using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbz : Form
{
	public string a = "";

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
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)this).BackColor = Color.FromArgb(red, green, blue);
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
					e();
					((Control)v).Text = asdaj.a;
					l.SelectedIndex = 1;
					((Control)r).Focus();
					num = 5;
					continue;
				case 5:
					return;
				case 7:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
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
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		try
		{
			bool flag = default;
			while (true)
			{
				IL_0022:
				r.RootTable.Columns["xTakhfif"].HasValueList = true;
				GridEXValueListItemCollection valueList = r.RootTable.Columns["xTakhfif"].ValueList;
				((CollectionBase)(object)valueList).Clear();
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
							valueList.Add(new GridEXValueListItem((object)dataTable.Rows[num]["id"].ToString(), dataTable.Rows[num]["name"].ToString()));
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
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
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
					string text = " tYear_Student.xStudent not in(select xstudent from tYear_Student where xyear=" + ((Control)v).Text + ") ";
					text = text + " and tYear_Student.xyear=" + l.SelectedValue.ToString();
					text = text + " and tYear_Student.xClass=" + n.SelectedValue.ToString();
					text = " where " + text;
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName,tYear_Student.sort,\r\n                        tYear_Student.shaghe, tYear_Student.hazer,tYear_Student.codeTakhfif, tYear_Student.mali,cast(0 as bit) as dakhle ,cast(0 as bit) as uniform ,cast(0 as bit) as komakdarsi ,cast(0 as bit) as transport  ,cast(0 as bit) as robotic  ,\r\n                         cast(0 as bit) as maghnae  ,cast(0 as bit) as maghnae  ,cast(0 as bit) as ketab,0 as xTakhfif,null as Fee1,null as transport1\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent " + text);
					r.DataSource = dataSource;
					GridEXFormatCondition val = new GridEXFormatCondition(r.RootTable.Columns["Selector"], (ConditionOperator)0, (object)true);
					val.FormatStyle.ForeColor = SystemColors.WindowText;
					val.FormatStyle.BackColor = Color.FromArgb(128, 255, 128);
					r.RootTable.FormatConditions.Add(val);
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
					text = text + " tYear_Student.xyear=" + ((Control)v).Text;
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
					flag = ((CollectionBase)(object)this.m_g.Items).Count <= 0;
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
		((Form)this).Close();
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
					flag = ((CollectionBase)(object)n.Items).Count <= 0;
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
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xyear=" + ((Control)v).Text + " and xPaye=" + this.m_e.SelectedValue.ToString());
					this.m_i.DataSource = dataSource;
					this.m_i.DisplayMember = "Name";
					this.m_i.ValueMember = "id";
					flag = ((CollectionBase)(object)this.m_i.Items).Count <= 0;
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
			((Control)x).Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_i.SelectedValue.ToString()).ToString();
		}
		catch
		{
			((Control)x).Text = "";
		}
		b();
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Invalid comparison between Unknown and I4
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		int num3 = default;
		int num2 = default;
		SqlCommand val = default;
		SqlConnection val2 = default;
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
					flag = (int)MessageBox.Show("تعداد شاگردان انتخابی  : " + num3 + " نفر\n-  صنف سال جدید : " + this.m_i.SelectedItem.Text + "\nانتخاب شده آیا از انتقال مطمئن هستيد؟", "انتقال", (MessageBoxButtons)4, (MessageBoxIcon)48) == 6;
					num = 30;
					continue;
				case 10:
				case 41:
					val.Parameters.AddWithValue("@Fee1", (object)r.GetRow(num2).Cells["Fee1"].Value.ToString());
					flag = !(r.GetRow(num2).Cells["transport1"].Value.ToString() == "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 14;
						continue;
					}
					val.Parameters.AddWithValue("@transport1", (object)r.GetRow(num2).Cells["transport1"].Value.ToString());
					if (true)
					{
					}
					num = 16;
					continue;
				case 5:
					r.Row = num2;
					r.CurrentColumn = r.GetRow(num2).Cells["fee1"].Column;
					((Control)r).Select();
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
					((DbConnection)(object)val2).Close();
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
						((Control)r).Select();
						r.SelectCurrentCellText();
						MessageBox.Show("مبلغ ترانسپورت را فقط عدد وارد کنید");
						return;
					}
					num = 36;
					continue;
				case 24:
					MessageBox.Show("صنف سال جدید را انتخاب کنید");
					((UIComboBase)this.m_i).Focus();
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
						((Control)r).Select();
						r.SelectCurrentCellText();
						MessageBox.Show("مبلغ فیس را فقط عدد وارد کنید");
						return;
					}
					flag = !(num4.ToString() != ((Control)x).Text);
					num = 25;
					continue;
				}
				case 21:
					r.Row = num2;
					r.CurrentColumn = r.GetRow(num2).Cells["xTakhfif"].Column;
					((Control)r).Select();
					r.SelectCurrentCellText();
					MessageBox.Show("مبلغ فیس این دانش آموز با فیس صنف  متفاوت هست\nباید برای این انش آموز نوع تخفیف را مشخص کنید");
					num = 42;
					continue;
				case 42:
					return;
				case 14:
					val.Parameters.AddWithValue("@transport1", (object)DBNull.Value);
					num = 4;
					continue;
				case 44:
					val.Parameters.AddWithValue("@codeTakhfif", (object)DBNull.Value);
					num = 10;
					continue;
				case 39:
					num = 12;
					continue;
				case 30:
					if (flag)
					{
						val = null;
						val2 = new SqlConnection(asdab.e());
						((DbConnection)(object)val2).Open();
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
					((Control)r).Focus();
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
					val.Parameters.AddWithValue("@shaghe", r.GetRow(num2).Cells["shaghe"].Value);
					val.Parameters.AddWithValue("@hazer", r.GetRow(num2).Cells["hazer"].Value);
					val.Parameters.AddWithValue("@mali", r.GetRow(num2).Cells["mali"].Value);
					val.Parameters.AddWithValue("@dakhle", r.GetRow(num2).Cells["dakhle"].Value);
					val.Parameters.AddWithValue("@uniform", r.GetRow(num2).Cells["uniform"].Value);
					val.Parameters.AddWithValue("@komakdarsi", r.GetRow(num2).Cells["komakdarsi"].Value);
					val.Parameters.AddWithValue("@ketab", r.GetRow(num2).Cells["ketab"].Value);
					val.Parameters.AddWithValue("@transport", r.GetRow(num2).Cells["transport"].Value);
					val.Parameters.AddWithValue("@robotic", r.GetRow(num2).Cells["robotic"].Value);
					val.Parameters.AddWithValue("@maghnae", r.GetRow(num2).Cells["maghnae"].Value);
					((DbCommand)(object)val).ExecuteNonQuery();
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
					val = new SqlCommand("sp_tYear_Student_Insert", val2);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@xYear", (object)((Control)v).Text);
					val.Parameters.AddWithValue("@xStudent", (object)r.GetRow(num2).Cells["id"].Value.ToString());
					val.Parameters.AddWithValue("@xPaye", (object)this.m_e.SelectedValue.ToString());
					val.Parameters.AddWithValue("@xClass", (object)this.m_i.SelectedValue.ToString());
					val.Parameters.AddWithValue("@xTakhfif", (object)r.GetRow(num2).Cells["xTakhfif"].Value.ToString());
					flag = !(r.GetRow(num2).Cells["codeTakhfif"].Value.ToString() == "");
					num = 37;
					continue;
				case 37:
					if (flag)
					{
						val.Parameters.AddWithValue("@codeTakhfif", (object)r.GetRow(num2).Cells["codeTakhfif"].Value.ToString());
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
			bool flag = !(((Control)x).Text == "");
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
					r.GetRow(num2).Cells["fee1"].Value = ((Control)x).Text;
					r.GetRow(num2).EndEdit();
					num = 8;
					continue;
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
						((Form)this).Dispose(A_0);
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected Obj, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected Obj, but got Unknown
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected Obj, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected Obj, but got Unknown
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected Obj, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected Obj, but got Unknown
		//IL_121b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Expected Obj, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Expected Obj, but got Unknown
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected Obj, but got Unknown
		//IL_14c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cf: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbz));
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		StringFormat val10 = new StringFormat();
		StringFormat val11 = new StringFormat();
		GridEXLayout val12 = new GridEXLayout();
		GridEXLayout val13 = new GridEXLayout();
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
		((Control)p).SuspendLayout();
		((ISupportInitialize)r).BeginInit();
		((ISupportInitialize)q).BeginInit();
		((Control)q).SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((Control)this).SuspendLayout();
		((FileDialog)this.m_c).FileName = "openFileDialog1";
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_e).ComboStyle = (ComboStyle)1;
		((Control)this.m_e).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(490, 55);
		((Control)this.m_e).Name = "comboPayeNew";
		((Control)this.m_e).Size = new Size(144, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_e).StringFormat = val;
		((Control)this.m_e).TabIndex = 55;
		this.m_e.SelectedIndexChanged += d;
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(640, 59);
		((Control)this.m_f).Name = "label6";
		((Control)this.m_f).Size = new Size(87, 16);
		((Control)this.m_f).TabIndex = 56;
		((Control)this.m_f).Text = "پایه سال جدید";
		((Control)this.m_d).Anchor = (AnchorStyles)10;
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnAcpstdGroup.Image");
		this.m_d.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		((Control)this.m_d).Location = new Point(502, 114);
		((Control)this.m_d).Name = "btnAcpstdGroup";
		((Control)this.m_d).Size = new Size(132, 58);
		((Control)this.m_d).TabIndex = 1;
		((Control)this.m_d).Text = "انتقال موارد انتخابی به صنف جدید";
		((Control)this.m_d).Click += b;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_g).ComboStyle = (ComboStyle)1;
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(344, 21);
		((Control)this.m_g).Name = "comboPayeSearch";
		((Control)this.m_g).Size = new Size(116, 23);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_g).StringFormat = val2;
		((Control)this.m_g).TabIndex = 76;
		this.m_g.SelectedIndexChanged += g;
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((Control)this.m_h).AutoSize = true;
		((Control)this.m_h).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(636, 28);
		((Control)this.m_h).Name = "label7";
		((Control)this.m_h).Size = new Size(120, 16);
		((Control)this.m_h).TabIndex = 77;
		((Control)this.m_h).Text = "سال تعلیمی گذشته";
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_i).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_i).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_i).Location = new Point(490, 85);
		((Control)this.m_i).Name = "comboClsNew";
		((Control)this.m_i).Size = new Size(144, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_i).StringFormat = val3;
		((Control)this.m_i).TabIndex = 78;
		this.m_i.SelectedIndexChanged += c;
		((Control)j).Anchor = (AnchorStyles)9;
		((Control)j).AutoSize = true;
		((Control)j).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)j).Location = new Point(642, 90);
		((Control)j).Name = "label19";
		((Control)j).Size = new Size(88, 14);
		((Control)j).TabIndex = 79;
		((Control)j).Text = "صنف سال جدید";
		((Control)k).AutoSize = true;
		((Control)k).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(304, 6);
		((Control)k).Name = "label1";
		((Control)k).Size = new Size(209, 16);
		((Control)k).TabIndex = 80;
		((Control)k).Text = "انتقال شاگردان به سال تعلیمی جدید";
		((Control)l).Anchor = (AnchorStyles)9;
		((UIComboBase)l).ComboStyle = (ComboStyle)1;
		((UIComboBase)l).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1402";
		val4.Value = "1402";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1401";
		val5.Value = "1401";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1400";
		val6.Value = "1400";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1399";
		val7.Value = "1399";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "1398";
		val8.Value = "1398";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "1402";
		val9.Value = "1402";
		l.Items.AddRange(new UIComboBoxItem[6] { val4, val5, val6, val7, val8, val9 });
		((Control)l).Location = new Point(530, 24);
		((Control)l).Name = "dropYear";
		((Control)l).Size = new Size(97, 23);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)l).StringFormat = val10;
		((Control)l).TabIndex = 131;
		l.SelectedIndexChanged += f;
		((Control)m).Anchor = (AnchorStyles)9;
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(467, 25);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(27, 16);
		((Control)m).TabIndex = 132;
		((Control)m).Text = "پایه";
		((Control)n).Anchor = (AnchorStyles)9;
		((UIComboBase)n).ComboStyle = (ComboStyle)1;
		((UIComboBase)n).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(19, 21);
		((Control)n).Name = "dropClassSearch";
		((Control)n).Size = new Size(165, 23);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)n).StringFormat = val11;
		((Control)n).TabIndex = 133;
		n.SelectedIndexChanged += e;
		((Control)o).Anchor = (AnchorStyles)9;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(192, 25);
		((Control)o).Name = "label3";
		((Control)o).Size = new Size(99, 14);
		((Control)o).TabIndex = 134;
		((Control)o).Text = "صنف سال گذشته";
		((Control)p).Anchor = (AnchorStyles)13;
		((Control)p).Controls.Add((Control)(object)r);
		((Control)p).Controls.Add((Control)(object)l);
		((Control)p).Controls.Add((Control)(object)this.m_h);
		((Control)p).Controls.Add((Control)(object)n);
		((Control)p).Controls.Add((Control)(object)this.m_g);
		((Control)p).Controls.Add((Control)(object)o);
		((Control)p).Controls.Add((Control)(object)m);
		((Control)p).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(2, 33);
		((Control)p).Name = "uiGroupBox1";
		((Control)p).Size = new Size(767, 439);
		((Control)p).TabIndex = 135;
		((Control)p).Text = "اطلاعات سال تعلیمی گذشته";
		((Control)r).Anchor = (AnchorStyles)15;
		val12.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		r.DesignTimeLayout = val12;
		r.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		r.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)r).Font = new Font("Tahoma", 9.75f);
		r.GroupByBoxVisible = false;
		((Control)r).Location = new Point(8, 53);
		((Control)r).Name = "gridEX1";
		((ScrollableBase)r).RecordNavigator = true;
		r.RowHeaders = (InheritableBoolean)1;
		((Control)r).Size = new Size(751, 371);
		((Control)r).TabIndex = 135;
		((ScrollableBase)r).VisualStyle = (VisualStyle)2;
		r.LayoutLoad += a;
		((Control)q).Anchor = (AnchorStyles)14;
		((Control)q).Controls.Add((Control)(object)w);
		((Control)q).Controls.Add((Control)(object)x);
		((Control)q).Controls.Add((Control)(object)v);
		((Control)q).Controls.Add((Control)(object)u);
		((Control)q).Controls.Add((Control)(object)s);
		((Control)q).Controls.Add((Control)(object)this.m_e);
		((Control)q).Controls.Add((Control)(object)this.m_f);
		((Control)q).Controls.Add((Control)(object)j);
		((Control)q).Controls.Add((Control)(object)this.m_d);
		((Control)q).Controls.Add((Control)(object)this.m_i);
		((Control)q).Font = new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(2, 478);
		((Control)q).Name = "uiGroupBox2";
		((Control)q).Size = new Size(767, 180);
		((Control)q).TabIndex = 136;
		((Control)q).Text = "صنف سال جدید";
		((Control)w).Anchor = (AnchorStyles)10;
		((Control)w).AutoSize = true;
		((Control)w).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(695, 130);
		((Control)w).Name = "label5";
		((Control)w).Size = new Size(60, 14);
		((Control)w).TabIndex = 140;
		((Control)w).Text = "فیس صنف";
		((Control)x).Anchor = (AnchorStyles)10;
		((EditBase)x).AutoScroll = false;
		((EditBase)x).AutoScrollMargin = new Size(0, 0);
		((EditBase)x).AutoScrollMinSize = new Size(0, 0);
		((EditBase)x).AutoScrollPosition = new Point(0, 0);
		((EditBase)x).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)x).Enabled = false;
		((Control)x).Location = new Point(680, 150);
		((EditBase)x).MaxLength = 10;
		((Control)x).Name = "txtFeeClass";
		x.Numeric = true;
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(76, 22);
		((Control)x).TabIndex = 139;
		((Control)x).Tag = "";
		((EditBase)x).TextAlignment = (TextAlignment)1;
		((Control)v).Anchor = (AnchorStyles)9;
		v.BorderStyle = (BorderStyle)1;
		((Control)v).Location = new Point(579, 19);
		((Control)v).Name = "lYear";
		((Control)v).Size = new Size(55, 24);
		((Control)v).TabIndex = 138;
		v.TextAlign = (ContentAlignment)32;
		((Control)u).Anchor = (AnchorStyles)9;
		((Control)u).AutoSize = true;
		((Control)u).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(643, 23);
		((Control)u).Name = "label4";
		((Control)u).Size = new Size(111, 16);
		((Control)u).TabIndex = 137;
		((Control)u).Text = "سال تعلیمی جاری";
		s.AllowEdit = (InheritableBoolean)2;
		((Control)s).Anchor = (AnchorStyles)15;
		val13.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		s.DesignTimeLayout = val13;
		s.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)s).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		s.GroupByBoxVisible = false;
		((Control)s).Location = new Point(10, 13);
		((Control)s).Name = "gridEX2";
		((ScrollableBase)s).RecordNavigator = true;
		s.RowHeaders = (InheritableBoolean)1;
		((Control)s).Size = new Size(450, 159);
		((Control)s).TabIndex = 136;
		((ScrollableBase)s).VisualStyle = (VisualStyle)2;
		t.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		t.ImageSize = new Size(20, 20);
		((Control)t).Location = new Point(5, 4);
		((Control)t).Name = "btnClose";
		((Control)t).Size = new Size(83, 28);
		((Control)t).TabIndex = 137;
		((Control)t).Text = "بستن";
		((Control)t).Click += h;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(770, 662);
		((Control)this).Controls.Add((Control)(object)t);
		((Control)this).Controls.Add((Control)(object)q);
		((Control)this).Controls.Add((Control)(object)p);
		((Control)this).Controls.Add((Control)(object)k);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this).Name = "frmYear_Student";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "انتقال به پایه بالاتر";
		((Form)this).Load += i;
		((ISupportInitialize)p).EndInit();
		((Control)p).ResumeLayout(false);
		((Control)p).PerformLayout();
		((ISupportInitialize)r).EndInit();
		((ISupportInitialize)q).EndInit();
		((Control)q).ResumeLayout(false);
		((Control)q).PerformLayout();
		((ISupportInitialize)s).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
