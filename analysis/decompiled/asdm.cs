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
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)this.m_e).BackColor = Color.FromArgb(red, green, blue);
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
					((Control)at).Text = asdaj.a;
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
			this.m_l.Items.Add("کل", (object)"0");
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
					this.m_l.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
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
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + ((Control)at).Text + text);
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
					text = " tYear_Student.xYear=" + ((Control)at).Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = this.m_n.SelectedIndex <= 0;
					if (true)
					{
					}
					num = 36;
					continue;
				case 47:
					flag = !(((Control)aj).Text.Trim() != "");
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
					text = text + " tstudent.code=" + ((Control)t).Text.Trim();
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
					text = text + " tYear_Student.codeTakhfif=" + ((Control)ar).Text.Trim();
					num = 40;
					continue;
				case 57:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName, tStudent.LName, \r\n  tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName,                      \r\ntStudent.PName, tStudent.Sh_Sh,tStudent.bDate,tStudent.bDateM, tStudent.MobileMother, tStudent.MobileFather, tClass.name AS Class, tPaye.Name AS Paye,\r\n                       tStudent.NumberTelegram, tStudent.NumberTelegram2, tStudent.NumberAsas, tStudent.RegDate, \r\n                      tYear_Student.Status, tYear_Student.sort, tYear_Student.shaghe, tYear_Student.hazer, tYear_Student.mali, \r\n                      tYear_Student.dakhle, tYear_Student.uniform, tYear_Student.komakdarsi, tYear_Student.ketab, tYear_Student.transport, \r\n                      tYear_Student.robotic, tYear_Student.maghnae, tYear_Student.Sumtransport,case tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک'  when 4 then N'معذرتی' end as vazeyat,\r\n                    tYear_Student.codeTakhfif" + text2 + " FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id  " + text3 + text);
					av.DataSource = dataSource;
					((Control)ax).Visible = false;
					num = 4;
					continue;
				}
				case 4:
					return;
				case 50:
					flag = !(((Control)this.m_r).Text.Trim() != "");
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
					text = text + " tstudent.NumberAsas=" + ((Control)aj).Text.Trim();
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
					flag = !(((Control)ar).Text.Trim() != "");
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
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)this.m_q).Text) + "%'";
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
					flag = !(((Control)this.m_q).Text.Trim() != "");
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
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)this.m_r).Text) + "%'";
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
					flag = !(((Control)t).Text.Trim() != "");
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (true)
			{
			}
			asdaj.h = false;
			asdat asdat2 = new asdat();
			((Form)asdat2).ShowDialog();
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
		((Form)this).Close();
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
		((Control)this.m_q).Text = "";
		((Control)this.m_r).Text = "";
		((Control)t).Text = "";
		((Control)aj).Text = "";
		((Control)ar).Text = "";
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
		((Control)ax).Visible = true;
		((Control)this).Refresh();
		c();
	}

	private void l(object A_0, EventArgs A_1)
	{
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
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
						num2 = (((int)MessageBox.Show("آيا از حذف شاگرد مطمئن هستيد؟", "حذف شاگرد", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6) ? 1 : 0);
						goto IL_01cd;
					case 4:
						num = 0;
						continue;
					case 0:
						if ((int)av.SelectedItems[0].RowType == 0)
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
						((Control)y).Visible = true;
						((Control)z).Text = av.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + av.SelectedItems[0].GetRow().Cells["lname"].Value.ToString();
						((Control)ag).Text = av.SelectedItems[0].GetRow().Cells["paye"].Value.ToString();
						((Control)af).Text = av.SelectedItems[0].GetRow().Cells["class"].Value.ToString();
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
		((Control)y).Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)MessageBox.Show("با حذف شاگرد کلیه اطلاعات مربوط به او حذف خواهد شد\n\nآیا از حذف شاگرد اطمینان دارید؟", "حذف شاگرد", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
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
					((Control)y).Visible = false;
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
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
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
					num2 = (((int)av.SelectedItems[0].RowType != 0) ? 1 : 0);
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
					asdat2.a = text;
					((Form)asdat2).ShowDialog();
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
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
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
					asdat2.ce.Items.Add(av.GetRow(num2).Cells["id"].Value.ToString(), (object)av.GetRow(num2).Cells["id"].Value.ToString());
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
					((Form)asdat2).ShowDialog();
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
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
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
					num2 = (((int)av.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_00d8;
				case 3:
				{
					string text = av.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asda4 asda10 = new asda4();
					asda10.a = text;
					((Form)asda10).ShowDialog();
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
		((Control)this).Refresh();
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

	protected override void a(bool A_0)
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected Obj, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected Obj, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected Obj, but got Unknown
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Expected Obj, but got Unknown
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f30: Expected Obj, but got Unknown
		//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Expected Obj, but got Unknown
		//IL_12ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1309: Expected Obj, but got Unknown
		//IL_1518: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected Obj, but got Unknown
		//IL_1740: Unknown result type (might be due to invalid IL or missing references)
		//IL_174a: Expected Obj, but got Unknown
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1887: Expected Obj, but got Unknown
		//IL_1a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a73: Expected Obj, but got Unknown
		//IL_1b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b65: Expected Obj, but got Unknown
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9a: Expected Obj, but got Unknown
		//IL_1de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df1: Expected Obj, but got Unknown
		//IL_1f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f49: Expected Obj, but got Unknown
		//IL_1fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb3: Expected Obj, but got Unknown
		//IL_2047: Unknown result type (might be due to invalid IL or missing references)
		//IL_2051: Expected Obj, but got Unknown
		//IL_2063: Unknown result type (might be due to invalid IL or missing references)
		//IL_206d: Expected Obj, but got Unknown
		//IL_20f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2100: Expected Obj, but got Unknown
		//IL_2112: Unknown result type (might be due to invalid IL or missing references)
		//IL_211c: Expected Obj, but got Unknown
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b9: Expected Obj, but got Unknown
		//IL_21cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d5: Expected Obj, but got Unknown
		//IL_226b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2275: Expected Obj, but got Unknown
		//IL_2287: Unknown result type (might be due to invalid IL or missing references)
		//IL_2291: Expected Obj, but got Unknown
		//IL_2316: Unknown result type (might be due to invalid IL or missing references)
		//IL_2320: Expected Obj, but got Unknown
		//IL_2332: Unknown result type (might be due to invalid IL or missing references)
		//IL_233c: Expected Obj, but got Unknown
		//IL_2422: Unknown result type (might be due to invalid IL or missing references)
		//IL_242c: Expected Obj, but got Unknown
		if (true)
		{
		}
		this.m_d = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdm));
		UIComboBoxItem val = new UIComboBoxItem();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		StringFormat val6 = new StringFormat();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		StringFormat val10 = new StringFormat();
		StringFormat val11 = new StringFormat();
		StringFormat val12 = new StringFormat();
		GridEXLayout val13 = new GridEXLayout();
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
		((Control)this.m_e).SuspendLayout();
		((Control)ax).SuspendLayout();
		((Control)y).SuspendLayout();
		((ISupportInitialize)this.m_j).BeginInit();
		((Control)this.m_j).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((ISupportInitialize)av).BeginInit();
		((Control)aq).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_e).BackColor = SystemColors.GradientInactiveCaption;
		this.m_e.BorderStyle = (BorderStyle)1;
		((Control)this.m_e).Controls.Add((Control)(object)ax);
		((Control)this.m_e).Controls.Add((Control)(object)y);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Controls.Add((Control)(object)av);
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_e).Location = new Point(3, 3);
		((Control)this.m_e).Name = "panel1";
		((Control)this.m_e).Size = new Size(794, 669);
		((Control)this.m_e).TabIndex = 0;
		((Control)ax).Controls.Add((Control)(object)ay);
		((Control)ax).Location = new Point(203, 321);
		((Control)ax).Name = "plode";
		((Control)ax).Size = new Size(305, 100);
		((Control)ax).TabIndex = 137;
		((Control)ay).Anchor = (AnchorStyles)9;
		((Control)ay).AutoSize = true;
		((Control)ay).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((Control)ay).Location = new Point(62, 45);
		((Control)ay).Name = "label8";
		((Control)ay).Size = new Size(189, 13);
		((Control)ay).TabIndex = 30;
		((Control)ay).Text = "در حال بارگزاری لطفا کمی صبر کنید";
		((Control)y).Anchor = (AnchorStyles)9;
		y.BorderStyle = (BorderStyle)1;
		((Control)y).Controls.Add((Control)(object)ai);
		((Control)y).Controls.Add((Control)(object)ah);
		((Control)y).Controls.Add((Control)(object)af);
		((Control)y).Controls.Add((Control)(object)ag);
		((Control)y).Controls.Add((Control)(object)z);
		((Control)y).Controls.Add((Control)(object)aa);
		((Control)y).Controls.Add((Control)(object)ab);
		((Control)y).Controls.Add((Control)(object)ac);
		((Control)y).Controls.Add((Control)(object)ad);
		((Control)y).Controls.Add((Control)(object)ae);
		((Control)y).Location = new Point(166, 211);
		((Control)y).Name = "pdeleteStd";
		((Control)y).Size = new Size(386, 289);
		((Control)y).TabIndex = 135;
		((Control)y).Visible = false;
		ai.Image = (Image)componentResourceManager.GetObject("btnDeleteStd.Image");
		((Control)ai).Location = new Point(191, 218);
		((Control)ai).Name = "btnDeleteStd";
		((Control)ai).Size = new Size(137, 35);
		((Control)ai).TabIndex = 3;
		((Control)ai).Text = "حذف شاگرد";
		((Control)ai).Click += i;
		((Control)ah).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ah).ForeColor = Color.Red;
		((Control)ah).Location = new Point(8, 159);
		((Control)ah).Name = "label22";
		((Control)ah).Size = new Size(364, 56);
		((Control)ah).TabIndex = 141;
		((Control)ah).Text = "اخطار!! با حذف شاگرد تمام اطلاعات از جمله نمرات و مشخصات شاگرد حذف شده و قابل بازگشت نمیباشد";
		af.BorderStyle = (BorderStyle)1;
		((Control)af).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)af).Location = new Point(57, 109);
		((Control)af).Name = "lClass";
		((Control)af).Size = new Size(180, 28);
		((Control)af).TabIndex = 140;
		af.TextAlign = (ContentAlignment)32;
		ag.BorderStyle = (BorderStyle)1;
		((Control)ag).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ag).Location = new Point(57, 76);
		((Control)ag).Name = "lPaye";
		((Control)ag).Size = new Size(180, 28);
		((Control)ag).TabIndex = 139;
		ag.TextAlign = (ContentAlignment)32;
		z.BorderStyle = (BorderStyle)1;
		((Control)z).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)z).Location = new Point(57, 45);
		((Control)z).Name = "lName";
		((Control)z).Size = new Size(180, 28);
		((Control)z).TabIndex = 138;
		z.TextAlign = (ContentAlignment)32;
		((Control)aa).AutoSize = true;
		((Control)aa).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)aa).Location = new Point(241, 113);
		((Control)aa).Name = "label21";
		((Control)aa).Size = new Size(48, 16);
		((Control)aa).TabIndex = 137;
		((Control)aa).Text = "صنف :";
		((Control)ab).AutoSize = true;
		((Control)ab).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ab).Location = new Point(241, 81);
		((Control)ab).Name = "label18";
		((Control)ab).Size = new Size(87, 16);
		((Control)ab).TabIndex = 136;
		((Control)ab).Text = "صنف اصلی :";
		((Control)ac).AutoSize = true;
		((Control)ac).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ac).Location = new Point(241, 50);
		((Control)ac).Name = "label17";
		((Control)ac).Size = new Size(77, 16);
		((Control)ac).TabIndex = 135;
		((Control)ac).Text = "نام شاگرد :";
		ad.Image = (Image)componentResourceManager.GetObject("btnCancelDel.Image");
		((Control)ad).Location = new Point(36, 218);
		((Control)ad).Name = "btnCancelDel";
		((Control)ad).Size = new Size(145, 38);
		((Control)ad).TabIndex = 134;
		((Control)ad).Text = "انصراف";
		((Control)ad).Click += j;
		((Control)ae).AutoSize = true;
		((Control)ae).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ae).Location = new Point(100, 13);
		((Control)ae).Name = "label16";
		((Control)ae).Size = new Size(135, 16);
		((Control)ae).TabIndex = 128;
		((Control)ae).Text = "حذف شاگرد از برنامه";
		((Control)this.m_j).Anchor = (AnchorStyles)13;
		((Control)this.m_j).Controls.Add((Control)(object)at);
		((Control)this.m_j).Controls.Add((Control)(object)ar);
		((Control)this.m_j).Controls.Add((Control)(object)@as);
		((Control)this.m_j).Controls.Add((Control)(object)ao);
		((Control)this.m_j).Controls.Add((Control)(object)ap);
		((Control)this.m_j).Controls.Add((Control)(object)an);
		((Control)this.m_j).Controls.Add((Control)(object)al);
		((Control)this.m_j).Controls.Add((Control)(object)am);
		((Control)this.m_j).Controls.Add((Control)(object)aj);
		((Control)this.m_j).Controls.Add((Control)(object)ak);
		((Control)this.m_j).Controls.Add((Control)(object)x);
		((Control)this.m_j).Controls.Add((Control)(object)t);
		((Control)this.m_j).Controls.Add((Control)(object)u);
		((Control)this.m_j).Controls.Add((Control)(object)s);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_p);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_r);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_j).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_j).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(11, -1);
		((Control)this.m_j).Name = "uiGroupBox1";
		((Control)this.m_j).Size = new Size(770, 159);
		((Control)this.m_j).TabIndex = 17;
		((Control)this.m_j).Text = "جستجو";
		at.BorderStyle = (BorderStyle)1;
		((Control)at).Location = new Point(619, 86);
		((Control)at).Name = "lYear";
		((Control)at).Size = new Size(55, 24);
		((Control)at).TabIndex = 117;
		at.TextAlign = (ContentAlignment)32;
		((EditBase)ar).AutoScroll = false;
		((EditBase)ar).AutoScrollMargin = new Size(0, 0);
		((EditBase)ar).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ar).AutoScrollPosition = new Point(0, 0);
		((EditBase)ar).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ar).Location = new Point(20, 23);
		((EditBase)ar).MaxLength = 10;
		((Control)ar).Name = "txtCodeTakhfif";
		ar.Numeric = true;
		((Control)ar).RightToLeft = (RightToLeft)1;
		((Control)ar).Size = new Size(153, 22);
		((Control)ar).TabIndex = 2;
		((Control)ar).Tag = "";
		((EditBase)ar).TextAlignment = (TextAlignment)1;
		((Control)ar).TextChanged += a;
		((Control)@as).AutoSize = true;
		((Control)@as).Location = new Point(178, 26);
		((Control)@as).Name = "label7";
		((Control)@as).Size = new Size(63, 14);
		((Control)@as).TabIndex = 116;
		((Control)@as).Text = "کد تخفیف";
		((Control)ao).AutoSize = true;
		((Control)ao).Location = new Point(680, 125);
		((Control)ao).Name = "label2";
		((Control)ao).Size = new Size(49, 14);
		((Control)ao).TabIndex = 114;
		((Control)ao).Text = "وضعیت";
		((UIComboBase)ap).ComboStyle = (ComboStyle)1;
		((UIComboBase)ap).DropListFont = new Font("B Nazanin", 12f);
		val.FormatStyle.Alpha = 0;
		val.Text = "کل";
		val.Value = "0";
		val2.FormatStyle.Alpha = 0;
		val2.Text = "برحال";
		val2.Value = "1";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "محروم";
		val3.Value = "2";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "منفک";
		val4.Value = "3";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "معذرتی";
		val5.Value = "4";
		ap.Items.AddRange(new UIComboBoxItem[5] { val, val2, val3, val4, val5 });
		((Control)ap).Location = new Point(521, 121);
		((Control)ap).Name = "dropStatus";
		((Control)ap).Size = new Size(153, 22);
		val6.Alignment = (StringAlignment)0;
		val6.FormatFlags = (StringFormatFlags)20485;
		val6.HotkeyPrefix = (HotkeyPrefix)0;
		val6.LineAlignment = (StringAlignment)1;
		val6.Trimming = (StringTrimming)1;
		((UIComboBase)ap).StringFormat = val6;
		((Control)ap).TabIndex = 9;
		ap.SelectedIndexChanged += h;
		((Control)an).AutoSize = true;
		((Control)an).Location = new Point(678, 91);
		((Control)an).Name = "label3";
		((Control)an).Size = new Size(79, 14);
		((Control)an).TabIndex = 112;
		((Control)an).Text = "سال تعلیمی";
		((UIComboBase)al).ComboStyle = (ComboStyle)1;
		((UIComboBase)al).DropListFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		val7.FormatStyle.Alpha = 0;
		val7.Text = "کل";
		val7.Value = "-1";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "مرد";
		val8.Value = "1";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "زن";
		val9.Value = "0";
		al.Items.AddRange(new UIComboBoxItem[3] { val7, val8, val9 });
		((Control)al).Location = new Point(20, 53);
		((Control)al).Name = "dropJens";
		((Control)al).Size = new Size(153, 22);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)al).StringFormat = val10;
		((Control)al).TabIndex = 5;
		al.SelectedIndexChanged += g;
		((Control)am).AutoSize = true;
		((Control)am).Location = new Point(179, 57);
		((Control)am).Name = "label1";
		((Control)am).Size = new Size(52, 14);
		((Control)am).TabIndex = 85;
		((Control)am).Text = "جنیست";
		((EditBase)aj).AutoScroll = false;
		((EditBase)aj).AutoScrollMargin = new Size(0, 0);
		((EditBase)aj).AutoScrollMinSize = new Size(0, 0);
		((EditBase)aj).AutoScrollPosition = new Point(0, 0);
		((EditBase)aj).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)aj).Location = new Point(521, 23);
		((EditBase)aj).MaxLength = 9;
		((Control)aj).Name = "txtNumberAsas";
		aj.Numeric = true;
		((Control)aj).RightToLeft = (RightToLeft)1;
		((Control)aj).Size = new Size(153, 22);
		((Control)aj).TabIndex = 0;
		((Control)aj).Tag = "";
		((EditBase)aj).TextAlignment = (TextAlignment)1;
		((Control)aj).TextChanged += a;
		((Control)ak).AutoSize = true;
		((Control)ak).Location = new Point(678, 27);
		((Control)ak).Name = "labl";
		((Control)ak).Size = new Size(72, 14);
		((Control)ak).TabIndex = 39;
		((Control)ak).Text = "نمبر اساس";
		((Control)x).Anchor = (AnchorStyles)9;
		((Control)x).AutoSize = true;
		((Control)x).Location = new Point(270, 124);
		((Control)x).Name = "checkBox1";
		((Control)x).Size = new Size(142, 18);
		((Control)x).TabIndex = 10;
		((Control)x).Text = "نمایش عکس شاگرد";
		((ButtonBase)x).UseVisualStyleBackColor = true;
		x.CheckedChanged += k;
		((Control)t).Anchor = (AnchorStyles)9;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((EditBase)t).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)t).Location = new Point(269, 23);
		((EditBase)t).MaxLength = 10;
		((Control)t).Name = "txtCode";
		t.Numeric = true;
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(143, 22);
		((Control)t).TabIndex = 1;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((Control)t).TextChanged += a;
		((Control)u).Anchor = (AnchorStyles)9;
		((Control)u).AutoSize = true;
		((Control)u).Location = new Point(418, 25);
		((Control)u).Name = "label6";
		((Control)u).Size = new Size(58, 14);
		((Control)u).TabIndex = 35;
		((Control)u).Text = "کد متعلم";
		((Control)s).Anchor = (AnchorStyles)9;
		s.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		s.ImageSize = new Size(25, 25);
		((Control)s).Location = new Point(21, 121);
		((Control)s).Name = "btnNoSearch";
		((Control)s).Size = new Size(152, 33);
		((Control)s).TabIndex = 11;
		((Control)s).Text = "حذف جستجو";
		((Control)s).Click += n;
		((Control)this.m_o).Anchor = (AnchorStyles)9;
		((Control)this.m_o).AutoSize = true;
		((Control)this.m_o).Location = new Point(416, 59);
		((Control)this.m_o).Name = "label5";
		((Control)this.m_o).Size = new Size(53, 14);
		((Control)this.m_o).TabIndex = 29;
		((Control)this.m_o).Text = "ولد/بنت";
		((Control)this.m_p).Anchor = (AnchorStyles)9;
		((Control)this.m_p).AutoSize = true;
		((Control)this.m_p).Location = new Point(678, 58);
		((Control)this.m_p).Name = "label4";
		((Control)this.m_p).Size = new Size(23, 14);
		((Control)this.m_p).TabIndex = 28;
		((Control)this.m_p).Text = "نام";
		((Control)this.m_q).Anchor = (AnchorStyles)9;
		((EditBase)this.m_q).AutoScroll = false;
		((EditBase)this.m_q).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_q).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_q).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_q).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_q).Location = new Point(269, 55);
		((Control)this.m_q).Name = "txtLName";
		((Control)this.m_q).RightToLeft = (RightToLeft)1;
		((Control)this.m_q).Size = new Size(143, 22);
		((Control)this.m_q).TabIndex = 4;
		((EditBase)this.m_q).TextAlignment = (TextAlignment)1;
		((Control)this.m_q).TextChanged += a;
		((Control)this.m_r).Anchor = (AnchorStyles)9;
		((EditBase)this.m_r).AutoScroll = false;
		((EditBase)this.m_r).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_r).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_r).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_r).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_r).Location = new Point(521, 54);
		((Control)this.m_r).Name = "txtFName";
		((Control)this.m_r).RightToLeft = (RightToLeft)1;
		((Control)this.m_r).Size = new Size(153, 22);
		((Control)this.m_r).TabIndex = 3;
		((EditBase)this.m_r).TextAlignment = (TextAlignment)1;
		((Control)this.m_r).TextChanged += a;
		((Control)this.m_m).Anchor = (AnchorStyles)9;
		((Control)this.m_m).AutoSize = true;
		((Control)this.m_m).Location = new Point(179, 90);
		((Control)this.m_m).Name = "label19";
		((Control)this.m_m).Size = new Size(36, 14);
		((Control)this.m_m).TabIndex = 25;
		((Control)this.m_m).Text = "صنف";
		((Control)this.m_n).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_n).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_n).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_n).Location = new Point(20, 85);
		((Control)this.m_n).Name = "dropCls";
		((Control)this.m_n).Size = new Size(153, 22);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_n).StringFormat = val11;
		((Control)this.m_n).TabIndex = 8;
		this.m_n.SelectedIndexChanged += m;
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Location = new Point(416, 91);
		((Control)this.m_k).Name = "label20";
		((Control)this.m_k).Size = new Size(27, 14);
		((Control)this.m_k).TabIndex = 15;
		((Control)this.m_k).Text = "پایه";
		((Control)this.m_l).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_l).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_l).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Location = new Point(269, 86);
		((Control)this.m_l).Name = "dropPaye";
		((Control)this.m_l).Size = new Size(143, 22);
		val12.Alignment = (StringAlignment)0;
		val12.FormatFlags = (StringFormatFlags)20485;
		val12.HotkeyPrefix = (HotkeyPrefix)0;
		val12.LineAlignment = (StringAlignment)1;
		val12.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_l).StringFormat = val12;
		((Control)this.m_l).TabIndex = 7;
		this.m_l.SelectedIndexChanged += o;
		((Control)this.m_f).Anchor = (AnchorStyles)10;
		((Control)this.m_f).Controls.Add((Control)(object)aw);
		((Control)this.m_f).Controls.Add((Control)(object)au);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_f).Controls.Add((Control)(object)v);
		((Control)this.m_f).Font = new Font("B Nazanin", 12f);
		((Control)this.m_f).Location = new Point(8, 605);
		((Control)this.m_f).Name = "p_new";
		((Control)this.m_f).Size = new Size(776, 54);
		((Control)this.m_f).TabIndex = 9;
		((Control)aw).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		aw.Image = (Image)(object)Resources.rptview;
		((Control)aw).Location = new Point(119, 3);
		((Control)aw).Name = "btnComment";
		((Control)aw).Size = new Size(111, 45);
		((Control)aw).TabIndex = 23;
		((Control)aw).Text = "یادداشت";
		((Control)aw).Click += d;
		((Control)au).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		au.Image = (Image)componentResourceManager.GetObject("btnEditlist.Image");
		((Control)au).Location = new Point(331, 3);
		((Control)au).Name = "btnEditlist";
		((Control)au).Size = new Size(156, 45);
		((Control)au).TabIndex = 22;
		((Control)au).Text = "اصلاح لیست";
		((Control)au).Click += e;
		((Control)this.m_g).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_g).Location = new Point(236, 3);
		((Control)this.m_g).Name = "btnDelete";
		((Control)this.m_g).Size = new Size(89, 45);
		((Control)this.m_g).TabIndex = 1;
		((Control)this.m_g).Text = "حذف";
		((Control)this.m_g).Click += l;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_i.ImageSize = new Size(20, 20);
		((Control)this.m_i).Location = new Point(3, 3);
		((Control)this.m_i).Name = "btnClose";
		((Control)this.m_i).Size = new Size(110, 45);
		((Control)this.m_i).TabIndex = 3;
		((Control)this.m_i).Text = "بستن";
		((Control)this.m_i).Click += p;
		((Control)this.m_h).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_h).Location = new Point(651, 3);
		((Control)this.m_h).Name = "btnNew";
		((Control)this.m_h).Size = new Size(122, 45);
		((Control)this.m_h).TabIndex = 0;
		((Control)this.m_h).Text = "ثبت نام جدید";
		((Control)this.m_h).Click += q;
		((Control)v).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		v.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)v).Location = new Point(491, 3);
		((Control)v).Name = "btnEdit";
		((Control)v).Size = new Size(156, 45);
		((Control)v).TabIndex = 2;
		((Control)v).Text = "اصلاح مورد انتخابی";
		((Control)v).Click += f;
		av.AllowEdit = (InheritableBoolean)2;
		((Control)av).Anchor = (AnchorStyles)15;
		av.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		val13.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		av.DesignTimeLayout = val13;
		av.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)av).Font = new Font("Tahoma", 9.75f);
		av.GroupByBoxFormatStyle.TextAlignment = (TextAlignment)2;
		((Control)av).Location = new Point(8, 163);
		((Control)av).Name = "gridEX1";
		((ScrollableBase)av).RecordNavigator = true;
		av.RowHeaders = (InheritableBoolean)1;
		((Control)av).Size = new Size(776, 433);
		((Control)av).TabIndex = 136;
		((ScrollableBase)av).VisualStyle = (VisualStyle)2;
		((FileDialog)w).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)w).Title = "انتخاب عکس شاگرد";
		((Control)aq).BackColor = Color.Black;
		((Control)aq).Controls.Add((Control)(object)this.m_e);
		((Control)aq).Dock = (DockStyle)5;
		((Control)aq).Location = new Point(0, 0);
		((Control)aq).Name = "panel2";
		((Control)aq).Size = new Size(800, 675);
		((Control)aq).TabIndex = 1;
		az.Interval = 700;
		az.Tick += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 675);
		((Control)this).Controls.Add((Control)(object)aq);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmlistStd";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست شاگردان";
		((Form)this).Load += r;
		((Form)this).Shown += c;
		((Control)this.m_e).ResumeLayout(false);
		((Control)ax).ResumeLayout(false);
		((Control)ax).PerformLayout();
		((Control)y).ResumeLayout(false);
		((Control)y).PerformLayout();
		((ISupportInitialize)this.m_j).EndInit();
		((Control)this.m_j).ResumeLayout(false);
		((Control)this.m_j).PerformLayout();
		((Control)this.m_f).ResumeLayout(false);
		((ISupportInitialize)av).EndInit();
		((Control)aq).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
