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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0977: Expected Obj, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acd: Expected Obj, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected Obj, but got Unknown
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected Obj, but got Unknown
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected Obj, but got Unknown
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected Obj, but got Unknown
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got Unknown
		//IL_0d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Expected Obj, but got Unknown
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected Obj, but got Unknown
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got Unknown
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Expected Obj, but got Unknown
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected Obj, but got Unknown
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3: Expected Obj, but got Unknown
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Expected Obj, but got Unknown
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Expected Obj, but got Unknown
		//IL_1589: Unknown result type (might be due to invalid IL or missing references)
		//IL_1593: Expected Obj, but got Unknown
		//IL_1613: Unknown result type (might be due to invalid IL or missing references)
		//IL_161d: Expected Obj, but got Unknown
		//IL_1631: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Expected Obj, but got Unknown
		//IL_16c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d0: Expected Obj, but got Unknown
		//IL_178c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1796: Expected Obj, but got Unknown
		//IL_17aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Expected Obj, but got Unknown
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_190b: Expected Obj, but got Unknown
		//IL_191f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1929: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdf));
		StringFormat val = new StringFormat();
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		GridEXLayout val4 = new GridEXLayout();
		GridEXLayout val5 = new GridEXLayout();
		StringFormat val6 = new StringFormat();
		StringFormat val7 = new StringFormat();
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
		((Control)this.m_b).SuspendLayout();
		((ISupportInitialize)this.m_p).BeginInit();
		((Control)this.m_p).SuspendLayout();
		((ISupportInitialize)this.m_q).BeginInit();
		((ISupportInitialize)this.m_c).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)this.m_n).BeginInit();
		((Control)this.m_m).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)ae);
		((Control)this.m_b).Controls.Add((Control)(object)ad);
		((Control)this.m_b).Controls.Add((Control)(object)ab);
		((Control)this.m_b).Controls.Add((Control)(object)z);
		((Control)this.m_b).Controls.Add((Control)(object)aa);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_p);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(5, 5);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(790, 589);
		((Control)this.m_b).TabIndex = 0;
		((Control)ae).Anchor = (AnchorStyles)6;
		((Control)ae).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		ae.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		ae.ImageSize = new Size(40, 40);
		((Control)ae).Location = new Point(11, 551);
		((Control)ae).Name = "btnClose";
		((Control)ae).Size = new Size(125, 33);
		((Control)ae).TabIndex = 140;
		((Control)ae).Text = "بستن";
		((Control)ae).Click += b;
		((Control)ad).Anchor = (AnchorStyles)9;
		((Control)ad).Font = new Font("Tahoma", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ad).ForeColor = Color.FromArgb(128, 64, 64);
		((Control)ad).Location = new Point(324, 6);
		((Control)ad).Name = "label7";
		((Control)ad).Size = new Size(161, 79);
		((Control)ad).TabIndex = 139;
		((Control)ad).Text = "اختصاص راننده به شاگرد";
		ad.TextAlign = (ContentAlignment)32;
		((Control)ab).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		ab.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		ab.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		ab.ImageIndex = 8;
		ab.ImageSize = new Size(30, 30);
		((Control)ab).Location = new Point(325, 300);
		((Control)ab).Name = "btnNext";
		((Control)ab).RightToLeft = (RightToLeft)1;
		((Control)ab).Size = new Size(152, 38);
		((Control)ab).TabIndex = 137;
		((Control)ab).Tag = "";
		((Control)ab).Text = "ثبت موارد انتخاب شده";
		ab.ToolTipText = "دکمه میانبر : PageDown";
		ab.VisualStyle = (VisualStyle)1;
		((Control)ab).Click += d;
		((Control)z).AutoSize = true;
		((Control)z).Location = new Point(437, 243);
		((Control)z).Name = "label41";
		((Control)z).Size = new Size(32, 13);
		((Control)z).TabIndex = 136;
		((Control)z).Text = "راننده";
		((Control)aa).Anchor = (AnchorStyles)9;
		((Control)aa).Location = new Point(324, 264);
		((Control)aa).Name = "dropDriver";
		((Control)aa).Size = new Size(150, 21);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)aa).StringFormat = val;
		((Control)aa).TabIndex = 135;
		aa.SelectedIndexChanged += a;
		((Control)this.m_p).Anchor = (AnchorStyles)13;
		((Control)this.m_p).Controls.Add((Control)(object)r);
		((Control)this.m_p).Controls.Add((Control)(object)s);
		((Control)this.m_p).Controls.Add((Control)(object)ac);
		((Control)this.m_p).Controls.Add((Control)(object)t);
		((Control)this.m_p).Controls.Add((Control)(object)u);
		((Control)this.m_p).Controls.Add((Control)(object)v);
		((Control)this.m_p).Controls.Add((Control)(object)w);
		((Control)this.m_p).Controls.Add((Control)(object)x);
		((Control)this.m_p).Controls.Add((Control)(object)y);
		((Control)this.m_p).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_p).Location = new Point(10, 4);
		((Control)this.m_p).Name = "uiGroupBox2";
		((Control)this.m_p).Size = new Size(308, 542);
		((Control)this.m_p).TabIndex = 1;
		((Control)this.m_p).Text = "لیست دانش آموزان دارای راننده";
		((Control)r).Anchor = (AnchorStyles)9;
		((Control)r).AutoSize = true;
		((Control)r).Location = new Point(236, 132);
		((Control)r).Name = "label1";
		((Control)r).Size = new Size(48, 13);
		((Control)r).TabIndex = 38;
		((Control)r).Text = "ولد / بنت";
		((Control)s).Anchor = (AnchorStyles)9;
		((Control)s).AutoSize = true;
		((Control)s).Location = new Point(241, 99);
		((Control)s).Name = "label2";
		((Control)s).Size = new Size(20, 13);
		((Control)s).TabIndex = 37;
		((Control)s).Text = "نام";
		((Control)ac).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		ac.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		ac.ImageIndex = 8;
		ac.ImageSize = new Size(30, 30);
		((Control)ac).Location = new Point(13, 488);
		((Control)ac).Name = "btnPrevious";
		((Control)ac).RightToLeft = (RightToLeft)1;
		((Control)ac).Size = new Size(289, 38);
		((Control)ac).TabIndex = 138;
		((Control)ac).Text = "برگشت مورد انتخاب شده به لیست بدون راننده";
		ac.ToolTipText = "دکمه میانبر : PageUp";
		ac.VisualStyle = (VisualStyle)1;
		((Control)ac).Click += c;
		((Control)t).Anchor = (AnchorStyles)9;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((EditBase)t).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)t).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)t).Location = new Point(29, 125);
		((Control)t).Name = "txtLName2";
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(201, 24);
		((Control)t).TabIndex = 33;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((Control)t).Leave += e;
		((Control)t).KeyUp += a;
		((Control)t).Enter += g;
		((Control)u).Anchor = (AnchorStyles)9;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((EditBase)u).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)u).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)u).Location = new Point(29, 93);
		((Control)u).Name = "txtFName2";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(201, 24);
		((Control)u).TabIndex = 34;
		((EditBase)u).TextAlignment = (TextAlignment)1;
		((Control)u).Leave += f;
		((Control)u).KeyUp += b;
		((Control)u).Enter += h;
		((Control)v).Anchor = (AnchorStyles)9;
		((Control)v).AutoSize = true;
		((Control)v).Location = new Point(236, 67);
		((Control)v).Name = "label3";
		((Control)v).Size = new Size(30, 13);
		((Control)v).TabIndex = 36;
		((Control)v).Text = "صنف";
		((Control)w).Anchor = (AnchorStyles)9;
		((UIComboBase)w).ComboStyle = (ComboStyle)1;
		((UIComboBase)w).DropListFont = new Font("Tahoma", 8.25f);
		((Control)w).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)w).Location = new Point(29, 63);
		((Control)w).Name = "dropCls2";
		((Control)w).Size = new Size(201, 23);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)w).StringFormat = val2;
		((Control)w).TabIndex = 32;
		w.SelectedIndexChanged += i;
		((Control)x).Anchor = (AnchorStyles)9;
		((Control)x).AutoSize = true;
		((Control)x).Location = new Point(236, 33);
		((Control)x).Name = "label6";
		((Control)x).Size = new Size(22, 13);
		((Control)x).TabIndex = 35;
		((Control)x).Text = "پایه";
		((Control)y).Anchor = (AnchorStyles)9;
		((UIComboBase)y).ComboStyle = (ComboStyle)1;
		((UIComboBase)y).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)y).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)y).Location = new Point(29, 28);
		((Control)y).Name = "dropPaye2";
		((Control)y).Size = new Size(201, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)y).StringFormat = val3;
		((Control)y).TabIndex = 31;
		y.SelectedIndexChanged += j;
		this.m_q.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_q).Anchor = (AnchorStyles)11;
		this.m_q.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		val4.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_q.DesignTimeLayout = val4;
		this.m_q.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_q).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_q).Location = new Point(5, 164);
		((Control)this.m_q).Name = "gridEX2";
		((ScrollableBase)this.m_q).RecordNavigator = true;
		this.m_q.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_q).Size = new Size(297, 305);
		((Control)this.m_q).TabIndex = 30;
		((ScrollableBase)this.m_q).VisualStyle = (VisualStyle)2;
		((Control)this.m_c).Anchor = (AnchorStyles)13;
		((Control)this.m_c).Controls.Add((Control)(object)af);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Location = new Point(491, 6);
		((Control)this.m_c).Name = "uiGroupBox1";
		((Control)this.m_c).Size = new Size(289, 578);
		((Control)this.m_c).TabIndex = 0;
		((Control)this.m_c).Text = "لیست دانش آموزان بدون راننده";
		((Control)this.m_o).Anchor = (AnchorStyles)9;
		((Control)this.m_o).AutoSize = true;
		((Control)this.m_o).Location = new Point(218, 29);
		((Control)this.m_o).Name = "label10";
		((Control)this.m_o).Size = new Size(66, 13);
		((Control)this.m_o).TabIndex = 135;
		((Control)this.m_o).Text = "سال تعلیمی";
		((Control)this.m_n).Anchor = (AnchorStyles)11;
		val5.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_n.DesignTimeLayout = val5;
		this.m_n.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_n).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_n.GroupByBoxVisible = false;
		((Control)this.m_n).Location = new Point(8, 186);
		((Control)this.m_n).Name = "gridEX1";
		((ScrollableBase)this.m_n).RecordNavigator = true;
		this.m_n.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_n).Size = new Size(273, 384);
		((Control)this.m_n).TabIndex = 30;
		((ScrollableBase)this.m_n).VisualStyle = (VisualStyle)2;
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((Control)this.m_h).AutoSize = true;
		((Control)this.m_h).Location = new Point(216, 160);
		((Control)this.m_h).Name = "label5";
		((Control)this.m_h).Size = new Size(48, 13);
		((Control)this.m_h).TabIndex = 29;
		((Control)this.m_h).Text = "ولد / بنت";
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(221, 127);
		((Control)this.m_i).Name = "label4";
		((Control)this.m_i).Size = new Size(20, 13);
		((Control)this.m_i).TabIndex = 28;
		((Control)this.m_i).Text = "نام";
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((EditBase)this.m_j).AutoScroll = false;
		((EditBase)this.m_j).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_j).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_j).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_j).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_j).Location = new Point(9, 153);
		((Control)this.m_j).Name = "txtLName";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(201, 24);
		((Control)this.m_j).TabIndex = 2;
		((EditBase)this.m_j).TextAlignment = (TextAlignment)1;
		((Control)this.m_j).Leave += n;
		((Control)this.m_j).KeyUp += c;
		((Control)this.m_j).Enter += m;
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((EditBase)this.m_k).AutoScroll = false;
		((EditBase)this.m_k).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_k).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_k).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_k).Location = new Point(9, 121);
		((Control)this.m_k).Name = "txtFName";
		((Control)this.m_k).RightToLeft = (RightToLeft)1;
		((Control)this.m_k).Size = new Size(201, 24);
		((Control)this.m_k).TabIndex = 3;
		((EditBase)this.m_k).TextAlignment = (TextAlignment)1;
		((Control)this.m_k).Leave += k;
		((Control)this.m_k).KeyUp += c;
		((Control)this.m_k).Enter += l;
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Location = new Point(216, 95);
		((Control)this.m_f).Name = "label19";
		((Control)this.m_f).Size = new Size(30, 13);
		((Control)this.m_f).TabIndex = 25;
		((Control)this.m_f).Text = "صنف";
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_g).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_g).DropListFont = new Font("Tahoma", 8.25f);
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_g).Location = new Point(9, 91);
		((Control)this.m_g).Name = "dropCls";
		((Control)this.m_g).Size = new Size(201, 23);
		val6.Alignment = (StringAlignment)0;
		val6.FormatFlags = (StringFormatFlags)20485;
		val6.HotkeyPrefix = (HotkeyPrefix)0;
		val6.LineAlignment = (StringAlignment)1;
		val6.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_g).StringFormat = val6;
		((Control)this.m_g).TabIndex = 1;
		this.m_g.SelectedIndexChanged += o;
		((Control)this.m_d).Anchor = (AnchorStyles)9;
		((Control)this.m_d).AutoSize = true;
		((Control)this.m_d).Location = new Point(216, 61);
		((Control)this.m_d).Name = "label20";
		((Control)this.m_d).Size = new Size(22, 13);
		((Control)this.m_d).TabIndex = 15;
		((Control)this.m_d).Text = "پایه";
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_e).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_e).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_e).Location = new Point(9, 56);
		((Control)this.m_e).Name = "dropPaye";
		((Control)this.m_e).Size = new Size(201, 23);
		val7.Alignment = (StringAlignment)0;
		val7.FormatFlags = (StringFormatFlags)20485;
		val7.HotkeyPrefix = (HotkeyPrefix)0;
		val7.LineAlignment = (StringAlignment)1;
		val7.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_e).StringFormat = val7;
		((Control)this.m_e).TabIndex = 0;
		this.m_e.SelectedIndexChanged += p;
		((FileDialog)this.m_l).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_l).Title = "انتخاب عکس شاگرد";
		((Control)this.m_m).BackColor = Color.Black;
		((Control)this.m_m).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_m).Dock = (DockStyle)5;
		((Control)this.m_m).Location = new Point(0, 0);
		((Control)this.m_m).Name = "panel2";
		((Control)this.m_m).Size = new Size(800, 600);
		((Control)this.m_m).TabIndex = 1;
		af.BorderStyle = (BorderStyle)1;
		((Control)af).Location = new Point(142, 25);
		((Control)af).Name = "lYear";
		((Control)af).Size = new Size(68, 24);
		((Control)af).TabIndex = 136;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 600);
		((Control)this).Controls.Add((Control)(object)this.m_m);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmDriverStd";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += q;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((ISupportInitialize)this.m_p).EndInit();
		((Control)this.m_p).ResumeLayout(false);
		((Control)this.m_p).PerformLayout();
		((ISupportInitialize)this.m_q).EndInit();
		((ISupportInitialize)this.m_c).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)this.m_n).EndInit();
		((Control)this.m_m).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdf()
	{
		g();
	}

	private void q(object A_0, EventArgs A_1)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)af).Text = asdaj.a;
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + ((Control)af).Text + text);
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
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + ((Control)af).Text + text);
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
			string text = " tYear_Student.transport=1 and xDriver=0 and tYear_Student.xyear=" + ((Control)af).Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
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
					flag = !(((Control)this.m_j).Text.Trim() != "");
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
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)this.m_j).Text) + "%'";
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
					flag = !(((Control)this.m_k).Text.Trim() != "");
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
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)this.m_k).Text) + "%'";
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
			string text = " tYear_Student.transport=1 and xDriver>0 and tYear_Student.xyear=" + ((Control)af).Text + " and tYear_Student.xPaye in(" + asdaj.n + ")";
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
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)u).Text) + "%'";
					num = 28;
					continue;
				case 27:
					flag = !(((Control)this.m_k).Text.Trim() != "");
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
					flag = !(((Control)this.m_j).Text.Trim() != "");
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
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)t).Text) + "%'";
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
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			string text = ((object)A_1.KeyCode).ToString();
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if ((int)A_1.KeyCode != 116)
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
					num2 = (((int)A_1.KeyCode != 112) ? 1 : 0);
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
		((EditBase)this.m_j).BackColor = Color.White;
	}

	private void m(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_j).BackColor = Color.Yellow;
	}

	private void l(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_k).BackColor = Color.Yellow;
	}

	private void k(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_k).BackColor = Color.White;
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
		((EditBase)u).BackColor = Color.Yellow;
	}

	private void g(object A_0, EventArgs A_1)
	{
		((EditBase)t).BackColor = Color.Yellow;
	}

	private void f(object A_0, EventArgs A_1)
	{
		((EditBase)u).BackColor = Color.White;
	}

	private void e(object A_0, EventArgs A_1)
	{
		((EditBase)t).BackColor = Color.White;
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
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
					((UIComboBase)aa).Focus();
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
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
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
						num2 = (((int)MessageBox.Show("آيا مطمئن هستيد؟", "", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6) ? 1 : 0);
						goto IL_0131;
					case 2:
						asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set xDriver=0 where id=" + this.m_q.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						c();
						b();
						num = 1;
						continue;
					case 9:
						if ((int)this.m_q.SelectedItems[0].RowType == 0)
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
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
	}
}
