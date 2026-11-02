# Unimplemented disciplinary workflows

The Afghan seed/migrations do not provide the discipline tables/procedures expected by the recovered controllers. Current menu guards prevent a load exception but do not implement these workflows. The application-wide goal remains open.

The static contract inventory in disciplinary-contracts.json records controller/layout hashes, fields, SQL procedure parameters and existing report schemas. It is evidence of the interfaces, not evidence that a working database or feature exists.

Required workflows include case definitions for discipline/rewards/academic warnings; per-student dated records with optional subject; daily excused absence/unexcused absence/unexcused lateness; and the four existing discipline report layouts. Daily IDs1/2/3 and their checkbox captions are explicit in asdbu's query/layout. Case editing uses a shared procedure with typ1/2/3 and insert/update commands; Code0 means duplicate. Student-record and daily procedures have separate parameter contracts.

Adding tables alone is insufficient. asdn/asdbu still query grade/class/order directly from tStudent, which belongs to the other database edition. The Afghan model stores those values in tYear_Student. Their list/class/grade queries need year-scoped joins and existing grade permissions. Do not create a second unsynchronized enrolment model on tStudent merely to make those queries compile.

The report selector needs tRptDis entries, four procedure result contracts, CSV filter handling, date ranges and linked subreport data. The original catalog rows are absent; existing template schemas and controller factories establish the four report variants, but the recovered filter modes and catalog settings must be verified explicitly. No arbitrary catalog aliases or empty datasets can stand in for those reports.

Implementation/verification still required:

- An additive, idempotent native schema migration with clear provenance; never claim newly implemented SQL was recovered original code. Preserve existing banks and restore/upgrade compatibility.
- Case CRUD, duplicate titles, reserved daily IDs, reference protection and role checks.
- Year-scoped student selection and daily/individual record save/edit/delete, including quoted text, dates, subject linkage, repeated same-day edits and rejected input.
- All four populated original-button previews, correct main/subreport fields, date/case/class filtering, every page and actual exports.
- Database rollback/restart/reopen, backup/restore of new data and absence of changes to unrelated students/years. External notifications must remain behind the existing test transport.

This document does not narrow the scope in PLAN.md. No discipline workflow is marked complete.
