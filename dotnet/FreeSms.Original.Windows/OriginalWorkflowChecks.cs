using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FreeSms.Core;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

// Called only after OriginalNavigationCheck has validated its disposable database.
internal static class OriginalWorkflowChecks
{
    private static Action<string> diagnostic = message => { };
    private static T Field<T>(Form form, string name) => (T)form.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(form);
    private static void Click(Form form, string name) => Field<UIButton>(form, name).PerformClick();
    private static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
    private static void Select(Form form, int id, string field = "m_b")
    {
        var grid = Field<GridEX>(form, field);
        for (int i = 0; i < grid.RowCount; i++)
            if (Convert.ToInt32(grid.GetRow(i).Cells["id"].Value) == id) { grid.Row = i; return; }
        throw new InvalidOperationException("Saved row was not reloaded into the original grid.");
    }
    internal static string ReportStudentName => asdaj.b("شاگرد آزمایشی گزارش");
    internal static void PrepareReportFixture(Database db)
    {
        // The parent creates this database; it never uses OriginalRuntime's user connection.
        var school = new SchoolService(db, new Session(1410));
        school.SetYear(1410);
        school.SaveSchool(new Record { ["sch"]="مکتب آزمایشی گزارش", ["Ost"]="کابل", ["cty"]="آزمون", ["Foter1"]="مدیر آزمایشی" });
        int classroom = school.SaveClass(new Record { ["name"]="صنف آزمایشی گزارش", ["xpaye"]=1, ["fee"]=1000, ["shift"]=1, ["sortRpt"]=30000 });
        var entities = new EntityService(school);
        var existingBook = db.Query("SELECT TOP 1 id FROM tBook WHERE xPaye=1 ORDER BY sort,id").FirstOrDefault();
        int book = existingBook == null ? entities.Save("books", new Record { ["xPaye"]=1, ["Name"]="مضمون آزمایشی", ["vahed"]=1, ["timeWeek"]=1, ["Type"]=1, ["sort"]=30000, ["SortOneEntry"]=30000, ["codedars"]=5991001, ["Vezarat"]=true }) : Convert.ToInt32(existingBook["id"]);
        int teacher = entities.Save("teachers",new Record { ["fNamF"]="استاد", ["fNamL"]="آزمایشی", ["fEmail"]="", ["fPassword"]="" });
        school.AssignTeacher(classroom,book,teacher);
        school.SaveStudent(new Record { ["FName"]=ReportStudentName, ["LName"]=asdaj.b("پدر آزمایشی"), ["PName"]=asdaj.b("پدرکلان آزمایشی"), ["Code"]=5991001, ["NumberAsas"]=5991001, ["xPaye"]=1, ["xClass"]=classroom, ["Status"]=1, ["Jens"]=0, ["Fee1"]=1000 });
    }
    internal static void AssertReportFixture(FreeSms.NativeControls.PortableReportViewer viewer)
    {
        var input = (FreeSms.Reports.ReportInput)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("input",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        bool found = input != null && input.Data != null && input.Data.Tables.Cast<System.Data.DataTable>().Any(table => table.Rows.Cast<System.Data.DataRow>().Any(row => row.ItemArray.Any(value => Convert.ToString(value) == ReportStudentName)));
        Require(found,"Report preview did not receive the fixture student's actual database values.");
        Require(input.Parameters.Values.Any(value => Convert.ToString(value).Contains("مکتب آزمایشی گزارش")), "Report preview did not receive the fixture school header.");
    }
    internal static void Run(string scenario, Form form, Database db, Action<string> log)
    {
        diagnostic = log;
        if (scenario == "discount") Discount(form, db, log);
        else if (scenario == "school") School(form, db, log);
        else if (scenario == "student-delete") StudentDelete(form, db, log);
        else throw new ArgumentException("Unknown workflow scenario: " + scenario);
    }
    private static void Discount(Form form, Database db, Action<string> log)
    {
        int before = Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif"));
        Click(form, "m_f");
        Dialog(() => Click(form, "j"), "عنوان تخفیف را وارد کنید", 1);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif")) == before, "Empty title inserted a discount.");
        log("PASS empty title validation leaves database unchanged");
        string name = asdaj.b("تخفیف آزمون " + Guid.NewGuid().ToString("N"));
        string comment = "توضیح ' آزمون ; SELECT 1 --";
        Field<Control>(form,"k").Text = name;
        Field<Control>(form,"n").Text = comment;
        Click(form, "j");
        var saved = db.Query("SELECT id,comment FROM tTakhfif WHERE name=@p0", new object[] { name }).Single();
        int id = Convert.ToInt32(saved["id"]);
        Require(Convert.ToString(saved["comment"]) == comment, "Inserted comment did not round trip exactly.");
        log("PASS actual New/Save buttons persist quoted Persian text as data");
        Select(form,id); Click(form,"m_g");
        Require(Field<Control>(form,"n").Text == comment, "Edit did not reload the saved comment.");
        comment = "اصلاح ' دوم ; --";
        Field<Control>(form,"n").Text = comment;
        Click(form,"j");
        Require(Convert.ToString(db.Scalar("SELECT comment FROM tTakhfif WHERE id=@p0", new object[] {id})) == comment, "Edited comment was not committed.");
        log("PASS actual Edit/Save buttons update the selected record");
        Click(form,"m_f"); Field<Control>(form,"k").Text = "ذخیره نشود"; Click(form,"p");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif")) == before + 1, "Cancel modified the database.");
        log("PASS New/Cancel leaves database unchanged");
        Select(form,id);
        Dialog(() => Click(form,"m_e"), "آيا از حذف تخفیف مطمئن هستيد؟", 7);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif WHERE id=@p0", new object[] {id})) == 1, "Declining deletion removed the row.");
        Dialog(() => Click(form,"m_e"), "آيا از حذف تخفیف مطمئن هستيد؟", 6);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif")) == before, "Confirmed deletion did not remove exactly the new record.");
        log("PASS deletion respects No/Yes and removes only the selected record");
    }
    private static void StudentDelete(Form form, Database db, Action<string> log)
    {
        int id = Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5991001"));
        int before = Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent"));
        Require(id > 0, "Student deletion fixture was not created.");
        Select(form,id,"av");
        Dialog(() => Click(form,"m_g"), "آيا از حذف شاگرد مطمئن هستيد؟",6);
        string warning = "با حذف شاگرد کلیه اطلاعات مربوط به او حذف خواهد شد\n\nآیا از حذف شاگرد اطمینان دارید؟";
        Dialog(() => Click(form,"ai"), warning,7);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tYear_Student WHERE xStudent=@p0",new object[]{id})) == 1,"Declining deletion removed enrolment.");
        Click(form,"ad");
        log("PASS declining student deletion and cancelling panel preserve enrolment");
        Dialog(() => Click(form,"m_g"), "آيا از حذف شاگرد مطمئن هستيد؟",6);
        Dialog(() => Click(form,"ai"), warning,6);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent WHERE id=@p0",new object[]{id})) == 0,"Student delete button did not remove the selected student.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tYear_Student WHERE xStudent=@p0",new object[]{id})) == 0,"Student delete left enrolment behind.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent")) == before-1,"Student delete modified unrelated records.");
        log("PASS original student deletion buttons complete against the supplied database edition");
    }
    private static void School(Form form, Database db, Action<string> log)
    {
        var values = new Dictionary<string,string> { ["o"]="کابل ' آزمون", ["m"]="ولسوالی ; آزمون", ["j"]="مدیر ' آزمون", ["k"]="مکتب آزمون .NET" };
        foreach (var value in values) Field<Control>(form,value.Key).Text=value.Value;
        Dialog(() => Click(form,"f"), "ثبت شد", 1);
        var row = db.Query("SELECT Ost,cty,Foter1,sch FROM tParmetr").Single();
        foreach (var pair in new[] { ("o","Ost"), ("m","cty"), ("j","Foter1"), ("k","sch") })
            Require(Convert.ToString(row[pair.Item2]) == values[pair.Item1], "School field did not round trip: " + pair.Item2);
        log("PASS school Save button persists every field, including quotes");
        using var reopened = new asdac();
        reopened.Show();
        foreach (var value in values) Require(Field<Control>(reopened,value.Key).Text == value.Value, "Reopened school form lost saved field: " + value.Key);
        reopened.Close();
        log("PASS school form reloads all saved fields after reopening");
    }
    private delegate bool WindowCallback(IntPtr window, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool EnumThreadWindows(uint thread, WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool EnumChildWindows(IntPtr window, WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool IsWindowVisible(IntPtr window);
    [DllImport("user32.dll", CharSet=CharSet.Unicode)] private static extern int GetClassName(IntPtr window, StringBuilder name, int size);
    [DllImport("user32.dll", CharSet=CharSet.Unicode)] private static extern int GetWindowText(IntPtr window, StringBuilder text, int size);
    [DllImport("user32.dll")] private static extern IntPtr GetDlgItem(IntPtr window, int id);
    [DllImport("user32.dll")] private static extern bool PostMessage(IntPtr window, uint message, IntPtr wparam, IntPtr lparam);
    [DllImport("kernel32.dll")] private static extern uint GetCurrentThreadId();
    private static void Dialog(Action action, string expectedText, int buttonId)
    {
        bool observed = false, logged = false;
        diagnostic("EXPECT dialog: " + expectedText);
        using var timer = new Timer {Interval=100};
        timer.Tick += (s,e) => EnumThreadWindows(GetCurrentThreadId(), (window,p) =>
        {
            var name = new StringBuilder(128); GetClassName(window,name,name.Capacity);
            if (!IsWindowVisible(window) || name.ToString() != "#32770") return true;
            var texts = new List<string>();
            EnumChildWindows(window,(child,unused) => {var text = new StringBuilder(2048);GetWindowText(child,text,text.Capacity);texts.Add(text.ToString());return true;},IntPtr.Zero);
            // Never acknowledge an unexpected message or an unrelated window.
            if (!logged) { logged = true; diagnostic("OBSERVED dialog child texts: " + string.Join(" | ",texts)); }
            if (!texts.Any(text => text.Trim() == expectedText)) return true;
            IntPtr button = GetDlgItem(window,buttonId);
            if (button == IntPtr.Zero) return true;
            observed = true; timer.Stop();
            // Queue the validated dialog button command; do not depend on focus or
            // synchronously reenter the native modal loop from a timer callback.
            Require(PostMessage(window,0x0111,(IntPtr)buttonId,button), "Could not queue expected dialog response."); // WM_COMMAND/BN_CLICKED
            diagnostic("RESPOND expected dialog, button=" + buttonId);
            return false;
        },IntPtr.Zero);
        timer.Start(); action();
        Require(observed,"Expected dialog did not appear: " + expectedText);
    }
}
