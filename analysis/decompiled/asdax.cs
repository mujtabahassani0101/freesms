using System.Data;
using System.Data.SqlClient;

internal class asdax
{
	public static bool a(int A_0)
	{
		bool flag2 = default;
		string[] array = default;
		int num2 = default;
		bool result = default;
		while (true)
		{
			bool flag = false;
			int num = 1;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 1:
					num = ((asdu.o == "") ? 4 : 6);
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_00c6:
							DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tItem where id=" + A_0);
							flag2 = dataTable.Rows.Count <= 0;
							num = 9;
							while (true)
							{
								switch (num)
								{
								case 9:
									if (!flag2)
									{
										num = 1;
										continue;
									}
									goto case 6;
								case 3:
								case 11:
									num = 6;
									continue;
								case 4:
									if (!flag2)
									{
										num = 2;
										continue;
									}
									goto case 7;
								case 1:
									array = asdab.c(dataTable.Rows[0]["fc"].ToString()).Split(new char[1] { '-' });
									flag2 = !(array[0] == A_0.ToString());
									num = 14;
									continue;
								case 14:
									if (flag2)
									{
										flag = false;
										num = 11;
									}
									else
									{
										num = 10;
									}
									continue;
								case 10:
									num2 = int.Parse(array[1]);
									flag2 = num2 <= 30;
									num = 5;
									continue;
								case 5:
									if (flag2)
									{
										flag = true;
										flag2 = !(asdab.c(dataTable.Rows[0]["fd"].ToString()) != asdab.b());
										num = 4;
									}
									else
									{
										num = 12;
									}
									continue;
								case 12:
									flag = false;
									num = 0;
									continue;
								case 2:
								{
									num2++;
									string a_ = asdab.d(A_0 + "-" + num2);
									string a_2 = asdab.d(asdab.b());
									SqlParameter[] a_3 = new SqlParameter[3]
									{
										asdcb.a("@fd", SqlDbType.NVarChar, a_2),
										asdcb.a("@fc", SqlDbType.NVarChar, a_),
										asdcb.a("@id", SqlDbType.Int, A_0)
									};
									asdcb.d(asdab.e(), CommandType.Text, "UPDATE  tItem SET fc = @fc, fd = @fd WHERE (id = @id)", a_3);
									num = 7;
									continue;
								}
								case 0:
								case 8:
									num = 3;
									continue;
								case 7:
									num = 8;
									continue;
								case 6:
									num = 13;
									continue;
								case 13:
									goto end_IL_0081;
								}
								goto IL_00c6;
								continue;
								end_IL_0081:
								break;
							}
							break;
						}
					}
					catch
					{
						flag = false;
					}
					if (true)
					{
					}
					num = 7;
					continue;
				case 4:
					num3 = 0;
					goto IL_03b4;
				case 6:
					num = 5;
					continue;
				case 5:
					num3 = ((!(asdu.o.Substring(A_0 - 1, 1) == "0")) ? 1 : 0);
					goto IL_03b4;
				case 0:
				case 7:
					result = flag;
					num = 9;
					continue;
				case 3:
					num = 2;
					continue;
				case 8:
					if (flag2)
					{
						flag = true;
						num = 0;
					}
					else
					{
						num = 3;
					}
					continue;
				case 9:
					{
						return result;
					}
					IL_03b4:
					flag2 = (byte)num3 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}
}
