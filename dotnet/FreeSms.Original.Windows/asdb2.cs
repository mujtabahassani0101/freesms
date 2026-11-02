using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using school_Af.Rpt.af;

public class asdb2 : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private UIButton m_c;

	private UIButton m_d;

	private Label m_e;

	private UIComboBox f;

	private GridEX g;

	private Label h;

	private UIComboBox i;

	private EditBox j;

	private EditBox k;

	private EditBox l;

	private EditBox m;

	private EditBox n;

	private Label o;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (A_0)
					{
						if (true)
						{
						}
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				case 6:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 0;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 3;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb2));
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
		i = new UIComboBox();
		j = new EditBox();
		k = new EditBox();
		l = new EditBox();
		m = new EditBox();
		n = new EditBox();
		o = new Label();
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
		this.m_b.Size = new Size(548, 428);
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
		i.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		i.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
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
		i.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		i.Location = new Point(12, 26);
		i.Name = "dropYear";
		i.Size = new Size(97, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		i.StringFormat = stringFormat2;
		i.TabIndex = 135;
		i.SelectedIndexChanged += a;
		j.AutoScroll = false;
		j.AutoScrollMargin = new Size(0, 0);
		j.AutoScrollMinSize = new Size(0, 0);
		j.AutoScrollPosition = new Point(0, 0);
		j.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.Location = new Point(439, 455);
		j.MaxLength = 300;
		j.Name = "txtHeder1";
		j.Size = new Size(247, 28);
		j.TabIndex = 141;
		j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		k.AutoScroll = false;
		k.AutoScrollMargin = new Size(0, 0);
		k.AutoScrollMinSize = new Size(0, 0);
		k.AutoScrollPosition = new Point(0, 0);
		k.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		k.Location = new Point(185, 534);
		k.MaxLength = 300;
		k.Name = "txtFoter1";
		k.Size = new Size(15, 28);
		k.TabIndex = 138;
		k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		k.Visible = false;
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new Point(0, 0);
		l.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Location = new Point(212, 522);
		l.MaxLength = 300;
		l.Name = "txtSch";
		l.Size = new Size(14, 28);
		l.TabIndex = 137;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		l.Visible = false;
		m.AutoScroll = false;
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.AutoScrollPosition = new Point(0, 0);
		m.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Location = new Point(164, 497);
		m.MaxLength = 300;
		m.Name = "txtFoter2";
		m.Size = new Size(15, 28);
		m.TabIndex = 144;
		m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.Visible = false;
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(164, 532);
		n.MaxLength = 300;
		n.Name = "txtHeder2";
		n.Size = new Size(15, 28);
		n.TabIndex = 143;
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		n.Visible = false;
		o.AutoSize = true;
		o.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(692, 460);
		o.Name = "label3";
		o.Size = new Size(71, 20);
		o.TabIndex = 145;
		o.Text = "بالای گزارش :";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(792, 566);
		Controls.Add(o);
		Controls.Add(this.m_d);
		Controls.Add(this.m_c);
		Controls.Add(m);
		Controls.Add(n);
		Controls.Add(j);
		Controls.Add(k);
		Controls.Add(l);
		Controls.Add(h);
		Controls.Add(i);
		Controls.Add(this.m_e);
		Controls.Add(f);
		Controls.Add(g);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRptAFLsit";
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

	public asdb2()
	{
		d();
	}

	private void e(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		DataTable dataSource = default;
		while (true)
		{
			bool flag = asdaj.a("2");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 7;
				case 1:
					k.Text = dataSource.Rows[0]["Foter1"].ToString();
					m.Text = dataSource.Rows[0]["Foter2"].ToString();
					j.Text = dataSource.Rows[0]["heder1"].ToString();
					n.Text = dataSource.Rows[0]["heder2"].ToString();
					l.Text = dataSource.Rows[0]["sch"].ToString();
					k.Tag = dataSource.Rows[0]["Foter1"].ToString();
					m.Tag = dataSource.Rows[0]["Foter2"].ToString();
					j.Tag = dataSource.Rows[0]["heder1"].ToString();
					n.Tag = dataSource.Rows[0]["heder2"].ToString();
					l.Tag = dataSource.Rows[0]["sch"].ToString();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 8;
					continue;
				case 8:
					return;
				case 7:
					i.SelectedValue = asdaj.__field_a;
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptAFLsit");
					this.m_b.DataSource = dataSource;
					c();
					b();
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tParmetr");
					flag = dataSource.Rows.Count <= 0;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 3:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 9:
					num = 3;
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
			f.Items.Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where  id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + i.SelectedValue.ToString() + ") order by id");
			f.Items.Add("کل", "0");
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
					f.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 0;
					continue;
				case 2:
					if (true)
					{
					}
					f.SelectedIndex = 0;
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
			if (true)
			{
			}
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
						num = 2;
						continue;
					}
					goto case 1;
				case 2:
					text = text + " and xPaye=" + f.SelectedValue.ToString();
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + i.SelectedValue.ToString() + text);
					g.DataSource = dataSource;
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
		SqlParameter[] a_ = default;
		DataTable dataSource = default;
		ReportClass reportClass = default;
		string text4 = default;
		string[] array = default;
		int value = default;
		while (true)
		{
			string text = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text2 = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			string text3 = "";
			int num = 0;
			int num2 = 18;
			while (true)
			{
				switch (num2)
				{
				case 8:
					flag = !(text3 == "");
					num2 = 6;
					continue;
				case 6:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					a_ = new SqlParameter[2]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text3),
						asdcb.a("@xYear", SqlDbType.Int, i.SelectedValue.ToString())
					};
					dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString(), a_);
					reportClass = null;
					text4 = text;
					num2 = 23;
					continue;
				case 33:
					flag = array.Length <= 3;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 32;
						continue;
					}
					goto case 14;
				case 28:
					num++;
					num2 = 11;
					continue;
				case 15:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_);
					reportClass.Subreports[array[4].ToString()].SetDataSource(dataSource2);
					num2 = 9;
					continue;
				}
				case 23:
					if (text4 != null)
					{
						num2 = 34;
						continue;
					}
					goto case 5;
				case 34:
					if (true)
					{
					}
					num2 = 45;
					continue;
				case 32:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_);
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource2);
					num2 = 14;
					continue;
				}
				case 7:
				{
					reportClass.SetDataSource(dataSource);
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					num2 = 22;
					continue;
				}
				case 22:
					return;
				case 35:
					num2 = 46;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 17;
						continue;
					}
					goto case 28;
				case 16:
					MessageBox.Show("صنفی انتخاب نشده است");
					num2 = 25;
					continue;
				case 25:
					return;
				case 11:
				case 18:
					flag = num < g.RowCount;
					num2 = 26;
					continue;
				case 26:
					if (flag)
					{
						flag = !(g.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 2;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 39:
					asdbg.c = new Dictionary<string, int>(11)
					{
						{ "CrChapShaghe", 0 },
						{ "CrChapShaghe2", 1 },
						{ "CrChapShagheHzeri", 2 },
						{ "CrChapShagheHzeri2", 3 },
						{ "CrListStdshaghe", 4 },
						{ "CrListStdKoll", 5 },
						{ "CrListStdMali", 6 },
						{ "CrListStdHazer", 7 },
						{ "CrListStdTransport", 8 },
						{ "CrListStdTransportDriver", 9 },
						{ "CrStdCard", 10 }
					};
					num2 = 4;
					continue;
				case 14:
					flag = array.Length <= 5;
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					goto case 9;
				case 5:
				case 12:
				case 13:
				case 21:
				case 24:
				case 29:
				case 31:
				case 38:
				case 41:
				case 42:
				case 43:
				case 46:
					flag = !(text2 != "");
					num2 = 20;
					continue;
				case 20:
					if (!flag)
					{
						num2 = 44;
						continue;
					}
					goto case 7;
				case 10:
					num2 = 37;
					continue;
				case 37:
					switch (value)
					{
					case 9:
						reportClass = new CrListStdTransportDriver();
						num2 = 12;
						break;
					case 4:
						reportClass = new CrListStdshaghe();
						num2 = 21;
						break;
					case 8:
						reportClass = new CrListStdTransport();
						num2 = 13;
						break;
					case 5:
						reportClass = new CrListStdKoll();
						num2 = 5;
						break;
					case 0:
						reportClass = new CrChapShaghe();
						num2 = 43;
						break;
					default:
						num2 = 35;
						break;
					case 7:
						reportClass = new CrListStdHazer();
						num2 = 38;
						break;
					case 1:
						reportClass = new CrChapShaghe2();
						num2 = 31;
						break;
					case 6:
						reportClass = new CrListStdMali();
						num2 = 24;
						break;
					case 10:
						reportClass = new CrStdCard();
						num2 = 42;
						break;
					case 3:
						reportClass = new CrChapShagheHzeri2();
						num2 = 29;
						break;
					case 2:
						reportClass = new CrChapShagheHzeri();
						num2 = 41;
						break;
					}
					continue;
				case 4:
					num2 = 27;
					continue;
				case 27:
					if (asdbg.c.TryGetValue(text4, out value))
					{
						num2 = 10;
						continue;
					}
					goto case 5;
				case 0:
					text3 += g.GetRow(num).Cells["id"].Value.ToString();
					num2 = 28;
					continue;
				case 36:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_);
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource2);
					num2 = 33;
					continue;
				}
				case 45:
					if (asdbg.c == null)
					{
						num2 = 39;
						continue;
					}
					goto case 4;
				case 30:
					text3 += ",";
					num2 = 0;
					continue;
				case 17:
					flag = !(text3 != "");
					num2 = 19;
					continue;
				case 19:
					if (!flag)
					{
						num2 = 30;
						continue;
					}
					goto case 0;
				case 9:
					num2 = 7;
					continue;
				case 44:
					array = text2.Split(',');
					flag = array.Length <= 1;
					num2 = 40;
					continue;
				case 40:
					if (!flag)
					{
						num2 = 36;
						continue;
					}
					goto case 33;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = asdab.p >= int.Parse(i.SelectedValue.ToString());
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
					flag = asdab.p != int.Parse(i.SelectedValue.ToString());
					num = 4;
					continue;
				case 10:
					flag = !(j.Text != j.Tag.ToString());
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 11;
				case 4:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 10;
				case 11:
					a();
					num = 0;
					continue;
				case 0:
					return;
				case 7:
					if (true)
					{
					}
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 6;
					continue;
				case 6:
					return;
				case 3:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@heder1", SqlDbType.NVarChar, j.Text) };
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE [dbo].[tParmetr]  SET [heder1] =@heder1", a_);
					num = 11;
					continue;
				}
				case 2:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 9;
					continue;
				case 9:
					return;
				case 8:
					flag = !(asdab.q != asdab.n);
					num = 5;
					continue;
				case 5:
					num = ((!flag) ? 2 : 10);
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
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		c();
		b();
	}
}
