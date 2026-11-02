using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using school_Af;

public class asdb3 : Form
{
	private IContainer m_a = null;

	private MenuStrip m_b;

	private ToolStripMenuItem m_c;

	private ToolStripMenuItem m_d;

	private ToolStripMenuItem m_e;

	private ToolStripSeparator m_f;

	private ToolStripMenuItem m_g;

	private ToolStripMenuItem m_h;

	private ToolStripMenuItem m_i;

	private ToolStripMenuItem m_j;

	private ToolStripMenuItem m_k;

	private ToolStripMenuItem m_l;

	private ToolStripMenuItem m_m;

	private ToolStripMenuItem m_n;

	private ToolStripMenuItem m_o;

	private ToolStripMenuItem m_p;

	private ToolStripMenuItem m_q;

	private ToolStripMenuItem m_r;

	private Label m_s;

	private Label m_t;

	private Label m_u;

	private Label m_v;

	private ToolStripMenuItem m_w;

	private ToolStripMenuItem m_x;

	private ToolStripMenuItem m_y;

	private ToolStripMenuItem m_z;

	private ToolStripMenuItem m_aa;

	private ToolStripMenuItem m_ab;

	private ToolStripMenuItem m_ac;

	private ToolStripMenuItem m_ad;

	private ToolStripMenuItem m_ae;

	private ToolStripSeparator m_af;

	private ToolStripMenuItem m_ag;

	private ToolStripMenuItem m_ah;

	private ToolStripSeparator m_ai;

	private ToolStripMenuItem m_aj;

	private ToolStripSeparator m_ak;

	private ToolStripMenuItem m_al;

	private ToolStripSeparator m_am;

	private ToolStripSeparator m_an;

	private ToolStripMenuItem m_ao;

	private ToolStripMenuItem m_ap;

	private ToolStripMenuItem m_aq;

	private ToolStripMenuItem m_ar;

	private ToolStripMenuItem m_as;

	private ToolStripMenuItem m_at;

	private ToolStripMenuItem m_au;

	private ToolStripMenuItem m_av;

	private ToolStripMenuItem m_aw;

	private PictureBox m_ax;

	private ToolStripMenuItem m_ay;

	private ToolStripSeparator m_az;

	private ToolStripMenuItem m_a0;

	private ToolStripSeparator m_a1;

	private ToolStripMenuItem m_a2;

	private ToolStripSeparator m_a3;

	private ToolStripMenuItem m_a4;

	private ToolStripMenuItem m_a5;

	private ToolStripMenuItem m_a6;

	private ToolStripMenuItem m_a7;

	private ToolStripMenuItem m_a8;

	private ToolStripMenuItem m_a9;

	private ToolStripMenuItem m_ba;

	private ToolStripSeparator m_bb;

	private ToolStripSeparator m_bc;

	private ToolStripSeparator m_bd;

	private ToolStripSeparator m_be;

	private ToolStripSeparator m_bf;

	private ToolStripMenuItem m_bg;

	private ToolStripMenuItem m_bh;

	private ToolStripMenuItem m_bi;

	private ToolStripMenuItem m_bj;

	private ToolStripMenuItem m_bk;

	private ToolStripMenuItem m_bl;

	private ToolStripMenuItem m_bm;

	private ToolStripMenuItem m_bn;

	private ToolStripMenuItem m_bo;

	private ToolStripMenuItem m_bp;

	private ToolStripMenuItem m_bq;

	private ToolStripMenuItem m_br;

	private ToolStripMenuItem m_bs;

	private ToolStripMenuItem m_bt;

	private ToolStripMenuItem m_bu;

	private ToolStripMenuItem m_bv;

	private ToolStripMenuItem m_bw;

	private ToolStripSeparator bx;

	private ToolStripMenuItem by;

	private ToolStripMenuItem bz;

	private ToolStripSeparator b0;

	private ToolStripMenuItem b1;

	private ToolStripMenuItem b2;

	private ToolStripMenuItem b3;

	private ToolStripMenuItem b4;

	private ToolStripSeparator b5;

	private ToolStripMenuItem b6;

	private ToolStripMenuItem b7;

	private ToolStripSeparator b8;

	private ToolStripMenuItem b9;

	private ToolStripSeparator ca;

	private ToolStripMenuItem cb;

	private ToolStripSeparator cc;

	private ToolStripMenuItem cd;

	private ToolStripSeparator ce;

	private ToolStripSeparator cf;

	private ToolStripSeparator cg;

	private ToolStripSeparator ch;

	private ToolStripSeparator ci;

	private ToolStripSeparator cj;

	private ToolStripSeparator ck;

	private ToolStripSeparator cl;

	private ToolStripSeparator cm;

	private ToolStripSeparator cn;

	private ToolStripSeparator co;

	private ToolStripSeparator cp;

	private ToolStripSeparator cq;

	private ToolStripSeparator cr;

	private ToolStripSeparator cs;

	private ToolStripSeparator ct;

	private ToolStripSeparator cu;

	private ToolStripSeparator cv;

	private ToolStripSeparator cw;

	private ToolStripSeparator cx;

	private ToolStripSeparator cy;

	private ToolStripSeparator cz;

	private ToolStripSeparator c0;

	private ToolStripMenuItem c1;

	private ToolStripMenuItem c2;

	private ToolStripMenuItem c3;

	private ToolStripMenuItem c4;

	private ToolStripSeparator c5;

	private ToolStripSeparator c6;

	private ToolStripMenuItem c7;

	private ToolStripMenuItem c8;

	private ToolStripSeparator c9;

	private ToolStripMenuItem da;

	private ToolStripSeparator db;

	private ToolStripSeparator dc;

	private Label dd;

	private Label de;

	private ToolStripMenuItem df;

	private ToolStripMenuItem dg;

	private UIButton dh;

	private Label di;

	private Label dj;

	private ToolStripMenuItem dk;

	private Label dl;

	private ToolStripMenuItem dm;

	private ToolStripMenuItem dn;

	private ToolStripMenuItem @do;

	private ToolStripSeparator dp;

	private ToolStripMenuItem dq;

	private ToolStripSeparator dr;

	private ToolStripMenuItem ds;

	private ToolStripSeparator dt;

	private ToolStripMenuItem du;

	private ToolStripSeparator dv;

	private ToolStripMenuItem dw;

	private ToolStripSeparator dx;

	private ToolStripMenuItem dy;

	private ToolStripSeparator dz;

	private ToolStripMenuItem d0;

	private ToolStripMenuItem d1;

	private ToolStripSeparator d2;

	private ToolStripMenuItem d3;

	private ToolStripSeparator d4;

	private ToolStripMenuItem d5;

	private ToolStripSeparator d6;

	private ToolStripMenuItem d7;

	private ToolStripMenuItem d8;

