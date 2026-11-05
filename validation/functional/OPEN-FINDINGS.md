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

## Native component evidence (run 41559110225)

Sourcecf7dfd7 passed169 native component/package/render checks, including the new stale-editor rebind/focus regression and recursive edit completion. It also passed28 Core/database checks and50 report checks. Verified artifact receipts and full logs are archived in runs/41559110225. The subsequent functional artifact is reviewed below; component results alone do not establish original workflow completion.

## Latest original-button results (run 41559110225)

Sourcecf7dfd7 passed11 of13 original business cases. The complete student registration/edit/class/grade-change scenario now passed, including the real SQL wait/UI heartbeat, exact explicitly entered monthly totals/photo, duplicate/cancel behavior, late photo-trigger rollback preserving old raw/calculated marks/fees/flags and successful confirmed grade-change cleanup. This proves that scenario, not every registration or new-year path. The original administrator authentication/password-change baseline also passed, including rejection of the former override and old password, persisted confirmed replacement and successful new-password login. The non-admin extension is newer and still pending.

Class management passed missing fields, negative/fraction/overflow fee/order rejection, Save, Edit, Cancel and clearing New fields, then timed out because the duplicate-name test also reused the already-saved class's order. The procedure reported duplicate order first. The test now uses a fresh order to isolate duplicate-name validation, followed by a separate duplicate-order case. Occupied/dependent/delete assertions have not yet run.

Individual mark entry still failed from the native SelectionChanged callback while CurrentCell was being assigned and a dependent grid was focused. GRID-SELECTION.md records the documented event order and revised compatibility dispatch: native selection notifications are queued until the operation completes; public Row/CurrentColumn setters publish after their native assignment returns. Two dependent-grid regressions check the new row identity and editor focus. The real original mark workflow remains unverified.

Full functional logs and the verified artifact receipt are archived in runs/41559110225. The overall workflow failed; its binary is not a verified release.

## Limited-user permission regression prepared

The authentication scenario now creates an owned non-admin account with section1/grade1, checks its actual login and exact loaded permissions, opens the allowed original class form and verifies the original student form denies section2. Separate logins with missing section permissions and missing grade permissions must show their original warnings without authenticating. Cleanup deletes the owned account and restores prior session/password state. The extension compiles locally; native execution and the rest of the permission matrix remain pending.

## Latest native and functional evidence (run 41560201196)

Source4a3a0eb passed171 native checks, including both dependent-grid selection regressions. Eleven of13 business cases passed again. The complete administrator/password-change and limited-user scenario passed: an owned non-admin authenticated with section1/grade1, the allowed original class form loaded, the original student form denied access, and accounts lacking section/grade permissions remained unauthenticated. Student registration/edit/grade rollback also passed again.

The original mark workflow still failed when selecting a student and changing a column in its hidden mark panel. SelectCurrentCellText previously began native editing even for an invisible grid with no handle. It now skips editor creation until the grid is visible and its handle exists. A dedicated hidden-panel regression verifies source/column replacement while hidden and normal editing after opening. This is the next repair to test, not a claim that171 green component checks proved the original workflow fixed.

Class duplicate-name validation still did not report a collision. Static inspection found Core Values.Text normalizes Arabic letters to Persian, whereas recovered asdaj.b normalizes Persian letters to Arabic. The fixture created through Core and entry through the original UI therefore differed in code points. A shared year-scoped, parameterized ClassNameExists comparison now normalizes both forms and spaces; both Core SaveClass and original class Save use it. The fixture/test retains the mixed-route input and expected duplicate rejection. Dependency/deletion assertions remain pending.

Verified artifact receipts, native171 log and full functional logs are archived in runs/41560201196. The overall failed binary is not a verified release.

## Additional populated report scenarios prepared

The original-button preview matrix now includes first-term cards104 (portrait) and105 (landscape), in addition to101/1024/1032. They use the existing SQL fixture's raw marks30/10 and independently known class mean20, requiring actual main input values, student photos and every-page rendering. The landscape card's configured course Sub1 is checked separately; it is not treated as the progress Sub1 used by other layouts. These scenarios compile locally but have not run on Windows. Five60-second worker bounds plus initialization are accommodated by the report parent420-second bound. This does not establish all report selectors or print/export correctness.

