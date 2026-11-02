using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

// Source compatibility names keep the recovered event handlers intact. Every
// control below is implemented with the Windows Forms controls in .NET 10.
namespace Janus.Windows.UI
{
    public enum VisualStyle { Standard, OfficeXP, Office2003 }
    public enum BorderStyle { None, Flat, RaisedLight3D }
    public class UIFormatStyle
    {
        public int Alpha { get; set; }
        public Color BackColor { get; set; }
    }
}
namespace Janus.Windows.EditControls
{
    public enum ButtonStyle { Button }
    public enum ComboStyle { DropDown, DropDownList }
    public enum ImageHorizontalAlignment { Empty, AfterText }
    public enum TextAlignment { Near, Center, Far }
    public class UIButton : Button
    {
        private readonly ToolTip tip = new ToolTip();
        private Image sourceImage, sizedImage;
        private Size imageSize;
        public UI.UIFormatStyle ActiveFormatStyle { get; } = new UI.UIFormatStyle();
        public ButtonStyle ButtonStyle { get; set; }
        public Size ImageSize { get => imageSize; set { imageSize = value; ResizeImage(); } }
        public new Image Image
        {
            get => base.Image;
            set { if (value == sizedImage && value != null) return; sourceImage = value; ResizeImage(); }
        }
        private void ResizeImage()
        {
            Image next = null;
            if (sourceImage != null && imageSize.Width > 0 && imageSize.Height > 0)
            {
                float dpi = DeviceDpi / 96f;
                var bounds = new Size(Math.Max(1, (int)(imageSize.Width * dpi)), Math.Max(1, (int)(imageSize.Height * dpi)));
                float scale = Math.Min(bounds.Width / (float)sourceImage.Width, bounds.Height / (float)sourceImage.Height);
                next = new Bitmap(sourceImage, new Size(Math.Max(1, (int)(sourceImage.Width * scale)), Math.Max(1, (int)(sourceImage.Height * scale))));
            }
            var previous = sizedImage;
            sizedImage = next;
            base.Image = next ?? sourceImage;
            previous?.Dispose();
        }
        protected override void OnHandleCreated(EventArgs e) { base.OnHandleCreated(e); ResizeImage(); }
        protected override void OnDpiChangedAfterParent(EventArgs e) { base.OnDpiChangedAfterParent(e); ResizeImage(); }
        public UI.VisualStyle VisualStyle { get; set; }
        public ImageHorizontalAlignment ImageHorizontalAlignment
        {
            get => TextImageRelation == TextImageRelation.TextBeforeImage ? ImageHorizontalAlignment.AfterText : ImageHorizontalAlignment.Empty;
            set => TextImageRelation = value == ImageHorizontalAlignment.AfterText ? TextImageRelation.TextBeforeImage : TextImageRelation.Overlay;
        }
        public TextAlignment TextHorizontalAlignment
        {
            get => TextAlign == ContentAlignment.MiddleRight ? TextAlignment.Far : TextAlign == ContentAlignment.MiddleLeft ? TextAlignment.Near : TextAlignment.Center;
            set => TextAlign = value == TextAlignment.Far ? ContentAlignment.MiddleRight : value == TextAlignment.Near ? ContentAlignment.MiddleLeft : ContentAlignment.MiddleCenter;
        }
        public string ToolTipText { get => tip.GetToolTip(this); set => tip.SetToolTip(this, value); }
        protected override void Dispose(bool disposing) { if (disposing) { tip.Dispose(); base.Image = null; sizedImage?.Dispose(); sizedImage = null; } base.Dispose(disposing); }
    }
    public class UIGroupBox : GroupBox, ISupportInitialize
    {
        public void BeginInit() { SuspendLayout(); }
        public void EndInit() { ResumeLayout(); }
    }
    public class UIRadioButton : RadioButton { }
    public class UIComboBase : ComboBox
    {
        public UI.BorderStyle BorderStyle { get; set; }
        public Font DropListFont { get; set; }
        public StringFormat StringFormat { get; set; }
        public ComboStyle ComboStyle
        {
            get => DropDownStyle == ComboBoxStyle.DropDownList ? ComboStyle.DropDownList : ComboStyle.DropDown;
            set => DropDownStyle = value == ComboStyle.DropDownList ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
        }
    }
    public class UIComboBoxItem
    {
        public string Text { get; set; } = "";
        public object Value { get; set; }
        public UI.UIFormatStyle FormatStyle { get; } = new UI.UIFormatStyle();
        public override string ToString() => Text;
    }
    public sealed class UIComboBoxItemCollection : IEnumerable<UIComboBoxItem>
    {
        private readonly UIComboBox owner;
        internal UIComboBoxItemCollection(UIComboBox owner) { this.owner = owner; }
        public int Count => owner.NativeItems.Count;
        public UIComboBoxItem this[int i] => owner.NativeItems[i] as UIComboBoxItem ?? owner.Wrap(owner.NativeItems[i]);
        public int Add(string text, object value) => owner.NativeItems.Add(new UIComboBoxItem { Text = text, Value = value });
        public int Add(UIComboBoxItem value) => owner.NativeItems.Add(value);
        public void AddRange(UIComboBoxItem[] items) { owner.NativeItems.AddRange(items); }
        public void Clear() { owner.NativeItems.Clear(); }
        public IEnumerator<UIComboBoxItem> GetEnumerator() { for (int i = 0; i < Count; i++) yield return this[i]; }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class UIComboBox : UIComboBase
    {
        internal ComboBox.ObjectCollection NativeItems => base.Items;
        private readonly UIComboBoxItemCollection items;
        private int bindingDepth;
        private bool pendingIndex, pendingValue;
        public UIComboBox() { items = new UIComboBoxItemCollection(this); }
        public new UIComboBoxItemCollection Items => items;
        public new object DataSource
        {
            get => base.DataSource;
            set
            {
                bindingDepth++;
                try { base.DataSource = value; }
                finally { bindingDepth--; }
                FlushSelection();
            }
        }
        private bool SelectionReady => bindingDepth == 0 && (base.DataSource == null || !string.IsNullOrEmpty(ValueMember));
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (!SelectionReady) { pendingIndex = true; return; }
            pendingIndex = false;
            base.OnSelectedIndexChanged(e);
        }
        protected override void OnSelectedValueChanged(EventArgs e)
        {
            if (!SelectionReady) { pendingValue = true; return; }
            pendingValue = false;
            base.OnSelectedValueChanged(e);
        }
        protected override void OnValueMemberChanged(EventArgs e)
        {
            base.OnValueMemberChanged(e);
            FlushSelection();
        }
        private void FlushSelection()
        {
            if (!SelectionReady) return;
            bool index = pendingIndex, value = pendingValue;
            pendingIndex = pendingValue = false;
            if (index) base.OnSelectedIndexChanged(EventArgs.Empty);
            if (value) base.OnSelectedValueChanged(EventArgs.Empty);
        }
        internal UIComboBoxItem Wrap(object item)
        {
            if (item is UIComboBoxItem wrapped) return wrapped;
            return new UIComboBoxItem { Text = GetItemText(item), Value = GetItemValue(item) };
        }
        private object GetItemValue(object item)
        {
            if (item is UIComboBoxItem wrapped) return wrapped.Value;
            if (item is DataRowView row) return string.IsNullOrEmpty(ValueMember) ? null : row[ValueMember];
            return string.IsNullOrEmpty(ValueMember) || item == null ? item : TypeDescriptor.GetProperties(item)[ValueMember]?.GetValue(item);
        }
        public new UIComboBoxItem SelectedItem
        {
            get => base.SelectedItem == null ? null : Wrap(base.SelectedItem);
            set
            {
                if (value == null) SelectedIndex = -1;
                else SelectedValue = value.Value;
            }
        }
        public new object SelectedValue
        {
            get => GetItemValue(base.SelectedItem);
            set
            {
                for (int i = 0; i < base.Items.Count; i++)
                {
                    var actual = GetItemValue(base.Items[i]);
                    if (Equals(actual, value) || (actual != null && value != null && Convert.ToString(actual, CultureInfo.InvariantCulture) == Convert.ToString(value, CultureInfo.InvariantCulture)))
                    { SelectedIndex = i; return; }
                }
                SelectedIndex = -1;
            }
        }
    }
}
namespace Janus.Windows.GridEX.EditControls
{
    public class EditBase : TextBox
    {
        public Font ButtonFont { get; set; }
        public bool AutoScroll { get; set; }
        public Size AutoScrollMargin { get; set; }
        public Size AutoScrollMinSize { get; set; }
        public Point AutoScrollPosition { get; set; }
        public VisualStyle VisualStyle { get; set; }
        public TextAlignment TextAlignment
        {
            get => TextAlign == HorizontalAlignment.Right ? TextAlignment.Far : TextAlign == HorizontalAlignment.Center ? TextAlignment.Center : TextAlignment.Near;
            set => TextAlign = value == TextAlignment.Far ? HorizontalAlignment.Right : value == TextAlignment.Center ? HorizontalAlignment.Center : HorizontalAlignment.Left;
        }
    }
    public class EditBox : EditBase { }
    public class MaskedEditBox : MaskedTextBox
    {
        public Font ButtonFont { get; set; }
        public bool AutoScroll { get; set; }
        public Size AutoScrollMargin { get; set; }
        public Size AutoScrollMinSize { get; set; }
        public Point AutoScrollPosition { get; set; }
        public VisualStyle VisualStyle { get; set; }
        public TextAlignment TextAlignment
        {
            get => TextAlign == HorizontalAlignment.Right ? TextAlignment.Far : TextAlign == HorizontalAlignment.Center ? TextAlignment.Center : TextAlignment.Near;
            set => TextAlign = value == TextAlignment.Far ? HorizontalAlignment.Right : value == TextAlignment.Center ? HorizontalAlignment.Center : HorizontalAlignment.Left;
        }
        public bool Numeric { get; set; }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Numeric && string.IsNullOrEmpty(Mask) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-') e.Handled = true;
            base.OnKeyPress(e);
        }
    }
    public class NumericEditBox : EditBase
    {
        public NumericEditValueType ValueType { get; set; }
        public object Value
        {
            get
            {
                if (!decimal.TryParse(Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var number)) return null;
                return ValueType == NumericEditValueType.Int16 ? (object)Convert.ToInt16(number) : ValueType == NumericEditValueType.Int32 ? (object)Convert.ToInt32(number) : number;
            }
            set => Text = value == null || value == DBNull.Value ? "" : Convert.ToString(value, CultureInfo.CurrentCulture);
        }
    }
}
namespace BijanComponents
{
    public static class ShamsiDate
    {
        public static string[] farsi_month_name = { "حمل", "ثور", "جوزا", "سرطان", "اسد", "سنبله", "میزان", "عقرب", "قوس", "جدی", "دلو", "حوت" };
        public static string GetShamsiDate(DateTime value)
        {
            var pc = new PersianCalendar();
            return string.Format(CultureInfo.InvariantCulture, "{0:0000}/{1:00}/{2:00}", pc.GetYear(value), pc.GetMonth(value), pc.GetDayOfMonth(value));
        }
        public static DateTime ShamsiToGregory(string value)
        {
            value = string.Concat(value.Select(c => c >= '۰' && c <= '۹' ? (char)('0' + c - '۰') : c >= '٠' && c <= '٩' ? (char)('0' + c - '٠') : c));
            var parts = value.Trim().Split('/', '-');
            if (parts.Length != 3) throw new FormatException("تاریخ را به صورت سال/ماه/روز وارد کنید.");
            return new PersianCalendar().ToDateTime(int.Parse(parts[0], CultureInfo.InvariantCulture), int.Parse(parts[1], CultureInfo.InvariantCulture), int.Parse(parts[2], CultureInfo.InvariantCulture), 0, 0, 0, 0);
        }
    }
    public class DatePicker : UserControl
    {
        private readonly TextBox input = new TextBox { Dock = DockStyle.Fill, TextAlign = HorizontalAlignment.Center };
        private readonly DateTimePicker picker = new DateTimePicker { Dock = DockStyle.Right, Width = 24, Format = DateTimePickerFormat.Custom, CustomFormat = " " };
        private DateTime date = DateTime.Today;
        private bool syncing;
        public event EventHandler DateChanged;
        public bool AutoToday { get; set; } = true;
        public Color BijanForeColor { get => input.ForeColor; set => input.ForeColor = value; }
        public string the_label { get; set; }
        public DateTime the_date
        {
            get => date;
            set
            {
                bool changed = date != value;
                date = value;
                syncing = true;
                input.Text = ShamsiDate.GetShamsiDate(value);
                picker.Value = value < picker.MinDate ? picker.MinDate : value > picker.MaxDate ? picker.MaxDate : value;
                syncing = false;
                if (changed) DateChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public DatePicker()
        {
            Controls.Add(input); Controls.Add(picker); Height = input.PreferredHeight;
            the_date = DateTime.Today;
            picker.ValueChanged += (s, e) => { if (!syncing) the_date = picker.Value; };
            input.Validating += (s, e) =>
            {
                try { the_date = ShamsiDate.ShamsiToGregory(input.Text); }
                catch (Exception error) when (error is FormatException || error is ArgumentException || error is OverflowException)
                { e.Cancel = true; input.SelectAll(); }
            };
        }
    }
}
