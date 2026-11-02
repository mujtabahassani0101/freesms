using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)e).BackColor = Color.FromArgb(red, green, blue);
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
					((Control)i).Text = asdaj.a;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
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
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = (int)MessageBox.Show("آيا مطمئن هستيد؟", "", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
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
					asdcb.d(asdab.e().Replace("school_af_kbr", "master"), CommandType.Text, "Backup DATABASE school_af_kbr to  DISK = N'" + Application.StartupPath + "\\Backup\\SetMark100_backup_" + ShamsiDate.GetShamsiDate(DateTime.Today).Replace("/", "") + "-" + DateTime.Now.Hour + DateTime.Now.Minute + "'");
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set MarkTerm3_From100=1 where xYear=" + asdaj.a);
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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
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
		((Control)this.m_c).SuspendLayout();
		((Control)d).SuspendLayout();
		((Control)e).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(482, 314);
		((Control)this.m_c).TabIndex = 0;
		((Control)d).BackColor = Color.Black;
		((Control)d).Controls.Add((Control)(object)e);
		((Control)d).Dock = (DockStyle)5;
		((Control)d).Location = new Point(0, 0);
		((Control)d).Name = "panel2";
		((Control)d).Size = new Size(480, 312);
		((Control)d).TabIndex = 44;
		((Control)e).BackColor = Color.FromArgb(214, 223, 247);
		((Control)e).Controls.Add((Control)(object)i);
		((Control)e).Controls.Add((Control)(object)j);
		((Control)e).Controls.Add((Control)(object)h);
		((Control)e).Controls.Add((Control)(object)g);
		((Control)e).Controls.Add((Control)(object)f);
		((Control)e).Location = new Point(3, 3);
		((Control)e).Name = "panel3";
		((Control)e).Size = new Size(473, 304);
		((Control)e).TabIndex = 0;
		((Control)i).Anchor = (AnchorStyles)10;
		((Control)i).BackColor = Color.CornflowerBlue;
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).ForeColor = Color.MediumBlue;
		((Control)i).Location = new Point(113, 14);
		((Control)i).Name = "lYear";
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(103, 32);
		((Control)i).TabIndex = 125;
		((Control)j).Anchor = (AnchorStyles)10;
		((Control)j).AutoSize = true;
		((Control)j).BackColor = Color.CornflowerBlue;
		((Control)j).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)j).ForeColor = Color.DarkViolet;
		((Control)j).Location = new Point(222, 15);
		((Control)j).Name = "label1";
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(98, 30);
		((Control)j).TabIndex = 124;
		((Control)j).Text = "سال تعلیمی :";
		((Control)h).Font = new Font("B Nazanin", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).ForeColor = Color.DarkViolet;
		((Control)h).Location = new Point(26, 68);
		((Control)h).Name = "label4";
		((Control)h).Size = new Size(403, 105);
		((Control)h).TabIndex = 121;
		((Control)h).Text = "ورود نمره سالانه از 100 برای کل دانش آموزان در این سال تعلیمی";
		h.TextAlign = (ContentAlignment)32;
		g.ButtonStyle = (ButtonStyle)1;
		((Control)g).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		g.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		g.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		g.ImageIndex = 8;
		g.ImageSize = new Size(40, 40);
		((Control)g).Location = new Point(55, 192);
		((Control)g).Name = "btnAcp";
		((Control)g).RightToLeft = (RightToLeft)1;
		((Control)g).Size = new Size(341, 40);
		((Control)g).TabIndex = 4;
		((Control)g).Text = "ثبت";
		g.VisualStyle = (VisualStyle)1;
		((Control)g).Click += a;
		f.DialogResult = (DialogResult)2;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		((Control)f).Location = new Point(55, 248);
		((Control)f).Name = "btnClose";
		((Control)f).Size = new Size(152, 40);
		((Control)f).TabIndex = 16;
		((Control)f).Text = "بستن";
		((Control)f).Click += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(482, 314);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSetMark100";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "مشخصات مکتب";
		((Form)this).Load += c;
		((Control)this.m_c).ResumeLayout(false);
		((Control)d).ResumeLayout(false);
		((Control)e).ResumeLayout(false);
		((Control)e).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
