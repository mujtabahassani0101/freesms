# Original report layout fidelity

The user requested the actual Windows templates, rather than newly designed cards. The `FirstTermCardLayouts` reflow is removed. The98 recovered XML files retain their original section order, positions, sizes, fonts, formulas and data links.

The original analysis from the other chat is read-only input. `scripts/recover_report_geometry.py` reads its Crystal RAS/Engine JSON exports and stores only previously omitted properties in RecoveredGeometry.xml. Per-input SHA256 values are in recovered-geometry-sources.json. Runtime code has no Crystal/Wine dependency.

Recovered properties include line/box end-section names, endpoint coordinates, text rotation and area-level page breaks. Formerly the renderer enlarged a table header to a line's design-time height, ignored its true footer anchor and omitted area page breaks. It now keeps shape height out of band measurement, draws anchored columns through their actual rows, preserves90/270-degree labels and applies page boundaries from the original area definition. Suppressed objects no longer inflate band measurements.

Synthetic native regressions exercise a three-row table with a deliberately enormous design-time column height; its header must remain compact and its column must terminate at the footer. Original-button cases assert two one-course student cards on separate pages, correct orientation, independent identities and distinct stored photo pixels. All pages are saved before any layout assertion rejects a result.

Local source/build and57 formula checks passed. Windows rendering, original-button output and visual comparison remain pending until the new CI artifacts are inspected. Do not describe this as full report or application parity.

An analysis-only helper independently loaded the original annual RPT through the bundled Crystal engine, supplied two synthetic students with12 subjects each, and exported a two-page reference. It ran in a separate copied analysis prefix under this checkout; the other chat's source and environment were not changed. This reference is for layout inspection, not an application runtime dependency.
