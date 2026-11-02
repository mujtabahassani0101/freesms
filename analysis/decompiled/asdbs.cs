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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbs));
		UIComboBoxItem val = new UIComboBoxItem();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		StringFormat val4 = new StringFormat();
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
		((Control)this.m_b).SuspendLayout();
		((Control)d).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)d);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(332, 228);
		((Control)this.m_b).TabIndex = 0;
		((Control)d).BackColor = SystemColors.ControlText;
		((Control)d).Controls.Add((Control)(object)this.m_c);
		((Control)d).Dock = (DockStyle)5;
		((Control)d).Location = new Point(0, 0);
		((Control)d).Name = "panel3";
		((Control)d).Size = new Size(330, 226);
		((Control)d).TabIndex = 19;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Controls.Add((Control)(object)h);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)k);
		((Control)this.m_c).Controls.Add((Control)(object)g);
		((Control)this.m_c).Controls.Add((Control)(object)f);
		((Control)this.m_c).Controls.Add((Control)(object)e);
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_c).Location = new Point(4, 5);
		((Control)this.m_c).Name = "panel2";
		((Control)this.m_c).Size = new Size(322, 216);
		((Control)this.m_c).TabIndex = 18;
		l.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)l).Location = new Point(61, 157);
		((Control)l).Name = "btnAcp";
		((Control)l).Size = new Size(167, 42);
		((Control)l).TabIndex = 39;
		((Control)l).Text = "نمایش";
		((Control)l).Click += a;
		((EditBase)h).AutoScroll = false;
		((EditBase)h).AutoScrollMargin = new Size(0, 0);
		((EditBase)h).AutoScrollMinSize = new Size(0, 0);
		((EditBase)h).AutoScrollPosition = new Point(0, 0);
		((EditBase)h).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).Location = new Point(128, 123);
		h.Mask = "0000/00/00";
		((EditBase)h).MaxLength = 12;
		((Control)h).Name = "txtDateto";
		h.Numeric = true;
		((Control)h).RightToLeft = (RightToLeft)0;
		((Control)h).Size = new Size(100, 26);
		((Control)h).TabIndex = 38;
		((Control)h).Tag = "";
		((EditBase)h).TextAlignment = (TextAlignment)3;
		((Control)h).Visible = false;
		((EditBase)i).AutoScroll = false;
		((EditBase)i).AutoScrollMargin = new Size(0, 0);
		((EditBase)i).AutoScrollMinSize = new Size(0, 0);
		((EditBase)i).AutoScrollPosition = new Point(0, 0);
		((EditBase)i).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(128, 91);
		i.Mask = "0000/00/00";
		((EditBase)i).MaxLength = 12;
		((Control)i).Name = "txtDatefrom";
		i.Numeric = true;
		((Control)i).RightToLeft = (RightToLeft)0;
		((Control)i).Size = new Size(100, 26);
		((Control)i).TabIndex = 37;
		((Control)i).Tag = "";
		((EditBase)i).TextAlignment = (TextAlignment)3;
		((Control)i).Visible = false;
		((Control)j).AutoSize = true;
		((Control)j).Location = new Point(233, 125);
		((Control)j).Name = "lDateTo";
		((Control)j).Size = new Size(60, 26);
		((Control)j).TabIndex = 36;
		((Control)j).Text = "تا تاریخ :";
		((Control)j).Visible = false;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(233, 93);
		((Control)k).Name = "lDateFrom";
		((Control)k).Size = new Size(42, 26);
		((Control)k).TabIndex = 35;
		((Control)k).Text = "تاریخ";
		((Control)k).Visible = false;
		((Control)g).AutoSize = true;
		((Control)g).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)g).Location = new Point(61, 3);
		((Control)g).Name = "label4";
		((Control)g).Size = new Size(195, 33);
		((Control)g).TabIndex = 34;
		((Control)g).Text = " نمایش لیست پرداخت ها";
		((Control)f).AutoSize = true;
		((Control)f).Location = new Point(235, 50);
		((Control)f).Name = "label1";
		((Control)f).Size = new Size(63, 26);
		((Control)f).TabIndex = 33;
		((Control)f).Text = "نوع فیلتر";
		((Control)e).Anchor = (AnchorStyles)9;
		((UIComboBase)e).ComboStyle = (ComboStyle)1;
		((UIComboBase)e).DropListFont = new Font("B Nazanin", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)e).Font = new Font("B Nazanin", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		val.FormatStyle.Alpha = 0;
		val.Text = "روزانه";
		val.Value = "1";
		val2.FormatStyle.Alpha = 0;
		val2.Text = "بین دو تاریخ";
		val2.Value = "2";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "کل پرداخت ها";
		val3.Value = "9";
		e.Items.AddRange(new UIComboBoxItem[3] { val, val2, val3 });
		((Control)e).Location = new Point(51, 44);
		((Control)e).Name = "droptypeFilter";
		((Control)e).Size = new Size(177, 39);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)e).StringFormat = val4;
		((Control)e).TabIndex = 32;
		e.SelectedIndexChanged += c;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(332, 228);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmPaymentListSelectDate";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "انتخاب تاریخ";
		((Form)this).Load += b;
		((Control)this.m_b).ResumeLayout(false);
		((Control)d).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)this).ResumeLayout(false);
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
					((Control)h).Visible = true;
					((Control)j).Visible = true;
					((Control)i).Visible = true;
					((Control)k).Visible = true;
					((Control)k).Text = "از تاریخ";
					num = 5;
					continue;
				case 5:
					return;
				case 4:
					((Control)i).Visible = true;
					((Control)k).Visible = true;
					((Control)k).Text = "تاریخ";
					((Control)h).Visible = false;
					((Control)j).Visible = false;
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					((Control)h).Visible = false;
					((Control)j).Visible = false;
					((Control)i).Visible = false;
					((Control)k).Visible = false;
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
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)i).Text = n;
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
					((Control)h).Text = asdab.b();
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
					((Control)i).Text = asdab.b();
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
						((Control)this.m_c).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 17;
					continue;
				case 1:
					((Control)h).Text = o;
					num = 18;
					continue;
				case 18:
					return;
				case 16:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
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
							DateTime dateTime = ShamsiDate.ShamsiToGregory(((Control)h).Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
							flag = !(shamsiDate != ((Control)h).Text);
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
									text = dateTime.DayOfWeek.ToString();
									num = 1;
									continue;
								case 0:
									MessageBox.Show("تاریخ تا اشتباه است");
									((Control)h).Focus();
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
						((Control)h).Focus();
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
							DateTime dateTime = ShamsiDate.ShamsiToGregory(((Control)i).Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
							flag = !(shamsiDate != ((Control)i).Text);
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
									text = dateTime.DayOfWeek.ToString();
									num = 0;
									continue;
								case 3:
									MessageBox.Show("تاریخ از اشتباه است");
									((Control)i).Focus();
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
						((Control)i).Focus();
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
					n = ((Control)i).Text;
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
					n = ((Control)i).Text;
					o = ((Control)h).Text;
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
							DateTime dateTime = ShamsiDate.ShamsiToGregory(((Control)i).Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
							flag = !(shamsiDate != ((Control)i).Text);
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
									text = dateTime.DayOfWeek.ToString();
									num = 2;
									continue;
								case 1:
									MessageBox.Show("تاریخ اشتباه است");
									((Control)i).Focus();
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
						((Control)i).Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 50;
					continue;
				case 16:
				case 42:
					((Form)this).Close();
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
