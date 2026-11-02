using System;
using System.Diagnostics;
using System.Windows.Forms;
using BijanComponents;

internal static class asdbx
{
	[STAThread]
	private static void a()
	{
		while (true)
		{
			ShamsiDate.farsi_month_name = new string[12]
			{
				"حمل", "ثور", "جوزا", "سرطان", "اسد", "سنبله", "میزان", "عقرب", "قوس", "جدی",
				"دلو", "حوت"
			};
			Process currentProcess = Process.GetCurrentProcess();
			bool flag = Process.GetProcessesByName(currentProcess.ProcessName).Length <= 1;
			if (true)
			{
			}
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
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new asdb3());
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}
}