## Malformed account-data repair prepared

The recovered account decoder directly parses nested Base64 and indexed substrings. Account validation now handles malformed format/argument/index data with a specific rejection message and restores prior section/grade context on failed validation, while preserving the original accepted-format logic. The owned-account original-button scenario independently corrupts pwd/per/xPaye, checks Login and password-edit rejection without partial permissions, repairs the data and logs in, then tests a selected account deleted after the login window opened. Local build passed with0 warnings/errors; these native cases are pending.

## Current native evidence (run 41561544090)

Source0b48151 passed174 native component/package/render checks. The three hidden-panel regressions passed: no editor is created while hidden, source/current-column changes preserve the new hidden data, and opening the panel enables normal editing. The verified functional artifact confirms all five original preview scenarios101/104/105/1024/1032 passed their data/photo/every-page assertions. Twelve of13 business scenarios passed, including the original individual mark-entry Save/Edit/Cancel/reopen and peer/other-exam preservation baseline. Class management still failed awaiting duplicate-order rejection. Functional logs and first-term card images are archived below; visual findings prevent a print-readiness claim. Native log and SHA256-verified receipt are archived in runs/41561544090. No full application or release claim follows from these component results.

## Latest original workflow result and report visual findings (run 41561544090)

The original mark-entry baseline finally passed after the hidden-editor guard. This does not yet prove validation bounds, clearing/deletion, multiple-subject atomicity, SQL-lock responsiveness or bulk entry. Authentication/limited permissions and student grade-change rollback passed again. Class duplicate-name rejection now passed for the mixed Persian/Arabic name fixture, but its duplicate-order case reached Save/reload without the expected warning. The next source checks a shared year-scoped ClassOrderExists from both Core and the original form, retaining the original SQL procedure; the fixture now logs entered/stored order/year and checks an existing collision before clicking. Dependency/delete assertions still have not run, and the exact legacy-procedure discrepancy is not claimed diagnosed.

Original104/105 previews passed known marks30/10, class mean20, configured subreport checks, SQL photo bytes and every-page photo-color checks. Manual inspection of every resulting first-term card page found substantive presentation defects:104 clips the first student's identity and starts the next student's repeated title at the previous page's tail;105 splits student cards/chart/rankings across three pages for two students and mixes the previous card's continuation with the next card. Narrow ranking cells clip names/values; charts lack useful legends/value labels. These remain open despite successful data assertions. The original XML/report inputs are preserved; no print-readiness or fully verified release claim is made.

## First-term layout adaptation prepared

The new in-memory FirstTermCardLayouts adapter reflows only104/105, preserving recovered files and data/calculation/link contracts. It adds growable identity fields, reflowed tables/summary/attendance/rankings, named/value-labelled chart series and a page boundary after all student content. Landscape orientation and the distinct meanings of Sub1 remain. All56 report checks pass, including long-name/ID retention and original formula/group preservation. The original-button fixture now enforces two separate pages for its two one-course students, stable orientation, no mixed parent-band student IDs and one photo per page. Native rendering/visual review remain pending.

## Latest class fixture and account results (run 41562748761)

Twelve of13 business workflows passed again. The new malformed pwd/per/xPaye, recovered-account login and deleted-selected-account cases passed through the actual original buttons, alongside the previously verified login/limited-user checks. Class stopped before duplicate-order Save: its diagnostic proved peer=0, stored-order empty. The fixture lookup passed Arabic-normalized text to a Core-created Persian-normalized name, then Convert.ToInt32(null) silently returned0. It now queries the Core-canonical name with Single(), reads the persisted ID/order and requires a positive ID. The retained order-collision precondition and original dependency/delete assertions must run on Windows; no legacy SQL failure is inferred from that invalid fixture.

## Populated gallery capture prepared