	public asdb3()
	{
		b();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
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
						num = 5;
						continue;
					}
					goto case 2;
				case 4:
					num = 2;
					continue;
				case 1:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					flag = this.m_a == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 2:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Obj, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected Obj, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected Obj, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected Obj, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected Obj, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected Obj, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Expected Obj, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected Obj, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Expected Obj, but got Unknown
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Expected Obj, but got Unknown
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Expected Obj, but got Unknown
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected Obj, but got Unknown
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected Obj, but got Unknown
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected Obj, but got Unknown
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected Obj, but got Unknown
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f9: Expected Obj, but got Unknown
		//IL_1285: Unknown result type (might be due to invalid IL or missing references)
		//IL_128f: Expected Obj, but got Unknown
		//IL_131b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1325: Expected Obj, but got Unknown
		//IL_13b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Expected Obj, but got Unknown
		//IL_1447: Unknown result type (might be due to invalid IL or missing references)
		//IL_1451: Expected Obj, but got Unknown
		//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e7: Expected Obj, but got Unknown
		//IL_1573: Unknown result type (might be due to invalid IL or missing references)
		//IL_157d: Expected Obj, but got Unknown
		//IL_1616: Unknown result type (might be due to invalid IL or missing references)
		//IL_1620: Expected Obj, but got Unknown
		//IL_174b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1755: Expected Obj, but got Unknown
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Expected Obj, but got Unknown
		//IL_1877: Unknown result type (might be due to invalid IL or missing references)
		//IL_1881: Expected Obj, but got Unknown
		//IL_190d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1917: Expected Obj, but got Unknown
		//IL_19a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ad: Expected Obj, but got Unknown
		//IL_1a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a43: Expected Obj, but got Unknown
		//IL_1bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be4: Expected Obj, but got Unknown
		//IL_1c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4e: Expected Obj, but got Unknown
		//IL_1c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6a: Expected Obj, but got Unknown
		//IL_1cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d06: Expected Obj, but got Unknown
		//IL_1d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d37: Expected Obj, but got Unknown
		//IL_1dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd3: Expected Obj, but got Unknown
		//IL_1de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1def: Expected Obj, but got Unknown
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8b: Expected Obj, but got Unknown
		//IL_1eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec3: Expected Obj, but got Unknown
		//IL_1f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5f: Expected Obj, but got Unknown
		//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f93: Expected Obj, but got Unknown
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_203f: Expected Obj, but got Unknown
		//IL_20e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ee: Expected Obj, but got Unknown
		//IL_21b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21be: Expected Obj, but got Unknown
		//IL_21e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21eb: Expected Obj, but got Unknown
		//IL_239a: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a4: Expected Obj, but got Unknown
		//IL_2565: Unknown result type (might be due to invalid IL or missing references)
		//IL_256f: Expected Obj, but got Unknown
		//IL_25f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fd: Expected Obj, but got Unknown
		//IL_26b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26be: Expected Obj, but got Unknown
		//IL_2775: Unknown result type (might be due to invalid IL or missing references)
		//IL_277f: Expected Obj, but got Unknown
		//IL_2811: Unknown result type (might be due to invalid IL or missing references)
		//IL_281b: Expected Obj, but got Unknown
		//IL_282d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2837: Expected Obj, but got Unknown
		//IL_28c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d3: Expected Obj, but got Unknown
		//IL_28fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2904: Expected Obj, but got Unknown
		//IL_2990: Unknown result type (might be due to invalid IL or missing references)
		//IL_299a: Expected Obj, but got Unknown
		//IL_2a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a30: Expected Obj, but got Unknown
		//IL_2a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a61: Expected Obj, but got Unknown
		//IL_2ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ade: Expected Obj, but got Unknown
		//IL_2af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afa: Expected Obj, but got Unknown
		//IL_2b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b75: Expected Obj, but got Unknown
		//IL_2f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f31: Expected Obj, but got Unknown
		//IL_2f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8d: Expected Obj, but got Unknown
		//IL_2f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa9: Expected Obj, but got Unknown
		//IL_303b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3045: Expected Obj, but got Unknown
		//IL_3068: Unknown result type (might be due to invalid IL or missing references)
		//IL_3072: Expected Obj, but got Unknown
		//IL_3104: Unknown result type (might be due to invalid IL or missing references)
		//IL_310e: Expected Obj, but got Unknown
		//IL_3120: Unknown result type (might be due to invalid IL or missing references)
		//IL_312a: Expected Obj, but got Unknown
		//IL_31bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c6: Expected Obj, but got Unknown
		//IL_31e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f3: Expected Obj, but got Unknown
		//IL_3285: Unknown result type (might be due to invalid IL or missing references)
		//IL_328f: Expected Obj, but got Unknown
		//IL_32a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ab: Expected Obj, but got Unknown
		//IL_333d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3347: Expected Obj, but got Unknown
		//IL_3375: Unknown result type (might be due to invalid IL or missing references)
		//IL_337f: Expected Obj, but got Unknown
		//IL_3431: Unknown result type (might be due to invalid IL or missing references)
		//IL_343b: Expected Obj, but got Unknown
		//IL_344d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3457: Expected Obj, but got Unknown
		//IL_34e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f3: Expected Obj, but got Unknown
		//IL_351a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3524: Expected Obj, but got Unknown
		//IL_358e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3598: Expected Obj, but got Unknown
		//IL_35aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b4: Expected Obj, but got Unknown
		//IL_36bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c5: Expected Obj, but got Unknown
		//IL_3751: Unknown result type (might be due to invalid IL or missing references)
		//IL_375b: Expected Obj, but got Unknown
		//IL_37e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f1: Expected Obj, but got Unknown
		//IL_387d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3887: Expected Obj, but got Unknown
		//IL_3979: Unknown result type (might be due to invalid IL or missing references)
		//IL_3983: Expected Obj, but got Unknown
		//IL_3a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a19: Expected Obj, but got Unknown
		//IL_3aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab5: Expected Obj, but got Unknown
		//IL_3ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ae2: Expected Obj, but got Unknown
		//IL_3c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c53: Expected Obj, but got Unknown
		//IL_3cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce9: Expected Obj, but got Unknown
		//IL_3d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d7f: Expected Obj, but got Unknown
		//IL_3e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e1b: Expected Obj, but got Unknown
		//IL_3e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e53: Expected Obj, but got Unknown
		//IL_3eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef6: Expected Obj, but got Unknown
		//IL_3f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9d: Expected Obj, but got Unknown
		//IL_4012: Unknown result type (might be due to invalid IL or missing references)
		//IL_401c: Expected Obj, but got Unknown
		//IL_40a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b2: Expected Obj, but got Unknown
		//IL_413e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4148: Expected Obj, but got Unknown
		//IL_41b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_41bc: Expected Obj, but got Unknown
		//IL_44e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_44eb: Expected Obj, but got Unknown
		//IL_45a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_45af: Expected Obj, but got Unknown
		//IL_4667: Unknown result type (might be due to invalid IL or missing references)
		//IL_4671: Expected Obj, but got Unknown
		//IL_4713: Unknown result type (might be due to invalid IL or missing references)
		//IL_471d: Expected Obj, but got Unknown
		//IL_47cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d5: Expected Obj, but got Unknown
		//IL_487b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4885: Expected Obj, but got Unknown
		//IL_4947: Unknown result type (might be due to invalid IL or missing references)
		//IL_4951: Expected Obj, but got Unknown
		//IL_4a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a11: Expected Obj, but got Unknown
		//IL_4aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_4af7: Expected Obj, but got Unknown
		//IL_4ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bab: Expected Obj, but got Unknown
		//IL_4c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c7b: Expected Obj, but got Unknown
		//IL_4d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d3d: Expected Obj, but got Unknown
		//IL_4e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e49: Expected Obj, but got Unknown
		//IL_4e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e9f: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb3));
		this.m_b = new MenuStrip();
		this.m_c = new ToolStripMenuItem();
		b6 = new ToolStripMenuItem();
		this.m_w = new ToolStripMenuItem();
		cf = new ToolStripSeparator();
		this.m_bl = new ToolStripMenuItem();
		cg = new ToolStripSeparator();
		b1 = new ToolStripMenuItem();
		ch = new ToolStripSeparator();
		this.m_l = new ToolStripMenuItem();
		ci = new ToolStripSeparator();
		this.m_k = new ToolStripMenuItem();
		cj = new ToolStripSeparator();
		this.m_j = new ToolStripMenuItem();
		ck = new ToolStripSeparator();
		this.m_r = new ToolStripMenuItem();
		cl = new ToolStripSeparator();
		this.m_bt = new ToolStripMenuItem();
		cm = new ToolStripSeparator();
		b2 = new ToolStripMenuItem();
		dg = new ToolStripMenuItem();
		d7 = new ToolStripMenuItem();
		this.m_d = new ToolStripMenuItem();
		this.m_e = new ToolStripMenuItem();
		ce = new ToolStripSeparator();
		this.m_bv = new ToolStripMenuItem();
		cn = new ToolStripSeparator();
		this.m_bj = new ToolStripMenuItem();
		co = new ToolStripSeparator();
		this.m_bm = new ToolStripMenuItem();
		cp = new ToolStripSeparator();
		this.m_bn = new ToolStripMenuItem();
		cq = new ToolStripSeparator();
		this.m_bu = new ToolStripMenuItem();
		this.m_f = new ToolStripSeparator();
		this.m_bw = new ToolStripMenuItem();
		bx = new ToolStripSeparator();
		this.m_bp = new ToolStripMenuItem();
		d2 = new ToolStripSeparator();
		d3 = new ToolStripMenuItem();
		this.m_bo = new ToolStripMenuItem();
		d8 = new ToolStripMenuItem();
		cr = new ToolStripSeparator();
		this.m_bq = new ToolStripMenuItem();
		cs = new ToolStripSeparator();
		b3 = new ToolStripMenuItem();
		ct = new ToolStripSeparator();
		this.m_bs = new ToolStripMenuItem();
		cu = new ToolStripSeparator();
		this.m_br = new ToolStripMenuItem();
		d4 = new ToolStripSeparator();
		dm = new ToolStripMenuItem();
		this.m_aa = new ToolStripMenuItem();
		this.m_ab = new ToolStripMenuItem();
		this.m_bb = new ToolStripSeparator();
		this.m_ac = new ToolStripMenuItem();
		this.m_bc = new ToolStripSeparator();
		this.m_a4 = new ToolStripMenuItem();
		this.m_bd = new ToolStripSeparator();
		by = new ToolStripMenuItem();
		cv = new ToolStripSeparator();
		bz = new ToolStripMenuItem();
		b0 = new ToolStripSeparator();
		b4 = new ToolStripMenuItem();
		b5 = new ToolStripSeparator();
		b7 = new ToolStripMenuItem();
		b8 = new ToolStripSeparator();
		c7 = new ToolStripMenuItem();
		c8 = new ToolStripMenuItem();
		c9 = new ToolStripSeparator();
		da = new ToolStripMenuItem();
		db = new ToolStripSeparator();
		b9 = new ToolStripMenuItem();
		cb = new ToolStripMenuItem();
		cc = new ToolStripSeparator();
		cd = new ToolStripMenuItem();
		dc = new ToolStripSeparator();
		c1 = new ToolStripMenuItem();
		c2 = new ToolStripMenuItem();
		c5 = new ToolStripSeparator();
		c3 = new ToolStripMenuItem();
		c6 = new ToolStripSeparator();
		c4 = new ToolStripMenuItem();
		ca = new ToolStripSeparator();
		this.m_ad = new ToolStripMenuItem();
		this.m_af = new ToolStripSeparator();
		this.m_ae = new ToolStripMenuItem();
		this.m_be = new ToolStripSeparator();
		this.m_ba = new ToolStripMenuItem();
		this.m_bf = new ToolStripSeparator();
		this.m_ah = new ToolStripMenuItem();
		this.m_ag = new ToolStripMenuItem();
		this.m_bg = new ToolStripMenuItem();
		this.m_a5 = new ToolStripMenuItem();
		this.m_a6 = new ToolStripMenuItem();
		this.m_a7 = new ToolStripMenuItem();
		this.m_bh = new ToolStripMenuItem();
		this.m_a8 = new ToolStripMenuItem();
		this.m_a9 = new ToolStripMenuItem();
		this.m_bi = new ToolStripMenuItem();
		dn = new ToolStripMenuItem();
		@do = new ToolStripMenuItem();
		dp = new ToolStripSeparator();
		dq = new ToolStripMenuItem();
		dr = new ToolStripSeparator();
		ds = new ToolStripMenuItem();
		dt = new ToolStripSeparator();
		du = new ToolStripMenuItem();
		dv = new ToolStripSeparator();
		dw = new ToolStripMenuItem();
		dx = new ToolStripSeparator();
		dy = new ToolStripMenuItem();
		dz = new ToolStripSeparator();
		d5 = new ToolStripMenuItem();
		d6 = new ToolStripSeparator();
		d0 = new ToolStripMenuItem();
		d1 = new ToolStripMenuItem();
		this.m_ao = new ToolStripMenuItem();
		this.m_as = new ToolStripMenuItem();
		cw = new ToolStripSeparator();
		this.m_ap = new ToolStripMenuItem();
		cx = new ToolStripSeparator();
		this.m_aq = new ToolStripMenuItem();
		cy = new ToolStripSeparator();
		this.m_ar = new ToolStripMenuItem();
		this.m_at = new ToolStripMenuItem();
		this.m_au = new ToolStripMenuItem();
		cz = new ToolStripSeparator();
		this.m_aw = new ToolStripMenuItem();
		c0 = new ToolStripSeparator();
		this.m_av = new ToolStripMenuItem();
		this.m_g = new ToolStripMenuItem();
		this.m_bk = new ToolStripMenuItem();
		this.m_ai = new ToolStripSeparator();
		this.m_ay = new ToolStripMenuItem();
		this.m_az = new ToolStripSeparator();
		this.m_a0 = new ToolStripMenuItem();
		this.m_a1 = new ToolStripSeparator();
		this.m_a2 = new ToolStripMenuItem();
		this.m_a3 = new ToolStripSeparator();
		this.m_aj = new ToolStripMenuItem();
		this.m_ak = new ToolStripSeparator();
		df = new ToolStripMenuItem();
		this.m_al = new ToolStripMenuItem();
		this.m_am = new ToolStripSeparator();
		this.m_h = new ToolStripMenuItem();
		this.m_an = new ToolStripSeparator();
		this.m_i = new ToolStripMenuItem();
		dk = new ToolStripMenuItem();
		this.m_x = new ToolStripMenuItem();
		this.m_y = new ToolStripMenuItem();
		this.m_z = new ToolStripMenuItem();
		this.m_p = new ToolStripMenuItem();
		this.m_q = new ToolStripMenuItem();
		this.m_m = new ToolStripMenuItem();
		this.m_o = new ToolStripMenuItem();
		this.m_n = new ToolStripMenuItem();
		this.m_s = new Label();
		this.m_t = new Label();
		this.m_u = new Label();
		this.m_v = new Label();
		this.m_ax = new PictureBox();
		dd = new Label();
		de = new Label();
		dh = new UIButton();
		di = new Label();
		dj = new Label();
		dl = new Label();
		((Control)this.m_b).SuspendLayout();
		((ISupportInitialize)this.m_ax).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStrip)this.m_b).ImageScalingSize = new Size(20, 20);
		((ToolStrip)this.m_b).Items.AddRange(new ToolStripItem[12]
		{
			(ToolStripItem)this.m_c,
			(ToolStripItem)this.m_d,
			(ToolStripItem)this.m_bo,
			(ToolStripItem)this.m_aa,
			(ToolStripItem)this.m_a5,
			(ToolStripItem)dn,
			(ToolStripItem)this.m_ao,
			(ToolStripItem)this.m_at,
			(ToolStripItem)this.m_g,
			(ToolStripItem)this.m_x,
			(ToolStripItem)this.m_p,
			(ToolStripItem)this.m_q
		});
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "menuStrip1";
		((Control)this.m_b).RightToLeft = (RightToLeft)1;
		((Control)this.m_b).Size = new Size(994, 34);
		((Control)this.m_b).TabIndex = 51;
		((Control)this.m_b).Text = "menuStrip1";
		((Control)this.m_b).Visible = false;
		((ToolStripDropDownItem)this.m_c).DropDownItems.AddRange(new ToolStripItem[20]
		{
			(ToolStripItem)b6,
			(ToolStripItem)this.m_w,
			(ToolStripItem)cf,
			(ToolStripItem)this.m_bl,
			(ToolStripItem)cg,
			(ToolStripItem)b1,
			(ToolStripItem)ch,
			(ToolStripItem)this.m_l,
			(ToolStripItem)ci,
			(ToolStripItem)this.m_k,
			(ToolStripItem)cj,
			(ToolStripItem)this.m_j,
			(ToolStripItem)ck,
			(ToolStripItem)this.m_r,
			(ToolStripItem)cl,
			(ToolStripItem)this.m_bt,
			(ToolStripItem)cm,
			(ToolStripItem)b2,
			(ToolStripItem)dg,
			(ToolStripItem)d7
		});
		((ToolStripItem)this.m_c).Image = (Image)(object)menu.base1;
		((ToolStripItem)this.m_c).Name = "tool3";
		((ToolStripItem)this.m_c).Size = new Size(122, 30);
		((ToolStripItem)this.m_c).Text = "اطلاعات پایه   ";
		((ToolStripItem)b6).ForeColor = Color.FromArgb(64, 0, 0);
		((ToolStripItem)b6).Image = (Image)(object)menu.select3;
		((ToolStripItem)b6).Name = "toolfrmSchool";
		((ToolStripItem)b6).Size = new Size(328, 30);
		((ToolStripItem)b6).Text = "مشخصات مکتب";
		((ToolStripItem)b6).Click += y;
		((ToolStripItem)this.m_w).Image = (Image)componentResourceManager.GetObject("toolfrmPaye.Image");
		((ToolStripItem)this.m_w).Name = "toolfrmPaye";
		((ToolStripItem)this.m_w).Size = new Size(328, 30);
		((ToolStripItem)this.m_w).Text = "پایه ها";
		((ToolStripItem)this.m_w).Visible = false;
		((ToolStripItem)this.m_w).Click += bk;
		((ToolStripItem)cf).Name = "toolStripSeparator27";
		((ToolStripItem)cf).Size = new Size(325, 6);
		((ToolStripItem)this.m_bl).Image = (Image)componentResourceManager.GetObject("toolYearMaghtaCountDay.Image");
		((ToolStripItem)this.m_bl).Name = "toolYearMaghtaCountDay";
		((ToolStripItem)this.m_bl).Size = new Size(328, 30);
		((ToolStripItem)this.m_bl).Text = "ایام سال تعلیمی";
		((ToolStripItem)this.m_bl).Click += aq;
		((ToolStripItem)cg).Name = "toolStripSeparator28";
		((ToolStripItem)cg).Size = new Size(325, 6);
		((ToolStripItem)b1).Image = (Image)componentResourceManager.GetObject("toolfrmTosifConfig.Image");
		((ToolStripItem)b1).Name = "toolfrmTosifConfig";
		((ToolStripItem)b1).Size = new Size(328, 30);
		((ToolStripItem)b1).Text = "تنظیمات درجه بندی";
		((ToolStripItem)b1).Click += ac;
		((ToolStripItem)ch).Name = "toolStripSeparator29";
		((ToolStripItem)ch).Size = new Size(325, 6);
		((ToolStripItem)this.m_l).Image = (Image)componentResourceManager.GetObject("toolfrmCls.Image");
		((ToolStripItem)this.m_l).Name = "toolfrmCls";
		((ToolStripItem)this.m_l).Size = new Size(328, 30);
		((ToolStripItem)this.m_l).Text = "مدیریت صنوف";
		((ToolStripItem)this.m_l).Click += bu;
		((ToolStripItem)ci).Name = "toolStripSeparator30";
		((ToolStripItem)ci).Size = new Size(325, 6);
		((ToolStripItem)this.m_k).Image = (Image)componentResourceManager.GetObject("toolfrBook.Image");
		((ToolStripItem)this.m_k).Name = "toolfrBook";
		((ToolStripItem)this.m_k).Size = new Size(328, 30);
		((ToolStripItem)this.m_k).Text = "دروس";
		((ToolStripItem)this.m_k).Click += bv;
		((ToolStripItem)cj).Name = "toolStripSeparator31";
		((ToolStripItem)cj).Size = new Size(325, 6);
		((ToolStripItem)this.m_j).Image = (Image)componentResourceManager.GetObject("toolfrmTeacher.Image");
		((ToolStripItem)this.m_j).Name = "toolfrmTeacher";
		((ToolStripItem)this.m_j).Size = new Size(328, 30);
		((ToolStripItem)this.m_j).Text = "لیست معلمان";
		((ToolStripItem)this.m_j).Click += bp;
		((ToolStripItem)ck).Name = "toolStripSeparator32";
		((ToolStripItem)ck).Size = new Size(325, 6);
		((ToolStripItem)this.m_r).Image = (Image)componentResourceManager.GetObject("toolfrmTchClass.Image");
		((ToolStripItem)this.m_r).Name = "toolfrmTchClass";
		((ToolStripItem)this.m_r).Size = new Size(328, 30);
		((ToolStripItem)this.m_r).Text = "معلم-درس";
		((ToolStripItem)this.m_r).Click += bo;
		((ToolStripItem)cl).Name = "toolStripSeparator34";
		((ToolStripItem)cl).Size = new Size(325, 6);
		((ToolStripItem)this.m_bt).Image = (Image)componentResourceManager.GetObject("toolDriver.Image");
		((ToolStripItem)this.m_bt).Name = "toolDriver";
		((ToolStripItem)this.m_bt).Size = new Size(328, 30);
		((ToolStripItem)this.m_bt).Text = "لیست رانندگان";
		((ToolStripItem)this.m_bt).Click += ah;
		((ToolStripItem)cm).Name = "toolStripSeparator33";
		((ToolStripItem)cm).Size = new Size(325, 6);
		((ToolStripItem)b2).Image = (Image)componentResourceManager.GetObject("toolOst.Image");
		((ToolStripItem)b2).Name = "toolOst";
		((ToolStripItem)b2).Size = new Size(328, 30);
		((ToolStripItem)b2).Text = "لیست ولسوالی ها";
		((ToolStripItem)b2).Click += ab;
		((ToolStripItem)dg).Image = (Image)componentResourceManager.GetObject("toolfrmUser.Image");
		((ToolStripItem)dg).Name = "toolfrmUser";
		((ToolStripItem)dg).Size = new Size(328, 30);
		((ToolStripItem)dg).Text = "مدیریت کاربران";
		((ToolStripItem)dg).Click += o;
		((ToolStripItem)d7).Image = (Image)componentResourceManager.GetObject("toolSetMark100.Image");
		((ToolStripItem)d7).Name = "toolSetMark100";
		((ToolStripItem)d7).Size = new Size(328, 30);
		((ToolStripItem)d7).Text = "ورود نمره سالانه از 100 برای کل دانش آموزان";
		((ToolStripItem)d7).Click += a;
		((ToolStripDropDownItem)this.m_d).DropDownItems.AddRange(new ToolStripItem[17]
		{
			(ToolStripItem)this.m_e,
			(ToolStripItem)ce,
			(ToolStripItem)this.m_bv,
			(ToolStripItem)cn,
			(ToolStripItem)this.m_bj,
			(ToolStripItem)co,
			(ToolStripItem)this.m_bm,
			(ToolStripItem)cp,
			(ToolStripItem)this.m_bn,
			(ToolStripItem)cq,
			(ToolStripItem)this.m_bu,
			(ToolStripItem)this.m_f,
			(ToolStripItem)this.m_bw,
			(ToolStripItem)bx,
			(ToolStripItem)this.m_bp,
			(ToolStripItem)d2,
			(ToolStripItem)d3
		});
		((ToolStripItem)this.m_d).Image = (Image)(object)menu.student;
		((ToolStripItem)this.m_d).Name = "tool2";
		((ToolStripItem)this.m_d).Size = new Size(116, 30);
		((ToolStripItem)this.m_d).Text = "امور متعلمین";
		((ToolStripItem)this.m_e).Image = (Image)componentResourceManager.GetObject("toolStd.Image");
		((ToolStripItem)this.m_e).Name = "toolStd";
		((ToolStripItem)this.m_e).Size = new Size(352, 30);
		((ToolStripItem)this.m_e).Text = "لیست شاگردان و ثبت نام";
		((ToolStripItem)this.m_e).Click += bt;
		((ToolStripItem)ce).Name = "toolStripSeparator21";
		((ToolStripItem)ce).Size = new Size(349, 6);
		((ToolStripItem)this.m_bv).Image = (Image)componentResourceManager.GetObject("toolImportStd.Image");
		((ToolStripItem)this.m_bv).Name = "toolImportStd";
		((ToolStripItem)this.m_bv).Size = new Size(352, 30);
		((ToolStripItem)this.m_bv).Text = "ثبت دانش آموزان از فایل اکسل";
		((ToolStripItem)this.m_bv).Click += af;
		((ToolStripItem)cn).Name = "toolStripSeparator22";
		((ToolStripItem)cn).Size = new Size(349, 6);
		((ToolStripItem)this.m_bj).Image = (Image)componentResourceManager.GetObject("toolshaghe.Image");
		((ToolStripItem)this.m_bj).Name = "toolshaghe";
		((ToolStripItem)this.m_bj).Size = new Size(352, 30);
		((ToolStripItem)this.m_bj).Text = "مدیریت شقه های صنف";
		((ToolStripItem)this.m_bj).Click += @as;
		((ToolStripItem)co).Name = "toolStripSeparator23";
		((ToolStripItem)co).Size = new Size(349, 6);
		((ToolStripItem)this.m_bm).Image = (Image)componentResourceManager.GetObject("toolHazeri1.Image");
		((ToolStripItem)this.m_bm).Name = "toolHazeri1";
		((ToolStripItem)this.m_bm).Size = new Size(352, 30);
		((ToolStripItem)this.m_bm).Text = "ثبت تعداد حاضری چهار و نیم ماهه";
		((ToolStripItem)this.m_bm).Click += ap;
		((ToolStripItem)cp).Name = "toolStripSeparator35";
		((ToolStripItem)cp).Size = new Size(349, 6);
		((ToolStripItem)this.m_bn).Image = (Image)componentResourceManager.GetObject("toolHazeri2.Image");
		((ToolStripItem)this.m_bn).Name = "toolHazeri2";
		((ToolStripItem)this.m_bn).Size = new Size(352, 30);
		((ToolStripItem)this.m_bn).Text = "ثبت تعداد حاضری سالانه";
		((ToolStripItem)this.m_bn).Click += ao;
		((ToolStripItem)cq).Name = "toolStripSeparator24";
		((ToolStripItem)cq).Size = new Size(349, 6);
		((ToolStripItem)this.m_bu).Image = (Image)componentResourceManager.GetObject("toolDriverStd.Image");
		((ToolStripItem)this.m_bu).Name = "toolDriverStd";
		((ToolStripItem)this.m_bu).Size = new Size(352, 30);
		((ToolStripItem)this.m_bu).Text = "اختصاص راننده به دانش آموز";
		((ToolStripItem)this.m_bu).Click += ag;
		((ToolStripItem)this.m_f).Name = "toolStripSeparator2";
		((ToolStripItem)this.m_f).Size = new Size(349, 6);
		((ToolStripItem)this.m_bw).Image = (Image)componentResourceManager.GetObject("toolfrmlistStdSearch.Image");
		((ToolStripItem)this.m_bw).Name = "toolfrmlistStdSearch";
		((ToolStripItem)this.m_bw).Size = new Size(352, 30);
		((ToolStripItem)this.m_bw).Text = "خروجی دانش آموزان بر اساس فیلتر دلخواه";
		((ToolStripItem)this.m_bw).Click += ae;
		((ToolStripItem)bx).Name = "toolStripSeparator1";
		((ToolStripItem)bx).Size = new Size(349, 6);
		((ToolStripItem)this.m_bp).Image = (Image)componentResourceManager.GetObject("toolfrmRptAFLsit.Image");
		((ToolStripItem)this.m_bp).Name = "toolfrmRptAFLsit";
		this.m_bp.ShowShortcutKeys = false;
		((ToolStripItem)this.m_bp).Size = new Size(352, 30);
		((ToolStripItem)this.m_bp).Text = "گزارشات";
		((ToolStripItem)this.m_bp).Click += al;
		((ToolStripItem)d2).Name = "toolStripSeparator49";
		((ToolStripItem)d2).Size = new Size(349, 6);
		((ToolStripItem)d3).Image = (Image)componentResourceManager.GetObject("toolfrmCommentList2.Image");
		((ToolStripItem)d3).Name = "toolfrmCommentList2";
		((ToolStripItem)d3).Size = new Size(352, 30);
		((ToolStripItem)d3).Text = "لیست یادداشت های ثبت شده برای دانش آموزان";
		((ToolStripItem)d3).Click += e;
		((ToolStripDropDownItem)this.m_bo).DropDownItems.AddRange(new ToolStripItem[11]
		{
			(ToolStripItem)d8,
			(ToolStripItem)cr,
			(ToolStripItem)this.m_bq,
			(ToolStripItem)cs,
			(ToolStripItem)b3,
			(ToolStripItem)ct,
			(ToolStripItem)this.m_bs,
			(ToolStripItem)cu,
			(ToolStripItem)this.m_br,
			(ToolStripItem)d4,
			(ToolStripItem)dm
		});
		((ToolStripItem)this.m_bo).Image = (Image)(object)menu.finance;
		((ToolStripItem)this.m_bo).Name = "toolMali";
		((ToolStripItem)this.m_bo).Size = new Size(100, 30);
		((ToolStripItem)this.m_bo).Text = "امور مالی  ";
		((ToolStripItem)d8).Image = (Image)componentResourceManager.GetObject("toolTakhfif.Image");
		((ToolStripItem)d8).Name = "toolTakhfif";
		((ToolStripItem)d8).Size = new Size(352, 30);
		((ToolStripItem)d8).Text = "تعریف تخفیف";
		((ToolStripItem)d8).Click += am;
		((ToolStripItem)cr).Name = "toolStripSeparator36";
		((ToolStripItem)cr).Size = new Size(349, 6);
		((ToolStripItem)this.m_bq).Image = (Image)componentResourceManager.GetObject("toolPaymentAdd.Image");
		((ToolStripItem)this.m_bq).Name = "toolPaymentAdd";
		((ToolStripItem)this.m_bq).Size = new Size(352, 30);
		((ToolStripItem)this.m_bq).Text = "مدیرت پرداخت ها";
		((ToolStripItem)this.m_bq).Click += ak;
		((ToolStripItem)cs).Name = "toolStripSeparator37";
		((ToolStripItem)cs).Size = new Size(349, 6);
		((ToolStripItem)b3).Image = (Image)componentResourceManager.GetObject("toolfrmPaymentList.Image");
		((ToolStripItem)b3).Name = "toolfrmPaymentList";
		((ToolStripItem)b3).Size = new Size(352, 30);
		((ToolStripItem)b3).Text = "لیست کلیه پرداخت ها";
		((ToolStripItem)b3).Click += aa;
		((ToolStripItem)ct).Name = "toolStripSeparator38";
		((ToolStripItem)ct).Size = new Size(349, 6);
		((ToolStripItem)this.m_bs).Image = (Image)componentResourceManager.GetObject("toolRptBalance.Image");
		((ToolStripItem)this.m_bs).Name = "toolRptBalance";
		((ToolStripItem)this.m_bs).Size = new Size(352, 30);
		((ToolStripItem)this.m_bs).Text = "دعوت پرداخت فیس بر اساس فصل";
		((ToolStripItem)this.m_bs).Click += ai;
		((ToolStripItem)cu).Name = "toolStripSeparator39";
		((ToolStripItem)cu).Size = new Size(349, 6);
		((ToolStripItem)this.m_br).Image = (Image)componentResourceManager.GetObject("toolRptPayment.Image");
		((ToolStripItem)this.m_br).Name = "toolRptPayment";
		((ToolStripItem)this.m_br).Size = new Size(352, 30);
		((ToolStripItem)this.m_br).Text = "گزارشات";
		((ToolStripItem)this.m_br).Click += aj;
		((ToolStripItem)d4).Name = "toolStripSeparator53";
		((ToolStripItem)d4).Size = new Size(349, 6);
		((ToolStripItem)dm).Image = (Image)componentResourceManager.GetObject("toolfrmCommentList.Image");
		((ToolStripItem)dm).Name = "toolfrmCommentList";
		((ToolStripItem)dm).Size = new Size(352, 30);
		((ToolStripItem)dm).Text = "لیست یادداشت های ثبت شده برای دانش آموزان";
		((ToolStripItem)dm).Click += l;
		((ToolStripDropDownItem)this.m_aa).DropDownItems.AddRange(new ToolStripItem[29]
		{
			(ToolStripItem)this.m_ab,
			(ToolStripItem)this.m_bb,
			(ToolStripItem)this.m_ac,
			(ToolStripItem)this.m_bc,
			(ToolStripItem)this.m_a4,
			(ToolStripItem)this.m_bd,
			(ToolStripItem)by,
			(ToolStripItem)cv,
			(ToolStripItem)bz,
			(ToolStripItem)b0,
			(ToolStripItem)b4,
			(ToolStripItem)b5,
			(ToolStripItem)b7,
			(ToolStripItem)b8,
			(ToolStripItem)c7,
			(ToolStripItem)db,
			(ToolStripItem)b9,
			(ToolStripItem)dc,
			(ToolStripItem)c1,
			(ToolStripItem)ca,
			(ToolStripItem)this.m_ad,
			(ToolStripItem)this.m_af,
			(ToolStripItem)this.m_ae,
			(ToolStripItem)this.m_be,
			(ToolStripItem)this.m_ba,
			(ToolStripItem)this.m_bf,
			(ToolStripItem)this.m_ah,
			(ToolStripItem)this.m_ag,
			(ToolStripItem)this.m_bg
		});
		((ToolStripItem)this.m_aa).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((ToolStripItem)this.m_aa).Image = (Image)(object)menu.mark;
		((ToolStripItem)this.m_aa).Name = "toolExam2";
		((ToolStripItem)this.m_aa).Size = new Size(108, 30);
		((ToolStripItem)this.m_aa).Text = "امور تعلیمی";
		((ToolStripItem)this.m_ab).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_ab).Image = (Image)componentResourceManager.GetObject("toolStripMenuItem6.Image");
		((ToolStripItem)this.m_ab).Name = "toolStripMenuItem6";
		((ToolStripItem)this.m_ab).Size = new Size(284, 34);
		((ToolStripItem)this.m_ab).Text = "تعریف دوره";
		((ToolStripItem)this.m_ab).Click += bs;
		((ToolStripItem)this.m_bb).Name = "toolStripSeparator11";
		((ToolStripItem)this.m_bb).Size = new Size(281, 6);
		((ToolStripItem)this.m_ac).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_ac).ForeColor = Color.FromArgb(0, 0, 64);
		((ToolStripItem)this.m_ac).Image = (Image)componentResourceManager.GetObject("toolStripMenuItem7.Image");
		((ToolStripItem)this.m_ac).Name = "toolStripMenuItem7";
		((ToolStripItem)this.m_ac).Size = new Size(284, 34);
		((ToolStripItem)this.m_ac).Text = "ورود نمرات";
		((ToolStripItem)this.m_ac).Click += br;
		((ToolStripItem)this.m_bc).Name = "toolStripSeparator12";
		((ToolStripItem)this.m_bc).Size = new Size(281, 6);
		((ToolStripItem)this.m_a4).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_a4).Image = (Image)componentResourceManager.GetObject("toolMarkEntryOne.Image");
		((ToolStripItem)this.m_a4).Name = "toolMarkEntryOne";
		((ToolStripItem)this.m_a4).Size = new Size(284, 34);
		((ToolStripItem)this.m_a4).Text = "ورود و اصلاح نمرات فردی";
		((ToolStripItem)this.m_a4).Click += a1;
		((ToolStripItem)this.m_bd).Name = "toolStripSeparator13";
		((ToolStripItem)this.m_bd).Size = new Size(281, 6);
		((ToolStripItem)by).Font = new Font("B Nazanin", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)by).ForeColor = Color.FromArgb(0, 192, 192);
		((ToolStripItem)by).Image = (Image)componentResourceManager.GetObject("toolCreateXlsToMarkEntry.Image");
		((ToolStripItem)by).Name = "toolCreateXlsToMarkEntry";
		((ToolStripItem)by).Size = new Size(284, 34);
		((ToolStripItem)by).Text = "دریافت اکسل خام شاگردان برای ورود نمره";
		((ToolStripItem)by).Click += bd;
		((ToolStripItem)cv).Name = "toolStripSeparator40";
		((ToolStripItem)cv).Size = new Size(281, 6);
		((ToolStripItem)bz).Font = new Font("B Nazanin", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)bz).ForeColor = Color.FromArgb(0, 192, 0);
		((ToolStripItem)bz).Image = (Image)componentResourceManager.GetObject("toolImportMark.Image");
		((ToolStripItem)bz).Name = "toolImportMark";
		((ToolStripItem)bz).Size = new Size(284, 34);
		((ToolStripItem)bz).Text = "ورود نمرات دوره از فایل اکسل";
		((ToolStripItem)bz).Click += ad;
		((ToolStripItem)b0).Name = "toolStripSeparator16";
		((ToolStripItem)b0).Size = new Size(281, 6);
		((ToolStripItem)b4).ForeColor = Color.FromArgb(64, 0, 64);
		((ToolStripItem)b4).Image = (Image)componentResourceManager.GetObject("toolfrmSummaryResults.Image");
		((ToolStripItem)b4).Name = "toolfrmSummaryResults";
		((ToolStripItem)b4).Size = new Size(284, 34);
		((ToolStripItem)b4).Text = "ثبت خلص نتایج هر صنف";
		((ToolStripItem)b4).Click += z;
		((ToolStripItem)b5).Name = "toolStripSeparator17";
		((ToolStripItem)b5).Size = new Size(281, 6);
		((ToolStripItem)b7).ForeColor = Color.FromArgb(192, 64, 0);
		((ToolStripItem)b7).Image = (Image)componentResourceManager.GetObject("toolCommentKoll6.Image");
		((ToolStripItem)b7).Name = "toolCommentKoll6";
		((ToolStripItem)b7).Size = new Size(284, 34);
		((ToolStripItem)b7).Text = "ثبت توضیحات جدول نتایج";
		((ToolStripItem)b7).Click += x;
		((ToolStripItem)b8).Name = "toolStripSeparator18";
		((ToolStripItem)b8).Size = new Size(281, 6);
		((ToolStripDropDownItem)c7).DropDownItems.AddRange(new ToolStripItem[3]
		{
			(ToolStripItem)c8,
			(ToolStripItem)c9,
			(ToolStripItem)da
		});
		((ToolStripItem)c7).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)c7).ForeColor = Color.Red;
		((ToolStripItem)c7).Image = (Image)componentResourceManager.GetObject("toolfrmSetAcpTerm.Image");
		((ToolStripItem)c7).Name = "toolfrmSetAcpTerm";
		((ToolStripItem)c7).Size = new Size(284, 34);
		((ToolStripItem)c7).Text = "ثبت نتایج ";
		((ToolStripItem)c8).ForeColor = Color.FromArgb(64, 0, 0);
		((ToolStripItem)c8).Name = "toolfrmSetAcpTerm1";
		((ToolStripItem)c8).Size = new Size(259, 34);
		((ToolStripItem)c8).Text = "ثبت نتیجه چهار و نیم ماهه";
		((ToolStripItem)c8).Click += r;
		((ToolStripItem)c9).Name = "toolStripSeparator46";
		((ToolStripItem)c9).Size = new Size(256, 6);
		((ToolStripItem)da).ForeColor = Color.FromArgb(0, 0, 64);
		((ToolStripItem)da).Name = "toolfrmSetAcpTerm3";
		((ToolStripItem)da).Size = new Size(259, 34);
		((ToolStripItem)da).Text = "ثبت نتیجه نهایی";
		((ToolStripItem)da).Click += q;
		((ToolStripItem)db).Name = "toolStripSeparator48";
		((ToolStripItem)db).Size = new Size(281, 6);
		((ToolStripDropDownItem)b9).DropDownItems.AddRange(new ToolStripItem[3]
		{
			(ToolStripItem)cb,
			(ToolStripItem)cc,
			(ToolStripItem)cd
		});
		((ToolStripItem)b9).ForeColor = Color.Navy;
		((ToolStripItem)b9).Image = (Image)componentResourceManager.GetObject("toolfrmSetgTerm.Image");
		((ToolStripItem)b9).Name = "toolfrmSetgTerm";
		((ToolStripItem)b9).Size = new Size(284, 34);
		((ToolStripItem)b9).Text = "ثبت درجه صنف 12";
		((ToolStripItem)cb).ForeColor = Color.FromArgb(64, 0, 0);
		((ToolStripItem)cb).Name = "toolfrmSetgTerm1";
		((ToolStripItem)cb).Size = new Size(203, 30);
		((ToolStripItem)cb).Text = "درجه چهار و نیم ماهه";
		((ToolStripItem)cb).Click += w;
		((ToolStripItem)cc).Name = "toolStripSeparator20";
		((ToolStripItem)cc).Size = new Size(200, 6);
		((ToolStripItem)cd).ForeColor = Color.FromArgb(0, 0, 64);
		((ToolStripItem)cd).Name = "toolfrmSetgTerm3";
		((ToolStripItem)cd).Size = new Size(203, 30);
		((ToolStripItem)cd).Text = "درجه نهایی";
		((ToolStripItem)cd).Click += v;
		((ToolStripItem)dc).Name = "toolStripSeparator47";
		((ToolStripItem)dc).Size = new Size(281, 6);
		((ToolStripDropDownItem)c1).DropDownItems.AddRange(new ToolStripItem[5]
		{
			(ToolStripItem)c2,
			(ToolStripItem)c5,
			(ToolStripItem)c3,
			(ToolStripItem)c6,
			(ToolStripItem)c4
		});
		((ToolStripItem)c1).ForeColor = Color.Navy;
		((ToolStripItem)c1).Image = (Image)componentResourceManager.GetObject("toolStripMenuItem11.Image");
		((ToolStripItem)c1).Name = "toolStripMenuItem11";
		c1.ShowShortcutKeys = false;
		((ToolStripItem)c1).Size = new Size(284, 34);
		((ToolStripItem)c1).Text = "امور صنف دوازدهم";
		c2.Checked = true;
		c2.CheckState = (CheckState)1;
		((ToolStripItem)c2).ForeColor = Color.Navy;
		((ToolStripItem)c2).Image = (Image)componentResourceManager.GetObject("toolfrmMarkEntryAgo.Image");
		((ToolStripItem)c2).Name = "toolfrmMarkEntryAgo";
		((ToolStripItem)c2).Size = new Size(287, 30);
		((ToolStripItem)c2).Text = "ثبت نمرات سنوات قبل صنف دوازدهم";
		((ToolStripItem)c2).Click += u;
		((ToolStripItem)c5).Name = "toolStripSeparator25";
		((ToolStripItem)c5).Size = new Size(284, 6);
		c3.Checked = true;
		c3.CheckState = (CheckState)1;
		((ToolStripItem)c3).ForeColor = Color.Black;
		((ToolStripItem)c3).Image = (Image)componentResourceManager.GetObject("toolfrmHazeriAgo10.Image");
		((ToolStripItem)c3).Name = "toolfrmHazeriAgo10";
		((ToolStripItem)c3).Size = new Size(287, 30);
		((ToolStripItem)c3).Text = "ثبت حاضری سال دهم";
		((ToolStripItem)c3).Click += t;
		((ToolStripItem)c6).Name = "toolStripSeparator26";
		((ToolStripItem)c6).Size = new Size(284, 6);
		c4.Checked = true;
		c4.CheckState = (CheckState)1;
		((ToolStripItem)c4).ForeColor = Color.Navy;
		((ToolStripItem)c4).Image = (Image)componentResourceManager.GetObject("toolfrmHazeriAgo11.Image");
		((ToolStripItem)c4).Name = "toolfrmHazeriAgo11";
		((ToolStripItem)c4).Size = new Size(287, 30);
		((ToolStripItem)c4).Text = "ثبت حاضری سال یازدهم";
		((ToolStripItem)c4).Click += s;
		((ToolStripItem)ca).Name = "toolStripSeparator19";
		((ToolStripItem)ca).Size = new Size(281, 6);
		((ToolStripItem)this.m_ad).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_ad).Image = (Image)componentResourceManager.GetObject("toolRpt.Image");
		((ToolStripItem)this.m_ad).Name = "toolRpt";
		((ToolStripItem)this.m_ad).Size = new Size(284, 34);
		((ToolStripItem)this.m_ad).Text = " گزارشات";
		((ToolStripItem)this.m_ad).Click += bq;
		((ToolStripItem)this.m_af).Name = "toolStripSeparator3";
		((ToolStripItem)this.m_af).Size = new Size(281, 6);
		((ToolStripItem)this.m_ae).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_ae).ForeColor = Color.FromArgb(0, 0, 64);
		((ToolStripItem)this.m_ae).Image = (Image)componentResourceManager.GetObject("toolRptChart.Image");
		((ToolStripItem)this.m_ae).Name = "toolRptChart";
		((ToolStripItem)this.m_ae).Size = new Size(284, 34);
		((ToolStripItem)this.m_ae).Text = "گزارشات نموداری";
		((ToolStripItem)this.m_ae).Click += be;
		((ToolStripItem)this.m_be).Name = "toolStripSeparator14";
		((ToolStripItem)this.m_be).Size = new Size(281, 6);
		((ToolStripItem)this.m_ba).Image = (Image)componentResourceManager.GetObject("toolRptSelectStd.Image");
		((ToolStripItem)this.m_ba).Name = "toolRptSelectStd";
		((ToolStripItem)this.m_ba).Size = new Size(284, 34);
		((ToolStripItem)this.m_ba).Text = "چاپ اطلاع نامه بر اساس شاگرد";
		((ToolStripItem)this.m_ba).Click += aw;
		((ToolStripItem)this.m_bf).Name = "toolStripSeparator15";
		((ToolStripItem)this.m_bf).Size = new Size(281, 6);
		((ToolStripItem)this.m_ah).Font = new Font("B Nazanin", 7f, (FontStyle)1);
		((ToolStripItem)this.m_ah).ForeColor = Color.FromArgb(0, 0, 64);
		((ToolStripItem)this.m_ah).Image = (Image)componentResourceManager.GetObject("toolSms.Image");
		((ToolStripItem)this.m_ah).Name = "toolSms";
		((ToolStripItem)this.m_ah).Size = new Size(284, 34);
		((ToolStripItem)this.m_ah).Text = "دریافت فایل اکسل نمرات برای ارسال پیامک به اولیا";
		((ToolStripItem)this.m_ah).Visible = false;
		((ToolStripItem)this.m_ah).Click += bf;
		((ToolStripItem)this.m_ag).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStripItem)this.m_ag).Image = (Image)componentResourceManager.GetObject("toolfrmExportMarkToSite.Image");
		((ToolStripItem)this.m_ag).Name = "toolfrmExportMarkToSite";
		((ToolStripItem)this.m_ag).Size = new Size(284, 34);
		((ToolStripItem)this.m_ag).Text = "ارسال نمرات به سایت";
		((ToolStripItem)this.m_ag).Visible = false;
		((ToolStripItem)this.m_ag).Click += bg;
		((ToolStripItem)this.m_bg).Image = (Image)componentResourceManager.GetObject("toolfrmSendSmsMark_armaghan.Image");
		((ToolStripItem)this.m_bg).Name = "toolfrmSendSmsMark_armaghan";
		((ToolStripItem)this.m_bg).Size = new Size(284, 34);
		((ToolStripItem)this.m_bg).Text = "ارسال نمرات از طریق پیامک ";
		((ToolStripItem)this.m_bg).Visible = false;
		((ToolStripItem)this.m_bg).Click += av;
		((ToolStripDropDownItem)this.m_a5).DropDownItems.AddRange(new ToolStripItem[6]
		{
			(ToolStripItem)this.m_a6,
			(ToolStripItem)this.m_a7,
			(ToolStripItem)this.m_bh,
			(ToolStripItem)this.m_a8,
			(ToolStripItem)this.m_a9,
			(ToolStripItem)this.m_bi
		});
		((ToolStripItem)this.m_a5).Name = "toolStripMenuItem9";
		((ToolStripItem)this.m_a5).Size = new Size(71, 30);
		((ToolStripItem)this.m_a5).Text = "انضباطی";
		((ToolStripItem)this.m_a5).Visible = false;
		((ToolStripItem)this.m_a6).Name = "toolDisciplinaryCases1";
		((ToolStripItem)this.m_a6).Size = new Size(244, 30);
		((ToolStripItem)this.m_a6).Text = "تعریف مورد انضباطی";
		((ToolStripItem)this.m_a6).Click += a0;
		((ToolStripItem)this.m_a7).Name = "toolDisciplinaryCases2";
		((ToolStripItem)this.m_a7).Size = new Size(244, 30);
		((ToolStripItem)this.m_a7).Text = "تعریف موارد تشویقی";
		((ToolStripItem)this.m_a7).Click += az;
		((ToolStripItem)this.m_bh).Name = "toolDisciplinaryCases3";
		((ToolStripItem)this.m_bh).Size = new Size(244, 30);
		((ToolStripItem)this.m_bh).Text = "تعریف اخطارهای آموزشی";
		((ToolStripItem)this.m_bh).Click += au;
		((ToolStripItem)this.m_a8).Name = "toolfrmDisciplinaryAddAbsent";
		((ToolStripItem)this.m_a8).Size = new Size(244, 30);
		((ToolStripItem)this.m_a8).Text = "ثبت غیبت و تاخیر روزانه";
		((ToolStripItem)this.m_a8).Click += ay;
		((ToolStripItem)this.m_a9).Name = "toolfrmDisciplinaryAdd";
		((ToolStripItem)this.m_a9).Size = new Size(244, 30);
		((ToolStripItem)this.m_a9).Text = "ثبت موارد انضباطی و تشویقی";
		((ToolStripItem)this.m_a9).Click += ax;
		((ToolStripItem)this.m_bi).Name = "toolRptDis";
		((ToolStripItem)this.m_bi).Size = new Size(244, 30);
		((ToolStripItem)this.m_bi).Text = "گزارشات";
		((ToolStripItem)this.m_bi).Click += at;
		((ToolStripDropDownItem)dn).DropDownItems.AddRange(new ToolStripItem[16]
		{
			(ToolStripItem)@do,
			(ToolStripItem)dp,
			(ToolStripItem)dq,
			(ToolStripItem)dr,
			(ToolStripItem)ds,
			(ToolStripItem)dt,
			(ToolStripItem)du,
			(ToolStripItem)dv,
			(ToolStripItem)dw,
			(ToolStripItem)dx,
			(ToolStripItem)dy,
			(ToolStripItem)dz,
			(ToolStripItem)d5,
			(ToolStripItem)d6,
			(ToolStripItem)d0,
			(ToolStripItem)d1
		});
		((ToolStripItem)dn).ForeColor = Color.Fuchsia;
		((ToolStripItem)dn).Image = (Image)componentResourceManager.GetObject("toolStripMenuItem15.Image");
		((ToolStripItem)dn).Name = "toolStripMenuItem15";
		((ToolStripItem)dn).Size = new Size(129, 30);
		((ToolStripItem)dn).Text = "طراحی سربرگ ";
		((ToolStripItem)@do).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)@do).Image = (Image)componentResourceManager.GetObject("toolRptDynamic1.Image");
		((ToolStripItem)@do).Name = "toolRptDynamic1";
		((ToolStripItem)@do).Size = new Size(360, 30);
		((ToolStripItem)@do).Text = "طراحی سربرگ امتحانی";
		((ToolStripItem)@do).Click += k;
		((ToolStripItem)dp).Name = "toolStripSeparator50";
		((ToolStripItem)dp).Size = new Size(357, 6);
		((ToolStripItem)dq).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)dq).ForeColor = Color.Red;
		((ToolStripItem)dq).Image = (Image)componentResourceManager.GetObject("toolRptDynamic5.Image");
		((ToolStripItem)dq).Name = "toolRptDynamic5";
		((ToolStripItem)dq).Size = new Size(360, 30);
		((ToolStripItem)dq).Text = "طراحی سربرگ امتحانی چند صفحه ای";
		((ToolStripItem)dq).Click += j;
		((ToolStripItem)dr).Name = "toolStripSeparator63";
		((ToolStripItem)dr).Size = new Size(357, 6);
		((ToolStripItem)ds).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)ds).Image = (Image)componentResourceManager.GetObject("toolRptDynamic2.Image");
		((ToolStripItem)ds).Name = "toolRptDynamic2";
		((ToolStripItem)ds).Size = new Size(360, 30);
		((ToolStripItem)ds).Text = "طراحی دعوت نامه و ...";
		((ToolStripItem)ds).Click += i;
		((ToolStripItem)dt).Name = "toolStripSeparator51";
		((ToolStripItem)dt).Size = new Size(357, 6);
		((ToolStripItem)du).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)du).ForeColor = Color.Navy;
		((ToolStripItem)du).Image = (Image)componentResourceManager.GetObject("toolRptDynamic3.Image");
		((ToolStripItem)du).Name = "toolRptDynamic3";
		((ToolStripItem)du).Size = new Size(360, 30);
		((ToolStripItem)du).Text = "طراحی فرم(تعهدنامه انضباطی و ...)";
		((ToolStripItem)du).Click += h;
		((ToolStripItem)dv).Name = "toolStripSeparator52";
		((ToolStripItem)dv).Size = new Size(357, 6);
		((ToolStripItem)dw).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)dw).Image = (Image)componentResourceManager.GetObject("toolRptDynamic4.Image");
		((ToolStripItem)dw).Name = "toolRptDynamic4";
		((ToolStripItem)dw).Size = new Size(360, 30);
		((ToolStripItem)dw).Text = "طراحی کارت دانش آموزی و ...";
		((ToolStripItem)dw).Click += g;
		((ToolStripItem)dx).Name = "toolStripSeparator79";
		((ToolStripItem)dx).Size = new Size(357, 6);
		((ToolStripItem)dy).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)dy).ForeColor = Color.FromArgb(192, 0, 192);
		((ToolStripItem)dy).Image = (Image)componentResourceManager.GetObject("toolRptDynamic6.Image");
		((ToolStripItem)dy).Name = "toolRptDynamic6";
		((ToolStripItem)dy).Size = new Size(360, 30);
		((ToolStripItem)dy).Text = "طراحی کارت تبریک تولد";
		((ToolStripItem)dy).Click += f;
		((ToolStripItem)dz).Name = "toolStripSeparator80";
		((ToolStripItem)dz).Size = new Size(357, 6);
		((ToolStripItem)d5).BackColor = Color.FromArgb(192, 255, 192);
		((ToolStripItem)d5).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)d5).Image = (Image)componentResourceManager.GetObject("toolfrmActivStdSarbarg.Image");
		((ToolStripItem)d5).Name = "toolfrmActivStdSarbarg";
		((ToolStripItem)d5).Size = new Size(360, 30);
		((ToolStripItem)d5).Text = "فعال / غیرفعال کردن چاپ دانش آموزان در طراحی";
		((ToolStripItem)d5).Click += b;
		((ToolStripItem)d6).Name = "toolStripSeparator54";
		((ToolStripItem)d6).Size = new Size(357, 6);
		((ToolStripItem)d0).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)d0).ForeColor = Color.FromArgb(0, 64, 0);
		((ToolStripItem)d0).Image = (Image)componentResourceManager.GetObject("toolfrmImportSarbargFile.Image");
		((ToolStripItem)d0).Name = "toolfrmImportSarbargFile";
		((ToolStripItem)d0).Size = new Size(360, 30);
		((ToolStripItem)d0).Text = "دریافت الگوهایی طراحی شده سایر مکتب ها";
		((ToolStripItem)d0).Click += c;
		((ToolStripItem)d1).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)d1).Image = (Image)componentResourceManager.GetObject("toolSarbargReg.Image");
		((ToolStripItem)d1).Name = "toolSarbargReg";
		((ToolStripItem)d1).Size = new Size(360, 30);
		((ToolStripItem)d1).Text = "عملیات فعال سازی";
		((ToolStripItem)d1).Click += d;
		((ToolStripDropDownItem)this.m_ao).DropDownItems.AddRange(new ToolStripItem[7]
		{
			(ToolStripItem)this.m_as,
			(ToolStripItem)cw,
			(ToolStripItem)this.m_ap,
			(ToolStripItem)cx,
			(ToolStripItem)this.m_aq,
			(ToolStripItem)cy,
			(ToolStripItem)this.m_ar
		});
		((ToolStripItem)this.m_ao).Image = (Image)(object)menu.card;
		((ToolStripItem)this.m_ao).Name = "toolLable";
		((ToolStripItem)this.m_ao).Size = new Size(140, 30);
		((ToolStripItem)this.m_ao).Text = "مدیریت امتحانات";
		((ToolStripItem)this.m_as).Image = (Image)componentResourceManager.GetObject("toolHelpLable.Image");
		((ToolStripItem)this.m_as).Name = "toolHelpLable";
		((ToolStripItem)this.m_as).Size = new Size(264, 30);
		((ToolStripItem)this.m_as).Text = "راهنمای استفاده ";
		((ToolStripItem)this.m_as).Click += a7;
		((ToolStripItem)cw).Name = "toolStripSeparator41";
		((ToolStripItem)cw).Size = new Size(261, 6);
		((ToolStripItem)this.m_ap).Image = (Image)componentResourceManager.GetObject("toolHoze.Image");
		((ToolStripItem)this.m_ap).Name = "toolHoze";
		((ToolStripItem)this.m_ap).Size = new Size(264, 30);
		((ToolStripItem)this.m_ap).Text = "تعریف حوزه های امتحانی";
		((ToolStripItem)this.m_ap).Click += ba;
		((ToolStripItem)cx).Name = "toolStripSeparator42";
		((ToolStripItem)cx).Size = new Size(261, 6);
		((ToolStripItem)this.m_aq).Image = (Image)componentResourceManager.GetObject("toolStripMenuItem8.Image");
		((ToolStripItem)this.m_aq).Name = "toolStripMenuItem8";
		((ToolStripItem)this.m_aq).Size = new Size(264, 30);
		((ToolStripItem)this.m_aq).Text = "اختصاص شماره چوکی اتوماتیک";
		((ToolStripItem)this.m_aq).Click += a9;
		((ToolStripItem)cy).Name = "toolStripSeparator43";
		((ToolStripItem)cy).Size = new Size(261, 6);
		((ToolStripItem)this.m_ar).Image = (Image)componentResourceManager.GetObject("toolRptLable.Image");
		((ToolStripItem)this.m_ar).Name = "toolRptLable";
		((ToolStripItem)this.m_ar).Size = new Size(264, 30);
		((ToolStripItem)this.m_ar).Text = "مشاهده گزارشات";
		((ToolStripItem)this.m_ar).Click += a8;
		((ToolStripDropDownItem)this.m_at).DropDownItems.AddRange(new ToolStripItem[5]
		{
			(ToolStripItem)this.m_au,
			(ToolStripItem)cz,
			(ToolStripItem)this.m_aw,
			(ToolStripItem)c0,
			(ToolStripItem)this.m_av
		});
		((ToolStripItem)this.m_at).Image = (Image)(object)menu.telegram;
		((ToolStripItem)this.m_at).Name = "toolTelegram";
		((ToolStripItem)this.m_at).Size = new Size(88, 30);
		((ToolStripItem)this.m_at).Text = "تلگرام   ";
		((ToolStripItem)this.m_au).Image = (Image)componentResourceManager.GetObject("toolTelegramConfig.Image");
		((ToolStripItem)this.m_au).Name = "toolTelegramConfig";
		((ToolStripItem)this.m_au).Size = new Size(237, 30);
		((ToolStripItem)this.m_au).Text = "تنظیمات تلگرام";
		((ToolStripItem)this.m_au).Click += a5;
		((ToolStripItem)cz).Name = "toolStripSeparator44";
		((ToolStripItem)cz).Size = new Size(234, 6);
		((ToolStripItem)this.m_aw).Image = (Image)componentResourceManager.GetObject("toollistTelegramMessage.Image");
		((ToolStripItem)this.m_aw).Name = "toollistTelegramMessage";
		((ToolStripItem)this.m_aw).Size = new Size(237, 30);
		((ToolStripItem)this.m_aw).Text = "لیست پیام های ارسال شده";
		((ToolStripItem)this.m_aw).Click += a4;
		((ToolStripItem)c0).Name = "toolStripSeparator45";
		((ToolStripItem)c0).Size = new Size(234, 6);
		((ToolStripItem)this.m_av).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_av).ForeColor = Color.Goldenrod;
		((ToolStripItem)this.m_av).Image = (Image)componentResourceManager.GetObject("toolSendMarkToTelegram.Image");
		((ToolStripItem)this.m_av).Name = "toolSendMarkToTelegram";
		((ToolStripItem)this.m_av).Size = new Size(237, 30);
		((ToolStripItem)this.m_av).Text = "ارسال نمرات به تلگرام اولیا";
		((ToolStripItem)this.m_av).Click += a6;
		((ToolStripDropDownItem)this.m_g).DropDownItems.AddRange(new ToolStripItem[17]
		{
			(ToolStripItem)this.m_bk,
			(ToolStripItem)this.m_ai,
			(ToolStripItem)this.m_ay,
			(ToolStripItem)this.m_az,
			(ToolStripItem)this.m_a0,
			(ToolStripItem)this.m_a1,
			(ToolStripItem)this.m_a2,
			(ToolStripItem)this.m_a3,
			(ToolStripItem)this.m_aj,
			(ToolStripItem)this.m_ak,
			(ToolStripItem)df,
			(ToolStripItem)this.m_al,
			(ToolStripItem)this.m_am,
			(ToolStripItem)this.m_h,
			(ToolStripItem)this.m_an,
			(ToolStripItem)this.m_i,
			(ToolStripItem)dk
		});
		((ToolStripItem)this.m_g).Image = (Image)(object)menu.Possibilities;
		((ToolStripItem)this.m_g).Name = "toolEmkanat";
		((ToolStripItem)this.m_g).Size = new Size(95, 30);
		((ToolStripItem)this.m_g).Text = "امکانات   ";
		((ToolStripItem)this.m_bk).Image = (Image)componentResourceManager.GetObject("toolfrmBackColor.Image");
		((ToolStripItem)this.m_bk).Name = "toolfrmBackColor";
		((ToolStripItem)this.m_bk).Size = new Size(312, 30);
		((ToolStripItem)this.m_bk).Text = "تنظیم رنگ پس زمینه صفحات";
		((ToolStripItem)this.m_bk).Click += ar;
		((ToolStripItem)this.m_ai).Name = "toolStripSeparator5";
		((ToolStripItem)this.m_ai).Size = new Size(309, 6);
		((ToolStripItem)this.m_ay).Image = (Image)componentResourceManager.GetObject("toolfrmExpotMarkToXls.Image");
		((ToolStripItem)this.m_ay).Name = "toolfrmExpotMarkToXls";
		((ToolStripItem)this.m_ay).Size = new Size(312, 30);
		((ToolStripItem)this.m_ay).Text = "دریافت خروجی اکسل نمرات دوره";
		((ToolStripItem)this.m_ay).Click += a3;
		((ToolStripItem)this.m_az).Name = "toolStripSeparator8";
		((ToolStripItem)this.m_az).Size = new Size(309, 6);
		((ToolStripItem)this.m_a0).Image = (Image)componentResourceManager.GetObject("toolCommentKoll.Image");
		((ToolStripItem)this.m_a0).Name = "toolCommentKoll";
		((ToolStripItem)this.m_a0).Size = new Size(312, 30);
		((ToolStripItem)this.m_a0).Text = "توضیحات زیر اطلاع نامه-فردی و گروهی";
		((ToolStripItem)this.m_a0).Click += bb;
		((ToolStripItem)this.m_a1).Name = "toolStripSeparator9";
		((ToolStripItem)this.m_a1).Size = new Size(309, 6);
		((ToolStripItem)this.m_a2).Font = new Font("B Nazanin", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((ToolStripItem)this.m_a2).ForeColor = Color.FromArgb(192, 0, 192);
		((ToolStripItem)this.m_a2).Image = (Image)componentResourceManager.GetObject("toolSarbarg.Image");
		((ToolStripItem)this.m_a2).Name = "toolSarbarg";
		((ToolStripItem)this.m_a2).Size = new Size(312, 30);
		((ToolStripItem)this.m_a2).Text = "چاپ مشخصات شاگرد در برگه های امتحانی و ...";
		((ToolStripItem)this.m_a2).Visible = false;
		((ToolStripItem)this.m_a2).Click += a2;
		((ToolStripItem)this.m_a3).Name = "toolStripSeparator10";
		((ToolStripItem)this.m_a3).Size = new Size(309, 6);
		((ToolStripItem)this.m_aj).Image = (Image)componentResourceManager.GetObject("toolBackUp.Image");
		((ToolStripItem)this.m_aj).Name = "toolBackUp";
		((ToolStripItem)this.m_aj).Size = new Size(312, 30);
		((ToolStripItem)this.m_aj).Text = "پشتیبان گیری";
		((ToolStripItem)this.m_aj).Click += bm;
		((ToolStripItem)this.m_ak).Name = "toolStripSeparator4";
		((ToolStripItem)this.m_ak).Size = new Size(309, 6);
		((ToolStripItem)df).ForeColor = Color.Red;
		((ToolStripItem)df).Image = (Image)componentResourceManager.GetObject("toolfrmSetDefYear.Image");
		((ToolStripItem)df).Name = "toolfrmSetDefYear";
		((ToolStripItem)df).Size = new Size(312, 30);
		((ToolStripItem)df).Text = "سال تعلیمی پیش فرض";
		((ToolStripItem)df).Click += p;
		((ToolStripItem)this.m_al).ForeColor = Color.DarkRed;
		((ToolStripItem)this.m_al).Image = (Image)componentResourceManager.GetObject("toolNewYear.Image");
		((ToolStripItem)this.m_al).Name = "toolNewYear";
		((ToolStripItem)this.m_al).Size = new Size(312, 30);
		((ToolStripItem)this.m_al).Text = "انتقال شاگردان به پایه بالاتر";
		((ToolStripItem)this.m_al).Click += bc;
		((ToolStripItem)this.m_am).Name = "toolStripSeparator6";
		((ToolStripItem)this.m_am).Size = new Size(309, 6);
		((ToolStripItem)this.m_h).Image = (Image)componentResourceManager.GetObject("toolEmpty.Image");
		((ToolStripItem)this.m_h).Name = "toolEmpty";
		((ToolStripItem)this.m_h).Size = new Size(312, 30);
		((ToolStripItem)this.m_h).Text = "خالی کردن بانک";
		((ToolStripItem)this.m_h).Click += bl;
		((ToolStripItem)this.m_an).Name = "toolStripSeparator7";
		((ToolStripItem)this.m_an).Size = new Size(309, 6);
		((ToolStripItem)this.m_i).Image = (Image)componentResourceManager.GetObject("toolUser.Image");
		((ToolStripItem)this.m_i).Name = "toolUser";
		((ToolStripItem)this.m_i).Size = new Size(312, 30);
		((ToolStripItem)this.m_i).Text = "مدیریت کابران";
		((ToolStripItem)this.m_i).Visible = false;
		((ToolStripItem)dk).ForeColor = Color.Red;
		((ToolStripItem)dk).Image = (Image)componentResourceManager.GetObject("toolfrmRegisterPak0.Image");
		((ToolStripItem)dk).Name = "toolfrmRegisterPak0";
		((ToolStripItem)dk).Size = new Size(312, 30);
		((ToolStripItem)dk).Text = "فعال سازی امکان شبکه";
		((ToolStripItem)dk).Click += m;
		((ToolStripDropDownItem)this.m_x).DropDownItems.AddRange(new ToolStripItem[2]
		{
			(ToolStripItem)this.m_y,
			(ToolStripItem)this.m_z
		});
		((ToolStripItem)this.m_x).Name = "toolhelp";
		((ToolStripItem)this.m_x).Size = new Size(39, 30);
		((ToolStripItem)this.m_x).Text = "راه";
		((ToolStripItem)this.m_x).Visible = false;
		((ToolStripItem)this.m_y).Name = "helpword";
		((ToolStripItem)this.m_y).Size = new Size(161, 30);
		((ToolStripItem)this.m_y).Text = "فرمت word";
		((ToolStripItem)this.m_y).Click += bj;
		((ToolStripItem)this.m_z).Name = "helpPdf";
		((ToolStripItem)this.m_z).Size = new Size(161, 30);
		((ToolStripItem)this.m_z).Text = "فرمت pdf";
		((ToolStripItem)this.m_z).Click += bi;
		((ToolStripItem)this.m_p).Name = "toolStripMenuItem4";
		((ToolStripItem)this.m_p).Size = new Size(36, 30);
		((ToolStripItem)this.m_p).Text = "ت";
		((ToolStripItem)this.m_p).Visible = false;
		((ToolStripItem)this.m_q).Image = (Image)(object)menu.exit;
		((ToolStripItem)this.m_q).Name = "toolStripMenuItem5";
		((ToolStripItem)this.m_q).Size = new Size(76, 30);
		((ToolStripItem)this.m_q).Text = "خروج";
		((ToolStripItem)this.m_q).Click += bn;
		((ToolStripDropDownItem)this.m_m).DropDownItems.AddRange(new ToolStripItem[1] { (ToolStripItem)this.m_o });
		((ToolStripItem)this.m_m).Name = "toolStripMenuItem1";
		((ToolStripItem)this.m_m).Size = new Size(88, 20);
		((ToolStripItem)this.m_m).Text = "تماس با شرکت";
		((ToolStripItem)this.m_o).Name = "toolStripMenuItem3";
		((ToolStripItem)this.m_o).Size = new Size(180, 22);
		((ToolStripItem)this.m_o).Text = "toolStripMenuItem3";
		((ToolStripItem)this.m_n).Name = "toolStripMenuItem2";
		((ToolStripItem)this.m_n).Size = new Size(43, 20);
		((ToolStripItem)this.m_n).Text = "خروج";
		((Control)this.m_s).Anchor = (AnchorStyles)6;
		((Control)this.m_s).AutoSize = true;
		((Control)this.m_s).BackColor = Color.FromArgb(192, 192, 255);
		((Control)this.m_s).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_s).Location = new Point(109, 612);
		((Control)this.m_s).Name = "label1";
		((Control)this.m_s).Size = new Size(84, 26);
		((Control)this.m_s).TabIndex = 52;
		((Control)this.m_s).Text = " : کد نرم افزار";
		((Control)this.m_s).DoubleClick += bh;
		((Control)this.m_t).Anchor = (AnchorStyles)6;
		((Control)this.m_t).BackColor = Color.FromArgb(192, 192, 255);
		((Control)this.m_t).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_t).Location = new Point(3, 612);
		((Control)this.m_t).Name = "l_xschool";
		((Control)this.m_t).RightToLeft = (RightToLeft)1;
		((Control)this.m_t).Size = new Size(100, 26);
		((Control)this.m_t).TabIndex = 53;
		this.m_t.TextAlign = (ContentAlignment)32;
		((Control)this.m_u).Anchor = (AnchorStyles)6;
		((Control)this.m_u).AutoSize = true;
		((Control)this.m_u).BackColor = Color.FromArgb(192, 192, 255);
		((Control)this.m_u).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_u).Location = new Point(109, 645);
		((Control)this.m_u).Name = "label3";
		((Control)this.m_u).Size = new Size(49, 26);
		((Control)this.m_u).TabIndex = 54;
		((Control)this.m_u).Text = " : ورژن";
		((Control)this.m_v).Anchor = (AnchorStyles)6;
		((Control)this.m_v).BackColor = Color.FromArgb(192, 255, 255);
		((Control)this.m_v).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_v).Location = new Point(3, 645);
		((Control)this.m_v).Name = "l_ver";
		((Control)this.m_v).RightToLeft = (RightToLeft)1;
		((Control)this.m_v).Size = new Size(100, 26);
		((Control)this.m_v).TabIndex = 55;
		((Control)this.m_v).Text = "1402/11/19";
		this.m_v.TextAlign = (ContentAlignment)32;
		((Control)this.m_v).DoubleClick += an;
		((Control)this.m_ax).Anchor = (AnchorStyles)1;
		this.m_ax.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		((Control)this.m_ax).Location = new Point(255, 164);
		((Control)this.m_ax).Name = "pictureBox1";
		((Control)this.m_ax).Size = new Size(466, 289);
		this.m_ax.TabIndex = 56;
		this.m_ax.TabStop = false;
		((Control)dd).Anchor = (AnchorStyles)10;
		((Control)dd).AutoSize = true;
		((Control)dd).BackColor = Color.CornflowerBlue;
		((Control)dd).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)dd).ForeColor = Color.DarkViolet;
		((Control)dd).Location = new Point(889, 637);
		((Control)dd).Name = "label4";
		((Control)dd).RightToLeft = (RightToLeft)1;
		((Control)dd).Size = new Size(98, 30);
		((Control)dd).TabIndex = 122;
		((Control)dd).Text = "سال تعلیمی :";
		((Control)de).Anchor = (AnchorStyles)10;
		((Control)de).BackColor = Color.CornflowerBlue;
		de.BorderStyle = (BorderStyle)1;
		((Control)de).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)de).ForeColor = Color.MediumBlue;
		((Control)de).Location = new Point(824, 637);
		((Control)de).Name = "lYear";
		((Control)de).RightToLeft = (RightToLeft)1;
		((Control)de).Size = new Size(59, 32);
		((Control)de).TabIndex = 123;
		dh.ActiveFormatStyle.BackColor = Color.Teal;
		((Control)dh).Anchor = (AnchorStyles)10;
		dh.ButtonStyle = (ButtonStyle)1;
		((Control)dh).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		dh.ImageIndex = 8;
		((Control)dh).Location = new Point(373, 634);
		((Control)dh).Name = "btnPer";
		((Control)dh).Size = new Size(130, 37);
		((Control)dh).TabIndex = 132;
		((Control)dh).Text = "مشاهده سطح دسترسی  کاربر";
		((Control)dh).Visible = false;
		((Control)dh).Click += n;
		((Control)di).Anchor = (AnchorStyles)10;
		((Control)di).BackColor = Color.CornflowerBlue;
		di.BorderStyle = (BorderStyle)1;
		((Control)di).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)di).ForeColor = Color.MediumBlue;
		((Control)di).Location = new Point(509, 637);
		((Control)di).Name = "lUser";
		((Control)di).RightToLeft = (RightToLeft)1;
		((Control)di).Size = new Size(177, 32);
		((Control)di).TabIndex = 131;
		((Control)dj).Anchor = (AnchorStyles)10;
		((Control)dj).BackColor = Color.CornflowerBlue;
		((Control)dj).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)dj).ForeColor = Color.DarkViolet;
		((Control)dj).Location = new Point(692, 637);
		((Control)dj).Name = "label2";
		((Control)dj).RightToLeft = (RightToLeft)1;
		((Control)dj).Size = new Size(107, 30);
		((Control)dj).TabIndex = 130;
		((Control)dj).Text = "کاربر فعال :";
		dj.TextAlign = (ContentAlignment)64;
		((Control)dl).Anchor = (AnchorStyles)10;
		((Control)dl).BackColor = Color.CornflowerBlue;
		((Control)dl).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)dl).ForeColor = Color.DarkViolet;
		((Control)dl).Location = new Point(225, 637);
		((Control)dl).Name = "lIsNetWork";
		((Control)dl).RightToLeft = (RightToLeft)1;
		((Control)dl).Size = new Size(120, 30);
		((Control)dl).TabIndex = 133;
		((Control)dl).Text = "شما در شبکه هستید";
		dl.TextAlign = (ContentAlignment)32;
		((Control)dl).Visible = false;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		((Form)this).ClientSize = new Size(994, 672);
		((Control)this).Controls.Add((Control)(object)dl);
		((Control)this).Controls.Add((Control)(object)dh);
		((Control)this).Controls.Add((Control)(object)di);
		((Control)this).Controls.Add((Control)(object)dj);
		((Control)this).Controls.Add((Control)(object)de);
		((Control)this).Controls.Add((Control)(object)dd);
		((Control)this).Controls.Add((Control)(object)this.m_ax);
		((Control)this).Controls.Add((Control)(object)this.m_v);
		((Control)this).Controls.Add((Control)(object)this.m_u);
		((Control)this).Controls.Add((Control)(object)this.m_t);
		((Control)this).Controls.Add((Control)(object)this.m_s);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Microsoft Sans Serif", 8.25f);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Control)this).Name = "frmMain";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "SMS نرم افزار ";
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).Load += bw;
		((Form)this).FormClosing += a;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((ISupportInitialize)this.m_ax).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void bw(object A_0, EventArgs A_1)
	{
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		int num4 = default;
		bool flag = default;
		string text = default;
		string A_2 = default;
		while (true)
		{
			int num = 15;
			while (true)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 52:
					num = ((asdaj.l == "") ? 18 : 44);
					continue;
				case 35:
					num = 51;
					continue;
				case 48:
					flag = num4 >= int.Parse(((Control)this.m_v).Tag.ToString().Replace("/", ""));
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 21;
						continue;
					}
					a();
					asdaj.a = asdcb.a(asdab.e(), CommandType.Text, "SELECT  xYear  FROM  tDefYear").ToString();
					((Control)de).Text = asdaj.a;
					((Control)di).Text = asdcb.a(asdab.e(), CommandType.Text, "select uid from tuser where id=" + asdaj.l).ToString();
					flag = !(asdaj.l != "1");
					num = 37;
					continue;
				case 37:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 29:
					return;
				case 34:
					((Control)this.m_b).Visible = true;
					num = 27;
					continue;
				case 10:
				{
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tPaye");
					flag = dataTable.Rows.Count != 0;
					num = 43;
					continue;
				}
				case 43:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 38;
				case 12:
					((Control)dl).Visible = true;
					num = 10;
					continue;
				case 25:
					if (!flag)
					{
						num = 2;
						continue;
					}
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده");
					Application.ExitThread();
					num = 7;
					continue;
				case 15:
					try
					{
						while (true)
						{
							IL_035c:
							flag = !File.Exists(Application.StartupPath + "\\config.kbr");
							num = 0;
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
								{
									string text2 = "";
									string path = Application.StartupPath + "\\config.kbr";
									StreamReader streamReader = new StreamReader(path);
									asdab.b = asdab.c(streamReader.ReadLine());
									text2 = asdab.c(streamReader.ReadLine());
									streamReader.Close();
									asdab.a = text2;
									asdab.r = "1";
									num = 2;
									continue;
								}
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_0343;
								}
								goto IL_035c;
								continue;
								end_IL_0343:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("اشکال در فایل کانفیگ");
						return;
					}
					flag = !(asdab.r == "1");
					num = 9;
					continue;
				case 26:
					try
					{
						while (true)
						{
							IL_0445:
							flag = !File.Exists(Application.StartupPath + "\\regkbr.kbr");
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 7;
										continue;
									}
									MessageBox.Show("فایل فعال سازی موجود نیست");
									num = 6;
									continue;
								case 4:
									MessageBox.Show("فایل فعال سازی قدیمی است");
									Application.ExitThread();
									num = 3;
									continue;
								case 3:
									return;
								case 7:
								{
									string path = Application.StartupPath + "\\regkbr.kbr";
									StreamReader streamReader = new StreamReader(path);
									text = asdab.c(streamReader.ReadLine());
									string[] array = text.Split(new char[1] { '-' });
									asdab.p = int.Parse(array[0]);
									streamReader.Close();
									flag = asdab.p == 1403;
									num = 1;
									continue;
								}
								case 1:
									num = ((!flag) ? 4 : 0);
									continue;
								case 6:
									return;
								case 0:
									num = 5;
									continue;
								case 5:
									goto end_IL_041c;
								}
								goto IL_0445;
								continue;
								end_IL_041c:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("اشکال در فعال سازی");
						return;
					}
					asdab.m = "3";
					((Control)this.m_t).Text = asdab.n;
					flag = text.IndexOf(asdab.n) < 0;
					num = 25;
					continue;
				case 42:
					num = 28;
					continue;
				case 28:
					num2 = ((asdaj.l == null) ? 1 : 0);
					goto IL_08d5;
				case 13:
				{
					A_2 = "";
					asdaw asdaw2 = new asdaw();
					flag = asdaw2.a(ref A_2);
					num = 22;
					continue;
				}
				case 22:
					if (!flag)
					{
						num = 31;
						continue;
					}
					asdab.a = asdab.a + "database=" + asdab.d;
					num = 17;
					continue;
				case 30:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 40:
					flag = !(asdab.m == "3");
					num = 32;
					continue;
				case 32:
					if (flag)
					{
						flag = !(asdab.m == "2");
						num = 30;
					}
					else
					{
						num = 35;
					}
					continue;
				case 20:
					try
					{
						string text3 = asdcb.a(asdab.e(), CommandType.Text, "SELECT  ver  FROM  tVer").ToString();
					}
					catch
					{
						if (asdab.r == "1")
						{
							MessageBox.Show(asdab.c("VFFCckFIUUFiUUJYQUZnQVRnQnJBR0VBV0FCRkFIa0FVd0F5QUhBQVdnQmpBRVFBYkFCd0FFMEFNQUJzQUU4QVlRQlhBRGdBZVFCVEFESUFUZ0J1QUUwQWF3QnpBSFlBV1FCdEFIQUFUd0JoQUZnQVJRQjVBRk1BTWdCYUFGb0FZd0JWQURVQU1RQlVBRlFBU2dCTkFGUUFWd0JqQUhrQVV3QXlBSEFBV2dCakFESUFVZ0IwQUZFQWVnQktBRTBBVXdCR0FHd0Fkd0JQQUZjQWJBQTBBRk1BVlFBMUFIUUFVZ0I2QUVvQVRRQldBRVlBYkFCNUFHUUFlUUIwQUVJQVVnQkVBRUlBUWdCVkFFWUFSUUIwQUE9PQ=="));
							Application.ExitThread();
							return;
						}
						asdb4 asdb10 = new asdb4();
						((Form)asdb10).ShowDialog();
						flag = !(asdab.c == "1");
						if (!flag)
						{
							Application.Exit();
							return;
						}
					}
					num = 52;
					continue;
				case 16:
					((Control)dh).Visible = true;
					num = 56;
					continue;
				case 56:
					return;
				case 2:
					asdab.q = asdab.n;
					num = 41;
					continue;
				case 27:
					num = 54;
					continue;
				case 8:
				case 11:
					Application.ExitThread();
					num = 33;
					continue;
				case 33:
					return;
				case 0:
					((ToolStripItem)dk).Visible = false;
					num = 20;
					continue;
				case 41:
					flag = !(asdab.o == "10");
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 20;
				case 54:
					flag = !(asdab.r == "1");
					num = 53;
					continue;
				case 53:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 10;
				case 44:
					num = 47;
					continue;
				case 47:
					num3 = ((asdaj.l != null) ? 1 : 0);
					goto IL_099c;
				case 1:
				{
					asdbv asdbv2 = new asdbv();
					asdbv2.at = ((Control)this.m_v).Tag.ToString();
					((Form)asdbv2).ShowDialog();
					string a_ = asdcb.a(asdab.e(), CommandType.Text, "SELECT  ver  FROM  tVer").ToString();
					((Control)this.m_v).Tag = asdab.c(a_);
					num = 48;
					continue;
				}
				case 14:
					num = ((!flag) ? 6 : 24);
					continue;
				case 58:
					if (flag)
					{
						((Form)this).Close();
						num = 29;
					}
					else
					{
						num = 34;
					}
					continue;
				case 55:
					num2 = 1;
					goto IL_08d5;
				case 9:
					if (flag)
					{
						asdaw asdaw2 = new asdaw();
						flag = asdaw2.a();
						num = 14;
					}
					else
					{
						num = 13;
					}
					continue;
				case 18:
					num3 = 0;
					goto IL_099c;
				case 6:
					MessageBox.Show(asdab.c(asdab.a()));
					Application.ExitThread();
					num = 23;
					continue;
				case 23:
					return;
				case 5:
				case 51:
					num = 38;
					continue;
				case 39:
					if (!flag)
					{
						num = 50;
						continue;
					}
					goto case 54;
				case 31:
					flag = A_2.Length <= 2;
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 57;
						continue;
					}
					MessageBox.Show(A_2);
					num = 11;
					continue;
				case 57:
					if (true)
					{
					}
					MessageBox.Show(asdab.c(A_2));
					num = 8;
					continue;
				case 17:
				case 24:
					text = "";
					num = 26;
					continue;
				case 7:
					return;
				case 4:
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'اول ابتدایی')");
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'دوم ابتدایی')");
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'سوم ابتدایی')");
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'چهارم ابتدایی')");
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'پنجم ابتدایی')");
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'ششم ابتدایی')");
					num = 5;
					continue;
				case 21:
					MessageBox.Show("ورژن نرم افزار با پایگاه داده مطابقت ندارد.آخرین بروزرسانی را نصب کنید");
					Application.ExitThread();
					num = 45;
					continue;
				case 45:
					return;
				case 38:
				{
					string a_ = asdcb.a(asdab.e(), CommandType.Text, "SELECT  ver  FROM  tVer").ToString();
					((Control)this.m_v).Tag = asdab.c(a_);
					num4 = int.Parse(((Control)this.m_v).Text.Replace("/", ""));
					flag = !(((Control)this.m_v).Tag.ToString() != "1402/11/19");
					num = 49;
					continue;
				}
				case 49:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 48;
				case 50:
				{
					asda3 asda10 = new asda3();
					((Form)asda10).ShowDialog();
					num = 3;
					continue;
				}
				case 3:
					{
						num = ((asdaj.l != "") ? 42 : 55);
						continue;
					}
					IL_08d5:
					flag = (byte)num2 != 0;
					num = 58;
					continue;
					IL_099c:
					flag = (byte)num3 != 0;
					num = 39;
					continue;
				}
				break;
			}
		}
	}

	private void bv(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdca asdca2 = new asdca();
		((Form)asdca2).ShowDialog();
	}

	private void a()
	{
		try
		{
			while (true)
			{
				IL_001e:
				bool flag = !(asdu.o.Substring(2, 1) == "1");
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
						goto case 1;
					case 0:
						((ToolStripItem)d1).Visible = false;
						num = 1;
						continue;
					case 1:
						num = 3;
						continue;
					case 3:
						goto end_IL_0005;
					}
					goto IL_001e;
					continue;
					end_IL_0005:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void bu(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdc asdc2 = new asdc();
		((Form)asdc2).ShowDialog();
	}

	private void bt(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdm asdm2 = new asdm();
		((Form)asdm2).ShowDialog();
	}

	private void bs(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbq asdbq2 = new asdbq();
		((Form)asdbq2).ShowDialog();
	}

	private void br(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdak asdak2 = new asdak();
		((Form)asdak2).ShowDialog();
	}

	private void bq(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda0 asda10 = new asda0();
		((Form)asda10).ShowDialog();
	}

	private void bp(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbi asdbi2 = new asdbi();
		((Form)asdbi2).ShowDialog();
	}

	private void bo(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdj asdj2 = new asdj();
		((Form)asdj2).ShowDialog();
	}

	private void bn(object A_0, EventArgs A_1)
	{
		try
		{
			Application.Exit();
		}
		catch
		{
			Application.ExitThread();
		}
		if (1 == 0)
		{
		}
	}

	private void bm(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda9 asda10 = new asda9();
		((Form)asda10).ShowDialog();
	}

	private void bl(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdao asdao2 = new asdao();
		((Form)asdao2).ShowDialog();
	}

	private void bk(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdcd asdcd2 = new asdcd();
		((Form)asdcd2).ShowDialog();
	}

	private void bj(object A_0, EventArgs A_1)
	{
		string text = "help" + asdab.m + ".doc";
		Process process = new Process();
		try
		{
			if (true)
			{
			}
			process.StartInfo.FileName = Application.StartupPath + "\\help\\" + text;
			process.Start();
		}
		catch
		{
		}
	}

	private void bi(object A_0, EventArgs A_1)
	{
		string text = "help" + asdab.m + ".pdf";
		Process process = new Process();
		try
		{
			if (true)
			{
			}
			process.StartInfo.FileName = Application.StartupPath + "\\help\\" + text;
			process.Start();
		}
		catch
		{
		}
	}

	private void bh(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asde asde2 = new asde();
		((Form)asde2).ShowDialog();
	}

	private void bg(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdcc asdcc2 = new asdcc();
		((Form)asdcc2).ShowDialog();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between I4 and Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(asdab.c == "1");
			int num = 1;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = 6 == (int)MessageBox.Show("آیا میخواهید از برنامه خارج شوید", "خروج", (MessageBoxButtons)4, (MessageBoxIcon)32);
					num = 2;
					continue;
				case 0:
					((CancelEventArgs)(object)A_1).Cancel = true;
					num = 4;
					continue;
				case 4:
					return;
				case 2:
				{
					if (!flag)
					{
						num = 0;
						continue;
					}
					asdbl asdbl2 = new asdbl();
					((Form)asdbl2).ShowDialog();
					num = 5;
					continue;
				}
				case 3:
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void bf(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdb0 asdb10 = new asdb0();
		((Form)asdb10).ShowDialog();
	}

	private void be(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdap asdap2 = new asdap();
		((Form)asdap2).ShowDialog();
	}

	private void bd(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdg asdg2 = new asdg();
		((Form)asdg2).ShowDialog();
	}

	private void bc(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbz asdbz2 = new asdbz();
		((Form)asdbz2).ShowDialog();
	}

	private void bb(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdx asdx2 = new asdx();
		asdx2.p = "5";
		((Form)asdx2).ShowDialog();
	}

	private void ba(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda1 asda10 = new asda1();
		((Form)asda10).ShowDialog();
	}

	private void a9(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdb asdb10 = new asdb();
		((Form)asdb10).ShowDialog();
	}

	private void a8(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdam asdam2 = new asdam();
		((Form)asdam2).ShowDialog();
	}

	private void a7(object A_0, EventArgs A_1)
	{
		string text = "shomare-sandali.pdf";
		Process process = new Process();
		try
		{
			if (true)
			{
			}
			process.StartInfo.FileName = Application.StartupPath + "\\help\\" + text;
			process.Start();
		}
		catch
		{
		}
	}

	private void a6(object A_0, EventArgs A_1)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		Process process = new Process();
		try
		{
			if (true)
			{
			}
			process.StartInfo.FileName = Application.StartupPath + "\\telegram\\karname20.telegram.exe";
			process.Start();
		}
		catch
		{
		}
		asdb1 asdb10 = new asdb1();
		((Form)asdb10).ShowDialog();
	}

	private void a5(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdb6 asdb10 = new asdb6();
		((Form)asdb10).ShowDialog();
	}

	private void a4(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbj asdbj2 = new asdbj();
		((Form)asdbj2).ShowDialog();
	}

	private void a3(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdb5 asdb10 = new asdb5();
		((Form)asdb10).ShowDialog();
	}

	private void a2(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdal asdal2 = new asdal();
		((Form)asdal2).ShowDialog();
	}

	private void a1(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdby asdby2 = new asdby();
		((Form)asdby2).ShowDialog();
	}

	private void a0(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbm asdbm2 = new asdbm();
		((Form)asdbm2).ShowDialog();
	}

	private void az(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdad asdad2 = new asdad();
		((Form)asdad2).ShowDialog();
	}

	private void ay(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbn asdbn2 = new asdbn();
		((Form)asdbn2).ShowDialog();
	}

	private void ax(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdn asdn2 = new asdn();
		((Form)asdn2).ShowDialog();
	}

	private void aw(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbw asdbw2 = new asdbw();
		((Form)asdbw2).ShowDialog();
	}

	private void av(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdce asdce2 = new asdce();
		((Form)asdce2).ShowDialog();
	}

	private void au(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdq asdq2 = new asdq();
		((Form)asdq2).ShowDialog();
	}

	private void at(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdas asdas2 = new asdas();
		((Form)asdas2).ShowDialog();
	}

	private void @as(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdaz asdaz2 = new asdaz();
		((Form)asdaz2).ShowDialog();
	}

	private void ar(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda8 asda10 = new asda8();
		((Form)asda10).ShowDialog();
	}

	private void aq(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdaa asdaa2 = new asdaa();
		((Form)asdaa2).ShowDialog();
	}

	private void ap(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdp asdp2 = new asdp();
		asdp2.q = "1";
		((Form)asdp2).ShowDialog();
	}

	private void ao(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdp asdp2 = new asdp();
		asdp2.q = "2";
		((Form)asdp2).ShowDialog();
	}

	private void an(object A_0, EventArgs A_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(((Control)this.m_v).Tag.ToString());
	}

	private void am(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdh asdh2 = new asdh();
		((Form)asdh2).ShowDialog();
	}

	private void al(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdb2 asdb10 = new asdb2();
		((Form)asdb10).ShowDialog();
	}

	private void ak(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda5 asda10 = new asda5();
		((Form)asda10).ShowDialog();
	}

	private void aj(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbf asdbf2 = new asdbf();
		((Form)asdbf2).ShowDialog();
	}

	private void ai(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbo asdbo2 = new asdbo();
		((Form)asdbo2).ShowDialog();
	}

	private void ah(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdl asdl2 = new asdl();
		((Form)asdl2).ShowDialog();
	}

	private void ag(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdf asdf2 = new asdf();
		((Form)asdf2).ShowDialog();
	}

	private void af(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdb7 asdb10 = new asdb7();
		((Form)asdb10).ShowDialog();
	}

	private void ae(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdai asdai2 = new asdai();
		((Form)asdai2).ShowDialog();
	}

	private void ad(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdv asdv2 = new asdv();
		((Form)asdv2).ShowDialog();
	}

	private void ac(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdag asdag2 = new asdag();
		((Form)asdag2).ShowDialog();
	}

	private void ab(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdo asdo2 = new asdo();
		((Form)asdo2).ShowDialog();
	}

	private void aa(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdar asdar2 = new asdar();
		((Form)asdar2).ShowDialog();
	}

	private void z(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdba asdba2 = new asdba();
		((Form)asdba2).ShowDialog();
	}

	private void y(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdac asdac2 = new asdac();
		((Form)asdac2).ShowDialog();
	}

	private void x(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdx asdx2 = new asdx();
		asdx2.p = "6";
		((Form)asdx2).ShowDialog();
	}

	private void w(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdb8 asdb10 = new asdb8();
		asdb10.c = "1";
		((Form)asdb10).ShowDialog();
	}

	private void v(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdb8 asdb10 = new asdb8();
		asdb10.c = "3";
		((Form)asdb10).ShowDialog();
	}

	private void u(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbh asdbh2 = new asdbh();
		((Form)asdbh2).ShowDialog();
	}

	private void t(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdaq asdaq2 = new asdaq();
		asdaq2.b = "10";
		((Form)asdaq2).ShowDialog();
	}

	private void s(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdaq asdaq2 = new asdaq();
		asdaq2.b = "11";
		((Form)asdaq2).ShowDialog();
	}

	private void r(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asda6 asda10 = new asda6();
		asda10.t = "1";
		((Form)asda10).ShowDialog();
	}

	private void q(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asda6 asda10 = new asda6();
		asda10.t = "3";
		((Form)asda10).ShowDialog();
	}

	private void p(object A_0, EventArgs A_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		asdav asdav2 = new asdav();
		((Form)asdav2).ShowDialog();
		((Control)de).Text = asdaj.a;
	}

	private void o(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdi asdi2 = new asdi();
		((Form)asdi2).ShowDialog();
	}

	private void n(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asds asds2 = new asds();
		asds2.o = asdaj.l;
		((Form)asds2).ShowDialog();
	}

	private void m(object A_0, EventArgs A_1)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			asdbk asdbk2 = new asdbk();
			asdbk2.k = "0";
			((Form)asdbk2).ShowDialog();
			bool flag = !(asdab.o == "10");
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
					((ToolStripItem)dk).Visible = false;
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
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdw asdw2 = new asdw();
		((Form)asdw2).ShowDialog();
	}

	private void k(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdt asdt2 = new asdt();
		asdt2.bx = "1";
		((Form)asdt2).ShowDialog();
	}

	private void j(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdt asdt2 = new asdt();
		asdt2.bx = "5";
		((Form)asdt2).ShowDialog();
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdt asdt2 = new asdt();
		asdt2.bx = "2";
		((Form)asdt2).ShowDialog();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdt asdt2 = new asdt();
		asdt2.bx = "3";
		((Form)asdt2).ShowDialog();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdt asdt2 = new asdt();
		asdt2.bx = "4";
		((Form)asdt2).ShowDialog();
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		asdt asdt2 = new asdt();
		asdt2.bx = "6";
		((Form)asdt2).ShowDialog();
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdw asdw2 = new asdw();
		((Form)asdw2).ShowDialog();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		asdbk asdbk2 = new asdbk();
		asdbk2.k = "3";
		((Form)asdbk2).ShowDialog();
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdah asdah2 = new asdah();
		((Form)asdah2).ShowDialog();
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdau asdau2 = new asdau();
		((Form)asdau2).ShowDialog();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asda7 asda10 = new asda7();
		((Form)asda10).ShowDialog();
	}
}
