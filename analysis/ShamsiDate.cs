using System;

namespace BijanComponents;

public class ShamsiDate
{
	public static string[] farsi_month_name = new string[12]
	{
		"فروردين", "ارديبهشت", "خرداد", "تير", "مرداد", "شهريور", "مهر", "آبان", "آذر", "دي",
		"بهمن", "اسفند"
	};

	public static string FarsiNumbers(string eng)
	{
		string text = eng;
		text = text.Replace("0", "٠");
		text = text.Replace("1", "١");
		text = text.Replace("2", "٢");
		text = text.Replace("3", "٣");
		text = text.Replace("4", "٤");
		text = text.Replace("5", "٥");
		text = text.Replace("6", "٦");
		text = text.Replace("7", "٧");
		text = text.Replace("8", "٨");
		return text.Replace("9", "٩");
	}

	public static DateTimeFarsi GetShamsiDateValue(DateTime date)
	{
		long[] array = new long[12]
		{
			31L, 28L, 31L, 30L, 31L, 30L, 31L, 31L, 30L, 31L,
			30L, 31L
		};
		long[] array2 = new long[12]
		{
			31L, 31L, 31L, 31L, 31L, 31L, 30L, 30L, 30L, 30L,
			30L, 29L
		};
		string[] array3 = new string[13]
		{
			"", "Farvardin", "Ordibehesht", "Khordad", "Tir", "Mordad", "Shahrivar", "Mehr", "Aban", "Azar",
			"Dey", "Bahman", "Esfand"
		};
		long num = date.Year;
		long num2 = date.Month;
		long num3 = date.Day;
		long num4 = num - 1600;
		long num5 = num2 - 1;
		long num6 = num3 - 1;
		long num7 = 365 * num4 + (num4 + 3) / 4 - (num4 + 99) / 100 + (num4 + 399) / 400;
		long num8;
		for (num8 = 0L; num8 < num5; num8++)
		{
			num7 += array[num8];
		}
		if (num5 > 1 && ((num4 % 4 == 0 && num4 % 100 != 0) || num4 % 400 == 0))
		{
			num7++;
		}
		num7 += num6;
		long num9 = num7 - 79;
		long num10 = num9 / 12053;
		num9 %= 12053;
		long num11 = 979 + 33 * num10 + 4 * (num9 / 1461);
		num9 %= 1461;
		if (num9 >= 366)
		{
			num11 += (num9 - 1) / 365;
			num9 = (num9 - 1) % 365;
		}
		for (num8 = 0L; num8 < 11 && num9 >= array2[num8]; num8++)
		{
			num9 -= array2[num8];
		}
		long num12 = num8 + 1;
		long num13 = num9 + 1;
		DateTimeFarsi dateTimeFarsi = new DateTimeFarsi(1, 1, 1);
		dateTimeFarsi = new DateTimeFarsi((int)num11, (int)num12, (int)num13);
		string text = $"ERROR in GetShamsiDateValue : {num11}/{num12}/{num13}";
		return dateTimeFarsi;
	}

	public static string GetShamsiDate(DateTime date)
	{
		DateTimeFarsi shamsiDateValue = GetShamsiDateValue(date);
		int year = shamsiDateValue.Year;
		int month = shamsiDateValue.Month;
		int day = shamsiDateValue.Day;
		string text = month.ToString();
		string text2 = day.ToString();
		if (text.Length == 1)
		{
			text = "0" + text;
		}
		if (text2.Length == 1)
		{
			text2 = "0" + text2;
		}
		return $"{year}/{text}/{text2}";
	}

	public static DateTime ShamsiToGregory(DateTimeFarsi shamsi)
	{
		string shamsi2 = $"{shamsi.Year}/{shamsi.Month}/{shamsi.Day}";
		return ShamsiToGregory(shamsi2);
	}

	public static DateTime ShamsiToGregory(int y, int m, int d)
	{
		DateTimeFarsi shamsi = new DateTimeFarsi(y, m, d);
		return ShamsiToGregory(shamsi);
	}

	public static DateTime ShamsiToGregory(string shamsi)
	{
		long[] array = new long[12]
		{
			31L, 28L, 31L, 30L, 31L, 30L, 31L, 31L, 30L, 31L,
			30L, 31L
		};
		long[] array2 = new long[12]
		{
			31L, 31L, 31L, 31L, 31L, 31L, 30L, 30L, 30L, 30L,
			30L, 29L
		};
		string[] array3 = new string[13]
		{
			"", "Farvardin", "Ordibehesht", "Khordad", "Tir", "Mordad", "Shahrivar", "Mehr", "Aban", "Azar",
			"Dey", "Bahman", "Esfand"
		};
		string[] array4 = shamsi.Split(new char[3] { ',', '/', '-' }, 3);
		long num = long.Parse(array4[0]);
		long num2 = long.Parse(array4[1]);
		long num3 = long.Parse(array4[2]);
		if (num < 1300)
		{
			num += 1300;
		}
		long num4 = num - 979;
		long num5 = num2 - 1;
		long num6 = num3 - 1;
		long num7 = 365 * num4 + num4 / 33 * 8 + (num4 % 33 + 3) / 4;
		long num8;
		for (num8 = 0L; num8 < num5; num8++)
		{
			num7 += array2[num8];
		}
		num7 += num6;
		long num9 = num7 + 79;
		long num10 = 1600 + 400 * (num9 / 146097);
		num9 %= 146097;
		long num11 = 1L;
		if (num9 >= 36525)
		{
			num9--;
			num10 += 100 * (num9 / 36524);
			num9 %= 36524;
			if (num9 >= 365)
			{
				num9++;
			}
			else
			{
				num11 = 0L;
			}
		}
		num10 += 4 * (num9 / 1461);
		num9 %= 1461;
		if (num9 >= 366)
		{
			num11 = 0L;
			num9--;
			num10 += num9 / 365;
			num9 %= 365;
		}
		for (num8 = 0L; num9 >= array[num8] + ((num8 == 1 && num11 != 0) ? 1 : 0); num8++)
		{
			num9 -= array[num8] + ((num8 == 1 && num11 != 0) ? 1 : 0);
		}
		long num12 = num8 + 1;
		long num13 = num9 + 1;
		DateTime result = DateTime.Now;
		try
		{
			result = new DateTime((int)num10, (int)num12, (int)num13);
		}
		catch
		{
		}
		return result;
	}
}
