using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using FreeSms.Reporting;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using school_Af.Properties;
using school_Af.Rpt.afPayment;

public class asdbo : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private Label m_f;

	private Label m_g;

	private UIComboBox h;

	private MaskedEditBox i;

	private TextBox j;

	private TextBox k;

	private Label l;

	private TextBox m;

	private TextBox n;

	private TextBox o;

	private TextBox p;

	private UIButton q;

	private Label r;

	private Label s;

	private UIComboBox t;

	private GridEX u;

	private Label v;

	private Label w;

	private Label x;

	private TextBox y;

	private Label z;

	private UIButton aa;

	private UIComboBox ab;

	private UIButton ac;

	private SqlConnection ad = new SqlConnection(asdab.e());
protected override void Dispose(bool A_0)
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 5;
					}
					else
					{
						num = 2;
					}
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 0:
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
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbo));
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem10 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem11 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem12 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem13 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem14 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem15 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem16 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem17 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem18 = new UIComboBoxItem();
		StringFormat stringFormat3 = new StringFormat();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		ac = new UIButton();
		ab = new UIComboBox();
		aa = new UIButton();
		y = new TextBox();
		z = new Label();
		x = new Label();
		v = new Label();
		w = new Label();
		r = new Label();
		s = new Label();
		t = new UIComboBox();
		u = new GridEX();
		q = new UIButton();
		p = new TextBox();
		o = new TextBox();
		n = new TextBox();
		m = new TextBox();
		l = new Label();
		k = new TextBox();
		j = new TextBox();
		i = new MaskedEditBox();
		this.m_f = new Label();
		this.m_g = new Label();
		h = new UIComboBox();
		this.m_e = new UIButton();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		((ISupportInitialize)u).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(650, 600);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(648, 598);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(ac);
		this.m_d.Controls.Add(ab);
		this.m_d.Controls.Add(aa);
		this.m_d.Controls.Add(y);
		this.m_d.Controls.Add(z);
		this.m_d.Controls.Add(x);
		this.m_d.Controls.Add(v);
		this.m_d.Controls.Add(w);
		this.m_d.Controls.Add(r);
		this.m_d.Controls.Add(s);
		this.m_d.Controls.Add(t);
		this.m_d.Controls.Add(u);
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(642, 592);
		this.m_d.TabIndex = 0;
		ac.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ac.Image = Resources.error;
		ac.ImageSize = new Size(33, 33);
		ac.Location = new Point(466, 482);
		ac.Name = "btnNotShowBalance";
		ac.Size = new Size(165, 50);
		ac.TabIndex = 149;
		ac.Text = "تنظیم عدم نمایش شاگرد در دعوت نامه";
		ac.Click += a;
		ab.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ab.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "1403";
		uIComboBoxItem.Value = "1403";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "1402";
		uIComboBoxItem2.Value = "1402";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "1401";
		uIComboBoxItem3.Value = "1401";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "1400";
		uIComboBoxItem4.Value = "1400";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1399";
		uIComboBoxItem5.Value = "1399";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1398";
		uIComboBoxItem6.Value = "1398";
		ab.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		ab.Location = new Point(355, 65);
		ab.Name = "dropYear";
		ab.Size = new Size(97, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		ab.StringFormat = stringFormat;
		ab.TabIndex = 148;
		ab.SelectedIndexChanged += c;
		aa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		aa.Image = Resources._0188;
		aa.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		aa.ImageSize = new Size(40, 40);
		aa.Location = new Point(184, 540);
		aa.Name = "uiButton1";
		aa.Size = new Size(259, 46);
		aa.TabIndex = 147;
		aa.Text = "نمایش لیست دانش آموزان بدهکار";
		aa.Click += d;
		y.Location = new Point(317, 253);
		y.Name = "txtDate";
		y.Size = new Size(229, 23);
		y.TabIndex = 146;
		y.Text = "تا تاریخ پنج شنبه دهم ثور";
		z.AutoSize = true;
		z.Location = new Point(554, 256);
		z.Name = "label7";
		z.Size = new Size(34, 16);
		z.TabIndex = 145;
		z.Text = "تاریخ";
		x.AutoSize = true;
		x.Font = new Font("Tahoma", 14f, FontStyle.Regular, GraphicsUnit.Point, 178);
		x.Location = new Point(284, 12);
		x.Name = "label6";
		x.Size = new Size(190, 23);
		x.TabIndex = 144;
		x.Text = "گزارش بدهی شاگردان";
		v.AutoSize = true;
		v.Location = new Point(549, 378);
		v.Name = "label5";
		v.Size = new Size(74, 16);
		v.TabIndex = 143;
		v.Text = "جمله پایانی";
		w.AutoSize = true;
		w.Location = new Point(554, 288);
		w.Name = "label3";
		w.Size = new Size(69, 16);
		w.TabIndex = 142;
		w.Text = "جمله بعدی";
		r.AutoSize = true;
		r.Location = new Point(458, 67);
		r.Name = "label8";
		r.Size = new Size(87, 16);
		r.TabIndex = 141;
		r.Text = "سال تعلیمی :";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.AutoSize = true;
		s.Location = new Point(208, 8);
		s.Name = "label20";
		s.Size = new Size(27, 16);
		s.TabIndex = 139;
		s.Text = "پایه";
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		t.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		t.Location = new Point(8, 8);
		t.Name = "dropPaye";
		t.Size = new Size(193, 20);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		t.StringFormat = stringFormat2;
		t.TabIndex = 138;
		t.SelectedIndexChanged += b;
		u.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		u.DesignTimeLayout = gridEXLayout;
		u.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		u.GroupByBoxVisible = false;
		u.Location = new Point(8, 31);
		u.Name = "gClass";
		u.RowHeaders = InheritableBoolean.True;
		u.Size = new Size(193, 181);
		u.TabIndex = 137;
		u.VisualStyle = VisualStyle.Office2003;
		q.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		q.Image = Resources._0188;
		q.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		q.ImageSize = new Size(40, 40);
		q.Location = new Point(184, 482);
		q.Name = "btnview";
		q.Size = new Size(259, 50);
		q.TabIndex = 130;
		q.Text = "نمایش دعوت نامه";
		q.Click += e;
		p.Location = new Point(27, 429);
		p.Multiline = true;
		p.Name = "txtfoter2";
		p.Size = new Size(196, 43);
		p.TabIndex = 129;
		p.Text = "با تشکر\r\nاداره لیسه عالی دین و دانش";
		p.TextAlign = HorizontalAlignment.Center;
		o.Location = new Point(27, 375);
		o.Multiline = true;
		o.Name = "txtfoter1";
		o.Size = new Size(521, 49);
		o.TabIndex = 128;
		o.Text = "تذکر : در صورت تأخیر در پرداخت مبلغ متذکره طبق صلاحدید مکتب عمل خواهد شد.";
		n.Enabled = false;
		n.Location = new Point(255, 340);
		n.Name = "textBox3";
		n.Size = new Size(293, 23);
		n.TabIndex = 127;
		n.Text = "مجموع فیس پرداخت شده تا این تاریخ .... افغانی";
		m.Enabled = false;
		m.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Location = new Point(8, 218);
		m.Name = "textBox2";
		m.Size = new Size(303, 22);
		m.TabIndex = 126;
		m.Text = "سه ماهه بهار مبلغ ...  افغانی افغانی می گردد را حداکثر";
		l.AutoSize = true;
		l.Location = new Point(554, 221);
		l.Name = "label4";
		l.Size = new Size(80, 16);
		l.TabIndex = 125;
		l.Text = "جمله ابتدایی";
		k.Location = new Point(317, 218);
		k.Name = "txtheder1";
		k.Size = new Size(230, 23);
		k.TabIndex = 124;
		k.Text = "خواهشمند است بقایای فیس";
		j.Location = new Point(8, 285);
		j.Multiline = true;
		j.Name = "txtheder2";
		j.Size = new Size(540, 49);
		j.TabIndex = 123;
		j.Text = "تحویل نموده و ما را در برنامه ریزی بهتر برای آینده فرزندتان یازی نمایید.";
		i.AutoScroll = false;
		i.AutoScrollMargin = new Size(0, 0);
		i.AutoScrollMinSize = new Size(0, 0);
		i.AutoScrollPosition = new Point(0, 0);
		i.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(355, 162);
		i.MaxLength = 9;
		i.Name = "txtBalance";
		i.Numeric = true;
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(97, 23);
		i.TabIndex = 122;
		i.Tag = "";
		i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_f.AutoSize = true;
		this.m_f.Location = new Point(458, 166);
		this.m_f.Name = "label2";
		this.m_f.Size = new Size(101, 16);
		this.m_f.TabIndex = 121;
		this.m_f.Text = "حداقل بدهکاری :";
		this.m_g.AutoSize = true;
		this.m_g.Location = new Point(458, 118);
		this.m_g.Name = "label1";
		this.m_g.Size = new Size(63, 16);
		this.m_g.TabIndex = 120;
		this.m_g.Text = "فصل/ماه :";
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		h.DropListFont = new Font("B Nazanin", 12f);
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "بهار";
		uIComboBoxItem7.Value = "1";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "تابستان";
		uIComboBoxItem8.Value = "2";
		uIComboBoxItem9.FormatStyle.Alpha = 0;
		uIComboBoxItem9.Text = "خزان";
		uIComboBoxItem9.Value = "3";
		uIComboBoxItem10.FormatStyle.Alpha = 0;
		uIComboBoxItem10.Text = "حمل";
		uIComboBoxItem10.Value = "1";
		uIComboBoxItem11.FormatStyle.Alpha = 0;
		uIComboBoxItem11.Text = "ثور";
		uIComboBoxItem11.Value = "2";
		uIComboBoxItem12.FormatStyle.Alpha = 0;
		uIComboBoxItem12.Text = "جوزا";
		uIComboBoxItem12.Value = "3";
		uIComboBoxItem13.FormatStyle.Alpha = 0;
		uIComboBoxItem13.Text = "سرطان";
		uIComboBoxItem13.Value = "4";
		uIComboBoxItem14.FormatStyle.Alpha = 0;
		uIComboBoxItem14.Text = "اسد";
		uIComboBoxItem14.Value = "5";
		uIComboBoxItem15.FormatStyle.Alpha = 0;
		uIComboBoxItem15.Text = "سنبله";
		uIComboBoxItem15.Value = "6";
		uIComboBoxItem16.FormatStyle.Alpha = 0;
		uIComboBoxItem16.Text = "میزان";
		uIComboBoxItem16.Value = "7";
		uIComboBoxItem17.FormatStyle.Alpha = 0;
		uIComboBoxItem17.Text = "عقرب";
		uIComboBoxItem17.Value = "8";
		uIComboBoxItem18.FormatStyle.Alpha = 0;
		uIComboBoxItem18.Text = "قوس";
		uIComboBoxItem18.Value = "9";
		h.Items.AddRange(new UIComboBoxItem[12]
		{
			uIComboBoxItem7, uIComboBoxItem8, uIComboBoxItem9, uIComboBoxItem10, uIComboBoxItem11, uIComboBoxItem12, uIComboBoxItem13, uIComboBoxItem14, uIComboBoxItem15, uIComboBoxItem16,
			uIComboBoxItem17, uIComboBoxItem18
		});
		h.Location = new Point(355, 114);
		h.Name = "dropFasl";
		h.Size = new Size(97, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat3;
		h.TabIndex = 119;
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_e.DialogResult = DialogResult.Cancel;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(40, 40);
		this.m_e.Location = new Point(8, 539);
		this.m_e.Name = "btnClose";
		this.m_e.Size = new Size(102, 50);
		this.m_e.TabIndex = 44;
		this.m_e.Text = "بستن";
		this.m_e.Click += f;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(650, 600);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmRptBalance";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += g;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)u).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdbo()
	{
		c();
	}

	private void g(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		DataTable dataTable2 = default;
		while (true)
		{
			bool flag = asdaj.a("10");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 0:
					o.Text = dataTable2.Rows[0]["Foter1"].ToString();
					p.Text = dataTable2.Rows[0]["Foter2"].ToString();
					k.Text = dataTable2.Rows[0]["heder1"].ToString();
					j.Text = dataTable2.Rows[0]["heder2"].ToString();
					i.Text = dataTable2.Rows[0]["balance"].ToString();
					y.Text = dataTable2.Rows[0]["fDate"].ToString();
					o.Tag = dataTable2.Rows[0]["Foter1"].ToString();
					p.Tag = dataTable2.Rows[0]["Foter2"].ToString();
					k.Tag = dataTable2.Rows[0]["heder1"].ToString();
					j.Tag = dataTable2.Rows[0]["heder2"].ToString();
					i.Tag = dataTable2.Rows[0]["balance"].ToString();
					y.Tag = dataTable2.Rows[0]["fDate"].ToString();
					num = 7;
					continue;
				case 7:
					return;
				case 8:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					OriginalSchoolYears.Select(ab, asdaj.__field_a);
					b();
					a();
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM tParmetrBalance");
					flag = dataTable2.Rows.Count <= 0;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 2:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 3:
					num = 2;
					continue;
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
			t.Items.Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where  id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ab.SelectedValue.ToString() + ") order by id");
			t.Items.Add("کل", "0");
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 3;
						continue;
					}
					t.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 0;
					continue;
				case 3:
					if (true)
					{
					}
					t.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			if (true)
			{
			}
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = t.SelectedIndex <= 0;
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
					text = text + " and xPaye=" + t.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + ab.SelectedValue.ToString() + text);
					u.DataSource = dataSource;
					return;
				}
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
		int num2 = default;
		SqlParameter[] a_3 = default;
		string text = default;
		string a_ = default;
		int num4 = default;
		while (true)
		{
			bool flag = asdab.p >= int.Parse(ab.SelectedValue.ToString());
			int num = 8;
			while (true)
			{
				int num6;
				int num3;
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 31;
						continue;
					}
					flag = asdab.p != int.Parse(ab.SelectedValue.ToString());
					num = 2;
					continue;
				case 18:
					num = 40;
					continue;
				case 40:
					if (!(p.Text != p.Tag.ToString()))
					{
						num = 47;
						continue;
					}
					goto IL_0587;
				case 7:
					num2++;
					num = 39;
					continue;
				case 9:
					num = ((i.Text == "") ? 13 : 37);
					continue;
				case 45:
					num = 51;
					continue;
				case 51:
					num6 = ((!(y.Text != y.Tag.ToString())) ? 1 : 0);
					goto IL_0373;
				case 3:
					if (!(o.Text != o.Tag.ToString()))
					{
						num = 18;
						continue;
					}
					goto IL_0587;
				case 38:
					a_3 = new SqlParameter[4]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text),
						asdcb.a("@xYear", SqlDbType.Int, ab.SelectedValue.ToString()),
						asdcb.a("@Fasl", SqlDbType.Int, h.SelectedValue.ToString()),
						asdcb.a("@Balance", SqlDbType.Int, i.Text)
					};
					a_ = "sp_RptPaymentBalance1";
					num4 = 1;
					flag = h.SelectedIndex < 3;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 28;
				case 17:
					text += u.GetRow(num2).Cells["id"].Value.ToString();
					num = 7;
					continue;
				case 37:
					num = 21;
					continue;
				case 21:
					num3 = ((!(i.Text == "0")) ? 1 : 0);
					goto IL_055d;
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 38;
				case 28:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_, a_3);
					ReportClass reportClass = null;
					reportClass = new CrRptStdBalance();
					reportClass.SetDataSource(dataSource);
					reportClass.ParameterFields["heder1"].CurrentValues.AddValue(k.Text);
					reportClass.ParameterFields["heder2"].CurrentValues.AddValue(j.Text);
					reportClass.ParameterFields["foter1"].CurrentValues.AddValue(o.Text);
					reportClass.ParameterFields["foter2"].CurrentValues.AddValue(p.Text);
					reportClass.ParameterFields["fdate"].CurrentValues.AddValue(y.Text);
					reportClass.ParameterFields["type"].CurrentValues.AddValue(num4);
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					num = 30;
					continue;
				}
				case 30:
					return;
				case 31:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 25;
					continue;
				case 25:
					return;
				case 49:
					MessageBox.Show("فصل یا ماه مورد نظر را انتخاب کنید");
					h.Focus();
					num = 36;
					continue;
				case 36:
					return;
				case 35:
					flag = h.SelectedIndex >= 0;
					num = 16;
					continue;
				case 16:
					num = ((!flag) ? 49 : 9);
					continue;
				case 32:
					num = (flag ? 22 : 20);
					continue;
				case 42:
					num6 = 0;
					goto IL_0373;
				case 29:
					num = 6;
					continue;
				case 6:
					if (!(j.Text != j.Tag.ToString()))
					{
						num = 26;
						continue;
					}
					goto IL_0587;
				case 22:
					try
					{
						int num5 = int.Parse(i.Text);
					}
					catch
					{
						MessageBox.Show("برای حداقل بدهی فقط عدد وارد کنید");
						i.Focus();
						return;
					}
					text = "";
					num2 = 0;
					num = 50;
					continue;
				case 15:
					flag = !(text == "");
					num = 10;
					continue;
				case 10:
					num = ((!flag) ? 4 : 3);
					continue;
				case 20:
					MessageBox.Show("حداقل بدهی را وارد کنید");
					i.Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 13:
					num3 = 0;
					goto IL_055d;
				case 26:
					num = 23;
					continue;
				case 23:
					if (!(i.Text != i.Tag.ToString()))
					{
						num = 45;
						continue;
					}
					goto IL_0587;
				case 27:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 33;
					continue;
				case 33:
					return;
				case 34:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 7;
				case 39:
				case 50:
					flag = num2 < u.RowCount;
					num = 46;
					continue;
				case 46:
					if (flag)
					{
						flag = !(u.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 34;
					}
					else
					{
						num = 15;
					}
					continue;
				case 2:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 35;
				case 4:
					MessageBox.Show("صنفی انتخاب نشده است");
					num = 41;
					continue;
				case 41:
					return;
				case 43:
					flag = !(text != "");
					num = 48;
					continue;
				case 48:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 17;
				case 14:
				{
					SqlParameter[] a_2 = new SqlParameter[6]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, k.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, j.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, o.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, p.Text),
						asdcb.a("@balance", SqlDbType.NVarChar, i.Text),
						asdcb.a("@fDate", SqlDbType.NVarChar, y.Text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "if not exists(select balance from tParmetrBalance)\r\n                    INSERT INTO tParmetrBalance\r\n                      (heder1, heder2, Foter1, Foter2, balance,fDate)\r\n                 VALUES (@heder1, @heder2, @Foter1, @Foter2, @balance,@fDate)\r\n                     else UPDATE    tParmetrBalance\r\n                          SET              heder1 =@heder1, heder2 =@heder2, Foter1 =@Foter1, Foter2 =@Foter2, balance =@balance,fDate=@fDate", a_2);
					num = 38;
					continue;
				}
				case 24:
					text += ",";
					num = 17;
					continue;
				case 11:
					a_ = "sp_RptPaymentBalance2";
					num4 = 2;
					num = 28;
					continue;
				case 44:
					flag = !(asdab.q != asdab.n);
					num = 12;
					continue;
				case 12:
					num = ((!flag) ? 27 : 35);
					continue;
				case 47:
					num = 19;
					continue;
				case 19:
					{
						if (!(k.Text != k.Tag.ToString()))
						{
							num = 29;
							continue;
						}
						goto IL_0587;
					}
					IL_055d:
					flag = (byte)num3 != 0;
					num = 32;
					continue;
					IL_0373:
					flag = (byte)num6 != 0;
					num = 5;
					continue;
					IL_0587:
					num = 42;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		int num2 = default;
		string a_ = default;
		int num4 = default;
		string text = default;
		while (true)
		{
			bool flag = asdab.p >= int.Parse(ab.SelectedValue.ToString());
			int num = 9;
			while (true)
			{
				int num6;
				int num3;
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 29;
						continue;
					}
					flag = asdab.p != int.Parse(ab.SelectedValue.ToString());
					num = 40;
					continue;
				case 45:
					num = 28;
					continue;
				case 28:
					if (!(p.Text != p.Tag.ToString()))
					{
						num = 41;
						continue;
					}
					goto IL_057f;
				case 19:
					num2++;
					num = 1;
					continue;
				case 4:
					num = ((i.Text == "") ? 47 : 12);
					continue;
				case 8:
					num = 44;
					continue;
				case 44:
					num6 = ((!(y.Text != y.Tag.ToString())) ? 1 : 0);
					goto IL_02fe;
				case 21:
					if (!(o.Text != o.Tag.ToString()))
					{
						num = 45;
						continue;
					}
					goto IL_057f;
				case 2:
					a_ = "sp_RptPaymentBalance1";
					num4 = 1;
					flag = h.SelectedIndex < 3;
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 50;
						continue;
					}
					goto case 17;
				case 20:
					text += u.GetRow(num2).Cells["id"].Value.ToString();
					num = 19;
					continue;
				case 12:
					num = 24;
					continue;
				case 24:
					num3 = ((!(i.Text == "0")) ? 1 : 0);
					goto IL_0555;
				case 37:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 2;
				case 17:
				{
					SqlParameter[] a_3 = new SqlParameter[4]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text),
						asdcb.a("@xYear", SqlDbType.Int, ab.SelectedValue.ToString()),
						asdcb.a("@Fasl", SqlDbType.Int, h.SelectedValue.ToString()),
						asdcb.a("@Balance", SqlDbType.Int, i.Text)
					};
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, a_, a_3);
					ReportClass reportClass = null;
					reportClass = new CrRptStdBalanceListe();
					reportClass.SetDataSource(dataSource);
					reportClass.ParameterFields["heder1"].CurrentValues.AddValue(k.Text);
					reportClass.ParameterFields["heder2"].CurrentValues.AddValue(j.Text);
					reportClass.ParameterFields["foter1"].CurrentValues.AddValue(o.Text);
					reportClass.ParameterFields["foter2"].CurrentValues.AddValue(p.Text);
					reportClass.ParameterFields["fdate"].CurrentValues.AddValue(y.Text);
					reportClass.ParameterFields["type"].CurrentValues.AddValue(num4);
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					num = 51;
					continue;
				}
				case 51:
					return;
				case 29:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 14;
					continue;
				case 14:
					return;
				case 46:
					MessageBox.Show("فصل را انتخاب کنید");
					h.Focus();
					num = 36;
					continue;
				case 36:
					return;
				case 39:
					flag = h.SelectedIndex >= 0;
					num = 48;
					continue;
				case 48:
					num = ((!flag) ? 46 : 4);
					continue;
				case 16:
					num = (flag ? 7 : 35);
					continue;
				case 6:
					num6 = 0;
					goto IL_02fe;
				case 11:
					num = 34;
					continue;
				case 34:
					if (!(j.Text != j.Tag.ToString()))
					{
						num = 33;
						continue;
					}
					goto IL_057f;
				case 7:
					try
					{
						int num5 = int.Parse(i.Text);
					}
					catch
					{
						MessageBox.Show("برای حداقل بدهی فقط عدد وارد کنید");
						i.Focus();
						return;
					}
					text = "";
					num2 = 0;
					num = 25;
					continue;
				case 5:
					flag = !(text == "");
					num = 31;
					continue;
				case 31:
					num = ((!flag) ? 15 : 21);
					continue;
				case 35:
					MessageBox.Show("حداقل بدهی را وارد کنید");
					i.Focus();
					num = 26;
					continue;
				case 26:
					return;
				case 47:
					num3 = 0;
					goto IL_0555;
				case 33:
					if (true)
					{
					}
					num = 13;
					continue;
				case 13:
					if (!(i.Text != i.Tag.ToString()))
					{
						num = 8;
						continue;
					}
					goto IL_057f;
				case 43:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 18;
					continue;
				case 18:
					return;
				case 23:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 19;
				case 1:
				case 25:
					flag = num2 < u.RowCount;
					num = 27;
					continue;
				case 27:
					if (flag)
					{
						flag = !(u.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 23;
					}
					else
					{
						num = 5;
					}
					continue;
				case 40:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 39;
				case 15:
					MessageBox.Show("صنفی انتخاب نشده است");
					num = 38;
					continue;
				case 38:
					return;
				case 0:
					flag = !(text != "");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 20;
				case 32:
				{
					SqlParameter[] a_2 = new SqlParameter[6]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, k.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, j.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, o.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, p.Text),
						asdcb.a("@balance", SqlDbType.NVarChar, i.Text),
						asdcb.a("@fDate", SqlDbType.NVarChar, y.Text)
					};
					asdcb.d(asdab.e(), CommandType.Text, "if not exists(select balance from tParmetrBalance)\r\n                    INSERT INTO tParmetrBalance\r\n                      (heder1, heder2, Foter1, Foter2, balance,fDate)\r\n                 VALUES (@heder1, @heder2, @Foter1, @Foter2, @balance,@fDate)\r\n                     else UPDATE    tParmetrBalance\r\n                          SET              heder1 =@heder1, heder2 =@heder2, Foter1 =@Foter1, Foter2 =@Foter2, balance =@balance,fDate=@fDate", a_2);
					num = 2;
					continue;
				}
				case 3:
					text += ",";
					num = 20;
					continue;
				case 50:
					a_ = "sp_RptPaymentBalance2";
					num4 = 2;
					num = 17;
					continue;
				case 49:
					flag = !(asdab.q != asdab.n);
					num = 30;
					continue;
				case 30:
					num = ((!flag) ? 43 : 39);
					continue;
				case 41:
					num = 42;
					continue;
				case 42:
					{
						if (!(k.Text != k.Tag.ToString()))
						{
							num = 11;
							continue;
						}
						goto IL_057f;
					}
					IL_0555:
					flag = (byte)num3 != 0;
					num = 16;
					continue;
					IL_02fe:
					flag = (byte)num6 != 0;
					num = 37;
					continue;
					IL_057f:
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		b();
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		asdbr asdbr2 = new asdbr();
		asdbr2.ShowDialog();
	}
}
