using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;

public class asdaf : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel d;

	private UIComboBox e;

	private Label f;

	private Label g;

	private Label h;

	private Label i;

	private UIButton j;

	private DatePicker k;

	private DatePicker l;

	public string m = "";

	public string n = "";

	public string o = "";

	public string p = "";

	public string q = "";
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
						num = 5;
					}
					else
					{
						num = 4;
					}
					continue;
				case 5:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 3:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
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
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdaf));
		this.m_b = new Panel();
		d = new Panel();
		this.m_c = new Panel();
		h = new Label();
		i = new Label();
		g = new Label();
		f = new Label();
		e = new UIComboBox();
		l = new DatePicker();
		k = new DatePicker();
		j = new UIButton();
		this.m_b.SuspendLayout();
		d.SuspendLayout();
		this.m_c.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = BorderStyle.FixedSingle;
		this.m_b.Controls.Add(d);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(332, 312);
		this.m_b.TabIndex = 0;
		d.BackColor = SystemColors.ControlText;
		d.Controls.Add(this.m_c);
		d.Dock = DockStyle.Fill;
		d.Location = new Point(0, 0);
		d.Name = "panel3";
		d.Size = new Size(330, 310);
		d.TabIndex = 19;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(h);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(f);
		this.m_c.Controls.Add(e);
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_c.Location = new Point(4, 5);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(322, 300);
		this.m_c.TabIndex = 18;
		h.AutoSize = true;
		h.Location = new Point(233, 127);
		h.Name = "lDateTo";
		h.Size = new Size(60, 26);
		h.TabIndex = 36;
		h.Text = "تا تاریخ :";
		h.Visible = false;
		i.AutoSize = true;
		i.Location = new Point(233, 90);
		i.Name = "lDateFrom";
		i.Size = new Size(42, 26);
		i.TabIndex = 35;
		i.Text = "تاریخ";
		i.Visible = false;
		g.AutoSize = true;
		g.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Location = new Point(61, 3);
		g.Name = "label4";
		g.Size = new Size(201, 33);
		g.TabIndex = 34;
		g.Text = " نمایش لیست یادداشت ها";
		f.AutoSize = true;
		f.Location = new Point(235, 50);
		f.Name = "label1";
		f.Size = new Size(63, 26);
		f.TabIndex = 33;
		f.Text = "نوع فیلتر";
		e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		e.ComboStyle = ComboStyle.DropDownList;
		e.DropListFont = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		e.Font = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "روزانه";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "بین دو تاریخ";
		uIComboBoxItem2.Value = "2";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "کل یادداشت ها";
		uIComboBoxItem3.Value = "9";
		e.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3 });
		e.Location = new Point(51, 44);
		e.Name = "droptypeFilter";
		e.Size = new Size(177, 39);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		e.StringFormat = stringFormat;
		e.TabIndex = 32;
		e.SelectedIndexChanged += c;
		l.AutoToday = true;
		l.BackColor = Color.SeaShell;
		l.BijanForeColor = Color.Blue;
		l.Location = new Point(83, 92);
		l.Name = "txtDatefrom";
		l.Size = new Size(144, 24);
		l.TabIndex = 40;
		l.the_date = new DateTime(2020, 8, 31, 22, 6, 50, 53);
		l.the_label = "ازمون تاريخ:";
		k.AutoToday = true;
		k.BackColor = Color.SeaShell;
		k.BijanForeColor = Color.Blue;
		k.Location = new Point(83, 127);
		k.Name = "txtDateto";
		k.Size = new Size(144, 24);
		k.TabIndex = 41;
		k.the_date = new DateTime(2020, 8, 31, 22, 6, 50, 49);
		k.the_label = "ازمون تاريخ:";
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		j.Location = new Point(70, 191);
		j.Name = "btnAcp";
		j.Size = new Size(167, 42);
		j.TabIndex = 39;
		j.Text = "نمایش";
		j.Click += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(332, 312);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		Name = "frmCommentListSelectDate";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "انتخاب تاریخ";
		Load += b;
		this.m_b.ResumeLayout(performLayout: false);
		d.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	public asdaf()
	{
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(e.SelectedValue.ToString() == "1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 7;
						continue;
					}
					flag = !(e.SelectedValue.ToString() == "2");
					if (true)
					{
					}
					num = 1;
					continue;
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 0:
					k.Visible = true;
					h.Visible = true;
					l.Visible = true;
					i.Visible = true;
					i.Text = "از تاریخ";
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					l.Visible = true;
					i.Visible = true;
					i.Text = "تاریخ";
					k.Visible = false;
					h.Visible = false;
					num = 8;
					continue;
				case 8:
					return;
				case 6:
					k.Visible = false;
					h.Visible = false;
					l.Visible = false;
					i.Visible = false;
					num = 5;
					continue;
				case 5:
					return;
				case 1:
					if (flag)
					{
						flag = !(e.SelectedValue.ToString() == "9");
						num = 4;
					}
					else
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 10;
			while (true)
			{
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 0;
				case 15:
					k.Text = o;
					num = 1;
					continue;
				case 1:
					return;
				case 14:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 12:
					l.Text = n;
					num = 7;
					continue;
				case 8:
					return;
				case 3:
					e.SelectedValue = m;
					num = 9;
					continue;
				case 7:
				case 11:
					flag = !(o != "");
					num = 13;
					continue;
				case 13:
					if (flag)
					{
						k.Text = asdab.b();
						num = 8;
					}
					else
					{
						num = 15;
					}
					continue;
				case 4:
				case 9:
					flag = !(n != "");
					num = 2;
					continue;
				case 2:
					if (flag)
					{
						l.Text = asdab.b();
						num = 11;
					}
					else
					{
						num = 12;
					}
					continue;
				case 5:
					if (true)
					{
					}
					num = 14;
					continue;
				case 0:
					flag = !(m != "");
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						e.SelectedIndex = 0;
						num = 4;
					}
					else
					{
						num = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		string text = default;
		while (true)
		{
			m = e.SelectedValue.ToString();
			bool flag = !(m == "9");
			int num = 51;
			while (true)
			{
				switch (num)
				{
				case 51:
					if (!flag)
					{
						num = 33;
						continue;
					}
					flag = !(m == "1");
					num = 27;
					continue;
				case 69:
					if (!flag)
					{
						num = 64;
						continue;
					}
					flag = !(text == "Sunday");
					num = 60;
					continue;
				case 13:
					if (!flag)
					{
						num = 50;
						continue;
					}
					flag = !(text == "Thursday");
					num = 38;
					continue;
				case 12:
					if (!flag)
					{
						num = 7;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 65;
					continue;
				case 36:
					if (!flag)
					{
						num = 67;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 75;
					continue;
				case 35:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(text == "Monday");
					num = 68;
					continue;
				case 3:
				case 18:
				case 25:
				case 39:
				case 43:
				case 45:
				case 70:
					try
					{
						text = k.the_date.DayOfWeek.ToString();
					}
					catch
					{
						MessageBox.Show("تاریخ  تا اشتباه است");
						k.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 69;
					continue;
				case 1:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 32;
				case 62:
					p = "سه شنبه";
					num = 39;
					continue;
				case 65:
					if (!flag)
					{
						num = 22;
						continue;
					}
					flag = !(text == "Thursday");
					num = 28;
					continue;
				case 29:
					q = "چهارشنبه";
					num = 42;
					continue;
				case 6:
				case 59:
					num = 23;
					continue;
				case 46:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = !(text == "Sunday");
					num = 54;
					continue;
				case 33:
					n = "";
					o = "";
					num = 24;
					continue;
				case 31:
					p = "دوشنبه";
					num = 10;
					continue;
				case 5:
					p = "یکشنبه";
					num = 4;
					continue;
				case 28:
					if (!flag)
					{
						num = 44;
						continue;
					}
					flag = !(text == "Friday");
					num = 74;
					continue;
				case 40:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 1;
					}
					else
					{
						num = 49;
					}
					continue;
				case 17:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 36;
					}
					else
					{
						num = 63;
					}
					continue;
				case 30:
					try
					{
						text = l.the_date.DayOfWeek.ToString();
					}
					catch
					{
						MessageBox.Show("تاریخ از اشتباه است");
						l.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 46;
					continue;
				case 52:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 3;
				case 73:
					p = "جمعه";
					num = 11;
					continue;
				case 7:
					p = "سه شنبه";
					num = 16;
					continue;
				case 63:
					q = "دوشنبه";
					num = 71;
					continue;
				case 74:
					if (!flag)
					{
						num = 73;
						continue;
					}
					goto case 2;
				case 44:
					p = "پنج شنبه";
					num = 2;
					continue;
				case 22:
					p = "چهارشنبه";
					num = 48;
					continue;
				case 72:
					if (flag)
					{
						flag = !(text == "Wednesday");
						num = 13;
					}
					else
					{
						num = 62;
					}
					continue;
				case 27:
					if (!flag)
					{
						num = 37;
						continue;
					}
					flag = !(m == "2");
					num = 0;
					continue;
				case 21:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 72;
					}
					else
					{
						num = 66;
					}
					continue;
				case 20:
					text = "";
					num = 30;
					continue;
				case 34:
					q = "یکشنبه";
					num = 55;
					continue;
				case 9:
					p = "شنبه";
					num = 70;
					continue;
				case 49:
					q = "پنج شنبه";
					num = 32;
					continue;
				case 61:
					if (flag)
					{
						flag = !(text == "Sunday");
						num = 35;
					}
					else
					{
						num = 14;
					}
					continue;
				case 37:
					text = "";
					num = 47;
					continue;
				case 19:
					q = "جمعه";
					num = 53;
					continue;
				case 2:
				case 4:
				case 10:
				case 11:
				case 15:
				case 16:
				case 48:
					if (true)
					{
					}
					n = ShamsiDate.GetShamsiDate(l.the_date);
					o = "";
					num = 6;
					continue;
				case 14:
					p = "شنبه";
					num = 15;
					continue;
				case 67:
					q = "سه شنبه";
					num = 57;
					continue;
				case 0:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 6;
				case 26:
					p = "جمعه";
					num = 25;
					continue;
				case 54:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 21;
					}
					else
					{
						num = 8;
					}
					continue;
				case 75:
					if (flag)
					{
						flag = !(text == "Thursday");
						num = 40;
					}
					else
					{
						num = 29;
					}
					continue;
				case 64:
					q = "شنبه";
					num = 41;
					continue;
				case 32:
				case 41:
				case 42:
				case 53:
				case 55:
				case 57:
				case 71:
					n = ShamsiDate.GetShamsiDate(l.the_date);
					o = ShamsiDate.GetShamsiDate(k.the_date);
					num = 59;
					continue;
				case 60:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 17;
					}
					else
					{
						num = 34;
					}
					continue;
				case 68:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 12;
					}
					else
					{
						num = 31;
					}
					continue;
				case 38:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 52;
					}
					else
					{
						num = 56;
					}
					continue;
				case 66:
					p = "دوشنبه";
					num = 3;
					continue;
				case 56:
					p = "پنج شنبه";
					num = 18;
					continue;
				case 47:
					try
					{
						text = l.the_date.DayOfWeek.ToString();
					}
					catch
					{
						MessageBox.Show("تاریخ اشتباه است");
						l.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 61;
					continue;
				case 23:
				case 24:
					Close();
					num = 58;
					continue;
				case 58:
					return;
				case 50:
					p = "چهارشنبه";
					num = 43;
					continue;
				case 8:
					p = "یکشنبه";
					num = 45;
					continue;
				}
				break;
			}
		}
	}
}
