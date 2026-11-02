using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

public class asdbt : Form
{
	private Container m_a = null;

	private Panel m_b;

	private Panel c;

	private Label d;

	private Panel e;

	private GridEX f;

	private UIButton g;

	public asdbt()
	{
		b();
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
						num = 5;
						continue;
					}
					goto case 2;
				case 1:
					num = 2;
					continue;
				case 3:
					this.m_a.Dispose();
					num = 1;
					continue;
				case 5:
					flag = this.m_a == null;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 2:
					base.Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbt));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		c = new Panel();
		e = new Panel();
		g = new UIButton();
		d = new Label();
		f = new GridEX();
		this.m_b.SuspendLayout();
		c.SuspendLayout();
		e.SuspendLayout();
		((ISupportInitialize)f).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.Black;
		this.m_b.Controls.Add(c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel3";
		this.m_b.Size = new Size(312, 584);
		this.m_b.TabIndex = 17;
		c.BackColor = Color.SkyBlue;
		c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		c.Controls.Add(e);
		c.Location = new Point(4, 6);
		c.Name = "panel1";
		c.Size = new Size(303, 573);
		c.TabIndex = 17;
		e.BackColor = Color.FromArgb(214, 223, 247);
		e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		e.Controls.Add(g);
		e.Controls.Add(d);
		e.Controls.Add(f);
		e.Dock = DockStyle.Bottom;
		e.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		e.Location = new Point(0, -1);
		e.Name = "panel2";
		e.RightToLeft = RightToLeft.Yes;
		e.Size = new Size(301, 572);
		e.TabIndex = 16;
		g.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		g.DialogResult = DialogResult.Cancel;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(20, 20);
		g.Location = new Point(218, 11);
		g.Name = "btnClose";
		g.Size = new Size(64, 28);
		g.TabIndex = 50;
		g.Text = "بستن";
		g.Click += a;
		d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		d.AutoSize = true;
		d.Font = new Font("B Nazanin", 16f, FontStyle.Bold, GraphicsUnit.Point, 178);
		d.Location = new Point(53, 5);
		d.Name = "label5";
		d.Size = new Size(146, 35);
		d.TabIndex = 49;
		d.Text = "آیتم های ثبت نام";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.CardCaptionPrefix = "Product:";
		f.DataMember = null;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		f.DesignTimeLayout = gridEXLayout;
		f.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		f.FlatBorderColor = SystemColors.ControlDark;
		f.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		f.GridLineColor = SystemColors.ScrollBar;
		f.GroupByBoxVisible = false;
		f.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		f.Location = new Point(7, 43);
		f.Name = "gridx1";
		f.RightToLeft = RightToLeft.Yes;
		f.RowHeaders = InheritableBoolean.True;
		f.SelectedFormatStyle.Blend = 0.5f;
		f.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		f.Size = new Size(283, 521);
		f.TabIndex = 15;
		f.VisualStyleAreas.CheckBoxStyle = VisualStyle.Standard;
		f.VisualStyleAreas.ControlBorderStyle = VisualStyle.Standard;
		f.VisualStyleAreas.EditControlsStyle = VisualStyle.Standard;
		f.VisualStyleAreas.GroupByBoxStyle = VisualStyle.Standard;
		f.VisualStyleAreas.GroupRowsStyle = VisualStyle.Standard;
		f.VisualStyleAreas.HeadersStyle = VisualStyle.Office2003;
		f.VisualStyleAreas.ScrollBarsStyle = VisualStyle.Standard;
		f.VisualStyleAreas.TreeGliphsStyle = VisualStyle.Standard;
		f.CellUpdated += a;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.CornflowerBlue;
		ClientSize = new Size(312, 584);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSabtenamItemEnable";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست دروس";
		Load += b;
		this.m_b.ResumeLayout(performLayout: false);
		c.ResumeLayout(performLayout: false);
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		((ISupportInitialize)f).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT * from tItemSabtenamEnable");
		f.DataSource = dataSource;
	}

	private void b(object A_0, EventArgs A_1)
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
						num = 1;
						continue;
					}
					goto case 2;
				case 3:
					try
					{
						int num2 = int.Parse(dataTable.Rows[0]["R"].ToString());
						int num3 = int.Parse(dataTable.Rows[0]["G"].ToString());
						int num4 = int.Parse(dataTable.Rows[0]["B"].ToString());
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 2;
					continue;
				case 1:
					num = 3;
					continue;
				case 2:
					a();
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		while (true)
		{
			bool flag = !(A_1.Column.Key == "Enable");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					if (true)
					{
					}
					asdcb.d(asdab.e(), CommandType.Text, "update tItemSabtenamEnable set Enable=" + f.GetRow(f.Row).Cells["Enable"].Value.ToString().Replace("True", "1").Replace("False", "0") + " where id=" + f.GetRow(f.Row).Cells["id"].Value.ToString());
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}
}
