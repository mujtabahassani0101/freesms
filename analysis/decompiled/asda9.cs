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

public class asda9 : Form
{
	private Panel m_a;

	private Panel m_b;

	private Panel m_c;

	private UIButton m_d;

	private EditBox m_e;

	private UIButton m_f;

	private SaveFileDialog g;

	private OpenFileDialog h;

	private Panel i;

	private Label j;

	private UIButton k;

	private EditBox l;

	private UIButton m;

	private Label n;

	private UIButton o;

	private Container p = null;

	public asda9()
	{
		a();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 0:
					num = 1;
					continue;
				case 2:
					p.Dispose();
					num = 0;
					continue;
				case 3:
					flag = p == null;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 1:
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
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected Obj, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected Obj, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected Obj, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda9));
		this.m_a = new Panel();
		this.m_b = new Panel();
		o = new UIButton();
		i = new Panel();
		j = new Label();
		k = new UIButton();
		l = new EditBox();
		m = new UIButton();
		this.m_c = new Panel();
		n = new Label();
		this.m_d = new UIButton();
		this.m_e = new EditBox();
		this.m_f = new UIButton();
		g = new SaveFileDialog();
		h = new OpenFileDialog();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)i).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(8, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(499, 427);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)o);
		((Control)this.m_b).Controls.Add((Control)(object)i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(7, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(482, 408);
		((Control)this.m_b).TabIndex = 16;
		o.ButtonStyle = (ButtonStyle)1;
		((Control)o).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		o.Image = (Image)componentResourceManager.GetObject("uiButton5.Image");
		o.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		o.ImageIndex = 8;
		o.ImageSize = new Size(50, 50);
		((Control)o).Location = new Point(19, 344);
		((Control)o).Name = "uiButton5";
		((Control)o).RightToLeft = (RightToLeft)1;
		((Control)o).Size = new Size(443, 45);
		((Control)o).TabIndex = 45;
		((Control)o).Text = "خروج";
		o.VisualStyle = (VisualStyle)1;
		((Control)o).Click += b;
		((Control)i).Controls.Add((Control)(object)j);
		((Control)i).Controls.Add((Control)(object)k);
		((Control)i).Controls.Add((Control)(object)l);
		((Control)i).Controls.Add((Control)(object)m);
		((Control)i).Location = new Point(18, 179);
		((Control)i).Name = "panel4";
		((Control)i).Size = new Size(443, 150);
		((Control)i).TabIndex = 1;
		((Control)j).AutoSize = true;
		((Control)j).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)j).Location = new Point(180, 14);
		((Control)j).Name = "label2";
		((Control)j).Size = new Size(115, 16);
		((Control)j).TabIndex = 3;
		((Control)j).Text = "مسير فايل پشتيبان";
		((Control)k).Font = new Font("Tahoma", 11.25f);
		k.Image = (Image)componentResourceManager.GetObject("btnRestor.Image");
		k.ImageSize = new Size(50, 50);
		((Control)k).Location = new Point(111, 71);
		((Control)k).Name = "btnRestor";
		((Control)k).Size = new Size(260, 63);
		((Control)k).TabIndex = 2;
		((Control)k).Text = "بازگردانی نسخه پشتیبان";
		((Control)k).Click += c;
		((EditBase)l).AutoScroll = false;
		((EditBase)l).AutoScrollMargin = new Size(0, 0);
		((EditBase)l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)l).AutoScrollPosition = new Point(0, 0);
		((Control)l).Location = new Point(84, 43);
		((Control)l).Name = "txtResore";
		((Control)l).Size = new Size(356, 20);
		((Control)l).TabIndex = 1;
		((EditBase)l).TextAlignment = (TextAlignment)1;
		((Control)m).Font = new Font("Tahoma", 8.25f);
		m.Image = (Image)componentResourceManager.GetObject("uiButton4.Image");
		m.ImageSize = new Size(30, 30);
		((Control)m).Location = new Point(3, 38);
		((Control)m).Name = "uiButton4";
		((Control)m).Size = new Size(75, 35);
		((Control)m).TabIndex = 0;
		((Control)m).Text = "انتخاب مسير";
		((Control)m).Click += d;
		((Control)this.m_c).Controls.Add((Control)(object)n);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Location = new Point(19, 15);
		((Control)this.m_c).Name = "panel3";
		((Control)this.m_c).Size = new Size(443, 150);
		((Control)this.m_c).TabIndex = 0;
		((Control)n).AutoSize = true;
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(163, 14);
		((Control)n).Name = "label1";
		((Control)n).Size = new Size(180, 16);
		((Control)n).TabIndex = 3;
		((Control)n).Text = "مسير قرار گيري نسخه پشتيبان";
		((Control)this.m_d).Font = new Font("Tahoma", 11.25f);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnBackup.Image");
		this.m_d.ImageSize = new Size(50, 50);
		((Control)this.m_d).Location = new Point(110, 71);
		((Control)this.m_d).Name = "btnBackup";
		((Control)this.m_d).Size = new Size(261, 51);
		((Control)this.m_d).TabIndex = 2;
		((Control)this.m_d).Text = "تهيه نسخه پشتيبان";
		((Control)this.m_d).Click += e;
		((EditBase)this.m_e).AutoScroll = false;
		((EditBase)this.m_e).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_e).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_e).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_e).Location = new Point(84, 43);
		((Control)this.m_e).Name = "txtbackup";
		((Control)this.m_e).Size = new Size(356, 20);
		((Control)this.m_e).TabIndex = 1;
		((EditBase)this.m_e).TextAlignment = (TextAlignment)1;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f);
		this.m_f.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		this.m_f.ImageSize = new Size(30, 30);
		((Control)this.m_f).Location = new Point(3, 38);
		((Control)this.m_f).Name = "uiButton1";
		((Control)this.m_f).Size = new Size(75, 35);
		((Control)this.m_f).TabIndex = 0;
		((Control)this.m_f).Text = "انتخاب مسير";
		((Control)this.m_f).Click += f;
		((FileDialog)h).FileName = "openFileDialog1";
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.FromArgb(184, 203, 255);
		((Form)this).ClientSize = new Size(514, 445);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmbackUp";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "پیشتیبان";
		((Form)this).Load += a;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)i).ResumeLayout(false);
		((Control)i).PerformLayout();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void f(object A_0, EventArgs A_1)
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
						num = 4;
						continue;
					}
					return;
				case 1:
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					((Control)this.m_e).Text = ((FileDialog)g).FileName + ".bak";
					num = 1;
					continue;
				case 4:
					flag = !(((FileDialog)g).FileName != "");
					num = 3;
					continue;
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)this.m_e).Text != "");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 4:
					MessageBox.Show("تهيه نسخه پشتيبان با موفقیت انجام شد", "", (MessageBoxButtons)0, (MessageBoxIcon)0);
					num = 0;
					continue;
				case 1:
				{
					int num2 = asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "Backup DATABASE school_af_kbr to  DISK = N'" + ((Control)this.m_e).Text + "'");
					flag = num2 != -1;
					num = 5;
					continue;
				}
				case 5:
					if (flag)
					{
						MessageBox.Show("خطا در تهيه نسخه پشتيبان", "خطا", (MessageBoxButtons)0, (MessageBoxIcon)16);
						num = 3;
					}
					else
					{
						num = 4;
					}
					continue;
				case 0:
				case 3:
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

	private void d(object A_0, EventArgs A_1)
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = !(asdab.r == "1");
					num = 8;
					continue;
				case 9:
					flag = !(((FileDialog)h).FileName != "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 11;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 8:
					if (flag)
					{
						DialogResult val = ((CommonDialog)h).ShowDialog();
						flag = (int)val != 1;
						num = 3;
					}
					else
					{
						num = 1;
					}
					continue;
				case 11:
					if (true)
					{
					}
					num = 0;
					continue;
				case 0:
					return;
				case 10:
					MessageBox.Show("اجازه بازگردانی دارد admin فقط کاربر");
					num = 2;
					continue;
				case 2:
					return;
				case 6:
					((Control)l).Text = ((FileDialog)h).FileName;
					num = 11;
					continue;
				case 1:
					MessageBox.Show("بازگرانی فقط باید از کامپیوتر اصلی صورت بگیرید");
					num = 7;
					continue;
				case 7:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(asdab.r == "1");
					num = 6;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					MessageBox.Show("خطا در بازگرداني نسخه پشتيبان");
					num = 0;
					continue;
				case 2:
					if (true)
					{
					}
					if (flag)
					{
						asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "declare @vcdbname varchar(50)\r\n\t\t\t\t\t\t\tSet @vcdbname = 'school_af_kbr'\r\n\t\t\t\t\t\t\tset nocount on\r\n\t\t\t\t\t\t\tdeclare Users cursor for\r\n\t\t\t\t\t\t\tselect spid\r\n\t\t\t\t\t\t\tfrom master..sysprocesses\r\n\t\t\t\t\t\t\twhere db_name(dbid) = @vcdbname\r\n\t\t\t\t\t\t\tdeclare @spid int, @str varchar(255)\r\n\t\t\t\t\t\t\topen users\r\n\t\t\t\t\t\t\tfetch next from users into @spid\r\n\t\t\t\t\t\t\twhile @@fetch_status <> -1\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tif @@fetch_status = 0\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tset @str = 'kill ' + convert(varchar, @spid)\r\n\t\t\t\t\t\t\t\texec (@str)\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\tfetch next from users into @spid\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\tdeallocate users ");
						int num2 = asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "RESTORE DATABASE school_af_kbr from  DISK = N'" + ((Control)l).Text + "'");
						flag = num2 != -1;
						num = 7;
					}
					else
					{
						num = 11;
					}
					continue;
				case 6:
					if (!flag)
					{
						num = 15;
						continue;
					}
					flag = !(((Control)l).Text == "");
					num = 12;
					continue;
				case 1:
					MessageBox.Show("بازگرداني نسخه پشتيبان انجام شد ");
					Application.ExitThread();
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					MessageBox.Show("اجازه بازگردانی دارد admin فقط کاربر");
					num = 5;
					continue;
				case 5:
					return;
				case 11:
					MessageBox.Show("خطا در تهيه نسخه پشتيبان");
					num = 8;
					continue;
				case 8:
					return;
				case 0:
					return;
				case 12:
					if (flag)
					{
						int num2 = asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "Backup DATABASE school_af_kbr to  DISK = N'" + Application.StartupPath + "\\Backup\\RESTORE_backup_" + ShamsiDate.GetShamsiDate(DateTime.Today).Replace("/", "") + "-" + DateTime.Now.Hour + DateTime.Now.Minute + "'");
						flag = num2 == -1;
						num = 2;
					}
					else
					{
						num = 14;
					}
					continue;
				case 15:
					MessageBox.Show("فقط از کامپیوتر اصلی (سرور) این امکان وجود دارد", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 10;
					continue;
				case 10:
					return;
				case 14:
					MessageBox.Show("فایلی برای بازگردانی انتخاب نشده است");
					num = 13;
					continue;
				case 13:
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
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
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
						num = 1;
						continue;
					}
					goto case 2;
				case 3:
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
				case 1:
					num = 3;
					continue;
				case 2:
					((Control)this.m_e).Text = Application.StartupPath + "\\Backup\\backup_" + ShamsiDate.GetShamsiDate(DateTime.Today).Replace("/", "") + "-" + DateTime.Now.Hour + DateTime.Now.Minute;
					return;
				}
				break;
			}
		}
	}
}
