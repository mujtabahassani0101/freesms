using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;

public class asdx : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private Panel m_d;

	private Label e;

	private UIComboBox f;

	private Label g;

	private UIComboBox h;

	private Label i;

	private UIComboBox j;

	private Panel k;

	private Label l;

	private Button m;

	private Label n;

	private Label o;

	public string p;
protected override void Dispose(bool A_0)
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				case 6:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 2;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 2:
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

	private void d()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdx));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		this.m_b = new Panel();
		k = new Panel();
		this.m_d = new Panel();
		n = new Label();
		o = new Label();
		m = new Button();
		l = new Label();
		e = new Label();
		this.m_c = new UIButton();
		f = new UIComboBox();
		g = new Label();
		h = new UIComboBox();
		i = new Label();
		j = new UIComboBox();
		this.m_b.SuspendLayout();
		k.SuspendLayout();
		this.m_d.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = BorderStyle.FixedSingle;
		this.m_b.Controls.Add(k);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(304, 263);
		this.m_b.TabIndex = 0;
		k.BackColor = SystemColors.ControlText;
		k.Controls.Add(this.m_d);
		k.Dock = DockStyle.Fill;
		k.Location = new Point(0, 0);
		k.Name = "panel3";
		k.Size = new Size(302, 261);
		k.TabIndex = 19;
		this.m_d.BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(e);
		this.m_d.Controls.Add(this.m_c);
		this.m_d.Controls.Add(f);
		this.m_d.Controls.Add(g);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(j);
		this.m_d.Location = new Point(4, 5);
		this.m_d.Name = "panel2";
		this.m_d.Size = new Size(294, 250);
		this.m_d.TabIndex = 18;
		n.BorderStyle = BorderStyle.FixedSingle;
		n.Location = new Point(156, 47);
		n.Name = "lYear";
		n.Size = new Size(68, 24);
		n.TabIndex = 120;
		o.AutoSize = true;
		o.Location = new Point(231, 52);
		o.Name = "label6";
		o.Size = new Size(66, 13);
		o.TabIndex = 119;
		o.Text = "سال تعلیمی";
		m.Location = new Point(27, 162);
		m.Name = "btnStart";
		m.Size = new Size(201, 33);
		m.TabIndex = 39;
		m.Text = "ثبت توضیح";
		m.UseVisualStyleBackColor = true;
		m.Click += a;
		l.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		l.ForeColor = Color.DarkViolet;
		l.Location = new Point(3, 3);
		l.Name = "lheder";
		l.Size = new Size(288, 37);
		l.TabIndex = 38;
		l.Text = "ورود توضیحات زیر اطلاع نامه";
		l.TextAlign = ContentAlignment.MiddleCenter;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		e.AutoSize = true;
		e.Location = new Point(233, 80);
		e.Name = "lExam";
		e.Size = new Size(26, 13);
		e.TabIndex = 37;
		e.Text = "دوره";
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		this.m_c.ImageSize = new Size(40, 40);
		this.m_c.Location = new Point(27, 201);
		this.m_c.Name = "btnClose";
		this.m_c.Size = new Size(201, 35);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "بستن";
		this.m_c.Click += c;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.ComboStyle = ComboStyle.DropDownList;
		f.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		f.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		f.Location = new Point(27, 75);
		f.Name = "dropExam";
		f.Size = new Size(201, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		f.StringFormat = stringFormat;
		f.TabIndex = 36;
		f.SelectedIndexChanged += b;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.AutoSize = true;
		g.Location = new Point(233, 138);
		g.Name = "label19";
		g.Size = new Size(30, 13);
		g.TabIndex = 33;
		g.Text = "صنف";
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.ComboStyle = ComboStyle.DropDownList;
		h.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		h.Location = new Point(27, 133);
		h.Name = "dropCls";
		h.Size = new Size(201, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat2;
		h.TabIndex = 31;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoSize = true;
		i.Location = new Point(233, 109);
		i.Name = "label20";
		i.Size = new Size(22, 13);
		i.TabIndex = 32;
		i.Text = "پایه";
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.ComboStyle = ComboStyle.DropDownList;
		j.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j.Location = new Point(27, 104);
		j.Name = "dropPaye";
		j.Size = new Size(201, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		j.StringFormat = stringFormat3;
		j.TabIndex = 30;
		j.SelectedIndexChanged += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(304, 263);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		Name = "frmCommentKollEntrySelect";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "انتخاب دوره";
		Load += d;
		this.m_b.ResumeLayout(performLayout: false);
		k.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public asdx()
	{
		d();
	}

	private void d(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 10;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 0;
					continue;
				case 2:
					l.Text = "ورود توضیحات زیر اطلاع نامه";
					num = 1;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 7;
				case 1:
					flag = !(p == "6");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 10:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 12;
					continue;
				case 12:
					return;
				case 7:
					n.Text = asdaj.__field_a;
					c();
					b();
					flag = !(p == "5");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 5:
					l.Text = "ورود توضیحات جدول نتایج";
					f.Visible = false;
					e.Visible = false;
					f.SelectedValue = asdcb.a(asdab.e(), CommandType.Text, "select id from tExam where term=3 and xYear=" + n.Text).ToString();
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				case 6:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 4:
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where xYear=" + n.Text + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			f.DataSource = dataSource;
			f.DisplayMember = "Name";
			f.ValueMember = "id";
			bool flag = f.Items.Count <= 0;
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
					return;
				case 1:
					f.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + n.Text + ") order by id");
			j.DataSource = dataSource;
			j.DisplayMember = "Name";
			j.ValueMember = "id";
			bool flag = j.Items.Count <= 0;
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
					if (true)
					{
					}
					j.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			string text = " where xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
			bool flag = j.SelectedIndex < 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto case 5;
				case 3:
					h.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
					h.DataSource = dataSource;
					h.DisplayMember = "Name";
					h.ValueMember = "id";
					flag = h.Items.Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 1:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + n.Text + " and (xPaye = " + j.SelectedValue.ToString() + "))";
					num = 5;
					continue;
				}
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		asda2 asda10 = default;
		while (true)
		{
			bool flag = f.SelectedIndex >= 1;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 9;
						continue;
					}
					asda10 = new asda2();
					asda10.r = h.SelectedValue.ToString();
					asda10.s = j.SelectedValue.ToString();
					asda10.t = f.SelectedValue.ToString();
					asda10.i.Text = j.SelectedItem.Text;
					asda10.k.Text = h.SelectedItem.Text;
					asda10.j.Text = f.SelectedItem.Text;
					flag = !(p == "5");
					num = 1;
					continue;
				case 7:
					asda10.u = "6";
					asda10.v = "-6";
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					asda10.u = "5";
					asda10.v = "-5";
					num = 0;
					continue;
				case 9:
					MessageBox.Show("دوره را انتخاب کنید");
					f.Focus();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				case 3:
					asda10.ShowDialog();
					num = 5;
					continue;
				case 5:
					return;
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(p == "6");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}
}
