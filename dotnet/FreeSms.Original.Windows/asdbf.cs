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
using school_Af.Rpt.afPayment;

public class asdbf : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private UIButton m_c;

	private UIButton m_d;

	private Label m_e;

	private UIComboBox f;

	private GridEX g;

	private Label h;

	private EditBox i;

	private EditBox j;

	private EditBox k;

	private EditBox l;

	private EditBox m;

	private UIComboBox n;

	public asdbf()
	{
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		DataTable dataSource = default;
		while (true)
		{
			bool flag = asdaj.a("10");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 9;
				case 4:
					j.Text = dataSource.Rows[0]["Foter1"].ToString();
					l.Text = dataSource.Rows[0]["Foter2"].ToString();
					i.Text = dataSource.Rows[0]["heder1"].ToString();
					m.Text = dataSource.Rows[0]["heder2"].ToString();
					k.Text = dataSource.Rows[0]["sch"].ToString();
					j.Tag = dataSource.Rows[0]["Foter1"].ToString();
					l.Tag = dataSource.Rows[0]["Foter2"].ToString();
					i.Tag = dataSource.Rows[0]["heder1"].ToString();
					m.Tag = dataSource.Rows[0]["heder2"].ToString();
					k.Tag = dataSource.Rows[0]["sch"].ToString();
					num = 8;
					continue;
				case 8:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 9:
					OriginalSchoolYears.Select(n, asdaj.__field_a);
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptPayment");
					this.m_b.DataSource = dataSource;
					d();
					c();
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tParmetr");
					flag = dataSource.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 0:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 9;
					continue;
				case 2:
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			f.Items.Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + n.SelectedValue.ToString() + ") order by id");
			f.Items.Add("کل", "0");
			int num = 0;
			if (true)
			{
			}
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 3;
						continue;
					}
					f.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 3:
					f.SelectedIndex = 0;
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
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = f.SelectedIndex <= 0;
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
					goto case 2;
				case 1:
					text = text + " and xPaye=" + f.SelectedValue.ToString();
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + n.SelectedValue.ToString() + text);
					g.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		string[] array = default;
		bool flag = default;
		SqlParameter[] a_ = default;
		ReportClass reportClass = default;
		DataTable dataSource = default;
		string text4 = default;
		while (true)
		{
			string text = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text2 = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			string text3 = "";
			int num = 0;
			int num2 = 24;
			while (true)
			{
				switch (num2)
				{
				case 18:
					array = text2.Split(',');
					flag = array.Length <= 1;
					num2 = 33;
					continue;
				case 33:
					if (!flag)
					{
						num2 = 30;
						continue;
					}
					goto case 12;
				case 26:
					num++;
					num2 = 2;
					continue;
				case 35:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_);
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource2);
					num2 = 32;
					continue;
				}
				case 22:
					text3 += ",";
					num2 = 37;
					continue;
				case 7:
				case 19:
				case 20:
				case 29:
					flag = !(text2 != "");
					num2 = 25;
					continue;
				case 25:
					if (!flag)
					{
						num2 = 18;
						continue;
					}
					goto case 13;
				case 27:
					num2 = 13;
					continue;
				case 5:
					num2 = 29;
					continue;
				case 9:
					flag = !(text3 == "");
					num2 = 15;
					continue;
				case 15:
					if (!flag)
					{
						num2 = 17;
						continue;
					}
					a_ = new SqlParameter[2]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text3),
						asdcb.a("@xYear", SqlDbType.Int, n.SelectedValue.ToString())
					};
					dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString(), a_);
					reportClass = null;
					text4 = text;
					num2 = 36;
					continue;
				case 32:
					flag = array.Length <= 5;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 21;
						continue;
					}
					goto case 27;
				case 13:
				{
					reportClass.SetDataSource(dataSource);
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					num2 = 16;
					continue;
				}
				case 16:
					return;
				case 4:
					num2 = 31;
					continue;
				case 31:
					if (text4 == "CrRptPayment1")
					{
						reportClass = new CrRptPayment1();
						num2 = 7;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 28:
					if (!flag)
					{
						num2 = 23;
						continue;
					}
					goto case 26;
				case 2:
				case 24:
					flag = num < g.RowCount;
					num2 = 10;
					continue;
				case 10:
					if (flag)
					{
						flag = !(g.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 28;
					}
					else
					{
						num2 = 9;
					}
					continue;
				case 37:
					text3 += g.GetRow(num).Cells["id"].Value.ToString();
					num2 = 26;
					continue;
				case 36:
					if (text4 != null)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 21:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_);
					reportClass.Subreports[array[4].ToString()].SetDataSource(dataSource2);
					num2 = 27;
					continue;
				}
				case 30:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_);
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource2);
					num2 = 12;
					continue;
				}
				case 8:
					num2 = 3;
					continue;
				case 3:
					if (!(text4 == "CrRptSumPaymentGroupByClass"))
					{
						num2 = 6;
						continue;
					}
					reportClass = new CrRptSumPaymentGroupByClass();
					num2 = 19;
					continue;
				case 6:
					num2 = 34;
					continue;
				case 34:
					if (!(text4 == "CrRptSumPaymentKoll"))
					{
						num2 = 5;
						continue;
					}
					reportClass = new CrRptSumPaymentKoll();
					num2 = 20;
					continue;
				case 17:
					MessageBox.Show("صنفی انتخاب نشده است");
					if (true)
					{
					}
					num2 = 14;
					continue;
				case 14:
					return;
				case 23:
					flag = !(text3 != "");
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 22;
						continue;
					}
					goto case 37;
				case 12:
					flag = array.Length <= 3;
					num2 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 35;
						continue;
					}
					goto case 32;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = asdab.p >= int.Parse(n.SelectedValue.ToString());
			int num = 16;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 16:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = asdab.p != int.Parse(n.SelectedValue.ToString());
					num = 9;
					continue;
				case 19:
					num = 10;
					continue;
				case 10:
					num2 = ((!(k.Text != k.Tag.ToString())) ? 1 : 0);
					goto IL_0166;
				case 8:
					num = 4;
					continue;
				case 4:
					if (!(i.Text != i.Tag.ToString()))
					{
						num = 15;
						continue;
					}
					goto IL_01d5;
				case 20:
					flag = !(asdab.q != asdab.n);
					num = 18;
					continue;
				case 18:
					num = (flag ? 21 : 0);
					continue;
				case 13:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 7;
				case 9:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 21;
				case 12:
					num2 = 0;
					goto IL_0166;
				case 7:
					b();
					num = 22;
					continue;
				case 22:
					return;
				case 5:
					num = 11;
					continue;
				case 11:
					if (!(l.Text != l.Tag.ToString()))
					{
						num = 8;
						continue;
					}
					goto IL_01d5;
				case 0:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 17;
					continue;
				case 17:
					if (1 == 0)
					{
					}
					return;
				case 6:
				{
					SqlParameter[] a_ = new SqlParameter[5]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, i.Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, m.Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, j.Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, l.Text),
						asdcb.a("@sch", SqlDbType.NVarChar, k.Text)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_);
					num = 7;
					continue;
				}
				case 15:
					num = 14;
					continue;
				case 14:
					if (!(m.Text != m.Tag.ToString()))
					{
						num = 19;
						continue;
					}
					goto IL_01d5;
				case 1:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 2;
					continue;
				case 2:
					return;
				case 21:
					num = 3;
					continue;
				case 3:
					{
						if (!(j.Text != j.Tag.ToString()))
						{
							num = 5;
							continue;
						}
						goto IL_01d5;
					}
					IL_01d5:
					num = 12;
					continue;
					IL_0166:
					flag = (byte)num2 != 0;
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		c();
	}

	private void a(object A_0, EventArgs A_1)
	{
		d();
		c();
	}
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
						num = 0;
					}
					else
					{
						num = 4;
					}
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
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
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbf));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat2 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new Label();
		f = new UIComboBox();
		g = new GridEX();
		h = new Label();
		i = new EditBox();
		j = new EditBox();
		k = new EditBox();
		l = new EditBox();
		m = new EditBox();
		n = new UIComboBox();
		((ISupportInitialize)this.m_b).BeginInit();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(232, 18);
		this.m_b.Name = "gridEX1";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(548, 538);
		this.m_b.TabIndex = 0;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Location = new Point(12, 460);
		this.m_c.Name = "btnview";
		this.m_c.Size = new Size(193, 50);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "نمایش گزارش";
		this.m_c.Click += d;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		this.m_d.Location = new Point(12, 516);
		this.m_d.Name = "btnClose";
		this.m_d.Size = new Size(193, 42);
		this.m_d.TabIndex = 110;
		this.m_d.Text = "بستن";
		this.m_d.Click += c;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(181, 58);
		this.m_e.Name = "label20";
		this.m_e.Size = new Size(22, 13);
		this.m_e.TabIndex = 126;
		this.m_e.Text = "پایه";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		f.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		f.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		f.Location = new Point(12, 55);
		f.Name = "dropPaye";
		f.Size = new Size(164, 20);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		f.StringFormat = stringFormat;
		f.TabIndex = 125;
		f.SelectedIndexChanged += b;
		g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		g.DesignTimeLayout = gridEXLayout2;
		g.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		g.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold);
		g.GroupByBoxVisible = false;
		g.Location = new Point(12, 90);
		g.Name = "gClass";
		g.RowHeaders = InheritableBoolean.True;
		g.Size = new Size(193, 356);
		g.TabIndex = 124;
		g.VisualStyle = VisualStyle.Office2003;
		h.AutoSize = true;
		h.Location = new Point(116, 32);
		h.Name = "label8";
		h.Size = new Size(66, 13);
		h.TabIndex = 136;
		h.Text = "سال تعلیمی";
		i.AutoScroll = false;
		i.AutoScrollMargin = new Size(0, 0);
		i.AutoScrollMinSize = new Size(0, 0);
		i.AutoScrollPosition = new Point(0, 0);
		i.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(200, 489);
		i.MaxLength = 300;
		i.Name = "txtHeder1";
		i.Size = new Size(26, 28);
		i.TabIndex = 141;
		i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		i.Visible = false;
		j.AutoScroll = false;
		j.AutoScrollMargin = new Size(0, 0);
		j.AutoScrollMinSize = new Size(0, 0);
		j.AutoScrollPosition = new Point(0, 0);
		j.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.Location = new Point(185, 534);
		j.MaxLength = 300;
		j.Name = "txtFoter1";
		j.Size = new Size(15, 28);
		j.TabIndex = 138;
		j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		j.Visible = false;
		k.AutoScroll = false;
		k.AutoScrollMargin = new Size(0, 0);
		k.AutoScrollMinSize = new Size(0, 0);
		k.AutoScrollPosition = new Point(0, 0);
		k.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		k.Location = new Point(212, 522);
		k.MaxLength = 300;
		k.Name = "txtSch";
		k.Size = new Size(14, 28);
		k.TabIndex = 137;
		k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		k.Visible = false;
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new Point(0, 0);
		l.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Location = new Point(164, 497);
		l.MaxLength = 300;
		l.Name = "txtFoter2";
		l.Size = new Size(15, 28);
		l.TabIndex = 144;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		l.Visible = false;
		m.AutoScroll = false;
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.AutoScrollPosition = new Point(0, 0);
		m.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Location = new Point(164, 532);
		m.MaxLength = 300;
		m.Name = "txtHeder2";
		m.Size = new Size(15, 28);
		m.TabIndex = 143;
		m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.Visible = false;
		n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		n.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
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
		n.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		n.Location = new Point(12, 26);
		n.Name = "dropYear";
		n.Size = new Size(97, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		n.StringFormat = stringFormat2;
		n.TabIndex = 149;
		n.SelectedIndexChanged += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(792, 566);
		Controls.Add(n);
		Controls.Add(this.m_d);
		Controls.Add(this.m_c);
		Controls.Add(l);
		Controls.Add(m);
		Controls.Add(i);
		Controls.Add(j);
		Controls.Add(k);
		Controls.Add(h);
		Controls.Add(this.m_e);
		Controls.Add(f);
		Controls.Add(g);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRptPayment";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "گزارش";
		Load += e;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
