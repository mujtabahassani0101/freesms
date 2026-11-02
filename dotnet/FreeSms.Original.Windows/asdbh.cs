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
using Janus.Windows.UI;

public class asdbh : Form
{
	private Panel m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private EditBox m_e;

	private Label m_f;

	private EditBox m_g;

	private Label m_h;

	private GridEX m_i;

	private UIButton m_j;

	private Panel m_k;

	private UIButton m_l;

	private UIButton m_m;

	private Label m_n;

	private UIButton o;

	private UIButton p;

	private Label q;

	private UIComboBox r;

	private GridEX s;

	private Label t;

	private NumericEditBox u;

	private NumericEditBox v;

	private Label w;

	private Panel x;

	private Label y;

	private Panel z;

	private RadioButton aa;

	private RadioButton ab;

	private Label ac;

	private NumericEditBox ad;

	private Label ae;

	private TextBox af;

	private Label ag;

	private Container ah = null;

	private SqlConnection ai = new SqlConnection(asdab.e());

	private string aj;

	private bool ak = false;

	private string al = "1";

	private int am = -1;

	private bool an = true;

	public asdbh()
	{
		f();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 0:
					num = 1;
					continue;
				case 3:
					ah.Dispose();
					num = 0;
					continue;
				case 4:
					flag = ah == null;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 1:
					base.Dispose(A_0);
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbh));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_k = new Panel();
		x = new Panel();
		af = new TextBox();
		ae = new Label();
		ac = new Label();
		ad = new NumericEditBox();
		y = new Label();
		this.m_n = new Label();
		s = new GridEX();
		this.m_l = new UIButton();
		o = new UIButton();
		this.m_m = new UIButton();
		p = new UIButton();
		this.m_i = new GridEX();
		this.m_f = new Label();
		this.m_e = new EditBox();
		this.m_d = new UIButton();
		this.m_c = new UIButton();
		this.m_j = new UIButton();
		q = new Label();
		r = new UIComboBox();
		this.m_h = new Label();
		this.m_g = new EditBox();
		t = new Label();
		u = new NumericEditBox();
		v = new NumericEditBox();
		w = new Label();
		z = new Panel();
		aa = new RadioButton();
		ab = new RadioButton();
		ag = new Label();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		this.m_k.SuspendLayout();
		x.SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((ISupportInitialize)this.m_i).BeginInit();
		z.SuspendLayout();
		SuspendLayout();
		this.m_a.BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(5, 6);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(695, 700);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(this.m_k);
		this.m_b.Controls.Add(this.m_i);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(this.m_j);
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(r);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Controls.Add(this.m_g);
		this.m_b.Controls.Add(t);
		this.m_b.Controls.Add(u);
		this.m_b.Controls.Add(v);
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(z);
		this.m_b.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.Size = new Size(679, 680);
		this.m_b.TabIndex = 0;
		this.m_k.BackColor = Color.Silver;
		this.m_k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_k.Controls.Add(x);
		this.m_k.Location = new Point(116, 3);
		this.m_k.Name = "pStdMark";
		this.m_k.Size = new Size(489, 664);
		this.m_k.TabIndex = 74;
		this.m_k.Visible = false;
		x.BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		x.Controls.Add(ag);
		x.Controls.Add(af);
		x.Controls.Add(ae);
		x.Controls.Add(ac);
		x.Controls.Add(ad);
		x.Controls.Add(y);
		x.Controls.Add(this.m_n);
		x.Controls.Add(s);
		x.Controls.Add(this.m_l);
		x.Controls.Add(o);
		x.Controls.Add(this.m_m);
		x.Controls.Add(p);
		x.Location = new Point(3, 3);
		x.Name = "panel3";
		x.Size = new Size(481, 655);
		x.TabIndex = 81;
		af.Enabled = false;
		af.Location = new Point(126, 579);
		af.Name = "txtSumMark";
		af.RightToLeft = RightToLeft.No;
		af.Size = new Size(82, 23);
		af.TabIndex = 89;
		af.TextAlign = HorizontalAlignment.Center;
		ae.AutoSize = true;
		ae.Location = new Point(211, 582);
		ae.Name = "label2";
		ae.Size = new Size(100, 16);
		ae.TabIndex = 87;
		ae.Text = "مجموع نمرات :";
		ac.AutoSize = true;
		ac.Location = new Point(396, 91);
		ac.Name = "label1";
		ac.Size = new Size(49, 16);
		ac.TabIndex = 86;
		ac.Text = "درجه :";
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.ButtonFont = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ad.Location = new Point(324, 86);
		ad.MaxLength = 2;
		ad.Name = "txtGClass";
		ad.RightToLeft = RightToLeft.No;
		ad.Size = new Size(66, 23);
		ad.TabIndex = 1;
		ad.Text = "0";
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		ad.Value = (short)0;
		ad.ValueType = NumericEditValueType.Int16;
		ad.Leave += a;
		ad.KeyUp += a;
		ad.Enter += b;
		y.BackColor = Color.FromArgb(255, 224, 192);
		y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		y.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		y.Location = new Point(293, 36);
		y.Name = "lExam";
		y.RightToLeft = RightToLeft.Yes;
		y.Size = new Size(172, 38);
		y.TabIndex = 82;
		y.TextAlign = ContentAlignment.MiddleCenter;
		this.m_n.BackColor = Color.FromArgb(192, 255, 192);
		this.m_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_n.Font = new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_n.Location = new Point(8, 34);
		this.m_n.Name = "lName";
		this.m_n.RightToLeft = RightToLeft.Yes;
		this.m_n.Size = new Size(279, 42);
		this.m_n.TabIndex = 76;
		this.m_n.TextAlign = ContentAlignment.MiddleCenter;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout5.LayoutString");
		s.DesignTimeLayout = gridEXLayout;
		s.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		s.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		s.Font = new Font("Tahoma", 9.75f);
		s.GroupByBoxVisible = false;
		s.Location = new Point(8, 118);
		s.Name = "gStdMark";
		s.RecordNavigator = true;
		s.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		s.SelectedFormatStyle.BackColor = Color.Empty;
		s.SelectedFormatStyle.ForeColor = Color.Empty;
		s.Size = new Size(458, 452);
		s.TabIndex = 2;
		s.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		s.SelectionChanged += d;
		s.KeyUp += e;
		s.CellUpdated += a;
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_l.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		this.m_l.ImageIndex = 8;
		this.m_l.ImageSize = new Size(30, 30);
		this.m_l.Location = new Point(88, 2);
		this.m_l.Name = "btnPrevious";
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.Size = new Size(190, 26);
		this.m_l.TabIndex = 75;
		this.m_l.Text = "(pageUp)    قبلی  ";
		this.m_l.ToolTipText = "دکمه میانبر : PageUp";
		this.m_l.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_l.Click += h;
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		o.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		o.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Image = (Image)componentResourceManager.GetObject("btnAcptest.Image");
		o.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Empty;
		o.ImageIndex = 8;
		o.ImageSize = new Size(50, 50);
		o.Location = new Point(156, 612);
		o.Name = "btnAcptest";
		o.Size = new Size(144, 38);
		o.TabIndex = 77;
		o.Text = "(F5)تائيد";
		o.ToolTipText = "دکمه میانبر : F5";
		o.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		o.Click += g;
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		this.m_m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_m.ImageIndex = 8;
		this.m_m.ImageSize = new Size(30, 30);
		this.m_m.Location = new Point(281, 2);
		this.m_m.Name = "btnNext";
		this.m_m.RightToLeft = RightToLeft.Yes;
		this.m_m.Size = new Size(185, 26);
		this.m_m.TabIndex = 74;
		this.m_m.Tag = "";
		this.m_m.Text = "(pageDown)    بعدی  ";
		this.m_m.ToolTipText = "دکمه میانبر : PageDown";
		this.m_m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_m.Click += i;
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		p.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		p.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		p.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		p.ImageIndex = 8;
		p.ImageSize = new Size(30, 30);
		p.Location = new Point(8, 612);
		p.Name = "btnCancel";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(142, 38);
		p.TabIndex = 78;
		p.Text = "(Esc)انصراف";
		p.ToolTipText = "دکمه میانبر : Esc";
		p.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		p.Click += m;
		this.m_i.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_i.CardCaptionPrefix = "Product:";
		this.m_i.Cursor = Cursors.Default;
		this.m_i.DataMember = null;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout6.LayoutString");
		this.m_i.DesignTimeLayout = gridEXLayout2;
		this.m_i.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_i.FlatBorderColor = SystemColors.ControlDark;
		this.m_i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
		this.m_i.GridLineColor = SystemColors.ScrollBar;
		this.m_i.GroupByBoxVisible = false;
		this.m_i.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_i.Location = new Point(7, 124);
		this.m_i.Name = "gstd";
		this.m_i.RecordNavigator = true;
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_i.SelectedFormatStyle.Blend = 0.5f;
		this.m_i.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_i.Size = new Size(657, 490);
		this.m_i.TabIndex = 67;
		this.m_i.TabStop = false;
		this.m_i.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_i.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.SelectionChanged += f;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.Location = new Point(321, 10);
		this.m_f.Name = "label12";
		this.m_f.RightToLeft = RightToLeft.Yes;
		this.m_f.Size = new Size(60, 26);
		this.m_f.TabIndex = 59;
		this.m_f.Text = "نام :";
		this.m_f.TextAlign = ContentAlignment.MiddleRight;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoScroll = false;
		this.m_e.AutoScrollMargin = new Size(0, 0);
		this.m_e.AutoScrollMinSize = new Size(0, 0);
		this.m_e.AutoScrollPosition = new Point(0, 0);
		this.m_e.Location = new Point(177, 10);
		this.m_e.Name = "txtNamFSearch";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(138, 23);
		this.m_e.TabIndex = 7;
		this.m_e.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_e.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_e.KeyUp += c;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_d.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_d.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_d.ImageIndex = 8;
		this.m_d.ImageSize = new Size(30, 30);
		this.m_d.Location = new Point(7, 624);
		this.m_d.Name = "uiButton2";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.Size = new Size(104, 31);
		this.m_d.TabIndex = 65;
		this.m_d.Text = "خروج";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += l;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_c.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_c.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_c.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_c.ImageIndex = 8;
		this.m_c.Location = new Point(500, 625);
		this.m_c.Name = "btnNew";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(164, 32);
		this.m_c.TabIndex = 62;
		this.m_c.Text = "(F2)ورود نمرات";
		this.m_c.ToolTipText = "دکمه میانبر : F2";
		this.m_c.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_c.Click += j;
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnSearch.Image");
		this.m_j.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_j.ImageIndex = 8;
		this.m_j.ImageSize = new Size(30, 30);
		this.m_j.Location = new Point(177, 67);
		this.m_j.Name = "btnSearch";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(138, 31);
		this.m_j.TabIndex = 73;
		this.m_j.Text = "جستجو اسم(F3)";
		this.m_j.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_j.Click += k;
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.AutoSize = true;
		q.Location = new Point(593, 16);
		q.Name = "label19";
		q.Size = new Size(48, 16);
		q.TabIndex = 78;
		q.Text = "صنف :";
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		r.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		r.Location = new Point(416, 13);
		r.Name = "dropCls";
		r.Size = new Size(171, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		r.StringFormat = stringFormat;
		r.TabIndex = 76;
		r.SelectedIndexChanged += e;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.Location = new Point(321, 36);
		this.m_h.Name = "label13";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(78, 28);
		this.m_h.TabIndex = 60;
		this.m_h.Text = "ولد /بنت :";
		this.m_h.TextAlign = ContentAlignment.MiddleRight;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.AutoScroll = false;
		this.m_g.AutoScrollMargin = new Size(0, 0);
		this.m_g.AutoScrollMinSize = new Size(0, 0);
		this.m_g.AutoScrollPosition = new Point(0, 0);
		this.m_g.Location = new Point(177, 39);
		this.m_g.Name = "txtNamLSearch";
		this.m_g.RightToLeft = RightToLeft.Yes;
		this.m_g.Size = new Size(138, 23);
		this.m_g.TabIndex = 6;
		this.m_g.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_g.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_g.KeyUp += d;
		t.AutoSize = true;
		t.Location = new Point(65, 39);
		t.Name = "label4";
		t.Size = new Size(25, 16);
		t.TabIndex = 84;
		t.Text = "تا :";
		t.Visible = false;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.Location = new Point(7, 36);
		u.Name = "txtMaxMark";
		u.Size = new Size(52, 23);
		u.TabIndex = 83;
		u.Text = "100";
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.Value = (short)100;
		u.ValueType = NumericEditValueType.Int16;
		u.Visible = false;
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.Location = new Point(7, 9);
		v.Name = "txtMinMark";
		v.Size = new Size(52, 23);
		v.TabIndex = 82;
		v.Text = "0";
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		v.Value = (short)0;
		v.ValueType = NumericEditValueType.Int16;
		v.Visible = false;
		w.AutoSize = true;
		w.Location = new Point(65, 10);
		w.Name = "label3";
		w.Size = new Size(83, 16);
		w.TabIndex = 81;
		w.Text = "رنج نمره از :";
		w.Visible = false;
		z.BackColor = Color.FromArgb(255, 192, 255);
		z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		z.Controls.Add(aa);
		z.Controls.Add(ab);
		z.Location = new Point(407, 48);
		z.Name = "panel4";
		z.Size = new Size(185, 58);
		z.TabIndex = 85;
		aa.AutoSize = true;
		aa.Location = new Point(29, 30);
		aa.Name = "r11";
		aa.Size = new Size(142, 20);
		aa.TabIndex = 1;
		aa.Text = "نمرات صنف یازدهم";
		aa.UseVisualStyleBackColor = true;
		ab.AutoSize = true;
		ab.Checked = true;
		ab.Location = new Point(43, 3);
		ab.Name = "r10";
		ab.Size = new Size(128, 20);
		ab.TabIndex = 0;
		ab.TabStop = true;
		ab.Text = "نمرات صنف دهم";
		ab.UseVisualStyleBackColor = true;
		ab.CheckedChanged += c;
		ag.AutoSize = true;
		ag.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.ForeColor = Color.Maroon;
		ag.Location = new Point(9, 91);
		ag.Name = "label5";
		ag.Size = new Size(292, 16);
		ag.TabIndex = 90;
		ag.Text = "راهنمای درجه : 1 (الف)   2 (ب)   3(ج)   4 (د)   5(ه)";
		AutoScaleBaseSize = new Size(8, 26);
		BackColor = Color.FromArgb(184, 203, 255);
		ClientSize = new Size(706, 714);
		Controls.Add(this.m_a);
		Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmMarkEntryAgo";
		StartPosition = FormStartPosition.CenterScreen;
		Tag = "10";
		Text = "اطلاعات داوطلبان";
		Load += n;
		KeyUp += b;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		this.m_k.ResumeLayout(performLayout: false);
		x.ResumeLayout(performLayout: false);
		x.PerformLayout();
		((ISupportInitialize)s).EndInit();
		((ISupportInitialize)this.m_i).EndInit();
		z.ResumeLayout(performLayout: false);
		z.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void e()
	{
		while (true)
		{
			string text = " where xPaye in(" + asdaj.n + ") and id in(SELECT DISTINCT xClass FROM tyear_student WHERE xYear=" + asdaj.__field_a + " and (xPaye = 12))";
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass " + text);
			r.DataSource = dataSource;
			r.DisplayMember = "Name";
			r.ValueMember = "id";
			bool flag = r.Items.Count <= 0;
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
					return;
				case 1:
					r.SelectedIndex = 0;
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		DataTable dataTable = default;
		while (true)
		{
			string text = "";
			string text2 = "10";
			bool flag = !aa.Checked;
			int num = 21;
			while (true)
			{
				switch (num)
				{
				case 21:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 5;
				case 18:
					flag = !(text != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 0;
				case 10:
					text += " and ";
					num = 3;
					continue;
				case 19:
					this.m_e.Text = asdaj.b(this.m_e.Text.Trim());
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 16;
				case 0:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tmpstd.sort, tmpstd.id, tmpstd.Code, tmpstd.FName, tmpstd.LName, tmpstd.PName,tmpMark.Mark,tmpMark.gclass from\r\n                    (SELECT     tYear_Student.sort, tStudent.id, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.NumberAsas\r\n                    FROM tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                    WHERE   (tYear_Student.xYear = " + asdaj.__field_a + ") AND tYear_Student.xClass = " + r.SelectedValue.ToString() + text + ") tmpstd left outer join\r\n                    (SELECT     xStudent, mark,gClass\r\n                    FROM         tMarkAgo\r\n                    WHERE     (typ = 5) AND (xpaye = " + text2 + ")) tmpMark on tmpstd.id=tmpMark.xStudent");
					flag = dataTable.Rows.Count <= 0;
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 2;
						continue;
					}
					this.m_i.DataSource = null;
					num = 14;
					continue;
				case 5:
					flag = !(this.m_e.Text.Trim() != "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto IL_0382;
				case 8:
					text = " and " + text;
					num = 0;
					continue;
				case 14:
					return;
				case 11:
					this.m_g.Text = asdaj.b(this.m_g.Text.Trim());
					flag = !(text != "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 3;
				case 1:
					text += " and ";
					num = 16;
					continue;
				case 2:
					this.m_i.DataSource = dataTable;
					num = 15;
					continue;
				case 15:
					return;
				case 3:
					text = text + " tStudent.LName Like N'%" + this.m_g.Text + "%'";
					num = 18;
					continue;
				case 16:
					text = text + " tStudent.FName Like N'%" + this.m_e.Text + "%'";
					num = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_0382;
				case 12:
					text2 = "11";
					num = 5;
					continue;
				case 4:
					{
						if (!flag)
						{
							num = 11;
							continue;
						}
						goto case 18;
					}
					IL_0382:
					flag = !(this.m_g.Text.Trim() != "");
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		DataTable dataTable2 = default;
		DataTable dataTable = default;
		while (true)
		{
			string text = "10";
			bool flag = !aa.Checked;
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
					goto case 9;
				case 8:
				case 10:
				{
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(s.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					s.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(s.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					s.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select  gClass,mark from tMarkAgo where  typ=5 and xpaye= " + text + " and xStudent= " + this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					flag = dataTable2.Rows.Count <= 0;
					num = 5;
					continue;
				}
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					af.Text = "";
					ad.Text = "";
					num = 4;
					continue;
				case 9:
					this.m_n.Text = this.m_i.SelectedItems[0].GetRow().Cells["FName"].Value.ToString() + " " + this.m_i.SelectedItems[0].GetRow().Cells["LName"].Value.ToString();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select  0 as acp,    tmpbok.xbook, tmpbok.book, tmpbok.SortOneEntry,tmpbok.sort,tmpmark.mark as M1\r\n                    \r\n                    from\r\n                    (SELECT     id as xbook, Name as book, SortOneEntry,sort\r\n                        FROM         tBook\r\n                      WHERE     (xPaye = 12) AND (showOneEntry = 1))tmpbok\r\n                        left outer join\r\n                       (SELECT     xStudent, xbook, mark         \r\n                        FROM         tMarkAgo where  typ=1 and xpaye= " + text + " and xStudent= " + this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")tmpmark on tmpbok.xbook=tmpmark.xbook order by tmpbok.sort,tmpbok.xbook");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						s.DataSource = null;
						num = 8;
					}
					else
					{
						num = 3;
					}
					continue;
				case 4:
					if (1 == 0)
					{
					}
					return;
				case 0:
					text = "11";
					num = 9;
					continue;
				case 7:
					af.Text = dataTable2.Rows[0]["mark"].ToString();
					ad.Text = dataTable2.Rows[0]["gClass"].ToString();
					num = 2;
					continue;
				case 2:
					return;
				case 3:
					s.DataSource = dataTable;
					num = 10;
					continue;
				}
				break;
			}
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					if (true)
					{
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 7:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_b.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 2:
					e();
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		this.m_k.Visible = false;
		d();
	}

	private void l(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void k(object A_0, EventArgs A_1)
	{
		d();
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_i.RowCount <= 0;
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
				case 3:
					y.Text = "نمرات صنف دهم";
					num = 4;
					continue;
				case 0:
					if (true)
					{
					}
					this.m_k.Visible = true;
					aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					c();
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					flag = !ab.Checked;
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						y.Text = "نمرات صنف یازدهم";
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				case 2:
				case 4:
					ad.Focus();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_i.MoveNext();
		aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		c();
		s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
		s.Select();
		s.SelectCurrentCellText();
		ad.Focus();
	}

	private void b()
	{
		while (true)
		{
			bool flag = this.m_i.Row != 0;
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
					this.m_l.Enabled = true;
					num = 3;
					continue;
				case 6:
					this.m_m.Enabled = false;
					num = 4;
					continue;
				case 4:
					return;
				case 3:
				case 7:
					flag = this.m_i.Row != this.m_i.RecordCount - 1;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					this.m_m.Enabled = true;
					num = 1;
					continue;
				case 5:
					this.m_l.Enabled = false;
					num = 7;
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

	private void h(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_i.MovePrevious();
		aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		c();
		s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
		s.Select();
		s.SelectCurrentCellText();
		ad.Focus();
	}

	private void g(object A_0, EventArgs A_1)
	{
		SqlCommand sqlCommand = default;
		int num6 = default;
		string text = default;
		float num4 = default;
		int num2 = default;
		int num3 = default;
		string value2 = default;
		int num5 = default;
		while (true)
		{
			string value = "10";
			bool flag = !aa.Checked;
			int num = 19;
			while (true)
			{
				int num9;
				int num8;
				switch (num)
				{
				case 19:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 25;
				case 41:
					num9 = 1;
					goto IL_0ab1;
				case 1:
					num8 = 0;
					goto IL_08b7;
				case 17:
					flag = ak;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 14;
				case 15:
					num = 3;
					continue;
				case 3:
					num9 = ((!(ad.Text != "")) ? 1 : 0);
					goto IL_0ab1;
				case 39:
					num = 9;
					continue;
				case 9:
					num8 = ((!(af.Text == "")) ? 1 : 0);
					goto IL_08b7;
				case 27:
					sqlCommand = new SqlCommand("DELETE FROM tMarkAgo WHERE (xStudent = @xStudent) AND (xpaye = @xpaye) AND (xbook = @xbook)", ai);
					sqlCommand.Parameters.AddWithValue("@xStudent", aj);
					sqlCommand.Parameters.AddWithValue("@xpaye", value);
					sqlCommand.Parameters.AddWithValue("@xbook", s.GetRow(num6).Cells["xbook"].Text.ToString());
					sqlCommand.ExecuteNonQuery();
					num = 22;
					continue;
				case 23:
					i(this, null);
					ad.Focus();
					num = 12;
					continue;
				case 4:
					return;
				case 31:
					value = "11";
					num = 25;
					continue;
				case 38:
					try
					{
						while (true)
						{
							IL_0377:
							flag = !(s.GetRow(num6).Cells["m1"].Text != "");
							num = 5;
							while (true)
							{
								int num7;
								switch (num)
								{
								case 5:
									if (!flag)
									{
										num = 4;
										continue;
									}
									text = null;
									num = 1;
									continue;
								case 7:
									num = 2;
									continue;
								case 2:
									num7 = ((!(num4 < (float)num2)) ? 1 : 0);
									goto IL_0501;
								case 4:
									num4 = float.Parse(s.GetRow(num6).Cells["m1"].Text.ToString());
									num = 3;
									continue;
								case 3:
									num = ((!(num4 > (float)num3)) ? 7 : 0);
									continue;
								case 0:
									num7 = 0;
									goto IL_0501;
								case 9:
									s.GetRow(num6).Cells["m1"].FormatStyle.BackColor = Color.Yellow;
									s.GetRow(num6).BeginEdit();
									s.GetRow(num6).Cells["acp"].Value = "-1";
									s.GetRow(num6).EndEdit();
									ak = true;
									num = 8;
									continue;
								case 8:
									goto end_IL_033e;
								case 10:
									if (flag)
									{
										text = num4.ToString();
										num = 11;
									}
									else
									{
										num = 9;
									}
									continue;
								case 1:
								case 11:
									num = 6;
									continue;
								case 6:
									goto IL_0702;
									IL_0501:
									flag = (byte)num7 != 0;
									num = 10;
									continue;
								}
								goto IL_0377;
								continue;
								end_IL_033e:
								break;
							}
							break;
						}
					}
					catch
					{
						s.GetRow(num6).BeginEdit();
						s.GetRow(num6).Cells["acp"].Value = "-1";
						s.GetRow(num6).EndEdit();
						ak = true;
					}
					goto case 8;
				case 32:
					sqlCommand.Parameters.AddWithValue("@Mark", DBNull.Value);
					num = 5;
					continue;
				case 44:
					flag = MessageBox.Show("اطلاعات ذخیره شد . آیا مایل هستید نفر بعدی نمایش داده شود", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
					num = 43;
					continue;
				case 43:
					num = ((!flag) ? 23 : 40);
					continue;
				case 10:
					value2 = ad.Text;
					num = 28;
					continue;
				case 6:
					num = 46;
					continue;
				case 29:
				case 46:
					num = 8;
					continue;
				case 35:
					sqlCommand = new SqlCommand("DELETE FROM tMarkAgo WHERE (xStudent = @xStudent) AND (xpaye = @xpaye) AND (typ =5)", ai);
					sqlCommand.Parameters.AddWithValue("@xStudent", aj);
					sqlCommand.Parameters.AddWithValue("@xpaye", value);
					sqlCommand.ExecuteNonQuery();
					num = 7;
					continue;
				case 16:
					if (!flag)
					{
						num = 27;
						continue;
					}
					s.GetRow(num6).BeginEdit();
					s.GetRow(num6).Cells["acp"].Value = "1";
					s.GetRow(num6).EndEdit();
					sqlCommand = new SqlCommand("sp_tMarkAgo_insertUpdate", ai);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xStudent", aj);
					sqlCommand.Parameters.AddWithValue("@xpaye", value);
					sqlCommand.Parameters.AddWithValue("@xbook", s.GetRow(num6).Cells["xbook"].Text.ToString());
					flag = text != null;
					num = 0;
					continue;
				case 7:
				case 21:
					ai.Close();
					flag = this.m_i.Row >= this.m_i.RowCount - 1;
					num = 36;
					continue;
				case 36:
					if (flag)
					{
						MessageBox.Show("اطلاعات ذخیره شد");
						this.m_k.Visible = false;
						d();
						num = 4;
					}
					else
					{
						num = 17;
					}
					continue;
				case 0:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@Mark", text);
						num = 26;
					}
					else
					{
						num = 32;
					}
					continue;
				case 5:
				case 26:
				{
					int num10 = sqlCommand.ExecuteNonQuery();
					flag = num10 >= 1;
					num = 24;
					continue;
				}
				case 24:
					if (flag)
					{
						al = "0";
						num5++;
						num = 29;
					}
					else
					{
						num = 6;
					}
					continue;
				case 45:
					if (!flag)
					{
						num = 35;
						continue;
					}
					sqlCommand = new SqlCommand("if not exists(select id from tMarkAgo where xStudent=@xStudent and xPaye=@xPaye and  typ=5)\r\n\t                    INSERT INTO tMarkAgo\r\n\t                                          (xStudent, xPaye,typ, xbook, Mark,gClass)\r\n\t                    VALUES      (@xStudent, @xPaye,5, -5, @Mark , @gClass)\r\n                    else \r\n\t                    UPDATE    tMarkAgo\r\n\t                    SET  Mark =@Mark ,gClass=@gClass\r\n\t                    where xStudent=@xStudent and xPaye=@xPaye and  typ=5", ai);
					value2 = "0";
					num = 2;
					continue;
				case 25:
				{
					sqlCommand = null;
					SqlConnection sqlConnection = new SqlConnection(asdab.e());
					ak = false;
					num2 = 0;
					num = 18;
					continue;
				}
				case 2:
					num = ((ad.Text != "0") ? 15 : 41);
					continue;
				case 30:
				case 33:
					flag = num6 < s.RowCount;
					num = 42;
					continue;
				case 42:
					if (flag)
					{
						if (true)
						{
						}
						text = "";
						num = 38;
					}
					else
					{
						num = 34;
					}
					continue;
				case 12:
				case 40:
					num = 14;
					continue;
				case 34:
					s.Refresh();
					a();
					num = 20;
					continue;
				case 20:
					num = ((af.Text == "0") ? 1 : 39);
					continue;
				case 14:
					num = 37;
					continue;
				case 37:
					return;
				case 18:
					try
					{
						num2 = int.Parse(v.Text);
					}
					catch
					{
					}
					num3 = int.Parse(u.Text);
					text = "";
					num4 = 0f;
					num5 = 0;
					ai.Open();
					num6 = 0;
					num = 33;
					continue;
				case 8:
				case 22:
					num6++;
					num = 30;
					continue;
				case 28:
					sqlCommand.Parameters.AddWithValue("@xStudent", aj);
					sqlCommand.Parameters.AddWithValue("@xpaye", value);
					sqlCommand.Parameters.AddWithValue("@Mark", af.Text);
					sqlCommand.Parameters.AddWithValue("@gClass", value2);
					sqlCommand.ExecuteNonQuery();
					num = 21;
					continue;
				case 11:
					{
						if (!flag)
						{
							num = 10;
							continue;
						}
						goto case 28;
					}
					IL_0702:
					flag = text != null;
					num = 16;
					continue;
					IL_08b7:
					flag = (byte)num8 != 0;
					num = 45;
					continue;
					IL_0ab1:
					flag = (byte)num9 != 0;
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_i.RowCount <= 0;
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
					b();
					aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					c();
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, KeyEventArgs A_1)
	{
	}

	private void e(object A_0, EventArgs A_1)
	{
		m(this, null);
		d();
	}

	private void d(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.F3;
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
					goto case 0;
				case 2:
					d();
					num = 0;
					continue;
				case 0:
					this.m_g.Focus();
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F3;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 2:
					d();
					num = 1;
					continue;
				case 1:
					this.m_e.Focus();
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F2;
			if (true)
			{
			}
			int num = 10;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 10:
					num = ((!flag) ? 1 : 3);
					continue;
				case 2:
					if (!flag)
					{
						num = 19;
						continue;
					}
					flag = A_1.KeyCode != Keys.Escape;
					num = 5;
					continue;
				case 7:
					an = true;
					s.Refresh();
					g(this, null);
					num = 21;
					continue;
				case 23:
					num2 = 1;
					goto IL_026b;
				case 5:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 0;
				case 3:
					num = ((A_1.KeyCode == Keys.F3) ? 18 : 23);
					continue;
				case 20:
					i(this, null);
					num = 15;
					continue;
				case 0:
				case 9:
				case 15:
				case 21:
					num = 6;
					continue;
				case 6:
					return;
				case 16:
					flag = A_1.KeyCode != Keys.F5;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 7;
						continue;
					}
					flag = A_1.KeyCode != Keys.Next;
					num = 14;
					continue;
				case 18:
					num = 4;
					continue;
				case 4:
					num2 = (this.m_k.Visible ? 1 : 0);
					goto IL_026b;
				case 24:
					m(this, null);
					num = 0;
					continue;
				case 19:
					h(this, null);
					num = 9;
					continue;
				case 13:
					d();
					num = 17;
					continue;
				case 1:
					j(this, null);
					num = 22;
					continue;
				case 8:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 17;
				case 17:
				case 22:
					flag = !this.m_k.Visible;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 14:
					{
						if (flag)
						{
							flag = A_1.KeyCode != Keys.Prior;
							num = 2;
						}
						else
						{
							num = 20;
						}
						continue;
					}
					IL_026b:
					flag = (byte)num2 != 0;
					num = 8;
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
			bool flag = !(A_1.Column.Key == "SortOneEntry");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					num2 = 0;
					num = 5;
					continue;
				case 0:
					try
					{
						while (true)
						{
							IL_008d:
							int num4 = int.Parse(s.GetRow(s.Row).Cells["m1"].Text.ToString());
							num = 6;
							while (true)
							{
								int num5;
								switch (num)
								{
								case 6:
									num = ((num4 <= num3) ? 7 : 0);
									continue;
								case 0:
									num5 = 0;
									goto IL_0281;
								case 8:
									am = s.Row;
									s.GetRow(s.Row).BeginEdit();
									s.GetRow(s.Row).Cells["acp"].Value = "-1";
									s.GetRow(s.Row).Cells["m1"].Value = num4;
									s.GetRow(s.Row).EndEdit();
									num = 5;
									continue;
								case 7:
									num = 3;
									continue;
								case 3:
									num5 = ((num4 >= num2) ? 1 : 0);
									goto IL_0281;
								case 4:
									if (flag)
									{
										am = -1;
										s.GetRow(s.Row).BeginEdit();
										s.GetRow(s.Row).Cells["acp"].Value = "0";
										s.GetRow(s.Row).Cells["m1"].Value = num4;
										s.GetRow(s.Row).EndEdit();
										num = 1;
									}
									else
									{
										num = 8;
									}
									continue;
								case 1:
								case 5:
									num = 2;
									continue;
								case 2:
									goto end_IL_0060;
									IL_0281:
									flag = (byte)num5 != 0;
									num = 4;
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
						am = -1;
						s.GetRow(s.Row).BeginEdit();
						s.GetRow(s.Row).Cells["acp"].Value = "0";
						s.GetRow(s.Row).Cells["m1"].Value = DBNull.Value;
						s.GetRow(s.Row).EndEdit();
					}
					a();
					num = 4;
					continue;
				case 4:
					return;
				case 1:
					asdcb.d(asdab.e(), CommandType.Text, "update tbook set SortOneEntry=" + s.GetRow(s.Row).Cells["SortOneEntry"].Value.ToString() + " where id=" + s.GetRow(s.Row).Cells["xbook"].Value.ToString());
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					try
					{
						num2 = int.Parse(v.Text);
					}
					catch
					{
					}
					num3 = int.Parse(u.Text);
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		int num4 = default;
		int num5 = default;
		int num7 = default;
		int num3 = default;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						while (true)
						{
							IL_0083:
							flag = !(s.GetRow(num4).Cells["m1"].Text != "");
							num2 = 6;
							while (true)
							{
								int num6;
								switch (num2)
								{
								case 6:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									goto case 1;
								case 7:
									s.GetRow(num4).Cells["m1"].FormatStyle.BackColor = Color.Yellow;
									s.GetRow(num4).BeginEdit();
									s.GetRow(num4).Cells["acp"].Value = "-1";
									s.GetRow(num4).EndEdit();
									ak = true;
									num2 = 10;
									continue;
								case 10:
									goto end_IL_004e;
								case 2:
									num2 = 9;
									continue;
								case 9:
									num6 = ((num5 >= num) ? 1 : 0);
									goto IL_0205;
								case 3:
									num5 = int.Parse(s.GetRow(num4).Cells["m1"].Text.ToString());
									num2 = 0;
									continue;
								case 0:
									num2 = ((num5 > num7) ? 8 : 2);
									continue;
								case 8:
									num6 = 0;
									goto IL_0205;
								case 5:
									if (flag)
									{
										string text = num5.ToString();
										num3 += num5;
										num2 = 1;
									}
									else
									{
										num2 = 7;
									}
									continue;
								case 1:
									num2 = 4;
									continue;
								case 4:
									{
										if (1 == 0)
										{
										}
										goto IL_003a;
									}
									IL_0205:
									flag = (byte)num6 != 0;
									num2 = 5;
									continue;
								}
								goto IL_0083;
								continue;
								end_IL_004e:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					goto case 1;
				case 1:
					num4++;
					num2 = 2;
					continue;
				case 0:
				{
					try
					{
						num = int.Parse(v.Text);
					}
					catch
					{
					}
					num7 = int.Parse(u.Text);
					num3 = 0;
					string text = "";
					num4 = 0;
					num2 = 5;
					continue;
				}
				case 2:
				case 5:
					flag = num4 < s.RowCount;
					num2 = 4;
					continue;
				case 4:
					num2 = (flag ? 6 : 3);
					continue;
				case 3:
					{
						af.Text = num3.ToString();
						return;
					}
					IL_003a:
					num2 = 1;
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
			if (true)
			{
			}
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((am < 0) ? 4 : 0);
					continue;
				case 0:
					num = 3;
					continue;
				case 3:
					num2 = ((s.Row == am) ? 1 : 0);
					goto IL_00e6;
				case 2:
					s.Row = am;
					MessageBox.Show("نمره وارد شده خارج از محدوده است");
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					num = 1;
					continue;
				case 1:
					return;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 4:
					{
						num2 = 1;
						goto IL_00e6;
					}
					IL_00e6:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		d();
	}

	private void b(object A_0, EventArgs A_1)
	{
		ad.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		ad.BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Return;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 3:
					s.Focus();
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					s.Select();
					s.SelectCurrentCellText();
					num = 2;
					continue;
				case 4:
					if (true)
					{
					}
					flag = an;
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						an = false;
						num = 0;
					}
					else
					{
						num = 3;
					}
					continue;
				case 0:
				case 2:
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}
}
