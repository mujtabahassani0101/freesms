# Backup and restore verification

The native maintenance service uses the configured SQL catalog, quotes identifiers, and binds backup paths as SQL parameters. It retains existing backup sets in a selected file; restore chooses the latest complete full set, avoiding stale set1 restores. Manual backup dialogs now default to a unique writable per-user path. Automatic pre-operation backups use that location too.

Restore is restricted to the machine hosting the SQL instance. Before altering the current bank, it verifies the backup, restores it into uniquely named temporary files, checks the application schema and tests its migrations in that staged copy. It maps logical files to the current bank's physical files, rather than trusting paths from another computer's backup. The supported layouts use matching data/log file counts; FILESTREAM and unmatched layouts are rejected before replacing the bank.

A pre-restore backup is retained beside the current data files. The service then obtains single-user access for replacement, returns to multi-user mode and clears stale connection pools. If replacement fails, it attempts recovery from the retained copy and reports recovery/access failures together, including the safety-copy path. Normal application startup applies migrations after restoring an older compatible snapshot.

The main backup and restore buttons run SQL/file work outside the UI thread. Existing account checks still restrict restore to the application admin. Successful restore exits the application so the restored accounts/settings are used on the next login. The legacy server flag is populated with its original meaning (`1` means a remote client).

Windows tests to execute:

- Backup to a Persian path containing an apostrophe against a uniquely named disposable catalog; append a second set and restore its exact Persian text, decimal amount and binary payload.
- Reject malformed media without modifying current records.
- Remove input after staged validation to force replacement failure; require recovery of the pre-restore value and normal database access.
- Reject a valid SQL backup of an unrelated schema before modifying current records.
- Use the original backup form's asynchronous buttons: empty-path validation, actual restorable backup, denied non-admin restore, and successful admin restore of the saved record.

These scenarios are not yet verified on Windows. They do not cover every SQL Server edition, concurrent independent clients or physical disk failure.

The SQL choices follow Microsoft's [copy-only backup documentation](https://learn.microsoft.com/en-us/sql/relational-databases/backup-restore/copy-only-backups-sql-server) and [RESTORE arguments documentation](https://learn.microsoft.com/en-us/sql/t-sql/statements/restore-statements-arguments-transact-sql). Staged restore is used because VERIFYONLY alone does not establish a complete working database.
