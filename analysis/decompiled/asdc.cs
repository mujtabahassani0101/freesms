using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdc : Form
{
	private string m_a;

	private IContainer m_b = null;

	private GridEX m_c;

	private Panel m_d;

	private Panel m_e;

	private UIButton m_f;

	private UIButton m_g;

	private UIButton m_h;

	private Panel i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private EditBox m;

	private UIButton n;

	private Label o;

	private Panel p;

	private Label q;

	private UIComboBox r;

	private UIButton s;

	private PrintPreviewDialog t;

	private GridEXPrintDocument u;

	private Label v;

	private EditBox w;

	private Label x;

	private Panel y;

	private Label z;

	private UIComboBox aa;

	private EditBox ab;

	private Label ac;

	private EditBox ad;

	private Label ae;

	private Label af;

	public asdc()
	{
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 1;
					continue;
				case 6:
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
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 2:
					((Control)af).Text = asdaj.a;
					c();
					b();
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 7;
					continue;
				case 7:
					return;
				case 5:
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
		r.DataSource = dataSource;
		r.DisplayMember = "Name";
		r.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tClass.id, tClass.name, tPaye.Name AS Paye, tClass.xpaye, tClass.answerable,\r\n            tClass.fee, tClass.shift, tClass.sortRpt, case tClass.shift when 1 then N'صبح' when 2 then N'عصر' end as shifttext\r\n           FROM         tClass INNER JOIN\r\n                      tPaye ON tClass.xpaye = tPaye.id where xYear=" + ((Control)af).Text);
		this.m_c.DataSource = dataSource;
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a = "insert";
		((Control)r).Enabled = true;
		((Control)y).Visible = true;
		((Control)m).Text = "";
		((Control)m).Focus();
	}

	private void f(object A_0, EventArgs A_1)
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
						num = 1;
						continue;
					}
					return;
				case 1:
					this.m_a = "update";
					((Control)r).Enabled = false;
					((Control)y).Visible = true;
					((Control)m).Text = this.m_c.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
					((Control)w).Text = this.m_c.SelectedItems[0].GetRow().Cells["Answerable"].Value.ToString();
					((Control)ad).Text = this.m_c.SelectedItems[0].GetRow().Cells["Fee"].Value.ToString();
					((Control)ab).Text = this.m_c.SelectedItems[0].GetRow().Cells["SortRpt"].Value.ToString();
					r.SelectedValue = this.m_c.SelectedItems[0].GetRow().Cells["xpaye"].Value.ToString();
					aa.SelectedValue = this.m_c.SelectedItems[0].GetRow().Cells["Shift"].Value.ToString();
					((Control)m).Select();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		SqlParameter[] array = default;
		string a_ = default;
		int num2 = default;
		while (true)
		{
			bool flag = r.SelectedIndex >= 0;
			int num = 18;
			while (true)
			{
				switch (num)
				{
				case 18:
					if (!flag)
					{
						num = 25;
						continue;
					}
					flag = !(((Control)m).Text.Trim() == "");
					num = 27;
					continue;
				case 13:
					array = new SqlParameter[9]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.Int, a_),
						asdcb.a("@xYear", SqlDbType.Int, ((Control)af).Text),
						asdcb.a("@xpaye", SqlDbType.Int, r.SelectedValue.ToString()),
						asdcb.a("@name", SqlDbType.NVarChar, asdaj.b(((Control)m).Text)),
						asdcb.a("@answerable", SqlDbType.NVarChar, asdaj.b(((Control)w).Text)),
						asdcb.a("@fee", SqlDbType.NVarChar, asdaj.b(((Control)ad).Text)),
						asdcb.a("@shift", SqlDbType.SmallInt, aa.SelectedValue.ToString()),
						asdcb.a("@sortRpt", SqlDbType.Int, ((Control)ab).Text)
					};
					num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tClass_insertUpdate", array);
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "-100");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 15;
						continue;
					}
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "-200");
					num = 16;
					continue;
				case 28:
					if (!flag)
					{
						num = 32;
						continue;
					}
					a_ = "0";
					flag = !(this.m_a == "update");
					num = 22;
					continue;
				case 5:
					MessageBox.Show("نگران را وارد کنید");
					((Control)w).Focus();
					num = 29;
					continue;
				case 29:
					return;
				case 6:
					MessageBox.Show("شماره تکراری است");
					((EditBase)ab).SelectAll();
					num = 30;
					continue;
				case 30:
					return;
				case 3:
					MessageBox.Show("عنوان صنف را وارد کنید");
					((Control)m).Focus();
					num = 12;
					continue;
				case 12:
					return;
				case 11:
					a_ = this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					if (true)
					{
					}
					num = 13;
					continue;
				case 24:
					((Control)y).Visible = false;
					num = 26;
					continue;
				case 21:
					MessageBox.Show("مبلغ را وارد کنید");
					((Control)ad).Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 23:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 26:
					b();
					((Control)m).Text = "";
					((Control)w).Text = "";
					((Control)ab).Text = "";
					num = 14;
					continue;
				case 14:
					return;
				case 31:
					if (!flag)
					{
						num = 2;
						continue;
					}
					try
					{
						int num4 = int.Parse(((Control)ab).Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای شماره فقط عدد وارد کنید");
						((Control)ab).Focus();
						return;
					}
					flag = aa.SelectedIndex >= 0;
					num = 28;
					continue;
				case 25:
					MessageBox.Show("نوع را انتخاب کنید");
					((UIComboBase)r).Focus();
					num = 9;
					continue;
				case 9:
					return;
				case 20:
					if (!flag)
					{
						num = 21;
						continue;
					}
					try
					{
						int num3 = int.Parse(((Control)ad).Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای مبلغ فقط عدد وارد کنید");
						((Control)ad).Focus();
						return;
					}
					flag = !(((Control)ab).Text.Trim() == "");
					num = 31;
					continue;
				case 19:
					if (flag)
					{
						flag = !(((Control)ad).Text.Trim() == "");
						num = 20;
					}
					else
					{
						num = 5;
					}
					continue;
				case 7:
					flag = !(this.m_a == "update");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 26;
				case 15:
					MessageBox.Show("عنوان صنف تکراری است");
					((EditBase)m).SelectAll();
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					MessageBox.Show("شماره را وارد کنید");
					((Control)ab).Focus();
					num = 10;
					continue;
				case 10:
					return;
				case 22:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 13;
				case 27:
					if (flag)
					{
						flag = !(((Control)w).Text.Trim() == "");
						num = 19;
					}
					else
					{
						num = 3;
					}
					continue;
				case 16:
					if (flag)
					{
						flag = num2 <= 0;
						num = 23;
					}
					else
					{
						num = 6;
					}
					continue;
				case 32:
					MessageBox.Show("شیفت را انتخاب کنید");
					((UIComboBase)aa).Focus();
					num = 8;
					continue;
				case 8:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)y).Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num = ((this.m_c.RowCount <= 0) ? 11 : 5);
					continue;
				case 10:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 9:
					MessageBox.Show("تعداد " + text + " شاگرد در این صنف وجود دارد.امکان حذف وجود ندارد");
					num = 12;
					continue;
				case 12:
					return;
				case 11:
					num2 = 1;
					goto IL_0211;
				case 0:
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					num = 3;
					continue;
				case 3:
					if (true)
					{
					}
					num2 = (((int)this.m_c.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_0211;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tclass where id=" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					b();
					num = 0;
					continue;
				case 8:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tYear_Student WHERE xClass =" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						flag = (int)MessageBox.Show("آيا از حذف صنف مطمئن هستيد؟", "حذف صنف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 10;
					}
					else
					{
						num = 9;
					}
					continue;
				case 4:
					{
						if (!flag)
						{
							num = 8;
							continue;
						}
						return;
					}
					IL_0211:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		Rectangle bounds = ((Control)this).Bounds;
		((Form)t).SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
		t.UseAntiAlias = true;
		((Form)t).ShowDialog((IWin32Window)(object)this);
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					num = ((!A_0) ? 3 : 4);
					continue;
				case 4:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 5:
					if (true)
					{
					}
					this.m_b.Dispose();
					num = 2;
					continue;
				case 3:
					num2 = 1;
					goto IL_0074;
				case 2:
					{
						((Form)this).Dispose(A_0);
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
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected Obj, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected Obj, but got Unknown
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected Obj, but got Unknown
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected Obj, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Expected Obj, but got Unknown
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected Obj, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Expected Obj, but got Unknown
		//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ea: Expected Obj, but got Unknown
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Expected Obj, but got Unknown
		//IL_11c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d2: Expected Obj, but got Unknown
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Expected Obj, but got Unknown
		//IL_1309: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Expected Obj, but got Unknown
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a2: Expected Obj, but got Unknown
		//IL_1508: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdc));
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		StringFormat val4 = new StringFormat();
		StringFormat val5 = new StringFormat();
		this.m_c = new GridEX();
		this.m_d = new Panel();
		af = new Label();
		ae = new Label();
		y = new Panel();
		i = new Panel();
		z = new Label();
		aa = new UIComboBox();
		ab = new EditBox();
		ac = new Label();
		ad = new EditBox();
		x = new Label();
		v = new Label();
		w = new EditBox();
		q = new Label();
		r = new UIComboBox();
		n = new UIButton();
		k = new UIButton();
		l = new Label();
		m = new EditBox();
		o = new Label();
		this.m_e = new Panel();
		s = new UIButton();
		this.m_f = new UIButton();
		j = new UIButton();
		this.m_g = new UIButton();
		this.m_h = new UIButton();
		p = new Panel();
		t = new PrintPreviewDialog();
		u = new GridEXPrintDocument();
		((ISupportInitialize)this.m_c).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((Control)y).SuspendLayout();
		((Control)i).SuspendLayout();
		((Control)this.m_e).SuspendLayout();
		((Control)p).SuspendLayout();
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
		((Control)this.m_c).Size = new Size(630, 471);
		((Control)this.m_c).TabIndex = 5;
		((ScrollableBase)this.m_c).VisualStyle = (VisualStyle)2;
		((Control)this.m_d).BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.BorderStyle = (BorderStyle)1;
		((Control)this.m_d).Controls.Add((Control)(object)af);
		((Control)this.m_d).Controls.Add((Control)(object)ae);
		((Control)this.m_d).Controls.Add((Control)(object)y);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(5, 6);
		((Control)this.m_d).Name = "panel1";
		((Control)this.m_d).Size = new Size(648, 632);
		((Control)this.m_d).TabIndex = 0;
		af.BorderStyle = (BorderStyle)1;
		((Control)af).Location = new Point(34, 31);
		((Control)af).Name = "lYear";
		((Control)af).Size = new Size(68, 24);
		((Control)af).TabIndex = 120;
		af.TextAlign = (ContentAlignment)32;
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(107, 29);
		((Control)ae).Name = "label7";
		((Control)ae).Size = new Size(78, 26);
		((Control)ae).TabIndex = 99;
		((Control)ae).Text = "سال تعلیمی";
		((Control)y).BackColor = SystemColors.ControlText;
		((Control)y).Controls.Add((Control)(object)i);
		((Control)y).Location = new Point(149, 181);
		((Control)y).Name = "pcls";
		((Control)y).Size = new Size(320, 323);
		((Control)y).TabIndex = 97;
		((Control)y).Visible = false;
		((Control)i).BackColor = SystemColors.GradientInactiveCaption;
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Controls.Add((Control)(object)z);
		((Control)i).Controls.Add((Control)(object)aa);
		((Control)i).Controls.Add((Control)(object)ab);
		((Control)i).Controls.Add((Control)(object)ac);
		((Control)i).Controls.Add((Control)(object)ad);
		((Control)i).Controls.Add((Control)(object)x);
		((Control)i).Controls.Add((Control)(object)v);
		((Control)i).Controls.Add((Control)(object)w);
		((Control)i).Controls.Add((Control)(object)q);
		((Control)i).Controls.Add((Control)(object)r);
		((Control)i).Controls.Add((Control)(object)n);
		((Control)i).Controls.Add((Control)(object)k);
		((Control)i).Controls.Add((Control)(object)l);
		((Control)i).Controls.Add((Control)(object)m);
		((Control)i).Location = new Point(3, 3);
		((Control)i).Name = "pcls00";
		((Control)i).Size = new Size(314, 317);
		((Control)i).TabIndex = 10;
		((Control)z).AutoSize = true;
		((Control)z).Location = new Point(213, 214);
		((Control)z).Name = "label6";
		((Control)z).Size = new Size(47, 26);
		((Control)z).TabIndex = 96;
		((Control)z).Text = "شیفت";
		((UIComboBase)aa).ComboStyle = (ComboStyle)1;
		((UIComboBase)aa).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)aa).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "صبح";
		val2.Value = "1";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "عصر";
		val3.Value = "2";
		aa.Items.AddRange(new UIComboBoxItem[2] { val2, val3 });
		((Control)aa).Location = new Point(88, 210);
		((Control)aa).Name = "dropShift";
		((Control)aa).Size = new Size(119, 33);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)aa).StringFormat = val4;
		((Control)aa).TabIndex = 5;
		((EditBase)ab).AutoScroll = false;
		((EditBase)ab).AutoScrollMargin = new Size(0, 0);
		((EditBase)ab).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ab).AutoScrollPosition = new Point(0, 0);
		((Control)ab).Location = new Point(88, 173);
		((Control)ab).Name = "txtSortRpt";
		((Control)ab).Size = new Size(119, 33);
		((Control)ab).TabIndex = 4;
		((EditBase)ab).TextAlignment = (TextAlignment)1;
		((Control)ac).AutoSize = true;
		((Control)ac).Location = new Point(211, 177);
		((Control)ac).Name = "label5";
		((Control)ac).Size = new Size(46, 26);
		((Control)ac).TabIndex = 93;
		((Control)ac).Text = "شماره";
		((EditBase)ad).AutoScroll = false;
		((EditBase)ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ad).AutoScrollPosition = new Point(0, 0);
		((Control)ad).Location = new Point(88, 136);
		((Control)ad).Name = "txtFee";
		((Control)ad).Size = new Size(119, 33);
		((Control)ad).TabIndex = 3;
		((EditBase)ad).TextAlignment = (TextAlignment)1;
		((Control)x).AutoSize = true;
		((Control)x).Location = new Point(211, 140);
		((Control)x).Name = "label3";
		((Control)x).Size = new Size(69, 26);
		((Control)x).TabIndex = 41;
		((Control)x).Text = "مبلغ فیس";
		((Control)v).AutoSize = true;
		((Control)v).Location = new Point(211, 103);
		((Control)v).Name = "label2";
		((Control)v).Size = new Size(43, 26);
		((Control)v).TabIndex = 39;
		((Control)v).Text = "نگران";
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((Control)w).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(23, 99);
		((Control)w).Name = "txtAnswerable";
		((Control)w).Size = new Size(184, 33);
		((Control)w).TabIndex = 2;
		((EditBase)w).TextAlignment = (TextAlignment)1;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(212, 23);
		((Control)q).Name = "label20";
		((Control)q).Size = new Size(31, 26);
		((Control)q).TabIndex = 37;
		((Control)q).Text = "نوع";
		((UIComboBase)r).ComboStyle = (ComboStyle)1;
		((UIComboBase)r).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)r).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(22, 19);
		((Control)r).Name = "dropPaye";
		((Control)r).Size = new Size(184, 33);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)r).StringFormat = val5;
		((Control)r).TabIndex = 0;
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)n).Location = new Point(23, 259);
		((Control)n).Name = "btnCancel";
		((Control)n).Size = new Size(90, 32);
		((Control)n).TabIndex = 7;
		((Control)n).Text = "انصراف";
		((Control)n).Click += c;
		k.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)k).Location = new Point(131, 259);
		((Control)k).Name = "btnAcp";
		((Control)k).Size = new Size(96, 32);
		((Control)k).TabIndex = 6;
		((Control)k).Text = "تایید";
		((Control)k).Click += e;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(211, 66);
		((Control)l).Name = "label1";
		((Control)l).Size = new Size(77, 26);
		((Control)l).TabIndex = 1;
		((Control)l).Text = "عنوان صنف";
		((EditBase)m).AutoScroll = false;
		((EditBase)m).AutoScrollMargin = new Size(0, 0);
		((EditBase)m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)m).AutoScrollPosition = new Point(0, 0);
		((Control)m).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(23, 62);
		((Control)m).Name = "txtNam";
		((Control)m).Size = new Size(184, 33);
		((Control)m).TabIndex = 1;
		((EditBase)m).TextAlignment = (TextAlignment)1;
		((Control)o).AutoSize = true;
		((Control)o).Font = new Font("B Nazanin", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).ForeColor = Color.DarkViolet;
		((Control)o).Location = new Point(445, 14);
		((Control)o).Name = "label4";
		((Control)o).Size = new Size(184, 51);
		((Control)o).TabIndex = 17;
		((Control)o).Text = "مدیریت صنوف";
		((Control)this.m_e).Anchor = (AnchorStyles)14;
		((Control)this.m_e).Controls.Add((Control)(object)s);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Controls.Add((Control)(object)j);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_e).Location = new Point(1, 567);
		((Control)this.m_e).Name = "p_new";
		((Control)this.m_e).Size = new Size(642, 51);
		((Control)this.m_e).TabIndex = 9;
		s.ButtonStyle = (ButtonStyle)1;
		((Control)s).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		s.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		s.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		s.ImageSize = new Size(30, 30);
		((Control)s).Location = new Point(148, 3);
		((Control)s).Name = "btnPrint";
		((Control)s).Size = new Size(117, 40);
		((Control)s).TabIndex = 28;
		((Control)s).Text = "چاپ";
		((Control)s).Visible = false;
		s.VisualStyle = (VisualStyle)1;
		((Control)s).Click += a;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_f).Location = new Point(313, 3);
		((Control)this.m_f).Name = "btnDelete";
		((Control)this.m_f).Size = new Size(107, 42);
		((Control)this.m_f).TabIndex = 2;
		((Control)this.m_f).Text = "حذف";
		((Control)this.m_f).Click += b;
		((Control)j).Anchor = (AnchorStyles)14;
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(40, 40);
		((Control)j).Location = new Point(7, 2);
		((Control)j).Name = "btnClose";
		((Control)j).Size = new Size(134, 43);
		((Control)j).TabIndex = 15;
		((Control)j).Text = "خروج";
		((Control)j).Click += d;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_g).Location = new Point(534, 3);
		((Control)this.m_g).Name = "btnNew";
		((Control)this.m_g).Size = new Size(90, 42);
		((Control)this.m_g).TabIndex = 0;
		((Control)this.m_g).Text = "جدید";
		((Control)this.m_g).Click += g;
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)this.m_h).Location = new Point(431, 3);
		((Control)this.m_h).Name = "btnEdit";
		((Control)this.m_h).Size = new Size(97, 42);
		((Control)this.m_h).TabIndex = 1;
		((Control)this.m_h).Text = "اصلاح";
		((Control)this.m_h).Click += f;
		((Control)p).BackColor = SystemColors.ControlText;
		((Control)p).Controls.Add((Control)(object)this.m_d);
		((Control)p).Dock = (DockStyle)5;
		((Control)p).Location = new Point(0, 0);
		((Control)p).Name = "panel2";
		((Control)p).Size = new Size(657, 643);
		((Control)p).TabIndex = 1;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		((Form)t).ClientSize = new Size(400, 300);
		t.Document = (PrintDocument)(object)u;
		t.Enabled = true;
		t.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)t).Name = "printPreviewDialog1";
		t.Visible = false;
		u.PageFooterLeft = "3";
		u.PageFooterRight = "2";
		u.PageHeaderCenter = "1";
		u.PageHeaderLeft = "4";
		u.PageHeaderRight = "5";
		((Form)this).AcceptButton = (IButtonControl)(object)k;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(657, 643);
		((Control)this).Controls.Add((Control)(object)p);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmCls";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "مدیریت صنوف";
		((Form)this).Load += h;
		((ISupportInitialize)this.m_c).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)y).ResumeLayout(false);
		((Control)i).ResumeLayout(false);
		((Control)i).PerformLayout();
		((Control)this.m_e).ResumeLayout(false);
		((Control)p).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
