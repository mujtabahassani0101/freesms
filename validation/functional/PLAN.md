# Full application verification

The requested end state covers all application sections, including the three reported screenshots. Completion is unproven until the relevant workflow results and persisted effects have been checked. The generated action inventory contains 89 forms, 2,313 controls and 446 click actions; its initial status is deliberately unverified.

Required workflow groups:

- Installation, first start, repeat start, upgrade and database preservation; login, logout, account changes and non-admin permissions.
- School/year/grade/class/subject/teacher setup; student registration, editing, lookup, moving classes and new-year transitions.
- Individual and bulk mark entry, validation, calculation, descriptive grades and persisted report values.
- Attendance, absences and disciplinary workflows, including the database edition prerequisites; a compatibility warning does not implement a missing feature.
- Fees, payments, discounts, balances, corrections and deletion; verify committed and rejected operations independently.
- Every report selector, configured report and RPX editor: real preview clicks, data/subreport/parameter binding, paging, editing, save/reload, image and XLSX exports, print-path rendering.
- Excel import/export with representative workbooks, malformed inputs and optional Office dependency handling.
- User permissions, notifications and settings; verify message preparation against a test transport, never send unsolicited external messages.
- Backup and restore against disposable databases; verify restored records and rollback on rejected input.
- Keyboard navigation, selection changes, empty and populated lists, sorting/filtering, invalid inputs, resource disposal and reopening forms after errors.

Each scenario needs preconditions, an isolated fixture, exact actions, expected persisted effects, actual evidence and pass/fail/incomplete status. Do not mark a whole section passed from constructor, rendering or menu-opening checks. Keep unavailable environmental dependencies and unexecuted cases explicit.

Initial regressions to reproduce and repair:

1. RPX binary payload inferred as a grid image and shown in the default DataGridView error dialog.
2. Oversized report button icons covering captions.
3. Null settings tags when the report preview button or close handler compares optional settings.
4. Additional failures discovered while exercising the original report selectors and all other workflow groups.
