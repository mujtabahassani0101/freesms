using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class asdan : UserControl
{
	public int __field_a;

	public int __field_b;

	public string __field_c = "";

	private bool m_d = false;

	public string e;

	private IContainer f = null;

	private CheckBox g;

	private Label h;

	private FontDialog i;

	private TextBox j;

	public asdan()
	{
		a();
	}

	[SpecialName]
	public Font d()
	{
		return h.Font;
	}

	[SpecialName]
	public void a(Font A_0)
	{
		h.Font = A_0;
	}

	[SpecialName]
	public string c()
	{
		return h.Text;
	}

	[SpecialName]
	public void a(string A_0)
	{
		h.Text = A_0;
	}

	[SpecialName]
	public bool b()
	{
		return g.Checked;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		g.Checked = A_0;
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.Button != MouseButtons.Left;
			int num = 12;
			while (true)
			{
				switch (num)
				{
				case 12:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = A_1.Button != MouseButtons.Right;
					num = 4;
					continue;
				case 9:
					this.__field_c = "";
					i.Font = h.Font;
					flag = DialogResult.OK != i.ShowDialog();
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
						continue;
					}
					goto case 0;
				case 4:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 11:
					Parent.Tag = "1";
					this.__field_c = Name;
					BackColor = Color.FromName("LightSkyBlue");
					j.Focus();
					num = 2;
					continue;
				case 0:
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					this.m_d = false;
					this.__field_a = A_1.X;
					this.__field_b = A_1.Y;
					flag = !(this.__field_c == "");
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 11;
						continue;
					}
					Parent.Tag = "0";
					this.__field_c = "";
					BackColor = Color.FromName("Control");
					num = 8;
					continue;
				case 5:
					h.Font = i.Font;
					num = 0;
					continue;
				case 2:
				case 8:
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		h.Height = Height + 1;
		h.Width = Width + 1;
	}

	protected override void Dispose(bool disposing)
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
					num = ((!disposing) ? 5 : 6);
					continue;
				case 6:
					num = 0;
					continue;
				case 0:
					num2 = ((f == null) ? 1 : 0);
					goto IL_0074;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 4:
					if (true)
					{
					}
					f.Dispose();
					num = 2;
					continue;
				case 5:
					num2 = 1;
					goto IL_0074;
				case 2:
					{
						base.Dispose(disposing);
						return;
					}
					IL_0074:
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
		g = new CheckBox();
		h = new Label();
		i = new FontDialog();
		j = new TextBox();
		SuspendLayout();
		g.AutoSize = true;
		g.Location = new Point(3, 3);
		g.Name = "checkBox1";
		g.Size = new Size(15, 14);
		g.TabIndex = 0;
		g.TabStop = false;
		g.UseVisualStyleBackColor = true;
		h.Dock = DockStyle.Right;
		h.Location = new Point(-1, 0);
		h.Name = "label1";
		h.RightToLeft = RightToLeft.Yes;
		h.Size = new Size(148, 27);
		h.TabIndex = 1;
		h.Text = "10";
		h.TextAlign = ContentAlignment.MiddleLeft;
		h.MouseDown += a;
		j.Location = new Point(115, 31);
		j.Name = "textBox1";
		j.Size = new Size(0, 20);
		j.TabIndex = 2;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BorderStyle = BorderStyle.FixedSingle;
		Controls.Add(j);
		Controls.Add(g);
		Controls.Add(h);
		Name = "UserControl1";
		Size = new Size(147, 27);
		Resize += a;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
