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
using school_Af.Properties;

public class asdb8 : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private string m_b = "";

	public string c = "";

	private string m_d = "gTerm3";

	private bool m_e = true;

	private int f;

	private bool g = false;

	private IContainer h = null;

	private Panel i;

	private Panel j;

	private Panel k;

	private Label l;

	private UIButton m;

	private GridEX n;

	private UIComboBox o;

	private Label p;

	private Label q;

	private Label r;

	private Button s;

	private Button t;

	private Label u;

	public asdb8()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 8;
					continue;
				case 0:
					this.m_d = "gTerm1";
					((Control)l).Text = "ثبت درجه چهار و نیم ماه";
					num = 7;
					continue;
				case 8:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 10;
				case 5:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					try
					{
						while (true)
						{
							IL_0146:
							this.m_b = asdcb.a(asdab.e(), CommandType.Text, "select id from tExam where xYear=" + ((Control)q).Text + "  and term=" + this.c).ToString();
							string text = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + this.m_b).ToString();
							flag = !(text != "1");
							num = 1;
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
									goto case 2;
								case 3:
								{
									SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, this.m_b) };
									asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
									asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
									asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
									num = 2;
									continue;
								}
								case 2:
									c();
									n.CurrentColumn = n.GetRow(0).Cells["gTerm"].Column;
									((Control)n).Select();
									n.SelectCurrentCellText();
									num = 0;
									continue;
								case 0:
									goto end_IL_012d;
								}
								goto IL_0146;
								continue;
								end_IL_012d:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					num = 3;
					continue;
				case 10:
					((Control)q).Text = asdaj.a;
					flag = !(this.c == "1");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 7;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)k).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 10;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		try
		{
			bool flag = default;
			while (true)
			{
				string text = asdcb.a(asdab.e(), CommandType.Text, "select xpaye from tclass where id=" + o.SelectedValue.ToString()).ToString();
				n.RootTable.Columns["AcpFinal"].HasValueList = true;
				GridEXValueListItemCollection valueList = n.RootTable.Columns["AcpFinal"].ValueList;
				((CollectionBase)(object)valueList).Clear();
				int num = 5;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 5:
						num = ((text == "12") ? 16 : 3);
						continue;
					case 3:
						num = 11;
						continue;
					case 11:
						num2 = ((!(text == "11")) ? 1 : 0);
						goto IL_01be;
					case 8:
						flag = !(this.c == "3");
						num = 13;
						continue;
					case 13:
						if (!flag)
						{
							num = 12;
							continue;
						}
						valueList.Add(new GridEXValueListItem((object)"1", "کامیاب"));
						valueList.Add(new GridEXValueListItem((object)"0", "ناکام"));
						valueList.Add(new GridEXValueListItem((object)"5", "غایب"));
						valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
						num = 14;
						continue;
					case 2:
						if (!flag)
						{
							num = 8;
							continue;
						}
						flag = !(this.c == "3");
						num = 7;
						continue;
					case 15:
						valueList.Add(new GridEXValueListItem((object)"1", "ارتقا صنف"));
						valueList.Add(new GridEXValueListItem((object)"2", "مشروط"));
						valueList.Add(new GridEXValueListItem((object)"0", "تکرار صنف"));
						valueList.Add(new GridEXValueListItem((object)"3", "معذرتی"));
						valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
						num = 9;
						continue;
					case 16:
						num2 = 0;
						goto IL_01be;
					case 12:
						valueList.Add(new GridEXValueListItem((object)"1", "کامیاب"));
						valueList.Add(new GridEXValueListItem((object)"2", "مشروط"));
						valueList.Add(new GridEXValueListItem((object)"0", "ناکام"));
						valueList.Add(new GridEXValueListItem((object)"3", "معذرتی"));
						valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
						num = 4;
						continue;
					case 7:
						if (flag)
						{
							valueList.Add(new GridEXValueListItem((object)"1", "موفق"));
							valueList.Add(new GridEXValueListItem((object)"0", "تلاش بیشتر"));
							valueList.Add(new GridEXValueListItem((object)"5", "غایب"));
							valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
							num = 6;
						}
						else
						{
							num = 15;
						}
						continue;
					case 6:
					case 9:
						if (true)
						{
						}
						num = 0;
						continue;
					case 4:
					case 14:
						num = 10;
						continue;
					case 0:
					case 10:
						num = 1;
						continue;
					case 1:
						return;
						IL_01be:
						flag = (byte)num2 != 0;
						num = 2;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void c()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xpaye in(12) and xYear=" + ((Control)q).Text + " and xPaye in(" + asdaj.n + ") order by xpaye,sortRpt");
			o.DataSource = dataSource;
			o.DisplayMember = "Name";
			o.ValueMember = "id";
			bool flag = ((CollectionBase)(object)o.Items).Count <= 0;
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
					o.SelectedIndex = 0;
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
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		DataTable dataTable = default;
		int num2 = default;
		while (true)
		{
			bool flag = o.SelectedIndex < 0;
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 9:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 5;
				case 10:
					((Control)u).Text = "نتیجه شاگردان این صنف ثبت نشده است.میتوانید از منوی ثبت نتایج برای ثبت نتیجه شاگردان اقدام نمایید.";
					((Control)u).Visible = true;
					num = 5;
					continue;
				case 4:
					((Control)u).Visible = false;
					num = 7;
					continue;
				case 5:
				case 6:
				case 7:
					num = 2;
					continue;
				case 2:
					return;
				case 0:
				{
					SqlParameter[] a_ = new SqlParameter[3]
					{
						asdcb.a("@xTerm", SqlDbType.Int, this.c),
						asdcb.a("@xClass", SqlDbType.Int, o.SelectedValue.ToString()),
						asdcb.a("@xYear", SqlDbType.Int, ((Control)q).Text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, "sp_SelectStdForSetGTerm", a_);
					n.DataSource = dataTable;
					GridEXFormatCondition val = new GridEXFormatCondition(n.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
					val.FormatStyle.ForeColor = SystemColors.WindowText;
					val.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					n.RootTable.FormatConditions.Add(val);
					GridEXFormatCondition val2 = new GridEXFormatCondition(n.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
					val2.FormatStyle.ForeColor = SystemColors.WindowText;
					val2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					n.RootTable.FormatConditions.Add(val2);
					GridEXFormatCondition val3 = new GridEXFormatCondition(n.RootTable.Columns["acp"], (ConditionOperator)0, (object)"2");
					val3.FormatStyle.ForeColor = SystemColors.WindowText;
					val3.FormatStyle.BackColor = Color.Yellow;
					n.RootTable.FormatConditions.Add(val3);
					d();
					num2 = dataTable.Select("AcpFinal>-1").Length;
					flag = num2 != dataTable.Rows.Count;
					num = 8;
					continue;
				}
				case 8:
					if (true)
					{
					}
					if (!flag)
					{
						num = 4;
						continue;
					}
					flag = num2 != 0;
					num = 3;
					continue;
				case 1:
					((Control)u).Text = "نتیجه برخی از شاگردان این صنف ثبت نشده است.میتوانید از منوی ثبت نتایج برای ثبت نتیجه شاگردان اقدام نمایید.";
					((Control)u).Visible = true;
					num = 6;
					continue;
				case 3:
					if (flag)
					{
						flag = num2 >= dataTable.Rows.Count;
						num = 9;
					}
					else
					{
						num = 10;
					}
					continue;
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
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = this.m_e;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 1:
					try
					{
						n.CurrentColumn = n.GetRow(0).Cells["gTerm"].Column;
						((Control)n).Select();
						n.SelectCurrentCellText();
					}
					catch
					{
					}
					f = o.SelectedIndex;
					num = 10;
					continue;
				case 9:
					g = false;
					num = 7;
					continue;
				case 7:
					return;
				case 3:
					flag = !g;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 2;
					continue;
				case 0:
					g = false;
					this.m_e = true;
					b();
					num = 1;
					continue;
				case 10:
					return;
				case 4:
					g = true;
					o.SelectedIndex = f;
					num = 5;
					continue;
				case 5:
					return;
				case 2:
					if (flag)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		bool flag = default;
		int num5 = default;
		while (true)
		{
			SqlCommand val = null;
			string text = "";
			int num = 0;
			((DbConnection)(object)this.m_a).Open();
			int num2 = 0;
			int num3 = 5;
			while (true)
			{
				switch (num3)
				{
				case 4:
					try
					{
						while (true)
						{
							IL_00c6:
							flag = !(n.GetRow(num2).Cells["gTerm"].Text != "");
							num3 = 4;
							while (true)
							{
								switch (num3)
								{
								case 4:
									if (!flag)
									{
										num3 = 6;
										continue;
									}
									goto case 7;
								case 2:
									num5++;
									num3 = 1;
									continue;
								case 5:
									if (!flag)
									{
										num3 = 8;
										continue;
									}
									goto case 2;
								case 6:
									short.Parse(n.GetRow(num2).Cells["gTerm"].Text.ToString());
									text = n.GetRow(num2).Cells["gTerm"].Text.ToString();
									num5 = num2 + 1;
									num3 = 10;
									continue;
								case 0:
									num3 = 7;
									continue;
								case 8:
									n.GetRow(num2).BeginEdit();
									n.GetRow(num2).Cells["acp"].Value = "2";
									n.GetRow(num2).EndEdit();
									n.GetRow(num5).BeginEdit();
									n.GetRow(num5).Cells["acp"].Value = "2";
									n.GetRow(num5).EndEdit();
									num3 = 2;
									continue;
								case 1:
								case 10:
									flag = num5 < n.RowCount;
									num3 = 3;
									continue;
								case 3:
									if (flag)
									{
										flag = !(text == n.GetRow(num5).Cells["gTerm"].Text.ToString());
										num3 = 5;
									}
									else
									{
										num3 = 0;
									}
									continue;
								case 7:
									num3 = 9;
									continue;
								case 9:
									goto end_IL_0091;
								}
								goto IL_00c6;
								continue;
								end_IL_0091:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num2++;
					num3 = 20;
					continue;
				case 8:
					num2++;
					num3 = 13;
					continue;
				case 14:
					if (!flag)
					{
						num3 = 12;
						continue;
					}
					val.Parameters.AddWithValue("@gClass", (object)text);
					num3 = 18;
					continue;
				case 19:
					n.Refetch();
					flag = num <= 0;
					num3 = 17;
					continue;
				case 17:
					if (!flag)
					{
						num3 = 0;
						continue;
					}
					return;
				case 1:
				case 15:
					num3 = 8;
					continue;
				case 12:
					val.Parameters.AddWithValue("@gClass", (object)DBNull.Value);
					num3 = 16;
					continue;
				case 20:
				case 21:
					flag = num2 < n.RowCount;
					num3 = 3;
					continue;
				case 3:
					if (flag)
					{
						text = "";
						if (true)
						{
						}
						num3 = 4;
					}
					else
					{
						num3 = 19;
					}
					continue;
				case 0:
					MessageBox.Show("تعداد " + num + " ردیف انجام شد");
					num3 = 9;
					continue;
				case 9:
					return;
				case 7:
					num3 = 15;
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_0537:
							flag = !(n.GetRow(num2).Cells["gTerm"].Text != "");
							num3 = 2;
							while (true)
							{
								switch (num3)
								{
								case 2:
									if (!flag)
									{
										num3 = 4;
										continue;
									}
									text = null;
									num3 = 0;
									continue;
								case 4:
									short.Parse(n.GetRow(num2).Cells["gTerm"].Text.ToString());
									text = n.GetRow(num2).Cells["gTerm"].Text.ToString();
									num3 = 3;
									continue;
								case 0:
								case 3:
									num3 = 1;
									continue;
								case 1:
									goto end_IL_051a;
								}
								goto IL_0537;
								continue;
								end_IL_051a:
								break;
							}
							break;
						}
					}
					catch
					{
						n.GetRow(num2).BeginEdit();
						n.GetRow(num2).Cells["acp"].Value = "-1";
						n.GetRow(num2).EndEdit();
						goto case 8;
					}
					val = new SqlCommand("update tYear_Student set " + this.m_d + "=@gClass where id=@id", this.m_a);
					val.Parameters.AddWithValue("@id", (object)n.GetRow(num2).Cells["id"].Text.ToString());
					flag = text != null;
					num3 = 14;
					continue;
				case 6:
					((DbConnection)(object)this.m_a).Close();
					((Control)n).Refresh();
					this.m_e = true;
					num2 = 0;
					num3 = 21;
					continue;
				case 16:
				case 18:
				{
					int num4 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num4 >= 1;
					num3 = 11;
					continue;
				}
				case 11:
					if (flag)
					{
						n.GetRow(num2).BeginEdit();
						n.GetRow(num2).Cells["acp"].Value = "1";
						n.GetRow(num2).EndEdit();
						num++;
						num3 = 1;
					}
					else
					{
						num3 = 7;
					}
					continue;
				case 5:
				case 13:
					flag = num2 < n.RowCount;
					num3 = 10;
					continue;
				case 10:
					if (flag)
					{
						text = "";
						num3 = 2;
					}
					else
					{
						num3 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		this.m_e = false;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 116;
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
					if (true)
					{
					}
					((Control)n).Refresh();
					b(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = this.m_e;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 3:
					return;
				case 2:
					((CancelEventArgs)(object)A_1).Cancel = true;
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 5;
					continue;
				case 5:
					num = ((!flag) ? 2 : 3);
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			this.m_e = false;
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < n.RowCount;
					num2 = 4;
					continue;
				case 4:
					num2 = (flag ? 1 : 2);
					continue;
				case 2:
					if (true)
					{
					}
					n.Refetch();
					return;
				case 1:
					try
					{
						n.GetRow(num).BeginEdit();
						n.GetRow(num).Cells["acp"].Value = DBNull.Value;
						n.GetRow(num).Cells["gTerm"].Value = n.GetRow(num).Cells["gclsKoll"].Text.ToString();
						n.GetRow(num).EndEdit();
					}
					catch
					{
					}
					num++;
					num2 = 0;
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
			int num = 1;
			while (true)
			{
				if (true)
				{
				}
				int num2;
				switch (num)
				{
				case 1:
					num = ((!A_0) ? 6 : 2);
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					num2 = ((h == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					h.Dispose();
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 6:
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
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected Obj, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected Obj, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected Obj, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb8));
		GridEXLayout val2 = new GridEXLayout();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		u = new Label();
		t = new Button();
		s = new Button();
		q = new Label();
		r = new Label();
		o = new UIComboBox();
		p = new Label();
		l = new Label();
		m = new UIButton();
		n = new GridEX();
		((Control)i).SuspendLayout();
		((Control)j).SuspendLayout();
		((Control)k).SuspendLayout();
		((ISupportInitialize)n).BeginInit();
		((Control)this).SuspendLayout();
		((Control)i).BackColor = Color.FromArgb(214, 223, 247);
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Controls.Add((Control)(object)j);
		((Control)i).Dock = (DockStyle)5;
		((Control)i).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)i).Location = new Point(0, 0);
		((Control)i).Name = "panel1";
		((Control)i).Size = new Size(751, 700);
		((Control)i).TabIndex = 0;
		((Control)j).BackColor = Color.Black;
		((Control)j).Controls.Add((Control)(object)k);
		((Control)j).Dock = (DockStyle)5;
		((Control)j).Location = new Point(0, 0);
		((Control)j).Name = "panel2";
		((Control)j).Size = new Size(749, 698);
		((Control)j).TabIndex = 44;
		((Control)k).BackColor = Color.FromArgb(214, 223, 247);
		((Control)k).Controls.Add((Control)(object)u);
		((Control)k).Controls.Add((Control)(object)t);
		((Control)k).Controls.Add((Control)(object)s);
		((Control)k).Controls.Add((Control)(object)q);
		((Control)k).Controls.Add((Control)(object)r);
		((Control)k).Controls.Add((Control)(object)o);
		((Control)k).Controls.Add((Control)(object)p);
		((Control)k).Controls.Add((Control)(object)l);
		((Control)k).Controls.Add((Control)(object)m);
		((Control)k).Controls.Add((Control)(object)n);
		((Control)k).Location = new Point(3, 3);
		((Control)k).Name = "panel3";
		((Control)k).Size = new Size(742, 689);
		((Control)k).TabIndex = 0;
		((Control)u).BackColor = Color.FromArgb(255, 192, 192);
		u.BorderStyle = (BorderStyle)1;
		((Control)u).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(82, 78);
		((Control)u).Name = "lmsg";
		((Control)u).Size = new Size(614, 23);
		((Control)u).TabIndex = 121;
		u.TextAlign = (ContentAlignment)32;
		((Control)u).Visible = false;
		((Control)t).BackColor = Color.Violet;
		((ButtonBase)t).FlatAppearance.BorderColor = Color.Maroon;
		((ButtonBase)t).FlatAppearance.BorderSize = 3;
		((ButtonBase)t).FlatStyle = (FlatStyle)0;
		((Control)t).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)t).ImageAlign = (ContentAlignment)64;
		((Control)t).Location = new Point(11, 37);
		((Control)t).Name = "btnCopygClass";
		((Control)t).Size = new Size(184, 35);
		((Control)t).TabIndex = 120;
		((Control)t).Text = "درخواست درجه پیشنهادی سیستم";
		((ButtonBase)t).UseVisualStyleBackColor = false;
		((Control)t).Click += a;
		((Control)s).Anchor = (AnchorStyles)6;
		((Control)s).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ButtonBase)s).Image = (Image)(object)Resources._4160;
		((ButtonBase)s).ImageAlign = (ContentAlignment)64;
		((Control)s).Location = new Point(538, 648);
		((Control)s).Name = "btnSaveMark";
		((Control)s).Size = new Size(197, 35);
		((Control)s).TabIndex = 119;
		((Control)s).Text = "ثبت درجه(F5)";
		((ButtonBase)s).UseVisualStyleBackColor = true;
		((Control)s).Click += b;
		q.BorderStyle = (BorderStyle)1;
		((Control)q).Location = new Point(584, 42);
		((Control)q).Name = "lYear";
		((Control)q).Size = new Size(55, 24);
		((Control)q).TabIndex = 118;
		((Control)r).AutoSize = true;
		((Control)r).Location = new Point(647, 40);
		((Control)r).Name = "label3";
		((Control)r).Size = new Size(78, 26);
		((Control)r).TabIndex = 117;
		((Control)r).Text = "سال تعلیمی";
		((UIComboBase)o).ComboStyle = (ComboStyle)1;
		((UIComboBase)o).DropListFont = new Font("B Nazanin", 12f);
		((Control)o).Location = new Point(271, 37);
		((Control)o).Name = "dropCls";
		((Control)o).Size = new Size(181, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)o).StringFormat = val;
		((Control)o).TabIndex = 52;
		o.SelectedIndexChanged += c;
		((Control)p).AutoSize = true;
		((Control)p).Location = new Point(458, 42);
		((Control)p).Name = "label19";
		((Control)p).Size = new Size(41, 26);
		((Control)p).TabIndex = 51;
		((Control)p).Text = "صنف";
		((Control)l).Font = new Font("B Nazanin", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).ForeColor = Color.DarkViolet;
		((Control)l).Location = new Point(145, -4);
		((Control)l).Name = "lTerm";
		((Control)l).Size = new Size(451, 44);
		((Control)l).TabIndex = 50;
		((Control)l).Text = "ثبت درجه نهایی";
		l.TextAlign = (ContentAlignment)32;
		((Control)m).Anchor = (AnchorStyles)6;
		m.DialogResult = (DialogResult)2;
		m.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		m.ImageSize = new Size(40, 40);
		((Control)m).Location = new Point(11, 649);
		((Control)m).Name = "btnClose";
		((Control)m).Size = new Size(93, 35);
		((Control)m).TabIndex = 44;
		((Control)m).Text = "بستن";
		((Control)m).Click += d;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		n.DesignTimeLayout = val2;
		n.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		n.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		n.GroupByBoxVisible = false;
		((Control)n).Location = new Point(8, 108);
		((Control)n).Name = "gridEX1";
		((ScrollableBase)n).RecordNavigator = true;
		n.RowHeaders = (InheritableBoolean)1;
		n.SelectedFormatStyle.BackColor = Color.Empty;
		n.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)n).Size = new Size(727, 534);
		((Control)n).TabIndex = 45;
		((ScrollableBase)n).VisualStyle = (VisualStyle)2;
		n.CellUpdated += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(751, 700);
		((Control)this).Controls.Add((Control)(object)i);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSetgTerm";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره";
		((Form)this).Load += e;
		((Control)this).KeyUp += a;
		((Form)this).FormClosing += a;
		((Control)i).ResumeLayout(false);
		((Control)j).ResumeLayout(false);
		((Control)k).ResumeLayout(false);
		((Control)k).PerformLayout();
		((ISupportInitialize)n).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
