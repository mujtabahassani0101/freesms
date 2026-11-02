using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdr : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private UIButton m_d;

	private Label e;

	private Panel f;

	private UIButton g;

	private EditBox h;

	private Label i;

	private ComboBox j;

	private Label k;

	private Label l;

	private bool m;

	private SqlConnection n = new SqlConnection(asdab.e());
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 2;
					}
					continue;
				case 3:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 5;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdr));
		this.m_b = new GridEX();
		this.m_c = new Panel();
		k = new Label();
		l = new Label();
		j = new ComboBox();
		i = new Label();
		e = new Label();
		this.m_d = new UIButton();
		g = new UIButton();
		f = new Panel();
		h = new EditBox();
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		f.SuspendLayout();
		SuspendLayout();
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		this.m_b.Font = new Font("B Nazanin", 12f);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(8, 81);
		this.m_b.Name = "gridEX1";
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(368, 316);
		this.m_b.TabIndex = 5;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(e);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(this.m_b);
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(5, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(386, 488);
		this.m_c.TabIndex = 0;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Location = new Point(14, 8);
		k.Name = "lYear";
		k.Size = new Size(55, 24);
		k.TabIndex = 118;
		l.AutoSize = true;
		l.Location = new Point(75, 7);
		l.Name = "label3";
		l.Size = new Size(78, 26);
		l.TabIndex = 117;
		l.Text = "سال تعلیمی";
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.DropDownStyle = ComboBoxStyle.DropDownList;
		j.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j.FormattingEnabled = true;
		j.Location = new Point(9, 43);
		j.Name = "dropPayeSeacrch";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(295, 31);
		j.TabIndex = 85;
		j.SelectedValueChanged += a;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoSize = true;
		i.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(309, 44);
		i.Name = "label1";
		i.Size = new Size(42, 26);
		i.TabIndex = 50;
		i.Text = "پایه  :";
		e.AutoSize = true;
		e.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		e.ForeColor = Color.DarkViolet;
		e.Location = new Point(241, 3);
		e.Name = "label4";
		e.Size = new Size(124, 33);
		e.TabIndex = 17;
		e.Text = "لیست صنف ها";
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		this.m_d.Location = new Point(8, 446);
		this.m_d.Name = "btnClose";
		this.m_d.Size = new Size(369, 38);
		this.m_d.TabIndex = 15;
		this.m_d.Text = "خروج";
		this.m_d.Click += b;
		g.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		g.Location = new Point(9, 403);
		g.Name = "btnAcp";
		g.Size = new Size(368, 39);
		g.TabIndex = 14;
		g.Text = "ثبت اولویت";
		g.Click += c;
		f.BackColor = SystemColors.ControlText;
		f.Controls.Add(this.m_c);
		f.Dock = DockStyle.Fill;
		f.Location = new Point(0, 0);
		f.Name = "panel2";
		f.Size = new Size(395, 500);
		f.TabIndex = 1;
		h.AutoScroll = false;
		h.AutoScrollMargin = new Size(0, 0);
		h.AutoScrollMinSize = new Size(0, 0);
		h.AutoScrollPosition = new Point(0, 0);
		h.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.Location = new Point(14, 55);
		h.Name = "txtNam";
		h.Size = new Size(184, 33);
		h.TabIndex = 0;
		h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		AcceptButton = g;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(395, 500);
		Controls.Add(f);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmClsSort";
		RightToLeft = RightToLeft.Yes;
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست صنف ها";
		Load += d;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		f.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdr()
	{
		c();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 2;
				case 1:
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
					if (true)
					{
					}
					num = 2;
					continue;
				case 3:
					num = 1;
					continue;
				case 2:
					k.Text = asdaj.__field_a;
					m = false;
					b();
					m = true;
					a();
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					dictionary.Add(dataTable.Rows[num]["id"].ToString(), dataTable.Rows[num]["name"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 1;
					continue;
				case 2:
					j.DataSource = new BindingSource(dictionary, null);
					j.DisplayMember = "Value";
					j.ValueMember = "Key";
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
			bool flag = m;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 4;
						continue;
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * from tclass where  xYear=" + k.Text + " and xpaye=" + j.SelectedValue);
					this.m_b.DataSource = dataSource;
					num = 3;
					continue;
				}
				case 3:
					try
					{
						this.m_b.CurrentColumn = this.m_b.GetRow(0).Cells["sortBarchasb"].Column;
						this.m_b.Select();
						this.m_b.SelectCurrentCellText();
						this.m_b.Refresh();
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 0;
					continue;
				case 4:
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			SqlCommand sqlCommand = null;
			string text = "";
			n.Open();
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 6:
					sqlCommand.ExecuteNonQuery();
					num++;
					num2 = 4;
					continue;
				case 4:
					if (1 == 0)
					{
					}
					goto case 0;
				case 7:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@sortBarchasb", this.m_b.GetRow(num).Cells["sortBarchasb"].Text.ToString());
						num2 = 3;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 0:
					flag = num < this.m_b.RowCount;
					num2 = 1;
					continue;
				case 1:
					if (flag)
					{
						text = this.m_b.GetRow(num).Cells["sortBarchasb"].Text.ToString();
						sqlCommand = new SqlCommand("update tclass set sortBarchasb=@sortBarchasb where id=@id", n);
						sqlCommand.Parameters.AddWithValue("@id", this.m_b.GetRow(num).Cells["id"].Text.ToString());
						flag = !(text == "");
						num2 = 7;
					}
					else
					{
						num2 = 2;
					}
					continue;
				case 5:
					sqlCommand.Parameters.AddWithValue("@sortBarchasb", DBNull.Value);
					num2 = 6;
					continue;
				case 2:
					n.Close();
					MessageBox.Show("ثبت شد");
					a();
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		a();
	}
}
