# FreeSMS — سورس بازیابی‌شدهٔ برنامهٔ ویندوزی

این مخزن سورس C# بازیابی‌شده از خود `school_af.exe`، فرم‌ها، SQL و قالب‌های گزارش آن را دارد. هدف، حفظ رفتار برنامهٔ اصلی و حذف نیاز به کلید سخت‌افزاری است. کار فقط در پوشهٔ مستقل `free-sms` انجام شده است.

**محدودیت مهم .NET 10:** کنترل‌های قدیمی Janus و موتور Crystal مستقیماً با .NET 10 سازگار نیستند. مسیر پیش‌فرض سازگار، راه‌اندازی و آماده‌سازی بانک را با .NET 10 انجام می‌دهد و رابط و منطق بازیابی‌شدهٔ اصلی را روی .NET Framework 4.8 اجرا می‌کند. این نسخه کاملاً بومی ویندوز است. انتقال کل رابط به .NET 10 هنوز کامل نشده است.

Docker، WSL، Wine و Python در اجرای نسخهٔ ویندوز لازم نیستند. کنترل Tiny، فایل فعال‌سازی سخت‌افزار و محدودیت اعتبار کلید اجرا نمی‌شوند. ورود، گذرواژه و مجوزهای کاربران اصلی حفظ شده‌اند.

## اجرای نسخهٔ سازگار

1. Windows x64 و SQL Server Express LocalDB نسخهٔ ۲۰۱۹ یا جدیدتر لازم است. .NET Framework 4.8 نیز باید روی ویندوز فعال باشد. محیط .NET 10 همراه خروجی مستقل عرضه می‌شود.
2. بسته را کامل استخراج کنید. برای موتور گزارش، `Setup-Reports.cmd` را یک بار اجرا کنید؛ نصب‌کنندهٔ بومی Crystal Runtime x86 همراه بسته است.
3. `FreeSMS.exe` را اجرا کنید. پوشهٔ `legacy-ui` باید کنار آن باشد؛ فایل EXE به‌تنهایی کافی نیست.

در سورس، پس از ساخت، `run.cmd` برنامه و `preview.cmd` پیش‌نمایش تصویری فرم اصلی را بدون اتصال به بانک باز می‌کند. نسخهٔ آماده در `dist/FreeSMS-Native-Compatible` قرار می‌گیرد.

برای Excel، مؤلفه‌های Office/Access سازگار با نوع فایل ممکن است لازم باشند؛ همان وابستگی واردکردن و صادرکردن فایل‌های برنامهٔ اصلی باقی است.

