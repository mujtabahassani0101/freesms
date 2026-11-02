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
protected override void Dispose(bool A_0)
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
					base.Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
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
		this.m_b.SuspendLayout();
		((ISupportInitialize)this.m_ax).BeginInit();
		SuspendLayout();
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_b.ImageScalingSize = new Size(20, 20);
		this.m_b.Items.AddRange(new ToolStripItem[12]
		{
			this.m_c, this.m_d, this.m_bo, this.m_aa, this.m_a5, dn, this.m_ao, this.m_at, this.m_g, this.m_x,
			this.m_p, this.m_q
		});
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "menuStrip1";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.Size = new Size(994, 34);
		this.m_b.TabIndex = 51;
		this.m_b.Text = "menuStrip1";
		this.m_b.Visible = false;
		this.m_c.DropDownItems.AddRange(new ToolStripItem[20]
		{
			b6, this.m_w, cf, this.m_bl, cg, b1, ch, this.m_l, ci, this.m_k,
			cj, this.m_j, ck, this.m_r, cl, this.m_bt, cm, b2, dg, d7
		});
		this.m_c.Image = menu.base1;
		this.m_c.Name = "tool3";
		this.m_c.Size = new Size(122, 30);
		this.m_c.Text = "اطلاعات پایه   ";
		b6.ForeColor = Color.FromArgb(64, 0, 0);
		b6.Image = menu.select3;
		b6.Name = "toolfrmSchool";
		b6.Size = new Size(328, 30);
		b6.Text = "مشخصات مکتب";
		b6.Click += y;
		this.m_w.Image = (Image)componentResourceManager.GetObject("toolfrmPaye.Image");
		this.m_w.Name = "toolfrmPaye";
		this.m_w.Size = new Size(328, 30);
		this.m_w.Text = "پایه ها";
		this.m_w.Visible = false;
		this.m_w.Click += bk;
		cf.Name = "toolStripSeparator27";
		cf.Size = new Size(325, 6);
		this.m_bl.Image = (Image)componentResourceManager.GetObject("toolYearMaghtaCountDay.Image");
		this.m_bl.Name = "toolYearMaghtaCountDay";
		this.m_bl.Size = new Size(328, 30);
		this.m_bl.Text = "ایام سال تعلیمی";
		this.m_bl.Click += aq;
		cg.Name = "toolStripSeparator28";
		cg.Size = new Size(325, 6);
		b1.Image = (Image)componentResourceManager.GetObject("toolfrmTosifConfig.Image");
		b1.Name = "toolfrmTosifConfig";
		b1.Size = new Size(328, 30);
		b1.Text = "تنظیمات درجه بندی";
		b1.Click += ac;
		ch.Name = "toolStripSeparator29";
		ch.Size = new Size(325, 6);
		this.m_l.Image = (Image)componentResourceManager.GetObject("toolfrmCls.Image");
		this.m_l.Name = "toolfrmCls";
		this.m_l.Size = new Size(328, 30);
		this.m_l.Text = "مدیریت صنوف";
		this.m_l.Click += bu;
		ci.Name = "toolStripSeparator30";
		ci.Size = new Size(325, 6);
		this.m_k.Image = (Image)componentResourceManager.GetObject("toolfrBook.Image");
		this.m_k.Name = "toolfrBook";
		this.m_k.Size = new Size(328, 30);
		this.m_k.Text = "دروس";
		this.m_k.Click += bv;
		cj.Name = "toolStripSeparator31";
		cj.Size = new Size(325, 6);
		this.m_j.Image = (Image)componentResourceManager.GetObject("toolfrmTeacher.Image");
		this.m_j.Name = "toolfrmTeacher";
		this.m_j.Size = new Size(328, 30);
		this.m_j.Text = "لیست معلمان";
		this.m_j.Click += bp;
		ck.Name = "toolStripSeparator32";
		ck.Size = new Size(325, 6);
		this.m_r.Image = (Image)componentResourceManager.GetObject("toolfrmTchClass.Image");
		this.m_r.Name = "toolfrmTchClass";
		this.m_r.Size = new Size(328, 30);
		this.m_r.Text = "معلم-درس";
		this.m_r.Click += bo;
		cl.Name = "toolStripSeparator34";
		cl.Size = new Size(325, 6);
		this.m_bt.Image = (Image)componentResourceManager.GetObject("toolDriver.Image");
		this.m_bt.Name = "toolDriver";
		this.m_bt.Size = new Size(328, 30);
		this.m_bt.Text = "لیست رانندگان";
		this.m_bt.Click += ah;
		cm.Name = "toolStripSeparator33";
		cm.Size = new Size(325, 6);
		b2.Image = (Image)componentResourceManager.GetObject("toolOst.Image");
		b2.Name = "toolOst";
		b2.Size = new Size(328, 30);
		b2.Text = "لیست ولسوالی ها";
		b2.Click += ab;
		dg.Image = (Image)componentResourceManager.GetObject("toolfrmUser.Image");
		dg.Name = "toolfrmUser";
		dg.Size = new Size(328, 30);
		dg.Text = "مدیریت کاربران";
		dg.Click += o;
		d7.Image = (Image)componentResourceManager.GetObject("toolSetMark100.Image");
		d7.Name = "toolSetMark100";
		d7.Size = new Size(328, 30);
		d7.Text = "ورود نمره سالانه از 100 برای کل دانش آموزان";
		d7.Click += a;
		this.m_d.DropDownItems.AddRange(new ToolStripItem[17]
		{
			this.m_e, ce, this.m_bv, cn, this.m_bj, co, this.m_bm, cp, this.m_bn, cq,
			this.m_bu, this.m_f, this.m_bw, bx, this.m_bp, d2, d3
		});
		this.m_d.Image = menu.student;
		this.m_d.Name = "tool2";
		this.m_d.Size = new Size(116, 30);
		this.m_d.Text = "امور متعلمین";
		this.m_e.Image = (Image)componentResourceManager.GetObject("toolStd.Image");
		this.m_e.Name = "toolStd";
		this.m_e.Size = new Size(352, 30);
		this.m_e.Text = "لیست شاگردان و ثبت نام";
		this.m_e.Click += bt;
		ce.Name = "toolStripSeparator21";
		ce.Size = new Size(349, 6);
		this.m_bv.Image = (Image)componentResourceManager.GetObject("toolImportStd.Image");
		this.m_bv.Name = "toolImportStd";
		this.m_bv.Size = new Size(352, 30);
		this.m_bv.Text = "ثبت دانش آموزان از فایل اکسل";
		this.m_bv.Click += af;
		cn.Name = "toolStripSeparator22";
		cn.Size = new Size(349, 6);
		this.m_bj.Image = (Image)componentResourceManager.GetObject("toolshaghe.Image");
		this.m_bj.Name = "toolshaghe";
		this.m_bj.Size = new Size(352, 30);
		this.m_bj.Text = "مدیریت شقه های صنف";
		this.m_bj.Click += @as;
		co.Name = "toolStripSeparator23";
		co.Size = new Size(349, 6);
		this.m_bm.Image = (Image)componentResourceManager.GetObject("toolHazeri1.Image");
		this.m_bm.Name = "toolHazeri1";
		this.m_bm.Size = new Size(352, 30);
		this.m_bm.Text = "ثبت تعداد حاضری چهار و نیم ماهه";
		this.m_bm.Click += ap;
		cp.Name = "toolStripSeparator35";
		cp.Size = new Size(349, 6);
		this.m_bn.Image = (Image)componentResourceManager.GetObject("toolHazeri2.Image");
		this.m_bn.Name = "toolHazeri2";
		this.m_bn.Size = new Size(352, 30);
		this.m_bn.Text = "ثبت تعداد حاضری سالانه";
		this.m_bn.Click += ao;
		cq.Name = "toolStripSeparator24";
		cq.Size = new Size(349, 6);
		this.m_bu.Image = (Image)componentResourceManager.GetObject("toolDriverStd.Image");
		this.m_bu.Name = "toolDriverStd";
		this.m_bu.Size = new Size(352, 30);
		this.m_bu.Text = "اختصاص راننده به دانش آموز";
		this.m_bu.Click += ag;
		this.m_f.Name = "toolStripSeparator2";
		this.m_f.Size = new Size(349, 6);
		this.m_bw.Image = (Image)componentResourceManager.GetObject("toolfrmlistStdSearch.Image");
		this.m_bw.Name = "toolfrmlistStdSearch";
		this.m_bw.Size = new Size(352, 30);
		this.m_bw.Text = "خروجی دانش آموزان بر اساس فیلتر دلخواه";
		this.m_bw.Click += ae;
		bx.Name = "toolStripSeparator1";
		bx.Size = new Size(349, 6);
		this.m_bp.Image = (Image)componentResourceManager.GetObject("toolfrmRptAFLsit.Image");
		this.m_bp.Name = "toolfrmRptAFLsit";
		this.m_bp.ShowShortcutKeys = false;
		this.m_bp.Size = new Size(352, 30);
		this.m_bp.Text = "گزارشات";
		this.m_bp.Click += al;
		d2.Name = "toolStripSeparator49";
		d2.Size = new Size(349, 6);
		d3.Image = (Image)componentResourceManager.GetObject("toolfrmCommentList2.Image");
		d3.Name = "toolfrmCommentList2";
		d3.Size = new Size(352, 30);
		d3.Text = "لیست یادداشت های ثبت شده برای دانش آموزان";
		d3.Click += e;
		this.m_bo.DropDownItems.AddRange(new ToolStripItem[11]
		{
			d8, cr, this.m_bq, cs, b3, ct, this.m_bs, cu, this.m_br, d4,
			dm
		});
		this.m_bo.Image = menu.finance;
		this.m_bo.Name = "toolMali";
		this.m_bo.Size = new Size(100, 30);
		this.m_bo.Text = "امور مالی  ";
		d8.Image = (Image)componentResourceManager.GetObject("toolTakhfif.Image");
		d8.Name = "toolTakhfif";
		d8.Size = new Size(352, 30);
		d8.Text = "تعریف تخفیف";
		d8.Click += am;
		cr.Name = "toolStripSeparator36";
		cr.Size = new Size(349, 6);
		this.m_bq.Image = (Image)componentResourceManager.GetObject("toolPaymentAdd.Image");
		this.m_bq.Name = "toolPaymentAdd";
		this.m_bq.Size = new Size(352, 30);
		this.m_bq.Text = "مدیرت پرداخت ها";
		this.m_bq.Click += ak;
		cs.Name = "toolStripSeparator37";
		cs.Size = new Size(349, 6);
		b3.Image = (Image)componentResourceManager.GetObject("toolfrmPaymentList.Image");
		b3.Name = "toolfrmPaymentList";
		b3.Size = new Size(352, 30);
		b3.Text = "لیست کلیه پرداخت ها";
		b3.Click += aa;
		ct.Name = "toolStripSeparator38";
		ct.Size = new Size(349, 6);
		this.m_bs.Image = (Image)componentResourceManager.GetObject("toolRptBalance.Image");
		this.m_bs.Name = "toolRptBalance";
		this.m_bs.Size = new Size(352, 30);
		this.m_bs.Text = "دعوت پرداخت فیس بر اساس فصل";
		this.m_bs.Click += ai;
		cu.Name = "toolStripSeparator39";
		cu.Size = new Size(349, 6);
		this.m_br.Image = (Image)componentResourceManager.GetObject("toolRptPayment.Image");
		this.m_br.Name = "toolRptPayment";
		this.m_br.Size = new Size(352, 30);
		this.m_br.Text = "گزارشات";
		this.m_br.Click += aj;
		d4.Name = "toolStripSeparator53";
		d4.Size = new Size(349, 6);
		dm.Image = (Image)componentResourceManager.GetObject("toolfrmCommentList.Image");
		dm.Name = "toolfrmCommentList";
		dm.Size = new Size(352, 30);
		dm.Text = "لیست یادداشت های ثبت شده برای دانش آموزان";
		dm.Click += l;
		this.m_aa.DropDownItems.AddRange(new ToolStripItem[29]
		{
			this.m_ab, this.m_bb, this.m_ac, this.m_bc, this.m_a4, this.m_bd, by, cv, bz, b0,
			b4, b5, b7, b8, c7, db, b9, dc, c1, ca,
			this.m_ad, this.m_af, this.m_ae, this.m_be, this.m_ba, this.m_bf, this.m_ah, this.m_ag, this.m_bg
		});
		this.m_aa.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_aa.Image = menu.mark;
		this.m_aa.Name = "toolExam2";
		this.m_aa.Size = new Size(108, 30);
		this.m_aa.Text = "امور تعلیمی";
		this.m_ab.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ab.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem6.Image");
		this.m_ab.Name = "toolStripMenuItem6";
		this.m_ab.Size = new Size(284, 34);
		this.m_ab.Text = "تعریف دوره";
		this.m_ab.Click += bs;
		this.m_bb.Name = "toolStripSeparator11";
		this.m_bb.Size = new Size(281, 6);
		this.m_ac.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ac.ForeColor = Color.FromArgb(0, 0, 64);
		this.m_ac.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem7.Image");
		this.m_ac.Name = "toolStripMenuItem7";
		this.m_ac.Size = new Size(284, 34);
		this.m_ac.Text = "ورود نمرات";
		this.m_ac.Click += br;
		this.m_bc.Name = "toolStripSeparator12";
		this.m_bc.Size = new Size(281, 6);
		this.m_a4.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_a4.Image = (Image)componentResourceManager.GetObject("toolMarkEntryOne.Image");
		this.m_a4.Name = "toolMarkEntryOne";
		this.m_a4.Size = new Size(284, 34);
		this.m_a4.Text = "ورود و اصلاح نمرات فردی";
		this.m_a4.Click += a1;
		this.m_bd.Name = "toolStripSeparator13";
		this.m_bd.Size = new Size(281, 6);
		by.Font = new Font("B Nazanin", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		by.ForeColor = Color.FromArgb(0, 192, 192);
		by.Image = (Image)componentResourceManager.GetObject("toolCreateXlsToMarkEntry.Image");
		by.Name = "toolCreateXlsToMarkEntry";
		by.Size = new Size(284, 34);
		by.Text = "دریافت اکسل خام شاگردان برای ورود نمره";
		by.Click += bd;
		cv.Name = "toolStripSeparator40";
		cv.Size = new Size(281, 6);
		bz.Font = new Font("B Nazanin", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bz.ForeColor = Color.FromArgb(0, 192, 0);
		bz.Image = (Image)componentResourceManager.GetObject("toolImportMark.Image");
		bz.Name = "toolImportMark";
		bz.Size = new Size(284, 34);
		bz.Text = "ورود نمرات دوره از فایل اکسل";
		bz.Click += ad;
		b0.Name = "toolStripSeparator16";
		b0.Size = new Size(281, 6);
		b4.ForeColor = Color.FromArgb(64, 0, 64);
		b4.Image = (Image)componentResourceManager.GetObject("toolfrmSummaryResults.Image");
		b4.Name = "toolfrmSummaryResults";
		b4.Size = new Size(284, 34);
		b4.Text = "ثبت خلص نتایج هر صنف";
		b4.Click += z;
		b5.Name = "toolStripSeparator17";
		b5.Size = new Size(281, 6);
		b7.ForeColor = Color.FromArgb(192, 64, 0);
		b7.Image = (Image)componentResourceManager.GetObject("toolCommentKoll6.Image");
		b7.Name = "toolCommentKoll6";
		b7.Size = new Size(284, 34);
		b7.Text = "ثبت توضیحات جدول نتایج";
		b7.Click += x;
		b8.Name = "toolStripSeparator18";
		b8.Size = new Size(281, 6);
		c7.DropDownItems.AddRange(new ToolStripItem[3] { c8, c9, da });
		c7.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		c7.ForeColor = Color.Red;
		c7.Image = (Image)componentResourceManager.GetObject("toolfrmSetAcpTerm.Image");
		c7.Name = "toolfrmSetAcpTerm";
		c7.Size = new Size(284, 34);
		c7.Text = "ثبت نتایج ";
		c8.ForeColor = Color.FromArgb(64, 0, 0);
		c8.Name = "toolfrmSetAcpTerm1";
		c8.Size = new Size(259, 34);
		c8.Text = "ثبت نتیجه چهار و نیم ماهه";
		c8.Click += r;
		c9.Name = "toolStripSeparator46";
		c9.Size = new Size(256, 6);
		da.ForeColor = Color.FromArgb(0, 0, 64);
		da.Name = "toolfrmSetAcpTerm3";
		da.Size = new Size(259, 34);
		da.Text = "ثبت نتیجه نهایی";
		da.Click += q;
		db.Name = "toolStripSeparator48";
		db.Size = new Size(281, 6);
		b9.DropDownItems.AddRange(new ToolStripItem[3] { cb, cc, cd });
		b9.ForeColor = Color.Navy;
		b9.Image = (Image)componentResourceManager.GetObject("toolfrmSetgTerm.Image");
		b9.Name = "toolfrmSetgTerm";
		b9.Size = new Size(284, 34);
		b9.Text = "ثبت درجه صنف 12";
		cb.ForeColor = Color.FromArgb(64, 0, 0);
		cb.Name = "toolfrmSetgTerm1";
		cb.Size = new Size(203, 30);
		cb.Text = "درجه چهار و نیم ماهه";
		cb.Click += w;
		cc.Name = "toolStripSeparator20";
		cc.Size = new Size(200, 6);
		cd.ForeColor = Color.FromArgb(0, 0, 64);
		cd.Name = "toolfrmSetgTerm3";
		cd.Size = new Size(203, 30);
		cd.Text = "درجه نهایی";
		cd.Click += v;
		dc.Name = "toolStripSeparator47";
		dc.Size = new Size(281, 6);
		c1.DropDownItems.AddRange(new ToolStripItem[5] { c2, c5, c3, c6, c4 });
		c1.ForeColor = Color.Navy;
		c1.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem11.Image");
		c1.Name = "toolStripMenuItem11";
		c1.ShowShortcutKeys = false;
		c1.Size = new Size(284, 34);
		c1.Text = "امور صنف دوازدهم";
		c2.Checked = true;
		c2.CheckState = CheckState.Checked;
		c2.ForeColor = Color.Navy;
		c2.Image = (Image)componentResourceManager.GetObject("toolfrmMarkEntryAgo.Image");
		c2.Name = "toolfrmMarkEntryAgo";
		c2.Size = new Size(287, 30);
		c2.Text = "ثبت نمرات سنوات قبل صنف دوازدهم";
		c2.Click += u;
		c5.Name = "toolStripSeparator25";
		c5.Size = new Size(284, 6);
		c3.Checked = true;
		c3.CheckState = CheckState.Checked;
		c3.ForeColor = Color.Black;
		c3.Image = (Image)componentResourceManager.GetObject("toolfrmHazeriAgo10.Image");
		c3.Name = "toolfrmHazeriAgo10";
		c3.Size = new Size(287, 30);
		c3.Text = "ثبت حاضری سال دهم";
		c3.Click += t;
		c6.Name = "toolStripSeparator26";
		c6.Size = new Size(284, 6);
		c4.Checked = true;
		c4.CheckState = CheckState.Checked;
		c4.ForeColor = Color.Navy;
		c4.Image = (Image)componentResourceManager.GetObject("toolfrmHazeriAgo11.Image");
		c4.Name = "toolfrmHazeriAgo11";
		c4.Size = new Size(287, 30);
		c4.Text = "ثبت حاضری سال یازدهم";
		c4.Click += s;
		ca.Name = "toolStripSeparator19";
		ca.Size = new Size(281, 6);
		this.m_ad.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ad.Image = (Image)componentResourceManager.GetObject("toolRpt.Image");
		this.m_ad.Name = "toolRpt";
		this.m_ad.Size = new Size(284, 34);
		this.m_ad.Text = " گزارشات";
		this.m_ad.Click += bq;
		this.m_af.Name = "toolStripSeparator3";
		this.m_af.Size = new Size(281, 6);
		this.m_ae.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ae.ForeColor = Color.FromArgb(0, 0, 64);
		this.m_ae.Image = (Image)componentResourceManager.GetObject("toolRptChart.Image");
		this.m_ae.Name = "toolRptChart";
		this.m_ae.Size = new Size(284, 34);
		this.m_ae.Text = "گزارشات نموداری";
		this.m_ae.Click += be;
		this.m_be.Name = "toolStripSeparator14";
		this.m_be.Size = new Size(281, 6);
		this.m_ba.Image = (Image)componentResourceManager.GetObject("toolRptSelectStd.Image");
		this.m_ba.Name = "toolRptSelectStd";
		this.m_ba.Size = new Size(284, 34);
		this.m_ba.Text = "چاپ اطلاع نامه بر اساس شاگرد";
		this.m_ba.Click += aw;
		this.m_bf.Name = "toolStripSeparator15";
		this.m_bf.Size = new Size(281, 6);
		this.m_ah.Font = new Font("B Nazanin", 7f, FontStyle.Bold);
		this.m_ah.ForeColor = Color.FromArgb(0, 0, 64);
		this.m_ah.Image = (Image)componentResourceManager.GetObject("toolSms.Image");
		this.m_ah.Name = "toolSms";
		this.m_ah.Size = new Size(284, 34);
		this.m_ah.Text = "دریافت فایل اکسل نمرات برای ارسال پیامک به اولیا";
		this.m_ah.Visible = false;
		this.m_ah.Click += bf;
		this.m_ag.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_ag.Image = (Image)componentResourceManager.GetObject("toolfrmExportMarkToSite.Image");
		this.m_ag.Name = "toolfrmExportMarkToSite";
		this.m_ag.Size = new Size(284, 34);
		this.m_ag.Text = "ارسال نمرات به سایت";
		this.m_ag.Visible = false;
		this.m_ag.Click += bg;
		this.m_bg.Image = (Image)componentResourceManager.GetObject("toolfrmSendSmsMark_armaghan.Image");
		this.m_bg.Name = "toolfrmSendSmsMark_armaghan";
		this.m_bg.Size = new Size(284, 34);
		this.m_bg.Text = "ارسال نمرات از طریق پیامک ";
		this.m_bg.Visible = false;
		this.m_bg.Click += av;
		this.m_a5.DropDownItems.AddRange(new ToolStripItem[6] { this.m_a6, this.m_a7, this.m_bh, this.m_a8, this.m_a9, this.m_bi });
		this.m_a5.Name = "toolStripMenuItem9";
		this.m_a5.Size = new Size(71, 30);
		this.m_a5.Text = "انضباطی";
		this.m_a5.Visible = false;
		this.m_a6.Name = "toolDisciplinaryCases1";
		this.m_a6.Size = new Size(244, 30);
		this.m_a6.Text = "تعریف مورد انضباطی";
		this.m_a6.Click += a0;
		this.m_a7.Name = "toolDisciplinaryCases2";
		this.m_a7.Size = new Size(244, 30);
		this.m_a7.Text = "تعریف موارد تشویقی";
		this.m_a7.Click += az;
		this.m_bh.Name = "toolDisciplinaryCases3";
		this.m_bh.Size = new Size(244, 30);
		this.m_bh.Text = "تعریف اخطارهای آموزشی";
		this.m_bh.Click += au;
		this.m_a8.Name = "toolfrmDisciplinaryAddAbsent";
		this.m_a8.Size = new Size(244, 30);
		this.m_a8.Text = "ثبت غیبت و تاخیر روزانه";
		this.m_a8.Click += ay;
		this.m_a9.Name = "toolfrmDisciplinaryAdd";
		this.m_a9.Size = new Size(244, 30);
		this.m_a9.Text = "ثبت موارد انضباطی و تشویقی";
		this.m_a9.Click += ax;
		this.m_bi.Name = "toolRptDis";
		this.m_bi.Size = new Size(244, 30);
		this.m_bi.Text = "گزارشات";
		this.m_bi.Click += at;
		dn.DropDownItems.AddRange(new ToolStripItem[16]
		{
			@do, dp, dq, dr, ds, dt, du, dv, dw, dx,
			dy, dz, d5, d6, d0, d1
		});
		dn.ForeColor = Color.Fuchsia;
		dn.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem15.Image");
		dn.Name = "toolStripMenuItem15";
		dn.Size = new Size(129, 30);
		dn.Text = "طراحی سربرگ ";
		@do.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		@do.Image = (Image)componentResourceManager.GetObject("toolRptDynamic1.Image");
		@do.Name = "toolRptDynamic1";
		@do.Size = new Size(360, 30);
		@do.Text = "طراحی سربرگ امتحانی";
		@do.Click += k;
		dp.Name = "toolStripSeparator50";
		dp.Size = new Size(357, 6);
		dq.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		dq.ForeColor = Color.Red;
		dq.Image = (Image)componentResourceManager.GetObject("toolRptDynamic5.Image");
		dq.Name = "toolRptDynamic5";
		dq.Size = new Size(360, 30);
		dq.Text = "طراحی سربرگ امتحانی چند صفحه ای";
		dq.Click += j;
		dr.Name = "toolStripSeparator63";
		dr.Size = new Size(357, 6);
		ds.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ds.Image = (Image)componentResourceManager.GetObject("toolRptDynamic2.Image");
		ds.Name = "toolRptDynamic2";
		ds.Size = new Size(360, 30);
		ds.Text = "طراحی دعوت نامه و ...";
		ds.Click += i;
		dt.Name = "toolStripSeparator51";
		dt.Size = new Size(357, 6);
		du.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		du.ForeColor = Color.Navy;
		du.Image = (Image)componentResourceManager.GetObject("toolRptDynamic3.Image");
		du.Name = "toolRptDynamic3";
		du.Size = new Size(360, 30);
		du.Text = "طراحی فرم(تعهدنامه انضباطی و ...)";
		du.Click += h;
		dv.Name = "toolStripSeparator52";
		dv.Size = new Size(357, 6);
		dw.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		dw.Image = (Image)componentResourceManager.GetObject("toolRptDynamic4.Image");
		dw.Name = "toolRptDynamic4";
		dw.Size = new Size(360, 30);
		dw.Text = "طراحی کارت دانش آموزی و ...";
		dw.Click += g;
		dx.Name = "toolStripSeparator79";
		dx.Size = new Size(357, 6);
		dy.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		dy.ForeColor = Color.FromArgb(192, 0, 192);
		dy.Image = (Image)componentResourceManager.GetObject("toolRptDynamic6.Image");
		dy.Name = "toolRptDynamic6";
		dy.Size = new Size(360, 30);
		dy.Text = "طراحی کارت تبریک تولد";
		dy.Click += f;
		dz.Name = "toolStripSeparator80";
		dz.Size = new Size(357, 6);
		d5.BackColor = Color.FromArgb(192, 255, 192);
		d5.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		d5.Image = (Image)componentResourceManager.GetObject("toolfrmActivStdSarbarg.Image");
		d5.Name = "toolfrmActivStdSarbarg";
		d5.Size = new Size(360, 30);
		d5.Text = "فعال / غیرفعال کردن چاپ دانش آموزان در طراحی";
		d5.Click += b;
		d6.Name = "toolStripSeparator54";
		d6.Size = new Size(357, 6);
		d0.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		d0.ForeColor = Color.FromArgb(0, 64, 0);
		d0.Image = (Image)componentResourceManager.GetObject("toolfrmImportSarbargFile.Image");
		d0.Name = "toolfrmImportSarbargFile";
		d0.Size = new Size(360, 30);
		d0.Text = "دریافت الگوهایی طراحی شده سایر مکتب ها";
		d0.Click += c;
		d1.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		d1.Image = (Image)componentResourceManager.GetObject("toolSarbargReg.Image");
		d1.Name = "toolSarbargReg";
		d1.Size = new Size(360, 30);
		d1.Text = "عملیات فعال سازی";
		d1.Click += d;
		this.m_ao.DropDownItems.AddRange(new ToolStripItem[7] { this.m_as, cw, this.m_ap, cx, this.m_aq, cy, this.m_ar });
		this.m_ao.Image = menu.card;
		this.m_ao.Name = "toolLable";
		this.m_ao.Size = new Size(140, 30);
		this.m_ao.Text = "مدیریت امتحانات";
		this.m_as.Image = (Image)componentResourceManager.GetObject("toolHelpLable.Image");
		this.m_as.Name = "toolHelpLable";
		this.m_as.Size = new Size(264, 30);
		this.m_as.Text = "راهنمای استفاده ";
		this.m_as.Click += a7;
		cw.Name = "toolStripSeparator41";
		cw.Size = new Size(261, 6);
		this.m_ap.Image = (Image)componentResourceManager.GetObject("toolHoze.Image");
		this.m_ap.Name = "toolHoze";
		this.m_ap.Size = new Size(264, 30);
		this.m_ap.Text = "تعریف حوزه های امتحانی";
		this.m_ap.Click += ba;
		cx.Name = "toolStripSeparator42";
		cx.Size = new Size(261, 6);
		this.m_aq.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem8.Image");
		this.m_aq.Name = "toolStripMenuItem8";
		this.m_aq.Size = new Size(264, 30);
		this.m_aq.Text = "اختصاص شماره چوکی اتوماتیک";
		this.m_aq.Click += a9;
		cy.Name = "toolStripSeparator43";
		cy.Size = new Size(261, 6);
		this.m_ar.Image = (Image)componentResourceManager.GetObject("toolRptLable.Image");
		this.m_ar.Name = "toolRptLable";
		this.m_ar.Size = new Size(264, 30);
		this.m_ar.Text = "مشاهده گزارشات";
		this.m_ar.Click += a8;
		this.m_at.DropDownItems.AddRange(new ToolStripItem[5] { this.m_au, cz, this.m_aw, c0, this.m_av });
		this.m_at.Image = menu.telegram;
		this.m_at.Name = "toolTelegram";
		this.m_at.Size = new Size(88, 30);
		this.m_at.Text = "تلگرام   ";
		this.m_au.Image = (Image)componentResourceManager.GetObject("toolTelegramConfig.Image");
		this.m_au.Name = "toolTelegramConfig";
		this.m_au.Size = new Size(237, 30);
		this.m_au.Text = "تنظیمات تلگرام";
		this.m_au.Click += a5;
		cz.Name = "toolStripSeparator44";
		cz.Size = new Size(234, 6);
		this.m_aw.Image = (Image)componentResourceManager.GetObject("toollistTelegramMessage.Image");
		this.m_aw.Name = "toollistTelegramMessage";
		this.m_aw.Size = new Size(237, 30);
		this.m_aw.Text = "لیست پیام های ارسال شده";
		this.m_aw.Click += a4;
		c0.Name = "toolStripSeparator45";
		c0.Size = new Size(234, 6);
		this.m_av.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_av.ForeColor = Color.Goldenrod;
		this.m_av.Image = (Image)componentResourceManager.GetObject("toolSendMarkToTelegram.Image");
		this.m_av.Name = "toolSendMarkToTelegram";
		this.m_av.Size = new Size(237, 30);
		this.m_av.Text = "ارسال نمرات به تلگرام اولیا";
		this.m_av.Click += a6;
		this.m_g.DropDownItems.AddRange(new ToolStripItem[17]
		{
			this.m_bk, this.m_ai, this.m_ay, this.m_az, this.m_a0, this.m_a1, this.m_a2, this.m_a3, this.m_aj, this.m_ak,
			df, this.m_al, this.m_am, this.m_h, this.m_an, this.m_i, dk
		});
		this.m_g.Image = menu.Possibilities;
		this.m_g.Name = "toolEmkanat";
		this.m_g.Size = new Size(95, 30);
		this.m_g.Text = "امکانات   ";
		this.m_bk.Image = (Image)componentResourceManager.GetObject("toolfrmBackColor.Image");
		this.m_bk.Name = "toolfrmBackColor";
		this.m_bk.Size = new Size(312, 30);
		this.m_bk.Text = "تنظیم رنگ پس زمینه صفحات";
		this.m_bk.Click += ar;
		this.m_ai.Name = "toolStripSeparator5";
		this.m_ai.Size = new Size(309, 6);
		this.m_ay.Image = (Image)componentResourceManager.GetObject("toolfrmExpotMarkToXls.Image");
		this.m_ay.Name = "toolfrmExpotMarkToXls";
		this.m_ay.Size = new Size(312, 30);
		this.m_ay.Text = "دریافت خروجی اکسل نمرات دوره";
		this.m_ay.Click += a3;
		this.m_az.Name = "toolStripSeparator8";
		this.m_az.Size = new Size(309, 6);
		this.m_a0.Image = (Image)componentResourceManager.GetObject("toolCommentKoll.Image");
		this.m_a0.Name = "toolCommentKoll";
		this.m_a0.Size = new Size(312, 30);
		this.m_a0.Text = "توضیحات زیر اطلاع نامه-فردی و گروهی";
		this.m_a0.Click += bb;
		this.m_a1.Name = "toolStripSeparator9";
		this.m_a1.Size = new Size(309, 6);
		this.m_a2.Font = new Font("B Nazanin", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_a2.ForeColor = Color.FromArgb(192, 0, 192);
		this.m_a2.Image = (Image)componentResourceManager.GetObject("toolSarbarg.Image");
		this.m_a2.Name = "toolSarbarg";
		this.m_a2.Size = new Size(312, 30);
		this.m_a2.Text = "چاپ مشخصات شاگرد در برگه های امتحانی و ...";
		this.m_a2.Visible = false;
		this.m_a2.Click += a2;
		this.m_a3.Name = "toolStripSeparator10";
		this.m_a3.Size = new Size(309, 6);
		this.m_aj.Image = (Image)componentResourceManager.GetObject("toolBackUp.Image");
		this.m_aj.Name = "toolBackUp";
		this.m_aj.Size = new Size(312, 30);
		this.m_aj.Text = "پشتیبان گیری";
		this.m_aj.Click += bm;
		this.m_ak.Name = "toolStripSeparator4";
		this.m_ak.Size = new Size(309, 6);
		df.ForeColor = Color.Red;
		df.Image = (Image)componentResourceManager.GetObject("toolfrmSetDefYear.Image");
		df.Name = "toolfrmSetDefYear";
		df.Size = new Size(312, 30);
		df.Text = "سال تعلیمی پیش فرض";
		df.Click += p;
		this.m_al.ForeColor = Color.DarkRed;
		this.m_al.Image = (Image)componentResourceManager.GetObject("toolNewYear.Image");
		this.m_al.Name = "toolNewYear";
		this.m_al.Size = new Size(312, 30);
		this.m_al.Text = "انتقال شاگردان به پایه بالاتر";
		this.m_al.Click += bc;
		this.m_am.Name = "toolStripSeparator6";
		this.m_am.Size = new Size(309, 6);
		this.m_h.Image = (Image)componentResourceManager.GetObject("toolEmpty.Image");
		this.m_h.Name = "toolEmpty";
		this.m_h.Size = new Size(312, 30);
		this.m_h.Text = "خالی کردن بانک";
		this.m_h.Click += bl;
		this.m_an.Name = "toolStripSeparator7";
		this.m_an.Size = new Size(309, 6);
		this.m_i.Image = (Image)componentResourceManager.GetObject("toolUser.Image");
		this.m_i.Name = "toolUser";
		this.m_i.Size = new Size(312, 30);
		this.m_i.Text = "مدیریت کابران";
		this.m_i.Visible = false;
		dk.ForeColor = Color.Red;
		dk.Image = (Image)componentResourceManager.GetObject("toolfrmRegisterPak0.Image");
		dk.Name = "toolfrmRegisterPak0";
		dk.Size = new Size(312, 30);
		dk.Text = "فعال سازی امکان شبکه";
		dk.Click += m;
		this.m_x.DropDownItems.AddRange(new ToolStripItem[2] { this.m_y, this.m_z });
		this.m_x.Name = "toolhelp";
		this.m_x.Size = new Size(39, 30);
		this.m_x.Text = "راه";
		this.m_x.Visible = false;
		this.m_y.Name = "helpword";
		this.m_y.Size = new Size(161, 30);
		this.m_y.Text = "فرمت word";
		this.m_y.Click += bj;
		this.m_z.Name = "helpPdf";
		this.m_z.Size = new Size(161, 30);
		this.m_z.Text = "فرمت pdf";
		this.m_z.Click += bi;
		this.m_p.Name = "toolStripMenuItem4";
		this.m_p.Size = new Size(36, 30);
		this.m_p.Text = "ت";
		this.m_p.Visible = false;
		this.m_q.Image = menu.exit;
		this.m_q.Name = "toolStripMenuItem5";
		this.m_q.Size = new Size(76, 30);
		this.m_q.Text = "خروج";
		this.m_q.Click += bn;
		this.m_m.DropDownItems.AddRange(new ToolStripItem[1] { this.m_o });
		this.m_m.Name = "toolStripMenuItem1";
		this.m_m.Size = new Size(88, 20);
		this.m_m.Text = "تماس با شرکت";
		this.m_o.Name = "toolStripMenuItem3";
		this.m_o.Size = new Size(180, 22);
		this.m_o.Text = "toolStripMenuItem3";
		this.m_n.Name = "toolStripMenuItem2";
		this.m_n.Size = new Size(43, 20);
		this.m_n.Text = "خروج";
		this.m_s.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_s.AutoSize = true;
		this.m_s.BackColor = Color.FromArgb(192, 192, 255);
		this.m_s.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_s.Location = new Point(109, 612);
		this.m_s.Name = "label1";
		this.m_s.Size = new Size(84, 26);
		this.m_s.TabIndex = 52;
		this.m_s.Text = " : کد نرم افزار";
		this.m_s.DoubleClick += bh;
		this.m_t.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_t.BackColor = Color.FromArgb(192, 192, 255);
		this.m_t.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_t.Location = new Point(3, 612);
		this.m_t.Name = "l_xschool";
		this.m_t.RightToLeft = RightToLeft.Yes;
		this.m_t.Size = new Size(100, 26);
		this.m_t.TabIndex = 53;
		this.m_t.TextAlign = ContentAlignment.MiddleCenter;
		this.m_u.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_u.AutoSize = true;
		this.m_u.BackColor = Color.FromArgb(192, 192, 255);
		this.m_u.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_u.Location = new Point(109, 645);
		this.m_u.Name = "label3";
		this.m_u.Size = new Size(49, 26);
		this.m_u.TabIndex = 54;
		this.m_u.Text = " : ورژن";
		this.m_v.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_v.BackColor = Color.FromArgb(192, 255, 255);
		this.m_v.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_v.Location = new Point(3, 645);
		this.m_v.Name = "l_ver";
		this.m_v.RightToLeft = RightToLeft.Yes;
		this.m_v.Size = new Size(100, 26);
		this.m_v.TabIndex = 55;
		this.m_v.Text = "1402/11/19";
		this.m_v.TextAlign = ContentAlignment.MiddleCenter;
		this.m_v.DoubleClick += an;
		this.m_ax.Anchor = AnchorStyles.Top;
		this.m_ax.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		this.m_ax.Location = new Point(255, 164);
		this.m_ax.Name = "pictureBox1";
		this.m_ax.Size = new Size(466, 289);
		this.m_ax.TabIndex = 56;
		this.m_ax.TabStop = false;
		dd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		dd.AutoSize = true;
		dd.BackColor = Color.CornflowerBlue;
		dd.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		dd.ForeColor = Color.DarkViolet;
		dd.Location = new Point(889, 637);
		dd.Name = "label4";
		dd.RightToLeft = RightToLeft.Yes;
		dd.Size = new Size(98, 30);
		dd.TabIndex = 122;
		dd.Text = "سال تعلیمی :";
		de.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		de.BackColor = Color.CornflowerBlue;
		de.BorderStyle = BorderStyle.FixedSingle;
		de.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		de.ForeColor = Color.MediumBlue;
		de.Location = new Point(824, 637);
		de.Name = "lYear";
		de.RightToLeft = RightToLeft.Yes;
		de.Size = new Size(59, 32);
		de.TabIndex = 123;
		dh.ActiveFormatStyle.BackColor = Color.Teal;
		dh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		dh.ButtonStyle = ButtonStyle.Button;
		dh.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		dh.ImageIndex = 8;
		dh.Location = new Point(373, 634);
		dh.Name = "btnPer";
		dh.Size = new Size(130, 37);
		dh.TabIndex = 132;
		dh.Text = "مشاهده سطح دسترسی  کاربر";
		dh.Visible = false;
		dh.Click += n;
		di.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		di.BackColor = Color.CornflowerBlue;
		di.BorderStyle = BorderStyle.FixedSingle;
		di.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		di.ForeColor = Color.MediumBlue;
		di.Location = new Point(509, 637);
		di.Name = "lUser";
		di.RightToLeft = RightToLeft.Yes;
		di.Size = new Size(177, 32);
		di.TabIndex = 131;
		dj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		dj.BackColor = Color.CornflowerBlue;
		dj.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		dj.ForeColor = Color.DarkViolet;
		dj.Location = new Point(692, 637);
		dj.Name = "label2";
		dj.RightToLeft = RightToLeft.Yes;
		dj.Size = new Size(107, 30);
		dj.TabIndex = 130;
		dj.Text = "کاربر فعال :";
		dj.TextAlign = ContentAlignment.MiddleRight;
		dl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		dl.BackColor = Color.CornflowerBlue;
		dl.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		dl.ForeColor = Color.DarkViolet;
		dl.Location = new Point(225, 637);
		dl.Name = "lIsNetWork";
		dl.RightToLeft = RightToLeft.Yes;
		dl.Size = new Size(120, 30);
		dl.TabIndex = 133;
		dl.Text = "شما در شبکه هستید";
		dl.TextAlign = ContentAlignment.MiddleCenter;
		dl.Visible = false;
		AutoScaleBaseSize = new Size(5, 13);
		BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		BackgroundImageLayout = ImageLayout.Stretch;
		ClientSize = new Size(994, 672);
		Controls.Add(dl);
		Controls.Add(dh);
		Controls.Add(di);
		Controls.Add(dj);
		Controls.Add(de);
		Controls.Add(dd);
		Controls.Add(this.m_ax);
		Controls.Add(this.m_v);
		Controls.Add(this.m_u);
		Controls.Add(this.m_t);
		Controls.Add(this.m_s);
		Controls.Add(this.m_b);
		Font = new Font("Microsoft Sans Serif", 8.25f);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		Name = "frmMain";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "SMS نرم افزار ";
		WindowState = FormWindowState.Maximized;
		Load += bw;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)this.m_ax).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void bw(object A_0, EventArgs A_1)
{
    KeylessRuntime.Enable();
    this.m_t.Text = "بدون کلید سخت‌افزاری";
    this.m_b.Visible = false;
    this.m_v.Tag = asdab.c(asdcb.a(asdab.e(), CommandType.Text, "SELECT ver FROM tVer").ToString());
    using (asda3 login = new asda3()) { login.ShowDialog(this); }
    if (string.IsNullOrEmpty(asdaj.l)) { Close(); return; }
    asdaj.__field_a = asdcb.a(asdab.e(), CommandType.Text, "SELECT xYear FROM tDefYear").ToString();
    de.Text = asdaj.__field_a;
    di.Text = asdcb.a(asdab.e(), CommandType.Text, "SELECT uid FROM tUser WHERE id=" + asdaj.l).ToString();
    this.m_b.Visible = true;
    dh.Visible = asdaj.l == "1";
}
	private void bv(object A_0, EventArgs A_1)
	{
		asdca asdca2 = new asdca();
		asdca2.ShowDialog();
	}

	private void a()
{ }
	private void bu(object A_0, EventArgs A_1)
	{
		asdc asdc2 = new asdc();
		asdc2.ShowDialog();
	}

	private void bt(object A_0, EventArgs A_1)
	{
		asdm asdm2 = new asdm();
		asdm2.ShowDialog();
	}

	private void bs(object A_0, EventArgs A_1)
	{
		asdbq asdbq2 = new asdbq();
		asdbq2.ShowDialog();
	}

	private void br(object A_0, EventArgs A_1)
	{
		asdak asdak2 = new asdak();
		asdak2.ShowDialog();
	}

	private void bq(object A_0, EventArgs A_1)
	{
		asda0 asda10 = new asda0();
		asda10.ShowDialog();
	}

	private void bp(object A_0, EventArgs A_1)
	{
		asdbi asdbi2 = new asdbi();
		asdbi2.ShowDialog();
	}

	private void bo(object A_0, EventArgs A_1)
	{
		asdj asdj2 = new asdj();
		asdj2.ShowDialog();
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
		asda9 asda10 = new asda9();
		asda10.ShowDialog();
	}

	private void bl(object A_0, EventArgs A_1)
	{
		asdao asdao2 = new asdao();
		asdao2.ShowDialog();
	}

	private void bk(object A_0, EventArgs A_1)
	{
		asdcd asdcd2 = new asdcd();
		asdcd2.ShowDialog();
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
		asde asde2 = new asde();
		asde2.ShowDialog();
	}

	private void bg(object A_0, EventArgs A_1)
	{
		asdcc asdcc2 = new asdcc();
		asdcc2.ShowDialog();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		while (true)
		{
			bool flag = !(asdab.__field_c == "1");
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
					flag = DialogResult.Yes == MessageBox.Show("آیا میخواهید از برنامه خارج شوید", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					num = 2;
					continue;
				case 0:
					A_1.Cancel = true;
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
					asdbl2.ShowDialog();
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
		asdb0 asdb10 = new asdb0();
		asdb10.ShowDialog();
	}

	private void be(object A_0, EventArgs A_1)
	{
		asdap asdap2 = new asdap();
		asdap2.ShowDialog();
	}

	private void bd(object A_0, EventArgs A_1)
	{
		asdg asdg2 = new asdg();
		asdg2.ShowDialog();
	}

	private void bc(object A_0, EventArgs A_1)
	{
		asdbz asdbz2 = new asdbz();
		asdbz2.ShowDialog();
	}

	private void bb(object A_0, EventArgs A_1)
	{
		asdx asdx2 = new asdx();
		asdx2.p = "5";
		asdx2.ShowDialog();
	}

	private void ba(object A_0, EventArgs A_1)
	{
		asda1 asda10 = new asda1();
		asda10.ShowDialog();
	}

	private void a9(object A_0, EventArgs A_1)
	{
		asdb asdb10 = new asdb();
		asdb10.ShowDialog();
	}

	private void a8(object A_0, EventArgs A_1)
	{
		asdam asdam2 = new asdam();
		asdam2.ShowDialog();
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
		asdb10.ShowDialog();
	}

	private void a5(object A_0, EventArgs A_1)
	{
		asdb6 asdb10 = new asdb6();
		asdb10.ShowDialog();
	}

	private void a4(object A_0, EventArgs A_1)
	{
		asdbj asdbj2 = new asdbj();
		asdbj2.ShowDialog();
	}

	private void a3(object A_0, EventArgs A_1)
	{
		asdb5 asdb10 = new asdb5();
		asdb10.ShowDialog();
	}

	private void a2(object A_0, EventArgs A_1)
	{
		asdal asdal2 = new asdal();
		asdal2.ShowDialog();
	}

	private void a1(object A_0, EventArgs A_1)
	{
		asdby asdby2 = new asdby();
		asdby2.ShowDialog();
	}

	private void a0(object A_0, EventArgs A_1)
	{
		if (!OriginalFeatureGuard.RequireSchema(this, "موارد انضباطی", "dbo.tDisciplinaryCases", "dbo.sp_tDisciplinaryCases_InsertUpdate")) return;
		asdbm asdbm2 = new asdbm();
		asdbm2.ShowDialog();
	}

	private void az(object A_0, EventArgs A_1)
	{
		if (!OriginalFeatureGuard.RequireSchema(this, "موارد انضباطی", "dbo.tDisciplinaryCases", "dbo.sp_tDisciplinaryCases_InsertUpdate")) return;
		asdad asdad2 = new asdad();
		asdad2.ShowDialog();
	}

	private void ay(object A_0, EventArgs A_1)
	{
		asdbn asdbn2 = new asdbn();
		asdbn2.ShowDialog();
	}

	private void ax(object A_0, EventArgs A_1)
	{
		if (!OriginalFeatureGuard.RequireSchema(this, "ثبت عملکرد انضباطی", "dbo.tDisciplinaryCases", "dbo.tDisciplinaryStudent", "dbo.sp_tDisciplinaryStudent_insertUpdate")) return;
		asdn asdn2 = new asdn();
		asdn2.ShowDialog();
	}

	private void aw(object A_0, EventArgs A_1)
	{
		asdbw asdbw2 = new asdbw();
		asdbw2.ShowDialog();
	}

	private void av(object A_0, EventArgs A_1)
	{
		asdce asdce2 = new asdce();
		asdce2.ShowDialog();
	}

	private void au(object A_0, EventArgs A_1)
	{
		if (!OriginalFeatureGuard.RequireSchema(this, "موارد انضباطی", "dbo.tDisciplinaryCases", "dbo.sp_tDisciplinaryCases_InsertUpdate")) return;
		asdq asdq2 = new asdq();
		asdq2.ShowDialog();
	}

	private void at(object A_0, EventArgs A_1)
	{
		if (!OriginalFeatureGuard.RequireSchema(this, "گزارش انضباطی", "dbo.tRptDis", "dbo.tDisciplinaryCases", "dbo.tDisciplinaryStudent")) return;
		asdas asdas2 = new asdas();
		asdas2.ShowDialog();
	}

	private void @as(object A_0, EventArgs A_1)
	{
		asdaz asdaz2 = new asdaz();
		asdaz2.ShowDialog();
	}

	private void ar(object A_0, EventArgs A_1)
	{
		asda8 asda10 = new asda8();
		asda10.ShowDialog();
	}

	private void aq(object A_0, EventArgs A_1)
	{
		asdaa asdaa2 = new asdaa();
		asdaa2.ShowDialog();
	}

	private void ap(object A_0, EventArgs A_1)
	{
		asdp asdp2 = new asdp();
		asdp2.q = "1";
		asdp2.ShowDialog();
	}

	private void ao(object A_0, EventArgs A_1)
	{
		asdp asdp2 = new asdp();
		asdp2.q = "2";
		asdp2.ShowDialog();
	}

	private void an(object A_0, EventArgs A_1)
	{
		MessageBox.Show(this.m_v.Tag.ToString());
	}

	private void am(object A_0, EventArgs A_1)
	{
		asdh asdh2 = new asdh();
		asdh2.ShowDialog();
	}

	private void al(object A_0, EventArgs A_1)
	{
		asdb2 asdb10 = new asdb2();
		asdb10.ShowDialog();
	}

	private void ak(object A_0, EventArgs A_1)
	{
		asda5 asda10 = new asda5();
		asda10.ShowDialog();
	}

	private void aj(object A_0, EventArgs A_1)
	{
		asdbf asdbf2 = new asdbf();
		asdbf2.ShowDialog();
	}

	private void ai(object A_0, EventArgs A_1)
	{
		asdbo asdbo2 = new asdbo();
		asdbo2.ShowDialog();
	}

	private void ah(object A_0, EventArgs A_1)
	{
		asdl asdl2 = new asdl();
		asdl2.ShowDialog();
	}

	private void ag(object A_0, EventArgs A_1)
	{
		asdf asdf2 = new asdf();
		asdf2.ShowDialog();
	}

	private void af(object A_0, EventArgs A_1)
	{
		asdb7 asdb10 = new asdb7();
		asdb10.ShowDialog();
	}

	private void ae(object A_0, EventArgs A_1)
	{
		asdai asdai2 = new asdai();
		asdai2.ShowDialog();
	}

	private void ad(object A_0, EventArgs A_1)
	{
		asdv asdv2 = new asdv();
		asdv2.ShowDialog();
	}

	private void ac(object A_0, EventArgs A_1)
	{
		asdag asdag2 = new asdag();
		asdag2.ShowDialog();
	}

	private void ab(object A_0, EventArgs A_1)
	{
		asdo asdo2 = new asdo();
		asdo2.ShowDialog();
	}

	private void aa(object A_0, EventArgs A_1)
	{
		asdar asdar2 = new asdar();
		asdar2.ShowDialog();
	}

	private void z(object A_0, EventArgs A_1)
	{
		asdba asdba2 = new asdba();
		asdba2.ShowDialog();
	}

	private void y(object A_0, EventArgs A_1)
	{
		asdac asdac2 = new asdac();
		asdac2.ShowDialog();
	}

	private void x(object A_0, EventArgs A_1)
	{
		asdx asdx2 = new asdx();
		asdx2.p = "6";
		asdx2.ShowDialog();
	}

	private void w(object A_0, EventArgs A_1)
	{
		asdb8 asdb10 = new asdb8();
		asdb10.__field_c = "1";
		asdb10.ShowDialog();
	}

	private void v(object A_0, EventArgs A_1)
	{
		asdb8 asdb10 = new asdb8();
		asdb10.__field_c = "3";
		asdb10.ShowDialog();
	}

	private void u(object A_0, EventArgs A_1)
	{
		asdbh asdbh2 = new asdbh();
		asdbh2.ShowDialog();
	}

	private void t(object A_0, EventArgs A_1)
	{
		asdaq asdaq2 = new asdaq();
		asdaq2.__field_b = "10";
		asdaq2.ShowDialog();
	}

	private void s(object A_0, EventArgs A_1)
	{
		asdaq asdaq2 = new asdaq();
		asdaq2.__field_b = "11";
		asdaq2.ShowDialog();
	}

	private void r(object A_0, EventArgs A_1)
	{
		asda6 asda10 = new asda6();
		asda10.t = "1";
		asda10.ShowDialog();
	}

	private void q(object A_0, EventArgs A_1)
	{
		asda6 asda10 = new asda6();
		asda10.t = "3";
		asda10.ShowDialog();
	}

	private void p(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		asdav asdav2 = new asdav();
		asdav2.ShowDialog();
		de.Text = asdaj.__field_a;
	}

	private void o(object A_0, EventArgs A_1)
	{
		asdi asdi2 = new asdi();
		asdi2.ShowDialog();
	}

	private void n(object A_0, EventArgs A_1)
	{
		asds asds2 = new asds();
		asds2.o = asdaj.l;
		asds2.ShowDialog();
	}

	private void m(object A_0, EventArgs A_1)
{ MessageBox.Show("این نسخه به کلید سخت‌افزاری یا فعال‌سازی سخت‌افزار نیاز ندارد.", "Free SMS"); }
	private void l(object A_0, EventArgs A_1)
	{
		asdw asdw2 = new asdw();
		asdw2.ShowDialog();
	}

	private void k(object A_0, EventArgs A_1)
	{
		asdt asdt2 = new asdt();
		asdt2.bx = "1";
		asdt2.ShowDialog();
	}

	private void j(object A_0, EventArgs A_1)
	{
		asdt asdt2 = new asdt();
		asdt2.bx = "5";
		asdt2.ShowDialog();
	}

	private void i(object A_0, EventArgs A_1)
	{
		asdt asdt2 = new asdt();
		asdt2.bx = "2";
		asdt2.ShowDialog();
	}

	private void h(object A_0, EventArgs A_1)
	{
		asdt asdt2 = new asdt();
		asdt2.bx = "3";
		asdt2.ShowDialog();
	}

	private void g(object A_0, EventArgs A_1)
	{
		asdt asdt2 = new asdt();
		asdt2.bx = "4";
		asdt2.ShowDialog();
	}

	private void f(object A_0, EventArgs A_1)
	{
		asdt asdt2 = new asdt();
		asdt2.bx = "6";
		asdt2.ShowDialog();
	}

	private void e(object A_0, EventArgs A_1)
	{
		asdw asdw2 = new asdw();
		asdw2.ShowDialog();
	}

	private void d(object A_0, EventArgs A_1)
{ MessageBox.Show("این نسخه به کلید سخت‌افزاری یا فعال‌سازی سخت‌افزار نیاز ندارد.", "Free SMS"); }
	private void c(object A_0, EventArgs A_1)
	{
		asdah asdah2 = new asdah();
		asdah2.ShowDialog();
	}

	private void b(object A_0, EventArgs A_1)
	{
		asdau asdau2 = new asdau();
		asdau2.ShowDialog();
	}

	private void a(object A_0, EventArgs A_1)
	{
		asda7 asda10 = new asda7();
		asda10.ShowDialog();
	}
}
