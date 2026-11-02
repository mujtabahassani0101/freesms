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

public class asdcc : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private Panel m_f;

	private UIButton m_g;

	private UIButton m_h;

	private Panel i;

	private UIButton j;

	private UIButton k;

	private GridEX l;

	private Label m;

	private UIComboBox n;

	private BackgroundWorker o;

	private ProgressBar p;

	private Label q;

	private Label r;

	private GridEX s;

	private UIButton t;

	private EditBox u;

	private Label v;

	private EditBox w;

	private Label x;

	private CheckBox y;

	private GridEX z;

	private Label aa;

	private UIComboBox ab;

	private SqlConnection ac = new SqlConnection(asdab.e());

	private SqlConnection ad = new SqlConnection();

	private string ae = "";

	private string af = "0";

	private string ag = " and xExportRpt is null";

	private string ah = "";
protected override void Dispose(bool A_0)
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
						num = 0;
					}
					else
					{
						num = 3;
					}
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void f()
	{
		if (true)
		{
		}
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdcc));
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		GridEXLayout gridEXLayout3 = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		r = new Label();
		this.m_f = new Panel();
		ab = new UIComboBox();
		aa = new Label();
		z = new GridEX();
		y = new CheckBox();
		u = new EditBox();
		v = new Label();
		w = new EditBox();
		x = new Label();
		m = new Label();
		n = new UIComboBox();
		this.m_g = new UIButton();
		this.m_h = new UIButton();
		p = new ProgressBar();
		this.m_d = new UIGroupBox();
		t = new UIButton();
		q = new Label();
		s = new GridEX();
		this.m_e = new Label();
		i = new Panel();
		j = new UIButton();
		k = new UIButton();
		l = new GridEX();
		o = new BackgroundWorker();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_f.SuspendLayout();
		((ISupportInitialize)z).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_d.SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		i.SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.ControlText;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(800, 600);
		this.m_b.TabIndex = 1;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(r);
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Controls.Add(p);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(l);
		this.m_c.Font = new Font("Tahoma", 8.25f);
		this.m_c.Location = new Point(4, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(790, 588);
		this.m_c.TabIndex = 0;
		r.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r.Location = new Point(528, 475);
		r.Name = "lTable";
		r.Size = new Size(241, 22);
		r.TabIndex = 8;
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(ab);
		this.m_f.Controls.Add(aa);
		this.m_f.Controls.Add(z);
		this.m_f.Controls.Add(y);
		this.m_f.Controls.Add(u);
		this.m_f.Controls.Add(v);
		this.m_f.Controls.Add(w);
		this.m_f.Controls.Add(x);
		this.m_f.Controls.Add(m);
		this.m_f.Controls.Add(n);
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Controls.Add(this.m_h);
		this.m_f.Location = new Point(241, 105);
		this.m_f.Name = "pcls";
		this.m_f.Size = new Size(257, 174);
		this.m_f.TabIndex = 10;
		this.m_f.Visible = false;
		ab.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ab.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "همه صنف ها";
		uIComboBoxItem.Value = "0";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "انتخاب صنف";
		uIComboBoxItem2.Value = "1";
		ab.Items.AddRange(new UIComboBoxItem[2] { uIComboBoxItem, uIComboBoxItem2 });
		ab.Location = new Point(21, 59);
		ab.Name = "comboTypeSendClass";
		ab.Size = new Size(154, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		ab.StringFormat = stringFormat;
		ab.TabIndex = 110;
		ab.SelectedIndexChanged += a;
		aa.AutoSize = true;
		aa.Location = new Point(179, 59);
		aa.Name = "label4";
		aa.Size = new Size(65, 13);
		aa.TabIndex = 109;
		aa.Text = "ارسال نمرات";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		z.DesignTimeLayout = gridEXLayout;
		z.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		z.Font = new Font("Tahoma", 8.25f);
		z.GroupByBoxVisible = false;
		z.Location = new Point(19, 175);
		z.Name = "gClass";
		z.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		z.Size = new Size(183, 280);
		z.TabIndex = 108;
		z.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		y.AutoSize = true;
		y.Location = new Point(45, 3);
		y.Name = "checkAgain";
		y.Size = new Size(145, 17);
		y.TabIndex = 83;
		y.Text = "ارسال مجدد همه اطلاعات";
		y.UseVisualStyleBackColor = true;
		y.CheckedChanged += b;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		u.Location = new Point(20, 88);
		u.Name = "txtUser";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(156, 21);
		u.TabIndex = 2;
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		v.Location = new Point(179, 88);
		v.Name = "label3";
		v.RightToLeft = RightToLeft.Yes;
		v.Size = new Size(61, 21);
		v.TabIndex = 82;
		v.Text = "نام کاربری :";
		v.TextAlign = ContentAlignment.MiddleRight;
		w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.Location = new Point(20, 115);
		w.Name = "txtPass";
		w.PasswordChar = '*';
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(156, 21);
		w.TabIndex = 3;
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		w.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		x.Location = new Point(179, 115);
		x.Name = "label6";
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(61, 21);
		x.TabIndex = 80;
		x.Text = "کلمه عبور :";
		x.TextAlign = ContentAlignment.MiddleRight;
		m.AutoSize = true;
		m.Location = new Point(183, 26);
		m.Name = "label2";
		m.Size = new Size(26, 13);
		m.TabIndex = 39;
		m.Text = "دوره";
		n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		n.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		n.Location = new Point(20, 26);
		n.Name = "dropExam";
		n.Size = new Size(154, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		n.StringFormat = stringFormat2;
		n.TabIndex = 1;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		this.m_g.Location = new Point(19, 146);
		this.m_g.Name = "btnCancel";
		this.m_g.Size = new Size(75, 23);
		this.m_g.TabIndex = 5;
		this.m_g.Text = "انصراف";
		this.m_g.Click += d;
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		this.m_h.Location = new Point(100, 146);
		this.m_h.Name = "btnAcp";
		this.m_h.Size = new Size(75, 23);
		this.m_h.TabIndex = 4;
		this.m_h.Text = "تایید";
		this.m_h.Click += f;
		p.Location = new Point(13, 505);
		p.Name = "progressBar1";
		p.Size = new Size(763, 23);
		p.TabIndex = 13;
		this.m_d.Controls.Add(t);
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(s);
		this.m_d.Location = new Point(10, 356);
		this.m_d.Name = "uiGroupBox1";
		this.m_d.Size = new Size(773, 116);
		this.m_d.TabIndex = 12;
		this.m_d.Text = "جزئیات آخرین ارسال";
		t.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		t.Location = new Point(638, 75);
		t.Name = "btnContinue";
		t.Size = new Size(128, 32);
		t.TabIndex = 9;
		t.Text = "ادامه ارسال";
		t.Visible = false;
		t.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
		t.Click += c;
		q.Location = new Point(3, 78);
		q.Name = "tbProgress";
		q.Size = new Size(629, 29);
		q.TabIndex = 7;
		q.TextAlign = ContentAlignment.MiddleCenter;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		s.DesignTimeLayout = gridEXLayout2;
		s.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		s.Font = new Font("Tahoma", 8.25f);
		s.GroupByBoxVisible = false;
		s.Location = new Point(-10, 19);
		s.Name = "gridEX2";
		s.Size = new Size(782, 44);
		s.TabIndex = 8;
		s.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(636, 8);
		this.m_e.Name = "label1";
		this.m_e.Size = new Size(143, 13);
		this.m_e.TabIndex = 11;
		this.m_e.Text = "تاریخچه ارسال نمرات به سایت";
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.Controls.Add(j);
		i.Controls.Add(k);
		i.Location = new Point(3, 543);
		i.Name = "p_new";
		i.Size = new Size(784, 41);
		i.TabIndex = 9;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(30, 30);
		j.Location = new Point(7, 3);
		j.Name = "btnClose";
		j.Size = new Size(75, 32);
		j.TabIndex = 15;
		j.Text = "خروج";
		j.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
		j.Click += e;
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		k.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		k.Location = new Point(648, 3);
		k.Name = "btnNew";
		k.Size = new Size(128, 32);
		k.TabIndex = 0;
		k.Text = "ارسال جدید";
		k.Click += g;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		l.DesignTimeLayout = gridEXLayout3;
		l.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		l.Font = new Font("Tahoma", 8.25f);
		l.GroupByBoxVisible = false;
		l.Location = new Point(3, 28);
		l.Name = "gridEX1";
		l.RecordNavigator = true;
		l.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		l.Size = new Size(782, 312);
		l.TabIndex = 5;
		l.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		o.DoWork += a;
		o.RunWorkerCompleted += a;
		o.ProgressChanged += a;
		AcceptButton = this.m_h;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmExportMarkToSite";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "ارسال نمرات به سایت";
		Load += h;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		((ISupportInitialize)z).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		((ISupportInitialize)s).EndInit();
		i.ResumeLayout(performLayout: false);
		((ISupportInitialize)l).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdcc()
	{
		f();
	}

	private void h(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			ae = asdcb.a(asdab.e(), CommandType.Text, "SELECT con FROM  tCon").ToString();
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num2 = 1;
					goto IL_011b;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((!(s.GetRow(0).Cells["TimeFinish"].Value.ToString() == "")) ? 1 : 0);
					goto IL_011b;
				case 2:
				{
					t.Visible = true;
					string text = "آخرین ارسال شما به طور کامل انجام نشده است";
					text += "\n";
					text += "شما میتوانید از دکمه *ادامه ارسال* برای کامل شدن مراحل ارسال استفاده نمایید";
					MessageBox.Show(text);
					num = 1;
					continue;
				}
				case 1:
					return;
				case 0:
					try
					{
						ad.ConnectionString = asdab.c(ae);
					}
					catch
					{
						MessageBox.Show("مشخصات سرور اشتباه است");
						return;
					}
					ab.SelectedIndex = 0;
					a();
					e();
					d();
					c();
					if (true)
					{
					}
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 4:
					{
						num = ((s.RowCount > 0) ? 3 : 7);
						continue;
					}
					IL_011b:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     dbo.tExportRpt.id, dbo.tExportRpt.xExam, dbo.tExportRpt.DateExport, dbo.tExportRpt.TimeStart, dbo.tExportRpt.TimeFinish, dbo.tExportRpt.countStd, \r\n                      dbo.tExam.Name, dbo.tExam.DateFrom, dbo.tExam.DateTo, dbo.tExportRpt.main, dbo.tExportRpt.std, dbo.tExportRpt.mark, \r\n                      dbo.tExportRpt.markDoreh\r\nFROM         dbo.tExportRpt INNER JOIN\r\n                      dbo.tExam ON dbo.tExportRpt.xExam = dbo.tExam.id");
		l.DataSource = dataSource;
	}

	private void d()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT TOP 1  dbo.tExportRpt.id, dbo.tExportRpt.xExam, dbo.tExportRpt.DateExport, dbo.tExportRpt.TimeStart, dbo.tExportRpt.TimeFinish, dbo.tExportRpt.countStd, \r\n                      dbo.tExam.Name, dbo.tExam.DateFrom, dbo.tExam.DateTo, dbo.tExportRpt.main, dbo.tExportRpt.std, dbo.tExportRpt.mark, \r\n                      dbo.tExportRpt.markDoreh\r\n                      FROM dbo.tExportRpt INNER JOIN\r\n                      dbo.tExam ON dbo.tExportRpt.xExam = dbo.tExam.id\r\n                      ORDER BY tExportRpt.id DESC");
		s.DataSource = dataSource;
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass");
		z.DataSource = dataSource;
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ah = "1";
		y.Visible = true;
		n.Enabled = true;
		this.m_f.Visible = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		string text5 = default;
		string text4 = default;
		int num2 = default;
		DataTable dataTable = default;
		string text = default;
		string text3 = default;
		while (true)
		{
			bool flag = n.SelectedIndex >= 0;
			int num = 23;
			while (true)
			{
				switch (num)
				{
				case 23:
					if (!flag)
					{
						num = 28;
						continue;
					}
					flag = !(u.Text == "");
					num = 56;
					continue;
				case 34:
					af = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(xStudent) FROM tMarkDoreh WHERE " + text5 + " (typ = 5) AND Xtest = " + n.SelectedValue).ToString();
					flag = !(af == "0");
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 19;
						continue;
					}
					flag = DialogResult.Yes != MessageBox.Show("تعداد نفرات برای ارسال نمره " + af + " نفر.آیا از ارسال نمرات دوره انتخابی مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 35;
					continue;
				case 18:
					flag = !(text4 != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 8;
				case 45:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 9;
				case 53:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 29;
				case 43:
					asdcb.d(asdab.e(), CommandType.Text, string.Concat("INSERT INTO tExportRpt  (xExam, DateExport, TimeStart, countStd)\r\n                          VALUES     (", n.SelectedValue, ", N'", asdab.b(), "', N'", asdab.d(), "', ", af, ")"));
					e();
					d();
					l.Refresh();
					s.Refresh();
					num = 1;
					continue;
				case 37:
					text5 = " xStudent in(SELECT  id FROM  tStudent WHERE  (xClass IN (" + text4 + "))) and ";
					num = 34;
					continue;
				case 8:
					text4 += z.GetRow(num2).Cells["id"].Value.ToString();
					num = 5;
					continue;
				case 9:
					flag = o.IsBusy;
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 41:
					num = 0;
					continue;
				case 0:
					return;
				case 28:
					MessageBox.Show("دوره مورد نظر را انتخاب کنید");
					num = 32;
					continue;
				case 32:
					return;
				case 7:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 5;
				case 6:
					num2 = 0;
					num = 50;
					continue;
				case 13:
				case 50:
					flag = num2 < z.RowCount;
					num = 52;
					continue;
				case 52:
					if (flag)
					{
						flag = !(z.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 7;
					}
					else
					{
						num = 54;
					}
					continue;
				case 4:
					flag = !(ah == "1");
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 1;
				case 24:
					flag = ad.State != ConnectionState.Open;
					num = 55;
					continue;
				case 55:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 38;
				case 29:
				{
					try
					{
						while (true)
						{
							IL_05bd:
							flag = ad.State == ConnectionState.Open;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 1;
								case 3:
									ad.Open();
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_05a4;
								}
								goto IL_05bd;
								continue;
								end_IL_05a4:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("ارتباط با سرور برقرار نشد-از ارتباط کامپیوتر با اینترنت مطمئن شوید");
						return;
					}
					ad.Close();
					SqlParameter[] a_2 = new SqlParameter[3]
					{
						asdcb.a("@id", SqlDbType.NVarChar, 50, asdab.n),
						asdcb.a("@uid", SqlDbType.NVarChar, 50, u.Text),
						asdcb.a("@pwd", SqlDbType.NVarChar, 500, asdab.d(w.Text))
					};
					dataTable = asdcb.c(asdab.c(ae), CommandType.StoredProcedure, "spCheckSchool", a_2);
					text = "0";
					text3 = "0";
					flag = dataTable.Rows.Count != 0;
					num = 31;
					continue;
				}
				case 31:
				{
					if (!flag)
					{
						num = 15;
						continue;
					}
					text = dataTable.Rows[0]["countStd"].ToString();
					text3 = dataTable.Rows[0]["countDoreh"].ToString();
					w.Text = "";
					string text6 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + n.SelectedValue).ToString();
					flag = !(text6 != "1");
					num = 57;
					continue;
				}
				case 35:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 41;
				case 54:
					flag = !(text4 == "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 58;
						continue;
					}
					if (true)
					{
					}
					num = 29;
					continue;
				case 26:
					text4 += ",";
					num = 8;
					continue;
				case 38:
				{
					string text7 = "شما تنها " + text3.ToString() + " دوره فعال در سایت میتوانید داشته باشید";
					text7 += "\n";
					text7 += "برای پا کردن دوره های قبلی به سایت مراجعه نمایید";
					MessageBox.Show(text7);
					num = 22;
					continue;
				}
				case 22:
					return;
				case 58:
					MessageBox.Show("صنفی انتخاب نشده است");
					z.Focus();
					num = 12;
					continue;
				case 12:
					return;
				case 5:
					num2++;
					num = 13;
					continue;
				case 19:
					MessageBox.Show("نمره ای برای ارسال وجود ندارد");
					num = 40;
					continue;
				case 40:
					return;
				case 56:
					if (!flag)
					{
						num = 11;
						continue;
					}
					flag = !(w.Text == "");
					num = 33;
					continue;
				case 51:
					text5 = "";
					flag = !(text4 != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 37;
						continue;
					}
					goto case 34;
				case 57:
					if (!flag)
					{
						num = 47;
						continue;
					}
					goto case 51;
				case 25:
					ad.Close();
					num = 38;
					continue;
				case 15:
					MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
					w.Text = "";
					w.Focus();
					num = 21;
					continue;
				case 21:
					return;
				case 1:
					t.Visible = false;
					k.Enabled = false;
					this.m_f.Visible = false;
					o.RunWorkerAsync();
					num = 2;
					continue;
				case 33:
					if (flag)
					{
						text4 = "";
						flag = !(ab.SelectedValue.ToString() == "1");
						num = 53;
					}
					else
					{
						num = 39;
					}
					continue;
				case 11:
					MessageBox.Show("نام کاربری را وارد کنید");
					u.Focus();
					num = 30;
					continue;
				case 30:
					return;
				case 2:
					num = 41;
					continue;
				case 47:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, n.SelectedValue) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
					num = 51;
					continue;
				}
				case 39:
					MessageBox.Show("کلمه عبور را وارد کنید");
					w.Focus();
					num = 42;
					continue;
				case 42:
					return;
				case 27:
					b();
					num = 9;
					continue;
				case 48:
					flag = int.Parse(af) <= int.Parse(text);
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						try
						{
							while (true)
							{
								IL_0298:
								flag = ad.State == ConnectionState.Open;
								num = 0;
								while (true)
								{
									switch (num)
									{
									case 0:
										if (!flag)
										{
											num = 3;
											continue;
										}
										goto case 2;
									case 3:
										ad.Open();
										num = 2;
										continue;
									case 2:
										num = 1;
										continue;
									case 1:
										goto end_IL_027f;
									}
									goto IL_0298;
									continue;
									end_IL_027f:
									break;
								}
								break;
							}
						}
						catch
						{
							MessageBox.Show("ارتباط با سرور برقرار نشد-از ارتباط کامپیوتر با اینترنت مطمئن شوید");
							return;
						}
						SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(id) FROM tExam" + asdab.n + " where id<>" + n.SelectedValue.ToString(), ad);
						string text2 = sqlCommand.ExecuteScalar().ToString();
						flag = int.Parse(text2) < int.Parse(text3);
						num = 44;
					}
					else
					{
						num = 46;
					}
					continue;
				case 46:
					MessageBox.Show("تعداد نمرات ارسالی بیش از حد مجاز برای مدرسه شما میباشد.تعداد مجوز مدرسه شما " + text.ToString() + " شاگرد میباشد");
					num = 49;
					continue;
				case 49:
					return;
				case 44:
					if (flag)
					{
						flag = !y.Checked;
						num = 45;
					}
					else
					{
						num = 24;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		asdcb.d(asdab.e(), CommandType.Text, "update tBook set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tClass set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tMark set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tMarkDoreh set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tParmetr set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tPaye set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tStudent set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tTeacher set xExportRpt=null");
		asdcb.d(asdab.e(), CommandType.Text, "update tTosif set xExportRpt=null");
		try
		{
			if (true)
			{
			}
			ad.Open();
		}
		catch
		{
		}
		SqlCommand sqlCommand = new SqlCommand("delete from tmark" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tMarkDoreh" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tBook" + asdab.n, ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tClass" + asdab.n, ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tParmetr" + asdab.n, ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tPaye" + asdab.n, ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tTeacher" + asdab.n, ad);
		sqlCommand.ExecuteNonQuery();
		sqlCommand = new SqlCommand("delete from tTosif" + asdab.n, ad);
		sqlCommand.ExecuteNonQuery();
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam order by id desc");
		n.DataSource = dataSource;
		n.DisplayMember = "Name";
		n.ValueMember = "id";
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}

	private void a(object A_0, DoWorkEventArgs A_1)
	{
		string text2 = default;
		DataTable dataTable = default;
		int num2 = default;
		string text3 = default;
		SqlCommand sqlCommand = default;
		while (true)
		{
			string text = "";
			bool flag = !(ab.SelectedValue.ToString() == "1");
			int num = 106;
			while (true)
			{
				switch (num)
				{
				case 106:
					if (!flag)
					{
						num = 290;
						continue;
					}
					goto case 208;
				case 192:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tStudent set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 193;
					continue;
				}
				case 250:
					ad.Open();
					num = 13;
					continue;
				case 68:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tMark.Xtest, tStudent.xClass, tMark.xbook, AVG(tMark.Mark) AS avgMark, MAX(tMark.Mark) AS maxMark, MIN(tMark.Mark) AS MinMark\r\n                                                                    FROM tMark INNER JOIN tStudent ON tMark.xStudent = tStudent.id\r\n                                                                     WHERE  " + text3 + "   (tMark.Xtest = " + n.SelectedValue.ToString() + ") GROUP BY tMark.Xtest, tMark.xbook, tStudent.xClass");
					flag = ac.State == ConnectionState.Open;
					num = 260;
					continue;
				case 260:
					if (!flag)
					{
						num = 124;
						continue;
					}
					goto case 212;
				case 93:
					sqlCommand.Parameters.AddWithValue("@M3", DBNull.Value);
					num = 184;
					continue;
				case 216:
					A_1.Cancel = true;
					num = 36;
					continue;
				case 36:
					return;
				case 75:
					num2 = 0;
					num = 88;
					continue;
				case 37:
					if (!flag)
					{
						num = 186;
						continue;
					}
					goto case 199;
				case 111:
					A_1.Cancel = true;
					num = 112;
					continue;
				case 112:
					return;
				case 176:
					sqlCommand.Parameters.AddWithValue("@M7", DBNull.Value);
					num = 8;
					continue;
				case 113:
					A_1.Cancel = true;
					num = 70;
					continue;
				case 70:
					return;
				case 69:
				case 242:
					flag = num2 < dataTable.Rows.Count;
					num = 49;
					continue;
				case 49:
					if (!flag)
					{
						num = 221;
						continue;
					}
					flag = !o.CancellationPending;
					num = 73;
					continue;
				case 163:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 29;
				case 268:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     Xtest, xbook, AVG(Mark) AS avgMark, MAX(Mark) AS maxMark, MIN(Mark) AS MinMark FROM tMark\r\n                                                                               WHERE     (Xtest = " + n.SelectedValue.ToString() + ") GROUP BY Xtest, xbook");
					flag = ac.State == ConnectionState.Open;
					num = 167;
					continue;
				case 167:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 89;
				case 77:
					sqlCommand = new SqlCommand("DELETE FROM vAvgBook_Class" + asdab.n + " where " + text3 + " xtest=" + n.SelectedValue.ToString(), ad);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 24;
					continue;
				case 120:
				case 182:
					flag = !(dataTable.Rows[num2]["M9"].ToString() == "");
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@M9", dataTable.Rows[num2]["M9"].ToString());
						num = 87;
					}
					else
					{
						num = 288;
					}
					continue;
				case 259:
					sqlCommand.Parameters.AddWithValue("@M2", DBNull.Value);
					num = 52;
					continue;
				case 105:
					r.Text = "دروس";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tBook where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 214;
						continue;
					}
					goto case 54;
				case 239:
				case 243:
					flag = num2 < dataTable.Rows.Count;
					num = 249;
					continue;
				case 249:
					if (!flag)
					{
						num = 105;
						continue;
					}
					flag = !o.CancellationPending;
					num = 275;
					continue;
				case 28:
					if (!flag)
					{
						num = 220;
						continue;
					}
					goto case 95;
				case 41:
					ad.Open();
					num = 229;
					continue;
				case 124:
					ac.Open();
					num = 212;
					continue;
				case 81:
				case 184:
					flag = !(dataTable.Rows[num2]["M4"].ToString() == "");
					num = 143;
					continue;
				case 143:
					if (!flag)
					{
						num = 61;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@M4", dataTable.Rows[num2]["M4"].ToString());
					num = 272;
					continue;
				case 292:
					ac.Open();
					num = 273;
					continue;
				case 157:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     dbo.tMarkDoreh.Xtest, dbo.tStudent.xClass, COUNT(dbo.tMarkDoreh.xStudent) AS countStd, AVG(dbo.tMarkDoreh.MarkDoreh) AS avgMark, \r\n                      MAX(dbo.tMarkDoreh.MarkDoreh) AS maxMark, MIN(dbo.tMarkDoreh.MarkDoreh) AS MinMark\r\n                        FROM         dbo.tMarkDoreh INNER JOIN\r\n                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id\r\n                        WHERE  " + text3 + "   (dbo.tMarkDoreh.typ = 5) AND    (Xtest = " + n.SelectedValue.ToString() + ") GROUP BY dbo.tMarkDoreh.Xtest, dbo.tStudent.xClass");
					flag = ac.State == ConnectionState.Open;
					num = 119;
					continue;
				case 119:
					if (!flag)
					{
						num = 292;
						continue;
					}
					goto case 273;
				case 35:
					ac.Open();
					num = 136;
					continue;
				case 53:
				case 82:
					flag = num2 < z.RowCount;
					num = 2;
					continue;
				case 2:
					if (flag)
					{
						flag = !(z.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 163;
					}
					else
					{
						num = 165;
					}
					continue;
				case 158:
					num2 = 0;
					num = 71;
					continue;
				case 107:
					ad.Open();
					num = 104;
					continue;
				case 286:
					ad.Open();
					num = 190;
					continue;
				case 140:
					flag = num2 < dataTable.Rows.Count;
					num = 241;
					continue;
				case 241:
					if (!flag)
					{
						num = 268;
						continue;
					}
					flag = !o.CancellationPending;
					num = 281;
					continue;
				case 139:
					text += z.GetRow(num2).Cells["id"].Value.ToString();
					num = 29;
					continue;
				case 87:
				case 254:
					flag = !(dataTable.Rows[num2]["M10"].ToString() == "");
					num = 114;
					continue;
				case 114:
					if (!flag)
					{
						num = 137;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@M10", dataTable.Rows[num2]["M10"].ToString());
					num = 203;
					continue;
				case 185:
					num2++;
					num = 140;
					continue;
				case 146:
				case 169:
					flag = !(dataTable.Rows[num2]["M1"].ToString() == "");
					num = 234;
					continue;
				case 234:
					if (!flag)
					{
						num = 50;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@M1", dataTable.Rows[num2]["M1"].ToString());
					num = 244;
					continue;
				case 177:
				{
					if (!flag)
					{
						num = 44;
						continue;
					}
					sqlCommand = new SqlCommand("sp_tParmetr" + asdab.n + "_InsertUpdate", ad);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@heder1", dataTable.Rows[num2]["heder1"].ToString());
					sqlCommand.Parameters.AddWithValue("@heder2", dataTable.Rows[num2]["heder2"].ToString());
					sqlCommand.Parameters.AddWithValue("@Foter1", dataTable.Rows[num2]["Foter1"].ToString());
					sqlCommand.Parameters.AddWithValue("@Foter2", dataTable.Rows[num2]["Foter2"].ToString());
					sqlCommand.Parameters.AddWithValue("@sch", dataTable.Rows[num2]["sch"].ToString());
					sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
					int num3 = sqlCommand.ExecuteNonQuery();
					flag = num3 <= 0;
					num = 217;
					continue;
				}
				case 89:
					flag = ad.State == ConnectionState.Open;
					num = 38;
					continue;
				case 38:
					if (!flag)
					{
						num = 94;
						continue;
					}
					goto case 181;
				case 90:
				case 99:
					flag = num2 < dataTable.Rows.Count;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 228;
						continue;
					}
					flag = !o.CancellationPending;
					num = 183;
					continue;
				case 67:
					ad.Open();
					num = 77;
					continue;
				case 104:
					num2 = 0;
					num = 197;
					continue;
				case 232:
				case 272:
					flag = !(dataTable.Rows[num2]["M5"].ToString() == "");
					num = 266;
					continue;
				case 266:
					if (!flag)
					{
						num = 40;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@M5", dataTable.Rows[num2]["M5"].ToString());
					num = 18;
					continue;
				case 145:
				case 170:
					flag = !(dataTable.Rows[num2]["M7"].ToString() == "");
					num = 248;
					continue;
				case 248:
					if (!flag)
					{
						num = 176;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@M7", dataTable.Rows[num2]["M7"].ToString());
					num = 72;
					continue;
				case 103:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_vAvgBook" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
						sqlCommand.Parameters.AddWithValue("@xbook", dataTable.Rows[num2]["xbook"].ToString());
						sqlCommand.Parameters.AddWithValue("@avgMark", dataTable.Rows[num2]["avgMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@maxMark", dataTable.Rows[num2]["maxMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@MinMark", dataTable.Rows[num2]["MinMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						num2++;
						num = 240;
					}
					else
					{
						num = 134;
					}
					continue;
				case 199:
					num2++;
					num = 90;
					continue;
				case 294:
					r.Text = "پایه ها";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tPaye where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 194;
					continue;
				case 194:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 109;
				case 245:
					num2++;
					num = 4;
					continue;
				case 285:
					if (!flag)
					{
						num = 51;
						continue;
					}
					goto case 185;
				case 92:
					if (!flag)
					{
						num = 213;
						continue;
					}
					sqlCommand = new SqlCommand("sp_tMark" + asdab.n + "_InsertUpdate", ad);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xStudent", dataTable.Rows[num2]["xStudent"].ToString());
					sqlCommand.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
					sqlCommand.Parameters.AddWithValue("@typ", dataTable.Rows[num2]["typ"].ToString());
					sqlCommand.Parameters.AddWithValue("@xbook", dataTable.Rows[num2]["xbook"].ToString());
					flag = !(dataTable.Rows[num2]["CountAb"].ToString() == "");
					num = 102;
					continue;
				case 13:
					sqlCommand = new SqlCommand("DELETE FROM tTch_Cls" + asdab.n, ad);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 99;
					continue;
				case 7:
					num2 = 0;
					num = 69;
					continue;
				case 154:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tPaye set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 115;
					continue;
				}
				case 73:
				{
					if (!flag)
					{
						num = 247;
						continue;
					}
					sqlCommand = new SqlCommand("sp_tBook" + asdab.n + "_InsertUpdate", ad);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
					sqlCommand.Parameters.AddWithValue("@xPaye", dataTable.Rows[num2]["xPaye"].ToString());
					sqlCommand.Parameters.AddWithValue("@Name", dataTable.Rows[num2]["Name"].ToString());
					sqlCommand.Parameters.AddWithValue("@vahed", dataTable.Rows[num2]["vahed"].ToString());
					sqlCommand.Parameters.AddWithValue("@timeWeek", dataTable.Rows[num2]["timeWeek"].ToString());
					sqlCommand.Parameters.AddWithValue("@Type", dataTable.Rows[num2]["Type"].ToString());
					sqlCommand.Parameters.AddWithValue("@sort", dataTable.Rows[num2]["sort"].ToString());
					sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
					int num3 = sqlCommand.ExecuteNonQuery();
					flag = num3 <= 0;
					num = 233;
					continue;
				}
				case 60:
					if (!flag)
					{
						num = 178;
						continue;
					}
					goto case 245;
				case 137:
					sqlCommand.Parameters.AddWithValue("@M10", DBNull.Value);
					num = 84;
					continue;
				case 251:
					ad.Open();
					num = 158;
					continue;
				case 233:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 256;
				case 238:
					A_1.Cancel = true;
					num = 187;
					continue;
				case 187:
					return;
				case 116:
					ac.Open();
					num = 57;
					continue;
				case 164:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_vAvgBook_Class" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
						sqlCommand.Parameters.AddWithValue("@xClass", dataTable.Rows[num2]["xClass"].ToString());
						sqlCommand.Parameters.AddWithValue("@xbook", dataTable.Rows[num2]["xbook"].ToString());
						sqlCommand.Parameters.AddWithValue("@avgMark", dataTable.Rows[num2]["avgMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@maxMark", dataTable.Rows[num2]["maxMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@MinMark", dataTable.Rows[num2]["MinMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						num2++;
						num = 59;
					}
					else
					{
						num = 111;
					}
					continue;
				case 162:
					num2++;
					num = 144;
					continue;
				case 179:
					sqlCommand = new SqlCommand("DELETE FROM tTosif" + asdab.n, ad);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 30;
					continue;
				case 30:
					if (1 == 0)
					{
					}
					goto case 140;
				case 29:
					num2++;
					num = 53;
					continue;
				case 281:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_tTosif" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
						sqlCommand.Parameters.AddWithValue("@fromMark", dataTable.Rows[num2]["fromMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@toMark", dataTable.Rows[num2]["toMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@tosif", dataTable.Rows[num2]["tosif"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						flag = num3 <= 0;
						num = 285;
					}
					else
					{
						num = 216;
					}
					continue;
				case 109:
					flag = ad.State == ConnectionState.Open;
					num = 91;
					continue;
				case 91:
					if (!flag)
					{
						num = 286;
						continue;
					}
					goto case 190;
				case 42:
					ad.Open();
					num = 75;
					continue;
				case 127:
					ac.Open();
					num = 226;
					continue;
				case 155:
					A_1.Cancel = true;
					num = 204;
					continue;
				case 204:
					return;
				case 5:
					ac.Open();
					num = 109;
					continue;
				case 136:
					flag = ad.State == ConnectionState.Open;
					num = 62;
					continue;
				case 62:
					if (!flag)
					{
						num = 211;
						continue;
					}
					goto case 65;
				case 117:
					ac.Open();
					num = 152;
					continue;
				case 290:
					num2 = 0;
					num = 82;
					continue;
				case 14:
					flag = !(text != "");
					num = 76;
					continue;
				case 76:
					if (!flag)
					{
						num = 205;
						continue;
					}
					goto case 139;
				case 74:
					r.Text = "tch-cls";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM  tTch_Cls where xCls>0");
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 291;
					continue;
				case 291:
					if (!flag)
					{
						num = 116;
						continue;
					}
					goto case 57;
				case 48:
					ac.Open();
					num = 173;
					continue;
				case 247:
					A_1.Cancel = true;
					num = 263;
					continue;
				case 263:
					return;
				case 78:
				case 98:
					flag = num2 < dataTable.Rows.Count;
					num = 66;
					continue;
				case 66:
					if (!flag)
					{
						num = 294;
						continue;
					}
					flag = !o.CancellationPending;
					num = 21;
					continue;
				case 142:
					A_1.Cancel = true;
					num = 278;
					continue;
				case 278:
					return;
				case 51:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tTosif set xExportRpt=" + text2, ac);
					sqlCommand2.ExecuteNonQuery();
					num = 185;
					continue;
				}
				case 52:
				case 133:
					flag = !(dataTable.Rows[num2]["M3"].ToString() == "");
					num = 261;
					continue;
				case 261:
					if (!flag)
					{
						num = 93;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@M3", dataTable.Rows[num2]["M3"].ToString());
					num = 81;
					continue;
				case 174:
					num2 = 0;
					num = 246;
					continue;
				case 27:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_tExam" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
						sqlCommand.Parameters.AddWithValue("@NumExam", dataTable.Rows[num2]["NumExam"].ToString());
						sqlCommand.Parameters.AddWithValue("@Name", dataTable.Rows[num2]["Name"].ToString());
						sqlCommand.Parameters.AddWithValue("@DateFrom", dataTable.Rows[num2]["DateFrom"].ToString());
						sqlCommand.Parameters.AddWithValue("@DateTo", dataTable.Rows[num2]["DateTo"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						flag = num3 <= 0;
						num = 28;
					}
					else
					{
						num = 155;
					}
					continue;
				case 166:
					ac.Open();
					num = 101;
					continue;
				case 61:
					sqlCommand.Parameters.AddWithValue("@M4", DBNull.Value);
					num = 232;
					continue;
				case 193:
					num2++;
					num = 79;
					continue;
				case 118:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_tTeacher" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
						sqlCommand.Parameters.AddWithValue("@fNamF", dataTable.Rows[num2]["fNamF"].ToString());
						sqlCommand.Parameters.AddWithValue("@fNamL", dataTable.Rows[num2]["fNamL"].ToString());
						sqlCommand.Parameters.AddWithValue("@fEmail", dataTable.Rows[num2]["fEmail"].ToString());
						sqlCommand.Parameters.AddWithValue("@fPassword", dataTable.Rows[num2]["fPassword"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						flag = num3 <= 0;
						num = 60;
					}
					else
					{
						num = 188;
					}
					continue;
				case 213:
					A_1.Cancel = true;
					num = 235;
					continue;
				case 235:
					return;
				case 16:
					A_1.Cancel = true;
					num = 123;
					continue;
				case 123:
					return;
				case 275:
				{
					if (!flag)
					{
						num = 19;
						continue;
					}
					sqlCommand = new SqlCommand("sp_tPaye" + asdab.n + "_InsertUpdate", ad);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
					sqlCommand.Parameters.AddWithValue("@Name", dataTable.Rows[num2]["Name"].ToString());
					sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
					int num3 = sqlCommand.ExecuteNonQuery();
					flag = num3 <= 0;
					num = 230;
					continue;
				}
				case 79:
				case 88:
					flag = num2 < dataTable.Rows.Count;
					num = 55;
					continue;
				case 55:
					if (!flag)
					{
						num = 237;
						continue;
					}
					flag = !o.CancellationPending;
					num = 156;
					continue;
				case 85:
					ad.Open();
					num = 174;
					continue;
				case 153:
					A_1.Cancel = true;
					num = 58;
					continue;
				case 58:
					return;
				case 225:
					ac.Open();
					num = 121;
					continue;
				case 151:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tExportRpt set main=1 where id=" + text2, ac);
					sqlCommand2.ExecuteNonQuery();
					sqlCommand = new SqlCommand("update ExportRpt set main=1 where id=" + text2 + " and xschool=" + asdab.n, ad);
					sqlCommand.ExecuteNonQuery();
					d();
					r.Text = "شاگردان";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM  tStudent where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 110;
					continue;
				}
				case 110:
					if (!flag)
					{
						num = 127;
						continue;
					}
					goto case 226;
				case 279:
					text3 = " xStudent in(SELECT  id FROM  tStudent WHERE  (xClass IN (" + text + "))) and ";
					num = 80;
					continue;
				case 208:
				{
					t.Visible = false;
					q.Text = "در حال ارسال نمرات";
					text2 = s.GetRow(0).Cells["id"].Value.ToString();
					sqlCommand = null;
					SqlCommand sqlCommand2 = null;
					sqlCommand = new SqlCommand("spExportRptInsert", ad);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@id", text2);
					sqlCommand.Parameters.AddWithValue("@xSchool", asdab.n);
					sqlCommand.Parameters.AddWithValue("@xExam", n.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@countStd", af);
					sqlCommand.ExecuteNonQuery();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tParmetr");
					flag = ac.State == ConnectionState.Open;
					num = 10;
					continue;
				}
				case 10:
					if (!flag)
					{
						num = 283;
						continue;
					}
					goto case 287;
				case 282:
					sqlCommand = new SqlCommand("DELETE FROM vAvgDoreh_Class" + asdab.n + " where " + text3 + " xtest=" + n.SelectedValue.ToString(), ad);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 131;
					continue;
				case 156:
				{
					if (!flag)
					{
						num = 153;
						continue;
					}
					sqlCommand = new SqlCommand("sp_tStudent" + asdab.n + "_InsertUpdate", ad);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
					sqlCommand.Parameters.AddWithValue("@code", dataTable.Rows[num2]["code"].ToString());
					sqlCommand.Parameters.AddWithValue("@xPaye", dataTable.Rows[num2]["xPaye"].ToString());
					sqlCommand.Parameters.AddWithValue("@xClass", dataTable.Rows[num2]["xClass"].ToString());
					sqlCommand.Parameters.AddWithValue("@xReshteh", dataTable.Rows[num2]["xReshteh"].ToString());
					sqlCommand.Parameters.AddWithValue("@FName", dataTable.Rows[num2]["FName"].ToString());
					sqlCommand.Parameters.AddWithValue("@LName", dataTable.Rows[num2]["LName"].ToString());
					sqlCommand.Parameters.AddWithValue("@PName", dataTable.Rows[num2]["PName"].ToString());
					sqlCommand.Parameters.AddWithValue("@Sh_Sh", dataTable.Rows[num2]["Sh_Sh"].ToString());
					sqlCommand.Parameters.AddWithValue("@pass", dataTable.Rows[num2]["pass"].ToString());
					sqlCommand.Parameters.AddWithValue("@pass2", dataTable.Rows[num2]["pass2"].ToString());
					sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
					int num3 = sqlCommand.ExecuteNonQuery();
					flag = num3 <= 0;
					num = 227;
					continue;
				}
				case 223:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tExportRpt set mark=1 where id=" + text2, ac);
					sqlCommand2.ExecuteNonQuery();
					sqlCommand = new SqlCommand("update ExportRpt set mark=1 where id=" + text2 + " and xschool=" + asdab.n, ad);
					sqlCommand.ExecuteNonQuery();
					d();
					r.Text = "نمره دوره";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tMarkDoreh where " + text3 + " xtest=" + n.SelectedValue.ToString() + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 45;
					continue;
				}
				case 45:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 64;
				case 65:
					num2 = 0;
					num = 1;
					continue;
				case 256:
					num2++;
					num = 242;
					continue;
				case 132:
					num2 = 0;
					num = 280;
					continue;
				case 80:
					r.Text = "نمره دروس";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tMark where " + text3 + " xtest=" + n.SelectedValue.ToString() + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 160;
					continue;
				case 160:
					if (!flag)
					{
						num = 117;
						continue;
					}
					goto case 152;
				case 190:
					num2 = 0;
					num = 243;
					continue;
				case 214:
					ac.Open();
					num = 54;
					continue;
				case 125:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tExportRpt set markDoreh=1,TimeFinish=N'" + asdab.d() + "' where id=" + text2, ac);
					sqlCommand2.ExecuteNonQuery();
					sqlCommand = new SqlCommand("update ExportRpt set markDoreh=1, TimeFinish= CONVERT(VARCHAR(8),GETDATE(),108)  where id=" + text2 + " and xschool=" + asdab.n, ad);
					sqlCommand.ExecuteNonQuery();
					e();
					d();
					l.Row = 0;
					ad.Close();
					ac.Close();
					MessageBox.Show("عملیات ارسال با موفقیت به پایان رسید");
					r.Text = "";
					num = 175;
					continue;
				}
				case 175:
					return;
				case 138:
					if (!flag)
					{
						num = 210;
						continue;
					}
					goto case 196;
				case 283:
					ac.Open();
					num = 287;
					continue;
				case 217:
					if (!flag)
					{
						num = 33;
						continue;
					}
					goto case 162;
				case 206:
					ad.Open();
					num = 179;
					continue;
				case 226:
					flag = ad.State == ConnectionState.Open;
					num = 148;
					continue;
				case 148:
					if (!flag)
					{
						num = 42;
						continue;
					}
					goto case 75;
				case 18:
				case 200:
					flag = !(dataTable.Rows[num2]["M6"].ToString() == "");
					num = 150;
					continue;
				case 150:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@M6", dataTable.Rows[num2]["M6"].ToString());
						num = 170;
					}
					else
					{
						num = 63;
					}
					continue;
				case 227:
					if (!flag)
					{
						num = 192;
						continue;
					}
					goto case 193;
				case 211:
					ad.Open();
					num = 65;
					continue;
				case 289:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tMark set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 34;
					continue;
				}
				case 24:
				case 59:
					flag = num2 < dataTable.Rows.Count;
					num = 126;
					continue;
				case 126:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 164;
					}
					else
					{
						num = 157;
					}
					continue;
				case 210:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tClass set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 196;
					continue;
				}
				case 224:
					sqlCommand.Parameters.AddWithValue("@M8", DBNull.Value);
					num = 182;
					continue;
				case 39:
					if (!flag)
					{
						num = 189;
						continue;
					}
					goto case 262;
				case 19:
					A_1.Cancel = true;
					num = 26;
					continue;
				case 26:
					return;
				case 6:
					ad.Open();
					num = 282;
					continue;
				case 129:
				case 246:
					flag = num2 < dataTable.Rows.Count;
					num = 265;
					continue;
				case 265:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 27;
					}
					else
					{
						num = 151;
					}
					continue;
				case 31:
					ac.Open();
					num = 64;
					continue;
				case 172:
				case 197:
					flag = num2 < dataTable.Rows.Count;
					num = 108;
					continue;
				case 108:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 92;
					}
					else
					{
						num = 223;
					}
					continue;
				case 229:
					sqlCommand = new SqlCommand("DELETE FROM vAvgDoreh" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 78;
					continue;
				case 54:
					flag = ad.State == ConnectionState.Open;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 276;
						continue;
					}
					goto case 7;
				case 34:
					num2++;
					num = 172;
					continue;
				case 178:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tTeacher set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 245;
					continue;
				}
				case 212:
					flag = ad.State == ConnectionState.Open;
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 67;
						continue;
					}
					goto case 77;
				case 100:
					ac.Open();
					num = 25;
					continue;
				case 196:
					num2++;
					num = 269;
					continue;
				case 84:
				case 203:
				{
					sqlCommand.Parameters.AddWithValue("@Mark", dataTable.Rows[num2]["Mark"].ToString());
					sqlCommand.Parameters.AddWithValue("@gClass", dataTable.Rows[num2]["gClass"].ToString());
					sqlCommand.Parameters.AddWithValue("@gKoll", dataTable.Rows[num2]["gKoll"].ToString());
					sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
					int num3 = sqlCommand.ExecuteNonQuery();
					flag = num3 <= 0;
					num = 218;
					continue;
				}
				case 218:
					if (!flag)
					{
						num = 289;
						continue;
					}
					goto case 34;
				case 25:
					flag = ad.State == ConnectionState.Open;
					num = 222;
					continue;
				case 222:
					if (!flag)
					{
						num = 206;
						continue;
					}
					goto case 179;
				case 134:
					A_1.Cancel = true;
					num = 159;
					continue;
				case 159:
					return;
				case 33:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tParmetr set xExportRpt=" + text2, ac);
					sqlCommand2.ExecuteNonQuery();
					num = 162;
					continue;
				}
				case 101:
					flag = ad.State == ConnectionState.Open;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 41;
						continue;
					}
					goto case 229;
				case 144:
				case 280:
					flag = num2 < dataTable.Rows.Count;
					num = 209;
					continue;
				case 209:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 177;
					}
					else
					{
						num = 128;
					}
					continue;
				case 50:
					sqlCommand.Parameters.AddWithValue("@M1", DBNull.Value);
					num = 293;
					continue;
				case 63:
					sqlCommand.Parameters.AddWithValue("@M6", DBNull.Value);
					num = 145;
					continue;
				case 131:
				case 277:
					flag = num2 < dataTable.Rows.Count;
					num = 231;
					continue;
				case 231:
					if (!flag)
					{
						num = 252;
						continue;
					}
					flag = !o.CancellationPending;
					num = 20;
					continue;
				case 228:
					r.Text = "دوره";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tExam where id=" + n.SelectedValue.ToString());
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 225;
						continue;
					}
					goto case 121;
				case 96:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_tClass" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@id", dataTable.Rows[num2]["id"].ToString());
						sqlCommand.Parameters.AddWithValue("@xPaye", dataTable.Rows[num2]["xPaye"].ToString());
						sqlCommand.Parameters.AddWithValue("@Name", dataTable.Rows[num2]["Name"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						flag = num3 <= 0;
						num = 138;
					}
					else
					{
						num = 142;
					}
					continue;
				case 181:
					sqlCommand = new SqlCommand("DELETE FROM vAvgBook" + asdab.n + " where xtest=" + n.SelectedValue.ToString(), ad);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 257;
					continue;
				case 64:
					flag = ad.State == ConnectionState.Open;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 236;
						continue;
					}
					goto case 191;
				case 97:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_tMarkDoreh" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@xStudent", dataTable.Rows[num2]["xStudent"].ToString());
						sqlCommand.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
						sqlCommand.Parameters.AddWithValue("@typ", dataTable.Rows[num2]["typ"].ToString());
						sqlCommand.Parameters.AddWithValue("@MarkDoreh", dataTable.Rows[num2]["MarkDoreh"].ToString());
						sqlCommand.Parameters.AddWithValue("@gClass", dataTable.Rows[num2]["gClass"].ToString());
						sqlCommand.Parameters.AddWithValue("@gPaye", dataTable.Rows[num2]["gPaye"].ToString());
						sqlCommand.Parameters.AddWithValue("@gKoll", dataTable.Rows[num2]["gKoll"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						flag = num3 <= 0;
						num = 39;
					}
					else
					{
						num = 113;
					}
					continue;
				case 44:
					A_1.Cancel = true;
					num = 264;
					continue;
				case 264:
					return;
				case 40:
					sqlCommand.Parameters.AddWithValue("@M5", DBNull.Value);
					num = 200;
					continue;
				case 183:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_tTch_Cls" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@xCls", dataTable.Rows[num2]["xCls"].ToString());
						sqlCommand.Parameters.AddWithValue("@xLsn", dataTable.Rows[num2]["xLsn"].ToString());
						sqlCommand.Parameters.AddWithValue("@xTch", dataTable.Rows[num2]["xTch"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						flag = num3 <= 0;
						num = 37;
					}
					else
					{
						num = 238;
					}
					continue;
				case 57:
					flag = ad.State == ConnectionState.Open;
					num = 271;
					continue;
				case 271:
					if (!flag)
					{
						num = 250;
						continue;
					}
					goto case 13;
				case 173:
					flag = ad.State == ConnectionState.Open;
					num = 83;
					continue;
				case 83:
					if (!flag)
					{
						num = 251;
						continue;
					}
					goto case 158;
				case 102:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@CountAb", dataTable.Rows[num2]["CountAb"].ToString());
						num = 146;
					}
					else
					{
						num = 86;
					}
					continue;
				case 284:
					r.Text = "معلم";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM  tTeacher where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 141;
					continue;
				case 141:
					if (!flag)
					{
						num = 35;
						continue;
					}
					goto case 136;
				case 273:
					flag = ad.State == ConnectionState.Open;
					num = 207;
					continue;
				case 207:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 282;
				case 94:
					ad.Open();
					num = 181;
					continue;
				case 205:
					text += ",";
					num = 139;
					continue;
				case 262:
					num2++;
					num = 267;
					continue;
				case 258:
					ad.Open();
					num = 132;
					continue;
				case 152:
					flag = ad.State == ConnectionState.Open;
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 107;
						continue;
					}
					goto case 104;
				case 71:
				case 269:
					flag = num2 < dataTable.Rows.Count;
					num = 219;
					continue;
				case 219:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 96;
					}
					else
					{
						num = 284;
					}
					continue;
				case 8:
				case 72:
					flag = !(dataTable.Rows[num2]["M8"].ToString() == "");
					num = 135;
					continue;
				case 135:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@M8", dataTable.Rows[num2]["M8"].ToString());
						num = 120;
					}
					else
					{
						num = 224;
					}
					continue;
				case 171:
				case 267:
					flag = num2 < dataTable.Rows.Count;
					num = 195;
					continue;
				case 195:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 97;
					}
					else
					{
						num = 125;
					}
					continue;
				case 0:
					ac.Open();
					num = 89;
					continue;
				case 1:
				case 4:
					flag = num2 < dataTable.Rows.Count;
					num = 56;
					continue;
				case 56:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 118;
					}
					else
					{
						num = 74;
					}
					continue;
				case 47:
					A_1.Cancel = true;
					num = 253;
					continue;
				case 253:
					return;
				case 220:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tExam set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 95;
					continue;
				}
				case 128:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tTosif");
					flag = ac.State == ConnectionState.Open;
					num = 198;
					continue;
				case 198:
					if (!flag)
					{
						num = 100;
						continue;
					}
					goto case 25;
				case 274:
					text3 = "";
					flag = !(text != "");
					num = 161;
					continue;
				case 161:
					if (!flag)
					{
						num = 255;
						continue;
					}
					goto case 68;
				case 237:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tExportRpt set std=1 where id=" + text2, ac);
					sqlCommand2.ExecuteNonQuery();
					sqlCommand = new SqlCommand("update ExportRpt set std=1 where id=" + text2 + " and xschool=" + asdab.n, ad);
					sqlCommand.ExecuteNonQuery();
					d();
					flag = !(text != "");
					num = 180;
					continue;
				}
				case 180:
					if (!flag)
					{
						num = 279;
						continue;
					}
					goto case 80;
				case 20:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_vAvgDoreh_Class" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
						sqlCommand.Parameters.AddWithValue("@xClass", dataTable.Rows[num2]["xClass"].ToString());
						sqlCommand.Parameters.AddWithValue("@countStd", dataTable.Rows[num2]["countStd"].ToString());
						sqlCommand.Parameters.AddWithValue("@avgMark", dataTable.Rows[num2]["avgMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@maxMark", dataTable.Rows[num2]["maxMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@MinMark", dataTable.Rows[num2]["MinMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						num2++;
						num = 277;
					}
					else
					{
						num = 16;
					}
					continue;
				case 186:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tTch_Cls set xExportRpt=" + text2 + " where  (xCls = @xCls) AND (xLsn = @xLsn)", ac);
					sqlCommand2.Parameters.AddWithValue("@xCls", dataTable.Rows[num2]["xCls"].ToString());
					sqlCommand2.Parameters.AddWithValue("@xLsn", dataTable.Rows[num2]["xLsn"].ToString());
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 199;
					continue;
				}
				case 189:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tMarkDoreh set xExportRpt=" + text2 + " where  xStudent=@xStudent and Xtest=@Xtest and typ=@typ", ac);
					sqlCommand2.Parameters.AddWithValue("@xStudent", dataTable.Rows[num2]["xStudent"].ToString());
					sqlCommand2.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
					sqlCommand2.Parameters.AddWithValue("@typ", dataTable.Rows[num2]["typ"].ToString());
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 262;
					continue;
				}
				case 147:
					MessageBox.Show("صنفی انتخاب نشده است");
					z.Focus();
					num = 270;
					continue;
				case 270:
					return;
				case 276:
					ad.Open();
					num = 7;
					continue;
				case 86:
					sqlCommand.Parameters.AddWithValue("@countAb", DBNull.Value);
					num = 169;
					continue;
				case 43:
				{
					SqlCommand sqlCommand2 = new SqlCommand("update tBook set xExportRpt=" + text2 + " where id=" + dataTable.Rows[num2]["id"].ToString(), ac);
					sqlCommand2.ExecuteNonQuery();
					p.PerformStep();
					num = 256;
					continue;
				}
				case 221:
					r.Text = "صنف ها";
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT * FROM tClass where id>0" + ag);
					p.Minimum = 0;
					p.Maximum = dataTable.Rows.Count;
					p.Value = 0;
					p.Step = 1;
					flag = ac.State == ConnectionState.Open;
					num = 168;
					continue;
				case 168:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 173;
				case 236:
					ad.Open();
					num = 191;
					continue;
				case 191:
					num2 = 0;
					num = 171;
					continue;
				case 121:
					flag = ad.State == ConnectionState.Open;
					num = 122;
					continue;
				case 122:
					if (!flag)
					{
						num = 85;
						continue;
					}
					goto case 174;
				case 188:
					A_1.Cancel = true;
					num = 202;
					continue;
				case 202:
					return;
				case 95:
					num2++;
					num = 129;
					continue;
				case 255:
					text3 = "  xClass in(" + text + ") and ";
					num = 68;
					continue;
				case 244:
				case 293:
					flag = !(dataTable.Rows[num2]["M2"].ToString() == "");
					num = 215;
					continue;
				case 215:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@M2", dataTable.Rows[num2]["M2"].ToString());
						num = 133;
					}
					else
					{
						num = 259;
					}
					continue;
				case 240:
				case 257:
					flag = num2 < dataTable.Rows.Count;
					num = 149;
					continue;
				case 149:
					if (flag)
					{
						flag = !o.CancellationPending;
						num = 103;
					}
					else
					{
						num = 274;
					}
					continue;
				case 165:
					flag = !(text == "");
					num = 201;
					continue;
				case 201:
					num = ((!flag) ? 147 : 208);
					continue;
				case 21:
					if (flag)
					{
						sqlCommand = new SqlCommand("sp_vAvgDoreh" + asdab.n + "_InsertUpdate", ad);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("@Xtest", dataTable.Rows[num2]["Xtest"].ToString());
						sqlCommand.Parameters.AddWithValue("@xPaye", dataTable.Rows[num2]["xPaye"].ToString());
						sqlCommand.Parameters.AddWithValue("@countStd", dataTable.Rows[num2]["countStd"].ToString());
						sqlCommand.Parameters.AddWithValue("@avgMark", dataTable.Rows[num2]["avgMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@maxMark", dataTable.Rows[num2]["maxMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@MinMark", dataTable.Rows[num2]["MinMark"].ToString());
						sqlCommand.Parameters.AddWithValue("@xExportRpt", text2);
						int num3 = sqlCommand.ExecuteNonQuery();
						num2++;
						num = 98;
					}
					else
					{
						num = 47;
					}
					continue;
				case 252:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     dbo.tMarkDoreh.Xtest, dbo.tStudent.xPaye, COUNT(dbo.tMarkDoreh.xStudent) AS countStd, AVG(dbo.tMarkDoreh.MarkDoreh) AS avgMark, \r\n                      MAX(dbo.tMarkDoreh.MarkDoreh) AS maxMark, MIN(dbo.tMarkDoreh.MarkDoreh) AS MinMark\r\n                        FROM         dbo.tMarkDoreh INNER JOIN\r\n                      dbo.tStudent ON dbo.tMarkDoreh.xStudent = dbo.tStudent.id\r\n                        WHERE     (dbo.tMarkDoreh.typ = 5) AND    (Xtest = " + n.SelectedValue.ToString() + ") GROUP BY dbo.tMarkDoreh.Xtest, dbo.tStudent.xPaye");
					flag = ac.State == ConnectionState.Open;
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 166;
						continue;
					}
					goto case 101;
				case 287:
					flag = ad.State == ConnectionState.Open;
					num = 130;
					continue;
				case 130:
					if (!flag)
					{
						num = 258;
						continue;
					}
					goto case 132;
				case 115:
					num2++;
					num = 239;
					continue;
				case 230:
					if (!flag)
					{
						num = 154;
						continue;
					}
					goto case 115;
				case 288:
					sqlCommand.Parameters.AddWithValue("@M9", DBNull.Value);
					num = 254;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ProgressChangedEventArgs A_1)
	{
		if (true)
		{
		}
		q.Text = A_1.ProgressPercentage + "%";
	}

	private void a(object A_0, RunWorkerCompletedEventArgs A_1)
	{
		while (true)
		{
			bool flag = !A_1.Cancelled;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = A_1.Error == null;
					num = 4;
					continue;
				case 1:
					if (true)
					{
					}
					q.Text = "Canceled!";
					num = 2;
					continue;
				case 3:
				{
					q.Text = "Error: " + A_1.Error.Message;
					t.Visible = true;
					string text = "خطایی در ارسال رخ داده است";
					text += "\n";
					text += "ممکن است ارتباط کامپیوتر با اینترت قطع شده باشد";
					text += "\n";
					text += "ابتدا از اتصال به اینترنت مطمئن شده سپس دکمه ادامه ارسال را کلیک کنید";
					MessageBox.Show(text);
					num = 0;
					continue;
				}
				case 0:
					return;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					q.Text = "پایان ارسال";
					num = 6;
					continue;
				case 2:
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ah = "2";
		y.Checked = false;
		y.Visible = false;
		n.SelectedValue = s.GetRow(0).Cells["xExam"].Value.ToString();
		n.Enabled = false;
		this.m_f.Visible = true;
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		while (true)
		{
			bool flag = !o.IsBusy;
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
						num = 4;
						continue;
					}
					return;
				case 6:
					o.WorkerSupportsCancellation = true;
					o.CancelAsync();
					num = 3;
					continue;
				case 4:
					flag = DialogResult.Yes != MessageBox.Show("سیستم در حال ارسال نمرات میباشد.آیا مایل به خروج و قطع ارسال نمرات هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						A_1.Cancel = true;
						num = 2;
					}
					else
					{
						num = 6;
					}
					continue;
				case 2:
				case 3:
					num = 5;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !y.Checked;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					ab.Enabled = true;
					num = 2;
					continue;
				case 0:
					ab.SelectedIndex = 0;
					ab.Enabled = false;
					num = 3;
					continue;
				case 3:
					return;
				case 4:
					flag = DialogResult.Yes == MessageBox.Show("از این گزینه تنها در ابتدای سال تحصیلی و موارد خاص استفاده میشود.آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 1:
					if (true)
					{
					}
					y.Checked = false;
					num = 0;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ab.SelectedValue.ToString() == "1");
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
						num = 1;
						continue;
					}
					z.Visible = false;
					this.m_f.Height = 176;
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					z.Visible = true;
					this.m_f.Height = 460;
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}
}
