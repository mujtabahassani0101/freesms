namespace FreeSms.Core;

public sealed record Entity(string Table, string[] Fields, string[] Required, bool Year = false, (string Table, string Field)[]? References = null);

public sealed class EntityService(SchoolService school)
{
    public static readonly IReadOnlyDictionary<string, Entity> Entities = new Dictionary<string, Entity>
    {
        ["grades"] = new("tPaye", ["Name", "xMaghta"], ["Name"], References: [("tClass", "xpaye"), ("tYear_Student", "xPaye"), ("tBook", "xPaye")]),
        ["teachers"] = new("tTeacher", ["fNamF", "fNamL", "fEmail", "fPassword"], ["fNamF", "fNamL"], References: [("tTch_Cls", "xTch")]),
        ["drivers"] = new("tDriver", ["name", "mobil", "mobil2", "comment"], ["name"], References: [("tYear_Student", "xDriver")]),
        ["books"] = new("tBook", ["xPaye", "Name", "vahed", "timeWeek", "Type", "sort", "SortOneEntry", "codedars", "Vezarat"], ["Name", "xPaye"], References: [("tMark", "xbook"), ("tMarkAgo", "xbook"), ("tTch_Cls", "xLsn")]),
        ["discounts"] = new("tTakhfif", ["name", "comment"], ["name"], References: [("tYear_Student", "xTakhfif")]),
        ["exams"] = new("tExam", ["Name", "NumExam", "DateFrom", "DateTo", "term", "procc"], ["Name"], true, [("tMark", "Xtest"), ("tComnentKarname", "Xtest"), ("tMarkDoreh", "Xtest")]),
        ["year_days"] = new("tYearMaghtaCountDay", ["xMaghta", "Term1", "Term2"], ["xMaghta"], true),
        ["halls"] = new("tHozeh", ["Name", "Capacity"], ["Name"]),
        ["provinces"] = new("tOstan", ["Name"], ["Name"], References: [("tCity", "xOstan")]),
        ["cities"] = new("tCity", ["xOstan", "Name"], ["Name", "xOstan"], References: [("tStudent", "xCity"), ("tStudent", "xCityNow")]),
        ["grading"] = new("tTosif", ["fromMark", "toMark", "tosif", "tosifM", "term", "lev", "comment"], ["tosif"])
    };
    private Database Db => school.Db;
    public List<Record> List(string key)
    {
        var entity = Entities[key];
        return Db.Query("SELECT * FROM " + Database.Identifier(entity.Table) + (entity.Year ? " WHERE xYear=@p0" : "") + (key == "exams" ? " AND term=0" : "") + " ORDER BY id", entity.Year ? [school.Session.Year] : []);
    }
    public int Save(string key, Record submitted, int id = 0)
    {
        var entity = Entities[key];
        var columns = Db.Columns(entity.Table).ToDictionary(r => r.Text("name"), StringComparer.OrdinalIgnoreCase);
        var data = new Record();
        foreach (var field in entity.Fields.Where(submitted.ContainsKey))
        {
            var value = submitted.Value(field);
            data[field] = columns[field].Text("type") switch
            {
                "int" or "smallint" or "bigint" or "tinyint" => Values.Number(value),
                "bit" => Values.Boolean(value),
                "float" or "real" or "decimal" or "numeric" => Values.Text(value).Length == 0 ? null : double.TryParse(Values.Text(value), System.Globalization.CultureInfo.InvariantCulture, out var number) ? number : throw new ValidationException("مقدار عددی معتبر وارد کنید."),
                _ => Values.Text(value)
            };
        }
        if (entity.Required.Any(f => Values.Text(data.Value(f)).Length == 0)) throw new ValidationException("فیلدهای الزامی را تکمیل کنید.");
        if (entity.Year) data["xYear"] = school.Session.Year;
        if (key == "exams") { data["term"] = 0; data["procc"] = false; }
        if (key == "year_days")
        {
            if (new[] { "Term1", "Term2" }.Any(f => (Values.Number(data.Value(f)) ?? 0) < 0)) throw new ValidationException("تعداد ایام نمی‌تواند منفی باشد.");
            if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tYearMaghtaCountDay WHERE xYear=@p0 AND xMaghta=@p1 AND id<>@p2", [school.Session.Year, data.Value("xMaghta"), id])) > 0) throw new ValidationException("ایام این مقطع قبلاً ثبت شده است.");
        }
        if (key == "books" && Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tBook WHERE xPaye=@p0 AND id<>@p1 AND (Name=@p2 OR codedars=@p3)", [data.Value("xPaye"), id, data.Value("Name"), data.Value("codedars")])) > 0) throw new ValidationException("نام یا کد درس در این پایه تکراری است.");
        return Db.Transaction((c, t) =>
        {
            if (id > 0)
            {
                var assignments = data.Keys.Select((field, i) => Database.Identifier(field) + "=@p" + i);
                if (Db.Execute("UPDATE " + Database.Identifier(entity.Table) + " SET " + string.Join(',', assignments) + " WHERE id=@p" + data.Count, [.. data.Values, id], c, t) != 1) throw new ValidationException("رکورد انتخاب‌شده دیگر موجود نیست.");
            }
            else
            {
                if (!Values.Boolean(columns["id"].Value("is_identity")))
                    data["id"] = Values.Number(submitted.Value("id")) ?? Convert.ToInt32(Db.Scalar("SELECT ISNULL(MAX(id)+1,@p0) FROM " + Database.Identifier(entity.Table) + " WITH(UPDLOCK,HOLDLOCK)", [key == "teachers" ? 10000 : key == "exams" ? 101 : 1], c, t));
                id = Convert.ToInt32(Db.Scalar("INSERT INTO " + Database.Identifier(entity.Table) + "(" + string.Join(',', data.Keys.Select(Database.Identifier)) + ") OUTPUT INSERTED.id VALUES(" + string.Join(',', Enumerable.Range(0, data.Count).Select(i => "@p" + i)) + ")", data.Values.ToArray(), c, t));
            }
            if (key == "books") Db.Execute("UPDATE tExam SET procc=0 WHERE xYear=@p0", [school.Session.Year], c, t);
            return id;
        });
    }
    public void Delete(string key, int id)
    {
        var entity = Entities[key];
        Db.Transaction((c, t) =>
        {
            foreach (var (table, field) in entity.References ?? [])
                if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM " + Database.Identifier(table) + " WHERE " + Database.Identifier(field) + "=@p0", [id], c, t)) > 0)
                    throw new ValidationException("این رکورد در اطلاعات دیگر استفاده شده و قابل حذف نیست.");
            if (key == "halls") Db.Execute("UPDATE tYear_Student SET xHozeh=NULL,idx=NULL WHERE xHozeh=@p0", [id], c, t);
            return Db.Execute("DELETE FROM " + Database.Identifier(entity.Table) + " WHERE id=@p0", [id], c, t);
        });
    }
}
