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

## Repairs awaiting Windows evidence

- Rebuilt report legends/numeric chart labels, student page boundaries and a populated progress chart including an additional eligible exam (mean15) pass 48 local report checks. Native preview/rendering is pending.
- Teacher/driver text saves now bind SQL parameters. Driver Edit now switches to update mode. Teacher Edit reloads saved email/password and New clears stale credentials. New original-button CRUD/cancel/confirmation scenarios compile but have not yet run on Windows.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
