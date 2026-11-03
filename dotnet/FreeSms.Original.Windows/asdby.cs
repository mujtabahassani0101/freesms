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

public class asdby : Form
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

	private UIComboBox q;

	private Label r;

	private UIComboBox s;

	private Label t;

	private UIComboBox u;

	private Label v;

	private GridEX w;

	private Label x;

	private NumericEditBox y;

	private NumericEditBox z;

	private Label aa;

	private Panel ab;

	private CheckBox ac;

	private Label ad;

	private Label ae;

	private Container af = null;

	private SqlConnection ag = new SqlConnection(asdab.e());

	private string ah;

	private bool ai = false;

	private string aj = "1";

	private string ak = "";

	private int al = -1;

	public asdby()
	{
		g();
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
					goto case 2;
				case 3:
					num = 2;
					continue;
				case 1:
					af.Dispose();
					num = 3;
					continue;
				case 4:
					flag = af == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 3;
				case 2:
					base.Dispose(A_0);
					return;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdby));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_k = new Panel();
		ab = new Panel();
		ad = new Label();
		this.m_n = new Label();
		w = new GridEX();
		this.m_l = new UIButton();
		o = new UIButton();
		this.m_m = new UIButton();
		p = new UIButton();
		ac = new CheckBox();
		this.m_i = new GridEX();
		this.m_f = new Label();
		this.m_e = new EditBox();
		this.m_d = new UIButton();
		this.m_c = new UIButton();
		this.m_j = new UIButton();
		r = new Label();
		s = new UIComboBox();
		t = new Label();
		u = new UIComboBox();
		this.m_h = new Label();
		this.m_g = new EditBox();
		v = new Label();
		q = new UIComboBox();
		x = new Label();
		y = new NumericEditBox();
		z = new NumericEditBox();
		aa = new Label();
		ae = new Label();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		this.m_k.SuspendLayout();
		ab.SuspendLayout();
		((ISupportInitialize)w).BeginInit();
		((ISupportInitialize)this.m_i).BeginInit();
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
		this.m_b.Controls.Add(r);
		this.m_b.Controls.Add(s);
		this.m_b.Controls.Add(t);
		this.m_b.Controls.Add(u);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Controls.Add(this.m_g);
		this.m_b.Controls.Add(v);
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(x);
		this.m_b.Controls.Add(y);
		this.m_b.Controls.Add(z);
		this.m_b.Controls.Add(aa);
		this.m_b.Controls.Add(ae);
		this.m_b.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.Size = new Size(679, 680);
		this.m_b.TabIndex = 0;
		this.m_k.BackColor = Color.Silver;
		this.m_k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_k.Controls.Add(ab);
		this.m_k.Location = new Point(116, 9);
		this.m_k.Name = "pStdMark";
		this.m_k.Size = new Size(489, 658);
		this.m_k.TabIndex = 74;
		this.m_k.Visible = false;
		ab.BackColor = Color.FromArgb(214, 223, 247);
		ab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ab.Controls.Add(ad);
		ab.Controls.Add(this.m_n);
		ab.Controls.Add(w);
		ab.Controls.Add(this.m_l);
		ab.Controls.Add(o);
		ab.Controls.Add(this.m_m);
		ab.Controls.Add(p);
		ab.Controls.Add(ac);
		ab.Location = new Point(3, 3);
		ab.Name = "panel3";
		ab.Size = new Size(481, 648);
		ab.TabIndex = 81;
		ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ad.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ad.Location = new Point(293, 38);
		ad.Name = "lExam";
		ad.RightToLeft = RightToLeft.Yes;
		ad.Size = new Size(172, 33);
		ad.TabIndex = 82;
		ad.TextAlign = ContentAlignment.MiddleCenter;
		this.m_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_n.Font = new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_n.Location = new Point(8, 34);
		this.m_n.Name = "lName";
		this.m_n.RightToLeft = RightToLeft.Yes;
		this.m_n.Size = new Size(279, 42);
		this.m_n.TabIndex = 76;
		this.m_n.TextAlign = ContentAlignment.MiddleCenter;
		w.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		w.DesignTimeLayout = gridEXLayout;
		w.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		w.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		w.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.GroupByBoxVisible = false;
		w.Location = new Point(8, 87);
		w.Name = "gStdMark";
		w.RecordNavigator = true;
		w.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		w.SelectedFormatStyle.BackColor = Color.Empty;
		w.SelectedFormatStyle.ForeColor = Color.Empty;
		w.Size = new Size(458, 514);
		w.TabIndex = 80;
		w.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		w.SelectionChanged += a;
		w.KeyUp += d;
		w.CellUpdated += a;
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
		o.Location = new Point(156, 605);
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
		p.Location = new Point(8, 605);
		p.Name = "btnCancel";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(142, 38);
		p.TabIndex = 78;
		p.Text = "(Esc)انصراف";
		p.ToolTipText = "دکمه میانبر : Esc";
		p.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		p.Click += m;
		ac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ac.AutoSize = true;
		ac.Location = new Point(115, 532);
		ac.Name = "checkBox1";
		ac.Size = new Size(351, 20);
		ac.TabIndex = 81;
		ac.Text = "فعال کردن ستون ردیف برای اصلاح شماره ردیف درس";
		ac.UseVisualStyleBackColor = true;
		ac.Visible = false;
		ac.CheckedChanged += b;
		this.m_i.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_i.CardCaptionPrefix = "Product:";
		this.m_i.Cursor = Cursors.Default;
		this.m_i.DataMember = null;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_i.DesignTimeLayout = gridEXLayout2;
		this.m_i.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_i.FlatBorderColor = SystemColors.ControlDark;
		this.m_i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.GridLineColor = SystemColors.ScrollBar;
		this.m_i.GroupByBoxVisible = false;
		this.m_i.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_i.Location = new Point(7, 151);
		this.m_i.Name = "gstd";
		this.m_i.RecordNavigator = true;
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_i.SelectedFormatStyle.Blend = 0.5f;
		this.m_i.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_i.Size = new Size(657, 463);
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
		this.m_e.KeyUp += b;
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
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.AutoSize = true;
		r.Location = new Point(593, 68);
		r.Name = "label19";
		r.Size = new Size(48, 16);
		r.TabIndex = 78;
		r.Text = "صنف :";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		s.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		s.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		s.Location = new Point(416, 67);
		s.Name = "dropCls";
		s.Size = new Size(171, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		s.StringFormat = stringFormat;
		s.TabIndex = 76;
		s.SelectedIndexChanged += c;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.AutoSize = true;
		t.Location = new Point(592, 42);
		t.Name = "label20";
		t.Size = new Size(38, 16);
		t.TabIndex = 77;
		t.Text = "پایه :";
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		u.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		u.Location = new Point(414, 39);
		u.Name = "dropPaye";
		u.Size = new Size(173, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		u.StringFormat = stringFormat2;
		u.TabIndex = 75;
		u.SelectedIndexChanged += d;
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
		this.m_g.KeyUp += c;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.AutoSize = true;
		v.Location = new Point(593, 10);
		v.Name = "label2";
		v.Size = new Size(45, 16);
		v.TabIndex = 80;
		v.Text = "دوره :";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		q.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		q.Location = new Point(414, 10);
		q.Name = "dropExam";
		q.Size = new Size(173, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		q.StringFormat = stringFormat3;
		q.TabIndex = 79;
		q.SelectedIndexChanged += e;
		x.AutoSize = true;
		x.Location = new Point(65, 39);
		x.Name = "label4";
		x.Size = new Size(25, 16);
		x.TabIndex = 84;
		x.Text = "تا :";
		y.AutoScroll = false;
		y.AutoScrollMargin = new Size(0, 0);
		y.AutoScrollMinSize = new Size(0, 0);
		y.AutoScrollPosition = new Point(0, 0);
		y.Location = new Point(7, 36);
		y.Name = "txtMaxMark";
		y.Size = new Size(52, 23);
		y.TabIndex = 83;
		y.Text = "20";
		y.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		y.Value = (short)20;
		y.ValueType = NumericEditValueType.Int16;
		z.AutoScroll = false;
		z.AutoScrollMargin = new Size(0, 0);
		z.AutoScrollMinSize = new Size(0, 0);
		z.AutoScrollPosition = new Point(0, 0);
		z.Location = new Point(7, 9);
		z.Name = "txtMinMark";
		z.Size = new Size(52, 23);
		z.TabIndex = 82;
		z.Text = "0";
		z.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		z.Value = (short)0;
		z.ValueType = NumericEditValueType.Int16;
		aa.AutoSize = true;
		aa.Location = new Point(65, 10);
		aa.Name = "label3";
		aa.Size = new Size(83, 16);
		aa.TabIndex = 81;
		aa.Text = "رنج نمره از :";
		ae.BackColor = Color.Silver;
		ae.Enabled = false;
		ae.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ae.ForeColor = Color.Red;
		ae.Location = new Point(37, 114);
		ae.Name = "lMark100";
		ae.Size = new Size(617, 23);
		ae.TabIndex = 85;
		ae.Text = "فقط شاگردانی که تیک مربوط به ورود نمره سالانه از 100 دارند در این بخش نمایش داده می شود";
		ae.Visible = false;
		AutoScaleBaseSize = new Size(8, 26);
		BackColor = Color.FromArgb(184, 203, 255);
		ClientSize = new Size(706, 714);
		Controls.Add(this.m_a);
		Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmMarkEntry2";
		StartPosition = FormStartPosition.CenterScreen;
		Tag = "10";
		Text = "اطلاعات داوطلبان";
		Load += n;
		KeyUp += a;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		this.m_k.ResumeLayout(performLayout: false);
		ab.ResumeLayout(performLayout: false);
		ab.PerformLayout();
		((ISupportInitialize)w).EndInit();
		((ISupportInitialize)this.m_i).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void f()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where term in(0,1,2,3) and xYear=" + asdaj.__field_a + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			q.DataSource = dataSource;
			q.DisplayMember = "Name";
			q.ValueMember = "id";
			bool flag = q.Items.Count <= 0;
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
					q.SelectedIndex = 0;
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

	private void e()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.__field_a + ") order by id");
			u.DataSource = dataSource;
			u.DisplayMember = "Name";
			u.ValueMember = "id";
			bool flag = u.Items.Count <= 0;
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
					u.SelectedIndex = 0;
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

	private void d()
	{
		while (true)
		{
			string text = " where  xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
			bool flag = u.SelectedIndex < 0;
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
					goto case 5;
				case 3:
					s.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
					s.DataSource = dataSource;
					s.DisplayMember = "Name";
					s.ValueMember = "id";
					flag = s.Items.Count <= 0;
					num = 4;
					continue;
				}
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 0:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + asdaj.__field_a + " and (xPaye = " + u.SelectedValue.ToString() + "))";
					num = 5;
					continue;
				}
				}
				break;
			}
		}
	}

	private void c()
	{
		string text = default;
		DataTable dataTable = default;
		while (true)
		{
			this.m_i.DataSource = null;
			bool flag = q.SelectedIndex >= 1;
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = u.SelectedIndex >= 0;
					num = 3;
					continue;
				case 35:
					flag = !(this.m_g.Text.Trim() != "");
					num = 42;
					continue;
				case 42:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 34;
				case 21:
				case 25:
					flag = !(this.m_e.Text.Trim() != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 35;
				case 16:
					num = ((ak == "1") ? 33 : 17);
					continue;
				case 34:
					flag = !(text != "");
					num = 43;
					continue;
				case 43:
					if (!flag)
					{
						num = 37;
						continue;
					}
					goto case 27;
				case 18:
					if (flag)
					{
						text = "";
						num = 16;
					}
					else
					{
						num = 22;
					}
					continue;
				case 28:
					text = text + " tStudent.FName Like N'%" + this.m_e.Text + "%'";
					num = 35;
					continue;
				case 27:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tmpstd.sort, tmpstd.id, tmpstd.Code, tmpstd.FName, tmpstd.LName, tmpstd.PName,round( tmpMark.MarkDoreh,2) Mark,tmpMark.gpaye,tmpMark.gclass from\r\n                    (SELECT     tYear_Student.sort, tStudent.id, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.NumberAsas\r\nFROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                    WHERE   (tYear_Student.xYear = " + asdaj.__field_a + ")  and   (tYear_Student.xPaye = " + u.SelectedValue.ToString() + ") AND tYear_Student.xClass = " + s.SelectedValue.ToString() + text + ") tmpstd left outer join\r\n                    (SELECT     xStudent, MarkDoreh,gClass,gPaye\r\n                    FROM         tMarkDoreh\r\n                    WHERE     (typ = 5) AND (Xtest = " + q.SelectedValue.ToString() + ")) tmpMark on tmpstd.id=tmpMark.xStudent");
					flag = dataTable.Rows.Count <= 0;
					num = 30;
					continue;
				case 30:
					if (true)
					{
					}
					if (!flag)
					{
						num = 6;
						continue;
					}
					this.m_i.DataSource = null;
					num = 0;
					continue;
				case 10:
					text += " tYear_Student.MarkTerm3_From100=1";
					num = 25;
					continue;
				case 33:
					num2 = 0;
					goto IL_0577;
				case 37:
					text = " and " + text;
					num = 27;
					continue;
				case 0:
					return;
				case 13:
					text += " tYear_Student.MarkTerm3_From100=0";
					num = 21;
					continue;
				case 12:
					num = 41;
					continue;
				case 41:
					return;
				case 17:
					num = 15;
					continue;
				case 15:
					num2 = ((!(ak == "2")) ? 1 : 0);
					goto IL_0577;
				case 22:
					num = 19;
					continue;
				case 19:
					return;
				case 39:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 13;
				case 14:
					text = text + " tStudent.LName Like N'%" + this.m_g.Text + "%'";
					num = 34;
					continue;
				case 32:
					this.m_g.Text = asdaj.b(this.m_g.Text.Trim());
					flag = !(text != "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 14;
				case 5:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 21;
				case 9:
					text += " and ";
					num = 13;
					continue;
				case 8:
					this.m_e.Text = asdaj.b(this.m_e.Text.Trim());
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 28;
				case 38:
					if (flag)
					{
						flag = !(ak == "3");
						num = 5;
					}
					else
					{
						num = 39;
					}
					continue;
				case 31:
					num = 26;
					continue;
				case 26:
					return;
				case 40:
					text += " and ";
					num = 14;
					continue;
				case 23:
					flag = !(text != "");
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 29;
						continue;
					}
					goto case 10;
				case 29:
					text += " and ";
					num = 10;
					continue;
				case 3:
					if (flag)
					{
						flag = s.SelectedIndex >= 0;
						num = 18;
					}
					else
					{
						num = 31;
					}
					continue;
				case 6:
					this.m_i.DataSource = dataTable;
					num = 1;
					continue;
				case 1:
					return;
				case 20:
					{
						text += " and ";
						num = 28;
						continue;
					}
					IL_0577:
					flag = (byte)num2 != 0;
					num = 38;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		DataTable dataTable = default;
		while (true)
		{
			string text = " M1, M2";
			bool flag = !(ak == "3");
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
						num = 5;
						continue;
					}
					goto case 1;
				case 0:
					w.DataSource = dataTable;
					num = 2;
					continue;
				case 1:
					this.m_n.Text = this.m_i.SelectedItems[0].GetRow().Cells["FName"].Value.ToString() + " " + this.m_i.SelectedItems[0].GetRow().Cells["LName"].Value.ToString();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select  0 as acp,    tmpbok.xbook, tmpbok.book, tmpbok.SortOneEntry,tmpbok.sort,  tmpmark.M1, tmpmark.M2, tmpmark.M3, tmpmark.M4, tmpmark.M5, tmpmark.M6, tmpmark.M7, tmpmark.M8, \r\n                      tmpmark.CountAb\r\n                    from\r\n                    (SELECT     id as xbook, Name as book, SortOneEntry,sort\r\n                        FROM         tBook\r\n                      WHERE     (xPaye = " + u.SelectedValue.ToString() + ") AND (showOneEntry = 1))tmpbok\r\n                        left outer join\r\n                       (SELECT     xStudent, xbook, " + text + ", M3, M4, M5, M6, M7, M8, CountAb         \r\n                        FROM         tMark where xtest= " + q.SelectedValue.ToString() + " and xStudent= " + this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")tmpmark on tmpbok.xbook=tmpmark.xbook order by tmpbok.sort,tmpbok.xbook");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					w.DataSource = null;
					num = 6;
					continue;
				case 5:
					text = " mark as M1,null as M2";
					num = 1;
					continue;
				case 2:
				case 6:
				{
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(w.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					w.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(w.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					w.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					return;
				}
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
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 7;
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
					f();
					e();
					d();
					q.Focus();
					num = 5;
					continue;
				case 5:
					if (1 == 0)
					{
					}
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		this.m_k.Visible = false;
	}

	private void l(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void k(object A_0, EventArgs A_1)
	{
		c();
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_i.RowCount <= 0;
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
					return;
				case 0:
					this.m_k.Visible = true;
                    this.m_k.BringToFront();
					ah = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					b();
					w.Row = 0;
					w.CurrentColumn = w.GetRow(0).Cells["m1"].Column;
					w.Select();
					w.SelectCurrentCellText();
					num = 2;
					continue;
				case 2:
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
		ah = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		b();
		w.CurrentColumn = w.GetRow(0).Cells["m1"].Column;
		w.Select();
		w.SelectCurrentCellText();
	}

	private void a()
	{
		while (true)
		{
			bool flag = this.m_i.Row != 0;
			int num = 7;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 0;
						continue;
					}
					this.m_l.Enabled = true;
					num = 5;
					continue;
				case 4:
					this.m_m.Enabled = false;
					num = 1;
					continue;
				case 1:
					return;
				case 3:
				case 5:
					flag = this.m_i.Row != this.m_i.RecordCount - 1;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					this.m_m.Enabled = true;
					num = 6;
					continue;
				case 0:
					this.m_l.Enabled = false;
					num = 3;
					continue;
				case 6:
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
		ah = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		b();
		w.CurrentColumn = w.GetRow(0).Cells["m1"].Column;
		w.Select();
		w.SelectCurrentCellText();
	}

	private void g(object A_0, EventArgs A_1)
	{
		bool flag = default;
		int num3 = default;
		string text7 = default;
		float num4 = default;
		int num8 = default;
		float num5 = default;
		int num6 = default;
		string text8 = default;
		int num9 = default;
		string text = default;
		string text4 = default;
		string text5 = default;
		string text6 = default;
		string text3 = default;
		string text9 = default;
		string text2 = default;
		string text10 = default;
		string text11 = default;
		while (true)
		{
			SqlCommand sqlCommand = null;
			SqlConnection sqlConnection = new SqlConnection(asdab.e());
			ai = false;
			int num = 0;
			int num2 = 99;
			while (true)
			{
				int num10;
				int num13;
				switch (num2)
				{
				case 79:
					sqlCommand.Parameters.AddWithValue("@m6", DBNull.Value);
					num2 = 84;
					continue;
				case 23:
					try
					{
						while (true)
						{
							IL_0256:
							flag = !(w.GetRow(num3).Cells["m4"].Text != "");
							num2 = 6;
							while (true)
							{
								int num20;
								switch (num2)
								{
								case 6:
									if (!flag)
									{
										num2 = 5;
										continue;
									}
									text7 = null;
									num2 = 9;
									continue;
								case 5:
									num4 = float.Parse(w.GetRow(num3).Cells["m4"].Text.ToString());
									num2 = 4;
									continue;
								case 4:
									num2 = ((!(num4 > (float)num8)) ? 1 : 3);
									continue;
								case 3:
									num20 = 0;
									goto IL_034e;
								case 7:
									if (flag)
									{
										text7 = num4.ToString();
										num5 += num4;
										num6++;
										num2 = 2;
									}
									else
									{
										num2 = 10;
									}
									continue;
								case 1:
									num2 = 8;
									continue;
								case 8:
									num20 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_034e;
								case 10:
									w.GetRow(num3).Cells["m4"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 0;
									continue;
								case 0:
									goto end_IL_021d;
								case 2:
								case 9:
									num2 = 11;
									continue;
								case 11:
									goto IL_23d4;
									IL_034e:
									flag = (byte)num20 != 0;
									num2 = 7;
									continue;
								}
								goto IL_0256;
								continue;
								end_IL_021d:
								break;
							}
							break;
						}
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 53:
					sqlCommand.Parameters.AddWithValue("@m10", DBNull.Value);
					num2 = 82;
					continue;
				case 15:
				case 92:
					num3++;
					num2 = 1;
					continue;
				case 96:
					sqlCommand.Parameters.AddWithValue("@m2", DBNull.Value);
					num2 = 59;
					continue;
				case 49:
					try
					{
						while (true)
						{
							IL_055e:
							flag = !(w.GetRow(num3).Cells["m5"].Text != "");
							num2 = 1;
							while (true)
							{
								int num17;
								switch (num2)
								{
								case 1:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									text8 = null;
									num2 = 8;
									continue;
								case 3:
									w.GetRow(num3).Cells["m5"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 11;
									continue;
								case 11:
									goto end_IL_0525;
								case 4:
									num17 = 0;
									goto IL_068a;
								case 10:
									num2 = 9;
									continue;
								case 9:
									num17 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_068a;
								case 5:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									text8 = num4.ToString();
									num5 += num4;
									num6++;
									num2 = 6;
									continue;
								case 2:
									num4 = float.Parse(w.GetRow(num3).Cells["m5"].Text.ToString());
									num2 = 7;
									continue;
								case 7:
									num2 = ((!(num4 > (float)num8)) ? 10 : 4);
									continue;
								case 6:
								case 8:
									num2 = 0;
									continue;
								case 0:
									goto IL_0e81;
									IL_068a:
									flag = (byte)num17 != 0;
									num2 = 5;
									continue;
								}
								goto IL_055e;
								continue;
								end_IL_0525:
								break;
							}
							break;
						}
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 25:
				case 47:
				{
					int num16 = sqlCommand.ExecuteNonQuery();
					flag = num16 >= 1;
					num2 = 42;
					continue;
				}
				case 42:
					if (!flag)
					{
						num2 = 62;
						continue;
					}
					aj = "0";
					num9++;
					num2 = 13;
					continue;
				case 12:
				case 83:
					num2 = 65;
					continue;
				case 88:
					sqlCommand = new SqlCommand("DELETE FROM tMark WHERE (xStudent = @xStudent) AND (Xtest = @Xtest) AND (xbook = @xbook)", ag);
					sqlCommand.Parameters.AddWithValue("@xStudent", ah);
					sqlCommand.Parameters.AddWithValue("@Xtest", q.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xbook", w.GetRow(num3).Cells["xbook"].Text.ToString());
					sqlCommand.ExecuteNonQuery();
					num2 = 15;
					continue;
				case 99:
					try
					{
						num = int.Parse(z.Text);
					}
					catch
					{
					}
					num8 = int.Parse(y.Text);
					text = "";
					text4 = "";
					text5 = "";
					text6 = "";
					text7 = "";
					text8 = "";
					text3 = "";
					text9 = "";
					text2 = "";
					text10 = "";
					text11 = "";
					num4 = 0f;
					num5 = 0f;
					num6 = 0;
					num9 = 0;
					ag.Open();
					sqlCommand = new SqlCommand("UPDATE tExam SET procc = 0 WHERE  (id = " + q.SelectedValue.ToString() + ")", ag);
					sqlCommand.ExecuteNonQuery();
					num2 = 28;
					continue;
				case 13:
				case 94:
					num2 = 92;
					continue;
				case 32:
					sqlCommand.Parameters.AddWithValue("@m9", DBNull.Value);
					num2 = 89;
					continue;
				case 38:
					num2 = ((num6 != 0) ? 87 : 46);
					continue;
				case 27:
				case 43:
					flag = text7 != null;
					num2 = 55;
					continue;
				case 55:
					if (!flag)
					{
						num2 = 31;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m4", text7);
					num2 = 40;
					continue;
				case 4:
				case 89:
					flag = text11 != null;
					num2 = 100;
					continue;
				case 100:
					if (!flag)
					{
						num2 = 53;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m10", text11);
					num2 = 73;
					continue;
				case 90:
					try
					{
						while (true)
						{
							IL_09c1:
							flag = !(w.GetRow(num3).Cells["m7"].Text != "");
							num2 = 2;
							while (true)
							{
								int num15;
								switch (num2)
								{
								case 4:
									goto end_IL_0988;
								case 2:
									if (!flag)
									{
										num2 = 7;
										continue;
									}
									text9 = null;
									num2 = 6;
									continue;
								case 3:
									num15 = 0;
									goto IL_0a40;
								case 11:
									if (!flag)
									{
										num2 = 0;
										continue;
									}
									text9 = num4.ToString();
									num5 += num4;
									num6++;
									num2 = 9;
									continue;
								case 0:
									w.GetRow(num3).Cells["m7"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 10;
									continue;
								case 10:
									goto end_IL_0986;
								case 8:
									num2 = 5;
									continue;
								case 5:
									num15 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_0a40;
								case 7:
									num4 = float.Parse(w.GetRow(num3).Cells["m7"].Text.ToString());
									num2 = 1;
									continue;
								case 1:
									num2 = ((!(num4 > (float)num8)) ? 8 : 3);
									continue;
								case 6:
								case 9:
									{
										num2 = 4;
										continue;
									}
									IL_0a40:
									flag = (byte)num15 != 0;
									num2 = 11;
									continue;
								}
								goto IL_09c1;
								continue;
								end_IL_0988:
								break;
							}
							break;
						}
						goto IL_0940;
						end_IL_0986:;
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 33:
					try
					{
						while (true)
						{
							IL_0c40:
							flag = !(w.GetRow(num3).Cells["m6"].Text != "");
							num2 = 2;
							while (true)
							{
								int num12;
								switch (num2)
								{
								case 2:
									if (!flag)
									{
										num2 = 1;
										continue;
									}
									text3 = null;
									num2 = 9;
									continue;
								case 10:
									num2 = 3;
									continue;
								case 3:
									num12 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_0cac;
								case 11:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									text3 = num4.ToString();
									num5 += num4;
									num6++;
									num2 = 6;
									continue;
								case 1:
									num4 = float.Parse(w.GetRow(num3).Cells["m6"].Text.ToString());
									num2 = 8;
									continue;
								case 8:
									num2 = ((num4 > (float)num8) ? 5 : 10);
									continue;
								case 5:
									num12 = 0;
									goto IL_0cac;
								case 4:
									w.GetRow(num3).Cells["m6"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 7;
									continue;
								case 7:
									goto end_IL_0c07;
								case 6:
								case 9:
									num2 = 0;
									continue;
								case 0:
									goto IL_1465;
									IL_0cac:
									flag = (byte)num12 != 0;
									num2 = 11;
									continue;
								}
								goto IL_0c40;
								continue;
								end_IL_0c07:
								break;
							}
							break;
						}
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 95:
					sqlCommand = new SqlCommand("sp_tMark_insertUpdate", ag);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xStudent", ah);
					sqlCommand.Parameters.AddWithValue("@Xtest", q.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xbook", w.GetRow(num3).Cells["xbook"].Text.ToString());
					flag = text != null;
					num2 = 35;
					continue;
				case 35:
					if (!flag)
					{
						num2 = 63;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@countAb", text);
					num2 = 5;
					continue;
				case 85:
					num2 = 66;
					continue;
				case 66:
					num10 = ((!(ak == "2")) ? 1 : 0);
					goto IL_20a9;
				case 98:
					num2 = 9;
					continue;
				case 3:
				case 10:
					if (true)
					{
					}
					flag = text2 != null;
					num2 = 68;
					continue;
				case 68:
					if (!flag)
					{
						num2 = 18;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m8", text2);
					num2 = 11;
					continue;
				case 28:
					num2 = ((ak == "1") ? 22 : 85);
					continue;
				case 70:
					ag.Close();
					w.Refresh();
					flag = this.m_i.Row >= this.m_i.RowCount - 1;
					num2 = 78;
					continue;
				case 78:
					if (!flag)
					{
						num2 = 69;
						continue;
					}
					MessageBox.Show("اطلاعات ذخیره شد");
					this.m_k.Visible = false;
					num2 = 93;
					continue;
				case 80:
					try
					{
						while (true)
						{
							IL_11ab:
							flag = !(w.GetRow(num3).Cells["m2"].Text != "");
							num2 = 4;
							while (true)
							{
								int num21;
								switch (num2)
								{
								case 4:
									if (!flag)
									{
										num2 = 2;
										continue;
									}
									text5 = null;
									num2 = 10;
									continue;
								case 3:
									num21 = 0;
									goto IL_1356;
								case 2:
									num4 = float.Parse(w.GetRow(num3).Cells["m2"].Text.ToString());
									num2 = 6;
									continue;
								case 6:
									num2 = ((!(num4 > (float)num8)) ? 11 : 3);
									continue;
								case 11:
									num2 = 5;
									continue;
								case 5:
									num21 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_1356;
								case 0:
									w.GetRow(num3).Cells["m2"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 1;
									continue;
								case 1:
									goto end_IL_1172;
								case 8:
									if (flag)
									{
										text5 = num4.ToString();
										num5 += num4;
										num6++;
										num2 = 7;
									}
									else
									{
										num2 = 0;
									}
									continue;
								case 7:
								case 10:
									num2 = 9;
									continue;
								case 9:
									goto IL_142b;
									IL_1356:
									flag = (byte)num21 != 0;
									num2 = 8;
									continue;
								}
								goto IL_11ab;
								continue;
								end_IL_1172:
								break;
							}
							break;
						}
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 72:
					num3 = 0;
					num2 = 7;
					continue;
				case 73:
				case 82:
					flag = num6 != 0;
					num2 = 77;
					continue;
				case 77:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@Mark", num5);
						num2 = 25;
					}
					else
					{
						num2 = 97;
					}
					continue;
				case 97:
					sqlCommand.Parameters.AddWithValue("@Mark", DBNull.Value);
					num2 = 47;
					continue;
				case 52:
					try
					{
						while (true)
						{
							IL_1558:
							flag = !(w.GetRow(num3).Cells["m3"].Text != "");
							num2 = 8;
							while (true)
							{
								int num19;
								switch (num2)
								{
								case 8:
									if (!flag)
									{
										num2 = 0;
										continue;
									}
									text6 = null;
									num2 = 3;
									continue;
								case 2:
									num2 = 1;
									continue;
								case 1:
									num19 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_16f5;
								case 0:
									num4 = float.Parse(w.GetRow(num3).Cells["m3"].Text.ToString());
									num2 = 7;
									continue;
								case 7:
									num2 = ((num4 > (float)num8) ? 10 : 2);
									continue;
								case 5:
									w.GetRow(num3).Cells["m3"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 4;
									continue;
								case 4:
									goto end_IL_151f;
								case 11:
									if (flag)
									{
										text6 = num4.ToString();
										num5 += num4;
										num6++;
										num2 = 6;
									}
									else
									{
										num2 = 5;
									}
									continue;
								case 10:
									num19 = 0;
									goto IL_16f5;
								case 3:
								case 6:
									num2 = 9;
									continue;
								case 9:
									goto IL_1cae;
									IL_16f5:
									flag = (byte)num19 != 0;
									num2 = 11;
									continue;
								}
								goto IL_1558;
								continue;
								end_IL_151f:
								break;
							}
							break;
						}
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 41:
				case 59:
					flag = text6 != null;
					num2 = 75;
					continue;
				case 75:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m3", text6);
						num2 = 27;
					}
					else
					{
						num2 = 36;
					}
					continue;
				case 17:
					try
					{
						while (true)
						{
							IL_180c:
							flag = !(w.GetRow(num3).Cells["m10"].Text != "");
							num2 = 4;
							while (true)
							{
								int num18;
								switch (num2)
								{
								case 2:
									goto end_IL_17d3;
								case 4:
									if (!flag)
									{
										num2 = 7;
										continue;
									}
									text11 = null;
									num2 = 9;
									continue;
								case 7:
									num4 = float.Parse(w.GetRow(num3).Cells["m10"].Text.ToString());
									num2 = 10;
									continue;
								case 10:
									num2 = ((num4 > (float)num8) ? 1 : 5);
									continue;
								case 5:
									num2 = 3;
									continue;
								case 3:
									num18 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_197c;
								case 8:
									w.GetRow(num3).Cells["m10"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 6;
									continue;
								case 6:
									goto end_IL_17d1;
								case 11:
									if (!flag)
									{
										num2 = 8;
										continue;
									}
									text11 = num4.ToString();
									num5 += num4;
									num6++;
									num2 = 0;
									continue;
								case 1:
									num18 = 0;
									goto IL_197c;
								case 0:
								case 9:
									{
										num2 = 2;
										continue;
									}
									IL_197c:
									flag = (byte)num18 != 0;
									num2 = 11;
									continue;
								}
								goto IL_180c;
								continue;
								end_IL_17d3:
								break;
							}
							break;
						}
						goto IL_08e5;
						end_IL_17d1:;
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 58:
					sqlCommand.Parameters.AddWithValue("@m1", DBNull.Value);
					num2 = 51;
					continue;
				case 34:
					sqlCommand.Parameters.AddWithValue("@m7", DBNull.Value);
					num2 = 3;
					continue;
				case 51:
				case 76:
					flag = text5 != null;
					num2 = 74;
					continue;
				case 74:
					if (!flag)
					{
						num2 = 96;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@m2", text5);
					num2 = 41;
					continue;
				case 39:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					goto case 67;
				case 87:
					num13 = 1;
					goto IL_1c0f;
				case 67:
					flag = !(ak == "3");
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 98;
						continue;
					}
					goto case 95;
				case 5:
				case 44:
					flag = text4 != null;
					num2 = 21;
					continue;
				case 21:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m1", text4);
						num2 = 76;
					}
					else
					{
						num2 = 58;
					}
					continue;
				case 69:
					flag = ai;
					num2 = 14;
					continue;
				case 14:
					if (!flag)
					{
						num2 = 54;
						continue;
					}
					goto case 65;
				case 20:
					if (flag)
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "1";
						w.GetRow(num3).EndEdit();
						flag = num6 == 0;
						num2 = 39;
					}
					else
					{
						num2 = 88;
					}
					continue;
				case 31:
					sqlCommand.Parameters.AddWithValue("@m4", DBNull.Value);
					num2 = 45;
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_1d6f:
							flag = !(w.GetRow(num3).Cells["m1"].Text != "");
							num2 = 8;
							while (true)
							{
								int num14;
								switch (num2)
								{
								case 0:
									goto end_IL_1d36;
								case 8:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									text4 = null;
									num2 = 9;
									continue;
								case 6:
									w.GetRow(num3).Cells["m1"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 2;
									continue;
								case 2:
									goto end_IL_1d34;
								case 1:
									num2 = 10;
									continue;
								case 10:
									num14 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_1e72;
								case 5:
									if (!flag)
									{
										num2 = 6;
										continue;
									}
									text4 = num4.ToString();
									num5 += num4;
									num6++;
									num2 = 3;
									continue;
								case 4:
									num4 = float.Parse(w.GetRow(num3).Cells["m1"].Text.ToString());
									num2 = 11;
									continue;
								case 11:
									num2 = ((!(num4 > (float)num8)) ? 1 : 7);
									continue;
								case 7:
									num14 = 0;
									goto IL_1e72;
								case 3:
								case 9:
									{
										num2 = 0;
										continue;
									}
									IL_1e72:
									flag = (byte)num14 != 0;
									num2 = 5;
									continue;
								}
								goto IL_1d6f;
								continue;
								end_IL_1d36:
								break;
							}
							break;
						}
						goto IL_1016;
						end_IL_1d34:;
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 46:
					num2 = 8;
					continue;
				case 8:
					num13 = ((text != null) ? 1 : 0);
					goto IL_1c0f;
				case 29:
				case 84:
					flag = text9 != null;
					num2 = 16;
					continue;
				case 16:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m7", text9);
						num2 = 10;
					}
					else
					{
						num2 = 34;
					}
					continue;
				case 19:
					sqlCommand.Parameters.AddWithValue("@m5", DBNull.Value);
					num2 = 56;
					continue;
				case 22:
					num10 = 0;
					goto IL_20a9;
				case 37:
					if (!flag)
					{
						num2 = 91;
						continue;
					}
					goto case 72;
				case 9:
					try
					{
						num5 = float.Parse(text4);
						text5 = num5.ToString();
					}
					catch
					{
					}
					text4 = null;
					num2 = 95;
					continue;
				case 81:
					try
					{
						while (true)
						{
							IL_2167:
							flag = !(w.GetRow(num3).Cells["m9"].Text != "");
							num2 = 9;
							while (true)
							{
								int num11;
								switch (num2)
								{
								case 3:
									goto end_IL_212e;
								case 9:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									text10 = null;
									num2 = 2;
									continue;
								case 8:
									num11 = 0;
									goto IL_22fd;
								case 6:
									w.GetRow(num3).Cells["m9"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 7;
									continue;
								case 7:
									goto end_IL_212c;
								case 0:
									num2 = 10;
									continue;
								case 10:
									num11 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_22fd;
								case 4:
									num4 = float.Parse(w.GetRow(num3).Cells["m9"].Text.ToString());
									num2 = 11;
									continue;
								case 11:
									num2 = ((num4 > (float)num8) ? 8 : 0);
									continue;
								case 5:
									if (flag)
									{
										text10 = num4.ToString();
										num5 += num4;
										num6++;
										num2 = 1;
									}
									else
									{
										num2 = 6;
									}
									continue;
								case 1:
								case 2:
									{
										num2 = 3;
										continue;
									}
									IL_22fd:
									flag = (byte)num11 != 0;
									num2 = 5;
									continue;
								}
								goto IL_2167;
								continue;
								end_IL_212e:
								break;
							}
							break;
						}
						goto IL_0fd7;
						end_IL_212c:;
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 36:
					sqlCommand.Parameters.AddWithValue("@m3", DBNull.Value);
					num2 = 43;
					continue;
				case 54:
					flag = MessageBox.Show("اطلاعات ذخیره شد . آیا مایل هستید نفر بعدی نمایش داده شود", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
					num2 = 30;
					continue;
				case 30:
					num2 = (flag ? 83 : 24);
					continue;
				case 18:
					sqlCommand.Parameters.AddWithValue("@m8", DBNull.Value);
					num2 = 64;
					continue;
				case 11:
				case 64:
					flag = text10 != null;
					num2 = 86;
					continue;
				case 86:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m9", text10);
						num2 = 4;
					}
					else
					{
						num2 = 32;
					}
					continue;
				case 24:
					i(this, null);
					num2 = 12;
					continue;
				case 62:
					num2 = 94;
					continue;
				case 40:
				case 45:
					flag = text8 != null;
					num2 = 71;
					continue;
				case 71:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m5", text8);
						num2 = 57;
					}
					else
					{
						num2 = 19;
					}
					continue;
				case 1:
				case 7:
					flag = num3 < w.RowCount;
					num2 = 60;
					continue;
				case 60:
					if (flag)
					{
						text = "";
						text4 = "";
						text5 = "";
						text6 = "";
						text7 = "";
						text8 = "";
						text3 = "";
						text9 = "";
						text2 = "";
						text10 = "";
						text11 = "";
						num4 = 0f;
						num5 = 0f;
						num6 = 0;
						num2 = 26;
					}
					else
					{
						num2 = 70;
					}
					continue;
				case 2:
					num5 /= (float)num6;
					num2 = 67;
					continue;
				case 56:
				case 57:
					flag = text3 != null;
					num2 = 50;
					continue;
				case 50:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@m6", text3);
						num2 = 29;
					}
					else
					{
						num2 = 79;
					}
					continue;
				case 65:
					num2 = 48;
					continue;
				case 48:
					return;
				case 63:
					sqlCommand.Parameters.AddWithValue("@countAb", DBNull.Value);
					num2 = 44;
					continue;
				case 61:
					try
					{
						while (true)
						{
							IL_25f8:
							flag = !(w.GetRow(num3).Cells["m8"].Text != "");
							num2 = 6;
							while (true)
							{
								int num7;
								switch (num2)
								{
								case 1:
									goto end_IL_25bf;
								case 6:
									if (!flag)
									{
										num2 = 9;
										continue;
									}
									text2 = null;
									num2 = 11;
									continue;
								case 5:
									num2 = 8;
									continue;
								case 8:
									num7 = ((!(num4 < (float)num)) ? 1 : 0);
									goto IL_27a0;
								case 2:
									w.GetRow(num3).Cells["m8"].FormatStyle.BackColor = Color.Yellow;
									w.GetRow(num3).BeginEdit();
									w.GetRow(num3).Cells["acp"].Value = "-1";
									w.GetRow(num3).EndEdit();
									ai = true;
									num2 = 0;
									continue;
								case 0:
									goto end_IL_25bd;
								case 9:
									num4 = float.Parse(w.GetRow(num3).Cells["m8"].Text.ToString());
									num2 = 3;
									continue;
								case 3:
									num2 = ((num4 > (float)num8) ? 10 : 5);
									continue;
								case 10:
									num7 = 0;
									goto IL_27a0;
								case 7:
									if (flag)
									{
										text2 = num4.ToString();
										num5 += num4;
										num6++;
										num2 = 4;
									}
									else
									{
										num2 = 2;
									}
									continue;
								case 4:
								case 11:
									{
										num2 = 1;
										continue;
									}
									IL_27a0:
									flag = (byte)num7 != 0;
									num2 = 7;
									continue;
								}
								goto IL_25f8;
								continue;
								end_IL_25bf:
								break;
							}
							break;
						}
						goto IL_0f89;
						end_IL_25bd:;
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
					}
					goto case 15;
				case 26:
					try
					{
						while (true)
						{
							IL_2858:
							flag = !(w.GetRow(num3).Cells["countAb"].Text != "");
							num2 = 1;
							while (true)
							{
								switch (num2)
								{
								case 1:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									text = null;
									num2 = 4;
									continue;
								case 3:
									short.Parse(w.GetRow(num3).Cells["countAb"].Text.ToString());
									text = w.GetRow(num3).Cells["countAb"].Text.ToString();
									num2 = 2;
									continue;
								case 2:
								case 4:
									num2 = 0;
									continue;
								case 0:
									goto end_IL_283b;
								}
								goto IL_2858;
								continue;
								end_IL_283b:
								break;
							}
							break;
						}
					}
					catch
					{
						w.GetRow(num3).BeginEdit();
						w.GetRow(num3).Cells["acp"].Value = "-1";
						w.GetRow(num3).EndEdit();
						ai = true;
						goto case 15;
					}
					num2 = 6;
					continue;
				case 93:
					return;
				case 91:
					{
						sqlCommand = new SqlCommand("UPDATE tExam SET procc = 0 WHERE term=3 and xYear=" + asdaj.__field_a, ag);
						sqlCommand.ExecuteNonQuery();
						num2 = 72;
						continue;
					}
					IL_0f89:
					num2 = 81;
					continue;
					IL_20a9:
					flag = (byte)num10 != 0;
					num2 = 37;
					continue;
					IL_23d4:
					num2 = 49;
					continue;
					IL_0fd7:
					num2 = 17;
					continue;
					IL_1465:
					num2 = 90;
					continue;
					IL_1016:
					num2 = 80;
					continue;
					IL_0940:
					num2 = 61;
					continue;
					IL_1c0f:
					flag = (byte)num13 != 0;
					num2 = 20;
					continue;
					IL_0e81:
					num2 = 33;
					continue;
					IL_08e5:
					num2 = 38;
					continue;
					IL_1cae:
					num2 = 23;
					continue;
					IL_142b:
					num2 = 52;
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
					a();
					ah = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					b();
					w.Row = 0;
					w.CurrentColumn = w.GetRow(0).Cells["m1"].Column;
					w.Select();
					w.SelectCurrentCellText();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, KeyEventArgs A_1)
	{
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = q.SelectedIndex < 1;
			int num = 14;
			while (true)
			{
				switch (num)
				{
				case 14:
					if (!flag)
					{
						num = 9;
						continue;
					}
					ae.Visible = false;
					num = 12;
					continue;
				case 7:
					if (flag)
					{
						y.Text = "100";
						num = 2;
					}
					else
					{
						num = 10;
					}
					continue;
				case 4:
					ae.Visible = true;
					num = 11;
					continue;
				case 1:
				case 2:
				case 6:
					num = 0;
					continue;
				case 0:
					if (1 == 0)
					{
					}
					goto case 12;
				case 9:
					ad.Text = q.SelectedItem.Text;
					ak = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + q.SelectedValue.ToString()).ToString();
					flag = !(ak == "3");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					ae.Visible = false;
					num = 8;
					continue;
				case 10:
					y.Text = "60";
					num = 1;
					continue;
				case 8:
				case 11:
					flag = !(ak == "1");
					num = 13;
					continue;
				case 13:
					if (flag)
					{
						flag = !(ak == "2");
						num = 7;
					}
					else
					{
						num = 3;
					}
					continue;
				case 3:
					y.Text = "40";
					num = 6;
					continue;
				case 12:
					c();
					m(this, null);
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		d();
		c();
		m(this, null);
	}

	private void c(object A_0, EventArgs A_1)
	{
		m(this, null);
		c();
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F3;
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
					c();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					this.m_g.Focus();
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
			bool flag = A_1.KeyCode != Keys.F3;
			if (true)
			{
			}
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
					c();
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

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F2;
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					num = (flag ? 1 : 2);
					continue;
				case 19:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = A_1.KeyCode != Keys.Escape;
					num = 13;
					continue;
				case 23:
					w.Refresh();
					g(this, null);
					num = 0;
					continue;
				case 10:
					num2 = 1;
					goto IL_025c;
				case 13:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 0;
				case 1:
					num = ((A_1.KeyCode == Keys.F3) ? 18 : 10);
					continue;
				case 0:
				case 5:
				case 17:
				case 20:
					num = 24;
					continue;
				case 24:
					return;
				case 9:
					flag = A_1.KeyCode != Keys.F5;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 23;
						continue;
					}
					flag = A_1.KeyCode != Keys.Next;
					num = 15;
					continue;
				case 18:
					num = 21;
					continue;
				case 21:
					num2 = (this.m_k.Visible ? 1 : 0);
					goto IL_025c;
				case 7:
					m(this, null);
					num = 17;
					continue;
				case 8:
					h(this, null);
					num = 20;
					continue;
				case 6:
					c();
					num = 3;
					continue;
				case 2:
					j(this, null);
					num = 12;
					continue;
				case 14:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 3:
				case 12:
					flag = !this.m_k.Visible;
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 15:
					if (flag)
					{
						flag = A_1.KeyCode != Keys.Prior;
						num = 19;
					}
					else
					{
						num = 16;
					}
					continue;
				case 16:
					{
						if (true)
						{
						}
						i(this, null);
						num = 5;
						continue;
					}
					IL_025c:
					flag = (byte)num2 != 0;
					num = 14;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		w.RootTable.Columns["SortOneEntry"].Selectable = ac.Checked;
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		int num2 = default;
		int num3 = default;
		while (true)
		{
			bool flag = !(A_1.Column.Key == "SortOneEntry");
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
					num2 = 0;
					num = 2;
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_008d:
							int num4 = int.Parse(w.GetRow(w.Row).Cells["m1"].Text.ToString());
							num = 4;
							while (true)
							{
								int num5;
								switch (num)
								{
								case 4:
									num = ((num4 > num3) ? 1 : 6);
									continue;
								case 1:
									num5 = 0;
									goto IL_0281;
								case 0:
									al = w.Row;
									w.GetRow(w.Row).BeginEdit();
									w.GetRow(w.Row).Cells["acp"].Value = "-1";
									w.GetRow(w.Row).Cells["m1"].Value = num4;
									w.GetRow(w.Row).EndEdit();
									num = 5;
									continue;
								case 6:
									num = 3;
									continue;
								case 3:
									num5 = ((num4 >= num2) ? 1 : 0);
									goto IL_0281;
								case 2:
									if (flag)
									{
										al = -1;
										w.GetRow(w.Row).BeginEdit();
										w.GetRow(w.Row).Cells["acp"].Value = "0";
										w.GetRow(w.Row).Cells["m1"].Value = num4;
										w.GetRow(w.Row).EndEdit();
										num = 7;
									}
									else
									{
										num = 0;
									}
									continue;
								case 5:
								case 7:
									num = 8;
									continue;
								case 8:
									goto end_IL_0060;
									IL_0281:
									flag = (byte)num5 != 0;
									num = 2;
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
						al = -1;
						w.GetRow(w.Row).BeginEdit();
						w.GetRow(w.Row).Cells["acp"].Value = "0";
						w.GetRow(w.Row).Cells["m1"].Value = DBNull.Value;
						w.GetRow(w.Row).EndEdit();
					}
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					asdcb.d(asdab.e(), CommandType.Text, "update tbook set SortOneEntry=" + w.GetRow(w.Row).Cells["SortOneEntry"].Value.ToString() + " where id=" + w.GetRow(w.Row).Cells["xbook"].Value.ToString());
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					try
					{
						num2 = int.Parse(z.Text);
					}
					catch
					{
					}
					num3 = int.Parse(y.Text);
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
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
					num = ((al < 0) ? 6 : 0);
					continue;
				case 0:
					num = 2;
					continue;
				case 2:
					num2 = ((w.Row == al) ? 1 : 0);
					goto IL_00de;
				case 1:
					return;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 3:
					if (true)
					{
					}
					w.Row = al;
					MessageBox.Show("نمره وارد شده خارج از محدوده است");
					w.CurrentColumn = w.GetRow(0).Cells["m1"].Column;
					w.Select();
					w.SelectCurrentCellText();
					num = 1;
					continue;
				case 6:
					{
						num2 = 1;
						goto IL_00de;
					}
					IL_00de:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}
}
