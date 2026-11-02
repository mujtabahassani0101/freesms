using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.UI;

public class asda7 : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private IContainer m_b = null;

	private Panel m_c;

	private Panel d;

	private Panel e;

	private UIButton f;

	private UIButton g;

	private Label h;

	private Label i;

	private Label j;

	public asda7()
	{
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 7;
					continue;
				case 3:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						e.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 6;
				case 6:
					i.Text = asdaj.__field_a;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				case 1:
					num = 3;
					continue;
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
		while (true)
		{
			bool flag = MessageBox.Show("آيا مطمئن هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					OriginalDatabaseMaintenance.BackupNamed("SetMark100_backup");
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set MarkTerm3_From100=1 where xYear=" + asdaj.__field_a);
					MessageBox.Show("ثبت شد");
					if (true)
					{
					}
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					num = ((!A_0) ? 2 : 5);
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 1:
					if (true)
					{
					}
					this.m_b.Dispose();
					num = 0;
					continue;
				case 2:
					num2 = 1;
					goto IL_0074;
				case 0:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 3;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda7));
		this.m_c = new Panel();
		d = new Panel();
		e = new Panel();
		i = new Label();
		j = new Label();
		h = new Label();
		g = new UIButton();
		f = new UIButton();
		this.m_c.SuspendLayout();
		d.SuspendLayout();
		e.SuspendLayout();
		SuspendLayout();
		this.m_c.BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(482, 314);
		this.m_c.TabIndex = 0;
		d.BackColor = Color.Black;
		d.Controls.Add(e);
		d.Dock = DockStyle.Fill;
		d.Location = new Point(0, 0);
		d.Name = "panel2";
		d.Size = new Size(480, 312);
		d.TabIndex = 44;
		e.BackColor = Color.FromArgb(214, 223, 247);
		e.Controls.Add(i);
		e.Controls.Add(j);
		e.Controls.Add(h);
		e.Controls.Add(g);
		e.Controls.Add(f);
		e.Location = new Point(3, 3);
		e.Name = "panel3";
		e.Size = new Size(473, 304);
		e.TabIndex = 0;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		i.BackColor = Color.CornflowerBlue;
		i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		i.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.ForeColor = Color.MediumBlue;
		i.Location = new Point(113, 14);
		i.Name = "lYear";
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(103, 32);
		i.TabIndex = 125;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoSize = true;
		j.BackColor = Color.CornflowerBlue;
		j.Font = new Font("B Nazanin", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.ForeColor = Color.DarkViolet;
		j.Location = new Point(222, 15);
		j.Name = "label1";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(98, 30);
		j.TabIndex = 124;
		j.Text = "سال تعلیمی :";
		h.Font = new Font("B Nazanin", 24f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.ForeColor = Color.DarkViolet;
		h.Location = new Point(26, 68);
		h.Name = "label4";
		h.Size = new Size(403, 105);
		h.TabIndex = 121;
		h.Text = "ورود نمره سالانه از 100 برای کل دانش آموزان در این سال تعلیمی";
		h.TextAlign = ContentAlignment.MiddleCenter;
		g.ButtonStyle = ButtonStyle.Button;
		g.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		g.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		g.ImageIndex = 8;
		g.ImageSize = new Size(40, 40);
		g.Location = new Point(55, 192);
		g.Name = "btnAcp";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(341, 40);
		g.TabIndex = 4;
		g.Text = "ثبت";
		g.VisualStyle = VisualStyle.OfficeXP;
		g.Click += a;
		f.DialogResult = DialogResult.Cancel;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		f.Location = new Point(55, 248);
		f.Name = "btnClose";
		f.Size = new Size(152, 40);
		f.TabIndex = 16;
		f.Text = "بستن";
		f.Click += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(482, 314);
		Controls.Add(this.m_c);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSetMark100";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "مشخصات مکتب";
		Load += c;
		this.m_c.ResumeLayout(performLayout: false);
		d.ResumeLayout(performLayout: false);
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
