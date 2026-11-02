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
			m.Items.Add("کل", "0");
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
					m.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
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
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + s.Text + text);
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
					text = " tYear_Student.xyear=" + s.Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
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
					text = text + " tstudent.LName like '%" + asdaj.b(h.Text) + "%'";
					num = 23;
					continue;
				case 13:
					flag = !(h.Text.Trim() != "");
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
					flag = !(i.Text.Trim() != "");
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
					text = text + " tstudent.FName like '%" + asdaj.b(i.Text) + "%'";
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id,tStudent.NumberAsas,  tStudent.FName, tStudent.LName, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id where tYear_Student.xyear=" + s.Text + " and tYear_Student.notShowBalance=1");
		o.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void e(object A_0, EventArgs A_1)
	{
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
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set notShowBalance=1 where xstudent=" + text + " and xyear=" + s.Text);
					b();
					i.Focus();
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					MessageBox.Show("موردی جهت اضافه شدن وجود ندارد");
					i.Focus();
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
					num2 = ((o.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
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
					flag = MessageBox.Show("آيا میخواهید شاگرد را از این لیست حذف کنید؟", "حذف از لیست", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
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
						asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set notShowBalance=0 where xstudent=" + text + " and xyear=" + s.Text);
						b();
						i.Focus();
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
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Insert;
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
					flag = A_1.KeyCode != Keys.Delete;
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
						BackColor = Color.FromArgb(red, green, blue);
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
					s.Text = asdaj.__field_a;
					e();
					b();
					i.Focus();
					i.Select();
					i.SelectAll();
					num = 1;
					continue;
				case 1:
					if (1 == 0)
					{
					}
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
protected override void Dispose(bool A_0)
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbr));
		GridEXLayout gridEXLayout = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
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
		this.m_d.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		((ISupportInitialize)n).BeginInit();
		n.SuspendLayout();
		((ISupportInitialize)o).BeginInit();
		SuspendLayout();
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(20, 20);
		this.m_c.Location = new Point(329, 519);
		this.m_c.Name = "btnClose";
		this.m_c.Size = new Size(72, 30);
		this.m_c.TabIndex = 110;
		this.m_c.Text = "بستن";
		this.m_c.Click += f;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(s);
		this.m_d.Controls.Add(r);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(g);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(m);
		this.m_d.Font = new Font("Tahoma", 8.25f);
		this.m_d.Location = new Point(407, 33);
		this.m_d.Name = "uiGroupBox1";
		this.m_d.Size = new Size(349, 528);
		this.m_d.TabIndex = 130;
		this.m_d.Text = "جستجو";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		s.Location = new Point(24, 42);
		s.Name = "lYear";
		s.Size = new Size(68, 24);
		s.TabIndex = 134;
		s.TextAlign = ContentAlignment.MiddleCenter;
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.AutoSize = true;
		r.Location = new Point(24, 22);
		r.Name = "label10";
		r.Size = new Size(66, 13);
		r.TabIndex = 133;
		r.Text = "سال تعلیمی";
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoSize = true;
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.Location = new Point(145, 82);
		this.m_e.Name = "label7";
		this.m_e.Size = new Size(21, 13);
		this.m_e.TabIndex = 29;
		this.m_e.Text = "ولد";
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.AutoSize = true;
		this.m_f.Font = new Font("Tahoma", 8.25f);
		this.m_f.Location = new Point(307, 81);
		this.m_f.Name = "label8";
		this.m_f.Size = new Size(20, 13);
		this.m_f.TabIndex = 28;
		this.m_f.Text = "نام";
		g.AllowEdit = InheritableBoolean.False;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		g.DesignTimeLayout = gridEXLayout;
		g.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		g.Font = new Font("Tahoma", 8.25f);
		g.GroupByBoxVisible = false;
		g.Location = new Point(10, 109);
		g.Name = "gridStdSearch";
		g.RecordNavigator = true;
		g.RowHeaders = InheritableBoolean.True;
		g.Size = new Size(332, 407);
		g.TabIndex = 5;
		g.VisualStyle = VisualStyle.Office2003;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.AutoScroll = false;
		h.AutoScrollMargin = new Size(0, 0);
		h.AutoScrollMinSize = new Size(0, 0);
		h.AutoScrollPosition = new Point(0, 0);
		h.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h.Font = new Font("Tahoma", 8.25f);
		h.Location = new Point(20, 78);
		h.Name = "txtLName";
		h.RightToLeft = RightToLeft.Yes;
		h.Size = new Size(119, 21);
		h.TabIndex = 4;
		h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		h.KeyUp += c;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoScroll = false;
		i.AutoScrollMargin = new Size(0, 0);
		i.AutoScrollMinSize = new Size(0, 0);
		i.AutoScrollPosition = new Point(0, 0);
		i.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i.Font = new Font("Tahoma", 8.25f);
		i.Location = new Point(182, 78);
		i.Name = "txtFName";
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(119, 21);
		i.TabIndex = 3;
		i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		i.KeyUp += b;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.AutoSize = true;
		j.Location = new Point(307, 47);
		j.Name = "label19";
		j.Size = new Size(30, 13);
		j.TabIndex = 25;
		j.Text = "صنف";
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		k.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Font = new Font("Tahoma", 8.25f);
		k.Location = new Point(127, 45);
		k.Name = "dropCls";
		k.Size = new Size(174, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		k.StringFormat = stringFormat;
		k.TabIndex = 2;
		k.SelectedIndexChanged += c;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoSize = true;
		l.Font = new Font("Tahoma", 8.25f);
		l.Location = new Point(307, 24);
		l.Name = "label20";
		l.Size = new Size(22, 13);
		l.TabIndex = 15;
		l.Text = "پایه";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		m.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Font = new Font("Tahoma", 8.25f);
		m.Location = new Point(127, 18);
		m.Name = "dropPaye";
		m.Size = new Size(174, 21);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		m.StringFormat = stringFormat2;
		m.TabIndex = 1;
		m.SelectedIndexChanged += b;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		n.Controls.Add(p);
		n.Controls.Add(o);
		n.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		n.Location = new Point(5, 33);
		n.Name = "uiGroupBox2";
		n.Size = new Size(320, 528);
		n.TabIndex = 131;
		n.Text = "لیست شاگردان عدم نمایش در دعوت نامه بدهکاران";
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		p.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		p.Location = new Point(56, 477);
		p.Name = "btnDelete";
		p.Size = new Size(195, 35);
		p.TabIndex = 133;
		p.Text = "حذف مورد انتخابی از لیست";
		p.Click += d;
		o.AllowEdit = InheritableBoolean.False;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		o.DesignTimeLayout = gridEXLayout2;
		o.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		o.Font = new Font("Tahoma", 8.25f);
		o.GroupByBoxVisible = false;
		o.Location = new Point(7, 34);
		o.Name = "gSelectStd";
		o.RecordNavigator = true;
		o.RowHeaders = InheritableBoolean.True;
		o.Size = new Size(303, 426);
		o.TabIndex = 5;
		o.VisualStyle = VisualStyle.Office2003;
		q.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		q.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		q.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Empty;
		q.Location = new Point(331, 132);
		q.Name = "btnNew";
		q.Size = new Size(70, 118);
		q.TabIndex = 132;
		q.Text = "اضافه کردن به لیست(+)";
		q.Click += e;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(784, 573);
		Controls.Add(q);
		Controls.Add(n);
		Controls.Add(this.m_d);
		Controls.Add(this.m_c);
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmSelectStdNotShowBalance";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "تنظیم عدم نمایش شاگرد در دعوت نامه بدهکاران";
		Load += a;
		KeyUp += a;
		((ISupportInitialize)this.m_d).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)g).EndInit();
		((ISupportInitialize)n).EndInit();
		n.ResumeLayout(performLayout: false);
		((ISupportInitialize)o).EndInit();
		ResumeLayout(performLayout: false);
	}
}
