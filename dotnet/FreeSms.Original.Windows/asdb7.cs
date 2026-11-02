using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdb7 : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private IContainer m_b = null;

	private Panel m_c;

	private UIButton m_d;

	private GridEX e;

	private Button f;

	private Button g;

	private OpenFileDialog h;

	private TextBox i;

	private Label j;

	private Label k;

	private Label l;

	private UIComboBox m;

	private Label n;

	private Label o;

	private MaskedEditBox p;

	private ProgressBar q;

	public asdb7()
	{
		a();
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		bool flag17 = default;
		bool flag8 = default;
		bool flag9 = default;
		bool flag11 = default;
		DataSet dataSet = default;
		int num2 = default;
		bool flag2 = default;
		bool flag14 = default;
		string text = default;
		bool flag13 = default;
		OleDbDataAdapter oleDbDataAdapter = default;
		string text2 = default;
		OleDbConnection oleDbConnection = default;
		bool flag3 = default;
		bool flag10 = default;
		bool flag15 = default;
		bool flag12 = default;
		bool flag6 = default;
		bool flag18 = default;
		bool flag16 = default;
		bool flag5 = default;
		bool flag19 = default;
		bool flag4 = default;
		bool flag7 = default;
		while (true)
		{
			bool flag = DialogResult.OK != h.ShowDialog();
			int num = 81;
			while (true)
			{
				switch (num)
				{
				case 81:
					if (!flag)
					{
						num = 8;
						continue;
					}
					return;
				case 97:
					flag = flag17;
					num = 64;
					continue;
				case 64:
					if (!flag)
					{
						num = 99;
						continue;
					}
					goto case 70;
				case 36:
					flag = flag8;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 68;
				case 42:
					flag9 = true;
					num = 15;
					continue;
				case 78:
					flag = flag11;
					num = 84;
					continue;
				case 84:
					if (!flag)
					{
						num = 71;
						continue;
					}
					goto case 112;
				case 79:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "paye");
					num = 52;
					continue;
				case 52:
					if (!flag)
					{
						num = 91;
						continue;
					}
					goto case 30;
				case 75:
					flag = flag2;
					num = 95;
					continue;
				case 95:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 97;
				case 109:
					flag = flag14;
					num = 120;
					continue;
				case 120:
					if (!flag)
					{
						num = 115;
						continue;
					}
					goto case 102;
				case 31:
					text += "\nفیلد مبلغ فیس اصلی صنف وجود ندارد(MainFees)";
					num = 68;
					continue;
				case 35:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "stdfeeskoll");
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 55;
				case 38:
					flag = flag13;
					num = 83;
					continue;
				case 83:
					if (!flag)
					{
						num = 101;
						continue;
					}
					goto case 117;
				case 37:
				{
					try
					{
						oleDbDataAdapter.Fill(dataSet);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
					e.DataSource = dataSet.Tables[0];
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(e.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					e.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(e.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					e.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					num = 47;
					continue;
				}
				case 105:
					if (!flag)
					{
						num = 86;
						continue;
					}
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "mobilemother");
					num = 82;
					continue;
				case 8:
					text2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + h.FileName + ";Extended Properties=Excel 12.0;";
					oleDbConnection = new OleDbConnection(text2);
					num = 57;
					continue;
				case 28:
					flag3 = true;
					num = 80;
					continue;
				case 30:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "mainfees");
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 32;
				case 108:
					flag10 = true;
					num = 35;
					continue;
				case 117:
					flag = flag15;
					num = 103;
					continue;
				case 103:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 109;
				case 14:
					text += "\nفیلد تلفن مادر وجود ندارد(MobileMother)";
					num = 85;
					continue;
				case 45:
					flag2 = true;
					num = 6;
					continue;
				case 21:
					if (!flag)
					{
						num = 45;
						continue;
					}
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "father");
					num = 67;
					continue;
				case 43:
					flag = flag9;
					num = 44;
					continue;
				case 44:
					if (!flag)
					{
						num = 92;
						continue;
					}
					goto case 58;
				case 77:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "uniform");
					num = 88;
					continue;
				case 88:
					if (true)
					{
					}
					if (!flag)
					{
						num = 118;
						continue;
					}
					goto case 2;
				case 15:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "stdfees");
					num = 107;
					continue;
				case 107:
					if (!flag)
					{
						num = 108;
						continue;
					}
					goto case 35;
				case 4:
					text += "\nفیلد فیس ماهانه شاگرد وجود ندارد(Stdfees)";
					num = 78;
					continue;
				case 16:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "dakhele");
					num = 100;
					continue;
				case 100:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 77;
				case 55:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "payment");
					num = 72;
					continue;
				case 72:
					if (!flag)
					{
						num = 93;
						continue;
					}
					goto case 16;
				case 93:
					flag12 = true;
					num = 16;
					continue;
				case 3:
					text = "";
					flag = flag6;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 62;
						continue;
					}
					goto case 53;
				case 94:
					flag18 = true;
					num = 65;
					continue;
				case 104:
					flag14 = true;
					num = 33;
					continue;
				case 69:
					flag = flag18;
					num = 119;
					continue;
				case 119:
					if (!flag)
					{
						num = 106;
						continue;
					}
					goto case 96;
				case 9:
					flag16 = true;
					num = 74;
					continue;
				case 101:
					text += "\nفیلد مبلغ پرداختی داخله وجود ندارد(dakhele)";
					num = 117;
					continue;
				case 49:
					flag5 = true;
					num = 79;
					continue;
				case 115:
					text += "\nفیلد مبلغ پرداختی امتحان وجود ندارد(exam)";
					num = 102;
					continue;
				case 26:
					flag11 = true;
					num = 55;
					continue;
				case 91:
					flag6 = true;
					num = 30;
					continue;
				case 96:
					flag = flag19;
					num = 87;
					continue;
				case 87:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 85;
				case 32:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "jens");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 28;
						continue;
					}
					goto case 80;
				case 24:
					text += "\nفیلد کد متعلم وجود ندارد(Code)";
					num = 43;
					continue;
				case 118:
					flag15 = true;
					num = 2;
					continue;
				case 112:
					flag = flag12;
					num = 25;
					continue;
				case 25:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 38;
				case 48:
					text += "\nفیلد جنسیت وجود ندارد(jens)";
					num = 69;
					continue;
				case 20:
					text += "\nفیلد مبلغ پرداخت شده فیس وجود ندارد(payment)";
					num = 38;
					continue;
				case 11:
					text += "\nفیلد مبلغ پرداختی لباس وجود ندارد(uniform)";
					num = 109;
					continue;
				case 80:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "numberasas");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 42;
						continue;
					}
					goto case 15;
				case 76:
					text += "\nفیلد ترتیب وجود ندارد(sort)";
					num = 1;
					continue;
				case 89:
					flag17 = true;
					num = 98;
					continue;
				case 40:
					text += "\nفیلد صنف وجود ندارد(Class)";
					num = 36;
					continue;
				case 61:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "code");
					num = 73;
					continue;
				case 73:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 79;
				case 70:
					flag = flag3;
					num = 114;
					continue;
				case 114:
					if (!flag)
					{
						num = 48;
						continue;
					}
					goto case 69;
				case 68:
					flag = flag4;
					num = 59;
					continue;
				case 59:
					if (!flag)
					{
						num = 76;
						continue;
					}
					goto case 1;
				case 116:
					flag19 = true;
					num = 13;
					continue;
				case 82:
					if (!flag)
					{
						num = 116;
						continue;
					}
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "mobilefather");
					num = 90;
					continue;
				case 90:
					if (!flag)
					{
						num = 94;
						continue;
					}
					goto case 6;
				case 1:
					flag = flag5;
					num = 111;
					continue;
				case 111:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 43;
				case 54:
					MessageBox.Show(text);
					num = 41;
					continue;
				case 41:
					return;
				case 6:
				case 12:
				case 13:
				case 65:
				case 74:
				case 98:
					num2++;
					num = 66;
					continue;
				case 86:
					flag7 = true;
					num = 12;
					continue;
				case 58:
					flag = flag16;
					num = 113;
					continue;
				case 113:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 75;
				case 85:
					flag = flag10;
					num = 60;
					continue;
				case 60:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 78;
				case 53:
					flag = flag7;
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 40;
						continue;
					}
					goto case 36;
				case 22:
					flag8 = true;
					num = 32;
					continue;
				case 56:
					flag4 = true;
					num = 61;
					continue;
				case 57:
					try
					{
						oleDbConnection.Open();
						oleDbConnection.Close();
					}
					catch
					{
						text2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + h.FileName + ";Extended Properties=Excel 8.0;";
					}
					oleDbDataAdapter = new OleDbDataAdapter("select top 1 * from [Sheet1$]", text2);
					dataSet = new DataSet();
					num = 10;
					continue;
				case 19:
					flag13 = true;
					num = 77;
					continue;
				case 50:
				case 66:
					flag = num2 < dataSet.Tables[0].Columns.Count;
					num = 110;
					continue;
				case 110:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "sort");
					num = 29;
					continue;
				case 106:
					text += "\nفیلد تلفن پدر وجود ندارد(MobileFather)";
					num = 96;
					continue;
				case 99:
					text += "\nفیلد ولدیت وجود ندارد(father)";
					num = 70;
					continue;
				case 18:
					text += "\nفیلد ولد وجود ندارد(famliy)";
					num = 97;
					continue;
				case 67:
					if (flag)
					{
						flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "class");
						num = 105;
					}
					else
					{
						num = 89;
					}
					continue;
				case 92:
					text += "\nفیلد نمبر اساس وجود ندارد(NumberAsas)";
					num = 58;
					continue;
				case 102:
					flag = !(text != "");
					num = 34;
					continue;
				case 34:
					if (!flag)
					{
						num = 54;
						continue;
					}
					oleDbDataAdapter = new OleDbDataAdapter("select * from [Sheet1$] where class is not null", text2);
					num = 37;
					continue;
				case 10:
					try
					{
						oleDbDataAdapter.Fill(dataSet);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
					dataSet.Tables[0].Columns.Add("acp");
					dataSet.Tables[0].Columns.Add("status");
					flag4 = false;
					flag5 = false;
					flag6 = false;
					flag7 = false;
					flag8 = false;
					flag3 = false;
					flag9 = false;
					flag10 = false;
					flag11 = false;
					flag12 = false;
					flag13 = false;
					flag14 = false;
					flag15 = false;
					flag16 = false;
					flag2 = false;
					flag17 = false;
					flag18 = false;
					flag19 = false;
					num2 = 0;
					num = 50;
					continue;
				case 29:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 61;
				case 71:
					text += "\nفیلد فیس کل شاگرد وجود ندارد(stdfeeskoll)";
					num = 112;
					continue;
				case 62:
					text += "\nفیلد پایه تحصیلی وجود ندارد(paye)";
					num = 53;
					continue;
				case 39:
					text += "\nفیلد نام وجود ندارد(Name)";
					num = 75;
					continue;
				case 33:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "name");
					num = 51;
					continue;
				case 51:
					if (flag)
					{
						flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "family");
						num = 21;
					}
					else
					{
						num = 9;
					}
					continue;
				case 2:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "exam");
					num = 63;
					continue;
				case 63:
					if (!flag)
					{
						num = 104;
						continue;
					}
					goto case 33;
				case 47:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		string text5 = default;
		int num2 = default;
		object a_18 = default;
		string text22 = default;
		bool flag = default;
		object a_20 = default;
		object a_23 = default;
		string text16 = default;
		string text6 = default;
		string text11 = default;
		int num4 = default;
		int num3 = default;
		string text12 = default;
		int num7 = default;
		string text8 = default;
		object a_25 = default;
		string a_11 = default;
		DataTable dataTable = default;
		string text20 = default;
		object a_19 = default;
		string text23 = default;
		object a_22 = default;
		SqlParameter[] array = default;
		object a_6 = default;
		object a_5 = default;
		object a_3 = default;
		object a_4 = default;
		string text21 = default;
		string text2 = default;
		string text24 = default;
		object a_7 = default;
		object a_2 = default;
		string text10 = default;
		string text19 = default;
		string text17 = default;
		object a_ = default;
		string text9 = default;
		int num10 = default;
		string text7 = default;
		string text4 = default;
		string a_17 = default;
		object a_10 = default;
		object a_24 = default;
		string text3 = default;
		string text14 = default;
		string text18 = default;
		string text13 = default;
		object a_8 = default;
		string a_12 = default;
		string a_13 = default;
		string a_14 = default;
		string a_15 = default;
		string a_16 = default;
		string text15 = default;
		string a_9 = default;
		int num6 = default;
		while (true)
		{
			string text = "";
			int num = 134;
			while (true)
			{
				int num5;
				switch (num)
				{
				case 34:
					try
					{
						int num8 = int.Parse(text5);
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «نمبر اساس» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
						goto case 12;
					}
					num = 108;
					continue;
				case 99:
					a_18 = text22;
					flag = !(text22 == "");
					num = 120;
					continue;
				case 120:
					if (!flag)
					{
						num = 190;
						continue;
					}
					goto case 105;
				case 134:
					try
					{
						while (true)
						{
							IL_0463:
							DateTime date = ShamsiDate.ShamsiToGregory(p.Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
							flag = !(shamsiDate != p.Text);
							num = 14;
							while (true)
							{
								switch (num)
								{
								case 14:
									if (!flag)
									{
										num = 7;
										continue;
									}
									text = date.DayOfWeek.ToString();
									flag = !(text == "Saturday");
									num = 0;
									continue;
								case 17:
									if (!flag)
									{
										num = 16;
										continue;
									}
									goto case 2;
								case 5:
									text = "پنج شنبه";
									num = 2;
									continue;
								case 6:
									text = "یکشنبه";
									num = 24;
									continue;
								case 16:
									text = "جمعه";
									num = 3;
									continue;
								case 19:
									if (!flag)
									{
										num = 12;
										continue;
									}
									flag = !(text == "Thursday");
									num = 21;
									continue;
								case 21:
									if (flag)
									{
										flag = !(text == "Friday");
										num = 17;
									}
									else
									{
										num = 5;
									}
									continue;
								case 15:
									if (flag)
									{
										flag = !(text == "Wednesday");
										num = 19;
									}
									else
									{
										num = 1;
									}
									continue;
								case 7:
									MessageBox.Show("تاریخ پرداخت اشتباه است");
									p.Focus();
									num = 13;
									continue;
								case 13:
									return;
								case 12:
									text = "چهارشنبه";
									num = 20;
									continue;
								case 9:
									if (flag)
									{
										flag = !(text == "Tuesday");
										num = 15;
									}
									else
									{
										num = 18;
									}
									continue;
								case 8:
									if (flag)
									{
										flag = !(text == "Monday");
										num = 9;
									}
									else
									{
										num = 6;
									}
									continue;
								case 0:
									if (flag)
									{
										flag = !(text == "Sunday");
										num = 8;
									}
									else
									{
										num = 4;
									}
									continue;
								case 1:
									text = "سه شنبه";
									num = 23;
									continue;
								case 4:
									text = "شنبه";
									num = 10;
									continue;
								case 18:
									text = "دوشنبه";
									num = 11;
									continue;
								case 2:
								case 3:
								case 10:
								case 11:
								case 20:
								case 23:
								case 24:
									num = 22;
									continue;
								case 22:
									goto end_IL_03f6;
								}
								goto IL_0463;
								continue;
								end_IL_03f6:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ پرداخت اشتباه است");
						p.Focus();
						return;
					}
					flag = m.SelectedIndex >= 1;
					num = 57;
					continue;
				case 77:
					a_20 = DBNull.Value;
					num = 74;
					continue;
				case 46:
				case 104:
					num = 30;
					continue;
				case 14:
					a_23 = DBNull.Value;
					num = 8;
					continue;
				case 73:
				case 85:
					flag = num2 < e.RowCount;
					num = 137;
					continue;
				case 137:
					if (!flag)
					{
						num = 127;
						continue;
					}
					q.PerformStep();
					text16 = asdaj.b(e.GetRow(num2).Cells["sort"].Value.ToString());
					flag = !(text16 != "");
					num = 148;
					continue;
				case 72:
					try
					{
						while (true)
						{
							IL_0880:
							int num8 = int.Parse(text6);
							num = 6;
							while (true)
							{
								int num9;
								switch (num)
								{
								case 6:
									num = ((num8 > 1) ? 5 : 0);
									continue;
								case 7:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «جنسیت» فقط اعداد بین صفر تا 1 باید باشد";
									e.GetRow(num2).EndEdit();
									num = 1;
									continue;
								case 1:
									goto end_IL_0857;
								case 5:
									num9 = 0;
									goto IL_0946;
								case 3:
									num = (flag ? 4 : 7);
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									num9 = ((num8 >= 0) ? 1 : 0);
									goto IL_0946;
								case 4:
									goto IL_27b7;
									IL_0946:
									flag = (byte)num9 != 0;
									num = 3;
									continue;
								}
								goto IL_0880;
								continue;
								end_IL_0857:
								break;
							}
							break;
						}
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «جنسیت» فقط عدد باشد صفر برای مونث و یک برای مذکر";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 92:
					num = 178;
					continue;
				case 178:
					num5 = ((!(text11 != "0")) ? 1 : 0);
					goto IL_332f;
				case 158:
				case 172:
					flag = num4 < num3;
					num = 166;
					continue;
				case 166:
					if (!flag)
					{
						num = 42;
						continue;
					}
					text22 = num4.ToString();
					num4 = 0;
					num = 23;
					continue;
				case 145:
					num = 34;
					continue;
				case 162:
				case 171:
					num = 139;
					continue;
				case 146:
					text12 = num3.ToString();
					num4 -= num3;
					num = 155;
					continue;
				case 127:
					e.Refetch();
					MessageBox.Show("تعداد " + num7 + " شاگرد انتقال یافت");
					num = 126;
					continue;
				case 126:
					return;
				case 55:
					flag = !(text8 == "0");
					num = 129;
					continue;
				case 129:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 96;
				case 64:
					a_25 = DBNull.Value;
					num = 65;
					continue;
				case 157:
					a_11 = dataTable.Rows[0]["id"].ToString();
					num = 46;
					continue;
				case 144:
					dataTable = asdcb.b(this.m_a, CommandType.Text, "select id  from  tClass where xYear=" + k.Text + " and xPaye=" + text8 + " and name=N'" + asdaj.b(e.GetRow(num2).Cells["Class"].Value.ToString()) + "'");
					flag = dataTable.Rows.Count <= 0;
					num = 70;
					continue;
				case 70:
				{
					if (!flag)
					{
						num = 157;
						continue;
					}
					int num11 = asdcb.c(this.m_a, CommandType.Text, "INSERT INTO tClass(xYear,name,xPaye,fee)\tVALUES (" + k.Text + ",N'" + asdaj.b(e.GetRow(num2).Cells["Class"].Value.ToString()) + "'," + text8 + "," + text20 + ")");
					flag = num11 >= 1;
					num = 0;
					continue;
				}
				case 105:
					a_19 = text23;
					flag = !(text23 == "");
					num = 68;
					continue;
				case 68:
					if (!flag)
					{
						num = 152;
						continue;
					}
					goto case 95;
				case 29:
					a_22 = text11;
					flag = !(text11 == "");
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 106;
						continue;
					}
					goto case 184;
				case 169:
				{
					SqlParameter[] a_21 = new SqlParameter[10]
					{
						asdcb.a("@xYear", SqlDbType.Int, k.Text),
						asdcb.a("@xStudent", SqlDbType.Int, array[0].Value),
						asdcb.a("@PaynemtDate", SqlDbType.NVarChar, p.Text),
						asdcb.a("@dayOfWeek", SqlDbType.NVarChar, text),
						asdcb.a("@Fee", SqlDbType.Int, a_6),
						asdcb.a("@Exam", SqlDbType.Int, a_22),
						asdcb.a("@uniform", SqlDbType.Int, a_5),
						asdcb.a("@dakhle", SqlDbType.Int, a_3),
						asdcb.a("@Date", SqlDbType.NVarChar, asdab.b() + "-" + asdab.c()),
						asdcb.a("@xUser", SqlDbType.Int, asdaj.l)
					};
					int num11 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tPaymentStudent_insertFromXls", a_21);
					num = 71;
					continue;
				}
				case 139:
				case 187:
					a_4 = text21;
					flag = !(text21 == "");
					num = 168;
					continue;
				case 168:
					if (!flag)
					{
						num = 175;
						continue;
					}
					goto case 97;
				case 23:
				case 116:
					flag = num4 < num3;
					num = 183;
					continue;
				case 183:
					if (!flag)
					{
						num = 153;
						continue;
					}
					text23 = num4.ToString();
					num4 = 0;
					num = 75;
					continue;
				case 152:
					a_19 = DBNull.Value;
					num = 95;
					continue;
				case 190:
					a_18 = DBNull.Value;
					num = 105;
					continue;
				case 121:
					try
					{
						while (true)
						{
							IL_0ecc:
							int num8 = int.Parse(text11);
							flag = num8 >= 0;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									num = ((!flag) ? 3 : 0);
									continue;
								case 3:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداختی امتحان» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 1;
									continue;
								case 1:
									goto end_IL_0eb3;
								case 0:
									goto IL_1a1f;
								}
								goto IL_0ecc;
								continue;
								end_IL_0eb3:
								break;
							}
							break;
						}
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداختی امتحان» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 167:
					if (!flag)
					{
						num = 54;
						continue;
					}
					return;
				case 33:
				case 35:
					text2 = asdaj.b(e.GetRow(num2).Cells["dakhele"].Value.ToString());
					flag = !(text2 != "");
					num = 52;
					continue;
				case 52:
					if (!flag)
					{
						num = 150;
						continue;
					}
					text2 = "0";
					num = 38;
					continue;
				case 111:
					num = 72;
					continue;
				case 95:
					a_23 = text24;
					flag = !(text24 == "");
					num = 109;
					continue;
				case 109:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 8;
				case 7:
					a_7 = DBNull.Value;
					num = 99;
					continue;
				case 59:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "عنوان صنف خالی است";
					e.GetRow(num2).EndEdit();
					num = 55;
					continue;
				case 148:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 189;
				case 133:
					a_3 = DBNull.Value;
					num = 169;
					continue;
				case 38:
				case 185:
					text11 = asdaj.b(e.GetRow(num2).Cells["exam"].Value.ToString());
					flag = !(text11 != "");
					num = 56;
					continue;
				case 56:
					if (flag)
					{
						text11 = "0";
						num = 173;
					}
					else
					{
						num = 170;
					}
					continue;
				case 65:
					a_2 = text10;
					flag = !(text10 == "");
					num = 141;
					continue;
				case 141:
					if (!flag)
					{
						num = 36;
						continue;
					}
					goto case 66;
				case 179:
				case 188:
					text5 = asdaj.b(e.GetRow(num2).Cells["NumberAsas"].Value.ToString());
					flag = !(text5 != "");
					num = 132;
					continue;
				case 132:
					if (!flag)
					{
						num = 145;
						continue;
					}
					goto case 108;
				case 24:
					try
					{
						long num13 = long.Parse(text19);
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "کد متعلم اشتباه است";
						e.GetRow(num2).EndEdit();
						goto case 12;
					}
					flag = !(text17 == "");
					num = 6;
					continue;
				case 66:
					a_ = text9;
					flag = !(text9 == "");
					num = 115;
					continue;
				case 115:
					if (!flag)
					{
						num = 37;
						continue;
					}
					goto case 182;
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 151;
						continue;
					}
					a_11 = asdcb.a(this.m_a, CommandType.Text, "select max(id) from tclass").ToString();
					num = 104;
					continue;
				case 106:
					a_22 = DBNull.Value;
					num = 184;
					continue;
				case 75:
				case 79:
					text24 = num4.ToString();
					num = 162;
					continue;
				case 97:
					a_20 = text12;
					flag = !(text12 == "");
					num = 53;
					continue;
				case 53:
					if (!flag)
					{
						num = 77;
						continue;
					}
					goto case 74;
				case 13:
					num = 135;
					continue;
				case 2:
					text21 = num10.ToString();
					text12 = num10.ToString();
					text7 = num10.ToString();
					text10 = num10.ToString();
					text9 = num10.ToString();
					text4 = num10.ToString();
					text22 = num10.ToString();
					text23 = num10.ToString();
					text24 = num10.ToString();
					a_17 = "0";
					num = 187;
					continue;
				case 123:
					a_10 = text5;
					flag = !(text5 == "");
					num = 51;
					continue;
				case 51:
					if (!flag)
					{
						num = 112;
						continue;
					}
					goto case 191;
				case 186:
					if (!flag)
					{
						num = 2;
						continue;
					}
					a_17 = m.SelectedValue.ToString();
					flag = num4 != 0;
					num = 91;
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_1878:
							int num8 = int.Parse(text8);
							num = 0;
							while (true)
							{
								int num12;
								switch (num)
								{
								case 0:
									num = ((num8 > 12) ? 5 : 7);
									continue;
								case 5:
									num12 = 0;
									goto IL_1954;
								case 3:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «پایه تحصیلی» فقط اعداد بین صفر تا 12 باید باشد";
									e.GetRow(num2).EndEdit();
									num = 4;
									continue;
								case 4:
									goto end_IL_184f;
								case 7:
									num = 2;
									continue;
								case 2:
									num12 = ((num8 >= 0) ? 1 : 0);
									goto IL_1954;
								case 1:
									num = (flag ? 6 : 3);
									continue;
								case 6:
									goto IL_2f90;
									IL_1954:
									flag = (byte)num12 != 0;
									num = 1;
									continue;
								}
								goto IL_1878;
								continue;
								end_IL_184f:
								break;
							}
							break;
						}
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «پایه تحصیلی» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 40:
					if (!flag)
					{
						num = 11;
						continue;
					}
					text21 = num4.ToString();
					num4 = 0;
					num = 86;
					continue;
				case 191:
					a_24 = text16;
					flag = !(text16 == "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 58;
				case 12:
				case 15:
				case 18:
				case 49:
				case 84:
				case 90:
				case 103:
				case 130:
				case 163:
					num2++;
					num = 85;
					continue;
				case 47:
					text9 = num3.ToString();
					num4 -= num3;
					num = 87;
					continue;
				case 16:
					a_24 = DBNull.Value;
					num = 58;
					continue;
				case 10:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "نمبر اساس تکراری است";
					e.GetRow(num2).EndEdit();
					num = 103;
					continue;
				case 101:
					text21 = "0";
					text12 = "0";
					text7 = "0";
					text10 = "0";
					text9 = "0";
					text4 = "0";
					text22 = "0";
					text23 = "0";
					text24 = "0";
					num = 171;
					continue;
				case 61:
				case 155:
					flag = num4 < num3;
					num = 117;
					continue;
				case 117:
					if (flag)
					{
						text7 = num4.ToString();
						num4 = 0;
						num = 110;
					}
					else
					{
						num = 31;
					}
					continue;
				case 108:
					text3 = asdaj.b(e.GetRow(num2).Cells["Stdfees"].Value.ToString());
					flag = !(text3 == "");
					num = 159;
					continue;
				case 159:
					num = (flag ? 94 : 118);
					continue;
				case 142:
					try
					{
						while (true)
						{
							IL_1c85:
							int num8 = int.Parse(text14);
							flag = num8 >= 0;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									num4 = num8;
									num = 1;
									continue;
								case 3:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «فیس کل شاگرد» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 0;
									continue;
								case 0:
									goto end_IL_1c6c;
								case 1:
									goto IL_21a1;
								}
								goto IL_1c85;
								continue;
								end_IL_1c6c:
								break;
							}
							break;
						}
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «فیس کل شاگرد» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 71:
					num = 1;
					continue;
				case 42:
					text22 = num3.ToString();
					num4 -= num3;
					num = 116;
					continue;
				case 96:
					flag = !(text18 != text17);
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 144;
						continue;
					}
					goto case 30;
				case 88:
					try
					{
						while (true)
						{
							IL_1e5d:
							int num8 = int.Parse(text20);
							flag = num8 >= 0;
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 0;
										continue;
									}
									num10 = num8;
									num = 2;
									continue;
								case 0:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «فیس اصلی صنف» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 3;
									continue;
								case 3:
									goto end_IL_1e44;
								case 2:
									goto IL_3713;
								}
								goto IL_1e5d;
								continue;
								end_IL_1e44:
								break;
							}
							break;
						}
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «فیس اصلی صنف» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 122:
					MessageBox.Show("نوع نخفیف را مشخص کنید");
					p.Focus();
					num = 3;
					continue;
				case 3:
					return;
				case 182:
					a_7 = text4;
					flag = !(text4 == "");
					num = 176;
					continue;
				case 176:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 99;
				case 91:
					if (flag)
					{
						flag = num4 < num3;
						num = 40;
					}
					else
					{
						num = 101;
					}
					continue;
				case 150:
					num = 45;
					continue;
				case 136:
					a_6 = text13;
					flag = !(text13 == "0");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 149;
						continue;
					}
					goto case 29;
				case 11:
					text21 = num3.ToString();
					num4 -= num3;
					num = 60;
					continue;
				case 87:
				case 147:
					flag = num4 < num3;
					num = 124;
					continue;
				case 124:
					if (!flag)
					{
						num = 83;
						continue;
					}
					text4 = num4.ToString();
					num4 = 0;
					num = 172;
					continue;
				case 100:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "فیلد «فیس کل شاگرد» خالی است";
					e.GetRow(num2).EndEdit();
					num = 163;
					continue;
				case 180:
					if (flag)
					{
						text13 = "0";
						num = 33;
					}
					else
					{
						num = 89;
					}
					continue;
				case 19:
					a_8 = DBNull.Value;
					num = 123;
					continue;
				case 82:
					try
					{
						while (true)
						{
							IL_225f:
							int num8 = int.Parse(text13);
							flag = num8 >= 0;
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 1:
									goto end_IL_2246;
								case 3:
									num = (flag ? 1 : 0);
									continue;
								case 0:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداخت شده فیس» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 2;
									continue;
								case 2:
									goto end_IL_2244;
								}
								goto IL_225f;
								continue;
								end_IL_2246:
								break;
							}
							break;
						}
						goto IL_1a0a;
						end_IL_2244:;
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداخت شده فیس» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 161:
					num = ((!flag) ? 100 : 142);
					continue;
				case 94:
					try
					{
						while (true)
						{
							IL_242c:
							int num8 = int.Parse(text3);
							flag = num8 >= 0;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 3:
									goto end_IL_2413;
								case 2:
									if (!flag)
									{
										num = 0;
										continue;
									}
									num3 = num8;
									num = 3;
									continue;
								case 0:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «فیس ماهانه شاگرد» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 1;
									continue;
								case 1:
									goto end_IL_2411;
								}
								goto IL_242c;
								continue;
								end_IL_2413:
								break;
							}
							break;
						}
						goto IL_23a9;
						end_IL_2411:;
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «فیس ماهانه شاگرد» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 153:
					text23 = num3.ToString();
					num4 -= num3;
					num = 79;
					continue;
				case 39:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "کد متعلم خالی است";
					e.GetRow(num2).EndEdit();
					num = 130;
					continue;
				case 8:
					a_8 = text14;
					flag = !(text14 == "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 123;
				case 30:
				{
					text18 = text17;
					string text25 = asdcb.a(this.m_a, CommandType.Text, "select Count(id) from tStudent where code=" + text19).ToString();
					flag = !(text25 != "0");
					num = 81;
					continue;
				}
				case 81:
					if (flag)
					{
						a_12 = asdaj.b(e.GetRow(num2).Cells["Name"].Value.ToString());
						a_13 = asdaj.b(e.GetRow(num2).Cells["Family"].Value.ToString());
						a_14 = asdaj.b(e.GetRow(num2).Cells["Father"].Value.ToString());
						a_15 = e.GetRow(num2).Cells["MobileFather"].Value.ToString();
						a_16 = e.GetRow(num2).Cells["MobileMother"].Value.ToString();
						text21 = "";
						text12 = "";
						text7 = "";
						text10 = "";
						text9 = "";
						text4 = "";
						text22 = "";
						text23 = "";
						text24 = "";
						flag = num4 != num10 * 9;
						num = 186;
					}
					else
					{
						num = 128;
					}
					continue;
				case 107:
				case 174:
					flag = num4 < num3;
					num = 50;
					continue;
				case 50:
					if (flag)
					{
						text9 = num4.ToString();
						num4 = 0;
						num = 147;
					}
					else
					{
						num = 47;
					}
					continue;
				case 128:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "کد متعلم تکراری است";
					e.GetRow(num2).EndEdit();
					num = 84;
					continue;
				case 93:
					num = 113;
					continue;
				case 113:
					if (!(text15 != "0"))
					{
						num = 92;
						continue;
					}
					goto IL_35fd;
				case 76:
				case 114:
					text17 = asdaj.b(e.GetRow(num2).Cells["Class"].Value.ToString());
					text19 = asdaj.b(e.GetRow(num2).Cells["Code"].Value.ToString());
					flag = !(text19 == "");
					num = 28;
					continue;
				case 28:
					num = (flag ? 24 : 39);
					continue;
				case 54:
					text17 = "";
					text18 = "000";
					a_11 = "";
					text19 = "";
					a_12 = "";
					a_13 = "";
					a_14 = "";
					a_15 = "";
					a_16 = "";
					text16 = "";
					text8 = "";
					text20 = "";
					num10 = 0;
					text6 = "";
					text5 = "";
					text3 = "";
					num3 = 0;
					text14 = "";
					num4 = 0;
					text13 = "";
					text2 = "";
					text11 = "";
					text15 = "";
					a_17 = "0";
					text21 = "";
					text12 = "";
					text7 = "";
					text10 = "";
					text9 = "";
					text4 = "";
					text22 = "";
					text23 = "";
					text24 = "";
					num7 = 0;
					num2 = 0;
					num = 73;
					continue;
				case 112:
					a_10 = DBNull.Value;
					num = 191;
					continue;
				case 57:
					if (flag)
					{
						a_9 = k.Text + "/01/01";
						q.Maximum = e.RowCount;
						q.Step = 1;
						q.Value = 0;
						flag = MessageBox.Show("آيا از انتقال مطمئن هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 167;
					}
					else
					{
						num = 122;
					}
					continue;
				case 170:
					num = 121;
					continue;
				case 135:
					try
					{
						int num8 = int.Parse(text16);
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «ترتیب» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
						goto case 12;
					}
					num = 189;
					continue;
				case 1:
				case 43:
					num = 18;
					continue;
				case 58:
					array = new SqlParameter[25]
					{
						asdcb.a("@CodeOut", SqlDbType.Int),
						asdcb.a("@xYear", SqlDbType.Int, k.Text),
						asdcb.a("@xpaye", SqlDbType.Int, text8),
						asdcb.a("@xClass", SqlDbType.Int, a_11),
						asdcb.a("@Code", SqlDbType.BigInt, text19),
						asdcb.a("@FName", SqlDbType.NVarChar, a_12),
						asdcb.a("@LName", SqlDbType.NVarChar, a_13),
						asdcb.a("@PName", SqlDbType.NVarChar, a_14),
						asdcb.a("@MobileFather", SqlDbType.NVarChar, a_15),
						asdcb.a("@MobileMother", SqlDbType.NVarChar, a_16),
						asdcb.a("@Jens", SqlDbType.SmallInt, text6),
						asdcb.a("@NumberAsas", SqlDbType.Int, a_10),
						asdcb.a("@Sort", SqlDbType.Int, a_24),
						asdcb.a("@RegDate", SqlDbType.NVarChar, a_9),
						asdcb.a("@Fee1", SqlDbType.Int, a_4),
						asdcb.a("@Fee2", SqlDbType.Int, a_20),
						asdcb.a("@Fee3", SqlDbType.Int, a_25),
						asdcb.a("@Fee4", SqlDbType.Int, a_2),
						asdcb.a("@Fee5", SqlDbType.Int, a_),
						asdcb.a("@Fee6", SqlDbType.Int, a_7),
						asdcb.a("@Fee7", SqlDbType.Int, a_18),
						asdcb.a("@Fee8", SqlDbType.Int, a_19),
						asdcb.a("@Fee9", SqlDbType.Int, a_23),
						asdcb.a("@SumFee", SqlDbType.Int, a_8),
						asdcb.a("@xTakhfif", SqlDbType.Int, a_17)
					};
					num6 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tStudent_insert_FromXls", array);
					flag = !(array[0].Value.ToString() == "-100");
					num = 160;
					continue;
				case 160:
					if (!flag)
					{
						num = 138;
						continue;
					}
					flag = !(array[0].Value.ToString() == "-200");
					num = 78;
					continue;
				case 44:
				case 173:
					text15 = asdaj.b(e.GetRow(num2).Cells["uniform"].Value.ToString());
					flag = !(text15 != "");
					num = 156;
					continue;
				case 156:
					if (flag)
					{
						text15 = "0";
						num = 114;
					}
					else
					{
						num = 165;
					}
					continue;
				case 27:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "فیلد «فیس اصلی صنف» خالی است";
					e.GetRow(num2).EndEdit();
					num = 15;
					continue;
				case 89:
					num = 82;
					continue;
				case 48:
					try
					{
						while (true)
						{
							IL_2e02:
							int num8 = int.Parse(text15);
							flag = num8 >= 0;
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 0:
									goto end_IL_2de9;
								case 1:
									num = ((!flag) ? 2 : 0);
									continue;
								case 2:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداختی لباس» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 3;
									continue;
								case 3:
									goto end_IL_2de7;
								}
								goto IL_2e02;
								continue;
								end_IL_2de9:
								break;
							}
							break;
						}
						goto IL_1464;
						end_IL_2de7:;
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداختی لباس» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 69:
				case 110:
					flag = num4 < num3;
					num = 119;
					continue;
				case 119:
					if (flag)
					{
						text10 = num4.ToString();
						num4 = 0;
						num = 107;
					}
					else
					{
						num = 80;
					}
					continue;
				case 17:
					num = (flag ? 88 : 27);
					continue;
				case 149:
					a_6 = DBNull.Value;
					num = 29;
					continue;
				case 45:
					try
					{
						while (true)
						{
							IL_302d:
							int num8 = int.Parse(text2);
							flag = num8 >= 0;
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 0:
									goto end_IL_3014;
								case 1:
									num = ((!flag) ? 2 : 0);
									continue;
								case 2:
									e.GetRow(num2).BeginEdit();
									e.GetRow(num2).Cells["acp"].Value = "-1";
									e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداختی داخله» نباید منفی باشد";
									e.GetRow(num2).EndEdit();
									num = 3;
									continue;
								case 3:
									goto end_IL_3012;
								}
								goto IL_302d;
								continue;
								end_IL_3014:
								break;
							}
							break;
						}
						goto IL_109f;
						end_IL_3012:;
					}
					catch
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "فیلد «مبلغ پرداختی داخله» فقط عدد باشد";
						e.GetRow(num2).EndEdit();
					}
					goto case 12;
				case 25:
					a_5 = DBNull.Value;
					num = 5;
					continue;
				case 143:
					num7++;
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "1";
					e.GetRow(num2).Cells["status"].Value = "ثبت شد";
					e.GetRow(num2).EndEdit();
					num = 164;
					continue;
				case 164:
					if (!(text13 != "0"))
					{
						num = 177;
						continue;
					}
					goto IL_35fd;
				case 41:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "فیلد «پایه تحصیلی» خالی است";
					e.GetRow(num2).EndEdit();
					num = 49;
					continue;
				case 175:
					a_4 = DBNull.Value;
					num = 97;
					continue;
				case 165:
					num = 48;
					continue;
				case 181:
					if (!flag)
					{
						num = 136;
						continue;
					}
					goto case 71;
				case 78:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = num6 <= 0;
					num = 63;
					continue;
				case 37:
					a_ = DBNull.Value;
					num = 182;
					continue;
				case 60:
				case 86:
					flag = num4 < num3;
					num = 131;
					continue;
				case 131:
					if (!flag)
					{
						num = 146;
						continue;
					}
					text12 = num4.ToString();
					num4 = 0;
					num = 61;
					continue;
				case 5:
					a_3 = text2;
					flag = !(text2 == "");
					num = 154;
					continue;
				case 154:
					if (!flag)
					{
						num = 133;
						continue;
					}
					goto case 169;
				case 80:
					text10 = num3.ToString();
					num4 -= num3;
					num = 174;
					continue;
				case 184:
					a_5 = text15;
					flag = !(text15 == "");
					num = 140;
					continue;
				case 140:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 5;
				case 36:
					a_2 = DBNull.Value;
					num = 66;
					continue;
				case 189:
					text8 = asdaj.b(e.GetRow(num2).Cells["paye"].Value.ToString());
					flag = !(text8 == "");
					num = 192;
					continue;
				case 192:
					num = ((!flag) ? 41 : 4);
					continue;
				case 6:
					if (!flag)
					{
						num = 59;
						continue;
					}
					goto case 55;
				case 118:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "فیلد «فیس ماهانه شاگرد» خالی است";
					e.GetRow(num2).EndEdit();
					num = 90;
					continue;
				case 125:
					num5 = 0;
					goto IL_332f;
				case 138:
					e.GetRow(num2).BeginEdit();
					e.GetRow(num2).Cells["acp"].Value = "-1";
					e.GetRow(num2).Cells["status"].Value = "کد متعلم تکراری است";
					e.GetRow(num2).EndEdit();
					num = 12;
					continue;
				case 22:
					text8 = "100";
					num = 96;
					continue;
				case 31:
					text7 = num3.ToString();
					num4 -= num3;
					num = 69;
					continue;
				case 62:
					if (flag)
					{
						text6 = "-1";
						num = 179;
					}
					else
					{
						num = 111;
					}
					continue;
				case 74:
					a_25 = text7;
					flag = !(text7 == "");
					num = 98;
					continue;
				case 98:
					if (!flag)
					{
						num = 64;
						continue;
					}
					goto case 65;
				case 83:
					text4 = num3.ToString();
					num4 -= num3;
					num = 158;
					continue;
				case 63:
					if (flag)
					{
						e.GetRow(num2).BeginEdit();
						e.GetRow(num2).Cells["acp"].Value = "-1";
						e.GetRow(num2).Cells["status"].Value = "خطا";
						e.GetRow(num2).EndEdit();
						num = 43;
					}
					else
					{
						num = 143;
					}
					continue;
				case 151:
					MessageBox.Show("خطا در ایجاد صنف");
					num = 102;
					continue;
				case 102:
					return;
				case 177:
					num = 67;
					continue;
				case 67:
					{
						if (!(text2 != "0"))
						{
							num = 93;
							continue;
						}
						goto IL_35fd;
					}
					IL_332f:
					flag = (byte)num5 != 0;
					num = 181;
					continue;
					IL_109f:
					num = 185;
					continue;
					IL_1464:
					num = 76;
					continue;
					IL_27b7:
					num = 188;
					continue;
					IL_1a1f:
					num = 44;
					continue;
					IL_35fd:
					num = 125;
					continue;
					IL_23a9:
					text14 = asdaj.b(e.GetRow(num2).Cells["stdfeeskoll"].Value.ToString());
					flag = !(text14 == "");
					num = 161;
					continue;
					IL_1a0a:
					num = 35;
					continue;
					IL_3713:
					text6 = asdaj.b(e.GetRow(num2).Cells["jens"].Value.ToString());
					flag = !(text6 != "");
					num = 62;
					continue;
					IL_21a1:
					text13 = asdaj.b(e.GetRow(num2).Cells["payment"].Value.ToString());
					flag = !(text13 != "");
					num = 180;
					continue;
					IL_2f90:
					text20 = asdaj.b(e.GetRow(num2).Cells["MainFees"].Value.ToString());
					flag = !(text20 == "");
					num = 17;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					b();
					k.Text = asdaj.__field_a;
					p.Text = asdab.b();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 6:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto IL_0155;
				case 1:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					if (1 == 0)
					{
					}
					goto IL_0155;
				case 3:
					{
						num = 6;
						continue;
					}
					IL_0155:
					i.Text = Application.StartupPath + "\\xls\\Example.xls";
					h.FileName = i.Text;
					num = 1;
					continue;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from ttakhfif order by name");
		m.DataSource = dataSource;
		m.DisplayMember = "Name";
		m.ValueMember = "id";
		m.SelectedIndex = 0;
	}
