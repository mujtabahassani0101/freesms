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
using school_Af.Rpt.afPayment;

public class asdar : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private UIComboBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private UIButton m_i;

	private OpenFileDialog m_j;

	private Panel k;

	private GridEX l;

	private Label m;

	private Panel n;

	private Label o;

	private UIButton p;

	private UIButton q;

	private ProgressBar r;

	private UIButton s;

	private SaveFileDialog t;

	private UIButton u;

	private UIComboBox v;

	private Panel w;

	private Label x;

	private string y = "";

	private string z = "";

	private string aa = "";

	private string ab = "";

	public string ac = "";

	private bool ad = false;

	private bool ae = false;

	private bool af = false;
protected override void Dispose(bool A_0)
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
						num = 6;
					}
					else
					{
						num = 4;
					}
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 5;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
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

	private void d()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdar));
		GridEXLayout gridEXLayout = new GridEXLayout();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		this.m_b = new Panel();
		w = new Panel();
		x = new Label();
		u = new UIButton();
		r = new ProgressBar();
		s = new UIButton();
		q = new UIButton();
		n = new Panel();
		o = new Label();
		this.m_c = new UIButton();
		l = new GridEX();
		p = new UIButton();
		this.m_i = new UIButton();
		this.m_d = new UIGroupBox();
		v = new UIComboBox();
		m = new Label();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		this.m_e = new Label();
		this.m_f = new UIComboBox();
		this.m_j = new OpenFileDialog();
		k = new Panel();
		t = new SaveFileDialog();
		this.m_b.SuspendLayout();
		w.SuspendLayout();
		n.SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_d.SuspendLayout();
		k.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(u);
		this.m_b.Controls.Add(r);
		this.m_b.Controls.Add(s);
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(n);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(l);
		this.m_b.Controls.Add(p);
		this.m_b.Controls.Add(this.m_i);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(5, 5);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(900, 674);
		this.m_b.TabIndex = 0;
		this.m_b.Paint += a;
		w.Controls.Add(x);
		w.Location = new Point(297, 286);
		w.Name = "plode";
		w.Size = new Size(305, 100);
		w.TabIndex = 139;
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.AutoSize = true;
		x.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		x.Location = new Point(62, 45);
		x.Name = "label8";
		x.Size = new Size(189, 13);
		x.TabIndex = 30;
		x.Text = "در حال بارگزاری لطفا کمی صبر کنید";
		u.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		u.Image = (Image)componentResourceManager.GetObject("btnview.Image");
		u.ImageSize = new Size(40, 40);
		u.Location = new Point(196, 621);
		u.Name = "btnview";
		u.Size = new Size(149, 46);
		u.TabIndex = 138;
		u.Text = "نمایش گزارش";
		u.Click += b;
		r.Location = new Point(372, 595);
		r.Name = "pr12";
		r.Size = new Size(167, 20);
		r.TabIndex = 137;
		r.Visible = false;
		s.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Image = (Image)componentResourceManager.GetObject("btnXls.Image");
		s.ImageSize = new Size(30, 30);
		s.Location = new Point(372, 621);
		s.Name = "btnXls";
		s.Size = new Size(167, 45);
		s.TabIndex = 136;
		s.Text = "دریافت فایل اکسل";
		s.Click += c;
		q.Image = (Image)componentResourceManager.GetObject("btnSelectDate.Image");
		q.Location = new Point(13, 65);
		q.Name = "btnSelectDate";
		q.Size = new Size(108, 31);
		q.TabIndex = 135;
		q.Text = "انتخاب تاریخ";
		q.Click += d;
		n.BackColor = SystemColors.HotTrack;
		n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		n.Controls.Add(o);
		n.Location = new Point(127, 62);
		n.Name = "panelStd";
		n.Size = new Size(756, 37);
		n.TabIndex = 134;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		o.BackColor = Color.FromArgb(0, 192, 192);
		o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		o.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(2, 2);
		o.Name = "lPayment";
		o.RightToLeft = RightToLeft.Yes;
		o.Size = new Size(749, 31);
		o.TabIndex = 77;
		o.TextAlign = ContentAlignment.MiddleCenter;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_c.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(20, 20);
		this.m_c.Location = new Point(13, 621);
		this.m_c.Name = "btnClose";
		this.m_c.Size = new Size(149, 46);
		this.m_c.TabIndex = 3;
		this.m_c.Text = "بستن";
		this.m_c.Click += g;
		l.AllowEdit = InheritableBoolean.False;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		l.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		l.DesignTimeLayout = gridEXLayout;
		l.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		l.Font = new Font("Tahoma", 8.25f);
		l.Location = new Point(13, 105);
		l.Name = "gridEX2";
		l.RecordNavigator = true;
		l.RowHeaders = InheritableBoolean.True;
		l.Size = new Size(874, 494);
		l.TabIndex = 18;
		l.TotalRow = InheritableBoolean.True;
		l.VisualStyle = VisualStyle.Office2003;
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		p.Location = new Point(734, 621);
		p.Name = "btnNew";
		p.Size = new Size(149, 46);
		p.TabIndex = 0;
		p.Text = "ثبت مورد جدید";
		p.Click += i;
		this.m_i.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_i.Location = new Point(579, 621);
		this.m_i.Name = "btnEdit";
		this.m_i.Size = new Size(149, 46);
		this.m_i.TabIndex = 1;
		this.m_i.Text = "اصلاح مورد انتخابی";
		this.m_i.Click += h;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(v);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Controls.Add(this.m_h);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Location = new Point(13, 0);
		this.m_d.Name = "uiGroupBox1";
		this.m_d.Size = new Size(874, 58);
		this.m_d.TabIndex = 0;
		this.m_d.Text = "جستجو";
		v.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		v.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		v.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
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
		v.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		v.Location = new Point(688, 22);
		v.Name = "dropYear";
		v.Size = new Size(97, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		v.StringFormat = stringFormat;
		v.TabIndex = 136;
		v.SelectedIndexChanged += a;
		m.AutoSize = true;
		m.Location = new Point(792, 24);
		m.Name = "label10";
		m.Size = new Size(66, 13);
		m.TabIndex = 135;
		m.Text = "سال تعلیمی";
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.AutoSize = true;
		this.m_g.Location = new Point(233, 24);
		this.m_g.Name = "label19";
		this.m_g.Size = new Size(30, 13);
		this.m_g.TabIndex = 25;
		this.m_g.Text = "صنف";
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("Tahoma", 8.25f);
		this.m_h.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_h.Location = new Point(26, 20);
		this.m_h.Name = "dropCls";
		this.m_h.Size = new Size(201, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat2;
		this.m_h.TabIndex = 1;
		this.m_h.SelectedIndexChanged += e;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(585, 26);
		this.m_e.Name = "label20";
		this.m_e.Size = new Size(22, 13);
		this.m_e.TabIndex = 15;
		this.m_e.Text = "پایه";
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_f.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_f.Location = new Point(378, 20);
		this.m_f.Name = "dropPaye";
		this.m_f.Size = new Size(201, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		this.m_f.StringFormat = stringFormat3;
		this.m_f.TabIndex = 0;
		this.m_f.SelectedIndexChanged += f;
		this.m_j.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_j.Title = "انتخاب عکس شاگرد";
		k.BackColor = Color.Black;
		k.Controls.Add(this.m_b);
		k.Dock = DockStyle.Fill;
		k.Location = new Point(0, 0);
		k.Name = "panel2";
		k.Size = new Size(910, 685);
		k.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(910, 685);
		Controls.Add(k);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmPaymentList";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست پرداخت های شاگرد";
		Load += j;
		this.m_b.ResumeLayout(performLayout: false);
		w.ResumeLayout(performLayout: false);
		w.PerformLayout();
		n.ResumeLayout(performLayout: false);
		((ISupportInitialize)l).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		k.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdar()
	{
		d();
	}

	private void j(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("9");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 0:
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
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto IL_012c;
				case 5:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_012c;
				case 4:
					{
						num = 0;
						continue;
					}
					IL_012c:
					OriginalSchoolYears.Select(v, asdaj.__field_a);
					ae = true;
					d(this, null);
					ad = true;
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + v.SelectedValue.ToString() + ") order by id");
			this.m_f.Items.Clear();
			this.m_f.Items.Add("کل", "0");
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 1:
					flag = num < dataTable.Rows.Count;
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					this.m_f.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 2:
					this.m_f.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		while (true)
		{
			ad = false;
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_f.SelectedIndex <= 0;
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
					if (true)
					{
					}
					text = text + " and xPaye=" + this.m_f.SelectedValue.ToString();
					num = 0;
					continue;
				case 0:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + v.SelectedValue.ToString() + text);
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					ad = true;
					this.m_h.SelectedIndex = 0;
					return;
				}
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 19;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 19:
					num = ((!ad) ? 10 : 5);
					continue;
				case 20:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 23;
				case 1:
				case 29:
					num = 4;
					continue;
				case 17:
					text += " and ";
					num = 14;
					continue;
				case 16:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 14;
				case 14:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 23;
					continue;
				case 9:
					flag = !(y != "");
					num = 28;
					continue;
				case 28:
					if (true)
					{
					}
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 4;
				case 5:
					num = 3;
					continue;
				case 3:
					num2 = (ae ? 1 : 0);
					goto IL_0325;
				case 18:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 9;
					continue;
				case 15:
					flag = !(text != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 18;
				case 7:
					text += " and ";
					num = 18;
					continue;
				case 6:
					text = " where " + text;
					num = 32;
					continue;
				case 0:
					if (flag)
					{
						l.DataSource = null;
						w.Visible = true;
						Refresh();
						text = " tYear_Student.xYear=" + v.SelectedValue.ToString() + " and   tPaymentStudent.xyear=" + v.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
						flag = this.m_h.SelectedIndex <= 0;
						num = 20;
					}
					else
					{
						num = 31;
					}
					continue;
				case 10:
					num2 = 0;
					goto IL_0325;
				case 32:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tPaymentStudent.*, ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) \r\n                      + ISNULL(tPaymentStudent.Celebration, 0) + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) \r\n                      + ISNULL(tPaymentStudent.ketab, 0) + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) \r\n                      AS SumPay, tStudent.Code AS Code, tStudent.FName AS FName, tStudent.LName AS LName, tStudent.PName AS PName, tClass.name AS Class, \r\n                      tPaye.Name AS Paye\r\n                      FROM   tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id" + text);
					l.DataSource = dataSource;
					w.Visible = false;
					num = 22;
					continue;
				}
				case 22:
					return;
				case 23:
					flag = this.m_f.SelectedIndex <= 0;
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 9;
				case 31:
					num = 11;
					continue;
				case 11:
					return;
				case 13:
				{
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + y + "' and tPaymentStudent.PaynemtDate<=N'" + z + "'";
					num = 1;
					continue;
				}
				case 8:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 12;
				case 30:
					text += " and ";
					num = 12;
					continue;
				case 4:
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 32;
				case 12:
					flag = !(z != "");
					num = 27;
					continue;
				case 27:
					{
						if (flag)
						{
							text = text + " tPaymentStudent.PaynemtDate=N'" + y + "'";
							num = 29;
						}
						else
						{
							num = 13;
						}
						continue;
					}
					IL_0325:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		asda5 asda10 = new asda5();
		asda10.ShowDialog();
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = "";
			string text2 = "";
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					num2 = 1;
					goto IL_0202;
				case 3:
					num = 4;
					continue;
				case 4:
					num2 = ((!(text != "")) ? 1 : 0);
					goto IL_0202;
				case 1:
				{
					asdae asdae2 = new asdae();
					asdae2.aw = text2;
					asdae2.ax = v.SelectedValue.ToString();
					asdae2.ay = text;
					asdae2.ShowDialog();
					a();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 6:
					try
					{
						while (true)
						{
							IL_00f7:
							num = 6;
							while (true)
							{
								int num3;
								switch (num)
								{
								case 6:
									num = ((l.RowCount > 0) ? 1 : 3);
									continue;
								case 3:
									num3 = 1;
									goto IL_0155;
								case 1:
									num = 5;
									continue;
								case 5:
									num3 = ((l.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
									goto IL_0155;
								case 0:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 4;
								case 2:
									text2 = l.SelectedItems[0].GetRow().Cells["xStudent"].Value.ToString();
									text = l.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
									num = 4;
									continue;
								case 4:
									num = 7;
									continue;
								case 7:
									goto end_IL_00ce;
									IL_0155:
									flag = (byte)num3 != 0;
									num = 0;
									continue;
								}
								goto IL_00f7;
								continue;
								end_IL_00ce:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 5;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 5:
					{
						num = ((text2 != "") ? 3 : 2);
						continue;
					}
					IL_0202:
					flag = (byte)num2 != 0;
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void f(object A_0, EventArgs A_1)
	{
		ad = false;
		b();
	}

	private void e(object A_0, EventArgs A_1)
	{
		a();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			asdbs asdbs2 = new asdbs();
			asdbs2.n = y;
			asdbs2.o = z;
			asdbs2.m = ac;
			asdbs2.ShowDialog();
			y = asdbs2.n;
			z = asdbs2.o;
			aa = asdbs2.p;
			ab = asdbs2.q;
			ac = asdbs2.m;
			bool flag = !(y != "");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 6;
						continue;
					}
					o.Text = "لیست کلیه پرداخت های ثبت شده";
					num = 4;
					continue;
				case 2:
				case 3:
					num = 1;
					continue;
				case 6:
					flag = !(z != "");
					num = 0;
					continue;
				case 0:
					if (true)
					{
					}
					if (flag)
					{
						o.Text = "لیست پرداخت های روز " + aa + " " + y;
						num = 2;
					}
					else
					{
						num = 5;
					}
					continue;
				case 5:
					o.Text = "لیست پرداخت ها از روز" + aa + " " + y + " تا روز " + ab + " " + z;
					num = 3;
					continue;
				case 1:
				case 4:
					ad = true;
					a();
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		asdbe asdbe2 = default;
		SaveFileDialog saveFileDialog = default;
		while (true)
		{
			string text = " tYear_Student.xYear=" + v.SelectedValue.ToString() + " and    tPaymentStudent.xyear=" + v.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
			bool flag = this.m_h.SelectedIndex <= 0;
			int num = 11;
			while (true)
			{
				string a_;
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 8;
				case 15:
					text += " and ";
					num = 17;
					continue;
				case 8:
					flag = this.m_f.SelectedIndex <= 0;
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 10;
				case 13:
					text = " where " + text;
					num = 27;
					continue;
				case 27:
					if (1 == 0)
					{
					}
					goto IL_023b;
				case 23:
					text += " and ";
					num = 18;
					continue;
				case 22:
				{
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + y + "' and tPaymentStudent.PaynemtDate<=N'" + z + "'";
					num = 14;
					continue;
				}
				case 9:
					if (!flag)
					{
						num = 12;
						continue;
					}
					return;
				case 2:
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 17;
				case 26:
					flag = !(text != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 5;
				case 0:
					flag = !(text != "");
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto IL_023b;
				case 12:
					asdbe2.b(saveFileDialog.FileName);
					MessageBox.Show("پایان");
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 10;
					continue;
				case 24:
					flag = !(text != "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 18;
				case 18:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 8;
					continue;
				case 1:
					text += " and ";
					num = 5;
					continue;
				case 10:
					flag = !(y != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 4:
				case 14:
					num = 0;
					continue;
				case 17:
					flag = !(z != "");
					num = 19;
					continue;
				case 19:
					{
						if (flag)
						{
							text = text + " tPaymentStudent.PaynemtDate=N'" + y + "'";
							num = 4;
						}
						else
						{
							num = 22;
						}
						continue;
					}
					IL_023b:
					a_ = "SELECT     tStudent.Code AS [کد متعلم], tStudent.FName AS نام, tStudent.LName AS [ولد-بنت], tStudent.PName AS ولدیت, tPaye.Name AS پایه, tClass.name AS صنف, \r\n\r\n                      tPaymentStudent.PaynemtDate AS [تاریخ پرداخت], tPaymentStudent.dayOfWeek AS روز, tPaymentStudent.NamberBel AS [نمبر بل],                      ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS [جمع پرداخت],  tPaymentStudent.Fee AS فیس, \r\n                      tPaymentStudent.Transport AS ترانسپورت, tPaymentStudent.racing AS مسابقه, tPaymentStudent.Celebration AS جشن, tPaymentStudent.Exam AS امتحان, \r\n                      tPaymentStudent.uniform AS یونیفرم, tPaymentStudent.maghnae AS مقنعه, tPaymentStudent.ketab AS کتاب, tPaymentStudent.komakdarsi AS [کمک درسی], \r\n                      tPaymentStudent.dakhle AS داخله, tPaymentStudent.other AS سایر, tPaymentStudent.comment AS توضیحات\r\n                    FROM         tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id" + text;
					asdbe2 = new asdbe(a_, asdab.e());
					saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "Excel Spreadsheets (*.xls)|*.xls";
					saveFileDialog.DefaultExt = "xls";
					flag = saveFileDialog.ShowDialog() != DialogResult.OK;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		string text = default;
		SqlParameter[] a_3 = default;
		while (true)
		{
			string a_ = "";
			string a_2 = "";
			bool flag = !(y != "");
			int num = 13;
			while (true)
			{
				switch (num)
				{
				case 13:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 17;
				case 30:
					flag = !(z != "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 29;
						continue;
					}
					text = text + " tPaymentStudent.PaynemtDate=N'" + y + "'";
					num = 16;
					continue;
				case 5:
					text = text + " tYear_Student.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 21;
					continue;
				case 20:
					a_3 = new SqlParameter[3]
					{
						asdcb.a("@dateFrom", SqlDbType.NVarChar, a_),
						asdcb.a("@dateTo", SqlDbType.NVarChar, a_2),
						asdcb.a("@dayName", SqlDbType.NVarChar, aa)
					};
					text = " tYear_Student.xYear=" + v.SelectedValue.ToString() + " and  tPaymentStudent.xyear=" + v.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = this.m_h.SelectedIndex <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 18;
				case 9:
					a_2 = z.Substring(8, 2) + "/" + z.Substring(5, 2) + "/" + z.Substring(0, 4);
					num = 20;
					continue;
				case 3:
					text += " and ";
					num = 30;
					continue;
				case 26:
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 12;
				case 23:
					text += " and ";
					num = 5;
					continue;
				case 27:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 2;
				case 16:
				case 25:
					num = 26;
					continue;
				case 22:
					text = " where " + text;
					num = 12;
					continue;
				case 18:
					flag = this.m_f.SelectedIndex <= 0;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 21;
				case 10:
					a_ = y.Substring(8, 2) + "/" + y.Substring(5, 2) + "/" + y.Substring(0, 4);
					num = 17;
					continue;
				case 14:
					text += " and ";
					num = 2;
					continue;
				case 17:
					flag = !(z != "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 20;
				case 11:
					flag = !(text != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 5;
				case 29:
				{
					if (true)
					{
					}
					string text2 = text;
					text = text2 + " tPaymentStudent.PaynemtDate>=N'" + y + "' and tPaymentStudent.PaynemtDate<=N'" + z + "'";
					num = 25;
					continue;
				}
				case 19:
					flag = !(text != "");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 30;
				case 2:
					text = text + " tYear_Student.xClass=" + this.m_h.SelectedValue.ToString();
					num = 18;
					continue;
				case 21:
					flag = !(y != "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 26;
				case 12:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  @dateFrom as dateFrom,@dateTo as dateTo, @dayName as dayName ,   ISNULL(tPaymentStudent.Fee, 0) + ISNULL(tPaymentStudent.Transport, 0) + ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS SumPay,  ISNULL(tPaymentStudent.racing, 0) + ISNULL(tPaymentStudent.Celebration, 0) \r\n                      + ISNULL(tPaymentStudent.Exam, 0) + ISNULL(tPaymentStudent.uniform, 0) + ISNULL(tPaymentStudent.maghnae, 0) + ISNULL(tPaymentStudent.ketab, 0) \r\n                      + ISNULL(tPaymentStudent.komakdarsi, 0) + ISNULL(tPaymentStudent.dakhle, 0) + ISNULL(tPaymentStudent.other, 0) AS SumOther, tStudent.Code AS Code, \r\n                      tStudent.FName AS FName, tStudent.LName AS LName, tStudent.PName AS PName, tClass.name AS Class, tPaye.Name AS Paye, tYear_Student.xPaye, \r\n                      tYear_Student.xClass, tPaymentStudent.id, tPaymentStudent.xYear, tPaymentStudent.xStudent, tPaymentStudent.PaynemtDate, tPaymentStudent.dayOfWeek, \r\n                      tPaymentStudent.NamberBel, tPaymentStudent.Fee, tPaymentStudent.Transport, tPaymentStudent.racing, tPaymentStudent.Celebration, tPaymentStudent.Exam, \r\n                      tPaymentStudent.uniform, tPaymentStudent.maghnae, tPaymentStudent.ketab, tPaymentStudent.komakdarsi, tPaymentStudent.dakhle, tPaymentStudent.other, \r\n                      tPaymentStudent.comment , tParmetr.heder1, tParmetr.sch\r\n                        FROM         tPaymentStudent INNER JOIN\r\n                      tStudent ON tPaymentStudent.xStudent = tStudent.id INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id   CROSS JOIN\r\n                      tParmetr" + text, a_3);
					ReportClass reportClass = null;
					reportClass = new CrRptListPayment();
					reportClass.SetDataSource(dataSource);
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					return;
				}
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		ad = false;
		c();
	}
}
