using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class asde : Form
{
	private IContainer m_a = null;

	private TextBox m_b;

	private TextBox c;

	private Button d;

	private Button e;

	private TextBox f;
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						num = 6;
					}
					continue;
				case 2:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 0;
				case 6:
					num2 = 1;
					goto IL_007c;
				case 0:
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
		this.m_b = new TextBox();
		c = new TextBox();
		d = new Button();
		e = new Button();
		f = new TextBox();
		SuspendLayout();
		this.m_b.Location = new Point(27, 55);
		this.m_b.Name = "textBox1";
		this.m_b.Size = new Size(412, 20);
		this.m_b.TabIndex = 0;
		c.Location = new Point(27, 136);
		c.Name = "textBox2";
		c.Size = new Size(420, 20);
		c.TabIndex = 1;
		d.Location = new Point(96, 101);
		d.Name = "btnCode";
		d.Size = new Size(75, 23);
		d.TabIndex = 2;
		d.Text = "Code";
		d.UseVisualStyleBackColor = true;
		d.Click += b;
		e.Location = new Point(210, 101);
		e.Name = "button2";
		e.Size = new Size(75, 23);
		e.TabIndex = 3;
		e.Text = "btnDecode";
		e.UseVisualStyleBackColor = true;
		e.Click += a;
		f.Location = new Point(27, 12);
		f.Name = "textBox3";
		f.PasswordChar = '*';
		f.Size = new Size(75, 20);
		f.TabIndex = 4;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(510, 425);
		Controls.Add(f);
		Controls.Add(e);
		Controls.Add(d);
		Controls.Add(c);
		Controls.Add(this.m_b);
		Name = "frmcode_decode";
		Text = "frmcode_decode";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public asde()
	{
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(f.Text == "qaz159");
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
					c.Text = asdab.d(this.m_b.Text);
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			while (true)
			{
				IL_001e:
				bool flag = !(f.Text == "qaz159");
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 2:
						if (!flag)
						{
							num = 0;
							continue;
						}
						goto case 3;
					case 0:
						c.Text = asdab.c(this.m_b.Text);
						num = 3;
						continue;
					case 3:
						num = 1;
						continue;
					case 1:
						goto end_IL_0005;
					}
					goto IL_001e;
					continue;
					end_IL_0005:
					break;
				}
				break;
			}
		}
		catch
		{
			c.Text = "";
		}
		if (1 == 0)
		{
		}
	}
}
