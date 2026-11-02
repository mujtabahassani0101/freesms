using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

public class asdcb
{
	private enum a
	{
		a,
		b
	}

	private static void a(SqlCommand A_0, SqlParameter[] A_1)
	{
		SqlParameter val = default;
		bool flag = default;
		while (true)
		{
			int num = 0;
			int num2 = 7;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 5:
					((DbParameter)(object)val).Value = DBNull.Value;
					num2 = 3;
					continue;
				case 1:
					if (true)
					{
					}
					num2 = 2;
					continue;
				case 2:
					num3 = ((((DbParameter)(object)val).Value != null) ? 1 : 0);
					goto IL_0116;
				case 6:
				case 7:
					flag = num < A_1.Length;
					num2 = 8;
					continue;
				case 8:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					val = A_1[num];
					num2 = 10;
					continue;
				case 4:
					return;
				case 3:
					A_0.Parameters.Add(val);
					num++;
					num2 = 6;
					continue;
				case 0:
					num3 = 0;
					goto IL_0116;
				case 10:
					num2 = ((((DbParameter)(object)val).Direction != ParameterDirection.InputOutput) ? 1 : 0);
					continue;
				case 9:
					{
						if (!flag)
						{
							num2 = 5;
							continue;
						}
						goto case 3;
					}
					IL_0116:
					flag = (byte)num3 != 0;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	private static void a(SqlCommand A_0, SqlConnection A_1, SqlTransaction A_2, CommandType A_3, string A_4, SqlParameter[] A_5)
	{
		while (true)
		{
			bool flag = ((DbConnection)(object)A_1).State == ConnectionState.Open;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 4:
					a(A_0, A_5);
					if (true)
					{
					}
					num = 0;
					continue;
				case 9:
					A_0.Transaction = A_2;
					num = 2;
					continue;
				case 7:
					((DbConnection)(object)A_1).Open();
					num = 1;
					continue;
				case 0:
					num = 5;
					continue;
				case 5:
					return;
				case 1:
					A_0.Connection = A_1;
					((DbCommand)(object)A_0).CommandText = A_4;
					flag = A_2 == null;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 2;
				case 2:
					((DbCommand)(object)A_0).CommandType = A_3;
					flag = A_5 == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}

	public static SqlParameter a(string A_0, SqlDbType A_1, object A_2)
	{
		SqlParameter result = a(A_0, A_1, -1, ParameterDirection.Input, A_2);
		if (true)
		{
		}
		return result;
	}

	public static SqlParameter a(string A_0, SqlDbType A_1, int A_2, object A_3)
	{
		SqlParameter result = a(A_0, A_1, A_2, ParameterDirection.Input, A_3);
		if (true)
		{
		}
		return result;
	}

	public static SqlParameter a(string A_0, SqlDbType A_1)
	{
		SqlParameter result = a(A_0, A_1, -1, ParameterDirection.Output, null);
		if (true)
		{
		}
		return result;
	}

	public static SqlParameter a(string A_0, SqlDbType A_1, int A_2, ParameterDirection A_3, object A_4)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		SqlParameter val = default;
		SqlParameter result = default;
		while (true)
		{
			bool flag = A_2 <= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					val = new SqlParameter(A_0, A_1);
					num = 3;
					continue;
				case 6:
					if (true)
					{
					}
					((DbParameter)(object)val).Value = A_4;
					num = 2;
					continue;
				case 3:
				case 5:
					((DbParameter)(object)val).Direction = A_3;
					((DbParameter)(object)val).Value = "";
					flag = A_3 == ParameterDirection.Output;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 2;
				case 4:
					val = new SqlParameter(A_0, A_1, A_2);
					num = 5;
					continue;
				case 2:
					result = val;
					num = 1;
					continue;
				case 1:
					return result;
				}
				break;
			}
		}
	}

	public static int d(string A_0, CommandType A_1, string A_2)
	{
		return d(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static int d(string A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		SqlConnection val = new SqlConnection(A_0);
		try
		{
			if (true)
			{
			}
			((DbConnection)(object)val).Open();
			return c(val, A_1, A_2, A_3);
		}
		finally
		{
			while (true)
			{
				IL_003d:
				bool flag = val == null;
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
						goto end_IL_0028;
					case 1:
						((IDisposable)val).Dispose();
						num = 0;
						continue;
					case 0:
						goto end_IL_0028;
					}
					goto IL_003d;
					continue;
					end_IL_0028:
					break;
				}
				break;
			}
		}
	}

