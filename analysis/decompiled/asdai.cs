using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using school_Af.Properties;

public class asdai : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private UIComboBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private Label m_i;

	private Label m_j;

	private EditBox m_k;

	private EditBox m_l;

	private UIButton m_m;

	private OpenFileDialog m_n;

	private UIComboBox m_o;

	private Label m_p;

	private Label q;

	private UIComboBox r;

	private Panel s;

	private UIButton t;

	private Label u;

	private MaskedEditBox v;

	private Label w;

	private MaskedEditBox x;

	private UIComboBox y;

	private Label z;

	private UIComboBox aa;

	private Label ab;

	private Label ac;

	private UIComboBox ad;

	private Label ae;

	private UIComboBox af;

	private UIComboBox ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private Label al;

	private UIComboBox am;

	private UIComboBox an;

	private UIComboBox ao;

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private UIComboBox at;

	private UIComboBox au;

	private UIComboBox av;

	private UIComboBox aw;

	private UIComboBox ax;

	private UIButton ay;

	private ProgressBar az;

	private UIButton a0;

	private SaveFileDialog a1;

	private EditBox a2;

	private Label a3;

	private Label a4;

	private EditBox a5;

	private UIGroupBox a6;

	private UIComboBox a7;

	private Label a8;

	private UIComboBox a9;

	private Label ba;

	private Label bb;

	private EditBox bc;

	private UIComboBox bd;

	private Label be;

	private UIButton bf;

	private Panel bg;

	private Label bh;

	private Timer bi;

	private bool bj = false;

	private int bk = 0;

	private int bl = 0;

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
						num = 2;
					}
					else
					{
						num = 1;
					}
					continue;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
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
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void j()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected Obj, but got Unknown
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected Obj, but got Unknown
		//IL_108d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Expected Obj, but got Unknown
		//IL_1114: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e: Expected Obj, but got Unknown
		//IL_1285: Unknown result type (might be due to invalid IL or missing references)
		//IL_128f: Expected Obj, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected Obj, but got Unknown
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f4: Expected Obj, but got Unknown
		//IL_1579: Unknown result type (might be due to invalid IL or missing references)
		//IL_1583: Expected Obj, but got Unknown
		//IL_16c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d3: Expected Obj, but got Unknown
		//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c3: Expected Obj, but got Unknown
		//IL_1983: Unknown result type (might be due to invalid IL or missing references)
		//IL_198d: Expected Obj, but got Unknown
		//IL_1af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aff: Expected Obj, but got Unknown
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6e: Expected Obj, but got Unknown
		//IL_1dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de1: Expected Obj, but got Unknown
		//IL_1f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5b: Expected Obj, but got Unknown
		//IL_1fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fea: Expected Obj, but got Unknown
		//IL_213f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2149: Expected Obj, but got Unknown
		//IL_2318: Unknown result type (might be due to invalid IL or missing references)
		//IL_2322: Expected Obj, but got Unknown
		//IL_2487: Unknown result type (might be due to invalid IL or missing references)
		//IL_2491: Expected Obj, but got Unknown
		//IL_25f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2600: Expected Obj, but got Unknown
		//IL_2847: Unknown result type (might be due to invalid IL or missing references)
		//IL_2851: Expected Obj, but got Unknown
		//IL_293f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2949: Expected Obj, but got Unknown
		//IL_2b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b29: Expected Obj, but got Unknown
		//IL_2db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc1: Expected Obj, but got Unknown
		//IL_3168: Unknown result type (might be due to invalid IL or missing references)
		//IL_3172: Expected Obj, but got Unknown
		//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3308: Expected Obj, but got Unknown
		//IL_3575: Unknown result type (might be due to invalid IL or missing references)
		//IL_357f: Expected Obj, but got Unknown
		//IL_374b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3755: Expected Obj, but got Unknown
		//IL_392f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3939: Expected Obj, but got Unknown
		//IL_3b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b24: Expected Obj, but got Unknown
		//IL_3c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c16: Expected Obj, but got Unknown
		//IL_3d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d4b: Expected Obj, but got Unknown
		//IL_3e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea5: Expected Obj, but got Unknown
		if (true)
		{
		}
		this.m_a = new Container();
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdai));
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		StringFormat val5 = new StringFormat();
		StringFormat val6 = new StringFormat();
		StringFormat val7 = new StringFormat();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		UIComboBoxItem val10 = new UIComboBoxItem();
		StringFormat val11 = new StringFormat();
		UIComboBoxItem val12 = new UIComboBoxItem();
		UIComboBoxItem val13 = new UIComboBoxItem();
		UIComboBoxItem val14 = new UIComboBoxItem();
		StringFormat val15 = new StringFormat();
		UIComboBoxItem val16 = new UIComboBoxItem();
		UIComboBoxItem val17 = new UIComboBoxItem();
		UIComboBoxItem val18 = new UIComboBoxItem();
		StringFormat val19 = new StringFormat();
		UIComboBoxItem val20 = new UIComboBoxItem();
		UIComboBoxItem val21 = new UIComboBoxItem();
		UIComboBoxItem val22 = new UIComboBoxItem();
		StringFormat val23 = new StringFormat();
		UIComboBoxItem val24 = new UIComboBoxItem();
		UIComboBoxItem val25 = new UIComboBoxItem();
		UIComboBoxItem val26 = new UIComboBoxItem();
		StringFormat val27 = new StringFormat();
		UIComboBoxItem val28 = new UIComboBoxItem();
		UIComboBoxItem val29 = new UIComboBoxItem();
		UIComboBoxItem val30 = new UIComboBoxItem();
		StringFormat val31 = new StringFormat();
		UIComboBoxItem val32 = new UIComboBoxItem();
		UIComboBoxItem val33 = new UIComboBoxItem();
		UIComboBoxItem val34 = new UIComboBoxItem();
		StringFormat val35 = new StringFormat();
		UIComboBoxItem val36 = new UIComboBoxItem();
		UIComboBoxItem val37 = new UIComboBoxItem();
		UIComboBoxItem val38 = new UIComboBoxItem();
		StringFormat val39 = new StringFormat();
		UIComboBoxItem val40 = new UIComboBoxItem();
		UIComboBoxItem val41 = new UIComboBoxItem();
		UIComboBoxItem val42 = new UIComboBoxItem();
		StringFormat val43 = new StringFormat();
		UIComboBoxItem val44 = new UIComboBoxItem();
		UIComboBoxItem val45 = new UIComboBoxItem();
		UIComboBoxItem val46 = new UIComboBoxItem();
		StringFormat val47 = new StringFormat();
		StringFormat val48 = new StringFormat();
		StringFormat val49 = new StringFormat();
		UIComboBoxItem val50 = new UIComboBoxItem();
		UIComboBoxItem val51 = new UIComboBoxItem();
		UIComboBoxItem val52 = new UIComboBoxItem();
		StringFormat val53 = new StringFormat();
		UIComboBoxItem val54 = new UIComboBoxItem();
		UIComboBoxItem val55 = new UIComboBoxItem();
		UIComboBoxItem val56 = new UIComboBoxItem();
		UIComboBoxItem val57 = new UIComboBoxItem();
		UIComboBoxItem val58 = new UIComboBoxItem();
		StringFormat val59 = new StringFormat();
		UIComboBoxItem val60 = new UIComboBoxItem();
		UIComboBoxItem val61 = new UIComboBoxItem();
		UIComboBoxItem val62 = new UIComboBoxItem();
		StringFormat val63 = new StringFormat();
		StringFormat val64 = new StringFormat();
		StringFormat val65 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		bg = new Panel();
		bh = new Label();
		bf = new UIButton();
		az = new ProgressBar();
		a0 = new UIButton();
		ay = new UIButton();
		t = new UIButton();
		this.m_d = new UIGroupBox();
		bd = new UIComboBox();
		be = new Label();
		a6 = new UIGroupBox();
		bc = new EditBox();
		ba = new Label();
		bb = new Label();
		a9 = new UIComboBox();
		a7 = new UIComboBox();
		a8 = new Label();
		a4 = new Label();
		a5 = new EditBox();
		aw = new UIComboBox();
		ax = new UIComboBox();
		au = new UIComboBox();
		av = new UIComboBox();
		ap = new Label();
		aq = new Label();
		ar = new Label();
		@as = new Label();
		at = new UIComboBox();
		al = new Label();
		am = new UIComboBox();
		an = new UIComboBox();
		ao = new UIComboBox();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		ag = new UIComboBox();
		ae = new Label();
		af = new UIComboBox();
		ac = new Label();
		ad = new UIComboBox();
		aa = new UIComboBox();
		ab = new Label();
		y = new UIComboBox();
		z = new Label();
		u = new Label();
		v = new MaskedEditBox();
		w = new Label();
		x = new MaskedEditBox();
		a2 = new EditBox();
		a3 = new Label();
		q = new Label();
		r = new UIComboBox();
		this.m_o = new UIComboBox();
		this.m_p = new Label();
		this.m_m = new UIButton();
		this.m_i = new Label();
		this.m_j = new Label();
		this.m_k = new EditBox();
		this.m_l = new EditBox();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		this.m_e = new Label();
		this.m_f = new UIComboBox();
		this.m_n = new OpenFileDialog();
		s = new Panel();
		a1 = new SaveFileDialog();
		bi = new Timer(this.m_a);
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)bg).SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)a6).BeginInit();
		((Control)a6).SuspendLayout();
		((Control)s).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		this.m_b.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("Tahoma", 9.75f);
		this.m_b.GroupByBoxFormatStyle.TextAlignment = (TextAlignment)2;
		((Control)this.m_b).Location = new Point(8, 259);
		((Control)this.m_b).Name = "gridEX1";
		((ScrollableBase)this.m_b).RecordNavigator = true;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(776, 329);
		((Control)this.m_b).TabIndex = 5;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		this.m_b.SelectionChanged += k;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)bg);
		((Control)this.m_c).Controls.Add((Control)(object)bf);
		((Control)this.m_c).Controls.Add((Control)(object)az);
		((Control)this.m_c).Controls.Add((Control)(object)a0);
		((Control)this.m_c).Controls.Add((Control)(object)ay);
		((Control)this.m_c).Controls.Add((Control)(object)t);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_c).Location = new Point(3, 3);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(794, 669);
		((Control)this.m_c).TabIndex = 0;
		((Control)bg).Controls.Add((Control)(object)bh);
		((Control)bg).Location = new Point(261, 352);
		((Control)bg).Name = "plode";
		((Control)bg).Size = new Size(305, 100);
		((Control)bg).TabIndex = 163;
		((Control)bh).Anchor = (AnchorStyles)9;
		((Control)bh).AutoSize = true;
		((Control)bh).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((Control)bh).Location = new Point(62, 45);
		((Control)bh).Name = "label23";
		((Control)bh).Size = new Size(189, 13);
		((Control)bh).TabIndex = 30;
		((Control)bh).Text = "در حال بارگزاری لطفا کمی صبر کنید";
		((Control)bf).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		bf.Image = (Image)(object)Resources.rptview;
		((Control)bf).Location = new Point(471, 607);
		((Control)bf).Name = "btnComment";
		((Control)bf).Size = new Size(142, 45);
		((Control)bf).TabIndex = 63;
		((Control)bf).Text = "یادداشت";
		((Control)bf).Click += d;
		((Control)az).Location = new Point(189, 594);
		((Control)az).Name = "pr12";
		((Control)az).Size = new Size(167, 20);
		((Control)az).TabIndex = 62;
		((Control)az).Visible = false;
		((Control)a0).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		a0.ImageSize = new Size(30, 30);
		((Control)a0).Location = new Point(189, 618);
		((Control)a0).Name = "btnXls";
		((Control)a0).Size = new Size(167, 34);
		((Control)a0).TabIndex = 61;
		((Control)a0).Text = "دریافت فایل اکسل";
		((Control)a0).Click += g;
		((Control)ay).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		ay.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)ay).Location = new Point(628, 607);
		((Control)ay).Name = "btnEdit";
		((Control)ay).Size = new Size(153, 45);
		((Control)ay).TabIndex = 18;
		((Control)ay).Text = "اصلاح مورد انتخابی";
		((Control)ay).Click += h;
		((Control)t).Anchor = (AnchorStyles)9;
		((Control)t).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		t.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		t.ImageSize = new Size(20, 20);
		((Control)t).Location = new Point(8, 607);
		((Control)t).Name = "btnClose";
		((Control)t).Size = new Size(149, 45);
		((Control)t).TabIndex = 3;
		((Control)t).Text = "بستن";
		((Control)t).Click += o;
		((Control)this.m_d).Anchor = (AnchorStyles)13;
		((Control)this.m_d).Controls.Add((Control)(object)bd);
		((Control)this.m_d).Controls.Add((Control)(object)be);
		((Control)this.m_d).Controls.Add((Control)(object)a6);
		((Control)this.m_d).Controls.Add((Control)(object)a4);
		((Control)this.m_d).Controls.Add((Control)(object)a5);
		((Control)this.m_d).Controls.Add((Control)(object)aw);
		((Control)this.m_d).Controls.Add((Control)(object)ax);
		((Control)this.m_d).Controls.Add((Control)(object)au);
		((Control)this.m_d).Controls.Add((Control)(object)av);
		((Control)this.m_d).Controls.Add((Control)(object)ap);
		((Control)this.m_d).Controls.Add((Control)(object)aq);
		((Control)this.m_d).Controls.Add((Control)(object)ar);
		((Control)this.m_d).Controls.Add((Control)(object)@as);
		((Control)this.m_d).Controls.Add((Control)(object)at);
		((Control)this.m_d).Controls.Add((Control)(object)al);
		((Control)this.m_d).Controls.Add((Control)(object)am);
		((Control)this.m_d).Controls.Add((Control)(object)an);
		((Control)this.m_d).Controls.Add((Control)(object)ao);
		((Control)this.m_d).Controls.Add((Control)(object)ah);
		((Control)this.m_d).Controls.Add((Control)(object)ai);
		((Control)this.m_d).Controls.Add((Control)(object)aj);
		((Control)this.m_d).Controls.Add((Control)(object)ak);
		((Control)this.m_d).Controls.Add((Control)(object)ag);
		((Control)this.m_d).Controls.Add((Control)(object)ae);
		((Control)this.m_d).Controls.Add((Control)(object)af);
		((Control)this.m_d).Controls.Add((Control)(object)ac);
		((Control)this.m_d).Controls.Add((Control)(object)ad);
		((Control)this.m_d).Controls.Add((Control)(object)aa);
		((Control)this.m_d).Controls.Add((Control)(object)ab);
		((Control)this.m_d).Controls.Add((Control)(object)y);
		((Control)this.m_d).Controls.Add((Control)(object)z);
		((Control)this.m_d).Controls.Add((Control)(object)u);
		((Control)this.m_d).Controls.Add((Control)(object)v);
		((Control)this.m_d).Controls.Add((Control)(object)w);
		((Control)this.m_d).Controls.Add((Control)(object)x);
		((Control)this.m_d).Controls.Add((Control)(object)a2);
		((Control)this.m_d).Controls.Add((Control)(object)a3);
		((Control)this.m_d).Controls.Add((Control)(object)q);
		((Control)this.m_d).Controls.Add((Control)(object)r);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_p);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(11, -1);
		((Control)this.m_d).Name = "uiGroupBox1";
		((Control)this.m_d).Size = new Size(770, 254);
		((Control)this.m_d).TabIndex = 17;
		((Control)this.m_d).Text = "جستجو";
		((UIComboBase)bd).ComboStyle = (ComboStyle)1;
		((UIComboBase)bd).DropListFont = new Font("B Nazanin", 12f);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "-";
		val2.Value = "-1";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "بله";
		val3.Value = "1";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "خیر";
		val4.Value = "0";
		bd.Items.AddRange(new UIComboBoxItem[3] { val2, val3, val4 });
		((Control)bd).Location = new Point(5, 164);
		((Control)bd).Name = "checkMarkTerm3_From100";
		((Control)bd).Size = new Size(74, 22);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)bd).StringFormat = val5;
		((Control)bd).TabIndex = 162;
		bd.SelectedIndexChanged += i;
		((Control)be).AutoSize = true;
		((Control)be).Font = new Font("Tahoma", 6f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)be).Location = new Point(83, 169);
		((Control)be).Name = "label22";
		((Control)be).Size = new Size(73, 10);
		((Control)be).TabIndex = 161;
		((Control)be).Text = "نمره سالانه از 100";
		((Control)a6).Anchor = (AnchorStyles)13;
		((Control)a6).Controls.Add((Control)(object)bc);
		((Control)a6).Controls.Add((Control)(object)ba);
		((Control)a6).Controls.Add((Control)(object)bb);
		((Control)a6).Controls.Add((Control)(object)a9);
		((Control)a6).Controls.Add((Control)(object)a7);
		((Control)a6).Controls.Add((Control)(object)a8);
		((Control)a6).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a6).Location = new Point(97, 192);
		((Control)a6).Name = "groupTransport";
		((Control)a6).Size = new Size(669, 52);
		((Control)a6).TabIndex = 160;
		((Control)a6).Text = "سکونت فعلی";
		((EditBase)bc).AutoScroll = false;
		((EditBase)bc).AutoScrollMargin = new Size(0, 0);
		((EditBase)bc).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bc).AutoScrollPosition = new Point(0, 0);
		((Control)bc).Location = new Point(6, 18);
		((Control)bc).Name = "txtAdress";
		((Control)bc).Size = new Size(149, 23);
		((Control)bc).TabIndex = 138;
		((EditBase)bc).TextAlignment = (TextAlignment)1;
		((Control)bc).TextChanged += a;
		((Control)ba).AutoSize = true;
		((Control)ba).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ba).Location = new Point(161, 23);
		((Control)ba).Name = "label21";
		((Control)ba).Size = new Size(39, 13);
		((Control)ba).TabIndex = 137;
		((Control)ba).Text = "آدرس :";
		((Control)bb).AutoSize = true;
		((Control)bb).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bb).Location = new Point(409, 23);
		((Control)bb).Name = "label42";
		((Control)bb).Size = new Size(59, 13);
		((Control)bb).TabIndex = 136;
		((Control)bb).Text = "ولسوالی\u200c  :";
		((Control)a9).Location = new Point(213, 18);
		((Control)a9).Name = "dropcity";
		((Control)a9).Size = new Size(190, 23);
		val6.Alignment = (StringAlignment)0;
		val6.FormatFlags = (StringFormatFlags)20485;
		val6.HotkeyPrefix = (HotkeyPrefix)0;
		val6.LineAlignment = (StringAlignment)1;
		val6.Trimming = (StringTrimming)1;
		((UIComboBase)a9).StringFormat = val6;
		((Control)a9).TabIndex = 34;
		a9.SelectedIndexChanged += e;
		((Control)a7).Anchor = (AnchorStyles)9;
		((UIComboBase)a7).BorderStyle = (BorderStyle)2;
		((UIComboBase)a7).ComboStyle = (ComboStyle)1;
		((Control)a7).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a7).Location = new Point(486, 18);
		((Control)a7).Name = "comboOst_Cty";
		((Control)a7).RightToLeft = (RightToLeft)1;
		((Control)a7).Size = new Size(132, 24);
		val7.Alignment = (StringAlignment)0;
		val7.FormatFlags = (StringFormatFlags)20485;
		val7.HotkeyPrefix = (HotkeyPrefix)0;
		val7.LineAlignment = (StringAlignment)1;
		val7.Trimming = (StringTrimming)1;
		((UIComboBase)a7).StringFormat = val7;
		((Control)a7).TabIndex = 32;
		a7.SelectedIndexChanged += f;
		((Control)a8).Anchor = (AnchorStyles)9;
		((Control)a8).AutoSize = true;
		((Control)a8).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a8).Location = new Point(624, 23);
		((Control)a8).Name = "label18";
		((Control)a8).RightToLeft = (RightToLeft)1;
		((Control)a8).Size = new Size(39, 13);
		((Control)a8).TabIndex = 31;
		((Control)a8).Text = "ولایت :";
		a8.TextAlign = (ContentAlignment)64;
		((Control)a4).AutoSize = true;
		((Control)a4).Location = new Point(683, 51);
		((Control)a4).Name = "label45";
		((Control)a4).Size = new Size(43, 14);
		((Control)a4).TabIndex = 159;
		((Control)a4).Text = "تخلص";
		((EditBase)a5).AutoScroll = false;
		((EditBase)a5).AutoScrollMargin = new Size(0, 0);
		((EditBase)a5).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a5).AutoScrollPosition = new Point(0, 0);
		((Control)a5).Location = new Point(535, 48);
		((Control)a5).Name = "txtLastName";
		((Control)a5).Size = new Size(143, 22);
		((Control)a5).TabIndex = 158;
		((EditBase)a5).TextAlignment = (TextAlignment)1;
		((Control)a5).TextChanged += a;
		((UIComboBase)aw).ComboStyle = (ComboStyle)1;
		((UIComboBase)aw).DropListFont = new Font("B Nazanin", 12f);
		val8.FormatStyle.Alpha = 0;
		val8.Text = "-";
		val8.Value = "-1";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "بله";
		val9.Value = "1";
		val10.FormatStyle.Alpha = 0;
		val10.Text = "خیر";
		val10.Value = "0";
		aw.Items.AddRange(new UIComboBoxItem[3] { val8, val9, val10 });
		((Control)aw).Location = new Point(5, 135);
		((Control)aw).Name = "checkmali";
		((Control)aw).Size = new Size(74, 22);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)aw).StringFormat = val11;
		((Control)aw).TabIndex = 157;
		aw.SelectedIndexChanged += i;
		((UIComboBase)ax).ComboStyle = (ComboStyle)1;
		((UIComboBase)ax).DropListFont = new Font("B Nazanin", 12f);
		val12.FormatStyle.Alpha = 0;
		val12.Text = "-";
		val12.Value = "-1";
		val13.FormatStyle.Alpha = 0;
		val13.Text = "بله";
		val13.Value = "1";
		val14.FormatStyle.Alpha = 0;
		val14.Text = "خیر";
		val14.Value = "0";
		ax.Items.AddRange(new UIComboBoxItem[3] { val12, val13, val14 });
		((Control)ax).Location = new Point(5, 105);
		((Control)ax).Name = "checkhazer";
		((Control)ax).Size = new Size(74, 22);
		val15.Alignment = (StringAlignment)0;
		val15.FormatFlags = (StringFormatFlags)20485;
		val15.HotkeyPrefix = (HotkeyPrefix)0;
		val15.LineAlignment = (StringAlignment)1;
		val15.Trimming = (StringTrimming)1;
		((UIComboBase)ax).StringFormat = val15;
		((Control)ax).TabIndex = 156;
		ax.SelectedIndexChanged += i;
		((UIComboBase)au).ComboStyle = (ComboStyle)1;
		((UIComboBase)au).DropListFont = new Font("B Nazanin", 12f);
		val16.FormatStyle.Alpha = 0;
		val16.Text = "-";
		val16.Value = "-1";
		val17.FormatStyle.Alpha = 0;
		val17.Text = "بله";
		val17.Value = "1";
		val18.FormatStyle.Alpha = 0;
		val18.Text = "خیر";
		val18.Value = "0";
		au.Items.AddRange(new UIComboBoxItem[3] { val16, val17, val18 });
		((Control)au).Location = new Point(159, 41);
		((Control)au).Name = "checkshaghe";
		((Control)au).Size = new Size(74, 22);
		val19.Alignment = (StringAlignment)0;
		val19.FormatFlags = (StringFormatFlags)20485;
		val19.HotkeyPrefix = (HotkeyPrefix)0;
		val19.LineAlignment = (StringAlignment)1;
		val19.Trimming = (StringTrimming)1;
		((UIComboBase)au).StringFormat = val19;
		((Control)au).TabIndex = 155;
		au.SelectedIndexChanged += i;
		((UIComboBase)av).ComboStyle = (ComboStyle)1;
		((UIComboBase)av).DropListFont = new Font("B Nazanin", 12f);
		val20.FormatStyle.Alpha = 0;
		val20.Text = "-";
		val20.Value = "-1";
		val21.FormatStyle.Alpha = 0;
		val21.Text = "بله";
		val21.Value = "1";
		val22.FormatStyle.Alpha = 0;
		val22.Text = "خیر";
		val22.Value = "0";
		av.Items.AddRange(new UIComboBoxItem[3] { val20, val21, val22 });
		((Control)av).Location = new Point(159, 13);
		((Control)av).Name = "checkmaghnae";
		((Control)av).Size = new Size(74, 22);
		val23.Alignment = (StringAlignment)0;
		val23.FormatFlags = (StringFormatFlags)20485;
		val23.HotkeyPrefix = (HotkeyPrefix)0;
		val23.LineAlignment = (StringAlignment)1;
		val23.Trimming = (StringTrimming)1;
		((UIComboBase)av).StringFormat = val23;
		((Control)av).TabIndex = 154;
		av.SelectedIndexChanged += i;
		((Control)ap).AutoSize = true;
		((Control)ap).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ap).Location = new Point(83, 139);
		((Control)ap).Name = "label17";
		((Control)ap).Size = new Size(69, 13);
		((Control)ap).TabIndex = 152;
		((Control)ap).Text = "لیست مالی";
		((Control)aq).AutoSize = true;
		((Control)aq).Font = new Font("Tahoma", 7f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)aq).Location = new Point(83, 109);
		((Control)aq).Name = "label16";
		((Control)aq).Size = new Size(67, 12);
		((Control)aq).TabIndex = 151;
		((Control)aq).Text = "حاضردر صنف";
		((Control)ar).AutoSize = true;
		((Control)ar).Location = new Point(237, 45);
		((Control)ar).Name = "label15";
		((Control)ar).Size = new Size(35, 14);
		((Control)ar).TabIndex = 150;
		((Control)ar).Text = "شقه";
		((Control)@as).AutoSize = true;
		((Control)@as).Location = new Point(237, 17);
		((Control)@as).Name = "label14";
		((Control)@as).Size = new Size(41, 14);
		((Control)@as).TabIndex = 149;
		((Control)@as).Text = "مقنعه";
		((UIComboBase)at).ComboStyle = (ComboStyle)1;
		((UIComboBase)at).DropListFont = new Font("B Nazanin", 12f);
		val24.FormatStyle.Alpha = 0;
		val24.Text = "-";
		val24.Value = "-1";
		val25.FormatStyle.Alpha = 0;
		val25.Text = "بله";
		val25.Value = "1";
		val26.FormatStyle.Alpha = 0;
		val26.Text = "خیر";
		val26.Value = "0";
		at.Items.AddRange(new UIComboBoxItem[3] { val24, val25, val26 });
		((Control)at).Location = new Point(5, 75);
		((Control)at).Name = "checkrobotic";
		((Control)at).Size = new Size(74, 22);
		val27.Alignment = (StringAlignment)0;
		val27.FormatFlags = (StringFormatFlags)20485;
		val27.HotkeyPrefix = (HotkeyPrefix)0;
		val27.LineAlignment = (StringAlignment)1;
		val27.Trimming = (StringTrimming)1;
		((UIComboBase)at).StringFormat = val27;
		((Control)at).TabIndex = 148;
		at.SelectedIndexChanged += i;
		((Control)al).AutoSize = true;
		((Control)al).Location = new Point(83, 80);
		((Control)al).Name = "label13";
		((Control)al).Size = new Size(43, 14);
		((Control)al).TabIndex = 147;
		((Control)al).Text = "رباتیک";
		((UIComboBase)am).ComboStyle = (ComboStyle)1;
		((UIComboBase)am).DropListFont = new Font("B Nazanin", 12f);
		val28.FormatStyle.Alpha = 0;
		val28.Text = "-";
		val28.Value = "-1";
		val29.FormatStyle.Alpha = 0;
		val29.Text = "بله";
		val29.Value = "1";
		val30.FormatStyle.Alpha = 0;
		val30.Text = "خیر";
		val30.Value = "0";
		am.Items.AddRange(new UIComboBoxItem[3] { val28, val29, val30 });
		((Control)am).Location = new Point(5, 44);
		((Control)am).Name = "checktransport";
		((Control)am).Size = new Size(74, 22);
		val31.Alignment = (StringAlignment)0;
		val31.FormatFlags = (StringFormatFlags)20485;
		val31.HotkeyPrefix = (HotkeyPrefix)0;
		val31.LineAlignment = (StringAlignment)1;
		val31.Trimming = (StringTrimming)1;
		((UIComboBase)am).StringFormat = val31;
		((Control)am).TabIndex = 146;
		am.SelectedIndexChanged += i;
		((UIComboBase)an).ComboStyle = (ComboStyle)1;
		((UIComboBase)an).DropListFont = new Font("B Nazanin", 12f);
		val32.FormatStyle.Alpha = 0;
		val32.Text = "-";
		val32.Value = "-1";
		val33.FormatStyle.Alpha = 0;
		val33.Text = "بله";
		val33.Value = "1";
		val34.FormatStyle.Alpha = 0;
		val34.Text = "خیر";
		val34.Value = "0";
		an.Items.AddRange(new UIComboBoxItem[3] { val32, val33, val34 });
		((Control)an).Location = new Point(5, 13);
		((Control)an).Name = "checkketab";
		((Control)an).Size = new Size(74, 22);
		val35.Alignment = (StringAlignment)0;
		val35.FormatFlags = (StringFormatFlags)20485;
		val35.HotkeyPrefix = (HotkeyPrefix)0;
		val35.LineAlignment = (StringAlignment)1;
		val35.Trimming = (StringTrimming)1;
		((UIComboBase)an).StringFormat = val35;
		((Control)an).TabIndex = 145;
		an.SelectedIndexChanged += i;
		((UIComboBase)ao).ComboStyle = (ComboStyle)1;
		((UIComboBase)ao).DropListFont = new Font("B Nazanin", 12f);
		val36.FormatStyle.Alpha = 0;
		val36.Text = "-";
		val36.Value = "-1";
		val37.FormatStyle.Alpha = 0;
		val37.Text = "بله";
		val37.Value = "1";
		val38.FormatStyle.Alpha = 0;
		val38.Text = "خیر";
		val38.Value = "0";
		ao.Items.AddRange(new UIComboBoxItem[3] { val36, val37, val38 });
		((Control)ao).Location = new Point(159, 135);
		((Control)ao).Name = "checkkomakdarsi";
		((Control)ao).Size = new Size(74, 22);
		val39.Alignment = (StringAlignment)0;
		val39.FormatFlags = (StringFormatFlags)20485;
		val39.HotkeyPrefix = (HotkeyPrefix)0;
		val39.LineAlignment = (StringAlignment)1;
		val39.Trimming = (StringTrimming)1;
		((UIComboBase)ao).StringFormat = val39;
		((Control)ao).TabIndex = 144;
		ao.SelectedIndexChanged += i;
		((Control)ah).AutoSize = true;
		((Control)ah).Location = new Point(83, 48);
		((Control)ah).Name = "label12";
		((Control)ah).Size = new Size(68, 14);
		((Control)ah).TabIndex = 143;
		((Control)ah).Text = "ترانسپورت";
		((Control)ai).AutoSize = true;
		((Control)ai).Location = new Point(83, 17);
		((Control)ai).Name = "label11";
		((Control)ai).Size = new Size(34, 14);
		((Control)ai).TabIndex = 142;
		((Control)ai).Text = "کتاب";
		((Control)aj).AutoSize = true;
		((Control)aj).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)aj).Location = new Point(237, 139);
		((Control)aj).Name = "label10";
		((Control)aj).Size = new Size(70, 13);
		((Control)aj).TabIndex = 141;
		((Control)aj).Text = "کمک درسی";
		((Control)ak).AutoSize = true;
		((Control)ak).Location = new Point(237, 110);
		((Control)ak).Name = "label9";
		((Control)ak).Size = new Size(55, 14);
		((Control)ak).TabIndex = 140;
		((Control)ak).Text = "یونیفورم";
		((UIComboBase)ag).ComboStyle = (ComboStyle)1;
		((UIComboBase)ag).DropListFont = new Font("B Nazanin", 12f);
		val40.FormatStyle.Alpha = 0;
		val40.Text = "-";
		val40.Value = "-1";
		val41.FormatStyle.Alpha = 0;
		val41.Text = "بله";
		val41.Value = "1";
		val42.FormatStyle.Alpha = 0;
		val42.Text = "خیر";
		val42.Value = "0";
		ag.Items.AddRange(new UIComboBoxItem[3] { val40, val41, val42 });
		((Control)ag).Location = new Point(159, 106);
		((Control)ag).Name = "checkuniform";
		((Control)ag).Size = new Size(74, 22);
		val43.Alignment = (StringAlignment)0;
		val43.FormatFlags = (StringFormatFlags)20485;
		val43.HotkeyPrefix = (HotkeyPrefix)0;
		val43.LineAlignment = (StringAlignment)1;
		val43.Trimming = (StringTrimming)1;
		((UIComboBase)ag).StringFormat = val43;
		((Control)ag).TabIndex = 139;
		ag.SelectedIndexChanged += i;
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(237, 82);
		((Control)ae).Name = "label7";
		((Control)ae).Size = new Size(40, 14);
		((Control)ae).TabIndex = 138;
		((Control)ae).Text = "داخله";
		((UIComboBase)af).ComboStyle = (ComboStyle)1;
		((UIComboBase)af).DropListFont = new Font("B Nazanin", 12f);
		val44.FormatStyle.Alpha = 0;
		val44.Text = "-";
		val44.Value = "-1";
		val45.FormatStyle.Alpha = 0;
		val45.Text = "بله";
		val45.Value = "1";
		val46.FormatStyle.Alpha = 0;
		val46.Text = "خیر";
		val46.Value = "0";
		af.Items.AddRange(new UIComboBoxItem[3] { val44, val45, val46 });
		((Control)af).Location = new Point(159, 72);
		((Control)af).Name = "checkdakhle";
		((Control)af).Size = new Size(74, 22);
		val47.Alignment = (StringAlignment)0;
		val47.FormatFlags = (StringFormatFlags)20485;
		val47.HotkeyPrefix = (HotkeyPrefix)0;
		val47.LineAlignment = (StringAlignment)1;
		val47.Trimming = (StringTrimming)1;
		((UIComboBase)af).StringFormat = val47;
		((Control)af).TabIndex = 137;
		af.SelectedIndexChanged += i;
		((Control)ac).AutoSize = true;
		((Control)ac).Location = new Point(472, 22);
		((Control)ac).Name = "label41";
		((Control)ac).Size = new Size(40, 14);
		((Control)ac).TabIndex = 136;
		((Control)ac).Text = "راننده";
		((Control)ad).Anchor = (AnchorStyles)9;
		((Control)ad).Location = new Point(310, 17);
		((Control)ad).Name = "dropDriver";
		((Control)ad).Size = new Size(153, 22);
		val48.Alignment = (StringAlignment)0;
		val48.FormatFlags = (StringFormatFlags)20485;
		val48.HotkeyPrefix = (HotkeyPrefix)0;
		val48.LineAlignment = (StringAlignment)1;
		val48.Trimming = (StringTrimming)1;
		((UIComboBase)ad).StringFormat = val48;
		((Control)ad).TabIndex = 135;
		ad.SelectedIndexChanged += i;
		((Control)aa).Anchor = (AnchorStyles)9;
		((UIComboBase)aa).DropListFont = new Font("B Nazanin", 12f);
		((Control)aa).Location = new Point(159, 163);
		((Control)aa).Name = "dropTakhfif";
		((Control)aa).Size = new Size(74, 22);
		val49.Alignment = (StringAlignment)0;
		val49.FormatFlags = (StringFormatFlags)20485;
		val49.HotkeyPrefix = (HotkeyPrefix)0;
		val49.LineAlignment = (StringAlignment)1;
		val49.Trimming = (StringTrimming)1;
		((UIComboBase)aa).StringFormat = val49;
		((Control)aa).TabIndex = 125;
		aa.SelectedIndexChanged += i;
		((Control)ab).Anchor = (AnchorStyles)9;
		((Control)ab).AutoSize = true;
		((Control)ab).Location = new Point(242, 166);
		((Control)ab).Name = "label40";
		((Control)ab).Size = new Size(45, 14);
		((Control)ab).TabIndex = 126;
		((Control)ab).Text = "تخفیف";
		val50.FormatStyle.Alpha = 0;
		val50.Text = "";
		val50.Value = "-1";
		val51.FormatStyle.Alpha = 0;
		val51.Text = "شیعه";
		val51.Value = "1";
		val52.FormatStyle.Alpha = 0;
		val52.Text = "سنی";
		val52.Value = "2";
		y.Items.AddRange(new UIComboBoxItem[3] { val50, val51, val52 });
		((Control)y).Location = new Point(310, 164);
		((Control)y).Name = "dropMazhab";
		((Control)y).Size = new Size(153, 22);
		val53.Alignment = (StringAlignment)0;
		val53.FormatFlags = (StringFormatFlags)20485;
		val53.HotkeyPrefix = (HotkeyPrefix)0;
		val53.LineAlignment = (StringAlignment)1;
		val53.Trimming = (StringTrimming)1;
		((UIComboBase)y).StringFormat = val53;
		((Control)y).TabIndex = 123;
		y.SelectedIndexChanged += i;
		((Control)z).AutoSize = true;
		((Control)z).Location = new Point(468, 168);
		((Control)z).Name = "label6";
		((Control)z).Size = new Size(42, 14);
		((Control)z).TabIndex = 124;
		((Control)z).Text = "مذهب";
		((Control)u).AutoSize = true;
		((Control)u).Location = new Point(684, 168);
		((Control)u).Name = "label3";
		((Control)u).Size = new Size(72, 14);
		((Control)u).TabIndex = 122;
		((Control)u).Text = "تاریخ تولد تا";
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((EditBase)v).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(535, 164);
		v.Mask = "0000/00/00";
		((EditBase)v).MaxLength = 12;
		((Control)v).Name = "txtbDateTo";
		v.Numeric = true;
		((Control)v).RightToLeft = (RightToLeft)0;
		((Control)v).Size = new Size(143, 22);
		((Control)v).TabIndex = 121;
		((Control)v).Tag = "";
		((EditBase)v).TextAlignment = (TextAlignment)3;
		((Control)v).TextChanged += a;
		((Control)w).AutoSize = true;
		((Control)w).Location = new Point(684, 139);
		((Control)w).Name = "label38";
		((Control)w).Size = new Size(74, 14);
		((Control)w).TabIndex = 120;
		((Control)w).Text = "تاریخ تولد از";
		((EditBase)x).AutoScroll = false;
		((EditBase)x).AutoScrollMargin = new Size(0, 0);
		((EditBase)x).AutoScrollMinSize = new Size(0, 0);
		((EditBase)x).AutoScrollPosition = new Point(0, 0);
		((EditBase)x).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(535, 135);
		x.Mask = "0000/00/00";
		((EditBase)x).MaxLength = 12;
		((Control)x).Name = "txtbDateFrom";
		x.Numeric = true;
		((Control)x).RightToLeft = (RightToLeft)0;
		((Control)x).Size = new Size(143, 22);
		((Control)x).TabIndex = 119;
		((Control)x).Tag = "";
		((EditBase)x).TextAlignment = (TextAlignment)3;
		((Control)x).TextChanged += a;
		((EditBase)a2).AutoScroll = false;
		((EditBase)a2).AutoScrollMargin = new Size(0, 0);
		((EditBase)a2).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a2).AutoScrollPosition = new Point(0, 0);
		((Control)a2).Location = new Point(535, 105);
		((Control)a2).Name = "txtNamP";
		((Control)a2).Size = new Size(143, 22);
		((Control)a2).TabIndex = 115;
		((EditBase)a2).TextAlignment = (TextAlignment)1;
		((Control)a2).TextChanged += a;
		((Control)a3).AutoSize = true;
		((Control)a3).Location = new Point(684, 109);
		((Control)a3).Name = "label8";
		((Control)a3).Size = new Size(41, 14);
		((Control)a3).TabIndex = 116;
		((Control)a3).Text = "ولدیت";
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(468, 52);
		((Control)q).Name = "label2";
		((Control)q).Size = new Size(49, 14);
		((Control)q).TabIndex = 114;
		((Control)q).Text = "وضعیت";
		((UIComboBase)r).ComboStyle = (ComboStyle)1;
		((UIComboBase)r).DropListFont = new Font("B Nazanin", 12f);
		val54.FormatStyle.Alpha = 0;
		val54.Text = "کل";
		val54.Value = "0";
		val55.FormatStyle.Alpha = 0;
		val55.Text = "برحال";
		val55.Value = "1";
		val56.FormatStyle.Alpha = 0;
		val56.Text = "محروم";
		val56.Value = "2";
		val57.FormatStyle.Alpha = 0;
		val57.Text = "منفک";
		val57.Value = "3";
		val58.FormatStyle.Alpha = 0;
		val58.Text = "معذرتی";
		val58.Value = "4";
		r.Items.AddRange(new UIComboBoxItem[5] { val54, val55, val56, val57, val58 });
		((Control)r).Location = new Point(310, 48);
		((Control)r).Name = "dropStatus";
		((Control)r).Size = new Size(153, 22);
		val59.Alignment = (StringAlignment)0;
		val59.FormatFlags = (StringFormatFlags)20485;
		val59.HotkeyPrefix = (HotkeyPrefix)0;
		val59.LineAlignment = (StringAlignment)1;
		val59.Trimming = (StringTrimming)1;
		((UIComboBase)r).StringFormat = val59;
		((Control)r).TabIndex = 9;
		r.SelectedIndexChanged += j;
		((UIComboBase)this.m_o).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_o).DropListFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		val60.FormatStyle.Alpha = 0;
		val60.Text = "کل";
		val60.Value = "-1";
		val61.FormatStyle.Alpha = 0;
		val61.Text = "مرد";
		val61.Value = "1";
		val62.FormatStyle.Alpha = 0;
		val62.Text = "زن";
		val62.Value = "0";
		this.m_o.Items.AddRange(new UIComboBoxItem[3] { val60, val61, val62 });
		((Control)this.m_o).Location = new Point(310, 135);
		((Control)this.m_o).Name = "dropJens";
		((Control)this.m_o).Size = new Size(153, 22);
		val63.Alignment = (StringAlignment)0;
		val63.FormatFlags = (StringFormatFlags)20485;
		val63.HotkeyPrefix = (HotkeyPrefix)0;
		val63.LineAlignment = (StringAlignment)1;
		val63.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_o).StringFormat = val63;
		((Control)this.m_o).TabIndex = 5;
		this.m_o.SelectedIndexChanged += i;
		((Control)this.m_p).AutoSize = true;
		((Control)this.m_p).Location = new Point(468, 139);
		((Control)this.m_p).Name = "label1";
		((Control)this.m_p).Size = new Size(52, 14);
		((Control)this.m_p).TabIndex = 85;
		((Control)this.m_p).Text = "جنیست";
		((Control)this.m_m).Anchor = (AnchorStyles)9;
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		this.m_m.ImageSize = new Size(25, 25);
		((Control)this.m_m).Location = new Point(5, 195);
		((Control)this.m_m).Name = "btnNoSearch";
		((Control)this.m_m).Size = new Size(86, 52);
		((Control)this.m_m).TabIndex = 11;
		((Control)this.m_m).Text = "حذف جستجو";
		((Control)this.m_m).Click += m;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(684, 80);
		((Control)this.m_i).Name = "label5";
		((Control)this.m_i).Size = new Size(53, 14);
		((Control)this.m_i).TabIndex = 29;
		((Control)this.m_i).Text = "ولد/بنت";
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((Control)this.m_j).AutoSize = true;
		((Control)this.m_j).Location = new Point(684, 21);
		((Control)this.m_j).Name = "label4";
		((Control)this.m_j).Size = new Size(23, 14);
		((Control)this.m_j).TabIndex = 28;
		((Control)this.m_j).Text = "نام";
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((EditBase)this.m_k).AutoScroll = false;
		((EditBase)this.m_k).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_k).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_k).Location = new Point(535, 76);
		((Control)this.m_k).Name = "txtLName";
		((Control)this.m_k).RightToLeft = (RightToLeft)1;
		((Control)this.m_k).Size = new Size(143, 22);
		((Control)this.m_k).TabIndex = 4;
		((EditBase)this.m_k).TextAlignment = (TextAlignment)1;
		((Control)this.m_k).TextChanged += a;
		((Control)this.m_l).Anchor = (AnchorStyles)9;
		((EditBase)this.m_l).AutoScroll = false;
		((EditBase)this.m_l).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_l).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_l).Location = new Point(535, 17);
		((Control)this.m_l).Name = "txtFName";
		((Control)this.m_l).RightToLeft = (RightToLeft)1;
		((Control)this.m_l).Size = new Size(143, 22);
		((Control)this.m_l).TabIndex = 3;
		((EditBase)this.m_l).TextAlignment = (TextAlignment)1;
		((Control)this.m_l).TextChanged += a;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Location = new Point(468, 109);
		((Control)this.m_g).Name = "label19";
		((Control)this.m_g).Size = new Size(36, 14);
		((Control)this.m_g).TabIndex = 25;
		((Control)this.m_g).Text = "صنف";
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(310, 105);
		((Control)this.m_h).Name = "dropCls";
		((Control)this.m_h).Size = new Size(153, 22);
		val64.Alignment = (StringAlignment)0;
		val64.FormatFlags = (StringFormatFlags)20485;
		val64.HotkeyPrefix = (HotkeyPrefix)0;
		val64.LineAlignment = (StringAlignment)1;
		val64.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val64;
		((Control)this.m_h).TabIndex = 8;
		this.m_h.SelectedIndexChanged += l;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(468, 80);
		((Control)this.m_e).Name = "label20";
		((Control)this.m_e).Size = new Size(27, 14);
		((Control)this.m_e).TabIndex = 15;
		((Control)this.m_e).Text = "پایه";
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_f).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_f).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(310, 76);
		((Control)this.m_f).Name = "dropPaye";
		((Control)this.m_f).Size = new Size(153, 22);
		val65.Alignment = (StringAlignment)0;
		val65.FormatFlags = (StringFormatFlags)20485;
		val65.HotkeyPrefix = (HotkeyPrefix)0;
		val65.LineAlignment = (StringAlignment)1;
		val65.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_f).StringFormat = val65;
		((Control)this.m_f).TabIndex = 7;
		this.m_f.SelectedIndexChanged += n;
		((FileDialog)this.m_n).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_n).Title = "انتخاب عکس شاگرد";
		((Control)s).BackColor = Color.Black;
		((Control)s).Controls.Add((Control)(object)this.m_c);
		((Control)s).Dock = (DockStyle)5;
		((Control)s).Location = new Point(0, 0);
		((Control)s).Name = "panel2";
		((Control)s).Size = new Size(800, 675);
		((Control)s).TabIndex = 1;
		bi.Interval = 700;
		bi.Tick += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 675);
		((Control)this).Controls.Add((Control)(object)s);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmlistStdSearch";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست شاگردان";
		((Form)this).Load += p;
		((Form)this).Shown += c;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)bg).ResumeLayout(false);
		((Control)bg).PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((ISupportInitialize)a6).EndInit();
		((Control)a6).ResumeLayout(false);
		((Control)a6).PerformLayout();
		((Control)s).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdai()
	{
		j();
	}

	private void p(object A_0, EventArgs A_1)
	{
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 2;
					continue;
				case 5:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_c).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 1;
					continue;
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_012c;
				case 6:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					if (1 == 0)
					{
					}
					goto IL_012c;
				case 0:
					{
						num = 5;
						continue;
					}
					IL_012c:
					r.SelectedIndex = 0;
					this.m_o.SelectedIndex = 0;
					g();
					f();
					b();
					c();
					h();
					i();
					bj = true;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void i()
	{
		while (true)
		{
			string text = "";
			bool flag = a7.SelectedIndex <= 0;
			int num = 2;
			while (true)
			{
				DataTable dataSource;
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_007c;
				case 0:
					text = text + " where xOstan=" + a7.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
					{
						if (1 == 0)
						{
						}
						goto IL_007c;
					}
					IL_007c:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'کل' as  name\r\n                                                                                                union select id,name from tCity" + text);
					a9.DataSource = dataSource;
					a9.ValueMember = "id";
					a9.DisplayMember = "name";
					return;
				}
				break;
			}
		}
	}

	private void h()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'کل' as  name\r\n                                                                                                                union  select id , name from tostan");
		a7.DataSource = dataSource;
		a7.ValueMember = "id";
		a7.DisplayMember = "name";
	}

	private void g()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") order by id");
			this.m_f.Items.Add("کل", (object)"0");
			int num = 0;
			if (true)
			{
			}
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					this.m_f.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 1:
					this.m_f.SelectedIndex = 0;
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
			if (true)
			{
			}
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_f.SelectedIndex <= 0;
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
					text = " and xPaye=" + this.m_f.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + asdaj.a + text);
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					this.m_h.SelectedIndex = 0;
					return;
				}
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
		this.m_b.DataSource = null;
		((Control)bg).Visible = true;
		((Control)this).Refresh();
		d();
	}

	private void d()
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = bj;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					string text = a();
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.Code, tYear_Student.xPaye, tYear_Student.xClass, tStudent.FName, \r\n   tStudent.LName, tStudent.PName, tStudent.Sh_Sh, tStudent.bDate, tStudent.bDateM, \r\n  tStudent.En_Fname, tStudent.En_Lname, tStudent.LastName, tStudent.En_LastName,\r\n            tOstan.Name AS Ostan, tCity.Name AS City, tStudent.Adress,tmpMark1.markDoreh as mark1,\r\n                      tStudent.MobileMother, tStudent.MobileFather, tClass.name AS Class, tPaye.Name AS Paye, tStudentImg.Student_img, tStudent.NumberTelegram, \r\n                      tStudent.NumberTelegram2, tStudent.NumberAsas, tStudent.RegDate, tYear_Student.Status, tYear_Student.sort, tYear_Student.shaghe, tYear_Student.hazer, \r\n                      tYear_Student.mali, tYear_Student.dakhle, tYear_Student.uniform, tYear_Student.komakdarsi, tYear_Student.ketab, tYear_Student.transport, tYear_Student.robotic, \r\n                      tYear_Student.maghnae,tYear_Student.MarkTerm3_From100, tYear_Student.SumFee, tYear_Student.Sumtransport, tDriver.name AS Driver, tTakhfif.name AS Takhfif,\r\ncase tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک' when 4 then N'معذرتی' end as vazeyat\r\n,case tStudent.Jens when 1 then N'مرد' when 0 then N'زن' else '' end as Jens\r\n,case tStudent.Mazhab when 1 then N'شیعه' when 0 then N'سنی' else '' end as Mazhab\r\n,tYear_Student.codeTakhfif, tOstan_1.Name AS OstanNow, tCity_1.Name AS CityNow\r\nFROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN\r\n                      tDriver ON tYear_Student.xDriver = tDriver.id LEFT OUTER JOIN\r\n                      tTakhfif ON tYear_Student.xTakhfif = tTakhfif.id LEFT OUTER JOIN\r\n                      tStudentImg ON tStudent.id = tStudentImg.xStudent   LEFT OUTER JOIN\r\n                      tCity ON tStudent.xCity = tCity.id  LEFT OUTER JOIN\r\n                      tOstan ON tCity.xOstan = tOstan.id  LEFT OUTER JOIN\r\n                      tCity tCity_1 ON tStudent.xCityNow = tCity_1.id LEFT OUTER JOIN\r\n                      tOstan tOstan_1 ON tCity_1.xOstan = tOstan_1.id LEFT OUTER JOIN\r\n(SELECT     ROUND(tMarkDoreh.MarkDoreh, 2) AS markDoreh, tMarkDoreh.xStudent\r\nFROM         tMarkDoreh INNER JOIN\r\n                      tExam ON tMarkDoreh.Xtest = tExam.id\r\nWHERE     (tExam.term = 1) AND (tExam.xYear = " + asdaj.a + ") AND (tMarkDoreh.typ = 5))tmpMark1 on tStudent.id=tmpMark1.xStudent" + text);
					this.m_b.DataSource = dataSource;
					((Control)bg).Visible = false;
					num = 0;
					continue;
				}
				case 0:
					return;
				case 1:
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void n(object A_0, EventArgs A_1)
	{
		f();
		e();
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from ttakhfif order by name");
		aa.DataSource = dataSource;
		aa.DisplayMember = "Name";
		aa.ValueMember = "id";
		aa.SelectedIndex = 0;
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tDriver order by name");
		ad.DataSource = dataSource;
		ad.DisplayMember = "Name";
		ad.ValueMember = "id";
		ad.SelectedIndex = 0;
	}

	private void m(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		bj = false;
		this.m_f.SelectedIndex = 0;
		this.m_h.SelectedIndex = 0;
		r.SelectedIndex = 0;
		this.m_o.SelectedIndex = 0;
		ad.SelectedIndex = 0;
		y.SelectedIndex = 0;
		y.SelectedIndex = 0;
		aa.SelectedIndex = 0;
		af.SelectedIndex = 0;
		ax.SelectedIndex = 0;
		an.SelectedIndex = 0;
		ao.SelectedIndex = 0;
		av.SelectedIndex = 0;
		aw.SelectedIndex = 0;
		at.SelectedIndex = 0;
		au.SelectedIndex = 0;
		am.SelectedIndex = 0;
		ag.SelectedIndex = 0;
		bd.SelectedIndex = 0;
		((Control)this.m_k).Text = "";
		((Control)this.m_l).Text = "";
		((Control)a2).Text = "";
		((Control)a5).Text = "";
		((Control)bc).Text = "";
		a9.SelectedIndex = 0;
		a7.SelectedIndex = 0;
		bj = true;
		e();
	}

	private void l(object A_0, EventArgs A_1)
	{
		e();
	}

	private void k(object A_0, EventArgs A_1)
	{
		bk = this.m_b.Row;
	}

	private string a()
	{
		string result = default;
		while (true)
		{
			string text = " tYear_Student.xYear=" + asdaj.a + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = this.m_h.SelectedIndex <= 0;
			int num = 94;
			while (true)
			{
				switch (num)
				{
				case 94:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 10;
				case 84:
					text += " and ";
					num = 163;
					continue;
				case 156:
					text = text + " tYear_Student.transport=" + am.SelectedValue.ToString();
					num = 152;
					continue;
				case 112:
					flag = aa.SelectedIndex <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 145;
				case 80:
					text += " and ";
					num = 85;
					continue;
				case 86:
					text = text + " tstudent.jens=" + this.m_o.SelectedValue.ToString();
					num = 23;
					continue;
				case 40:
					flag = !(((Control)this.m_k).Text.Trim() != "");
					num = 97;
					continue;
				case 97:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 43;
				case 151:
					flag = !(text != "");
					num = 88;
					continue;
				case 88:
					if (!flag)
					{
						num = 120;
						continue;
					}
					goto case 27;
				case 115:
					flag = !(text != "");
					num = 164;
					continue;
				case 164:
					if (!flag)
					{
						num = 155;
						continue;
					}
					goto case 1;
				case 111:
					text = text + " tYear_Student.xTakhfif=" + aa.SelectedValue.ToString();
					num = 145;
					continue;
				case 81:
					flag = !(text != "");
					num = 92;
					continue;
				case 92:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 16;
				case 73:
					flag = !(text != "");
					num = 31;
					continue;
				case 31:
					if (!flag)
					{
						num = 114;
						continue;
					}
					goto case 29;
				case 138:
					flag = !(text != "");
					num = 137;
					continue;
				case 137:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 75;
				case 48:
					flag = !(text != "");
					num = 104;
					continue;
				case 104:
					if (!flag)
					{
						num = 106;
						continue;
					}
					goto case 45;
				case 124:
					text += " and ";
					num = 52;
					continue;
				case 100:
					text += " and ";
					num = 34;
					continue;
				case 145:
					flag = af.SelectedIndex <= 0;
					num = 126;
					continue;
				case 126:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 161;
				case 16:
					text = text + " tstudent.bDate<='" + asdaj.b(((Control)v).Text) + "'";
					num = 22;
					continue;
				case 142:
					text = text + " tstudent.LastName like '%" + asdaj.b(((Control)a5).Text) + "%'";
					num = 60;
					continue;
				case 61:
					flag = av.SelectedIndex <= 0;
					num = 143;
					continue;
				case 143:
					if (!flag)
					{
						num = 144;
						continue;
					}
					goto case 79;
				case 144:
					flag = !(text != "");
					num = 63;
					continue;
				case 63:
					if (!flag)
					{
						num = 134;
						continue;
					}
					goto case 130;
				case 74:
					text = text + " tYear_Student.MarkTerm3_From100=" + bd.SelectedValue.ToString();
					num = 82;
					continue;
				case 95:
					text = text + " tYear_Student.hazer=" + ax.SelectedValue.ToString();
					num = 37;
					continue;
				case 8:
					flag = !(text != "");
					num = 157;
					continue;
				case 157:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 111;
				case 85:
					text = text + " tstudent.Adress like '%" + asdaj.b(((Control)bc).Text) + "%'";
					num = 0;
					continue;
				case 160:
					flag = !(text != "");
					num = 35;
					continue;
				case 35:
					if (!flag)
					{
						num = 51;
						continue;
					}
					goto case 95;
				case 146:
					text += " and ";
					num = 90;
					continue;
				case 24:
					flag = !(text != "");
					num = 78;
					continue;
				case 78:
					if (!flag)
					{
						num = 146;
						continue;
					}
					goto case 90;
				case 154:
					flag = !(text != "");
					num = 133;
					continue;
				case 133:
					if (!flag)
					{
						num = 55;
						continue;
					}
					goto case 93;
				case 10:
					flag = this.m_f.SelectedIndex <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						if (true)
						{
						}
						num = 131;
						continue;
					}
					goto case 65;
				case 147:
					text += " and ";
					num = 12;
					continue;
				case 91:
					text = text + " tYear_Student.ketab=" + an.SelectedValue.ToString();
					num = 148;
					continue;
				case 158:
					text = text + " tstudent.PName like '%" + asdaj.b(((Control)a2).Text) + "%'";
					num = 113;
					continue;
				case 76:
					flag = !(text != "");
					num = 128;
					continue;
				case 128:
					if (!flag)
					{
						num = 87;
						continue;
					}
					goto case 99;
				case 153:
					text = text + " tstudent.bDate>='" + asdaj.b(((Control)x).Text) + "'";
					num = 53;
					continue;
				case 23:
					flag = y.SelectedIndex <= 0;
					num = 98;
					continue;
				case 98:
					if (!flag)
					{
						num = 42;
						continue;
					}
					goto case 18;
				case 45:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 10;
					continue;
				case 120:
					text += " and ";
					num = 27;
					continue;
				case 90:
					text = text + " tYear_Student.dakhle=" + af.SelectedValue.ToString();
					num = 161;
					continue;
				case 42:
					flag = !(text != "");
					num = 119;
					continue;
				case 119:
					if (!flag)
					{
						num = 100;
						continue;
					}
					goto case 34;
				case 72:
					text += " and ";
					num = 142;
					continue;
				case 38:
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 121;
						continue;
					}
					goto case 50;
				case 18:
					flag = ad.SelectedIndex <= 0;
					num = 116;
					continue;
				case 116:
					if (!flag)
					{
						num = 140;
						continue;
					}
					goto case 112;
				case 47:
					flag = !(text != "");
					num = 132;
					continue;
				case 132:
					if (!flag)
					{
						num = 102;
						continue;
					}
					goto case 74;
				case 161:
					flag = ax.SelectedIndex <= 0;
					num = 57;
					continue;
				case 57:
					if (!flag)
					{
						num = 160;
						continue;
					}
					goto case 37;
				case 149:
					flag = !(text != "");
					num = 77;
					continue;
				case 77:
					if (!flag)
					{
						num = 54;
						continue;
					}
					goto case 153;
				case 15:
					text += " and ";
					num = 158;
					continue;
				case 54:
					text += " and ";
					num = 153;
					continue;
				case 32:
					text += " and ";
					num = 16;
					continue;
				case 140:
					flag = !(text != "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 124;
						continue;
					}
					goto case 52;
				case 1:
					text = text + " tYear_Student.uniform=" + ag.SelectedValue.ToString();
					num = 127;
					continue;
				case 87:
					text += " and ";
					num = 99;
					continue;
				case 66:
					flag = !(text != "");
					num = 62;
					continue;
				case 62:
					if (!flag)
					{
						num = 125;
						continue;
					}
					goto case 156;
				case 4:
					flag = !(text != "");
					num = 135;
					continue;
				case 135:
					if (!flag)
					{
						num = 159;
						continue;
					}
					goto case 86;
				case 113:
					flag = !(((Control)a5).Text.Trim() != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 71;
						continue;
					}
					goto case 60;
				case 152:
					flag = ag.SelectedIndex <= 0;
					num = 70;
					continue;
				case 70:
					if (!flag)
					{
						num = 115;
						continue;
					}
					goto case 127;
				case 20:
					text += " and ";
					num = 75;
					continue;
				case 130:
					text = text + " tYear_Student.maghnae=" + av.SelectedValue.ToString();
					num = 79;
					continue;
				case 75:
					text = text + " tYear_Student.mali=" + aw.SelectedValue.ToString();
					num = 162;
					continue;
				case 125:
					text += " and ";
					num = 156;
					continue;
				case 59:
					flag = a7.SelectedIndex <= 0;
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 73;
				case 12:
					text = text + " tYear_Student.robotic=" + at.SelectedValue.ToString();
					num = 68;
					continue;
				case 79:
					flag = aw.SelectedIndex <= 0;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 138;
						continue;
					}
					goto case 162;
				case 102:
					text += " and ";
					num = 74;
					continue;
				case 60:
					flag = !(((Control)bc).Text.Trim() != "");
					num = 64;
					continue;
				case 64:
					if (!flag)
					{
						num = 122;
						continue;
					}
					goto case 0;
				case 155:
					text += " and ";
					num = 1;
					continue;
				case 52:
					text = text + " tYear_Student.xDriver=" + ad.SelectedValue.ToString();
					num = 112;
					continue;
				case 65:
					flag = r.SelectedIndex <= 0;
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 38;
						continue;
					}
					goto case 139;
				case 139:
					flag = this.m_o.SelectedIndex <= 0;
					num = 118;
					continue;
				case 118:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 23;
				case 131:
					flag = !(text != "");
					num = 123;
					continue;
				case 123:
					if (!flag)
					{
						num = 96;
						continue;
					}
					goto case 19;
				case 159:
					text += " and ";
					num = 86;
					continue;
				case 99:
					text = text + " tYear_Student.komakdarsi=" + ao.SelectedValue.ToString();
					num = 61;
					continue;
				case 163:
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)this.m_k).Text) + "%'";
					num = 43;
					continue;
				case 11:
					flag = !(text != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 84;
						continue;
					}
					goto case 163;
				case 103:
					text += " and ";
					num = 69;
					continue;
				case 148:
					flag = ao.SelectedIndex <= 0;
					num = 83;
					continue;
				case 83:
					if (!flag)
					{
						num = 76;
						continue;
					}
					goto case 61;
				case 108:
					flag = am.SelectedIndex <= 0;
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 66;
						continue;
					}
					goto case 152;
				case 122:
					flag = !(text != "");
					num = 141;
					continue;
				case 141:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 85;
				case 106:
					text += " and ";
					num = 45;
					continue;
				case 96:
					text += " and ";
					num = 19;
					continue;
				case 82:
					flag = !(((Control)this.m_l).Text.Trim() != "");
					num = 150;
					continue;
				case 150:
					if (!flag)
					{
						num = 105;
						continue;
					}
					goto case 40;
				case 68:
					flag = au.SelectedIndex <= 0;
					num = 67;
					continue;
				case 67:
					if (!flag)
					{
						num = 154;
						continue;
					}
					goto case 108;
				case 21:
					flag = !(text != "");
					num = 56;
					continue;
				case 56:
					if (!flag)
					{
						num = 147;
						continue;
					}
					goto case 12;
				case 109:
					text += " and ";
					num = 91;
					continue;
				case 93:
					text = text + " tYear_Student.shaghe=" + au.SelectedValue.ToString();
					num = 108;
					continue;
				case 34:
					text = text + " tstudent.Mazhab=" + y.SelectedValue.ToString();
					num = 18;
					continue;
				case 27:
					text = text + " tstudent.xCityNow=" + a9.SelectedValue.ToString();
					num = 59;
					continue;
				case 101:
					flag = !(text != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 158;
				case 43:
					flag = !(((Control)a2).Text.Trim() != "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 101;
						continue;
					}
					goto case 113;
				case 129:
					flag = !(text != "");
					num = 110;
					continue;
				case 110:
					if (!flag)
					{
						num = 109;
						continue;
					}
					goto case 91;
				case 44:
					flag = !(text != "");
					num = 107;
					continue;
				case 107:
					if (!flag)
					{
						num = 36;
						continue;
					}
					goto case 14;
				case 0:
					flag = !(((Control)x).Text.Trim() != "");
					num = 136;
					continue;
				case 136:
					if (!flag)
					{
						num = 149;
						continue;
					}
					goto case 53;
				case 127:
					flag = bd.SelectedIndex <= 0;
					num = 58;
					continue;
				case 58:
					if (!flag)
					{
						num = 47;
						continue;
					}
					goto case 82;
				case 53:
					flag = !(((Control)v).Text.Trim() != "");
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 81;
						continue;
					}
					goto case 22;
				case 51:
					text += " and ";
					num = 95;
					continue;
				case 134:
					text += " and ";
					num = 130;
					continue;
				case 22:
					flag = a9.SelectedIndex <= 0;
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 151;
						continue;
					}
					goto case 59;
				case 69:
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)this.m_l).Text) + "%'";
					num = 40;
					continue;
				case 14:
					text = text + " tCity_1.xOstan=" + a7.SelectedValue.ToString();
					num = 73;
					continue;
				case 105:
					flag = !(text != "");
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 103;
						continue;
					}
					goto case 69;
				case 55:
					text += " and ";
					num = 93;
					continue;
				case 71:
					flag = !(text != "");
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 72;
						continue;
					}
					goto case 142;
				case 36:
					text += " and ";
					num = 14;
					continue;
				case 114:
					text = " where " + text;
					num = 29;
					continue;
				case 19:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 65;
					continue;
				case 50:
					text = text + " tYear_Student.Status=" + r.SelectedValue.ToString();
					num = 139;
					continue;
				case 162:
					flag = at.SelectedIndex <= 0;
					num = 165;
					continue;
				case 165:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 68;
				case 29:
					result = text;
					num = 117;
					continue;
				case 49:
					text += " and ";
					num = 111;
					continue;
				case 121:
					text += " and ";
					num = 50;
					continue;
				case 37:
					flag = an.SelectedIndex <= 0;
					num = 89;
					continue;
				case 89:
					if (!flag)
					{
						num = 129;
						continue;
					}
					goto case 148;
				case 117:
					return result;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		e();
	}

	private void i(object A_0, EventArgs A_1)
	{
		e();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
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
					num = ((this.m_b.RowCount <= 0) ? 1 : 8);
					continue;
				case 8:
					num = 9;
					continue;
				case 9:
					if (true)
					{
					}
					num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_009c;
				case 1:
					num2 = 1;
					goto IL_009c;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 5:
				{
					asdaj.h = false;
					string text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdat asdat2 = new asdat();
					asdat2.a = text;
					((Form)asdat2).ShowDialog();
					flag = !asdaj.h;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 0:
					num = 6;
					continue;
				case 6:
					return;
				case 2:
					{
						d();
						num = 0;
						continue;
					}
					IL_009c:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string a_ = "SELECT    tStudent.code as [کد متعلم],     tStudent.FName as [نام], tStudent.LastName AS تخلص,  tStudent.LName as [ولد/بنت], tStudent.PName as [ولدیت], tStudent.En_Fname AS [نام انگلسی], tStudent.En_LastName AS [تخلص انگلیسی], tStudent.En_Lname AS [نام پدر انگلیسی], tStudent.Sh_Sh as [نمبر تذکره], tStudent.bDate as [تاریخ تولد شمسی],  tStudent.bDateM as [تاریخ تولد میلادی], \r\n                      tStudent.MobileMother as [شماره مادر], tStudent.MobileFather as [شماره پدر],tStudent.NumberTelegram as [نمبر تلگرام] , tPaye.Name  as [پایه],  tClass.name  as [صنف],\r\n                       tStudent.NumberAsas as [نمبر اساس] , tStudent.RegDate  as [تاریخ شمولیت],tYear_Student.codeTakhfif as [کد تخفیف],  tOstan.Name AS [ولایت سکونت اصلی], tCity.Name AS [ولسوالی سکونت اصلی], tOstan_1.Name AS [ولایت سکونت فعلی], tCity_1.Name  as [ولسوالی سکونت فعلی], tStudent.Adress AS [آدرس سکونت],  tYear_Student.sort  as [ترتیب], tYear_Student.SumFee  as [مجموع فیس], tYear_Student.Sumtransport  as [مجموع ترانسپورت], tDriver.name  as [راننده], tTakhfif.name  as [تخفیف] ,\r\ncase tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک' when 4 then N'معذرتی' end  as [وضعیت]\r\n,case tStudent.Jens when 1 then N'مرد' when 0 then N'زن' else '' end  as [جنسیت]\r\n,case tStudent.Mazhab when 1 then N'شیعه' when 0 then N'سنی' else '' end  as [مذهب],tmpMark1.markDoreh as [اوسط چهار و نیم ماهه], tYear_Student.shaghe  as [شقه], tYear_Student.hazer  as [حاضر در صنف], \r\n                      tYear_Student.mali  as [لیست مالی], tYear_Student.dakhle  as [داخله], tYear_Student.uniform  as [یونیفرم], tYear_Student.komakdarsi  as [کمک درسی], tYear_Student.ketab  as [کتاب], tYear_Student.transport  as [ترانسپورت], tYear_Student.robotic  as [رباتیک], \r\n                      tYear_Student.maghnae  as [مقنعه],tYear_Student.MarkTerm3_From100 as [ورود نمره سالانه از 100]\r\nFROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id LEFT OUTER JOIN\r\n                      tDriver ON tYear_Student.xDriver = tDriver.id LEFT OUTER JOIN\r\n                      tTakhfif ON tYear_Student.xTakhfif = tTakhfif.id  LEFT OUTER JOIN\r\n                      tCity ON tStudent.xCity = tCity.id LEFT OUTER JOIN\r\n                      tOstan ON tCity.xOstan = tOstan.id LEFT OUTER JOIN\r\n                      tCity tCity_1 ON tStudent.xCityNow = tCity_1.id LEFT OUTER JOIN\r\n                      tOstan tOstan_1 ON tCity_1.xOstan = tOstan_1.id LEFT OUTER JOIN\r\n(SELECT     ROUND(tMarkDoreh.MarkDoreh, 2) AS markDoreh, tMarkDoreh.xStudent\r\nFROM         tMarkDoreh INNER JOIN\r\n                      tExam ON tMarkDoreh.Xtest = tExam.id\r\nWHERE     (tExam.term = 1) AND (tExam.xYear = " + asdaj.a + ") AND (tMarkDoreh.typ = 5))tmpMark1 on tStudent.id=tmpMark1.xStudent" + a();
			asdbe asdbe2 = new asdbe(a_, asdab.e());
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).Filter = "Excel Spreadsheets (*.xls)|*.xls";
			((FileDialog)val).DefaultExt = "xls";
			bool flag = (int)((CommonDialog)val).ShowDialog() != 1;
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
						num = 0;
						continue;
					}
					return;
				case 0:
					asdbe2.b(((FileDialog)val).FileName);
					MessageBox.Show("پایان");
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		i();
		e();
	}

	private void e(object A_0, EventArgs A_1)
	{
		e();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				if (true)
				{
				}
				int num2;
				switch (num)
				{
				case 5:
					num = ((this.m_b.RowCount <= 0) ? 6 : 3);
					continue;
				case 3:
					num = 1;
					continue;
				case 1:
					num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_00d8;
				case 2:
				{
					string text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asda4 asda10 = new asda4();
					asda10.a = text;
					((Form)asda10).ShowDialog();
					num = 4;
					continue;
				}
				case 4:
					return;
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 6:
					{
						num2 = 1;
						goto IL_00d8;
					}
					IL_00d8:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)this).Refresh();
		d();
	}

	private void b(object A_0, EventArgs A_1)
	{
		bi.Stop();
		e();
	}

	private void a(object A_0, EventArgs A_1)
	{
		bi.Stop();
		bi.Start();
	}
}
