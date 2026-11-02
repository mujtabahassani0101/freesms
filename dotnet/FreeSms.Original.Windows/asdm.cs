using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using school_Af.Properties;

public class asdm : Form
{
	private bool m_a = false;

	private int m_b = 0;

	private int m_c = 0;

	private IContainer m_d = null;

	private Panel m_e;

	private Panel m_f;

	private UIButton m_g;

	private UIButton m_h;

	private UIButton m_i;

	private UIGroupBox m_j;

	private Label m_k;

	private UIComboBox m_l;

	private Label m_m;

	private UIComboBox m_n;

	private Label m_o;

	private Label m_p;

	private EditBox m_q;

	private EditBox m_r;

	private UIButton s;

	private MaskedEditBox t;

	private Label u;

	private UIButton v;

	private OpenFileDialog w;

	private CheckBox x;

	private Panel y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	private UIButton ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private UIButton ai;

	private MaskedEditBox aj;

	private Label ak;

	private UIComboBox al;

	private Label am;

	private Label an;

	private Label ao;

	private UIComboBox ap;

	private Panel aq;

	private MaskedEditBox ar;

	private Label @as;

	private Label at;

	private UIButton au;

	private GridEX av;

	private UIButton aw;

	private Panel ax;

	private Label ay;

	private Timer az;

	public asdm()
	{
		a();
	}

