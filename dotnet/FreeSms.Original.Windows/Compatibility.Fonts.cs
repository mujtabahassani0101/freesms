using System;
using System.IO;
using System.Runtime.InteropServices;

internal static class OriginalFonts
{
    [DllImport("gdi32.dll", CharSet = CharSet.Unicode, EntryPoint = "AddFontResourceExW")]
    private static extern int AddFontResourceEx(string file, uint flags, IntPtr reserved);

    public static void Initialize()
    {
        var directory = Path.Combine(AppContext.BaseDirectory, "fonts");
        if (!Directory.Exists(directory)) return;
        foreach (var path in Directory.GetFiles(directory, "*.ttf"))
            AddFontResourceEx(path, 0x10, IntPtr.Zero);
    }
}
