using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdcc : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private Panel m_f;

	private UIButton m_g;

	private UIButton m_h;

	private Panel i;

	private UIButton j;

	private UIButton k;

	private GridEX l;

	private Label m;

	private UIComboBox n;

	private BackgroundWorker o;

	private ProgressBar p;

	private Label q;

	private Label r;

	private GridEX s;

	private UIButton t;

	private EditBox u;

	private Label v;

	private EditBox w;

	private Label x;

	private CheckBox y;

	private GridEX z;

	private Label aa;

	private UIComboBox ab;

	private SqlConnection ac = new SqlConnection(asdab.e());

	private SqlConnection ad = new SqlConnection();

	private string ae = "";

	private string af = "0";

	private string ag = " and xExportRpt is null";

	private string ah = "";

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
						num = 0;
					}
					else
					{
						num = 3;
					}
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 2;
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
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
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
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected Obj, but got Unknown
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected Obj, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Expected Obj, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected Obj, but got Unknown
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected Obj, but got Unknown
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected Obj, but got Unknown
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected Obj, but got Unknown
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected Obj, but got Unknown
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected Obj, but got Unknown
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Expected Obj, but got Unknown
		//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f8: Expected Obj, but got Unknown
		if (true)
		{
		}
		UIComboBoxItem val = new UIComboBoxItem();
		UIComboBoxItem val2 = new UIComboBoxItem();
		StringFormat val3 = new StringFormat();
		GridEXLayout val4 = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdcc));
		StringFormat val5 = new StringFormat();
		GridEXLayout val6 = new GridEXLayout();
		GridEXLayout val7 = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		r = new Label();
		this.m_f = new Panel();
		ab = new UIComboBox();
		aa = new Label();
		z = new GridEX();
		y = new CheckBox();
		u = new EditBox();
		v = new Label();
		w = new EditBox();
		x = new Label();
		m = new Label();
		n = new UIComboBox();
		this.m_g = new UIButton();
		this.m_h = new UIButton();
		p = new ProgressBar();
		this.m_d = new UIGroupBox();
		t = new UIButton();
		q = new Label();
		s = new GridEX();
		this.m_e = new Label();
		i = new Panel();
		j = new UIButton();
		k = new UIButton();
		l = new GridEX();
		o = new BackgroundWorker();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((ISupportInitialize)z).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((Control)i).SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.ControlText;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(800, 600);
		((Control)this.m_b).TabIndex = 1;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)r);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Controls.Add((Control)(object)p);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_c).Location = new Point(4, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(790, 588);
		((Control)this.m_c).TabIndex = 0;
		((Control)r).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)r).Location = new Point(528, 475);
		((Control)r).Name = "lTable";
		((Control)r).Size = new Size(241, 22);
		((Control)r).TabIndex = 8;
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)ab);
		((Control)this.m_f).Controls.Add((Control)(object)aa);
		((Control)this.m_f).Controls.Add((Control)(object)z);
		((Control)this.m_f).Controls.Add((Control)(object)y);
		((Control)this.m_f).Controls.Add((Control)(object)u);
		((Control)this.m_f).Controls.Add((Control)(object)v);
		((Control)this.m_f).Controls.Add((Control)(object)w);
		((Control)this.m_f).Controls.Add((Control)(object)x);
		((Control)this.m_f).Controls.Add((Control)(object)m);
		((Control)this.m_f).Controls.Add((Control)(object)n);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_f).Location = new Point(241, 105);
		((Control)this.m_f).Name = "pcls";
		((Control)this.m_f).Size = new Size(257, 174);
		((Control)this.m_f).TabIndex = 10;
		((Control)this.m_f).Visible = false;
		((UIComboBase)ab).ComboStyle = (ComboStyle)1;
		((UIComboBase)ab).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ab).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val.FormatStyle.Alpha = 0;
		val.Text = "همه صنف ها";
		val.Value = "0";
		val2.FormatStyle.Alpha = 0;
		val2.Text = "انتخاب صنف";
		val2.Value = "1";
		ab.Items.AddRange(new UIComboBoxItem[2] { val, val2 });
		((Control)ab).Location = new Point(21, 59);
		((Control)ab).Name = "comboTypeSendClass";
		((Control)ab).Size = new Size(154, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)ab).StringFormat = val3;
		((Control)ab).TabIndex = 110;
		ab.SelectedIndexChanged += a;
		((Control)aa).AutoSize = true;
		((Control)aa).Location = new Point(179, 59);
		((Control)aa).Name = "label4";
		((Control)aa).Size = new Size(65, 13);
		((Control)aa).TabIndex = 109;
		((Control)aa).Text = "ارسال نمرات";
		val4.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		z.DesignTimeLayout = val4;
		z.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)z).Font = new Font("Tahoma", 8.25f);
		z.GroupByBoxVisible = false;
		((Control)z).Location = new Point(19, 175);
		((Control)z).Name = "gClass";
		z.RowHeaders = (InheritableBoolean)1;
		((Control)z).Size = new Size(183, 280);
		((Control)z).TabIndex = 108;
		((ScrollableBase)z).VisualStyle = (VisualStyle)2;
		((Control)y).AutoSize = true;
		((Control)y).Location = new Point(45, 3);
		((Control)y).Name = "checkAgain";
		((Control)y).Size = new Size(145, 17);
		((Control)y).TabIndex = 83;
		((Control)y).Text = "ارسال مجدد همه اطلاعات";
		((ButtonBase)y).UseVisualStyleBackColor = true;
		y.CheckedChanged += b;
		((Control)u).Anchor = (AnchorStyles)9;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((Control)u).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(20, 88);
		((Control)u).Name = "txtUser";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(156, 21);
		((Control)u).TabIndex = 2;
		((EditBase)u).TextAlignment = (TextAlignment)1;
		((EditBase)u).VisualStyle = (VisualStyle)2;
		((Control)v).Anchor = (AnchorStyles)9;
		((Control)v).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(179, 88);
		((Control)v).Name = "label3";
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(61, 21);
		((Control)v).TabIndex = 82;
		((Control)v).Text = "نام کاربری :";
		v.TextAlign = (ContentAlignment)64;
		((Control)w).Anchor = (AnchorStyles)9;
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((Control)w).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(20, 115);
		((Control)w).Name = "txtPass";
		w.PasswordChar = '*';
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(156, 21);
		((Control)w).TabIndex = 3;
		((EditBase)w).TextAlignment = (TextAlignment)1;
		((EditBase)w).VisualStyle = (VisualStyle)2;
		((Control)x).Anchor = (AnchorStyles)9;
		((Control)x).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(179, 115);
		((Control)x).Name = "label6";
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(61, 21);
		((Control)x).TabIndex = 80;
		((Control)x).Text = "کلمه عبور :";
		x.TextAlign = (ContentAlignment)64;
		((Control)m).AutoSize = true;
		((Control)m).Location = new Point(183, 26);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(26, 13);
		((Control)m).TabIndex = 39;
		((Control)m).Text = "دوره";
		((UIComboBase)n).ComboStyle = (ComboStyle)1;
		((UIComboBase)n).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(20, 26);
		((Control)n).Name = "dropExam";
		((Control)n).Size = new Size(154, 23);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)n).StringFormat = val5;
		((Control)n).TabIndex = 1;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)this.m_g).Location = new Point(19, 146);
		((Control)this.m_g).Name = "btnCancel";
		((Control)this.m_g).Size = new Size(75, 23);
		((Control)this.m_g).TabIndex = 5;
		((Control)this.m_g).Text = "انصراف";
		((Control)this.m_g).Click += d;
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)this.m_h).Location = new Point(100, 146);
		((Control)this.m_h).Name = "btnAcp";
		((Control)this.m_h).Size = new Size(75, 23);
		((Control)this.m_h).TabIndex = 4;
		((Control)this.m_h).Text = "تایید";
		((Control)this.m_h).Click += f;
		((Control)p).Location = new Point(13, 505);
		((Control)p).Name = "progressBar1";
		((Control)p).Size = new Size(763, 23);
		((Control)p).TabIndex = 13;
		((Control)this.m_d).Controls.Add((Control)(object)t);
		((Control)this.m_d).Controls.Add((Control)(object)q);
		((Control)this.m_d).Controls.Add((Control)(object)s);
		((Control)this.m_d).Location = new Point(10, 356);
		((Control)this.m_d).Name = "uiGroupBox1";
		((Control)this.m_d).Size = new Size(773, 116);
		((Control)this.m_d).TabIndex = 12;
		((Control)this.m_d).Text = "جزئیات آخرین ارسال";
		((Control)t).Anchor = (AnchorStyles)10;
		((Control)t).Location = new Point(638, 75);
		((Control)t).Name = "btnContinue";
		((Control)t).Size = new Size(128, 32);
		((Control)t).TabIndex = 9;
		((Control)t).Text = "ادامه ارسال";
		((Control)t).Visible = false;
		t.VisualStyle = (VisualStyle)3;
		((Control)t).Click += c;
		((Control)q).Location = new Point(3, 78);
		((Control)q).Name = "tbProgress";
		((Control)q).Size = new Size(629, 29);
		((Control)q).TabIndex = 7;
		q.TextAlign = (ContentAlignment)32;
		((Control)s).Anchor = (AnchorStyles)9;
		val6.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		s.DesignTimeLayout = val6;
		s.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)s).Font = new Font("Tahoma", 8.25f);
		s.GroupByBoxVisible = false;
		((Control)s).Location = new Point(-10, 19);
		((Control)s).Name = "gridEX2";
		((Control)s).Size = new Size(782, 44);
		((Control)s).TabIndex = 8;
		((ScrollableBase)s).VisualStyle = (VisualStyle)2;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(636, 8);
		((Control)this.m_e).Name = "label1";
		((Control)this.m_e).Size = new Size(143, 13);
		((Control)this.m_e).TabIndex = 11;
		((Control)this.m_e).Text = "تاریخچه ارسال نمرات به سایت";
		((Control)i).Anchor = (AnchorStyles)14;
		((Control)i).Controls.Add((Control)(object)j);
		((Control)i).Controls.Add((Control)(object)k);
		((Control)i).Location = new Point(3, 543);
		((Control)i).Name = "p_new";
		((Control)i).Size = new Size(784, 41);
		((Control)i).TabIndex = 9;
		((Control)j).Anchor = (AnchorStyles)6;
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(30, 30);
		((Control)j).Location = new Point(7, 3);
		((Control)j).Name = "btnClose";
		((Control)j).Size = new Size(75, 32);
		((Control)j).TabIndex = 15;
		((Control)j).Text = "خروج";
		j.TextHorizontalAlignment = (TextAlignment)1;
		((Control)j).Click += e;
		((Control)k).Anchor = (AnchorStyles)10;
		k.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)k).Location = new Point(648, 3);
		((Control)k).Name = "btnNew";
		((Control)k).Size = new Size(128, 32);
		((Control)k).TabIndex = 0;
		((Control)k).Text = "ارسال جدید";
		((Control)k).Click += g;
		((Control)l).Anchor = (AnchorStyles)15;
		val7.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		l.DesignTimeLayout = val7;
		l.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)l).Font = new Font("Tahoma", 8.25f);
		l.GroupByBoxVisible = false;
		((Control)l).Location = new Point(3, 28);
		((Control)l).Name = "gridEX1";
		((ScrollableBase)l).RecordNavigator = true;
		l.RowHeaders = (InheritableBoolean)1;
		((Control)l).Size = new Size(782, 312);
		((Control)l).TabIndex = 5;
		((ScrollableBase)l).VisualStyle = (VisualStyle)2;
		o.DoWork += a;
		o.RunWorkerCompleted += a;
		o.ProgressChanged += a;
		((Form)this).AcceptButton = (IButtonControl)(object)this.m_h;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 600);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmExportMarkToSite";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "ارسال نمرات به سایت";
		((Form)this).Load += h;
		((Form)this).FormClosing += a;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((ISupportInitialize)z).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((ISupportInitialize)s).EndInit();
		((Control)i).ResumeLayout(false);
		((ISupportInitialize)l).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asdcc()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		f();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			ae = asdcb.a(asdab.e(), CommandType.Text, "SELECT con FROM  tCon").ToString();
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num2 = 1;
					goto IL_011b;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((!(s.GetRow(0).Cells["TimeFinish"].Value.ToString() == "")) ? 1 : 0);
					goto IL_011b;
				case 2:
				{
					((Control)t).Visible = true;
					string text = "آخرین ارسال شما به طور کامل انجام نشده است";
					text += "\n";
					text += "شما میتوانید از دکمه *ادامه ارسال* برای کامل شدن مراحل ارسال استفاده نمایید";
					MessageBox.Show(text);
					num = 1;
					continue;
				}
				case 1:
					return;
				case 0:
					try
					{
						((DbConnection)(object)ad).ConnectionString = asdab.c(ae);
					}
					catch
					{
						MessageBox.Show("مشخصات سرور اشتباه است");
						return;
					}
					ab.SelectedIndex = 0;
					a();
					e();
					d();
					c();
					if (true)
					{
					}
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 4:
					{
						num = ((s.RowCount > 0) ? 3 : 7);
						continue;
					}
					IL_011b:
					flag = (byte)num2 != 0;
					num = 6;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     dbo.tExportRpt.id, dbo.tExportRpt.xExam, dbo.tExportRpt.DateExport, dbo.tExportRpt.TimeStart, dbo.tExportRpt.TimeFinish, dbo.tExportRpt.countStd, \r\n                      dbo.tExam.Name, dbo.tExam.DateFrom, dbo.tExam.DateTo, dbo.tExportRpt.main, dbo.tExportRpt.std, dbo.tExportRpt.mark, \r\n                      dbo.tExportRpt.markDoreh\r\nFROM         dbo.tExportRpt INNER JOIN\r\n                      dbo.tExam ON dbo.tExportRpt.xExam = dbo.tExam.id");
		l.DataSource = dataSource;
	}

	private void d()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT TOP 1  dbo.tExportRpt.id, dbo.tExportRpt.xExam, dbo.tExportRpt.DateExport, dbo.tExportRpt.TimeStart, dbo.tExportRpt.TimeFinish, dbo.tExportRpt.countStd, \r\n                      dbo.tExam.Name, dbo.tExam.DateFrom, dbo.tExam.DateTo, dbo.tExportRpt.main, dbo.tExportRpt.std, dbo.tExportRpt.mark, \r\n                      dbo.tExportRpt.markDoreh\r\n                      FROM dbo.tExportRpt INNER JOIN\r\n                      dbo.tExam ON dbo.tExportRpt.xExam = dbo.tExam.id\r\n                      ORDER BY tExportRpt.id DESC");
		s.DataSource = dataSource;
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass");
		z.DataSource = dataSource;
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ah = "1";
		((Control)y).Visible = true;
		((Control)n).Enabled = true;
		((Control)this.m_f).Visible = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Invalid comparison between I4 and Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected Obj, but got Unknown
		string text5 = default;
		string text4 = default;
		int num2 = default;
		DataTable dataTable = default;
		string text = default;
		string text3 = default;
		while (true)
		{
			bool flag = n.SelectedIndex >= 0;
			int num = 23;
			while (true)
			{
				switch (num)
				{
				case 23:
					if (!flag)
					{
						num = 28;
						continue;
					}
					flag = !(((Control)u).Text == "");
					num = 56;
					continue;
				case 34:
					af = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(xStudent) FROM tMarkDoreh WHERE " + text5 + " (typ = 5) AND Xtest = " + n.SelectedValue).ToString();
					flag = !(af == "0");
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 19;
						continue;
					}
					flag = 6 != (int)MessageBox.Show("تعداد نفرات برای ارسال نمره " + af + " نفر.آیا از ارسال نمرات دوره انتخابی مطمئن هستید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 35;
					continue;
				case 18:
					flag = !(text4 != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 8;
				case 45:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 9;
				case 53:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 29;
				case 43:
					asdcb.d(asdab.e(), CommandType.Text, string.Concat(new object[9]
					{
						"INSERT INTO tExportRpt  (xExam, DateExport, TimeStart, countStd)\r\n                          VALUES     (",
						n.SelectedValue,
						", N'",
						asdab.b(),
						"', N'",
						asdab.d(),
						"', ",
						af,
						")"
					}));
					e();
					d();
					((Control)l).Refresh();
					((Control)s).Refresh();
					num = 1;
					continue;
				case 37:
					text5 = " xStudent in(SELECT  id FROM  tStudent WHERE  (xClass IN (" + text4 + "))) and ";
					num = 34;
					continue;
				case 8:
					text4 += z.GetRow(num2).Cells["id"].Value.ToString();
					num = 5;
					continue;
				case 9:
					flag = o.IsBusy;
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 41:
					num = 0;
					continue;
				case 0:
					return;
				case 28:
					MessageBox.Show("دوره مورد نظر را انتخاب کنید");
					num = 32;
					continue;
				case 32:
					return;
				case 7:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 5;
				case 6:
					num2 = 0;
					num = 50;
					continue;
				case 13:
				case 50:
					flag = num2 < z.RowCount;
					num = 52;
					continue;
				case 52:
					if (flag)
					{
						flag = !(z.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 7;
					}
					else
					{
						num = 54;
					}
					continue;
				case 4:
					flag = !(ah == "1");
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 1;
				case 24:
					flag = ((DbConnection)(object)ad).State != ConnectionState.Open;
					num = 55;
					continue;
				case 55:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 38;
				case 29:
				{
					try
					{
						while (true)
						{
							IL_05bd:
							flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 1;
								case 3:
									((DbConnection)(object)ad).Open();
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_05a4;
								}
								goto IL_05bd;
								continue;
								end_IL_05a4:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("ارتباط با سرور برقرار نشد-از ارتباط کامپیوتر با اینترنت مطمئن شوید");
						return;
					}
					((DbConnection)(object)ad).Close();
					SqlParameter[] a_2 = new SqlParameter[3]
					{
						asdcb.a("@id", SqlDbType.NVarChar, 50, asdab.n),
						asdcb.a("@uid", SqlDbType.NVarChar, 50, ((Control)u).Text),
						asdcb.a("@pwd", SqlDbType.NVarChar, 500, asdab.d(((Control)w).Text))
					};
					dataTable = asdcb.c(asdab.c(ae), CommandType.StoredProcedure, "spCheckSchool", a_2);
					text = "0";
					text3 = "0";
					flag = dataTable.Rows.Count != 0;
					num = 31;
					continue;
				}
				case 31:
				{
					if (!flag)
					{
						num = 15;
						continue;
					}
					text = dataTable.Rows[0]["countStd"].ToString();
					text3 = dataTable.Rows[0]["countDoreh"].ToString();
					((Control)w).Text = "";
					string text6 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + n.SelectedValue).ToString();
					flag = !(text6 != "1");
					num = 57;
					continue;
				}
				case 35:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 41;
				case 54:
					flag = !(text4 == "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 58;
						continue;
					}
					if (true)
					{
					}
					num = 29;
					continue;
				case 26:
					text4 += ",";
					num = 8;
					continue;
				case 38:
				{
					string text7 = "شما تنها " + text3.ToString() + " دوره فعال در سایت میتوانید داشته باشید";
					text7 += "\n";
					text7 += "برای پا کردن دوره های قبلی به سایت مراجعه نمایید";
					MessageBox.Show(text7);
					num = 22;
					continue;
				}
				case 22:
					return;
				case 58:
					MessageBox.Show("صنفی انتخاب نشده است");
					((Control)z).Focus();
					num = 12;
					continue;
				case 12:
					return;
				case 5:
					num2++;
					num = 13;
					continue;
				case 19:
					MessageBox.Show("نمره ای برای ارسال وجود ندارد");
					num = 40;
					continue;
				case 40:
					return;
				case 56:
					if (!flag)
					{
						num = 11;
						continue;
					}
					flag = !(((Control)w).Text == "");
					num = 33;
					continue;
				case 51:
					text5 = "";
					flag = !(text4 != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 37;
						continue;
					}
					goto case 34;
				case 57:
					if (!flag)
					{
						num = 47;
						continue;
					}
					goto case 51;
				case 25:
					((DbConnection)(object)ad).Close();
					num = 38;
					continue;
				case 15:
					MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
					((Control)w).Text = "";
					((Control)w).Focus();
					num = 21;
					continue;
				case 21:
					return;
				case 1:
					((Control)t).Visible = false;
					((Control)k).Enabled = false;
					((Control)this.m_f).Visible = false;
					o.RunWorkerAsync();
					num = 2;
					continue;
				case 33:
					if (flag)
					{
						text4 = "";
						flag = !(ab.SelectedValue.ToString() == "1");
						num = 53;
					}
					else
					{
						num = 39;
					}
					continue;
				case 11:
					MessageBox.Show("نام کاربری را وارد کنید");
					((Control)u).Focus();
					num = 30;
					continue;
				case 30:
					return;
				case 2:
					num = 41;
					continue;
				case 47:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, n.SelectedValue) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
					num = 51;
					continue;
				}
				case 39:
					MessageBox.Show("کلمه عبور را وارد کنید");
					((Control)w).Focus();
					num = 42;
					continue;
				case 42:
					return;
				case 27:
					b();
					num = 9;
					continue;
				case 48:
					flag = int.Parse(af) <= int.Parse(text);
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						try
						{
							while (true)
							{
								IL_0298:
								flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
								num = 0;
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
										goto case 2;
									case 3:
										((DbConnection)(object)ad).Open();
										num = 2;
										continue;
									case 2:
										num = 1;
										continue;
									case 1:
										goto end_IL_027f;
									}
									goto IL_0298;
									continue;
									end_IL_027f:
									break;
								}
								break;
							}
						}
						catch
						{
							MessageBox.Show("ارتباط با سرور برقرار نشد-از ارتباط کامپیوتر با اینترنت مطمئن شوید");
							return;
						}
						SqlCommand val = new SqlCommand("SELECT COUNT(id) FROM tExam" + asdab.n + " where id<>" + n.SelectedValue.ToString(), ad);
						string text2 = ((DbCommand)(object)val).ExecuteScalar().ToString();
						flag = int.Parse(text2) < int.Parse(text3);
						num = 44;
					}
					else
					{
						num = 46;
					}
					continue;
				case 46:
					MessageBox.Show("تعداد نمرات ارسالی بیش از حد مجاز برای مدرسه شما میباشد.تعداد مجوز مدرسه شما " + text.ToString() + " شاگرد میباشد");
					num = 49;
					continue;
				case 49:
					return;
				case 44:
					if (flag)
					{
						flag = !y.Checked;
						num = 45;
					}
					else
					{
						num = 24;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		asdcb.d(asdab.e(), CommandType.Text, "update tBook set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tClass set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tMark set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tMarkDoreh set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tParmetr set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tPaye set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tStudent set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tTeacher set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tTosif set xExportRpt=null");
		try
		{
			if (true)
			{
			}
			((DbConnection)(object)ad).Open();
		}
		catch
		{
		}
		SqlCommand val = new SqlCommand("delete from tmark" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tMarkDoreh" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tBook" + asdab.n, ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tClass" + asdab.n, ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tParmetr" + asdab.n, ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tPaye" + asdab.n, ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tTeacher" + asdab.n, ad);
		((DbCommand)(object)val).ExecuteNonQuery();
		val = new SqlCommand("delete from tTosif" + asdab.n, ad);
		((DbCommand)(object)val).ExecuteNonQuery();
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam order by id desc");
		n.DataSource = dataSource;
		n.DisplayMember = "Name";
		n.ValueMember = "id";
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}

	private void a(object A_0, DoWorkEventArgs A_1)
	{
		//IL_3385: Unknown result type (might be due to invalid IL or missing references)
		//IL_338b: Expected Obj, but got Unknown
		//IL_1928: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Expected Obj, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Expected Obj, but got Unknown
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected Obj, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected Obj, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected Obj, but got Unknown
		//IL_3655: Unknown result type (might be due to invalid IL or missing references)
		//IL_365c: Expected Obj, but got Unknown
		//IL_3886: Unknown result type (might be due to invalid IL or missing references)
		//IL_388c: Expected Obj, but got Unknown
		//IL_427c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4283: Expected Obj, but got Unknown
		//IL_2135: Unknown result type (might be due to invalid IL or missing references)
		//IL_213c: Expected Obj, but got Unknown
		//IL_1bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb7: Expected Obj, but got Unknown
		//IL_3a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a27: Expected Obj, but got Unknown
		//IL_2a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3f: Expected Obj, but got Unknown
		//IL_30fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3100: Expected Obj, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected Obj, but got Unknown
		//IL_2585: Unknown result type (might be due to invalid IL or missing references)
		//IL_258b: Expected Obj, but got Unknown
		//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1a: Expected Obj, but got Unknown
		//IL_2986: Unknown result type (might be due to invalid IL or missing references)
		//IL_298d: Expected Obj, but got Unknown
		//IL_29b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b6: Expected Obj, but got Unknown
		//IL_29f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_41dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ee: Expected Obj, but got Unknown
		//IL_2411: Unknown result type (might be due to invalid IL or missing references)
		//IL_2417: Expected Obj, but got Unknown
		//IL_1992: Unknown result type (might be due to invalid IL or missing references)
		//IL_1999: Expected Obj, but got Unknown
		//IL_2d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d58: Expected Obj, but got Unknown
		//IL_132a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1330: Expected Obj, but got Unknown
		//IL_2b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b59: Expected Obj, but got Unknown
		//IL_346a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3471: Expected Obj, but got Unknown
		//IL_1e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2d: Expected Obj, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_407b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4082: Expected Obj, but got Unknown
		//IL_411d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4124: Expected Obj, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_2697: Unknown result type (might be due to invalid IL or missing references)
		//IL_269d: Expected Obj, but got Unknown
		//IL_3088: Unknown result type (might be due to invalid IL or missing references)
		//IL_308f: Expected Obj, but got Unknown
		//IL_3eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef3: Expected Obj, but got Unknown
		//IL_2703: Unknown result type (might be due to invalid IL or missing references)
		//IL_270a: Expected Obj, but got Unknown
		//IL_272d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2733: Expected Obj, but got Unknown
		//IL_3fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fbc: Expected Obj, but got Unknown
		//IL_3fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fe5: Expected Obj, but got Unknown
		//IL_461f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4625: Expected Obj, but got Unknown
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d2: Expected Obj, but got Unknown
		//IL_2fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff4: Expected Obj, but got Unknown
		string text2 = default;
		DataTable dataTable = default;
		int num2 = default;
		string text3 = default;
		SqlCommand val = default;
		while (true)
		{
			string text = "";
			bool flag = !(ab.SelectedValue.ToString() == "1");
			int num = 106;
			while (true)
			{
				switch (num)
				{
				case 106:
					if (!flag)
					{
						num = 290;
						continue;
					}
					goto case 208;
				case 192:
				{
					SqlCommand val2 = new SqlCommand("update tStudent set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 193;
					continue;
				}
				case 250:
					((DbConnection)(object)ad).Open();
					num = 13;
					continue;
				case 68:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tMark.Xtest, tStudent.xClass, tMark.xbook, AVG(tMark.Mark) AS avgMark, MAX(tMark.Mark) AS maxMark, MIN(tMark.Mark) AS MinMark\r\n                                                                    FROM tMark INNER JOIN tStudent ON tMark.xStudent = tStudent.id\r\n                                                                     WHERE  " + text3 + "   (tMark.Xtest = " + n.SelectedValue.ToString() + ") GROUP BY tMark.Xtest, tMark.xbook, tStudent.xClass");
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 260;
					continue;
				case 260:
					if (!flag)
					{
						num = 124;
						continue;
					}
					goto case 212;
				case 93:
					val.Parameters.AddWithValue("@M3", (object)DBNull.Value);
					num = 184;
					continue;
				case 216:
					A_1.Cancel = true;
					num = 36;
					continue;
				case 36:
					return;
				case 75:
					num2 = 0;
					num = 88;
					continue;
				case 37:
					if (!flag)
					{
						num = 186;
						continue;
					}
					goto case 199;
				case 111:
					A_1.Cancel = true;
					num = 112;
					continue;
				case 112:
					return;
				case 176:
					val.Parameters.AddWithValue("@M7", (object)DBNull.Value);
					num = 8;
					continue;
				case 113:
					A_1.Cancel = true;
					num = 70;
					continue;
				case 70:
					return;
				case 69:
				case 242:
					flag = num2 < dataTable.Rows.Count;
					num = 49;
					continue;
				case 49:
					if (!flag)
					{
						num = 221;
						continue;
					}
					flag = !o.CancellationPending;
					num = 73;
					continue;
				case 163:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 29;
				case 268:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     Xtest, xbook, AVG(Mark) AS avgMark, MAX(Mark) AS maxMark, MIN(Mark) AS MinMark FROM tMark\r\n                                                                               WHERE     (Xtest = " + n.SelectedValue.ToString() + ") GROUP BY Xtest, xbook");
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 167;
					continue;
				case 167:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 89;
				case 77:
					val = new SqlCommand("DELETE FROM vAvgBook_Class" + asdab.n + " where " + text3 + " xtest=" + n.SelectedValue.ToString(), ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 24;
					continue;
				case 120:
				case 182:
					flag = !(dataTable.Rows[num2]["M9"].ToString() == "");
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						val.Parameters.AddWithValue("@M9", (object)dataTable.Rows[num2]["M9"].ToString());
						num = 87;
					}
					else
					{
						num = 288;
					}
					continue;
				case 259:
					val.Parameters.AddWithValue("@M2", (object)DBNull.Value);
					num = 52;
					continue;
				case 105:
					((Control)r).Text = "دروس";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tBook where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 214;
						continue;
					}
					goto case 54;
				case 239:
				case 243:
					flag = num2 < dataTable.Rows.Count;
					num = 249;
					continue;
				case 249:
					if (!flag)
					{
						num = 105;
						continue;
					}
					flag = !o.CancellationPending;
					num = 275;
					continue;
				case 28:
					if (!flag)
					{
						num = 220;
						continue;
					}
					goto case 95;
				case 41:
					((DbConnection)(object)ad).Open();
					num = 229;
					continue;
				case 124:
					((DbConnection)(object)ac).Open();
					num = 212;
					continue;
				case 81:
				case 184:
					flag = !(dataTable.Rows[num2]["M4"].ToString() == "");
					num = 143;
					continue;
				case 143:
					if (!flag)
					{
						num = 61;
						continue;
					}
					val.Parameters.AddWithValue("@M4", (object)dataTable.Rows[num2]["M4"].ToString());
					num = 272;
					continue;
				case 292:
					((DbConnection)(object)ac).Open();
					num = 273;
					continue;
				case 157:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     dbo.tMarkDoreh.Xtest, dbo.tStudent.xClass, COUNT(dbo.tMarkDoreh.xStudent) AS countStd, AVG(dbo.tMarkDoreh.MarkDoreh) AS avgMark, \r\n                      MAX(dbo.tMarkDoreh.MarkDoreh) AS maxMark, MIN(dbo.tMarkDoreh.MarkDoreh) AS MinMark\r\n                        FROM         dbo.tMarkDoreh INNER JOIN\r\n                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id\r\n                        WHERE  " + text3 + "   (dbo.tMarkDoreh.typ = 5) AND    (Xtest = " + n.SelectedValue.ToString() + ") GROUP BY dbo.tMarkDoreh.Xtest, dbo.tStudent.xClass");
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 119;
					continue;
				case 119:
					if (!flag)
					{
						num = 292;
						continue;
					}
					goto case 273;
				case 35:
					((DbConnection)(object)ac).Open();
					num = 136;
					continue;
				case 53:
				case 82:
					flag = num2 < z.RowCount;
					num = 2;
					continue;
				case 2:
					if (flag)
					{
						flag = !(z.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 163;
					}
					else
					{
						num = 165;
					}
					continue;
				case 158:
					num2 = 0;
					num = 71;
					continue;
				case 107:
					((DbConnection)(object)ad).Open();
					num = 104;
					continue;
				case 286:
					((DbConnection)(object)ad).Open();
					num = 190;
					continue;
				case 140:
					flag = num2 < dataTable.Rows.Count;
					num = 241;
					continue;
				case 241:
					if (!flag)
					{
						num = 268;
						continue;
					}
					flag = !o.CancellationPending;
					num = 281;
					continue;
				case 139:
					text += z.GetRow(num2).Cells["id"].Value.ToString();
					num = 29;
					continue;
				case 87:
				case 254:
					flag = !(dataTable.Rows[num2]["M10"].ToString() == "");
					num = 114;
					continue;
				case 114:
					if (!flag)
					{
						num = 137;
						continue;
					}
					val.Parameters.AddWithValue("@M10", (object)dataTable.Rows[num2]["M10"].ToString());
					num = 203;
					continue;
				case 185:
					num2++;
					num = 140;
					continue;
				case 146:
				case 169:
					flag = !(dataTable.Rows[num2]["M1"].ToString() == "");
					num = 234;
					continue;
				case 234:
					if (!flag)
					{
						num = 50;
						continue;
					}
					val.Parameters.AddWithValue("@M1", (object)dataTable.Rows[num2]["M1"].ToString());
					num = 244;
					continue;
				case 177:
				{
					if (!flag)
					{
						num = 44;
						continue;
					}
					val = new SqlCommand("sp_tParmetr" + asdab.n + "_InsertUpdate", ad);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@heder1", (object)dataTable.Rows[num2]["heder1"].ToString());
					val.Parameters.AddWithValue("@heder2", (object)dataTable.Rows[num2]["heder2"].ToString());
					val.Parameters.AddWithValue("@Foter1", (object)dataTable.Rows[num2]["Foter1"].ToString());
					val.Parameters.AddWithValue("@Foter2", (object)dataTable.Rows[num2]["Foter2"].ToString());
					val.Parameters.AddWithValue("@sch", (object)dataTable.Rows[num2]["sch"].ToString());
					val.Parameters.AddWithValue("@xExportRpt", (object)text2);
					int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num3 <= 0;
					num = 217;
					continue;
				}
				case 89:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 38;
					continue;
				case 38:
					if (!flag)
					{
						num = 94;
						continue;
					}
					goto case 181;
				case 90:
				case 99:
					flag = num2 < dataTable.Rows.Count;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 228;
						continue;
					}
					flag = !o.CancellationPending;
					num = 183;
					continue;
				case 67:
					((DbConnection)(object)ad).Open();
					num = 77;
					continue;
				case 104:
					num2 = 0;
					num = 197;
					continue;
				case 232:
				case 272:
					flag = !(dataTable.Rows[num2]["M5"].ToString() == "");
					num = 266;
					continue;
				case 266:
					if (!flag)
					{
						num = 40;
						continue;
					}
					val.Parameters.AddWithValue("@M5", (object)dataTable.Rows[num2]["M5"].ToString());
					num = 18;
					continue;
				case 145:
				case 170:
					flag = !(dataTable.Rows[num2]["M7"].ToString() == "");
					num = 248;
					continue;
				case 248:
					if (!flag)
					{
						num = 176;
						continue;
					}
					val.Parameters.AddWithValue("@M7", (object)dataTable.Rows[num2]["M7"].ToString());
					num = 72;
					continue;
				case 103:
					if (flag)
					{
						val = new SqlCommand("sp_vAvgBook" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
						val.Parameters.AddWithValue("@xbook", (object)dataTable.Rows[num2]["xbook"].ToString());
						val.Parameters.AddWithValue("@avgMark", (object)dataTable.Rows[num2]["avgMark"].ToString());
						val.Parameters.AddWithValue("@maxMark", (object)dataTable.Rows[num2]["maxMark"].ToString());
						val.Parameters.AddWithValue("@MinMark", (object)dataTable.Rows[num2]["MinMark"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						num2++;
						num = 240;
					}
					else
					{
						num = 134;
					}
					continue;
				case 199:
					num2++;
					num = 90;
					continue;
				case 294:
					((Control)r).Text = "پایه ها";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tPaye where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 194;
					continue;
				case 194:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 109;
				case 245:
					num2++;
					num = 4;
					continue;
				case 285:
					if (!flag)
					{
						num = 51;
						continue;
					}
					goto case 185;
				case 92:
					if (!flag)
					{
						num = 213;
						continue;
					}
					val = new SqlCommand("sp_tMark" + asdab.n + "_InsertUpdate", ad);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@xStudent", (object)dataTable.Rows[num2]["xStudent"].ToString());
					val.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
					val.Parameters.AddWithValue("@typ", (object)dataTable.Rows[num2]["typ"].ToString());
					val.Parameters.AddWithValue("@xbook", (object)dataTable.Rows[num2]["xbook"].ToString());
					flag = !(dataTable.Rows[num2]["CountAb"].ToString() == "");
					num = 102;
					continue;
				case 13:
					val = new SqlCommand("DELETE FROM tTch_Cls" + asdab.n, ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 99;
					continue;
				case 7:
					num2 = 0;
					num = 69;
					continue;
				case 154:
				{
					SqlCommand val2 = new SqlCommand("update tPaye set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 115;
					continue;
				}
				case 73:
				{
					if (!flag)
					{
						num = 247;
						continue;
					}
					val = new SqlCommand("sp_tBook" + asdab.n + "_InsertUpdate", ad);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
					val.Parameters.AddWithValue("@xPaye", (object)dataTable.Rows[num2]["xPaye"].ToString());
					val.Parameters.AddWithValue("@Name", (object)dataTable.Rows[num2]["Name"].ToString());
					val.Parameters.AddWithValue("@vahed", (object)dataTable.Rows[num2]["vahed"].ToString());
					val.Parameters.AddWithValue("@timeWeek", (object)dataTable.Rows[num2]["timeWeek"].ToString());
					val.Parameters.AddWithValue("@Type", (object)dataTable.Rows[num2]["Type"].ToString());
					val.Parameters.AddWithValue("@sort", (object)dataTable.Rows[num2]["sort"].ToString());
					val.Parameters.AddWithValue("@xExportRpt", (object)text2);
					int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num3 <= 0;
					num = 233;
					continue;
				}
				case 60:
					if (!flag)
					{
						num = 178;
						continue;
					}
					goto case 245;
				case 137:
					val.Parameters.AddWithValue("@M10", (object)DBNull.Value);
					num = 84;
					continue;
				case 251:
					((DbConnection)(object)ad).Open();
					num = 158;
					continue;
				case 233:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 256;
				case 238:
					A_1.Cancel = true;
					num = 187;
					continue;
				case 187:
					return;
				case 116:
					((DbConnection)(object)ac).Open();
					num = 57;
					continue;
				case 164:
					if (flag)
					{
						val = new SqlCommand("sp_vAvgBook_Class" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
						val.Parameters.AddWithValue("@xClass", (object)dataTable.Rows[num2]["xClass"].ToString());
						val.Parameters.AddWithValue("@xbook", (object)dataTable.Rows[num2]["xbook"].ToString());
						val.Parameters.AddWithValue("@avgMark", (object)dataTable.Rows[num2]["avgMark"].ToString());
						val.Parameters.AddWithValue("@maxMark", (object)dataTable.Rows[num2]["maxMark"].ToString());
						val.Parameters.AddWithValue("@MinMark", (object)dataTable.Rows[num2]["MinMark"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						num2++;
						num = 59;
					}
					else
					{
						num = 111;
					}
					continue;
				case 162:
					num2++;
					num = 144;
					continue;
				case 179:
					val = new SqlCommand("DELETE FROM tTosif" + asdab.n, ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 30;
					continue;
				case 30:
					if (1 == 0)
					{
					}
					goto case 140;
				case 29:
					num2++;
					num = 53;
					continue;
				case 281:
					if (flag)
					{
						val = new SqlCommand("sp_tTosif" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
						val.Parameters.AddWithValue("@fromMark", (object)dataTable.Rows[num2]["fromMark"].ToString());
						val.Parameters.AddWithValue("@toMark", (object)dataTable.Rows[num2]["toMark"].ToString());
						val.Parameters.AddWithValue("@tosif", (object)dataTable.Rows[num2]["tosif"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = num3 <= 0;
						num = 285;
					}
					else
					{
						num = 216;
					}
					continue;
				case 109:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 91;
					continue;
				case 91:
					if (!flag)
					{
						num = 286;
						continue;
					}
					goto case 190;
				case 42:
					((DbConnection)(object)ad).Open();
					num = 75;
					continue;
				case 127:
					((DbConnection)(object)ac).Open();
					num = 226;
					continue;
				case 155:
					A_1.Cancel = true;
					num = 204;
					continue;
				case 204:
					return;
				case 5:
					((DbConnection)(object)ac).Open();
					num = 109;
					continue;
				case 136:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 62;
					continue;
				case 62:
					if (!flag)
					{
						num = 211;
						continue;
					}
					goto case 65;
				case 117:
					((DbConnection)(object)ac).Open();
					num = 152;
					continue;
				case 290:
					num2 = 0;
					num = 82;
					continue;
				case 14:
					flag = !(text != "");
					num = 76;
					continue;
				case 76:
					if (!flag)
					{
						num = 205;
						continue;
					}
					goto case 139;
				case 74:
					((Control)r).Text = "tch-cls";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM  tTch_Cls where xCls>0");
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 291;
					continue;
				case 291:
					if (!flag)
					{
						num = 116;
						continue;
					}
					goto case 57;
				case 48:
					((DbConnection)(object)ac).Open();
					num = 173;
					continue;
				case 247:
					A_1.Cancel = true;
					num = 263;
					continue;
				case 263:
					return;
				case 78:
				case 98:
					flag = num2 < dataTable.Rows.Count;
					num = 66;
					continue;
				case 66:
					if (!flag)
					{
						num = 294;
						continue;
					}
					flag = !o.CancellationPending;
					num = 21;
					continue;
				case 142:
					A_1.Cancel = true;
					num = 278;
					continue;
				case 278:
					return;
				case 51:
				{
					SqlCommand val2 = new SqlCommand("update tTosif set xExportRpt=" + text2, ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					num = 185;
					continue;
				}
				case 52:
				case 133:
					flag = !(dataTable.Rows[num2]["M3"].ToString() == "");
					num = 261;
					continue;
				case 261:
					if (!flag)
					{
						num = 93;
						continue;
					}
					val.Parameters.AddWithValue("@M3", (object)dataTable.Rows[num2]["M3"].ToString());
					num = 81;
					continue;
				case 174:
					num2 = 0;
					num = 246;
					continue;
				case 27:
					if (flag)
					{
						val = new SqlCommand("sp_tExam" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
						val.Parameters.AddWithValue("@NumExam", (object)dataTable.Rows[num2]["NumExam"].ToString());
						val.Parameters.AddWithValue("@Name", (object)dataTable.Rows[num2]["Name"].ToString());
						val.Parameters.AddWithValue("@DateFrom", (object)dataTable.Rows[num2]["DateFrom"].ToString());
						val.Parameters.AddWithValue("@DateTo", (object)dataTable.Rows[num2]["DateTo"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = num3 <= 0;
						num = 28;
					}
					else
					{
						num = 155;
					}
					continue;
				case 166:
					((DbConnection)(object)ac).Open();
					num = 101;
					continue;
				case 61:
					val.Parameters.AddWithValue("@M4", (object)DBNull.Value);
					num = 232;
					continue;
				case 193:
					num2++;
					num = 79;
					continue;
				case 118:
					if (flag)
					{
						val = new SqlCommand("sp_tTeacher" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
						val.Parameters.AddWithValue("@fNamF", (object)dataTable.Rows[num2]["fNamF"].ToString());
						val.Parameters.AddWithValue("@fNamL", (object)dataTable.Rows[num2]["fNamL"].ToString());
						val.Parameters.AddWithValue("@fEmail", (object)dataTable.Rows[num2]["fEmail"].ToString());
						val.Parameters.AddWithValue("@fPassword", (object)dataTable.Rows[num2]["fPassword"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = num3 <= 0;
						num = 60;
					}
					else
					{
						num = 188;
					}
					continue;
				case 213:
					A_1.Cancel = true;
					num = 235;
					continue;
				case 235:
					return;
				case 16:
					A_1.Cancel = true;
					num = 123;
					continue;
				case 123:
					return;
				case 275:
				{
					if (!flag)
					{
						num = 19;
						continue;
					}
					val = new SqlCommand("sp_tPaye" + asdab.n + "_InsertUpdate", ad);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
					val.Parameters.AddWithValue("@Name", (object)dataTable.Rows[num2]["Name"].ToString());
					val.Parameters.AddWithValue("@xExportRpt", (object)text2);
					int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num3 <= 0;
					num = 230;
					continue;
				}
				case 79:
				case 88:
					flag = num2 < dataTable.Rows.Count;
					num = 55;
					continue;
				case 55:
					if (!flag)
					{
						num = 237;
						continue;
					}
					flag = !o.CancellationPending;
					num = 156;
					continue;
				case 85:
					((DbConnection)(object)ad).Open();
					num = 174;
					continue;
				case 153:
					A_1.Cancel = true;
					num = 58;
					continue;
				case 58:
					return;
				case 225:
					((DbConnection)(object)ac).Open();
					num = 121;
					continue;
				case 151:
				{
					SqlCommand val2 = new SqlCommand("update tExportRpt set main=1 where id=" + text2, ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					val = new SqlCommand("update ExportRpt set main=1 where id=" + text2 + " and xschool=" + asdab.n, ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					d();
					((Control)r).Text = "شاگردان";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM  tStudent where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 110;
					continue;
				}
				case 110:
					if (!flag)
					{
						num = 127;
						continue;
					}
					goto case 226;
				case 279:
					text3 = " xStudent in(SELECT  id FROM  tStudent WHERE  (xClass IN (" + text + "))) and ";
					num = 80;
					continue;
				case 208:
				{
					((Control)t).Visible = false;
					((Control)q).Text = "در حال ارسال نمرات";
					text2 = s.GetRow(0).Cells["id"].Value.ToString();
					val = null;
					SqlCommand val2 = null;
					val = new SqlCommand("spExportRptInsert", ad);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@id", (object)text2);
					val.Parameters.AddWithValue("@xSchool", (object)asdab.n);
					val.Parameters.AddWithValue("@xExam", (object)n.SelectedValue.ToString());
					val.Parameters.AddWithValue("@countStd", (object)af);
					((DbCommand)(object)val).ExecuteNonQuery();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tParmetr");
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 10;
					continue;
				}
				case 10:
					if (!flag)
					{
						num = 283;
						continue;
					}
					goto case 287;
				case 282:
					val = new SqlCommand("DELETE FROM vAvgDoreh_Class" + asdab.n + " where " + text3 + " xtest=" + n.SelectedValue.ToString(), ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 131;
					continue;
				case 156:
				{
					if (!flag)
					{
						num = 153;
						continue;
					}
					val = new SqlCommand("sp_tStudent" + asdab.n + "_InsertUpdate", ad);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
					val.Parameters.AddWithValue("@code", (object)dataTable.Rows[num2]["code"].ToString());
					val.Parameters.AddWithValue("@xPaye", (object)dataTable.Rows[num2]["xPaye"].ToString());
					val.Parameters.AddWithValue("@xClass", (object)dataTable.Rows[num2]["xClass"].ToString());
					val.Parameters.AddWithValue("@xReshteh", (object)dataTable.Rows[num2]["xReshteh"].ToString());
					val.Parameters.AddWithValue("@FName", (object)dataTable.Rows[num2]["FName"].ToString());
					val.Parameters.AddWithValue("@LName", (object)dataTable.Rows[num2]["LName"].ToString());
					val.Parameters.AddWithValue("@PName", (object)dataTable.Rows[num2]["PName"].ToString());
					val.Parameters.AddWithValue("@Sh_Sh", (object)dataTable.Rows[num2]["Sh_Sh"].ToString());
					val.Parameters.AddWithValue("@pass", (object)dataTable.Rows[num2]["pass"].ToString());
					val.Parameters.AddWithValue("@pass2", (object)dataTable.Rows[num2]["pass2"].ToString());
					val.Parameters.AddWithValue("@xExportRpt", (object)text2);
					int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num3 <= 0;
					num = 227;
					continue;
				}
				case 223:
				{
					SqlCommand val2 = new SqlCommand("update tExportRpt set mark=1 where id=" + text2, ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					val = new SqlCommand("update ExportRpt set mark=1 where id=" + text2 + " and xschool=" + asdab.n, ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					d();
					((Control)r).Text = "نمره دوره";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tMarkDoreh where " + text3 + " xtest=" + n.SelectedValue.ToString() + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 45;
					continue;
				}
				case 45:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 64;
				case 65:
					num2 = 0;
					num = 1;
					continue;
				case 256:
					num2++;
					num = 242;
					continue;
				case 132:
					num2 = 0;
					num = 280;
					continue;
				case 80:
					((Control)r).Text = "نمره دروس";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tMark where " + text3 + " xtest=" + n.SelectedValue.ToString() + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 160;
					continue;
				case 160:
					if (!flag)
					{
						num = 117;
						continue;
					}
					goto case 152;
				case 190:
					num2 = 0;
					num = 243;
					continue;
				case 214:
					((DbConnection)(object)ac).Open();
					num = 54;
					continue;
				case 125:
				{
					SqlCommand val2 = new SqlCommand("update tExportRpt set markDoreh=1,TimeFinish=N'" + asdab.d() + "' where id=" + text2, ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					val = new SqlCommand("update ExportRpt set markDoreh=1, TimeFinish= CONVERT(VARCHAR(8),GETDATE(),108)  where id=" + text2 + " and xschool=" + asdab.n, ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					e();
					d();
					l.Row = 0;
					((DbConnection)(object)ad).Close();
					((DbConnection)(object)ac).Close();
					MessageBox.Show("عملیات ارسال با موفقیت به پایان رسید");
					((Control)r).Text = "";
					num = 175;
					continue;
				}
				case 175:
					return;
				case 138:
					if (!flag)
					{
						num = 210;
						continue;
					}
					goto case 196;
				case 283:
					((DbConnection)(object)ac).Open();
					num = 287;
					continue;
				case 217:
					if (!flag)
					{
						num = 33;
						continue;
					}
					goto case 162;
				case 206:
					((DbConnection)(object)ad).Open();
					num = 179;
					continue;
				case 226:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 148;
					continue;
				case 148:
					if (!flag)
					{
						num = 42;
						continue;
					}
					goto case 75;
				case 18:
				case 200:
					flag = !(dataTable.Rows[num2]["M6"].ToString() == "");
					num = 150;
					continue;
				case 150:
					if (flag)
					{
						val.Parameters.AddWithValue("@M6", (object)dataTable.Rows[num2]["M6"].ToString());
						num = 170;
					}
					else
					{
						num = 63;
					}
					continue;
				case 227:
					if (!flag)
					{
						num = 192;
						continue;
					}
					goto case 193;
				case 211:
					((DbConnection)(object)ad).Open();
					num = 65;
					continue;
				case 289:
				{
					SqlCommand val2 = new SqlCommand("update tMark set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 34;
					continue;
				}
				case 24:
				case 59:
					flag = num2 < dataTable.Rows.Count;
					num = 126;
					continue;
				case 126:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 164;
					}
					else
					{
						num = 157;
					}
					continue;
				case 210:
				{
					SqlCommand val2 = new SqlCommand("update tClass set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 196;
					continue;
				}
				case 224:
					val.Parameters.AddWithValue("@M8", (object)DBNull.Value);
					num = 182;
					continue;
				case 39:
					if (!flag)
					{
						num = 189;
						continue;
					}
					goto case 262;
				case 19:
					A_1.Cancel = true;
					num = 26;
					continue;
				case 26:
					return;
				case 6:
					((DbConnection)(object)ad).Open();
					num = 282;
					continue;
				case 129:
				case 246:
					flag = num2 < dataTable.Rows.Count;
					num = 265;
					continue;
				case 265:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 27;
					}
					else
					{
						num = 151;
					}
					continue;
				case 31:
					((DbConnection)(object)ac).Open();
					num = 64;
					continue;
				case 172:
				case 197:
					flag = num2 < dataTable.Rows.Count;
					num = 108;
					continue;
				case 108:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 92;
					}
					else
					{
						num = 223;
					}
					continue;
				case 229:
					val = new SqlCommand("DELETE FROM vAvgDoreh" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 78;
					continue;
				case 54:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 276;
						continue;
					}
					goto case 7;
				case 34:
					num2++;
					num = 172;
					continue;
				case 178:
				{
					SqlCommand val2 = new SqlCommand("update tTeacher set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 245;
					continue;
				}
				case 212:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 67;
						continue;
					}
					goto case 77;
				case 100:
					((DbConnection)(object)ac).Open();
					num = 25;
					continue;
				case 196:
					num2++;
					num = 269;
					continue;
				case 84:
				case 203:
				{
					val.Parameters.AddWithValue("@Mark", (object)dataTable.Rows[num2]["Mark"].ToString());
					val.Parameters.AddWithValue("@gClass", (object)dataTable.Rows[num2]["gClass"].ToString());
					val.Parameters.AddWithValue("@gKoll", (object)dataTable.Rows[num2]["gKoll"].ToString());
					val.Parameters.AddWithValue("@xExportRpt", (object)text2);
					int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num3 <= 0;
					num = 218;
					continue;
				}
				case 218:
					if (!flag)
					{
						num = 289;
						continue;
					}
					goto case 34;
				case 25:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 222;
					continue;
				case 222:
					if (!flag)
					{
						num = 206;
						continue;
					}
					goto case 179;
				case 134:
					A_1.Cancel = true;
					num = 159;
					continue;
				case 159:
					return;
				case 33:
				{
					SqlCommand val2 = new SqlCommand("update tParmetr set xExportRpt=" + text2, ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					num = 162;
					continue;
				}
				case 101:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 41;
						continue;
					}
					goto case 229;
				case 144:
				case 280:
					flag = num2 < dataTable.Rows.Count;
					num = 209;
					continue;
				case 209:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 177;
					}
					else
					{
						num = 128;
					}
					continue;
				case 50:
					val.Parameters.AddWithValue("@M1", (object)DBNull.Value);
					num = 293;
					continue;
				case 63:
					val.Parameters.AddWithValue("@M6", (object)DBNull.Value);
					num = 145;
					continue;
				case 131:
				case 277:
					flag = num2 < dataTable.Rows.Count;
					num = 231;
					continue;
				case 231:
					if (!flag)
					{
						num = 252;
						continue;
					}
					flag = !o.CancellationPending;
					num = 20;
					continue;
				case 228:
					((Control)r).Text = "دوره";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tExam where id=" + n.SelectedValue.ToString());
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 225;
						continue;
					}
					goto case 121;
				case 96:
					if (flag)
					{
						val = new SqlCommand("sp_tClass" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@id", (object)dataTable.Rows[num2]["id"].ToString());
						val.Parameters.AddWithValue("@xPaye", (object)dataTable.Rows[num2]["xPaye"].ToString());
						val.Parameters.AddWithValue("@Name", (object)dataTable.Rows[num2]["Name"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = num3 <= 0;
						num = 138;
					}
					else
					{
						num = 142;
					}
					continue;
				case 181:
					val = new SqlCommand("DELETE FROM vAvgBook" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 257;
					continue;
				case 64:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 236;
						continue;
					}
					goto case 191;
				case 97:
					if (flag)
					{
						val = new SqlCommand("sp_tMarkDoreh" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@xStudent", (object)dataTable.Rows[num2]["xStudent"].ToString());
						val.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
						val.Parameters.AddWithValue("@typ", (object)dataTable.Rows[num2]["typ"].ToString());
						val.Parameters.AddWithValue("@MarkDoreh", (object)dataTable.Rows[num2]["MarkDoreh"].ToString());
						val.Parameters.AddWithValue("@gClass", (object)dataTable.Rows[num2]["gClass"].ToString());
						val.Parameters.AddWithValue("@gPaye", (object)dataTable.Rows[num2]["gPaye"].ToString());
						val.Parameters.AddWithValue("@gKoll", (object)dataTable.Rows[num2]["gKoll"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = num3 <= 0;
						num = 39;
					}
					else
					{
						num = 113;
					}
					continue;
				case 44:
					A_1.Cancel = true;
					num = 264;
					continue;
				case 264:
					return;
				case 40:
					val.Parameters.AddWithValue("@M5", (object)DBNull.Value);
					num = 200;
					continue;
				case 183:
					if (flag)
					{
						val = new SqlCommand("sp_tTch_Cls" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@xCls", (object)dataTable.Rows[num2]["xCls"].ToString());
						val.Parameters.AddWithValue("@xLsn", (object)dataTable.Rows[num2]["xLsn"].ToString());
						val.Parameters.AddWithValue("@xTch", (object)dataTable.Rows[num2]["xTch"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = num3 <= 0;
						num = 37;
					}
					else
					{
						num = 238;
					}
					continue;
				case 57:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 271;
					continue;
				case 271:
					if (!flag)
					{
						num = 250;
						continue;
					}
					goto case 13;
				case 173:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 83;
					continue;
				case 83:
					if (!flag)
					{
						num = 251;
						continue;
					}
					goto case 158;
				case 102:
					if (flag)
					{
						val.Parameters.AddWithValue("@CountAb", (object)dataTable.Rows[num2]["CountAb"].ToString());
						num = 146;
					}
					else
					{
						num = 86;
					}
					continue;
				case 284:
					((Control)r).Text = "معلم";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM  tTeacher where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 141;
					continue;
				case 141:
					if (!flag)
					{
						num = 35;
						continue;
					}
					goto case 136;
				case 273:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 207;
					continue;
				case 207:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 282;
				case 94:
					((DbConnection)(object)ad).Open();
					num = 181;
					continue;
				case 205:
					text += ",";
					num = 139;
					continue;
				case 262:
					num2++;
					num = 267;
					continue;
				case 258:
					((DbConnection)(object)ad).Open();
					num = 132;
					continue;
				case 152:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 107;
						continue;
					}
					goto case 104;
				case 71:
				case 269:
					flag = num2 < dataTable.Rows.Count;
					num = 219;
					continue;
				case 219:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 96;
					}
					else
					{
						num = 284;
					}
					continue;
				case 8:
				case 72:
					flag = !(dataTable.Rows[num2]["M8"].ToString() == "");
					num = 135;
					continue;
				case 135:
					if (flag)
					{
						val.Parameters.AddWithValue("@M8", (object)dataTable.Rows[num2]["M8"].ToString());
						num = 120;
					}
					else
					{
						num = 224;
					}
					continue;
				case 171:
				case 267:
					flag = num2 < dataTable.Rows.Count;
					num = 195;
					continue;
				case 195:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 97;
					}
					else
					{
						num = 125;
					}
					continue;
				case 0:
					((DbConnection)(object)ac).Open();
					num = 89;
					continue;
				case 1:
				case 4:
					flag = num2 < dataTable.Rows.Count;
					num = 56;
					continue;
				case 56:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 118;
					}
					else
					{
						num = 74;
					}
					continue;
				case 47:
					A_1.Cancel = true;
					num = 253;
					continue;
				case 253:
					return;
				case 220:
				{
					SqlCommand val2 = new SqlCommand("update tExam set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 95;
					continue;
				}
				case 128:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tTosif");
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 198;
					continue;
				case 198:
					if (!flag)
					{
						num = 100;
						continue;
					}
					goto case 25;
				case 274:
					text3 = "";
					flag = !(text != "");
					num = 161;
					continue;
				case 161:
					if (!flag)
					{
						num = 255;
						continue;
					}
					goto case 68;
				case 237:
				{
					SqlCommand val2 = new SqlCommand("update tExportRpt set std=1 where id=" + text2, ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					val = new SqlCommand("update ExportRpt set std=1 where id=" + text2 + " and xschool=" + asdab.n, ad);
					((DbCommand)(object)val).ExecuteNonQuery();
					d();
					flag = !(text != "");
					num = 180;
					continue;
				}
				case 180:
					if (!flag)
					{
						num = 279;
						continue;
					}
					goto case 80;
				case 20:
					if (flag)
					{
						val = new SqlCommand("sp_vAvgDoreh_Class" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
						val.Parameters.AddWithValue("@xClass", (object)dataTable.Rows[num2]["xClass"].ToString());
						val.Parameters.AddWithValue("@countStd", (object)dataTable.Rows[num2]["countStd"].ToString());
						val.Parameters.AddWithValue("@avgMark", (object)dataTable.Rows[num2]["avgMark"].ToString());
						val.Parameters.AddWithValue("@maxMark", (object)dataTable.Rows[num2]["maxMark"].ToString());
						val.Parameters.AddWithValue("@MinMark", (object)dataTable.Rows[num2]["MinMark"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						num2++;
						num = 277;
					}
					else
					{
						num = 16;
					}
					continue;
				case 186:
				{
					SqlCommand val2 = new SqlCommand("update tTch_Cls set xExportRpt=" + text2 + " where  (xCls = @xCls) AND (xLsn = @xLsn)", ac);
					val2.Parameters.AddWithValue("@xCls", (object)dataTable.Rows[num2]["xCls"].ToString());
					val2.Parameters.AddWithValue("@xLsn", (object)dataTable.Rows[num2]["xLsn"].ToString());
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 199;
					continue;
				}
				case 189:
				{
					SqlCommand val2 = new SqlCommand("update tMarkDoreh set xExportRpt=" + text2 + " where  xStudent=@xStudent and Xtest=@Xtest and typ=@typ", ac);
					val2.Parameters.AddWithValue("@xStudent", (object)dataTable.Rows[num2]["xStudent"].ToString());
					val2.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
					val2.Parameters.AddWithValue("@typ", (object)dataTable.Rows[num2]["typ"].ToString());
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 262;
					continue;
				}
				case 147:
					MessageBox.Show("صنفی انتخاب نشده است");
					((Control)z).Focus();
					num = 270;
					continue;
				case 270:
					return;
				case 276:
					((DbConnection)(object)ad).Open();
					num = 7;
					continue;
				case 86:
					val.Parameters.AddWithValue("@countAb", (object)DBNull.Value);
					num = 169;
					continue;
				case 43:
				{
					SqlCommand val2 = new SqlCommand("update tBook set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					((DbCommand)(object)val2).ExecuteNonQuery();
					p.PerformStep();
					num = 256;
					continue;
				}
				case 221:
					((Control)r).Text = "صنف ها";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tClass where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 168;
					continue;
				case 168:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 173;
				case 236:
					((DbConnection)(object)ad).Open();
					num = 191;
					continue;
				case 191:
					num2 = 0;
					num = 171;
					continue;
				case 121:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 122;
					continue;
				case 122:
					if (!flag)
					{
						num = 85;
						continue;
					}
					goto case 174;
				case 188:
					A_1.Cancel = true;
					num = 202;
					continue;
				case 202:
					return;
				case 95:
					num2++;
					num = 129;
					continue;
				case 255:
					text3 = "  xClass in(" + text + ") and ";
					num = 68;
					continue;
				case 244:
				case 293:
					flag = !(dataTable.Rows[num2]["M2"].ToString() == "");
					num = 215;
					continue;
				case 215:
					if (flag)
					{
						val.Parameters.AddWithValue("@M2", (object)dataTable.Rows[num2]["M2"].ToString());
						num = 133;
					}
					else
					{
						num = 259;
					}
					continue;
				case 240:
				case 257:
					flag = num2 < dataTable.Rows.Count;
					num = 149;
					continue;
				case 149:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 103;
					}
					else
					{
						num = 274;
					}
					continue;
				case 165:
					flag = !(text == "");
					num = 201;
					continue;
				case 201:
					num = ((!flag) ? 147 : 208);
					continue;
				case 21:
					if (flag)
					{
						val = new SqlCommand("sp_vAvgDoreh" + asdab.n + "_InsertUpdate", ad);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.AddWithValue("@Xtest", (object)dataTable.Rows[num2]["Xtest"].ToString());
						val.Parameters.AddWithValue("@xPaye", (object)dataTable.Rows[num2]["xPaye"].ToString());
						val.Parameters.AddWithValue("@countStd", (object)dataTable.Rows[num2]["countStd"].ToString());
						val.Parameters.AddWithValue("@avgMark", (object)dataTable.Rows[num2]["avgMark"].ToString());
						val.Parameters.AddWithValue("@maxMark", (object)dataTable.Rows[num2]["maxMark"].ToString());
						val.Parameters.AddWithValue("@MinMark", (object)dataTable.Rows[num2]["MinMark"].ToString());
						val.Parameters.AddWithValue("@xExportRpt", (object)text2);
						int num3 = ((DbCommand)(object)val).ExecuteNonQuery();
						num2++;
						num = 98;
					}
					else
					{
						num = 47;
					}
					continue;
				case 252:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     dbo.tMarkDoreh.Xtest, dbo.tStudent.xPaye, COUNT(dbo.tMarkDoreh.xStudent) AS countStd, AVG(dbo.tMarkDoreh.MarkDoreh) AS avgMark, \r\n                      MAX(dbo.tMarkDoreh.MarkDoreh) AS maxMark, MIN(dbo.tMarkDoreh.MarkDoreh) AS MinMark\r\n                        FROM         dbo.tMarkDoreh INNER JOIN\r\n                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id\r\n                        WHERE     (dbo.tMarkDoreh.typ = 5) AND    (Xtest = " + n.SelectedValue.ToString() + ") GROUP BY dbo.tMarkDoreh.Xtest, dbo.tStudent.xPaye");
					flag = ((DbConnection)(object)ac).State == ConnectionState.Open;
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 166;
						continue;
					}
					goto case 101;
				case 287:
					flag = ((DbConnection)(object)ad).State == ConnectionState.Open;
					num = 130;
					continue;
				case 130:
					if (!flag)
					{
						num = 258;
						continue;
					}
					goto case 132;
				case 115:
					num2++;
					num = 239;
					continue;
				case 230:
					if (!flag)
					{
						num = 154;
						continue;
					}
					goto case 115;
				case 288:
					val.Parameters.AddWithValue("@M9", (object)DBNull.Value);
					num = 254;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ProgressChangedEventArgs A_1)
	{
		if (true)
		{
		}
		((Control)q).Text = A_1.ProgressPercentage + "%";
	}

	private void a(object A_0, RunWorkerCompletedEventArgs A_1)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !A_1.Cancelled;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = A_1.Error == null;
					num = 4;
					continue;
				case 1:
					if (true)
					{
					}
					((Control)q).Text = "Canceled!";
					num = 2;
					continue;
				case 3:
				{
					((Control)q).Text = "Error: " + A_1.Error.Message;
					((Control)t).Visible = true;
					string text = "خطایی در ارسال رخ داده است";
					text += "\n";
					text += "ممکن است ارتباط کامپیوتر با اینترت قطع شده باشد";
					text += "\n";
					text += "ابتدا از اتصال به اینترنت مطمئن شده سپس دکمه ادامه ارسال را کلیک کنید";
					MessageBox.Show(text);
					num = 0;
					continue;
				}
				case 0:
					return;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					((Control)q).Text = "پایان ارسال";
					num = 6;
					continue;
				case 2:
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ah = "2";
		y.Checked = false;
		((Control)y).Visible = false;
		n.SelectedValue = s.GetRow(0).Cells["xExam"].Value.ToString();
		((Control)n).Enabled = false;
		((Control)this.m_f).Visible = true;
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = !o.IsBusy;
			int num = 0;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 6:
					o.WorkerSupportsCancellation = true;
					o.CancelAsync();
					num = 3;
					continue;
				case 4:
					flag = 6 != (int)MessageBox.Show("سیستم در حال ارسال نمرات میباشد.آیا مایل به خروج و قطع ارسال نمرات هستید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)16);
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						((CancelEventArgs)(object)A_1).Cancel = true;
						num = 2;
					}
					else
					{
						num = 6;
					}
					continue;
				case 2:
				case 3:
					num = 5;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = !y.Checked;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					((Control)ab).Enabled = true;
					num = 2;
					continue;
				case 0:
					ab.SelectedIndex = 0;
					((Control)ab).Enabled = false;
					num = 3;
					continue;
				case 3:
					return;
				case 4:
					flag = 6 == (int)MessageBox.Show("از این گزینه تنها در ابتدای سال تحصیلی و موارد خاص استفاده میشود.آیا مطمئن هستید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)16, (MessageBoxDefaultButton)256);
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 1:
					if (true)
					{
					}
					y.Checked = false;
					num = 0;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ab.SelectedValue.ToString() == "1");
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
						num = 1;
						continue;
					}
					((Control)z).Visible = false;
					((Control)this.m_f).Height = 176;
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					((Control)z).Visible = true;
					((Control)this.m_f).Height = 460;
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}
}
