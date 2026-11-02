using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbz : Form
{
	public string __field_a = "";

	private IContainer m_b = null;

	private OpenFileDialog m_c;

	private UIButton m_d;

	private UIComboBox m_e;

	private Label m_f;

	private UIComboBox m_g;

	private Label m_h;

	private UIComboBox m_i;

	private Label j;

	private Label k;

	private UIComboBox l;

	private Label m;

	private UIComboBox n;

	private Label o;

	private UIGroupBox p;

	private UIGroupBox q;

	private GridEX r;

	private GridEX s;

	private UIButton t;

	private Label u;

	private Label v;

	private Label w;

	private MaskedEditBox x;

	public asdbz()
	{
		a();
	}

	private void i(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 4:
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
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 3;
				case 3:
					v.Text = asdaj.__field_a;
					e();
					l.SelectedIndex = 1;
					r.Focus();
					num = 5;
					continue;
				case 5:
					return;
				case 7:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void i()
	{
		try
		{
			bool flag = default;
			while (true)
			{
				IL_0022:
				r.RootTable.Columns["xTakhfif"].HasValueList = true;
				GridEXValueListItemCollection valueList = r.RootTable.Columns["xTakhfif"].ValueList;
				valueList.Clear();
				DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from ttakhfif order by name");
				int num = 0;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 3:
						flag = num < dataTable.Rows.Count;
						num2 = 0;
						continue;
					case 0:
						if (flag)
						{
							valueList.Add(new GridEXValueListItem(dataTable.Rows[num]["id"].ToString(), dataTable.Rows[num]["name"].ToString()));
							num++;
							num2 = 3;
						}
						else
						{
							num2 = 4;
						}
						continue;
					case 4:
						num2 = 1;
						continue;
					case 1:
						goto end_IL_0005;
					}
					goto IL_0022;
					continue;
					end_IL_0005:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void h()
	{
		while (true)
		{
			r.DataSource = null;
			bool flag = n.SelectedIndex >= 0;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					string text = " tYear_Student.xStudent not in(select xstudent from tYear_Student where xyear=" + v.Text + ") ";
					text = text + " and tYear_Student.xyear=" + l.SelectedValue.ToString();
					text = text + " and tYear_Student.xClass=" + n.SelectedValue.ToString();
					text = " where " + text;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName,tYear_Student.sort,\r\n                        tYear_Student.shaghe, tYear_Student.hazer,tYear_Student.codeTakhfif, tYear_Student.mali,cast(0 as bit) as dakhle ,cast(0 as bit) as uniform ,cast(0 as bit) as komakdarsi ,cast(0 as bit) as transport  ,cast(0 as bit) as robotic  ,\r\n                         cast(0 as bit) as maghnae  ,cast(0 as bit) as maghnae  ,cast(0 as bit) as ketab,0 as xTakhfif,null as Fee1,null as transport1\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent " + text);
					r.DataSource = dataSource;
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(r.RootTable.Columns["Selector"], ConditionOperator.Equal, true);
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(128, 255, 128);
					r.RootTable.FormatConditions.Add(gridEXFormatCondition);
					b();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 1:
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void g()
	{
		while (true)
		{
			s.DataSource = null;
			bool flag = this.m_i.SelectedIndex >= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 3;
						continue;
					}
					string text = "";
					text = text + " tYear_Student.xyear=" + v.Text;
					text = text + " and tYear_Student.xClass=" + this.m_i.SelectedValue.ToString();
					text = " where " + text;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName,tYear_Student.sort\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent " + text);
					s.DataSource = dataSource;
					num = 2;
					continue;
				}
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 3:
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void f()
	{
		while (true)
		{
			r.DataSource = null;
			bool flag = l.SelectedIndex < 0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
						continue;
					}
					return;
				case 0:
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					this.m_g.SelectedIndex = 0;
					num = 0;
					continue;
				case 5:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + l.SelectedValue.ToString() + ") and id in(" + asdaj.n + ")  order by id");
					this.m_g.DataSource = dataSource;
					this.m_g.DisplayMember = "Name";
					this.m_g.ValueMember = "id";
					flag = this.m_g.Items.Count <= 0;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}

	private void e()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") order by id");
		this.m_e.DataSource = dataSource;
		this.m_e.DisplayMember = "Name";
		this.m_e.ValueMember = "id";
	}

	private void h(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void g(object A_0, EventArgs A_1)
	{
		d();
		try
		{
			int num = int.Parse(this.m_g.SelectedValue.ToString());
			num++;
			this.m_e.SelectedValue = num;
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void d()
	{
		while (true)
		{
			r.DataSource = null;
			bool flag = this.m_g.SelectedIndex < 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					n.DataSource = null;
					num = 5;
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					return;
				case 3:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xyear=" + l.SelectedValue.ToString() + " and xPaye=" + this.m_g.SelectedValue.ToString());
					n.DataSource = dataSource;
					n.DisplayMember = "Name";
					n.ValueMember = "id";
					flag = n.Items.Count <= 0;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 2;
				case 6:
					if (true)
					{
					}
					n.SelectedIndex = 0;
					num = 2;
					continue;
				case 5:
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
			s.DataSource = null;
			bool flag = this.m_e.SelectedIndex < 0;
			int num = 0;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					this.m_i.DataSource = null;
					num = 5;
					continue;
				case 1:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					this.m_i.SelectedIndex = 0;
					num = 1;
					continue;
				case 6:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xyear=" + v.Text + " and xPaye=" + this.m_e.SelectedValue.ToString());
					this.m_i.DataSource = dataSource;
					this.m_i.DisplayMember = "Name";
					this.m_i.ValueMember = "id";
					flag = this.m_i.Items.Count <= 0;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		f();
	}

	private void e(object A_0, EventArgs A_1)
	{
		h();
	}

	private void d(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c(object A_0, EventArgs A_1)
	{
		g();
		try
		{
			if (true)
			{
			}
			x.Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_i.SelectedValue.ToString()).ToString();
		}
		catch
		{
			x.Text = "";
		}
		b();
	}

	private void b(object A_0, EventArgs A_1)
	{
		int num3 = default;
		int num2 = default;
		SqlCommand sqlCommand = default;
		SqlConnection sqlConnection = default;
		while (true)
		{
			bool flag = this.m_i.SelectedIndex >= 0;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
				{
					if (!flag)
					{
						num = 24;
						continue;
					}
					num3 = 0;
					int num4 = 0;
					num2 = 0;
					num = 27;
					continue;
				}
				case 33:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 45;
				case 26:
					flag = num3 != 0;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 20;
						continue;
					}
					flag = MessageBox.Show("تعداد شاگردان انتخابی  : " + num3 + " نفر\n-  صنف سال جدید : " + this.m_i.SelectedItem.Text + "\nانتخاب شده آیا از انتقال مطمئن هستيد؟", "انتقال", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
					num = 30;
					continue;
				case 10:
				case 41:
					sqlCommand.Parameters.AddWithValue("@Fee1", r.GetRow(num2).Cells["Fee1"].Value.ToString());
					flag = !(r.GetRow(num2).Cells["transport1"].Value.ToString() == "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 14;
						continue;
					}
					sqlCommand.Parameters.AddWithValue("@transport1", r.GetRow(num2).Cells["transport1"].Value.ToString());
					if (true)
					{
					}
					num = 16;
					continue;
				case 5:
					r.Row = num2;
					r.CurrentColumn = r.GetRow(num2).Cells["fee1"].Column;
					r.Select();
					r.SelectCurrentCellText();
					MessageBox.Show("مبلغ فیس را وارد کنید");
					num = 0;
					continue;
				case 0:
					return;
				case 45:
					num2++;
					num = 3;
					continue;
				case 23:
				case 27:
					flag = num2 < r.RowCount;
					num = 35;
					continue;
				case 35:
					if (!flag)
					{
						num = 26;
						continue;
					}
					flag = !(r.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
					num = 40;
					continue;
				case 25:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 19;
				case 2:
					sqlConnection.Close();
					h();
					g();
					num = 29;
					continue;
				case 29:
					return;
				case 12:
					try
					{
						int.Parse(r.GetRow(num2).Cells["transport1"].Value.ToString());
					}
					catch
					{
						r.Row = num2;
						r.CurrentColumn = r.GetRow(num2).Cells["transport1"].Column;
						r.Select();
						r.SelectCurrentCellText();
						MessageBox.Show("مبلغ ترانسپورت را فقط عدد وارد کنید");
						return;
					}
					num = 36;
					continue;
				case 24:
					MessageBox.Show("صنف سال جدید را انتخاب کنید");
					this.m_i.Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 31:
				{
					int num4;
					try
					{
						num4 = int.Parse(r.GetRow(num2).Cells["fee1"].Value.ToString());
					}
					catch
					{
						r.Row = num2;
						r.CurrentColumn = r.GetRow(num2).Cells["fee1"].Column;
						r.Select();
						r.SelectCurrentCellText();
						MessageBox.Show("مبلغ فیس را فقط عدد وارد کنید");
						return;
					}
					flag = !(num4.ToString() != x.Text);
					num = 25;
					continue;
				}
				case 21:
					r.Row = num2;
					r.CurrentColumn = r.GetRow(num2).Cells["xTakhfif"].Column;
					r.Select();
					r.SelectCurrentCellText();
					MessageBox.Show("مبلغ فیس این دانش آموز با فیس صنف  متفاوت هست\nباید برای این انش آموز نوع تخفیف را مشخص کنید");
					num = 42;
					continue;
				case 42:
					return;
				case 14:
					sqlCommand.Parameters.AddWithValue("@transport1", DBNull.Value);
					num = 4;
					continue;
				case 44:
					sqlCommand.Parameters.AddWithValue("@codeTakhfif", DBNull.Value);
					num = 10;
					continue;
				case 39:
					num = 12;
					continue;
				case 30:
					if (flag)
					{
						sqlCommand = null;
						sqlConnection = new SqlConnection(asdab.e());
						sqlConnection.Open();
						num2 = 0;
						num = 18;
					}
					else
					{
						num = 38;
					}
					continue;
				case 15:
					flag = !(r.GetRow(num2).Cells["xTakhfif"].Value.ToString() == "0");
					num = 32;
					continue;
				case 32:
					num = ((!flag) ? 21 : 19);
					continue;
				case 19:
					flag = !(r.GetRow(num2).Cells["transport1"].Value.ToString() != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 36;
				case 8:
					num3++;
					flag = !(r.GetRow(num2).Cells["fee1"].Value.ToString() == "");
					num = 17;
					continue;
				case 17:
					num = ((!flag) ? 5 : 31);
					continue;
				case 20:
					MessageBox.Show("شاگردی انتخاب نشده است");
					r.Focus();
					num = 34;
					continue;
				case 34:
					return;
				case 38:
					num = 28;
					continue;
				case 28:
					return;
				case 36:
					num = 43;
					continue;
				case 4:
				case 16:
					sqlCommand.Parameters.AddWithValue("@shaghe", r.GetRow(num2).Cells["shaghe"].Value);
					sqlCommand.Parameters.AddWithValue("@hazer", r.GetRow(num2).Cells["hazer"].Value);
					sqlCommand.Parameters.AddWithValue("@mali", r.GetRow(num2).Cells["mali"].Value);
					sqlCommand.Parameters.AddWithValue("@dakhle", r.GetRow(num2).Cells["dakhle"].Value);
					sqlCommand.Parameters.AddWithValue("@uniform", r.GetRow(num2).Cells["uniform"].Value);
					sqlCommand.Parameters.AddWithValue("@komakdarsi", r.GetRow(num2).Cells["komakdarsi"].Value);
					sqlCommand.Parameters.AddWithValue("@ketab", r.GetRow(num2).Cells["ketab"].Value);
					sqlCommand.Parameters.AddWithValue("@transport", r.GetRow(num2).Cells["transport"].Value);
					sqlCommand.Parameters.AddWithValue("@robotic", r.GetRow(num2).Cells["robotic"].Value);
					sqlCommand.Parameters.AddWithValue("@maghnae", r.GetRow(num2).Cells["maghnae"].Value);
					sqlCommand.ExecuteNonQuery();
					num = 45;
					continue;
				case 43:
					num2++;
					num = 23;
					continue;
				case 3:
				case 18:
					flag = num2 < r.RowCount;
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						flag = !(r.GetRow(num2).Cells["Selector"].Value.ToString() == "True");
						num = 33;
					}
					else
					{
						num = 2;
					}
					continue;
				case 40:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 43;
				case 22:
					sqlCommand = new SqlCommand("sp_tYear_Student_Insert", sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xYear", v.Text);
					sqlCommand.Parameters.AddWithValue("@xStudent", r.GetRow(num2).Cells["id"].Value.ToString());
					sqlCommand.Parameters.AddWithValue("@xPaye", this.m_e.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xClass", this.m_i.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xTakhfif", r.GetRow(num2).Cells["xTakhfif"].Value.ToString());
					flag = !(r.GetRow(num2).Cells["codeTakhfif"].Value.ToString() == "");
					num = 37;
					continue;
				case 37:
					if (flag)
					{
						sqlCommand.Parameters.AddWithValue("@codeTakhfif", r.GetRow(num2).Cells["codeTakhfif"].Value.ToString());
						num = 41;
					}
					else
					{
						num = 44;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		i();
	}

	private void b()
	{
		int num2 = default;
		while (true)
		{
			bool flag = !(x.Text == "");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					num2 = 0;
					num = 4;
					continue;
				case 8:
					num2++;
					num = 2;
					continue;
				case 9:
					if (!flag)
					{
						if (true)
						{
						}
						num = 7;
						continue;
					}
					goto case 8;
				case 1:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
				case 4:
					flag = num2 < r.RowCount;
					num = 0;
					continue;
				case 0:
					if (flag)
					{
						flag = !(r.GetRow(num2).Cells["xTakhfif"].Value.ToString() == "0");
						num = 9;
					}
					else
					{
						num = 5;
					}
					continue;
				case 5:
					return;
				case 7:
					r.GetRow(num2).BeginEdit();
					r.GetRow(num2).Cells["fee1"].Value = x.Text;
					r.GetRow(num2).EndEdit();
					num = 8;
					continue;
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
			int num = 4;
			while (true)
			{
				if (true)
				{
				}
				int num2;
				switch (num)
				{
				case 4:
					num = (A_0 ? 6 : 0);
					continue;
				case 6:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_b.Dispose();
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 3;
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
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbz));
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat4 = new StringFormat();
		StringFormat stringFormat5 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		this.m_c = new OpenFileDialog();
		this.m_e = new UIComboBox();
		this.m_f = new Label();
		this.m_d = new UIButton();
		this.m_g = new UIComboBox();
		this.m_h = new Label();
		this.m_i = new UIComboBox();
		j = new Label();
		k = new Label();
		l = new UIComboBox();
		m = new Label();
		n = new UIComboBox();
		o = new Label();
		p = new UIGroupBox();
		r = new GridEX();
		q = new UIGroupBox();
		w = new Label();
		x = new MaskedEditBox();
		v = new Label();
		u = new Label();
		s = new GridEX();
		t = new UIButton();
		((ISupportInitialize)p).BeginInit();
		p.SuspendLayout();
		((ISupportInitialize)r).BeginInit();
		((ISupportInitialize)q).BeginInit();
		q.SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		SuspendLayout();
		this.m_c.FileName = "openFileDialog1";
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_e.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.Location = new Point(490, 55);
		this.m_e.Name = "comboPayeNew";
		this.m_e.Size = new Size(144, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_e.StringFormat = stringFormat;
		this.m_e.TabIndex = 55;
		this.m_e.SelectedIndexChanged += d;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.AutoSize = true;
		this.m_f.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(640, 59);
		this.m_f.Name = "label6";
		this.m_f.Size = new Size(87, 16);
		this.m_f.TabIndex = 56;
		this.m_f.Text = "پایه سال جدید";
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnAcpstdGroup.Image");
		this.m_d.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_d.Location = new Point(502, 114);
		this.m_d.Name = "btnAcpstdGroup";
		this.m_d.Size = new Size(132, 58);
		this.m_d.TabIndex = 1;
		this.m_d.Text = "انتقال موارد انتخابی به صنف جدید";
		this.m_d.Click += b;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_g.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(344, 21);
		this.m_g.Name = "comboPayeSearch";
		this.m_g.Size = new Size(116, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		this.m_g.StringFormat = stringFormat2;
		this.m_g.TabIndex = 76;
		this.m_g.SelectedIndexChanged += g;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.AutoSize = true;
		this.m_h.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(636, 28);
		this.m_h.Name = "label7";
		this.m_h.Size = new Size(120, 16);
		this.m_h.TabIndex = 77;
		this.m_h.Text = "سال تعلیمی گذشته";
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_i.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_i.Location = new Point(490, 85);
		this.m_i.Name = "comboClsNew";
		this.m_i.Size = new Size(144, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		this.m_i.StringFormat = stringFormat3;
		this.m_i.TabIndex = 78;
		this.m_i.SelectedIndexChanged += c;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.AutoSize = true;
		j.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Location = new Point(642, 90);
		j.Name = "label19";
		j.Size = new Size(88, 14);
		j.TabIndex = 79;
		j.Text = "صنف سال جدید";
		k.AutoSize = true;
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(304, 6);
		k.Name = "label1";
		k.Size = new Size(209, 16);
		k.TabIndex = 80;
		k.Text = "انتقال شاگردان به سال تعلیمی جدید";
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		l.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "1402";
		uIComboBoxItem.Value = "1402";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "1401";
		uIComboBoxItem2.Value = "1401";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "1400";
		uIComboBoxItem3.Value = "1400";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "1399";
		uIComboBoxItem4.Value = "1399";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1398";
		uIComboBoxItem5.Value = "1398";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1402";
		uIComboBoxItem6.Value = "1402";
		l.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		l.Location = new Point(530, 24);
		l.Name = "dropYear";
		l.Size = new Size(97, 23);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		l.StringFormat = stringFormat4;
		l.TabIndex = 131;
		l.SelectedIndexChanged += f;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.AutoSize = true;
		m.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Location = new Point(467, 25);
		m.Name = "label2";
		m.Size = new Size(27, 16);
		m.TabIndex = 132;
		m.Text = "پایه";
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		n.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		n.Location = new Point(19, 21);
		n.Name = "dropClassSearch";
		n.Size = new Size(165, 23);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		n.StringFormat = stringFormat5;
		n.TabIndex = 133;
		n.SelectedIndexChanged += e;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		o.AutoSize = true;
		o.Location = new Point(192, 25);
		o.Name = "label3";
		o.Size = new Size(99, 14);
		o.TabIndex = 134;
		o.Text = "صنف سال گذشته";
		p.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		p.Controls.Add(r);
		p.Controls.Add(l);
		p.Controls.Add(this.m_h);
		p.Controls.Add(n);
		p.Controls.Add(this.m_g);
		p.Controls.Add(o);
		p.Controls.Add(m);
		p.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.Location = new Point(2, 33);
		p.Name = "uiGroupBox1";
		p.Size = new Size(767, 439);
		p.TabIndex = 135;
		p.Text = "اطلاعات سال تعلیمی گذشته";
		r.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		r.DesignTimeLayout = gridEXLayout;
		r.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		r.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		r.Font = new Font("Tahoma", 9.75f);
		r.GroupByBoxVisible = false;
		r.Location = new Point(8, 53);
		r.Name = "gridEX1";
		r.RecordNavigator = true;
		r.RowHeaders = InheritableBoolean.True;
		r.Size = new Size(751, 371);
		r.TabIndex = 135;
		r.VisualStyle = VisualStyle.Office2003;
		r.LayoutLoad += a;
		q.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		q.Controls.Add(w);
		q.Controls.Add(x);
		q.Controls.Add(v);
		q.Controls.Add(u);
		q.Controls.Add(s);
		q.Controls.Add(this.m_e);
		q.Controls.Add(this.m_f);
		q.Controls.Add(j);
		q.Controls.Add(this.m_d);
		q.Controls.Add(this.m_i);
		q.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Location = new Point(2, 478);
		q.Name = "uiGroupBox2";
		q.Size = new Size(767, 180);
		q.TabIndex = 136;
		q.Text = "صنف سال جدید";
		w.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		w.AutoSize = true;
		w.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.Location = new Point(695, 130);
		w.Name = "label5";
		w.Size = new Size(60, 14);
		w.TabIndex = 140;
		w.Text = "فیس صنف";
		x.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x.AutoScroll = false;
		x.AutoScrollMargin = new Size(0, 0);
		x.AutoScrollMinSize = new Size(0, 0);
		x.AutoScrollPosition = new Point(0, 0);
		x.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Enabled = false;
		x.Location = new Point(680, 150);
		x.MaxLength = 10;
		x.Name = "txtFeeClass";
		x.Numeric = true;
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(76, 22);
		x.TabIndex = 139;
		x.Tag = "";
		x.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		v.Location = new Point(579, 19);
		v.Name = "lYear";
		v.Size = new Size(55, 24);
		v.TabIndex = 138;
		v.TextAlign = ContentAlignment.MiddleCenter;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.AutoSize = true;
		u.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		u.Location = new Point(643, 23);
		u.Name = "label4";
		u.Size = new Size(111, 16);
		u.TabIndex = 137;
		u.Text = "سال تعلیمی جاری";
		s.AllowEdit = InheritableBoolean.False;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		s.DesignTimeLayout = gridEXLayout2;
		s.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		s.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s.GroupByBoxVisible = false;
		s.Location = new Point(10, 13);
		s.Name = "gridEX2";
		s.RecordNavigator = true;
		s.RowHeaders = InheritableBoolean.True;
		s.Size = new Size(450, 159);
		s.TabIndex = 136;
		s.VisualStyle = VisualStyle.Office2003;
		t.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		t.ImageSize = new Size(20, 20);
		t.Location = new Point(5, 4);
		t.Name = "btnClose";
		t.Size = new Size(83, 28);
		t.TabIndex = 137;
		t.Text = "بستن";
		t.Click += h;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(770, 662);
		Controls.Add(t);
		Controls.Add(q);
		Controls.Add(p);
		Controls.Add(k);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		Name = "frmYear_Student";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "انتقال به پایه بالاتر";
		Load += i;
		((ISupportInitialize)p).EndInit();
		p.ResumeLayout(performLayout: false);
		p.PerformLayout();
		((ISupportInitialize)r).EndInit();
		((ISupportInitialize)q).EndInit();
		q.ResumeLayout(performLayout: false);
		q.PerformLayout();
		((ISupportInitialize)s).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
