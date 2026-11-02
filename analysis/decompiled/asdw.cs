using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Microsoft.Office.Interop.Excel;
using school_Af.Rpt.afPayment;

public class asdw : Form
{
	private string m_a = "";

	private string m_b = "";

	private string m_c = "";

	private string m_d = "";

	public string e = "";

	private bool m_f = false;

	private bool m_g = false;

	private IContainer m_h = null;

	private Panel m_i;

	private UIButton j;

	private UIGroupBox k;

	private Label l;

	private UIComboBox m;

	private Label n;

	private UIComboBox o;

	private UIButton p;

	private OpenFileDialog q;

	private Panel r;

	private GridEX s;

	private Label t;

	private Panel u;

	private Label v;

	private UIButton w;

	private ProgressBar x;

	private UIButton y;

	private SaveFileDialog z;

	private UIButton aa;

	private UIComboBox ab;

	public asdw()
	{
		a();
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 3;
				case 1:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_i).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 3;
					continue;
				case 2:
					num = 1;
					continue;
				case 3:
					ab.SelectedValue = asdaj.a;
					this.m_g = true;
					d(this, null);
					this.m_f = true;
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ab.SelectedValue.ToString() + ") order by id");
			((CollectionBase)(object)m.Items).Clear();
			m.Items.Add("کل", (object)"0");
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
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					m.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 3;
					continue;
				case 1:
					m.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			this.m_f = false;
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = m.SelectedIndex <= 0;
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
					goto case 0;
				case 2:
					text = text + " and xPaye=" + m.SelectedValue.ToString();
					if (true)
					{
					}
					num = 0;
					continue;
				case 0:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + ab.SelectedValue.ToString() + text);
					o.DataSource = dataSource;
					o.DisplayMember = "Name";
					o.ValueMember = "id";
					this.m_f = true;
					o.SelectedIndex = 0;
					return;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 15;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 15:
					num = ((!this.m_f) ? 3 : 2);
					continue;
				case 30:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 28;
				case 1:
				case 19:
					num = 22;
					continue;
				case 16:
					text += " and ";
					num = 18;
					continue;
				case 4:
					flag = !(text != "");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 18;
				case 18:
					text = text + " tYear_Student.xClass=" + o.SelectedValue.ToString();
					num = 28;
					continue;
				case 9:
					flag = !(this.m_a != "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 22;
				case 2:
					num = 6;
					continue;
				case 6:
					num2 = (this.m_g ? 1 : 0);
					goto IL_0309;
				case 12:
					text = text + " tYear_Student.xPaye=" + m.SelectedValue.ToString();
					num = 9;
					continue;
				case 13:
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 12;
				case 21:
					text += " and ";
					num = 12;
					continue;
				case 10:
					text = " where " + text;
					num = 29;
					continue;
				case 31:
					if (flag)
					{
						s.DataSource = null;
						text = " tComnentStd.deleteDate is null and tYear_Student.xYear=" + ab.SelectedValue.ToString() + " and   tComnentStd.xyear=" + ab.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
						flag = o.SelectedIndex <= 0;
						num = 30;
					}
					else
					{
						num = 11;
					}
					continue;
				case 3:
					num2 = 0;
					goto IL_0309;
				case 29:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tComnentStd.*, tStudent.Code AS Code, tStudent.FName AS FName, tStudent.LName AS LName, tStudent.PName AS PName, tClass.name AS Class, \r\n                      tPaye.Name AS Paye, tuser.uid AS UserInsert, tuser_1.uid AS UserUpdate\r\nFROM         tComnentStd INNER JOIN\r\n                      tStudent ON tComnentStd.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN\r\n                      tuser ON tComnentStd.xUserInsert = tuser.id LEFT OUTER JOIN\r\n                      tuser tuser_1 ON tComnentStd.xUserUpdate = tuser_1.id" + text + "  order by tComnentStd.id desc");
					s.DataSource = dataSource;
					num = 27;
					continue;
				}
				case 27:
					return;
				case 28:
					flag = m.SelectedIndex <= 0;
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 9;
				case 11:
					num = 5;
					continue;
				case 5:
					return;
				case 8:
				{
					string text2 = text;
					text = text2 + " tComnentStd.DateInsert>=N'" + this.m_a + "' and tComnentStd.DateInsert<=N'" + this.m_b + "'";
					num = 1;
					continue;
				}
				case 32:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 0;
				case 26:
					if (true)
					{
					}
					text += " and ";
					num = 0;
					continue;
				case 22:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 29;
				case 0:
					flag = !(this.m_b != "");
					num = 20;
					continue;
				case 20:
					{
						if (flag)
						{
							text = text + " tComnentStd.DateInsert=N'" + this.m_a + "'";
							num = 19;
						}
						else
						{
							num = 8;
						}
						continue;
					}
					IL_0309:
					flag = (byte)num2 != 0;
					num = 31;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Invalid comparison between Unknown and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			string text = "";
			string text2 = "";
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					num2 = 1;
					goto IL_0300;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((!(text != "")) ? 1 : 0);
					goto IL_0300;
				case 4:
				{
					asdbb asdbb2 = new asdbb();
					asdbb2.a = text2;
					asdbb2.b = ab.SelectedValue.ToString();
					asdbb2.c = text;
					((Form)asdbb2).ShowDialog();
					b();
					num = 1;
					continue;
				}
				case 1:
					return;
				case 7:
					try
					{
						while (true)
						{
							IL_0108:
							num = 0;
							while (true)
							{
								int num4;
								int num3;
								switch (num)
								{
								case 0:
									num = ((s.RowCount <= 0) ? 6 : 13);
									continue;
								case 2:
									num4 = 1;
									goto IL_02c2;
								case 6:
									num3 = 1;
									goto IL_024e;
								case 9:
									MessageBox.Show("این یادداشت توسط کاربر دیگری ثبت شده و امکان اصلاح برای شما وجود ندارد", "خطای دسترسی");
									num = 14;
									continue;
								case 14:
									return;
								case 10:
									num = 12;
									continue;
								case 12:
									num = ((asdaj.l != "1") ? 7 : 2);
									continue;
								case 13:
									num = 5;
									continue;
								case 5:
									num3 = (((int)s.SelectedItems[0].RowType != 0) ? 1 : 0);
									goto IL_024e;
								case 1:
									if (!flag)
									{
										num = 10;
										continue;
									}
									goto case 8;
								case 7:
									num = 4;
									continue;
								case 4:
									num4 = ((!(s.SelectedItems[0].GetRow().Cells["xUserInsert"].Value.ToString() != asdaj.l)) ? 1 : 0);
									goto IL_02c2;
								case 3:
									if (flag)
									{
										text2 = s.SelectedItems[0].GetRow().Cells["xStudent"].Value.ToString();
										text = s.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
										num = 8;
									}
									else
									{
										num = 9;
									}
									continue;
								case 8:
									num = 11;
									continue;
								case 11:
									goto end_IL_00c3;
									IL_024e:
									flag = (byte)num3 != 0;
									num = 1;
									continue;
									IL_02c2:
									flag = (byte)num4 != 0;
									num = 3;
									continue;
								}
								goto IL_0108;
								continue;
								end_IL_00c3:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						if (true)
						{
						}
						num = 4;
						continue;
					}
					return;
				case 5:
					{
						num = ((text2 != "") ? 6 : 0);
						continue;
					}
					IL_0300:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void f(object A_0, EventArgs A_1)
	{
		this.m_f = false;
		c();
	}

	private void e(object A_0, EventArgs A_1)
	{
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			asdaf asdaf2 = new asdaf();
			asdaf2.n = this.m_a;
			asdaf2.o = this.m_b;
			asdaf2.m = this.e;
			((Form)asdaf2).ShowDialog();
			this.m_a = asdaf2.n;
			this.m_b = asdaf2.o;
			this.m_c = asdaf2.p;
			this.m_d = asdaf2.q;
			this.e = asdaf2.m;
			bool flag = !(this.m_a != "");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 3;
						continue;
					}
					((Control)v).Text = "لیست کلیه یادداشت های ثبت شده";
					num = 6;
					continue;
				case 0:
				case 2:
					if (true)
					{
					}
					num = 1;
					continue;
				case 3:
					flag = !(this.m_b != "");
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						((Control)v).Text = "لیست یادداشت های روز " + this.m_c + " " + this.m_a;
						num = 0;
					}
					else
					{
						num = 5;
					}
					continue;
				case 5:
					((Control)v).Text = "لیست یادداشت ها از روز" + this.m_c + " " + this.m_a + " تا روز " + this.m_d + " " + this.m_b;
					num = 2;
					continue;
				case 1:
				case 6:
					this.m_f = true;
					b();
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		string fileName = default;
		string text = default;
		int num2 = default;
		DataTable dataTable = default;
		int num3 = default;
		Application val2 = default;
		Workbook val3 = default;
		Worksheet val4 = default;
		while (true)
		{
			DialogResult val = ((CommonDialog)z).ShowDialog();
			bool flag = (int)val == 1;
			int num = 29;
			while (true)
			{
				switch (num)
				{
				case 29:
					if (!flag)
					{
						num = 7;
						continue;
					}
					fileName = ((FileDialog)z).FileName;
					x.Minimum = 0;
					x.Value = 1;
					x.Step = 1;
					text = " tYear_Student.xYear=" + ab.SelectedValue.ToString() + " and    tPaymentStudent.xyear=" + ab.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = o.SelectedIndex <= 0;
					num = 46;
					continue;
				case 5:
					text = " where " + text;
					num = 37;
					continue;
				case 14:
					flag = !(text != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 25;
				case 28:
				case 40:
					flag = num2 < dataTable.Rows.Count;
					num = 22;
					continue;
				case 22:
					if (flag)
					{
						num3 = 0;
						num = 23;
					}
					else
					{
						num = 20;
					}
					continue;
				case 27:
					text += " and ";
					num = 0;
					continue;
				case 32:
					x.Maximum = dataTable.Rows.Count;
					num2 = 0;
					num = 40;
					continue;
				case 17:
					flag = val2 == null;
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 16;
				case 18:
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
						continue;
					}
					goto case 37;
				case 13:
					text += " and ";
					num = 25;
					continue;
				case 4:
					((_Workbook)val3).Close((object)true, (object)null, (object)null);
					Marshal.FinalReleaseComObject(val3);
					num = 17;
					continue;
				case 16:
					MessageBox.Show("پایان");
					num = 3;
					continue;
				case 3:
					return;
				case 41:
					flag = !(this.m_b != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 38;
						continue;
					}
					text = text + " tPaymentStudent.PaynemtDate=N'" + this.m_a + "'";
					num = 43;
					continue;
				case 7:
					num = 10;
					continue;
				case 10:
					return;
				case 24:
					flag = m.SelectedIndex <= 0;
					num = 31;
					continue;
				case 31:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 1;
				case 0:
					text = text + " tYear_Student.xClass=" + o.SelectedValue.ToString();
					num = 24;
					continue;
				case 1:
					flag = !(this.m_a != "");
					num = 42;
					continue;
				case 42:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 18;
				case 20:
					((_Workbook)val3).SaveAs((object)fileName, (object)(XlFileFormat)(-4143), (object)null, (object)null, (object)null, (object)null, (XlSaveAsAccessMode)1, (object)null, (object)null, (object)null, (object)null, (object)null);
					flag = val3 == null;
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 17;
				case 23:
				case 45:
					flag = num3 < dataTable.Columns.Count;
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 2;
						continue;
					}
					((_Worksheet)val4).Cells[(object)(num2 + 2), (object)(num3 + 1)] = dataTable.Rows[num2][num3].ToString();
					num3++;
					num = 45;
					continue;
				case 38:
				{
					string text3 = text;
					text = text3 + " tPaymentStudent.PaynemtDate>=N'" + this.m_a + "' and tPaymentStudent.PaynemtDate<=N'" + this.m_b + "'";
					num = 8;
					continue;
				}
				case 21:
					flag = !(text != "");
					num = 34;
					continue;
				case 34:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 41;
				case 25:
					text = text + " tYear_Student.xPaye=" + m.SelectedValue.ToString();
					num = 1;
					continue;
				case 2:
					x.PerformStep();
					num2++;
					num = 28;
					continue;
				case 15:
					text += " and ";
					num = 41;
					continue;
				case 44:
					flag = !(text != "");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 0;
				case 8:
				case 43:
					num = 18;
					continue;
				case 19:
				case 36:
					flag = num2 < dataTable.Columns.Count + 1;
					num = 35;
					continue;
				case 35:
					if (flag)
					{
						((_Worksheet)val4).Cells[(object)1, (object)num2] = dataTable.Columns[num2 - 1].ColumnName;
						num2++;
						num = 36;
					}
					else
					{
						num = 32;
					}
					continue;
				case 46:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 24;
				case 37:
				{
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.Code AS [کد متعلم], tStudent.FName AS نام, tStudent.LName AS [ولد-بنت], tStudent.PName AS ولدیت, tPaye.Name AS پایه, tClass.name AS صنف, \r\n\r\n                      tPaymentStudent.PaynemtDate AS [تاریخ یادداشت], tPaymentStudent.dayOfWeek AS روز, tPaymentStudent.NamberBel AS [نمبر بل],                      ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS [جمع یادداشت],  tPaymentStudent.Fee AS فیس, \r\n                      tPaymentStudent.Transport AS ترانسپورت, tPaymentStudent.racing AS مسابقه, tPaymentStudent.Celebration AS جشن, tPaymentStudent.Exam AS امتحان, \r\n                      tPaymentStudent.uniform AS یونیفرم, tPaymentStudent.maghnae AS مقنعه, tPaymentStudent.ketab AS کتاب, tPaymentStudent.komakdarsi AS [کمک درسی], \r\n                      tPaymentStudent.dakhle AS داخله, tPaymentStudent.other AS سایر, tPaymentStudent.comment AS توضیحات\r\n                    FROM         tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id" + text);
					object value = Missing.Value;
					val2 = (Application)new ApplicationClass();
					Workbooks workbooks = ((_Application)val2).Workbooks;
					string text2 = Application.StartupPath + "\\std.xls";
					CultureInfo currentCulture = new CultureInfo("en-US");
					Thread.CurrentThread.CurrentCulture = currentCulture;
					val3 = workbooks.Open(text2, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
					val4 = (Worksheet)((_Workbook)val3).ActiveSheet;
					num2 = 1;
					num = 19;
					continue;
				}
				case 9:
					((_Application)val2).Quit();
					Marshal.FinalReleaseComObject(val2);
					num = 16;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		SqlParameter[] a_3 = default;
		while (true)
		{
			string a_ = "";
			string a_2 = "";
			bool flag = !(this.m_a != "");
			int num = 16;
			while (true)
			{
				switch (num)
				{
				case 16:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 24;
				case 8:
					flag = !(this.m_b != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 21;
						continue;
					}
					text = text + " tPaymentStudent.PaynemtDate=N'" + this.m_a + "'";
					num = 30;
					continue;
				case 10:
					text = text + " tYear_Student.xPaye=" + m.SelectedValue.ToString();
					num = 26;
					continue;
				case 9:
					a_3 = new SqlParameter[3]
					{
						asdcb.a("@dateFrom", SqlDbType.NVarChar, a_),
						asdcb.a("@dateTo", SqlDbType.NVarChar, a_2),
						asdcb.a("@dayName", SqlDbType.NVarChar, this.m_c)
					};
					text = " tYear_Student.xYear=" + ab.SelectedValue.ToString() + " and  tPaymentStudent.xyear=" + ab.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = o.SelectedIndex <= 0;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 12;
				case 2:
					a_2 = this.m_b.Substring(8, 2) + "/" + this.m_b.Substring(5, 2) + "/" + this.m_b.Substring(0, 4);
					num = 9;
					continue;
				case 18:
					text += " and ";
					num = 8;
					continue;
				case 28:
					flag = !(text != "");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 20;
				case 3:
					text += " and ";
					num = 10;
					continue;
				case 22:
					flag = !(text != "");
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 13;
				case 29:
				case 30:
					num = 28;
					continue;
				case 5:
					text = " where " + text;
					num = 20;
					continue;
				case 12:
					flag = m.SelectedIndex <= 0;
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 26;
				case 1:
					if (true)
					{
					}
					flag = !(text != "");
					num = 0;
					continue;
				case 19:
					a_ = this.m_a.Substring(8, 2) + "/" + this.m_a.Substring(5, 2) + "/" + this.m_a.Substring(0, 4);
					num = 24;
					continue;
				case 6:
					text += " and ";
					num = 13;
					continue;
				case 24:
					flag = !(this.m_b != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 9;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 10;
				case 21:
				{
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + this.m_a + "' and tPaymentStudent.PaynemtDate<=N'" + this.m_b + "'";
					num = 29;
					continue;
				}
				case 14:
					flag = !(text != "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 8;
				case 13:
					text = text + " tYear_Student.xClass=" + o.SelectedValue.ToString();
					num = 12;
					continue;
				case 26:
					flag = !(this.m_a != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 28;
				case 20:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  @dateFrom as dateFrom,@dateTo as dateTo, @dayName as dayName ,   ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS SumPay,  ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS SumOther, tStudent.Code AS Code, \r\n                      tStudent.FName AS FName, tStudent.LName AS LName, tStudent.PName AS PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.xPaye, \r\n                      tYear_Student.xClass, tPaymentStudent.id, tPaymentStudent.xYear, tPaymentStudent.xStudent, tPaymentStudent.PaynemtDate, tPaymentStudent.dayOfWeek, \r\n                      tPaymentStudent.NamberBel, tPaymentStudent.Fee, tPaymentStudent.Transport, tPaymentStudent.racing, tPaymentStudent.Celebration, tPaymentStudent.Exam, \r\n                      tPaymentStudent.uniform, tPaymentStudent.maghnae, tPaymentStudent.ketab, tPaymentStudent.komakdarsi, tPaymentStudent.dakhle, tPaymentStudent.other, \r\n                      tPaymentStudent.comment , tParmetr.heder1, tParmetr.sch\r\n                        FROM         tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id   CROSS JOIN\r\n                      tParmetr" + text, a_3);
					ReportClass val = null;
					val = (ReportClass)(object)new CrRptListPayment();
					((ReportDocument)val).SetDataSource(dataSource);
					asda asda10 = new asda();
					asda10.a = val;
					((Form)asda10).ShowDialog();
					return;
				}
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		this.m_f = false;
		d();
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					num = ((!A_0) ? 6 : 0);
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_h == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_h.Dispose();
					num = 5;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 6:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected Obj, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected Obj, but got Unknown
		//IL_0aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Unknown
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Obj, but got Unknown
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected Obj, but got Unknown
		//IL_0f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Expected Obj, but got Unknown
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdw));
		GridEXLayout val = new GridEXLayout();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		StringFormat val8 = new StringFormat();
		StringFormat val9 = new StringFormat();
		StringFormat val10 = new StringFormat();
		this.m_i = new Panel();
		aa = new UIButton();
		x = new ProgressBar();
		y = new UIButton();
		w = new UIButton();
		u = new Panel();
		v = new Label();
		j = new UIButton();
		s = new GridEX();
		p = new UIButton();
		k = new UIGroupBox();
		ab = new UIComboBox();
		t = new Label();
		n = new Label();
		o = new UIComboBox();
		l = new Label();
		m = new UIComboBox();
		q = new OpenFileDialog();
		r = new Panel();
		z = new SaveFileDialog();
		((Control)this.m_i).SuspendLayout();
		((Control)u).SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((ISupportInitialize)k).BeginInit();
		((Control)k).SuspendLayout();
		((Control)r).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_i).BackColor = Color.FromArgb(214, 223, 247);
		this.m_i.BorderStyle = (BorderStyle)1;
		((Control)this.m_i).Controls.Add((Control)(object)aa);
		((Control)this.m_i).Controls.Add((Control)(object)x);
		((Control)this.m_i).Controls.Add((Control)(object)y);
		((Control)this.m_i).Controls.Add((Control)(object)w);
		((Control)this.m_i).Controls.Add((Control)(object)u);
		((Control)this.m_i).Controls.Add((Control)(object)j);
		((Control)this.m_i).Controls.Add((Control)(object)s);
		((Control)this.m_i).Controls.Add((Control)(object)p);
		((Control)this.m_i).Controls.Add((Control)(object)k);
		((Control)this.m_i).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_i).Location = new Point(5, 5);
		((Control)this.m_i).Name = "panel1";
		((Control)this.m_i).Size = new Size(900, 674);
		((Control)this.m_i).TabIndex = 0;
		((Control)this.m_i).Paint += a;
		((Control)aa).Anchor = (AnchorStyles)6;
		aa.Image = (Image)componentResourceManager.GetObject("btnview.Image");
		aa.ImageSize = new Size(40, 40);
		((Control)aa).Location = new Point(196, 621);
		((Control)aa).Name = "btnview";
		((Control)aa).Size = new Size(149, 46);
		((Control)aa).TabIndex = 138;
		((Control)aa).Text = "نمایش گزارش";
		((Control)aa).Visible = false;
		((Control)aa).Click += b;
		((Control)x).Location = new Point(372, 605);
		((Control)x).Name = "pr12";
		((Control)x).Size = new Size(167, 20);
		((Control)x).TabIndex = 137;
		((Control)x).UseWaitCursor = true;
		((Control)x).Visible = false;
		((Control)y).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		y.Image = (Image)componentResourceManager.GetObject("btnXls.Image");
		y.ImageSize = new Size(30, 30);
		((Control)y).Location = new Point(372, 631);
		((Control)y).Name = "btnXls";
		((Control)y).Size = new Size(167, 35);
		((Control)y).TabIndex = 136;
		((Control)y).Text = "دریافت فایل اکسل";
		((Control)y).Visible = false;
		((Control)y).Click += c;
		w.Image = (Image)componentResourceManager.GetObject("btnSelectDate.Image");
		((Control)w).Location = new Point(13, 65);
		((Control)w).Name = "btnSelectDate";
		((Control)w).Size = new Size(108, 31);
		((Control)w).TabIndex = 135;
		((Control)w).Text = "انتخاب تاریخ";
		((Control)w).Click += d;
		((Control)u).BackColor = SystemColors.HotTrack;
		u.BorderStyle = (BorderStyle)1;
		((Control)u).Controls.Add((Control)(object)v);
		((Control)u).Location = new Point(127, 62);
		((Control)u).Name = "panelStd";
		((Control)u).Size = new Size(756, 37);
		((Control)u).TabIndex = 134;
		((Control)v).Anchor = (AnchorStyles)15;
		((Control)v).BackColor = Color.FromArgb(0, 192, 192);
		v.BorderStyle = (BorderStyle)1;
		((Control)v).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(2, 2);
		((Control)v).Name = "lPayment";
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(749, 31);
		((Control)v).TabIndex = 77;
		v.TextAlign = (ContentAlignment)32;
		((Control)j).Anchor = (AnchorStyles)10;
		((Control)j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(20, 20);
		((Control)j).Location = new Point(13, 621);
		((Control)j).Name = "btnClose";
		((Control)j).Size = new Size(149, 46);
		((Control)j).TabIndex = 3;
		((Control)j).Text = "بستن";
		((Control)j).Click += g;
		s.AllowEdit = (InheritableBoolean)2;
		((Control)s).Anchor = (AnchorStyles)15;
		s.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		s.DesignTimeLayout = val;
		s.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)s).Font = new Font("Tahoma", 8.25f);
		((Control)s).Location = new Point(13, 105);
		((Control)s).Name = "gridEX2";
		((ScrollableBase)s).RecordNavigator = true;
		s.RowHeaders = (InheritableBoolean)1;
		s.SelectedFormatStyle.BackColor = Color.FromArgb(0, 0, 64);
		((Control)s).Size = new Size(874, 494);
		((Control)s).TabIndex = 18;
		((ScrollableBase)s).VisualStyle = (VisualStyle)2;
		((Control)p).Anchor = (AnchorStyles)10;
		((Control)p).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		p.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)p).Location = new Point(738, 620);
		((Control)p).Name = "btnEdit";
		((Control)p).Size = new Size(149, 46);
		((Control)p).TabIndex = 1;
		((Control)p).Text = "اصلاح مورد انتخابی";
		((Control)p).Click += h;
		((Control)k).Anchor = (AnchorStyles)13;
		((Control)k).Controls.Add((Control)(object)ab);
		((Control)k).Controls.Add((Control)(object)t);
		((Control)k).Controls.Add((Control)(object)n);
		((Control)k).Controls.Add((Control)(object)o);
		((Control)k).Controls.Add((Control)(object)l);
		((Control)k).Controls.Add((Control)(object)m);
		((Control)k).Location = new Point(13, 0);
		((Control)k).Name = "uiGroupBox1";
		((Control)k).Size = new Size(874, 58);
		((Control)k).TabIndex = 0;
		((Control)k).Text = "جستجو";
		((UIComboBase)ab).ComboStyle = (ComboStyle)1;
		((UIComboBase)ab).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ab).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "1403";
		val2.Value = "1403";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "1402";
		val3.Value = "1402";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1401";
		val4.Value = "1401";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1400";
		val5.Value = "1400";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1399";
		val6.Value = "1399";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1398";
		val7.Value = "1398";
		ab.Items.AddRange(new UIComboBoxItem[6] { val2, val3, val4, val5, val6, val7 });
		((Control)ab).Location = new Point(688, 22);
		((Control)ab).Name = "dropYear";
		((Control)ab).Size = new Size(97, 23);
		val8.Alignment = (StringAlignment)0;
		val8.FormatFlags = (StringFormatFlags)20485;
		val8.HotkeyPrefix = (HotkeyPrefix)0;
		val8.LineAlignment = (StringAlignment)1;
		val8.Trimming = (StringTrimming)1;
		((UIComboBase)ab).StringFormat = val8;
		((Control)ab).TabIndex = 136;
		ab.SelectedIndexChanged += a;
		((Control)t).AutoSize = true;
		((Control)t).Location = new Point(792, 24);
		((Control)t).Name = "label10";
		((Control)t).Size = new Size(66, 13);
		((Control)t).TabIndex = 135;
		((Control)t).Text = "سال تعلیمی";
		((Control)n).Anchor = (AnchorStyles)9;
		((Control)n).AutoSize = true;
		((Control)n).Location = new Point(233, 24);
		((Control)n).Name = "label19";
		((Control)n).Size = new Size(30, 13);
		((Control)n).TabIndex = 25;
		((Control)n).Text = "صنف";
		((Control)o).Anchor = (AnchorStyles)9;
		((UIComboBase)o).ComboStyle = (ComboStyle)1;
		((UIComboBase)o).DropListFont = new Font("Tahoma", 8.25f);
		((Control)o).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)o).Location = new Point(26, 20);
		((Control)o).Name = "dropCls";
		((Control)o).Size = new Size(201, 23);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)o).StringFormat = val9;
		((Control)o).TabIndex = 1;
		o.SelectedIndexChanged += e;
		((Control)l).Anchor = (AnchorStyles)9;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(585, 26);
		((Control)l).Name = "label20";
		((Control)l).Size = new Size(22, 13);
		((Control)l).TabIndex = 15;
		((Control)l).Text = "پایه";
		((Control)m).Anchor = (AnchorStyles)9;
		((UIComboBase)m).ComboStyle = (ComboStyle)1;
		((UIComboBase)m).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)m).Location = new Point(378, 20);
		((Control)m).Name = "dropPaye";
		((Control)m).Size = new Size(201, 23);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)m).StringFormat = val10;
		((Control)m).TabIndex = 0;
		m.SelectedIndexChanged += f;
		((FileDialog)q).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)q).Title = "انتخاب عکس شاگرد";
		((Control)r).BackColor = Color.Black;
		((Control)r).Controls.Add((Control)(object)this.m_i);
		((Control)r).Dock = (DockStyle)5;
		((Control)r).Location = new Point(0, 0);
		((Control)r).Name = "panel2";
		((Control)r).Size = new Size(910, 685);
		((Control)r).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(910, 685);
		((Control)this).Controls.Add((Control)(object)r);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmCommentList";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += i;
		((Control)this.m_i).ResumeLayout(false);
		((Control)u).ResumeLayout(false);
		((ISupportInitialize)s).EndInit();
		((ISupportInitialize)k).EndInit();
		((Control)k).ResumeLayout(false);
		((Control)k).PerformLayout();
		((Control)r).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
