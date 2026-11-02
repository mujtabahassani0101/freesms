using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace FreeSms.Reports;

public sealed class FormulaContext
{
    public DataRow? Row { get; init; }
    public IReadOnlyList<DataRow> Rows { get; init; } = [];
    public IReadOnlyDictionary<string, Formula> Formulas { get; init; } = new Dictionary<string, Formula>(StringComparer.OrdinalIgnoreCase);
    public IReadOnlyDictionary<string, object?> Parameters { get; init; } = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
    public IReadOnlyDictionary<string, Func<object?[], object?>> Functions { get; init; } = new Dictionary<string, Func<object?[], object?>>(StringComparer.OrdinalIgnoreCase);
    public Func<string, object?>? Special { get; init; }
    public Func<DataRow, FormulaContext>? RowFactory { get; init; }
    private readonly HashSet<string> evaluating = new(StringComparer.OrdinalIgnoreCase);
    public object? Field(string name)
    {
        name = name.Trim();
        if (name.StartsWith('@'))
        {
            name = name[1..];
            if (!Formulas.TryGetValue(name, out var formula)) throw new InvalidDataException("Missing report formula: " + name);
            if (!evaluating.Add(name)) throw new InvalidDataException("Recursive report formula: " + name);
            try { return formula.Evaluate(this); } finally { evaluating.Remove(name); }
        }
        if (name.StartsWith('?')) return Parameters.GetValueOrDefault(name[1..]);
        if (name.StartsWith('#')) return Special?.Invoke(name);
        string field = name[(name.LastIndexOf('.') + 1)..];
        if (Row == null) return null;
        if (!Row.Table.Columns.Contains(field)) throw new InvalidDataException("Missing report data field: " + name);
        var value = Row[field];
        return value == DBNull.Value ? null : value;
    }
    internal FormulaContext WithRow(DataRow row) => RowFactory?.Invoke(row) ?? new() { Row = row, Rows = Rows, Formulas = Formulas, Parameters = Parameters, Functions = Functions, Special = Special };
}

