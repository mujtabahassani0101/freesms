using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using FreeSms.Reports;

namespace FreeSms.NativeControls
{
    public sealed class PortableReportDocument : PrintDocument
    {
        private sealed class Band
        {
            internal XElement Section;
            internal DataRow Row;
            internal float Top;
            internal float Height;
            internal float Offset;
            internal Layout Layout;
        }
        private sealed class Layout
        {
            internal float Height;
            internal readonly Dictionary<XElement, Child> Children = new Dictionary<XElement, Child>();
            internal readonly Dictionary<XElement, PivotTable> Pivots = new Dictionary<XElement, PivotTable>();
            internal readonly Dictionary<XElement, float> ObjectHeights = new Dictionary<XElement, float>();
        }
        private sealed class Child
        {
            internal PortableReportDocument Document;
            internal float Scale;
            internal float Height;
        }
        private readonly ReportModel model;
        private readonly ReportInput input;
        private readonly DataRow[] rows;
        private readonly List<List<Band>> pages = new List<List<Band>>();
        private readonly Dictionary<string, Image> pictures = new Dictionary<string, Image>();
        private readonly float width;
        private float height;
        private readonly float contentWidth;
        private readonly bool flow;
        private readonly List<PortableReportDocument> children = new List<PortableReportDocument>();
        private int page;
        public int PageCount => pages.Count;
        public PortableReportDocument(ReportModel model, ReportInput input) : this(model, input, false) { }
        private PortableReportDocument(ReportModel model, ReportInput input, bool flow)
        {
            this.flow = flow;
            this.model = model; this.input = input; rows = model.Rows(input);
            var objects = model.Sections.SelectMany(s => s.Elements("object")).ToArray();
            contentWidth = Math.Max(1, objects.Select(o => N(o, "Left") + N(o, "Width")).DefaultIfEmpty(10000).Max() / 14.4f);
            width = Math.Max(720, contentWidth);
            bool landscape = model.Xml.Element("print")?.Element("PaperOrientation")?.Value.Contains("Landscape") == true || width > 900;
            DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            DefaultPageSettings.Landscape = landscape;
            DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);
            float paperWidth = landscape ? 1119 : 777;
            height = (landscape ? 777 : 1119) * Math.Max(1, width / paperWidth);
            BuildPages();
            if (flow) height = Math.Max(1, pages.SelectMany(p => p).Select(b => b.Top + b.Height).DefaultIfEmpty(1).Max());
        }
        private static float N(XElement node, string name) => float.TryParse(node.Element(name)?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out var n) ? n : 0;
        private float BandHeight(XElement section) => Math.Max(0, (float?)section.Attribute("height") ?? 0) / 14.4f;
        private void BuildPages()
        {
            List<Band> current = null;
            float top = 0;
            var first = rows.FirstOrDefault();
            var last = rows.LastOrDefault();
            float footerHeight = flow ? 0 : model.Sections.Where(s => Kind(s) == "PageFooter").Sum(BandHeight);
            bool pendingPage = false;
            void NewPage(DataRow record)
            {
                current = new List<Band>(); pages.Add(current); top = 0;
                foreach (var section in model.Sections.Where(s => Kind(s) == "PageHeader")) Add(section, record, false);
            }
            void Add(XElement section, DataRow record, bool paginate = true)
            {
                var context = model.Context(input, record, rows, pages.Count, pages.Count);
                if (model.Flag(section.Element("format"), "EnableSuppress", context)) return;
                var layout = Measure(section, record);
                float size = layout.Height;
                bool before = model.Flag(section.Element("format"), "EnableNewPageBefore", context);
                if (!flow && paginate && top > 0 && (pendingPage || before || size <= height - footerHeight && top + size > height - footerHeight)) NewPage(record);
                pendingPage = false;
                float remaining = size, offset = 0;
                do
                {
                    float available = flow || !paginate ? Math.Max(remaining, 1) : height - footerHeight - top;
                    if (available <= 0) { NewPage(record); continue; }
                    float part = Math.Min(remaining, available);
                    current.Add(new Band { Section = section, Row = record, Top = top, Height = part, Offset = offset, Layout = layout });
                    if (!model.Flag(section.Element("format"), "EnableUnderlaySection", context)) top += part;
                    offset += part; remaining -= part;
                    if (remaining > 0) NewPage(record);
                } while (remaining > 0);
                if (paginate && model.Flag(section.Element("format"), "EnableNewPageAfter", context)) pendingPage = true;
            }
            bool Boundary(DataRow row, DataRow other, int level) => other == null || Enumerable.Range(0, Math.Min(model.Groups.Length, level + 1)).Any(i => !Equals(model.Evaluate(model.Groups[i], model.Context(input, row, rows)), model.Evaluate(model.Groups[i], model.Context(input, other, rows))));
            NewPage(first);
            foreach (var section in model.Sections.Where(s => Kind(s) == "ReportHeader")) Add(section, first);
            for (int index = 0; index < rows.Length; index++)
            {
                var row = rows[index];
                foreach (var section in model.Sections.Where(s => Kind(s) == "GroupHeader"))
                    if (Boundary(row, index == 0 ? null : rows[index - 1], model.GroupLevel(section))) Add(section, row);
                foreach (var section in model.Sections.Where(s => Kind(s) == "Detail")) Add(section, row);
                foreach (var section in model.Sections.Where(s => Kind(s) == "GroupFooter"))
                    if (Boundary(row, index + 1 == rows.Length ? null : rows[index + 1], model.GroupLevel(section))) Add(section, row);
            }
            foreach (var section in model.Sections.Where(s => Kind(s) == "ReportFooter")) Add(section, last);
            for (int i = 0; !flow && i < pages.Count; i++)
            {
                float bottom = height - footerHeight;
                foreach (var section in model.Sections.Where(s => Kind(s) == "PageFooter"))
                {
                    var record = pages[i].LastOrDefault()?.Row;
                    if (!model.Flag(section.Element("format"), "EnableSuppress", model.Context(input, record, rows, i + 1, pages.Count)))
                        pages[i].Add(new Band { Section = section, Row = record, Top = bottom, Height = BandHeight(section), Layout = Measure(section, record) });
                    bottom += BandHeight(section);
                }
            }
        }
        private static string Kind(XElement section)
        {
            string kind = (string)section.Attribute("kind") ?? "";
            return kind.EndsWith("Section", StringComparison.Ordinal) ? kind.Substring(0, kind.Length - 7) : kind;
        }
        protected override void OnBeginPrint(PrintEventArgs e) { page = 0; base.OnBeginPrint(e); }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);
            var state = e.Graphics.Save();
            // Layout and pixel fonts use hundredths of an inch, regardless of printer DPI.
            e.Graphics.PageUnit = GraphicsUnit.Pixel;
            e.Graphics.TranslateTransform(e.MarginBounds.Left * e.Graphics.DpiX / 100f, e.MarginBounds.Top * e.Graphics.DpiY / 100f);
            float scale = Math.Min(1, e.MarginBounds.Width / width);
            e.Graphics.ScaleTransform(scale * e.Graphics.DpiX / 100f, scale * e.Graphics.DpiY / 100f);
            DrawPage(e.Graphics, page++);
            e.Graphics.Restore(state);
            e.HasMorePages = page < pages.Count;
        }
        public void SavePageImage(string path, int index, int dpi = 120)
        {
            if (index < 0 || index >= pages.Count) throw new ArgumentOutOfRangeException(nameof(index));
            using var bitmap = new Bitmap(Math.Max(1, (int)(width * dpi / 100)), Math.Max(1, (int)(height * dpi / 100)));
            bitmap.SetResolution(dpi, dpi);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White); graphics.ScaleTransform(dpi / 100f, dpi / 100f); DrawPage(graphics, index);
            }
            bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }
        private void DrawPage(Graphics graphics, int index)
        {
            if (index < 0 || index >= pages.Count) return;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (var band in pages[index])
            {
                var state = graphics.Save();
                graphics.SetClip(new RectangleF(0, band.Top, width, Math.Max(.1f, band.Height)), CombineMode.Intersect);
                graphics.TranslateTransform(0, band.Top - band.Offset);
                var context = model.Context(input, band.Row, rows, index + 1, pages.Count);
                foreach (var obj in band.Section.Elements("object"))
                {
                    if (model.Flag(obj.Element("format"), "EnableSuppress", context)) continue;
                    var rect = new RectangleF(N(obj, "Left") / 14.4f, ObjectTop(obj, band.Layout), Math.Max(.1f, N(obj, "Width") / 14.4f), Math.Max(.1f, band.Layout.ObjectHeights.TryGetValue(obj, out var measuredHeight) ? measuredHeight : N(obj, "Height") / 14.4f));
                    var kind = obj.Element("Kind")?.Value;
                    if (kind == "LineObject") { using var pen = new Pen(ColorValue(obj.Element("LineColor"), Color.Black), Math.Max(.5f, N(obj, "LineThickness") / 14.4f)); graphics.DrawLine(pen, rect.Left, rect.Top, rect.Right, rect.Bottom); continue; }
                    DrawBackground(graphics, obj, rect);
                    if (kind == "BoxObject") { graphics.DrawRectangle(Pens.Gray, rect.X, rect.Y, rect.Width, rect.Height); continue; }
                    if (kind == "PictureObject") { DrawPicture(graphics, obj, rect); continue; }
                    if (kind == "ChartObject") { DrawChart(graphics, obj, rect, band, context); continue; }
                    if (kind == "CrossTabObject") { DrawPivot(graphics, obj, rect, band); continue; }
                    if (kind == "SubreportObject") { DrawSubreport(graphics, obj, rect, band); continue; }
                    var source = obj.Element("source");
                    object value = source == null ? obj.Element("Text")?.Value : model.Evaluate((string)source.Attribute("formula") ?? "", context);
                    if (kind == "BlobFieldObject")
                    {
                        if (value is byte[] bytes) { using var image = DataDynamics.ActiveReports.Rpx.Image(bytes); graphics.DrawImage(image, rect); }
                        continue;
                    }
                    string text = TextValue(ReportValue.Format(obj, value));
                    var fontNode = obj.Element("Font");
                    float size = (float?)fontNode?.Attribute("size") ?? 10;
                    using var font = new Font((string)fontNode?.Attribute("family") ?? "Tahoma", Math.Max(1, size * 100 / 72), (FontStyle)((int?)fontNode?.Attribute("style") ?? 0), GraphicsUnit.Pixel);
                    using var brush = new SolidBrush(ColorValue(obj.Element("Color"), Color.Black));
                    using var format = new StringFormat { Trimming = StringTrimming.EllipsisCharacter };
                    var alignment = obj.Element("format")?.Element("HorizontalAlignment")?.Value;
                    format.Alignment = alignment == "RightAlign" ? StringAlignment.Far : alignment == "HorizontalCenterAlign" ? StringAlignment.Center : StringAlignment.Near;
                    if (Regex.IsMatch(text, "[\u0600-\u06ff]")) format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    graphics.DrawString(text, font, brush, rect, format);
                }
                graphics.Restore(state);
            }
        }
        private static string TextValue(object value) => WebUtility.HtmlDecode(Regex.Replace(Formula.Text(value).Replace("<br>", "\n").Replace("<br/>", "\n"), "<[^>]*>", ""));
        private static Color ColorValue(XElement node, Color fallback) => int.TryParse(node?.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var argb) ? Color.FromArgb(argb) : fallback;
        private static void DrawBackground(Graphics g, XElement obj, RectangleF rect)
        {
            var border = obj.Element("border");
            var back = ColorValue(border?.Element("BackgroundColor"), Color.Transparent);
            if (back.A != 0) { using var brush = new SolidBrush(back); g.FillRectangle(brush, rect); }
            using var pen = new Pen(ColorValue(border?.Element("BorderColor"), Color.Black), .5f);
            bool Has(string side) => border?.Element(side + "LineStyle")?.Value is string value && value != "NoLine";
            if (Has("Top")) g.DrawLine(pen, rect.Left, rect.Top, rect.Right, rect.Top);
            if (Has("Bottom")) g.DrawLine(pen, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
            if (Has("Left")) g.DrawLine(pen, rect.Left, rect.Top, rect.Left, rect.Bottom);
            if (Has("Right")) g.DrawLine(pen, rect.Right, rect.Top, rect.Right, rect.Bottom);
        }
        private void DrawPicture(Graphics graphics, XElement obj, RectangleF rect)
        {
            string data = obj.Element("picture")?.Value;
            if (string.IsNullOrEmpty(data)) return;
            if (!pictures.TryGetValue(data, out var image))
            {
                using var stream = new MemoryStream(Convert.FromBase64String(data));
                using var source = Image.FromStream(stream);
                pictures[data] = image = new Bitmap(source);
            }
            graphics.DrawImage(image, rect);
        }
        private Layout Measure(XElement section, DataRow row)
        {
            var layout = new Layout { Height = BandHeight(section) };
            foreach (var obj in section.Elements("object").Where(o => o.Element("Kind")?.Value == "SubreportObject"))
            {
                var context = model.Context(input, row, rows);
                if (model.Flag(obj.Element("format"), "EnableSuppress", context)) continue;
                string name = (string)obj.Attribute("subreport");
                if (name == null || !input.Subreports.TryGetValue(name, out var source)) throw new InvalidDataException("Missing report data: " + name);
                var childModel = new ReportModel(obj.Element("report"));
                var childInput = model.BindSubreport(input, source, childModel, row, rows);
                var document = new PortableReportDocument(childModel, childInput, true);
                children.Add(document);
                float scale = Math.Min(1, N(obj, "Width") / 14.4f / document.contentWidth);
                var placement = new Child { Document = document, Scale = scale, Height = document.height * scale };
                layout.Children[obj] = placement;
            }
            using var measureImage = new Bitmap(1, 1);
            using var measureGraphics = Graphics.FromImage(measureImage);
            foreach (var obj in section.Elements("object"))
            {
                var context = model.Context(input, row, rows);
                if (model.Flag(obj.Element("format"), "EnableCanGrow", context) && obj.Element("Kind")?.Value is "TextObject" or "FieldObject")
                {
                    var source = obj.Element("source");
                    var value = source == null ? obj.Element("Text")?.Value : model.Evaluate((string)source.Attribute("formula") ?? "", context);
                    string text = TextValue(ReportValue.Format(obj, value));
                    var fontNode = obj.Element("Font");
                    using var font = new Font((string)fontNode?.Attribute("family") ?? "Tahoma", Math.Max(1, ((float?)fontNode?.Attribute("size") ?? 10) * 100 / 72), (FontStyle)((int?)fontNode?.Attribute("style") ?? 0), GraphicsUnit.Pixel);
                    layout.ObjectHeights[obj] = Math.Max(N(obj, "Height") / 14.4f, measureGraphics.MeasureString(text, font, new SizeF(Math.Max(1, N(obj, "Width") / 14.4f), 100000)).Height);
                }
                if (obj.Element("Kind")?.Value == "CrossTabObject")
                {
                    var definition = obj.Element("pivot") ?? throw new InvalidDataException("Missing migrated pivot definition.");
                    var scope = Kind(section).StartsWith("Group", StringComparison.Ordinal) ? model.Scope(input, row, rows, model.GroupLevel(section)) : rows;
                    var pivot = ReportPivot.Build(definition, model, input, scope);
                    layout.Pivots[obj] = pivot;
                    layout.ObjectHeights[obj] = Math.Max(N(obj, "Height") / 14.4f, (pivot.Rows.Length + 1) * 26);
                }
                float objectHeight = layout.Children.TryGetValue(obj, out var child) ? Math.Max(N(obj, "Height") / 14.4f, child.Height) : layout.ObjectHeights.GetValueOrDefault(obj, N(obj, "Height") / 14.4f);
                layout.Height = Math.Max(layout.Height, ObjectTop(obj, layout) + objectHeight);
            }
            return layout;
        }
        private static float ObjectTop(XElement obj, Layout layout)
        {
            float top = N(obj, "Top") / 14.4f;
            if (layout == null) return top;
            // Objects beside a subreport remain aligned; objects below it move
            // down when its rows exceed the original design-time placeholder.
            float textGrowth = layout.ObjectHeights.Where(p => p.Key != obj && N(p.Key, "Top") + N(p.Key, "Height") <= N(obj, "Top") + .1f)
                .Select(p => Math.Max(0, p.Value - N(p.Key, "Height") / 14.4f)).DefaultIfEmpty(0).Max();
            return top + Math.Max(textGrowth, layout.Children.Where(p => p.Key != obj && N(p.Key, "Top") + N(p.Key, "Height") <= N(obj, "Top") + .1f)
                .Select(p => Math.Max(0, p.Value.Height - N(p.Key, "Height") / 14.4f)).DefaultIfEmpty(0).Max());
        }
        private static void DrawSubreport(Graphics graphics, XElement obj, RectangleF rect, Band band)
        {
            if (!band.Layout.Children.TryGetValue(obj, out var child)) return;
            var state = graphics.Save(); graphics.TranslateTransform(rect.Left, rect.Top);
            graphics.ScaleTransform(child.Scale, child.Scale);
            child.Document.DrawPage(graphics, 0);
            graphics.Restore(state);
        }
        private void DrawChart(Graphics graphics, XElement obj, RectangleF rect, Band band, FormulaContext context)
        {
            var chart = obj.Element("chart");
            if (chart == null) throw new InvalidDataException("The migrated chart definition is missing: " + obj.Element("Name")?.Value);
            var scope = (Kind(band.Section).StartsWith("Group", StringComparison.Ordinal) ? model.Scope(input, band.Row, rows, model.GroupLevel(band.Section)) : rows);
            var categories = chart.Elements("category").Select(x => x.Value).ToArray();
            var series = chart.Elements("series").Select(x => x.Value).ToArray();
            if (categories.Length == 0 || series.Length == 0) throw new InvalidDataException("The migrated chart has no category or values.");
            var groups = scope.GroupBy(r => string.Join(" / ", categories.Select(category => Formula.Text(model.Evaluate(category, model.Context(input, r, scope)))))).ToArray();
            var values = groups.Select(group => series.Select(s => Convert.ToDecimal(model.Evaluate(s, model.Context(input, group.First(), group.ToArray())) ?? 0, CultureInfo.InvariantCulture)).ToArray()).ToArray();
            decimal max = Math.Max(1, values.SelectMany(v => v).DefaultIfEmpty(1).Max());
            using var font = new Font("Tahoma", 7 * 100f / 72, FontStyle.Regular, GraphicsUnit.Pixel);
            Color[] colors = { Color.SteelBlue, Color.OrangeRed, Color.ForestGreen, Color.Goldenrod };
            float labelHeight = Math.Min(45, rect.Height / 3), plotHeight = Math.Max(1, rect.Height - labelHeight);
            float slot = rect.Width / Math.Max(1, groups.Length);
            graphics.DrawLine(Pens.Gray, rect.Left, rect.Top + plotHeight, rect.Right, rect.Top + plotHeight);
            for (int i = 0; i < groups.Length; i++)
            {
                for (int s = 0; s < series.Length; s++)
                {
                    float barWidth = slot / (series.Length + 1), barHeight = plotHeight * (float)(values[i][s] / max);
                    using var brush = new SolidBrush(colors[s % colors.Length]);
                    graphics.FillRectangle(brush, rect.Left + i * slot + s * barWidth, rect.Top + plotHeight - barHeight, barWidth - 1, Math.Max(0, barHeight));
                }
                using var format = new StringFormat { Alignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft };
                graphics.DrawString(groups[i].Key, font, Brushes.Black, new RectangleF(rect.Left + i * slot, rect.Top + plotHeight, slot, labelHeight), format);
            }
        }
        private static void DrawPivot(Graphics graphics, XElement obj, RectangleF rect, Band band)
        {
            var pivot = band.Layout.Pivots[obj];
            using var font = new Font("Tahoma", 8 * 100f / 72, FontStyle.Regular, GraphicsUnit.Pixel);
            using var bold = new Font(font, FontStyle.Bold);
            using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center, FormatFlags = StringFormatFlags.DirectionRightToLeft };
            float cellWidth = rect.Width / Math.Max(1, pivot.Columns.Length + 1), cellHeight = 26;
            void Draw(string text, int x, int y, bool total)
            {
                var cell = new RectangleF(rect.Right - (x + 1) * cellWidth, rect.Top + y * cellHeight, cellWidth, cellHeight);
                if (total) graphics.FillRectangle(Brushes.WhiteSmoke, cell);
                graphics.DrawRectangle(Pens.Gray, cell.X, cell.Y, cell.Width, cell.Height);
                graphics.DrawString(text, total ? bold : font, Brushes.Black, cell, format);
            }
            for (int column = 0; column < pivot.Columns.Length; column++) Draw(pivot.Columns[column], column + 1, 0, true);
            for (int row = 0; row < pivot.Rows.Length; row++)
            {
                var record = pivot.Rows[row]; Draw(record.Label, 0, row + 1, record.Total);
                for (int column = 0; column < record.Values.Length; column++) Draw(record.Values[column]?.ToString("0.##", CultureInfo.CurrentCulture) ?? "", column + 1, row + 1, record.Total);
            }
        }
        protected override void Dispose(bool disposing) { if (disposing) { foreach (var picture in pictures.Values) picture.Dispose(); foreach (var child in children) child.Dispose(); } base.Dispose(disposing); }
    }

    public class PortableReportViewer : UserControl
    {
        private readonly PrintPreviewControl preview = new PrintPreviewControl { Dock = DockStyle.Fill, AutoZoom = true };
        private readonly ToolStrip strip = new ToolStrip { Dock = DockStyle.Top };
        private readonly ToolStripButton print;
        private readonly ToolStripButton export;
        private PortableReportDocument document;
        private ReportModel model;
        private ReportInput input;
        public bool ShowPrint { get => print.Visible; set => print.Visible = value; }
        public bool ShowExport { get => export.Visible; set => export.Visible = value; }
        public PortableReportViewer()
        {
            print = new ToolStripButton("چاپ / PDF", null, (s,e) => { if (document == null) return; using var dialog = new PrintDialog { Document = document, UseEXDialog = true }; if (dialog.ShowDialog(FindForm()) == DialogResult.OK) document.Print(); });
            export = new ToolStripButton("خروجی Excel / تصویر", null, (s,e) =>
            {
                if (document == null) return;
                using var dialog = new SaveFileDialog { Filter = "Excel workbook|*.xlsx|PNG images|*.png", FileName = "report.xlsx" };
                if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;
                if (dialog.FilterIndex == 1)
                {
                    string temporary = dialog.FileName + "." + Guid.NewGuid().ToString("N") + ".tmp";
                    try { ReportWorkbook.Save(temporary, model, input); File.Move(temporary, dialog.FileName, true); }
                    finally { if (File.Exists(temporary)) File.Delete(temporary); }
                }
                else for (int i = 0; i < document.PageCount; i++)
                        document.SavePageImage(Path.Combine(Path.GetDirectoryName(dialog.FileName), Path.GetFileNameWithoutExtension(dialog.FileName) + (document.PageCount == 1 ? "" : "-" + (i + 1)) + ".png"), i, 200);
            });
            strip.Items.Add(print); strip.Items.Add(export);
            strip.Items.Add(new ToolStripButton("قبلی", null, (s,e) => { if (preview.StartPage > 0) preview.StartPage--; }));
            strip.Items.Add(new ToolStripButton("بعدی", null, (s,e) => { if (document != null && preview.StartPage + 1 < document.PageCount) preview.StartPage++; }));
            strip.Items.Add(new ToolStripButton("بزرگ‌نمایی", null, (s,e) => { preview.AutoZoom = false; preview.Zoom = preview.Zoom >= 1.5 ? .5 : preview.Zoom + .25; }));
            Controls.Add(preview); Controls.Add(strip);
        }
        public void Open(ReportModel model, ReportInput input)
        {
            preview.Document = null; document?.Dispose();
            this.model = model; this.input = input;
            document = new PortableReportDocument(model, input); preview.Document = document; preview.InvalidatePreview();
        }
        protected override void Dispose(bool disposing) { if (disposing) document?.Dispose(); base.Dispose(disposing); }
    }
}
