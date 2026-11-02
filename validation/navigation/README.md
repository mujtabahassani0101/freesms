# Native menu loading diagnosis

Run 41501113977, application source `51f5bc5`, invokes the actual recovered main-menu click handlers with an isolated native LocalDB clone, preserving each handler's parameters. Each worker has a ten-second limit. The UI timer confirms responsiveness; native messages and modal pickers are recorded separately.

The current `summary.log` records 77 routes: 70 loaded and responsive; 7 awaiting modal interaction; no failures or timeouts. Five compatibility messages correspond to disciplinary schemas absent from the supplied seed; two other routes open their original registration dialogs. A compatibility message does not mean that the unavailable feature was implemented or verified.

Per-route logs are named after the menu variable (for example `m_bg.log`). Earlier class-name logs are retained historical evidence from the first, less precise constructor/load probe. The second probe reproduced 21 failing routes before the fixes: premature DataRowView IDs, year initialization order, and unavailable database schemas.

The fixes defer selection notifications until ValueMember is ready, coalesce transient rebind events, initialize the year before loading dependent lists, check schema prerequisites before opening incompatible modules, and reject report headers/footers that would leave no space for pagination.

These checks cover opening the menu destinations, not every inner button, save, import, report-data combination, or real printer. No user's live database is used by the probe.
