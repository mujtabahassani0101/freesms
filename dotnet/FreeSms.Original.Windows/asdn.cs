using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdn : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private UIButton m_f;

	private UIButton m_g;

	private UIGroupBox m_h;

	private Label m_i;

	private UIComboBox m_j;

	private Label m_k;

	private UIComboBox m_l;

	private Label m_m;

	private Label m_n;

	private EditBox m_o;

	private EditBox m_p;

	private UIButton m_q;

	private OpenFileDialog r;

	private Panel s;

	private GridEX t;

	private Label u;

	private UIGroupBox v;

	private Panel w;

	private Panel x;

	private TextBox y;

	private Label z;

	private UIButton aa;

	private UIButton ab;

	private Label ac;

	private Label ad;

	private UIComboBox ae;

	private UIComboBox af;

	private Label ag;

	private DatePicker ah;

	private Label ai;

	private UIComboBox aj;

	private UIComboBox ak;

	private Label al;

	private bool am = false;

	private int an = 0;

	private int ao = 0;

	private string ap = "0";
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
						num = 5;
					}
					continue;
				case 1:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 3:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void h()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdn));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		StringFormat stringFormat3 = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat4 = new StringFormat();
		StringFormat stringFormat5 = new StringFormat();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
		StringFormat stringFormat6 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		w = new Panel();
		x = new Panel();
		ai = new Label();
		aj = new UIComboBox();
		ag = new Label();
		ah = new DatePicker();
		ad = new Label();
		ae = new UIComboBox();
		af = new UIComboBox();
		ac = new Label();
		y = new TextBox();
		z = new Label();
		aa = new UIButton();
		ab = new UIButton();
		v = new UIGroupBox();
		t = new GridEX();
		u = new Label();
		this.m_h = new UIGroupBox();
		this.m_m = new Label();
		this.m_n = new Label();
		this.m_o = new EditBox();
		this.m_p = new EditBox();
		this.m_k = new Label();
		this.m_l = new UIComboBox();
		this.m_i = new Label();
		this.m_j = new UIComboBox();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_g = new UIButton();
		this.m_f = new UIButton();
		this.m_q = new UIButton();
		r = new OpenFileDialog();
		s = new Panel();
		ak = new UIComboBox();
		al = new Label();
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		w.SuspendLayout();
		x.SuspendLayout();
		((ISupportInitialize)v).BeginInit();
		v.SuspendLayout();
		((ISupportInitialize)t).BeginInit();
		((ISupportInitialize)this.m_h).BeginInit();
		this.m_h.SuspendLayout();
		this.m_d.SuspendLayout();
		s.SuspendLayout();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(10, 100);
		this.m_b.Name = "gridEX1";
		this.m_b.RecordNavigator = true;
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(747, 131);
		this.m_b.TabIndex = 4;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_b.SelectionChanged += j;
		this.m_c.BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(w);
		this.m_c.Controls.Add(v);
		this.m_c.Controls.Add(u);
		this.m_c.Controls.Add(this.m_h);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Font = new Font("Tahoma", 8.25f);
		this.m_c.Location = new Point(5, 5);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(790, 589);
		this.m_c.TabIndex = 0;
		this.m_c.Paint += a;
		w.BackColor = Color.Gray;
		w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		w.Controls.Add(x);
		w.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.Location = new Point(58, 269);
		w.Name = "pStd";
		w.Size = new Size(514, 298);
		w.TabIndex = 79;
		w.Visible = false;
		x.BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		x.Controls.Add(ai);
		x.Controls.Add(aj);
		x.Controls.Add(ag);
		x.Controls.Add(ah);
		x.Controls.Add(ad);
		x.Controls.Add(ae);
		x.Controls.Add(af);
		x.Controls.Add(ac);
		x.Controls.Add(y);
		x.Controls.Add(z);
		x.Controls.Add(aa);
		x.Controls.Add(ab);
		x.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		x.Location = new Point(6, 7);
		x.Name = "panel3";
		x.Size = new Size(498, 281);
		x.TabIndex = 40;
		ai.AutoSize = true;
		ai.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ai.Location = new Point(428, 74);
		ai.Name = "lbook";
		ai.Size = new Size(36, 13);
		ai.TabIndex = 50;
		ai.Text = "درس :";
		aj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		aj.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		aj.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aj.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "انضباطی";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "تشویقی";
		uIComboBoxItem2.Value = "2";
		aj.Items.AddRange(new UIComboBoxItem[2] { uIComboBoxItem, uIComboBoxItem2 });
		aj.Location = new Point(149, 68);
		aj.Name = "dropBook";
		aj.Size = new Size(272, 24);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		aj.StringFormat = stringFormat;
		aj.TabIndex = 2;
		ag.AutoSize = true;
		ag.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.Location = new Point(428, 104);
		ag.Name = "label6";
		ag.Size = new Size(35, 13);
		ag.TabIndex = 48;
		ag.Text = "تاریخ :";
		ah.AutoToday = true;
		ah.BackColor = Color.SeaShell;
		ah.BijanForeColor = Color.Blue;
		ah.Location = new Point(276, 99);
		ah.Name = "txtDatafrom";
		ah.Size = new Size(144, 24);
		ah.TabIndex = 3;
		ah.the_date = new DateTime(2019, 1, 3, 14, 40, 32, 797);
		ah.the_label = "ازمون تاريخ:";
		ad.AutoSize = true;
		ad.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ad.Location = new Point(427, 43);
		ad.Name = "label3";
		ad.Size = new Size(40, 13);
		ad.TabIndex = 46;
		ad.Text = "عنوان :";
		ae.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ae.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ae.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ae.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ae.Location = new Point(16, 38);
		ae.Name = "dropDisciplinaryCases";
		ae.Size = new Size(405, 24);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		ae.StringFormat = stringFormat2;
		ae.TabIndex = 1;
		af.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		af.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		af.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "انضباطی";
		uIComboBoxItem3.Value = "1";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "اخطار آموزشی";
		uIComboBoxItem4.Value = "3";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "تشویقی";
		uIComboBoxItem5.Value = "2";
		af.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5 });
		af.Location = new Point(237, 6);
		af.Name = "dropType";
		af.Size = new Size(184, 24);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		af.StringFormat = stringFormat3;
		af.TabIndex = 0;
		af.SelectedIndexChanged += i;
		ac.AutoSize = true;
		ac.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ac.Location = new Point(427, 11);
		ac.Name = "label1";
		ac.Size = new Size(34, 13);
		ac.TabIndex = 43;
		ac.Text = "مورد :";
		y.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		y.Location = new Point(16, 134);
		y.Multiline = true;
		y.Name = "txtComment";
		y.Size = new Size(405, 82);
		y.TabIndex = 4;
		z.AutoSize = true;
		z.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		z.Location = new Point(427, 138);
		z.Name = "label2";
		z.Size = new Size(54, 13);
		z.TabIndex = 42;
		z.Text = "توضیحات :";
		aa.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aa.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		aa.Location = new Point(16, 233);
		aa.Name = "btnCancel";
		aa.Size = new Size(75, 38);
		aa.TabIndex = 6;
		aa.Text = "انصراف";
		aa.Click += g;
		ab.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		ab.Location = new Point(97, 233);
		ab.Name = "btnAcp";
		ab.Size = new Size(75, 38);
		ab.TabIndex = 5;
		ab.Text = "تایید";
		ab.Click += h;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		v.Controls.Add(ak);
		v.Controls.Add(al);
		v.Controls.Add(t);
		v.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Location = new Point(12, 236);
		v.Name = "uiGroupBox2";
		v.Size = new Size(581, 346);
		v.TabIndex = 2;
		v.Text = "موارد انضباطی ، تشویقی و اخطارهای آموزشی شاگرد";
		t.AllowEdit = InheritableBoolean.False;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		t.DesignTimeLayout = gridEXLayout2;
		t.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		t.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.GroupByBoxVisible = false;
		t.Location = new Point(11, 58);
		t.Name = "gridEX2";
		t.RecordNavigator = true;
		t.RowHeaders = InheritableBoolean.True;
		t.Size = new Size(562, 283);
		t.TabIndex = 18;
		t.VisualStyle = VisualStyle.Office2003;
		t.SelectionChanged += f;
		u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		u.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(599, 244);
		u.Name = "lName";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(171, 113);
		u.TabIndex = 77;
		u.TextAlign = ContentAlignment.MiddleCenter;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_h.Controls.Add(this.m_m);
		this.m_h.Controls.Add(this.m_n);
		this.m_h.Controls.Add(this.m_b);
		this.m_h.Controls.Add(this.m_o);
		this.m_h.Controls.Add(this.m_p);
		this.m_h.Controls.Add(this.m_k);
		this.m_h.Controls.Add(this.m_l);
		this.m_h.Controls.Add(this.m_i);
		this.m_h.Controls.Add(this.m_j);
		this.m_h.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_h.Location = new Point(13, -1);
		this.m_h.Name = "uiGroupBox1";
		this.m_h.Size = new Size(764, 239);
		this.m_h.TabIndex = 0;
		this.m_h.Text = "جستجو";
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.AutoSize = true;
		this.m_m.Location = new Point(665, 67);
		this.m_m.Name = "label5";
		this.m_m.Size = new Size(84, 24);
		this.m_m.TabIndex = 29;
		this.m_m.Text = "نام خانوادگی";
		this.m_n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_n.AutoSize = true;
		this.m_n.Location = new Point(387, 67);
		this.m_n.Name = "label4";
		this.m_n.Size = new Size(26, 24);
		this.m_n.TabIndex = 28;
		this.m_n.Text = "نام";
		this.m_o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_o.AutoScroll = false;
		this.m_o.AutoScrollMargin = new Size(0, 0);
		this.m_o.AutoScrollMinSize = new Size(0, 0);
		this.m_o.AutoScrollPosition = new Point(0, 0);
		this.m_o.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_o.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_o.Location = new Point(458, 67);
		this.m_o.Name = "txtLName";
		this.m_o.RightToLeft = RightToLeft.Yes;
		this.m_o.Size = new Size(201, 27);
		this.m_o.TabIndex = 2;
		this.m_o.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_o.Leave += e;
		this.m_o.KeyUp += b;
		this.m_o.Enter += d;
		this.m_p.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_p.AutoScroll = false;
		this.m_p.AutoScrollMargin = new Size(0, 0);
		this.m_p.AutoScrollMinSize = new Size(0, 0);
		this.m_p.AutoScrollPosition = new Point(0, 0);
		this.m_p.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_p.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_p.Location = new Point(175, 67);
		this.m_p.Name = "txtFName";
		this.m_p.RightToLeft = RightToLeft.Yes;
		this.m_p.Size = new Size(201, 27);
		this.m_p.TabIndex = 3;
		this.m_p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_p.Leave += b;
		this.m_p.KeyUp += b;
		this.m_p.Enter += c;
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.AutoSize = true;
		this.m_k.Location = new Point(382, 22);
		this.m_k.Name = "label19";
		this.m_k.Size = new Size(42, 24);
		this.m_k.TabIndex = 25;
		this.m_k.Text = "صنف";
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_l.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_l.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_l.Location = new Point(175, 18);
		this.m_l.Name = "dropCls";
		this.m_l.Size = new Size(201, 31);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		this.m_l.StringFormat = stringFormat4;
		this.m_l.TabIndex = 1;
		this.m_l.SelectedIndexChanged += l;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(665, 24);
		this.m_i.Name = "label20";
		this.m_i.Size = new Size(33, 24);
		this.m_i.TabIndex = 15;
		this.m_i.Text = "پایه";
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_j.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_j.Location = new Point(458, 18);
		this.m_j.Name = "dropPaye";
		this.m_j.Size = new Size(201, 31);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		this.m_j.StringFormat = stringFormat5;
		this.m_j.TabIndex = 0;
		this.m_j.SelectedIndexChanged += m;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(this.m_q);
		this.m_d.Font = new Font("B Nazanin", 12f);
		this.m_d.Location = new Point(599, 360);
		this.m_d.Name = "p_new";
		this.m_d.Size = new Size(183, 224);
		this.m_d.TabIndex = 1;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_e.Location = new Point(15, 119);
		this.m_e.Name = "btnDelete";
		this.m_e.Size = new Size(149, 46);
		this.m_e.TabIndex = 2;
		this.m_e.Text = "حذف";
		this.m_e.Click += k;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_g.ImageSize = new Size(20, 20);
		this.m_g.Location = new Point(15, 171);
		this.m_g.Name = "btnClose";
		this.m_g.Size = new Size(149, 46);
		this.m_g.TabIndex = 3;
		this.m_g.Text = "بستن";
		this.m_g.Click += n;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_f.Location = new Point(15, 16);
		this.m_f.Name = "btnNew";
		this.m_f.Size = new Size(149, 45);
		this.m_f.TabIndex = 0;
		this.m_f.Text = "ثبت مورد جدید(F1)";
		this.m_f.Click += p;
		this.m_q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_q.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_q.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_q.Location = new Point(15, 67);
		this.m_q.Name = "btnEdit";
		this.m_q.Size = new Size(149, 46);
		this.m_q.TabIndex = 1;
		this.m_q.Text = "اصلاح";
		this.m_q.Click += o;
		r.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		r.Title = "انتخاب عکس شاگرد";
		s.BackColor = Color.Black;
		s.Controls.Add(this.m_c);
		s.Dock = DockStyle.Fill;
		s.Location = new Point(0, 0);
		s.Name = "panel2";
		s.Size = new Size(800, 600);
		s.TabIndex = 1;
		ak.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ak.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ak.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "همه موارد";
		uIComboBoxItem6.Value = "0";
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "انضباطی";
		uIComboBoxItem7.Value = "1";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "اخطار آموزشی";
		uIComboBoxItem8.Value = "3";
		uIComboBoxItem9.FormatStyle.Alpha = 0;
		uIComboBoxItem9.Text = "تشویقی";
		uIComboBoxItem9.Value = "2";
		ak.Items.AddRange(new UIComboBoxItem[4] { uIComboBoxItem6, uIComboBoxItem7, uIComboBoxItem8, uIComboBoxItem9 });
		ak.Location = new Point(318, 28);
		ak.Name = "dropFilterType";
		ak.Size = new Size(184, 24);
		stringFormat6.Alignment = StringAlignment.Near;
		stringFormat6.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat6.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat6.LineAlignment = StringAlignment.Center;
		stringFormat6.Trimming = StringTrimming.Character;
		ak.StringFormat = stringFormat6;
		ak.TabIndex = 44;
		ak.SelectedIndexChanged += a;
		al.AutoSize = true;
		al.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		al.Location = new Point(508, 33);
		al.Name = "label7";
		al.Size = new Size(67, 13);
		al.TabIndex = 45;
		al.Text = "مشاهده ی :";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(s);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmDisciplinaryAdd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست شاگردان";
		Load += q;
		KeyUp += a;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		w.ResumeLayout(performLayout: false);
		x.ResumeLayout(performLayout: false);
		x.PerformLayout();
		((ISupportInitialize)v).EndInit();
		v.ResumeLayout(performLayout: false);
		v.PerformLayout();
		((ISupportInitialize)t).EndInit();
		((ISupportInitialize)this.m_h).EndInit();
		this.m_h.ResumeLayout(performLayout: false);
		this.m_h.PerformLayout();
		this.m_d.ResumeLayout(performLayout: false);
		s.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdn()
	{
		h();
	}

	private void q(object A_0, EventArgs A_1)
	{
		while (true)
		{
			f();
			g();
			d();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM  tCardProperties");
			bool flag = dataTable.Rows.Count <= 0;
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

	private void g()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			this.m_j.Items.Add("کل", "0");
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 2;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					this.m_j.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 1:
					this.m_j.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void f()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name,xpaye from tClass");
			this.m_l.Items.Add("همه صنفها", "0");
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					this.m_l.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 1;
					continue;
				case 2:
					if (true)
					{
					}
					this.m_l.SelectedIndex = 0;
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
			if (true)
			{
			}
			bool flag = af.SelectedIndex < 0;
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
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tDisciplinaryCases where typ=" + af.SelectedValue.ToString());
					ae.DataSource = dataSource;
					ae.DisplayMember = "Name";
					ae.ValueMember = "id";
					num = 1;
					continue;
				}
				case 1:
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
			ao = an;
			string text = "";
			bool flag = this.m_l.SelectedIndex <= 0;
			int num = 28;
			while (true)
			{
				switch (num)
				{
				case 28:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 27;
				case 7:
					flag = !(text != "");
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 5;
				case 4:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 3;
				case 19:
					flag = !(text != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 17;
				case 23:
					num = 2;
					continue;
				case 10:
					if (true)
					{
					}
					text = text + " tstudent.xClass=" + this.m_l.SelectedValue.ToString();
					num = 27;
					continue;
				case 3:
					text = text + " tstudent.LName like '%" + asdaj.b(this.m_o.Text) + "%'";
					num = 7;
					continue;
				case 21:
					text = text + " tstudent.FName like '%" + asdaj.b(this.m_p.Text) + "%'";
					num = 6;
					continue;
				case 9:
					text += " and ";
					num = 17;
					continue;
				case 2:
					try
					{
						this.m_b.Row = ao;
						this.m_b.Focus();
					}
					catch
					{
					}
					num = 25;
					continue;
				case 13:
					flag = !(text != "");
					num = 29;
					continue;
				case 29:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 21;
				case 16:
					flag = !(text != "");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 10;
				case 27:
					flag = this.m_j.SelectedIndex <= 0;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 24;
				case 17:
					text = text + " tstudent.xPaye=" + this.m_j.SelectedValue.ToString();
					num = 24;
					continue;
				case 24:
					flag = !(this.m_p.Text.Trim() != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 6;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code,  tStudent.Code, tStudent.xPaye, tStudent.xClass, tStudent.xReshteh, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Sh_Sh, \r\n                   tStudent.MobileMother,tStudent.MobileFather,   tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tPaye ON tStudent.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tStudent.xClass = tClass.id " + text + " order by tStudent.sort,tStudent.lname,tStudent.fname");
					this.m_b.DataSource = dataSource;
					flag = !am;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 25;
				case 1:
					text = " where " + text;
					num = 5;
					continue;
				case 15:
					text += " and ";
					num = 21;
					continue;
				case 6:
					flag = !(this.m_o.Text.Trim() != "");
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 7;
				case 26:
					text += " and ";
					num = 3;
					continue;
				case 18:
					text += " and ";
					num = 10;
					continue;
				case 25:
					am = false;
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		string text = default;
		bool flag = default;
		while (true)
		{
			t.DataSource = null;
			u.Text = "";
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((this.m_b.RowCount <= 0) ? 6 : 10);
					continue;
				case 8:
					text += " and ";
					num = 1;
					continue;
				case 4:
					flag = !(text != "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 1;
				case 6:
					num2 = 1;
					goto IL_02c0;
				case 11:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT tDisciplinaryStudent.id,    tDisciplinaryCases.name AS DisciplinaryCases, tDisciplinaryStudent.xDisciplinaryCases, tDisciplinaryCases.typ\r\n                       ,case tDisciplinaryCases.typ  when 1 then N'انضباطی' when 2 then N'تشویقی' when 3 then N'اخطار آموزشی' end as typText, tDisciplinaryCases.mark, \r\n                      tDisciplinaryStudent.DateDis, tDisciplinaryStudent.comment,tbook.name as book,tDisciplinaryStudent.xbook\r\n                      FROM  tDisciplinaryStudent INNER JOIN\r\n                      tDisciplinaryCases ON tDisciplinaryStudent.xDisciplinaryCases = tDisciplinaryCases.id left outer join\r\n                      tbook on tDisciplinaryStudent.xbook=tbook.id\r\n                    WHERE     (tDisciplinaryStudent.xStudent = " + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")" + text);
					t.DataSource = dataSource;
					num = 7;
					continue;
				}
				case 7:
					return;
				case 10:
					num = 12;
					continue;
				case 12:
					if (true)
					{
					}
					num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_02c0;
				case 1:
					text = text + " and tDisciplinaryCases.typ=" + ak.SelectedValue.ToString();
					num = 11;
					continue;
				case 0:
					u.Text = this.m_b.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + this.m_b.SelectedItems[0].GetRow().Cells["lname"].Value.ToString() + "\nنام پدر :" + this.m_b.SelectedItems[0].GetRow().Cells["pname"].Value.ToString();
					text = "";
					flag = ak.SelectedIndex <= 0;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 11;
				case 3:
					{
						if (!flag)
						{
							num = 0;
							continue;
						}
						return;
					}
					IL_02c0:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default;
			while (true)
			{
				int num = 7;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 7:
						num = ((this.m_b.RowCount > 0) ? 3 : 0);
						continue;
					case 3:
						num = 1;
						continue;
					case 1:
						num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_00d2;
					case 5:
						w.Visible = true;
						af.Enabled = true;
						af.Focus();
						ap = "0";
						num = 6;
						continue;
					case 0:
						num2 = 1;
						goto IL_00d2;
					case 2:
						if (!flag)
						{
							if (true)
							{
							}
							num = 5;
							continue;
						}
						goto case 6;
					case 6:
						num = 4;
						continue;
					case 4:
						return;
						IL_00d2:
						flag = (byte)num2 != 0;
						num = 2;
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

	private void o(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		try
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
						num = ((t.RowCount <= 0) ? 3 : 2);
						continue;
					case 2:
						num = 0;
						continue;
					case 0:
						num2 = ((t.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_00ca;
					case 4:
						af.Enabled = false;
						b();
						w.Visible = true;
						num = 1;
						continue;
					case 3:
						num2 = 1;
						goto IL_00ca;
					case 6:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 1;
					case 1:
						num = 7;
						continue;
					case 7:
						return;
						IL_00ca:
						flag = (byte)num2 != 0;
						num = 6;
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

	private void b()
	{
		if (true)
		{
		}
		ap = t.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		y.Text = t.SelectedItems[0].GetRow().Cells["comment"].Value.ToString();
		af.SelectedValue = t.SelectedItems[0].GetRow().Cells["typ"].Value.ToString();
		ae.SelectedValue = t.SelectedItems[0].GetRow().Cells["xDisciplinaryCases"].Value.ToString();
		aj.SelectedValue = t.SelectedItems[0].GetRow().Cells["xbook"].Value.ToString();
		ah.the_date = ShamsiDate.ShamsiToGregory(t.SelectedItems[0].GetRow().Cells["DateDis"].Value.ToString());
		ae.Focus();
	}

	private void n(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void m(object A_0, EventArgs A_1)
	{
		d();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = A_1.KeyCode.ToString();
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					if (A_1.KeyCode != Keys.F5)
					{
						num = 8;
						continue;
					}
					goto IL_007f;
				case 8:
					if (true)
					{
					}
					num = 6;
					continue;
				case 7:
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					num2 = 0;
					goto IL_00ef;
				case 6:
					if (!(text == "Return"))
					{
						num = 2;
						continue;
					}
					goto IL_007f;
				case 9:
					return;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = ((A_1.KeyCode != Keys.F1) ? 1 : 0);
					goto IL_00ef;
				case 3:
					{
						if (flag)
						{
							d();
							num = 9;
						}
						else
						{
							num = 7;
						}
						continue;
					}
					IL_007f:
					num = 5;
					continue;
					IL_00ef:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		d();
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default;
			while (true)
			{
				int num = 8;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 8:
						num = ((t.RowCount <= 0) ? 6 : 5);
						continue;
					case 6:
						num2 = 1;
						goto IL_015c;
					case 1:
						num = 2;
						continue;
					case 5:
						num = 0;
						continue;
					case 0:
						if (true)
						{
						}
						num2 = ((t.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_015c;
					case 9:
						asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryStudent where id=" + t.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						c();
						num = 1;
						continue;
					case 3:
						flag = MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 7;
						continue;
					case 7:
						if (!flag)
						{
							num = 9;
							continue;
						}
						goto case 1;
					case 4:
						if (!flag)
						{
							num = 3;
							continue;
						}
						goto case 2;
					case 2:
						num = 10;
						continue;
					case 10:
						return;
						IL_015c:
						flag = (byte)num2 != 0;
						num = 4;
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

	private void j(object A_0, EventArgs A_1)
	{
		c();
		w.Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			e();
			bool flag = !(af.SelectedValue.ToString() == "3");
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
					ai.Visible = false;
					aj.Visible = false;
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					ai.Visible = true;
					aj.Visible = true;
					a();
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		string text = default;
		string a_ = default;
		while (true)
		{
			bool flag = af.SelectedIndex >= 0;
			int num = 16;
			while (true)
			{
				switch (num)
				{
				case 16:
					if (!flag)
					{
						num = 23;
						continue;
					}
					flag = ae.SelectedIndex >= 0;
					num = 7;
					continue;
				case 8:
					text = "چهارشنبه";
					num = 3;
					continue;
				case 28:
					text = "دوشنبه";
					num = 35;
					continue;
				case 15:
					flag = aj.SelectedIndex > 0;
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 21;
						continue;
					}
					a_ = aj.SelectedValue.ToString();
					num = 10;
					continue;
				case 17:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 3;
				case 9:
					MessageBox.Show("عنوان را انتخاب کنید");
					ae.Focus();
					num = 0;
					continue;
				case 0:
					return;
				case 4:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = !(text == "Thursday");
					num = 14;
					continue;
				case 3:
				case 11:
				case 25:
				case 29:
				case 32:
				case 33:
				case 35:
				{
					SqlParameter[] a_2 = new SqlParameter[7]
					{
						asdcb.a("@id", SqlDbType.Int, ap),
						asdcb.a("@xStudent", SqlDbType.Int, this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()),
						asdcb.a("@DateDis", SqlDbType.NVarChar, 10, ShamsiDate.GetShamsiDate(ah.the_date)),
						asdcb.a("@dayOfWeek", SqlDbType.NVarChar, 20, text),
						asdcb.a("@xDisciplinaryCases", SqlDbType.Int, ae.SelectedValue.ToString()),
						asdcb.a("@comment", SqlDbType.NVarChar, asdaj.b(y.Text.Trim())),
						asdcb.a("@xbook", SqlDbType.Int, a_)
					};
					int num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryStudent_insertUpdate", a_2);
					flag = num2 <= 0;
					num = 30;
					continue;
				}
				case 30:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 13:
					if (!flag)
					{
						num = 28;
						continue;
					}
					flag = !(text == "Tuesday");
					num = 5;
					continue;
				case 21:
					MessageBox.Show("درس را انتخاب کنید");
					aj.Focus();
					num = 27;
					continue;
				case 27:
					return;
				case 20:
					text = "جمعه";
					num = 29;
					continue;
				case 2:
					ak.SelectedIndex = 0;
					y.Text = "";
					w.Visible = false;
					c();
					MessageBox.Show("ثبت شد");
					this.m_o.SelectAll();
					this.m_o.Focus();
					num = 18;
					continue;
				case 18:
					return;
				case 12:
					text = "شنبه";
					num = 32;
					continue;
				case 23:
					MessageBox.Show("مورد را انتخاب کنید");
					af.Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 19:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 10;
				case 10:
					text = ah.the_date.DayOfWeek.ToString();
					flag = !(text == "Saturday");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(text == "Sunday");
					num = 6;
					continue;
				case 26:
					text = "پنج شنبه";
					num = 33;
					continue;
				case 34:
					text = "سه شنبه";
					num = 25;
					continue;
				case 6:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 13;
					}
					else
					{
						num = 31;
					}
					continue;
				case 31:
					if (true)
					{
					}
					text = "یکشنبه";
					num = 11;
					continue;
				case 5:
					if (flag)
					{
						flag = !(text == "Wednesday");
						num = 4;
					}
					else
					{
						num = 34;
					}
					continue;
				case 7:
					if (flag)
					{
						a_ = "0";
						flag = !(af.SelectedValue.ToString() == "3");
						num = 19;
					}
					else
					{
						num = 9;
					}
					continue;
				case 14:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 17;
					}
					else
					{
						num = 26;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			aj.DataSource = null;
			string text = this.m_b.SelectedItems[0].GetRow().Cells["xpaye"].Value.ToString();
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                              union\r\n                                                                                             select id,name from tbook where xPaye=" + text);
			aj.DataSource = dataSource;
			aj.DisplayMember = "Name";
			aj.ValueMember = "id";
			bool flag = aj.Items.Count <= 0;
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
					return;
				case 2:
					aj.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
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
		this.m_o.BackColor = Color.White;
	}

	private void d(object A_0, EventArgs A_1)
	{
		this.m_o.BackColor = Color.Yellow;
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_p.BackColor = Color.Yellow;
	}

	private void b(object A_0, EventArgs A_1)
	{
		this.m_p.BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F1;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 0:
					n(this, null);
					num = 1;
					continue;
				case 2:
					flag = A_1.KeyCode != Keys.Escape;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 5:
					p(this, null);
					num = 2;
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

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((ak.SelectedValue.ToString() == "0") ? 7 : 3);
					continue;
				case 0:
					t.Tables[0].Columns["book"].Visible = true;
					num = 6;
					continue;
				case 7:
					num2 = 0;
					goto IL_011d;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((!(ak.SelectedValue.ToString() == "3")) ? 1 : 0);
					goto IL_011d;
				case 1:
					if (flag)
					{
						t.Tables[0].Columns["book"].Visible = false;
						num = 4;
					}
					else
					{
						num = 0;
					}
					continue;
				case 4:
				case 6:
					{
						c();
						return;
					}
					IL_011d:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}
}
