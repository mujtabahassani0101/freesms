# Individual marks: atomic and responsive Save

The recovered frmMarkEntry2 Save wrote/deleted one subject at a time on the UI thread, invalidated exam processing before validating the grid, and could leave earlier subjects committed on a later error. Its cell-updated integer parser also replaced fractional marks with DBNull without warning.

The new path validates a captured batch before writing, preserves fractional values and the recovered averaging/annual M2 convention, and executes the original sp_tMark_insertUpdate inside one transaction with deletions and processing invalidation. The selected enrolment, grade, class, exam year and subjects are checked inside that transaction. SQL runs off the UI thread; pending edits survive a failure, and close/double-save is prevented until completion.

Added original-button scenarios cover an out-of-range mark preserving data/processing state, fractional editing, a second-subject SQL trigger failure rolling back the first subject, successful retry without discarding edits, a real exam-row lock released by a UI timer, and clearing one subject while preserving peer/other-exam marks. These scenarios require the Windows workflow; local compilation and pure Core checks alone do not establish a Windows pass.

The application-wide goal remains open. Bulk marks, imports, annual/manual entry through the actual UI, discipline and the other unverified workflows in PLAN.md still require investigation.
