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
protected override void Dispose(bool A_0)
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
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		SuspendLayout();
		this.m_a.BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(8, 8);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(499, 224);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(k);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Location = new Point(7, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(482, 203);
		this.m_b.TabIndex = 16;
		k.AutoSize = true;
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k.Location = new Point(109, 10);
		k.Name = "label2";
		k.Size = new Size(267, 16);
		k.TabIndex = 4;
		k.Text = "در صورت تمایل میتوانید از برنامه پشتیبان بگیرید";
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(e);
		this.m_c.Controls.Add(f);
		this.m_c.Location = new Point(19, 44);
		this.m_c.Name = "panel3";
		this.m_c.Size = new Size(443, 150);
		this.m_c.TabIndex = 0;
		j.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		j.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j.Image = (Image)componentResourceManager.GetObject("uiButton5.Image");
		j.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		j.ImageIndex = 8;
		j.ImageSize = new Size(50, 50);
		j.Location = new Point(22, 82);
		j.Name = "uiButton5";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(189, 51);
		j.TabIndex = 45;
		j.Text = "خروج";
		j.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		j.Click += b;
		i.AutoSize = true;
		i.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i.Location = new Point(163, 14);
		i.Name = "label1";
		i.Size = new Size(180, 16);
		i.TabIndex = 3;
		i.Text = "مسير قرار گيري نسخه پشتيبان";
		this.m_d.Font = new Font("Tahoma", 11.25f);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnBackup.Image");
		this.m_d.ImageSize = new Size(50, 50);
		this.m_d.Location = new Point(242, 82);
		this.m_d.Name = "btnBackup";
		this.m_d.Size = new Size(189, 51);
		this.m_d.TabIndex = 2;
		this.m_d.Text = "تهيه نسخه پشتيبان";
		this.m_d.Click += c;
		e.AutoScroll = false;
		e.AutoScrollMargin = new Size(0, 0);
		e.AutoScrollMinSize = new Size(0, 0);
		e.AutoScrollPosition = new Point(0, 0);
		e.Location = new Point(84, 43);
		e.Name = "txtbackup";
		e.Size = new Size(356, 20);
		e.TabIndex = 1;
		e.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		f.Font = new Font("Tahoma", 8.25f);
		f.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		f.ImageSize = new Size(30, 30);
		f.Location = new Point(3, 38);
		f.Name = "uiButton1";
		f.Size = new Size(75, 35);
		f.TabIndex = 0;
		f.Text = "انتخاب مسير";
		f.Click += d;
		h.FileName = "openFileDialog1";
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.FromArgb(184, 203, 255);
		ClientSize = new Size(514, 242);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmbackUpClosing";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "پیشتیبان";
		Load += a;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void d(object A_0, EventArgs A_1)
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
					e.Text = g.FileName + ".bak";
					num = 5;
					continue;
				case 2:
					flag = !(g.FileName != "");
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

	private async void c(object A_0, EventArgs A_1)
    {
        if(string.IsNullOrWhiteSpace(e.Text)){MessageBox.Show("مسیر فایل پشتیبان را مشخص کنید");return;}
        if(await OriginalDatabaseMaintenance.BackupAsync(this,e.Text)) Close();
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
		e.Text = OriginalDatabaseMaintenance.NewBackupPath();
	}
}
