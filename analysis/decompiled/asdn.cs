using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdn : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private UIButton m_f;

	private UIButton m_g;

	private UIGroupBox m_h;

	private Label m_i;

	private UIComboBox m_j;

	private Label m_k;

	private UIComboBox m_l;

	private Label m_m;

	private Label m_n;

	private EditBox m_o;

	private EditBox m_p;

	private UIButton m_q;

	private OpenFileDialog r;

	private Panel s;

	private GridEX t;

	private Label u;

	private UIGroupBox v;

	private Panel w;

	private Panel x;

	private TextBox y;

	private Label z;

	private UIButton aa;

	private UIButton ab;

	private Label ac;

	private Label ad;

	private UIComboBox ae;

	private UIComboBox af;

	private Label ag;

	private DatePicker ah;

	private Label ai;

	private UIComboBox aj;

	private UIComboBox ak;

	private Label al;

	private bool am = false;

	private int an = 0;

	private int ao = 0;

	private string ap = "0";

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (A_0)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 5;
					}
					continue;
				case 1:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 3:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void h()
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
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected Obj, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected Obj, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected Obj, but got Unknown
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected Obj, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Expected Obj, but got Unknown
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected Obj, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected Obj, but got Unknown
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Expected Obj, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected Obj, but got Unknown
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f39: Expected Obj, but got Unknown
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected Obj, but got Unknown
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0feb: Expected Obj, but got Unknown
		//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got Unknown
		//IL_119c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Expected Obj, but got Unknown
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected Obj, but got Unknown
		//IL_13cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d6: Expected Obj, but got Unknown
		//IL_158c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1596: Expected Obj, but got Unknown
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Expected Obj, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Expected Obj, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d6: Expected Obj, but got Unknown
		//IL_16ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Expected Obj, but got Unknown
		//IL_1782: Unknown result type (might be due to invalid IL or missing references)
		//IL_178c: Expected Obj, but got Unknown
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1859: Expected Obj, but got Unknown
		//IL_186d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1877: Expected Obj, but got Unknown
		//IL_19c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Expected Obj, but got Unknown
		//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ef: Expected Obj, but got Unknown
		//IL_1b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b19: Expected Obj, but got Unknown
		//IL_1b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9d: Expected Obj, but got Unknown
		//IL_1baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb9: Expected Obj, but got Unknown
		//IL_1c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5d: Expected Obj, but got Unknown
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c79: Expected Obj, but got Unknown
		//IL_1d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d35: Expected Obj, but got Unknown
		//IL_1d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d51: Expected Obj, but got Unknown
		//IL_1deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Expected Obj, but got Unknown
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Expected Obj, but got Unknown
		//IL_1f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f57: Expected Obj, but got Unknown
		//IL_1f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f79: Expected Obj, but got Unknown
		//IL_2117: Unknown result type (might be due to invalid IL or missing references)
		//IL_2121: Expected Obj, but got Unknown
		//IL_2220: Unknown result type (might be due to invalid IL or missing references)
		//IL_222a: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdn));
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		StringFormat val4 = new StringFormat();
		StringFormat val5 = new StringFormat();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		StringFormat val9 = new StringFormat();
		GridEXLayout val10 = new GridEXLayout();
		StringFormat val11 = new StringFormat();
		StringFormat val12 = new StringFormat();
		UIComboBoxItem val13 = new UIComboBoxItem();
		UIComboBoxItem val14 = new UIComboBoxItem();
		UIComboBoxItem val15 = new UIComboBoxItem();
		UIComboBoxItem val16 = new UIComboBoxItem();
		StringFormat val17 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		w = new Panel();
		x = new Panel();
		ai = new Label();
		aj = new UIComboBox();
		ag = new Label();
		ah = new DatePicker();
		ad = new Label();
		ae = new UIComboBox();
		af = new UIComboBox();
		ac = new Label();
		y = new TextBox();
		z = new Label();
		aa = new UIButton();
		ab = new UIButton();
		v = new UIGroupBox();
		t = new GridEX();
		u = new Label();
		this.m_h = new UIGroupBox();
		this.m_m = new Label();
		this.m_n = new Label();
		this.m_o = new EditBox();
		this.m_p = new EditBox();
		this.m_k = new Label();
		this.m_l = new UIComboBox();
		this.m_i = new Label();
		this.m_j = new UIComboBox();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_g = new UIButton();
		this.m_f = new UIButton();
		this.m_q = new UIButton();
		r = new OpenFileDialog();
		s = new Panel();
		ak = new UIComboBox();
		al = new Label();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)w).SuspendLayout();
		((Control)x).SuspendLayout();
		((ISupportInitialize)v).BeginInit();
		((Control)v).SuspendLayout();
		((ISupportInitialize)t).BeginInit();
		((ISupportInitialize)this.m_h).BeginInit();
		((Control)this.m_h).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)s).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(10, 100);
		((Control)this.m_b).Name = "gridEX1";
		((ScrollableBase)this.m_b).RecordNavigator = true;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(747, 131);
		((Control)this.m_b).TabIndex = 4;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		this.m_b.SelectionChanged += j;
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)w);
		((Control)this.m_c).Controls.Add((Control)(object)v);
		((Control)this.m_c).Controls.Add((Control)(object)u);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_c).Location = new Point(5, 5);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(790, 589);
		((Control)this.m_c).TabIndex = 0;
		((Control)this.m_c).Paint += a;
		((Control)w).BackColor = Color.Gray;
		w.BorderStyle = (BorderStyle)1;
		((Control)w).Controls.Add((Control)(object)x);
		((Control)w).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(58, 269);
		((Control)w).Name = "pStd";
		((Control)w).Size = new Size(514, 298);
		((Control)w).TabIndex = 79;
		((Control)w).Visible = false;
		((Control)x).BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = (BorderStyle)2;
		((Control)x).Controls.Add((Control)(object)ai);
		((Control)x).Controls.Add((Control)(object)aj);
		((Control)x).Controls.Add((Control)(object)ag);
		((Control)x).Controls.Add((Control)(object)ah);
		((Control)x).Controls.Add((Control)(object)ad);
		((Control)x).Controls.Add((Control)(object)ae);
		((Control)x).Controls.Add((Control)(object)af);
		((Control)x).Controls.Add((Control)(object)ac);
		((Control)x).Controls.Add((Control)(object)y);
		((Control)x).Controls.Add((Control)(object)z);
		((Control)x).Controls.Add((Control)(object)aa);
		((Control)x).Controls.Add((Control)(object)ab);
		((Control)x).Font = new Font("Tahoma", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(6, 7);
		((Control)x).Name = "panel3";
		((Control)x).Size = new Size(498, 281);
		((Control)x).TabIndex = 40;
		((Control)ai).AutoSize = true;
		((Control)ai).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ai).Location = new Point(428, 74);
		((Control)ai).Name = "lbook";
		((Control)ai).Size = new Size(36, 13);
		((Control)ai).TabIndex = 50;
		((Control)ai).Text = "درس :";
		((Control)aj).Anchor = (AnchorStyles)9;
		((UIComboBase)aj).ComboStyle = (ComboStyle)1;
		((UIComboBase)aj).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)aj).Font = new Font("Tahoma", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "انضباطی";
		val2.Value = "1";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "تشویقی";
		val3.Value = "2";
		aj.Items.AddRange(new UIComboBoxItem[2] { val2, val3 });
		((Control)aj).Location = new Point(149, 68);
		((Control)aj).Name = "dropBook";
		((Control)aj).Size = new Size(272, 24);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)aj).StringFormat = val4;
		((Control)aj).TabIndex = 2;
		((Control)ag).AutoSize = true;
		((Control)ag).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ag).Location = new Point(428, 104);
		((Control)ag).Name = "label6";
		((Control)ag).Size = new Size(35, 13);
		((Control)ag).TabIndex = 48;
		((Control)ag).Text = "تاریخ :";
		ah.AutoToday = true;
		((Control)ah).BackColor = Color.SeaShell;
		ah.BijanForeColor = Color.Blue;
		((Control)ah).Location = new Point(276, 99);
		((Control)ah).Name = "txtDatafrom";
		((Control)ah).Size = new Size(144, 24);
		((Control)ah).TabIndex = 3;
		ah.the_date = new DateTime(2019, 1, 3, 14, 40, 32, 797);
		ah.the_label = "ازمون تاريخ:";
		((Control)ad).AutoSize = true;
		((Control)ad).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ad).Location = new Point(427, 43);
		((Control)ad).Name = "label3";
		((Control)ad).Size = new Size(40, 13);
		((Control)ad).TabIndex = 46;
		((Control)ad).Text = "عنوان :";
		((Control)ae).Anchor = (AnchorStyles)9;
		((UIComboBase)ae).ComboStyle = (ComboStyle)1;
		((UIComboBase)ae).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ae).Font = new Font("Tahoma", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)ae).Location = new Point(16, 38);
		((Control)ae).Name = "dropDisciplinaryCases";
		((Control)ae).Size = new Size(405, 24);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)ae).StringFormat = val5;
		((Control)ae).TabIndex = 1;
		((UIComboBase)af).ComboStyle = (ComboStyle)1;
		((UIComboBase)af).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)af).Font = new Font("Tahoma", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val6.FormatStyle.Alpha = 0;
		val6.Text = "انضباطی";
		val6.Value = "1";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "اخطار آموزشی";
		val7.Value = "3";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "تشویقی";
		val8.Value = "2";
		af.Items.AddRange(new UIComboBoxItem[3] { val6, val7, val8 });
		((Control)af).Location = new Point(237, 6);
		((Control)af).Name = "dropType";
		((Control)af).Size = new Size(184, 24);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)af).StringFormat = val9;
		((Control)af).TabIndex = 0;
		af.SelectedIndexChanged += i;
		((Control)ac).AutoSize = true;
		((Control)ac).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ac).Location = new Point(427, 11);
		((Control)ac).Name = "label1";
		((Control)ac).Size = new Size(34, 13);
		((Control)ac).TabIndex = 43;
		((Control)ac).Text = "مورد :";
		((Control)y).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(16, 134);
		((TextBoxBase)y).Multiline = true;
		((Control)y).Name = "txtComment";
		((Control)y).Size = new Size(405, 82);
		((Control)y).TabIndex = 4;
		((Control)z).AutoSize = true;
		((Control)z).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)z).Location = new Point(427, 138);
		((Control)z).Name = "label2";
		((Control)z).Size = new Size(54, 13);
		((Control)z).TabIndex = 42;
		((Control)z).Text = "توضیحات :";
		((Control)aa).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		aa.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)aa).Location = new Point(16, 233);
		((Control)aa).Name = "btnCancel";
		((Control)aa).Size = new Size(75, 38);
		((Control)aa).TabIndex = 6;
		((Control)aa).Text = "انصراف";
		((Control)aa).Click += g;
		((Control)ab).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		ab.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)ab).Location = new Point(97, 233);
		((Control)ab).Name = "btnAcp";
		((Control)ab).Size = new Size(75, 38);
		((Control)ab).TabIndex = 5;
		((Control)ab).Text = "تایید";
		((Control)ab).Click += h;
		((Control)v).Anchor = (AnchorStyles)13;
		((Control)v).Controls.Add((Control)(object)ak);
		((Control)v).Controls.Add((Control)(object)al);
		((Control)v).Controls.Add((Control)(object)t);
		((Control)v).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(12, 236);
		((Control)v).Name = "uiGroupBox2";
		((Control)v).Size = new Size(581, 346);
		((Control)v).TabIndex = 2;
		((Control)v).Text = "موارد انضباطی ، تشویقی و اخطارهای آموزشی شاگرد";
		t.AllowEdit = (InheritableBoolean)2;
		((Control)t).Anchor = (AnchorStyles)15;
		val10.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		t.DesignTimeLayout = val10;
		t.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)t).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		t.GroupByBoxVisible = false;
		((Control)t).Location = new Point(11, 58);
		((Control)t).Name = "gridEX2";
		((ScrollableBase)t).RecordNavigator = true;
		t.RowHeaders = (InheritableBoolean)1;
		((Control)t).Size = new Size(562, 283);
		((Control)t).TabIndex = 18;
		((ScrollableBase)t).VisualStyle = (VisualStyle)2;
		t.SelectionChanged += f;
		u.BorderStyle = (BorderStyle)1;
		((Control)u).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(599, 244);
		((Control)u).Name = "lName";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(171, 113);
		((Control)u).TabIndex = 77;
		u.TextAlign = (ContentAlignment)32;
		((Control)this.m_h).Anchor = (AnchorStyles)13;
		((Control)this.m_h).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_p);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_h).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_h).Location = new Point(13, -1);
		((Control)this.m_h).Name = "uiGroupBox1";
		((Control)this.m_h).Size = new Size(764, 239);
		((Control)this.m_h).TabIndex = 0;
		((Control)this.m_h).Text = "جستجو";
		((Control)this.m_m).Anchor = (AnchorStyles)9;
		((Control)this.m_m).AutoSize = true;
		((Control)this.m_m).Location = new Point(665, 67);
		((Control)this.m_m).Name = "label5";
		((Control)this.m_m).Size = new Size(84, 24);
		((Control)this.m_m).TabIndex = 29;
		((Control)this.m_m).Text = "نام خانوادگی";
		((Control)this.m_n).Anchor = (AnchorStyles)9;
		((Control)this.m_n).AutoSize = true;
		((Control)this.m_n).Location = new Point(387, 67);
		((Control)this.m_n).Name = "label4";
		((Control)this.m_n).Size = new Size(26, 24);
		((Control)this.m_n).TabIndex = 28;
		((Control)this.m_n).Text = "نام";
		((Control)this.m_o).Anchor = (AnchorStyles)9;
		((EditBase)this.m_o).AutoScroll = false;
		((EditBase)this.m_o).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_o).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_o).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_o).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_o).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_o).Location = new Point(458, 67);
		((Control)this.m_o).Name = "txtLName";
		((Control)this.m_o).RightToLeft = (RightToLeft)1;
		((Control)this.m_o).Size = new Size(201, 27);
		((Control)this.m_o).TabIndex = 2;
		((EditBase)this.m_o).TextAlignment = (TextAlignment)1;
		((Control)this.m_o).Leave += e;
		((Control)this.m_o).KeyUp += b;
		((Control)this.m_o).Enter += d;
		((Control)this.m_p).Anchor = (AnchorStyles)9;
		((EditBase)this.m_p).AutoScroll = false;
		((EditBase)this.m_p).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_p).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_p).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_p).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_p).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_p).Location = new Point(175, 67);
		((Control)this.m_p).Name = "txtFName";
		((Control)this.m_p).RightToLeft = (RightToLeft)1;
		((Control)this.m_p).Size = new Size(201, 27);
		((Control)this.m_p).TabIndex = 3;
		((EditBase)this.m_p).TextAlignment = (TextAlignment)1;
		((Control)this.m_p).Leave += b;
		((Control)this.m_p).KeyUp += b;
		((Control)this.m_p).Enter += c;
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Location = new Point(382, 22);
		((Control)this.m_k).Name = "label19";
		((Control)this.m_k).Size = new Size(42, 24);
		((Control)this.m_k).TabIndex = 25;
		((Control)this.m_k).Text = "صنف";
		((Control)this.m_l).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_l).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_l).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_l).Location = new Point(175, 18);
		((Control)this.m_l).Name = "dropCls";
		((Control)this.m_l).Size = new Size(201, 31);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_l).StringFormat = val11;
		((Control)this.m_l).TabIndex = 1;
		this.m_l.SelectedIndexChanged += l;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(665, 24);
		((Control)this.m_i).Name = "label20";
		((Control)this.m_i).Size = new Size(33, 24);
		((Control)this.m_i).TabIndex = 15;
		((Control)this.m_i).Text = "پایه";
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_j).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_j).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_j).Location = new Point(458, 18);
		((Control)this.m_j).Name = "dropPaye";
		((Control)this.m_j).Size = new Size(201, 31);
		val12.Alignment = (StringAlignment)0;
		val12.FormatFlags = (StringFormatFlags)20485;
		val12.HotkeyPrefix = (HotkeyPrefix)0;
		val12.LineAlignment = (StringAlignment)1;
		val12.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_j).StringFormat = val12;
		((Control)this.m_j).TabIndex = 0;
		this.m_j.SelectedIndexChanged += m;
		((Control)this.m_d).Anchor = (AnchorStyles)10;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_d).Font = new Font("B Nazanin", 12f);
		((Control)this.m_d).Location = new Point(599, 360);
		((Control)this.m_d).Name = "p_new";
		((Control)this.m_d).Size = new Size(183, 224);
		((Control)this.m_d).TabIndex = 1;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_e).Location = new Point(15, 119);
		((Control)this.m_e).Name = "btnDelete";
		((Control)this.m_e).Size = new Size(149, 46);
		((Control)this.m_e).TabIndex = 2;
		((Control)this.m_e).Text = "حذف";
		((Control)this.m_e).Click += k;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_g.ImageSize = new Size(20, 20);
		((Control)this.m_g).Location = new Point(15, 171);
		((Control)this.m_g).Name = "btnClose";
		((Control)this.m_g).Size = new Size(149, 46);
		((Control)this.m_g).TabIndex = 3;
		((Control)this.m_g).Text = "بستن";
		((Control)this.m_g).Click += n;
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((Control)this.m_f).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_f).Location = new Point(15, 16);
		((Control)this.m_f).Name = "btnNew";
		((Control)this.m_f).Size = new Size(149, 45);
		((Control)this.m_f).TabIndex = 0;
		((Control)this.m_f).Text = "ثبت مورد جدید(F1)";
		((Control)this.m_f).Click += p;
		((Control)this.m_q).Anchor = (AnchorStyles)9;
		((Control)this.m_q).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_q.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)this.m_q).Location = new Point(15, 67);
		((Control)this.m_q).Name = "btnEdit";
		((Control)this.m_q).Size = new Size(149, 46);
		((Control)this.m_q).TabIndex = 1;
		((Control)this.m_q).Text = "اصلاح";
		((Control)this.m_q).Click += o;
		((FileDialog)r).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)r).Title = "انتخاب عکس شاگرد";
		((Control)s).BackColor = Color.Black;
		((Control)s).Controls.Add((Control)(object)this.m_c);
		((Control)s).Dock = (DockStyle)5;
		((Control)s).Location = new Point(0, 0);
		((Control)s).Name = "panel2";
		((Control)s).Size = new Size(800, 600);
		((Control)s).TabIndex = 1;
		((UIComboBase)ak).ComboStyle = (ComboStyle)1;
		((UIComboBase)ak).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ak).Font = new Font("Tahoma", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val13.FormatStyle.Alpha = 0;
		val13.Text = "همه موارد";
		val13.Value = "0";
		val14.FormatStyle.Alpha = 0;
		val14.Text = "انضباطی";
		val14.Value = "1";
		val15.FormatStyle.Alpha = 0;
		val15.Text = "اخطار آموزشی";
		val15.Value = "3";
		val16.FormatStyle.Alpha = 0;
		val16.Text = "تشویقی";
		val16.Value = "2";
		ak.Items.AddRange(new UIComboBoxItem[4] { val13, val14, val15, val16 });
		((Control)ak).Location = new Point(318, 28);
		((Control)ak).Name = "dropFilterType";
		((Control)ak).Size = new Size(184, 24);
		val17.Alignment = (StringAlignment)0;
		val17.FormatFlags = (StringFormatFlags)20485;
		val17.HotkeyPrefix = (HotkeyPrefix)0;
		val17.LineAlignment = (StringAlignment)1;
		val17.Trimming = (StringTrimming)1;
		((UIComboBase)ak).StringFormat = val17;
		((Control)ak).TabIndex = 44;
		ak.SelectedIndexChanged += a;
		((Control)al).AutoSize = true;
		((Control)al).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)al).Location = new Point(508, 33);
		((Control)al).Name = "label7";
		((Control)al).Size = new Size(67, 13);
		((Control)al).TabIndex = 45;
		((Control)al).Text = "مشاهده ی :";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 600);
		((Control)this).Controls.Add((Control)(object)s);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmDisciplinaryAdd";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست شاگردان";
		((Form)this).Load += q;
		((Control)this).KeyUp += a;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)w).ResumeLayout(false);
		((Control)x).ResumeLayout(false);
		((Control)x).PerformLayout();
		((ISupportInitialize)v).EndInit();
		((Control)v).ResumeLayout(false);
		((Control)v).PerformLayout();
		((ISupportInitialize)t).EndInit();
		((ISupportInitialize)this.m_h).EndInit();
		((Control)this.m_h).ResumeLayout(false);
		((Control)this.m_h).PerformLayout();
		((Control)this.m_d).ResumeLayout(false);
		((Control)s).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdn()
	{
		h();
	}

	private void q(object A_0, EventArgs A_1)
	{
		while (true)
		{
			f();
			g();
			d();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM  tCardProperties");
			bool flag = dataTable.Rows.Count <= 0;
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

	private void g()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			this.m_j.Items.Add("کل", (object)"0");
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 2;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					this.m_j.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 1:
					this.m_j.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void f()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name,xpaye from tClass");
			this.m_l.Items.Add("همه صنفها", (object)"0");
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					this.m_l.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 1;
					continue;
				case 2:
					if (true)
					{
					}
					this.m_l.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = af.SelectedIndex < 0;
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
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tDisciplinaryCases where typ=" + af.SelectedValue.ToString());
					ae.DataSource = dataSource;
					ae.DisplayMember = "Name";
					ae.ValueMember = "id";
					num = 1;
					continue;
				}
				case 1:
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
			ao = an;
			string text = "";
			bool flag = this.m_l.SelectedIndex <= 0;
			int num = 28;
			while (true)
			{
				switch (num)
				{
				case 28:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 27;
				case 7:
					flag = !(text != "");
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 5;
				case 4:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 3;
				case 19:
					flag = !(text != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 17;
				case 23:
					num = 2;
					continue;
				case 10:
					if (true)
					{
					}
					text = text + " tstudent.xClass=" + this.m_l.SelectedValue.ToString();
					num = 27;
					continue;
				case 3:
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)this.m_o).Text) + "%'";
					num = 7;
					continue;
				case 21:
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)this.m_p).Text) + "%'";
					num = 6;
					continue;
				case 9:
					text += " and ";
					num = 17;
					continue;
				case 2:
					try
					{
						this.m_b.Row = ao;
						((Control)this.m_b).Focus();
					}
					catch
					{
					}
					num = 25;
					continue;
				case 13:
					flag = !(text != "");
					num = 29;
					continue;
				case 29:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 21;
				case 16:
					flag = !(text != "");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 10;
				case 27:
					flag = this.m_j.SelectedIndex <= 0;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 24;
				case 17:
					text = text + " tstudent.xPaye=" + this.m_j.SelectedValue.ToString();
					num = 24;
					continue;
				case 24:
					flag = !(((Control)this.m_p).Text.Trim() != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 6;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code,  tStudent.Code, tStudent.xPaye, tStudent.xClass, tStudent.xReshteh, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Sh_Sh, \r\n                   tStudent.MobileMother,tStudent.MobileFather,   tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tPaye ON tStudent.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tStudent.xClass = tClass.id " + text + " order by tStudent.sort,tStudent.lname,tStudent.fname");
					this.m_b.DataSource = dataSource;
					flag = !am;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 25;
				case 1:
					text = " where " + text;
					num = 5;
					continue;
				case 15:
					text += " and ";
					num = 21;
					continue;
				case 6:
					flag = !(((Control)this.m_o).Text.Trim() != "");
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 7;
				case 26:
					text += " and ";
					num = 3;
					continue;
				case 18:
					text += " and ";
					num = 10;
					continue;
				case 25:
					am = false;
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between Unknown and I4
		string text = default;
		bool flag = default;
		while (true)
		{
			t.DataSource = null;
			((Control)u).Text = "";
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((this.m_b.RowCount <= 0) ? 6 : 10);
					continue;
				case 8:
					text += " and ";
					num = 1;
					continue;
				case 4:
					flag = !(text != "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 1;
				case 6:
					num2 = 1;
					goto IL_02c0;
				case 11:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT tDisciplinaryStudent.id,    tDisciplinaryCases.name AS DisciplinaryCases, tDisciplinaryStudent.xDisciplinaryCases, tDisciplinaryCases.typ\r\n                       ,case tDisciplinaryCases.typ  when 1 then N'انضباطی' when 2 then N'تشویقی' when 3 then N'اخطار آموزشی' end as typText, tDisciplinaryCases.mark, \r\n                      tDisciplinaryStudent.DateDis, tDisciplinaryStudent.comment,tbook.name as book,tDisciplinaryStudent.xbook\r\n                      FROM  tDisciplinaryStudent INNER JOIN\r\n                      tDisciplinaryCases ON tDisciplinaryStudent.xDisciplinaryCases = tDisciplinaryCases.id left outer join\r\n                      tbook on tDisciplinaryStudent.xbook=tbook.id\r\n                    WHERE     (tDisciplinaryStudent.xStudent = " + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")" + text);
					t.DataSource = dataSource;
					num = 7;
					continue;
				}
				case 7:
					return;
				case 10:
					num = 12;
					continue;
				case 12:
					if (true)
					{
					}
					num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_02c0;
				case 1:
					text = text + " and tDisciplinaryCases.typ=" + ak.SelectedValue.ToString();
					num = 11;
					continue;
				case 0:
					((Control)u).Text = this.m_b.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + this.m_b.SelectedItems[0].GetRow().Cells["lname"].Value.ToString() + "\nنام پدر :" + this.m_b.SelectedItems[0].GetRow().Cells["pname"].Value.ToString();
					text = "";
					flag = ak.SelectedIndex <= 0;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 11;
				case 3:
					{
						if (!flag)
						{
							num = 0;
							continue;
						}
						return;
					}
					IL_02c0:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		try
		{
			bool flag = default;
			while (true)
			{
				int num = 7;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 7:
						num = ((this.m_b.RowCount > 0) ? 3 : 0);
						continue;
					case 3:
						num = 1;
						continue;
					case 1:
						num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_00d2;
					case 5:
						((Control)w).Visible = true;
						((Control)af).Enabled = true;
						((UIComboBase)af).Focus();
						ap = "0";
						num = 6;
						continue;
					case 0:
						num2 = 1;
						goto IL_00d2;
					case 2:
						if (!flag)
						{
							if (true)
							{
							}
							num = 5;
							continue;
						}
						goto case 6;
					case 6:
						num = 4;
						continue;
					case 4:
						return;
						IL_00d2:
						flag = (byte)num2 != 0;
						num = 2;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		if (true)
		{
		}
		try
		{
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
						num = ((t.RowCount <= 0) ? 3 : 2);
						continue;
					case 2:
						num = 0;
						continue;
					case 0:
						num2 = (((int)t.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_00ca;
					case 4:
						((Control)af).Enabled = false;
						b();
						((Control)w).Visible = true;
						num = 1;
						continue;
					case 3:
						num2 = 1;
						goto IL_00ca;
					case 6:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 1;
					case 1:
						num = 7;
						continue;
					case 7:
						return;
						IL_00ca:
						flag = (byte)num2 != 0;
						num = 6;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void b()
	{
		if (true)
		{
		}
		ap = t.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		((Control)y).Text = t.SelectedItems[0].GetRow().Cells["comment"].Value.ToString();
		af.SelectedValue = t.SelectedItems[0].GetRow().Cells["typ"].Value.ToString();
		ae.SelectedValue = t.SelectedItems[0].GetRow().Cells["xDisciplinaryCases"].Value.ToString();
		aj.SelectedValue = t.SelectedItems[0].GetRow().Cells["xbook"].Value.ToString();
		ah.the_date = ShamsiDate.ShamsiToGregory(t.SelectedItems[0].GetRow().Cells["DateDis"].Value.ToString());
		((UIComboBase)ae).Focus();
	}

	private void n(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void m(object A_0, EventArgs A_1)
	{
		d();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			string text = ((object)A_1.KeyCode).ToString();
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					if ((int)A_1.KeyCode != 116)
					{
						num = 8;
						continue;
					}
					goto IL_007f;
				case 8:
					if (true)
					{
					}
					num = 6;
					continue;
				case 7:
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					num2 = 0;
					goto IL_00ef;
				case 6:
					if (!(text == "Return"))
					{
						num = 2;
						continue;
					}
					goto IL_007f;
				case 9:
					return;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = (((int)A_1.KeyCode != 112) ? 1 : 0);
					goto IL_00ef;
				case 3:
					{
						if (flag)
						{
							d();
							num = 9;
						}
						else
						{
							num = 7;
						}
						continue;
					}
					IL_007f:
					num = 5;
					continue;
					IL_00ef:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		d();
	}

	private void k(object A_0, EventArgs A_1)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		try
		{
			bool flag = default;
			while (true)
			{
				int num = 8;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 8:
						num = ((t.RowCount <= 0) ? 6 : 5);
						continue;
					case 6:
						num2 = 1;
						goto IL_015c;
					case 1:
						num = 2;
						continue;
					case 5:
						num = 0;
						continue;
					case 0:
						if (true)
						{
						}
						num2 = (((int)t.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_015c;
					case 9:
						asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryStudent where id=" + t.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						c();
						num = 1;
						continue;
					case 3:
						flag = (int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 7;
						continue;
					case 7:
						if (!flag)
						{
							num = 9;
							continue;
						}
						goto case 1;
					case 4:
						if (!flag)
						{
							num = 3;
							continue;
						}
						goto case 2;
					case 2:
						num = 10;
						continue;
					case 10:
						return;
						IL_015c:
						flag = (byte)num2 != 0;
						num = 4;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		c();
		((Control)w).Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			e();
			bool flag = !(af.SelectedValue.ToString() == "3");
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
					((Control)ai).Visible = false;
					((Control)aj).Visible = false;
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					((Control)ai).Visible = true;
					((Control)aj).Visible = true;
					a();
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		string a_ = default;
		while (true)
		{
			bool flag = af.SelectedIndex >= 0;
			int num = 16;
			while (true)
			{
				switch (num)
				{
				case 16:
					if (!flag)
					{
						num = 23;
						continue;
					}
					flag = ae.SelectedIndex >= 0;
					num = 7;
					continue;
				case 8:
					text = "چهارشنبه";
					num = 3;
					continue;
				case 28:
					text = "دوشنبه";
					num = 35;
					continue;
				case 15:
					flag = aj.SelectedIndex > 0;
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 21;
						continue;
					}
					a_ = aj.SelectedValue.ToString();
					num = 10;
					continue;
				case 17:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 3;
				case 9:
					MessageBox.Show("عنوان را انتخاب کنید");
					((UIComboBase)ae).Focus();
					num = 0;
					continue;
				case 0:
					return;
				case 4:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = !(text == "Thursday");
					num = 14;
					continue;
				case 3:
				case 11:
				case 25:
				case 29:
				case 32:
				case 33:
				case 35:
				{
					SqlParameter[] a_2 = new SqlParameter[7]
					{
						asdcb.a("@id", SqlDbType.Int, ap),
						asdcb.a("@xStudent", SqlDbType.Int, this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()),
						asdcb.a("@DateDis", SqlDbType.NVarChar, 10, ShamsiDate.GetShamsiDate(ah.the_date)),
						asdcb.a("@dayOfWeek", SqlDbType.NVarChar, 20, text),
						asdcb.a("@xDisciplinaryCases", SqlDbType.Int, ae.SelectedValue.ToString()),
						asdcb.a("@comment", SqlDbType.NVarChar, asdaj.b(((Control)y).Text.Trim())),
						asdcb.a("@xbook", SqlDbType.Int, a_)
					};
					int num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryStudent_insertUpdate", a_2);
					flag = num2 <= 0;
					num = 30;
					continue;
				}
				case 30:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 13:
					if (!flag)
					{
						num = 28;
						continue;
					}
					flag = !(text == "Tuesday");
					num = 5;
					continue;
				case 21:
					MessageBox.Show("درس را انتخاب کنید");
					((UIComboBase)aj).Focus();
					num = 27;
					continue;
				case 27:
					return;
				case 20:
					text = "جمعه";
					num = 29;
					continue;
				case 2:
					ak.SelectedIndex = 0;
					((Control)y).Text = "";
					((Control)w).Visible = false;
					c();
					MessageBox.Show("ثبت شد");
					((EditBase)this.m_o).SelectAll();
					((Control)this.m_o).Focus();
					num = 18;
					continue;
				case 18:
					return;
				case 12:
					text = "شنبه";
					num = 32;
					continue;
				case 23:
					MessageBox.Show("مورد را انتخاب کنید");
					((UIComboBase)af).Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 19:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 10;
				case 10:
					text = ah.the_date.DayOfWeek.ToString();
					flag = !(text == "Saturday");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(text == "Sunday");
					num = 6;
					continue;
				case 26:
					text = "پنج شنبه";
					num = 33;
					continue;
				case 34:
					text = "سه شنبه";
					num = 25;
					continue;
				case 6:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 13;
					}
					else
					{
						num = 31;
					}
					continue;
				case 31:
					if (true)
					{
					}
					text = "یکشنبه";
					num = 11;
					continue;
				case 5:
					if (flag)
					{
						flag = !(text == "Wednesday");
						num = 4;
					}
					else
					{
						num = 34;
					}
					continue;
				case 7:
					if (flag)
					{
						a_ = "0";
						flag = !(af.SelectedValue.ToString() == "3");
						num = 19;
					}
					else
					{
						num = 9;
					}
					continue;
				case 14:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 17;
					}
					else
					{
						num = 26;
					}
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
			aj.DataSource = null;
			string text = this.m_b.SelectedItems[0].GetRow().Cells["xpaye"].Value.ToString();
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                              union\r\n                                                                                             select id,name from tbook where xPaye=" + text);
			aj.DataSource = dataSource;
			aj.DisplayMember = "Name";
			aj.ValueMember = "id";
			bool flag = ((CollectionBase)(object)aj.Items).Count <= 0;
			if (true)
			{
			}
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
					aj.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
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
		((EditBase)this.m_o).BackColor = Color.White;
	}

	private void d(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_o).BackColor = Color.Yellow;
	}

	private void c(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_p).BackColor = Color.Yellow;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_p).BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 112;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 0:
					n(this, null);
					num = 1;
					continue;
				case 2:
					flag = (int)A_1.KeyCode != 27;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 5:
					p(this, null);
					num = 2;
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

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((ak.SelectedValue.ToString() == "0") ? 7 : 3);
					continue;
				case 0:
					t.Tables[0].Columns["book"].Visible = true;
					num = 6;
					continue;
				case 7:
					num2 = 0;
					goto IL_011d;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((!(ak.SelectedValue.ToString() == "3")) ? 1 : 0);
					goto IL_011d;
				case 1:
					if (flag)
					{
						t.Tables[0].Columns["book"].Visible = false;
						num = 4;
					}
					else
					{
						num = 0;
					}
					continue;
				case 4:
				case 6:
					{
						c();
						return;
					}
					IL_011d:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}
}
