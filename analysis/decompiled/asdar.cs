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
using school_Af.Rpt.afPayment;

public class asdar : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private UIComboBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private UIButton m_i;

	private OpenFileDialog m_j;

	private Panel k;

	private GridEX l;

	private Label m;

	private Panel n;

	private Label o;

	private UIButton p;

	private UIButton q;

	private ProgressBar r;

	private UIButton s;

	private SaveFileDialog t;

	private UIButton u;

	private UIComboBox v;

	private Panel w;

	private Label x;

	private string y = "";

	private string z = "";

	private string aa = "";

	private string ab = "";

	public string ac = "";

	private bool ad = false;

	private bool ae = false;

	private bool af = false;

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
						num = 6;
					}
					else
					{
						num = 4;
					}
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 5;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 5:
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

	private void d()
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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected Obj, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected Obj, but got Unknown
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected Obj, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected Obj, but got Unknown
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected Obj, but got Unknown
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Expected Obj, but got Unknown
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa5: Expected Obj, but got Unknown
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc3: Expected Obj, but got Unknown
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Expected Obj, but got Unknown
		//IL_112e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdar));
		GridEXLayout val = new GridEXLayout();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		StringFormat val8 = new StringFormat();
		StringFormat val9 = new StringFormat();
		StringFormat val10 = new StringFormat();
		this.m_b = new Panel();
		w = new Panel();
		x = new Label();
		u = new UIButton();
		r = new ProgressBar();
		s = new UIButton();
		q = new UIButton();
		n = new Panel();
		o = new Label();
		this.m_c = new UIButton();
		l = new GridEX();
		p = new UIButton();
		this.m_i = new UIButton();
		this.m_d = new UIGroupBox();
		v = new UIComboBox();
		m = new Label();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		this.m_e = new Label();
		this.m_f = new UIComboBox();
		this.m_j = new OpenFileDialog();
		k = new Panel();
		t = new SaveFileDialog();
		((Control)this.m_b).SuspendLayout();
		((Control)w).SuspendLayout();
		((Control)n).SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)w);
		((Control)this.m_b).Controls.Add((Control)(object)u);
		((Control)this.m_b).Controls.Add((Control)(object)r);
		((Control)this.m_b).Controls.Add((Control)(object)s);
		((Control)this.m_b).Controls.Add((Control)(object)q);
		((Control)this.m_b).Controls.Add((Control)(object)n);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)l);
		((Control)this.m_b).Controls.Add((Control)(object)p);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(5, 5);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(900, 674);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_b).Paint += a;
		((Control)w).Controls.Add((Control)(object)x);
		((Control)w).Location = new Point(297, 286);
		((Control)w).Name = "plode";
		((Control)w).Size = new Size(305, 100);
		((Control)w).TabIndex = 139;
		((Control)x).Anchor = (AnchorStyles)9;
		((Control)x).AutoSize = true;
		((Control)x).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((Control)x).Location = new Point(62, 45);
		((Control)x).Name = "label8";
		((Control)x).Size = new Size(189, 13);
		((Control)x).TabIndex = 30;
		((Control)x).Text = "در حال بارگزاری لطفا کمی صبر کنید";
		((Control)u).Anchor = (AnchorStyles)6;
		u.Image = (Image)componentResourceManager.GetObject("btnview.Image");
		u.ImageSize = new Size(40, 40);
		((Control)u).Location = new Point(196, 621);
		((Control)u).Name = "btnview";
		((Control)u).Size = new Size(149, 46);
		((Control)u).TabIndex = 138;
		((Control)u).Text = "نمایش گزارش";
		((Control)u).Click += b;
		((Control)r).Location = new Point(372, 595);
		((Control)r).Name = "pr12";
		((Control)r).Size = new Size(167, 20);
		((Control)r).TabIndex = 137;
		((Control)r).Visible = false;
		((Control)s).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		s.Image = (Image)componentResourceManager.GetObject("btnXls.Image");
		s.ImageSize = new Size(30, 30);
		((Control)s).Location = new Point(372, 621);
		((Control)s).Name = "btnXls";
		((Control)s).Size = new Size(167, 45);
		((Control)s).TabIndex = 136;
		((Control)s).Text = "دریافت فایل اکسل";
		((Control)s).Click += c;
		q.Image = (Image)componentResourceManager.GetObject("btnSelectDate.Image");
		((Control)q).Location = new Point(13, 65);
		((Control)q).Name = "btnSelectDate";
		((Control)q).Size = new Size(108, 31);
		((Control)q).TabIndex = 135;
		((Control)q).Text = "انتخاب تاریخ";
		((Control)q).Click += d;
		((Control)n).BackColor = SystemColors.HotTrack;
		n.BorderStyle = (BorderStyle)1;
		((Control)n).Controls.Add((Control)(object)o);
		((Control)n).Location = new Point(127, 62);
		((Control)n).Name = "panelStd";
		((Control)n).Size = new Size(756, 37);
		((Control)n).TabIndex = 134;
		((Control)o).Anchor = (AnchorStyles)15;
		((Control)o).BackColor = Color.FromArgb(0, 192, 192);
		o.BorderStyle = (BorderStyle)1;
		((Control)o).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(2, 2);
		((Control)o).Name = "lPayment";
		((Control)o).RightToLeft = (RightToLeft)1;
		((Control)o).Size = new Size(749, 31);
		((Control)o).TabIndex = 77;
		o.TextAlign = (ContentAlignment)32;
		((Control)this.m_c).Anchor = (AnchorStyles)10;
		((Control)this.m_c).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(20, 20);
		((Control)this.m_c).Location = new Point(13, 621);
		((Control)this.m_c).Name = "btnClose";
		((Control)this.m_c).Size = new Size(149, 46);
		((Control)this.m_c).TabIndex = 3;
		((Control)this.m_c).Text = "بستن";
		((Control)this.m_c).Click += g;
		l.AllowEdit = (InheritableBoolean)2;
		((Control)l).Anchor = (AnchorStyles)15;
		l.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		l.DesignTimeLayout = val;
		l.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)l).Font = new Font("Tahoma", 8.25f);
		((Control)l).Location = new Point(13, 105);
		((Control)l).Name = "gridEX2";
		((ScrollableBase)l).RecordNavigator = true;
		l.RowHeaders = (InheritableBoolean)1;
		((Control)l).Size = new Size(874, 494);
		((Control)l).TabIndex = 18;
		l.TotalRow = (InheritableBoolean)1;
		((ScrollableBase)l).VisualStyle = (VisualStyle)2;
		((Control)p).Anchor = (AnchorStyles)10;
		((Control)p).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		p.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)p).Location = new Point(734, 621);
		((Control)p).Name = "btnNew";
		((Control)p).Size = new Size(149, 46);
		((Control)p).TabIndex = 0;
		((Control)p).Text = "ثبت مورد جدید";
		((Control)p).Click += i;
		((Control)this.m_i).Anchor = (AnchorStyles)10;
		((Control)this.m_i).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)this.m_i).Location = new Point(579, 621);
		((Control)this.m_i).Name = "btnEdit";
		((Control)this.m_i).Size = new Size(149, 46);
		((Control)this.m_i).TabIndex = 1;
		((Control)this.m_i).Text = "اصلاح مورد انتخابی";
		((Control)this.m_i).Click += h;
		((Control)this.m_d).Anchor = (AnchorStyles)13;
		((Control)this.m_d).Controls.Add((Control)(object)v);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Location = new Point(13, 0);
		((Control)this.m_d).Name = "uiGroupBox1";
		((Control)this.m_d).Size = new Size(874, 58);
		((Control)this.m_d).TabIndex = 0;
		((Control)this.m_d).Text = "جستجو";
		((UIComboBase)v).ComboStyle = (ComboStyle)1;
		((UIComboBase)v).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)v).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "1403";
		val2.Value = "1403";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "1402";
		val3.Value = "1402";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1401";
		val4.Value = "1401";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1400";
		val5.Value = "1400";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1399";
		val6.Value = "1399";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1398";
		val7.Value = "1398";
		v.Items.AddRange(new UIComboBoxItem[6] { val2, val3, val4, val5, val6, val7 });
		((Control)v).Location = new Point(688, 22);
		((Control)v).Name = "dropYear";
		((Control)v).Size = new Size(97, 23);
		val8.Alignment = (StringAlignment)0;
		val8.FormatFlags = (StringFormatFlags)20485;
		val8.HotkeyPrefix = (HotkeyPrefix)0;
		val8.LineAlignment = (StringAlignment)1;
		val8.Trimming = (StringTrimming)1;
		((UIComboBase)v).StringFormat = val8;
		((Control)v).TabIndex = 136;
		v.SelectedIndexChanged += a;
		((Control)m).AutoSize = true;
		((Control)m).Location = new Point(792, 24);
		((Control)m).Name = "label10";
		((Control)m).Size = new Size(66, 13);
		((Control)m).TabIndex = 135;
		((Control)m).Text = "سال تعلیمی";
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Location = new Point(233, 24);
		((Control)this.m_g).Name = "label19";
		((Control)this.m_g).Size = new Size(30, 13);
		((Control)this.m_g).TabIndex = 25;
		((Control)this.m_g).Text = "صنف";
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("Tahoma", 8.25f);
		((Control)this.m_h).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_h).Location = new Point(26, 20);
		((Control)this.m_h).Name = "dropCls";
		((Control)this.m_h).Size = new Size(201, 23);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val9;
		((Control)this.m_h).TabIndex = 1;
		this.m_h.SelectedIndexChanged += e;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(585, 26);
		((Control)this.m_e).Name = "label20";
		((Control)this.m_e).Size = new Size(22, 13);
		((Control)this.m_e).TabIndex = 15;
		((Control)this.m_e).Text = "پایه";
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_f).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_f).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_f).Location = new Point(378, 20);
		((Control)this.m_f).Name = "dropPaye";
		((Control)this.m_f).Size = new Size(201, 23);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_f).StringFormat = val10;
		((Control)this.m_f).TabIndex = 0;
		this.m_f.SelectedIndexChanged += f;
		((FileDialog)this.m_j).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_j).Title = "انتخاب عکس شاگرد";
		((Control)k).BackColor = Color.Black;
		((Control)k).Controls.Add((Control)(object)this.m_b);
		((Control)k).Dock = (DockStyle)5;
		((Control)k).Location = new Point(0, 0);
		((Control)k).Name = "panel2";
		((Control)k).Size = new Size(910, 685);
		((Control)k).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(910, 685);
		((Control)this).Controls.Add((Control)(object)k);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmPaymentList";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += j;
		((Control)this.m_b).ResumeLayout(false);
		((Control)w).ResumeLayout(false);
		((Control)w).PerformLayout();
		((Control)n).ResumeLayout(false);
		((ISupportInitialize)l).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)k).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdar()
	{
		d();
	}

	private void j(object A_0, EventArgs A_1)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("9");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 0:
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
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto IL_012c;
				case 5:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_012c;
				case 4:
					{
						num = 0;
						continue;
					}
					IL_012c:
					v.SelectedValue = asdaj.a;
					ae = true;
					d(this, null);
					ad = true;
					num = 5;
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
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + v.SelectedValue.ToString() + ") order by id");
			((CollectionBase)(object)this.m_f.Items).Clear();
			this.m_f.Items.Add("کل", (object)"0");
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 1:
					flag = num < dataTable.Rows.Count;
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					this.m_f.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 2:
					this.m_f.SelectedIndex = 0;
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
			ad = false;
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_f.SelectedIndex <= 0;
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
					if (true)
					{
					}
					text = text + " and xPaye=" + this.m_f.SelectedValue.ToString();
					num = 0;
					continue;
				case 0:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + v.SelectedValue.ToString() + text);
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					ad = true;
					this.m_h.SelectedIndex = 0;
					return;
				}
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 19;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 19:
					num = ((!ad) ? 10 : 5);
					continue;
				case 20:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 23;
				case 1:
				case 29:
					num = 4;
					continue;
				case 17:
					text += " and ";
					num = 14;
					continue;
				case 16:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 14;
				case 14:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 23;
					continue;
				case 9:
					flag = !(y != "");
					num = 28;
					continue;
				case 28:
					if (true)
					{
					}
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 4;
				case 5:
					num = 3;
					continue;
				case 3:
					num2 = (ae ? 1 : 0);
					goto IL_0325;
				case 18:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 9;
					continue;
				case 15:
					flag = !(text != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 18;
				case 7:
					text += " and ";
					num = 18;
					continue;
				case 6:
					text = " where " + text;
					num = 32;
					continue;
				case 0:
					if (flag)
					{
						l.DataSource = null;
						((Control)w).Visible = true;
						((Control)this).Refresh();
						text = " tYear_Student.xYear=" + v.SelectedValue.ToString() + " and   tPaymentStudent.xyear=" + v.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
						flag = this.m_h.SelectedIndex <= 0;
						num = 20;
					}
					else
					{
						num = 31;
					}
					continue;
				case 10:
					num2 = 0;
					goto IL_0325;
				case 32:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tPaymentStudent.*, ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) \r\n                      + ISNULL(tPaymentStudent.Celebration, 0) + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) \r\n                      + ISNULL(tPaymentStudent.ketab, 0) + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) \r\n                      AS SumPay, tStudent.Code AS Code, tStudent.FName AS FName, tStudent.LName AS LName, tStudent.PName AS PName, tClass.name AS Class, \r\n                      tPaye.Name AS Paye\r\n                      FROM   tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id" + text);
					l.DataSource = dataSource;
					((Control)w).Visible = false;
					num = 22;
					continue;
				}
				case 22:
					return;
				case 23:
					flag = this.m_f.SelectedIndex <= 0;
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 9;
				case 31:
					num = 11;
					continue;
				case 11:
					return;
				case 13:
				{
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + y + "' and tPaymentStudent.PaynemtDate<=N'" + z + "'";
					num = 1;
					continue;
				}
				case 8:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 12;
				case 30:
					text += " and ";
					num = 12;
					continue;
				case 4:
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 32;
				case 12:
					flag = !(z != "");
					num = 27;
					continue;
				case 27:
					{
						if (flag)
						{
							text = text + " tPaymentStudent.PaynemtDate=N'" + y + "'";
							num = 29;
						}
						else
						{
							num = 13;
						}
						continue;
					}
					IL_0325:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda5 asda10 = new asda5();
		((Form)asda10).ShowDialog();
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			string text = "";
			string text2 = "";
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					num2 = 1;
					goto IL_0202;
				case 3:
					num = 4;
					continue;
				case 4:
					num2 = ((!(text != "")) ? 1 : 0);
					goto IL_0202;
				case 1:
				{
					asdae asdae2 = new asdae();
					asdae2.aw = text2;
					asdae2.ax = v.SelectedValue.ToString();
					asdae2.ay = text;
					((Form)asdae2).ShowDialog();
					a();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 6:
					try
					{
						while (true)
						{
							IL_00f7:
							num = 6;
							while (true)
							{
								int num3;
								switch (num)
								{
								case 6:
									num = ((l.RowCount > 0) ? 1 : 3);
									continue;
								case 3:
									num3 = 1;
									goto IL_0155;
								case 1:
									num = 5;
									continue;
								case 5:
									num3 = (((int)l.SelectedItems[0].RowType != 0) ? 1 : 0);
									goto IL_0155;
								case 0:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 4;
								case 2:
									text2 = l.SelectedItems[0].GetRow().Cells["xStudent"].Value.ToString();
									text = l.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
									num = 4;
									continue;
								case 4:
									num = 7;
									continue;
								case 7:
									goto end_IL_00ce;
									IL_0155:
									flag = (byte)num3 != 0;
									num = 0;
									continue;
								}
								goto IL_00f7;
								continue;
								end_IL_00ce:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 5;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 5:
					{
						num = ((text2 != "") ? 3 : 2);
						continue;
					}
					IL_0202:
					flag = (byte)num2 != 0;
					num = 7;
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

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void f(object A_0, EventArgs A_1)
	{
		ad = false;
		b();
	}

	private void e(object A_0, EventArgs A_1)
	{
		a();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			asdbs asdbs2 = new asdbs();
			asdbs2.n = y;
			asdbs2.o = z;
			asdbs2.m = ac;
			((Form)asdbs2).ShowDialog();
			y = asdbs2.n;
			z = asdbs2.o;
			aa = asdbs2.p;
			ab = asdbs2.q;
			ac = asdbs2.m;
			bool flag = !(y != "");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 6;
						continue;
					}
					((Control)o).Text = "لیست کلیه پرداخت های ثبت شده";
					num = 4;
					continue;
				case 2:
				case 3:
					num = 1;
					continue;
				case 6:
					flag = !(z != "");
					num = 0;
					continue;
				case 0:
					if (true)
					{
					}
					if (flag)
					{
						((Control)o).Text = "لیست پرداخت های روز " + aa + " " + y;
						num = 2;
					}
					else
					{
						num = 5;
					}
					continue;
				case 5:
					((Control)o).Text = "لیست پرداخت ها از روز" + aa + " " + y + " تا روز " + ab + " " + z;
					num = 3;
					continue;
				case 1:
				case 4:
					ad = true;
					a();
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Invalid comparison between Unknown and I4
		asdbe asdbe2 = default;
		SaveFileDialog val = default;
		while (true)
		{
			string text = " tYear_Student.xYear=" + v.SelectedValue.ToString() + " and    tPaymentStudent.xyear=" + v.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = this.m_h.SelectedIndex <= 0;
			int num = 11;
			while (true)
			{
				string a_;
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 8;
				case 15:
					text += " and ";
					num = 17;
					continue;
				case 8:
					flag = this.m_f.SelectedIndex <= 0;
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 10;
				case 13:
					text = " where " + text;
					num = 27;
					continue;
				case 27:
					if (1 == 0)
					{
					}
					goto IL_023b;
				case 23:
					text += " and ";
					num = 18;
					continue;
				case 22:
				{
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + y + "' and tPaymentStudent.PaynemtDate<=N'" + z + "'";
					num = 14;
					continue;
				}
				case 9:
					if (!flag)
					{
						num = 12;
						continue;
					}
					return;
				case 2:
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 17;
				case 26:
					flag = !(text != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 5;
				case 0:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto IL_023b;
				case 12:
					asdbe2.b(((FileDialog)val).FileName);
					MessageBox.Show("پایان");
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 10;
					continue;
				case 24:
					flag = !(text != "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 18;
				case 18:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 8;
					continue;
				case 1:
					text += " and ";
					num = 5;
					continue;
				case 10:
					flag = !(y != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 4:
				case 14:
					num = 0;
					continue;
				case 17:
					flag = !(z != "");
					num = 19;
					continue;
				case 19:
					{
						if (flag)
						{
							text = text + " tPaymentStudent.PaynemtDate=N'" + y + "'";
							num = 4;
						}
						else
						{
							num = 22;
						}
						continue;
					}
					IL_023b:
					a_ = "SELECT     tStudent.Code AS [کد متعلم], tStudent.FName AS نام, tStudent.LName AS [ولد-بنت], tStudent.PName AS ولدیت, tPaye.Name AS پایه, tClass.name AS صنف, \r\n\r\n                      tPaymentStudent.PaynemtDate AS [تاریخ پرداخت], tPaymentStudent.dayOfWeek AS روز, tPaymentStudent.NamberBel AS [نمبر بل],                      ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS [جمع پرداخت],  tPaymentStudent.Fee AS فیس, \r\n                      tPaymentStudent.Transport AS ترانسپورت, tPaymentStudent.racing AS مسابقه, tPaymentStudent.Celebration AS جشن, tPaymentStudent.Exam AS امتحان, \r\n                      tPaymentStudent.uniform AS یونیفرم, tPaymentStudent.maghnae AS مقنعه, tPaymentStudent.ketab AS کتاب, tPaymentStudent.komakdarsi AS [کمک درسی], \r\n                      tPaymentStudent.dakhle AS داخله, tPaymentStudent.other AS سایر, tPaymentStudent.comment AS توضیحات\r\n                    FROM         tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id" + text;
					asdbe2 = new asdbe(a_, asdab.e());
					val = new SaveFileDialog();
					((FileDialog)val).Filter = "Excel Spreadsheets (*.xls)|*.xls";
					((FileDialog)val).DefaultExt = "xls";
					flag = (int)((CommonDialog)val).ShowDialog() != 1;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		SqlParameter[] a_3 = default;
		while (true)
		{
			string a_ = "";
			string a_2 = "";
			bool flag = !(y != "");
			int num = 13;
			while (true)
			{
				switch (num)
				{
				case 13:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 17;
				case 30:
					flag = !(z != "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 29;
						continue;
					}
					text = text + " tPaymentStudent.PaynemtDate=N'" + y + "'";
					num = 16;
					continue;
				case 5:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 21;
					continue;
				case 20:
					a_3 = new SqlParameter[3]
					{
						asdcb.a("@dateFrom", SqlDbType.NVarChar, a_),
						asdcb.a("@dateTo", SqlDbType.NVarChar, a_2),
						asdcb.a("@dayName", SqlDbType.NVarChar, aa)
					};
					text = " tYear_Student.xYear=" + v.SelectedValue.ToString() + " and  tPaymentStudent.xyear=" + v.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = this.m_h.SelectedIndex <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 18;
				case 9:
					a_2 = z.Substring(8, 2) + "/" + z.Substring(5, 2) + "/" + z.Substring(0, 4);
					num = 20;
					continue;
				case 3:
					text += " and ";
					num = 30;
					continue;
				case 26:
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 12;
				case 23:
					text += " and ";
					num = 5;
					continue;
				case 27:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 2;
				case 16:
				case 25:
					num = 26;
					continue;
				case 22:
					text = " where " + text;
					num = 12;
					continue;
				case 18:
					flag = this.m_f.SelectedIndex <= 0;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 21;
				case 10:
					a_ = y.Substring(8, 2) + "/" + y.Substring(5, 2) + "/" + y.Substring(0, 4);
					num = 17;
					continue;
				case 14:
					text += " and ";
					num = 2;
					continue;
				case 17:
					flag = !(z != "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 20;
				case 11:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 5;
				case 29:
				{
					if (true)
					{
					}
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + y + "' and tPaymentStudent.PaynemtDate<=N'" + z + "'";
					num = 25;
					continue;
				}
				case 19:
					flag = !(text != "");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 30;
				case 2:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 18;
					continue;
				case 21:
					flag = !(y != "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 26;
				case 12:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  @dateFrom as dateFrom,@dateTo as dateTo, @dayName as dayName ,   ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS SumPay,  ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS SumOther, tStudent.Code AS Code, \r\n                      tStudent.FName AS FName, tStudent.LName AS LName, tStudent.PName AS PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.xPaye, \r\n                      tYear_Student.xClass, tPaymentStudent.id, tPaymentStudent.xYear, tPaymentStudent.xStudent, tPaymentStudent.PaynemtDate, tPaymentStudent.dayOfWeek, \r\n                      tPaymentStudent.NamberBel, tPaymentStudent.Fee, tPaymentStudent.Transport, tPaymentStudent.racing, tPaymentStudent.Celebration, tPaymentStudent.Exam, \r\n                      tPaymentStudent.uniform, tPaymentStudent.maghnae, tPaymentStudent.ketab, tPaymentStudent.komakdarsi, tPaymentStudent.dakhle, tPaymentStudent.other, \r\n                      tPaymentStudent.comment , tParmetr.heder1, tParmetr.sch\r\n                        FROM         tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id   CROSS JOIN\r\n                      tParmetr" + text, a_3);
					ReportClass val = null;
					val = (ReportClass)(object)new CrRptListPayment();
					((ReportDocument)val).SetDataSource(dataSource);
					asda asda10 = new asda();
					asda10.a = val;
					((Form)asda10).ShowDialog();
					return;
				}
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		ad = false;
		c();
	}
}
