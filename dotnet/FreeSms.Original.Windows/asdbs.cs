using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbs : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel d;

	private UIComboBox e;

	private Label f;

	private Label g;

	private MaskedEditBox h;

	private MaskedEditBox i;

	private Label j;

	private Label k;

	private UIButton l;

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
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					if (A_0)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 3;
					}
					continue;
				case 1:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbs));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		this.m_b = new Panel();
		d = new Panel();
		this.m_c = new Panel();
		l = new UIButton();
		h = new MaskedEditBox();
		i = new MaskedEditBox();
		j = new Label();
		k = new Label();
		g = new Label();
		f = new Label();
		e = new UIComboBox();
		this.m_b.SuspendLayout();
		d.SuspendLayout();
		this.m_c.SuspendLayout();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(d);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(332, 228);
		this.m_b.TabIndex = 0;
		d.BackColor = SystemColors.ControlText;
		d.Controls.Add(this.m_c);
		d.Dock = DockStyle.Fill;
		d.Location = new Point(0, 0);
		d.Name = "panel3";
		d.Size = new Size(330, 226);
		d.TabIndex = 19;
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(h);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(f);
		this.m_c.Controls.Add(e);
		this.m_c.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_c.Location = new Point(4, 5);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(322, 216);
		this.m_c.TabIndex = 18;
		l.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		l.Location = new Point(61, 157);
		l.Name = "btnAcp";
		l.Size = new Size(167, 42);
		l.TabIndex = 39;
		l.Text = "نمایش";
		l.Click += a;
		h.AutoScroll = false;
		h.AutoScrollMargin = new Size(0, 0);
		h.AutoScrollMinSize = new Size(0, 0);
		h.AutoScrollPosition = new Point(0, 0);
		h.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.Location = new Point(128, 123);
		h.Mask = "0000/00/00";
		h.MaxLength = 12;
		h.Name = "txtDateto";
		h.Numeric = true;
		h.RightToLeft = RightToLeft.No;
		h.Size = new Size(100, 26);
		h.TabIndex = 38;
		h.Tag = "";
		h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		h.Visible = false;
		i.AutoScroll = false;
		i.AutoScrollMargin = new Size(0, 0);
		i.AutoScrollMinSize = new Size(0, 0);
		i.AutoScrollPosition = new Point(0, 0);
		i.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Location = new Point(128, 91);
		i.Mask = "0000/00/00";
		i.MaxLength = 12;
		i.Name = "txtDatefrom";
		i.Numeric = true;
		i.RightToLeft = RightToLeft.No;
		i.Size = new Size(100, 26);
		i.TabIndex = 37;
		i.Tag = "";
		i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		i.Visible = false;
		j.AutoSize = true;
		j.Location = new Point(233, 125);
		j.Name = "lDateTo";
		j.Size = new Size(60, 26);
		j.TabIndex = 36;
		j.Text = "تا تاریخ :";
		j.Visible = false;
		k.AutoSize = true;
		k.Location = new Point(233, 93);
		k.Name = "lDateFrom";
		k.Size = new Size(42, 26);
		k.TabIndex = 35;
		k.Text = "تاریخ";
		k.Visible = false;
		g.AutoSize = true;
		g.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Location = new Point(61, 3);
		g.Name = "label4";
		g.Size = new Size(195, 33);
		g.TabIndex = 34;
		g.Text = " نمایش لیست پرداخت ها";
		f.AutoSize = true;
		f.Location = new Point(235, 50);
		f.Name = "label1";
		f.Size = new Size(63, 26);
		f.TabIndex = 33;
		f.Text = "نوع فیلتر";
		e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		e.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		e.DropListFont = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		e.Font = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "روزانه";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "بین دو تاریخ";
		uIComboBoxItem2.Value = "2";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "کل پرداخت ها";
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
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(332, 228);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		Name = "frmPaymentListSelectDate";
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

	public asdbs()
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
						num = 4;
						continue;
					}
					flag = !(e.SelectedValue.ToString() == "2");
					if (true)
					{
					}
					num = 7;
					continue;
				case 8:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 0:
					h.Visible = true;
					j.Visible = true;
					i.Visible = true;
					k.Visible = true;
					k.Text = "از تاریخ";
					num = 5;
					continue;
				case 5:
					return;
				case 4:
					i.Visible = true;
					k.Visible = true;
					k.Text = "تاریخ";
					h.Visible = false;
					j.Visible = false;
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					h.Visible = false;
					j.Visible = false;
					i.Visible = false;
					k.Visible = false;
					num = 6;
					continue;
				case 6:
					return;
				case 7:
					if (flag)
					{
						flag = !(e.SelectedValue.ToString() == "9");
						num = 8;
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
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("9");
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 16;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 13;
					continue;
				case 5:
					i.Text = n;
					num = 3;
					continue;
				case 14:
					num = 11;
					continue;
				case 3:
				case 7:
					flag = !(o != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 1;
						continue;
					}
					h.Text = asdab.b();
					num = 9;
					continue;
				case 13:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 17;
				case 2:
				case 4:
					flag = !(n != "");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					i.Text = asdab.b();
					num = 7;
					continue;
				case 9:
					return;
				case 17:
					flag = !(m != "");
					num = 15;
					continue;
				case 15:
					if (flag)
					{
						e.SelectedIndex = 0;
						num = 2;
					}
					else
					{
						num = 8;
					}
					continue;
				case 11:
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
					num = 17;
					continue;
				case 1:
					h.Text = o;
					num = 18;
					continue;
				case 18:
					return;
				case 16:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					if (true)
					{
					}
					num = 10;
					continue;
				case 10:
					return;
				case 8:
					e.SelectedValue = m;
					num = 4;
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
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 54;
						continue;
					}
					flag = !(m == "1");
					num = 34;
					continue;
				case 2:
					if (!flag)
					{
						num = 40;
						continue;
					}
					flag = !(text == "Sunday");
					num = 47;
					continue;
				case 22:
					if (!flag)
					{
						num = 38;
						continue;
					}
					flag = !(text == "Thursday");
					num = 4;
					continue;
				case 62:
					if (!flag)
					{
						num = 26;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 8;
					continue;
				case 63:
					if (!flag)
					{
						num = 35;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 36;
					continue;
				case 43:
					if (!flag)
					{
						num = 51;
						continue;
					}
					flag = !(text == "Monday");
					num = 41;
					continue;
				case 5:
				case 14:
				case 24:
				case 46:
				case 57:
				case 70:
				case 74:
					try
					{
						while (true)
						{
							IL_02ba:
							DateTime date = ShamsiDate.ShamsiToGregory(h.Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
							flag = !(shamsiDate != h.Text);
							num = 2;
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
									text = date.DayOfWeek.ToString();
									num = 1;
									continue;
								case 0:
									MessageBox.Show("تاریخ تا اشتباه است");
									h.Focus();
									num = 3;
									continue;
								case 3:
									return;
								case 1:
									goto end_IL_02a1;
								}
								goto IL_02ba;
								continue;
								end_IL_02a1:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ  تا اشتباه است");
						h.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 2;
					continue;
				case 28:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 6;
				case 52:
					p = "سه شنبه";
					num = 74;
					continue;
				case 8:
					if (!flag)
					{
						num = 71;
						continue;
					}
					flag = !(text == "Thursday");
					num = 65;
					continue;
				case 29:
					q = "چهارشنبه";
					num = 31;
					continue;
				case 23:
				case 68:
					num = 16;
					continue;
				case 56:
					if (!flag)
					{
						num = 37;
						continue;
					}
					flag = !(text == "Sunday");
					num = 15;
					continue;
				case 54:
					n = "";
					o = "";
					num = 42;
					continue;
				case 72:
					p = "دوشنبه";
					num = 3;
					continue;
				case 51:
					p = "یکشنبه";
					num = 49;
					continue;
				case 65:
					if (!flag)
					{
						num = 48;
						continue;
					}
					flag = !(text == "Friday");
					num = 10;
					continue;
				case 27:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 28;
					}
					else
					{
						num = 44;
					}
					continue;
				case 11:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 63;
					}
					else
					{
						num = 59;
					}
					continue;
				case 73:
					try
					{
						while (true)
						{
							IL_0589:
							DateTime date = ShamsiDate.ShamsiToGregory(i.Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
							flag = !(shamsiDate != i.Text);
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									text = date.DayOfWeek.ToString();
									num = 0;
									continue;
								case 3:
									MessageBox.Show("تاریخ از اشتباه است");
									i.Focus();
									num = 1;
									continue;
								case 1:
									return;
								case 0:
									goto end_IL_0570;
								}
								goto IL_0589;
								continue;
								end_IL_0570:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ از اشتباه است");
						i.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 56;
					continue;
				case 25:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 5;
				case 69:
					p = "جمعه";
					num = 19;
					continue;
				case 26:
					p = "سه شنبه";
					num = 60;
					continue;
				case 59:
					q = "دوشنبه";
					num = 6;
					continue;
				case 10:
					if (!flag)
					{
						num = 69;
						continue;
					}
					goto case 3;
				case 48:
					p = "پنج شنبه";
					num = 66;
					continue;
				case 71:
					p = "چهارشنبه";
					num = 67;
					continue;
				case 30:
					if (flag)
					{
						flag = !(text == "Wednesday");
						num = 22;
					}
					else
					{
						num = 52;
					}
					continue;
				case 34:
					if (!flag)
					{
						num = 61;
						continue;
					}
					flag = !(m == "2");
					num = 20;
					continue;
				case 32:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 30;
					}
					else
					{
						num = 21;
					}
					continue;
				case 7:
					text = "";
					num = 73;
					continue;
				case 17:
					q = "یکشنبه";
					num = 75;
					continue;
				case 37:
					p = "شنبه";
					num = 70;
					continue;
				case 44:
					q = "پنج شنبه";
					num = 33;
					continue;
				case 50:
					if (flag)
					{
						flag = !(text == "Sunday");
						num = 43;
					}
					else
					{
						num = 1;
					}
					continue;
				case 61:
					text = "";
					num = 55;
					continue;
				case 39:
					q = "جمعه";
					num = 64;
					continue;
				case 3:
				case 12:
				case 19:
				case 49:
				case 60:
				case 66:
				case 67:
					if (true)
					{
					}
					n = i.Text;
					o = "";
					num = 68;
					continue;
				case 1:
					p = "شنبه";
					num = 12;
					continue;
				case 35:
					q = "سه شنبه";
					num = 13;
					continue;
				case 20:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 23;
				case 18:
					p = "جمعه";
					num = 24;
					continue;
				case 15:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 32;
					}
					else
					{
						num = 58;
					}
					continue;
				case 36:
					if (flag)
					{
						flag = !(text == "Thursday");
						num = 27;
					}
					else
					{
						num = 29;
					}
					continue;
				case 40:
					q = "شنبه";
					num = 9;
					continue;
				case 6:
				case 9:
				case 13:
				case 31:
				case 33:
				case 64:
				case 75:
					n = i.Text;
					o = h.Text;
					num = 23;
					continue;
				case 47:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 11;
					}
					else
					{
						num = 17;
					}
					continue;
				case 41:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 62;
					}
					else
					{
						num = 72;
					}
					continue;
				case 4:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 25;
					}
					else
					{
						num = 45;
					}
					continue;
				case 21:
					p = "دوشنبه";
					num = 5;
					continue;
				case 45:
					p = "پنج شنبه";
					num = 14;
					continue;
				case 55:
					try
					{
						while (true)
						{
							IL_0b4e:
							DateTime date = ShamsiDate.ShamsiToGregory(i.Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
							flag = !(shamsiDate != i.Text);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 1;
										continue;
									}
									text = date.DayOfWeek.ToString();
									num = 2;
									continue;
								case 1:
									MessageBox.Show("تاریخ اشتباه است");
									i.Focus();
									num = 0;
									continue;
								case 0:
									return;
								case 2:
									goto end_IL_0b35;
								}
								goto IL_0b4e;
								continue;
								end_IL_0b35:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ اشتباه است");
						i.Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 50;
					continue;
				case 16:
				case 42:
					Close();
					num = 53;
					continue;
				case 53:
					return;
				case 38:
					p = "چهارشنبه";
					num = 57;
					continue;
				case 58:
					p = "یکشنبه";
					num = 46;
					continue;
				}
				break;
			}
		}
	}
}
