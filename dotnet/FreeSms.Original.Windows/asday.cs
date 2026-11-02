using System;
using System.ComponentModel;
using System.Globalization;

public class asday : TypeConverter
{
	public virtual bool a(ITypeDescriptorContext A_0, Type A_1)
	{
		bool result = default;
		while (true)
		{
			bool flag = A_1 != typeof(string);
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
						num = 0;
						continue;
					}
					result = base.CanConvertFrom(A_0, A_1);
					num = 2;
					continue;
				case 0:
					result = true;
					num = 1;
					continue;
				case 1:
				case 2:
					return result;
				}
				break;
			}
		}
	}

	public virtual bool b(ITypeDescriptorContext A_0, Type A_1)
	{
		bool result = default;
		while (true)
		{
			bool flag = A_1 != typeof(string);
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
						num = 3;
						continue;
					}
					result = base.CanConvertTo(A_0, A_1);
					num = 0;
					continue;
				case 3:
					result = true;
					num = 1;
					continue;
				case 0:
				case 1:
					return result;
				}
				break;
			}
		}
	}

	public virtual object a(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2)
	{
		object result = default;
		double result2 = default;
		string text = default;
		while (true)
		{
			bool flag = !(A_2 is string);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 5;
						continue;
					}
					if (true)
					{
					}
					result = base.ConvertFrom(A_0, A_1, A_2);
					num = 2;
					continue;
				case 0:
					result = new asdb9(result2, (asdy)Enum.Parse(typeof(asdy), text.Substring(text.Length - 2, 2), ignoreCase: true));
					num = 3;
					continue;
				case 5:
					text = A_2 as string;
					result2 = -1.0;
					flag = !double.TryParse(text.Remove(text.Length - 2, 2), out result2);
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						throw new Exception("Property value is not correct. ( { ±5.0 × 10−324 to ±1.7 × 10308 } { Cm | Px | In | Mm } )");
					}
					num = 0;
					continue;
				case 2:
				case 3:
					return result;
				}
				break;
			}
		}
	}

	public virtual object a(ITypeDescriptorContext A_0, CultureInfo A_1, object A_2, Type A_3)
	{
		object result = default;
		while (true)
		{
			bool flag = A_3 != typeof(string);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					result = base.ConvertTo(A_0, A_1, A_2, A_3);
					num = 0;
					continue;
				case 1:
					result = A_2.ToString();
					if (true)
					{
					}
					num = 3;
					continue;
				case 0:
				case 3:
					return result;
				}
				break;
			}
		}
	}
}
