using FreeSms.Core;

namespace FreeSms.Windows;

public sealed class AppRuntime(string root, bool preview)
{
    private Task<SchoolService>? initialization;
    public string Root { get; } = root;
    public bool Preview { get; } = preview;
    public FormCatalog Catalog { get; } = new(root);
    public SchoolService? School { get; private set; }
    public List<RecoveredForm> Forms { get; } = [];
    public async Task InitializeAsync(IProgress<string> progress)
    {
        initialization ??= Task.Run(async () =>
        {
            var database = await Bootstrapper.OpenAsync(Root, progress: progress);
            Migrations.Apply(database, Root, progress);
            return new SchoolService(database, new Session(Convert.ToInt32(database.Scalar("SELECT TOP 1 xYear FROM tDefYear") ?? 1398)));
        });
        School = await initialization;
    }
    public void Open(string name, RecoveredForm parent, int? student = null)
    {
        var form = new RecoveredForm(this, Catalog.ByName[name], student);
        form.Show(parent);
    }
    public async Task ChangedAsync(RecoveredForm origin)
    {
        foreach (var form in Forms.ToArray())
            if (form != origin && !form.IsDisposed && form.Visible && !form.Busy && form.Controller is not null)
                await form.OperationAsync(form.Controller.RefreshAsync);
    }
}
