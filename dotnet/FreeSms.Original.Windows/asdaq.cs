using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdaq : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	public string __field_b;

	private bool m_c;

	private int m_d;

	private bool m_e = false;

	private IContainer f = null;

	private Panel g;

	private Panel h;

	private Panel i;

	private Label j;

	private UIButton k;

	private GridEX l;

	private UIComboBox m;

	private Label n;

	private Label o;

	private UIButton p;

	private EditBox q;

	private Label r;

	private Button s;

	private EditBox t;

	private Label u;

	private Label v;

	public asdaq()
	{
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 12;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 8;
					continue;
				case 10:
					o.Text = "صنف یازدهم";
					num = 3;
					continue;
				case 4:
					o.Text = "صنف دهم";
					num = 5;
					continue;
				case 1:
					if (true)
					{
					}
					num = 14;
					continue;
				case 13:
					try
					{
						m.SelectedIndex = 0;
						b();
						l.CurrentColumn = l.GetRow(0).Cells["ghayeb"].Column;
						l.Select();
						l.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 6;
					continue;
				case 8:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 9;
				case 3:
				case 5:
					c();
					num = 13;
					continue;
				case 6:
					return;
				case 9:
					this.m_c = true;
					flag = !(this.__field_b == "10");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					flag = !(this.__field_b == "11");
					num = 0;
					continue;
				case 14:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						i.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 9;
					continue;
				case 0:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 3;
				case 12:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 7;
					continue;
				case 7:
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + asdaj.__field_a + " and xpaye =12 and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
		m.DataSource = dataSource;
		m.DisplayMember = "Name";
		m.ValueMember = "id";
	}

	private void b()
	{
		while (true)
		{
			bool flag = m.SelectedIndex >= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 2;
						continue;
					}
					int num2 = asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tHazeriAgo\r\n                      (xStudent)\r\n                    SELECT     xStudent FROM   tYear_Student\r\n                WHERE     (xClass = " + m.SelectedValue.ToString() + ") AND (xYear = " + asdaj.__field_a + ") AND (xStudent NOT IN\r\n                          (SELECT     xStudent\r\n                             FROM         tHazeriAgo))");
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    0 as acp,  tYear_Student.xStudent, tYear_Student.sort, tHazeriAgo.hazer" + this.__field_b + " as hazer, tHazeriAgo.Ghayeb" + this.__field_b + " as Ghayeb, tHazeriAgo.Mariz" + this.__field_b + " as Mariz, tHazeriAgo.rokhsat" + this.__field_b + " as rokhsat,tHazeriAgo.CountDay" + this.__field_b + " as CountDay, tHazeriAgo.xYear" + this.__field_b + " as xYear,   tStudent.FName+ ' '+ tStudent.LName as Fullname,  tStudent.NumberAsas\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                        tHazeriAgo   ON tYear_Student.xStudent = tHazeriAgo.xStudent\r\n                WHERE   tYear_Student.shaghe=1 and  (tYear_Student.xYear = " + asdaj.__field_a + ") AND (tYear_Student.xClass = " + m.SelectedValue.ToString() + ")");
					l.DataSource = dataSource;
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(l.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					l.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(l.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					l.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					num = 0;
					continue;
				}
				case 0:
					return;
				case 2:
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		int num7 = default;
		int num3 = default;
		int num2 = default;
		int num8 = default;
		bool flag = default;
		int num5 = default;
		while (true)
		{
			this.m_c = false;
			int num = 14;
			while (true)
			{
				int num4;
				switch (num)
				{
				case 14:
					if (!(A_1.Column.Key == "ghayeb"))
					{
						num = 8;
						continue;
					}
					goto IL_0085;
				case 11:
					num4 = 0;
					goto IL_019b;
				case 12:
					try
					{
						num7 = int.Parse(l.GetRow(l.Row).Cells["Ghayeb"].Value.ToString());
					}
					catch
					{
					}
					num = 6;
					continue;
				case 0:
					num3 = 0;
					num = 5;
					continue;
				case 13:
					try
					{
						num2 = int.Parse(l.GetRow(l.Row).Cells["xYear"].Value.ToString());
					}
					catch
					{
					}
					num = 12;
					continue;
				case 6:
					try
					{
						num8 = int.Parse(l.GetRow(l.Row).Cells["Mariz"].Value.ToString());
					}
					catch
					{
					}
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 5:
				{
					try
					{
						num3 = int.Parse(l.GetRow(l.Row).Cells["CountDay"].Value.ToString());
					}
					catch
					{
						MessageBox.Show("ابتدا تعداد روز ها را وارد کنید");
						return;
					}
					int num9 = 0;
					num7 = 0;
					num8 = 0;
					num5 = 0;
					int num6 = 0;
					num2 = 0;
					num = 13;
					continue;
				}
				case 2:
				{
					try
					{
						num5 = int.Parse(l.GetRow(l.Row).Cells["rokhsat"].Value.ToString());
					}
					catch
					{
					}
					int num6 = num7 + num8 + num5;
					int num9 = num3 - num6;
					l.GetRow(l.Row).BeginEdit();
					l.GetRow(l.Row).Cells["hazer"].Value = num9;
					l.GetRow(l.Row).Cells["Ghayeb"].Value = num7;
					l.GetRow(l.Row).Cells["Mariz"].Value = num8;
					l.GetRow(l.Row).Cells["rokhsat"].Value = num5;
					l.GetRow(l.Row).Cells["acp"].Value = 0;
					l.GetRow(l.Row).Cells["countDay"].Value = num3;
					l.GetRow(l.Row).Cells["xYear"].Value = num2;
					l.GetRow(l.Row).EndEdit();
					num = 4;
					continue;
				}
				case 3:
					num = 7;
					continue;
				case 7:
					num4 = ((!(A_1.Column.Key == "CountDay")) ? 1 : 0);
					goto IL_019b;
				case 4:
					return;
				case 8:
					if (true)
					{
					}
					num = 15;
					continue;
				case 15:
					if (!(A_1.Column.Key == "Mariz"))
					{
						num = 10;
						continue;
					}
					goto IL_0085;
				case 10:
					num = 9;
					continue;
				case 9:
					{
						if (!(A_1.Column.Key == "rokhsat"))
						{
							num = 3;
							continue;
						}
						goto IL_0085;
					}
					IL_0085:
					num = 11;
					continue;
					IL_019b:
					flag = (byte)num4 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_c;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 8;
				case 0:
					try
					{
						l.CurrentColumn = l.GetRow(0).Cells["ghayeb"].Column;
						l.Select();
						l.SelectCurrentCellText();
					}
					catch
					{
					}
					if (true)
					{
					}
					this.m_d = m.SelectedIndex;
					num = 9;
					continue;
				case 7:
					this.m_e = false;
					num = 4;
					continue;
				case 4:
					return;
				case 6:
					flag = !this.m_e;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 5;
					continue;
				case 8:
					this.m_e = false;
					this.m_c = true;
					b();
					num = 0;
					continue;
				case 9:
					return;
				case 3:
					this.m_e = true;
					m.SelectedIndex = this.m_d;
					num = 10;
					continue;
				case 10:
					return;
				case 5:
					num = ((!flag) ? 3 : 8);
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		int num11 = default;
		int num7 = default;
		int num12 = default;
		int num9 = default;
		int num5 = default;
		int num4 = default;
		bool flag = default;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 10;
			while (true)
			{
				int num8;
				switch (num3)
				{
				case 10:
				{
					try
					{
						num2 = int.Parse(l.GetRow(0).Cells["CountDay"].Text.ToString());
					}
					catch
					{
						MessageBox.Show("ابتدا تعداد روز ها را وارد کنید");
						return;
					}
					num11 = 0;
					num7 = 0;
					num12 = 0;
					num9 = 0;
					int num13 = 0;
					num5 = 0;
					num4 = 0;
					num3 = 13;
					continue;
				}
				case 28:
					if (num2 > 0)
					{
						num3 = 3;
						continue;
					}
					goto IL_08ad;
				case 25:
					try
					{
						while (true)
						{
							IL_0157:
							flag = !(l.GetRow(num4).Cells["Mariz"].Text != "");
							num3 = 7;
							while (true)
							{
								int num15;
								switch (num3)
								{
								case 7:
									if (!flag)
									{
										num3 = 11;
										continue;
									}
									num12 = 0;
									num3 = 3;
									continue;
								case 0:
									num15 = 0;
									goto IL_01d4;
								case 8:
									num3 = (flag ? 10 : 5);
									continue;
								case 5:
									l.GetRow(num4).Cells["acp"].Value = "-1";
									l.GetRow(num4).EndEdit();
									num3 = 6;
									continue;
								case 6:
									goto end_IL_011e;
								case 1:
									num3 = 4;
									continue;
								case 4:
									num15 = ((num12 <= num2) ? 1 : 0);
									goto IL_01d4;
								case 11:
									num12 = int.Parse(l.GetRow(num4).Cells["Mariz"].Text.ToString());
									num3 = 2;
									continue;
								case 2:
									num3 = ((num12 >= 0) ? 1 : 0);
									continue;
								case 3:
								case 10:
									num3 = 9;
									continue;
								case 9:
									goto IL_0342;
									IL_01d4:
									flag = (byte)num15 != 0;
									num3 = 8;
									continue;
								}
								goto IL_0157;
								continue;
								end_IL_011e:
								break;
							}
							break;
						}
					}
					catch
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["acp"].Value = "-1";
						l.GetRow(num4).EndEdit();
					}
					goto case 12;
				case 29:
					num3 = (flag ? 23 : 5);
					continue;
				case 1:
					num3 = 30;
					continue;
				case 30:
					num8 = ((num9 >= 0) ? 1 : 0);
					goto IL_078f;
				case 15:
					num3 = 18;
					continue;
				case 18:
					if (num11 >= 0)
					{
						num3 = 1;
						continue;
					}
					goto IL_08ad;
				case 16:
					try
					{
						while (true)
						{
							IL_054f:
							flag = !(l.GetRow(num4).Cells["hazer"].Text != "");
							num3 = 5;
							while (true)
							{
								int num16;
								switch (num3)
								{
								case 8:
									goto end_IL_0516;
								case 5:
									if (!flag)
									{
										num3 = 0;
										continue;
									}
									num11 = 0;
									num3 = 3;
									continue;
								case 6:
									num3 = 2;
									continue;
								case 2:
									num16 = ((num11 <= num2) ? 1 : 0);
									goto IL_05b9;
								case 4:
									num3 = (flag ? 11 : 10);
									continue;
								case 0:
									num11 = int.Parse(l.GetRow(num4).Cells["hazer"].Text.ToString());
									num3 = 1;
									continue;
								case 1:
									num3 = ((num11 < 0) ? 7 : 6);
									continue;
								case 7:
									num16 = 0;
									goto IL_05b9;
								case 10:
									l.GetRow(num4).Cells["acp"].Value = "-1";
									l.GetRow(num4).EndEdit();
									num3 = 9;
									continue;
								case 9:
									goto end_IL_0514;
								case 3:
								case 11:
									{
										num3 = 8;
										continue;
									}
									IL_05b9:
									flag = (byte)num16 != 0;
									num3 = 4;
									continue;
								}
								goto IL_054f;
								continue;
								end_IL_0516:
								break;
							}
							break;
						}
						goto IL_032e;
						end_IL_0514:;
					}
					catch
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["acp"].Value = "-1";
						l.GetRow(num4).EndEdit();
					}
					goto case 12;
				case 5:
					l.GetRow(num4).BeginEdit();
					l.GetRow(num4).Cells["acp"].Value = "1";
					l.GetRow(num4).EndEdit();
					num++;
					num3 = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					goto case 12;
				case 26:
				{
					if (!flag)
					{
						num3 = 9;
						continue;
					}
					int num13 = num11 + num7 + num12 + num9;
					flag = num13 == num2;
					num3 = 2;
					continue;
				}
				case 2:
					if (flag)
					{
						int num14 = asdcb.d(asdab.e(), CommandType.Text, "update tHazeriAgo set hazer" + this.__field_b + "=" + num11 + " ,Ghayeb" + this.__field_b + "=" + num7 + " ,Mariz" + this.__field_b + "=" + num12 + " ,rokhsat" + this.__field_b + "=" + num9 + " ,CountDay" + this.__field_b + "=" + num2 + " ,xYear" + this.__field_b + "=" + num5 + " where xStudent=" + l.GetRow(num4).Cells["xStudent"].Value.ToString());
						flag = num14 <= 0;
						num3 = 29;
					}
					else
					{
						num3 = 20;
					}
					continue;
				case 9:
					l.GetRow(num4).BeginEdit();
					l.GetRow(num4).Cells["acp"].Value = "-1";
					l.GetRow(num4).EndEdit();
					num3 = 32;
					continue;
				case 7:
					num3 = 17;
					continue;
				case 17:
					if (num12 >= 0)
					{
						num3 = 15;
						continue;
					}
					goto IL_08ad;
				case 13:
				case 19:
					flag = num4 < l.RowCount;
					num3 = 22;
					continue;
				case 22:
				{
					if (!flag)
					{
						num3 = 11;
						continue;
					}
					num11 = 0;
					num7 = 0;
					num12 = 0;
					num9 = 0;
					int num13 = 0;
					num2 = 0;
					num5 = 0;
					num3 = 8;
					continue;
				}
				case 24:
					num8 = 0;
					goto IL_078f;
				case 31:
					try
					{
						while (true)
						{
							IL_0908:
							flag = !(l.GetRow(num4).Cells["rokhsat"].Text != "");
							num3 = 8;
							while (true)
							{
								int num10;
								switch (num3)
								{
								case 1:
									goto end_IL_08c3;
								case 8:
									if (!flag)
									{
										num3 = 10;
										continue;
									}
									num9 = 0;
									num3 = 5;
									continue;
								case 12:
									num3 = 14;
									continue;
								case 14:
									num10 = ((num9 <= num2) ? 1 : 0);
									goto IL_0a56;
								case 10:
									flag = !(l.GetRow(num4).Cells["rokhsat"].Text != "");
									num3 = 4;
									continue;
								case 4:
									if (!flag)
									{
										num3 = 2;
										continue;
									}
									goto case 3;
								case 3:
									num3 = 6;
									continue;
								case 0:
									num10 = 0;
									goto IL_0a56;
								case 7:
									l.GetRow(num4).Cells["acp"].Value = "-1";
									l.GetRow(num4).EndEdit();
									num3 = 9;
									continue;
								case 9:
									goto end_IL_08c1;
								case 11:
									num3 = ((!flag) ? 7 : 3);
									continue;
								case 2:
									num9 = int.Parse(l.GetRow(num4).Cells["rokhsat"].Text.ToString());
									num3 = 13;
									continue;
								case 13:
									num3 = ((num9 >= 0) ? 12 : 0);
									continue;
								case 5:
								case 6:
									{
										num3 = 1;
										continue;
									}
									IL_0a56:
									flag = (byte)num10 != 0;
									num3 = 11;
									continue;
								}
								goto IL_0908;
								continue;
								end_IL_08c3:
								break;
							}
							break;
						}
						goto IL_00f3;
						end_IL_08c1:;
					}
					catch
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["acp"].Value = "-1";
						l.GetRow(num4).EndEdit();
					}
					goto case 12;
				case 3:
					num3 = 21;
					continue;
				case 21:
					if (num7 >= 0)
					{
						num3 = 7;
						continue;
					}
					goto IL_08ad;
				case 20:
					l.GetRow(num4).BeginEdit();
					l.GetRow(num4).Cells["acp"].Value = "-1";
					l.GetRow(num4).EndEdit();
					num3 = 12;
					continue;
				case 11:
					l.Refresh();
					flag = num <= 0;
					num3 = 33;
					continue;
				case 33:
					if (!flag)
					{
						num3 = 27;
						continue;
					}
					goto case 14;
				case 27:
					MessageBox.Show("تعداد " + num + " ردیف انجام شد");
					num3 = 14;
					continue;
				case 0:
					try
					{
						while (true)
						{
							IL_0c92:
							flag = !(l.GetRow(num4).Cells["Ghayeb"].Text != "");
							num3 = 8;
							while (true)
							{
								int num6;
								switch (num3)
								{
								case 8:
									if (!flag)
									{
										num3 = 7;
										continue;
									}
									num7 = 0;
									num3 = 2;
									continue;
								case 10:
									l.GetRow(num4).Cells["acp"].Value = "-1";
									l.GetRow(num4).EndEdit();
									num3 = 6;
									continue;
								case 6:
									goto end_IL_0c59;
								case 4:
									num6 = 0;
									goto IL_0dd3;
								case 7:
									num7 = int.Parse(l.GetRow(num4).Cells["Ghayeb"].Text.ToString());
									num3 = 0;
									continue;
								case 0:
									num3 = ((num7 >= 0) ? 3 : 4);
									continue;
								case 3:
									num3 = 5;
									continue;
								case 5:
									num6 = ((num7 <= num2) ? 1 : 0);
									goto IL_0dd3;
								case 9:
									num3 = (flag ? 1 : 10);
									continue;
								case 1:
								case 2:
									num3 = 11;
									continue;
								case 11:
									goto IL_0fdb;
									IL_0dd3:
									flag = (byte)num6 != 0;
									num3 = 9;
									continue;
								}
								goto IL_0c92;
								continue;
								end_IL_0c59:
								break;
							}
							break;
						}
					}
					catch
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["acp"].Value = "-1";
						l.GetRow(num4).EndEdit();
					}
					goto case 12;
				case 34:
					try
					{
						num5 = int.Parse(l.GetRow(num4).Cells["xYear"].Text.ToString());
					}
					catch
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["acp"].Value = "-1";
						l.GetRow(num4).EndEdit();
						goto case 12;
					}
					num3 = 16;
					continue;
				case 8:
					try
					{
						num2 = int.Parse(l.GetRow(num4).Cells["CountDay"].Text.ToString());
					}
					catch
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["acp"].Value = "-1";
						l.GetRow(num4).EndEdit();
						goto case 12;
					}
					num3 = 34;
					continue;
				case 14:
					this.m_c = true;
					num3 = 4;
					continue;
				case 4:
					return;
				case 12:
				case 23:
				case 32:
					{
						num4++;
						num3 = 19;
						continue;
					}
					IL_0fdb:
					num3 = 25;
					continue;
					IL_078f:
					flag = (byte)num8 != 0;
					num3 = 26;
					continue;
					IL_00f3:
					num3 = 28;
					continue;
					IL_08ad:
					num3 = 24;
					continue;
					IL_0342:
					num3 = 31;
					continue;
					IL_032e:
					num3 = 0;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.F5;
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
					return;
				case 2:
					l.Refresh();
					b(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_c;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 4:
					return;
				case 0:
					A_1.Cancel = true;
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 2;
					continue;
				case 2:
					num = (flag ? 4 : 0);
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		int num2 = default;
		int num4 = default;
		int num5 = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num6;
				int num3;
				switch (num)
				{
				case 4:
					num = ((t.Text == "") ? 9 : 22);
					continue;
				case 1:
					MessageBox.Show("تعداد روز وارد شده اشتباه است");
					q.Focus();
					num = 0;
					continue;
				case 0:
					return;
				case 3:
					num6 = 0;
					goto IL_0320;
				case 6:
					num = 19;
					continue;
				case 19:
					num6 = ((!(q.Text == "0")) ? 1 : 0);
					goto IL_0320;
				case 17:
					num = ((!(q.Text == "")) ? 6 : 3);
					continue;
				case 2:
					if (!flag)
					{
						num = 25;
						continue;
					}
					num2 = 0;
					num = 11;
					continue;
				case 22:
					num = 8;
					continue;
				case 8:
					num3 = ((!(t.Text == "0")) ? 1 : 0);
					goto IL_0379;
				case 10:
					MessageBox.Show("تعداد روز را وارد کنید");
					q.Focus();
					num = 14;
					continue;
				case 14:
					return;
				case 15:
					num4++;
					num = 7;
					continue;
				case 12:
					MessageBox.Show("سال را وارد کنید");
					t.Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 9:
					num3 = 0;
					goto IL_0379;
				case 18:
					try
					{
						num5 = int.Parse(t.Text);
					}
					catch
					{
						MessageBox.Show("برای سال فقط عدد وارد کنید");
						t.Focus();
						return;
					}
					flag = num5 >= 1380;
					if (true)
					{
					}
					num = 2;
					continue;
				case 16:
					if (flag)
					{
						num5 = 0;
						num = 18;
					}
					else
					{
						num = 10;
					}
					continue;
				case 24:
					if (flag)
					{
						num4 = 0;
						num = 26;
					}
					else
					{
						num = 1;
					}
					continue;
				case 5:
					num = ((!flag) ? 12 : 17);
					continue;
				case 25:
					MessageBox.Show("سال اشتباه است");
					t.Focus();
					num = 20;
					continue;
				case 20:
					return;
				case 7:
				case 26:
					flag = num4 < l.RowCount;
					num = 21;
					continue;
				case 21:
					if (flag)
					{
						l.GetRow(num4).BeginEdit();
						l.GetRow(num4).Cells["CountDay"].Value = num2;
						l.GetRow(num4).Cells["xYear"].Value = num5;
						l.GetRow(num4).EndEdit();
						num = 15;
					}
					else
					{
						num = 23;
					}
					continue;
				case 23:
					return;
				case 11:
					{
						try
						{
							num2 = int.Parse(q.Text);
						}
						catch
						{
							MessageBox.Show("تعداد روز را فقط عدد وارد کنید");
							q.Focus();
							return;
						}
						flag = num2 >= 100;
						num = 24;
						continue;
					}
					IL_0379:
					flag = (byte)num3 != 0;
					num = 5;
					continue;
					IL_0320:
					flag = (byte)num6 != 0;
					num = 16;
					continue;
				}
				break;
			}
		}
	}
