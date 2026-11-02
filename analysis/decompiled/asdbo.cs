using System;
using System.Collections;
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
using school_Af.Properties;
using school_Af.Rpt.afPayment;

public class asdbo : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private Label m_f;

	private Label m_g;

	private UIComboBox h;

	private MaskedEditBox i;

	private TextBox j;

	private TextBox k;

	private Label l;

	private TextBox m;

	private TextBox n;

	private TextBox o;

	private TextBox p;

	private UIButton q;

	private Label r;

	private Label s;

	private UIComboBox t;

	private GridEX u;

	private Label v;

	private Label w;

	private Label x;

	private TextBox y;

	private Label z;

	private UIButton aa;

	private UIComboBox ab;

	private UIButton ac;

	private SqlConnection ad = new SqlConnection(asdab.e());

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
						num = 5;
					}
					else
					{
						num = 2;
					}
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 0:
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected Obj, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected Obj, but got Unknown
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Expected Obj, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected Obj, but got Unknown
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Expected Obj, but got Unknown
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Expected Obj, but got Unknown
		//IL_175d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1767: Expected Obj, but got Unknown
		if (true)
		{
		}
		UIComboBoxItem val = new UIComboBoxItem();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		StringFormat val7 = new StringFormat();
		StringFormat val8 = new StringFormat();
		GridEXLayout val9 = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbo));
		UIComboBoxItem val10 = new UIComboBoxItem();
		UIComboBoxItem val11 = new UIComboBoxItem();
		UIComboBoxItem val12 = new UIComboBoxItem();
		UIComboBoxItem val13 = new UIComboBoxItem();
		UIComboBoxItem val14 = new UIComboBoxItem();
		UIComboBoxItem val15 = new UIComboBoxItem();
		UIComboBoxItem val16 = new UIComboBoxItem();
		UIComboBoxItem val17 = new UIComboBoxItem();
		UIComboBoxItem val18 = new UIComboBoxItem();
		UIComboBoxItem val19 = new UIComboBoxItem();
		UIComboBoxItem val20 = new UIComboBoxItem();
		UIComboBoxItem val21 = new UIComboBoxItem();
		StringFormat val22 = new StringFormat();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		ac = new UIButton();
		ab = new UIComboBox();
		aa = new UIButton();
		y = new TextBox();
		z = new Label();
		x = new Label();
		v = new Label();
		w = new Label();
		r = new Label();
		s = new Label();
		t = new UIComboBox();
		u = new GridEX();
		q = new UIButton();
		p = new TextBox();
		o = new TextBox();
		n = new TextBox();
		m = new TextBox();
		l = new Label();
		k = new TextBox();
		j = new TextBox();
		i = new MaskedEditBox();
		this.m_f = new Label();
		this.m_g = new Label();
		h = new UIComboBox();
		this.m_e = new UIButton();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)u).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(650, 600);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_c).BackColor = Color.Black;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel2";
		((Control)this.m_c).Size = new Size(648, 598);
		((Control)this.m_c).TabIndex = 44;
		((Control)this.m_d).BackColor = Color.FromArgb(214, 223, 247);
		((Control)this.m_d).Controls.Add((Control)(object)ac);
		((Control)this.m_d).Controls.Add((Control)(object)ab);
		((Control)this.m_d).Controls.Add((Control)(object)aa);
		((Control)this.m_d).Controls.Add((Control)(object)y);
		((Control)this.m_d).Controls.Add((Control)(object)z);
		((Control)this.m_d).Controls.Add((Control)(object)x);
		((Control)this.m_d).Controls.Add((Control)(object)v);
		((Control)this.m_d).Controls.Add((Control)(object)w);
		((Control)this.m_d).Controls.Add((Control)(object)r);
		((Control)this.m_d).Controls.Add((Control)(object)s);
		((Control)this.m_d).Controls.Add((Control)(object)t);
		((Control)this.m_d).Controls.Add((Control)(object)u);
		((Control)this.m_d).Controls.Add((Control)(object)q);
		((Control)this.m_d).Controls.Add((Control)(object)p);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)n);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Location = new Point(3, 3);
		((Control)this.m_d).Name = "panel3";
		((Control)this.m_d).Size = new Size(642, 592);
		((Control)this.m_d).TabIndex = 0;
		((Control)ac).Anchor = (AnchorStyles)6;
		ac.Image = (Image)(object)Resources.error;
		ac.ImageSize = new Size(33, 33);
		((Control)ac).Location = new Point(466, 482);
		((Control)ac).Name = "btnNotShowBalance";
		((Control)ac).Size = new Size(165, 50);
		((Control)ac).TabIndex = 149;
		((Control)ac).Text = "تنظیم عدم نمایش شاگرد در دعوت نامه";
		((Control)ac).Click += a;
		((UIComboBase)ab).ComboStyle = (ComboStyle)1;
		((UIComboBase)ab).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ab).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.FormatStyle.Alpha = 0;
		val.Text = "1403";
		val.Value = "1403";
		val2.FormatStyle.Alpha = 0;
		val2.Text = "1402";
		val2.Value = "1402";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "1401";
		val3.Value = "1401";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1400";
		val4.Value = "1400";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1399";
		val5.Value = "1399";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1398";
		val6.Value = "1398";
		ab.Items.AddRange(new UIComboBoxItem[6] { val, val2, val3, val4, val5, val6 });
		((Control)ab).Location = new Point(355, 65);
		((Control)ab).Name = "dropYear";
		((Control)ab).Size = new Size(97, 23);
		val7.Alignment = (StringAlignment)0;
		val7.FormatFlags = (StringFormatFlags)20485;
		val7.HotkeyPrefix = (HotkeyPrefix)0;
		val7.LineAlignment = (StringAlignment)1;
		val7.Trimming = (StringTrimming)1;
		((UIComboBase)ab).StringFormat = val7;
		((Control)ab).TabIndex = 148;
		ab.SelectedIndexChanged += c;
		((Control)aa).Anchor = (AnchorStyles)6;
		aa.Image = (Image)(object)Resources._0188;
		aa.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		aa.ImageSize = new Size(40, 40);
		((Control)aa).Location = new Point(184, 540);
		((Control)aa).Name = "uiButton1";
		((Control)aa).Size = new Size(259, 46);
		((Control)aa).TabIndex = 147;
		((Control)aa).Text = "نمایش لیست دانش آموزان بدهکار";
		((Control)aa).Click += d;
		((Control)y).Location = new Point(317, 253);
		((Control)y).Name = "txtDate";
		((Control)y).Size = new Size(229, 23);
		((Control)y).TabIndex = 146;
		((Control)y).Text = "تا تاریخ پنج شنبه دهم ثور";
		((Control)z).AutoSize = true;
		((Control)z).Location = new Point(554, 256);
		((Control)z).Name = "label7";
		((Control)z).Size = new Size(34, 16);
		((Control)z).TabIndex = 145;
		((Control)z).Text = "تاریخ";
		((Control)x).AutoSize = true;
		((Control)x).Font = new Font("Tahoma", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(284, 12);
		((Control)x).Name = "label6";
		((Control)x).Size = new Size(190, 23);
		((Control)x).TabIndex = 144;
		((Control)x).Text = "گزارش بدهی شاگردان";
		((Control)v).AutoSize = true;
		((Control)v).Location = new Point(549, 378);
		((Control)v).Name = "label5";
		((Control)v).Size = new Size(74, 16);
		((Control)v).TabIndex = 143;
		((Control)v).Text = "جمله پایانی";
		((Control)w).AutoSize = true;
		((Control)w).Location = new Point(554, 288);
		((Control)w).Name = "label3";
		((Control)w).Size = new Size(69, 16);
		((Control)w).TabIndex = 142;
		((Control)w).Text = "جمله بعدی";
		((Control)r).AutoSize = true;
		((Control)r).Location = new Point(458, 67);
		((Control)r).Name = "label8";
		((Control)r).Size = new Size(87, 16);
		((Control)r).TabIndex = 141;
		((Control)r).Text = "سال تعلیمی :";
		((Control)s).Anchor = (AnchorStyles)9;
		((Control)s).AutoSize = true;
		((Control)s).Location = new Point(208, 8);
		((Control)s).Name = "label20";
		((Control)s).Size = new Size(27, 16);
		((Control)s).TabIndex = 139;
		((Control)s).Text = "پایه";
		((Control)t).Anchor = (AnchorStyles)9;
		((UIComboBase)t).ComboStyle = (ComboStyle)1;
		((UIComboBase)t).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)t).Location = new Point(8, 8);
		((Control)t).Name = "dropPaye";
		((Control)t).Size = new Size(193, 20);
		val8.Alignment = (StringAlignment)0;
		val8.FormatFlags = (StringFormatFlags)20485;
		val8.HotkeyPrefix = (HotkeyPrefix)0;
		val8.LineAlignment = (StringAlignment)1;
		val8.Trimming = (StringTrimming)1;
		((UIComboBase)t).StringFormat = val8;
		((Control)t).TabIndex = 138;
		t.SelectedIndexChanged += b;
		((Control)u).Anchor = (AnchorStyles)10;
		val9.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		u.DesignTimeLayout = val9;
		u.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		u.GroupByBoxVisible = false;
		((Control)u).Location = new Point(8, 31);
		((Control)u).Name = "gClass";
		u.RowHeaders = (InheritableBoolean)1;
		((Control)u).Size = new Size(193, 181);
		((Control)u).TabIndex = 137;
		((ScrollableBase)u).VisualStyle = (VisualStyle)2;
		((Control)q).Anchor = (AnchorStyles)6;
		q.Image = (Image)(object)Resources._0188;
		q.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		q.ImageSize = new Size(40, 40);
		((Control)q).Location = new Point(184, 482);
		((Control)q).Name = "btnview";
		((Control)q).Size = new Size(259, 50);
		((Control)q).TabIndex = 130;
		((Control)q).Text = "نمایش دعوت نامه";
		((Control)q).Click += e;
		((Control)p).Location = new Point(27, 429);
		((TextBoxBase)p).Multiline = true;
		((Control)p).Name = "txtfoter2";
		((Control)p).Size = new Size(196, 43);
		((Control)p).TabIndex = 129;
		((Control)p).Text = "با تشکر\r\nاداره لیسه عالی دین و دانش";
		p.TextAlign = (HorizontalAlignment)2;
		((Control)o).Location = new Point(27, 375);
		((TextBoxBase)o).Multiline = true;
		((Control)o).Name = "txtfoter1";
		((Control)o).Size = new Size(521, 49);
		((Control)o).TabIndex = 128;
		((Control)o).Text = "تذکر : در صورت تأخیر در پرداخت مبلغ متذکره طبق صلاحدید مکتب عمل خواهد شد.";
		((Control)n).Enabled = false;
		((Control)n).Location = new Point(255, 340);
		((Control)n).Name = "textBox3";
		((Control)n).Size = new Size(293, 23);
		((Control)n).TabIndex = 127;
		((Control)n).Text = "مجموع فیس پرداخت شده تا این تاریخ .... افغانی";
		((Control)m).Enabled = false;
		((Control)m).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(8, 218);
		((Control)m).Name = "textBox2";
		((Control)m).Size = new Size(303, 22);
		((Control)m).TabIndex = 126;
		((Control)m).Text = "سه ماهه بهار مبلغ ...  افغانی افغانی می گردد را حداکثر";
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(554, 221);
		((Control)l).Name = "label4";
		((Control)l).Size = new Size(80, 16);
		((Control)l).TabIndex = 125;
		((Control)l).Text = "جمله ابتدایی";
		((Control)k).Location = new Point(317, 218);
		((Control)k).Name = "txtheder1";
		((Control)k).Size = new Size(230, 23);
		((Control)k).TabIndex = 124;
		((Control)k).Text = "خواهشمند است بقایای فیس";
		((Control)j).Location = new Point(8, 285);
		((TextBoxBase)j).Multiline = true;
		((Control)j).Name = "txtheder2";
		((Control)j).Size = new Size(540, 49);
		((Control)j).TabIndex = 123;
		((Control)j).Text = "تحویل نموده و ما را در برنامه ریزی بهتر برای آینده فرزندتان یازی نمایید.";
		((EditBase)i).AutoScroll = false;
		((EditBase)i).AutoScrollMargin = new Size(0, 0);
		((EditBase)i).AutoScrollMinSize = new Size(0, 0);
		((EditBase)i).AutoScrollPosition = new Point(0, 0);
		((EditBase)i).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(355, 162);
		((EditBase)i).MaxLength = 9;
		((Control)i).Name = "txtBalance";
		i.Numeric = true;
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(97, 23);
		((Control)i).TabIndex = 122;
		((Control)i).Tag = "";
		((EditBase)i).TextAlignment = (TextAlignment)1;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Location = new Point(458, 166);
		((Control)this.m_f).Name = "label2";
		((Control)this.m_f).Size = new Size(101, 16);
		((Control)this.m_f).TabIndex = 121;
		((Control)this.m_f).Text = "حداقل بدهکاری :";
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Location = new Point(458, 118);
		((Control)this.m_g).Name = "label1";
		((Control)this.m_g).Size = new Size(63, 16);
		((Control)this.m_g).TabIndex = 120;
		((Control)this.m_g).Text = "فصل/ماه :";
		((Control)h).Anchor = (AnchorStyles)9;
		((UIComboBase)h).ComboStyle = (ComboStyle)1;
		((UIComboBase)h).DropListFont = new Font("B Nazanin", 12f);
		val10.FormatStyle.Alpha = 0;
		val10.Text = "بهار";
		val10.Value = "1";
		val11.FormatStyle.Alpha = 0;
		val11.Text = "تابستان";
		val11.Value = "2";
		val12.FormatStyle.Alpha = 0;
		val12.Text = "خزان";
		val12.Value = "3";
		val13.FormatStyle.Alpha = 0;
		val13.Text = "حمل";
		val13.Value = "1";
		val14.FormatStyle.Alpha = 0;
		val14.Text = "ثور";
		val14.Value = "2";
		val15.FormatStyle.Alpha = 0;
		val15.Text = "جوزا";
		val15.Value = "3";
		val16.FormatStyle.Alpha = 0;
		val16.Text = "سرطان";
		val16.Value = "4";
		val17.FormatStyle.Alpha = 0;
		val17.Text = "اسد";
		val17.Value = "5";
		val18.FormatStyle.Alpha = 0;
		val18.Text = "سنبله";
		val18.Value = "6";
		val19.FormatStyle.Alpha = 0;
		val19.Text = "میزان";
		val19.Value = "7";
		val20.FormatStyle.Alpha = 0;
		val20.Text = "عقرب";
		val20.Value = "8";
		val21.FormatStyle.Alpha = 0;
		val21.Text = "قوس";
		val21.Value = "9";
		h.Items.AddRange(new UIComboBoxItem[12]
		{
			val10, val11, val12, val13, val14, val15, val16, val17, val18, val19,
			val20, val21
		});
		((Control)h).Location = new Point(355, 114);
		((Control)h).Name = "dropFasl";
		((Control)h).Size = new Size(97, 23);
		val22.Alignment = (StringAlignment)0;
		val22.FormatFlags = (StringFormatFlags)20485;
		val22.HotkeyPrefix = (HotkeyPrefix)0;
		val22.LineAlignment = (StringAlignment)1;
		val22.Trimming = (StringTrimming)1;
		((UIComboBase)h).StringFormat = val22;
		((Control)h).TabIndex = 119;
		((Control)this.m_e).Anchor = (AnchorStyles)6;
		this.m_e.DialogResult = (DialogResult)2;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(40, 40);
		((Control)this.m_e).Location = new Point(8, 539);
		((Control)this.m_e).Name = "btnClose";
		((Control)this.m_e).Size = new Size(102, 50);
		((Control)this.m_e).TabIndex = 44;
		((Control)this.m_e).Text = "بستن";
		((Control)this.m_e).Click += f;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(650, 600);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmRptBalance";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره";
		((Form)this).Load += g;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((ISupportInitialize)u).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asdbo()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		c();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		DataTable dataTable2 = default;
		while (true)
		{
			bool flag = asdaj.a("10");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 0:
					((Control)o).Text = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)p).Text = dataTable2.Rows[0]["Foter2"].ToString();
					((Control)k).Text = dataTable2.Rows[0]["heder1"].ToString();
					((Control)j).Text = dataTable2.Rows[0]["heder2"].ToString();
					((Control)i).Text = dataTable2.Rows[0]["balance"].ToString();
					((Control)y).Text = dataTable2.Rows[0]["fDate"].ToString();
					((Control)o).Tag = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)p).Tag = dataTable2.Rows[0]["Foter2"].ToString();
					((Control)k).Tag = dataTable2.Rows[0]["heder1"].ToString();
					((Control)j).Tag = dataTable2.Rows[0]["heder2"].ToString();
					((Control)i).Tag = dataTable2.Rows[0]["balance"].ToString();
					((Control)y).Tag = dataTable2.Rows[0]["fDate"].ToString();
					num = 7;
					continue;
				case 7:
					return;
				case 8:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					ab.SelectedValue = asdaj.a;
					b();
					a();
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM tParmetrBalance");
					flag = dataTable2.Rows.Count <= 0;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 2:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 3:
					num = 2;
					continue;
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
			((CollectionBase)(object)t.Items).Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where  id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ab.SelectedValue.ToString() + ") order by id");
			t.Items.Add("کل", (object)"0");
			int num = 0;
			int num2 = 2;
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
					t.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 0;
					continue;
				case 3:
					if (true)
					{
					}
					t.SelectedIndex = 0;
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
			if (true)
			{
			}
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = t.SelectedIndex <= 0;
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
					text = text + " and xPaye=" + t.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + ab.SelectedValue.ToString() + text);
					u.DataSource = dataSource;
					return;
				}
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
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		int num2 = default;
		SqlParameter[] a_3 = default;
		string text = default;
		string a_ = default;
		int num4 = default;
		while (true)
		{
			bool flag = asdab.p >= int.Parse(ab.SelectedValue.ToString());
			int num = 8;
			while (true)
			{
				int num6;
				int num3;
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 31;
						continue;
					}
					flag = asdab.p != int.Parse(ab.SelectedValue.ToString());
					num = 2;
					continue;
				case 18:
					num = 40;
					continue;
				case 40:
					if (!(((Control)p).Text != ((Control)p).Tag.ToString()))
					{
						num = 47;
						continue;
					}
					goto IL_0587;
				case 7:
					num2++;
					num = 39;
					continue;
				case 9:
					num = ((((Control)i).Text == "") ? 13 : 37);
					continue;
				case 45:
					num = 51;
					continue;
				case 51:
					num6 = ((!(((Control)y).Text != ((Control)y).Tag.ToString())) ? 1 : 0);
					goto IL_0373;
				case 3:
					if (!(((Control)o).Text != ((Control)o).Tag.ToString()))
					{
						num = 18;
						continue;
					}
					goto IL_0587;
				case 38:
					a_3 = new SqlParameter[4]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text),
						asdcb.a("@xYear", SqlDbType.Int, ab.SelectedValue.ToString()),
						asdcb.a("@Fasl", SqlDbType.Int, h.SelectedValue.ToString()),
						asdcb.a("@Balance", SqlDbType.Int, ((Control)i).Text)
					};
					a_ = "sp_RptPaymentBalance1";
					num4 = 1;
					flag = h.SelectedIndex < 3;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 28;
				case 17:
					text += u.GetRow(num2).Cells["id"].Value.ToString();
					num = 7;
					continue;
				case 37:
					num = 21;
					continue;
				case 21:
					num3 = ((!(((Control)i).Text == "0")) ? 1 : 0);
					goto IL_055d;
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 38;
				case 28:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_, a_3);
					ReportClass val = null;
					val = (ReportClass)(object)new CrRptStdBalance();
					((ReportDocument)val).SetDataSource(dataSource);
					((ReportDocument)val).ParameterFields["heder1"].CurrentValues.AddValue((object)((Control)k).Text);
					((ReportDocument)val).ParameterFields["heder2"].CurrentValues.AddValue((object)((Control)j).Text);
					((ReportDocument)val).ParameterFields["foter1"].CurrentValues.AddValue((object)((Control)o).Text);
					((ReportDocument)val).ParameterFields["foter2"].CurrentValues.AddValue((object)((Control)p).Text);
					((ReportDocument)val).ParameterFields["fdate"].CurrentValues.AddValue((object)((Control)y).Text);
					((ReportDocument)val).ParameterFields["type"].CurrentValues.AddValue((object)num4);
					asda asda10 = new asda();
					asda10.a = val;
					((Form)asda10).ShowDialog();
					num = 30;
					continue;
				}
				case 30:
					return;
				case 31:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 25;
					continue;
				case 25:
					return;
				case 49:
					MessageBox.Show("فصل یا ماه مورد نظر را انتخاب کنید");
					((UIComboBase)h).Focus();
					num = 36;
					continue;
				case 36:
					return;
				case 35:
					flag = h.SelectedIndex >= 0;
					num = 16;
					continue;
				case 16:
					num = ((!flag) ? 49 : 9);
					continue;
				case 32:
					num = (flag ? 22 : 20);
					continue;
				case 42:
					num6 = 0;
					goto IL_0373;
				case 29:
					num = 6;
					continue;
				case 6:
					if (!(((Control)j).Text != ((Control)j).Tag.ToString()))
					{
						num = 26;
						continue;
					}
					goto IL_0587;
				case 22:
					try
					{
						int num5 = int.Parse(((Control)i).Text);
					}
					catch
					{
						MessageBox.Show("برای حداقل بدهی فقط عدد وارد کنید");
						((Control)i).Focus();
						return;
					}
					text = "";
					num2 = 0;
					num = 50;
					continue;
				case 15:
					flag = !(text == "");
					num = 10;
					continue;
				case 10:
					num = ((!flag) ? 4 : 3);
					continue;
				case 20:
					MessageBox.Show("حداقل بدهی را وارد کنید");
					((Control)i).Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 13:
					num3 = 0;
					goto IL_055d;
				case 26:
					num = 23;
					continue;
				case 23:
					if (!(((Control)i).Text != ((Control)i).Tag.ToString()))
					{
						num = 45;
						continue;
					}
					goto IL_0587;
				case 27:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 33;
					continue;
				case 33:
					return;
				case 34:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 7;
				case 39:
				case 50:
					flag = num2 < u.RowCount;
					num = 46;
					continue;
				case 46:
					if (flag)
					{
						flag = !(u.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 34;
					}
					else
					{
						num = 15;
					}
					continue;
				case 2:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 35;
				case 4:
					MessageBox.Show("صنفی انتخاب نشده است");
					num = 41;
					continue;
				case 41:
					return;
				case 43:
					flag = !(text != "");
					num = 48;
					continue;
				case 48:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 17;
				case 14:
				{
					SqlParameter[] a_2 = new SqlParameter[6]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)k).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)j).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)o).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)p).Text),
						asdcb.a("@balance", SqlDbType.NVarChar, ((Control)i).Text),
						asdcb.a("@fDate", SqlDbType.NVarChar, ((Control)y).Text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "if not exists(select balance from tParmetrBalance)\r\n                    INSERT INTO tParmetrBalance\r\n                      (heder1, heder2, Foter1, Foter2, balance,fDate)\r\n                 VALUES (@heder1, @heder2, @Foter1, @Foter2, @balance,@fDate)\r\n                     else UPDATE    tParmetrBalance\r\n                          SET              heder1 =@heder1, heder2 =@heder2, Foter1 =@Foter1, Foter2 =@Foter2, balance =@balance,fDate=@fDate", a_2);
					num = 38;
					continue;
				}
				case 24:
					text += ",";
					num = 17;
					continue;
				case 11:
					a_ = "sp_RptPaymentBalance2";
					num4 = 2;
					num = 28;
					continue;
				case 44:
					flag = !(asdab.q != asdab.n);
					num = 12;
					continue;
				case 12:
					num = ((!flag) ? 27 : 35);
					continue;
				case 47:
					num = 19;
					continue;
				case 19:
					{
						if (!(((Control)k).Text != ((Control)k).Tag.ToString()))
						{
							num = 29;
							continue;
						}
						goto IL_0587;
					}
					IL_055d:
					flag = (byte)num3 != 0;
					num = 32;
					continue;
					IL_0373:
					flag = (byte)num6 != 0;
					num = 5;
					continue;
					IL_0587:
					num = 42;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		int num2 = default;
		string a_ = default;
		int num4 = default;
		string text = default;
		while (true)
		{
			bool flag = asdab.p >= int.Parse(ab.SelectedValue.ToString());
			int num = 9;
			while (true)
			{
				int num6;
				int num3;
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 29;
						continue;
					}
					flag = asdab.p != int.Parse(ab.SelectedValue.ToString());
					num = 40;
					continue;
				case 45:
					num = 28;
					continue;
				case 28:
					if (!(((Control)p).Text != ((Control)p).Tag.ToString()))
					{
						num = 41;
						continue;
					}
					goto IL_057f;
				case 19:
					num2++;
					num = 1;
					continue;
				case 4:
					num = ((((Control)i).Text == "") ? 47 : 12);
					continue;
				case 8:
					num = 44;
					continue;
				case 44:
					num6 = ((!(((Control)y).Text != ((Control)y).Tag.ToString())) ? 1 : 0);
					goto IL_02fe;
				case 21:
					if (!(((Control)o).Text != ((Control)o).Tag.ToString()))
					{
						num = 45;
						continue;
					}
					goto IL_057f;
				case 2:
					a_ = "sp_RptPaymentBalance1";
					num4 = 1;
					flag = h.SelectedIndex < 3;
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 50;
						continue;
					}
					goto case 17;
				case 20:
					text += u.GetRow(num2).Cells["id"].Value.ToString();
					num = 19;
					continue;
				case 12:
					num = 24;
					continue;
				case 24:
					num3 = ((!(((Control)i).Text == "0")) ? 1 : 0);
					goto IL_0555;
				case 37:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 2;
				case 17:
				{
					SqlParameter[] a_3 = new SqlParameter[4]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text),
						asdcb.a("@xYear", SqlDbType.Int, ab.SelectedValue.ToString()),
						asdcb.a("@Fasl", SqlDbType.Int, h.SelectedValue.ToString()),
						asdcb.a("@Balance", SqlDbType.Int, ((Control)i).Text)
					};
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_, a_3);
					ReportClass val = null;
					val = (ReportClass)(object)new CrRptStdBalanceListe();
					((ReportDocument)val).SetDataSource(dataSource);
					((ReportDocument)val).ParameterFields["heder1"].CurrentValues.AddValue((object)((Control)k).Text);
					((ReportDocument)val).ParameterFields["heder2"].CurrentValues.AddValue((object)((Control)j).Text);
					((ReportDocument)val).ParameterFields["foter1"].CurrentValues.AddValue((object)((Control)o).Text);
					((ReportDocument)val).ParameterFields["foter2"].CurrentValues.AddValue((object)((Control)p).Text);
					((ReportDocument)val).ParameterFields["fdate"].CurrentValues.AddValue((object)((Control)y).Text);
					((ReportDocument)val).ParameterFields["type"].CurrentValues.AddValue((object)num4);
					asda asda10 = new asda();
					asda10.a = val;
					((Form)asda10).ShowDialog();
					num = 51;
					continue;
				}
				case 51:
					return;
				case 29:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 14;
					continue;
				case 14:
					return;
				case 46:
					MessageBox.Show("فصل را انتخاب کنید");
					((UIComboBase)h).Focus();
					num = 36;
					continue;
				case 36:
					return;
				case 39:
					flag = h.SelectedIndex >= 0;
					num = 48;
					continue;
				case 48:
					num = ((!flag) ? 46 : 4);
					continue;
				case 16:
					num = (flag ? 7 : 35);
					continue;
				case 6:
					num6 = 0;
					goto IL_02fe;
				case 11:
					num = 34;
					continue;
				case 34:
					if (!(((Control)j).Text != ((Control)j).Tag.ToString()))
					{
						num = 33;
						continue;
					}
					goto IL_057f;
				case 7:
					try
					{
						int num5 = int.Parse(((Control)i).Text);
					}
					catch
					{
						MessageBox.Show("برای حداقل بدهی فقط عدد وارد کنید");
						((Control)i).Focus();
						return;
					}
					text = "";
					num2 = 0;
					num = 25;
					continue;
				case 5:
					flag = !(text == "");
					num = 31;
					continue;
				case 31:
					num = ((!flag) ? 15 : 21);
					continue;
				case 35:
					MessageBox.Show("حداقل بدهی را وارد کنید");
					((Control)i).Focus();
					num = 26;
					continue;
				case 26:
					return;
				case 47:
					num3 = 0;
					goto IL_0555;
				case 33:
					if (true)
					{
					}
					num = 13;
					continue;
				case 13:
					if (!(((Control)i).Text != ((Control)i).Tag.ToString()))
					{
						num = 8;
						continue;
					}
					goto IL_057f;
				case 43:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 18;
					continue;
				case 18:
					return;
				case 23:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 19;
				case 1:
				case 25:
					flag = num2 < u.RowCount;
					num = 27;
					continue;
				case 27:
					if (flag)
					{
						flag = !(u.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 23;
					}
					else
					{
						num = 5;
					}
					continue;
				case 40:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 39;
				case 15:
					MessageBox.Show("صنفی انتخاب نشده است");
					num = 38;
					continue;
				case 38:
					return;
				case 0:
					flag = !(text != "");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 20;
				case 32:
				{
					SqlParameter[] a_2 = new SqlParameter[6]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)k).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)j).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)o).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)p).Text),
						asdcb.a("@balance", SqlDbType.NVarChar, ((Control)i).Text),
						asdcb.a("@fDate", SqlDbType.NVarChar, ((Control)y).Text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "if not exists(select balance from tParmetrBalance)\r\n                    INSERT INTO tParmetrBalance\r\n                      (heder1, heder2, Foter1, Foter2, balance,fDate)\r\n                 VALUES (@heder1, @heder2, @Foter1, @Foter2, @balance,@fDate)\r\n                     else UPDATE    tParmetrBalance\r\n                          SET              heder1 =@heder1, heder2 =@heder2, Foter1 =@Foter1, Foter2 =@Foter2, balance =@balance,fDate=@fDate", a_2);
					num = 2;
					continue;
				}
				case 3:
					text += ",";
					num = 20;
					continue;
				case 50:
					a_ = "sp_RptPaymentBalance2";
					num4 = 2;
					num = 17;
					continue;
				case 49:
					flag = !(asdab.q != asdab.n);
					num = 30;
					continue;
				case 30:
					num = ((!flag) ? 43 : 39);
					continue;
				case 41:
					num = 42;
					continue;
				case 42:
					{
						if (!(((Control)k).Text != ((Control)k).Tag.ToString()))
						{
							num = 11;
							continue;
						}
						goto IL_057f;
					}
					IL_0555:
					flag = (byte)num3 != 0;
					num = 16;
					continue;
					IL_02fe:
					flag = (byte)num6 != 0;
					num = 37;
					continue;
					IL_057f:
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		b();
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbr asdbr2 = new asdbr();
		((Form)asdbr2).ShowDialog();
	}
}
