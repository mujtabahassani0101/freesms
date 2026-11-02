using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;

public class asdak : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private Panel m_d;

	private Label m_e;

	private UIComboBox f;

	private Label g;

	private UIComboBox h;

	private Label i;

	private UIComboBox j;

	private Label k;

	private UIComboBox l;

	private Panel m;

	private Label n;

	private Button o;

	private Label p;

	private Label q;
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
						num = 3;
					}
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 3:
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

	private void e()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdak));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		StringFormat stringFormat4 = new StringFormat();
		this.m_b = new Panel();
		m = new Panel();
		this.m_d = new Panel();
		q = new Label();
		p = new Label();
		o = new Button();
		n = new Label();
		this.m_e = new Label();
		this.m_c = new UIButton();
		f = new UIComboBox();
		g = new Label();
		h = new UIComboBox();
		i = new Label();
		j = new UIComboBox();
		k = new Label();
		l = new UIComboBox();
		this.m_b.SuspendLayout();
		m.SuspendLayout();
		this.m_d.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = BorderStyle.FixedSingle;
		this.m_b.Controls.Add(m);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(332, 358);
		this.m_b.TabIndex = 0;
		m.BackColor = SystemColors.ControlText;
		m.Controls.Add(this.m_d);
		m.Dock = DockStyle.Fill;
		m.Location = new Point(0, 0);
		m.Name = "panel3";
		m.Size = new Size(330, 356);
		m.TabIndex = 19;
		this.m_d.BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_c);
		this.m_d.Controls.Add(f);
		this.m_d.Controls.Add(g);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(l);
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_d.Location = new Point(4, 5);
		this.m_d.Name = "panel2";
		this.m_d.Size = new Size(322, 346);
		this.m_d.TabIndex = 18;
		q.BorderStyle = BorderStyle.FixedSingle;
		q.Location = new Point(159, 64);
		q.Name = "lYear";
		q.Size = new Size(68, 24);
		q.TabIndex = 118;
		p.AutoSize = true;
		p.Location = new Point(233, 63);
		p.Name = "label6";
		p.Size = new Size(78, 26);
		p.TabIndex = 116;
		p.Text = "سال تعلیمی";
		o.Location = new Point(27, 250);
		o.Name = "btnStart";
		o.Size = new Size(201, 33);
		o.TabIndex = 5;
		o.Text = "ورود نمرات";
		o.UseVisualStyleBackColor = true;
		o.Click += a;
		n.AutoSize = true;
		n.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.ForeColor = Color.DarkViolet;
		n.Location = new Point(79, 13);
		n.Name = "label4";
		n.Size = new Size(117, 30);
		n.TabIndex = 38;
		n.Text = "ورود نمرات دوره";
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(233, 98);
		this.m_e.Name = "label2";
		this.m_e.Size = new Size(37, 26);
		this.m_e.TabIndex = 37;
		this.m_e.Text = "دوره";
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		this.m_c.ImageSize = new Size(40, 40);
		this.m_c.Location = new Point(27, 294);
		this.m_c.Name = "btnClose";
		this.m_c.Size = new Size(201, 35);
		this.m_c.TabIndex = 6;
		this.m_c.Text = "بستن";
		this.m_c.Click += c;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.ComboStyle = ComboStyle.DropDownList;
		f.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		f.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		f.Location = new Point(27, 96);
		f.Name = "dropExam";
		f.Size = new Size(201, 31);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		f.StringFormat = stringFormat;
		f.TabIndex = 1;
		f.SelectedIndexChanged += b;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.AutoSize = true;
		g.Location = new Point(233, 215);
		g.Name = "label1";
		g.Size = new Size(40, 26);
		g.TabIndex = 35;
		g.Text = "درس";
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.ComboStyle = ComboStyle.DropDownList;
		h.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		h.Location = new Point(27, 211);
		h.Name = "dropBook";
		h.Size = new Size(201, 31);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat2;
		h.TabIndex = 4;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoSize = true;
		i.Location = new Point(233, 175);
		i.Name = "label19";
		i.Size = new Size(41, 26);
		i.TabIndex = 33;
		i.Text = "صنف";
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.ComboStyle = ComboStyle.DropDownList;
		j.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Location = new Point(27, 171);
		j.Name = "dropCls";
		j.Size = new Size(201, 31);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		j.StringFormat = stringFormat3;
		j.TabIndex = 3;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.AutoSize = true;
		k.Location = new Point(233, 135);
		k.Name = "label20";
		k.Size = new Size(33, 26);
		k.TabIndex = 32;
		k.Text = "پایه";
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.ComboStyle = ComboStyle.DropDownList;
		l.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.Location = new Point(27, 134);
		l.Name = "dropPaye";
		l.Size = new Size(201, 31);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		l.StringFormat = stringFormat4;
		l.TabIndex = 2;
		l.SelectedIndexChanged += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(332, 358);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		Name = "frmMarkEntrySelect";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "انتخاب دوره";
		Load += d;
		this.m_b.ResumeLayout(performLayout: false);
		m.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public asdak()
	{
		e();
	}

	private void d(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 2;
					continue;
				case 0:
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
					num = 6;
					continue;
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto IL_012c;
				case 3:
					return;
				case 1:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 5;
					continue;
				case 5:
					return;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_012c;
				case 7:
					{
						num = 0;
						continue;
					}
					IL_012c:
					q.Text = asdaj.__field_a;
					d();
					c();
					b();
					f.Focus();
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where xYear=" + q.Text + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			f.DataSource = dataSource;
			f.DisplayMember = "Name";
			f.ValueMember = "id";
			bool flag = f.Items.Count <= 0;
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
					f.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					if (1 == 0)
					{
					}
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + q.Text + ") order by id");
			l.DataSource = dataSource;
			l.DisplayMember = "Name";
			l.ValueMember = "id";
			bool flag = l.Items.Count <= 0;
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
					if (true)
					{
					}
					l.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
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
			bool flag = l.SelectedIndex < 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 5;
						continue;
					}
					h.DataSource = null;
					num = 3;
					continue;
				case 5:
				{
					if (true)
					{
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tbook where xPaye=" + l.SelectedValue.ToString());
					h.DataSource = dataSource;
					h.DisplayMember = "Name";
					h.ValueMember = "id";
					flag = h.Items.Count <= 0;
					num = 6;
					continue;
				}
				case 1:
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					h.SelectedIndex = 0;
					num = 1;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 3:
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
			string text = " where  xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
			bool flag = l.SelectedIndex < 0;
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
						num = 1;
						continue;
					}
					goto case 3;
				case 5:
					j.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 3:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
					j.DataSource = dataSource;
					j.DisplayMember = "Name";
					j.ValueMember = "id";
					flag = j.Items.Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 1:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + asdaj.__field_a + " and (xPaye = " + l.SelectedValue.ToString() + "))";
					num = 3;
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
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		string ak = default;
		while (true)
		{
			bool flag = f.SelectedIndex >= 1;
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
					ak = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + f.SelectedValue.ToString()).ToString();
					flag = h.SelectedIndex >= 1;
					num = 3;
					continue;
				case 6:
					MessageBox.Show("درس را انتخاب کنید");
					h.Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 3:
				{
					if (!flag)
					{
						if (true)
						{
						}
						num = 6;
						continue;
					}
					asdbd asdbd2 = new asdbd();
					asdbd2.af = j.SelectedValue.ToString();
					asdbd2.ag = l.SelectedValue.ToString();
					asdbd2.ah = f.SelectedValue.ToString();
					asdbd2.ai = h.SelectedValue.ToString();
					asdbd2.v.Text = l.SelectedItem.Text;
					asdbd2.t.Text = j.SelectedItem.Text;
					asdbd2.s.Text = f.SelectedItem.Text;
					asdbd2.u.Text = h.SelectedItem.Text;
					asdbd2.aj = q.Text;
					asdbd2.ak = ak;
					asdbd2.ShowDialog();
					num = 0;
					continue;
				}
				case 2:
					MessageBox.Show("دوره را انتخاب کنید");
					f.Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}
}
