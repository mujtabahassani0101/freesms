using System.Drawing.Text;
using System.Text.Json;
using FreeSms.Core;

namespace FreeSms.Windows;

public sealed class BufferedPanel : Panel
{
    public BufferedPanel() { DoubleBuffered = true; ResizeRedraw = true; }
}

public sealed class RecoveredForm : Form
{
    public AppRuntime Runtime { get; }
    public JsonElement Definition { get; }
    public Dictionary<string, Control> Widgets { get; } = new(StringComparer.OrdinalIgnoreCase);
    public UiController? Controller { get; private set; }
    public bool Busy { get; private set; }
    public Panel Surface { get; } = new BufferedPanel { Location = Point.Empty };
    private readonly Dictionary<string, Control> variables = new(StringComparer.Ordinal);
    private readonly Dictionary<string, Image> images = new(StringComparer.Ordinal);
    private readonly Dictionary<(string Family, float Size, FontStyle Style), Font> fontCache = [];
    private readonly PrivateFontCollection fonts = new();
    private readonly System.Windows.Forms.Timer searchTimer = new() { Interval = 300 };
    private readonly Label status = new() { AutoSize = true, BackColor = Color.LightYellow, Padding = new Padding(6) };
    private readonly int? student;
    private bool loaded;
    private bool resourcesDisposed;
    private Icon? ownedIcon;

    public RecoveredForm(AppRuntime runtime, JsonElement definition, int? student = null)
    {
        Runtime = runtime; Definition = definition; this.student = student;
        SuspendLayout();
        DoubleBuffered = true;
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoScaleDimensions = new SizeF(96, 96);
        RightToLeft = RightToLeft.Yes;
        AutoScroll = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = definition.S("text", definition.S("name")) + (runtime.Preview ? " — پیش‌نمایش" : " — .NET 10");
        var size = definition.A("clientsize");
        ClientSize = size.Length == 2 ? new(size[0].GetInt32(), size[1].GetInt32()) : new(800, 600);
        Surface.Size = ClientSize;
        Surface.RightToLeft = RightToLeft.Yes;
        Surface.BackgroundImage = ImageFor(definition.S("image"));
        Surface.BackgroundImageLayout = ImageLayout.Stretch;
        var fontPath = Path.Combine(runtime.Root, "native/assets/BNAZANIN.TTF");
        if (File.Exists(fontPath)) { fonts.AddFontFile(fontPath); Font = FontFor(fonts.Families[0].Name, 12, FontStyle.Regular); }
        var icon = Path.Combine(runtime.Root, "native/assets/app.ico");
        if (File.Exists(icon)) { ownedIcon = new Icon(icon); Icon = ownedIcon; }
        Controls.Add(Surface);
        variables["this"] = Surface;
        var pending = definition.A("controls").ToList();
        while (pending.Count > 0)
        {
            var ready = pending.Where(c => variables.ContainsKey(c.S("parent", "this"))).ToArray();
            if (ready.Length == 0) { foreach (var c in pending) MakeControl(c, Surface); break; }
            foreach (var control in ready) { MakeControl(control, variables[control.S("parent", "this")]); pending.Remove(control); }
        }
        MakeMenus();
        Controls.Add(status); status.BringToFront(); status.Visible = false;
        searchTimer.Tick += async (_, _) => { searchTimer.Stop(); if (Busy) searchTimer.Start(); else if (Controller is not null) await OperationAsync(Controller.RefreshAsync); };
        Shown += async (_, _) => await OperationAsync(LoadAsync);
        FormClosed += (_, _) => Runtime.Forms.Remove(this);
        Runtime.Forms.Add(this);
        ResumeLayout(false);
    }

    public void QueueRefresh() { if (!loaded) return; searchTimer.Stop(); searchTimer.Start(); }

