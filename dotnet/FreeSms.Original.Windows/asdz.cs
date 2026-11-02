using System;
using System.IO;
using System.Net;
using System.Text;

public class asdz
{
	public static string a(string A_0, string A_1, string A_2, string A_3, string A_4)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://bulk.armaghan.net/post/sendsms.ashx");
		try
		{
			string text = "Username=" + A_2;
			text = text + "&Password=" + A_3;
			text = text + "&From=" + A_4;
			text = text + "&Text=" + A_1;
			text = text + "&TO=" + A_0;
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			httpWebRequest.Timeout = 20000;
			Stream requestStream = httpWebRequest.GetRequestStream();
			try
			{
				if (true)
				{
				}
				requestStream.Write(bytes, 0, bytes.Length);
			}
			finally
			{
				while (true)
				{
					IL_00c8:
					bool flag = requestStream == null;
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
							goto end_IL_00b3;
						case 1:
							((IDisposable)requestStream).Dispose();
							num = 0;
							continue;
						case 0:
							goto end_IL_00b3;
						}
						goto IL_00c8;
						continue;
						end_IL_00b3:
						break;
					}
					break;
				}
			}
			WebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
		}
		catch (WebException ex)
		{
			return ex.Message;
		}
	}
}
