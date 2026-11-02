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
using Janus.Windows.UI;

public class asdb1 : Form
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

	private UIButton v;

	private CheckBox w;

	private CheckBox x;

	private Label y;

	private UIComboBox z;

	private GridEX aa;

	private Label ab;

	private UIComboBox ac;

	private FolderBrowserDialog ad;

	private Label ae;

	private CheckBox af;

	private CheckBox ag;

	private Label ah;

	private TextBox ai;

	private GroupBox aj;

	private UIButton ak;

	private Container al = null;

	private string am = Application.StartupPath + "\\xls\\sms.xls";

	public asdb1()
	{
		e();
	}

	protected override void b(bool A_0)
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
						num = 1;
						continue;
					}
					goto case 4;
				case 0:
					num = 4;
					continue;
				case 2:
					al.Dispose();
					num = 0;
					continue;
				case 1:
					flag = al == null;
					num = 3;
					continue;
				case 3:
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected Obj, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected Obj, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected Obj, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected Obj, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected Obj, but got Unknown
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected Obj, but got Unknown
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Expected Obj, but got Unknown
		//IL_0e38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Expected Obj, but got Unknown
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eca: Expected Obj, but got Unknown
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected Obj, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Expected Obj, but got Unknown
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Expected Obj, but got Unknown
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected Obj, but got Unknown
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected Obj, but got Unknown
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected Obj, but got Unknown
		//IL_1391: Unknown result type (might be due to invalid IL or missing references)
		//IL_139b: Expected Obj, but got Unknown
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_143a: Expected Obj, but got Unknown
		//IL_1501: Unknown result type (might be due to invalid IL or missing references)
		//IL_150b: Expected Obj, but got Unknown
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1527: Expected Obj, but got Unknown
		//IL_1788: Unknown result type (might be due to invalid IL or missing references)
		//IL_1792: Expected Obj, but got Unknown
		//IL_17a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b0: Expected Obj, but got Unknown
		//IL_18f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1901: Expected Obj, but got Unknown
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_191f: Expected Obj, but got Unknown
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Expected Obj, but got Unknown
		//IL_1b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b32: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb1));
		StringFormat val = new StringFormat();
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
		GridEXLayout val4 = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		aj = new GroupBox();
		ak = new UIButton();
		ai = new TextBox();
		ah = new Label();
		ae = new Label();
		w = new CheckBox();
		x = new CheckBox();
		v = new UIButton();
		j = new UIGroupBox();
		ag = new CheckBox();
		af = new CheckBox();
		o = new Label();
		p = new Label();
		q = new TextBox();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		i = new CheckBox();
		this.m_f = new CheckBox();
		h = new TextBox();
		k = new CheckBox();
		l = new Label();
		g = new CheckBox();
		m = new Label();
		n = new TextBox();
		this.m_e = new UIButton();
		this.m_c = new Panel();
		ab = new Label();
		ac = new UIComboBox();
		y = new Label();
		z = new UIComboBox();
		aa = new GridEX();
		this.m_d = new GridEX();
		ad = new FolderBrowserDialog();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)aj).SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((Control)j).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)aa).BeginInit();
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
		((Control)this.m_b).Controls.Add((Control)(object)aj);
		((Control)this.m_b).Controls.Add((Control)(object)ae);
		((Control)this.m_b).Controls.Add((Control)(object)w);
		((Control)this.m_b).Controls.Add((Control)(object)x);
		((Control)this.m_b).Controls.Add((Control)(object)v);
		((Control)this.m_b).Controls.Add((Control)(object)j);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(8, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(733, 597);
		((Control)this.m_b).TabIndex = 16;
		((Control)aj).Controls.Add((Control)(object)ak);
		((Control)aj).Controls.Add((Control)(object)ai);
		((Control)aj).Controls.Add((Control)(object)ah);
		((Control)aj).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)aj).Location = new Point(13, 413);
		((Control)aj).Name = "groupBox1";
		((Control)aj).RightToLeft = (RightToLeft)1;
		((Control)aj).Size = new Size(414, 68);
		((Control)aj).TabIndex = 68;
		aj.TabStop = false;
		((Control)aj).Text = "ارسال نمرات یک نمونه به تلگرام  شماره همراه زیر جهت اطمینان";
		((Control)ak).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		ak.ImageSize = new Size(30, 30);
		((Control)ak).Location = new Point(18, 34);
		((Control)ak).Name = "btnSendTest";
		((Control)ak).Size = new Size(154, 25);
		((Control)ak).TabIndex = 69;
		((Control)ak).Text = "ارسال نمونه";
		((Control)ak).Click += a;
		((Control)ai).Location = new Point(191, 36);
		((TextBoxBase)ai).MaxLength = 11;
		((Control)ai).Name = "txtTestMobil";
		((Control)ai).Size = new Size(170, 23);
		((Control)ai).TabIndex = 66;
		((Control)ah).AutoSize = true;
		((Control)ah).Font = new Font("Tahoma", 8.25f);
		((Control)ah).Location = new Point(367, 39);
		((Control)ah).Name = "label9";
		((Control)ah).Size = new Size(41, 13);
		((Control)ah).TabIndex = 67;
		((Control)ah).Text = "موبایل  ";
		((Control)ae).AutoSize = true;
		((Control)ae).Font = new Font("B Nazanin", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ae).ForeColor = Color.Maroon;
		((Control)ae).Location = new Point(147, 7);
		((Control)ae).Name = "label11";
		((Control)ae).Size = new Size(152, 31);
		((Control)ae).TabIndex = 64;
		((Control)ae).Text = "ارسال نمرات به تلگرام";
		((Control)w).AutoSize = true;
		w.Checked = true;
		w.CheckState = (CheckState)1;
		((Control)w).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(145, 337);
		((Control)w).Name = "checksendTo2";
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(130, 17);
		((Control)w).TabIndex = 65;
		((Control)w).Text = "ارسال برای موبایل مادر";
		((ButtonBase)w).UseVisualStyleBackColor = true;
		((Control)x).AutoSize = true;
		x.Checked = true;
		x.CheckState = (CheckState)1;
		((Control)x).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(299, 337);
		((Control)x).Name = "checksendTo1";
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(125, 17);
		((Control)x).TabIndex = 64;
		((Control)x).Text = "ارسال برای موبایل پدر";
		((ButtonBase)x).UseVisualStyleBackColor = true;
		((Control)v).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		v.ImageSize = new Size(30, 30);
		((Control)v).Location = new Point(165, 360);
		((Control)v).Name = "btnProcc";
		((Control)v).Size = new Size(262, 25);
		((Control)v).TabIndex = 59;
		((Control)v).Text = "ارسال به تلگرام";
		((Control)v).Click += e;
		((Control)j).Controls.Add((Control)(object)ag);
		((Control)j).Controls.Add((Control)(object)af);
		((Control)j).Controls.Add((Control)(object)o);
		((Control)j).Controls.Add((Control)(object)p);
		((Control)j).Controls.Add((Control)(object)q);
		((Control)j).Controls.Add((Control)(object)r);
		((Control)j).Controls.Add((Control)(object)s);
		((Control)j).Controls.Add((Control)(object)t);
		((Control)j).Controls.Add((Control)(object)u);
		((Control)j).Controls.Add((Control)(object)i);
		((Control)j).Controls.Add((Control)(object)this.m_f);
		((Control)j).Controls.Add((Control)(object)h);
		((Control)j).Controls.Add((Control)(object)k);
		((Control)j).Controls.Add((Control)(object)l);
		((Control)j).Controls.Add((Control)(object)g);
		((Control)j).Controls.Add((Control)(object)m);
		((Control)j).Controls.Add((Control)(object)n);
		((Control)j).Font = new Font("Tahoma", 8.25f);
		((Control)j).Location = new Point(41, 38);
		((Control)j).Name = "uiGroupBox1";
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(386, 268);
		((Control)j).TabIndex = 56;
		((Control)j).Text = "ترکیب پیام ارسالی";
		((Control)ag).AutoSize = true;
		ag.Checked = true;
		ag.CheckState = (CheckState)1;
		((Control)ag).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ag).Location = new Point(15, 238);
		((Control)ag).Name = "checkgkolliClass";
		((Control)ag).RightToLeft = (RightToLeft)1;
		((Control)ag).Size = new Size(100, 17);
		((Control)ag).TabIndex = 64;
		((Control)ag).Text = "رتبه کل در صنف";
		((ButtonBase)ag).UseVisualStyleBackColor = true;
		((Control)af).AutoSize = true;
		af.Checked = true;
		af.CheckState = (CheckState)1;
		((Control)af).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)af).Location = new Point(15, 143);
		((Control)af).Name = "checkgbookClass";
		((Control)af).RightToLeft = (RightToLeft)1;
		((Control)af).Size = new Size(109, 17);
		((Control)af).TabIndex = 63;
		((Control)af).Text = "رتبه درس در صنف";
		((ButtonBase)af).UseVisualStyleBackColor = true;
		((Control)o).AutoSize = true;
		((Control)o).Font = new Font("Tahoma", 8.25f);
		((Control)o).Location = new Point(181, 175);
		((Control)o).Name = "label8";
		((Control)o).Size = new Size(15, 13);
		((Control)o).TabIndex = 62;
		((Control)o).Text = "+";
		((Control)p).AutoSize = true;
		((Control)p).Font = new Font("Tahoma", 8.25f);
		((Control)p).Location = new Point(312, 198);
		((Control)p).Name = "label7";
		((Control)p).Size = new Size(60, 13);
		((Control)p).TabIndex = 61;
		((Control)p).Text = "جمله پایانی";
		((Control)q).Location = new Point(32, 197);
		((Control)q).Name = "txtfoter";
		((Control)q).Size = new Size(272, 21);
		((Control)q).TabIndex = 60;
		((Control)r).AutoSize = true;
		((Control)r).Font = new Font("Tahoma", 8.25f);
		((Control)r).Location = new Point(135, 151);
		((Control)r).Name = "label6";
		((Control)r).Size = new Size(102, 13);
		((Control)r).TabIndex = 59;
		((Control)r).Text = "نام درس + نمره و ...";
		((Control)s).AutoSize = true;
		((Control)s).Font = new Font("Tahoma", 8.25f);
		((Control)s).Location = new Point(181, 127);
		((Control)s).Name = "label5";
		((Control)s).Size = new Size(15, 13);
		((Control)s).TabIndex = 58;
		((Control)s).Text = "+";
		((Control)t).AutoSize = true;
		((Control)t).Font = new Font("Tahoma", 8.25f);
		((Control)t).Location = new Point(180, 90);
		((Control)t).Name = "label4";
		((Control)t).Size = new Size(15, 13);
		((Control)t).TabIndex = 57;
		((Control)t).Text = "+";
		((Control)u).AutoSize = true;
		((Control)u).Font = new Font("Tahoma", 8.25f);
		((Control)u).Location = new Point(180, 53);
		((Control)u).Name = "label3";
		((Control)u).Size = new Size(15, 13);
		((Control)u).TabIndex = 56;
		((Control)u).Text = "+";
		((Control)i).AutoSize = true;
		i.Checked = true;
		i.CheckState = (CheckState)1;
		((Control)i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(127, 238);
		((Control)i).Name = "checkgkolli";
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(89, 17);
		((Control)i).TabIndex = 49;
		((Control)i).Text = "رتبه کل در پایه";
		((ButtonBase)i).UseVisualStyleBackColor = true;
		((Control)this.m_f).AutoSize = true;
		this.m_f.Checked = true;
		this.m_f.CheckState = (CheckState)1;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(222, 238);
		((Control)this.m_f).Name = "checkmKolli";
		((Control)this.m_f).RightToLeft = (RightToLeft)1;
		((Control)this.m_f).Size = new Size(81, 17);
		((Control)this.m_f).TabIndex = 48;
		((Control)this.m_f).Text = "معدل دروس";
		((ButtonBase)this.m_f).UseVisualStyleBackColor = true;
		((Control)h).Location = new Point(34, 31);
		((Control)h).Name = "txtheder1";
		((Control)h).Size = new Size(272, 21);
		((Control)h).TabIndex = 51;
		((Control)k).AutoSize = true;
		k.Checked = true;
		k.CheckState = (CheckState)1;
		((Control)k).Enabled = false;
		((Control)k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(123, 68);
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
		((Control)g).AutoSize = true;
		g.Checked = true;
		g.CheckState = (CheckState)1;
		((Control)g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)g).Location = new Point(27, 166);
		((Control)g).Name = "checkgbook";
		((Control)g).RightToLeft = (RightToLeft)1;
		((Control)g).Size = new Size(98, 17);
		((Control)g).TabIndex = 47;
		((Control)g).Text = "رتبه درس در پایه";
		((ButtonBase)g).UseVisualStyleBackColor = true;
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("Tahoma", 8.25f);
		((Control)m).Location = new Point(310, 108);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(59, 13);
		((Control)m).TabIndex = 54;
		((Control)m).Text = "جمله بعدی";
		((Control)n).Location = new Point(31, 104);
		((Control)n).Name = "txtheder2";
		((Control)n).Size = new Size(272, 21);
		((Control)n).TabIndex = 53;
		this.m_e.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		this.m_e.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_e.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(20, 20);
		((Control)this.m_e).Location = new Point(13, 519);
		((Control)this.m_e).Name = "uiButton2";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(123, 64);
		((Control)this.m_e).TabIndex = 46;
		((Control)this.m_e).Text = "خروج";
		this.m_e.VisualStyle = (VisualStyle)1;
		((Control)this.m_e).Click += f;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)ab);
		((Control)this.m_c).Controls.Add((Control)(object)ac);
		((Control)this.m_c).Controls.Add((Control)(object)y);
		((Control)this.m_c).Controls.Add((Control)(object)z);
		((Control)this.m_c).Controls.Add((Control)(object)aa);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Location = new Point(450, 4);
		((Control)this.m_c).Name = "panel3";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(272, 579);
		((Control)this.m_c).TabIndex = 36;
		((Control)ab).Anchor = (AnchorStyles)9;
		((Control)ab).AutoSize = true;
		((Control)ab).Location = new Point(237, 17);
		((Control)ab).Name = "label10";
		((Control)ab).Size = new Size(29, 13);
		((Control)ab).TabIndex = 128;
		((Control)ab).Text = "دوره";
		((Control)ac).Anchor = (AnchorStyles)9;
		((UIComboBase)ac).ComboStyle = (ComboStyle)1;
		((UIComboBase)ac).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ac).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ac).Location = new Point(4, 14);
		((Control)ac).Name = "dropExam";
		((Control)ac).Size = new Size(232, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)ac).StringFormat = val;
		((Control)ac).TabIndex = 127;
		ac.SelectedIndexChanged += b;
		((Control)y).Anchor = (AnchorStyles)9;
		((Control)y).AutoSize = true;
		((Control)y).Location = new Point(242, 50);
		((Control)y).Name = "label20";
		((Control)y).Size = new Size(24, 13);
		((Control)y).TabIndex = 126;
		((Control)y).Text = "پایه";
		((Control)z).Anchor = (AnchorStyles)9;
		((UIComboBase)z).ComboStyle = (ComboStyle)1;
		((UIComboBase)z).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)z).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)z).Location = new Point(3, 46);
		((Control)z).Name = "dropPaye";
		((Control)z).RightToLeft = (RightToLeft)1;
		((Control)z).Size = new Size(233, 20);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)z).StringFormat = val2;
		((Control)z).TabIndex = 125;
		z.SelectedIndexChanged += d;
		((Control)aa).Anchor = (AnchorStyles)10;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		aa.DesignTimeLayout = val3;
		aa.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)aa).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		aa.GroupByBoxVisible = false;
		((Control)aa).Location = new Point(8, 72);
		((Control)aa).Name = "gClass";
		((Control)aa).RightToLeft = (RightToLeft)1;
		aa.RowHeaders = (InheritableBoolean)1;
		((Control)aa).Size = new Size(240, 116);
		((Control)aa).TabIndex = 124;
		((ScrollableBase)aa).VisualStyle = (VisualStyle)2;
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
		((Control)this).Name = "frmSendSmsMarkTelegram";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "دریافت فایل اکسل نمرات برای ارسال پیامک";
		((Form)this).Load += c;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)aj).ResumeLayout(false);
		((Control)aj).PerformLayout();
		((ISupportInitialize)j).EndInit();
		((Control)j).ResumeLayout(false);
		((Control)j).PerformLayout();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)aa).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam  where xYear=" + asdaj.a + " order by id desc");
			ac.DataSource = dataSource;
			ac.DisplayMember = "Name";
			ac.ValueMember = "id";
			bool flag = ((CollectionBase)(object)ac.Items).Count <= 0;
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
					ac.SelectedIndex = 0;
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
			z.DataSource = dataSource;
			z.DisplayMember = "Name";
			z.ValueMember = "id";
			bool flag = ((CollectionBase)(object)z.Items).Count <= 0;
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
					z.SelectedIndex = 0;
					num = 1;
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

	private void b()
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
					num = ((z.SelectedIndex < 0) ? 6 : 2);
					continue;
				case 0:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT DISTINCT tBook.id, tBook.Name,tBook.sort\r\n                                    FROM         tMark INNER JOIN\r\n                                                          tBook ON tMark.xbook = tBook.id\r\n                                    WHERE     tBook.xPaye =" + z.SelectedValue.ToString() + " AND tMark.Xtest = " + ac.SelectedValue.ToString() + " ORDER BY tBook.sort");
					this.m_d.DataSource = dataSource;
					num = 4;
					continue;
				}
				case 4:
					return;
				case 5:
					return;
				case 6:
					num2 = 1;
					goto IL_0124;
				case 2:
					if (true)
					{
					}
					num = 7;
					continue;
				case 7:
					num2 = ((ac.SelectedIndex < 0) ? 1 : 0);
					goto IL_0124;
				case 3:
					{
						if (flag)
						{
							this.m_d.DataSource = null;
							num = 5;
						}
						else
						{
							num = 0;
						}
						continue;
					}
					IL_0124:
					flag = (byte)num2 != 0;
					num = 3;
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
			string text = " where  xYear=" + asdaj.a + " and xPaye in(" + asdaj.n + ")";
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (z.SelectedIndex >= 0)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 0;
					}
					continue;
				case 4:
					num = 2;
					continue;
				case 2:
					num2 = ((!(z.SelectedValue.ToString() != "0")) ? 1 : 0);
					goto IL_00eb;
				case 6:
					text = text + " and xPaye=" + z.SelectedValue.ToString();
					num = 5;
					continue;
				case 1:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 5;
				case 0:
					num2 = 1;
					goto IL_00eb;
				case 5:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass" + text);
						aa.DataSource = dataSource;
						return;
					}
					IL_00eb:
					flag = (byte)num2 != 0;
					num = 1;
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

	private void a(bool A_0)
	{
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Invalid comparison between Unknown and I4
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		int num2 = default;
		string text2 = default;
		string text3 = default;
		string a_3 = default;
		while (true)
		{
			string text = "-1";
			bool flag = A_0;
			int num = 15;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 15:
					if (!flag)
					{
						num = 50;
						continue;
					}
					text = "1";
					num = 31;
					continue;
				case 46:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = !w.Checked;
					num = 40;
					continue;
				case 47:
				{
					string text4 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + ac.SelectedValue.ToString()).ToString();
					flag = !(text4 != "1");
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 35;
						continue;
					}
					goto case 6;
				case 10:
					num3 = 1;
					goto IL_05f4;
				case 40:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 11;
				case 33:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 5;
				case 8:
					MessageBox.Show("برای ارسال باید یکی از آیتمهای پدر یا مادر انتخاب شود");
					((Control)x).Focus();
					num = 48;
					continue;
				case 48:
					return;
				case 12:
				{
					DialogResult val = MessageBox.Show(" هیچ درسی انتخاب نشده است آیا میخواهید ادامه دهید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)16);
					flag = (int)val == 6;
					num = 23;
					continue;
				}
				case 23:
					num = (flag ? 2 : 0);
					continue;
				case 16:
				case 36:
					flag = num2 < this.m_d.RowCount;
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						flag = !(this.m_d.GetRow(num2).Cells[0].Value.ToString() == "True");
						num = 33;
					}
					else
					{
						num = 47;
					}
					continue;
				case 6:
					flag = !(text2 == "");
					num = 26;
					continue;
				case 26:
					if (true)
					{
					}
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 2;
				case 0:
					num = 37;
					continue;
				case 37:
					return;
				case 34:
					text = "2";
					num = 51;
					continue;
				case 39:
					MessageBox.Show(" هیچ صنفی انتخاب نشده است");
					((Control)aa).Focus();
					num = 45;
					continue;
				case 45:
					return;
				case 31:
				case 53:
					text3 = "";
					num2 = 0;
					num = 54;
					continue;
				case 29:
				case 54:
					flag = num2 < aa.RowCount;
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 13;
						continue;
					}
					flag = !(aa.GetRow(num2).Cells[0].Value.ToString() == "True");
					num = 42;
					continue;
				case 7:
					text = "0";
					num = 28;
					continue;
				case 5:
					num2++;
					num = 36;
					continue;
				case 13:
					flag = !(text3 == "");
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 39;
						continue;
					}
					text2 = "";
					num2 = 0;
					num = 16;
					continue;
				case 44:
					flag = !(text3 != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 19;
				case 42:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 14;
				case 43:
					text3 += ",";
					num = 19;
					continue;
				case 22:
					a_3 = "CreateMsgTelegram_tosifi";
					num = 20;
					continue;
				case 19:
					text3 += aa.GetRow(num2).Cells["id"].Value.ToString();
					num = 14;
					continue;
				case 27:
					flag = !(text2 != "");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 55;
						continue;
					}
					goto case 1;
				case 14:
					num2++;
					num = 29;
					continue;
				case 49:
					if (flag)
					{
						flag = !x.Checked;
						num = 46;
					}
					else
					{
						num = 7;
					}
					continue;
				case 21:
					num = 3;
					continue;
				case 3:
					num3 = ((!w.Checked) ? 1 : 0);
					goto IL_05f4;
				case 9:
					text = "1";
					num = 11;
					continue;
				case 50:
					num = 38;
					continue;
				case 38:
					num = (x.Checked ? 21 : 10);
					continue;
				case 11:
				case 28:
				case 51:
					flag = !(text == "-1");
					num = 41;
					continue;
				case 41:
					num = (flag ? 53 : 8);
					continue;
				case 55:
					text2 += ",";
					num = 1;
					continue;
				case 2:
					a_3 = "CreateMsgTelegram";
					flag = !(asdab.m == "2");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 20;
				case 35:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, ac.SelectedValue.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
					num = 6;
					continue;
				}
				case 1:
					text2 += this.m_d.GetRow(num2).Cells["id"].Value.ToString();
					num = 5;
					continue;
				case 20:
				{
					SqlParameter[] a_2 = new SqlParameter[16]
					{
						asdcb.a("@sendTo", SqlDbType.SmallInt, text),
						asdcb.a("@gBook", SqlDbType.SmallInt, g.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@gBookClass", SqlDbType.SmallInt, af.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@mKolli", SqlDbType.SmallInt, this.m_f.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@gkolli", SqlDbType.SmallInt, i.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@gkolliClass", SqlDbType.SmallInt, ag.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@NameStd", SqlDbType.SmallInt, k.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@test", SqlDbType.Int, ac.SelectedValue.ToString()),
						asdcb.a("@xbook", SqlDbType.VarChar, 200, text2),
						asdcb.a("@xClass", SqlDbType.VarChar, 200, text3),
						asdcb.a("@heder1", SqlDbType.NVarChar, 200, ((Control)h).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, 200, ((Control)n).Text),
						asdcb.a("@foter", SqlDbType.NVarChar, 200, ((Control)q).Text),
						asdcb.a("@date", SqlDbType.NVarChar, 10, asdab.b()),
						asdcb.a("@time", SqlDbType.NVarChar, 10, asdab.c()),
						asdcb.a("@SendTest", SqlDbType.Bit, A_0)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, a_3, a_2);
					MessageBox.Show("ارسال شد");
					num = 52;
					continue;
				}
				case 52:
					return;
					IL_05f4:
					flag = (byte)num3 != 0;
					num = 49;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		a(A_0: false);
	}

	private void d(object A_0, EventArgs A_1)
	{
		a();
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("5");
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
					flag = !(asdab.m == "2");
					num = 1;
					continue;
				case 9:
					((Control)q).Text = dataTable.Rows[0]["foter"].ToString();
					((Control)h).Text = dataTable.Rows[0]["heder"].ToString();
					((Control)ai).Text = dataTable.Rows[0]["testmobil"].ToString();
					num = 0;
					continue;
				case 5:
					((Control)g).Visible = false;
					((Control)af).Visible = false;
					((Control)i).Visible = false;
					((Control)this.m_f).Visible = false;
					((Control)ag).Visible = false;
					num = 2;
					continue;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
					d();
					c();
					num = 8;
					continue;
				case 8:
					if (1 == 0)
					{
					}
					return;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 2:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tTelegramConfig");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((Control)ai).Text = asdaj.b(((Control)ai).Text);
			bool flag = !(((Control)ai).Text == "");
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 9;
						continue;
					}
					try
					{
						long num2 = long.Parse(((Control)ai).Text);
					}
					catch
					{
						MessageBox.Show("برای شماره موبایل فقط عدد وراد کنید");
						((Control)ai).Focus();
						return;
					}
					flag = !(((Control)ai).Text.Substring(0, 2) != "09");
					num = 12;
					continue;
				case 0:
				{
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					SqlParameter[] a_ = new SqlParameter[3]
					{
						asdcb.a("@testmobil", SqlDbType.NVarChar, 11, ((Control)ai).Text),
						asdcb.a("@heder", SqlDbType.NVarChar, 200, ((Control)h).Text),
						asdcb.a("@foter", SqlDbType.NVarChar, 200, ((Control)q).Text)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetTelegramConfigTestMobil", a_);
					a(A_0: true);
					num = 4;
					continue;
				}
				case 10:
					if (flag)
					{
						string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(id) AS countId FROM tTelegramId WHERE  Mobile =" + ((Control)ai).Text).ToString();
						flag = !(text == "0");
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 2:
					MessageBox.Show("این شماره در ربات ثبت نشده است .ابتدا با این شماره وارد ربات شده و دکمه ارسال موبایل را کلیک کنید ");
					((Control)ai).Focus();
					num = 3;
					continue;
				case 3:
					return;
				case 9:
					MessageBox.Show("شماره موبایل برای ارسال نمونه را وارد کنید");
					((Control)ai).Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					MessageBox.Show("شماره موبایل باید 11 رقم باشد");
					((Control)ai).Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 4:
					return;
				case 12:
					if (flag)
					{
						flag = ((Control)ai).Text.Length >= 11;
						num = 10;
					}
					else
					{
						num = 6;
					}
					continue;
				case 6:
					MessageBox.Show("شماره موبایل باید با 09 شروع شود");
					((Control)ai).Focus();
					num = 5;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}
}
