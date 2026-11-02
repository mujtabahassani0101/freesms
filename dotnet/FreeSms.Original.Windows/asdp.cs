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

public class asdp : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private Label e;

	private UIButton f;

	private GridEX g;

	private UIComboBox h;

	private Label i;

	private Label j;

	private Label k;

	private Label l;

	private UIButton m;

	private Label n;

	private Label o;

	private SqlConnection p = new SqlConnection(asdab.e());

	public string q;

	private bool r;

	private int s;

	private bool t = false;
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
						num = 0;
					}
					continue;
				case 2:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdp));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		o = new Label();
		n = new Label();
		m = new UIButton();
		l = new Label();
		j = new Label();
		k = new Label();
		h = new UIComboBox();
		i = new Label();
		e = new Label();
		f = new UIButton();
		g = new GridEX();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(700, 671);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(698, 669);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(e);
		this.m_d.Controls.Add(f);
		this.m_d.Controls.Add(g);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(692, 663);
		this.m_d.TabIndex = 0;
		o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		o.Location = new Point(217, 42);
		o.Name = "lcountDay";
		o.Size = new Size(59, 24);
		o.TabIndex = 122;
		n.AutoSize = true;
		n.Location = new Point(285, 41);
		n.Name = "label1";
		n.Size = new Size(62, 26);
		n.TabIndex = 121;
		n.Text = "تعداد روز";
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		m.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		m.ImageIndex = 8;
		m.Location = new Point(529, 620);
		m.Name = "btnAcp";
		m.RightToLeft = RightToLeft.Yes;
		m.Size = new Size(153, 40);
		m.TabIndex = 120;
		m.Text = "ثبت (F5)";
		m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		m.Click += a;
		l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		l.Location = new Point(428, 8);
		l.Name = "lterm";
		l.Size = new Size(144, 24);
		l.TabIndex = 119;
		j.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		j.Location = new Point(217, 9);
		j.Name = "lYear";
		j.Size = new Size(59, 24);
		j.TabIndex = 118;
		k.AutoSize = true;
		k.Location = new Point(282, 9);
		k.Name = "label3";
		k.Size = new Size(78, 26);
		k.TabIndex = 117;
		k.Text = "سال تعلیمی\r\n";
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		h.DropListFont = new Font("B Nazanin", 12f);
		h.Location = new Point(430, 37);
		h.Name = "dropCls";
		h.Size = new Size(142, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat;
		h.TabIndex = 52;
		h.SelectedIndexChanged += b;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoSize = true;
		i.Location = new Point(578, 43);
		i.Name = "label19";
		i.Size = new Size(41, 26);
		i.TabIndex = 51;
		i.Text = "صنف";
		e.AutoSize = true;
		e.Font = new Font("B Nazanin", 14f);
		e.Location = new Point(577, 5);
		e.Name = "label7";
		e.Size = new Size(105, 28);
		e.TabIndex = 50;
		e.Text = "وضعیت حاضری";
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		f.DialogResult = DialogResult.Cancel;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		f.Location = new Point(11, 623);
		f.Name = "btnClose";
		f.Size = new Size(93, 35);
		f.TabIndex = 44;
		f.Text = "بستن";
		f.Click += c;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		g.DesignTimeLayout = gridEXLayout;
		g.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		g.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		g.Font = new Font("Tahoma", 9.75f);
		g.GroupByBoxVisible = false;
		g.Location = new Point(8, 76);
		g.Name = "gridEX1";
		g.RecordNavigator = true;
		g.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		g.SelectedFormatStyle.BackColor = Color.Empty;
		g.SelectedFormatStyle.ForeColor = Color.Empty;
		g.Size = new Size(676, 540);
		g.TabIndex = 45;
		g.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		g.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(700, 671);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmHazeri";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += d;
		KeyUp += a;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdp()
	{
		c();
	}

	private void d(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 10;
					continue;
				case 13:
					l.Text = "سالانه";
					num = 1;
					continue;
				case 12:
					l.Text = "چهار و نیم ماهه";
					num = 8;
					continue;
				case 7:
					num = 3;
					continue;
				case 11:
					try
					{
						h.SelectedIndex = 0;
						a();
						g.CurrentColumn = g.GetRow(0).Cells["ghayeb"].Column;
						g.Select();
						g.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 4;
					continue;
				case 10:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 5;
				case 1:
				case 8:
					j.Text = asdaj.__field_a;
					b();
					num = 11;
					continue;
				case 4:
					return;
				case 5:
					r = true;
					flag = !(q == "1");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(q == "2");
					num = 6;
					continue;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						if (true)
						{
						}
						num = 13;
						continue;
					}
					goto case 1;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 14;
					continue;
				case 14:
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + j.Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
		h.DataSource = dataSource;
		h.DisplayMember = "Name";
		h.ValueMember = "id";
	}

	private void a()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    0 as acp,  tYear_Student.id, tYear_Student.sort, tYear_Student.hazer" + q + " as hazer, tYear_Student.Ghayeb" + q + " as Ghayeb, tYear_Student.Mariz" + q + " as Mariz, tYear_Student.rokhsat" + q + " as rokhsat,  tStudent.FName+ ' '+ tStudent.LName as Fullname,  tStudent.NumberAsas\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE   tYear_Student.shaghe=1 and  (tYear_Student.xYear = " + j.Text + ") AND (tYear_Student.xClass = " + h.SelectedValue.ToString() + ")");
			g.DataSource = dataSource;
			GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(g.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
			gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
			gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
			g.RootTable.FormatConditions.Add(gridEXFormatCondition);
			GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(g.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
			gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
			gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
			g.RootTable.FormatConditions.Add(gridEXFormatCondition2);
			o.Text = "";
			int num = 0;
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
					return;
				case 0:
					try
					{
						while (true)
						{
							IL_0222:
							string text = " ISNULL(tYearMaghtaCountDay.Term1, 0) + ISNULL(tYearMaghtaCountDay.Term2, 0) AS term3 ";
							flag = !(q == "1");
							if (true)
							{
							}
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
									text = " tYearMaghtaCountDay.Term1 AS term1";
									num = 2;
									continue;
								case 2:
									o.Text = asdcb.a(asdab.e(), CommandType.Text, "SELECT " + text + "\r\n                FROM         tYearMaghtaCountDay INNER JOIN\r\n                      tPaye ON tYearMaghtaCountDay.xMaghta = tPaye.xMaghta INNER JOIN\r\n                      tClass ON tPaye.id = tClass.xpaye\r\n                WHERE     (tClass.id = " + h.SelectedValue.ToString() + ") AND (tYearMaghtaCountDay.xYear = " + asdaj.__field_a + ")").ToString();
									num = 1;
									continue;
								case 1:
									goto end_IL_0209;
								}
								goto IL_0222;
								continue;
								end_IL_0209:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					flag = !(o.Text == "");
					num = 3;
					continue;
				case 1:
					MessageBox.Show("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید");
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		int num7 = default;
		int num4 = default;
		int num5 = default;
		int num2 = default;
		bool flag = default;
		while (true)
		{
			r = false;
			int num = 6;
			while (true)
			{
				int num8;
				switch (num)
				{
				case 6:
					if (!(A_1.Column.Key == "ghayeb"))
					{
						num = 2;
						continue;
					}
					goto IL_0119;
				case 9:
				{
					try
					{
						num7 = int.Parse(o.Text);
					}
					catch
					{
						MessageBox.Show("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید");
						return;
					}
					int num6 = 0;
					num4 = 0;
					num5 = 0;
					num2 = 0;
					int num3 = 0;
					num = 8;
					continue;
				}
				case 11:
					try
					{
						if (true)
						{
						}
						num5 = int.Parse(g.GetRow(g.Row).Cells["Mariz"].Value.ToString());
					}
					catch
					{
					}
					num = 10;
					continue;
				case 4:
					num7 = 0;
					num = 9;
					continue;
				case 1:
					num8 = 0;
					goto IL_012a;
				case 12:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 0:
					num = 5;
					continue;
				case 5:
					num8 = ((!(A_1.Column.Key == "rokhsat")) ? 1 : 0);
					goto IL_012a;
				case 2:
					num = 3;
					continue;
				case 3:
					if (!(A_1.Column.Key == "Mariz"))
					{
						num = 0;
						continue;
					}
					goto IL_0119;
				case 7:
					return;
				case 8:
					try
					{
						num4 = int.Parse(g.GetRow(g.Row).Cells["Ghayeb"].Value.ToString());
					}
					catch
					{
					}
					num = 11;
					continue;
				case 10:
					{
						try
						{
							num2 = int.Parse(g.GetRow(g.Row).Cells["rokhsat"].Value.ToString());
						}
						catch
						{
						}
						int num3 = num4 + num5 + num2;
						int num6 = num7 - num3;
						g.GetRow(g.Row).BeginEdit();
						g.GetRow(g.Row).Cells["hazer"].Value = num6;
						g.GetRow(g.Row).Cells["Ghayeb"].Value = num4;
						g.GetRow(g.Row).Cells["Mariz"].Value = num5;
						g.GetRow(g.Row).Cells["rokhsat"].Value = num2;
						g.GetRow(g.Row).EndEdit();
						num = 7;
						continue;
					}
					IL_0119:
					num = 1;
					continue;
					IL_012a:
					flag = (byte)num8 != 0;
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = r;
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
					goto case 10;
				case 7:
					try
					{
						g.CurrentColumn = g.GetRow(0).Cells["ghayeb"].Column;
						g.Select();
						g.SelectCurrentCellText();
					}
					catch
					{
					}
					s = h.SelectedIndex;
					num = 2;
					continue;
				case 8:
					t = false;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					flag = !t;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 6;
					continue;
				case 10:
					t = false;
					r = true;
					a();
					num = 7;
					continue;
				case 2:
					return;
				case 4:
					t = true;
					h.SelectedIndex = s;
					num = 9;
					continue;
				case 9:
					return;
				case 6:
					if (flag)
					{
						if (true)
						{
						}
						num = 10;
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

	private void a(object A_0, EventArgs A_1)
	{
		int num4 = default;
		bool flag = default;
		int num8 = default;
		int num9 = default;
		int num10 = default;
		int num6 = default;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			if (true)
			{
			}
			int num3 = 6;
			while (true)
			{
				int num7;
				int num11;
				switch (num3)
				{
				case 3:
					g.GetRow(num4).BeginEdit();
					g.GetRow(num4).Cells["acp"].Value = "1";
					g.GetRow(num4).EndEdit();
					num++;
					num3 = 16;
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_0120:
							flag = !(g.GetRow(num4).Cells["hazer"].Text != "");
							num3 = 2;
							while (true)
							{
								int num14;
								switch (num3)
								{
								case 2:
									if (!flag)
									{
										num3 = 11;
										continue;
									}
									num8 = 0;
									num3 = 10;
									continue;
								case 1:
									num3 = 8;
									continue;
								case 8:
									num14 = ((num8 <= num2) ? 1 : 0);
									goto IL_0252;
								case 6:
									num14 = 0;
									goto IL_0252;
								case 11:
									num8 = int.Parse(g.GetRow(num4).Cells["hazer"].Text.ToString());
									num3 = 9;
									continue;
								case 9:
									num3 = ((num8 >= 0) ? 1 : 6);
									continue;
								case 3:
									g.GetRow(num4).Cells["acp"].Value = "-1";
									g.GetRow(num4).EndEdit();
									num3 = 4;
									continue;
								case 4:
									goto end_IL_00e7;
								case 0:
									num3 = ((!flag) ? 3 : 7);
									continue;
								case 7:
								case 10:
									num3 = 5;
									continue;
								case 5:
									goto IL_054d;
									IL_0252:
									flag = (byte)num14 != 0;
									num3 = 0;
									continue;
								}
								goto IL_0120;
								continue;
								end_IL_00e7:
								break;
							}
							break;
						}
					}
					catch
					{
						g.GetRow(num4).BeginEdit();
						g.GetRow(num4).Cells["acp"].Value = "-1";
						g.GetRow(num4).EndEdit();
					}
					goto case 1;
				case 12:
				case 14:
					flag = num4 < g.RowCount;
					num3 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num3 = 10;
						continue;
					}
					num8 = 0;
					num9 = 0;
					num10 = 0;
					num6 = 0;
					num7 = 0;
					num3 = 4;
					continue;
				case 9:
					num3 = (flag ? 1 : 3);
					continue;
				case 5:
					MessageBox.Show("تعداد " + num + " ردیف انجام شد");
					num3 = 8;
					continue;
				case 10:
					g.Refresh();
					flag = num <= 0;
					num3 = 13;
					continue;
				case 13:
					if (!flag)
					{
						num3 = 5;
						continue;
					}
					goto case 8;
				case 8:
					r = true;
					num3 = 11;
					continue;
				case 11:
					return;
				case 6:
					try
					{
						num2 = int.Parse(o.Text);
					}
					catch
					{
						MessageBox.Show("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید");
						return;
					}
					num8 = 0;
					num9 = 0;
					num10 = 0;
					num6 = 0;
					num7 = 0;
					num4 = 0;
					num3 = 14;
					continue;
				case 7:
					try
					{
						while (true)
						{
							IL_0599:
							flag = !(g.GetRow(num4).Cells["Ghayeb"].Text != "");
							num3 = 6;
							while (true)
							{
								int num13;
								switch (num3)
								{
								case 6:
									if (!flag)
									{
										num3 = 1;
										continue;
									}
									num9 = 0;
									num3 = 11;
									continue;
								case 3:
									num13 = 0;
									goto IL_0692;
								case 2:
									num3 = 10;
									continue;
								case 10:
									num13 = ((num9 <= num2) ? 1 : 0);
									goto IL_0692;
								case 1:
									num9 = int.Parse(g.GetRow(num4).Cells["Ghayeb"].Text.ToString());
									num3 = 8;
									continue;
								case 8:
									num3 = ((num9 >= 0) ? 2 : 3);
									continue;
								case 4:
									num3 = (flag ? 5 : 0);
									continue;
								case 0:
									g.GetRow(num4).Cells["acp"].Value = "-1";
									g.GetRow(num4).EndEdit();
									num3 = 9;
									continue;
								case 9:
									goto end_IL_0560;
								case 5:
								case 11:
									num3 = 7;
									continue;
								case 7:
									goto IL_0786;
									IL_0692:
									flag = (byte)num13 != 0;
									num3 = 4;
									continue;
								}
								goto IL_0599;
								continue;
								end_IL_0560:
								break;
							}
							break;
						}
					}
					catch
					{
						g.GetRow(num4).BeginEdit();
						g.GetRow(num4).Cells["acp"].Value = "-1";
						g.GetRow(num4).EndEdit();
					}
					goto case 1;
				case 1:
				case 16:
					num4++;
					num3 = 12;
					continue;
				case 15:
					try
					{
						while (true)
						{
							IL_07d2:
							flag = !(g.GetRow(num4).Cells["Mariz"].Text != "");
							num3 = 8;
							while (true)
							{
								int num12;
								switch (num3)
								{
								case 4:
									goto end_IL_0799;
								case 8:
									if (!flag)
									{
										num3 = 5;
										continue;
									}
									num10 = 0;
									num3 = 7;
									continue;
								case 0:
									num3 = 10;
									continue;
								case 10:
									num12 = ((num10 <= num2) ? 1 : 0);
									goto IL_08b3;
								case 5:
									num10 = int.Parse(g.GetRow(num4).Cells["Mariz"].Text.ToString());
									num3 = 9;
									continue;
								case 9:
									num3 = ((num10 < 0) ? 1 : 0);
									continue;
								case 1:
									num12 = 0;
									goto IL_08b3;
								case 3:
									num3 = ((!flag) ? 2 : 6);
									continue;
								case 2:
									g.GetRow(num4).Cells["acp"].Value = "-1";
									g.GetRow(num4).EndEdit();
									num3 = 11;
									continue;
								case 11:
									goto end_IL_0797;
								case 6:
								case 7:
									{
										num3 = 4;
										continue;
									}
									IL_08b3:
									flag = (byte)num12 != 0;
									num3 = 3;
									continue;
								}
								goto IL_07d2;
								continue;
								end_IL_0799:
								break;
							}
							break;
						}
						goto IL_00d1;
						end_IL_0797:;
					}
					catch
					{
						g.GetRow(num4).BeginEdit();
						g.GetRow(num4).Cells["acp"].Value = "-1";
						g.GetRow(num4).EndEdit();
					}
					goto case 1;
				case 2:
					{
						try
						{
							while (true)
							{
								IL_09e7:
								flag = !(g.GetRow(num4).Cells["rokhsat"].Text != "");
								num3 = 1;
								while (true)
								{
									int num5;
									switch (num3)
									{
									case 2:
										goto end_IL_09a2;
									case 1:
										if (!flag)
										{
											num3 = 12;
											continue;
										}
										num6 = 0;
										num3 = 5;
										continue;
									case 7:
										num3 = 11;
										continue;
									case 14:
										g.GetRow(num4).Cells["acp"].Value = "-1";
										g.GetRow(num4).EndEdit();
										num3 = 4;
										continue;
									case 4:
										goto end_IL_09a0;
									case 12:
										flag = !(g.GetRow(num4).Cells["rokhsat"].Text != "");
										num3 = 13;
										continue;
									case 13:
										if (!flag)
										{
											num3 = 0;
											continue;
										}
										goto case 7;
									case 3:
										num5 = 0;
										goto IL_0b81;
									case 0:
										num6 = int.Parse(g.GetRow(num4).Cells["rokhsat"].Text.ToString());
										num3 = 9;
										continue;
									case 9:
										num3 = ((num6 >= 0) ? 6 : 3);
										continue;
									case 8:
										num3 = ((!flag) ? 14 : 7);
										continue;
									case 6:
										num3 = 10;
										continue;
									case 10:
										num5 = ((num6 <= num2) ? 1 : 0);
										goto IL_0b81;
									case 5:
									case 11:
										{
											num3 = 2;
											continue;
										}
										IL_0b81:
										flag = (byte)num5 != 0;
										num3 = 8;
										continue;
									}
									goto IL_09e7;
									continue;
									end_IL_09a2:
									break;
								}
								break;
							}
							goto IL_0350;
							end_IL_09a0:;
						}
						catch
						{
							g.GetRow(num4).BeginEdit();
							g.GetRow(num4).Cells["acp"].Value = "-1";
							g.GetRow(num4).EndEdit();
						}
						goto case 1;
					}
					IL_0350:
					num7 = num8 + num9 + num10 + num6;
					num11 = asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set hazer" + q + "=" + num8 + " ,Ghayeb" + q + "=" + num9 + " ,Mariz" + q + "=" + num10 + " ,rokhsat" + q + "=" + num6 + " where id=" + g.GetRow(num4).Cells["id"].Value.ToString());
					flag = num11 <= 0;
					num3 = 9;
					continue;
					IL_00d1:
					num3 = 2;
					continue;
					IL_0786:
					num3 = 15;
					continue;
					IL_054d:
					num3 = 7;
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
			bool flag = A_1.KeyCode != Keys.F5;
			if (true)
			{
			}
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
					g.Refresh();
					a((object)this, (EventArgs)null);
					num = 2;
					continue;
				case 2:
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
			bool flag = r;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 0:
					return;
				case 4:
					A_1.Cancel = true;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 1;
					continue;
				case 1:
					num = ((!flag) ? 4 : 0);
					continue;
				}
				break;
			}
		}
	}
}
