using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdat : Form
{
	public string a = "0";

	private string m_b = "";

	private IContainer m_c = null;

	private UIComboBox m_d;

	private UIButton m_e;

	private Label m_f;

	private UIButton m_g;

	private Panel m_h;

	private Panel m_i;

	private Label m_j;

	private Label m_k;

	private MaskedEditBox m_l;

	private MaskedEditBox m_m;

	private UIButton m_n;

	private UIButton m_o;

	private PictureBox m_p;

	private MaskedEditBox m_q;

	private Label m_r;

	private EditBox m_s;

	private Label m_t;

	private EditBox m_u;

	private Label m_v;

	private EditBox m_w;

	private Label m_x;

	private UIComboBox m_y;

	private Label m_z;

	private MaskedEditBox m_aa;

	private Label m_ab;

	private Label m_ac;

	private MaskedEditBox m_ad;

	private MaskedEditBox m_ae;

	private Label m_af;

	private Label m_ag;

	private UIComboBox m_ah;

	private UIComboBox m_ai;

	private Label m_aj;

	private OpenFileDialog m_ak;

	private Panel m_al;

	private EditBox m_am;

	private Label m_an;

	private CheckBox m_ao;

	private CheckBox m_ap;

	private CheckBox m_aq;

	private CheckBox m_ar;

	private CheckBox m_as;

	private CheckBox m_at;

	private CheckBox m_au;

	private CheckBox m_av;

	private CheckBox m_aw;

	private CheckBox ax;

	private Label ay;

	private MaskedEditBox az;

	private MaskedEditBox a0;

	private Label a1;

	private Label a2;

	private Label a3;

	private UIComboBox a4;

	private MaskedEditBox a5;

	private Label a6;

	private MaskedEditBox a7;

	private Label a8;

	private UIGroupBox a9;

	private MaskedEditBox ba;

	private MaskedEditBox bb;

	private MaskedEditBox bc;

	private MaskedEditBox bd;

	private MaskedEditBox be;

	private MaskedEditBox bf;

	private MaskedEditBox bg;

	private MaskedEditBox bh;

	private MaskedEditBox bi;

	private Label bj;

	private Label bk;

	private Label bl;

	private Label bm;

	private Label bn;

	private Label bo;

	private UIGroupBox bp;

	private Label bq;

	private Label br;

	private Label bs;

	private Label bt;

	private Label bu;

	private Label bv;

	private Label bw;

	private Label bx;

	private Label by;

	private MaskedEditBox bz;

	private MaskedEditBox b0;

	private MaskedEditBox b1;

	private MaskedEditBox b2;

	private MaskedEditBox b3;

	private MaskedEditBox b4;

	private MaskedEditBox b5;

	private MaskedEditBox b6;

	private MaskedEditBox b7;

	private Label b8;

	private Label b9;

	private Label ca;

	private Label cb;

	private Label cc;

	private MaskedEditBox cd;

	public UIComboBox ce;

	private UIButton cf;

	private UIButton cg;

	public UIComboBox ch;

	private Panel ci;

	private Label cj;

	private UIComboBox ck;

	private Label cl;

	private MaskedEditBox cm;

	private UIButton cn;

	private Panel co;

	private Label cp;

	private Label cq;

	private Label cr;

	private UIComboBox cs;

	private UIComboBox ct;

	private Label cu;

	private Label cv;

	private EditBox cw;

	private Label cx;

	private EditBox cy;

	private Label cz;

	private EditBox c0;

	private Label c1;

	private EditBox c2;

	private CheckBox c3;

	private Label c4;

	private MaskedEditBox c5;

	private UIComboBox c6;

	private Label c7;

	private MaskedEditBox c8;

	private Label c9;

	public asdat()
	{
		a();
	}

	private void aw(object A_0, EventArgs A_1)
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
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
						num = 6;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 12;
					continue;
				case 3:
					ce.SelectedIndex = 0;
					this.a = ce.SelectedValue.ToString();
					ch.SelectedIndex = 0;
					((Control)ci).Visible = true;
					num = 8;
					continue;
				case 12:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 5;
				case 13:
					((Control)az).Text = ShamsiDate.GetShamsiDate(DateTime.Now);
					this.m_ai.SelectedIndex = 0;
					h();
					m();
					((Control)cp).Text = asdaj.j;
					((Control)cq).Visible = true;
					((Control)co).Visible = true;
					((Control)cn).Visible = true;
					h();
					num = 2;
					continue;
				case 2:
					return;
				case 6:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 0;
					continue;
				case 0:
					return;
				case 8:
					flag = !(this.a == "0");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 13;
						continue;
					}
					j();
					num = 9;
					continue;
				case 9:
					return;
				case 11:
					num = 1;
					continue;
				case 5:
					((Control)cb).Text = asdaj.a;
					k();
					l();
					o();
					n();
					p();
					this.m_ah.SelectedIndex = 0;
					ck.SelectedIndex = 0;
					cs.SelectedIndex = 0;
					this.m_y.SelectedIndex = 0;
					flag = ((CollectionBase)(object)ce.Items).Count <= 0;
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 8;
				case 1:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_h).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
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

	private void p()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as  id,N'-' as name\r\n                                                                                union\r\n                                                                                SELECT   tCity.id, tCity.Name + ' - ' + tOstan.Name AS name\r\n                                                                                FROM         tCity INNER JOIN\r\n                                                                                                      tOstan ON tCity.xOstan = tOstan.id\r\n                                                                                ORDER BY name");
		ct.DataSource = dataSource;
		ct.DisplayMember = "Name";
		ct.ValueMember = "id";
		ct.SelectedIndex = 0;
		c6.DataSource = dataSource;
		c6.DisplayMember = "Name";
		c6.ValueMember = "id";
		c6.SelectedIndex = 0;
	}

	private void o()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from ttakhfif order by name");
		ck.DataSource = dataSource;
		ck.DisplayMember = "Name";
		ck.ValueMember = "id";
		ck.SelectedIndex = 0;
	}

	private void n()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tDriver order by name");
		cs.DataSource = dataSource;
		cs.DisplayMember = "Name";
		cs.ValueMember = "id";
		cs.SelectedIndex = 0;
	}

	private void m()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT name FROM tItemSabtenamEnable WHERE (Enable = 0)");
			int num = 0;
			int num2 = 105;
			while (true)
			{
				switch (num2)
				{
				case 164:
					if (!flag)
					{
						num2 = 152;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkuniform");
					num2 = 24;
					continue;
				case 108:
					((Control)cd).Enabled = true;
					num2 = 68;
					continue;
				case 61:
					if (!flag)
					{
						num2 = 142;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkkomakdarsi");
					num2 = 121;
					continue;
				case 20:
					((Control)this.m_av).Enabled = true;
					num2 = 54;
					continue;
				case 167:
					if (!flag)
					{
						num2 = 184;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "dropStatus");
					num2 = 114;
					continue;
				case 102:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkdakhle");
						num2 = 164;
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 177:
					if (!flag)
					{
						num2 = 208;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtLastName");
					num2 = 148;
					continue;
				case 69:
					if (!flag)
					{
						num2 = 212;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtNumberAsas");
					num2 = 190;
					continue;
				case 133:
					((Control)this.m_as).Enabled = false;
					num2 = 156;
					continue;
				case 139:
					((Control)a0).Enabled = true;
					num2 = 210;
					continue;
				case 154:
					if (!flag)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				case 75:
					if (!flag)
					{
						num2 = 185;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtcodeTakhfif");
					num2 = 213;
					continue;
				case 67:
					if (!flag)
					{
						num2 = 40;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtNumberTelegram");
					num2 = 14;
					continue;
				case 160:
					((Control)this.m_am).Enabled = false;
					num2 = 41;
					continue;
				case 76:
					if (!flag)
					{
						num2 = 49;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtCode");
					num2 = 12;
					continue;
				case 65:
					((Control)this.m_at).Enabled = false;
					num2 = 7;
					continue;
				case 198:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtEn_Lname");
						num2 = 177;
					}
					else
					{
						num2 = 21;
					}
					continue;
				case 215:
					if (!flag)
					{
						num2 = 138;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkhazer");
					num2 = 92;
					continue;
				case 205:
					((Control)cy).Enabled = false;
					num2 = 88;
					continue;
				case 200:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtLastName");
					num2 = 214;
					continue;
				case 163:
					if (!flag)
					{
						num2 = 35;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtRegDate");
					num2 = 104;
					continue;
				case 83:
					((Control)this.m_av).Enabled = false;
					num2 = 209;
					continue;
				case 142:
					((Control)this.m_ao).Enabled = false;
					num2 = 8;
					continue;
				case 9:
					if (!flag)
					{
						num2 = 146;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkMarkTerm3_From100");
					num2 = 48;
					continue;
				case 72:
					if (!flag)
					{
						num2 = 204;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkhazer");
					num2 = 172;
					continue;
				case 89:
					if (!flag)
					{
						num2 = 71;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkmaghnae");
					num2 = 63;
					continue;
				case 173:
					((Control)this.m_ar).Enabled = false;
					num2 = 47;
					continue;
				case 147:
					((Control)this.m_s).Enabled = true;
					num2 = 166;
					continue;
				case 86:
					if (!flag)
					{
						num2 = 42;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtMobileMother");
					num2 = 78;
					continue;
				case 26:
					((Control)this.m_o).Enabled = false;
					((Control)this.m_n).Enabled = false;
					num2 = 44;
					continue;
				case 103:
					((Control)c3).Enabled = false;
					num2 = 56;
					continue;
				case 10:
					((Control)this.m_as).Enabled = true;
					num2 = 66;
					continue;
				case 11:
					((Control)a0).Enabled = false;
					num2 = 52;
					continue;
				case 80:
					((Control)ck).Enabled = true;
					num2 = 106;
					continue;
				case 22:
					((Control)this.m_ai).Enabled = false;
					num2 = 176;
					continue;
				case 1:
					((Control)this.m_ad).Enabled = false;
					num2 = 182;
					continue;
				case 208:
					((Control)cw).Enabled = true;
					num2 = 17;
					continue;
				case 62:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkrobotic");
						num2 = 89;
					}
					else
					{
						num2 = 173;
					}
					continue;
				case 114:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtRegDate");
						num2 = 76;
					}
					else
					{
						num2 = 22;
					}
					continue;
				case 145:
					((Control)this.m_aq).Enabled = true;
					num2 = 149;
					continue;
				case 98:
					if (!flag)
					{
						num2 = 110;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtSh_sh");
					num2 = 59;
					continue;
				case 12:
					if (!flag)
					{
						num2 = 5;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtAdress");
					num2 = 53;
					continue;
				case 13:
					if (!flag)
					{
						num2 = 143;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "dropMazhab");
					num2 = 187;
					continue;
				case 196:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checktransport");
						num2 = 62;
					}
					else
					{
						num2 = 133;
					}
					continue;
				case 146:
					((Control)ax).Enabled = true;
					num2 = 201;
					continue;
				case 100:
					if (!flag)
					{
						num2 = 10;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checktransport");
					num2 = 82;
					continue;
				case 125:
					((Control)c3).Enabled = true;
					num2 = 129;
					continue;
				case 136:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtEn_Fname");
						num2 = 198;
					}
					else
					{
						num2 = 95;
					}
					continue;
				case 53:
					if (!flag)
					{
						num2 = 160;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkdakhle");
					num2 = 18;
					continue;
				case 190:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropJens");
						num2 = 13;
					}
					else
					{
						num2 = 199;
					}
					continue;
				case 107:
					((Control)ck).Enabled = false;
					num2 = 29;
					continue;
				case 123:
					if (!flag)
					{
						num2 = 74;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtbDate");
					num2 = 73;
					continue;
				case 184:
					((Control)this.m_ah).Enabled = false;
					num2 = 131;
					continue;
				case 82:
					if (!flag)
					{
						num2 = 144;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkrobotic");
					num2 = 203;
					continue;
				case 43:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtSh_sh");
						num2 = 69;
					}
					else
					{
						num2 = 27;
					}
					continue;
				case 170:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropcityNow");
						num2 = 75;
					}
					else
					{
						num2 = 91;
					}
					continue;
				case 50:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtEn_Lname");
						num2 = 200;
					}
					else
					{
						num2 = 205;
					}
					continue;
				case 91:
					((Control)c2).Enabled = false;
					num2 = 178;
					continue;
				case 64:
					((Control)this.m_l).Enabled = true;
					num2 = 87;
					continue;
				case 179:
					((Control)c0).Enabled = true;
					num2 = 85;
					continue;
				case 6:
					if (!flag)
					{
						num2 = 26;
						continue;
					}
					goto case 0;
				case 19:
					((Control)c0).Enabled = false;
					num2 = 32;
					continue;
				case 199:
					((Control)this.m_ae).Enabled = true;
					num2 = 157;
					continue;
				case 216:
					((Control)this.m_au).Enabled = true;
					num2 = 16;
					continue;
				case 27:
					((Control)c8).Enabled = true;
					num2 = 191;
					continue;
				case 121:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkketab");
						num2 = 196;
					}
					else
					{
						num2 = 65;
					}
					continue;
				case 59:
					if (!flag)
					{
						num2 = 112;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtNumberAsas");
					num2 = 169;
					continue;
				case 60:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropMazhab");
						num2 = 167;
					}
					else
					{
						num2 = 23;
					}
					continue;
				case 42:
					((Control)this.m_l).Enabled = false;
					num2 = 39;
					continue;
				case 23:
					((Control)this.m_y).Enabled = false;
					num2 = 180;
					continue;
				case 127:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtEn_Fname");
						num2 = 50;
					}
					else
					{
						num2 = 158;
					}
					continue;
				case 4:
					((Control)this.m_am).Enabled = true;
					num2 = 37;
					continue;
				case 126:
					((Control)this.m_q).Enabled = true;
					num2 = 186;
					continue;
				case 104:
					if (!flag)
					{
						num2 = 130;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtCode");
					num2 = 183;
					continue;
				case 161:
					if (!flag)
					{
						num2 = 107;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtExitDate");
					num2 = 113;
					continue;
				case 34:
					((Control)this.m_ad).Enabled = true;
					num2 = 2;
					continue;
				case 144:
					((Control)this.m_ar).Enabled = true;
					num2 = 188;
					continue;
				case 40:
					((Control)this.m_s).Enabled = false;
					num2 = 38;
					continue;
				case 14:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtMobileFather");
						num2 = 86;
					}
					else
					{
						num2 = 1;
					}
					continue;
				case 212:
					((Control)this.m_aa).Enabled = true;
					num2 = 58;
					continue;
				case 0:
				case 7:
				case 8:
				case 25:
				case 28:
				case 29:
				case 32:
				case 38:
				case 39:
				case 41:
				case 44:
				case 45:
				case 47:
				case 52:
				case 56:
				case 70:
				case 88:
				case 101:
				case 115:
				case 117:
				case 120:
				case 131:
				case 132:
				case 134:
				case 151:
				case 156:
				case 175:
				case 176:
				case 178:
				case 180:
				case 182:
				case 189:
				case 194:
				case 197:
				case 209:
					num++;
					num2 = 99;
					continue;
				case 185:
					((Control)c6).Enabled = false;
					num2 = 120;
					continue;
				case 113:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropcity");
						num2 = 127;
					}
					else
					{
						num2 = 11;
					}
					continue;
				case 211:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT name FROM tItemSabtenamEnable WHERE (Enable = 1)");
					num = 0;
					num2 = 171;
					continue;
				case 49:
					((Control)az).Enabled = false;
					num2 = 28;
					continue;
				case 109:
					if (!flag)
					{
						num2 = 80;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtExitDate");
					num2 = 159;
					continue;
				case 130:
					((Control)az).Enabled = true;
					num2 = 46;
					continue;
				case 183:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtAdress");
						num2 = 102;
					}
					else
					{
						num2 = 126;
					}
					continue;
				case 135:
					if (!flag)
					{
						num2 = 217;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "checkMarkTerm3_From100");
					num2 = 165;
					continue;
				case 159:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropcity");
						num2 = 136;
					}
					else
					{
						num2 = 139;
					}
					continue;
				case 181:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkketab");
						num2 = 100;
					}
					else
					{
						num2 = 122;
					}
					continue;
				case 74:
					((Control)this.m_m).Enabled = true;
					num2 = 111;
					continue;
				case 195:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkshaghe");
						num2 = 215;
					}
					else
					{
						num2 = 216;
					}
					continue;
				case 204:
					((Control)this.m_aw).Enabled = false;
					num2 = 45;
					continue;
				case 158:
					((Control)ct).Enabled = false;
					num2 = 115;
					continue;
				case 122:
					((Control)this.m_at).Enabled = true;
					num2 = 155;
					continue;
				case 162:
					((Control)this.m_ah).Enabled = true;
					num2 = 94;
					continue;
				case 148:
					if (!flag)
					{
						num2 = 179;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtEn_LastName");
					num2 = 137;
					continue;
				case 24:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkkomakdarsi");
						num2 = 181;
					}
					else
					{
						num2 = 57;
					}
					continue;
				case 143:
					((Control)this.m_y).Enabled = true;
					num2 = 206;
					continue;
				case 206:
					if (1 == 0)
					{
					}
					goto case 2;
				case 152:
					((Control)this.m_ap).Enabled = true;
					num2 = 116;
					continue;
				case 203:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkmaghnae");
						num2 = 195;
					}
					else
					{
						num2 = 145;
					}
					continue;
				case 97:
					((Control)c2).Enabled = true;
					num2 = 124;
					continue;
				case 36:
					((Control)this.m_m).Enabled = false;
					num2 = 151;
					continue;
				case 63:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkshaghe");
						num2 = 72;
					}
					else
					{
						num2 = 141;
					}
					continue;
				case 57:
					((Control)this.m_ao).Enabled = true;
					num2 = 93;
					continue;
				case 207:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "pic");
						num2 = 154;
					}
					else
					{
						num2 = 33;
					}
					continue;
				case 192:
					if (!flag)
					{
						num2 = 147;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtNumberTelegram");
					num2 = 118;
					continue;
				case 214:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtEn_LastName");
						num2 = 170;
					}
					else
					{
						num2 = 19;
					}
					continue;
				case 119:
					((Control)cd).Enabled = false;
					num2 = 189;
					continue;
				case 138:
					((Control)this.m_aw).Enabled = true;
					num2 = 77;
					continue;
				case 172:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkmali");
						num2 = 135;
					}
					else
					{
						num2 = 83;
					}
					continue;
				case 165:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "comboTakhfif");
						num2 = 161;
					}
					else
					{
						num2 = 103;
					}
					continue;
				case 171:
				case 174:
					flag = num < dataTable.Rows.Count;
					num2 = 202;
					continue;
				case 202:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtNamP");
						num2 = 192;
					}
					else
					{
						num2 = 128;
					}
					continue;
				case 128:
					return;
				case 30:
					((Control)c5).Enabled = false;
					num2 = 101;
					continue;
				case 140:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtbDateM");
						num2 = 98;
					}
					else
					{
						num2 = 119;
					}
					continue;
				case 112:
					((Control)this.m_aa).Enabled = false;
					num2 = 134;
					continue;
				case 90:
					((Control)this.m_ae).Enabled = false;
					num2 = 0;
					continue;
				case 92:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkmali");
						num2 = 9;
					}
					else
					{
						num2 = 20;
					}
					continue;
				case 137:
					if (!flag)
					{
						num2 = 97;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "dropcityNow");
					num2 = 84;
					continue;
				case 35:
					((Control)this.m_ai).Enabled = true;
					num2 = 55;
					continue;
				case 118:
					if (!flag)
					{
						num2 = 34;
						continue;
					}
					flag = !(dataTable.Rows[num]["name"].ToString() == "txtMobileFather");
					num2 = 96;
					continue;
				case 81:
					((Control)c6).Enabled = true;
					num2 = 150;
					continue;
				case 51:
					((Control)this.m_ap).Enabled = false;
					num2 = 117;
					continue;
				case 99:
				case 105:
					flag = num < dataTable.Rows.Count;
					num2 = 168;
					continue;
				case 168:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtNamP");
						num2 = 67;
					}
					else
					{
						num2 = 211;
					}
					continue;
				case 84:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtcodeTakhfif");
						num2 = 207;
					}
					else
					{
						num2 = 81;
					}
					continue;
				case 2:
				case 16:
				case 17:
				case 31:
				case 37:
				case 46:
				case 54:
				case 55:
				case 58:
				case 66:
				case 68:
				case 77:
				case 79:
				case 85:
				case 87:
				case 93:
				case 94:
				case 106:
				case 111:
				case 116:
				case 124:
				case 129:
				case 149:
				case 150:
				case 153:
				case 155:
				case 157:
				case 166:
				case 186:
				case 188:
				case 191:
				case 193:
				case 201:
				case 210:
					num++;
					num2 = 174;
					continue;
				case 141:
					((Control)this.m_au).Enabled = false;
					num2 = 197;
					continue;
				case 18:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "checkuniform");
						num2 = 61;
					}
					else
					{
						num2 = 51;
					}
					continue;
				case 187:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropStatus");
						num2 = 163;
					}
					else
					{
						num2 = 162;
					}
					continue;
				case 33:
					((Control)c5).Enabled = true;
					num2 = 79;
					continue;
				case 21:
					((Control)cy).Enabled = true;
					num2 = 31;
					continue;
				case 71:
					((Control)this.m_aq).Enabled = false;
					num2 = 175;
					continue;
				case 217:
					((Control)ax).Enabled = false;
					num2 = 25;
					continue;
				case 95:
					((Control)ct).Enabled = true;
					num2 = 193;
					continue;
				case 73:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtbDateM");
						num2 = 43;
					}
					else
					{
						num2 = 108;
					}
					continue;
				case 213:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "pic");
						num2 = 6;
					}
					else
					{
						num2 = 30;
					}
					continue;
				case 169:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "dropJens");
						num2 = 60;
					}
					else
					{
						num2 = 90;
					}
					continue;
				case 110:
					((Control)c8).Enabled = false;
					num2 = 132;
					continue;
				case 15:
					((Control)cw).Enabled = false;
					num2 = 194;
					continue;
				case 3:
					((Control)this.m_o).Enabled = true;
					((Control)this.m_n).Enabled = true;
					num2 = 153;
					continue;
				case 78:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtbDate");
						num2 = 140;
					}
					else
					{
						num2 = 36;
					}
					continue;
				case 5:
					((Control)this.m_q).Enabled = false;
					num2 = 70;
					continue;
				case 96:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "txtMobileMother");
						num2 = 123;
					}
					else
					{
						num2 = 64;
					}
					continue;
				case 48:
					if (flag)
					{
						flag = !(dataTable.Rows[num]["name"].ToString() == "comboTakhfif");
						num2 = 109;
					}
					else
					{
						num2 = 125;
					}
					continue;
				}
				break;
			}
		}
	}

	private void l()
	{
		while (true)
		{
			bool flag = a4.SelectedIndex >= 0;
			if (true)
			{
			}
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 1;
						continue;
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + ((Control)cb).Text + " and xPaye in(" + asdaj.n + ") and xPaye=" + a4.SelectedValue.ToString() + " order by xpaye,sortRpt");
					this.m_d.DataSource = dataSource;
					this.m_d.DisplayMember = "Name";
					this.m_d.ValueMember = "id";
					num = 0;
					continue;
				}
				case 0:
					return;
				case 1:
					this.m_d.DataSource = null;
					((Control)this.m_d).Text = "";
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void av(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void au(object A_0, EventArgs A_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = (int)((CommonDialog)this.m_ak).ShowDialog() != 1;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 2:
					try
					{
						while (true)
						{
							IL_0072:
							FileInfo fileInfo = new FileInfo(((FileDialog)this.m_ak).FileName);
							long length = fileInfo.Length;
							flag = length <= 102400;
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
									this.m_p.Image = Image.FromFile(((FileDialog)this.m_ak).FileName);
									this.m_b = ((FileDialog)this.m_ak).FileName;
									num = 3;
									continue;
								case 0:
									MessageBox.Show("حجم عکس انتخابی بیشتر از حد مجاز است-حجم عکس باید کمتر از 100 کیلوبایت باشد");
									num = 2;
									continue;
								case 2:
									return;
								case 3:
									goto end_IL_0059;
								}
								goto IL_0072;
								continue;
								end_IL_0059:
								break;
							}
							break;
						}
					}
					catch
					{
						this.m_b = "";
						this.m_p.Image = null;
					}
					num = 0;
					continue;
				case 1:
					num = 2;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void at(object A_0, EventArgs A_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = 6 != (int)MessageBox.Show("آیا از حذف عکس شاگرد اطمینان دارید", "حذف عکس شاگرد ", (MessageBoxButtons)4, (MessageBoxIcon)32);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					if (true)
					{
					}
					asdcb.d(asdab.e(), CommandType.Text, "delete from tStudentImg where xStudent=" + this.a);
					this.m_p.Image = null;
					asdaj.h = true;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void k()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
		a4.DataSource = dataSource;
		a4.DisplayMember = "Name";
		a4.ValueMember = "id";
	}

	private void @as(object A_0, EventArgs A_1)
	{
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1815: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Invalid comparison between I4 and Unknown
		//IL_1b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Invalid comparison between Unknown and I4
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
		object a_11 = default;
		object a_25 = default;
		object a_18 = default;
		object a_20 = default;
		DataTable dataTable = default;
		int num5 = default;
		object a_24 = default;
		string text = default;
		int num3 = default;
		object a_23 = default;
		object a_17 = default;
		object a_16 = default;
		object a_7 = default;
		object a_8 = default;
		object a_3 = default;
		string a_2 = default;
		object a_ = default;
		object a_21 = default;
		string a_10 = default;
		SqlParameter[] array = default;
		object a_27 = default;
		object a_19 = default;
		object a_15 = default;
		string a_4 = default;
		object a_26 = default;
		object a_22 = default;
		object a_12 = default;
		object a_14 = default;
		object a_13 = default;
		object a_5 = default;
		object a_6 = default;
		while (true)
		{
			bool flag = !(((Control)this.m_w).Text.Trim() == "");
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = !(((Control)this.m_u).Text.Trim() == "");
					num = 118;
					continue;
				case 6:
					a_11 = ((Control)this.m_q).Text;
					flag = !(((Control)this.m_q).Text.Trim() == "");
					num = 40;
					continue;
				case 40:
					if (!flag)
					{
						num = 128;
						continue;
					}
					goto case 87;
				case 114:
					a_25 = DBNull.Value;
					num = 147;
					continue;
				case 12:
					if (!flag)
					{
						num = 135;
						continue;
					}
					flag = !(this.m_b != "");
					num = 136;
					continue;
				case 58:
					a_18 = ((Control)a7).Text;
					flag = !(((Control)a7).Text.Trim() == "");
					num = 106;
					continue;
				case 106:
					if (!flag)
					{
						num = 117;
						continue;
					}
					goto case 6;
				case 71:
					if (!flag)
					{
						num = 92;
						continue;
					}
					MessageBox.Show("اطلاعات اصلاح شد");
					num = 27;
					continue;
				case 19:
					a_20 = DBNull.Value;
					num = 15;
					continue;
				case 124:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT DISTINCT Xtest FROM tMark WHERE(xStudent = " + this.a + ") AND (xbook IN  (SELECT     id  FROM         tBook   WHERE     (xPaye = " + ((Control)a4).Tag.ToString() + " ))) AND (Xtest IN (SELECT id FROM texam WHERE     xyear = " + ((Control)cb).Text + "))");
					flag = dataTable.Rows.Count <= 0;
					num = 97;
					continue;
				case 97:
					if (!flag)
					{
						num = 37;
						continue;
					}
					goto case 56;
				case 16:
					flag = num5 <= 0;
					num = 138;
					continue;
				case 138:
					if (!flag)
					{
						num = 35;
						continue;
					}
					return;
				case 102:
				case 119:
					num = 57;
					continue;
				case 33:
					a_24 = DBNull.Value;
					num = 42;
					continue;
				case 10:
					MessageBox.Show("نام را وارد کنید");
					((Control)this.m_w).Focus();
					num = 129;
					continue;
				case 129:
					return;
				case 21:
					if (!flag)
					{
						num = 46;
						continue;
					}
					try
					{
						while (true)
						{
							IL_0b21:
							string text3 = ((Control)az).Text;
							DateTime dateTime = ShamsiDate.ShamsiToGregory(text3);
							string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
							flag = !(shamsiDate != text3);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									num = ((!flag) ? 2 : 0);
									continue;
								case 2:
									MessageBox.Show("تاریخ شمولیت اشتباه است");
									((Control)az).Focus();
									num = 3;
									continue;
								case 3:
									return;
								case 0:
									goto end_IL_0b08;
								}
								goto IL_0b21;
								continue;
								end_IL_0b08:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ شمولیت اشتباه است");
						((Control)az).Focus();
						return;
					}
					num = 25;
					continue;
				case 37:
					flag = 6 == (int)MessageBox.Show("با اصلاح پایه شاگرد نمرات قبلی شاگرد در این سال حذف میشود\nآیا مطمئن هستید؟", "اخطار", (MessageBoxButtons)4, (MessageBoxIcon)48);
					num = 143;
					continue;
				case 143:
					if (!flag)
					{
						num = 140;
						continue;
					}
					text = "";
					num3 = 0;
					num = 120;
					continue;
				case 28:
					flag = ((CollectionBase)(object)ce.Items).Count != 0;
					num = 76;
					continue;
				case 76:
					if (flag)
					{
						flag = !((Control)cg).Enabled;
						num = 71;
					}
					else
					{
						num = 1;
					}
					continue;
				case 103:
					a_23 = DBNull.Value;
					num = 51;
					continue;
				case 104:
					a_17 = ((Control)b6).Text;
					flag = !(((Control)b6).Text.Trim() == "");
					num = 53;
					continue;
				case 53:
					if (!flag)
					{
						num = 111;
						continue;
					}
					goto case 66;
				case 111:
					a_17 = DBNull.Value;
					num = 66;
					continue;
				case 148:
					a_16 = DBNull.Value;
					num = 110;
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "DELETE FROM tMark WHERE (xStudent = " + this.a + ") AND (Xtest IN (" + text + "))");
					asdcb.d(asdab.e(), CommandType.Text, "DELETE FROM tMarkDoreh WHERE (xStudent = " + this.a + ") AND (Xtest IN (" + text + "))");
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tExam SET procc = 0 WHERE id in(" + text + ")");
					num = 56;
					continue;
				case 68:
					if (!flag)
					{
						num = 45;
						continue;
					}
					goto case 134;
				case 135:
					MessageBox.Show("نمبر اساس تکراری است");
					((EditBase)this.m_ae).SelectAll();
					((Control)this.m_ae).Focus();
					num = 141;
					continue;
				case 141:
					return;
				case 69:
					text += dataTable.Rows[num3][0].ToString();
					num3++;
					num = 108;
					continue;
				case 140:
					num = 132;
					continue;
				case 132:
					return;
				case 95:
					a_7 = DBNull.Value;
					num = 3;
					continue;
				case 13:
					num = (flag ? 75 : 65);
					continue;
				case 116:
					a_8 = ((Control)bz).Text;
					flag = !(((Control)bz).Text.Trim() == "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 126;
				case 78:
					a_3 = DBNull.Value;
					num = 41;
					continue;
				case 38:
					a_2 = ct.SelectedValue.ToString();
					num = 34;
					continue;
				case 83:
					a_ = DBNull.Value;
					num = 7;
					continue;
				case 29:
				case 82:
					flag = a4.SelectedIndex >= 0;
					num = 99;
					continue;
				case 99:
					if (flag)
					{
						flag = this.m_d.SelectedIndex >= 0;
						num = 21;
					}
					else
					{
						num = 121;
					}
					continue;
				case 59:
					MessageBox.Show("ولد/بنت را وارد کنید");
					((Control)this.m_u).Focus();
					num = 55;
					continue;
				case 55:
					return;
				case 92:
					flag = (int)MessageBox.Show("اطلاعات اصلاح شد . آیا مایل هستید نفر بعدی نمایش داده شود", "", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6;
					num = 96;
					continue;
				case 96:
					if (!flag)
					{
						num = 86;
						continue;
					}
					((Control)a4).Tag = a4.SelectedValue;
					num = 122;
					continue;
				case 70:
					if (!flag)
					{
						num = 115;
						continue;
					}
					goto case 69;
				case 121:
					MessageBox.Show("پایه را مشخص کنید");
					((UIComboBase)a4).Focus();
					num = 107;
					continue;
				case 107:
					return;
				case 64:
					a_23 = ((Control)c5).Text;
					flag = !(((Control)c5).Text.Trim() == "");
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 103;
						continue;
					}
					goto case 51;
				case 142:
					a_21 = DBNull.Value;
					num = 43;
					continue;
				case 115:
					text += ",";
					num = 69;
					continue;
				case 139:
					a_10 = "";
					flag = !(this.a != "0");
					num = 0;
					continue;
				case 0:
					if (flag)
					{
						a_10 = ((DbParameter)(object)array[0]).Value.ToString();
						num = 109;
					}
					else
					{
						num = 50;
					}
					continue;
				case 67:
					a_2 = "0";
					flag = ct.SelectedIndex < 0;
					num = 72;
					continue;
				case 72:
					if (!flag)
					{
						num = 38;
						continue;
					}
					goto case 34;
				case 50:
					a_10 = this.a;
					num = 89;
					continue;
				case 35:
					asdaj.h = true;
					flag = !(this.a != "0");
					num = 73;
					continue;
				case 73:
					if (!flag)
					{
						num = 28;
						continue;
					}
					asdaj.j = ((Control)this.m_w).Text + " " + ((Control)this.m_u).Text;
					((Control)cp).Text = asdaj.j;
					MessageBox.Show("ثبت شد");
					i();
					((Control)this.m_w).Focus();
					num = 74;
					continue;
				case 31:
					a_27 = DBNull.Value;
					num = 17;
					continue;
				case 7:
					a_19 = ((Control)b1).Text;
					flag = !(((Control)b1).Text.Trim() == "");
					num = 63;
					continue;
				case 63:
					if (!flag)
					{
						num = 101;
						continue;
					}
					goto case 104;
				case 49:
					a_15 = DBNull.Value;
					num = 93;
					continue;
				case 112:
					try
					{
						long num4 = long.Parse(((Control)this.m_q).Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای کد متعلم فقط عدد وارد کنید");
						((Control)this.m_q).Focus();
						return;
					}
					num = 82;
					continue;
				case 34:
					a_4 = "0";
					flag = c6.SelectedIndex < 0;
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 84;
						continue;
					}
					goto case 64;
				case 147:
					a_20 = ((Control)bh).Text;
					flag = !(((Control)bh).Text.Trim() == "");
					num = 62;
					continue;
				case 62:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 15;
				case 42:
					a_26 = ((Control)b5).Text;
					flag = !(((Control)b5).Text.Trim() == "");
					num = 146;
					continue;
				case 146:
					if (!flag)
					{
						num = 32;
						continue;
					}
					goto case 80;
				case 22:
					a_22 = DBNull.Value;
					num = 144;
					continue;
				case 32:
					a_26 = DBNull.Value;
					num = 80;
					continue;
				case 93:
					a_25 = ((Control)bc).Text;
					flag = !(((Control)bc).Text.Trim() == "");
					num = 131;
					continue;
				case 131:
					if (!flag)
					{
						num = 114;
						continue;
					}
					goto case 147;
				case 11:
					a_8 = DBNull.Value;
					num = 126;
					continue;
				case 144:
					a_24 = ((Control)b0).Text;
					flag = !(((Control)b0).Text.Trim() == "");
					num = 145;
					continue;
				case 145:
					if (!flag)
					{
						num = 33;
						continue;
					}
					goto case 42;
				case 43:
					a_16 = ((Control)bg).Text;
					flag = !(((Control)bg).Text.Trim() == "");
					num = 61;
					continue;
				case 61:
					if (!flag)
					{
						num = 148;
						continue;
					}
					goto case 110;
				case 51:
					array = new SqlParameter[63]
					{
						asdcb.a("@CodeOut", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.Int, this.a),
						asdcb.a("@xYear", SqlDbType.Int, ((Control)cb).Text),
						asdcb.a("@xpaye", SqlDbType.Int, a4.SelectedValue.ToString()),
						asdcb.a("@xClass", SqlDbType.Int, this.m_d.SelectedValue.ToString()),
						asdcb.a("@Code", SqlDbType.BigInt, a_11),
						asdcb.a("@FName", SqlDbType.NVarChar, asdaj.b(((Control)this.m_w).Text)),
						asdcb.a("@LName", SqlDbType.NVarChar, asdaj.b(((Control)this.m_u).Text)),
						asdcb.a("@PName", SqlDbType.NVarChar, asdaj.b(((Control)this.m_s).Text)),
						asdcb.a("@Sh_Sh", SqlDbType.NVarChar, asdaj.b(((Control)this.m_aa).Text)),
						asdcb.a("@bDate", SqlDbType.NVarChar, asdaj.b(((Control)cd).Text)),
						asdcb.a("@bDateM", SqlDbType.NVarChar, asdaj.b(((Control)c8).Text)),
						asdcb.a("@MobileFather", SqlDbType.NVarChar, asdaj.b(((Control)this.m_l).Text)),
						asdcb.a("@MobileMother", SqlDbType.NVarChar, asdaj.b(((Control)this.m_m).Text)),
						asdcb.a("@NumberTelegram", SqlDbType.NVarChar, asdaj.b(((Control)this.m_ad).Text)),
						asdcb.a("@NumberTelegram2", SqlDbType.NVarChar, DBNull.Value),
						asdcb.a("@Jens", SqlDbType.SmallInt, this.m_y.SelectedValue.ToString()),
						asdcb.a("@Mazhab", SqlDbType.SmallInt, this.m_ah.SelectedValue.ToString()),
						asdcb.a("@NumberAsas", SqlDbType.Int, a_12),
						asdcb.a("@RegDate", SqlDbType.NVarChar, asdaj.b(((Control)az).Text)),
						asdcb.a("@Adress", SqlDbType.NVarChar, asdaj.b(((Control)this.m_am).Text)),
						asdcb.a("@ExitDate", SqlDbType.NVarChar, asdaj.b(((Control)a0).Text)),
						asdcb.a("@Status", SqlDbType.Int, this.m_ai.SelectedValue.ToString()),
						asdcb.a("@shaghe", SqlDbType.Bit, this.m_aw.Checked),
						asdcb.a("@hazer", SqlDbType.Bit, this.m_av.Checked),
						asdcb.a("@mali", SqlDbType.Bit, ax.Checked),
						asdcb.a("@dakhle", SqlDbType.Bit, this.m_ap.Checked),
						asdcb.a("@uniform", SqlDbType.Bit, this.m_ao.Checked),
						asdcb.a("@komakdarsi", SqlDbType.Bit, this.m_at.Checked),
						asdcb.a("@ketab", SqlDbType.Bit, this.m_as.Checked),
						asdcb.a("@transport", SqlDbType.Bit, this.m_ar.Checked),
						asdcb.a("@robotic", SqlDbType.Bit, this.m_aq.Checked),
						asdcb.a("@maghnae", SqlDbType.Bit, this.m_au.Checked),
						asdcb.a("@MarkTerm3_From100", SqlDbType.Bit, c3.Checked),
						asdcb.a("@Fee1", SqlDbType.Int, a_3),
						asdcb.a("@Fee2", SqlDbType.Int, a_),
						asdcb.a("@Fee3", SqlDbType.Int, a_19),
						asdcb.a("@Fee4", SqlDbType.Int, a_17),
						asdcb.a("@Fee5", SqlDbType.Int, a_22),
						asdcb.a("@Fee6", SqlDbType.Int, a_24),
						asdcb.a("@Fee7", SqlDbType.Int, a_26),
						asdcb.a("@Fee8", SqlDbType.Int, a_14),
						asdcb.a("@Fee9", SqlDbType.Int, a_8),
						asdcb.a("@SumFee", SqlDbType.Int, a_7),
						asdcb.a("@xTakhfif", SqlDbType.Int, ck.SelectedValue),
						asdcb.a("@transport1", SqlDbType.Int, a_13),
						asdcb.a("@transport2", SqlDbType.Int, a_15),
						asdcb.a("@transport3", SqlDbType.Int, a_25),
						asdcb.a("@transport4", SqlDbType.Int, a_20),
						asdcb.a("@transport5", SqlDbType.Int, a_27),
						asdcb.a("@transport6", SqlDbType.Int, a_21),
						asdcb.a("@transport7", SqlDbType.Int, a_16),
						asdcb.a("@transport8", SqlDbType.Int, a_5),
						asdcb.a("@transport9", SqlDbType.Int, a_6),
						asdcb.a("@Sumtransport", SqlDbType.Int, a_18),
						asdcb.a("@xDriver", SqlDbType.Int, cs.SelectedValue.ToString()),
						asdcb.a("@xcity", SqlDbType.Int, a_2),
						asdcb.a("@En_Fname", SqlDbType.NVarChar, asdaj.b(((Control)cy).Text)),
						asdcb.a("@En_Lname", SqlDbType.NVarChar, asdaj.b(((Control)cw).Text)),
						asdcb.a("@LastName", SqlDbType.NVarChar, asdaj.b(((Control)c0).Text)),
						asdcb.a("@En_LastName", SqlDbType.NVarChar, asdaj.b(((Control)c2).Text)),
						asdcb.a("@xCityNow", SqlDbType.Int, a_4),
						asdcb.a("@codeTakhfif", SqlDbType.Int, a_23)
					};
					num5 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tStudent_insertUpdate", array);
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "-100");
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						flag = !(((DbParameter)(object)array[0]).Value.ToString() == "-200");
						num = 12;
					}
					else
					{
						num = 88;
					}
					continue;
				case 15:
					a_27 = ((Control)be).Text;
					flag = !(((Control)be).Text.Trim() == "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 17;
				case 25:
					try
					{
						while (true)
						{
							IL_1739:
							flag = !(((Control)cd).Text != "");
							num = 6;
							while (true)
							{
								switch (num)
								{
								case 6:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 4;
								case 0:
								{
									string text2 = ((Control)cd).Text;
									DateTime dateTime = ShamsiDate.ShamsiToGregory(text2);
									string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
									flag = !(shamsiDate != text2);
									num = 3;
									continue;
								}
								case 3:
									num = ((!flag) ? 2 : 4);
									continue;
								case 2:
									MessageBox.Show("تاریخ تولد اشتباه است");
									((Control)cd).Focus();
									num = 5;
									continue;
								case 5:
									return;
								case 4:
									num = 1;
									continue;
								case 1:
									goto end_IL_1714;
								}
								goto IL_1739;
								continue;
								end_IL_1714:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ تولد اشتباه است");
						((Control)cd).Focus();
						return;
					}
					flag = !(this.a != "0");
					num = 68;
					continue;
				case 65:
					num = 90;
					continue;
				case 101:
					a_19 = DBNull.Value;
					num = 104;
					continue;
				case 128:
					a_11 = DBNull.Value;
					num = 87;
					continue;
				case 117:
					a_18 = DBNull.Value;
					num = 6;
					continue;
				case 105:
					a_6 = ((Control)ba).Text;
					flag = !(((Control)ba).Text.Trim() == "");
					num = 130;
					continue;
				case 130:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 58;
				case 41:
					a_ = ((Control)b4).Text;
					flag = !(((Control)b4).Text.Trim() == "");
					num = 77;
					continue;
				case 77:
					if (!flag)
					{
						num = 83;
						continue;
					}
					goto case 7;
				case 123:
					a_15 = ((Control)bf).Text;
					flag = !(((Control)bf).Text.Trim() == "");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 49;
						continue;
					}
					goto case 93;
				case 88:
					MessageBox.Show("کد متعلم تکراری است");
					((EditBase)this.m_q).SelectAll();
					((Control)this.m_q).Focus();
					num = 36;
					continue;
				case 36:
					return;
				case 118:
					if (flag)
					{
						flag = !(((Control)this.m_ae).Text.Trim() == "");
						num = 13;
					}
					else
					{
						num = 59;
					}
					continue;
				case 110:
					a_5 = ((Control)bd).Text;
					flag = !(((Control)bd).Text.Trim() == "");
					num = 98;
					continue;
				case 98:
					if (!flag)
					{
						num = 81;
						continue;
					}
					goto case 105;
				case 126:
					a_7 = ((Control)a5).Text;
					flag = !(((Control)a5).Text.Trim() == "");
					num = 137;
					continue;
				case 137:
					if (!flag)
					{
						num = 95;
						continue;
					}
					goto case 3;
				case 94:
					a_14 = DBNull.Value;
					num = 116;
					continue;
				case 134:
					a_3 = ((Control)b7).Text;
					flag = !(((Control)b7).Text.Trim() == "");
					num = 48;
					continue;
				case 48:
					if (!flag)
					{
						num = 78;
						continue;
					}
					goto case 41;
				case 91:
					a_13 = DBNull.Value;
					num = 123;
					continue;
				case 46:
					MessageBox.Show("صنف را مشخص کنید");
					((UIComboBase)this.m_d).Focus();
					num = 125;
					continue;
				case 125:
					return;
				case 86:
					r((object)this, (EventArgs)null);
					num = 100;
					continue;
				case 14:
					a_12 = DBNull.Value;
					num = 67;
					continue;
				case 87:
					a_12 = ((Control)this.m_ae).Text;
					flag = !(((Control)this.m_ae).Text.Trim() == "");
					num = 52;
					continue;
				case 52:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 67;
				case 113:
					num = 134;
					continue;
				case 100:
				case 122:
					if (true)
					{
					}
					num = 54;
					continue;
				case 136:
					if (!flag)
					{
						num = 139;
						continue;
					}
					goto case 16;
				case 17:
					a_21 = ((Control)bb).Text;
					flag = !(((Control)bb).Text.Trim() == "");
					num = 47;
					continue;
				case 47:
					if (!flag)
					{
						num = 142;
						continue;
					}
					goto case 43;
				case 89:
				case 109:
				{
					SqlParameter[] a_9 = new SqlParameter[2]
					{
						asdcb.a("@id", SqlDbType.BigInt, a_10),
						asdcb.a("@img", SqlDbType.Image, asdab.b(this.m_b))
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tStudentImg_InsertUpdate", a_9);
					this.m_b = "";
					num = 16;
					continue;
				}
				case 108:
				case 120:
					flag = num3 < dataTable.Rows.Count;
					num = 23;
					continue;
				case 23:
					if (flag)
					{
						flag = !(text != "");
						num = 70;
					}
					else
					{
						num = 2;
					}
					continue;
				case 66:
					a_22 = ((Control)b3).Text;
					flag = !(((Control)b3).Text.Trim() == "");
					num = 127;
					continue;
				case 127:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 144;
				case 1:
					((Form)this).Close();
					num = 102;
					continue;
				case 4:
					a_6 = DBNull.Value;
					num = 58;
					continue;
				case 27:
				case 54:
					f();
					num = 119;
					continue;
				case 81:
					a_5 = DBNull.Value;
					num = 105;
					continue;
				case 3:
					a_13 = ((Control)bi).Text;
					flag = !(((Control)bi).Text.Trim() == "");
					num = 133;
					continue;
				case 133:
					if (!flag)
					{
						num = 91;
						continue;
					}
					goto case 123;
				case 84:
					a_4 = c6.SelectedValue.ToString();
					num = 64;
					continue;
				case 75:
					try
					{
						int num2 = int.Parse(((Control)this.m_ae).Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای نبر اساس فقط عدد وارد کنید");
						((Control)this.m_ae).Focus();
						return;
					}
					num = 85;
					continue;
				case 44:
					num = 29;
					continue;
				case 80:
					a_14 = ((Control)b2).Text;
					flag = !(((Control)b2).Text.Trim() == "");
					num = 30;
					continue;
				case 30:
					if (!flag)
					{
						num = 94;
						continue;
					}
					goto case 116;
				case 57:
				case 74:
					num = 60;
					continue;
				case 60:
					return;
				case 45:
					flag = !(a4.SelectedValue.ToString() != ((Control)a4).Tag.ToString());
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 124;
						continue;
					}
					goto case 113;
				case 85:
				case 90:
					flag = !(((Control)this.m_q).Text.Trim() == "");
					num = 79;
					continue;
				case 79:
					num = ((!flag) ? 44 : 112);
					continue;
				case 56:
					num = 113;
					continue;
				}
				break;
			}
		}
	}

	private void ar(object A_0, EventArgs A_1)
	{
		l();
	}

	private void aq(object A_0, EventArgs A_1)
	{
	}

	private void j()
	{
		while (true)
		{
			SqlParameter[] a_ = new SqlParameter[2]
			{
				asdcb.a("@xYear", SqlDbType.Int, ((Control)cb).Text),
				asdcb.a("@xStudent", SqlDbType.Int, this.a)
			};
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Sh_Sh, tStudent.bDate, tStudent.bDateM,tStudent.MobileFather, tStudent.MobileMother,\r\n                        tStudent.xCity, tStudent.En_Fname, tStudent.En_Lname,  tStudent.LastName, tStudent.En_LastName,\r\n                      tStudent.NumberTelegram, tStudent.NumberTelegram2, tStudent.Jens, tStudent.Mazhab, tStudent.NumberAsas, tStudent.RegDate, tStudent.Adress,tStudent.xCityNow,tYear_Student.codeTakhfif, \r\n                      tStudent.ExitDate, tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.Status, tYear_Student.shaghe, tYear_Student.hazer, tYear_Student.mali,tYear_Student.MarkTerm3_From100 ,\r\n                      tYear_Student.dakhle, tYear_Student.uniform, tYear_Student.komakdarsi, tYear_Student.ketab, tYear_Student.transport, tYear_Student.robotic, \r\n                      tYear_Student.maghnae, tYear_Student.Sumtransport, tYear_Student.transport1, tYear_Student.transport2, tYear_Student.transport3, \r\n                      tYear_Student.transport4, tYear_Student.transport5, tYear_Student.transport6, tYear_Student.transport7, tYear_Student.transport8, \r\n                      tYear_Student.transport9, tYear_Student.fee1, tYear_Student.fee2, tYear_Student.fee3, tYear_Student.fee4, tYear_Student.fee5, tYear_Student.fee6, \r\n                      tYear_Student.fee7, tYear_Student.fee8, tYear_Student.fee9,tYear_Student.SumFee,tYear_Student.xTakhfif, tYear_Student.xYear, tYear_Student.xStudent,tYear_Student.xDriver\r\n                      FROM         tYear_Student INNER JOIN\r\n                      tStudent ON tYear_Student.xStudent = tStudent.id\r\n                      WHERE     (tYear_Student.xYear = @xYear) AND (tYear_Student.xStudent = @xStudent)", a_);
			a4.SelectedValue = dataTable.Rows[0]["xPaye"].ToString();
			((Control)a4).Tag = dataTable.Rows[0]["xPaye"].ToString();
			this.m_d.SelectedValue = dataTable.Rows[0]["xClass"].ToString();
			((Control)this.m_q).Text = dataTable.Rows[0]["Code"].ToString();
			((Control)this.m_w).Text = dataTable.Rows[0]["FName"].ToString();
			((Control)this.m_u).Text = dataTable.Rows[0]["LName"].ToString();
			((Control)this.m_s).Text = dataTable.Rows[0]["PName"].ToString();
			((Control)cy).Text = dataTable.Rows[0]["En_Fname"].ToString();
			((Control)cw).Text = dataTable.Rows[0]["En_Lname"].ToString();
			ct.SelectedValue = dataTable.Rows[0]["xCity"].ToString();
			c6.SelectedValue = dataTable.Rows[0]["xCityNow"].ToString();
			((Control)c5).Text = dataTable.Rows[0]["codeTakhfif"].ToString();
			((Control)c2).Text = dataTable.Rows[0]["En_LastName"].ToString();
			((Control)c0).Text = dataTable.Rows[0]["LastName"].ToString();
			((Control)this.m_aa).Text = dataTable.Rows[0]["Sh_Sh"].ToString();
			((Control)cd).Text = dataTable.Rows[0]["bDate"].ToString();
			((Control)c8).Text = dataTable.Rows[0]["bDateM"].ToString();
			((Control)this.m_l).Text = dataTable.Rows[0]["MobileFather"].ToString();
			((Control)this.m_m).Text = dataTable.Rows[0]["MobileMother"].ToString();
			((Control)this.m_ad).Text = dataTable.Rows[0]["NumberTelegram"].ToString();
			this.m_y.SelectedValue = dataTable.Rows[0]["Jens"].ToString();
			this.m_ah.SelectedValue = dataTable.Rows[0]["Mazhab"].ToString();
			ck.SelectedValue = dataTable.Rows[0]["xtakhfif"].ToString();
			cs.SelectedValue = dataTable.Rows[0]["xDriver"].ToString();
			((Control)this.m_ae).Text = dataTable.Rows[0]["NumberAsas"].ToString();
			((Control)az).Text = dataTable.Rows[0]["RegDate"].ToString();
			((Control)this.m_am).Text = dataTable.Rows[0]["Adress"].ToString();
			((Control)a0).Text = dataTable.Rows[0]["ExitDate"].ToString();
			this.m_ai.SelectedValue = dataTable.Rows[0]["Status"].ToString();
			if (true)
			{
			}
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 7:
					try
					{
						this.m_as.Checked = bool.Parse(dataTable.Rows[0]["ketab"].ToString());
					}
					catch
					{
					}
					num = 6;
					continue;
				case 11:
					try
					{
						c3.Checked = bool.Parse(dataTable.Rows[0]["MarkTerm3_From100"].ToString());
					}
					catch
					{
					}
					num = 10;
					continue;
				case 4:
					try
					{
						this.m_p.Image = asdab.a((byte[])asdcb.a(asdab.e(), CommandType.Text, "select Student_img from tStudentImg where xStudent=" + this.a));
					}
					catch
					{
						this.m_p.Image = null;
					}
					num = 8;
					continue;
				case 1:
					try
					{
						this.m_ao.Checked = bool.Parse(dataTable.Rows[0]["uniform"].ToString());
					}
					catch
					{
					}
					num = 2;
					continue;
				case 9:
					try
					{
						this.m_aw.Checked = bool.Parse(dataTable.Rows[0]["shaghe"].ToString());
					}
					catch
					{
					}
					num = 5;
					continue;
				case 0:
					try
					{
						ax.Checked = bool.Parse(dataTable.Rows[0]["mali"].ToString());
					}
					catch
					{
					}
					num = 11;
					continue;
				case 10:
					try
					{
						this.m_ap.Checked = bool.Parse(dataTable.Rows[0]["dakhle"].ToString());
					}
					catch
					{
					}
					num = 1;
					continue;
				case 3:
					try
					{
						this.m_au.Checked = bool.Parse(dataTable.Rows[0]["maghnae"].ToString());
					}
					catch
					{
					}
					((Control)b7).Text = dataTable.Rows[0]["Fee1"].ToString();
					((Control)b4).Text = dataTable.Rows[0]["Fee2"].ToString();
					((Control)b1).Text = dataTable.Rows[0]["Fee3"].ToString();
					((Control)b6).Text = dataTable.Rows[0]["Fee4"].ToString();
					((Control)b3).Text = dataTable.Rows[0]["Fee5"].ToString();
					((Control)b0).Text = dataTable.Rows[0]["Fee6"].ToString();
					((Control)b5).Text = dataTable.Rows[0]["Fee7"].ToString();
					((Control)b2).Text = dataTable.Rows[0]["Fee8"].ToString();
					((Control)bz).Text = dataTable.Rows[0]["Fee9"].ToString();
					((Control)a5).Text = dataTable.Rows[0]["SumFee"].ToString();
					((Control)bi).Text = dataTable.Rows[0]["transport1"].ToString();
					((Control)bf).Text = dataTable.Rows[0]["transport2"].ToString();
					((Control)bc).Text = dataTable.Rows[0]["transport3"].ToString();
					((Control)bh).Text = dataTable.Rows[0]["transport4"].ToString();
					((Control)be).Text = dataTable.Rows[0]["transport5"].ToString();
					((Control)bb).Text = dataTable.Rows[0]["transport6"].ToString();
					((Control)bg).Text = dataTable.Rows[0]["transport7"].ToString();
					((Control)bd).Text = dataTable.Rows[0]["transport8"].ToString();
					((Control)ba).Text = dataTable.Rows[0]["transport9"].ToString();
					((Control)a7).Text = dataTable.Rows[0]["Sumtransport"].ToString();
					num = 4;
					continue;
				case 5:
					try
					{
						this.m_av.Checked = bool.Parse(dataTable.Rows[0]["hazer"].ToString());
					}
					catch
					{
					}
					num = 0;
					continue;
				case 6:
					try
					{
						this.m_ar.Checked = bool.Parse(dataTable.Rows[0]["transport"].ToString());
					}
					catch
					{
					}
					num = 12;
					continue;
				case 2:
					try
					{
						this.m_at.Checked = bool.Parse(dataTable.Rows[0]["komakdarsi"].ToString());
					}
					catch
					{
					}
					num = 7;
					continue;
				case 8:
					try
					{
						((Control)cm).Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_d.SelectedValue.ToString()).ToString();
					}
					catch
					{
						((Control)cm).Text = "";
						((Control)a5).Text = "";
					}
					h();
					return;
				case 12:
					try
					{
						this.m_aq.Checked = bool.Parse(dataTable.Rows[0]["robotic"].ToString());
					}
					catch
					{
					}
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void v(object A_0, KeyEventArgs A_1)
	{
	}

	private void i()
	{
		while (true)
		{
			((Control)this.m_q).Text = "";
			((Control)this.m_w).Text = "";
			((Control)this.m_u).Text = "";
			((Control)this.m_s).Text = "";
			((Control)this.m_aa).Text = "";
			((Control)cd).Text = "";
			((Control)c8).Text = "";
			((Control)this.m_l).Text = "";
			((Control)this.m_m).Text = "";
			((Control)this.m_ad).Text = "";
			((Control)this.m_ae).Text = "";
			((Control)this.m_am).Text = "";
			((Control)a0).Text = "";
			((Control)c5).Text = "";
			((Control)bi).Text = "";
			((Control)bf).Text = "";
			((Control)bc).Text = "";
			((Control)bh).Text = "";
			((Control)be).Text = "";
			((Control)bb).Text = "";
			((Control)bg).Text = "";
			((Control)bd).Text = "";
			((Control)ba).Text = "";
			((Control)a7).Text = "";
			((Control)cw).Text = "";
			((Control)cy).Text = "";
			((Control)c2).Text = "";
			((Control)c0).Text = "";
			bool flag = !((Control)ct).Enabled;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 5;
				case 1:
					flag = !((Control)ck).Enabled;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 11;
				case 12:
					flag = !((Control)this.m_ah).Enabled;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 1;
				case 8:
					if (true)
					{
					}
					this.m_ah.SelectedIndex = 0;
					num = 1;
					continue;
				case 5:
					flag = !((Control)c6).Enabled;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 16;
				case 11:
					flag = !((Control)cs).Enabled;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 2;
				case 17:
					ct.SelectedIndex = 0;
					num = 5;
					continue;
				case 10:
					ck.SelectedIndex = 0;
					num = 11;
					continue;
				case 15:
					cs.SelectedIndex = 0;
					num = 2;
					continue;
				case 4:
					this.m_y.SelectedIndex = 0;
					num = 12;
					continue;
				case 14:
					c6.SelectedIndex = 0;
					num = 16;
					continue;
				case 16:
					flag = !((Control)this.m_y).Enabled;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 12;
				case 2:
					this.m_p.Image = null;
					this.m_b = "";
					return;
				}
				break;
			}
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_am).BackColor = Color.White;
	}

	private void ao(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_am).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void an(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_w).BackColor = Color.White;
	}

	private void am(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_w).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void al(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_u).BackColor = Color.White;
	}

	private void ak(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_u).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void aj(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_s).BackColor = Color.White;
	}

	private void ai(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_s).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void ah(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_ad).BackColor = Color.White;
	}

	private void ag(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_ad).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void af(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_l).BackColor = Color.White;
	}

	private void ae(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_l).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void ad(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_m).BackColor = Color.White;
	}

	private void ac(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_m).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void ab(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_aa).BackColor = Color.White;
	}

	private void aa(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_aa).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void z(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_ae).BackColor = Color.White;
	}

	private void y(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_ae).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void u(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			if (true)
			{
			}
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
					try
					{
						((Control)bf).Text = ((Control)bi).Text;
						((Control)bc).Text = ((Control)bi).Text;
						((Control)bh).Text = ((Control)bi).Text;
						((Control)be).Text = ((Control)bi).Text;
						((Control)bb).Text = ((Control)bi).Text;
						((Control)bg).Text = ((Control)bi).Text;
						((Control)bd).Text = ((Control)bi).Text;
						((Control)ba).Text = ((Control)bi).Text;
					}
					catch
					{
					}
					d();
					num = 3;
					continue;
				case 2:
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void t(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 3;
						continue;
					}
					try
					{
						((Control)bc).Text = ((Control)bf).Text;
						((Control)bh).Text = ((Control)bf).Text;
						((Control)be).Text = ((Control)bf).Text;
						((Control)bb).Text = ((Control)bf).Text;
						((Control)bg).Text = ((Control)bf).Text;
						((Control)bd).Text = ((Control)bf).Text;
						((Control)ba).Text = ((Control)bf).Text;
					}
					catch
					{
					}
					d();
					num = 1;
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					return;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void s(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
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
					try
					{
						((Control)bh).Text = ((Control)bc).Text;
						((Control)be).Text = ((Control)bc).Text;
						((Control)bb).Text = ((Control)bc).Text;
						((Control)bg).Text = ((Control)bc).Text;
						((Control)bd).Text = ((Control)bc).Text;
						((Control)ba).Text = ((Control)bc).Text;
					}
					catch
					{
					}
					d();
					num = 0;
					continue;
				case 3:
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void r(object A_0, KeyEventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 1;
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
					try
					{
						((Control)be).Text = ((Control)bh).Text;
						((Control)bb).Text = ((Control)bh).Text;
						((Control)bg).Text = ((Control)bh).Text;
						((Control)bd).Text = ((Control)bh).Text;
						((Control)ba).Text = ((Control)bh).Text;
					}
					catch
					{
					}
					d();
					num = 2;
					continue;
				case 0:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void q(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					try
					{
						((Control)bb).Text = ((Control)be).Text;
						((Control)bg).Text = ((Control)be).Text;
						((Control)bd).Text = ((Control)be).Text;
						((Control)ba).Text = ((Control)be).Text;
					}
					catch
					{
					}
					d();
					if (true)
					{
					}
					num = 1;
					continue;
				case 3:
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void p(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
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
						num = 3;
						continue;
					}
					try
					{
						((Control)bg).Text = ((Control)bb).Text;
						((Control)bd).Text = ((Control)bb).Text;
						((Control)ba).Text = ((Control)bb).Text;
					}
					catch
					{
					}
					d();
					num = 2;
					continue;
				case 3:
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void o(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 1;
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
					try
					{
						((Control)bd).Text = ((Control)bg).Text;
						((Control)ba).Text = ((Control)bg).Text;
					}
					catch
					{
					}
					d();
					num = 2;
					continue;
				case 0:
					num = 3;
					continue;
				case 2:
				case 3:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void n(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = a(A_1.KeyValue);
			int num = 2;
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
					try
					{
						((Control)ba).Text = ((Control)bd).Text;
					}
					catch
					{
					}
					d();
					num = 0;
					continue;
				case 3:
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void m(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					if (true)
					{
					}
					d();
					num = 2;
					continue;
				case 2:
					return;
				case 3:
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void l(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
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
					try
					{
						((Control)b4).Text = ((Control)b7).Text;
						((Control)b1).Text = ((Control)b7).Text;
						((Control)b6).Text = ((Control)b7).Text;
						((Control)b3).Text = ((Control)b7).Text;
						((Control)b0).Text = ((Control)b7).Text;
						((Control)b5).Text = ((Control)b7).Text;
						((Control)b2).Text = ((Control)b7).Text;
						((Control)bz).Text = ((Control)b7).Text;
					}
					catch
					{
					}
					b();
					if (true)
					{
					}
					num = 3;
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void k(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 2;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					try
					{
						((Control)b1).Text = ((Control)b4).Text;
						((Control)b6).Text = ((Control)b4).Text;
						((Control)b3).Text = ((Control)b4).Text;
						((Control)b0).Text = ((Control)b4).Text;
						((Control)b5).Text = ((Control)b4).Text;
						((Control)b2).Text = ((Control)b4).Text;
						((Control)bz).Text = ((Control)b4).Text;
					}
					catch
					{
					}
					b();
					num = 3;
					continue;
				case 1:
					num = 0;
					continue;
				case 0:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void j(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
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
					try
					{
						((Control)b6).Text = ((Control)b1).Text;
						((Control)b3).Text = ((Control)b1).Text;
						((Control)b0).Text = ((Control)b1).Text;
						((Control)b5).Text = ((Control)b1).Text;
						((Control)b2).Text = ((Control)b1).Text;
						((Control)bz).Text = ((Control)b1).Text;
					}
					catch
					{
					}
					if (true)
					{
					}
					b();
					num = 3;
					continue;
				case 2:
					num = 1;
					continue;
				case 1:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void i(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					try
					{
						((Control)b3).Text = ((Control)b6).Text;
						((Control)b0).Text = ((Control)b6).Text;
						((Control)b5).Text = ((Control)b6).Text;
						((Control)b2).Text = ((Control)b6).Text;
						((Control)bz).Text = ((Control)b6).Text;
					}
					catch
					{
					}
					b();
					num = 2;
					continue;
				case 3:
					num = 1;
					continue;
				case 1:
				case 2:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
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
					try
					{
						((Control)b0).Text = ((Control)b3).Text;
						((Control)b5).Text = ((Control)b3).Text;
						((Control)b2).Text = ((Control)b3).Text;
						((Control)bz).Text = ((Control)b3).Text;
					}
					catch
					{
					}
					b();
					if (true)
					{
					}
					num = 0;
					continue;
				case 1:
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void g(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			if (true)
			{
			}
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
					try
					{
						((Control)b5).Text = ((Control)b0).Text;
						((Control)b2).Text = ((Control)b0).Text;
						((Control)bz).Text = ((Control)b0).Text;
					}
					catch
					{
					}
					b();
					num = 1;
					continue;
				case 0:
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					try
					{
						((Control)b2).Text = ((Control)b5).Text;
						((Control)bz).Text = ((Control)b5).Text;
					}
					catch
					{
					}
					b();
					num = 1;
					continue;
				case 3:
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
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
					try
					{
						((Control)bz).Text = ((Control)b2).Text;
					}
					catch
					{
					}
					b();
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = a(A_1.KeyValue);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					b();
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			MaskedEditBox val = (MaskedEditBox)A_0;
			((EditBase)val).BackColor = Color.White;
			DateTime dateTime = ShamsiDate.ShamsiToGregory(((Control)az).Text);
			string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
			bool flag = !(((Control)az).Text != shamsiDate);
			int num = 3;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					h();
					flag = ck.SelectedIndex <= 0;
					num = 5;
					continue;
				case 1:
					c();
					num = 2;
					continue;
				case 0:
					MessageBox.Show("تاریخ اشتباه است");
					((Control)az).Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 2:
				case 6:
					d();
					num = 7;
					continue;
				case 7:
					return;
				case 5:
					if (flag)
					{
						e();
						c();
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void h()
	{
		while (true)
		{
			int num = int.Parse(((Control)az).Text.Substring(5, 2));
			bool flag = !(((Control)az).Text.Substring(0, 4) != ((Control)cb).Text);
			int num2 = 31;
			while (true)
			{
				switch (num2)
				{
				case 31:
					if (!flag)
					{
						num2 = 7;
						continue;
					}
					goto case 9;
				case 29:
					((Control)bb).Text = "";
					((Control)b0).Text = "";
					((Control)bb).Enabled = false;
					((EditBase)bb).ReadOnly = true;
					((Control)b0).Enabled = false;
					((EditBase)b0).ReadOnly = true;
					num2 = 3;
					continue;
				case 17:
				case 27:
					flag = num <= 5;
					num2 = 10;
					continue;
				case 10:
					if (!flag)
					{
						num2 = 6;
						continue;
					}
					((Control)be).Enabled = true;
					((EditBase)be).ReadOnly = false;
					((Control)b3).Enabled = true;
					((EditBase)b3).ReadOnly = false;
					num2 = 18;
					continue;
				case 5:
				case 23:
					flag = num <= 2;
					num2 = 4;
					continue;
				case 4:
					if (!flag)
					{
						num2 = 21;
						continue;
					}
					((Control)bf).Enabled = true;
					((EditBase)bf).ReadOnly = false;
					((Control)b4).Enabled = true;
					((EditBase)b4).ReadOnly = false;
					num2 = 0;
					continue;
				case 15:
					((Control)bg).Text = "";
					((Control)b5).Text = "";
					((Control)bg).Enabled = false;
					((EditBase)bg).ReadOnly = true;
					((Control)b5).Enabled = false;
					((EditBase)b5).ReadOnly = true;
					num2 = 16;
					continue;
				case 30:
					((Control)bi).Text = "";
					((Control)b7).Text = "";
					((Control)bi).Enabled = false;
					((EditBase)bi).ReadOnly = true;
					((Control)b7).Enabled = false;
					((EditBase)b7).ReadOnly = true;
					num2 = 5;
					continue;
				case 18:
				case 22:
					flag = num <= 6;
					num2 = 24;
					continue;
				case 24:
					if (!flag)
					{
						num2 = 29;
						continue;
					}
					((Control)bb).Enabled = true;
					((EditBase)bb).ReadOnly = false;
					((Control)b0).Enabled = true;
					((EditBase)b0).ReadOnly = false;
					num2 = 19;
					continue;
				case 11:
					((Control)bd).Text = "";
					((Control)b2).Text = "";
					((Control)bd).Enabled = false;
					((EditBase)bd).ReadOnly = true;
					((Control)b2).Enabled = false;
					((EditBase)b2).ReadOnly = true;
					num2 = 32;
					continue;
				case 32:
					return;
				case 28:
					return;
				case 7:
					num = 1;
					num2 = 9;
					continue;
				case 21:
					((Control)bf).Text = "";
					((Control)b4).Text = "";
					((Control)bf).Enabled = false;
					((EditBase)bf).ReadOnly = true;
					((Control)b4).Enabled = false;
					((EditBase)b4).ReadOnly = true;
					num2 = 1;
					continue;
				case 13:
					((Control)bc).Text = "";
					((Control)b1).Text = "";
					((Control)bc).Enabled = false;
					((EditBase)bc).ReadOnly = true;
					((Control)b1).Enabled = false;
					((EditBase)b1).ReadOnly = true;
					num2 = 26;
					continue;
				case 12:
				case 16:
					flag = num <= 8;
					num2 = 14;
					continue;
				case 14:
					if (true)
					{
					}
					if (flag)
					{
						((Control)bd).Enabled = true;
						((EditBase)bd).ReadOnly = false;
						((Control)b2).Enabled = true;
						((EditBase)b2).ReadOnly = false;
						num2 = 28;
					}
					else
					{
						num2 = 11;
					}
					continue;
				case 8:
				case 26:
					flag = num <= 4;
					num2 = 25;
					continue;
				case 25:
					if (flag)
					{
						((Control)bh).Enabled = true;
						((EditBase)bh).ReadOnly = false;
						((Control)b6).Enabled = true;
						((EditBase)b6).ReadOnly = false;
						num2 = 17;
					}
					else
					{
						num2 = 20;
					}
					continue;
				case 20:
					((Control)bh).Text = "";
					((Control)b6).Text = "";
					((Control)bh).Enabled = false;
					((EditBase)bh).ReadOnly = true;
					((Control)b6).Enabled = false;
					((EditBase)b6).ReadOnly = true;
					num2 = 27;
					continue;
				case 0:
				case 1:
					flag = num <= 3;
					num2 = 34;
					continue;
				case 34:
					if (flag)
					{
						((Control)bc).Enabled = true;
						((EditBase)bc).ReadOnly = false;
						((Control)b1).Enabled = true;
						((EditBase)b1).ReadOnly = false;
						num2 = 8;
					}
					else
					{
						num2 = 13;
					}
					continue;
				case 9:
					flag = num <= 1;
					num2 = 33;
					continue;
				case 33:
					if (flag)
					{
						((Control)bi).Enabled = true;
						((EditBase)bi).ReadOnly = false;
						((Control)b7).Enabled = true;
						((EditBase)b7).ReadOnly = false;
						num2 = 23;
					}
					else
					{
						num2 = 30;
					}
					continue;
				case 3:
				case 19:
					flag = num <= 7;
					num2 = 2;
					continue;
				case 2:
					if (flag)
					{
						((Control)bg).Enabled = true;
						((EditBase)bg).ReadOnly = false;
						((Control)b5).Enabled = true;
						((EditBase)b5).ReadOnly = false;
						num2 = 12;
					}
					else
					{
						num2 = 15;
					}
					continue;
				case 6:
					((Control)be).Text = "";
					((Control)b3).Text = "";
					((Control)be).Enabled = false;
					((EditBase)be).ReadOnly = true;
					((Control)b3).Enabled = false;
					((EditBase)b3).ReadOnly = true;
					num2 = 22;
					continue;
				}
				break;
			}
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		CheckBox val = (CheckBox)A_0;
		((Control)val).BackColor = Color.Empty;
	}

	private void v(object A_0, EventArgs A_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (true)
		{
		}
		CheckBox val = (CheckBox)A_0;
		((Control)val).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void u(object A_0, EventArgs A_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromName("Window");
	}

	private void t(object A_0, EventArgs A_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (true)
		{
		}
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void s(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.a = ce.SelectedValue.ToString();
		j();
		g();
	}

	private void g()
	{
		while (true)
		{
			bool flag = ce.SelectedIndex != 0;
			if (true)
			{
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					((Control)cf).Enabled = true;
					num = 4;
					continue;
				case 6:
					((Control)cg).Enabled = false;
					num = 1;
					continue;
				case 1:
					return;
				case 2:
				case 4:
					flag = ce.SelectedIndex != ((CollectionBase)(object)ce.Items).Count - 1;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					((Control)cg).Enabled = true;
					num = 7;
					continue;
				case 5:
					((Control)cf).Enabled = false;
					num = 2;
					continue;
				case 7:
					return;
				}
				break;
			}
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !((Control)ci).Visible;
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
						num = 1;
						continue;
					}
					return;
				case 1:
					ce.SelectedIndex += 1;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ce.SelectedIndex -= 1;
	}

	private void p(object A_0, EventArgs A_1)
	{
		f();
	}

	private void f()
	{
		while (true)
		{
			bool flag = !(ch.SelectedValue.ToString() == "txtFee1");
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
					((Control)this.m_h).Controls[ch.SelectedValue.ToString()].Focus();
					flag = !(ch.SelectedValue.ToString() == "dropDriver");
					num = 8;
					continue;
				case 5:
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					goto IL_00d8;
				case 3:
					flag = ((Control)cs).Enabled;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 1:
					((Control)b7).Focus();
					num = 9;
					continue;
				case 9:
					return;
				case 2:
					return;
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto IL_00d8;
				case 4:
					{
						((Control)this.m_ar).Focus();
						num = 5;
						continue;
					}
					IL_00d8:
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(this.a == "0");
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
					if (true)
					{
					}
					num = 7;
					continue;
				case 5:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 2;
				case 7:
					try
					{
						((Control)cm).Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_d.SelectedValue.ToString()).ToString();
					}
					catch
					{
						((Control)cm).Text = "";
						if (ck.SelectedIndex < 1)
						{
							((Control)a5).Text = "";
						}
					}
					flag = ck.SelectedIndex >= 1;
					num = 5;
					continue;
				case 1:
					try
					{
						((Control)cm).Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_d.SelectedValue.ToString()).ToString();
					}
					catch
					{
						((Control)cm).Text = "";
						((Control)a5).Text = "";
					}
					e();
					c();
					num = 6;
					continue;
				case 8:
					e();
					c();
					num = 2;
					continue;
				case 0:
					num = 1;
					continue;
				case 2:
					num = 3;
					continue;
				case 3:
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		int num5 = default;
		int num2 = default;
		while (true)
		{
			bool flag = !(((Control)cm).Text == "");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 8;
						continue;
					}
					int num7 = int.Parse(((Control)cm).Text);
					num5 = num7;
					num2 = 9;
					flag = !((EditBase)b7).ReadOnly;
					num = 4;
					continue;
				}
				case 26:
					num2--;
					num = 23;
					continue;
				case 14:
					if (true)
					{
					}
					flag = !((EditBase)b3).ReadOnly;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 25;
				case 10:
					flag = !((EditBase)b4).ReadOnly;
					num = 22;
					continue;
				case 22:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 9;
				case 13:
					flag = !((EditBase)b2).ReadOnly;
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 27;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 10;
				case 25:
					flag = !((EditBase)b0).ReadOnly;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 23;
				case 18:
					num2--;
					num = 27;
					continue;
				case 16:
					num2--;
					num = 14;
					continue;
				case 21:
					num2--;
					num = 9;
					continue;
				case 6:
					num2--;
					num = 13;
					continue;
				case 27:
				{
					int num3 = 9 - num2;
					int num4 = num5 * num3;
					int num6 = 9 * num5;
					((Control)a5).Text = (num6 - num4).ToString();
					num = 2;
					continue;
				}
				case 2:
					return;
				case 12:
					num2--;
					num = 5;
					continue;
				case 8:
					num = 19;
					continue;
				case 19:
					return;
				case 3:
					num2--;
					num = 10;
					continue;
				case 9:
					flag = !((EditBase)b1).ReadOnly;
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 5;
				case 5:
					flag = !((EditBase)b6).ReadOnly;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 14;
				case 23:
					flag = !((EditBase)b5).ReadOnly;
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 13;
				case 17:
					num2--;
					num = 25;
					continue;
				}
				break;
			}
		}
	}

	private bool a(int A_0)
	{
		bool result = default;
		bool flag2 = default;
		while (true)
		{
			bool flag = false;
			int num = 17;
			while (true)
			{
				int num2;
				int num3;
				int num4;
				switch (num)
				{
				case 17:
					num = ((A_0 == 8) ? 3 : 2);
					continue;
				case 7:
					num = 10;
					continue;
				case 10:
					num = ((A_0 < 48) ? 20 : 18);
					continue;
				case 6:
					num2 = 1;
					goto IL_01ec;
				case 18:
					num = 19;
					continue;
				case 19:
					num3 = ((A_0 > 57) ? 1 : 0);
					goto IL_018f;
				case 16:
					flag = true;
					num = 14;
					continue;
				case 3:
					num4 = 0;
					goto IL_016a;
				case 2:
					num = 1;
					continue;
				case 1:
					num4 = ((A_0 != 46) ? 1 : 0);
					goto IL_016a;
				case 14:
					result = flag;
					num = 4;
					continue;
				case 12:
					flag = true;
					num = 7;
					continue;
				case 20:
					if (true)
					{
					}
					num3 = 1;
					goto IL_018f;
				case 0:
					num = 9;
					continue;
				case 9:
					num2 = ((A_0 > 105) ? 1 : 0);
					goto IL_01ec;
				case 13:
					if (!flag2)
					{
						num = 12;
						continue;
					}
					goto case 7;
				case 8:
					if (!flag2)
					{
						num = 5;
						continue;
					}
					goto case 15;
				case 15:
					num = 11;
					continue;
				case 11:
					num = ((A_0 < 96) ? 6 : 0);
					continue;
				case 5:
					flag = true;
					num = 15;
					continue;
				case 21:
					if (!flag2)
					{
						num = 16;
						continue;
					}
					goto case 14;
				case 4:
					{
						return result;
					}
					IL_01ec:
					flag2 = (byte)num2 != 0;
					num = 21;
					continue;
					IL_016a:
					flag2 = (byte)num4 != 0;
					num = 13;
					continue;
					IL_018f:
					flag2 = (byte)num3 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		int num2 = default;
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 26;
			while (true)
			{
				switch (num)
				{
				case 26:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(((Control)a7).Text == "");
					num = 6;
					continue;
				case 19:
					flag = !((EditBase)bg).ReadOnly;
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 13;
				case 29:
					num2--;
					num = 16;
					continue;
				case 9:
					num2--;
					num = 25;
					continue;
				case 30:
					num2--;
					num = 28;
					continue;
				case 22:
					((Control)bi).Text = "";
					((Control)bf).Text = "";
					((Control)bc).Text = "";
					((Control)bh).Text = "";
					((Control)be).Text = "";
					((Control)bb).Text = "";
					((Control)bg).Text = "";
					((Control)bd).Text = "";
					((Control)ba).Text = "";
					num = 2;
					continue;
				case 2:
					return;
				case 11:
					num2--;
					num = 19;
					continue;
				case 10:
					num2--;
					num = 17;
					continue;
				case 25:
					flag = !((EditBase)bf).ReadOnly;
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 14;
				case 28:
					try
					{
						while (true)
						{
							IL_02c1:
							int num3 = int.Parse(((Control)a7).Text);
							int num4 = num3 / num2;
							int num5 = num3 % num2;
							int num6 = num4 + num5;
							flag = ((EditBase)bi).ReadOnly;
							num = 17;
							while (true)
							{
								switch (num)
								{
								case 17:
									if (!flag)
									{
										num = 24;
										continue;
									}
									goto case 12;
								case 9:
									flag = ((EditBase)bc).ReadOnly;
									num = 3;
									continue;
								case 3:
									if (!flag)
									{
										num = 23;
										continue;
									}
									goto case 20;
								case 6:
									((Control)bg).Text = num4.ToString();
									num = 15;
									continue;
								case 23:
									((Control)bc).Text = num4.ToString();
									num = 20;
									continue;
								case 20:
									flag = ((EditBase)bh).ReadOnly;
									num = 2;
									continue;
								case 2:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 4;
								case 1:
									((Control)bf).Text = num4.ToString();
									num = 9;
									continue;
								case 13:
									flag = ((EditBase)bb).ReadOnly;
									num = 11;
									continue;
								case 11:
									if (!flag)
									{
										num = 5;
										continue;
									}
									goto case 8;
								case 24:
									((Control)bi).Text = num4.ToString();
									num = 12;
									continue;
								case 22:
									((Control)be).Text = num4.ToString();
									num = 13;
									continue;
								case 4:
									flag = ((EditBase)be).ReadOnly;
									num = 14;
									continue;
								case 14:
									if (!flag)
									{
										num = 22;
										continue;
									}
									goto case 13;
								case 15:
									flag = ((EditBase)bd).ReadOnly;
									num = 18;
									continue;
								case 18:
									if (!flag)
									{
										num = 16;
										continue;
									}
									goto case 10;
								case 0:
									((Control)bh).Text = num4.ToString();
									num = 4;
									continue;
								case 16:
									((Control)bd).Text = num4.ToString();
									num = 10;
									continue;
								case 12:
									flag = ((EditBase)bf).ReadOnly;
									num = 7;
									continue;
								case 7:
									if (!flag)
									{
										num = 1;
										continue;
									}
									goto case 9;
								case 5:
									((Control)bb).Text = num4.ToString();
									num = 8;
									continue;
								case 8:
									flag = ((EditBase)bg).ReadOnly;
									num = 21;
									continue;
								case 21:
									if (!flag)
									{
										num = 6;
										continue;
									}
									goto case 15;
								case 10:
									((Control)ba).Text = num6.ToString();
									num = 19;
									continue;
								case 19:
									goto end_IL_0254;
								}
								goto IL_02c1;
								continue;
								end_IL_0254:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 0;
					continue;
				case 0:
					return;
				case 24:
					num2--;
					num = 12;
					continue;
				case 5:
					num = 27;
					continue;
				case 27:
					return;
				case 15:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 25;
				case 1:
					if (true)
					{
					}
					num2--;
					num = 14;
					continue;
				case 14:
					flag = !((EditBase)bc).ReadOnly;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 12;
				case 13:
					flag = !((EditBase)bd).ReadOnly;
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 28;
				case 20:
					num2--;
					num = 13;
					continue;
				case 12:
					flag = !((EditBase)bh).ReadOnly;
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 17;
				case 17:
					flag = !((EditBase)be).ReadOnly;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 29;
						continue;
					}
					goto case 16;
				case 16:
					flag = !((EditBase)bb).ReadOnly;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 19;
				case 6:
					if (flag)
					{
						num2 = 9;
						flag = !((EditBase)bi).ReadOnly;
						num = 15;
					}
					else
					{
						num = 22;
					}
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
			while (true)
			{
				IL_00a5:
				int num = 0;
				bool flag = !(((Control)bi).Text != "");
				int num2 = 0;
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (!flag)
						{
							num2 = 1;
							continue;
						}
						goto case 5;
					case 27:
						flag = !(((Control)bc).Text != "");
						num2 = 7;
						continue;
					case 7:
						if (!flag)
						{
							num2 = 35;
							continue;
						}
						goto case 10;
					case 4:
						num2 = 15;
						continue;
					case 16:
						num2 = 33;
						continue;
					case 17:
						num2 = 34;
						continue;
					case 21:
						num2 = 11;
						continue;
					case 13:
						num2 = 9;
						continue;
					case 3:
						try
						{
							num += int.Parse(((Control)bc).Text);
						}
						catch
						{
							((EditBase)bc).BackColor = Color.Red;
						}
						num2 = 10;
						continue;
					case 1:
						num2 = 28;
						continue;
					case 36:
						flag = !(((Control)be).Text != "");
						num2 = 31;
						continue;
					case 31:
						if (!flag)
						{
							num2 = 22;
							continue;
						}
						goto case 24;
					case 10:
						flag = !(((Control)bh).Text != "");
						num2 = 23;
						continue;
					case 23:
						if (!flag)
						{
							num2 = 6;
							continue;
						}
						goto case 36;
					case 35:
						num2 = 3;
						continue;
					case 18:
						flag = !(((Control)bd).Text != "");
						num2 = 32;
						continue;
					case 32:
						if (!flag)
						{
							num2 = 4;
							continue;
						}
						goto case 8;
					case 6:
						num2 = 29;
						continue;
					case 33:
						try
						{
							num += int.Parse(((Control)bf).Text);
						}
						catch
						{
							((EditBase)bf).BackColor = Color.Red;
						}
						num2 = 27;
						continue;
					case 24:
						flag = !(((Control)bb).Text != "");
						num2 = 30;
						continue;
					case 30:
						if (!flag)
						{
							num2 = 13;
							continue;
						}
						goto case 26;
					case 28:
						try
						{
							num += int.Parse(((Control)bi).Text);
						}
						catch
						{
							((EditBase)bi).BackColor = Color.Red;
						}
						num2 = 5;
						continue;
					case 12:
						try
						{
							num += int.Parse(((Control)be).Text);
						}
						catch
						{
							((EditBase)be).BackColor = Color.Red;
						}
						num2 = 24;
						continue;
					case 15:
						try
						{
							num += int.Parse(((Control)bd).Text);
						}
						catch
						{
							((EditBase)bd).BackColor = Color.Red;
						}
						num2 = 8;
						continue;
					case 22:
						num2 = 12;
						continue;
					case 11:
						try
						{
							num += int.Parse(((Control)ba).Text);
						}
						catch
						{
							((EditBase)ba).BackColor = Color.Red;
						}
						num2 = 14;
						continue;
					case 5:
						flag = !(((Control)bf).Text != "");
						num2 = 25;
						continue;
					case 25:
						if (!flag)
						{
							num2 = 16;
							continue;
						}
						goto case 27;
					case 8:
						flag = !(((Control)ba).Text != "");
						num2 = 20;
						continue;
					case 20:
						if (!flag)
						{
							num2 = 21;
							continue;
						}
						goto case 14;
					case 29:
						try
						{
							num += int.Parse(((Control)bh).Text);
						}
						catch
						{
							((EditBase)bh).BackColor = Color.Red;
						}
						num2 = 36;
						continue;
					case 9:
						try
						{
							num += int.Parse(((Control)bb).Text);
						}
						catch
						{
							((EditBase)bb).BackColor = Color.Red;
						}
						num2 = 26;
						continue;
					case 34:
						try
						{
							num += int.Parse(((Control)bg).Text);
						}
						catch
						{
							((EditBase)bg).BackColor = Color.Red;
						}
						num2 = 18;
						continue;
					case 26:
						flag = !(((Control)bg).Text != "");
						num2 = 2;
						continue;
					case 2:
						if (!flag)
						{
							num2 = 17;
							continue;
						}
						goto case 18;
					case 14:
						((Control)a7).Text = num.ToString();
						num2 = 19;
						continue;
					case 19:
						goto end_IL_0008;
					}
					goto IL_00a5;
					continue;
					end_IL_0008:
					break;
				}
				break;
			}
		}
		catch
		{
			((Control)a7).Text = "";
		}
		if (1 == 0)
		{
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = a(A_1.KeyValue);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					c();
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					num = 0;
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
		int num2 = default;
		while (true)
		{
			bool flag = !(((Control)a5).Text == "");
			int num = 22;
			while (true)
			{
				switch (num)
				{
				case 22:
					if (!flag)
					{
						num = 10;
						continue;
					}
					num2 = 9;
					flag = !((EditBase)b7).ReadOnly;
					num = 25;
					continue;
				case 15:
					num2--;
					num = 3;
					continue;
				case 9:
					num2--;
					num = 21;
					continue;
				case 8:
					flag = !((EditBase)b4).ReadOnly;
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 4;
				case 6:
					num2--;
					num = 23;
					continue;
				case 26:
					num2--;
					num = 8;
					continue;
				case 14:
					flag = !((EditBase)b5).ReadOnly;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 3;
				case 0:
					flag = !((EditBase)b3).ReadOnly;
					if (true)
					{
					}
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 21;
				case 17:
					num2--;
					num = 4;
					continue;
				case 23:
					try
					{
						while (true)
						{
							IL_024d:
							int num3 = int.Parse(((Control)a5).Text);
							int num4 = num3 / num2;
							int num5 = num3 % num2;
							int num6 = num4 + num5;
							flag = ((EditBase)b7).ReadOnly;
							num = 12;
							while (true)
							{
								switch (num)
								{
								case 12:
									if (!flag)
									{
										num = 23;
										continue;
									}
									goto case 13;
								case 7:
									flag = ((EditBase)b0).ReadOnly;
									num = 9;
									continue;
								case 9:
									if (!flag)
									{
										num = 19;
										continue;
									}
									goto case 5;
								case 24:
									((Control)b1).Text = num4.ToString();
									num = 1;
									continue;
								case 18:
									((Control)b4).Text = num4.ToString();
									num = 15;
									continue;
								case 10:
									((Control)b5).Text = num4.ToString();
									num = 20;
									continue;
								case 1:
									flag = ((EditBase)b6).ReadOnly;
									num = 4;
									continue;
								case 4:
									if (!flag)
									{
										num = 8;
										continue;
									}
									goto case 2;
								case 15:
									flag = ((EditBase)b1).ReadOnly;
									num = 3;
									continue;
								case 3:
									if (!flag)
									{
										num = 24;
										continue;
									}
									goto case 1;
								case 8:
									((Control)b6).Text = num4.ToString();
									num = 2;
									continue;
								case 19:
									((Control)b0).Text = num4.ToString();
									num = 5;
									continue;
								case 23:
									((Control)b7).Text = num4.ToString();
									num = 13;
									continue;
								case 6:
									((Control)b3).Text = num4.ToString();
									num = 7;
									continue;
								case 2:
									flag = ((EditBase)b3).ReadOnly;
									num = 11;
									continue;
								case 11:
									if (!flag)
									{
										num = 6;
										continue;
									}
									goto case 7;
								case 20:
									flag = ((EditBase)b2).ReadOnly;
									num = 16;
									continue;
								case 16:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 21;
								case 5:
									flag = ((EditBase)b5).ReadOnly;
									num = 14;
									continue;
								case 14:
									if (!flag)
									{
										num = 10;
										continue;
									}
									goto case 20;
								case 0:
									((Control)b2).Text = num4.ToString();
									num = 21;
									continue;
								case 13:
									flag = ((EditBase)b4).ReadOnly;
									num = 22;
									continue;
								case 22:
									if (!flag)
									{
										num = 18;
										continue;
									}
									goto case 15;
								case 21:
									((Control)bz).Text = num6.ToString();
									num = 17;
									continue;
								case 17:
									goto end_IL_01e0;
								}
								goto IL_024d;
								continue;
								end_IL_01e0:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 27;
					continue;
				case 27:
					return;
				case 18:
					flag = !((EditBase)b6).ReadOnly;
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 10:
					((Control)b7).Text = "";
					((Control)b4).Text = "";
					((Control)b1).Text = "";
					((Control)b6).Text = "";
					((Control)b3).Text = "";
					((Control)b0).Text = "";
					((Control)b5).Text = "";
					((Control)b2).Text = "";
					((Control)bz).Text = "";
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					flag = !((EditBase)b1).ReadOnly;
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 18;
				case 25:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 8;
				case 1:
					num2--;
					num = 0;
					continue;
				case 3:
					flag = !((EditBase)b2).ReadOnly;
					num = 19;
					continue;
				case 19:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 23;
				case 13:
					num2--;
					num = 14;
					continue;
				case 11:
					num2--;
					num = 18;
					continue;
				case 21:
					flag = !((EditBase)b0).ReadOnly;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 14;
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
		try
		{
			while (true)
			{
				int num = 0;
				bool flag = !(((Control)b7).Text != "");
				int num2 = 29;
				while (true)
				{
					switch (num2)
					{
					case 29:
						if (!flag)
						{
							num2 = 1;
							continue;
						}
						goto case 16;
					case 30:
						flag = !(((Control)b1).Text != "");
						num2 = 5;
						continue;
					case 5:
						if (!flag)
						{
							num2 = 17;
							continue;
						}
						goto case 20;
					case 15:
						num2 = 6;
						continue;
					case 14:
						num2 = 19;
						continue;
					case 4:
						num2 = 13;
						continue;
					case 10:
						num2 = 25;
						continue;
					case 3:
						num2 = 26;
						continue;
					case 2:
						try
						{
							num += int.Parse(((Control)b1).Text);
						}
						catch
						{
							((EditBase)b1).BackColor = Color.Red;
						}
						num2 = 20;
						continue;
					case 1:
						num2 = 24;
						continue;
					case 8:
						flag = !(((Control)b3).Text != "");
						num2 = 21;
						continue;
					case 21:
						if (!flag)
						{
							num2 = 33;
							continue;
						}
						goto case 22;
					case 20:
						flag = !(((Control)b6).Text != "");
						num2 = 32;
						continue;
					case 32:
						if (!flag)
						{
							num2 = 12;
							continue;
						}
						goto case 8;
					case 17:
						num2 = 2;
						continue;
					case 27:
						flag = !(((Control)b2).Text != "");
						num2 = 18;
						continue;
					case 18:
						if (!flag)
						{
							num2 = 15;
							continue;
						}
						goto case 23;
					case 12:
						num2 = 31;
						continue;
					case 19:
						try
						{
							num += int.Parse(((Control)b4).Text);
						}
						catch
						{
							((EditBase)b4).BackColor = Color.Red;
						}
						num2 = 30;
						continue;
					case 22:
						flag = !(((Control)b0).Text != "");
						num2 = 11;
						continue;
					case 11:
						if (!flag)
						{
							num2 = 3;
							continue;
						}
						goto case 34;
					case 24:
						try
						{
							num += int.Parse(((Control)b7).Text);
						}
						catch
						{
							((EditBase)b7).BackColor = Color.Red;
						}
						num2 = 16;
						continue;
					case 35:
						try
						{
							num += int.Parse(((Control)b3).Text);
						}
						catch
						{
							((EditBase)b3).BackColor = Color.Red;
						}
						num2 = 22;
						continue;
					case 6:
						try
						{
							num += int.Parse(((Control)b2).Text);
						}
						catch
						{
							((EditBase)b2).BackColor = Color.Red;
						}
						num2 = 23;
						continue;
					case 33:
						num2 = 35;
						continue;
					case 25:
						try
						{
							num += int.Parse(((Control)bz).Text);
						}
						catch
						{
							((EditBase)bz).BackColor = Color.Red;
						}
						num2 = 0;
						continue;
					case 16:
						flag = !(((Control)b4).Text != "");
						num2 = 9;
						continue;
					case 9:
						if (!flag)
						{
							num2 = 14;
							continue;
						}
						goto case 30;
					case 23:
						flag = !(((Control)bz).Text != "");
						num2 = 28;
						continue;
					case 28:
						if (!flag)
						{
							num2 = 10;
							continue;
						}
						goto case 0;
					case 31:
						try
						{
							num += int.Parse(((Control)b6).Text);
						}
						catch
						{
							((EditBase)b6).BackColor = Color.Red;
						}
						num2 = 8;
						continue;
					case 26:
						try
						{
							num += int.Parse(((Control)b0).Text);
						}
						catch
						{
							((EditBase)b0).BackColor = Color.Red;
						}
						num2 = 34;
						continue;
					case 13:
						try
						{
							num += int.Parse(((Control)b5).Text);
						}
						catch
						{
							((EditBase)b5).BackColor = Color.Red;
						}
						num2 = 27;
						continue;
					case 34:
						flag = !(((Control)b5).Text != "");
						num2 = 36;
						continue;
					case 36:
						if (!flag)
						{
							num2 = 4;
							continue;
						}
						goto case 27;
					case 0:
						((Control)a5).Text = num.ToString();
						num2 = 7;
						continue;
					case 7:
						return;
					}
					break;
				}
			}
		}
		catch
		{
			((Control)a5).Text = "";
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = ck.SelectedIndex <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					((Control)a5).Enabled = false;
					((Control)bp).Enabled = false;
					e();
					c();
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					((Control)bp).Enabled = true;
					((Control)a5).Enabled = true;
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = ck.SelectedIndex >= 0;
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
					MessageBox.Show("تخفیفی با این عنوان وجود ندارد. تخفیف مورد نظر را انتخاب کنید");
					((UIComboBase)ck).Focus();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)a9).Enabled = this.m_ar.Checked;
		((Control)a7).Enabled = this.m_ar.Checked;
		((Control)cs).Enabled = this.m_ar.Checked;
	}

	private void k(object A_0, EventArgs A_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		asdbt asdbt2 = new asdbt();
		((Form)asdbt2).ShowDialog();
		m();
	}

	private void j(object A_0, EventArgs A_1)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = cs.SelectedIndex >= 0;
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
						num = 1;
						continue;
					}
					return;
				case 1:
					MessageBox.Show("راننده ای با این نام وجود ندارد. راننده مورد نظر را انتخاب کنید");
					((UIComboBase)cs).Focus();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 114;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = (int)A_1.KeyCode != 34;
					num = 13;
					continue;
				case 9:
					if (true)
					{
					}
					flag = !((Control)cf).Enabled;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 12;
				case 2:
					num = 0;
					continue;
				case 0:
					return;
				case 13:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = (int)A_1.KeyCode != 33;
					num = 4;
					continue;
				case 7:
					q((object)this, (EventArgs)null);
					num = 12;
					continue;
				case 10:
					@as(this, null);
					num = 14;
					continue;
				case 14:
					return;
				case 4:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 12:
					num = 1;
					continue;
				case 1:
					return;
				case 11:
					r((object)this, (EventArgs)null);
					num = 2;
					continue;
				case 8:
					flag = !((Control)cg).Enabled;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		((EditBase)cy).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void h(object A_0, EventArgs A_1)
	{
		((EditBase)cw).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void g(object A_0, EventArgs A_1)
	{
		((EditBase)cy).BackColor = Color.White;
	}

	private void f(object A_0, EventArgs A_1)
	{
		((EditBase)cw).BackColor = Color.White;
	}

	private void e(object A_0, EventArgs A_1)
	{
		((EditBase)c0).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void d(object A_0, EventArgs A_1)
	{
		((EditBase)c2).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void c(object A_0, EventArgs A_1)
	{
		((EditBase)c0).BackColor = Color.White;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((EditBase)c2).BackColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		((EditBase)cd).BackColor = Color.FromName("Window");
		try
		{
			string text3 = default;
			DateTime dateTime = default;
			string text = default;
			while (true)
			{
				IL_005e:
				bool flag = !(((Control)cd).Text != "");
				int num = 3;
				while (true)
				{
					switch (num)
					{
					case 1:
						goto end_IL_0021;
					case 3:
						if (!flag)
						{
							num = 7;
							continue;
						}
						goto case 12;
					case 9:
						text3 = "0" + text3;
						num = 6;
						continue;
					case 7:
					{
						string text2 = ((Control)cd).Text;
						dateTime = ShamsiDate.ShamsiToGregory(text2);
						string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
						flag = !(shamsiDate != text2);
						num = 5;
						continue;
					}
					case 5:
						if (!flag)
						{
							num = 0;
							continue;
						}
						text = dateTime.Month.ToString();
						flag = text.Length != 1;
						num = 8;
						continue;
					case 4:
						text3 = dateTime.Day.ToString();
						flag = text3.Length != 1;
						num = 2;
						continue;
					case 2:
						if (!flag)
						{
							num = 9;
							continue;
						}
						goto case 6;
					case 6:
						((Control)c8).Text = dateTime.Year + "/" + text + "/" + text3;
						num = 12;
						continue;
					case 8:
						if (!flag)
						{
							num = 10;
							continue;
						}
						goto case 4;
					case 0:
						MessageBox.Show("تاریخ تولد اشتباه است");
						((Control)cd).Focus();
						num = 11;
						continue;
					case 11:
						goto end_IL_0021;
					case 10:
						text = "0" + text;
						num = 4;
						continue;
					case 12:
						num = 1;
						continue;
					}
					goto IL_005e;
					continue;
					end_IL_0021:
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
					num = ((!A_0) ? 3 : 6);
					continue;
				case 6:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_c == null) ? 1 : 0);
					goto IL_0074;
				case 2:
					this.m_c.Dispose();
					num = 4;
					continue;
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 3:
					num2 = 1;
					goto IL_0074;
				case 4:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 1;
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
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Obj, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected Obj, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected Obj, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_123b: Expected Obj, but got Unknown
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fe: Expected Obj, but got Unknown
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Expected Obj, but got Unknown
		//IL_1416: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420: Expected Obj, but got Unknown
		//IL_164f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1659: Expected Obj, but got Unknown
		//IL_17b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c2: Expected Obj, but got Unknown
		//IL_1a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a59: Expected Obj, but got Unknown
		//IL_1bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbb: Expected Obj, but got Unknown
		//IL_1fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe6: Expected Obj, but got Unknown
		//IL_2062: Unknown result type (might be due to invalid IL or missing references)
		//IL_206c: Expected Obj, but got Unknown
		//IL_207e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2088: Expected Obj, but got Unknown
		//IL_2164: Unknown result type (might be due to invalid IL or missing references)
		//IL_216e: Expected Obj, but got Unknown
		//IL_2236: Unknown result type (might be due to invalid IL or missing references)
		//IL_2240: Expected Obj, but got Unknown
		//IL_22f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fa: Expected Obj, but got Unknown
		//IL_2505: Unknown result type (might be due to invalid IL or missing references)
		//IL_250f: Expected Obj, but got Unknown
		//IL_259e: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a8: Expected Obj, but got Unknown
		//IL_25c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ca: Expected Obj, but got Unknown
		//IL_2b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b35: Expected Obj, but got Unknown
		//IL_2b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b51: Expected Obj, but got Unknown
		//IL_2c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c34: Expected Obj, but got Unknown
		//IL_2c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c50: Expected Obj, but got Unknown
		//IL_2d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d57: Expected Obj, but got Unknown
		//IL_2e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e35: Expected Obj, but got Unknown
		//IL_2ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2efd: Expected Obj, but got Unknown
		//IL_2f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1f: Expected Obj, but got Unknown
		//IL_3216: Unknown result type (might be due to invalid IL or missing references)
		//IL_3220: Expected Obj, but got Unknown
		//IL_32a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_32af: Expected Obj, but got Unknown
		//IL_3331: Unknown result type (might be due to invalid IL or missing references)
		//IL_333b: Expected Obj, but got Unknown
		//IL_33bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c7: Expected Obj, but got Unknown
		//IL_3449: Unknown result type (might be due to invalid IL or missing references)
		//IL_3453: Expected Obj, but got Unknown
		//IL_34d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e2: Expected Obj, but got Unknown
		//IL_3567: Unknown result type (might be due to invalid IL or missing references)
		//IL_3571: Expected Obj, but got Unknown
		//IL_35f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35fd: Expected Obj, but got Unknown
		//IL_367f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3689: Expected Obj, but got Unknown
		//IL_370b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3715: Expected Obj, but got Unknown
		//IL_37d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_37da: Expected Obj, but got Unknown
		//IL_37f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37fc: Expected Obj, but got Unknown
		//IL_38b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ba: Expected Obj, but got Unknown
		//IL_3930: Unknown result type (might be due to invalid IL or missing references)
		//IL_393a: Expected Obj, but got Unknown
		//IL_3952: Unknown result type (might be due to invalid IL or missing references)
		//IL_395c: Expected Obj, but got Unknown
		//IL_3a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a1a: Expected Obj, but got Unknown
		//IL_3a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a9a: Expected Obj, but got Unknown
		//IL_3ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3abc: Expected Obj, but got Unknown
		//IL_3b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b7a: Expected Obj, but got Unknown
		//IL_3bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfa: Expected Obj, but got Unknown
		//IL_3c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c1c: Expected Obj, but got Unknown
		//IL_3cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cdd: Expected Obj, but got Unknown
		//IL_3d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5d: Expected Obj, but got Unknown
		//IL_3d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d7f: Expected Obj, but got Unknown
		//IL_3e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e40: Expected Obj, but got Unknown
		//IL_3eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec0: Expected Obj, but got Unknown
		//IL_3ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee2: Expected Obj, but got Unknown
		//IL_3f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fa3: Expected Obj, but got Unknown
		//IL_4019: Unknown result type (might be due to invalid IL or missing references)
		//IL_4023: Expected Obj, but got Unknown
		//IL_403b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4045: Expected Obj, but got Unknown
		//IL_40fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4106: Expected Obj, but got Unknown
		//IL_417c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4186: Expected Obj, but got Unknown
		//IL_419e: Unknown result type (might be due to invalid IL or missing references)
		//IL_41a8: Expected Obj, but got Unknown
		//IL_425f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4269: Expected Obj, but got Unknown
		//IL_42df: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e9: Expected Obj, but got Unknown
		//IL_4301: Unknown result type (might be due to invalid IL or missing references)
		//IL_430b: Expected Obj, but got Unknown
		//IL_43cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d9: Expected Obj, but got Unknown
		//IL_45b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_45be: Expected Obj, but got Unknown
		//IL_4646: Unknown result type (might be due to invalid IL or missing references)
		//IL_4650: Expected Obj, but got Unknown
		//IL_46d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_46dc: Expected Obj, but got Unknown
		//IL_475e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4768: Expected Obj, but got Unknown
		//IL_47ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_47f4: Expected Obj, but got Unknown
		//IL_4879: Unknown result type (might be due to invalid IL or missing references)
		//IL_4883: Expected Obj, but got Unknown
		//IL_4908: Unknown result type (might be due to invalid IL or missing references)
		//IL_4912: Expected Obj, but got Unknown
		//IL_4994: Unknown result type (might be due to invalid IL or missing references)
		//IL_499e: Expected Obj, but got Unknown
		//IL_4a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a2a: Expected Obj, but got Unknown
		//IL_4aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ab6: Expected Obj, but got Unknown
		//IL_4b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b7b: Expected Obj, but got Unknown
		//IL_4b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b9d: Expected Obj, but got Unknown
		//IL_4c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c5b: Expected Obj, but got Unknown
		//IL_4cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cdb: Expected Obj, but got Unknown
		//IL_4cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cfd: Expected Obj, but got Unknown
		//IL_4db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dbb: Expected Obj, but got Unknown
		//IL_4e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e3b: Expected Obj, but got Unknown
		//IL_4e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e5d: Expected Obj, but got Unknown
		//IL_4f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f1b: Expected Obj, but got Unknown
		//IL_4f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f9b: Expected Obj, but got Unknown
		//IL_4fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fbd: Expected Obj, but got Unknown
		//IL_5074: Unknown result type (might be due to invalid IL or missing references)
		//IL_507e: Expected Obj, but got Unknown
		//IL_50f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_50fe: Expected Obj, but got Unknown
		//IL_5116: Unknown result type (might be due to invalid IL or missing references)
		//IL_5120: Expected Obj, but got Unknown
		//IL_51d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_51e1: Expected Obj, but got Unknown
		//IL_5257: Unknown result type (might be due to invalid IL or missing references)
		//IL_5261: Expected Obj, but got Unknown
		//IL_5279: Unknown result type (might be due to invalid IL or missing references)
		//IL_5283: Expected Obj, but got Unknown
		//IL_533a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5344: Expected Obj, but got Unknown
		//IL_53ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_53c4: Expected Obj, but got Unknown
		//IL_53dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_53e6: Expected Obj, but got Unknown
		//IL_549d: Unknown result type (might be due to invalid IL or missing references)
		//IL_54a7: Expected Obj, but got Unknown
		//IL_551d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5527: Expected Obj, but got Unknown
		//IL_553f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5549: Expected Obj, but got Unknown
		//IL_5600: Unknown result type (might be due to invalid IL or missing references)
		//IL_560a: Expected Obj, but got Unknown
		//IL_5680: Unknown result type (might be due to invalid IL or missing references)
		//IL_568a: Expected Obj, but got Unknown
		//IL_56a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_56ac: Expected Obj, but got Unknown
		//IL_5763: Unknown result type (might be due to invalid IL or missing references)
		//IL_576d: Expected Obj, but got Unknown
		//IL_5893: Unknown result type (might be due to invalid IL or missing references)
		//IL_589d: Expected Obj, but got Unknown
		//IL_5a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a3a: Expected Obj, but got Unknown
		//IL_5ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cd7: Expected Obj, but got Unknown
		//IL_5d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d9f: Expected Obj, but got Unknown
		//IL_5db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dc1: Expected Obj, but got Unknown
		//IL_5ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f02: Expected Obj, but got Unknown
		//IL_6cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cc9: Expected Obj, but got Unknown
		//IL_6fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fb1: Expected Obj, but got Unknown
		//IL_71a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_71ad: Expected Obj, but got Unknown
		//IL_728c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7296: Expected Obj, but got Unknown
		//IL_7390: Unknown result type (might be due to invalid IL or missing references)
		//IL_739a: Expected Obj, but got Unknown
		//IL_7556: Unknown result type (might be due to invalid IL or missing references)
		//IL_7560: Expected Obj, but got Unknown
		//IL_7686: Unknown result type (might be due to invalid IL or missing references)
		//IL_7690: Expected Obj, but got Unknown
		//IL_77b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_77bd: Expected Obj, but got Unknown
		//IL_7da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_7dab: Expected Obj, but got Unknown
		//IL_7e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e11: Expected Obj, but got Unknown
		//IL_7e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e24: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdat));
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		StringFormat val4 = new StringFormat();
		StringFormat val5 = new StringFormat();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		UIComboBoxItem val10 = new UIComboBoxItem();
		UIComboBoxItem val11 = new UIComboBoxItem();
		UIComboBoxItem val12 = new UIComboBoxItem();
		UIComboBoxItem val13 = new UIComboBoxItem();
		UIComboBoxItem val14 = new UIComboBoxItem();
		UIComboBoxItem val15 = new UIComboBoxItem();
		UIComboBoxItem val16 = new UIComboBoxItem();
		UIComboBoxItem val17 = new UIComboBoxItem();
		UIComboBoxItem val18 = new UIComboBoxItem();
		UIComboBoxItem val19 = new UIComboBoxItem();
		UIComboBoxItem val20 = new UIComboBoxItem();
		UIComboBoxItem val21 = new UIComboBoxItem();
		UIComboBoxItem val22 = new UIComboBoxItem();
		UIComboBoxItem val23 = new UIComboBoxItem();
		UIComboBoxItem val24 = new UIComboBoxItem();
		UIComboBoxItem val25 = new UIComboBoxItem();
		UIComboBoxItem val26 = new UIComboBoxItem();
		UIComboBoxItem val27 = new UIComboBoxItem();
		UIComboBoxItem val28 = new UIComboBoxItem();
		UIComboBoxItem val29 = new UIComboBoxItem();
		UIComboBoxItem val30 = new UIComboBoxItem();
		StringFormat val31 = new StringFormat();
		StringFormat val32 = new StringFormat();
		StringFormat val33 = new StringFormat();
		UIComboBoxItem val34 = new UIComboBoxItem();
		UIComboBoxItem val35 = new UIComboBoxItem();
		UIComboBoxItem val36 = new UIComboBoxItem();
		UIComboBoxItem val37 = new UIComboBoxItem();
		StringFormat val38 = new StringFormat();
		UIComboBoxItem val39 = new UIComboBoxItem();
		UIComboBoxItem val40 = new UIComboBoxItem();
		UIComboBoxItem val41 = new UIComboBoxItem();
		StringFormat val42 = new StringFormat();
		UIComboBoxItem val43 = new UIComboBoxItem();
		UIComboBoxItem val44 = new UIComboBoxItem();
		UIComboBoxItem val45 = new UIComboBoxItem();
		StringFormat val46 = new StringFormat();
		this.m_d = new UIComboBox();
		this.m_e = new UIButton();
		this.m_f = new Label();
		this.m_g = new UIButton();
		this.m_h = new Panel();
		c8 = new MaskedEditBox();
		c9 = new Label();
		c6 = new UIComboBox();
		c7 = new Label();
		c4 = new Label();
		c5 = new MaskedEditBox();
		c3 = new CheckBox();
		c1 = new Label();
		c2 = new EditBox();
		cz = new Label();
		c0 = new EditBox();
		cv = new Label();
		cw = new EditBox();
		cx = new Label();
		cy = new EditBox();
		ct = new UIComboBox();
		cu = new Label();
		cr = new Label();
		cs = new UIComboBox();
		co = new Panel();
		cp = new Label();
		cn = new UIButton();
		cq = new Label();
		cm = new MaskedEditBox();
		ck = new UIComboBox();
		cl = new Label();
		ci = new Panel();
		cj = new Label();
		ch = new UIComboBox();
		cf = new UIButton();
		cg = new UIButton();
		ce = new UIComboBox();
		cc = new Label();
		cd = new MaskedEditBox();
		cb = new Label();
		bp = new UIGroupBox();
		bq = new Label();
		br = new Label();
		bs = new Label();
		bt = new Label();
		bu = new Label();
		bv = new Label();
		bw = new Label();
		bx = new Label();
		by = new Label();
		bz = new MaskedEditBox();
		b0 = new MaskedEditBox();
		b1 = new MaskedEditBox();
		b2 = new MaskedEditBox();
		b3 = new MaskedEditBox();
		b4 = new MaskedEditBox();
		b5 = new MaskedEditBox();
		b6 = new MaskedEditBox();
		b7 = new MaskedEditBox();
		a9 = new UIGroupBox();
		b8 = new Label();
		b9 = new Label();
		ca = new Label();
		bj = new Label();
		bk = new Label();
		bl = new Label();
		bm = new Label();
		bn = new Label();
		bo = new Label();
		ba = new MaskedEditBox();
		bb = new MaskedEditBox();
		bc = new MaskedEditBox();
		bd = new MaskedEditBox();
		be = new MaskedEditBox();
		bf = new MaskedEditBox();
		bg = new MaskedEditBox();
		bh = new MaskedEditBox();
		bi = new MaskedEditBox();
		a7 = new MaskedEditBox();
		a8 = new Label();
		a5 = new MaskedEditBox();
		a6 = new Label();
		a3 = new Label();
		a4 = new UIComboBox();
		a2 = new Label();
		a1 = new Label();
		ay = new Label();
		az = new MaskedEditBox();
		a0 = new MaskedEditBox();
		ax = new CheckBox();
		this.m_av = new CheckBox();
		this.m_aw = new CheckBox();
		this.m_au = new CheckBox();
		this.m_aq = new CheckBox();
		this.m_ar = new CheckBox();
		this.m_as = new CheckBox();
		this.m_at = new CheckBox();
		this.m_ao = new CheckBox();
		this.m_ap = new CheckBox();
		this.m_am = new EditBox();
		this.m_an = new Label();
		this.m_al = new Panel();
		this.m_aj = new Label();
		this.m_ai = new UIComboBox();
		this.m_ag = new Label();
		this.m_ah = new UIComboBox();
		this.m_af = new Label();
		this.m_ae = new MaskedEditBox();
		this.m_y = new UIComboBox();
		this.m_z = new Label();
		this.m_aa = new MaskedEditBox();
		this.m_ab = new Label();
		this.m_ac = new Label();
		this.m_ad = new MaskedEditBox();
		this.m_n = new UIButton();
		this.m_j = new Label();
		this.m_o = new UIButton();
		this.m_p = new PictureBox();
		this.m_k = new Label();
		this.m_l = new MaskedEditBox();
		this.m_m = new MaskedEditBox();
		this.m_q = new MaskedEditBox();
		this.m_r = new Label();
		this.m_x = new Label();
		this.m_s = new EditBox();
		this.m_w = new EditBox();
		this.m_t = new Label();
		this.m_v = new Label();
		this.m_u = new EditBox();
		this.m_i = new Panel();
		this.m_ak = new OpenFileDialog();
		((Control)this.m_h).SuspendLayout();
		((Control)co).SuspendLayout();
		((Control)ci).SuspendLayout();
		((ISupportInitialize)bp).BeginInit();
		((Control)bp).SuspendLayout();
		((ISupportInitialize)a9).BeginInit();
		((Control)a9).SuspendLayout();
		((ISupportInitialize)this.m_p).BeginInit();
		((Control)this.m_i).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_d).Location = new Point(188, 434);
		((Control)this.m_d).Name = "dropCls";
		((Control)this.m_d).Size = new Size(142, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_d).StringFormat = val;
		((Control)this.m_d).TabIndex = 37;
		this.m_d.SelectedIndexChanged += o;
		((Control)this.m_e).Anchor = (AnchorStyles)1;
		((Control)this.m_e).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		this.m_e.ImageSize = new Size(30, 40);
		((Control)this.m_e).Location = new Point(220, 624);
		((Control)this.m_e).Name = "btnAcp";
		((Control)this.m_e).Size = new Size(178, 42);
		((Control)this.m_e).TabIndex = 100;
		((Control)this.m_e).Text = "ثبت(F3)";
		((Control)this.m_e).Click += @as;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Location = new Point(336, 437);
		((Control)this.m_f).Name = "label19";
		((Control)this.m_f).Size = new Size(35, 16);
		((Control)this.m_f).TabIndex = 12;
		((Control)this.m_f).Text = "صنف";
		((Control)this.m_g).Anchor = (AnchorStyles)1;
		((Control)this.m_g).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		this.m_g.ImageSize = new Size(40, 40);
		((Control)this.m_g).Location = new Point(19, 624);
		((Control)this.m_g).Name = "uiButton1";
		((Control)this.m_g).Size = new Size(178, 42);
		((Control)this.m_g).TabIndex = 101;
		((Control)this.m_g).Text = "بستن";
		((Control)this.m_g).Click += av;
		((Control)this.m_h).BackColor = SystemColors.GradientInactiveCaption;
		this.m_h.BorderStyle = (BorderStyle)1;
		((Control)this.m_h).Controls.Add((Control)(object)c8);
		((Control)this.m_h).Controls.Add((Control)(object)c9);
		((Control)this.m_h).Controls.Add((Control)(object)c6);
		((Control)this.m_h).Controls.Add((Control)(object)c7);
		((Control)this.m_h).Controls.Add((Control)(object)c4);
		((Control)this.m_h).Controls.Add((Control)(object)c5);
		((Control)this.m_h).Controls.Add((Control)(object)c3);
		((Control)this.m_h).Controls.Add((Control)(object)c1);
		((Control)this.m_h).Controls.Add((Control)(object)c2);
		((Control)this.m_h).Controls.Add((Control)(object)cz);
		((Control)this.m_h).Controls.Add((Control)(object)c0);
		((Control)this.m_h).Controls.Add((Control)(object)cv);
		((Control)this.m_h).Controls.Add((Control)(object)cw);
		((Control)this.m_h).Controls.Add((Control)(object)cx);
		((Control)this.m_h).Controls.Add((Control)(object)cy);
		((Control)this.m_h).Controls.Add((Control)(object)ct);
		((Control)this.m_h).Controls.Add((Control)(object)cu);
		((Control)this.m_h).Controls.Add((Control)(object)cr);
		((Control)this.m_h).Controls.Add((Control)(object)cs);
		((Control)this.m_h).Controls.Add((Control)(object)co);
		((Control)this.m_h).Controls.Add((Control)(object)cn);
		((Control)this.m_h).Controls.Add((Control)(object)cq);
		((Control)this.m_h).Controls.Add((Control)(object)cm);
		((Control)this.m_h).Controls.Add((Control)(object)ck);
		((Control)this.m_h).Controls.Add((Control)(object)cl);
		((Control)this.m_h).Controls.Add((Control)(object)ci);
		((Control)this.m_h).Controls.Add((Control)(object)ce);
		((Control)this.m_h).Controls.Add((Control)(object)cc);
		((Control)this.m_h).Controls.Add((Control)(object)cd);
		((Control)this.m_h).Controls.Add((Control)(object)cb);
		((Control)this.m_h).Controls.Add((Control)(object)bp);
		((Control)this.m_h).Controls.Add((Control)(object)a9);
		((Control)this.m_h).Controls.Add((Control)(object)a7);
		((Control)this.m_h).Controls.Add((Control)(object)a8);
		((Control)this.m_h).Controls.Add((Control)(object)a5);
		((Control)this.m_h).Controls.Add((Control)(object)a6);
		((Control)this.m_h).Controls.Add((Control)(object)a3);
		((Control)this.m_h).Controls.Add((Control)(object)a4);
		((Control)this.m_h).Controls.Add((Control)(object)a2);
		((Control)this.m_h).Controls.Add((Control)(object)a1);
		((Control)this.m_h).Controls.Add((Control)(object)ay);
		((Control)this.m_h).Controls.Add((Control)(object)az);
		((Control)this.m_h).Controls.Add((Control)(object)a0);
		((Control)this.m_h).Controls.Add((Control)(object)ax);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_av);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_aw);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_au);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_aq);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ar);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_as);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_at);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ao);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ap);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_am);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_an);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_al);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_aj);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ai);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ag);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ah);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_af);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ae);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_y);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_z);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_aa);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ab);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ac);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_ad);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_p);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_r);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_x);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_s);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_w);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_t);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_v);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_u);
		((Control)this.m_h).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_h).Location = new Point(8, 13);
		((Control)this.m_h).Name = "panel1";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(815, 680);
		((Control)this.m_h).TabIndex = 34;
		((EditBase)c8).AutoScroll = false;
		((EditBase)c8).AutoScrollMargin = new Size(0, 0);
		((EditBase)c8).AutoScrollMinSize = new Size(0, 0);
		((EditBase)c8).AutoScrollPosition = new Point(0, 0);
		((EditBase)c8).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)c8).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)c8).Location = new Point(112, 135);
		c8.Mask = "0000/00/00";
		((EditBase)c8).MaxLength = 12;
		((Control)c8).Name = "txtbDateM";
		c8.Numeric = true;
		((Control)c8).RightToLeft = (RightToLeft)0;
		((Control)c8).Size = new Size(143, 26);
		((Control)c8).TabIndex = 8;
		((Control)c8).Tag = "";
		((EditBase)c8).TextAlignment = (TextAlignment)3;
		((Control)c8).Leave += u;
		((Control)c8).Enter += t;
		((Control)c9).AutoSize = true;
		((Control)c9).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)c9).Location = new Point(260, 141);
		((Control)c9).Name = "label49";
		((Control)c9).Size = new Size(60, 13);
		((Control)c9).TabIndex = 148;
		((Control)c9).Text = "تولد میلادی";
		((Control)c6).Location = new Point(450, 325);
		((Control)c6).Name = "dropcityNow";
		((Control)c6).Size = new Size(218, 23);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)c6).StringFormat = val2;
		((Control)c6).TabIndex = 146;
		((Control)c7).AutoSize = true;
		((Control)c7).Location = new Point(674, 328);
		((Control)c7).Name = "label48";
		((Control)c7).Size = new Size(136, 16);
		((Control)c7).TabIndex = 147;
		((Control)c7).Text = "ولسوالی\u200c سکونت فعلی";
		((Control)c4).AutoSize = true;
		((Control)c4).Location = new Point(102, 219);
		((Control)c4).Name = "label47";
		((Control)c4).Size = new Size(62, 16);
		((Control)c4).TabIndex = 145;
		((Control)c4).Text = "کد تخفیف";
		((EditBase)c5).AutoScroll = false;
		((EditBase)c5).AutoScrollMargin = new Size(0, 0);
		((EditBase)c5).AutoScrollMinSize = new Size(0, 0);
		((EditBase)c5).AutoScrollPosition = new Point(0, 0);
		((EditBase)c5).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)c5).Location = new Point(3, 215);
		((EditBase)c5).MaxLength = 9;
		((Control)c5).Name = "txtcodeTakhfif";
		c5.Numeric = true;
		((Control)c5).RightToLeft = (RightToLeft)1;
		((Control)c5).Size = new Size(96, 23);
		((Control)c5).TabIndex = 14;
		((Control)c5).Tag = "";
		((EditBase)c5).TextAlignment = (TextAlignment)1;
		((Control)c5).Leave += u;
		((Control)c5).Enter += t;
		((Control)c3).AutoSize = true;
		((Control)c3).Location = new Point(208, 393);
		((Control)c3).Name = "checkMarkTerm3_From100";
		((Control)c3).Size = new Size(152, 20);
		((Control)c3).TabIndex = 36;
		((Control)c3).Text = "ورود نمره سالانه از 100";
		((ButtonBase)c3).UseVisualStyleBackColor = true;
		((Control)c1).AutoSize = true;
		((Control)c1).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)c1).Location = new Point(260, 101);
		((Control)c1).Name = "label46";
		((Control)c1).Size = new Size(80, 13);
		((Control)c1).TabIndex = 143;
		((Control)c1).Text = "تخلص انگلیسی";
		((EditBase)c2).AutoScroll = false;
		((EditBase)c2).AutoScrollMargin = new Size(0, 0);
		((EditBase)c2).AutoScrollMinSize = new Size(0, 0);
		((EditBase)c2).AutoScrollPosition = new Point(0, 0);
		((Control)c2).Location = new Point(112, 97);
		((Control)c2).Name = "txtEn_LastName";
		((Control)c2).Size = new Size(143, 23);
		((Control)c2).TabIndex = 5;
		((EditBase)c2).TextAlignment = (TextAlignment)1;
		((Control)c2).Leave += b;
		((Control)c2).Enter += d;
		((Control)cz).AutoSize = true;
		((Control)cz).Location = new Point(494, 63);
		((Control)cz).Name = "label45";
		((Control)cz).Size = new Size(41, 16);
		((Control)cz).TabIndex = 141;
		((Control)cz).Text = "تخلص";
		((EditBase)c0).AutoScroll = false;
		((EditBase)c0).AutoScrollMargin = new Size(0, 0);
		((EditBase)c0).AutoScrollMinSize = new Size(0, 0);
		((EditBase)c0).AutoScrollPosition = new Point(0, 0);
		((Control)c0).Location = new Point(346, 60);
		((Control)c0).Name = "txtLastName";
		((Control)c0).Size = new Size(143, 23);
		((Control)c0).TabIndex = 1;
		((EditBase)c0).TextAlignment = (TextAlignment)1;
		((Control)c0).Leave += c;
		((Control)c0).Enter += e;
		((Control)cv).AutoSize = true;
		((Control)cv).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cv).Location = new Point(723, 142);
		((Control)cv).Name = "label44";
		((Control)cv).Size = new Size(82, 13);
		((Control)cv).TabIndex = 139;
		((Control)cv).Text = "نام پدر انگلیسی";
		((EditBase)cw).AutoScroll = false;
		((EditBase)cw).AutoScrollMargin = new Size(0, 0);
		((EditBase)cw).AutoScrollMinSize = new Size(0, 0);
		((EditBase)cw).AutoScrollPosition = new Point(0, 0);
		((Control)cw).Location = new Point(583, 138);
		((Control)cw).Name = "txtEn_Lname";
		((Control)cw).Size = new Size(136, 23);
		((Control)cw).TabIndex = 6;
		((EditBase)cw).TextAlignment = (TextAlignment)1;
		((Control)cw).Leave += f;
		((Control)cw).Enter += h;
		((Control)cx).AutoSize = true;
		((Control)cx).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cx).Location = new Point(490, 101);
		((Control)cx).Name = "label43";
		((Control)cx).Size = new Size(70, 14);
		((Control)cx).TabIndex = 137;
		((Control)cx).Text = "نام انگلیسی";
		((EditBase)cy).AutoScroll = false;
		((EditBase)cy).AutoScrollMargin = new Size(0, 0);
		((EditBase)cy).AutoScrollMinSize = new Size(0, 0);
		((EditBase)cy).AutoScrollPosition = new Point(0, 0);
		((Control)cy).Location = new Point(346, 97);
		((Control)cy).Name = "txtEn_Fname";
		((Control)cy).Size = new Size(143, 23);
		((Control)cy).TabIndex = 4;
		((EditBase)cy).TextAlignment = (TextAlignment)1;
		((Control)cy).Leave += g;
		((Control)cy).Enter += i;
		((Control)ct).Location = new Point(7, 255);
		((Control)ct).Name = "dropcity";
		((Control)ct).Size = new Size(179, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)ct).StringFormat = val3;
		((Control)ct).TabIndex = 18;
		((Control)cu).AutoSize = true;
		((Control)cu).Location = new Point(190, 258);
		((Control)cu).Name = "label42";
		((Control)cu).Size = new Size(147, 16);
		((Control)cu).TabIndex = 135;
		((Control)cu).Text = "ولسوالی\u200c سکونت اصلی :";
		((Control)cr).AutoSize = true;
		((Control)cr).Location = new Point(562, 478);
		((Control)cr).Name = "label41";
		((Control)cr).Size = new Size(38, 16);
		((Control)cr).TabIndex = 134;
		((Control)cr).Text = "راننده";
		((Control)cs).Enabled = false;
		((Control)cs).Location = new Point(421, 475);
		((Control)cs).Name = "dropDriver";
		((Control)cs).Size = new Size(138, 23);
		val4.Alignment = (StringAlignment)0;
		val4.FormatFlags = (StringFormatFlags)20485;
		val4.HotkeyPrefix = (HotkeyPrefix)0;
		val4.LineAlignment = (StringAlignment)1;
		val4.Trimming = (StringTrimming)1;
		((UIComboBase)cs).StringFormat = val4;
		((Control)cs).TabIndex = 39;
		((Control)cs).Leave += j;
		((Control)co).BackColor = SystemColors.HotTrack;
		co.BorderStyle = (BorderStyle)1;
		((Control)co).Controls.Add((Control)(object)cp);
		((Control)co).Location = new Point(142, 5);
		((Control)co).Name = "pLastReg";
		((Control)co).Size = new Size(281, 49);
		((Control)co).TabIndex = 132;
		((Control)co).Visible = false;
		((Control)cp).BackColor = Color.FromArgb(0, 192, 192);
		cp.BorderStyle = (BorderStyle)1;
		((Control)cp).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cp).Location = new Point(6, 5);
		((Control)cp).Name = "lLastReg";
		((Control)cp).Size = new Size(267, 37);
		((Control)cp).TabIndex = 131;
		cp.TextAlign = (ContentAlignment)32;
		cn.ButtonStyle = (ButtonStyle)1;
		((Control)cn).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cn.Image = (Image)componentResourceManager.GetObject("btnEnableItem.Image");
		cn.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		cn.ImageIndex = 8;
		((Control)cn).Location = new Point(566, 6);
		((Control)cn).Name = "btnEnableItem";
		((Control)cn).RightToLeft = (RightToLeft)1;
		((Control)cn).Size = new Size(224, 31);
		((Control)cn).TabIndex = 129;
		((Control)cn).Text = "فعال و غیر فعال کردن آیتم های ثبت نام";
		((Control)cn).Visible = false;
		cn.VisualStyle = (VisualStyle)1;
		((Control)cn).Click += k;
		((Control)cq).AutoSize = true;
		((Control)cq).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cq).Location = new Point(430, 19);
		((Control)cq).Name = "llastReglable";
		((Control)cq).Size = new Size(98, 16);
		((Control)cq).TabIndex = 127;
		((Control)cq).Text = "نفر آخر ثبت نام";
		((Control)cq).Visible = false;
		((EditBase)cm).AutoScroll = false;
		((EditBase)cm).AutoScrollMargin = new Size(0, 0);
		((EditBase)cm).AutoScrollMinSize = new Size(0, 0);
		((EditBase)cm).AutoScrollPosition = new Point(0, 0);
		((EditBase)cm).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)cm).Enabled = false;
		((Control)cm).Location = new Point(23, 432);
		((EditBase)cm).MaxLength = 10;
		((Control)cm).Name = "txtFeeClass";
		cm.Numeric = true;
		((Control)cm).RightToLeft = (RightToLeft)1;
		((Control)cm).Size = new Size(76, 23);
		((Control)cm).TabIndex = 126;
		((Control)cm).Tag = "";
		((EditBase)cm).TextAlignment = (TextAlignment)1;
		((UIComboBase)ck).DropListFont = new Font("B Nazanin", 12f);
		((Control)ck).Location = new Point(16, 471);
		((Control)ck).Name = "comboTakhfif";
		((Control)ck).Size = new Size(156, 23);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)ck).StringFormat = val5;
		((Control)ck).TabIndex = 40;
		((Control)ck).Leave += m;
		ck.SelectedIndexChanged += n;
		((Control)cl).AutoSize = true;
		((Control)cl).Location = new Point(178, 475);
		((Control)cl).Name = "label40";
		((Control)cl).Size = new Size(45, 16);
		((Control)cl).TabIndex = 124;
		((Control)cl).Text = "تخفیف";
		((Control)ci).Controls.Add((Control)(object)cj);
		((Control)ci).Controls.Add((Control)(object)ch);
		((Control)ci).Controls.Add((Control)(object)cf);
		((Control)ci).Controls.Add((Control)(object)cg);
		((Control)ci).Location = new Point(410, 625);
		((Control)ci).Name = "pEditList";
		((Control)ci).Size = new Size(383, 41);
		((Control)ci).TabIndex = 123;
		((Control)ci).Visible = false;
		((Control)cj).AutoSize = true;
		((Control)cj).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)cj).Location = new Point(22, 1);
		((Control)cj).Name = "label39";
		((Control)cj).Size = new Size(97, 13);
		((Control)cj).TabIndex = 133;
		((Control)cj).Text = "اشاره گر روی گزینه ";
		((Control)ch).Anchor = (AnchorStyles)9;
		((UIComboBase)ch).ComboStyle = (ComboStyle)1;
		((UIComboBase)ch).DropListFont = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ch).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		val6.FormatStyle.Alpha = 0;
		val6.Text = "نام";
		val6.Value = "txtNamF";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "تخلص";
		val7.Value = "txtLastName";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "ولد/بنت";
		val8.Value = "txtNamL";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "ولدیت";
		val9.Value = "txtNamP";
		val10.FormatStyle.Alpha = 0;
		val10.Text = "نام انگلیسی";
		val10.Value = "txtEn_Fname";
		val11.FormatStyle.Alpha = 0;
		val11.Text = "تخلص انگلیسی";
		val11.Value = "En_LastName";
		val12.FormatStyle.Alpha = 0;
		val12.Text = "نام پدر انگلیسی";
		val12.Value = "txtEn_Lname";
		val13.FormatStyle.Alpha = 0;
		val13.Text = "نمبرتلگرام";
		val13.Value = "txtNumberTelegram";
		val14.FormatStyle.Alpha = 0;
		val14.Text = "تلفن پدر";
		val14.Value = "txtMobileFather";
		val15.FormatStyle.Alpha = 0;
		val15.Text = "تلفن مادر";
		val15.Value = "txtMobileMother";
		val16.FormatStyle.Alpha = 0;
		val16.Text = "تاریخ تولد";
		val16.Value = "txtbDate";
		val17.FormatStyle.Alpha = 0;
		val17.Text = "نمبرتذکره";
		val17.Value = "txtSh_sh";
		val18.FormatStyle.Alpha = 0;
		val18.Text = "نمبر اساس";
		val18.Value = "txtNumberAsas";
		val19.FormatStyle.Alpha = 0;
		val19.Text = "جنیست";
		val19.Value = "dropJens";
		val20.FormatStyle.Alpha = 0;
		val20.Text = "دین / مذهب";
		val20.Value = "dropMazhab";
		val21.FormatStyle.Alpha = 0;
		val21.Text = "وضعیت";
		val21.Value = "dropStatus";
		val22.FormatStyle.Alpha = 0;
		val22.Text = "تاریخ شمولیت";
		val22.Value = "txtRegDate";
		val23.FormatStyle.Alpha = 0;
		val23.Text = "کد متعلم";
		val23.Value = "txtCode";
		val24.FormatStyle.Alpha = 0;
		val24.Text = "آدرس";
		val24.Value = "txtAdress";
		val25.FormatStyle.Alpha = 0;
		val25.Text = "داخله";
		val25.Value = "checkdakhle";
		val26.FormatStyle.Alpha = 0;
		val26.Text = "صنف";
		val26.Value = "dropCls";
		val27.FormatStyle.Alpha = 0;
		val27.Text = "مجموع ترانسپورت";
		val27.Value = "txtSumtransport";
		val28.FormatStyle.Alpha = 0;
		val28.Text = "راننده";
		val28.Value = "dropDriver";
		val29.FormatStyle.Alpha = 0;
		val29.Text = "فیس";
		val29.Value = "txtFee1";
		val30.FormatStyle.Alpha = 0;
		val30.Text = "ولسوالی";
		val30.Value = "dropcity";
		ch.Items.AddRange(new UIComboBoxItem[25]
		{
			val6, val7, val8, val9, val10, val11, val12, val13, val14, val15,
			val16, val17, val18, val19, val20, val21, val22, val23, val24, val25,
			val26, val27, val28, val29, val30
		});
		((Control)ch).Location = new Point(8, 18);
		((Control)ch).Name = "comboFocse";
		((Control)ch).Size = new Size(122, 21);
		val31.Alignment = (StringAlignment)0;
		val31.FormatFlags = (StringFormatFlags)20485;
		val31.HotkeyPrefix = (HotkeyPrefix)0;
		val31.LineAlignment = (StringAlignment)1;
		val31.Trimming = (StringTrimming)1;
		((UIComboBase)ch).StringFormat = val31;
		((Control)ch).TabIndex = 122;
		ch.SelectedIndexChanged += p;
		((Control)cf).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		cf.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		cf.ImageIndex = 8;
		cf.ImageSize = new Size(30, 30);
		((Control)cf).Location = new Point(164, 2);
		((Control)cf).Name = "btnPrevious";
		((Control)cf).RightToLeft = (RightToLeft)1;
		((Control)cf).Size = new Size(106, 38);
		((Control)cf).TabIndex = 121;
		((Control)cf).Text = "(pageUp) قبلی  ";
		cf.ToolTipText = "دکمه میانبر : PageUp";
		cf.VisualStyle = (VisualStyle)1;
		((Control)cf).Click += q;
		((Control)cg).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		cg.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		cg.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		cg.ImageIndex = 8;
		cg.ImageSize = new Size(30, 30);
		((Control)cg).Location = new Point(273, 2);
		((Control)cg).Name = "btnNext";
		((Control)cg).RightToLeft = (RightToLeft)1;
		((Control)cg).Size = new Size(106, 38);
		((Control)cg).TabIndex = 120;
		((Control)cg).Tag = "";
		((Control)cg).Text = "(pageDown) بعدی  ";
		cg.ToolTipText = "دکمه میانبر : PageDown";
		cg.VisualStyle = (VisualStyle)1;
		((Control)cg).Click += r;
		((UIComboBase)ce).ComboStyle = (ComboStyle)1;
		((UIComboBase)ce).DropListFont = new Font("B Nazanin", 12f);
		((Control)ce).Location = new Point(387, 570);
		((Control)ce).Name = "comboStd";
		((Control)ce).Size = new Size(39, 23);
		val32.Alignment = (StringAlignment)0;
		val32.FormatFlags = (StringFormatFlags)20485;
		val32.HotkeyPrefix = (HotkeyPrefix)0;
		val32.LineAlignment = (StringAlignment)1;
		val32.Trimming = (StringTrimming)1;
		((UIComboBase)ce).StringFormat = val32;
		((Control)ce).TabIndex = 119;
		((Control)ce).Visible = false;
		ce.SelectedIndexChanged += s;
		((Control)cc).AutoSize = true;
		((Control)cc).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cc).Location = new Point(492, 142);
		((Control)cc).Name = "label38";
		((Control)cc).Size = new Size(92, 13);
		((Control)cc).TabIndex = 118;
		((Control)cc).Text = "تاریخ تولد شمسی";
		((EditBase)cd).AutoScroll = false;
		((EditBase)cd).AutoScrollMargin = new Size(0, 0);
		((EditBase)cd).AutoScrollMinSize = new Size(0, 0);
		((EditBase)cd).AutoScrollPosition = new Point(0, 0);
		((EditBase)cd).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)cd).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)cd).Location = new Point(346, 135);
		cd.Mask = "0000/00/00";
		((EditBase)cd).MaxLength = 12;
		((Control)cd).Name = "txtbDate";
		cd.Numeric = true;
		((Control)cd).RightToLeft = (RightToLeft)0;
		((Control)cd).Size = new Size(143, 26);
		((Control)cd).TabIndex = 7;
		((Control)cd).Tag = "";
		((EditBase)cd).TextAlignment = (TextAlignment)3;
		((Control)cd).Leave += a;
		((Control)cd).Enter += t;
		cb.BorderStyle = (BorderStyle)1;
		((Control)cb).Location = new Point(635, 431);
		((Control)cb).Name = "lYear";
		((Control)cb).Size = new Size(55, 24);
		((Control)cb).TabIndex = 116;
		((Control)bp).Controls.Add((Control)(object)bq);
		((Control)bp).Controls.Add((Control)(object)br);
		((Control)bp).Controls.Add((Control)(object)bs);
		((Control)bp).Controls.Add((Control)(object)bt);
		((Control)bp).Controls.Add((Control)(object)bu);
		((Control)bp).Controls.Add((Control)(object)bv);
		((Control)bp).Controls.Add((Control)(object)bw);
		((Control)bp).Controls.Add((Control)(object)bx);
		((Control)bp).Controls.Add((Control)(object)by);
		((Control)bp).Controls.Add((Control)(object)bz);
		((Control)bp).Controls.Add((Control)(object)b0);
		((Control)bp).Controls.Add((Control)(object)b1);
		((Control)bp).Controls.Add((Control)(object)b2);
		((Control)bp).Controls.Add((Control)(object)b3);
		((Control)bp).Controls.Add((Control)(object)b4);
		((Control)bp).Controls.Add((Control)(object)b5);
		((Control)bp).Controls.Add((Control)(object)b6);
		((Control)bp).Controls.Add((Control)(object)b7);
		((Control)bp).Enabled = false;
		((Control)bp).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bp).Location = new Point(14, 503);
		((Control)bp).Name = "GroupFee";
		((Control)bp).Size = new Size(372, 110);
		((Control)bp).TabIndex = 42;
		((Control)bp).Text = "فیس";
		((Control)bq).AutoSize = true;
		((Control)bq).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bq).Location = new Point(80, 81);
		((Control)bq).Name = "label29";
		((Control)bq).Size = new Size(30, 13);
		((Control)bq).TabIndex = 132;
		((Control)bq).Text = "قوس";
		((Control)br).AutoSize = true;
		((Control)br).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)br).Location = new Point(80, 54);
		((Control)br).Name = "label30";
		((Control)br).Size = new Size(36, 13);
		((Control)br).TabIndex = 131;
		((Control)br).Text = "سنبله";
		((Control)bs).AutoSize = true;
		((Control)bs).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bs).Location = new Point(80, 27);
		((Control)bs).Name = "label31";
		((Control)bs).Size = new Size(26, 13);
		((Control)bs).TabIndex = 130;
		((Control)bs).Text = "جوزا";
		((Control)bt).AutoSize = true;
		((Control)bt).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bt).Location = new Point(213, 81);
		((Control)bt).Name = "label32";
		((Control)bt).Size = new Size(34, 13);
		((Control)bt).TabIndex = 129;
		((Control)bt).Text = "عقرب";
		((Control)bu).AutoSize = true;
		((Control)bu).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bu).Location = new Point(213, 54);
		((Control)bu).Name = "label33";
		((Control)bu).Size = new Size(27, 13);
		((Control)bu).TabIndex = 128;
		((Control)bu).Text = "اسد";
		((Control)bv).AutoSize = true;
		((Control)bv).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bv).Location = new Point(213, 27);
		((Control)bv).Name = "label34";
		((Control)bv).Size = new Size(19, 13);
		((Control)bv).TabIndex = 127;
		((Control)bv).Text = "ثور";
		((Control)bw).AutoSize = true;
		((Control)bw).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bw).Location = new Point(325, 81);
		((Control)bw).Name = "label35";
		((Control)bw).Size = new Size(32, 13);
		((Control)bw).TabIndex = 126;
		((Control)bw).Text = "میزان";
		((Control)bx).AutoSize = true;
		((Control)bx).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bx).Location = new Point(323, 55);
		((Control)bx).Name = "label36";
		((Control)bx).Size = new Size(40, 13);
		((Control)bx).TabIndex = 125;
		((Control)bx).Text = "سرطان";
		((Control)by).AutoSize = true;
		((Control)by).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)by).Location = new Point(325, 27);
		((Control)by).Name = "label37";
		((Control)by).Size = new Size(29, 13);
		((Control)by).TabIndex = 124;
		((Control)by).Text = "حمل";
		((EditBase)bz).AutoScroll = false;
		((EditBase)bz).AutoScrollMargin = new Size(0, 0);
		((EditBase)bz).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bz).AutoScrollPosition = new Point(0, 0);
		((EditBase)bz).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bz).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bz).Location = new Point(11, 77);
		((EditBase)bz).MaxLength = 8;
		((Control)bz).Name = "txtFee9";
		bz.Numeric = true;
		((Control)bz).RightToLeft = (RightToLeft)1;
		((Control)bz).Size = new Size(63, 21);
		((Control)bz).TabIndex = 49;
		((Control)bz).Tag = "";
		((EditBase)bz).TextAlignment = (TextAlignment)1;
		((Control)bz).Leave += u;
		((Control)bz).KeyUp += d;
		((Control)bz).Enter += t;
		((EditBase)b0).AutoScroll = false;
		((EditBase)b0).AutoScrollMargin = new Size(0, 0);
		((EditBase)b0).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b0).AutoScrollPosition = new Point(0, 0);
		((EditBase)b0).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b0).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b0).Location = new Point(11, 50);
		((EditBase)b0).MaxLength = 8;
		((Control)b0).Name = "txtFee6";
		b0.Numeric = true;
		((Control)b0).RightToLeft = (RightToLeft)1;
		((Control)b0).Size = new Size(63, 21);
		((Control)b0).TabIndex = 46;
		((Control)b0).Tag = "";
		((EditBase)b0).TextAlignment = (TextAlignment)1;
		((Control)b0).Leave += u;
		((Control)b0).KeyUp += g;
		((Control)b0).Enter += t;
		((EditBase)b1).AutoScroll = false;
		((EditBase)b1).AutoScrollMargin = new Size(0, 0);
		((EditBase)b1).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b1).AutoScrollPosition = new Point(0, 0);
		((EditBase)b1).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b1).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b1).Location = new Point(11, 23);
		((EditBase)b1).MaxLength = 8;
		((Control)b1).Name = "txtFee3";
		b1.Numeric = true;
		((Control)b1).RightToLeft = (RightToLeft)1;
		((Control)b1).Size = new Size(63, 21);
		((Control)b1).TabIndex = 43;
		((Control)b1).Tag = "";
		((EditBase)b1).TextAlignment = (TextAlignment)1;
		((Control)b1).Leave += u;
		((Control)b1).KeyUp += j;
		((Control)b1).Enter += t;
		((EditBase)b2).AutoScroll = false;
		((EditBase)b2).AutoScrollMargin = new Size(0, 0);
		((EditBase)b2).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b2).AutoScrollPosition = new Point(0, 0);
		((EditBase)b2).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b2).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b2).Location = new Point(144, 77);
		((EditBase)b2).MaxLength = 8;
		((Control)b2).Name = "txtFee8";
		b2.Numeric = true;
		((Control)b2).RightToLeft = (RightToLeft)1;
		((Control)b2).Size = new Size(63, 21);
		((Control)b2).TabIndex = 48;
		((Control)b2).Tag = "";
		((EditBase)b2).TextAlignment = (TextAlignment)1;
		((Control)b2).Leave += u;
		((Control)b2).KeyUp += e;
		((Control)b2).Enter += t;
		((EditBase)b3).AutoScroll = false;
		((EditBase)b3).AutoScrollMargin = new Size(0, 0);
		((EditBase)b3).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b3).AutoScrollPosition = new Point(0, 0);
		((EditBase)b3).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b3).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b3).Location = new Point(144, 50);
		((EditBase)b3).MaxLength = 8;
		((Control)b3).Name = "txtFee5";
		b3.Numeric = true;
		((Control)b3).RightToLeft = (RightToLeft)1;
		((Control)b3).Size = new Size(63, 21);
		((Control)b3).TabIndex = 45;
		((Control)b3).Tag = "";
		((EditBase)b3).TextAlignment = (TextAlignment)1;
		((Control)b3).Leave += u;
		((Control)b3).KeyUp += h;
		((Control)b3).Enter += t;
		((EditBase)b4).AutoScroll = false;
		((EditBase)b4).AutoScrollMargin = new Size(0, 0);
		((EditBase)b4).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b4).AutoScrollPosition = new Point(0, 0);
		((EditBase)b4).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b4).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b4).Location = new Point(144, 23);
		((EditBase)b4).MaxLength = 8;
		((Control)b4).Name = "txtFee2";
		b4.Numeric = true;
		((Control)b4).RightToLeft = (RightToLeft)1;
		((Control)b4).Size = new Size(63, 21);
		((Control)b4).TabIndex = 42;
		((Control)b4).Tag = "";
		((EditBase)b4).TextAlignment = (TextAlignment)1;
		((Control)b4).Leave += u;
		((Control)b4).KeyUp += k;
		((Control)b4).Enter += t;
		((EditBase)b5).AutoScroll = false;
		((EditBase)b5).AutoScrollMargin = new Size(0, 0);
		((EditBase)b5).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b5).AutoScrollPosition = new Point(0, 0);
		((EditBase)b5).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b5).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b5).Location = new Point(262, 77);
		((EditBase)b5).MaxLength = 8;
		((Control)b5).Name = "txtFee7";
		b5.Numeric = true;
		((Control)b5).RightToLeft = (RightToLeft)1;
		((Control)b5).Size = new Size(57, 21);
		((Control)b5).TabIndex = 47;
		((Control)b5).Tag = "";
		((EditBase)b5).TextAlignment = (TextAlignment)1;
		((Control)b5).Leave += u;
		((Control)b5).KeyUp += f;
		((Control)b5).Enter += t;
		((EditBase)b6).AutoScroll = false;
		((EditBase)b6).AutoScrollMargin = new Size(0, 0);
		((EditBase)b6).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b6).AutoScrollPosition = new Point(0, 0);
		((EditBase)b6).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b6).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b6).Location = new Point(262, 50);
		((EditBase)b6).MaxLength = 8;
		((Control)b6).Name = "txtFee4";
		b6.Numeric = true;
		((Control)b6).RightToLeft = (RightToLeft)1;
		((Control)b6).Size = new Size(57, 21);
		((Control)b6).TabIndex = 44;
		((Control)b6).Tag = "";
		((EditBase)b6).TextAlignment = (TextAlignment)1;
		((Control)b6).Leave += u;
		((Control)b6).KeyUp += i;
		((Control)b6).Enter += t;
		((EditBase)b7).AutoScroll = false;
		((EditBase)b7).AutoScrollMargin = new Size(0, 0);
		((EditBase)b7).AutoScrollMinSize = new Size(0, 0);
		((EditBase)b7).AutoScrollPosition = new Point(0, 0);
		((EditBase)b7).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b7).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)b7).Location = new Point(262, 23);
		((EditBase)b7).MaxLength = 8;
		((Control)b7).Name = "txtFee1";
		b7.Numeric = true;
		((EditBase)b7).ReadOnly = true;
		((Control)b7).RightToLeft = (RightToLeft)1;
		((Control)b7).Size = new Size(57, 21);
		((Control)b7).TabIndex = 41;
		((Control)b7).Tag = "";
		((EditBase)b7).TextAlignment = (TextAlignment)1;
		((Control)b7).Leave += u;
		((Control)b7).KeyUp += l;
		((Control)b7).Enter += t;
		((Control)a9).Controls.Add((Control)(object)b8);
		((Control)a9).Controls.Add((Control)(object)b9);
		((Control)a9).Controls.Add((Control)(object)ca);
		((Control)a9).Controls.Add((Control)(object)bj);
		((Control)a9).Controls.Add((Control)(object)bk);
		((Control)a9).Controls.Add((Control)(object)bl);
		((Control)a9).Controls.Add((Control)(object)bm);
		((Control)a9).Controls.Add((Control)(object)bn);
		((Control)a9).Controls.Add((Control)(object)bo);
		((Control)a9).Controls.Add((Control)(object)ba);
		((Control)a9).Controls.Add((Control)(object)bb);
		((Control)a9).Controls.Add((Control)(object)bc);
		((Control)a9).Controls.Add((Control)(object)bd);
		((Control)a9).Controls.Add((Control)(object)be);
		((Control)a9).Controls.Add((Control)(object)bf);
		((Control)a9).Controls.Add((Control)(object)bg);
		((Control)a9).Controls.Add((Control)(object)bh);
		((Control)a9).Controls.Add((Control)(object)bi);
		((Control)a9).Enabled = false;
		((Control)a9).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)a9).Location = new Point(422, 503);
		((Control)a9).Name = "groupTransport";
		((Control)a9).Size = new Size(372, 110);
		((Control)a9).TabIndex = 41;
		((Control)a9).Text = "ترانسپورت";
		((Control)b8).AutoSize = true;
		((Control)b8).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)b8).Location = new Point(80, 81);
		((Control)b8).Name = "label26";
		((Control)b8).Size = new Size(30, 13);
		((Control)b8).TabIndex = 132;
		((Control)b8).Text = "قوس";
		((Control)b9).AutoSize = true;
		((Control)b9).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)b9).Location = new Point(80, 54);
		((Control)b9).Name = "label27";
		((Control)b9).Size = new Size(36, 13);
		((Control)b9).TabIndex = 131;
		((Control)b9).Text = "سنبله";
		((Control)ca).AutoSize = true;
		((Control)ca).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ca).Location = new Point(80, 27);
		((Control)ca).Name = "label28";
		((Control)ca).Size = new Size(26, 13);
		((Control)ca).TabIndex = 130;
		((Control)ca).Text = "جوزا";
		((Control)bj).AutoSize = true;
		((Control)bj).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bj).Location = new Point(213, 81);
		((Control)bj).Name = "label25";
		((Control)bj).Size = new Size(34, 13);
		((Control)bj).TabIndex = 129;
		((Control)bj).Text = "عقرب";
		((Control)bk).AutoSize = true;
		((Control)bk).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bk).Location = new Point(213, 54);
		((Control)bk).Name = "label24";
		((Control)bk).Size = new Size(27, 13);
		((Control)bk).TabIndex = 128;
		((Control)bk).Text = "اسد";
		((Control)bl).AutoSize = true;
		((Control)bl).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bl).Location = new Point(213, 27);
		((Control)bl).Name = "label23";
		((Control)bl).Size = new Size(19, 13);
		((Control)bl).TabIndex = 127;
		((Control)bl).Text = "ثور";
		((Control)bm).AutoSize = true;
		((Control)bm).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bm).Location = new Point(325, 81);
		((Control)bm).Name = "label22";
		((Control)bm).Size = new Size(32, 13);
		((Control)bm).TabIndex = 126;
		((Control)bm).Text = "میزان";
		((Control)bn).AutoSize = true;
		((Control)bn).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bn).Location = new Point(324, 54);
		((Control)bn).Name = "label21";
		((Control)bn).Size = new Size(40, 13);
		((Control)bn).TabIndex = 125;
		((Control)bn).Text = "سرطان";
		((Control)bo).AutoSize = true;
		((Control)bo).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)bo).Location = new Point(325, 27);
		((Control)bo).Name = "label18";
		((Control)bo).Size = new Size(29, 13);
		((Control)bo).TabIndex = 124;
		((Control)bo).Text = "حمل";
		((EditBase)ba).AutoScroll = false;
		((EditBase)ba).AutoScrollMargin = new Size(0, 0);
		((EditBase)ba).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ba).AutoScrollPosition = new Point(0, 0);
		((EditBase)ba).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ba).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ba).Location = new Point(11, 77);
		((EditBase)ba).MaxLength = 8;
		((Control)ba).Name = "txttransport9";
		ba.Numeric = true;
		((Control)ba).RightToLeft = (RightToLeft)1;
		((Control)ba).Size = new Size(63, 21);
		((Control)ba).TabIndex = 69;
		((Control)ba).Tag = "";
		((EditBase)ba).TextAlignment = (TextAlignment)1;
		((Control)ba).Leave += u;
		((Control)ba).KeyUp += m;
		((Control)ba).Enter += t;
		((EditBase)bb).AutoScroll = false;
		((EditBase)bb).AutoScrollMargin = new Size(0, 0);
		((EditBase)bb).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bb).AutoScrollPosition = new Point(0, 0);
		((EditBase)bb).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bb).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bb).Location = new Point(11, 50);
		((EditBase)bb).MaxLength = 8;
		((Control)bb).Name = "txttransport6";
		bb.Numeric = true;
		((Control)bb).RightToLeft = (RightToLeft)1;
		((Control)bb).Size = new Size(63, 21);
		((Control)bb).TabIndex = 66;
		((Control)bb).Tag = "";
		((EditBase)bb).TextAlignment = (TextAlignment)1;
		((Control)bb).Leave += u;
		((Control)bb).KeyUp += p;
		((Control)bb).Enter += t;
		((EditBase)bc).AutoScroll = false;
		((EditBase)bc).AutoScrollMargin = new Size(0, 0);
		((EditBase)bc).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bc).AutoScrollPosition = new Point(0, 0);
		((EditBase)bc).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bc).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bc).Location = new Point(11, 23);
		((EditBase)bc).MaxLength = 8;
		((Control)bc).Name = "txttransport3";
		bc.Numeric = true;
		((Control)bc).RightToLeft = (RightToLeft)1;
		((Control)bc).Size = new Size(63, 21);
		((Control)bc).TabIndex = 63;
		((Control)bc).Tag = "";
		((EditBase)bc).TextAlignment = (TextAlignment)1;
		((Control)bc).Leave += u;
		((Control)bc).KeyUp += s;
		((Control)bc).Enter += t;
		((EditBase)bd).AutoScroll = false;
		((EditBase)bd).AutoScrollMargin = new Size(0, 0);
		((EditBase)bd).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bd).AutoScrollPosition = new Point(0, 0);
		((EditBase)bd).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bd).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bd).Location = new Point(144, 77);
		((EditBase)bd).MaxLength = 8;
		((Control)bd).Name = "txttransport8";
		bd.Numeric = true;
		((Control)bd).RightToLeft = (RightToLeft)1;
		((Control)bd).Size = new Size(63, 21);
		((Control)bd).TabIndex = 68;
		((Control)bd).Tag = "";
		((EditBase)bd).TextAlignment = (TextAlignment)1;
		((Control)bd).Leave += u;
		((Control)bd).KeyUp += n;
		((Control)bd).Enter += t;
		((EditBase)be).AutoScroll = false;
		((EditBase)be).AutoScrollMargin = new Size(0, 0);
		((EditBase)be).AutoScrollMinSize = new Size(0, 0);
		((EditBase)be).AutoScrollPosition = new Point(0, 0);
		((EditBase)be).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)be).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)be).Location = new Point(144, 50);
		((EditBase)be).MaxLength = 8;
		((Control)be).Name = "txttransport5";
		be.Numeric = true;
		((Control)be).RightToLeft = (RightToLeft)1;
		((Control)be).Size = new Size(63, 21);
		((Control)be).TabIndex = 65;
		((Control)be).Tag = "";
		((EditBase)be).TextAlignment = (TextAlignment)1;
		((Control)be).Leave += u;
		((Control)be).KeyUp += q;
		((Control)be).Enter += t;
		((EditBase)bf).AutoScroll = false;
		((EditBase)bf).AutoScrollMargin = new Size(0, 0);
		((EditBase)bf).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bf).AutoScrollPosition = new Point(0, 0);
		((EditBase)bf).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bf).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bf).Location = new Point(144, 23);
		((EditBase)bf).MaxLength = 8;
		((Control)bf).Name = "txttransport2";
		bf.Numeric = true;
		((Control)bf).RightToLeft = (RightToLeft)1;
		((Control)bf).Size = new Size(63, 21);
		((Control)bf).TabIndex = 62;
		((Control)bf).Tag = "";
		((EditBase)bf).TextAlignment = (TextAlignment)1;
		((Control)bf).Leave += u;
		((Control)bf).KeyUp += t;
		((Control)bf).Enter += t;
		((EditBase)bg).AutoScroll = false;
		((EditBase)bg).AutoScrollMargin = new Size(0, 0);
		((EditBase)bg).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bg).AutoScrollPosition = new Point(0, 0);
		((EditBase)bg).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bg).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bg).Location = new Point(262, 77);
		((EditBase)bg).MaxLength = 8;
		((Control)bg).Name = "txttransport7";
		bg.Numeric = true;
		((Control)bg).RightToLeft = (RightToLeft)1;
		((Control)bg).Size = new Size(57, 21);
		((Control)bg).TabIndex = 67;
		((Control)bg).Tag = "";
		((EditBase)bg).TextAlignment = (TextAlignment)1;
		((Control)bg).Leave += u;
		((Control)bg).KeyUp += o;
		((Control)bg).Enter += t;
		((EditBase)bh).AutoScroll = false;
		((EditBase)bh).AutoScrollMargin = new Size(0, 0);
		((EditBase)bh).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bh).AutoScrollPosition = new Point(0, 0);
		((EditBase)bh).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bh).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bh).Location = new Point(262, 50);
		((EditBase)bh).MaxLength = 8;
		((Control)bh).Name = "txttransport4";
		bh.Numeric = true;
		((Control)bh).RightToLeft = (RightToLeft)1;
		((Control)bh).Size = new Size(57, 21);
		((Control)bh).TabIndex = 64;
		((Control)bh).Tag = "";
		((EditBase)bh).TextAlignment = (TextAlignment)1;
		((Control)bh).Leave += u;
		((Control)bh).KeyUp += r;
		((Control)bh).Enter += t;
		((EditBase)bi).AutoScroll = false;
		((EditBase)bi).AutoScrollMargin = new Size(0, 0);
		((EditBase)bi).AutoScrollMinSize = new Size(0, 0);
		((EditBase)bi).AutoScrollPosition = new Point(0, 0);
		((EditBase)bi).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bi).Font = new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)bi).Location = new Point(262, 23);
		((EditBase)bi).MaxLength = 8;
		((Control)bi).Name = "txttransport1";
		bi.Numeric = true;
		((Control)bi).RightToLeft = (RightToLeft)1;
		((Control)bi).Size = new Size(57, 21);
		((Control)bi).TabIndex = 61;
		((Control)bi).Tag = "";
		((EditBase)bi).TextAlignment = (TextAlignment)1;
		((Control)bi).Leave += u;
		((Control)bi).KeyUp += u;
		((Control)bi).Enter += t;
		((EditBase)a7).AutoScroll = false;
		((EditBase)a7).AutoScrollMargin = new Size(0, 0);
		((EditBase)a7).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a7).AutoScrollPosition = new Point(0, 0);
		((Control)a7).Enabled = false;
		((Control)a7).Location = new Point(606, 475);
		((EditBase)a7).MaxLength = 10;
		((Control)a7).Name = "txtSumtransport";
		a7.Numeric = true;
		((Control)a7).RightToLeft = (RightToLeft)1;
		((Control)a7).Size = new Size(80, 23);
		((Control)a7).TabIndex = 38;
		((Control)a7).Tag = "";
		((EditBase)a7).TextAlignment = (TextAlignment)1;
		((Control)a7).Leave += u;
		((Control)a7).KeyUp += c;
		((Control)a7).Enter += t;
		((Control)a8).AutoSize = true;
		((Control)a8).Location = new Point(688, 477);
		((Control)a8).Name = "label17";
		((Control)a8).Size = new Size(107, 16);
		((Control)a8).TabIndex = 115;
		((Control)a8).Text = "مجموع ترانسپورت";
		((EditBase)a5).AutoScroll = false;
		((EditBase)a5).AutoScrollMargin = new Size(0, 0);
		((EditBase)a5).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a5).AutoScrollPosition = new Point(0, 0);
		((Control)a5).Enabled = false;
		((Control)a5).Location = new Point(231, 472);
		((EditBase)a5).MaxLength = 10;
		((Control)a5).Name = "txtSumFee";
		a5.Numeric = true;
		((Control)a5).RightToLeft = (RightToLeft)1;
		((Control)a5).Size = new Size(76, 23);
		((Control)a5).TabIndex = 114;
		((Control)a5).Tag = "";
		((EditBase)a5).TextAlignment = (TextAlignment)1;
		((Control)a5).Leave += u;
		((Control)a5).KeyUp += b;
		((Control)a5).Enter += t;
		((Control)a6).AutoSize = true;
		((Control)a6).Location = new Point(314, 476);
		((Control)a6).Name = "label16";
		((Control)a6).Size = new Size(75, 16);
		((Control)a6).TabIndex = 113;
		((Control)a6).Text = "فیس سالانه";
		((Control)a3).AutoSize = true;
		((Control)a3).Location = new Point(529, 438);
		((Control)a3).Name = "label20";
		((Control)a3).Size = new Size(27, 16);
		((Control)a3).TabIndex = 112;
		((Control)a3).Text = "پایه";
		((Control)a4).Location = new Point(395, 434);
		((Control)a4).Name = "dropPaye";
		((Control)a4).Size = new Size(130, 23);
		val33.Alignment = (StringAlignment)0;
		val33.FormatFlags = (StringFormatFlags)20485;
		val33.HotkeyPrefix = (HotkeyPrefix)0;
		val33.LineAlignment = (StringAlignment)1;
		val33.Trimming = (StringTrimming)1;
		((UIComboBase)a4).StringFormat = val33;
		((Control)a4).TabIndex = 36;
		a4.SelectedIndexChanged += ar;
		((Control)a2).AutoSize = true;
		((Control)a2).Location = new Point(697, 435);
		((Control)a2).Name = "label3";
		((Control)a2).Size = new Size(78, 16);
		((Control)a2).TabIndex = 110;
		((Control)a2).Text = "سال تعلیمی";
		((Control)a1).AutoSize = true;
		((Control)a1).Location = new Point(120, 395);
		((Control)a1).Name = "label13";
		((Control)a1).Size = new Size(65, 16);
		((Control)a1).TabIndex = 24;
		((Control)a1).Text = "تاریخ خروج";
		((Control)ay).AutoSize = true;
		((Control)ay).Font = new Font("Tahoma", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ay).Location = new Point(722, 294);
		((Control)ay).Name = "label12";
		((Control)ay).Size = new Size(75, 14);
		((Control)ay).TabIndex = 107;
		((Control)ay).Text = "تاریخ شمولیت";
		((EditBase)az).AutoScroll = false;
		((EditBase)az).AutoScrollMargin = new Size(0, 0);
		((EditBase)az).AutoScrollMinSize = new Size(0, 0);
		((EditBase)az).AutoScrollPosition = new Point(0, 0);
		((EditBase)az).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)az).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)az).Location = new Point(583, 288);
		az.Mask = "0000/00/00";
		((EditBase)az).MaxLength = 12;
		((Control)az).Name = "txtRegDate";
		az.Numeric = true;
		((Control)az).RightToLeft = (RightToLeft)0;
		((Control)az).Size = new Size(135, 26);
		((Control)az).TabIndex = 16;
		((Control)az).Tag = "";
		((EditBase)az).TextAlignment = (TextAlignment)3;
		((Control)az).Leave += x;
		((Control)az).Enter += t;
		((EditBase)a0).AutoScroll = false;
		((EditBase)a0).AutoScrollMargin = new Size(0, 0);
		((EditBase)a0).AutoScrollMinSize = new Size(0, 0);
		((EditBase)a0).AutoScrollPosition = new Point(0, 0);
		((Control)a0).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)a0).Location = new Point(7, 392);
		a0.Mask = "0000/00/00";
		((EditBase)a0).MaxLength = 12;
		((Control)a0).Name = "txtExitDate";
		a0.Numeric = true;
		((Control)a0).RightToLeft = (RightToLeft)0;
		((Control)a0).Size = new Size(108, 26);
		((Control)a0).TabIndex = 100;
		((Control)a0).Tag = "";
		((EditBase)a0).TextAlignment = (TextAlignment)3;
		((Control)a0).Leave += u;
		((Control)a0).Enter += t;
		((Control)ax).AutoSize = true;
		ax.Checked = true;
		ax.CheckState = (CheckState)1;
		((Control)ax).Location = new Point(379, 393);
		((Control)ax).Name = "checkmali";
		((Control)ax).Size = new Size(94, 20);
		((Control)ax).TabIndex = 35;
		((Control)ax).Text = "لیست مالی";
		((ButtonBase)ax).UseVisualStyleBackColor = true;
		((Control)ax).Leave += w;
		((Control)ax).Enter += v;
		((Control)this.m_av).AutoSize = true;
		this.m_av.Checked = true;
		this.m_av.CheckState = (CheckState)1;
		((Control)this.m_av).Location = new Point(515, 393);
		((Control)this.m_av).Name = "checkhazer";
		((Control)this.m_av).Size = new Size(193, 20);
		((Control)this.m_av).TabIndex = 34;
		((Control)this.m_av).Text = "حاضر در صنف(رسمی و موقت)";
		((ButtonBase)this.m_av).UseVisualStyleBackColor = true;
		((Control)this.m_av).Leave += w;
		((Control)this.m_av).Enter += v;
		((Control)this.m_aw).AutoSize = true;
		this.m_aw.Checked = true;
		this.m_aw.CheckState = (CheckState)1;
		((Control)this.m_aw).Location = new Point(737, 393);
		((Control)this.m_aw).Name = "checkshaghe";
		((Control)this.m_aw).Size = new Size(54, 20);
		((Control)this.m_aw).TabIndex = 33;
		((Control)this.m_aw).Text = "شقه";
		((ButtonBase)this.m_aw).UseVisualStyleBackColor = true;
		((Control)this.m_aw).Leave += w;
		((Control)this.m_aw).Enter += v;
		((Control)this.m_au).AutoSize = true;
		((Control)this.m_au).Location = new Point(89, 363);
		((Control)this.m_au).Name = "checkmaghnae";
		((Control)this.m_au).Size = new Size(59, 20);
		((Control)this.m_au).TabIndex = 32;
		((Control)this.m_au).Text = "مقنعه";
		((ButtonBase)this.m_au).UseVisualStyleBackColor = true;
		((Control)this.m_au).Leave += w;
		((Control)this.m_au).Enter += v;
		((Control)this.m_aq).AutoSize = true;
		((Control)this.m_aq).Location = new Point(174, 363);
		((Control)this.m_aq).Name = "checkrobotic";
		((Control)this.m_aq).Size = new Size(62, 20);
		((Control)this.m_aq).TabIndex = 31;
		((Control)this.m_aq).Text = "رباتیک";
		((ButtonBase)this.m_aq).UseVisualStyleBackColor = true;
		((Control)this.m_aq).Leave += w;
		((Control)this.m_aq).Enter += v;
		((Control)this.m_ar).AutoSize = true;
		((Control)this.m_ar).Location = new Point(276, 363);
		((Control)this.m_ar).Name = "checktransport";
		((Control)this.m_ar).Size = new Size(84, 20);
		((Control)this.m_ar).TabIndex = 30;
		((Control)this.m_ar).Text = "ترانسپورت";
		((ButtonBase)this.m_ar).UseVisualStyleBackColor = true;
		((Control)this.m_ar).Leave += w;
		((Control)this.m_ar).Enter += v;
		this.m_ar.CheckedChanged += l;
		((Control)this.m_as).AutoSize = true;
		((Control)this.m_as).Location = new Point(420, 363);
		((Control)this.m_as).Name = "checkketab";
		((Control)this.m_as).Size = new Size(53, 20);
		((Control)this.m_as).TabIndex = 29;
		((Control)this.m_as).Text = "کتاب";
		((ButtonBase)this.m_as).UseVisualStyleBackColor = true;
		((Control)this.m_as).Leave += w;
		((Control)this.m_as).Enter += v;
		((Control)this.m_at).AutoSize = true;
		((Control)this.m_at).Location = new Point(511, 363);
		((Control)this.m_at).Name = "checkkomakdarsi";
		((Control)this.m_at).Size = new Size(95, 20);
		((Control)this.m_at).TabIndex = 28;
		((Control)this.m_at).Text = "کمک درسی";
		((ButtonBase)this.m_at).UseVisualStyleBackColor = true;
		((Control)this.m_at).Leave += w;
		((Control)this.m_at).Enter += v;
		((Control)this.m_ao).AutoSize = true;
		((Control)this.m_ao).Location = new Point(636, 363);
		((Control)this.m_ao).Name = "checkuniform";
		((Control)this.m_ao).Size = new Size(72, 20);
		((Control)this.m_ao).TabIndex = 27;
		((Control)this.m_ao).Text = "یونیفورم";
		((ButtonBase)this.m_ao).UseVisualStyleBackColor = true;
		((Control)this.m_ao).Leave += w;
		((Control)this.m_ao).Enter += v;
		((Control)this.m_ap).AutoSize = true;
		((Control)this.m_ap).Location = new Point(733, 363);
		((Control)this.m_ap).Name = "checkdakhle";
		((Control)this.m_ap).Size = new Size(57, 20);
		((Control)this.m_ap).TabIndex = 26;
		((Control)this.m_ap).Text = "داخله";
		((ButtonBase)this.m_ap).UseVisualStyleBackColor = true;
		((Control)this.m_ap).Leave += w;
		((Control)this.m_ap).Enter += v;
		((EditBase)this.m_am).AutoScroll = false;
		((EditBase)this.m_am).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_am).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_am).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_am).Location = new Point(7, 326);
		((Control)this.m_am).Name = "txtAdress";
		((Control)this.m_am).Size = new Size(367, 23);
		((Control)this.m_am).TabIndex = 19;
		((EditBase)this.m_am).TextAlignment = (TextAlignment)1;
		((Control)this.m_am).Leave += ap;
		((Control)this.m_am).Enter += ao;
		((Control)this.m_an).AutoSize = true;
		((Control)this.m_an).Location = new Point(376, 329);
		((Control)this.m_an).Name = "label11";
		((Control)this.m_an).Size = new Size(68, 16);
		((Control)this.m_an).TabIndex = 93;
		((Control)this.m_an).Text = "ادامه آدرس";
		((Control)this.m_al).AutoSize = true;
		this.m_al.AutoSizeMode = (AutoSizeMode)0;
		((Control)this.m_al).Location = new Point(21, 158);
		((Control)this.m_al).Name = "panel3";
		((Control)this.m_al).Size = new Size(0, 0);
		((Control)this.m_al).TabIndex = 92;
		((Control)this.m_aj).AutoSize = true;
		((Control)this.m_aj).Location = new Point(495, 259);
		((Control)this.m_aj).Name = "label10";
		((Control)this.m_aj).Size = new Size(46, 16);
		((Control)this.m_aj).TabIndex = 91;
		((Control)this.m_aj).Text = "وضعیت";
		val34.FormatStyle.Alpha = 0;
		val34.Text = "برحال";
		val34.Value = "1";
		val35.FormatStyle.Alpha = 0;
		val35.Text = "محروم";
		val35.Value = "2";
		val36.FormatStyle.Alpha = 0;
		val36.Text = "منفک";
		val36.Value = "3";
		val37.FormatStyle.Alpha = 0;
		val37.Text = "معذرتی";
		val37.Value = "4";
		this.m_ai.Items.AddRange(new UIComboBoxItem[4] { val34, val35, val36, val37 });
		((Control)this.m_ai).Location = new Point(346, 255);
		((Control)this.m_ai).Name = "dropStatus";
		((Control)this.m_ai).Size = new Size(143, 23);
		val38.Alignment = (StringAlignment)0;
		val38.FormatFlags = (StringFormatFlags)20485;
		val38.HotkeyPrefix = (HotkeyPrefix)0;
		val38.LineAlignment = (StringAlignment)1;
		val38.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_ai).StringFormat = val38;
		((Control)this.m_ai).TabIndex = 15;
		((Control)this.m_ag).AutoSize = true;
		((Control)this.m_ag).Location = new Point(726, 218);
		((Control)this.m_ag).Name = "label9";
		((Control)this.m_ag).Size = new Size(57, 16);
		((Control)this.m_ag).TabIndex = 89;
		((Control)this.m_ag).Text = "کد متعلم";
		val39.FormatStyle.Alpha = 0;
		val39.Text = "";
		val39.Value = "-1";
		val40.FormatStyle.Alpha = 0;
		val40.Text = "شیعه";
		val40.Value = "1";
		val41.FormatStyle.Alpha = 0;
		val41.Text = "سنی";
		val41.Value = "2";
		this.m_ah.Items.AddRange(new UIComboBoxItem[3] { val39, val40, val41 });
		((Control)this.m_ah).Location = new Point(577, 255);
		((Control)this.m_ah).Name = "dropMazhab";
		((Control)this.m_ah).Size = new Size(143, 23);
		val42.Alignment = (StringAlignment)0;
		val42.FormatFlags = (StringFormatFlags)20485;
		val42.HotkeyPrefix = (HotkeyPrefix)0;
		val42.LineAlignment = (StringAlignment)1;
		val42.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_ah).StringFormat = val42;
		((Control)this.m_ah).TabIndex = 14;
		((Control)this.m_af).AutoSize = true;
		((Control)this.m_af).Location = new Point(726, 258);
		((Control)this.m_af).Name = "label6";
		((Control)this.m_af).Size = new Size(76, 16);
		((Control)this.m_af).TabIndex = 87;
		((Control)this.m_af).Text = "دین / مذهب";
		((EditBase)this.m_ae).AutoScroll = false;
		((EditBase)this.m_ae).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_ae).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_ae).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_ae).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_ae).Location = new Point(346, 215);
		((EditBase)this.m_ae).MaxLength = 9;
		((Control)this.m_ae).Name = "txtNumberAsas";
		this.m_ae.Numeric = true;
		((Control)this.m_ae).RightToLeft = (RightToLeft)1;
		((Control)this.m_ae).Size = new Size(143, 23);
		((Control)this.m_ae).TabIndex = 12;
		((Control)this.m_ae).Tag = "";
		((EditBase)this.m_ae).TextAlignment = (TextAlignment)1;
		((Control)this.m_ae).Leave += z;
		((Control)this.m_ae).Enter += y;
		val43.FormatStyle.Alpha = 0;
		val43.Text = "";
		val43.Value = "-1";
		val44.FormatStyle.Alpha = 0;
		val44.Text = "مرد";
		val44.Value = "1";
		val45.FormatStyle.Alpha = 0;
		val45.Text = "زن";
		val45.Value = "0";
		this.m_y.Items.AddRange(new UIComboBoxItem[3] { val43, val44, val45 });
		((Control)this.m_y).Location = new Point(174, 215);
		((Control)this.m_y).Name = "dropJens";
		((Control)this.m_y).Size = new Size(81, 23);
		val46.Alignment = (StringAlignment)0;
		val46.FormatFlags = (StringFormatFlags)20485;
		val46.HotkeyPrefix = (HotkeyPrefix)0;
		val46.LineAlignment = (StringAlignment)1;
		val46.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_y).StringFormat = val46;
		((Control)this.m_y).TabIndex = 13;
		this.m_y.SelectedIndexChanged += aq;
		((Control)this.m_z).AutoSize = true;
		((Control)this.m_z).Location = new Point(258, 219);
		((Control)this.m_z).Name = "label5";
		((Control)this.m_z).Size = new Size(53, 16);
		((Control)this.m_z).TabIndex = 83;
		((Control)this.m_z).Text = "جنیست";
		((EditBase)this.m_aa).AutoScroll = false;
		((EditBase)this.m_aa).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_aa).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_aa).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_aa).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_aa).Location = new Point(7, 291);
		((EditBase)this.m_aa).MaxLength = 200;
		((Control)this.m_aa).Name = "txtSh_sh";
		((Control)this.m_aa).RightToLeft = (RightToLeft)1;
		((Control)this.m_aa).Size = new Size(479, 23);
		((Control)this.m_aa).TabIndex = 17;
		((Control)this.m_aa).Tag = "";
		((EditBase)this.m_aa).TextAlignment = (TextAlignment)1;
		((Control)this.m_aa).Leave += ab;
		((Control)this.m_aa).Enter += aa;
		((Control)this.m_ab).AutoSize = true;
		((Control)this.m_ab).Location = new Point(488, 295);
		((Control)this.m_ab).Name = "label4";
		((Control)this.m_ab).Size = new Size(58, 16);
		((Control)this.m_ab).TabIndex = 81;
		((Control)this.m_ab).Text = "نمبرتذکره";
		((Control)this.m_ac).AutoSize = true;
		((Control)this.m_ac).Location = new Point(502, 181);
		((Control)this.m_ac).Name = "label2";
		((Control)this.m_ac).Size = new Size(54, 16);
		((Control)this.m_ac).TabIndex = 80;
		((Control)this.m_ac).Text = "تلفن پدر";
		((EditBase)this.m_ad).AutoScroll = false;
		((EditBase)this.m_ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_ad).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_ad).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_ad).Location = new Point(579, 174);
		((EditBase)this.m_ad).MaxLength = 12;
		((Control)this.m_ad).Name = "txtNumberTelegram";
		this.m_ad.Numeric = true;
		((Control)this.m_ad).RightToLeft = (RightToLeft)1;
		((Control)this.m_ad).Size = new Size(140, 23);
		((Control)this.m_ad).TabIndex = 8;
		((Control)this.m_ad).Tag = "";
		((EditBase)this.m_ad).TextAlignment = (TextAlignment)1;
		((Control)this.m_ad).Leave += ah;
		((Control)this.m_ad).Enter += ag;
		((Control)this.m_n).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_n).Location = new Point(20, 149);
		((Control)this.m_n).Name = "btnDeletePic";
		((Control)this.m_n).Size = new Size(75, 23);
		((Control)this.m_n).TabIndex = 21;
		((Control)this.m_n).Text = "حذف عکس";
		((Control)this.m_n).Click += at;
		((Control)this.m_j).AutoSize = true;
		((Control)this.m_j).Location = new Point(261, 181);
		((Control)this.m_j).Name = "label15";
		((Control)this.m_j).Size = new Size(60, 16);
		((Control)this.m_j).TabIndex = 78;
		((Control)this.m_j).Text = "تلفن مادر";
		((Control)this.m_o).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_o).Location = new Point(20, 121);
		((Control)this.m_o).Name = "btnPic";
		((Control)this.m_o).Size = new Size(75, 23);
		((Control)this.m_o).TabIndex = 20;
		((Control)this.m_o).Text = "انتخاب عکس";
		((Control)this.m_o).Click += au;
		this.m_p.BorderStyle = (BorderStyle)2;
		((Control)this.m_p).Location = new Point(3, 2);
		((Control)this.m_p).Name = "pictureBox1";
		((Control)this.m_p).Size = new Size(96, 115);
		this.m_p.SizeMode = (PictureBoxSizeMode)1;
		this.m_p.TabIndex = 70;
		this.m_p.TabStop = false;
		((Control)this.m_p).Tag = "";
		((Control)this.m_k).AutoSize = true;
		((Control)this.m_k).Location = new Point(724, 177);
		((Control)this.m_k).Name = "label14";
		((Control)this.m_k).Size = new Size(62, 16);
		((Control)this.m_k).TabIndex = 77;
		((Control)this.m_k).Text = "نمبرتلگرام";
		((EditBase)this.m_l).AutoScroll = false;
		((EditBase)this.m_l).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_l).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_l).Location = new Point(346, 177);
		((EditBase)this.m_l).MaxLength = 11;
		((Control)this.m_l).Name = "txtMobileFather";
		this.m_l.Numeric = true;
		((Control)this.m_l).RightToLeft = (RightToLeft)1;
		((Control)this.m_l).Size = new Size(143, 23);
		((Control)this.m_l).TabIndex = 9;
		((Control)this.m_l).Tag = "";
		((EditBase)this.m_l).TextAlignment = (TextAlignment)1;
		((Control)this.m_l).Leave += af;
		((Control)this.m_l).Enter += ae;
		((EditBase)this.m_m).AutoScroll = false;
		((EditBase)this.m_m).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_m).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_m).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_m).Location = new Point(112, 177);
		((EditBase)this.m_m).MaxLength = 11;
		((Control)this.m_m).Name = "txtMobileMother";
		this.m_m.Numeric = true;
		((Control)this.m_m).RightToLeft = (RightToLeft)1;
		((Control)this.m_m).Size = new Size(143, 23);
		((Control)this.m_m).TabIndex = 10;
		((Control)this.m_m).Tag = "";
		((EditBase)this.m_m).TextAlignment = (TextAlignment)1;
		((Control)this.m_m).Leave += ad;
		((Control)this.m_m).Enter += ac;
		((EditBase)this.m_q).AutoScroll = false;
		((EditBase)this.m_q).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_q).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_q).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_q).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_q).Location = new Point(577, 215);
		((EditBase)this.m_q).MaxLength = 12;
		((Control)this.m_q).Name = "txtCode";
		this.m_q.Numeric = true;
		((Control)this.m_q).RightToLeft = (RightToLeft)1;
		((Control)this.m_q).Size = new Size(143, 23);
		((Control)this.m_q).TabIndex = 11;
		((Control)this.m_q).Tag = "";
		((EditBase)this.m_q).TextAlignment = (TextAlignment)1;
		((Control)this.m_q).Leave += u;
		((Control)this.m_q).Enter += t;
		((Control)this.m_r).AutoSize = true;
		((Control)this.m_r).Location = new Point(492, 218);
		((Control)this.m_r).Name = "labl";
		((Control)this.m_r).Size = new Size(70, 16);
		((Control)this.m_r).TabIndex = 33;
		((Control)this.m_r).Text = "نمبر اساس";
		((Control)this.m_x).AutoSize = true;
		((Control)this.m_x).Location = new Point(724, 65);
		((Control)this.m_x).Name = "label1";
		((Control)this.m_x).Size = new Size(24, 16);
		((Control)this.m_x).TabIndex = 1;
		((Control)this.m_x).Text = "نام";
		((EditBase)this.m_s).AutoScroll = false;
		((EditBase)this.m_s).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_s).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_s).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_s).Location = new Point(584, 97);
		((Control)this.m_s).Name = "txtNamP";
		((Control)this.m_s).Size = new Size(135, 23);
		((Control)this.m_s).TabIndex = 3;
		((EditBase)this.m_s).TextAlignment = (TextAlignment)1;
		((Control)this.m_s).Leave += aj;
		((Control)this.m_s).Enter += ai;
		((EditBase)this.m_w).AutoScroll = false;
		((EditBase)this.m_w).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_w).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_w).Location = new Point(584, 62);
		((Control)this.m_w).Name = "txtNamF";
		((Control)this.m_w).Size = new Size(135, 23);
		((Control)this.m_w).TabIndex = 0;
		((EditBase)this.m_w).TextAlignment = (TextAlignment)1;
		((Control)this.m_w).Leave += an;
		((Control)this.m_w).Enter += am;
		((Control)this.m_t).AutoSize = true;
		((Control)this.m_t).Location = new Point(724, 100);
		((Control)this.m_t).Name = "label8";
		((Control)this.m_t).Size = new Size(40, 16);
		((Control)this.m_t).TabIndex = 20;
		((Control)this.m_t).Text = "ولدیت";
		((Control)this.m_v).AutoSize = true;
		((Control)this.m_v).Location = new Point(261, 65);
		((Control)this.m_v).Name = "label7";
		((Control)this.m_v).Size = new Size(58, 16);
		((Control)this.m_v).TabIndex = 18;
		((Control)this.m_v).Text = "ولد / بنت";
		((EditBase)this.m_u).AutoScroll = false;
		((EditBase)this.m_u).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_u).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_u).Location = new Point(112, 62);
		((Control)this.m_u).Name = "txtNamL";
		((Control)this.m_u).Size = new Size(143, 23);
		((Control)this.m_u).TabIndex = 2;
		((EditBase)this.m_u).TextAlignment = (TextAlignment)1;
		((Control)this.m_u).Leave += al;
		((Control)this.m_u).Enter += ak;
		((Control)this.m_i).BackColor = Color.Black;
		((Control)this.m_i).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_i).Dock = (DockStyle)5;
		((Control)this.m_i).Location = new Point(0, 0);
		((Control)this.m_i).Name = "panel2";
		((Control)this.m_i).Size = new Size(831, 700);
		((Control)this.m_i).TabIndex = 35;
		((FileDialog)this.m_ak).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_ak).Title = "انتخاب عکس شاگرد";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.LightSteelBlue;
		((Form)this).ClientSize = new Size(831, 700);
		((Control)this).Controls.Add((Control)(object)this.m_i);
		((Control)this).Font = new Font("Tahoma", 8.25f);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSabtenam";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نام ";
		((Form)this).Load += aw;
		((Control)this).KeyUp += a;
		((Control)this).KeyDown += v;
		((Control)this.m_h).ResumeLayout(false);
		((Control)this.m_h).PerformLayout();
		((Control)co).ResumeLayout(false);
		((Control)ci).ResumeLayout(false);
		((Control)ci).PerformLayout();
		((ISupportInitialize)bp).EndInit();
		((Control)bp).ResumeLayout(false);
		((Control)bp).PerformLayout();
		((ISupportInitialize)a9).EndInit();
		((Control)a9).ResumeLayout(false);
		((Control)a9).PerformLayout();
		((ISupportInitialize)this.m_p).EndInit();
		((Control)this.m_i).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
