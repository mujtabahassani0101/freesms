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

public class asdbu : Form
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

	private OpenFileDialog m;

	private Label n;

	private UIButton o;

	private Button p;

	private UIButton q;

	private Label r;

	private Panel s;

	public string t;

	public string u;

	private bool v = false;

	private int w = 0;

	private int x = 0;
protected override void Dispose(bool A_0)
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
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 2:
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

	private void d()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbu));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		r = new Label();
		p = new Button();
		q = new UIButton();
		n = new Label();
		this.m_d = new UIGroupBox();
		o = new UIButton();
		this.m_i = new Label();
		this.m_j = new Label();
		this.m_k = new EditBox();
		this.m_l = new EditBox();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		this.m_e = new Label();
		this.m_f = new UIComboBox();
		m = new OpenFileDialog();
		s = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_d.SuspendLayout();
		s.SuspendLayout();
		SuspendLayout();
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		this.m_b.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(8, 112);
		this.m_b.Name = "gridEX1";
		this.m_b.RecordNavigator = true;
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(770, 417);
		this.m_b.TabIndex = 0;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_b.Enter += e;
		this.m_b.SortKeysChanged += f;
		this.m_c.BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(r);
		this.m_c.Controls.Add(p);
		this.m_c.Controls.Add(q);
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_b);
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(6, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(788, 587);
		this.m_c.TabIndex = 0;
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		r.Font = new Font("B Nazanin", 16f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.ForeColor = Color.DarkGreen;
		r.Location = new Point(614, 50);
		r.Name = "txtDate";
		r.Size = new Size(139, 42);
		r.TabIndex = 34;
		r.TextAlign = ContentAlignment.MiddleCenter;
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		p.Location = new Point(581, 535);
		p.Name = "btnSave";
		p.Size = new Size(197, 35);
		p.TabIndex = 1;
		p.Text = "(F5) ثبت  ";
		p.UseVisualStyleBackColor = true;
		p.Click += g;
		q.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		q.DialogResult = DialogResult.Cancel;
		q.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		q.ImageSize = new Size(40, 40);
		q.Location = new Point(11, 535);
		q.Name = "btnClose";
		q.Size = new Size(189, 35);
		q.TabIndex = 2;
		q.Text = "بستن";
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.AutoSize = true;
		n.Font = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Location = new Point(670, 8);
		n.Name = "label1";
		n.Size = new Size(47, 31);
		n.TabIndex = 30;
		n.Text = "تاریخ";
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(this.m_i);
		this.m_d.Controls.Add(this.m_j);
		this.m_d.Controls.Add(this.m_k);
		this.m_d.Controls.Add(this.m_l);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Controls.Add(this.m_h);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_d.Location = new Point(11, -1);
		this.m_d.Name = "uiGroupBox1";
		this.m_d.Size = new Size(578, 107);
		this.m_d.TabIndex = 17;
		this.m_d.Text = "جستجو";
		o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		o.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		o.ImageSize = new Size(25, 25);
		o.Location = new Point(14, 22);
		o.Name = "btnNoSearch";
		o.Size = new Size(93, 71);
		o.TabIndex = 30;
		o.TabStop = false;
		o.Text = "حذف جستجو";
		o.Click += i;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(483, 66);
		this.m_i.Name = "label5";
		this.m_i.Size = new Size(84, 24);
		this.m_i.TabIndex = 29;
		this.m_i.Text = "نام خانوادگی";
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.AutoSize = true;
		this.m_j.Location = new Point(279, 66);
		this.m_j.Name = "label4";
		this.m_j.Size = new Size(26, 24);
		this.m_j.TabIndex = 28;
		this.m_j.Text = "نام";
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.AutoScroll = false;
		this.m_k.AutoScrollMargin = new Size(0, 0);
		this.m_k.AutoScrollMinSize = new Size(0, 0);
		this.m_k.AutoScrollPosition = new Point(0, 0);
		this.m_k.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_k.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_k.Location = new Point(333, 66);
		this.m_k.Name = "txtLName";
		this.m_k.RightToLeft = RightToLeft.Yes;
		this.m_k.Size = new Size(144, 27);
		this.m_k.TabIndex = 3;
		this.m_k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_k.Leave += d;
		this.m_k.KeyUp += a;
		this.m_k.Enter += c;
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.AutoScroll = false;
		this.m_l.AutoScrollMargin = new Size(0, 0);
		this.m_l.AutoScrollMinSize = new Size(0, 0);
		this.m_l.AutoScrollPosition = new Point(0, 0);
		this.m_l.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_l.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_l.Location = new Point(132, 66);
		this.m_l.Name = "txtFName";
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.Size = new Size(141, 27);
		this.m_l.TabIndex = 2;
		this.m_l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_l.Leave += a;
		this.m_l.KeyUp += c;
		this.m_l.Enter += b;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.AutoSize = true;
		this.m_g.Location = new Point(279, 28);
		this.m_g.Name = "label19";
		this.m_g.Size = new Size(42, 24);
		this.m_g.TabIndex = 25;
		this.m_g.Text = "صنف";
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_h.Location = new Point(132, 25);
		this.m_h.Name = "dropCls";
		this.m_h.Size = new Size(141, 31);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat;
		this.m_h.TabIndex = 1;
		this.m_h.SelectedIndexChanged += h;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(483, 29);
		this.m_e.Name = "label20";
		this.m_e.Size = new Size(33, 24);
		this.m_e.TabIndex = 15;
		this.m_e.Text = "پایه";
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_f.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_f.Location = new Point(333, 25);
		this.m_f.Name = "dropPaye";
		this.m_f.Size = new Size(144, 31);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		this.m_f.StringFormat = stringFormat2;
		this.m_f.TabIndex = 0;
		this.m_f.SelectedIndexChanged += j;
		m.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		m.Title = "انتخاب عکس شاگرد";
		s.BackColor = SystemColors.ActiveCaptionText;
		s.Controls.Add(this.m_c);
		s.Dock = DockStyle.Fill;
		s.Location = new Point(0, 0);
		s.Name = "panel2";
		s.Size = new Size(800, 600);
		s.TabIndex = 35;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(s);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmDisciplinaryAddAbsent";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست شاگردان";
		Load += l;
		KeyUp += b;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		s.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdbu()
	{
		d();
	}

	private void l(object A_0, EventArgs A_1)
	{
		r.Text = t;
		b();
		c();
		a();
		this.m_k.Focus();
		this.m_k.SelectAll();
		if (1 == 0)
		{
		}
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'' as  name union select id,name from tPaye order by id");
		this.m_f.DataSource = dataSource;
		this.m_f.DisplayMember = "Name";
		this.m_f.ValueMember = "id";
		this.m_f.SelectedIndex = 0;
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'' as  name union select id,name from tClass");
		this.m_h.DataSource = dataSource;
		this.m_h.DisplayMember = "Name";
		this.m_h.ValueMember = "id";
		this.m_h.SelectedIndex = 0;
	}

	private void a()
	{
		while (true)
		{
			x = w;
			string text = "";
			bool flag = this.m_h.SelectedIndex <= 0;
			int num = 19;
			while (true)
			{
				switch (num)
				{
				case 19:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 28;
				case 22:
					text += " and ";
					num = 25;
					continue;
				case 9:
					text = text + " tstudent.FName like '%" + asdaj.b(this.m_l.Text) + "%'";
					num = 16;
					continue;
				case 28:
					flag = this.m_f.SelectedIndex <= 0;
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 24;
				case 7:
					flag = !(text != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 15;
				case 13:
					text = text + " tstudent.xClass=" + this.m_h.SelectedValue.ToString();
					num = 28;
					continue;
				case 2:
					if (true)
					{
					}
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 25;
				case 15:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  0 as acp,   tmpStd.id, tmpStd.code, tmpStd.FName, tmpStd.LName, tmpStd.PName, tmpStd.Class, tmpStd.Paye\r\n    , tmpdis.comment, tmpdis.comment,cast(isnull(tmpdis.dis1,0) as bit) as dis1,cast(isnull(tmpdis.dis2,0)  as bit) as dis2,cast(isnull(tmpdis.dis3,0)  as bit) as dis3,tmpdis.xDisciplinaryCases\r\n    from\r\n    (SELECT     tStudent.id, tStudent.code, tStudent.FName, tStudent.LName, tStudent.PName,\r\n                    tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tPaye ON tStudent.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tStudent.xClass = tClass.id " + text + ")tmpStd left outer join\r\n     (SELECT     xStudent, comment, xDisciplinaryCases,\r\n\t    case xDisciplinaryCases when 1 then 1 else 0  end as  dis1 ,\r\n    \tcase xDisciplinaryCases when 2 then 1 else 0  end as  dis2 ,\r\n    \tcase xDisciplinaryCases when 3 then 1 else 0  end as  dis3\r\n    \tFROM         tDisciplinaryStudent\r\n    \tWHERE     (xDisciplinaryCases IN (1, 2, 3)) AND (DateDis = N'" + r.Text + "'))tmpdis on tmpStd.id=tmpdis.xStudent");
					this.m_b.DataSource = dataSource;
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(this.m_b.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					this.m_b.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(this.m_b.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					this.m_b.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					flag = this.m_b.RowCount <= 0;
					num = 3;
					continue;
				}
				case 3:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 14:
					text += " and ";
					num = 9;
					continue;
				case 1:
					flag = !(text != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 18;
				case 10:
					text = " where " + text;
					num = 15;
					continue;
				case 11:
					this.m_b.Row = 0;
					num = 0;
					continue;
				case 0:
					return;
				case 18:
					text = text + " tstudent.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 24;
					continue;
				case 6:
					flag = !(text != "");
					num = 29;
					continue;
				case 29:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 13;
				case 17:
					text += " and ";
					num = 18;
					continue;
				case 5:
					text += " and ";
					num = 13;
					continue;
				case 24:
					flag = !(this.m_l.Text.Trim() != "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 16;
				case 25:
					text = text + " tstudent.LName like '%" + asdaj.b(this.m_k.Text) + "%'";
					num = 7;
					continue;
				case 16:
					flag = !(this.m_k.Text.Trim() != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 7;
				case 4:
					flag = !(text != "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void j(object A_0, EventArgs A_1)
	{
		a();
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = A_1.KeyCode.ToString();
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					if (A_1.KeyCode != Keys.F5)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 2;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					return;
				case 2:
					num2 = 0;
					goto IL_00ba;
				case 1:
					num = 0;
					continue;
				case 0:
					num2 = ((!(text == "Return")) ? 1 : 0);
					goto IL_00ba;
				case 4:
					{
						if (flag)
						{
							a();
							num = 5;
						}
						else
						{
							num = 6;
						}
						continue;
					}
					IL_00ba:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_f.SelectedIndex = 0;
		this.m_h.SelectedIndex = 0;
		this.m_k.Text = "";
		this.m_l.Text = "";
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		a();
	}

	private void g(object A_0, EventArgs A_1)
	{
		bool flag4 = default;
		string text2 = default;
		while (true)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			string text = "";
			int num = 0;
			int num2 = 0;
			SqlCommand sqlCommand = null;
			SqlConnection sqlConnection = new SqlConnection(asdab.e());
			int num3 = 0;
			sqlConnection.Open();
			int num4 = 0;
			int num5 = 55;
			while (true)
			{
				int num8;
				int num6;
				int num7;
				switch (num5)
				{
				case 0:
				case 26:
					num5 = 25;
					continue;
				case 34:
					num5 = 35;
					continue;
				case 35:
					num8 = ((!flag3) ? 1 : 0);
					goto IL_03ad;
				case 39:
					if (!flag4)
					{
						num5 = 18;
						continue;
					}
					goto case 13;
				case 53:
					num5 = 56;
					continue;
				case 56:
					num6 = ((!flag3) ? 1 : 0);
					goto IL_060f;
				case 47:
				case 55:
					flag4 = num4 < this.m_b.RowCount;
					num5 = 46;
					continue;
				case 46:
					if (!flag4)
					{
						num5 = 6;
						continue;
					}
					num3 = 0;
					flag = false;
					flag2 = false;
					flag3 = false;
					text = asdaj.b(this.m_b.GetRow(num4).Cells["comment"].Text.ToString());
					flag = bool.Parse(this.m_b.GetRow(num4).Cells["dis1"].Text.ToString());
					flag2 = bool.Parse(this.m_b.GetRow(num4).Cells["dis2"].Text.ToString());
					flag3 = bool.Parse(this.m_b.GetRow(num4).Cells["dis3"].Text.ToString());
					flag4 = !flag;
					num5 = 19;
					continue;
				case 54:
					num5 = 0;
					continue;
				case 6:
					text2 = "";
					flag4 = num <= 0;
					num5 = 31;
					continue;
				case 31:
					if (!flag4)
					{
						num5 = 37;
						continue;
					}
					goto case 41;
				case 37:
					text2 = "تعداد  " + num + "  مورد ثبت شد";
					num5 = 41;
					continue;
				case 16:
					if (!flag4)
					{
						if (true)
						{
						}
						num5 = 9;
					}
					else
					{
						flag4 = !flag3;
						num5 = 12;
					}
					continue;
				case 3:
					if (flag4)
					{
						flag4 = num3 != 0;
						num5 = 39;
					}
					else
					{
						num5 = 8;
					}
					continue;
				case 51:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 43;
					continue;
				case 7:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 10;
					continue;
				case 29:
					if (flag4)
					{
						num3 = 1;
						num5 = 23;
					}
					else
					{
						num5 = 50;
					}
					continue;
				case 13:
				case 23:
				case 38:
				{
					sqlCommand = new SqlCommand("sp_tDisciplinaryStudent123_insertUpdate", sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xStudent", this.m_b.GetRow(num4).Cells["id"].Text.ToString());
					sqlCommand.Parameters.AddWithValue("@DateDis", r.Text);
					sqlCommand.Parameters.AddWithValue("@xDisciplinaryCases", num3);
					sqlCommand.Parameters.AddWithValue("@dayOfWeek", u);
					sqlCommand.Parameters.AddWithValue("@comment", text);
					int num9 = sqlCommand.ExecuteNonQuery();
					flag4 = num9 >= 1;
					num5 = 17;
					continue;
				}
				case 17:
					if (!flag4)
					{
						num5 = 54;
						continue;
					}
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "1";
					this.m_b.GetRow(num4).Cells["xDisciplinaryCases"].Value = num3;
					this.m_b.GetRow(num4).EndEdit();
					num++;
					num5 = 26;
					continue;
				case 12:
					if (flag4)
					{
						flag4 = !(text.Trim() != "");
						num5 = 3;
					}
					else
					{
						num5 = 48;
					}
					continue;
				case 44:
					num5 = 42;
					continue;
				case 42:
					num7 = ((!flag2) ? 1 : 0);
					goto IL_0755;
				case 8:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 1;
					continue;
				case 33:
				{
					object obj = text2;
					text2 = string.Concat(obj, "\nتعداد ", num2, " مورد خطا اتفاق افتاد");
					num5 = 4;
					continue;
				}
				case 48:
					num5 = 21;
					continue;
				case 21:
					num5 = (flag ? 36 : 44);
					continue;
				case 5:
					if (flag4)
					{
						num3 = 2;
						num5 = 38;
					}
					else
					{
						num5 = 51;
					}
					continue;
				case 20:
					sqlCommand = new SqlCommand("delete from tDisciplinaryStudent where xStudent=@xStudent and DateDis=@DateDis and xDisciplinaryCases in(1,2,3)", sqlConnection);
					sqlCommand.Parameters.AddWithValue("@xStudent", this.m_b.GetRow(num4).Cells["id"].Text.ToString());
					sqlCommand.Parameters.AddWithValue("@DateDis", r.Text);
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.ExecuteNonQuery();
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "1";
					this.m_b.GetRow(num4).Cells["xDisciplinaryCases"].Value = DBNull.Value;
					this.m_b.GetRow(num4).EndEdit();
					num++;
					num5 = 32;
					continue;
				case 1:
				case 10:
				case 25:
				case 27:
				case 43:
				case 52:
					num4++;
					num5 = 47;
					continue;
				case 2:
					if (flag4)
					{
						num3 = 3;
						num5 = 13;
					}
					else
					{
						num5 = 7;
					}
					continue;
				case 50:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 27;
					continue;
				case 14:
					num5 = 40;
					continue;
				case 40:
					num5 = (flag2 ? 11 : 34);
					continue;
				case 11:
					num8 = 0;
					goto IL_03ad;
				case 19:
					if (flag4)
					{
						flag4 = !flag2;
						num5 = 16;
					}
					else
					{
						num5 = 14;
					}
					continue;
				case 30:
					num6 = 0;
					goto IL_060f;
				case 18:
					flag4 = !(this.m_b.GetRow(num4).Cells["xDisciplinaryCases"].Value.ToString() != "");
					num5 = 28;
					continue;
				case 28:
					if (!flag4)
					{
						num5 = 20;
						continue;
					}
					goto case 32;
				case 41:
					flag4 = num2 <= 0;
					num5 = 15;
					continue;
				case 15:
					if (!flag4)
					{
						num5 = 33;
						continue;
					}
					goto case 4;
				case 4:
					MessageBox.Show(text2);
					flag4 = num2 != 0;
					num5 = 22;
					continue;
				case 22:
					if (!flag4)
					{
						num5 = 45;
						continue;
					}
					goto case 49;
				case 36:
					num7 = 0;
					goto IL_0755;
				case 32:
					num5 = 52;
					continue;
				case 45:
					this.m_k.SelectAll();
					this.m_k.Focus();
					num5 = 49;
					continue;
				case 9:
					num5 = 24;
					continue;
				case 24:
					num5 = ((!flag) ? 53 : 30);
					continue;
				case 49:
					{
						sqlConnection.Close();
						return;
					}
					IL_060f:
					flag4 = (byte)num6 != 0;
					num5 = 5;
					continue;
					IL_0755:
					flag4 = (byte)num7 != 0;
					num5 = 2;
					continue;
					IL_03ad:
					flag4 = (byte)num8 != 0;
					num5 = 29;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_b.RowCount <= 0;
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
					this.m_b.Row = 0;
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

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		try
		{
			while (true)
			{
				bool flag = !v;
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
						goto case 3;
					case 1:
						this.m_k.Focus();
						v = true;
						num = 3;
						continue;
					case 3:
						num = 2;
						continue;
					case 2:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F5;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto case 4;
				case 2:
					k(this, null);
					num = 0;
					continue;
				case 0:
					return;
				case 4:
					flag = A_1.KeyCode != Keys.Escape;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 1:
					this.m_b.Refresh();
					g(this, null);
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		this.m_k.BackColor = Color.White;
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_k.BackColor = Color.Yellow;
	}

	private void b(object A_0, EventArgs A_1)
	{
		this.m_l.BackColor = Color.Yellow;
	}

	private void a(object A_0, EventArgs A_1)
	{
		this.m_l.BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = A_1.KeyCode.ToString();
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (A_1.KeyCode != Keys.F5)
					{
						num = 3;
						continue;
					}
					goto IL_007f;
				case 3:
					if (true)
					{
					}
					num = 1;
					continue;
				case 0:
					num = 7;
					continue;
				case 7:
					return;
				case 9:
					num2 = 0;
					goto IL_00ed;
				case 1:
					if (A_1.KeyCode != Keys.F1)
					{
						num = 4;
						continue;
					}
					goto IL_007f;
				case 8:
					return;
				case 4:
					num = 2;
					continue;
				case 2:
					num2 = ((!(text == "Return")) ? 1 : 0);
					goto IL_00ed;
				case 5:
					{
						if (flag)
						{
							a();
							num = 8;
						}
						else
						{
							num = 0;
						}
						continue;
					}
					IL_007f:
					num = 9;
					continue;
					IL_00ed:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}
}