protected override void Dispose(bool A_0)
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
					num = ((!A_0) ? 4 : 6);
					continue;
				case 6:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 3:
					this.m_b.Dispose();
					num = 2;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 2;
				case 4:
					num2 = 1;
					goto IL_0074;
				case 2:
					{
						base.Dispose(A_0);
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
		if (true)
		{
		}
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb7));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_c = new Panel();
		q = new ProgressBar();
		o = new Label();
		p = new MaskedEditBox();
		m = new UIComboBox();
		n = new Label();
		k = new Label();
		l = new Label();
		j = new Label();
		i = new TextBox();
		g = new Button();
		f = new Button();
		this.m_d = new UIButton();
		e = new GridEX();
		h = new OpenFileDialog();
		this.m_c.SuspendLayout();
		((ISupportInitialize)e).BeginInit();
		SuspendLayout();
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(q);
		this.m_c.Controls.Add(o);
		this.m_c.Controls.Add(p);
		this.m_c.Controls.Add(m);
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(f);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(e);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Font = new Font("Tahoma", 8.25f);
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(800, 600);
		this.m_c.TabIndex = 0;
		q.Location = new Point(11, 480);
		q.Name = "progressBar1";
		q.Size = new Size(475, 23);
		q.TabIndex = 129;
		o.AutoSize = true;
		o.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Location = new Point(696, 510);
		o.Name = "label12";
		o.Size = new Size(85, 13);
		o.TabIndex = 128;
		o.Text = "تاریخ پرداخت ها :";
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Location = new Point(602, 506);
		p.Mask = "0000/00/00";
		p.MaxLength = 12;
		p.Name = "txtPaynemtDate";
		p.Numeric = true;
		p.RightToLeft = RightToLeft.No;
		p.Size = new Size(86, 22);
		p.TabIndex = 127;
		p.Tag = "";
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.DropListFont = new Font("B Nazanin", 12f);
		m.Location = new Point(532, 480);
		m.Name = "comboTakhfif";
		m.Size = new Size(156, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		m.StringFormat = stringFormat;
		m.TabIndex = 125;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.AutoSize = true;
		n.Location = new Point(694, 486);
		n.Name = "label40";
		n.Size = new Size(37, 13);
		n.TabIndex = 126;
		n.Text = "تخفیف";
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Location = new Point(621, 8);
		k.Name = "lYear";
		k.Size = new Size(55, 24);
		k.TabIndex = 118;
		l.AutoSize = true;
		l.Location = new Point(683, 12);
		l.Name = "label3";
		l.Size = new Size(66, 13);
		l.TabIndex = 117;
		l.Text = "سال تعلیمی";
		j.AutoSize = true;
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j.ForeColor = Color.Red;
		j.Location = new Point(170, 45);
		j.Name = "label1";
		j.Size = new Size(279, 16);
		j.TabIndex = 43;
		j.Text = "نمونه فایل اکسل در مسیر زیر موجود میباشد";
		i.Location = new Point(12, 67);
		i.Name = "txtExam";
		i.ReadOnly = true;
		i.RightToLeft = RightToLeft.No;
		i.Size = new Size(440, 21);
		i.TabIndex = 40;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.Location = new Point(575, 48);
		g.Name = "BtnNew";
		g.Size = new Size(197, 35);
		g.TabIndex = 19;
		g.Text = "انتخاب فایل اکسل";
		g.UseVisualStyleBackColor = true;
		g.Click += c;
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		f.Location = new Point(532, 535);
		f.Name = "btnAcp";
		f.Size = new Size(156, 35);
		f.TabIndex = 18;
		f.Text = "ثبت";
		f.UseVisualStyleBackColor = true;
		f.Click += b;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		this.m_d.Location = new Point(11, 535);
		this.m_d.Name = "btnClose";
		this.m_d.Size = new Size(189, 35);
		this.m_d.TabIndex = 1;
		this.m_d.Text = "بستن";
		this.m_d.Click += d;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		e.DesignTimeLayout = gridEXLayout;
		e.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		e.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		e.Font = new Font("Tahoma", 8.25f);
		e.Location = new Point(8, 99);
		e.Name = "gridEX1";
		e.RecordNavigator = true;
		e.RowHeaders = InheritableBoolean.True;
		e.SelectedFormatStyle.BackColor = Color.Empty;
		e.SelectedFormatStyle.ForeColor = Color.Empty;
		e.Size = new Size(782, 371);
		e.TabIndex = 5;
		e.VisualStyle = VisualStyle.Office2003;
		h.Filter = "اکسل 2003 |*.xls";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_c);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmImportStd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت شاگردان از فایل اکسل";
		Load += a;
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)e).EndInit();
		ResumeLayout(performLayout: false);
	}
}
