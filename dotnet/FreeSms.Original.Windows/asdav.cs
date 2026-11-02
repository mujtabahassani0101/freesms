using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.UI;

public class asdav : Form
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

	private UIComboBox j;

	public asdav()
	{
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 2:
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
					num = 0;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 0:
					OriginalSchoolYears.Select(j, asdaj.__field_a);
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					num = 2;
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
			bool flag = !(asdab.q != asdab.n);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = asdab.p >= int.Parse(j.SelectedValue.ToString());
					num = 1;
					continue;
				case 4:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 3;
					continue;
				case 3:
					return;
				case 1:
				{
					if (!flag)
					{
						num = 4;
						continue;
					}
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xYear", SqlDbType.Int, j.SelectedValue.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "Sp_SetDefYear", a_);
					MessageBox.Show("ثبت شد");
					asdaj.__field_a = j.SelectedValue.ToString();
					num = 0;
					continue;
				}
				case 2:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر سال وجود ندارد");
					num = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					return;
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
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((!A_0) ? 4 : 5);
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 3:
					if (true)
					{
					}
					this.m_b.Dispose();
					num = 1;
					continue;
				case 4:
					num2 = 1;
					goto IL_0074;
				case 1:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 0;
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
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdav));
		this.m_c = new Panel();
		d = new Panel();
		e = new Panel();
		j = new UIComboBox();
		i = new Label();
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
		this.m_c.Size = new Size(375, 222);
		this.m_c.TabIndex = 0;
		d.BackColor = Color.Black;
		d.Controls.Add(e);
		d.Dock = DockStyle.Fill;
		d.Location = new Point(0, 0);
		d.Name = "panel2";
		d.Size = new Size(373, 220);
		d.TabIndex = 44;
		e.BackColor = Color.FromArgb(214, 223, 247);
		e.Controls.Add(j);
		e.Controls.Add(i);
		e.Controls.Add(h);
		e.Controls.Add(g);
		e.Controls.Add(f);
		e.Location = new Point(3, 3);
		e.Name = "panel3";
		e.Size = new Size(367, 213);
		e.TabIndex = 0;
		j.ComboStyle = ComboStyle.DropDownList;
		j.DropListFont = new Font("B Nazanin", 15.75f, FontStyle.Bold);
		j.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "1403";
		uIComboBoxItem.Value = "1403";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "1402";
		uIComboBoxItem2.Value = "1402";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "1401";
		uIComboBoxItem3.Value = "1401";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "1400";
		uIComboBoxItem4.Value = "1400";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1399";
		uIComboBoxItem5.Value = "1399";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1398";
		uIComboBoxItem6.Value = "1398";
		j.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		j.Location = new Point(83, 83);
		j.Name = "dropYear";
		j.Size = new Size(137, 41);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		j.StringFormat = stringFormat;
		j.TabIndex = 131;
		i.AutoSize = true;
		i.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(229, 83);
		i.Name = "label3";
		i.Size = new Size(101, 33);
		i.TabIndex = 127;
		i.Text = "سال تعلیمی";
		h.AutoSize = true;
		h.Font = new Font("B Nazanin", 24f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.ForeColor = Color.DarkViolet;
		h.Location = new Point(46, 5);
		h.Name = "label4";
		h.Size = new Size(274, 51);
		h.TabIndex = 121;
		h.Text = "سال تعلیمی پیش فرض";
		g.ButtonStyle = ButtonStyle.Button;
		g.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		g.ImageHorizontalAlignment = ImageHorizontalAlignment.AfterText;
		g.ImageIndex = 8;
		g.ImageSize = new Size(40, 40);
		g.Location = new Point(188, 163);
		g.Name = "btnAcp";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(153, 40);
		g.TabIndex = 4;
		g.Text = "ثبت";
		g.VisualStyle = VisualStyle.OfficeXP;
		g.Click += a;
		f.DialogResult = DialogResult.Cancel;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		f.Location = new Point(20, 163);
		f.Name = "btnClose";
		f.Size = new Size(152, 40);
		f.TabIndex = 16;
		f.Text = "بستن";
		f.Click += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(375, 222);
		Controls.Add(this.m_c);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSetDefYear";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "سال تعلیمی پیش فرض";
		Load += c;
		this.m_c.ResumeLayout(performLayout: false);
		d.ResumeLayout(performLayout: false);
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
