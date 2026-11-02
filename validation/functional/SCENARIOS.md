# Functional scenarios under development

These scenarios execute the original Windows forms and their actual buttons against a new, migrated copy of the supplied database. The connection guard rejects a user database. Each worker runs separately, records exceptions and has a parent-enforced time limit. Passing these cases does not prove the rest of the action inventory.

## Report preview (`FreeSMS.exe --verify-report-actions`)

Precondition: the migrated seed's default year has a class, an exam and report 101. Open the original report selector through the main menu handler; select report 101, one class and the compatible number of exams; click the original preview button. Require a viewer with at least one generated page after asynchronous data binding. Save a rendered screenshot. Unexpected dialogs, controller exceptions, missing fixture data and timeouts are failures. This first case does not yet cover all report configurations or correctness of printed values.

Also inspect every `tRpt` entry's original factory, migrated template, main/alternate procedures and subreport procedure references. Log each missing dependency separately. These metadata checks do not prove procedure execution or report accuracy.

## Discounts (`FreeSMS.exe --verify-business-actions`)

Open the original discount form through its main menu handler with the isolated admin fixture. Use New and Save with an empty title; require the exact validation message and no insertion. Save a unique valid title with Persian text, apostrophes and SQL punctuation in its comment; verify the exact committed value. Select the saved row by database identity, click Edit, change the comment and Save; verify the same record changes. Use New and Cancel and verify no insertion. Delete the test record, first answering No and checking it remains, then answering Yes and checking only that record disappears.

Expected dialogs are acknowledged only when their actual message text matches. No unrelated dialog or external communication is accepted automatically.

## School settings (`FreeSMS.exe --verify-business-actions`)

Open the original school form through its main menu handler. Change province, district, manager and school name, including Persian text and apostrophes. Click Save and acknowledge the exact success message. Query every persisted field. Open the school form again and verify every textbox reloads the committed value.

## Other sections

Student registration, marks, attendance, fees/payments, user permissions, imports/exports, backup/restore and remaining reports still require their own complete scenarios and verified evidence. Their current action inventory status remains unverified. See PLAN.md for the full scope; do not infer coverage from the three scenarios above.
