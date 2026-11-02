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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		if (true)
		{
		}
		this.m_b = new TextBox();
		c = new TextBox();
		d = new Button();
		e = new Button();
		f = new TextBox();
		((Control)this).SuspendLayout();
		((Control)this.m_b).Location = new Point(27, 55);
		((Control)this.m_b).Name = "textBox1";
		((Control)this.m_b).Size = new Size(412, 20);
		((Control)this.m_b).TabIndex = 0;
		((Control)c).Location = new Point(27, 136);
		((Control)c).Name = "textBox2";
		((Control)c).Size = new Size(420, 20);
		((Control)c).TabIndex = 1;
		((Control)d).Location = new Point(96, 101);
		((Control)d).Name = "btnCode";
		((Control)d).Size = new Size(75, 23);
		((Control)d).TabIndex = 2;
		((Control)d).Text = "Code";
		((ButtonBase)d).UseVisualStyleBackColor = true;
		((Control)d).Click += b;
		((Control)e).Location = new Point(210, 101);
		((Control)e).Name = "button2";
		((Control)e).Size = new Size(75, 23);
		((Control)e).TabIndex = 3;
		((Control)e).Text = "btnDecode";
		((ButtonBase)e).UseVisualStyleBackColor = true;
		((Control)e).Click += a;
		((Control)f).Location = new Point(27, 12);
		((Control)f).Name = "textBox3";
		f.PasswordChar = '*';
		((Control)f).Size = new Size(75, 20);
		((Control)f).TabIndex = 4;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(510, 425);
		((Control)this).Controls.Add((Control)(object)f);
		((Control)this).Controls.Add((Control)(object)e);
		((Control)this).Controls.Add((Control)(object)d);
		((Control)this).Controls.Add((Control)(object)c);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Name = "frmcode_decode";
		((Control)this).Text = "frmcode_decode";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public asde()
	{
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(((Control)f).Text == "qaz159");
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
					((Control)c).Text = asdab.d(((Control)this.m_b).Text);
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
				bool flag = !(((Control)f).Text == "qaz159");
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
						((Control)c).Text = asdab.c(((Control)this.m_b).Text);
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
			((Control)c).Text = "";
		}
		if (1 == 0)
		{
		}
	}
}
