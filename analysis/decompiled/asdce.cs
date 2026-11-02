using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdce : Form
{
	private Panel m_a;

	private Panel m_b;

	private Panel m_c;

	private GridEX m_d;

	private UIButton m_e;

	private CheckBox m_f;

	private CheckBox g;

	private TextBox h;

	private CheckBox i;

	private UIGroupBox j;

	private CheckBox k;

	private Label l;

	private Label m;

	private TextBox n;

	private Label o;

	private Label p;

	private TextBox q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private EditBox v;

	private UIButton w;

	private UIButton x;

	private Label y;

	private ProgressBar z;

	private CheckBox aa;

	private CheckBox ab;

	private Label ac;

	private UIComboBox ad;

	private GridEX ae;

	private Label af;

	private UIComboBox ag;

	private FolderBrowserDialog ah;

	private Container ai = null;

	private string aj = Application.StartupPath + "\\xls\\sms.xls";

	public asdce()
	{
		e();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
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
						num = 3;
						continue;
					}
					goto case 4;
				case 1:
					num = 4;
					continue;
				case 5:
					ai.Dispose();
					num = 1;
					continue;
				case 3:
					flag = ai == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
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

	private void e()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected Obj, but got Unknown
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected Obj, but got Unknown
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected Obj, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc4: Expected Obj, but got Unknown
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected Obj, but got Unknown
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee8: Expected Obj, but got Unknown
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected Obj, but got Unknown
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected Obj, but got Unknown
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected Obj, but got Unknown
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected Obj, but got Unknown
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fe: Expected Obj, but got Unknown
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1468: Expected Obj, but got Unknown
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Expected Obj, but got Unknown
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Expected Obj, but got Unknown
		//IL_15eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Expected Obj, but got Unknown
		//IL_16f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fb: Expected Obj, but got Unknown
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb0));
		StringFormat val = new StringFormat();
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
		GridEXLayout val4 = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		aa = new CheckBox();
		ab = new CheckBox();
		y = new Label();
		z = new ProgressBar();
		x = new UIButton();
		v = new EditBox();
		w = new UIButton();
		j = new UIGroupBox();
		o = new Label();
		p = new Label();
		q = new TextBox();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		h = new TextBox();
		k = new CheckBox();
		l = new Label();
		m = new Label();
		n = new TextBox();
		i = new CheckBox();
		this.m_f = new CheckBox();
		g = new CheckBox();
		this.m_e = new UIButton();
		this.m_c = new Panel();
		af = new Label();
		ag = new UIComboBox();
		ac = new Label();
		ad = new UIComboBox();
		ae = new GridEX();
		this.m_d = new GridEX();
		ah = new FolderBrowserDialog();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((Control)j).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)ae).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(8, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(751, 615);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)aa);
		((Control)this.m_b).Controls.Add((Control)(object)ab);
		((Control)this.m_b).Controls.Add((Control)(object)y);
		((Control)this.m_b).Controls.Add((Control)(object)z);
		((Control)this.m_b).Controls.Add((Control)(object)x);
		((Control)this.m_b).Controls.Add((Control)(object)v);
		((Control)this.m_b).Controls.Add((Control)(object)w);
		((Control)this.m_b).Controls.Add((Control)(object)j);
		((Control)this.m_b).Controls.Add((Control)(object)i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Controls.Add((Control)(object)g);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(8, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(733, 597);
		((Control)this.m_b).TabIndex = 16;
		((Control)aa).AutoSize = true;
		((Control)aa).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)aa).Location = new Point(119, 506);
		((Control)aa).Name = "checksendTo2";
		((Control)aa).RightToLeft = (RightToLeft)1;
		((Control)aa).Size = new Size(130, 17);
		((Control)aa).TabIndex = 65;
		((Control)aa).Text = "ارسال برای موبایل مادر";
		((ButtonBase)aa).UseVisualStyleBackColor = true;
		((Control)ab).AutoSize = true;
		((Control)ab).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ab).Location = new Point(273, 506);
		((Control)ab).Name = "checksendTo1";
		((Control)ab).RightToLeft = (RightToLeft)1;
		((Control)ab).Size = new Size(125, 17);
		((Control)ab).TabIndex = 64;
		((Control)ab).Text = "ارسال برای موبایل پدر";
		((ButtonBase)ab).UseVisualStyleBackColor = true;
		((Control)y).AutoSize = true;
		((Control)y).Font = new Font("Tahoma", 8.25f);
		((Control)y).Location = new Point(306, 442);
		((Control)y).Name = "label9";
		((Control)y).Size = new Size(87, 13);
		((Control)y).TabIndex = 63;
		((Control)y).Text = "مسیر فایل اکسل";
		((Control)z).Location = new Point(7, 539);
		((Control)z).Name = "pr12";
		((Control)z).Size = new Size(437, 16);
		((Control)z).TabIndex = 60;
		((Control)x).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		x.ImageSize = new Size(30, 30);
		((Control)x).Location = new Point(297, 561);
		((Control)x).Name = "btnProcc";
		((Control)x).Size = new Size(147, 25);
		((Control)x).TabIndex = 59;
		((Control)x).Text = "ایجاد فایل";
		((Control)x).Click += d;
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((Control)v).Location = new Point(88, 458);
		((Control)v).Name = "txtpath";
		((Control)v).Size = new Size(305, 20);
		((Control)v).TabIndex = 58;
		((EditBase)v).TextAlignment = (TextAlignment)1;
		((Control)w).Font = new Font("Tahoma", 8.25f);
		((Control)w).Location = new Point(7, 457);
		((Control)w).Name = "btnselectPath";
		((Control)w).Size = new Size(75, 20);
		((Control)w).TabIndex = 57;
		((Control)w).Text = "انتخاب مسير";
		((Control)w).Click += e;
		((Control)j).Controls.Add((Control)(object)o);
		((Control)j).Controls.Add((Control)(object)p);
		((Control)j).Controls.Add((Control)(object)q);
		((Control)j).Controls.Add((Control)(object)r);
		((Control)j).Controls.Add((Control)(object)s);
		((Control)j).Controls.Add((Control)(object)t);
		((Control)j).Controls.Add((Control)(object)u);
		((Control)j).Controls.Add((Control)(object)h);
		((Control)j).Controls.Add((Control)(object)k);
		((Control)j).Controls.Add((Control)(object)l);
		((Control)j).Controls.Add((Control)(object)m);
		((Control)j).Controls.Add((Control)(object)n);
		((Control)j).Font = new Font("Tahoma", 8.25f);
		((Control)j).Location = new Point(41, 75);
		((Control)j).Name = "uiGroupBox1";
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(386, 318);
		((Control)j).TabIndex = 56;
		((Control)j).Text = "ترکیب پیام ارسالی";
		((Control)o).AutoSize = true;
		((Control)o).Font = new Font("Tahoma", 8.25f);
		((Control)o).Location = new Point(180, 244);
		((Control)o).Name = "label8";
		((Control)o).Size = new Size(15, 13);
		((Control)o).TabIndex = 62;
		((Control)o).Text = "+";
		((Control)p).AutoSize = true;
		((Control)p).Font = new Font("Tahoma", 8.25f);
		((Control)p).Location = new Point(312, 274);
		((Control)p).Name = "label7";
		((Control)p).Size = new Size(60, 13);
		((Control)p).TabIndex = 61;
		((Control)p).Text = "جمله پایانی";
		((Control)q).Location = new Point(35, 269);
		((Control)q).Name = "txtfoter";
		((Control)q).Size = new Size(273, 21);
		((Control)q).TabIndex = 60;
		((Control)r).AutoSize = true;
		((Control)r).Font = new Font("Tahoma", 8.25f);
		((Control)r).Location = new Point(128, 216);
		((Control)r).Name = "label6";
		((Control)r).Size = new Size(102, 13);
		((Control)r).TabIndex = 59;
		((Control)r).Text = "نام درس + نمره و ...";
		((Control)s).AutoSize = true;
		((Control)s).Font = new Font("Tahoma", 8.25f);
		((Control)s).Location = new Point(180, 193);
		((Control)s).Name = "label5";
		((Control)s).Size = new Size(15, 13);
		((Control)s).TabIndex = 58;
		((Control)s).Text = "+";
		((Control)t).AutoSize = true;
		((Control)t).Font = new Font("Tahoma", 8.25f);
		((Control)t).Location = new Point(180, 124);
		((Control)t).Name = "label4";
		((Control)t).Size = new Size(15, 13);
		((Control)t).TabIndex = 57;
		((Control)t).Text = "+";
		((Control)u).AutoSize = true;
		((Control)u).Font = new Font("Tahoma", 8.25f);
		((Control)u).Location = new Point(180, 65);
		((Control)u).Name = "label3";
		((Control)u).Size = new Size(15, 13);
		((Control)u).TabIndex = 56;
		((Control)u).Text = "+";
		((Control)h).Location = new Point(34, 31);
		((Control)h).Name = "txtheder1";
		((Control)h).Size = new Size(272, 21);
		((Control)h).TabIndex = 51;
		((Control)k).AutoSize = true;
		((Control)k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(125, 101);
		((Control)k).Name = "checkNameStd";
		((Control)k).RightToLeft = (RightToLeft)1;
		((Control)k).Size = new Size(157, 17);
		((Control)k).TabIndex = 55;
		((Control)k).Text = "نام و نام خانوادگی شاگرد";
		((ButtonBase)k).UseVisualStyleBackColor = true;
		((Control)l).AutoSize = true;
		((Control)l).Font = new Font("Tahoma", 8.25f);
		((Control)l).Location = new Point(310, 35);
		((Control)l).Name = "label1";
		((Control)l).Size = new Size(67, 13);
		((Control)l).TabIndex = 52;
		((Control)l).Text = "جمله ابتدایی";
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("Tahoma", 8.25f);
		((Control)m).Location = new Point(310, 160);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(59, 13);
		((Control)m).TabIndex = 54;
		((Control)m).Text = "جمله بعدی";
		((Control)n).Location = new Point(34, 157);
		((Control)n).Name = "txtheder2";
		((Control)n).Size = new Size(272, 21);
		((Control)n).TabIndex = 53;
		((Control)i).AutoSize = true;
		i.Checked = true;
		i.CheckState = (CheckState)1;
		((Control)i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(98, 37);
		((Control)i).Name = "checkgkolli";
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(83, 17);
		((Control)i).TabIndex = 49;
		((Control)i).Text = "رتبه در معدل";
		((ButtonBase)i).UseVisualStyleBackColor = true;
		((Control)this.m_f).AutoSize = true;
		this.m_f.Checked = true;
		this.m_f.CheckState = (CheckState)1;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(240, 37);
		((Control)this.m_f).Name = "checkmKolli";
		((Control)this.m_f).RightToLeft = (RightToLeft)1;
		((Control)this.m_f).Size = new Size(81, 17);
		((Control)this.m_f).TabIndex = 48;
		((Control)this.m_f).Text = "معدل دروس";
		((ButtonBase)this.m_f).UseVisualStyleBackColor = true;
		((Control)g).AutoSize = true;
		((Control)g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)g).Location = new Point(353, 37);
		((Control)g).Name = "checkgbook";
		((Control)g).RightToLeft = (RightToLeft)1;
		((Control)g).Size = new Size(68, 17);
		((Control)g).TabIndex = 47;
		((Control)g).Text = "رتبه درس";
		((ButtonBase)g).UseVisualStyleBackColor = true;
		this.m_e.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		this.m_e.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_e.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(20, 20);
		((Control)this.m_e).Location = new Point(7, 561);
		((Control)this.m_e).Name = "uiButton2";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(123, 25);
		((Control)this.m_e).TabIndex = 46;
		((Control)this.m_e).Text = "خروج";
		this.m_e.VisualStyle = (VisualStyle)1;
		((Control)this.m_e).Click += f;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)af);
		((Control)this.m_c).Controls.Add((Control)(object)ag);
		((Control)this.m_c).Controls.Add((Control)(object)ac);
		((Control)this.m_c).Controls.Add((Control)(object)ad);
		((Control)this.m_c).Controls.Add((Control)(object)ae);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Location = new Point(450, 4);
		((Control)this.m_c).Name = "panel3";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(272, 579);
		((Control)this.m_c).TabIndex = 36;
		((Control)af).Anchor = (AnchorStyles)9;
		((Control)af).AutoSize = true;
		((Control)af).Location = new Point(237, 17);
		((Control)af).Name = "label10";
		((Control)af).Size = new Size(29, 13);
		((Control)af).TabIndex = 128;
		((Control)af).Text = "دوره";
		((Control)ag).Anchor = (AnchorStyles)9;
		((UIComboBase)ag).ComboStyle = (ComboStyle)1;
		((UIComboBase)ag).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ag).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ag).Location = new Point(4, 14);
		((Control)ag).Name = "dropExam";
		((Control)ag).Size = new Size(232, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)ag).StringFormat = val;
		((Control)ag).TabIndex = 127;
		ag.SelectedIndexChanged += a;
		((Control)ac).Anchor = (AnchorStyles)9;
		((Control)ac).AutoSize = true;
		((Control)ac).Location = new Point(242, 50);
		((Control)ac).Name = "label20";
		((Control)ac).Size = new Size(24, 13);
		((Control)ac).TabIndex = 126;
		((Control)ac).Text = "پایه";
		((Control)ad).Anchor = (AnchorStyles)9;
		((UIComboBase)ad).ComboStyle = (ComboStyle)1;
		((UIComboBase)ad).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ad).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ad).Location = new Point(3, 46);
		((Control)ad).Name = "dropPaye";
		((Control)ad).RightToLeft = (RightToLeft)1;
		((Control)ad).Size = new Size(233, 20);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)ad).StringFormat = val2;
		((Control)ad).TabIndex = 125;
		ad.SelectedIndexChanged += c;
		((Control)ae).Anchor = (AnchorStyles)10;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		ae.DesignTimeLayout = val3;
		ae.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)ae).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		ae.GroupByBoxVisible = false;
		((Control)ae).Location = new Point(8, 72);
		((Control)ae).Name = "gClass";
		((Control)ae).RightToLeft = (RightToLeft)1;
		ae.RowHeaders = (InheritableBoolean)1;
		((Control)ae).Size = new Size(240, 116);
		((Control)ae).TabIndex = 124;
		((ScrollableBase)ae).VisualStyle = (VisualStyle)2;
		this.m_d.CardCaptionPrefix = "Product:";
		((Control)this.m_d).Cursor = Cursors.Default;
		this.m_d.DataMember = null;
		val4.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_d.DesignTimeLayout = val4;
		this.m_d.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)this.m_d).FlatBorderColor = SystemColors.ControlDark;
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f);
		this.m_d.GridLineColor = SystemColors.ScrollBar;
		this.m_d.GroupByBoxVisible = false;
		this.m_d.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)this.m_d).Location = new Point(6, 194);
		((Control)this.m_d).Name = "gBook";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		this.m_d.RowHeaders = (InheritableBoolean)1;
		this.m_d.SelectedFormatStyle.Blend = 0.5f;
		this.m_d.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_d).Size = new Size(240, 368);
		((Control)this.m_d).TabIndex = 39;
		((ScrollableBase)this.m_d).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_d).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(767, 633);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmSendSmsMark";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "دریافت فایل اکسل نمرات برای ارسال پیامک";
		((Form)this).Load += b;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((ISupportInitialize)j).EndInit();
		((Control)j).ResumeLayout(false);
		((Control)j).PerformLayout();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)ae).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam order by id desc");
			ag.DataSource = dataSource;
			ag.DisplayMember = "Name";
			ag.ValueMember = "id";
			bool flag = ((CollectionBase)(object)ag.Items).Count <= 0;
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
					ag.SelectedIndex = 0;
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

	private void c()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			ad.DataSource = dataSource;
			ad.DisplayMember = "Name";
			ad.ValueMember = "id";
			bool flag = ((CollectionBase)(object)ad.Items).Count <= 0;
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
					ad.SelectedIndex = 0;
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

	private void b()
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					num = ((ad.SelectedIndex < 0) ? 2 : 3);
					continue;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT DISTINCT tBook.id, tBook.Name,tBook.sort\r\n                                    FROM         tMark INNER JOIN\r\n                                                          tBook ON tMark.xbook = tBook.id\r\n                                    WHERE     tBook.xPaye =" + ad.SelectedValue.ToString() + " AND tMark.Xtest = " + ag.SelectedValue.ToString() + " ORDER BY tBook.sort");
					this.m_d.DataSource = dataSource;
					num = 1;
					continue;
				}
				case 1:
					return;
				case 7:
					return;
				case 2:
					num2 = 1;
					goto IL_0124;
				case 3:
					if (true)
					{
					}
					num = 6;
					continue;
				case 6:
					num2 = ((ag.SelectedIndex < 0) ? 1 : 0);
					goto IL_0124;
				case 4:
					{
						if (flag)
						{
							this.m_d.DataSource = null;
							num = 7;
						}
						else
						{
							num = 5;
						}
						continue;
					}
					IL_0124:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		while (true)
		{
			string text = "";
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (ad.SelectedIndex >= 0)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						num = 5;
					}
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					num2 = ((!(ad.SelectedValue.ToString() != "0")) ? 1 : 0);
					goto IL_00b4;
				case 1:
					text = " where xPaye=" + ad.SelectedValue.ToString();
					num = 6;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 6;
				case 5:
					num2 = 1;
					goto IL_00b4;
				case 6:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass" + text);
						ae.DataSource = dataSource;
						return;
					}
					IL_00b4:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		while (true)
		{
			DialogResult val = ((CommonDialog)ah).ShowDialog();
			bool flag = (int)val != 1;
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
						num = 1;
						continue;
					}
					return;
				case 3:
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					((Control)v).Text = ah.SelectedPath;
					num = 3;
					continue;
				case 1:
					flag = !(ah.SelectedPath != "");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Invalid comparison between Unknown and I4
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		string text3 = default;
		string text2 = default;
		DataTable dataTable = default;
		string a_5 = default;
		bool flag = default;
		string[] array = default;
		int num3 = default;
		while (true)
		{
			string text = "-1";
			int num = 55;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 55:
					num = ((!ab.Checked) ? 6 : 50);
					continue;
				case 40:
				{
					SqlParameter[] a_4 = new SqlParameter[11]
					{
						asdcb.a("@sendTo", SqlDbType.SmallInt, text),
						asdcb.a("@gBook", SqlDbType.SmallInt, g.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@mKolli", SqlDbType.SmallInt, this.m_f.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@gkolli", SqlDbType.SmallInt, i.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@NameStd", SqlDbType.SmallInt, k.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@test", SqlDbType.Int, ag.SelectedValue.ToString()),
						asdcb.a("@xbook", SqlDbType.VarChar, 200, text3),
						asdcb.a("@xClass", SqlDbType.VarChar, 200, text2),
						asdcb.a("@heder1", SqlDbType.NVarChar, 200, ((Control)h).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, 200, ((Control)n).Text),
						asdcb.a("@foter", SqlDbType.NVarChar, 200, ((Control)q).Text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_5, a_4);
					flag = dataTable.Rows.Count != 0;
					num = 51;
					continue;
				}
				case 51:
				{
					if (!flag)
					{
						num = 70;
						continue;
					}
					string a_ = asdab.c("VkFBd0FGSUFWZ0JsQUZFQVBRQTlBQT09");
					string a_2 = "tavakoli";
					string a_3 = "50004646138609";
					string text4 = asdz.a("09902922484", dataTable.Rows[0]["message"].ToString(), a_2, a_, a_3);
					array = text4.Split(new char[1] { '-' });
					flag = !(array[0] == "1");
					num = 31;
					continue;
				}
				case 59:
				{
					SqlParameter[] a_6 = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, ag.SelectedValue.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_6);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_6);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_6);
					num = 16;
					continue;
				}
				case 68:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(array[0] == "4");
					num = 62;
					continue;
				case 11:
					if (!flag)
					{
						num = 72;
						continue;
					}
					goto case 0;
				case 53:
					a_5 = "CreateMsg_tosifi";
					num = 40;
					continue;
				case 7:
					if (!flag)
					{
						num = 69;
						continue;
					}
					flag = !(array[0] == "2");
					num = 71;
					continue;
				case 16:
					flag = !(text3 == "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 35;
				case 37:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 21;
				case 62:
					if (flag)
					{
						flag = !(array[0] == "3");
						num = 7;
					}
					else
					{
						num = 8;
					}
					continue;
				case 13:
					num = 1;
					continue;
				case 1:
					return;
				case 64:
					if (!flag)
					{
						num = 45;
						continue;
					}
					goto case 52;
				case 50:
					num = 54;
					continue;
				case 54:
					num2 = ((!aa.Checked) ? 1 : 0);
					goto IL_09e4;
				case 46:
					MessageBox.Show("برای ارسال باید یکی از آیتمهای پدر یا مادر انتخاب شود");
					((Control)ab).Focus();
					num = 58;
					continue;
				case 58:
					return;
				case 72:
					text = "2";
					num = 0;
					continue;
				case 63:
					text2 += ",";
					num = 5;
					continue;
				case 8:
					num = 49;
					continue;
				case 49:
					return;
				case 19:
					MessageBox.Show("ارسال شد");
					num = 41;
					continue;
				case 41:
					return;
				case 42:
					MessageBox.Show(" هیچ صنفی انتخاب نشده است");
					((Control)ae).Focus();
					num = 3;
					continue;
				case 3:
					return;
				case 65:
					num = 4;
					continue;
				case 4:
					return;
				case 21:
					num3++;
					num = 66;
					continue;
				case 0:
				case 22:
				case 28:
					flag = !(text == "-1");
					num = 29;
					continue;
				case 29:
					if (flag)
					{
						text2 = "";
						num3 = 0;
						num = 30;
					}
					else
					{
						num = 46;
					}
					continue;
				case 24:
					MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است-در قسمت تنظیمات ارسال پیامک شماره تنظیم شود");
					num = 27;
					continue;
				case 27:
					return;
				case 30:
				case 66:
					flag = num3 < ae.RowCount;
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						flag = !(ae.GetRow(num3).Cells[0].Value.ToString() == "True");
						num = 37;
					}
					else
					{
						num = 44;
					}
					continue;
				case 5:
					text2 += ae.GetRow(num3).Cells["id"].Value.ToString();
					num = 21;
					continue;
				case 56:
					flag = !(text2 != "");
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 63;
						continue;
					}
					goto case 5;
				case 48:
				{
					string text5 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + ag.SelectedValue.ToString()).ToString();
					flag = !(text5 != "1");
					num = 14;
					continue;
				}
				case 14:
					if (!flag)
					{
						num = 59;
						continue;
					}
					goto case 16;
				case 6:
					num2 = 1;
					goto IL_09e4;
				case 10:
				case 36:
					flag = num3 < this.m_d.RowCount;
					num = 38;
					continue;
				case 38:
					if (flag)
					{
						flag = !(this.m_d.GetRow(num3).Cells[0].Value.ToString() == "True");
						num = 64;
					}
					else
					{
						num = 48;
					}
					continue;
				case 45:
					if (true)
					{
					}
					flag = !(text3 != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 23;
				case 34:
					if (flag)
					{
						flag = !(array[0] == "5");
						num = 68;
					}
					else
					{
						num = 24;
					}
					continue;
				case 39:
					text3 += ",";
					num = 23;
					continue;
				case 69:
					num = 43;
					continue;
				case 43:
					return;
				case 26:
					if (flag)
					{
						flag = !aa.Checked;
						num = 11;
					}
					else
					{
						num = 57;
					}
					continue;
				case 60:
					if (flag)
					{
						flag = !ab.Checked;
						num = 26;
					}
					else
					{
						num = 25;
					}
					continue;
				case 71:
					num = (flag ? 18 : 13);
					continue;
				case 44:
					flag = !(text2 == "");
					num = 47;
					continue;
				case 47:
					if (flag)
					{
						text3 = "";
						num3 = 0;
						num = 10;
					}
					else
					{
						num = 42;
					}
					continue;
				case 57:
					text = "1";
					num = 22;
					continue;
				case 31:
					if (flag)
					{
						flag = !(array[0] == "0");
						num = 34;
					}
					else
					{
						num = 19;
					}
					continue;
				case 25:
					text = "0";
					num = 28;
					continue;
				case 52:
					num3++;
					num = 36;
					continue;
				case 70:
					MessageBox.Show("موردی برای ارسال وجود ندارد");
					num = 67;
					continue;
				case 67:
					return;
				case 20:
				{
					DialogResult val = MessageBox.Show(" هیچ درسی انتخاب نشده است آیا میخواهید ادامه دهید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)16);
					flag = (int)val == 6;
					num = 9;
					continue;
				}
				case 9:
					num = (flag ? 35 : 65);
					continue;
				case 18:
					return;
				case 35:
					a_5 = "CreateMsg";
					flag = !(asdab.m == "2");
					num = 61;
					continue;
				case 61:
					if (!flag)
					{
						num = 53;
						continue;
					}
					goto case 40;
				case 12:
					num = 32;
					continue;
				case 32:
					return;
				case 23:
					{
						text3 += this.m_d.GetRow(num3).Cells["id"].Value.ToString();
						num = 52;
						continue;
					}
					IL_09e4:
					flag = (byte)num2 != 0;
					num = 60;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		a();
		b();
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = !(asdab.m == "2");
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
					((Control)g).Visible = false;
					((Control)i).Visible = false;
					((Control)this.m_f).Visible = false;
					num = 0;
					continue;
				case 0:
					d();
					c();
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
	}
}
