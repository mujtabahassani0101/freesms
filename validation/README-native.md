# Native Windows evidence

Run `41448794495`, commit `ab4fa8e`, verified the native LocalDB path on Windows Server 2025: **18 checks passed**, and the separate reconstructed interface rendered successfully. The original application's Janus controls failed at this stage; the license context compatibility fix was introduced afterward. These results do not prove parity of the original application's 89 forms or its reports.

The per-user data directory is intentional: SQL Server database files must reside on a writable Windows volume supported by the engine. The integration check creates a unique LocalDB instance under the current user's LocalAppData and deletes only that temporary instance.

Current results are available in the repository's Native Windows verification workflow. Older Python/container checks in this directory are historical and do not verify the current native application.
