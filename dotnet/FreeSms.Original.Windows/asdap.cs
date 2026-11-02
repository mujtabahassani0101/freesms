using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using FreeSms.Reporting;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using school_Af.Rpt.chart;

public class asdap : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private UIButton m_c;

	private UIButton m_d;

	private GridEX m_e;

	private GridEX m_f;

	private Label g;

	private UIComboBox h;

	private Label i;

	private Label j;

	private UIComboBox k;

	private string l = "0";
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
						num = 2;
					}
					else
					{
						num = 4;
					}
					continue;
				case 2:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 6;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 6;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 6:
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

	private void e()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdap));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		GridEXLayout gridEXLayout3 = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
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
		this.m_e = new GridEX();
		this.m_f = new GridEX();
		g = new Label();
		h = new UIComboBox();
		i = new Label();
		j = new Label();
		k = new UIComboBox();
		((ISupportInitialize)this.m_b).BeginInit();
		((ISupportInitialize)this.m_e).BeginInit();
		((ISupportInitialize)this.m_f).BeginInit();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(212, 52);
		this.m_b.Name = "gridEX1";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(456, 514);
		this.m_b.TabIndex = 0;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_b.SelectionChanged += b;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_c.Location = new Point(117, 517);
		this.m_c.Name = "btnview";
		this.m_c.Size = new Size(86, 49);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "نمایش گزارش";
		this.m_c.Click += e;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		this.m_d.Location = new Point(6, 517);
		this.m_d.Name = "btnClose";
		this.m_d.Size = new Size(105, 49);
		this.m_d.TabIndex = 110;
		this.m_d.Text = "بستن";
		this.m_d.Click += d;
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_e.DesignTimeLayout = gridEXLayout2;
		this.m_e.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_e.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_e.GroupByBoxVisible = false;
		this.m_e.Location = new Point(4, 301);
		this.m_e.Name = "gClass";
		this.m_e.RowHeaders = InheritableBoolean.True;
		this.m_e.Size = new Size(193, 210);
		this.m_e.TabIndex = 107;
		this.m_e.VisualStyle = VisualStyle.Office2003;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_f.DesignTimeLayout = gridEXLayout3;
		this.m_f.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_f.Font = new Font("Tahoma", 8.25f);
		this.m_f.GroupByBoxVisible = false;
		this.m_f.Location = new Point(11, 52);
		this.m_f.Name = "gExam";
		this.m_f.RowHeaders = InheritableBoolean.True;
		this.m_f.Size = new Size(188, 213);
		this.m_f.TabIndex = 111;
		this.m_f.VisualStyle = VisualStyle.Office2003;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.AutoSize = true;
		g.Location = new Point(174, 279);
		g.Name = "label20";
		g.Size = new Size(22, 13);
		g.TabIndex = 123;
		g.Text = "پایه";
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		h.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		h.Font = new Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		h.Location = new Point(4, 275);
		h.Name = "dropPaye";
		h.Size = new Size(164, 20);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat;
		h.TabIndex = 122;
		h.SelectedIndexChanged += c;
		i.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(238, 9);
		i.Name = "lCountExam";
		i.Size = new Size(414, 29);
		i.TabIndex = 124;
		i.Text = "گزارش انتخابی  برای مقایسه دوره ها  بوده و میتوانید چند دوره را انتخاب کنید";
		i.TextAlign = ContentAlignment.MiddleLeft;
		j.AutoSize = true;
		j.Location = new Point(118, 15);
		j.Name = "label8";
		j.Size = new Size(66, 13);
		j.TabIndex = 138;
		j.Text = "سال تعلیمی";
		k.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		k.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
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
		k.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		k.Location = new Point(15, 9);
		k.Name = "dropYear";
		k.Size = new Size(97, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		k.StringFormat = stringFormat2;
		k.TabIndex = 139;
		k.SelectedIndexChanged += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(676, 578);
		Controls.Add(k);
		Controls.Add(j);
		Controls.Add(i);
		Controls.Add(g);
		Controls.Add(h);
		Controls.Add(this.m_f);
		Controls.Add(this.m_d);
		Controls.Add(this.m_e);
		Controls.Add(this.m_c);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRptChart";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "گزارشات نموداری";
		Load += f;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)this.m_e).EndInit();
		((ISupportInitialize)this.m_f).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public asdap()
	{
		e();
	}

	private void f(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("4");
			int num = 0;
			while (true)
			{
				DataTable dataSource;
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					OriginalSchoolYears.Select(k, asdaj.__field_a);
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 1:
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
					num = 2;
					continue;
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto IL_0135;
				case 5:
					return;
				case 6:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 7;
					continue;
				case 7:
					return;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0135;
				case 4:
					{
						num = 1;
						continue;
					}
					IL_0135:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select tRptChart.*,case countExam when 0 then 'نا محدود' else cast(countExam as nvarchar(2)) end as countTest from tRptChart");
					this.m_b.DataSource = dataSource;
					d();
					c();
					b();
					num = 5;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tExam where xYear=" + k.SelectedValue.ToString() + " order by NumExam desc");
		this.m_f.DataSource = dataSource;
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			h.Items.Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + k.SelectedValue.ToString() + ") order by id");
			h.Items.Add("کل", "0");
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 2;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					h.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 3;
					continue;
				case 0:
					if (true)
					{
					}
					h.SelectedIndex = 0;
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
			bool flag = h.SelectedIndex <= 0;
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
					text = text + " and xPaye=" + h.SelectedValue.ToString();
					num = 2;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + k.SelectedValue.ToString() + text);
					this.m_e.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void a()
	{
		string text2 = default;
		int value = default;
		bool flag = default;
		string text4 = default;
		string[] array = default;
		int num3 = default;
		string text3 = default;
		SqlParameter[] a_ = default;
		ReportClass reportClass = default;
		string value2 = default;
		DataTable dataSource = default;
		while (true)
		{
			string text = "";
			int num = 0;
			int num2 = 6;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 65:
					num2 = 45;
					continue;
				case 45:
					if (asdbg.a.TryGetValue(text2, out value))
					{
						num2 = 41;
						continue;
					}
					goto case 2;
				case 48:
					MessageBox.Show("صنفی انتخاب نشده است");
					num2 = 0;
					continue;
				case 0:
					return;
				case 2:
				case 9:
				case 14:
				case 16:
				case 22:
				case 28:
				case 32:
				case 35:
				case 38:
				case 44:
				case 52:
				case 67:
					flag = !(text4 != "");
					num2 = 13;
					continue;
				case 13:
					if (!flag)
					{
						num2 = 63;
						continue;
					}
					goto case 3;
				case 60:
					text += ",";
					num2 = 40;
					continue;
				case 43:
					num2 = 3;
					continue;
				case 10:
					asdbg.a = new Dictionary<string, int>(11)
					{
						{ "CrChartAvgClassBooks_1", 0 },
						{ "CrChartAvgClassBooks_2", 1 },
						{ "CrChartAvgClassBooks_3", 2 },
						{ "CrChartAvgClassDorehBooks", 3 },
						{ "CrChartAvgOneClassBooks_1", 4 },
						{ "CrChartAvgOneClassBooks_2", 5 },
						{ "CrChartAvgPayeBooks_1", 6 },
						{ "CrChartAvgPayeBooks_2", 7 },
						{ "CrChartAvgStdClassBooks_1", 8 },
						{ "CrChartAvgStdClassBooks_2", 9 },
						{ "CrChartAvgClassDorehBooksTch", 10 }
					};
					num2 = 65;
					continue;
				case 8:
					if (!flag)
					{
						num2 = 31;
						continue;
					}
					goto case 50;
				case 71:
					flag = array.Length <= 3;
					num2 = 29;
					continue;
				case 29:
					if (!flag)
					{
						num2 = 46;
						continue;
					}
					goto case 43;
				case 1:
					num2 = ((num3 <= 1) ? 27 : 30);
					continue;
				case 19:
					if (!flag)
					{
						num2 = 56;
						continue;
					}
					flag = !(this.m_e.GetRow(num).Cells["Selector"].Value.ToString() == "True");
					num2 = 15;
					continue;
				case 36:
					flag = !(text == "");
					num2 = 37;
					continue;
				case 37:
					if (!flag)
					{
						num2 = 48;
						continue;
					}
					text3 = "";
					num3 = 0;
					num = 0;
					num2 = 55;
					continue;
				case 17:
				case 34:
					num++;
					num2 = 54;
					continue;
				case 54:
					if (1 == 0)
					{
					}
					goto case 6;
				case 31:
					num3++;
					flag = !(text3 != "");
					num2 = 26;
					continue;
				case 26:
					if (!flag)
					{
						num2 = 64;
						continue;
					}
					goto case 69;
				case 46:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_);
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource2);
					num2 = 43;
					continue;
				}
				case 20:
					flag = !(text3 == "");
					num2 = 58;
					continue;
				case 58:
					num2 = (flag ? 1 : 62);
					continue;
				case 62:
					MessageBox.Show("دوره ای انتخاب نشده است");
					num2 = 66;
					continue;
				case 66:
					return;
				case 61:
				{
					SqlParameter[] a_2 = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, this.m_f.GetRow(num).Cells["id"].Value.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_2);
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_2);
					asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_2);
					num2 = 51;
					continue;
				}
				case 69:
				{
					text3 += this.m_f.GetRow(num).Cells["id"].Value.ToString();
					string text6 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + this.m_f.GetRow(num).Cells["id"].Value.ToString()).ToString();
					flag = !(text6 != "1");
					num2 = 47;
					continue;
				}
				case 47:
					if (!flag)
					{
						num2 = 61;
						continue;
					}
					goto case 51;
				case 64:
					text3 += ",";
					num2 = 69;
					continue;
				case 51:
					num2 = 50;
					continue;
				case 68:
					num2 = 70;
					continue;
				case 70:
					if (asdbg.a == null)
					{
						num2 = 10;
						continue;
					}
					goto case 65;
				case 56:
					flag = !(text != "");
					num2 = 21;
					continue;
				case 21:
					if (!flag)
					{
						num2 = 73;
						continue;
					}
					goto case 23;
				case 42:
					MessageBox.Show("برای نمایش این گزارش تنها باید یک دوره انتخاب شود");
					num2 = 53;
					continue;
				case 53:
					return;
				case 5:
				case 55:
					flag = num < this.m_f.RowCount;
					num2 = 33;
					continue;
				case 33:
					if (flag)
					{
						flag = !(this.m_f.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 8;
					}
					else
					{
						num2 = 20;
					}
					continue;
				case 30:
					num2 = 59;
					continue;
				case 59:
					num4 = ((!(this.m_b.SelectedItems[0].GetRow().Cells["countExam"].Value.ToString() == "1")) ? 1 : 0);
					goto IL_0a3f;
				case 4:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_);
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource2);
					num2 = 71;
					continue;
				}
				case 49:
					flag = !(text != "");
					num2 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 60;
						continue;
					}
					goto case 40;
				case 73:
					text += ",";
					num2 = 23;
					continue;
				case 24:
				{
					try
					{
						reportClass.ParameterFields[0].CurrentValues.AddValue(value2);
						reportClass.ParameterFields[1].CurrentValues.AddValue("");
						reportClass.ParameterFields[2].CurrentValues.AddValue("");
						reportClass.ParameterFields[3].CurrentValues.AddValue("");
						reportClass.ParameterFields[4].CurrentValues.AddValue("");
					}
					catch
					{
					}
					asda asda10 = new asda();
					asda10.__field_a = reportClass;
					asda10.ShowDialog();
					num2 = 72;
					continue;
				}
				case 50:
					num++;
					num2 = 5;
					continue;
				case 40:
					text += this.m_e.GetRow(num).Cells["id"].Value.ToString();
					num2 = 17;
					continue;
				case 15:
					if (!flag)
					{
						num2 = 49;
						continue;
					}
					goto case 17;
				case 27:
					num4 = 1;
					goto IL_0a3f;
				case 7:
				{
					if (!flag)
					{
						num2 = 42;
						continue;
					}
					string text5 = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
					text4 = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
					a_ = new SqlParameter[3]
					{
						asdcb.a("@Exam", SqlDbType.VarChar, text3),
						asdcb.a("@Class", SqlDbType.VarChar, text),
						asdcb.a("@xYear", SqlDbType.Int, k.SelectedValue.ToString())
					};
					dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString(), a_);
					reportClass = null;
					value2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT  sch FROM  tParmetr").ToString();
					text2 = text5;
					num2 = 18;
					continue;
				}
				case 3:
					reportClass.SetDataSource(dataSource);
					num2 = 24;
					continue;
				case 63:
					array = text4.Split(',');
					flag = array.Length <= 1;
					num2 = 57;
					continue;
				case 57:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					goto case 71;
				case 6:
					flag = num < this.m_e.RowCount;
					num2 = 39;
					continue;
				case 39:
					if (flag)
					{
						flag = !(l != "1");
						num2 = 19;
					}
					else
					{
						num2 = 36;
					}
					continue;
				case 25:
					num2 = 44;
					continue;
				case 18:
					if (text2 != null)
					{
						num2 = 68;
						continue;
					}
					goto case 2;
				case 23:
					text += this.m_e.GetRow(num).Cells["id"].Value.ToString();
					num2 = 34;
					continue;
				case 72:
					return;
				case 41:
					num2 = 12;
					continue;
				case 12:
					{
						switch (value)
						{
						case 4:
							reportClass = new CrChartAvgOneClassBooks_1();
							num2 = 32;
							break;
						case 3:
							reportClass = new CrChartAvgClassDorehBooks();
							num2 = 16;
							break;
						case 8:
							reportClass = new CrChartAvgStdClassBooks_1();
							num2 = 35;
							break;
						case 0:
							reportClass = new CrChartAvgClassBooks_1();
							num2 = 14;
							break;
						case 10:
							reportClass = new CrChartAvgClassDorehBooksTch();
							num2 = 9;
							break;
						case 7:
							reportClass = new CrChartAvgPayeBooks_2();
							num2 = 28;
							break;
						case 9:
							reportClass = new CrChartAvgStdClassBooks_2();
							num2 = 67;
							break;
						case 2:
							reportClass = new CrChartAvgClassBooks_3();
							num2 = 38;
							break;
						case 6:
							reportClass = new CrChartAvgPayeBooks_1();
							num2 = 2;
							break;
						case 5:
							reportClass = new CrChartAvgOneClassBooks_2();
							num2 = 52;
							break;
						case 1:
							reportClass = new CrChartAvgClassBooks_2();
							num2 = 22;
							break;
						default:
							num2 = 25;
							break;
						}
						continue;
					}
					IL_0a3f:
					flag = (byte)num4 != 0;
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		a();
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		b();
	}

	private void b(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 0:
					this.m_e.Visible = true;
					num = 3;
					continue;
				case 3:
					return;
				case 4:
					if (!flag)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						this.m_e.Visible = false;
						num = 2;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_00c3:
							num = 9;
							while (true)
							{
								int num2;
								switch (num)
								{
								case 9:
									num = ((this.m_b.RowCount > 0) ? 1 : 4);
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
									goto IL_0113;
								case 10:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 2;
								case 4:
									num2 = 1;
									goto IL_0113;
								case 3:
									l = this.m_b.SelectedItems[0].GetRow().Cells["class"].Value.ToString();
									flag = !(this.m_b.SelectedItems[0].GetRow().Cells["countExam"].Value.ToString() == "1");
									num = 11;
									continue;
								case 11:
									if (!flag)
									{
										num = 5;
										continue;
									}
									i.Text = "گزارش انتخابی  برای مقایسه دوره ها  بوده و میتوانید چند دوره را انتخاب کنید";
									i.ForeColor = Color.DarkRed;
									num = 6;
									continue;
								case 6:
								case 7:
									num = 2;
									continue;
								case 5:
									i.Text = "برای گزارش انتخابی تنها یک دوره قابل انتخاب است";
									i.ForeColor = Color.Black;
									num = 7;
									continue;
								case 2:
									num = 8;
									continue;
								case 8:
									goto end_IL_008a;
									IL_0113:
									flag = (byte)num2 != 0;
									num = 10;
									continue;
								}
								goto IL_00c3;
								continue;
								end_IL_008a:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					flag = !(l == "1");
					num = 4;
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
		if (true)
		{
		}
		d();
		c();
		b();
	}
}
