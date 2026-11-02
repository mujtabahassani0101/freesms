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
using Janus.Windows.UI;
using school_Af.Properties;

public class asdt : Form
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

	private GridEX m_n;

	private UIComboBox m_o;

	private Label m_p;

	private GroupBox m_q;

	private Label m_r;

	private Label m_s;

	private DatePicker m_t;

	private Label m_u;

	private TextBox m_v;

	private TextBox m_w;

	private Label m_x;

	private TextBox m_y;

	private Button m_z;

	private OpenFileDialog m_aa;

	private UIButton m_ab;

	private UIButton m_ac;

	private Panel m_ad;

	private UIButton m_ae;

	private UIButton m_af;

	private Label m_ag;

	private EditBox ah;

	private Panel ai;

	private UIButton aj;

	private UIButton ak;

	private UIButton al;

	private TextBox am;

	private Label an;

	private RadioButton ao;

	private RadioButton ap;

	private UIGroupBox aq;

	private UIButton ar;

	private UIButton @as;

	private GridEX at;

	private UIGroupBox au;

	private UIButton av;

	private UIGroupBox aw;

	private Label ax;

	private Label ay;

	private GridEX az;

	private EditBox a0;

	private EditBox a1;

	private Label a2;

	private UIComboBox a3;

	private Label a4;

	private UIComboBox a5;

	private UIButton a6;

	private UIButton a7;

	private TextBox a8;

	private Label a9;

	private Panel ba;

	private TextBox bb;

	private TextBox bc;

	private TextBox bd;

	private Button be;

	private Button bf;

	private Button bg;

	private TextBox bh;

	private Button bi;

	private TextBox bj;

	private Button bk;

	private UIButton bl;

	private UIButton bm;

	private UIButton bn;

	private UIButton bo;

	private UIButton bp;

	private UIButton bq;

	private UIGroupBox br;

	private GridEX bs;

	private DatePicker bt;

	private Label bu;

	private Label bv;

	private DatePicker bw;

	public string bx = "";

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
						num = 5;
					}
					else
					{
						num = 4;
					}
					continue;
				case 5:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 6:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 3:
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

	private void m()
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected Obj, but got Unknown
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected Obj, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected Obj, but got Unknown
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Expected Obj, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected Obj, but got Unknown
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Expected Obj, but got Unknown
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected Obj, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected Obj, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10de: Expected Obj, but got Unknown
		//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected Obj, but got Unknown
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected Obj, but got Unknown
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Expected Obj, but got Unknown
		//IL_11f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Expected Obj, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected Obj, but got Unknown
		//IL_132b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1335: Expected Obj, but got Unknown
		//IL_1346: Unknown result type (might be due to invalid IL or missing references)
		//IL_1350: Expected Obj, but got Unknown
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1425: Expected Obj, but got Unknown
		//IL_14b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bf: Expected Obj, but got Unknown
		//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14da: Expected Obj, but got Unknown
		//IL_15cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d6: Expected Obj, but got Unknown
		//IL_171d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1727: Expected Obj, but got Unknown
		//IL_1820: Unknown result type (might be due to invalid IL or missing references)
		//IL_182a: Expected Obj, but got Unknown
		//IL_19e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ed: Expected Obj, but got Unknown
		//IL_19ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a09: Expected Obj, but got Unknown
		//IL_1adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae6: Expected Obj, but got Unknown
		//IL_1b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b97: Expected Obj, but got Unknown
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Expected Obj, but got Unknown
		//IL_1e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e22: Expected Obj, but got Unknown
		//IL_204c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2056: Expected Obj, but got Unknown
		//IL_20cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d6: Expected Obj, but got Unknown
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2156: Expected Obj, but got Unknown
		//IL_21cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d6: Expected Obj, but got Unknown
		//IL_224c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2256: Expected Obj, but got Unknown
		//IL_2c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c80: Expected Obj, but got Unknown
		//IL_2c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca2: Expected Obj, but got Unknown
		//IL_2d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d6c: Expected Obj, but got Unknown
		//IL_2d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d88: Expected Obj, but got Unknown
		//IL_2e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e45: Expected Obj, but got Unknown
		//IL_2e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e61: Expected Obj, but got Unknown
		//IL_2f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f27: Expected Obj, but got Unknown
		//IL_3147: Unknown result type (might be due to invalid IL or missing references)
		//IL_3151: Expected Obj, but got Unknown
		//IL_33b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c0: Expected Obj, but got Unknown
		//IL_3488: Unknown result type (might be due to invalid IL or missing references)
		//IL_3492: Expected Obj, but got Unknown
		//IL_3675: Unknown result type (might be due to invalid IL or missing references)
		//IL_367f: Expected Obj, but got Unknown
		//IL_373d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3747: Expected Obj, but got Unknown
		//IL_3759: Unknown result type (might be due to invalid IL or missing references)
		//IL_3763: Expected Obj, but got Unknown
		//IL_3823: Unknown result type (might be due to invalid IL or missing references)
		//IL_382d: Expected Obj, but got Unknown
		//IL_383f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3849: Expected Obj, but got Unknown
		//IL_3938: Unknown result type (might be due to invalid IL or missing references)
		//IL_3942: Expected Obj, but got Unknown
		//IL_3b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b16: Expected Obj, but got Unknown
		//IL_3b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b9e: Expected Obj, but got Unknown
		//IL_3c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c2c: Expected Obj, but got Unknown
		//IL_3d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d70: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdt));
		GridEXLayout val2 = new GridEXLayout();
		StringFormat val3 = new StringFormat();
		StringFormat val4 = new StringFormat();
		GridEXLayout val5 = new GridEXLayout();
		StringFormat val6 = new StringFormat();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		StringFormat val9 = new StringFormat();
		StringFormat val10 = new StringFormat();
		StringFormat val11 = new StringFormat();
		GridEXLayout val12 = new GridEXLayout();
		this.m_b = new Panel();
		br = new UIGroupBox();
		bt = new DatePicker();
		bu = new Label();
		bv = new Label();
		bw = new DatePicker();
		bs = new GridEX();
		aw = new UIGroupBox();
		a7 = new UIButton();
		a6 = new UIButton();
		ax = new Label();
		ay = new Label();
		az = new GridEX();
		a0 = new EditBox();
		a1 = new EditBox();
		a2 = new Label();
		a3 = new UIComboBox();
		a4 = new Label();
		a5 = new UIComboBox();
		au = new UIGroupBox();
		ap = new RadioButton();
		ao = new RadioButton();
		aq = new UIGroupBox();
		av = new UIButton();
		ar = new UIButton();
		@as = new UIButton();
		at = new GridEX();
		this.m_g = new Label();
		this.m_q = new GroupBox();
		bl = new UIButton();
		ba = new Panel();
		bm = new UIButton();
		bn = new UIButton();
		bo = new UIButton();
		bp = new UIButton();
		bq = new UIButton();
		bb = new TextBox();
		bc = new TextBox();
		bd = new TextBox();
		be = new Button();
		bf = new Button();
		bg = new Button();
		bh = new TextBox();
		bi = new Button();
		bj = new TextBox();
		bk = new Button();
		a8 = new TextBox();
		a9 = new Label();
		am = new TextBox();
		an = new Label();
		this.m_z = new Button();
		this.m_x = new Label();
		this.m_y = new TextBox();
		this.m_w = new TextBox();
		this.m_u = new Label();
		this.m_v = new TextBox();
		this.m_r = new Label();
		this.m_s = new Label();
		this.m_t = new DatePicker();
		this.m_h = new UIComboBox();
		al = new UIButton();
		aj = new UIButton();
		this.m_c = new Panel();
		this.m_f = new GroupBox();
		this.m_m = new Label();
		this.m_o = new UIComboBox();
		this.m_k = new Label();
		this.m_p = new Label();
		this.m_i = new Label();
		this.m_l = new UIComboBox();
		this.m_j = new UIComboBox();
		this.m_e = new ComboBox();
		ai = new Panel();
		this.m_ac = new UIButton();
		this.m_ab = new UIButton();
		ak = new UIButton();
		this.m_n = new GridEX();
		this.m_d = new Panel();
		this.m_aa = new OpenFileDialog();
		this.m_ad = new Panel();
		this.m_ae = new UIButton();
		this.m_af = new UIButton();
		this.m_ag = new Label();
		ah = new EditBox();
		((Control)this.m_b).SuspendLayout();
		((ISupportInitialize)br).BeginInit();
		((Control)br).SuspendLayout();
		((ISupportInitialize)bs).BeginInit();
		((ISupportInitialize)aw).BeginInit();
		((Control)aw).SuspendLayout();
		((ISupportInitialize)az).BeginInit();
		((ISupportInitialize)au).BeginInit();
		((Control)au).SuspendLayout();
		((ISupportInitialize)aq).BeginInit();
		((Control)aq).SuspendLayout();
		((ISupportInitialize)at).BeginInit();
		((Control)this.m_q).SuspendLayout();
		((Control)ba).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((Control)ai).SuspendLayout();
		((ISupportInitialize)this.m_n).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((Control)this.m_ad).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)br);
		((Control)this.m_b).Controls.Add((Control)(object)aw);
		((Control)this.m_b).Controls.Add((Control)(object)au);
		((Control)this.m_b).Controls.Add((Control)(object)aq);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Controls.Add((Control)(object)al);
		((Control)this.m_b).Controls.Add((Control)(object)aj);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)ai);
		((Control)this.m_b).Location = new Point(4, 5);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(507, 630);
		((Control)this.m_b).TabIndex = 19;
		((Control)br).Anchor = (AnchorStyles)13;
		((Control)br).Controls.Add((Control)(object)bt);
		((Control)br).Controls.Add((Control)(object)bu);
		((Control)br).Controls.Add((Control)(object)bv);
		((Control)br).Controls.Add((Control)(object)bw);
		((Control)br).Controls.Add((Control)(object)bs);
		((Control)br).Font = new Font("Tahoma", 8.25f);
		((Control)br).Location = new Point(155, 319);
		((Control)br).Name = "groupBDate";
		((Control)br).RightToLeft = (RightToLeft)1;
		((Control)br).Size = new Size(344, 294);
		((Control)br).TabIndex = 135;
		((Control)br).Text = "لیست دانش آموزان متولد بین روزهای زیر";
		((Control)br).Visible = false;
		bt.AutoToday = false;
		((Control)bt).BackColor = Color.SeaShell;
		bt.BijanForeColor = Color.Blue;
		((Control)bt).Location = new Point(111, 65);
		((Control)bt).Name = "txtDateTo";
		((Control)bt).Size = new Size(144, 24);
		((Control)bt).TabIndex = 140;
		bt.the_date = new DateTime(2020, 8, 18, 0, 0, 0, 0);
		bt.the_label = "ازمون تاريخ:";
		bt.DateChanged += a;
		((Control)bu).AutoSize = true;
		((Control)bu).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bu).Location = new Point(264, 69);
		((Control)bu).Name = "label12";
		((Control)bu).Size = new Size(56, 13);
		((Control)bu).TabIndex = 139;
		((Control)bu).Text = "روز تولد تا :";
		((Control)bv).AutoSize = true;
		((Control)bv).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bv).Location = new Point(261, 28);
		((Control)bv).Name = "label6";
		((Control)bv).Size = new Size(57, 13);
		((Control)bv).TabIndex = 138;
		((Control)bv).Text = "روز تولد از :";
		bw.AutoToday = false;
		((Control)bw).BackColor = Color.SeaShell;
		bw.BijanForeColor = Color.Blue;
		((Control)bw).Location = new Point(111, 24);
		((Control)bw).Name = "dateBDateFrom";
		((Control)bw).Size = new Size(144, 24);
		((Control)bw).TabIndex = 137;
		bw.the_date = new DateTime(2020, 8, 18, 0, 0, 0, 0);
		bw.the_label = "ازمون تاريخ:";
		bw.DateChanged += b;
		((Control)bs).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		bs.DesignTimeLayout = val;
		bs.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)bs).Font = new Font("Tahoma", 8.25f);
		bs.GroupByBoxVisible = false;
		((Control)bs).Location = new Point(8, 98);
		((Control)bs).Name = "gStdBdate";
		((ScrollableBase)bs).RecordNavigator = true;
		bs.RowHeaders = (InheritableBoolean)1;
		((Control)bs).Size = new Size(323, 193);
		((Control)bs).TabIndex = 135;
		((ScrollableBase)bs).VisualStyle = (VisualStyle)2;
		((Control)aw).Anchor = (AnchorStyles)14;
		((Control)aw).Controls.Add((Control)(object)a7);
		((Control)aw).Controls.Add((Control)(object)a6);
		((Control)aw).Controls.Add((Control)(object)ax);
		((Control)aw).Controls.Add((Control)(object)ay);
		((Control)aw).Controls.Add((Control)(object)az);
		((Control)aw).Controls.Add((Control)(object)a0);
		((Control)aw).Controls.Add((Control)(object)a1);
		((Control)aw).Controls.Add((Control)(object)a2);
		((Control)aw).Controls.Add((Control)(object)a3);
		((Control)aw).Controls.Add((Control)(object)a4);
		((Control)aw).Controls.Add((Control)(object)a5);
		((Control)aw).Font = new Font("Tahoma", 8.25f);
		((Control)aw).Location = new Point(6, 1);
		((Control)aw).Name = "groupSearchStd";
		((Control)aw).RightToLeft = (RightToLeft)1;
		((Control)aw).Size = new Size(495, 415);
		((Control)aw).TabIndex = 134;
		((Control)aw).Text = "جستجو";
		((Control)aw).Visible = false;
		((Control)a7).Anchor = (AnchorStyles)10;
		((Control)a7).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		a7.Image = (Image)(object)Resources.end;
		a7.ImageSize = new Size(30, 30);
		((Control)a7).Location = new Point(12, 353);
		((Control)a7).Name = "btnCancelSelect";
		((Control)a7).Size = new Size(86, 45);
		((Control)a7).TabIndex = 137;
		((Control)a7).Text = "اتمام";
		((Control)a7).Click += n;
		((Control)a6).Anchor = (AnchorStyles)10;
		((Control)a6).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		a6.Image = (Image)(object)Resources.down;
		a6.ImageSize = new Size(40, 40);
		((Control)a6).Location = new Point(170, 356);
		((Control)a6).Name = "btnAdd";
		((Control)a6).Size = new Size(318, 45);
		((Control)a6).TabIndex = 136;
		((Control)a6).Text = "اضافه کردن دانش آموز انتخاب شده به لیست زیر";
		((Control)a6).Click += q;
		((Control)ax).Anchor = (AnchorStyles)9;
		((Control)ax).AutoSize = true;
		((Control)ax).Font = new Font("Tahoma", 8.25f);
		((Control)ax).Location = new Point(185, 54);
		((Control)ax).Name = "label7";
		((Control)ax).Size = new Size(42, 13);
		((Control)ax).TabIndex = 29;
		((Control)ax).Text = "ولد/بنت";
		((Control)ay).Anchor = (AnchorStyles)9;
		((Control)ay).AutoSize = true;
		((Control)ay).Font = new Font("Tahoma", 8.25f);
		((Control)ay).Location = new Point(189, 32);
		((Control)ay).Name = "label2";
		((Control)ay).Size = new Size(20, 13);
		((Control)ay).TabIndex = 28;
		((Control)ay).Text = "نام";
		az.AllowEdit = (InheritableBoolean)2;
		((Control)az).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		az.DesignTimeLayout = val2;
		az.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)az).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		az.GroupByBoxVisible = false;
		((Control)az).Location = new Point(12, 83);
		((Control)az).Name = "gridStdSearch";
		((ScrollableBase)az).RecordNavigator = true;
		az.RowHeaders = (InheritableBoolean)1;
		((Control)az).Size = new Size(476, 264);
		((Control)az).TabIndex = 5;
		((ScrollableBase)az).VisualStyle = (VisualStyle)2;
		((Control)a0).Anchor = (AnchorStyles)9;
		((EditBase)a0).AutoScroll = false;
		((EditBase)a0).AutoScrollMargin = new Size(0, 0);
		((EditBase)a0).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a0).AutoScrollPosition = new Point(0, 0);
		((EditBase)a0).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)a0).Font = new Font("Tahoma", 8.25f);
		((Control)a0).Location = new Point(24, 51);
		((Control)a0).Name = "txtLName";
		((Control)a0).RightToLeft = (RightToLeft)1;
		((Control)a0).Size = new Size(155, 21);
		((Control)a0).TabIndex = 4;
		((EditBase)a0).TextAlignment = (TextAlignment)1;
		((Control)a0).KeyUp += a;
		((Control)a1).Anchor = (AnchorStyles)9;
		((EditBase)a1).AutoScroll = false;
		((EditBase)a1).AutoScrollMargin = new Size(0, 0);
		((EditBase)a1).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a1).AutoScrollPosition = new Point(0, 0);
		((EditBase)a1).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)a1).Font = new Font("Tahoma", 8.25f);
		((Control)a1).Location = new Point(24, 27);
		((Control)a1).Name = "txtFName";
		((Control)a1).RightToLeft = (RightToLeft)1;
		((Control)a1).Size = new Size(155, 21);
		((Control)a1).TabIndex = 3;
		((EditBase)a1).TextAlignment = (TextAlignment)1;
		((Control)a1).KeyUp += a;
		((Control)a2).Anchor = (AnchorStyles)9;
		((Control)a2).AutoSize = true;
		((Control)a2).Location = new Point(450, 57);
		((Control)a2).Name = "label9";
		((Control)a2).Size = new Size(30, 13);
		((Control)a2).TabIndex = 25;
		((Control)a2).Text = "صنف";
		((Control)a3).Anchor = (AnchorStyles)9;
		((UIComboBase)a3).ComboStyle = (ComboStyle)1;
		((UIComboBase)a3).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a3).Font = new Font("Tahoma", 8.25f);
		((Control)a3).Location = new Point(260, 53);
		((Control)a3).Name = "dropClsSearch";
		((Control)a3).Size = new Size(184, 21);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)a3).StringFormat = val3;
		((Control)a3).TabIndex = 2;
		a3.SelectedIndexChanged += r;
		((Control)a4).Anchor = (AnchorStyles)9;
		((Control)a4).AutoSize = true;
		((Control)a4).Font = new Font("Tahoma", 8.25f);
		((Control)a4).Location = new Point(450, 35);
		((Control)a4).Name = "label10";
		((Control)a4).Size = new Size(22, 13);
		((Control)a4).TabIndex = 15;
		((Control)a4).Text = "پایه";
		((Control)a5).Anchor = (AnchorStyles)9;
		((UIComboBase)a5).ComboStyle = (ComboStyle)1;
		((UIComboBase)a5).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a5).Font = new Font("Tahoma", 8.25f);
		((Control)a5).Location = new Point(260, 29);
		((Control)a5).Name = "dropPayeSearch";
		((Control)a5).Size = new Size(184, 21);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)a5).StringFormat = val4;
		((Control)a5).TabIndex = 1;
		a5.SelectedIndexChanged += s;
		((Control)au).Anchor = (AnchorStyles)13;
		((Control)au).Controls.Add((Control)(object)ap);
		((Control)au).Controls.Add((Control)(object)ao);
		((Control)au).Font = new Font("Tahoma", 8.25f);
		((Control)au).Location = new Point(10, 421);
		((Control)au).Name = "groupTypeSelect";
		((Control)au).RightToLeft = (RightToLeft)1;
		((Control)au).Size = new Size(141, 83);
		((Control)au).TabIndex = 133;
		((Control)au).Text = "چاپ بر اساس ";
		((Control)au).Visible = false;
		((Control)ap).AutoSize = true;
		ap.Checked = true;
		((Control)ap).Location = new Point(84, 26);
		((Control)ap).Name = "rClass";
		((Control)ap).Size = new Size(48, 17);
		((Control)ap).TabIndex = 0;
		ap.TabStop = true;
		((Control)ap).Text = "صنف";
		((ButtonBase)ap).UseVisualStyleBackColor = true;
		ap.CheckedChanged += v;
		((Control)ao).AutoSize = true;
		((Control)ao).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ao).Location = new Point(9, 54);
		((Control)ao).Name = "rStd";
		((Control)ao).Size = new Size(123, 17);
		((Control)ao).TabIndex = 1;
		((Control)ao).Text = "انتخاب چند دانش آموز";
		((ButtonBase)ao).UseVisualStyleBackColor = true;
		ao.CheckedChanged += u;
		((Control)aq).Anchor = (AnchorStyles)13;
		((Control)aq).Controls.Add((Control)(object)av);
		((Control)aq).Controls.Add((Control)(object)ar);
		((Control)aq).Controls.Add((Control)(object)@as);
		((Control)aq).Controls.Add((Control)(object)at);
		((Control)aq).Font = new Font("Tahoma", 8.25f);
		((Control)aq).Location = new Point(157, 421);
		((Control)aq).Name = "groupListStd";
		((Control)aq).RightToLeft = (RightToLeft)1;
		((Control)aq).Size = new Size(345, 192);
		((Control)aq).TabIndex = 132;
		((Control)aq).Text = "لیست دانش آموزان جهت نمایش در گزارش";
		((Control)aq).Visible = false;
		av.Image = (Image)(object)Resources._new;
		((Control)av).Location = new Point(4, 27);
		((Control)av).Name = "btnNewStd";
		((Control)av).Size = new Size(113, 45);
		((Control)av).TabIndex = 135;
		((Control)av).Text = "افزودن دانش آموز به لیست پرینت";
		((Control)av).Click += t;
		ar.Image = (Image)(object)Resources.free;
		ar.ImageSize = new Size(20, 20);
		((Control)ar).Location = new Point(4, 140);
		((Control)ar).Name = "btnFree";
		((Control)ar).Size = new Size(113, 45);
		((Control)ar).TabIndex = 134;
		((Control)ar).Text = "خالی کردن کل لیست پرینت";
		((Control)ar).Click += o;
		((Control)@as).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		@as.Image = (Image)componentResourceManager.GetObject("btnDeleteStd.Image");
		((Control)@as).Location = new Point(5, 84);
		((Control)@as).Name = "btnDeleteStd";
		((Control)@as).Size = new Size(113, 45);
		((Control)@as).TabIndex = 133;
		((Control)@as).Text = "حذف مورد انتخابی از لیست پرینت";
		((Control)@as).Click += p;
		at.AllowEdit = (InheritableBoolean)2;
		((Control)at).Anchor = (AnchorStyles)15;
		val5.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		at.DesignTimeLayout = val5;
		at.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)at).Font = new Font("Tahoma", 8.25f);
		at.GroupByBoxVisible = false;
		((Control)at).Location = new Point(123, 23);
		((Control)at).Name = "gSelectStd";
		((ScrollableBase)at).RecordNavigator = true;
		at.RowHeaders = (InheritableBoolean)1;
		((Control)at).Size = new Size(214, 166);
		((Control)at).TabIndex = 5;
		((ScrollableBase)at).VisualStyle = (VisualStyle)2;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Font = new Font("B Nazanin", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(155, 479);
		((Control)this.m_g).Name = "lBook";
		((Control)this.m_g).RightToLeft = (RightToLeft)1;
		((Control)this.m_g).Size = new Size(40, 23);
		((Control)this.m_g).TabIndex = 37;
		((Control)this.m_g).Text = "درس :";
		this.m_g.TextAlign = (ContentAlignment)32;
		((Control)this.m_q).Controls.Add((Control)(object)bl);
		((Control)this.m_q).Controls.Add((Control)(object)ba);
		((Control)this.m_q).Controls.Add((Control)(object)a8);
		((Control)this.m_q).Controls.Add((Control)(object)a9);
		((Control)this.m_q).Controls.Add((Control)(object)am);
		((Control)this.m_q).Controls.Add((Control)(object)an);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_z);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_x);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_y);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_w);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_u);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_v);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_r);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_s);
		((Control)this.m_q).Controls.Add((Control)(object)this.m_t);
		((Control)this.m_q).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_q).Location = new Point(3, 297);
		((Control)this.m_q).Name = "groupBoxAzmoon";
		((Control)this.m_q).RightToLeft = (RightToLeft)1;
		((Control)this.m_q).Size = new Size(495, 118);
		((Control)this.m_q).TabIndex = 14;
		this.m_q.TabStop = false;
		((Control)this.m_q).Text = "تنظیمات آزمون";
		bl.Image = (Image)componentResourceManager.GetObject("btnCancel1.Image");
		((Control)bl).Location = new Point(450, 89);
		((Control)bl).Name = "btnCancel1";
		((Control)bl).Size = new Size(30, 22);
		((Control)bl).TabIndex = 45;
		((Control)bl).Click += h;
		((Control)ba).Controls.Add((Control)(object)bm);
		((Control)ba).Controls.Add((Control)(object)bn);
		((Control)ba).Controls.Add((Control)(object)bo);
		((Control)ba).Controls.Add((Control)(object)bp);
		((Control)ba).Controls.Add((Control)(object)bq);
		((Control)ba).Controls.Add((Control)(object)bb);
		((Control)ba).Controls.Add((Control)(object)bc);
		((Control)ba).Controls.Add((Control)(object)bd);
		((Control)ba).Controls.Add((Control)(object)be);
		((Control)ba).Controls.Add((Control)(object)bf);
		((Control)ba).Controls.Add((Control)(object)bg);
		((Control)ba).Controls.Add((Control)(object)bh);
		((Control)ba).Controls.Add((Control)(object)bi);
		((Control)ba).Controls.Add((Control)(object)bj);
		((Control)ba).Controls.Add((Control)(object)bk);
		((Control)ba).Location = new Point(6, 115);
		((Control)ba).Name = "pOtherPage";
		((Control)ba).Size = new Size(484, 134);
		((Control)ba).TabIndex = 44;
		((Control)ba).Visible = false;
		bm.Image = (Image)componentResourceManager.GetObject("btnCancel6.Image");
		((Control)bm).Location = new Point(444, 109);
		((Control)bm).Name = "btnCancel6";
		((Control)bm).Size = new Size(30, 22);
		((Control)bm).TabIndex = 58;
		((Control)bm).Click += c;
		bn.Image = (Image)componentResourceManager.GetObject("btnCancel5.Image");
		((Control)bn).Location = new Point(444, 83);
		((Control)bn).Name = "btnCancel5";
		((Control)bn).Size = new Size(30, 22);
		((Control)bn).TabIndex = 57;
		((Control)bn).Click += d;
		bo.Image = (Image)componentResourceManager.GetObject("btnCancel4.Image");
		((Control)bo).Location = new Point(444, 55);
		((Control)bo).Name = "btnCancel4";
		((Control)bo).Size = new Size(30, 22);
		((Control)bo).TabIndex = 56;
		((Control)bo).Click += e;
		bp.Image = (Image)componentResourceManager.GetObject("btnCancel3.Image");
		((Control)bp).Location = new Point(444, 29);
		((Control)bp).Name = "btnCancel3";
		((Control)bp).Size = new Size(30, 22);
		((Control)bp).TabIndex = 55;
		((Control)bp).Click += f;
		bq.Image = (Image)componentResourceManager.GetObject("btnCancel2.Image");
		((Control)bq).Location = new Point(444, 4);
		((Control)bq).Name = "btnCancel2";
		((Control)bq).Size = new Size(30, 22);
		((Control)bq).TabIndex = 54;
		((Control)bq).Click += g;
		((Control)bb).Enabled = false;
		((Control)bb).Location = new Point(98, 110);
		((Control)bb).Name = "txtadress6";
		((Control)bb).Size = new Size(340, 21);
		((Control)bb).TabIndex = 53;
		((Control)bc).Enabled = false;
		((Control)bc).Location = new Point(98, 83);
		((Control)bc).Name = "txtadress5";
		((Control)bc).Size = new Size(340, 21);
		((Control)bc).TabIndex = 52;
		((Control)bd).Enabled = false;
		((Control)bd).Location = new Point(98, 56);
		((Control)bd).Name = "txtadress4";
		((Control)bd).Size = new Size(340, 21);
		((Control)bd).TabIndex = 51;
		((Control)be).Location = new Point(2, 107);
		((Control)be).Name = "btnSelectPage6";
		((Control)be).Size = new Size(89, 23);
		((Control)be).TabIndex = 50;
		((Control)be).Text = "صفحه 6";
		((ButtonBase)be).UseVisualStyleBackColor = true;
		((Control)be).Click += i;
		((Control)bf).Location = new Point(3, 81);
		((Control)bf).Name = "btnSelectPage5";
		((Control)bf).Size = new Size(89, 23);
		((Control)bf).TabIndex = 49;
		((Control)bf).Text = "صفحه 5";
		((ButtonBase)bf).UseVisualStyleBackColor = true;
		((Control)bf).Click += j;
		((Control)bg).Location = new Point(2, 56);
		((Control)bg).Name = "btnSelectPage4";
		((Control)bg).Size = new Size(89, 23);
		((Control)bg).TabIndex = 48;
		((Control)bg).Text = "صفحه 4";
		((ButtonBase)bg).UseVisualStyleBackColor = true;
		((Control)bg).Click += k;
		((Control)bh).Enabled = false;
		((Control)bh).Location = new Point(98, 30);
		((Control)bh).Name = "txtadress3";
		((Control)bh).Size = new Size(340, 21);
		((Control)bh).TabIndex = 47;
		((Control)bi).Location = new Point(2, 29);
		((Control)bi).Name = "btnSelectPage3";
		((Control)bi).Size = new Size(89, 23);
		((Control)bi).TabIndex = 46;
		((Control)bi).Text = "صفحه 3";
		((ButtonBase)bi).UseVisualStyleBackColor = true;
		((Control)bi).Click += l;
		((Control)bj).Enabled = false;
		((Control)bj).Location = new Point(98, 4);
		((Control)bj).Name = "txtadress2";
		((Control)bj).Size = new Size(340, 21);
		((Control)bj).TabIndex = 45;
		((Control)bk).Location = new Point(2, 4);
		((Control)bk).Name = "btnSelectPage2";
		((Control)bk).Size = new Size(91, 23);
		((Control)bk).TabIndex = 44;
		((Control)bk).Text = "صفحه 2";
		((ButtonBase)bk).UseVisualStyleBackColor = true;
		((Control)bk).Click += m;
		((Control)a8).Location = new Point(13, 47);
		((TextBoxBase)a8).MaxLength = 15;
		((Control)a8).Name = "txtStartExam";
		((Control)a8).Size = new Size(82, 21);
		((Control)a8).TabIndex = 23;
		((Control)a9).AutoSize = true;
		((Control)a9).Location = new Point(98, 51);
		((Control)a9).Name = "label11";
		((Control)a9).Size = new Size(76, 13);
		((Control)a9).TabIndex = 29;
		((Control)a9).Text = "ساعت شروع :";
		((Control)am).Location = new Point(198, 46);
		((TextBoxBase)am).MaxLength = 10;
		((Control)am).Name = "txtCountQus";
		((Control)am).Size = new Size(60, 21);
		((Control)am).TabIndex = 22;
		((Control)an).AutoSize = true;
		((Control)an).Location = new Point(264, 51);
		((Control)an).Name = "label1";
		((Control)an).Size = new Size(66, 13);
		((Control)an).TabIndex = 28;
		((Control)an).Text = "تعداد سوال :";
		((Control)this.m_z).Location = new Point(7, 90);
		((Control)this.m_z).Name = "btnSelectPage1";
		((Control)this.m_z).Size = new Size(94, 23);
		((Control)this.m_z).TabIndex = 27;
		((Control)this.m_z).Text = "انتخاب فایل";
		((ButtonBase)this.m_z).UseVisualStyleBackColor = true;
		((Control)this.m_z).Click += ac;
		((Control)this.m_x).Location = new Point(311, 72);
		((Control)this.m_x).Name = "lQusText";
		((Control)this.m_x).Size = new Size(175, 14);
		((Control)this.m_x).TabIndex = 26;
		((Control)this.m_x).Text = "مسیر عکس سوالات صفحه اول";
		this.m_x.TextAlign = (ContentAlignment)16;
		((Control)this.m_y).Enabled = false;
		((Control)this.m_y).Location = new Point(104, 89);
		((Control)this.m_y).Name = "txtadress";
		((Control)this.m_y).Size = new Size(340, 21);
		((Control)this.m_y).TabIndex = 25;
		((Control)this.m_w).Location = new Point(361, 46);
		((TextBoxBase)this.m_w).MaxLength = 10;
		((Control)this.m_w).Name = "txtCountPage";
		((Control)this.m_w).Size = new Size(57, 21);
		((Control)this.m_w).TabIndex = 21;
		((Control)this.m_u).AutoSize = true;
		((Control)this.m_u).Location = new Point(422, 50);
		((Control)this.m_u).Name = "label5";
		((Control)this.m_u).Size = new Size(68, 13);
		((Control)this.m_u).TabIndex = 23;
		((Control)this.m_u).Text = "تعداد صفحه :";
		((Control)this.m_v).Location = new Point(14, 19);
		((TextBoxBase)this.m_v).MaxLength = 50;
		((Control)this.m_v).Name = "txtTimeExam";
		((Control)this.m_v).Size = new Size(81, 21);
		((Control)this.m_v).TabIndex = 20;
		((Control)this.m_r).AutoSize = true;
		((Control)this.m_r).Location = new Point(102, 23);
		((Control)this.m_r).Name = "label4";
		((Control)this.m_r).Size = new Size(68, 13);
		((Control)this.m_r).TabIndex = 21;
		((Control)this.m_r).Text = "مدت امتحان :";
		((Control)this.m_s).AutoSize = true;
		((Control)this.m_s).Location = new Point(420, 22);
		((Control)this.m_s).Name = "label3";
		((Control)this.m_s).Size = new Size(68, 13);
		((Control)this.m_s).TabIndex = 20;
		((Control)this.m_s).Text = "تاریخ امتحان :";
		this.m_t.AutoToday = true;
		((Control)this.m_t).BackColor = Color.SeaShell;
		this.m_t.BijanForeColor = Color.Blue;
		((Control)this.m_t).Location = new Point(274, 16);
		((Control)this.m_t).Name = "txtDateFrom";
		((Control)this.m_t).Size = new Size(144, 24);
		((Control)this.m_t).TabIndex = 19;
		this.m_t.the_date = new DateTime(2020, 11, 20, 19, 59, 42, 780);
		this.m_t.the_label = "ازمون تاريخ:";
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(7, 478);
		((Control)this.m_h).Name = "dropBook";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(144, 21);
		val6.Alignment = (StringAlignment)0;
		val6.FormatFlags = (StringFormatFlags)20485;
		val6.HotkeyPrefix = (HotkeyPrefix)0;
		val6.LineAlignment = (StringAlignment)1;
		val6.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val6;
		((Control)this.m_h).TabIndex = 36;
		((Control)al).Anchor = (AnchorStyles)10;
		((Control)al).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		al.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		al.ImageSize = new Size(40, 40);
		((Control)al).Location = new Point(9, 568);
		((Control)al).Name = "btnClose";
		((Control)al).Size = new Size(142, 45);
		((Control)al).TabIndex = 111;
		((Control)al).Text = "بستن";
		((Control)al).Click += w;
		((Control)aj).Anchor = (AnchorStyles)10;
		((Control)aj).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		aj.Image = (Image)componentResourceManager.GetObject("btnView.Image");
		aj.ImageSize = new Size(40, 40);
		((Control)aj).Location = new Point(9, 510);
		((Control)aj).Name = "btnView";
		((Control)aj).Size = new Size(142, 52);
		((Control)aj).TabIndex = 109;
		((Control)aj).Text = "نمایش";
		((Control)aj).Click += ad;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(163, 428);
		((Control)this.m_c).Name = "pClass";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(336, 185);
		((Control)this.m_c).TabIndex = 103;
		((Control)this.m_f).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_p);
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
		((UIComboBase)this.m_o).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_o).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val7.FormatStyle.Alpha = 0;
		val7.Text = "ردیف-نام خانوادگی";
		val7.Value = "1";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "حوزه-شماره چوکی";
		val8.Value = "2";
		this.m_o.Items.AddRange(new UIComboBoxItem[2] { val7, val8 });
		((Control)this.m_o).Location = new Point(12, 99);
		((Control)this.m_o).Name = "dropSort";
		((Control)this.m_o).Size = new Size(183, 21);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_o).StringFormat = val9;
		((Control)this.m_o).TabIndex = 109;
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Location = new Point(201, 51);
		((Control)this.m_k).Name = "label19";
		((Control)this.m_k).Size = new Size(30, 13);
		((Control)this.m_k).TabIndex = 105;
		((Control)this.m_k).Text = "صنف";
		((Control)this.m_p).AutoSize = true;
		((Control)this.m_p).Location = new Point(200, 104);
		((Control)this.m_p).Name = "lSort";
		((Control)this.m_p).Size = new Size(64, 13);
		((Control)this.m_p).TabIndex = 108;
		((Control)this.m_p).Text = "ترتیب نماش ";
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
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_l).StringFormat = val10;
		((Control)this.m_l).TabIndex = 104;
		this.m_l.SelectedIndexChanged += af;
		((UIComboBase)this.m_j).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_j).DropListFont = new Font("Rod", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(13, 20);
		((Control)this.m_j).Name = "dropPaye";
		((Control)this.m_j).Size = new Size(183, 21);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_j).StringFormat = val11;
		((Control)this.m_j).TabIndex = 104;
		this.m_j.SelectedIndexChanged += ae;
		this.m_e.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)this.m_e).FormattingEnabled = true;
		((Control)this.m_e).Location = new Point(13, 73);
		((Control)this.m_e).Name = "dropStd";
		((Control)this.m_e).Size = new Size(183, 21);
		((Control)this.m_e).TabIndex = 3;
		((Control)this.m_e).Visible = false;
		ai.BorderStyle = (BorderStyle)1;
		((Control)ai).Controls.Add((Control)(object)this.m_ac);
		((Control)ai).Controls.Add((Control)(object)this.m_ab);
		((Control)ai).Controls.Add((Control)(object)ak);
		((Control)ai).Controls.Add((Control)(object)this.m_n);
		((Control)ai).Location = new Point(6, 6);
		((Control)ai).Name = "pRpt";
		((Control)ai).Size = new Size(494, 405);
		((Control)ai).TabIndex = 108;
		((Control)this.m_ac).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_ac.Image = (Image)(object)Resources.copy;
		this.m_ac.ImageSize = new Size(30, 30);
		((Control)this.m_ac).Location = new Point(5, 6);
		((Control)this.m_ac).Name = "btnNew";
		((Control)this.m_ac).Size = new Size(151, 42);
		((Control)this.m_ac).TabIndex = 107;
		((Control)this.m_ac).Text = "تهیه گزارش جدید از روی گزارش انتخاب شده";
		((Control)this.m_ac).Click += aa;
		this.m_ab.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_ab).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_ab.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_ab.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_ab.ImageIndex = 8;
		((Control)this.m_ab).Location = new Point(5, 103);
		((Control)this.m_ab).Name = "btnDelete";
		((Control)this.m_ab).RightToLeft = (RightToLeft)1;
		((Control)this.m_ab).Size = new Size(151, 42);
		((Control)this.m_ab).TabIndex = 106;
		((Control)this.m_ab).Text = "حذف گزارش انتخاب شده";
		this.m_ab.VisualStyle = (VisualStyle)1;
		((Control)this.m_ab).Click += ab;
		((Control)ak).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		ak.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		ak.ImageSize = new Size(40, 40);
		((Control)ak).Location = new Point(5, 54);
		((Control)ak).Name = "btnEdit";
		((Control)ak).Size = new Size(151, 42);
		((Control)ak).TabIndex = 110;
		((Control)ak).Text = "ویرایش گزارش";
		((Control)ak).Click += x;
		this.m_n.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_n).Anchor = (AnchorStyles)15;
		val12.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		this.m_n.DesignTimeLayout = val12;
		this.m_n.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_n).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_n.GroupByBoxVisible = false;
		((Control)this.m_n).Location = new Point(162, 3);
		((Control)this.m_n).Name = "gridEX1";
		((Control)this.m_n).RightToLeft = (RightToLeft)1;
		this.m_n.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_n).Size = new Size(324, 397);
		((Control)this.m_n).TabIndex = 104;
		((ScrollableBase)this.m_n).VisualStyle = (VisualStyle)2;
		((Control)this.m_d).BackColor = SystemColors.ControlText;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_d).Dock = (DockStyle)5;
		((Control)this.m_d).Location = new Point(0, 0);
		((Control)this.m_d).Name = "panel4";
		((Control)this.m_d).Size = new Size(515, 640);
		((Control)this.m_d).TabIndex = 20;
		((FileDialog)this.m_aa).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_aa).Title = "فایل عکس صفحه اول سوالات امتحان";
		((Control)this.m_ad).BackColor = Color.FromArgb(214, 223, 247);
		this.m_ad.BorderStyle = (BorderStyle)1;
		((Control)this.m_ad).Controls.Add((Control)(object)this.m_ae);
		((Control)this.m_ad).Controls.Add((Control)(object)this.m_af);
		((Control)this.m_ad).Controls.Add((Control)(object)this.m_ag);
		((Control)this.m_ad).Controls.Add((Control)(object)ah);
		((Control)this.m_ad).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_ad).Location = new Point(174, 161);
		((Control)this.m_ad).Name = "pNew";
		((Control)this.m_ad).RightToLeft = (RightToLeft)1;
		((Control)this.m_ad).Size = new Size(327, 116);
		((Control)this.m_ad).TabIndex = 108;
		((Control)this.m_ad).Visible = false;
		this.m_ae.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)this.m_ae).Location = new Point(40, 67);
		((Control)this.m_ae).Name = "btnCancel";
		((Control)this.m_ae).Size = new Size(75, 32);
		((Control)this.m_ae).TabIndex = 16;
		((Control)this.m_ae).Text = "انصراف";
		((Control)this.m_ae).Click += z;
		this.m_af.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)this.m_af).Location = new Point(121, 67);
		((Control)this.m_af).Name = "btnAcp";
		((Control)this.m_af).Size = new Size(75, 32);
		((Control)this.m_af).TabIndex = 14;
		((Control)this.m_af).Text = "تایید";
		((Control)this.m_af).Click += y;
		((Control)this.m_ag).Location = new Point(228, 22);
		((Control)this.m_ag).Name = "label8";
		((Control)this.m_ag).Size = new Size(86, 28);
		((Control)this.m_ag).TabIndex = 1;
		((Control)this.m_ag).Text = "عنوان الگو";
		this.m_ag.TextAlign = (ContentAlignment)64;
		((EditBase)ah).AutoScroll = false;
		((EditBase)ah).AutoScrollMargin = new Size(0, 0);
		((EditBase)ah).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ah).AutoScrollPosition = new Point(0, 0);
		((Control)ah).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ah).Location = new Point(13, 19);
		((Control)ah).Name = "txtNam";
		((Control)ah).Size = new Size(211, 33);
		((Control)ah).TabIndex = 0;
		((EditBase)ah).TextAlignment = (TextAlignment)1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = SystemColors.InactiveCaptionText;
		((Form)this).ClientSize = new Size(515, 640);
		((Control)this).Controls.Add((Control)(object)this.m_ad);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmsarbarg2";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "سربرگ";
		((Form)this).Load += ag;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((ISupportInitialize)br).EndInit();
		((Control)br).ResumeLayout(false);
		((Control)br).PerformLayout();
		((ISupportInitialize)bs).EndInit();
		((ISupportInitialize)aw).EndInit();
		((Control)aw).ResumeLayout(false);
		((Control)aw).PerformLayout();
		((ISupportInitialize)az).EndInit();
		((ISupportInitialize)au).EndInit();
		((Control)au).ResumeLayout(false);
		((Control)au).PerformLayout();
		((ISupportInitialize)aq).EndInit();
		((Control)aq).ResumeLayout(false);
		((ISupportInitialize)at).EndInit();
		((Control)this.m_q).ResumeLayout(false);
		((Control)this.m_q).PerformLayout();
		((Control)ba).ResumeLayout(false);
		((Control)ba).PerformLayout();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((Control)ai).ResumeLayout(false);
		((ISupportInitialize)this.m_n).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_ad).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdt()
	{
		m();
	}

	private void l()
	{
		FileStream fileStream = default;
		byte[] buffer = default;
		while (true)
		{
			string path = Application.StartupPath + "\\1000.rpx";
			SqlDataReader val = asdcb.b(asdab.e(), CommandType.Text, "select Rpt from tRptDynamic where id=" + this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
			bool flag = !((DbDataReader)(object)val).Read();
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
					goto case 3;
				case 1:
					try
					{
						BinaryWriter binaryWriter = new BinaryWriter(fileStream);
						try
						{
							binaryWriter.Write(buffer);
							binaryWriter.Close();
						}
						finally
						{
							while (true)
							{
								IL_00db:
								flag = binaryWriter == null;
								num = 1;
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
										goto end_IL_00c6;
									case 0:
										((IDisposable)binaryWriter).Dispose();
										num = 2;
										continue;
									case 2:
										goto end_IL_00c6;
									}
									goto IL_00db;
									continue;
									end_IL_00c6:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						while (true)
						{
							IL_012f:
							flag = fileStream == null;
							num = 0;
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
									goto end_IL_011a;
								case 2:
									((IDisposable)fileStream).Dispose();
									num = 1;
									continue;
								case 1:
									goto end_IL_011a;
								}
								goto IL_012f;
								continue;
								end_IL_011a:
								break;
							}
							break;
						}
					}
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					buffer = (byte[])((DbDataReader)(object)val).GetValue(0);
					fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
					num = 1;
					continue;
				case 3:
					((DbDataReader)(object)val).Close();
					((DbDataReader)(object)val).Dispose();
					return;
				}
				break;
			}
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		while (true)
		{
			bool flag = asdaj.a("12");
			int num = 3;
			while (true)
			{
				int num4;
				int num3;
				switch (num)
				{
				case 3:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					string text2 = asdab.b();
					this.m_t.the_date = ShamsiDate.ShamsiToGregory(text2);
					bw.the_date = ShamsiDate.ShamsiToGregory(text2);
					bt.the_date = ShamsiDate.ShamsiToGregory(text2);
					num = 19;
					continue;
				}
				case 7:
					num = 23;
					continue;
				case 10:
				{
					int num2 = int.Parse(asdab.b().Substring(0, 4));
					flag = num2 >= 1399;
					num = 34;
					continue;
				}
				case 34:
					if (!flag)
					{
						num = 4;
						continue;
					}
					((Control)this.m_q).Visible = false;
					((Control)ai).Height = 300;
					((Control)this.m_g).Visible = false;
					((Control)this.m_h).Visible = false;
					((Control)au).Visible = false;
					((Control)br).Visible = true;
					((Control)this.m_c).Visible = false;
					j();
					text = k();
					flag = !(text != "0");
					num = 16;
					continue;
				case 17:
					num4 = 0;
					goto IL_0217;
				case 33:
					num3 = 0;
					goto IL_023f;
				case 25:
					num = 15;
					continue;
				case 15:
					if (!(bx == "3"))
					{
						num = 14;
						continue;
					}
					goto IL_0127;
				case 18:
					MessageBox.Show("تعداد " + text + "  نفر از دانش آموزان فاقد تاریخ تولد هستند");
					num = 7;
					continue;
				case 0:
					((Control)this.m_p).Visible = false;
					((Control)this.m_o).Visible = false;
					num = 31;
					continue;
				case 24:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 5;
				case 13:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(bx == "1");
					num = 6;
					continue;
				case 8:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 31;
				case 31:
					i();
					g();
					e();
					c();
					this.m_o.SelectedIndex = 0;
					h();
					f();
					a();
					num = 12;
					continue;
				case 12:
					return;
				case 26:
					((Control)ai).Height = 270;
					num = 32;
					continue;
				case 1:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 22;
					continue;
				case 22:
					return;
				case 14:
					num = 9;
					continue;
				case 9:
					num4 = ((!(bx == "4")) ? 1 : 0);
					goto IL_0217;
				case 2:
					((Control)this.m_q).Visible = false;
					((Control)ai).Height = 400;
					((Control)this.m_g).Visible = false;
					((Control)this.m_h).Visible = false;
					((Control)au).Visible = true;
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						num = 26;
						continue;
					}
					flag = !(bx == "5");
					num = 11;
					continue;
				case 29:
					num = 28;
					continue;
				case 28:
					num3 = ((!(bx == "3")) ? 1 : 0);
					goto IL_023f;
				case 16:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 7;
				case 11:
					if (flag)
					{
						flag = !(bx == "6");
						num = 24;
					}
					else
					{
						num = 20;
					}
					continue;
				case 20:
					((Control)ai).Height = 170;
					((Control)this.m_q).Height = 255;
					((Control)this.m_q).Top = 185;
					((Control)ba).Visible = true;
					((Control)this.m_x).Text = "مسیر عکس سوالات";
					((Control)this.m_z).Text = "صفحه 1";
					if (true)
					{
					}
					num = 27;
					continue;
				case 4:
					MessageBox.Show("تاریخ کامپیوتر شما بروز نیست ابتدا تاریخ کامپیوتر را تنظیم کرده و دوباره وارد این بخش شوید");
					((Form)this).Close();
					num = 21;
					continue;
				case 21:
					return;
				case 19:
					if (!(bx == "2"))
					{
						num = 25;
						continue;
					}
					goto IL_0127;
				case 5:
				case 23:
				case 27:
				case 32:
					num = 30;
					continue;
				case 30:
					{
						num = ((!(bx == "2")) ? 29 : 33);
						continue;
					}
					IL_0127:
					num = 17;
					continue;
					IL_023f:
					flag = (byte)num3 != 0;
					num = 8;
					continue;
					IL_0217:
					flag = (byte)num4 != 0;
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private string k()
	{
		string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT    count( tStudent.id)  \r\n                        FROM  tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent inner join tclass on tYear_Student.xclass=tclass.id\r\n                        where tYear_Student.xyear=" + asdaj.a + " and tYear_Student.xPaye in(" + asdaj.n + ") and  len(isnull(tStudent.bdate,'1'))<10 ").ToString();
		string result = text;
		if (true)
		{
		}
		return result;
	}

	private void j()
	{
		while (true)
		{
			if (true)
			{
			}
			string text = "  tYear_Student.xYear=" + asdaj.a + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			text += " and len(tStudent.bDate)=10";
			text = text + " and substring(tStudent.bDate,6,5)>=N'" + ShamsiDate.GetShamsiDate(bw.the_date).Substring(5, 5) + "'";
			text = text + " and substring(tStudent.bDate,6,5)<=N'" + ShamsiDate.GetShamsiDate(bt.the_date).Substring(5, 5) + "'";
			bool flag = !(text != "");
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
					goto case 2;
				case 0:
					text = " where " + text;
					num = 2;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.FName, tStudent.LName, tStudent.PName,tclass.name as class,substring(tStudent.bdate,3,8) as bdate \r\n                        FROM  tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent inner join tclass on tYear_Student.xclass=tclass.id  " + text + " order by tStudent.lname,tStudent.fname");
					bs.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void i()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptDynamic where type=" + bx);
		this.m_n.DataSource = dataSource;
	}

	private void h()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه پایه ها' as  name\r\n                                                                                                                union select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.a + ") order by id");
			a5.DataSource = dataSource;
			a5.DisplayMember = "Name";
			a5.ValueMember = "id";
			bool flag = ((CollectionBase)(object)a5.Items).Count <= 0;
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
					a5.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void g()
	{
		while (true)
		{
			if (true)
			{
			}
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.a + ") order by id");
			this.m_j.DataSource = dataSource;
			this.m_j.DisplayMember = "Name";
			this.m_j.ValueMember = "id";
			bool flag = ((CollectionBase)(object)this.m_j.Items).Count <= 0;
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
					return;
				case 2:
					this.m_j.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void f()
	{
		while (true)
		{
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = a5.SelectedIndex <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 3;
				case 4:
					a3.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 3:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where  xYear=" + asdaj.a + text);
					a3.DataSource = dataSource;
					a3.DisplayMember = "Name";
					a3.ValueMember = "id";
					flag = ((CollectionBase)(object)a3.Items).Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 5:
					if (true)
					{
					}
					text = " and xPaye=" + a5.SelectedValue.ToString();
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void e()
	{
		while (true)
		{
			string text = "  where  xYear=" + asdaj.a + " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_j.SelectedIndex < 0;
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
						num = 2;
						continue;
					}
					goto case 1;
				case 4:
					this.m_l.SelectedIndex = 0;
					num = 3;
					continue;
				case 3:
					return;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'تمام صنف ها' as  name\r\n                                                                                                                union select id,name from tClass" + text);
					this.m_l.DataSource = dataSource;
					this.m_l.DisplayMember = "Name";
					this.m_l.ValueMember = "id";
					flag = ((CollectionBase)(object)this.m_l.Items).Count <= 0;
					num = 5;
					continue;
				}
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 2:
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

	private void d()
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
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 8:
					flag = dictionary.Count != 0;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 4;
						continue;
					}
					this.m_e.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)this.m_e).DisplayMember = "Value";
					((ListControl)this.m_e).ValueMember = "Key";
					num = 12;
					continue;
				case 13:
					if (true)
					{
					}
					((Control)this.m_e).Visible = false;
					((Control)this.m_m).Visible = false;
					this.m_e.DataSource = null;
					num = 0;
					continue;
				case 0:
					return;
				case 9:
					flag = !(this.m_l.SelectedValue.ToString() == "0");
					num = 11;
					continue;
				case 11:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					((Control)this.m_e).Visible = true;
					((Control)this.m_m).Visible = true;
					string a_ = "select tStudent.id,tStudent.lname + N' - '+ tStudent.fname as name  from tstudent inner join \r\n                                 tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.status=1 and tYear_Student.xYear=" + asdaj.a + " and tYear_Student.xclass= " + this.m_l.SelectedValue.ToString() + " order by tYear_Student.sort,tStudent.lname,tStudent.fname,tStudent.id";
					dictionary = new Dictionary<string, string>();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count <= 1;
					num = 16;
					continue;
				}
				case 4:
					this.m_e.DataSource = null;
					MessageBox.Show("دانش آموزی در این صنف وجود ندارد");
					num = 10;
					continue;
				case 10:
				case 12:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					num2 = 0;
					num = 1;
					continue;
				case 16:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 2;
				case 1:
				case 15:
					flag = num2 < dataTable.Rows.Count;
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						num = 15;
					}
					else
					{
						num = 8;
					}
					continue;
				case 14:
					dictionary.Add("0", "تمام دانش آموزان صنف");
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			bool flag = this.m_j.SelectedIndex < 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						this.m_h.DataSource = null;
						num = 5;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					this.m_h.SelectedIndex = 0;
					num = 6;
					continue;
				case 4:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tbook where xPaye=" + this.m_j.SelectedValue.ToString());
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					flag = ((CollectionBase)(object)this.m_h.Items).Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		d();
	}

	private void ae(object A_0, EventArgs A_1)
	{
		e();
		c();
	}

	private void ad(object A_0, EventArgs A_1)
	{
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected Obj, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected Obj, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected Obj, but got Unknown
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		int num10 = default;
		int num3 = default;
		string text3 = default;
		DataSet dataSet = default;
		while (true)
		{
			string text = "0";
			string text2 = "0";
			bool flag = !((Control)aw).Visible;
			int num = 12;
			while (true)
			{
				int num8;
				int num7;
				int num2;
				int num4;
				int num6;
				int num9;
				int num5;
				switch (num)
				{
				case 12:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 26;
				case 107:
					return;
				case 15:
					text2 += ",";
					num = 22;
					continue;
				case 3:
					num = 108;
					continue;
				case 108:
					num8 = ((!(bx != "5")) ? 1 : 0);
					goto IL_0eae;
				case 112:
					num = ((((Control)bh).Text != "") ? 76 : 51);
					continue;
				case 97:
					MessageBox.Show("تاریخ انتخابی اشتباه است");
					num = 91;
					continue;
				case 91:
					return;
				case 101:
					MessageBox.Show("عکس صفحه چهارم را انتخاب کنید");
					num = 94;
					continue;
				case 94:
					return;
				case 19:
					num = 4;
					continue;
				case 4:
					num7 = ((!(((Control)bj).Text != "")) ? 1 : 0);
					goto IL_06de;
				case 84:
				case 87:
				case 95:
					num = 92;
					continue;
				case 92:
					num = ((!(((Control)this.m_y).Text == "")) ? 46 : 19);
					continue;
				case 76:
					num2 = 0;
					goto IL_0c18;
				case 5:
					if (!flag)
					{
						num = 96;
						continue;
					}
					MessageBox.Show("پایه ای انتخاب نشده است");
					num = 70;
					continue;
				case 62:
					flag = !(text2 == "0");
					num = 110;
					continue;
				case 110:
					if (!flag)
					{
						num = 58;
						continue;
					}
					num10 = int.Parse(ShamsiDate.GetShamsiDate(bw.the_date).Substring(0, 4));
					flag = num10 >= 1399;
					num = 17;
					continue;
				case 102:
					MessageBox.Show("تاریخ انتخابی اشتباه است");
					num = 93;
					continue;
				case 93:
					return;
				case 28:
					num = ((!(((Control)bd).Text == "")) ? 89 : 65);
					continue;
				case 109:
					if (!flag)
					{
						num = 16;
						continue;
					}
					if (true)
					{
					}
					num = 87;
					continue;
				case 7:
					num8 = 1;
					goto IL_0eae;
				case 31:
					flag = !(this.m_l.SelectedValue.ToString() != "0");
					num = 105;
					continue;
				case 105:
					if (!flag)
					{
						num = 81;
						continue;
					}
					goto case 111;
				case 27:
				case 37:
					flag = num3 < bs.RowCount;
					num = 56;
					continue;
				case 56:
					if (!flag)
					{
						num = 62;
						continue;
					}
					flag = !(text2 != "");
					num = 72;
					continue;
				case 38:
					num = 84;
					continue;
				case 1:
					num = 10;
					continue;
				case 10:
					num4 = ((!(((Control)bh).Text != "")) ? 1 : 0);
					goto IL_071c;
				case 25:
				case 39:
					flag = num3 < at.RowCount;
					num = 45;
					continue;
				case 45:
					if (!flag)
					{
						num = 83;
						continue;
					}
					flag = !(text2 != "");
					num = 23;
					continue;
				case 2:
					num = 64;
					continue;
				case 53:
					MessageBox.Show("عکس صفحه سوم را انتخاب کنید");
					num = 49;
					continue;
				case 49:
					return;
				case 80:
					text = "3";
					text2 = ((ListControl)this.m_e).SelectedValue.ToString();
					num = 86;
					continue;
				case 51:
					num = 82;
					continue;
				case 82:
					num2 = ((!(((Control)bd).Text == "")) ? 1 : 0);
					goto IL_0c18;
				case 17:
				{
					if (!flag)
					{
						num = 102;
						continue;
					}
					int num11 = int.Parse(ShamsiDate.GetShamsiDate(bt.the_date).Substring(0, 4));
					flag = num10 <= num11;
					num = 47;
					continue;
				}
				case 16:
					MessageBox.Show("اختلاف دو تاریخ نباید بیشتر از یک ماه باشد");
					num = 35;
					continue;
				case 35:
					return;
				case 65:
					num = 20;
					continue;
				case 20:
					num6 = ((!(((Control)bc).Text != "")) ? 1 : 0);
					goto IL_0aff;
				case 67:
					num = (flag ? 21 : 100);
					continue;
				case 18:
					num = 111;
					continue;
				case 63:
					num = (flag ? 50 : 43);
					continue;
				case 81:
					text = "2";
					text2 = this.m_l.SelectedValue.ToString();
					flag = ((ListControl)this.m_e).SelectedIndex < 0;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 106;
						continue;
					}
					MessageBox.Show("دانش آموزی انتخاب نشده است");
					num = 68;
					continue;
				case 40:
					((Control)aw).Visible = false;
					num = 26;
					continue;
				case 100:
					MessageBox.Show("عکس صفحه اول را انتخاب کنید");
					num = 33;
					continue;
				case 33:
					return;
				case 46:
					num7 = 1;
					goto IL_06de;
				case 106:
					flag = !(((ListControl)this.m_e).SelectedValue.ToString() != "0");
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 86;
				case 36:
					return;
				case 59:
					text = "9";
					num3 = 0;
					num = 25;
					continue;
				case 58:
					MessageBox.Show("در تاریخ های مشخص شده متولدی وجود ندارد");
					num = 6;
					continue;
				case 6:
					return;
				case 47:
					if (!flag)
					{
						num = 60;
						continue;
					}
					flag = num10 >= 1399;
					num = 85;
					continue;
				case 34:
					num = 11;
					continue;
				case 11:
					num9 = ((!(((Control)bb).Text != "")) ? 1 : 0);
					goto IL_0b29;
				case 103:
					num9 = 1;
					goto IL_0b29;
				case 88:
					text2 += ",";
					num = 8;
					continue;
				case 90:
					if (flag)
					{
						flag = this.m_j.SelectedIndex < 0;
						num = 5;
					}
					else
					{
						num = 59;
					}
					continue;
				case 26:
					flag = !(bx == "6");
					num = 98;
					continue;
				case 98:
					if (flag)
					{
						flag = !ao.Checked;
						num = 90;
					}
					else
					{
						num = 44;
					}
					continue;
				case 71:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 78;
					continue;
				case 78:
					return;
				case 43:
					MessageBox.Show("عکس صفحه دوم را انتخاب کنید");
					num = 32;
					continue;
				case 32:
					return;
				case 23:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 22;
				case 96:
					text = "1";
					text2 = this.m_j.SelectedValue.ToString();
					num = 66;
					continue;
				case 22:
					text2 += at.GetRow(num3).Cells["id"].Value.ToString();
					num3++;
					num = 39;
					continue;
				case 42:
					num = (flag ? 73 : 101);
					continue;
				case 75:
					num = ((!flag) ? 54 : 112);
					continue;
				case 72:
					if (!flag)
					{
						num = 88;
						continue;
					}
					goto case 8;
				case 29:
					text3 = "sp_SelectStdForSarbarg_Type2";
					num = 55;
					continue;
				case 85:
					if (flag)
					{
						DateTime the_date = bw.the_date;
						DateTime the_date2 = bt.the_date;
						the_date = the_date.AddMonths(1);
						flag = !(the_date2 > the_date);
						num = 109;
					}
					else
					{
						num = 97;
					}
					continue;
				case 73:
					num = ((((Control)bc).Text == "") ? 34 : 103);
					continue;
				case 52:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 64;
				case 8:
					text2 += bs.GetRow(num3).Cells["id"].Value.ToString();
					num3++;
					num = 27;
					continue;
				case 74:
					num5 = 1;
					goto IL_107d;
				case 55:
				{
					SqlConnection val = new SqlConnection(asdab.e());
					((DbConnection)(object)val).Open();
					dataSet = new DataSet();
					SqlCommand val2 = new SqlCommand(text3, val);
					((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
					val2.Parameters.AddWithValue("@type", (object)text);
					val2.Parameters.AddWithValue("@code", (object)text2);
					val2.Parameters.AddWithValue("@sort", (object)this.m_o.SelectedValue.ToString());
					val2.Parameters.AddWithValue("@xBook", (object)this.m_h.SelectedValue.ToString());
					val2.Parameters.AddWithValue("@DateExam", (object)ShamsiDate.GetShamsiDate(this.m_t.the_date));
					val2.Parameters.AddWithValue("@TimeExam", (object)((Control)this.m_v).Text);
					val2.Parameters.AddWithValue("@CountPageExam", (object)((Control)this.m_w).Text);
					val2.Parameters.AddWithValue("@CountQusExam", (object)((Control)am).Text);
					val2.Parameters.AddWithValue("@StartExam", (object)((Control)a8).Text);
					val2.Parameters.AddWithValue("@xYear", (object)asdaj.a);
					val2.Parameters.AddWithValue("@formType", (object)bx);
					SqlDataAdapter val3 = new SqlDataAdapter(val2);
					((DbDataAdapter)(object)val3).Fill(dataSet, "v_data");
					((DbConnection)(object)val).Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 9;
					continue;
				}
				case 9:
					if (flag)
					{
						l();
						asdbp asdbp2 = new asdbp();
						asdbp2.a(dataSet, dataSet.Tables[0].TableName, ((Control)this.m_y).Text, ((Control)bj).Text, ((Control)bh).Text, ((Control)bd).Text, ((Control)bc).Text, ((Control)bb).Text);
						((Form)asdbp2).ShowDialog();
						((Component)(object)asdbp2).Dispose();
						num = 36;
					}
					else
					{
						num = 71;
					}
					continue;
				case 21:
					num = ((((Control)bj).Text == "") ? 1 : 24);
					continue;
				case 89:
					num6 = 1;
					goto IL_0aff;
				case 79:
					if (!flag)
					{
						num = 29;
						continue;
					}
					goto case 55;
				case 66:
					flag = this.m_l.SelectedIndex < 0;
					num = 14;
					continue;
				case 14:
					if (flag)
					{
						MessageBox.Show("صنفی ای انتخاب نشده است");
						num = 107;
					}
					else
					{
						num = 31;
					}
					continue;
				case 61:
					num = 48;
					continue;
				case 48:
					num5 = ((!(((Control)bd).Text != "")) ? 1 : 0);
					goto IL_107d;
				case 24:
					num4 = 1;
					goto IL_071c;
				case 60:
					MessageBox.Show("تاریخ انتخابی دوم نباید کمتر از اولی باشد");
					num = 104;
					continue;
				case 104:
					return;
				case 57:
					MessageBox.Show("دانش آموزی به لیست چاپ اضافه نشده است");
					num = 30;
					continue;
				case 30:
					return;
				case 50:
					num = ((((Control)bh).Text == "") ? 61 : 74);
					continue;
				case 86:
					num = 18;
					continue;
				case 70:
					return;
				case 54:
					MessageBox.Show("عکس صفحه پنجم را انتخاب کنید");
					num = 69;
					continue;
				case 69:
					return;
				case 68:
					return;
				case 111:
					num = 38;
					continue;
				case 44:
					text = "9";
					num3 = 0;
					num = 37;
					continue;
				case 13:
					num = ((!flag) ? 53 : 28);
					continue;
				case 83:
					flag = !(text2 == "0");
					num = 77;
					continue;
				case 77:
					num = ((!flag) ? 57 : 95);
					continue;
				case 64:
					text3 = "sp_SelectStdForSarbarg_Type1";
					num = 99;
					continue;
				case 99:
					{
						num = ((bx != "1") ? 3 : 7);
						continue;
					}
					IL_0c18:
					flag = (byte)num2 != 0;
					num = 52;
					continue;
					IL_071c:
					flag = (byte)num4 != 0;
					num = 63;
					continue;
					IL_107d:
					flag = (byte)num5 != 0;
					num = 13;
					continue;
					IL_06de:
					flag = (byte)num7 != 0;
					num = 67;
					continue;
					IL_0b29:
					flag = (byte)num9 != 0;
					num = 75;
					continue;
					IL_0eae:
					flag = (byte)num8 != 0;
					num = 79;
					continue;
					IL_0aff:
					flag = (byte)num6 != 0;
					num = 42;
					continue;
				}
				break;
			}
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_aa).ShowDialog() != 1;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					((Control)this.m_y).Text = ((FileDialog)this.m_aa).FileName;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num = ((this.m_n.RowCount <= 0) ? 12 : 0);
					continue;
				case 9:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 2;
				case 10:
					MessageBox.Show("گزارش انتخاب شده از گزارش های پیش فرض برنامه است و قابل حذف نیست");
					num = 1;
					continue;
				case 1:
					return;
				case 12:
					num2 = 1;
					goto IL_01e7;
				case 2:
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					num = 4;
					continue;
				case 4:
					num2 = (((int)this.m_n.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_01e7;
				case 6:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tRptDynamic where id=" + this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					i();
					num = 2;
					continue;
				case 8:
					flag = !(this.m_n.SelectedItems[0].GetRow().Cells["sys"].Value.ToString() == "True");
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						flag = (int)MessageBox.Show("آیا از حذف گزارش انتخاب شده اطمینان دارید؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 9;
					}
					else
					{
						num = 10;
					}
					continue;
				case 11:
					{
						if (!flag)
						{
							num = 8;
							continue;
						}
						return;
					}
					IL_01e7:
					flag = (byte)num2 != 0;
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)this.m_b).Enabled = false;
		((Control)this.m_ad).Visible = true;
		((Control)ah).Text = "";
		((Control)ah).Focus();
	}

	private void z(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)this.m_b).Enabled = true;
		((Control)this.m_ad).Visible = false;
	}

	private void y(object A_0, EventArgs A_1)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)ah).Text.Trim() == "");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 0;
						continue;
					}
					SqlParameter[] a_ = new SqlParameter[2]
					{
						asdcb.a("@id", SqlDbType.Int, this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString()),
						asdcb.a("@Caption", SqlDbType.NVarChar, ((Control)ah).Text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "declare @idAdd int\r\n                        select @idAdd=isnull (max(id)+1,1001) from tRptDynamic where id>100\r\n                        INSERT INTO tRptDynamic\r\n                             (id,Caption, Rpt, type, sys)\r\n                            select @idAdd ,@Caption,Rpt,type,0 from tRptDynamic where id=@id", a_);
					i();
					((Control)this.m_b).Enabled = true;
					((Control)this.m_ad).Visible = false;
					num = 3;
					continue;
				}
				case 0:
					MessageBox.Show("عنوان الگو جدید را وارد کنید");
					((Control)ah).Focus();
					num = 1;
					continue;
				case 1:
				case 3:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		string text = default;
		string text2 = default;
		SqlConnection val = default;
		DataSet dataSet = default;
		string text3 = default;
		while (true)
		{
			bool flag = !(this.m_n.SelectedItems[0].GetRow().Cells["sys"].Value.ToString() == "True");
			int num = 17;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 15;
						continue;
					}
					text = "0";
					text2 = "0";
					flag = this.m_j.SelectedIndex < 0;
					num = 22;
					continue;
				case 25:
					num2 = 1;
					goto IL_058c;
				case 13:
					num = 9;
					continue;
				case 9:
					if (true)
					{
					}
					val = new SqlConnection(asdab.e());
					((DbConnection)(object)val).Open();
					dataSet = new DataSet();
					text3 = "sp_SelectStdForSarbarg_Test_Type1";
					num = 24;
					continue;
				case 8:
					return;
				case 27:
					text3 = "sp_SelectStdForSarbarg_Test_Type2";
					num = 19;
					continue;
				case 11:
					text = "1";
					text2 = this.m_j.SelectedValue.ToString();
					num = 10;
					continue;
				case 21:
					num = 3;
					continue;
				case 3:
					num2 = ((!(bx != "5")) ? 1 : 0);
					goto IL_058c;
				case 4:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 18;
					continue;
				case 18:
					return;
				case 2:
					num = 13;
					continue;
				case 10:
					flag = this.m_l.SelectedIndex < 0;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 23;
						continue;
					}
					MessageBox.Show("صنفی ای انتخاب نشده است");
					num = 16;
					continue;
				case 19:
				{
					SqlCommand val2 = new SqlCommand(text3, val);
					((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
					val2.Parameters.AddWithValue("@type", (object)text);
					val2.Parameters.AddWithValue("@code", (object)text2);
					val2.Parameters.AddWithValue("@sort", (object)this.m_o.SelectedValue.ToString());
					val2.Parameters.AddWithValue("@xBook", (object)this.m_h.SelectedValue.ToString());
					val2.Parameters.AddWithValue("@DateExam", (object)ShamsiDate.GetShamsiDate(this.m_t.the_date));
					val2.Parameters.AddWithValue("@TimeExam", (object)((Control)this.m_v).Text);
					val2.Parameters.AddWithValue("@CountPageExam", (object)((Control)this.m_w).Text);
					val2.Parameters.AddWithValue("@CountQusExam", (object)((Control)am).Text);
					val2.Parameters.AddWithValue("@StartExam", (object)((Control)a8).Text);
					val2.Parameters.AddWithValue("@xYear", (object)asdaj.a);
					val2.Parameters.AddWithValue("@formType", (object)bx);
					SqlDataAdapter val3 = new SqlDataAdapter(val2);
					((DbDataAdapter)(object)val3).Fill(dataSet, "v_data");
					((DbConnection)(object)val).Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 20;
					continue;
				}
				case 20:
				{
					if (!flag)
					{
						num = 4;
						continue;
					}
					l();
					asdk asdk2 = new asdk();
					asdk2.r = bx;
					asdk2.a(dataSet, dataSet.Tables[0].TableName, ((Control)this.m_y).Text, ((Control)bj).Text, ((Control)bh).Text, ((Control)bd).Text, ((Control)bc).Text, ((Control)bb).Text);
					asdk2.q = this.m_n.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					((Control)asdk2).Text = this.m_n.SelectedItems[0].GetRow().Cells["Caption"].Value.ToString();
					((Form)asdk2).ShowDialog();
					num = 5;
					continue;
				}
				case 5:
					return;
				case 6:
					num = 2;
					continue;
				case 15:
					MessageBox.Show("گزارش انتخاب شده از گزارش های پیش فرض برنامه است و قابل اصلاح نیست\nبرای اصلاح میتوانید با استفاده از دکمه تهیه گزارش جدید یک کپی از این گزارش ایجاد و آن را اصلاح کنید ");
					num = 26;
					continue;
				case 26:
					return;
				case 23:
					flag = !(this.m_l.SelectedValue.ToString() != "0");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 13;
				case 22:
					if (flag)
					{
						MessageBox.Show("پایه ای انتخاب نشده است");
						num = 8;
					}
					else
					{
						num = 11;
					}
					continue;
				case 14:
					return;
				case 7:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 19;
				case 24:
					num = ((bx != "1") ? 21 : 25);
					continue;
				case 1:
					text = "2";
					text2 = this.m_l.SelectedValue.ToString();
					flag = ((ListControl)this.m_e).SelectedIndex < 0;
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						MessageBox.Show("دانش آموزی انتخاب نشده است");
						num = 14;
					}
					else
					{
						num = 6;
					}
					continue;
				case 16:
					return;
					IL_058c:
					flag = (byte)num2 != 0;
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void v(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !ap.Checked;
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
					((Control)this.m_c).Visible = true;
					((Control)aq).Visible = false;
					((Control)this.m_ad).Visible = false;
					((Control)aw).Visible = false;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !ao.Checked;
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
					((Control)this.m_c).Visible = false;
					((Control)aq).Visible = true;
					((Control)this.m_ad).Visible = false;
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

	private void t(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)aw).Visible = true;
		((Control)this.m_ad).Visible = false;
	}

	private void b()
	{
		while (true)
		{
			string text = " tYear_Student.status=1 and tYear_Student.xYear=" + asdaj.a;
			bool flag = a3.SelectedIndex <= 0;
			int num = 10;
			while (true)
			{
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 2;
				case 3:
					text += " and ";
					num = 16;
					continue;
				case 5:
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)a1).Text) + "%'";
					num = 26;
					continue;
				case 2:
					flag = a5.SelectedIndex <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 23;
				case 29:
					flag = !(text != "");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 20;
				case 25:
					text = text + " tYear_Student.xClass=" + a3.SelectedValue.ToString();
					num = 2;
					continue;
				case 0:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 16;
				case 20:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code,  tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Sh_Sh, \r\n                   tStudent.MobileMother,tStudent.MobileFather,   tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent  INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text + " order by tStudent.lname,tStudent.fname");
					az.DataSource = dataSource;
					flag = az.RowCount <= 0;
					num = 28;
					continue;
				}
				case 28:
					if (!flag)
					{
						num = 18;
						continue;
					}
					return;
				case 4:
					text += " and ";
					num = 5;
					continue;
				case 21:
					flag = !(text != "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 13;
				case 24:
					text = " where " + text;
					num = 20;
					continue;
				case 18:
					az.Row = 0;
					num = 6;
					continue;
				case 6:
					return;
				case 13:
					text = text + " tYear_Student.xPaye=" + a5.SelectedValue.ToString();
					num = 23;
					continue;
				case 22:
					flag = !(text != "");
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 25;
				case 14:
					text += " and ";
					num = 13;
					continue;
				case 15:
					text += " and ";
					num = 25;
					continue;
				case 23:
					if (true)
					{
					}
					flag = !(((Control)a1).Text.Trim() != "");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 26;
				case 16:
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)a0).Text) + "%'";
					num = 29;
					continue;
				case 26:
					flag = !(((Control)a0).Text.Trim() != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 29;
				case 7:
					flag = !(text != "");
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code,  tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName+ ' '+ tStudent.LName as fullname, tStudent.PName, tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent  inner join tYear_Student on tStudent.id=tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id  INNER JOIN tmpStdforPrintSarbarg on  tStudent.id=tmpStdforPrintSarbarg.id where tYear_Student.xYear=" + asdaj.a + " and tmpStdforPrintSarbarg.xUser=" + asdaj.l);
		at.DataSource = dataSource;
	}

	private void s(object A_0, EventArgs A_1)
	{
		f();
		b();
	}

	private void r(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		b();
	}

	private void q(object A_0, EventArgs A_1)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		string text2 = default;
		int num2 = default;
		while (true)
		{
			bool flag = az.RowCount != 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 6;
						continue;
					}
					text2 = az.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num2 = 0;
					num = 0;
					continue;
				case 2:
					MessageBox.Show("این دانش آموز قبلا به لیست پرینت اضافه شده است");
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tmpStdforPrintSarbarg (id,xuser) VALUES     (" + text2 + "," + asdaj.l + ")");
					a();
					((Control)a0).Focus();
					num = 9;
					continue;
				case 9:
					return;
				case 6:
					MessageBox.Show("موردی جهت اضافه شدن وجود ندارد");
					((Control)a0).Focus();
					num = 5;
					continue;
				case 5:
					return;
				case 0:
				case 10:
					flag = num2 < at.RowCount;
					num = 7;
					continue;
				case 7:
				{
					if (!flag)
					{
						num = 3;
						continue;
					}
					string text = at.GetRow(num2).Cells["id"].Value.ToString();
					flag = !(text == text2);
					if (true)
					{
					}
					num = 4;
					continue;
				}
				case 4:
					if (flag)
					{
						num2++;
						num = 10;
					}
					else
					{
						num = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
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
					if (true)
					{
					}
					num = ((at.RowCount <= 0) ? 6 : 3);
					continue;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = (((int)at.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_00ee;
				case 4:
				{
					string text = at.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrintSarbarg where id=" + text);
					a();
					((Control)a0).Focus();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 6:
					{
						num2 = 1;
						goto IL_00ee;
					}
					IL_00ee:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = at.RowCount <= 0;
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
					if (true)
					{
					}
					asdcb.d(asdab.e(), CommandType.Text, "delete from tmpStdforPrintSarbarg where xUser=" + asdaj.l);
					a();
					((Control)a0).Focus();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		((Control)aw).Visible = false;
	}

	private void m(object A_0, EventArgs A_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_aa).ShowDialog() != 1;
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
					((Control)bj).Text = ((FileDialog)this.m_aa).FileName;
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

	private void l(object A_0, EventArgs A_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)((CommonDialog)this.m_aa).ShowDialog() != 1;
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
					((Control)bh).Text = ((FileDialog)this.m_aa).FileName;
					num = 2;
					continue;
				case 2:
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
			bool flag = (int)((CommonDialog)this.m_aa).ShowDialog() != 1;
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
					((Control)bd).Text = ((FileDialog)this.m_aa).FileName;
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
			bool flag = (int)((CommonDialog)this.m_aa).ShowDialog() != 1;
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
					((Control)bc).Text = ((FileDialog)this.m_aa).FileName;
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)((CommonDialog)this.m_aa).ShowDialog() != 1;
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
					((Control)bb).Text = ((FileDialog)this.m_aa).FileName;
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
		((Control)this.m_y).Text = "";
	}

	private void g(object A_0, EventArgs A_1)
	{
		((Control)bj).Text = "";
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Control)bh).Text = "";
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Control)bd).Text = "";
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Control)bc).Text = "";
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)bb).Text = "";
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = int.Parse(ShamsiDate.GetShamsiDate(bw.the_date).Substring(0, 4)) >= 1399;
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
					j();
					num = 2;
					continue;
				case 0:
					if (true)
					{
					}
					MessageBox.Show("تاریخ انتخابی اشتباه است");
					bs.DataSource = null;
					num = 3;
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			DateTime the_date = bw.the_date;
			DateTime the_date2 = bt.the_date;
			the_date = the_date.AddMonths(1);
			bool flag = !(the_date2 > the_date);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto case 2;
				case 1:
					MessageBox.Show("اختلاف دو تاریخ نباید بیشتر از یک ماه باشد");
					num = 2;
					continue;
				case 2:
					j();
					return;
				}
				break;
			}
		}
	}
}
