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
    internal static string ReportStudentName => "شاگرد آزمایشی گزارش";
    internal static void PrepareReportFixture(Database db)
    {
        // The parent creates this database; it never uses OriginalRuntime's user connection.
        var school = new SchoolService(db, new Session(1410));
        school.SetYear(1410);
        school.SaveSchool(new Record { ["sch"]="مکتب آزمایشی گزارش", ["Ost"]="کابل", ["cty"]="آزمون", ["Foter1"]="مدیر آزمایشی" });
        int classroom = school.SaveClass(new Record { ["name"]="صنف آزمایشی گزارش", ["xpaye"]=1, ["fee"]=1000, ["shift"]=1, ["sortRpt"]=30000 });
        var entities = new EntityService(school);
        int book = entities.Save("books", new Record { ["xPaye"]=1, ["Name"]="مضمون آزمایشی", ["vahed"]=1, ["timeWeek"]=1, ["Type"]=1, ["sort"]=30000, ["SortOneEntry"]=30000, ["codedars"]=5991001, ["Vezarat"]=true });
        int teacher = entities.Save("teachers",new Record { ["fNamF"]="استاد", ["fNamL"]="آزمایشی", ["fEmail"]="", ["fPassword"]="" });
        school.AssignTeacher(classroom,book,teacher);
        school.SaveStudent(new Record { ["FName"]=ReportStudentName, ["LName"]=asdaj.b("پدر آزمایشی"), ["PName"]=asdaj.b("پدرکلان آزمایشی"), ["Code"]=5991001, ["NumberAsas"]=5991001, ["xPaye"]=1, ["xClass"]=classroom, ["Status"]=1, ["Jens"]=0, ["Fee1"]=1000 });
        school.SaveStudent(new Record { ["FName"]="شاگرد محفوظ", ["LName"]="پدر دوم", ["PName"]="پدرکلان دوم", ["Code"]=5991002, ["NumberAsas"]=5991002, ["xPaye"]=1, ["xClass"]=classroom, ["Status"]=1, ["Jens"]=1, ["Fee1"]=700 });
        foreach (var exam in db.Query("SELECT id,term FROM tExam WHERE xYear=1410 AND term IN(1,2)"))
            foreach (int code in new[] {5991001,5991002})
            {
                int term = Convert.ToInt32(exam["term"]);
                double mark = code == 5991001 ? term == 1 ? 30 : 40 : term == 1 ? 10 : 20;
                var result = db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record { ["xuser"]=1, ["code"]=code.ToString(), ["codedars"]=5991001, ["Xtest"]=exam["id"], ["xYear"]=1410, ["Mark"]=mark });
                Require(string.IsNullOrEmpty(Convert.ToString(result.Output["err"])),"Valid fixture marks were rejected by the original import procedure.");
            }
        // Calculate using the original SQL, in term order. Assert independent known totals.
        foreach (var exam in db.Query("SELECT id FROM tExam WHERE xYear=1410 AND term IN(1,2,3) ORDER BY term"))
        {
            db.Call("sp_Procc",new Record {["Exam"]=exam["id"]});
            db.Call("sp_CalcMarkDoreh",new Record {["Exam"]=exam["id"]});
        }
        foreach (int code in new[] {5991001,5991002})
        {
            var mark = db.Scalar("SELECT m.Mark FROM tMark m JOIN tStudent s ON s.id=m.xStudent JOIN tExam e ON e.id=m.Xtest WHERE s.Code=@p0 AND e.xYear=1410 AND e.term=3 AND m.xbook=@p1 AND m.typ=1",new object[]{code,book});
            Require(Convert.ToDecimal(mark)==(code==5991001 ? 70m : 30m),"Original final-term calculation did not equal the fixture's known sum.");
        }

        var finalExam = db.Scalar("SELECT id FROM tExam WHERE xYear=1410 AND term=3");
        var averages = db.Call("spRpt_StdListTestMark_AvgClass_AllExam",new Record {["Exam"]=Convert.ToString(finalExam),["Class"]=classroom.ToString(),["xYear"]=1410}).Sets[0];
        var finals = averages.Where(row=>Convert.ToInt32(row["Xtest"])==Convert.ToInt32(finalExam)).ToArray();
        Require(finals.Length==2 && finals.All(row=>Convert.ToDecimal(row["AvgClass"])==50m),"Original progress report did not return the known class mean of 50.");

    }
    internal static void AssertReportFixture(FreeSms.NativeControls.PortableReportViewer viewer, Database database)
    {
        var input = (FreeSms.Reports.ReportInput)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("input",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        var expected = database.Query("SELECT id,FName FROM tStudent WHERE Code=5991001").Single();
        bool found = input != null && input.Data != null && input.Data.Tables.Cast<System.Data.DataTable>().Any(table => table.Columns.Contains("xStudent") && table.Columns.Contains("FName") && table.Rows.Cast<System.Data.DataRow>().Any(row => Convert.ToInt32(row["xStudent"]) == Convert.ToInt32(expected["id"]) && Convert.ToString(row["FName"]) == Convert.ToString(expected["FName"])));
        Require(found,"Report preview did not receive the fixture student's actual database values.");
        Require(input.Parameters.Values.Any(value => Convert.ToString(value).Contains("مکتب آزمایشی گزارش")), "Report preview did not receive the fixture school header.");
    }
    internal static void SaveReportPages(FreeSms.NativeControls.PortableReportViewer viewer, string directory, string scenario)
    {
        var document = (FreeSms.NativeControls.PortableReportDocument)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("document",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        Require(document.PageCount>0 && document.PageCount<=20,"Small report fixture produced an invalid page count.");
        for (int page=0; page<document.PageCount; page++) document.SavePageImage(System.IO.Path.Combine(directory,scenario+"-page-"+(page+1)+".png"),page,100);
    }
    internal static void Run(string scenario, Form form, Database db, Action<string> log)
    {
        diagnostic = log;
        if (scenario == "discount") Discount(form, db, log);
        else if (scenario == "school") School(form, db, log);
        else if (scenario == "student-delete") StudentDelete(form, db, log);
        else if (scenario == "backup") Backup(form,db,log);
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
    private static void Backup(Form form,Database db,Action<string> log)
    {
        string folder=System.IO.Path.Combine(System.IO.Path.GetTempPath(),"FreeSmsBackupUi_"+Guid.NewGuid().ToString("N"));
        System.IO.Directory.CreateDirectory(folder);
        try
        {
            Field<Control>(form,"m_e").Text="";
            Dialog(()=>Click(form,"m_d"),"مسیر فایل پشتیبان را مشخص کنید",1);
            db.Execute("CREATE TABLE native_ui_backup_fixture(id int PRIMARY KEY,value nvarchar(100))");
            db.Execute("INSERT INTO native_ui_backup_fixture VALUES(1,N'پیش از پشتیبان')");
            string path=System.IO.Path.Combine(folder,"نسخه ' فارسی.bak");Field<Control>(form,"m_e").Text=path;
            Dialog(()=>Click(form,"m_d"),"تهيه نسخه پشتيبان با موفقیت انجام شد",1);
            Require(System.IO.File.Exists(path),"Original backup button did not create the selected file.");
            var header=db.Query("RESTORE HEADERONLY FROM DISK=@p0",new object[]{path}).Single();
            Require(Convert.ToString(header["DatabaseName"])==new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(db.ConnectionString).InitialCatalog,"Backup button saved a different database.");
            db.Execute("UPDATE native_ui_backup_fixture SET value=N'پس از پشتیبان'");
            new DatabaseMaintenance(db).Restore(path);
            Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Backup from the actual button did not restore its actual record.");
            string originalUser=asdaj.l;
            try
            {
                asdaj.l="2";Field<Control>(form,"l").Text=path;
                Dialog(()=>Click(form,"k"),"اجازه بازگردانی دارد admin فقط کاربر",1);
                Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Non-admin restore action altered the database.");
            }
            finally{asdaj.l=originalUser;}
            db.Execute("UPDATE native_ui_backup_fixture SET value=N'پیش از دکمهٔ بازگردانی'");
            Dialog(()=>Click(form,"k"),"بازگردانی نسخهٔ پشتیبان انجام شد. برنامه را دوباره اجرا کنید.",1);
            Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Original admin restore button did not restore the saved record.");
            db.Execute("DROP TABLE native_ui_backup_fixture");
            log("PASS actual async backup button validates path, backs up configured bank to quoted Persian path, produces restorable records, blocks non-admin restore and completes actual admin restore");
        }
        finally{System.IO.Directory.Delete(folder,true);}
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
        Require(Convert.ToString(db.Scalar("SELECT FName FROM tStudent WHERE Code=5991002"))=="شاگرد محفوظ", "Deletion modified the other student's identity.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tYear_Student y JOIN tStudent s ON s.id=y.xStudent WHERE s.Code=5991002 AND y.xYear=1410"))==1, "Deletion removed another student's enrolment.");
        log("PASS original student deletion buttons preserve the other student and complete against the supplied database edition");
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
    [DllImport("user32.dll")] private static extern int GetDlgCtrlID(IntPtr window);
    [DllImport("user32.dll")] private static extern IntPtr SetActiveWindow(IntPtr window);
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
            var buttons = new List<(IntPtr Handle,int Id,string Text)>();
            EnumChildWindows(window,(child,unused) =>
            {
                var text = new StringBuilder(2048); GetWindowText(child,text,text.Capacity); texts.Add(text.ToString());
                var kind = new StringBuilder(128); GetClassName(child,kind,kind.Capacity);
                if (kind.ToString().IndexOf("button",StringComparison.OrdinalIgnoreCase)>=0)
                    buttons.Add((child,GetDlgCtrlID(child),text.ToString().Replace("&","").Trim()));
                return true;
            },IntPtr.Zero);
            // Never acknowledge an unexpected message or an unrelated window.
            if (!logged) { logged = true; diagnostic("OBSERVED dialog child texts: " + string.Join(" | ",texts)); }
            if (!texts.Any(text => text.Trim() == expectedText)) return true;
            string[] labels = buttonId == 1 ? new[] { "OK", "تأیید", "تایید" } : buttonId == 6 ? new[] { "Yes", "بله" } : buttonId == 7 ? new[] { "No", "خیر" } : Array.Empty<string>();
            // Some native dialog hosts nest their buttons; GetDlgItem(root,id)
            // cannot find those. Resolve the actual descendant button first.
            var selected = buttons.FirstOrDefault(button => labels.Contains(button.Text,StringComparer.OrdinalIgnoreCase));
            if (selected.Handle == IntPtr.Zero) selected = buttons.FirstOrDefault(button => button.Id == buttonId);
            if (selected.Handle == IntPtr.Zero)
            {
                diagnostic("FAILED expected dialog button missing; available=" + string.Join(" | ",buttons.Select(button => button.Id + ":" + button.Text)));
                Environment.Exit(1);
            }
            observed = true; timer.Stop();
            SetActiveWindow(window);
            Require(PostMessage(selected.Handle,0x00F5,IntPtr.Zero,IntPtr.Zero), "Could not queue expected dialog button click."); // BM_CLICK
            diagnostic("RESPOND expected dialog, requested=" + buttonId + " actual=" + selected.Id + ":" + selected.Text);
            return false;
        },IntPtr.Zero);
        timer.Start(); action();
        var deadline=System.Diagnostics.Stopwatch.StartNew();
        while(!observed && deadline.Elapsed<TimeSpan.FromSeconds(45))
        {Application.DoEvents();System.Threading.Thread.Sleep(10);}
        Require(observed,"Expected dialog did not appear: " + expectedText);
    }
}
