using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using FreeSms.Reporting;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbw : Form
{
	private string m_a = "";

	private IContainer m_b = null;

	private GridEX m_c;

	private UIButton m_d;

	private UIButton m_e;

	private GridEX m_f;

	private EditBox m_g;

	private EditBox m_h;

	private Label m_i;

	private Label m_j;

	private Label m_k;

	private EditBox m_l;

	private Label m_m;

	private EditBox n;

	private Label o;

	private EditBox p;

	private CheckBox q;

	private Label r;

	private Panel s;

	private Panel t;

	private UIButton u;

	private UIButton v;

	private RadioButton w;

	private RadioButton x;

	private Label y;

	private UIGroupBox z;

	private Label aa;

	private Label ab;

	private GridEX ac;

	private EditBox ad;

	private EditBox ae;

	private Label af;

	private UIComboBox ag;

	private Label ah;

	private UIComboBox ai;

	private UIGroupBox aj;

	private GridEX ak;

	private UIButton al;

	private UIButton am;

	private UIButton an;

	private Label ao;

	private CheckBox ap;

	private UIComboBox aq;

	private CheckBox ar;

	public asdbw()
	{
		a();
	}

	private void h()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tExam where xYear=" + aq.SelectedValue.ToString() + " order by NumExam desc");
		this.m_f.DataSource = dataSource;
	}

	private void g()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") order by id");
			ai.Items.Add("کل", "0");
			int num = 0;
			if (true)
			{
			}
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					ai.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 0:
					ai.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void f()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name,xpaye from tClass where xYear=" + aq.SelectedValue.ToString() + " and xPaye in(" + asdaj.n + ")");
			ag.Items.Clear();
			ag.Items.Add("همه صنفها", "0");
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					ag.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 3;
					continue;
				case 2:
					ag.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		while (true)
		{
			string text = " where tosifi is null";
			bool flag = !(asdab.m == "2");
			int num = 2;
			while (true)
			{
				DataTable dataSource;
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_0067;
				case 0:
					text = " where tosifi=1";
					num = 1;
					continue;
				case 1:
					{
						if (1 == 0)
						{
						}
						goto IL_0067;
					}
					IL_0067:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tRpt.*,case countExam when 0 then 'نا محدود' else cast(countExam as nvarchar(2)) end as countTest from tRpt" + text + " and type=1");
					this.m_c.DataSource = dataSource;
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			string text = " tYear_Student.xyear=" + aq.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = ag.SelectedIndex <= 0;
			int num = 18;
			while (true)
			{
				switch (num)
				{
				case 18:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 13;
				case 21:
					text += " and ";
					num = 3;
					continue;
				case 28:
					text = text + " tstudent.FName like '%" + asdaj.b(ae.Text) + "%'";
					num = 27;
					continue;
				case 13:
					flag = ai.SelectedIndex <= 0;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 11;
				case 16:
					flag = !(text != "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 8;
				case 17:
					text = text + " tYear_Student.xClass=" + ag.SelectedValue.ToString();
					num = 13;
					continue;
				case 12:
					flag = !(text != "");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 3;
				case 8:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName, \r\n                 tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text + " order by tYear_Student.sort,tStudent.lname,tStudent.fname");
					ac.DataSource = dataSource;
					flag = ac.RowCount <= 0;
					num = 19;
					continue;
				}
				case 19:
					if (!flag)
					{
						num = 25;
						continue;
					}
					return;
				case 9:
					text += " and ";
					num = 28;
					continue;
				case 26:
					flag = !(text != "");
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 4;
				case 14:
					text = " where " + text;
					num = 8;
					continue;
				case 25:
					ac.Row = 0;
					num = 23;
					continue;
				case 23:
					return;
				case 4:
					text = text + " tYear_Student.xPaye=" + ai.SelectedValue.ToString();
					num = 11;
					continue;
				case 7:
					flag = !(text != "");
					num = 29;
					continue;
				case 29:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 17;
				case 1:
					if (true)
					{
					}
					text += " and ";
					num = 17;
					continue;
				case 22:
					text += " and ";
					num = 4;
					continue;
				case 11:
					flag = !(ae.Text.Trim() != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 27;
				case 3:
					text = text + " tstudent.LName like '%" + asdaj.b(ad.Text) + "%'";
					num = 16;
					continue;
				case 27:
					flag = !(ad.Text.Trim() != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 16;
				case 20:
					flag = !(text != "");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 28;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id,tStudent.NumberAsas,  tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id  INNER JOIN tmpStdforPrint on  tStudent.id=tmpStdforPrint.id where tYear_Student.xyear=" + aq.SelectedValue.ToString() + " and tmpStdforPrint.xUser=" + asdaj.l);
		ak.DataSource = dataSource;
	}

	private void b()
	{
		bool flag = default;
		string[] array = default;
		DataTable dataTable = default;
		string a_3 = default;
		SqlParameter[] a_2 = default;
		ReportClass reportClass = default;
		string text5 = default;
		DataTable dataTable2 = default;
		while (true)
		{
			string a_ = this.m_c.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text = this.m_c.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			string text2 = "";
			string text3 = "";
			int num = 0;
			int num2 = 39;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 35:
					flag = array.Length <= 5;
					num2 = 40;
					continue;
				case 40:
					if (!flag)
					{
						num2 = 50;
						continue;
					}
					goto case 5;
				case 28:
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_3, a_2);
					reportClass = asdd.a(a_);
					flag = !(text != "");
					num2 = 13;
					continue;
				case 13:
					if (!flag)
					{
						num2 = 17;
						continue;
					}
					goto case 12;
				case 19:
					MessageBox.Show("شاگردی با لیست نمایش اضافه نشده است");
					num2 = 34;
					continue;
				case 34:
					return;
				case 8:
					dataTable.Rows.Remove(dataTable.Rows[num]);
					num--;
					num2 = 15;
					continue;
				case 1:
					num++;
					num2 = 26;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_2);
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource);
					num2 = 35;
					continue;
				}
				case 30:
					reportClass.SetDataSource(dataTable);
					num2 = 32;
					continue;
				case 44:
					a_3 = this.m_c.SelectedItems[0].GetRow().Cells["sp2"].Value.ToString();
					num2 = 28;
					continue;
				case 10:
					if (!flag)
					{
						num2 = 29;
						continue;
					}
					goto case 42;
				case 4:
				case 21:
					flag = num < dataTable.Rows.Count;
					num2 = 49;
					continue;
				case 49:
					if (!flag)
					{
						if (true)
						{
						}
						num2 = 30;
					}
					else
					{
						string text4 = dataTable.Rows[num]["xstudent"].ToString();
						flag = text5.IndexOf("-" + text4 + "-") >= 0;
						num2 = 24;
					}
					continue;
				case 20:
					return;
				case 7:
				case 41:
					flag = num < ak.RowCount;
					num2 = 46;
					continue;
				case 46:
					if (!flag)
					{
						num2 = 18;
						continue;
					}
					text5 = text5 + "-" + ak.GetRow(num).Cells["id"].Value.ToString() + "-";
					num++;
					num2 = 7;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 23;
						continue;
					}
					goto case 1;
				case 27:
					flag = ak.RowCount != 0;
					num2 = 6;
					continue;
				case 6:
					if (!flag)
					{
						num2 = 19;
						continue;
					}
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select distinct xclass from tYear_Student where xyear=" + aq.SelectedValue.ToString() + " and  xstudent in(select id from tmpStdforPrint)");
					num = 0;
					num2 = 36;
					continue;
				case 26:
				case 39:
					flag = num < this.m_f.RowCount;
					num2 = 11;
					continue;
				case 11:
					if (flag)
					{
						flag = !(this.m_f.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 3;
					}
					else
					{
						num2 = 27;
					}
					continue;
				case 42:
					text3 += dataTable2.Rows[num]["xclass"].ToString();
					num++;
					num2 = 0;
					continue;
				case 15:
					num++;
					num2 = 21;
					continue;
				case 5:
					num2 = 12;
					continue;
				case 18:
					a_2 = new SqlParameter[3]
					{
						asdcb.a("@Exam", SqlDbType.VarChar, text2),
						asdcb.a("@Class", SqlDbType.VarChar, text3),
						asdcb.a("@xYear", SqlDbType.Int, aq.SelectedValue.ToString())
					};
					a_3 = this.m_c.SelectedItems[0].GetRow().Cells["sp"].Value.ToString();
					num2 = 37;
					continue;
				case 37:
					num2 = ((!q.Checked) ? 25 : 47);
					continue;
				case 16:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_2);
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource);
					num2 = 33;
					continue;
				}
				case 0:
				case 36:
					flag = num < dataTable2.Rows.Count;
					num2 = 22;
					continue;
				case 22:
					if (flag)
					{
						flag = !(text3 != "");
						num2 = 10;
					}
					else
					{
						num2 = 14;
					}
					continue;
				case 24:
					if (!flag)
					{
						num2 = 8;
						continue;
					}
					goto case 15;
				case 29:
					text3 += ",";
					num2 = 42;
					continue;
				case 14:
					text5 = "";
					num = 0;
					num2 = 41;
					continue;
				case 43:
					text2 += this.m_f.GetRow(num).Cells["id"].Value.ToString();
					num2 = 1;
					continue;
				case 17:
					array = text.Split(',');
					flag = array.Length <= 1;
					num2 = 48;
					continue;
				case 48:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 33;
				case 23:
					flag = !(text2 != "");
					num2 = 45;
					continue;
				case 45:
					if (!flag)
					{
						num2 = 9;
						continue;
					}
					goto case 43;
				case 33:
					flag = array.Length <= 3;
					num2 = 51;
					continue;
				case 51:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					goto case 35;
				case 25:
					num3 = 1;
					goto IL_0bb0;
				case 32:
				{
					try
					{
						while (true)
						{
							IL_08d8:
							reportClass.ParameterFields[0].CurrentValues.AddValue(this.m_g.Text);
							reportClass.ParameterFields[1].CurrentValues.AddValue(this.m_l.Text);
							reportClass.ParameterFields[2].CurrentValues.AddValue(n.Text);
							reportClass.ParameterFields[3].CurrentValues.AddValue(this.m_h.Text);
							reportClass.ParameterFields[4].CurrentValues.AddValue(p.Text);
							flag = !(this.m_a != "");
							num2 = 14;
							while (true)
							{
								switch (num2)
								{
								case 14:
									if (!flag)
									{
										num2 = 9;
										continue;
									}
									goto case 3;
								case 3:
									flag = !(this.m_c.SelectedItems[0].GetRow().Cells["showBartar"].Value.ToString() == "1");
									num2 = 8;
									continue;
								case 8:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									goto case 6;
								case 9:
									reportClass.ParameterFields[5].CurrentValues.AddValue(this.m_a);
									num2 = 3;
									continue;
								case 2:
									flag = !ap.Checked;
									num2 = 7;
									continue;
								case 7:
									if (!flag)
									{
										num2 = 1;
										continue;
									}
									reportClass.ParameterFields[5].CurrentValues.AddValue("0");
									num2 = 12;
									continue;
								case 0:
								case 12:
									flag = !ar.Checked;
									num2 = 4;
									continue;
								case 4:
									if (flag)
									{
										reportClass.ParameterFields["showGread"].CurrentValues.AddValue("0");
										num2 = 5;
									}
									else
									{
										num2 = 11;
									}
									continue;
								case 1:
									reportClass.ParameterFields[5].CurrentValues.AddValue("1");
									num2 = 0;
									continue;
								case 5:
								case 10:
									num2 = 6;
									continue;
								case 11:
									reportClass.ParameterFields["showGread"].CurrentValues.AddValue("1");
									num2 = 10;
									continue;
								case 6:
									num2 = 13;
									continue;
								case 13:
									goto end_IL_0893;
								}
								goto IL_08d8;
								continue;
								end_IL_0893:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					num2 = 20;
					continue;
				}
				case 38:
					if (!flag)
					{
						num2 = 44;
						continue;
					}
					goto case 28;
				case 9:
					text2 += ",";
					num2 = 43;
					continue;
				case 47:
					num2 = 31;
					continue;
				case 31:
					num3 = ((!(this.m_c.SelectedItems[0].GetRow().Cells["sp2"].Value.ToString() != "")) ? 1 : 0);
					goto IL_0bb0;
				case 12:
					num = 0;
					num2 = 4;
					continue;
				case 50:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_2);
						reportClass.Subreports[array[4].ToString()].SetDataSource(dataSource);
						num2 = 5;
						continue;
					}
					IL_0bb0:
					flag = (byte)num3 != 0;
					num2 = 38;
					continue;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		int num4 = default;
		int num2 = default;
		bool flag = default;
		int num5 = default;
		string text = default;
		bool flag2 = default;
		while (true)
		{
			int num = 25;
			while (true)
			{
				int num8;
				int num6;
				int num7;
				int num3;
				switch (num)
				{
				case 25:
					if (!(this.m_h.Text != this.m_h.Tag.ToString()))
					{
						num = 52;
						continue;
					}
					goto IL_0a7d;
				case 56:
				{
					SqlParameter[] a_2 = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, this.m_f.GetRow(num4).Cells["id"].Value.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_2);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_2);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_2);
					num = 53;
					continue;
				}
				case 21:
					num = 47;
					continue;
				case 47:
					num8 = ((num2 <= 0) ? 1 : 0);
					goto IL_0325;
				case 9:
					num6 = 1;
					goto IL_03e6;
				case 48:
					flag = !(this.m_c.SelectedItems[0].GetRow().Cells["term"].Value.ToString() != this.m_f.GetRow(num4).Cells["term"].Value.ToString());
					num = 13;
					continue;
				case 13:
					num = (flag ? 44 : 26);
					continue;
				case 51:
					num = ((num5 <= num2) ? 20 : 21);
					continue;
				case 1:
					num = ((num5 != 2) ? 36 : 9);
					continue;
				case 42:
					MessageBox.Show("برای نمایش این گزارش باید حتما تعداد 2 دوره انتخاب شود");
					num = 18;
					continue;
				case 18:
					return;
				case 29:
					if (!flag)
					{
						num = 64;
						continue;
					}
					flag = !(this.m_c.SelectedItems[0].GetRow().Cells["term"].Value.ToString() != "");
					num = 19;
					continue;
				case 62:
					num = 69;
					continue;
				case 69:
					if (!(this.m_l.Text != this.m_l.Tag.ToString()))
					{
						num = 15;
						continue;
					}
					goto IL_0a7d;
				case 24:
					num5++;
					flag = !(text != "");
					num = 60;
					continue;
				case 60:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 23;
				case 31:
					num = ((!flag) ? 42 : 51);
					continue;
				case 8:
					num = 35;
					continue;
				case 70:
					num = 10;
					continue;
				case 10:
					num7 = ((num2 != 1) ? 1 : 0);
					goto IL_0a53;
				case 2:
				case 40:
					flag = num4 < this.m_f.RowCount;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 32;
						continue;
					}
					flag = !(this.m_f.GetRow(num4).Cells["Selector"].Value.ToString() == "True");
					num = 66;
					continue;
				case 63:
					num = 65;
					continue;
				case 65:
					if (!(this.m_g.Text != this.m_g.Tag.ToString()))
					{
						num = 45;
						continue;
					}
					goto IL_0a7d;
				case 20:
					num8 = 1;
					goto IL_0325;
				case 23:
					text += this.m_f.GetRow(num4).Cells["id"].Value.ToString();
					num = 6;
					continue;
				case 53:
					num4++;
					num = 40;
					continue;
				case 57:
					return;
				case 12:
					MessageBox.Show("دوره ای انتخاب نشده است");
					num = 38;
					continue;
				case 38:
					return;
				case 15:
					num = 33;
					continue;
				case 33:
					if (!(n.Text != n.Tag.ToString()))
					{
						num = 63;
						continue;
					}
					goto IL_0a7d;
				case 55:
					flag2 = ar.Checked;
					num = 28;
					continue;
				case 28:
					num3 = ((!(flag2.ToString() != ar.Tag.ToString())) ? 1 : 0);
					goto IL_05e4;
				case 30:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 5;
				case 64:
					MessageBox.Show("برای نمایش این گزارش نباید بیشتر از " + num2 + " دوره انتخاب شود");
					num = 22;
					continue;
				case 22:
					return;
				case 26:
					MessageBox.Show("این گزارش برای دوره ای که انتخاب کردید قابل نمایش نیست");
					num = 14;
					continue;
				case 14:
					return;
				case 36:
					num = 61;
					continue;
				case 61:
					num6 = ((num2 != 2) ? 1 : 0);
					goto IL_03e6;
				case 27:
					num7 = 1;
					goto IL_0a53;
				case 34:
				case 54:
					flag = num4 < this.m_f.RowCount;
					num = 68;
					continue;
				case 68:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = !(this.m_f.GetRow(num4).Cells["Selector"].Value.ToString() == "True");
					num = 49;
					continue;
				case 5:
					text = "";
					num5 = 0;
					num4 = 0;
					num = 2;
					continue;
				case 41:
					num = ((num5 > 1) ? 70 : 27);
					continue;
				case 44:
					num4++;
					num = 54;
					continue;
				case 59:
					s.Visible = true;
					x.Checked = false;
					w.Checked = false;
					v.Focus();
					num = 16;
					continue;
				case 16:
					return;
				case 3:
					text += ",";
					num = 23;
					continue;
				case 17:
				{
					SqlParameter[] a_ = new SqlParameter[7]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, this.m_l.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, n.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, this.m_h.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, p.Text),
						asdcb.a("@sch", SqlDbType.NVarChar, this.m_g.Text),
						asdcb.a("@showBartar", SqlDbType.Bit, ap.Checked),
						asdcb.a("@showGread", SqlDbType.Bit, ar.Checked)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_);
					num = 5;
					continue;
				}
				case 50:
					MessageBox.Show("برای نمایش این گزارش تنها باید یک دوره انتخاب شود");
					num = 37;
					continue;
				case 37:
					return;
				case 49:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 44;
				case 35:
					flag = !(this.m_c.SelectedItems[0].GetRow().Cells["sortRpt"].Value.ToString() == "1");
					num = 46;
					continue;
				case 46:
					if (flag)
					{
						b();
						num = 57;
					}
					else
					{
						num = 59;
					}
					continue;
				case 66:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 6;
				case 6:
				{
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + this.m_f.GetRow(num4).Cells["id"].Value.ToString()).ToString();
					flag = !(text2 != "1");
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 53;
				case 11:
					num4 = 0;
					num = 34;
					continue;
				case 67:
					num = (flag ? 1 : 50);
					continue;
				case 39:
					num3 = 0;
					goto IL_05e4;
				case 45:
					flag2 = ap.Checked;
					num = 7;
					continue;
				case 7:
					if (!(flag2.ToString() != ap.Tag.ToString()))
					{
						num = 55;
						continue;
					}
					goto IL_0a7d;
				case 52:
					num = 58;
					continue;
				case 58:
					if (!(p.Text != p.Tag.ToString()))
					{
						num = 62;
						continue;
					}
					goto IL_0a7d;
				case 32:
					num2 = int.Parse(this.m_c.SelectedItems[0].GetRow().Cells["countExam"].Value.ToString());
					flag = !(text == "");
					num = 43;
					continue;
				case 43:
					if (flag)
					{
						if (true)
						{
						}
						num = 41;
					}
					else
					{
						num = 12;
					}
					continue;
				case 19:
					{
						if (!flag)
						{
							num = 11;
							continue;
						}
						goto case 35;
					}
					IL_0a7d:
					num = 39;
					continue;
					IL_03e6:
					flag = (byte)num6 != 0;
					num = 31;
					continue;
					IL_05e4:
					flag = (byte)num3 != 0;
					num = 30;
					continue;
					IL_0325:
					flag = (byte)num8 != 0;
					num = 29;
					continue;
					IL_0a53:
					flag = (byte)num7 != 0;
					num = 67;
					continue;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrint where xUser=" + asdaj.l);
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					if (!(this.m_h.Text != this.m_h.Tag.ToString()))
					{
						num = 12;
						continue;
					}
					goto IL_009e;
				case 6:
					num2 = 0;
					goto IL_022e;
				case 2:
					num = 11;
					continue;
				case 11:
					num2 = ((!(this.m_g.Text != this.m_g.Tag.ToString())) ? 1 : 0);
					goto IL_022e;
				case 4:
					num = 8;
					continue;
				case 8:
					if (!(this.m_l.Text != this.m_l.Tag.ToString()))
					{
						num = 10;
						continue;
					}
					goto IL_009e;
				case 9:
				{
					SqlParameter[] a_ = new SqlParameter[5]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, this.m_l.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, n.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, this.m_h.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, p.Text),
						asdcb.a("@sch", SqlDbType.NVarChar, this.m_g.Text)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_);
					num = 5;
					continue;
				}
				case 5:
					return;
				case 12:
					num = 3;
					continue;
				case 3:
					if (!(p.Text != p.Tag.ToString()))
					{
						num = 4;
						continue;
					}
					goto IL_009e;
				case 1:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 10:
					num = 0;
					continue;
				case 0:
					{
						if (!(n.Text != n.Tag.ToString()))
						{
							num = 2;
							continue;
						}
						goto IL_009e;
					}
					IL_022e:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
					IL_009e:
					if (true)
					{
					}
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
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
					num = (x.Checked ? 1 : 9);
					continue;
				case 3:
					this.m_a = "1";
					num = 5;
					continue;
				case 11:
					if (!flag)
					{
						num = 3;
						continue;
					}
					this.m_a = "2";
					num = 10;
					continue;
				case 1:
					num2 = 1;
					goto IL_012e;
				case 5:
				case 10:
					b();
					num = 4;
					continue;
				case 4:
					return;
				case 9:
					num = 0;
					continue;
				case 0:
					num2 = (w.Checked ? 1 : 0);
					goto IL_012e;
				case 2:
					MessageBox.Show("ترتیب نمایش گزارش را مشخص کنید");
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					return;
				case 8:
					{
						if (flag)
						{
							flag = !x.Checked;
							num = 11;
						}
						else
						{
							num = 2;
						}
						continue;
					}
					IL_012e:
					flag = (byte)num2 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		s.Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		s.Visible = false;
	}

	private void h(object A_0, EventArgs A_1)
	{
		s.Visible = false;
	}

	private void g(object A_0, EventArgs A_1)
	{
		string text = default;
		int num2 = default;
		while (true)
		{
			if (true)
			{
			}
			bool flag = ac.RowCount != 0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					text = ac.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num2 = 0;
					num = 1;
					continue;
				case 8:
					MessageBox.Show("این شاگرد قبلا به لیست پرینت اضافه شده است");
					num = 3;
					continue;
				case 3:
					return;
				case 10:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tmpStdforPrint (id,xUser) VALUES     (" + text + "," + asdaj.l + ")");
					c();
					ad.Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 7:
					MessageBox.Show("موردی جهت اضافه شدن وجود ندارد");
					ad.Focus();
					num = 9;
					continue;
				case 9:
					return;
				case 1:
				case 5:
					flag = num2 < ak.RowCount;
					num = 6;
					continue;
				case 6:
				{
					if (!flag)
					{
						num = 10;
						continue;
					}
					string text2 = ak.GetRow(num2).Cells["id"].Value.ToString();
					flag = !(text2 == text);
					num = 0;
					continue;
				}
				case 0:
					if (flag)
					{
						num2++;
						num = 5;
					}
					else
					{
						num = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					num = ((ak.RowCount > 0) ? 1 : 6);
					continue;
				case 1:
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					num2 = ((ak.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_00ee;
				case 5:
				{
					string text = ak.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrint where id=" + text);
					c();
					ad.Focus();
					num = 2;
					continue;
				}
				case 2:
					return;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 6:
					{
						num2 = 1;
						goto IL_00ee;
					}
					IL_00ee:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		d();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		d();
	}

	private void e(object A_0, EventArgs A_1)
	{
		d();
	}

	private void d(object A_0, EventArgs A_1)
	{
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Insert;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = A_1.KeyCode != Keys.Delete;
					num = 4;
					continue;
				case 3:
					f(this, null);
					num = 5;
					continue;
				case 5:
					return;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 1:
					g(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = ak.RowCount <= 0;
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
					return;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrint where xUser=" + asdaj.l);
					c();
					ad.Focus();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		DataTable dataTable2 = default;
		while (true)
		{
			bool flag = asdaj.a("4");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 9;
						continue;
					}
					OriginalSchoolYears.Select(aq, asdaj.__field_a);
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 0:
					try
					{
						ap.Checked = bool.Parse(dataTable2.Rows[0]["showBartar"].ToString());
						ap.Tag = dataTable2.Rows[0]["showBartar"].ToString();
						ar.Checked = bool.Parse(dataTable2.Rows[0]["ShowGread"].ToString());
						ar.Tag = dataTable2.Rows[0]["ShowGread"].ToString();
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 11;
					continue;
				case 6:
					h();
					g();
					f();
					d();
					c();
					e();
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tParmetr");
					flag = dataTable2.Rows.Count <= 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 11;
				case 2:
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 8:
					this.m_h.Text = dataTable2.Rows[0]["Foter1"].ToString();
					p.Text = dataTable2.Rows[0]["Foter2"].ToString();
					this.m_l.Text = dataTable2.Rows[0]["heder1"].ToString();
					n.Text = dataTable2.Rows[0]["heder2"].ToString();
					this.m_g.Text = dataTable2.Rows[0]["sch"].ToString();
					this.m_h.Tag = dataTable2.Rows[0]["Foter1"].ToString();
					p.Tag = dataTable2.Rows[0]["Foter2"].ToString();
					this.m_l.Tag = dataTable2.Rows[0]["heder1"].ToString();
					n.Tag = dataTable2.Rows[0]["heder2"].ToString();
					this.m_g.Tag = dataTable2.Rows[0]["sch"].ToString();
					num = 0;
					continue;
				case 11:
					ad.Focus();
					ad.Select();
					ad.SelectAll();
					num = 10;
					continue;
				case 10:
					return;
				case 9:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		h();
		f();
		d();
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
					num = ((!A_0) ? 3 : 2);
					continue;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 5:
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
					this.m_b.Dispose();
					num = 0;
					continue;
				case 3:
					num2 = 1;
					goto IL_0074;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbw));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout3 = new GridEXLayout();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		GridEXLayout gridEXLayout4 = new GridEXLayout();
		this.m_c = new GridEX();
		this.m_d = new UIButton();
		this.m_f = new GridEX();
		this.m_g = new EditBox();
		this.m_h = new EditBox();
		this.m_i = new Label();
		this.m_j = new Label();
		this.m_k = new Label();
		this.m_l = new EditBox();
		this.m_m = new Label();
		n = new EditBox();
		o = new Label();
		p = new EditBox();
		q = new CheckBox();
		r = new Label();
		s = new Panel();
		t = new Panel();
		w = new RadioButton();
		x = new RadioButton();
		y = new Label();
		u = new UIButton();
		v = new UIButton();
		z = new UIGroupBox();
		aq = new UIComboBox();
		ao = new Label();
		aa = new Label();
		ab = new Label();
		ac = new GridEX();
		ad = new EditBox();
		ae = new EditBox();
		af = new Label();
		ag = new UIComboBox();
		ah = new Label();
		ai = new UIComboBox();
		aj = new UIGroupBox();
		an = new UIButton();
		al = new UIButton();
		ak = new GridEX();
		ap = new CheckBox();
		am = new UIButton();
		this.m_e = new UIButton();
		ar = new CheckBox();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)this.m_f).BeginInit();
		s.SuspendLayout();
		t.SuspendLayout();
		((ISupportInitialize)z).BeginInit();
		z.SuspendLayout();
		((ISupportInitialize)ac).BeginInit();
		((ISupportInitialize)aj).BeginInit();
		aj.SuspendLayout();
		((ISupportInitialize)ak).BeginInit();
		SuspendLayout();
		this.m_c.AllowEdit = InheritableBoolean.False;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = gridEXLayout;
		this.m_c.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_c.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.GroupByBoxVisible = false;
		this.m_c.Location = new Point(199, 248);
		this.m_c.Name = "gridEX1";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.RowHeaders = InheritableBoolean.True;
		this.m_c.Size = new Size(575, 168);
		this.m_c.TabIndex = 0;
		this.m_c.VisualStyle = VisualStyle.Office2003;
		this.m_c.SelectionChanged += j;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_d.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(174, 599);
		this.m_d.Name = "btnview";
		this.m_d.Size = new Size(122, 34);
		this.m_d.TabIndex = 1;
		this.m_d.Text = "نمایش گزارش";
		this.m_d.Click += m;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_f.DesignTimeLayout = gridEXLayout2;
		this.m_f.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_f.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_f.GroupByBoxVisible = false;
		this.m_f.Location = new Point(1, 248);
		this.m_f.Name = "gExam";
		this.m_f.RowHeaders = InheritableBoolean.True;
		this.m_f.Size = new Size(193, 166);
		this.m_f.TabIndex = 111;
		this.m_f.VisualStyle = VisualStyle.Office2003;
		this.m_f.Click += h;
		this.m_g.AutoScroll = false;
		this.m_g.AutoScrollMargin = new Size(0, 0);
		this.m_g.AutoScrollMinSize = new Size(0, 0);
		this.m_g.AutoScrollPosition = new Point(0, 0);
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(413, 523);
		this.m_g.MaxLength = 300;
		this.m_g.Name = "txtSch";
		this.m_g.Size = new Size(263, 23);
		this.m_g.TabIndex = 112;
		this.m_g.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_h.AutoScroll = false;
		this.m_h.AutoScrollMargin = new Size(0, 0);
		this.m_h.AutoScrollMinSize = new Size(0, 0);
		this.m_h.AutoScrollPosition = new Point(0, 0);
		this.m_h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(413, 551);
		this.m_h.MaxLength = 300;
		this.m_h.Name = "txtFoter1";
		this.m_h.Size = new Size(263, 23);
		this.m_h.TabIndex = 113;
		this.m_h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_i.AutoSize = true;
		this.m_i.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(679, 527);
		this.m_i.Name = "label1";
		this.m_i.Size = new Size(57, 20);
		this.m_i.TabIndex = 114;
		this.m_i.Text = "نام مکتب :";
		this.m_j.AutoSize = true;
		this.m_j.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(680, 553);
		this.m_j.Name = "label2";
		this.m_j.Size = new Size(50, 20);
		this.m_j.TabIndex = 115;
		this.m_j.Text = "نام مدیر :";
		this.m_k.AutoSize = true;
		this.m_k.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_k.Location = new Point(681, 421);
		this.m_k.Name = "label3";
		this.m_k.Size = new Size(71, 20);
		this.m_k.TabIndex = 117;
		this.m_k.Text = "بالای گزارش :";
		this.m_l.AutoScroll = false;
		this.m_l.AutoScrollMargin = new Size(0, 0);
		this.m_l.AutoScrollMinSize = new Size(0, 0);
		this.m_l.AutoScrollPosition = new Point(0, 0);
		this.m_l.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(12, 419);
		this.m_l.MaxLength = 300;
		this.m_l.Name = "txtHeder1";
		this.m_l.Size = new Size(664, 23);
		this.m_l.TabIndex = 116;
		this.m_l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_m.AutoSize = true;
		this.m_m.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_m.Location = new Point(679, 495);
		this.m_m.Name = "label4";
		this.m_m.Size = new Size(56, 20);
		this.m_m.TabIndex = 119;
		this.m_m.Text = "پیام مدیر :";
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(12, 494);
		n.MaxLength = 300;
		n.Name = "txtHeder2";
		n.Size = new Size(664, 23);
		n.TabIndex = 118;
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		o.AutoSize = true;
		o.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(679, 472);
		o.Name = "label5";
		o.Size = new Size(86, 20);
		o.TabIndex = 121;
		o.Text = "پایین اطلاع نامه :";
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Location = new Point(12, 468);
		p.MaxLength = 300;
		p.Name = "txtFoter2";
		p.Size = new Size(664, 23);
		p.TabIndex = 120;
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.AutoSize = true;
		q.Checked = true;
		q.CheckState = CheckState.Checked;
		q.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Location = new Point(12, 520);
		q.Name = "checkSp2";
		q.Size = new Size(375, 20);
		q.TabIndex = 125;
		q.Text = "فقط درس های دارای نمره را  در گزارش نمایش داده شود";
		q.UseVisualStyleBackColor = true;
		r.AutoSize = true;
		r.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.ForeColor = Color.Red;
		r.Location = new Point(90, 446);
		r.Name = "label6";
		r.Size = new Size(598, 20);
		r.TabIndex = 126;
		r.Text = "در صورتی که برای شاگرد در منوی توضیحات زیر اطلاع نامه توضیحی ثبت شده باشد به جای پایین اطلاع نامه نمایش داده خواهد شد";
		s.BackColor = Color.Gray;
		s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		s.Controls.Add(t);
		s.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Location = new Point(218, 246);
		s.Name = "pSort";
		s.Size = new Size(338, 204);
		s.TabIndex = 129;
		s.Visible = false;
		t.BackColor = Color.FromArgb(214, 223, 247);
		t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		t.Controls.Add(w);
		t.Controls.Add(x);
		t.Controls.Add(y);
		t.Controls.Add(u);
		t.Controls.Add(v);
		t.Location = new Point(6, 7);
		t.Name = "panel1";
		t.Size = new Size(321, 186);
		t.TabIndex = 40;
		w.AutoSize = true;
		w.Location = new Point(135, 88);
		w.Name = "radioButton2";
		w.Size = new Size(99, 32);
		w.TabIndex = 1;
		w.TabStop = true;
		w.Text = "ردیف و الفبا";
		w.UseVisualStyleBackColor = true;
		x.AutoSize = true;
		x.Location = new Point(180, 50);
		x.Name = "radioButton1";
		x.Size = new Size(54, 32);
		x.TabIndex = 0;
		x.TabStop = true;
		x.Text = "نمره";
		x.UseVisualStyleBackColor = true;
		y.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		y.Location = new Point(17, 10);
		y.Name = "label9";
		y.Size = new Size(255, 37);
		y.TabIndex = 130;
		y.Text = "ترتیب شاگردان در  گزارش بر اساس";
		u.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		u.Location = new Point(40, 132);
		u.Name = "btnCancel";
		u.Size = new Size(117, 38);
		u.TabIndex = 5;
		u.Text = "انصراف";
		u.Click += i;
		v.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		v.Location = new Point(163, 132);
		v.Name = "btnAcp";
		v.Size = new Size(104, 38);
		v.TabIndex = 4;
		v.Text = "تایید";
		v.Click += k;
		z.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		z.Controls.Add(aq);
		z.Controls.Add(ao);
		z.Controls.Add(aa);
		z.Controls.Add(ab);
		z.Controls.Add(ac);
		z.Controls.Add(ad);
		z.Controls.Add(ae);
		z.Controls.Add(af);
		z.Controls.Add(ag);
		z.Controls.Add(ah);
		z.Controls.Add(ai);
		z.Font = new Font("Tahoma", 8.25f);
		z.Location = new Point(407, 2);
		z.Name = "uiGroupBox1";
		z.Size = new Size(349, 239);
		z.TabIndex = 130;
		z.Text = "جستجو";
		aq.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		aq.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aq.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "1403";
		uIComboBoxItem.Value = "1403";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "1402";
		uIComboBoxItem2.Value = "1402";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "1401";
		uIComboBoxItem3.Value = "1401";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "1400";
		uIComboBoxItem4.Value = "1400";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1399";
		uIComboBoxItem5.Value = "1399";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1398";
		uIComboBoxItem6.Value = "1398";
		aq.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		aq.Location = new Point(15, 45);
		aq.Name = "dropYear";
		aq.Size = new Size(97, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		aq.StringFormat = stringFormat;
		aq.TabIndex = 136;
		aq.SelectedIndexChanged += a;
		ao.AutoSize = true;
		ao.Location = new Point(24, 22);
		ao.Name = "label10";
		ao.Size = new Size(66, 13);
		ao.TabIndex = 133;
		ao.Text = "سال تعلیمی";
		aa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		aa.AutoSize = true;
		aa.Font = new Font("Tahoma", 8.25f);
		aa.Location = new Point(145, 82);
		aa.Name = "label7";
		aa.Size = new Size(21, 13);
		aa.TabIndex = 29;
		aa.Text = "ولد";
		ab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ab.AutoSize = true;
		ab.Font = new Font("Tahoma", 8.25f);
		ab.Location = new Point(307, 81);
		ab.Name = "label8";
		ab.Size = new Size(20, 13);
		ab.TabIndex = 28;
		ab.Text = "نام";
		ac.AllowEdit = InheritableBoolean.False;
		ac.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		ac.DesignTimeLayout = gridEXLayout3;
		ac.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		ac.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ac.GroupByBoxVisible = false;
		ac.Location = new Point(10, 109);
		ac.Name = "gridStdSearch";
		ac.RecordNavigator = true;
		ac.RowHeaders = InheritableBoolean.True;
		ac.Size = new Size(332, 118);
		ac.TabIndex = 5;
		ac.VisualStyle = VisualStyle.Office2003;
		ad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad.Font = new Font("Tahoma", 8.25f);
		ad.Location = new Point(20, 78);
		ad.Name = "txtLName";
		ad.RightToLeft = RightToLeft.Yes;
		ad.Size = new Size(119, 21);
		ad.TabIndex = 4;
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ad.KeyUp += c;
		ae.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ae.AutoScroll = false;
		ae.AutoScrollMargin = new Size(0, 0);
		ae.AutoScrollMinSize = new Size(0, 0);
		ae.AutoScrollPosition = new Point(0, 0);
		ae.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae.Font = new Font("Tahoma", 8.25f);
		ae.Location = new Point(182, 78);
		ae.Name = "txtFName";
		ae.RightToLeft = RightToLeft.Yes;
		ae.Size = new Size(119, 21);
		ae.TabIndex = 3;
		ae.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ae.KeyUp += b;
		af.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		af.AutoSize = true;
		af.Location = new Point(307, 47);
		af.Name = "label19";
		af.Size = new Size(30, 13);
		af.TabIndex = 25;
		af.Text = "صنف";
		ag.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ag.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ag.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.Font = new Font("Tahoma", 8.25f);
		ag.Location = new Point(127, 45);
		ag.Name = "dropCls";
		ag.Size = new Size(174, 21);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		ag.StringFormat = stringFormat2;
		ag.TabIndex = 2;
		ag.SelectedIndexChanged += e;
		ah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ah.AutoSize = true;
		ah.Font = new Font("Tahoma", 8.25f);
		ah.Location = new Point(307, 24);
		ah.Name = "label20";
		ah.Size = new Size(22, 13);
		ah.TabIndex = 15;
		ah.Text = "پایه";
		ai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ai.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ai.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ai.Font = new Font("Tahoma", 8.25f);
		ai.Location = new Point(127, 18);
		ai.Name = "dropPaye";
		ai.Size = new Size(174, 21);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		ai.StringFormat = stringFormat3;
		ai.TabIndex = 1;
		ai.SelectedIndexChanged += d;
		aj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		aj.Controls.Add(an);
		aj.Controls.Add(al);
		aj.Controls.Add(ak);
		aj.Font = new Font("Tahoma", 8.25f);
		aj.Location = new Point(5, 7);
		aj.Name = "uiGroupBox2";
		aj.Size = new Size(320, 234);
		aj.TabIndex = 131;
		aj.Text = "لیست شاگردان جهت نمایش در گزارش";
		an.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		an.Image = (Image)componentResourceManager.GetObject("btnFree.Image");
		an.Location = new Point(7, 191);
		an.Name = "btnFree";
		an.Size = new Size(162, 35);
		an.TabIndex = 134;
		an.Text = "خالی کرد کل لیست نمایش";
		an.Click += c;
		al.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		al.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		al.Location = new Point(175, 191);
		al.Name = "btnDelete";
		al.Size = new Size(134, 35);
		al.TabIndex = 133;
		al.Text = "حذف مورد انتخابی از لیست نمایش";
		al.Click += f;
		ak.AllowEdit = InheritableBoolean.False;
		ak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout4.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		ak.DesignTimeLayout = gridEXLayout4;
		ak.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		ak.Font = new Font("Tahoma", 8.25f);
		ak.GroupByBoxVisible = false;
		ak.Location = new Point(7, 23);
		ak.Name = "gSelectStd";
		ak.RecordNavigator = true;
		ak.RowHeaders = InheritableBoolean.True;
		ak.Size = new Size(303, 163);
		ak.TabIndex = 5;
		ak.VisualStyle = VisualStyle.Office2003;
		ap.AutoSize = true;
		ap.Checked = true;
		ap.CheckState = CheckState.Checked;
		ap.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ap.ForeColor = Color.Navy;
		ap.Location = new Point(173, 544);
		ap.Name = "checkshowBartar";
		ap.Size = new Size(214, 20);
		ap.TabIndex = 133;
		ap.Text = "نمایش نفرات برتر در اطلاع نامه";
		ap.UseVisualStyleBackColor = true;
		am.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		am.Location = new Point(331, 111);
		am.Name = "btnNew";
		am.Size = new Size(70, 89);
		am.TabIndex = 132;
		am.Text = "اضافه به لیست نمایش(+)";
		am.Click += g;
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_e.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(40, 40);
		this.m_e.Location = new Point(21, 599);
		this.m_e.Name = "btnClose";
		this.m_e.Size = new Size(134, 34);
		this.m_e.TabIndex = 110;
		this.m_e.Text = "بستن";
		this.m_e.Click += l;
		ar.Checked = true;
		ar.CheckState = CheckState.Checked;
		ar.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ar.ForeColor = Color.FromArgb(192, 0, 192);
		ar.Location = new Point(64, 570);
		ar.Name = "checkShowGread";
		ar.Size = new Size(323, 20);
		ar.TabIndex = 134;
		ar.Text = "نمایش رتبه کل و تعداد شاگرد در اطلاع نامه";
		ar.UseVisualStyleBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(784, 636);
		Controls.Add(ar);
		Controls.Add(ap);
		Controls.Add(am);
		Controls.Add(aj);
		Controls.Add(z);
		Controls.Add(s);
		Controls.Add(r);
		Controls.Add(q);
		Controls.Add(o);
		Controls.Add(p);
		Controls.Add(this.m_m);
		Controls.Add(n);
		Controls.Add(this.m_k);
		Controls.Add(this.m_l);
		Controls.Add(this.m_j);
		Controls.Add(this.m_i);
		Controls.Add(this.m_h);
		Controls.Add(this.m_g);
		Controls.Add(this.m_f);
		Controls.Add(this.m_e);
		Controls.Add(this.m_d);
		Controls.Add(this.m_c);
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRptSelectStd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "گزارشات";
		Load += b;
		KeyUp += a;
		FormClosing += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_f).EndInit();
		s.ResumeLayout(performLayout: false);
		t.ResumeLayout(performLayout: false);
		t.PerformLayout();
		((ISupportInitialize)z).EndInit();
		z.ResumeLayout(performLayout: false);
		z.PerformLayout();
		((ISupportInitialize)ac).EndInit();
		((ISupportInitialize)aj).EndInit();
		aj.ResumeLayout(performLayout: false);
		((ISupportInitialize)ak).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
