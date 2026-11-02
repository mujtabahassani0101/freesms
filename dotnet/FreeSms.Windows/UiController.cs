using FreeSms.Core;

namespace FreeSms.Windows;

public sealed record Choice(object? Value, string Caption)
{
    public override string ToString() => Caption;
}

public sealed class UiController
{
    private readonly RecoveredForm form;
    private readonly SchoolService school;
    private readonly EntityService entities;
    private readonly string name;
    private readonly ReferenceBinding? reference;
    private readonly Dictionary<string, List<Record>> rowSets = new(StringComparer.OrdinalIgnoreCase);
    private List<Record> referenceRows = [];
    private int id;
    private bool updating = true;
    private byte[]? studentImage;
    private bool imageChanged;
    private static readonly Dictionary<string, string> SchoolFields = new() { ["txtOst"] = "Ost", ["txtCity"] = "cty", ["txtSch"] = "sch", ["txtFoter1"] = "Foter1" };
    private static readonly Dictionary<string, string> Filters = new() { ["txtFName"] = "first_name", ["txtLName"] = "father_name", ["txtCode"] = "code", ["txtNumberAsas"] = "number_asas", ["txtCodeTakhfif"] = "discount_code", ["dropPaye"] = "grade", ["dropCls"] = "class", ["dropStatus"] = "status", ["dropJens"] = "gender" };
    private static List<Record> Status => [Option(1, "برحال"), Option(2, "محروم"), Option(3, "منفک"), Option(4, "معذرتی")];
    private static List<Record> Gender => [Option(1, "مرد"), Option(0, "زن")];
    private static Record Option(object? value, string caption) => new() { ["id"] = value, ["name"] = caption };
    public UiController(RecoveredForm form, SchoolService school, int? student)
    {
        this.form = form; this.school = school; entities = new(school); name = form.Definition.S("name"); id = student ?? 0;
        BindingDefinitions.References.TryGetValue(name, out reference);
    }
    private Control? Widget(string key) => form.Widgets.GetValueOrDefault(key);
    private object? Get(string key) => Widget(key) switch
    {
        TextBox text => text.Text.Trim(), ComboBox combo => (combo.SelectedItem as Choice)?.Value,
        CheckBox check => check.Checked, NumericUpDown number => (int)number.Value, _ => null
    };
    private void Put(string key, object? value)
    {
        var previous = updating; updating = true;
        try
        {
            switch (Widget(key))
            {
                case TextBox text: text.Text = Convert.ToString(value) ?? ""; break;
                case Label label: label.Text = Convert.ToString(value) ?? ""; break;
                case ComboBox combo:
                    combo.SelectedIndex = Enumerable.Range(0, combo.Items.Count).FirstOrDefault(i => combo.Items[i] is Choice item && EqualsValue(item.Value, value), -1); break;
                case CheckBox check: check.Checked = Values.Boolean(value); break;
                case NumericUpDown number: number.Value = Math.Clamp(Values.Number(value) ?? 0, number.Minimum, number.Maximum); break;
            }
        }
        finally { updating = previous; }
    }
    private static bool EqualsValue(object? a, object? b) => Values.Text(a) == Values.Text(b);
    private void Combo(string key, List<Record> rows, bool blank = true)
    {
        if (Widget(key) is not ComboBox combo) return;
        var previous = updating; updating = true;
        var value = Get(key);
        combo.BeginUpdate(); combo.Items.Clear();
        if (blank) combo.Items.Add(new Choice(null, "—"));
        combo.Items.AddRange(rows.Select(r => (object)new Choice(r.Value("id"), r.Text("name"))).ToArray());
        combo.SelectedIndex = combo.Items.Count == 0 ? -1 : 0;
        if (value is not null) Put(key, value);
        combo.EndUpdate(); updating = previous;
    }
    private void Watch(string key, Func<Task>? action = null)
    {
        async void Changed(object? sender, EventArgs args)
        {
            if (updating) return;
            if (action is null) form.QueueRefresh(); else await form.OperationAsync(action);
        }
        switch (Widget(key)) { case TextBox text: text.TextChanged += Changed; break; case ComboBox combo: combo.SelectedIndexChanged += Changed; break; }
    }
    private Record Read(IReadOnlyDictionary<string, string> fields)
    {
        var result = new Record();
        foreach (var (widget, column) in fields) result[column] = Get(widget);
        return result;
    }
    private void Fill(string key, List<Record> rows)
    {
        if (Widget(key) is not DataGridView grid) return;
        var first = !rowSets.ContainsKey(key);
        rowSets[key] = rows;
        if (grid.Columns.Count == 0 && rows.Count > 0)
            foreach (var field in rows[0].Keys) grid.Columns.Add(new DataGridViewTextBoxColumn { Name = field, HeaderText = field, SortMode = DataGridViewColumnSortMode.NotSortable });
        if (first) grid.CellValueNeeded += (_, args) =>
        {
            var current = rowSets[key];
            if (args.RowIndex >= 0 && args.RowIndex < current.Count) args.Value = current[args.RowIndex].Value(grid.Columns[args.ColumnIndex].Name);
        };
        grid.RowCount = rows.Count;
        grid.Invalidate();
        if (rows.Count > 0 && grid.ColumnCount > 0) grid.CurrentCell = grid[0, 0];
    }
    private Record Selected(string key)
    {
        if (Widget(key) is DataGridView { CurrentCell.RowIndex: var index } && rowSets.TryGetValue(key, out var rows) && index >= 0 && index < rows.Count) return rows[index];
        throw new ValidationException("یک مورد را از لیست انتخاب کنید.");
    }
    private bool Confirm(string text) => MessageBox.Show(form, text, "تأیید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
    private void Notify() => form.Text = form.Definition.S("text", "Free SMS") + " — اطلاعات ثبت شد.";
    private async Task ChangedAsync() => await form.Runtime.ChangedAsync(form);

    public async Task InitializeAsync()
    {
        await ThemeAsync();
        if (reference is not null)
        {
            var choices = await Task.Run(() => (Grades: school.Choices("grades"), Levels: school.Choices("levels")));
            Combo("dropPaye", choices.Grades, false); Combo("dropPayeSeacrch", choices.Grades); Combo("dropMaghta", choices.Levels, false);
            Combo("dropShift", [Option(1, "صبح"), Option(2, "عصر")], false);
            foreach (var key in new[] { "txtNamFSearch", "txtNamlSearch", "txtNameSearch", "dropPayeSeacrch" }) Watch(key);
            if (Widget(reference.Grid) is DataGridView grid) grid.CellDoubleClick += async (_, e) => { if (e.RowIndex >= 0) await form.OperationAsync(EditReferenceAsync); };
            Editing(false);
        }
        if (name is "frmSabtenam" or "frmlistStd")
        {
            Combo("dropPaye", await Task.Run(() => school.Choices("grades")), name != "frmSabtenam");
            Combo("dropStatus", Status, name != "frmSabtenam"); Combo("dropJens", Gender);
            await LoadStudentClassesAsync();
            Watch("dropPaye", LoadStudentClassesAsync);
        }
        if (name == "frmlistStd")
        {
            foreach (var key in Filters.Keys.Where(k => k != "dropPaye")) Watch(key);
            if (Widget("gridEX1") is DataGridView grid) grid.CellDoubleClick += async (_, e) => { if (e.RowIndex >= 0) await form.OperationAsync(() => { OpenStudent(); return Task.CompletedTask; }); };
        }
        if (name == "frmSabtenam")
        {
            Combo("dropMazhab", [Option(1, "شیعه"), Option(2, "سنی")]);
            var choices = await Task.Run(() => new[] { "drivers", "discounts", "cities" }.ToDictionary(k => k, k => school.Choices(k)));
            Combo("dropDriver", choices["drivers"]); Combo("comboTakhfif", choices["discounts"]); Combo("dropcity", choices["cities"]); Combo("dropcityNow", choices["cities"]);
            Watch("dropCls", ClassFeeAsync);
            foreach (var key in BindingDefinitions.StudentFields.Keys)
            {
                EnableField(key, true);
                if (key.StartsWith("txtFee", StringComparison.Ordinal) || key.StartsWith("txttransport", StringComparison.Ordinal))
                    if (Widget(key) is TextBox text) text.TextChanged += (_, _) => { if (!updating) Totals(); };
            }
            foreach (var key in new[] { "txtSumFee", "txtSumtransport", "txtFeeClass" }) if (Widget(key) is TextBox text) text.ReadOnly = true;
            Put("dropStatus", 1);
            for (var i = 1; i <= 9; i++) { Put("txtFee" + i, 0); Put("txttransport" + i, 0); }
            if (id > 0) await LoadStudentAsync(id);
            Totals();
        }
        if (name == "frmSetDefYear")
        {
            Combo("dropYear", Enumerable.Range(Math.Min(1390, school.Session.Year), Math.Max(1410, school.Session.Year + 6) - Math.Min(1390, school.Session.Year)).Select(year => Option(year, year.ToString())).ToList(), false);
            Put("dropYear", school.Session.Year);
        }
        if (name == "frmTchClass")
        {
            var choices = await Task.Run(() => (Grades: school.Choices("grades"), Teachers: school.Choices("teachers")));
            Combo("comboPaye", choices.Grades, false); Combo("dropTch", choices.Teachers);
            Combo("comboTypeFilter", [Option("all", "همه"), Option("cls", "صنف"), Option("tch", "معلم"), Option("both", "صنف و معلم")], false);
            await AssignmentClassesAsync();
            Watch("comboPaye", AssignmentClassesAsync); Watch("dropCls", AssignmentBooksAsync); Watch("dropTch"); Watch("comboTypeFilter");
        }
        await RefreshAsync();
        updating = false;
    }

    private async Task ThemeAsync()
    {
        var color = (await Task.Run(() => school.Db.Query("SELECT TOP 1 R,G,B FROM tFormColor"))).FirstOrDefault();
        if (color is null) return;
        foreach (var variable in form.Definition.A("runtime_background_targets"))
        {
            var metadata = form.Definition.A("controls").FirstOrDefault(c => c.S("variable") == variable.GetString());
            if (Widget(metadata.S("name")) is { } widget) widget.BackColor = Color.FromArgb(Math.Clamp(color.Int("R"), 0, 255), Math.Clamp(color.Int("G"), 0, 255), Math.Clamp(color.Int("B"), 0, 255));
        }
        if (name == "frmbackColor") foreach (var channel in new[] { "R", "G", "B" }) { if (Widget("txt" + channel) is NumericUpDown number) number.Maximum = 255; Put("txt" + channel, color.Int(channel)); }
    }

    public async Task RefreshAsync()
    {
        if (name == "frmMain") { Put("lYear", school.Session.Year); Put("lUser", school.Session.Username); Put("l_xschool", "Free SMS"); }
        else if (name == "frmSchool")
        {
            var record = await Task.Run(school.School);
            foreach (var (widget, column) in SchoolFields) Put(widget, record.Value(column));
        }
        else if (reference is not null)
        {
            referenceRows = await Task.Run(() => reference.Entity == "classes" ? school.Classes() : entities.List(reference.Entity));
            if (reference.Entity is "books" or "year_days")
            {
                var choices = await Task.Run(() => school.Choices(reference.Entity == "books" ? "grades" : "levels"));
                foreach (var row in referenceRows)
                {
                    row[reference.Entity == "books" ? "paye" : "maghta"] = choices.FirstOrDefault(c => EqualsValue(c.Value("id"), row.Value(reference.Entity == "books" ? "xPaye" : "xMaghta")))?.Text("name");
                    if (reference.Entity == "year_days") row["sumyear"] = row.Int("Term1") + row.Int("Term2");
                }
            }
            FilterReferences();
        }
        else if (name == "frmlistStd")
        {
            var values = Read(Filters);
            Fill("gridEX1", await Task.Run(() => school.Students(values)));
        }
        else if (name == "frmTchClass")
        {
            var mode = Values.Text(Get("comboTypeFilter"));
            var classroom = mode is "cls" or "both" ? Get("dropCls") : null;
            var teacher = mode is "tch" or "both" ? Get("dropTch") : null;
            Fill("gTchCls", await Task.Run(() => school.TeacherAssignments(classroom, teacher)));
        }
        else if (name == "frmbackColor") await ThemeAsync();
    }
    private void FilterReferences()
    {
        if (reference is null) return;
        IEnumerable<Record> rows = referenceRows;
        foreach (var (widget, column) in new[] { ("txtNamFSearch", "fNamF"), ("txtNamlSearch", reference.Entity == "teachers" ? "fNamL" : "name"), ("txtNameSearch", "Name") })
            if (Values.Text(Get(widget)) is var text && text.Length > 0) rows = rows.Where(r => r.Text(column).Contains(text, StringComparison.OrdinalIgnoreCase));
        if (Get("dropPayeSeacrch") is { } grade) rows = rows.Where(r => EqualsValue(r.Value("xPaye"), grade));
        Fill(reference.Grid, rows.ToList());
    }
    private void EnableField(string key, bool enabled)
    {
        if (Widget(key) is not { } widget) return;
        for (var parent = widget.Parent; parent is not null && parent != form.Surface; parent = parent.Parent) parent.Enabled = true;
        widget.Enabled = enabled;
    }
    private void Editing(bool enabled)
    {
        if (reference is null) return;
        foreach (var key in reference.Fields.Keys.Concat(["btnAcp", "btnAccept", "btnCancel", "btnCansel"])) EnableField(key, enabled);
        if (reference.Entity == "classes" && id > 0 && Widget("dropPaye") is { } grade) grade.Enabled = false;
    }
    private Task EditReferenceAsync()
    {
        var row = Selected(reference!.Grid); id = row.Int("id");
        foreach (var (widget, column) in reference.Fields) Put(widget, row.Value(column));
        Editing(true); return Task.CompletedTask;
    }
    private void NewReference()
    {
        id = 0;
        foreach (var key in reference!.Fields.Keys) Put(key, null);
        foreach (var key in new[] { "dropPaye", "dropMaghta" }) if (Widget(key) is ComboBox combo && combo.Items.Count > 0) Put(key, (combo.Items[0] as Choice)?.Value);
        Put("dropShift", 1); Put("txtFee", 0); Put("txtVahed", 1); Put("txttimeWeek", 1);
        foreach (var (widget, column) in new[] { ("txtSortRpt", "sortRpt"), ("txtSort", "sort"), ("txtCodeDars", "codedars"), ("txtNumExam", "NumExam") }) Put(widget, referenceRows.Select(r => r.Int(column)).DefaultIfEmpty(0).Max() + 1);
        Editing(true);
    }
    private async Task SaveReferenceAsync()
    {
        var values = Read(reference!.Fields);
        if (reference.Entity == "books") { values["Type"] = 1; values["SortOneEntry"] = values.Value("sort"); }
        if (reference.Entity == "teachers" && !Values.Boolean(Get("checkID")) && Values.Text(Get("txtid")).Length > 0) values["id"] = Get("txtid");
        await Task.Run(() => reference.Entity == "classes" ? school.SaveClass(values, id) : entities.Save(reference.Entity, values, id));
        await RefreshAsync(); Editing(false); Notify(); await ChangedAsync();
    }
    private async Task LoadStudentClassesAsync()
    {
        var grade = Get("dropPaye");
        Combo("dropCls", await Task.Run(() => school.Choices("classes", grade)), name != "frmSabtenam");
        if (name == "frmSabtenam") await ClassFeeAsync(); else if (!updating) await RefreshAsync();
    }
    private async Task ClassFeeAsync()
    {
        var classroom = Get("dropCls");
        var fee = classroom is null ? 0 : await Task.Run(() => school.Db.Scalar("SELECT fee FROM tClass WHERE id=@p0", [classroom]));
        Put("txtFeeClass", fee);
    }
    private void Totals()
    {
        foreach (var (prefix, target) in new[] { ("txtFee", "txtSumFee"), ("txttransport", "txtSumtransport") })
        {
            long sum = 0;
            for (var i = 1; i <= 9; i++) { try { sum += Values.Number(Get(prefix + i)) ?? 0; } catch (ValidationException) { } }
            Put(target, sum);
        }
    }
    private async Task LoadStudentAsync(int identifier)
    {
        var result = await Task.Run(() => (Row: school.Student(identifier), Image: school.StudentImage(identifier)));
        if (result.Row is null) throw new ValidationException("پروندهٔ شاگرد در سال انتخاب‌شده پیدا نشد.");
        Put("dropPaye", result.Row.Value("xPaye")); await LoadStudentClassesAsync();
        foreach (var (widget, column) in BindingDefinitions.StudentFields) Put(widget, result.Row.Value(column));
        studentImage = result.Image; imageChanged = false; id = identifier; ShowImage(); Totals();
    }
    private void ShowImage()
    {
        if (Widget("pictureBox1") is not PictureBox picture) return;
        var old = picture.Image; picture.Image = null;
        if (studentImage is not null) { using var stream = new MemoryStream(studentImage); using var image = Image.FromStream(stream); picture.Image = new Bitmap(image); }
        // Original decorative assets are owned by the form; student image bitmaps are transient.
        if (old is not null && picture.Tag is true) old.Dispose();
        picture.Tag = true;
    }
    private void OpenStudent() => form.Runtime.Open("frmSabtenam", form, Selected("gridEX1").Int("id"));
    private async Task AssignmentClassesAsync()
    {
        var grade = Get("comboPaye"); Combo("dropCls", await Task.Run(() => school.Choices("classes", grade)), false); await AssignmentBooksAsync();
    }
    private async Task AssignmentBooksAsync()
    {
        var classroom = Get("dropCls"); var grade = Get("comboPaye");
        var rows = await Task.Run(() =>
        {
            var assigned = classroom is null ? [] : school.TeacherAssignments(classroom).Select(r => r.Int("xLsn")).ToHashSet();
            return school.Choices("books", grade).Where(r => !assigned.Contains(r.Int("id"))).ToList();
        });
        Combo("dropBook", rows, false);
        if (!updating) await RefreshAsync();
    }
    public async Task<bool> HandleAsync(string control)
    {
        var action = control.ToLowerInvariant();
        if (name == "frmMain" && action is "toolsarbargreg" or "toolfrmregisterpak0") { MessageBox.Show(form, "نسخهٔ .NET بدون کلید سخت‌افزاری فعال است."); return true; }
        if (name == "frmSchool" && action == "btnacp") { var values = Read(SchoolFields); await Task.Run(() => school.SaveSchool(values)); Notify(); await ChangedAsync(); return true; }
        if (name == "frmSetDefYear" && action == "btnacp") { var year = Values.Number(Get("dropYear")) ?? throw new ValidationException("سال تعلیمی را انتخاب کنید."); await Task.Run(() => school.SetYear(year)); Notify(); await ChangedAsync(); return true; }
        if (reference is not null)
        {
            switch (action)
            {
                case "btnnew": NewReference(); return true;
                case "btnedit": await EditReferenceAsync(); return true;
                case "btnacp": case "btnaccept": await SaveReferenceAsync(); return true;
                case "btncancel": case "btncansel": id = 0; Editing(false); return true;
                case "btndelete":
                    var row = Selected(reference.Grid);
                    if (Confirm("مورد انتخاب‌شده حذف شود؟")) { await Task.Run(() => { if (reference.Entity == "classes") school.DeleteClass(row.Int("id")); else entities.Delete(reference.Entity, row.Int("id")); }); await RefreshAsync(); await ChangedAsync(); }
                    return true;
            }
        }
        if (name == "frmlistStd")
        {
            switch (action)
            {
                case "btnnew": form.Runtime.Open("frmSabtenam", form); return true;
                case "btnedit": OpenStudent(); return true;
                case "btndelete": case "btndeletestd":
                    var row = Selected("gridEX1");
                    if (Confirm("پرونده، نمرات و پرداخت‌های شاگرد انتخاب‌شده به‌طور کامل حذف شود؟")) { await Task.Run(() => school.DeleteStudent(row.Int("id"))); await RefreshAsync(); await ChangedAsync(); }
                    return true;
                case "btnnosearch": foreach (var key in Filters.Keys) Put(key, null); await LoadStudentClassesAsync(); await RefreshAsync(); return true;
            }
        }
        if (name == "frmSabtenam")
        {
            switch (action)
            {
                case "btnacp":
                    var values = Read(BindingDefinitions.StudentFields);
                    if (imageChanged) values["Student_img"] = studentImage;
                    id = await Task.Run(() => school.SaveStudent(values, id)); imageChanged = false; Notify(); await ChangedAsync(); return true;
                case "btnpic":
                    using (var dialog = new OpenFileDialog { Filter = "تصویر|*.png;*.jpg;*.jpeg" })
                        if (dialog.ShowDialog(form) == DialogResult.OK)
                        {
                            var bytes = await File.ReadAllBytesAsync(dialog.FileName);
                            using var stream = new MemoryStream(bytes); using var probe = Image.FromStream(stream);
                            studentImage = bytes; imageChanged = true; ShowImage();
                        }
                    return true;
                case "btndeletepic": studentImage = null; imageChanged = true; ShowImage(); return true;
                case "btnnext": case "btnprevious":
                    var ids = (await Task.Run(() => school.Students())).Select(r => r.Int("id")).ToList();
                    var index = ids.IndexOf(id); var next = index + (action == "btnnext" ? 1 : -1);
                    if (index >= 0 && next >= 0 && next < ids.Count) await LoadStudentAsync(ids[next]);
                    return true;
            }
        }
        if (name == "frmTchClass")
        {
            if (action == "btnadd") { var classroom = Get("dropCls"); var book = Get("dropBook"); var teacher = Get("dropTch"); await Task.Run(() => school.AssignTeacher(classroom, book, teacher)); await AssignmentBooksAsync(); await ChangedAsync(); return true; }
            if (action == "btndelete") { var row = Selected("gTchCls"); if (Confirm("ارتباط معلم و درس حذف شود؟")) { await Task.Run(() => school.UnassignTeacher(row.Value("xCls"), row.Value("xLsn"))); await AssignmentBooksAsync(); await ChangedAsync(); } return true; }
        }
        if (name == "frmbackColor")
        {
            if (action == "btnnew") { using var dialog = new ColorDialog(); if (dialog.ShowDialog(form) == DialogResult.OK) { Put("txtR", dialog.Color.R); Put("txtG", dialog.Color.G); Put("txtB", dialog.Color.B); } return true; }
            if (action == "btnacp") { var values = new[] { "R", "G", "B" }.Select(c => (object?)Values.Number(Get("txt" + c), 0, 255)).ToArray(); await Task.Run(() => school.Db.Execute("UPDATE tFormColor SET R=@p0,G=@p1,B=@p2", values)); await ThemeAsync(); await ChangedAsync(); Notify(); return true; }
        }
        return false;
    }
}