	public static int c(SqlConnection A_0, CommandType A_1, string A_2)
	{
		return c(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static int c(SqlConnection A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		int result = default;
		while (true)
		{
			SqlCommand val = new SqlCommand();
			int num = 0;
			if (true)
			{
			}
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 2:
					try
					{
						a(val, A_0, null, A_1, A_2, A_3);
						((DbCommand)(object)val).CommandTimeout = 70000;
						num = ((DbCommand)(object)val).ExecuteNonQuery();
						((DbParameterCollection)(object)val.Parameters).Clear();
					}
					catch (Exception ex)
					{
						string message = ex.Message;
						num = -2;
					}
					num2 = 1;
					continue;
				case 1:
					try
					{
						((DbParameterCollection)(object)val.Parameters).Clear();
					}
					catch
					{
					}
					result = num;
					num2 = 0;
					continue;
				case 0:
					return result;
				}
				break;
			}
		}
	}

	public static DataTable c(string A_0, CommandType A_1, string A_2)
	{
		return c(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static DataTable c(string A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		SqlConnection val = new SqlConnection(A_0);
		DataTable result;
		try
		{
			((DbConnection)(object)val).Open();
			result = b(val, A_1, A_2, A_3);
		}
		finally
		{
			while (true)
			{
				IL_0035:
				bool flag = val == null;
				int num = 1;
				while (true)
				{
					switch (num)
					{
					case 1:
						if (!flag)
						{
							num = 0;
							continue;
						}
						goto end_IL_0020;
					case 0:
						((IDisposable)val).Dispose();
						num = 2;
						continue;
					case 2:
						goto end_IL_0020;
					}
					goto IL_0035;
					continue;
					end_IL_0020:
					break;
				}
				break;
			}
		}
		if (true)
		{
		}
		return result;
	}

	public static DataTable b(SqlConnection A_0, CommandType A_1, string A_2)
	{
		return b(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static DataTable b(SqlConnection A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		if (true)
		{
		}
		SqlCommand val = new SqlCommand();
		a(val, A_0, null, A_1, A_2, A_3);
		((DbCommand)(object)val).CommandTimeout = 0;
		SqlDataAdapter val2 = new SqlDataAdapter(val);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val2).Fill(dataTable);
		((DbParameterCollection)(object)val.Parameters).Clear();
		return dataTable;
	}

	private static SqlDataReader a(SqlConnection A_0, SqlTransaction A_1, CommandType A_2, string A_3, SqlParameter[] A_4, a A_5)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		SqlCommand val = new SqlCommand();
		try
		{
			SqlDataReader val2 = default;
			SqlDataReader result = default;
			while (true)
			{
				a(val, A_0, A_1, A_2, A_3, A_4);
				bool flag = A_5 != asdcb.a.b;
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
						val2 = val.ExecuteReader(CommandBehavior.CloseConnection);
						num = 4;
						continue;
					case 1:
						val2 = val.ExecuteReader();
						num = 2;
						continue;
					case 2:
					case 4:
						((DbParameterCollection)(object)val.Parameters).Clear();
						result = val2;
						num = 0;
						continue;
					case 0:
						return result;
					}
					break;
				}
			}
		}
		catch
		{
			try
			{
				((DbParameterCollection)(object)val.Parameters).Clear();
			}
			catch
			{
			}
			throw;
		}
	}

	public static SqlDataReader b(string A_0, CommandType A_1, string A_2)
	{
		return b(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static SqlDataReader b(string A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		try
		{
			SqlConnection val = new SqlConnection(A_0);
			((DbConnection)(object)val).Open();
			try
			{
				if (true)
				{
				}
				return a(val, null, A_1, A_2, A_3, asdcb.a.a);
			}
			catch
			{
				((DbConnection)(object)val).Close();
				throw;
			}
		}
		catch (Exception ex)
		{
			string message = ex.Message;
			return null;
		}
	}

	public static object a(string A_0, CommandType A_1, string A_2)
	{
		return a(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static object a(string A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		SqlConnection val = new SqlConnection(A_0);
		object result;
		try
		{
			((DbConnection)(object)val).Open();
			result = a(val, A_1, A_2, A_3);
		}
		finally
		{
			while (true)
			{
				IL_0035:
				bool flag = val == null;
				int num = 1;
				while (true)
				{
					switch (num)
					{
					case 1:
						if (!flag)
						{
							num = 2;
							continue;
						}
						goto end_IL_0020;
					case 2:
						((IDisposable)val).Dispose();
						num = 0;
						continue;
					case 0:
						goto end_IL_0020;
					}
					goto IL_0035;
					continue;
					end_IL_0020:
					break;
				}
				break;
			}
		}
		if (true)
		{
		}
		return result;
	}

	public static object a(SqlConnection A_0, CommandType A_1, string A_2)
	{
		return a(A_0, A_1, A_2, (SqlParameter[])null);
	}

	public static object a(SqlConnection A_0, CommandType A_1, string A_2, params SqlParameter[] A_3)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		if (true)
		{
		}
		SqlCommand val = new SqlCommand();
		a(val, A_0, null, A_1, A_2, A_3);
		object result = ((DbCommand)(object)val).ExecuteScalar();
		((DbParameterCollection)(object)val.Parameters).Clear();
		return result;
	}
}
