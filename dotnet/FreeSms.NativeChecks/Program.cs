using System.Data;
using System.Xml.Linq;
using FreeSms.Reports;
using FreeSms.NativeControls;
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
            OriginalFonts.InitializeFromDirectory(Path.Combine(root, "vendor", "fonts"));
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
            using var date = new DatePicker { the_date = new DateTime(2026, 11, 1) }; int changes = 0; date.DateChanged += (s,e) => changes++;
            date.the_date = new DateTime(2026, 11, 2);
            Check(changes == 1 && ShamsiDate.GetShamsiDate(date.the_date) == "1405/08/11", "date picker value and event");
            window.Hide();
            bool checkedRpxPrint = false;
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
                if (!checkedRpxPrint)
                {
                    Check(PrintMatches(report.Document.PrintDocument, (file, dpi) => report.Document.SavePageImage(file, 0, dpi), Path.Combine(output, "rpx-print-300.png")), "RPX printer rendering matches image export at 300 DPI");
                    checkedRpxPrint = true;
                }
            }
            using (var designer = new DataDynamics.ActiveReports.Design.Designer())
            {
                designer.LoadReport(Directory.GetFiles(Path.Combine(root, "original", "update", "rpt"), "*.rpx").First());
                Check(designer.Selection == null, "empty designer selection follows original event contract");
                var field = designer.Report.Sections.SelectMany(s => s.Controls).First();
                field.Text = "ذخیرهٔ ویرایش"; field.Left = .75f;
                string saved = Path.Combine(output, "edited.rpx"); designer.SaveReport(saved);
                designer.LoadReport(saved);
                var loaded = designer.Report.Sections.SelectMany(s => s.Controls).First();
                Check(loaded.Text == "ذخیرهٔ ویرایش" && loaded.Left == .75f, "designer saves and reloads actual text and geometry");
            }
            bool checkedPortablePrint = false;
            foreach (var path in Directory.GetFiles(Path.Combine(root, "dotnet", "FreeSms.Original.Windows", "portable-layouts"), "*.xml"))
            {
                try
                {
                    var model = ReportModel.Load(path);
                    using var document = new PortableReportDocument(model, ReportFixtures.Create(model.Xml));
                    Check(document.PageCount > 0, "native report " + Path.GetFileName(path));
                    document.SavePageImage(Path.Combine(output, Path.GetFileNameWithoutExtension(path) + ".png"), 0);
                    if (!checkedPortablePrint)
                    {
                        Check(PrintMatches(document, (file, dpi) => document.SavePageImage(file, 0, dpi), Path.Combine(output, "portable-print-300.png")), "native printer rendering matches image export at 300 DPI");
                        checkedPortablePrint = true;
                    }
                }
                catch (Exception error) { throw new Exception(Path.GetFileName(path), error); }
            }
            var childTemplate = XElement.Parse("<report><sections><section kind='Detail' height='720'><object><Kind>FieldObject</Kind><Left>0</Left><Top>0</Top><Width>3000</Width><Height>720</Height><source formula='{data.mark}'/></object></section></sections></report>");
            var parentTemplate = XElement.Parse("<report><sections><section kind='Detail' height='144'><object subreport='Sub1'><Kind>SubreportObject</Kind><Left>0</Left><Top>0</Top><Width>10000</Width><Height>144</Height></object></section></sections></report>");
            parentTemplate.Descendants("object").First().Add(childTemplate);
            var parentInput = ReportFixtures.Create(parentTemplate, 1);
            parentInput.Subreports["Sub1"] = ReportFixtures.Create(childTemplate, 100);
            using (var document = new PortableReportDocument(new ReportModel(parentTemplate), parentInput))
            {
                Check(document.PageCount >= 4, "long subreport continues beyond its original placeholder");
                document.SavePageImage(Path.Combine(output, "long-subreport-last.png"), document.PageCount - 1);
            }
            var layered = XElement.Parse("<report><sections><section kind='Detail' height='2400'><object><Kind>ChartObject</Kind><Left>144</Left><Top>144</Top><Width>4320</Width><Height>1440</Height><chart><category>'گروه'</category><series>Sum({data.mark})</series></chart></object><object><Kind>BoxObject</Kind><Left>0</Left><Top>0</Top><Width>5000</Width><Height>2200</Height><border><BackgroundColor>-1</BackgroundColor></border></object></section></sections></report>");
            using (var document = new PortableReportDocument(new ReportModel(layered), ReportFixtures.Create(layered, 1)))
            {
                string path = Path.Combine(output, "chart-over-background.png");
                document.SavePageImage(path, 0, 100);
                using var image = new Bitmap(path);
                int visible = 0;
                for (int y = 15; y < 70; y++)
                    for (int x = 15; x < 100; x++)
                        if (image.GetPixel(x, y).ToArgb() == Color.SteelBlue.ToArgb()) visible++;
                Check(visible > 100, "report background boxes cannot cover chart values");
            }
            PackageChecks.Verify(root, Check);
            Console.WriteLine("SUCCESS " + count);
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); File.WriteAllText(Path.Combine(output, "error.txt"), error.ToString()); return 1; }
    }

    private static bool PrintMatches(System.Drawing.Printing.PrintDocument document, Action<string, int> save, string path)
    {
        const int dpi = 300;
        save(path, dpi);
        using var expected = new Bitmap(path);
        using var actual = new Bitmap(expected.Width, expected.Height);
        actual.SetResolution(dpi, dpi);
        using var graphics = Graphics.FromImage(actual);
        graphics.Clear(Color.White);
        var bounds = new Rectangle(0, 0, (int)Math.Ceiling(actual.Width * 100d / dpi), (int)Math.Ceiling(actual.Height * 100d / dpi));
        var args = new System.Drawing.Printing.PrintPageEventArgs(graphics, bounds, bounds, new System.Drawing.Printing.PageSettings());
        document.GetType().GetMethod("OnPrintPage", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!.Invoke(document, new object[] { args });
        for (int y = 0; y < actual.Height; y += 7)
            for (int x = 0; x < actual.Width; x += 7)
                if (actual.GetPixel(x, y).ToArgb() != expected.GetPixel(x, y).ToArgb()) return false;
        return true;
    }
}
