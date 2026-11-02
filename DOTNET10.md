# Active .NET 10 build

`build-windows.cmd` publishes `FreeSms.Original.Windows` to `dist/FreeSMS-Net10` as a self-contained Windows x86 application. The recovered controllers and resources run with the source implementations in `FreeSms.NativeControls`, `FreeSms.Reports` and `FreeSms.Core`. `FreeSms.slnx` contains only these .NET 10 projects and their checks.

No .NET Framework UI process, Crystal report process, Janus DLL, dongle driver, Docker service or Python process is started by this build. Legacy projects remain as recovery references; `FreeSms.ReportHost` is an offline conversion tool used to produce the checked-in XML layouts, not an end-user dependency.

See `README.md` for build instructions and the remaining workflow-validation limits. Historical compatibility notes under `validation` describe earlier builds and do not define the default runtime.
