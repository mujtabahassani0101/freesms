using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;

public class asdak : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private Panel m_d;

	private Label m_e;

	private UIComboBox f;

	private Label g;

	private UIComboBox h;

	private Label i;

	private UIComboBox j;

	private Label k;

	private UIComboBox l;

	private Panel m;

	private Label n;

	private Button o;

	private Label p;

	private Label q;

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
						num = 6;
					}
					else
					{
						num = 3;
					}
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void e()
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
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected Obj, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected Obj, but got Unknown
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected Obj, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdak));
		StringFormat val = new StringFormat();
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		StringFormat val4 = new StringFormat();
		this.m_b = new Panel();
		m = new Panel();
		this.m_d = new Panel();
		q = new Label();
		p = new Label();
		o = new Button();
		n = new Label();
		this.m_e = new Label();
		this.m_c = new UIButton();
		f = new UIComboBox();
		g = new Label();
		h = new UIComboBox();
		i = new Label();
		j = new UIComboBox();
		k = new Label();
		l = new UIComboBox();
		((Control)this.m_b).SuspendLayout();
		((Control)m).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)m);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(332, 358);
		((Control)this.m_b).TabIndex = 0;
		((Control)m).BackColor = SystemColors.ControlText;
		((Control)m).Controls.Add((Control)(object)this.m_d);
		((Control)m).Dock = (DockStyle)5;
		((Control)m).Location = new Point(0, 0);
		((Control)m).Name = "panel3";
		((Control)m).Size = new Size(330, 356);
		((Control)m).TabIndex = 19;
		((Control)this.m_d).BackColor = SystemColors.GradientInactiveCaption;
		((Control)this.m_d).Controls.Add((Control)(object)q);
		((Control)this.m_d).Controls.Add((Control)(object)p);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)n);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_d).Controls.Add((Control)(object)f);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_d).Location = new Point(4, 5);
		((Control)this.m_d).Name = "panel2";
		((Control)this.m_d).Size = new Size(322, 346);
		((Control)this.m_d).TabIndex = 18;
		q.BorderStyle = (BorderStyle)1;
		((Control)q).Location = new Point(159, 64);
		((Control)q).Name = "lYear";
		((Control)q).Size = new Size(68, 24);
		((Control)q).TabIndex = 118;
		((Control)p).AutoSize = true;
		((Control)p).Location = new Point(233, 63);
		((Control)p).Name = "label6";
		((Control)p).Size = new Size(78, 26);
		((Control)p).TabIndex = 116;
		((Control)p).Text = "سال تعلیمی";
		((Control)o).Location = new Point(27, 250);
		((Control)o).Name = "btnStart";
		((Control)o).Size = new Size(201, 33);
		((Control)o).TabIndex = 5;
		((Control)o).Text = "ورود نمرات";
		((ButtonBase)o).UseVisualStyleBackColor = true;
		((Control)o).Click += a;
		((Control)n).AutoSize = true;
		((Control)n).Font = new Font("B Nazanin", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).ForeColor = Color.DarkViolet;
		((Control)n).Location = new Point(79, 13);
		((Control)n).Name = "label4";
		((Control)n).Size = new Size(117, 30);
		((Control)n).TabIndex = 38;
		((Control)n).Text = "ورود نمرات دوره";
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(233, 98);
		((Control)this.m_e).Name = "label2";
		((Control)this.m_e).Size = new Size(37, 26);
		((Control)this.m_e).TabIndex = 37;
		((Control)this.m_e).Text = "دوره";
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageSize = new Size(40, 40);
		((Control)this.m_c).Location = new Point(27, 294);
		((Control)this.m_c).Name = "btnClose";
		((Control)this.m_c).Size = new Size(201, 35);
		((Control)this.m_c).TabIndex = 6;
		((Control)this.m_c).Text = "بستن";
		((Control)this.m_c).Click += c;
		((Control)f).Anchor = (AnchorStyles)9;
		((UIComboBase)f).ComboStyle = (ComboStyle)1;
		((UIComboBase)f).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)f).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)f).Location = new Point(27, 96);
		((Control)f).Name = "dropExam";
		((Control)f).Size = new Size(201, 31);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)f).StringFormat = val;
		((Control)f).TabIndex = 1;
		f.SelectedIndexChanged += b;
		((Control)g).Anchor = (AnchorStyles)9;
		((Control)g).AutoSize = true;
		((Control)g).Location = new Point(233, 215);
		((Control)g).Name = "label1";
		((Control)g).Size = new Size(40, 26);
		((Control)g).TabIndex = 35;
		((Control)g).Text = "درس";
		((Control)h).Anchor = (AnchorStyles)9;
		((UIComboBase)h).ComboStyle = (ComboStyle)1;
		((UIComboBase)h).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)h).Location = new Point(27, 211);
		((Control)h).Name = "dropBook";
		((Control)h).Size = new Size(201, 31);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)h).StringFormat = val2;
		((Control)h).TabIndex = 4;
		((Control)i).Anchor = (AnchorStyles)9;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(233, 175);
		((Control)i).Name = "label19";
		((Control)i).Size = new Size(41, 26);
		((Control)i).TabIndex = 33;
		((Control)i).Text = "صنف";
		((Control)j).Anchor = (AnchorStyles)9;
		((UIComboBase)j).ComboStyle = (ComboStyle)1;
		((UIComboBase)j).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)j).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)j).Location = new Point(27, 171);
		((Control)j).Name = "dropCls";
		((Control)j).Size = new Size(201, 31);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)j).StringFormat = val3;
		((Control)j).TabIndex = 3;
		((Control)k).Anchor = (AnchorStyles)9;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(233, 135);
		((Control)k).Name = "label20";
		((Control)k).Size = new Size(33, 26);
		((Control)k).TabIndex = 32;
		((Control)k).Text = "پایه";
		((Control)l).Anchor = (AnchorStyles)9;
		((UIComboBase)l).ComboStyle = (ComboStyle)1;
		((UIComboBase)l).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(27, 134);
		((Control)l).Name = "dropPaye";
		((Control)l).Size = new Size(201, 31);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)l).StringFormat = val4;
		((Control)l).TabIndex = 2;
		l.SelectedIndexChanged += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(332, 358);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmMarkEntrySelect";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "انتخاب دوره";
		((Form)this).Load += d;
		((Control)this.m_b).ResumeLayout(false);
		((Control)m).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public asdak()
	{
		e();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 2;
					continue;
				case 0:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto IL_012c;
				case 3:
					return;
				case 1:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 5;
					continue;
				case 5:
					return;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_012c;
				case 7:
					{
						num = 0;
						continue;
					}
					IL_012c:
					((Control)q).Text = asdaj.a;
					d();
					c();
					b();
					((UIComboBase)f).Focus();
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where xYear=" + ((Control)q).Text + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			f.DataSource = dataSource;
			f.DisplayMember = "Name";
			f.ValueMember = "id";
			bool flag = ((CollectionBase)(object)f.Items).Count <= 0;
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
				case 2:
					f.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ((Control)q).Text + ") order by id");
			l.DataSource = dataSource;
			l.DisplayMember = "Name";
			l.ValueMember = "id";
			bool flag = ((CollectionBase)(object)l.Items).Count <= 0;
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
					if (true)
					{
					}
					l.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		while (true)
		{
			bool flag = l.SelectedIndex < 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 5;
						continue;
					}
					h.DataSource = null;
					num = 3;
					continue;
				case 5:
				{
					if (true)
					{
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tbook where xPaye=" + l.SelectedValue.ToString());
					h.DataSource = dataSource;
					h.DisplayMember = "Name";
					h.ValueMember = "id";
					flag = ((CollectionBase)(object)h.Items).Count <= 0;
					num = 6;
					continue;
				}
				case 1:
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					h.SelectedIndex = 0;
					num = 1;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			string text = " where  xYear=" + asdaj.a + " and xPaye in(" + asdaj.n + ")";
			bool flag = l.SelectedIndex < 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 3;
				case 5:
					j.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 3:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
					j.DataSource = dataSource;
					j.DisplayMember = "Name";
					j.ValueMember = "id";
					flag = ((CollectionBase)(object)j.Items).Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 1:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + asdaj.a + " and (xPaye = " + l.SelectedValue.ToString() + "))";
					num = 3;
					continue;
				}
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		string ak = default;
		while (true)
		{
			bool flag = f.SelectedIndex >= 1;
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
					ak = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + f.SelectedValue.ToString()).ToString();
					flag = h.SelectedIndex >= 1;
					num = 3;
					continue;
				case 6:
					MessageBox.Show("درس را انتخاب کنید");
					((UIComboBase)h).Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 3:
				{
					if (!flag)
					{
						if (true)
						{
						}
						num = 6;
						continue;
					}
					asdbd asdbd2 = new asdbd();
					asdbd2.af = j.SelectedValue.ToString();
					asdbd2.ag = l.SelectedValue.ToString();
					asdbd2.ah = f.SelectedValue.ToString();
					asdbd2.ai = h.SelectedValue.ToString();
					((Control)asdbd2.v).Text = l.SelectedItem.Text;
					((Control)asdbd2.t).Text = j.SelectedItem.Text;
					((Control)asdbd2.s).Text = f.SelectedItem.Text;
					((Control)asdbd2.u).Text = h.SelectedItem.Text;
					asdbd2.aj = ((Control)q).Text;
					asdbd2.ak = ak;
					((Form)asdbd2).ShowDialog();
					num = 0;
					continue;
				}
				case 2:
					MessageBox.Show("دوره را انتخاب کنید");
					((UIComboBase)f).Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}
}
