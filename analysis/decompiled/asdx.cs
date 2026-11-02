using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;

public class asdx : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private Panel m_d;

	private Label e;

	private UIComboBox f;

	private Label g;

	private UIComboBox h;

	private Label i;

	private UIComboBox j;

	private Panel k;

	private Label l;

	private Button m;

	private Label n;

	private Label o;

	public string p;

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
						num = 1;
					}
					continue;
				case 6:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 2;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 2:
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

	private void d()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected Obj, but got Unknown
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdx));
		StringFormat val = new StringFormat();
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		this.m_b = new Panel();
		k = new Panel();
		this.m_d = new Panel();
		n = new Label();
		o = new Label();
		m = new Button();
		l = new Label();
		e = new Label();
		this.m_c = new UIButton();
		f = new UIComboBox();
		g = new Label();
		h = new UIComboBox();
		i = new Label();
		j = new UIComboBox();
		((Control)this.m_b).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)k);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(304, 263);
		((Control)this.m_b).TabIndex = 0;
		((Control)k).BackColor = SystemColors.ControlText;
		((Control)k).Controls.Add((Control)(object)this.m_d);
		((Control)k).Dock = (DockStyle)5;
		((Control)k).Location = new Point(0, 0);
		((Control)k).Name = "panel3";
		((Control)k).Size = new Size(302, 261);
		((Control)k).TabIndex = 19;
		((Control)this.m_d).BackColor = SystemColors.GradientInactiveCaption;
		((Control)this.m_d).Controls.Add((Control)(object)n);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_d).Controls.Add((Control)(object)f);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Location = new Point(4, 5);
		((Control)this.m_d).Name = "panel2";
		((Control)this.m_d).Size = new Size(294, 250);
		((Control)this.m_d).TabIndex = 18;
		n.BorderStyle = (BorderStyle)1;
		((Control)n).Location = new Point(156, 47);
		((Control)n).Name = "lYear";
		((Control)n).Size = new Size(68, 24);
		((Control)n).TabIndex = 120;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(231, 52);
		((Control)o).Name = "label6";
		((Control)o).Size = new Size(66, 13);
		((Control)o).TabIndex = 119;
		((Control)o).Text = "سال تعلیمی";
		((Control)m).Location = new Point(27, 162);
		((Control)m).Name = "btnStart";
		((Control)m).Size = new Size(201, 33);
		((Control)m).TabIndex = 39;
		((Control)m).Text = "ثبت توضیح";
		((ButtonBase)m).UseVisualStyleBackColor = true;
		((Control)m).Click += a;
		((Control)l).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)l).ForeColor = Color.DarkViolet;
		((Control)l).Location = new Point(3, 3);
		((Control)l).Name = "lheder";
		((Control)l).Size = new Size(288, 37);
		((Control)l).TabIndex = 38;
		((Control)l).Text = "ورود توضیحات زیر اطلاع نامه";
		l.TextAlign = (ContentAlignment)32;
		((Control)e).Anchor = (AnchorStyles)9;
		((Control)e).AutoSize = true;
		((Control)e).Location = new Point(233, 80);
		((Control)e).Name = "lExam";
		((Control)e).Size = new Size(26, 13);
		((Control)e).TabIndex = 37;
		((Control)e).Text = "دوره";
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageSize = new Size(40, 40);
		((Control)this.m_c).Location = new Point(27, 201);
		((Control)this.m_c).Name = "btnClose";
		((Control)this.m_c).Size = new Size(201, 35);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "بستن";
		((Control)this.m_c).Click += c;
		((Control)f).Anchor = (AnchorStyles)9;
		((UIComboBase)f).ComboStyle = (ComboStyle)1;
		((UIComboBase)f).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)f).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)f).Location = new Point(27, 75);
		((Control)f).Name = "dropExam";
		((Control)f).Size = new Size(201, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)f).StringFormat = val;
		((Control)f).TabIndex = 36;
		f.SelectedIndexChanged += b;
		((Control)g).Anchor = (AnchorStyles)9;
		((Control)g).AutoSize = true;
		((Control)g).Location = new Point(233, 138);
		((Control)g).Name = "label19";
		((Control)g).Size = new Size(30, 13);
		((Control)g).TabIndex = 33;
		((Control)g).Text = "صنف";
		((Control)h).Anchor = (AnchorStyles)9;
		((UIComboBase)h).ComboStyle = (ComboStyle)1;
		((UIComboBase)h).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)h).Location = new Point(27, 133);
		((Control)h).Name = "dropCls";
		((Control)h).Size = new Size(201, 23);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)h).StringFormat = val2;
		((Control)h).TabIndex = 31;
		((Control)i).Anchor = (AnchorStyles)9;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(233, 109);
		((Control)i).Name = "label20";
		((Control)i).Size = new Size(22, 13);
		((Control)i).TabIndex = 32;
		((Control)i).Text = "پایه";
		((Control)j).Anchor = (AnchorStyles)9;
		((UIComboBase)j).ComboStyle = (ComboStyle)1;
		((UIComboBase)j).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)j).Location = new Point(27, 104);
		((Control)j).Name = "dropPaye";
		((Control)j).Size = new Size(201, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)j).StringFormat = val3;
		((Control)j).TabIndex = 30;
		j.SelectedIndexChanged += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(304, 263);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "frmCommentKollEntrySelect";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "انتخاب دوره";
		((Form)this).Load += d;
		((Control)this.m_b).ResumeLayout(false);
		((Control)k).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public asdx()
	{
		d();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 10;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 0;
					continue;
				case 2:
					((Control)l).Text = "ورود توضیحات زیر اطلاع نامه";
					num = 1;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 7;
				case 1:
					flag = !(p == "6");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 10:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 12;
					continue;
				case 12:
					return;
				case 7:
					((Control)n).Text = asdaj.a;
					c();
					b();
					flag = !(p == "5");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 5:
					((Control)l).Text = "ورود توضیحات جدول نتایج";
					((Control)f).Visible = false;
					((Control)e).Visible = false;
					f.SelectedValue = asdcb.a(asdab.e(), CommandType.Text, "select id from tExam where term=3 and xYear=" + ((Control)n).Text).ToString();
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				case 6:
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
					num = 7;
					continue;
				case 4:
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where xYear=" + ((Control)n).Text + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			f.DataSource = dataSource;
			f.DisplayMember = "Name";
			f.ValueMember = "id";
			bool flag = ((CollectionBase)(object)f.Items).Count <= 0;
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
					f.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					if (1 == 0)
					{
					}
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ((Control)n).Text + ") order by id");
			j.DataSource = dataSource;
			j.DisplayMember = "Name";
			j.ValueMember = "id";
			bool flag = ((CollectionBase)(object)j.Items).Count <= 0;
			int num = 2;
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
					return;
				case 0:
					if (true)
					{
					}
					j.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
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
			string text = " where xYear=" + asdaj.a + " and xPaye in(" + asdaj.n + ")";
			bool flag = j.SelectedIndex < 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto case 5;
				case 3:
					h.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass" + text);
					h.DataSource = dataSource;
					h.DisplayMember = "Name";
					h.ValueMember = "id";
					flag = ((CollectionBase)(object)h.Items).Count <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 1:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student WHERE xYear=" + ((Control)n).Text + " and (xPaye = " + j.SelectedValue.ToString() + "))";
					num = 5;
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
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		asda2 asda10 = default;
		while (true)
		{
			bool flag = f.SelectedIndex >= 1;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 9;
						continue;
					}
					asda10 = new asda2();
					asda10.r = h.SelectedValue.ToString();
					asda10.s = j.SelectedValue.ToString();
					asda10.t = f.SelectedValue.ToString();
					((Control)asda10.i).Text = j.SelectedItem.Text;
					((Control)asda10.k).Text = h.SelectedItem.Text;
					((Control)asda10.j).Text = f.SelectedItem.Text;
					flag = !(p == "5");
					num = 1;
					continue;
				case 7:
					asda10.u = "6";
					asda10.v = "-6";
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					asda10.u = "5";
					asda10.v = "-5";
					num = 0;
					continue;
				case 9:
					MessageBox.Show("دوره را انتخاب کنید");
					((UIComboBase)f).Focus();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				case 3:
					((Form)asda10).ShowDialog();
					num = 5;
					continue;
				case 5:
					return;
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(p == "6");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}
}
