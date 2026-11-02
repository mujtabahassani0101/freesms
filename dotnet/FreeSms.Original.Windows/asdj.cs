using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

public class asdj : Form
{
	private IContainer m_a = null;

	private UIButton m_b;

	private Label m_c;

	private GridEX m_d;

	private UIComboBox m_e;

	private UIButton m_f;

	private UIButton m_g;

	private Label m_h;

	private UIComboBox i;

	private UIComboBox j;

	private Label k;

	private Label l;

	private UIComboBox m;

	private UIComboBox n;

	private Label o;

	private Label p;

	private Label q;

	public asdj()
	{
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 7:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 0:
					p.Text = asdaj.__field_a;
					this.m_e.SelectedIndex = 0;
					f();
					d();
					e();
					c();
					b();
					num = 4;
					continue;
				case 4:
					return;
				case 1:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 6;
					continue;
				case 6:
					return;
				case 2:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void f()
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT DISTINCT tPaye.id, tPaye.Name\r\n            FROM         tPaye INNER JOIN\r\n                      tBook ON tPaye.id = tBook.xPaye  where tPaye.id in(" + asdaj.n + ")");
			i.DataSource = dataTable;
			i.DisplayMember = "name";
			i.ValueMember = "id";
			bool flag = dataTable.Rows.Count != 0;
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
					i.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					MessageBox.Show("هنوز درسی تعریف نشده است");
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		while (true)
		{
			string text = "";
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     id,fNamf + N' ' + fNaml  AS Name  FROM tTeacher" + text + " order by fNamf");
			n.DataSource = dataTable;
			n.DisplayMember = "name";
			n.ValueMember = "id";
			bool flag = dataTable.Rows.Count != 0;
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
					n.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					MessageBox.Show("هنوز معلمی تعریف نشده است");
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			bool flag = i.SelectedIndex < 0;
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
					j.DataSource = null;
					num = 0;
					continue;
				case 3:
					return;
				case 5:
					MessageBox.Show("هنوز صنفی تعریف نشده است");
					num = 2;
					continue;
				case 2:
					return;
				case 1:
				{
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM   tClass where  xYear=" + p.Text + " and xPaye=" + i.SelectedValue.ToString());
					j.DataSource = dataTable;
					j.DisplayMember = "name";
					j.ValueMember = "id";
					flag = dataTable.Rows.Count != 0;
					if (true)
					{
					}
					num = 6;
					continue;
				}
				case 6:
					if (flag)
					{
						j.SelectedIndex = 0;
						num = 3;
					}
					else
					{
						num = 5;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		string text = default;
		while (true)
		{
			bool flag = i.SelectedIndex < 0;
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
					return;
				case 8:
					m.SelectedIndex = 0;
					if (true)
					{
					}
					num = 6;
					continue;
				case 4:
				{
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT id, Name FROM tbook WHERE (xPaye = " + i.SelectedValue.ToString() + ")" + text);
					m.DataSource = dataTable;
					m.DisplayMember = "name";
					m.ValueMember = "id";
					flag = dataTable.Rows.Count <= 0;
					num = 7;
					continue;
				}
				case 7:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 6;
				case 2:
					text = "";
					flag = j.SelectedIndex < 0;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 6:
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					text = " AND (id NOT IN (SELECT xLsn  FROM tTch_Cls WHERE     (xCls = " + j.SelectedValue.ToString() + ")))";
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		string text = "SELECT  tTeacher.fNamF + ' ' + tTeacher.fNamL AS tch, tBook.Name AS lsn, tPaye.Name AS Paye, tClass.name AS cls, tTch_Cls.xCls, tTch_Cls.xLsn\r\n                      FROM  tTch_Cls INNER JOIN\r\n                      tTeacher ON tTch_Cls.xTch = tTeacher.id INNER JOIN\r\n                      tBook ON tTch_Cls.xLsn = tBook.id INNER JOIN\r\n                      tPaye ON tBook.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tTch_Cls.xCls = tClass.id  where  tClass.xYear=" + p.Text;
		try
		{
			while (true)
			{
				IL_004c:
				bool flag = !(this.m_e.SelectedValue.ToString() == "cls");
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
						flag = !(this.m_e.SelectedValue.ToString() == "tch");
						num = 4;
						continue;
					case 4:
						if (!flag)
						{
							num = 7;
							continue;
						}
						flag = !(this.m_e.SelectedValue.ToString() == "both");
						num = 3;
						continue;
					case 8:
					{
						string text2 = text;
						text = text2 + " and tTch_Cls.xTch=" + n.SelectedValue.ToString() + " and tTch_Cls.xCls=" + j.SelectedValue.ToString() + " ORDER BY tBook.xPaye, tTch_Cls.xCls, tTch_Cls.xLsn";
						num = 6;
						continue;
					}
					case 5:
						text = text + " and tTch_Cls.xCls=" + j.SelectedValue.ToString() + " ORDER BY tBook.xPaye, tTch_Cls.xCls, tTch_Cls.xLsn";
						num = 1;
						continue;
					case 1:
						if (1 == 0)
						{
						}
						goto case 6;
					case 3:
						if (!flag)
						{
							num = 8;
							continue;
						}
						goto case 6;
					case 7:
						text = text + " and tTch_Cls.xTch=" + n.SelectedValue.ToString() + " ORDER BY tBook.xPaye, tTch_Cls.xCls, tTch_Cls.xLsn";
						num = 9;
						continue;
					case 6:
					case 9:
						num = 0;
						continue;
					case 0:
						goto end_IL_001b;
					}
					goto IL_004c;
					continue;
					end_IL_001b:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, text);
		this.m_d.DataSource = dataSource;
	}

	private void g(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void f(object A_0, EventArgs A_1)
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
					if (j.SelectedIndex >= 0)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto IL_0135;
				case 7:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tTch_Cls (xCls, xLsn, xTch)\r\n                     VALUES     (" + j.SelectedValue.ToString() + ", " + m.SelectedValue.ToString() + ", " + n.SelectedValue.ToString() + ")");
					num = 2;
					continue;
				case 3:
					num = 6;
					continue;
				case 6:
					num2 = ((n.SelectedIndex < 0) ? 1 : 0);
					goto IL_0146;
				case 1:
					num = 0;
					continue;
				case 0:
					if (m.SelectedIndex >= 0)
					{
						num = 3;
						continue;
					}
					goto IL_0135;
				case 4:
					num2 = 1;
					goto IL_0146;
				case 8:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 2;
				case 2:
					{
						c();
						b();
						return;
					}
					IL_0135:
					num = 4;
					continue;
					IL_0146:
					flag = (byte)num2 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (this.m_d.RowCount > 0)
					{
						num = 3;
						continue;
					}
					goto IL_0148;
				case 5:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tTch_Cls where xCls=" + this.m_d.SelectedItems[0].GetRow().Cells["xCls"].Value.ToString() + " and xLsn=" + this.m_d.SelectedItems[0].GetRow().Cells["xLsn"].Value.ToString());
					num = 0;
					continue;
				case 2:
					num = 1;
					continue;
				case 1:
					num2 = ((MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1 : 0);
					goto IL_0159;
				case 3:
					num = 7;
					continue;
				case 7:
					if (this.m_d.SelectedItems[0].RowType == RowType.Record)
					{
						num = 2;
						continue;
					}
					goto IL_0148;
				case 4:
					num2 = 1;
					goto IL_0159;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 0;
				case 0:
					{
						b();
						c();
						return;
					}
					IL_0159:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 8;
					continue;
					IL_0148:
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		d();
		c();
	}

	private void b(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			c();
			bool flag = !(this.m_e.SelectedValue.ToString() != "tch");
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
					b();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(this.m_e.SelectedValue.ToString() != "cls");
			if (true)
			{
			}
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
					b();
					num = 0;
					continue;
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
					if (true)
					{
					}
					num = ((!A_0) ? 6 : 0);
					continue;
				case 0:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 6:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 5;
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdj));
		GridEXLayout gridEXLayout = new GridEXLayout();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		StringFormat stringFormat4 = new StringFormat();
		StringFormat stringFormat5 = new StringFormat();
		this.m_b = new UIButton();
		this.m_c = new Label();
		this.m_d = new GridEX();
		this.m_e = new UIComboBox();
		this.m_f = new UIButton();
		this.m_g = new UIButton();
		this.m_h = new Label();
		i = new UIComboBox();
		j = new UIComboBox();
		k = new Label();
		l = new Label();
		m = new UIComboBox();
		n = new UIComboBox();
		o = new Label();
		p = new Label();
		q = new Label();
		((ISupportInitialize)this.m_d).BeginInit();
		SuspendLayout();
		this.m_b.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_b.ImageSize = new Size(40, 40);
		this.m_b.Location = new Point(12, 386);
		this.m_b.Name = "btnClose";
		this.m_b.Size = new Size(130, 40);
		this.m_b.TabIndex = 30;
		this.m_b.Text = "بستن";
		this.m_b.Click += g;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_c.AutoSize = true;
		this.m_c.Location = new Point(751, 89);
		this.m_c.Name = "label1";
		this.m_c.Size = new Size(22, 13);
		this.m_c.TabIndex = 43;
		this.m_c.Text = "نوع";
		this.m_d.AllowEdit = InheritableBoolean.False;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_d.DesignTimeLayout = gridEXLayout;
		this.m_d.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_d.Font = new Font("Tahoma", 9.75f);
		this.m_d.GroupByBoxVisible = false;
		this.m_d.Location = new Point(12, 46);
		this.m_d.Name = "gTchCls";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.RowHeaders = InheritableBoolean.True;
		this.m_d.Size = new Size(515, 323);
		this.m_d.TabIndex = 52;
		this.m_d.VisualStyle = VisualStyle.Office2003;
		this.m_e.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "";
		uIComboBoxItem.Value = "0";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "صنف";
		uIComboBoxItem2.Value = "cls";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "استاد";
		uIComboBoxItem3.Value = "tch";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "استاد-صنف";
		uIComboBoxItem4.Value = "both";
		this.m_e.Items.AddRange(new UIComboBoxItem[4] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4 });
		this.m_e.Location = new Point(203, 12);
		this.m_e.Name = "comboTypeFilter";
		this.m_e.Size = new Size(207, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_e.StringFormat = stringFormat;
		this.m_e.TabIndex = 53;
		this.m_e.SelectedIndexChanged += e;
		this.m_f.ImageSize = new Size(45, 45);
		this.m_f.Location = new Point(548, 193);
		this.m_f.Name = "btnAdd";
		this.m_f.Size = new Size(197, 41);
		this.m_f.TabIndex = 54;
		this.m_f.Text = "اضافه";
		this.m_f.Click += f;
		this.m_g.ImageSize = new Size(35, 35);
		this.m_g.Location = new Point(397, 385);
		this.m_g.Name = "btnDelete";
		this.m_g.Size = new Size(130, 41);
		this.m_g.TabIndex = 55;
		this.m_g.Text = "حذف مورد انتخابی";
		this.m_g.Click += d;
		this.m_h.AutoSize = true;
		this.m_h.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(416, 12);
		this.m_h.Name = "label3";
		this.m_h.Size = new Size(103, 17);
		this.m_h.TabIndex = 56;
		this.m_h.Text = "نمایش بر اساس";
		i.Anchor = AnchorStyles.Top;
		i.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		i.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		i.Location = new Point(548, 85);
		i.Name = "comboPaye";
		i.Size = new Size(197, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		i.StringFormat = stringFormat2;
		i.TabIndex = 57;
		i.SelectedIndexChanged += c;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		j.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j.Location = new Point(548, 120);
		j.Name = "dropCls";
		j.Size = new Size(197, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		j.StringFormat = stringFormat3;
		j.TabIndex = 58;
		j.SelectedIndexChanged += b;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.AutoSize = true;
		k.Location = new Point(750, 124);
		k.Name = "label19";
		k.Size = new Size(30, 13);
		k.TabIndex = 59;
		k.Text = "صنف";
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoSize = true;
		l.Location = new Point(750, 161);
		l.Name = "label2";
		l.Size = new Size(29, 13);
		l.TabIndex = 61;
		l.Text = "درس";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		m.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		m.Location = new Point(548, 158);
		m.Name = "dropBook";
		m.Size = new Size(197, 23);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		m.StringFormat = stringFormat4;
		m.TabIndex = 60;
		n.Anchor = AnchorStyles.Top;
		n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		n.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		n.Location = new Point(548, 48);
		n.Name = "dropTch";
		n.Size = new Size(197, 23);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		n.StringFormat = stringFormat5;
		n.TabIndex = 62;
		n.SelectedIndexChanged += a;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		o.AutoSize = true;
		o.Location = new Point(750, 52);
		o.Name = "lTch";
		o.Size = new Size(33, 13);
		o.TabIndex = 63;
		o.Text = "استاد";
		p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		p.Location = new Point(617, 15);
		p.Name = "lYear";
		p.Size = new Size(68, 24);
		p.TabIndex = 120;
		q.AutoSize = true;
		q.Location = new Point(691, 20);
		q.Name = "label6";
		q.Size = new Size(66, 13);
		q.TabIndex = 119;
		q.Text = "سال تعلیمی";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(792, 459);
		Controls.Add(p);
		Controls.Add(q);
		Controls.Add(o);
		Controls.Add(n);
		Controls.Add(l);
		Controls.Add(m);
		Controls.Add(j);
		Controls.Add(k);
		Controls.Add(i);
		Controls.Add(this.m_h);
		Controls.Add(this.m_g);
		Controls.Add(this.m_f);
		Controls.Add(this.m_e);
		Controls.Add(this.m_d);
		Controls.Add(this.m_c);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmTchClass";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		Text = "معلم-صنف-درس";
		Load += h;
		((ISupportInitialize)this.m_d).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
