using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Microsoft.Office.Interop.Excel;

public class asdg : Form
{
	private Panel m_a;

	private Panel m_b;

	private Panel m_c;

	private GridEX m_d;

	private UIButton m_e;

	private FolderBrowserDialog f;

	private UIButton g;

	private Label h;

	private UIComboBox i;

	private GridEX j;

	private Label k;

	private EditBox l;

	private UIButton m;

	private ProgressBar n;

	private Label o;

	private Label p;

	private Container q = null;

	public asdg()
	{
		d();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
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
						num = 3;
						continue;
					}
					goto case 1;
				case 4:
					num = 1;
					continue;
				case 2:
					q.Dispose();
					num = 4;
					continue;
				case 3:
					flag = q == null;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 1:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected Obj, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected Obj, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdg));
		StringFormat val = new StringFormat();
		GridEXLayout val2 = new GridEXLayout();
		GridEXLayout val3 = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_c = new Panel();
		n = new ProgressBar();
		k = new Label();
		l = new EditBox();
		m = new UIButton();
		g = new UIButton();
		this.m_e = new UIButton();
		h = new Label();
		i = new UIComboBox();
		j = new GridEX();
		this.m_d = new GridEX();
		f = new FolderBrowserDialog();
		o = new Label();
		p = new Label();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(7, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(273, 615);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(8, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(259, 597);
		((Control)this.m_b).TabIndex = 16;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)o);
		((Control)this.m_c).Controls.Add((Control)(object)p);
		((Control)this.m_c).Controls.Add((Control)(object)n);
		((Control)this.m_c).Controls.Add((Control)(object)k);
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Controls.Add((Control)(object)m);
		((Control)this.m_c).Controls.Add((Control)(object)g);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)h);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel3";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(255, 593);
		((Control)this.m_c).TabIndex = 36;
		((Control)n).Location = new Point(5, 511);
		((Control)n).Name = "pr12";
		((Control)n).Size = new Size(242, 16);
		((Control)n).TabIndex = 130;
		((Control)k).AutoSize = true;
		((Control)k).Font = new Font("Tahoma", 8.25f);
		((Control)k).Location = new Point(149, 448);
		((Control)k).Name = "label9";
		((Control)k).Size = new Size(87, 13);
		((Control)k).TabIndex = 129;
		((Control)k).Text = "مسیر فایل اکسل";
		((EditBase)l).AutoScroll = false;
		((EditBase)l).AutoScrollMargin = new Size(0, 0);
		((EditBase)l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)l).AutoScrollPosition = new Point(0, 0);
		((Control)l).Location = new Point(4, 464);
		((Control)l).Name = "txtpath";
		((Control)l).Size = new Size(239, 21);
		((Control)l).TabIndex = 128;
		((EditBase)l).TextAlignment = (TextAlignment)1;
		((Control)m).Font = new Font("Tahoma", 8.25f);
		((Control)m).Location = new Point(4, 441);
		((Control)m).Name = "btnselectPath";
		((Control)m).Size = new Size(75, 20);
		((Control)m).TabIndex = 127;
		((Control)m).Text = "انتخاب مسير";
		((Control)m).Click += c;
		((Control)g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		g.ImageSize = new Size(30, 30);
		((Control)g).Location = new Point(138, 554);
		((Control)g).Name = "btnProcc";
		((Control)g).Size = new Size(107, 25);
		((Control)g).TabIndex = 59;
		((Control)g).Text = "ایجاد فایل";
		((Control)g).Click += d;
		this.m_e.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		this.m_e.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_e.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(20, 20);
		((Control)this.m_e).Location = new Point(4, 554);
		((Control)this.m_e).Name = "uiButton2";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(87, 25);
		((Control)this.m_e).TabIndex = 46;
		((Control)this.m_e).Text = "خروج";
		this.m_e.VisualStyle = (VisualStyle)1;
		((Control)this.m_e).Click += e;
		((Control)h).Anchor = (AnchorStyles)9;
		((Control)h).AutoSize = true;
		((Control)h).Location = new Point(224, 56);
		((Control)h).Name = "label20";
		((Control)h).Size = new Size(22, 13);
		((Control)h).TabIndex = 126;
		((Control)h).Text = "پایه";
		((Control)i).Anchor = (AnchorStyles)9;
		((UIComboBase)i).ComboStyle = (ComboStyle)1;
		((UIComboBase)i).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)i).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)i).Location = new Point(4, 53);
		((Control)i).Name = "dropPaye";
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(216, 20);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)i).StringFormat = val;
		((Control)i).TabIndex = 125;
		i.SelectedIndexChanged += b;
		((Control)j).Anchor = (AnchorStyles)10;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		j.DesignTimeLayout = val2;
		j.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		j.GroupByBoxVisible = false;
		((Control)j).Location = new Point(3, 83);
		((Control)j).Name = "gClass";
		((Control)j).RightToLeft = (RightToLeft)1;
		j.RowHeaders = (InheritableBoolean)1;
		((Control)j).Size = new Size(240, 116);
		((Control)j).TabIndex = 124;
		((ScrollableBase)j).VisualStyle = (VisualStyle)2;
		this.m_d.CardCaptionPrefix = "Product:";
		((Control)this.m_d).Cursor = Cursors.Default;
		this.m_d.DataMember = null;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		this.m_d.DesignTimeLayout = val3;
		this.m_d.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)this.m_d).FlatBorderColor = SystemColors.ControlDark;
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f);
		this.m_d.GridLineColor = SystemColors.ScrollBar;
		this.m_d.GroupByBoxVisible = false;
		this.m_d.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)this.m_d).Location = new Point(4, 209);
		((Control)this.m_d).Name = "gBook";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		this.m_d.RowHeaders = (InheritableBoolean)1;
		this.m_d.SelectedFormatStyle.Blend = 0.5f;
		this.m_d.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_d).Size = new Size(240, 226);
		((Control)this.m_d).TabIndex = 39;
		((ScrollableBase)this.m_d).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_d).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_d).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		o.BorderStyle = (BorderStyle)1;
		((Control)o).Location = new Point(102, 17);
		((Control)o).Name = "lYear";
		((Control)o).Size = new Size(68, 24);
		((Control)o).TabIndex = 132;
		((Control)p).AutoSize = true;
		((Control)p).Location = new Point(176, 23);
		((Control)p).Name = "label6";
		((Control)p).Size = new Size(66, 13);
		((Control)p).TabIndex = 131;
		((Control)p).Text = "سال تعلیمی";
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(287, 633);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmCreateXlsToMarkEntry";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ایجاد فایل اکسل شاگردان برای ورود نمره";
		((Form)this).Load += a;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)j).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
		i.DataSource = dataSource;
		i.DisplayMember = "Name";
		i.ValueMember = "id";
	}

	private void b()
	{
		while (true)
		{
			bool flag = i.SelectedIndex < 0;
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
					this.m_d.DataSource = null;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tbook where xPaye=" + i.SelectedValue.ToString());
					this.m_d.DataSource = dataSource;
					if (true)
					{
					}
					num = 2;
					continue;
				}
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			string text = " where xYear=" + asdaj.a + " and xPaye in(" + asdaj.n + ")";
			bool flag = i.SelectedIndex < 0;
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
				{
					if (true)
					{
					}
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + ((Control)o).Text + " and (xPaye = " + i.SelectedValue.ToString() + "))";
					num = 2;
					continue;
				}
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
					j.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		int num3 = default;
		Workbook val = default;
		string text = default;
		int num2 = default;
		DataTable dataTable = default;
		int num4 = default;
		Application val3 = default;
		Worksheet val2 = default;
		while (true)
		{
			bool flag = !(((Control)l).Text == "");
			int num = 43;
			while (true)
			{
				switch (num)
				{
				case 43:
					if (!flag)
					{
						num = 2;
						continue;
					}
					num3 = 0;
					num = 26;
					continue;
				case 16:
					((_Workbook)val).SaveAs((object)(((Control)l).Text + "\\" + j.GetRow(num3).Cells["name"].Value.ToString().Replace("/", "-").Replace("\\", "-") + "-" + i.SelectedItem.Text + ".xls"), (object)(XlFileFormat)(-4143), (object)null, (object)null, (object)null, (object)null, (XlSaveAsAccessMode)1, (object)null, (object)null, (object)null, (object)null, (object)null);
					flag = val == null;
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 24;
				case 40:
					text += ",";
					num = 20;
					continue;
				case 3:
					num = 4;
					continue;
				case 28:
				case 39:
					flag = num2 < dataTable.Rows.Count;
					num = 38;
					continue;
				case 38:
					if (flag)
					{
						num4 = 0;
						num = 7;
					}
					else
					{
						num = 16;
					}
					continue;
				case 14:
					try
					{
						Process.Start("explorer.exe", ((Control)l).Text);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 22;
					continue;
				case 33:
					n.Maximum = dataTable.Rows.Count;
					num2 = 0;
					num = 39;
					continue;
				case 20:
					text += this.m_d.GetRow(num2).Cells["id"].Value.ToString();
					num = 11;
					continue;
				case 26:
				case 37:
					flag = num3 < j.RowCount;
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 27;
						continue;
					}
					n.Minimum = 0;
					n.Value = 1;
					n.Step = 1;
					flag = !(j.GetRow(num3).Cells[0].Value.ToString() != "True");
					num = 44;
					continue;
				case 22:
					return;
				case 45:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					string text2 = "mark.xls";
					object value = Missing.Value;
					val3 = (Application)new ApplicationClass();
					Workbooks workbooks = ((_Application)val3).Workbooks;
					string text3 = Application.StartupPath + "\\" + text2;
					CultureInfo currentCulture = new CultureInfo("en-US");
					Thread.CurrentThread.CurrentCulture = currentCulture;
					val = workbooks.Open(text3, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
					val2 = (Worksheet)((_Workbook)val).ActiveSheet;
					num2 = 1;
					num = 21;
					continue;
				}
				case 2:
					MessageBox.Show("مسیری برای ساختن فایل اکسل انتخاب نشده است");
					((Control)m).Focus();
					num = 29;
					continue;
				case 29:
					return;
				case 42:
					flag = !(text != "");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 20;
				case 9:
					if (!flag)
					{
						num = 42;
						continue;
					}
					goto case 11;
				case 5:
				case 23:
					flag = num2 < this.m_d.RowCount;
					num = 46;
					continue;
				case 46:
					if (flag)
					{
						flag = !(this.m_d.GetRow(num2).Cells[0].Value.ToString() == "True");
						num = 9;
					}
					else
					{
						num = 17;
					}
					continue;
				case 27:
					MessageBox.Show("پایان");
					num = 14;
					continue;
				case 24:
					flag = val3 == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 3;
				case 13:
					num = 8;
					continue;
				case 7:
				case 15:
					flag = num4 < dataTable.Columns.Count;
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 31;
						continue;
					}
					((_Worksheet)val2).Cells[(object)(num2 + 2), (object)(num4 + 1)] = dataTable.Rows[num2][num4].ToString();
					num4++;
					num = 15;
					continue;
				case 17:
					flag = !(text == "");
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						SqlParameter[] a_ = new SqlParameter[3]
						{
							asdcb.a("@xbook", SqlDbType.VarChar, 200, text),
							asdcb.a("@xclass", SqlDbType.Int, j.GetRow(num3).Cells["id"].Value.ToString()),
							asdcb.a("@xyear", SqlDbType.Int, ((Control)o).Text)
						};
						dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT tYear_Student.sort AS ترتیب, tStudent.Code, tBook.codeDars, tStudent.FName AS نام, tStudent.LName AS [ولد/بنت], tBook.Name AS [مضمون]\r\n                                            FROM         tStudent inner join tYear_Student on tStudent.id=tYear_Student.xstudent CROSS JOIN tBook WHERE tYear_Student.xyear=@xyear and  (tYear_Student.xClass = @xclass)  AND tBook.id  in(select * from SplitNumber(@xbook))ORDER BY tBook.sort,tBook.id, tYear_Student.sort, tStudent.LName, tStudent.FName", a_);
						flag = dataTable.Rows.Count != 0;
						num = 45;
					}
					else
					{
						num = 25;
					}
					continue;
				case 32:
					num = 35;
					continue;
				case 10:
					((_Application)val3).Quit();
					Marshal.FinalReleaseComObject(val3);
					num = 3;
					continue;
				case 25:
					MessageBox.Show(" هیچ درسی انتخاب نشده است");
					num = 1;
					continue;
				case 1:
					return;
				case 11:
					num2++;
					num = 5;
					continue;
				case 31:
					n.PerformStep();
					num2++;
					num = 28;
					continue;
				case 6:
				case 21:
					flag = num2 < dataTable.Columns.Count + 1;
					num = 30;
					continue;
				case 30:
					if (flag)
					{
						((_Worksheet)val2).Cells[(object)1, (object)num2] = dataTable.Columns[num2 - 1].ColumnName;
						num2++;
						num = 6;
					}
					else
					{
						num = 33;
					}
					continue;
				case 4:
				case 8:
				case 35:
					num3++;
					num = 37;
					continue;
				case 34:
					((_Workbook)val).Close((object)true, (object)null, (object)null);
					Marshal.FinalReleaseComObject(val);
					num = 24;
					continue;
				case 44:
					if (flag)
					{
						text = "";
						num2 = 0;
						num = 23;
					}
					else
					{
						num = 32;
					}
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		while (true)
		{
			DialogResult val = ((CommonDialog)f).ShowDialog();
			bool flag = (int)val != 1;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 0:
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					((Control)l).Text = f.SelectedPath;
					num = 0;
					continue;
				case 2:
					flag = !(f.SelectedPath != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 5:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_c).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 4:
					c();
					((Control)o).Text = asdaj.a;
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 6;
					continue;
				case 6:
					return;
				case 1:
					num = 5;
					continue;
				}
				break;
			}
		}
	}
}
