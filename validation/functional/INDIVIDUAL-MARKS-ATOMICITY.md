# Individual marks: atomic and responsive Save

The recovered frmMarkEntry2 Save wrote/deleted one subject at a time on the UI thread, invalidated exam processing before validating the grid, and could leave earlier subjects committed on a later error. Its cell-updated integer parser also rewrote M1 even when another component was being edited. The authored visible M1 column has InputMask Number0 and remains restricted to integers; fractional hidden components retain their original float semantics.

The new path validates a captured batch before writing, preserves component values and the recovered averaging/annual M2 convention, and executes the original sp_tMark_insertUpdate inside one transaction with deletions and processing invalidation. The selected enrolment, grade, class, exam year and subjects are checked inside that transaction. SQL runs off the UI thread; pending edits survive a failure, and close/double-save is prevented until completion.

Added original-button scenarios cover an out-of-range mark preserving data/processing state, fractional-input rejection without silent rounding, a second-subject SQL trigger failure rolling back the first subject, successful retry without discarding edits, a real exam-row lock released by a UI timer, and clearing one subject while preserving peer/other-exam marks. These scenarios require the Windows workflow; local compilation and pure Core checks alone do not establish a Windows pass.

The application-wide goal remains open. Bulk marks, imports, other annual/manual paths, discipline and the other unverified workflows in PLAN.md still require investigation.

Windows run41608908198 (5e06cfe) passed the complete expanded individual-mark scenario, including the late second-subject trigger rollback, real SQL lock/UI heartbeat, integer/fractional-input rejection, clearing and actual annual100-point M2 storage/reopen/Cancel assertions. All13 current business scenarios and5 original report cases passed. This is bounded evidence, not completion of PLAN.md.
