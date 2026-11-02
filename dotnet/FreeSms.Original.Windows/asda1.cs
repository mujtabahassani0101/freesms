using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asda1 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Label m_d;

	private Label m_e;

	private MaskedEditBox m_f;

	private TextBox m_g;

	private Label m_h;

	private UIButton i;

	private UIButton j;

	private Panel k;

	private GridEX l;

	private UIButton m;

	private UIButton n;

	private UIButton o;

	private Panel p;

	private UIButton q;

	private Panel r;

	private Label s;

	private string t = "insert";

	private int u;
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 1;
					}
					continue;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 4;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda1));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		r = new Panel();
		p = new Panel();
		o = new UIButton();
		n = new UIButton();
		m = new UIButton();
		q = new UIButton();
		k = new Panel();
		this.m_c = new Panel();
		this.m_d = new Label();
		this.m_e = new Label();
		this.m_f = new MaskedEditBox();
		this.m_g = new TextBox();
		this.m_h = new Label();
		i = new UIButton();
		j = new UIButton();
		l = new GridEX();
		s = new Label();
		this.m_b.SuspendLayout();
		r.SuspendLayout();
		p.SuspendLayout();
		k.SuspendLayout();
		this.m_c.SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.ControlText;
		this.m_b.Controls.Add(r);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(424, 454);
		this.m_b.TabIndex = 31;
		r.BackColor = SystemColors.GradientInactiveCaption;
		r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		r.Controls.Add(s);
		r.Controls.Add(p);
		r.Controls.Add(q);
		r.Controls.Add(k);
		r.Controls.Add(l);
		r.Font = new Font("Tahoma", 8.25f);
		r.Location = new Point(5, 5);
		r.Name = "panel3";
		r.Size = new Size(414, 444);
		r.TabIndex = 0;
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p.Controls.Add(o);
		p.Controls.Add(n);
		p.Controls.Add(m);
		p.Location = new Point(142, 389);
		p.Name = "p_new";
		p.Size = new Size(258, 43);
		p.TabIndex = 29;
		o.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		o.Location = new Point(3, 6);
		o.Name = "btnDelete";
		o.Size = new Size(78, 34);
		o.TabIndex = 2;
		o.Text = "حذف";
		o.Click += a;
		n.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		n.Location = new Point(170, 6);
		n.Name = "btnNew";
		n.Size = new Size(85, 34);
		n.TabIndex = 0;
		n.Text = "جدید";
		n.Click += g;
		m.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		m.Location = new Point(87, 6);
		m.Name = "btnEdit";
		m.Size = new Size(77, 34);
		m.TabIndex = 1;
		m.Text = "اصلاح";
		m.Click += d;
		q.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		q.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		q.ImageSize = new Size(40, 40);
		q.Location = new Point(16, 392);
		q.Name = "btnClose";
		q.Size = new Size(110, 40);
		q.TabIndex = 30;
		q.Text = "بستن";
		q.Click += b;
		k.BackColor = Color.Gray;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Controls.Add(this.m_c);
		k.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(18, 160);
		k.Name = "pStd";
		k.Size = new Size(375, 207);
		k.TabIndex = 0;
		k.Visible = false;
		this.m_c.BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Controls.Add(this.m_g);
		this.m_c.Controls.Add(this.m_h);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(j);
		this.m_c.Location = new Point(6, 7);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(359, 189);
		this.m_c.TabIndex = 40;
		this.m_d.AutoSize = true;
		this.m_d.Location = new Point(149, 81);
		this.m_d.Name = "label6";
		this.m_d.Size = new Size(28, 28);
		this.m_d.TabIndex = 50;
		this.m_d.Text = "نفر";
		this.m_e.AutoSize = true;
		this.m_e.Location = new Point(257, 81);
		this.m_e.Name = "label5";
		this.m_e.Size = new Size(87, 28);
		this.m_e.TabIndex = 49;
		this.m_e.Text = "ظرفیت حوزه";
		this.m_f.AutoScroll = false;
		this.m_f.AutoScrollMargin = new Size(0, 0);
		this.m_f.AutoScrollMinSize = new Size(0, 0);
		this.m_f.AutoScrollPosition = new Point(0, 0);
		this.m_f.Location = new Point(188, 77);
		this.m_f.MaxLength = 3;
		this.m_f.Name = "txtCapacity";
		this.m_f.Numeric = true;
		this.m_f.Size = new Size(64, 36);
		this.m_f.TabIndex = 3;
		this.m_f.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_g.Location = new Point(16, 28);
		this.m_g.Name = "txtName";
		this.m_g.Size = new Size(237, 36);
		this.m_g.TabIndex = 2;
		this.m_h.AutoSize = true;
		this.m_h.Location = new Point(258, 32);
		this.m_h.Name = "label2";
		this.m_h.Size = new Size(61, 28);
		this.m_h.TabIndex = 42;
		this.m_h.Text = "نام حوزه";
		i.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		i.Location = new Point(97, 129);
		i.Name = "btnCancel";
		i.Size = new Size(75, 38);
		i.TabIndex = 5;
		i.Text = "انصراف";
		i.Click += f;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		j.Location = new Point(178, 129);
		j.Name = "btnAcp";
		j.Size = new Size(75, 38);
		j.TabIndex = 4;
		j.Text = "تایید";
		j.Click += e;
		l.AllowEdit = InheritableBoolean.False;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		l.DesignTimeLayout = gridEXLayout;
		l.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		l.Font = new Font("B Nazanin", 12f);
		l.GroupByBoxVisible = false;
		l.Location = new Point(16, 56);
		l.Name = "gridEX1";
		l.RecordNavigator = true;
		l.RightToLeft = RightToLeft.Yes;
		l.RowHeaders = InheritableBoolean.True;
		l.Size = new Size(380, 325);
		l.TabIndex = 1;
		l.VisualStyle = VisualStyle.Office2003;
		l.SelectionChanged += c;
		s.AutoSize = true;
		s.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s.Location = new Point(124, 15);
		s.Name = "label4";
		s.Size = new Size(168, 23);
		s.TabIndex = 86;
		s.Text = "تعریف حوزه امتحانی";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(424, 454);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmHozeh";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "تعریف حوزه امتحانی";
		Load += h;
		this.m_b.ResumeLayout(performLayout: false);
		r.ResumeLayout(performLayout: false);
		r.PerformLayout();
		p.ResumeLayout(performLayout: false);
		k.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)l).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asda1()
	{
		d();
	}

	private void h(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("14");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 4;
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
						r.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto IL_0129;
				case 7:
					return;
				case 4:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					if (1 == 0)
					{
					}
					goto IL_0129;
				case 6:
					{
						num = 0;
						continue;
					}
					IL_0129:
					c();
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			int num = u;
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    id,Name, Capacity   FROM  tHozeh");
			l.DataSource = dataSource;
			int num2 = 0;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					num2 = ((!(t == "update")) ? 4 : 13);
					continue;
				case 11:
					num3 = 1;
					goto IL_00eb;
				case 3:
					num2 = ((t == "update") ? 2 : 11);
					continue;
				case 4:
					num4 = 1;
					goto IL_01aa;
				case 12:
					if (!flag)
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				case 13:
					num2 = 6;
					continue;
				case 6:
					num4 = ((l.RecordCount <= num) ? 1 : 0);
					goto IL_01aa;
				case 2:
					num2 = 9;
					continue;
				case 9:
					num3 = ((l.RecordCount != num) ? 1 : 0);
					goto IL_00eb;
				case 5:
					l.Focus();
					l.Row = num - 1;
					num2 = 8;
					continue;
				case 1:
					l.Focus();
					l.Row = num;
					num2 = 7;
					continue;
				case 10:
					num2 = ((!flag) ? 1 : 3);
					continue;
				case 7:
				case 8:
					{
						t = "insert";
						return;
					}
					IL_00eb:
					flag = (byte)num3 != 0;
					num2 = 12;
					continue;
					IL_01aa:
					flag = (byte)num4 != 0;
					if (true)
					{
					}
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		t = "insert";
		k.Visible = true;
		this.m_g.Text = "";
		this.m_g.Focus();
	}

	private void f(object A_0, EventArgs A_1)
	{
		k.Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		string a_ = default;
		int num2 = default;
		while (true)
		{
			bool flag = !(asdaj.b(this.m_g.Text) == "");
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = !(asdaj.b(this.m_f.Text) == "");
					num = 1;
					continue;
				case 5:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 7:
				{
					SqlParameter[] array = new SqlParameter[5]
					{
						asdcb.a("@Code", SqlDbType.Int, null),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(this.m_g.Text)),
						asdcb.a("@Capacity", SqlDbType.Int, asdaj.b(this.m_f.Text)),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, t)
					};
					array[0].Direction = ParameterDirection.InputOutput;
					num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tHozeh_InsertUpdate", array);
					flag = !(array[0].Value.ToString() == "0");
					num = 2;
					continue;
				}
				case 2:
					if (flag)
					{
						flag = num2 <= 0;
						num = 5;
					}
					else
					{
						num = 14;
					}
					continue;
				case 14:
					if (true)
					{
					}
					MessageBox.Show("نام حوزه تکراری است");
					this.m_g.SelectAll();
					num = 13;
					continue;
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					a_ = "0";
					flag = !(t == "update");
					num = 9;
					continue;
				case 17:
					k.Visible = false;
					num = 0;
					continue;
				case 10:
					MessageBox.Show("نام حوزه را وارد کنید");
					this.m_g.Focus();
					num = 15;
					continue;
				case 15:
					return;
				case 11:
					flag = !(t == "update");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 0;
				case 0:
					c();
					b();
					num = 4;
					continue;
				case 4:
					return;
				case 6:
					a_ = l.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 7;
					continue;
				case 3:
					MessageBox.Show("ظرفیت حوزه را وارد کنید");
					this.m_f.Focus();
					num = 16;
					continue;
				case 16:
					return;
				case 13:
					return;
				case 9:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 7;
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
		this.m_g.Text = "";
		this.m_g.Focus();
	}

	private void a()
	{
		if (true)
		{
		}
		this.m_g.Text = l.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
		this.m_f.Text = l.SelectedItems[0].GetRow().Cells["Capacity"].Value.ToString();
		this.m_g.Focus();
		this.m_g.SelectAll();
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		t = "update";
		k.Visible = true;
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		u = l.Row;
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 9;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 9:
					if (l.RowCount > 0)
					{
						num = 6;
						continue;
					}
					goto IL_0226;
				case 2:
					return;
				case 12:
					flag = MessageBox.Show(" این حوزه داری شاگرد است. آیا اطمینان به حذف حوزه دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
					num = 5;
					continue;
				case 5:
					num = ((!flag) ? 10 : 2);
					continue;
				case 13:
					num = 1;
					continue;
				case 1:
					num2 = ((MessageBox.Show("آيا از حذف حوزه مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1 : 0);
					goto IL_01f9;
				case 11:
					num = 8;
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					if (l.SelectedItems[0].RowType == RowType.Record)
					{
						num = 13;
						continue;
					}
					goto IL_0226;
				case 10:
					asdcb.d(asdab.e(), CommandType.Text, "update tstudent set idx=null,xhozeh=null where xhozeh=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					num = 11;
					continue;
				case 8:
					asdcb.d(asdab.e(), CommandType.Text, "delete from thozeh where id=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					c();
					num = 7;
					continue;
				case 7:
					return;
				case 0:
					if (!flag)
					{
						num = 15;
						continue;
					}
					return;
				case 15:
				{
					if (true)
					{
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tstudent where xHozeh=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 14;
					continue;
				}
				case 4:
					num2 = 1;
					goto IL_01f9;
				case 14:
					{
						if (!flag)
						{
							num = 12;
							continue;
						}
						goto case 8;
					}
					IL_0226:
					num = 4;
					continue;
					IL_01f9:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}
}
