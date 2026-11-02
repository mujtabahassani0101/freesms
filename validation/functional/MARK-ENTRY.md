# Original individual mark entry regression

Status: prepared and locally compiled; native Windows execution pending. This is not proof that the mark-entry section is complete.

The guarded navigation worker opens the original main-menu route to asdby/frmMarkEntry2. Its disposable database receives year1414, one class with a unique display order, one visible individual-entry subject, its teacher, and two registered students. A peer has half-year M1=10; the edited student has annual M1=15. These sentinel rows must remain unchanged.

The scenario selects the actual half-year exam, grade and class, opens the original entry panel and edits the subject through its DataGridView text editor. It enters Persian digits۲۵, presses the original Save button, and asserts SQL M1=25. It reopens the panel to verify persisted display values, edits28 and cancels, checks SQL remains25, then reopens, saves28, checks SQL and the reloaded display, and checks the peer and other exam retain10/15. Success dialogs are matched exactly and the next-student question is declined when applicable.

The scenario does not yet establish invalid-range/fraction handling, clearing/deletion, multi-subject atomicity, SQL-lock responsiveness, final/other-term formulas, bulk entry, permissions, new-year moves or every keyboard path. Preserve those requirements in PLAN.md; do not infer them from this baseline.