Business probes now save actual, visible, reloaded fixture forms under navigation-checks/docs-gallery: student list/edit, mark entry, class and payment. A small original-populated-gallery artifact is uploaded independently of the final full evidence bundle. No constructed empty form or fake logged-in main window is substituted. Captures still need Windows execution and review. README/docs screenshots are being handled in the other user chat; this work does not edit those files.

## Complete bounded workflow result (run 41568720739)

Sourceef6188c completed both Windows jobs successfully. Verified evidence confirms174 native component/package/render checks,28 Core/database checks,50 report checks, all13 original business workflows and all5 populated report preview/data/photo/every-page cases. Class now reached and passed its duplicate-order, occupied/dependent deletion rejection and confirmed/canceled deletion assertions after the canonical fixture lookup was corrected. This is the bounded scenario set, not the full PLAN.md scope. Original source104/105 layouts still have the previously documented visual defects; the new in-memory layout is not in this run.

The populated gallery was SHA256-verified and extracted. Manual inspection found a real mark-form usability issue: its student grid paints over the mark editor. The editor now comes to the front when opened; its workflow tests actual visible hit targets for the Save button and mark cell, in addition to persisted effects. A new gallery will provide visual verification. The earlier gallery captures and native/core/functional receipts/logs are archived in runs/41568720739; README/docs screenshots remain owned by the other user chat and are excluded from these code commits.

Local validation of the pending layout adapter passes56 report checks and the main application builds with0 warnings/errors. Original preview workers will render all diagnostic pages before checking two-page/two-student/orientation/photo separation assertions, so failures retain their visual evidence. Native execution of the layout and mark-panel visibility repair is pending.

## Other open work

- Visible disciplinary menus still require schemas/procedures missing from the supplied Afghan database. Existing compatibility messages do not implement those workflows.
- Student registration/editing/moves, original mark entry, attendance, payments, non-admin authentication/permissions, imports/exports and remaining report/editor workflows are not proven complete. Preserve all requirements in PLAN.md.
- Exact empty-fixture warnings (no lessons or no configured school-day counts) are classified as expected validation only when the matching database prerequisite is absent; they do not prove populated workflows.

## User-reported card layout / original reference

The attached1024 card remains unacceptable. Run41589840339 also failed the invented105 reflow's page-count check; business actions and native component checks passed in that run. The next change removes the invented104/105 reflow and1024/1032 compositions, uses the available intact original annual card for the two absent resources, and restores omitted original shape/rotation/area properties.57 disconnected checks and builds passed locally. Windows rendering and visual review remain required. The exact missing1024/1032 designs are still not recovered.

## Original-card layout resolution (b2517de)

Run41599723649 completed successfully:182 native checks,28 Core,58 reports,5/5 original report actions,13/13 original business actions,89forms, initialization/login and menu responsiveness. Actual original annual/first-term layouts replace the invented reflows/compositions; recovered drawing anchors, area pagination and authored fonts are in use. Final pages were inspected, including independent landscape columns and the12-subject native fixture. See RECOVERED-REPORT-LAYOUTS.md and the final run receipts/logs/images. The two absent catalog-specific layouts are explicit aliases of the available original annual card, not newly claimed recoveries. Existing full-application scope limits above remain open.

## Expanded individual marks and cross-form search (83e87fc follow-up)

Windows run41608010590 passed the original mark Save/Edit/Cancel baseline and out-of-range rejection, but the new harness then incorrectly tried to commit a fractional value into the authored M1 Number0 column. Native validation correctly rejected that edit. The test now asserts rejection without rounding/data loss and uses an integer for the later transaction/lock scenarios. No claim is made that those later assertions passed in this failed run. Its functional summary and full mark log/verified artifact receipt are archived.

The pending extension includes a real annual 100-point entry/reopen/Cancel and the recovered M2/Mark persistence convention. Local compilation passes. Windows execution remains required.

Static cross-section review also found raw text concatenation in eight name filters across teacher, driver, subject, individual marks and previous-grade marks. These queries now pass search text as SQL parameters. The original teacher/driver/mark button scenarios include apostrophe/SQL-punctuation searches; subject and previous-grade populated searches still need dedicated native cases. Office-dependent import/export and missing discipline schemas remain open alongside PLAN.md.

