using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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

	public string __field_c = "";

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
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
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
					l.Text = "ثبت درجه چهار و نیم ماه";
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
							this.m_b = asdcb.a(asdab.e(), CommandType.Text, "select id from tExam where xYear=" + q.Text + "  and term=" + this.__field_c).ToString();
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
									n.Select();
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
					q.Text = asdaj.__field_a;
					flag = !(this.__field_c == "1");
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
						k.BackColor = Color.FromArgb(red, green, blue);
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
		try
		{
			bool flag = default;
			while (true)
			{
				string text = asdcb.a(asdab.e(), CommandType.Text, "select xpaye from tclass where id=" + o.SelectedValue.ToString()).ToString();
				n.RootTable.Columns["AcpFinal"].HasValueList = true;
				GridEXValueListItemCollection valueList = n.RootTable.Columns["AcpFinal"].ValueList;
				valueList.Clear();
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
						flag = !(this.__field_c == "3");
						num = 13;
						continue;
					case 13:
						if (!flag)
						{
							num = 12;
							continue;
						}
						valueList.Add(new GridEXValueListItem("1", "کامیاب"));
						valueList.Add(new GridEXValueListItem("0", "ناکام"));
						valueList.Add(new GridEXValueListItem("5", "غایب"));
						valueList.Add(new GridEXValueListItem("4", "محروم"));
						num = 14;
						continue;
					case 2:
						if (!flag)
						{
							num = 8;
							continue;
						}
						flag = !(this.__field_c == "3");
						num = 7;
						continue;
					case 15:
						valueList.Add(new GridEXValueListItem("1", "ارتقا صنف"));
						valueList.Add(new GridEXValueListItem("2", "مشروط"));
						valueList.Add(new GridEXValueListItem("0", "تکرار صنف"));
						valueList.Add(new GridEXValueListItem("3", "معذرتی"));
						valueList.Add(new GridEXValueListItem("4", "محروم"));
						num = 9;
						continue;
					case 16:
						num2 = 0;
						goto IL_01be;
					case 12:
						valueList.Add(new GridEXValueListItem("1", "کامیاب"));
						valueList.Add(new GridEXValueListItem("2", "مشروط"));
						valueList.Add(new GridEXValueListItem("0", "ناکام"));
						valueList.Add(new GridEXValueListItem("3", "معذرتی"));
						valueList.Add(new GridEXValueListItem("4", "محروم"));
						num = 4;
						continue;
					case 7:
						if (flag)
						{
							valueList.Add(new GridEXValueListItem("1", "موفق"));
							valueList.Add(new GridEXValueListItem("0", "تلاش بیشتر"));
							valueList.Add(new GridEXValueListItem("5", "غایب"));
							valueList.Add(new GridEXValueListItem("4", "محروم"));
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xpaye in(12) and xYear=" + q.Text + " and xPaye in(" + asdaj.n + ") order by xpaye,sortRpt");
			o.DataSource = dataSource;
			o.DisplayMember = "Name";
			o.ValueMember = "id";
			bool flag = o.Items.Count <= 0;
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
					u.Text = "نتیجه شاگردان این صنف ثبت نشده است.میتوانید از منوی ثبت نتایج برای ثبت نتیجه شاگردان اقدام نمایید.";
					u.Visible = true;
					num = 5;
					continue;
				case 4:
					u.Visible = false;
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
						asdcb.a("@xTerm", SqlDbType.Int, this.__field_c),
						asdcb.a("@xClass", SqlDbType.Int, o.SelectedValue.ToString()),
						asdcb.a("@xYear", SqlDbType.Int, q.Text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, "sp_SelectStdForSetGTerm", a_);
					n.DataSource = dataTable;
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(n.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					n.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(n.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					n.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					GridEXFormatCondition gridEXFormatCondition3 = new GridEXFormatCondition(n.RootTable.Columns["acp"], ConditionOperator.Equal, "2");
					gridEXFormatCondition3.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition3.FormatStyle.BackColor = Color.Yellow;
					n.RootTable.FormatConditions.Add(gridEXFormatCondition3);
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
					u.Text = "نتیجه برخی از شاگردان این صنف ثبت نشده است.میتوانید از منوی ثبت نتایج برای ثبت نتیجه شاگردان اقدام نمایید.";
					u.Visible = true;
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
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
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
						n.Select();
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
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
		bool flag = default;
		int num5 = default;
		while (true)
		{
			SqlCommand sqlCommand = null;
			string text = "";
			int num = 0;
			this.m_a.Open();
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
					sqlCommand.Parameters.AddWithValue("@gClass", text);
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
					sqlCommand.Parameters.AddWithValue("@gClass", DBNull.Value);
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
					sqlCommand = new SqlCommand("update tYear_Student set " + this.m_d + "=@gClass where id=@id", this.m_a);
					sqlCommand.Parameters.AddWithValue("@id", n.GetRow(num2).Cells["id"].Text.ToString());
					flag = text != null;
					num3 = 14;
					continue;
				case 6:
					this.m_a.Close();
					n.Refresh();
					this.m_e = true;
					num2 = 0;
					num3 = 21;
					continue;
				case 16:
				case 18:
				{
					int num4 = sqlCommand.ExecuteNonQuery();
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
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F5;
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
					n.Refresh();
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
					A_1.Cancel = true;
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
protected override void Dispose(bool A_0)
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb8));
		GridEXLayout gridEXLayout = new GridEXLayout();
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
		i.SuspendLayout();
		j.SuspendLayout();
		k.SuspendLayout();
		((ISupportInitialize)n).BeginInit();
		SuspendLayout();
		i.BackColor = Color.FromArgb(214, 223, 247);
		i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		i.Controls.Add(j);
		i.Dock = DockStyle.Fill;
		i.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		i.Location = new Point(0, 0);
		i.Name = "panel1";
		i.Size = new Size(751, 700);
		i.TabIndex = 0;
		j.BackColor = Color.Black;
		j.Controls.Add(k);
		j.Dock = DockStyle.Fill;
		j.Location = new Point(0, 0);
		j.Name = "panel2";
		j.Size = new Size(749, 698);
		j.TabIndex = 44;
		k.BackColor = Color.FromArgb(214, 223, 247);
		k.Controls.Add(u);
		k.Controls.Add(t);
		k.Controls.Add(s);
		k.Controls.Add(q);
		k.Controls.Add(r);
		k.Controls.Add(o);
		k.Controls.Add(p);
		k.Controls.Add(l);
		k.Controls.Add(m);
		k.Controls.Add(n);
		k.Location = new Point(3, 3);
		k.Name = "panel3";
		k.Size = new Size(742, 689);
		k.TabIndex = 0;
		u.BackColor = Color.FromArgb(255, 192, 192);
		u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		u.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(82, 78);
		u.Name = "lmsg";
		u.Size = new Size(614, 23);
		u.TabIndex = 121;
		u.TextAlign = ContentAlignment.MiddleCenter;
		u.Visible = false;
		t.BackColor = Color.Violet;
		t.FlatAppearance.BorderColor = Color.Maroon;
		t.FlatAppearance.BorderSize = 3;
		t.FlatStyle = FlatStyle.Flat;
		t.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t.ImageAlign = ContentAlignment.MiddleRight;
		t.Location = new Point(11, 37);
		t.Name = "btnCopygClass";
		t.Size = new Size(184, 35);
		t.TabIndex = 120;
		t.Text = "درخواست درجه پیشنهادی سیستم";
		t.UseVisualStyleBackColor = false;
		t.Click += a;
		s.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		s.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		s.Image = Resources._4160;
		s.ImageAlign = ContentAlignment.MiddleRight;
		s.Location = new Point(538, 648);
		s.Name = "btnSaveMark";
		s.Size = new Size(197, 35);
		s.TabIndex = 119;
		s.Text = "ثبت درجه(F5)";
		s.UseVisualStyleBackColor = true;
		s.Click += b;
		q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		q.Location = new Point(584, 42);
		q.Name = "lYear";
		q.Size = new Size(55, 24);
		q.TabIndex = 118;
		r.AutoSize = true;
		r.Location = new Point(647, 40);
		r.Name = "label3";
		r.Size = new Size(78, 26);
		r.TabIndex = 117;
		r.Text = "سال تعلیمی";
		o.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		o.DropListFont = new Font("B Nazanin", 12f);
		o.Location = new Point(271, 37);
		o.Name = "dropCls";
		o.Size = new Size(181, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		o.StringFormat = stringFormat;
		o.TabIndex = 52;
		o.SelectedIndexChanged += c;
		p.AutoSize = true;
		p.Location = new Point(458, 42);
		p.Name = "label19";
		p.Size = new Size(41, 26);
		p.TabIndex = 51;
		p.Text = "صنف";
		l.Font = new Font("B Nazanin", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.ForeColor = Color.DarkViolet;
		l.Location = new Point(145, -4);
		l.Name = "lTerm";
		l.Size = new Size(451, 44);
		l.TabIndex = 50;
		l.Text = "ثبت درجه نهایی";
		l.TextAlign = ContentAlignment.MiddleCenter;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		m.DialogResult = DialogResult.Cancel;
		m.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		m.ImageSize = new Size(40, 40);
		m.Location = new Point(11, 649);
		m.Name = "btnClose";
		m.Size = new Size(93, 35);
		m.TabIndex = 44;
		m.Text = "بستن";
		m.Click += d;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		n.DesignTimeLayout = gridEXLayout;
		n.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		n.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
		n.GroupByBoxVisible = false;
		n.Location = new Point(8, 108);
		n.Name = "gridEX1";
		n.RecordNavigator = true;
		n.RowHeaders = InheritableBoolean.True;
		n.SelectedFormatStyle.BackColor = Color.Empty;
		n.SelectedFormatStyle.ForeColor = Color.Empty;
		n.Size = new Size(727, 534);
		n.TabIndex = 45;
		n.VisualStyle = VisualStyle.Office2003;
		n.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(751, 700);
		Controls.Add(i);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSetgTerm";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += e;
		KeyUp += a;
		FormClosing += a;
		i.ResumeLayout(performLayout: false);
		j.ResumeLayout(performLayout: false);
		k.ResumeLayout(performLayout: false);
		k.PerformLayout();
		((ISupportInitialize)n).EndInit();
		ResumeLayout(performLayout: false);
	}
}
