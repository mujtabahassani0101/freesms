using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdag : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private Panel m_f;

	private UIButton m_g;

	private UIButton h;

	private EditBox i;

	private Label j;

	private Panel k;

	private EditBox l;

	private Label m;

	private UIButton n;

	private Label o;

	private EditBox p;

	private Label q;

	private NumericEditBox r;

	private NumericEditBox s;

	private Label t;

	private Label u;

	private UIComboBox v;

	private Panel w;

	private string x;

	private string y = "0";
protected override void Dispose(bool A_0)
	{
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 6;
					}
					else
					{
						num = 5;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdag));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		v = new UIComboBox();
		j = new Label();
		this.m_f = new Panel();
		w = new Panel();
		i = new EditBox();
		u = new Label();
		o = new Label();
		r = new NumericEditBox();
		h = new UIButton();
		s = new NumericEditBox();
		n = new UIButton();
		t = new Label();
		m = new Label();
		p = new EditBox();
		l = new EditBox();
		q = new Label();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_g = new UIButton();
		k = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		this.m_f.SuspendLayout();
		w.SuspendLayout();
		this.m_d.SuspendLayout();
		k.SuspendLayout();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(8, 51);
		this.m_b.Name = "gridEX1";
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(648, 341);
		this.m_b.TabIndex = 5;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_b.SelectionChanged += a;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(v);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_b);
		this.m_c.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(5, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(662, 487);
		this.m_c.TabIndex = 0;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		v.DropListFont = new Font("B Titr", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Font = new Font("B Titr", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "چهار و نیم ماهه";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "سالانه";
		uIComboBoxItem2.Value = "3";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "نمرات ماهانه";
		uIComboBoxItem3.Value = "0";
		v.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3 });
		v.Location = new Point(119, 5);
		v.Name = "dropTerm";
		v.Size = new Size(287, 41);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		v.StringFormat = stringFormat;
		v.TabIndex = 53;
		v.SelectedIndexChanged += b;
		j.AutoSize = true;
		j.Font = new Font("B Titr", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.ForeColor = Color.Maroon;
		j.Location = new Point(408, 0);
		j.Name = "label4";
		j.Size = new Size(246, 42);
		j.TabIndex = 17;
		j.Text = "تنظیمات درجه بندی نمرات";
		this.m_f.BackColor = SystemColors.ControlText;
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(w);
		this.m_f.Location = new Point(16, 97);
		this.m_f.Name = "pcls";
		this.m_f.Size = new Size(635, 274);
		this.m_f.TabIndex = 10;
		this.m_f.Visible = false;
		w.BackColor = SystemColors.GradientInactiveCaption;
		w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		w.Controls.Add(i);
		w.Controls.Add(u);
		w.Controls.Add(o);
		w.Controls.Add(r);
		w.Controls.Add(h);
		w.Controls.Add(s);
		w.Controls.Add(n);
		w.Controls.Add(t);
		w.Controls.Add(m);
		w.Controls.Add(p);
		w.Controls.Add(l);
		w.Controls.Add(q);
		w.Location = new Point(5, 5);
		w.Name = "panel3";
		w.Size = new Size(623, 261);
		w.TabIndex = 41;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		i.AutoScroll = false;
		i.AutoScrollMargin = new Size(0, 0);
		i.AutoScrollMinSize = new Size(0, 0);
		i.AutoScrollPosition = new Point(0, 0);
		i.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(294, 5);
		i.MaxLength = 50;
		i.Name = "txttosif";
		i.Size = new Size(246, 23);
		i.TabIndex = 0;
		i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		i.Visible = false;
		u.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		u.AutoSize = true;
		u.Enabled = false;
		u.Location = new Point(364, 75);
		u.Name = "label6";
		u.Size = new Size(62, 16);
		u.TabIndex = 40;
		u.Text = "تا کمتر از";
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		o.AutoSize = true;
		o.Location = new Point(546, 8);
		o.Name = "label1";
		o.Size = new Size(25, 16);
		o.TabIndex = 1;
		o.Text = "نام";
		o.Visible = false;
		r.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		r.AutoScroll = false;
		r.AutoScrollMargin = new Size(0, 0);
		r.AutoScrollMinSize = new Size(0, 0);
		r.AutoScrollPosition = new Point(0, 0);
		r.Location = new Point(294, 72);
		r.Name = "txttoMark";
		r.Size = new Size(61, 23);
		r.TabIndex = 39;
		r.Text = "100";
		r.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		r.Value = (short)100;
		r.ValueType = NumericEditValueType.Int16;
		h.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		h.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		h.Location = new Point(113, 220);
		h.Name = "btnAcp";
		h.Size = new Size(103, 35);
		h.TabIndex = 2;
		h.Text = "تایید";
		h.Click += e;
		s.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		s.AutoScroll = false;
		s.AutoScrollMargin = new Size(0, 0);
		s.AutoScrollMinSize = new Size(0, 0);
		s.AutoScrollPosition = new Point(0, 0);
		s.Enabled = false;
		s.Location = new Point(474, 72);
		s.Name = "txtfromMark";
		s.Size = new Size(66, 23);
		s.TabIndex = 38;
		s.Text = "0";
		s.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		s.Value = (short)0;
		s.ValueType = NumericEditValueType.Int16;
		n.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		n.Location = new Point(18, 220);
		n.Name = "btnCancel";
		n.Size = new Size(89, 35);
		n.TabIndex = 3;
		n.Text = "انصراف";
		n.Click += c;
		t.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		t.AutoSize = true;
		t.Enabled = false;
		t.Location = new Point(546, 75);
		t.Name = "label5";
		t.Size = new Size(54, 16);
		t.TabIndex = 37;
		t.Text = "از نمره ";
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.Location = new Point(546, 108);
		m.Name = "label2";
		m.Size = new Size(62, 44);
		m.TabIndex = 17;
		m.Text = " متن در اطلاع نامه";
		m.TextAlign = ContentAlignment.MiddleRight;
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Location = new Point(474, 38);
		p.MaxLength = 10;
		p.Name = "txttosifM";
		p.Size = new Size(66, 23);
		p.TabIndex = 19;
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		l.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new Point(0, 0);
		l.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Location = new Point(11, 109);
		l.Multiline = true;
		l.Name = "txtComment";
		l.Size = new Size(529, 107);
		l.TabIndex = 1;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		q.AutoSize = true;
		q.Location = new Point(546, 42);
		q.Name = "label3";
		q.Size = new Size(40, 16);
		q.TabIndex = 18;
		q.Text = "درجه";
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Location = new Point(1, 404);
		this.m_d.Name = "p_new";
		this.m_d.Size = new Size(655, 45);
		this.m_d.TabIndex = 9;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_e.Location = new Point(515, 3);
		this.m_e.Name = "btnEdit";
		this.m_e.Size = new Size(127, 36);
		this.m_e.TabIndex = 1;
		this.m_e.Text = "اصلاح";
		this.m_e.Click += f;
		this.m_g.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_g.ImageSize = new Size(40, 40);
		this.m_g.Location = new Point(2, 4);
		this.m_g.Name = "btnClose";
		this.m_g.Size = new Size(228, 36);
		this.m_g.TabIndex = 15;
		this.m_g.Text = "خروج";
		this.m_g.Click += d;
		k.BackColor = SystemColors.ControlText;
		k.Controls.Add(this.m_c);
		k.Dock = DockStyle.Fill;
		k.Location = new Point(0, 0);
		k.Name = "panel2";
		k.Size = new Size(672, 500);
		k.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(672, 500);
		Controls.Add(k);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmTosifConfig";
		RightToLeft = RightToLeft.Yes;
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست تخفیف ها";
		Load += g;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		w.ResumeLayout(performLayout: false);
		w.PerformLayout();
		this.m_d.ResumeLayout(performLayout: false);
		k.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdag()
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto IL_0131;
				case 5:
					return;
				case 1:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 0;
					continue;
				case 0:
					return;
				case 4:
					if (1 == 0)
					{
					}
					goto IL_0131;
				case 2:
					{
						num = 3;
						continue;
					}
					IL_0131:
					v.SelectedIndex = 0;
					a();
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tTosif where term=" + v.SelectedValue.ToString() + " order by lev desc");
		this.m_b.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_b.RowCount <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 3:
					r.Enabled = false;
					num = 0;
					continue;
				case 6:
					x = "update";
					this.m_f.Visible = true;
					i.Text = this.m_b.SelectedItems[0].GetRow().Cells["tosif"].Value.ToString();
					p.Text = this.m_b.SelectedItems[0].GetRow().Cells["tosifM"].Value.ToString();
					s.Text = this.m_b.SelectedItems[0].GetRow().Cells["fromMark"].Value.ToString();
					r.Text = this.m_b.SelectedItems[0].GetRow().Cells["toMark"].Value.ToString();
					l.Text = this.m_b.SelectedItems[0].GetRow().Cells["comment"].Value.ToString();
					y = this.m_b.SelectedItems[0].GetRow().Cells["lev"].Value.ToString();
					flag = !(y == "1");
					if (true)
					{
					}
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						r.Enabled = true;
						num = 4;
					}
					else
					{
						num = 3;
					}
					continue;
				case 0:
				case 4:
					i.Select();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string text = "0";
			bool flag = !(i.Text.Trim() == "");
			int num = 20;
			while (true)
			{
				int num5;
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 15;
						continue;
					}
					flag = !(p.Text.Trim() == "");
					num = 25;
					continue;
				case 21:
					MessageBox.Show("نمره را وارد کنید");
					s.Focus();
					num = 23;
					continue;
				case 23:
					return;
				case 14:
				{
					int num4 = int.Parse(y);
					num4--;
					asdcb.d(asdab.e(), CommandType.Text, " update tTosif set fromMark=" + r.Text + " where term=" + v.SelectedValue.ToString() + " and lev=" + num4);
					num = 6;
					continue;
				}
				case 5:
					num = 16;
					continue;
				case 16:
					num5 = ((!(r.Text.Trim() == "0")) ? 1 : 0);
					goto IL_0384;
				case 19:
					num = ((r.Text.Trim() == "") ? 8 : 5);
					continue;
				case 8:
					num5 = 0;
					goto IL_0384;
				case 15:
					if (true)
					{
					}
					MessageBox.Show("نام را وارد کنید");
					i.Focus();
					num = 17;
					continue;
				case 17:
					return;
				case 26:
					MessageBox.Show("نمره را وارد کنید");
					r.Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 9:
					flag = !(y != "1");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 6;
				case 12:
					this.m_f.Visible = false;
					num = 18;
					continue;
				case 2:
					MessageBox.Show("عنوان درجه را وارد کنید");
					i.Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 25:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(s.Text.Trim() == "");
					num = 1;
					continue;
				case 18:
					a();
					num = 24;
					continue;
				case 24:
					return;
				case 11:
					if (flag)
					{
						try
						{
							int num6 = int.Parse(s.Text);
						}
						catch
						{
							MessageBox.Show("نمره اشتباه است فقط عدد وارد کنید");
							s.Focus();
							return;
						}
						num = 3;
					}
					else
					{
						num = 26;
					}
					continue;
				case 1:
					num = ((!flag) ? 21 : 19);
					continue;
				case 22:
				{
					text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					int num3 = asdcb.d(asdab.e(), CommandType.Text, " update tTosif set tosif=N'" + asdaj.b(i.Text) + "',tosifM=N'" + p.Text + "',comment=N'" + l.Text + "',toMark=" + r.Text + " where id=" + text);
					flag = num3 <= 0;
					num = 10;
					continue;
				}
				case 10:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 12;
				case 3:
					try
					{
						int num2 = int.Parse(r.Text);
					}
					catch
					{
						MessageBox.Show("نمره اشتباه است فقط عدد وارد کنید");
						r.Focus();
						return;
					}
					flag = !(x == "update");
					num = 0;
					continue;
				case 6:
					num = 12;
					continue;
				case 0:
					{
						if (!flag)
						{
							num = 22;
							continue;
						}
						goto case 18;
					}
					IL_0384:
					flag = (byte)num5 != 0;
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
		this.m_f.Visible = false;
	}

	private void a(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}
}