protected override void Dispose(bool A_0)
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
					num = ((!A_0) ? 4 : 2);
					continue;
				case 2:
					num = 5;
					continue;
				case 5:
					num2 = ((f == null) ? 1 : 0);
					goto IL_0074;
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 1:
					if (true)
					{
					}
					f.Dispose();
					num = 0;
					continue;
				case 4:
					num2 = 1;
					goto IL_0074;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdaq));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		g = new Panel();
		h = new Panel();
		i = new Panel();
		v = new Label();
		t = new EditBox();
		u = new Label();
		s = new Button();
		q = new EditBox();
		r = new Label();
		p = new UIButton();
		o = new Label();
		m = new UIComboBox();
		n = new Label();
		j = new Label();
		k = new UIButton();
		l = new GridEX();
		g.SuspendLayout();
		h.SuspendLayout();
		i.SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		SuspendLayout();
		g.BackColor = Color.FromArgb(214, 223, 247);
		g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		g.Controls.Add(h);
		g.Dock = DockStyle.Fill;
		g.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		g.Location = new Point(0, 0);
		g.Name = "panel1";
		g.Size = new Size(700, 671);
		g.TabIndex = 0;
		h.BackColor = Color.Black;
		h.Controls.Add(i);
		h.Dock = DockStyle.Fill;
		h.Location = new Point(0, 0);
		h.Name = "panel2";
		h.Size = new Size(698, 669);
		h.TabIndex = 44;
		i.BackColor = Color.FromArgb(214, 223, 247);
		i.Controls.Add(v);
		i.Controls.Add(t);
		i.Controls.Add(u);
		i.Controls.Add(s);
		i.Controls.Add(q);
		i.Controls.Add(r);
		i.Controls.Add(p);
		i.Controls.Add(o);
		i.Controls.Add(m);
		i.Controls.Add(n);
		i.Controls.Add(j);
		i.Controls.Add(k);
		i.Controls.Add(l);
		i.Location = new Point(3, 3);
		i.Name = "panel3";
		i.Size = new Size(692, 663);
		i.TabIndex = 0;
		v.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		v.ForeColor = Color.DarkViolet;
		v.Location = new Point(228, 5);
		v.Name = "lheder";
		v.Size = new Size(386, 37);
		v.TabIndex = 127;
		v.Text = "ثبت وضعیت حاضری سنوات قبل صنف دوازدهم";
		v.TextAlign = ContentAlignment.MiddleCenter;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.Location = new Point(21, 6);
		t.Name = "txtYear";
		t.RightToLeft = RightToLeft.No;
		t.Size = new Size(83, 33);
		t.TabIndex = 1;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.AutoSize = true;
		u.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(110, 15);
		u.Name = "label2";
		u.Size = new Size(29, 20);
		u.TabIndex = 125;
		u.Text = "سال";
		s.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		s.Location = new Point(21, 82);
		s.Name = "btnMarkAll";
		s.Size = new Size(219, 33);
		s.TabIndex = 3;
		s.Text = "کپی کردن سال و تعداد روز برای همه";
		s.UseVisualStyleBackColor = true;
		s.Click += a;
		q.AutoScroll = false;
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		q.AutoScrollPosition = new Point(0, 0);
		q.Location = new Point(21, 45);
		q.Name = "txtSumYear";
		q.RightToLeft = RightToLeft.No;
		q.Size = new Size(83, 33);
		q.TabIndex = 2;
		q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		r.AutoSize = true;
		r.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Location = new Point(110, 54);
		r.Name = "label1";
		r.Size = new Size(134, 20);
		r.TabIndex = 121;
		r.Text = "تعداد روز ایام سال تحصیلی";
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		p.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		p.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		p.ImageIndex = 8;
		p.Location = new Point(529, 620);
		p.Name = "btnAcp";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(153, 40);
		p.TabIndex = 120;
		p.Text = "ثبت (F5)";
		p.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		p.Click += b;
		o.BackColor = Color.FromArgb(255, 224, 192);
		o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		o.Location = new Point(428, 50);
		o.Name = "lterm";
		o.Size = new Size(144, 27);
		o.TabIndex = 119;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		m.DropListFont = new Font("B Nazanin", 12f);
		m.Location = new Point(430, 82);
		m.Name = "dropCls";
		m.Size = new Size(142, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		m.StringFormat = stringFormat;
		m.TabIndex = 52;
		m.SelectedIndexChanged += c;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.AutoSize = true;
		n.Location = new Point(578, 88);
		n.Name = "label19";
		n.Size = new Size(41, 26);
		n.TabIndex = 51;
		n.Text = "صنف";
		j.AutoSize = true;
		j.Font = new Font("B Nazanin", 14f);
		j.Location = new Point(577, 48);
		j.Name = "label7";
		j.Size = new Size(105, 28);
		j.TabIndex = 50;
		j.Text = "وضعیت حاضری";
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		k.DialogResult = DialogResult.Cancel;
		k.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		k.ImageSize = new Size(40, 40);
		k.Location = new Point(11, 620);
		k.Name = "btnClose";
		k.Size = new Size(124, 38);
		k.TabIndex = 44;
		k.Text = "بستن";
		k.Click += d;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		l.DesignTimeLayout = gridEXLayout;
		l.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		l.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		l.Font = new Font("Tahoma", 9.75f);
		l.GroupByBoxVisible = false;
		l.Location = new Point(8, 125);
		l.Name = "gridEX1";
		l.RecordNavigator = true;
		l.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		l.SelectedFormatStyle.BackColor = Color.Empty;
		l.SelectedFormatStyle.ForeColor = Color.Empty;
		l.Size = new Size(676, 491);
		l.TabIndex = 45;
		l.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		l.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(700, 671);
		Controls.Add(g);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmHazeriAgo";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += e;
		KeyUp += a;
		FormClosing += a;
		g.ResumeLayout(performLayout: false);
		h.ResumeLayout(performLayout: false);
		i.ResumeLayout(performLayout: false);
		i.PerformLayout();
		((ISupportInitialize)l).EndInit();
		ResumeLayout(performLayout: false);
	}
}
