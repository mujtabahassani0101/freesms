using System.Text.Json;

namespace FreeSms.Core;

public static class JsonFields
{
    public static string S(this JsonElement value, string key, string fallback = "") => value.ValueKind == JsonValueKind.Object && value.TryGetProperty(key, out var item) && item.ValueKind == JsonValueKind.String ? item.GetString()! : fallback;
    public static bool B(this JsonElement value, string key, bool fallback = false) => value.ValueKind == JsonValueKind.Object && value.TryGetProperty(key, out var item) && item.ValueKind is JsonValueKind.True or JsonValueKind.False ? item.GetBoolean() : fallback;
    public static int I(this JsonElement value, string key, int fallback = 0) => value.ValueKind == JsonValueKind.Object && value.TryGetProperty(key, out var item) && item.TryGetInt32(out var result) ? result : fallback;
    public static JsonElement Get(this JsonElement value, string key) => value.ValueKind == JsonValueKind.Object && value.TryGetProperty(key, out var item) ? item : default;
    public static JsonElement[] A(this JsonElement value, string key) => value.Get(key) is var item && item.ValueKind == JsonValueKind.Array ? item.EnumerateArray().ToArray() : [];
}

public sealed class FormCatalog
{
    public IReadOnlyList<JsonElement> Forms { get; }
    public IReadOnlyDictionary<string, JsonElement> ByName { get; }
    public IReadOnlyDictionary<string, JsonElement> ByClass { get; }
    public FormCatalog(string root)
    {
        Forms = JsonSerializer.Deserialize<JsonElement[]>(File.ReadAllText(Path.Combine(root, "native/assets/forms.json")))!;
        // A few legacy forms share a Name; retain Python's last-definition lookup.
        ByName = Forms.GroupBy(f => f.S("name"), StringComparer.Ordinal).ToDictionary(g => g.Key, g => g.Last(), StringComparer.Ordinal);
        ByClass = Forms.ToDictionary(f => f.S("class"), StringComparer.Ordinal);
    }
    public JsonElement? Target(JsonElement form, JsonElement control)
    {
        foreach (var target in form.Get("actions").A(control.S("click")))
            if (ByClass.TryGetValue(target.GetString()!, out var result)) return result;
        return null;
    }
}
