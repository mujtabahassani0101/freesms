using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeSms.Core;
using Janus.Windows.GridEX;

internal sealed class OriginalWorkbookImport
{
    private bool busy;
    private readonly Form form;
    internal OriginalWorkbookImport(Form form)
    {
        this.form = form;
        form.FormClosing += (sender, args) => { if (busy) args.Cancel = true; };
    }
    internal async Task OpenAsync(OpenFileDialog picker, GridEX grid, WorkbookImportKind kind)
    {
        picker.Title = "انتخاب فایل اکسل";
        picker.RestoreDirectory = true;
        if (busy || picker.ShowDialog(form) != DialogResult.OK) return;
        string path = picker.FileName;
        busy = true;
        bool enabled = form.Enabled, wait = form.UseWaitCursor;
        form.Enabled = false;
        form.UseWaitCursor = true;
        try
        {
            var table = await Task.Run(() => ImportWorkbook.Read(path, kind));
            // Replace the old preview only after the whole file and its schema pass.
            grid.DataSource = null;
            grid.RootTable.Columns.Clear();
            grid.RootTable.FormatConditions.Clear();
            foreach (System.Data.DataColumn column in table.Columns)
            {
                var model = grid.RootTable.Columns.Add(column.ColumnName, ColumnType.Text);
                model.AllowSort = false;
                if (column.ColumnName == "status") model.Width = 200;
                if (column.ColumnName == "acp") model.Visible = false;
            }
            grid.DataSource = table;
            foreach (var state in new[] { ("1", Color.FromArgb(0, 200, 0)), ("-1", Color.FromArgb(250, 0, 150)) })
            {
                var condition = new GridEXFormatCondition(grid.RootTable.Columns["acp"], ConditionOperator.Equal, state.Item1);
                condition.FormatStyle.ForeColor = SystemColors.WindowText;
                condition.FormatStyle.BackColor = state.Item2;
                grid.RootTable.FormatConditions.Add(condition);
            }
        }
        catch (Exception error) { MessageBox.Show(form, error.Message); }
        finally { form.Enabled = enabled; form.UseWaitCursor = wait; busy = false; }
    }
}