	private void r(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 4:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_e.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 5;
				case 5:
					at.Text = asdaj.__field_a;
					ap.SelectedIndex = 0;
					al.SelectedIndex = 0;
					d();
					e();
					this.m_a = true;
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 0;
					continue;
				case 0:
					return;
				case 3:
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void e()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
			this.m_l.Items.Add("کل", "0");
			int num = 0;
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
					this.m_l.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 1;
					continue;
				case 3:
					this.m_l.SelectedIndex = 0;
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
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_l.SelectedIndex <= 0;
			int num = 0;
			while (true)
			{
				DataTable dataSource;
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto IL_008a;
				case 1:
					text = " and xPaye=" + this.m_l.SelectedValue.ToString();
					num = 2;
					continue;
				case 2:
					{
						if (1 == 0)
						{
						}
						goto IL_008a;
					}
					IL_008a:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + at.Text + text);
					this.m_n.DataSource = dataSource;
					this.m_n.DisplayMember = "Name";
					this.m_n.ValueMember = "id";
					this.m_n.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		string text = default;
		string text2 = default;
		string text3 = default;
		while (true)
		{
			bool flag = this.m_a;
			int num = 20;
			while (true)
			{
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 5;
						continue;
					}
					text = " tYear_Student.xYear=" + at.Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = this.m_n.SelectedIndex <= 0;
					if (true)
					{
					}
					num = 36;
					continue;
				case 47:
					flag = !(aj.Text.Trim() != "");
					num = 55;
					continue;
				case 55:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 26;
				case 24:
					text += " and ";
					num = 29;
					continue;
				case 3:
					text = text + " tYear_Student.xPaye=" + this.m_l.SelectedValue.ToString();
					num = 32;
					continue;
				case 25:
					flag = !(text != "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 27;
				case 38:
					flag = this.m_l.SelectedIndex <= 0;
					num = 42;
					continue;
				case 42:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 32;
				case 17:
					text = text + " tstudent.code=" + t.Text.Trim();
					num = 47;
					continue;
				case 22:
					text = " where " + text;
					num = 37;
					continue;
				case 45:
					flag = !(text != "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 29;
				case 49:
					flag = !(text != "");
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 58;
						continue;
					}
					goto case 46;
				case 27:
					text = text + " tYear_Student.codeTakhfif=" + ar.Text.Trim();
					num = 40;
					continue;
				case 57:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName, tStudent.LName, \r\n  tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName,                      \r\ntStudent.PName, tStudent.Sh_Sh,tStudent.bDate,tStudent.bDateM, tStudent.MobileMother, tStudent.MobileFather, tClass.name AS Class, tPaye.Name AS Paye,\r\n                       tStudent.NumberTelegram, tStudent.NumberTelegram2, tStudent.NumberAsas, tStudent.RegDate, \r\n                      tYear_Student.Status, tYear_Student.sort, tYear_Student.shaghe, tYear_Student.hazer, tYear_Student.mali, \r\n                      tYear_Student.dakhle, tYear_Student.uniform, tYear_Student.komakdarsi, tYear_Student.ketab, tYear_Student.transport, \r\n                      tYear_Student.robotic, tYear_Student.maghnae, tYear_Student.Sumtransport,case tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک'  when 4 then N'معذرتی' end as vazeyat,\r\n                    tYear_Student.codeTakhfif" + text2 + " FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id  " + text3 + text);
					av.DataSource = dataSource;
					ax.Visible = false;
					num = 4;
					continue;
				}
				case 4:
					return;
				case 50:
					flag = !(this.m_r.Text.Trim() != "");
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 7;
				case 5:
					num = 16;
					continue;
				case 16:
					return;
				case 59:
					text += " and ";
					num = 3;
					continue;
				case 23:
					flag = !(text != "");
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 59;
						continue;
					}
					goto case 3;
				case 58:
					text += " and ";
					num = 46;
					continue;
				case 40:
					flag = !(text != "");
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 37;
				case 31:
					text = text + " tstudent.NumberAsas=" + aj.Text.Trim();
					num = 26;
					continue;
				case 1:
					text = text + " tstudent.jens=" + al.SelectedValue.ToString();
					num = 50;
					continue;
				case 6:
					flag = !(text != "");
					num = 54;
					continue;
				case 54:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 18;
				case 21:
					flag = !(text != "");
					num = 61;
					continue;
				case 61:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 17;
				case 56:
					flag = al.SelectedIndex <= 0;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 50;
				case 32:
					flag = ap.SelectedIndex <= 0;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 56;
				case 26:
					flag = !(ar.Text.Trim() != "");
					num = 63;
					continue;
				case 63:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 40;
				case 34:
					flag = !(text != "");
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 60;
						continue;
					}
					goto case 1;
				case 46:
					text = text + " tYear_Student.Status=" + ap.SelectedValue.ToString();
					num = 56;
					continue;
				case 43:
					text = text + " tYear_Student.xClass=" + this.m_n.SelectedValue.ToString();
					num = 38;
					continue;
				case 29:
					text = text + " tstudent.LName like '%" + asdaj.b(this.m_q.Text) + "%'";
					num = 9;
					continue;
				case 36:
					if (!flag)
					{
						num = 62;
						continue;
					}
					goto case 38;
				case 7:
					flag = !(this.m_q.Text.Trim() != "");
					num = 51;
					continue;
				case 51:
					if (!flag)
					{
						num = 45;
						continue;
					}
					goto case 9;
				case 10:
					text += " and ";
					num = 18;
					continue;
				case 2:
					text += " and ";
					num = 27;
					continue;
				case 18:
					text = text + " tstudent.FName like '%" + asdaj.b(this.m_r.Text) + "%'";
					num = 7;
					continue;
				case 37:
					text2 = "";
					text3 = "";
					flag = !x.Checked;
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 52;
						continue;
					}
					goto case 57;
				case 11:
					text += " and ";
					num = 43;
					continue;
				case 62:
					flag = !(text != "");
					num = 35;
					continue;
				case 35:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 43;
				case 52:
					text2 = ",tStudentImg.Student_img";
					text3 = "LEFT OUTER JOIN\r\n                      tStudentImg ON tStudent.id = tStudentImg.xStudent";
					num = 57;
					continue;
				case 9:
					flag = !(t.Text.Trim() != "");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 47;
				case 60:
					text += " and ";
					num = 1;
					continue;
				case 44:
					text += " and ";
					num = 31;
					continue;
				case 13:
					text += " and ";
					num = 17;
					continue;
				case 48:
					flag = !(text != "");
					num = 53;
					continue;
				case 53:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 31;
				}
				break;
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			asdaj.h = false;
			asdat asdat2 = new asdat();
			asdat2.ShowDialog();
			n(this, null);
			bool flag = !asdaj.h;
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
					b();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void o(object A_0, EventArgs A_1)
	{
		d();
		b();
	}

	private void n(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a = false;
		this.m_l.SelectedIndex = 0;
		this.m_n.SelectedIndex = 0;
		ap.SelectedIndex = 0;
		al.SelectedIndex = 0;
		this.m_q.Text = "";
		this.m_r.Text = "";
		t.Text = "";
		aj.Text = "";
		ar.Text = "";
		this.m_a = true;
		b();
	}

	private void m(object A_0, EventArgs A_1)
	{
		b();
	}

	private void b()
	{
		if (true)
		{
		}
		av.DataSource = null;
		ax.Visible = true;
		Refresh();
		c();
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default;
			while (true)
			{
				int num = 5;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 5:
						if (av.RowCount > 0)
						{
							num = 4;
							continue;
						}
						goto IL_01fd;
					case 2:
						num = 3;
						continue;
					case 3:
						num2 = ((MessageBox.Show("آيا از حذف شاگرد مطمئن هستيد؟", "حذف شاگرد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1 : 0);
						goto IL_01cd;
					case 4:
						num = 0;
						continue;
					case 0:
						if (av.SelectedItems[0].RowType == RowType.Record)
						{
							num = 2;
							continue;
						}
						goto IL_01fd;
					case 7:
						if (!flag)
						{
							num = 9;
							continue;
						}
						goto case 1;
					case 9:
						if (true)
						{
						}
						y.Visible = true;
						z.Text = av.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + av.SelectedItems[0].GetRow().Cells["lname"].Value.ToString();
						ag.Text = av.SelectedItems[0].GetRow().Cells["paye"].Value.ToString();
						af.Text = av.SelectedItems[0].GetRow().Cells["class"].Value.ToString();
						num = 1;
						continue;
					case 8:
						num2 = 1;
						goto IL_01cd;
					case 1:
						num = 6;
						continue;
					case 6:
						return;
						IL_01fd:
						num = 8;
						continue;
						IL_01cd:
						flag = (byte)num2 != 0;
						num = 7;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		av.RootTable.Columns["Student_img"].Visible = x.Checked;
		b();
	}

	private void j(object A_0, EventArgs A_1)
	{
		y.Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = MessageBox.Show("با حذف شاگرد کلیه اطلاعات مربوط به او حذف خواهد شد\n\nآیا از حذف شاگرد اطمینان دارید؟", "حذف شاگرد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
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
					return;
				case 0:
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tExam SET procc = 0 WHERE (id IN(SELECT Xtest  FROM tMarkDoreh WHERE     (xStudent =" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")))");
					asdcb.d(asdab.e(), CommandType.Text, "delete from tPaymentStudent where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tMark where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tMarkDoreh where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tMarkAgo where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tComnentKarname where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tEnzebat where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryStudent where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tStudentImg where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tComnentStd where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tYear_Student where xStudent=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete from tstudent where id=" + av.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					y.Visible = false;
					b();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		b();
	}

	private void f(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((av.RowCount <= 0) ? 7 : 3);
					continue;
				case 3:
					if (true)
					{
					}
					num = 8;
					continue;
				case 8:
					num2 = ((av.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_009c;
				case 7:
					num2 = 1;
					goto IL_009c;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
				{
					asdaj.h = false;
					string text = av.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdat asdat2 = new asdat();
					asdat2.__field_a = text;
					asdat2.ShowDialog();
					flag = !asdaj.h;
					num = 2;
					continue;
				}
				case 2:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 9;
				case 9:
					num = 1;
					continue;
				case 1:
					return;
				case 6:
					{
						b();
						num = 9;
						continue;
					}
					IL_009c:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		int num2 = default;
		asdat asdat2 = default;
		while (true)
		{
			bool flag = av.RowCount <= 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 5:
					b();
					num = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_00d4;
				case 0:
				case 3:
					flag = num2 < av.RowCount;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 2;
						continue;
					}
					asdat2.ce.Items.Add(av.GetRow(num2).Cells["id"].Value.ToString(), av.GetRow(num2).Cells["id"].Value.ToString());
					num2++;
					num = 0;
					continue;
				case 7:
					asdaj.h = false;
					asdat2 = new asdat();
					num2 = 0;
					num = 3;
					continue;
				case 4:
					return;
				case 2:
					asdat2.ShowDialog();
					flag = !asdaj.h;
					num = 1;
					continue;
				case 1:
					{
						if (!flag)
						{
							num = 5;
							continue;
						}
						goto IL_00d4;
					}
					IL_00d4:
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					num = ((av.RowCount <= 0) ? 1 : 4);
					continue;
				case 4:
					num = 6;
					continue;
				case 6:
					if (true)
					{
					}
					num2 = ((av.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_00d8;
				case 3:
				{
					string text = av.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asda4 asda10 = new asda4();
					asda10.__field_a = text;
					asda10.ShowDialog();
					num = 5;
					continue;
				}
				case 5:
					return;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 1:
					{
						num2 = 1;
						goto IL_00d8;
					}
					IL_00d8:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Refresh();
		c();
	}

	private void b(object A_0, EventArgs A_1)
	{
		az.Stop();
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		az.Stop();
		az.Start();
	}
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 3;
			while (true)
			{
				if (true)
				{
				}
				int num2;
				switch (num)
				{
				case 3:
					num = (A_0 ? 1 : 2);
					continue;
				case 1:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_d == null) ? 1 : 0);
					goto IL_007c;
				case 6:
					this.m_d.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 0;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						base.Dispose(A_0);
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
		if (true)
		{
		}
		this.m_d = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdm));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		StringFormat stringFormat4 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_e = new Panel();
		ax = new Panel();
		ay = new Label();
		y = new Panel();
		ai = new UIButton();
		ah = new Label();
		af = new Label();
		ag = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		ad = new UIButton();
		ae = new Label();
		this.m_j = new UIGroupBox();
		at = new Label();
		ar = new MaskedEditBox();
		@as = new Label();
		ao = new Label();
		ap = new UIComboBox();
		an = new Label();
		al = new UIComboBox();
		am = new Label();
		aj = new MaskedEditBox();
		ak = new Label();
		x = new CheckBox();
		t = new MaskedEditBox();
		u = new Label();
		s = new UIButton();
		this.m_o = new Label();
		this.m_p = new Label();
		this.m_q = new EditBox();
		this.m_r = new EditBox();
		this.m_m = new Label();
		this.m_n = new UIComboBox();
		this.m_k = new Label();
		this.m_l = new UIComboBox();
		this.m_f = new Panel();
		aw = new UIButton();
		au = new UIButton();
		this.m_g = new UIButton();
		this.m_i = new UIButton();
		this.m_h = new UIButton();
		v = new UIButton();
		av = new GridEX();
		w = new OpenFileDialog();
		aq = new Panel();
		az = new Timer(this.m_d);
		this.m_e.SuspendLayout();
		ax.SuspendLayout();
		y.SuspendLayout();
		((ISupportInitialize)this.m_j).BeginInit();
		this.m_j.SuspendLayout();
		this.m_f.SuspendLayout();
		((ISupportInitialize)av).BeginInit();
		aq.SuspendLayout();
		SuspendLayout();
		this.m_e.BackColor = SystemColors.GradientInactiveCaption;
		this.m_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_e.Controls.Add(ax);
		this.m_e.Controls.Add(y);
		this.m_e.Controls.Add(this.m_j);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Controls.Add(av);
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.Location = new Point(3, 3);
		this.m_e.Name = "panel1";
		this.m_e.Size = new Size(794, 669);
		this.m_e.TabIndex = 0;
		ax.Controls.Add(ay);
		ax.Location = new Point(203, 321);
		ax.Name = "plode";
		ax.Size = new Size(305, 100);
		ax.TabIndex = 137;
		ay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ay.AutoSize = true;
		ay.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		ay.Location = new Point(62, 45);
		ay.Name = "label8";
		ay.Size = new Size(189, 13);
		ay.TabIndex = 30;
		ay.Text = "در حال بارگزاری لطفا کمی صبر کنید";
		y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		y.Controls.Add(ai);
		y.Controls.Add(ah);
		y.Controls.Add(af);
		y.Controls.Add(ag);
		y.Controls.Add(z);
		y.Controls.Add(aa);
		y.Controls.Add(ab);
		y.Controls.Add(ac);
		y.Controls.Add(ad);
		y.Controls.Add(ae);
		y.Location = new Point(166, 211);
		y.Name = "pdeleteStd";
		y.Size = new Size(386, 289);
		y.TabIndex = 135;
		y.Visible = false;
		ai.Image = (Image)componentResourceManager.GetObject("btnDeleteStd.Image");
		ai.Location = new Point(191, 218);
		ai.Name = "btnDeleteStd";
		ai.Size = new Size(137, 35);
		ai.TabIndex = 3;
		ai.Text = "حذف شاگرد";
		ai.Click += i;
		ah.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ah.ForeColor = Color.Red;
		ah.Location = new Point(8, 159);
		ah.Name = "label22";
		ah.Size = new Size(364, 56);
		ah.TabIndex = 141;
		ah.Text = "اخطار!! با حذف شاگرد تمام اطلاعات از جمله نمرات و مشخصات شاگرد حذف شده و قابل بازگشت نمیباشد";
		af.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		af.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		af.Location = new Point(57, 109);
		af.Name = "lClass";
		af.Size = new Size(180, 28);
		af.TabIndex = 140;
		af.TextAlign = ContentAlignment.MiddleCenter;
		ag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ag.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ag.Location = new Point(57, 76);
		ag.Name = "lPaye";
		ag.Size = new Size(180, 28);
		ag.TabIndex = 139;
		ag.TextAlign = ContentAlignment.MiddleCenter;
		z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		z.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		z.Location = new Point(57, 45);
		z.Name = "lName";
		z.Size = new Size(180, 28);
		z.TabIndex = 138;
		z.TextAlign = ContentAlignment.MiddleCenter;
		aa.AutoSize = true;
		aa.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aa.Location = new Point(241, 113);
		aa.Name = "label21";
		aa.Size = new Size(48, 16);
		aa.TabIndex = 137;
		aa.Text = "صنف :";
		ab.AutoSize = true;
		ab.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ab.Location = new Point(241, 81);
		ab.Name = "label18";
		ab.Size = new Size(87, 16);
		ab.TabIndex = 136;
		ab.Text = "صنف اصلی :";
		ac.AutoSize = true;
		ac.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ac.Location = new Point(241, 50);
		ac.Name = "label17";
		ac.Size = new Size(77, 16);
		ac.TabIndex = 135;
		ac.Text = "نام شاگرد :";
		ad.Image = (Image)componentResourceManager.GetObject("btnCancelDel.Image");
		ad.Location = new Point(36, 218);
		ad.Name = "btnCancelDel";
		ad.Size = new Size(145, 38);
		ad.TabIndex = 134;
		ad.Text = "انصراف";
		ad.Click += j;
		ae.AutoSize = true;
		ae.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ae.Location = new Point(100, 13);
		ae.Name = "label16";
		ae.Size = new Size(135, 16);
		ae.TabIndex = 128;
		ae.Text = "حذف شاگرد از برنامه";
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_j.Controls.Add(at);
		this.m_j.Controls.Add(ar);
		this.m_j.Controls.Add(@as);
		this.m_j.Controls.Add(ao);
		this.m_j.Controls.Add(ap);
		this.m_j.Controls.Add(an);
		this.m_j.Controls.Add(al);
		this.m_j.Controls.Add(am);
		this.m_j.Controls.Add(aj);
		this.m_j.Controls.Add(ak);
		this.m_j.Controls.Add(x);
		this.m_j.Controls.Add(t);
		this.m_j.Controls.Add(u);
		this.m_j.Controls.Add(s);
		this.m_j.Controls.Add(this.m_o);
		this.m_j.Controls.Add(this.m_p);
		this.m_j.Controls.Add(this.m_q);
		this.m_j.Controls.Add(this.m_r);
		this.m_j.Controls.Add(this.m_m);
		this.m_j.Controls.Add(this.m_n);
		this.m_j.Controls.Add(this.m_k);
		this.m_j.Controls.Add(this.m_l);
		this.m_j.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(11, -1);
		this.m_j.Name = "uiGroupBox1";
		this.m_j.Size = new Size(770, 159);
		this.m_j.TabIndex = 17;
		this.m_j.Text = "جستجو";
		at.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		at.Location = new Point(619, 86);
		at.Name = "lYear";
		at.Size = new Size(55, 24);
		at.TabIndex = 117;
		at.TextAlign = ContentAlignment.MiddleCenter;
		ar.AutoScroll = false;
		ar.AutoScrollMargin = new Size(0, 0);
		ar.AutoScrollMinSize = new Size(0, 0);
		ar.AutoScrollPosition = new Point(0, 0);
		ar.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ar.Location = new Point(20, 23);
		ar.MaxLength = 10;
		ar.Name = "txtCodeTakhfif";
		ar.Numeric = true;
		ar.RightToLeft = RightToLeft.Yes;
		ar.Size = new Size(153, 22);
		ar.TabIndex = 2;
		ar.Tag = "";
		ar.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ar.TextChanged += a;
		@as.AutoSize = true;
		@as.Location = new Point(178, 26);
		@as.Name = "label7";
		@as.Size = new Size(63, 14);
		@as.TabIndex = 116;
		@as.Text = "کد تخفیف";
		ao.AutoSize = true;
		ao.Location = new Point(680, 125);
		ao.Name = "label2";
		ao.Size = new Size(49, 14);
		ao.TabIndex = 114;
		ao.Text = "وضعیت";
		ap.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ap.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "کل";
		uIComboBoxItem.Value = "0";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "برحال";
		uIComboBoxItem2.Value = "1";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "محروم";
		uIComboBoxItem3.Value = "2";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "منفک";
		uIComboBoxItem4.Value = "3";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "معذرتی";
		uIComboBoxItem5.Value = "4";
		ap.Items.AddRange(new UIComboBoxItem[5] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5 });
		ap.Location = new Point(521, 121);
		ap.Name = "dropStatus";
		ap.Size = new Size(153, 22);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		ap.StringFormat = stringFormat;
		ap.TabIndex = 9;
		ap.SelectedIndexChanged += h;
		an.AutoSize = true;
		an.Location = new Point(678, 91);
		an.Name = "label3";
		an.Size = new Size(79, 14);
		an.TabIndex = 112;
		an.Text = "سال تعلیمی";
		al.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		al.DropListFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "کل";
		uIComboBoxItem6.Value = "-1";
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "مرد";
		uIComboBoxItem7.Value = "1";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "زن";
		uIComboBoxItem8.Value = "0";
		al.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem6, uIComboBoxItem7, uIComboBoxItem8 });
		al.Location = new Point(20, 53);
		al.Name = "dropJens";
		al.Size = new Size(153, 22);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		al.StringFormat = stringFormat2;
		al.TabIndex = 5;
		al.SelectedIndexChanged += g;
		am.AutoSize = true;
		am.Location = new Point(179, 57);
		am.Name = "label1";
		am.Size = new Size(52, 14);
		am.TabIndex = 85;
		am.Text = "جنیست";
		aj.AutoScroll = false;
		aj.AutoScrollMargin = new Size(0, 0);
		aj.AutoScrollMinSize = new Size(0, 0);
		aj.AutoScrollPosition = new Point(0, 0);
		aj.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aj.Location = new Point(521, 23);
		aj.MaxLength = 9;
		aj.Name = "txtNumberAsas";
		aj.Numeric = true;
		aj.RightToLeft = RightToLeft.Yes;
		aj.Size = new Size(153, 22);
		aj.TabIndex = 0;
		aj.Tag = "";
		aj.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		aj.TextChanged += a;
		ak.AutoSize = true;
		ak.Location = new Point(678, 27);
		ak.Name = "labl";
		ak.Size = new Size(72, 14);
		ak.TabIndex = 39;
		ak.Text = "نمبر اساس";
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.AutoSize = true;
		x.Location = new Point(270, 124);
		x.Name = "checkBox1";
		x.Size = new Size(142, 18);
		x.TabIndex = 10;
		x.Text = "نمایش عکس شاگرد";
		x.UseVisualStyleBackColor = true;
		x.CheckedChanged += k;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t.Location = new Point(269, 23);
		t.MaxLength = 10;
		t.Name = "txtCode";
		t.Numeric = true;
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(143, 22);
		t.TabIndex = 1;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.TextChanged += a;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.AutoSize = true;
		u.Location = new Point(418, 25);
		u.Name = "label6";
		u.Size = new Size(58, 14);
		u.TabIndex = 35;
		u.Text = "کد متعلم";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		s.ImageSize = new Size(25, 25);
		s.Location = new Point(21, 121);
		s.Name = "btnNoSearch";
		s.Size = new Size(152, 33);
		s.TabIndex = 11;
		s.Text = "حذف جستجو";
		s.Click += n;
		this.m_o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_o.AutoSize = true;
		this.m_o.Location = new Point(416, 59);
		this.m_o.Name = "label5";
		this.m_o.Size = new Size(53, 14);
		this.m_o.TabIndex = 29;
		this.m_o.Text = "ولد/بنت";
		this.m_p.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_p.AutoSize = true;
		this.m_p.Location = new Point(678, 58);
		this.m_p.Name = "label4";
		this.m_p.Size = new Size(23, 14);
		this.m_p.TabIndex = 28;
		this.m_p.Text = "نام";
		this.m_q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_q.AutoScroll = false;
		this.m_q.AutoScrollMargin = new Size(0, 0);
		this.m_q.AutoScrollMinSize = new Size(0, 0);
		this.m_q.AutoScrollPosition = new Point(0, 0);
		this.m_q.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_q.Location = new Point(269, 55);
		this.m_q.Name = "txtLName";
		this.m_q.RightToLeft = RightToLeft.Yes;
		this.m_q.Size = new Size(143, 22);
		this.m_q.TabIndex = 4;
		this.m_q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_q.TextChanged += a;
		this.m_r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_r.AutoScroll = false;
		this.m_r.AutoScrollMargin = new Size(0, 0);
		this.m_r.AutoScrollMinSize = new Size(0, 0);
		this.m_r.AutoScrollPosition = new Point(0, 0);
		this.m_r.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_r.Location = new Point(521, 54);
		this.m_r.Name = "txtFName";
		this.m_r.RightToLeft = RightToLeft.Yes;
		this.m_r.Size = new Size(153, 22);
		this.m_r.TabIndex = 3;
		this.m_r.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_r.TextChanged += a;
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.AutoSize = true;
		this.m_m.Location = new Point(179, 90);
		this.m_m.Name = "label19";
		this.m_m.Size = new Size(36, 14);
		this.m_m.TabIndex = 25;
		this.m_m.Text = "صنف";
		this.m_n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_n.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_n.Location = new Point(20, 85);
		this.m_n.Name = "dropCls";
		this.m_n.Size = new Size(153, 22);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		this.m_n.StringFormat = stringFormat3;
		this.m_n.TabIndex = 8;
		this.m_n.SelectedIndexChanged += m;
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.AutoSize = true;
		this.m_k.Location = new Point(416, 91);
		this.m_k.Name = "label20";
		this.m_k.Size = new Size(27, 14);
		this.m_k.TabIndex = 15;
		this.m_k.Text = "پایه";
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_l.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(269, 86);
		this.m_l.Name = "dropPaye";
		this.m_l.Size = new Size(143, 22);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		this.m_l.StringFormat = stringFormat4;
		this.m_l.TabIndex = 7;
		this.m_l.SelectedIndexChanged += o;
		this.m_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_f.Controls.Add(aw);
		this.m_f.Controls.Add(au);
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(this.m_h);
		this.m_f.Controls.Add(v);
		this.m_f.Font = new Font("B Nazanin", 12f);
		this.m_f.Location = new Point(8, 605);
		this.m_f.Name = "p_new";
		this.m_f.Size = new Size(776, 54);
		this.m_f.TabIndex = 9;
		aw.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		aw.Image = Resources.rptview;
		aw.Location = new Point(119, 3);
		aw.Name = "btnComment";
		aw.Size = new Size(111, 45);
		aw.TabIndex = 23;
		aw.Text = "یادداشت";
		aw.Click += d;
		au.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		au.Image = (Image)componentResourceManager.GetObject("btnEditlist.Image");
		au.Location = new Point(331, 3);
		au.Name = "btnEditlist";
		au.Size = new Size(156, 45);
		au.TabIndex = 22;
		au.Text = "اصلاح لیست";
		au.Click += e;
		this.m_g.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_g.Location = new Point(236, 3);
		this.m_g.Name = "btnDelete";
		this.m_g.Size = new Size(89, 45);
		this.m_g.TabIndex = 1;
		this.m_g.Text = "حذف";
		this.m_g.Click += l;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_i.ImageSize = new Size(20, 20);
		this.m_i.Location = new Point(3, 3);
		this.m_i.Name = "btnClose";
		this.m_i.Size = new Size(110, 45);
		this.m_i.TabIndex = 3;
		this.m_i.Text = "بستن";
		this.m_i.Click += p;
		this.m_h.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_h.Location = new Point(651, 3);
		this.m_h.Name = "btnNew";
		this.m_h.Size = new Size(122, 45);
		this.m_h.TabIndex = 0;
		this.m_h.Text = "ثبت نام جدید";
		this.m_h.Click += q;
		v.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		v.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		v.Location = new Point(491, 3);
		v.Name = "btnEdit";
		v.Size = new Size(156, 45);
		v.TabIndex = 2;
		v.Text = "اصلاح مورد انتخابی";
		v.Click += f;
		av.AllowEdit = InheritableBoolean.False;
		av.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		av.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		av.DesignTimeLayout = gridEXLayout;
		av.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		av.Font = new Font("Tahoma", 9.75f);
		av.GroupByBoxFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		av.Location = new Point(8, 163);
		av.Name = "gridEX1";
		av.RecordNavigator = true;
		av.RowHeaders = InheritableBoolean.True;
		av.Size = new Size(776, 433);
		av.TabIndex = 136;
		av.VisualStyle = VisualStyle.Office2003;
		w.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		w.Title = "انتخاب عکس شاگرد";
		aq.BackColor = Color.Black;
		aq.Controls.Add(this.m_e);
		aq.Dock = DockStyle.Fill;
		aq.Location = new Point(0, 0);
		aq.Name = "panel2";
		aq.Size = new Size(800, 675);
		aq.TabIndex = 1;
		az.Interval = 700;
		az.Tick += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 675);
		Controls.Add(aq);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmlistStd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست شاگردان";
		Load += r;
		Shown += c;
		this.m_e.ResumeLayout(performLayout: false);
		ax.ResumeLayout(performLayout: false);
		ax.PerformLayout();
		y.ResumeLayout(performLayout: false);
		y.PerformLayout();
		((ISupportInitialize)this.m_j).EndInit();
		this.m_j.ResumeLayout(performLayout: false);
		this.m_j.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		((ISupportInitialize)av).EndInit();
		aq.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
