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

public class asdau : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private bool m_b = true;

	private int m_c;

	private bool m_d = false;

	private IContainer e = null;

	private Panel f;

	private Panel g;

	private Panel h;

	private UIButton i;

	private GridEX j;

	private UIComboBox k;

	private Label l;

	private UIButton m;

	private Label n;

	private Label o;

	private Label p;

	public asdau()
	{
		a();
	}

	private void d(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("12");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 3:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						h.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 6;
				case 6:
					this.m_b = true;
					n.Text = asdaj.__field_a;
					c();
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 7;
					continue;
				case 7:
					return;
				case 0:
					num = 3;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + n.Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
		k.DataSource = dataSource;
		k.DisplayMember = "Name";
		k.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT   tYear_Student.id, tYear_Student.sort,      tYear_Student.ShowSarbarg1, tYear_Student.ShowSarbarg2, tYear_Student.ShowSarbarg3, tYear_Student.ShowSarbarg4, tYear_Student.ShowSarbarg6, \r\n                      tYear_Student.ShowSarbarg7,  tStudent.FName+ ' '+ tStudent.LName as Fullname,  tStudent.NumberAsas\r\n,case tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک'  when 4 then N'معذرتی' end as vazeyat\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE (tYear_Student.xYear = " + n.Text + ") AND (tYear_Student.xClass = " + k.SelectedValue.ToString() + ")");
		j.DataSource = dataSource;
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		this.m_b = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_b;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 10;
				case 8:
					try
					{
						j.CurrentColumn = j.GetRow(0).Cells["ghayeb"].Column;
						j.Select();
						j.SelectCurrentCellText();
					}
					catch
					{
					}
					if (true)
					{
					}
					this.m_c = k.SelectedIndex;
					num = 7;
					continue;
				case 2:
					this.m_d = false;
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					flag = !this.m_d;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 1;
					continue;
				case 10:
					this.m_d = false;
					this.m_b = true;
					b();
					num = 8;
					continue;
				case 7:
					return;
				case 9:
					this.m_d = true;
					k.SelectedIndex = this.m_c;
					num = 0;
					continue;
				case 0:
					return;
				case 1:
					num = ((!flag) ? 9 : 10);
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			int num = 0;
			if (true)
			{
			}
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 3:
					flag = num < j.RowCount;
					num2 = 0;
					continue;
				case 0:
				{
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					text = j.GetRow(num).Cells["ShowSarbarg1"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text2 = j.GetRow(num).Cells["ShowSarbarg2"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text3 = j.GetRow(num).Cells["ShowSarbarg3"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text4 = j.GetRow(num).Cells["ShowSarbarg4"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text5 = j.GetRow(num).Cells["ShowSarbarg6"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text6 = j.GetRow(num).Cells["ShowSarbarg7"].Value.ToString().Replace("True", "1").Replace("False", "0");
					int num3 = asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set ShowSarbarg1=" + text + ",ShowSarbarg2=" + text2 + ",ShowSarbarg3=" + text3 + ",ShowSarbarg4=" + text4 + ",ShowSarbarg6=" + text5 + ",ShowSarbarg7=" + text6 + " where id=" + j.GetRow(num).Cells["id"].Value.ToString());
					num++;
					num2 = 2;
					continue;
				}
				case 1:
					MessageBox.Show("انجام شد");
					this.m_b = true;
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.F5;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					j.Refresh();
					a((object)this, (EventArgs)null);
					num = 0;
					continue;
				case 0:
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
			bool flag = this.m_b;
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
				case 5:
					return;
				case 4:
					A_1.Cancel = true;
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 0;
					continue;
				case 0:
					num = ((!flag) ? 4 : 5);
					continue;
				}
				break;
			}
		}
	}
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (true)
					{
					}
					num = ((!A_0) ? 1 : 3);
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((e == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					e.Dispose();
					num = 5;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 2;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdau));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		f = new Panel();
		g = new Panel();
		h = new Panel();
		p = new Label();
		m = new UIButton();
		n = new Label();
		o = new Label();
		k = new UIComboBox();
		l = new Label();
		i = new UIButton();
		j = new GridEX();
		f.SuspendLayout();
		g.SuspendLayout();
		h.SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		SuspendLayout();
		f.BackColor = Color.FromArgb(214, 223, 247);
		f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		f.Controls.Add(g);
		f.Dock = DockStyle.Fill;
		f.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		f.Location = new Point(0, 0);
		f.Name = "panel1";
		f.Size = new Size(719, 671);
		f.TabIndex = 0;
		g.BackColor = Color.Black;
		g.Controls.Add(h);
		g.Dock = DockStyle.Fill;
		g.Location = new Point(0, 0);
		g.Name = "panel2";
		g.Size = new Size(717, 669);
		g.TabIndex = 44;
		h.BackColor = Color.FromArgb(214, 223, 247);
		h.Controls.Add(p);
		h.Controls.Add(m);
		h.Controls.Add(n);
		h.Controls.Add(o);
		h.Controls.Add(k);
		h.Controls.Add(l);
		h.Controls.Add(i);
		h.Controls.Add(j);
		h.Location = new Point(3, 3);
		h.Name = "panel3";
		h.Size = new Size(711, 663);
		h.TabIndex = 0;
		p.AutoSize = true;
		p.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.ForeColor = Color.DarkViolet;
		p.Location = new Point(140, 2);
		p.Name = "label7";
		p.Size = new Size(423, 33);
		p.TabIndex = 121;
		p.Text = "فعال / غیرفعال کردن چاپ دانش آموزان در بخش طراحی";
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		m.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		m.ImageIndex = 8;
		m.Location = new Point(548, 620);
		m.Name = "btnAcp";
		m.RightToLeft = RightToLeft.Yes;
		m.Size = new Size(153, 40);
		m.TabIndex = 120;
		m.Text = "ثبت (F5)";
		m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		m.Click += a;
		n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		n.Location = new Point(11, 43);
		n.Name = "lYear";
		n.Size = new Size(59, 24);
		n.TabIndex = 118;
		o.AutoSize = true;
		o.Location = new Point(76, 43);
		o.Name = "label3";
		o.Size = new Size(78, 26);
		o.TabIndex = 117;
		o.Text = "سال تعلیمی\r\n";
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		k.DropListFont = new Font("B Nazanin", 12f);
		k.Location = new Point(384, 38);
		k.Name = "dropCls";
		k.Size = new Size(273, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		k.StringFormat = stringFormat;
		k.TabIndex = 52;
		k.SelectedIndexChanged += b;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoSize = true;
		l.Location = new Point(663, 44);
		l.Name = "label19";
		l.Size = new Size(41, 26);
		l.TabIndex = 51;
		l.Text = "صنف";
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		i.DialogResult = DialogResult.Cancel;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		i.Location = new Point(11, 623);
		i.Name = "btnClose";
		i.Size = new Size(93, 35);
		i.TabIndex = 44;
		i.Text = "بستن";
		i.Click += c;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		j.DesignTimeLayout = gridEXLayout;
		j.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		j.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		j.Font = new Font("Tahoma", 9.75f);
		j.GroupByBoxVisible = false;
		j.Location = new Point(8, 76);
		j.Name = "gridEX1";
		j.RecordNavigator = true;
		j.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		j.SelectedFormatStyle.BackColor = Color.Empty;
		j.SelectedFormatStyle.ForeColor = Color.Empty;
		j.Size = new Size(700, 540);
		j.TabIndex = 45;
		j.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		j.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(719, 671);
		Controls.Add(f);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmActivStdSarbarg";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += d;
		KeyUp += a;
		FormClosing += a;
		f.ResumeLayout(performLayout: false);
		g.ResumeLayout(performLayout: false);
		h.ResumeLayout(performLayout: false);
		h.PerformLayout();
		((ISupportInitialize)j).EndInit();
		ResumeLayout(performLayout: false);
	}
}
