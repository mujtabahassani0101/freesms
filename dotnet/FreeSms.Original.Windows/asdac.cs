using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdac : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private UIButton f;

	private Label g;

	private Label h;

	private Label i;

	private EditBox j;

	private EditBox k;

	private Label l;

	private EditBox m;

	private Label n;

	private EditBox o;

	private SqlConnection p = new SqlConnection(asdab.e());
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
						num = 6;
					}
					else
					{
						num = 4;
					}
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 0;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 3;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdac));
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		l = new Label();
		m = new EditBox();
		n = new Label();
		o = new EditBox();
		h = new Label();
		i = new Label();
		j = new EditBox();
		k = new EditBox();
		g = new Label();
		f = new UIButton();
		this.m_e = new UIButton();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(482, 314);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(480, 312);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(g);
		this.m_d.Controls.Add(f);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(473, 304);
		this.m_d.TabIndex = 0;
		l.AutoSize = true;
		l.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Location = new Point(348, 108);
		l.Name = "label5";
		l.Size = new Size(51, 20);
		l.TabIndex = 129;
		l.Text = "ولسوالی :";
		m.AutoScroll = false;
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.AutoScrollPosition = new Point(0, 0);
		m.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Location = new Point(81, 106);
		m.MaxLength = 300;
		m.Name = "txtCity";
		m.Size = new Size(263, 23);
		m.TabIndex = 1;
		m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.Leave += a;
		m.Enter += b;
		m.KeyDown += a;
		n.AutoSize = true;
		n.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(347, 78);
		n.Name = "label3";
		n.Size = new Size(41, 20);
		n.TabIndex = 127;
		n.Text = "ولایت :";
		o.AutoScroll = false;
		o.AutoScrollMargin = new Size(0, 0);
		o.AutoScrollMinSize = new Size(0, 0);
		o.AutoScrollPosition = new Point(0, 0);
		o.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(81, 77);
		o.MaxLength = 300;
		o.Name = "txtOst";
		o.Size = new Size(263, 23);
		o.TabIndex = 0;
		o.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		o.Leave += a;
		o.Enter += b;
		o.KeyDown += a;
		h.AutoSize = true;
		h.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.Location = new Point(348, 171);
		h.Name = "label2";
		h.Size = new Size(50, 20);
		h.TabIndex = 125;
		h.Text = "نام مدیر :";
		i.AutoSize = true;
		i.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(347, 140);
		i.Name = "label1";
		i.Size = new Size(57, 20);
		i.TabIndex = 124;
		i.Text = "نام مکتب :";
		j.AutoScroll = false;
		j.AutoScrollMargin = new Size(0, 0);
		j.AutoScrollMinSize = new Size(0, 0);
		j.AutoScrollPosition = new Point(0, 0);
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.Location = new Point(81, 168);
		j.MaxLength = 300;
		j.Name = "txtFoter1";
		j.Size = new Size(263, 23);
		j.TabIndex = 3;
		j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		j.Leave += a;
		j.Enter += b;
		j.KeyDown += a;
		k.AutoScroll = false;
		k.AutoScrollMargin = new Size(0, 0);
		k.AutoScrollMinSize = new Size(0, 0);
		k.AutoScrollPosition = new Point(0, 0);
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		k.Location = new Point(81, 139);
		k.MaxLength = 300;
		k.Name = "txtSch";
		k.Size = new Size(263, 23);
		k.TabIndex = 2;
		k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		k.Leave += a;
		k.Enter += b;
		k.KeyDown += a;
		g.AutoSize = true;
		g.Font = new Font("B Nazanin", 24f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.ForeColor = Color.DarkViolet;
		g.Location = new Point(129, 14);
		g.Name = "label4";
		g.Size = new Size(202, 51);
		g.TabIndex = 121;
		g.Text = "مشخصات مکتب";
		f.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		f.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		f.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		f.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		f.ImageIndex = 8;
		f.ImageSize = new Size(40, 40);
		f.Location = new Point(197, 213);
		f.Name = "btnAcp";
		f.RightToLeft = RightToLeft.Yes;
		f.Size = new Size(153, 40);
		f.TabIndex = 4;
		f.Text = "ثبت";
		f.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		f.Click += c;
		this.m_e.DialogResult = DialogResult.Cancel;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(40, 40);
		this.m_e.Location = new Point(39, 213);
		this.m_e.Name = "btnClose";
		this.m_e.Size = new Size(152, 40);
		this.m_e.TabIndex = 16;
		this.m_e.Text = "بستن";
		this.m_e.Click += d;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(482, 314);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSchool";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "مشخصات مکتب";
		Load += e;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public asdac()
	{
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 1;
			while (true)
			{
				DataTable dataTable2;
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
					num = 0;
					continue;
				case 2:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto IL_0134;
				case 3:
					return;
				case 7:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_0134;
				case 5:
					{
						num = 2;
						continue;
					}
					IL_0134:
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select * from tParmetr");
					o.Text = dataTable2.Rows[0]["Ost"].ToString();
					m.Text = dataTable2.Rows[0]["cty"].ToString();
					j.Text = dataTable2.Rows[0]["Foter1"].ToString();
					k.Text = dataTable2.Rows[0]["sch"].ToString();
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[4]
		{
			asdcb.a("@Ost", SqlDbType.NVarChar, o.Text),
			asdcb.a("@cty", SqlDbType.NVarChar, m.Text),
			asdcb.a("@Foter1", SqlDbType.NVarChar, j.Text),
			asdcb.a("@sch", SqlDbType.NVarChar, k.Text)
		};
		asdcb.d(asdab.e(), CommandType.Text, "UPDATE    tParmetr\r\n                SET  Ost =@Ost , cty =@cty , Foter1 =@Foter1 , sch =@sch", a_);
		MessageBox.Show("ثبت شد");
	}

	private void b(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		EditBox editBox = (EditBox)A_0;
		editBox.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		EditBox editBox = (EditBox)A_0;
		editBox.BackColor = Color.FromName("Window");
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.Return;
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
					SendKeys.Send("{tab}");
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}
}
