using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdbl : Form
{
	private Panel m_a;

	private Panel m_b;

	private Panel m_c;

	private UIButton m_d;

	private EditBox e;

	private UIButton f;

	private SaveFileDialog g;

	private OpenFileDialog h;

	private Label i;

	private UIButton j;

	private Label k;

	private Container l = null;

	public asdbl()
	{
		a();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
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
					goto case 5;
				case 2:
					num = 5;
					continue;
				case 4:
					l.Dispose();
					num = 2;
					continue;
				case 1:
					flag = l == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 5:
					((Form)this).Dispose(A_0);
					return;
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
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbl));
		this.m_a = new Panel();
		this.m_b = new Panel();
		k = new Label();
		this.m_c = new Panel();
		j = new UIButton();
		i = new Label();
		this.m_d = new UIButton();
		e = new EditBox();
		f = new UIButton();
		g = new SaveFileDialog();
		h = new OpenFileDialog();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(8, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(499, 224);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)k);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(7, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(482, 203);
		((Control)this.m_b).TabIndex = 16;
		((Control)k).AutoSize = true;
		((Control)k).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)k).Location = new Point(109, 10);
		((Control)k).Name = "label2";
		((Control)k).Size = new Size(267, 16);
		((Control)k).TabIndex = 4;
		((Control)k).Text = "در صورت تمایل میتوانید از برنامه پشتیبان بگیرید";
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)e);
		((Control)this.m_c).Controls.Add((Control)(object)f);
		((Control)this.m_c).Location = new Point(19, 44);
		((Control)this.m_c).Name = "panel3";
		((Control)this.m_c).Size = new Size(443, 150);
		((Control)this.m_c).TabIndex = 0;
		j.ButtonStyle = (ButtonStyle)1;
		((Control)j).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		j.Image = (Image)componentResourceManager.GetObject("uiButton5.Image");
		j.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		j.ImageIndex = 8;
		j.ImageSize = new Size(50, 50);
		((Control)j).Location = new Point(22, 82);
		((Control)j).Name = "uiButton5";
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(189, 51);
		((Control)j).TabIndex = 45;
		((Control)j).Text = "خروج";
		j.VisualStyle = (VisualStyle)1;
		((Control)j).Click += b;
		((Control)i).AutoSize = true;
		((Control)i).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)i).Location = new Point(163, 14);
		((Control)i).Name = "label1";
		((Control)i).Size = new Size(180, 16);
		((Control)i).TabIndex = 3;
		((Control)i).Text = "مسير قرار گيري نسخه پشتيبان";
		((Control)this.m_d).Font = new Font("Tahoma", 11.25f);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnBackup.Image");
		this.m_d.ImageSize = new Size(50, 50);
		((Control)this.m_d).Location = new Point(242, 82);
		((Control)this.m_d).Name = "btnBackup";
		((Control)this.m_d).Size = new Size(189, 51);
		((Control)this.m_d).TabIndex = 2;
		((Control)this.m_d).Text = "تهيه نسخه پشتيبان";
		((Control)this.m_d).Click += c;
		((EditBase)e).AutoScroll = false;
		((EditBase)e).AutoScrollMargin = new Size(0, 0);
		((EditBase)e).AutoScrollMinSize = new Size(0, 0);
		((EditBase)e).AutoScrollPosition = new Point(0, 0);
		((Control)e).Location = new Point(84, 43);
		((Control)e).Name = "txtbackup";
		((Control)e).Size = new Size(356, 20);
		((Control)e).TabIndex = 1;
		((EditBase)e).TextAlignment = (TextAlignment)1;
		((Control)f).Font = new Font("Tahoma", 8.25f);
		f.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		f.ImageSize = new Size(30, 30);
		((Control)f).Location = new Point(3, 38);
		((Control)f).Name = "uiButton1";
		((Control)f).Size = new Size(75, 35);
		((Control)f).TabIndex = 0;
		((Control)f).Text = "انتخاب مسير";
		((Control)f).Click += d;
		((FileDialog)h).FileName = "openFileDialog1";
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.FromArgb(184, 203, 255);
		((Form)this).ClientSize = new Size(514, 242);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmbackUpClosing";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "پیشتیبان";
		((Form)this).Load += a;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		while (true)
		{
			((FileDialog)g).FileName = Application.StartupPath + "\\Backup\\backup_" + ShamsiDate.GetShamsiDate(DateTime.Today).Replace("/", "") + "-" + DateTime.Now.Hour + DateTime.Now.Minute;
			DialogResult val = ((CommonDialog)g).ShowDialog();
			bool flag = (int)val != 1;
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
					return;
				case 5:
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					((Control)e).Text = ((FileDialog)g).FileName + ".bak";
					num = 5;
					continue;
				case 2:
					flag = !(((FileDialog)g).FileName != "");
					num = 4;
					continue;
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)e).Text != "");
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
					return;
				case 3:
					MessageBox.Show("تهيه نسخه پشتيبان با موفقیت انجام شد", "", (MessageBoxButtons)0, (MessageBoxIcon)0);
					((Form)this).Close();
					num = 4;
					continue;
				case 0:
				{
					int num2 = asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "Backup DATABASE school_af_kbr to  DISK = N'" + ((Control)e).Text + "'");
					flag = num2 != -1;
					num = 5;
					continue;
				}
				case 5:
					if (flag)
					{
						MessageBox.Show("خطا در تهيه نسخه پشتيبان", "خطا", (MessageBoxButtons)0, (MessageBoxIcon)16);
						num = 6;
					}
					else
					{
						num = 3;
					}
					continue;
				case 4:
				case 6:
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
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
		if (true)
		{
		}
		((Control)e).Text = Application.StartupPath + "\\Backup\\backup_" + ShamsiDate.GetShamsiDate(DateTime.Today).Replace("/", "") + "-" + DateTime.Now.Hour + DateTime.Now.Minute;
	}
}
