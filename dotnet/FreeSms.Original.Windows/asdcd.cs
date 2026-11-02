using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdcd : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private UIButton m_f;

	private UIButton m_g;

	private Panel h;

	private UIButton i;

	private UIButton j;

	private Label k;

	private EditBox l;

	private UIButton m;

	private Label n;

	private Panel o;

	private string p;
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
						num = 0;
					}
					continue;
				case 3:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 0:
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

	private void b()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdcd));
		this.m_b = new GridEX();
		this.m_c = new Panel();
		n = new Label();
		i = new UIButton();
		h = new Panel();
		m = new UIButton();
		j = new UIButton();
		k = new Label();
		l = new EditBox();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_f = new UIButton();
		this.m_g = new UIButton();
		o = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		h.SuspendLayout();
		this.m_d.SuspendLayout();
		o.SuspendLayout();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(8, 51);
		this.m_b.Name = "gridEX1";
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(275, 341);
		this.m_b.TabIndex = 5;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(h);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_b);
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(5, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(289, 487);
		this.m_c.TabIndex = 0;
		n.AutoSize = true;
		n.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(94, 6);
		n.Name = "label4";
		n.Size = new Size(110, 33);
		n.TabIndex = 17;
		n.Text = "لیست پایه ها";
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		i.Location = new Point(6, 445);
		i.Name = "btnClose";
		i.Size = new Size(274, 36);
		i.TabIndex = 15;
		i.Text = "خروج";
		i.Click += c;
		h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		h.Controls.Add(m);
		h.Controls.Add(j);
		h.Controls.Add(k);
		h.Controls.Add(l);
		h.Location = new Point(16, 176);
		h.Name = "pcls";
		h.Size = new Size(260, 104);
		h.TabIndex = 10;
		h.Visible = false;
		m.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		m.Location = new Point(18, 53);
		m.Name = "btnCancel";
		m.Size = new Size(75, 35);
		m.TabIndex = 16;
		m.Text = "انصراف";
		m.Click += b;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		j.Location = new Point(99, 53);
		j.Name = "btnAcp";
		j.Size = new Size(75, 35);
		j.TabIndex = 14;
		j.Text = "تایید";
		j.Click += d;
		k.AutoSize = true;
		k.Location = new Point(203, 17);
		k.Name = "label1";
		k.Size = new Size(52, 26);
		k.TabIndex = 1;
		k.Text = "نام پایه";
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new Point(0, 0);
		l.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.Location = new Point(3, 12);
		l.Name = "txtNam";
		l.Size = new Size(194, 31);
		l.TabIndex = 0;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Location = new Point(1, 395);
		this.m_d.Name = "p_new";
		this.m_d.Size = new Size(282, 45);
		this.m_d.TabIndex = 9;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_e.Location = new Point(6, 6);
		this.m_e.Name = "btnDelete";
		this.m_e.Size = new Size(77, 36);
		this.m_e.TabIndex = 2;
		this.m_e.Text = "حذف";
		this.m_e.Click += a;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_f.Location = new Point(188, 6);
		this.m_f.Name = "btnNew";
		this.m_f.Size = new Size(86, 36);
		this.m_f.TabIndex = 0;
		this.m_f.Text = "جدید";
		this.m_f.Click += f;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_g.Location = new Point(93, 6);
		this.m_g.Name = "btnEdit";
		this.m_g.Size = new Size(81, 36);
		this.m_g.TabIndex = 1;
		this.m_g.Text = "اصلاح";
		this.m_g.Click += e;
		o.BackColor = SystemColors.ControlText;
		o.Controls.Add(this.m_c);
		o.Dock = DockStyle.Fill;
		o.Location = new Point(0, 0);
		o.Name = "panel2";
		o.Size = new Size(300, 500);
		o.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(300, 500);
		Controls.Add(o);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmPaye";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست پایه ها";
		Load += g;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		h.ResumeLayout(performLayout: false);
		h.PerformLayout();
		this.m_d.ResumeLayout(performLayout: false);
		o.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdcd()
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
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
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto IL_0129;
				case 6:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				case 5:
					if (1 == 0)
					{
					}
					goto IL_0129;
				case 2:
					{
						num = 0;
						continue;
					}
					IL_0129:
					a();
					num = 6;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tPaye where id in(" + asdaj.n + ")");
		this.m_b.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		p = "insert";
		h.Visible = true;
		l.Text = "";
		l.Focus();
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_b.RowCount <= 0;
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
					p = "update";
					h.Visible = true;
					l.Text = this.m_b.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
					l.Select();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string text = "0";
			bool flag = !(l.Text.Trim() == "");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					flag = !(p == "update");
					num = 0;
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'" + asdaj.b(l.Text) + "')");
					l.Text = "";
					l.Focus();
					if (true)
					{
					}
					num = 5;
					continue;
				case 1:
					text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, " update tPaye set name=N'" + asdaj.b(l.Text) + "',xExportRpt=null where id=" + text);
					h.Visible = false;
					num = 7;
					continue;
				case 6:
					MessageBox.Show("نام پایه را وارد کنید");
					l.Focus();
					num = 8;
					continue;
				case 8:
					return;
				case 5:
				case 7:
					a();
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = !(p == "insert");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		h.Visible = false;
	}

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		string text2 = default;
		string text = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					num = ((this.m_b.RowCount <= 0) ? 3 : 11);
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 15;
				case 14:
					if (flag)
					{
						flag = MessageBox.Show("آيا از حذف پایه مطمئن هستيد؟", "حذف پایه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 0;
					}
					else
					{
						num = 13;
					}
					continue;
				case 3:
					num2 = 1;
					goto IL_029f;
				case 5:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tPaye where id=" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 15;
					continue;
				case 11:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_029f;
				case 13:
					MessageBox.Show("تعداد " + text2 + " صنف در این پایه وجود دارد.امکان حذف وجود ندارد");
					num = 10;
					continue;
				case 10:
					if (1 == 0)
					{
					}
					return;
				case 15:
					num = 9;
					continue;
				case 9:
					return;
				case 7:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tStudent WHERE xPaye =" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountClass FROM tClass WHERE xPaye =" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
						flag = !(text2 != "0");
						num = 14;
					}
					else
					{
						num = 12;
					}
					continue;
				case 8:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 12:
					MessageBox.Show("تعداد " + text + " شاگرد در این پایه وجود دارد.امکان حذف وجود ندارد");
					num = 4;
					continue;
				case 4:
					return;
					IL_029f:
					flag = (byte)num2 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}
}
