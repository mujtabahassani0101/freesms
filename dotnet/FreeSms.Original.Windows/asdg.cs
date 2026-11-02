using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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

	private System.Windows.Forms.Label h;

	private UIComboBox i;

	private GridEX j;

	private System.Windows.Forms.Label k;

	private Janus.Windows.GridEX.EditControls.EditBox l;

	private UIButton m;

	private ProgressBar n;

	private System.Windows.Forms.Label o;

	private System.Windows.Forms.Label p;

	private Container q = null;

	public asdg()
	{
		d();
	}
protected override void Dispose(bool A_0)
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
					base.Dispose(A_0);
					return;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdg));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_c = new Panel();
		n = new ProgressBar();
		k = new System.Windows.Forms.Label();
		l = new Janus.Windows.GridEX.EditControls.EditBox();
		m = new UIButton();
		g = new UIButton();
		this.m_e = new UIButton();
		h = new System.Windows.Forms.Label();
		i = new UIComboBox();
		j = new GridEX();
		this.m_d = new GridEX();
		f = new FolderBrowserDialog();
		o = new System.Windows.Forms.Label();
		p = new System.Windows.Forms.Label();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		SuspendLayout();
		this.m_a.BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new System.Drawing.Point(7, 8);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(273, 615);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new System.Drawing.Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(259, 597);
		this.m_b.TabIndex = 16;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(o);
		this.m_c.Controls.Add(p);
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(m);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(h);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Location = new System.Drawing.Point(0, 0);
		this.m_c.Name = "panel3";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(255, 593);
		this.m_c.TabIndex = 36;
		n.Location = new System.Drawing.Point(5, 511);
		n.Name = "pr12";
		n.Size = new Size(242, 16);
		n.TabIndex = 130;
		k.AutoSize = true;
		k.Font = new System.Drawing.Font("Tahoma", 8.25f);
		k.Location = new System.Drawing.Point(149, 448);
		k.Name = "label9";
		k.Size = new Size(87, 13);
		k.TabIndex = 129;
		k.Text = "مسیر فایل اکسل";
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new System.Drawing.Point(0, 0);
		l.Location = new System.Drawing.Point(4, 464);
		l.Name = "txtpath";
		l.Size = new Size(239, 21);
		l.TabIndex = 128;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.Font = new System.Drawing.Font("Tahoma", 8.25f);
		m.Location = new System.Drawing.Point(4, 441);
		m.Name = "btnselectPath";
		m.Size = new Size(75, 20);
		m.TabIndex = 127;
		m.Text = "انتخاب مسير";
		m.Click += c;
		g.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.ImageSize = new Size(30, 30);
		g.Location = new System.Drawing.Point(138, 554);
		g.Name = "btnProcc";
		g.Size = new Size(107, 25);
		g.TabIndex = 59;
		g.Text = "ایجاد فایل";
		g.Click += d;
		this.m_e.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_e.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.m_e.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_e.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(20, 20);
		this.m_e.Location = new System.Drawing.Point(4, 554);
		this.m_e.Name = "uiButton2";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(87, 25);
		this.m_e.TabIndex = 46;
		this.m_e.Text = "خروج";
		this.m_e.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_e.Click += e;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.AutoSize = true;
		h.Location = new System.Drawing.Point(224, 56);
		h.Name = "label20";
		h.Size = new Size(22, 13);
		h.TabIndex = 126;
		h.Text = "پایه";
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		i.DropListFont = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Font = new System.Drawing.Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		i.Location = new System.Drawing.Point(4, 53);
		i.Name = "dropPaye";
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(216, 20);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		i.StringFormat = stringFormat;
		i.TabIndex = 125;
		i.SelectedIndexChanged += b;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		j.DesignTimeLayout = gridEXLayout;
		j.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		j.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j.GroupByBoxVisible = false;
		j.Location = new System.Drawing.Point(3, 83);
		j.Name = "gClass";
		j.RightToLeft = RightToLeft.Yes;
		j.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		j.Size = new Size(240, 116);
		j.TabIndex = 124;
		j.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.CardCaptionPrefix = "Product:";
		this.m_d.Cursor = Cursors.Default;
		this.m_d.DataMember = null;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		this.m_d.DesignTimeLayout = gridEXLayout2;
		this.m_d.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_d.FlatBorderColor = SystemColors.ControlDark;
		this.m_d.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.m_d.GridLineColor = SystemColors.ScrollBar;
		this.m_d.GroupByBoxVisible = false;
		this.m_d.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_d.Location = new System.Drawing.Point(4, 209);
		this.m_d.Name = "gBook";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_d.SelectedFormatStyle.Blend = 0.5f;
		this.m_d.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_d.Size = new Size(240, 226);
		this.m_d.TabIndex = 39;
		this.m_d.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_d.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		o.Location = new System.Drawing.Point(102, 17);
		o.Name = "lYear";
		o.Size = new Size(68, 24);
		o.TabIndex = 132;
		p.AutoSize = true;
		p.Location = new System.Drawing.Point(176, 23);
		p.Name = "label6";
		p.Size = new Size(66, 13);
		p.TabIndex = 131;
		p.Text = "سال تعلیمی";
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.CornflowerBlue;
		ClientSize = new Size(287, 633);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmCreateXlsToMarkEntry";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ایجاد فایل اکسل شاگردان برای ورود نمره";
		Load += a;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)j).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void c()
	{
		if (true)
		{
		}
		System.Data.DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
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
					System.Data.DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tbook where xPaye=" + i.SelectedValue.ToString());
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
			string text = " where xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
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
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + o.Text + " and (xPaye = " + i.SelectedValue.ToString() + "))";
					num = 2;
					continue;
				}
				case 2:
				{
					System.Data.DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
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
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		int num3 = default;
		Workbook workbook = default;
		string text = default;
		int num2 = default;
		System.Data.DataTable dataTable = default;
		int num4 = default;
		Microsoft.Office.Interop.Excel.Application application = default;
		Worksheet worksheet = default;
		while (true)
		{
			bool flag = !(l.Text == "");
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
					workbook.SaveAs(l.Text + "\\" + j.GetRow(num3).Cells["name"].Value.ToString().Replace("/", "-").Replace("\\", "-") + "-" + i.SelectedItem.Text + ".xls", XlFileFormat.xlWorkbookNormal);
					flag = workbook == null;
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
						Process.Start("explorer.exe", l.Text);
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
					application = new ApplicationClass();
					Workbooks workbooks = application.Workbooks;
					string filename = System.Windows.Forms.Application.StartupPath + "\\" + text2;
					CultureInfo currentCulture = new CultureInfo("en-US");
					Thread.CurrentThread.CurrentCulture = currentCulture;
					workbook = workbooks.Open(filename, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
					worksheet = (Worksheet)workbook.ActiveSheet;
					num2 = 1;
					num = 21;
					continue;
				}
				case 2:
					MessageBox.Show("مسیری برای ساختن فایل اکسل انتخاب نشده است");
					m.Focus();
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
					flag = application == null;
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
					worksheet.Cells[num2 + 2, num4 + 1] = dataTable.Rows[num2][num4].ToString();
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
							asdcb.a("@xyear", SqlDbType.Int, o.Text)
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
					application.Quit();
					Marshal.FinalReleaseComObject(application);
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
						worksheet.Cells[1, num2] = dataTable.Columns[num2 - 1].ColumnName;
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
					workbook.Close(true);
					Marshal.FinalReleaseComObject(workbook);
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
		while (true)
		{
			DialogResult dialogResult = f.ShowDialog();
			bool flag = dialogResult != DialogResult.OK;
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
					l.Text = f.SelectedPath;
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
		System.Data.DataTable dataTable = default;
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
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
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
					o.Text = asdaj.__field_a;
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
