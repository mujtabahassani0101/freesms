using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdb6 : Form
{
	private IContainer m_a = null;

	private UIButton m_b;

	private Label m_c;

	private EditBox d;

	private UIButton e;

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					if (A_0)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 3;
					}
					continue;
				case 1:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 6;
					continue;
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 6;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 6:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 5;
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
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb6));
		this.m_b = new UIButton();
		this.m_c = new Label();
		d = new EditBox();
		e = new UIButton();
		((Control)this).SuspendLayout();
		this.m_b.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_b.ImageSize = new Size(40, 40);
		((Control)this.m_b).Location = new Point(31, 58);
		((Control)this.m_b).Name = "btnClose";
		((Control)this.m_b).Size = new Size(123, 43);
		((Control)this.m_b).TabIndex = 110;
		((Control)this.m_b).Text = "بستن";
		((Control)this.m_b).Click += b;
		((Control)this.m_c).AutoSize = true;
		((Control)this.m_c).Location = new Point(368, 30);
		((Control)this.m_c).Name = "label3";
		((Control)this.m_c).Size = new Size(35, 13);
		((Control)this.m_c).TabIndex = 117;
		((Control)this.m_c).Text = "توکن :";
		((EditBase)d).AutoScroll = false;
		((EditBase)d).AutoScrollMargin = new Size(0, 0);
		((EditBase)d).AutoScrollMinSize = new Size(0, 0);
		((EditBase)d).AutoScrollPosition = new Point(0, 0);
		((Control)d).Location = new Point(31, 25);
		((EditBase)d).MaxLength = 300;
		((Control)d).Name = "txttoken";
		d.PasswordChar = '*';
		((Control)d).Size = new Size(331, 21);
		((Control)d).TabIndex = 116;
		((EditBase)d).TextAlignment = (TextAlignment)1;
		((Control)e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		e.ImageSize = new Size(30, 30);
		((Control)e).Location = new Point(160, 58);
		((Control)e).Name = "btnAcp";
		((Control)e).Size = new Size(107, 43);
		((Control)e).TabIndex = 118;
		((Control)e).Text = "ثبت";
		((Control)e).Click += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(448, 116);
		((Control)this).Controls.Add((Control)(object)e);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Control)this).Controls.Add((Control)(object)d);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmTelegramConfig";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "تنظیمات ربات تلگرام";
		((Form)this).Load += c;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public asdb6()
	{
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
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
						num = 2;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tTelegramConfig");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 5:
					((Control)d).Text = asdab.c(dataTable.Rows[0]["telegramtoken"].ToString());
					num = 3;
					continue;
				case 3:
					return;
				case 4:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 2:
					if (true)
					{
					}
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@telegramtoken", SqlDbType.NVarChar, 500, asdab.d(((Control)d).Text)) };
		asdcb.d(asdab.e(), CommandType.Text, "if not exists(select telegramtoken from tTelegramConfig)\r\n                                    INSERT INTO tTelegramConfig (telegramtoken) VALUES     (@telegramtoken)\r\n                                    else\r\n                                    update tTelegramConfig set telegramtoken=@telegramtoken", a_);
		MessageBox.Show("ثبت شد");
	}
}
