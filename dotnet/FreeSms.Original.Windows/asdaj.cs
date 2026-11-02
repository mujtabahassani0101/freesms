internal class asdaj
{
	public static string __field_a;

	public static string __field_b;

	public static string c;

	public static string d;

	public static string e;

	public static int f;

	public static int g;

	public static bool h;

	public static bool i;

	public static string j;

	public static string k;

	public static string l;

	public static string m;

	public static string n;

	public static string b(string A_0)
	{
		if (true)
		{
		}
		string text = A_0.Trim();
		text = text.Replace('ى', 'ي');
		text = text.Replace('ی', 'ي');
		text = text.Replace('ک', 'ك');
		text = text.Replace("'", "");
		text = text.Replace(";", "");
		text = text.Replace(",", "");
		text = text.Replace("|", "");
		return text.Replace("\"", "");
	}

	public static bool a(string A_0)
	{
		bool result = default;
		while (true)
		{
			bool flag = false;
			bool flag2 = !(l == "1");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag2)
					{
						num = 3;
						continue;
					}
					flag2 = m.IndexOf("," + A_0 + ",") < 0;
					num = 5;
					continue;
				case 4:
					if (true)
					{
					}
					num = 2;
					continue;
				case 1:
					flag = true;
					num = 4;
					continue;
				case 3:
					flag = true;
					num = 7;
					continue;
				case 2:
				case 7:
					result = flag;
					num = 0;
					continue;
				case 5:
					if (!flag2)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 0:
					return result;
				}
				break;
			}
		}
	}

	static asdaj()
	{
		if (true)
		{
		}
		asdaj.__field_a = "1398";
		asdaj.__field_b = "";
		c = "";
		d = "";
		e = "";
		f = 0;
		g = 0;
		h = false;
		i = false;
		j = "";
		k = "";
	}
}
