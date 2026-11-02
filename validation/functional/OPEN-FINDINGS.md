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

- Run 41526253553 (e7d2a10) passed all three original report previews, every-page rendering, Core/report checks, the six physical Persian/Latin alignment regressions and the original teacher/driver CRUD/cancel/delete scenarios. Backup, school, student deletion and discounts also passed. The overall run failed in Payments after saving its first record: Count of the string payment-date column attempted decimal conversion in GridEX.UpdateTotals. Logs and receipt are archived in runs/41526253553. Do not present this run's build as a verified release.

## Repairs awaiting a fresh Windows run

- Grid Count now counts non-null values without numeric conversion, while Sum/Average still use decimal values. New native regressions require exact count/sum for populated, filtered and empty payment lists. The original payment scenario must finish its date/amount validation, actual persisted fee/transport/comment, balance reload, duplicate-date rejection, edit/cancel and delete confirmations.
- All 21 known Studentimg1 report controls lacked source metadata. The runtime model now binds only the unique declared Student_img blob field and rejects ambiguity; the recovered XML files remain unchanged. Three native pixel checks exercise distinct student photos, a null photo and a damaged-photo placeholder. The original report fixture now persists two distinct colored PNGs, asserts the selected student's actual SQL photo bytes and requires both photos in the rendered card pages. New Windows evidence is pending.
- The two reconstructed card headers now use a growable identity field with school, student, father, grandfather and code, followed by class/grade/exam and the original additional header. Existing period dates are retained where configured. This replaces cramped fixed fields and the large empty box in these two layouts. It still requires native rendering/visual inspection; readability of all 98 original report layouts is not established.
- Local report/expression/export checks pass50, including all student-photo bindings and rejection of ambiguous metadata. The modified app/native checks compile with zero warnings/errors; Windows execution is pending.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
