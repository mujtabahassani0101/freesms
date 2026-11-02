using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace school_Af;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class menu
{
	private static ResourceManager a;

	private static CultureInfo b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			ResourceManager result = default;
			while (true)
			{
				bool flag = !object.ReferenceEquals(a, null);
				if (true)
				{
				}
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 0:
						if (!flag)
						{
							num = 2;
							continue;
						}
						goto case 3;
					case 3:
						result = a;
						num = 1;
						continue;
					case 2:
					{
						ResourceManager resourceManager = new ResourceManager("school_Af.menu", typeof(menu).Assembly);
						a = resourceManager;
						num = 3;
						continue;
					}
					case 1:
						return result;
					}
					break;
				}
			}
		}
	}

	internal static Bitmap base1
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("base1", b);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap card
	{
		get
		{
			object obj = ResourceManager.GetObject("card", b);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap exit
	{
		get
		{
			object obj = ResourceManager.GetObject("exit", b);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap finance
	{
		get
		{
			object obj = ResourceManager.GetObject("finance", b);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap mark
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("mark", b);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Possibilities
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("Possibilities", b);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap select3
	{
		get
		{
			object obj = ResourceManager.GetObject("select3", b);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}

	internal static Bitmap student
	{
		get
		{
			if (true)
			{
			}
			object obj = ResourceManager.GetObject("student", b);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap telegram
	{
		get
		{
			object obj = ResourceManager.GetObject("telegram", b);
			Bitmap result = (Bitmap)obj;
			if (true)
			{
			}
			return result;
		}
	}
}
