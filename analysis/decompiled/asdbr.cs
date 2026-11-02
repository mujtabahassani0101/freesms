using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbr : Form
{
	private bool m_a = false;

	private IContainer m_b = null;

	private UIButton m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private Label m_f;

	private GridEX g;

	private EditBox h;

	private EditBox i;

	private Label j;

	private UIComboBox k;

	private Label l;

	private UIComboBox m;

	private UIGroupBox n;

	private GridEX o;

	private UIButton p;

	private UIButton q;

	private Label r;

	private Label s;

	public asdbr()
	{
		a();
	}

	private void e()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") order by id");
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
				case 1:
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					m.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 1;
					continue;
				case 0:
					m.SelectedIndex = 0;
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
			if (true)
			{
			}
			this.m_a = false;
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = m.SelectedIndex <= 0;
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
					goto case 1;
				case 0:
					text = " and xPaye=" + m.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + ((Control)s).Text + text);
					k.DataSource = dataSource;
					k.DisplayMember = "Name";
					k.ValueMember = "id";
					this.m_a = true;
					k.SelectedIndex = 0;
					return;
				}
				}
				break;
			}
		}
	}

	private void c()
	{
		string text = default;
		while (true)
		{
			g.DataSource = null;
			bool flag = this.m_a;
			int num = 15;
			while (true)
			{
				switch (num)
				{
				case 15:
					if (!flag)
					{
						num = 5;
						continue;
					}
					text = " tYear_Student.xyear=" + ((Control)s).Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = k.SelectedIndex <= 0;
					num = 20;
					continue;
				case 21:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 9;
				case 28:
					text += " and ";
					num = 0;
					continue;
				case 14:
					text = text + " tYear_Student.xClass=" + k.SelectedValue.ToString();
					num = 26;
					continue;
				case 23:
					flag = !(text != "");
					num = 29;
					continue;
				case 29:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 27;
				case 2:
					flag = !(text != "");
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 14;
				case 30:
					text += " and ";
					num = 9;
					continue;
				case 27:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName, \r\n                 tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text + " order by tYear_Student.sort,tStudent.lname,tStudent.fname");
					g.DataSource = dataSource;
					flag = g.RowCount <= 0;
					num = 31;
					continue;
				}
				case 31:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 10:
					flag = !(text != "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 28;
						continue;
					}
					goto case 0;
				case 26:
					flag = m.SelectedIndex <= 0;
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 8;
				case 6:
					text = " where " + text;
					num = 27;
					continue;
				case 16:
					g.Row = 0;
					num = 24;
					continue;
				case 24:
					return;
				case 22:
					text += " and ";
					num = 12;
					continue;
				case 5:
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					text += " and ";
					num = 14;
					continue;
				case 18:
					flag = !(text != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 12;
				case 12:
					text = text + " tYear_Student.xPaye=" + m.SelectedValue.ToString();
					num = 8;
					continue;
				case 9:
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)h).Text) + "%'";
					num = 23;
					continue;
				case 13:
					flag = !(((Control)h).Text.Trim() != "");
					num = 7;
					continue;
				case 7:
					if (true)
					{
					}
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 23;
				case 8:
					flag = !(((Control)i).Text.Trim() != "");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 13;
				case 20:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 26;
				case 0:
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)i).Text) + "%'";
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id,tStudent.NumberAsas,  tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id where tYear_Student.xyear=" + ((Control)s).Text + " and tYear_Student.notShowBalance=1");
		o.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		int num2 = default;
		while (true)
		{
			bool flag = g.RowCount != 0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					text = g.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num2 = 0;
					num = 7;
					continue;
				case 1:
					MessageBox.Show("این شاگرد قبلا به لیست پرینت اضافه شده است");
					num = 3;
					continue;
				case 3:
					return;
				case 9:
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set notShowBalance=1 where xstudent=" + text + " and xyear=" + ((Control)s).Text);
					b();
					((Control)i).Focus();
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					MessageBox.Show("موردی جهت اضافه شدن وجود ندارد");
					((Control)i).Focus();
					num = 8;
					continue;
				case 8:
					return;
				case 4:
				case 7:
					if (true)
					{
					}
					flag = num2 < o.RowCount;
					num = 6;
					continue;
				case 6:
				{
					if (!flag)
					{
						num = 9;
						continue;
					}
					string text2 = o.GetRow(num2).Cells["id"].Value.ToString();
					flag = !(text2 == text);
					num = 10;
					continue;
				}
				case 10:
					if (flag)
					{
						num2++;
						num = 4;
					}
					else
					{
						num = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
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
					num = ((o.RowCount > 0) ? 9 : 0);
					continue;
				case 9:
					num = 1;
					continue;
				case 1:
					if (true)
					{
					}
					num2 = (((int)o.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_009c;
				case 0:
					num2 = 1;
					goto IL_009c;
				case 7:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 4:
					flag = (int)MessageBox.Show("آيا میخواهید شاگرد را از این لیست حذف کنید؟", "حذف از لیست", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 6;
				case 6:
					num = 8;
					continue;
				case 8:
					return;
				case 5:
					{
						string text = o.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
						asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set notShowBalance=0 where xstudent=" + text + " and xyear=" + ((Control)s).Text);
						b();
						((Control)i).Focus();
						num = 6;
						continue;
					}
					IL_009c:
					flag = (byte)num2 != 0;
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		c();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		c();
	}

	private void c(object A_0, EventArgs A_1)
	{
		c();
	}

	private void b(object A_0, EventArgs A_1)
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
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = (int)A_1.KeyCode != 46;
					num = 0;
					continue;
				case 3:
					d(this, null);
					num = 5;
					continue;
				case 5:
					return;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 2:
					e(this, null);
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
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("4");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
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
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 6;
				case 6:
					((Control)s).Text = asdaj.a;
					e();
					b();
					((Control)i).Focus();
					((Control)i).Select();
					((EditBase)i).SelectAll();
					num = 1;
					continue;
				case 1:
					if (1 == 0)
					{
					}
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 7;
					continue;
				case 7:
					return;
				case 5:
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	protected override void a(bool A_0)
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
					if (true)
					{
					}
					num = ((!A_0) ? 6 : 2);
					continue;
				case 2:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_b.Dispose();
					num = 1;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 6:
					num2 = 1;
					goto IL_007c;
				case 1:
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
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected Obj, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected Obj, but got Unknown
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected Obj, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected Obj, but got Unknown
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Expected Obj, but got Unknown
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Expected Obj, but got Unknown
		//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Expected Obj, but got Unknown
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected Obj, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbr));
		GridEXLayout val = new GridEXLayout();
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		GridEXLayout val4 = new GridEXLayout();
		this.m_c = new UIButton();
		this.m_d = new UIGroupBox();
		s = new Label();
		r = new Label();
		this.m_e = new Label();
		this.m_f = new Label();
		g = new GridEX();
		h = new EditBox();
		i = new EditBox();
		j = new Label();
		k = new UIComboBox();
		l = new Label();
		m = new UIComboBox();
		n = new UIGroupBox();
		p = new UIButton();
		o = new GridEX();
		q = new UIButton();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		((ISupportInitialize)n).BeginInit();
		((Control)n).SuspendLayout();
		((ISupportInitialize)o).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		((Control)this.m_c).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(20, 20);
		((Control)this.m_c).Location = new Point(329, 519);
		((Control)this.m_c).Name = "btnClose";
		((Control)this.m_c).Size = new Size(72, 30);
		((Control)this.m_c).TabIndex = 110;
		((Control)this.m_c).Text = "بستن";
		((Control)this.m_c).Click += f;
		((Control)this.m_d).Anchor = (AnchorStyles)13;
		((Control)this.m_d).Controls.Add((Control)(object)s);
		((Control)this.m_d).Controls.Add((Control)(object)r);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_d).Location = new Point(407, 33);
		((Control)this.m_d).Name = "uiGroupBox1";
		((Control)this.m_d).Size = new Size(349, 528);
		((Control)this.m_d).TabIndex = 130;
		((Control)this.m_d).Text = "جستجو";
		((Control)s).Anchor = (AnchorStyles)9;
		s.BorderStyle = (BorderStyle)1;
		((Control)s).Location = new Point(24, 42);
		((Control)s).Name = "lYear";
		((Control)s).Size = new Size(68, 24);
		((Control)s).TabIndex = 134;
		s.TextAlign = (ContentAlignment)32;
		((Control)r).Anchor = (AnchorStyles)9;
		((Control)r).AutoSize = true;
		((Control)r).Location = new Point(24, 22);
		((Control)r).Name = "label10";
		((Control)r).Size = new Size(66, 13);
		((Control)r).TabIndex = 133;
		((Control)r).Text = "سال تعلیمی";
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_e).Location = new Point(145, 82);
		((Control)this.m_e).Name = "label7";
		((Control)this.m_e).Size = new Size(21, 13);
		((Control)this.m_e).TabIndex = 29;
		((Control)this.m_e).Text = "ولد";
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_f).Location = new Point(307, 81);
		((Control)this.m_f).Name = "label8";
		((Control)this.m_f).Size = new Size(20, 13);
		((Control)this.m_f).TabIndex = 28;
		((Control)this.m_f).Text = "نام";
		g.AllowEdit = (InheritableBoolean)2;
		((Control)g).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		g.DesignTimeLayout = val;
		g.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)g).Font = new Font("Tahoma", 8.25f);
		g.GroupByBoxVisible = false;
		((Control)g).Location = new Point(10, 109);
		((Control)g).Name = "gridStdSearch";
		((ScrollableBase)g).RecordNavigator = true;
		g.RowHeaders = (InheritableBoolean)1;
		((Control)g).Size = new Size(332, 407);
		((Control)g).TabIndex = 5;
		((ScrollableBase)g).VisualStyle = (VisualStyle)2;
		((Control)h).Anchor = (AnchorStyles)9;
		((EditBase)h).AutoScroll = false;
		((EditBase)h).AutoScrollMargin = new Size(0, 0);
		((EditBase)h).AutoScrollMinSize = new Size(0, 0);
		((EditBase)h).AutoScrollPosition = new Point(0, 0);
		((EditBase)h).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)h).Font = new Font("Tahoma", 8.25f);
		((Control)h).Location = new Point(20, 78);
		((Control)h).Name = "txtLName";
		((Control)h).RightToLeft = (RightToLeft)1;
		((Control)h).Size = new Size(119, 21);
		((Control)h).TabIndex = 4;
		((EditBase)h).TextAlignment = (TextAlignment)1;
		((Control)h).KeyUp += c;
		((Control)i).Anchor = (AnchorStyles)9;
		((EditBase)i).AutoScroll = false;
		((EditBase)i).AutoScrollMargin = new Size(0, 0);
		((EditBase)i).AutoScrollMinSize = new Size(0, 0);
		((EditBase)i).AutoScrollPosition = new Point(0, 0);
		((EditBase)i).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)i).Font = new Font("Tahoma", 8.25f);
		((Control)i).Location = new Point(182, 78);
		((Control)i).Name = "txtFName";
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(119, 21);
		((Control)i).TabIndex = 3;
		((EditBase)i).TextAlignment = (TextAlignment)1;
		((Control)i).KeyUp += b;
		((Control)j).Anchor = (AnchorStyles)9;
		((Control)j).AutoSize = true;
		((Control)j).Location = new Point(307, 47);
		((Control)j).Name = "label19";
		((Control)j).Size = new Size(30, 13);
		((Control)j).TabIndex = 25;
		((Control)j).Text = "صنف";
		((Control)k).Anchor = (AnchorStyles)9;
		((UIComboBase)k).ComboStyle = (ComboStyle)1;
		((UIComboBase)k).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Font = new Font("Tahoma", 8.25f);
		((Control)k).Location = new Point(127, 45);
		((Control)k).Name = "dropCls";
		((Control)k).Size = new Size(174, 21);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)k).StringFormat = val2;
		((Control)k).TabIndex = 2;
		k.SelectedIndexChanged += c;
		((Control)l).Anchor = (AnchorStyles)9;
		((Control)l).AutoSize = true;
		((Control)l).Font = new Font("Tahoma", 8.25f);
		((Control)l).Location = new Point(307, 24);
		((Control)l).Name = "label20";
		((Control)l).Size = new Size(22, 13);
		((Control)l).TabIndex = 15;
		((Control)l).Text = "پایه";
		((Control)m).Anchor = (AnchorStyles)9;
		((UIComboBase)m).ComboStyle = (ComboStyle)1;
		((UIComboBase)m).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Font = new Font("Tahoma", 8.25f);
		((Control)m).Location = new Point(127, 18);
		((Control)m).Name = "dropPaye";
		((Control)m).Size = new Size(174, 21);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)m).StringFormat = val3;
		((Control)m).TabIndex = 1;
		m.SelectedIndexChanged += b;
		((Control)n).Anchor = (AnchorStyles)13;
		((Control)n).Controls.Add((Control)(object)p);
		((Control)n).Controls.Add((Control)(object)o);
		((Control)n).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(5, 33);
		((Control)n).Name = "uiGroupBox2";
		((Control)n).Size = new Size(320, 528);
		((Control)n).TabIndex = 131;
		((Control)n).Text = "لیست شاگردان عدم نمایش در دعوت نامه بدهکاران";
		((Control)p).Anchor = (AnchorStyles)6;
		p.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)p).Location = new Point(56, 477);
		((Control)p).Name = "btnDelete";
		((Control)p).Size = new Size(195, 35);
		((Control)p).TabIndex = 133;
		((Control)p).Text = "حذف مورد انتخابی از لیست";
		((Control)p).Click += d;
		o.AllowEdit = (InheritableBoolean)2;
		((Control)o).Anchor = (AnchorStyles)15;
		val4.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		o.DesignTimeLayout = val4;
		o.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)o).Font = new Font("Tahoma", 8.25f);
		o.GroupByBoxVisible = false;
		((Control)o).Location = new Point(7, 34);
		((Control)o).Name = "gSelectStd";
		((ScrollableBase)o).RecordNavigator = true;
		o.RowHeaders = (InheritableBoolean)1;
		((Control)o).Size = new Size(303, 426);
		((Control)o).TabIndex = 5;
		((ScrollableBase)o).VisualStyle = (VisualStyle)2;
		((Control)q).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		q.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		q.ImageHorizontalAlignment = (ImageHorizontalAlignment)0;
		((Control)q).Location = new Point(331, 132);
		((Control)q).Name = "btnNew";
		((Control)q).Size = new Size(70, 118);
		((Control)q).TabIndex = 132;
		((Control)q).Text = "اضافه کردن به لیست(+)";
		((Control)q).Click += e;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(784, 573);
		((Control)this).Controls.Add((Control)(object)q);
		((Control)this).Controls.Add((Control)(object)n);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmSelectStdNotShowBalance";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "تنظیم عدم نمایش شاگرد در دعوت نامه بدهکاران";
		((Form)this).Load += a;
		((Control)this).KeyUp += a;
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((ISupportInitialize)g).EndInit();
		((ISupportInitialize)n).EndInit();
		((Control)n).ResumeLayout(false);
		((ISupportInitialize)o).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
