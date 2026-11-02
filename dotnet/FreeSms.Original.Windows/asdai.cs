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
using school_Af.Properties;

public class asdai : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private UIComboBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private Label m_i;

	private Label m_j;

	private EditBox m_k;

	private EditBox m_l;

	private UIButton m_m;

	private OpenFileDialog m_n;

	private UIComboBox m_o;

	private Label m_p;

	private Label q;

	private UIComboBox r;

	private Panel s;

	private UIButton t;

	private Label u;

	private MaskedEditBox v;

	private Label w;

	private MaskedEditBox x;

	private UIComboBox y;

	private Label z;

	private UIComboBox aa;

	private Label ab;

	private Label ac;

	private UIComboBox ad;

	private Label ae;

	private UIComboBox af;

	private UIComboBox ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private Label al;

	private UIComboBox am;

	private UIComboBox an;

	private UIComboBox ao;

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private UIComboBox at;

	private UIComboBox au;

	private UIComboBox av;

	private UIComboBox aw;

	private UIComboBox ax;

	private UIButton ay;

	private ProgressBar az;

	private UIButton a0;

	private SaveFileDialog a1;

	private EditBox a2;

	private Label a3;

	private Label a4;

	private EditBox a5;

	private UIGroupBox a6;

	private UIComboBox a7;

	private Label a8;

	private UIComboBox a9;

	private Label ba;

	private Label bb;

	private EditBox bc;

	private UIComboBox bd;

	private Label be;

	private UIButton bf;

	private Panel bg;

	private Label bh;

	private Timer bi;

	private bool bj = false;

	private int bk = 0;

	private int bl = 0;
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
						num = 2;
					}
					else
					{
						num = 1;
					}
					continue;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 3:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void j()
	{
		if (true)
		{
		}
		this.m_a = new Container();
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdai));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat4 = new StringFormat();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
		StringFormat stringFormat5 = new StringFormat();
		UIComboBoxItem uIComboBoxItem10 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem11 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem12 = new UIComboBoxItem();
		StringFormat stringFormat6 = new StringFormat();
		UIComboBoxItem uIComboBoxItem13 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem14 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem15 = new UIComboBoxItem();
		StringFormat stringFormat7 = new StringFormat();
		UIComboBoxItem uIComboBoxItem16 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem17 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem18 = new UIComboBoxItem();
		StringFormat stringFormat8 = new StringFormat();
		UIComboBoxItem uIComboBoxItem19 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem20 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem21 = new UIComboBoxItem();
		StringFormat stringFormat9 = new StringFormat();
		UIComboBoxItem uIComboBoxItem22 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem23 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem24 = new UIComboBoxItem();
		StringFormat stringFormat10 = new StringFormat();
		UIComboBoxItem uIComboBoxItem25 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem26 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem27 = new UIComboBoxItem();
		StringFormat stringFormat11 = new StringFormat();
		UIComboBoxItem uIComboBoxItem28 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem29 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem30 = new UIComboBoxItem();
		StringFormat stringFormat12 = new StringFormat();
		UIComboBoxItem uIComboBoxItem31 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem32 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem33 = new UIComboBoxItem();
		StringFormat stringFormat13 = new StringFormat();
		StringFormat stringFormat14 = new StringFormat();
		StringFormat stringFormat15 = new StringFormat();
		UIComboBoxItem uIComboBoxItem34 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem35 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem36 = new UIComboBoxItem();
		StringFormat stringFormat16 = new StringFormat();
		UIComboBoxItem uIComboBoxItem37 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem38 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem39 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem40 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem41 = new UIComboBoxItem();
		StringFormat stringFormat17 = new StringFormat();
		UIComboBoxItem uIComboBoxItem42 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem43 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem44 = new UIComboBoxItem();
		StringFormat stringFormat18 = new StringFormat();
		StringFormat stringFormat19 = new StringFormat();
		StringFormat stringFormat20 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		bg = new Panel();
		bh = new Label();
		bf = new UIButton();
		az = new ProgressBar();
		a0 = new UIButton();
		ay = new UIButton();
		t = new UIButton();
		this.m_d = new UIGroupBox();
		bd = new UIComboBox();
		be = new Label();
		a6 = new UIGroupBox();
		bc = new EditBox();
		ba = new Label();
		bb = new Label();
		a9 = new UIComboBox();
		a7 = new UIComboBox();
		a8 = new Label();
		a4 = new Label();
		a5 = new EditBox();
		aw = new UIComboBox();
		ax = new UIComboBox();
		au = new UIComboBox();
		av = new UIComboBox();
		ap = new Label();
		aq = new Label();
		ar = new Label();
		@as = new Label();
		at = new UIComboBox();
		al = new Label();
		am = new UIComboBox();
		an = new UIComboBox();
		ao = new UIComboBox();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		ag = new UIComboBox();
		ae = new Label();
		af = new UIComboBox();
		ac = new Label();
		ad = new UIComboBox();
		aa = new UIComboBox();
		ab = new Label();
		y = new UIComboBox();
		z = new Label();
		u = new Label();
		v = new MaskedEditBox();
		w = new Label();
		x = new MaskedEditBox();
		a2 = new EditBox();
		a3 = new Label();
		q = new Label();
		r = new UIComboBox();
		this.m_o = new UIComboBox();
		this.m_p = new Label();
		this.m_m = new UIButton();
		this.m_i = new Label();
		this.m_j = new Label();
		this.m_k = new EditBox();
		this.m_l = new EditBox();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		this.m_e = new Label();
		this.m_f = new UIComboBox();
		this.m_n = new OpenFileDialog();
		s = new Panel();
		a1 = new SaveFileDialog();
		bi = new Timer(this.m_a);
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		bg.SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_d.SuspendLayout();
		((ISupportInitialize)a6).BeginInit();
		a6.SuspendLayout();
		s.SuspendLayout();
		SuspendLayout();
		this.m_b.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_b.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("Tahoma", 9.75f);
		this.m_b.GroupByBoxFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		this.m_b.Location = new Point(8, 259);
		this.m_b.Name = "gridEX1";
		this.m_b.RecordNavigator = true;
		this.m_b.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_b.Size = new Size(776, 329);
		this.m_b.TabIndex = 5;
		this.m_b.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_b.SelectionChanged += k;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(bg);
		this.m_c.Controls.Add(bf);
		this.m_c.Controls.Add(az);
		this.m_c.Controls.Add(a0);
		this.m_c.Controls.Add(ay);
		this.m_c.Controls.Add(t);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_b);
		this.m_c.Font = new Font("Tahoma", 8.25f);
		this.m_c.Location = new Point(3, 3);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(794, 669);
		this.m_c.TabIndex = 0;
		bg.Controls.Add(bh);
		bg.Location = new Point(261, 352);
		bg.Name = "plode";
		bg.Size = new Size(305, 100);
		bg.TabIndex = 163;
		bh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		bh.AutoSize = true;
		bh.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		bh.Location = new Point(62, 45);
		bh.Name = "label23";
		bh.Size = new Size(189, 13);
		bh.TabIndex = 30;
		bh.Text = "در حال بارگزاری لطفا کمی صبر کنید";
		bf.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		bf.Image = Resources.rptview;
		bf.Location = new Point(471, 607);
		bf.Name = "btnComment";
		bf.Size = new Size(142, 45);
		bf.TabIndex = 63;
		bf.Text = "یادداشت";
		bf.Click += d;
		az.Location = new Point(189, 594);
		az.Name = "pr12";
		az.Size = new Size(167, 20);
		az.TabIndex = 62;
		az.Visible = false;
		a0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a0.ImageSize = new Size(30, 30);
		a0.Location = new Point(189, 618);
		a0.Name = "btnXls";
		a0.Size = new Size(167, 34);
		a0.TabIndex = 61;
		a0.Text = "دریافت فایل اکسل";
		a0.Click += g;
		ay.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		ay.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		ay.Location = new Point(628, 607);
		ay.Name = "btnEdit";
		ay.Size = new Size(153, 45);
		ay.TabIndex = 18;
		ay.Text = "اصلاح مورد انتخابی";
		ay.Click += h;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		t.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		t.ImageSize = new Size(20, 20);
		t.Location = new Point(8, 607);
		t.Name = "btnClose";
		t.Size = new Size(149, 45);
		t.TabIndex = 3;
		t.Text = "بستن";
		t.Click += o;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(bd);
		this.m_d.Controls.Add(be);
		this.m_d.Controls.Add(a6);
		this.m_d.Controls.Add(a4);
		this.m_d.Controls.Add(a5);
		this.m_d.Controls.Add(aw);
		this.m_d.Controls.Add(ax);
		this.m_d.Controls.Add(au);
		this.m_d.Controls.Add(av);
		this.m_d.Controls.Add(ap);
		this.m_d.Controls.Add(aq);
		this.m_d.Controls.Add(ar);
		this.m_d.Controls.Add(@as);
		this.m_d.Controls.Add(at);
		this.m_d.Controls.Add(al);
		this.m_d.Controls.Add(am);
		this.m_d.Controls.Add(an);
		this.m_d.Controls.Add(ao);
		this.m_d.Controls.Add(ah);
		this.m_d.Controls.Add(ai);
		this.m_d.Controls.Add(aj);
		this.m_d.Controls.Add(ak);
		this.m_d.Controls.Add(ag);
		this.m_d.Controls.Add(ae);
		this.m_d.Controls.Add(af);
		this.m_d.Controls.Add(ac);
		this.m_d.Controls.Add(ad);
		this.m_d.Controls.Add(aa);
		this.m_d.Controls.Add(ab);
		this.m_d.Controls.Add(y);
		this.m_d.Controls.Add(z);
		this.m_d.Controls.Add(u);
		this.m_d.Controls.Add(v);
		this.m_d.Controls.Add(w);
		this.m_d.Controls.Add(x);
		this.m_d.Controls.Add(a2);
		this.m_d.Controls.Add(a3);
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(r);
		this.m_d.Controls.Add(this.m_o);
		this.m_d.Controls.Add(this.m_p);
		this.m_d.Controls.Add(this.m_m);
		this.m_d.Controls.Add(this.m_i);
		this.m_d.Controls.Add(this.m_j);
		this.m_d.Controls.Add(this.m_k);
		this.m_d.Controls.Add(this.m_l);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Controls.Add(this.m_h);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(11, -1);
		this.m_d.Name = "uiGroupBox1";
		this.m_d.Size = new Size(770, 254);
		this.m_d.TabIndex = 17;
		this.m_d.Text = "جستجو";
		bd.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		bd.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "-";
		uIComboBoxItem.Value = "-1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "بله";
		uIComboBoxItem2.Value = "1";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "خیر";
		uIComboBoxItem3.Value = "0";
		bd.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3 });
		bd.Location = new Point(5, 164);
		bd.Name = "checkMarkTerm3_From100";
		bd.Size = new Size(74, 22);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		bd.StringFormat = stringFormat;
		bd.TabIndex = 162;
		bd.SelectedIndexChanged += i;
		be.AutoSize = true;
		be.Font = new Font("Tahoma", 6f, FontStyle.Bold, GraphicsUnit.Point, 178);
		be.Location = new Point(83, 169);
		be.Name = "label22";
		be.Size = new Size(73, 10);
		be.TabIndex = 161;
		be.Text = "نمره سالانه از 100";
		a6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		a6.Controls.Add(bc);
		a6.Controls.Add(ba);
		a6.Controls.Add(bb);
		a6.Controls.Add(a9);
		a6.Controls.Add(a7);
		a6.Controls.Add(a8);
		a6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a6.Location = new Point(97, 192);
		a6.Name = "groupTransport";
		a6.Size = new Size(669, 52);
		a6.TabIndex = 160;
		a6.Text = "سکونت فعلی";
		bc.AutoScroll = false;
		bc.AutoScrollMargin = new Size(0, 0);
		bc.AutoScrollMinSize = new Size(0, 0);
		bc.AutoScrollPosition = new Point(0, 0);
		bc.Location = new Point(6, 18);
		bc.Name = "txtAdress";
		bc.Size = new Size(149, 23);
		bc.TabIndex = 138;
		bc.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bc.TextChanged += a;
		ba.AutoSize = true;
		ba.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ba.Location = new Point(161, 23);
		ba.Name = "label21";
		ba.Size = new Size(39, 13);
		ba.TabIndex = 137;
		ba.Text = "آدرس :";
		bb.AutoSize = true;
		bb.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bb.Location = new Point(409, 23);
		bb.Name = "label42";
		bb.Size = new Size(59, 13);
		bb.TabIndex = 136;
		bb.Text = "ولسوالی\u200c  :";
		a9.Location = new Point(213, 18);
		a9.Name = "dropcity";
		a9.Size = new Size(190, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		a9.StringFormat = stringFormat2;
		a9.TabIndex = 34;
		a9.SelectedIndexChanged += e;
		a7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a7.BorderStyle = Janus.Windows.UI.BorderStyle.RaisedLight3D;
		a7.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		a7.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a7.Location = new Point(486, 18);
		a7.Name = "comboOst_Cty";
		a7.RightToLeft = RightToLeft.Yes;
		a7.Size = new Size(132, 24);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		a7.StringFormat = stringFormat3;
		a7.TabIndex = 32;
		a7.SelectedIndexChanged += f;
		a8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a8.AutoSize = true;
		a8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a8.Location = new Point(624, 23);
		a8.Name = "label18";
		a8.RightToLeft = RightToLeft.Yes;
		a8.Size = new Size(39, 13);
		a8.TabIndex = 31;
		a8.Text = "ولایت :";
		a8.TextAlign = ContentAlignment.MiddleRight;
		a4.AutoSize = true;
		a4.Location = new Point(683, 51);
		a4.Name = "label45";
		a4.Size = new Size(43, 14);
		a4.TabIndex = 159;
		a4.Text = "تخلص";
		a5.AutoScroll = false;
		a5.AutoScrollMargin = new Size(0, 0);
		a5.AutoScrollMinSize = new Size(0, 0);
		a5.AutoScrollPosition = new Point(0, 0);
		a5.Location = new Point(535, 48);
		a5.Name = "txtLastName";
		a5.Size = new Size(143, 22);
		a5.TabIndex = 158;
		a5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a5.TextChanged += a;
		aw.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		aw.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "-";
		uIComboBoxItem4.Value = "-1";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "بله";
		uIComboBoxItem5.Value = "1";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "خیر";
		uIComboBoxItem6.Value = "0";
		aw.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		aw.Location = new Point(5, 135);
		aw.Name = "checkmali";
		aw.Size = new Size(74, 22);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		aw.StringFormat = stringFormat4;
		aw.TabIndex = 157;
		aw.SelectedIndexChanged += i;
		ax.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ax.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "-";
		uIComboBoxItem7.Value = "-1";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "بله";
		uIComboBoxItem8.Value = "1";
		uIComboBoxItem9.FormatStyle.Alpha = 0;
		uIComboBoxItem9.Text = "خیر";
		uIComboBoxItem9.Value = "0";
		ax.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem7, uIComboBoxItem8, uIComboBoxItem9 });
		ax.Location = new Point(5, 105);
		ax.Name = "checkhazer";
		ax.Size = new Size(74, 22);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		ax.StringFormat = stringFormat5;
		ax.TabIndex = 156;
		ax.SelectedIndexChanged += i;
		au.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		au.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem10.FormatStyle.Alpha = 0;
		uIComboBoxItem10.Text = "-";
		uIComboBoxItem10.Value = "-1";
		uIComboBoxItem11.FormatStyle.Alpha = 0;
		uIComboBoxItem11.Text = "بله";
		uIComboBoxItem11.Value = "1";
		uIComboBoxItem12.FormatStyle.Alpha = 0;
		uIComboBoxItem12.Text = "خیر";
		uIComboBoxItem12.Value = "0";
		au.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem10, uIComboBoxItem11, uIComboBoxItem12 });
		au.Location = new Point(159, 41);
		au.Name = "checkshaghe";
		au.Size = new Size(74, 22);
		stringFormat6.Alignment = StringAlignment.Near;
		stringFormat6.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat6.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat6.LineAlignment = StringAlignment.Center;
		stringFormat6.Trimming = StringTrimming.Character;
		au.StringFormat = stringFormat6;
		au.TabIndex = 155;
		au.SelectedIndexChanged += i;
		av.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		av.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem13.FormatStyle.Alpha = 0;
		uIComboBoxItem13.Text = "-";
		uIComboBoxItem13.Value = "-1";
		uIComboBoxItem14.FormatStyle.Alpha = 0;
		uIComboBoxItem14.Text = "بله";
		uIComboBoxItem14.Value = "1";
		uIComboBoxItem15.FormatStyle.Alpha = 0;
		uIComboBoxItem15.Text = "خیر";
		uIComboBoxItem15.Value = "0";
		av.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem13, uIComboBoxItem14, uIComboBoxItem15 });
		av.Location = new Point(159, 13);
		av.Name = "checkmaghnae";
		av.Size = new Size(74, 22);
		stringFormat7.Alignment = StringAlignment.Near;
		stringFormat7.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat7.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat7.LineAlignment = StringAlignment.Center;
		stringFormat7.Trimming = StringTrimming.Character;
		av.StringFormat = stringFormat7;
		av.TabIndex = 154;
		av.SelectedIndexChanged += i;
		ap.AutoSize = true;
		ap.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ap.Location = new Point(83, 139);
		ap.Name = "label17";
		ap.Size = new Size(69, 13);
		ap.TabIndex = 152;
		ap.Text = "لیست مالی";
		aq.AutoSize = true;
		aq.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aq.Location = new Point(83, 109);
		aq.Name = "label16";
		aq.Size = new Size(67, 12);
		aq.TabIndex = 151;
		aq.Text = "حاضردر صنف";
		ar.AutoSize = true;
		ar.Location = new Point(237, 45);
		ar.Name = "label15";
		ar.Size = new Size(35, 14);
		ar.TabIndex = 150;
		ar.Text = "شقه";
		@as.AutoSize = true;
		@as.Location = new Point(237, 17);
		@as.Name = "label14";
		@as.Size = new Size(41, 14);
		@as.TabIndex = 149;
		@as.Text = "مقنعه";
		at.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		at.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem16.FormatStyle.Alpha = 0;
		uIComboBoxItem16.Text = "-";
		uIComboBoxItem16.Value = "-1";
		uIComboBoxItem17.FormatStyle.Alpha = 0;
		uIComboBoxItem17.Text = "بله";
		uIComboBoxItem17.Value = "1";
		uIComboBoxItem18.FormatStyle.Alpha = 0;
		uIComboBoxItem18.Text = "خیر";
		uIComboBoxItem18.Value = "0";
		at.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem16, uIComboBoxItem17, uIComboBoxItem18 });
		at.Location = new Point(5, 75);
		at.Name = "checkrobotic";
		at.Size = new Size(74, 22);
		stringFormat8.Alignment = StringAlignment.Near;
		stringFormat8.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat8.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat8.LineAlignment = StringAlignment.Center;
		stringFormat8.Trimming = StringTrimming.Character;
		at.StringFormat = stringFormat8;
		at.TabIndex = 148;
		at.SelectedIndexChanged += i;
		al.AutoSize = true;
		al.Location = new Point(83, 80);
		al.Name = "label13";
		al.Size = new Size(43, 14);
		al.TabIndex = 147;
		al.Text = "رباتیک";
		am.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		am.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem19.FormatStyle.Alpha = 0;
		uIComboBoxItem19.Text = "-";
		uIComboBoxItem19.Value = "-1";
		uIComboBoxItem20.FormatStyle.Alpha = 0;
		uIComboBoxItem20.Text = "بله";
		uIComboBoxItem20.Value = "1";
		uIComboBoxItem21.FormatStyle.Alpha = 0;
		uIComboBoxItem21.Text = "خیر";
		uIComboBoxItem21.Value = "0";
		am.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem19, uIComboBoxItem20, uIComboBoxItem21 });
		am.Location = new Point(5, 44);
		am.Name = "checktransport";
		am.Size = new Size(74, 22);
		stringFormat9.Alignment = StringAlignment.Near;
		stringFormat9.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat9.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat9.LineAlignment = StringAlignment.Center;
		stringFormat9.Trimming = StringTrimming.Character;
		am.StringFormat = stringFormat9;
		am.TabIndex = 146;
		am.SelectedIndexChanged += i;
		an.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		an.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem22.FormatStyle.Alpha = 0;
		uIComboBoxItem22.Text = "-";
		uIComboBoxItem22.Value = "-1";
		uIComboBoxItem23.FormatStyle.Alpha = 0;
		uIComboBoxItem23.Text = "بله";
		uIComboBoxItem23.Value = "1";
		uIComboBoxItem24.FormatStyle.Alpha = 0;
		uIComboBoxItem24.Text = "خیر";
		uIComboBoxItem24.Value = "0";
		an.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem22, uIComboBoxItem23, uIComboBoxItem24 });
		an.Location = new Point(5, 13);
		an.Name = "checkketab";
		an.Size = new Size(74, 22);
		stringFormat10.Alignment = StringAlignment.Near;
		stringFormat10.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat10.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat10.LineAlignment = StringAlignment.Center;
		stringFormat10.Trimming = StringTrimming.Character;
		an.StringFormat = stringFormat10;
		an.TabIndex = 145;
		an.SelectedIndexChanged += i;
		ao.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ao.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem25.FormatStyle.Alpha = 0;
		uIComboBoxItem25.Text = "-";
		uIComboBoxItem25.Value = "-1";
		uIComboBoxItem26.FormatStyle.Alpha = 0;
		uIComboBoxItem26.Text = "بله";
		uIComboBoxItem26.Value = "1";
		uIComboBoxItem27.FormatStyle.Alpha = 0;
		uIComboBoxItem27.Text = "خیر";
		uIComboBoxItem27.Value = "0";
		ao.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem25, uIComboBoxItem26, uIComboBoxItem27 });
		ao.Location = new Point(159, 135);
		ao.Name = "checkkomakdarsi";
		ao.Size = new Size(74, 22);
		stringFormat11.Alignment = StringAlignment.Near;
		stringFormat11.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat11.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat11.LineAlignment = StringAlignment.Center;
		stringFormat11.Trimming = StringTrimming.Character;
		ao.StringFormat = stringFormat11;
		ao.TabIndex = 144;
		ao.SelectedIndexChanged += i;
		ah.AutoSize = true;
		ah.Location = new Point(83, 48);
		ah.Name = "label12";
		ah.Size = new Size(68, 14);
		ah.TabIndex = 143;
		ah.Text = "ترانسپورت";
		ai.AutoSize = true;
		ai.Location = new Point(83, 17);
		ai.Name = "label11";
		ai.Size = new Size(34, 14);
		ai.TabIndex = 142;
		ai.Text = "کتاب";
		aj.AutoSize = true;
		aj.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aj.Location = new Point(237, 139);
		aj.Name = "label10";
		aj.Size = new Size(70, 13);
		aj.TabIndex = 141;
		aj.Text = "کمک درسی";
		ak.AutoSize = true;
		ak.Location = new Point(237, 110);
		ak.Name = "label9";
		ak.Size = new Size(55, 14);
		ak.TabIndex = 140;
		ak.Text = "یونیفورم";
		ag.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ag.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem28.FormatStyle.Alpha = 0;
		uIComboBoxItem28.Text = "-";
		uIComboBoxItem28.Value = "-1";
		uIComboBoxItem29.FormatStyle.Alpha = 0;
		uIComboBoxItem29.Text = "بله";
		uIComboBoxItem29.Value = "1";
		uIComboBoxItem30.FormatStyle.Alpha = 0;
		uIComboBoxItem30.Text = "خیر";
		uIComboBoxItem30.Value = "0";
		ag.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem28, uIComboBoxItem29, uIComboBoxItem30 });
		ag.Location = new Point(159, 106);
		ag.Name = "checkuniform";
		ag.Size = new Size(74, 22);
		stringFormat12.Alignment = StringAlignment.Near;
		stringFormat12.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat12.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat12.LineAlignment = StringAlignment.Center;
		stringFormat12.Trimming = StringTrimming.Character;
		ag.StringFormat = stringFormat12;
		ag.TabIndex = 139;
		ag.SelectedIndexChanged += i;
		ae.AutoSize = true;
		ae.Location = new Point(237, 82);
		ae.Name = "label7";
		ae.Size = new Size(40, 14);
		ae.TabIndex = 138;
		ae.Text = "داخله";
		af.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		af.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem31.FormatStyle.Alpha = 0;
		uIComboBoxItem31.Text = "-";
		uIComboBoxItem31.Value = "-1";
		uIComboBoxItem32.FormatStyle.Alpha = 0;
		uIComboBoxItem32.Text = "بله";
		uIComboBoxItem32.Value = "1";
		uIComboBoxItem33.FormatStyle.Alpha = 0;
		uIComboBoxItem33.Text = "خیر";
		uIComboBoxItem33.Value = "0";
		af.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem31, uIComboBoxItem32, uIComboBoxItem33 });
		af.Location = new Point(159, 72);
		af.Name = "checkdakhle";
		af.Size = new Size(74, 22);
		stringFormat13.Alignment = StringAlignment.Near;
		stringFormat13.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat13.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat13.LineAlignment = StringAlignment.Center;
		stringFormat13.Trimming = StringTrimming.Character;
		af.StringFormat = stringFormat13;
		af.TabIndex = 137;
		af.SelectedIndexChanged += i;
		ac.AutoSize = true;
		ac.Location = new Point(472, 22);
		ac.Name = "label41";
		ac.Size = new Size(40, 14);
		ac.TabIndex = 136;
		ac.Text = "راننده";
		ad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ad.Location = new Point(310, 17);
		ad.Name = "dropDriver";
		ad.Size = new Size(153, 22);
		stringFormat14.Alignment = StringAlignment.Near;
		stringFormat14.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat14.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat14.LineAlignment = StringAlignment.Center;
		stringFormat14.Trimming = StringTrimming.Character;
		ad.StringFormat = stringFormat14;
		ad.TabIndex = 135;
		ad.SelectedIndexChanged += i;
		aa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		aa.DropListFont = new Font("B Nazanin", 12f);
		aa.Location = new Point(159, 163);
		aa.Name = "dropTakhfif";
		aa.Size = new Size(74, 22);
		stringFormat15.Alignment = StringAlignment.Near;
		stringFormat15.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat15.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat15.LineAlignment = StringAlignment.Center;
		stringFormat15.Trimming = StringTrimming.Character;
		aa.StringFormat = stringFormat15;
		aa.TabIndex = 125;
		aa.SelectedIndexChanged += i;
		ab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ab.AutoSize = true;
		ab.Location = new Point(242, 166);
		ab.Name = "label40";
		ab.Size = new Size(45, 14);
		ab.TabIndex = 126;
		ab.Text = "تخفیف";
		uIComboBoxItem34.FormatStyle.Alpha = 0;
		uIComboBoxItem34.Text = "";
		uIComboBoxItem34.Value = "-1";
		uIComboBoxItem35.FormatStyle.Alpha = 0;
		uIComboBoxItem35.Text = "شیعه";
		uIComboBoxItem35.Value = "1";
		uIComboBoxItem36.FormatStyle.Alpha = 0;
		uIComboBoxItem36.Text = "سنی";
		uIComboBoxItem36.Value = "2";
		y.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem34, uIComboBoxItem35, uIComboBoxItem36 });
		y.Location = new Point(310, 164);
		y.Name = "dropMazhab";
		y.Size = new Size(153, 22);
		stringFormat16.Alignment = StringAlignment.Near;
		stringFormat16.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat16.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat16.LineAlignment = StringAlignment.Center;
		stringFormat16.Trimming = StringTrimming.Character;
		y.StringFormat = stringFormat16;
		y.TabIndex = 123;
		y.SelectedIndexChanged += i;
		z.AutoSize = true;
		z.Location = new Point(468, 168);
		z.Name = "label6";
		z.Size = new Size(42, 14);
		z.TabIndex = 124;
		z.Text = "مذهب";
		u.AutoSize = true;
		u.Location = new Point(684, 168);
		u.Name = "label3";
		u.Size = new Size(72, 14);
		u.TabIndex = 122;
		u.Text = "تاریخ تولد تا";
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Location = new Point(535, 164);
		v.Mask = "0000/00/00";
		v.MaxLength = 12;
		v.Name = "txtbDateTo";
		v.Numeric = true;
		v.RightToLeft = RightToLeft.No;
		v.Size = new Size(143, 22);
		v.TabIndex = 121;
		v.Tag = "";
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		v.TextChanged += a;
		w.AutoSize = true;
		w.Location = new Point(684, 139);
		w.Name = "label38";
		w.Size = new Size(74, 14);
		w.TabIndex = 120;
		w.Text = "تاریخ تولد از";
		x.AutoScroll = false;
		x.AutoScrollMargin = new Size(0, 0);
		x.AutoScrollMinSize = new Size(0, 0);
		x.AutoScrollPosition = new Point(0, 0);
		x.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Location = new Point(535, 135);
		x.Mask = "0000/00/00";
		x.MaxLength = 12;
		x.Name = "txtbDateFrom";
		x.Numeric = true;
		x.RightToLeft = RightToLeft.No;
		x.Size = new Size(143, 22);
		x.TabIndex = 119;
		x.Tag = "";
		x.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		x.TextChanged += a;
		a2.AutoScroll = false;
		a2.AutoScrollMargin = new Size(0, 0);
		a2.AutoScrollMinSize = new Size(0, 0);
		a2.AutoScrollPosition = new Point(0, 0);
		a2.Location = new Point(535, 105);
		a2.Name = "txtNamP";
		a2.Size = new Size(143, 22);
		a2.TabIndex = 115;
		a2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a2.TextChanged += a;
		a3.AutoSize = true;
		a3.Location = new Point(684, 109);
		a3.Name = "label8";
		a3.Size = new Size(41, 14);
		a3.TabIndex = 116;
		a3.Text = "ولدیت";
		q.AutoSize = true;
		q.Location = new Point(468, 52);
		q.Name = "label2";
		q.Size = new Size(49, 14);
		q.TabIndex = 114;
		q.Text = "وضعیت";
		r.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		r.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem37.FormatStyle.Alpha = 0;
		uIComboBoxItem37.Text = "کل";
		uIComboBoxItem37.Value = "0";
		uIComboBoxItem38.FormatStyle.Alpha = 0;
		uIComboBoxItem38.Text = "برحال";
		uIComboBoxItem38.Value = "1";
		uIComboBoxItem39.FormatStyle.Alpha = 0;
		uIComboBoxItem39.Text = "محروم";
		uIComboBoxItem39.Value = "2";
		uIComboBoxItem40.FormatStyle.Alpha = 0;
		uIComboBoxItem40.Text = "منفک";
		uIComboBoxItem40.Value = "3";
		uIComboBoxItem41.FormatStyle.Alpha = 0;
		uIComboBoxItem41.Text = "معذرتی";
		uIComboBoxItem41.Value = "4";
		r.Items.AddRange(new UIComboBoxItem[5] { uIComboBoxItem37, uIComboBoxItem38, uIComboBoxItem39, uIComboBoxItem40, uIComboBoxItem41 });
		r.Location = new Point(310, 48);
		r.Name = "dropStatus";
		r.Size = new Size(153, 22);
		stringFormat17.Alignment = StringAlignment.Near;
		stringFormat17.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat17.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat17.LineAlignment = StringAlignment.Center;
		stringFormat17.Trimming = StringTrimming.Character;
		r.StringFormat = stringFormat17;
		r.TabIndex = 9;
		r.SelectedIndexChanged += j;
		this.m_o.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_o.DropListFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		uIComboBoxItem42.FormatStyle.Alpha = 0;
		uIComboBoxItem42.Text = "کل";
		uIComboBoxItem42.Value = "-1";
		uIComboBoxItem43.FormatStyle.Alpha = 0;
		uIComboBoxItem43.Text = "مرد";
		uIComboBoxItem43.Value = "1";
		uIComboBoxItem44.FormatStyle.Alpha = 0;
		uIComboBoxItem44.Text = "زن";
		uIComboBoxItem44.Value = "0";
		this.m_o.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem42, uIComboBoxItem43, uIComboBoxItem44 });
		this.m_o.Location = new Point(310, 135);
		this.m_o.Name = "dropJens";
		this.m_o.Size = new Size(153, 22);
		stringFormat18.Alignment = StringAlignment.Near;
		stringFormat18.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat18.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat18.LineAlignment = StringAlignment.Center;
		stringFormat18.Trimming = StringTrimming.Character;
		this.m_o.StringFormat = stringFormat18;
		this.m_o.TabIndex = 5;
		this.m_o.SelectedIndexChanged += i;
		this.m_p.AutoSize = true;
		this.m_p.Location = new Point(468, 139);
		this.m_p.Name = "label1";
		this.m_p.Size = new Size(52, 14);
		this.m_p.TabIndex = 85;
		this.m_p.Text = "جنیست";
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		this.m_m.ImageSize = new Size(25, 25);
		this.m_m.Location = new Point(5, 195);
		this.m_m.Name = "btnNoSearch";
		this.m_m.Size = new Size(86, 52);
		this.m_m.TabIndex = 11;
		this.m_m.Text = "حذف جستجو";
		this.m_m.Click += m;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(684, 80);
		this.m_i.Name = "label5";
		this.m_i.Size = new Size(53, 14);
		this.m_i.TabIndex = 29;
		this.m_i.Text = "ولد/بنت";
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.AutoSize = true;
		this.m_j.Location = new Point(684, 21);
		this.m_j.Name = "label4";
		this.m_j.Size = new Size(23, 14);
		this.m_j.TabIndex = 28;
		this.m_j.Text = "نام";
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.AutoScroll = false;
		this.m_k.AutoScrollMargin = new Size(0, 0);
		this.m_k.AutoScrollMinSize = new Size(0, 0);
		this.m_k.AutoScrollPosition = new Point(0, 0);
		this.m_k.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_k.Location = new Point(535, 76);
		this.m_k.Name = "txtLName";
		this.m_k.RightToLeft = RightToLeft.Yes;
		this.m_k.Size = new Size(143, 22);
		this.m_k.TabIndex = 4;
		this.m_k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_k.TextChanged += a;
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.AutoScroll = false;
		this.m_l.AutoScrollMargin = new Size(0, 0);
		this.m_l.AutoScrollMinSize = new Size(0, 0);
		this.m_l.AutoScrollPosition = new Point(0, 0);
		this.m_l.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_l.Location = new Point(535, 17);
		this.m_l.Name = "txtFName";
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.Size = new Size(143, 22);
		this.m_l.TabIndex = 3;
		this.m_l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_l.TextChanged += a;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.AutoSize = true;
		this.m_g.Location = new Point(468, 109);
		this.m_g.Name = "label19";
		this.m_g.Size = new Size(36, 14);
		this.m_g.TabIndex = 25;
		this.m_g.Text = "صنف";
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(310, 105);
		this.m_h.Name = "dropCls";
		this.m_h.Size = new Size(153, 22);
		stringFormat19.Alignment = StringAlignment.Near;
		stringFormat19.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat19.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat19.LineAlignment = StringAlignment.Center;
		stringFormat19.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat19;
		this.m_h.TabIndex = 8;
		this.m_h.SelectedIndexChanged += l;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(468, 80);
		this.m_e.Name = "label20";
		this.m_e.Size = new Size(27, 14);
		this.m_e.TabIndex = 15;
		this.m_e.Text = "پایه";
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_f.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(310, 76);
		this.m_f.Name = "dropPaye";
		this.m_f.Size = new Size(153, 22);
		stringFormat20.Alignment = StringAlignment.Near;
		stringFormat20.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat20.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat20.LineAlignment = StringAlignment.Center;
		stringFormat20.Trimming = StringTrimming.Character;
		this.m_f.StringFormat = stringFormat20;
		this.m_f.TabIndex = 7;
		this.m_f.SelectedIndexChanged += n;
		this.m_n.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_n.Title = "انتخاب عکس شاگرد";
		s.BackColor = Color.Black;
		s.Controls.Add(this.m_c);
		s.Dock = DockStyle.Fill;
		s.Location = new Point(0, 0);
		s.Name = "panel2";
		s.Size = new Size(800, 675);
		s.TabIndex = 1;
		bi.Interval = 700;
		bi.Tick += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 675);
		Controls.Add(s);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmlistStdSearch";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست شاگردان";
		Load += p;
		Shown += c;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		bg.ResumeLayout(performLayout: false);
		bg.PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)a6).EndInit();
		a6.ResumeLayout(performLayout: false);
		a6.PerformLayout();
		s.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdai()
	{
		j();
	}

	private void p(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 2;
					continue;
				case 5:
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
					num = 1;
					continue;
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_012c;
				case 6:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					if (1 == 0)
					{
					}
					goto IL_012c;
				case 0:
					{
						num = 5;
						continue;
					}
					IL_012c:
					r.SelectedIndex = 0;
					this.m_o.SelectedIndex = 0;
					g();
					f();
					b();
					c();
					h();
					i();
					bj = true;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void i()
	{
		while (true)
		{
			string text = "";
			bool flag = a7.SelectedIndex <= 0;
			int num = 2;
			while (true)
			{
				DataTable dataSource;
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_007c;
				case 0:
					text = text + " where xOstan=" + a7.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
					{
						if (1 == 0)
						{
						}
						goto IL_007c;
					}
					IL_007c:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'کل' as  name\r\n                                                                                                union select id,name from tCity" + text);
					a9.DataSource = dataSource;
					a9.ValueMember = "id";
					a9.DisplayMember = "name";
					return;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'کل' as  name\r\n                                                                                                                union  select id , name from tostan");
		a7.DataSource = dataSource;
		a7.ValueMember = "id";
		a7.DisplayMember = "name";
	}

	private void g()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") order by id");
			this.m_f.Items.Add("کل", "0");
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
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					this.m_f.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 1:
					this.m_f.SelectedIndex = 0;
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
			if (true)
			{
			}
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_f.SelectedIndex <= 0;
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
					text = " and xPaye=" + this.m_f.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + asdaj.__field_a + text);
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					this.m_h.SelectedIndex = 0;
					return;
				}
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
		this.m_b.DataSource = null;
		bg.Visible = true;
		Refresh();
		d();
	}

	private void d()
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = bj;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					string text = a();
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName, \r\n   tStudent.LName, tStudent.PName, tStudent.Sh_Sh, tStudent.bDate, tStudent.bDateM, \r\n  tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName,\r\n            tOstan.Name AS Ostan, tCity.Name AS City, tStudent.Adress,tmpMark1.markDoreh as mark1,\r\n                      tStudent.MobileMother, tStudent.MobileFather, tClass.name AS Class, tPaye.Name AS Paye, tStudentImg.Student_img, tStudent.NumberTelegram, \r\n                      tStudent.NumberTelegram2, tStudent.NumberAsas, tStudent.RegDate, tYear_Student.Status, tYear_Student.sort, tYear_Student.shaghe, tYear_Student.hazer, \r\n                      tYear_Student.mali, tYear_Student.dakhle, tYear_Student.uniform, tYear_Student.komakdarsi, tYear_Student.ketab, tYear_Student.transport, tYear_Student.robotic, \r\n                      tYear_Student.maghnae,tYear_Student.MarkTerm3_From100, tYear_Student.SumFee, tYear_Student.Sumtransport, tDriver.name AS Driver, tTakhfif.name AS Takhfif,\r\ncase tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک' when 4 then N'معذرتی' end as vazeyat\r\n,case tStudent.Jens when 1 then N'مرد' when 0 then N'زن' else '' end as Jens\r\n,case tStudent.Mazhab when 1 then N'شیعه' when 0 then N'سنی' else '' end as Mazhab\r\n,tYear_Student.codeTakhfif, tOstan_1.Name AS OstanNow, tCity_1.Name AS CityNow\r\nFROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN\r\n                      tDriver ON tYear_Student.xDriver = tDriver.id LEFT OUTER JOIN\r\n                      tTakhfif ON tYear_Student.xTakhfif = tTakhfif.id LEFT OUTER JOIN\r\n                      tStudentImg ON tStudent.id = tStudentImg.xStudent   LEFT OUTER JOIN\r\n                      tCity ON tStudent.xCity = tCity.id  LEFT OUTER JOIN\r\n                      tOstan ON tCity.xOstan = tOstan.id  LEFT OUTER JOIN\r\n                      tCity tCity_1 ON tStudent.xCityNow = tCity_1.id LEFT OUTER JOIN\r\n                      tOstan tOstan_1 ON tCity_1.xOstan = tOstan_1.id LEFT OUTER JOIN\r\n(SELECT     ROUND(tMarkDoreh.MarkDoreh, 2) AS markDoreh, tMarkDoreh.xStudent\r\nFROM         tMarkDoreh INNER JOIN\r\n                      tExam ON tMarkDoreh.Xtest = tExam.id\r\nWHERE     (tExam.term = 1) AND (tExam.xYear = " + asdaj.__field_a + ") AND (tMarkDoreh.typ = 5))tmpMark1 on tStudent.id=tmpMark1.xStudent" + text);
					this.m_b.DataSource = dataSource;
					bg.Visible = false;
					num = 0;
					continue;
				}
				case 0:
					return;
				case 1:
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void n(object A_0, EventArgs A_1)
	{
		f();
		e();
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from ttakhfif order by name");
		aa.DataSource = dataSource;
		aa.DisplayMember = "Name";
		aa.ValueMember = "id";
		aa.SelectedIndex = 0;
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tDriver order by name");
		ad.DataSource = dataSource;
		ad.DisplayMember = "Name";
		ad.ValueMember = "id";
		ad.SelectedIndex = 0;
	}

	private void m(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		bj = false;
		this.m_f.SelectedIndex = 0;
		this.m_h.SelectedIndex = 0;
		r.SelectedIndex = 0;
		this.m_o.SelectedIndex = 0;
		ad.SelectedIndex = 0;
		y.SelectedIndex = 0;
		y.SelectedIndex = 0;
		aa.SelectedIndex = 0;
		af.SelectedIndex = 0;
		ax.SelectedIndex = 0;
		an.SelectedIndex = 0;
		ao.SelectedIndex = 0;
		av.SelectedIndex = 0;
		aw.SelectedIndex = 0;
		at.SelectedIndex = 0;
		au.SelectedIndex = 0;
		am.SelectedIndex = 0;
		ag.SelectedIndex = 0;
		bd.SelectedIndex = 0;
		this.m_k.Text = "";
		this.m_l.Text = "";
		a2.Text = "";
		a5.Text = "";
		bc.Text = "";
		a9.SelectedIndex = 0;
		a7.SelectedIndex = 0;
		bj = true;
		e();
	}

	private void l(object A_0, EventArgs A_1)
	{
		e();
	}

	private void k(object A_0, EventArgs A_1)
	{
		bk = this.m_b.Row;
	}

	private string a()
	{
		string result = default;
		while (true)
		{
			string text = " tYear_Student.xYear=" + asdaj.__field_a + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = this.m_h.SelectedIndex <= 0;
			int num = 94;
			while (true)
			{
				switch (num)
				{
				case 94:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 10;
				case 84:
					text += " and ";
					num = 163;
					continue;
				case 156:
					text = text + " tYear_Student.transport=" + am.SelectedValue.ToString();
					num = 152;
					continue;
				case 112:
					flag = aa.SelectedIndex <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 145;
				case 80:
					text += " and ";
					num = 85;
					continue;
				case 86:
					text = text + " tstudent.jens=" + this.m_o.SelectedValue.ToString();
					num = 23;
					continue;
				case 40:
					flag = !(this.m_k.Text.Trim() != "");
					num = 97;
					continue;
				case 97:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 43;
				case 151:
					flag = !(text != "");
					num = 88;
					continue;
				case 88:
					if (!flag)
					{
						num = 120;
						continue;
					}
					goto case 27;
				case 115:
					flag = !(text != "");
					num = 164;
					continue;
				case 164:
					if (!flag)
					{
						num = 155;
						continue;
					}
					goto case 1;
				case 111:
					text = text + " tYear_Student.xTakhfif=" + aa.SelectedValue.ToString();
					num = 145;
					continue;
				case 81:
					flag = !(text != "");
					num = 92;
					continue;
				case 92:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 16;
				case 73:
					flag = !(text != "");
					num = 31;
					continue;
				case 31:
					if (!flag)
					{
						num = 114;
						continue;
					}
					goto case 29;
				case 138:
					flag = !(text != "");
					num = 137;
					continue;
				case 137:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 75;
				case 48:
					flag = !(text != "");
					num = 104;
					continue;
				case 104:
					if (!flag)
					{
						num = 106;
						continue;
					}
					goto case 45;
				case 124:
					text += " and ";
					num = 52;
					continue;
				case 100:
					text += " and ";
					num = 34;
					continue;
				case 145:
					flag = af.SelectedIndex <= 0;
					num = 126;
					continue;
				case 126:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 161;
				case 16:
					text = text + " tstudent.bDate<='" + asdaj.b(v.Text) + "'";
					num = 22;
					continue;
				case 142:
					text = text + " tstudent.LastName like '%" + asdaj.b(a5.Text) + "%'";
					num = 60;
					continue;
				case 61:
					flag = av.SelectedIndex <= 0;
					num = 143;
					continue;
				case 143:
					if (!flag)
					{
						num = 144;
						continue;
					}
					goto case 79;
				case 144:
					flag = !(text != "");
					num = 63;
					continue;
				case 63:
					if (!flag)
					{
						num = 134;
						continue;
					}
					goto case 130;
				case 74:
					text = text + " tYear_Student.MarkTerm3_From100=" + bd.SelectedValue.ToString();
					num = 82;
					continue;
				case 95:
					text = text + " tYear_Student.hazer=" + ax.SelectedValue.ToString();
					num = 37;
					continue;
				case 8:
					flag = !(text != "");
					num = 157;
					continue;
				case 157:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 111;
				case 85:
					text = text + " tstudent.Adress like '%" + asdaj.b(bc.Text) + "%'";
					num = 0;
					continue;
				case 160:
					flag = !(text != "");
					num = 35;
					continue;
				case 35:
					if (!flag)
					{
						num = 51;
						continue;
					}
					goto case 95;
				case 146:
					text += " and ";
					num = 90;
					continue;
				case 24:
					flag = !(text != "");
					num = 78;
					continue;
				case 78:
					if (!flag)
					{
						num = 146;
						continue;
					}
					goto case 90;
				case 154:
					flag = !(text != "");
					num = 133;
					continue;
				case 133:
					if (!flag)
					{
						num = 55;
						continue;
					}
					goto case 93;
				case 10:
					flag = this.m_f.SelectedIndex <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						if (true)
						{
						}
						num = 131;
						continue;
					}
					goto case 65;
				case 147:
					text += " and ";
					num = 12;
					continue;
				case 91:
					text = text + " tYear_Student.ketab=" + an.SelectedValue.ToString();
					num = 148;
					continue;
				case 158:
					text = text + " tstudent.PName like '%" + asdaj.b(a2.Text) + "%'";
					num = 113;
					continue;
				case 76:
					flag = !(text != "");
					num = 128;
					continue;
				case 128:
					if (!flag)
					{
						num = 87;
						continue;
					}
					goto case 99;
				case 153:
					text = text + " tstudent.bDate>='" + asdaj.b(x.Text) + "'";
					num = 53;
					continue;
				case 23:
					flag = y.SelectedIndex <= 0;
					num = 98;
					continue;
				case 98:
					if (!flag)
					{
						num = 42;
						continue;
					}
					goto case 18;
				case 45:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 10;
					continue;
				case 120:
					text += " and ";
					num = 27;
					continue;
				case 90:
					text = text + " tYear_Student.dakhle=" + af.SelectedValue.ToString();
					num = 161;
					continue;
				case 42:
					flag = !(text != "");
					num = 119;
					continue;
				case 119:
					if (!flag)
					{
						num = 100;
						continue;
					}
					goto case 34;
				case 72:
					text += " and ";
					num = 142;
					continue;
				case 38:
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 121;
						continue;
					}
					goto case 50;
				case 18:
					flag = ad.SelectedIndex <= 0;
					num = 116;
					continue;
				case 116:
					if (!flag)
					{
						num = 140;
						continue;
					}
					goto case 112;
				case 47:
					flag = !(text != "");
					num = 132;
					continue;
				case 132:
					if (!flag)
					{
						num = 102;
						continue;
					}
					goto case 74;
				case 161:
					flag = ax.SelectedIndex <= 0;
					num = 57;
					continue;
				case 57:
					if (!flag)
					{
						num = 160;
						continue;
					}
					goto case 37;
				case 149:
					flag = !(text != "");
					num = 77;
					continue;
				case 77:
					if (!flag)
					{
						num = 54;
						continue;
					}
					goto case 153;
				case 15:
					text += " and ";
					num = 158;
					continue;
				case 54:
					text += " and ";
					num = 153;
					continue;
				case 32:
					text += " and ";
					num = 16;
					continue;
				case 140:
					flag = !(text != "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 124;
						continue;
					}
					goto case 52;
				case 1:
					text = text + " tYear_Student.uniform=" + ag.SelectedValue.ToString();
					num = 127;
					continue;
				case 87:
					text += " and ";
					num = 99;
					continue;
				case 66:
					flag = !(text != "");
					num = 62;
					continue;
				case 62:
					if (!flag)
					{
						num = 125;
						continue;
					}
					goto case 156;
				case 4:
					flag = !(text != "");
					num = 135;
					continue;
				case 135:
					if (!flag)
					{
						num = 159;
						continue;
					}
					goto case 86;
				case 113:
					flag = !(a5.Text.Trim() != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 71;
						continue;
					}
					goto case 60;
				case 152:
					flag = ag.SelectedIndex <= 0;
					num = 70;
					continue;
				case 70:
					if (!flag)
					{
						num = 115;
						continue;
					}
					goto case 127;
				case 20:
					text += " and ";
					num = 75;
					continue;
				case 130:
					text = text + " tYear_Student.maghnae=" + av.SelectedValue.ToString();
					num = 79;
					continue;
				case 75:
					text = text + " tYear_Student.mali=" + aw.SelectedValue.ToString();
					num = 162;
					continue;
				case 125:
					text += " and ";
					num = 156;
					continue;
				case 59:
					flag = a7.SelectedIndex <= 0;
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 73;
				case 12:
					text = text + " tYear_Student.robotic=" + at.SelectedValue.ToString();
					num = 68;
					continue;
				case 79:
					flag = aw.SelectedIndex <= 0;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 138;
						continue;
					}
					goto case 162;
				case 102:
					text += " and ";
					num = 74;
					continue;
				case 60:
					flag = !(bc.Text.Trim() != "");
					num = 64;
					continue;
				case 64:
					if (!flag)
					{
						num = 122;
						continue;
					}
					goto case 0;
				case 155:
					text += " and ";
					num = 1;
					continue;
				case 52:
					text = text + " tYear_Student.xDriver=" + ad.SelectedValue.ToString();
					num = 112;
					continue;
				case 65:
					flag = r.SelectedIndex <= 0;
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 38;
						continue;
					}
					goto case 139;
				case 139:
					flag = this.m_o.SelectedIndex <= 0;
					num = 118;
					continue;
				case 118:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 23;
				case 131:
					flag = !(text != "");
					num = 123;
					continue;
				case 123:
					if (!flag)
					{
						num = 96;
						continue;
					}
					goto case 19;
				case 159:
					text += " and ";
					num = 86;
					continue;
				case 99:
					text = text + " tYear_Student.komakdarsi=" + ao.SelectedValue.ToString();
					num = 61;
					continue;
				case 163:
					text = text + " tstudent.LName like '%" + asdaj.b(this.m_k.Text) + "%'";
					num = 43;
					continue;
				case 11:
					flag = !(text != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 84;
						continue;
					}
					goto case 163;
				case 103:
					text += " and ";
					num = 69;
					continue;
				case 148:
					flag = ao.SelectedIndex <= 0;
					num = 83;
					continue;
				case 83:
					if (!flag)
					{
						num = 76;
						continue;
					}
					goto case 61;
				case 108:
					flag = am.SelectedIndex <= 0;
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 66;
						continue;
					}
					goto case 152;
				case 122:
					flag = !(text != "");
					num = 141;
					continue;
				case 141:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 85;
				case 106:
					text += " and ";
					num = 45;
					continue;
				case 96:
					text += " and ";
					num = 19;
					continue;
				case 82:
					flag = !(this.m_l.Text.Trim() != "");
					num = 150;
					continue;
				case 150:
					if (!flag)
					{
						num = 105;
						continue;
					}
					goto case 40;
				case 68:
					flag = au.SelectedIndex <= 0;
					num = 67;
					continue;
				case 67:
					if (!flag)
					{
						num = 154;
						continue;
					}
					goto case 108;
				case 21:
					flag = !(text != "");
					num = 56;
					continue;
				case 56:
					if (!flag)
					{
						num = 147;
						continue;
					}
					goto case 12;
				case 109:
					text += " and ";
					num = 91;
					continue;
				case 93:
					text = text + " tYear_Student.shaghe=" + au.SelectedValue.ToString();
					num = 108;
					continue;
				case 34:
					text = text + " tstudent.Mazhab=" + y.SelectedValue.ToString();
					num = 18;
					continue;
				case 27:
					text = text + " tstudent.xCityNow=" + a9.SelectedValue.ToString();
					num = 59;
					continue;
				case 101:
					flag = !(text != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 158;
				case 43:
					flag = !(a2.Text.Trim() != "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 101;
						continue;
					}
					goto case 113;
				case 129:
					flag = !(text != "");
					num = 110;
					continue;
				case 110:
					if (!flag)
					{
						num = 109;
						continue;
					}
					goto case 91;
				case 44:
					flag = !(text != "");
					num = 107;
					continue;
				case 107:
					if (!flag)
					{
						num = 36;
						continue;
					}
					goto case 14;
				case 0:
					flag = !(x.Text.Trim() != "");
					num = 136;
					continue;
				case 136:
					if (!flag)
					{
						num = 149;
						continue;
					}
					goto case 53;
				case 127:
					flag = bd.SelectedIndex <= 0;
					num = 58;
					continue;
				case 58:
					if (!flag)
					{
						num = 47;
						continue;
					}
					goto case 82;
				case 53:
					flag = !(v.Text.Trim() != "");
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 81;
						continue;
					}
					goto case 22;
				case 51:
					text += " and ";
					num = 95;
					continue;
				case 134:
					text += " and ";
					num = 130;
					continue;
				case 22:
					flag = a9.SelectedIndex <= 0;
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 151;
						continue;
					}
					goto case 59;
				case 69:
					text = text + " tstudent.FName like '%" + asdaj.b(this.m_l.Text) + "%'";
					num = 40;
					continue;
				case 14:
					text = text + " tCity_1.xOstan=" + a7.SelectedValue.ToString();
					num = 73;
					continue;
				case 105:
					flag = !(text != "");
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 103;
						continue;
					}
					goto case 69;
				case 55:
					text += " and ";
					num = 93;
					continue;
				case 71:
					flag = !(text != "");
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 72;
						continue;
					}
					goto case 142;
				case 36:
					text += " and ";
					num = 14;
					continue;
				case 114:
					text = " where " + text;
					num = 29;
					continue;
				case 19:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 65;
					continue;
				case 50:
					text = text + " tYear_Student.Status=" + r.SelectedValue.ToString();
					num = 139;
					continue;
				case 162:
					flag = at.SelectedIndex <= 0;
					num = 165;
					continue;
				case 165:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 68;
				case 29:
					result = text;
					num = 117;
					continue;
				case 49:
					text += " and ";
					num = 111;
					continue;
				case 121:
					text += " and ";
					num = 50;
					continue;
				case 37:
					flag = an.SelectedIndex <= 0;
					num = 89;
					continue;
				case 89:
					if (!flag)
					{
						num = 129;
						continue;
					}
					goto case 148;
				case 117:
					return result;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		e();
	}

	private void i(object A_0, EventArgs A_1)
	{
		e();
	}

	private void h(object A_0, EventArgs A_1)
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
					num = ((this.m_b.RowCount <= 0) ? 1 : 8);
					continue;
				case 8:
					num = 9;
					continue;
				case 9:
					if (true)
					{
					}
					num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_009c;
				case 1:
					num2 = 1;
					goto IL_009c;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 5:
				{
					asdaj.h = false;
					string text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdat asdat2 = new asdat();
					asdat2.__field_a = text;
					asdat2.ShowDialog();
					flag = !asdaj.h;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 0:
					num = 6;
					continue;
				case 6:
					return;
				case 2:
					{
						d();
						num = 0;
						continue;
					}
					IL_009c:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string a_ = "SELECT    tStudent.code as [کد متعلم],     tStudent.FName as [نام], tStudent.LastName AS تخلص,  tStudent.LName as [ولد/بنت], tStudent.PName as [ولدیت], tStudent.En_Fname AS [نام انگلسی], tStudent.En_LastName AS [تخلص انگلیسی], tStudent.En_Lname AS [نام پدر انگلیسی], tStudent.Sh_Sh as [نمبر تذکره], tStudent.bDate as [تاریخ تولد شمسی],  tStudent.bDateM as [تاریخ تولد میلادی], \r\n                      tStudent.MobileMother as [شماره مادر], tStudent.MobileFather as [شماره پدر],tStudent.NumberTelegram as [نمبر تلگرام] , tPaye.Name  as [پایه],  tClass.name  as [صنف],\r\n                       tStudent.NumberAsas as [نمبر اساس] , tStudent.RegDate  as [تاریخ شمولیت],tYear_Student.codeTakhfif as [کد تخفیف],  tOstan.Name AS [ولایت سکونت اصلی], tCity.Name AS [ولسوالی سکونت اصلی], tOstan_1.Name AS [ولایت سکونت فعلی], tCity_1.Name  as [ولسوالی سکونت فعلی], tStudent.Adress AS [آدرس سکونت],  tYear_Student.sort  as [ترتیب], tYear_Student.SumFee  as [مجموع فیس], tYear_Student.Sumtransport  as [مجموع ترانسپورت], tDriver.name  as [راننده], tTakhfif.name  as [تخفیف] ,\r\ncase tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک' when 4 then N'معذرتی' end  as [وضعیت]\r\n,case tStudent.Jens when 1 then N'مرد' when 0 then N'زن' else '' end  as [جنسیت]\r\n,case tStudent.Mazhab when 1 then N'شیعه' when 0 then N'سنی' else '' end  as [مذهب],tmpMark1.markDoreh as [اوسط چهار و نیم ماهه], tYear_Student.shaghe  as [شقه], tYear_Student.hazer  as [حاضر در صنف], \r\n                      tYear_Student.mali  as [لیست مالی], tYear_Student.dakhle  as [داخله], tYear_Student.uniform  as [یونیفرم], tYear_Student.komakdarsi  as [کمک درسی], tYear_Student.ketab  as [کتاب], tYear_Student.transport  as [ترانسپورت], tYear_Student.robotic  as [رباتیک], \r\n                      tYear_Student.maghnae  as [مقنعه],tYear_Student.MarkTerm3_From100 as [ورود نمره سالانه از 100]\r\nFROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN\r\n                      tDriver ON tYear_Student.xDriver = tDriver.id LEFT OUTER JOIN\r\n                      tTakhfif ON tYear_Student.xTakhfif = tTakhfif.id  LEFT OUTER JOIN\r\n                      tCity ON tStudent.xCity = tCity.id LEFT OUTER JOIN\r\n                      tOstan ON tCity.xOstan = tOstan.id LEFT OUTER JOIN\r\n                      tCity tCity_1 ON tStudent.xCityNow = tCity_1.id LEFT OUTER JOIN\r\n                      tOstan tOstan_1 ON tCity_1.xOstan = tOstan_1.id LEFT OUTER JOIN\r\n(SELECT     ROUND(tMarkDoreh.MarkDoreh, 2) AS markDoreh, tMarkDoreh.xStudent\r\nFROM         tMarkDoreh INNER JOIN\r\n                      tExam ON tMarkDoreh.Xtest = tExam.id\r\nWHERE     (tExam.term = 1) AND (tExam.xYear = " + asdaj.__field_a + ") AND (tMarkDoreh.typ = 5))tmpMark1 on tStudent.id=tmpMark1.xStudent" + a();
			asdbe asdbe2 = new asdbe(a_, asdab.e());
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel Spreadsheets (*.xls)|*.xls";
			saveFileDialog.DefaultExt = "xls";
			bool flag = saveFileDialog.ShowDialog() != DialogResult.OK;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
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
					asdbe2.b(saveFileDialog.FileName);
					MessageBox.Show("پایان");
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		i();
		e();
	}

	private void e(object A_0, EventArgs A_1)
	{
		e();
	}

	private void d(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				if (true)
				{
				}
				int num2;
				switch (num)
				{
				case 5:
					num = ((this.m_b.RowCount <= 0) ? 6 : 3);
					continue;
				case 3:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_00d8;
				case 2:
				{
					string text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asda4 asda10 = new asda4();
					asda10.__field_a = text;
					asda10.ShowDialog();
					num = 4;
					continue;
				}
				case 4:
					return;
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 6:
					{
						num2 = 1;
						goto IL_00d8;
					}
					IL_00d8:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Refresh();
		d();
	}

	private void b(object A_0, EventArgs A_1)
	{
		bi.Stop();
		e();
	}

	private void a(object A_0, EventArgs A_1)
	{
		bi.Stop();
		bi.Start();
	}
}
