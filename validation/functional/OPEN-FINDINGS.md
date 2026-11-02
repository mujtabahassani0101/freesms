# Open findings and scope limits

The full application goal is not complete. The 448-click inventory is a starting point, not exhaustive coverage of keyboard, editing, selection, printing or database behavior.

## Verified limited workflows

- Binary report-layout grid rendering and button icon sizing have passing native Windows regressions. Run 41513493718 has 146 native component/package/render checks; these do not prove every RPX editor workflow.
- Run 41516044782 (c318b82) verifies actual report101 preview with a named persisted student and school header, including a captured populated preview. It also advances through a year-1410 selector beyond the old static year limit. This does not prove every printed field or report.
- That run's original-button scenarios verify school Save/reopen, discount empty-title/New/Edit/Cancel/Delete with quoted Persian comments, and student deletion confirmation/cancellation and persisted effects.
- The native Core suite in run 41511439779 verifies rollback when a late foreign-key rejection occurs after earlier enrolment/image deletes. Original deletion now uses that transaction and handles the optional disciplinary table when present.
- Native OK dialogs use button ID2 on this runner. The probe now locates the actual descendant button by label/id and clicks it after matching the expected message; the earlier school/discount probe timeouts were resolved.

## Repairs awaiting Windows evidence

- Catalog reports 1024 and 1032 reference classes/RPTs absent even from the original executable; both are active under the current edition. Two native layouts have been reconstructed from the recovered mark-table and chart components, with existing SQL contracts and base formulas retained. They pass 46 disconnected calculation/expression checks locally. Real original-button previews, every rendered page and the original SQL calculations still require Windows verification. See REBUILT-REPORTS.md.
- The report/deletion fixture now includes two students and real term marks. It independently requires final marks70/30, class mean50 and preservation of the peer's identity/enrolment after deletion. This stronger fixture has not yet passed Windows verification.

## Other open work

- Backup/restore code still hardcodes `school_af_kbr` and concatenates backup file paths in asda9/asdbl/asdao/asda7/asdbv. Test the configured catalog, quoted paths, invalid backups and actual restored records before claiming repair.
- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
