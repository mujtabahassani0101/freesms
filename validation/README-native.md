# Native Windows evidence

The active solution, application, controls and reporting engine target .NET 10. Earlier Python/container and Framework results in this directory are historical.

Windows Server 2025 run [41501113977](https://github.com/mujtabahassani0101/freesms/actions/runs/41501113977), source commit `51f5bc5`, passed:

- 18 LocalDB integration/service checks and 40 report expression, lookup, pivot-reference, formatting and XLSX checks.
- 138 native checks: control adapter contracts, 7 RPX layouts, all 98 migrated report templates with disconnected sample data, long-subreport pagination, print/image consistency at 300 DPI, chart visibility over background boxes, and package validation.
- Construction and bitmap rendering of the 89 recovered forms, database initialization, and the original login form.
- A self-contained x86 package with .NET 10 frameworks only. All four application assemblies have .NET 10 target attributes and x86 ReadyToRun headers; old UI/report runtime files are absent.

Selected synthetic previews, package metadata, startup evidence and check logs are committed here. Fixtures exercise rendering and adapter contracts. They do not prove every recovered controller workflow, data-dependent report layout or original Excel operation behaves identically to the original. Actual printer hardware and all manual workflows have not been verified.

The integration check creates a unique LocalDB instance under the current user's LocalAppData and deletes only that temporary instance. The application's own writable database is separate.

The checked-in source can rebuild the self-contained Windows application using `build-windows.cmd`.

The separate menu-loading probe passed 70 loaded/responsive routes and observed seven responsive modal interactions out of 77 actual menu handlers, with no failures or timeouts. See `navigation/README.md` and `navigation/summary.log` for scope and the unavailable-schema limits. This probe is now required by the Windows workflow.
