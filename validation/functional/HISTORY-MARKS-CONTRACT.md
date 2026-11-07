# Recovered previous-grade marks contract

Static audit while native mark-export verification runs. No history-mark Save scenario is currently certified. Original controllers and SQL remain available; constructors/search parameterization do not certify persistence.

| Source | SHA256 |
|---|---|
| dotnet/FreeSms.Original.Windows/asdbh.cs | cb4f7e7e192b86f7b2c9292c39c3509ae7e847f57af04718eeb63a5c12b689ea |
| analysis/sql-resources/asdbv_txt981018.Text.sql | 67cecffc8ab753ddb04999a5958e60bf2855e683052e8613fb05ee96d866630a |

The form selects current-school-year students from the selected class and reads historic grade10 or11 using ab/aa. History is stored in tMarkAgo by student, historic grade, subject and typ; the original table has no year column. Do not invent year-specific history storage without migrating/reconciling every original consumer. Preserve current enrollment permissions and class/year membership when selecting a student to edit.

The subject editor deliberately queries the configured grade12 subjects with showOneEntry1, ordered by sort/id, then left-joins typ1 history for the selected student and historic grade10/11. This is the recovered contract, not evidence that subjects should be silently changed to the historic grade. The layout exposes SortOneEntry editing; its controller writes tBook.SortOneEntry as a separate operation.

Save loops each displayed subject, parses float text using current culture, checks displayed min/max (default0..100), deletes a subject entry when blank and otherwise calls sp_tMarkAgo_insertUpdate. The original procedure upserts on student+historic grade+subject and inserts typ1. Delete is scoped by student/grade/subject. These writes are synchronous with no transaction, and invalid rows can leave earlier rows saved. The shared connection can remain open on errors.

The total helper a() sums nonempty marks using Int32 parsing, while the subject Save loop accepts floats. Fractional input can therefore reach the bank but be omitted from the displayed integer sum or marked invalid after preceding writes. af holds this aggregate sum, not a generic arithmetic mean; keep the recovered aggregate contract explicit when repairing fractional behavior. ad is the manually editable class rank (gClass, SQL SmallInt). Missing/zero rank becomes0. Blank/zero aggregate deletes typ5 records for the student/grade; otherwise a typ5/xbook-5 row is inserted or updated with aggregate Mark and rank. No weighting/mean should be invented.

The success path hides/refills the editor and optionally prompts to show the next student. Cancel reloads committed data. Previous/Next and selection handlers index the selected student/first subject without complete empty-list guards. Save must capture a stable student identity and both subject rows and total/rank before asynchronous work; navigation/Close needs a busy guard. Rejected save must preserve pending values. A future atomic service must handle blank per-subject deletion and typ5 aggregate deletion in the same transaction, while leaving the other historic grade, current-year marks/calculations, peer students and subject catalog unchanged.

Required native cases: both grade10/11 routes; actual New/Edit/Save/Cancel/clear/reload; Persian fractions/zero/blank and numeric bounds; valid class-rank limits; aggregate exact sum and zero/blank typ5 deletion; source/current-grade permissions; stable year/class/student membership; empty subject/student lists; late SQL error rollback/retry and UI SQL-lock heartbeat/close guard; Previous/Next/student switching; real report consumers and backup/restore. Any necessary precision decision must be justified by original float schema plus report/aggregate behavior and tested explicitly. This document implements no history changes.
