using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

internal sealed class OriginalComponentLicenses : LicenseContext
{
    private readonly Dictionary<string, string> keys = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    public override LicenseUsageMode UsageMode => LicenseUsageMode.Runtime;

    public static void Initialize()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "original-component-licenses.xml");
        if (!File.Exists(path)) throw new FileNotFoundException("منابع مجوز اجزای اصلی همراه برنامه نیست. ساخت کامل را با build-windows.cmd انجام دهید.", path);
        var context = new OriginalComponentLicenses();
        using (var reader = XmlReader.Create(path, new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null }))
            foreach (var item in XDocument.Load(reader).Root.Elements("license"))
                context.keys.Add((string)item.Attribute("type"), item.Value);
        LicenseManager.CurrentContext = context;
    }

    public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
    {
        return keys.TryGetValue(type.AssemblyQualifiedName, out var key) ? key : null;
    }
}
