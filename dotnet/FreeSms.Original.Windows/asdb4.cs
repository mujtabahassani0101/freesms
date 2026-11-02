using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.UI;

public class asdb4 : Form
{
	private Panel m_a;

	private Panel m_b;

	private Label m_c;

	private UIButton d;

	private UIButton e;

	private Container f = null;

	public asdb4()
	{
		b();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (true)
					{
					}
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 5:
					num = 3;
					continue;
				case 0:
					f.Dispose();
					num = 5;
					continue;
				case 4:
					flag = f == null;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 5;
				case 3:
					base.Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb4));
		this.m_a = new Panel();
		this.m_b = new Panel();
		e = new UIButton();
		d = new UIButton();
		this.m_c = new Label();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		SuspendLayout();
		this.m_a.BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(8, 8);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(446, 133);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(e);
		this.m_b.Controls.Add(d);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(7, 8);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(431, 114);
		this.m_b.TabIndex = 16;
		e.ButtonStyle = ButtonStyle.Button;
		e.Font = new Font("B Homa", 16f);
		e.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		e.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		e.ImageIndex = 8;
		e.ImageSize = new Size(40, 40);
		e.Location = new Point(213, 61);
		e.Name = "uiButton1";
		e.Size = new Size(183, 37);
		e.TabIndex = 75;
		e.Text = "بارگذاری";
		e.VisualStyle = VisualStyle.OfficeXP;
		e.Click += a;
		d.ButtonStyle = ButtonStyle.Button;
		d.Font = new Font("B Homa", 16f);
		d.Image = (Image)componentResourceManager.GetObject("btnExit.Image");
		d.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		d.ImageIndex = 8;
		d.ImageSize = new Size(40, 40);
		d.Location = new Point(26, 61);
		d.Name = "btnExit";
		d.Size = new Size(181, 37);
		d.TabIndex = 4;
		d.Text = "خروج";
		d.VisualStyle = VisualStyle.OfficeXP;
		d.Click += b;
		this.m_c.AutoSize = true;
		this.m_c.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_c.ForeColor = Color.FromArgb(192, 64, 0);
		this.m_c.Location = new Point(23, 26);
		this.m_c.Name = "label1";
		this.m_c.Size = new Size(393, 14);
		this.m_c.TabIndex = 0;
		this.m_c.Text = "شما برای اولین بار وارد برنامه شده اید دکمه بارگذاری را کلیک کنید";
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.FromArgb(184, 203, 255);
		ClientSize = new Size(460, 149);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmAtach";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "بارگزاری";
		Load += c;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a();
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private static bool a()
	{
		bool result = default;
		while (true)
		{
			FileSystemRights fileSystemRights = (FileSystemRights)0;
			fileSystemRights = FileSystemRights.FullControl;
			FileSystemAccessRule rule = new FileSystemAccessRule("Users", fileSystemRights, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "\\db");
			DirectorySecurity accessControl = directoryInfo.GetAccessControl(AccessControlSections.Access);
			bool modified = false;
			accessControl.ModifyAccessRule(AccessControlModification.Set, rule, out modified);
			bool flag = modified;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
				{
					if (!flag)
					{
						num = 2;
						continue;
					}
					InheritanceFlags inheritanceFlags = InheritanceFlags.ObjectInherit;
					inheritanceFlags = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
					rule = new FileSystemAccessRule("Users", fileSystemRights, inheritanceFlags, PropagationFlags.InheritOnly, AccessControlType.Allow);
					modified = false;
					accessControl.ModifyAccessRule(AccessControlModification.Add, rule, out modified);
					flag = modified;
					num = 6;
					continue;
				}
				case 0:
					result = false;
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					if (true)
					{
					}
					directoryInfo.SetAccessControl(accessControl);
					result = true;
					num = 5;
					continue;
				case 2:
					result = false;
					num = 1;
					continue;
				case 1:
				case 3:
				case 5:
					return result;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		asdab.__field_c = "1";
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			SqlParameter[] a_ = new SqlParameter[3]
			{
				asdcb.a("@dbname ", SqlDbType.NVarChar, 50, "school_af_kbr"),
				asdcb.a("@filename1", SqlDbType.NVarChar, 250, Application.StartupPath + "\\db\\school_af_kbr_Data.MDF"),
				asdcb.a("@filename2", SqlDbType.NVarChar, 250, Application.StartupPath + "\\db\\school_af_kbr_Log.LDF")
			};
			int num = asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.StoredProcedure, "sp_attach_db", a_);
			bool flag = num == -1;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					Thread.Sleep(5000);
					Close();
					num2 = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 1:
					d.Visible = true;
					this.m_c.Text = "خطا در بارگزاری بانک اطلاعاتی";
					num2 = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}
}
