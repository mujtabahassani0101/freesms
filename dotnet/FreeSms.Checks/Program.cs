using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using FreeSms.Core;

var position = Array.IndexOf(args, "--root");
var root = Path.GetFullPath(position >= 0 && position + 1 < args.Length ? args[position + 1] : "..");
var passed = 0;
void Check(string title, Action assertion)
{
    assertion(); passed++; Console.WriteLine("PASS " + title);
}
void Require(bool condition, string message = "Assertion failed") { if (!condition) throw new Exception(message); }
void Reject(Action action, string? message = null)
{
    try { action(); } catch (ValidationException error) { if (message is not null) Require(error.Message.Contains(message), error.Message); return; }
    throw new Exception("Expected validation failure");
}
try
{
    Check("Persian and Arabic digits, zero, null and bounds", () =>
    {
        Require(Values.Number("۱۲٣۴") == 1234 && Values.Number("۰") == 0 && Values.Number("") is null);
        Reject(() => Values.Number("not-a-number")); Reject(() => Values.Number(-1, 0));
        Require(Values.Text("  علي كابل  ") == "علی کابل");
    });
    Check("Legacy version codec agrees with the Python fixture", () =>
    {
        const string fixture = "VkFCV0FGSUFVZ0JrQURBQU1RQndBRThBU0FCb0FFNEFWUUI2QUdnQU5BQlVBREVBUlFBNUFGQUFVUUE5QUQwQQ==";
        Require(Migrations.EncodeVersion("1402/11/19") == fixture);
        Require(Migrations.DecodeVersion(fixture) == "1402/11/19");
        var escaped = Convert.ToBase64String(Encoding.ASCII.GetBytes("MTQwMi8xMS8xOQ+AD0APQ-"));
        escaped = Convert.ToBase64String(Encoding.Unicode.GetBytes(escaped));
        escaped = Convert.ToBase64String(Encoding.ASCII.GetBytes(escaped));
        Require(Migrations.DecodeVersion(escaped) == "1402/11/19");
        Require(Migrations.Version("txt980614.Text") == "1398/06/14");
    });
    Check("SQL GO batches, comments and blank lines", () => Require(Migrations.Batches("SELECT 1\r\nGO -- next\r\nSELECT 2\n go\n").Count() == 2));
    var catalog = new FormCatalog(root);
    Check("All recovered forms and the school menu route", () =>
    {
        Require(catalog.Forms.Count == 89);
        var main = catalog.ByName["frmMain"];
        var item = main.A("controls").First(c => c.S("name") == "toolfrmSchool");
        Require(catalog.Target(main, item)?.S("name") == "frmSchool");
        foreach (var form in catalog.Forms) Require(form.A("controls").Select(c => c.S("variable")).Distinct().Count() == form.A("controls").Length);
    });
    Check("All SQL resource hashes verified", () =>
    {
        var resources = JsonSerializer.Deserialize<JsonElement[]>(File.ReadAllText(Path.Combine(root, "analysis/sql-resources/index.json")))!;
        Require(resources.Length == 44);
        foreach (var resource in resources)
        {
            var text = File.ReadAllText(Path.Combine(root, resource.S("file")), Encoding.UTF8).Replace("\r\n", "\n");
            Require(Convert.ToHexStringLower(System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes(text))) == resource.S("sha256"));
        }
    });
    if (args.Contains("--integration"))
    {
        var suffix = Guid.NewGuid().ToString("N")[..10];
        var container = "free-sms-dotnet-check-" + suffix;
        var listener = new TcpListener(IPAddress.Loopback, 0); listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port; listener.Stop();
        var options = new DatabaseOptions(Path.Combine(root, "validation/dotnet-data", suffix), container, container + "-data", port, "free_sms_check_" + suffix);
        try
        {
            var db = await Bootstrapper.OpenAsync(root, options);
            Migrations.Apply(db, root);
            Check("Database migrations reach the target version and are idempotent", () =>
            {
                Require(Migrations.DecodeVersion(Convert.ToString(db.Scalar("SELECT ver FROM tVer"))) == Migrations.LatestVersion);
                Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM sys.tables")) == 53);
                var before = db.Scalar("SELECT COUNT(*) FROM native_migrations"); Migrations.Apply(db, root);
                Require(Equals(before, db.Scalar("SELECT COUNT(*) FROM native_migrations")));
            });
            var school = new SchoolService(db, new Session(1410)); var entities = new EntityService(school);
            Check("School details round trip Persian text and apostrophes", () =>
            {
                school.SaveSchool(new() { ["sch"] = "مکتب ' آزمایشی", ["Ost"] = "کابل", ["cty"] = "مرکز" });
                Require(school.School().Text("sch") == "مکتب ' آزمایشی"); Reject(() => school.SaveSchool(new()));
            });
            Check("School year creates exactly three terms", () =>
            {
                school.SetYear(1410); school.SetYear(1410);
                Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tExam WHERE xYear=1410 AND term IN(1,2,3)")) == 3);
            });
            var classroom = school.SaveClass(new() { ["name"] = "صنف آزمون .NET", ["xpaye"] = 1, ["fee"] = 1000, ["shift"] = 1, ["sortRpt"] = 30000 });
            Record Student(int code) => new()
            {
                ["FName"] = "فاطمه", ["LName"] = "کریم", ["PName"] = "احمد", ["LastName"] = "حسینی ' آزمون", ["Code"] = code,
                ["NumberAsas"] = code, ["xPaye"] = 1, ["xClass"] = classroom, ["Status"] = 1, ["Jens"] = 0,
                ["Fee1"] = 1200, ["Fee2"] = 500, ["transport1"] = 100
            };
            var first = Student(991001); var image = File.ReadAllBytes(Path.Combine(root, "native/assets/asdat_btnAcp_Image.png")); first["Student_img"] = image;
            var student = school.SaveStudent(first);
            Check("Student registration, zero gender, totals, photo and filters", () =>
            {
                var saved = school.Student(student)!;
                Require(saved.Int("id") == student && saved.Int("SumFee") == 1700 && saved.Int("Sumtransport") == 100);
                Require(saved.Int("Jens") == 0 && Values.Boolean(saved.Value("hazer")));
                Require(school.StudentImage(student)!.SequenceEqual(image));
                Require(school.Students(new() { ["code"] = "۹۹۱۰۰۱", ["gender"] = 0 }).Single().Int("id") == student);
                Require(school.Students(new() { ["first_name"] = "'; DROP TABLE tStudent;--" }).Count == 0);
            });
            Check("Student update recalculates sums and retains the record identifier", () =>
            {
                first["Fee1"] = 900; first["Fee2"] = 10;
                Require(school.SaveStudent(first, student) == student && school.Student(student)!.Int("SumFee") == 910);
            });
            Check("Duplicate codes and enrolment numbers fail without partial inserts", () =>
            {
                var before = db.Scalar("SELECT COUNT(*) FROM tStudent");
                Reject(() => school.SaveStudent(first), "کد متعلم");
                var duplicate = Student(991002); duplicate["NumberAsas"] = 991001;
                Reject(() => school.SaveStudent(duplicate), "نمبر اساس");
                Require(Equals(before, db.Scalar("SELECT COUNT(*) FROM tStudent")));
            });
            Check("Negative fees and incompatible class grades are rejected", () =>
            {
                var invalid = Student(991003); invalid["Fee1"] = -1; Reject(() => school.SaveStudent(invalid));
                invalid["Fee1"] = 0; invalid["xPaye"] = 2; Reject(() => school.SaveStudent(invalid));
                Reject(() => school.DeleteClass(classroom));
            });
            Check("An image failure rolls the student transaction back", () =>
            {
                var invalid = Student(991004); invalid["Student_img"] = "not bytes";
                var failed = false;
                try { school.SaveStudent(invalid); } catch (Exception) { failed = true; }
                Require(failed && Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent WHERE Code=991004")) == 0);
            });
            var teacher = entities.Save("teachers", new() { ["fNamF"] = "استاد", ["fNamL"] = "آزمون", ["fEmail"] = "", ["fPassword"] = "" });
            var book = entities.Save("books", new() { ["xPaye"] = 1, ["Name"] = "ریاضی .NET", ["vahed"] = 1, ["timeWeek"] = 1, ["Type"] = 1, ["sort"] = 30000, ["SortOneEntry"] = 30000, ["codedars"] = 991000, ["Vezarat"] = true });
            Check("Teacher assignments and reference protection", () =>
            {
                school.AssignTeacher(classroom, book, teacher);
                Require(school.TeacherAssignments(classroom).Single().Int("xTch") == teacher);
                Reject(() => school.AssignTeacher(classroom, book, teacher)); Reject(() => entities.Delete("teachers", teacher));
                school.UnassignTeacher(classroom, book); entities.Delete("teachers", teacher);
            });
            Check("Reference entities save, edit and delete", () =>
            {
                var discount = entities.Save("discounts", new() { ["name"] = "تخفیف .NET", ["comment"] = "آزمایشی" });
                entities.Save("discounts", new() { ["name"] = "تخفیف جدید", ["comment"] = "" }, discount);
                Require(entities.List("discounts").Single(r => r.Int("id") == discount).Text("name") == "تخفیف جدید");
                entities.Delete("discounts", discount);
                var days = entities.Save("year_days", new() { ["xMaghta"] = 1, ["Term1"] = 100, ["Term2"] = 90 });
                Reject(() => entities.Save("year_days", new() { ["xMaghta"] = 1, ["Term1"] = 100, ["Term2"] = 90 }));
                entities.Delete("year_days", days);
                var exam = entities.Save("exams", new() { ["Name"] = "آزمون .NET", ["NumExam"] = 30000, ["DateFrom"] = "1410/01/01", ["DateTo"] = "1410/01/02" });
                Require(entities.List("exams").Any(r => r.Int("id") == exam)); entities.Delete("exams", exam);
            });
            Check("Deleting a student removes their image and enrolment", () =>
            {
                school.DeleteStudent(student); Require(school.Student(student) is null && school.StudentImage(student) is null);
                school.DeleteClass(classroom);
            });
        }
        finally
        {
            foreach (var command in new[] { new[] { "container", "rm", "-f", container }, new[] { "volume", "rm", options.Volume } })
            {
                var start = new ProcessStartInfo("docker") { RedirectStandardOutput = true, RedirectStandardError = true };
                foreach (var argument in command) start.ArgumentList.Add(argument);
                using var process = Process.Start(start)!;
                var output = process.StandardOutput.ReadToEndAsync(); var error = process.StandardError.ReadToEndAsync(); await process.WaitForExitAsync(); await output;
                if (process.ExitCode != 0) throw new Exception("Verification cleanup failed: " + await error);
            }
            Directory.Delete(options.DataDirectory, true);
        }
    }
    Console.WriteLine($"SUCCESS: {passed} checks passed.");
    return 0;
}
catch (Exception error) { Console.Error.WriteLine(error); return 1; }
