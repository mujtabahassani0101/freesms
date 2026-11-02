using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;

public class asda8 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private UIButton m_d;

	private UIButton m_e;

	private Label f;

	private Panel g;

	private ColorDialog h;

	private Label i;

	private Label j;

	private NumericUpDown k;

	private Label l;

	private NumericUpDown m;

	private NumericUpDown n;

	private UIButton o;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (A_0)
					{
						if (true)
						{
						}
						num = 6;
					}
					else
					{
						num = 5;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 2:
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

	private void a()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda8));
		this.m_b = new Panel();
		o = new UIButton();
		l = new Label();
		m = new NumericUpDown();
		n = new NumericUpDown();
		k = new NumericUpDown();
		j = new Label();
		i = new Label();
		f = new Label();
		this.m_c = new Panel();
		this.m_e = new UIButton();
		this.m_d = new UIButton();
		g = new Panel();
		h = new ColorDialog();
		this.m_b.SuspendLayout();
		((ISupportInitialize)m).BeginInit();
		((ISupportInitialize)n).BeginInit();
		((ISupportInitialize)k).BeginInit();
		this.m_c.SuspendLayout();
		g.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = BorderStyle.FixedSingle;
		this.m_b.Controls.Add(o);
		this.m_b.Controls.Add(l);
		this.m_b.Controls.Add(m);
		this.m_b.Controls.Add(n);
		this.m_b.Controls.Add(k);
		this.m_b.Controls.Add(j);
		this.m_b.Controls.Add(i);
		this.m_b.Controls.Add(f);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new Point(4, 6);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(446, 395);
		this.m_b.TabIndex = 0;
		o.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		o.Location = new Point(186, 227);
		o.Name = "btnAcp";
		o.Size = new Size(96, 32);
		o.TabIndex = 24;
		o.Text = "ثبت";
		o.Click += c;
		l.AutoSize = true;
		l.Location = new Point(267, 189);
		l.Name = "label3";
		l.Size = new Size(53, 24);
		l.TabIndex = 23;
		l.Text = "رنگ آبی";
		m.Location = new Point(197, 185);
		m.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		m.Name = "txtB";
		m.Size = new Size(62, 31);
		m.TabIndex = 22;
		m.ValueChanged += a;
		n.Location = new Point(197, 138);
		n.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		n.Name = "txtG";
		n.Size = new Size(62, 31);
		n.TabIndex = 21;
		n.ValueChanged += a;
		k.Location = new Point(197, 94);
		k.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		k.Name = "txtR";
		k.Size = new Size(62, 31);
		k.TabIndex = 20;
		k.ValueChanged += a;
		j.AutoSize = true;
		j.Location = new Point(265, 140);
		j.Name = "label2";
		j.Size = new Size(55, 24);
		j.TabIndex = 19;
		j.Text = "رنگ سبز";
		i.AutoSize = true;
		i.Location = new Point(265, 96);
		i.Name = "label1";
		i.Size = new Size(57, 24);
		i.TabIndex = 18;
		i.Text = "رنک قرمز";
		f.AutoSize = true;
		f.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		f.ForeColor = Color.DarkViolet;
		f.Location = new Point(125, 9);
		f.Name = "label4";
		f.Size = new Size(202, 40);
		f.TabIndex = 16;
		f.Text = "رنگ پس زمینه فرم ها";
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Location = new Point(3, 350);
		this.m_c.Name = "p_new";
		this.m_c.Size = new Size(440, 41);
		this.m_c.TabIndex = 9;
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(30, 30);
		this.m_e.Location = new Point(7, 3);
		this.m_e.Name = "btnClose";
		this.m_e.Size = new Size(75, 32);
		this.m_e.TabIndex = 15;
		this.m_e.Text = "خروج";
		this.m_e.TextHorizontalAlignment = TextAlignment.Near;
		this.m_e.Click += b;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_d.Location = new Point(316, 3);
		this.m_d.Name = "btnNew";
		this.m_d.Size = new Size(116, 32);
		this.m_d.TabIndex = 0;
		this.m_d.Text = "انتخاب رنگ ";
		this.m_d.Click += d;
		g.BackColor = SystemColors.ControlText;
		g.Controls.Add(this.m_b);
		g.Dock = DockStyle.Fill;
		g.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.Location = new Point(0, 0);
		g.Name = "panel2";
		g.Size = new Size(456, 407);
		g.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(456, 407);
		Controls.Add(g);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmbackColor";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "تعریف دوره";
		Load += e;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)m).EndInit();
		((ISupportInitialize)n).EndInit();
		((ISupportInitialize)k).EndInit();
		this.m_c.ResumeLayout(performLayout: false);
		g.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asda8()
	{
		a();
	}

	private void e(object A_0, EventArgs A_1)
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
						num = 2;
						continue;
					}
					goto case 3;
				case 1:
					try
					{
						k.Value = decimal.Parse(dataTable.Rows[0]["R"].ToString());
						n.Value = decimal.Parse(dataTable.Rows[0]["G"].ToString());
						m.Value = decimal.Parse(dataTable.Rows[0]["B"].ToString());
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					num = 1;
					continue;
				case 3:
					o.Visible = false;
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
			ColorDialog colorDialog = new ColorDialog();
			bool flag = colorDialog.ShowDialog() != DialogResult.OK;
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
					return;
				case 1:
					k.Value = decimal.Parse(colorDialog.Color.R.ToString());
					n.Value = decimal.Parse(colorDialog.Color.G.ToString());
					m.Value = decimal.Parse(colorDialog.Color.B.ToString());
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void a(decimal A_0, decimal A_1, decimal A_2)
	{
		if (true)
		{
		}
		this.m_b.BackColor = Color.FromArgb(int.Parse(A_0.ToString()), int.Parse(A_1.ToString()), int.Parse(A_2.ToString()));
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		asdcb.d(asdab.e(), CommandType.Text, "if not exists(select R from tFormColor)\r\n                insert into tFormColor(R,G,B)values(" + k.Value + "," + n.Value + "," + m.Value + ")\r\n                else\r\n                update tFormColor set R=" + k.Value + ",G=" + n.Value + ",B=" + m.Value);
		MessageBox.Show("ثبت شد");
		o.Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		a(k.Value, n.Value, m.Value);
		o.Visible = true;
	}
}
