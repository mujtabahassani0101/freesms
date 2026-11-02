using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)this.m_h).BackColor = Color.FromArgb(red, green, blue);
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
					((Control)af).Text = asdaj.a;
					this.m_a = false;
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					dictionary.Add("1", "اوسط شاگرد از بالا به پایین");
					dictionary.Add("2", "اوسط شاگرد از پایین به بالا");
					dictionary.Add("3", "تصادفی");
					dictionary.Add("4", "شماره ترتیب شاگرد");
					w.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)w).DisplayMember = "Value";
					((ListControl)w).ValueMember = "Key";
					b();
					this.m_a = true;
					c();
					num = 1;
					continue;
				}
				case 1:
					return;
				case 5:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
							DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.idx,tmpMoadel.moadel\r\n                    FROM         tStudent  INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                                          tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                                          tClass ON tYear_Student.xClass = tClass.id  left outer join \r\n                    (SELECT     ROUND(AVG(MarkDoreh), 2) AS moadel, xStudent\r\n                    FROM         tMarkDoreh\r\n                    WHERE     (typ = 5) and xtest in(select id from texam where xyear=" + ((Control)af).Text + ")\r\n                    GROUP BY xStudent) tmpMoadel on tStudent.id=tmpMoadel.xStudent\r\n                    WHERE   tYear_Student.xYear=" + ((Control)af).Text + " and (tYear_Student.xhozeh = " + ((ListControl)r).SelectedValue.ToString() + ")");
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
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tYear_Student where xYear=" + ((Control)af).Text + " and xHozeh=" + ((ListControl)r).SelectedValue.ToString()).ToString();
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
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT name , Capacity   FROM  tHozeh where id=" + ((ListControl)r).SelectedValue.ToString());
					((Control)t).Text = dataTable.Rows[0]["name"].ToString();
					((Control)u).Text = "ظرفیت حوزه : " + dataTable.Rows[0]["Capacity"].ToString();
					this.m_b = int.Parse(dataTable.Rows[0]["Capacity"].ToString());
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT isnull(max(idx),0)+1   FROM  tYear_Student where xYear=" + ((Control)af).Text).ToString();
					((Control)z).Text = text2;
					((Control)k).Visible = true;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tmpPaye.*,isnull(tmpHoze.countStdHozeh,0) as countStdHozeh,isnull(tmpNoHoze.countStdNoHozeh,0) as countStdNoHozeh,null as m1\r\n                    from\r\n                    (SELECT   tPaye.id ,  tPaye.Name, COUNT(tYear_Student.id) AS countPaye\r\n                    FROM   tStudent inner join   tYear_Student  \r\n                    ON  tStudent.id =tYear_Student.xStudent INNER JOIN   tPaye \r\n                     ON tYear_Student.xPaye=tPaye.id \r\n                    where tYear_Student.xYear=" + ((Control)af).Text + "\r\n                    GROUP BY  tPaye.id , tPaye.Name)tmpPaye left outer join \r\n                    (SELECT     tPaye.id AS xpaye, COUNT(tYear_Student.id) AS countStdHozeh\r\n                     FROM   tStudent inner join   tYear_Student  \r\n                     ON  tStudent.id =tYear_Student.xStudent INNER JOIN   tPaye \r\n                     ON tYear_Student.xPaye=tPaye.id \r\n                    WHERE    tYear_Student.xYear=" + ((Control)af).Text + " and (tYear_Student.xhozeh = " + ((ListControl)r).SelectedValue.ToString() + ")\r\n                    GROUP BY tPaye.id)tmpHoze on tmpPaye.id=tmpHoze.xpaye\r\n                    left outer join \r\n                    (SELECT     tPaye.id AS xpaye, COUNT(tYear_Student.id) AS countStdNoHozeh\r\n                     FROM   tStudent inner join   tYear_Student  \r\n                     ON  tStudent.id =tYear_Student.xStudent INNER JOIN   tPaye \r\n                     ON tYear_Student.xPaye=tPaye.id \r\n                    WHERE   tYear_Student.xYear=" + ((Control)af).Text + " and (tYear_Student.xhozeh is null)\r\n                    GROUP BY tPaye.id)tmpNoHoze on tmpPaye.id=tmpNoHoze.xpaye");
					s.DataSource = dataSource;
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					((Control)s).Select();
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
		((Control)k).Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
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
			string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tYear_Student where xyear=" + ((Control)af).Text + " and xHozeh=" + ((ListControl)r).SelectedValue.ToString()).ToString();
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
					flag = !(((ListControl)w).SelectedValue.ToString() == "1");
					num = 45;
					continue;
				case 45:
					if (!flag)
					{
						num = 57;
						continue;
					}
					flag = !(((ListControl)w).SelectedValue.ToString() == "2");
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
					((Control)k).Visible = false;
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
					((Control)k).Visible = false;
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
						num5 = int.Parse(((Control)z).Text);
					}
					catch
					{
						MessageBox.Show("برای شماره شروع فقط عدد وارد کنید");
						((Control)z).Focus();
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
					((Control)s).Select();
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
					text2 = "SELECT  top " + text5 + " tStudent.id\r\n                    FROM         tStudent inner join   tYear_Student  \r\n                    ON  tStudent.id =tYear_Student.xStudent   left outer join \r\n                    (SELECT     ROUND(AVG(MarkDoreh), 2) AS moadel, xStudent\r\n                    FROM         tMarkDoreh\r\n                    WHERE     (typ = 5)  and xtest in(select id from texam where xyear=" + ((Control)af).Text + ")\r\n                    GROUP BY xStudent) tmpMoadel on tStudent.id=tmpMoadel.xStudent  inner join tclass\r\n                    on tYear_Student.xClass=tclass.id            \r\n                    where  tYear_Student.xYear=" + ((Control)af).Text + " and tYear_Student.xhozeh is null and " + text3 + " =" + text6;
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
						a(x.Checked, ((ListControl)r).SelectedValue.ToString(), num5.ToString(), ((ListControl)w).SelectedValue.ToString());
						string text4 = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(*) AS countStd FROM  tYear_Student WHERE xyear=" + ((Control)af).Text + " and idx is null and xhozeh=" + ((ListControl)r).SelectedValue.ToString()).ToString();
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
						((Control)s).Select();
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
					asdcb.c(asdab.e(), CommandType.Text, "update tYear_Student set xhozeh= " + ((ListControl)r).SelectedValue.ToString() + " where xyear=" + ((Control)af).Text + " and xStudent in(" + text2 + ")");
					num = 50;
					continue;
				case 40:
					if (!flag)
					{
						num = 11;
						continue;
					}
					flag = !(((ListControl)w).SelectedValue.ToString() == "3");
					num = 18;
					continue;
				case 18:
					if (flag)
					{
						flag = !(((ListControl)w).SelectedValue.ToString() == "4");
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
						asdcb.a("@xYear", SqlDbType.Int, ((Control)af).Text),
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
		((Form)this).Close();
	}

	private void b()
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
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
						r.DataSource = (object)new BindingSource((object)dictionary, (string)null);
						((ListControl)r).DisplayMember = "Value";
						((ListControl)r).ValueMember = "Key";
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
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (true)
			{
			}
			string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tYear_Student where xYear=" + ((Control)af).Text + " and xHozeh=" + ((ListControl)r).SelectedValue.ToString()).ToString();
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
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT name , Capacity   FROM  tHozeh where id=" + ((ListControl)r).SelectedValue.ToString());
					((Control)t).Text = dataTable.Rows[0]["name"].ToString();
					((Control)u).Text = "ظرفیت حوزه : " + dataTable.Rows[0]["Capacity"].ToString();
					this.m_b = int.Parse(dataTable.Rows[0]["Capacity"].ToString());
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT isnull(max(idx),0)+1  FROM  tYear_Student where xYear=" + ((Control)af).Text).ToString();
					((Control)z).Text = text2;
					((Control)k).Visible = true;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tmpClass.*,isnull(tmpHoze.countStdHozeh,0) as countStdHozeh,isnull(tmpNoHoze.countStdNoHozeh,0) as countStdNoHozeh,null as m1\r\n                    from\r\n                    (SELECT   tclass.id ,  tclass.Name, COUNT(tYear_Student.id) AS countPaye\r\n                       FROM    tStudent   inner join   tYear_Student  \r\n                        ON  tStudent.id =tYear_Student.xStudent   INNER JOIN\r\n                                      tclass ON tYear_Student.xClass= tclass.id\r\n                    where tYear_Student.xYear=" + ((Control)af).Text + "\r\n                    GROUP BY  tclass.id , tclass.Name)tmpClass left outer join \r\n                    (SELECT     tclass.id AS xClass, COUNT(tYear_Student.id) AS countStdHozeh\r\n                     FROM    tStudent   inner join   tYear_Student  \r\n                        ON  tStudent.id =tYear_Student.xStudent   INNER JOIN\r\n                           tclass ON tYear_Student.xClass= tclass.id\r\n                    WHERE    tYear_Student.xYear=" + ((Control)af).Text + " and   (tYear_Student.xhozeh = " + ((ListControl)r).SelectedValue.ToString() + ")\r\n                    GROUP BY tclass.id)tmpHoze on tmpClass.id=tmpHoze.xClass\r\n                    left outer join \r\n                    (SELECT     tclass.id AS xClass, COUNT(tYear_Student.id) AS countStdNoHozeh\r\n                        FROM    tStudent   inner join   tYear_Student  \r\n                        ON  tStudent.id =tYear_Student.xStudent   INNER JOIN\r\n                                      tclass ON tYear_Student.xClass= tclass.id\r\n                    WHERE    tYear_Student.xYear=" + ((Control)af).Text + " and  (tYear_Student.xhozeh is null)\r\n                    GROUP BY tclass.id)tmpNoHoze on tmpClass.id=tmpNoHoze.xClass");
					s.DataSource = dataSource;
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					((Control)s).Select();
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
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
					num2 = (((int)MessageBox.Show("آيا از حذف شاگردان از حوزه مطمئن هستيد؟", "", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6) ? 1 : 0);
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
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set idx=null,xhozeh=null where xYear=" + ((Control)af).Text + " and xhozeh=" + ((ListControl)r).SelectedValue.ToString());
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
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdr asdr2 = new asdr();
		((Form)asdr2).ShowDialog();
	}

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected Obj, but got Unknown
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected Obj, but got Unknown
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected Obj, but got Unknown
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected Obj, but got Unknown
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e68: Expected Obj, but got Unknown
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Expected Obj, but got Unknown
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got Unknown
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Expected Obj, but got Unknown
		//IL_107b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1085: Expected Obj, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected Obj, but got Unknown
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Expected Obj, but got Unknown
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_126c: Expected Obj, but got Unknown
		//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb));
		GridEXLayout val2 = new GridEXLayout();
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
		((Control)this.m_g).SuspendLayout();
		((Control)o).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this.m_h).SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((ISupportInitialize)p).BeginInit();
		((Control)m).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_g).BackColor = SystemColors.ControlText;
		((Control)this.m_g).Controls.Add((Control)(object)o);
		((Control)this.m_g).Dock = (DockStyle)5;
		((Control)this.m_g).Location = new Point(0, 0);
		((Control)this.m_g).Name = "panel2";
		((Control)this.m_g).Size = new Size(697, 650);
		((Control)this.m_g).TabIndex = 31;
		((Control)o).BackColor = SystemColors.GradientInactiveCaption;
		o.BorderStyle = (BorderStyle)1;
		((Control)o).Controls.Add((Control)(object)af);
		((Control)o).Controls.Add((Control)(object)k);
		((Control)o).Controls.Add((Control)(object)q);
		((Control)o).Controls.Add((Control)(object)r);
		((Control)o).Controls.Add((Control)(object)p);
		((Control)o).Controls.Add((Control)(object)m);
		((Control)o).Controls.Add((Control)(object)n);
		((Control)o).Controls.Add((Control)(object)ac);
		((Control)o).Controls.Add((Control)(object)ae);
		((Control)o).Controls.Add((Control)(object)ag);
		((Control)o).Font = new Font("Tahoma", 8.25f);
		((Control)o).Location = new Point(5, 6);
		((Control)o).Name = "panel3";
		((Control)o).Size = new Size(687, 637);
		((Control)o).TabIndex = 0;
		af.BorderStyle = (BorderStyle)1;
		((Control)af).Location = new Point(12, 53);
		((Control)af).Name = "lYear";
		((Control)af).Size = new Size(68, 24);
		((Control)af).TabIndex = 122;
		af.TextAlign = (ContentAlignment)32;
		((Control)ag).AutoSize = true;
		((Control)ag).Location = new Point(86, 58);
		((Control)ag).Name = "label6";
		((Control)ag).Size = new Size(66, 13);
		((Control)ag).TabIndex = 121;
		((Control)ag).Text = "سال تعلیمی";
		((Control)k).BackColor = Color.Gray;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Controls.Add((Control)(object)this.m_h);
		((Control)k).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(142, 52);
		((Control)k).Name = "pPayeSelect";
		((Control)k).Size = new Size(535, 564);
		((Control)k).TabIndex = 0;
		((Control)k).Visible = false;
		((Control)this.m_h).BackColor = Color.FromArgb(214, 223, 247);
		this.m_h.BorderStyle = (BorderStyle)2;
		((Control)this.m_h).Controls.Add((Control)(object)ad);
		((Control)this.m_h).Controls.Add((Control)(object)z);
		((Control)this.m_h).Controls.Add((Control)(object)y);
		((Control)this.m_h).Controls.Add((Control)(object)x);
		((Control)this.m_h).Controls.Add((Control)(object)v);
		((Control)this.m_h).Controls.Add((Control)(object)w);
		((Control)this.m_h).Controls.Add((Control)(object)t);
		((Control)this.m_h).Controls.Add((Control)(object)u);
		((Control)this.m_h).Controls.Add((Control)(object)s);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_h).Controls.Add((Control)(object)j);
		((Control)this.m_h).Location = new Point(4, 5);
		((Control)this.m_h).Name = "panel1";
		((Control)this.m_h).Size = new Size(524, 551);
		((Control)this.m_h).TabIndex = 40;
		ad.Checked = true;
		ad.CheckState = (CheckState)1;
		((Control)ad).Location = new Point(3, 401);
		((Control)ad).Name = "checksortClass";
		((Control)ad).Size = new Size(339, 32);
		((Control)ad).TabIndex = 92;
		((Control)ad).Text = "شاگردان هر صنف در حوزه پشت سر هم بیفتند";
		((ButtonBase)ad).UseVisualStyleBackColor = true;
		((EditBase)z).AutoScroll = false;
		((EditBase)z).AutoScrollMargin = new Size(0, 0);
		((EditBase)z).AutoScrollMinSize = new Size(0, 0);
		((EditBase)z).AutoScrollPosition = new Point(0, 0);
		((Control)z).Location = new Point(223, 442);
		((Control)z).Name = "txtStart";
		((Control)z).Size = new Size(119, 36);
		((Control)z).TabIndex = 91;
		((EditBase)z).TextAlignment = (TextAlignment)1;
		((Control)y).AutoSize = true;
		((Control)y).Location = new Point(354, 445);
		((Control)y).Name = "label3";
		((Control)y).Size = new Size(129, 28);
		((Control)y).TabIndex = 90;
		((Control)y).Text = "شروع شماره چوکی";
		x.Checked = true;
		x.CheckState = (CheckState)1;
		((Control)x).Location = new Point(66, 363);
		((Control)x).Name = "checksortNopaye";
		((Control)x).Size = new Size(276, 32);
		((Control)x).TabIndex = 89;
		((Control)x).Text = "شماره چوکی یک پایه پشت سر هم نباشد";
		((ButtonBase)x).UseVisualStyleBackColor = true;
		((Control)v).AutoSize = true;
		((Control)v).Location = new Point(348, 324);
		((Control)v).Name = "label2";
		((Control)v).Size = new Size(128, 28);
		((Control)v).TabIndex = 88;
		((Control)v).Text = "نوع انتخاب شاگردان";
		((Control)w).Anchor = (AnchorStyles)9;
		w.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)w).FormattingEnabled = true;
		((Control)w).Location = new Point(46, 321);
		((Control)w).Name = "dropTypeSelectStd";
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(296, 36);
		((Control)w).TabIndex = 87;
		t.BorderStyle = (BorderStyle)2;
		((Control)t).Location = new Point(178, 10);
		((Control)t).Name = "lHozePayeName";
		((Control)t).Size = new Size(324, 30);
		((Control)t).TabIndex = 86;
		t.TextAlign = (ContentAlignment)32;
		u.BorderStyle = (BorderStyle)2;
		((Control)u).Location = new Point(22, 10);
		((Control)u).Name = "lHozePayeCount";
		((Control)u).Size = new Size(150, 30);
		((Control)u).TabIndex = 85;
		((Control)u).Text = "ظرفیت حوزه : 50";
		u.TextAlign = (ContentAlignment)32;
		((Control)s).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		s.DesignTimeLayout = val;
		s.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		s.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)s).Font = new Font("Tahoma", 9.75f);
		s.GroupByBoxVisible = false;
		s.HeaderFormatStyle.FontSize = 8f;
		((Control)s).Location = new Point(22, 51);
		((Control)s).Name = "gSelectByPaye";
		((ScrollableBase)s).RecordNavigator = true;
		s.RowHeaders = (InheritableBoolean)1;
		s.SelectedFormatStyle.BackColor = Color.Empty;
		s.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)s).Size = new Size(480, 261);
		((Control)s).TabIndex = 6;
		((ScrollableBase)s).VisualStyle = (VisualStyle)2;
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)this.m_i).Location = new Point(130, 495);
		((Control)this.m_i).Name = "btnCancel";
		((Control)this.m_i).Size = new Size(115, 38);
		((Control)this.m_i).TabIndex = 5;
		((Control)this.m_i).Text = "انصراف";
		((Control)this.m_i).Click += g;
		j.Image = (Image)componentResourceManager.GetObject("btnAcpPaye.Image");
		((Control)j).Location = new Point(251, 495);
		((Control)j).Name = "btnAcpPaye";
		((Control)j).Size = new Size(119, 38);
		((Control)j).TabIndex = 4;
		((Control)j).Text = "تایید";
		((Control)j).Click += f;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(627, 63);
		((Control)q).Name = "label1";
		((Control)q).Size = new Size(44, 13);
		((Control)q).TabIndex = 51;
		((Control)q).Text = "نام حوزه";
		((Control)r).Anchor = (AnchorStyles)9;
		r.DropDownStyle = (ComboBoxStyle)2;
		((Control)r).Font = new Font("Tahoma", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ListControl)r).FormattingEnabled = true;
		((Control)r).Location = new Point(284, 54);
		((Control)r).Name = "dropHoze";
		((Control)r).RightToLeft = (RightToLeft)1;
		((Control)r).Size = new Size(337, 31);
		((Control)r).TabIndex = 84;
		((ListControl)r).SelectedValueChanged += d;
		((Control)p).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		p.DesignTimeLayout = val2;
		p.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)p).Font = new Font("Tahoma", 15.75f);
		p.GroupByBoxVisible = false;
		p.HeaderFormatStyle.Font = new Font("Tahoma", 8.25f);
		((Control)p).Location = new Point(10, 98);
		((Control)p).Name = "gridEX1";
		((ScrollableBase)p).RecordNavigator = true;
		((Control)p).RightToLeft = (RightToLeft)1;
		p.RowFormatStyle.Font = new Font("B Nazanin", 15.75f);
		p.RowHeaders = (InheritableBoolean)1;
		((Control)p).Size = new Size(669, 448);
		((Control)p).TabIndex = 31;
		((ScrollableBase)p).VisualStyle = (VisualStyle)2;
		((Control)m).Anchor = (AnchorStyles)10;
		((Control)m).Controls.Add((Control)(object)ab);
		((Control)m).Controls.Add((Control)(object)aa);
		((Control)m).Controls.Add((Control)(object)l);
		((Control)m).Location = new Point(126, 564);
		((Control)m).Name = "p_new";
		((Control)m).Size = new Size(556, 59);
		((Control)m).TabIndex = 29;
		ab.Image = (Image)componentResourceManager.GetObject("btnDeleteStdFromhozeh.Image");
		((Control)ab).Location = new Point(3, 19);
		((Control)ab).Name = "btnDeleteStdFromhozeh";
		((Control)ab).Size = new Size(152, 34);
		((Control)ab).TabIndex = 6;
		((Control)ab).Text = "حذف شاگردان از حوزه برای اختصاص مجدد";
		((Control)ab).Click += b;
		aa.Image = (Image)componentResourceManager.GetObject("btnSelectByClass.Image");
		((Control)aa).Location = new Point(161, 19);
		((Control)aa).Name = "btnSelectByClass";
		((Control)aa).Size = new Size(193, 34);
		((Control)aa).TabIndex = 3;
		((Control)aa).Text = "انتخاب شاگردان بر اساس صنف";
		((Control)aa).Click += c;
		l.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)l).Location = new Point(360, 20);
		((Control)l).Name = "btnNew";
		((Control)l).Size = new Size(193, 34);
		((Control)l).TabIndex = 0;
		((Control)l).Text = "انتخاب شاگردان بر اساس پایه";
		((Control)l).Click += h;
		((Control)n).Anchor = (AnchorStyles)6;
		n.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		n.ImageSize = new Size(40, 40);
		((Control)n).Location = new Point(6, 589);
		((Control)n).Name = "btnClose";
		((Control)n).Size = new Size(110, 34);
		((Control)n).TabIndex = 30;
		((Control)n).Text = "بستن";
		((Control)n).Click += e;
		((Control)ac).AutoSize = true;
		((Control)ac).Font = new Font("Tahoma", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ac).Location = new Point(224, 9);
		((Control)ac).Name = "label4";
		((Control)ac).Size = new Size(268, 23);
		((Control)ac).TabIndex = 85;
		((Control)ac).Text = "اختصاص شماره چوکی اتوماتیک";
		((Control)ae).Anchor = (AnchorStyles)6;
		((Control)ae).Location = new Point(6, 553);
		((Control)ae).Name = "btnSort";
		((Control)ae).Size = new Size(110, 34);
		((Control)ae).TabIndex = 86;
		((Control)ae).Text = "اولویت صنف ها";
		((Control)ae).Click += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(697, 650);
		((Control)this).Controls.Add((Control)(object)this.m_g);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmlistHozeh";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "اختصاص شماره چوکی اتوماتیک";
		((Form)this).Load += i;
		((Control)this.m_g).ResumeLayout(false);
		((Control)o).ResumeLayout(false);
		((Control)o).PerformLayout();
		((Control)k).ResumeLayout(false);
		((Control)this.m_h).ResumeLayout(false);
		((Control)this.m_h).PerformLayout();
		((ISupportInitialize)s).EndInit();
		((ISupportInitialize)p).EndInit();
		((Control)m).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
