using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using FreeSms.Reporting;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asda0 : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private UIButton m_c;

	private UIButton m_d;

	private GridEX m_e;

	private GridEX m_f;

	private EditBox m_g;

	private EditBox m_h;

	private Label m_i;

	private Label m_j;

	private Label m_k;

	private EditBox m_l;

	private Label m_m;

	private EditBox n;

	private Label o;

	private EditBox p;

	private Label q;

	private UIComboBox r;

	private CheckBox s;

	private Label t;

	private ComboBox u;

	private Label v;

	private Panel w;

	private Panel x;

	private UIButton y;

	private UIButton z;

	private RadioButton aa;

	private RadioButton ab;

	private Label ac;

	private UIComboBox ad;

	private Label ae;

	private CheckBox af;

	private CheckBox ag;

	private bool ah;

	private string ai = "";
protected override void Dispose(bool A_0)
	{
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 2;
					}
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 1;
					continue;
				case 4:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 1;
				case 2:
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

	private void f()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda0));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		GridEXLayout gridEXLayout3 = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat2 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new GridEX();
		this.m_f = new GridEX();
		this.m_g = new EditBox();
		this.m_h = new EditBox();
		this.m_i = new Label();
		this.m_j = new Label();
		this.m_k = new Label();
		this.m_l = new EditBox();
		this.m_m = new Label();
		n = new EditBox();
		o = new Label();
		p = new EditBox();
		q = new Label();
		r = new UIComboBox();
		s = new CheckBox();
		t = new Label();
		u = new ComboBox();
		v = new Label();
		w = new Panel();
		x = new Panel();
		aa = new RadioButton();
		ab = new RadioButton();
		ac = new Label();
		y = new UIButton();
		z = new UIButton();
		ad = new UIComboBox();
		ae = new Label();
		af = new CheckBox();
		ag = new CheckBox();
		((ISupportInitialize)this.m_b).BeginInit();
		((ISupportInitialize)this.m_e).BeginInit();
		((ISupportInitialize)this.m_f).BeginInit();
		w.SuspendLayout();
		x.SuspendLayout();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(199, 34);
		this.m_b.Name = "gridEX1";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(564, 356);
		this.m_b.TabIndex = 0;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_b.SelectionChanged += g;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_c.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(158, 576);
		this.m_c.Name = "btnview";
		this.m_c.Size = new Size(122, 34);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "نمایش گزارش";
		this.m_c.Click += l;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_d.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		this.m_d.Location = new Point(18, 576);
		this.m_d.Name = "btnClose";
		this.m_d.Size = new Size(134, 34);
		this.m_d.TabIndex = 110;
		this.m_d.Text = "بستن";
		this.m_d.Click += k;
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_e.DesignTimeLayout = gridEXLayout2;
		this.m_e.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_e.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.GroupByBoxVisible = false;
		this.m_e.Location = new Point(1, 220);
		this.m_e.Name = "gClass";
		this.m_e.RowHeaders = InheritableBoolean.True;
		this.m_e.Size = new Size(193, 170);
		this.m_e.TabIndex = 107;
		this.m_e.VisualStyle = VisualStyle.Office2003;
		this.m_e.Click += b;
		this.m_e.SelectionChanged += d;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_f.DesignTimeLayout = gridEXLayout3;
		this.m_f.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_f.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_f.GroupByBoxVisible = false;
		this.m_f.Location = new Point(1, 34);
		this.m_f.Name = "gExam";
		this.m_f.RowHeaders = InheritableBoolean.True;
		this.m_f.Size = new Size(193, 160);
		this.m_f.TabIndex = 111;
		this.m_f.VisualStyle = VisualStyle.Office2003;
		this.m_f.Click += c;
		this.m_f.SelectionChanged += e;
		this.m_g.AutoScroll = false;
		this.m_g.AutoScrollMargin = new Size(0, 0);
		this.m_g.AutoScrollMinSize = new Size(0, 0);
		this.m_g.AutoScrollPosition = new Point(0, 0);
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(414, 504);
		this.m_g.MaxLength = 300;
		this.m_g.Name = "txtSch";
		this.m_g.Size = new Size(263, 23);
		this.m_g.TabIndex = 112;
		this.m_g.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_h.AutoScroll = false;
		this.m_h.AutoScrollMargin = new Size(0, 0);
		this.m_h.AutoScrollMinSize = new Size(0, 0);
		this.m_h.AutoScrollPosition = new Point(0, 0);
		this.m_h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(414, 539);
		this.m_h.MaxLength = 300;
		this.m_h.Name = "txtFoter1";
		this.m_h.Size = new Size(263, 23);
		this.m_h.TabIndex = 113;
		this.m_h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_i.AutoSize = true;
		this.m_i.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(680, 505);
		this.m_i.Name = "label1";
		this.m_i.Size = new Size(57, 20);
		this.m_i.TabIndex = 114;
		this.m_i.Text = "نام مکتب :";
		this.m_j.AutoSize = true;
		this.m_j.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(681, 542);
		this.m_j.Name = "label2";
		this.m_j.Size = new Size(50, 20);
		this.m_j.TabIndex = 115;
		this.m_j.Text = "نام مدیر :";
		this.m_k.AutoSize = true;
		this.m_k.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_k.Location = new Point(681, 395);
		this.m_k.Name = "label3";
		this.m_k.Size = new Size(71, 20);
		this.m_k.TabIndex = 117;
		this.m_k.Text = "بالای گزارش :";
		this.m_l.AutoScroll = false;
		this.m_l.AutoScrollMargin = new Size(0, 0);
		this.m_l.AutoScrollMinSize = new Size(0, 0);
		this.m_l.AutoScrollPosition = new Point(0, 0);
		this.m_l.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(12, 394);
		this.m_l.MaxLength = 300;
		this.m_l.Name = "txtHeder1";
		this.m_l.Size = new Size(664, 23);
		this.m_l.TabIndex = 116;
		this.m_l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_m.AutoSize = true;
		this.m_m.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_m.Location = new Point(679, 473);
		this.m_m.Name = "label4";
		this.m_m.Size = new Size(56, 20);
		this.m_m.TabIndex = 119;
		this.m_m.Text = "پیام مدیر :";
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(12, 472);
		n.MaxLength = 300;
		n.Name = "txtHeder2";
		n.Size = new Size(664, 23);
		n.TabIndex = 118;
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		o.AutoSize = true;
		o.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(680, 447);
		o.Name = "label5";
		o.Size = new Size(86, 20);
		o.TabIndex = 121;
		o.Text = "پایین اطلاع نامه :";
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Location = new Point(12, 445);
		p.MaxLength = 300;
		p.Name = "txtFoter2";
		p.Size = new Size(664, 23);
		p.TabIndex = 120;
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.AutoSize = true;
		q.Location = new Point(171, 200);
		q.Name = "label20";
		q.Size = new Size(22, 13);
		q.TabIndex = 123;
		q.Text = "پایه";
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		r.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		r.Location = new Point(1, 197);
		r.Name = "dropPaye";
		r.Size = new Size(164, 20);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		r.StringFormat = stringFormat;
		r.TabIndex = 122;
		r.SelectedIndexChanged += j;
		s.Checked = true;
		s.CheckState = CheckState.Checked;
		s.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		s.Location = new Point(10, 497);
		s.Name = "checkSp2";
		s.Size = new Size(399, 20);
		s.TabIndex = 125;
		s.Text = "فقط درس های دارای نمره را  در گزارش نمایش داده شود";
		s.UseVisualStyleBackColor = true;
		t.AutoSize = true;
		t.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		t.ForeColor = Color.Red;
		t.Location = new Point(103, 420);
		t.Name = "label6";
		t.Size = new Size(598, 20);
		t.TabIndex = 126;
		t.Text = "در صورتی که برای شاگرد در منوی توضیحات زیر اطلاع نامه توضیحی ثبت شده باشد به جای پایین اطلاع نامه نمایش داده خواهد شد";
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.DropDownStyle = ComboBoxStyle.DropDownList;
		u.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.FormattingEnabled = true;
		u.Location = new Point(483, 4);
		u.Name = "dropTypeRpt";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(228, 24);
		u.TabIndex = 127;
		u.SelectedValueChanged += i;
		v.AutoSize = true;
		v.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Location = new Point(717, 5);
		v.Name = "label7";
		v.Size = new Size(59, 20);
		v.TabIndex = 128;
		v.Text = "نوع گزارش";
		w.BackColor = Color.Gray;
		w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		w.Controls.Add(x);
		w.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.Location = new Point(218, 142);
		w.Name = "pSort";
		w.Size = new Size(338, 204);
		w.TabIndex = 129;
		w.Visible = false;
		x.BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		x.Controls.Add(aa);
		x.Controls.Add(ab);
		x.Controls.Add(ac);
		x.Controls.Add(y);
		x.Controls.Add(z);
		x.Location = new Point(6, 7);
		x.Name = "panel1";
		x.Size = new Size(321, 186);
		x.TabIndex = 40;
		aa.AutoSize = true;
		aa.Location = new Point(126, 88);
		aa.Name = "radioButton2";
		aa.Size = new Size(108, 32);
		aa.TabIndex = 1;
		aa.TabStop = true;
		aa.Text = " ترتیب و الفبا";
		aa.UseVisualStyleBackColor = true;
		ab.AutoSize = true;
		ab.Location = new Point(132, 50);
		ab.Name = "radioButton1";
		ab.Size = new Size(102, 32);
		ab.TabIndex = 0;
		ab.TabStop = true;
		ab.Text = "بالاترین نمره";
		ab.UseVisualStyleBackColor = true;
		ac.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ac.Location = new Point(17, 10);
		ac.Name = "label9";
		ac.Size = new Size(255, 37);
		ac.TabIndex = 130;
		ac.Text = "ترتیب شاگردان در  گزارش بر اساس";
		y.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		y.Location = new Point(40, 132);
		y.Name = "btnCancel";
		y.Size = new Size(117, 38);
		y.TabIndex = 5;
		y.Text = "انصراف";
		y.Click += f;
		z.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		z.Location = new Point(163, 132);
		z.Name = "btnAcp";
		z.Size = new Size(104, 38);
		z.TabIndex = 4;
		z.Text = "تایید";
		z.Click += h;
		ad.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ad.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ad.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "1403";
		uIComboBoxItem.Value = "1403";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "1402";
		uIComboBoxItem2.Value = "1402";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "1401";
		uIComboBoxItem3.Value = "1401";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "1400";
		uIComboBoxItem4.Value = "1400";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1399";
		uIComboBoxItem5.Value = "1399";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1398";
		uIComboBoxItem6.Value = "1398";
		ad.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		ad.Location = new Point(10, 4);
		ad.Name = "dropYear";
		ad.Size = new Size(97, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		ad.StringFormat = stringFormat2;
		ad.TabIndex = 130;
		ad.SelectedIndexChanged += a;
		ae.AutoSize = true;
		ae.Location = new Point(114, 10);
		ae.Name = "label8";
		ae.Size = new Size(66, 13);
		ae.TabIndex = 131;
		ae.Text = "سال تعلیمی";
		af.Checked = true;
		af.CheckState = CheckState.Checked;
		af.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		af.ForeColor = Color.Navy;
		af.Location = new Point(126, 520);
		af.Name = "checkshowBartar";
		af.Size = new Size(283, 20);
		af.TabIndex = 132;
		af.Text = "نمایش نفرات برتر در اطلاع نامه";
		af.UseVisualStyleBackColor = true;
		ag.Checked = true;
		ag.CheckState = CheckState.Checked;
		ag.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ag.ForeColor = Color.FromArgb(192, 0, 192);
		ag.Location = new Point(86, 546);
		ag.Name = "checkShowGread";
		ag.Size = new Size(323, 20);
		ag.TabIndex = 133;
		ag.Text = "نمایش رتبه کل و تعداد شاگرد در اطلاع نامه";
		ag.UseVisualStyleBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(784, 612);
		Controls.Add(ag);
		Controls.Add(af);
		Controls.Add(ae);
		Controls.Add(ad);
		Controls.Add(w);
		Controls.Add(v);
		Controls.Add(u);
		Controls.Add(t);
		Controls.Add(s);
		Controls.Add(q);
		Controls.Add(r);
		Controls.Add(o);
		Controls.Add(p);
		Controls.Add(this.m_m);
		Controls.Add(n);
		Controls.Add(this.m_k);
		Controls.Add(this.m_l);
		Controls.Add(this.m_j);
		Controls.Add(this.m_i);
		Controls.Add(this.m_h);
		Controls.Add(this.m_g);
		Controls.Add(this.m_f);
		Controls.Add(this.m_d);
		Controls.Add(this.m_e);
		Controls.Add(this.m_c);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRpt";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "گزارشات";
		Load += m;
		FormClosing += a;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)this.m_e).EndInit();
		((ISupportInitialize)this.m_f).EndInit();
		w.ResumeLayout(performLayout: false);
		x.ResumeLayout(performLayout: false);
		x.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public asda0()
	{
		f();
        // Optional settings may be NULL or absent in an older bank. Keep a valid
        // comparison baseline before Load reads the persisted values.
        foreach (Control field in new Control[] { this.m_h, p, this.m_l, n, this.m_g }) field.Tag = field.Text;
        af.Tag = af.Checked.ToString();
        ag.Tag = ag.Checked.ToString();
	}

	private void m(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		DataTable dataTable2 = default;
		while (true)
		{
			bool flag = asdaj.a("4");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 8;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 0;
					continue;
				case 7:
					try
					{
						af.Checked = bool.Parse(dataTable2.Rows[0]["showBartar"].ToString());
						af.Tag = dataTable2.Rows[0]["showBartar"].ToString();
						ag.Checked = bool.Parse(dataTable2.Rows[0]["ShowGread"].ToString());
						ag.Tag = dataTable2.Rows[0]["ShowGread"].ToString();
					}
					catch
					{
					}
					num = 1;
					continue;
				case 9:
				{
					OriginalSchoolYears.Select(ad, asdaj.__field_a);
					ah = false;
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					dictionary.Add("0", "تمام گزارشات");
					dictionary.Add("1", "اطلاع نامه");
					dictionary.Add("4", "جدول نتایج");
					dictionary.Add("5", "خلص نتایج");
					dictionary.Add("2", "گزارشات لیستی");
					dictionary.Add("3", "گزارشات آماری و مقایسه ای");
					u.DataSource = new BindingSource(dictionary, null);
					u.DisplayMember = "Value";
					u.ValueMember = "Key";
					ah = true;
					d();
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tParmetr");
					flag = dataTable2.Rows.Count <= 0;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 5:
					num = 10;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 9;
				case 2:
					this.m_h.Text = dataTable2.Rows[0]["Foter1"].ToString();
					p.Text = dataTable2.Rows[0]["Foter2"].ToString();
					this.m_l.Text = dataTable2.Rows[0]["heder1"].ToString();
					n.Text = dataTable2.Rows[0]["heder2"].ToString();
					this.m_g.Text = dataTable2.Rows[0]["sch"].ToString();
					this.m_h.Tag = dataTable2.Rows[0]["Foter1"].ToString();
					p.Tag = dataTable2.Rows[0]["Foter2"].ToString();
					this.m_l.Tag = dataTable2.Rows[0]["heder1"].ToString();
					n.Tag = dataTable2.Rows[0]["heder2"].ToString();
					this.m_g.Tag = dataTable2.Rows[0]["sch"].ToString();
					num = 7;
					continue;
				case 1:
					e();
					c();
					b();
					num = 6;
					continue;
				case 6:
					return;
				case 8:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				case 10:
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
					num = 9;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tExam where xYear=" + ad.SelectedValue.ToString() + " order by NumExam desc");
		this.m_f.DataSource = dataSource;
	}

	private void d()
	{
		string text = default;
		while (true)
		{
			bool flag = !ah;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 5:
					text = text + " and type=" + u.SelectedValue.ToString();
					num = 4;
					continue;
				case 3:
					flag = u.SelectedIndex <= 0;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 4;
				case 0:
					text = " where tosifi is null";
					flag = !(asdab.m == "2");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						if (true)
						{
						}
						num = 7;
						continue;
					}
					goto case 3;
				case 4:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tRpt.*,case countExam when 0 then 'نا محدود' else cast(countExam as nvarchar(2)) end as countTest from tRpt" + text);
					this.m_b.DataSource = dataSource;
					num = 2;
					continue;
				}
				case 2:
					return;
				case 7:
					text = " where tosifi=1";
					num = 3;
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
			r.Items.Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ad.SelectedValue.ToString() + ") order by id");
			r.Items.Add("کل", "0");
			int num = 0;
			if (true)
			{
			}
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 3;
						continue;
					}
					r.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 3:
					r.SelectedIndex = 0;
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
			if (true)
			{
			}
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = r.SelectedIndex <= 0;
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
					goto case 1;
				case 2:
					text = text + " and xPaye=" + r.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + ad.SelectedValue.ToString() + text);
					this.m_e.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void a()
	{
		DataTable dataSource2 = default;
		string a_3 = default;
		SqlParameter[] a_2 = default;
		ReportClass reportClass = default;
		string[] array = default;
		string text3 = default;
		bool flag = default;
		while (true)
		{
			string a_ = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			string text2 = "";
			int num = 0;
			int num2 = 14;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 1:
				case 3:
					dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_3, a_2);
					reportClass = asdd.a(a_);
					flag = !(text != "");
					num2 = 25;
					continue;
				case 25:
					if (!flag)
					{
						num2 = 13;
						continue;
					}
					goto case 27;
				case 28:
					num2 = 30;
					continue;
				case 30:
					num3 = ((!(this.m_b.SelectedItems[0].GetRow().Cells["sp2"].Value.ToString() != "")) ? 1 : 0);
					goto IL_03a8;
				case 29:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_2);
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource);
					num2 = 8;
					continue;
				}
				case 12:
					if (!flag)
					{
						num2 = 17;
						continue;
					}
					goto case 6;
				case 26:
					text3 += ",";
					num2 = 36;
					continue;
				case 13:
					array = text.Split(',');
					flag = array.Length <= 1;
					num2 = 18;
					continue;
				case 18:
					if (!flag)
					{
						num2 = 29;
						continue;
					}
					goto case 8;
				case 0:
					a_3 = this.m_b.SelectedItems[0].GetRow().Cells["sp2"].Value.ToString();
					num2 = 3;
					continue;
				case 10:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_2);
					reportClass.Subreports[array[4].ToString()].SetDataSource(dataSource);
					num2 = 21;
					continue;
				}
				case 38:
					num3 = 1;
					goto IL_03a8;
				case 7:
					if (flag)
					{
						text = text.Replace("spRpt_StdKarnameDoreh1", "spRpt_StdKarnameDoreh2");
						num2 = 1;
					}
					else
					{
						num2 = 0;
					}
					continue;
				case 8:
					flag = array.Length <= 3;
					num2 = 15;
					continue;
				case 15:
					if (!flag)
					{
						num2 = 39;
						continue;
					}
					goto case 5;
				case 21:
					num2 = 27;
					continue;
				case 34:
					if (!flag)
					{
						num2 = 20;
						continue;
					}
					goto case 11;
				case 14:
				case 37:
					flag = num < this.m_f.RowCount;
					num2 = 2;
					continue;
				case 2:
					if (flag)
					{
						flag = !(this.m_f.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 34;
					}
					else
					{
						num2 = 32;
					}
					continue;
				case 23:
					a_2 = new SqlParameter[3]
					{
						asdcb.a("@Exam", SqlDbType.VarChar, text2),
						asdcb.a("@Class", SqlDbType.VarChar, text3),
						asdcb.a("@xYear", SqlDbType.Int, ad.SelectedValue.ToString())
					};
					a_3 = this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString();
					num2 = 40;
					continue;
				case 40:
					num2 = (s.Checked ? 28 : 38);
					continue;
				case 33:
				{
					try
					{
						while (true)
						{
							IL_05a3:
							reportClass.ParameterFields[0].CurrentValues.AddValue(this.m_g.Text);
							reportClass.ParameterFields[1].CurrentValues.AddValue(this.m_l.Text);
							reportClass.ParameterFields[2].CurrentValues.AddValue(n.Text);
							reportClass.ParameterFields[3].CurrentValues.AddValue(this.m_h.Text);
							reportClass.ParameterFields[4].CurrentValues.AddValue(p.Text);
							flag = !(ai != "");
							num2 = 2;
							while (true)
							{
								switch (num2)
								{
								case 2:
									if (!flag)
									{
										num2 = 14;
										continue;
									}
									goto case 8;
								case 6:
								case 11:
									flag = !ag.Checked;
									num2 = 12;
									continue;
								case 12:
									if (!flag)
									{
										num2 = 7;
										continue;
									}
									reportClass.ParameterFields["showGread"].CurrentValues.AddValue("0");
									num2 = 3;
									continue;
								case 3:
								case 5:
									num2 = 10;
									continue;
								case 8:
									flag = !(this.m_b.SelectedItems[0].GetRow().Cells["showBartar"].Value.ToString() == "1");
									num2 = 4;
									continue;
								case 4:
									if (!flag)
									{
										num2 = 0;
										continue;
									}
									goto case 10;
								case 9:
									reportClass.ParameterFields["showBartar"].CurrentValues.AddValue("1");
									num2 = 11;
									continue;
								case 7:
									reportClass.ParameterFields["showGread"].CurrentValues.AddValue("1");
									num2 = 5;
									continue;
								case 14:
									reportClass.ParameterFields[5].CurrentValues.AddValue(ai);
									num2 = 8;
									continue;
								case 0:
									flag = !af.Checked;
									num2 = 13;
									continue;
								case 13:
									if (flag)
									{
										reportClass.ParameterFields["showBartar"].CurrentValues.AddValue("0");
										num2 = 6;
									}
									else
									{
										num2 = 9;
									}
									continue;
								case 10:
									num2 = 1;
									continue;
								case 1:
									goto end_IL_055e;
								}
								goto IL_05a3;
								continue;
								end_IL_055e:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					return;
				}
				case 36:
					text3 += this.m_e.GetRow(num).Cells["id"].Value.ToString();
					if (true)
					{
					}
					num2 = 6;
					continue;
				case 17:
					flag = !(text3 != "");
					num2 = 35;
					continue;
				case 35:
					if (!flag)
					{
						num2 = 26;
						continue;
					}
					goto case 36;
				case 20:
					flag = !(text2 != "");
					num2 = 19;
					continue;
				case 19:
					if (!flag)
					{
						num2 = 22;
						continue;
					}
					goto case 16;
				case 39:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_2);
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource);
					num2 = 5;
					continue;
				}
				case 32:
					text3 = "";
					num = 0;
					num2 = 24;
					continue;
				case 6:
					num++;
					num2 = 4;
					continue;
				case 11:
					num++;
					num2 = 37;
					continue;
				case 22:
					text2 += ",";
					num2 = 16;
					continue;
				case 16:
					text2 += this.m_f.GetRow(num).Cells["id"].Value.ToString();
					num2 = 11;
					continue;
				case 4:
				case 24:
					flag = num < this.m_e.RowCount;
					num2 = 9;
					continue;
				case 9:
					if (flag)
					{
						flag = !(this.m_e.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 12;
					}
					else
					{
						num2 = 23;
					}
					continue;
				case 27:
					reportClass.SetDataSource(dataSource2);
					num2 = 33;
					continue;
				case 5:
					flag = array.Length <= 5;
					num2 = 31;
					continue;
				case 31:
					{
						if (!flag)
						{
							num2 = 10;
							continue;
						}
						goto case 21;
					}
					IL_03a8:
					flag = (byte)num3 != 0;
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		DataTable dataTable2 = default;
		int num4 = default;
		string text = default;
		int num2 = default;
		DataTable dataTable = default;
		bool flag2 = default;
		string text2 = default;
		int num3 = default;
		while (true)
		{
			bool flag = asdab.p >= int.Parse(ad.SelectedValue.ToString());
			int num = 27;
			while (true)
			{
				int num6;
				int num7;
				int num5;
				int num8;
				switch (num)
				{
				case 27:
					if (!flag)
					{
						num = 53;
						continue;
					}
					flag = asdab.p != int.Parse(ad.SelectedValue.ToString());
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 57;
				case 50:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 61;
				case 36:
					MessageBox.Show("برای نمایش این گزارش باید حتما تعداد 2 دوره انتخاب شود");
					num = 104;
					continue;
				case 104:
					return;
				case 96:
					MessageBox.Show("صنفی انتخاب نشده است");
					num = 82;
					continue;
				case 82:
					return;
				case 43:
					flag = !(this.m_b.SelectedItems[0].GetRow().Cells["term"].Value.ToString() == "1");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 28;
						continue;
					}
					MessageBox.Show("این گزارش برای دوره ای که انتخاب کردید قابل نمایش نیست");
					num = 38;
					continue;
				case 5:
					num = 24;
					continue;
				case 24:
					if (!(p.Text != Convert.ToString(p.Tag)))
					{
						num = 47;
						continue;
					}
					goto IL_0c71;
				case 86:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 29;
				case 15:
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select id,procc from tExam where term=1 and xyear=" + ad.SelectedValue.ToString());
					flag = !(dataTable2.Rows[0]["procc"].ToString() != "1");
					num = 69;
					continue;
				case 69:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 0;
				case 38:
					return;
				case 22:
					num = 79;
					continue;
				case 79:
					num6 = ((num4 != 2) ? 1 : 0);
					goto IL_0c47;
				case 30:
					text += ",";
					num = 62;
					continue;
				case 7:
				case 85:
					flag = num2 < this.m_e.RowCount;
					num = 34;
					continue;
				case 34:
					if (!flag)
					{
						num = 89;
						continue;
					}
					flag = !(this.m_e.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
					num = 91;
					continue;
				case 65:
					num7 = 1;
					goto IL_0e7c;
				case 52:
					num = 77;
					continue;
				case 77:
					num7 = ((num4 != 1) ? 1 : 0);
					goto IL_0e7c;
				case 23:
					MessageBox.Show("برای نمایش این گزارش نباید بیشتر از " + num4 + " دوره انتخاب شود");
					num = 59;
					continue;
				case 59:
					return;
				case 6:
					num2++;
					num = 73;
					continue;
				case 60:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 81;
					continue;
				case 81:
					if (1 == 0)
					{
					}
					return;
				case 88:
				{
					SqlParameter[] a_3 = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, dataTable.Rows[0]["id"].ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_3);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_3);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_3);
					num = 56;
					continue;
				}
				case 16:
				{
					SqlParameter[] a_2 = new SqlParameter[7]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, this.m_l.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, n.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, this.m_h.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, p.Text),
						asdcb.a("@sch", SqlDbType.NVarChar, this.m_g.Text),
						asdcb.a("@showBartar", SqlDbType.Bit, af.Checked),
						asdcb.a("@showGread", SqlDbType.Bit, ag.Checked)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_2);
					num = 64;
					continue;
				}
				case 103:
					w.Visible = true;
					ab.Checked = false;
					aa.Checked = false;
					z.Focus();
					num = 25;
					continue;
				case 25:
					return;
				case 46:
					flag2 = ag.Checked;
					num = 14;
					continue;
				case 14:
					num5 = ((!(flag2.ToString() != Convert.ToString(ag.Tag))) ? 1 : 0);
					goto IL_0e33;
				case 57:
					num = 94;
					continue;
				case 94:
					if (!(this.m_h.Text != Convert.ToString(this.m_h.Tag)))
					{
						num = 5;
						continue;
					}
					goto IL_0c71;
				case 64:
					text2 = "";
					num2 = 0;
					num = 7;
					continue;
				case 56:
					num = 6;
					continue;
				case 26:
					text2 += this.m_e.GetRow(num2).Cells["id"].Value.ToString();
					num = 70;
					continue;
				case 61:
				{
					string text3 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + this.m_f.GetRow(num2).Cells["id"].Value.ToString()).ToString();
					flag = !(text3 != "1");
					num = 35;
					continue;
				}
				case 35:
					if (!flag)
					{
						num = 101;
						continue;
					}
					goto case 17;
				case 97:
					num = ((num3 > 1) ? 52 : 65);
					continue;
				case 4:
					num = 19;
					continue;
				case 19:
					if (!(this.m_g.Text != Convert.ToString(this.m_g.Tag)))
					{
						num = 18;
						continue;
					}
					goto IL_0c71;
				case 13:
					num = 76;
					continue;
				case 76:
					num8 = ((num4 <= 0) ? 1 : 0);
					goto IL_0c85;
				case 11:
					num3++;
					flag = !(text != "");
					num = 66;
					continue;
				case 66:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 62;
				case 62:
					text += this.m_f.GetRow(num2).Cells["id"].Value.ToString();
					num = 61;
					continue;
				case 0:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,procc from tExam where term=2 and xyear=" + ad.SelectedValue.ToString());
					flag = !(dataTable.Rows[0]["procc"].ToString() != "1");
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 88;
						continue;
					}
					goto case 56;
				case 91:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 70;
				case 75:
				case 93:
					flag = num2 < this.m_f.RowCount;
					num = 58;
					continue;
				case 58:
					if (!flag)
					{
						num = 78;
						continue;
					}
					flag = !(this.m_f.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
					num = 45;
					continue;
				case 44:
					return;
				case 80:
					flag = !(text2 != "");
					num = 71;
					continue;
				case 71:
					if (!flag)
					{
						num = 68;
						continue;
					}
					goto case 26;
				case 20:
				{
					SqlParameter[] a_4 = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, dataTable2.Rows[0]["id"].ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_4);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_4);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_4);
					num = 0;
					continue;
				}
				case 1:
					num = 51;
					continue;
				case 51:
					if (!(n.Text != Convert.ToString(n.Tag)))
					{
						num = 4;
						continue;
					}
					goto IL_0c71;
				case 84:
					num8 = 1;
					goto IL_0c85;
				case 68:
					text2 += ",";
					num = 26;
					continue;
				case 21:
					num = (flag ? 2 : 36);
					continue;
				case 55:
					num5 = 0;
					goto IL_0e33;
				case 74:
					if (flag)
					{
						flag = !(this.m_b.SelectedItems[0].GetRow().Cells["term"].Value.ToString() != "");
						num = 86;
					}
					else
					{
						num = 23;
					}
					continue;
				case 72:
					num4 = int.Parse(this.m_b.SelectedItems[0].GetRow().Cells["countExam"].Value.ToString());
					flag = !(text == "");
					num = 32;
					continue;
				case 32:
					num = ((!flag) ? 49 : 97);
					continue;
				case 63:
				case 73:
					flag = num2 < this.m_f.RowCount;
					num = 102;
					continue;
				case 102:
					if (flag)
					{
						flag = !(this.m_f.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 50;
					}
					else
					{
						num = 72;
					}
					continue;
				case 28:
					MessageBox.Show("این گزارش برای فقط برای دوره چهار و نیم ماهه قابل نمایش نیست");
					num = 83;
					continue;
				case 83:
					return;
				case 18:
					flag2 = af.Checked;
					num = 67;
					continue;
				case 67:
					if (!(flag2.ToString() != Convert.ToString(af.Tag)))
					{
						num = 46;
						continue;
					}
					goto IL_0c71;
				case 78:
					num = 29;
					continue;
				case 98:
					MessageBox.Show("برای نمایش این گزارش تنها باید یک دوره انتخاب شود");
					num = 33;
					continue;
				case 33:
					return;
				case 12:
					flag = !(asdab.q != asdab.n);
					num = 42;
					continue;
				case 42:
					num = (flag ? 57 : 60);
					continue;
				case 95:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 64;
				case 49:
					MessageBox.Show("دوره ای انتخاب نشده است");
					num = 99;
					continue;
				case 99:
					return;
				case 31:
					num = (flag ? 37 : 98);
					continue;
				case 48:
					num2 = 0;
					num = 93;
					continue;
				case 70:
					num2++;
					num = 85;
					continue;
				case 37:
					num = ((num3 == 2) ? 39 : 22);
					continue;
				case 90:
					num2++;
					num = 75;
					continue;
				case 39:
					num6 = 1;
					goto IL_0c47;
				case 45:
					if (!flag)
					{
						num = 100;
						continue;
					}
					goto case 90;
				case 47:
					num = 87;
					continue;
				case 87:
					if (!(this.m_l.Text != Convert.ToString(this.m_l.Tag)))
					{
						num = 1;
						continue;
					}
					goto IL_0c71;
				case 100:
					flag = !(this.m_b.SelectedItems[0].GetRow().Cells["term"].Value.ToString() != this.m_f.GetRow(num2).Cells["term"].Value.ToString());
					num = 92;
					continue;
				case 92:
					num = ((!flag) ? 43 : 90);
					continue;
				case 17:
				{
					string text4 = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + this.m_f.GetRow(num2).Cells["id"].Value.ToString()).ToString();
					flag = !(text4 == "3");
					num = 40;
					continue;
				}
				case 40:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 6;
				case 89:
					flag = !(text2 == "");
					num = 10;
					continue;
				case 10:
					if (flag)
					{
						text = "";
						num3 = 0;
						num2 = 0;
						num = 63;
					}
					else
					{
						num = 96;
					}
					continue;
				case 29:
					flag = !(this.m_b.SelectedItems[0].GetRow().Cells["sortRpt"].Value.ToString() == "1");
					num = 3;
					continue;
				case 3:
					if (flag)
					{
						a();
						num = 44;
					}
					else
					{
						num = 103;
					}
					continue;
				case 53:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 54;
					continue;
				case 54:
					return;
				case 2:
					num = ((num3 > num4) ? 13 : 84);
					continue;
				case 101:
					{
						SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, this.m_f.GetRow(num2).Cells["id"].Value.ToString()) };
						asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
						asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
						asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
						num = 17;
						continue;
					}
					IL_0e33:
					flag = (byte)num5 != 0;
					num = 95;
					continue;
					IL_0e7c:
					flag = (byte)num7 != 0;
					num = 31;
					continue;
					IL_0c47:
					flag = (byte)num6 != 0;
					num = 21;
					continue;
					IL_0c71:
					num = 55;
					continue;
					IL_0c85:
					flag = (byte)num8 != 0;
					num = 74;
					continue;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void j(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (!(this.m_h.Text != Convert.ToString(this.m_h.Tag)))
					{
						num = 9;
						continue;
					}
					goto IL_0080;
				case 5:
					num2 = 0;
					goto IL_0205;
				case 7:
					num = 4;
					continue;
				case 4:
					num2 = ((!(this.m_g.Text != Convert.ToString(this.m_g.Tag))) ? 1 : 0);
					goto IL_0205;
				case 10:
					num = 3;
					continue;
				case 3:
					if (!(this.m_l.Text != Convert.ToString(this.m_l.Tag)))
					{
						num = 8;
						continue;
					}
					goto IL_0080;
				case 11:
				{
					SqlParameter[] a_ = new SqlParameter[5]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, this.m_l.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, n.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, this.m_h.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, p.Text),
						asdcb.a("@sch", SqlDbType.NVarChar, this.m_g.Text)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_);
					num = 0;
					continue;
				}
				case 0:
					return;
				case 9:
					num = 1;
					continue;
				case 1:
					if (!(p.Text != Convert.ToString(p.Tag)))
					{
						num = 10;
						continue;
					}
					goto IL_0080;
				case 12:
					if (!flag)
					{
						if (true)
						{
						}
						num = 11;
						continue;
					}
					return;
				case 8:
					num = 6;
					continue;
				case 6:
					{
						if (!(n.Text != Convert.ToString(n.Tag)))
						{
							num = 7;
							continue;
						}
						goto IL_0080;
					}
					IL_0205:
					flag = (byte)num2 != 0;
					num = 12;
					continue;
					IL_0080:
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			d();
			bool flag = u.SelectedIndex != 0;
			int num = 1;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 3;
						continue;
					}
					Font font2 = new Font("b nazanin", 12f);
					this.m_b.Font = font2;
					num = 2;
					continue;
				}
				case 2:
					return;
				case 3:
				{
					Font font = new Font("b nazanin", 10f);
					this.m_b.Font = font;
					num = 0;
					continue;
				}
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = (ab.Checked ? 10 : 5);
					continue;
				case 11:
					ai = "1";
					num = 9;
					continue;
				case 7:
					if (!flag)
					{
						num = 11;
						continue;
					}
					ai = "2";
					num = 8;
					continue;
				case 10:
					num2 = 1;
					goto IL_012b;
				case 8:
				case 9:
					a();
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					num = 1;
					continue;
				case 1:
					num2 = (aa.Checked ? 1 : 0);
					goto IL_012b;
				case 0:
					MessageBox.Show("ترتیب نمایش گزارش را مشخص کنید");
					num = 6;
					continue;
				case 6:
					return;
				case 4:
					{
						if (flag)
						{
							if (true)
							{
							}
							flag = !ab.Checked;
							num = 7;
						}
						else
						{
							num = 0;
						}
						continue;
					}
					IL_012b:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		w.Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		w.Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		w.Visible = false;
	}

	private void d(object A_0, EventArgs A_1)
	{
		w.Visible = false;
	}

	private void c(object A_0, EventArgs A_1)
	{
		w.Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		w.Visible = false;
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		e();
		c();
		b();
	}
}
