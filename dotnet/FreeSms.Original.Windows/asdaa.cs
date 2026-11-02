using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdaa : Form
{
	private string m_a;

	private IContainer m_b = null;

	private GridEX m_c;

	private Panel m_d;

	private Panel m_e;

	private UIButton m_f;

	private UIButton g;

	private Panel h;

	private UIButton i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private Panel m;

	private Label n;

	private UIComboBox o;

	private PrintPreviewDialog p;

	private GridEXPrintDocument q;

	private Label r;

	private Panel s;

	private EditBox t;

	private Label u;

	private EditBox v;

	private Label w;

	private Label x;

	private EditBox y;

	private Label z;

	private Label aa;

	public asdaa()
	{
		a();
	}

	private void f(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 5;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 7;
					continue;
				case 0:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 4:
					x.Text = asdaj.__field_a;
					b();
					c();
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 6;
					continue;
				case 6:
					return;
				case 1:
					num = 0;
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tmaghta where id not in(select xmaghta from tYearMaghtaCountDay where xYear=" + asdaj.__field_a + ") order by id");
			o.DataSource = dataSource;
			o.DisplayMember = "Name";
			o.ValueMember = "id";
			bool flag = o.Items.Count != 0;
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
					s.Visible = false;
					this.m_f.Visible = false;
					g.Left = 365;
					if (true)
					{
					}
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
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tYearMaghtaCountDay.id, tMaghta.name AS maghta, tYearMaghtaCountDay.Term1, tYearMaghtaCountDay.Term2, \r\n                      tYearMaghtaCountDay.Term1 + tYearMaghtaCountDay.Term2 AS sumyear\r\n                        FROM         tYearMaghtaCountDay INNER JOIN\r\n                                              tMaghta ON tYearMaghtaCountDay.xMaghta = tMaghta.id\r\n                        WHERE         tYearMaghtaCountDay.xYear = " + x.Text);
		this.m_c.DataSource = dataSource;
	}

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a = "insert";
		o.Visible = true;
		s.Visible = true;
		v.Text = "";
		t.Text = "";
		y.Text = "";
		o.Focus();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_c.RowCount <= 0;
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
					this.m_a = "update";
					s.Visible = true;
					v.Text = this.m_c.SelectedItems[0].GetRow().Cells["Term1"].Value.ToString();
					t.Text = this.m_c.SelectedItems[0].GetRow().Cells["Term2"].Value.ToString();
					aa.Text = this.m_c.SelectedItems[0].GetRow().Cells["maghta"].Value.ToString();
					o.Visible = false;
					y.Text = this.m_c.SelectedItems[0].GetRow().Cells["sumyear"].Value.ToString();
					v.Select();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		string a_ = default;
		string a_2 = default;
		while (true)
		{
			bool flag = s.Visible;
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = (flag ? 22 : 10);
					continue;
				case 1:
					num2 = 1;
					goto IL_027d;
				case 18:
					MessageBox.Show("تعداد روز های سالانه را وارد کنید");
					t.Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 14:
					MessageBox.Show("مقطع را انتخاب کنید");
					o.Focus();
					num = 20;
					continue;
				case 20:
					return;
				case 23:
				case 24:
				{
					if (true)
					{
					}
					SqlParameter[] a_3 = new SqlParameter[5]
					{
						asdcb.a("@id", SqlDbType.Int, a_),
						asdcb.a("@xYear", SqlDbType.Int, x.Text),
						asdcb.a("@xmaghta", SqlDbType.Int, a_2),
						asdcb.a("@Term1", SqlDbType.Int, v.Text),
						asdcb.a("@Term2", SqlDbType.Int, t.Text)
					};
					int num5 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tYearMaghtaCountDay_insertUpdate", a_3);
					flag = num5 <= 0;
					num = 17;
					continue;
				}
				case 17:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 16:
					a_ = this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 23;
					continue;
				case 2:
					if (!flag)
					{
						num = 14;
						continue;
					}
					flag = !(v.Text.Trim() == "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 19;
						continue;
					}
					try
					{
						int num4 = int.Parse(v.Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای تعداد روز های چهار و نیم ماهه فقط عدد وارد کنید");
						v.Focus();
						return;
					}
					flag = !(t.Text.Trim() == "");
					num = 7;
					continue;
				case 15:
					if (flag)
					{
						a_2 = o.SelectedValue.ToString();
						num = 24;
					}
					else
					{
						num = 16;
					}
					continue;
				case 7:
					if (flag)
					{
						try
						{
							int num3 = int.Parse(t.Text.Trim());
						}
						catch
						{
							MessageBox.Show("برای تعداد روز های سالانه فقط عدد وارد کنید");
							t.Focus();
							return;
						}
						a_ = "0";
						a_2 = "0";
						flag = !(this.m_a == "update");
						num = 15;
					}
					else
					{
						num = 18;
					}
					continue;
				case 3:
					s.Visible = false;
					num = 8;
					continue;
				case 19:
					MessageBox.Show("تعداد روز های چهار و نیم ماهه را وارد کنید");
					v.Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 0:
					flag = !(this.m_a == "update");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 8;
				case 12:
					num = 25;
					continue;
				case 25:
					num2 = ((o.SelectedIndex >= 0) ? 1 : 0);
					goto IL_027d;
				case 8:
					b();
					MessageBox.Show("ثبت شد");
					c();
					v.Text = "";
					t.Text = "";
					o.Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 10:
					num = 6;
					continue;
				case 6:
					return;
				case 22:
					{
						num = ((!(this.m_a == "insert")) ? 1 : 12);
						continue;
					}
					IL_027d:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		s.Visible = false;
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
					num = ((!A_0) ? 1 : 2);
					continue;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 6:
					this.m_b.Dispose();
					num = 3;
					continue;
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_0074;
				case 3:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
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

	private void a()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdaa));
		StringFormat stringFormat = new StringFormat();
		this.m_c = new GridEX();
		this.m_d = new Panel();
		x = new Label();
		w = new Label();
		s = new Panel();
		h = new Panel();
		aa = new Label();
		z = new Label();
		y = new EditBox();
		t = new EditBox();
		u = new Label();
		v = new EditBox();
		r = new Label();
		n = new Label();
		o = new UIComboBox();
		k = new UIButton();
		j = new UIButton();
		l = new Label();
		this.m_e = new Panel();
		i = new UIButton();
		this.m_f = new UIButton();
		g = new UIButton();
		m = new Panel();
		p = new PrintPreviewDialog();
		q = new GridEXPrintDocument();
		((ISupportInitialize)this.m_c).BeginInit();
		this.m_d.SuspendLayout();
		s.SuspendLayout();
		h.SuspendLayout();
		this.m_e.SuspendLayout();
		m.SuspendLayout();
		SuspendLayout();
		this.m_c.AllowEdit = InheritableBoolean.False;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = gridEXLayout;
		this.m_c.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_c.Font = new Font("B Nazanin", 12f);
		this.m_c.GroupByBoxVisible = false;
		this.m_c.Location = new Point(8, 90);
		this.m_c.Name = "gridEX1";
		this.m_c.RowHeaders = InheritableBoolean.True;
		this.m_c.Size = new Size(458, 202);
		this.m_c.TabIndex = 5;
		this.m_c.VisualStyle = VisualStyle.Office2003;
		this.m_d.BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_d.Controls.Add(x);
		this.m_d.Controls.Add(w);
		this.m_d.Controls.Add(s);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_c);
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(5, 6);
		this.m_d.Name = "panel1";
		this.m_d.Size = new Size(479, 369);
		this.m_d.TabIndex = 0;
		x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		x.Location = new Point(34, 31);
		x.Name = "lYear";
		x.Size = new Size(68, 24);
		x.TabIndex = 120;
		w.AutoSize = true;
		w.Location = new Point(107, 29);
		w.Name = "label7";
		w.Size = new Size(78, 26);
		w.TabIndex = 99;
		w.Text = "سال تعلیمی";
		s.BackColor = SystemColors.ControlText;
		s.Controls.Add(h);
		s.Location = new Point(58, 63);
		s.Name = "pcls";
		s.Size = new Size(320, 237);
		s.TabIndex = 97;
		s.Visible = false;
		h.BackColor = SystemColors.GradientInactiveCaption;
		h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		h.Controls.Add(aa);
		h.Controls.Add(z);
		h.Controls.Add(y);
		h.Controls.Add(t);
		h.Controls.Add(u);
		h.Controls.Add(v);
		h.Controls.Add(r);
		h.Controls.Add(n);
		h.Controls.Add(o);
		h.Controls.Add(k);
		h.Controls.Add(j);
		h.Location = new Point(3, 3);
		h.Name = "pcls00";
		h.Size = new Size(314, 231);
		h.TabIndex = 10;
		aa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		aa.Location = new Point(23, 20);
		aa.Name = "lMaghta";
		aa.Size = new Size(182, 32);
		aa.TabIndex = 121;
		aa.Visible = false;
		z.AutoSize = true;
		z.Location = new Point(173, 138);
		z.Name = "label1";
		z.Size = new Size(47, 26);
		z.TabIndex = 95;
		z.Text = "سالانه";
		y.AutoScroll = false;
		y.AutoScrollMargin = new Size(0, 0);
		y.AutoScrollMinSize = new Size(0, 0);
		y.AutoScrollPosition = new Point(0, 0);
		y.Enabled = false;
		y.Location = new Point(85, 135);
		y.Name = "txtSumYear";
		y.Size = new Size(83, 33);
		y.TabIndex = 94;
		y.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.Location = new Point(85, 96);
		t.Name = "txtTerm2";
		t.Size = new Size(83, 33);
		t.TabIndex = 4;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.AutoSize = true;
		u.Location = new Point(172, 100);
		u.Name = "label5";
		u.Size = new Size(125, 26);
		u.TabIndex = 93;
		u.Text = " چهار و نیم ماهه دوم";
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.Location = new Point(85, 59);
		v.Name = "txtTerm1";
		v.Size = new Size(83, 33);
		v.TabIndex = 3;
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		r.AutoSize = true;
		r.Location = new Point(172, 63);
		r.Name = "label3";
		r.Size = new Size(98, 26);
		r.TabIndex = 41;
		r.Text = "چهار و نیم ماهه";
		n.AutoSize = true;
		n.Location = new Point(212, 23);
		n.Name = "label20";
		n.Size = new Size(43, 26);
		n.TabIndex = 37;
		n.Text = "مقطع";
		o.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		o.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(22, 20);
		o.Name = "dropMaghta";
		o.Size = new Size(184, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		o.StringFormat = stringFormat;
		o.TabIndex = 0;
		k.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		k.Location = new Point(23, 188);
		k.Name = "btnCancel";
		k.Size = new Size(90, 32);
		k.TabIndex = 7;
		k.Text = "انصراف";
		k.Click += a;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		j.Location = new Point(131, 188);
		j.Name = "btnAcp";
		j.Size = new Size(96, 32);
		j.TabIndex = 6;
		j.Text = "تایید";
		j.Click += c;
		l.AutoSize = true;
		l.Font = new Font("B Nazanin", 24f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.ForeColor = Color.DarkViolet;
		l.Location = new Point(254, 14);
		l.Name = "label4";
		l.Size = new Size(198, 51);
		l.TabIndex = 17;
		l.Text = "ایام سال تعلیمی";
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_e.Controls.Add(i);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Controls.Add(g);
		this.m_e.Location = new Point(6, 301);
		this.m_e.Name = "p_new";
		this.m_e.Size = new Size(468, 56);
		this.m_e.TabIndex = 9;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.DialogResult = DialogResult.Cancel;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		i.Location = new Point(7, 7);
		i.Name = "btnClose";
		i.Size = new Size(98, 43);
		i.TabIndex = 15;
		i.Text = "خروج";
		i.Click += b;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_f.Location = new Point(365, 6);
		this.m_f.Name = "btnNew";
		this.m_f.Size = new Size(90, 42);
		this.m_f.TabIndex = 0;
		this.m_f.Text = "جدید";
		this.m_f.Click += e;
		g.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		g.Location = new Point(262, 6);
		g.Name = "btnEdit";
		g.Size = new Size(90, 42);
		g.TabIndex = 1;
		g.Text = "اصلاح";
		g.Click += d;
		m.BackColor = SystemColors.ControlText;
		m.Controls.Add(this.m_d);
		m.Dock = DockStyle.Fill;
		m.Location = new Point(0, 0);
		m.Name = "panel2";
		m.Size = new Size(488, 380);
		m.TabIndex = 1;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.ClientSize = new Size(400, 300);
		p.Document = q;
		p.Enabled = true;
		p.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		p.Name = "printPreviewDialog1";
		p.Visible = false;
		q.PageFooterLeft = "3";
		q.PageFooterRight = "2";
		q.PageHeaderCenter = "1";
		q.PageHeaderLeft = "4";
		q.PageHeaderRight = "5";
		AcceptButton = j;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		CancelButton = i;
		ClientSize = new Size(488, 380);
		Controls.Add(m);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmYearMaghtaCountDay";
		RightToLeft = RightToLeft.Yes;
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "مدیریت صنوف";
		Load += f;
		((ISupportInitialize)this.m_c).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		s.ResumeLayout(performLayout: false);
		h.ResumeLayout(performLayout: false);
		h.PerformLayout();
		this.m_e.ResumeLayout(performLayout: false);
		m.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
