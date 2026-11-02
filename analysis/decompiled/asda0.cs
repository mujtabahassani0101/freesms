using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected Obj, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected Obj, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected Obj, but got Unknown
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected Obj, but got Unknown
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Expected Obj, but got Unknown
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Expected Obj, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected Obj, but got Unknown
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected Obj, but got Unknown
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Expected Obj, but got Unknown
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Expected Obj, but got Unknown
		//IL_11f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Expected Obj, but got Unknown
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Expected Obj, but got Unknown
		//IL_14e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ed: Expected Obj, but got Unknown
		//IL_1573: Unknown result type (might be due to invalid IL or missing references)
		//IL_157d: Expected Obj, but got Unknown
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_1623: Expected Obj, but got Unknown
		//IL_1637: Unknown result type (might be due to invalid IL or missing references)
		//IL_1641: Expected Obj, but got Unknown
		//IL_18aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b4: Expected Obj, but got Unknown
		//IL_1963: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Expected Obj, but got Unknown
		//IL_1c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c39: Expected Obj, but got Unknown
		//IL_1c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9f: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda0));
		GridEXLayout val2 = new GridEXLayout();
		GridEXLayout val3 = new GridEXLayout();
		StringFormat val4 = new StringFormat();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		UIComboBoxItem val10 = new UIComboBoxItem();
		StringFormat val11 = new StringFormat();
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
		((Control)w).SuspendLayout();
		((Control)x).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(199, 34);
		((Control)this.m_b).Name = "gridEX1";
		((Control)this.m_b).RightToLeft = (RightToLeft)1;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(564, 356);
		((Control)this.m_b).TabIndex = 0;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		this.m_b.SelectionChanged += g;
		((Control)this.m_c).Anchor = (AnchorStyles)10;
		((Control)this.m_c).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(158, 576);
		((Control)this.m_c).Name = "btnview";
		((Control)this.m_c).Size = new Size(122, 34);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "نمایش گزارش";
		((Control)this.m_c).Click += l;
		((Control)this.m_d).Anchor = (AnchorStyles)6;
		((Control)this.m_d).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		((Control)this.m_d).Location = new Point(18, 576);
		((Control)this.m_d).Name = "btnClose";
		((Control)this.m_d).Size = new Size(134, 34);
		((Control)this.m_d).TabIndex = 110;
		((Control)this.m_d).Text = "بستن";
		((Control)this.m_d).Click += k;
		((Control)this.m_e).Anchor = (AnchorStyles)10;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_e.DesignTimeLayout = val2;
		this.m_e.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_e.GroupByBoxVisible = false;
		((Control)this.m_e).Location = new Point(1, 220);
		((Control)this.m_e).Name = "gClass";
		this.m_e.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_e).Size = new Size(193, 170);
		((Control)this.m_e).TabIndex = 107;
		((ScrollableBase)this.m_e).VisualStyle = (VisualStyle)2;
		((Control)this.m_e).Click += b;
		this.m_e.SelectionChanged += d;
		((Control)this.m_f).Anchor = (AnchorStyles)15;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_f.DesignTimeLayout = val3;
		this.m_f.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_f.GroupByBoxVisible = false;
		((Control)this.m_f).Location = new Point(1, 34);
		((Control)this.m_f).Name = "gExam";
		this.m_f.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_f).Size = new Size(193, 160);
		((Control)this.m_f).TabIndex = 111;
		((ScrollableBase)this.m_f).VisualStyle = (VisualStyle)2;
		((Control)this.m_f).Click += c;
		this.m_f.SelectionChanged += e;
		((EditBase)this.m_g).AutoScroll = false;
		((EditBase)this.m_g).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_g).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_g).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(414, 504);
		((EditBase)this.m_g).MaxLength = 300;
		((Control)this.m_g).Name = "txtSch";
		((Control)this.m_g).Size = new Size(263, 23);
		((Control)this.m_g).TabIndex = 112;
		((EditBase)this.m_g).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_h).AutoScroll = false;
		((EditBase)this.m_h).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_h).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_h).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(414, 539);
		((EditBase)this.m_h).MaxLength = 300;
		((Control)this.m_h).Name = "txtFoter1";
		((Control)this.m_h).Size = new Size(263, 23);
		((Control)this.m_h).TabIndex = 113;
		((EditBase)this.m_h).TextAlignment = (TextAlignment)1;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(680, 505);
		((Control)this.m_i).Name = "label1";
		((Control)this.m_i).Size = new Size(57, 20);
		((Control)this.m_i).TabIndex = 114;
		((Control)this.m_i).Text = "نام مکتب :";
		((Control)this.m_j).AutoSize = true;
		((Control)this.m_j).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(681, 542);
		((Control)this.m_j).Name = "label2";
		((Control)this.m_j).Size = new Size(50, 20);
		((Control)this.m_j).TabIndex = 115;
		((Control)this.m_j).Text = "نام مدیر :";
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_k).Location = new Point(681, 395);
		((Control)this.m_k).Name = "label3";
		((Control)this.m_k).Size = new Size(71, 20);
		((Control)this.m_k).TabIndex = 117;
		((Control)this.m_k).Text = "بالای گزارش :";
		((EditBase)this.m_l).AutoScroll = false;
		((EditBase)this.m_l).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_l).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Location = new Point(12, 394);
		((EditBase)this.m_l).MaxLength = 300;
		((Control)this.m_l).Name = "txtHeder1";
		((Control)this.m_l).Size = new Size(664, 23);
		((Control)this.m_l).TabIndex = 116;
		((EditBase)this.m_l).TextAlignment = (TextAlignment)1;
		((Control)this.m_m).AutoSize = true;
		((Control)this.m_m).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_m).Location = new Point(679, 473);
		((Control)this.m_m).Name = "label4";
		((Control)this.m_m).Size = new Size(56, 20);
		((Control)this.m_m).TabIndex = 119;
		((Control)this.m_m).Text = "پیام مدیر :";
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(12, 472);
		((EditBase)n).MaxLength = 300;
		((Control)n).Name = "txtHeder2";
		((Control)n).Size = new Size(664, 23);
		((Control)n).TabIndex = 118;
		((EditBase)n).TextAlignment = (TextAlignment)1;
		((Control)o).AutoSize = true;
		((Control)o).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(680, 447);
		((Control)o).Name = "label5";
		((Control)o).Size = new Size(86, 20);
		((Control)o).TabIndex = 121;
		((Control)o).Text = "پایین اطلاع نامه :";
		((EditBase)p).AutoScroll = false;
		((EditBase)p).AutoScrollMargin = new Size(0, 0);
		((EditBase)p).AutoScrollMinSize = new Size(0, 0);
		((EditBase)p).AutoScrollPosition = new Point(0, 0);
		((Control)p).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(12, 445);
		((EditBase)p).MaxLength = 300;
		((Control)p).Name = "txtFoter2";
		((Control)p).Size = new Size(664, 23);
		((Control)p).TabIndex = 120;
		((EditBase)p).TextAlignment = (TextAlignment)1;
		((Control)q).Anchor = (AnchorStyles)9;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(171, 200);
		((Control)q).Name = "label20";
		((Control)q).Size = new Size(22, 13);
		((Control)q).TabIndex = 123;
		((Control)q).Text = "پایه";
		((Control)r).Anchor = (AnchorStyles)9;
		((UIComboBase)r).ComboStyle = (ComboStyle)1;
		((UIComboBase)r).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)r).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)r).Location = new Point(1, 197);
		((Control)r).Name = "dropPaye";
		((Control)r).Size = new Size(164, 20);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)r).StringFormat = val4;
		((Control)r).TabIndex = 122;
		r.SelectedIndexChanged += j;
		s.Checked = true;
		s.CheckState = (CheckState)1;
		((Control)s).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)s).Location = new Point(10, 497);
		((Control)s).Name = "checkSp2";
		((Control)s).Size = new Size(399, 20);
		((Control)s).TabIndex = 125;
		((Control)s).Text = "فقط درس های دارای نمره را  در گزارش نمایش داده شود";
		((ButtonBase)s).UseVisualStyleBackColor = true;
		((Control)t).AutoSize = true;
		((Control)t).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)t).ForeColor = Color.Red;
		((Control)t).Location = new Point(103, 420);
		((Control)t).Name = "label6";
		((Control)t).Size = new Size(598, 20);
		((Control)t).TabIndex = 126;
		((Control)t).Text = "در صورتی که برای شاگرد در منوی توضیحات زیر اطلاع نامه توضیحی ثبت شده باشد به جای پایین اطلاع نامه نمایش داده خواهد شد";
		((Control)u).Anchor = (AnchorStyles)9;
		u.DropDownStyle = (ComboBoxStyle)2;
		((Control)u).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ListControl)u).FormattingEnabled = true;
		((Control)u).Location = new Point(483, 4);
		((Control)u).Name = "dropTypeRpt";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(228, 24);
		((Control)u).TabIndex = 127;
		((ListControl)u).SelectedValueChanged += i;
		((Control)v).AutoSize = true;
		((Control)v).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(717, 5);
		((Control)v).Name = "label7";
		((Control)v).Size = new Size(59, 20);
		((Control)v).TabIndex = 128;
		((Control)v).Text = "نوع گزارش";
		((Control)w).BackColor = Color.Gray;
		w.BorderStyle = (BorderStyle)1;
		((Control)w).Controls.Add((Control)(object)x);
		((Control)w).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(218, 142);
		((Control)w).Name = "pSort";
		((Control)w).Size = new Size(338, 204);
		((Control)w).TabIndex = 129;
		((Control)w).Visible = false;
		((Control)x).BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = (BorderStyle)2;
		((Control)x).Controls.Add((Control)(object)aa);
		((Control)x).Controls.Add((Control)(object)ab);
		((Control)x).Controls.Add((Control)(object)ac);
		((Control)x).Controls.Add((Control)(object)y);
		((Control)x).Controls.Add((Control)(object)z);
		((Control)x).Location = new Point(6, 7);
		((Control)x).Name = "panel1";
		((Control)x).Size = new Size(321, 186);
		((Control)x).TabIndex = 40;
		((Control)aa).AutoSize = true;
		((Control)aa).Location = new Point(126, 88);
		((Control)aa).Name = "radioButton2";
		((Control)aa).Size = new Size(108, 32);
		((Control)aa).TabIndex = 1;
		aa.TabStop = true;
		((Control)aa).Text = " ترتیب و الفبا";
		((ButtonBase)aa).UseVisualStyleBackColor = true;
		((Control)ab).AutoSize = true;
		((Control)ab).Location = new Point(132, 50);
		((Control)ab).Name = "radioButton1";
		((Control)ab).Size = new Size(102, 32);
		((Control)ab).TabIndex = 0;
		ab.TabStop = true;
		((Control)ab).Text = "بالاترین نمره";
		((ButtonBase)ab).UseVisualStyleBackColor = true;
		((Control)ac).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ac).Location = new Point(17, 10);
		((Control)ac).Name = "label9";
		((Control)ac).Size = new Size(255, 37);
		((Control)ac).TabIndex = 130;
		((Control)ac).Text = "ترتیب شاگردان در  گزارش بر اساس";
		y.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)y).Location = new Point(40, 132);
		((Control)y).Name = "btnCancel";
		((Control)y).Size = new Size(117, 38);
		((Control)y).TabIndex = 5;
		((Control)y).Text = "انصراف";
		((Control)y).Click += f;
		z.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)z).Location = new Point(163, 132);
		((Control)z).Name = "btnAcp";
		((Control)z).Size = new Size(104, 38);
		((Control)z).TabIndex = 4;
		((Control)z).Text = "تایید";
		((Control)z).Click += h;
		((UIComboBase)ad).ComboStyle = (ComboStyle)1;
		((UIComboBase)ad).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ad).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1403";
		val5.Value = "1403";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1402";
		val6.Value = "1402";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1401";
		val7.Value = "1401";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "1400";
		val8.Value = "1400";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "1399";
		val9.Value = "1399";
		val10.FormatStyle.Alpha = 0;
		val10.Text = "1398";
		val10.Value = "1398";
		ad.Items.AddRange(new UIComboBoxItem[6] { val5, val6, val7, val8, val9, val10 });
		((Control)ad).Location = new Point(10, 4);
		((Control)ad).Name = "dropYear";
		((Control)ad).Size = new Size(97, 23);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)ad).StringFormat = val11;
		((Control)ad).TabIndex = 130;
		ad.SelectedIndexChanged += a;
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(114, 10);
		((Control)ae).Name = "label8";
		((Control)ae).Size = new Size(66, 13);
		((Control)ae).TabIndex = 131;
		((Control)ae).Text = "سال تعلیمی";
		af.Checked = true;
		af.CheckState = (CheckState)1;
		((Control)af).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)af).ForeColor = Color.Navy;
		((Control)af).Location = new Point(126, 520);
		((Control)af).Name = "checkshowBartar";
		((Control)af).Size = new Size(283, 20);
		((Control)af).TabIndex = 132;
		((Control)af).Text = "نمایش نفرات برتر در اطلاع نامه";
		((ButtonBase)af).UseVisualStyleBackColor = true;
		ag.Checked = true;
		ag.CheckState = (CheckState)1;
		((Control)ag).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ag).ForeColor = Color.FromArgb(192, 0, 192);
		((Control)ag).Location = new Point(86, 546);
		((Control)ag).Name = "checkShowGread";
		((Control)ag).Size = new Size(323, 20);
		((Control)ag).TabIndex = 133;
		((Control)ag).Text = "نمایش رتبه کل و تعداد شاگرد در اطلاع نامه";
		((ButtonBase)ag).UseVisualStyleBackColor = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(784, 612);
		((Control)this).Controls.Add((Control)(object)ag);
		((Control)this).Controls.Add((Control)(object)af);
		((Control)this).Controls.Add((Control)(object)ae);
		((Control)this).Controls.Add((Control)(object)ad);
		((Control)this).Controls.Add((Control)(object)w);
		((Control)this).Controls.Add((Control)(object)v);
		((Control)this).Controls.Add((Control)(object)u);
		((Control)this).Controls.Add((Control)(object)t);
		((Control)this).Controls.Add((Control)(object)s);
		((Control)this).Controls.Add((Control)(object)q);
		((Control)this).Controls.Add((Control)(object)r);
		((Control)this).Controls.Add((Control)(object)o);
		((Control)this).Controls.Add((Control)(object)p);
		((Control)this).Controls.Add((Control)(object)this.m_m);
		((Control)this).Controls.Add((Control)(object)n);
		((Control)this).Controls.Add((Control)(object)this.m_k);
		((Control)this).Controls.Add((Control)(object)this.m_l);
		((Control)this).Controls.Add((Control)(object)this.m_j);
		((Control)this).Controls.Add((Control)(object)this.m_i);
		((Control)this).Controls.Add((Control)(object)this.m_h);
		((Control)this).Controls.Add((Control)(object)this.m_g);
		((Control)this).Controls.Add((Control)(object)this.m_f);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmRpt";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "گزارشات";
		((Form)this).Load += m;
		((Form)this).FormClosing += a;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)this.m_e).EndInit();
		((ISupportInitialize)this.m_f).EndInit();
		((Control)w).ResumeLayout(false);
		((Control)x).ResumeLayout(false);
		((Control)x).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public asda0()
	{
		f();
	}

	private void m(object A_0, EventArgs A_1)
	{
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)af).Tag = dataTable2.Rows[0]["showBartar"].ToString();
						ag.Checked = bool.Parse(dataTable2.Rows[0]["ShowGread"].ToString());
						((Control)ag).Tag = dataTable2.Rows[0]["ShowGread"].ToString();
					}
					catch
					{
					}
					num = 1;
					continue;
				case 9:
				{
					ad.SelectedValue = asdaj.a;
					ah = false;
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					dictionary.Add("0", "تمام گزارشات");
					dictionary.Add("1", "اطلاع نامه");
					dictionary.Add("4", "جدول نتایج");
					dictionary.Add("5", "خلص نتایج");
					dictionary.Add("2", "گزارشات لیستی");
					dictionary.Add("3", "گزارشات آماری و مقایسه ای");
					u.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)u).DisplayMember = "Value";
					((ListControl)u).ValueMember = "Key";
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
					((Control)this.m_h).Text = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)p).Text = dataTable2.Rows[0]["Foter2"].ToString();
					((Control)this.m_l).Text = dataTable2.Rows[0]["heder1"].ToString();
					((Control)n).Text = dataTable2.Rows[0]["heder2"].ToString();
					((Control)this.m_g).Text = dataTable2.Rows[0]["sch"].ToString();
					((Control)this.m_h).Tag = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)p).Tag = dataTable2.Rows[0]["Foter2"].ToString();
					((Control)this.m_l).Tag = dataTable2.Rows[0]["heder1"].ToString();
					((Control)n).Tag = dataTable2.Rows[0]["heder2"].ToString();
					((Control)this.m_g).Tag = dataTable2.Rows[0]["sch"].ToString();
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
						((Control)this).BackColor = Color.FromArgb(red, green, blue);
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
					text = text + " and type=" + ((ListControl)u).SelectedValue.ToString();
					num = 4;
					continue;
				case 3:
					flag = ((ListControl)u).SelectedIndex <= 0;
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
			((CollectionBase)(object)r.Items).Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ad.SelectedValue.ToString() + ") order by id");
			r.Items.Add("کل", (object)"0");
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
					r.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
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
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataSource2 = default;
		string a_3 = default;
		SqlParameter[] a_2 = default;
		ReportClass val = default;
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
					val = asdd.a(a_);
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
					((ReportDocument)val).Subreports[array[0].ToString()].SetDataSource(dataSource);
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
					array = text.Split(new char[1] { ',' });
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
					((ReportDocument)val).Subreports[array[4].ToString()].SetDataSource(dataSource);
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
							((ReportDocument)val).ParameterFields[0].CurrentValues.AddValue((object)((Control)this.m_g).Text);
							((ReportDocument)val).ParameterFields[1].CurrentValues.AddValue((object)((Control)this.m_l).Text);
							((ReportDocument)val).ParameterFields[2].CurrentValues.AddValue((object)((Control)n).Text);
							((ReportDocument)val).ParameterFields[3].CurrentValues.AddValue((object)((Control)this.m_h).Text);
							((ReportDocument)val).ParameterFields[4].CurrentValues.AddValue((object)((Control)p).Text);
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
									((ReportDocument)val).ParameterFields["showGread"].CurrentValues.AddValue((object)"0");
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
									((ReportDocument)val).ParameterFields["showBartar"].CurrentValues.AddValue((object)"1");
									num2 = 11;
									continue;
								case 7:
									((ReportDocument)val).ParameterFields["showGread"].CurrentValues.AddValue((object)"1");
									num2 = 5;
									continue;
								case 14:
									((ReportDocument)val).ParameterFields[5].CurrentValues.AddValue((object)ai);
									num2 = 8;
									continue;
								case 0:
									flag = !af.Checked;
									num2 = 13;
									continue;
								case 13:
									if (flag)
									{
										((ReportDocument)val).ParameterFields["showBartar"].CurrentValues.AddValue((object)"0");
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
					asda10.a = val;
					((Form)asda10).ShowDialog();
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
					((ReportDocument)val).Subreports[array[2].ToString()].SetDataSource(dataSource);
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
					((ReportDocument)val).SetDataSource(dataSource2);
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
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
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
					if (!(((Control)p).Text != ((Control)p).Tag.ToString()))
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
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)this.m_l).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)n).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)this.m_h).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)p).Text),
						asdcb.a("@sch", SqlDbType.NVarChar, ((Control)this.m_g).Text),
						asdcb.a("@showBartar", SqlDbType.Bit, af.Checked),
						asdcb.a("@showGread", SqlDbType.Bit, ag.Checked)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_2);
					num = 64;
					continue;
				}
				case 103:
					((Control)w).Visible = true;
					ab.Checked = false;
					aa.Checked = false;
					((Control)z).Focus();
					num = 25;
					continue;
				case 25:
					return;
				case 46:
					flag2 = ag.Checked;
					num = 14;
					continue;
				case 14:
					num5 = ((!(flag2.ToString() != ((Control)ag).Tag.ToString())) ? 1 : 0);
					goto IL_0e33;
				case 57:
					num = 94;
					continue;
				case 94:
					if (!(((Control)this.m_h).Text != ((Control)this.m_h).Tag.ToString()))
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
					if (!(((Control)this.m_g).Text != ((Control)this.m_g).Tag.ToString()))
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
					if (!(((Control)n).Text != ((Control)n).Tag.ToString()))
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
					if (!(flag2.ToString() != ((Control)af).Tag.ToString()))
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
					if (!(((Control)this.m_l).Text != ((Control)this.m_l).Tag.ToString()))
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
		((Form)this).Close();
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
					if (!(((Control)this.m_h).Text != ((Control)this.m_h).Tag.ToString()))
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
					num2 = ((!(((Control)this.m_g).Text != ((Control)this.m_g).Tag.ToString())) ? 1 : 0);
					goto IL_0205;
				case 10:
					num = 3;
					continue;
				case 3:
					if (!(((Control)this.m_l).Text != ((Control)this.m_l).Tag.ToString()))
					{
						num = 8;
						continue;
					}
					goto IL_0080;
				case 11:
				{
					SqlParameter[] a_ = new SqlParameter[5]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)this.m_l).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)n).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)this.m_h).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)p).Text),
						asdcb.a("@sch", SqlDbType.NVarChar, ((Control)this.m_g).Text)
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
					if (!(((Control)p).Text != ((Control)p).Tag.ToString()))
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
						if (!(((Control)n).Text != ((Control)n).Tag.ToString()))
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
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		while (true)
		{
			d();
			bool flag = ((ListControl)u).SelectedIndex != 0;
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
					((Control)this.m_b).Font = font2;
					num = 2;
					continue;
				}
				case 2:
					return;
				case 3:
				{
					Font font = new Font("b nazanin", 10f);
					((Control)this.m_b).Font = font;
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
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
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
		((Control)w).Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Control)w).Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Control)w).Visible = false;
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Control)w).Visible = false;
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)w).Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Control)w).Visible = false;
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
