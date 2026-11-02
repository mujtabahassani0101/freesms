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

- Run 41535136926 (be46e5d) passed167 native component/package/render checks,28 Core/database checks and50 report checks. The explicit grid save rejects fractional/overflowing integers without changing stored values or showing data-error dialogs; unchanged/canceled edits do not publish modifications. Empty/full/cleared masked dates and student photo/null/corrupt-photo rendering passed. The Core BigInt save/filter and server-aborted transaction preservation scenarios also passed.
- Nine of10 original business scenarios passed: backup, driver, school, teacher, half-year attendance, annual attendance, payments, student deletion and discounts. Both attendance cases completed their real SQL-lock/UI-timer test, all persisted/rejection/other-period assertions and reopening/closing without an unsaved question. Three report previews and every-page rendering passed.
- Student registration/editing did not reach its form. Its fixture reused sortRpt30000 for three classes; the real class procedure correctly rejected the duplicate display order. The overall workflow failed and its binary is not a verified release. Artifact receipts, component screenshots and full functional diagnostic logs are archived in runs/41535136926.

## Repairs awaiting a fresh Windows run

- The student fixture now allocates three unused, in-range display orders from the disposable bank. Production class validation was retained. The original registration/edit/class/grade-change scenarios still require actual Windows execution; no student UI behavior is claimed verified from a fixture-construction failure.
- Student/enrolment, optional photo and confirmed grade-dependent mark removal share one asynchronous transaction; the old pre-save mark deletes were removed. The pending scenario covers required name, negative fee, zero gender, exact fee/transport totals, selected photo, duplicate code/number, cancel, edit/class move and both rejected/successful grade changes. A real class lock tests responsiveness; an owned rejecting photo trigger must preserve prior class/fees/raw and calculated marks/calculation flags/photo. File-picker interaction itself remains untested: the fixture seeds the selected path.
- Whole-section readiness remains unproven despite the passing limited scenarios. Native metadata/render checks do not establish every report's populated content or every control workflow.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
