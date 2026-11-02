using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdce : Form
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

	private EditBox v;

	private UIButton w;

	private UIButton x;

	private Label y;

	private ProgressBar z;

	private CheckBox aa;

	private CheckBox ab;

	private Label ac;

	private UIComboBox ad;

	private GridEX ae;

	private Label af;

	private UIComboBox ag;

	private FolderBrowserDialog ah;

	private Container ai = null;

	private string aj = Application.StartupPath + "\\xls\\sms.xls";

	public asdce()
	{
		e();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
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
						num = 3;
						continue;
					}
					goto case 4;
				case 1:
					num = 4;
					continue;
				case 5:
					ai.Dispose();
					num = 1;
					continue;
				case 3:
					flag = ai == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 1;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb0));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		aa = new CheckBox();
		ab = new CheckBox();
		y = new Label();
		z = new ProgressBar();
		x = new UIButton();
		v = new EditBox();
		w = new UIButton();
		j = new UIGroupBox();
		o = new Label();
		p = new Label();
		q = new TextBox();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		h = new TextBox();
		k = new CheckBox();
		l = new Label();
		m = new Label();
		n = new TextBox();
		i = new CheckBox();
		this.m_f = new CheckBox();
		g = new CheckBox();
		this.m_e = new UIButton();
		this.m_c = new Panel();
		af = new Label();
		ag = new UIComboBox();
		ac = new Label();
		ad = new UIComboBox();
		ae = new GridEX();
		this.m_d = new GridEX();
		ah = new FolderBrowserDialog();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		j.SuspendLayout();
		this.m_c.SuspendLayout();
		((ISupportInitialize)ae).BeginInit();
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
		this.m_b.Controls.Add(aa);
		this.m_b.Controls.Add(ab);
		this.m_b.Controls.Add(y);
		this.m_b.Controls.Add(z);
		this.m_b.Controls.Add(x);
		this.m_b.Controls.Add(v);
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(j);
		this.m_b.Controls.Add(i);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Controls.Add(g);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(733, 597);
		this.m_b.TabIndex = 16;
		aa.AutoSize = true;
		aa.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aa.Location = new Point(119, 506);
		aa.Name = "checksendTo2";
		aa.RightToLeft = RightToLeft.Yes;
		aa.Size = new Size(130, 17);
		aa.TabIndex = 65;
		aa.Text = "ارسال برای موبایل مادر";
		aa.UseVisualStyleBackColor = true;
		ab.AutoSize = true;
		ab.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.Location = new Point(273, 506);
		ab.Name = "checksendTo1";
		ab.RightToLeft = RightToLeft.Yes;
		ab.Size = new Size(125, 17);
		ab.TabIndex = 64;
		ab.Text = "ارسال برای موبایل پدر";
		ab.UseVisualStyleBackColor = true;
		y.AutoSize = true;
		y.Font = new Font("Tahoma", 8.25f);
		y.Location = new Point(306, 442);
		y.Name = "label9";
		y.Size = new Size(87, 13);
		y.TabIndex = 63;
		y.Text = "مسیر فایل اکسل";
		z.Location = new Point(7, 539);
		z.Name = "pr12";
		z.Size = new Size(437, 16);
		z.TabIndex = 60;
		x.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		x.ImageSize = new Size(30, 30);
		x.Location = new Point(297, 561);
		x.Name = "btnProcc";
		x.Size = new Size(147, 25);
		x.TabIndex = 59;
		x.Text = "ایجاد فایل";
		x.Click += d;
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.Location = new Point(88, 458);
		v.Name = "txtpath";
		v.Size = new Size(305, 20);
		v.TabIndex = 58;
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		w.Font = new Font("Tahoma", 8.25f);
		w.Location = new Point(7, 457);
		w.Name = "btnselectPath";
		w.Size = new Size(75, 20);
		w.TabIndex = 57;
		w.Text = "انتخاب مسير";
		w.Click += e;
		j.Controls.Add(o);
		j.Controls.Add(p);
		j.Controls.Add(q);
		j.Controls.Add(r);
		j.Controls.Add(s);
		j.Controls.Add(t);
		j.Controls.Add(u);
		j.Controls.Add(h);
		j.Controls.Add(k);
		j.Controls.Add(l);
		j.Controls.Add(m);
		j.Controls.Add(n);
		j.Font = new Font("Tahoma", 8.25f);
		j.Location = new Point(41, 75);
		j.Name = "uiGroupBox1";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(386, 318);
		j.TabIndex = 56;
		j.Text = "ترکیب پیام ارسالی";
		o.AutoSize = true;
		o.Font = new Font("Tahoma", 8.25f);
		o.Location = new Point(180, 244);
		o.Name = "label8";
		o.Size = new Size(15, 13);
		o.TabIndex = 62;
		o.Text = "+";
		p.AutoSize = true;
		p.Font = new Font("Tahoma", 8.25f);
		p.Location = new Point(312, 274);
		p.Name = "label7";
		p.Size = new Size(60, 13);
		p.TabIndex = 61;
		p.Text = "جمله پایانی";
		q.Location = new Point(35, 269);
		q.Name = "txtfoter";
		q.Size = new Size(273, 21);
		q.TabIndex = 60;
		r.AutoSize = true;
		r.Font = new Font("Tahoma", 8.25f);
		r.Location = new Point(128, 216);
		r.Name = "label6";
		r.Size = new Size(102, 13);
		r.TabIndex = 59;
		r.Text = "نام درس + نمره و ...";
		s.AutoSize = true;
		s.Font = new Font("Tahoma", 8.25f);
		s.Location = new Point(180, 193);
		s.Name = "label5";
		s.Size = new Size(15, 13);
		s.TabIndex = 58;
		s.Text = "+";
		t.AutoSize = true;
		t.Font = new Font("Tahoma", 8.25f);
		t.Location = new Point(180, 124);
		t.Name = "label4";
		t.Size = new Size(15, 13);
		t.TabIndex = 57;
		t.Text = "+";
		u.AutoSize = true;
		u.Font = new Font("Tahoma", 8.25f);
		u.Location = new Point(180, 65);
		u.Name = "label3";
		u.Size = new Size(15, 13);
		u.TabIndex = 56;
		u.Text = "+";
		h.Location = new Point(34, 31);
		h.Name = "txtheder1";
		h.Size = new Size(272, 21);
		h.TabIndex = 51;
		k.AutoSize = true;
		k.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(125, 101);
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
		m.AutoSize = true;
		m.Font = new Font("Tahoma", 8.25f);
		m.Location = new Point(310, 160);
		m.Name = "label2";
		m.Size = new Size(59, 13);
		m.TabIndex = 54;
		m.Text = "جمله بعدی";
		n.Location = new Point(34, 157);
		n.Name = "txtheder2";
		n.Size = new Size(272, 21);
		n.TabIndex = 53;
		i.AutoSize = true;
		i.Checked = true;
		i.CheckState = CheckState.Checked;
		i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Location = new Point(98, 37);
		i.Name = "checkgkolli";
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(83, 17);
		i.TabIndex = 49;
		i.Text = "رتبه در معدل";
		i.UseVisualStyleBackColor = true;
		this.m_f.AutoSize = true;
		this.m_f.Checked = true;
		this.m_f.CheckState = CheckState.Checked;
		this.m_f.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(240, 37);
		this.m_f.Name = "checkmKolli";
		this.m_f.RightToLeft = RightToLeft.Yes;
		this.m_f.Size = new Size(81, 17);
		this.m_f.TabIndex = 48;
		this.m_f.Text = "معدل دروس";
		this.m_f.UseVisualStyleBackColor = true;
		g.AutoSize = true;
		g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.Location = new Point(353, 37);
		g.Name = "checkgbook";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(68, 17);
		g.TabIndex = 47;
		g.Text = "رتبه درس";
		g.UseVisualStyleBackColor = true;
		this.m_e.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_e.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(20, 20);
		this.m_e.Location = new Point(7, 561);
		this.m_e.Name = "uiButton2";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(123, 25);
		this.m_e.TabIndex = 46;
		this.m_e.Text = "خروج";
		this.m_e.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_e.Click += f;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(af);
		this.m_c.Controls.Add(ag);
		this.m_c.Controls.Add(ac);
		this.m_c.Controls.Add(ad);
		this.m_c.Controls.Add(ae);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Location = new Point(450, 4);
		this.m_c.Name = "panel3";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(272, 579);
		this.m_c.TabIndex = 36;
		af.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		af.AutoSize = true;
		af.Location = new Point(237, 17);
		af.Name = "label10";
		af.Size = new Size(29, 13);
		af.TabIndex = 128;
		af.Text = "دوره";
		ag.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ag.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ag.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ag.Location = new Point(4, 14);
		ag.Name = "dropExam";
		ag.Size = new Size(232, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		ag.StringFormat = stringFormat;
		ag.TabIndex = 127;
		ag.SelectedIndexChanged += a;
		ac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ac.AutoSize = true;
		ac.Location = new Point(242, 50);
		ac.Name = "label20";
		ac.Size = new Size(24, 13);
		ac.TabIndex = 126;
		ac.Text = "پایه";
		ad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ad.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ad.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ad.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ad.Location = new Point(3, 46);
		ad.Name = "dropPaye";
		ad.RightToLeft = RightToLeft.Yes;
		ad.Size = new Size(233, 20);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		ad.StringFormat = stringFormat2;
		ad.TabIndex = 125;
		ad.SelectedIndexChanged += c;
		ae.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		ae.DesignTimeLayout = gridEXLayout;
		ae.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		ae.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae.GroupByBoxVisible = false;
		ae.Location = new Point(8, 72);
		ae.Name = "gClass";
		ae.RightToLeft = RightToLeft.Yes;
		ae.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		ae.Size = new Size(240, 116);
		ae.TabIndex = 124;
		ae.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
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
		Name = "frmSendSmsMark";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "دریافت فایل اکسل نمرات برای ارسال پیامک";
		Load += b;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)j).EndInit();
		j.ResumeLayout(performLayout: false);
		j.PerformLayout();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)ae).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam order by id desc");
			ag.DataSource = dataSource;
			ag.DisplayMember = "Name";
			ag.ValueMember = "id";
			bool flag = ag.Items.Count <= 0;
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
					ag.SelectedIndex = 0;
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			ad.DataSource = dataSource;
			ad.DisplayMember = "Name";
			ad.ValueMember = "id";
			bool flag = ad.Items.Count <= 0;
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
					ad.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
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
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					num = ((ad.SelectedIndex < 0) ? 2 : 3);
					continue;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT DISTINCT tBook.id, tBook.Name,tBook.sort\r\n                                    FROM         tMark INNER JOIN\r\n                                                          tBook ON tMark.xbook = tBook.id\r\n                                    WHERE     tBook.xPaye =" + ad.SelectedValue.ToString() + " AND tMark.Xtest = " + ag.SelectedValue.ToString() + " ORDER BY tBook.sort");
					this.m_d.DataSource = dataSource;
					num = 1;
					continue;
				}
				case 1:
					return;
				case 7:
					return;
				case 2:
					num2 = 1;
					goto IL_0124;
				case 3:
					if (true)
					{
					}
					num = 6;
					continue;
				case 6:
					num2 = ((ag.SelectedIndex < 0) ? 1 : 0);
					goto IL_0124;
				case 4:
					{
						if (flag)
						{
							this.m_d.DataSource = null;
							num = 7;
						}
						else
						{
							num = 5;
						}
						continue;
					}
					IL_0124:
					flag = (byte)num2 != 0;
					num = 4;
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
			string text = "";
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (ad.SelectedIndex >= 0)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						num = 5;
					}
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					num2 = ((!(ad.SelectedValue.ToString() != "0")) ? 1 : 0);
					goto IL_00b4;
				case 1:
					text = " where xPaye=" + ad.SelectedValue.ToString();
					num = 6;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 6;
				case 5:
					num2 = 1;
					goto IL_00b4;
				case 6:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass" + text);
						ae.DataSource = dataSource;
						return;
					}
					IL_00b4:
					flag = (byte)num2 != 0;
					num = 4;
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

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DialogResult dialogResult = ah.ShowDialog();
			bool flag = dialogResult != DialogResult.OK;
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
					return;
				case 3:
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					v.Text = ah.SelectedPath;
					num = 3;
					continue;
				case 1:
					flag = !(ah.SelectedPath != "");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		string text3 = default;
		string text2 = default;
		DataTable dataTable = default;
		string a_5 = default;
		bool flag = default;
		string[] array = default;
		int num3 = default;
		while (true)
		{
			string text = "-1";
			int num = 55;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 55:
					num = ((!ab.Checked) ? 6 : 50);
					continue;
				case 40:
				{
					SqlParameter[] a_4 = new SqlParameter[11]
					{
						asdcb.a("@sendTo", SqlDbType.SmallInt, text),
						asdcb.a("@gBook", SqlDbType.SmallInt, g.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@mKolli", SqlDbType.SmallInt, this.m_f.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@gkolli", SqlDbType.SmallInt, i.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@NameStd", SqlDbType.SmallInt, k.Checked.ToString().Replace("True", "1").Replace("False", "0")),
						asdcb.a("@test", SqlDbType.Int, ag.SelectedValue.ToString()),
						asdcb.a("@xbook", SqlDbType.VarChar, 200, text3),
						asdcb.a("@xClass", SqlDbType.VarChar, 200, text2),
						asdcb.a("@heder1", SqlDbType.NVarChar, 200, h.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, 200, n.Text),
						asdcb.a("@foter", SqlDbType.NVarChar, 200, q.Text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_5, a_4);
					flag = dataTable.Rows.Count != 0;
					num = 51;
					continue;
				}
				case 51:
				{
					if (!flag)
					{
						num = 70;
						continue;
					}
					string a_ = asdab.c("VkFBd0FGSUFWZ0JsQUZFQVBRQTlBQT09");
					string a_2 = "tavakoli";
					string a_3 = "50004646138609";
					string text4 = asdz.a("09902922484", dataTable.Rows[0]["message"].ToString(), a_2, a_, a_3);
					array = text4.Split('-');
					flag = !(array[0] == "1");
					num = 31;
					continue;
				}
				case 59:
				{
					SqlParameter[] a_6 = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, ag.SelectedValue.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_6);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_6);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_6);
					num = 16;
					continue;
				}
				case 68:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(array[0] == "4");
					num = 62;
					continue;
				case 11:
					if (!flag)
					{
						num = 72;
						continue;
					}
					goto case 0;
				case 53:
					a_5 = "CreateMsg_tosifi";
					num = 40;
					continue;
				case 7:
					if (!flag)
					{
						num = 69;
						continue;
					}
					flag = !(array[0] == "2");
					num = 71;
					continue;
				case 16:
					flag = !(text3 == "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 35;
				case 37:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 21;
				case 62:
					if (flag)
					{
						flag = !(array[0] == "3");
						num = 7;
					}
					else
					{
						num = 8;
					}
					continue;
				case 13:
					num = 1;
					continue;
				case 1:
					return;
				case 64:
					if (!flag)
					{
						num = 45;
						continue;
					}
					goto case 52;
				case 50:
					num = 54;
					continue;
				case 54:
					num2 = ((!aa.Checked) ? 1 : 0);
					goto IL_09e4;
				case 46:
					MessageBox.Show("برای ارسال باید یکی از آیتمهای پدر یا مادر انتخاب شود");
					ab.Focus();
					num = 58;
					continue;
				case 58:
					return;
				case 72:
					text = "2";
					num = 0;
					continue;
				case 63:
					text2 += ",";
					num = 5;
					continue;
				case 8:
					num = 49;
					continue;
				case 49:
					return;
				case 19:
					MessageBox.Show("ارسال شد");
					num = 41;
					continue;
				case 41:
					return;
				case 42:
					MessageBox.Show(" هیچ صنفی انتخاب نشده است");
					ae.Focus();
					num = 3;
					continue;
				case 3:
					return;
				case 65:
					num = 4;
					continue;
				case 4:
					return;
				case 21:
					num3++;
					num = 66;
					continue;
				case 0:
				case 22:
				case 28:
					flag = !(text == "-1");
					num = 29;
					continue;
				case 29:
					if (flag)
					{
						text2 = "";
						num3 = 0;
						num = 30;
					}
					else
					{
						num = 46;
					}
					continue;
				case 24:
					MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است-در قسمت تنظیمات ارسال پیامک شماره تنظیم شود");
					num = 27;
					continue;
				case 27:
					return;
				case 30:
				case 66:
					flag = num3 < ae.RowCount;
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						flag = !(ae.GetRow(num3).Cells[0].Value.ToString() == "True");
						num = 37;
					}
					else
					{
						num = 44;
					}
					continue;
				case 5:
					text2 += ae.GetRow(num3).Cells["id"].Value.ToString();
					num = 21;
					continue;
				case 56:
					flag = !(text2 != "");
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 63;
						continue;
					}
					goto case 5;
				case 48:
				{
					string text5 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + ag.SelectedValue.ToString()).ToString();
					flag = !(text5 != "1");
					num = 14;
					continue;
				}
				case 14:
					if (!flag)
					{
						num = 59;
						continue;
					}
					goto case 16;
				case 6:
					num2 = 1;
					goto IL_09e4;
				case 10:
				case 36:
					flag = num3 < this.m_d.RowCount;
					num = 38;
					continue;
				case 38:
					if (flag)
					{
						flag = !(this.m_d.GetRow(num3).Cells[0].Value.ToString() == "True");
						num = 64;
					}
					else
					{
						num = 48;
					}
					continue;
				case 45:
					if (true)
					{
					}
					flag = !(text3 != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 23;
				case 34:
					if (flag)
					{
						flag = !(array[0] == "5");
						num = 68;
					}
					else
					{
						num = 24;
					}
					continue;
				case 39:
					text3 += ",";
					num = 23;
					continue;
				case 69:
					num = 43;
					continue;
				case 43:
					return;
				case 26:
					if (flag)
					{
						flag = !aa.Checked;
						num = 11;
					}
					else
					{
						num = 57;
					}
					continue;
				case 60:
					if (flag)
					{
						flag = !ab.Checked;
						num = 26;
					}
					else
					{
						num = 25;
					}
					continue;
				case 71:
					num = (flag ? 18 : 13);
					continue;
				case 44:
					flag = !(text2 == "");
					num = 47;
					continue;
				case 47:
					if (flag)
					{
						text3 = "";
						num3 = 0;
						num = 10;
					}
					else
					{
						num = 42;
					}
					continue;
				case 57:
					text = "1";
					num = 22;
					continue;
				case 31:
					if (flag)
					{
						flag = !(array[0] == "0");
						num = 34;
					}
					else
					{
						num = 19;
					}
					continue;
				case 25:
					text = "0";
					num = 28;
					continue;
				case 52:
					num3++;
					num = 36;
					continue;
				case 70:
					MessageBox.Show("موردی برای ارسال وجود ندارد");
					num = 67;
					continue;
				case 67:
					return;
				case 20:
				{
					DialogResult dialogResult = MessageBox.Show(" هیچ درسی انتخاب نشده است آیا میخواهید ادامه دهید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
					flag = dialogResult == DialogResult.Yes;
					num = 9;
					continue;
				}
				case 9:
					num = (flag ? 35 : 65);
					continue;
				case 18:
					return;
				case 35:
					a_5 = "CreateMsg";
					flag = !(asdab.m == "2");
					num = 61;
					continue;
				case 61:
					if (!flag)
					{
						num = 53;
						continue;
					}
					goto case 40;
				case 12:
					num = 32;
					continue;
				case 32:
					return;
				case 23:
					{
						text3 += this.m_d.GetRow(num3).Cells["id"].Value.ToString();
						num = 52;
						continue;
					}
					IL_09e4:
					flag = (byte)num2 != 0;
					num = 60;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		a();
		b();
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = !(asdab.m == "2");
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
					g.Visible = false;
					i.Visible = false;
					this.m_f.Visible = false;
					num = 0;
					continue;
				case 0:
					d();
					c();
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
	}
}
