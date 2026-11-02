using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Janus.Windows.GridEX
{
    public enum VisualStyle { Standard, Office2003 }
    public enum TextAlignment { Near, Center, Far }
    public enum NumericEditValueType { Int16, Int32, Decimal }
    public enum InheritableBoolean { Default, False, True }
    public enum FocusStyle { None, Solid }
    public enum GroupRowVisualStyle { Standard, Outlook2003 }
    public enum ButtonAppearance { Regular }
    public enum ColumnType { Text, CheckBox, Image }
    public enum ConditionOperator { Equal }
    public enum RowType { Record, FilterRow }
    public class ControlStyle { public ButtonAppearance ButtonAppearance { get; set; } }
    public class GridEXVisualStyleAreas
    {
        public VisualStyle CheckBoxStyle { get; set; }
        public VisualStyle ControlBorderStyle { get; set; }
        public VisualStyle EditControlsStyle { get; set; }
        public VisualStyle GroupByBoxStyle { get; set; }
        public VisualStyle GroupRowsStyle { get; set; }
        public VisualStyle HeadersStyle { get; set; }
        public VisualStyle ScrollBarsStyle { get; set; }
        public VisualStyle TreeGliphsStyle { get; set; }
    }
    public class GridEXFormatStyle
    {
        internal Action Changed;
        private Color back, fore;
        private Font font;
        public string Key { get; set; }
        public float Blend { get; set; }
        public float FontSize { get; set; }
        public TextAlignment TextAlignment { get; set; }
        public Color BackColor { get => back; set { back = value; Changed?.Invoke(); } }
        public Color ForeColor { get => fore; set { fore = value; Changed?.Invoke(); } }
        public Font Font { get => font; set { font = value; Changed?.Invoke(); } }
        internal void Apply(DataGridViewCellStyle target)
        {
            if (!back.IsEmpty) target.BackColor = back;
            if (!fore.IsEmpty) target.ForeColor = fore;
            if (font != null) target.Font = font;
        }
    }
    public sealed class GridEXValueListItem
    {
        public object Value { get; }
        public string Text { get; }
        public GridEXValueListItem(object value, string text) { Value = value; Text = text; }
    }
    public sealed class GridEXValueListItemCollection : List<GridEXValueListItem>
    {
        internal Action Changed;
        public new void Add(GridEXValueListItem item) { base.Add(item); Changed?.Invoke(); }
    }
    public class GridEXColumn
    {
        internal Action Changed;
        internal bool Editable = true;
        internal ColumnType Type;
        internal string DataMember;
        internal string Aggregate;
        internal string InputMask;
        private string caption = "";
        private bool visible = true, sortable = true, selectable = true, list;
        private int width = 100;
        public string Key { get; set; }
        public string Caption { get => caption; set { caption = value; Changed?.Invoke(); } }
        public bool Visible { get => visible; set { visible = value; Changed?.Invoke(); } }
        public bool AllowSort { get => sortable; set { sortable = value; Changed?.Invoke(); } }
        public bool Selectable { get => selectable; set { selectable = value; Changed?.Invoke(); } }
        public bool HasValueList { get => list; set { list = value; Changed?.Invoke(); } }
        public int Width { get => width; set { width = value; Changed?.Invoke(); } }
        public GridEXValueListItemCollection ValueList { get; } = new GridEXValueListItemCollection();
    }
    public class GridEXColumnCollection : IEnumerable<GridEXColumn>
    {
        private readonly List<GridEXColumn> items = new List<GridEXColumn>();
        private readonly GridEX owner;
        internal GridEXColumnCollection(GridEX owner) { this.owner = owner; }
        public int Count => items.Count;
        public GridEXColumn this[int index] => items[index];
        public GridEXColumn this[string key] => items.FirstOrDefault(x => string.Equals(x.Key, key, StringComparison.OrdinalIgnoreCase)) ?? throw new ArgumentException("Unknown grid column: " + key);
        public GridEXColumn Add(string key, ColumnType type)
        {
            var column = new GridEXColumn { Key = key, DataMember = key, Caption = key, Type = type };
            Add(column); return column;
        }
        internal void Add(GridEXColumn column)
        {
            column.Changed = () => owner.ApplyColumn(column);
            column.ValueList.Changed = () => owner.ApplyColumn(column);
            items.Add(column);
            owner.RebuildColumns();
        }
        public void Clear() { items.Clear(); owner.RebuildColumns(); }
        public IEnumerator<GridEXColumn> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class GridEXFormatCondition
    {
        internal GridEXColumn Column;
        internal object Value;
        public GridEXFormatStyle FormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatCondition(GridEXColumn column, ConditionOperator operation, object value) { Column = column; Value = value; }
    }
    public class GridEXFormatConditionCollection : List<GridEXFormatCondition> { }
    public class GridEXTable
    {
        internal GridEXTable(GridEX grid) { Columns = new GridEXColumnCollection(grid); }
        public GridEXColumnCollection Columns { get; }
        public GridEXFormatConditionCollection FormatConditions { get; } = new GridEXFormatConditionCollection();
    }
    public class GridEXLayout { public string LayoutString { get; set; } }
    public class ColumnActionEventArgs : EventArgs
    {
        public GridEXColumn Column { get; }
        public ColumnActionEventArgs(GridEXColumn column) { Column = column; }
    }
    public class RowLoadEventArgs : EventArgs
    {
        public GridEXRow Row { get; }
        public RowLoadEventArgs(GridEXRow row) { Row = row; }
    }
    public class GridEXCell
    {
        private readonly GridEXRow row;
        public GridEXColumn Column { get; }
        private GridEXFormatStyle style = new GridEXFormatStyle();
        public GridEXFormatStyle FormatStyle
        {
            get => style;
            set
            {
                style = value ?? new GridEXFormatStyle();
                style.Changed = () => { var cell = NativeCell; if (cell != null) style.Apply(cell.Style); };
                style.Changed();
            }
        }
        internal GridEXCell(GridEXRow row, GridEXColumn column)
        {
            this.row = row; Column = column;
            FormatStyle.Changed = () => { var cell = NativeCell; if (cell != null) FormatStyle.Apply(cell.Style); };
        }
        private DataGridViewCell NativeCell => row.NativeRow?.Cells[Column.Key];
        public object Value
        {
            get
            {
                if (row.DataRow != null && row.DataRow.Table.Columns.Contains(Column.DataMember)) return row.DataRow[Column.DataMember];
                return NativeCell?.Value;
            }
            set
            {
                if (row.DataRow != null && row.DataRow.Table.Columns.Contains(Column.DataMember)) row.DataRow[Column.DataMember] = value ?? DBNull.Value;
                else if (NativeCell != null) NativeCell.Value = value;
            }
        }
        public string Text { get => Convert.ToString(Value, CultureInfo.CurrentCulture) ?? ""; set => Value = value; }
    }
    public class GridEXCellCollection
    {
        private readonly GridEXRow row;
        private readonly Dictionary<string, GridEXCell> cells = new Dictionary<string, GridEXCell>(StringComparer.OrdinalIgnoreCase);
        internal GridEXCellCollection(GridEXRow row) { this.row = row; }
        public GridEXCell this[string key]
        {
            get
            {
                if (!cells.TryGetValue(key, out var cell)) cells[key] = cell = new GridEXCell(row, row.Grid.RootTable.Columns[key]);
                return cell;
            }
        }
        public GridEXCell this[int index] => this[row.Grid.RootTable.Columns[index].Key];
    }
    public class GridEXRow
    {
        internal readonly GridEX Grid;
        internal DataGridViewRow NativeRow;
        internal DataRow DataRow => (NativeRow?.DataBoundItem as DataRowView)?.Row;
        public GridEXCellCollection Cells { get; }
        internal GridEXRow(GridEX owner, DataGridViewRow row) { Grid = owner; NativeRow = row; Cells = new GridEXCellCollection(this); }
        public void BeginEdit() { DataRow?.BeginEdit(); }
        public void EndEdit() { DataRow?.EndEdit(); Grid.EndEdit(); }
    }
    public class GridEXSelectedItem
    {
        private readonly GridEXRow row;
        internal GridEXSelectedItem(GridEXRow row) { this.row = row; }
        public RowType RowType => RowType.Record;
        public GridEXRow GetRow() => row;
    }
    public class GridEXSelectedItemCollection : IEnumerable<GridEXSelectedItem>
    {
        private readonly GridEX owner;
        internal GridEXSelectedItemCollection(GridEX owner) { this.owner = owner; }
        private DataGridViewRow[] Rows => owner.View.SelectedRows.Cast<DataGridViewRow>().OrderBy(r => r.Index).ToArray();
        public int Count => Rows.Length;
        public GridEXSelectedItem this[int index] => new GridEXSelectedItem(owner.Wrap(Rows[index]));
        public IEnumerator<GridEXSelectedItem> GetEnumerator() => Rows.Select(r => new GridEXSelectedItem(owner.Wrap(r))).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class GridEX : UserControl, ISupportInitialize
    {
        internal readonly DataGridView View = new DataGridView
        {
            Dock = DockStyle.Fill, AutoGenerateColumns = false, AllowUserToAddRows = false,
            AllowUserToDeleteRows = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false, RowHeadersVisible = false, BackgroundColor = SystemColors.Window,
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        };
        private readonly TextBox search = new TextBox { Dock = DockStyle.Top, PlaceholderText = "جستجو در جدول…" };
        private readonly BindingSource binding = new BindingSource();
        private readonly BindingNavigator navigator;
        private readonly Label totals = new Label { Dock = DockStyle.Bottom, AutoSize = false, Height = 26, TextAlign = ContentAlignment.MiddleRight, Visible = false };
        private readonly Dictionary<DataGridViewRow, GridEXRow> rows = new Dictionary<DataGridViewRow, GridEXRow>();
        private bool loading;
        private bool building;
        private bool groupVisible = true;
        private object source;
        private string dataMember;
        private GridEXLayout layout;
        private InheritableBoolean editable = InheritableBoolean.True;
        public event EventHandler SelectionChanged;
        public event EventHandler LayoutLoad;
        public event EventHandler SortKeysChanged;
        public event EventHandler<ColumnActionEventArgs> CellUpdated;
        public event EventHandler<ColumnActionEventArgs> CellValueChanged;
        public event EventHandler<RowLoadEventArgs> FormattingRow;

        public GridEXTable RootTable { get; }
        public GridEXTable[] Tables => new[] { RootTable };
        public GridEXSelectedItemCollection SelectedItems { get; }
        public GridEXFormatStyle HeaderFormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatStyle RowFormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatStyle SelectedFormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatStyle FocusCellFormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatStyle GroupByBoxFormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatStyle GroupByBoxInfoFormatStyle { get; } = new GridEXFormatStyle();
        public GridEXFormatStyle GroupTotalRowFormatStyle { get; } = new GridEXFormatStyle();
        public ControlStyle EditorsControlStyle { get; } = new ControlStyle();
        public GridEXVisualStyleAreas VisualStyleAreas { get; } = new GridEXVisualStyleAreas();
        public VisualStyle VisualStyle { get; set; }
        public FocusStyle FocusStyle { get; set; }
        public GroupRowVisualStyle GroupRowVisualStyle { get; set; }
        public ImageList ExternalImageList { get; set; }
        public string BuiltInTextsData { get; set; }
        public string CardCaptionPrefix { get; set; }
        public Color FlatBorderColor { get; set; }
        public bool GroupByBoxVisible { get => groupVisible; set { groupVisible = value; search.Visible = value; } }
        public bool ColumnAutoResize
        {
            get => View.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.Fill;
            set => View.AutoSizeColumnsMode = value ? DataGridViewAutoSizeColumnsMode.Fill : DataGridViewAutoSizeColumnsMode.None;
        }
        public InheritableBoolean AllowEdit { get => editable; set { editable = value; View.ReadOnly = value == InheritableBoolean.False; } }
        public InheritableBoolean RowHeaders { get => View.RowHeadersVisible ? InheritableBoolean.True : InheritableBoolean.False; set => View.RowHeadersVisible = value == InheritableBoolean.True; }
        public bool RecordNavigator { get => navigator.Visible; set => navigator.Visible = value; }
        public InheritableBoolean TotalRow { get => totals.Visible ? InheritableBoolean.True : InheritableBoolean.False; set { totals.Visible = value == InheritableBoolean.True; UpdateTotals(); } }
        public Color GridLineColor { get => View.GridColor; set => View.GridColor = value; }
        public int RecordCount => binding.Count;
        public int RowCount => binding.Count;
        public int Row
        {
            get => View.CurrentCell?.RowIndex ?? -1;
            set
            {
                if (value < 0 || value >= View.Rows.Count) return;
                var column = View.CurrentCell?.OwningColumn ?? View.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible);
                if (column != null) View.CurrentCell = View.Rows[value].Cells[column.Index];
            }
        }
        public GridEXColumn CurrentColumn
        {
            get => View.CurrentCell == null ? null : RootTable.Columns[View.CurrentCell.OwningColumn.Name];
            set { if (value != null && Row >= 0 && View.Columns.Contains(value.Key) && View.Columns[value.Key].Visible) View.CurrentCell = View.Rows[Row].Cells[value.Key]; }
        }
        public string DataMember { get => dataMember; set { dataMember = value; Bind(); } }
        public object DataSource { get => source; set { source = value; Bind(); } }
        public GridEXLayout DesignTimeLayout
        {
            get => layout;
            set { layout = value; LoadLayout(value?.LayoutString); LayoutLoad?.Invoke(this, EventArgs.Empty); }
        }
        public GridEX()
        {
            RootTable = new GridEXTable(this);
            SelectedItems = new GridEXSelectedItemCollection(this);
            navigator = new BindingNavigator(false) { Dock = DockStyle.Bottom, BindingSource = binding, Visible = false };
            navigator.AddStandardItems();
            navigator.AddNewItem = null; navigator.DeleteItem = null;
            // AddStandardItems includes add/delete buttons; remove them from the visible strip.
            foreach (ToolStripItem item in navigator.Items.Cast<ToolStripItem>().Where(i => i.Name.Contains("AddNew") || i.Name.Contains("Delete")).ToArray()) navigator.Items.Remove(item);
            Controls.Add(View); Controls.Add(search); Controls.Add(totals); Controls.Add(navigator);
            View.DataSource = binding;
            View.SelectionChanged += (s, e) => { if (!loading && !building) SelectionChanged?.Invoke(this, e); };
            View.CellValueChanged += (s, e) =>
            {
                if (loading || building || e.RowIndex < 0 || e.ColumnIndex < 0) return;
                var args = new ColumnActionEventArgs(RootTable.Columns[View.Columns[e.ColumnIndex].Name]);
                CellValueChanged?.Invoke(this, args); UpdateTotals();
            };
            View.CellEndEdit += (s, e) => { if (!loading && e.ColumnIndex >= 0) { EndEdit(); CellUpdated?.Invoke(this, new ColumnActionEventArgs(RootTable.Columns[View.Columns[e.ColumnIndex].Name])); } };
            View.CurrentCellDirtyStateChanged += (s, e) => { if (View.CurrentCell is DataGridViewCheckBoxCell && View.IsCurrentCellDirty) View.CommitEdit(DataGridViewDataErrorContexts.Commit); };
            View.Sorted += (s, e) => SortKeysChanged?.Invoke(this, e);
            View.Scroll += (s, e) => OnScroll(e);
            View.Click += (s, e) => OnClick(e);
            View.MouseDown += (s, e) => OnMouseDown(e);
            View.MouseUp += (s, e) => OnMouseUp(e);
            View.KeyUp += (s, e) => OnKeyUp(e);
            View.DoubleClick += (s, e) => OnDoubleClick(e);
            View.KeyDown += (s, e) => OnKeyDown(e);
            View.KeyPress += (s, e) => OnKeyPress(e);
            View.CellFormatting += FormatCell;
            View.CellValidating += (s, e) =>
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
                var column = RootTable.Columns[View.Columns[e.ColumnIndex].Name];
                if (!string.IsNullOrEmpty(column.InputMask) && Convert.ToString(e.FormattedValue, CultureInfo.CurrentCulture) is string text && text.Length > 0)
                {
                    bool valid = decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out var number);
                    if (column.InputMask == "Number0") valid &= number == decimal.Truncate(number);
                    e.Cancel = !valid;
                    View.Rows[e.RowIndex].ErrorText = valid ? "" : "مقدار عددی معتبر وارد کنید.";
                }
            };
            View.DataBindingComplete += (s, e) => { rows.Clear(); UpdateTotals(); };
            search.TextChanged += (s, e) => Filter();
            HeaderFormatStyle.Changed = () => HeaderFormatStyle.Apply(View.ColumnHeadersDefaultCellStyle);
            RowFormatStyle.Changed = () => RowFormatStyle.Apply(View.DefaultCellStyle);
            SelectedFormatStyle.Changed = () =>
            {
                if (!SelectedFormatStyle.BackColor.IsEmpty) View.DefaultCellStyle.SelectionBackColor = SelectedFormatStyle.BackColor;
                if (!SelectedFormatStyle.ForeColor.IsEmpty) View.DefaultCellStyle.SelectionForeColor = SelectedFormatStyle.ForeColor;
            };
        }
        public void BeginInit() { loading = true; SuspendLayout(); }
        public void EndInit() { loading = false; ResumeLayout(); RebuildColumns(); }
        internal GridEXRow Wrap(DataGridViewRow row)
        {
            if (!rows.TryGetValue(row, out var wrapped)) rows[row] = wrapped = new GridEXRow(this, row);
            return wrapped;
        }
        public GridEXRow GetRow(int index) => Wrap(View.Rows[index]);
        public GridEXRow GetRow() => GetRow(Row);
        public void MoveNext() { Row = Math.Min(RowCount - 1, Row + 1); }
        public void MovePrevious() { Row = Math.Max(0, Row - 1); }
        public void SelectCurrentCellText() { View.BeginEdit(true); (View.EditingControl as TextBox)?.SelectAll(); }
        public void EndEdit() { View.EndEdit(); binding.EndEdit(); }
        public void Refetch() { EndEdit(); binding.ResetBindings(false); UpdateTotals(); }
        public override void Refresh() { View.Refresh(); base.Refresh(); }
        protected override void OnFontChanged(EventArgs e) { base.OnFontChanged(e); if (View != null) View.Font = Font; }
        protected override void OnRightToLeftChanged(EventArgs e) { base.OnRightToLeftChanged(e); if (View != null) View.RightToLeft = RightToLeft; }
        private void Bind()
        {
            if (RootTable == null) return;
            loading = true;
            try
            {
                object table = source;
                if (source is DataSet ds) table = !string.IsNullOrEmpty(dataMember) && ds.Tables.Contains(dataMember) ? ds.Tables[dataMember] : ds.Tables.Count > 0 ? ds.Tables[0] : null;
                if (table is DataTable dt) table = new DataView(dt);
                if (table is DataView dv)
                {
                    foreach (DataColumn col in dv.Table.Columns)
                        if (!RootTable.Columns.Any(c => string.Equals(c.DataMember, col.ColumnName, StringComparison.OrdinalIgnoreCase)))
                            RootTable.Columns.Add(col.ColumnName, col.DataType == typeof(bool) ? ColumnType.CheckBox : col.DataType == typeof(byte[]) ? ColumnType.Image : ColumnType.Text);
                }
                binding.DataSource = table;
                RebuildColumns(); Filter();
            }
            finally { loading = false; }
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }
        private void LoadLayout(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml)) return;
            var root = XElement.Parse(xml).Element("RootTable");
            if (root == null) return;
            building = true;
            try
            {
                RootTable.Columns.Clear();
                var columns = root.Element("Columns");
                if (columns != null)
                    foreach (var node in columns.Elements().OrderBy(x => (int?)x.Element("Position") ?? 0))
                    {
                        string key = (string)node.Element("Key") ?? (string)node.Attribute("ID");
                        var column = new GridEXColumn
                        {
                            Key = key, DataMember = (string)node.Element("DataMember") ?? key,
                            Caption = (string)node.Element("Caption") ?? key,
                            Width = (int?)node.Element("Width") ?? 100,
                            Visible = !string.Equals((string)node.Element("Visible"), "False", StringComparison.OrdinalIgnoreCase),
                            Editable = !string.Equals((string)node.Element("EditType"), "NoEdit", StringComparison.OrdinalIgnoreCase),
                            Type = (string)node.Element("ColumnType") == "CheckBox" ? ColumnType.CheckBox : ((string)node.Element("ColumnType") == "Image" || (string)node.Element("ColumnType") == "BoundImage") ? ColumnType.Image : ColumnType.Text,
                            Aggregate = (string)node.Element("AggregateFunction"),
                            InputMask = (string)node.Element("InputMask"),
                            Selectable = !string.Equals((string)node.Element("Selectable"), "False", StringComparison.OrdinalIgnoreCase)
                        };
                        RootTable.Columns.Add(column);
                    }
            }
            finally { building = false; }
            RebuildColumns();
        }
        internal void RebuildColumns()
        {
            if (building || RootTable == null) return;
            building = true;
            try
            {
                View.Columns.Clear();
                foreach (var model in RootTable.Columns)
                {
                    DataGridViewColumn native = model.Type == ColumnType.CheckBox ? new DataGridViewCheckBoxColumn() : model.Type == ColumnType.Image ? new DataGridViewImageColumn { ImageLayout = DataGridViewImageCellLayout.Zoom } : new DataGridViewTextBoxColumn();
                    native.Name = model.Key; native.DataPropertyName = model.DataMember; native.HeaderText = model.Caption;
                    View.Columns.Add(native); ApplyColumn(model);
                }
            }
            finally { building = false; }
        }
        internal void ApplyColumn(GridEXColumn model)
        {
            if (View == null || !View.Columns.Contains(model.Key)) return;
            var native = View.Columns[model.Key];
            if (model.HasValueList && model.ValueList.Count > 0 && native is not DataGridViewComboBoxColumn)
            {
                int index = native.Index;
                native = new DataGridViewComboBoxColumn { Name = model.Key, DataPropertyName = model.DataMember, DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton, FlatStyle = FlatStyle.Flat };
                View.Columns.RemoveAt(index); View.Columns.Insert(index, native);
            }
            if (native is DataGridViewComboBoxColumn combo)
            {
                var dataType = (binding.DataSource as DataView)?.Table.Columns.Cast<DataColumn>().FirstOrDefault(c => c.ColumnName.Equals(model.DataMember, StringComparison.OrdinalIgnoreCase))?.DataType;
                var options = model.ValueList.Select(v => new ValueOption { Text = v.Text, Value = dataType == null || v.Value == null ? v.Value : Convert.ChangeType(v.Value, dataType, CultureInfo.InvariantCulture) }).ToArray();
                combo.DisplayMember = nameof(ValueOption.Text); combo.ValueMember = nameof(ValueOption.Value); combo.DataSource = options;
            }
            native.HeaderText = model.Caption; native.Width = Math.Max(2, model.Width); native.Visible = model.Visible;
            native.ReadOnly = !model.Editable || !model.Selectable;
            native.SortMode = model.AllowSort ? DataGridViewColumnSortMode.Automatic : DataGridViewColumnSortMode.NotSortable;
        }
        private sealed class ValueOption { public object Value { get; set; } public string Text { get; set; } }
        private void Filter()
        {
            if (binding.DataSource is not DataView data) return;
            string text = search.Text.Replace("'", "''").Replace("[", "[[]").Replace("%", "[%]").Replace("*", "[*]");
            data.RowFilter = string.IsNullOrEmpty(text) ? "" : string.Join(" OR ", data.Table.Columns.Cast<DataColumn>().Where(c => c.DataType != typeof(byte[])).Select(c => "Convert([" + c.ColumnName.Replace("]", "\\]") + "], 'System.String') LIKE '%" + text + "%'") );
            UpdateTotals();
        }
        private void FormatCell(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (building || loading || e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= View.Rows.Count) return;
            var row = Wrap(View.Rows[e.RowIndex]);
            if (e.ColumnIndex == 0) FormattingRow?.Invoke(this, new RowLoadEventArgs(row));
            foreach (var condition in RootTable.FormatConditions)
            {
                var value = row.Cells[condition.Column.Key].Value;
                if (Convert.ToString(value, CultureInfo.InvariantCulture) == Convert.ToString(condition.Value, CultureInfo.InvariantCulture)) condition.FormatStyle.Apply(e.CellStyle);
            }
        }
        private void UpdateTotals()
        {
            if (!totals.Visible) return;
            var parts = new List<string> { "تعداد: " + binding.Count.ToString(CultureInfo.CurrentCulture) };
            if (binding.DataSource is DataView data)
                foreach (var column in RootTable.Columns.Where(c => !string.IsNullOrEmpty(c.Aggregate) && c.Aggregate != "None" && data.Table.Columns.Contains(c.DataMember)))
                {
                    var values = data.Cast<DataRowView>().Select(r => r[column.DataMember]).Where(v => v != DBNull.Value).Select(v => Convert.ToDecimal(v, CultureInfo.InvariantCulture)).ToArray();
                    decimal number = column.Aggregate == "Average" ? (values.Length == 0 ? 0 : values.Average()) : column.Aggregate == "Count" ? values.Length : values.Sum();
                    parts.Add(column.Caption + ": " + number.ToString("0.##", CultureInfo.CurrentCulture));
                }
            totals.Text = string.Join("     ", parts);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing) { binding.Dispose(); rows.Clear(); }
            base.Dispose(disposing);
        }
    }
    public class GridEXPrintDocument : PrintDocument
    {
        public GridEX GridEX { get; set; }
        public string PageFooterLeft { get; set; }
        public string PageFooterRight { get; set; }
        public string PageHeaderCenter { get; set; }
        public string PageHeaderLeft { get; set; }
        public string PageHeaderRight { get; set; }
        private int position;
        protected override void OnBeginPrint(PrintEventArgs e) { position = 0; base.OnBeginPrint(e); }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);
            if (GridEX == null) return;
            var columns = GridEX.RootTable.Columns.Where(c => c.Visible).ToArray();
            if (columns.Length == 0) return;
            using var font = new Font(GridEX.Font.FontFamily, 9);
            using var title = new Font(font, FontStyle.Bold);
            using var format = new StringFormat { Alignment = StringAlignment.Far, FormatFlags = StringFormatFlags.DirectionRightToLeft, Trimming = StringTrimming.EllipsisCharacter };
            float y = e.MarginBounds.Top;
            e.Graphics.DrawString(PageHeaderRight + "    " + PageHeaderCenter + "    " + PageHeaderLeft, title, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, 28), format);
            y += 32;
            float width = e.MarginBounds.Width / (float)columns.Length;
            for (int i = 0; i < columns.Length; i++) Draw(columns[i].Caption, i, y, title);
            y += 25;
            while (position < GridEX.RowCount && y + 25 < e.MarginBounds.Bottom - 25)
            {
                var row = GridEX.GetRow(position++);
                for (int i = 0; i < columns.Length; i++) Draw(row.Cells[columns[i].Key].Text, i, y, font);
                y += 25;
            }
            e.Graphics.DrawString(PageFooterRight + "    " + PageFooterLeft, font, Brushes.Black, new RectangleF(e.MarginBounds.Left, e.MarginBounds.Bottom - 22, e.MarginBounds.Width, 22), format);
            e.HasMorePages = position < GridEX.RowCount;
            void Draw(string text, int index, float top, Font cellFont)
            {
                var rect = new RectangleF(e.MarginBounds.Right - width * (index + 1), top, width, 25);
                e.Graphics.DrawRectangle(Pens.Gray, rect.X, rect.Y, rect.Width, rect.Height);
                e.Graphics.DrawString(text, cellFont, Brushes.Black, rect, format);
            }
        }
    }
}
