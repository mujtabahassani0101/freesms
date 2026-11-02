using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdb : Form
{
	private bool m_a;

	private int m_b = 0;

	private bool m_c;

	private string m_d = "";

	private int m_e;

	private IContainer m_f = null;

	private Panel m_g;

	private Panel m_h;

	private UIButton m_i;

	private UIButton j;

	private Panel k;

	private UIButton l;

	private Panel m;

	private UIButton n;

	private Panel o;

	private GridEX p;

	private Label q;

	private ComboBox r;

	private GridEX s;

	private Label t;

	private Label u;

	private Label v;

	private ComboBox w;

	private CheckBox x;

	private Label y;

	private EditBox z;

	private UIButton aa;

	private UIButton ab;

	private Label ac;

	private CheckBox ad;

	private UIButton ae;

	private Label af;

	private Label ag;

	public asdb()
	{
		a();
	}

	private void i(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("14");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 0;
					continue;
				case 7:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_h.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 4:
				{
					af.Text = asdaj.__field_a;
					this.m_a = false;
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					dictionary.Add("1", "اوسط شاگرد از بالا به پایین");
					dictionary.Add("2", "اوسط شاگرد از پایین به بالا");
					dictionary.Add("3", "تصادفی");
					dictionary.Add("4", "شماره ترتیب شاگرد");
					w.DataSource = new BindingSource(dictionary, null);
					w.DisplayMember = "Value";
					w.ValueMember = "Key";
					b();
					this.m_a = true;
					c();
					num = 1;
					continue;
				}
				case 1:
					return;
				case 5:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 2;
					continue;
				case 2:
					return;
				case 3:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 4:
					num = (this.m_a ? 7 : 0);
					continue;
				case 1:
					num = 2;
					continue;
				case 2:
					return;
				case 3:
					return;
				case 0:
					num3 = 0;
					goto IL_0125;
				case 7:
					num = 6;
					continue;
				case 6:
					num3 = ((r.Items.Count != 0) ? 1 : 0);
					goto IL_0125;
				case 5:
					{
						if (flag)
						{
							int num2 = this.m_e;
							DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.idx,tmpMoadel.moadel\r\n                    FROM         tStudent  INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                                          tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                                          tClass ON tYear_Student.xClass = tClass.id  left outer join \r\n                    (SELECT     ROUND(AVG(MarkDoreh), 2) AS moadel, xStudent\r\n                    FROM         tMarkDoreh\r\n                    WHERE     (typ = 5) and xtest in(select id from texam where xyear=" + af.Text + ")\r\n                    GROUP BY xStudent) tmpMoadel on tStudent.id=tmpMoadel.xStudent\r\n                    WHERE   tYear_Student.xYear=" + af.Text + " and (tYear_Student.xhozeh = " + r.SelectedValue.ToString() + ")");
							p.DataSource = dataSource;
							num = 3;
						}
						else
						{
							num = 1;
						}
						continue;
					}
					IL_0125:
					flag = (byte)num3 != 0;
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

	private void h(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tYear_Student where xYear=" + af.Text + " and xHozeh=" + r.SelectedValue.ToString()).ToString();
			bool flag = !(text != "0");
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
					this.m_d = "پایه";
					s.RootTable.Columns["name"].Caption = "پایه";
					s.RootTable.Columns["countPaye"].Caption = "تعداد شاگردان پایه";
					s.RootTable.Columns["countStdHozeh"].Caption = "تعداد پایه در این حوزه";
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT name , Capacity   FROM  tHozeh where id=" + r.SelectedValue.ToString());
					t.Text = dataTable.Rows[0]["name"].ToString();
					u.Text = "ظرفیت حوزه : " + dataTable.Rows[0]["Capacity"].ToString();
					this.m_b = int.Parse(dataTable.Rows[0]["Capacity"].ToString());
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT isnull(max(idx),0)+1   FROM  tYear_Student where xYear=" + af.Text).ToString();
					z.Text = text2;
					k.Visible = true;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tmpPaye.*,isnull(tmpHoze.countStdHozeh,0) as countStdHozeh,isnull(tmpNoHoze.countStdNoHozeh,0) as countStdNoHozeh,null as m1\r\n                    from\r\n                    (SELECT   tPaye.id ,  tPaye.Name, COUNT(tYear_Student.id) AS countPaye\r\n                    FROM   tStudent inner join   tYear_Student  \r\n                    ON  tStudent.id =tYear_Student.xStudent INNER JOIN   tPaye \r\n                     ON tYear_Student.xPaye=tPaye.id \r\n                    where tYear_Student.xYear=" + af.Text + "\r\n                    GROUP BY  tPaye.id , tPaye.Name)tmpPaye left outer join \r\n                    (SELECT     tPaye.id AS xpaye, COUNT(tYear_Student.id) AS countStdHozeh\r\n                     FROM   tStudent inner join   tYear_Student  \r\n                     ON  tStudent.id =tYear_Student.xStudent INNER JOIN   tPaye \r\n                     ON tYear_Student.xPaye=tPaye.id \r\n                    WHERE    tYear_Student.xYear=" + af.Text + " and (tYear_Student.xhozeh = " + r.SelectedValue.ToString() + ")\r\n                    GROUP BY tPaye.id)tmpHoze on tmpPaye.id=tmpHoze.xpaye\r\n                    left outer join \r\n                    (SELECT     tPaye.id AS xpaye, COUNT(tYear_Student.id) AS countStdNoHozeh\r\n                     FROM   tStudent inner join   tYear_Student  \r\n                     ON  tStudent.id =tYear_Student.xStudent INNER JOIN   tPaye \r\n                     ON tYear_Student.xPaye=tPaye.id \r\n                    WHERE   tYear_Student.xYear=" + af.Text + " and (tYear_Student.xhozeh is null)\r\n                    GROUP BY tPaye.id)tmpNoHoze on tmpPaye.id=tmpNoHoze.xpaye");
					s.DataSource = dataSource;
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 2:
					MessageBox.Show("این حوزه داری شاگرد هست وامکان اختصاص مجدد وجود ندارد");
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

	private void g(object A_0, EventArgs A_1)
	{
		k.Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		int num3 = default;
		int num7 = default;
		int num8 = default;
		int num2 = default;
		int num5 = default;
		string text3 = default;
		int num4 = default;
		string text2 = default;
		while (true)
		{
			string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tYear_Student where xyear=" + af.Text + " and xHozeh=" + r.SelectedValue.ToString()).ToString();
			bool flag = !(text != "0");
			int num = 9;
			while (true)
			{
				int num6;
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 35;
				case 36:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 19;
				case 54:
					flag = !(w.SelectedValue.ToString() == "1");
					num = 45;
					continue;
				case 45:
					if (!flag)
					{
						num = 57;
						continue;
					}
					flag = !(w.SelectedValue.ToString() == "2");
					num = 40;
					continue;
				case 55:
					num3++;
					num = 23;
					continue;
				case 22:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 2;
				case 56:
					text2 += " newid()";
					num = 31;
					continue;
				case 39:
					num = 26;
					continue;
				case 26:
					num6 = ((num7 < 5) ? 1 : 0);
					goto IL_090d;
				case 57:
					text2 += " tmpMoadel.moadel desc";
					num = 19;
					continue;
				case 23:
				case 51:
					flag = num3 < s.RowCount;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 49;
						continue;
					}
					flag = !(s.GetRow(num3).Cells["m1"].Value.ToString() != "");
					num = 44;
					continue;
				case 2:
					num7++;
					num = 14;
					continue;
				case 42:
					c();
					k.Visible = false;
					num = 32;
					continue;
				case 32:
					return;
				case 53:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 6;
				case 8:
					k.Visible = false;
					num = 35;
					continue;
				case 0:
					if (flag)
					{
						num8 += num2;
						num = 55;
					}
					else
					{
						num = 25;
					}
					continue;
				case 17:
					MessageBox.Show("مجموع اعداد وارد شده " + num8 + " میباشد که بیشتر از ظرفیت حوزه میباشد \n یا ظرفیت حوزه را زیاد کنید یا اعداد وارد شده را کم کنید");
					num = 37;
					continue;
				case 37:
					return;
				case 7:
				case 14:
					num = 48;
					continue;
				case 48:
					num = ((!this.m_c) ? 30 : 39);
					continue;
				case 50:
					num3++;
					num = 5;
					continue;
				case 38:
					try
					{
						num5 = int.Parse(z.Text);
					}
					catch
					{
						MessageBox.Show("برای شماره شروع فقط عدد وارد کنید");
						z.Focus();
						return;
					}
					text2 = "";
					text3 = "tYear_Student.xpaye";
					flag = !(this.m_d == "صنف");
					num = 53;
					continue;
				case 11:
					text2 += " tmpMoadel.moadel";
					num = 33;
					continue;
				case 28:
					MessageBox.Show("مجموع اعداد وارد شده " + num8 + " میباشد که کمتر از ظرفیت حوزه میباشد \n یا ظرفیت حوزه را کم کنید یا اعداد وارد شده را زیاد کنید");
					num = 16;
					continue;
				case 16:
					return;
				case 25:
					s.Row = num3;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					MessageBox.Show("عدد وارد شده بیشتر از شاگردان فاقد حوزه در آن " + this.m_d + " هست ");
					num = 1;
					continue;
				case 1:
					return;
				case 52:
					num7 = 0;
					num = 7;
					continue;
				case 27:
					if (!flag)
					{
						num = 28;
						continue;
					}
					num5 = 0;
					num = 38;
					continue;
				case 49:
					flag = num8 <= this.m_b;
					num = 43;
					continue;
				case 43:
					if (flag)
					{
						flag = num8 >= this.m_b;
						num = 27;
					}
					else
					{
						num = 17;
					}
					continue;
				case 21:
					text2 += " tclass.sortBarchasb,tYear_Student.xclass,";
					num = 54;
					continue;
				case 35:
					this.m_c = true;
					num8 = 0;
					num2 = 0;
					num4 = 0;
					num3 = 0;
					num = 51;
					continue;
				case 10:
				{
					string text5 = s.GetRow(num3).Cells["m1"].Value.ToString();
					string text6 = s.GetRow(num3).Cells["id"].Value.ToString();
					text2 = "SELECT  top " + text5 + " tStudent.id\r\n                    FROM         tStudent inner join   tYear_Student  \r\n                    ON  tStudent.id =tYear_Student.xStudent   left outer join \r\n                    (SELECT     ROUND(AVG(MarkDoreh), 2) AS moadel, xStudent\r\n                    FROM         tMarkDoreh\r\n                    WHERE     (typ = 5)  and xtest in(select id from texam where xyear=" + af.Text + ")\r\n                    GROUP BY xStudent) tmpMoadel on tStudent.id=tmpMoadel.xStudent  inner join tclass\r\n                    on tYear_Student.xClass=tclass.id            \r\n                    where  tYear_Student.xYear=" + af.Text + " and tYear_Student.xhozeh is null and " + text3 + " =" + text6;
					text2 += " order by ";
					flag = !ad.Checked;
					num = 47;
					continue;
				}
				case 47:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 54;
				case 6:
					num3 = 0;
					num = 29;
					continue;
				case 5:
				case 29:
					if (true)
					{
					}
					flag = num3 < s.RowCount;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 52;
						continue;
					}
					flag = !(s.GetRow(num3).Cells["m1"].Value.ToString() != "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 50;
				case 30:
					num6 = 0;
					goto IL_090d;
				case 13:
					num2 = 0;
					num4 = int.Parse(s.GetRow(num3).Cells["countStdNoHozeh"].Value.ToString());
					num = 46;
					continue;
				case 44:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 55;
				case 34:
					if (flag)
					{
						a(x.Checked, r.SelectedValue.ToString(), num5.ToString(), w.SelectedValue.ToString());
						string text4 = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(*) AS countStd FROM  tYear_Student WHERE xyear=" + af.Text + " and idx is null and xhozeh=" + r.SelectedValue.ToString()).ToString();
						flag = !(text4 == "0");
						num = 22;
					}
					else
					{
						num = 42;
					}
					continue;
				case 12:
					text3 = "tYear_Student.xclass";
					num = 6;
					continue;
				case 46:
					try
					{
						num2 = int.Parse(s.GetRow(num3).Cells["m1"].Value.ToString());
					}
					catch
					{
						s.Row = num3;
						s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
						s.Select();
						s.SelectCurrentCellText();
						MessageBox.Show("فقط عدد وارد کنید");
						return;
					}
					flag = num2 <= num4;
					num = 0;
					continue;
				case 19:
				case 31:
				case 33:
				case 41:
					asdcb.c(asdab.e(), CommandType.Text, "update tYear_Student set xhozeh= " + r.SelectedValue.ToString() + " where xyear=" + af.Text + " and xStudent in(" + text2 + ")");
					num = 50;
					continue;
				case 40:
					if (!flag)
					{
						num = 11;
						continue;
					}
					flag = !(w.SelectedValue.ToString() == "3");
					num = 18;
					continue;
				case 18:
					if (flag)
					{
						flag = !(w.SelectedValue.ToString() == "4");
						num = 36;
					}
					else
					{
						num = 56;
					}
					continue;
				case 24:
					this.m_c = false;
					num = 2;
					continue;
				case 20:
					{
						text2 += " tYear_Student.sort,tStudent.fname ,tStudent.lname";
						num = 41;
						continue;
					}
					IL_090d:
					flag = (byte)num6 != 0;
					num = 34;
					continue;
				}
				break;
			}
		}
	}

	private void a(bool A_0, string A_1, string A_2, string A_3)
	{
		while (true)
		{
			string text = "idx";
			bool flag = A_0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						if (true)
						{
						}
						num = 2;
						continue;
					}
					goto case 3;
				case 0:
					text += "_SortClass";
					num = 1;
					continue;
				case 3:
					flag = !ad.Checked;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 2:
					text = "idxSortPaye";
					num = 3;
					continue;
				case 1:
				{
					SqlParameter[] a_ = new SqlParameter[4]
					{
						asdcb.a("@xYear", SqlDbType.Int, af.Text),
						asdcb.a("@xHozeh", SqlDbType.Int, A_1),
						asdcb.a("@Start", SqlDbType.Int, A_2),
						asdcb.a("@sort", SqlDbType.Int, A_3)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, text, a_);
					return;
				}
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b()
	{
		try
		{
			bool flag = default;
			while (true)
			{
				DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT id,Name from tHozeh");
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				int num = 0;
				int num2 = 4;
				while (true)
				{
					switch (num2)
					{
					case 0:
					case 4:
						flag = num < dataTable.Rows.Count;
						if (true)
						{
						}
						num2 = 1;
						continue;
					case 1:
						if (flag)
						{
							dictionary.Add(dataTable.Rows[num]["id"].ToString(), dataTable.Rows[num]["name"].ToString());
							num++;
							num2 = 0;
						}
						else
						{
							num2 = 3;
						}
						continue;
					case 3:
						r.DataSource = new BindingSource(dictionary, null);
						r.DisplayMember = "Value";
						r.ValueMember = "Key";
						num2 = 2;
						continue;
					case 2:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tYear_Student where xYear=" + af.Text + " and xHozeh=" + r.SelectedValue.ToString()).ToString();
			bool flag = !(text != "0");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
				{
					if (!flag)
					{
						num = 2;
						continue;
					}
					this.m_d = "صنف";
					s.RootTable.Columns["name"].Caption = "صنف";
					s.RootTable.Columns["countPaye"].Caption = "تعداد شاگردان صنف";
					s.RootTable.Columns["countStdHozeh"].Caption = "تعداد صنف در این حوزه";
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT name , Capacity   FROM  tHozeh where id=" + r.SelectedValue.ToString());
					t.Text = dataTable.Rows[0]["name"].ToString();
					u.Text = "ظرفیت حوزه : " + dataTable.Rows[0]["Capacity"].ToString();
					this.m_b = int.Parse(dataTable.Rows[0]["Capacity"].ToString());
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT isnull(max(idx),0)+1  FROM  tYear_Student where xYear=" + af.Text).ToString();
					z.Text = text2;
					k.Visible = true;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tmpClass.*,isnull(tmpHoze.countStdHozeh,0) as countStdHozeh,isnull(tmpNoHoze.countStdNoHozeh,0) as countStdNoHozeh,null as m1\r\n                    from\r\n                    (SELECT   tclass.id ,  tclass.Name, COUNT(tYear_Student.id) AS countPaye\r\n                       FROM    tStudent   inner join   tYear_Student  \r\n                        ON  tStudent.id =tYear_Student.xStudent   INNER JOIN\r\n                                      tclass ON tYear_Student.xClass= tclass.id\r\n                    where tYear_Student.xYear=" + af.Text + "\r\n                    GROUP BY  tclass.id , tclass.Name)tmpClass left outer join \r\n                    (SELECT     tclass.id AS xClass, COUNT(tYear_Student.id) AS countStdHozeh\r\n                     FROM    tStudent   inner join   tYear_Student  \r\n                        ON  tStudent.id =tYear_Student.xStudent   INNER JOIN\r\n                           tclass ON tYear_Student.xClass= tclass.id\r\n                    WHERE    tYear_Student.xYear=" + af.Text + " and   (tYear_Student.xhozeh = " + r.SelectedValue.ToString() + ")\r\n                    GROUP BY tclass.id)tmpHoze on tmpClass.id=tmpHoze.xClass\r\n                    left outer join \r\n                    (SELECT     tclass.id AS xClass, COUNT(tYear_Student.id) AS countStdNoHozeh\r\n                        FROM    tStudent   inner join   tYear_Student  \r\n                        ON  tStudent.id =tYear_Student.xStudent   INNER JOIN\r\n                                      tclass ON tYear_Student.xClass= tclass.id\r\n                    WHERE    tYear_Student.xYear=" + af.Text + " and  (tYear_Student.xhozeh is null)\r\n                    GROUP BY tclass.id)tmpNoHoze on tmpClass.id=tmpNoHoze.xClass");
					s.DataSource = dataSource;
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					num = 1;
					continue;
				}
				case 1:
					return;
				case 2:
					MessageBox.Show("این حوزه داری شاگرد هست وامکان اختصاص مجدد وجود ندارد");
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
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
					num = ((p.RowCount <= 0) ? 1 : 0);
					continue;
				case 0:
					num = 5;
					continue;
				case 5:
					num2 = ((MessageBox.Show("آيا از حذف شاگردان از حوزه مطمئن هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1 : 0);
					goto IL_00c5;
				case 4:
					return;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					if (true)
					{
					}
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set idx=null,xhozeh=null where xYear=" + af.Text + " and xhozeh=" + r.SelectedValue.ToString());
					c();
					num = 4;
					continue;
				case 1:
					{
						num2 = 1;
						goto IL_00c5;
					}
					IL_00c5:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		asdr asdr2 = new asdr();
		asdr2.ShowDialog();
	}
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				if (true)
				{
				}
				int num2;
				switch (num)
				{
				case 5:
					num = ((!A_0) ? 1 : 4);
					continue;
				case 4:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_f == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_f.Dispose();
					num = 0;
					continue;
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		this.m_g = new Panel();
		o = new Panel();
		af = new Label();
		ag = new Label();
		k = new Panel();
		this.m_h = new Panel();
		ad = new CheckBox();
		z = new EditBox();
		y = new Label();
		x = new CheckBox();
		v = new Label();
		w = new ComboBox();
		t = new Label();
		u = new Label();
		s = new GridEX();
		this.m_i = new UIButton();
		j = new UIButton();
		q = new Label();
		r = new ComboBox();
		p = new GridEX();
		m = new Panel();
		ab = new UIButton();
		aa = new UIButton();
		l = new UIButton();
		n = new UIButton();
		ac = new Label();
		ae = new UIButton();
		this.m_g.SuspendLayout();
		o.SuspendLayout();
		k.SuspendLayout();
		this.m_h.SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((ISupportInitialize)p).BeginInit();
		m.SuspendLayout();
		SuspendLayout();
		this.m_g.BackColor = SystemColors.ControlText;
		this.m_g.Controls.Add(o);
		this.m_g.Dock = DockStyle.Fill;
		this.m_g.Location = new Point(0, 0);
		this.m_g.Name = "panel2";
		this.m_g.Size = new Size(697, 650);
		this.m_g.TabIndex = 31;
		o.BackColor = SystemColors.GradientInactiveCaption;
		o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		o.Controls.Add(af);
		o.Controls.Add(k);
		o.Controls.Add(q);
		o.Controls.Add(r);
		o.Controls.Add(p);
		o.Controls.Add(m);
		o.Controls.Add(n);
		o.Controls.Add(ac);
		o.Controls.Add(ae);
		o.Controls.Add(ag);
		o.Font = new Font("Tahoma", 8.25f);
		o.Location = new Point(5, 6);
		o.Name = "panel3";
		o.Size = new Size(687, 637);
		o.TabIndex = 0;
		af.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		af.Location = new Point(12, 53);
		af.Name = "lYear";
		af.Size = new Size(68, 24);
		af.TabIndex = 122;
		af.TextAlign = ContentAlignment.MiddleCenter;
		ag.AutoSize = true;
		ag.Location = new Point(86, 58);
		ag.Name = "label6";
		ag.Size = new Size(66, 13);
		ag.TabIndex = 121;
		ag.Text = "سال تعلیمی";
		k.BackColor = Color.Gray;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Controls.Add(this.m_h);
		k.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(142, 52);
		k.Name = "pPayeSelect";
		k.Size = new Size(535, 564);
		k.TabIndex = 0;
		k.Visible = false;
		this.m_h.BackColor = Color.FromArgb(214, 223, 247);
		this.m_h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_h.Controls.Add(ad);
		this.m_h.Controls.Add(z);
		this.m_h.Controls.Add(y);
		this.m_h.Controls.Add(x);
		this.m_h.Controls.Add(v);
		this.m_h.Controls.Add(w);
		this.m_h.Controls.Add(t);
		this.m_h.Controls.Add(u);
		this.m_h.Controls.Add(s);
		this.m_h.Controls.Add(this.m_i);
		this.m_h.Controls.Add(j);
		this.m_h.Location = new Point(4, 5);
		this.m_h.Name = "panel1";
		this.m_h.Size = new Size(524, 551);
		this.m_h.TabIndex = 40;
		ad.Checked = true;
		ad.CheckState = CheckState.Checked;
		ad.Location = new Point(3, 401);
		ad.Name = "checksortClass";
		ad.Size = new Size(339, 32);
		ad.TabIndex = 92;
		ad.Text = "شاگردان هر صنف در حوزه پشت سر هم بیفتند";
		ad.UseVisualStyleBackColor = true;
		z.AutoScroll = false;
		z.AutoScrollMargin = new Size(0, 0);
		z.AutoScrollMinSize = new Size(0, 0);
		z.AutoScrollPosition = new Point(0, 0);
		z.Location = new Point(223, 442);
		z.Name = "txtStart";
		z.Size = new Size(119, 36);
		z.TabIndex = 91;
		z.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		y.AutoSize = true;
		y.Location = new Point(354, 445);
		y.Name = "label3";
		y.Size = new Size(129, 28);
		y.TabIndex = 90;
		y.Text = "شروع شماره چوکی";
		x.Checked = true;
		x.CheckState = CheckState.Checked;
		x.Location = new Point(66, 363);
		x.Name = "checksortNopaye";
		x.Size = new Size(276, 32);
		x.TabIndex = 89;
		x.Text = "شماره چوکی یک پایه پشت سر هم نباشد";
		x.UseVisualStyleBackColor = true;
		v.AutoSize = true;
		v.Location = new Point(348, 324);
		v.Name = "label2";
		v.Size = new Size(128, 28);
		v.TabIndex = 88;
		v.Text = "نوع انتخاب شاگردان";
		w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		w.DropDownStyle = ComboBoxStyle.DropDownList;
		w.FormattingEnabled = true;
		w.Location = new Point(46, 321);
		w.Name = "dropTypeSelectStd";
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(296, 36);
		w.TabIndex = 87;
		t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		t.Location = new Point(178, 10);
		t.Name = "lHozePayeName";
		t.Size = new Size(324, 30);
		t.TabIndex = 86;
		t.TextAlign = ContentAlignment.MiddleCenter;
		u.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		u.Location = new Point(22, 10);
		u.Name = "lHozePayeCount";
		u.Size = new Size(150, 30);
		u.TabIndex = 85;
		u.Text = "ظرفیت حوزه : 50";
		u.TextAlign = ContentAlignment.MiddleCenter;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		s.DesignTimeLayout = gridEXLayout;
		s.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		s.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		s.Font = new Font("Tahoma", 9.75f);
		s.GroupByBoxVisible = false;
		s.HeaderFormatStyle.FontSize = 8f;
		s.Location = new Point(22, 51);
		s.Name = "gSelectByPaye";
		s.RecordNavigator = true;
		s.RowHeaders = InheritableBoolean.True;
		s.SelectedFormatStyle.BackColor = Color.Empty;
		s.SelectedFormatStyle.ForeColor = Color.Empty;
		s.Size = new Size(480, 261);
		s.TabIndex = 6;
		s.VisualStyle = VisualStyle.Office2003;
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		this.m_i.Location = new Point(130, 495);
		this.m_i.Name = "btnCancel";
		this.m_i.Size = new Size(115, 38);
		this.m_i.TabIndex = 5;
		this.m_i.Text = "انصراف";
		this.m_i.Click += g;
		j.Image = (Image)componentResourceManager.GetObject("btnAcpPaye.Image");
		j.Location = new Point(251, 495);
		j.Name = "btnAcpPaye";
		j.Size = new Size(119, 38);
		j.TabIndex = 4;
		j.Text = "تایید";
		j.Click += f;
		q.AutoSize = true;
		q.Location = new Point(627, 63);
		q.Name = "label1";
		q.Size = new Size(44, 13);
		q.TabIndex = 51;
		q.Text = "نام حوزه";
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.DropDownStyle = ComboBoxStyle.DropDownList;
		r.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r.FormattingEnabled = true;
		r.Location = new Point(284, 54);
		r.Name = "dropHoze";
		r.RightToLeft = RightToLeft.Yes;
		r.Size = new Size(337, 31);
		r.TabIndex = 84;
		r.SelectedValueChanged += d;
		p.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		p.DesignTimeLayout = gridEXLayout2;
		p.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		p.Font = new Font("Tahoma", 15.75f);
		p.GroupByBoxVisible = false;
		p.HeaderFormatStyle.Font = new Font("Tahoma", 8.25f);
		p.Location = new Point(10, 98);
		p.Name = "gridEX1";
		p.RecordNavigator = true;
		p.RightToLeft = RightToLeft.Yes;
		p.RowFormatStyle.Font = new Font("B Nazanin", 15.75f);
		p.RowHeaders = InheritableBoolean.True;
		p.Size = new Size(669, 448);
		p.TabIndex = 31;
		p.VisualStyle = VisualStyle.Office2003;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.Controls.Add(ab);
		m.Controls.Add(aa);
		m.Controls.Add(l);
		m.Location = new Point(126, 564);
		m.Name = "p_new";
		m.Size = new Size(556, 59);
		m.TabIndex = 29;
		ab.Image = (Image)componentResourceManager.GetObject("btnDeleteStdFromhozeh.Image");
		ab.Location = new Point(3, 19);
		ab.Name = "btnDeleteStdFromhozeh";
		ab.Size = new Size(152, 34);
		ab.TabIndex = 6;
		ab.Text = "حذف شاگردان از حوزه برای اختصاص مجدد";
		ab.Click += b;
		aa.Image = (Image)componentResourceManager.GetObject("btnSelectByClass.Image");
		aa.Location = new Point(161, 19);
		aa.Name = "btnSelectByClass";
		aa.Size = new Size(193, 34);
		aa.TabIndex = 3;
		aa.Text = "انتخاب شاگردان بر اساس صنف";
		aa.Click += c;
		l.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		l.Location = new Point(360, 20);
		l.Name = "btnNew";
		l.Size = new Size(193, 34);
		l.TabIndex = 0;
		l.Text = "انتخاب شاگردان بر اساس پایه";
		l.Click += h;
		n.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		n.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		n.ImageSize = new Size(40, 40);
		n.Location = new Point(6, 589);
		n.Name = "btnClose";
		n.Size = new Size(110, 34);
		n.TabIndex = 30;
		n.Text = "بستن";
		n.Click += e;
		ac.AutoSize = true;
		ac.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac.Location = new Point(224, 9);
		ac.Name = "label4";
		ac.Size = new Size(268, 23);
		ac.TabIndex = 85;
		ac.Text = "اختصاص شماره چوکی اتوماتیک";
		ae.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ae.Location = new Point(6, 553);
		ae.Name = "btnSort";
		ae.Size = new Size(110, 34);
		ae.TabIndex = 86;
		ae.Text = "اولویت صنف ها";
		ae.Click += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(697, 650);
		Controls.Add(this.m_g);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmlistHozeh";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "اختصاص شماره چوکی اتوماتیک";
		Load += i;
		this.m_g.ResumeLayout(performLayout: false);
		o.ResumeLayout(performLayout: false);
		o.PerformLayout();
		k.ResumeLayout(performLayout: false);
		this.m_h.ResumeLayout(performLayout: false);
		this.m_h.PerformLayout();
		((ISupportInitialize)s).EndInit();
		((ISupportInitialize)p).EndInit();
		m.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