راهنمای رسمی بانک بومی: [LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) و [ابزار SqlLocalDB](https://learn.microsoft.com/en-us/sql/tools/sqllocaldb-utility). توضیح سازگاری Crystal با خانوادهٔ .NET Framework در [FAQ سازنده](https://pages.community.sap.com/topics/crystal-reports/faq) آمده است.

## ساخت از سورس

SDK دات‌نت ۱۰ برای Windows x64 را نصب و `setup.cmd` یا `build-windows.cmd` را اجرا کنید. بسته‌های مرجع Framework از NuGet دریافت می‌شوند؛ ساخت به Visual Studio کامل نیاز ندارد.

دستور معادل از ریشهٔ سورس:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -File scripts/build-native-compatible-windows.ps1
```

خروجی، `dist/FreeSMS-Native-Compatible/FreeSMS.exe` به‌همراه تمام پوشه‌های وابسته است.

## بانک و حفاظت از داده

- نمونهٔ بومی اختصاصی: `(localdb)\FreeSMS`
- بانک نسخهٔ اصلی: `school_af_kbr`
- مسیر داده: `%LOCALAPPDATA%\free-sms\windows-db\school_af_kbr`
- احراز هویت SQL با حساب ویندوز انجام می‌شود؛ گذرواژهٔ SQL ساخته نمی‌شود.

بانک اولیه فقط یک بار و به‌صورت اتمیک کپی می‌شود. بانک موجود و فایل ناقص بازنویسی نمی‌شوند. فایل‌های نصب اصلی تغییر نمی‌کنند. برای SQL Server بومی موجود با طرح سازگار، متغیر `FREE_SMS_CONNECTION_STRING` قابل تنظیم است؛ به‌روزرسانی‌ها روی همان بانک انتخاب‌شده انجام می‌شوند.

## وضعیت بررسی

- ساخت کامل سورس بازیابی‌شده برای هر دو هدف .NET 10 و .NET Framework 4.8 موفق است.
- مسیر LocalDB بومی روی Windows Server 2025، ۱۸ آزمون ثبت، ویرایش، حذف، تراکنش و به‌روزرسانی بانک را گذرانده است.
- نسخهٔ Framework، آزمون ساخت و رندر فرم‌های اصلی را روی ویندوز گذرانده است.
- ۹۸ کلاس گزارش اصلی، قالب‌های خود را در موتور Crystal بومی با موفقیت بارگذاری کرده‌اند.
- بازشدن فرم و بارگذاری قالب، به‌تنهایی برابری همهٔ محاسبات، چاپ روی چاپگر واقعی، Excel و تمام جریان‌های کاری را ثابت نمی‌کند. تطبیق دستی همهٔ عملیات هنوز انجام نشده است.

نتایج و شواهد هر اجرا در [آزمون ویندوز مخزن](https://github.com/mujtabahassani0101/freesms/actions/workflows/windows.yml) و توضیحات `validation/README-native.md` هستند. `check-windows.cmd` بانک موقت و نمونهٔ اختصاصی با پیشوند `FreeSmsCheck_` می‌سازد و فقط همان نمونه را حذف می‌کند.

## ساختار سورس

| مسیر | محتوا |
| --- | --- |
| `dotnet/FreeSms.Original.Windows` | همهٔ واحدهای C# و منابع بازیابی‌شده؛ تلاش برای انتقال مستقیم به .NET 10 |
| `dotnet/FreeSms.Original.Framework` | ساخت سازگار همان سورس و منابع با هدف Framework 4.8 |
| `dotnet/FreeSms.NativeLauncher` | راه‌انداز بومی .NET 10 و اتصال آن به برنامهٔ اصلی |
| `dotnet/FreeSms.Core` | LocalDB، به‌روزرسانی بانک و خدمات SQL |
| `dotnet/FreeSms.ReportHost` | اجرای مستقل قالب‌های اصلی Crystal برای مسیر آزمایشی .NET 10 |
| `dotnet/FreeSms.Checks` | آزمون‌های بانک و منطق خدمات C# |
| `vendor/legacy`، `vendor/fonts`، `vendor/runtime` | اجزا، قلم‌ها و نصب‌کنندهٔ گزارش همراه برنامهٔ اصلی |
| `analysis/sql-resources` | ۴۴ اسکریپت اصلی به‌روزرسانی بانک |
| `original/installed/db` | بانک اولیهٔ توزیع‌شده |
| `dotnet/FreeSms.Windows`، `native` و `*-python.cmd` | نمونه‌ها و بازنویسی‌های قبلی؛ مسیر اجرای نسخهٔ اصلی نیستند |

`build-net10-experimental.cmd` تلاش انتقال مستقیم به .NET 10 را می‌سازد. **آن خروجی آمادهٔ استفاده نیست:** آزمون ویندوز وابستگی‌های حذف‌شدهٔ منو، مجوز و serialization را در کنترل‌های قدیمی نشان داده است. ساخت موفق آن، به معنی اجرای موفق نیست. برای حفظ رفتار اصلی، مسیر سازگار بالا استفاده می‌شود.

جزئیات بازیابی و تغییرات در `dotnet/FreeSms.Original.Windows/RECOVERY.md` است. نسخهٔ منبع EXE: ۱۴۰۲/۱۱/۱۹؛ SHA-256 آن:

```text
f380191dc4a7c6fbf7dbc0f95c21e915e9b50bf8a8bd44eac6e8943bc715fe28
```
