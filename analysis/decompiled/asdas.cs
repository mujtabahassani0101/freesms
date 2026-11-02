using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using CrystalDecisions.CrystalReports.Engine;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using school_Af.Rpt.Dis;

public class asdas : Form
{
	private string m_a = "";

	private string m_b = "";

	private string m_c = "";

	private IContainer m_d = null;

	private GridEX m_e;

	private UIButton m_f;

	private UIButton g;

	private Label h;

	private UIComboBox i;

	private GridEX j;

	private GridEX k;

	private Label l;

	private DatePicker m;

	private Label n;

	private DatePicker o;

	private UIComboBox p;

	private Label q;

	private Label r;

	private Label s;

	private UIComboBox t;

	public asdas()
	{
		a();
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptDis");
		this.m_e.DataSource = dataSource;
		d();
		c();
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + t.SelectedValue.ToString() + ") order by id");
			i.Items.Add("کل", (object)"0");
			int num = 0;
			if (true)
			{
			}
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 1:
					flag = num < dataTable.Rows.Count;
					num2 = 2;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 3;
						continue;
					}
					i.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 1;
					continue;
				case 3:
					i.SelectedIndex = 0;
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
			string text = "";
			bool flag = i.SelectedIndex <= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 2:
					text = " where xPaye=" + i.SelectedValue.ToString();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass" + text);
					j.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		string text7 = default;
		ReportClass val = default;
		bool flag = default;
		string text4 = default;
		string[] array = default;
		SqlParameter[] a_ = default;
		DataTable dataSource2 = default;
		string text6 = default;
		while (true)
		{
			string text = this.m_e.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text2 = this.m_e.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			string text3 = "";
			int num = 0;
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 11:
					num2 = 19;
					continue;
				case 19:
					if (!(text7 == "crDis_AmarAbsentClass"))
					{
						num2 = 12;
						continue;
					}
					val = (ReportClass)(object)new crDis_AmarAbsentClass();
					num2 = 36;
					continue;
				case 51:
					flag = !(text4 != "");
					num2 = 4;
					continue;
				case 4:
					if (!flag)
					{
						num2 = 7;
						continue;
					}
					goto case 30;
				case 57:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_);
					((ReportDocument)val).Subreports[array[2].ToString()].SetDataSource(dataSource);
					num2 = 53;
					continue;
				}
				case 1:
				case 14:
					flag = num < k.RowCount;
					num2 = 27;
					continue;
				case 27:
					if (!flag)
					{
						num2 = 34;
						continue;
					}
					flag = !(k.GetRow(num).Cells["Selector"].Value.ToString() == "True");
					num2 = 43;
					continue;
				case 9:
					((ReportDocument)val).SetDataSource(dataSource2);
					num2 = 49;
					continue;
				case 22:
					num2 = 10;
					continue;
				case 10:
					if (!(text7 == "crDis_ListStdAbsent2"))
					{
						num2 = 11;
						continue;
					}
					val = (ReportClass)(object)new crDis_ListStdAbsent2();
					num2 = 8;
					continue;
				case 30:
					text4 += j.GetRow(num).Cells["id"].Value.ToString();
					num2 = 15;
					continue;
				case 28:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_);
					((ReportDocument)val).Subreports[array[4].ToString()].SetDataSource(dataSource);
					num2 = 25;
					continue;
				}
				case 32:
					return;
				case 16:
					num3 = 1;
					goto IL_051a;
				case 43:
					if (!flag)
					{
						num2 = 24;
						continue;
					}
					goto case 44;
				case 20:
					if (!flag)
					{
						num2 = 51;
						continue;
					}
					goto case 15;
				case 34:
					text4 = "";
					num = 0;
					num2 = 21;
					continue;
				case 15:
					num++;
					num2 = 3;
					continue;
				case 25:
					num2 = 9;
					continue;
				case 35:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_);
					((ReportDocument)val).Subreports[array[0].ToString()].SetDataSource(dataSource);
					num2 = 56;
					continue;
				}
				case 31:
					num2 = 54;
					continue;
				case 54:
					num3 = ((!(text3 == "")) ? 1 : 0);
					goto IL_051a;
				case 48:
					if (!flag)
					{
						num2 = 23;
						continue;
					}
					goto case 38;
				case 39:
					flag = !(text4 == "");
					num2 = 40;
					continue;
				case 40:
					num2 = (flag ? 45 : 42);
					continue;
				case 7:
					text4 += ",";
					num2 = 30;
					continue;
				case 56:
					flag = array.Length <= 3;
					num2 = 47;
					continue;
				case 47:
					if (!flag)
					{
						num2 = 57;
						continue;
					}
					goto case 53;
				case 42:
					MessageBox.Show("صنفی انتخاب نشده است");
					num2 = 17;
					continue;
				case 17:
					return;
				case 3:
				case 21:
					flag = num < j.RowCount;
					num2 = 50;
					continue;
				case 50:
					if (flag)
					{
						flag = !(j.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 20;
					}
					else
					{
						num2 = 39;
					}
					continue;
				case 44:
					num++;
					num2 = 14;
					continue;
				case 12:
					num2 = 0;
					continue;
				case 0:
					if (text7 == "crDis_KarnameStd")
					{
						val = (ReportClass)(object)new crDis_KarnameStd();
						num2 = 13;
					}
					else
					{
						num2 = 46;
					}
					continue;
				case 24:
					flag = !(text3 != "");
					num2 = 18;
					continue;
				case 18:
					if (!flag)
					{
						num2 = 5;
						continue;
					}
					goto case 26;
				case 29:
					num2 = 41;
					continue;
				case 41:
					if (text7 == "crDis_ListStdAbsent")
					{
						val = (ReportClass)(object)new crDis_ListStdAbsent();
						num2 = 37;
					}
					else
					{
						num2 = 22;
					}
					continue;
				case 23:
					text3 = "0";
					num2 = 38;
					continue;
				case 53:
					flag = array.Length <= 5;
					num2 = 2;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 28;
						continue;
					}
					goto case 25;
				case 38:
					a_ = new SqlParameter[4]
					{
						asdcb.a("@datefrom", SqlDbType.NVarChar, 10, ShamsiDate.GetShamsiDate(o.the_date)),
						asdcb.a("@dateto", SqlDbType.NVarChar, 10, ShamsiDate.GetShamsiDate(m.the_date)),
						asdcb.a("@xDisciplinaryCases", SqlDbType.VarChar, text3),
						asdcb.a("@Class", SqlDbType.VarChar, text4)
					};
					dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_e.SelectedItems[0].GetRow().Cells["sp"].Value.ToString(), a_);
					val = null;
					text7 = text;
					num2 = 33;
					continue;
				case 33:
					if (text7 != null)
					{
						num2 = 29;
						continue;
					}
					goto case 8;
				case 49:
				{
					try
					{
						while (true)
						{
							IL_08da:
							string text5 = o.the_date.DayOfWeek.ToString();
							flag = !(text5 == "Saturday");
							num2 = 11;
							while (true)
							{
								switch (num2)
								{
								case 11:
									if (!flag)
									{
										num2 = 13;
										continue;
									}
									flag = !(text5 == "Sunday");
									num2 = 30;
									continue;
								case 10:
									text6 = "یکشنبه";
									num2 = 23;
									continue;
								case 33:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									flag = !(text5 == "Wednesday");
									num2 = 19;
									continue;
								case 31:
									text6 = "چهارشنبه";
									num2 = 12;
									continue;
								case 15:
									if (!flag)
									{
										num2 = 7;
										continue;
									}
									flag = !(text6 == "Wednesday");
									num2 = 9;
									continue;
								case 40:
									if (!flag)
									{
										num2 = 25;
										continue;
									}
									flag = !(text6 == "Friday");
									num2 = 35;
									continue;
								case 9:
									if (flag)
									{
										flag = !(text6 == "Thursday");
										num2 = 40;
									}
									else
									{
										num2 = 31;
									}
									continue;
								case 14:
									if (flag)
									{
										flag = !(text5 == "Tuesday");
										num2 = 33;
									}
									else
									{
										num2 = 0;
									}
									continue;
								case 2:
									text6 = "شنبه";
									num2 = 24;
									continue;
								case 19:
									if (!flag)
									{
										num2 = 39;
										continue;
									}
									flag = !(text5 == "Thursday");
									num2 = 42;
									continue;
								case 26:
									text5 = "جمعه";
									num2 = 36;
									continue;
								case 32:
									text5 = "یکشنبه";
									num2 = 5;
									continue;
								case 7:
									text6 = "سه شنبه";
									num2 = 27;
									continue;
								case 5:
								case 6:
								case 18:
								case 28:
								case 34:
								case 36:
								case 37:
									text6 = m.the_date.DayOfWeek.ToString();
									flag = !(text6 == "Saturday");
									num2 = 21;
									continue;
								case 21:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									flag = !(text6 == "Sunday");
									num2 = 20;
									continue;
								case 42:
									if (!flag)
									{
										num2 = 29;
										continue;
									}
									flag = !(text5 == "Friday");
									num2 = 41;
									continue;
								case 39:
									text5 = "چهارشنبه";
									num2 = 18;
									continue;
								case 29:
									text5 = "پنج شنبه";
									num2 = 37;
									continue;
								case 20:
									if (!flag)
									{
										num2 = 10;
										continue;
									}
									flag = !(text6 == "Monday");
									num2 = 38;
									continue;
								case 35:
									if (!flag)
									{
										num2 = 22;
										continue;
									}
									goto case 1;
								case 4:
									text5 = "سه شنبه";
									num2 = 28;
									continue;
								case 41:
									if (!flag)
									{
										num2 = 26;
										continue;
									}
									goto case 5;
								case 38:
									if (flag)
									{
										flag = !(text6 == "Tuesday");
										num2 = 15;
									}
									else
									{
										num2 = 8;
									}
									continue;
								case 25:
									text6 = "پنج شنبه";
									num2 = 17;
									continue;
								case 0:
									text5 = "دوشنبه";
									num2 = 34;
									continue;
								case 13:
									text5 = "شنبه";
									num2 = 6;
									continue;
								case 30:
									if (flag)
									{
										flag = !(text5 == "Monday");
										num2 = 14;
									}
									else
									{
										num2 = 32;
									}
									continue;
								case 8:
									text6 = "دوشنبه";
									num2 = 16;
									continue;
								case 22:
									text6 = "جمعه";
									num2 = 1;
									continue;
								case 1:
								case 12:
								case 16:
								case 17:
								case 23:
								case 24:
								case 27:
									((ReportDocument)val).ParameterFields["dayfrom"].CurrentValues.AddValue((object)text5);
									((ReportDocument)val).ParameterFields["dayTo"].CurrentValues.AddValue((object)text6);
									((ReportDocument)val).ParameterFields["dateFrom"].CurrentValues.AddValue((object)ShamsiDate.GetShamsiDate(o.the_date));
									((ReportDocument)val).ParameterFields["dateTo"].CurrentValues.AddValue((object)ShamsiDate.GetShamsiDate(m.the_date));
									((ReportDocument)val).ParameterFields["sch"].CurrentValues.AddValue((object)asdcb.a(asdab.e(), CommandType.Text, "SELECT     sch FROM  tParmetr").ToString());
									num2 = 3;
									continue;
								case 3:
									goto end_IL_0825;
								}
								goto IL_08da;
								continue;
								end_IL_0825:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					asdbc asdbc2 = new asdbc();
					asdbc2.c = val;
					((Form)asdbc2).ShowDialog();
					num2 = 32;
					continue;
				}
				case 26:
					text3 += k.GetRow(num).Cells["id"].Value.ToString();
					if (true)
					{
					}
					num2 = 44;
					continue;
				case 5:
					text3 += ",";
					num2 = 26;
					continue;
				case 46:
					num2 = 55;
					continue;
				case 45:
					num2 = (((Control)k).Visible ? 31 : 16);
					continue;
				case 6:
					array = text2.Split(new char[1] { ',' });
					flag = array.Length <= 1;
					num2 = 58;
					continue;
				case 58:
					if (!flag)
					{
						num2 = 35;
						continue;
					}
					goto case 56;
				case 8:
				case 13:
				case 36:
				case 37:
				case 55:
					flag = !(text2 != "");
					num2 = 52;
					continue;
				case 52:
					{
						if (!flag)
						{
							num2 = 6;
							continue;
						}
						goto case 9;
					}
					IL_051a:
					flag = (byte)num3 != 0;
					num2 = 48;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			int num = 10;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(this.m_a == "2");
					num = 20;
					continue;
				case 18:
					if (flag)
					{
						flag = !(this.m_a == "1");
						num = 0;
					}
					else
					{
						num = 9;
					}
					continue;
				case 23:
					((Control)p).Visible = false;
					((Control)q).Visible = false;
					((Control)k).Visible = true;
					a(this.m_b);
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					((Control)n).Visible = true;
					((Control)o).Visible = true;
					((Control)l).Visible = false;
					((Control)m).Visible = false;
					num = 5;
					continue;
				case 15:
					num2 = 0;
					goto IL_0259;
				case 20:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 5;
				case 24:
					((Control)p).Visible = true;
					((Control)q).Visible = true;
					((Control)k).Visible = true;
					p.SelectedIndex = 0;
					num = 14;
					continue;
				case 14:
					return;
				case 22:
					if (!flag)
					{
						num = 23;
						continue;
					}
					flag = !(this.m_b == "123");
					num = 2;
					continue;
				case 2:
					if (flag)
					{
						flag = !(this.m_b == "0");
						num = 17;
					}
					else
					{
						num = 24;
					}
					continue;
				case 11:
					if (true)
					{
					}
					((Control)p).Visible = false;
					((Control)q).Visible = false;
					((Control)k).Visible = false;
					num = 7;
					continue;
				case 7:
					return;
				case 9:
					((Control)n).Visible = false;
					((Control)o).Visible = false;
					((Control)l).Visible = false;
					((Control)m).Visible = false;
					num = 16;
					continue;
				case 6:
					num = 21;
					continue;
				case 21:
					if (!(this.m_b == "2"))
					{
						num = 19;
						continue;
					}
					goto IL_01c1;
				case 12:
					((Control)n).Visible = true;
					((Control)o).Visible = true;
					((Control)l).Visible = true;
					((Control)m).Visible = true;
					num = 13;
					continue;
				case 5:
				case 13:
				case 16:
					num = 1;
					continue;
				case 1:
					if (!(this.m_b == "1"))
					{
						num = 6;
						continue;
					}
					goto IL_01c1;
				case 10:
					try
					{
						while (true)
						{
							IL_0423:
							num = 0;
							while (true)
							{
								int num3;
								switch (num)
								{
								case 0:
									num = ((this.m_e.RowCount <= 0) ? 1 : 3);
									continue;
								case 3:
									num = 5;
									continue;
								case 5:
									num3 = (((int)this.m_e.SelectedItems[0].RowType != 0) ? 1 : 0);
									goto IL_0484;
								case 1:
									num3 = 1;
									goto IL_0484;
								case 4:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 7;
								case 2:
									this.m_a = this.m_e.SelectedItems[0].GetRow().Cells["dayFilter"].Value.ToString();
									this.m_b = this.m_e.SelectedItems[0].GetRow().Cells["typeFilter"].Value.ToString();
									num = 7;
									continue;
								case 7:
									num = 6;
									continue;
								case 6:
									goto end_IL_03fa;
									IL_0484:
									flag = (byte)num3 != 0;
									num = 4;
									continue;
								}
								goto IL_0423;
								continue;
								end_IL_03fa:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					flag = !(this.m_a == "0");
					num = 18;
					continue;
				case 19:
					num = 8;
					continue;
				case 8:
					{
						num2 = ((!(this.m_b == "3")) ? 1 : 0);
						goto IL_0259;
					}
					IL_01c1:
					num = 15;
					continue;
					IL_0259:
					flag = (byte)num2 != 0;
					num = 22;
					continue;
				}
				break;
			}
		}
	}

	private void a(string A_0)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = !(this.m_c != A_0);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    *   FROM  tDisciplinaryCases where typ in(" + A_0 + ")");
					k.DataSource = dataSource;
					this.m_c = A_0;
					num = 1;
					continue;
				}
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = p.SelectedIndex != 0;
			if (true)
			{
			}
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					a(p.SelectedValue.ToString());
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					a("1,2,3");
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)r).Visible = ((Control)k).Visible;
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					num = ((!A_0) ? 1 : 4);
					continue;
				case 4:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_d == null) ? 1 : 0);
					goto IL_0074;
				case 2:
					this.m_d.Dispose();
					num = 0;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 1:
					num2 = 1;
					goto IL_0074;
				case 0:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected Obj, but got Unknown
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected Obj, but got Unknown
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Expected Obj, but got Unknown
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0feb: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdas));
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
		GridEXLayout val4 = new GridEXLayout();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		StringFormat val9 = new StringFormat();
		UIComboBoxItem val10 = new UIComboBoxItem();
		UIComboBoxItem val11 = new UIComboBoxItem();
		UIComboBoxItem val12 = new UIComboBoxItem();
		UIComboBoxItem val13 = new UIComboBoxItem();
		UIComboBoxItem val14 = new UIComboBoxItem();
		UIComboBoxItem val15 = new UIComboBoxItem();
		StringFormat val16 = new StringFormat();
		this.m_e = new GridEX();
		this.m_f = new UIButton();
		g = new UIButton();
		h = new Label();
		i = new UIComboBox();
		j = new GridEX();
		k = new GridEX();
		l = new Label();
		m = new DatePicker();
		n = new Label();
		o = new DatePicker();
		p = new UIComboBox();
		q = new Label();
		r = new Label();
		s = new Label();
		t = new UIComboBox();
		((ISupportInitialize)this.m_e).BeginInit();
		((ISupportInitialize)j).BeginInit();
		((ISupportInitialize)k).BeginInit();
		((Control)this).SuspendLayout();
		this.m_e.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_e).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_e.DesignTimeLayout = val;
		this.m_e.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		this.m_e.GroupByBoxVisible = false;
		((Control)this.m_e).Location = new Point(232, 18);
		((Control)this.m_e).Name = "gridEX1";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		this.m_e.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_e).Size = new Size(548, 319);
		((Control)this.m_e).TabIndex = 0;
		((ScrollableBase)this.m_e).VisualStyle = (VisualStyle)2;
		this.m_e.SelectionChanged += c;
		((Control)this.m_f).Anchor = (AnchorStyles)6;
		((Control)this.m_f).Location = new Point(12, 479);
		((Control)this.m_f).Name = "btnview";
		((Control)this.m_f).Size = new Size(131, 38);
		((Control)this.m_f).TabIndex = 1;
		((Control)this.m_f).Text = "نمایش گزارش";
		((Control)this.m_f).Click += e;
		((Control)g).Anchor = (AnchorStyles)6;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(40, 40);
		((Control)g).Location = new Point(12, 523);
		((Control)g).Name = "btnClose";
		((Control)g).Size = new Size(131, 30);
		((Control)g).TabIndex = 110;
		((Control)g).Text = "بستن";
		((Control)g).Click += d;
		((Control)h).Anchor = (AnchorStyles)9;
		((Control)h).AutoSize = true;
		((Control)h).Location = new Point(181, 58);
		((Control)h).Name = "label20";
		((Control)h).Size = new Size(22, 13);
		((Control)h).TabIndex = 126;
		((Control)h).Text = "پایه";
		((Control)i).Anchor = (AnchorStyles)9;
		((UIComboBase)i).ComboStyle = (ComboStyle)1;
		((UIComboBase)i).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)i).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)i).Location = new Point(12, 55);
		((Control)i).Name = "dropPaye";
		((Control)i).Size = new Size(164, 20);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)i).StringFormat = val2;
		((Control)i).TabIndex = 125;
		((Control)j).Anchor = (AnchorStyles)10;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		j.DesignTimeLayout = val3;
		j.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)j).Font = new Font("B Nazanin", 9.75f, (FontStyle)1);
		j.GroupByBoxVisible = false;
		((Control)j).Location = new Point(12, 90);
		((Control)j).Name = "gClass";
		j.RowHeaders = (InheritableBoolean)1;
		((Control)j).Size = new Size(193, 247);
		((Control)j).TabIndex = 124;
		((ScrollableBase)j).VisualStyle = (VisualStyle)2;
		((Control)k).Anchor = (AnchorStyles)10;
		val4.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		k.DesignTimeLayout = val4;
		k.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)k).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		k.GroupByBoxVisible = false;
		((Control)k).Location = new Point(232, 379);
		((Control)k).Name = "gDis";
		k.RowHeaders = (InheritableBoolean)1;
		((Control)k).Size = new Size(546, 162);
		((Control)k).TabIndex = 127;
		((ScrollableBase)k).VisualStyle = (VisualStyle)2;
		((Control)k).VisibleChanged += a;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(162, 436);
		((Control)l).Name = "lDatato";
		((Control)l).Size = new Size(44, 13);
		((Control)l).TabIndex = 131;
		((Control)l).Text = "تا تاریخ :";
		m.AutoToday = true;
		((Control)m).BackColor = Color.SeaShell;
		m.BijanForeColor = Color.Blue;
		((Control)m).Location = new Point(12, 432);
		((Control)m).Name = "txtDatato";
		((Control)m).Size = new Size(144, 24);
		((Control)m).TabIndex = 129;
		m.the_date = new DateTime(2024, 2, 8, 9, 45, 47, 638);
		m.the_label = "ازمون تاريخ:";
		((Control)n).AutoSize = true;
		((Control)n).Location = new Point(162, 398);
		((Control)n).Name = "lDatafrom";
		((Control)n).Size = new Size(45, 13);
		((Control)n).TabIndex = 130;
		((Control)n).Text = "از تاریخ :";
		o.AutoToday = true;
		((Control)o).BackColor = Color.SeaShell;
		o.BijanForeColor = Color.Blue;
		((Control)o).Location = new Point(12, 393);
		((Control)o).Name = "txtDatafrom";
		((Control)o).Size = new Size(144, 24);
		((Control)o).TabIndex = 128;
		o.the_date = new DateTime(2024, 2, 8, 9, 45, 47, 641);
		o.the_label = "ازمون تاريخ:";
		((UIComboBase)p).ComboStyle = (ComboStyle)1;
		((UIComboBase)p).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)p).Font = new Font("Tahoma", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val5.FormatStyle.Alpha = 0;
		val5.Text = "همه موارد";
		val5.Value = "0";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "انضباطی";
		val6.Value = "1";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "اخطار آموزشی";
		val7.Value = "3";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "تشویقی";
		val8.Value = "2";
		p.Items.AddRange(new UIComboBoxItem[4] { val5, val6, val7, val8 });
		((Control)p).Location = new Point(558, 346);
		((Control)p).Name = "dropFilterType";
		((Control)p).Size = new Size(184, 24);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)p).StringFormat = val9;
		((Control)p).TabIndex = 132;
		p.SelectedIndexChanged += b;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(745, 353);
		((Control)q).Name = "lFilterType";
		((Control)q).Size = new Size(34, 13);
		((Control)q).TabIndex = 133;
		((Control)q).Text = "مورد :";
		r.BorderStyle = (BorderStyle)1;
		((Control)r).ForeColor = Color.FromArgb(192, 0, 0);
		((Control)r).Location = new Point(232, 353);
		((Control)r).Name = "ltextDis";
		((Control)r).Size = new Size(308, 23);
		((Control)r).TabIndex = 134;
		((Control)r).Text = "مواردی که نمی خواهید در گزارش نمایش داده شود را تیک بزنید";
		r.TextAlign = (ContentAlignment)32;
		((Control)r).Visible = false;
		((Control)s).AutoSize = true;
		((Control)s).Location = new Point(116, 32);
		((Control)s).Name = "label8";
		((Control)s).Size = new Size(66, 13);
		((Control)s).TabIndex = 136;
		((Control)s).Text = "سال تعلیمی";
		((UIComboBase)t).ComboStyle = (ComboStyle)1;
		((UIComboBase)t).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val10.FormatStyle.Alpha = 0;
		val10.Text = "1403";
		val10.Value = "1403";
		val11.FormatStyle.Alpha = 0;
		val11.Text = "1402";
		val11.Value = "1402";
		val12.FormatStyle.Alpha = 0;
		val12.Text = "1401";
		val12.Value = "1401";
		val13.FormatStyle.Alpha = 0;
		val13.Text = "1400";
		val13.Value = "1400";
		val14.FormatStyle.Alpha = 0;
		val14.Text = "1399";
		val14.Value = "1399";
		val15.FormatStyle.Alpha = 0;
		val15.Text = "1398";
		val15.Value = "1398";
		t.Items.AddRange(new UIComboBoxItem[6] { val10, val11, val12, val13, val14, val15 });
		((Control)t).Location = new Point(12, 26);
		((Control)t).Name = "dropYear";
		((Control)t).Size = new Size(97, 23);
		val16.Alignment = (StringAlignment)0;
		val16.FormatFlags = (StringFormatFlags)20485;
		val16.HotkeyPrefix = (HotkeyPrefix)0;
		val16.LineAlignment = (StringAlignment)1;
		val16.Trimming = (StringTrimming)1;
		((UIComboBase)t).StringFormat = val16;
		((Control)t).TabIndex = 135;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(792, 566);
		((Control)this).Controls.Add((Control)(object)s);
		((Control)this).Controls.Add((Control)(object)t);
		((Control)this).Controls.Add((Control)(object)r);
		((Control)this).Controls.Add((Control)(object)q);
		((Control)this).Controls.Add((Control)(object)p);
		((Control)this).Controls.Add((Control)(object)l);
		((Control)this).Controls.Add((Control)(object)m);
		((Control)this).Controls.Add((Control)(object)n);
		((Control)this).Controls.Add((Control)(object)o);
		((Control)this).Controls.Add((Control)(object)k);
		((Control)this).Controls.Add((Control)(object)h);
		((Control)this).Controls.Add((Control)(object)i);
		((Control)this).Controls.Add((Control)(object)j);
		((Control)this).Controls.Add((Control)(object)g);
		((Control)this).Controls.Add((Control)(object)this.m_f);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmRptDis";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "گزارش موارد انضباطی";
		((Form)this).Load += f;
		((ISupportInitialize)this.m_e).EndInit();
		((ISupportInitialize)j).EndInit();
		((ISupportInitialize)k).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
