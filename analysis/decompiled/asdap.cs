using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected Obj, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected Obj, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdap));
		GridEXLayout val2 = new GridEXLayout();
		GridEXLayout val3 = new GridEXLayout();
		StringFormat val4 = new StringFormat();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		UIComboBoxItem val10 = new UIComboBoxItem();
		StringFormat val11 = new StringFormat();
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
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(212, 52);
		((Control)this.m_b).Name = "gridEX1";
		((Control)this.m_b).RightToLeft = (RightToLeft)1;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(456, 514);
		((Control)this.m_b).TabIndex = 0;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		this.m_b.SelectionChanged += b;
		((Control)this.m_c).Anchor = (AnchorStyles)10;
		((Control)this.m_c).Location = new Point(117, 517);
		((Control)this.m_c).Name = "btnview";
		((Control)this.m_c).Size = new Size(86, 49);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "نمایش گزارش";
		((Control)this.m_c).Click += e;
		((Control)this.m_d).Anchor = (AnchorStyles)6;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		((Control)this.m_d).Location = new Point(6, 517);
		((Control)this.m_d).Name = "btnClose";
		((Control)this.m_d).Size = new Size(105, 49);
		((Control)this.m_d).TabIndex = 110;
		((Control)this.m_d).Text = "بستن";
		((Control)this.m_d).Click += d;
		((Control)this.m_e).Anchor = (AnchorStyles)10;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_e.DesignTimeLayout = val2;
		this.m_e.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		this.m_e.GroupByBoxVisible = false;
		((Control)this.m_e).Location = new Point(4, 301);
		((Control)this.m_e).Name = "gClass";
		this.m_e.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_e).Size = new Size(193, 210);
		((Control)this.m_e).TabIndex = 107;
		((ScrollableBase)this.m_e).VisualStyle = (VisualStyle)2;
		((Control)this.m_f).Anchor = (AnchorStyles)15;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_f.DesignTimeLayout = val3;
		this.m_f.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f);
		this.m_f.GroupByBoxVisible = false;
		((Control)this.m_f).Location = new Point(11, 52);
		((Control)this.m_f).Name = "gExam";
		this.m_f.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_f).Size = new Size(188, 213);
		((Control)this.m_f).TabIndex = 111;
		((ScrollableBase)this.m_f).VisualStyle = (VisualStyle)2;
		((Control)g).Anchor = (AnchorStyles)9;
		((Control)g).AutoSize = true;
		((Control)g).Location = new Point(174, 279);
		((Control)g).Name = "label20";
		((Control)g).Size = new Size(22, 13);
		((Control)g).TabIndex = 123;
		((Control)g).Text = "پایه";
		((Control)h).Anchor = (AnchorStyles)9;
		((UIComboBase)h).ComboStyle = (ComboStyle)1;
		((UIComboBase)h).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)h).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)h).Location = new Point(4, 275);
		((Control)h).Name = "dropPaye";
		((Control)h).Size = new Size(164, 20);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)h).StringFormat = val4;
		((Control)h).TabIndex = 122;
		h.SelectedIndexChanged += c;
		((Control)i).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(238, 9);
		((Control)i).Name = "lCountExam";
		((Control)i).Size = new Size(414, 29);
		((Control)i).TabIndex = 124;
		((Control)i).Text = "گزارش انتخابی  برای مقایسه دوره ها  بوده و میتوانید چند دوره را انتخاب کنید";
		i.TextAlign = (ContentAlignment)16;
		((Control)j).AutoSize = true;
		((Control)j).Location = new Point(118, 15);
		((Control)j).Name = "label8";
		((Control)j).Size = new Size(66, 13);
		((Control)j).TabIndex = 138;
		((Control)j).Text = "سال تعلیمی";
		((UIComboBase)k).ComboStyle = (ComboStyle)1;
		((UIComboBase)k).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1403";
		val5.Value = "1403";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1402";
		val6.Value = "1402";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1401";
		val7.Value = "1401";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "1400";
		val8.Value = "1400";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "1399";
		val9.Value = "1399";
		val10.FormatStyle.Alpha = 0;
		val10.Text = "1398";
		val10.Value = "1398";
		k.Items.AddRange(new UIComboBoxItem[6] { val5, val6, val7, val8, val9, val10 });
		((Control)k).Location = new Point(15, 9);
		((Control)k).Name = "dropYear";
		((Control)k).Size = new Size(97, 23);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)k).StringFormat = val11;
		((Control)k).TabIndex = 139;
		k.SelectedIndexChanged += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(676, 578);
		((Control)this).Controls.Add((Control)(object)k);
		((Control)this).Controls.Add((Control)(object)j);
		((Control)this).Controls.Add((Control)(object)i);
		((Control)this).Controls.Add((Control)(object)g);
		((Control)this).Controls.Add((Control)(object)h);
		((Control)this).Controls.Add((Control)(object)this.m_f);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmRptChart";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "گزارشات نموداری";
		((Form)this).Load += f;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)this.m_e).EndInit();
		((ISupportInitialize)this.m_f).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public asdap()
	{
		e();
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
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
					k.SelectedValue = asdaj.a;
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
						((Control)this).BackColor = Color.FromArgb(red, green, blue);
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
			((CollectionBase)(object)h.Items).Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + k.SelectedValue.ToString() + ") order by id");
			h.Items.Add("کل", (object)"0");
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
					h.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
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
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		string text2 = default;
		int value = default;
		bool flag = default;
		string text4 = default;
		string[] array = default;
		int num3 = default;
		string text3 = default;
		SqlParameter[] a_ = default;
		ReportClass val = default;
		string text6 = default;
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
					((ReportDocument)val).Subreports[array[2].ToString()].SetDataSource(dataSource2);
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
					string text7 = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + this.m_f.GetRow(num).Cells["id"].Value.ToString()).ToString();
					flag = !(text7 != "1");
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
					((ReportDocument)val).Subreports[array[0].ToString()].SetDataSource(dataSource2);
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
						((ReportDocument)val).ParameterFields[0].CurrentValues.AddValue((object)text6);
						((ReportDocument)val).ParameterFields[1].CurrentValues.AddValue((object)"");
						((ReportDocument)val).ParameterFields[2].CurrentValues.AddValue((object)"");
						((ReportDocument)val).ParameterFields[3].CurrentValues.AddValue((object)"");
						((ReportDocument)val).ParameterFields[4].CurrentValues.AddValue((object)"");
					}
					catch
					{
					}
					asda asda10 = new asda();
					asda10.a = val;
					((Form)asda10).ShowDialog();
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
					val = null;
					text6 = asdcb.a(asdab.e(), CommandType.Text, "SELECT  sch FROM  tParmetr").ToString();
					text2 = text5;
					num2 = 18;
					continue;
				}
				case 3:
					((ReportDocument)val).SetDataSource(dataSource);
					num2 = 24;
					continue;
				case 63:
					array = text4.Split(new char[1] { ',' });
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
							val = (ReportClass)(object)new CrChartAvgOneClassBooks_1();
							num2 = 32;
							break;
						case 3:
							val = (ReportClass)(object)new CrChartAvgClassDorehBooks();
							num2 = 16;
							break;
						case 8:
							val = (ReportClass)(object)new CrChartAvgStdClassBooks_1();
							num2 = 35;
							break;
						case 0:
							val = (ReportClass)(object)new CrChartAvgClassBooks_1();
							num2 = 14;
							break;
						case 10:
							val = (ReportClass)(object)new CrChartAvgClassDorehBooksTch();
							num2 = 9;
							break;
						case 7:
							val = (ReportClass)(object)new CrChartAvgPayeBooks_2();
							num2 = 28;
							break;
						case 9:
							val = (ReportClass)(object)new CrChartAvgStdClassBooks_2();
							num2 = 67;
							break;
						case 2:
							val = (ReportClass)(object)new CrChartAvgClassBooks_3();
							num2 = 38;
							break;
						case 6:
							val = (ReportClass)(object)new CrChartAvgPayeBooks_1();
							num2 = 2;
							break;
						case 5:
							val = (ReportClass)(object)new CrChartAvgOneClassBooks_2();
							num2 = 52;
							break;
						case 1:
							val = (ReportClass)(object)new CrChartAvgClassBooks_2();
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
		((Form)this).Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		b();
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 0:
					((Control)this.m_e).Visible = true;
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
						((Control)this.m_e).Visible = false;
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
									num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
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
									((Control)i).Text = "گزارش انتخابی  برای مقایسه دوره ها  بوده و میتوانید چند دوره را انتخاب کنید";
									((Control)i).ForeColor = Color.DarkRed;
									num = 6;
									continue;
								case 6:
								case 7:
									num = 2;
									continue;
								case 5:
									((Control)i).Text = "برای گزارش انتخابی تنها یک دوره قابل انتخاب است";
									((Control)i).ForeColor = Color.Black;
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
