using System.Data;

namespace FreeSms.Core;

public sealed class Session(int year, string username = "admin")
{
    public int Year { get; set; } = year;
    public string Username { get; } = username;
}

public sealed class SchoolService(Database database, Session session)
{
    public Database Db { get; } = database;
    public Session Session { get; } = session;

    public Record School() => Db.Query("SELECT TOP 1 * FROM tParmetr").FirstOrDefault() ?? new();
    public void SaveSchool(Record values)
    {
        if (Values.Text(values.Value("sch")).Length == 0) throw new ValidationException("نام مکتب را وارد کنید.");
        Db.Transaction((c, t) =>
        {
            Db.Execute("IF EXISTS(SELECT 1 FROM tParmetr) UPDATE tParmetr SET Ost=@p0,cty=@p1,sch=@p2,Foter1=@p3 ELSE INSERT INTO tParmetr(Ost,cty,sch,Foter1) VALUES(@p0,@p1,@p2,@p3)",
                [Values.Text(values.Value("Ost")), Values.Text(values.Value("cty")), Values.Text(values.Value("sch")), Values.Text(values.Value("Foter1"))], c, t);
            return 0;
        });
    }
    public List<Record> Choices(string source, object? grade = null, object? parent = null) => source switch
    {
        "grades" => Db.Query("SELECT id,Name AS name,xMaghta FROM tPaye ORDER BY id"),
        "levels" => Db.Query("SELECT id,name FROM tMaghta ORDER BY id"),
        "classes" => Db.Query("SELECT id,name,xpaye FROM tClass WHERE xYear=@p0" + (grade is null ? "" : " AND xpaye=@p1") + " ORDER BY sortRpt,id", grade is null ? [Session.Year] : [Session.Year, grade]),
        "teachers" => Db.Query("SELECT id,fNamF+N' '+fNamL AS name FROM tTeacher ORDER BY fNamL,fNamF"),
        "books" => Db.Query("SELECT id,Name AS name,xPaye,vahed FROM tBook" + (grade is null ? "" : " WHERE xPaye=@p0") + " ORDER BY sort,id", grade is null ? [] : [grade]),
        "drivers" => Db.Query("SELECT id,name FROM tDriver ORDER BY name"),
        "discounts" => Db.Query("SELECT id,name FROM tTakhfif ORDER BY name"),
        "provinces" => Db.Query("SELECT id,Name AS name FROM tOstan ORDER BY Name"),
        "cities" => Db.Query("SELECT id,Name AS name,xOstan FROM tCity" + (parent is null ? "" : " WHERE xOstan=@p0") + " ORDER BY Name", parent is null ? [] : [parent]),
        "exams" => Db.Query("SELECT id,Name AS name,term FROM tExam WHERE xYear=@p0 ORDER BY NumExam,id", [Session.Year]),
        _ => throw new ArgumentException("Unknown choice source: " + source)
    };
    public List<Record> Classes() => Db.Query("SELECT c.*,p.Name AS Paye,CASE c.shift WHEN 1 THEN N'صبح' WHEN 2 THEN N'عصر' END AS shifttext FROM tClass c JOIN tPaye p ON p.id=c.xpaye WHERE c.xYear=@p0 ORDER BY c.sortRpt,c.id", [Session.Year]);
    public bool ClassNameExists(string name,int id=0) => Convert.ToInt32(Db.Scalar(
        "SELECT COUNT(*) FROM tClass WHERE xYear=@p0 AND id<>@p1 AND REPLACE(REPLACE(REPLACE(name,N' ',N''),N'ي',N'ی'),N'ك',N'ک')=REPLACE(REPLACE(REPLACE(@p2,N' ',N''),N'ي',N'ی'),N'ك',N'ک')",
        [Session.Year,id,name]))>0;
    public int SaveClass(Record values, int id = 0)
    {
        var name = Values.Text(values.Value("name"));
        var grade = Values.Number(values.Value("xpaye"));
        if (name.Length == 0 || grade is null) throw new ValidationException("نام صنف و پایه را مشخص کنید.");
        if(ClassNameExists(name,id))throw new ValidationException("نام صنف تکراری است.");
        var output = Db.Call("sp_tClass_insertUpdate", new()
        {
            ["id"] = id, ["xYear"] = Session.Year, ["xpaye"] = grade, ["name"] = name,
            ["answerable"] = Values.Text(values.Value("answerable")), ["fee"] = Values.Number(values.Value("fee"), 0) ?? 0,
            ["shift"] = Values.Number(values.Value("shift")) ?? 0, ["sortRpt"] = Values.Number(values.Value("sortRpt"), 0, 32767) ?? 0
        }).Output;
        if (output.Int("code") < 0) throw new ValidationException(output.Int("code") == -100 ? "نام صنف تکراری است." : "ترتیب نمایش صنف تکراری است.");
        return id > 0 ? id : Convert.ToInt32(Db.Scalar("SELECT id FROM tClass WHERE xYear=@p0 AND REPLACE(name,N' ',N'')=REPLACE(@p1,N' ',N'')", [Session.Year, name]));
    }
    public List<Record> Students(Record? filters = null)
    {
        filters ??= new();
        var where = new List<string> { "y.xYear=@p0" };
        var values = new List<object?> { Session.Year };
        foreach (var (key, column) in new[] { ("grade", "y.xPaye"), ("class", "y.xClass"), ("status", "y.Status"), ("gender", "s.Jens"), ("code", "s.Code"), ("number_asas", "s.NumberAsas"), ("discount_code", "y.codeTakhfif") })
            if (Values.Text(filters.Value(key)).Length > 0) { where.Add(column + "=@p" + values.Count); values.Add(key=="code"?(object?)Values.LongNumber(filters.Value(key)):Values.Number(filters.Value(key))); }
        foreach (var (key, column) in new[] { ("first_name", "s.FName"), ("father_name", "s.LName"), ("last_name", "s.LastName") })
            if (Values.Text(filters.Value(key)).Length > 0) { where.Add(column + " LIKE @p" + values.Count); values.Add("%" + Values.Text(filters.Value(key)) + "%"); }
        return Db.Query("SELECT s.id,s.Code,s.FName,s.LName,s.PName,s.LastName,s.NumberAsas,s.bDate,s.bDateM,s.Sh_Sh,s.En_Fname,s.En_LastName,s.En_Lname,s.Jens,s.MobileFather,s.MobileMother,s.NumberTelegram,y.Status,y.xClass,y.xPaye,c.name AS class,p.Name AS Paye,y.xYear,y.SumFee,y.Sumtransport,y.xTakhfif,y.xDriver,y.codeTakhfif,y.shaghe,y.hazer,y.mali,CASE y.Status WHEN 1 THEN N'برحال' WHEN 2 THEN N'محروم' WHEN 3 THEN N'منفک' WHEN 4 THEN N'معذرتی' END AS vazeyat FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id LEFT JOIN tClass c ON c.id=y.xClass LEFT JOIN tPaye p ON p.id=y.xPaye WHERE " + string.Join(" AND ", where) + " ORDER BY s.FName,s.LName,s.id", values.ToArray());
    }
    public Record? Student(int id)
    {
        var row = Db.Query("SELECT s.*,y.* FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id WHERE s.id=@p0 AND y.xYear=@p1", [id, Session.Year]).FirstOrDefault();
        if (row is not null) row["id"] = id;
        return row;
    }
    public int SaveStudent(Record data, int id = 0)
    {
        if (Values.Text(data.Value("FName")).Length == 0) throw new ValidationException("نام شاگرد را وارد کنید.");
        if (Values.Text(data.Value("LName")).Length == 0) throw new ValidationException("ولد / بنت را وارد کنید.");
        var grade = Values.Number(data.Value("xPaye"));
        var classroom = Values.Number(data.Value("xClass"));
        if (grade is null || classroom is null) throw new ValidationException("پایه و صنف شاگرد را مشخص کنید.");
        if (Convert.ToInt32(Db.Scalar("SELECT xpaye FROM tClass WHERE id=@p0 AND xYear=@p1", [classroom, Session.Year])) != grade)
            throw new ValidationException("صنف انتخاب‌شده با پایه و سال تعلیمی مطابقت ندارد.");
        var inputs = new Record();
        foreach (var field in Db.Parameters("sp_tStudent_insertUpdate").Where(p => p.Direction == ParameterDirection.Input))
        {
            var key = field.ParameterName.TrimStart('@');
            object? value = data.Value(key);
            if (key.Equals("id", StringComparison.OrdinalIgnoreCase)) value = id;
            else if (key.Equals("xYear", StringComparison.OrdinalIgnoreCase)) value = Session.Year;
            else if (field.SqlDbType == SqlDbType.Bit) value = value is null ? new[] { "shaghe", "hazer", "mali" }.Contains(key, StringComparer.OrdinalIgnoreCase) : Values.Boolean(value);
            else if(field.SqlDbType==SqlDbType.BigInt)value=Values.LongNumber(value);
            else if (field.SqlDbType is SqlDbType.Int or SqlDbType.SmallInt) value = Values.Number(value) ?? (key.StartsWith("fee", StringComparison.OrdinalIgnoreCase) || key.StartsWith("transport", StringComparison.OrdinalIgnoreCase) ? 0 : null);
            else if (field.SqlDbType is SqlDbType.NVarChar or SqlDbType.VarChar) value = Values.Text(value) is var text && text.Length > 0 ? text : null;
            inputs[key] = value;
        }
        foreach (var (prefix, total) in new[] { ("Fee", "SumFee"), ("transport", "Sumtransport") })
        {
            var amounts = Enumerable.Range(1, 9).Select(i => Values.Number(inputs.Value(prefix + i)) ?? 0).ToArray();
            if (amounts.Any(a => a < 0)) throw new ValidationException("مبلغ فیس و ترانسپورت نمی‌تواند منفی باشد.");
            long sum=amounts.Sum(amount=>(long)amount);
            if(sum>int.MaxValue)throw new ValidationException("مجموع مبلغ فیس یا ترانسپورت خارج از محدودهٔ مجاز است");
            inputs[total]=(int)sum;
        }
        inputs["xPaye"] = grade; inputs["xClass"] = classroom;
        return Db.Transaction((c, t) =>
        {
            var code = Db.Call("sp_tStudent_insertUpdate", inputs, c, t).Output.Int("CodeOut");
            if (code == -100) throw new ValidationException("کد متعلم تکراری است.");
            if (code == -200) throw new ValidationException("نمبر اساس تکراری است.");
            var saved = id > 0 ? id : code;
            if (saved <= 0) throw new InvalidOperationException("شناسهٔ شاگرد از بانک دریافت نشد.");
            Db.Execute("UPDATE tExam SET procc=0 WHERE xYear=@p0", [Session.Year], c, t);
            if (data.ContainsKey("Student_img")) Db.Call("sp_tStudentImg_InsertUpdate", new() { ["id"] = saved, ["img"] = data.Value("Student_img") }, c, t);
            return saved;
        });
    }
    public byte[]? StudentImage(int id) => Db.Scalar("SELECT Student_img FROM tStudentImg WHERE xStudent=@p0", [id]) as byte[];
    public void DeleteClass(int id) => Db.Transaction((connection,transaction) =>
    {
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tClass WHERE id=@p0 AND xYear=@p1", [id,Session.Year],connection,transaction))!=1)
            throw new ValidationException("صنف در سال تعلیمی انتخاب‌شده یافت نشد.");
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tYear_Student WHERE xClass=@p0", [id],connection,transaction)) > 0)
            throw new ValidationException("این صنف شاگرد دارد و قابل حذف نیست.");
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tTch_Cls WHERE xCls=@p0", [id],connection,transaction)) > 0)
            throw new ValidationException("این صنف ارتباط معلم و مضمون دارد؛ ابتدا ارتباط‌ها را حذف کنید.");
        return Db.Execute("DELETE FROM tClass WHERE id=@p0 AND xYear=@p1", [id, Session.Year],connection,transaction);
    });
    public void DeleteStudent(int id) => Db.Transaction((c, t) =>
    {
        Db.Execute("UPDATE tExam SET procc=0 WHERE id IN(SELECT Xtest FROM tMarkDoreh WHERE xStudent=@p0)", [id], c, t);
        if (Db.Scalar("SELECT OBJECT_ID(N'dbo.tDisciplinaryStudent',N'U')", connection: c, transaction: t) is not null)
            Db.Execute("DELETE FROM dbo.tDisciplinaryStudent WHERE xStudent=@p0", [id], c, t);
        foreach (var table in new[] { "tPaymentStudent", "tMark", "tMarkDoreh", "tMarkAgo", "tHazeriAgo", "tEnzebat", "tComnentKarname", "tComnentStd", "tStudentImg", "tYear_Student" })
            Db.Execute("DELETE FROM " + Database.Identifier(table) + " WHERE xStudent=@p0", [id], c, t);
        return Db.Execute("DELETE FROM tStudent WHERE id=@p0", [id], c, t);
    });
    public void SetYear(int year)
    {
        _ = Values.Number(year, 1300, 1600);
        Db.Call("Sp_SetDefYear", new() { ["xYear"] = year });
        Session.Year = year;
    }
    public List<Record> TeacherAssignments(object? classroom = null, object? teacher = null)
    {
        var values = new List<object?> { Session.Year };
        var where = "c.xYear=@p0";
        if (classroom is not null) { where += " AND a.xCls=@p" + values.Count; values.Add(classroom); }
        if (teacher is not null) { where += " AND a.xTch=@p" + values.Count; values.Add(teacher); }
        return Db.Query("SELECT a.xCls,a.xLsn,a.xTch,t.fNamF+N' '+t.fNamL AS tch,b.Name AS lsn,p.Name AS Paye,c.name AS cls FROM tTch_Cls a JOIN tTeacher t ON t.id=a.xTch JOIN tBook b ON b.id=a.xLsn JOIN tPaye p ON p.id=b.xPaye JOIN tClass c ON c.id=a.xCls WHERE " + where + " ORDER BY p.id,c.id,b.sort", values.ToArray());
    }
    public void AssignTeacher(object? classroom, object? book, object? teacher)
    {
        if (classroom is null || book is null || teacher is null) throw new ValidationException("صنف، درس و معلم را انتخاب کنید.");
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tClass c JOIN tBook b ON b.xPaye=c.xpaye WHERE c.id=@p0 AND b.id=@p1 AND c.xYear=@p2", [classroom, book, Session.Year])) == 0) throw new ValidationException("درس با پایهٔ صنف مطابقت ندارد.");
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tTeacher WHERE id=@p0", [teacher])) == 0) throw new ValidationException("معلم انتخاب‌شده موجود نیست.");
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM tTch_Cls WHERE xCls=@p0 AND xLsn=@p1", [classroom, book])) > 0) throw new ValidationException("برای این درس و صنف قبلاً معلم تعیین شده است.");
        Db.Execute("INSERT INTO tTch_Cls(xCls,xLsn,xTch) VALUES(@p0,@p1,@p2)", [classroom, book, teacher]);
    }
    public void UnassignTeacher(object? classroom, object? book) => Db.Execute("DELETE FROM tTch_Cls WHERE xCls=@p0 AND xLsn=@p1", [classroom, book]);
}
