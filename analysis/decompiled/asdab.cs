using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using BijanComponents;

public class asdab
{
	public static string a;

	public static string b;

	public static string c;

	public static string d;

	public static int e;

	public static int f;

	public static int g;

	public static string h;

	public static string i;

	public static string j;

	public static string k;

	public static string l;

	public static string m;

	public static string n;

	public static string o;

	public static int p;

	public static string q;

	public static string r;

	[SpecialName]
	public static string e()
	{
		string result = default;
		while (true)
		{
			bool flag = !(r == "1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					num = (flag ? 1 : 0);
					continue;
				case 1:
					try
					{
						string path = Application.StartupPath + "\\ConnectionString.txt";
						StreamReader streamReader = new StreamReader(path);
						result = streamReader.ReadToEnd() + "database=" + asdab.d;
					}
					catch
					{
						result = ((!(asdab.d != "")) ? "" : ("server=(local)\\kbr63;database=" + asdab.d + ";uid=sa;pwd=123456789"));
					}
					goto case 2;
				case 0:
					result = asdab.a;
					num = 2;
					continue;
				case 2:
					return result;
				}
				break;
			}
		}
	}

	public static string d(string A_0)
	{
		if (true)
		{
		}
		byte[] bytes = Encoding.UTF8.GetBytes(A_0);
		A_0 = Convert.ToBase64String(bytes);
		bytes = Encoding.UTF7.GetBytes(A_0);
		A_0 = Convert.ToBase64String(bytes);
		bytes = Encoding.Unicode.GetBytes(A_0);
		A_0 = Convert.ToBase64String(bytes);
		bytes = Encoding.ASCII.GetBytes(A_0);
		return Convert.ToBase64String(bytes);
	}

	public static string c(string A_0)
	{
		byte[] bytes = Convert.FromBase64String(A_0);
		A_0 = Encoding.ASCII.GetString(bytes);
		bytes = Convert.FromBase64String(A_0);
		A_0 = Encoding.Unicode.GetString(bytes);
		bytes = Convert.FromBase64String(A_0);
		A_0 = Encoding.UTF7.GetString(bytes);
		bytes = Convert.FromBase64String(A_0);
		string result = Encoding.UTF8.GetString(bytes);
		if (true)
		{
		}
		return result;
	}

	public static byte[] b(string A_0)
	{
		byte[] result;
		try
		{
			FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			result = binaryReader.ReadBytes(int.Parse(fileStream.Length.ToString()));
		}
		catch
		{
			result = null;
		}
		if (true)
		{
		}
		return result;
	}

	public static Image a(byte[] A_0)
	{
		Image result;
		try
		{
			MemoryStream memoryStream = new MemoryStream(A_0);
			result = Image.FromStream((Stream)memoryStream);
		}
		catch
		{
			result = null;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public static string d()
	{
		return DateTime.Now.ToShortTimeString();
	}

	[SpecialName]
	public static string c()
	{
		string result = default;
		while (true)
		{
			string text = DateTime.Now.Minute.ToString();
			bool flag = text.Length != 1;
			if (true)
			{
			}
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
				case 3:
					result = DateTime.Now.Hour + ":" + text;
					num = 1;
					continue;
				case 0:
					text = "0" + text;
					num = 3;
					continue;
				case 1:
					return result;
				}
				break;
			}
		}
	}

	[SpecialName]
	public static string b()
	{
		return ShamsiDate.GetShamsiDate(DateTime.Now);
	}

	[SpecialName]
	public static string a()
	{
		return "VFFCc0FHd0FUUUJYQUcwQVpBQnJBR0lBVlFCV0FFb0FWQUJ0QUd3QU5nQk5BR3NBY3dBekFGY0FXQUJHQUhBQVVnQkdBR3dBZHdCUEFGY0FNUUJEQUUwQWF3QjRBRTBBVndCWUFFRUFOUUJoQUZnQVp3QjVBRTRBU0FCa0FHNEFUUUJzQUd3QVdRQlhBRmdBUmdBd0FHRUFWQUJGQUhrQVZ3QldBRVlBYmdCTkFHd0FiQUJwQUZrQWJRQndBRThBWVFCWUFHOEFlUUJUQURJQU9BQnlBRkVBVlFCUkFIY0FUQUJSQUQwQVBRQT0=";
	}

	public static string a(string A_0)
	{
		string result = default;
		while (true)
		{
			string text = "";
			bool flag = !(A_0 == "1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(A_0 == "6");
					num = 7;
					continue;
				case 4:
					text = "VFFCckFIUUFiUUJYQUZnQVRnQnJBR0VBV0FCRkFIa0FVd0F5QUhBQVdnQmpBRVFBYkFCd0FFMEFNQUJzQUU4QVlRQlhBRGdBZVFCVEFESUFUZ0J1QUUwQWF3QjRBRkVBVndCWUFFNEFhd0JpQUZVQWF3QjVBRlFBUlFCV0FHNEFUUUJyQUhRQWNRQlhBRmdBVGdCckFHSUFWUUJOQUhrQVZBQkZBR2dBV2dCakFFUUFiQUJ3QUdVQVJRQnNBRThBWWdCVkFHTUFlUUJVQUVZQVVnQmFBR01BYmdCakFISUFVUUJWQUZFQWR3QlJBRllBUWdCU0FFd0FVUUE5QUQwQQ==";
					num = 6;
					continue;
				case 5:
					text = "VFFCc0FHd0FUUUJYQUcwQVpBQnJBR0lBVlFCV0FFb0FVUUF3QUZJQVlRQmtBRzRBVWdBeEFGUUFWQUJLQUV3QVRBQXhBR3dBZHdCbEFGVUFVZ0JoQUdFQVNBQlNBSEFBVFFCRUFFb0FUQUJQQUVNQWRBQkNBRklBUkFCQkFIUUE=";
					num = 1;
					continue;
				case 1:
					if (1 == 0)
					{
					}
					goto case 0;
				case 0:
				case 6:
					result = text;
					num = 2;
					continue;
				case 7:
					if (flag)
					{
						text = A_0;
						num = 0;
					}
					else
					{
						num = 4;
					}
					continue;
				case 2:
					return result;
				}
				break;
			}
		}
	}

	static asdab()
	{
		if (true)
		{
		}
		asdab.b = "";
		asdab.c = "";
		asdab.e = 26;
		f = 67;
		g = -2;
		h = "_emp";
		i = "";
		j = "";
		k = "";
		l = "";
	}
}
