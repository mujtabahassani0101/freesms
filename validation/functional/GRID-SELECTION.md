# Selection publication and dependent grids

Run41559110225 still reproduced the original individual mark editor's DataGridView NullReferenceException during student selection, even after the narrower recursive-EndEdit and source-rebind regressions passed. The stack enters the recovered dependent-grid/focus handler from native SelectionChanged inside the student's CurrentCell assignment. The original workflow has not passed.

Microsoft documents that DataGridView.SelectionChanged may run before CurrentCellChanged, exposing the previous current cell: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.selectionchanged?view=windowsdesktop-10.0

The .NET10 implementation also reads EditingControl after translating mouse coordinates in its MouseOverEditingControl getter, which is where the recorded exception occurs: https://github.com/dotnet/winforms/blob/v10.0.0/src/System.Windows.Forms/System/Windows/Forms/Controls/DataGridView/DataGridView.cs . Reentrant dependent-grid focus is the working diagnosis, not a claim that every native call path has been proven.

Compatibility selection events now coalesce native notifications through BeginInvoke until the native operation returns. Programmatic Row/CurrentColumn setters flush a pending event after assigning the native property, preserving immediate original-button selection behavior. Bind publishes once after initialization; disposal/loading and recursive publication are guarded.

The new native regression uses two visible grids. Its selector handler asserts selected-row/current-row agreement, replaces the dependent data, focuses that grid and starts editing. It tests both the compatibility Row setter and direct native CurrentCell assignment followed by a UI event cycle, requiring exact final identities and notification counts. These tests and the original mark case require Windows execution. Passing earlier single-grid tests does not substitute for that verification.
