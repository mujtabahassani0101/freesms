using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

public class asdb5 : Form
{
	private Panel m_a;

	private Panel m_b;

	private Panel m_c;

	private UIButton m_d;

	private UIButton m_e;

	private Label f;

	private UIComboBox g;

	private GridEX h;

	private Label i;

	private EditBox j;

	private UIButton k;

	private ProgressBar l;

	private Label m;

	private UIComboBox n;

	private SaveFileDialog o;

	private Container p = null;

	private string q = Application.StartupPath + "\\mark2.xls";

	public asdb5()
	{
		d();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 5:
					num = 1;
					continue;
				case 2:
					p.Dispose();
					num = 5;
					continue;
				case 0:
					flag = p == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
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
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected Obj, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected Obj, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected Obj, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb5));
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_c = new Panel();
		m = new Label();
		n = new UIComboBox();
		l = new ProgressBar();
		i = new Label();
		j = new EditBox();
		k = new UIButton();
		this.m_e = new UIButton();
		this.m_d = new UIButton();
		f = new Label();
		g = new UIComboBox();
		h = new GridEX();
		o = new SaveFileDialog();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(7, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(273, 395);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(8, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(259, 379);
		((Control)this.m_b).TabIndex = 16;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)m);
		((Control)this.m_c).Controls.Add((Control)(object)n);
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)k);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)f);
		((Control)this.m_c).Controls.Add((Control)(object)g);
		((Control)this.m_c).Controls.Add((Control)(object)h);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel3";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(255, 375);
		((Control)this.m_c).TabIndex = 36;
		((Control)m).Anchor = (AnchorStyles)9;
		((Control)m).AutoSize = true;
		((Control)m).Location = new Point(211, 17);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(29, 13);
		((Control)m).TabIndex = 132;
		((Control)m).Text = "دوره";
		((Control)n).Anchor = (AnchorStyles)9;
		((UIComboBase)n).ComboStyle = (ComboStyle)1;
		((UIComboBase)n).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(5, 12);
		((Control)n).Name = "dropExam";
		((Control)n).Size = new Size(201, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)n).StringFormat = val;
		((Control)n).TabIndex = 131;
		((Control)l).Location = new Point(6, 309);
		((Control)l).Name = "pr12";
		((Control)l).Size = new Size(242, 16);
		((Control)l).TabIndex = 130;
		((Control)i).AutoSize = true;
		((Control)i).Font = new Font("Tahoma", 8.25f);
		((Control)i).Location = new Point(150, 268);
		((Control)i).Name = "label9";
		((Control)i).Size = new Size(87, 13);
		((Control)i).TabIndex = 129;
		((Control)i).Text = "مسیر فایل اکسل";
		((EditBase)j).AutoScroll = false;
		((EditBase)j).AutoScrollMargin = new Size(0, 0);
		((EditBase)j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)j).AutoScrollPosition = new Point(0, 0);
		((Control)j).Location = new Point(5, 284);
		((Control)j).Name = "txtpath";
		((Control)j).Size = new Size(239, 20);
		((Control)j).TabIndex = 128;
		((EditBase)j).TextAlignment = (TextAlignment)1;
		((Control)k).Font = new Font("Tahoma", 8.25f);
		((Control)k).Location = new Point(5, 261);
		((Control)k).Name = "btnselectPath";
		((Control)k).Size = new Size(75, 20);
		((Control)k).TabIndex = 127;
		((Control)k).Text = "انتخاب مسير";
		((Control)k).Click += c;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_e.ImageSize = new Size(30, 30);
		((Control)this.m_e).Location = new Point(139, 334);
		((Control)this.m_e).Name = "btnProcc";
		((Control)this.m_e).Size = new Size(107, 25);
		((Control)this.m_e).TabIndex = 59;
		((Control)this.m_e).Text = "ایجاد فایل";
		((Control)this.m_e).Click += d;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f);
		this.m_d.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_d.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_d.ImageIndex = 8;
		this.m_d.ImageSize = new Size(20, 20);
		((Control)this.m_d).Location = new Point(5, 334);
		((Control)this.m_d).Name = "uiButton2";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		((Control)this.m_d).Size = new Size(87, 25);
		((Control)this.m_d).TabIndex = 46;
		((Control)this.m_d).Text = "خروج";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += e;
		((Control)f).Anchor = (AnchorStyles)9;
		((Control)f).AutoSize = true;
		((Control)f).Location = new Point(216, 45);
		((Control)f).Name = "label20";
		((Control)f).Size = new Size(24, 13);
		((Control)f).TabIndex = 126;
		((Control)f).Text = "پایه";
		((Control)g).Anchor = (AnchorStyles)9;
		((UIComboBase)g).ComboStyle = (ComboStyle)1;
		((UIComboBase)g).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)g).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)g).Location = new Point(4, 41);
		((Control)g).Name = "dropPaye";
		((Control)g).RightToLeft = (RightToLeft)1;
		((Control)g).Size = new Size(202, 20);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)g).StringFormat = val2;
		((Control)g).TabIndex = 125;
		g.SelectedIndexChanged += b;
		((Control)h).Anchor = (AnchorStyles)9;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		h.DesignTimeLayout = val3;
		h.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)h).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		h.GroupByBoxVisible = false;
		((Control)h).Location = new Point(6, 78);
		((Control)h).Name = "gClass";
		((Control)h).RightToLeft = (RightToLeft)1;
		h.RowHeaders = (InheritableBoolean)1;
		((Control)h).Size = new Size(240, 162);
		((Control)h).TabIndex = 124;
		((ScrollableBase)h).VisualStyle = (VisualStyle)2;
		((FileDialog)o).Filter = "اکسل 2003|*.xls";
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(287, 412);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmExpotMarkToXls";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "دریافت فایل اکسل نمرات";
		((Form)this).Load += a;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)h).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void c()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam order by id desc");
			n.DataSource = dataSource;
			n.DisplayMember = "Name";
			n.ValueMember = "id";
			bool flag = ((CollectionBase)(object)n.Items).Count <= 0;
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
					return;
				case 0:
					n.SelectedIndex = 0;
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		int num2 = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
			bool flag = dataTable.Rows.Count <= 1;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 2;
				case 1:
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 3:
					g.Items.Add("", (object)"0");
					num = 2;
					continue;
				case 9:
					g.SelectedIndex = 0;
					num = 5;
					continue;
				case 5:
					return;
				case 2:
					num2 = 0;
					num = 0;
					continue;
				case 0:
				case 8:
					flag = num2 < dataTable.Rows.Count;
					if (true)
					{
					}
					num = 7;
					continue;
				case 7:
					if (flag)
					{
						g.Items.Add(dataTable.Rows[num2]["name"].ToString(), (object)dataTable.Rows[num2]["id"].ToString());
						num2++;
						num = 8;
					}
					else
					{
						num = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		while (true)
		{
			string text = " and xPaye in(" + asdaj.n + ")";
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					num = ((g.SelectedIndex < 0) ? 5 : 4);
					continue;
				case 4:
					num = 3;
					continue;
				case 3:
					num2 = ((!(g.SelectedValue.ToString() != "0")) ? 1 : 0);
					goto IL_00bc;
				case 6:
					text = text + " and xPaye=" + g.SelectedValue.ToString();
					num = 0;
					continue;
				case 2:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 0;
				case 5:
					num2 = 1;
					goto IL_00bc;
				case 0:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + asdaj.a + text);
						h.DataSource = dataSource;
						return;
					}
					IL_00bc:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 2;
					continue;
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
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		Workbook val2 = default;
		Application val3 = default;
		DataTable dataTable = default;
		int num2 = default;
		int num3 = default;
		Worksheet val = default;
		while (true)
		{
			bool flag = !(((Control)j).Text == "");
			int num = 36;
			while (true)
			{
				switch (num)
				{
				case 36:
					if (!flag)
					{
						num = 30;
						continue;
					}
					flag = n.SelectedIndex >= 0;
					num = 37;
					continue;
				case 20:
					flag = !(text != "");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 23;
				case 8:
					((_Workbook)val2).SaveAs((object)((Control)j).Text, (object)(XlFileFormat)(-4143), (object)null, (object)null, (object)null, (object)null, (XlSaveAsAccessMode)1, (object)null, (object)null, (object)null, (object)null, (object)null);
					flag = val2 == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 11;
				case 11:
					flag = val3 == null;
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 32:
					if (true)
					{
					}
					text += ",";
					num = 23;
					continue;
				case 12:
					((_Workbook)val2).Close((object)true, (object)null, (object)null);
					Marshal.FinalReleaseComObject(val2);
					num = 11;
					continue;
				case 4:
					MessageBox.Show("پایان");
					num = 18;
					continue;
				case 18:
					return;
				case 40:
					flag = !(text == "");
					num = 6;
					continue;
				case 6:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					SqlParameter[] a_ = new SqlParameter[2]
					{
						asdcb.a("@Exam", SqlDbType.VarChar, 500, n.SelectedValue.ToString()),
						asdcb.a("@class", SqlDbType.VarChar, 500, text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, "sp_ExportMarkToXls", a_);
					flag = dataTable.Rows.Count != 0;
					num = 14;
					continue;
				}
				case 30:
					MessageBox.Show("مسیری برای ساختن فایل اکسل انتخاب نشده است");
					((Control)k).Focus();
					num = 25;
					continue;
				case 25:
					return;
				case 9:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 29;
				case 23:
					text += h.GetRow(num2).Cells["id"].Value.ToString();
					num = 29;
					continue;
				case 29:
					num2++;
					num = 26;
					continue;
				case 15:
				case 22:
					flag = num2 < dataTable.Rows.Count;
					num = 19;
					continue;
				case 19:
					if (flag)
					{
						num3 = 0;
						num = 10;
					}
					else
					{
						num = 8;
					}
					continue;
				case 7:
				case 10:
					flag = num3 < dataTable.Columns.Count;
					num = 24;
					continue;
				case 24:
					if (flag)
					{
						((_Worksheet)val).Cells[(object)(num2 + 2), (object)(num3 + 1)] = dataTable.Rows[num2][num3].ToString();
						num3++;
						num = 7;
					}
					else
					{
						num = 16;
					}
					continue;
				case 1:
					MessageBox.Show(" هیچ صنفی انتخاب نشده است");
					((Control)h).Focus();
					num = 33;
					continue;
				case 33:
					return;
				case 14:
					if (flag)
					{
						object value = Missing.Value;
						val3 = (Application)new ApplicationClass();
						Workbooks workbooks = ((_Application)val3).Workbooks;
						CultureInfo currentCulture = new CultureInfo("en-US");
						Thread.CurrentThread.CurrentCulture = currentCulture;
						val2 = workbooks.Open(q, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
						val = (Worksheet)((_Workbook)val2).ActiveSheet;
						num2 = 1;
						num = 13;
					}
					else
					{
						num = 39;
					}
					continue;
				case 31:
					l.Minimum = 0;
					l.Value = 1;
					l.Step = 1;
					l.Maximum = dataTable.Rows.Count;
					num2 = 0;
					num = 22;
					continue;
				case 0:
				case 26:
					flag = num2 < h.RowCount;
					num = 34;
					continue;
				case 34:
					if (flag)
					{
						flag = !(h.GetRow(num2).Cells[0].Value.ToString() == "True");
						num = 9;
					}
					else
					{
						num = 40;
					}
					continue;
				case 21:
					MessageBox.Show(" دوره ای انتخاب نشده است");
					((UIComboBase)n).Focus();
					num = 28;
					continue;
				case 28:
					return;
				case 2:
					((_Application)val3).Quit();
					Marshal.FinalReleaseComObject(val3);
					num = 4;
					continue;
				case 39:
					MessageBox.Show("موردی برای ارسال وجود ندارد");
					num = 17;
					continue;
				case 17:
					return;
				case 37:
					if (flag)
					{
						text = "";
						num2 = 0;
						num = 0;
					}
					else
					{
						num = 21;
					}
					continue;
				case 13:
				case 38:
					flag = num2 < dataTable.Columns.Count + 1;
					num = 35;
					continue;
				case 35:
					if (flag)
					{
						((_Worksheet)val).Cells[(object)1, (object)num2] = dataTable.Columns[num2 - 1].ColumnName;
						num2++;
						num = 38;
					}
					else
					{
						num = 31;
					}
					continue;
				case 16:
					l.PerformStep();
					num2++;
					num = 15;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			DialogResult val = ((CommonDialog)o).ShowDialog();
			bool flag = (int)val != 1;
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
					return;
				case 2:
					if (true)
					{
					}
					((Control)j).Text = ((FileDialog)o).FileName;
					num = 0;
					continue;
				case 7:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 1:
					flag = !(q == ((FileDialog)o).FileName);
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						flag = !(((FileDialog)o).FileName != "");
						num = 7;
					}
					else
					{
						num = 8;
					}
					continue;
				case 0:
					num = 4;
					continue;
				case 4:
					return;
				case 8:
					MessageBox.Show("شما قادر به انتخاب این فایل نیستید.لطفا مسیر دیگری را انتخاب کنید");
					num = 5;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
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
						num = 3;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 0:
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
					num = 2;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 2:
					c();
					b();
					num = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					return;
				case 3:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					num = 0;
					continue;
				}
				break;
			}
		}
	}
}
