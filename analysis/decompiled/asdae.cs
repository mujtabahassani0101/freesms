using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdae : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private OpenFileDialog m_c;

	private Panel m_d;

	private Label m_e;

	private Panel m_f;

	private Panel m_g;

	private TextBox h;

	private Label i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private Label m;

	private MaskedEditBox n;

	private MaskedEditBox o;

	private Label p;

	private MaskedEditBox q;

	private MaskedEditBox r;

	private Label s;

	private MaskedEditBox t;

	private MaskedEditBox u;

	private MaskedEditBox v;

	private MaskedEditBox w;

	private MaskedEditBox x;

	private MaskedEditBox y;

	private MaskedEditBox z;

	private MaskedEditBox aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private MaskedEditBox ak;

	private MaskedEditBox al;

	private MaskedEditBox am;

	private MaskedEditBox an;

	private Label ao;

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private Label at;

	private Label au;

	private Label av;

	public string aw;

	public string ax;

	public string ay;

	private bool az = false;

	protected override void a(bool A_0)
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 0:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 6:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 3:
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

	private void c()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Expected Obj, but got Unknown
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e58: Expected Obj, but got Unknown
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Expected Obj, but got Unknown
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072: Expected Obj, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected Obj, but got Unknown
		//IL_1567: Unknown result type (might be due to invalid IL or missing references)
		//IL_1571: Expected Obj, but got Unknown
		//IL_163e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1648: Expected Obj, but got Unknown
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Expected Obj, but got Unknown
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1787: Expected Obj, but got Unknown
		//IL_17e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Expected Obj, but got Unknown
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c6: Expected Obj, but got Unknown
		//IL_1924: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Expected Obj, but got Unknown
		//IL_19fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a04: Expected Obj, but got Unknown
		//IL_1a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6c: Expected Obj, but got Unknown
		//IL_1b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b45: Expected Obj, but got Unknown
		//IL_1ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bad: Expected Obj, but got Unknown
		//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c86: Expected Obj, but got Unknown
		//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cee: Expected Obj, but got Unknown
		//IL_1dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc7: Expected Obj, but got Unknown
		//IL_1e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2f: Expected Obj, but got Unknown
		//IL_1efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f07: Expected Obj, but got Unknown
		//IL_1f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6f: Expected Obj, but got Unknown
		//IL_203e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2048: Expected Obj, but got Unknown
		//IL_2110: Unknown result type (might be due to invalid IL or missing references)
		//IL_211a: Expected Obj, but got Unknown
		//IL_21e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f3: Expected Obj, but got Unknown
		//IL_22bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c5: Expected Obj, but got Unknown
		//IL_2394: Unknown result type (might be due to invalid IL or missing references)
		//IL_239e: Expected Obj, but got Unknown
		//IL_23c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cd: Expected Obj, but got Unknown
		//IL_2488: Unknown result type (might be due to invalid IL or missing references)
		//IL_2492: Expected Obj, but got Unknown
		//IL_24aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b4: Expected Obj, but got Unknown
		//IL_2593: Unknown result type (might be due to invalid IL or missing references)
		//IL_259d: Expected Obj, but got Unknown
		//IL_261f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2629: Expected Obj, but got Unknown
		//IL_2695: Unknown result type (might be due to invalid IL or missing references)
		//IL_269f: Expected Obj, but got Unknown
		//IL_2754: Unknown result type (might be due to invalid IL or missing references)
		//IL_275e: Expected Obj, but got Unknown
		//IL_2770: Unknown result type (might be due to invalid IL or missing references)
		//IL_277a: Expected Obj, but got Unknown
		//IL_2807: Unknown result type (might be due to invalid IL or missing references)
		//IL_2811: Expected Obj, but got Unknown
		//IL_2823: Unknown result type (might be due to invalid IL or missing references)
		//IL_282d: Expected Obj, but got Unknown
		//IL_29ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f4: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdae));
		this.m_b = new Panel();
		av = new Label();
		ar = new Label();
		@as = new Label();
		at = new Label();
		au = new Label();
		this.m_e = new Label();
		this.m_f = new Panel();
		this.m_g = new Panel();
		ao = new Label();
		ap = new Label();
		aq = new Label();
		an = new MaskedEditBox();
		am = new MaskedEditBox();
		al = new MaskedEditBox();
		ak = new MaskedEditBox();
		ai = new Label();
		aj = new Label();
		ah = new Label();
		ag = new Label();
		af = new Label();
		ae = new Label();
		ab = new Label();
		ac = new Label();
		ad = new Label();
		x = new MaskedEditBox();
		y = new MaskedEditBox();
		z = new MaskedEditBox();
		aa = new MaskedEditBox();
		w = new MaskedEditBox();
		u = new MaskedEditBox();
		v = new MaskedEditBox();
		t = new MaskedEditBox();
		r = new MaskedEditBox();
		s = new Label();
		q = new MaskedEditBox();
		p = new Label();
		o = new MaskedEditBox();
		m = new Label();
		n = new MaskedEditBox();
		l = new Label();
		h = new TextBox();
		i = new Label();
		j = new UIButton();
		k = new UIButton();
		this.m_c = new OpenFileDialog();
		this.m_d = new Panel();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((Control)this.m_g).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)av);
		((Control)this.m_b).Controls.Add((Control)(object)ar);
		((Control)this.m_b).Controls.Add((Control)(object)@as);
		((Control)this.m_b).Controls.Add((Control)(object)at);
		((Control)this.m_b).Controls.Add((Control)(object)au);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(5, 5);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(601, 450);
		((Control)this.m_b).TabIndex = 0;
		((Control)av).AutoSize = true;
		((Control)av).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)av).Location = new Point(102, 88);
		((Control)av).Name = "label19";
		((Control)av).Size = new Size(81, 17);
		((Control)av).TabIndex = 114;
		((Control)av).Text = "نوع عملیات :";
		((Control)ar).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ar).ForeColor = Color.Fuchsia;
		((Control)ar).Location = new Point(6, 87);
		((Control)ar).Name = "lTypecomand";
		((Control)ar).Size = new Size(90, 18);
		((Control)ar).TabIndex = 113;
		((Control)ar).Text = "اصلاح پرداخت";
		((Control)@as).BackColor = Color.FromArgb(0, 192, 192);
		@as.BorderStyle = (BorderStyle)1;
		((Control)@as).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)@as).Location = new Point(349, 76);
		((Control)@as).Name = "lCode";
		((Control)@as).RightToLeft = (RightToLeft)1;
		((Control)@as).Size = new Size(173, 37);
		((Control)@as).TabIndex = 112;
		@as.TextAlign = (ContentAlignment)32;
		((Control)at).AutoSize = true;
		((Control)at).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)at).Location = new Point(528, 87);
		((Control)at).Name = "label5";
		((Control)at).Size = new Size(61, 17);
		((Control)at).TabIndex = 111;
		((Control)at).Text = "کد متعلم";
		((Control)au).AutoSize = true;
		((Control)au).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)au).Location = new Point(528, 26);
		((Control)au).Name = "label4";
		((Control)au).Size = new Size(51, 17);
		((Control)au).TabIndex = 110;
		((Control)au).Text = "نام -ولد";
		((Control)this.m_e).BackColor = Color.FromArgb(0, 192, 192);
		this.m_e.BorderStyle = (BorderStyle)1;
		((Control)this.m_e).Font = new Font("B Nazanin", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(10, 3);
		((Control)this.m_e).Name = "lName";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(512, 61);
		((Control)this.m_e).TabIndex = 77;
		this.m_e.TextAlign = (ContentAlignment)32;
		((Control)this.m_f).BackColor = Color.Gray;
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(7, 125);
		((Control)this.m_f).Name = "pStd";
		((Control)this.m_f).Size = new Size(588, 317);
		((Control)this.m_f).TabIndex = 79;
		((Control)this.m_g).BackColor = Color.FromArgb(214, 223, 247);
		this.m_g.BorderStyle = (BorderStyle)2;
		((Control)this.m_g).Controls.Add((Control)(object)ao);
		((Control)this.m_g).Controls.Add((Control)(object)ap);
		((Control)this.m_g).Controls.Add((Control)(object)aq);
		((Control)this.m_g).Controls.Add((Control)(object)an);
		((Control)this.m_g).Controls.Add((Control)(object)am);
		((Control)this.m_g).Controls.Add((Control)(object)al);
		((Control)this.m_g).Controls.Add((Control)(object)ak);
		((Control)this.m_g).Controls.Add((Control)(object)ai);
		((Control)this.m_g).Controls.Add((Control)(object)aj);
		((Control)this.m_g).Controls.Add((Control)(object)ah);
		((Control)this.m_g).Controls.Add((Control)(object)ag);
		((Control)this.m_g).Controls.Add((Control)(object)af);
		((Control)this.m_g).Controls.Add((Control)(object)ae);
		((Control)this.m_g).Controls.Add((Control)(object)ab);
		((Control)this.m_g).Controls.Add((Control)(object)ac);
		((Control)this.m_g).Controls.Add((Control)(object)ad);
		((Control)this.m_g).Controls.Add((Control)(object)x);
		((Control)this.m_g).Controls.Add((Control)(object)y);
		((Control)this.m_g).Controls.Add((Control)(object)z);
		((Control)this.m_g).Controls.Add((Control)(object)aa);
		((Control)this.m_g).Controls.Add((Control)(object)w);
		((Control)this.m_g).Controls.Add((Control)(object)u);
		((Control)this.m_g).Controls.Add((Control)(object)v);
		((Control)this.m_g).Controls.Add((Control)(object)t);
		((Control)this.m_g).Controls.Add((Control)(object)r);
		((Control)this.m_g).Controls.Add((Control)(object)s);
		((Control)this.m_g).Controls.Add((Control)(object)q);
		((Control)this.m_g).Controls.Add((Control)(object)p);
		((Control)this.m_g).Controls.Add((Control)(object)o);
		((Control)this.m_g).Controls.Add((Control)(object)m);
		((Control)this.m_g).Controls.Add((Control)(object)n);
		((Control)this.m_g).Controls.Add((Control)(object)l);
		((Control)this.m_g).Controls.Add((Control)(object)h);
		((Control)this.m_g).Controls.Add((Control)(object)i);
		((Control)this.m_g).Controls.Add((Control)(object)j);
		((Control)this.m_g).Controls.Add((Control)(object)k);
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(2, 3);
		((Control)this.m_g).Name = "panel3";
		((Control)this.m_g).Size = new Size(580, 307);
		((Control)this.m_g).TabIndex = 40;
		((Control)ao).AutoSize = true;
		((Control)ao).Location = new Point(107, 220);
		((Control)ao).Name = "label23";
		((Control)ao).Size = new Size(75, 16);
		((Control)ao).TabIndex = 138;
		((Control)ao).Text = "باقی مانده :";
		((Control)ap).AutoSize = true;
		((Control)ap).Location = new Point(316, 220);
		((Control)ap).Name = "label22";
		((Control)ap).Size = new Size(82, 16);
		((Control)ap).TabIndex = 137;
		((Control)ap).Text = "پرداخت شده:";
		((Control)aq).AutoSize = true;
		((Control)aq).Location = new Point(495, 220);
		((Control)aq).Name = "label14";
		((Control)aq).Size = new Size(80, 16);
		((Control)aq).TabIndex = 136;
		((Control)aq).Text = "فیس سالانه:";
		((EditBase)an).AutoScroll = false;
		((EditBase)an).AutoScrollMargin = new Size(0, 0);
		((EditBase)an).AutoScrollMinSize = new Size(0, 0);
		((EditBase)an).AutoScrollPosition = new Point(0, 0);
		((EditBase)an).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)an).Enabled = false;
		((Control)an).Location = new Point(16, 217);
		((EditBase)an).MaxLength = 9;
		((Control)an).Name = "txtMostPay";
		an.Numeric = true;
		((Control)an).RightToLeft = (RightToLeft)1;
		((Control)an).Size = new Size(88, 23);
		((Control)an).TabIndex = 135;
		((Control)an).Tag = "";
		((EditBase)an).TextAlignment = (TextAlignment)1;
		((EditBase)am).AutoScroll = false;
		((EditBase)am).AutoScrollMargin = new Size(0, 0);
		((EditBase)am).AutoScrollMinSize = new Size(0, 0);
		((EditBase)am).AutoScrollPosition = new Point(0, 0);
		((EditBase)am).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)am).Enabled = false;
		((Control)am).Location = new Point(227, 217);
		((EditBase)am).MaxLength = 9;
		((Control)am).Name = "txtStdPay";
		am.Numeric = true;
		((Control)am).RightToLeft = (RightToLeft)1;
		((Control)am).Size = new Size(88, 23);
		((Control)am).TabIndex = 134;
		((Control)am).Tag = "";
		((EditBase)am).TextAlignment = (TextAlignment)1;
		((EditBase)al).AutoScroll = false;
		((EditBase)al).AutoScrollMargin = new Size(0, 0);
		((EditBase)al).AutoScrollMinSize = new Size(0, 0);
		((EditBase)al).AutoScrollPosition = new Point(0, 0);
		((EditBase)al).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)al).Enabled = false;
		((Control)al).Location = new Point(405, 217);
		((EditBase)al).MaxLength = 9;
		((Control)al).Name = "txtSumFee";
		al.Numeric = true;
		((Control)al).RightToLeft = (RightToLeft)1;
		((Control)al).Size = new Size(88, 23);
		((Control)al).TabIndex = 133;
		((Control)al).Tag = "";
		((EditBase)al).TextAlignment = (TextAlignment)1;
		((EditBase)ak).AutoScroll = false;
		((EditBase)ak).AutoScrollMargin = new Size(0, 0);
		((EditBase)ak).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ak).AutoScrollPosition = new Point(0, 0);
		((EditBase)ak).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ak).Location = new Point(16, 140);
		((EditBase)ak).MaxLength = 9;
		((Control)ak).Name = "txtother";
		ak.Numeric = true;
		((Control)ak).RightToLeft = (RightToLeft)1;
		((Control)ak).Size = new Size(88, 23);
		((Control)ak).TabIndex = 14;
		((Control)ak).Tag = "";
		((EditBase)ak).TextAlignment = (TextAlignment)1;
		((Control)ak).Leave += c;
		((Control)ak).Enter += d;
		((Control)ak).KeyDown += a;
		((Control)ai).AutoSize = true;
		((Control)ai).Location = new Point(110, 146);
		((Control)ai).Name = "label21";
		((Control)ai).Size = new Size(43, 16);
		((Control)ai).TabIndex = 132;
		((Control)ai).Text = "سایر :";
		((Control)aj).AutoSize = true;
		((Control)aj).Location = new Point(110, 111);
		((Control)aj).Name = "label18";
		((Control)aj).Size = new Size(47, 16);
		((Control)aj).TabIndex = 131;
		((Control)aj).Text = "داخله :";
		((Control)ah).AutoSize = true;
		((Control)ah).Location = new Point(110, 76);
		((Control)ah).Name = "label17";
		((Control)ah).Size = new Size(85, 16);
		((Control)ah).TabIndex = 130;
		((Control)ah).Text = "کمک درسی :";
		((Control)ag).AutoSize = true;
		((Control)ag).Location = new Point(110, 44);
		((Control)ag).Name = "label16";
		((Control)ag).Size = new Size(43, 16);
		((Control)ag).TabIndex = 129;
		((Control)ag).Text = "کتاب :";
		((Control)af).AutoSize = true;
		((Control)af).Location = new Point(110, 10);
		((Control)af).Name = "label15";
		((Control)af).Size = new Size(49, 16);
		((Control)af).TabIndex = 128;
		((Control)af).Text = "مقنعه :";
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(321, 109);
		((Control)ae).Name = "label13";
		((Control)ae).Size = new Size(56, 16);
		((Control)ae).TabIndex = 126;
		((Control)ae).Text = "یونیفرم :";
		((Control)ab).AutoSize = true;
		((Control)ab).Location = new Point(323, 77);
		((Control)ab).Name = "label11";
		((Control)ab).Size = new Size(54, 16);
		((Control)ab).TabIndex = 125;
		((Control)ab).Text = "امتحان :";
		((Control)ac).AutoSize = true;
		((Control)ac).Location = new Point(321, 43);
		((Control)ac).Name = "label9";
		((Control)ac).Size = new Size(50, 16);
		((Control)ac).TabIndex = 124;
		((Control)ac).Text = "جشن :";
		((Control)ad).AutoSize = true;
		((Control)ad).Location = new Point(321, 12);
		((Control)ad).Name = "label8";
		((Control)ad).Size = new Size(60, 16);
		((Control)ad).TabIndex = 123;
		((Control)ad).Text = "مسابقه :";
		((EditBase)x).AutoScroll = false;
		((EditBase)x).AutoScrollMargin = new Size(0, 0);
		((EditBase)x).AutoScrollMinSize = new Size(0, 0);
		((EditBase)x).AutoScrollPosition = new Point(0, 0);
		((EditBase)x).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(16, 106);
		((EditBase)x).MaxLength = 9;
		((Control)x).Name = "txtdakhle";
		x.Numeric = true;
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(88, 23);
		((Control)x).TabIndex = 13;
		((Control)x).Tag = "";
		((EditBase)x).TextAlignment = (TextAlignment)1;
		((Control)x).Leave += c;
		((Control)x).Enter += d;
		((Control)x).KeyDown += a;
		((EditBase)y).AutoScroll = false;
		((EditBase)y).AutoScrollMargin = new Size(0, 0);
		((EditBase)y).AutoScrollMinSize = new Size(0, 0);
		((EditBase)y).AutoScrollPosition = new Point(0, 0);
		((EditBase)y).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(16, 73);
		((EditBase)y).MaxLength = 9;
		((Control)y).Name = "txtkomakdarsi";
		y.Numeric = true;
		((Control)y).RightToLeft = (RightToLeft)1;
		((Control)y).Size = new Size(88, 23);
		((Control)y).TabIndex = 11;
		((Control)y).Tag = "";
		((EditBase)y).TextAlignment = (TextAlignment)1;
		((Control)y).Leave += c;
		((Control)y).Enter += d;
		((Control)y).KeyDown += a;
		((EditBase)z).AutoScroll = false;
		((EditBase)z).AutoScrollMargin = new Size(0, 0);
		((EditBase)z).AutoScrollMinSize = new Size(0, 0);
		((EditBase)z).AutoScrollPosition = new Point(0, 0);
		((EditBase)z).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)z).Location = new Point(16, 40);
		((EditBase)z).MaxLength = 9;
		((Control)z).Name = "txtketab";
		z.Numeric = true;
		((Control)z).RightToLeft = (RightToLeft)1;
		((Control)z).Size = new Size(88, 23);
		((Control)z).TabIndex = 10;
		((Control)z).Tag = "";
		((EditBase)z).TextAlignment = (TextAlignment)1;
		((Control)z).Leave += c;
		((Control)z).Enter += d;
		((Control)z).KeyDown += a;
		((EditBase)aa).AutoScroll = false;
		((EditBase)aa).AutoScrollMargin = new Size(0, 0);
		((EditBase)aa).AutoScrollMinSize = new Size(0, 0);
		((EditBase)aa).AutoScrollPosition = new Point(0, 0);
		((EditBase)aa).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)aa).Location = new Point(16, 8);
		((EditBase)aa).MaxLength = 9;
		((Control)aa).Name = "txtmaghnae";
		aa.Numeric = true;
		((Control)aa).RightToLeft = (RightToLeft)1;
		((Control)aa).Size = new Size(88, 23);
		((Control)aa).TabIndex = 9;
		((Control)aa).Tag = "";
		((EditBase)aa).TextAlignment = (TextAlignment)1;
		((Control)aa).Leave += c;
		((Control)aa).Enter += d;
		((Control)aa).KeyDown += a;
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((EditBase)w).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(227, 106);
		((EditBase)w).MaxLength = 9;
		((Control)w).Name = "txtuniform";
		w.Numeric = true;
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(88, 23);
		((Control)w).TabIndex = 8;
		((Control)w).Tag = "";
		((EditBase)w).TextAlignment = (TextAlignment)1;
		((Control)w).Leave += c;
		((Control)w).Enter += d;
		((Control)w).KeyDown += a;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((EditBase)u).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(227, 73);
		((EditBase)u).MaxLength = 9;
		((Control)u).Name = "txtExam";
		u.Numeric = true;
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(88, 23);
		((Control)u).TabIndex = 7;
		((Control)u).Tag = "";
		((EditBase)u).TextAlignment = (TextAlignment)1;
		((Control)u).Leave += c;
		((Control)u).Enter += d;
		((Control)u).KeyDown += a;
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((EditBase)v).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(227, 40);
		((EditBase)v).MaxLength = 9;
		((Control)v).Name = "txtCelebration";
		v.Numeric = true;
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(88, 23);
		((Control)v).TabIndex = 6;
		((Control)v).Tag = "";
		((EditBase)v).TextAlignment = (TextAlignment)1;
		((Control)v).Leave += c;
		((Control)v).Enter += d;
		((Control)v).KeyDown += a;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((EditBase)t).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(227, 8);
		((EditBase)t).MaxLength = 9;
		((Control)t).Name = "txtracing";
		t.Numeric = true;
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(88, 23);
		((Control)t).TabIndex = 5;
		((Control)t).Tag = "";
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((Control)t).Leave += c;
		((Control)t).Enter += d;
		((Control)t).KeyDown += a;
		((EditBase)r).AutoScroll = false;
		((EditBase)r).AutoScrollMargin = new Size(0, 0);
		((EditBase)r).AutoScrollMinSize = new Size(0, 0);
		((EditBase)r).AutoScrollPosition = new Point(0, 0);
		((EditBase)r).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(405, 106);
		((EditBase)r).MaxLength = 9;
		((Control)r).Name = "txtTransport";
		r.Numeric = true;
		((Control)r).RightToLeft = (RightToLeft)1;
		((Control)r).Size = new Size(88, 23);
		((Control)r).TabIndex = 3;
		((Control)r).Tag = "";
		((EditBase)r).TextAlignment = (TextAlignment)1;
		((Control)r).Leave += c;
		((Control)r).Enter += d;
		((Control)r).KeyDown += a;
		((Control)s).AutoSize = true;
		((Control)s).Location = new Point(501, 109);
		((Control)s).Name = "label3";
		((Control)s).Size = new Size(74, 16);
		((Control)s).TabIndex = 113;
		((Control)s).Text = "ترانسپورت :";
		((EditBase)q).AutoScroll = false;
		((EditBase)q).AutoScrollMargin = new Size(0, 0);
		((EditBase)q).AutoScrollMinSize = new Size(0, 0);
		((EditBase)q).AutoScrollPosition = new Point(0, 0);
		((EditBase)q).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(405, 73);
		((EditBase)q).MaxLength = 9;
		((Control)q).Name = "txtFee";
		q.Numeric = true;
		((Control)q).RightToLeft = (RightToLeft)1;
		((Control)q).Size = new Size(88, 23);
		((Control)q).TabIndex = 2;
		((Control)q).Tag = "";
		((EditBase)q).TextAlignment = (TextAlignment)1;
		((Control)q).Leave += c;
		((Control)q).Enter += d;
		((Control)q).KeyDown += a;
		((Control)p).AutoSize = true;
		((Control)p).Location = new Point(501, 42);
		((Control)p).Name = "label1";
		((Control)p).Size = new Size(60, 16);
		((Control)p).TabIndex = 111;
		((Control)p).Text = " نمبر بل :";
		((EditBase)o).AutoScroll = false;
		((EditBase)o).AutoScrollMargin = new Size(0, 0);
		((EditBase)o).AutoScrollMinSize = new Size(0, 0);
		((EditBase)o).AutoScrollPosition = new Point(0, 0);
		((EditBase)o).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(405, 40);
		((EditBase)o).MaxLength = 9;
		((Control)o).Name = "txtNamberBel";
		o.Numeric = true;
		((Control)o).RightToLeft = (RightToLeft)1;
		((Control)o).Size = new Size(88, 23);
		((Control)o).TabIndex = 1;
		((Control)o).Tag = "";
		((EditBase)o).TextAlignment = (TextAlignment)1;
		((Control)o).Leave += c;
		((Control)o).Enter += d;
		((Control)o).KeyDown += a;
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(501, 9);
		((Control)m).Name = "label12";
		((Control)m).Size = new Size(44, 17);
		((Control)m).TabIndex = 109;
		((Control)m).Text = "تاریخ :";
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((EditBase)n).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(407, 8);
		n.Mask = "0000/00/00";
		((EditBase)n).MaxLength = 12;
		((Control)n).Name = "txtPaynemtDate";
		n.Numeric = true;
		((Control)n).RightToLeft = (RightToLeft)0;
		((Control)n).Size = new Size(86, 22);
		((Control)n).TabIndex = 0;
		((Control)n).Tag = "";
		((EditBase)n).TextAlignment = (TextAlignment)3;
		((Control)n).Leave += c;
		((Control)n).Enter += d;
		((Control)n).KeyDown += a;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(501, 76);
		((Control)l).Name = "label6";
		((Control)l).Size = new Size(44, 16);
		((Control)l).TabIndex = 48;
		((Control)l).Text = "فیس :";
		((Control)h).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)h).Location = new Point(163, 139);
		((TextBoxBase)h).Multiline = true;
		((Control)h).Name = "txtComment";
		((Control)h).Size = new Size(331, 61);
		((Control)h).TabIndex = 4;
		((Control)h).KeyDown += a;
		((Control)h).Leave += a;
		((Control)h).Enter += b;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(501, 142);
		((Control)i).Name = "label2";
		((Control)i).Size = new Size(66, 16);
		((Control)i).TabIndex = 42;
		((Control)i).Text = "توضیحات :";
		((Control)j).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		j.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)j).Location = new Point(19, 259);
		((Control)j).Name = "btnCancel";
		((Control)j).Size = new Size(110, 39);
		((Control)j).TabIndex = 16;
		((Control)j).Text = "انصراف(Esc)";
		((Control)j).Click += e;
		((Control)k).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		k.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)k).Location = new Point(147, 259);
		((Control)k).Name = "btnAcp";
		((Control)k).Size = new Size(110, 39);
		((Control)k).TabIndex = 15;
		((Control)k).Text = "ثبت(F3)";
		((Control)k).Click += f;
		((FileDialog)this.m_c).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_c).Title = "انتخاب عکس شاگرد";
		((Control)this.m_d).BackColor = Color.Black;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_d).Dock = (DockStyle)5;
		((Control)this.m_d).Location = new Point(0, 0);
		((Control)this.m_d).Name = "panel2";
		((Control)this.m_d).Size = new Size(611, 461);
		((Control)this.m_d).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(611, 461);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmPaymentInsertUpdate";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += g;
		((Control)this).KeyUp += b;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_g).ResumeLayout(false);
		((Control)this.m_g).PerformLayout();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdae()
	{
		c();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("9");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 3;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 1;
					continue;
				case 4:
				case 7:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xStudent", SqlDbType.Int, aw) };
					DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select code,fname,lname from tstudent where  id=@xStudent", a_);
					((Control)this.m_e).Text = dataTable2.Rows[0]["fname"].ToString() + " - " + dataTable2.Rows[0]["lname"].ToString();
					((Control)@as).Text = dataTable2.Rows[0]["code"].ToString();
					flag = !(ay != "0");
					num = 13;
					continue;
				}
				case 13:
					if (!flag)
					{
						num = 14;
						continue;
					}
					((Control)ar).Text = "پرداخت جدید";
					num = 0;
					continue;
				case 10:
					flag = !(asdaj.k == "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 5;
						continue;
					}
					((Control)n).Text = asdaj.k;
					num = 4;
					continue;
				case 8:
					num = 6;
					continue;
				case 1:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 10;
				case 0:
				case 2:
					b();
					((Control)n).Focus();
					num = 12;
					continue;
				case 12:
					return;
				case 6:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_b).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 10;
					continue;
				case 14:
					((Control)ar).Text = "اصلاح پرداخت";
					a();
					if (true)
					{
					}
					num = 2;
					continue;
				case 5:
					((Control)n).Text = asdab.b();
					num = 7;
					continue;
				case 3:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 9;
					continue;
				case 9:
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[2]
		{
			asdcb.a("@xYear", SqlDbType.Int, ax),
			asdcb.a("@xStudent", SqlDbType.Int, aw)
		};
		int num = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "select isnull(SumFee,0) from tYear_Student where xStudent=@xStudent and xYear=@xYear", a_).ToString());
		int num2 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "select isnull(Sum(fee),0) from tPaymentStudent where xStudent=@xStudent and xYear=@xYear", a_).ToString());
		int num3 = num - num2;
		((Control)al).Text = num.ToString();
		((Control)am).Text = num2.ToString();
		((Control)an).Text = num3.ToString();
	}

	private void a()
	{
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[3]
		{
			asdcb.a("@xYear", SqlDbType.Int, ax),
			asdcb.a("@id", SqlDbType.Int, ay),
			asdcb.a("@xStudent", SqlDbType.Int, aw)
		};
		DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * FROM tPaymentStudent where xStudent=@xStudent and xYear=@xYear and id=@id", a_);
		((Control)n).Text = dataTable.Rows[0]["PaynemtDate"].ToString();
		((Control)o).Text = dataTable.Rows[0]["NamberBel"].ToString();
		((Control)q).Text = dataTable.Rows[0]["Fee"].ToString();
		((Control)r).Text = dataTable.Rows[0]["Transport"].ToString();
		((Control)t).Text = dataTable.Rows[0]["racing"].ToString();
		((Control)v).Text = dataTable.Rows[0]["Celebration"].ToString();
		((Control)u).Text = dataTable.Rows[0]["Exam"].ToString();
		((Control)w).Text = dataTable.Rows[0]["uniform"].ToString();
		((Control)aa).Text = dataTable.Rows[0]["maghnae"].ToString();
		((Control)z).Text = dataTable.Rows[0]["ketab"].ToString();
		((Control)y).Text = dataTable.Rows[0]["komakdarsi"].ToString();
		((Control)x).Text = dataTable.Rows[0]["dakhle"].ToString();
		((Control)ak).Text = dataTable.Rows[0]["other"].ToString();
		((Control)h).Text = dataTable.Rows[0]["comment"].ToString();
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		SqlParameter[] array = default;
		object a_2 = default;
		bool flag2 = default;
		object a_5 = default;
		object a_4 = default;
		object a_ = default;
		object a_11 = default;
		object a_10 = default;
		object a_8 = default;
		object a_7 = default;
		object a_6 = default;
		object a_9 = default;
		object a_3 = default;
		int num12 = default;
		bool flag = default;
		while (true)
		{
			asdaj.k = ((Control)n).Text;
			string text = "";
			int num = 113;
			while (true)
			{
				int num2;
				int num5;
				int num10;
				int num4;
				int num13;
				int num3;
				int num6;
				int num9;
				int num7;
				int num11;
				int num8;
				switch (num)
				{
				case 38:
					if (!flag)
					{
						num = 55;
						continue;
					}
					goto case 27;
				case 67:
					num2 = 0;
					goto IL_09bc;
				case 80:
					num = 88;
					continue;
				case 88:
					num5 = ((!(((Control)u).Text == "0")) ? 1 : 0);
					goto IL_0de1;
				case 63:
					num10 = 0;
					goto IL_05eb;
				case 71:
					num = 114;
					continue;
				case 114:
					num4 = ((!(((Control)aa).Text == "0")) ? 1 : 0);
					goto IL_0bf8;
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "-200");
					num = 40;
					continue;
				case 85:
					asdaj.i = true;
					MessageBox.Show("ثبت شد");
					((Form)this).Close();
					num = 43;
					continue;
				case 43:
					return;
				case 8:
				case 82:
					a_2 = ((Control)v).Text;
					num = 73;
					continue;
				case 73:
					num = ((((Control)v).Text.Trim() == "") ? 56 : 0);
					continue;
				case 91:
					num4 = 0;
					goto IL_0bf8;
				case 49:
					num = 12;
					continue;
				case 12:
					num13 = ((!(((Control)t).Text == "0")) ? 1 : 0);
					goto IL_0f5d;
				case 2:
					num = 118;
					continue;
				case 118:
					num10 = ((!(((Control)x).Text == "0")) ? 1 : 0);
					goto IL_05eb;
				case 97:
					if (!flag)
					{
						num = 25;
						continue;
					}
					flag2 = true;
					num = 76;
					continue;
				case 109:
					text = "دوشنبه";
					num = 29;
					continue;
				case 30:
				case 60:
					flag = flag2;
					num = 21;
					continue;
				case 21:
					if (flag)
					{
						array = new SqlParameter[21]
						{
							asdcb.a("@code", SqlDbType.Int),
							asdcb.a("@id", SqlDbType.Int, ay),
							asdcb.a("@xYear", SqlDbType.Int, ax),
							asdcb.a("@xStudent", SqlDbType.Int, aw),
							asdcb.a("@PaynemtDate", SqlDbType.NVarChar, ((Control)n).Text),
							asdcb.a("@dayOfWeek", SqlDbType.NVarChar, text),
							asdcb.a("@NamberBel", SqlDbType.NVarChar, ((Control)o).Text.Trim()),
							asdcb.a("@Fee", SqlDbType.Int, a_5),
							asdcb.a("@Transport", SqlDbType.Int, a_4),
							asdcb.a("@racing", SqlDbType.Int, a_),
							asdcb.a("@Celebration", SqlDbType.Int, a_2),
							asdcb.a("@Exam", SqlDbType.Int, a_11),
							asdcb.a("@uniform", SqlDbType.Int, a_10),
							asdcb.a("@maghnae", SqlDbType.Int, a_8),
							asdcb.a("@ketab", SqlDbType.Int, a_7),
							asdcb.a("@komakdarsi", SqlDbType.Int, a_6),
							asdcb.a("@dakhle", SqlDbType.Int, a_9),
							asdcb.a("@other", SqlDbType.Int, a_3),
							asdcb.a("@comment", SqlDbType.NVarChar, ((Control)h).Text.Trim()),
							asdcb.a("@Date", SqlDbType.NVarChar, asdab.b() + "-" + asdab.c()),
							asdcb.a("@xUser", SqlDbType.Int, asdaj.l)
						};
						num12 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tPaymentStudent_insertUpdate", array);
						flag = !(((DbParameter)(object)array[0]).Value.ToString() == "-100");
						num = 6;
					}
					else
					{
						num = 83;
					}
					continue;
				case 89:
					a_11 = DBNull.Value;
					num = 59;
					continue;
				case 104:
					a_10 = DBNull.Value;
					num = 64;
					continue;
				case 79:
					num3 = 0;
					goto IL_0736;
				case 3:
					MessageBox.Show("در این تاریخ یک پرداخت ثبت شده است\n\nامکان ثبت بیشتر از یک پرداخت در هر روز برای شاگرد امکان پذیر نیست\n\nدر صورت نیاز ، پرداخت موجود در این تاریخ را اصلاح نمایید");
					num = 45;
					continue;
				case 45:
					return;
				case 7:
					num6 = 0;
					goto IL_103c;
				case 26:
					if (!flag)
					{
						num = 115;
						continue;
					}
					flag = !(text == "Thursday");
					num = 13;
					continue;
				case 120:
					if (!flag)
					{
						num = 39;
						continue;
					}
					flag2 = true;
					num = 57;
					continue;
				case 119:
					if (!flag)
					{
						num = 75;
						continue;
					}
					flag = !(text == "Monday");
					num = 121;
					continue;
				case 27:
				case 29:
				case 37:
				case 54:
				case 87:
				case 101:
				case 108:
					flag2 = false;
					a_5 = ((Control)q).Text;
					num = 66;
					continue;
				case 66:
					num = ((((Control)q).Text.Trim() == "") ? 100 : 42);
					continue;
				case 20:
					MessageBox.Show("مبلغ وارد شده برای فیس بالاتر از مقدار باقی مانده است ");
					num = 24;
					continue;
				case 24:
					return;
				case 0:
					num = 41;
					continue;
				case 41:
					num9 = ((!(((Control)v).Text == "0")) ? 1 : 0);
					goto IL_082e;
				case 34:
					if (!flag)
					{
						num = 65;
						continue;
					}
					flag2 = true;
					num = 116;
					continue;
				case 13:
					if (true)
					{
					}
					if (flag)
					{
						flag = !(text == "Friday");
						num = 38;
					}
					else
					{
						num = 105;
					}
					continue;
				case 1:
					a_ = DBNull.Value;
					num = 8;
					continue;
				case 50:
				case 78:
					a_7 = ((Control)z).Text;
					num = 81;
					continue;
				case 81:
					num = ((((Control)z).Text.Trim() == "") ? 107 : 90);
					continue;
				case 55:
					text = "جمعه";
					num = 54;
					continue;
				case 115:
					text = "چهارشنبه";
					num = 87;
					continue;
				case 102:
					if (!flag)
					{
						num = 85;
						continue;
					}
					return;
				case 105:
					text = "پنج شنبه";
					num = 27;
					continue;
				case 83:
					MessageBox.Show("جهت ثبت پرداخت حداقل یکی از گزینه ها باید وارد شود");
					((Control)q).Focus();
					num = 48;
					continue;
				case 48:
					return;
				case 70:
					if (!flag)
					{
						num = 104;
						continue;
					}
					flag2 = true;
					num = 62;
					continue;
				case 9:
					text = "شنبه";
					num = 37;
					continue;
				case 107:
					num7 = 0;
					goto IL_0c22;
				case 113:
					try
					{
						while (true)
						{
							IL_0a2e:
							DateTime dateTime = ShamsiDate.ShamsiToGregory(((Control)n).Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
							flag = !(shamsiDate != ((Control)n).Text);
							num = 0;
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
									text = dateTime.DayOfWeek.ToString();
									num = 3;
									continue;
								case 1:
									MessageBox.Show("تاریخ پرداخت اشتباه است");
									((Control)n).Focus();
									num = 2;
									continue;
								case 2:
									return;
								case 3:
									goto end_IL_0a15;
								}
								goto IL_0a2e;
								continue;
								end_IL_0a15:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ پرداخت اشتباه است");
						((Control)n).Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 96;
					continue;
				case 84:
					num13 = 0;
					goto IL_0f5d;
				case 23:
				case 112:
					a_9 = ((Control)x).Text;
					num = 10;
					continue;
				case 10:
					num = ((!(((Control)x).Text.Trim() == "")) ? 2 : 63);
					continue;
				case 86:
				case 116:
					a_11 = ((Control)u).Text;
					num = 111;
					continue;
				case 111:
					num = ((((Control)u).Text.Trim() == "") ? 72 : 80);
					continue;
				case 121:
					if (!flag)
					{
						num = 109;
						continue;
					}
					flag = !(text == "Tuesday");
					num = 4;
					continue;
				case 18:
					if (flag)
					{
						flag2 = true;
						num = 78;
					}
					else
					{
						num = 17;
					}
					continue;
				case 106:
					if (flag)
					{
						flag2 = true;
						num = 52;
					}
					else
					{
						num = 35;
					}
					continue;
				case 56:
					num9 = 0;
					goto IL_082e;
				case 100:
					num11 = 0;
					goto IL_11d3;
				case 59:
				case 117:
					a_10 = ((Control)w).Text;
					num = 53;
					continue;
				case 53:
					num = ((!(((Control)w).Text.Trim() == "")) ? 92 : 67);
					continue;
				case 40:
					if (flag)
					{
						flag = num12 <= 0;
						num = 102;
					}
					else
					{
						num = 20;
					}
					continue;
				case 25:
					a_9 = DBNull.Value;
					num = 32;
					continue;
				case 42:
					num = 110;
					continue;
				case 110:
					num11 = ((!(((Control)q).Text == "0")) ? 1 : 0);
					goto IL_11d3;
				case 11:
					a_6 = DBNull.Value;
					num = 112;
					continue;
				case 17:
					a_8 = DBNull.Value;
					num = 50;
					continue;
				case 62:
				case 64:
					a_8 = ((Control)aa).Text;
					num = 16;
					continue;
				case 16:
					num = ((!(((Control)aa).Text.Trim() == "")) ? 71 : 91);
					continue;
				case 94:
					if (!flag)
					{
						num = 89;
						continue;
					}
					flag2 = true;
					num = 117;
					continue;
				case 28:
				case 58:
					a_4 = ((Control)r).Text;
					num = 93;
					continue;
				case 93:
					num = ((!(((Control)r).Text.Trim() == "")) ? 14 : 79);
					continue;
				case 68:
					a_5 = DBNull.Value;
					num = 58;
					continue;
				case 61:
					num = 69;
					continue;
				case 69:
					num8 = ((!(((Control)y).Text == "0")) ? 1 : 0);
					goto IL_1066;
				case 35:
					a_7 = DBNull.Value;
					num = 51;
					continue;
				case 51:
				case 52:
					a_6 = ((Control)y).Text;
					num = 47;
					continue;
				case 47:
					num = ((((Control)y).Text.Trim() == "") ? 95 : 61);
					continue;
				case 4:
					if (flag)
					{
						flag = !(text == "Wednesday");
						num = 26;
					}
					else
					{
						num = 36;
					}
					continue;
				case 46:
					if (flag)
					{
						flag2 = true;
						num = 82;
					}
					else
					{
						num = 1;
					}
					continue;
				case 32:
				case 76:
					a_3 = ((Control)ak).Text;
					num = 103;
					continue;
				case 103:
					num = ((!(((Control)ak).Text.Trim() == "")) ? 22 : 7);
					continue;
				case 96:
					if (flag)
					{
						flag = !(text == "Sunday");
						num = 119;
					}
					else
					{
						num = 9;
					}
					continue;
				case 39:
					a_4 = DBNull.Value;
					num = 33;
					continue;
				case 99:
					if (flag)
					{
						flag2 = true;
						num = 30;
					}
					else
					{
						num = 74;
					}
					continue;
				case 19:
					if (flag)
					{
						flag2 = true;
						num = 23;
					}
					else
					{
						num = 11;
					}
					continue;
				case 95:
					num8 = 0;
					goto IL_1066;
				case 90:
					num = 98;
					continue;
				case 98:
					num7 = ((!(((Control)z).Text == "0")) ? 1 : 0);
					goto IL_0c22;
				case 22:
					num = 44;
					continue;
				case 44:
					num6 = ((!(((Control)ak).Text == "0")) ? 1 : 0);
					goto IL_103c;
				case 72:
					num5 = 0;
					goto IL_0de1;
				case 74:
					a_3 = DBNull.Value;
					num = 60;
					continue;
				case 65:
					a_2 = DBNull.Value;
					num = 86;
					continue;
				case 33:
				case 57:
					a_ = ((Control)t).Text;
					num = 15;
					continue;
				case 15:
					num = ((!(((Control)t).Text.Trim() == "")) ? 49 : 84);
					continue;
				case 36:
					text = "سه شنبه";
					num = 101;
					continue;
				case 75:
					text = "یکشنبه";
					num = 108;
					continue;
				case 31:
					if (flag)
					{
						flag2 = true;
						num = 28;
					}
					else
					{
						num = 68;
					}
					continue;
				case 14:
					num = 77;
					continue;
				case 77:
					num3 = ((!(((Control)r).Text == "0")) ? 1 : 0);
					goto IL_0736;
				case 92:
					num = 5;
					continue;
				case 5:
					{
						num2 = ((!(((Control)w).Text == "0")) ? 1 : 0);
						goto IL_09bc;
					}
					IL_09bc:
					flag = (byte)num2 != 0;
					num = 70;
					continue;
					IL_082e:
					flag = (byte)num9 != 0;
					num = 34;
					continue;
					IL_1066:
					flag = (byte)num8 != 0;
					num = 19;
					continue;
					IL_0bf8:
					flag = (byte)num4 != 0;
					num = 18;
					continue;
					IL_103c:
					flag = (byte)num6 != 0;
					num = 99;
					continue;
					IL_11d3:
					flag = (byte)num11 != 0;
					num = 31;
					continue;
					IL_0736:
					flag = (byte)num3 != 0;
					num = 120;
					continue;
					IL_05eb:
					flag = (byte)num10 != 0;
					num = 97;
					continue;
					IL_0de1:
					flag = (byte)num5 != 0;
					num = 94;
					continue;
					IL_0c22:
					flag = (byte)num7 != 0;
					num = 106;
					continue;
					IL_0f5d:
					flag = (byte)num13 != 0;
					num = 46;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					num = (((int)A_1.KeyCode != 114) ? 8 : 4);
					continue;
				case 4:
					if (true)
					{
					}
					num = 7;
					continue;
				case 7:
					num2 = ((!((Control)this.m_f).Visible) ? 1 : 0);
					goto IL_008a;
				case 8:
					num2 = 1;
					goto IL_008a;
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = (int)A_1.KeyCode != 27;
					num = 9;
					continue;
				case 2:
					f(this, null);
					num = 6;
					continue;
				case 6:
					return;
				case 0:
					e(this, null);
					num = 5;
					continue;
				case 5:
					return;
				case 9:
					{
						if (!flag)
						{
							num = 0;
							continue;
						}
						return;
					}
					IL_008a:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 13;
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
					SendKeys.Send("{tab}");
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (true)
		{
		}
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromName("Window");
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Control)h).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)h).BackColor = Color.FromName("Window");
	}
}
