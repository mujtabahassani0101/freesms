# Catalog entries with missing original resources

Catalog entries1024 and1032 refer to classes/RPTs absent from the original EXE. See original-report-resource-audit.json. The former port composed them from several reports; the user rejected that presentation.

The current source removes those compositions. Both resource names now use the intact recovered `CR_AF_StdKarnameDorehByChart_term3` annual card. Apart from an explicit `recovered-alias` provenance attribute, the saved XML is byte-identical to that original. Formula checks also compare the complete saved XML trees. No invented identity, table, signature or chart bands remain in these aliases.

This is an explicit fallback to an available original report, not recovery of the absent1024/1032-specific designs. In particular,1032's absent single-mark chart layout has not been recovered; its catalog label still describes that missing design. Both entries currently display the original annual-card layout, with its original conditional visibility. SQL data preparation is unchanged.

`scripts/rebuild_missing_reports.py` reproduces these aliases and records source digests in rebuilt-reports.json. The98 recovered layouts are unchanged on disk. Runtime recovery of missing original line anchors, rotated text and area pagination is described in RECOVERED-REPORT-LAYOUTS.md.

The compatibility bridge maps the aliases' ranking visibility to their actual subreport contract:1024 supplies only Sub1, so the original optional best-student band stays hidden;1032 supplies Sub2/Sub3 as well, so that band is enabled. It does not reuse the absent templates' positional parameter5 as if it had the same meaning in the original annual card.

The older installed executable was also inspected read-only through .NET PE metadata, without launching or altering the other chat's files. SHA256 9e1dcf6bda5b78000451811843522f9215365af1d75d841fc3e13874293a2cd0 has92 RPT resource names; neither missing class/resource name is present. installed-report-resource-audit.json records that independent original source. The update executable still has99 RPT resource names and neither requested name (one resource is a duplicate report copy). Thus the older installer does not currently supply these missing layouts either. This narrows the search evidence, not the user's fidelity requirement or the whole-app scope; the aliases remain disclosed fallbacks.
