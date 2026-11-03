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

## Latest Windows results

- Run 41535136926 (be46e5d) passed167 native component/package/render checks,28 Core/database checks and50 report checks. The explicit grid save rejects fractional/overflowing integers without changing stored values or showing data-error dialogs; unchanged/canceled edits do not publish modifications. Empty/full/cleared masked dates and student photo/null/corrupt-photo rendering passed. The Core BigInt save/filter and server-aborted transaction preservation scenarios also passed.
- Nine of10 original business scenarios passed: backup, driver, school, teacher, half-year attendance, annual attendance, payments, student deletion and discounts. Both attendance cases completed their real SQL-lock/UI-timer test, all persisted/rejection/other-period assertions and reopening/closing without an unsaved question. Three report previews and every-page rendering passed.
- Student registration/editing did not reach its form. Its fixture reused sortRpt30000 for three classes; the real class procedure correctly rejected the duplicate display order. The overall workflow failed and its binary is not a verified release. Artifact receipts, component screenshots and full functional diagnostic logs are archived in runs/41535136926.

## Latest registration diagnostic (run 41537278992)

- Source401cf94 allocated valid fixture class orders. The registration scenario reached the real form, exercised required identity and negative-fee rejection, passed the SQL-lock/UI-heartbeat assertion, verified persisted gender0/empty birth date/fee300/transport55/photo, rejected duplicate code and basis number, and verified Cancel before entering Edit.
- The edit scenario then failed waiting for the next-student confirmation. Inspection shows the single-student launch from asdm does not populate ce (the optional navigation list); the recovered successful-save branch closes immediately in that case, without a message. The harness had incorrectly inferred next-student availability from the default-enabled navigation button alone. The workflow remains failed; later class/grade-change/rollback assertions have not passed.
- The single-student successful-save branch now displays the same edit confirmation as the last student in a populated list, before closing. The harness selects the exact expected message using both navigation-list contents and button state. Class/grade changes, persistence and late photo-failure rollback assertions are retained. This repair requires another Windows execution.
- Nine other business scenarios passed, as did report previews, native components, Core/database, original-form rendering, login and menu probes. Functional logs and the SHA256-verified artifact receipt are archived in runs/41537278992; this failed run is not a verified release.

## Follow-up registration diagnostic (run 41538737957)

Source25d32bd passed the same initial registration and rejection checks and nine other workflows. Edit then stopped in the test helper before Save: Field<T> searched only non-public fields, but asdat.ce is public. The actual stack identifies Field<T>/EditSave, not the production save handler. The helper now resolves both public and non-public instance fields and reports missing/null/type errors explicitly. The single-student confirmation and downstream class/grade/rollback checks remain awaiting Windows verification. Functional logs and their verified artifact receipt are archived in runs/41538737957. The new individual-mark baseline in MARK-ENTRY.md is also queued for native execution.

## Repairs awaiting a fresh Windows run

- The student fixture now allocates three unused, in-range display orders from the disposable bank. Production class validation was retained. Registration and its initial rejection/persistence checks ran in41537278992 as detailed above; edit/class/grade-change completion still needs a passing Windows run.
- Student/enrolment, optional photo and confirmed grade-dependent mark removal share one asynchronous transaction; the old pre-save mark deletes were removed. The pending scenario covers required name, negative fee, zero gender, exact fee/transport totals, selected photo, duplicate code/number, cancel, edit/class move and both rejected/successful grade changes. A real class lock tests responsiveness; an owned rejecting photo trigger must preserve prior class/fees/raw and calculated marks/calculation flags/photo. File-picker interaction itself remains untested: the fixture seeds the selected path.
- Whole-section readiness remains unproven despite the passing limited scenarios. Native metadata/render checks do not establish every report's populated content or every control workflow.

## Original mark and student diagnostics (run 41557658288)

Source4cda39b ran11 business cases. Nine passed. Student Edit now reached and acknowledged the exact single-student success confirmation, then failed the persisted class/fee350 assertion. The next run logs the editor's selected ID/class/first two fee inputs and reports actual persisted class/Fee1/Fee2/SumFee on failure; the assertion has not been relaxed. Grade-change rollback assertions remain unexecuted.

The new mark baseline found a real native DataGridView NullReferenceException when changing student selection: the original controller rebinds the mark grid and sets CurrentColumn while its prior edit is ending. The compatibility CellEndEdit handler called EndEdit again, and recovered CellUpdated handlers also end row edits. CellEndEdit now commits binding and publishes the change under a guard, so recursive row-end calls cannot re-enter native editor disposal. A native regression changes cells while its update handler also ends the row edit. The native recursive-end-edit regression passed in run41558287376 (168 native checks); the original mark workflow still requires its result to be inspected. All functional logs and the SHA256-verified receipt are archived in runs/41557658288.

## Authentication repair awaiting Windows execution

The original login and password-change entry handlers had fixed vendor-override branches that bypassed the selected account's saved password. Both now always call the original password validator. No production credentials or permission records are migrated by this patch. AUTHENTICATION.md describes the original-button regression for rejected credentials, password editing, mismatch/cancel/confirm persistence and old/new password verification in the disposable bank. Local build passed with0 warnings/errors; native execution is pending. Non-admin permission coverage remains open.

## Latest functional diagnostics (run 41558287376)

Source48ab851 passed168 native checks including recursive edit completion; nine of12 business cases passed. Original individual mark entry still failed while replacing the marks grid data and changing its active column. Bind now explicitly cancels the old native editor before replacing the source/columns, with a separate native regression for stale text/focus after rebinding. This change still needs Windows verification; the narrower passing168-check result did not prove the original workflow fixed.

The student diagnostic showed the selected class was saved correctly and fee1=1000/fee2=250/total8250 matched the actual editor inputs: the recovered class selector applies its new monthly class-fee template. The test now enters all nine intended fees explicitly after selecting the new class, retaining its expected total350 and the later grade/photo/mark rollback assertions. Production fee-template behavior is unchanged.

Authentication correctly rejected empty/incorrect/former-override passwords and incorrect password-edit access, preserved mismatched/declined replacements and stored the confirmed replacement; reopening rejected the old password. Its final assertion required both the account ID and immediate modal invisibility, without reporting which condition failed. Modal closure can finish after ShowDialog unwinds; the revised assertion checks the authenticated account and non-None dialog result (closure requested), with diagnostic values if either fails. This is a test-lifecycle hypothesis, not yet a proven diagnosis of the final failure. Successful new-password login still requires the next native result; it is not claimed passed here.

Functional logs and native168 logs with verified artifact receipts are archived in runs/41558287376.

## Class-management repair prepared

Original class Save now validates nonnegative Int32 fees and display orders0–32767 and normalizes Persian/Arabic digits before SQL. Previously int.Parse accepted negative/out-of-range-for-smallint orders. New clears the prior supervisor/fee/order/shift. Class deletion is year-scoped and transactional and rejects enrolled students and teacher/subject dependencies; the original form displays validation/SQL failures safely. CLASS-MANAGEMENT.md defines the original-button validation/CRUD/cancel/occupied-delete/duplicate regression in a disposable year1416. It compiles locally; Windows execution is pending.

## Limited-user permission regression prepared

The authentication scenario now creates an owned non-admin account with section1/grade1, checks its actual login and exact loaded permissions, opens the allowed original class form and verifies the original student form denies section2. Separate logins with missing section permissions and missing grade permissions must show their original warnings without authenticating. Cleanup deletes the owned account and restores prior session/password state. The extension compiles locally; native execution and the rest of the permission matrix remain pending.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.
