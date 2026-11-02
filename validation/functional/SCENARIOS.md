# Functional scenarios under development

These scenarios execute the original Windows forms and their actual buttons against a new, migrated copy of the supplied database. The connection guard rejects a user database. Each worker runs separately, records exceptions and has a parent-enforced time limit. Passing these cases does not prove the rest of the action inventory.

## Report preview (`FreeSMS.exe --verify-report-actions`)

Precondition: create year 1410, its exams, a dedicated class, named test student and school headers in the migrated disposable database. Never use the user's bank. Open the original report selector through the main menu handler; select each of reports 101, 1024 and 1032, one class and the compatible number of exams; click the original preview button. Require a viewer with at least one generated page after asynchronous data binding and assert the real input received by the viewer contains the named fixture student. An empty report template does not satisfy this assertion. Save a rendered screenshot. Unexpected dialogs, controller exceptions, missing fixture data and timeouts are failures. Render every generated page, including chart pages. The fixture uses original mark import/calculation procedures and independently checks final marks 70/30 and class mean 50. These cases do not yet cover all report configurations or correctness of every printed field.

Also inspect every `tRpt` entry's original factory, migrated template, main/alternate procedures and subreport procedure references. Log each missing dependency separately. These metadata checks do not prove procedure execution or report accuracy.

## Discounts (`FreeSMS.exe --verify-business-actions`)

Open the original discount form through its main menu handler with the isolated admin fixture. Use New and Save with an empty title; require the exact validation message and no insertion. Save a unique valid title with Persian text, apostrophes and SQL punctuation in its comment; verify the exact committed value. Select the saved row by database identity, click Edit, change the comment and Save; verify the same record changes. Use New and Cancel and verify no insertion. Delete the test record, first answering No and checking it remains, then answering Yes and checking only that record disappears.

Expected dialogs are acknowledged only when their actual message text matches. No unrelated dialog or external communication is accepted automatically.

## School settings (`FreeSMS.exe --verify-business-actions`)

Open the original school form through its main menu handler. Change province, district, manager and school name, including Persian text and apostrophes. Click Save and acknowledge the exact success message. Query every persisted field. Open the school form again and verify every textbox reloads the committed value.

## Student deletion (`FreeSMS.exe --verify-business-actions`)

Seed a dedicated year, class and student in the worker's guarded disposable database. Open the original student list through the main menu. Use two students and select the deletion fixture by database identity; click Delete and acknowledge the first warning. Decline the final warning and cancel the deletion panel; verify enrolment remains. Repeat the two confirmations with Yes; require the selected student and enrolment to disappear and the other student’s identity and enrolment to remain unchanged. The operation must work when the optional disciplinary table is absent.

The native database integration suite separately adds a temporary foreign key that rejects the final student delete. Require the earlier enrolment and image deletes to roll back. Drop the test guard in a `finally` block before checking successful deletion. This specifically tests atomicity after earlier statements have already executed.

## Backup and restore

See MAINTENANCE.md for the original-button and staged database round-trip/rejection/recovery scenarios. They use disposable catalogs and owned files.

## Teachers and drivers (`FreeSMS.exe --verify-business-actions`)

Open each original form through its main-menu route. Use New/Save with a quoted email/password or Persian driver comment. Teacher empty-surname validation must not insert. Require exactly one saved record and exact stored text. New teacher clears the previous teacher's email/password; Edit reloads the selected credentials. Edit/Save must update that same identity without inserting another row or overwriting the saved password. Cancel must leave committed values unchanged. Delete first with No and then Yes; require only the selected record to disappear. Run 41524997246 reached the quoted-text insertion assertions but failed at Edit because the keyboard-selected row did not enable the initially disabled buttons. The SelectionChanged repair and all remaining edit/cancel/delete assertions passed in Windows run41526253553.

## Payments (`FreeSMS.exe --verify-business-actions`)

Seed a separate year1411, a class and two dedicated students in the disposable bank, each with annual fee1000. Select the first student in the actual payment-list form, then open its editor using New. Require empty-payment validation, rejection of negative/fractional/out-of-range amounts and total overflow, and invalid-date rejection, each without insertion. Reject fee1001 as overpayment. Save fee400 and transport20 using Persian/Arabic digits and a quoted Persian comment; require exact persisted values and fee balance600. Reject another payment on the same date. Edit the saved identity to fee600; require one record and balance400 after reopening. Cancel an unsaved change to700. Decline deletion and then confirm it; require only the selected payment to disappear. Windows run41526253553 reached the first committed payment, then failed when the payment grid converted the Count date column to decimal. Count is now independent of numeric aggregation, with new populated/filtered/empty grid regressions. The complete original payment scenario subsequently passed in Windows run41527859737. It does not prove concurrent payments or every financial report.

## Half-year and annual attendance (`FreeSMS.exe --verify-business-actions`)

Create a separate year1412 with a dedicated class and two students, plus100 days per half. Exercise both original menu routes. Edit the actual grid's absence/sickness/leave cells using Persian/Arabic digits5/3/2; require present days90 for half-year and190 for annual attendance. Hold a real transaction lock on the selected disposable enrolment row, then Save with the original button. A UI timer must release the lock after350ms; this fails if SQL blocks the UI thread. Query all4 persisted fields after completion. Set present days above the available total and then negative; require the selected invalid row to stay rejected and its previous database values to remain, while the other valid row can save. Repair and save again, close and reopen the original form, and require the committed counts. At every save, require the other period's snapshot to remain unchanged. Both routes must be discovered; a missing route fails verification. Both attendance scenarios passed completely in Windows run41535136926, including the SQL-lock/UI-timer and reopen/close assertions.

## Original student registration/editing (`FreeSMS.exe --verify-business-actions`)

Create year1413 and dedicated classes. Open New from the actual student list and require the exact empty-name validation. Fill identity, zero gender, empty optional birth date, fee100+200 and transport25+30. A negative fee must leave the student count unchanged. Seed a selected PNG path, hold a real class-row lock and require a UI timer to release it while Save is waiting; then require one student/enrolment with totals300/55 and exact photo bytes. Reject duplicate code and number without insertion; cancel another new entry without insertion. Edit/reload the saved identity, move within the grade and update total fee350. Create a known mark25 and calculated totals, then confirm a grade change with an owned trigger rejecting the photo write. Require prior class, fee, raw/calculated marks, calculation flags and photo to survive. Drop the trigger and confirm a successful grade change: only that student's old-grade raw/calculated marks may disappear, and the photo/other students' marks must remain. Windows run41535136926 failed in fixture construction because the three classes reused a display order. The fixture now chooses unused display orders; actual registration/editing execution remains pending. The photo chooser itself is not exercised.

The attendance scenarios initially exposed false CellUpdated notifications in run41530385450. The repaired grid and both complete attendance workflows passed in run41535136926. See NUMERIC-GRID.md.

## Other sections

Student registration, marks, attendance, non-admin permissions, imports/exports and remaining report/editor workflows still require their own complete scenarios and verified evidence. Broader payment and backup cases remain in PLAN.md. Do not infer whole-section coverage from the limited scenarios above.

Expected native dialog button automation follows the documented [BM_CLICK focus requirement](https://learn.microsoft.com/en-us/windows/win32/controls/bm-click), after validating the message and locating its actual descendant button. It is confined to disposable-database workers.
