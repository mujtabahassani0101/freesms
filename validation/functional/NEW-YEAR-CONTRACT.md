# Recovered new-year transition contract

Static audit at runtime8b28642. No actual new-year Save case is currently certified; construction/menu checks are insufficient. The original asdbz handler is still synchronous and executes a separate sp_tYear_Student_Insert for each selected row.

| Source | SHA256 |
|---|---|
| dotnet/FreeSms.Original.Windows/asdbz.cs | 0ec31b62e291651e9637ad51b7e62768e99861f42bbbecdb47ad415814eb9ce3 |
| analysis/sql-resources/asdbv_txt14020107.Text.sql | a6d0096802c42d04ab43e3c4b7c1f4d17059e201cbf9c5eeecfe815373f0ed49 |

The form is restricted to original account id1 on Load. Destination year v is the current selected school year; source year l initially selects the preceding year using OriginalSchoolYears. Source grade/class are m_g/n; destination grade/class are m_e/m_i. Candidate grid r includes only source-class students not already enrolled in the destination year. Target grid s lists the destination year/class. Only rows with Selector=true are saved. The source list carries shaghe, hazer, mali and codeTakhfif. It initializes xTakhfif=0; admission/uniform/study-material/transport/robotics/head-cover/book flags to false; Fee1 and transport1 to null. Do not replace this with copying every source enrollment field.

Selecting a destination class loads its current monthly fee into x. The b() helper applies that amount to each row with xTakhfif0; discounted rows retain their edited amount. Before Save, selected rows require Fee1 parseable as Int32; a difference from the displayed class fee requires a nonzero discount. Optional transport1 must parse as Int32 if supplied. The existing handler does not reject negative amounts or preflight nine-month overflow.

The latest recovered procedure is the1402/01/07 alteration with18 inputs: xYear, xStudent, xPaye, xClass, xTakhfif, codeTakhfif, Fee1, transport1 and10 flags (shaghe,hazer,mali,dakhle,uniform,komakdarsi,ketab,transport,robotic,maghnae). It inserts only if the student/year is absent, sets Status1, repeats Fee1 and transport1 into each of nine months and multiplies each by9 for totals. A null transport amount remains null in all months and total; it is not implicitly zero. Sort is not supplied or copied by this procedure. No original-year records, raw/calculated marks, payment rows or student identity are moved or deleted.

Implementation gaps requiring repair and actual Windows evidence:

- The per-row writes have no encompassing transaction or error cleanup; a late overflow/SQL failure can leave earlier students transferred and the connection unclosed.
- Save has only Load-time admin authorization; recheck the original account constraint and valid current context when the write starts.
- Validate source year/class membership, current grade permissions, destination year/grade/class identity and selected student IDs under the transaction. A stale candidate or already-enrolled target must never overwrite an existing enrollment.
- Require nonnegative whole amounts with9*amount fitting Int32 before any insert; retain optional null transport semantics and exact original flag/discount behavior.
- Capture selected rows, validate together, use original procedure calls on one connection/transaction outside the UI thread, prevent closing mid-save, restore pending input on failure and refresh both lists only after success.
- Preserve prior years, marks, payments, identities, unselected students and any existing destination enrollment. Check current class fee/discount rules rather than trusting stale displayed fee text.

Required native cases: admin/nonadmin; source/destination year and grade switching; empty selection and destination; actual Save No/Yes; target-class default fee vs discount; zero/null/Persian/negative/fraction/overflow amounts; copied/reset flags and codeTakhfif; exact nine-month sums and nulls; prior-year isolation and no Sort invention; stale membership/already-enrolled target; late SQL rollback/retry; real SQL-lock heartbeat/close guard; repeated transition and reopening, plus backup/restore of transferred records. This audit does not implement or certify the transition.

## Replacement pending its first Windows run

YearTransitions now validates immutable selected entries and runs the recovered eighteen-parameter procedure in one transaction. It checks original account1 again at Save, source/destination class+year+grade, allowed grades, source identity/membership, existing destination enrollments, current class fee and discount identity. Source year must precede destination year. Amounts are nonnegative integers with nine-month totals fitting Int32; nullable transport and study flags retain the recovered SQL semantics. Sort is still not supplied. The original controller disables itself during Task.Run, blocks Close until the transaction finishes, preserves pending grid values after errors and refreshes both lists after commit.

Local compilation is clean and23 pure Core checks pass, including two new amount/null/immutable-capture cases. The new native case uses isolated years1421/1422, independent original-procedure fixtures, four students (one already enrolled), two selected and one unselected candidate, source marks/calculated results/payment, selected discount and nullable transport. It exercises actual Save No/Yes, empty selection, admin/grade/amount/discount rejection, changed class fee/year, stale source membership, existing target, a late SQL insert trigger, rollback/retry, real SQL-lock UI heartbeat/close guard, exact nine-month values/flags, prior/unselected records, repeat Save and reopen. None of these native new-year assertions is certified until a successful Windows run is archived. Larger classes, concurrent independent clients, backup/restore and all filter/keyboard paths remain additional scope.

## Verified bounded Windows evidence

Run42164493853/source23b8b21 passes the complete new-year original-button case and all19 business scenarios. The exact new-year log, synthetic visible capture, artifact receipts, completed workflow summary and native package proof are archived in runs/42164493853. Both Persian typed amounts commit through Number0 fields. Every pending transaction assertion listed above passed, including changed fee/year, stale enrollment and existing target rejection, late SQL rollback, retry, real SQL wait and protected old records. This supersedes the initial run41998023700 timeout before Save; the original unmasked typed amount columns were repaired. Native compilation,41 Core/database,183 component and58 report checks also pass.

The visible capture still clips long names/class titles and some narrow column captions; reachable hit targets and passing persisted effects do not certify its complete layout. Larger/concurrent transitions, restore/restart and the full filter/keyboard matrix remain open. Whole-application completion is unproven.

Run42342586651/source1af7b02 repeats the full passing new-year case with actual queued Space messages on native selector checkbox cells. This strengthens selection evidence beyond the prior programmatic assignments. The independent native component test also toggles two unbound rows, checks separate states/unchanged IDs and captures the rendered checkboxes. Other transition/layout/scale/restore cases above remain open.
