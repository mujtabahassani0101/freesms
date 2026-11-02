using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
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
			ai.Items.Add("کل", (object)"0");
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
					ai.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
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
			((CollectionBase)(object)ag.Items).Clear();
			ag.Items.Add("همه صنفها", (object)"0");
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
					ag.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
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
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)ae).Text) + "%'";
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
					flag = !(((Control)ae).Text.Trim() != "");
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
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)ad).Text) + "%'";
					num = 16;
					continue;
				case 27:
					flag = !(((Control)ad).Text.Trim() != "");
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
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		string[] array = default;
		DataTable dataTable = default;
		string a_3 = default;
		SqlParameter[] a_2 = default;
		ReportClass val = default;
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
					val = asdd.a(a_);
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
					((ReportDocument)val).Subreports[array[2].ToString()].SetDataSource(dataSource);
					num2 = 35;
					continue;
				}
				case 30:
					((ReportDocument)val).SetDataSource(dataTable);
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
					((ReportDocument)val).Subreports[array[0].ToString()].SetDataSource(dataSource);
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
					array = text.Split(new char[1] { ',' });
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
							((ReportDocument)val).ParameterFields[0].CurrentValues.AddValue((object)((Control)this.m_g).Text);
							((ReportDocument)val).ParameterFields[1].CurrentValues.AddValue((object)((Control)this.m_l).Text);
							((ReportDocument)val).ParameterFields[2].CurrentValues.AddValue((object)((Control)n).Text);
							((ReportDocument)val).ParameterFields[3].CurrentValues.AddValue((object)((Control)this.m_h).Text);
							((ReportDocument)val).ParameterFields[4].CurrentValues.AddValue((object)((Control)p).Text);
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
									((ReportDocument)val).ParameterFields[5].CurrentValues.AddValue((object)this.m_a);
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
									((ReportDocument)val).ParameterFields[5].CurrentValues.AddValue((object)"0");
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
										((ReportDocument)val).ParameterFields["showGread"].CurrentValues.AddValue((object)"0");
										num2 = 5;
									}
									else
									{
										num2 = 11;
									}
									continue;
								case 1:
									((ReportDocument)val).ParameterFields[5].CurrentValues.AddValue((object)"1");
									num2 = 0;
									continue;
								case 5:
								case 10:
									num2 = 6;
									continue;
								case 11:
									((ReportDocument)val).ParameterFields["showGread"].CurrentValues.AddValue((object)"1");
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
					asda10.a = val;
					((Form)asda10).ShowDialog();
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
						((ReportDocument)val).Subreports[array[4].ToString()].SetDataSource(dataSource);
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
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
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
					if (!(((Control)this.m_h).Text != ((Control)this.m_h).Tag.ToString()))
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
					if (!(((Control)this.m_l).Text != ((Control)this.m_l).Tag.ToString()))
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
					if (!(((Control)this.m_g).Text != ((Control)this.m_g).Tag.ToString()))
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
					if (!(((Control)n).Text != ((Control)n).Tag.ToString()))
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
					num3 = ((!(flag2.ToString() != ((Control)ar).Tag.ToString())) ? 1 : 0);
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
					((Control)s).Visible = true;
					x.Checked = false;
					w.Checked = false;
					((Control)v).Focus();
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
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)this.m_l).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)n).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)this.m_h).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)p).Text),
						asdcb.a("@sch", SqlDbType.NVarChar, ((Control)this.m_g).Text),
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
					if (!(flag2.ToString() != ((Control)ap).Tag.ToString()))
					{
						num = 55;
						continue;
					}
					goto IL_0a7d;
				case 52:
					num = 58;
					continue;
				case 58:
					if (!(((Control)p).Text != ((Control)p).Tag.ToString()))
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
		((Form)this).Close();
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
					if (!(((Control)this.m_h).Text != ((Control)this.m_h).Tag.ToString()))
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
					num2 = ((!(((Control)this.m_g).Text != ((Control)this.m_g).Tag.ToString())) ? 1 : 0);
					goto IL_022e;
				case 4:
					num = 8;
					continue;
				case 8:
					if (!(((Control)this.m_l).Text != ((Control)this.m_l).Tag.ToString()))
					{
						num = 10;
						continue;
					}
					goto IL_009e;
				case 9:
				{
					SqlParameter[] a_ = new SqlParameter[5]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)this.m_l).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)n).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)this.m_h).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)p).Text),
						asdcb.a("@sch", SqlDbType.NVarChar, ((Control)this.m_g).Text)
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
					if (!(((Control)p).Text != ((Control)p).Tag.ToString()))
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
						if (!(((Control)n).Text != ((Control)n).Tag.ToString()))
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
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
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
		((Control)s).Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		((Control)s).Visible = false;
	}

	private void h(object A_0, EventArgs A_1)
	{
		((Control)s).Visible = false;
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)ad).Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 7:
					MessageBox.Show("موردی جهت اضافه شدن وجود ندارد");
					((Control)ad).Focus();
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
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
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
					num2 = (((int)ak.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_00ee;
				case 5:
				{
					string text = ak.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrint where id=" + text);
					c();
					((Control)ad).Focus();
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
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 45;
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
					flag = (int)A_1.KeyCode != 46;
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
					((Control)ad).Focus();
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
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
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
					aq.SelectedValue = asdaj.a;
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 0:
					try
					{
						ap.Checked = bool.Parse(dataTable2.Rows[0]["showBartar"].ToString());
						((Control)ap).Tag = dataTable2.Rows[0]["showBartar"].ToString();
						ar.Checked = bool.Parse(dataTable2.Rows[0]["ShowGread"].ToString());
						((Control)ar).Tag = dataTable2.Rows[0]["ShowGread"].ToString();
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
					((Control)this.m_h).Text = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)p).Text = dataTable2.Rows[0]["Foter2"].ToString();
					((Control)this.m_l).Text = dataTable2.Rows[0]["heder1"].ToString();
					((Control)n).Text = dataTable2.Rows[0]["heder2"].ToString();
					((Control)this.m_g).Text = dataTable2.Rows[0]["sch"].ToString();
					((Control)this.m_h).Tag = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)p).Tag = dataTable2.Rows[0]["Foter2"].ToString();
					((Control)this.m_l).Tag = dataTable2.Rows[0]["heder1"].ToString();
					((Control)n).Tag = dataTable2.Rows[0]["heder2"].ToString();
					((Control)this.m_g).Tag = dataTable2.Rows[0]["sch"].ToString();
					num = 0;
					continue;
				case 11:
					((Control)ad).Focus();
					((Control)ad).Select();
					((EditBase)ad).SelectAll();
					num = 10;
					continue;
				case 10:
					return;
				case 9:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
						((Control)this).BackColor = Color.FromArgb(red, green, blue);
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
						((Form)this).Dispose(A_0);
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
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected Obj, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected Obj, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected Obj, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b28: Expected Obj, but got Unknown
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected Obj, but got Unknown
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected Obj, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected Obj, but got Unknown
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected Obj, but got Unknown
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1084: Expected Obj, but got Unknown
		//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1100: Expected Obj, but got Unknown
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Expected Obj, but got Unknown
		//IL_1323: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Expected Obj, but got Unknown
		//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1: Expected Obj, but got Unknown
		//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13df: Expected Obj, but got Unknown
		//IL_1643: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Expected Obj, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e0: Expected Obj, but got Unknown
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ad: Expected Obj, but got Unknown
		//IL_1894: Unknown result type (might be due to invalid IL or missing references)
		//IL_189e: Expected Obj, but got Unknown
		//IL_18af: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b9: Expected Obj, but got Unknown
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Expected Obj, but got Unknown
		//IL_199b: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a5: Expected Obj, but got Unknown
		//IL_19b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c0: Expected Obj, but got Unknown
		//IL_1a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3d: Expected Obj, but got Unknown
		//IL_1ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af2: Expected Obj, but got Unknown
		//IL_1b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0d: Expected Obj, but got Unknown
		//IL_1bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be5: Expected Obj, but got Unknown
		//IL_1c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7f: Expected Obj, but got Unknown
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9a: Expected Obj, but got Unknown
		//IL_1da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1daa: Expected Obj, but got Unknown
		//IL_1e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e34: Expected Obj, but got Unknown
		//IL_1ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed7: Expected Obj, but got Unknown
		//IL_1fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbe: Expected Obj, but got Unknown
		//IL_207a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2084: Expected Obj, but got Unknown
		//IL_211a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2124: Expected Obj, but got Unknown
		//IL_21c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cb: Expected Obj, but got Unknown
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e7: Expected Obj, but got Unknown
		//IL_22a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ac: Expected Obj, but got Unknown
		//IL_2577: Unknown result type (might be due to invalid IL or missing references)
		//IL_2581: Expected Obj, but got Unknown
		//IL_258a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2594: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbw));
		GridEXLayout val2 = new GridEXLayout();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		StringFormat val9 = new StringFormat();
		GridEXLayout val10 = new GridEXLayout();
		StringFormat val11 = new StringFormat();
		StringFormat val12 = new StringFormat();
		GridEXLayout val13 = new GridEXLayout();
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
		((Control)s).SuspendLayout();
		((Control)t).SuspendLayout();
		((ISupportInitialize)z).BeginInit();
		((Control)z).SuspendLayout();
		((ISupportInitialize)ac).BeginInit();
		((ISupportInitialize)aj).BeginInit();
		((Control)aj).SuspendLayout();
		((ISupportInitialize)ak).BeginInit();
		((Control)this).SuspendLayout();
		this.m_c.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_c).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = val;
		this.m_c.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_c).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_c.GroupByBoxVisible = false;
		((Control)this.m_c).Location = new Point(199, 248);
		((Control)this.m_c).Name = "gridEX1";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		this.m_c.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_c).Size = new Size(575, 168);
		((Control)this.m_c).TabIndex = 0;
		((ScrollableBase)this.m_c).VisualStyle = (VisualStyle)2;
		this.m_c.SelectionChanged += j;
		((Control)this.m_d).Anchor = (AnchorStyles)10;
		((Control)this.m_d).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(174, 599);
		((Control)this.m_d).Name = "btnview";
		((Control)this.m_d).Size = new Size(122, 34);
		((Control)this.m_d).TabIndex = 1;
		((Control)this.m_d).Text = "نمایش گزارش";
		((Control)this.m_d).Click += m;
		((Control)this.m_f).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_f.DesignTimeLayout = val2;
		this.m_f.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_f).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_f.GroupByBoxVisible = false;
		((Control)this.m_f).Location = new Point(1, 248);
		((Control)this.m_f).Name = "gExam";
		this.m_f.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_f).Size = new Size(193, 166);
		((Control)this.m_f).TabIndex = 111;
		((ScrollableBase)this.m_f).VisualStyle = (VisualStyle)2;
		((Control)this.m_f).Click += h;
		((EditBase)this.m_g).AutoScroll = false;
		((EditBase)this.m_g).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_g).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_g).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(413, 523);
		((EditBase)this.m_g).MaxLength = 300;
		((Control)this.m_g).Name = "txtSch";
		((Control)this.m_g).Size = new Size(263, 23);
		((Control)this.m_g).TabIndex = 112;
		((EditBase)this.m_g).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_h).AutoScroll = false;
		((EditBase)this.m_h).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_h).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_h).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(413, 551);
		((EditBase)this.m_h).MaxLength = 300;
		((Control)this.m_h).Name = "txtFoter1";
		((Control)this.m_h).Size = new Size(263, 23);
		((Control)this.m_h).TabIndex = 113;
		((EditBase)this.m_h).TextAlignment = (TextAlignment)1;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(679, 527);
		((Control)this.m_i).Name = "label1";
		((Control)this.m_i).Size = new Size(57, 20);
		((Control)this.m_i).TabIndex = 114;
		((Control)this.m_i).Text = "نام مکتب :";
		((Control)this.m_j).AutoSize = true;
		((Control)this.m_j).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(680, 553);
		((Control)this.m_j).Name = "label2";
		((Control)this.m_j).Size = new Size(50, 20);
		((Control)this.m_j).TabIndex = 115;
		((Control)this.m_j).Text = "نام مدیر :";
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_k).Location = new Point(681, 421);
		((Control)this.m_k).Name = "label3";
		((Control)this.m_k).Size = new Size(71, 20);
		((Control)this.m_k).TabIndex = 117;
		((Control)this.m_k).Text = "بالای گزارش :";
		((EditBase)this.m_l).AutoScroll = false;
		((EditBase)this.m_l).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_l).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Location = new Point(12, 419);
		((EditBase)this.m_l).MaxLength = 300;
		((Control)this.m_l).Name = "txtHeder1";
		((Control)this.m_l).Size = new Size(664, 23);
		((Control)this.m_l).TabIndex = 116;
		((EditBase)this.m_l).TextAlignment = (TextAlignment)1;
		((Control)this.m_m).AutoSize = true;
		((Control)this.m_m).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_m).Location = new Point(679, 495);
		((Control)this.m_m).Name = "label4";
		((Control)this.m_m).Size = new Size(56, 20);
		((Control)this.m_m).TabIndex = 119;
		((Control)this.m_m).Text = "پیام مدیر :";
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(12, 494);
		((EditBase)n).MaxLength = 300;
		((Control)n).Name = "txtHeder2";
		((Control)n).Size = new Size(664, 23);
		((Control)n).TabIndex = 118;
		((EditBase)n).TextAlignment = (TextAlignment)1;
		((Control)o).AutoSize = true;
		((Control)o).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(679, 472);
		((Control)o).Name = "label5";
		((Control)o).Size = new Size(86, 20);
		((Control)o).TabIndex = 121;
		((Control)o).Text = "پایین اطلاع نامه :";
		((EditBase)p).AutoScroll = false;
		((EditBase)p).AutoScrollMargin = new Size(0, 0);
		((EditBase)p).AutoScrollMinSize = new Size(0, 0);
		((EditBase)p).AutoScrollPosition = new Point(0, 0);
		((Control)p).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(12, 468);
		((EditBase)p).MaxLength = 300;
		((Control)p).Name = "txtFoter2";
		((Control)p).Size = new Size(664, 23);
		((Control)p).TabIndex = 120;
		((EditBase)p).TextAlignment = (TextAlignment)1;
		((Control)q).AutoSize = true;
		q.Checked = true;
		q.CheckState = (CheckState)1;
		((Control)q).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(12, 520);
		((Control)q).Name = "checkSp2";
		((Control)q).Size = new Size(375, 20);
		((Control)q).TabIndex = 125;
		((Control)q).Text = "فقط درس های دارای نمره را  در گزارش نمایش داده شود";
		((ButtonBase)q).UseVisualStyleBackColor = true;
		((Control)r).AutoSize = true;
		((Control)r).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).ForeColor = Color.Red;
		((Control)r).Location = new Point(90, 446);
		((Control)r).Name = "label6";
		((Control)r).Size = new Size(598, 20);
		((Control)r).TabIndex = 126;
		((Control)r).Text = "در صورتی که برای شاگرد در منوی توضیحات زیر اطلاع نامه توضیحی ثبت شده باشد به جای پایین اطلاع نامه نمایش داده خواهد شد";
		((Control)s).BackColor = Color.Gray;
		s.BorderStyle = (BorderStyle)1;
		((Control)s).Controls.Add((Control)(object)t);
		((Control)s).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)s).Location = new Point(218, 246);
		((Control)s).Name = "pSort";
		((Control)s).Size = new Size(338, 204);
		((Control)s).TabIndex = 129;
		((Control)s).Visible = false;
		((Control)t).BackColor = Color.FromArgb(214, 223, 247);
		t.BorderStyle = (BorderStyle)2;
		((Control)t).Controls.Add((Control)(object)w);
		((Control)t).Controls.Add((Control)(object)x);
		((Control)t).Controls.Add((Control)(object)y);
		((Control)t).Controls.Add((Control)(object)u);
		((Control)t).Controls.Add((Control)(object)v);
		((Control)t).Location = new Point(6, 7);
		((Control)t).Name = "panel1";
		((Control)t).Size = new Size(321, 186);
		((Control)t).TabIndex = 40;
		((Control)w).AutoSize = true;
		((Control)w).Location = new Point(135, 88);
		((Control)w).Name = "radioButton2";
		((Control)w).Size = new Size(99, 32);
		((Control)w).TabIndex = 1;
		w.TabStop = true;
		((Control)w).Text = "ردیف و الفبا";
		((ButtonBase)w).UseVisualStyleBackColor = true;
		((Control)x).AutoSize = true;
		((Control)x).Location = new Point(180, 50);
		((Control)x).Name = "radioButton1";
		((Control)x).Size = new Size(54, 32);
		((Control)x).TabIndex = 0;
		x.TabStop = true;
		((Control)x).Text = "نمره";
		((ButtonBase)x).UseVisualStyleBackColor = true;
		((Control)y).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(17, 10);
		((Control)y).Name = "label9";
		((Control)y).Size = new Size(255, 37);
		((Control)y).TabIndex = 130;
		((Control)y).Text = "ترتیب شاگردان در  گزارش بر اساس";
		u.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)u).Location = new Point(40, 132);
		((Control)u).Name = "btnCancel";
		((Control)u).Size = new Size(117, 38);
		((Control)u).TabIndex = 5;
		((Control)u).Text = "انصراف";
		((Control)u).Click += i;
		v.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)v).Location = new Point(163, 132);
		((Control)v).Name = "btnAcp";
		((Control)v).Size = new Size(104, 38);
		((Control)v).TabIndex = 4;
		((Control)v).Text = "تایید";
		((Control)v).Click += k;
		((Control)z).Anchor = (AnchorStyles)13;
		((Control)z).Controls.Add((Control)(object)aq);
		((Control)z).Controls.Add((Control)(object)ao);
		((Control)z).Controls.Add((Control)(object)aa);
		((Control)z).Controls.Add((Control)(object)ab);
		((Control)z).Controls.Add((Control)(object)ac);
		((Control)z).Controls.Add((Control)(object)ad);
		((Control)z).Controls.Add((Control)(object)ae);
		((Control)z).Controls.Add((Control)(object)af);
		((Control)z).Controls.Add((Control)(object)ag);
		((Control)z).Controls.Add((Control)(object)ah);
		((Control)z).Controls.Add((Control)(object)ai);
		((Control)z).Font = new Font("Tahoma", 8.25f);
		((Control)z).Location = new Point(407, 2);
		((Control)z).Name = "uiGroupBox1";
		((Control)z).Size = new Size(349, 239);
		((Control)z).TabIndex = 130;
		((Control)z).Text = "جستجو";
		((UIComboBase)aq).ComboStyle = (ComboStyle)1;
		((UIComboBase)aq).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)aq).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val3.FormatStyle.Alpha = 0;
		val3.Text = "1403";
		val3.Value = "1403";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1402";
		val4.Value = "1402";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1401";
		val5.Value = "1401";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1400";
		val6.Value = "1400";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1399";
		val7.Value = "1399";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "1398";
		val8.Value = "1398";
		aq.Items.AddRange(new UIComboBoxItem[6] { val3, val4, val5, val6, val7, val8 });
		((Control)aq).Location = new Point(15, 45);
		((Control)aq).Name = "dropYear";
		((Control)aq).Size = new Size(97, 23);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)aq).StringFormat = val9;
		((Control)aq).TabIndex = 136;
		aq.SelectedIndexChanged += a;
		((Control)ao).AutoSize = true;
		((Control)ao).Location = new Point(24, 22);
		((Control)ao).Name = "label10";
		((Control)ao).Size = new Size(66, 13);
		((Control)ao).TabIndex = 133;
		((Control)ao).Text = "سال تعلیمی";
		((Control)aa).Anchor = (AnchorStyles)9;
		((Control)aa).AutoSize = true;
		((Control)aa).Font = new Font("Tahoma", 8.25f);
		((Control)aa).Location = new Point(145, 82);
		((Control)aa).Name = "label7";
		((Control)aa).Size = new Size(21, 13);
		((Control)aa).TabIndex = 29;
		((Control)aa).Text = "ولد";
		((Control)ab).Anchor = (AnchorStyles)9;
		((Control)ab).AutoSize = true;
		((Control)ab).Font = new Font("Tahoma", 8.25f);
		((Control)ab).Location = new Point(307, 81);
		((Control)ab).Name = "label8";
		((Control)ab).Size = new Size(20, 13);
		((Control)ab).TabIndex = 28;
		((Control)ab).Text = "نام";
		ac.AllowEdit = (InheritableBoolean)2;
		((Control)ac).Anchor = (AnchorStyles)15;
		val10.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		ac.DesignTimeLayout = val10;
		ac.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)ac).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		ac.GroupByBoxVisible = false;
		((Control)ac).Location = new Point(10, 109);
		((Control)ac).Name = "gridStdSearch";
		((ScrollableBase)ac).RecordNavigator = true;
		ac.RowHeaders = (InheritableBoolean)1;
		((Control)ac).Size = new Size(332, 118);
		((Control)ac).TabIndex = 5;
		((ScrollableBase)ac).VisualStyle = (VisualStyle)2;
		((Control)ad).Anchor = (AnchorStyles)9;
		((EditBase)ad).AutoScroll = false;
		((EditBase)ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ad).AutoScrollPosition = new Point(0, 0);
		((EditBase)ad).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ad).Font = new Font("Tahoma", 8.25f);
		((Control)ad).Location = new Point(20, 78);
		((Control)ad).Name = "txtLName";
		((Control)ad).RightToLeft = (RightToLeft)1;
		((Control)ad).Size = new Size(119, 21);
		((Control)ad).TabIndex = 4;
		((EditBase)ad).TextAlignment = (TextAlignment)1;
		((Control)ad).KeyUp += c;
		((Control)ae).Anchor = (AnchorStyles)9;
		((EditBase)ae).AutoScroll = false;
		((EditBase)ae).AutoScrollMargin = new Size(0, 0);
		((EditBase)ae).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ae).AutoScrollPosition = new Point(0, 0);
		((EditBase)ae).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ae).Font = new Font("Tahoma", 8.25f);
		((Control)ae).Location = new Point(182, 78);
		((Control)ae).Name = "txtFName";
		((Control)ae).RightToLeft = (RightToLeft)1;
		((Control)ae).Size = new Size(119, 21);
		((Control)ae).TabIndex = 3;
		((EditBase)ae).TextAlignment = (TextAlignment)1;
		((Control)ae).KeyUp += b;
		((Control)af).Anchor = (AnchorStyles)9;
		((Control)af).AutoSize = true;
		((Control)af).Location = new Point(307, 47);
		((Control)af).Name = "label19";
		((Control)af).Size = new Size(30, 13);
		((Control)af).TabIndex = 25;
		((Control)af).Text = "صنف";
		((Control)ag).Anchor = (AnchorStyles)9;
		((UIComboBase)ag).ComboStyle = (ComboStyle)1;
		((UIComboBase)ag).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ag).Font = new Font("Tahoma", 8.25f);
		((Control)ag).Location = new Point(127, 45);
		((Control)ag).Name = "dropCls";
		((Control)ag).Size = new Size(174, 21);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)ag).StringFormat = val11;
		((Control)ag).TabIndex = 2;
		ag.SelectedIndexChanged += e;
		((Control)ah).Anchor = (AnchorStyles)9;
		((Control)ah).AutoSize = true;
		((Control)ah).Font = new Font("Tahoma", 8.25f);
		((Control)ah).Location = new Point(307, 24);
		((Control)ah).Name = "label20";
		((Control)ah).Size = new Size(22, 13);
		((Control)ah).TabIndex = 15;
		((Control)ah).Text = "پایه";
		((Control)ai).Anchor = (AnchorStyles)9;
		((UIComboBase)ai).ComboStyle = (ComboStyle)1;
		((UIComboBase)ai).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ai).Font = new Font("Tahoma", 8.25f);
		((Control)ai).Location = new Point(127, 18);
		((Control)ai).Name = "dropPaye";
		((Control)ai).Size = new Size(174, 21);
		val12.Alignment = (StringAlignment)0;
		val12.FormatFlags = (StringFormatFlags)20485;
		val12.HotkeyPrefix = (HotkeyPrefix)0;
		val12.LineAlignment = (StringAlignment)1;
		val12.Trimming = (StringTrimming)1;
		((UIComboBase)ai).StringFormat = val12;
		((Control)ai).TabIndex = 1;
		ai.SelectedIndexChanged += d;
		((Control)aj).Anchor = (AnchorStyles)13;
		((Control)aj).Controls.Add((Control)(object)an);
		((Control)aj).Controls.Add((Control)(object)al);
		((Control)aj).Controls.Add((Control)(object)ak);
		((Control)aj).Font = new Font("Tahoma", 8.25f);
		((Control)aj).Location = new Point(5, 7);
		((Control)aj).Name = "uiGroupBox2";
		((Control)aj).Size = new Size(320, 234);
		((Control)aj).TabIndex = 131;
		((Control)aj).Text = "لیست شاگردان جهت نمایش در گزارش";
		((Control)an).Anchor = (AnchorStyles)6;
		an.Image = (Image)componentResourceManager.GetObject("btnFree.Image");
		((Control)an).Location = new Point(7, 191);
		((Control)an).Name = "btnFree";
		((Control)an).Size = new Size(162, 35);
		((Control)an).TabIndex = 134;
		((Control)an).Text = "خالی کرد کل لیست نمایش";
		((Control)an).Click += c;
		((Control)al).Anchor = (AnchorStyles)6;
		al.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)al).Location = new Point(175, 191);
		((Control)al).Name = "btnDelete";
		((Control)al).Size = new Size(134, 35);
		((Control)al).TabIndex = 133;
		((Control)al).Text = "حذف مورد انتخابی از لیست نمایش";
		((Control)al).Click += f;
		ak.AllowEdit = (InheritableBoolean)2;
		((Control)ak).Anchor = (AnchorStyles)15;
		val13.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		ak.DesignTimeLayout = val13;
		ak.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)ak).Font = new Font("Tahoma", 8.25f);
		ak.GroupByBoxVisible = false;
		((Control)ak).Location = new Point(7, 23);
		((Control)ak).Name = "gSelectStd";
		((ScrollableBase)ak).RecordNavigator = true;
		ak.RowHeaders = (InheritableBoolean)1;
		((Control)ak).Size = new Size(303, 163);
		((Control)ak).TabIndex = 5;
		((ScrollableBase)ak).VisualStyle = (VisualStyle)2;
		((Control)ap).AutoSize = true;
		ap.Checked = true;
		ap.CheckState = (CheckState)1;
		((Control)ap).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ap).ForeColor = Color.Navy;
		((Control)ap).Location = new Point(173, 544);
		((Control)ap).Name = "checkshowBartar";
		((Control)ap).Size = new Size(214, 20);
		((Control)ap).TabIndex = 133;
		((Control)ap).Text = "نمایش نفرات برتر در اطلاع نامه";
		((ButtonBase)ap).UseVisualStyleBackColor = true;
		am.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)am).Location = new Point(331, 111);
		((Control)am).Name = "btnNew";
		((Control)am).Size = new Size(70, 89);
		((Control)am).TabIndex = 132;
		((Control)am).Text = "اضافه به لیست نمایش(+)";
		((Control)am).Click += g;
		((Control)this.m_e).Anchor = (AnchorStyles)6;
		((Control)this.m_e).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(40, 40);
		((Control)this.m_e).Location = new Point(21, 599);
		((Control)this.m_e).Name = "btnClose";
		((Control)this.m_e).Size = new Size(134, 34);
		((Control)this.m_e).TabIndex = 110;
		((Control)this.m_e).Text = "بستن";
		((Control)this.m_e).Click += l;
		ar.Checked = true;
		ar.CheckState = (CheckState)1;
		((Control)ar).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ar).ForeColor = Color.FromArgb(192, 0, 192);
		((Control)ar).Location = new Point(64, 570);
		((Control)ar).Name = "checkShowGread";
		((Control)ar).Size = new Size(323, 20);
		((Control)ar).TabIndex = 134;
		((Control)ar).Text = "نمایش رتبه کل و تعداد شاگرد در اطلاع نامه";
		((ButtonBase)ar).UseVisualStyleBackColor = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(784, 636);
		((Control)this).Controls.Add((Control)(object)ar);
		((Control)this).Controls.Add((Control)(object)ap);
		((Control)this).Controls.Add((Control)(object)am);
		((Control)this).Controls.Add((Control)(object)aj);
		((Control)this).Controls.Add((Control)(object)z);
		((Control)this).Controls.Add((Control)(object)s);
		((Control)this).Controls.Add((Control)(object)r);
		((Control)this).Controls.Add((Control)(object)q);
		((Control)this).Controls.Add((Control)(object)o);
		((Control)this).Controls.Add((Control)(object)p);
		((Control)this).Controls.Add((Control)(object)this.m_m);
		((Control)this).Controls.Add((Control)(object)n);
		((Control)this).Controls.Add((Control)(object)this.m_k);
		((Control)this).Controls.Add((Control)(object)this.m_l);
		((Control)this).Controls.Add((Control)(object)this.m_j);
		((Control)this).Controls.Add((Control)(object)this.m_i);
		((Control)this).Controls.Add((Control)(object)this.m_h);
		((Control)this).Controls.Add((Control)(object)this.m_g);
		((Control)this).Controls.Add((Control)(object)this.m_f);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmRptSelectStd";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "گزارشات";
		((Form)this).Load += b;
		((Control)this).KeyUp += a;
		((Form)this).FormClosing += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_f).EndInit();
		((Control)s).ResumeLayout(false);
		((Control)t).ResumeLayout(false);
		((Control)t).PerformLayout();
		((ISupportInitialize)z).EndInit();
		((Control)z).ResumeLayout(false);
		((Control)z).PerformLayout();
		((ISupportInitialize)ac).EndInit();
		((ISupportInitialize)aj).EndInit();
		((Control)aj).ResumeLayout(false);
		((ISupportInitialize)ak).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
