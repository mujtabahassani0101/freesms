using System;
using System.Data;
using Microsoft.Data.SqlClient;

public class asdcb
{
	private enum __type_a
	{
		a,
		b
	}

	private static void a(SqlCommand A_0, SqlParameter[] A_1)
	{
		SqlParameter sqlParameter = default;
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
					sqlParameter.Value = DBNull.Value;
					num2 = 3;
					continue;
				case 1:
					if (true)
					{
					}
					num2 = 2;
					continue;
				case 2:
					num3 = ((sqlParameter.Value != null) ? 1 : 0);
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
					sqlParameter = A_1[num];
					num2 = 10;
					continue;
				case 4:
					return;
				case 3:
					A_0.Parameters.Add(sqlParameter);
					num++;
					num2 = 6;
					continue;
				case 0:
					num3 = 0;
					goto IL_0116;
				case 10:
					num2 = ((sqlParameter.Direction != ParameterDirection.InputOutput) ? 1 : 0);
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
		OriginalNavigationCheck.TraceCommand(A_4);
		while (true)
		{
			bool flag = A_1.State == ConnectionState.Open;
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
					A_1.Open();
					num = 1;
					continue;
				case 0:
					num = 5;
					continue;
				case 5:
					return;
				case 1:
					A_0.Connection = A_1;
					A_0.CommandText = A_4;
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
					A_0.CommandType = A_3;
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
		SqlParameter sqlParameter = default;
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
					sqlParameter = new SqlParameter(A_0, A_1);
					num = 3;
					continue;
				case 6:
					if (true)
					{
					}
					sqlParameter.Value = A_4;
					num = 2;
					continue;
				case 3:
				case 5:
					sqlParameter.Direction = A_3;
					sqlParameter.Value = "";
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
					sqlParameter = new SqlParameter(A_0, A_1, A_2);
					num = 5;
					continue;
				case 2:
					result = sqlParameter;
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
		SqlConnection sqlConnection = new SqlConnection(A_0);
		try
		{
			if (true)
			{
			}
			sqlConnection.Open();
			return c(sqlConnection, A_1, A_2, A_3);
		}
		finally
		{
			while (true)
			{
				IL_003d:
				bool flag = sqlConnection == null;
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
						((IDisposable)sqlConnection).Dispose();
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
		int result = default;
		while (true)
		{
			SqlCommand sqlCommand = new SqlCommand();
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
						a(sqlCommand, A_0, null, A_1, A_2, A_3);
						sqlCommand.CommandTimeout = 70000;
						num = sqlCommand.ExecuteNonQuery();
						sqlCommand.Parameters.Clear();
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
						sqlCommand.Parameters.Clear();
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
		SqlConnection sqlConnection = new SqlConnection(A_0);
		DataTable result;
		try
		{
			sqlConnection.Open();
			result = b(sqlConnection, A_1, A_2, A_3);
		}
		finally
		{
			while (true)
			{
				IL_0035:
				bool flag = sqlConnection == null;
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
						((IDisposable)sqlConnection).Dispose();
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
		if (true)
		{
		}
		SqlCommand sqlCommand = new SqlCommand();
		a(sqlCommand, A_0, null, A_1, A_2, A_3);
		sqlCommand.CommandTimeout = 0;
		SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
		DataTable dataTable = new DataTable();
		sqlDataAdapter.Fill(dataTable);
		sqlCommand.Parameters.Clear();
		return dataTable;
	}

	private static SqlDataReader a(SqlConnection A_0, SqlTransaction A_1, CommandType A_2, string A_3, SqlParameter[] A_4, __type_a A_5)
	{
		SqlCommand sqlCommand = new SqlCommand();
		try
		{
			SqlDataReader sqlDataReader = default;
			SqlDataReader result = default;
			while (true)
			{
				a(sqlCommand, A_0, A_1, A_2, A_3, A_4);
				bool flag = A_5 != asdcb.__type_a.b;
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
						sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
						num = 4;
						continue;
					case 1:
						sqlDataReader = sqlCommand.ExecuteReader();
						num = 2;
						continue;
					case 2:
					case 4:
						sqlCommand.Parameters.Clear();
						result = sqlDataReader;
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
				sqlCommand.Parameters.Clear();
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
		try
		{
			SqlConnection sqlConnection = new SqlConnection(A_0);
			sqlConnection.Open();
			try
			{
				if (true)
				{
				}
				return a(sqlConnection, null, A_1, A_2, A_3, asdcb.__type_a.a);
			}
			catch
			{
				sqlConnection.Close();
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
		SqlConnection sqlConnection = new SqlConnection(A_0);
		object result;
		try
		{
			sqlConnection.Open();
			result = a(sqlConnection, A_1, A_2, A_3);
		}
		finally
		{
			while (true)
			{
				IL_0035:
				bool flag = sqlConnection == null;
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
						((IDisposable)sqlConnection).Dispose();
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
		if (true)
		{
		}
		SqlCommand sqlCommand = new SqlCommand();
		a(sqlCommand, A_0, null, A_1, A_2, A_3);
		object result = sqlCommand.ExecuteScalar();
		sqlCommand.Parameters.Clear();
		return result;
	}
}
