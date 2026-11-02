using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;

public class asdbn : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton c;

	private Panel d;

	private Panel e;

	private Label f;

	private Button g;

	private DatePicker h;

	public asdbn()
	{
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string text = h.the_date.DayOfWeek.ToString();
			bool flag = !(text == "Saturday");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 6;
						continue;
					}
					flag = !(text == "Sunday");
					num = 8;
					continue;
				case 15:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = !(text == "Friday");
					num = 17;
					continue;
				case 12:
					text = "سه شنبه";
					num = 10;
					continue;
				case 1:
					text = "یکشنبه";
					if (true)
					{
					}
					num = 13;
					continue;
				case 17:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 3;
				case 8:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = !(text == "Monday");
					num = 5;
					continue;
				case 0:
					text = "چهارشنبه";
					num = 14;
					continue;
				case 16:
					text = "جمعه";
					num = 3;
					continue;
				case 19:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 7;
					continue;
				case 5:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 19;
					}
					else
					{
						num = 20;
					}
					continue;
				case 9:
					text = "پنج شنبه";
					num = 11;
					continue;
				case 7:
					if (flag)
					{
						flag = !(text == "Thursday");
						num = 15;
					}
					else
					{
						num = 0;
					}
					continue;
				case 6:
					text = "شنبه";
					num = 4;
					continue;
				case 20:
					text = "دوشنبه";
					num = 18;
					continue;
				case 3:
				case 4:
				case 10:
				case 11:
				case 13:
				case 14:
				case 18:
				{
					asdbu asdbu2 = new asdbu();
					asdbu2.t = ShamsiDate.GetShamsiDate(h.the_date);
					asdbu2.u = text;
					asdbu2.ShowDialog();
					return;
				}
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 5;
					}
					continue;
				case 0:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 1;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 1:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbn));
		this.m_b = new Panel();
		e = new Panel();
		d = new Panel();
		h = new DatePicker();
		g = new Button();
		f = new Label();
		c = new UIButton();
		this.m_b.SuspendLayout();
		e.SuspendLayout();
		d.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = BorderStyle.FixedSingle;
		this.m_b.Controls.Add(e);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(304, 220);
		this.m_b.TabIndex = 0;
		e.BackColor = SystemColors.ControlText;
		e.Controls.Add(d);
		e.Dock = DockStyle.Fill;
		e.Location = new Point(0, 0);
		e.Name = "panel3";
		e.Size = new Size(302, 218);
		e.TabIndex = 19;
		d.BackColor = SystemColors.GradientInactiveCaption;
		d.Controls.Add(h);
		d.Controls.Add(g);
		d.Controls.Add(f);
		d.Controls.Add(c);
		d.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		d.Location = new Point(4, 5);
		d.Name = "panel2";
		d.Size = new Size(294, 208);
		d.TabIndex = 18;
		h.AutoToday = true;
		h.BackColor = Color.SeaShell;
		h.BijanForeColor = Color.Blue;
		h.Location = new Point(66, 53);
		h.Name = "txtDatafrom";
		h.Size = new Size(144, 24);
		h.TabIndex = 39;
		h.the_date = new DateTime(2019, 1, 3, 13, 22, 58, 109);
		h.the_label = "ازمون تاريخ:";
		g.Location = new Point(40, 92);
		g.Name = "btnStart";
		g.Size = new Size(201, 40);
		g.TabIndex = 5;
		g.Text = "ورود غیبت و تاخیر";
		g.UseVisualStyleBackColor = true;
		g.Click += a;
		f.AutoSize = true;
		f.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		f.ForeColor = Color.DarkViolet;
		f.Location = new Point(122, 13);
		f.Name = "label4";
		f.Size = new Size(52, 28);
		f.TabIndex = 38;
		f.Text = "تاریخ ";
		c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		c.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		c.ImageSize = new Size(40, 40);
		c.Location = new Point(40, 142);
		c.Name = "btnClose";
		c.Size = new Size(201, 35);
		c.TabIndex = 6;
		c.Text = "بستن";
		c.Click += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(304, 220);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		Name = "frmDisciplinaryAddAbsentSelectDate";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "انتخاب تاریخ برای ثبت غیبت و تاخیر";
		this.m_b.ResumeLayout(performLayout: false);
		e.ResumeLayout(performLayout: false);
		d.ResumeLayout(performLayout: false);
		d.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
