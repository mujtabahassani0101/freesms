using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataDynamics.ActiveReports.Design
{
    public enum LayoutChangeType { Modified = 0, Loaded = 9, Replaced = 10 }
    public class LayoutChangedArgs : EventArgs { public LayoutChangeType Type { get; } public LayoutChangedArgs(LayoutChangeType type) { Type = type; } }
    public class Selection : ArrayList { }
    public class CommandBarItem { }
    public class CommandBarMenu : CommandBarItem { }
    public class CommandBar { public List<CommandBarItem> Items { get; } = new List<CommandBarItem> { new CommandBarMenu() }; }
    public class CommandBarManager : ToolStrip
    {
        public List<CommandBar> CommandBars { get; } = new List<CommandBar> { new CommandBar() };
        public CommandBarManager() { Dock = DockStyle.Top; }
    }
    public class Designer : UserControl
    {
        private readonly Panel canvas = new Panel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = SystemColors.AppWorkspace };
        private readonly Panel page = new Panel { BackColor = Color.White, Width = 827, Height = 1169 };
        private readonly ComboBox sectionPicker = new ComboBox { Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDownList };
        private Toolbox.Toolbox toolbox;
        private Point drag;
        private PointF original;
        private bool moving;
        private bool grid = true;
        public ActiveReport3 Report { get; private set; } = new ActiveReport3();
        public PropertyGrid PropertyGrid { get; set; }
        public CommandBarManager CommandBarManager { get; } = new CommandBarManager();
        public Selection Selection { get; } = new Selection();
        public bool DrawGrid { get => grid; set { grid = value; page.Invalidate(); } }
        public bool IsDirty { get; set; }
        public bool LockControls { get; set; }
        public bool ReportTabsVisible { get; set; }
        public bool ShowDataSourceIcon { get; set; }
        public object ToolBoxItem { get; set; }
        public Toolbox.Toolbox Toolbox
        {
            get => toolbox;
            set { if (toolbox != null) toolbox.DoubleClick -= AddControl; toolbox = value; if (toolbox != null) toolbox.DoubleClick += AddControl; }
        }
        public event EventHandler SelectionChanged;
        public event EventHandler<LayoutChangedArgs> LayoutChanged;
        private Section Current => sectionPicker.SelectedItem as Section;
        public Designer()
        {
            canvas.Controls.Add(page); Controls.Add(canvas); Controls.Add(sectionPicker);
            CommandBarManager.Items.Add(new ToolStripButton("بازکردن", null, (s,e) => { using var dialog = new OpenFileDialog { Filter = "Report|*.rpx" }; if (dialog.ShowDialog(FindForm()) == DialogResult.OK) LoadReport(dialog.FileName); }));
            CommandBarManager.Items.Add(new ToolStripButton("ذخیره", null, (s,e) => { using var dialog = new SaveFileDialog { Filter = "Report|*.rpx" }; if (dialog.ShowDialog(FindForm()) == DialogResult.OK) SaveReport(dialog.FileName); }));
            CommandBarManager.Items.Add(new ToolStripButton("پیش‌نمایش", null, (s,e) => { Report.Run(false); using var dialog = new Form { Text = "گزارش", WindowState = FormWindowState.Maximized }; dialog.Controls.Add(new Viewer.Viewer { Dock = DockStyle.Fill, Document = Report.Document }); dialog.ShowDialog(FindForm()); }));
            sectionPicker.Format += (s,e) => { if (e.ListItem is Section section) e.Value = section.Name; };
            sectionPicker.FormattingEnabled = true;
            sectionPicker.SelectedIndexChanged += (s,e) => { page.Height = Math.Max(50, (int)((Current?.Height ?? 11) * 100)); Select(null); page.Invalidate(); };
            page.Paint += PaintPage;
            page.MouseDown += (s,e) =>
            {
                var control = Current?.Controls.Reverse().FirstOrDefault(c => new RectangleF(c.Left * 100, c.Top * 100, c.Width * 100, c.Height * 100).Contains(e.Location));
                Select(control); drag = e.Location;
                if (control != null && !LockControls) { original = new PointF(control.Left, control.Top); moving = true; page.Capture = true; }
            };
            page.MouseMove += (s,e) =>
            {
                if (!moving || Selection.Count == 0) return;
                var control = (ARControl)Selection[0];
                control.Left = Math.Max(0, original.X + (e.X - drag.X) / 100f); control.Top = Math.Max(0, original.Y + (e.Y - drag.Y) / 100f);
                MarkDirty(); PropertyGrid?.Refresh(); page.Invalidate();
            };
            page.MouseUp += (s,e) => { moving = false; page.Capture = false; };
        }
        private void Select(ARControl control)
        {
            Selection.Clear(); if (control != null) Selection.Add(control);
            if (PropertyGrid != null)
            {
                PropertyGrid.SelectedObject = control;
                PropertyGrid.PropertyValueChanged -= PropertyChanged;
                PropertyGrid.PropertyValueChanged += PropertyChanged;
            }
            SelectionChanged?.Invoke(this, EventArgs.Empty); page.Invalidate();
        }
        private void PropertyChanged(object sender, PropertyValueChangedEventArgs e) { MarkDirty(); page.Invalidate(); }
        private void MarkDirty() { IsDirty = true; LayoutChanged?.Invoke(this, new LayoutChangedArgs(LayoutChangeType.Modified)); }
        private void AddControl(object sender, EventArgs e)
        {
            if (Current == null || toolbox?.SelectedItem == null) return;
            var control = new ARControl { Name = "field" + (Current.Controls.Count() + 1), Text = "متن", Width = 1.5f, Height = .3f, Left = .25f, Top = .25f };
            if (toolbox.SelectedItem.ToString() != "متن") control.DataField = toolbox.SelectedItem.ToString();
            Current.Controls.Add(control); Select(control); MarkDirty();
        }
        private void PaintPage(object sender, PaintEventArgs e)
        {
            if (grid) for (int y = 0; y < page.Height; y += 10) for (int x = 0; x < page.Width; x += 10) e.Graphics.FillRectangle(Brushes.LightGray, x, y, 1, 1);
            if (Current != null) foreach (var control in Current.Controls) control.Draw(e.Graphics, null, 0, true);
            if (Selection.Count > 0)
            {
                var c = (ARControl)Selection[0];
                using var pen = new Pen(Color.DodgerBlue, 2);
                e.Graphics.DrawRectangle(pen, c.Left * 100, c.Top * 100, c.Width * 100, c.Height * 100);
            }
        }
        public void LoadReport(string path)
        {
            Report.Dispose(); Report = new ActiveReport3(); Report.LoadLayout(path);
            sectionPicker.Items.Clear(); sectionPicker.Items.AddRange(Report.Sections.Cast<object>().ToArray());
            if (sectionPicker.Items.Count > 0) sectionPicker.SelectedIndex = 0;
            IsDirty = false; LayoutChanged?.Invoke(this, new LayoutChangedArgs(LayoutChangeType.Loaded));
        }
        public void SaveReport(string path)
        {
            if (Report.Layout == null) throw new InvalidOperationException("ابتدا یک قالب گزارش باز کنید.");
            Report.Layout.Save(path); IsDirty = false;
        }
        protected override void Dispose(bool disposing) { if (disposing) { Report.Dispose(); CommandBarManager.Dispose(); } base.Dispose(disposing); }
    }
    public class ReportExplorer : UserControl
    {
        private readonly TreeView tree = new TreeView { Dock = DockStyle.Fill };
        public ReportExplorer() { Controls.Add(tree); }
        private ActiveReport3 report;
        public Designer ReportDesigner { get; set; }
        public ActiveReport3 Report
        {
            get => report;
            set
            {
                report = value; tree.Nodes.Clear();
                if (value == null) return;
                foreach (var section in value.Sections)
                {
                    var node = tree.Nodes.Add(section.Name);
                    foreach (var control in section.Controls) node.Nodes.Add(control.Name);
                }
                tree.ExpandAll();
            }
        }
    }
}
namespace DataDynamics.ActiveReports.Design.Toolbox
{
    public class GroupListbar : ListBox, ISupportInitialize
    {
        public ImageList LargeImages { get; set; }
        public ImageList SmallImages { get; set; }
        public object Selected { get => SelectedItem; set => SelectedItem = value; }
        public void BeginInit() { BeginUpdate(); }
        public void EndInit() { EndUpdate(); }
    }
    public class Toolbox : GroupListbar
    {
        public string SelectedCategory { get; set; }
        public Toolbox() { Items.Add("متن"); }
    }
}
