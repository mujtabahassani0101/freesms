# Reconstructed catalog reports

Catalog entries 1024 and 1032 are visible (`tosifi IS NULL`) but refer to classes and RPT resources absent from the original executable. The original binary metadata audit is recorded in original-report-resource-audit.json. The port now provides explicit native XML layouts for these entries, rather than removing them or displaying a different catalog report.

`rebuild_missing_reports.py` builds them from:

- `CStdKarnameDoreh3`: the recovered mark table, formulas and grouping for 1024.
- `CStdKarnameDoreh_byBestStd_OneMark`: the recovered single-mark table and class/grade best-student subreports for 1032.
- `CR_AF_StdKarnameDorehByChart_term3`: the recovered course comparison expressions and linked student-progress report, used by both reconstructed layouts.

The existing 98 templates are unchanged. The new layouts preserve all base expressions, data contracts, grouping and existing subreports. Native chart bands have readable titles, the current student's name and independent course/progress plots. The formerly suppressed progress subreport is enabled and laid out without its empty legacy bands. This is a reconstruction of the intended configured report, not a claim to have recovered its absent original RPT or exact appearance. Source digests are recorded in rebuilt-reports.json.

The disconnected calculation tests independently assert student mark 70 versus class mean 50 while another student has mark 30. They verify that each progress subreport includes only its linked student's three terms (30,40,70) and excludes the peer (10,20,30). Both new layouts also pass the expression evaluation suite alongside the 98 original layouts.

Windows verification still must exercise the original preview button for 101, 1024 and 1032, render every generated page, check persisted student identity/name and school header, and inspect the output. Its fixture creates two students, a teacher assignment and a subject, enters term marks using the original import procedure, calculates final marks with the original procedures, and asserts final results 70/30 and class mean 50. These checks do not prove every report, mark entry workflow, printer or user role.
