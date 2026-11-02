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
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
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
					((Form)asdbu2).ShowDialog();
					return;
				}
				}
				break;
			}
		}
	}

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
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
		((Control)this.m_b).SuspendLayout();
		((Control)e).SuspendLayout();
		((Control)d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)e);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(304, 220);
		((Control)this.m_b).TabIndex = 0;
		((Control)e).BackColor = SystemColors.ControlText;
		((Control)e).Controls.Add((Control)(object)d);
		((Control)e).Dock = (DockStyle)5;
		((Control)e).Location = new Point(0, 0);
		((Control)e).Name = "panel3";
		((Control)e).Size = new Size(302, 218);
		((Control)e).TabIndex = 19;
		((Control)d).BackColor = SystemColors.GradientInactiveCaption;
		((Control)d).Controls.Add((Control)(object)h);
		((Control)d).Controls.Add((Control)(object)g);
		((Control)d).Controls.Add((Control)(object)f);
		((Control)d).Controls.Add((Control)(object)c);
		((Control)d).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)d).Location = new Point(4, 5);
		((Control)d).Name = "panel2";
		((Control)d).Size = new Size(294, 208);
		((Control)d).TabIndex = 18;
		h.AutoToday = true;
		((Control)h).BackColor = Color.SeaShell;
		h.BijanForeColor = Color.Blue;
		((Control)h).Location = new Point(66, 53);
		((Control)h).Name = "txtDatafrom";
		((Control)h).Size = new Size(144, 24);
		((Control)h).TabIndex = 39;
		h.the_date = new DateTime(2019, 1, 3, 13, 22, 58, 109);
		h.the_label = "ازمون تاريخ:";
		((Control)g).Location = new Point(40, 92);
		((Control)g).Name = "btnStart";
		((Control)g).Size = new Size(201, 40);
		((Control)g).TabIndex = 5;
		((Control)g).Text = "ورود غیبت و تاخیر";
		((ButtonBase)g).UseVisualStyleBackColor = true;
		((Control)g).Click += a;
		((Control)f).AutoSize = true;
		((Control)f).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)f).ForeColor = Color.DarkViolet;
		((Control)f).Location = new Point(122, 13);
		((Control)f).Name = "label4";
		((Control)f).Size = new Size(52, 28);
		((Control)f).TabIndex = 38;
		((Control)f).Text = "تاریخ ";
		c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		c.ImageSize = new Size(40, 40);
		((Control)c).Location = new Point(40, 142);
		((Control)c).Name = "btnClose";
		((Control)c).Size = new Size(201, 35);
		((Control)c).TabIndex = 6;
		((Control)c).Text = "بستن";
		((Control)c).Click += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(304, 220);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmDisciplinaryAddAbsentSelectDate";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "انتخاب تاریخ برای ثبت غیبت و تاخیر";
		((Control)this.m_b).ResumeLayout(false);
		((Control)e).ResumeLayout(false);
		((Control)d).ResumeLayout(false);
		((Control)d).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
