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
    private static T Field<T>(Form form, string name) => (T)form.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(form);
    private static void Click(Form form, string name) => Field<UIButton>(form, name).PerformClick();
    private static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
    private static void Select(Form form, int id)
    {
        var grid = Field<GridEX>(form, "m_b");
        for (int i = 0; i < grid.RowCount; i++)
            if (Convert.ToInt32(grid.GetRow(i).Cells["id"].Value) == id) { grid.Row = i; return; }
        throw new InvalidOperationException("Saved row was not reloaded into the original grid.");
    }
    internal static void Run(string scenario, Form form, Database db, Action<string> log)
    {
        if (scenario == "discount") Discount(form, db, log);
        else if (scenario == "school") School(form, db, log);
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
    [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr window, uint message, IntPtr wparam, IntPtr lparam);
    [DllImport("kernel32.dll")] private static extern uint GetCurrentThreadId();
    private static void Dialog(Action action, string expectedText, int buttonId)
    {
        bool observed = false;
        using var timer = new Timer {Interval=100};
        timer.Tick += (s,e) => EnumThreadWindows(GetCurrentThreadId(), (window,p) =>
        {
            var name = new StringBuilder(128); GetClassName(window,name,name.Capacity);
            if (!IsWindowVisible(window) || name.ToString() != "#32770") return true;
            var texts = new List<string>();
            EnumChildWindows(window,(child,unused) => {var text = new StringBuilder(2048);GetWindowText(child,text,text.Capacity);texts.Add(text.ToString());return true;},IntPtr.Zero);
            // Never acknowledge an unexpected message or an unrelated window.
            if (!texts.Contains(expectedText)) return true;
            IntPtr button = GetDlgItem(window,buttonId);
            if (button == IntPtr.Zero) return true;
            observed = true; timer.Stop();
            SendMessage(button,0x00F5,IntPtr.Zero,IntPtr.Zero); // BM_CLICK
            return false;
        },IntPtr.Zero);
        timer.Start(); action();
        Require(observed,"Expected dialog did not appear: " + expectedText);
    }
}
