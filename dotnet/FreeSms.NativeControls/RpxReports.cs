using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DataDynamics.ActiveReports
{
    internal static class Rpx
    {
        internal static string Get(XElement element, string name, string fallback = "") => (string)element.Elements("Property").FirstOrDefault(p => (string)p.Attribute("name") == name) ?? fallback;
        internal static XElement Property(XElement element, string name) => element.Elements("Property").FirstOrDefault(p => (string)p.Attribute("name") == name);
        internal static void Set(XElement element, string name, string value)
        {
            var node = Property(element, name);
            if (node == null) element.Add(node = new XElement("Property", new XAttribute("name", name)));
            node.Value = value;
        }
        internal static IEnumerable<XElement> Children(XElement property)
        {
            if (property == null) yield break;
            foreach (var child in property.Elements())
            {
                if (child.Name.LocalName == "Object") yield return child;
                else if (child.Name.LocalName == "Reference")
                {
                    var name = (string)child.Attribute("name");
                    var target = property.Document?.Root?.Elements("Object").FirstOrDefault(x => (string)x.Attribute("name") == name);
                    if (target == null) throw new InvalidDataException("Missing RPX object: " + name);
                    yield return target;
                }
            }
        }
        internal static float Number(string value, float fallback = 0) => float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var n) ? n : fallback;
        internal static float[] Coordinates(XElement element, string property)
        {
            var p = Property(element, property);
            if (p == null) return new float[] { 0, 0 };
            var args = p.Descendants("Argument").ToArray();
            return args.Length >= 2 ? args.Take(2).Select(x => Number(x.Value)).ToArray() : p.Value.Split(',').Take(2).Select(x => Number(x.Trim())).Concat(new float[] { 0, 0 }).Take(2).ToArray();
        }
        internal static Color Color(string value, Color fallback)
        {
            if (string.IsNullOrEmpty(value)) return fallback;
            try { return ColorTranslator.FromHtml(value); } catch (Exception error) when (error is ArgumentException || error is FormatException) { return fallback; }
        }
        internal static Image Image(byte[] data)
        {
            // Old RPX contains a serialized Bitmap. Extract only its encoded image
            // payload; never execute BinaryFormatter deserialization.
            byte[][] signatures = { new byte[] { 137,80,78,71,13,10,26,10 }, new byte[] { 255,216,255 }, new byte[] { 71,73,70,56 }, new byte[] { 66,77 } };
            foreach (var signature in signatures)
                for (int i = 0; i <= data.Length - signature.Length; i++)
                    if (data.AsSpan(i, signature.Length).SequenceEqual(signature))
                    {
                        try { using var stream = new MemoryStream(data, i, data.Length - i); using var image = System.Drawing.Image.FromStream(stream); return new Bitmap(image); }
                        catch (ArgumentException) { }
                    }
            throw new InvalidDataException("The RPX image payload is not a supported encoded image.");
        }
    }
    public class ARControl : IDisposable
    {
        internal readonly XElement Xml;
        internal ARControl(XElement xml) { Xml = xml; }
        public ARControl() : this(new XElement("Object", new XAttribute("type", "DataDynamics.ActiveReports.Label"), new XAttribute("name", "Label"))) { }
        public string Name { get => (string)Xml.Attribute("name") ?? Rpx.Get(Xml, "Name"); set { Xml.SetAttributeValue("name", value); Rpx.Set(Xml, "Name", value); } }
        public string Text { get => Rpx.Get(Xml, "Text"); set => Rpx.Set(Xml, "Text", value); }
        public string DataField { get => Rpx.Get(Xml, "DataField"); set => Rpx.Set(Xml, "DataField", value); }
        public float Left { get => Rpx.Coordinates(Xml, "Location")[0]; set => Location(value, Top); }
        public float Top { get => Rpx.Coordinates(Xml, "Location")[1]; set => Location(Left, value); }
        public float Width { get => Rpx.Coordinates(Xml, "Size")[0]; set => Rpx.Set(Xml, "Size", value.ToString(CultureInfo.InvariantCulture) + ", " + Height.ToString(CultureInfo.InvariantCulture)); }
        public float Height { get => Rpx.Coordinates(Xml, "Size")[1]; set => Rpx.Set(Xml, "Size", Width.ToString(CultureInfo.InvariantCulture) + ", " + value.ToString(CultureInfo.InvariantCulture)); }
        public string Font { get => Rpx.Get(Xml, "Font", "Arial, 10pt"); set => Rpx.Set(Xml, "Font", value); }
        public string Alignment { get => Rpx.Get(Xml, "Alignment", "Left"); set => Rpx.Set(Xml, "Alignment", value); }
        public bool Visible { get => Rpx.Get(Xml, "Visible", "True") != "False"; set => Rpx.Set(Xml, "Visible", value ? "True" : "False"); }
        private void Location(float left, float top)
        {
            var prop = Rpx.Property(Xml, "Location");
            if (prop == null) Xml.Add(prop = new XElement("Property", new XAttribute("name", "Location")));
            prop.ReplaceNodes(new XElement("InstanceDescriptor", new XAttribute("type", "System.Drawing.PointF"), new XElement("Argument", new XAttribute("type", "System.Single"), left), new XElement("Argument", new XAttribute("type", "System.Single"), top)));
        }
        internal virtual void Draw(Graphics graphics, DataRow row, float y, bool design)
        {
            if (!Visible && !design) return;
            var rect = new RectangleF(Left * 100, y + Top * 100, Math.Max(1, Width * 100), Math.Max(1, Height * 100));
            var type = (string)Xml.Attribute("type") ?? "";
            var back = Rpx.Color(Rpx.Get(Xml, "BackColor"), Color.Transparent);
            if (back.A != 0) { using var brush = new SolidBrush(back); graphics.FillRectangle(brush, rect); }
            if (type.EndsWith("Shape", StringComparison.Ordinal))
            {
                using var pen = new Pen(Rpx.Color(Rpx.Get(Xml, "LineColor"), Color.Black), Math.Max(.5f, Rpx.Number(Rpx.Get(Xml, "LineWeight"), 1)));
                if (Rpx.Get(Xml, "Style") == "Ellipse") graphics.DrawEllipse(pen, rect); else graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
            }
            else if (type.EndsWith("Line", StringComparison.Ordinal))
            {
                using var pen = new Pen(Rpx.Color(Rpx.Get(Xml, "LineColor"), Color.Black), Math.Max(.5f, Rpx.Number(Rpx.Get(Xml, "LineWeight"), 1)));
                graphics.DrawLine(pen, rect.Left, rect.Top, rect.Right, rect.Bottom);
            }
            else if (this is Picture picture)
            {
                if (picture.Image != null) graphics.DrawImage(picture.Image, rect);
            }
            else
            {
                var text = Text;
                if (!string.IsNullOrEmpty(DataField))
                {
                    string field = DataField.Contains('.') ? DataField.Substring(DataField.LastIndexOf('.') + 1) : DataField;
                    text = design ? "[" + DataField + "]" : row != null && row.Table.Columns.Contains(field) ? Convert.ToString(row[field], CultureInfo.CurrentCulture) : "";
                    var output = Rpx.Get(Xml, "OutputFormat");
                    if (!design && row != null && row.Table.Columns.Contains(field) && row[field] is IFormattable number && !string.IsNullOrEmpty(output)) text = number.ToString(output, CultureInfo.CurrentCulture);
                }
                var fontParts = Font.Split(',');
                float size = Rpx.Number(Regex.Match(Font, @"([\d.]+)pt").Groups[1].Value, 10);
                var style = Font.Contains("Bold") ? FontStyle.Bold : FontStyle.Regular;
                if (Font.Contains("Italic")) style |= FontStyle.Italic;
                if (Font.Contains("Underline")) style |= FontStyle.Underline;
                using var font = new Font(fontParts[0], size, style);
                using var brush = new SolidBrush(Rpx.Color(Rpx.Get(Xml, "ForeColor"), Color.Black));
                using var format = new StringFormat { Alignment = Alignment == "Center" ? StringAlignment.Center : Alignment == "Right" ? StringAlignment.Far : StringAlignment.Near, LineAlignment = Rpx.Get(Xml, "VerticalAlignment") == "Middle" ? StringAlignment.Center : StringAlignment.Near };
                if (Rpx.Get(Xml, "RightToLeft") == "True") format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                graphics.DrawString(text, font, brush, rect, format);
            }
            var border = Rpx.Property(Xml, "Border");
            if (border != null)
            {
                void Line(string side, float x1, float y1, float x2, float y2) { if (Rpx.Get(border, side + "Style", "None") != "None") graphics.DrawLine(Pens.Black, x1, y1, x2, y2); }
                Line("Top", rect.Left, rect.Top, rect.Right, rect.Top); Line("Bottom", rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                Line("Left", rect.Left, rect.Top, rect.Left, rect.Bottom); Line("Right", rect.Right, rect.Top, rect.Right, rect.Bottom);
            }
        }
        public virtual void Dispose() { }
    }
    public class Picture : ARControl
    {
        private Image image;
        internal Picture(XElement xml) : base(xml)
        {
            var data = Rpx.Property(xml, "ImageData")?.Element("Binary");
            if (data != null && !string.IsNullOrWhiteSpace(data.Value)) image = Rpx.Image(Convert.FromBase64String(data.Value));
        }
        public Image Image { get => image; set => image = value; }
        public override void Dispose() { image?.Dispose(); image = null; }
    }
    public class ControlCollection : IEnumerable<ARControl>
    {
        private readonly XElement xml;
        private readonly List<ARControl> controls;
        internal ControlCollection(XElement node)
        {
            xml = node;
            controls = Rpx.Children(node).Select(x => ((string)x.Attribute("type"))?.EndsWith("Picture", StringComparison.Ordinal) == true ? (ARControl)new Picture(x) : new ARControl(x)).ToList();
        }
        public ARControl this[string name] => controls.First(c => c.Name == name);
        public void Clear() { foreach (var control in controls) control.Dispose(); controls.Clear(); xml.RemoveNodes(); }
        public void Add(ARControl control) { controls.Add(control); xml.Add(control.Xml); }
        public IEnumerator<ARControl> GetEnumerator() => controls.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class Section
    {
        internal readonly XElement Xml;
        internal Section(XElement xml)
        {
            Xml = xml;
            var controls = Rpx.Property(xml, "Controls");
            if (controls == null) xml.Add(controls = new XElement("Property", new XAttribute("name", "Controls")));
            Controls = new ControlCollection(controls);
        }
        public string Name => (string)Xml.Attribute("name") ?? Rpx.Get(Xml, "Name");
        public bool Visible { get => Rpx.Get(Xml, "Visible", "True") != "False"; set => Rpx.Set(Xml, "Visible", value ? "True" : "False"); }
        public float Height { get => Rpx.Number(Rpx.Get(Xml, "Height"), .25f); set => Rpx.Set(Xml, "Height", value.ToString(CultureInfo.InvariantCulture)); }
        public ControlCollection Controls { get; }
        internal string Kind => ((string)Xml.Attribute("type") ?? "").Split('.').Last();
        internal string GroupField => Rpx.Get(Xml, "DataField");
    }
    public class SectionCollection : List<Section> { public Section this[string name] => this.First(s => s.Name == name); }
    public class Field { public string Name { get; set; } }
    public class Parameter { public string Key { get; set; } }
    public class PageSettings { public Document.Margins Margins { get; set; } = new Document.Margins(.4f, .4f, .4f, .4f); }
    public class ActiveReport3 : IDisposable
    {
        internal XDocument Layout;
        public string DataMember { get; set; }
        public object DataSource { get; set; }
        public Document.Document Document { get; } = new Document.Document("");
        public PageSettings PageSettings { get; } = new PageSettings();
        public SectionCollection Sections { get; } = new SectionCollection();
        public void LoadLayout(string path)
        {
            using var reader = XmlReader.Create(path, new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null });
            Layout = XDocument.Load(reader);
            var report = Layout.Root.Element("Object") ?? throw new InvalidDataException("Missing RPX report root.");
            Sections.Clear();
            foreach (var section in Rpx.Children(Rpx.Property(report, "Sections"))) Sections.Add(new Section(section));
            Document.Name = (string)report.Attribute("name") ?? Path.GetFileNameWithoutExtension(path);
            DataMember = Rpx.Get(report, "DataMember");
            var settings = Rpx.Property(report, "PageSettings");
            var margins = settings == null ? null : Rpx.Property(settings, "Margins");
            if (margins != null) PageSettings.Margins = new Document.Margins(Rpx.Number(Rpx.Get(margins, "Left"), .4f), Rpx.Number(Rpx.Get(margins, "Right"), .4f), Rpx.Number(Rpx.Get(margins, "Top"), .4f), Rpx.Number(Rpx.Get(margins, "Bottom"), .4f));
        }
        public void SetLicense(string unused) { /* Source compatibility: this renderer has no runtime license or dongle. */ }
        public void Run(bool asynchronous)
        {
            DataTable table = DataSource as DataTable;
            if (DataSource is DataSet ds) table = ds.Tables.Contains(DataMember ?? "") ? ds.Tables[DataMember] : ds.Tables.Count == 0 ? null : ds.Tables[0];
            Document.Render(this, table);
        }
        public void Dispose() { foreach (var section in Sections) foreach (var control in section.Controls) control.Dispose(); Document.Dispose(); }
    }
}
namespace DataDynamics.ActiveReports.Document
{
    public class Margins
    {
        public float Left, Right, Top, Bottom;
        public Margins(float left, float right, float top, float bottom) { Left = left; Right = right; Top = top; Bottom = bottom; }
    }
    public class Document : IDisposable
    {
        public string Name { get; set; }
        public bool CacheToDisk { get; set; }
        public string CacheToDiskLocation { get; set; }
        public PrintDocument PrintDocument { get; } = new PrintDocument();
        internal readonly List<List<Placement>> Pages = new List<List<Placement>>();
        public int PageCount => Pages.Count;
        public void SavePageImage(string path, int index, int dpi = 120)
        {
            if (index < 0 || index >= Pages.Count) throw new ArgumentOutOfRangeException(nameof(index));
            using var bitmap = new Bitmap((int)(8.27 * dpi), (int)(11.69 * dpi));
            bitmap.SetResolution(dpi, dpi);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White); graphics.ScaleTransform(dpi / 100f, dpi / 100f);
                DrawPage(graphics, index);
            }
            bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }
        private int page;
        internal sealed class Placement { internal Section Section; internal DataRow Row; internal float Top; }
        public Document(string name)
        {
            Name = name;
            PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            PrintDocument.BeginPrint += (s, e) => page = 0;
            PrintDocument.PrintPage += (s, e) =>
            {
                e.Graphics.PageUnit = GraphicsUnit.Display;
                e.Graphics.TranslateTransform(e.MarginBounds.Left, e.MarginBounds.Top);
                DrawPage(e.Graphics, page++);
                e.HasMorePages = page < Pages.Count;
            };
        }
        internal void Render(ActiveReport3 report, DataTable table)
        {
            Pages.Clear(); page = 0;
            var m = report.PageSettings.Margins;
            PrintDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins((int)(m.Left * 100), (int)(m.Right * 100), (int)(m.Top * 100), (int)(m.Bottom * 100));
            var rows = table?.Rows.Cast<DataRow>().ToArray() ?? Array.Empty<DataRow>();
            float y = 0;
            var placements = new List<Placement>();
            Pages.Add(placements);
            var headers = report.Sections.Where(s => s.Kind == "GroupHeader").ToArray();
            var footerFields = report.Sections.Where(s => s.Kind == "GroupFooter").Select((s, i) => new { Section = s, Field = headers.Reverse().ElementAtOrDefault(i)?.GroupField }).ToDictionary(x => x.Section, x => x.Field);
            foreach (var item in rows.Select((row, index) => new { row, index }))
                foreach (var section in report.Sections.Where(s => s.Visible))
                {
                    string field = section.Kind == "GroupFooter" ? footerFields[section] : section.GroupField;
                    if (section.Kind == "GroupHeader" && !Boundary(item.index - 1, item.row, field)) continue;
                    if (section.Kind == "GroupFooter" && !Boundary(item.index + 1, item.row, field)) continue;
                    float height = section.Height * 100;
                    if (y > 0 && (Rpx.Get(section.Xml, "NewPage") == "Before" || y + height > 1090))
                    { Pages.Add(placements = new List<Placement>()); y = 0; }
                    placements.Add(new Placement { Section = section, Row = item.row, Top = y });
                    y += height;
                }
            bool Boundary(int other, DataRow row, string field) => other < 0 || other >= rows.Length || (!string.IsNullOrEmpty(field) && row.Table.Columns.Contains(field) && !Equals(row[field], rows[other][field]));
        }
        internal void DrawPage(Graphics graphics, int index)
        {
            if (index < 0 || index >= Pages.Count) return;
            foreach (var placement in Pages[index])
                foreach (var control in placement.Section.Controls) control.Draw(graphics, placement.Row, placement.Top, false);
        }
        public void Dispose() { PrintDocument.Dispose(); Pages.Clear(); }
    }
}
namespace DataDynamics.ActiveReports.Toolbar
{
    public class Tool
    {
        internal ToolStripItem Item;
        public bool Visible { get => Item?.Visible ?? false; set { if (Item != null) Item.Visible = value; } }
    }
}
namespace DataDynamics.ActiveReports.Viewer
{
    public enum ViewType { Normal }
    public class ReportViewerObject
    {
        private readonly PrintPreviewControl view;
        internal ReportViewerObject(PrintPreviewControl view) { this.view = view; }
        public Color BackColor { get => view.BackColor; set => view.BackColor = value; }
        public int CurrentPage { get => view.StartPage; set => view.StartPage = value; }
        public int MultiplePageCols { get => view.Columns; set => view.Columns = value; }
        public int MultiplePageRows { get => view.Rows; set => view.Rows = value; }
        public ViewType ViewType { get; set; }
    }
    public class TableOfContentsObject { public string Text { get; set; } public int Width { get; set; } }
    public class ToolbarObject
    {
        internal readonly ToolStrip Strip = new ToolStrip { Dock = DockStyle.Top };
        public Font Font { get => Strip.Font; set => Strip.Font = value; }
        public List<Toolbar.Tool> Tools { get; } = new List<Toolbar.Tool>();
        internal void Add(ToolStripItem item) { Strip.Items.Add(item); Tools.Add(new Toolbar.Tool { Item = item }); }
    }
    public class Viewer : UserControl
    {
        private readonly PrintPreviewControl preview = new PrintPreviewControl { Dock = DockStyle.Fill, AutoZoom = true };
        private Document.Document document;
        public ReportViewerObject ReportViewer { get; }
        public TableOfContentsObject TableOfContents { get; } = new TableOfContentsObject();
        public ToolbarObject Toolbar { get; } = new ToolbarObject();
        public int TabTitleLength { get; set; }
        public Document.Document Document { get => document; set { document = value; preview.Document = value?.PrintDocument; preview.InvalidatePreview(); } }
        public Viewer()
        {
            ReportViewer = new ReportViewerObject(preview);
            Toolbar.Add(new ToolStripButton("قبلی", null, (s,e) => { if (preview.StartPage > 0) preview.StartPage--; }));
            Toolbar.Add(new ToolStripButton("بعدی", null, (s,e) => preview.StartPage++));
            Toolbar.Add(new ToolStripButton("چاپ / PDF", null, (s,e) => { if (document == null) return; using var dialog = new PrintDialog { Document = document.PrintDocument, UseEXDialog = true }; if (dialog.ShowDialog(FindForm()) == DialogResult.OK) document.PrintDocument.Print(); }));
            Toolbar.Add(new ToolStripButton("اندازهٔ صفحه", null, (s,e) => { if (document == null) return; using var dialog = new PageSetupDialog { Document = document.PrintDocument }; if (dialog.ShowDialog(FindForm()) == DialogResult.OK) preview.InvalidatePreview(); }));
            Toolbar.Add(new ToolStripButton("خروجی تصویر", null, (s,e) => ExportImage()));
            Toolbar.Add(new ToolStripButton("بزرگ‌نمایی", null, (s,e) => { preview.AutoZoom = false; preview.Zoom = preview.Zoom >= 1.5 ? .5 : preview.Zoom + .25; }));
            Controls.Add(preview); Controls.Add(Toolbar.Strip);
        }
        private void ExportImage()
        {
            if (document == null) return;
            using var dialog = new SaveFileDialog { Filter = "PNG|*.png", FileName = "report.png" };
            if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;
            for (int i = 0; i < document.Pages.Count; i++)
            {
                using var bitmap = new Bitmap(1654, 2338);
                bitmap.SetResolution(200, 200);
                using (var graphics = Graphics.FromImage(bitmap)) { graphics.Clear(Color.White); graphics.ScaleTransform(2, 2); document.DrawPage(graphics, i); }
                var file = document.Pages.Count == 1 ? dialog.FileName : Path.Combine(Path.GetDirectoryName(dialog.FileName), Path.GetFileNameWithoutExtension(dialog.FileName) + "-" + (i + 1) + ".png");
                bitmap.Save(file, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
