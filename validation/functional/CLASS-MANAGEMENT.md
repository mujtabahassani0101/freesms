# Original class management

Status: prepared and locally compiled; native Windows execution pending.

The original class Save accepted negative fees and display orders outside the SQL smallint domain, because it only used int.Parse. It now validates nonnegative Int32 fees and display orders0–32767, normalizes Persian/Arabic digits and sends normalized values to the original procedure. Class deletion now uses a year-scoped transaction and rejects existing enrolments and teacher/subject assignments with a clear message; the original form handles validation and SQL errors instead of allowing an unhandled exception. The New button clears supervisor, fee and display order and resets the shift, so details of the previously edited class are not carried into a new class.

The guarded disposable worker creates year1416 and one occupied peer class with a unique display order. The original New/Save/Edit/Cancel/Delete buttons must reject missing title/supervisor, negative/fractional/overflowing fees, negative/fractional/out-of-range order, duplicate name and duplicate order without insertion. A Persian-digit fee150 must persist, Edit must reload it, Cancel must preserve it, and a confirmed Edit must change only the selected class to200. New must clear prior details. Deleting the occupied peer must be rejected; a class with a teacher/subject assignment must remain intact after the delete confirmation and exact dependency warning; declining deletion of the empty owned class must preserve it; confirming must remove exactly that class.

This scenario does not verify printing, all grade/shift/permission combinations, SQL-wait responsiveness, simultaneous edits or new-year transfers. These remain in PLAN.md. It must not be marked passed from compilation or menu opening alone.
