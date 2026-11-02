# Open findings and scope limits

The full application goal is not complete. The 448-click inventory is a starting point, not exhaustive coverage of keyboard, editing, selection, printing or database behavior.

## Verified limited workflows

- Binary report-layout grid rendering and button icon sizing have passing native Windows regressions. Run 41513493718 has 146 native component/package/render checks; these do not prove every RPX editor workflow.
- Run 41516044782 (c318b82) verifies actual report101 preview with a named persisted student and school header, including a captured populated preview. It also advances through a year-1410 selector beyond the old static year limit. This does not prove every printed field or report.
- That run's original-button scenarios verify school Save/reopen, discount empty-title/New/Edit/Cancel/Delete with quoted Persian comments, and student deletion confirmation/cancellation and persisted effects.
- The native Core suite in run 41511439779 verifies rollback when a late foreign-key rejection occurs after earlier enrolment/image deletes. Original deletion now uses that transaction and handles the optional disciplinary table when present.
- Native OK dialogs use button ID2 on this runner. The probe now locates the actual descendant button by label/id and clicks it after matching the expected message; the earlier school/discount probe timeouts were resolved.

## Additional verified workflows

- Run 41518278379 (285d624) passed reconstructed report 1024/1032 previews and every-page rendering, known original SQL marks70/30 and class mean50, and peer preservation during student deletion.
- Run 41522307571 (ee2e060) passed native backup/restore with configured catalog, quoted Persian paths, appended backup sets, malformed media and unrelated-schema rejection, recovery after replacement failure, and actual asynchronous backup/admin-restore buttons. See MAINTENANCE.md and the archived artifact receipts/logs.

## Latest Windows results

- Run 41527859737 (8e429d2) passed all7 original business scenarios, including the full payment validation, save, balance reload, edit/cancel and deletion scenario. The three original report previews also passed; actual SQL photo bytes and both student-photo colors were asserted in the rendered card pages. Fifty report checks and23 Core checks passed.
- The overall run failed because a new native regression changed DataTable.DefaultView.RowFilter while GridEX displays its own private DataView. It therefore did not actually filter the visible rows. The count/date fix itself passed its first component assertion and the real payment workflow. Logs, screenshots and artifact digests are archived in runs/41527859737. Native component tests after that early assertion were not executed in this revision; do not claim the whole component suite passed.
- Visual inspection confirmed separate photos and readable identity headers for the two students in reconstructed cards. The inherited narrow column headings still clipped their multiline captions; that follow-up is pending a new render.

## Repairs awaiting a fresh Windows run

- The filter regression now enters the real GridEX search box and asserts both visible-row count and displayed count/sum. The existing empty-list test remains. No production filter behavior was changed merely to satisfy the test.
- Original half-year and annual attendance handlers now validate the complete row before SQL. Negative, fractional, out-of-range and over-total day counts are rejected. Valid rows retain their own result status; invalid rows stay marked and unsaved. Updates bind values and require the matching enrolment/year/class. SQL writes run asynchronously with the form disabled and a wait cursor; a real row-lock/UI-timer regression is pending for responsiveness. Absence edits recalculate present days using all categories and normalized Persian/Arabic digits. Two original-menu/editor scenarios are configured with100 half-year and200 annual days, exact persisted counts, rejection preservation, other-period isolation and reopening assertions.
- Native numeric grid parsing now normalizes Persian/Arabic digits and validates the bound numeric range before data binding. New actual-cell-editor regressions cover typed integers/decimals, fraction rejection and Int32 overflow without data-error dialogs.
- Reconstructed card identifier formatting now omits thousands separators and narrow table-heading fields have enough vertical space for multiline captions. Fresh visual inspection is required.
- Nine disconnected Core checks pass locally, including attendance normalization, totals and bounds. Fifty report/expression/export checks pass. Main/native projects compile with zero warnings/errors. Fresh Windows evidence for the changes above is pending; native-photo component tests remain required even though the real two-card photo workflows passed.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
