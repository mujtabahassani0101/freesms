using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdu : Form
{
	private Panel m_a;

	private UIButton m_b;

	private Label m_c;

	private NumericUpDown m_d;

	private Label e;

	private UIButton f;

	private Label g;

	private UIComboBox h;

	private EditBox i;

	private Label j;

	private Label k;

	private IContainer n = null;

	public static string o = "";

	public asdu()
	{
		b();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
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
				case 0:
					n.Dispose();
					num = 1;
					continue;
				case 4:
					flag = n == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 5:
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdu));
		StringFormat stringFormat = new StringFormat();
		this.m_a = new Panel();
		k = new Label();
		i = new EditBox();
		j = new Label();
		g = new Label();
		h = new UIComboBox();
		f = new UIButton();
		e = new Label();
		this.m_c = new Label();
		this.m_d = new NumericUpDown();
		this.m_b = new UIButton();
		this.m_a.SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		SuspendLayout();
		this.m_a.BackColor = Color.FromArgb(214, 223, 247);
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_a.Controls.Add(k);
		this.m_a.Controls.Add(i);
		this.m_a.Controls.Add(j);
		this.m_a.Controls.Add(g);
		this.m_a.Controls.Add(h);
		this.m_a.Controls.Add(f);
		this.m_a.Controls.Add(e);
		this.m_a.Controls.Add(this.m_c);
		this.m_a.Controls.Add(this.m_d);
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(10, 11);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(494, 393);
		this.m_a.TabIndex = 72;
		k.AutoSize = true;
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(5, 368);
		k.Name = "label7";
		k.Size = new Size(98, 16);
		k.TabIndex = 79;
		k.Text = "نسخه 90/12/10";
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoScroll = false;
		i.AutoScrollMargin = new Size(0, 0);
		i.AutoScrollMinSize = new Size(0, 0);
		i.AutoScrollPosition = new Point(0, 0);
		i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Location = new Point(137, 217);
		i.Name = "txtPass";
		i.PasswordChar = '*';
		i.RightToLeft = RightToLeft.Yes;
		i.Size = new Size(184, 21);
		i.TabIndex = 0;
		i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		i.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Location = new Point(324, 217);
		j.Name = "label6";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(61, 21);
		j.TabIndex = 78;
		j.Text = "کلمه عبور :";
		j.TextAlign = ContentAlignment.MiddleRight;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.Location = new Point(324, 180);
		g.Name = "label3";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(56, 21);
		g.TabIndex = 76;
		g.Text = "کاربر :";
		g.TextAlign = ContentAlignment.MiddleRight;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.BorderStyle = Janus.Windows.UI.BorderStyle.RaisedLight3D;
		h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		h.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		h.Location = new Point(137, 180);
		h.Name = "ComboUser";
		h.RightToLeft = RightToLeft.Yes;
		h.Size = new Size(184, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat;
		h.TabIndex = 75;
		f.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		f.Font = new Font("B Homa", 20.25f);
		f.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		f.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		f.ImageIndex = 8;
		f.ImageSize = new Size(50, 50);
		f.Location = new Point(111, 261);
		f.Name = "uiButton1";
		f.Size = new Size(256, 48);
		f.TabIndex = 74;
		f.Text = "ورود";
		f.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		f.Click += a;
		e.Font = new Font("B Homa", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		e.ForeColor = Color.MediumSlateBlue;
		e.Location = new Point(134, 30);
		e.Name = "label1";
		e.RightToLeft = RightToLeft.Yes;
		e.Size = new Size(242, 48);
		e.TabIndex = 72;
		e.TextAlign = ContentAlignment.MiddleRight;
		this.m_c.Font = new Font("B Homa", 20.25f);
		this.m_c.Location = new Point(259, 100);
		this.m_c.Name = "label5";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(196, 55);
		this.m_c.TabIndex = 70;
		this.m_c.Text = "سال تعلیمی :";
		this.m_c.TextAlign = ContentAlignment.MiddleRight;
		this.m_d.BackColor = SystemColors.InactiveCaptionText;
		this.m_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_d.Font = new Font("B Homa", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(169, 113);
		this.m_d.Maximum = new decimal(new int[4] { 1399, 0, 0, 0 });
		this.m_d.Minimum = new decimal(new int[4] { 1386, 0, 0, 0 });
		this.m_d.Name = "txtYear";
		this.m_d.Size = new Size(88, 37);
		this.m_d.TabIndex = 68;
		this.m_d.TextAlign = HorizontalAlignment.Center;
		this.m_d.Value = new decimal(new int[4] { 1386, 0, 0, 0 });
		this.m_b.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_b.Font = new Font("B Homa", 20.25f);
		this.m_b.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_b.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_b.ImageIndex = 8;
		this.m_b.ImageSize = new Size(50, 50);
		this.m_b.Location = new Point(111, 315);
		this.m_b.Name = "uiButton2";
		this.m_b.Size = new Size(256, 48);
		this.m_b.TabIndex = 43;
		this.m_b.Text = "خروج";
		this.m_b.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_b.Click += c;
		AcceptButton = f;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.LightSteelBlue;
		ClientSize = new Size(515, 418);
		ControlBox = false;
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frm_Year_Term";
		RightToLeft = RightToLeft.Yes;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ورود به برنامه";
		Load += b;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_a.PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void c(object A_0, EventArgs A_1)
	{
		Application.Exit();
	}

	private void a()
	{
		int num2 = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tuser");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 6:
					h.SelectedIndex = 0;
					num = 7;
					continue;
				case 3:
				case 4:
					flag = num2 < dataTable.Rows.Count;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 9;
						continue;
					}
					h.Items.Add(dataTable.Rows[num2]["uid"].ToString(), dataTable.Rows[num2]["id"].ToString());
					num2++;
					num = 3;
					continue;
				case 5:
					h.Items.Clear();
					num2 = 0;
					num = 4;
					continue;
				case 7:
					num = 0;
					continue;
				case 0:
					return;
				case 9:
					if (true)
					{
					}
					flag = dataTable.Rows.Count != 1;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	public string d()
{ KeylessRuntime.Enable(); return "0"; }
	private void b(object A_0, EventArgs A_1)
	{
		DataTable dataTable = null;
		try
		{
			dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tYear_term");
			this.m_d.Text = dataTable.Rows[0]["fYear"].ToString();
		}
		catch
		{
			SqlParameter[] a_ = new SqlParameter[3]
			{
				asdcb.a("@dbname ", SqlDbType.NVarChar, 50, "Azmoon_Un_Kbr"),
				asdcb.a("@filename1", SqlDbType.NVarChar, 250, Application.StartupPath + "\\db\\Azmoon_Un_Kbr_Data.MDF"),
				asdcb.a("@filename2", SqlDbType.NVarChar, 250, Application.StartupPath + "\\db\\Azmoon_Un_Kbr_Log.LDF")
			};
			asdcb.d(asdab.e().Replace("azmoon_un_kbr", "master"), CommandType.StoredProcedure, "sp_attach_db", a_);
			Thread.Sleep(5000);
			dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tYear_term");
			this.m_d.Text = dataTable.Rows[0]["fYear"].ToString();
		}
		if (true)
		{
		}
		a();
		i.SelectAll();
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = h.SelectedIndex >= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
				{
					if (!flag)
					{
						if (true)
						{
						}
						num = 4;
						continue;
					}
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tuser where id= " + h.SelectedValue.ToString() + " and pwd=N'" + asdab.d(i.Text) + "'");
					flag = dataTable.Rows.Count != 0;
					num = 6;
					continue;
				}
				case 3:
					MessageBox.Show("کلمه عبور اشتباه است");
					i.Focus();
					i.SelectAll();
					num = 5;
					continue;
				case 5:
					return;
				case 6:
				{
					if (!flag)
					{
						num = 3;
						continue;
					}
					asdaj.l = h.SelectedValue.ToString();
					asdab.i = this.m_d.Value.ToString();
					int num2 = int.Parse(asdab.i);
					asdab.k = this.m_d.Value + "-" + (num2 + 1).ToString().Substring(2, 2);
					asdcb.d(asdab.e(), CommandType.Text, "update tYear set fYear=" + this.m_d.Value);
					asdb3 asdb10 = new asdb3();
					asdb10.ShowDialog();
					num = 1;
					continue;
				}
				case 4:
					MessageBox.Show("کاربری انتخاب نشده است");
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					return;
				}
				break;
			}
		}
	}

	public string c()
{ KeylessRuntime.Enable(); return "0"; }
	private void a(int A_0)
{ KeylessRuntime.Enable(); }
	public void a(int A_0, ref bool A_1)
{ KeylessRuntime.Enable(); A_1 = true; }
	public void a(ref bool A_0)
{ KeylessRuntime.Enable(); A_0 = true; }}
