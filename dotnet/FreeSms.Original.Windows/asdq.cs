using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdq : Form
{
	private string m_a = "insert";

	private int m_b;

	private IContainer m_c = null;

	private Panel m_d;

	private Panel m_e;

	private Label m_f;

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

	private NumericEditBox t;

	public asdq()
	{
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		d();
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			int num = this.m_b;
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    *   FROM  tDisciplinaryCases where typ=3");
			l.DataSource = dataSource;
			int num2 = 6;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 6:
					num2 = ((!(this.m_a == "update")) ? 4 : 11);
					continue;
				case 9:
					num3 = 1;
					goto IL_00f6;
				case 7:
					num2 = ((this.m_a == "update") ? 2 : 9);
					continue;
				case 4:
					num4 = 1;
					goto IL_01b5;
				case 12:
					if (!flag)
					{
						num2 = 13;
						continue;
					}
					goto case 1;
				case 11:
					num2 = 10;
					continue;
				case 10:
					num4 = ((l.RecordCount <= num) ? 1 : 0);
					goto IL_01b5;
				case 2:
					num2 = 0;
					continue;
				case 0:
					num3 = ((l.RecordCount != num) ? 1 : 0);
					goto IL_00f6;
				case 13:
					l.Focus();
					l.Row = num - 1;
					num2 = 1;
					continue;
				case 8:
					l.Focus();
					l.Row = num;
					num2 = 3;
					continue;
				case 5:
					if (flag)
					{
						if (true)
						{
						}
						num2 = 7;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 1:
				case 3:
					{
						this.m_a = "insert";
						return;
					}
					IL_00f6:
					flag = (byte)num3 != 0;
					num2 = 12;
					continue;
					IL_01b5:
					flag = (byte)num4 != 0;
					num2 = 5;
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
		this.m_a = "insert";
		k.Visible = true;
		this.m_g.Text = "";
		this.m_g.Focus();
		this.m_g.Enabled = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		k.Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		string a_ = default;
		int num3 = default;
		float num2 = default;
		while (true)
		{
			bool flag = !(asdaj.b(this.m_g.Text) == "");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 17;
						continue;
					}
					flag = !(asdaj.b(t.Text) == "");
					num = 1;
					continue;
				case 8:
					MessageBox.Show("عنوان اخطار آموزشی تکراری است");
					this.m_g.SelectAll();
					num = 3;
					continue;
				case 3:
					return;
				case 16:
					a_ = l.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 4;
					continue;
				case 12:
					MessageBox.Show("میزان امتیاز منفی را وارد کنید");
					t.Focus();
					num = 10;
					continue;
				case 10:
					return;
				case 5:
					flag = !(this.m_a == "update");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 2;
				case 1:
					if (!flag)
					{
						num = 12;
						continue;
					}
					t.Text = t.Text.Trim().Replace("-", "");
					num2 = 0f;
					num = 9;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 2:
					d();
					c();
					num = 13;
					continue;
				case 13:
					return;
				case 15:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 4;
				case 18:
					k.Visible = false;
					num = 2;
					continue;
				case 4:
				{
					if (true)
					{
					}
					SqlParameter[] array = new SqlParameter[6]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(this.m_g.Text)),
						asdcb.a("@mark", SqlDbType.Float, num2),
						asdcb.a("@typ", SqlDbType.SmallInt, 3),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, this.m_a)
					};
					num3 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryCases_InsertUpdate", array);
					flag = !(array[0].Value.ToString() == "0");
					num = 14;
					continue;
				}
				case 14:
					if (flag)
					{
						flag = num3 <= 0;
						num = 0;
					}
					else
					{
						num = 8;
					}
					continue;
				case 9:
					try
					{
						num2 = float.Parse(t.Text);
						num2 = 0f - num2;
					}
					catch
					{
						MessageBox.Show("برای امتیاز منفی فقط عدد وارد کنید");
						return;
					}
					a_ = "0";
					flag = !(this.m_a == "update");
					num = 15;
					continue;
				case 17:
					MessageBox.Show("عنوان اخطار آموزشی را وارد کنید");
					this.m_g.Focus();
					num = 7;
					continue;
				case 7:
					return;
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
		this.m_g.Text = "";
		this.m_g.Focus();
	}

	private void b()
	{
		bool flag = default;
		while (true)
		{
			this.m_g.Text = l.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 7;
						continue;
					}
					goto IL_00e5;
				case 1:
					this.m_g.Enabled = false;
					num = 5;
					continue;
				case 3:
					num2 = 0;
					goto IL_01c3;
				case 7:
					num = 4;
					continue;
				case 4:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 2;
						continue;
					}
					goto IL_00e5;
				case 0:
					if (1 == 0)
					{
					}
					goto case 5;
				case 2:
					num = 8;
					continue;
				case 8:
					num2 = ((!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_01c3;
				case 9:
					if (flag)
					{
						this.m_g.Enabled = true;
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 5:
					{
						t.Text = l.SelectedItems[0].GetRow().Cells["mark"].Value.ToString();
						this.m_g.Focus();
						this.m_g.SelectAll();
						return;
					}
					IL_00e5:
					num = 3;
					continue;
					IL_01c3:
					flag = (byte)num2 != 0;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a = "update";
		k.Visible = true;
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_b = l.Row;
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
				int num3;
				int num2;
				switch (num)
				{
				case 9:
					num = ((l.RowCount <= 0) ? 1 : 10);
					continue;
				case 10:
					num = 17;
					continue;
				case 17:
					num3 = ((l.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_021e;
				case 11:
					num2 = 0;
					goto IL_0268;
				case 5:
					num = 2;
					continue;
				case 2:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 14;
						continue;
					}
					goto IL_00bf;
				case 13:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 16;
				case 14:
					num = 8;
					continue;
				case 8:
					num2 = ((!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_0268;
				case 12:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryCases where id=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					d();
					num = 16;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 1:
					num3 = 1;
					goto IL_021e;
				case 16:
					num = 3;
					continue;
				case 3:
					return;
				case 7:
				{
					if (!flag)
					{
						num = 21;
						continue;
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tDisciplinaryStudent where xDisciplinaryCases=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 15;
					continue;
				}
				case 4:
					num = 19;
					continue;
				case 19:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 5;
						continue;
					}
					goto IL_00bf;
				case 18:
					MessageBox.Show("از این اخطار آموزشی استفاده شده و قابل حذف نیست");
					num = 20;
					continue;
				case 20:
					return;
				case 21:
					MessageBox.Show("این اخطار آموزشی قابل حذف نیست");
					num = 0;
					continue;
				case 0:
					return;
				case 15:
					{
						if (flag)
						{
							flag = MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
							if (true)
							{
							}
							num = 13;
						}
						else
						{
							num = 18;
						}
						continue;
					}
					IL_00bf:
					num = 11;
					continue;
					IL_0268:
					flag = (byte)num2 != 0;
					num = 7;
					continue;
					IL_021e:
					flag = (byte)num3 != 0;
					num = 6;
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
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					num = ((!A_0) ? 1 : 6);
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_c == null) ? 1 : 0);
					goto IL_0074;
				case 0:
					this.m_c.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 1:
					num2 = 1;
					goto IL_0074;
				case 4:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 5;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdq));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_d = new Panel();
		r = new Panel();
		s = new Label();
		p = new Panel();
		o = new UIButton();
		n = new UIButton();
		m = new UIButton();
		q = new UIButton();
		k = new Panel();
		this.m_e = new Panel();
		t = new NumericEditBox();
		this.m_f = new Label();
		this.m_g = new TextBox();
		this.m_h = new Label();
		i = new UIButton();
		j = new UIButton();
		l = new GridEX();
		this.m_d.SuspendLayout();
		r.SuspendLayout();
		p.SuspendLayout();
		k.SuspendLayout();
		this.m_e.SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		SuspendLayout();
		this.m_d.BackColor = SystemColors.ControlText;
		this.m_d.Controls.Add(r);
		this.m_d.Dock = DockStyle.Fill;
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "panel2";
		this.m_d.Size = new Size(550, 600);
		this.m_d.TabIndex = 31;
		r.BackColor = Color.FromArgb(214, 223, 247);
		r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		r.Controls.Add(s);
		r.Controls.Add(p);
		r.Controls.Add(q);
		r.Controls.Add(k);
		r.Controls.Add(l);
		r.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Location = new Point(5, 5);
		r.Name = "panel3";
		r.Size = new Size(540, 590);
		r.TabIndex = 0;
		s.AutoSize = true;
		s.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Location = new Point(149, 3);
		s.Name = "label4";
		s.Size = new Size(236, 40);
		s.TabIndex = 86;
		s.Text = "تعریف اخطار های آموزشی";
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p.Controls.Add(o);
		p.Controls.Add(n);
		p.Controls.Add(m);
		p.Location = new Point(268, 535);
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
		q.Location = new Point(16, 538);
		q.Name = "btnClose";
		q.Size = new Size(110, 40);
		q.TabIndex = 30;
		q.Text = "بستن";
		q.Click += b;
		k.BackColor = Color.Gray;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Controls.Add(this.m_e);
		k.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(18, 160);
		k.Name = "pStd";
		k.Size = new Size(514, 207);
		k.TabIndex = 0;
		k.Visible = false;
		this.m_e.BackColor = Color.FromArgb(214, 223, 247);
		this.m_e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_e.Controls.Add(t);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Controls.Add(this.m_g);
		this.m_e.Controls.Add(this.m_h);
		this.m_e.Controls.Add(i);
		this.m_e.Controls.Add(j);
		this.m_e.Location = new Point(6, 7);
		this.m_e.Name = "panel1";
		this.m_e.Size = new Size(498, 189);
		this.m_e.TabIndex = 40;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		t.Location = new Point(312, 70);
		t.Name = "txtMark";
		t.Size = new Size(62, 31);
		t.TabIndex = 3;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.Value = new decimal(new int[4] { 0, 0, 0, 131072 });
		this.m_f.AutoSize = true;
		this.m_f.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(380, 73);
		this.m_f.Name = "label5";
		this.m_f.Size = new Size(96, 24);
		this.m_f.TabIndex = 49;
		this.m_f.Text = "میزان امتیاز منفی";
		this.m_g.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(16, 28);
		this.m_g.Name = "txtName";
		this.m_g.Size = new Size(358, 31);
		this.m_g.TabIndex = 2;
		this.m_h.AutoSize = true;
		this.m_h.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(380, 31);
		this.m_h.Name = "label2";
		this.m_h.Size = new Size(111, 24);
		this.m_h.TabIndex = 42;
		this.m_h.Text = "عنوان اخطار آموزشی";
		i.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		i.Location = new Point(97, 129);
		i.Name = "btnCancel";
		i.Size = new Size(75, 38);
		i.TabIndex = 5;
		i.Text = "انصراف";
		i.Click += f;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		j.Location = new Point(191, 129);
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
		l.Location = new Point(6, 56);
		l.Name = "gridEX1";
		l.RecordNavigator = true;
		l.RightToLeft = RightToLeft.Yes;
		l.RowHeaders = InheritableBoolean.True;
		l.Size = new Size(516, 471);
		l.TabIndex = 1;
		l.VisualStyle = VisualStyle.Office2003;
		l.SelectionChanged += c;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(550, 600);
		Controls.Add(this.m_d);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmDisciplinaryCases3";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "تعریف اخطارهای آموزشی";
		Load += h;
		this.m_d.ResumeLayout(performLayout: false);
		r.ResumeLayout(performLayout: false);
		r.PerformLayout();
		p.ResumeLayout(performLayout: false);
		k.ResumeLayout(performLayout: false);
		this.m_e.ResumeLayout(performLayout: false);
		this.m_e.PerformLayout();
		((ISupportInitialize)l).EndInit();
		ResumeLayout(performLayout: false);
	}
}
