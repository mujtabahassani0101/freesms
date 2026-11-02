using System.Collections.Concurrent;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace FreeSms.Core;

public sealed record ProcedureResult(List<List<Record>> Sets, Record Output);

public sealed partial class Database(string connectionString)
{
    private readonly ConcurrentDictionary<string, SqlParameter[]> procedureParameters = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, List<Record>> columns = new(StringComparer.OrdinalIgnoreCase);
    public string ConnectionString { get; } = new SqlConnectionStringBuilder(connectionString) { Pooling = true }.ConnectionString;

    public SqlConnection Open(string? catalog = null)
    {
        var builder = new SqlConnectionStringBuilder(ConnectionString);
        if (catalog is not null) builder.InitialCatalog = catalog;
        var connection = new SqlConnection(builder.ConnectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }

    public List<Record> Query(string sql, object?[]? values = null, SqlConnection? connection = null, SqlTransaction? transaction = null)
    {
        using var owned = connection is null ? Open() : null;
        using var command = Command(connection ?? owned!, transaction, sql, values);
        using var reader = command.ExecuteReader();
        return Read(reader);
    }

    public object? Scalar(string sql, object?[]? values = null, SqlConnection? connection = null, SqlTransaction? transaction = null)
    {
        using var owned = connection is null ? Open() : null;
        using var command = Command(connection ?? owned!, transaction, sql, values);
        var result = command.ExecuteScalar();
        return result is DBNull ? null : result;
    }

    public int Execute(string sql, object?[]? values = null, SqlConnection? connection = null, SqlTransaction? transaction = null)
    {
        using var owned = connection is null ? Open() : null;
        using var command = Command(connection ?? owned!, transaction, sql, values);
        return command.ExecuteNonQuery();
    }

    public T Transaction<T>(Func<SqlConnection, SqlTransaction, T> action)
    {
        using var connection = Open();
        using var transaction = connection.BeginTransaction();
        try { var result = action(connection, transaction); transaction.Commit(); return result; }
        catch { transaction.Rollback(); throw; }
    }

    public SqlParameter[] Parameters(string name) => procedureParameters.GetOrAdd(name, key =>
    {
        using var connection = Open();
        using var command = new SqlCommand(Identifier(key), connection) { CommandType = CommandType.StoredProcedure, CommandTimeout = 60 };
        SqlCommandBuilder.DeriveParameters(command);
        return command.Parameters.Cast<SqlParameter>().Where(p => p.Direction != ParameterDirection.ReturnValue).ToArray();
    });

    public List<Record> Columns(string table) => columns.GetOrAdd(table, key => Query(
        "SELECT c.name,TYPE_NAME(c.user_type_id) AS type,c.is_identity FROM sys.columns c WHERE c.object_id=OBJECT_ID(@p0)", [key]));

    public ProcedureResult Call(string name, Record values, SqlConnection? connection = null, SqlTransaction? transaction = null)
    {
        var metadata = Parameters(name);
        var expected = metadata.Where(p => p.Direction == ParameterDirection.Input).Select(p => p.ParameterName.TrimStart('@')).ToHashSet(StringComparer.OrdinalIgnoreCase);
        if (!expected.SetEquals(values.Keys)) throw new ArgumentException("پارامترهای رویه کامل یا معتبر نیست: " + name);
        using var owned = connection is null ? Open() : null;
        using var command = new SqlCommand(Identifier(name), connection ?? owned!, transaction) { CommandType = CommandType.StoredProcedure, CommandTimeout = 60 };
        foreach (var template in metadata)
        {
            var parameter = (SqlParameter)((ICloneable)template).Clone();
            if (parameter.Direction == ParameterDirection.Input) parameter.Value = values.Value(parameter.ParameterName.TrimStart('@')) ?? DBNull.Value;
            else { parameter.Direction = ParameterDirection.Output; parameter.Value = DBNull.Value; }
            command.Parameters.Add(parameter);
        }
        var sets = new List<List<Record>>();
        using (var reader = command.ExecuteReader())
            do { if (reader.FieldCount > 0) sets.Add(Read(reader)); } while (reader.NextResult());
        var output = new Record();
        foreach (SqlParameter parameter in command.Parameters)
            if (parameter.Direction != ParameterDirection.Input)
                output[parameter.ParameterName.TrimStart('@')] = parameter.Value is DBNull ? null : parameter.Value;
        return new(sets, output);
    }

    public static string Identifier(string value)
    {
        if (!IdentifierPattern().IsMatch(value)) throw new ArgumentException("Invalid SQL identifier");
        return string.Join('.', value.Split('.').Select(part => "[" + part + "]"));
    }

    [GeneratedRegex(@"^[A-Za-z_][A-Za-z0-9_]*(\.[A-Za-z_][A-Za-z0-9_]*)*$", RegexOptions.CultureInvariant)]
    private static partial Regex IdentifierPattern();

    private static SqlCommand Command(SqlConnection connection, SqlTransaction? transaction, string sql, object?[]? values)
    {
        var command = new SqlCommand(sql, connection, transaction) { CommandTimeout = 60 };
        for (var i = 0; i < (values?.Length ?? 0); i++)
        {
            var value = values![i];
            var type = value switch
            {
                bool => SqlDbType.Bit, int => SqlDbType.Int, long => SqlDbType.BigInt, short => SqlDbType.SmallInt,
                byte[] => SqlDbType.VarBinary, decimal => SqlDbType.Decimal, double => SqlDbType.Float,
                _ => SqlDbType.NVarChar
            };
            var parameter = command.Parameters.Add("@p" + i, type);
            if (type == SqlDbType.NVarChar) parameter.Size = value is string text && text.Length > 4000 ? -1 : 4000;
            if (type == SqlDbType.VarBinary) parameter.Size = -1;
            parameter.Value = value ?? DBNull.Value;
        }
        return command;
    }

    private static List<Record> Read(SqlDataReader reader)
    {
        var rows = new List<Record>();
        while (reader.Read())
        {
            var row = new Record();
            for (var i = 0; i < reader.FieldCount; i++) row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
            rows.Add(row);
        }
        return rows;
    }
}
