using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using DataDynamics.ActiveReports;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

internal static class Program
{
    [STAThread]
    private static int Main(string[] args)
    {
        var root = Path.GetFullPath(args.Length > 0 ? args[0] : ".");
        var output = Path.Combine(root, "validation", "native-controls");
        Directory.CreateDirectory(output);
        try
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            int count = 0;
            void Check(bool result, string name) { if (!result) throw new InvalidOperationException(name); Console.WriteLine("PASS " + name); count++; }
            using var window = new Form { Width = 800, Height = 600 };
            using var grid = new GridEX { Dock = DockStyle.Fill };
            window.Controls.Add(grid);
            grid.DesignTimeLayout = new GridEXLayout { LayoutString = "<GridEXLayoutData><RootTable><Columns><Column0 ID='id'><Key>id</Key><DataMember>id</DataMember><Caption>کد</Caption><Visible>False</Visible></Column0><Column1 ID='mark'><Key>mark</Key><DataMember>mark</DataMember><Caption>نمره</Caption></Column1><Column2 ID='selected'><Key>selected</Key><DataMember>selected</DataMember><ColumnType>CheckBox</ColumnType></Column2></Columns></RootTable></GridEXLayoutData>" };
            var table = new DataTable("students");
            table.Columns.Add("id", typeof(int)); table.Columns.Add("mark", typeof(decimal)); table.Columns.Add("selected", typeof(bool));
            table.Rows.Add(41, 85m, false); table.Rows.Add(42, 90m, true);
            grid.DataSource = table;
            window.Show(); Application.DoEvents();
            Check(grid.RowCount == 2 && grid.RecordCount == 2, "bind two records");
            Check(!grid.RootTable.Columns["id"].Visible && grid.RootTable.Columns["mark"].Caption == "نمره", "preserve layout metadata");
            grid.Row = 1; Application.DoEvents();
            Check(Convert.ToInt32(grid.SelectedItems[0].GetRow().Cells["id"].Value) == 42, "selected row preserves database identity");
            grid.GetRow(1).BeginEdit(); grid.GetRow(1).Cells["mark"].Text = "91.5"; grid.GetRow(1).EndEdit();
            Check(Convert.ToDecimal(table.Rows[1]["mark"]) == 91.5m, "typed mark edits update source data");
            grid.GetRow(0).Cells["selected"].Value = true;
            Check((bool)table.Rows[0]["selected"], "checkbox write-through");
            ((DataGridView)grid.Controls.OfType<DataGridView>().Single()).Sort(((DataGridView)grid.Controls.OfType<DataGridView>().Single()).Columns["mark"]!, System.ComponentModel.ListSortDirection.Descending);
            Check(Convert.ToInt32(grid.GetRow(0).Cells["id"].Value) == 42, "sorted row identity");
            using var combo = new UIComboBox(); window.Controls.Add(combo);
            combo.Items.Add("اول", "1"); combo.Items.Add("دوم", "2"); combo.SelectedValue = 2;
            Check(combo.SelectedIndex == 1 && combo.SelectedItem.Value.ToString() == "2", "unbound combo values support original numeric IDs");
            combo.DataSource = table; combo.DisplayMember = "mark"; combo.ValueMember = "id"; combo.SelectedValue = "41";
            Check(Convert.ToInt32(combo.SelectedValue) == 41, "bound combo identity");
            Check(ShamsiDate.GetShamsiDate(ShamsiDate.ShamsiToGregory("۱۴۰۵/۰۸/۱۱")) == "1405/08/11", "Afghan calendar roundtrip with Persian digits");
            using var date = new DatePicker(); int changes = 0; date.DateChanged += (s,e) => changes++;
            date.the_date = new DateTime(2026, 11, 2);
            Check(changes == 1 && ShamsiDate.GetShamsiDate(date.the_date) == "1405/08/11", "date picker value and event");
            window.Hide();
            foreach (var path in Directory.GetFiles(Path.Combine(root, "original", "update", "rpt"), "*.rpx"))
            {
                using var report = new ActiveReport3(); report.LoadLayout(path);
                Check(report.Sections.Count > 0 && report.Sections.Any(s => s.Controls.Any()), "load RPX " + Path.GetFileName(path));
                var data = new DataTable("v_data");
                foreach (var field in report.Sections.SelectMany(s => s.Controls).Select(c => c.DataField).Where(f => !string.IsNullOrEmpty(f)).Distinct()) data.Columns.Add(field, typeof(string));
                var row = data.NewRow(); foreach (DataColumn column in data.Columns) row[column] = "آزمون ۱۲۳"; data.Rows.Add(row);
                report.DataSource = data; report.Run(false);
                Check(report.Document.PageCount > 0, "paginate RPX " + Path.GetFileName(path));
                report.Document.SavePageImage(Path.Combine(output, Path.GetFileNameWithoutExtension(path) + ".png"), 0);
            }
            Console.WriteLine("SUCCESS " + count);
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); File.WriteAllText(Path.Combine(output, "error.txt"), error.ToString()); return 1; }
    }
}
