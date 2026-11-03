using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;

namespace FreeSms.NativeControls
{
    public static class ReportFonts
    {
        // GDI registration alone does not make private fonts available to GDI+.
        // Keep this collection alive for the lifetime of every report document.
        private static readonly PrivateFontCollection Fonts = new PrivateFontCollection();
        private static readonly HashSet<string> Loaded = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private static readonly Dictionary<string, FontFamily> Families = new Dictionary<string, FontFamily>(StringComparer.OrdinalIgnoreCase);
        private static readonly object Gate = new object();

        public static void Initialize(string directory)
        {
            if (!Directory.Exists(directory)) return;
            lock (Gate)
            {
                foreach (string path in Directory.GetFiles(directory, "*"))
                    if (Path.GetExtension(path).Equals(".ttf", StringComparison.OrdinalIgnoreCase) && Loaded.Add(Path.GetFullPath(path)))
                        Fonts.AddFontFile(path);
                foreach(var family in Fonts.Families)
                {
                    if(!Families.TryAdd(family.Name,family))family.Dispose();
                }
            }
        }

        public static Font Create(string family, float size, FontStyle style)
        {
            lock (Gate)
            {
                if(!Families.TryGetValue(family,out var match))return new Font(family,size,style,GraphicsUnit.Pixel);
                var face=style & (FontStyle.Bold | FontStyle.Italic);
                if(!match.IsStyleAvailable(face))
                {
                    face=match.IsStyleAvailable(FontStyle.Regular)?FontStyle.Regular:FontStyle.Bold;
                    style=face | (style & (FontStyle.Underline | FontStyle.Strikeout));
                }
                return new Font(match,size,style,GraphicsUnit.Pixel);
            }
        }
    }
}
