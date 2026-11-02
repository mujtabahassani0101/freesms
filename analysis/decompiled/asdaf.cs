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

	protected override void a(bool A_0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
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
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		if (true)
		{
		}
		UIComboBoxItem val = new UIComboBoxItem();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		StringFormat val4 = new StringFormat();
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
		((Control)this.m_b).Size = new Size(332, 312);
		((Control)this.m_b).TabIndex = 0;
		((Control)d).BackColor = SystemColors.ControlText;
		((Control)d).Controls.Add((Control)(object)this.m_c);
		((Control)d).Dock = (DockStyle)5;
		((Control)d).Location = new Point(0, 0);
		((Control)d).Name = "panel3";
		((Control)d).Size = new Size(330, 310);
		((Control)d).TabIndex = 19;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		((Control)this.m_c).Controls.Add((Control)(object)k);
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)h);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)g);
		((Control)this.m_c).Controls.Add((Control)(object)f);
		((Control)this.m_c).Controls.Add((Control)(object)e);
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_c).Location = new Point(4, 5);
		((Control)this.m_c).Name = "panel2";
		((Control)this.m_c).Size = new Size(322, 300);
		((Control)this.m_c).TabIndex = 18;
		((Control)h).AutoSize = true;
		((Control)h).Location = new Point(233, 127);
		((Control)h).Name = "lDateTo";
		((Control)h).Size = new Size(60, 26);
		((Control)h).TabIndex = 36;
		((Control)h).Text = "تا تاریخ :";
		((Control)h).Visible = false;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(233, 90);
		((Control)i).Name = "lDateFrom";
		((Control)i).Size = new Size(42, 26);
		((Control)i).TabIndex = 35;
		((Control)i).Text = "تاریخ";
		((Control)i).Visible = false;
		((Control)g).AutoSize = true;
		((Control)g).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)g).Location = new Point(61, 3);
		((Control)g).Name = "label4";
		((Control)g).Size = new Size(201, 33);
		((Control)g).TabIndex = 34;
		((Control)g).Text = " نمایش لیست یادداشت ها";
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
		val3.Text = "کل یادداشت ها";
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
		l.AutoToday = true;
		((Control)l).BackColor = Color.SeaShell;
		l.BijanForeColor = Color.Blue;
		((Control)l).Location = new Point(83, 92);
		((Control)l).Name = "txtDatefrom";
		((Control)l).Size = new Size(144, 24);
		((Control)l).TabIndex = 40;
		l.the_date = new DateTime(2020, 8, 31, 22, 6, 50, 53);
		l.the_label = "ازمون تاريخ:";
		k.AutoToday = true;
		((Control)k).BackColor = Color.SeaShell;
		k.BijanForeColor = Color.Blue;
		((Control)k).Location = new Point(83, 127);
		((Control)k).Name = "txtDateto";
		((Control)k).Size = new Size(144, 24);
		((Control)k).TabIndex = 41;
		k.the_date = new DateTime(2020, 8, 31, 22, 6, 50, 49);
		k.the_label = "ازمون تاريخ:";
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)j).Location = new Point(70, 191);
		((Control)j).Name = "btnAcp";
		((Control)j).Size = new Size(167, 42);
		((Control)j).TabIndex = 39;
		((Control)j).Text = "نمایش";
		((Control)j).Click += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(332, 312);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmCommentListSelectDate";
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
					((Control)k).Visible = true;
					((Control)h).Visible = true;
					((Control)l).Visible = true;
					((Control)i).Visible = true;
					((Control)i).Text = "از تاریخ";
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					((Control)l).Visible = true;
					((Control)i).Visible = true;
					((Control)i).Text = "تاریخ";
					((Control)k).Visible = false;
					((Control)h).Visible = false;
					num = 8;
					continue;
				case 8:
					return;
				case 6:
					((Control)k).Visible = false;
					((Control)h).Visible = false;
					((Control)l).Visible = false;
					((Control)i).Visible = false;
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
					((Control)k).Text = o;
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
						((Control)this.m_c).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 12:
					((Control)l).Text = n;
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
						((Control)k).Text = asdab.b();
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
						((Control)l).Text = asdab.b();
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
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)k).Focus();
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
						((Control)l).Focus();
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
						((Control)l).Focus();
						return;
					}
					flag = !(text == "Saturday");
					num = 61;
					continue;
				case 23:
				case 24:
					((Form)this).Close();
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
