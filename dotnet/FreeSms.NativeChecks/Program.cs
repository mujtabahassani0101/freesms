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
            foreach(string family in new[]{"B Badr","B Nazanin","XB Titre"})
            {
                using var privateFont=ReportFonts.Create(family,16,FontStyle.Regular);
                Check(privateFont.FontFamily.Name==family,"authored report font loaded from its bundled TTF: "+family);
            }
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
            using(var pair=new Panel{Dock=DockStyle.Fill})
            using(var students=new GridEX{Dock=DockStyle.Left,Width=180})
            using(var details=new GridEX{Dock=DockStyle.Fill})
            {
                pair.Controls.Add(details);pair.Controls.Add(students);window.Controls.Add(pair);pair.BringToFront();
                var identities=new DataTable();identities.Columns.Add("id",typeof(int));identities.Rows.Add(51);identities.Rows.Add(52);students.DataSource=identities;
                var initial=new DataTable();initial.Columns.Add("mark",typeof(int));initial.Rows.Add(10);details.DataSource=initial;
                Application.DoEvents();int callbacks=0;bool stable=true;
                students.SelectionChanged+=(sender,args)=>
                {
                    callbacks++;stable&=students.SelectedItems.Count==1 && students.Row>=0;
                    if(students.SelectedItems.Count!=1 || students.Row<0)return;
                    int selected=Convert.ToInt32(students.SelectedItems[0].GetRow().Cells["id"].Value);
                    stable&=selected==Convert.ToInt32(students.GetRow(students.Row).Cells["id"].Value);
                    var data=initial.Clone();data.Rows.Add(selected);details.DataSource=data;
                    details.CurrentColumn=details.RootTable.Columns["mark"];details.Select();details.SelectCurrentCellText();
                };
                details.Select();details.SelectCurrentCellText();students.Row=1;
                Check(stable && callbacks==1 && Convert.ToInt32(details.GetRow(0).Cells["mark"].Value)==52,"programmatic selection publishes the new row once before rebinding and focusing its dependent grid");
                students.Controls.OfType<DataGridView>().Single().CurrentCell=students.Controls.OfType<DataGridView>().Single().Rows[0].Cells["id"];
                Application.DoEvents();
                Check(stable && callbacks==2 && Convert.ToInt32(details.GetRow(0).Cells["mark"].Value)==51,"native selection completes before dependent grid rebinding and editor focus");
            }
            using(var hiddenPanel=new Panel{Dock=DockStyle.Fill,Visible=false})
            using(var hiddenDetails=new GridEX{Dock=DockStyle.Fill})
            {
                hiddenPanel.Controls.Add(hiddenDetails);window.Controls.Add(hiddenPanel);
                DataTable Data(int mark){var result=new DataTable();result.Columns.Add("mark",typeof(int));result.Rows.Add(mark);return result;}
                hiddenDetails.DataSource=Data(15);hiddenDetails.CurrentColumn=hiddenDetails.RootTable.Columns["mark"];hiddenDetails.SelectCurrentCellText();
                var native=hiddenDetails.Controls.OfType<DataGridView>().Single();
                Check(native.EditingControl==null,"a hidden dependent grid does not create a native editor before its panel is opened");
                hiddenDetails.DataSource=Data(25);hiddenDetails.CurrentColumn=hiddenDetails.RootTable.Columns["mark"];hiddenDetails.SelectCurrentCellText();
                Check(native.EditingControl==null && Convert.ToInt32(hiddenDetails.GetRow(0).Cells["mark"].Value)==25,"hidden dependent data can be replaced and its column selected without a stale editing control");
                hiddenPanel.Visible=true;hiddenPanel.BringToFront();Application.DoEvents();hiddenDetails.Select();hiddenDetails.SelectCurrentCellText();
                Check(native.IsCurrentCellInEditMode && native.EditingControl is TextBox,"opening the dependent panel still enables normal cell editing");hiddenDetails.EndEdit();
            }
            using(var payments=new GridEX{Dock=DockStyle.Fill})
            {
                window.Controls.Add(payments);payments.BringToFront();
                payments.DesignTimeLayout=new GridEXLayout{LayoutString="<GridEXLayoutData><RootTable><Columns><Column0><Key>date</Key><DataMember>date</DataMember><Caption>dates</Caption><AggregateFunction>Count</AggregateFunction></Column0><Column1><Key>fee</Key><DataMember>fee</DataMember><Caption>fees</Caption><AggregateFunction>Sum</AggregateFunction></Column1></Columns></RootTable></GridEXLayoutData>"};
                payments.TotalRow=Janus.Windows.GridEX.InheritableBoolean.True;
                var entries=new DataTable();entries.Columns.Add("date",typeof(string));entries.Columns.Add("fee",typeof(int));
                entries.Rows.Add("1411/02/01",400);entries.Rows.Add("1411/02/02",200);entries.Rows.Add(DBNull.Value,DBNull.Value);
                payments.DataSource=entries;Application.DoEvents();
                var total=payments.Controls.OfType<Label>().Single();
                Check(total.Text.Contains("dates: 2") && total.Text.Contains("fees: 600"),"payment grid counts string dates and sums numeric amounts without converting dates to numbers");
                payments.Controls.OfType<TextBox>().Single().Text="1411/02/01";Application.DoEvents();
                Check(payments.RowCount==1 && total.Text.Contains("dates: 1") && total.Text.Contains("fees: 400"),"payment grid totals follow the visible filtered records");
                entries.Clear();Application.DoEvents();
                Check(total.Text.Contains("dates: 0") && total.Text.Contains("fees: 0"),"empty payment grid reports zero count and sum");
            }
            using(var numbers=new GridEX{Dock=DockStyle.Fill})
            {
                window.Controls.Add(numbers);numbers.BringToFront();
                numbers.DesignTimeLayout=new GridEXLayout{LayoutString="<GridEXLayoutData><RootTable><Columns><Column0><Key>count</Key><DataMember>count</DataMember><InputMask>Number0</InputMask></Column0><Column1><Key>mark</Key><DataMember>mark</DataMember><InputMask>Number2</InputMask></Column1></Columns></RootTable></GridEXLayoutData>"};
                var values=new DataTable();values.Columns.Add("count",typeof(int));values.Columns.Add("mark",typeof(decimal));values.Rows.Add(1,1m);numbers.DataSource=values;
                var view=numbers.Controls.OfType<DataGridView>().Single();int editNotifications=0;numbers.CellUpdated+=(sender,args)=>editNotifications++;int errors=0;view.DataError+=(sender,args)=>{errors++;args.ThrowException=true;};
                bool Enter(string key,string value)
                {
                    view.CurrentCell=view.Rows[0].Cells[key];RequireEditor();
                    ((TextBox)view.EditingControl!).Text=value;
                    bool accepted=numbers.TryEndEdit();if(!accepted)view.CancelEdit();Console.WriteLine("NUMERIC key="+key+" input="+value+" accepted="+accepted+" stored="+values.Rows[0][key]);return accepted;
                }
                void RequireEditor(){if(!view.BeginEdit(true) || view.EditingControl is not TextBox)throw new InvalidOperationException("Numeric cell did not open its editor.");}
                Check(Enter("count","۱۲٣") && (int)values.Rows[0]["count"]==123 && Enter("mark","۱۲.۵") && (decimal)values.Rows[0]["mark"]==12.5m,"native numeric grid edits preserve typed Persian/Arabic integers and decimal marks");
                Check(Enter("count","123") && editNotifications==2,"ending an unchanged grid edit does not publish a false modification");
                Check(!Enter("count","1.5") && (int)values.Rows[0]["count"]==123,"integer grid mask rejects fractions without changing the saved cell");
                Check(!Enter("count","2147483648") && (int)values.Rows[0]["count"]==123 && errors==0 && editNotifications==2,"out-of-range integer edits reject before binding without native data-error dialogs");
                numbers.CellUpdated+=(sender,args)=>numbers.GetRow(numbers.Row).EndEdit();
                view.CurrentCell=view.Rows[0].Cells["count"];RequireEditor();((TextBox)view.EditingControl!).Text="124";
                view.CurrentCell=view.Rows[0].Cells["mark"];
                Check((int)values.Rows[0]["count"]==124 && editNotifications==3 && errors==0,"changing cells safely commits edits when the recovered update handler also ends the row edit");
                view.CurrentCell=view.Rows[0].Cells["count"];RequireEditor();((TextBox)view.EditingControl!).Text="999";
                var replacement=values.Clone();replacement.Rows.Add(7,8m);numbers.DataSource=replacement;
                numbers.CurrentColumn=numbers.RootTable.Columns["mark"];numbers.SelectCurrentCellText();numbers.EndEdit();
                Check((int)values.Rows[0]["count"]==124 && (int)replacement.Rows[0]["count"]==7 && errors==0,"rebinding a grid with an active editor cancels stale text before columns and focus are replaced");
            }
            using (var blobs = new GridEX { Dock = DockStyle.Fill })
            {
                var records = new DataTable(); records.Columns.Add("id", typeof(int)); records.Columns.Add("Rpt", typeof(byte[]));
                byte[] layoutBytes = System.Text.Encoding.UTF8.GetBytes("<ActiveReportsLayout><Sections/></ActiveReportsLayout>");
                records.Rows.Add(1, layoutBytes);
                blobs.DesignTimeLayout = new GridEXLayout { LayoutString = "<GridEXLayoutData><RootTable><Columns><Column0 ID='id'><Key>id</Key></Column0></Columns></RootTable></GridEXLayoutData>" };
                window.Controls.Add(blobs); blobs.BringToFront();
                var native = blobs.Controls.OfType<DataGridView>().Single();
                int errors = 0; native.DataError += (s,e) => { errors++; e.ThrowException = false; };
                blobs.DataSource = records;
                Check(!blobs.RootTable.Columns["Rpt"].Visible && native.Columns["Rpt"] is not DataGridViewImageColumn, "report layout bytes are hidden binary data, never inferred as images");
                blobs.RootTable.Columns["Rpt"].Visible = true;
                using var bitmap = new Bitmap(blobs.Width, blobs.Height); blobs.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
                Check(errors == 0 && ReferenceEquals(blobs.GetRow(0).Cells["Rpt"].Value, layoutBytes), "binary cells render without data errors and preserve the original payload");
            }
            using (var photos = new GridEX { Dock = DockStyle.Fill })
            {
                photos.DesignTimeLayout = new GridEXLayout { LayoutString = "<GridEXLayoutData><RootTable><Columns><Column0 ID='photo'><Key>photo</Key><ColumnType>BoundImage</ColumnType></Column0></Columns></RootTable></GridEXLayoutData>" };
                var records = new DataTable(); records.Columns.Add("photo", typeof(byte[]));
                using var picture = new Bitmap(12,12); using var stream = new MemoryStream(); picture.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                records.Rows.Add(stream.ToArray()); records.Rows.Add(new byte[] { 1,2,3 }); records.Rows.Add(DBNull.Value);
                window.Controls.Add(photos); photos.BringToFront();
                var native = photos.Controls.OfType<DataGridView>().Single(); int errors = 0;
                native.DataError += (s,e) => { errors++; e.ThrowException = false; };
                photos.DataSource = records;
                using var bitmap = new Bitmap(photos.Width, photos.Height); photos.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
                Check(errors == 0 && native.Rows[0].Cells[0].FormattedValue is Image, "explicit photo columns decode valid images and safely render corrupt or empty images");
            }
            using (var sourceIcon = new Bitmap(256, 128))
            {
                using (var button = new UIButton { Image = sourceIcon, ImageSize = new Size(24,24) })
                {
                    window.Controls.Add(button); button.CreateControl();
                    int limit = (int)(24 * button.DeviceDpi / 96f);
                    Check(button.Image.Width == limit && button.Image.Height == Math.Max(1,limit / 2), "button icon respects requested size and aspect ratio");
                    button.ImageSize = new Size(16,16);
                    Check(button.Image.Width == (int)(16 * button.DeviceDpi / 96f), "button icon responds to size changes");
                    button.Image = null;
                    Check(button.Image == null && sourceIcon.Width == 256, "clearing button image preserves shared resource ownership");
                    button.Image = sourceIcon;
                }
                Check(sourceIcon.Width == 256, "disposing button does not dispose shared source icon");
            }
            using var combo = new UIComboBox(); window.Controls.Add(combo);
            combo.Items.Add("اول", "1"); combo.Items.Add("دوم", "2"); combo.SelectedValue = 2;
            Check(combo.SelectedIndex == 1 && combo.SelectedItem.Value.ToString() == "2", "unbound combo values support original numeric IDs");
            combo.DataSource = table; combo.DisplayMember = "mark"; combo.ValueMember = "id"; combo.SelectedValue = "41";
            Check(Convert.ToInt32(combo.SelectedValue) == 41, "bound combo identity");
            using (var bindingCombo = new UIComboBox())
            {
                window.Controls.Add(bindingCombo);
                var observed = new List<object>();
                bindingCombo.SelectedIndexChanged += (s, e) => observed.Add(bindingCombo.SelectedValue);
                bindingCombo.DataSource = table;
                Check(observed.Count == 0, "combo does not publish a row object before ValueMember is configured");
                bindingCombo.DisplayMember = "mark"; bindingCombo.ValueMember = "id";
                Check(observed.Count > 0 && observed.All(value => value is int), "initial combo selection publishes only the typed database ID");
                observed.Clear(); bindingCombo.DataSource = table.Copy();
                Check(observed.All(value => value is int), "combo rebinding does not publish transient empty selections");
            }
            using (var replacingCombo = new UIComboBox())
            {
                window.Controls.Add(replacingCombo);
                replacingCombo.Items.Add("old", "old"); replacingCombo.SelectedIndex=0;
                var seen = new List<object>();
                replacingCombo.SelectedIndexChanged += (s,e) => seen.Add(replacingCombo.SelectedValue);
                replacingCombo.SetItems(new[] { new UIComboBoxItem {Text="future year",Value="1410"}, new UIComboBoxItem {Text="current year",Value="1405"} },"1410");
                Check(Convert.ToString(replacingCombo.SelectedValue)=="1410" && seen.Count==1 && seen.All(value => Convert.ToString(value)=="1410"), "atomic item replacement publishes only the configured selection, never an empty or first default value");
            }
            using(var masked=new Janus.Windows.GridEX.EditControls.MaskedEditBox{Mask="0000/00/00",Numeric=true})
            {
                Check(masked.Text=="","empty masked dates expose no literal separators as a value");
                masked.Text="۱۴۱۳/۰۲/۰۳";Check(masked.Text=="1413/02/03","masked dates normalize Persian input without losing separators");
                masked.Text="";Check(masked.Text=="","cleared masked dates become empty again");
            }
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
            var annualModel=ReportModel.Load(Path.Combine(root,"dotnet","FreeSms.Original.Windows","portable-layouts","CR_AF_StdKarnameDorehByChart_term3.rpt.xml"));
            var annualInput=ReportFixtures.Create(annualModel.Xml,24);
            annualInput.Parameters["showBartar"]="0";annualInput.Parameters["showGread"]="0";
            for(int i=0;i<24;i++)
            {
                var row=annualInput.Data!.Tables[0].Rows[i];
                row["xStudent"]=i/12+1;row["Code"]=5991001+i/12;row["sort"]=i%12+1;
                row["FName"]="شاگرد "+(i/12+1);row["LName"]="پدر شاگرد";row["PName"]="پدرکلان";
                row["Book"]="مضمون "+(i%12+1);row["Mark"]=i<12?70m:30m;row["avgClass"]=50m;
            }
            using(var document=new PortableReportDocument(annualModel,annualInput))
            {
                Check(document.PageCount==2,"intact original annual card keeps two students with twelve subjects each on separate pages");
                for(int i=0;i<document.PageCount;i++)document.SavePageImage(Path.Combine(output,"original-annual-twelve-subjects-page-"+(i+1)+".png"),i,120);
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
            foreach(string text in new[]{"مکتب", "School"})
            foreach(string alignment in new[]{"LeftAlign","RightAlign","HorizontalCenterAlign"})
            {
                var template=XElement.Parse("<report><sections><section kind='Detail' height='720'><object><Kind>TextObject</Kind><Left>144</Left><Top>0</Top><Width>4320</Width><Height>720</Height><Font family='Tahoma' size='12'/><format><HorizontalAlignment>"+alignment+"</HorizontalAlignment></format><Text>"+text+"</Text></object></section></sections></report>");
                using var document=new PortableReportDocument(new ReportModel(template),ReportFixtures.Create(template,1));
                string path=Path.Combine(output,(text=="School"?"latin":"persian")+"-"+alignment+".png");
                document.SavePageImage(path,0,100);using var bitmap=new Bitmap(path);
                int first=bitmap.Width,last=-1;
                for(int y=0;y<50;y++)for(int x=0;x<bitmap.Width;x++)
                    if(bitmap.GetPixel(x,y).GetBrightness()<.6f){first=Math.Min(first,x);last=Math.Max(last,x);}
                bool aligned=alignment=="LeftAlign" ? first>=10 && first<50 : alignment=="RightAlign" ? last>280 && last<=310 : first>100 && last<220;
                Check(last>=first && aligned,"physical "+alignment+" preserved for "+(text=="School"?"Latin":"Persian")+" report text");
            }
            var columns=XElement.Parse("<report><sections><section kind='Detail' height='1440'><object subreport='Sub1'><Kind>SubreportObject</Kind><Left>1440</Left><Top>0</Top><Width>3000</Width><Height>144</Height><report><sections><section kind='Detail' height='720'/></sections></report></object><object><Kind>BoxObject</Kind><Left>0</Left><Top>720</Top><Width>720</Width><Height>720</Height><border><BackgroundColor>-16711936</BackgroundColor></border></object></section></sections></report>");
            var columnsInput=ReportFixtures.Create(columns,1);columnsInput.Subreports["Sub1"]=ReportFixtures.Create(columns.Descendants("report").Single(),20);
            using(var document=new PortableReportDocument(new ReportModel(columns),columnsInput))
            {
                string path=Path.Combine(output,"independent-report-columns.png");document.SavePageImage(path,0,100);using var bitmap=new Bitmap(path);
                Check(bitmap.GetPixel(25,75).ToArgb()==Color.Lime.ToArgb(),"growing right-hand subreport does not move the independent left-hand column");
            }
            var columnTemplate=XElement.Parse("<report><sections><section name='TableHeader' kind='ReportHeader' height='288'><object><Name>ColumnEdge</Name><Kind>LineObject</Kind><LineThickness>20</LineThickness><Left>1440</Left><Top>0</Top><Width>0</Width><Height>16000</Height><EndSectionName>TableEnd</EndSectionName><Right>1440</Right><Bottom>0</Bottom></object></section><section name='Rows' kind='Detail' height='288'/><section name='TableEnd' kind='ReportFooter' height='288'><object><Kind>LineObject</Kind><LineThickness>20</LineThickness><Left>0</Left><Top>0</Top><Width>2880</Width><Height>0</Height></object></section></sections></report>");
            using(var document=new PortableReportDocument(new ReportModel(columnTemplate),ReportFixtures.Create(columnTemplate,3)))
            {
                Check(document.PageCount==1,"cross-section table lines do not stretch the original header or add pages");
                string path=Path.Combine(output,"original-column-anchors.png");document.SavePageImage(path,0,100);using var bitmap=new Bitmap(path);
                Check(bitmap.GetPixel(100,10).GetBrightness()<.6f && bitmap.GetPixel(100,70).GetBrightness()<.6f && bitmap.GetPixel(150,80).GetBrightness()<.6f && bitmap.GetPixel(100,90).ToArgb()==Color.White.ToArgb(),"table column ends at the footer after all three rows, using the recovered section anchor");
            }
            var photoTemplate=XElement.Parse("<report><database><table name='student'><field name='Student_img' type='BlobField'/></table></database><sections><section kind='Detail' height='720'><object><Name>Studentimg1</Name><Kind>BlobFieldObject</Kind><Left>144</Left><Top>0</Top><Width>720</Width><Height>720</Height></object></section></sections></report>");
            var photoModel=new ReportModel(photoTemplate);var photoInput=ReportFixtures.Create(photoTemplate,4);
            byte[] Photo(Color color)
            {
                using var bitmap=new Bitmap(8,8);using(var graphics=Graphics.FromImage(bitmap))graphics.Clear(color);
                using var stream=new MemoryStream();bitmap.Save(stream,System.Drawing.Imaging.ImageFormat.Png);return stream.ToArray();
            }
            photoInput.Data!.Tables[0].Rows[0]["Student_img"]=Photo(Color.Lime);
            photoInput.Data.Tables[0].Rows[1]["Student_img"]=Photo(Color.Red);
            photoInput.Data.Tables[0].Rows[2]["Student_img"]=DBNull.Value;
            photoInput.Data.Tables[0].Rows[3]["Student_img"]=new byte[]{1,2,3};
            using(var document=new PortableReportDocument(photoModel,photoInput))
            {
                string path=Path.Combine(output,"student-photos.png");document.SavePageImage(path,0,100);using var bitmap=new Bitmap(path);
                Check(bitmap.GetPixel(25,20).ToArgb()==Color.Lime.ToArgb() && bitmap.GetPixel(25,70).ToArgb()==Color.Red.ToArgb(),"each student report photo renders its own persisted image");
                Check(bitmap.GetPixel(25,120).ToArgb()==Color.White.ToArgb(),"empty student report photo remains blank");
                Check(bitmap.GetPixel(35,175).GetBrightness()<.9f,"damaged student report photo renders a placeholder without stopping the report");
            }
            var oversizedHeader = XElement.Parse("<report><sections><section kind='PageHeader' height='20000'/><section kind='Detail' height='720'/></sections></report>");
            bool rejectedHeader = false;
            try { using var document = new PortableReportDocument(new ReportModel(oversizedHeader), ReportFixtures.Create(oversizedHeader, 1)); }
            catch (InvalidDataException) { rejectedHeader = true; }
            Check(rejectedHeader, "oversized page headers reject pagination instead of generating pages forever");
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
