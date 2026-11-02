using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdah : Form
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

	private UIComboBox m_n;

	private Label m_o;

	private OpenFileDialog m_p;

	private UIButton m_q;

	private Panel m_r;

	private UIButton m_s;

	private UIButton m_t;

	private Label m_u;

	private EditBox v;

	private UIButton w;

	private UIButton x;

	private GroupBox y;

	private UIButton z;

	private Panel aa;

	private UIButton ab;

	private UIButton ac;

	private UIButton ad;

	private UIButton ae;

	private UIButton af;

	private TextBox ag;

	private TextBox ah;

	private TextBox ai;

	private Button aj;

	private Button ak;

	private Button al;

	private TextBox am;

	private Button an;

	private TextBox ao;

	private Button ap;

	private TextBox aq;

	private Label ar;

	private TextBox @as;

	private Label at;

	private Button au;

	private Label av;

	private TextBox aw;

	private TextBox ax;

	private Label ay;

	private TextBox az;

	private Label a0;

	private Label a1;

	private DatePicker a2;

	private EditBox a3;

	private Label a4;

	private Button a5;

	private Label a6;

	private Label a7;

	public string a8 = "";

	protected override void a(bool A_0)
	{
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 1;
					}
					continue;
				case 4:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						((Form)this).Dispose(A_0);
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

	private void f()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected Obj, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected Obj, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected Obj, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected Obj, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected Obj, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected Obj, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected Obj, but got Unknown
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected Obj, but got Unknown
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected Obj, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected Obj, but got Unknown
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected Obj, but got Unknown
		//IL_19ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f8: Expected Obj, but got Unknown
		//IL_1a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a14: Expected Obj, but got Unknown
		//IL_1ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acf: Expected Obj, but got Unknown
		//IL_1ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af1: Expected Obj, but got Unknown
		//IL_1bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbe: Expected Obj, but got Unknown
		//IL_1dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de8: Expected Obj, but got Unknown
		//IL_2045: Unknown result type (might be due to invalid IL or missing references)
		//IL_204f: Expected Obj, but got Unknown
		//IL_2117: Unknown result type (might be due to invalid IL or missing references)
		//IL_2121: Expected Obj, but got Unknown
		//IL_224e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2258: Expected Obj, but got Unknown
		//IL_2366: Unknown result type (might be due to invalid IL or missing references)
		//IL_2370: Expected Obj, but got Unknown
		//IL_23ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f8: Expected Obj, but got Unknown
		//IL_247c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2486: Expected Obj, but got Unknown
		//IL_25c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ca: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdah));
		StringFormat val = new StringFormat();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		StringFormat val4 = new StringFormat();
		StringFormat val5 = new StringFormat();
		StringFormat val6 = new StringFormat();
		this.m_b = new Panel();
		a7 = new Label();
		a5 = new Button();
		a3 = new EditBox();
		a4 = new Label();
		this.m_q = new UIButton();
		this.m_g = new Label();
		w = new UIButton();
		y = new GroupBox();
		z = new UIButton();
		aa = new Panel();
		ab = new UIButton();
		ac = new UIButton();
		ad = new UIButton();
		ae = new UIButton();
		af = new UIButton();
		ag = new TextBox();
		ah = new TextBox();
		ai = new TextBox();
		aj = new Button();
		ak = new Button();
		al = new Button();
		am = new TextBox();
		an = new Button();
		ao = new TextBox();
		ap = new Button();
		aq = new TextBox();
		ar = new Label();
		@as = new TextBox();
		at = new Label();
		au = new Button();
		av = new Label();
		aw = new TextBox();
		ax = new TextBox();
		ay = new Label();
		az = new TextBox();
		a0 = new Label();
		a1 = new Label();
		a2 = new DatePicker();
		x = new UIButton();
		this.m_h = new UIComboBox();
		this.m_c = new Panel();
		this.m_f = new GroupBox();
		this.m_m = new Label();
		this.m_n = new UIComboBox();
		this.m_k = new Label();
		this.m_o = new Label();
		this.m_i = new Label();
		this.m_l = new UIComboBox();
		this.m_j = new UIComboBox();
		this.m_e = new ComboBox();
		a6 = new Label();
		this.m_r = new Panel();
		this.m_s = new UIButton();
		this.m_t = new UIButton();
		this.m_u = new Label();
		v = new EditBox();
		this.m_d = new Panel();
		this.m_p = new OpenFileDialog();
		((Control)this.m_b).SuspendLayout();
		((Control)y).SuspendLayout();
		((Control)aa).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((Control)this.m_r).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)a7);
		((Control)this.m_b).Controls.Add((Control)(object)a5);
		((Control)this.m_b).Controls.Add((Control)(object)a3);
		((Control)this.m_b).Controls.Add((Control)(object)a4);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_b).Controls.Add((Control)(object)w);
		((Control)this.m_b).Controls.Add((Control)(object)y);
		((Control)this.m_b).Controls.Add((Control)(object)x);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)a6);
		((Control)this.m_b).Location = new Point(4, 5);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(507, 313);
		((Control)this.m_b).TabIndex = 19;
		((Control)a7).AutoSize = true;
		((Control)a7).Font = new Font("B Nazanin", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a7).ForeColor = Color.DarkViolet;
		((Control)a7).Location = new Point(87, 3);
		((Control)a7).Name = "label2";
		((Control)a7).Size = new Size(355, 40);
		((Control)a7).TabIndex = 116;
		((Control)a7).Text = "دریافت الگوهای طراحی شده سایر مکاتب";
		((Control)a5).Anchor = (AnchorStyles)9;
		((Control)a5).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a5).Location = new Point(11, 65);
		((Control)a5).Name = "btnSelectFile";
		((Control)a5).Size = new Size(197, 35);
		((Control)a5).TabIndex = 114;
		((Control)a5).Text = "انتخاب فایل الگو";
		((ButtonBase)a5).UseVisualStyleBackColor = true;
		((Control)a5).Click += a;
		((EditBase)a3).AutoScroll = false;
		((EditBase)a3).AutoScrollMargin = new Size(0, 0);
		((EditBase)a3).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a3).AutoScrollPosition = new Point(0, 0);
		((Control)a3).Location = new Point(11, 106);
		((Control)a3).Name = "txtpath";
		((Control)a3).Size = new Size(487, 20);
		((Control)a3).TabIndex = 112;
		((EditBase)a3).TextAlignment = (TextAlignment)1;
		((Control)a4).AutoSize = true;
		((Control)a4).Font = new Font("Tahoma", 8.25f);
		((Control)a4).Location = new Point(407, 80);
		((Control)a4).Name = "label9";
		((Control)a4).Size = new Size(87, 13);
		((Control)a4).TabIndex = 113;
		((Control)a4).Text = "مسیر فایل اکسل";
		((Control)this.m_q).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_q.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_q.ImageSize = new Size(30, 30);
		((Control)this.m_q).Location = new Point(8, 211);
		((Control)this.m_q).Name = "btnNew";
		((Control)this.m_q).Size = new Size(156, 42);
		((Control)this.m_q).TabIndex = 107;
		((Control)this.m_q).Text = "ذخیره الگو در نرم افزار";
		((Control)this.m_q).Click += p;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Font = new Font("B Nazanin", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(155, 479);
		((Control)this.m_g).Name = "lBook";
		((Control)this.m_g).RightToLeft = (RightToLeft)1;
		((Control)this.m_g).Size = new Size(40, 23);
		((Control)this.m_g).TabIndex = 37;
		((Control)this.m_g).Text = "درس :";
		this.m_g.TextAlign = (ContentAlignment)32;
		((Control)w).Anchor = (AnchorStyles)10;
		((Control)w).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		w.Image = (Image)componentResourceManager.GetObject("btnView.Image");
		w.ImageSize = new Size(40, 40);
		((Control)w).Location = new Point(7, 153);
		((Control)w).Name = "btnView";
		((Control)w).Size = new Size(158, 52);
		((Control)w).TabIndex = 109;
		((Control)w).Text = "پیش نمایش";
		((Control)w).Click += r;
		((Control)y).Controls.Add((Control)(object)z);
		((Control)y).Controls.Add((Control)(object)aa);
		((Control)y).Controls.Add((Control)(object)aq);
		((Control)y).Controls.Add((Control)(object)ar);
		((Control)y).Controls.Add((Control)(object)@as);
		((Control)y).Controls.Add((Control)(object)at);
		((Control)y).Controls.Add((Control)(object)au);
		((Control)y).Controls.Add((Control)(object)av);
		((Control)y).Controls.Add((Control)(object)aw);
		((Control)y).Controls.Add((Control)(object)ax);
		((Control)y).Controls.Add((Control)(object)ay);
		((Control)y).Controls.Add((Control)(object)az);
		((Control)y).Controls.Add((Control)(object)a0);
		((Control)y).Controls.Add((Control)(object)a1);
		((Control)y).Controls.Add((Control)(object)a2);
		((Control)y).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(3, 381);
		((Control)y).Name = "groupBoxAzmoon";
		((Control)y).RightToLeft = (RightToLeft)1;
		((Control)y).Size = new Size(495, 118);
		((Control)y).TabIndex = 14;
		y.TabStop = false;
		((Control)y).Text = "تنظیمات آزمون";
		((Control)y).Visible = false;
		z.Image = (Image)componentResourceManager.GetObject("btnCancel1.Image");
		((Control)z).Location = new Point(450, 89);
		((Control)z).Name = "btnCancel1";
		((Control)z).Size = new Size(30, 22);
		((Control)z).TabIndex = 45;
		((Control)z).Click += g;
		((Control)aa).Controls.Add((Control)(object)ab);
		((Control)aa).Controls.Add((Control)(object)ac);
		((Control)aa).Controls.Add((Control)(object)ad);
		((Control)aa).Controls.Add((Control)(object)ae);
		((Control)aa).Controls.Add((Control)(object)af);
		((Control)aa).Controls.Add((Control)(object)ag);
		((Control)aa).Controls.Add((Control)(object)ah);
		((Control)aa).Controls.Add((Control)(object)ai);
		((Control)aa).Controls.Add((Control)(object)aj);
		((Control)aa).Controls.Add((Control)(object)ak);
		((Control)aa).Controls.Add((Control)(object)al);
		((Control)aa).Controls.Add((Control)(object)am);
		((Control)aa).Controls.Add((Control)(object)an);
		((Control)aa).Controls.Add((Control)(object)ao);
		((Control)aa).Controls.Add((Control)(object)ap);
		((Control)aa).Location = new Point(6, 115);
		((Control)aa).Name = "pOtherPage";
		((Control)aa).Size = new Size(484, 134);
		((Control)aa).TabIndex = 44;
		((Control)aa).Visible = false;
		ab.Image = (Image)componentResourceManager.GetObject("btnCancel6.Image");
		((Control)ab).Location = new Point(444, 109);
		((Control)ab).Name = "btnCancel6";
		((Control)ab).Size = new Size(30, 22);
		((Control)ab).TabIndex = 58;
		((Control)ab).Click += b;
		ac.Image = (Image)componentResourceManager.GetObject("btnCancel5.Image");
		((Control)ac).Location = new Point(444, 83);
		((Control)ac).Name = "btnCancel5";
		((Control)ac).Size = new Size(30, 22);
		((Control)ac).TabIndex = 57;
		((Control)ac).Click += c;
		ad.Image = (Image)componentResourceManager.GetObject("btnCancel4.Image");
		((Control)ad).Location = new Point(444, 55);
		((Control)ad).Name = "btnCancel4";
		((Control)ad).Size = new Size(30, 22);
		((Control)ad).TabIndex = 56;
		((Control)ad).Click += d;
		ae.Image = (Image)componentResourceManager.GetObject("btnCancel3.Image");
		((Control)ae).Location = new Point(444, 29);
		((Control)ae).Name = "btnCancel3";
		((Control)ae).Size = new Size(30, 22);
		((Control)ae).TabIndex = 55;
		((Control)ae).Click += e;
		af.Image = (Image)componentResourceManager.GetObject("btnCancel2.Image");
		((Control)af).Location = new Point(444, 4);
		((Control)af).Name = "btnCancel2";
		((Control)af).Size = new Size(30, 22);
		((Control)af).TabIndex = 54;
		((Control)af).Click += f;
		((Control)ag).Enabled = false;
		((Control)ag).Location = new Point(98, 110);
		((Control)ag).Name = "txtadress6";
		((Control)ag).Size = new Size(340, 21);
		((Control)ag).TabIndex = 53;
		((Control)ah).Enabled = false;
		((Control)ah).Location = new Point(98, 83);
		((Control)ah).Name = "txtadress5";
		((Control)ah).Size = new Size(340, 21);
		((Control)ah).TabIndex = 52;
		((Control)ai).Enabled = false;
		((Control)ai).Location = new Point(98, 56);
		((Control)ai).Name = "txtadress4";
		((Control)ai).Size = new Size(340, 21);
		((Control)ai).TabIndex = 51;
		((Control)aj).Location = new Point(2, 107);
		((Control)aj).Name = "btnSelectPage6";
		((Control)aj).Size = new Size(89, 23);
		((Control)aj).TabIndex = 50;
		((Control)aj).Text = "صفحه 6";
		((ButtonBase)aj).UseVisualStyleBackColor = true;
		((Control)aj).Click += h;
		((Control)ak).Location = new Point(3, 81);
		((Control)ak).Name = "btnSelectPage5";
		((Control)ak).Size = new Size(89, 23);
		((Control)ak).TabIndex = 49;
		((Control)ak).Text = "صفحه 5";
		((ButtonBase)ak).UseVisualStyleBackColor = true;
		((Control)ak).Click += i;
		((Control)al).Location = new Point(2, 56);
		((Control)al).Name = "btnSelectPage4";
		((Control)al).Size = new Size(89, 23);
		((Control)al).TabIndex = 48;
		((Control)al).Text = "صفحه 4";
		((ButtonBase)al).UseVisualStyleBackColor = true;
		((Control)al).Click += j;
		((Control)am).Enabled = false;
		((Control)am).Location = new Point(98, 30);
		((Control)am).Name = "txtadress3";
		((Control)am).Size = new Size(340, 21);
		((Control)am).TabIndex = 47;
		((Control)an).Location = new Point(2, 29);
		((Control)an).Name = "btnSelectPage3";
		((Control)an).Size = new Size(89, 23);
		((Control)an).TabIndex = 46;
		((Control)an).Text = "صفحه 3";
		((ButtonBase)an).UseVisualStyleBackColor = true;
		((Control)an).Click += k;
		((Control)ao).Enabled = false;
		((Control)ao).Location = new Point(98, 4);
		((Control)ao).Name = "txtadress2";
		((Control)ao).Size = new Size(340, 21);
		((Control)ao).TabIndex = 45;
		((Control)ap).Location = new Point(2, 4);
		((Control)ap).Name = "btnSelectPage2";
		((Control)ap).Size = new Size(91, 23);
		((Control)ap).TabIndex = 44;
		((Control)ap).Text = "صفحه 2";
		((ButtonBase)ap).UseVisualStyleBackColor = true;
		((Control)ap).Click += l;
		((Control)aq).Location = new Point(13, 47);
		((TextBoxBase)aq).MaxLength = 15;
		((Control)aq).Name = "txtStartExam";
		((Control)aq).Size = new Size(82, 21);
		((Control)aq).TabIndex = 23;
		((Control)ar).AutoSize = true;
		((Control)ar).Location = new Point(98, 51);
		((Control)ar).Name = "label11";
		((Control)ar).Size = new Size(76, 13);
		((Control)ar).TabIndex = 29;
		((Control)ar).Text = "ساعت شروع :";
		((Control)@as).Location = new Point(198, 46);
		((TextBoxBase)@as).MaxLength = 10;
		((Control)@as).Name = "txtCountQus";
		((Control)@as).Size = new Size(60, 21);
		((Control)@as).TabIndex = 22;
		((Control)at).AutoSize = true;
		((Control)at).Location = new Point(264, 51);
		((Control)at).Name = "label1";
		((Control)at).Size = new Size(66, 13);
		((Control)at).TabIndex = 28;
		((Control)at).Text = "تعداد سوال :";
		((Control)au).Location = new Point(7, 90);
		((Control)au).Name = "btnSelectPage1";
		((Control)au).Size = new Size(94, 23);
		((Control)au).TabIndex = 27;
		((Control)au).Text = "انتخاب فایل";
		((ButtonBase)au).UseVisualStyleBackColor = true;
		((Control)au).Click += q;
		((Control)av).Location = new Point(311, 72);
		((Control)av).Name = "lQusText";
		((Control)av).Size = new Size(175, 14);
		((Control)av).TabIndex = 26;
		((Control)av).Text = "مسیر عکس سوالات صفحه اول";
		av.TextAlign = (ContentAlignment)16;
		((Control)aw).Enabled = false;
		((Control)aw).Location = new Point(104, 89);
		((Control)aw).Name = "txtadress";
		((Control)aw).Size = new Size(340, 21);
		((Control)aw).TabIndex = 25;
		((Control)ax).Location = new Point(361, 46);
		((TextBoxBase)ax).MaxLength = 10;
		((Control)ax).Name = "txtCountPage";
		((Control)ax).Size = new Size(57, 21);
		((Control)ax).TabIndex = 21;
		((Control)ay).AutoSize = true;
		((Control)ay).Location = new Point(422, 50);
		((Control)ay).Name = "label5";
		((Control)ay).Size = new Size(68, 13);
		((Control)ay).TabIndex = 23;
		((Control)ay).Text = "تعداد صفحه :";
		((Control)az).Location = new Point(14, 19);
		((TextBoxBase)az).MaxLength = 50;
		((Control)az).Name = "txtTimeExam";
		((Control)az).Size = new Size(81, 21);
		((Control)az).TabIndex = 20;
		((Control)a0).AutoSize = true;
		((Control)a0).Location = new Point(102, 23);
		((Control)a0).Name = "label4";
		((Control)a0).Size = new Size(68, 13);
		((Control)a0).TabIndex = 21;
		((Control)a0).Text = "مدت امتحان :";
		((Control)a1).AutoSize = true;
		((Control)a1).Location = new Point(420, 22);
		((Control)a1).Name = "label3";
		((Control)a1).Size = new Size(68, 13);
		((Control)a1).TabIndex = 20;
		((Control)a1).Text = "تاریخ امتحان :";
		a2.AutoToday = true;
		((Control)a2).BackColor = Color.SeaShell;
		a2.BijanForeColor = Color.Blue;
		((Control)a2).Location = new Point(274, 16);
		((Control)a2).Name = "txtDateFrom";
		((Control)a2).Size = new Size(144, 24);
		((Control)a2).TabIndex = 19;
		a2.the_date = new DateTime(2020, 11, 8, 17, 15, 37, 603);
		a2.the_label = "ازمون تاريخ:";
		((Control)x).Anchor = (AnchorStyles)10;
		((Control)x).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		x.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		x.ImageSize = new Size(40, 40);
		((Control)x).Location = new Point(6, 258);
		((Control)x).Name = "btnClose";
		((Control)x).Size = new Size(159, 45);
		((Control)x).TabIndex = 111;
		((Control)x).Text = "بستن";
		((Control)x).Click += m;
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(7, 478);
		((Control)this.m_h).Name = "dropBook";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(144, 21);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val;
		((Control)this.m_h).TabIndex = 36;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(163, 428);
		((Control)this.m_c).Name = "pClass";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(336, 185);
		((Control)this.m_c).TabIndex = 103;
		((Control)this.m_f).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_f).Location = new Point(35, 41);
		((Control)this.m_f).Name = "groupBox2";
		((Control)this.m_f).Size = new Size(282, 124);
		((Control)this.m_f).TabIndex = 14;
		this.m_f.TabStop = false;
		((Control)this.m_f).Text = "انتخاب دانش آموزان برای چاپ";
		((Control)this.m_m).AutoSize = true;
		((Control)this.m_m).Location = new Point(201, 77);
		((Control)this.m_m).Name = "lStd";
		((Control)this.m_m).Size = new Size(53, 13);
		((Control)this.m_m).TabIndex = 106;
		((Control)this.m_m).Text = "دانش آموز";
		((Control)this.m_m).Visible = false;
		((UIComboBase)this.m_n).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_n).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "ترتیب";
		val2.Value = "1";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "حوزه-شماره چوکی";
		val3.Value = "2";
		this.m_n.Items.AddRange(new UIComboBoxItem[2] { val2, val3 });
		((Control)this.m_n).Location = new Point(12, 99);
		((Control)this.m_n).Name = "dropSort";
		((Control)this.m_n).Size = new Size(183, 21);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_n).StringFormat = val4;
		((Control)this.m_n).TabIndex = 109;
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Location = new Point(201, 51);
		((Control)this.m_k).Name = "label19";
		((Control)this.m_k).Size = new Size(30, 13);
		((Control)this.m_k).TabIndex = 105;
		((Control)this.m_k).Text = "صنف";
		((Control)this.m_o).AutoSize = true;
		((Control)this.m_o).Location = new Point(200, 104);
		((Control)this.m_o).Name = "lSort";
		((Control)this.m_o).Size = new Size(64, 13);
		((Control)this.m_o).TabIndex = 108;
		((Control)this.m_o).Text = "ترتیب نماش ";
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(201, 24);
		((Control)this.m_i).Name = "label20";
		((Control)this.m_i).Size = new Size(22, 13);
		((Control)this.m_i).TabIndex = 105;
		((Control)this.m_i).Text = "پایه";
		((UIComboBase)this.m_l).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_l).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Location = new Point(13, 47);
		((Control)this.m_l).Name = "dropClass";
		((Control)this.m_l).Size = new Size(183, 21);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_l).StringFormat = val5;
		((Control)this.m_l).TabIndex = 104;
		this.m_l.SelectedIndexChanged += t;
		((UIComboBase)this.m_j).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_j).DropListFont = new Font("Rod", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(13, 20);
		((Control)this.m_j).Name = "dropPaye";
		((Control)this.m_j).Size = new Size(183, 21);
		val6.Alignment = (StringAlignment)0;
		val6.FormatFlags = (StringFormatFlags)20485;
		val6.HotkeyPrefix = (HotkeyPrefix)0;
		val6.LineAlignment = (StringAlignment)1;
		val6.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_j).StringFormat = val6;
		((Control)this.m_j).TabIndex = 104;
		this.m_j.SelectedIndexChanged += s;
		this.m_e.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)this.m_e).FormattingEnabled = true;
		((Control)this.m_e).Location = new Point(13, 73);
		((Control)this.m_e).Name = "dropStd";
		((Control)this.m_e).Size = new Size(183, 21);
		((Control)this.m_e).TabIndex = 3;
		((Control)this.m_e).Visible = false;
		((Control)a6).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a6).Location = new Point(185, 186);
		((Control)a6).Name = "ltype";
		((Control)a6).RightToLeft = (RightToLeft)1;
		((Control)a6).Size = new Size(299, 96);
		((Control)a6).TabIndex = 115;
		a6.TextAlign = (ContentAlignment)32;
		((Control)this.m_r).BackColor = Color.FromArgb(214, 223, 247);
		this.m_r.BorderStyle = (BorderStyle)1;
		((Control)this.m_r).Controls.Add((Control)(object)this.m_s);
		((Control)this.m_r).Controls.Add((Control)(object)this.m_t);
		((Control)this.m_r).Controls.Add((Control)(object)this.m_u);
		((Control)this.m_r).Controls.Add((Control)(object)v);
		((Control)this.m_r).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_r).Location = new Point(173, 150);
		((Control)this.m_r).Name = "pNew";
		((Control)this.m_r).RightToLeft = (RightToLeft)1;
		((Control)this.m_r).Size = new Size(327, 116);
		((Control)this.m_r).TabIndex = 108;
		((Control)this.m_r).Visible = false;
		this.m_s.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)this.m_s).Location = new Point(40, 67);
		((Control)this.m_s).Name = "btnCancel";
		((Control)this.m_s).Size = new Size(75, 32);
		((Control)this.m_s).TabIndex = 16;
		((Control)this.m_s).Text = "انصراف";
		((Control)this.m_s).Click += o;
		this.m_t.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)this.m_t).Location = new Point(121, 67);
		((Control)this.m_t).Name = "btnAcp";
		((Control)this.m_t).Size = new Size(75, 32);
		((Control)this.m_t).TabIndex = 14;
		((Control)this.m_t).Text = "تایید";
		((Control)this.m_t).Click += n;
		((Control)this.m_u).Location = new Point(228, 22);
		((Control)this.m_u).Name = "label8";
		((Control)this.m_u).Size = new Size(86, 28);
		((Control)this.m_u).TabIndex = 1;
		((Control)this.m_u).Text = "عنوان الگو";
		this.m_u.TextAlign = (ContentAlignment)64;
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((Control)v).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(13, 19);
		((Control)v).Name = "txtNam";
		((Control)v).Size = new Size(211, 33);
		((Control)v).TabIndex = 0;
		((EditBase)v).TextAlignment = (TextAlignment)1;
		((Control)this.m_d).Anchor = (AnchorStyles)15;
		((Control)this.m_d).BackColor = SystemColors.ControlText;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_d).Location = new Point(0, 0);
		((Control)this.m_d).Name = "panel4";
		((Control)this.m_d).Size = new Size(515, 323);
		((Control)this.m_d).TabIndex = 20;
		((FileDialog)this.m_p).Filter = "الگوی طراحی 20 (*.rpx)| *.rpx";
		((FileDialog)this.m_p).Title = "فایل عکس صفحه اول سوالات امتحان";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = SystemColors.InactiveCaptionText;
		((Form)this).ClientSize = new Size(515, 323);
		((Control)this).Controls.Add((Control)(object)this.m_r);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmImportSarbargFile";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "سربرگ";
		((Form)this).Load += u;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)y).ResumeLayout(false);
		((Control)y).PerformLayout();
		((Control)aa).ResumeLayout(false);
		((Control)aa).PerformLayout();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((Control)this.m_r).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdah()
	{
		f();
	}

	private void e()
	{
		if (true)
		{
		}
		File.Copy(((Control)a3).Text, Application.StartupPath + "\\1000.rpx", overwrite: true);
		string text = Application.StartupPath + "\\1000.rpx";
	}

	private void u(object A_0, EventArgs A_1)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = asdaj.a("12");
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
					d();
					c();
					a();
					this.m_n.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.a + ") order by id");
			this.m_j.DataSource = dataSource;
			this.m_j.DisplayMember = "Name";
			this.m_j.ValueMember = "id";
			bool flag = ((CollectionBase)(object)this.m_j.Items).Count <= 0;
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
					this.m_j.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			string text = "  where  xYear=" + asdaj.a;
			bool flag = this.m_j.SelectedIndex < 0;
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
				case 2:
					this.m_l.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					return;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'تمام صنف ها' as  name\r\n                                                                                                                union select id,name from tClass" + text);
					this.m_l.DataSource = dataSource;
					this.m_l.DisplayMember = "Name";
					this.m_l.ValueMember = "id";
					flag = ((CollectionBase)(object)this.m_l.Items).Count <= 0;
					num = 3;
					continue;
				}
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 5:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student where xYear=" + asdaj.a + " and (xPaye = " + this.m_j.SelectedValue.ToString() + "))";
					num = 1;
					continue;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		Dictionary<string, string> dictionary = default;
		DataTable dataTable = default;
		int num2 = default;
		while (true)
		{
			bool flag = this.m_l.SelectedIndex < 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 13:
					flag = dictionary.Count != 0;
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 3;
						continue;
					}
					this.m_e.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)this.m_e).DisplayMember = "Value";
					((ListControl)this.m_e).ValueMember = "Key";
					num = 5;
					continue;
				case 11:
					((Control)this.m_e).Visible = false;
					((Control)this.m_m).Visible = false;
					this.m_e.DataSource = null;
					num = 12;
					continue;
				case 12:
					return;
				case 0:
					flag = !(this.m_l.SelectedValue.ToString() == "0");
					num = 4;
					continue;
				case 4:
				{
					if (!flag)
					{
						num = 11;
						continue;
					}
					((Control)this.m_e).Visible = true;
					((Control)this.m_m).Visible = true;
					string a_ = "select tStudent.id,tStudent.lname + N' - '+ tStudent.fname as name  from tstudent inner join \r\n                                 tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.status=1 and tYear_Student.xYear=" + asdaj.a + " and tYear_Student.xclass= " + this.m_l.SelectedValue.ToString() + " order by tYear_Student.sort,tStudent.lname,tStudent.fname,tStudent.id";
					dictionary = new Dictionary<string, string>();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count <= 1;
					num = 10;
					continue;
				}
				case 3:
					this.m_e.DataSource = null;
					MessageBox.Show("دانش آموزی در این صنف وجود ندارد");
					num = 6;
					continue;
				case 5:
				case 6:
					num = 16;
					continue;
				case 16:
					return;
				case 1:
					num2 = 0;
					num = 2;
					continue;
				case 10:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 1;
				case 2:
				case 9:
					flag = num2 < dataTable.Rows.Count;
					num = 7;
					continue;
				case 7:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						if (true)
						{
						}
						num = 9;
					}
					else
					{
						num = 13;
					}
					continue;
				case 15:
					dictionary.Add("0", "تمام دانش آموزان صنف");
					num = 1;
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
			bool flag = this.m_j.SelectedIndex < 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					this.m_h.DataSource = null;
					num = 6;
					continue;
				case 5:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					this.m_h.SelectedIndex = 0;
					num = 5;
					continue;
				case 4:
				{
					if (true)
					{
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tbook where xPaye=" + this.m_j.SelectedValue.ToString());
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					flag = ((CollectionBase)(object)this.m_h.Items).Count <= 0;
					num = 1;
					continue;
				}
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		b();
	}

	private void s(object A_0, EventArgs A_1)
	{
		c();
		a();
	}

	private void r(object A_0, EventArgs A_1)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		string text = default;
		string text2 = default;
		SqlConnection val = default;
		DataSet dataSet = default;
		string text3 = default;
		while (true)
		{
			bool flag = !(((Control)a3).Text == "");
			int num = 14;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 14:
					if (!flag)
					{
						num = 6;
						continue;
					}
					text = "0";
					text2 = "0";
					flag = this.m_j.SelectedIndex < 0;
					num = 18;
					continue;
				case 17:
					num2 = 1;
					goto IL_0326;
				case 2:
					val = new SqlConnection(asdab.e());
					((DbConnection)(object)val).Open();
					dataSet = new DataSet();
					text3 = "sp_SelectStdForSarbarg_Test_Type1";
					num = 21;
					continue;
				case 21:
					num = ((a8 != "1") ? 20 : 17);
					continue;
				case 1:
					return;
				case 22:
				{
					if (true)
					{
					}
					SqlCommand val2 = new SqlCommand(text3, val);
					((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
					val2.Parameters.AddWithValue("@type", (object)text);
					val2.Parameters.AddWithValue("@code", (object)text2);
					val2.Parameters.AddWithValue("@sort", (object)this.m_n.SelectedValue.ToString());
					val2.Parameters.AddWithValue("@xBook", (object)this.m_h.SelectedValue.ToString());
					val2.Parameters.AddWithValue("@DateExam", (object)ShamsiDate.GetShamsiDate(a2.the_date));
					val2.Parameters.AddWithValue("@TimeExam", (object)((Control)az).Text);
					val2.Parameters.AddWithValue("@CountPageExam", (object)((Control)ax).Text);
					val2.Parameters.AddWithValue("@CountQusExam", (object)((Control)@as).Text);
					val2.Parameters.AddWithValue("@StartExam", (object)((Control)aq).Text);
					val2.Parameters.AddWithValue("@xYear", (object)asdaj.a);
					val2.Parameters.AddWithValue("@formType", (object)a8);
					SqlDataAdapter val3 = new SqlDataAdapter(val2);
					((DbDataAdapter)(object)val3).Fill(dataSet, "v_data");
					((DbConnection)(object)val).Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 19;
					continue;
				}
				case 19:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					e();
					asdbp asdbp2 = new asdbp();
					asdbp2.a(dataSet, dataSet.Tables[0].TableName, ((Control)aw).Text, ((Control)ao).Text, ((Control)am).Text, ((Control)ai).Text, ((Control)ah).Text, ((Control)ag).Text);
					((Form)asdbp2).ShowDialog();
					((Component)(object)asdbp2).Dispose();
					num = 10;
					continue;
				}
				case 18:
					if (flag)
					{
						MessageBox.Show("پایه ای انتخاب نشده است");
						num = 1;
					}
					else
					{
						num = 0;
					}
					continue;
				case 9:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 22;
				case 13:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 16;
					continue;
				case 16:
					return;
				case 5:
					num = 2;
					continue;
				case 15:
					flag = this.m_l.SelectedIndex < 0;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					MessageBox.Show("صنفی ای انتخاب نشده است");
					num = 24;
					continue;
				case 7:
					text3 = "sp_SelectStdForSarbarg_Test_Type2";
					num = 22;
					continue;
				case 10:
					return;
				case 3:
					flag = !(this.m_l.SelectedValue.ToString() != "0");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 5;
				case 6:
					MessageBox.Show("الگویی انتخاب نشده است");
					num = 12;
					continue;
				case 12:
					return;
				case 0:
					text = "1";
					text2 = this.m_j.SelectedValue.ToString();
					num = 15;
					continue;
				case 23:
					text = "2";
					text2 = this.m_l.SelectedValue.ToString();
					num = 5;
					continue;
				case 24:
					return;
				case 20:
					num = 11;
					continue;
				case 11:
					{
						num2 = ((!(a8 != "5")) ? 1 : 0);
						goto IL_0326;
					}
					IL_0326:
					flag = (byte)num2 != 0;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_p).ShowDialog() != 1;
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
					((Control)aw).Text = ((FileDialog)this.m_p).FileName;
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

	private void p(object A_0, EventArgs A_1)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)a3).Text == "");
			int num = 3;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					((Control)this.m_b).Enabled = false;
					((Control)this.m_r).Visible = true;
					((Control)v).Text = "";
					((Control)v).Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					MessageBox.Show("الگویی انتخاب نشده است");
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)this.m_b).Enabled = true;
		((Control)this.m_r).Visible = false;
	}

	private void n(object A_0, EventArgs A_1)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)v).Text.Trim() == "");
			if (true)
			{
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 2;
						continue;
					}
					FileStream fileStream = File.OpenRead(((Control)a3).Text);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, (int)fileStream.Length);
					fileStream.Close();
					string text = ((Control)v).Text;
					SqlParameter[] a_ = new SqlParameter[3]
					{
						asdcb.a("@Rpt", SqlDbType.Image, array),
						asdcb.a("@type", SqlDbType.Int, a8),
						asdcb.a("@Caption", SqlDbType.NVarChar, 200, text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "declare @idAdd int\r\n                        select @idAdd=isnull (max(id)+1,1001) from tRptDynamic where id>100\r\n                        INSERT into tRptDynamic (id, Caption, Rpt, sys, type) \r\n                        values (@idAdd,@Caption,@Rpt,0,@type)", a_);
					asdt asdt2 = new asdt();
					asdt2.bx = a8;
					((Form)asdt2).ShowDialog();
					((Form)this).Close();
					((Control)this.m_b).Enabled = true;
					((Control)this.m_r).Visible = false;
					num = 3;
					continue;
				}
				case 3:
					return;
				case 2:
					MessageBox.Show("عنوان الگو جدید را وارد کنید");
					((Control)v).Focus();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private string a(string A_0)
	{
		string result = default;
		while (true)
		{
			string text = "";
			bool flag = !(A_0 == "kbrqazwsx");
			int num = 10;
			while (true)
			{
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = !(A_0 == "kbredcrfv");
					num = 2;
					continue;
				case 12:
					text += "5";
					num = 3;
					continue;
				case 0:
					text = "4";
					num = 6;
					continue;
				case 5:
					text = "2";
					num = 9;
					continue;
				case 4:
					if (true)
					{
					}
					text = "6";
					num = 13;
					continue;
				case 2:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(A_0 == "kbrtgbyhn");
					num = 17;
					continue;
				case 14:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(A_0 == "kbrtfcefv");
					num = 16;
					continue;
				case 1:
				case 3:
				case 6:
				case 9:
				case 11:
				case 13:
					result = text;
					num = 18;
					continue;
				case 7:
					text = "3";
					num = 11;
					continue;
				case 8:
					text = "1";
					num = 1;
					continue;
				case 16:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 15:
					if (flag)
					{
						flag = !(A_0 == "kbrolpkio");
						num = 14;
					}
					else
					{
						num = 0;
					}
					continue;
				case 17:
					if (flag)
					{
						flag = !(A_0 == "kbrujmiko");
						num = 15;
					}
					else
					{
						num = 7;
					}
					continue;
				case 18:
					return result;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_p).ShowDialog() != 1;
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
					return;
				case 2:
					((Control)ao).Text = ((FileDialog)this.m_p).FileName;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		if (true)
		{
		}
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_p).ShowDialog() != 1;
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
					((Control)am).Text = ((FileDialog)this.m_p).FileName;
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_p).ShowDialog() != 1;
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
					((Control)ai).Text = ((FileDialog)this.m_p).FileName;
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

	private void i(object A_0, EventArgs A_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_p).ShowDialog() != 1;
			if (true)
			{
			}
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
					((Control)ah).Text = ((FileDialog)this.m_p).FileName;
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_p).ShowDialog() != 1;
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
					((Control)ag).Text = ((FileDialog)this.m_p).FileName;
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

	private void g(object A_0, EventArgs A_1)
	{
		((Control)aw).Text = "";
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Control)ao).Text = "";
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Control)am).Text = "";
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Control)ai).Text = "";
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)ah).Text = "";
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Control)ag).Text = "";
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between I4 and Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		string[] array = default;
		while (true)
		{
			bool flag = 1 != (int)((CommonDialog)this.m_p).ShowDialog();
			int num = 20;
			while (true)
			{
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 10;
						continue;
					}
					return;
				case 12:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					a8 = "";
					((Control)a3).Text = "";
					MessageBox.Show("فایل انتخاب شده اشتباه است");
					num = 3;
					continue;
				case 21:
					if (flag)
					{
						flag = !(text == "6");
						num = 12;
					}
					else
					{
						num = 11;
					}
					continue;
				case 7:
					if (!flag)
					{
						num = 24;
						continue;
					}
					flag = !(text == "3");
					num = 4;
					continue;
				case 2:
				case 9:
				case 17:
				case 22:
				case 23:
				case 25:
					num = 1;
					continue;
				case 0:
					text = a(array[0]);
					flag = !(text == "1");
					num = 19;
					continue;
				case 19:
					if (flag)
					{
						flag = !(text == "2");
						num = 7;
					}
					else
					{
						num = 15;
					}
					continue;
				case 5:
					a8 = "6";
					((Control)a6).Text = "طراحی کارت تبریک تولد";
					num = 25;
					continue;
				case 14:
					return;
				case 18:
					if (flag)
					{
						flag = !(text == "5");
						num = 21;
					}
					else
					{
						num = 13;
					}
					continue;
				case 24:
					a8 = "2";
					((Control)a6).Text = "طراحی دعوت نامه و ...";
					num = 9;
					continue;
				case 3:
					return;
				case 1:
					num = 6;
					continue;
				case 6:
					return;
				case 4:
					if (flag)
					{
						flag = !(text == "4");
						num = 18;
					}
					else
					{
						num = 16;
					}
					continue;
				case 10:
				{
					((Control)a3).Text = ((FileDialog)this.m_p).FileName;
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(((FileDialog)this.m_p).FileName);
					array = fileNameWithoutExtension.Split(new char[1] { '-' });
					flag = array.Length <= 0;
					num = 8;
					continue;
				}
				case 8:
					if (flag)
					{
						((Control)a6).Text = "";
						((Control)a3).Text = "";
						MessageBox.Show("فایل انتخاب شده اشتباه است");
						num = 14;
					}
					else
					{
						num = 0;
					}
					continue;
				case 15:
					a8 = "1";
					((Control)a6).Text = "طراحی سربرگ امتحانی تک صفحه";
					num = 22;
					continue;
				case 16:
					a8 = "3";
					((Control)a6).Text = "طراحی فرم(تعهدنامه انضباطی و ...)";
					num = 23;
					continue;
				case 13:
					a8 = "4";
					((Control)a6).Text = "طراحی کارت دانش آموزی و ...";
					num = 17;
					continue;
				case 11:
					a8 = "5";
					((Control)a6).Text = "طراحی سربرگ امتحانی چند صفحه ای";
					num = 2;
					continue;
				}
				break;
			}
		}
	}
}
