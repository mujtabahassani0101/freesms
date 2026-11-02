using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected Obj, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected Obj, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdp));
		StringFormat val = new StringFormat();
		GridEXLayout val2 = new GridEXLayout();
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
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(700, 671);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_c).BackColor = Color.Black;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel2";
		((Control)this.m_c).Size = new Size(698, 669);
		((Control)this.m_c).TabIndex = 44;
		((Control)this.m_d).BackColor = Color.FromArgb(214, 223, 247);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)n);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)e);
		((Control)this.m_d).Controls.Add((Control)(object)f);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Location = new Point(3, 3);
		((Control)this.m_d).Name = "panel3";
		((Control)this.m_d).Size = new Size(692, 663);
		((Control)this.m_d).TabIndex = 0;
		o.BorderStyle = (BorderStyle)1;
		((Control)o).Location = new Point(217, 42);
		((Control)o).Name = "lcountDay";
		((Control)o).Size = new Size(59, 24);
		((Control)o).TabIndex = 122;
		((Control)n).AutoSize = true;
		((Control)n).Location = new Point(285, 41);
		((Control)n).Name = "label1";
		((Control)n).Size = new Size(62, 26);
		((Control)n).TabIndex = 121;
		((Control)n).Text = "تعداد روز";
		((Control)m).Anchor = (AnchorStyles)10;
		m.ButtonStyle = (ButtonStyle)1;
		((Control)m).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		m.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		m.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		m.ImageIndex = 8;
		((Control)m).Location = new Point(529, 620);
		((Control)m).Name = "btnAcp";
		((Control)m).RightToLeft = (RightToLeft)1;
		((Control)m).Size = new Size(153, 40);
		((Control)m).TabIndex = 120;
		((Control)m).Text = "ثبت (F5)";
		m.VisualStyle = (VisualStyle)1;
		((Control)m).Click += a;
		l.BorderStyle = (BorderStyle)1;
		((Control)l).Location = new Point(428, 8);
		((Control)l).Name = "lterm";
		((Control)l).Size = new Size(144, 24);
		((Control)l).TabIndex = 119;
		j.BorderStyle = (BorderStyle)1;
		((Control)j).Location = new Point(217, 9);
		((Control)j).Name = "lYear";
		((Control)j).Size = new Size(59, 24);
		((Control)j).TabIndex = 118;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(282, 9);
		((Control)k).Name = "label3";
		((Control)k).Size = new Size(78, 26);
		((Control)k).TabIndex = 117;
		((Control)k).Text = "سال تعلیمی\r\n";
		((Control)h).Anchor = (AnchorStyles)9;
		((UIComboBase)h).ComboStyle = (ComboStyle)1;
		((UIComboBase)h).DropListFont = new Font("B Nazanin", 12f);
		((Control)h).Location = new Point(430, 37);
		((Control)h).Name = "dropCls";
		((Control)h).Size = new Size(142, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)h).StringFormat = val;
		((Control)h).TabIndex = 52;
		h.SelectedIndexChanged += b;
		((Control)i).Anchor = (AnchorStyles)9;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(578, 43);
		((Control)i).Name = "label19";
		((Control)i).Size = new Size(41, 26);
		((Control)i).TabIndex = 51;
		((Control)i).Text = "صنف";
		((Control)e).AutoSize = true;
		((Control)e).Font = new Font("B Nazanin", 14f);
		((Control)e).Location = new Point(577, 5);
		((Control)e).Name = "label7";
		((Control)e).Size = new Size(105, 28);
		((Control)e).TabIndex = 50;
		((Control)e).Text = "وضعیت حاضری";
		((Control)f).Anchor = (AnchorStyles)6;
		f.DialogResult = (DialogResult)2;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		((Control)f).Location = new Point(11, 623);
		((Control)f).Name = "btnClose";
		((Control)f).Size = new Size(93, 35);
		((Control)f).TabIndex = 44;
		((Control)f).Text = "بستن";
		((Control)f).Click += c;
		((Control)g).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		g.DesignTimeLayout = val2;
		g.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		g.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)g).Font = new Font("Tahoma", 9.75f);
		g.GroupByBoxVisible = false;
		((Control)g).Location = new Point(8, 76);
		((Control)g).Name = "gridEX1";
		((ScrollableBase)g).RecordNavigator = true;
		g.RowHeaders = (InheritableBoolean)1;
		g.SelectedFormatStyle.BackColor = Color.Empty;
		g.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)g).Size = new Size(676, 540);
		((Control)g).TabIndex = 45;
		((ScrollableBase)g).VisualStyle = (VisualStyle)2;
		g.CellUpdated += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(700, 671);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmHazeri";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره";
		((Form)this).Load += d;
		((Control)this).KeyUp += a;
		((Form)this).FormClosing += a;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((ISupportInitialize)g).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asdp()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		c();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)l).Text = "سالانه";
					num = 1;
					continue;
				case 12:
					((Control)l).Text = "چهار و نیم ماهه";
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
						((Control)g).Select();
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
					((Control)j).Text = asdaj.a;
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
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + ((Control)j).Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
		h.DataSource = dataSource;
		h.DisplayMember = "Name";
		h.ValueMember = "id";
	}

	private void a()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    0 as acp,  tYear_Student.id, tYear_Student.sort, tYear_Student.hazer" + q + " as hazer, tYear_Student.Ghayeb" + q + " as Ghayeb, tYear_Student.Mariz" + q + " as Mariz, tYear_Student.rokhsat" + q + " as rokhsat,  tStudent.FName+ ' '+ tStudent.LName as Fullname,  tStudent.NumberAsas\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE   tYear_Student.shaghe=1 and  (tYear_Student.xYear = " + ((Control)j).Text + ") AND (tYear_Student.xClass = " + h.SelectedValue.ToString() + ")");
			g.DataSource = dataSource;
			GridEXFormatCondition val = new GridEXFormatCondition(g.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
			val.FormatStyle.ForeColor = SystemColors.WindowText;
			val.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
			g.RootTable.FormatConditions.Add(val);
			GridEXFormatCondition val2 = new GridEXFormatCondition(g.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
			val2.FormatStyle.ForeColor = SystemColors.WindowText;
			val2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
			g.RootTable.FormatConditions.Add(val2);
			((Control)o).Text = "";
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
									((Control)o).Text = asdcb.a(asdab.e(), CommandType.Text, "SELECT " + text + "\r\n                FROM         tYearMaghtaCountDay INNER JOIN\r\n                      tPaye ON tYearMaghtaCountDay.xMaghta = tPaye.xMaghta INNER JOIN\r\n                      tClass ON tPaye.id = tClass.xpaye\r\n                WHERE     (tClass.id = " + h.SelectedValue.ToString() + ") AND (tYearMaghtaCountDay.xYear = " + asdaj.a + ")").ToString();
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
					flag = !(((Control)o).Text == "");
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
		((Form)this).Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
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
						num7 = int.Parse(((Control)o).Text);
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
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between I4 and Unknown
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
						((Control)g).Select();
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
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
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
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)g).Refresh();
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
						num2 = int.Parse(((Control)o).Text);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 116;
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
					((Control)g).Refresh();
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
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between I4 and Unknown
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
					((CancelEventArgs)(object)A_1).Cancel = true;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
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
