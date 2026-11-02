using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class asdan : UserControl
{
	public int a;

	public int b;

	public string c = "";

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
		return ((Control)h).Font;
	}

	[SpecialName]
	public void a(Font A_0)
	{
		((Control)h).Font = A_0;
	}

	[SpecialName]
	public string c()
	{
		return ((Control)h).Text;
	}

	[SpecialName]
	public void a(string A_0)
	{
		((Control)h).Text = A_0;
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Invalid comparison between I4 and Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.Button != 1048576;
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
					flag = (int)A_1.Button != 2097152;
					num = 4;
					continue;
				case 9:
					this.c = "";
					i.Font = ((Control)h).Font;
					flag = 1 != (int)((CommonDialog)i).ShowDialog();
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
					((Control)this).Parent.Tag = "1";
					this.c = ((Control)this).Name;
					((Control)this).BackColor = Color.FromName("LightSkyBlue");
					((Control)j).Focus();
					num = 2;
					continue;
				case 0:
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					this.m_d = false;
					this.a = A_1.X;
					this.b = A_1.Y;
					flag = !(this.c == "");
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 11;
						continue;
					}
					((Control)this).Parent.Tag = "0";
					this.c = "";
					((Control)this).BackColor = Color.FromName("Control");
					num = 8;
					continue;
				case 5:
					((Control)h).Font = i.Font;
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
		((Control)h).Height = ((Control)this).Height + 1;
		((Control)h).Width = ((Control)this).Width + 1;
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
						((ContainerControl)this).Dispose(disposing);
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
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		if (true)
		{
		}
		g = new CheckBox();
		h = new Label();
		i = new FontDialog();
		j = new TextBox();
		((Control)this).SuspendLayout();
		((Control)g).AutoSize = true;
		((Control)g).Location = new Point(3, 3);
		((Control)g).Name = "checkBox1";
		((Control)g).Size = new Size(15, 14);
		((Control)g).TabIndex = 0;
		((Control)g).TabStop = false;
		((ButtonBase)g).UseVisualStyleBackColor = true;
		((Control)h).Dock = (DockStyle)4;
		((Control)h).Location = new Point(-1, 0);
		((Control)h).Name = "label1";
		((Control)h).RightToLeft = (RightToLeft)1;
		((Control)h).Size = new Size(148, 27);
		((Control)h).TabIndex = 1;
		((Control)h).Text = "10";
		h.TextAlign = (ContentAlignment)16;
		((Control)h).MouseDown += a;
		((Control)j).Location = new Point(115, 31);
		((Control)j).Name = "textBox1";
		((Control)j).Size = new Size(0, 20);
		((Control)j).TabIndex = 2;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((UserControl)this).BorderStyle = (BorderStyle)1;
		((Control)this).Controls.Add((Control)(object)j);
		((Control)this).Controls.Add((Control)(object)g);
		((Control)this).Controls.Add((Control)(object)h);
		((Control)this).Name = "UserControl1";
		((Control)this).Size = new Size(147, 27);
		((Control)this).Resize += a;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
