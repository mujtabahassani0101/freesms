using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using school_Af.Properties;

public class asdt : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private ComboBox m_e;

	private GroupBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private Label m_i;

	private UIComboBox m_j;

	private Label m_k;

	private UIComboBox m_l;

	private Label m_m;

	private GridEX m_n;

	private UIComboBox m_o;

	private Label m_p;

	private GroupBox m_q;

	private Label m_r;

	private Label m_s;

	private DatePicker m_t;

	private Label m_u;

	private TextBox m_v;

	private TextBox m_w;

	private Label m_x;

	private TextBox m_y;

	private Button m_z;

	private OpenFileDialog m_aa;

	private UIButton m_ab;

	private UIButton m_ac;

	private Panel m_ad;

	private UIButton m_ae;

	private UIButton m_af;

	private Label m_ag;

	private EditBox ah;

	private Panel ai;

	private UIButton aj;

	private UIButton ak;

	private UIButton al;

	private TextBox am;

	private Label an;

	private RadioButton ao;

	private RadioButton ap;

	private UIGroupBox aq;

	private UIButton ar;

	private UIButton @as;

	private GridEX at;

	private UIGroupBox au;

	private UIButton av;

	private UIGroupBox aw;

	private Label ax;

	private Label ay;

	private GridEX az;

	private EditBox a0;

	private EditBox a1;

	private Label a2;

	private UIComboBox a3;

	private Label a4;

	private UIComboBox a5;

	private UIButton a6;

	private UIButton a7;

	private TextBox a8;

	private Label a9;

	private Panel ba;

	private TextBox bb;

	private TextBox bc;

	private TextBox bd;

	private Button be;

	private Button bf;

	private Button bg;

	private TextBox bh;

	private Button bi;

	private TextBox bj;

	private Button bk;

	private UIButton bl;

	private UIButton bm;

	private UIButton bn;

	private UIButton bo;

	private UIButton bp;

	private UIButton bq;

	private UIGroupBox br;

	private GridEX bs;

	private DatePicker bt;

	private Label bu;

	private Label bv;

	private DatePicker bw;

	public string bx = "";
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
						num = 5;
					}
					else
					{
						num = 4;
					}
					continue;
				case 5:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 6:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 3:
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

	private void m()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdt));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout3 = new GridEXLayout();
		StringFormat stringFormat3 = new StringFormat();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		StringFormat stringFormat4 = new StringFormat();
		StringFormat stringFormat5 = new StringFormat();
		StringFormat stringFormat6 = new StringFormat();
		GridEXLayout gridEXLayout4 = new GridEXLayout();
		this.m_b = new Panel();
		br = new UIGroupBox();
		bt = new DatePicker();
		bu = new Label();
		bv = new Label();
		bw = new DatePicker();
		bs = new GridEX();
		aw = new UIGroupBox();
		a7 = new UIButton();
		a6 = new UIButton();
		ax = new Label();
		ay = new Label();
		az = new GridEX();
		a0 = new EditBox();
		a1 = new EditBox();
		a2 = new Label();
		a3 = new UIComboBox();
		a4 = new Label();
		a5 = new UIComboBox();
		au = new UIGroupBox();
		ap = new RadioButton();
		ao = new RadioButton();
		aq = new UIGroupBox();
		av = new UIButton();
		ar = new UIButton();
		@as = new UIButton();
		at = new GridEX();
		this.m_g = new Label();
		this.m_q = new GroupBox();
		bl = new UIButton();
		ba = new Panel();
		bm = new UIButton();
		bn = new UIButton();
		bo = new UIButton();
		bp = new UIButton();
		bq = new UIButton();
		bb = new TextBox();
		bc = new TextBox();
		bd = new TextBox();
		be = new Button();
		bf = new Button();
		bg = new Button();
		bh = new TextBox();
		bi = new Button();
		bj = new TextBox();
		bk = new Button();
		a8 = new TextBox();
		a9 = new Label();
		am = new TextBox();
		an = new Label();
		this.m_z = new Button();
		this.m_x = new Label();
		this.m_y = new TextBox();
		this.m_w = new TextBox();
		this.m_u = new Label();
		this.m_v = new TextBox();
		this.m_r = new Label();
		this.m_s = new Label();
		this.m_t = new DatePicker();
		this.m_h = new UIComboBox();
		al = new UIButton();
		aj = new UIButton();
		this.m_c = new Panel();
		this.m_f = new GroupBox();
		this.m_m = new Label();
		this.m_o = new UIComboBox();
		this.m_k = new Label();
		this.m_p = new Label();
		this.m_i = new Label();
		this.m_l = new UIComboBox();
		this.m_j = new UIComboBox();
		this.m_e = new ComboBox();
		ai = new Panel();
		this.m_ac = new UIButton();
		this.m_ab = new UIButton();
		ak = new UIButton();
		this.m_n = new GridEX();
		this.m_d = new Panel();
		this.m_aa = new OpenFileDialog();
		this.m_ad = new Panel();
		this.m_ae = new UIButton();
		this.m_af = new UIButton();
		this.m_ag = new Label();
		ah = new EditBox();
		this.m_b.SuspendLayout();
		((ISupportInitialize)br).BeginInit();
		br.SuspendLayout();
		((ISupportInitialize)bs).BeginInit();
		((ISupportInitialize)aw).BeginInit();
		aw.SuspendLayout();
		((ISupportInitialize)az).BeginInit();
		((ISupportInitialize)au).BeginInit();
		au.SuspendLayout();
		((ISupportInitialize)aq).BeginInit();
		aq.SuspendLayout();
		((ISupportInitialize)at).BeginInit();
		this.m_q.SuspendLayout();
		ba.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_f.SuspendLayout();
		ai.SuspendLayout();
		((ISupportInitialize)this.m_n).BeginInit();
		this.m_d.SuspendLayout();
		this.m_ad.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(br);
		this.m_b.Controls.Add(aw);
		this.m_b.Controls.Add(au);
		this.m_b.Controls.Add(aq);
		this.m_b.Controls.Add(this.m_g);
		this.m_b.Controls.Add(this.m_q);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Controls.Add(al);
		this.m_b.Controls.Add(aj);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(ai);
		this.m_b.Location = new Point(4, 5);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(507, 630);
		this.m_b.TabIndex = 19;
		br.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		br.Controls.Add(bt);
		br.Controls.Add(bu);
		br.Controls.Add(bv);
		br.Controls.Add(bw);
		br.Controls.Add(bs);
		br.Font = new Font("Tahoma", 8.25f);
		br.Location = new Point(155, 319);
		br.Name = "groupBDate";
		br.RightToLeft = RightToLeft.Yes;
		br.Size = new Size(344, 294);
		br.TabIndex = 135;
		br.Text = "لیست دانش آموزان متولد بین روزهای زیر";
		br.Visible = false;
		bt.AutoToday = false;
		bt.BackColor = Color.SeaShell;
		bt.BijanForeColor = Color.Blue;
		bt.Location = new Point(111, 65);
		bt.Name = "txtDateTo";
		bt.Size = new Size(144, 24);
		bt.TabIndex = 140;
		bt.the_date = new DateTime(2020, 8, 18, 0, 0, 0, 0);
		bt.the_label = "ازمون تاريخ:";
		bt.DateChanged += a;
		bu.AutoSize = true;
		bu.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bu.Location = new Point(264, 69);
		bu.Name = "label12";
		bu.Size = new Size(56, 13);
		bu.TabIndex = 139;
		bu.Text = "روز تولد تا :";
		bv.AutoSize = true;
		bv.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bv.Location = new Point(261, 28);
		bv.Name = "label6";
		bv.Size = new Size(57, 13);
		bv.TabIndex = 138;
		bv.Text = "روز تولد از :";
		bw.AutoToday = false;
		bw.BackColor = Color.SeaShell;
		bw.BijanForeColor = Color.Blue;
		bw.Location = new Point(111, 24);
		bw.Name = "dateBDateFrom";
		bw.Size = new Size(144, 24);
		bw.TabIndex = 137;
		bw.the_date = new DateTime(2020, 8, 18, 0, 0, 0, 0);
		bw.the_label = "ازمون تاريخ:";
		bw.DateChanged += b;
		bs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		bs.DesignTimeLayout = gridEXLayout;
		bs.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		bs.Font = new Font("Tahoma", 8.25f);
		bs.GroupByBoxVisible = false;
		bs.Location = new Point(8, 98);
		bs.Name = "gStdBdate";
		bs.RecordNavigator = true;
		bs.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		bs.Size = new Size(323, 193);
		bs.TabIndex = 135;
		bs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		aw.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		aw.Controls.Add(a7);
		aw.Controls.Add(a6);
		aw.Controls.Add(ax);
		aw.Controls.Add(ay);
		aw.Controls.Add(az);
		aw.Controls.Add(a0);
		aw.Controls.Add(a1);
		aw.Controls.Add(a2);
		aw.Controls.Add(a3);
		aw.Controls.Add(a4);
		aw.Controls.Add(a5);
		aw.Font = new Font("Tahoma", 8.25f);
		aw.Location = new Point(6, 1);
		aw.Name = "groupSearchStd";
		aw.RightToLeft = RightToLeft.Yes;
		aw.Size = new Size(495, 415);
		aw.TabIndex = 134;
		aw.Text = "جستجو";
		aw.Visible = false;
		a7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		a7.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		a7.Image = Resources.end;
		a7.ImageSize = new Size(30, 30);
		a7.Location = new Point(12, 353);
		a7.Name = "btnCancelSelect";
		a7.Size = new Size(86, 45);
		a7.TabIndex = 137;
		a7.Text = "اتمام";
		a7.Click += n;
		a6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		a6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		a6.Image = Resources.down;
		a6.ImageSize = new Size(40, 40);
		a6.Location = new Point(170, 356);
		a6.Name = "btnAdd";
		a6.Size = new Size(318, 45);
		a6.TabIndex = 136;
		a6.Text = "اضافه کردن دانش آموز انتخاب شده به لیست زیر";
		a6.Click += q;
		ax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ax.AutoSize = true;
		ax.Font = new Font("Tahoma", 8.25f);
		ax.Location = new Point(185, 54);
		ax.Name = "label7";
		ax.Size = new Size(42, 13);
		ax.TabIndex = 29;
		ax.Text = "ولد/بنت";
		ay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ay.AutoSize = true;
		ay.Font = new Font("Tahoma", 8.25f);
		ay.Location = new Point(189, 32);
		ay.Name = "label2";
		ay.Size = new Size(20, 13);
		ay.TabIndex = 28;
		ay.Text = "نام";
		az.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		az.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		az.DesignTimeLayout = gridEXLayout2;
		az.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		az.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		az.GroupByBoxVisible = false;
		az.Location = new Point(12, 83);
		az.Name = "gridStdSearch";
		az.RecordNavigator = true;
		az.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		az.Size = new Size(476, 264);
		az.TabIndex = 5;
		az.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		a0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a0.AutoScroll = false;
		a0.AutoScrollMargin = new Size(0, 0);
		a0.AutoScrollMinSize = new Size(0, 0);
		a0.AutoScrollPosition = new Point(0, 0);
		a0.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a0.Font = new Font("Tahoma", 8.25f);
		a0.Location = new Point(24, 51);
		a0.Name = "txtLName";
		a0.RightToLeft = RightToLeft.Yes;
		a0.Size = new Size(155, 21);
		a0.TabIndex = 4;
		a0.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a0.KeyUp += a;
		a1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a1.AutoScroll = false;
		a1.AutoScrollMargin = new Size(0, 0);
		a1.AutoScrollMinSize = new Size(0, 0);
		a1.AutoScrollPosition = new Point(0, 0);
		a1.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a1.Font = new Font("Tahoma", 8.25f);
		a1.Location = new Point(24, 27);
		a1.Name = "txtFName";
		a1.RightToLeft = RightToLeft.Yes;
		a1.Size = new Size(155, 21);
		a1.TabIndex = 3;
		a1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a1.KeyUp += a;
		a2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a2.AutoSize = true;
		a2.Location = new Point(450, 57);
		a2.Name = "label9";
		a2.Size = new Size(30, 13);
		a2.TabIndex = 25;
		a2.Text = "صنف";
		a3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a3.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		a3.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a3.Font = new Font("Tahoma", 8.25f);
		a3.Location = new Point(260, 53);
		a3.Name = "dropClsSearch";
		a3.Size = new Size(184, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		a3.StringFormat = stringFormat;
		a3.TabIndex = 2;
		a3.SelectedIndexChanged += r;
		a4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a4.AutoSize = true;
		a4.Font = new Font("Tahoma", 8.25f);
		a4.Location = new Point(450, 35);
		a4.Name = "label10";
		a4.Size = new Size(22, 13);
		a4.TabIndex = 15;
		a4.Text = "پایه";
		a5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a5.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		a5.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a5.Font = new Font("Tahoma", 8.25f);
		a5.Location = new Point(260, 29);
		a5.Name = "dropPayeSearch";
		a5.Size = new Size(184, 21);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		a5.StringFormat = stringFormat2;
		a5.TabIndex = 1;
		a5.SelectedIndexChanged += s;
		au.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		au.Controls.Add(ap);
		au.Controls.Add(ao);
		au.Font = new Font("Tahoma", 8.25f);
		au.Location = new Point(10, 421);
		au.Name = "groupTypeSelect";
		au.RightToLeft = RightToLeft.Yes;
		au.Size = new Size(141, 83);
		au.TabIndex = 133;
		au.Text = "چاپ بر اساس ";
		au.Visible = false;
		ap.AutoSize = true;
		ap.Checked = true;
		ap.Location = new Point(84, 26);
		ap.Name = "rClass";
		ap.Size = new Size(48, 17);
		ap.TabIndex = 0;
		ap.TabStop = true;
		ap.Text = "صنف";
		ap.UseVisualStyleBackColor = true;
		ap.CheckedChanged += v;
		ao.AutoSize = true;
		ao.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ao.Location = new Point(9, 54);
		ao.Name = "rStd";
		ao.Size = new Size(123, 17);
		ao.TabIndex = 1;
		ao.Text = "انتخاب چند دانش آموز";
		ao.UseVisualStyleBackColor = true;
		ao.CheckedChanged += u;
		aq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		aq.Controls.Add(av);
		aq.Controls.Add(ar);
		aq.Controls.Add(@as);
		aq.Controls.Add(at);
		aq.Font = new Font("Tahoma", 8.25f);
		aq.Location = new Point(157, 421);
		aq.Name = "groupListStd";
		aq.RightToLeft = RightToLeft.Yes;
		aq.Size = new Size(345, 192);
		aq.TabIndex = 132;
		aq.Text = "لیست دانش آموزان جهت نمایش در گزارش";
		aq.Visible = false;
		av.Image = Resources._new;
		av.Location = new Point(4, 27);
		av.Name = "btnNewStd";
		av.Size = new Size(113, 45);
		av.TabIndex = 135;
		av.Text = "افزودن دانش آموز به لیست پرینت";
		av.Click += t;
		ar.Image = Resources.free;
		ar.ImageSize = new Size(20, 20);
		ar.Location = new Point(4, 140);
		ar.Name = "btnFree";
		ar.Size = new Size(113, 45);
		ar.TabIndex = 134;
		ar.Text = "خالی کردن کل لیست پرینت";
		ar.Click += o;
		@as.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		@as.Image = (Image)componentResourceManager.GetObject("btnDeleteStd.Image");
		@as.Location = new Point(5, 84);
		@as.Name = "btnDeleteStd";
		@as.Size = new Size(113, 45);
		@as.TabIndex = 133;
		@as.Text = "حذف مورد انتخابی از لیست پرینت";
		@as.Click += p;
		at.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		at.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		at.DesignTimeLayout = gridEXLayout3;
		at.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		at.Font = new Font("Tahoma", 8.25f);
		at.GroupByBoxVisible = false;
		at.Location = new Point(123, 23);
		at.Name = "gSelectStd";
		at.RecordNavigator = true;
		at.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		at.Size = new Size(214, 166);
		at.TabIndex = 5;
		at.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_g.AutoSize = true;
		this.m_g.Font = new Font("B Nazanin", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(155, 479);
		this.m_g.Name = "lBook";
		this.m_g.RightToLeft = RightToLeft.Yes;
		this.m_g.Size = new Size(40, 23);
		this.m_g.TabIndex = 37;
		this.m_g.Text = "درس :";
		this.m_g.TextAlign = ContentAlignment.MiddleCenter;
		this.m_q.Controls.Add(bl);
		this.m_q.Controls.Add(ba);
		this.m_q.Controls.Add(a8);
		this.m_q.Controls.Add(a9);
		this.m_q.Controls.Add(am);
		this.m_q.Controls.Add(an);
		this.m_q.Controls.Add(this.m_z);
		this.m_q.Controls.Add(this.m_x);
		this.m_q.Controls.Add(this.m_y);
		this.m_q.Controls.Add(this.m_w);
		this.m_q.Controls.Add(this.m_u);
		this.m_q.Controls.Add(this.m_v);
		this.m_q.Controls.Add(this.m_r);
		this.m_q.Controls.Add(this.m_s);
		this.m_q.Controls.Add(this.m_t);
		this.m_q.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_q.Location = new Point(3, 297);
		this.m_q.Name = "groupBoxAzmoon";
		this.m_q.RightToLeft = RightToLeft.Yes;
		this.m_q.Size = new Size(495, 118);
		this.m_q.TabIndex = 14;
		this.m_q.TabStop = false;
		this.m_q.Text = "تنظیمات آزمون";
		bl.Image = (Image)componentResourceManager.GetObject("btnCancel1.Image");
		bl.Location = new Point(450, 89);
		bl.Name = "btnCancel1";
		bl.Size = new Size(30, 22);
		bl.TabIndex = 45;
		bl.Click += h;
		ba.Controls.Add(bm);
		ba.Controls.Add(bn);
		ba.Controls.Add(bo);
		ba.Controls.Add(bp);
		ba.Controls.Add(bq);
		ba.Controls.Add(bb);
		ba.Controls.Add(bc);
		ba.Controls.Add(bd);
		ba.Controls.Add(be);
		ba.Controls.Add(bf);
		ba.Controls.Add(bg);
		ba.Controls.Add(bh);
		ba.Controls.Add(bi);
		ba.Controls.Add(bj);
		ba.Controls.Add(bk);
		ba.Location = new Point(6, 115);
		ba.Name = "pOtherPage";
		ba.Size = new Size(484, 134);
		ba.TabIndex = 44;
		ba.Visible = false;
		bm.Image = (Image)componentResourceManager.GetObject("btnCancel6.Image");
		bm.Location = new Point(444, 109);
		bm.Name = "btnCancel6";
		bm.Size = new Size(30, 22);
		bm.TabIndex = 58;
		bm.Click += c;
		bn.Image = (Image)componentResourceManager.GetObject("btnCancel5.Image");
		bn.Location = new Point(444, 83);
		bn.Name = "btnCancel5";
		bn.Size = new Size(30, 22);
		bn.TabIndex = 57;
		bn.Click += d;
		bo.Image = (Image)componentResourceManager.GetObject("btnCancel4.Image");
		bo.Location = new Point(444, 55);
		bo.Name = "btnCancel4";
		bo.Size = new Size(30, 22);
		bo.TabIndex = 56;
		bo.Click += e;
		bp.Image = (Image)componentResourceManager.GetObject("btnCancel3.Image");
		bp.Location = new Point(444, 29);
		bp.Name = "btnCancel3";
		bp.Size = new Size(30, 22);
		bp.TabIndex = 55;
		bp.Click += f;
		bq.Image = (Image)componentResourceManager.GetObject("btnCancel2.Image");
		bq.Location = new Point(444, 4);
		bq.Name = "btnCancel2";
		bq.Size = new Size(30, 22);
		bq.TabIndex = 54;
		bq.Click += g;
		bb.Enabled = false;
		bb.Location = new Point(98, 110);
		bb.Name = "txtadress6";
		bb.Size = new Size(340, 21);
		bb.TabIndex = 53;
		bc.Enabled = false;
		bc.Location = new Point(98, 83);
		bc.Name = "txtadress5";
		bc.Size = new Size(340, 21);
		bc.TabIndex = 52;
		bd.Enabled = false;
		bd.Location = new Point(98, 56);
		bd.Name = "txtadress4";
		bd.Size = new Size(340, 21);
		bd.TabIndex = 51;
		be.Location = new Point(2, 107);
		be.Name = "btnSelectPage6";
		be.Size = new Size(89, 23);
		be.TabIndex = 50;
		be.Text = "صفحه 6";
		be.UseVisualStyleBackColor = true;
		be.Click += i;
		bf.Location = new Point(3, 81);
		bf.Name = "btnSelectPage5";
		bf.Size = new Size(89, 23);
		bf.TabIndex = 49;
		bf.Text = "صفحه 5";
		bf.UseVisualStyleBackColor = true;
		bf.Click += j;
		bg.Location = new Point(2, 56);
		bg.Name = "btnSelectPage4";
		bg.Size = new Size(89, 23);
		bg.TabIndex = 48;
		bg.Text = "صفحه 4";
		bg.UseVisualStyleBackColor = true;
		bg.Click += k;
		bh.Enabled = false;
		bh.Location = new Point(98, 30);
		bh.Name = "txtadress3";
		bh.Size = new Size(340, 21);
		bh.TabIndex = 47;
		bi.Location = new Point(2, 29);
		bi.Name = "btnSelectPage3";
		bi.Size = new Size(89, 23);
		bi.TabIndex = 46;
		bi.Text = "صفحه 3";
		bi.UseVisualStyleBackColor = true;
		bi.Click += l;
		bj.Enabled = false;
		bj.Location = new Point(98, 4);
		bj.Name = "txtadress2";
		bj.Size = new Size(340, 21);
		bj.TabIndex = 45;
		bk.Location = new Point(2, 4);
		bk.Name = "btnSelectPage2";
		bk.Size = new Size(91, 23);
		bk.TabIndex = 44;
		bk.Text = "صفحه 2";
		bk.UseVisualStyleBackColor = true;
		bk.Click += m;
		a8.Location = new Point(13, 47);
		a8.MaxLength = 15;
		a8.Name = "txtStartExam";
		a8.Size = new Size(82, 21);
		a8.TabIndex = 23;
		a9.AutoSize = true;
		a9.Location = new Point(98, 51);
		a9.Name = "label11";
		a9.Size = new Size(76, 13);
		a9.TabIndex = 29;
		a9.Text = "ساعت شروع :";
		am.Location = new Point(198, 46);
		am.MaxLength = 10;
		am.Name = "txtCountQus";
		am.Size = new Size(60, 21);
		am.TabIndex = 22;
		an.AutoSize = true;
		an.Location = new Point(264, 51);
		an.Name = "label1";
		an.Size = new Size(66, 13);
		an.TabIndex = 28;
		an.Text = "تعداد سوال :";
		this.m_z.Location = new Point(7, 90);
		this.m_z.Name = "btnSelectPage1";
		this.m_z.Size = new Size(94, 23);
		this.m_z.TabIndex = 27;
		this.m_z.Text = "انتخاب فایل";
		this.m_z.UseVisualStyleBackColor = true;
		this.m_z.Click += ac;
		this.m_x.Location = new Point(311, 72);
		this.m_x.Name = "lQusText";
		this.m_x.Size = new Size(175, 14);
		this.m_x.TabIndex = 26;
		this.m_x.Text = "مسیر عکس سوالات صفحه اول";
		this.m_x.TextAlign = ContentAlignment.MiddleLeft;
		this.m_y.Enabled = false;
		this.m_y.Location = new Point(104, 89);
		this.m_y.Name = "txtadress";
		this.m_y.Size = new Size(340, 21);
		this.m_y.TabIndex = 25;
		this.m_w.Location = new Point(361, 46);
		this.m_w.MaxLength = 10;
		this.m_w.Name = "txtCountPage";
		this.m_w.Size = new Size(57, 21);
		this.m_w.TabIndex = 21;
		this.m_u.AutoSize = true;
		this.m_u.Location = new Point(422, 50);
		this.m_u.Name = "label5";
		this.m_u.Size = new Size(68, 13);
		this.m_u.TabIndex = 23;
		this.m_u.Text = "تعداد صفحه :";
		this.m_v.Location = new Point(14, 19);
		this.m_v.MaxLength = 50;
		this.m_v.Name = "txtTimeExam";
		this.m_v.Size = new Size(81, 21);
		this.m_v.TabIndex = 20;
		this.m_r.AutoSize = true;
		this.m_r.Location = new Point(102, 23);
		this.m_r.Name = "label4";
		this.m_r.Size = new Size(68, 13);
		this.m_r.TabIndex = 21;
		this.m_r.Text = "مدت امتحان :";
		this.m_s.AutoSize = true;
		this.m_s.Location = new Point(420, 22);
		this.m_s.Name = "label3";
		this.m_s.Size = new Size(68, 13);
		this.m_s.TabIndex = 20;
		this.m_s.Text = "تاریخ امتحان :";
		this.m_t.AutoToday = true;
		this.m_t.BackColor = Color.SeaShell;
		this.m_t.BijanForeColor = Color.Blue;
		this.m_t.Location = new Point(274, 16);
		this.m_t.Name = "txtDateFrom";
		this.m_t.Size = new Size(144, 24);
		this.m_t.TabIndex = 19;
		this.m_t.the_date = new DateTime(2020, 11, 20, 19, 59, 42, 780);
		this.m_t.the_label = "ازمون تاريخ:";
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(7, 478);
		this.m_h.Name = "dropBook";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(144, 21);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat3;
		this.m_h.TabIndex = 36;
		al.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		al.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		al.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		al.ImageSize = new Size(40, 40);
		al.Location = new Point(9, 568);
		al.Name = "btnClose";
		al.Size = new Size(142, 45);
		al.TabIndex = 111;
		al.Text = "بستن";
		al.Click += w;
		aj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		aj.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aj.Image = (Image)componentResourceManager.GetObject("btnView.Image");
		aj.ImageSize = new Size(40, 40);
		aj.Location = new Point(9, 510);
		aj.Name = "btnView";
		aj.Size = new Size(142, 52);
		aj.TabIndex = 109;
		aj.Text = "نمایش";
		aj.Click += ad;
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(163, 428);
		this.m_c.Name = "pClass";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(336, 185);
		this.m_c.TabIndex = 103;
		this.m_f.Controls.Add(this.m_m);
		this.m_f.Controls.Add(this.m_o);
		this.m_f.Controls.Add(this.m_k);
		this.m_f.Controls.Add(this.m_p);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(this.m_l);
		this.m_f.Controls.Add(this.m_j);
		this.m_f.Controls.Add(this.m_e);
		this.m_f.Location = new Point(35, 41);
		this.m_f.Name = "groupBox2";
		this.m_f.Size = new Size(282, 124);
		this.m_f.TabIndex = 14;
		this.m_f.TabStop = false;
		this.m_f.Text = "انتخاب دانش آموزان برای چاپ";
		this.m_m.AutoSize = true;
		this.m_m.Location = new Point(201, 77);
		this.m_m.Name = "lStd";
		this.m_m.Size = new Size(53, 13);
		this.m_m.TabIndex = 106;
		this.m_m.Text = "دانش آموز";
		this.m_m.Visible = false;
		this.m_o.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_o.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "ردیف-نام خانوادگی";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "حوزه-شماره چوکی";
		uIComboBoxItem2.Value = "2";
		this.m_o.Items.AddRange(new UIComboBoxItem[2] { uIComboBoxItem, uIComboBoxItem2 });
		this.m_o.Location = new Point(12, 99);
		this.m_o.Name = "dropSort";
		this.m_o.Size = new Size(183, 21);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		this.m_o.StringFormat = stringFormat4;
		this.m_o.TabIndex = 109;
		this.m_k.AutoSize = true;
		this.m_k.Location = new Point(201, 51);
		this.m_k.Name = "label19";
		this.m_k.Size = new Size(30, 13);
		this.m_k.TabIndex = 105;
		this.m_k.Text = "صنف";
		this.m_p.AutoSize = true;
		this.m_p.Location = new Point(200, 104);
		this.m_p.Name = "lSort";
		this.m_p.Size = new Size(64, 13);
		this.m_p.TabIndex = 108;
		this.m_p.Text = "ترتیب نماش ";
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(201, 24);
		this.m_i.Name = "label20";
		this.m_i.Size = new Size(22, 13);
		this.m_i.TabIndex = 105;
		this.m_i.Text = "پایه";
		this.m_l.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_l.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(13, 47);
		this.m_l.Name = "dropClass";
		this.m_l.Size = new Size(183, 21);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		this.m_l.StringFormat = stringFormat5;
		this.m_l.TabIndex = 104;
		this.m_l.SelectedIndexChanged += af;
		this.m_j.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_j.DropListFont = new Font("Rod", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(13, 20);
		this.m_j.Name = "dropPaye";
		this.m_j.Size = new Size(183, 21);
		stringFormat6.Alignment = StringAlignment.Near;
		stringFormat6.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat6.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat6.LineAlignment = StringAlignment.Center;
		stringFormat6.Trimming = StringTrimming.Character;
		this.m_j.StringFormat = stringFormat6;
		this.m_j.TabIndex = 104;
		this.m_j.SelectedIndexChanged += ae;
		this.m_e.DropDownStyle = ComboBoxStyle.DropDownList;
		this.m_e.FormattingEnabled = true;
		this.m_e.Location = new Point(13, 73);
		this.m_e.Name = "dropStd";
		this.m_e.Size = new Size(183, 21);
		this.m_e.TabIndex = 3;
		this.m_e.Visible = false;
		ai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ai.Controls.Add(this.m_ac);
		ai.Controls.Add(this.m_ab);
		ai.Controls.Add(ak);
		ai.Controls.Add(this.m_n);
		ai.Location = new Point(6, 6);
		ai.Name = "pRpt";
		ai.Size = new Size(494, 405);
		ai.TabIndex = 108;
		this.m_ac.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ac.Image = Resources.copy;
		this.m_ac.ImageSize = new Size(30, 30);
		this.m_ac.Location = new Point(5, 6);
		this.m_ac.Name = "btnNew";
		this.m_ac.Size = new Size(151, 42);
		this.m_ac.TabIndex = 107;
		this.m_ac.Text = "تهیه گزارش جدید از روی گزارش انتخاب شده";
		this.m_ac.Click += aa;
		this.m_ab.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_ab.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ab.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_ab.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_ab.ImageIndex = 8;
		this.m_ab.Location = new Point(5, 103);
		this.m_ab.Name = "btnDelete";
		this.m_ab.RightToLeft = RightToLeft.Yes;
		this.m_ab.Size = new Size(151, 42);
		this.m_ab.TabIndex = 106;
		this.m_ab.Text = "حذف گزارش انتخاب شده";
		this.m_ab.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_ab.Click += ab;
		ak.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ak.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		ak.ImageSize = new Size(40, 40);
		ak.Location = new Point(5, 54);
		ak.Name = "btnEdit";
		ak.Size = new Size(151, 42);
		ak.TabIndex = 110;
		ak.Text = "ویرایش گزارش";
		ak.Click += x;
		this.m_n.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout4.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		this.m_n.DesignTimeLayout = gridEXLayout4;
		this.m_n.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_n.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_n.GroupByBoxVisible = false;
		this.m_n.Location = new Point(162, 3);
		this.m_n.Name = "gridEX1";
		this.m_n.RightToLeft = RightToLeft.Yes;
		this.m_n.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_n.Size = new Size(324, 397);
		this.m_n.TabIndex = 104;
		this.m_n.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.BackColor = SystemColors.ControlText;
		this.m_d.Controls.Add(this.m_b);
		this.m_d.Dock = DockStyle.Fill;
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "panel4";
		this.m_d.Size = new Size(515, 640);
		this.m_d.TabIndex = 20;
		this.m_aa.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_aa.Title = "فایل عکس صفحه اول سوالات امتحان";
		this.m_ad.BackColor = Color.FromArgb(214, 223, 247);
		this.m_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_ad.Controls.Add(this.m_ae);
		this.m_ad.Controls.Add(this.m_af);
		this.m_ad.Controls.Add(this.m_ag);
		this.m_ad.Controls.Add(ah);
		this.m_ad.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_ad.Location = new Point(174, 161);
		this.m_ad.Name = "pNew";
		this.m_ad.RightToLeft = RightToLeft.Yes;
		this.m_ad.Size = new Size(327, 116);
		this.m_ad.TabIndex = 108;
		this.m_ad.Visible = false;
		this.m_ae.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		this.m_ae.Location = new Point(40, 67);
		this.m_ae.Name = "btnCancel";
		this.m_ae.Size = new Size(75, 32);
		this.m_ae.TabIndex = 16;
		this.m_ae.Text = "انصراف";
		this.m_ae.Click += z;
		this.m_af.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		this.m_af.Location = new Point(121, 67);
		this.m_af.Name = "btnAcp";
		this.m_af.Size = new Size(75, 32);
		this.m_af.TabIndex = 14;
		this.m_af.Text = "تایید";
		this.m_af.Click += y;
		this.m_ag.Location = new Point(228, 22);
		this.m_ag.Name = "label8";
		this.m_ag.Size = new Size(86, 28);
		this.m_ag.TabIndex = 1;
		this.m_ag.Text = "عنوان الگو";
		this.m_ag.TextAlign = ContentAlignment.MiddleRight;
		ah.AutoScroll = false;
		ah.AutoScrollMargin = new Size(0, 0);
		ah.AutoScrollMinSize = new Size(0, 0);
		ah.AutoScrollPosition = new Point(0, 0);
		ah.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ah.Location = new Point(13, 19);
		ah.Name = "txtNam";
		ah.Size = new Size(211, 33);
		ah.TabIndex = 0;
		ah.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.InactiveCaptionText;
		ClientSize = new Size(515, 640);
		Controls.Add(this.m_ad);
		Controls.Add(this.m_d);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmsarbarg2";
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "سربرگ";
		Load += ag;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)br).EndInit();
		br.ResumeLayout(performLayout: false);
		br.PerformLayout();
		((ISupportInitialize)bs).EndInit();
		((ISupportInitialize)aw).EndInit();
		aw.ResumeLayout(performLayout: false);
		aw.PerformLayout();
		((ISupportInitialize)az).EndInit();
		((ISupportInitialize)au).EndInit();
		au.ResumeLayout(performLayout: false);
		au.PerformLayout();
		((ISupportInitialize)aq).EndInit();
		aq.ResumeLayout(performLayout: false);
		((ISupportInitialize)at).EndInit();
		this.m_q.ResumeLayout(performLayout: false);
		this.m_q.PerformLayout();
		ba.ResumeLayout(performLayout: false);
		ba.PerformLayout();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		ai.ResumeLayout(performLayout: false);
		((ISupportInitialize)this.m_n).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_ad.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdt()
	{
		m();
	}

	private void l()
	{
		FileStream fileStream = default;
		byte[] buffer = default;
		while (true)
		{
			string path = Application.StartupPath + "\\1000.rpx";
			SqlDataReader sqlDataReader = asdcb.b(asdab.e(), CommandType.Text, "select Rpt from tRptDynamic where id=" + this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
			bool flag = !sqlDataReader.Read();
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
					goto case 3;
				case 1:
					try
					{
						BinaryWriter binaryWriter = new BinaryWriter(fileStream);
						try
						{
							binaryWriter.Write(buffer);
							binaryWriter.Close();
						}
						finally
						{
							while (true)
							{
								IL_00db:
								flag = binaryWriter == null;
								num = 1;
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
										goto end_IL_00c6;
									case 0:
										((IDisposable)binaryWriter).Dispose();
										num = 2;
										continue;
									case 2:
										goto end_IL_00c6;
									}
									goto IL_00db;
									continue;
									end_IL_00c6:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						while (true)
						{
							IL_012f:
							flag = fileStream == null;
							num = 0;
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
									goto end_IL_011a;
								case 2:
									((IDisposable)fileStream).Dispose();
									num = 1;
									continue;
								case 1:
									goto end_IL_011a;
								}
								goto IL_012f;
								continue;
								end_IL_011a:
								break;
							}
							break;
						}
					}
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					buffer = (byte[])sqlDataReader.GetValue(0);
					fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
					num = 1;
					continue;
				case 3:
					sqlDataReader.Close();
					sqlDataReader.Dispose();
					return;
				}
				break;
			}
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		string text = default;
		while (true)
		{
			bool flag = asdaj.a("12");
			int num = 3;
			while (true)
			{
				int num4;
				int num3;
				switch (num)
				{
				case 3:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					string shamsi = asdab.b();
					this.m_t.the_date = ShamsiDate.ShamsiToGregory(shamsi);
					bw.the_date = ShamsiDate.ShamsiToGregory(shamsi);
					bt.the_date = ShamsiDate.ShamsiToGregory(shamsi);
					num = 19;
					continue;
				}
				case 7:
					num = 23;
					continue;
				case 10:
				{
					int num2 = int.Parse(asdab.b().Substring(0, 4));
					flag = num2 >= 1399;
					num = 34;
					continue;
				}
				case 34:
					if (!flag)
					{
						num = 4;
						continue;
					}
					this.m_q.Visible = false;
					ai.Height = 300;
					this.m_g.Visible = false;
					this.m_h.Visible = false;
					au.Visible = false;
					br.Visible = true;
					this.m_c.Visible = false;
					j();
					text = k();
					flag = !(text != "0");
					num = 16;
					continue;
				case 17:
					num4 = 0;
					goto IL_0217;
				case 33:
					num3 = 0;
					goto IL_023f;
				case 25:
					num = 15;
					continue;
				case 15:
					if (!(bx == "3"))
					{
						num = 14;
						continue;
					}
					goto IL_0127;
				case 18:
					MessageBox.Show("تعداد " + text + "  نفر از دانش آموزان فاقد تاریخ تولد هستند");
					num = 7;
					continue;
				case 0:
					this.m_p.Visible = false;
					this.m_o.Visible = false;
					num = 31;
					continue;
				case 24:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 5;
				case 13:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(bx == "1");
					num = 6;
					continue;
				case 8:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 31;
				case 31:
					i();
					g();
					e();
					c();
					this.m_o.SelectedIndex = 0;
					h();
					f();
					a();
					num = 12;
					continue;
				case 12:
					return;
				case 26:
					ai.Height = 270;
					num = 32;
					continue;
				case 1:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 22;
					continue;
				case 22:
					return;
				case 14:
					num = 9;
					continue;
				case 9:
					num4 = ((!(bx == "4")) ? 1 : 0);
					goto IL_0217;
				case 2:
					this.m_q.Visible = false;
					ai.Height = 400;
					this.m_g.Visible = false;
					this.m_h.Visible = false;
					au.Visible = true;
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						num = 26;
						continue;
					}
					flag = !(bx == "5");
					num = 11;
					continue;
				case 29:
					num = 28;
					continue;
				case 28:
					num3 = ((!(bx == "3")) ? 1 : 0);
					goto IL_023f;
				case 16:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 7;
				case 11:
					if (flag)
					{
						flag = !(bx == "6");
						num = 24;
					}
					else
					{
						num = 20;
					}
					continue;
				case 20:
					ai.Height = 170;
					this.m_q.Height = 255;
					this.m_q.Top = 185;
					ba.Visible = true;
					this.m_x.Text = "مسیر عکس سوالات";
					this.m_z.Text = "صفحه 1";
					if (true)
					{
					}
					num = 27;
					continue;
				case 4:
					MessageBox.Show("تاریخ کامپیوتر شما بروز نیست ابتدا تاریخ کامپیوتر را تنظیم کرده و دوباره وارد این بخش شوید");
					Close();
					num = 21;
					continue;
				case 21:
					return;
				case 19:
					if (!(bx == "2"))
					{
						num = 25;
						continue;
					}
					goto IL_0127;
				case 5:
				case 23:
				case 27:
				case 32:
					num = 30;
					continue;
				case 30:
					{
						num = ((!(bx == "2")) ? 29 : 33);
						continue;
					}
					IL_0127:
					num = 17;
					continue;
					IL_023f:
					flag = (byte)num3 != 0;
					num = 8;
					continue;
					IL_0217:
					flag = (byte)num4 != 0;
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private string k()
	{
		string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT    count( tStudent.id)  \r\n                        FROM  tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent inner join tclass on tYear_Student.xclass=tclass.id\r\n                        where tYear_Student.xyear=" + asdaj.__field_a + " and tYear_Student.xPaye in(" + asdaj.n + ") and  len(isnull(tStudent.bdate,'1'))<10 ").ToString();
		string result = text;
		if (true)
		{
		}
		return result;
	}

	private void j()
	{
		while (true)
		{
			if (true)
			{
			}
			string text = "  tYear_Student.xYear=" + asdaj.__field_a + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			text += " and len(tStudent.bDate)=10";
			text = text + " and substring(tStudent.bDate,6,5)>=N'" + ShamsiDate.GetShamsiDate(bw.the_date).Substring(5, 5) + "'";
			text = text + " and substring(tStudent.bDate,6,5)<=N'" + ShamsiDate.GetShamsiDate(bt.the_date).Substring(5, 5) + "'";
			bool flag = !(text != "");
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
					goto case 2;
				case 0:
					text = " where " + text;
					num = 2;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName,tclass.name as class,substring(tStudent.bdate,3,8) as bdate \r\n                        FROM  tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent inner join tclass on tYear_Student.xclass=tclass.id  " + text + " order by tStudent.lname,tStudent.fname");
					bs.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void i()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptDynamic where type=" + bx);
		this.m_n.DataSource = dataSource;
	}

	private void h()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه پایه ها' as  name\r\n                                                                                                                union select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.__field_a + ") order by id");
			a5.DataSource = dataSource;
			a5.DisplayMember = "Name";
			a5.ValueMember = "id";
			bool flag = a5.Items.Count <= 0;
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
					if (true)
					{
					}
					a5.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void g()
	{
		while (true)
		{
			if (true)
			{
			}
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.__field_a + ") order by id");
			this.m_j.DataSource = dataSource;
			this.m_j.DisplayMember = "Name";
			this.m_j.ValueMember = "id";
			bool flag = this.m_j.Items.Count <= 0;
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
					this.m_j.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void f()
	{
		while (true)
		{
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = a5.SelectedIndex <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 3;
				case 4:
					a3.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 3:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where  xYear=" + asdaj.__field_a + text);
					a3.DataSource = dataSource;
					a3.DisplayMember = "Name";
					a3.ValueMember = "id";
					flag = a3.Items.Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 5:
					if (true)
					{
					}
					text = " and xPaye=" + a5.SelectedValue.ToString();
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void e()
	{
		while (true)
		{
			string text = "  where  xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_j.SelectedIndex < 0;
			int num = 0;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 4:
					this.m_l.SelectedIndex = 0;
					num = 3;
					continue;
				case 3:
					return;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'تمام صنف ها' as  name\r\n                                                                                                                union select id,name from tClass" + text);
					this.m_l.DataSource = dataSource;
					this.m_l.DisplayMember = "Name";
					this.m_l.ValueMember = "id";
					flag = this.m_l.Items.Count <= 0;
					num = 5;
					continue;
				}
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 2:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student where xYear=" + asdaj.__field_a + " and (xPaye = " + this.m_j.SelectedValue.ToString() + "))";
					num = 1;
					continue;
				}
				}
				break;
			}
		}
	}

	private void d()
	{
		Dictionary<string, string> dictionary = default;
		DataTable dataTable = default;
		int num2 = default;
		while (true)
		{
			bool flag = this.m_l.SelectedIndex < 0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 8:
					flag = dictionary.Count != 0;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 4;
						continue;
					}
					this.m_e.DataSource = new BindingSource(dictionary, null);
					this.m_e.DisplayMember = "Value";
					this.m_e.ValueMember = "Key";
					num = 12;
					continue;
				case 13:
					if (true)
					{
					}
					this.m_e.Visible = false;
					this.m_m.Visible = false;
					this.m_e.DataSource = null;
					num = 0;
					continue;
				case 0:
					return;
				case 9:
					flag = !(this.m_l.SelectedValue.ToString() == "0");
					num = 11;
					continue;
				case 11:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					this.m_e.Visible = true;
					this.m_m.Visible = true;
					string a_ = "select tStudent.id,tStudent.lname + N' - '+ tStudent.fname as name  from tstudent inner join \r\n                                 tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.status=1 and tYear_Student.xYear=" + asdaj.__field_a + " and tYear_Student.xclass= " + this.m_l.SelectedValue.ToString() + " order by tYear_Student.sort,tStudent.lname,tStudent.fname,tStudent.id";
					dictionary = new Dictionary<string, string>();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count <= 1;
					num = 16;
					continue;
				}
				case 4:
					this.m_e.DataSource = null;
					MessageBox.Show("دانش آموزی در این صنف وجود ندارد");
					num = 10;
					continue;
				case 10:
				case 12:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					num2 = 0;
					num = 1;
					continue;
				case 16:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 2;
				case 1:
				case 15:
					flag = num2 < dataTable.Rows.Count;
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						num = 15;
					}
					else
					{
						num = 8;
					}
					continue;
				case 14:
					dictionary.Add("0", "تمام دانش آموزان صنف");
					num = 2;
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
			bool flag = this.m_j.SelectedIndex < 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						this.m_h.DataSource = null;
						num = 5;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					this.m_h.SelectedIndex = 0;
					num = 6;
					continue;
				case 4:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tbook where xPaye=" + this.m_j.SelectedValue.ToString());
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					flag = this.m_h.Items.Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		d();
	}

	private void ae(object A_0, EventArgs A_1)
	{
		e();
		c();
	}

	private void ad(object A_0, EventArgs A_1)
	{
		int num10 = default;
		int num3 = default;
		string cmdText = default;
		DataSet dataSet = default;
		while (true)
		{
			string value = "0";
			string text = "0";
			bool flag = !aw.Visible;
			int num = 12;
			while (true)
			{
				int num8;
				int num7;
				int num2;
				int num4;
				int num6;
				int num9;
				int num5;
				switch (num)
				{
				case 12:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 26;
				case 107:
					return;
				case 15:
					text += ",";
					num = 22;
					continue;
				case 3:
					num = 108;
					continue;
				case 108:
					num8 = ((!(bx != "5")) ? 1 : 0);
					goto IL_0eae;
				case 112:
					num = ((bh.Text != "") ? 76 : 51);
					continue;
				case 97:
					MessageBox.Show("تاریخ انتخابی اشتباه است");
					num = 91;
					continue;
				case 91:
					return;
				case 101:
					MessageBox.Show("عکس صفحه چهارم را انتخاب کنید");
					num = 94;
					continue;
				case 94:
					return;
				case 19:
					num = 4;
					continue;
				case 4:
					num7 = ((!(bj.Text != "")) ? 1 : 0);
					goto IL_06de;
				case 84:
				case 87:
				case 95:
					num = 92;
					continue;
				case 92:
					num = ((!(this.m_y.Text == "")) ? 46 : 19);
					continue;
				case 76:
					num2 = 0;
					goto IL_0c18;
				case 5:
					if (!flag)
					{
						num = 96;
						continue;
					}
					MessageBox.Show("پایه ای انتخاب نشده است");
					num = 70;
					continue;
				case 62:
					flag = !(text == "0");
					num = 110;
					continue;
				case 110:
					if (!flag)
					{
						num = 58;
						continue;
					}
					num10 = int.Parse(ShamsiDate.GetShamsiDate(bw.the_date).Substring(0, 4));
					flag = num10 >= 1399;
					num = 17;
					continue;
				case 102:
					MessageBox.Show("تاریخ انتخابی اشتباه است");
					num = 93;
					continue;
				case 93:
					return;
				case 28:
					num = ((!(bd.Text == "")) ? 89 : 65);
					continue;
				case 109:
					if (!flag)
					{
						num = 16;
						continue;
					}
					if (true)
					{
					}
					num = 87;
					continue;
				case 7:
					num8 = 1;
					goto IL_0eae;
				case 31:
					flag = !(this.m_l.SelectedValue.ToString() != "0");
					num = 105;
					continue;
				case 105:
					if (!flag)
					{
						num = 81;
						continue;
					}
					goto case 111;
				case 27:
				case 37:
					flag = num3 < bs.RowCount;
					num = 56;
					continue;
				case 56:
					if (!flag)
					{
						num = 62;
						continue;
					}
					flag = !(text != "");
					num = 72;
					continue;
				case 38:
					num = 84;
					continue;
				case 1:
					num = 10;
					continue;
				case 10:
					num4 = ((!(bh.Text != "")) ? 1 : 0);
					goto IL_071c;
				case 25:
				case 39:
					flag = num3 < at.RowCount;
					num = 45;
					continue;
				case 45:
					if (!flag)
					{
						num = 83;
						continue;
					}
					flag = !(text != "");
					num = 23;
					continue;
				case 2:
					num = 64;
					continue;
				case 53:
					MessageBox.Show("عکس صفحه سوم را انتخاب کنید");
					num = 49;
					continue;
				case 49:
					return;
				case 80:
					value = "3";
					text = this.m_e.SelectedValue.ToString();
					num = 86;
					continue;
				case 51:
					num = 82;
					continue;
				case 82:
					num2 = ((!(bd.Text == "")) ? 1 : 0);
					goto IL_0c18;
				case 17:
				{
					if (!flag)
					{
						num = 102;
						continue;
					}
					int num11 = int.Parse(ShamsiDate.GetShamsiDate(bt.the_date).Substring(0, 4));
					flag = num10 <= num11;
					num = 47;
					continue;
				}
				case 16:
					MessageBox.Show("اختلاف دو تاریخ نباید بیشتر از یک ماه باشد");
					num = 35;
					continue;
				case 35:
					return;
				case 65:
					num = 20;
					continue;
				case 20:
					num6 = ((!(bc.Text != "")) ? 1 : 0);
					goto IL_0aff;
				case 67:
					num = (flag ? 21 : 100);
					continue;
				case 18:
					num = 111;
					continue;
				case 63:
					num = (flag ? 50 : 43);
					continue;
				case 81:
					value = "2";
					text = this.m_l.SelectedValue.ToString();
					flag = this.m_e.SelectedIndex < 0;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 106;
						continue;
					}
					MessageBox.Show("دانش آموزی انتخاب نشده است");
					num = 68;
					continue;
				case 40:
					aw.Visible = false;
					num = 26;
					continue;
				case 100:
					MessageBox.Show("عکس صفحه اول را انتخاب کنید");
					num = 33;
					continue;
				case 33:
					return;
				case 46:
					num7 = 1;
					goto IL_06de;
				case 106:
					flag = !(this.m_e.SelectedValue.ToString() != "0");
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 86;
				case 36:
					return;
				case 59:
					value = "9";
					num3 = 0;
					num = 25;
					continue;
				case 58:
					MessageBox.Show("در تاریخ های مشخص شده متولدی وجود ندارد");
					num = 6;
					continue;
				case 6:
					return;
				case 47:
					if (!flag)
					{
						num = 60;
						continue;
					}
					flag = num10 >= 1399;
					num = 85;
					continue;
				case 34:
					num = 11;
					continue;
				case 11:
					num9 = ((!(bb.Text != "")) ? 1 : 0);
					goto IL_0b29;
				case 103:
					num9 = 1;
					goto IL_0b29;
				case 88:
					text += ",";
					num = 8;
					continue;
				case 90:
					if (flag)
					{
						flag = this.m_j.SelectedIndex < 0;
						num = 5;
					}
					else
					{
						num = 59;
					}
					continue;
				case 26:
					flag = !(bx == "6");
					num = 98;
					continue;
				case 98:
					if (flag)
					{
						flag = !ao.Checked;
						num = 90;
					}
					else
					{
						num = 44;
					}
					continue;
				case 71:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 78;
					continue;
				case 78:
					return;
				case 43:
					MessageBox.Show("عکس صفحه دوم را انتخاب کنید");
					num = 32;
					continue;
				case 32:
					return;
				case 23:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 22;
				case 96:
					value = "1";
					text = this.m_j.SelectedValue.ToString();
					num = 66;
					continue;
				case 22:
					text += at.GetRow(num3).Cells["id"].Value.ToString();
					num3++;
					num = 39;
					continue;
				case 42:
					num = (flag ? 73 : 101);
					continue;
				case 75:
					num = ((!flag) ? 54 : 112);
					continue;
				case 72:
					if (!flag)
					{
						num = 88;
						continue;
					}
					goto case 8;
				case 29:
					cmdText = "sp_SelectStdForSarbarg_Type2";
					num = 55;
					continue;
				case 85:
					if (flag)
					{
						DateTime the_date = bw.the_date;
						DateTime the_date2 = bt.the_date;
						the_date = the_date.AddMonths(1);
						flag = !(the_date2 > the_date);
						num = 109;
					}
					else
					{
						num = 97;
					}
					continue;
				case 73:
					num = ((bc.Text == "") ? 34 : 103);
					continue;
				case 52:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 64;
				case 8:
					text += bs.GetRow(num3).Cells["id"].Value.ToString();
					num3++;
					num = 27;
					continue;
				case 74:
					num5 = 1;
					goto IL_107d;
				case 55:
				{
					SqlConnection sqlConnection = new SqlConnection(asdab.e());
					sqlConnection.Open();
					dataSet = new DataSet();
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@type", value);
					sqlCommand.Parameters.AddWithValue("@code", text);
					sqlCommand.Parameters.AddWithValue("@sort", this.m_o.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xBook", this.m_h.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@DateExam", ShamsiDate.GetShamsiDate(this.m_t.the_date));
					sqlCommand.Parameters.AddWithValue("@TimeExam", this.m_v.Text);
					sqlCommand.Parameters.AddWithValue("@CountPageExam", this.m_w.Text);
					sqlCommand.Parameters.AddWithValue("@CountQusExam", am.Text);
					sqlCommand.Parameters.AddWithValue("@StartExam", a8.Text);
					sqlCommand.Parameters.AddWithValue("@xYear", asdaj.__field_a);
					sqlCommand.Parameters.AddWithValue("@formType", bx);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(dataSet, "v_data");
					sqlConnection.Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 9;
					continue;
				}
				case 9:
					if (flag)
					{
						l();
						asdbp asdbp2 = new asdbp();
						asdbp2.a(dataSet, dataSet.Tables[0].TableName, this.m_y.Text, bj.Text, bh.Text, bd.Text, bc.Text, bb.Text);
						asdbp2.ShowDialog();
						asdbp2.Dispose();
						num = 36;
					}
					else
					{
						num = 71;
					}
					continue;
				case 21:
					num = ((bj.Text == "") ? 1 : 24);
					continue;
				case 89:
					num6 = 1;
					goto IL_0aff;
				case 79:
					if (!flag)
					{
						num = 29;
						continue;
					}
					goto case 55;
				case 66:
					flag = this.m_l.SelectedIndex < 0;
					num = 14;
					continue;
				case 14:
					if (flag)
					{
						MessageBox.Show("صنفی ای انتخاب نشده است");
						num = 107;
					}
					else
					{
						num = 31;
					}
					continue;
				case 61:
					num = 48;
					continue;
				case 48:
					num5 = ((!(bd.Text != "")) ? 1 : 0);
					goto IL_107d;
				case 24:
					num4 = 1;
					goto IL_071c;
				case 60:
					MessageBox.Show("تاریخ انتخابی دوم نباید کمتر از اولی باشد");
					num = 104;
					continue;
				case 104:
					return;
				case 57:
					MessageBox.Show("دانش آموزی به لیست چاپ اضافه نشده است");
					num = 30;
					continue;
				case 30:
					return;
				case 50:
					num = ((bh.Text == "") ? 61 : 74);
					continue;
				case 86:
					num = 18;
					continue;
				case 70:
					return;
				case 54:
					MessageBox.Show("عکس صفحه پنجم را انتخاب کنید");
					num = 69;
					continue;
				case 69:
					return;
				case 68:
					return;
				case 111:
					num = 38;
					continue;
				case 44:
					value = "9";
					num3 = 0;
					num = 37;
					continue;
				case 13:
					num = ((!flag) ? 53 : 28);
					continue;
				case 83:
					flag = !(text == "0");
					num = 77;
					continue;
				case 77:
					num = ((!flag) ? 57 : 95);
					continue;
				case 64:
					cmdText = "sp_SelectStdForSarbarg_Type1";
					num = 99;
					continue;
				case 99:
					{
						num = ((bx != "1") ? 3 : 7);
						continue;
					}
					IL_0c18:
					flag = (byte)num2 != 0;
					num = 52;
					continue;
					IL_071c:
					flag = (byte)num4 != 0;
					num = 63;
					continue;
					IL_107d:
					flag = (byte)num5 != 0;
					num = 13;
					continue;
					IL_06de:
					flag = (byte)num7 != 0;
					num = 67;
					continue;
					IL_0b29:
					flag = (byte)num9 != 0;
					num = 75;
					continue;
					IL_0eae:
					flag = (byte)num8 != 0;
					num = 79;
					continue;
					IL_0aff:
					flag = (byte)num6 != 0;
					num = 42;
					continue;
				}
				break;
			}
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_aa.ShowDialog() != DialogResult.OK;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					this.m_y.Text = this.m_aa.FileName;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num = ((this.m_n.RowCount <= 0) ? 12 : 0);
					continue;
				case 9:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 2;
				case 10:
					MessageBox.Show("گزارش انتخاب شده از گزارش های پیش فرض برنامه است و قابل حذف نیست");
					num = 1;
					continue;
				case 1:
					return;
				case 12:
					num2 = 1;
					goto IL_01e7;
				case 2:
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_n.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_01e7;
				case 6:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tRptDynamic where id=" + this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					i();
					num = 2;
					continue;
				case 8:
					flag = !(this.m_n.SelectedItems[0].GetRow().Cells["sys"].Value.ToString() == "True");
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						flag = MessageBox.Show("آیا از حذف گزارش انتخاب شده اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 9;
					}
					else
					{
						num = 10;
					}
					continue;
				case 11:
					{
						if (!flag)
						{
							num = 8;
							continue;
						}
						return;
					}
					IL_01e7:
					flag = (byte)num2 != 0;
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_b.Enabled = false;
		this.m_ad.Visible = true;
		ah.Text = "";
		ah.Focus();
	}

	private void z(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_b.Enabled = true;
		this.m_ad.Visible = false;
	}

	private void y(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ah.Text.Trim() == "");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 0;
						continue;
					}
					SqlParameter[] a_ = new SqlParameter[2]
					{
						asdcb.a("@id", SqlDbType.Int, this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString()),
						asdcb.a("@Caption", SqlDbType.NVarChar, ah.Text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "declare @idAdd int\r\n                        select @idAdd=isnull (max(id)+1,1001) from tRptDynamic where id>100\r\n                        INSERT INTO tRptDynamic\r\n                             (id,Caption, Rpt, type, sys)\r\n                            select @idAdd ,@Caption,Rpt,type,0 from tRptDynamic where id=@id", a_);
					i();
					this.m_b.Enabled = true;
					this.m_ad.Visible = false;
					num = 3;
					continue;
				}
				case 0:
					MessageBox.Show("عنوان الگو جدید را وارد کنید");
					ah.Focus();
					num = 1;
					continue;
				case 1:
				case 3:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		string value = default;
		string value2 = default;
		SqlConnection sqlConnection = default;
		DataSet dataSet = default;
		string cmdText = default;
		while (true)
		{
			bool flag = !(this.m_n.SelectedItems[0].GetRow().Cells["sys"].Value.ToString() == "True");
			int num = 17;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 15;
						continue;
					}
					value = "0";
					value2 = "0";
					flag = this.m_j.SelectedIndex < 0;
					num = 22;
					continue;
				case 25:
					num2 = 1;
					goto IL_058c;
				case 13:
					num = 9;
					continue;
				case 9:
					if (true)
					{
					}
					sqlConnection = new SqlConnection(asdab.e());
					sqlConnection.Open();
					dataSet = new DataSet();
					cmdText = "sp_SelectStdForSarbarg_Test_Type1";
					num = 24;
					continue;
				case 8:
					return;
				case 27:
					cmdText = "sp_SelectStdForSarbarg_Test_Type2";
					num = 19;
					continue;
				case 11:
					value = "1";
					value2 = this.m_j.SelectedValue.ToString();
					num = 10;
					continue;
				case 21:
					num = 3;
					continue;
				case 3:
					num2 = ((!(bx != "5")) ? 1 : 0);
					goto IL_058c;
				case 4:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 18;
					continue;
				case 18:
					return;
				case 2:
					num = 13;
					continue;
				case 10:
					flag = this.m_l.SelectedIndex < 0;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 23;
						continue;
					}
					MessageBox.Show("صنفی ای انتخاب نشده است");
					num = 16;
					continue;
				case 19:
				{
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@type", value);
					sqlCommand.Parameters.AddWithValue("@code", value2);
					sqlCommand.Parameters.AddWithValue("@sort", this.m_o.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xBook", this.m_h.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@DateExam", ShamsiDate.GetShamsiDate(this.m_t.the_date));
					sqlCommand.Parameters.AddWithValue("@TimeExam", this.m_v.Text);
					sqlCommand.Parameters.AddWithValue("@CountPageExam", this.m_w.Text);
					sqlCommand.Parameters.AddWithValue("@CountQusExam", am.Text);
					sqlCommand.Parameters.AddWithValue("@StartExam", a8.Text);
					sqlCommand.Parameters.AddWithValue("@xYear", asdaj.__field_a);
					sqlCommand.Parameters.AddWithValue("@formType", bx);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(dataSet, "v_data");
					sqlConnection.Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 20;
					continue;
				}
				case 20:
				{
					if (!flag)
					{
						num = 4;
						continue;
					}
					l();
					asdk asdk2 = new asdk();
					asdk2.r = bx;
					asdk2.a(dataSet, dataSet.Tables[0].TableName, this.m_y.Text, bj.Text, bh.Text, bd.Text, bc.Text, bb.Text);
					asdk2.q = this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdk2.Text = this.m_n.SelectedItems[0].GetRow().Cells["Caption"].Value.ToString();
					asdk2.ShowDialog();
					num = 5;
					continue;
				}
				case 5:
					return;
				case 6:
					num = 2;
					continue;
				case 15:
					MessageBox.Show("گزارش انتخاب شده از گزارش های پیش فرض برنامه است و قابل اصلاح نیست\nبرای اصلاح میتوانید با استفاده از دکمه تهیه گزارش جدید یک کپی از این گزارش ایجاد و آن را اصلاح کنید ");
					num = 26;
					continue;
				case 26:
					return;
				case 23:
					flag = !(this.m_l.SelectedValue.ToString() != "0");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 13;
				case 22:
					if (flag)
					{
						MessageBox.Show("پایه ای انتخاب نشده است");
						num = 8;
					}
					else
					{
						num = 11;
					}
					continue;
				case 14:
					return;
				case 7:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 19;
				case 24:
					num = ((bx != "1") ? 21 : 25);
					continue;
				case 1:
					value = "2";
					value2 = this.m_l.SelectedValue.ToString();
					flag = this.m_e.SelectedIndex < 0;
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						MessageBox.Show("دانش آموزی انتخاب نشده است");
						num = 14;
					}
					else
					{
						num = 6;
					}
					continue;
				case 16:
					return;
					IL_058c:
					flag = (byte)num2 != 0;
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void v(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !ap.Checked;
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
					if (true)
					{
					}
					this.m_c.Visible = true;
					aq.Visible = false;
					this.m_ad.Visible = false;
					aw.Visible = false;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !ao.Checked;
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
					this.m_c.Visible = false;
					aq.Visible = true;
					this.m_ad.Visible = false;
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

	private void t(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		aw.Visible = true;
		this.m_ad.Visible = false;
	}

	private void b()
	{
		while (true)
		{
			string text = " tYear_Student.status=1 and tYear_Student.xYear=" + asdaj.__field_a;
			bool flag = a3.SelectedIndex <= 0;
			int num = 10;
			while (true)
			{
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 2;
				case 3:
					text += " and ";
					num = 16;
					continue;
				case 5:
					text = text + " tstudent.FName like '%" + asdaj.b(a1.Text) + "%'";
					num = 26;
					continue;
				case 2:
					flag = a5.SelectedIndex <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 23;
				case 29:
					flag = !(text != "");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 20;
				case 25:
					text = text + " tYear_Student.xClass=" + a3.SelectedValue.ToString();
					num = 2;
					continue;
				case 0:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 16;
				case 20:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code,  tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Sh_Sh, \r\n                   tStudent.MobileMother,tStudent.MobileFather,   tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent  INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text + " order by tStudent.lname,tStudent.fname");
					az.DataSource = dataSource;
					flag = az.RowCount <= 0;
					num = 28;
					continue;
				}
				case 28:
					if (!flag)
					{
						num = 18;
						continue;
					}
					return;
				case 4:
					text += " and ";
					num = 5;
					continue;
				case 21:
					flag = !(text != "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 13;
				case 24:
					text = " where " + text;
					num = 20;
					continue;
				case 18:
					az.Row = 0;
					num = 6;
					continue;
				case 6:
					return;
				case 13:
					text = text + " tYear_Student.xPaye=" + a5.SelectedValue.ToString();
					num = 23;
					continue;
				case 22:
					flag = !(text != "");
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 25;
				case 14:
					text += " and ";
					num = 13;
					continue;
				case 15:
					text += " and ";
					num = 25;
					continue;
				case 23:
					if (true)
					{
					}
					flag = !(a1.Text.Trim() != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 26;
				case 16:
					text = text + " tstudent.LName like '%" + asdaj.b(a0.Text) + "%'";
					num = 29;
					continue;
				case 26:
					flag = !(a0.Text.Trim() != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 29;
				case 7:
					flag = !(text != "");
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code,  tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName+ ' '+ tStudent.LName as fullname, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent  inner join tYear_Student on tStudent.id=tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id  INNER JOIN tmpStdforPrintSarbarg on  tStudent.id=tmpStdforPrintSarbarg.id where tYear_Student.xYear=" + asdaj.__field_a + " and tmpStdforPrintSarbarg.xUser=" + asdaj.l);
		at.DataSource = dataSource;
	}

	private void s(object A_0, EventArgs A_1)
	{
		f();
		b();
	}

	private void r(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		b();
	}

	private void q(object A_0, EventArgs A_1)
	{
		string text2 = default;
		int num2 = default;
		while (true)
		{
			bool flag = az.RowCount != 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 6;
						continue;
					}
					text2 = az.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num2 = 0;
					num = 0;
					continue;
				case 2:
					MessageBox.Show("این دانش آموز قبلا به لیست پرینت اضافه شده است");
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tmpStdforPrintSarbarg (id,xuser) VALUES     (" + text2 + "," + asdaj.l + ")");
					a();
					a0.Focus();
					num = 9;
					continue;
				case 9:
					return;
				case 6:
					MessageBox.Show("موردی جهت اضافه شدن وجود ندارد");
					a0.Focus();
					num = 5;
					continue;
				case 5:
					return;
				case 0:
				case 10:
					flag = num2 < at.RowCount;
					num = 7;
					continue;
				case 7:
				{
					if (!flag)
					{
						num = 3;
						continue;
					}
					string text = at.GetRow(num2).Cells["id"].Value.ToString();
					flag = !(text == text2);
					if (true)
					{
					}
					num = 4;
					continue;
				}
				case 4:
					if (flag)
					{
						num2++;
						num = 10;
					}
					else
					{
						num = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
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
					if (true)
					{
					}
					num = ((at.RowCount <= 0) ? 6 : 3);
					continue;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((at.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_00ee;
				case 4:
				{
					string text = at.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrintSarbarg where id=" + text);
					a();
					a0.Focus();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 6:
					{
						num2 = 1;
						goto IL_00ee;
					}
					IL_00ee:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = at.RowCount <= 0;
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
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrintSarbarg where xUser=" + asdaj.l);
					a();
					a0.Focus();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		aw.Visible = false;
	}

	private void m(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_aa.ShowDialog() != DialogResult.OK;
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
					bj.Text = this.m_aa.FileName;
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

	private void l(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_aa.ShowDialog() != DialogResult.OK;
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
					bh.Text = this.m_aa.FileName;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			bool flag = this.m_aa.ShowDialog() != DialogResult.OK;
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
					bd.Text = this.m_aa.FileName;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_aa.ShowDialog() != DialogResult.OK;
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
					if (true)
					{
					}
					bc.Text = this.m_aa.FileName;
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
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_aa.ShowDialog() != DialogResult.OK;
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
					bb.Text = this.m_aa.FileName;
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		this.m_y.Text = "";
	}

	private void g(object A_0, EventArgs A_1)
	{
		bj.Text = "";
	}

	private void f(object A_0, EventArgs A_1)
	{
		bh.Text = "";
	}

	private void e(object A_0, EventArgs A_1)
	{
		bd.Text = "";
	}

	private void d(object A_0, EventArgs A_1)
	{
		bc.Text = "";
	}

	private void c(object A_0, EventArgs A_1)
	{
		bb.Text = "";
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = int.Parse(ShamsiDate.GetShamsiDate(bw.the_date).Substring(0, 4)) >= 1399;
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
					j();
					num = 2;
					continue;
				case 0:
					if (true)
					{
					}
					MessageBox.Show("تاریخ انتخابی اشتباه است");
					bs.DataSource = null;
					num = 3;
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DateTime the_date = bw.the_date;
			DateTime the_date2 = bt.the_date;
			the_date = the_date.AddMonths(1);
			bool flag = !(the_date2 > the_date);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto case 2;
				case 1:
					MessageBox.Show("اختلاف دو تاریخ نباید بیشتر از یک ماه باشد");
					num = 2;
					continue;
				case 2:
					j();
					return;
				}
				break;
			}
		}
	}
}
