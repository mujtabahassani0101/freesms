using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbq : Form
{
	private string m_a;

	private IContainer m_b = null;

	private GridEX m_c;

	private Panel m_d;

	private Panel m_e;

	private UIButton m_f;

	private UIButton m_g;

	private UIButton h;

	private Panel i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private UIButton m;

	private Label n;

	private Label o;

	private Label p;

	private Panel q;

	private NumericEditBox r;

	private Label s;

	private EditBox t;

	private Label u;

	private Label v;

	private MaskedEditBox w;

	private MaskedEditBox x;

	public asdbq()
	{
		a();
	}

	private void g(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 1:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 7;
				case 7:
					v.Text = asdaj.__field_a;
					b();
					num = 6;
					continue;
				case 6:
					return;
				case 3:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 5;
					continue;
				case 5:
					return;
				case 2:
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tExam where term=0 and xYear=" + v.Text);
		this.m_c.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		r.Text = asdcb.a(asdab.e(), CommandType.Text, "select case when isnull(max (NumExam),0)+1 <0 then 1 else isnull(max (NumExam),0)+1 end as n  from tExam where xYear=" + v.Text).ToString();
		this.m_a = "insert";
		i.Visible = true;
		t.Focus();
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_c.RowCount <= 0;
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
					return;
				case 1:
					try
					{
						w.Text = this.m_c.SelectedItems[0].GetRow().Cells["DateTo"].Value.ToString();
					}
					catch
					{
					}
					if (true)
					{
					}
					t.Select();
					num = 0;
					continue;
				case 2:
					try
					{
						x.Text = this.m_c.SelectedItems[0].GetRow().Cells["DateFrom"].Value.ToString();
					}
					catch
					{
					}
					num = 1;
					continue;
				case 0:
					return;
				case 3:
					this.m_a = "update";
					i.Visible = true;
					r.Text = this.m_c.SelectedItems[0].GetRow().Cells["NumExam"].Value.ToString();
					t.Text = this.m_c.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
					num = 2;
					continue;
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
			bool flag = !(this.m_a == "update");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						flag = !(this.m_a == "insert");
						num = 0;
					}
					continue;
				case 1:
					text = asdcb.a(asdab.e(), CommandType.Text, " select isNull(MAX(ID),100)+1  from tExam").ToString();
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tExam (id,name,NumExam,DateFrom,DateTo,xYear,term) values(" + text + ",N'" + t.Text.Trim() + "'," + r.Text + ",N'" + x.Text + "',N'" + w.Text + "'," + v.Text + ",0)");
					i.Visible = false;
					b();
					MessageBox.Show("ثبت شد");
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
					return;
				case 2:
					text = this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, " update tExam set NumExam=" + r.Text + ",name=N'" + t.Text.Trim() + "',DateFrom=N'" + x.Text + "',DateTo=N'" + w.Text + "',xExportRpt=null where id=" + text);
					b();
					i.Visible = false;
					MessageBox.Show("اصلاح شد");
					num = 4;
					continue;
				case 4:
					return;
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
		i.Visible = false;
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
					num = ((this.m_c.RowCount <= 0) ? 10 : 5);
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 3;
				case 14:
					if (flag)
					{
						flag = MessageBox.Show("آيا از حذف دوره مطمئن هستيد؟", "حذف دوره", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 7;
					}
					else
					{
						num = 13;
					}
					continue;
				case 10:
					num2 = 1;
					goto IL_029d;
				case 1:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tExam where id=" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					b();
					num = 3;
					continue;
				case 5:
					num = 15;
					continue;
				case 15:
					num2 = ((this.m_c.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_029d;
				case 13:
					MessageBox.Show("تعداد " + text + "توضیحات زیر اطلاع نامه در این دوره وجود دارد.امکان حذف وجود ندارد");
					num = 8;
					continue;
				case 8:
					return;
				case 3:
					num = 6;
					continue;
				case 6:
					return;
				case 9:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tMark WHERE Xtest =" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						if (true)
						{
						}
						text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tComnentKarname WHERE Xtest =" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
						flag = !(text != "0");
						num = 14;
					}
					else
					{
						num = 0;
					}
					continue;
				case 11:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 0:
					MessageBox.Show("تعداد " + text + "نمره در این دوره وجود دارد.امکان حذف وجود ندارد");
					num = 4;
					continue;
				case 4:
					return;
					IL_029d:
					flag = (byte)num2 != 0;
					num = 11;
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
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((!A_0) ? 6 : 3);
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 1:
					this.m_b.Dispose();
					num = 4;
					continue;
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 6:
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbq));
		this.m_c = new GridEX();
		this.m_d = new Panel();
		v = new Label();
		u = new Label();
		p = new Label();
		i = new Panel();
		w = new MaskedEditBox();
		x = new MaskedEditBox();
		t = new EditBox();
		s = new Label();
		r = new NumericEditBox();
		n = new Label();
		o = new Label();
		m = new UIButton();
		k = new UIButton();
		l = new Label();
		this.m_e = new Panel();
		this.m_f = new UIButton();
		j = new UIButton();
		this.m_g = new UIButton();
		h = new UIButton();
		q = new Panel();
		((ISupportInitialize)this.m_c).BeginInit();
		this.m_d.SuspendLayout();
		i.SuspendLayout();
		this.m_e.SuspendLayout();
		q.SuspendLayout();
		SuspendLayout();
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = gridEXLayout;
		this.m_c.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_c.GroupByBoxVisible = false;
		this.m_c.Location = new Point(8, 46);
		this.m_c.Name = "gridEX1";
		this.m_c.RowHeaders = InheritableBoolean.True;
		this.m_c.Size = new Size(428, 303);
		this.m_c.TabIndex = 5;
		this.m_c.VisualStyle = VisualStyle.Office2003;
		this.m_d.BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_d.Controls.Add(v);
		this.m_d.Controls.Add(u);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_c);
		this.m_d.Location = new Point(4, 6);
		this.m_d.Name = "panel1";
		this.m_d.Size = new Size(446, 395);
		this.m_d.TabIndex = 0;
		v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		v.Location = new Point(65, 9);
		v.Name = "lYear";
		v.Size = new Size(68, 24);
		v.TabIndex = 119;
		u.AutoSize = true;
		u.Location = new Point(139, 9);
		u.Name = "label6";
		u.Size = new Size(70, 24);
		u.TabIndex = 114;
		u.Text = "سال تعلیمی";
		p.AutoSize = true;
		p.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.ForeColor = Color.DarkViolet;
		p.Location = new Point(307, 3);
		p.Name = "label4";
		p.Size = new Size(132, 40);
		p.TabIndex = 16;
		p.Text = "لیست دوره ها";
		i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		i.Controls.Add(w);
		i.Controls.Add(x);
		i.Controls.Add(t);
		i.Controls.Add(s);
		i.Controls.Add(r);
		i.Controls.Add(n);
		i.Controls.Add(o);
		i.Controls.Add(m);
		i.Controls.Add(k);
		i.Controls.Add(l);
		i.Location = new Point(48, 104);
		i.Name = "pcls";
		i.Size = new Size(269, 216);
		i.TabIndex = 10;
		i.Visible = false;
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Location = new Point(90, 137);
		w.Mask = "0000/00/00";
		w.MaxLength = 12;
		w.Name = "txtDatato";
		w.Numeric = true;
		w.RightToLeft = RightToLeft.No;
		w.Size = new Size(100, 26);
		w.TabIndex = 23;
		w.Tag = "";
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		x.AutoScroll = false;
		x.AutoScrollMargin = new Size(0, 0);
		x.AutoScrollMinSize = new Size(0, 0);
		x.AutoScrollPosition = new Point(0, 0);
		x.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Location = new Point(90, 97);
		x.Mask = "0000/00/00";
		x.MaxLength = 12;
		x.Name = "txtDatafrom";
		x.Numeric = true;
		x.RightToLeft = RightToLeft.No;
		x.Size = new Size(100, 26);
		x.TabIndex = 22;
		x.Tag = "";
		x.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.Location = new Point(3, 54);
		t.Name = "txtNam";
		t.Size = new Size(187, 31);
		t.TabIndex = 1;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		s.AutoSize = true;
		s.Location = new Point(196, 59);
		s.Name = "label5";
		s.Size = new Size(70, 24);
		s.TabIndex = 21;
		s.Text = "عنوان دوره :";
		r.AutoScroll = false;
		r.AutoScrollMargin = new Size(0, 0);
		r.AutoScrollMinSize = new Size(0, 0);
		r.AutoScrollPosition = new Point(0, 0);
		r.Location = new Point(139, 13);
		r.MaxLength = 3;
		r.Name = "txtNumExam";
		r.Size = new Size(50, 31);
		r.TabIndex = 0;
		r.Text = "0";
		r.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		r.Value = 0;
		r.ValueType = NumericEditValueType.Int32;
		n.AutoSize = true;
		n.Location = new Point(195, 139);
		n.Name = "label3";
		n.Size = new Size(67, 24);
		n.TabIndex = 20;
		n.Text = "پایان دوره :";
		o.AutoSize = true;
		o.Location = new Point(195, 99);
		o.Name = "label2";
		o.Size = new Size(68, 24);
		o.TabIndex = 18;
		o.Text = "شروع دوره :";
		m.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		m.Location = new Point(40, 172);
		m.Name = "btnCancel";
		m.Size = new Size(75, 31);
		m.TabIndex = 5;
		m.Text = "انصراف";
		m.Click += b;
		k.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		k.Location = new Point(121, 172);
		k.Name = "btnAcp";
		k.Size = new Size(75, 31);
		k.TabIndex = 4;
		k.Text = "تایید";
		k.Click += d;
		l.AutoSize = true;
		l.Location = new Point(195, 15);
		l.Name = "label1";
		l.Size = new Size(71, 24);
		l.TabIndex = 1;
		l.Text = "شماره دوره :";
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Controls.Add(j);
		this.m_e.Controls.Add(this.m_g);
		this.m_e.Controls.Add(h);
		this.m_e.Location = new Point(3, 350);
		this.m_e.Name = "p_new";
		this.m_e.Size = new Size(440, 41);
		this.m_e.TabIndex = 9;
		this.m_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_f.Location = new Point(194, 3);
		this.m_f.Name = "btnDelete";
		this.m_f.Size = new Size(75, 32);
		this.m_f.TabIndex = 2;
		this.m_f.Text = "حذف";
		this.m_f.Click += a;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(30, 30);
		j.Location = new Point(7, 3);
		j.Name = "btnClose";
		j.Size = new Size(75, 32);
		j.TabIndex = 15;
		j.Text = "خروج";
		j.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
		j.Click += c;
		this.m_g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_g.Location = new Point(357, 3);
		this.m_g.Name = "btnNew";
		this.m_g.Size = new Size(75, 32);
		this.m_g.TabIndex = 0;
		this.m_g.Text = "جدید";
		this.m_g.Click += f;
		h.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		h.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		h.Location = new Point(275, 3);
		h.Name = "btnEdit";
		h.Size = new Size(75, 32);
		h.TabIndex = 1;
		h.Text = "اصلاح";
		h.Click += e;
		q.BackColor = SystemColors.ControlText;
		q.Controls.Add(this.m_d);
		q.Dock = DockStyle.Fill;
		q.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		q.Location = new Point(0, 0);
		q.Name = "panel2";
		q.Size = new Size(456, 407);
		q.TabIndex = 1;
		AcceptButton = k;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(456, 407);
		Controls.Add(q);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmExam";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "تعریف دوره";
		Load += g;
		((ISupportInitialize)this.m_c).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		i.ResumeLayout(performLayout: false);
		i.PerformLayout();
		this.m_e.ResumeLayout(performLayout: false);
		q.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
