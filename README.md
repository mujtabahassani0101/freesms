# Free SMS — ویندوز بومی با .NET 10

**وضعیت: در حال انتقال و تطبیق منطق برنامهٔ اصلی. این نسخه هنوز هم‌ارز کامل EXE اصلی نیست.**

برنامهٔ فعال با C# و Windows Forms برای `net10.0-windows` ساخته می‌شود. راه‌اندازی بانک اکنون کاملاً بومی ویندوز است: SQL Server Express LocalDB با احراز هویت ویندوز. Docker، WSL، Wine، Python و کلید سخت‌افزاری در اجرای نسخهٔ .NET لازم نیستند.

## اجرا

- روی Windows x64، SQL Server Express LocalDB نسخهٔ ۲۰۱۹ یا جدیدتر را نصب کنید. این یک مؤلفهٔ بومی ویندوز است؛ برای نصب می‌توان از بستهٔ رسمی `SqlLocalDB.msi` همراه رسانهٔ SQL Server Express یا Visual Studio Installer استفاده کرد.
- در بستهٔ آماده، تمام پوشه را استخراج و `FreeSMS.exe` را اجرا کنید؛ محیط .NET همراه خروجی مستقل قرار دارد.
- برای مشاهدهٔ رابط بدون بانک، `Preview.cmd` را اجرا کنید. پیش‌نمایش فقط‌خواندنی است.
- اولین اجرای کامل، نمونهٔ اختصاصی `FreeSMS` را در LocalDB ایجاد و کپی بانک اولیه را آماده می‌کند. فایل‌های اصلی نصب تغییر نمی‌کنند.

راهنمای رسمی: [SQL Server Express LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)، [ابزار SqlLocalDB](https://learn.microsoft.com/en-us/sql/tools/sqllocaldb-utility).

## ساخت از سورس

SDK دات‌نت ۱۰ برای Windows x64 را نصب و `setup.cmd` را اجرا کنید. فایل‌های `run.cmd`، `preview.cmd` و `build-windows.cmd` برای اجرای کامل، پیش‌نمایش و ساخت هستند.

پروژه در `dotnet/FreeSms.slnx` و خروجی در `dist/FreeSMS-Net10/FreeSMS.exe` است. دستور معادل از داخل پوشهٔ `dotnet`:

```bat
dotnet publish FreeSms.Windows/FreeSms.Windows.csproj -c Release -r win-x64 --self-contained true -p:PublishReadyToRun=true -o ../dist/FreeSMS-Net10
```

## اطلاعات بانک

- نمونهٔ اختصاصی: `(localdb)\FreeSMS`
- نام بانک: `free_sms`
- مسیر داده: `%LOCALAPPDATA%\free-sms\windows-db\free_sms`
- احراز هویت: حساب ویندوز؛ گذرواژهٔ SQL ساخته یا ذخیره نمی‌شود.

بانک توزیع‌شده فقط در اولین راه‌اندازی، به‌صورت اتمیک کپی می‌شود. بانک موجود یا فایل ناقص بازنویسی نمی‌شود. اجراهای هم‌زمان با قفل فایل راه‌اندازی هماهنگ می‌شوند. داده‌های نسخهٔ قبلیِ کانتینری خودکار منتقل نمی‌شوند و باید با پشتیبان/بازیابی مناسب انتقال داده شوند.

برای بانک SQL Server بومی موجود با طرح سازگار، می‌توان متغیر `FREE_SMS_CONNECTION_STRING` را صریحاً تنظیم کرد. در این حالت LocalDB راه‌اندازی نمی‌شود و به‌روزرسانی‌ها روی بانک انتخاب‌شده انجام می‌شوند.

## دامنهٔ فعلی و هدف نهایی

هدف، حفظ همهٔ منطق و قابلیت‌های برنامهٔ ویندوزی اصلی و حذف نیاز به کلید سخت‌افزاری است. هدف کامل نشده است. در نسخهٔ C# فعلی، مشخصات مکتب، ثبت و ویرایش و جستجوی متعلم و عکس، اطلاعات پایه، سال تعلیمی و تخصیص معلم وجود دارند؛ نمایش ۸۹ فرم به معنی تکمیل عملیات آن‌ها نیست. ماژول‌های نمرات، حاضری، مالی، کاربران، Excel، چاپ و گزارش‌ها هنوز باید کامل منتقل و با مرجع تطبیق داده شوند.

کدهای `analysis/decompiled` و منابع SQL از EXE و بانک بازیابی شده‌اند؛ آن‌ها سورس اصلیِ بی‌نقص و آمادهٔ کامپایل محسوب نمی‌شوند. پروژهٔ فعال جدید در `dotnet` قرار دارد. بررسی ساخت مستقیم نسخهٔ بازیابی‌شده و انتقال منطق بازنویسی‌شدهٔ چت دیگر ادامه دارد. اجرای برنامه در چت دیگر، به‌تنهایی صحت همهٔ عملیات و گزارش‌ها را ثابت نمی‌کند.

## ساختار

| مسیر | محتوا |
| --- | --- |
| `dotnet/FreeSms.Core/` | منطق C#، SQL، به‌روزرسانی بانک و راه‌اندازی بومی LocalDB |
| `dotnet/FreeSms.Windows/` | رابط Windows Forms و اتصالات فرم‌ها |
| `dotnet/FreeSms.Checks/` | بررسی‌های مستقل و آزمون واقعی بانک بومی |
| `analysis/decompiled/` | مرجع C# و RESX و گزارش‌های بازیابی‌شده |
| `analysis/sql-resources/` | ۴۴ اسکریپت اصلی به‌روزرسانی بانک |
| `analysis/database/` و `native/sql/` | تعریف‌های SQL بازیابی‌شده |
| `native/assets/` | چیدمان، تصویر و قلم فرم‌ها |
| `original/installed/db/` | بانک اولیه |
| `native/`، `tests/` و `*-python.cmd` | آرشیو نسخهٔ قبلی Python؛ مسیر اجرای برنامهٔ .NET نیستند |
| `.github/workflows/windows.yml` | آزمون روی ویندوز با LocalDB و رندر فرم‌ها |

## بررسی روی ویندوز

`check-windows.cmd` را اجرا کنید. این دستور بانک موقت و نمونهٔ جداگانه با پیشوند `FreeSmsCheck_` ایجاد و پس از آزمون حذف می‌کند. هیچ نمونه یا بانک دیگر پاک نمی‌شود.

از داخل `dotnet`:

```bat
dotnet run --project FreeSms.Checks/FreeSms.Checks.csproj -c Release -- --root ..
dotnet run --project FreeSms.Checks/FreeSms.Checks.csproj -c Release -- --root .. --integration
```

فرمان دوم به Windows و LocalDB نیاز دارد؛ هیچ کانتینری اجرا نمی‌کند. گزارش‌های آزمون قبلیِ کانتینری در `validation` تاریخی‌اند و مدرک آزمون مسیر جدید LocalDB نیستند. نتایج جاریِ ویندوز در GitHub Actions ذخیره می‌شوند.

خروجی مستقل از runtime نسخهٔ 10.0.14 استفاده می‌کند. بهبودهای فعلی شامل اجرای پس‌زمینهٔ بانک، اتصال‌های SQL قابل استفادهٔ مجدد، cache تعریف فرم و مشخصات رویه‌ها، جدول‌های VirtualMode، جستجوی با تأخیر کوتاه، cache قلم و تصویر و ساخت ReadyToRun است. اندازه‌گیری مقایسه‌ای سرعت انجام نشده است.