## Further native results (run41765855928)

Source08da312 passed13/14 business scenarios and5/5 report previews. The expanded individual-mark case now passes invalid annual Cancel/reopen and actual hidden M3 preservation with the recovered M2/Mark annual-total convention. Subject CRUD, combined grade/name filtering and real apostrophe preservation pass. Their full logs, summaries and SHA256-verified artifact receipts are archived in runs/41765855928.

The restricted-account sweep progressed through30 denied forms, then asdbw (batch report selector) threw NullReferenceException while closing without initialized settings tags. Its close handler also deleted the denied user's print selection before failing. Closing now skips all work until entry was authorized, and skips settings persistence until those settings were loaded. Each denied-form case additionally checks unchanged print selection and report parameters, not just the dialog/session. The rest of the sweep remains unproven.

The new native invalid-editor Cancel check failed in this run. GridEX.CancelEdit no longer calls BindingSource.CancelEdit, which can roll back other current-row edits; it discards only the active cell editor, matching the existing rebind path. A temporary diagnostic records stored value/event count/editor state for the next Windows run. This repair is not yet verified on Windows. Full application scope remains open.

## Restricted forms pass; bulk mark entry repair queued

Run41794296110/source99ff885 passes all14 current business and5 report cases, including all40 restricted forms with unchanged session, print selection and report settings. Verified functional receipt, authentication log and summaries are archived. Native component checks still fail the newly added explicit Cancel assertion: diagnostic shows the value124 and3 update events are correct, but the editor remains active. The .NET10 implementation of [DataGridView.CancelEdit](https://github.com/dotnet/winforms/blob/v10.0.0/src/System.Windows.Forms/System/Windows/Forms/Controls/DataGridView/DataGridView.Methods.cs) calls CancelEdit(endEdit:false), restoring its text while retaining the editor. The adapter now ends that restored editor too; Windows verification remains required.

The recovered bulk mark controller separately wrote/deleted each student's mark and invalidated processing before validation. It also omitted year/grade predicates from its enrollment load and wrote display order into tStudent instead of the selected tYear_Student row. Its replacement preserves the authored controls, selectors, averaging, annual M2/total convention, uniform fill/clear and unsaved-close behavior. It snapshots validated rows, uses the original mark procedure in one transaction, rechecks enrollment eligibility/exam year/book grade inside that transaction, and runs writes off the Windows UI thread. Visible integer M1 input remains integer; hidden Number2 components retain their fractional values rather than being discarded by int.Parse. Order changes remain immediate, with validation, year scoping and asynchronous SQL handling.

A new actual selector/button workflow is queued for Save/reopen, stale enrollment, bounds, late-student SQL failure with complete rollback, pending-edit retry, both calculation invalidations, a real SQL lock released by the UI timer, unsaved-close Yes/No, uniform Persian input, clear Yes/No, other-exam preservation, duplicate historical enrollment exclusion, year-scoped order and annual100-point M2 storage with retained hidden component. These changes are not yet certified by Windows evidence; other PLAN.md sections remain open.

## Native Cancel passes; bulk fixture collision (run41795351792)

Source3618a96 passed183 native component checks, including explicit invalid-editor Cancel and subsequent rebind. All14 previously covered business scenarios and5 report previews passed. The new fifteenth bulk scenario failed during setup before its selector opened: it reused the individual-entry fixture's class name/year. Bulk now uses independent year1417 and student/subject codes5998001/2 with distinct names; individual entry remains year1414/codes5995001/2. This is a harness setup repair, not evidence of a passing bulk Save. Verified receipts and exact native/functional logs are archived.

Further bulk review also repairs rejected immediate ordering: restore the last loaded/saved order in the grid, and prevent Save/uniform-fill from starting while ending a sort edit launches its async update. The all-class fixture now includes an unrelated grade2 student and checks invalid-order restoration. Windows verification is still pending.

## Bulk save stages pass; repeated dirty close stalls (run41796057403)

Sourcea7f2369 passed the previous14 business cases and all5 report previews. Its bulk scenario reached successful Save, stale-enrollment rejection, bound rejection, a late-student trigger rollback, complete retry and both processing invalidations while a UI timer released a real SQL lock. The worker then timed out after both unsaved-close No and Yes were acknowledged. The recovered close handler left its dirty flag false after confirmed discard, so subsequent owned-form cleanup requested another unsaved-close dialog. Confirmed discard now cancels the editor and marks the exiting form clean; the Close button bypasses validation so malformed editor text can be discarded too. The scenario now explicitly discards an invalid editor after rejecting the first close. Remaining reopen/fill/clear/order/annual assertions still require their own native pass. Full failed bulk log and verified receipt are archived.

Static batch-report review also found that removing one selected student deleted that student's rows for every user, and report class selection read every user's temporary list. Both queries now include a typed current-user parameter. A new independent year1418 fixture exercises the actual batch selector's grade filter, Add/duplicate/Remove/Clear/Close buttons with overlapping selections belonging to another user. It also checks unchanged report settings. That scenario covers selection management; actual populated batch-report rendering/export remains open.

## Expanded workflows verified (run41797019414)

Runtime sourcec7efb21 completed both Windows jobs successfully:16/16 business cases,5/5 populated original previews,183 native component checks,31 Core/database checks and58 report checks, plus original-form construction, initialization/login and menu responsiveness. SHA256/CRC-verified receipts and full new bulk/print-selection logs are archived alongside authentication, marks, subjects and summaries.

The bulk workflow now completes its formerly blocked close/discard/reopen stages, including malformed editor text, uniform Persian input, clear No/Yes, all-class year/grade isolation, persisted ordering and invalid-order restoration, and annual M2/total storage with retained M3. The actual batch list buttons preserve another user's overlapping selections through Add/duplicate/Remove/Clear/Close, with unchanged report settings. The native Cancel/rebind regression also passes.

These results supersede the specific pending assertions above. They do not prove all448 click actions, history marks, actual batch-report rendering, native Excel import/export, missing disciplinary workflows or the remaining PLAN.md requirements. Whole-application completion remains unproven.

## Hidden-form capture limitation

Review of both the earlier and current c7efb21 packaged original-forms/asdbd.png found a uniformly gray image (933x692, RGB240 throughout). OriginalProgram's89-form probe creates each hidden form and calls DrawToBitmap without showing it, so its successful result proves construction/drawing-call completion, not visible control layout. Earlier references to the constructor/render audit must be read with this limitation. The separate populated SaveGallery cases require a visible form and retain useful UI evidence, as do actual report pages. Bulk/list visual captures and real hit-target checks must be expanded alongside the remaining application workflows; the blank constructor capture is not accepted as UI fidelity evidence.

## Expanded marks/search confirmed; subjects under test

Run41608908198 passed all13 business and5 report scenarios. Its full individual-mark, teacher/driver quoted-search logs and verified artifact receipt are archived. Individual marks passed the new multi-subject rollback/retry, SQL-lock/UI heartbeat, bound/fraction rejection, clearing and actual annual100-point M2 storage checks. These replace the earlier pending status for those specific assertions.

Subject Save/Edit/duplicate-name checks also concatenated the title directly into SQL. Their names are now parameters, preserving the existing numeric/type/calculation branches. The next Windows scenario exercises required name, quoted Save/Edit, exact identity/grade/flag persistence, Cancel, duplicate name/code, actual KeyUp search and both delete confirmation choices. Subject dependency protection, numeric rejection, responsiveness and concurrent changes still need deeper coverage; the whole application remains incomplete.

## Subject combined-filter failure (run41609610238)

Source9dd9f60 passed13 existing business cases and5 report cases. The new subject scenario passed required-name and quoted insertion, then failed its filtered-list assertion. The recovered filter builder replaces its accumulated name clause when a grade is selected, so searching is ignored in that combination. It now appends the grade predicate with a SQL parameter, retaining both filters. The fixture also exits the continuing New panel before searching. Edit/Cancel/duplicate/deletion assertions still need a fresh native pass. The failed scenario log and verified artifact receipt are archived.

## Denial/Cancel state and name normalization (run41610759492)

Source7484e32 passed11 of14 business scenarios and all5 report previews, alongside the Core/native/report checks. The expanded denial sweep reached asda2, displayed and acknowledged the exact access-denied dialog, then timed out: its default dirty flag was false, so closing the uninitialized denied form requested unsaved-change confirmation. Four other guarded forms use the same initial-clean convention; their flags now start clean, while their existing edit handlers still mark real edits dirty. No unexpected confirmation is accepted by the harness. The remaining denial sweep is still unverified.

The annual mark scenario passed bound rejection, then timed out when Cancel/reopen encountered the previous invalid row marker. Cancel now clears validation state and cancels its pending native editor; loading another student's grid also clears the stale marker. A native regression checks explicit invalid-editor Cancel without value mutation or false CellUpdated. The full annual hidden-component scenario remains required.

The subject search assertion exposed a second cause: asdaj.b deletes punctuation, including apostrophes, before the already-parameterized query. The prior fixture normalized its expected name through that function and therefore did not prove punctuation preservation. Parameterized teacher/driver/subject name writes and filters now use a letter-only normalizer, as do the parameterized individual/history mark searches; the legacy sanitizer remains unchanged at unconverted SQL callers. Expected fixture names retain their actual apostrophe. Windows verification is pending; existing earlier search claims are limited by this newly identified normalization issue. Full failed logs and verified receipt are archived.

## Native Excel preview implementation queued

The two recovered Excel file buttons (asdb7 student import/asdv mark import) now read binary XLS and OOXML XLSX with a managed reader instead of ACE/Jet. The recovered Sheet1/required-column contracts and Save controllers remain in place. Loading runs off the UI thread, prevents close while active, and replaces the previous preview only after complete parsing and schema validation. Names, leading-zero text, zero/fraction marks and blank cells retain their values; repeated loads replace rows instead of appending the original top-one probe. Duplicate/reserved headers, unnamed populated columns and Excel error cells reject explicitly. No database writes occur while previewing. ExcelDataReader3.9.0 is pinned with its MIT notice and source-license provenance.

Local .NET10 compilation passes without warnings. All17 local Core checks pass, including recovered original binary examples and independent valid/malformed OOXML fixtures. Actual file chooser Open/Cancel and preview/error-preservation workflows, plus visible bulk/list captures and hit targets, are queued for Windows execution. These claims do not certify the legacy student/mark Save transaction paths or Office COM exports, which still need replacement/verification. The 89-form probe now labels its hidden drawing limitation explicitly.

## Workbook mark Save transaction prepared

Further review of asdv found per-row synchronous mark writes and processing invalidation before confirmation/validation. Its Save controller now captures validated input, keeps the recovered blank-mark skip semantics, calls the original sp_tMark_insertUpdate_FromXls_Af inside one transaction, validates exam year/student enrollment/subject grade/current allowed grades, and invalidates selected/annual calculations only on committed success. Duplicate student/course pairs reject. The recovered varchar(14) import-code limit is checked explicitly to prevent silent truncation; this does not claim wider import identifiers. Hidden mark components remain under the original procedure's update convention. Writes run off the UI thread, block closing while active and keep pending file values after failure.

Local .NET10 compilation and all18 Core checks pass. Native confirmation No/Yes, bounds, unknown student, duplicate/grade rejection, a last-row trigger rollback/retry, real SQL-lock/UI heartbeat and close guard, fractions/zero/blank/hidden components, repeat import and other-exam preservation are prepared but still require their own Windows evidence. Student Save and Excel COM exports remain open; workbook preview evidence does not certify those paths.

## Workbook previews and visible bulk/list probes verified (run41803073532)

Runtime source47e1abf completed both Windows jobs successfully:18/18 business cases (including actual native student/mark file choosers with recovered XLS and valid/malformed XLSX),5 original report previews,183 native checks,35 Core/database checks and58 report checks. SHA256/CRC-verified receipts, full workbook workflow logs, summaries and four new visible captures are archived. Actual chooser Cancel and rejected workbook loads retain the prior valid preview, exact row counts, database counts and exam processing state. Bulk Save/grid and batch Add/Remove real hit targets pass. These results certify the specific preview assertions, not the newly prepared mark Save transaction.

Visual review of the new bulk capture also shows clipped student names/codes in the authored narrow columns. Reachable controls do not prove readable data in every column. This remains a visible UI finding for follow-up alongside the remaining whole-app scope; no layout-completeness claim is made.

## Workbook mark transaction verified (run41804308541)

Runtime sourceab3e0d8 completed both Windows jobs successfully:18/18 business scenarios,5/5 populated original report previews,183 native component checks,36 Core/database checks and58 report checks. Verified functional/Windows receipts, full workbook logs and summaries are archived. The native workbook Save scenario passes confirmation No without any writes/invalidation; late bounds, unknown-student, duplicate and forbidden-grade rejection; last-row SQL trigger rollback with all prior marks/processing flags intact; pending input retention and complete retry; a real SQL lock released by the UI timer while close is blocked; original fractional/zero/blank/M2 semantics; selected/annual invalidation, other-exam preservation and repeat import without duplicates. These results supersede the prepared-only mark Save status above. Student Save and Office COM exports remain unverified/unreplaced.

The current run's first-term and annual page1 captures were also visually inspected and archived. Known totals/photos/page isolation remain verified, but long combined student/parent identities in narrow header/ranking cells show ellipsis. This is an additional readable-text acceptance gap; the five passing previews do not certify long-name layout fidelity.

### Student workbook transaction replacement — pending Windows verification

The original student Save handler is replaced with validated immutable entries and one asynchronous class/student/enrollment/payment transaction. Year+grade+title class resolution and OUTPUT INSERTED.id repair cross-grade reuse and SELECT MAX races; row-level grade permissions and duplicate protection are enforced. Original nine-month tuition allocation and original payment-procedure semantics are retained. Local compilation and21 pure Core checks pass. The new native button/rollback/SQL-lock cases are pending and do not yet upgrade the section to verified; see STUDENT-WORKBOOK-CONTRACT.md.

Run41807977272/source5faa270 passed39 Core/database,58 report and183 native checks, plus5 report previews and17 business cases. The student-workbook worker timed out at its negative-payment validation message because the new Dialog assertion supplied a prefix without its requiredText matching mode. The log shows the correct complete rejection message, but no later student Save/rollback assertions ran. Correct the assertion and rerun; this failed attempt is retained in runs/41807977272 and is not evidence of a passing student transaction.

Run41818150464/source8b28642 passed the corrected original student Save workflow, including all six fee/identity examples, same-title cross-grade/year classes, optional fields, kindergarten, exact payment/date/user values, late existing-code/NumberAsas rejection, both late student and payment SQL failures with full rollback, pending values/retry, a real SQL-lock UI heartbeat/close guard, repeat-import rejection and unrelated-record preservation. All18 business scenarios and5 report previews pass;39 Core/database,183 native and58 report checks pass. This supersedes the previous dialog timeout for these stated cases, not whole-application completion. The final native package receipt records startup/menu verification separately.

Static new-year audit: asdbz still writes selected students through independent synchronous sp_tYear_Student_Insert calls. Negative monthly amounts and nine-month Int32 overflow are not preflighted; a late SQL failure can leave earlier enrollments transferred. The latest recovered1402 procedure intentionally repeats monthly fee/transport across nine months, leaves omitted transport null, preserves selected flags and resets others through the candidate grid; source Sort is not an input. NEW-YEAR-CONTRACT.md records exact source hashes/fields and required native cases. No new-year transaction has been implemented or certified by this audit.

The installed local ZIP for source8b28642 is SHA256 f9c463419cbbe77c4b10998523b37eb8cbb03e606c10c07479895647b0a6a980,78,190,907bytes. Its four own .NET10 assemblies are x86 ReadyToRun, and startup/login pass. Menu evidence is68 loaded plus10 responsive interactions; the additional teacher-assignment interaction is the exact expected no-subjects fixture validation, not a populated assignment test. Its log is retained. This differs from the previous69/9 split and is not replaced by an invented fixed count.