    public async Task OperationAsync(Func<Task> action)
    {
        if (Busy || IsDisposed) return;
        Busy = true; UseWaitCursor = true; Surface.Enabled = false;
        try { await action(); }
        catch (Exception error) { if (!IsDisposed) MessageBox.Show(this, error.Message, "عملیات انجام نشد", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        finally { Busy = false; if (!IsDisposed) { UseWaitCursor = false; Surface.Enabled = true; } }
    }

    private async Task LoadAsync()
    {
        if (Runtime.Preview) { loaded = true; return; }
        status.Text = "آماده‌سازی بانک اطلاعاتی..."; status.Visible = true;
        try
        {
            await Runtime.InitializeAsync(new Progress<string>(message => { if (!IsDisposed) status.Text = message; }));
            if (IsDisposed) return;
            Controller = new UiController(this, Runtime.School!, student);
            await Controller.InitializeAsync();
            loaded = true;
        }
        catch { Surface.Enabled = false; throw; }
        finally { if (!IsDisposed) status.Visible = false; }
    }

    private async Task DispatchAsync(JsonElement control)
    {
        var name = control.S("name").ToLowerInvariant();
        if (name.Contains("close", StringComparison.Ordinal) || name.Contains("exit", StringComparison.Ordinal) || control.S("text").Trim() is "خروج" or "بستن") { Close(); return; }
        await OperationAsync(async () =>
        {
            if (!Runtime.Preview && !loaded) { await LoadAsync(); if (!loaded) return; }
            if (Controller is not null && await Controller.HandleAsync(control.S("name"))) return;
            if (Runtime.Catalog.Target(Definition, control) is { } target) { Runtime.Open(target.S("name"), this); return; }
            MessageBox.Show(this, Runtime.Preview ? "پیش‌نمایش فقط‌خواندنی است." : "عملیات این بخش هنوز تکمیل نشده است.", "Free SMS");
        });
    }

    private void MakeControl(JsonElement metadata, Control parent)
    {
        var type = metadata.S("type");
        Control? control = type switch
        {
            "Label" => new Label { TextAlign = ContentAlignment.MiddleRight },
            "EditBox" or "TextBox" or "MaskedEditBox" or "NumericEditBox" or "DatePicker" => new TextBox { ReadOnly = Runtime.Preview, BorderStyle = BorderStyle.FixedSingle },
            "Button" or "UIButton" => new Button(),
            "CheckBox" or "UICheckBox" => new CheckBox(),
            "RadioButton" or "UIRadioButton" => new RadioButton(),
            "UIComboBox" or "ComboBox" => new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList },
            "NumericUpDown" => new NumericUpDown { Maximum = 10000 },
            "GridEX" => new DataGridView { ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, RowHeadersVisible = false, MultiSelect = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect, VirtualMode = true, AutoGenerateColumns = false },
            "Panel" or "Splitter" => new BufferedPanel(),
            "UIGroupBox" or "GroupBox" => new GroupBox(),
            "PictureBox" => new PictureBox { SizeMode = PictureBoxSizeMode.StretchImage },
            "ProgressBar" => new ProgressBar(),
            "MenuStrip" => new MenuStrip(),
            _ => null
        };
        if (control is null) return; // Includes all legacy COM/hardware components.
        control.Name = metadata.S("name", metadata.S("variable"));
        control.Text = metadata.S("text");
        control.RightToLeft = RightToLeft.Yes;
        var location = metadata.A("location"); var size = metadata.A("size");
        control.SetBounds(location.Length == 2 ? location[0].GetInt32() : 0, location.Length == 2 ? location[1].GetInt32() : 0,
            size.Length == 2 ? Math.Max(1, size[0].GetInt32()) : 100, size.Length == 2 ? Math.Max(1, size[1].GetInt32()) : 24);
        control.TabIndex = metadata.I("tabindex");
        var font = metadata.Get("font");
        if (font.ValueKind == JsonValueKind.Object)
        {
            var points = font.Get("pt");
            control.Font = FontFor(font.S("family", Font.Name), points.ValueKind == JsonValueKind.Number ? points.GetSingle() : 10, font.B("bold") ? FontStyle.Bold : FontStyle.Regular);
        }
        if (ReadColor(metadata.Get("backcolor")) is { } back) control.BackColor = back;
        if (ReadColor(metadata.Get("forecolor")) is { } fore) control.ForeColor = fore;
        if (control is TextBox text) { text.UseSystemPasswordChar = metadata.B("password"); if (metadata.I("maxlength") > 0) text.MaxLength = metadata.I("maxlength"); }
        if (control is CheckBox check) check.Checked = metadata.B("checked");
        if (control is RadioButton radio) radio.Checked = metadata.B("checked");
        if (control is ComboBox combo) combo.Items.AddRange(metadata.A("options").Select(v => (object)(v.GetString() ?? "")).ToArray());
        if (control is PictureBox picture) picture.Image = ImageFor(metadata.S("image"));
        if (control is Button button) { button.Click += async (_, _) => await DispatchAsync(metadata); button.Image = null; }
        if (control is DataGridView grid) MakeColumns(grid, metadata);
        control.Enabled = Runtime.Preview ? control is not ComboBox and not CheckBox and not RadioButton and not NumericUpDown : metadata.B("enabled", true);
        if (control is not MenuStrip) control.Visible = metadata.B("visible", true);
        parent.Controls.Add(control);
        variables[metadata.S("variable")] = control;
        Widgets[control.Name] = control;
    }

    private void MakeColumns(DataGridView grid, JsonElement metadata)
    {
        var layouts = Definition.A("layouts");
        var layout = layouts.FirstOrDefault(l => l.S("resource") == metadata.S("gridlayout"));
        if (layout.ValueKind == JsonValueKind.Undefined) layout = layouts.FirstOrDefault();
        foreach (var column in layout.A("columns").Where(c => c.S("Visible") != "False"))
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = column.S("DataMember", column.S("Key")), HeaderText = column.S("Caption", column.S("Key")), Width = int.TryParse(column.S("Width"), out var width) ? Math.Max(width, 20) : 100, SortMode = DataGridViewColumnSortMode.NotSortable });
    }
    private void MakeMenus()
    {
        var metadata = Definition.A("controls").ToDictionary(c => c.S("variable"), StringComparer.Ordinal);
        var bar = Widgets.Values.OfType<MenuStrip>().FirstOrDefault();
        if (bar is null) return;
        ToolStripItem? Item(string variable)
        {
            if (!metadata.TryGetValue(variable, out var data) || !data.B("visible", true)) return null;
            if (data.S("type") == "ToolStripSeparator") return new ToolStripSeparator();
            var result = new ToolStripMenuItem(data.S("text"));
            var children = data.A("children");
            foreach (var child in children) if (Item(child.GetString()!) is { } item) result.DropDownItems.Add(item);
            if (children.Length == 0) result.Click += async (_, _) => await DispatchAsync(data);
            return result;
        }
        var menu = Definition.A("controls").First(c => c.S("type") == "MenuStrip");
        foreach (var child in menu.A("children")) if (Item(child.GetString()!) is { } item) bar.Items.Add(item);
        bar.Dock = DockStyle.Top; bar.Visible = true; bar.BringToFront(); MainMenuStrip = bar;
    }
    private Image? ImageFor(string name)
    {
        if (name.Length == 0) return null;
        if (images.TryGetValue(name, out var image)) return image;
        var path = Path.Combine(Runtime.Root, "native/assets", name);
        if (!File.Exists(path)) return null;
        using var input = Image.FromFile(path);
        image = new Bitmap(input); images[name] = image; return image;
    }
    private Font FontFor(string family, float size, FontStyle style)
    {
        var key = (family, size, style);
        if (!fontCache.TryGetValue(key, out var font))
        {
            var privateFamily = fonts.Families.FirstOrDefault(f => f.Name.Equals(family, StringComparison.OrdinalIgnoreCase));
            font = privateFamily is null ? new Font(family, size, style) : new Font(privateFamily, size, style);
            fontCache[key] = font;
        }
        return font;
    }
    private static Color? ReadColor(JsonElement value)
    {
        if (value.ValueKind == JsonValueKind.Array) return Color.FromArgb(value[0].GetInt32(), value[1].GetInt32(), value[2].GetInt32());
        if (value.ValueKind == JsonValueKind.String) return Color.FromName(value.GetString()!);
        return null;
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing && !resourcesDisposed)
        {
            resourcesDisposed = true;
            searchTimer.Dispose();
            foreach (var picture in Widgets.Values.OfType<PictureBox>().Where(p => p.Tag is true)) picture.Image?.Dispose();
            base.Dispose(disposing);
            foreach (var image in images.Values) image.Dispose();
            foreach (var font in fontCache.Values) font.Dispose();
            ownedIcon?.Dispose(); fonts.Dispose();
            return;
        }
        base.Dispose(disposing);
    }
}
