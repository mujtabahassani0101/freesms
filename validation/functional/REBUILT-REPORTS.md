# Reconstructed catalog reports

Catalog entries 1024 and 1032 are visible (`tosifi IS NULL`) but refer to classes and RPT resources absent from the original executable. The original binary metadata audit is recorded in original-report-resource-audit.json. The port now provides explicit native XML layouts for these entries, rather than removing them or displaying a different catalog report.

`rebuild_missing_reports.py` builds them from:

- `CStdKarnameDoreh3`: the recovered mark table, formulas and grouping for 1024.
- `CStdKarnameDoreh_byBestStd_OneMark`: the recovered single-mark table and class/grade best-student subreports for 1032.
- `CR_AF_StdKarnameDorehByChart_term3`: the recovered course comparison expressions and linked student-progress report, used by both reconstructed layouts.

The existing 98 templates are unchanged. The new layouts preserve all base expressions, data contracts, grouping and existing subreports. Native chart bands have readable titles, the current student's name and independent course/progress plots. The formerly suppressed progress subreport is enabled and laid out without its empty legacy bands. This is a reconstruction of the intended configured report, not a claim to have recovered its absent original RPT or exact appearance. Source digests are recorded in rebuilt-reports.json.

The disconnected calculation tests independently assert student mark 70 versus class mean 50 while another student has mark 30. They verify that each progress subreport includes only its linked student's three terms (30,40,70) and excludes the peer (10,20,30). Both new layouts also pass the expression evaluation suite alongside the 98 original layouts.

Run 41518278379 (285d624) successfully exercised the original preview button for 101, 1024 and 1032, render every generated page, check persisted student identity/name and school header, and captured the output. Its fixture creates two students, a teacher assignment and a subject, enters term marks using the original import procedure, calculates final marks with the original procedures, and asserts final results 70/30 and class mean 50. These checks do not prove every report, mark entry workflow, printer or user role.

The next fixture adds a custom term0 exam (student marks20/10 and class mean15), as the recovered progress procedure deliberately excludes term1/2. The real progress input must include that eligible exam and the final exam (70/30, mean50), with the correct student linkage. Rebuilt charts now opt into series legends and numeric labels. Student page breaks move after the complete chart group and omit the last-record break. These additions passed 48 expression/export checks and original-button preview/every-page rendering in Windows run 41524997246. The actual student progress input20/70 and class means15/50 were asserted. Visual review found reversed physical text alignment for Persian; that renderer fix is pending a new Windows run. Some inherited fixed-height headers also truncate long names and still require layout work.

The reconstructed cards now replace the inherited cramped identity area with a growable multiline field for school/student/father/grandfather/code, retain the class/grade/exam, configured period dates and additional header, and relocate the original student-photo placeholder. Main marks, formulas, groups and best-student subreports stay in use. Native page rendering and visual review are pending for this layout revision.

The recovered exporter omitted BlobFieldObject sources in19 original layouts plus these2 derivatives. ReportModel repairs only the named Studentimg1 control when its local database declares exactly one Student_img blob field; an ambiguous binding is rejected. Native tests use different images per row, null and damaged payloads. Original-button report fixtures now save distinct PNGs for the two students and verify SQL bytes and actual page pixels. Fifty disconnected checks pass; Windows results for these photo cases are pending.

Windows run41527859737 passed the actual report fixture's persisted photo-byte and page-color assertions for both students in both reconstructed cards. Identity headers and the distinct photos were inspected visually. The same run's native component suite stopped at an unrelated, incorrectly targeted filter test before reaching its isolated photo tests; those component tests still need to execute. Follow-up heading-height and ungrouped identifier formatting changes need fresh Windows rendering.
