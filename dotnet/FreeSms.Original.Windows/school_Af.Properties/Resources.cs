using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace school_Af.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ResourceManager result = default;
			while (true)
			{
				bool flag = !object.ReferenceEquals(resourceMan, null);
				if (true)
				{
				}
				int num = 3;
				while (true)
				{
					switch (num)
					{
					case 3:
						if (!flag)
						{
							num = 1;
							continue;
						}
						goto case 0;
					case 0:
						result = resourceMan;
						num = 2;
						continue;
					case 1:
					{
						ResourceManager resourceManager = new ResourceManager("school_Af.Properties.Resources", typeof(Resources).Assembly);
						resourceMan = resourceManager;
						num = 0;
						continue;
					}
					case 2:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap _0188
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("0188", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap _4160
	{
		get
		{
			object obj = ResourceManager.GetObject("4160", resourceCulture);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap _new
	{
		get
		{
			object obj = ResourceManager.GetObject("new", resourceCulture);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap copy
	{
		get
		{
			object obj = ResourceManager.GetObject("copy", resourceCulture);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap down
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("down", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap end
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("end", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap error
	{
		get
		{
			object obj = ResourceManager.GetObject("error", resourceCulture);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap free
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("free", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap rptview
	{
		get
		{
			object obj = ResourceManager.GetObject("rptview", resourceCulture);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}
}
