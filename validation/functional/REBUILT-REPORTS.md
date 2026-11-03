# Catalog entries with missing original resources

Catalog entries1024 and1032 refer to classes/RPTs absent from the original EXE. See original-report-resource-audit.json. The former port composed them from several reports; the user rejected that presentation.

The current source removes those compositions. Both resource names now use the intact recovered `CR_AF_StdKarnameDorehByChart_term3` annual card. Apart from an explicit `recovered-alias` provenance attribute, the saved XML is byte-identical to that original. Formula checks also compare the complete saved XML trees. No invented identity, table, signature or chart bands remain in these aliases.

This is an explicit fallback to an available original report, not recovery of the absent1024/1032-specific designs. In particular,1032's absent single-mark chart layout has not been recovered; its catalog label still describes that missing design. Both entries currently display the original annual-card layout, with its original conditional visibility. SQL data preparation is unchanged.

`scripts/rebuild_missing_reports.py` reproduces these aliases and records source digests in rebuilt-reports.json. The98 recovered layouts are unchanged on disk. Runtime recovery of missing original line anchors, rotated text and area pagination is described in RECOVERED-REPORT-LAYOUTS.md.
