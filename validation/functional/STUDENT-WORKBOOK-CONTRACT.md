# Remaining student workbook Save contract

This records the recovered contract and its defects at ab3e0d8. The current replacement is implemented below; its bounded native Windows assertions passed in run41818150464/source8b28642. Native file selection/preview already has separate verified evidence.

The authoritative sources at runtime revision ab3e0d8 are:

| Source | SHA256 |
|---|---|
| dotnet/FreeSms.Original.Windows/asdb7.cs | f3180b3bc516f513c27ec1262fbcf5a8bd62558b03edbcdc659b027ac5a8af64 |
| analysis/sql-resources/asdbv_txt980308.Text.sql | 361f46ccb2c107306e68256001b0927df021d13a55fecdddddaccb283264925f |

The preview contract is Sheet1 with sort, code, paye, class, name, family, father, jens, numberasas, mainfees, stdfees, stdfeeskoll, payment, dakhele, exam, uniform, mobilefather and mobilemother. Header names ignore case. New native previews read once and skip blank/no-class rows; there is no longer a top-one/full-Fill duplication path.

The recovered Save maps Name/Family/Father to FName/LName/PName. Code is BigInt, NumberAsas is Int, optional sort is passed to the enrolment. Grade input0 maps to kindergarten id100; other inputs are restricted by the handler to0..12. A supplied gender must be0 (female) or1 (male); a missing gender becomes-1. RegDate is the selected year followed by /01/01. Phone values are passed as strings to nvarchar(11) procedure parameters.

The fee branches must be preserved explicitly rather than replaced by a generic equal split:

- mainfees is the class's base monthly fee; stdfees is this student's monthly amount; stdfeeskoll is this student's total.
- When total equals9 times the base class fee, all nine Fee fields equal that base fee and xTakhfif is0.
- Otherwise xTakhfif is the selected discount. A zero total fills all nine fees with zero. A positive total fills the first eight fields in order with the smaller of the remaining balance and stdfees; Fee9 receives the remainder. This also permits a remainder larger than one monthly amount.
- The existing handler requires a non-default discount selection before entering the loop, even for a full-fee row that later sets its discount to0. That early requirement needs an explicit behavior decision/verification when repaired.

Missing payment/dakhele/exam/uniform values become zero; negative or non-integer amounts reject. If any amount is nonzero, the handler calls sp_tPaymentStudent_insertFromXls for the just-inserted student, with the payment date, its weekday, the current account and an insertion timestamp. The date must round-trip through the existing ShamsiDate parser. This import procedure inserts a payment without the manual-payment validation path; overpayment and related accounting acceptance cases remain necessary.

Important implementation gaps found by inspection:

- The class lookup is scoped by year and grade, but its in-memory reuse key is only the class title. Consecutive same-title classes in different grades can reuse the wrong identifier.
- A newly inserted class is resolved with SELECT MAX(id), so concurrent inserts can associate a student with an unrelated class. Use the inserted identifier in the same transaction.
- The original import loops over rows, creates classes and calls student/payment procedures through separate operations; a late failure can leave a partial workbook. The replacement needs one transaction for the selected import, rollback of newly created classes/payments and preserved pending preview rows.
- The recovered section2 guard does not check each imported grade against the current grade permissions. Enforce year/grade/class consistency under the write transaction.
- Names/class lookup still use the legacy punctuation-stripping sanitizer. Parameterize the remaining lookup/write paths before preserving punctuation, including quotes.
- sp_tStudent_insert_FromXls rejects duplicate student code with CodeOut=-100 and duplicate NumberAsas with-200, returns the student identifier on success, and internally starts/commits a transaction. The outer transaction must handle its server-aborted failure path without masking the original error.

Required next native cases: actual Save No/Yes; full-fee/discount/zero/partial/large-remainder allocation; preserved quotes, BigInt codes and phone text; optional values; kindergarten/grade restrictions; same-title cross-grade class separation; duplicate code/NumberAsas; malformed dates and amounts; late student/payment SQL failure and complete retry; real SQL-wait UI heartbeat and close guard; reopening persisted students/fees/payments; repeat-import rejection without changes; unrelated students/years and backup/restore preservation. No student Save scenario is currently certified by this document.

## Replacement and native verification

WorkbookStudents and the original asdb7 Save button now capture validated immutable rows before starting one asynchronous database transaction. Class lookup uses year+grade+parameterized title; newly created classes use OUTPUT INSERTED.id. The recovered student and payment procedures run inside that same transaction. Grade permissions, existing grade/discount, duplicate code/NumberAsas, BigInt/phone/name limits and enrollment identity are checked. Pending preview values survive errors; success status is assigned only after commit, and closing is blocked while saving.

The original fee allocation and payment import semantics are preserved, including a ninth-month remainder larger than the monthly amount and import payments exceeding the imported tuition. Payment amount validation is nonnegative integer validation; this does not certify the separate manual-payment or balance-report paths. Full-fee rows no longer require selecting an unused discount; discounted/zero-fee rows still require one. Blank NumberAsas/sort/gender retain null/null/-1. Grade0 maps to100.

Three independent Core checks pass locally for fee branches, identity/validation and Persian dates. The passing native assertions use students-save.xlsx in an isolated year1420: real Save No/Yes, late validation/duplicate/grade failures, both late student and payment SQL triggers, complete rollback/retry, a real SQL-lock UI heartbeat/close guard, persisted values and fee allocation, same-title classes across grades/years, kindergarten, unrelated-record preservation and repeat-import rejection. These bounded cases passed in Windows run41818150464/source8b28642; its exact original-button log and artifact receipt are in runs/41818150464. The prior run41807977272 timed out on an incorrectly matched validation dialog before reaching the transaction; the full message match was corrected. Larger/concurrent workbooks, live permission changes and backup/restore of imported records remain additional acceptance cases.
