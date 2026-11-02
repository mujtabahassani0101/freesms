using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdba : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private bool m_b;

	private IContainer m_c = null;

	private Panel m_d;

	private Panel m_e;

	private Panel m_f;

	private UIButton g;

	private UIComboBox h;

	private Label i;

	private Label j;

	private Label k;

	private UIButton l;

	private Label m;

	private MaskedEditBox n;

	private Label o;

	private Label p;

	private Label q;

	private MaskedEditBox r;

	private MaskedEditBox s;

	private MaskedEditBox t;

	private MaskedEditBox u;

	private MaskedEditBox v;

	private MaskedEditBox w;

	private MaskedEditBox x;

	private MaskedEditBox y;

	private MaskedEditBox z;

	private MaskedEditBox aa;

	private MaskedEditBox ab;

	private MaskedEditBox ac;

	private MaskedEditBox ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private MaskedEditBox al;

	public asdba()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		a();
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 1;
					continue;
				case 5:
					try
					{
						h.SelectedIndex = 0;
						b();
					}
					catch
					{
					}
					((Control)n).Focus();
					((Control)n).Focus();
					num = 6;
					continue;
				case 1:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 7;
				case 4:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					this.m_b = true;
					((Control)j).Text = asdaj.a;
					c();
					num = 5;
					continue;
				case 6:
					return;
				case 0:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_f).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 7;
					continue;
				case 8:
					num = 0;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + ((Control)j).Text + " and xPaye in(" + asdaj.n + ") order by xpaye,sortRpt");
		h.DataSource = dataSource;
		h.DisplayMember = "Name";
		h.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where id=" + h.SelectedValue.ToString());
		((Control)ad).Text = dataTable.Rows[0]["countAbsent1"].ToString();
		((Control)w).Text = dataTable.Rows[0]["countAbsent2"].ToString();
		((Control)u).Text = dataTable.Rows[0]["countAcp1"].ToString();
		((Control)aa).Text = dataTable.Rows[0]["countAcp2"].ToString();
		((Control)n).Text = dataTable.Rows[0]["countDakhele1"].ToString();
		((Control)ac).Text = dataTable.Rows[0]["countDakhele2"].ToString();
		((Control)v).Text = dataTable.Rows[0]["countExam1"].ToString();
		((Control)ab).Text = dataTable.Rows[0]["countExam2"].ToString();
		((Control)s).Text = dataTable.Rows[0]["countMashrot1"].ToString();
		((Control)y).Text = dataTable.Rows[0]["countMashrot2"].ToString();
		((Control)r).Text = dataTable.Rows[0]["countMazerati1"].ToString();
		((Control)x).Text = dataTable.Rows[0]["countMazerati2"].ToString();
		((Control)t).Text = dataTable.Rows[0]["countNoAcp1"].ToString();
		((Control)z).Text = dataTable.Rows[0]["countNoAcp2"].ToString();
		((Control)al).Text = dataTable.Rows[0]["Separcheh"].ToString();
		((Control)n).Focus();
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		object a_3 = default;
		object a_12 = default;
		object a_7 = default;
		object a_14 = default;
		object a_6 = default;
		object a_15 = default;
		object a_8 = default;
		object a_16 = default;
		object a_10 = default;
		object a_9 = default;
		object a_13 = default;
		object a_2 = default;
		object a_5 = default;
		object a_11 = default;
		while (true)
		{
			object a_ = ((Control)ad).Text;
			bool flag = !(((Control)ad).Text.Trim() == "");
			int num = 37;
			while (true)
			{
				switch (num)
				{
				case 37:
					if (!flag)
					{
						num = 28;
						continue;
					}
					goto case 6;
				case 35:
					a_3 = DBNull.Value;
					num = 39;
					continue;
				case 32:
					a_12 = DBNull.Value;
					num = 3;
					continue;
				case 33:
					a_7 = ((Control)aa).Text;
					flag = !(((Control)aa).Text.Trim() == "");
					num = 40;
					continue;
				case 40:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 31;
				case 7:
					a_14 = DBNull.Value;
					num = 12;
					continue;
				case 15:
					a_6 = ((Control)u).Text;
					flag = !(((Control)u).Text.Trim() == "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 33;
				case 0:
					a_3 = ((Control)r).Text;
					flag = !(((Control)r).Text.Trim() == "");
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 35;
						continue;
					}
					goto case 39;
				case 43:
					a_15 = DBNull.Value;
					num = 41;
					continue;
				case 29:
					a_12 = ((Control)s).Text;
					flag = !(((Control)s).Text.Trim() == "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 3;
				case 31:
					a_8 = ((Control)n).Text;
					flag = !(((Control)n).Text.Trim() == "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 20;
				case 12:
					a_15 = ((Control)z).Text;
					flag = !(((Control)z).Text.Trim() == "");
					num = 38;
					continue;
				case 38:
					if (!flag)
					{
						num = 43;
						continue;
					}
					goto case 41;
				case 5:
					a_16 = DBNull.Value;
					num = 30;
					continue;
				case 10:
					a_10 = ((Control)v).Text;
					flag = !(((Control)v).Text.Trim() == "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 25;
				case 28:
					a_ = DBNull.Value;
					num = 6;
					continue;
				case 2:
					a_7 = DBNull.Value;
					num = 31;
					continue;
				case 24:
					a_6 = DBNull.Value;
					num = 33;
					continue;
				case 20:
					a_9 = ((Control)ac).Text;
					flag = !(((Control)ac).Text.Trim() == "");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 10;
				case 8:
					a_14 = ((Control)t).Text;
					flag = !(((Control)t).Text.Trim() == "");
					num = 42;
					continue;
				case 42:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 12;
				case 39:
					a_13 = ((Control)x).Text;
					flag = !(((Control)x).Text.Trim() == "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 8;
				case 26:
					a_10 = DBNull.Value;
					num = 25;
					continue;
				case 9:
					if (true)
					{
					}
					a_9 = DBNull.Value;
					num = 10;
					continue;
				case 3:
					a_2 = ((Control)y).Text;
					flag = !(((Control)y).Text.Trim() == "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 27;
						continue;
					}
					goto case 0;
				case 19:
					a_8 = DBNull.Value;
					num = 20;
					continue;
				case 11:
					a_5 = DBNull.Value;
					num = 15;
					continue;
				case 17:
					a_13 = DBNull.Value;
					num = 8;
					continue;
				case 25:
					a_11 = ((Control)ab).Text;
					flag = !(((Control)ab).Text.Trim() == "");
					num = 34;
					continue;
				case 34:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 29;
				case 14:
					a_11 = DBNull.Value;
					num = 29;
					continue;
				case 6:
					a_5 = ((Control)w).Text;
					flag = !(((Control)w).Text.Trim() == "");
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 15;
				case 41:
					a_16 = ((Control)al).Text;
					flag = !(((Control)al).Text.Trim() == "");
					num = 44;
					continue;
				case 44:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 30;
				case 27:
					a_2 = DBNull.Value;
					num = 0;
					continue;
				case 30:
				{
					SqlParameter[] a_4 = new SqlParameter[16]
					{
						asdcb.a("@id", SqlDbType.Int, h.SelectedValue.ToString()),
						asdcb.a("@countAbsent1", SqlDbType.SmallInt, a_),
						asdcb.a("@countAbsent2", SqlDbType.SmallInt, a_5),
						asdcb.a("@countAcp1", SqlDbType.SmallInt, a_6),
						asdcb.a("@countAcp2", SqlDbType.SmallInt, a_7),
						asdcb.a("@countDakhele1", SqlDbType.SmallInt, a_8),
						asdcb.a("@countDakhele2", SqlDbType.SmallInt, a_9),
						asdcb.a("@countExam1", SqlDbType.SmallInt, a_10),
						asdcb.a("@countExam2", SqlDbType.SmallInt, a_11),
						asdcb.a("@countMashrot1", SqlDbType.SmallInt, a_12),
						asdcb.a("@countMashrot2", SqlDbType.SmallInt, a_2),
						asdcb.a("@countMazerati1", SqlDbType.SmallInt, a_3),
						asdcb.a("@countMazerati2", SqlDbType.SmallInt, a_13),
						asdcb.a("@countNoAcp1", SqlDbType.SmallInt, a_14),
						asdcb.a("@countNoAcp2", SqlDbType.SmallInt, a_15),
						asdcb.a("@Separcheh", SqlDbType.SmallInt, a_16)
					};
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE    tClass\r\n                SET  countDakhele1 =@countDakhele1 , countDakhele2 =@countDakhele2 , countExam1 =@countExam1 ,\r\n                 countExam2 =@countExam2 , countAcp1 =@countAcp1 ,\r\n                 countAcp2 =@countAcp2 , countNoAcp1 =@countNoAcp1 ,\r\n                 countNoAcp2 =@countNoAcp2 , countMashrot1 =@countMashrot1 ,\r\n                 countMashrot2 =@countMashrot2 ,countMazerati1 =@countMazerati1 , \r\n                 countMazerati2 =@countMazerati2 , countAbsent1 =@countAbsent1 , countAbsent2 =@countAbsent2, Separcheh =@Separcheh\r\n                    WHERE     (id = @id)", a_4);
					MessageBox.Show("ثبت شد");
					((UIComboBase)h).Focus();
					return;
				}
				}
				break;
			}
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)A_1.KeyCode != 116;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					c(this, null);
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (true)
		{
		}
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromName("Window");
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 13;
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
					SendKeys.Send("{tab}");
					num = 1;
					continue;
				case 1:
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
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					if (true)
					{
					}
					num = ((!A_0) ? 1 : 3);
					continue;
				case 3:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_c == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_c.Dispose();
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
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
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected Obj, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected Obj, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected Obj, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected Obj, but got Unknown
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected Obj, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected Obj, but got Unknown
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f39: Expected Obj, but got Unknown
		//IL_0f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected Obj, but got Unknown
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Expected Obj, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Expected Obj, but got Unknown
		//IL_11af: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b9: Expected Obj, but got Unknown
		//IL_1217: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected Obj, but got Unknown
		//IL_12f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Expected Obj, but got Unknown
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1364: Expected Obj, but got Unknown
		//IL_1435: Unknown result type (might be due to invalid IL or missing references)
		//IL_143f: Expected Obj, but got Unknown
		//IL_149d: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a7: Expected Obj, but got Unknown
		//IL_1578: Unknown result type (might be due to invalid IL or missing references)
		//IL_1582: Expected Obj, but got Unknown
		//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Expected Obj, but got Unknown
		//IL_16bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c5: Expected Obj, but got Unknown
		//IL_1723: Unknown result type (might be due to invalid IL or missing references)
		//IL_172d: Expected Obj, but got Unknown
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected Obj, but got Unknown
		//IL_1866: Unknown result type (might be due to invalid IL or missing references)
		//IL_1870: Expected Obj, but got Unknown
		//IL_1941: Unknown result type (might be due to invalid IL or missing references)
		//IL_194b: Expected Obj, but got Unknown
		//IL_1aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af7: Expected Obj, but got Unknown
		//IL_1bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd2: Expected Obj, but got Unknown
		//IL_1bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c01: Expected Obj, but got Unknown
		//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca0: Expected Obj, but got Unknown
		//IL_1cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbc: Expected Obj, but got Unknown
		//IL_1e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e50: Expected Obj, but got Unknown
		//IL_1f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8d: Expected Obj, but got Unknown
		//IL_20e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f2: Expected Obj, but got Unknown
		//IL_2228: Unknown result type (might be due to invalid IL or missing references)
		//IL_2232: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdba));
		StringFormat val = new StringFormat();
		this.m_d = new Panel();
		this.m_e = new Panel();
		this.m_f = new Panel();
		af = new Label();
		ag = new Label();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ae = new Label();
		w = new MaskedEditBox();
		x = new MaskedEditBox();
		y = new MaskedEditBox();
		z = new MaskedEditBox();
		aa = new MaskedEditBox();
		ab = new MaskedEditBox();
		ac = new MaskedEditBox();
		ad = new MaskedEditBox();
		r = new MaskedEditBox();
		s = new MaskedEditBox();
		t = new MaskedEditBox();
		u = new MaskedEditBox();
		v = new MaskedEditBox();
		q = new Label();
		p = new Label();
		o = new Label();
		n = new MaskedEditBox();
		m = new Label();
		l = new UIButton();
		j = new Label();
		k = new Label();
		h = new UIComboBox();
		i = new Label();
		g = new UIButton();
		ak = new Label();
		al = new MaskedEditBox();
		((Control)this.m_d).SuspendLayout();
		((Control)this.m_e).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_d).BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.BorderStyle = (BorderStyle)1;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Dock = (DockStyle)5;
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_d).Location = new Point(0, 0);
		((Control)this.m_d).Name = "panel1";
		((Control)this.m_d).Size = new Size(482, 567);
		((Control)this.m_d).TabIndex = 0;
		((Control)this.m_e).BackColor = Color.Black;
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Dock = (DockStyle)5;
		((Control)this.m_e).Location = new Point(0, 0);
		((Control)this.m_e).Name = "panel2";
		((Control)this.m_e).Size = new Size(480, 565);
		((Control)this.m_e).TabIndex = 44;
		((Control)this.m_f).BackColor = Color.FromArgb(214, 223, 247);
		((Control)this.m_f).Controls.Add((Control)(object)al);
		((Control)this.m_f).Controls.Add((Control)(object)ak);
		((Control)this.m_f).Controls.Add((Control)(object)af);
		((Control)this.m_f).Controls.Add((Control)(object)ag);
		((Control)this.m_f).Controls.Add((Control)(object)ah);
		((Control)this.m_f).Controls.Add((Control)(object)ai);
		((Control)this.m_f).Controls.Add((Control)(object)aj);
		((Control)this.m_f).Controls.Add((Control)(object)ae);
		((Control)this.m_f).Controls.Add((Control)(object)w);
		((Control)this.m_f).Controls.Add((Control)(object)x);
		((Control)this.m_f).Controls.Add((Control)(object)y);
		((Control)this.m_f).Controls.Add((Control)(object)z);
		((Control)this.m_f).Controls.Add((Control)(object)aa);
		((Control)this.m_f).Controls.Add((Control)(object)ab);
		((Control)this.m_f).Controls.Add((Control)(object)ac);
		((Control)this.m_f).Controls.Add((Control)(object)ad);
		((Control)this.m_f).Controls.Add((Control)(object)r);
		((Control)this.m_f).Controls.Add((Control)(object)s);
		((Control)this.m_f).Controls.Add((Control)(object)t);
		((Control)this.m_f).Controls.Add((Control)(object)u);
		((Control)this.m_f).Controls.Add((Control)(object)v);
		((Control)this.m_f).Controls.Add((Control)(object)q);
		((Control)this.m_f).Controls.Add((Control)(object)p);
		((Control)this.m_f).Controls.Add((Control)(object)o);
		((Control)this.m_f).Controls.Add((Control)(object)n);
		((Control)this.m_f).Controls.Add((Control)(object)m);
		((Control)this.m_f).Controls.Add((Control)(object)l);
		((Control)this.m_f).Controls.Add((Control)(object)j);
		((Control)this.m_f).Controls.Add((Control)(object)k);
		((Control)this.m_f).Controls.Add((Control)(object)h);
		((Control)this.m_f).Controls.Add((Control)(object)i);
		((Control)this.m_f).Controls.Add((Control)(object)g);
		((Control)this.m_f).Location = new Point(3, 3);
		((Control)this.m_f).Name = "panel3";
		((Control)this.m_f).Size = new Size(473, 559);
		((Control)this.m_f).TabIndex = 0;
		((Control)af).AutoSize = true;
		((Control)af).Location = new Point(323, 416);
		((Control)af).Name = "label11";
		((Control)af).Size = new Size(83, 26);
		((Control)af).TabIndex = 144;
		((Control)af).Text = "غایب/محروم";
		((Control)ag).AutoSize = true;
		((Control)ag).Location = new Point(322, 371);
		((Control)ag).Name = "label10";
		((Control)ag).Size = new Size(54, 26);
		((Control)ag).TabIndex = 143;
		((Control)ag).Text = "معذرتی";
		((Control)ah).AutoSize = true;
		((Control)ah).Location = new Point(322, 328);
		((Control)ah).Name = "label9";
		((Control)ah).Size = new Size(52, 26);
		((Control)ah).TabIndex = 142;
		((Control)ah).Text = "مشروط";
		((Control)ai).AutoSize = true;
		((Control)ai).Location = new Point(322, 286);
		((Control)ai).Name = "label8";
		((Control)ai).Size = new Size(142, 26);
		((Control)ai).TabIndex = 141;
		((Control)ai).Text = "تلاش بیشتر/تکرار صنف";
		((Control)aj).AutoSize = true;
		((Control)aj).Location = new Point(322, 246);
		((Control)aj).Name = "label7";
		((Control)aj).Size = new Size(107, 26);
		((Control)aj).TabIndex = 140;
		((Control)aj).Text = "موفق/ارتقاء صنف";
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(322, 206);
		((Control)ae).Name = "label6";
		((Control)ae).Size = new Size(86, 26);
		((Control)ae).TabIndex = 139;
		((Control)ae).Text = "شامل امتحان";
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((EditBase)w).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(63, 412);
		((EditBase)w).MaxLength = 3;
		((Control)w).Name = "txtcountAbsent2";
		w.Numeric = true;
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(96, 33);
		((Control)w).TabIndex = 13;
		((Control)w).Tag = "";
		((EditBase)w).TextAlignment = (TextAlignment)2;
		((Control)w).Leave += a;
		((Control)w).Enter += b;
		((Control)w).KeyDown += a;
		((EditBase)x).AutoScroll = false;
		((EditBase)x).AutoScrollMargin = new Size(0, 0);
		((EditBase)x).AutoScrollMinSize = new Size(0, 0);
		((EditBase)x).AutoScrollPosition = new Point(0, 0);
		((EditBase)x).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(63, 366);
		((EditBase)x).MaxLength = 3;
		((Control)x).Name = "txtcountMazerati2";
		x.Numeric = true;
		((Control)x).RightToLeft = (RightToLeft)1;
		((Control)x).Size = new Size(96, 33);
		((Control)x).TabIndex = 12;
		((Control)x).Tag = "";
		((EditBase)x).TextAlignment = (TextAlignment)2;
		((Control)x).Leave += a;
		((Control)x).Enter += b;
		((Control)x).KeyDown += a;
		((EditBase)y).AutoScroll = false;
		((EditBase)y).AutoScrollMargin = new Size(0, 0);
		((EditBase)y).AutoScrollMinSize = new Size(0, 0);
		((EditBase)y).AutoScrollPosition = new Point(0, 0);
		((EditBase)y).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(63, 323);
		((EditBase)y).MaxLength = 3;
		((Control)y).Name = "txtcountMashrot2";
		y.Numeric = true;
		((Control)y).RightToLeft = (RightToLeft)1;
		((Control)y).Size = new Size(96, 33);
		((Control)y).TabIndex = 11;
		((Control)y).Tag = "";
		((EditBase)y).TextAlignment = (TextAlignment)2;
		((Control)y).Leave += a;
		((Control)y).Enter += b;
		((Control)y).KeyDown += a;
		((EditBase)z).AutoScroll = false;
		((EditBase)z).AutoScrollMargin = new Size(0, 0);
		((EditBase)z).AutoScrollMinSize = new Size(0, 0);
		((EditBase)z).AutoScrollPosition = new Point(0, 0);
		((EditBase)z).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)z).Location = new Point(63, 282);
		((EditBase)z).MaxLength = 3;
		((Control)z).Name = "txtcountNoAcp2";
		z.Numeric = true;
		((Control)z).RightToLeft = (RightToLeft)1;
		((Control)z).Size = new Size(96, 33);
		((Control)z).TabIndex = 10;
		((Control)z).Tag = "";
		((EditBase)z).TextAlignment = (TextAlignment)2;
		((Control)z).Leave += a;
		((Control)z).Enter += b;
		((Control)z).KeyDown += a;
		((EditBase)aa).AutoScroll = false;
		((EditBase)aa).AutoScrollMargin = new Size(0, 0);
		((EditBase)aa).AutoScrollMinSize = new Size(0, 0);
		((EditBase)aa).AutoScrollPosition = new Point(0, 0);
		((EditBase)aa).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)aa).Location = new Point(63, 242);
		((EditBase)aa).MaxLength = 3;
		((Control)aa).Name = "txtcountAcp2";
		aa.Numeric = true;
		((Control)aa).RightToLeft = (RightToLeft)1;
		((Control)aa).Size = new Size(96, 33);
		((Control)aa).TabIndex = 9;
		((Control)aa).Tag = "";
		((EditBase)aa).TextAlignment = (TextAlignment)2;
		((Control)aa).Leave += a;
		((Control)aa).Enter += b;
		((Control)aa).KeyDown += a;
		((EditBase)ab).AutoScroll = false;
		((EditBase)ab).AutoScrollMargin = new Size(0, 0);
		((EditBase)ab).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ab).AutoScrollPosition = new Point(0, 0);
		((EditBase)ab).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ab).Location = new Point(63, 202);
		((EditBase)ab).MaxLength = 3;
		((Control)ab).Name = "txtcountExam2";
		ab.Numeric = true;
		((Control)ab).RightToLeft = (RightToLeft)1;
		((Control)ab).Size = new Size(96, 33);
		((Control)ab).TabIndex = 8;
		((Control)ab).Tag = "";
		((EditBase)ab).TextAlignment = (TextAlignment)2;
		((Control)ab).Leave += a;
		((Control)ab).Enter += b;
		((Control)ab).KeyDown += a;
		((EditBase)ac).AutoScroll = false;
		((EditBase)ac).AutoScrollMargin = new Size(0, 0);
		((EditBase)ac).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ac).AutoScrollPosition = new Point(0, 0);
		((EditBase)ac).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ac).Location = new Point(63, 161);
		((EditBase)ac).MaxLength = 3;
		((Control)ac).Name = "txtcountDakhele2";
		ac.Numeric = true;
		((Control)ac).RightToLeft = (RightToLeft)1;
		((Control)ac).Size = new Size(96, 33);
		((Control)ac).TabIndex = 7;
		((Control)ac).Tag = "";
		((EditBase)ac).TextAlignment = (TextAlignment)2;
		((Control)ac).Leave += a;
		((Control)ac).Enter += b;
		((Control)ac).KeyDown += a;
		((EditBase)ad).AutoScroll = false;
		((EditBase)ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ad).AutoScrollPosition = new Point(0, 0);
		((EditBase)ad).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ad).Location = new Point(221, 412);
		((EditBase)ad).MaxLength = 3;
		((Control)ad).Name = "txtcountAbsent1";
		ad.Numeric = true;
		((Control)ad).RightToLeft = (RightToLeft)1;
		((Control)ad).Size = new Size(96, 33);
		((Control)ad).TabIndex = 6;
		((Control)ad).Tag = "";
		((EditBase)ad).TextAlignment = (TextAlignment)2;
		((Control)ad).Leave += a;
		((Control)ad).Enter += b;
		((Control)ad).KeyDown += a;
		((EditBase)r).AutoScroll = false;
		((EditBase)r).AutoScrollMargin = new Size(0, 0);
		((EditBase)r).AutoScrollMinSize = new Size(0, 0);
		((EditBase)r).AutoScrollPosition = new Point(0, 0);
		((EditBase)r).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(221, 366);
		((EditBase)r).MaxLength = 3;
		((Control)r).Name = "txtcountMazerati1";
		r.Numeric = true;
		((Control)r).RightToLeft = (RightToLeft)1;
		((Control)r).Size = new Size(96, 33);
		((Control)r).TabIndex = 5;
		((Control)r).Tag = "";
		((EditBase)r).TextAlignment = (TextAlignment)2;
		((Control)r).Leave += a;
		((Control)r).Enter += b;
		((Control)r).KeyDown += a;
		((EditBase)s).AutoScroll = false;
		((EditBase)s).AutoScrollMargin = new Size(0, 0);
		((EditBase)s).AutoScrollMinSize = new Size(0, 0);
		((EditBase)s).AutoScrollPosition = new Point(0, 0);
		((EditBase)s).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)s).Location = new Point(221, 323);
		((EditBase)s).MaxLength = 3;
		((Control)s).Name = "txtcountMashrot1";
		s.Numeric = true;
		((Control)s).RightToLeft = (RightToLeft)1;
		((Control)s).Size = new Size(96, 33);
		((Control)s).TabIndex = 4;
		((Control)s).Tag = "";
		((EditBase)s).TextAlignment = (TextAlignment)2;
		((Control)s).Leave += a;
		((Control)s).Enter += b;
		((Control)s).KeyDown += a;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((EditBase)t).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(221, 282);
		((EditBase)t).MaxLength = 3;
		((Control)t).Name = "txtcountNoAcp1";
		t.Numeric = true;
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(96, 33);
		((Control)t).TabIndex = 3;
		((Control)t).Tag = "";
		((EditBase)t).TextAlignment = (TextAlignment)2;
		((Control)t).Leave += a;
		((Control)t).Enter += b;
		((Control)t).KeyDown += a;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((EditBase)u).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(221, 242);
		((EditBase)u).MaxLength = 3;
		((Control)u).Name = "txtcountAcp1";
		u.Numeric = true;
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(96, 33);
		((Control)u).TabIndex = 2;
		((Control)u).Tag = "";
		((EditBase)u).TextAlignment = (TextAlignment)2;
		((Control)u).Leave += a;
		((Control)u).Enter += b;
		((Control)u).KeyDown += a;
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((EditBase)v).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(221, 202);
		((EditBase)v).MaxLength = 3;
		((Control)v).Name = "txtcountExam1";
		v.Numeric = true;
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(96, 33);
		((Control)v).TabIndex = 1;
		((Control)v).Tag = "";
		((EditBase)v).TextAlignment = (TextAlignment)2;
		((Control)v).Leave += a;
		((Control)v).Enter += b;
		((Control)v).KeyDown += a;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(89, 128);
		((Control)q).Name = "label5";
		((Control)q).Size = new Size(47, 26);
		((Control)q).TabIndex = 125;
		((Control)q).Text = "سالانه";
		((Control)p).AutoSize = true;
		((Control)p).Location = new Point(223, 129);
		((Control)p).Name = "label2";
		((Control)p).Size = new Size(89, 26);
		((Control)p).TabIndex = 124;
		((Control)p).Text = "چهار نیم ماهه";
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(322, 165);
		((Control)o).Name = "label1";
		((Control)o).Size = new Size(76, 26);
		((Control)o).TabIndex = 123;
		((Control)o).Text = "تعداد داخله";
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((EditBase)n).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(221, 161);
		((EditBase)n).MaxLength = 3;
		((Control)n).Name = "txtcountDakhele1";
		n.Numeric = true;
		((Control)n).RightToLeft = (RightToLeft)1;
		((Control)n).Size = new Size(96, 33);
		((Control)n).TabIndex = 0;
		((Control)n).Tag = "";
		((EditBase)n).TextAlignment = (TextAlignment)2;
		((Control)n).Leave += a;
		((Control)n).Enter += b;
		((Control)n).KeyDown += a;
		((Control)m).AutoSize = true;
		((Control)m).Font = new Font("B Nazanin", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)m).ForeColor = Color.DarkViolet;
		((Control)m).Location = new Point(177, 5);
		((Control)m).Name = "label4";
		((Control)m).Size = new Size(144, 51);
		((Control)m).TabIndex = 121;
		((Control)m).Text = "خلص نتایج";
		l.ButtonStyle = (ButtonStyle)1;
		((Control)l).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		l.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		l.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		l.ImageIndex = 8;
		((Control)l).Location = new Point(220, 504);
		((Control)l).Name = "btnAcp";
		((Control)l).RightToLeft = (RightToLeft)1;
		((Control)l).Size = new Size(153, 40);
		((Control)l).TabIndex = 15;
		((Control)l).Text = "ثبت (F5)";
		l.VisualStyle = (VisualStyle)1;
		((Control)l).Click += c;
		j.BorderStyle = (BorderStyle)1;
		((Control)j).Location = new Point(10, 20);
		((Control)j).Name = "lYear";
		((Control)j).Size = new Size(59, 24);
		((Control)j).TabIndex = 118;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(75, 20);
		((Control)k).Name = "label3";
		((Control)k).Size = new Size(78, 26);
		((Control)k).TabIndex = 117;
		((Control)k).Text = "سال تعلیمی\r\n";
		((UIComboBase)h).ComboStyle = (ComboStyle)1;
		((UIComboBase)h).DropListFont = new Font("B Nazanin", 12f);
		((Control)h).Location = new Point(63, 84);
		((Control)h).Name = "dropCls";
		((Control)h).Size = new Size(254, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)h).StringFormat = val;
		((Control)h).TabIndex = 15;
		h.SelectedIndexChanged += d;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(323, 88);
		((Control)i).Name = "label19";
		((Control)i).Size = new Size(41, 26);
		((Control)i).TabIndex = 51;
		((Control)i).Text = "صنف";
		((Control)g).Anchor = (AnchorStyles)6;
		g.DialogResult = (DialogResult)2;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(40, 40);
		((Control)g).Location = new Point(28, 504);
		((Control)g).Name = "btnClose";
		((Control)g).Size = new Size(152, 40);
		((Control)g).TabIndex = 16;
		((Control)g).Text = "بستن";
		((Control)g).Click += e;
		((Control)ak).AutoSize = true;
		((Control)ak).Location = new Point(225, 463);
		((Control)ak).Name = "label12";
		((Control)ak).Size = new Size(65, 26);
		((Control)ak).TabIndex = 145;
		((Control)ak).Text = "سه پارچه";
		((EditBase)al).AutoScroll = false;
		((EditBase)al).AutoScrollMargin = new Size(0, 0);
		((EditBase)al).AutoScrollMinSize = new Size(0, 0);
		((EditBase)al).AutoScrollPosition = new Point(0, 0);
		((EditBase)al).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)al).Location = new Point(159, 458);
		((EditBase)al).MaxLength = 3;
		((Control)al).Name = "txtSeparcheh";
		al.Numeric = true;
		((Control)al).RightToLeft = (RightToLeft)1;
		((Control)al).Size = new Size(66, 33);
		((Control)al).TabIndex = 14;
		((Control)al).Tag = "";
		((EditBase)al).TextAlignment = (TextAlignment)2;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(482, 567);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSummaryResults";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "خلص نتایج";
		((Form)this).Load += f;
		((Control)this).KeyUp += b;
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_e).ResumeLayout(false);
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
