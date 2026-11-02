using Microsoft.Data.SqlClient;
using System.IO;
using System.Text;

internal class asdbe
{
	private string m_a = "";

	private string m_b = "";

	public asdbe(string A_0, string A_1)
	{
		this.m_a = A_0;
		this.m_b = A_1;
	}

	private string a(string A_0)
	{
		string result = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				string text;
				switch (num)
				{
				case 6:
					if (!(A_0 == ""))
					{
						num = 5;
						continue;
					}
					goto IL_005d;
				case 5:
					if (true)
					{
					}
					num = 2;
					continue;
				case 1:
					text = "'";
					goto IL_00aa;
				case 3:
					num = 0;
					continue;
				case 0:
					text = "";
					goto IL_00aa;
				case 2:
					if (A_0[0] >= '0')
					{
						num = 7;
						continue;
					}
					goto case 3;
				case 7:
					num = 8;
					continue;
				case 8:
					if (A_0[0] > '9')
					{
						num = 3;
						continue;
					}
					goto IL_005d;
				case 4:
					{
						return result;
					}
					IL_005d:
					num = 1;
					continue;
					IL_00aa:
					result = text + A_0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	public void b(string A_0)
	{
		bool flag = default;
		while (true)
		{
			SqlConnection sqlConnection = new SqlConnection(this.m_b);
			StringBuilder stringBuilder = new StringBuilder();
			SqlCommand sqlCommand = new SqlCommand(this.m_a, sqlConnection);
			sqlConnection.Open();
			sqlCommand.CommandTimeout = 1200;
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			stringBuilder.Append("<meta http-equiv=\"Content-Type\" content=\"application/vnd.ms-excel;charset=UTF-8\"><style>.text { mso-number-format:\\@; } </style><TABLE class=\"text\" Border=1 ID=\"Table1\">");
			stringBuilder.Append("<TR bgcolor=\"#bbbbbb\" >");
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 7:
					flag = num < sqlDataReader.FieldCount;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 8;
						continue;
					}
					if (true)
					{
					}
					stringBuilder.Append("<TD align=center>" + a(sqlDataReader.GetValue(num).ToString()).Replace("'", "") + "</TD>");
					num++;
					num2 = 7;
					continue;
				case 5:
				case 9:
					flag = num < sqlDataReader.FieldCount;
					num2 = 6;
					continue;
				case 6:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					stringBuilder.Append("<TH style=' font-family:Tahoma; font-size:8pt'>" + sqlDataReader.GetName(num).Replace("'", "") + "</TH>");
					num++;
					num2 = 9;
					continue;
				case 0:
				case 3:
					flag = sqlDataReader.Read();
					num2 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 10;
						continue;
					}
					stringBuilder.Append("<TR>");
					num = 0;
					num2 = 2;
					continue;
				case 8:
					stringBuilder.Append("</TR>");
					num2 = 3;
					continue;
				case 4:
					stringBuilder.Append("</TR>");
					num2 = 0;
					continue;
				case 10:
				{
					sqlDataReader.Close();
					stringBuilder.Append("</TABLE>");
					StreamWriter streamWriter = new StreamWriter(A_0);
					streamWriter.Write(stringBuilder.ToString());
					streamWriter.Close();
					sqlConnection.Close();
					sqlConnection.Close();
					return;
				}
				}
				break;
			}
		}
	}
}
