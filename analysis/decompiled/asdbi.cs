using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdbi : Form
{
	private ImageList m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private UIButton m_e;

	private Panel m_f;

	private UIButton m_g;

	private GridEX m_h;

	private Label m_i;

	private Label m_j;

	private Label m_k;

	private EditBox m_l;

	private EditBox m_m;

	private EditBox m_n;

	private UIButton o;

	private GridEXPrintDocument p;

	private PrintPreviewDialog q;

	private UIButton r;

	private UIButton s;

	private EditBox t;

	private EditBox u;

	private Label v;

	private EditBox w;

	private Label x;

	private MaskedEditBox y;

	private CheckBox z;

	private Label aa;

	private Label ab;

	private IContainer ac;

	private int ad;

	private int ae = 0;

	public asdbi()
	{
		b();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 0:
					num = 4;
					continue;
				case 2:
					ac.Dispose();
					num = 0;
					continue;
				case 1:
					flag = ac == null;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 4:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected Obj, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Expected Obj, but got Unknown
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected Obj, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Expected Obj, but got Unknown
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected Obj, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Expected Obj, but got Unknown
		//IL_1094: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Expected Obj, but got Unknown
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected Obj, but got Unknown
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Expected Obj, but got Unknown
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1215: Expected Obj, but got Unknown
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected Obj, but got Unknown
		//IL_1303: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d: Expected Obj, but got Unknown
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected Obj, but got Unknown
		//IL_13ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1409: Expected Obj, but got Unknown
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1425: Expected Obj, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected Obj, but got Unknown
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_1521: Expected Obj, but got Unknown
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f6: Expected Obj, but got Unknown
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected Obj, but got Unknown
		//IL_16d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16df: Expected Obj, but got Unknown
		//IL_184d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1857: Expected Obj, but got Unknown
		//IL_1af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b03: Expected Obj, but got Unknown
		if (true)
		{
		}
		ac = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbi));
		GridEXLayout val = new GridEXLayout();
		this.m_a = new ImageList(ac);
		this.m_b = new Panel();
		aa = new Label();
		ab = new Label();
		t = new EditBox();
		u = new EditBox();
		this.m_f = new Panel();
		z = new CheckBox();
		x = new Label();
		y = new MaskedEditBox();
		v = new Label();
		w = new EditBox();
		this.m_k = new Label();
		this.m_j = new Label();
		this.m_i = new Label();
		this.m_l = new EditBox();
		this.m_m = new EditBox();
		this.m_n = new EditBox();
		this.m_g = new UIButton();
		o = new UIButton();
		s = new UIButton();
		r = new UIButton();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new UIButton();
		this.m_h = new GridEX();
		p = new GridEXPrintDocument();
		q = new PrintPreviewDialog();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((ISupportInitialize)this.m_h).BeginInit();
		((Control)this).SuspendLayout();
		this.m_a.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("icons.ImageStream");
		this.m_a.TransparentColor = Color.Magenta;
		this.m_a.Images.SetKeyName(0, "");
		this.m_a.Images.SetKeyName(1, "");
		this.m_a.Images.SetKeyName(2, "");
		this.m_a.Images.SetKeyName(3, "");
		this.m_a.Images.SetKeyName(4, "");
		this.m_a.Images.SetKeyName(5, "");
		this.m_a.Images.SetKeyName(6, "");
		this.m_a.Images.SetKeyName(7, "");
		this.m_a.Images.SetKeyName(8, "");
		this.m_a.Images.SetKeyName(9, "");
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)aa);
		((Control)this.m_b).Controls.Add((Control)(object)ab);
		((Control)this.m_b).Controls.Add((Control)(object)t);
		((Control)this.m_b).Controls.Add((Control)(object)u);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Controls.Add((Control)(object)s);
		((Control)this.m_b).Controls.Add((Control)(object)r);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Location = new Point(8, 11);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(433, 560);
		((Control)this.m_b).TabIndex = 21;
		((Control)aa).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)aa).Location = new Point(126, 13);
		((Control)aa).Name = "lname1";
		((Control)aa).RightToLeft = (RightToLeft)1;
		((Control)aa).Size = new Size(77, 21);
		((Control)aa).TabIndex = 42;
		((Control)aa).Text = "نام آموزگار :";
		aa.TextAlign = (ContentAlignment)64;
		((Control)ab).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ab).Location = new Point(308, 14);
		((Control)ab).Name = "lfamily1";
		((Control)ab).RightToLeft = (RightToLeft)1;
		((Control)ab).Size = new Size(134, 21);
		((Control)ab).TabIndex = 41;
		((Control)ab).Text = "نام خانوادگي آموزگار :";
		ab.TextAlign = (ContentAlignment)64;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((Control)t).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(209, 14);
		((Control)t).Name = "txtNamlSearch";
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(96, 21);
		((Control)t).TabIndex = 2;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((EditBase)t).VisualStyle = (VisualStyle)2;
		((Control)t).TextChanged += e;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((Control)u).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(14, 14);
		((Control)u).Name = "txtNamFSearch";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(108, 21);
		((Control)u).TabIndex = 3;
		((EditBase)u).TextAlignment = (TextAlignment)1;
		((EditBase)u).VisualStyle = (VisualStyle)2;
		((Control)u).TextChanged += d;
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)z);
		((Control)this.m_f).Controls.Add((Control)(object)x);
		((Control)this.m_f).Controls.Add((Control)(object)y);
		((Control)this.m_f).Controls.Add((Control)(object)v);
		((Control)this.m_f).Controls.Add((Control)(object)w);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Controls.Add((Control)(object)o);
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(46, 190);
		((Control)this.m_f).Name = "panel3";
		((Control)this.m_f).Size = new Size(292, 177);
		((Control)this.m_f).TabIndex = 26;
		((Control)this.m_f).Visible = false;
		((Control)z).AutoSize = true;
		z.Checked = true;
		z.CheckState = (CheckState)1;
		((Control)z).Location = new Point(22, 12);
		((Control)z).Name = "checkID";
		((Control)z).Size = new Size(153, 17);
		((Control)z).TabIndex = 50;
		((Control)z).Text = "کد آموزگار به صورت اتوماتیک";
		((ButtonBase)z).UseVisualStyleBackColor = true;
		z.CheckedChanged += a;
		((Control)x).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(179, 35);
		((Control)x).Name = "l_id";
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(96, 21);
		((Control)x).TabIndex = 49;
		((Control)x).Text = "کد آموزگار :";
		x.TextAlign = (ContentAlignment)64;
		((Control)x).Visible = false;
		((EditBase)y).AutoScroll = false;
		((EditBase)y).AutoScrollMargin = new Size(0, 0);
		((EditBase)y).AutoScrollMinSize = new Size(0, 0);
		((EditBase)y).AutoScrollPosition = new Point(0, 0);
		((Control)y).Location = new Point(16, 35);
		((Control)y).Name = "txtid";
		y.Numeric = true;
		((Control)y).Size = new Size(159, 21);
		((Control)y).TabIndex = 48;
		((EditBase)y).TextAlignment = (TextAlignment)1;
		((Control)y).Visible = false;
		((Control)v).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(196, 211);
		((Control)v).Name = "label10";
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(93, 21);
		((Control)v).TabIndex = 47;
		((Control)v).Text = "کلمه عبور :";
		v.TextAlign = (ContentAlignment)64;
		((Control)v).Visible = false;
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((Control)w).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(31, 211);
		((EditBase)w).MaxLength = 50;
		((Control)w).Name = "txtPass";
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(159, 21);
		((Control)w).TabIndex = 46;
		((EditBase)w).TextAlignment = (TextAlignment)1;
		((Control)w).Visible = false;
		((EditBase)w).VisualStyle = (VisualStyle)2;
		((Control)this.m_k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_k).Location = new Point(196, 240);
		((Control)this.m_k).Name = "label9";
		((Control)this.m_k).RightToLeft = (RightToLeft)1;
		((Control)this.m_k).Size = new Size(104, 21);
		((Control)this.m_k).TabIndex = 45;
		((Control)this.m_k).Text = "پست الکترونيکي :";
		this.m_k.TextAlign = (ContentAlignment)64;
		((Control)this.m_k).Visible = false;
		((Control)this.m_j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(179, 87);
		((Control)this.m_j).Name = "lfamily2";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(109, 21);
		((Control)this.m_j).TabIndex = 40;
		((Control)this.m_j).Text = "نام خانوادگي آموزگار :";
		this.m_j.TextAlign = (ContentAlignment)64;
		((Control)this.m_i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(182, 60);
		((Control)this.m_i).Name = "lname2";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(96, 21);
		((Control)this.m_i).TabIndex = 39;
		((Control)this.m_i).Text = "نام آموزگار :";
		this.m_i.TextAlign = (ContentAlignment)64;
		((EditBase)this.m_l).AutoScroll = false;
		((EditBase)this.m_l).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_l).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Location = new Point(31, 240);
		((Control)this.m_l).Name = "txtEmail";
		((Control)this.m_l).RightToLeft = (RightToLeft)1;
		((Control)this.m_l).Size = new Size(159, 21);
		((Control)this.m_l).TabIndex = 8;
		((EditBase)this.m_l).TextAlignment = (TextAlignment)1;
		((Control)this.m_l).Visible = false;
		((EditBase)this.m_l).VisualStyle = (VisualStyle)2;
		((EditBase)this.m_m).AutoScroll = false;
		((EditBase)this.m_m).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_m).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_m).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_m).Location = new Point(17, 87);
		((Control)this.m_m).Name = "txtNamL";
		((Control)this.m_m).RightToLeft = (RightToLeft)1;
		((Control)this.m_m).Size = new Size(159, 21);
		((Control)this.m_m).TabIndex = 3;
		((EditBase)this.m_m).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_m).VisualStyle = (VisualStyle)2;
		((EditBase)this.m_n).AutoScroll = false;
		((EditBase)this.m_n).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_n).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_n).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_n).Location = new Point(17, 60);
		((Control)this.m_n).Name = "txtNamF";
		((Control)this.m_n).RightToLeft = (RightToLeft)1;
		((Control)this.m_n).Size = new Size(159, 21);
		((Control)this.m_n).TabIndex = 2;
		((EditBase)this.m_n).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_n).VisualStyle = (VisualStyle)2;
		this.m_g.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCansel.Image");
		this.m_g.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		((Control)this.m_g).Location = new Point(16, 125);
		((Control)this.m_g).Name = "btnCansel";
		((Control)this.m_g).Size = new Size(88, 32);
		((Control)this.m_g).TabIndex = 5;
		((Control)this.m_g).Text = "انصراف";
		this.m_g.VisualStyle = (VisualStyle)1;
		((Control)this.m_g).Click += j;
		o.ButtonStyle = (ButtonStyle)1;
		((Control)o).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		o.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		o.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		o.ImageIndex = 8;
		o.ImageSize = new Size(30, 30);
		((Control)o).Location = new Point(110, 125);
		((Control)o).Name = "btnAccept";
		((Control)o).Size = new Size(88, 32);
		((Control)o).TabIndex = 4;
		((Control)o).Text = "تائيد";
		o.VisualStyle = (VisualStyle)1;
		((Control)o).Click += l;
		s.ButtonStyle = (ButtonStyle)1;
		((Control)s).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		s.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		s.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		s.ImageIndex = 8;
		s.ImageSize = new Size(30, 30);
		((Control)s).Location = new Point(11, 512);
		((Control)s).Name = "uiButton1";
		((Control)s).Size = new Size(73, 40);
		((Control)s).TabIndex = 28;
		((Control)s).Text = "خروج";
		s.VisualStyle = (VisualStyle)1;
		((Control)s).Click += g;
		r.ButtonStyle = (ButtonStyle)1;
		((Control)r).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		r.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		r.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		r.ImageSize = new Size(30, 30);
		((Control)r).Location = new Point(92, 512);
		((Control)r).Name = "btnPrint";
		((Control)r).Size = new Size(73, 40);
		((Control)r).TabIndex = 27;
		((Control)r).Text = "چاپ";
		r.VisualStyle = (VisualStyle)1;
		((Control)r).Click += h;
		this.m_c.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_c).Enabled = false;
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageSize = new Size(30, 30);
		((Control)this.m_c).Location = new Point(188, 512);
		((Control)this.m_c).Name = "btnDelete";
		((Control)this.m_c).Size = new Size(73, 40);
		((Control)this.m_c).TabIndex = 2;
		((Control)this.m_c).Text = "حذف";
		this.m_c.VisualStyle = (VisualStyle)1;
		((Control)this.m_c).Click += i;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_d.ImageIndex = 8;
		((Control)this.m_d).Location = new Point(349, 512);
		((Control)this.m_d).Name = "btnNew";
		((Control)this.m_d).Size = new Size(73, 40);
		((Control)this.m_d).TabIndex = 0;
		((Control)this.m_d).Text = "جديد";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += m;
		this.m_e.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_e).Enabled = false;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_e.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(30, 30);
		((Control)this.m_e).Location = new Point(268, 512);
		((Control)this.m_e).Name = "btnEdit";
		((Control)this.m_e).Size = new Size(73, 40);
		((Control)this.m_e).TabIndex = 1;
		((Control)this.m_e).Text = "اصلاح";
		this.m_e.VisualStyle = (VisualStyle)1;
		((Control)this.m_e).Click += k;
		this.m_h.AllowEdit = (InheritableBoolean)2;
		this.m_h.CardCaptionPrefix = "Product:";
		this.m_h.ColumnAutoResize = true;
		((Control)this.m_h).Cursor = Cursors.Default;
		this.m_h.DataMember = null;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_h.DesignTimeLayout = val;
		this.m_h.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_h.ExternalImageList = this.m_a;
		((ScrollableBase)this.m_h).FlatBorderColor = SystemColors.ControlDark;
		this.m_h.FocusStyle = (FocusStyle)2;
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f);
		this.m_h.GridLineColor = SystemColors.ScrollBar;
		this.m_h.GroupByBoxInfoFormatStyle.BackColor = Color.Empty;
		this.m_h.GroupByBoxInfoFormatStyle.Key = "4545";
		this.m_h.GroupByBoxVisible = false;
		this.m_h.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		this.m_h.GroupTotalRowFormatStyle.TextAlignment = (TextAlignment)2;
		((Control)this.m_h).Location = new Point(8, 47);
		((Control)this.m_h).Name = "gteacher";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		this.m_h.RowHeaders = (InheritableBoolean)1;
		this.m_h.SelectedFormatStyle.Blend = 0.5f;
		this.m_h.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_h).Size = new Size(413, 456);
		((Control)this.m_h).TabIndex = 4;
		((Control)this.m_h).TabStop = false;
		((ScrollableBase)this.m_h).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_h).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		((Control)this.m_h).Click += c;
		this.m_h.SelectionChanged += b;
		p.GridEX = this.m_h;
		p.PageFooterLeft = "3";
		p.PageFooterRight = "2";
		p.PageHeaderCenter = "1";
		p.PageHeaderLeft = "4";
		p.PageHeaderRight = "5";
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		((Form)q).ClientSize = new Size(400, 300);
		q.Document = (PrintDocument)(object)p;
		q.Enabled = true;
		q.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)q).Name = "printPreviewDialog1";
		q.Visible = false;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = SystemColors.InactiveCaption;
		((Form)this).ClientSize = new Size(450, 583);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmTeacher";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "اطلاعات معلمان";
		((Form)this).Load += n;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((ISupportInitialize)this.m_h).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void n(object A_0, EventArgs A_1)
	{
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 1:
					flag = !(asdab.m == "3");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 9;
				case 4:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 3:
					((Control)ab).Text = "نام خانوادگي معلم :";
					((Control)this.m_j).Text = "نام خانوادگي معلم :";
					((Control)aa).Text = "نام معلم :";
					((Control)this.m_i).Text = "نام معلم :";
					((Control)x).Text = "کد معلم :";
					((Control)z).Text = "کد معلم به صورت اتوماتیک";
					num = 9;
					continue;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 10;
					continue;
				case 10:
					return;
				case 9:
					a();
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 8:
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
					num = 1;
					continue;
				case 7:
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		int num = ae;
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tteacher");
		this.m_h.DataSource = dataSource;
		try
		{
			((Control)this.m_h).Focus();
			this.m_h.Row = num - 1;
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ad = 1;
		((Control)z).Visible = true;
		((Control)this.m_f).Visible = true;
		((Control)this.m_n).Text = "";
		((Control)this.m_m).Text = "";
		((Control)this.m_n).Focus();
	}

	private void l(object A_0, EventArgs A_1)
	{
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 26;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 26:
					num = (z.Checked ? 11 : 14);
					continue;
				case 25:
					if (!flag)
					{
						num = 24;
						continue;
					}
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tTeacher SET fNamF = N'" + ((Control)this.m_n).Text.Trim() + "',fNamL = N'" + ((Control)this.m_m).Text.Trim() + "',fEmail = N'" + ((Control)this.m_l).Text.Trim() + "',fPassword = N'" + ((Control)w).Text.Trim() + "',xExportRpt=null where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					((Control)this.m_f).Visible = false;
					((Control)this.m_n).Text = "";
					((Control)this.m_m).Text = "";
					flag = !z.Checked;
					num = 2;
					continue;
				case 7:
					if (flag)
					{
						((Control)this.m_n).Text = asdaj.b(((Control)this.m_n).Text.Trim());
						((Control)this.m_m).Text = asdaj.b(((Control)this.m_m).Text.Trim());
						flag = ad != 1;
						num = 25;
					}
					else
					{
						num = 20;
					}
					continue;
				case 15:
					((Control)y).Text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,10000) from tTeacher").ToString();
					((Control)this.m_n).Focus();
					num = 21;
					continue;
				case 24:
					text = "";
					flag = !z.Checked;
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 17;
						continue;
					}
					text = ((Control)y).Text;
					flag = !("0" != asdcb.a(asdab.e(), CommandType.Text, "select count(id) from tTeacher where id=" + text).ToString());
					num = 19;
					continue;
				case 20:
					MessageBox.Show("نام خانوادگي را وارد کنيد");
					((Control)this.m_m).Focus();
					if (true)
					{
					}
					num = 5;
					continue;
				case 5:
					return;
				case 4:
					MessageBox.Show("کد معلم را وارد کنيد");
					((Control)y).Focus();
					num = 16;
					continue;
				case 16:
					return;
				case 9:
				case 27:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tTeacher (id, fNamF, fNamL,fEmail,fPassword)VALUES(" + text + ", N'" + ((Control)this.m_n).Text.Trim() + "', N'" + ((Control)this.m_m).Text.Trim() + "',N'" + ((Control)this.m_l).Text.Trim() + "', N'" + ((Control)w).Text.Trim() + "')");
					((Control)this.m_n).Text = "";
					((Control)this.m_m).Text = "";
					((Control)y).Text = "";
					flag = !z.Checked;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 18;
						continue;
					}
					((Control)y).Focus();
					num = 0;
					continue;
				case 14:
					num = 12;
					continue;
				case 12:
					num2 = ((!(((Control)y).Text == "")) ? 1 : 0);
					goto IL_0456;
				case 19:
					num = ((!flag) ? 28 : 27);
					continue;
				case 28:
					MessageBox.Show("کد معلم تکراری میباشد");
					((Control)y).Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 3:
				case 21:
					num = 8;
					continue;
				case 23:
					if (flag)
					{
						flag = !(((Control)this.m_m).Text.Trim() == "");
						num = 7;
					}
					else
					{
						num = 4;
					}
					continue;
				case 11:
					num2 = 1;
					goto IL_0456;
				case 6:
				case 8:
					f(this, null);
					num = 29;
					continue;
				case 29:
					return;
				case 18:
					((Control)this.m_n).Focus();
					num = 22;
					continue;
				case 17:
					text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,10000) from tTeacher").ToString();
					num = 9;
					continue;
				case 2:
					if (flag)
					{
						((Control)y).Text = "";
						((Control)y).Focus();
						num = 3;
					}
					else
					{
						num = 15;
					}
					continue;
				case 0:
				case 22:
					{
						num = 6;
						continue;
					}
					IL_0456:
					flag = (byte)num2 != 0;
					num = 23;
					continue;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
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
					if (this.m_h.RowCount > 0)
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
					num = 0;
					continue;
				case 0:
					num2 = (((int)this.m_h.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_013b;
				case 6:
					((Control)z).Visible = false;
					z.Checked = true;
					ad = 2;
					((Control)this.m_n).Text = this.m_h.SelectedItems[0].GetRow().Cells["fNamF"].Value.ToString();
					((Control)this.m_m).Text = this.m_h.SelectedItems[0].GetRow().Cells["fNamL"].Value.ToString();
					((Control)this.m_f).Visible = true;
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 1:
					{
						num2 = 1;
						goto IL_013b;
					}
					IL_013b:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Invalid comparison between Unknown and I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
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
					num = ((this.m_h.RowCount >= 1) ? 1 : 7);
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tTeacher where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 6;
					continue;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					MessageBox.Show("برای این معلم صنف تعریف شده است .حذف امکان پذیر نیست");
					num = 8;
					continue;
				case 7:
					num2 = 0;
					goto IL_0229;
				case 6:
					num = 12;
					continue;
				case 12:
					return;
				case 1:
					num = 0;
					continue;
				case 0:
					num2 = (((int)this.m_h.SelectedItems[0].RowType == 0) ? 1 : 0);
					goto IL_0229;
				case 9:
					flag = (int)MessageBox.Show("آيا از حذف معلم مطمئن هستيد؟", "حذف معلم", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
					if (true)
					{
					}
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 8:
					return;
				case 10:
					MessageBox.Show("معلمی انتخاب نشده است");
					num = 4;
					continue;
				case 4:
					return;
				case 13:
					{
						if (flag)
						{
							string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(xCls) FROM   tTch_Cls WHERE     (xTch = " + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")").ToString();
							flag = !(text == "0");
							num = 3;
						}
						else
						{
							num = 10;
						}
						continue;
					}
					IL_0229:
					flag = (byte)num2 != 0;
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		Rectangle bounds = ((Control)this).Bounds;
		((Form)q).SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
		q.UseAntiAlias = true;
		((Form)q).ShowDialog((IWin32Window)(object)this);
	}

	private void g(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = ae;
			string text = "";
			bool flag = !(((Control)u).Text.Trim() != "");
			int num2 = 21;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 21:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 3;
				case 25:
					((Control)this.m_h).Focus();
					this.m_h.Row = num;
					num2 = 22;
					continue;
				case 17:
					num2 = 5;
					continue;
				case 5:
					num3 = ((this.m_h.RecordCount <= num) ? 1 : 0);
					goto IL_01c1;
				case 3:
					flag = !(((Control)t).Text.Trim() != "");
					num2 = 12;
					continue;
				case 12:
					if (!flag)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 28:
					num2 = 27;
					continue;
				case 27:
					num4 = ((this.m_h.RecordCount != num) ? 1 : 0);
					goto IL_01e9;
				case 18:
					text = text + "tTeacher.fNamF like N'%" + asdaj.b(((Control)u).Text.Trim()) + "%'";
					num2 = 3;
					continue;
				case 11:
					num2 = (flag ? 13 : 25);
					continue;
				case 19:
					if (!flag)
					{
						num2 = 24;
						continue;
					}
					goto case 14;
				case 20:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tteacher" + text);
					this.m_h.DataSource = dataSource;
					num2 = 26;
					continue;
				}
				case 26:
					num2 = ((ad != 2) ? 23 : 17);
					continue;
				case 7:
					flag = !(text != "");
					num2 = 9;
					continue;
				case 9:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 8:
					num4 = 1;
					goto IL_01e9;
				case 24:
					((Control)this.m_h).Focus();
					this.m_h.Row = num - 1;
					num2 = 14;
					continue;
				case 2:
					text = text + "tTeacher.fNamL like N'%" + asdaj.b(((Control)t).Text.Trim()) + "%'";
					num2 = 1;
					continue;
				case 16:
					flag = !(text != "");
					num2 = 10;
					continue;
				case 10:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					goto case 18;
				case 4:
					text += " and ";
					num2 = 2;
					continue;
				case 0:
					text += " and ";
					num2 = 18;
					continue;
				case 1:
					if (true)
					{
					}
					flag = !(text != "");
					num2 = 6;
					continue;
				case 6:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					goto case 20;
				case 13:
					num2 = ((ad == 2) ? 28 : 8);
					continue;
				case 23:
					num3 = 1;
					goto IL_01c1;
				case 15:
					text = " where " + text;
					num2 = 20;
					continue;
				case 14:
				case 22:
					{
						ad = 1;
						return;
					}
					IL_01e9:
					flag = (byte)num4 != 0;
					num2 = 19;
					continue;
					IL_01c1:
					flag = (byte)num3 != 0;
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		f(this, null);
	}

	private void d(object A_0, EventArgs A_1)
	{
		f(this, null);
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		if (true)
		{
		}
		try
		{
			while (true)
			{
				bool flag = (int)this.m_h.SelectedItems[0].RowType == 5;
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
						((Control)this.m_c).Enabled = true;
						((Control)this.m_e).Enabled = true;
						num = 0;
						continue;
					case 0:
						num = 3;
						continue;
					case 3:
						return;
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
		ae = this.m_h.Row;
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)y).Visible = !z.Checked;
		((Control)x).Visible = !z.Checked;
	}
}
