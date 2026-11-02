using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbm : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Label m_d;

	private TextBox m_e;

	private Label m_f;

	private UIButton m_g;

	private UIButton m_h;

	private Panel i;

	private GridEX j;

	private UIButton k;

	private UIButton l;

	private UIButton m;

	private Panel n;

	private UIButton o;

	private Panel p;

	private Label q;

	private NumericEditBox r;

	private string s = "insert";

	private int t;
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
						num = 2;
					}
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 1;
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

	private void d()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbm));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		p = new Panel();
		q = new Label();
		n = new Panel();
		m = new UIButton();
		l = new UIButton();
		k = new UIButton();
		o = new UIButton();
		i = new Panel();
		this.m_c = new Panel();
		r = new NumericEditBox();
		this.m_d = new Label();
		this.m_e = new TextBox();
		this.m_f = new Label();
		this.m_g = new UIButton();
		this.m_h = new UIButton();
		j = new GridEX();
		this.m_b.SuspendLayout();
		p.SuspendLayout();
		n.SuspendLayout();
		i.SuspendLayout();
		this.m_c.SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.ControlText;
		this.m_b.Controls.Add(p);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(550, 600);
		this.m_b.TabIndex = 31;
		p.BackColor = Color.FromArgb(214, 223, 247);
		p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		p.Controls.Add(q);
		p.Controls.Add(n);
		p.Controls.Add(o);
		p.Controls.Add(i);
		p.Controls.Add(j);
		p.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.Location = new Point(5, 5);
		p.Name = "panel3";
		p.Size = new Size(540, 590);
		p.TabIndex = 0;
		q.AutoSize = true;
		q.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		q.Location = new Point(181, 5);
		q.Name = "label4";
		q.Size = new Size(192, 40);
		q.TabIndex = 86;
		q.Text = "تعریف موارد انضباطی";
		n.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		n.Controls.Add(m);
		n.Controls.Add(l);
		n.Controls.Add(k);
		n.Location = new Point(268, 535);
		n.Name = "p_new";
		n.Size = new Size(258, 43);
		n.TabIndex = 29;
		m.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		m.Location = new Point(3, 6);
		m.Name = "btnDelete";
		m.Size = new Size(78, 34);
		m.TabIndex = 2;
		m.Text = "حذف";
		m.Click += a;
		l.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		l.Location = new Point(170, 6);
		l.Name = "btnNew";
		l.Size = new Size(85, 34);
		l.TabIndex = 0;
		l.Text = "جدید";
		l.Click += g;
		k.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		k.Location = new Point(87, 6);
		k.Name = "btnEdit";
		k.Size = new Size(77, 34);
		k.TabIndex = 1;
		k.Text = "اصلاح";
		k.Click += d;
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		o.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		o.ImageSize = new Size(40, 40);
		o.Location = new Point(16, 538);
		o.Name = "btnClose";
		o.Size = new Size(110, 40);
		o.TabIndex = 30;
		o.Text = "بستن";
		o.Click += b;
		i.BackColor = Color.Gray;
		i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		i.Controls.Add(this.m_c);
		i.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Location = new Point(18, 160);
		i.Name = "pStd";
		i.Size = new Size(514, 207);
		i.TabIndex = 0;
		i.Visible = false;
		this.m_c.BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_c.Controls.Add(r);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Controls.Add(this.m_g);
		this.m_c.Controls.Add(this.m_h);
		this.m_c.Location = new Point(6, 7);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(498, 189);
		this.m_c.TabIndex = 40;
		r.AutoScroll = false;
		r.AutoScrollMargin = new Size(0, 0);
		r.AutoScrollMinSize = new Size(0, 0);
		r.AutoScrollPosition = new Point(0, 0);
		r.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Location = new Point(312, 70);
		r.Name = "txtMark";
		r.Size = new Size(62, 31);
		r.TabIndex = 3;
		r.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		r.Value = new decimal(new int[4] { 0, 0, 0, 131072 });
		this.m_d.AutoSize = true;
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(380, 73);
		this.m_d.Name = "label5";
		this.m_d.Size = new Size(96, 24);
		this.m_d.TabIndex = 49;
		this.m_d.Text = "میزان امتیاز منفی";
		this.m_e.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.Location = new Point(16, 28);
		this.m_e.Name = "txtName";
		this.m_e.Size = new Size(358, 31);
		this.m_e.TabIndex = 2;
		this.m_f.AutoSize = true;
		this.m_f.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(380, 31);
		this.m_f.Name = "label2";
		this.m_f.Size = new Size(110, 24);
		this.m_f.TabIndex = 42;
		this.m_f.Text = "عنوان مورد انضباطی";
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		this.m_g.Location = new Point(97, 129);
		this.m_g.Name = "btnCancel";
		this.m_g.Size = new Size(75, 38);
		this.m_g.TabIndex = 5;
		this.m_g.Text = "انصراف";
		this.m_g.Click += f;
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		this.m_h.Location = new Point(191, 129);
		this.m_h.Name = "btnAcp";
		this.m_h.Size = new Size(75, 38);
		this.m_h.TabIndex = 4;
		this.m_h.Text = "تایید";
		this.m_h.Click += e;
		j.AllowEdit = InheritableBoolean.False;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		j.DesignTimeLayout = gridEXLayout;
		j.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		j.Font = new Font("B Nazanin", 12f);
		j.GroupByBoxVisible = false;
		j.Location = new Point(6, 56);
		j.Name = "gridEX1";
		j.RecordNavigator = true;
		j.RightToLeft = RightToLeft.Yes;
		j.RowHeaders = InheritableBoolean.True;
		j.Size = new Size(516, 471);
		j.TabIndex = 1;
		j.VisualStyle = VisualStyle.Office2003;
		j.SelectionChanged += c;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(550, 600);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmDisciplinaryCases";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "تعریف موارد انضباطی";
		Load += h;
		this.m_b.ResumeLayout(performLayout: false);
		p.ResumeLayout(performLayout: false);
		p.PerformLayout();
		n.ResumeLayout(performLayout: false);
		i.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)j).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdbm()
	{
		d();
	}

	private void h(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			int num = t;
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    *   FROM  tDisciplinaryCases where typ=1");
			j.DataSource = dataSource;
			int num2 = 13;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 13:
					num2 = ((!(s == "update")) ? 9 : 8);
					continue;
				case 6:
					num3 = 1;
					goto IL_00eb;
				case 5:
					num2 = ((s == "update") ? 1 : 6);
					continue;
				case 9:
					num4 = 1;
					goto IL_01b5;
				case 0:
					if (!flag)
					{
						num2 = 12;
						continue;
					}
					goto case 4;
				case 8:
					num2 = 7;
					continue;
				case 7:
					num4 = ((j.RecordCount <= num) ? 1 : 0);
					goto IL_01b5;
				case 1:
					num2 = 10;
					continue;
				case 10:
					num3 = ((j.RecordCount != num) ? 1 : 0);
					goto IL_00eb;
				case 12:
					j.Focus();
					j.Row = num - 1;
					num2 = 4;
					continue;
				case 11:
					j.Focus();
					j.Row = num;
					num2 = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					goto case 4;
				case 3:
					num2 = ((!flag) ? 11 : 5);
					continue;
				case 4:
					{
						s = "insert";
						return;
					}
					IL_00eb:
					flag = (byte)num3 != 0;
					num2 = 0;
					continue;
					IL_01b5:
					flag = (byte)num4 != 0;
					num2 = 3;
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
		s = "insert";
		i.Visible = true;
		this.m_e.Text = "";
		this.m_e.Focus();
		this.m_e.Enabled = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		i.Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		string a_ = default;
		int num3 = default;
		float num2 = default;
		while (true)
		{
			bool flag = !(asdaj.b(this.m_e.Text) == "");
			int num = 17;
			while (true)
			{
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 14;
						continue;
					}
					flag = !(asdaj.b(r.Text) == "");
					num = 11;
					continue;
				case 9:
					MessageBox.Show("عنوان مورد انضباطی تکراری است");
					this.m_e.SelectAll();
					num = 5;
					continue;
				case 5:
					return;
				case 0:
					MessageBox.Show("میزان امتیاز منفی را وارد کنید");
					r.Focus();
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					flag = !(s == "update");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 4;
				case 11:
					if (!flag)
					{
						num = 0;
						continue;
					}
					r.Text = r.Text.Trim().Replace("-", "");
					num2 = 0f;
					num = 13;
					continue;
				case 8:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 4:
					c();
					b();
					num = 12;
					continue;
				case 12:
					return;
				case 6:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 10;
				case 15:
					if (true)
					{
					}
					a_ = j.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 10;
					continue;
				case 18:
					i.Visible = false;
					num = 4;
					continue;
				case 10:
				{
					SqlParameter[] array = new SqlParameter[6]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(this.m_e.Text)),
						asdcb.a("@mark", SqlDbType.Float, num2),
						asdcb.a("@typ", SqlDbType.SmallInt, 1),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, s)
					};
					num3 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryCases_InsertUpdate", array);
					flag = !(array[0].Value.ToString() == "0");
					num = 3;
					continue;
				}
				case 3:
					if (flag)
					{
						flag = num3 <= 0;
						num = 8;
					}
					else
					{
						num = 9;
					}
					continue;
				case 13:
					try
					{
						num2 = float.Parse(r.Text);
						num2 = 0f - num2;
					}
					catch
					{
						MessageBox.Show("برای امتیاز منفی فقط عدد وارد کنید");
						return;
					}
					a_ = "0";
					flag = !(s == "update");
					num = 6;
					continue;
				case 14:
					MessageBox.Show("عنوان مورد انضباطی را وارد کنید");
					this.m_e.Focus();
					num = 16;
					continue;
				case 16:
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
		this.m_e.Text = "";
		this.m_e.Focus();
	}

	private void a()
	{
		bool flag = default;
		while (true)
		{
			this.m_e.Text = j.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 9;
						continue;
					}
					goto IL_00ed;
				case 6:
					if (true)
					{
					}
					this.m_e.Enabled = false;
					num = 1;
					continue;
				case 2:
					num2 = 0;
					goto IL_01c3;
				case 9:
					num = 8;
					continue;
				case 8:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 3;
						continue;
					}
					goto IL_00ed;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_01c3;
				case 0:
					if (flag)
					{
						this.m_e.Enabled = true;
						num = 7;
					}
					else
					{
						num = 6;
					}
					continue;
				case 1:
				case 7:
					{
						r.Text = j.SelectedItems[0].GetRow().Cells["mark"].Value.ToString();
						this.m_e.Focus();
						this.m_e.SelectAll();
						return;
					}
					IL_00ed:
					num = 2;
					continue;
					IL_01c3:
					flag = (byte)num2 != 0;
					num = 0;
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
		s = "update";
		i.Visible = true;
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		t = j.Row;
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
			int num = 10;
			while (true)
			{
				int num3;
				int num2;
				switch (num)
				{
				case 10:
					num = ((j.RowCount <= 0) ? 12 : 11);
					continue;
				case 11:
					num = 0;
					continue;
				case 0:
					num3 = ((j.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_021e;
				case 3:
					num2 = 0;
					goto IL_0268;
				case 20:
					num = 14;
					continue;
				case 14:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 4;
						continue;
					}
					goto IL_00bf;
				case 4:
					if (true)
					{
					}
					num = 16;
					continue;
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 18;
				case 16:
					num2 = ((!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_0268;
				case 7:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryCases where id=" + j.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					c();
					num = 18;
					continue;
				case 15:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 12:
					num3 = 1;
					goto IL_021e;
				case 18:
					num = 5;
					continue;
				case 5:
					return;
				case 2:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tDisciplinaryStudent where xDisciplinaryCases=" + j.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 8;
					continue;
				}
				case 9:
					num = 17;
					continue;
				case 17:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 20;
						continue;
					}
					goto IL_00bf;
				case 21:
					MessageBox.Show("از این مورد انضباطی استفاده شده و قابل حذف نیست");
					num = 19;
					continue;
				case 19:
					return;
				case 13:
					MessageBox.Show("این مورد انضباطی قابل حذف نیست");
					num = 6;
					continue;
				case 6:
					return;
				case 8:
					{
						if (flag)
						{
							flag = MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
							num = 1;
						}
						else
						{
							num = 21;
						}
						continue;
					}
					IL_00bf:
					num = 3;
					continue;
					IL_0268:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
					IL_021e:
					flag = (byte)num3 != 0;
					num = 15;
					continue;
				}
				break;
			}
		}
	}
}
