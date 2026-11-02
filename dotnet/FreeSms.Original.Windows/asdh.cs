using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdh : Form
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

	private EditBox k;

	private Label l;

	private Panel m;

	private EditBox n;

	private Label o;

	private UIButton p;

	private Label q;

	private string r;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (A_0)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 3;
					}
					continue;
				case 4:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 5;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdh));
		this.m_b = new GridEX();
		this.m_c = new Panel();
		l = new Label();
		i = new UIButton();
		h = new Panel();
		n = new EditBox();
		o = new Label();
		p = new UIButton();
		j = new UIButton();
		q = new Label();
		k = new EditBox();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_f = new UIButton();
		this.m_g = new UIButton();
		m = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		this.m_c.SuspendLayout();
		h.SuspendLayout();
		this.m_d.SuspendLayout();
		m.SuspendLayout();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(8, 51);
		this.m_b.Name = "gridEX1";
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(431, 341);
		this.m_b.TabIndex = 5;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(h);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_b);
		this.m_c.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(5, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(445, 487);
		this.m_c.TabIndex = 0;
		l.AutoSize = true;
		l.Font = new Font("B Titr", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Location = new Point(182, 2);
		l.Name = "label4";
		l.Size = new Size(74, 42);
		l.TabIndex = 17;
		l.Text = "تخفیف";
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		i.Location = new Point(6, 445);
		i.Name = "btnClose";
		i.Size = new Size(430, 36);
		i.TabIndex = 15;
		i.Text = "خروج";
		i.Click += c;
		h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		h.Controls.Add(n);
		h.Controls.Add(o);
		h.Controls.Add(p);
		h.Controls.Add(j);
		h.Controls.Add(q);
		h.Controls.Add(k);
		h.Location = new Point(31, 176);
		h.Name = "pcls";
		h.Size = new Size(363, 197);
		h.TabIndex = 10;
		h.Visible = false;
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(5, 50);
		n.Multiline = true;
		n.Name = "txtComment";
		n.Size = new Size(265, 93);
		n.TabIndex = 1;
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		o.AutoSize = true;
		o.Location = new Point(273, 52);
		o.Name = "label2";
		o.Size = new Size(62, 16);
		o.TabIndex = 17;
		o.Text = "توضیحات";
		p.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		p.Location = new Point(18, 151);
		p.Name = "btnCancel";
		p.Size = new Size(75, 35);
		p.TabIndex = 3;
		p.Text = "انصراف";
		p.Click += b;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		j.Location = new Point(99, 151);
		j.Name = "btnAcp";
		j.Size = new Size(75, 35);
		j.TabIndex = 2;
		j.Text = "تایید";
		j.Click += d;
		q.AutoSize = true;
		q.Location = new Point(272, 13);
		q.Name = "label1";
		q.Size = new Size(87, 16);
		q.TabIndex = 1;
		q.Text = "عنوان تخفیف";
		k.AutoScroll = false;
		k.AutoScrollMargin = new Size(0, 0);
		k.AutoScrollMinSize = new Size(0, 0);
		k.AutoScrollPosition = new Point(0, 0);
		k.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		k.Location = new Point(4, 9);
		k.Name = "txtNam";
		k.Size = new Size(265, 23);
		k.TabIndex = 0;
		k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(this.m_g);
		this.m_d.Location = new Point(1, 395);
		this.m_d.Name = "p_new";
		this.m_d.Size = new Size(438, 45);
		this.m_d.TabIndex = 9;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_e.Location = new Point(6, 6);
		this.m_e.Name = "btnDelete";
		this.m_e.Size = new Size(127, 36);
		this.m_e.TabIndex = 2;
		this.m_e.Text = "حذف";
		this.m_e.Click += a;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_f.Location = new Point(304, 6);
		this.m_f.Name = "btnNew";
		this.m_f.Size = new Size(127, 36);
		this.m_f.TabIndex = 0;
		this.m_f.Text = "جدید";
		this.m_f.Click += f;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_g.Location = new Point(157, 6);
		this.m_g.Name = "btnEdit";
		this.m_g.Size = new Size(127, 36);
		this.m_g.TabIndex = 1;
		this.m_g.Text = "اصلاح";
		this.m_g.Click += e;
		m.BackColor = SystemColors.ControlText;
		m.Controls.Add(this.m_c);
		m.Dock = DockStyle.Fill;
		m.Location = new Point(0, 0);
		m.Name = "panel2";
		m.Size = new Size(455, 500);
		m.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(455, 500);
		Controls.Add(m);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmTakhfif";
		RightToLeft = RightToLeft.Yes;
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست تخفیف ها";
		Load += g;
		((ISupportInitialize)this.m_b).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		h.ResumeLayout(performLayout: false);
		h.PerformLayout();
		this.m_d.ResumeLayout(performLayout: false);
		m.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdh()
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 3:
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
					num = 0;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto IL_0131;
				case 7:
					return;
				case 1:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					if (1 == 0)
					{
					}
					goto IL_0131;
				case 2:
					{
						num = 3;
						continue;
					}
					IL_0131:
					a();
					num = 7;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tTakhfif");
		this.m_b.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		r = "insert";
		h.Visible = true;
		k.Text = "";
		n.Text = "";
		k.Focus();
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
						num = 0;
						continue;
					}
					return;
				case 0:
					r = "update";
					h.Visible = true;
					k.Text = this.m_b.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
					n.Text = this.m_b.SelectedItems[0].GetRow().Cells["comment"].Value.ToString();
					k.Select();
					num = 2;
					continue;
				case 2:
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
			bool flag = !(k.Text.Trim() == "");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = !(r == "update");
					num = 3;
					continue;
				case 4:
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tTakhfif (name,comment) values(N'" + asdaj.b(k.Text) + "',N'" + n.Text + "' )");
					k.Text = "";
					n.Text = "";
					k.Focus();
					if (true)
					{
					}
					num = 1;
					continue;
				case 2:
					text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, " update tTakhfif set name=N'" + asdaj.b(k.Text) + "',comment=N'" + n.Text + "' where id=" + text);
					h.Visible = false;
					num = 0;
					continue;
				case 9:
					MessageBox.Show("عنوان تخفیف را وارد کنید");
					k.Focus();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				case 1:
					a();
					num = 8;
					continue;
				case 8:
					return;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(r == "insert");
					num = 5;
					continue;
				case 5:
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
		string text = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((this.m_b.RowCount <= 0) ? 4 : 11);
					continue;
				case 8:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 9;
				case 5:
					MessageBox.Show("تعداد " + text + " شاگرد برای این تخفیف وجود دارد.امکان حذف وجود ندارد");
					num = 7;
					continue;
				case 7:
					return;
				case 4:
					num2 = 1;
					goto IL_0213;
				case 9:
					num = 10;
					continue;
				case 10:
					return;
				case 11:
					num = 12;
					continue;
				case 12:
					if (true)
					{
					}
					num2 = ((this.m_b.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_0213;
				case 0:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tTakhfif where id=" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 9;
					continue;
				case 1:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tYear_Student WHERE xTakhfif =" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						flag = MessageBox.Show("آيا از حذف تخفیف مطمئن هستيد؟", "حذف تخفیف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 8;
					}
					else
					{
						num = 5;
					}
					continue;
				case 3:
					{
						if (!flag)
						{
							num = 1;
							continue;
						}
						return;
					}
					IL_0213:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}
}
