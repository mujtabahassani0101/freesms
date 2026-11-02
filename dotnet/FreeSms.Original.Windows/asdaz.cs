using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

public class asdaz : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private IContainer m_b = null;

	private Panel m_c;

	private Panel d;

	private Panel e;

	private Label f;

	private UIButton g;

	private GridEX h;

	private UIComboBox i;

	private Label j;

	private Label k;

	private Label l;

	public asdaz()
	{
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 0:
					try
					{
						i.SelectedIndex = 0;
						b();
						h.CurrentColumn = h.GetRow(0).Cells["sort"].Column;
						h.Select();
						h.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 1;
					continue;
				case 3:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 8;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 5;
					continue;
				case 5:
					return;
				case 8:
					k.Text = asdaj.__field_a;
					c();
					num = 0;
					continue;
				case 1:
					return;
				case 4:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						e.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 8;
					continue;
				case 6:
					num = 4;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + k.Text + " and xPaye in(" + asdaj.n + ") order by xpaye,sortRpt");
		i.DataSource = dataSource;
		i.DisplayMember = "Name";
		i.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tYear_Student.id, tYear_Student.sort, tYear_Student.shaghe,  tYear_Student.hazer,\r\n                          tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Code, tStudent.NumberAsas\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE     (tYear_Student.xYear = " + k.Text + ") AND (tYear_Student.xClass = " + i.SelectedValue.ToString() + ")");
		h.DataSource = dataSource;
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		while (true)
		{
			bool flag = !(A_1.Column.Key == "sort");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = !(A_1.Column.Key == "shaghe");
					num = 3;
					continue;
				case 7:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 8:
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set shaghe=" + h.GetRow(h.Row).Cells["shaghe"].Value.ToString().Replace("True", "1").Replace("False", "0") + " where id=" + h.GetRow(h.Row).Cells["id"].Value.ToString());
					num = 0;
					continue;
				case 0:
					return;
				case 1:
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set sort=" + h.GetRow(h.Row).Cells["sort"].Value.ToString() + " where id=" + h.GetRow(h.Row).Cells["id"].Value.ToString());
					num = 6;
					continue;
				case 6:
					return;
				case 2:
					if (true)
					{
					}
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set hazer=" + h.GetRow(h.Row).Cells["hazer"].Value.ToString().Replace("True", "1").Replace("False", "0") + " where id=" + h.GetRow(h.Row).Cells["id"].Value.ToString());
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					if (flag)
					{
						flag = !(A_1.Column.Key == "hazer");
						num = 7;
					}
					else
					{
						num = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
		try
		{
			if (true)
			{
			}
			h.CurrentColumn = h.GetRow(0).Cells["sort"].Column;
			h.Select();
			h.SelectCurrentCellText();
		}
		catch
		{
		}
	}
protected override void Dispose(bool A_0)
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
					num = ((!A_0) ? 3 : 2);
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 4:
					this.m_b.Dispose();
					num = 6;
					continue;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 6;
				case 3:
					num2 = 1;
					goto IL_0074;
				case 6:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 1;
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
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdaz));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_c = new Panel();
		d = new Panel();
		e = new Panel();
		k = new Label();
		l = new Label();
		i = new UIComboBox();
		j = new Label();
		f = new Label();
		g = new UIButton();
		h = new GridEX();
		this.m_c.SuspendLayout();
		d.SuspendLayout();
		e.SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		SuspendLayout();
		this.m_c.BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(586, 600);
		this.m_c.TabIndex = 0;
		d.BackColor = Color.Black;
		d.Controls.Add(e);
		d.Dock = DockStyle.Fill;
		d.Location = new Point(0, 0);
		d.Name = "panel2";
		d.Size = new Size(584, 598);
		d.TabIndex = 44;
		e.BackColor = Color.FromArgb(214, 223, 247);
		e.Controls.Add(k);
		e.Controls.Add(l);
		e.Controls.Add(i);
		e.Controls.Add(j);
		e.Controls.Add(f);
		e.Controls.Add(g);
		e.Controls.Add(h);
		e.Location = new Point(3, 3);
		e.Name = "panel3";
		e.Size = new Size(578, 592);
		e.TabIndex = 0;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Location = new Point(245, 12);
		k.Name = "lYear";
		k.Size = new Size(55, 24);
		k.TabIndex = 118;
		l.AutoSize = true;
		l.Location = new Point(310, 12);
		l.Name = "label3";
		l.Size = new Size(86, 24);
		l.TabIndex = 117;
		l.Text = "سال تعلیمی";
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		i.DropListFont = new Font("B Nazanin", 12f);
		i.Location = new Point(11, 8);
		i.Name = "dropCls";
		i.Size = new Size(142, 31);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		i.StringFormat = stringFormat;
		i.TabIndex = 52;
		i.SelectedIndexChanged += a;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.AutoSize = true;
		j.Location = new Point(160, 12);
		j.Name = "label19";
		j.Size = new Size(39, 24);
		j.TabIndex = 51;
		j.Text = "صنف";
		f.AutoSize = true;
		f.Font = new Font("B Nazanin", 14f);
		f.ForeColor = Color.DarkViolet;
		f.Location = new Point(421, 10);
		f.Name = "label7";
		f.Size = new Size(149, 28);
		f.TabIndex = 50;
		f.Text = "مدیریت شقه های صنف";
		g.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		g.DialogResult = DialogResult.Cancel;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(40, 40);
		g.Location = new Point(11, 552);
		g.Name = "btnClose";
		g.Size = new Size(93, 35);
		g.TabIndex = 44;
		g.Text = "بستن";
		g.Click += b;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		h.DesignTimeLayout = gridEXLayout;
		h.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		h.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.GroupByBoxVisible = false;
		h.Location = new Point(8, 56);
		h.Name = "gridEX1";
		h.RecordNavigator = true;
		h.RowHeaders = InheritableBoolean.True;
		h.SelectedFormatStyle.BackColor = Color.Empty;
		h.SelectedFormatStyle.ForeColor = Color.Empty;
		h.Size = new Size(562, 489);
		h.TabIndex = 45;
		h.VisualStyle = VisualStyle.Office2003;
		h.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(586, 600);
		Controls.Add(this.m_c);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmshaghe";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += c;
		this.m_c.ResumeLayout(performLayout: false);
		d.ResumeLayout(performLayout: false);
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		((ISupportInitialize)h).EndInit();
		ResumeLayout(performLayout: false);
	}
}
