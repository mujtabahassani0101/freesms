using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
protected override void Dispose(bool A_0)
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
						base.Dispose(A_0);
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
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb6));
		this.m_b = new UIButton();
		this.m_c = new Label();
		d = new EditBox();
		e = new UIButton();
		SuspendLayout();
		this.m_b.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_b.ImageSize = new Size(40, 40);
		this.m_b.Location = new Point(31, 58);
		this.m_b.Name = "btnClose";
		this.m_b.Size = new Size(123, 43);
		this.m_b.TabIndex = 110;
		this.m_b.Text = "بستن";
		this.m_b.Click += b;
		this.m_c.AutoSize = true;
		this.m_c.Location = new Point(368, 30);
		this.m_c.Name = "label3";
		this.m_c.Size = new Size(35, 13);
		this.m_c.TabIndex = 117;
		this.m_c.Text = "توکن :";
		d.AutoScroll = false;
		d.AutoScrollMargin = new Size(0, 0);
		d.AutoScrollMinSize = new Size(0, 0);
		d.AutoScrollPosition = new Point(0, 0);
		d.Location = new Point(31, 25);
		d.MaxLength = 300;
		d.Name = "txttoken";
		d.PasswordChar = '*';
		d.Size = new Size(331, 21);
		d.TabIndex = 116;
		d.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		e.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		e.ImageSize = new Size(30, 30);
		e.Location = new Point(160, 58);
		e.Name = "btnAcp";
		e.Size = new Size(107, 43);
		e.TabIndex = 118;
		e.Text = "ثبت";
		e.Click += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(448, 116);
		Controls.Add(e);
		Controls.Add(this.m_c);
		Controls.Add(d);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmTelegramConfig";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "تنظیمات ربات تلگرام";
		Load += c;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public asdb6()
	{
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
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
					d.Text = asdab.c(dataTable.Rows[0]["telegramtoken"].ToString());
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
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
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
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@telegramtoken", SqlDbType.NVarChar, 500, asdab.d(d.Text)) };
		asdcb.d(asdab.e(), CommandType.Text, "if not exists(select telegramtoken from tTelegramConfig)\r\n                                    INSERT INTO tTelegramConfig (telegramtoken) VALUES     (@telegramtoken)\r\n                                    else\r\n                                    update tTelegramConfig set telegramtoken=@telegramtoken", a_);
		MessageBox.Show("ثبت شد");
	}
}
