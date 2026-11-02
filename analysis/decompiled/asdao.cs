using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.UI;

public class asdao : Form
{
	private Panel m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private CheckBox m_e;

	private CheckBox m_f;

	private CheckBox m_g;

	private CheckBox m_h;

	private CheckBox m_i;

	private UIComboBox m_j;

	private Label k;

	private CheckBox l;

	private CheckBox m;

	private Container n = null;

	public asdao()
	{
		j();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 1:
					num = 5;
					continue;
				case 3:
					n.Dispose();
					num = 1;
					continue;
				case 4:
					flag = n == null;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 5:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void j()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected Obj, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected Obj, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdao));
		this.m_a = new Panel();
		this.m_b = new Panel();
		m = new CheckBox();
		l = new CheckBox();
		this.m_j = new UIComboBox();
		k = new Label();
		this.m_e = new CheckBox();
		this.m_f = new CheckBox();
		this.m_i = new CheckBox();
		this.m_g = new CheckBox();
		this.m_h = new CheckBox();
		this.m_d = new UIButton();
		this.m_c = new UIButton();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(8, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(342, 333);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)m);
		((Control)this.m_b).Controls.Add((Control)(object)l);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_b).Controls.Add((Control)(object)k);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(7, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(326, 314);
		((Control)this.m_b).TabIndex = 16;
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(149, 120);
		((Control)m).Name = "chtch_book";
		((Control)m).RightToLeft = (RightToLeft)1;
		((Control)m).Size = new Size(135, 17);
		((Control)m).TabIndex = 58;
		((Control)m).Text = "حذف معلم- صنف- درس";
		((ButtonBase)m).TextAlign = (ContentAlignment)64;
		((ButtonBase)m).UseVisualStyleBackColor = true;
		((Control)l).AutoSize = true;
		((Control)l).Enabled = false;
		((Control)l).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(21, 15);
		((Control)l).Name = "checkTch";
		((Control)l).RightToLeft = (RightToLeft)1;
		((Control)l).Size = new Size(85, 17);
		((Control)l).TabIndex = 57;
		((Control)l).Text = "حذف معلمان";
		((ButtonBase)l).UseVisualStyleBackColor = true;
		l.CheckedChanged += a;
		((UIComboBase)this.m_j).ComboStyle = (ComboStyle)1;
		((Control)this.m_j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(35, 201);
		((Control)this.m_j).Name = "ComBoAzmoon";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(209, 21);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_j).StringFormat = val;
		((Control)this.m_j).TabIndex = 55;
		((Control)this.m_j).Visible = false;
		((Control)k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(247, 201);
		((Control)k).Name = "label1";
		((Control)k).RightToLeft = (RightToLeft)1;
		((Control)k).Size = new Size(40, 21);
		((Control)k).TabIndex = 56;
		((Control)k).Text = "دوره :";
		k.TextAlign = (ContentAlignment)64;
		((Control)k).Visible = false;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(193, 95);
		((Control)this.m_e).Name = "chstd";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(91, 17);
		((Control)this.m_e).TabIndex = 49;
		((Control)this.m_e).Text = "حذف شاگردان";
		((ButtonBase)this.m_e).UseVisualStyleBackColor = true;
		this.m_e.CheckedChanged += e;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(84, 171);
		((Control)this.m_f).Name = "chMark";
		((Control)this.m_f).RightToLeft = (RightToLeft)1;
		((Control)this.m_f).Size = new Size(200, 17);
		((Control)this.m_f).TabIndex = 48;
		((Control)this.m_f).Text = "حذف نمرات دوره و توضیحات زیر اطلاع نامه";
		((ButtonBase)this.m_f).TextAlign = (ContentAlignment)64;
		((ButtonBase)this.m_f).UseVisualStyleBackColor = true;
		this.m_f.CheckedChanged += b;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(163, 68);
		((Control)this.m_i).Name = "chStd_Img";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(121, 17);
		((Control)this.m_i).TabIndex = 47;
		((Control)this.m_i).Text = "حذف عکس شاگردان";
		((ButtonBase)this.m_i).UseVisualStyleBackColor = true;
		this.m_i.CheckedChanged += d;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Enabled = false;
		((Control)this.m_g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(21, 38);
		((Control)this.m_g).Name = "chbook";
		((Control)this.m_g).RightToLeft = (RightToLeft)1;
		((Control)this.m_g).Size = new Size(79, 17);
		((Control)this.m_g).TabIndex = 46;
		((Control)this.m_g).Text = "حذف دروس";
		((ButtonBase)this.m_g).TextAlign = (ContentAlignment)64;
		((ButtonBase)this.m_g).UseVisualStyleBackColor = true;
		this.m_g.CheckedChanged += f;
		((Control)this.m_h).AutoSize = true;
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(199, 146);
		((Control)this.m_h).Name = "chAzmoon_Emp";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(85, 17);
		((Control)this.m_h).TabIndex = 44;
		((Control)this.m_h).Text = "حذف دوره ها";
		((ButtonBase)this.m_h).TextAlign = (ContentAlignment)64;
		((ButtonBase)this.m_h).UseVisualStyleBackColor = true;
		this.m_h.CheckedChanged += g;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		this.m_d.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_d.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_d.ImageIndex = 8;
		this.m_d.ImageSize = new Size(30, 30);
		((Control)this.m_d).Location = new Point(50, 254);
		((Control)this.m_d).Name = "uiButton2";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		((Control)this.m_d).Size = new Size(104, 32);
		((Control)this.m_d).TabIndex = 42;
		((Control)this.m_d).Text = "خروج";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += h;
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_c.ImageSize = new Size(30, 30);
		((Control)this.m_c).Location = new Point(160, 253);
		((Control)this.m_c).Name = "btnEmpty";
		((Control)this.m_c).Size = new Size(106, 33);
		((Control)this.m_c).TabIndex = 41;
		((Control)this.m_c).Text = "حذف";
		((Control)this.m_c).Click += c;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.FromArgb(184, 203, 255);
		((Form)this).ClientSize = new Size(357, 349);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "FrmEmpty";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "خالی کردن بانک اطلاعاتی";
		((Form)this).Load += i;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(asdab.r == "1");
					num = 0;
					continue;
				case 8:
					num = 4;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 7;
					continue;
				case 5:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 10;
					continue;
				case 10:
					return;
				case 4:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_b).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 2:
					a();
					num = 9;
					continue;
				case 9:
					return;
				case 7:
					if (true)
					{
					}
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 2;
				case 3:
					MessageBox.Show("فقط از کامپیوتر اصلی (سرور) این امکان وجود دارد", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void i()
	{
		if (true)
		{
		}
		((Control)this.m_f).Enabled = false;
		this.m_f.Checked = true;
	}

	private void h()
	{
		if (true)
		{
		}
		((Control)this.m_f).Enabled = true;
		this.m_f.Checked = false;
	}

	private void g()
	{
		if (true)
		{
		}
		((Control)m).Enabled = false;
		m.Checked = true;
	}

	private void f()
	{
		while (true)
		{
			bool flag = !this.m_g.Checked;
			if (true)
			{
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					((Control)m).Enabled = true;
					m.Checked = false;
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					((Control)m).Enabled = false;
					m.Checked = true;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		if (true)
		{
		}
		((Control)this.m_f).Enabled = false;
		this.m_f.Checked = true;
		((Control)m).Enabled = false;
		m.Checked = true;
	}

	private void d()
	{
		while (true)
		{
			if (true)
			{
			}
			((Control)this.m_f).Enabled = true;
			this.m_f.Checked = false;
			bool flag = !l.Checked;
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
					((Control)m).Enabled = true;
					m.Checked = false;
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					((Control)m).Enabled = false;
					m.Checked = true;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		if (true)
		{
		}
		((Control)this.m_i).Enabled = false;
		((Control)this.m_f).Enabled = false;
		this.m_i.Checked = true;
		this.m_f.Checked = true;
	}

	private void b()
	{
		if (true)
		{
		}
		((Control)this.m_i).Enabled = true;
		((Control)this.m_f).Enabled = true;
		this.m_i.Checked = false;
		this.m_f.Checked = false;
	}

	private void g(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !this.m_h.Checked;
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 2;
						continue;
					}
					h();
					num = 6;
					continue;
				case 1:
					flag = !this.m_e.Checked;
					num = 9;
					continue;
				case 9:
					if (true)
					{
					}
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 0:
				case 6:
					flag = !this.m_g.Checked;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 2:
					i();
					num = 0;
					continue;
				case 3:
					c();
					num = 5;
					continue;
				case 5:
					return;
				case 4:
					e();
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !this.m_g.Checked;
			int num = 15;
			while (true)
			{
				switch (num)
				{
				case 15:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 16;
				case 11:
					flag = !this.m_e.Checked;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 9;
				case 9:
					flag = !this.m_i.Checked;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 10:
					try
					{
						this.m_j.SelectedIndex = 0;
					}
					catch
					{
					}
					num = 16;
					continue;
				case 14:
					i();
					num = 11;
					continue;
				case 6:
					this.m_f.Checked = true;
					((Control)this.m_f).Enabled = false;
					num = 12;
					continue;
				case 12:
					return;
				case 4:
					e();
					num = 3;
					continue;
				case 8:
					c();
					num = 9;
					continue;
				case 3:
				case 13:
					flag = !this.m_h.Checked;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 11;
				case 7:
					((Control)this.m_j).Visible = false;
					((Control)k).Visible = false;
					num = 10;
					continue;
				case 16:
					flag = !this.m_g.Checked;
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						d();
						if (true)
						{
						}
						num = 13;
					}
					else
					{
						num = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !this.m_e.Checked;
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 14;
				case 0:
					flag = !this.m_g.Checked;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 2;
				case 2:
					if (true)
					{
					}
					flag = !this.m_i.Checked;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 12:
					try
					{
						this.m_j.SelectedIndex = 0;
					}
					catch
					{
					}
					num = 14;
					continue;
				case 15:
					i();
					num = 0;
					continue;
				case 16:
					this.m_f.Checked = true;
					((Control)this.m_f).Enabled = false;
					num = 13;
					continue;
				case 13:
					return;
				case 6:
					c();
					num = 10;
					continue;
				case 11:
					e();
					num = 2;
					continue;
				case 8:
				case 10:
					flag = !this.m_h.Checked;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 0;
				case 1:
					((Control)this.m_j).Visible = false;
					((Control)k).Visible = false;
					num = 12;
					continue;
				case 14:
					flag = !this.m_e.Checked;
					num = 3;
					continue;
				case 3:
					if (flag)
					{
						b();
						num = 8;
					}
					else
					{
						num = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
	}

	private void a()
	{
		int num2 = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tExam where xyear=" + asdaj.a);
			bool flag = dataTable.Rows.Count <= 0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 8:
					this.m_j.SelectedIndex = 0;
					num = 6;
					continue;
				case 0:
				case 2:
					flag = num2 < dataTable.Rows.Count;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						this.m_j.Items.Add(dataTable.Rows[num2]["Name"].ToString(), (object)dataTable.Rows[num2]["id"].ToString());
						num2++;
						num = 0;
					}
					continue;
				case 7:
					num2 = 0;
					num = 2;
					continue;
				case 6:
					num = 9;
					continue;
				case 9:
					return;
				case 4:
					flag = dataTable.Rows.Count <= 1;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		while (true)
		{
			bool flag = (int)MessageBox.Show("آیا از حذف اطمینان دارید", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
			int num = 13;
			while (true)
			{
				switch (num)
				{
				case 13:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 9:
				{
					if (true)
					{
					}
					int num2 = asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "Backup DATABASE school_af_kbr to  DISK = N'" + Application.StartupPath + "\\Backup\\Delete_backup_" + ShamsiDate.GetShamsiDate(DateTime.Today).Replace("/", "") + "-" + DateTime.Now.Hour + DateTime.Now.Minute + "'");
					flag = ((CollectionBase)(object)this.m_j.Items).Count <= 0;
					num = 27;
					continue;
				}
				case 39:
					flag = !this.m_g.Checked;
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 30;
				case 23:
				case 42:
					num = 41;
					continue;
				case 16:
					flag = !this.m_f.Checked;
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 29;
						continue;
					}
					goto case 1;
				case 15:
					flag = !this.m_i.Checked;
					num = 33;
					continue;
				case 33:
					if (!flag)
					{
						num = 35;
						continue;
					}
					goto case 12;
				case 37:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 16;
				case 34:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tTch_Cls where xCls in(select id from tclass where xyear=" + asdaj.a + ")");
					num = 39;
					continue;
				case 12:
					flag = !this.m_e.Checked;
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 28;
				case 29:
					flag = ((Control)this.m_j).Visible;
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 36;
						continue;
					}
					goto case 18;
				case 35:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tStudentImg");
					num = 12;
					continue;
				case 28:
					MessageBox.Show("عملیات حذف انجام شد");
					num = 4;
					continue;
				case 4:
					return;
				case 6:
					flag = !((Control)this.m_j).Visible;
					num = 38;
					continue;
				case 38:
					if (flag)
					{
						asdcb.d(asdab.e(), CommandType.Text, "delete FROM tExam where term=0");
						num = 23;
					}
					else
					{
						num = 7;
					}
					continue;
				case 27:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 24;
				case 31:
					text = " where xtest =" + this.m_j.SelectedValue.ToString();
					num = 16;
					continue;
				case 36:
					text = "";
					num = 18;
					continue;
				case 18:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tMarkDoreh" + text);
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tMark" + text);
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tComnentKarname" + text);
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tEnzebat" + text);
					num = 1;
					continue;
				case 25:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tTeacher");
					num = 15;
					continue;
				case 3:
					num = 30;
					continue;
				case 7:
				{
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + this.m_j.SelectedValue.ToString()).ToString();
					flag = !(text2 == "0");
					num = 11;
					continue;
				}
				case 11:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 10;
				case 40:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tExam" + text.Replace("xtest", "id"));
					num = 10;
					continue;
				case 24:
					flag = !m.Checked;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 39;
				case 1:
					flag = !this.m_h.Checked;
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 41;
				case 5:
					MessageBox.Show("آزمون را انتخاب کنید");
					num = 0;
					continue;
				case 0:
					return;
				case 8:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tMarkAgo");
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tPaymentStudent");
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tDisciplinaryStudent");
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tComnentStd");
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tYear_Student");
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM tStudent");
					num = 28;
					continue;
				case 10:
					num = 42;
					continue;
				case 14:
					flag = this.m_j.SelectedIndex >= 0;
					num = 19;
					continue;
				case 19:
					if (flag)
					{
						text = "";
						flag = !(this.m_j.SelectedValue.ToString() != "0");
						num = 37;
					}
					else
					{
						num = 5;
					}
					continue;
				case 41:
					num = 24;
					continue;
				case 30:
					flag = !l.Checked;
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 15;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			((Control)this.m_j).Visible = this.m_f.Checked;
			((Control)k).Visible = this.m_f.Checked;
			bool flag = !this.m_e.Checked;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 6:
					try
					{
						this.m_j.SelectedIndex = 0;
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 3;
					continue;
				case 1:
					flag = !this.m_g.Checked;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 2:
					try
					{
						this.m_j.SelectedIndex = 0;
					}
					catch
					{
					}
					num = 1;
					continue;
				case 0:
					((Control)this.m_j).Visible = false;
					((Control)k).Visible = false;
					num = 2;
					continue;
				case 7:
					((Control)this.m_j).Visible = false;
					((Control)k).Visible = false;
					num = 6;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !l.Checked;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					f();
					num = 0;
					continue;
				case 0:
					return;
				case 1:
					g();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}
}
