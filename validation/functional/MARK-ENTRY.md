# Original individual mark entry regression

Status: the original Save/Edit/Cancel/reload/peer-preservation baseline passed in run41561544090 (source0b48151), after the hidden-editor guard. Earlier failed attempts and narrow component regressions are recorded in OPEN-FINDINGS.md/GRID-SELECTION.md. This baseline does not establish the full mark-entry section.

The guarded navigation worker opens the original main-menu route to asdby/frmMarkEntry2. Its disposable database receives year1414, one class with a unique display order, one visible individual-entry subject, its teacher, and two registered students. A peer has half-year M1=10; the edited student has annual M1=15. These sentinel rows must remain unchanged.

The scenario selects the actual half-year exam, grade and class, opens the original entry panel and edits the subject through its DataGridView text editor. It enters Persian digits۲۵, presses the original Save button, and asserts SQL M1=25. It reopens the panel to verify persisted display values, edits28 and cancels, checks SQL remains25, then reopens, saves28, checks SQL and the reloaded display, and checks the peer and other exam retain10/15. Success dialogs are matched exactly and the next-student question is declined when applicable.

The scenario does not yet establish invalid-range/fraction handling, clearing/deletion, multi-subject atomicity, SQL-lock responsiveness, final/other-term formulas, bulk entry, permissions, new-year moves or every keyboard path. Preserve those requirements in PLAN.md; do not infer them from this baseline.

Manual inspection of the actual populated gallery in41568720739 found that the student list covers the visible mark-edit panel even though programmatic Save/Edit checks pass. The opening handler now raises that panel to the front. The original workflow additionally walks actual visible child hit targets at the Save button and mark cell, rejecting covered or off-form controls, before editing. These visibility checks and an updated gallery await Windows execution; a passing programmatic workflow alone is not treated as proof of mouse usability.
