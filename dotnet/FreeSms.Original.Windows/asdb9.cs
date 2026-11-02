using System.ComponentModel;
using System.Runtime.CompilerServices;

[TypeConverter(typeof(asday))]
public struct asdb9(double A_0, asdy A_1)
{
	private double m_a = A_0;

	private asdy m_b = A_1;

	[SpecialName]
	public double b()
	{
		return this.m_a;
	}

	[SpecialName]
	public void a(double A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	public asdy c()
	{
		return this.m_b;
	}

	[SpecialName]
	public void b(asdy A_0)
	{
		if (true)
		{
		}
		a(a(A_0).b());
		this.m_b = A_0;
	}

	public double c(asdy A_0)
	{
		double result = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					switch (A_0)
					{
					default:
						num = 4;
						break;
					case asdy.c:
						result = c(asdy.a) / 10.0;
						num = 1;
						break;
					case asdy.b:
						result = 96.0;
						num = 3;
						break;
					case asdy.a:
						result = c(asdy.b) / 2.5399999618530273;
						num = 0;
						break;
					}
					continue;
				case 4:
					if (true)
					{
					}
					num = 5;
					continue;
				case 5:
					result = 1.0;
					num = 6;
					continue;
				case 0:
				case 1:
				case 3:
				case 6:
					return result;
				}
				break;
			}
		}
	}

	public asdb9 a(asdy A_0)
	{
		asdb9 result = new asdb9(b() * c(c()) / c(A_0), A_0);
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public static asdb9 d(asdb9 A_0, asdb9 A_1)
	{
		asdb9 result = new asdb9(a(d(A_0.a(asdy.d), A_1.a(asdy.d))), asdy.d);
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public static asdb9 c(asdb9 A_0, asdb9 A_1)
	{
		asdb9 result = new asdb9(a(c(A_0.a(asdy.d), A_1.a(asdy.d))), asdy.d);
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public static asdb9 b(asdb9 A_0, asdb9 A_1)
	{
		if (true)
		{
		}
		return new asdb9(a(b(A_0.a(asdy.d), A_1.a(asdy.d))), asdy.d);
	}

	[SpecialName]
	public static asdb9 a(asdb9 A_0, asdb9 A_1)
	{
		if (true)
		{
		}
		return new asdb9(a(a(A_0.a(asdy.d), A_1.a(asdy.d))), asdy.d);
	}

	[SpecialName]
	public static double a(asdb9 A_0)
	{
		return a(A_0.a(asdy.d));
	}

	public string a()
	{
		string result = $"{b().ToString()} {c().ToString()}";
		if (true)
		{
		}
		return result;
	}
}
