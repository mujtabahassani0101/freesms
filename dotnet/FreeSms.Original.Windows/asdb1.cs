using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
protected override void Dispose(bool A_0)
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
					base.Dispose(A_0);
					return;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb1));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
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
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		aj.SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		j.SuspendLayout();
		this.m_c.SuspendLayout();
		((ISupportInitialize)aa).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		SuspendLayout();
		this.m_a.BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(8, 8);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(751, 615);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(aj);
		this.m_b.Controls.Add(ae);
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(x);
		this.m_b.Controls.Add(v);
		this.m_b.Controls.Add(j);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(733, 597);
		this.m_b.TabIndex = 16;
		aj.Controls.Add(ak);
		aj.Controls.Add(ai);
		aj.Controls.Add(ah);
		aj.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aj.Location = new Point(13, 413);
		aj.Name = "groupBox1";
		aj.RightToLeft = RightToLeft.Yes;
		aj.Size = new Size(414, 68);
		aj.TabIndex = 68;
		aj.TabStop = false;
		aj.Text = "ارسال نمرات یک نمونه به تلگرام  شماره همراه زیر جهت اطمینان";
		ak.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ak.ImageSize = new Size(30, 30);
		ak.Location = new Point(18, 34);
		ak.Name = "btnSendTest";
		ak.Size = new Size(154, 25);
		ak.TabIndex = 69;
		ak.Text = "ارسال نمونه";
		ak.Click += a;
		ai.Location = new Point(191, 36);
		ai.MaxLength = 11;
		ai.Name = "txtTestMobil";
		ai.Size = new Size(170, 23);
		ai.TabIndex = 66;
		ah.AutoSize = true;
		ah.Font = new Font("Tahoma", 8.25f);
		ah.Location = new Point(367, 39);
		ah.Name = "label9";
		ah.Size = new Size(41, 13);
		ah.TabIndex = 67;
		ah.Text = "موبایل  ";
		ae.AutoSize = true;
		ae.Font = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ae.ForeColor = Color.Maroon;
		ae.Location = new Point(147, 7);
		ae.Name = "label11";
		ae.Size = new Size(152, 31);
		ae.TabIndex = 64;
		ae.Text = "ارسال نمرات به تلگرام";
		w.AutoSize = true;
		w.Checked = true;
		w.CheckState = CheckState.Checked;
		w.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.Location = new Point(145, 337);
		w.Name = "checksendTo2";
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(130, 17);
		w.TabIndex = 65;
		w.Text = "ارسال برای موبایل مادر";
		w.UseVisualStyleBackColor = true;
		x.AutoSize = true;
		x.Checked = true;
		x.CheckState = CheckState.Checked;
		x.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		x.Location = new Point(299, 337);
		x.Name = "checksendTo1";
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(125, 17);
		x.TabIndex = 64;
		x.Text = "ارسال برای موبایل پدر";
		x.UseVisualStyleBackColor = true;
		v.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		v.ImageSize = new Size(30, 30);
		v.Location = new Point(165, 360);
		v.Name = "btnProcc";
		v.Size = new Size(262, 25);
		v.TabIndex = 59;
		v.Text = "ارسال به تلگرام";
		v.Click += e;
		j.Controls.Add(ag);
		j.Controls.Add(af);
		j.Controls.Add(o);
		j.Controls.Add(p);
		j.Controls.Add(q);
		j.Controls.Add(r);
		j.Controls.Add(s);
		j.Controls.Add(t);
		j.Controls.Add(u);
		j.Controls.Add(i);
		j.Controls.Add(this.m_f);
		j.Controls.Add(h);
		j.Controls.Add(k);
		j.Controls.Add(l);
		j.Controls.Add(g);
		j.Controls.Add(m);
		j.Controls.Add(n);
		j.Font = new Font("Tahoma", 8.25f);
		j.Location = new Point(41, 38);
		j.Name = "uiGroupBox1";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(386, 268);
		j.TabIndex = 56;
		j.Text = "ترکیب پیام ارسالی";
		ag.AutoSize = true;
		ag.Checked = true;
		ag.CheckState = CheckState.Checked;
		ag.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.Location = new Point(15, 238);
		ag.Name = "checkgkolliClass";
		ag.RightToLeft = RightToLeft.Yes;
		ag.Size = new Size(100, 17);
		ag.TabIndex = 64;
		ag.Text = "رتبه کل در صنف";
		ag.UseVisualStyleBackColor = true;
		af.AutoSize = true;
		af.Checked = true;
		af.CheckState = CheckState.Checked;
		af.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		af.Location = new Point(15, 143);
		af.Name = "checkgbookClass";
		af.RightToLeft = RightToLeft.Yes;
		af.Size = new Size(109, 17);
		af.TabIndex = 63;
		af.Text = "رتبه درس در صنف";
		af.UseVisualStyleBackColor = true;
		o.AutoSize = true;
		o.Font = new Font("Tahoma", 8.25f);
		o.Location = new Point(181, 175);
		o.Name = "label8";
		o.Size = new Size(15, 13);
		o.TabIndex = 62;
		o.Text = "+";
		p.AutoSize = true;
		p.Font = new Font("Tahoma", 8.25f);
		p.Location = new Point(312, 198);
		p.Name = "label7";
		p.Size = new Size(60, 13);
		p.TabIndex = 61;
		p.Text = "جمله پایانی";
		q.Location = new Point(32, 197);
		q.Name = "txtfoter";
		q.Size = new Size(272, 21);
		q.TabIndex = 60;
		r.AutoSize = true;
		r.Font = new Font("Tahoma", 8.25f);
		r.Location = new Point(135, 151);
		r.Name = "label6";
		r.Size = new Size(102, 13);
		r.TabIndex = 59;
		r.Text = "نام درس + نمره و ...";
		s.AutoSize = true;
		s.Font = new Font("Tahoma", 8.25f);
		s.Location = new Point(181, 127);
		s.Name = "label5";
		s.Size = new Size(15, 13);
		s.TabIndex = 58;
		s.Text = "+";
		t.AutoSize = true;
		t.Font = new Font("Tahoma", 8.25f);
		t.Location = new Point(180, 90);
		t.Name = "label4";
		t.Size = new Size(15, 13);
		t.TabIndex = 57;
		t.Text = "+";
		u.AutoSize = true;
		u.Font = new Font("Tahoma", 8.25f);
		u.Location = new Point(180, 53);
		u.Name = "label3";
		u.Size = new Size(15, 13);
		u.TabIndex = 56;
		u.Text = "+";
		i.AutoSize = true;
		i.Checked = true;
		i.CheckState = CheckState.Checked;
		i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Location = new Point(127, 238);
		i.Name = "checkgkolli";
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(89, 17);
		i.TabIndex = 49;
		i.Text = "رتبه کل در پایه";
		i.UseVisualStyleBackColor = true;
		this.m_f.AutoSize = true;
		this.m_f.Checked = true;
		this.m_f.CheckState = CheckState.Checked;
		this.m_f.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(222, 238);
		this.m_f.Name = "checkmKolli";
		this.m_f.RightToLeft = RightToLeft.Yes;
		this.m_f.Size = new Size(81, 17);
		this.m_f.TabIndex = 48;
		this.m_f.Text = "معدل دروس";
		this.m_f.UseVisualStyleBackColor = true;
		h.Location = new Point(34, 31);
		h.Name = "txtheder1";
		h.Size = new Size(272, 21);
		h.TabIndex = 51;
		k.AutoSize = true;
		k.Checked = true;
		k.CheckState = CheckState.Checked;
		k.Enabled = false;
		k.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(123, 68);
		k.Name = "checkNameStd";
		k.RightToLeft = RightToLeft.Yes;
		k.Size = new Size(157, 17);
		k.TabIndex = 55;
		k.Text = "نام و نام خانوادگی شاگرد";
		k.UseVisualStyleBackColor = true;
		l.AutoSize = true;
		l.Font = new Font("Tahoma", 8.25f);
		l.Location = new Point(310, 35);
		l.Name = "label1";
		l.Size = new Size(67, 13);
		l.TabIndex = 52;
		l.Text = "جمله ابتدایی";
		g.AutoSize = true;
		g.Checked = true;
		g.CheckState = CheckState.Checked;
		g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.Location = new Point(27, 166);
		g.Name = "checkgbook";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(98, 17);
		g.TabIndex = 47;
		g.Text = "رتبه درس در پایه";
		g.UseVisualStyleBackColor = true;
		m.AutoSize = true;
		m.Font = new Font("Tahoma", 8.25f);
		m.Location = new Point(310, 108);
		m.Name = "label2";
		m.Size = new Size(59, 13);
		m.TabIndex = 54;
		m.Text = "جمله بعدی";
		n.Location = new Point(31, 104);
		n.Name = "txtheder2";
		n.Size = new Size(272, 21);
		n.TabIndex = 53;
		this.m_e.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_e.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(20, 20);
		this.m_e.Location = new Point(13, 519);
		this.m_e.Name = "uiButton2";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(123, 64);
		this.m_e.TabIndex = 46;
		this.m_e.Text = "خروج";
		this.m_e.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_e.Click += f;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(ab);
		this.m_c.Controls.Add(ac);
		this.m_c.Controls.Add(y);
		this.m_c.Controls.Add(z);
		this.m_c.Controls.Add(aa);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Location = new Point(450, 4);
		this.m_c.Name = "panel3";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(272, 579);
		this.m_c.TabIndex = 36;
		ab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ab.AutoSize = true;
		ab.Location = new Point(237, 17);
		ab.Name = "label10";
		ab.Size = new Size(29, 13);
		ab.TabIndex = 128;
		ab.Text = "دوره";
		ac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ac.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ac.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ac.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ac.Location = new Point(4, 14);
		ac.Name = "dropExam";
		ac.Size = new Size(232, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		ac.StringFormat = stringFormat;
		ac.TabIndex = 127;
		ac.SelectedIndexChanged += b;
		y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		y.AutoSize = true;
		y.Location = new Point(242, 50);
		y.Name = "label20";
		y.Size = new Size(24, 13);
		y.TabIndex = 126;
		y.Text = "پایه";
		z.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		z.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		z.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		z.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		z.Location = new Point(3, 46);
		z.Name = "dropPaye";
		z.RightToLeft = RightToLeft.Yes;
		z.Size = new Size(233, 20);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		z.StringFormat = stringFormat2;
		z.TabIndex = 125;
		z.SelectedIndexChanged += d;
		aa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		aa.DesignTimeLayout = gridEXLayout;
		aa.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		aa.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa.GroupByBoxVisible = false;
		aa.Location = new Point(8, 72);
		aa.Name = "gClass";
		aa.RightToLeft = RightToLeft.Yes;
		aa.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		aa.Size = new Size(240, 116);
		aa.TabIndex = 124;
		aa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.CardCaptionPrefix = "Product:";
		this.m_d.Cursor = Cursors.Default;
		this.m_d.DataMember = null;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_d.DesignTimeLayout = gridEXLayout2;
		this.m_d.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_d.FlatBorderColor = SystemColors.ControlDark;
		this.m_d.Font = new Font("Tahoma", 8.25f);
		this.m_d.GridLineColor = SystemColors.ScrollBar;
		this.m_d.GroupByBoxVisible = false;
		this.m_d.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_d.Location = new Point(6, 194);
		this.m_d.Name = "gBook";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_d.SelectedFormatStyle.Blend = 0.5f;
		this.m_d.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_d.Size = new Size(240, 368);
		this.m_d.TabIndex = 39;
		this.m_d.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.CornflowerBlue;
		ClientSize = new Size(767, 633);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmSendSmsMarkTelegram";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "دریافت فایل اکسل نمرات برای ارسال پیامک";
		Load += c;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		aj.ResumeLayout(performLayout: false);
		aj.PerformLayout();
		((ISupportInitialize)j).EndInit();
		j.ResumeLayout(performLayout: false);
		j.PerformLayout();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)aa).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam  where xYear=" + asdaj.__field_a + " order by id desc");
			ac.DataSource = dataSource;
			ac.DisplayMember = "Name";
			ac.ValueMember = "id";
			bool flag = ac.Items.Count <= 0;
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
			bool flag = z.Items.Count <= 0;
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
			string text = " where  xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
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
		Close();
	}

	private void a(bool A_0)
	{
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
					x.Focus();
					num = 48;
					continue;
				case 48:
					return;
				case 12:
				{
					DialogResult dialogResult = MessageBox.Show(" هیچ درسی انتخاب نشده است آیا میخواهید ادامه دهید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
					flag = dialogResult == DialogResult.Yes;
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
					aa.Focus();
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
						asdcb.a("@heder1", SqlDbType.NVarChar, 200, h.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, 200, n.Text),
						asdcb.a("@foter", SqlDbType.NVarChar, 200, q.Text),
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
					q.Text = dataTable.Rows[0]["foter"].ToString();
					h.Text = dataTable.Rows[0]["heder"].ToString();
					ai.Text = dataTable.Rows[0]["testmobil"].ToString();
					num = 0;
					continue;
				case 5:
					g.Visible = false;
					af.Visible = false;
					i.Visible = false;
					this.m_f.Visible = false;
					ag.Visible = false;
					num = 2;
					continue;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
		while (true)
		{
			ai.Text = asdaj.b(ai.Text);
			bool flag = !(ai.Text == "");
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
						long num2 = long.Parse(ai.Text);
					}
					catch
					{
						MessageBox.Show("برای شماره موبایل فقط عدد وراد کنید");
						ai.Focus();
						return;
					}
					flag = !(ai.Text.Substring(0, 2) != "09");
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
						asdcb.a("@testmobil", SqlDbType.NVarChar, 11, ai.Text),
						asdcb.a("@heder", SqlDbType.NVarChar, 200, h.Text),
						asdcb.a("@foter", SqlDbType.NVarChar, 200, q.Text)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetTelegramConfigTestMobil", a_);
					a(A_0: true);
					num = 4;
					continue;
				}
				case 10:
					if (flag)
					{
						string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(id) AS countId FROM tTelegramId WHERE  Mobile =" + ai.Text).ToString();
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
					ai.Focus();
					num = 3;
					continue;
				case 3:
					return;
				case 9:
					MessageBox.Show("شماره موبایل برای ارسال نمونه را وارد کنید");
					ai.Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					MessageBox.Show("شماره موبایل باید 11 رقم باشد");
					ai.Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 4:
					return;
				case 12:
					if (flag)
					{
						flag = ai.Text.Length >= 11;
						num = 10;
					}
					else
					{
						num = 6;
					}
					continue;
				case 6:
					MessageBox.Show("شماره موبایل باید با 09 شروع شود");
					ai.Focus();
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
