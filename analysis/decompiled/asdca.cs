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

public class asdca : Form
{
	private Container m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Label m_d;

	private Panel m_e;

	private Label m_f;

	private UIComboBox m_g;

	private Label m_h;

	private EditBox m_i;

	private UIButton j;

	private Panel k;

	private Label l;

	private Label m;

	private UIComboBox n;

	private UIRadioButton o;

	private UIRadioButton p;

	private Label q;

	private UIButton r;

	private UIButton s;

	private EditBox t;

	private Label u;

	private UIButton v;

	private UIButton w;

	private UIButton x;

	private GridEX y;

	private MaskedEditBox z;

	private Label aa;

	private Label ab;

	private NumericEditBox ac;

	private NumericEditBox ad;

	private MaskedEditBox ae;

	private Label af;

	private CheckBox ag;

	private int ah;

	public asdca()
	{
		f();
	}

	protected override void a(bool A_0)
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
						num = 2;
						continue;
					}
					goto case 4;
				case 1:
					num = 4;
					continue;
				case 3:
					this.m_a.Dispose();
					num = 1;
					continue;
				case 2:
					flag = this.m_a == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 4:
					((Form)this).Dispose(A_0);
					return;
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
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected Obj, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_0c7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected Obj, but got Unknown
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected Obj, but got Unknown
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got Unknown
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected Obj, but got Unknown
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected Obj, but got Unknown
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected Obj, but got Unknown
		//IL_11b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bc: Expected Obj, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected Obj, but got Unknown
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a2: Expected Obj, but got Unknown
		//IL_1355: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Expected Obj, but got Unknown
		//IL_13fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1404: Expected Obj, but got Unknown
		//IL_14a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Expected Obj, but got Unknown
		//IL_1549: Unknown result type (might be due to invalid IL or missing references)
		//IL_1553: Expected Obj, but got Unknown
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Expected Obj, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Expected Obj, but got Unknown
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected Obj, but got Unknown
		//IL_16ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1709: Expected Obj, but got Unknown
		//IL_1812: Unknown result type (might be due to invalid IL or missing references)
		//IL_181c: Expected Obj, but got Unknown
		//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Expected Obj, but got Unknown
		//IL_196b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1975: Expected Obj, but got Unknown
		//IL_1987: Unknown result type (might be due to invalid IL or missing references)
		//IL_1991: Expected Obj, but got Unknown
		//IL_1a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7a: Expected Obj, but got Unknown
		//IL_1a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a96: Expected Obj, but got Unknown
		//IL_1b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7f: Expected Obj, but got Unknown
		//IL_1b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9b: Expected Obj, but got Unknown
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cef: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdca));
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_e = new Panel();
		this.m_d = new Label();
		this.m_f = new Label();
		this.m_g = new UIComboBox();
		this.m_h = new Label();
		this.m_i = new EditBox();
		j = new UIButton();
		k = new Panel();
		ag = new CheckBox();
		ae = new MaskedEditBox();
		af = new Label();
		ac = new NumericEditBox();
		z = new MaskedEditBox();
		aa = new Label();
		ad = new NumericEditBox();
		m = new Label();
		ab = new Label();
		n = new UIComboBox();
		o = new UIRadioButton();
		p = new UIRadioButton();
		l = new Label();
		q = new Label();
		r = new UIButton();
		s = new UIButton();
		t = new EditBox();
		u = new Label();
		v = new UIButton();
		w = new UIButton();
		x = new UIButton();
		y = new GridEX();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_e).SuspendLayout();
		((Control)k).SuspendLayout();
		((ISupportInitialize)y).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.Black;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel3";
		((Control)this.m_b).Size = new Size(550, 585);
		((Control)this.m_b).TabIndex = 17;
		((Control)this.m_c).BackColor = Color.SkyBlue;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Location = new Point(4, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(542, 573);
		((Control)this.m_c).TabIndex = 17;
		((Control)this.m_e).BackColor = Color.FromArgb(214, 223, 247);
		this.m_e.BorderStyle = (BorderStyle)1;
		((Control)this.m_e).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_e).Controls.Add((Control)(object)j);
		((Control)this.m_e).Controls.Add((Control)(object)k);
		((Control)this.m_e).Controls.Add((Control)(object)v);
		((Control)this.m_e).Controls.Add((Control)(object)w);
		((Control)this.m_e).Controls.Add((Control)(object)x);
		((Control)this.m_e).Controls.Add((Control)(object)y);
		((Control)this.m_e).Dock = (DockStyle)2;
		((Control)this.m_e).Location = new Point(0, -1);
		((Control)this.m_e).Name = "panel2";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(540, 572);
		((Control)this.m_e).TabIndex = 16;
		((Control)this.m_d).Anchor = (AnchorStyles)13;
		((Control)this.m_d).AutoSize = true;
		((Control)this.m_d).Font = new Font("B Nazanin", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(215, 5);
		((Control)this.m_d).Name = "label5";
		((Control)this.m_d).Size = new Size(112, 35);
		((Control)this.m_d).TabIndex = 49;
		((Control)this.m_d).Text = "لیست دروس";
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(218, 58);
		((Control)this.m_f).Name = "label4";
		((Control)this.m_f).Size = new Size(40, 26);
		((Control)this.m_f).TabIndex = 48;
		((Control)this.m_f).Text = "نوع  :";
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_g).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_g).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(21, 54);
		((Control)this.m_g).Name = "dropPayeSeacrch";
		((Control)this.m_g).Size = new Size(191, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_g).StringFormat = val;
		((Control)this.m_g).TabIndex = 47;
		this.m_g.SelectedIndexChanged += b;
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((Control)this.m_h).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(471, 58);
		((Control)this.m_h).Name = "label2";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(74, 26);
		((Control)this.m_h).TabIndex = 46;
		((Control)this.m_h).Text = "نام درس :";
		this.m_h.TextAlign = (ContentAlignment)64;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((EditBase)this.m_i).AutoScroll = false;
		((EditBase)this.m_i).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_i).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_i).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_i).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(301, 53);
		((Control)this.m_i).Name = "txtNameSearch";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(164, 33);
		((Control)this.m_i).TabIndex = 45;
		((EditBase)this.m_i).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_i).VisualStyle = (VisualStyle)2;
		((Control)this.m_i).KeyUp += a;
		j.ButtonStyle = (ButtonStyle)1;
		((Control)j).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		j.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		j.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		j.ImageIndex = 8;
		j.ImageSize = new Size(40, 40);
		((Control)j).Location = new Point(6, 531);
		((Control)j).Name = "uiButton2";
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(107, 32);
		((Control)j).TabIndex = 44;
		((Control)j).Text = "خروج";
		j.VisualStyle = (VisualStyle)1;
		((Control)j).Click += g;
		((Control)k).Anchor = (AnchorStyles)9;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Controls.Add((Control)(object)ag);
		((Control)k).Controls.Add((Control)(object)ae);
		((Control)k).Controls.Add((Control)(object)af);
		((Control)k).Controls.Add((Control)(object)ac);
		((Control)k).Controls.Add((Control)(object)z);
		((Control)k).Controls.Add((Control)(object)aa);
		((Control)k).Controls.Add((Control)(object)ad);
		((Control)k).Controls.Add((Control)(object)m);
		((Control)k).Controls.Add((Control)(object)ab);
		((Control)k).Controls.Add((Control)(object)n);
		((Control)k).Controls.Add((Control)(object)o);
		((Control)k).Controls.Add((Control)(object)p);
		((Control)k).Controls.Add((Control)(object)l);
		((Control)k).Controls.Add((Control)(object)q);
		((Control)k).Controls.Add((Control)(object)r);
		((Control)k).Controls.Add((Control)(object)s);
		((Control)k).Controls.Add((Control)(object)t);
		((Control)k).Controls.Add((Control)(object)u);
		((Control)k).Location = new Point(43, 203);
		((Control)k).Name = "POst";
		((Control)k).RightToLeft = (RightToLeft)1;
		((Control)k).Size = new Size(388, 225);
		((Control)k).TabIndex = 30;
		((Control)k).Visible = false;
		((Control)ag).AutoSize = true;
		ag.Checked = true;
		ag.CheckState = (CheckState)1;
		((Control)ag).Location = new Point(225, 82);
		((Control)ag).Name = "checkVezarat";
		((Control)ag).Size = new Size(54, 28);
		((Control)ag).TabIndex = 2;
		((Control)ag).Text = "نتایج";
		((ButtonBase)ag).UseVisualStyleBackColor = true;
		((EditBase)ae).AutoScroll = false;
		((EditBase)ae).AutoScrollMargin = new Size(0, 0);
		((EditBase)ae).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ae).AutoScrollPosition = new Point(0, 0);
		((Control)ae).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ae).Location = new Point(21, 116);
		((Control)ae).Name = "txtCodeDars";
		ae.Numeric = true;
		((Control)ae).Size = new Size(62, 33);
		((Control)ae).TabIndex = 4;
		((EditBase)ae).TextAlignment = (TextAlignment)1;
		((Control)af).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)af).Location = new Point(86, 116);
		((Control)af).Name = "label3";
		((Control)af).RightToLeft = (RightToLeft)1;
		((Control)af).Size = new Size(69, 31);
		((Control)af).TabIndex = 38;
		((Control)af).Text = "کد درس :";
		af.TextAlign = (ContentAlignment)64;
		((EditBase)ac).AutoScroll = false;
		((EditBase)ac).AutoScrollMargin = new Size(0, 0);
		((EditBase)ac).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ac).AutoScrollPosition = new Point(0, 0);
		((Control)ac).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ac).Location = new Point(204, 267);
		((Control)ac).Name = "txttimeWeek";
		((Control)ac).Size = new Size(62, 33);
		((Control)ac).TabIndex = 2;
		((Control)ac).Text = "1.00";
		((EditBase)ac).TextAlignment = (TextAlignment)1;
		ac.Value = new decimal(new int[4] { 100, 0, 0, 131072 });
		((Control)ac).Visible = false;
		((EditBase)z).AutoScroll = false;
		((EditBase)z).AutoScrollMargin = new Size(0, 0);
		((EditBase)z).AutoScrollMinSize = new Size(0, 0);
		((EditBase)z).AutoScrollPosition = new Point(0, 0);
		((Control)z).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)z).Location = new Point(218, 116);
		((Control)z).Name = "txtSort";
		z.Numeric = true;
		((Control)z).Size = new Size(62, 33);
		((Control)z).TabIndex = 3;
		((EditBase)z).TextAlignment = (TextAlignment)1;
		((Control)aa).Font = new Font("B Nazanin", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)aa).Location = new Point(285, 119);
		((Control)aa).Name = "label6";
		((Control)aa).RightToLeft = (RightToLeft)1;
		((Control)aa).Size = new Size(71, 27);
		((Control)aa).TabIndex = 33;
		((Control)aa).Text = "ترتیب:";
		aa.TextAlign = (ContentAlignment)64;
		((EditBase)ad).AutoScroll = false;
		((EditBase)ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ad).AutoScrollPosition = new Point(0, 0);
		((Control)ad).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ad).Location = new Point(43, 267);
		((Control)ad).Name = "txtVahed";
		((Control)ad).Size = new Size(62, 33);
		((Control)ad).TabIndex = 4;
		((Control)ad).Text = "1.00";
		((EditBase)ad).TextAlignment = (TextAlignment)1;
		ad.Value = new decimal(new int[4] { 100, 0, 0, 131072 });
		((Control)ad).Visible = false;
		((Control)m).Anchor = (AnchorStyles)1;
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(286, 9);
		((Control)m).Name = "label20";
		((Control)m).Size = new Size(37, 26);
		((Control)m).TabIndex = 31;
		((Control)m).Text = "نوع :";
		((Control)ab).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ab).Location = new Point(269, 269);
		((Control)ab).Name = "ltimeWeek";
		((Control)ab).RightToLeft = (RightToLeft)1;
		((Control)ab).Size = new Size(115, 29);
		((Control)ab).TabIndex = 35;
		((Control)ab).Text = "ساعات هفتگی :";
		ab.TextAlign = (ContentAlignment)64;
		((Control)ab).Visible = false;
		((Control)n).Anchor = (AnchorStyles)1;
		((UIComboBase)n).ComboStyle = (ComboStyle)1;
		((UIComboBase)n).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(21, 6);
		((Control)n).Name = "dropPaye";
		((Control)n).Size = new Size(259, 33);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)n).StringFormat = val2;
		((Control)n).TabIndex = 0;
		n.SelectedIndexChanged += a;
		((Control)o).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(72, 269);
		((Control)o).Name = "rEkhtesasi";
		((Control)o).RightToLeft = (RightToLeft)1;
		((Control)o).Size = new Size(79, 23);
		((Control)o).TabIndex = 6;
		((Control)o).Text = "اختصاصی";
		((Control)o).Visible = false;
		p.Checked = true;
		((Control)p).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(162, 268);
		((Control)p).Name = "rOmomi";
		((Control)p).RightToLeft = (RightToLeft)1;
		((Control)p).Size = new Size(69, 23);
		((Control)p).TabIndex = 5;
		p.TabStop = true;
		((Control)p).Text = "عمومی";
		((Control)p).Visible = false;
		((Control)l).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(113, 267);
		((Control)l).Name = "lvahed";
		((Control)l).RightToLeft = (RightToLeft)1;
		((Control)l).Size = new Size(85, 32);
		((Control)l).TabIndex = 32;
		((Control)l).Text = "تعداد واحد :";
		l.TextAlign = (ContentAlignment)64;
		((Control)l).Visible = false;
		((Control)q).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(285, 46);
		((Control)q).Name = "label1";
		((Control)q).RightToLeft = (RightToLeft)1;
		((Control)q).Size = new Size(98, 28);
		((Control)q).TabIndex = 29;
		((Control)q).Text = "عنوان درس :";
		q.TextAlign = (ContentAlignment)64;
		r.ButtonStyle = (ButtonStyle)1;
		((Control)r).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		r.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		r.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		r.ImageIndex = 8;
		((Control)r).Location = new Point(54, 167);
		((Control)r).Name = "btnCancel";
		((Control)r).RightToLeft = (RightToLeft)1;
		((Control)r).Size = new Size(97, 42);
		((Control)r).TabIndex = 6;
		((Control)r).Text = "انصراف";
		r.VisualStyle = (VisualStyle)1;
		((Control)r).Click += d;
		s.ButtonStyle = (ButtonStyle)1;
		((Control)s).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		s.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		s.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		s.ImageIndex = 8;
		((Control)s).Location = new Point(157, 167);
		((Control)s).Name = "btnAcp";
		((Control)s).RightToLeft = (RightToLeft)1;
		((Control)s).Size = new Size(101, 42);
		((Control)s).TabIndex = 5;
		((Control)s).Text = "تائيد";
		s.VisualStyle = (VisualStyle)1;
		((Control)s).Click += e;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((Control)t).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(21, 45);
		((Control)t).Name = "txtBook";
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(259, 33);
		((Control)t).TabIndex = 1;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((EditBase)t).VisualStyle = (VisualStyle)2;
		((Control)u).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(237, 264);
		((Control)u).Name = "L_Type";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(88, 29);
		((Control)u).TabIndex = 22;
		((Control)u).Text = "نوع درس :";
		u.TextAlign = (ContentAlignment)64;
		((Control)u).Visible = false;
		((Control)v).Anchor = (AnchorStyles)9;
		v.ButtonStyle = (ButtonStyle)1;
		((Control)v).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		v.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		v.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		v.ImageIndex = 8;
		((Control)v).Location = new Point(188, 531);
		((Control)v).Name = "btnDelete";
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(107, 32);
		((Control)v).TabIndex = 33;
		((Control)v).Text = "حذف";
		v.VisualStyle = (VisualStyle)1;
		((Control)v).Click += c;
		((Control)w).Anchor = (AnchorStyles)9;
		w.ButtonStyle = (ButtonStyle)1;
		((Control)w).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		w.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		w.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		w.ImageIndex = 8;
		((Control)w).Location = new Point(415, 531);
		((Control)w).Name = "btnNew";
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(107, 32);
		((Control)w).TabIndex = 31;
		((Control)w).Text = "جديد";
		w.VisualStyle = (VisualStyle)1;
		((Control)w).Click += i;
		((Control)x).Anchor = (AnchorStyles)9;
		x.ButtonStyle = (ButtonStyle)1;
		((Control)x).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		x.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		x.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		x.ImageIndex = 8;
		((Control)x).Location = new Point(301, 531);
		((Control)x).Name = "btnEdit";
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(107, 32);
		((Control)x).TabIndex = 32;
		((Control)x).Text = "اصلاح";
		x.VisualStyle = (VisualStyle)1;
		((Control)x).Click += f;
		y.AllowEdit = (InheritableBoolean)2;
		((Control)y).Anchor = (AnchorStyles)9;
		y.CardCaptionPrefix = "Product:";
		((Control)y).Cursor = Cursors.Default;
		y.DataMember = null;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		y.DesignTimeLayout = val3;
		y.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)y).FlatBorderColor = SystemColors.ControlDark;
		((Control)y).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		y.GridLineColor = SystemColors.ScrollBar;
		y.GroupByBoxVisible = false;
		y.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)y).Location = new Point(11, 91);
		((Control)y).Name = "gBook";
		((Control)y).RightToLeft = (RightToLeft)1;
		y.RowHeaders = (InheritableBoolean)1;
		y.SelectedFormatStyle.Blend = 0.5f;
		y.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)y).Size = new Size(518, 424);
		((Control)y).TabIndex = 15;
		((ScrollableBase)y).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)y).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)y).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)y).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)y).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)y).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)y).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)y).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		((Form)this).AcceptButton = (IButtonControl)(object)s;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(550, 585);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmbook";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست دروس";
		((Form)this).Load += h;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_e).ResumeLayout(false);
		((Control)this.m_e).PerformLayout();
		((Control)k).ResumeLayout(false);
		((Control)k).PerformLayout();
		((ISupportInitialize)y).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)n).Enabled = true;
		ah = 1;
		((Control)t).Text = "";
		((Control)k).Visible = true;
		e();
		d();
		((UIComboBase)n).Focus();
	}

	private void e()
	{
		while (true)
		{
			bool flag = n.SelectedIndex < 0;
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
					((Control)z).Text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(sort),0)+1 as sort from tbook where xpaye=" + n.SelectedValue).ToString();
					num = 2;
					continue;
				case 2:
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
		if (true)
		{
		}
		((Control)ae).Text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(codedars),0)+1 as id from tbook").ToString();
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
		n.DataSource = dataSource;
		n.DisplayMember = "Name";
		n.ValueMember = "id";
	}

	private void b()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
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
					this.m_g.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 1:
					this.m_g.Items.Add("", (object)"0");
					this.m_g.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			string text = "";
			bool flag = !(((Control)this.m_i).Text != "");
			int num = 10;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 4;
				case 13:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 4:
					num = 9;
					continue;
				case 9:
					num = ((this.m_g.SelectedIndex < 0) ? 18 : 3);
					continue;
				case 5:
					text = " tbook.name like N'%" + asdaj.b(((Control)this.m_i).Text) + "%'";
					num = 4;
					continue;
				case 3:
					num = 17;
					continue;
				case 17:
					num2 = ((!(this.m_g.SelectedValue.ToString() != "0")) ? 1 : 0);
					goto IL_01a4;
				case 12:
					text = " where " + text;
					num = 0;
					continue;
				case 14:
					text = "  tbook.xPaye=" + this.m_g.SelectedValue.ToString();
					num = 7;
					continue;
				case 6:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 7;
				case 15:
					if (true)
					{
					}
					flag = !(text != "");
					num = 11;
					continue;
				case 18:
					num2 = 1;
					goto IL_01a4;
				case 1:
					text += " and ";
					num = 14;
					continue;
				case 2:
					text += " and ";
					num = 5;
					continue;
				case 11:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 14;
				case 7:
					flag = !(text != "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 0;
				case 0:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tbook.id,tbook.CodeDars,tbook.Vezarat,  tbook.sort,tbook.Type, tbook.Name,tbook.xpaye,tbook.vahed,tbook.timeWeek,tpaye.name as paye  FROM tBook inner join tpaye on tbook.xpaye=tpaye.id" + text + " order by tbook.sort");
						y.DataSource = dataSource;
						return;
					}
					IL_01a4:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 11;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 10:
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					goto case 6;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 11:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 8;
					continue;
				case 8:
					return;
				case 2:
					flag = !(asdab.m != "2");
					num = 9;
					continue;
				case 9:
					if (flag)
					{
						((Control)ad).Text = "1";
						((Control)ac).Text = "1";
						p.Checked = true;
						num = 6;
					}
					else
					{
						num = 10;
					}
					continue;
				case 6:
					c();
					b();
					a();
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_e).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 0:
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			while (true)
			{
				IL_004a:
				bool flag = y.RecordCount <= 0;
				int num = 10;
				while (true)
				{
					switch (num)
					{
					case 10:
						if (!flag)
						{
							num = 14;
							continue;
						}
						goto case 8;
					case 9:
						try
						{
							ag.Checked = bool.Parse(y.SelectedItems[0].GetRow().Cells["Vezarat"].Value.ToString());
							((Control)ag).Tag = y.SelectedItems[0].GetRow().Cells["Vezarat"].Value.ToString();
						}
						catch
						{
						}
						((Control)ac).Text = y.SelectedItems[0].GetRow().Cells["timeWeek"].Value.ToString();
						((Control)z).Text = y.SelectedItems[0].GetRow().Cells["sort"].Value.ToString();
						flag = !(y.SelectedItems[0].GetRow().Cells["Type"].Value.ToString() == "2");
						num = 3;
						continue;
					case 13:
						if (flag)
						{
							p.Checked = false;
							o.Checked = false;
							num = 12;
						}
						else
						{
							num = 0;
						}
						continue;
					case 4:
					case 6:
					case 7:
					case 12:
						((Control)k).Visible = true;
						((Control)t).Focus();
						num = 8;
						continue;
					case 11:
						if (flag)
						{
							flag = !(y.SelectedItems[0].GetRow().Cells["Type"].Value.ToString() == "4");
							num = 13;
						}
						else
						{
							num = 2;
						}
						continue;
					case 3:
						if (flag)
						{
							flag = !(y.SelectedItems[0].GetRow().Cells["Type"].Value.ToString() == "3");
							num = 11;
						}
						else
						{
							num = 5;
						}
						continue;
					case 0:
						p.Checked = false;
						o.Checked = false;
						num = 6;
						continue;
					case 2:
						p.Checked = false;
						o.Checked = true;
						num = 4;
						continue;
					case 14:
						ah = 2;
						n.SelectedValue = y.SelectedItems[0].GetRow().Cells["xpaye"].Value.ToString();
						((Control)n).Enabled = false;
						((Control)t).Text = y.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
						((Control)ad).Text = y.SelectedItems[0].GetRow().Cells["vahed"].Value.ToString();
						((Control)ad).Tag = y.SelectedItems[0].GetRow().Cells["vahed"].Value.ToString();
						((Control)ae).Text = y.SelectedItems[0].GetRow().Cells["CodeDars"].Value.ToString();
						num = 9;
						continue;
					case 5:
						p.Checked = true;
						o.Checked = false;
						num = 7;
						continue;
					case 8:
						num = 1;
						continue;
					case 1:
						goto end_IL_0005;
					}
					goto IL_004a;
					continue;
					end_IL_0005:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		string text3 = default;
		string text = default;
		while (true)
		{
			bool flag = n.SelectedIndex >= 0;
			int num = 49;
			while (true)
			{
				int num2;
				int num5;
				switch (num)
				{
				case 49:
					if (!flag)
					{
						num = 33;
						continue;
					}
					flag = !(((Control)t).Text == "");
					num = 48;
					continue;
				case 26:
					MessageBox.Show("نام درس را تکراری می باشد");
					((Control)t).Focus();
					num = 53;
					continue;
				case 53:
					if (1 == 0)
					{
					}
					return;
				case 46:
					MessageBox.Show("ترتیب را وارد کنيد");
					((Control)z).Focus();
					num = 31;
					continue;
				case 31:
					return;
				case 36:
					MessageBox.Show("کد درس را تکراری می باشد");
					((Control)ae).Focus();
					num = 5;
					continue;
				case 5:
					return;
				case 13:
				{
					if (!flag)
					{
						num = 40;
						continue;
					}
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) AS countId FROM tBook WHERE  id<>" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + " and  (xPaye = " + n.SelectedValue.ToString() + ") AND (codeDars = " + ((Control)ae).Text + ")").ToString();
					flag = !(text2 != "0");
					num = 6;
					continue;
				}
				case 44:
					num = ((float.Parse(((Control)ad).Text) != float.Parse(((Control)ad).Tag.ToString())) ? 37 : 38);
					continue;
				case 38:
					num = 27;
					continue;
				case 27:
					num2 = ((ag.Checked == bool.Parse(((Control)ag).Tag.ToString())) ? 1 : 0);
					goto IL_0bce;
				case 42:
					MessageBox.Show("تعداد واحد را وارد کنيد");
					((Control)ad).Focus();
					num = 23;
					continue;
				case 23:
					return;
				case 24:
				{
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(id) AS countId FROM tBook WHERE     (xPaye = " + n.SelectedValue.ToString() + ") AND (Name = N'" + asdaj.b(((Control)t).Text) + "')").ToString();
					flag = !(text2 != "0");
					num = 55;
					continue;
				}
				case 55:
				{
					if (!flag)
					{
						num = 26;
						continue;
					}
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) AS countId FROM tBook WHERE (xPaye = " + n.SelectedValue.ToString() + ") AND (codeDars = " + ((Control)ae).Text + ")").ToString();
					flag = !(text2 != "0");
					num = 8;
					continue;
				}
				case 34:
					num = 41;
					continue;
				case 41:
					num5 = (o.Checked ? 1 : 0);
					goto IL_05cd;
				case 9:
				case 16:
					text3 = "0";
					flag = !ag.Checked;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 57;
						continue;
					}
					goto case 54;
				case 19:
					MessageBox.Show("ساعات هفتگی را وارد کنيد");
					((Control)ac).Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 54:
					flag = ah != 1;
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(id) AS countId FROM tBook WHERE  id<>" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + " and (xPaye = " + n.SelectedValue.ToString() + ") AND (Name = N'" + asdaj.b(((Control)t).Text) + "')").ToString();
						flag = !(text2 != "0");
						num = 13;
					}
					else
					{
						num = 24;
					}
					continue;
				case 10:
					MessageBox.Show("نوع درس را مشخص کنيد");
					((Control)p).Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 22:
					if (!flag)
					{
						num = 10;
						continue;
					}
					text = "";
					flag = !p.Checked;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 39;
						continue;
					}
					flag = !o.Checked;
					num = 4;
					continue;
				case 57:
					text3 = "1";
					num = 54;
					continue;
				case 50:
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tExam SET procc = 0 WHERE xyear=" + asdaj.a + " and (id IN(SELECT DISTINCT Xtest FROM tMark  WHERE (xbook = " + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")))");
					num = 21;
					continue;
				case 39:
					text = "2";
					num = 16;
					continue;
				case 32:
					num5 = 1;
					goto IL_05cd;
				case 18:
					MessageBox.Show("کد درس را تکراری می باشد");
					((Control)ae).Focus();
					num = 52;
					continue;
				case 52:
					return;
				case 6:
					if (flag)
					{
						asdcb.d(asdab.e(), CommandType.Text, "update tbook set Name=N'" + asdaj.b(((Control)t).Text) + "',Type=" + text + ",vahed=" + ((Control)ad).Text + ",timeWeek=" + ((Control)ac).Text + ",sort=" + ((Control)z).Text + ",codeDars = " + ((Control)ae).Text + ",Vezarat=" + text3 + ",xExportRpt=null where id=" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						num = 44;
					}
					else
					{
						num = 36;
					}
					continue;
				case 8:
					if (!flag)
					{
						num = 18;
						continue;
					}
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tbook (xPaye,Name,vahed,timeWeek,Type,sort,SortOneEntry,CodeDars,Vezarat)VALUES(" + n.SelectedValue.ToString() + ", N'" + asdaj.b(((Control)t).Text) + "'," + ((Control)ad).Text + "," + ((Control)ac).Text + "," + text + "," + ((Control)z).Text + "," + ((Control)z).Text + "," + ((Control)ae).Text + "," + text3 + ")");
					((Control)t).Text = "";
					((Control)t).Focus();
					num = 47;
					continue;
				case 43:
					if (!flag)
					{
						num = 42;
						continue;
					}
					flag = !(((Control)z).Text == "");
					num = 58;
					continue;
				case 35:
					MessageBox.Show("نام درس را وارد کنيد");
					((Control)t).Focus();
					num = 25;
					continue;
				case 25:
					return;
				case 1:
					if (flag)
					{
						flag = !(((Control)ad).Text == "");
						num = 43;
					}
					else
					{
						num = 19;
					}
					continue;
				case 33:
					MessageBox.Show("نوع را مشخص کنید");
					((UIComboBase)n).Focus();
					num = 30;
					continue;
				case 30:
					return;
				case 28:
					num = (flag ? 15 : 20);
					continue;
				case 4:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 9;
				case 40:
					MessageBox.Show("نام درس را تکراری می باشد");
					((Control)t).Focus();
					num = 45;
					continue;
				case 45:
					return;
				case 47:
					try
					{
						int num3 = int.Parse(((Control)z).Text);
						((Control)z).Text = (num3 + 1).ToString();
						int num4 = int.Parse(((Control)ae).Text);
						((Control)ae).Text = (num4 + 1).ToString();
					}
					catch
					{
					}
					num = 51;
					continue;
				case 15:
					num = ((!p.Checked) ? 34 : 32);
					continue;
				case 12:
					if (!flag)
					{
						num = 50;
						continue;
					}
					goto case 21;
				case 48:
					if (flag)
					{
						flag = !(((Control)ac).Text == "");
						num = 1;
					}
					else
					{
						num = 35;
					}
					continue;
				case 58:
					if (flag)
					{
						flag = !(((Control)ae).Text == "");
						num = 28;
					}
					else
					{
						num = 46;
					}
					continue;
				case 37:
					num2 = 0;
					goto IL_0bce;
				case 56:
					text = "3";
					num = 9;
					continue;
				case 21:
					((Control)k).Visible = false;
					num = 0;
					continue;
				case 20:
					MessageBox.Show("کد درس را وارد کنيد");
					((Control)ae).Focus();
					num = 29;
					continue;
				case 29:
					return;
				case 0:
				case 51:
					a();
					num = 14;
					continue;
				case 14:
					return;
					IL_05cd:
					flag = (byte)num5 != 0;
					num = 22;
					continue;
					IL_0bce:
					flag = (byte)num2 != 0;
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Control)k).Visible = false;
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num2 = default;
			int num3 = default;
			while (true)
			{
				IL_0064:
				bool flag = y.RecordCount <= 0;
				int num = 14;
				while (true)
				{
					switch (num)
					{
					case 14:
						if (!flag)
						{
							num = 15;
							continue;
						}
						goto case 13;
					case 0:
						num = 2;
						continue;
					case 6:
						try
						{
							num2 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) FROM tDisciplinaryStudent WHERE XBook=" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString());
						}
						catch
						{
						}
						flag = num3 <= 0;
						num = 5;
						continue;
					case 7:
						flag = (int)MessageBox.Show("آیا از حذف درس اطمینان دارید", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 16;
						continue;
					case 16:
						if (!flag)
						{
							num = 17;
							continue;
						}
						goto case 0;
					case 2:
					case 9:
						num = 13;
						continue;
					case 4:
						MessageBox.Show("از این درس در بخش اخطار آموزشی استفاده شده است. شما قادر به حذف نمیباشید", "حذف");
						num = 3;
						continue;
					case 3:
						return;
					case 17:
						asdcb.d(asdab.e(), CommandType.Text, "delete from  tBook WHERE  id = " + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						a();
						num = 0;
						continue;
					case 8:
						MessageBox.Show("برای این درس نمره وارد شده است. شما قادر به حذف نمیباشید", "حذف");
						num = 12;
						continue;
					case 12:
						return;
					case 15:
						num3 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) FROM tMark WHERE XBook=" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString());
						num2 = 0;
						num = 6;
						continue;
					case 5:
						if (!flag)
						{
							num = 8;
							continue;
						}
						flag = num2 <= 0;
						num = 1;
						continue;
					case 1:
					{
						if (!flag)
						{
							num = 4;
							continue;
						}
						string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(xCls) FROM   tTch_Cls WHERE     (xLsn = " + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")").ToString();
						flag = !(text == "0");
						num = 10;
						continue;
					}
					case 10:
						if (flag)
						{
							MessageBox.Show("برای این درس معلم تعریف شده است .حذف امکان پذیر نیست");
							num = 9;
						}
						else
						{
							num = 7;
						}
						continue;
					case 13:
						num = 11;
						continue;
					case 11:
						goto end_IL_0013;
					}
					goto IL_0064;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_g.SelectedValue = n.SelectedValue;
		e();
	}
}
