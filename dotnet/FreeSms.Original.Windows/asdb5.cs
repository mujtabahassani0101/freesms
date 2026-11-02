using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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

	private System.Windows.Forms.Label f;

	private UIComboBox g;

	private GridEX h;

	private System.Windows.Forms.Label i;

	private Janus.Windows.GridEX.EditControls.EditBox j;

	private UIButton k;

	private ProgressBar l;

	private System.Windows.Forms.Label m;

	private UIComboBox n;

	private SaveFileDialog o;

	private Container p = null;

	private string q = System.Windows.Forms.Application.StartupPath + "\\mark2.xls";

	public asdb5()
	{
		d();
	}
protected override void Dispose(bool A_0)
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
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb5));
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_c = new Panel();
		m = new System.Windows.Forms.Label();
		n = new UIComboBox();
		l = new ProgressBar();
		i = new System.Windows.Forms.Label();
		j = new Janus.Windows.GridEX.EditControls.EditBox();
		k = new UIButton();
		this.m_e = new UIButton();
		this.m_d = new UIButton();
		f = new System.Windows.Forms.Label();
		g = new UIComboBox();
		h = new GridEX();
		o = new SaveFileDialog();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		SuspendLayout();
		this.m_a.BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new System.Drawing.Point(7, 8);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(273, 395);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new System.Drawing.Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(259, 379);
		this.m_b.TabIndex = 16;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(m);
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(f);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(h);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new System.Drawing.Point(0, 0);
		this.m_c.Name = "panel3";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(255, 375);
		this.m_c.TabIndex = 36;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.AutoSize = true;
		m.Location = new System.Drawing.Point(211, 17);
		m.Name = "label2";
		m.Size = new Size(29, 13);
		m.TabIndex = 132;
		m.Text = "دوره";
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		n.DropListFont = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		n.Location = new System.Drawing.Point(5, 12);
		n.Name = "dropExam";
		n.Size = new Size(201, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		n.StringFormat = stringFormat;
		n.TabIndex = 131;
		l.Location = new System.Drawing.Point(6, 309);
		l.Name = "pr12";
		l.Size = new Size(242, 16);
		l.TabIndex = 130;
		i.AutoSize = true;
		i.Font = new System.Drawing.Font("Tahoma", 8.25f);
		i.Location = new System.Drawing.Point(150, 268);
		i.Name = "label9";
		i.Size = new Size(87, 13);
		i.TabIndex = 129;
		i.Text = "مسیر فایل اکسل";
		j.AutoScroll = false;
		j.AutoScrollMargin = new Size(0, 0);
		j.AutoScrollMinSize = new Size(0, 0);
		j.AutoScrollPosition = new System.Drawing.Point(0, 0);
		j.Location = new System.Drawing.Point(5, 284);
		j.Name = "txtpath";
		j.Size = new Size(239, 20);
		j.TabIndex = 128;
		j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		k.Font = new System.Drawing.Font("Tahoma", 8.25f);
		k.Location = new System.Drawing.Point(5, 261);
		k.Name = "btnselectPath";
		k.Size = new Size(75, 20);
		k.TabIndex = 127;
		k.Text = "انتخاب مسير";
		k.Click += c;
		this.m_e.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.ImageSize = new Size(30, 30);
		this.m_e.Location = new System.Drawing.Point(139, 334);
		this.m_e.Name = "btnProcc";
		this.m_e.Size = new Size(107, 25);
		this.m_e.TabIndex = 59;
		this.m_e.Text = "ایجاد فایل";
		this.m_e.Click += d;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.m_d.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_d.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_d.ImageIndex = 8;
		this.m_d.ImageSize = new Size(20, 20);
		this.m_d.Location = new System.Drawing.Point(5, 334);
		this.m_d.Name = "uiButton2";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.Size = new Size(87, 25);
		this.m_d.TabIndex = 46;
		this.m_d.Text = "خروج";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += e;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.AutoSize = true;
		f.Location = new System.Drawing.Point(216, 45);
		f.Name = "label20";
		f.Size = new Size(24, 13);
		f.TabIndex = 126;
		f.Text = "پایه";
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		g.DropListFont = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.Font = new System.Drawing.Font("Tahoma", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
		g.Location = new System.Drawing.Point(4, 41);
		g.Name = "dropPaye";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(202, 20);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		g.StringFormat = stringFormat2;
		g.TabIndex = 125;
		g.SelectedIndexChanged += b;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		h.DesignTimeLayout = gridEXLayout;
		h.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		h.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h.GroupByBoxVisible = false;
		h.Location = new System.Drawing.Point(6, 78);
		h.Name = "gClass";
		h.RightToLeft = RightToLeft.Yes;
		h.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		h.Size = new Size(240, 162);
		h.TabIndex = 124;
		h.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		o.Filter = "اکسل 2003|*.xls";
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.CornflowerBlue;
		ClientSize = new Size(287, 412);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmExpotMarkToXls";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "دریافت فایل اکسل نمرات";
		Load += a;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)h).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void c()
	{
		while (true)
		{
			System.Data.DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam order by id desc");
			n.DataSource = dataSource;
			n.DisplayMember = "Name";
			n.ValueMember = "id";
			bool flag = n.Items.Count <= 0;
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
			System.Data.DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
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
					g.Items.Add("", "0");
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
						g.Items.Add(dataTable.Rows[num2]["name"].ToString(), dataTable.Rows[num2]["id"].ToString());
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
						System.Data.DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + asdaj.__field_a + text);
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
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		string text = default;
		Workbook workbook = default;
		Microsoft.Office.Interop.Excel.Application application = default;
		System.Data.DataTable dataTable = default;
		int num2 = default;
		int num3 = default;
		Worksheet worksheet = default;
		while (true)
		{
			bool flag = !(j.Text == "");
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
					workbook.SaveAs(j.Text, XlFileFormat.xlWorkbookNormal);
					flag = workbook == null;
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
					flag = application == null;
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
					workbook.Close(true);
					Marshal.FinalReleaseComObject(workbook);
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
					k.Focus();
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
						worksheet.Cells[num2 + 2, num3 + 1] = dataTable.Rows[num2][num3].ToString();
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
					h.Focus();
					num = 33;
					continue;
				case 33:
					return;
				case 14:
					if (flag)
					{
						object value = Missing.Value;
						application = new ApplicationClass();
						Workbooks workbooks = application.Workbooks;
						CultureInfo currentCulture = new CultureInfo("en-US");
						Thread.CurrentThread.CurrentCulture = currentCulture;
						workbook = workbooks.Open(q, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
						worksheet = (Worksheet)workbook.ActiveSheet;
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
					n.Focus();
					num = 28;
					continue;
				case 28:
					return;
				case 2:
					application.Quit();
					Marshal.FinalReleaseComObject(application);
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
						worksheet.Cells[1, num2] = dataTable.Columns[num2 - 1].ColumnName;
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
		while (true)
		{
			DialogResult dialogResult = o.ShowDialog();
			bool flag = dialogResult != DialogResult.OK;
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
					j.Text = o.FileName;
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
					flag = !(q == o.FileName);
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						flag = !(o.FileName != "");
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
		System.Data.DataTable dataTable = default;
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
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
