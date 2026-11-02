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

## Latest Windows results and repairs pending a fresh run

- Run 41524997246 (af7f9c3) passed all three original report previews, every-page rendering and the actual eligible progress-exam values20/70 with class means15/50. The Core and 48 report checks passed. Its business scenarios passed backup, school, student deletion and discounts, but failed both People scenarios because Edit/Delete remained disabled after keyboard selection. The overall run failed; do not present its build as a verified release. Original logs, screenshots and digest receipt are in runs/41524997246.
- Teacher/driver SelectionChanged now updates Edit/Delete enabled state; the original-button scenarios explicitly require that state before editing. The quoted-text saves, driver update mode and teacher credential reload still need the complete UI scenario to pass.
- Payment Save now validates every Int32 amount as non-negative, normalizes Persian/Arabic digits and rejects an overflowing total before SQL. New original-list/editor scenarios cover validation, persisted fee/transport/comment, balance reload, duplicate dates, edit/cancel and delete confirmations. Fresh Windows evidence is pending.
- Visual inspection of the rebuilt report screenshots exposed physically reversed RightAlign/LeftAlign for Persian text in the native renderer. Alignment now accounts for GDI+ reading direction. Six pixel-position regressions cover left/center/right alignment for Persian and Latin text. They compile locally but require Windows execution.
- Fixed-height header fields in recovered layouts still truncate some long synthetic names. Correcting horizontal alignment alone does not establish full report readability; visually inspect header sizing and all report pages after the next run.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
