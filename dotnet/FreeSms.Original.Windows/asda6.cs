using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using school_Af.Properties;

public class asda6 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private Label m_e;

	private UIButton m_f;

	private GridEX m_g;

	private UIComboBox m_h;

	private Label m_i;

	private Label m_j;

	private Label k;

	private Button l;

	private Button m;

	private CheckBox n;

	private Label o;

	private Panel p;

	private Label q;

	private SqlConnection r = new SqlConnection(asdab.e());

	private string s = "";

	public string t = "";

	private string u = "Acp3";

	private bool v = true;

	private int w;

	private bool x = false;

	private bool y = false;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					if (A_0)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				case 2:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
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
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda6));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		o = new Label();
		n = new CheckBox();
		m = new Button();
		l = new Button();
		this.m_j = new Label();
		k = new Label();
		this.m_h = new UIComboBox();
		this.m_i = new Label();
		this.m_e = new Label();
		this.m_f = new UIButton();
		this.m_g = new GridEX();
		p = new Panel();
		q = new Label();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		((ISupportInitialize)this.m_g).BeginInit();
		p.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(1010, 700);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(1008, 698);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(this.m_j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(this.m_h);
		this.m_d.Controls.Add(this.m_i);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(1002, 689);
		this.m_d.TabIndex = 0;
		o.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.ForeColor = Color.FromArgb(192, 64, 0);
		o.Location = new Point(110, 648);
		o.Name = "label1";
		o.Size = new Size(419, 41);
		o.TabIndex = 122;
		o.Text = "توضیح:زمانی که تیک رنگی شدن نمرات کمتر از حدنصاب خورده باشد ،به علت نیاز به تنظیم رنگ ها سیستم یک مقدار کند می شود";
		n.AutoSize = true;
		n.Checked = true;
		n.CheckState = CheckState.Checked;
		n.ForeColor = Color.Red;
		n.Location = new Point(549, 652);
		n.Name = "checkMarkMin";
		n.Size = new Size(219, 30);
		n.TabIndex = 121;
		n.Text = "رنگی شدن نمرات کمتر از حدنصاب";
		n.UseVisualStyleBackColor = true;
		n.CheckedChanged += b;
		m.BackColor = Color.Violet;
		m.FlatAppearance.BorderColor = Color.Maroon;
		m.FlatAppearance.BorderSize = 3;
		m.FlatStyle = FlatStyle.Flat;
		m.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m.ImageAlign = ContentAlignment.MiddleRight;
		m.Location = new Point(12, 10);
		m.Name = "btnCopygClass";
		m.Size = new Size(194, 35);
		m.TabIndex = 120;
		m.Text = "درخواست نتیجه پیشنهادی سیستم";
		m.UseVisualStyleBackColor = false;
		m.Click += f;
		l.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		l.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		l.Image = Resources._4160;
		l.ImageAlign = ContentAlignment.MiddleRight;
		l.Location = new Point(797, 648);
		l.Name = "btnSaveMark";
		l.Size = new Size(197, 35);
		l.TabIndex = 119;
		l.Text = "ثبت نتایج(F5)";
		l.UseVisualStyleBackColor = true;
		l.Click += g;
		this.m_j.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_j.Location = new Point(584, 14);
		this.m_j.Name = "lYear";
		this.m_j.Size = new Size(55, 24);
		this.m_j.TabIndex = 118;
		this.m_j.Click += e;
		k.AutoSize = true;
		k.Location = new Point(647, 12);
		k.Name = "label3";
		k.Size = new Size(78, 26);
		k.TabIndex = 117;
		k.Text = "سال تعلیمی";
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("B Nazanin", 12f);
		this.m_h.Location = new Point(315, 8);
		this.m_h.Name = "dropCls";
		this.m_h.Size = new Size(181, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat;
		this.m_h.TabIndex = 52;
		this.m_h.SelectedIndexChanged += h;
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(502, 13);
		this.m_i.Name = "label19";
		this.m_i.Size = new Size(41, 26);
		this.m_i.TabIndex = 51;
		this.m_i.Text = "صنف";
		this.m_e.Font = new Font("B Nazanin", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.ForeColor = Color.DarkViolet;
		this.m_e.Location = new Point(756, 4);
		this.m_e.Name = "lTerm";
		this.m_e.Size = new Size(245, 44);
		this.m_e.TabIndex = 50;
		this.m_e.Text = "ثبت نتیجه نهایی";
		this.m_e.TextAlign = ContentAlignment.MiddleCenter;
		this.m_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_f.DialogResult = DialogResult.Cancel;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_f.ImageSize = new Size(40, 40);
		this.m_f.Location = new Point(11, 649);
		this.m_f.Name = "btnClose";
		this.m_f.Size = new Size(93, 35);
		this.m_f.TabIndex = 44;
		this.m_f.Text = "بستن";
		this.m_f.Click += i;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_g.DesignTimeLayout = gridEXLayout;
		this.m_g.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_g.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_g.GroupByBoxVisible = false;
		this.m_g.Location = new Point(12, 51);
		this.m_g.Name = "gridEX1";
		this.m_g.RecordNavigator = true;
		this.m_g.RightToLeft = RightToLeft.Yes;
		this.m_g.RowHeaders = InheritableBoolean.True;
		this.m_g.SelectedFormatStyle.BackColor = Color.Empty;
		this.m_g.SelectedFormatStyle.ForeColor = Color.Empty;
		this.m_g.Size = new Size(987, 591);
		this.m_g.TabIndex = 45;
		this.m_g.VisualStyle = VisualStyle.Office2003;
		this.m_g.LayoutLoad += d;
		this.m_g.FormattingRow += a;
		this.m_g.CellUpdated += a;
		this.m_g.Scroll += c;
		p.Controls.Add(q);
		p.Location = new Point(349, 294);
		p.Name = "plode";
		p.Size = new Size(305, 100);
		p.TabIndex = 138;
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.AutoSize = true;
		q.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		q.Location = new Point(62, 45);
		q.Name = "label8";
		q.Size = new Size(189, 13);
		q.TabIndex = 30;
		q.Text = "در حال بارگزاری لطفا کمی صبر کنید";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1010, 700);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSetAcpTerm";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نتایج شاگردان";
		Load += j;
		Shown += a;
		KeyUp += a;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)this.m_g).EndInit();
		p.ResumeLayout(performLayout: false);
		p.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public asda6()
	{
		f();
	}

	private void e()
	{
		try
		{
			bool flag = default;
			while (true)
			{
				IL_0052:
				string text = asdcb.a(asdab.e(), CommandType.Text, "select xpaye from tclass where id=" + this.m_h.SelectedValue.ToString()).ToString();
				this.m_g.RootTable.Columns["acpFinal"].HasValueList = true;
				GridEXValueListItemCollection valueList = this.m_g.RootTable.Columns["acpFinal"].ValueList;
				valueList.Clear();
				int num = 15;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 15:
						num = ((!(text == "12")) ? 1 : 13);
						continue;
					case 1:
						num = 0;
						continue;
					case 0:
						num2 = ((!(text == "11")) ? 1 : 0);
						goto IL_01be;
					case 8:
						flag = !(t == "3");
						num = 11;
						continue;
					case 11:
						if (!flag)
						{
							num = 14;
							continue;
						}
						valueList.Add(new GridEXValueListItem("1", "کامیاب"));
						valueList.Add(new GridEXValueListItem("0", "ناکام"));
						valueList.Add(new GridEXValueListItem("5", "غایب"));
						valueList.Add(new GridEXValueListItem("4", "محروم"));
						num = 5;
						continue;
					case 12:
						if (!flag)
						{
							num = 8;
							continue;
						}
						flag = !(t == "3");
						num = 10;
						continue;
					case 3:
						valueList.Add(new GridEXValueListItem("1", "ارتقا صنف"));
						valueList.Add(new GridEXValueListItem("2", "مشروط"));
						valueList.Add(new GridEXValueListItem("0", "تکرار صنف"));
						valueList.Add(new GridEXValueListItem("3", "معذرتی"));
						valueList.Add(new GridEXValueListItem("4", "محروم"));
						num = 7;
						continue;
					case 13:
						num2 = 0;
						goto IL_01be;
					case 14:
						valueList.Add(new GridEXValueListItem("1", "کامیاب"));
						valueList.Add(new GridEXValueListItem("2", "مشروط"));
						valueList.Add(new GridEXValueListItem("0", "ناکام"));
						valueList.Add(new GridEXValueListItem("3", "معذرتی"));
						valueList.Add(new GridEXValueListItem("4", "محروم"));
						num = 9;
						continue;
					case 10:
						if (flag)
						{
							valueList.Add(new GridEXValueListItem("1", "موفق"));
							valueList.Add(new GridEXValueListItem("0", "تلاش بیشتر"));
							valueList.Add(new GridEXValueListItem("5", "غایب"));
							valueList.Add(new GridEXValueListItem("4", "محروم"));
							num = 4;
						}
						else
						{
							num = 3;
						}
						continue;
					case 4:
					case 7:
						num = 2;
						continue;
					case 5:
					case 9:
						num = 6;
						continue;
					case 2:
					case 6:
						num = 16;
						continue;
					case 16:
						goto end_IL_0005;
						IL_01be:
						flag = (byte)num2 != 0;
						num = 12;
						continue;
					}
					goto IL_0052;
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

	private void j(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 1;
				case 3:
					u = "Acp1";
					this.m_e.Text = "ثبت نتیجه چهار و نیم ماه";
					num = 8;
					continue;
				case 8:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				case 1:
					this.m_j.Text = asdaj.__field_a;
					flag = !(t == "1");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 7:
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
					num = 1;
					continue;
				case 9:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			if (true)
			{
			}
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where  xYear=" + this.m_j.Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
			this.m_h.DataSource = dataSource;
			this.m_h.DisplayMember = "Name";
			this.m_h.ValueMember = "id";
			bool flag = this.m_h.Items.Count <= 0;
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
					this.m_h.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					return;
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
		this.m_g.DataSource = null;
		p.Visible = true;
		Refresh();
		b();
	}

	private void b()
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = this.m_h.SelectedIndex < 0;
			int num = 72;
			while (true)
			{
				switch (num)
				{
				case 72:
					if (!flag)
					{
						num = 20;
						continue;
					}
					return;
				case 11:
				case 27:
					flag = !(dataTable.Rows[0]["book14"].ToString() == "");
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 43;
						continue;
					}
					this.m_g.RootTable.Columns["mark14"].Caption = dataTable.Rows[0]["book14"].ToString();
					num = 69;
					continue;
				case 60:
					this.m_g.RootTable.Columns["mark11"].Visible = false;
					num = 34;
					continue;
				case 63:
				case 76:
					flag = !(dataTable.Rows[0]["book4"].ToString() == "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 66;
						continue;
					}
					this.m_g.RootTable.Columns["mark4"].Caption = dataTable.Rows[0]["book4"].ToString();
					num = 56;
					continue;
				case 77:
					this.m_g.RootTable.Columns["mark2"].Visible = false;
					num = 2;
					continue;
				case 68:
					this.m_g.RootTable.Columns["mark18"].Visible = false;
					num = 24;
					continue;
				case 39:
					this.m_g.Visible = true;
					num = 15;
					continue;
				case 26:
					this.m_g.RootTable.Columns["mark8"].Visible = false;
					num = 65;
					continue;
				case 20:
					flag = !n.Checked;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 51;
				case 2:
				case 48:
					flag = !(dataTable.Rows[0]["book3"].ToString() == "");
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark3"].Caption = dataTable.Rows[0]["book3"].ToString();
						num = 76;
					}
					else
					{
						num = 7;
					}
					continue;
				case 3:
					this.m_g.RootTable.Columns["mark5"].Visible = false;
					num = 54;
					continue;
				case 57:
				case 67:
					flag = !(dataTable.Rows[0]["book18"].ToString() == "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 68;
						continue;
					}
					this.m_g.RootTable.Columns["mark18"].Caption = dataTable.Rows[0]["book18"].ToString();
					num = 75;
					continue;
				case 10:
				case 81:
					flag = !(dataTable.Rows[0]["book8"].ToString() == "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 26;
						continue;
					}
					this.m_g.RootTable.Columns["mark8"].Caption = dataTable.Rows[0]["book8"].ToString();
					num = 73;
					continue;
				case 62:
					this.m_g.RootTable.Columns["mark6"].Visible = false;
					num = 18;
					continue;
				case 66:
					this.m_g.RootTable.Columns["mark4"].Visible = false;
					num = 17;
					continue;
				case 9:
					this.m_g.RootTable.Columns["mark16"].Visible = false;
					num = 38;
					continue;
				case 49:
				case 54:
					flag = !(dataTable.Rows[0]["book6"].ToString() == "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 62;
						continue;
					}
					this.m_g.RootTable.Columns["mark6"].Caption = dataTable.Rows[0]["book6"].ToString();
					num = 30;
					continue;
				case 17:
				case 56:
					flag = !(dataTable.Rows[0]["book5"].ToString() == "");
					num = 41;
					continue;
				case 41:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark5"].Caption = dataTable.Rows[0]["book5"].ToString();
						num = 49;
					}
					else
					{
						num = 3;
					}
					continue;
				case 14:
					this.m_g.Visible = false;
					num = 51;
					continue;
				case 29:
				case 61:
					flag = !(dataTable.Rows[0]["book10"].ToString() == "");
					num = 32;
					continue;
				case 32:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark10"].Caption = dataTable.Rows[0]["book10"].ToString();
						num = 44;
					}
					else
					{
						num = 45;
					}
					continue;
				case 31:
					this.m_g.RootTable.Columns["mark7"].Visible = false;
					num = 81;
					continue;
				case 19:
					this.m_g.RootTable.Columns["mark15"].Visible = false;
					num = 35;
					continue;
				case 65:
				case 73:
					flag = !(dataTable.Rows[0]["book9"].ToString() == "");
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 64;
						continue;
					}
					this.m_g.RootTable.Columns["mark9"].Caption = dataTable.Rows[0]["book9"].ToString();
					num = 29;
					continue;
				case 70:
					this.m_g.RootTable.Columns["mark17"].Visible = false;
					num = 67;
					continue;
				case 58:
				case 83:
					flag = !(dataTable.Rows[0]["book2"].ToString() == "");
					num = 82;
					continue;
				case 82:
					if (!flag)
					{
						num = 77;
						continue;
					}
					this.m_g.RootTable.Columns["mark2"].Caption = dataTable.Rows[0]["book2"].ToString();
					num = 48;
					continue;
				case 51:
				{
					SqlParameter[] a_ = new SqlParameter[3]
					{
						asdcb.a("@xTerm", SqlDbType.Int, t),
						asdcb.a("@xClass", SqlDbType.Int, this.m_h.SelectedValue.ToString()),
						asdcb.a("@xYear", SqlDbType.Int, this.m_j.Text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, "sp_SelectStdForSetAcp", a_);
					this.m_g.DataSource = dataTable;
					this.m_g.RootTable.Columns["mark1"].Visible = true;
					this.m_g.RootTable.Columns["mark2"].Visible = true;
					this.m_g.RootTable.Columns["mark3"].Visible = true;
					this.m_g.RootTable.Columns["mark4"].Visible = true;
					this.m_g.RootTable.Columns["mark5"].Visible = true;
					this.m_g.RootTable.Columns["mark6"].Visible = true;
					this.m_g.RootTable.Columns["mark7"].Visible = true;
					this.m_g.RootTable.Columns["mark8"].Visible = true;
					this.m_g.RootTable.Columns["mark9"].Visible = true;
					this.m_g.RootTable.Columns["mark10"].Visible = true;
					this.m_g.RootTable.Columns["mark11"].Visible = true;
					this.m_g.RootTable.Columns["mark12"].Visible = true;
					this.m_g.RootTable.Columns["mark13"].Visible = true;
					this.m_g.RootTable.Columns["mark14"].Visible = true;
					this.m_g.RootTable.Columns["mark15"].Visible = true;
					this.m_g.RootTable.Columns["mark16"].Visible = true;
					this.m_g.RootTable.Columns["mark17"].Visible = true;
					this.m_g.RootTable.Columns["mark18"].Visible = true;
					flag = dataTable.Rows.Count <= 0;
					num = 50;
					continue;
				}
				case 50:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 33;
				case 24:
				case 75:
					num = 33;
					continue;
				case 30:
					if (1 == 0)
					{
					}
					goto case 18;
				case 25:
				case 35:
					flag = !(dataTable.Rows[0]["book16"].ToString() == "");
					num = 47;
					continue;
				case 47:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark16"].Caption = dataTable.Rows[0]["book16"].ToString();
						num = 5;
					}
					else
					{
						num = 9;
					}
					continue;
				case 79:
					this.m_g.RootTable.Columns["mark1"].Visible = false;
					num = 58;
					continue;
				case 18:
					flag = !(dataTable.Rows[0]["book7"].ToString() == "");
					num = 78;
					continue;
				case 78:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark7"].Caption = dataTable.Rows[0]["book7"].ToString();
						num = 10;
					}
					else
					{
						num = 31;
					}
					continue;
				case 22:
					this.m_g.RootTable.Columns["mark13"].Visible = false;
					num = 27;
					continue;
				case 5:
				case 38:
					flag = !(dataTable.Rows[0]["book17"].ToString() == "");
					num = 37;
					continue;
				case 37:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark17"].Caption = dataTable.Rows[0]["book17"].ToString();
						num = 57;
					}
					else
					{
						num = 70;
					}
					continue;
				case 33:
				{
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(this.m_g.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					this.m_g.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(this.m_g.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					this.m_g.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					e();
					flag = !n.Checked;
					num = 71;
					continue;
				}
				case 71:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 15;
				case 7:
					this.m_g.RootTable.Columns["mark3"].Visible = false;
					num = 63;
					continue;
				case 12:
					this.m_g.RootTable.Columns["mark12"].Visible = false;
					num = 59;
					continue;
				case 34:
				case 40:
					flag = !(dataTable.Rows[0]["book12"].ToString() == "");
					num = 0;
					continue;
				case 0:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark12"].Caption = dataTable.Rows[0]["book12"].ToString();
						num = 16;
					}
					else
					{
						num = 12;
					}
					continue;
				case 42:
				case 69:
					flag = !(dataTable.Rows[0]["book15"].ToString() == "");
					num = 55;
					continue;
				case 55:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark15"].Caption = dataTable.Rows[0]["book15"].ToString();
						num = 25;
					}
					else
					{
						num = 19;
					}
					continue;
				case 44:
				case 52:
					flag = !(dataTable.Rows[0]["book11"].ToString() == "");
					num = 74;
					continue;
				case 74:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark11"].Caption = dataTable.Rows[0]["book11"].ToString();
						num = 40;
					}
					else
					{
						num = 60;
					}
					continue;
				case 45:
					this.m_g.RootTable.Columns["mark10"].Visible = false;
					num = 52;
					continue;
				case 64:
					this.m_g.RootTable.Columns["mark9"].Visible = false;
					num = 61;
					continue;
				case 16:
				case 59:
					flag = !(dataTable.Rows[0]["book13"].ToString() == "");
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark13"].Caption = dataTable.Rows[0]["book13"].ToString();
						num = 11;
					}
					else
					{
						num = 22;
					}
					continue;
				case 43:
					this.m_g.RootTable.Columns["mark14"].Visible = false;
					num = 42;
					continue;
				case 15:
					p.Visible = false;
					num = 53;
					continue;
				case 53:
					return;
				case 80:
					flag = !(dataTable.Rows[0]["book1"].ToString() == "");
					num = 23;
					continue;
				case 23:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark1"].Caption = dataTable.Rows[0]["book1"].ToString();
						num = 83;
					}
					else
					{
						num = 79;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		int num4 = default;
		int num6 = default;
		GridEXFormatStyle gridEXFormatStyle = default;
		int num2 = default;
		while (true)
		{
			bool flag = !n.Checked;
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
					return;
				case 13:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_00e2:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark13"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 2;
								case 0:
									this.m_g.GetRow(num4).Cells["mark13"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_00c9;
								}
								goto IL_00e2;
								continue;
								end_IL_00c9:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 20;
					continue;
				}
				case 2:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_01a0:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark10"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 1;
								case 0:
									this.m_g.GetRow(num4).Cells["mark10"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0187;
								}
								goto IL_01a0;
								continue;
								end_IL_0187:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 23;
					continue;
				}
				case 18:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_02c6:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark3"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									goto case 2;
								case 0:
									this.m_g.GetRow(num4).Cells["mark3"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_02ad;
								}
								goto IL_02c6;
								continue;
								end_IL_02ad:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 21;
					continue;
				}
				case 16:
				case 31:
					flag = num4 < this.m_g.RowCount;
					num = 10;
					continue;
				case 10:
				{
					if (!flag)
					{
						num = 11;
						continue;
					}
					float num3 = 0f;
					num = 17;
					continue;
				}
				case 28:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_03d7:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark7"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									this.m_g.GetRow(num4).Cells["mark7"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_03be;
								}
								goto IL_03d7;
								continue;
								end_IL_03be:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 29;
					continue;
				}
				case 7:
					if (true)
					{
					}
					num6 = 16;
					flag = !(t == "3");
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 24;
				case 0:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_04de:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark2"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 1;
										continue;
									}
									goto case 0;
								case 1:
									this.m_g.GetRow(num4).Cells["mark2"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_04c5;
								}
								goto IL_04de;
								continue;
								end_IL_04c5:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 18;
					continue;
				}
				case 19:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_05b6:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark17"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 1;
								case 0:
									this.m_g.GetRow(num4).Cells["mark17"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_059d;
								}
								goto IL_05b6;
								continue;
								end_IL_059d:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 5;
					continue;
				}
				case 21:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_06f6:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark4"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									this.m_g.GetRow(num4).Cells["mark4"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_06dd;
								}
								goto IL_06f6;
								continue;
								end_IL_06dd:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 30;
					continue;
				}
				case 24:
					num2 = 20;
					flag = !(t == "3");
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 12;
				case 22:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_080e:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark6"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									this.m_g.GetRow(num4).Cells["mark6"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_07f5;
								}
								goto IL_080e;
								continue;
								end_IL_07f5:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 28;
					continue;
				}
				case 3:
					num6 = 40;
					num = 24;
					continue;
				case 30:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_08e2:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark5"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
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
									this.m_g.GetRow(num4).Cells["mark5"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 3;
									continue;
								case 3:
									goto end_IL_08c9;
								}
								goto IL_08e2;
								continue;
								end_IL_08c9:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 22;
					continue;
				}
				case 25:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_09a0:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark1"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									goto case 1;
								case 3:
									this.m_g.GetRow(num4).Cells["mark1"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0987;
								}
								goto IL_09a0;
								continue;
								end_IL_0987:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 0;
					continue;
				}
				case 4:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0a5e:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark15"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									goto case 1;
								case 3:
									this.m_g.GetRow(num4).Cells["mark15"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0a45;
								}
								goto IL_0a5e;
								continue;
								end_IL_0a45:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 15;
					continue;
				}
				case 12:
				{
					float num3 = 0f;
					float num5 = 0f;
					gridEXFormatStyle = new GridEXFormatStyle();
					gridEXFormatStyle.BackColor = Color.Red;
					num4 = 0;
					num = 31;
					continue;
				}
				case 8:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0b6c:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark12"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
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
									goto case 3;
								case 2:
									this.m_g.GetRow(num4).Cells["mark12"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_0b53;
								}
								goto IL_0b6c;
								continue;
								end_IL_0b53:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 13;
					continue;
				}
				case 15:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0c5e:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark16"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 2;
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
									goto case 0;
								case 1:
									this.m_g.GetRow(num4).Cells["mark16"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 3;
									continue;
								case 3:
									goto end_IL_0c45;
								}
								goto IL_0c5e;
								continue;
								end_IL_0c45:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 19;
					continue;
				}
				case 5:
					try
					{
						while (true)
						{
							IL_0d1c:
							float num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark18"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									this.m_g.GetRow(num4).Cells["mark18"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0d03;
								}
								goto IL_0d1c;
								continue;
								end_IL_0d03:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num4++;
					num = 16;
					continue;
				case 23:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0dda:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark11"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									this.m_g.GetRow(num4).Cells["mark11"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_0dc1;
								}
								goto IL_0dda;
								continue;
								end_IL_0dc1:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 8;
					continue;
				}
				case 29:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0e98:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark8"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									goto case 2;
								case 0:
									this.m_g.GetRow(num4).Cells["mark8"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_0e7f;
								}
								goto IL_0e98;
								continue;
								end_IL_0e7f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 6;
					continue;
				}
				case 20:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0f8a:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark14"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									this.m_g.GetRow(num4).Cells["mark14"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_0f71;
								}
								goto IL_0f8a;
								continue;
								end_IL_0f71:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 4;
					continue;
				}
				case 6:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_1048:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark9"].Value.ToString());
							flag = !(num5 < (float)num6);
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
									goto case 0;
								case 3:
									this.m_g.GetRow(num4).Cells["mark9"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_102f;
								}
								goto IL_1048;
								continue;
								end_IL_102f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 2;
					continue;
				}
				case 11:
					num = 9;
					continue;
				case 9:
					return;
				case 17:
				{
					try
					{
						while (true)
						{
							IL_1148:
							float num3 = float.Parse(this.m_g.GetRow(num4).Cells["markkoll"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 2;
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
									goto case 3;
								case 1:
									this.m_g.GetRow(num4).Cells["markkoll"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_112f;
								}
								goto IL_1148;
								continue;
								end_IL_112f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					float num5 = 0f;
					num = 25;
					continue;
				}
				case 26:
					num2 = 50;
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void h(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = v;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 8;
				case 5:
					try
					{
						this.m_g.CurrentColumn = this.m_g.GetRow(0).Cells["gTerm"].Column;
						this.m_g.Select();
						this.m_g.SelectCurrentCellText();
					}
					catch
					{
					}
					w = this.m_h.SelectedIndex;
					num = 7;
					continue;
				case 0:
					x = false;
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					flag = !x;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 3;
					continue;
				case 8:
					x = false;
					v = true;
					c();
					num = 5;
					continue;
				case 7:
					return;
				case 10:
					x = true;
					this.m_h.SelectedIndex = w;
					num = 9;
					continue;
				case 9:
					return;
				case 3:
					num = ((!flag) ? 10 : 8);
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			SqlCommand sqlCommand = null;
			y = true;
			string text = "";
			int num = 0;
			r.Open();
			int num2 = 0;
			int num3 = 10;
			while (true)
			{
				switch (num3)
				{
				case 7:
				case 13:
					num3 = 3;
					continue;
				case 12:
					num3 = 7;
					continue;
				case 0:
				case 10:
					flag = num2 < this.m_g.RowCount;
					num3 = 14;
					continue;
				case 14:
					if (!flag)
					{
						num3 = 15;
						continue;
					}
					text = "";
					num3 = 6;
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_00fc:
							flag = !(this.m_g.GetRow(num2).Cells["acpFinal"].Text != "");
							if (true)
							{
							}
							num3 = 1;
							while (true)
							{
								switch (num3)
								{
								case 1:
									num3 = (flag ? 4 : 2);
									continue;
								case 2:
									short.Parse(this.m_g.GetRow(num2).Cells["acpFinal"].Value.ToString());
									text = this.m_g.GetRow(num2).Cells["acpFinal"].Value.ToString();
									num3 = 3;
									continue;
								case 4:
									goto end_IL_00df;
								case 3:
									num3 = 0;
									continue;
								case 0:
									goto IL_02af;
								}
								goto IL_00fc;
								continue;
								end_IL_00df:
								break;
							}
							break;
						}
					}
					catch
					{
						this.m_g.GetRow(num2).BeginEdit();
						this.m_g.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_g.GetRow(num2).EndEdit();
					}
					goto case 3;
				case 3:
					num2++;
					num3 = 0;
					continue;
				case 4:
					MessageBox.Show("تعداد " + num + " ردیف انجام شد");
					num3 = 9;
					continue;
				case 9:
					return;
				case 1:
				case 16:
				{
					int num4 = sqlCommand.ExecuteNonQuery();
					flag = num4 >= 1;
					num3 = 5;
					continue;
				}
				case 5:
					if (!flag)
					{
						num3 = 12;
						continue;
					}
					this.m_g.GetRow(num2).BeginEdit();
					this.m_g.GetRow(num2).Cells["acp"].Value = "1";
					this.m_g.GetRow(num2).EndEdit();
					num++;
					num3 = 13;
					continue;
				case 8:
					if (!flag)
					{
						num3 = 2;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@Acp", text);
					num3 = 1;
					continue;
				case 15:
					r.Close();
					this.m_g.Refresh();
					v = true;
					y = false;
					a();
					flag = num <= 0;
					num3 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num3 = 4;
						continue;
					}
					return;
				case 2:
					{
						sqlCommand.Parameters.AddWithValue("@Acp", DBNull.Value);
						num3 = 16;
						continue;
					}
					IL_02af:
					sqlCommand = new SqlCommand("update tYear_Student set " + u + "=@Acp where id=@id", r);
					sqlCommand.Parameters.AddWithValue("@id", this.m_g.GetRow(num2).Cells["id"].Text.ToString());
					flag = text != null;
					num3 = 8;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		v = false;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.F5;
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
					this.m_g.Refresh();
					g(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		while (true)
		{
			bool flag = v;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 5:
					return;
				case 4:
					A_1.Cancel = true;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 2;
					continue;
				case 2:
					if (flag)
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
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			v = false;
			y = true;
			int num = 0;
			int num2 = 2;
			while (true)
			{
				if (true)
				{
				}
				switch (num2)
				{
				case 0:
				case 2:
					flag = num < this.m_g.RowCount;
					num2 = 1;
					continue;
				case 1:
					num2 = ((!flag) ? 4 : 3);
					continue;
				case 3:
					try
					{
						this.m_g.GetRow(num).BeginEdit();
						this.m_g.GetRow(num).Cells["acp"].Value = DBNull.Value;
						this.m_g.GetRow(num).Cells["AcpFinal"].Value = this.m_g.GetRow(num).Cells["AcpDef"].Text.ToString();
						this.m_g.GetRow(num).EndEdit();
					}
					catch
					{
					}
					num++;
					num2 = 0;
					continue;
				case 4:
					y = false;
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
	}

	private void d(object A_0, EventArgs A_1)
	{
		e();
	}

	private void c(object A_0, EventArgs A_1)
	{
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !n.Checked;
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
					this.m_g.Refresh();
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					this.m_g.Visible = false;
					this.m_g.Visible = true;
					a();
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, RowLoadEventArgs A_1)
	{
		bool flag = default;
		int num4 = default;
		GridEXFormatStyle gridEXFormatStyle = default;
		int num2 = default;
		while (true)
		{
			int num = 18;
			while (true)
			{
				int num6;
				switch (num)
				{
				case 18:
					num = ((!n.Checked) ? 2 : 12);
					continue;
				case 20:
				{
					try
					{
						while (true)
						{
							IL_01a5:
							float num5 = float.Parse(A_1.Row.Cells["markkoll"].Value.ToString());
							flag = !(num5 < (float)num4);
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
									goto case 3;
								case 2:
									A_1.Row.Cells["markkoll"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 1;
									continue;
								case 1:
									goto end_IL_018c;
								}
								goto IL_01a5;
								continue;
								end_IL_018c:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					float num3 = 0f;
					num = 31;
					continue;
				}
				case 27:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0255:
							num3 = float.Parse(A_1.Row.Cells["mark12"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									A_1.Row.Cells["mark12"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_023c;
								}
								goto IL_0255;
								continue;
								end_IL_023c:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 11;
					continue;
				}
				case 6:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0305:
							num3 = float.Parse(A_1.Row.Cells["mark17"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 1;
								case 2:
									A_1.Row.Cells["mark17"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_02ec;
								}
								goto IL_0305;
								continue;
								end_IL_02ec:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 4;
					continue;
				}
				case 23:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_03cf:
							num3 = float.Parse(A_1.Row.Cells["mark16"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 3;
								case 0:
									A_1.Row.Cells["mark16"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_03b6;
								}
								goto IL_03cf;
								continue;
								end_IL_03b6:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 6;
					continue;
				}
				case 12:
					num = 17;
					continue;
				case 17:
					num6 = (y ? 1 : 0);
					goto IL_0938;
				case 1:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_04b2:
							num3 = float.Parse(A_1.Row.Cells["mark3"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 1;
								case 3:
									A_1.Row.Cells["mark3"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0499;
								}
								goto IL_04b2;
								continue;
								end_IL_0499:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 8;
					continue;
				}
				case 0:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0562:
							num3 = float.Parse(A_1.Row.Cells["mark14"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									A_1.Row.Cells["mark14"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 3;
									continue;
								case 3:
									goto end_IL_0549;
								}
								goto IL_0562;
								continue;
								end_IL_0549:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 29;
					continue;
				}
				case 15:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0629:
							num3 = float.Parse(A_1.Row.Cells["mark6"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 3;
								case 2:
									A_1.Row.Cells["mark6"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_0610;
								}
								goto IL_0629;
								continue;
								end_IL_0610:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 22;
					continue;
				}
				case 19:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_06d9:
							num3 = float.Parse(A_1.Row.Cells["mark11"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 1;
								case 2:
									A_1.Row.Cells["mark11"].FormatStyle = gridEXFormatStyle;
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_06c0;
								}
								goto IL_06d9;
								continue;
								end_IL_06c0:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 27;
					continue;
				}
				case 8:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0789:
							num3 = float.Parse(A_1.Row.Cells["mark4"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 3;
								case 0:
									A_1.Row.Cells["mark4"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_0770;
								}
								goto IL_0789;
								continue;
								end_IL_0770:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 13;
					continue;
				}
				case 25:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0839:
							num3 = float.Parse(A_1.Row.Cells["mark2"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 0;
								case 3:
									A_1.Row.Cells["mark2"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0820;
								}
								goto IL_0839;
								continue;
								end_IL_0820:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 1;
					continue;
				}
				case 29:
				{
					if (true)
					{
					}
					float num3;
					try
					{
						while (true)
						{
							IL_00f5:
							num3 = float.Parse(A_1.Row.Cells["mark15"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 3;
								case 1:
									A_1.Row.Cells["mark15"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_00dc;
								}
								goto IL_00f5;
								continue;
								end_IL_00dc:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 23;
					continue;
				}
				case 9:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 14:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_097d:
							num3 = float.Parse(A_1.Row.Cells["mark8"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									A_1.Row.Cells["mark8"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0964;
								}
								goto IL_097d;
								continue;
								end_IL_0964:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 30;
					continue;
				}
				case 28:
				{
					float num5 = 0f;
					float num3 = 0f;
					gridEXFormatStyle = new GridEXFormatStyle();
					gridEXFormatStyle.BackColor = Color.Red;
					num5 = 0f;
					num = 20;
					continue;
				}
				case 2:
					num6 = 1;
					goto IL_0938;
				case 5:
					num2 = 40;
					num = 3;
					continue;
				case 31:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0af8:
							num3 = float.Parse(A_1.Row.Cells["mark1"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 2;
								case 0:
									A_1.Row.Cells["mark1"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_0adf;
								}
								goto IL_0af8;
								continue;
								end_IL_0adf:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 25;
					continue;
				}
				case 13:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0ba8:
							num3 = float.Parse(A_1.Row.Cells["mark5"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 3;
								case 1:
									A_1.Row.Cells["mark5"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_0b8f;
								}
								goto IL_0ba8;
								continue;
								end_IL_0b8f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 15;
					continue;
				}
				case 11:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0c72:
							num3 = float.Parse(A_1.Row.Cells["mark13"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 2;
								case 0:
									A_1.Row.Cells["mark13"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_0c59;
								}
								goto IL_0c72;
								continue;
								end_IL_0c59:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 0;
					continue;
				}
				case 10:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0d3c:
							num3 = float.Parse(A_1.Row.Cells["mark10"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 3;
								case 2:
									A_1.Row.Cells["mark10"].FormatStyle = gridEXFormatStyle;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_0d23;
								}
								goto IL_0d3c;
								continue;
								end_IL_0d23:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 19;
					continue;
				}
				case 3:
					num4 = 20;
					flag = !(t == "3");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 28;
				case 30:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0e5a:
							num3 = float.Parse(A_1.Row.Cells["mark9"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									A_1.Row.Cells["mark9"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0e41;
								}
								goto IL_0e5a;
								continue;
								end_IL_0e41:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 10;
					continue;
				}
				case 7:
					return;
				case 22:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0f39:
							num3 = float.Parse(A_1.Row.Cells["mark7"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									A_1.Row.Cells["mark7"].FormatStyle = gridEXFormatStyle;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0f20;
								}
								goto IL_0f39;
								continue;
								end_IL_0f20:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 14;
					continue;
				}
				case 26:
					num4 = 50;
					num = 28;
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_1019:
							float num3 = float.Parse(A_1.Row.Cells["mark18"].Value.ToString());
							flag = !(num3 < (float)num2);
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
									goto case 2;
								case 0:
									A_1.Row.Cells["mark18"].FormatStyle = gridEXFormatStyle;
									num = 2;
									continue;
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_1000;
								}
								goto IL_1019;
								continue;
								end_IL_1000:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 7;
					continue;
				case 16:
					num2 = 16;
					flag = !(t == "3");
					num = 24;
					continue;
				case 24:
					{
						if (!flag)
						{
							num = 5;
							continue;
						}
						goto case 3;
					}
					IL_0938:
					flag = (byte)num6 != 0;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		Refresh();
		try
		{
			while (true)
			{
				IL_0025:
				s = asdcb.a(asdab.e(), CommandType.Text, "select id from tExam where xYear=" + this.m_j.Text + "  and term=" + t).ToString();
				string text = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + s).ToString();
				bool flag = !(text != "1");
				int num = 3;
				while (true)
				{
					switch (num)
					{
					case 3:
						if (!flag)
						{
							num = 1;
							continue;
						}
						goto case 0;
					case 1:
					{
						SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, s) };
						asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
						asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
						asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
						num = 0;
						continue;
					}
					case 0:
						d();
						this.m_g.CurrentColumn = this.m_g.GetRow(0).Cells["gTerm"].Column;
						this.m_g.Select();
						this.m_g.SelectCurrentCellText();
						num = 2;
						continue;
					case 2:
						goto end_IL_000c;
					}
					goto IL_0025;
					continue;
					end_IL_000c:
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
}
