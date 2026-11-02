using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
			i.Items.Add("کل", "0");
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
					i.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
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
		string text7 = default;
		ReportClass reportClass = default;
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
					reportClass = new crDis_AmarAbsentClass();
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
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource);
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
					reportClass.SetDataSource(dataSource2);
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
					reportClass = new crDis_ListStdAbsent2();
					num2 = 8;
					continue;
				case 30:
					text4 += j.GetRow(num).Cells["id"].Value.ToString();
					num2 = 15;
					continue;
				case 28:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_);
					reportClass.Subreports[array[4].ToString()].SetDataSource(dataSource);
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
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource);
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
						reportClass = new crDis_KarnameStd();
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
						reportClass = new crDis_ListStdAbsent();
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
					reportClass = null;
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
									reportClass.ParameterFields["dayfrom"].CurrentValues.AddValue(text5);
									reportClass.ParameterFields["dayTo"].CurrentValues.AddValue(text6);
									reportClass.ParameterFields["dateFrom"].CurrentValues.AddValue(ShamsiDate.GetShamsiDate(o.the_date));
									reportClass.ParameterFields["dateTo"].CurrentValues.AddValue(ShamsiDate.GetShamsiDate(m.the_date));
									reportClass.ParameterFields["sch"].CurrentValues.AddValue(asdcb.a(asdab.e(), CommandType.Text, "SELECT     sch FROM  tParmetr").ToString());
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
					asdbc2.c = reportClass;
					asdbc2.ShowDialog();
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
					num2 = (k.Visible ? 31 : 16);
					continue;
				case 6:
					array = text2.Split(',');
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
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
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
					p.Visible = false;
					q.Visible = false;
					k.Visible = true;
					a(this.m_b);
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					n.Visible = true;
					o.Visible = true;
					l.Visible = false;
					m.Visible = false;
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
					p.Visible = true;
					q.Visible = true;
					k.Visible = true;
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
					p.Visible = false;
					q.Visible = false;
					k.Visible = false;
					num = 7;
					continue;
				case 7:
					return;
				case 9:
					n.Visible = false;
					o.Visible = false;
					l.Visible = false;
					m.Visible = false;
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
					n.Visible = true;
					o.Visible = true;
					l.Visible = true;
					m.Visible = true;
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
									num3 = ((this.m_e.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
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
		r.Visible = k.Visible;
	}
protected override void Dispose(bool A_0)
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
						base.Dispose(A_0);
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
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdas));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		GridEXLayout gridEXLayout3 = new GridEXLayout();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		StringFormat stringFormat2 = new StringFormat();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem10 = new UIComboBoxItem();
		StringFormat stringFormat3 = new StringFormat();
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
		SuspendLayout();
		this.m_e.AllowEdit = InheritableBoolean.False;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_e.DesignTimeLayout = gridEXLayout;
		this.m_e.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.GroupByBoxVisible = false;
		this.m_e.Location = new Point(232, 18);
		this.m_e.Name = "gridEX1";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.RowHeaders = InheritableBoolean.True;
		this.m_e.Size = new Size(548, 319);
		this.m_e.TabIndex = 0;
		this.m_e.VisualStyle = VisualStyle.Office2003;
		this.m_e.SelectionChanged += c;
		this.m_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_f.Location = new Point(12, 479);
		this.m_f.Name = "btnview";
		this.m_f.Size = new Size(131, 38);
		this.m_f.TabIndex = 1;
		this.m_f.Text = "نمایش گزارش";
		this.m_f.Click += e;
		g.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(40, 40);
		g.Location = new Point(12, 523);
		g.Name = "btnClose";
		g.Size = new Size(131, 30);
		g.TabIndex = 110;
		g.Text = "بستن";
		g.Click += d;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.AutoSize = true;
		h.Location = new Point(181, 58);
		h.Name = "label20";
		h.Size = new Size(22, 13);
		h.TabIndex = 126;
		h.Text = "پایه";
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		i.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		i.Location = new Point(12, 55);
		i.Name = "dropPaye";
		i.Size = new Size(164, 20);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		i.StringFormat = stringFormat;
		i.TabIndex = 125;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		j.DesignTimeLayout = gridEXLayout2;
		j.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		j.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold);
		j.GroupByBoxVisible = false;
		j.Location = new Point(12, 90);
		j.Name = "gClass";
		j.RowHeaders = InheritableBoolean.True;
		j.Size = new Size(193, 247);
		j.TabIndex = 124;
		j.VisualStyle = VisualStyle.Office2003;
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		k.DesignTimeLayout = gridEXLayout3;
		k.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		k.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 178);
		k.GroupByBoxVisible = false;
		k.Location = new Point(232, 379);
		k.Name = "gDis";
		k.RowHeaders = InheritableBoolean.True;
		k.Size = new Size(546, 162);
		k.TabIndex = 127;
		k.VisualStyle = VisualStyle.Office2003;
		k.VisibleChanged += a;
		l.AutoSize = true;
		l.Location = new Point(162, 436);
		l.Name = "lDatato";
		l.Size = new Size(44, 13);
		l.TabIndex = 131;
		l.Text = "تا تاریخ :";
		m.AutoToday = true;
		m.BackColor = Color.SeaShell;
		m.BijanForeColor = Color.Blue;
		m.Location = new Point(12, 432);
		m.Name = "txtDatato";
		m.Size = new Size(144, 24);
		m.TabIndex = 129;
		m.the_date = new DateTime(2024, 2, 8, 9, 45, 47, 638);
		m.the_label = "ازمون تاريخ:";
		n.AutoSize = true;
		n.Location = new Point(162, 398);
		n.Name = "lDatafrom";
		n.Size = new Size(45, 13);
		n.TabIndex = 130;
		n.Text = "از تاریخ :";
		o.AutoToday = true;
		o.BackColor = Color.SeaShell;
		o.BijanForeColor = Color.Blue;
		o.Location = new Point(12, 393);
		o.Name = "txtDatafrom";
		o.Size = new Size(144, 24);
		o.TabIndex = 128;
		o.the_date = new DateTime(2024, 2, 8, 9, 45, 47, 641);
		o.the_label = "ازمون تاريخ:";
		p.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		p.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "همه موارد";
		uIComboBoxItem.Value = "0";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "انضباطی";
		uIComboBoxItem2.Value = "1";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "اخطار آموزشی";
		uIComboBoxItem3.Value = "3";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "تشویقی";
		uIComboBoxItem4.Value = "2";
		p.Items.AddRange(new UIComboBoxItem[4] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4 });
		p.Location = new Point(558, 346);
		p.Name = "dropFilterType";
		p.Size = new Size(184, 24);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		p.StringFormat = stringFormat2;
		p.TabIndex = 132;
		p.SelectedIndexChanged += b;
		q.AutoSize = true;
		q.Location = new Point(745, 353);
		q.Name = "lFilterType";
		q.Size = new Size(34, 13);
		q.TabIndex = 133;
		q.Text = "مورد :";
		r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		r.ForeColor = Color.FromArgb(192, 0, 0);
		r.Location = new Point(232, 353);
		r.Name = "ltextDis";
		r.Size = new Size(308, 23);
		r.TabIndex = 134;
		r.Text = "مواردی که نمی خواهید در گزارش نمایش داده شود را تیک بزنید";
		r.TextAlign = ContentAlignment.MiddleCenter;
		r.Visible = false;
		s.AutoSize = true;
		s.Location = new Point(116, 32);
		s.Name = "label8";
		s.Size = new Size(66, 13);
		s.TabIndex = 136;
		s.Text = "سال تعلیمی";
		t.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		t.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1403";
		uIComboBoxItem5.Value = "1403";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1402";
		uIComboBoxItem6.Value = "1402";
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "1401";
		uIComboBoxItem7.Value = "1401";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "1400";
		uIComboBoxItem8.Value = "1400";
		uIComboBoxItem9.FormatStyle.Alpha = 0;
		uIComboBoxItem9.Text = "1399";
		uIComboBoxItem9.Value = "1399";
		uIComboBoxItem10.FormatStyle.Alpha = 0;
		uIComboBoxItem10.Text = "1398";
		uIComboBoxItem10.Value = "1398";
		t.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem5, uIComboBoxItem6, uIComboBoxItem7, uIComboBoxItem8, uIComboBoxItem9, uIComboBoxItem10 });
		t.Location = new Point(12, 26);
		t.Name = "dropYear";
		t.Size = new Size(97, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		t.StringFormat = stringFormat3;
		t.TabIndex = 135;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(792, 566);
		Controls.Add(s);
		Controls.Add(t);
		Controls.Add(r);
		Controls.Add(q);
		Controls.Add(p);
		Controls.Add(l);
		Controls.Add(m);
		Controls.Add(n);
		Controls.Add(o);
		Controls.Add(k);
		Controls.Add(h);
		Controls.Add(i);
		Controls.Add(j);
		Controls.Add(g);
		Controls.Add(this.m_f);
		Controls.Add(this.m_e);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRptDis";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "گزارش موارد انضباطی";
		Load += f;
		((ISupportInitialize)this.m_e).EndInit();
		((ISupportInitialize)j).EndInit();
		((ISupportInitialize)k).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
