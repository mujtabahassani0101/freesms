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
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)this).BackColor = Color.FromArgb(red, green, blue);
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
					((Control)p).Text = asdaj.a;
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
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
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM   tClass where  xYear=" + ((Control)p).Text + " and xPaye=" + i.SelectedValue.ToString());
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
		string text = "SELECT  tTeacher.fNamF + ' ' + tTeacher.fNamL AS tch, tBook.Name AS lsn, tPaye.Name AS Paye, tClass.name AS cls, tTch_Cls.xCls, tTch_Cls.xLsn\r\n                      FROM  tTch_Cls INNER JOIN\r\n                      tTeacher ON tTch_Cls.xTch = tTeacher.id INNER JOIN\r\n                      tBook ON tTch_Cls.xLsn = tBook.id INNER JOIN\r\n                      tPaye ON tBook.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tTch_Cls.xCls = tClass.id  where  tClass.xYear=" + ((Control)p).Text;
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
		((Form)this).Close();
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
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
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
					num2 = (((int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6) ? 1 : 0);
					goto IL_0159;
				case 3:
					num = 7;
					continue;
				case 7:
					if ((int)this.m_d.SelectedItems[0].RowType == 0)
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
						((Form)this).Dispose(A_0);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected Obj, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected Obj, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Expected Obj, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdj));
		GridEXLayout val = new GridEXLayout();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		StringFormat val6 = new StringFormat();
		StringFormat val7 = new StringFormat();
		StringFormat val8 = new StringFormat();
		StringFormat val9 = new StringFormat();
		StringFormat val10 = new StringFormat();
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
		((Control)this).SuspendLayout();
		this.m_b.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_b.ImageSize = new Size(40, 40);
		((Control)this.m_b).Location = new Point(12, 386);
		((Control)this.m_b).Name = "btnClose";
		((Control)this.m_b).Size = new Size(130, 40);
		((Control)this.m_b).TabIndex = 30;
		((Control)this.m_b).Text = "بستن";
		((Control)this.m_b).Click += g;
		((Control)this.m_c).Anchor = (AnchorStyles)9;
		((Control)this.m_c).AutoSize = true;
		((Control)this.m_c).Location = new Point(751, 89);
		((Control)this.m_c).Name = "label1";
		((Control)this.m_c).Size = new Size(22, 13);
		((Control)this.m_c).TabIndex = 43;
		((Control)this.m_c).Text = "نوع";
		this.m_d.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_d).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_d.DesignTimeLayout = val;
		this.m_d.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_d).Font = new Font("Tahoma", 9.75f);
		this.m_d.GroupByBoxVisible = false;
		((Control)this.m_d).Location = new Point(12, 46);
		((Control)this.m_d).Name = "gTchCls";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		this.m_d.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_d).Size = new Size(515, 323);
		((Control)this.m_d).TabIndex = 52;
		((ScrollableBase)this.m_d).VisualStyle = (VisualStyle)2;
		((UIComboBase)this.m_e).ComboStyle = (ComboStyle)1;
		val2.FormatStyle.Alpha = 0;
		val2.Text = "";
		val2.Value = "0";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "صنف";
		val3.Value = "cls";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "استاد";
		val4.Value = "tch";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "استاد-صنف";
		val5.Value = "both";
		this.m_e.Items.AddRange(new UIComboBoxItem[4] { val2, val3, val4, val5 });
		((Control)this.m_e).Location = new Point(203, 12);
		((Control)this.m_e).Name = "comboTypeFilter";
		((Control)this.m_e).Size = new Size(207, 21);
		val6.Alignment = (StringAlignment)0;
		val6.FormatFlags = (StringFormatFlags)20485;
		val6.HotkeyPrefix = (HotkeyPrefix)0;
		val6.LineAlignment = (StringAlignment)1;
		val6.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_e).StringFormat = val6;
		((Control)this.m_e).TabIndex = 53;
		this.m_e.SelectedIndexChanged += e;
		this.m_f.ImageSize = new Size(45, 45);
		((Control)this.m_f).Location = new Point(548, 193);
		((Control)this.m_f).Name = "btnAdd";
		((Control)this.m_f).Size = new Size(197, 41);
		((Control)this.m_f).TabIndex = 54;
		((Control)this.m_f).Text = "اضافه";
		((Control)this.m_f).Click += f;
		this.m_g.ImageSize = new Size(35, 35);
		((Control)this.m_g).Location = new Point(397, 385);
		((Control)this.m_g).Name = "btnDelete";
		((Control)this.m_g).Size = new Size(130, 41);
		((Control)this.m_g).TabIndex = 55;
		((Control)this.m_g).Text = "حذف مورد انتخابی";
		((Control)this.m_g).Click += d;
		((Control)this.m_h).AutoSize = true;
		((Control)this.m_h).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(416, 12);
		((Control)this.m_h).Name = "label3";
		((Control)this.m_h).Size = new Size(103, 17);
		((Control)this.m_h).TabIndex = 56;
		((Control)this.m_h).Text = "نمایش بر اساس";
		((Control)i).Anchor = (AnchorStyles)1;
		((UIComboBase)i).ComboStyle = (ComboStyle)1;
		((UIComboBase)i).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)i).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)i).Location = new Point(548, 85);
		((Control)i).Name = "comboPaye";
		((Control)i).Size = new Size(197, 23);
		val7.Alignment = (StringAlignment)0;
		val7.FormatFlags = (StringFormatFlags)20485;
		val7.HotkeyPrefix = (HotkeyPrefix)0;
		val7.LineAlignment = (StringAlignment)1;
		val7.Trimming = (StringTrimming)1;
		((UIComboBase)i).StringFormat = val7;
		((Control)i).TabIndex = 57;
		i.SelectedIndexChanged += c;
		((Control)j).Anchor = (AnchorStyles)9;
		((UIComboBase)j).ComboStyle = (ComboStyle)1;
		((UIComboBase)j).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)j).Location = new Point(548, 120);
		((Control)j).Name = "dropCls";
		((Control)j).Size = new Size(197, 23);
		val8.Alignment = (StringAlignment)0;
		val8.FormatFlags = (StringFormatFlags)20485;
		val8.HotkeyPrefix = (HotkeyPrefix)0;
		val8.LineAlignment = (StringAlignment)1;
		val8.Trimming = (StringTrimming)1;
		((UIComboBase)j).StringFormat = val8;
		((Control)j).TabIndex = 58;
		j.SelectedIndexChanged += b;
		((Control)k).Anchor = (AnchorStyles)9;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(750, 124);
		((Control)k).Name = "label19";
		((Control)k).Size = new Size(30, 13);
		((Control)k).TabIndex = 59;
		((Control)k).Text = "صنف";
		((Control)l).Anchor = (AnchorStyles)9;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(750, 161);
		((Control)l).Name = "label2";
		((Control)l).Size = new Size(29, 13);
		((Control)l).TabIndex = 61;
		((Control)l).Text = "درس";
		((Control)m).Anchor = (AnchorStyles)9;
		((UIComboBase)m).ComboStyle = (ComboStyle)1;
		((UIComboBase)m).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)m).Location = new Point(548, 158);
		((Control)m).Name = "dropBook";
		((Control)m).Size = new Size(197, 23);
		val9.Alignment = (StringAlignment)0;
		val9.FormatFlags = (StringFormatFlags)20485;
		val9.HotkeyPrefix = (HotkeyPrefix)0;
		val9.LineAlignment = (StringAlignment)1;
		val9.Trimming = (StringTrimming)1;
		((UIComboBase)m).StringFormat = val9;
		((Control)m).TabIndex = 60;
		((Control)n).Anchor = (AnchorStyles)1;
		((UIComboBase)n).ComboStyle = (ComboStyle)1;
		((UIComboBase)n).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(548, 48);
		((Control)n).Name = "dropTch";
		((Control)n).Size = new Size(197, 23);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)n).StringFormat = val10;
		((Control)n).TabIndex = 62;
		n.SelectedIndexChanged += a;
		((Control)o).Anchor = (AnchorStyles)9;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(750, 52);
		((Control)o).Name = "lTch";
		((Control)o).Size = new Size(33, 13);
		((Control)o).TabIndex = 63;
		((Control)o).Text = "استاد";
		p.BorderStyle = (BorderStyle)1;
		((Control)p).Location = new Point(617, 15);
		((Control)p).Name = "lYear";
		((Control)p).Size = new Size(68, 24);
		((Control)p).TabIndex = 120;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(691, 20);
		((Control)q).Name = "label6";
		((Control)q).Size = new Size(66, 13);
		((Control)q).TabIndex = 119;
		((Control)q).Text = "سال تعلیمی";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(792, 459);
		((Control)this).Controls.Add((Control)(object)p);
		((Control)this).Controls.Add((Control)(object)q);
		((Control)this).Controls.Add((Control)(object)o);
		((Control)this).Controls.Add((Control)(object)n);
		((Control)this).Controls.Add((Control)(object)l);
		((Control)this).Controls.Add((Control)(object)m);
		((Control)this).Controls.Add((Control)(object)j);
		((Control)this).Controls.Add((Control)(object)k);
		((Control)this).Controls.Add((Control)(object)i);
		((Control)this).Controls.Add((Control)(object)this.m_h);
		((Control)this).Controls.Add((Control)(object)this.m_g);
		((Control)this).Controls.Add((Control)(object)this.m_f);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmTchClass";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Control)this).Text = "معلم-صنف-درس";
		((Form)this).Load += h;
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
