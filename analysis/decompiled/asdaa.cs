using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdaa : Form
{
	private string m_a;

	private IContainer m_b = null;

	private GridEX m_c;

	private Panel m_d;

	private Panel m_e;

	private UIButton m_f;

	private UIButton g;

	private Panel h;

	private UIButton i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private Panel m;

	private Label n;

	private UIComboBox o;

	private PrintPreviewDialog p;

	private GridEXPrintDocument q;

	private Label r;

	private Panel s;

	private EditBox t;

	private Label u;

	private EditBox v;

	private Label w;

	private Label x;

	private EditBox y;

	private Label z;

	private Label aa;

	public asdaa()
	{
		a();
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 5;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 7;
					continue;
				case 0:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 4;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 4:
					((Control)x).Text = asdaj.a;
					b();
					c();
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 6;
					continue;
				case 6:
					return;
				case 1:
					num = 0;
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tmaghta where id not in(select xmaghta from tYearMaghtaCountDay where xYear=" + asdaj.a + ") order by id");
			o.DataSource = dataSource;
			o.DisplayMember = "Name";
			o.ValueMember = "id";
			bool flag = ((CollectionBase)(object)o.Items).Count != 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					((Control)s).Visible = false;
					((Control)this.m_f).Visible = false;
					((Control)g).Left = 365;
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

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tYearMaghtaCountDay.id, tMaghta.name AS maghta, tYearMaghtaCountDay.Term1, tYearMaghtaCountDay.Term2, \r\n                      tYearMaghtaCountDay.Term1 + tYearMaghtaCountDay.Term2 AS sumyear\r\n                        FROM         tYearMaghtaCountDay INNER JOIN\r\n                                              tMaghta ON tYearMaghtaCountDay.xMaghta = tMaghta.id\r\n                        WHERE         tYearMaghtaCountDay.xYear = " + ((Control)x).Text);
		this.m_c.DataSource = dataSource;
	}

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a = "insert";
		((Control)o).Visible = true;
		((Control)s).Visible = true;
		((Control)v).Text = "";
		((Control)t).Text = "";
		((Control)y).Text = "";
		((UIComboBase)o).Focus();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_c.RowCount <= 0;
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
					this.m_a = "update";
					((Control)s).Visible = true;
					((Control)v).Text = this.m_c.SelectedItems[0].GetRow().Cells["Term1"].Value.ToString();
					((Control)t).Text = this.m_c.SelectedItems[0].GetRow().Cells["Term2"].Value.ToString();
					((Control)aa).Text = this.m_c.SelectedItems[0].GetRow().Cells["maghta"].Value.ToString();
					((Control)o).Visible = false;
					((Control)y).Text = this.m_c.SelectedItems[0].GetRow().Cells["sumyear"].Value.ToString();
					((Control)v).Select();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		string a_ = default;
		string a_2 = default;
		while (true)
		{
			bool flag = ((Control)s).Visible;
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = (flag ? 22 : 10);
					continue;
				case 1:
					num2 = 1;
					goto IL_027d;
				case 18:
					MessageBox.Show("تعداد روز های سالانه را وارد کنید");
					((Control)t).Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 14:
					MessageBox.Show("مقطع را انتخاب کنید");
					((UIComboBase)o).Focus();
					num = 20;
					continue;
				case 20:
					return;
				case 23:
				case 24:
				{
					if (true)
					{
					}
					SqlParameter[] a_3 = new SqlParameter[5]
					{
						asdcb.a("@id", SqlDbType.Int, a_),
						asdcb.a("@xYear", SqlDbType.Int, ((Control)x).Text),
						asdcb.a("@xmaghta", SqlDbType.Int, a_2),
						asdcb.a("@Term1", SqlDbType.Int, ((Control)v).Text),
						asdcb.a("@Term2", SqlDbType.Int, ((Control)t).Text)
					};
					int num5 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tYearMaghtaCountDay_insertUpdate", a_3);
					flag = num5 <= 0;
					num = 17;
					continue;
				}
				case 17:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 16:
					a_ = this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 23;
					continue;
				case 2:
					if (!flag)
					{
						num = 14;
						continue;
					}
					flag = !(((Control)v).Text.Trim() == "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 19;
						continue;
					}
					try
					{
						int num4 = int.Parse(((Control)v).Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای تعداد روز های چهار و نیم ماهه فقط عدد وارد کنید");
						((Control)v).Focus();
						return;
					}
					flag = !(((Control)t).Text.Trim() == "");
					num = 7;
					continue;
				case 15:
					if (flag)
					{
						a_2 = o.SelectedValue.ToString();
						num = 24;
					}
					else
					{
						num = 16;
					}
					continue;
				case 7:
					if (flag)
					{
						try
						{
							int num3 = int.Parse(((Control)t).Text.Trim());
						}
						catch
						{
							MessageBox.Show("برای تعداد روز های سالانه فقط عدد وارد کنید");
							((Control)t).Focus();
							return;
						}
						a_ = "0";
						a_2 = "0";
						flag = !(this.m_a == "update");
						num = 15;
					}
					else
					{
						num = 18;
					}
					continue;
				case 3:
					((Control)s).Visible = false;
					num = 8;
					continue;
				case 19:
					MessageBox.Show("تعداد روز های چهار و نیم ماهه را وارد کنید");
					((Control)v).Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 0:
					flag = !(this.m_a == "update");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 8;
				case 12:
					num = 25;
					continue;
				case 25:
					num2 = ((o.SelectedIndex >= 0) ? 1 : 0);
					goto IL_027d;
				case 8:
					b();
					MessageBox.Show("ثبت شد");
					c();
					((Control)v).Text = "";
					((Control)t).Text = "";
					((UIComboBase)o).Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 10:
					num = 6;
					continue;
				case 6:
					return;
				case 22:
					{
						num = ((!(this.m_a == "insert")) ? 1 : 12);
						continue;
					}
					IL_027d:
					flag = (byte)num2 != 0;
					num = 2;
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
		((Control)s).Visible = false;
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					num = ((!A_0) ? 1 : 2);
					continue;
				case 2:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 6:
					this.m_b.Dispose();
					num = 3;
					continue;
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_0074;
				case 3:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 5;
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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected Obj, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected Obj, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected Obj, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected Obj, but got Unknown
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected Obj, but got Unknown
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected Obj, but got Unknown
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected Obj, but got Unknown
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_1023: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdaa));
		StringFormat val2 = new StringFormat();
		this.m_c = new GridEX();
		this.m_d = new Panel();
		x = new Label();
		w = new Label();
		s = new Panel();
		h = new Panel();
		aa = new Label();
		z = new Label();
		y = new EditBox();
		t = new EditBox();
		u = new Label();
		v = new EditBox();
		r = new Label();
		n = new Label();
		o = new UIComboBox();
		k = new UIButton();
		j = new UIButton();
		l = new Label();
		this.m_e = new Panel();
		i = new UIButton();
		this.m_f = new UIButton();
		g = new UIButton();
		m = new Panel();
		p = new PrintPreviewDialog();
		q = new GridEXPrintDocument();
		((ISupportInitialize)this.m_c).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((Control)s).SuspendLayout();
		((Control)h).SuspendLayout();
		((Control)this.m_e).SuspendLayout();
		((Control)m).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_c.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_c).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = val;
		this.m_c.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_c).Font = new Font("B Nazanin", 12f);
		this.m_c.GroupByBoxVisible = false;
		((Control)this.m_c).Location = new Point(8, 90);
		((Control)this.m_c).Name = "gridEX1";
		this.m_c.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_c).Size = new Size(458, 202);
		((Control)this.m_c).TabIndex = 5;
		((ScrollableBase)this.m_c).VisualStyle = (VisualStyle)2;
		((Control)this.m_d).BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.BorderStyle = (BorderStyle)1;
		((Control)this.m_d).Controls.Add((Control)(object)x);
		((Control)this.m_d).Controls.Add((Control)(object)w);
		((Control)this.m_d).Controls.Add((Control)(object)s);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(5, 6);
		((Control)this.m_d).Name = "panel1";
		((Control)this.m_d).Size = new Size(479, 369);
		((Control)this.m_d).TabIndex = 0;
		x.BorderStyle = (BorderStyle)1;
		((Control)x).Location = new Point(34, 31);
		((Control)x).Name = "lYear";
		((Control)x).Size = new Size(68, 24);
		((Control)x).TabIndex = 120;
		((Control)w).AutoSize = true;
		((Control)w).Location = new Point(107, 29);
		((Control)w).Name = "label7";
		((Control)w).Size = new Size(78, 26);
		((Control)w).TabIndex = 99;
		((Control)w).Text = "سال تعلیمی";
		((Control)s).BackColor = SystemColors.ControlText;
		((Control)s).Controls.Add((Control)(object)h);
		((Control)s).Location = new Point(58, 63);
		((Control)s).Name = "pcls";
		((Control)s).Size = new Size(320, 237);
		((Control)s).TabIndex = 97;
		((Control)s).Visible = false;
		((Control)h).BackColor = SystemColors.GradientInactiveCaption;
		h.BorderStyle = (BorderStyle)1;
		((Control)h).Controls.Add((Control)(object)aa);
		((Control)h).Controls.Add((Control)(object)z);
		((Control)h).Controls.Add((Control)(object)y);
		((Control)h).Controls.Add((Control)(object)t);
		((Control)h).Controls.Add((Control)(object)u);
		((Control)h).Controls.Add((Control)(object)v);
		((Control)h).Controls.Add((Control)(object)r);
		((Control)h).Controls.Add((Control)(object)n);
		((Control)h).Controls.Add((Control)(object)o);
		((Control)h).Controls.Add((Control)(object)k);
		((Control)h).Controls.Add((Control)(object)j);
		((Control)h).Location = new Point(3, 3);
		((Control)h).Name = "pcls00";
		((Control)h).Size = new Size(314, 231);
		((Control)h).TabIndex = 10;
		aa.BorderStyle = (BorderStyle)1;
		((Control)aa).Location = new Point(23, 20);
		((Control)aa).Name = "lMaghta";
		((Control)aa).Size = new Size(182, 32);
		((Control)aa).TabIndex = 121;
		((Control)aa).Visible = false;
		((Control)z).AutoSize = true;
		((Control)z).Location = new Point(173, 138);
		((Control)z).Name = "label1";
		((Control)z).Size = new Size(47, 26);
		((Control)z).TabIndex = 95;
		((Control)z).Text = "سالانه";
		((EditBase)y).AutoScroll = false;
		((EditBase)y).AutoScrollMargin = new Size(0, 0);
		((EditBase)y).AutoScrollMinSize = new Size(0, 0);
		((EditBase)y).AutoScrollPosition = new Point(0, 0);
		((Control)y).Enabled = false;
		((Control)y).Location = new Point(85, 135);
		((Control)y).Name = "txtSumYear";
		((Control)y).Size = new Size(83, 33);
		((Control)y).TabIndex = 94;
		((EditBase)y).TextAlignment = (TextAlignment)1;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((Control)t).Location = new Point(85, 96);
		((Control)t).Name = "txtTerm2";
		((Control)t).Size = new Size(83, 33);
		((Control)t).TabIndex = 4;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((Control)u).AutoSize = true;
		((Control)u).Location = new Point(172, 100);
		((Control)u).Name = "label5";
		((Control)u).Size = new Size(125, 26);
		((Control)u).TabIndex = 93;
		((Control)u).Text = " چهار و نیم ماهه دوم";
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((Control)v).Location = new Point(85, 59);
		((Control)v).Name = "txtTerm1";
		((Control)v).Size = new Size(83, 33);
		((Control)v).TabIndex = 3;
		((EditBase)v).TextAlignment = (TextAlignment)1;
		((Control)r).AutoSize = true;
		((Control)r).Location = new Point(172, 63);
		((Control)r).Name = "label3";
		((Control)r).Size = new Size(98, 26);
		((Control)r).TabIndex = 41;
		((Control)r).Text = "چهار و نیم ماهه";
		((Control)n).AutoSize = true;
		((Control)n).Location = new Point(212, 23);
		((Control)n).Name = "label20";
		((Control)n).Size = new Size(43, 26);
		((Control)n).TabIndex = 37;
		((Control)n).Text = "مقطع";
		((UIComboBase)o).ComboStyle = (ComboStyle)1;
		((UIComboBase)o).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)o).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(22, 20);
		((Control)o).Name = "dropMaghta";
		((Control)o).Size = new Size(184, 33);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)o).StringFormat = val2;
		((Control)o).TabIndex = 0;
		k.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)k).Location = new Point(23, 188);
		((Control)k).Name = "btnCancel";
		((Control)k).Size = new Size(90, 32);
		((Control)k).TabIndex = 7;
		((Control)k).Text = "انصراف";
		((Control)k).Click += a;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)j).Location = new Point(131, 188);
		((Control)j).Name = "btnAcp";
		((Control)j).Size = new Size(96, 32);
		((Control)j).TabIndex = 6;
		((Control)j).Text = "تایید";
		((Control)j).Click += c;
		((Control)l).AutoSize = true;
		((Control)l).Font = new Font("B Nazanin", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).ForeColor = Color.DarkViolet;
		((Control)l).Location = new Point(254, 14);
		((Control)l).Name = "label4";
		((Control)l).Size = new Size(198, 51);
		((Control)l).TabIndex = 17;
		((Control)l).Text = "ایام سال تعلیمی";
		((Control)this.m_e).Anchor = (AnchorStyles)14;
		((Control)this.m_e).Controls.Add((Control)(object)i);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Controls.Add((Control)(object)g);
		((Control)this.m_e).Location = new Point(6, 301);
		((Control)this.m_e).Name = "p_new";
		((Control)this.m_e).Size = new Size(468, 56);
		((Control)this.m_e).TabIndex = 9;
		((Control)i).Anchor = (AnchorStyles)14;
		i.DialogResult = (DialogResult)2;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		((Control)i).Location = new Point(7, 7);
		((Control)i).Name = "btnClose";
		((Control)i).Size = new Size(98, 43);
		((Control)i).TabIndex = 15;
		((Control)i).Text = "خروج";
		((Control)i).Click += b;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_f).Location = new Point(365, 6);
		((Control)this.m_f).Name = "btnNew";
		((Control)this.m_f).Size = new Size(90, 42);
		((Control)this.m_f).TabIndex = 0;
		((Control)this.m_f).Text = "جدید";
		((Control)this.m_f).Click += e;
		g.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)g).Location = new Point(262, 6);
		((Control)g).Name = "btnEdit";
		((Control)g).Size = new Size(90, 42);
		((Control)g).TabIndex = 1;
		((Control)g).Text = "اصلاح";
		((Control)g).Click += d;
		((Control)m).BackColor = SystemColors.ControlText;
		((Control)m).Controls.Add((Control)(object)this.m_d);
		((Control)m).Dock = (DockStyle)5;
		((Control)m).Location = new Point(0, 0);
		((Control)m).Name = "panel2";
		((Control)m).Size = new Size(488, 380);
		((Control)m).TabIndex = 1;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		((Form)p).ClientSize = new Size(400, 300);
		p.Document = (PrintDocument)(object)q;
		p.Enabled = true;
		p.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)p).Name = "printPreviewDialog1";
		p.Visible = false;
		q.PageFooterLeft = "3";
		q.PageFooterRight = "2";
		q.PageHeaderCenter = "1";
		q.PageHeaderLeft = "4";
		q.PageHeaderRight = "5";
		((Form)this).AcceptButton = (IButtonControl)(object)j;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)i;
		((Form)this).ClientSize = new Size(488, 380);
		((Control)this).Controls.Add((Control)(object)m);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmYearMaghtaCountDay";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "مدیریت صنوف";
		((Form)this).Load += f;
		((ISupportInitialize)this.m_c).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)s).ResumeLayout(false);
		((Control)h).ResumeLayout(false);
		((Control)h).PerformLayout();
		((Control)this.m_e).ResumeLayout(false);
		((Control)m).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
