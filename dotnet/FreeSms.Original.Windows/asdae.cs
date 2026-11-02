using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdae : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private OpenFileDialog m_c;

	private Panel m_d;

	private Label m_e;

	private Panel m_f;

	private Panel m_g;

	private TextBox h;

	private Label i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private Label m;

	private MaskedEditBox n;

	private MaskedEditBox o;

	private Label p;

	private MaskedEditBox q;

	private MaskedEditBox r;

	private Label s;

	private MaskedEditBox t;

	private MaskedEditBox u;

	private MaskedEditBox v;

	private MaskedEditBox w;

	private MaskedEditBox x;

	private MaskedEditBox y;

	private MaskedEditBox z;

	private MaskedEditBox aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private MaskedEditBox ak;

	private MaskedEditBox al;

	private MaskedEditBox am;

	private MaskedEditBox an;

	private Label ao;

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private Label at;

	private Label au;

	private Label av;

	public string aw;

	public string ax;

	public string ay;

	private bool az = false;
protected override void Dispose(bool A_0)
	{
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 0:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 6:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 3:
					{
						base.Dispose(A_0);
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
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdae));
		this.m_b = new Panel();
		av = new Label();
		ar = new Label();
		@as = new Label();
		at = new Label();
		au = new Label();
		this.m_e = new Label();
		this.m_f = new Panel();
		this.m_g = new Panel();
		ao = new Label();
		ap = new Label();
		aq = new Label();
		an = new MaskedEditBox();
		am = new MaskedEditBox();
		al = new MaskedEditBox();
		ak = new MaskedEditBox();
		ai = new Label();
		aj = new Label();
		ah = new Label();
		ag = new Label();
		af = new Label();
		ae = new Label();
		ab = new Label();
		ac = new Label();
		ad = new Label();
		x = new MaskedEditBox();
		y = new MaskedEditBox();
		z = new MaskedEditBox();
		aa = new MaskedEditBox();
		w = new MaskedEditBox();
		u = new MaskedEditBox();
		v = new MaskedEditBox();
		t = new MaskedEditBox();
		r = new MaskedEditBox();
		s = new Label();
		q = new MaskedEditBox();
		p = new Label();
		o = new MaskedEditBox();
		m = new Label();
		n = new MaskedEditBox();
		l = new Label();
		h = new TextBox();
		i = new Label();
		j = new UIButton();
		k = new UIButton();
		this.m_c = new OpenFileDialog();
		this.m_d = new Panel();
		this.m_b.SuspendLayout();
		this.m_f.SuspendLayout();
		this.m_g.SuspendLayout();
		this.m_d.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(av);
		this.m_b.Controls.Add(ar);
		this.m_b.Controls.Add(@as);
		this.m_b.Controls.Add(at);
		this.m_b.Controls.Add(au);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(5, 5);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(601, 450);
		this.m_b.TabIndex = 0;
		av.AutoSize = true;
		av.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		av.Location = new Point(102, 88);
		av.Name = "label19";
		av.Size = new Size(81, 17);
		av.TabIndex = 114;
		av.Text = "نوع عملیات :";
		ar.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ar.ForeColor = Color.Fuchsia;
		ar.Location = new Point(6, 87);
		ar.Name = "lTypecomand";
		ar.Size = new Size(90, 18);
		ar.TabIndex = 113;
		ar.Text = "اصلاح پرداخت";
		@as.BackColor = Color.FromArgb(0, 192, 192);
		@as.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		@as.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		@as.Location = new Point(349, 76);
		@as.Name = "lCode";
		@as.RightToLeft = RightToLeft.Yes;
		@as.Size = new Size(173, 37);
		@as.TabIndex = 112;
		@as.TextAlign = ContentAlignment.MiddleCenter;
		at.AutoSize = true;
		at.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		at.Location = new Point(528, 87);
		at.Name = "label5";
		at.Size = new Size(61, 17);
		at.TabIndex = 111;
		at.Text = "کد متعلم";
		au.AutoSize = true;
		au.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		au.Location = new Point(528, 26);
		au.Name = "label4";
		au.Size = new Size(51, 17);
		au.TabIndex = 110;
		au.Text = "نام -ولد";
		this.m_e.BackColor = Color.FromArgb(0, 192, 192);
		this.m_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_e.Font = new Font("B Nazanin", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.Location = new Point(10, 3);
		this.m_e.Name = "lName";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(512, 61);
		this.m_e.TabIndex = 77;
		this.m_e.TextAlign = ContentAlignment.MiddleCenter;
		this.m_f.BackColor = Color.Gray;
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(7, 125);
		this.m_f.Name = "pStd";
		this.m_f.Size = new Size(588, 317);
		this.m_f.TabIndex = 79;
		this.m_g.BackColor = Color.FromArgb(214, 223, 247);
		this.m_g.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_g.Controls.Add(ao);
		this.m_g.Controls.Add(ap);
		this.m_g.Controls.Add(aq);
		this.m_g.Controls.Add(an);
		this.m_g.Controls.Add(am);
		this.m_g.Controls.Add(al);
		this.m_g.Controls.Add(ak);
		this.m_g.Controls.Add(ai);
		this.m_g.Controls.Add(aj);
		this.m_g.Controls.Add(ah);
		this.m_g.Controls.Add(ag);
		this.m_g.Controls.Add(af);
		this.m_g.Controls.Add(ae);
		this.m_g.Controls.Add(ab);
		this.m_g.Controls.Add(ac);
		this.m_g.Controls.Add(ad);
		this.m_g.Controls.Add(x);
		this.m_g.Controls.Add(y);
		this.m_g.Controls.Add(z);
		this.m_g.Controls.Add(aa);
		this.m_g.Controls.Add(w);
		this.m_g.Controls.Add(u);
		this.m_g.Controls.Add(v);
		this.m_g.Controls.Add(t);
		this.m_g.Controls.Add(r);
		this.m_g.Controls.Add(s);
		this.m_g.Controls.Add(q);
		this.m_g.Controls.Add(p);
		this.m_g.Controls.Add(o);
		this.m_g.Controls.Add(m);
		this.m_g.Controls.Add(n);
		this.m_g.Controls.Add(l);
		this.m_g.Controls.Add(h);
		this.m_g.Controls.Add(i);
		this.m_g.Controls.Add(j);
		this.m_g.Controls.Add(k);
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(2, 3);
		this.m_g.Name = "panel3";
		this.m_g.Size = new Size(580, 307);
		this.m_g.TabIndex = 40;
		ao.AutoSize = true;
		ao.Location = new Point(107, 220);
		ao.Name = "label23";
		ao.Size = new Size(75, 16);
		ao.TabIndex = 138;
		ao.Text = "باقی مانده :";
		ap.AutoSize = true;
		ap.Location = new Point(316, 220);
		ap.Name = "label22";
		ap.Size = new Size(82, 16);
		ap.TabIndex = 137;
		ap.Text = "پرداخت شده:";
		aq.AutoSize = true;
		aq.Location = new Point(495, 220);
		aq.Name = "label14";
		aq.Size = new Size(80, 16);
		aq.TabIndex = 136;
		aq.Text = "فیس سالانه:";
		an.AutoScroll = false;
		an.AutoScrollMargin = new Size(0, 0);
		an.AutoScrollMinSize = new Size(0, 0);
		an.AutoScrollPosition = new Point(0, 0);
		an.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		an.Enabled = false;
		an.Location = new Point(16, 217);
		an.MaxLength = 9;
		an.Name = "txtMostPay";
		an.Numeric = true;
		an.RightToLeft = RightToLeft.Yes;
		an.Size = new Size(88, 23);
		an.TabIndex = 135;
		an.Tag = "";
		an.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		am.AutoScroll = false;
		am.AutoScrollMargin = new Size(0, 0);
		am.AutoScrollMinSize = new Size(0, 0);
		am.AutoScrollPosition = new Point(0, 0);
		am.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		am.Enabled = false;
		am.Location = new Point(227, 217);
		am.MaxLength = 9;
		am.Name = "txtStdPay";
		am.Numeric = true;
		am.RightToLeft = RightToLeft.Yes;
		am.Size = new Size(88, 23);
		am.TabIndex = 134;
		am.Tag = "";
		am.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		al.AutoScroll = false;
		al.AutoScrollMargin = new Size(0, 0);
		al.AutoScrollMinSize = new Size(0, 0);
		al.AutoScrollPosition = new Point(0, 0);
		al.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		al.Enabled = false;
		al.Location = new Point(405, 217);
		al.MaxLength = 9;
		al.Name = "txtSumFee";
		al.Numeric = true;
		al.RightToLeft = RightToLeft.Yes;
		al.Size = new Size(88, 23);
		al.TabIndex = 133;
		al.Tag = "";
		al.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ak.AutoScroll = false;
		ak.AutoScrollMargin = new Size(0, 0);
		ak.AutoScrollMinSize = new Size(0, 0);
		ak.AutoScrollPosition = new Point(0, 0);
		ak.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ak.Location = new Point(16, 140);
		ak.MaxLength = 9;
		ak.Name = "txtother";
		ak.Numeric = true;
		ak.RightToLeft = RightToLeft.Yes;
		ak.Size = new Size(88, 23);
		ak.TabIndex = 14;
		ak.Tag = "";
		ak.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ak.Leave += c;
		ak.Enter += d;
		ak.KeyDown += a;
		ai.AutoSize = true;
		ai.Location = new Point(110, 146);
		ai.Name = "label21";
		ai.Size = new Size(43, 16);
		ai.TabIndex = 132;
		ai.Text = "سایر :";
		aj.AutoSize = true;
		aj.Location = new Point(110, 111);
		aj.Name = "label18";
		aj.Size = new Size(47, 16);
		aj.TabIndex = 131;
		aj.Text = "داخله :";
		ah.AutoSize = true;
		ah.Location = new Point(110, 76);
		ah.Name = "label17";
		ah.Size = new Size(85, 16);
		ah.TabIndex = 130;
		ah.Text = "کمک درسی :";
		ag.AutoSize = true;
		ag.Location = new Point(110, 44);
		ag.Name = "label16";
		ag.Size = new Size(43, 16);
		ag.TabIndex = 129;
		ag.Text = "کتاب :";
		af.AutoSize = true;
		af.Location = new Point(110, 10);
		af.Name = "label15";
		af.Size = new Size(49, 16);
		af.TabIndex = 128;
		af.Text = "مقنعه :";
		ae.AutoSize = true;
		ae.Location = new Point(321, 109);
		ae.Name = "label13";
		ae.Size = new Size(56, 16);
		ae.TabIndex = 126;
		ae.Text = "یونیفرم :";
		ab.AutoSize = true;
		ab.Location = new Point(323, 77);
		ab.Name = "label11";
		ab.Size = new Size(54, 16);
		ab.TabIndex = 125;
		ab.Text = "امتحان :";
		ac.AutoSize = true;
		ac.Location = new Point(321, 43);
		ac.Name = "label9";
		ac.Size = new Size(50, 16);
		ac.TabIndex = 124;
		ac.Text = "جشن :";
		ad.AutoSize = true;
		ad.Location = new Point(321, 12);
		ad.Name = "label8";
		ad.Size = new Size(60, 16);
		ad.TabIndex = 123;
		ad.Text = "مسابقه :";
		x.AutoScroll = false;
		x.AutoScrollMargin = new Size(0, 0);
		x.AutoScrollMinSize = new Size(0, 0);
		x.AutoScrollPosition = new Point(0, 0);
		x.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Location = new Point(16, 106);
		x.MaxLength = 9;
		x.Name = "txtdakhle";
		x.Numeric = true;
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(88, 23);
		x.TabIndex = 13;
		x.Tag = "";
		x.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		x.Leave += c;
		x.Enter += d;
		x.KeyDown += a;
		y.AutoScroll = false;
		y.AutoScrollMargin = new Size(0, 0);
		y.AutoScrollMinSize = new Size(0, 0);
		y.AutoScrollPosition = new Point(0, 0);
		y.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		y.Location = new Point(16, 73);
		y.MaxLength = 9;
		y.Name = "txtkomakdarsi";
		y.Numeric = true;
		y.RightToLeft = RightToLeft.Yes;
		y.Size = new Size(88, 23);
		y.TabIndex = 11;
		y.Tag = "";
		y.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		y.Leave += c;
		y.Enter += d;
		y.KeyDown += a;
		z.AutoScroll = false;
		z.AutoScrollMargin = new Size(0, 0);
		z.AutoScrollMinSize = new Size(0, 0);
		z.AutoScrollPosition = new Point(0, 0);
		z.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		z.Location = new Point(16, 40);
		z.MaxLength = 9;
		z.Name = "txtketab";
		z.Numeric = true;
		z.RightToLeft = RightToLeft.Yes;
		z.Size = new Size(88, 23);
		z.TabIndex = 10;
		z.Tag = "";
		z.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		z.Leave += c;
		z.Enter += d;
		z.KeyDown += a;
		aa.AutoScroll = false;
		aa.AutoScrollMargin = new Size(0, 0);
		aa.AutoScrollMinSize = new Size(0, 0);
		aa.AutoScrollPosition = new Point(0, 0);
		aa.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aa.Location = new Point(16, 8);
		aa.MaxLength = 9;
		aa.Name = "txtmaghnae";
		aa.Numeric = true;
		aa.RightToLeft = RightToLeft.Yes;
		aa.Size = new Size(88, 23);
		aa.TabIndex = 9;
		aa.Tag = "";
		aa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		aa.Leave += c;
		aa.Enter += d;
		aa.KeyDown += a;
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Location = new Point(227, 106);
		w.MaxLength = 9;
		w.Name = "txtuniform";
		w.Numeric = true;
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(88, 23);
		w.TabIndex = 8;
		w.Tag = "";
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		w.Leave += c;
		w.Enter += d;
		w.KeyDown += a;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(227, 73);
		u.MaxLength = 9;
		u.Name = "txtExam";
		u.Numeric = true;
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(88, 23);
		u.TabIndex = 7;
		u.Tag = "";
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.Leave += c;
		u.Enter += d;
		u.KeyDown += a;
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Location = new Point(227, 40);
		v.MaxLength = 9;
		v.Name = "txtCelebration";
		v.Numeric = true;
		v.RightToLeft = RightToLeft.Yes;
		v.Size = new Size(88, 23);
		v.TabIndex = 6;
		v.Tag = "";
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		v.Leave += c;
		v.Enter += d;
		v.KeyDown += a;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		t.Location = new Point(227, 8);
		t.MaxLength = 9;
		t.Name = "txtracing";
		t.Numeric = true;
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(88, 23);
		t.TabIndex = 5;
		t.Tag = "";
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.Leave += c;
		t.Enter += d;
		t.KeyDown += a;
		r.AutoScroll = false;
		r.AutoScrollMargin = new Size(0, 0);
		r.AutoScrollMinSize = new Size(0, 0);
		r.AutoScrollPosition = new Point(0, 0);
		r.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Location = new Point(405, 106);
		r.MaxLength = 9;
		r.Name = "txtTransport";
		r.Numeric = true;
		r.RightToLeft = RightToLeft.Yes;
		r.Size = new Size(88, 23);
		r.TabIndex = 3;
		r.Tag = "";
		r.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		r.Leave += c;
		r.Enter += d;
		r.KeyDown += a;
		s.AutoSize = true;
		s.Location = new Point(501, 109);
		s.Name = "label3";
		s.Size = new Size(74, 16);
		s.TabIndex = 113;
		s.Text = "ترانسپورت :";
		q.AutoScroll = false;
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		q.AutoScrollPosition = new Point(0, 0);
		q.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Location = new Point(405, 73);
		q.MaxLength = 9;
		q.Name = "txtFee";
		q.Numeric = true;
		q.RightToLeft = RightToLeft.Yes;
		q.Size = new Size(88, 23);
		q.TabIndex = 2;
		q.Tag = "";
		q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.Leave += c;
		q.Enter += d;
		q.KeyDown += a;
		p.AutoSize = true;
		p.Location = new Point(501, 42);
		p.Name = "label1";
		p.Size = new Size(60, 16);
		p.TabIndex = 111;
		p.Text = " نمبر بل :";
		o.AutoScroll = false;
		o.AutoScrollMargin = new Size(0, 0);
		o.AutoScrollMinSize = new Size(0, 0);
		o.AutoScrollPosition = new Point(0, 0);
		o.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(405, 40);
		o.MaxLength = 9;
		o.Name = "txtNamberBel";
		o.Numeric = true;
		o.RightToLeft = RightToLeft.Yes;
		o.Size = new Size(88, 23);
		o.TabIndex = 1;
		o.Tag = "";
		o.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		o.Leave += c;
		o.Enter += d;
		o.KeyDown += a;
		m.AutoSize = true;
		m.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Location = new Point(501, 9);
		m.Name = "label12";
		m.Size = new Size(44, 17);
		m.TabIndex = 109;
		m.Text = "تاریخ :";
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(407, 8);
		n.Mask = "0000/00/00";
		n.MaxLength = 12;
		n.Name = "txtPaynemtDate";
		n.Numeric = true;
		n.RightToLeft = RightToLeft.No;
		n.Size = new Size(86, 22);
		n.TabIndex = 0;
		n.Tag = "";
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		n.Leave += c;
		n.Enter += d;
		n.KeyDown += a;
		l.AutoSize = true;
		l.Location = new Point(501, 76);
		l.Name = "label6";
		l.Size = new Size(44, 16);
		l.TabIndex = 48;
		l.Text = "فیس :";
		h.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		h.Location = new Point(163, 139);
		h.Multiline = true;
		h.Name = "txtComment";
		h.Size = new Size(331, 61);
		h.TabIndex = 4;
		h.KeyDown += a;
		h.Leave += a;
		h.Enter += b;
		i.AutoSize = true;
		i.Location = new Point(501, 142);
		i.Name = "label2";
		i.Size = new Size(66, 16);
		i.TabIndex = 42;
		i.Text = "توضیحات :";
		j.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		j.Location = new Point(19, 259);
		j.Name = "btnCancel";
		j.Size = new Size(110, 39);
		j.TabIndex = 16;
		j.Text = "انصراف(Esc)";
		j.Click += e;
		k.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		k.Location = new Point(147, 259);
		k.Name = "btnAcp";
		k.Size = new Size(110, 39);
		k.TabIndex = 15;
		k.Text = "ثبت(F3)";
		k.Click += f;
		this.m_c.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_c.Title = "انتخاب عکس شاگرد";
		this.m_d.BackColor = Color.Black;
		this.m_d.Controls.Add(this.m_b);
		this.m_d.Dock = DockStyle.Fill;
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "panel2";
		this.m_d.Size = new Size(611, 461);
		this.m_d.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(611, 461);
		Controls.Add(this.m_d);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmPaymentInsertUpdate";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست پرداخت های شاگرد";
		Load += g;
		KeyUp += b;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		this.m_g.ResumeLayout(performLayout: false);
		this.m_g.PerformLayout();
		this.m_d.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdae()
	{
		c();
	}

	private void g(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("9");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 3;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 1;
					continue;
				case 4:
				case 7:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xStudent", SqlDbType.Int, aw) };
					DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select code,fname,lname from tstudent where  id=@xStudent", a_);
					this.m_e.Text = dataTable2.Rows[0]["fname"].ToString() + " - " + dataTable2.Rows[0]["lname"].ToString();
					@as.Text = dataTable2.Rows[0]["code"].ToString();
					flag = !(ay != "0");
					num = 13;
					continue;
				}
				case 13:
					if (!flag)
					{
						num = 14;
						continue;
					}
					ar.Text = "پرداخت جدید";
					num = 0;
					continue;
				case 10:
					flag = !(asdaj.k == "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 5;
						continue;
					}
					n.Text = asdaj.k;
					num = 4;
					continue;
				case 8:
					num = 6;
					continue;
				case 1:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 10;
				case 0:
				case 2:
					b();
					n.Focus();
					num = 12;
					continue;
				case 12:
					return;
				case 6:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_b.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 10;
					continue;
				case 14:
					ar.Text = "اصلاح پرداخت";
					a();
					if (true)
					{
					}
					num = 2;
					continue;
				case 5:
					n.Text = asdab.b();
					num = 7;
					continue;
				case 3:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 9;
					continue;
				case 9:
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
		SqlParameter[] a_ = new SqlParameter[2]
		{
			asdcb.a("@xYear", SqlDbType.Int, ax),
			asdcb.a("@xStudent", SqlDbType.Int, aw)
		};
		int num = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "select isnull(SumFee,0) from tYear_Student where xStudent=@xStudent and xYear=@xYear", a_).ToString());
		int num2 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "select isnull(Sum(fee),0) from tPaymentStudent where xStudent=@xStudent and xYear=@xYear", a_).ToString());
		int num3 = num - num2;
		al.Text = num.ToString();
		am.Text = num2.ToString();
		an.Text = num3.ToString();
	}

	private void a()
	{
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[3]
		{
			asdcb.a("@xYear", SqlDbType.Int, ax),
			asdcb.a("@id", SqlDbType.Int, ay),
			asdcb.a("@xStudent", SqlDbType.Int, aw)
		};
		DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * FROM tPaymentStudent where xStudent=@xStudent and xYear=@xYear and id=@id", a_);
		n.Text = dataTable.Rows[0]["PaynemtDate"].ToString();
		o.Text = dataTable.Rows[0]["NamberBel"].ToString();
		q.Text = dataTable.Rows[0]["Fee"].ToString();
		r.Text = dataTable.Rows[0]["Transport"].ToString();
		t.Text = dataTable.Rows[0]["racing"].ToString();
		v.Text = dataTable.Rows[0]["Celebration"].ToString();
		u.Text = dataTable.Rows[0]["Exam"].ToString();
		w.Text = dataTable.Rows[0]["uniform"].ToString();
		aa.Text = dataTable.Rows[0]["maghnae"].ToString();
		z.Text = dataTable.Rows[0]["ketab"].ToString();
		y.Text = dataTable.Rows[0]["komakdarsi"].ToString();
		x.Text = dataTable.Rows[0]["dakhle"].ToString();
		ak.Text = dataTable.Rows[0]["other"].ToString();
		h.Text = dataTable.Rows[0]["comment"].ToString();
	}

	private void f(object A_0, EventArgs A_1)
	{
        // The original SQL contract uses non-negative Int32 amounts. Validate before
        // calling it so malformed or negative entries cannot fail SQL or reduce totals.
        var amounts = new[] {q,r,t,v,u,w,aa,z,y,x,ak};
        var normalized = new string[amounts.Length];
        long total=0;
        for(int index=0;index<amounts.Length;index++)
        {
            try
            {
                int? paymentAmount=FreeSms.Core.Values.Number(amounts[index].Text,0);
                total+=paymentAmount??0;
                if(total>int.MaxValue)throw new FreeSms.Core.ValidationException("Payment total overflow.");
                normalized[index]=paymentAmount?.ToString(System.Globalization.CultureInfo.InvariantCulture)??"";
            }
            catch(FreeSms.Core.ValidationException)
            {
                MessageBox.Show("مبلغ باید عدد صحیح غیرمنفی باشد و مجموع پرداخت از ۲۱۴۷۴۸۳۶۴۷ بیشتر نباشد");
                amounts[index].Focus();return;
            }
        }
        for(int index=0;index<amounts.Length;index++)amounts[index].Text=normalized[index];
		SqlParameter[] array = default;
		object value2 = default;
		bool flag2 = default;
		object value5 = default;
		object value4 = default;
		object value = default;
		object value11 = default;
		object value10 = default;
		object value8 = default;
		object value7 = default;
		object value6 = default;
		object value9 = default;
		object value3 = default;
		int num12 = default;
		bool flag = default;
		while (true)
		{
			asdaj.k = n.Text;
			string text = "";
			int num = 113;
			while (true)
			{
				int num2;
				int num5;
				int num10;
				int num4;
				int num13;
				int num3;
				int num6;
				int num9;
				int num7;
				int num11;
				int num8;
				switch (num)
				{
				case 38:
					if (!flag)
					{
						num = 55;
						continue;
					}
					goto case 27;
				case 67:
					num2 = 0;
					goto IL_09bc;
				case 80:
					num = 88;
					continue;
				case 88:
					num5 = ((!(u.Text == "0")) ? 1 : 0);
					goto IL_0de1;
				case 63:
					num10 = 0;
					goto IL_05eb;
				case 71:
					num = 114;
					continue;
				case 114:
					num4 = ((!(aa.Text == "0")) ? 1 : 0);
					goto IL_0bf8;
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(array[0].Value.ToString() == "-200");
					num = 40;
					continue;
				case 85:
					asdaj.i = true;
					MessageBox.Show("ثبت شد");
					Close();
					num = 43;
					continue;
				case 43:
					return;
				case 8:
				case 82:
					value2 = v.Text;
					num = 73;
					continue;
				case 73:
					num = ((v.Text.Trim() == "") ? 56 : 0);
					continue;
				case 91:
					num4 = 0;
					goto IL_0bf8;
				case 49:
					num = 12;
					continue;
				case 12:
					num13 = ((!(t.Text == "0")) ? 1 : 0);
					goto IL_0f5d;
				case 2:
					num = 118;
					continue;
				case 118:
					num10 = ((!(x.Text == "0")) ? 1 : 0);
					goto IL_05eb;
				case 97:
					if (!flag)
					{
						num = 25;
						continue;
					}
					flag2 = true;
					num = 76;
					continue;
				case 109:
					text = "دوشنبه";
					num = 29;
					continue;
				case 30:
				case 60:
					flag = flag2;
					num = 21;
					continue;
				case 21:
					if (flag)
					{
						array = new SqlParameter[21]
						{
							asdcb.a("@code", SqlDbType.Int),
							asdcb.a("@id", SqlDbType.Int, ay),
							asdcb.a("@xYear", SqlDbType.Int, ax),
							asdcb.a("@xStudent", SqlDbType.Int, aw),
							asdcb.a("@PaynemtDate", SqlDbType.NVarChar, n.Text),
							asdcb.a("@dayOfWeek", SqlDbType.NVarChar, text),
							asdcb.a("@NamberBel", SqlDbType.NVarChar, o.Text.Trim()),
							asdcb.a("@Fee", SqlDbType.Int, value5),
							asdcb.a("@Transport", SqlDbType.Int, value4),
							asdcb.a("@racing", SqlDbType.Int, value),
							asdcb.a("@Celebration", SqlDbType.Int, value2),
							asdcb.a("@Exam", SqlDbType.Int, value11),
							asdcb.a("@uniform", SqlDbType.Int, value10),
							asdcb.a("@maghnae", SqlDbType.Int, value8),
							asdcb.a("@ketab", SqlDbType.Int, value7),
							asdcb.a("@komakdarsi", SqlDbType.Int, value6),
							asdcb.a("@dakhle", SqlDbType.Int, value9),
							asdcb.a("@other", SqlDbType.Int, value3),
							asdcb.a("@comment", SqlDbType.NVarChar, h.Text.Trim()),
							asdcb.a("@Date", SqlDbType.NVarChar, asdab.b() + "-" + asdab.c()),
							asdcb.a("@xUser", SqlDbType.Int, asdaj.l)
						};
						num12 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tPaymentStudent_insertUpdate", array);
						flag = !(array[0].Value.ToString() == "-100");
						num = 6;
					}
					else
					{
						num = 83;
					}
					continue;
				case 89:
					value11 = DBNull.Value;
					num = 59;
					continue;
				case 104:
					value10 = DBNull.Value;
					num = 64;
					continue;
				case 79:
					num3 = 0;
					goto IL_0736;
				case 3:
					MessageBox.Show("در این تاریخ یک پرداخت ثبت شده است\n\nامکان ثبت بیشتر از یک پرداخت در هر روز برای شاگرد امکان پذیر نیست\n\nدر صورت نیاز ، پرداخت موجود در این تاریخ را اصلاح نمایید");
					num = 45;
					continue;
				case 45:
					return;
				case 7:
					num6 = 0;
					goto IL_103c;
				case 26:
					if (!flag)
					{
						num = 115;
						continue;
					}
					flag = !(text == "Thursday");
					num = 13;
					continue;
				case 120:
					if (!flag)
					{
						num = 39;
						continue;
					}
					flag2 = true;
					num = 57;
					continue;
				case 119:
					if (!flag)
					{
						num = 75;
						continue;
					}
					flag = !(text == "Monday");
					num = 121;
					continue;
				case 27:
				case 29:
				case 37:
				case 54:
				case 87:
				case 101:
				case 108:
					flag2 = false;
					value5 = q.Text;
					num = 66;
					continue;
				case 66:
					num = ((q.Text.Trim() == "") ? 100 : 42);
					continue;
				case 20:
					MessageBox.Show("مبلغ وارد شده برای فیس بالاتر از مقدار باقی مانده است ");
					num = 24;
					continue;
				case 24:
					return;
				case 0:
					num = 41;
					continue;
				case 41:
					num9 = ((!(v.Text == "0")) ? 1 : 0);
					goto IL_082e;
				case 34:
					if (!flag)
					{
						num = 65;
						continue;
					}
					flag2 = true;
					num = 116;
					continue;
				case 13:
					if (true)
					{
					}
					if (flag)
					{
						flag = !(text == "Friday");
						num = 38;
					}
					else
					{
						num = 105;
					}
					continue;
				case 1:
					value = DBNull.Value;
					num = 8;
					continue;
				case 50:
				case 78:
					value7 = z.Text;
					num = 81;
					continue;
				case 81:
					num = ((z.Text.Trim() == "") ? 107 : 90);
					continue;
				case 55:
					text = "جمعه";
					num = 54;
					continue;
				case 115:
					text = "چهارشنبه";
					num = 87;
					continue;
				case 102:
					if (!flag)
					{
						num = 85;
						continue;
					}
					return;
				case 105:
					text = "پنج شنبه";
					num = 27;
					continue;
				case 83:
					MessageBox.Show("جهت ثبت پرداخت حداقل یکی از گزینه ها باید وارد شود");
					q.Focus();
					num = 48;
					continue;
				case 48:
					return;
				case 70:
					if (!flag)
					{
						num = 104;
						continue;
					}
					flag2 = true;
					num = 62;
					continue;
				case 9:
					text = "شنبه";
					num = 37;
					continue;
				case 107:
					num7 = 0;
					goto IL_0c22;
				case 113:
					try
					{
						while (true)
						{
							IL_0a2e:
							DateTime date = ShamsiDate.ShamsiToGregory(n.Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
							flag = !(shamsiDate != n.Text);
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
									text = date.DayOfWeek.ToString();
									num = 3;
									continue;
								case 1:
									MessageBox.Show("تاریخ پرداخت اشتباه است");
									n.Focus();
									num = 2;
									continue;
								case 2:
									return;
								case 3:
									goto end_IL_0a15;
								}
								goto IL_0a2e;
								continue;
								end_IL_0a15:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ پرداخت اشتباه است");
						n.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 96;
					continue;
				case 84:
					num13 = 0;
					goto IL_0f5d;
				case 23:
				case 112:
					value9 = x.Text;
					num = 10;
					continue;
				case 10:
					num = ((!(x.Text.Trim() == "")) ? 2 : 63);
					continue;
				case 86:
				case 116:
					value11 = u.Text;
					num = 111;
					continue;
				case 111:
					num = ((u.Text.Trim() == "") ? 72 : 80);
					continue;
				case 121:
					if (!flag)
					{
						num = 109;
						continue;
					}
					flag = !(text == "Tuesday");
					num = 4;
					continue;
				case 18:
					if (flag)
					{
						flag2 = true;
						num = 78;
					}
					else
					{
						num = 17;
					}
					continue;
				case 106:
					if (flag)
					{
						flag2 = true;
						num = 52;
					}
					else
					{
						num = 35;
					}
					continue;
				case 56:
					num9 = 0;
					goto IL_082e;
				case 100:
					num11 = 0;
					goto IL_11d3;
				case 59:
				case 117:
					value10 = w.Text;
					num = 53;
					continue;
				case 53:
					num = ((!(w.Text.Trim() == "")) ? 92 : 67);
					continue;
				case 40:
					if (flag)
					{
						flag = num12 <= 0;
						num = 102;
					}
					else
					{
						num = 20;
					}
					continue;
				case 25:
					value9 = DBNull.Value;
					num = 32;
					continue;
				case 42:
					num = 110;
					continue;
				case 110:
					num11 = ((!(q.Text == "0")) ? 1 : 0);
					goto IL_11d3;
				case 11:
					value6 = DBNull.Value;
					num = 112;
					continue;
				case 17:
					value8 = DBNull.Value;
					num = 50;
					continue;
				case 62:
				case 64:
					value8 = aa.Text;
					num = 16;
					continue;
				case 16:
					num = ((!(aa.Text.Trim() == "")) ? 71 : 91);
					continue;
				case 94:
					if (!flag)
					{
						num = 89;
						continue;
					}
					flag2 = true;
					num = 117;
					continue;
				case 28:
				case 58:
					value4 = r.Text;
					num = 93;
					continue;
				case 93:
					num = ((!(r.Text.Trim() == "")) ? 14 : 79);
					continue;
				case 68:
					value5 = DBNull.Value;
					num = 58;
					continue;
				case 61:
					num = 69;
					continue;
				case 69:
					num8 = ((!(y.Text == "0")) ? 1 : 0);
					goto IL_1066;
				case 35:
					value7 = DBNull.Value;
					num = 51;
					continue;
				case 51:
				case 52:
					value6 = y.Text;
					num = 47;
					continue;
				case 47:
					num = ((y.Text.Trim() == "") ? 95 : 61);
					continue;
				case 4:
					if (flag)
					{
						flag = !(text == "Wednesday");
						num = 26;
					}
					else
					{
						num = 36;
					}
					continue;
				case 46:
					if (flag)
					{
						flag2 = true;
						num = 82;
					}
					else
					{
						num = 1;
					}
					continue;
				case 32:
				case 76:
					value3 = ak.Text;
					num = 103;
					continue;
				case 103:
					num = ((!(ak.Text.Trim() == "")) ? 22 : 7);
					continue;
				case 96:
					if (flag)
					{
						flag = !(text == "Sunday");
						num = 119;
					}
					else
					{
						num = 9;
					}
					continue;
				case 39:
					value4 = DBNull.Value;
					num = 33;
					continue;
				case 99:
					if (flag)
					{
						flag2 = true;
						num = 30;
					}
					else
					{
						num = 74;
					}
					continue;
				case 19:
					if (flag)
					{
						flag2 = true;
						num = 23;
					}
					else
					{
						num = 11;
					}
					continue;
				case 95:
					num8 = 0;
					goto IL_1066;
				case 90:
					num = 98;
					continue;
				case 98:
					num7 = ((!(z.Text == "0")) ? 1 : 0);
					goto IL_0c22;
				case 22:
					num = 44;
					continue;
				case 44:
					num6 = ((!(ak.Text == "0")) ? 1 : 0);
					goto IL_103c;
				case 72:
					num5 = 0;
					goto IL_0de1;
				case 74:
					value3 = DBNull.Value;
					num = 60;
					continue;
				case 65:
					value2 = DBNull.Value;
					num = 86;
					continue;
				case 33:
				case 57:
					value = t.Text;
					num = 15;
					continue;
				case 15:
					num = ((!(t.Text.Trim() == "")) ? 49 : 84);
					continue;
				case 36:
					text = "سه شنبه";
					num = 101;
					continue;
				case 75:
					text = "یکشنبه";
					num = 108;
					continue;
				case 31:
					if (flag)
					{
						flag2 = true;
						num = 28;
					}
					else
					{
						num = 68;
					}
					continue;
				case 14:
					num = 77;
					continue;
				case 77:
					num3 = ((!(r.Text == "0")) ? 1 : 0);
					goto IL_0736;
				case 92:
					num = 5;
					continue;
				case 5:
					{
						num2 = ((!(w.Text == "0")) ? 1 : 0);
						goto IL_09bc;
					}
					IL_09bc:
					flag = (byte)num2 != 0;
					num = 70;
					continue;
					IL_082e:
					flag = (byte)num9 != 0;
					num = 34;
					continue;
					IL_1066:
					flag = (byte)num8 != 0;
					num = 19;
					continue;
					IL_0bf8:
					flag = (byte)num4 != 0;
					num = 18;
					continue;
					IL_103c:
					flag = (byte)num6 != 0;
					num = 99;
					continue;
					IL_11d3:
					flag = (byte)num11 != 0;
					num = 31;
					continue;
					IL_0736:
					flag = (byte)num3 != 0;
					num = 120;
					continue;
					IL_05eb:
					flag = (byte)num10 != 0;
					num = 97;
					continue;
					IL_0de1:
					flag = (byte)num5 != 0;
					num = 94;
					continue;
					IL_0c22:
					flag = (byte)num7 != 0;
					num = 106;
					continue;
					IL_0f5d:
					flag = (byte)num13 != 0;
					num = 46;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, KeyEventArgs A_1)
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
					num = ((A_1.KeyCode != Keys.F3) ? 8 : 4);
					continue;
				case 4:
					if (true)
					{
					}
					num = 7;
					continue;
				case 7:
					num2 = ((!this.m_f.Visible) ? 1 : 0);
					goto IL_008a;
				case 8:
					num2 = 1;
					goto IL_008a;
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = A_1.KeyCode != Keys.Escape;
					num = 9;
					continue;
				case 2:
					f(this, null);
					num = 6;
					continue;
				case 6:
					return;
				case 0:
					e(this, null);
					num = 5;
					continue;
				case 5:
					return;
				case 9:
					{
						if (!flag)
						{
							num = 0;
							continue;
						}
						return;
					}
					IL_008a:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Return;
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
					SendKeys.Send("{tab}");
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void c(object A_0, EventArgs A_1)
	{
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromName("Window");
	}

	private void b(object A_0, EventArgs A_1)
	{
		h.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		h.BackColor = Color.FromName("Window");
	}
}