// Parses the expression language used by the recovered templates. No runtime
// compilation, scripting host, SQL execution or assembly loading is involved.
public sealed class Formula
{
    private readonly Node root;
    private Formula(Node root) { this.root = root; }
    public static Formula Parse(string text) => new(new Parser(text).Parse());
    public object? Evaluate(FormulaContext context) => root.Evaluate(context);
    public static string Text(object? value) => Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
    private static decimal Number(object? value) => value == null ? 0 : Convert.ToDecimal(value, CultureInfo.InvariantCulture);
    public static bool Boolean(object? value) => value != null && (value is bool flag ? flag : value is string s ? bool.TryParse(s, out var b) ? b : s.Length > 0 : Number(value) != 0);
    private abstract record Node { internal abstract object? Evaluate(FormulaContext context); }
    private sealed record Literal(object? Value) : Node { internal override object? Evaluate(FormulaContext context) => Value; }
    private sealed record FieldNode(string Name) : Node { internal override object? Evaluate(FormulaContext context) => context.Field(Name); }
    private sealed record NameNode(string Name) : Node { internal override object? Evaluate(FormulaContext context) => context.Special?.Invoke(Name); }
    private sealed record Conditional(Node Condition, Node True, Node False) : Node
    {
        internal override object? Evaluate(FormulaContext context) => (Boolean(Condition.Evaluate(context)) ? True : False).Evaluate(context);
    }
    private sealed record Unary(string Operator, Node Value) : Node
    {
        internal override object? Evaluate(FormulaContext context) => Operator == "not" ? !Boolean(Value.Evaluate(context)) : Operator == "-" ? -Number(Value.Evaluate(context)) : Number(Value.Evaluate(context));
    }
    private sealed record Binary(string Operator, Node Left, Node Right) : Node
    {
        internal override object? Evaluate(FormulaContext context)
        {
            var left = Left.Evaluate(context);
            if (Operator == "and" && !Boolean(left)) return false;
            if (Operator == "or" && Boolean(left)) return true;
            var right = Right.Evaluate(context);
            if (Operator == "&" || (Operator == "+" && (left is string || right is string))) return Text(left) + Text(right);
            if (Operator is "=" or "<>" or "<" or ">" or "<=" or ">=")
            {
                if (left == null || right == null) return false;
                int compare = decimal.TryParse(Text(left), NumberStyles.Number, CultureInfo.InvariantCulture, out var a) && decimal.TryParse(Text(right), NumberStyles.Number, CultureInfo.InvariantCulture, out var b) ? a.CompareTo(b) : string.Compare(Text(left), Text(right), StringComparison.Ordinal);
                return Operator switch { "=" => compare == 0, "<>" => compare != 0, "<" => compare < 0, ">" => compare > 0, "<=" => compare <= 0, _ => compare >= 0 };
            }
            return Operator switch
            {
                "+" => Number(left) + Number(right), "-" => Number(left) - Number(right), "*" => Number(left) * Number(right), "/" => Number(left) / Number(right),
                "mod" => Number(left) % Number(right), "and" => Boolean(right), "or" => Boolean(right),
                _ => throw new InvalidDataException("Unsupported report operator: " + Operator)
            };
        }
    }
    private sealed record Call(string Name, Node[] Args) : Node
    {
        internal override object? Evaluate(FormulaContext context)
        {
            if (Name is "sum" or "average" or "count" or "maximum" or "minimum")
            {
                var rows = context.Rows.AsEnumerable();
                if (Args.Length > 1)
                {
                    var group = Args[1].Evaluate(context);
                    rows = rows.Where(row => Equals(Args[1].Evaluate(context.WithRow(row)), group));
                }
                var values = rows.Select(row => Args[0].Evaluate(context.WithRow(row))).Where(v => v != null).ToArray();
                if (Name == "count") return values.Length;
                if (values.Length == 0) return null;
                return Name switch { "sum" => values.Sum(Number), "average" => values.Average(Number), "maximum" => values.Max(Number), _ => values.Min(Number) };
            }
            object?[] args = Args.Select(a => a.Evaluate(context)).ToArray();
            string S(int i) => Text(args[i]);
            int I(int i) => (int)Number(args[i]);
            switch (Name)
            {
                case "color": return unchecked((int)(0xff000000u | ((uint)I(0) << 16) | ((uint)I(1) << 8) | (uint)I(2)));
                case "isnull": return args[0] == null;
                case "totext":
                    if (args[0] is string || args[0] is DateTime || args[0] is bool) return Text(args[0]);
                    if (args[0] == null) return "";
                    decimal n = Number(args[0]);
                    int digits = args.Length > 1 ? I(1) : 2;
                    if (digits < 0 || digits > 20) throw new InvalidDataException("Invalid report decimal precision.");
                    var culture = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                    if (args.Length > 2) culture.NumberGroupSeparator = S(2);
                    return decimal.Round(Math.Abs(n), digits, MidpointRounding.AwayFromZero).ToString("N" + digits, culture) + (n < 0 ? "-" : "");
                case "tonumber": return decimal.Parse(S(0), NumberStyles.Number, CultureInfo.InvariantCulture);
                case "replace": return S(0).Replace(S(1), S(2), StringComparison.Ordinal);
                case "right": return S(0)[Math.Max(0, S(0).Length - Math.Max(0, I(1)))..];
                case "left": return S(0)[..Math.Min(S(0).Length, Math.Max(0, I(1)))];
                case "mid":
                    int start = Math.Clamp(I(1) - 1, 0, S(0).Length);
                    return S(0).Substring(start, args.Length > 2 ? Math.Clamp(I(2), 0, S(0).Length - start) : S(0).Length - start);
                case "len": return S(0).Length;
                case "groupname": return args[0];
                case "round": return decimal.Round(Number(args[0]), args.Length > 1 ? I(1) : 0, MidpointRounding.AwayFromZero);
                default:
                    if (context.Functions.TryGetValue(Name, out var function)) return function(args);
                    throw new InvalidDataException("Unsupported report function: " + Name);
            }
        }
    }
    private sealed class Parser
    {
        private readonly string text;
        private int position;
        private string token = "";
        private string kind = "";
        internal Parser(string text) { this.text = text; Next(); }
        internal Node Parse() { if (kind == "end") return new Literal(null); var result = Expression(); if (kind != "end") throw Error("Unexpected token " + token); return result; }
        private InvalidDataException Error(string message) => new(message + " at offset " + position + ": " + text);
        private bool Take(string value) { if (!token.Equals(value, StringComparison.OrdinalIgnoreCase) || kind == "string" || kind == "field") return false; Next(); return true; }
        private void Require(string value) { if (!Take(value)) throw Error("Expected " + value); }
        private Node Expression(int minimum = 0)
        {
            Node left;
            if (Take("if"))
            {
                var condition = Expression(); Require("then"); var yes = Expression(); var no = Take("else") ? Expression() : new Literal(null);
                left = new Conditional(condition, yes, no);
            }
            else if (kind == "symbol" && token is "+" or "-" || kind == "name" && token.Equals("not", StringComparison.OrdinalIgnoreCase)) { string op = token.ToLowerInvariant(); Next(); left = new Unary(op, Expression(7)); }
            else if (Take("(")) { left = Expression(); Require(")"); }
            else if (kind == "string") { left = new Literal(token); Next(); }
            else if (kind == "number") { left = new Literal(decimal.Parse(token, NumberStyles.Float, CultureInfo.InvariantCulture)); Next(); }
            else if (kind == "field") { left = new FieldNode(token); Next(); }
            else if (kind == "name")
            {
                string name = token.ToLowerInvariant(); Next();
                if (Take("("))
                {
                    var args = new List<Node>();
                    if (!Take(")")) { do { args.Add(Expression()); } while (Take(",")); Require(")"); }
                    left = new Call(name, args.ToArray());
                }
                else left = name is "true" or "false" ? new Literal(name == "true") : new NameNode(name);
            }
            else throw Error("Expected expression");
            while (kind is "name" or "symbol")
            {
                string op = token.ToLowerInvariant();
                int priority = op switch { "or" => 1, "and" => 2, "=" or "<>" or "<" or ">" or "<=" or ">=" => 3, "+" or "-" or "&" => 4, "*" or "/" or "mod" => 5, _ => -1 };
                if (priority < minimum) break;
                Next(); left = new Binary(op, left, Expression(priority + 1));
            }
            return left;
        }
        private void Next()
        {
            while (position < text.Length)
            {
                if (char.IsWhiteSpace(text[position])) { position++; continue; }
                if (position + 1 < text.Length && text[position] == '/' && text[position + 1] == '/') { while (position < text.Length && text[position] != '\n') position++; continue; }
                break;
            }
            if (position >= text.Length) { kind = "end"; token = ""; return; }
            char c = text[position++];
            if (c is '\'' or '"')
            {
                kind = "string"; var builder = new StringBuilder(); bool closed = false;
                while (position < text.Length)
                {
                    char next = text[position++];
                    if (next == c) { if (position < text.Length && text[position] == c) { position++; builder.Append(c); } else { closed = true; break; } }
                    else builder.Append(next);
                }
                if (!closed) throw Error("Unclosed string"); token = builder.ToString(); return;
            }
            if (c == '{')
            {
                int start = position; while (position < text.Length && text[position] != '}') position++;
                if (position == text.Length) throw Error("Unclosed field"); token = text[start..position++]; kind = "field"; return;
            }
            if (char.IsDigit(c) || c == '.' && position < text.Length && char.IsDigit(text[position]))
            {
                int start = position - 1; while (position < text.Length && (char.IsDigit(text[position]) || text[position] == '.')) position++;
                token = text[start..position]; kind = "number"; return;
            }
            if (char.IsLetter(c) || c == '_')
            {
                int start = position - 1; while (position < text.Length && (char.IsLetterOrDigit(text[position]) || text[position] == '_')) position++;
                token = text[start..position]; kind = "name"; return;
            }
            token = c.ToString(); kind = "symbol";
            if (position < text.Length && (c == '<' && text[position] is '=' or '>' || c == '>' && text[position] == '=')) token += text[position++];
        }
    }
}
