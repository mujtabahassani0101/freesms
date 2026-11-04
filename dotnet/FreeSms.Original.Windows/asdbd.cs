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
using school_Af.Properties;

public class asdbd : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private Label m_e;

	private GroupBox m_f;

	private TextBox g;

	private Label h;

	private Button i;

	private Label j;

	private UIComboBox k;

	private CheckBox l;

	private Button m;

	private UIGroupBox n;

	private Label o;

	private NumericEditBox p;

	private NumericEditBox q;

	private Label r;

	public Label s;

	public Label t;

	public Label u;

	public Label v;

	private Label w;

	private Label x;

	private Label y;

	private Label z;

	private UIButton aa;

	private GridEX ab;

	private Label ac;

	private Label ad;

	private Label ae;

	public string af;

	public string ag;

	public string ah;

	public string ai;

	public string aj;

	public string ak;

	private SqlConnection al = new SqlConnection(asdab.e());

	private bool am = true;

	private int an = -1;
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
						num = 1;
					}
					else
					{
						num = 0;
					}
					continue;
				case 1:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 3;
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
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbd));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		ac = new Label();
		o = new Label();
		this.m_e = new Label();
		p = new NumericEditBox();
		this.m_f = new GroupBox();
		g = new TextBox();
		h = new Label();
		i = new Button();
		q = new NumericEditBox();
		r = new Label();
		l = new CheckBox();
		j = new Label();
		m = new Button();
		k = new UIComboBox();
		n = new UIGroupBox();
		ad = new Label();
		ae = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new UIButton();
		ab = new GridEX();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		this.m_f.SuspendLayout();
		((ISupportInitialize)n).BeginInit();
		n.SuspendLayout();
		((ISupportInitialize)ab).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(800, 600);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(798, 598);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(ac);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(r);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(aa);
		this.m_d.Controls.Add(ab);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(792, 592);
		this.m_d.TabIndex = 0;
		ac.Enabled = false;
		ac.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ac.ForeColor = Color.Red;
		ac.Location = new Point(546, 339);
		ac.Name = "lMark100";
		ac.Size = new Size(213, 68);
		ac.TabIndex = 51;
		ac.Text = "فقط شاگردانی که تیک مربوط به ورود نمره سالانه از 100 دارند در این بخش نمایش داده می شود";
		ac.Visible = false;
		o.AutoSize = true;
		o.Enabled = false;
		o.Location = new Point(685, 499);
		o.Name = "label4";
		o.Size = new Size(27, 26);
		o.TabIndex = 37;
		o.Text = "تا :";
		this.m_e.AutoSize = true;
		this.m_e.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.ForeColor = Color.DarkViolet;
		this.m_e.Location = new Point(575, 6);
		this.m_e.Name = "label7";
		this.m_e.Size = new Size(134, 33);
		this.m_e.TabIndex = 50;
		this.m_e.Text = "ورود نمرات دوره";
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.Enabled = false;
		p.Location = new Point(627, 496);
		p.Name = "txtMaxMark";
		p.Size = new Size(52, 33);
		p.TabIndex = 36;
		p.Text = "100";
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		p.Value = (short)100;
		p.ValueType = NumericEditValueType.Int16;
		this.m_f.Controls.Add(g);
		this.m_f.Controls.Add(h);
		this.m_f.Controls.Add(i);
		this.m_f.Font = new Font("B Nazanin", 10f);
		this.m_f.Location = new Point(510, 268);
		this.m_f.Name = "groupBox1";
		this.m_f.Size = new Size(262, 54);
		this.m_f.TabIndex = 49;
		this.m_f.TabStop = false;
		this.m_f.Text = "وارد کردن نمرات یکسان";
		g.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Location = new Point(110, 23);
		g.MaxLength = 3;
		g.Name = "txtmarkAll";
		g.Size = new Size(64, 23);
		g.TabIndex = 43;
		h.AutoSize = true;
		h.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		h.Location = new Point(178, 21);
		h.Name = "label6";
		h.Size = new Size(41, 26);
		h.TabIndex = 42;
		h.Text = "نمره :";
		i.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		i.Location = new Point(24, 19);
		i.Name = "btnMarkAll";
		i.Size = new Size(72, 30);
		i.TabIndex = 41;
		i.Text = "ثبت";
		i.UseVisualStyleBackColor = true;
		i.Click += b;
		q.AutoScroll = false;
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		q.AutoScrollPosition = new Point(0, 0);
		q.Enabled = false;
		q.Location = new Point(627, 457);
		q.Name = "txtMinMark";
		q.Size = new Size(52, 33);
		q.TabIndex = 35;
		q.Text = "0";
		q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.Value = (short)0;
		q.ValueType = NumericEditValueType.Int16;
		r.AutoSize = true;
		r.Enabled = false;
		r.Location = new Point(685, 460);
		r.Name = "label3";
		r.Size = new Size(76, 26);
		r.TabIndex = 34;
		r.Text = "رنج نمره از :";
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoSize = true;
		l.Location = new Point(540, 410);
		l.Name = "checkBox1";
		l.Size = new Size(225, 30);
		l.TabIndex = 48;
		l.Text = "فعال کردن ستون ترتیب برای اصلاح";
		l.UseVisualStyleBackColor = true;
		l.Visible = false;
		l.CheckedChanged += c;
		j.AutoSize = true;
		j.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		j.Location = new Point(719, 552);
		j.Name = "label5";
		j.Size = new Size(51, 26);
		j.TabIndex = 38;
		j.Text = "ستون :";
		j.Visible = false;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		m.Image = Resources._4160;
		m.ImageAlign = ContentAlignment.MiddleRight;
		m.Location = new Point(290, 551);
		m.Name = "btnSaveMark";
		m.Size = new Size(197, 35);
		m.TabIndex = 47;
		m.Text = "ثبت نمرات(F5)";
		m.UseVisualStyleBackColor = true;
		m.Click += d;
		k.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		k.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "نمره 1";
		uIComboBoxItem.Value = "m1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "نمره 2";
		uIComboBoxItem2.Value = "m2";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "نمره 3";
		uIComboBoxItem3.Value = "m3";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "نمره 4";
		uIComboBoxItem4.Value = "m4";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "نمره 5";
		uIComboBoxItem5.Value = "m5";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "نمره 6";
		uIComboBoxItem6.Value = "m6";
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "نمره 7";
		uIComboBoxItem7.Value = "m7";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "نمره 8";
		uIComboBoxItem8.Value = "m8";
		k.Items.AddRange(new UIComboBoxItem[8] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6, uIComboBoxItem7, uIComboBoxItem8 });
		k.Location = new Point(664, 552);
		k.Name = "dropMarkAll";
		k.Size = new Size(49, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		k.StringFormat = stringFormat;
		k.TabIndex = 40;
		k.Visible = false;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		n.Controls.Add(ad);
		n.Controls.Add(ae);
		n.Controls.Add(s);
		n.Controls.Add(t);
		n.Controls.Add(u);
		n.Controls.Add(v);
		n.Controls.Add(w);
		n.Controls.Add(x);
		n.Controls.Add(y);
		n.Controls.Add(z);
		n.Location = new Point(493, 39);
		n.Name = "uiGroupBox1";
		n.Size = new Size(288, 223);
		n.TabIndex = 46;
		ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ad.Location = new Point(139, 21);
		ad.Name = "lYear";
		ad.Size = new Size(55, 24);
		ad.TabIndex = 119;
		ad.TextAlign = ContentAlignment.MiddleCenter;
		ae.AutoSize = true;
		ae.Location = new Point(198, 20);
		ae.Name = "label8";
		ae.Size = new Size(78, 26);
		ae.TabIndex = 118;
		ae.Text = "سال تعلیمی";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		s.Location = new Point(11, 135);
		s.Name = "lExam";
		s.Size = new Size(183, 33);
		s.TabIndex = 33;
		s.TextAlign = ContentAlignment.MiddleCenter;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		t.Location = new Point(11, 96);
		t.Name = "lClass";
		t.Size = new Size(183, 33);
		t.TabIndex = 32;
		t.TextAlign = ContentAlignment.MiddleCenter;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		u.Location = new Point(11, 179);
		u.Name = "lBook";
		u.Size = new Size(183, 33);
		u.TabIndex = 31;
		u.TextAlign = ContentAlignment.MiddleCenter;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		v.Location = new Point(11, 56);
		v.Name = "lPaye";
		v.Size = new Size(183, 33);
		v.TabIndex = 30;
		v.TextAlign = ContentAlignment.MiddleCenter;
		w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		w.AutoSize = true;
		w.Location = new Point(200, 139);
		w.Name = "label2";
		w.Size = new Size(43, 26);
		w.TabIndex = 29;
		w.Text = "دوره :";
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.AutoSize = true;
		x.Location = new Point(198, 182);
		x.Name = "label1";
		x.Size = new Size(46, 26);
		x.TabIndex = 27;
		x.Text = "درس :";
		y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		y.AutoSize = true;
		y.Location = new Point(200, 100);
		y.Name = "label19";
		y.Size = new Size(47, 26);
		y.TabIndex = 25;
		y.Text = "صنف :";
		z.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		z.AutoSize = true;
		z.Location = new Point(198, 59);
		z.Name = "label20";
		z.Size = new Size(79, 26);
		z.TabIndex = 15;
		z.Text = "صنف اصلی :";
		z.TextAlign = ContentAlignment.MiddleLeft;
		aa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		aa.DialogResult = DialogResult.Cancel;
		aa.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		aa.ImageSize = new Size(40, 40);
		aa.Location = new Point(11, 552);
		aa.Name = "btnClose";
		aa.Size = new Size(189, 35);
		aa.TabIndex = 44;
		aa.Text = "بستن";
		aa.Click += e;
		ab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		ab.DesignTimeLayout = gridEXLayout;
		ab.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		ab.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		ab.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.GroupByBoxVisible = false;
		ab.Location = new Point(8, 8);
		ab.Name = "gridEX1";
		ab.RecordNavigator = true;
		ab.RowHeaders = InheritableBoolean.True;
		ab.SelectedFormatStyle.BackColor = Color.Empty;
		ab.SelectedFormatStyle.ForeColor = Color.Empty;
		ab.Size = new Size(479, 537);
		ab.TabIndex = 45;
		ab.VisualStyle = VisualStyle.Office2003;
		ab.SelectionChanged += a;
		ab.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmMarkEntry";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += f;
		KeyUp += a;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		((ISupportInitialize)n).EndInit();
		n.ResumeLayout(performLayout: false);
		n.PerformLayout();
		((ISupportInitialize)ab).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdbd()
	{
		b();
	}

	private void f(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 14;
			while (true)
			{
				switch (num)
				{
				case 14:
					if (!flag)
					{
						num = 12;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 2;
					continue;
				case 8:
					ab.Tables[0].Columns["countAb"].Visible = false;
					ac.Visible = true;
					p.Text = "100";
					num = 0;
					continue;
				case 11:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(ak == "3");
					num = 6;
					continue;
				case 1:
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
					num = 13;
					continue;
				case 7:
					try
					{
						ab.CurrentColumn = ab.GetRow(0).Cells["m1"].Column;
						ab.Select();
						ab.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 9;
					continue;
				case 2:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 13;
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 0;
				case 9:
					return;
				case 16:
					ab.Tables[0].Columns["countAb"].Visible = false;
					p.Text = "40";
					num = 17;
					continue;
				case 10:
					num = 1;
					continue;
				case 0:
				case 15:
				case 17:
					a();
					num = 7;
					continue;
				case 12:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					if (true)
					{
					}
					num = 4;
					continue;
				case 4:
					return;
				case 13:
					ad.Text = asdaj.__field_a;
					am = true;
					flag = !(ak == "1");
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						flag = !(ak == "2");
						num = 11;
					}
					else
					{
						num = 16;
					}
					continue;
				case 3:
					ab.Tables[0].Columns["countAb"].Visible = false;
					p.Text = "60";
					num = 15;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		string text2 = default;
		while (true)
		{
			string text = " tYear_Student.Status in(1,4)";
			int num = 21;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 21:
					num = ((ak == "1") ? 22 : 23);
					continue;
				case 16:
					text += " and ";
					num = 13;
					continue;
				case 0:
					text += " tYear_Student.MarkTerm3_From100=1";
					num = 19;
					continue;
				case 8:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 15;
				case 20:
					text = " where " + text;
					num = 17;
					continue;
				case 22:
					num2 = 0;
					goto IL_02c5;
				case 11:
					flag = !(text != "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 13;
				case 17:
					text2 = " M1, M2";
					flag = !(ak == "3");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 5;
				case 7:
					text += " and ";
					num = 0;
					continue;
				case 6:
					text += " and ";
					num = 15;
					continue;
				case 27:
					flag = !(text != "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 17;
				case 24:
					text2 = " mark as M1,null as M2";
					num = 5;
					continue;
				case 26:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 14;
				case 23:
					num = 2;
					continue;
				case 2:
					num2 = ((!(ak == "2")) ? 1 : 0);
					goto IL_02c5;
				case 12:
					if (flag)
					{
						flag = !(ak == "3");
						num = 26;
					}
					else
					{
						num = 8;
					}
					continue;
				case 15:
					text += " tYear_Student.MarkTerm3_From100=0";
					num = 14;
					continue;
				case 10:
					flag = !(text != "");
					num = 1;
					continue;
				case 1:
					if (true)
					{
					}
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 0;
				case 13:
					text = text + " tYear_Student.xClass=" + af;
					num = 27;
					continue;
				case 14:
				case 19:
					flag = !(af != "0");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 27;
				case 5:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  0 as acp,  tStudent.id,tStudent.NumberAsas,tYear_Student.sort, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName,tmpMark.countAb, tmpMark.M1, tmpMark.M2, tmpMark.M3, tmpMark.M4, tmpMark.M5, \r\n                      tmpMark.M6, tmpMark.M7, tmpMark.M8, tmpMark.M9, tmpMark.M10\r\n                            FROM  tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent LEFT OUTER JOIN\r\n                          (SELECT     xStudent, Xtest, xbook, countAb, " + text2 + ", M3, M4, M5, M6, M7, M8, M9, M10\r\n                             FROM         tMark\r\n                             WHERE     (Xtest = " + ah + ") AND (xbook = " + ai + ")) tmpMark ON tStudent.id = tmpMark.xStudent" + text + " order by tStudent.LName, tStudent.FName");
						ab.DataSource = dataSource;
						GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(ab.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
						gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
						gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
						ab.RootTable.FormatConditions.Add(gridEXFormatCondition);
						GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(ab.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
						gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
						gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
						ab.RootTable.FormatConditions.Add(gridEXFormatCondition2);
						return;
					}
					IL_02c5:
					flag = (byte)num2 != 0;
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		bool flag = default;
		string text7 = default;
		int num4 = default;
		string text = default;
		int num8 = default;
		int num9 = default;
		string text8 = default;
		string text9 = default;
		string text6 = default;
		string text3 = default;
		string text10 = default;
		string text2 = default;
		string text5 = default;
		string text4 = default;
		string text11 = default;
		int num6 = default;
		float num7 = default;
		int num3 = default;
		while (true)
		{
			SqlCommand sqlCommand = null;
			int num = 0;
			int num2 = 52;
			while (true)
			{
				int num14;
				int num12;
				switch (num2)
				{
				case 21:
				case 66:
					flag = text7 != null;
					num2 = 36;
					continue;
				case 36:
					if (!flag)
					{
						num2 = 12;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m5", text7);
					num2 = 65;
					continue;
				case 67:
					try
					{
						while (true)
						{
							IL_0266:
							flag = !(ab.GetRow(num4).Cells["m1"].Text != "");
							num2 = 4;
							while (true)
							{
								int num17;
								switch (num2)
								{
								case 4:
									if (!flag)
									{
										num2 = 1;
										continue;
									}
									text = null;
									num2 = 6;
									continue;
								case 0:
									num2 = 8;
									continue;
								case 8:
									num17 = ((num6 >= num) ? 1 : 0);
									goto IL_037c;
								case 11:
									ab.GetRow(num4).Cells["m1"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 7;
									continue;
								case 7:
									goto end_IL_022d;
								case 9:
									if (!flag)
									{
										num2 = 11;
										continue;
									}
									text = num6.ToString();
									num7 += (float)num6;
									num8++;
									num2 = 5;
									continue;
								case 3:
									num17 = 0;
									goto IL_037c;
								case 1:
									num6 = int.Parse(ab.GetRow(num4).Cells["m1"].Text.ToString());
									num2 = 2;
									continue;
								case 2:
									num2 = ((num6 > num9) ? 3 : 0);
									continue;
								case 5:
								case 6:
									num2 = 10;
									continue;
								case 10:
									goto IL_1967;
									IL_037c:
									flag = (byte)num17 != 0;
									num2 = 9;
									continue;
								}
								goto IL_0266;
								continue;
								end_IL_022d:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 70:
					sqlCommand.Parameters.AddWithValue("@m4", DBNull.Value);
					num2 = 21;
					continue;
				case 24:
				case 39:
					flag = text != null;
					num2 = 35;
					continue;
				case 35:
					if (!flag)
					{
						num2 = 23;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m1", text);
					num2 = 41;
					continue;
				case 20:
					sqlCommand.Parameters.AddWithValue("@m10", DBNull.Value);
					num2 = 58;
					continue;
				case 57:
				case 90:
					flag = num4 < ab.RowCount;
					num2 = 77;
					continue;
				case 77:
					if (!flag)
					{
						num2 = 40;
						continue;
					}
					text8 = "";
					text = "";
					text9 = "";
					text6 = "";
					text3 = "";
					text7 = "";
					text10 = "";
					text2 = "";
					text5 = "";
					text4 = "";
					text11 = "";
					num6 = 0;
					num7 = 0f;
					num6 = 0;
					num7 = 0f;
					num8 = 0;
					num2 = 73;
					continue;
				case 27:
					num2 = 1;
					continue;
				case 1:
					num14 = ((text8 != null) ? 1 : 0);
					goto IL_1e46;
				case 52:
					try
					{
						num = int.Parse(q.Text);
					}
					catch
					{
					}
					num9 = int.Parse(p.Text);
					text8 = "";
					text = "";
					text9 = "";
					text6 = "";
					text3 = "";
					text7 = "";
					text10 = "";
					text2 = "";
					text5 = "";
					text4 = "";
					text11 = "";
					num6 = 0;
					num7 = 0f;
					num8 = 0;
					num3 = 0;
					al.Open();
					sqlCommand = new SqlCommand("UPDATE tExam SET procc = 0 WHERE  (id = " + ah + ")", al);
					sqlCommand.ExecuteNonQuery();
					num2 = 44;
					continue;
				case 19:
					try
					{
						while (true)
						{
							IL_0609:
							flag = !(ab.GetRow(num4).Cells["m3"].Text != "");
							num2 = 9;
							while (true)
							{
								int num16;
								switch (num2)
								{
								case 7:
									goto end_IL_05d0;
								case 9:
									if (!flag)
									{
										num2 = 8;
										continue;
									}
									text6 = null;
									num2 = 5;
									continue;
								case 1:
									num16 = 0;
									goto IL_066d;
								case 10:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									text6 = num6.ToString();
									num7 += (float)num6;
									num8++;
									num2 = 0;
									continue;
								case 2:
									num2 = 4;
									continue;
								case 4:
									num16 = ((num6 >= num) ? 1 : 0);
									goto IL_066d;
								case 8:
									num6 = int.Parse(ab.GetRow(num4).Cells["m3"].Text.ToString());
									num2 = 11;
									continue;
								case 11:
									num2 = ((num6 > num9) ? 1 : 2);
									continue;
								case 3:
									ab.GetRow(num4).Cells["m3"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 6;
									continue;
								case 6:
									goto end_IL_05ce;
								case 0:
								case 5:
									{
										num2 = 7;
										continue;
									}
									IL_066d:
									flag = (byte)num16 != 0;
									num2 = 10;
									continue;
								}
								goto IL_0609;
								continue;
								end_IL_05d0:
								break;
							}
							break;
						}
						goto IL_01f1;
						end_IL_05ce:;
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 81:
					try
					{
						while (true)
						{
							IL_0873:
							flag = !(ab.GetRow(num4).Cells["m2"].Text != "");
							num2 = 3;
							while (true)
							{
								int num15;
								switch (num2)
								{
								case 3:
									if (!flag)
									{
										num2 = 6;
										continue;
									}
									text9 = null;
									num2 = 11;
									continue;
								case 0:
									num2 = 7;
									continue;
								case 7:
									num15 = ((num6 >= num) ? 1 : 0);
									goto IL_0935;
								case 9:
									num15 = 0;
									goto IL_0935;
								case 1:
									if (flag)
									{
										text9 = num6.ToString();
										num7 += (float)num6;
										num8++;
										num2 = 2;
									}
									else
									{
										num2 = 5;
									}
									continue;
								case 5:
									ab.GetRow(num4).Cells["m2"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 10;
									continue;
								case 10:
									goto end_IL_083a;
								case 6:
									num6 = int.Parse(ab.GetRow(num4).Cells["m2"].Text.ToString());
									num2 = 8;
									continue;
								case 8:
									num2 = ((num6 > num9) ? 9 : 0);
									continue;
								case 2:
								case 11:
									num2 = 4;
									continue;
								case 4:
									goto IL_19ba;
									IL_0935:
									flag = (byte)num15 != 0;
									num2 = 1;
									continue;
								}
								goto IL_0873;
								continue;
								end_IL_083a:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 14:
					try
					{
						while (true)
						{
							IL_0ae0:
							flag = !(ab.GetRow(num4).Cells["m5"].Text != "");
							num2 = 1;
							while (true)
							{
								int num13;
								switch (num2)
								{
								case 1:
									if (!flag)
									{
										num2 = 6;
										continue;
									}
									text7 = null;
									num2 = 0;
									continue;
								case 10:
									num13 = 0;
									goto IL_0b47;
								case 4:
									if (!flag)
									{
										num2 = 11;
										continue;
									}
									text7 = num6.ToString();
									num7 += (float)num6;
									num8++;
									num2 = 7;
									continue;
								case 11:
									ab.GetRow(num4).Cells["m5"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 5;
									continue;
								case 5:
									goto end_IL_0aa7;
								case 9:
									num2 = 3;
									continue;
								case 3:
									num13 = ((num6 >= num) ? 1 : 0);
									goto IL_0b47;
								case 6:
									num6 = int.Parse(ab.GetRow(num4).Cells["m5"].Text.ToString());
									num2 = 2;
									continue;
								case 2:
									num2 = ((num6 <= num9) ? 9 : 10);
									continue;
								case 0:
								case 7:
									num2 = 8;
									continue;
								case 8:
									goto IL_12ad;
									IL_0b47:
									flag = (byte)num13 != 0;
									num2 = 4;
									continue;
								}
								goto IL_0ae0;
								continue;
								end_IL_0aa7:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 51:
				case 58:
					flag = num8 != 0;
					num2 = 56;
					continue;
				case 56:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@Mark", num7);
						num2 = 74;
					}
					else
					{
						num2 = 79;
					}
					continue;
				case 0:
				case 46:
					flag = text6 != null;
					num2 = 82;
					continue;
				case 82:
					if (!flag)
					{
						num2 = 30;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m3", text6);
					num2 = 28;
					continue;
				case 87:
					try
					{
						while (true)
						{
							IL_0deb:
							flag = !(ab.GetRow(num4).Cells["m7"].Text != "");
							num2 = 3;
							while (true)
							{
								int num10;
								switch (num2)
								{
								case 3:
									if (!flag)
									{
										num2 = 0;
										continue;
									}
									text2 = null;
									num2 = 5;
									continue;
								case 0:
									num6 = int.Parse(ab.GetRow(num4).Cells["m7"].Text.ToString());
									num2 = 6;
									continue;
								case 6:
									num2 = ((num6 <= num9) ? 1 : 4);
									continue;
								case 4:
									num10 = 0;
									goto IL_0ee3;
								case 11:
									if (flag)
									{
										text2 = num6.ToString();
										num7 += (float)num6;
										num8++;
										num2 = 10;
									}
									else
									{
										num2 = 8;
									}
									continue;
								case 1:
									num2 = 7;
									continue;
								case 7:
									num10 = ((num6 >= num) ? 1 : 0);
									goto IL_0ee3;
								case 8:
									ab.GetRow(num4).Cells["m7"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 2;
									continue;
								case 2:
									goto end_IL_0db2;
								case 5:
								case 10:
									num2 = 9;
									continue;
								case 9:
									goto IL_263d;
									IL_0ee3:
									flag = (byte)num10 != 0;
									num2 = 11;
									continue;
								}
								goto IL_0deb;
								continue;
								end_IL_0db2:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 9:
					try
					{
						while (true)
						{
							IL_104f:
							flag = !(ab.GetRow(num4).Cells["m4"].Text != "");
							num2 = 9;
							while (true)
							{
								int num5;
								switch (num2)
								{
								case 3:
									goto end_IL_1016;
								case 9:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									text3 = null;
									num2 = 10;
									continue;
								case 2:
									num6 = int.Parse(ab.GetRow(num4).Cells["m4"].Text.ToString());
									num2 = 0;
									continue;
								case 0:
									num2 = ((num6 > num9) ? 1 : 4);
									continue;
								case 5:
									ab.GetRow(num4).Cells["m4"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 8;
									continue;
								case 8:
									goto end_IL_1014;
								case 1:
									num5 = 0;
									goto IL_11da;
								case 7:
									if (flag)
									{
										text3 = num6.ToString();
										num7 += (float)num6;
										num8++;
										num2 = 6;
									}
									else
									{
										num2 = 5;
									}
									continue;
								case 4:
									num2 = 11;
									continue;
								case 11:
									num5 = ((num6 >= num) ? 1 : 0);
									goto IL_11da;
								case 6:
								case 10:
									{
										num2 = 3;
										continue;
									}
									IL_11da:
									flag = (byte)num5 != 0;
									num2 = 7;
									continue;
								}
								goto IL_104f;
								continue;
								end_IL_1016:
								break;
							}
							break;
						}
						goto IL_051e;
						end_IL_1014:;
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 10:
					sqlCommand.Parameters.AddWithValue("@m8", DBNull.Value);
					num2 = 47;
					continue;
				case 32:
					try
					{
						num7 = float.Parse(text);
						text9 = num7.ToString();
					}
					catch
					{
					}
					text = null;
					num2 = 72;
					continue;
				case 45:
					num2 = 2;
					continue;
				case 2:
					num12 = ((!(ak == "2")) ? 1 : 0);
					goto IL_22c5;
				case 50:
					num7 /= (float)num8;
					num2 = 85;
					continue;
				case 22:
					sqlCommand.Parameters.AddWithValue("@m6", DBNull.Value);
					num2 = 48;
					continue;
				case 86:
					try
					{
						while (true)
						{
							IL_1387:
							flag = !(ab.GetRow(num4).Cells["m9"].Text != "");
							num2 = 2;
							while (true)
							{
								int num21;
								switch (num2)
								{
								case 9:
									goto end_IL_134e;
								case 2:
									if (!flag)
									{
										num2 = 7;
										continue;
									}
									text4 = null;
									num2 = 6;
									continue;
								case 7:
									num6 = int.Parse(ab.GetRow(num4).Cells["m9"].Text.ToString());
									num2 = 1;
									continue;
								case 1:
									num2 = ((num6 > num9) ? 4 : 5);
									continue;
								case 8:
									ab.GetRow(num4).Cells["m9"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 0;
									continue;
								case 0:
									goto end_IL_134c;
								case 4:
									num21 = 0;
									goto IL_150f;
								case 10:
									if (flag)
									{
										text4 = num6.ToString();
										num7 += (float)num6;
										num8++;
										num2 = 3;
									}
									else
									{
										num2 = 8;
									}
									continue;
								case 5:
									num2 = 11;
									continue;
								case 11:
									num21 = ((num6 >= num) ? 1 : 0);
									goto IL_150f;
								case 3:
								case 6:
									{
										num2 = 9;
										continue;
									}
									IL_150f:
									flag = (byte)num21 != 0;
									num2 = 10;
									continue;
								}
								goto IL_1387;
								continue;
								end_IL_134e:
								break;
							}
							break;
						}
						goto IL_0d6a;
						end_IL_134c:;
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 53:
				case 91:
					flag = text11 != null;
					num2 = 60;
					continue;
				case 60:
					if (!flag)
					{
						num2 = 20;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m10", text11);
					num2 = 51;
					continue;
				case 44:
					num2 = ((ak == "1") ? 4 : 45);
					continue;
				case 55:
				case 74:
				{
					int num20 = sqlCommand.ExecuteNonQuery();
					flag = num20 >= 1;
					num2 = 18;
					continue;
				}
				case 18:
					if (!flag)
					{
						num2 = 49;
						continue;
					}
					num3++;
					num2 = 31;
					continue;
				case 42:
					try
					{
						while (true)
						{
							IL_1735:
							flag = !(ab.GetRow(num4).Cells["m6"].Text != "");
							num2 = 7;
							while (true)
							{
								int num19;
								switch (num2)
								{
								case 7:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									text10 = null;
									num2 = 4;
									continue;
								case 5:
									num2 = 11;
									continue;
								case 11:
									num19 = ((num6 >= num) ? 1 : 0);
									goto IL_189f;
								case 6:
									ab.GetRow(num4).Cells["m6"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 1;
									continue;
								case 1:
									goto end_IL_16fc;
								case 2:
									num6 = int.Parse(ab.GetRow(num4).Cells["m6"].Text.ToString());
									num2 = 8;
									continue;
								case 8:
									num2 = ((num6 > num9) ? 9 : 5);
									continue;
								case 0:
									if (!flag)
									{
										num2 = 6;
										continue;
									}
									text10 = num6.ToString();
									num7 += (float)num6;
									num8++;
									num2 = 3;
									continue;
								case 9:
									num19 = 0;
									goto IL_189f;
								case 3:
								case 4:
									num2 = 10;
									continue;
								case 10:
									goto IL_19f7;
									IL_189f:
									flag = (byte)num19 != 0;
									num2 = 0;
									continue;
								}
								goto IL_1735;
								continue;
								end_IL_16fc:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 69:
					sqlCommand.Parameters.AddWithValue("@m7", DBNull.Value);
					num2 = 17;
					continue;
				case 6:
					num4 = 0;
					num2 = 90;
					continue;
				case 16:
					sqlCommand.Parameters.AddWithValue("@m2", DBNull.Value);
					num2 = 46;
					continue;
				case 37:
					sqlCommand.Parameters.AddWithValue("@m9", DBNull.Value);
					num2 = 91;
					continue;
				case 34:
				case 65:
					flag = text10 != null;
					num2 = 76;
					continue;
				case 76:
					if (!flag)
					{
						num2 = 22;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m6", text10);
					num2 = 80;
					continue;
				case 26:
					try
					{
						while (true)
						{
							IL_1b13:
							flag = !(ab.GetRow(num4).Cells["m10"].Text != "");
							num2 = 8;
							while (true)
							{
								int num18;
								switch (num2)
								{
								case 8:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									text11 = null;
									num2 = 9;
									continue;
								case 5:
									num18 = 0;
									goto IL_1ca1;
								case 4:
									num2 = 0;
									continue;
								case 0:
									num18 = ((num6 >= num) ? 1 : 0);
									goto IL_1ca1;
								case 2:
									num6 = int.Parse(ab.GetRow(num4).Cells["m10"].Text.ToString());
									num2 = 1;
									continue;
								case 1:
									num2 = ((num6 <= num9) ? 4 : 5);
									continue;
								case 11:
									ab.GetRow(num4).Cells["m10"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 6;
									continue;
								case 6:
									goto end_IL_1ada;
								case 3:
									if (flag)
									{
										text11 = num6.ToString();
										num7 += (float)num6;
										num8++;
										num2 = 10;
									}
									else
									{
										num2 = 11;
									}
									continue;
								case 9:
								case 10:
									num2 = 7;
									continue;
								case 7:
									goto IL_1e6d;
									IL_1ca1:
									flag = (byte)num18 != 0;
									num2 = 3;
									continue;
								}
								goto IL_1b13;
								continue;
								end_IL_1ada:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 72:
					sqlCommand = new SqlCommand("sp_tMark_insertUpdate", al);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xStudent", ab.GetRow(num4).Cells["id"].Text.ToString());
					sqlCommand.Parameters.AddWithValue("@Xtest", ah);
					sqlCommand.Parameters.AddWithValue("@xbook", ai);
					flag = text8 != null;
					num2 = 64;
					continue;
				case 64:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@countAb", text8);
						num2 = 24;
					}
					else
					{
						num2 = 13;
					}
					continue;
				case 23:
					sqlCommand.Parameters.AddWithValue("@m1", DBNull.Value);
					num2 = 68;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 5;
						continue;
					}
					ab.GetRow(num4).BeginEdit();
					ab.GetRow(num4).Cells["acp"].Value = "1";
					ab.GetRow(num4).EndEdit();
					flag = num8 == 0;
					num2 = 75;
					continue;
				case 29:
					num2 = ((num8 != 0) ? 25 : 27);
					continue;
				case 5:
					sqlCommand = new SqlCommand("DELETE FROM tMark WHERE (xStudent = @xStudent) AND (Xtest = @Xtest) AND (xbook = @xbook)", al);
					sqlCommand.Parameters.AddWithValue("@xStudent", ab.GetRow(num4).Cells["id"].Text.ToString());
					sqlCommand.Parameters.AddWithValue("@Xtest", ah);
					sqlCommand.Parameters.AddWithValue("@xbook", ai);
					sqlCommand.ExecuteNonQuery();
					num2 = 3;
					continue;
				case 13:
					sqlCommand.Parameters.AddWithValue("@countAb", DBNull.Value);
					num2 = 39;
					continue;
				case 85:
					flag = !(ak == "3");
					num2 = 71;
					continue;
				case 71:
					if (!flag)
					{
						num2 = 61;
						continue;
					}
					goto case 72;
				case 25:
					num14 = 1;
					goto IL_1e46;
				case 17:
				case 84:
					flag = text5 != null;
					num2 = 88;
					continue;
				case 88:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m8", text5);
						num2 = 54;
					}
					else
					{
						num2 = 10;
					}
					continue;
				case 41:
				case 68:
					flag = text9 != null;
					num2 = 59;
					continue;
				case 59:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m2", text9);
						num2 = 0;
					}
					else
					{
						num2 = 16;
					}
					continue;
				case 89:
					if (true)
					{
					}
					sqlCommand = new SqlCommand("UPDATE tExam SET procc = 0 WHERE term=3 and xYear=" + aj, al);
					sqlCommand.ExecuteNonQuery();
					num2 = 6;
					continue;
				case 73:
					try
					{
						while (true)
						{
							IL_20a2:
							flag = !(ab.GetRow(num4).Cells["countAb"].Text != "");
							num2 = 3;
							while (true)
							{
								switch (num2)
								{
								case 3:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									text8 = null;
									num2 = 0;
									continue;
								case 4:
									short.Parse(ab.GetRow(num4).Cells["countAb"].Text.ToString());
									text8 = ab.GetRow(num4).Cells["countAb"].Text.ToString();
									num2 = 1;
									continue;
								case 0:
								case 1:
									num2 = 2;
									continue;
								case 2:
									goto end_IL_2085;
								}
								goto IL_20a2;
								continue;
								end_IL_2085:
								break;
							}
							break;
						}
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
						goto case 3;
					}
					num2 = 67;
					continue;
				case 12:
					sqlCommand.Parameters.AddWithValue("@m5", DBNull.Value);
					num2 = 34;
					continue;
				case 15:
				case 28:
					flag = text3 != null;
					num2 = 83;
					continue;
				case 83:
					if (!flag)
					{
						num2 = 70;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m4", text3);
					num2 = 66;
					continue;
				case 79:
					sqlCommand.Parameters.AddWithValue("@Mark", DBNull.Value);
					num2 = 55;
					continue;
				case 4:
					num12 = 0;
					goto IL_22c5;
				case 63:
					if (!flag)
					{
						num2 = 89;
						continue;
					}
					goto case 6;
				case 61:
					num2 = 32;
					continue;
				case 43:
					try
					{
						while (true)
						{
							IL_2364:
							flag = !(ab.GetRow(num4).Cells["m8"].Text != "");
							num2 = 11;
							while (true)
							{
								int num11;
								switch (num2)
								{
								case 5:
									goto end_IL_232b;
								case 11:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									text5 = null;
									num2 = 8;
									continue;
								case 2:
									ab.GetRow(num4).Cells["m8"].FormatStyle.BackColor = Color.Yellow;
									ab.GetRow(num4).BeginEdit();
									ab.GetRow(num4).Cells["acp"].Value = "-1";
									ab.GetRow(num4).EndEdit();
									num2 = 9;
									continue;
								case 9:
									goto end_IL_2329;
								case 10:
									num11 = 0;
									goto IL_2504;
								case 3:
									num6 = int.Parse(ab.GetRow(num4).Cells["m8"].Text.ToString());
									num2 = 4;
									continue;
								case 4:
									num2 = ((num6 <= num9) ? 6 : 10);
									continue;
								case 6:
									num2 = 1;
									continue;
								case 1:
									num11 = ((num6 >= num) ? 1 : 0);
									goto IL_2504;
								case 7:
									if (flag)
									{
										text5 = num6.ToString();
										num7 += (float)num6;
										num8++;
										num2 = 0;
									}
									else
									{
										num2 = 2;
									}
									continue;
								case 0:
								case 8:
									{
										num2 = 5;
										continue;
									}
									IL_2504:
									flag = (byte)num11 != 0;
									num2 = 7;
									continue;
								}
								goto IL_2364;
								continue;
								end_IL_232b:
								break;
							}
							break;
						}
						goto IL_225f;
						end_IL_2329:;
					}
					catch
					{
						ab.GetRow(num4).BeginEdit();
						ab.GetRow(num4).Cells["acp"].Value = "-1";
						ab.GetRow(num4).EndEdit();
					}
					goto case 3;
				case 30:
					sqlCommand.Parameters.AddWithValue("@m3", DBNull.Value);
					num2 = 15;
					continue;
				case 3:
				case 92:
					num4++;
					num2 = 57;
					continue;
				case 47:
				case 54:
					flag = text4 != null;
					num2 = 38;
					continue;
				case 38:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m9", text4);
						num2 = 53;
					}
					else
					{
						num2 = 37;
					}
					continue;
				case 48:
				case 80:
					flag = text2 != null;
					num2 = 78;
					continue;
				case 78:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m7", text2);
						num2 = 84;
					}
					else
					{
						num2 = 69;
					}
					continue;
				case 40:
					al.Close();
					ab.Refresh();
					flag = num3 <= 0;
					num2 = 7;
					continue;
				case 7:
					if (!flag)
					{
						num2 = 62;
						continue;
					}
					goto case 33;
				case 49:
					num2 = 8;
					continue;
				case 8:
				case 31:
					num2 = 92;
					continue;
				case 75:
					if (!flag)
					{
						num2 = 50;
						continue;
					}
					goto case 85;
				case 62:
					MessageBox.Show("تعداد " + num3 + " ردیف انجام شد");
					num2 = 33;
					continue;
				case 33:
					{
						am = true;
						return;
					}
					IL_051e:
					num2 = 14;
					continue;
					IL_263d:
					num2 = 43;
					continue;
					IL_225f:
					num2 = 86;
					continue;
					IL_12ad:
					num2 = 42;
					continue;
					IL_19ba:
					num2 = 19;
					continue;
					IL_01f1:
					num2 = 9;
					continue;
					IL_1e6d:
					num2 = 29;
					continue;
					IL_1e46:
					flag = (byte)num14 != 0;
					num2 = 11;
					continue;
					IL_19f7:
					num2 = 87;
					continue;
					IL_1967:
					num2 = 81;
					continue;
					IL_0d6a:
					num2 = 26;
					continue;
					IL_22c5:
					flag = (byte)num12 != 0;
					num2 = 63;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		int num2 = default;
		int num3 = default;
		while (true)
		{
			bool flag = !(A_1.Column.Key == "sort");
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
					am = false;
					num2 = 0;
					num = 0;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_008d:
							int num4 = int.Parse(ab.GetRow(ab.Row).Cells["m1"].Text.ToString());
							num = 0;
							while (true)
							{
								int num5;
								switch (num)
								{
								case 0:
									num = ((num4 > num3) ? 2 : 6);
									continue;
								case 6:
									if (true)
									{
									}
									num = 5;
									continue;
								case 2:
									num5 = 0;
									goto IL_0289;
								case 4:
									an = ab.Row;
									ab.GetRow(ab.Row).BeginEdit();
									ab.GetRow(ab.Row).Cells["acp"].Value = "-1";
									ab.GetRow(ab.Row).Cells["m1"].Value = num4;
									ab.GetRow(ab.Row).EndEdit();
									num = 7;
									continue;
								case 5:
									num5 = ((num4 >= num2) ? 1 : 0);
									goto IL_0289;
								case 8:
									if (flag)
									{
										an = -1;
										ab.GetRow(ab.Row).BeginEdit();
										ab.GetRow(ab.Row).Cells["acp"].Value = "0";
										ab.GetRow(ab.Row).Cells["m1"].Value = num4;
										ab.GetRow(ab.Row).EndEdit();
										num = 3;
									}
									else
									{
										num = 4;
									}
									continue;
								case 3:
								case 7:
									num = 1;
									continue;
								case 1:
									goto end_IL_0060;
									IL_0289:
									flag = (byte)num5 != 0;
									num = 8;
									continue;
								}
								goto IL_008d;
								continue;
								end_IL_0060:
								break;
							}
							break;
						}
					}
					catch
					{
						an = -1;
						ab.GetRow(ab.Row).BeginEdit();
						ab.GetRow(ab.Row).Cells["acp"].Value = "0";
						ab.GetRow(ab.Row).Cells["m1"].Value = DBNull.Value;
						ab.GetRow(ab.Row).EndEdit();
					}
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "update tstudent set sort=" + ab.GetRow(ab.Row).Cells["sort"].Value.ToString() + " where id=" + ab.GetRow(ab.Row).Cells["id"].Value.ToString());
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					try
					{
						num2 = int.Parse(q.Text);
					}
					catch
					{
					}
					num3 = int.Parse(p.Text);
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ab.RootTable.Columns["sort"].Selectable = l.Checked;
	}

	private void b(object A_0, EventArgs A_1)
	{
		int num2 = default;
		float num6 = default;
		float num5 = default;
		while (true)
		{
			bool flag = k.SelectedIndex >= 0;
			int num = 10;
			while (true)
			{
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 15;
				case 0:
					ab.GetRow(num2).Cells[k.SelectedValue.ToString()].Value = DBNull.Value;
					num = 9;
					continue;
				case 4:
					num2 = 0;
					num = 2;
					continue;
				case 8:
					num6 = float.Parse(q.Text);
					num5 = float.Parse(p.Text);
					if (true)
					{
					}
					num = 3;
					continue;
				case 9:
				case 18:
					ab.GetRow(num2).Cells[k.SelectedValue.ToString()].Text = g.Text;
					ab.GetRow(num2).EndEdit();
					num2++;
					num = 17;
					continue;
				case 15:
					g.Text = g.Text.Trim();
					flag = !(g.Text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = DialogResult.Yes == MessageBox.Show("آیا میخواهید نمرات " + k.SelectedItem.Text + " خالی شود", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
					num = 11;
					continue;
				case 13:
					if (!flag)
					{
						num = 0;
						continue;
					}
					ab.GetRow(num2).Cells[k.SelectedValue.ToString()].Value = g.Text;
					num = 18;
					continue;
				case 1:
					am = false;
					num = 12;
					continue;
				case 12:
					return;
				case 11:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 4;
				case 3:
					try
					{
						while (true)
						{
							IL_02d7:
							float num3 = float.Parse(g.Text);
							num = 3;
							while (true)
							{
								int num4;
								switch (num)
								{
								case 3:
									num = ((!(num3 > num5)) ? 6 : 0);
									continue;
								case 6:
									num = 1;
									continue;
								case 1:
									num4 = ((!(num3 < num6)) ? 1 : 0);
									goto IL_0344;
								case 7:
									MessageBox.Show("نمره وارد شده خارج از محدوده می باشد");
									g.Focus();
									num = 2;
									continue;
								case 2:
									return;
								case 4:
									num = (flag ? 5 : 7);
									continue;
								case 0:
									num4 = 0;
									goto IL_0344;
								case 5:
									goto end_IL_02ae;
									IL_0344:
									flag = (byte)num4 != 0;
									num = 4;
									continue;
								}
								goto IL_02d7;
								continue;
								end_IL_02ae:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("نمره اشتباه است - فقط عدد وارد کنید");
						g.Focus();
						return;
					}
					num = 4;
					continue;
				case 2:
				case 17:
					flag = num2 < ab.RowCount;
					num = 14;
					continue;
				case 14:
					if (flag)
					{
						ab.GetRow(num2).BeginEdit();
						flag = !(g.Text == "");
						num = 13;
					}
					else
					{
						num = 1;
					}
					continue;
				case 5:
					k.SelectedIndex = 0;
					num = 15;
					continue;
				case 16:
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		while (true)
		{
			bool flag = am;
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
					return;
				case 1:
					return;
				case 0:
					A_1.Cancel = true;
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 2;
					continue;
				case 2:
					if (true)
					{
					}
					num = (flag ? 1 : 0);
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F5;
			int num = 4;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 5:
					e(this, null);
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					flag = A_1.KeyCode != Keys.Escape;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 1:
					ab.Refresh();
					d(this, null);
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
	}
}
