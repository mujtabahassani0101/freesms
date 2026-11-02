using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdf : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIGroupBox m_c;

	private Label m_d;

	private UIComboBox m_e;

	private Label m_f;

	private UIComboBox m_g;

	private Label m_h;

	private Label m_i;

	private EditBox m_j;

	private EditBox m_k;

	private OpenFileDialog m_l;

	private Panel m_m;

	private GridEX m_n;

	private Label m_o;

	private UIGroupBox m_p;

	private GridEX m_q;

	private Label r;

	private Label s;

	private EditBox t;

	private EditBox u;

	private Label v;

	private UIComboBox w;

	private Label x;

	private UIComboBox y;

	private Label z;

	private UIComboBox aa;

	private UIButton ab;

	private UIButton ac;

	private Label ad;

	private UIButton ae;

	private Label af;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 4;
					}
					continue;
				case 3:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 6;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 6;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 6:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void g()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdf));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat4 = new StringFormat();
		StringFormat stringFormat5 = new StringFormat();
		this.m_b = new Panel();
		ae = new UIButton();
		ad = new Label();
		ab = new UIButton();
		z = new Label();
		aa = new UIComboBox();
		this.m_p = new UIGroupBox();
		r = new Label();
		s = new Label();
		ac = new UIButton();
		t = new EditBox();
		u = new EditBox();
		v = new Label();
		w = new UIComboBox();
		x = new Label();
		y = new UIComboBox();
		this.m_q = new GridEX();
		this.m_c = new UIGroupBox();
		this.m_o = new Label();
		this.m_n = new GridEX();
		this.m_h = new Label();
		this.m_i = new Label();
		this.m_j = new EditBox();
		this.m_k = new EditBox();
		this.m_f = new Label();
		this.m_g = new UIComboBox();
		this.m_d = new Label();
		this.m_e = new UIComboBox();
		this.m_l = new OpenFileDialog();
		this.m_m = new Panel();
		af = new Label();
		this.m_b.SuspendLayout();
		((ISupportInitialize)this.m_p).BeginInit();
		this.m_p.SuspendLayout();
		((ISupportInitialize)this.m_q).BeginInit();
		((ISupportInitialize)this.m_c).BeginInit();
		this.m_c.SuspendLayout();
		((ISupportInitialize)this.m_n).BeginInit();
		this.m_m.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(ae);
		this.m_b.Controls.Add(ad);
		this.m_b.Controls.Add(ab);
		this.m_b.Controls.Add(z);
		this.m_b.Controls.Add(aa);
		this.m_b.Controls.Add(this.m_p);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(5, 5);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(790, 589);
		this.m_b.TabIndex = 0;
		ae.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ae.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ae.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		ae.ImageSize = new Size(40, 40);
		ae.Location = new Point(11, 551);
		ae.Name = "btnClose";
		ae.Size = new Size(125, 33);
		ae.TabIndex = 140;
		ae.Text = "بستن";
		ae.Click += b;
		ad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ad.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ad.ForeColor = Color.FromArgb(128, 64, 64);
		ad.Location = new Point(324, 6);
		ad.Name = "label7";
		ad.Size = new Size(161, 79);
		ad.TabIndex = 139;
		ad.Text = "اختصاص راننده به شاگرد";
		ad.TextAlign = ContentAlignment.MiddleCenter;
		ab.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		ab.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		ab.ImageIndex = 8;
		ab.ImageSize = new Size(30, 30);
		ab.Location = new Point(325, 300);
		ab.Name = "btnNext";
		ab.RightToLeft = RightToLeft.Yes;
		ab.Size = new Size(152, 38);
		ab.TabIndex = 137;
		ab.Tag = "";
		ab.Text = "ثبت موارد انتخاب شده";
		ab.ToolTipText = "دکمه میانبر : PageDown";
		ab.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		ab.Click += d;
		z.AutoSize = true;
		z.Location = new Point(437, 243);
		z.Name = "label41";
		z.Size = new Size(32, 13);
		z.TabIndex = 136;
		z.Text = "راننده";
		aa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		aa.Location = new Point(324, 264);
		aa.Name = "dropDriver";
		aa.Size = new Size(150, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		aa.StringFormat = stringFormat;
		aa.TabIndex = 135;
		aa.SelectedIndexChanged += a;
		this.m_p.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_p.Controls.Add(r);
		this.m_p.Controls.Add(s);
		this.m_p.Controls.Add(ac);
		this.m_p.Controls.Add(t);
		this.m_p.Controls.Add(u);
		this.m_p.Controls.Add(v);
		this.m_p.Controls.Add(w);
		this.m_p.Controls.Add(x);
		this.m_p.Controls.Add(y);
		this.m_p.Controls.Add(this.m_q);
		this.m_p.Location = new Point(10, 4);
		this.m_p.Name = "uiGroupBox2";
		this.m_p.Size = new Size(308, 542);
		this.m_p.TabIndex = 1;
		this.m_p.Text = "لیست دانش آموزان دارای راننده";
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.AutoSize = true;
		r.Location = new Point(236, 132);
		r.Name = "label1";
		r.Size = new Size(48, 13);
		r.TabIndex = 38;
		r.Text = "ولد / بنت";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.AutoSize = true;
		s.Location = new Point(241, 99);
		s.Name = "label2";
		s.Size = new Size(20, 13);
		s.TabIndex = 37;
		s.Text = "نام";
		ac.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ac.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		ac.ImageIndex = 8;
		ac.ImageSize = new Size(30, 30);
		ac.Location = new Point(13, 488);
		ac.Name = "btnPrevious";
		ac.RightToLeft = RightToLeft.Yes;
		ac.Size = new Size(289, 38);
		ac.TabIndex = 138;
		ac.Text = "برگشت مورد انتخاب شده به لیست بدون راننده";
		ac.ToolTipText = "دکمه میانبر : PageUp";
		ac.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		ac.Click += c;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t.Location = new Point(29, 125);
		t.Name = "txtLName2";
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(201, 24);
		t.TabIndex = 33;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.Leave += e;
		t.KeyUp += a;
		t.Enter += g;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u.Location = new Point(29, 93);
		u.Name = "txtFName2";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(201, 24);
		u.TabIndex = 34;
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.Leave += f;
		u.KeyUp += b;
		u.Enter += h;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.AutoSize = true;
		v.Location = new Point(236, 67);
		v.Name = "label3";
		v.Size = new Size(30, 13);
		v.TabIndex = 36;
		v.Text = "صنف";
		w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		w.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		w.DropListFont = new Font("Tahoma", 8.25f);
		w.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w.Location = new Point(29, 63);
		w.Name = "dropCls2";
		w.Size = new Size(201, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		w.StringFormat = stringFormat2;
		w.TabIndex = 32;
		w.SelectedIndexChanged += i;
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.AutoSize = true;
		x.Location = new Point(236, 33);
		x.Name = "label6";
		x.Size = new Size(22, 13);
		x.TabIndex = 35;
		x.Text = "پایه";
		y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		y.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		y.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		y.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y.Location = new Point(29, 28);
		y.Name = "dropPaye2";
		y.Size = new Size(201, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		y.StringFormat = stringFormat3;
		y.TabIndex = 31;
		y.SelectedIndexChanged += j;
		this.m_q.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_q.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_q.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_q.DesignTimeLayout = gridEXLayout;
		this.m_q.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_q.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_q.Location = new Point(5, 164);
		this.m_q.Name = "gridEX2";
		this.m_q.RecordNavigator = true;
		this.m_q.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_q.Size = new Size(297, 305);
		this.m_q.TabIndex = 30;
		this.m_q.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_c.Controls.Add(af);
		this.m_c.Controls.Add(this.m_o);
		this.m_c.Controls.Add(this.m_n);
		this.m_c.Controls.Add(this.m_h);
		this.m_c.Controls.Add(this.m_i);
		this.m_c.Controls.Add(this.m_j);
		this.m_c.Controls.Add(this.m_k);
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Controls.Add(this.m_g);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Location = new Point(491, 6);
		this.m_c.Name = "uiGroupBox1";
		this.m_c.Size = new Size(289, 578);
		this.m_c.TabIndex = 0;
		this.m_c.Text = "لیست دانش آموزان بدون راننده";
		this.m_o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_o.AutoSize = true;
		this.m_o.Location = new Point(218, 29);
		this.m_o.Name = "label10";
		this.m_o.Size = new Size(66, 13);
		this.m_o.TabIndex = 135;
		this.m_o.Text = "سال تعلیمی";
		this.m_n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_n.DesignTimeLayout = gridEXLayout2;
		this.m_n.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_n.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_n.GroupByBoxVisible = false;
		this.m_n.Location = new Point(8, 186);
		this.m_n.Name = "gridEX1";
		this.m_n.RecordNavigator = true;
		this.m_n.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_n.Size = new Size(273, 384);
		this.m_n.TabIndex = 30;
		this.m_n.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.AutoSize = true;
		this.m_h.Location = new Point(216, 160);
		this.m_h.Name = "label5";
		this.m_h.Size = new Size(48, 13);
		this.m_h.TabIndex = 29;
		this.m_h.Text = "ولد / بنت";
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(221, 127);
		this.m_i.Name = "label4";
		this.m_i.Size = new Size(20, 13);
		this.m_i.TabIndex = 28;
		this.m_i.Text = "نام";
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.AutoScroll = false;
		this.m_j.AutoScrollMargin = new Size(0, 0);
		this.m_j.AutoScrollMinSize = new Size(0, 0);
		this.m_j.AutoScrollPosition = new Point(0, 0);
		this.m_j.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_j.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_j.Location = new Point(9, 153);
		this.m_j.Name = "txtLName";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(201, 24);
		this.m_j.TabIndex = 2;
		this.m_j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_j.Leave += n;
		this.m_j.KeyUp += c;
		this.m_j.Enter += m;
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.AutoScroll = false;
		this.m_k.AutoScrollMargin = new Size(0, 0);
		this.m_k.AutoScrollMinSize = new Size(0, 0);
		this.m_k.AutoScrollPosition = new Point(0, 0);
		this.m_k.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_k.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_k.Location = new Point(9, 121);
		this.m_k.Name = "txtFName";
		this.m_k.RightToLeft = RightToLeft.Yes;
		this.m_k.Size = new Size(201, 24);
		this.m_k.TabIndex = 3;
		this.m_k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_k.Leave += k;
		this.m_k.KeyUp += c;
		this.m_k.Enter += l;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.AutoSize = true;
		this.m_f.Location = new Point(216, 95);
		this.m_f.Name = "label19";
		this.m_f.Size = new Size(30, 13);
		this.m_f.TabIndex = 25;
		this.m_f.Text = "صنف";
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_g.DropListFont = new Font("Tahoma", 8.25f);
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_g.Location = new Point(9, 91);
		this.m_g.Name = "dropCls";
		this.m_g.Size = new Size(201, 23);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		this.m_g.StringFormat = stringFormat4;
		this.m_g.TabIndex = 1;
		this.m_g.SelectedIndexChanged += o;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_d.AutoSize = true;
		this.m_d.Location = new Point(216, 61);
		this.m_d.Name = "label20";
		this.m_d.Size = new Size(22, 13);
		this.m_d.TabIndex = 15;
		this.m_d.Text = "پایه";
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_e.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_e.Location = new Point(9, 56);
		this.m_e.Name = "dropPaye";
		this.m_e.Size = new Size(201, 23);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		this.m_e.StringFormat = stringFormat5;
		this.m_e.TabIndex = 0;
		this.m_e.SelectedIndexChanged += p;
		this.m_l.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_l.Title = "انتخاب عکس شاگرد";
		this.m_m.BackColor = Color.Black;
		this.m_m.Controls.Add(this.m_b);
		this.m_m.Dock = DockStyle.Fill;
		this.m_m.Location = new Point(0, 0);
		this.m_m.Name = "panel2";
		this.m_m.Size = new Size(800, 600);
		this.m_m.TabIndex = 1;
		af.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		af.Location = new Point(142, 25);
		af.Name = "lYear";
		af.Size = new Size(68, 24);
		af.TabIndex = 136;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_m);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmDriverStd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست پرداخت های شاگرد";
		Load += q;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)this.m_p).EndInit();
		this.m_p.ResumeLayout(performLayout: false);
		this.m_p.PerformLayout();
		((ISupportInitialize)this.m_q).EndInit();
		((ISupportInitialize)this.m_c).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)this.m_n).EndInit();
		this.m_m.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdf()
	{
		g();
	}

	private void q(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = asdaj.a("2");
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					af.Text = asdaj.__field_a;
					f();
					e();
					c();
					d();
					a();
					b();
					num = 2;
					continue;
				case 2:
					return;
				case 3:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'کل' as  name\r\n                                                                                                                union select id,name from tPaye where id in(" + asdaj.n + ") order by id");
		this.m_e.DataSource = dataSource;
		this.m_e.DisplayMember = "Name";
		this.m_e.ValueMember = "id";
		this.m_e.SelectedIndex = 0;
		y.DataSource = dataSource;
		y.DisplayMember = "Name";
		y.ValueMember = "id";
		y.SelectedIndex = 0;
	}

	private void e()
	{
		while (true)
		{
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_e.SelectedIndex <= 0;
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
					if (true)
					{
					}
					text = text + " and xPaye=" + this.m_e.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + af.Text + text);
					this.m_g.DataSource = dataSource;
					this.m_g.DisplayMember = "Name";
					this.m_g.ValueMember = "id";
					this.m_g.SelectedIndex = 0;
					return;
				}
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
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = y.SelectedIndex <= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 1:
					text = text + " and xPaye=" + y.SelectedValue.ToString();
					num = 2;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + af.Text + text);
					w.DataSource = dataSource;
					w.DisplayMember = "Name";
					w.ValueMember = "id";
					w.SelectedIndex = 0;
					return;
				}
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			string text = " tYear_Student.transport=1 and xDriver=0 and tYear_Student.xyear=" + af.Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = this.m_g.SelectedIndex <= 0;
			int num = 20;
			while (true)
			{
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 14;
				case 7:
					flag = !(this.m_j.Text.Trim() != "");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 11;
				case 3:
					text += " and ";
					num = 10;
					continue;
				case 14:
					flag = this.m_e.SelectedIndex <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 5;
				case 21:
					text = text + " tstudent.LName like '%" + asdaj.b(this.m_j.Text) + "%'";
					if (true)
					{
					}
					num = 11;
					continue;
				case 6:
					text += " and ";
					num = 13;
					continue;
				case 8:
					flag = !(text != "");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 21;
				case 11:
					flag = !(text != "");
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 23;
				case 5:
					flag = !(this.m_k.Text.Trim() != "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 7;
				case 24:
					flag = !(text != "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 17;
				case 2:
					text += " and ";
					num = 21;
					continue;
				case 25:
					text = " where " + text;
					num = 23;
					continue;
				case 12:
					text += " and ";
					num = 17;
					continue;
				case 15:
					flag = !(text != "");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 13;
				case 13:
					text = text + " tYear_Student.xClass=" + this.m_g.SelectedValue.ToString();
					num = 14;
					continue;
				case 17:
					text = text + " tYear_Student.xPaye=" + this.m_e.SelectedValue.ToString();
					num = 5;
					continue;
				case 16:
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 10;
				case 10:
					text = text + " tstudent.FName like '%" + asdaj.b(this.m_k.Text) + "%'";
					num = 7;
					continue;
				case 23:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tYear_Student.id, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName, \r\n                 tClass.name AS Class, tPaye.Name AS Paye,tYear_Student.sort\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text + " order by tYear_Student.sort,tStudent.lname,tStudent.fname");
					this.m_n.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		while (true)
		{
			string text = " tYear_Student.transport=1 and xDriver>0 and tYear_Student.xyear=" + af.Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = aa.SelectedIndex <= 0;
			int num = 17;
			while (true)
			{
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 0;
				case 29:
					text = text + " tstudent.FName like '%" + asdaj.b(u.Text) + "%'";
					num = 28;
					continue;
				case 27:
					flag = !(this.m_k.Text.Trim() != "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 28;
				case 13:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 22;
				case 2:
					text += " and ";
					num = 32;
					continue;
				case 1:
					text = text + " tYear_Student.xDriver=" + aa.SelectedValue.ToString();
					num = 0;
					continue;
				case 28:
					flag = !(this.m_j.Text.Trim() != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 19;
				case 19:
					flag = !(text != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 14;
				case 31:
					text = text + " tYear_Student.xPaye=" + y.SelectedValue.ToString();
					num = 27;
					continue;
				case 30:
					text += " and ";
					num = 22;
					continue;
				case 32:
					text = text + " tstudent.LName like '%" + asdaj.b(t.Text) + "%'";
					num = 19;
					continue;
				case 9:
					text = " where " + text;
					num = 14;
					continue;
				case 16:
					flag = this.m_e.SelectedIndex <= 0;
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 27;
				case 26:
					flag = !(text != "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						if (true)
						{
						}
						num = 7;
						continue;
					}
					goto case 1;
				case 0:
					flag = w.SelectedIndex <= 0;
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 16;
				case 22:
					text = text + " tYear_Student.xClass=" + w.SelectedValue.ToString();
					num = 16;
					continue;
				case 18:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 31;
				case 15:
					flag = !(text != "");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 32;
				case 10:
					text += " and ";
					num = 29;
					continue;
				case 5:
					text += " and ";
					num = 31;
					continue;
				case 7:
					text += " and ";
					num = 1;
					continue;
				case 4:
					flag = !(text != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 29;
				case 14:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tYear_Student.id, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName, \r\n                 tClass.name AS Class, tPaye.Name AS Paye,tYear_Student.sort,tDriver.name as Driver\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tDriver on tYear_Student.xDriver=tDriver.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text + " order by tYear_Student.sort,tStudent.lname,tStudent.fname");
					this.m_q.DataSource = dataSource;
					return;
				}
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tDriver order by name");
		aa.DataSource = dataSource;
		aa.DisplayMember = "Name";
		aa.ValueMember = "id";
		aa.SelectedIndex = 0;
	}

	private void p(object A_0, EventArgs A_1)
	{
		e();
		c();
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = A_1.KeyCode.ToString();
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (A_1.KeyCode != Keys.F5)
					{
						num = 7;
						continue;
					}
					goto IL_0077;
				case 2:
					num = 1;
					continue;
				case 1:
					return;
				case 6:
					num2 = 0;
					goto IL_00e4;
				case 7:
					num = 3;
					continue;
				case 3:
					if (!(text == "Return"))
					{
						num = 9;
						continue;
					}
					goto IL_0077;
				case 5:
					return;
				case 9:
					num = 0;
					continue;
				case 0:
					num2 = ((A_1.KeyCode != Keys.F1) ? 1 : 0);
					goto IL_00e4;
				case 8:
					{
						if (flag)
						{
							c();
							num = 5;
						}
						else
						{
							num = 2;
						}
						continue;
					}
					IL_0077:
					num = 6;
					continue;
					IL_00e4:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		c();
	}

	private void n(object A_0, EventArgs A_1)
	{
		this.m_j.BackColor = Color.White;
	}

	private void m(object A_0, EventArgs A_1)
	{
		this.m_j.BackColor = Color.Yellow;
	}

	private void l(object A_0, EventArgs A_1)
	{
		this.m_k.BackColor = Color.Yellow;
	}

	private void k(object A_0, EventArgs A_1)
	{
		this.m_k.BackColor = Color.White;
	}

	private void j(object A_0, EventArgs A_1)
	{
		d();
		b();
	}

	private void i(object A_0, EventArgs A_1)
	{
		b();
	}

	private void h(object A_0, EventArgs A_1)
	{
		u.BackColor = Color.Yellow;
	}

	private void g(object A_0, EventArgs A_1)
	{
		t.BackColor = Color.Yellow;
	}

	private void f(object A_0, EventArgs A_1)
	{
		u.BackColor = Color.White;
	}

	private void e(object A_0, EventArgs A_1)
	{
		t.BackColor = Color.White;
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		b();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		int num2 = default;
		int num3 = default;
		while (true)
		{
			if (true)
			{
			}
			bool flag = aa.SelectedIndex >= 1;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 9;
						continue;
					}
					num2 = 0;
					num3 = 0;
					num = 7;
					continue;
				case 6:
					flag = num2 != 0;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 0;
						continue;
					}
					c();
					b();
					num = 10;
					continue;
				case 8:
					num3++;
					num = 5;
					continue;
				case 0:
					MessageBox.Show("شاگردی انتخاب نشده است");
					num = 12;
					continue;
				case 12:
					return;
				case 9:
					MessageBox.Show("راننده را انتخاب کنید");
					aa.Focus();
					num = 3;
					continue;
				case 3:
					return;
				case 5:
				case 7:
					flag = num3 < this.m_n.RowCount;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 6;
						continue;
					}
					flag = !(this.m_n.GetRow(num3).Cells["Selector"].Value.ToString() == "True");
					num = 2;
					continue;
				case 10:
					return;
				case 13:
					num2++;
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set xDriver=" + aa.SelectedValue.ToString() + " where id=" + this.m_n.GetRow(num3).Cells["id"].Value.ToString());
					num = 8;
					continue;
				case 2:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
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
						if (this.m_q.RowCount > 0)
						{
							num = 5;
							continue;
						}
						goto IL_0156;
					case 5:
						if (true)
						{
						}
						num = 9;
						continue;
					case 7:
						num = 8;
						continue;
					case 8:
						num2 = ((MessageBox.Show("آيا مطمئن هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1 : 0);
						goto IL_0131;
					case 2:
						asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set xDriver=0 where id=" + this.m_q.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						c();
						b();
						num = 1;
						continue;
					case 9:
						if (this.m_q.SelectedItems[0].RowType == RowType.Record)
						{
							num = 7;
							continue;
						}
						goto IL_0156;
					case 0:
						if (!flag)
						{
							num = 2;
							continue;
						}
						goto case 1;
					case 3:
						num2 = 1;
						goto IL_0131;
					case 1:
						num = 4;
						continue;
					case 4:
						return;
						IL_0156:
						num = 3;
						continue;
						IL_0131:
						flag = (byte)num2 != 0;
						num = 0;
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

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
	}
}
