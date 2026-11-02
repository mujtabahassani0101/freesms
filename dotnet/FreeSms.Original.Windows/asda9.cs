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
protected override void Dispose(bool A_0)
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
					base.Dispose(A_0);
					return;
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
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		i.SuspendLayout();
		this.m_c.SuspendLayout();
		SuspendLayout();
		this.m_a.BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(8, 8);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(499, 427);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(o);
		this.m_b.Controls.Add(i);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new Point(7, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(482, 408);
		this.m_b.TabIndex = 16;
		o.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		o.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o.Image = (Image)componentResourceManager.GetObject("uiButton5.Image");
		o.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		o.ImageIndex = 8;
		o.ImageSize = new Size(50, 50);
		o.Location = new Point(19, 344);
		o.Name = "uiButton5";
		o.RightToLeft = RightToLeft.Yes;
		o.Size = new Size(443, 45);
		o.TabIndex = 45;
		o.Text = "خروج";
		o.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		o.Click += b;
		i.Controls.Add(j);
		i.Controls.Add(k);
		i.Controls.Add(l);
		i.Controls.Add(m);
		i.Location = new Point(18, 179);
		i.Name = "panel4";
		i.Size = new Size(443, 150);
		i.TabIndex = 1;
		j.AutoSize = true;
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j.Location = new Point(180, 14);
		j.Name = "label2";
		j.Size = new Size(115, 16);
		j.TabIndex = 3;
		j.Text = "مسير فايل پشتيبان";
		k.Font = new Font("Tahoma", 11.25f);
		k.Image = (Image)componentResourceManager.GetObject("btnRestor.Image");
		k.ImageSize = new Size(50, 50);
		k.Location = new Point(111, 71);
		k.Name = "btnRestor";
		k.Size = new Size(260, 63);
		k.TabIndex = 2;
		k.Text = "بازگردانی نسخه پشتیبان";
		k.Click += c;
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new Point(0, 0);
		l.Location = new Point(84, 43);
		l.Name = "txtResore";
		l.Size = new Size(356, 20);
		l.TabIndex = 1;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.Font = new Font("Tahoma", 8.25f);
		m.Image = (Image)componentResourceManager.GetObject("uiButton4.Image");
		m.ImageSize = new Size(30, 30);
		m.Location = new Point(3, 38);
		m.Name = "uiButton4";
		m.Size = new Size(75, 35);
		m.TabIndex = 0;
		m.Text = "انتخاب مسير";
		m.Click += d;
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Location = new Point(19, 15);
		this.m_c.Name = "panel3";
		this.m_c.Size = new Size(443, 150);
		this.m_c.TabIndex = 0;
		n.AutoSize = true;
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n.Location = new Point(163, 14);
		n.Name = "label1";
		n.Size = new Size(180, 16);
		n.TabIndex = 3;
		n.Text = "مسير قرار گيري نسخه پشتيبان";
		this.m_d.Font = new Font("Tahoma", 11.25f);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnBackup.Image");
		this.m_d.ImageSize = new Size(50, 50);
		this.m_d.Location = new Point(110, 71);
		this.m_d.Name = "btnBackup";
		this.m_d.Size = new Size(261, 51);
		this.m_d.TabIndex = 2;
		this.m_d.Text = "تهيه نسخه پشتيبان";
		this.m_d.Click += e;
		this.m_e.AutoScroll = false;
		this.m_e.AutoScrollMargin = new Size(0, 0);
		this.m_e.AutoScrollMinSize = new Size(0, 0);
		this.m_e.AutoScrollPosition = new Point(0, 0);
		this.m_e.Location = new Point(84, 43);
		this.m_e.Name = "txtbackup";
		this.m_e.Size = new Size(356, 20);
		this.m_e.TabIndex = 1;
		this.m_e.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_f.Font = new Font("Tahoma", 8.25f);
		this.m_f.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		this.m_f.ImageSize = new Size(30, 30);
		this.m_f.Location = new Point(3, 38);
		this.m_f.Name = "uiButton1";
		this.m_f.Size = new Size(75, 35);
		this.m_f.TabIndex = 0;
		this.m_f.Text = "انتخاب مسير";
		this.m_f.Click += f;
		h.FileName = "openFileDialog1";
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.FromArgb(184, 203, 255);
		ClientSize = new Size(514, 445);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmbackUp";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "پیشتیبان";
		Load += a;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		i.ResumeLayout(performLayout: false);
		i.PerformLayout();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			g.FileName = OriginalDatabaseMaintenance.NewBackupPath();
			DialogResult dialogResult = g.ShowDialog();
			bool flag = dialogResult != DialogResult.OK;
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
					this.m_e.Text = g.FileName + ".bak";
					num = 1;
					continue;
				case 4:
					flag = !(g.FileName != "");
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

	private async void e(object A_0, EventArgs A_1)
    {
        if(string.IsNullOrWhiteSpace(this.m_e.Text)){MessageBox.Show("مسیر فایل پشتیبان را مشخص کنید");return;}
        await OriginalDatabaseMaintenance.BackupAsync(this,this.m_e.Text);
    }

	private void d(object A_0, EventArgs A_1)
    {
        if(asdaj.l!="1"){MessageBox.Show("اجازه بازگردانی دارد admin فقط کاربر");return;}
        if(h.ShowDialog(this)==DialogResult.OK) l.Text=h.FileName;
    }

	private async void c(object A_0, EventArgs A_1)
    {
        if(asdaj.l!="1"){MessageBox.Show("اجازه بازگردانی دارد admin فقط کاربر");return;}
        if(string.IsNullOrWhiteSpace(l.Text)){MessageBox.Show("فایلی برای بازگردانی انتخاب نشده است");return;}
        if(await OriginalDatabaseMaintenance.RestoreAsync(this,l.Text)) Application.ExitThread();
    }

	private void b(object A_0, EventArgs A_1)
	{
		Close();
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
						this.m_b.BackColor = Color.FromArgb(red, green, blue);
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
					this.m_e.Text = OriginalDatabaseMaintenance.NewBackupPath();
					return;
				}
				break;
			}
		}
	}
}
