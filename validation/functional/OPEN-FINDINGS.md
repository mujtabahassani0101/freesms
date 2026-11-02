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

- Run 41530385450 (21e9850) passed the original backup, driver, school, teacher, payment, student deletion and discount scenarios, plus all3 report previews. The Core suite passed25 and report suite50. The native component suite passed populated/filtered/empty payment totals and Persian/Arabic numeric edits, then failed its fraction-rejection assertion during an explicit native EndEdit call.
- Both attendance workers reached successful save, invalid-row rejection, correction and their persisted-count/other-period assertions. Their real row-lock/UI-timer responsiveness checks also passed. They timed out after reopening because leaving an unchanged editor published CellUpdated, setting the form's unsaved flag and blocking close with a question. Neither attendance scenario is complete. Artifact receipts and diagnostic logs are archived in runs/41530385450; the overall run failed.

## Repairs awaiting a fresh Windows run

- GridEX.TryEndEdit now runs the same numeric validation as CellValidating before committing an explicit save; native EndEdit itself skips that validation. Native regressions require fraction/overflow rejection, unchanged persisted cells and no data-error dialogs. CellUpdated now compares the beginning/end values and only reports real modifications; canceled/unchanged edits must not set dirty flags. Attendance uses TryEndEdit and its reopening/close scenarios remain required.
- MaskedEditBox now exposes an entirely empty date as empty, and normalizes numeric Persian/Arabic input. Three native regressions cover empty/full/cleared masked dates. The new original student scenario deliberately leaves birth date empty.
- Original student Save is now asynchronous. Student/enrolment, optional photo and confirmed grade-dependent mark removal share one transaction; the old pre-save mark deletes were removed. Invalid fees, class mismatch, photo I/O or late SQL failure must not leave partial changes. An original-form scenario covers required name, negative fee, zero gender, exact fee/transport totals, selected photo, duplicate code/number, cancel, edit/class move and both rejected/successful grade changes. A real class-row lock released by a UI timer tests responsiveness; an owned photo trigger forces a late SQL failure and requires prior class/fees/marks/calculation flags/photo to survive. File-picker interaction itself is not covered: the fixture seeds the selected photo path.
- Core student code parsing/filtering and bigint entity fields now use Int64. Local bounds/digit checks pass; SQL save/filter round trips and downstream report/import support for large codes still require Windows evidence.
- Database.Transaction skips a second rollback when the server has already invalidated the transaction; if an active rollback also fails, both errors are retained. A native SQL XACT_ABORT/THROW scenario requires the original SQL error and preservation of the previous school value.
- Ten disconnected Core checks pass locally. Main/native projects compile with zero warnings/errors. Fresh Windows evidence for these repairs is pending. Native photo/printing/package checks after the earlier component failure remain unexecuted on this revision.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
