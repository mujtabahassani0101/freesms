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

## Other sections

Student registration, marks, attendance, fees/payments, user permissions, imports/exports, backup/restore and remaining reports still require their own complete scenarios and verified evidence. Their current action inventory status remains unverified. See PLAN.md for the full scope; do not infer coverage from the three scenarios above.

Expected native dialog button automation follows the documented [BM_CLICK focus requirement](https://learn.microsoft.com/en-us/windows/win32/controls/bm-click), after validating the message and locating its actual descendant button. It is confined to disposable-database workers.
