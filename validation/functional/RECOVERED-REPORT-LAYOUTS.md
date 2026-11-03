# Original report layout fidelity

The user requested the actual Windows templates, rather than newly designed cards. The `FirstTermCardLayouts` reflow is removed. The98 recovered XML files retain their original section order, positions, sizes, fonts, formulas and data links.

The original analysis from the other chat is read-only input. `scripts/recover_report_geometry.py` reads its Crystal RAS/Engine JSON exports and stores only previously omitted properties in RecoveredGeometry.xml. Per-input SHA256 values are in recovered-geometry-sources.json. Runtime code has no Crystal/Wine dependency.

Recovered properties include line/box end-section names, endpoint coordinates, text rotation and area-level page breaks. Formerly the renderer enlarged a table header to a line's design-time height, ignored its true footer anchor and omitted area page breaks. It now keeps shape height out of band measurement, draws anchored columns through their actual rows, preserves90/270-degree labels and applies page boundaries from the original area definition. Suppressed objects no longer inflate band measurements.

Synthetic native regressions exercise a three-row table with a deliberately enormous design-time column height; its header must remain compact and its column must terminate at the footer. Original-button cases assert two one-course student cards on separate pages, correct orientation, independent identities and distinct stored photo pixels. All pages are saved before any layout assertion rejects a result.

Local source/build and57 formula checks passed. Windows rendering, original-button output and visual comparison remain pending until the new CI artifacts are inspected. Do not describe this as full report or application parity.

An analysis-only helper independently loaded the original annual RPT through the bundled Crystal engine, supplied two synthetic students with12 subjects each, and exported a two-page reference. It ran in a separate copied analysis prefix under this checkout; the other chat's source and environment were not changed. This reference is for layout inspection, not an application runtime dependency.

## Follow-up rendering corrections

Windows run41592972051 (ff8af82) passed the native component step and the separate Core/formula job, but its original-preview step failed. The detailed archive could not be retrieved during a GitHub connectivity outage; do not assign a specific failed scenario without that evidence.

Source review independently identified two further faults. ObjectTop previously shifted objects in the left column when a right-column subreport grew; growth now affects only horizontally overlapping objects, with a native pixel regression. The two absent-resource aliases also inherited positional parameter5 from the missing templates; the intact annual card uses that slot for showBartar. Their bridge now enables the original ranking band only when both configured ranking datasets are available. This avoids requiring absent Sub2/Sub3 data for1024 while retaining them for1032.

The next native artifact includes both twelve-subject card pages and the table-anchor regression image. The latest follow-up builds successfully locally; Windows verification is still required.

## Windows evidence from8f091eb

Run41595245271 passed all5 original-button previews (101,104,105,1024,1032), their stored-data/photo assertions and separate-card page checks. Its178 native checks passed, including the twelve-subject two-student layout and independent-column pixel regression. The full run failed in the async restore fixture: its45-second dialog wait expired while SQL still held the backup file; the cleanup exception masked that earlier wait failure and the remaining shared-catalog scenarios failed. The restore fixture now has a300-second dialog allowance and360-second worker budget, consistent with the service's300-second SQL command timeout. Cleanup errors preserve the primary diagnostic instead of masking it. The production restore implementation is unchanged.

Visual inspection still found clipped Persian labels. The original RAS usesB Badr/B Nazanin fonts, while the earlier Engine API export substitutedMicrosoft Sans Serif on the analysis machine. Uniform authored RAS font definitions are now recovered too. GDI+ loads the bundled TTFs through a long-lived private font collection rather than relying only on GDI registration. These latest font and diagnostic changes require a fresh Windows run.

The original templates also requestXB Titre, which the old installer did not bundle. The unmodified regular font is now packaged from its [Font Library distribution](https://fontlibrary.org/en/font/xb-titre), with its embeddedGNU GPL notice, full GPL text and source/SHA256 metadata. Its MD5 matches the publisher's asset identifier7d457676d948f716783d269642c6f409. Native checks requireB Badr,B Nazanin andXB Titre to retain their real family names rather than silently substituting a system face. Private font loading follows the [Microsoft GDI+ private font collection API](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-a-private-font-collection).
