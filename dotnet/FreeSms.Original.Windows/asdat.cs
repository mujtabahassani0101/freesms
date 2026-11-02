using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
	public string __field_a = "0";

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
					this.__field_a = ce.SelectedValue.ToString();
					ch.SelectedIndex = 0;
					ci.Visible = true;
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
					az.Text = ShamsiDate.GetShamsiDate(DateTime.Now);
					this.m_ai.SelectedIndex = 0;
					h();
					m();
					cp.Text = asdaj.j;
					cq.Visible = true;
					co.Visible = true;
					cn.Visible = true;
					h();
					num = 2;
					continue;
				case 2:
					return;
				case 6:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 0;
					continue;
				case 0:
					return;
				case 8:
					flag = !(this.__field_a == "0");
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
					cb.Text = asdaj.__field_a;
					k();
					l();
					o();
					n();
					p();
					this.m_ah.SelectedIndex = 0;
					ck.SelectedIndex = 0;
					cs.SelectedIndex = 0;
					this.m_y.SelectedIndex = 0;
					flag = ce.Items.Count <= 0;
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
						this.m_h.BackColor = Color.FromArgb(red, green, blue);
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
					cd.Enabled = true;
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
					this.m_av.Enabled = true;
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
					this.m_as.Enabled = false;
					num2 = 156;
					continue;
				case 139:
					a0.Enabled = true;
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
					this.m_am.Enabled = false;
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
					this.m_at.Enabled = false;
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
					cy.Enabled = false;
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
					this.m_av.Enabled = false;
					num2 = 209;
					continue;
				case 142:
					this.m_ao.Enabled = false;
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
					this.m_ar.Enabled = false;
					num2 = 47;
					continue;
				case 147:
					this.m_s.Enabled = true;
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
					this.m_o.Enabled = false;
					this.m_n.Enabled = false;
					num2 = 44;
					continue;
				case 103:
					c3.Enabled = false;
					num2 = 56;
					continue;
				case 10:
					this.m_as.Enabled = true;
					num2 = 66;
					continue;
				case 11:
					a0.Enabled = false;
					num2 = 52;
					continue;
				case 80:
					ck.Enabled = true;
					num2 = 106;
					continue;
				case 22:
					this.m_ai.Enabled = false;
					num2 = 176;
					continue;
				case 1:
					this.m_ad.Enabled = false;
					num2 = 182;
					continue;
				case 208:
					cw.Enabled = true;
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
					this.m_aq.Enabled = true;
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
					ax.Enabled = true;
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
					c3.Enabled = true;
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
					ck.Enabled = false;
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
					this.m_ah.Enabled = false;
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
					c2.Enabled = false;
					num2 = 178;
					continue;
				case 64:
					this.m_l.Enabled = true;
					num2 = 87;
					continue;
				case 179:
					c0.Enabled = true;
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
					c0.Enabled = false;
					num2 = 32;
					continue;
				case 199:
					this.m_ae.Enabled = true;
					num2 = 157;
					continue;
				case 216:
					this.m_au.Enabled = true;
					num2 = 16;
					continue;
				case 27:
					c8.Enabled = true;
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
					this.m_l.Enabled = false;
					num2 = 39;
					continue;
				case 23:
					this.m_y.Enabled = false;
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
					this.m_am.Enabled = true;
					num2 = 37;
					continue;
				case 126:
					this.m_q.Enabled = true;
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
					this.m_ad.Enabled = true;
					num2 = 2;
					continue;
				case 144:
					this.m_ar.Enabled = true;
					num2 = 188;
					continue;
				case 40:
					this.m_s.Enabled = false;
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
					this.m_aa.Enabled = true;
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
					c6.Enabled = false;
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
					az.Enabled = false;
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
					az.Enabled = true;
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
					this.m_m.Enabled = true;
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
					this.m_aw.Enabled = false;
					num2 = 45;
					continue;
				case 158:
					ct.Enabled = false;
					num2 = 115;
					continue;
				case 122:
					this.m_at.Enabled = true;
					num2 = 155;
					continue;
				case 162:
					this.m_ah.Enabled = true;
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
					this.m_y.Enabled = true;
					num2 = 206;
					continue;
				case 206:
					if (1 == 0)
					{
					}
					goto case 2;
				case 152:
					this.m_ap.Enabled = true;
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
					c2.Enabled = true;
					num2 = 124;
					continue;
				case 36:
					this.m_m.Enabled = false;
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
					this.m_ao.Enabled = true;
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
					cd.Enabled = false;
					num2 = 189;
					continue;
				case 138:
					this.m_aw.Enabled = true;
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
					c5.Enabled = false;
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
					this.m_aa.Enabled = false;
					num2 = 134;
					continue;
				case 90:
					this.m_ae.Enabled = false;
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
					this.m_ai.Enabled = true;
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
					c6.Enabled = true;
					num2 = 150;
					continue;
				case 51:
					this.m_ap.Enabled = false;
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
					this.m_au.Enabled = false;
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
					c5.Enabled = true;
					num2 = 79;
					continue;
				case 21:
					cy.Enabled = true;
					num2 = 31;
					continue;
				case 71:
					this.m_aq.Enabled = false;
					num2 = 175;
					continue;
				case 217:
					ax.Enabled = false;
					num2 = 25;
					continue;
				case 95:
					ct.Enabled = true;
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
					c8.Enabled = false;
					num2 = 132;
					continue;
				case 15:
					cw.Enabled = false;
					num2 = 194;
					continue;
				case 3:
					this.m_o.Enabled = true;
					this.m_n.Enabled = true;
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
					this.m_q.Enabled = false;
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
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + cb.Text + " and xPaye in(" + asdaj.n + ") and xPaye=" + a4.SelectedValue.ToString() + " order by xpaye,sortRpt");
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
					this.m_d.Text = "";
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
		Close();
	}

	private void au(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_ak.ShowDialog() != DialogResult.OK;
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
							FileInfo fileInfo = new FileInfo(this.m_ak.FileName);
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
									this.m_p.Image = Image.FromFile(this.m_ak.FileName);
									this.m_b = this.m_ak.FileName;
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
		while (true)
		{
			bool flag = DialogResult.Yes != MessageBox.Show("آیا از حذف عکس شاگرد اطمینان دارید", "حذف عکس شاگرد ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
					asdcb.d(asdab.e(), CommandType.Text, "delete from tStudentImg where xStudent=" + this.__field_a);
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

	private async void @as(object A_0, EventArgs A_1)
	{
		object value7 = default;
		object value21 = default;
		object value14 = default;
		object value16 = default;
		DataTable dataTable = default;
		int num5 = default;
		object value20 = default;
		string text = default;
		int num3 = default;
		object value19 = default;
		object value13 = default;
		object value12 = default;
		object value5 = default;
		object value6 = default;
		object value2 = default;
		string a_ = default;
		object value = default;
		object value17 = default;
		string a_4 = default;
		SqlParameter[] array = default;
		object value23 = default;
		object value15 = default;
		object value11 = default;
		string a_2 = default;
		object value22 = default;
		object value18 = default;
		object value8 = default;
		object value10 = default;
		object value9 = default;
		object value3 = default;
		object value4 = default;
		while (true)
		{
			bool flag = !(this.m_w.Text.Trim() == "");
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
					flag = !(this.m_u.Text.Trim() == "");
					num = 118;
					continue;
				case 6:
					value7 = this.m_q.Text;
					flag = !(this.m_q.Text.Trim() == "");
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
					value21 = DBNull.Value;
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
					value14 = a7.Text;
					flag = !(a7.Text.Trim() == "");
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
					value16 = DBNull.Value;
					num = 15;
					continue;
				case 124:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT DISTINCT Xtest FROM tMark WHERE(xStudent = " + this.__field_a + ") AND (xbook IN  (SELECT     id  FROM         tBook   WHERE     (xPaye = " + a4.Tag.ToString() + " ))) AND (Xtest IN (SELECT id FROM texam WHERE     xyear = " + cb.Text + "))");
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
					value20 = DBNull.Value;
					num = 42;
					continue;
				case 10:
					MessageBox.Show("نام را وارد کنید");
					this.m_w.Focus();
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
							string text3 = az.Text;
							DateTime date = ShamsiDate.ShamsiToGregory(text3);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
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
									az.Focus();
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
						az.Focus();
						return;
					}
					num = 25;
					continue;
				case 37:
					flag = DialogResult.Yes == MessageBox.Show("با اصلاح پایه شاگرد نمرات قبلی شاگرد در این سال حذف میشود\nآیا مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
					flag = ce.Items.Count != 0;
					num = 76;
					continue;
				case 76:
					if (flag)
					{
						flag = !cg.Enabled;
						num = 71;
					}
					else
					{
						num = 1;
					}
					continue;
				case 103:
					value19 = DBNull.Value;
					num = 51;
					continue;
				case 104:
					value13 = b6.Text;
					flag = !(b6.Text.Trim() == "");
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
					value13 = DBNull.Value;
					num = 66;
					continue;
				case 148:
					value12 = DBNull.Value;
					num = 110;
					continue;
				case 2:
                    // Applied atomically by OriginalStudentSave after successful validation.
                    // Applied atomically by OriginalStudentSave after successful validation.
                    // Applied atomically by OriginalStudentSave after successful validation.
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
					this.m_ae.SelectAll();
					this.m_ae.Focus();
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
					value5 = DBNull.Value;
					num = 3;
					continue;
				case 13:
					num = (flag ? 75 : 65);
					continue;
				case 116:
					value6 = bz.Text;
					flag = !(bz.Text.Trim() == "");
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
					value2 = DBNull.Value;
					num = 41;
					continue;
				case 38:
					a_ = ct.SelectedValue.ToString();
					num = 34;
					continue;
				case 83:
					value = DBNull.Value;
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
					this.m_u.Focus();
					num = 55;
					continue;
				case 55:
					return;
				case 92:
					flag = MessageBox.Show("اطلاعات اصلاح شد . آیا مایل هستید نفر بعدی نمایش داده شود", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
					num = 96;
					continue;
				case 96:
					if (!flag)
					{
						num = 86;
						continue;
					}
					a4.Tag = a4.SelectedValue;
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
					a4.Focus();
					num = 107;
					continue;
				case 107:
					return;
				case 64:
					value19 = c5.Text;
					flag = !(c5.Text.Trim() == "");
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
					value17 = DBNull.Value;
					num = 43;
					continue;
				case 115:
					text += ",";
					num = 69;
					continue;
				case 139:
					a_4 = "";
					flag = !(this.__field_a != "0");
					num = 0;
					continue;
				case 0:
					if (flag)
					{
						a_4 = array[0].Value.ToString();
						num = 109;
					}
					else
					{
						num = 50;
					}
					continue;
				case 67:
					a_ = "0";
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
					a_4 = this.__field_a;
					num = 89;
					continue;
				case 35:
					asdaj.h = true;
					flag = !(this.__field_a != "0");
					num = 73;
					continue;
				case 73:
					if (!flag)
					{
						num = 28;
						continue;
					}
					asdaj.j = this.m_w.Text + " " + this.m_u.Text;
					cp.Text = asdaj.j;
					MessageBox.Show("ثبت شد");
					i();
					this.m_w.Focus();
					num = 74;
					continue;
				case 31:
					value23 = DBNull.Value;
					num = 17;
					continue;
				case 7:
					value15 = b1.Text;
					flag = !(b1.Text.Trim() == "");
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
					value11 = DBNull.Value;
					num = 93;
					continue;
				case 112:
					try
					{
						long num4 = long.Parse(this.m_q.Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای کد متعلم فقط عدد وارد کنید");
						this.m_q.Focus();
						return;
					}
					num = 82;
					continue;
				case 34:
					a_2 = "0";
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
					value16 = bh.Text;
					flag = !(bh.Text.Trim() == "");
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
					value22 = b5.Text;
					flag = !(b5.Text.Trim() == "");
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
					value18 = DBNull.Value;
					num = 144;
					continue;
				case 32:
					value22 = DBNull.Value;
					num = 80;
					continue;
				case 93:
					value21 = bc.Text;
					flag = !(bc.Text.Trim() == "");
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
					value6 = DBNull.Value;
					num = 126;
					continue;
				case 144:
					value20 = b0.Text;
					flag = !(b0.Text.Trim() == "");
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
					value12 = bg.Text;
					flag = !(bg.Text.Trim() == "");
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
						asdcb.a("@id", SqlDbType.Int, this.__field_a),
						asdcb.a("@xYear", SqlDbType.Int, cb.Text),
						asdcb.a("@xpaye", SqlDbType.Int, a4.SelectedValue.ToString()),
						asdcb.a("@xClass", SqlDbType.Int, this.m_d.SelectedValue.ToString()),
						asdcb.a("@Code", SqlDbType.BigInt, value7),
						asdcb.a("@FName", SqlDbType.NVarChar, asdaj.b(this.m_w.Text)),
						asdcb.a("@LName", SqlDbType.NVarChar, asdaj.b(this.m_u.Text)),
						asdcb.a("@PName", SqlDbType.NVarChar, asdaj.b(this.m_s.Text)),
						asdcb.a("@Sh_Sh", SqlDbType.NVarChar, asdaj.b(this.m_aa.Text)),
						asdcb.a("@bDate", SqlDbType.NVarChar, asdaj.b(cd.Text)),
						asdcb.a("@bDateM", SqlDbType.NVarChar, asdaj.b(c8.Text)),
						asdcb.a("@MobileFather", SqlDbType.NVarChar, asdaj.b(this.m_l.Text)),
						asdcb.a("@MobileMother", SqlDbType.NVarChar, asdaj.b(this.m_m.Text)),
						asdcb.a("@NumberTelegram", SqlDbType.NVarChar, asdaj.b(this.m_ad.Text)),
						asdcb.a("@NumberTelegram2", SqlDbType.NVarChar, DBNull.Value),
						asdcb.a("@Jens", SqlDbType.SmallInt, this.m_y.SelectedValue.ToString()),
						asdcb.a("@Mazhab", SqlDbType.SmallInt, this.m_ah.SelectedValue.ToString()),
						asdcb.a("@NumberAsas", SqlDbType.Int, value8),
						asdcb.a("@RegDate", SqlDbType.NVarChar, asdaj.b(az.Text)),
						asdcb.a("@Adress", SqlDbType.NVarChar, asdaj.b(this.m_am.Text)),
						asdcb.a("@ExitDate", SqlDbType.NVarChar, asdaj.b(a0.Text)),
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
						asdcb.a("@Fee1", SqlDbType.Int, value2),
						asdcb.a("@Fee2", SqlDbType.Int, value),
						asdcb.a("@Fee3", SqlDbType.Int, value15),
						asdcb.a("@Fee4", SqlDbType.Int, value13),
						asdcb.a("@Fee5", SqlDbType.Int, value18),
						asdcb.a("@Fee6", SqlDbType.Int, value20),
						asdcb.a("@Fee7", SqlDbType.Int, value22),
						asdcb.a("@Fee8", SqlDbType.Int, value10),
						asdcb.a("@Fee9", SqlDbType.Int, value6),
						asdcb.a("@SumFee", SqlDbType.Int, value5),
						asdcb.a("@xTakhfif", SqlDbType.Int, ck.SelectedValue),
						asdcb.a("@transport1", SqlDbType.Int, value9),
						asdcb.a("@transport2", SqlDbType.Int, value11),
						asdcb.a("@transport3", SqlDbType.Int, value21),
						asdcb.a("@transport4", SqlDbType.Int, value16),
						asdcb.a("@transport5", SqlDbType.Int, value23),
						asdcb.a("@transport6", SqlDbType.Int, value17),
						asdcb.a("@transport7", SqlDbType.Int, value12),
						asdcb.a("@transport8", SqlDbType.Int, value3),
						asdcb.a("@transport9", SqlDbType.Int, value4),
						asdcb.a("@Sumtransport", SqlDbType.Int, value14),
						asdcb.a("@xDriver", SqlDbType.Int, cs.SelectedValue.ToString()),
						asdcb.a("@xcity", SqlDbType.Int, a_),
						asdcb.a("@En_Fname", SqlDbType.NVarChar, asdaj.b(cy.Text)),
						asdcb.a("@En_Lname", SqlDbType.NVarChar, asdaj.b(cw.Text)),
						asdcb.a("@LastName", SqlDbType.NVarChar, asdaj.b(c0.Text)),
						asdcb.a("@En_LastName", SqlDbType.NVarChar, asdaj.b(c2.Text)),
						asdcb.a("@xCityNow", SqlDbType.Int, a_2),
						asdcb.a("@codeTakhfif", SqlDbType.Int, value19)
					};
                    string photoPath=this.m_b;Exception saveError=null;
                    Enabled=false;UseWaitCursor=true;
                    try{num5=await System.Threading.Tasks.Task.Run(()=>OriginalStudentSave.Save(array,photoPath));}
                    catch(Exception error) when(error is FreeSms.Core.ValidationException || error is System.IO.IOException || error is UnauthorizedAccessException || error is SqlException || error is AggregateException)
                    {saveError=error;}
                    finally{if(!IsDisposed){Enabled=true;UseWaitCursor=false;}}
                    if(IsDisposed)return;
                    if(saveError!=null){MessageBox.Show("ثبت معلومات شاگرد انجام نشد:\n"+saveError.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);return;}
                    if(num5>0)this.m_b="";
					flag = !(array[0].Value.ToString() == "-100");
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						flag = !(array[0].Value.ToString() == "-200");
						num = 12;
					}
					else
					{
						num = 88;
					}
					continue;
				case 15:
					value23 = be.Text;
					flag = !(be.Text.Trim() == "");
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
							flag = !(cd.Text != "");
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
									string text2 = cd.Text;
									DateTime date = ShamsiDate.ShamsiToGregory(text2);
									string shamsiDate = ShamsiDate.GetShamsiDate(date);
									flag = !(shamsiDate != text2);
									num = 3;
									continue;
								}
								case 3:
									num = ((!flag) ? 2 : 4);
									continue;
								case 2:
									MessageBox.Show("تاریخ تولد اشتباه است");
									cd.Focus();
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
						cd.Focus();
						return;
					}
					flag = !(this.__field_a != "0");
					num = 68;
					continue;
				case 65:
					num = 90;
					continue;
				case 101:
					value15 = DBNull.Value;
					num = 104;
					continue;
				case 128:
					value7 = DBNull.Value;
					num = 87;
					continue;
				case 117:
					value14 = DBNull.Value;
					num = 6;
					continue;
				case 105:
					value4 = ba.Text;
					flag = !(ba.Text.Trim() == "");
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
					value = b4.Text;
					flag = !(b4.Text.Trim() == "");
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
					value11 = bf.Text;
					flag = !(bf.Text.Trim() == "");
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
					this.m_q.SelectAll();
					this.m_q.Focus();
					num = 36;
					continue;
				case 36:
					return;
				case 118:
					if (flag)
					{
						flag = !(this.m_ae.Text.Trim() == "");
						num = 13;
					}
					else
					{
						num = 59;
					}
					continue;
				case 110:
					value3 = bd.Text;
					flag = !(bd.Text.Trim() == "");
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
					value5 = a5.Text;
					flag = !(a5.Text.Trim() == "");
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
					value10 = DBNull.Value;
					num = 116;
					continue;
				case 134:
					value2 = b7.Text;
					flag = !(b7.Text.Trim() == "");
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
					value9 = DBNull.Value;
					num = 123;
					continue;
				case 46:
					MessageBox.Show("صنف را مشخص کنید");
					this.m_d.Focus();
					num = 125;
					continue;
				case 125:
					return;
				case 86:
					r((object)this, (EventArgs)null);
					num = 100;
					continue;
				case 14:
					value8 = DBNull.Value;
					num = 67;
					continue;
				case 87:
					value8 = this.m_ae.Text;
					flag = !(this.m_ae.Text.Trim() == "");
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
					value17 = bb.Text;
					flag = !(bb.Text.Trim() == "");
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
					SqlParameter[] a_3 = new SqlParameter[2]
					{
						asdcb.a("@id", SqlDbType.BigInt, a_4),
						asdcb.a("@img", SqlDbType.Image, asdab.b(this.m_b))
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tStudentImg_InsertUpdate", a_3);
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
					value18 = b3.Text;
					flag = !(b3.Text.Trim() == "");
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
                    // A single-student editor has no next/previous list. Confirm
                    // the committed edit before closing, just as the list editor does.
                    MessageBox.Show("اطلاعات اصلاح شد");
					Close();
					num = 102;
					continue;
				case 4:
					value4 = DBNull.Value;
					num = 58;
					continue;
				case 27:
				case 54:
					f();
					num = 119;
					continue;
				case 81:
					value3 = DBNull.Value;
					num = 105;
					continue;
				case 3:
					value9 = bi.Text;
					flag = !(bi.Text.Trim() == "");
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
					a_2 = c6.SelectedValue.ToString();
					num = 64;
					continue;
				case 75:
					try
					{
						int num2 = int.Parse(this.m_ae.Text.Trim());
					}
					catch
					{
						MessageBox.Show("برای نبر اساس فقط عدد وارد کنید");
						this.m_ae.Focus();
						return;
					}
					num = 85;
					continue;
				case 44:
					num = 29;
					continue;
				case 80:
					value10 = b2.Text;
					flag = !(b2.Text.Trim() == "");
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
					flag = !(a4.SelectedValue.ToString() != a4.Tag.ToString());
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
					flag = !(this.m_q.Text.Trim() == "");
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
				asdcb.a("@xYear", SqlDbType.Int, cb.Text),
				asdcb.a("@xStudent", SqlDbType.Int, this.__field_a)
			};
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Sh_Sh, tStudent.bDate, tStudent.bDateM,tStudent.MobileFather, tStudent.MobileMother,\r\n                        tStudent.xCity, tStudent.En_Fname, tStudent.En_Lname,  tStudent.LastName, tStudent.En_LastName,\r\n                      tStudent.NumberTelegram, tStudent.NumberTelegram2, tStudent.Jens, tStudent.Mazhab, tStudent.NumberAsas, tStudent.RegDate, tStudent.Adress,tStudent.xCityNow,tYear_Student.codeTakhfif, \r\n                      tStudent.ExitDate, tYear_Student.xPaye, tYear_Student.xClass, tYear_Student.Status, tYear_Student.shaghe, tYear_Student.hazer, tYear_Student.mali,tYear_Student.MarkTerm3_From100 ,\r\n                      tYear_Student.dakhle, tYear_Student.uniform, tYear_Student.komakdarsi, tYear_Student.ketab, tYear_Student.transport, tYear_Student.robotic, \r\n                      tYear_Student.maghnae, tYear_Student.Sumtransport, tYear_Student.transport1, tYear_Student.transport2, tYear_Student.transport3, \r\n                      tYear_Student.transport4, tYear_Student.transport5, tYear_Student.transport6, tYear_Student.transport7, tYear_Student.transport8, \r\n                      tYear_Student.transport9, tYear_Student.fee1, tYear_Student.fee2, tYear_Student.fee3, tYear_Student.fee4, tYear_Student.fee5, tYear_Student.fee6, \r\n                      tYear_Student.fee7, tYear_Student.fee8, tYear_Student.fee9,tYear_Student.SumFee,tYear_Student.xTakhfif, tYear_Student.xYear, tYear_Student.xStudent,tYear_Student.xDriver\r\n                      FROM         tYear_Student INNER JOIN\r\n                      tStudent ON tYear_Student.xStudent = tStudent.id\r\n                      WHERE     (tYear_Student.xYear = @xYear) AND (tYear_Student.xStudent = @xStudent)", a_);
			a4.SelectedValue = dataTable.Rows[0]["xPaye"].ToString();
			a4.Tag = dataTable.Rows[0]["xPaye"].ToString();
			this.m_d.SelectedValue = dataTable.Rows[0]["xClass"].ToString();
			this.m_q.Text = dataTable.Rows[0]["Code"].ToString();
			this.m_w.Text = dataTable.Rows[0]["FName"].ToString();
			this.m_u.Text = dataTable.Rows[0]["LName"].ToString();
			this.m_s.Text = dataTable.Rows[0]["PName"].ToString();
			cy.Text = dataTable.Rows[0]["En_Fname"].ToString();
			cw.Text = dataTable.Rows[0]["En_Lname"].ToString();
			ct.SelectedValue = dataTable.Rows[0]["xCity"].ToString();
			c6.SelectedValue = dataTable.Rows[0]["xCityNow"].ToString();
			c5.Text = dataTable.Rows[0]["codeTakhfif"].ToString();
			c2.Text = dataTable.Rows[0]["En_LastName"].ToString();
			c0.Text = dataTable.Rows[0]["LastName"].ToString();
			this.m_aa.Text = dataTable.Rows[0]["Sh_Sh"].ToString();
			cd.Text = dataTable.Rows[0]["bDate"].ToString();
			c8.Text = dataTable.Rows[0]["bDateM"].ToString();
			this.m_l.Text = dataTable.Rows[0]["MobileFather"].ToString();
			this.m_m.Text = dataTable.Rows[0]["MobileMother"].ToString();
			this.m_ad.Text = dataTable.Rows[0]["NumberTelegram"].ToString();
			this.m_y.SelectedValue = dataTable.Rows[0]["Jens"].ToString();
			this.m_ah.SelectedValue = dataTable.Rows[0]["Mazhab"].ToString();
			ck.SelectedValue = dataTable.Rows[0]["xtakhfif"].ToString();
			cs.SelectedValue = dataTable.Rows[0]["xDriver"].ToString();
			this.m_ae.Text = dataTable.Rows[0]["NumberAsas"].ToString();
			az.Text = dataTable.Rows[0]["RegDate"].ToString();
			this.m_am.Text = dataTable.Rows[0]["Adress"].ToString();
			a0.Text = dataTable.Rows[0]["ExitDate"].ToString();
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
						this.m_p.Image = asdab.a((byte[])asdcb.a(asdab.e(), CommandType.Text, "select Student_img from tStudentImg where xStudent=" + this.__field_a));
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
					b7.Text = dataTable.Rows[0]["Fee1"].ToString();
					b4.Text = dataTable.Rows[0]["Fee2"].ToString();
					b1.Text = dataTable.Rows[0]["Fee3"].ToString();
					b6.Text = dataTable.Rows[0]["Fee4"].ToString();
					b3.Text = dataTable.Rows[0]["Fee5"].ToString();
					b0.Text = dataTable.Rows[0]["Fee6"].ToString();
					b5.Text = dataTable.Rows[0]["Fee7"].ToString();
					b2.Text = dataTable.Rows[0]["Fee8"].ToString();
					bz.Text = dataTable.Rows[0]["Fee9"].ToString();
					a5.Text = dataTable.Rows[0]["SumFee"].ToString();
					bi.Text = dataTable.Rows[0]["transport1"].ToString();
					bf.Text = dataTable.Rows[0]["transport2"].ToString();
					bc.Text = dataTable.Rows[0]["transport3"].ToString();
					bh.Text = dataTable.Rows[0]["transport4"].ToString();
					be.Text = dataTable.Rows[0]["transport5"].ToString();
					bb.Text = dataTable.Rows[0]["transport6"].ToString();
					bg.Text = dataTable.Rows[0]["transport7"].ToString();
					bd.Text = dataTable.Rows[0]["transport8"].ToString();
					ba.Text = dataTable.Rows[0]["transport9"].ToString();
					a7.Text = dataTable.Rows[0]["Sumtransport"].ToString();
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
						cm.Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_d.SelectedValue.ToString()).ToString();
					}
					catch
					{
						cm.Text = "";
						a5.Text = "";
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
			this.m_q.Text = "";
			this.m_w.Text = "";
			this.m_u.Text = "";
			this.m_s.Text = "";
			this.m_aa.Text = "";
			cd.Text = "";
			c8.Text = "";
			this.m_l.Text = "";
			this.m_m.Text = "";
			this.m_ad.Text = "";
			this.m_ae.Text = "";
			this.m_am.Text = "";
			a0.Text = "";
			c5.Text = "";
			bi.Text = "";
			bf.Text = "";
			bc.Text = "";
			bh.Text = "";
			be.Text = "";
			bb.Text = "";
			bg.Text = "";
			bd.Text = "";
			ba.Text = "";
			a7.Text = "";
			cw.Text = "";
			cy.Text = "";
			c2.Text = "";
			c0.Text = "";
			bool flag = !ct.Enabled;
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
					flag = !ck.Enabled;
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
					flag = !this.m_ah.Enabled;
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
					flag = !c6.Enabled;
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
					flag = !cs.Enabled;
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
					flag = !this.m_y.Enabled;
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
		this.m_am.BackColor = Color.White;
	}

	private void ao(object A_0, EventArgs A_1)
	{
		this.m_am.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void an(object A_0, EventArgs A_1)
	{
		this.m_w.BackColor = Color.White;
	}

	private void am(object A_0, EventArgs A_1)
	{
		this.m_w.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void al(object A_0, EventArgs A_1)
	{
		this.m_u.BackColor = Color.White;
	}

	private void ak(object A_0, EventArgs A_1)
	{
		this.m_u.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void aj(object A_0, EventArgs A_1)
	{
		this.m_s.BackColor = Color.White;
	}

	private void ai(object A_0, EventArgs A_1)
	{
		this.m_s.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void ah(object A_0, EventArgs A_1)
	{
		this.m_ad.BackColor = Color.White;
	}

	private void ag(object A_0, EventArgs A_1)
	{
		this.m_ad.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void af(object A_0, EventArgs A_1)
	{
		this.m_l.BackColor = Color.White;
	}

	private void ae(object A_0, EventArgs A_1)
	{
		this.m_l.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void ad(object A_0, EventArgs A_1)
	{
		this.m_m.BackColor = Color.White;
	}

	private void ac(object A_0, EventArgs A_1)
	{
		this.m_m.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void ab(object A_0, EventArgs A_1)
	{
		this.m_aa.BackColor = Color.White;
	}

	private void aa(object A_0, EventArgs A_1)
	{
		this.m_aa.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void z(object A_0, EventArgs A_1)
	{
		this.m_ae.BackColor = Color.White;
	}

	private void y(object A_0, EventArgs A_1)
	{
		this.m_ae.BackColor = Color.FromArgb(255, 255, 128);
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
						bf.Text = bi.Text;
						bc.Text = bi.Text;
						bh.Text = bi.Text;
						be.Text = bi.Text;
						bb.Text = bi.Text;
						bg.Text = bi.Text;
						bd.Text = bi.Text;
						ba.Text = bi.Text;
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
						bc.Text = bf.Text;
						bh.Text = bf.Text;
						be.Text = bf.Text;
						bb.Text = bf.Text;
						bg.Text = bf.Text;
						bd.Text = bf.Text;
						ba.Text = bf.Text;
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
						bh.Text = bc.Text;
						be.Text = bc.Text;
						bb.Text = bc.Text;
						bg.Text = bc.Text;
						bd.Text = bc.Text;
						ba.Text = bc.Text;
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
						be.Text = bh.Text;
						bb.Text = bh.Text;
						bg.Text = bh.Text;
						bd.Text = bh.Text;
						ba.Text = bh.Text;
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
						bb.Text = be.Text;
						bg.Text = be.Text;
						bd.Text = be.Text;
						ba.Text = be.Text;
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
						bg.Text = bb.Text;
						bd.Text = bb.Text;
						ba.Text = bb.Text;
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
						bd.Text = bg.Text;
						ba.Text = bg.Text;
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
						ba.Text = bd.Text;
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
						b4.Text = b7.Text;
						b1.Text = b7.Text;
						b6.Text = b7.Text;
						b3.Text = b7.Text;
						b0.Text = b7.Text;
						b5.Text = b7.Text;
						b2.Text = b7.Text;
						bz.Text = b7.Text;
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
						b1.Text = b4.Text;
						b6.Text = b4.Text;
						b3.Text = b4.Text;
						b0.Text = b4.Text;
						b5.Text = b4.Text;
						b2.Text = b4.Text;
						bz.Text = b4.Text;
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
						b6.Text = b1.Text;
						b3.Text = b1.Text;
						b0.Text = b1.Text;
						b5.Text = b1.Text;
						b2.Text = b1.Text;
						bz.Text = b1.Text;
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
						b3.Text = b6.Text;
						b0.Text = b6.Text;
						b5.Text = b6.Text;
						b2.Text = b6.Text;
						bz.Text = b6.Text;
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
						b0.Text = b3.Text;
						b5.Text = b3.Text;
						b2.Text = b3.Text;
						bz.Text = b3.Text;
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
						b5.Text = b0.Text;
						b2.Text = b0.Text;
						bz.Text = b0.Text;
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
						b2.Text = b5.Text;
						bz.Text = b5.Text;
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
						bz.Text = b2.Text;
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
		while (true)
		{
			MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
			maskedEditBox.BackColor = Color.White;
			DateTime date = ShamsiDate.ShamsiToGregory(az.Text);
			string shamsiDate = ShamsiDate.GetShamsiDate(date);
			bool flag = !(az.Text != shamsiDate);
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
					az.Focus();
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
			int num = int.Parse(az.Text.Substring(5, 2));
			bool flag = !(az.Text.Substring(0, 4) != cb.Text);
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
					bb.Text = "";
					b0.Text = "";
					bb.Enabled = false;
					bb.ReadOnly = true;
					b0.Enabled = false;
					b0.ReadOnly = true;
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
					be.Enabled = true;
					be.ReadOnly = false;
					b3.Enabled = true;
					b3.ReadOnly = false;
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
					bf.Enabled = true;
					bf.ReadOnly = false;
					b4.Enabled = true;
					b4.ReadOnly = false;
					num2 = 0;
					continue;
				case 15:
					bg.Text = "";
					b5.Text = "";
					bg.Enabled = false;
					bg.ReadOnly = true;
					b5.Enabled = false;
					b5.ReadOnly = true;
					num2 = 16;
					continue;
				case 30:
					bi.Text = "";
					b7.Text = "";
					bi.Enabled = false;
					bi.ReadOnly = true;
					b7.Enabled = false;
					b7.ReadOnly = true;
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
					bb.Enabled = true;
					bb.ReadOnly = false;
					b0.Enabled = true;
					b0.ReadOnly = false;
					num2 = 19;
					continue;
				case 11:
					bd.Text = "";
					b2.Text = "";
					bd.Enabled = false;
					bd.ReadOnly = true;
					b2.Enabled = false;
					b2.ReadOnly = true;
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
					bf.Text = "";
					b4.Text = "";
					bf.Enabled = false;
					bf.ReadOnly = true;
					b4.Enabled = false;
					b4.ReadOnly = true;
					num2 = 1;
					continue;
				case 13:
					bc.Text = "";
					b1.Text = "";
					bc.Enabled = false;
					bc.ReadOnly = true;
					b1.Enabled = false;
					b1.ReadOnly = true;
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
						bd.Enabled = true;
						bd.ReadOnly = false;
						b2.Enabled = true;
						b2.ReadOnly = false;
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
						bh.Enabled = true;
						bh.ReadOnly = false;
						b6.Enabled = true;
						b6.ReadOnly = false;
						num2 = 17;
					}
					else
					{
						num2 = 20;
					}
					continue;
				case 20:
					bh.Text = "";
					b6.Text = "";
					bh.Enabled = false;
					bh.ReadOnly = true;
					b6.Enabled = false;
					b6.ReadOnly = true;
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
						bc.Enabled = true;
						bc.ReadOnly = false;
						b1.Enabled = true;
						b1.ReadOnly = false;
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
						bi.Enabled = true;
						bi.ReadOnly = false;
						b7.Enabled = true;
						b7.ReadOnly = false;
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
						bg.Enabled = true;
						bg.ReadOnly = false;
						b5.Enabled = true;
						b5.ReadOnly = false;
						num2 = 12;
					}
					else
					{
						num2 = 15;
					}
					continue;
				case 6:
					be.Text = "";
					b3.Text = "";
					be.Enabled = false;
					be.ReadOnly = true;
					b3.Enabled = false;
					b3.ReadOnly = true;
					num2 = 22;
					continue;
				}
				break;
			}
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		CheckBox checkBox = (CheckBox)A_0;
		checkBox.BackColor = Color.Empty;
	}

	private void v(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		CheckBox checkBox = (CheckBox)A_0;
		checkBox.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void u(object A_0, EventArgs A_1)
	{
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromName("Window");
	}

	private void t(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void s(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.__field_a = ce.SelectedValue.ToString();
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
					cf.Enabled = true;
					num = 4;
					continue;
				case 6:
					cg.Enabled = false;
					num = 1;
					continue;
				case 1:
					return;
				case 2:
				case 4:
					flag = ce.SelectedIndex != ce.Items.Count - 1;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					cg.Enabled = true;
					num = 7;
					continue;
				case 5:
					cf.Enabled = false;
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
			bool flag = !ci.Visible;
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
					this.m_h.Controls[ch.SelectedValue.ToString()].Focus();
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
					flag = cs.Enabled;
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
					b7.Focus();
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
						this.m_ar.Focus();
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
			bool flag = !(this.__field_a == "0");
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
						cm.Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_d.SelectedValue.ToString()).ToString();
					}
					catch
					{
						cm.Text = "";
						if (ck.SelectedIndex < 1)
						{
							a5.Text = "";
						}
					}
					flag = ck.SelectedIndex >= 1;
					num = 5;
					continue;
				case 1:
					try
					{
						cm.Text = asdcb.a(asdab.e(), CommandType.Text, "select fee from tClass where id=" + this.m_d.SelectedValue.ToString()).ToString();
					}
					catch
					{
						cm.Text = "";
						a5.Text = "";
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
			bool flag = !(cm.Text == "");
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
					int num7 = int.Parse(cm.Text);
					num5 = num7;
					num2 = 9;
					flag = !b7.ReadOnly;
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
					flag = !b3.ReadOnly;
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
					flag = !b4.ReadOnly;
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
					flag = !b2.ReadOnly;
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
					flag = !b0.ReadOnly;
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
					a5.Text = (num6 - num4).ToString();
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
					flag = !b1.ReadOnly;
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
					flag = !b6.ReadOnly;
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
					flag = !b5.ReadOnly;
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
					flag = !(a7.Text == "");
					num = 6;
					continue;
				case 19:
					flag = !bg.ReadOnly;
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
					bi.Text = "";
					bf.Text = "";
					bc.Text = "";
					bh.Text = "";
					be.Text = "";
					bb.Text = "";
					bg.Text = "";
					bd.Text = "";
					ba.Text = "";
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
					flag = !bf.ReadOnly;
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
							int num3 = int.Parse(a7.Text);
							int num4 = num3 / num2;
							int num5 = num3 % num2;
							int num6 = num4 + num5;
							flag = bi.ReadOnly;
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
									flag = bc.ReadOnly;
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
									bg.Text = num4.ToString();
									num = 15;
									continue;
								case 23:
									bc.Text = num4.ToString();
									num = 20;
									continue;
								case 20:
									flag = bh.ReadOnly;
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
									bf.Text = num4.ToString();
									num = 9;
									continue;
								case 13:
									flag = bb.ReadOnly;
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
									bi.Text = num4.ToString();
									num = 12;
									continue;
								case 22:
									be.Text = num4.ToString();
									num = 13;
									continue;
								case 4:
									flag = be.ReadOnly;
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
									flag = bd.ReadOnly;
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
									bh.Text = num4.ToString();
									num = 4;
									continue;
								case 16:
									bd.Text = num4.ToString();
									num = 10;
									continue;
								case 12:
									flag = bf.ReadOnly;
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
									bb.Text = num4.ToString();
									num = 8;
									continue;
								case 8:
									flag = bg.ReadOnly;
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
									ba.Text = num6.ToString();
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
					flag = !bc.ReadOnly;
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
					flag = !bd.ReadOnly;
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
					flag = !bh.ReadOnly;
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
					flag = !be.ReadOnly;
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
					flag = !bb.ReadOnly;
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
						flag = !bi.ReadOnly;
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
				bool flag = !(bi.Text != "");
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
						flag = !(bc.Text != "");
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
							num += int.Parse(bc.Text);
						}
						catch
						{
							bc.BackColor = Color.Red;
						}
						num2 = 10;
						continue;
					case 1:
						num2 = 28;
						continue;
					case 36:
						flag = !(be.Text != "");
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
						flag = !(bh.Text != "");
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
						flag = !(bd.Text != "");
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
							num += int.Parse(bf.Text);
						}
						catch
						{
							bf.BackColor = Color.Red;
						}
						num2 = 27;
						continue;
					case 24:
						flag = !(bb.Text != "");
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
							num += int.Parse(bi.Text);
						}
						catch
						{
							bi.BackColor = Color.Red;
						}
						num2 = 5;
						continue;
					case 12:
						try
						{
							num += int.Parse(be.Text);
						}
						catch
						{
							be.BackColor = Color.Red;
						}
						num2 = 24;
						continue;
					case 15:
						try
						{
							num += int.Parse(bd.Text);
						}
						catch
						{
							bd.BackColor = Color.Red;
						}
						num2 = 8;
						continue;
					case 22:
						num2 = 12;
						continue;
					case 11:
						try
						{
							num += int.Parse(ba.Text);
						}
						catch
						{
							ba.BackColor = Color.Red;
						}
						num2 = 14;
						continue;
					case 5:
						flag = !(bf.Text != "");
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
						flag = !(ba.Text != "");
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
							num += int.Parse(bh.Text);
						}
						catch
						{
							bh.BackColor = Color.Red;
						}
						num2 = 36;
						continue;
					case 9:
						try
						{
							num += int.Parse(bb.Text);
						}
						catch
						{
							bb.BackColor = Color.Red;
						}
						num2 = 26;
						continue;
					case 34:
						try
						{
							num += int.Parse(bg.Text);
						}
						catch
						{
							bg.BackColor = Color.Red;
						}
						num2 = 18;
						continue;
					case 26:
						flag = !(bg.Text != "");
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
						a7.Text = num.ToString();
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
			a7.Text = "";
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
			bool flag = !(a5.Text == "");
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
					flag = !b7.ReadOnly;
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
					flag = !b4.ReadOnly;
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
					flag = !b5.ReadOnly;
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
					flag = !b3.ReadOnly;
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
							int num3 = int.Parse(a5.Text);
							int num4 = num3 / num2;
							int num5 = num3 % num2;
							int num6 = num4 + num5;
							flag = b7.ReadOnly;
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
									flag = b0.ReadOnly;
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
									b1.Text = num4.ToString();
									num = 1;
									continue;
								case 18:
									b4.Text = num4.ToString();
									num = 15;
									continue;
								case 10:
									b5.Text = num4.ToString();
									num = 20;
									continue;
								case 1:
									flag = b6.ReadOnly;
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
									flag = b1.ReadOnly;
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
									b6.Text = num4.ToString();
									num = 2;
									continue;
								case 19:
									b0.Text = num4.ToString();
									num = 5;
									continue;
								case 23:
									b7.Text = num4.ToString();
									num = 13;
									continue;
								case 6:
									b3.Text = num4.ToString();
									num = 7;
									continue;
								case 2:
									flag = b3.ReadOnly;
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
									flag = b2.ReadOnly;
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
									flag = b5.ReadOnly;
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
									b2.Text = num4.ToString();
									num = 21;
									continue;
								case 13:
									flag = b4.ReadOnly;
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
									bz.Text = num6.ToString();
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
					flag = !b6.ReadOnly;
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
					b7.Text = "";
					b4.Text = "";
					b1.Text = "";
					b6.Text = "";
					b3.Text = "";
					b0.Text = "";
					b5.Text = "";
					b2.Text = "";
					bz.Text = "";
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					flag = !b1.ReadOnly;
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
					flag = !b2.ReadOnly;
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
					flag = !b0.ReadOnly;
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
				bool flag = !(b7.Text != "");
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
						flag = !(b1.Text != "");
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
							num += int.Parse(b1.Text);
						}
						catch
						{
							b1.BackColor = Color.Red;
						}
						num2 = 20;
						continue;
					case 1:
						num2 = 24;
						continue;
					case 8:
						flag = !(b3.Text != "");
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
						flag = !(b6.Text != "");
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
						flag = !(b2.Text != "");
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
							num += int.Parse(b4.Text);
						}
						catch
						{
							b4.BackColor = Color.Red;
						}
						num2 = 30;
						continue;
					case 22:
						flag = !(b0.Text != "");
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
							num += int.Parse(b7.Text);
						}
						catch
						{
							b7.BackColor = Color.Red;
						}
						num2 = 16;
						continue;
					case 35:
						try
						{
							num += int.Parse(b3.Text);
						}
						catch
						{
							b3.BackColor = Color.Red;
						}
						num2 = 22;
						continue;
					case 6:
						try
						{
							num += int.Parse(b2.Text);
						}
						catch
						{
							b2.BackColor = Color.Red;
						}
						num2 = 23;
						continue;
					case 33:
						num2 = 35;
						continue;
					case 25:
						try
						{
							num += int.Parse(bz.Text);
						}
						catch
						{
							bz.BackColor = Color.Red;
						}
						num2 = 0;
						continue;
					case 16:
						flag = !(b4.Text != "");
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
						flag = !(bz.Text != "");
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
							num += int.Parse(b6.Text);
						}
						catch
						{
							b6.BackColor = Color.Red;
						}
						num2 = 8;
						continue;
					case 26:
						try
						{
							num += int.Parse(b0.Text);
						}
						catch
						{
							b0.BackColor = Color.Red;
						}
						num2 = 34;
						continue;
					case 13:
						try
						{
							num += int.Parse(b5.Text);
						}
						catch
						{
							b5.BackColor = Color.Red;
						}
						num2 = 27;
						continue;
					case 34:
						flag = !(b5.Text != "");
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
						a5.Text = num.ToString();
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
			a5.Text = "";
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
					a5.Enabled = false;
					bp.Enabled = false;
					e();
					c();
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					bp.Enabled = true;
					a5.Enabled = true;
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
					ck.Focus();
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
		a9.Enabled = this.m_ar.Checked;
		a7.Enabled = this.m_ar.Checked;
		cs.Enabled = this.m_ar.Checked;
	}

	private void k(object A_0, EventArgs A_1)
	{
		asdbt asdbt2 = new asdbt();
		asdbt2.ShowDialog();
		m();
	}

	private void j(object A_0, EventArgs A_1)
	{
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
					cs.Focus();
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
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F3;
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
					flag = A_1.KeyCode != Keys.Next;
					num = 13;
					continue;
				case 9:
					if (true)
					{
					}
					flag = !cf.Enabled;
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
					flag = A_1.KeyCode != Keys.Prior;
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
					flag = !cg.Enabled;
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
		cy.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void h(object A_0, EventArgs A_1)
	{
		cw.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void g(object A_0, EventArgs A_1)
	{
		cy.BackColor = Color.White;
	}

	private void f(object A_0, EventArgs A_1)
	{
		cw.BackColor = Color.White;
	}

	private void e(object A_0, EventArgs A_1)
	{
		c0.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void d(object A_0, EventArgs A_1)
	{
		c2.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void c(object A_0, EventArgs A_1)
	{
		c0.BackColor = Color.White;
	}

	private void b(object A_0, EventArgs A_1)
	{
		c2.BackColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		cd.BackColor = Color.FromName("Window");
		try
		{
			string text3 = default;
			DateTime date = default;
			string text = default;
			while (true)
			{
				IL_005e:
				bool flag = !(cd.Text != "");
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
						string text2 = cd.Text;
						date = ShamsiDate.ShamsiToGregory(text2);
						string shamsiDate = ShamsiDate.GetShamsiDate(date);
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
						text = date.Month.ToString();
						flag = text.Length != 1;
						num = 8;
						continue;
					case 4:
						text3 = date.Day.ToString();
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
						c8.Text = date.Year + "/" + text + "/" + text3;
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
						cd.Focus();
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
protected override void Dispose(bool A_0)
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
						base.Dispose(A_0);
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
		if (true)
		{
		}
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdat));
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		StringFormat stringFormat4 = new StringFormat();
		StringFormat stringFormat5 = new StringFormat();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem10 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem11 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem12 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem13 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem14 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem15 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem16 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem17 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem18 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem19 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem20 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem21 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem22 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem23 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem24 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem25 = new UIComboBoxItem();
		StringFormat stringFormat6 = new StringFormat();
		StringFormat stringFormat7 = new StringFormat();
		StringFormat stringFormat8 = new StringFormat();
		UIComboBoxItem uIComboBoxItem26 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem27 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem28 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem29 = new UIComboBoxItem();
		StringFormat stringFormat9 = new StringFormat();
		UIComboBoxItem uIComboBoxItem30 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem31 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem32 = new UIComboBoxItem();
		StringFormat stringFormat10 = new StringFormat();
		UIComboBoxItem uIComboBoxItem33 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem34 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem35 = new UIComboBoxItem();
		StringFormat stringFormat11 = new StringFormat();
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
		this.m_h.SuspendLayout();
		co.SuspendLayout();
		ci.SuspendLayout();
		((ISupportInitialize)bp).BeginInit();
		bp.SuspendLayout();
		((ISupportInitialize)a9).BeginInit();
		a9.SuspendLayout();
		((ISupportInitialize)this.m_p).BeginInit();
		this.m_i.SuspendLayout();
		SuspendLayout();
		this.m_d.Location = new Point(188, 434);
		this.m_d.Name = "dropCls";
		this.m_d.Size = new Size(142, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_d.StringFormat = stringFormat;
		this.m_d.TabIndex = 37;
		this.m_d.SelectedIndexChanged += o;
		this.m_e.Anchor = AnchorStyles.Top;
		this.m_e.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		this.m_e.ImageSize = new Size(30, 40);
		this.m_e.Location = new Point(220, 624);
		this.m_e.Name = "btnAcp";
		this.m_e.Size = new Size(178, 42);
		this.m_e.TabIndex = 100;
		this.m_e.Text = "ثبت(F3)";
		this.m_e.Click += @as;
		this.m_f.AutoSize = true;
		this.m_f.Location = new Point(336, 437);
		this.m_f.Name = "label19";
		this.m_f.Size = new Size(35, 16);
		this.m_f.TabIndex = 12;
		this.m_f.Text = "صنف";
		this.m_g.Anchor = AnchorStyles.Top;
		this.m_g.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		this.m_g.ImageSize = new Size(40, 40);
		this.m_g.Location = new Point(19, 624);
		this.m_g.Name = "uiButton1";
		this.m_g.Size = new Size(178, 42);
		this.m_g.TabIndex = 101;
		this.m_g.Text = "بستن";
		this.m_g.Click += av;
		this.m_h.BackColor = SystemColors.GradientInactiveCaption;
		this.m_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_h.Controls.Add(c8);
		this.m_h.Controls.Add(c9);
		this.m_h.Controls.Add(c6);
		this.m_h.Controls.Add(c7);
		this.m_h.Controls.Add(c4);
		this.m_h.Controls.Add(c5);
		this.m_h.Controls.Add(c3);
		this.m_h.Controls.Add(c1);
		this.m_h.Controls.Add(c2);
		this.m_h.Controls.Add(cz);
		this.m_h.Controls.Add(c0);
		this.m_h.Controls.Add(cv);
		this.m_h.Controls.Add(cw);
		this.m_h.Controls.Add(cx);
		this.m_h.Controls.Add(cy);
		this.m_h.Controls.Add(ct);
		this.m_h.Controls.Add(cu);
		this.m_h.Controls.Add(cr);
		this.m_h.Controls.Add(cs);
		this.m_h.Controls.Add(co);
		this.m_h.Controls.Add(cn);
		this.m_h.Controls.Add(cq);
		this.m_h.Controls.Add(cm);
		this.m_h.Controls.Add(ck);
		this.m_h.Controls.Add(cl);
		this.m_h.Controls.Add(ci);
		this.m_h.Controls.Add(ce);
		this.m_h.Controls.Add(cc);
		this.m_h.Controls.Add(cd);
		this.m_h.Controls.Add(cb);
		this.m_h.Controls.Add(bp);
		this.m_h.Controls.Add(a9);
		this.m_h.Controls.Add(a7);
		this.m_h.Controls.Add(a8);
		this.m_h.Controls.Add(a5);
		this.m_h.Controls.Add(a6);
		this.m_h.Controls.Add(a3);
		this.m_h.Controls.Add(a4);
		this.m_h.Controls.Add(a2);
		this.m_h.Controls.Add(a1);
		this.m_h.Controls.Add(ay);
		this.m_h.Controls.Add(az);
		this.m_h.Controls.Add(a0);
		this.m_h.Controls.Add(ax);
		this.m_h.Controls.Add(this.m_av);
		this.m_h.Controls.Add(this.m_aw);
		this.m_h.Controls.Add(this.m_au);
		this.m_h.Controls.Add(this.m_aq);
		this.m_h.Controls.Add(this.m_ar);
		this.m_h.Controls.Add(this.m_as);
		this.m_h.Controls.Add(this.m_at);
		this.m_h.Controls.Add(this.m_ao);
		this.m_h.Controls.Add(this.m_ap);
		this.m_h.Controls.Add(this.m_am);
		this.m_h.Controls.Add(this.m_an);
		this.m_h.Controls.Add(this.m_al);
		this.m_h.Controls.Add(this.m_aj);
		this.m_h.Controls.Add(this.m_ai);
		this.m_h.Controls.Add(this.m_ag);
		this.m_h.Controls.Add(this.m_ah);
		this.m_h.Controls.Add(this.m_af);
		this.m_h.Controls.Add(this.m_ae);
		this.m_h.Controls.Add(this.m_y);
		this.m_h.Controls.Add(this.m_z);
		this.m_h.Controls.Add(this.m_aa);
		this.m_h.Controls.Add(this.m_ab);
		this.m_h.Controls.Add(this.m_ac);
		this.m_h.Controls.Add(this.m_ad);
		this.m_h.Controls.Add(this.m_n);
		this.m_h.Controls.Add(this.m_j);
		this.m_h.Controls.Add(this.m_o);
		this.m_h.Controls.Add(this.m_p);
		this.m_h.Controls.Add(this.m_k);
		this.m_h.Controls.Add(this.m_l);
		this.m_h.Controls.Add(this.m_m);
		this.m_h.Controls.Add(this.m_d);
		this.m_h.Controls.Add(this.m_g);
		this.m_h.Controls.Add(this.m_e);
		this.m_h.Controls.Add(this.m_f);
		this.m_h.Controls.Add(this.m_q);
		this.m_h.Controls.Add(this.m_r);
		this.m_h.Controls.Add(this.m_x);
		this.m_h.Controls.Add(this.m_s);
		this.m_h.Controls.Add(this.m_w);
		this.m_h.Controls.Add(this.m_t);
		this.m_h.Controls.Add(this.m_v);
		this.m_h.Controls.Add(this.m_u);
		this.m_h.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_h.Location = new Point(8, 13);
		this.m_h.Name = "panel1";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(815, 680);
		this.m_h.TabIndex = 34;
		c8.AutoScroll = false;
		c8.AutoScrollMargin = new Size(0, 0);
		c8.AutoScrollMinSize = new Size(0, 0);
		c8.AutoScrollPosition = new Point(0, 0);
		c8.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		c8.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		c8.Location = new Point(112, 135);
		c8.Mask = "0000/00/00";
		c8.MaxLength = 12;
		c8.Name = "txtbDateM";
		c8.Numeric = true;
		c8.RightToLeft = RightToLeft.No;
		c8.Size = new Size(143, 26);
		c8.TabIndex = 8;
		c8.Tag = "";
		c8.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		c8.Leave += u;
		c8.Enter += t;
		c9.AutoSize = true;
		c9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c9.Location = new Point(260, 141);
		c9.Name = "label49";
		c9.Size = new Size(60, 13);
		c9.TabIndex = 148;
		c9.Text = "تولد میلادی";
		c6.Location = new Point(450, 325);
		c6.Name = "dropcityNow";
		c6.Size = new Size(218, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		c6.StringFormat = stringFormat2;
		c6.TabIndex = 146;
		c7.AutoSize = true;
		c7.Location = new Point(674, 328);
		c7.Name = "label48";
		c7.Size = new Size(136, 16);
		c7.TabIndex = 147;
		c7.Text = "ولسوالی\u200c سکونت فعلی";
		c4.AutoSize = true;
		c4.Location = new Point(102, 219);
		c4.Name = "label47";
		c4.Size = new Size(62, 16);
		c4.TabIndex = 145;
		c4.Text = "کد تخفیف";
		c5.AutoScroll = false;
		c5.AutoScrollMargin = new Size(0, 0);
		c5.AutoScrollMinSize = new Size(0, 0);
		c5.AutoScrollPosition = new Point(0, 0);
		c5.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		c5.Location = new Point(3, 215);
		c5.MaxLength = 9;
		c5.Name = "txtcodeTakhfif";
		c5.Numeric = true;
		c5.RightToLeft = RightToLeft.Yes;
		c5.Size = new Size(96, 23);
		c5.TabIndex = 14;
		c5.Tag = "";
		c5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		c5.Leave += u;
		c5.Enter += t;
		c3.AutoSize = true;
		c3.Location = new Point(208, 393);
		c3.Name = "checkMarkTerm3_From100";
		c3.Size = new Size(152, 20);
		c3.TabIndex = 36;
		c3.Text = "ورود نمره سالانه از 100";
		c3.UseVisualStyleBackColor = true;
		c1.AutoSize = true;
		c1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c1.Location = new Point(260, 101);
		c1.Name = "label46";
		c1.Size = new Size(80, 13);
		c1.TabIndex = 143;
		c1.Text = "تخلص انگلیسی";
		c2.AutoScroll = false;
		c2.AutoScrollMargin = new Size(0, 0);
		c2.AutoScrollMinSize = new Size(0, 0);
		c2.AutoScrollPosition = new Point(0, 0);
		c2.Location = new Point(112, 97);
		c2.Name = "txtEn_LastName";
		c2.Size = new Size(143, 23);
		c2.TabIndex = 5;
		c2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		c2.Leave += b;
		c2.Enter += d;
		cz.AutoSize = true;
		cz.Location = new Point(494, 63);
		cz.Name = "label45";
		cz.Size = new Size(41, 16);
		cz.TabIndex = 141;
		cz.Text = "تخلص";
		c0.AutoScroll = false;
		c0.AutoScrollMargin = new Size(0, 0);
		c0.AutoScrollMinSize = new Size(0, 0);
		c0.AutoScrollPosition = new Point(0, 0);
		c0.Location = new Point(346, 60);
		c0.Name = "txtLastName";
		c0.Size = new Size(143, 23);
		c0.TabIndex = 1;
		c0.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		c0.Leave += c;
		c0.Enter += e;
		cv.AutoSize = true;
		cv.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cv.Location = new Point(723, 142);
		cv.Name = "label44";
		cv.Size = new Size(82, 13);
		cv.TabIndex = 139;
		cv.Text = "نام پدر انگلیسی";
		cw.AutoScroll = false;
		cw.AutoScrollMargin = new Size(0, 0);
		cw.AutoScrollMinSize = new Size(0, 0);
		cw.AutoScrollPosition = new Point(0, 0);
		cw.Location = new Point(583, 138);
		cw.Name = "txtEn_Lname";
		cw.Size = new Size(136, 23);
		cw.TabIndex = 6;
		cw.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		cw.Leave += f;
		cw.Enter += h;
		cx.AutoSize = true;
		cx.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cx.Location = new Point(490, 101);
		cx.Name = "label43";
		cx.Size = new Size(70, 14);
		cx.TabIndex = 137;
		cx.Text = "نام انگلیسی";
		cy.AutoScroll = false;
		cy.AutoScrollMargin = new Size(0, 0);
		cy.AutoScrollMinSize = new Size(0, 0);
		cy.AutoScrollPosition = new Point(0, 0);
		cy.Location = new Point(346, 97);
		cy.Name = "txtEn_Fname";
		cy.Size = new Size(143, 23);
		cy.TabIndex = 4;
		cy.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		cy.Leave += g;
		cy.Enter += i;
		ct.Location = new Point(7, 255);
		ct.Name = "dropcity";
		ct.Size = new Size(179, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		ct.StringFormat = stringFormat3;
		ct.TabIndex = 18;
		cu.AutoSize = true;
		cu.Location = new Point(190, 258);
		cu.Name = "label42";
		cu.Size = new Size(147, 16);
		cu.TabIndex = 135;
		cu.Text = "ولسوالی\u200c سکونت اصلی :";
		cr.AutoSize = true;
		cr.Location = new Point(562, 478);
		cr.Name = "label41";
		cr.Size = new Size(38, 16);
		cr.TabIndex = 134;
		cr.Text = "راننده";
		cs.Enabled = false;
		cs.Location = new Point(421, 475);
		cs.Name = "dropDriver";
		cs.Size = new Size(138, 23);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		cs.StringFormat = stringFormat4;
		cs.TabIndex = 39;
		cs.Leave += j;
		co.BackColor = SystemColors.HotTrack;
		co.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		co.Controls.Add(cp);
		co.Location = new Point(142, 5);
		co.Name = "pLastReg";
		co.Size = new Size(281, 49);
		co.TabIndex = 132;
		co.Visible = false;
		cp.BackColor = Color.FromArgb(0, 192, 192);
		cp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		cp.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		cp.Location = new Point(6, 5);
		cp.Name = "lLastReg";
		cp.Size = new Size(267, 37);
		cp.TabIndex = 131;
		cp.TextAlign = ContentAlignment.MiddleCenter;
		cn.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		cn.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cn.Image = (Image)componentResourceManager.GetObject("btnEnableItem.Image");
		cn.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		cn.ImageIndex = 8;
		cn.Location = new Point(566, 6);
		cn.Name = "btnEnableItem";
		cn.RightToLeft = RightToLeft.Yes;
		cn.Size = new Size(224, 31);
		cn.TabIndex = 129;
		cn.Text = "فعال و غیر فعال کردن آیتم های ثبت نام";
		cn.Visible = false;
		cn.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		cn.Click += k;
		cq.AutoSize = true;
		cq.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		cq.Location = new Point(430, 19);
		cq.Name = "llastReglable";
		cq.Size = new Size(98, 16);
		cq.TabIndex = 127;
		cq.Text = "نفر آخر ثبت نام";
		cq.Visible = false;
		cm.AutoScroll = false;
		cm.AutoScrollMargin = new Size(0, 0);
		cm.AutoScrollMinSize = new Size(0, 0);
		cm.AutoScrollPosition = new Point(0, 0);
		cm.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		cm.Enabled = false;
		cm.Location = new Point(23, 432);
		cm.MaxLength = 10;
		cm.Name = "txtFeeClass";
		cm.Numeric = true;
		cm.RightToLeft = RightToLeft.Yes;
		cm.Size = new Size(76, 23);
		cm.TabIndex = 126;
		cm.Tag = "";
		cm.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ck.DropListFont = new Font("B Nazanin", 12f);
		ck.Location = new Point(16, 471);
		ck.Name = "comboTakhfif";
		ck.Size = new Size(156, 23);
		stringFormat5.Alignment = StringAlignment.Near;
		stringFormat5.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat5.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat5.LineAlignment = StringAlignment.Center;
		stringFormat5.Trimming = StringTrimming.Character;
		ck.StringFormat = stringFormat5;
		ck.TabIndex = 40;
		ck.Leave += m;
		ck.SelectedIndexChanged += n;
		cl.AutoSize = true;
		cl.Location = new Point(178, 475);
		cl.Name = "label40";
		cl.Size = new Size(45, 16);
		cl.TabIndex = 124;
		cl.Text = "تخفیف";
		ci.Controls.Add(cj);
		ci.Controls.Add(ch);
		ci.Controls.Add(cf);
		ci.Controls.Add(cg);
		ci.Location = new Point(410, 625);
		ci.Name = "pEditList";
		ci.Size = new Size(383, 41);
		ci.TabIndex = 123;
		ci.Visible = false;
		cj.AutoSize = true;
		cj.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		cj.Location = new Point(22, 1);
		cj.Name = "label39";
		cj.Size = new Size(97, 13);
		cj.TabIndex = 133;
		cj.Text = "اشاره گر روی گزینه ";
		ch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ch.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ch.DropListFont = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ch.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "نام";
		uIComboBoxItem.Value = "txtNamF";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "تخلص";
		uIComboBoxItem2.Value = "txtLastName";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "ولد/بنت";
		uIComboBoxItem3.Value = "txtNamL";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "ولدیت";
		uIComboBoxItem4.Value = "txtNamP";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "نام انگلیسی";
		uIComboBoxItem5.Value = "txtEn_Fname";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "تخلص انگلیسی";
		uIComboBoxItem6.Value = "En_LastName";
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "نام پدر انگلیسی";
		uIComboBoxItem7.Value = "txtEn_Lname";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "نمبرتلگرام";
		uIComboBoxItem8.Value = "txtNumberTelegram";
		uIComboBoxItem9.FormatStyle.Alpha = 0;
		uIComboBoxItem9.Text = "تلفن پدر";
		uIComboBoxItem9.Value = "txtMobileFather";
		uIComboBoxItem10.FormatStyle.Alpha = 0;
		uIComboBoxItem10.Text = "تلفن مادر";
		uIComboBoxItem10.Value = "txtMobileMother";
		uIComboBoxItem11.FormatStyle.Alpha = 0;
		uIComboBoxItem11.Text = "تاریخ تولد";
		uIComboBoxItem11.Value = "txtbDate";
		uIComboBoxItem12.FormatStyle.Alpha = 0;
		uIComboBoxItem12.Text = "نمبرتذکره";
		uIComboBoxItem12.Value = "txtSh_sh";
		uIComboBoxItem13.FormatStyle.Alpha = 0;
		uIComboBoxItem13.Text = "نمبر اساس";
		uIComboBoxItem13.Value = "txtNumberAsas";
		uIComboBoxItem14.FormatStyle.Alpha = 0;
		uIComboBoxItem14.Text = "جنیست";
		uIComboBoxItem14.Value = "dropJens";
		uIComboBoxItem15.FormatStyle.Alpha = 0;
		uIComboBoxItem15.Text = "دین / مذهب";
		uIComboBoxItem15.Value = "dropMazhab";
		uIComboBoxItem16.FormatStyle.Alpha = 0;
		uIComboBoxItem16.Text = "وضعیت";
		uIComboBoxItem16.Value = "dropStatus";
		uIComboBoxItem17.FormatStyle.Alpha = 0;
		uIComboBoxItem17.Text = "تاریخ شمولیت";
		uIComboBoxItem17.Value = "txtRegDate";
		uIComboBoxItem18.FormatStyle.Alpha = 0;
		uIComboBoxItem18.Text = "کد متعلم";
		uIComboBoxItem18.Value = "txtCode";
		uIComboBoxItem19.FormatStyle.Alpha = 0;
		uIComboBoxItem19.Text = "آدرس";
		uIComboBoxItem19.Value = "txtAdress";
		uIComboBoxItem20.FormatStyle.Alpha = 0;
		uIComboBoxItem20.Text = "داخله";
		uIComboBoxItem20.Value = "checkdakhle";
		uIComboBoxItem21.FormatStyle.Alpha = 0;
		uIComboBoxItem21.Text = "صنف";
		uIComboBoxItem21.Value = "dropCls";
		uIComboBoxItem22.FormatStyle.Alpha = 0;
		uIComboBoxItem22.Text = "مجموع ترانسپورت";
		uIComboBoxItem22.Value = "txtSumtransport";
		uIComboBoxItem23.FormatStyle.Alpha = 0;
		uIComboBoxItem23.Text = "راننده";
		uIComboBoxItem23.Value = "dropDriver";
		uIComboBoxItem24.FormatStyle.Alpha = 0;
		uIComboBoxItem24.Text = "فیس";
		uIComboBoxItem24.Value = "txtFee1";
		uIComboBoxItem25.FormatStyle.Alpha = 0;
		uIComboBoxItem25.Text = "ولسوالی";
		uIComboBoxItem25.Value = "dropcity";
		ch.Items.AddRange(new UIComboBoxItem[25]
		{
			uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6, uIComboBoxItem7, uIComboBoxItem8, uIComboBoxItem9, uIComboBoxItem10,
			uIComboBoxItem11, uIComboBoxItem12, uIComboBoxItem13, uIComboBoxItem14, uIComboBoxItem15, uIComboBoxItem16, uIComboBoxItem17, uIComboBoxItem18, uIComboBoxItem19, uIComboBoxItem20,
			uIComboBoxItem21, uIComboBoxItem22, uIComboBoxItem23, uIComboBoxItem24, uIComboBoxItem25
		});
		ch.Location = new Point(8, 18);
		ch.Name = "comboFocse";
		ch.Size = new Size(122, 21);
		stringFormat6.Alignment = StringAlignment.Near;
		stringFormat6.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat6.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat6.LineAlignment = StringAlignment.Center;
		stringFormat6.Trimming = StringTrimming.Character;
		ch.StringFormat = stringFormat6;
		ch.TabIndex = 122;
		ch.SelectedIndexChanged += p;
		cf.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		cf.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		cf.ImageIndex = 8;
		cf.ImageSize = new Size(30, 30);
		cf.Location = new Point(164, 2);
		cf.Name = "btnPrevious";
		cf.RightToLeft = RightToLeft.Yes;
		cf.Size = new Size(106, 38);
		cf.TabIndex = 121;
		cf.Text = "(pageUp) قبلی  ";
		cf.ToolTipText = "دکمه میانبر : PageUp";
		cf.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		cf.Click += q;
		cg.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		cg.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		cg.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		cg.ImageIndex = 8;
		cg.ImageSize = new Size(30, 30);
		cg.Location = new Point(273, 2);
		cg.Name = "btnNext";
		cg.RightToLeft = RightToLeft.Yes;
		cg.Size = new Size(106, 38);
		cg.TabIndex = 120;
		cg.Tag = "";
		cg.Text = "(pageDown) بعدی  ";
		cg.ToolTipText = "دکمه میانبر : PageDown";
		cg.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		cg.Click += r;
		ce.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ce.DropListFont = new Font("B Nazanin", 12f);
		ce.Location = new Point(387, 570);
		ce.Name = "comboStd";
		ce.Size = new Size(39, 23);
		stringFormat7.Alignment = StringAlignment.Near;
		stringFormat7.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat7.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat7.LineAlignment = StringAlignment.Center;
		stringFormat7.Trimming = StringTrimming.Character;
		ce.StringFormat = stringFormat7;
		ce.TabIndex = 119;
		ce.Visible = false;
		ce.SelectedIndexChanged += s;
		cc.AutoSize = true;
		cc.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cc.Location = new Point(492, 142);
		cc.Name = "label38";
		cc.Size = new Size(92, 13);
		cc.TabIndex = 118;
		cc.Text = "تاریخ تولد شمسی";
		cd.AutoScroll = false;
		cd.AutoScrollMargin = new Size(0, 0);
		cd.AutoScrollMinSize = new Size(0, 0);
		cd.AutoScrollPosition = new Point(0, 0);
		cd.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		cd.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		cd.Location = new Point(346, 135);
		cd.Mask = "0000/00/00";
		cd.MaxLength = 12;
		cd.Name = "txtbDate";
		cd.Numeric = true;
		cd.RightToLeft = RightToLeft.No;
		cd.Size = new Size(143, 26);
		cd.TabIndex = 7;
		cd.Tag = "";
		cd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		cd.Leave += a;
		cd.Enter += t;
		cb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		cb.Location = new Point(635, 431);
		cb.Name = "lYear";
		cb.Size = new Size(55, 24);
		cb.TabIndex = 116;
		bp.Controls.Add(bq);
		bp.Controls.Add(br);
		bp.Controls.Add(bs);
		bp.Controls.Add(bt);
		bp.Controls.Add(bu);
		bp.Controls.Add(bv);
		bp.Controls.Add(bw);
		bp.Controls.Add(bx);
		bp.Controls.Add(by);
		bp.Controls.Add(bz);
		bp.Controls.Add(b0);
		bp.Controls.Add(b1);
		bp.Controls.Add(b2);
		bp.Controls.Add(b3);
		bp.Controls.Add(b4);
		bp.Controls.Add(b5);
		bp.Controls.Add(b6);
		bp.Controls.Add(b7);
		bp.Enabled = false;
		bp.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bp.Location = new Point(14, 503);
		bp.Name = "GroupFee";
		bp.Size = new Size(372, 110);
		bp.TabIndex = 42;
		bp.Text = "فیس";
		bq.AutoSize = true;
		bq.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bq.Location = new Point(80, 81);
		bq.Name = "label29";
		bq.Size = new Size(30, 13);
		bq.TabIndex = 132;
		bq.Text = "قوس";
		br.AutoSize = true;
		br.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		br.Location = new Point(80, 54);
		br.Name = "label30";
		br.Size = new Size(36, 13);
		br.TabIndex = 131;
		br.Text = "سنبله";
		bs.AutoSize = true;
		bs.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bs.Location = new Point(80, 27);
		bs.Name = "label31";
		bs.Size = new Size(26, 13);
		bs.TabIndex = 130;
		bs.Text = "جوزا";
		bt.AutoSize = true;
		bt.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bt.Location = new Point(213, 81);
		bt.Name = "label32";
		bt.Size = new Size(34, 13);
		bt.TabIndex = 129;
		bt.Text = "عقرب";
		bu.AutoSize = true;
		bu.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bu.Location = new Point(213, 54);
		bu.Name = "label33";
		bu.Size = new Size(27, 13);
		bu.TabIndex = 128;
		bu.Text = "اسد";
		bv.AutoSize = true;
		bv.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bv.Location = new Point(213, 27);
		bv.Name = "label34";
		bv.Size = new Size(19, 13);
		bv.TabIndex = 127;
		bv.Text = "ثور";
		bw.AutoSize = true;
		bw.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bw.Location = new Point(325, 81);
		bw.Name = "label35";
		bw.Size = new Size(32, 13);
		bw.TabIndex = 126;
		bw.Text = "میزان";
		bx.AutoSize = true;
		bx.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bx.Location = new Point(323, 55);
		bx.Name = "label36";
		bx.Size = new Size(40, 13);
		bx.TabIndex = 125;
		bx.Text = "سرطان";
		by.AutoSize = true;
		by.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		by.Location = new Point(325, 27);
		by.Name = "label37";
		by.Size = new Size(29, 13);
		by.TabIndex = 124;
		by.Text = "حمل";
		bz.AutoScroll = false;
		bz.AutoScrollMargin = new Size(0, 0);
		bz.AutoScrollMinSize = new Size(0, 0);
		bz.AutoScrollPosition = new Point(0, 0);
		bz.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bz.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bz.Location = new Point(11, 77);
		bz.MaxLength = 8;
		bz.Name = "txtFee9";
		bz.Numeric = true;
		bz.RightToLeft = RightToLeft.Yes;
		bz.Size = new Size(63, 21);
		bz.TabIndex = 49;
		bz.Tag = "";
		bz.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bz.Leave += u;
		bz.KeyUp += d;
		bz.Enter += t;
		b0.AutoScroll = false;
		b0.AutoScrollMargin = new Size(0, 0);
		b0.AutoScrollMinSize = new Size(0, 0);
		b0.AutoScrollPosition = new Point(0, 0);
		b0.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b0.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b0.Location = new Point(11, 50);
		b0.MaxLength = 8;
		b0.Name = "txtFee6";
		b0.Numeric = true;
		b0.RightToLeft = RightToLeft.Yes;
		b0.Size = new Size(63, 21);
		b0.TabIndex = 46;
		b0.Tag = "";
		b0.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b0.Leave += u;
		b0.KeyUp += g;
		b0.Enter += t;
		b1.AutoScroll = false;
		b1.AutoScrollMargin = new Size(0, 0);
		b1.AutoScrollMinSize = new Size(0, 0);
		b1.AutoScrollPosition = new Point(0, 0);
		b1.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b1.Location = new Point(11, 23);
		b1.MaxLength = 8;
		b1.Name = "txtFee3";
		b1.Numeric = true;
		b1.RightToLeft = RightToLeft.Yes;
		b1.Size = new Size(63, 21);
		b1.TabIndex = 43;
		b1.Tag = "";
		b1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b1.Leave += u;
		b1.KeyUp += j;
		b1.Enter += t;
		b2.AutoScroll = false;
		b2.AutoScrollMargin = new Size(0, 0);
		b2.AutoScrollMinSize = new Size(0, 0);
		b2.AutoScrollPosition = new Point(0, 0);
		b2.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b2.Location = new Point(144, 77);
		b2.MaxLength = 8;
		b2.Name = "txtFee8";
		b2.Numeric = true;
		b2.RightToLeft = RightToLeft.Yes;
		b2.Size = new Size(63, 21);
		b2.TabIndex = 48;
		b2.Tag = "";
		b2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b2.Leave += u;
		b2.KeyUp += e;
		b2.Enter += t;
		b3.AutoScroll = false;
		b3.AutoScrollMargin = new Size(0, 0);
		b3.AutoScrollMinSize = new Size(0, 0);
		b3.AutoScrollPosition = new Point(0, 0);
		b3.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b3.Location = new Point(144, 50);
		b3.MaxLength = 8;
		b3.Name = "txtFee5";
		b3.Numeric = true;
		b3.RightToLeft = RightToLeft.Yes;
		b3.Size = new Size(63, 21);
		b3.TabIndex = 45;
		b3.Tag = "";
		b3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b3.Leave += u;
		b3.KeyUp += h;
		b3.Enter += t;
		b4.AutoScroll = false;
		b4.AutoScrollMargin = new Size(0, 0);
		b4.AutoScrollMinSize = new Size(0, 0);
		b4.AutoScrollPosition = new Point(0, 0);
		b4.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b4.Location = new Point(144, 23);
		b4.MaxLength = 8;
		b4.Name = "txtFee2";
		b4.Numeric = true;
		b4.RightToLeft = RightToLeft.Yes;
		b4.Size = new Size(63, 21);
		b4.TabIndex = 42;
		b4.Tag = "";
		b4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b4.Leave += u;
		b4.KeyUp += k;
		b4.Enter += t;
		b5.AutoScroll = false;
		b5.AutoScrollMargin = new Size(0, 0);
		b5.AutoScrollMinSize = new Size(0, 0);
		b5.AutoScrollPosition = new Point(0, 0);
		b5.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b5.Location = new Point(262, 77);
		b5.MaxLength = 8;
		b5.Name = "txtFee7";
		b5.Numeric = true;
		b5.RightToLeft = RightToLeft.Yes;
		b5.Size = new Size(57, 21);
		b5.TabIndex = 47;
		b5.Tag = "";
		b5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b5.Leave += u;
		b5.KeyUp += f;
		b5.Enter += t;
		b6.AutoScroll = false;
		b6.AutoScrollMargin = new Size(0, 0);
		b6.AutoScrollMinSize = new Size(0, 0);
		b6.AutoScrollPosition = new Point(0, 0);
		b6.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b6.Location = new Point(262, 50);
		b6.MaxLength = 8;
		b6.Name = "txtFee4";
		b6.Numeric = true;
		b6.RightToLeft = RightToLeft.Yes;
		b6.Size = new Size(57, 21);
		b6.TabIndex = 44;
		b6.Tag = "";
		b6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b6.Leave += u;
		b6.KeyUp += i;
		b6.Enter += t;
		b7.AutoScroll = false;
		b7.AutoScrollMargin = new Size(0, 0);
		b7.AutoScrollMinSize = new Size(0, 0);
		b7.AutoScrollPosition = new Point(0, 0);
		b7.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		b7.Location = new Point(262, 23);
		b7.MaxLength = 8;
		b7.Name = "txtFee1";
		b7.Numeric = true;
		b7.ReadOnly = true;
		b7.RightToLeft = RightToLeft.Yes;
		b7.Size = new Size(57, 21);
		b7.TabIndex = 41;
		b7.Tag = "";
		b7.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		b7.Leave += u;
		b7.KeyUp += l;
		b7.Enter += t;
		a9.Controls.Add(b8);
		a9.Controls.Add(b9);
		a9.Controls.Add(ca);
		a9.Controls.Add(bj);
		a9.Controls.Add(bk);
		a9.Controls.Add(bl);
		a9.Controls.Add(bm);
		a9.Controls.Add(bn);
		a9.Controls.Add(bo);
		a9.Controls.Add(ba);
		a9.Controls.Add(bb);
		a9.Controls.Add(bc);
		a9.Controls.Add(bd);
		a9.Controls.Add(be);
		a9.Controls.Add(bf);
		a9.Controls.Add(bg);
		a9.Controls.Add(bh);
		a9.Controls.Add(bi);
		a9.Enabled = false;
		a9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a9.Location = new Point(422, 503);
		a9.Name = "groupTransport";
		a9.Size = new Size(372, 110);
		a9.TabIndex = 41;
		a9.Text = "ترانسپورت";
		b8.AutoSize = true;
		b8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		b8.Location = new Point(80, 81);
		b8.Name = "label26";
		b8.Size = new Size(30, 13);
		b8.TabIndex = 132;
		b8.Text = "قوس";
		b9.AutoSize = true;
		b9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		b9.Location = new Point(80, 54);
		b9.Name = "label27";
		b9.Size = new Size(36, 13);
		b9.TabIndex = 131;
		b9.Text = "سنبله";
		ca.AutoSize = true;
		ca.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ca.Location = new Point(80, 27);
		ca.Name = "label28";
		ca.Size = new Size(26, 13);
		ca.TabIndex = 130;
		ca.Text = "جوزا";
		bj.AutoSize = true;
		bj.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bj.Location = new Point(213, 81);
		bj.Name = "label25";
		bj.Size = new Size(34, 13);
		bj.TabIndex = 129;
		bj.Text = "عقرب";
		bk.AutoSize = true;
		bk.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bk.Location = new Point(213, 54);
		bk.Name = "label24";
		bk.Size = new Size(27, 13);
		bk.TabIndex = 128;
		bk.Text = "اسد";
		bl.AutoSize = true;
		bl.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bl.Location = new Point(213, 27);
		bl.Name = "label23";
		bl.Size = new Size(19, 13);
		bl.TabIndex = 127;
		bl.Text = "ثور";
		bm.AutoSize = true;
		bm.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bm.Location = new Point(325, 81);
		bm.Name = "label22";
		bm.Size = new Size(32, 13);
		bm.TabIndex = 126;
		bm.Text = "میزان";
		bn.AutoSize = true;
		bn.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bn.Location = new Point(324, 54);
		bn.Name = "label21";
		bn.Size = new Size(40, 13);
		bn.TabIndex = 125;
		bn.Text = "سرطان";
		bo.AutoSize = true;
		bo.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		bo.Location = new Point(325, 27);
		bo.Name = "label18";
		bo.Size = new Size(29, 13);
		bo.TabIndex = 124;
		bo.Text = "حمل";
		ba.AutoScroll = false;
		ba.AutoScrollMargin = new Size(0, 0);
		ba.AutoScrollMinSize = new Size(0, 0);
		ba.AutoScrollPosition = new Point(0, 0);
		ba.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ba.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ba.Location = new Point(11, 77);
		ba.MaxLength = 8;
		ba.Name = "txttransport9";
		ba.Numeric = true;
		ba.RightToLeft = RightToLeft.Yes;
		ba.Size = new Size(63, 21);
		ba.TabIndex = 69;
		ba.Tag = "";
		ba.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ba.Leave += u;
		ba.KeyUp += m;
		ba.Enter += t;
		bb.AutoScroll = false;
		bb.AutoScrollMargin = new Size(0, 0);
		bb.AutoScrollMinSize = new Size(0, 0);
		bb.AutoScrollPosition = new Point(0, 0);
		bb.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bb.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bb.Location = new Point(11, 50);
		bb.MaxLength = 8;
		bb.Name = "txttransport6";
		bb.Numeric = true;
		bb.RightToLeft = RightToLeft.Yes;
		bb.Size = new Size(63, 21);
		bb.TabIndex = 66;
		bb.Tag = "";
		bb.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bb.Leave += u;
		bb.KeyUp += p;
		bb.Enter += t;
		bc.AutoScroll = false;
		bc.AutoScrollMargin = new Size(0, 0);
		bc.AutoScrollMinSize = new Size(0, 0);
		bc.AutoScrollPosition = new Point(0, 0);
		bc.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bc.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bc.Location = new Point(11, 23);
		bc.MaxLength = 8;
		bc.Name = "txttransport3";
		bc.Numeric = true;
		bc.RightToLeft = RightToLeft.Yes;
		bc.Size = new Size(63, 21);
		bc.TabIndex = 63;
		bc.Tag = "";
		bc.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bc.Leave += u;
		bc.KeyUp += s;
		bc.Enter += t;
		bd.AutoScroll = false;
		bd.AutoScrollMargin = new Size(0, 0);
		bd.AutoScrollMinSize = new Size(0, 0);
		bd.AutoScrollPosition = new Point(0, 0);
		bd.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bd.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bd.Location = new Point(144, 77);
		bd.MaxLength = 8;
		bd.Name = "txttransport8";
		bd.Numeric = true;
		bd.RightToLeft = RightToLeft.Yes;
		bd.Size = new Size(63, 21);
		bd.TabIndex = 68;
		bd.Tag = "";
		bd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bd.Leave += u;
		bd.KeyUp += n;
		bd.Enter += t;
		be.AutoScroll = false;
		be.AutoScrollMargin = new Size(0, 0);
		be.AutoScrollMinSize = new Size(0, 0);
		be.AutoScrollPosition = new Point(0, 0);
		be.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		be.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		be.Location = new Point(144, 50);
		be.MaxLength = 8;
		be.Name = "txttransport5";
		be.Numeric = true;
		be.RightToLeft = RightToLeft.Yes;
		be.Size = new Size(63, 21);
		be.TabIndex = 65;
		be.Tag = "";
		be.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		be.Leave += u;
		be.KeyUp += q;
		be.Enter += t;
		bf.AutoScroll = false;
		bf.AutoScrollMargin = new Size(0, 0);
		bf.AutoScrollMinSize = new Size(0, 0);
		bf.AutoScrollPosition = new Point(0, 0);
		bf.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bf.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bf.Location = new Point(144, 23);
		bf.MaxLength = 8;
		bf.Name = "txttransport2";
		bf.Numeric = true;
		bf.RightToLeft = RightToLeft.Yes;
		bf.Size = new Size(63, 21);
		bf.TabIndex = 62;
		bf.Tag = "";
		bf.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bf.Leave += u;
		bf.KeyUp += t;
		bf.Enter += t;
		bg.AutoScroll = false;
		bg.AutoScrollMargin = new Size(0, 0);
		bg.AutoScrollMinSize = new Size(0, 0);
		bg.AutoScrollPosition = new Point(0, 0);
		bg.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bg.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bg.Location = new Point(262, 77);
		bg.MaxLength = 8;
		bg.Name = "txttransport7";
		bg.Numeric = true;
		bg.RightToLeft = RightToLeft.Yes;
		bg.Size = new Size(57, 21);
		bg.TabIndex = 67;
		bg.Tag = "";
		bg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bg.Leave += u;
		bg.KeyUp += o;
		bg.Enter += t;
		bh.AutoScroll = false;
		bh.AutoScrollMargin = new Size(0, 0);
		bh.AutoScrollMinSize = new Size(0, 0);
		bh.AutoScrollPosition = new Point(0, 0);
		bh.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bh.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bh.Location = new Point(262, 50);
		bh.MaxLength = 8;
		bh.Name = "txttransport4";
		bh.Numeric = true;
		bh.RightToLeft = RightToLeft.Yes;
		bh.Size = new Size(57, 21);
		bh.TabIndex = 64;
		bh.Tag = "";
		bh.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bh.Leave += u;
		bh.KeyUp += r;
		bh.Enter += t;
		bi.AutoScroll = false;
		bi.AutoScrollMargin = new Size(0, 0);
		bi.AutoScrollMinSize = new Size(0, 0);
		bi.AutoScrollPosition = new Point(0, 0);
		bi.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bi.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		bi.Location = new Point(262, 23);
		bi.MaxLength = 8;
		bi.Name = "txttransport1";
		bi.Numeric = true;
		bi.RightToLeft = RightToLeft.Yes;
		bi.Size = new Size(57, 21);
		bi.TabIndex = 61;
		bi.Tag = "";
		bi.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		bi.Leave += u;
		bi.KeyUp += u;
		bi.Enter += t;
		a7.AutoScroll = false;
		a7.AutoScrollMargin = new Size(0, 0);
		a7.AutoScrollMinSize = new Size(0, 0);
		a7.AutoScrollPosition = new Point(0, 0);
		a7.Enabled = false;
		a7.Location = new Point(606, 475);
		a7.MaxLength = 10;
		a7.Name = "txtSumtransport";
		a7.Numeric = true;
		a7.RightToLeft = RightToLeft.Yes;
		a7.Size = new Size(80, 23);
		a7.TabIndex = 38;
		a7.Tag = "";
		a7.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a7.Leave += u;
		a7.KeyUp += c;
		a7.Enter += t;
		a8.AutoSize = true;
		a8.Location = new Point(688, 477);
		a8.Name = "label17";
		a8.Size = new Size(107, 16);
		a8.TabIndex = 115;
		a8.Text = "مجموع ترانسپورت";
		a5.AutoScroll = false;
		a5.AutoScrollMargin = new Size(0, 0);
		a5.AutoScrollMinSize = new Size(0, 0);
		a5.AutoScrollPosition = new Point(0, 0);
		a5.Enabled = false;
		a5.Location = new Point(231, 472);
		a5.MaxLength = 10;
		a5.Name = "txtSumFee";
		a5.Numeric = true;
		a5.RightToLeft = RightToLeft.Yes;
		a5.Size = new Size(76, 23);
		a5.TabIndex = 114;
		a5.Tag = "";
		a5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a5.Leave += u;
		a5.KeyUp += b;
		a5.Enter += t;
		a6.AutoSize = true;
		a6.Location = new Point(314, 476);
		a6.Name = "label16";
		a6.Size = new Size(75, 16);
		a6.TabIndex = 113;
		a6.Text = "فیس سالانه";
		a3.AutoSize = true;
		a3.Location = new Point(529, 438);
		a3.Name = "label20";
		a3.Size = new Size(27, 16);
		a3.TabIndex = 112;
		a3.Text = "پایه";
		a4.Location = new Point(395, 434);
		a4.Name = "dropPaye";
		a4.Size = new Size(130, 23);
		stringFormat8.Alignment = StringAlignment.Near;
		stringFormat8.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat8.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat8.LineAlignment = StringAlignment.Center;
		stringFormat8.Trimming = StringTrimming.Character;
		a4.StringFormat = stringFormat8;
		a4.TabIndex = 36;
		a4.SelectedIndexChanged += ar;
		a2.AutoSize = true;
		a2.Location = new Point(697, 435);
		a2.Name = "label3";
		a2.Size = new Size(78, 16);
		a2.TabIndex = 110;
		a2.Text = "سال تعلیمی";
		a1.AutoSize = true;
		a1.Location = new Point(120, 395);
		a1.Name = "label13";
		a1.Size = new Size(65, 16);
		a1.TabIndex = 24;
		a1.Text = "تاریخ خروج";
		ay.AutoSize = true;
		ay.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ay.Location = new Point(722, 294);
		ay.Name = "label12";
		ay.Size = new Size(75, 14);
		ay.TabIndex = 107;
		ay.Text = "تاریخ شمولیت";
		az.AutoScroll = false;
		az.AutoScrollMargin = new Size(0, 0);
		az.AutoScrollMinSize = new Size(0, 0);
		az.AutoScrollPosition = new Point(0, 0);
		az.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		az.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		az.Location = new Point(583, 288);
		az.Mask = "0000/00/00";
		az.MaxLength = 12;
		az.Name = "txtRegDate";
		az.Numeric = true;
		az.RightToLeft = RightToLeft.No;
		az.Size = new Size(135, 26);
		az.TabIndex = 16;
		az.Tag = "";
		az.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		az.Leave += x;
		az.Enter += t;
		a0.AutoScroll = false;
		a0.AutoScrollMargin = new Size(0, 0);
		a0.AutoScrollMinSize = new Size(0, 0);
		a0.AutoScrollPosition = new Point(0, 0);
		a0.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		a0.Location = new Point(7, 392);
		a0.Mask = "0000/00/00";
		a0.MaxLength = 12;
		a0.Name = "txtExitDate";
		a0.Numeric = true;
		a0.RightToLeft = RightToLeft.No;
		a0.Size = new Size(108, 26);
		a0.TabIndex = 100;
		a0.Tag = "";
		a0.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		a0.Leave += u;
		a0.Enter += t;
		ax.AutoSize = true;
		ax.Checked = true;
		ax.CheckState = CheckState.Checked;
		ax.Location = new Point(379, 393);
		ax.Name = "checkmali";
		ax.Size = new Size(94, 20);
		ax.TabIndex = 35;
		ax.Text = "لیست مالی";
		ax.UseVisualStyleBackColor = true;
		ax.Leave += w;
		ax.Enter += v;
		this.m_av.AutoSize = true;
		this.m_av.Checked = true;
		this.m_av.CheckState = CheckState.Checked;
		this.m_av.Location = new Point(515, 393);
		this.m_av.Name = "checkhazer";
		this.m_av.Size = new Size(193, 20);
		this.m_av.TabIndex = 34;
		this.m_av.Text = "حاضر در صنف(رسمی و موقت)";
		this.m_av.UseVisualStyleBackColor = true;
		this.m_av.Leave += w;
		this.m_av.Enter += v;
		this.m_aw.AutoSize = true;
		this.m_aw.Checked = true;
		this.m_aw.CheckState = CheckState.Checked;
		this.m_aw.Location = new Point(737, 393);
		this.m_aw.Name = "checkshaghe";
		this.m_aw.Size = new Size(54, 20);
		this.m_aw.TabIndex = 33;
		this.m_aw.Text = "شقه";
		this.m_aw.UseVisualStyleBackColor = true;
		this.m_aw.Leave += w;
		this.m_aw.Enter += v;
		this.m_au.AutoSize = true;
		this.m_au.Location = new Point(89, 363);
		this.m_au.Name = "checkmaghnae";
		this.m_au.Size = new Size(59, 20);
		this.m_au.TabIndex = 32;
		this.m_au.Text = "مقنعه";
		this.m_au.UseVisualStyleBackColor = true;
		this.m_au.Leave += w;
		this.m_au.Enter += v;
		this.m_aq.AutoSize = true;
		this.m_aq.Location = new Point(174, 363);
		this.m_aq.Name = "checkrobotic";
		this.m_aq.Size = new Size(62, 20);
		this.m_aq.TabIndex = 31;
		this.m_aq.Text = "رباتیک";
		this.m_aq.UseVisualStyleBackColor = true;
		this.m_aq.Leave += w;
		this.m_aq.Enter += v;
		this.m_ar.AutoSize = true;
		this.m_ar.Location = new Point(276, 363);
		this.m_ar.Name = "checktransport";
		this.m_ar.Size = new Size(84, 20);
		this.m_ar.TabIndex = 30;
		this.m_ar.Text = "ترانسپورت";
		this.m_ar.UseVisualStyleBackColor = true;
		this.m_ar.Leave += w;
		this.m_ar.Enter += v;
		this.m_ar.CheckedChanged += l;
		this.m_as.AutoSize = true;
		this.m_as.Location = new Point(420, 363);
		this.m_as.Name = "checkketab";
		this.m_as.Size = new Size(53, 20);
		this.m_as.TabIndex = 29;
		this.m_as.Text = "کتاب";
		this.m_as.UseVisualStyleBackColor = true;
		this.m_as.Leave += w;
		this.m_as.Enter += v;
		this.m_at.AutoSize = true;
		this.m_at.Location = new Point(511, 363);
		this.m_at.Name = "checkkomakdarsi";
		this.m_at.Size = new Size(95, 20);
		this.m_at.TabIndex = 28;
		this.m_at.Text = "کمک درسی";
		this.m_at.UseVisualStyleBackColor = true;
		this.m_at.Leave += w;
		this.m_at.Enter += v;
		this.m_ao.AutoSize = true;
		this.m_ao.Location = new Point(636, 363);
		this.m_ao.Name = "checkuniform";
		this.m_ao.Size = new Size(72, 20);
		this.m_ao.TabIndex = 27;
		this.m_ao.Text = "یونیفورم";
		this.m_ao.UseVisualStyleBackColor = true;
		this.m_ao.Leave += w;
		this.m_ao.Enter += v;
		this.m_ap.AutoSize = true;
		this.m_ap.Location = new Point(733, 363);
		this.m_ap.Name = "checkdakhle";
		this.m_ap.Size = new Size(57, 20);
		this.m_ap.TabIndex = 26;
		this.m_ap.Text = "داخله";
		this.m_ap.UseVisualStyleBackColor = true;
		this.m_ap.Leave += w;
		this.m_ap.Enter += v;
		this.m_am.AutoScroll = false;
		this.m_am.AutoScrollMargin = new Size(0, 0);
		this.m_am.AutoScrollMinSize = new Size(0, 0);
		this.m_am.AutoScrollPosition = new Point(0, 0);
		this.m_am.Location = new Point(7, 326);
		this.m_am.Name = "txtAdress";
		this.m_am.Size = new Size(367, 23);
		this.m_am.TabIndex = 19;
		this.m_am.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_am.Leave += ap;
		this.m_am.Enter += ao;
		this.m_an.AutoSize = true;
		this.m_an.Location = new Point(376, 329);
		this.m_an.Name = "label11";
		this.m_an.Size = new Size(68, 16);
		this.m_an.TabIndex = 93;
		this.m_an.Text = "ادامه آدرس";
		this.m_al.AutoSize = true;
		this.m_al.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		this.m_al.Location = new Point(21, 158);
		this.m_al.Name = "panel3";
		this.m_al.Size = new Size(0, 0);
		this.m_al.TabIndex = 92;
		this.m_aj.AutoSize = true;
		this.m_aj.Location = new Point(495, 259);
		this.m_aj.Name = "label10";
		this.m_aj.Size = new Size(46, 16);
		this.m_aj.TabIndex = 91;
		this.m_aj.Text = "وضعیت";
		uIComboBoxItem26.FormatStyle.Alpha = 0;
		uIComboBoxItem26.Text = "برحال";
		uIComboBoxItem26.Value = "1";
		uIComboBoxItem27.FormatStyle.Alpha = 0;
		uIComboBoxItem27.Text = "محروم";
		uIComboBoxItem27.Value = "2";
		uIComboBoxItem28.FormatStyle.Alpha = 0;
		uIComboBoxItem28.Text = "منفک";
		uIComboBoxItem28.Value = "3";
		uIComboBoxItem29.FormatStyle.Alpha = 0;
		uIComboBoxItem29.Text = "معذرتی";
		uIComboBoxItem29.Value = "4";
		this.m_ai.Items.AddRange(new UIComboBoxItem[4] { uIComboBoxItem26, uIComboBoxItem27, uIComboBoxItem28, uIComboBoxItem29 });
		this.m_ai.Location = new Point(346, 255);
		this.m_ai.Name = "dropStatus";
		this.m_ai.Size = new Size(143, 23);
		stringFormat9.Alignment = StringAlignment.Near;
		stringFormat9.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat9.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat9.LineAlignment = StringAlignment.Center;
		stringFormat9.Trimming = StringTrimming.Character;
		this.m_ai.StringFormat = stringFormat9;
		this.m_ai.TabIndex = 15;
		this.m_ag.AutoSize = true;
		this.m_ag.Location = new Point(726, 218);
		this.m_ag.Name = "label9";
		this.m_ag.Size = new Size(57, 16);
		this.m_ag.TabIndex = 89;
		this.m_ag.Text = "کد متعلم";
		uIComboBoxItem30.FormatStyle.Alpha = 0;
		uIComboBoxItem30.Text = "";
		uIComboBoxItem30.Value = "-1";
		uIComboBoxItem31.FormatStyle.Alpha = 0;
		uIComboBoxItem31.Text = "شیعه";
		uIComboBoxItem31.Value = "1";
		uIComboBoxItem32.FormatStyle.Alpha = 0;
		uIComboBoxItem32.Text = "سنی";
		uIComboBoxItem32.Value = "2";
		this.m_ah.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem30, uIComboBoxItem31, uIComboBoxItem32 });
		this.m_ah.Location = new Point(577, 255);
		this.m_ah.Name = "dropMazhab";
		this.m_ah.Size = new Size(143, 23);
		stringFormat10.Alignment = StringAlignment.Near;
		stringFormat10.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat10.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat10.LineAlignment = StringAlignment.Center;
		stringFormat10.Trimming = StringTrimming.Character;
		this.m_ah.StringFormat = stringFormat10;
		this.m_ah.TabIndex = 14;
		this.m_af.AutoSize = true;
		this.m_af.Location = new Point(726, 258);
		this.m_af.Name = "label6";
		this.m_af.Size = new Size(76, 16);
		this.m_af.TabIndex = 87;
		this.m_af.Text = "دین / مذهب";
		this.m_ae.AutoScroll = false;
		this.m_ae.AutoScrollMargin = new Size(0, 0);
		this.m_ae.AutoScrollMinSize = new Size(0, 0);
		this.m_ae.AutoScrollPosition = new Point(0, 0);
		this.m_ae.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ae.Location = new Point(346, 215);
		this.m_ae.MaxLength = 9;
		this.m_ae.Name = "txtNumberAsas";
		this.m_ae.Numeric = true;
		this.m_ae.RightToLeft = RightToLeft.Yes;
		this.m_ae.Size = new Size(143, 23);
		this.m_ae.TabIndex = 12;
		this.m_ae.Tag = "";
		this.m_ae.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_ae.Leave += z;
		this.m_ae.Enter += y;
		uIComboBoxItem33.FormatStyle.Alpha = 0;
		uIComboBoxItem33.Text = "";
		uIComboBoxItem33.Value = "-1";
		uIComboBoxItem34.FormatStyle.Alpha = 0;
		uIComboBoxItem34.Text = "مرد";
		uIComboBoxItem34.Value = "1";
		uIComboBoxItem35.FormatStyle.Alpha = 0;
		uIComboBoxItem35.Text = "زن";
		uIComboBoxItem35.Value = "0";
		this.m_y.Items.AddRange(new UIComboBoxItem[3] { uIComboBoxItem33, uIComboBoxItem34, uIComboBoxItem35 });
		this.m_y.Location = new Point(174, 215);
		this.m_y.Name = "dropJens";
		this.m_y.Size = new Size(81, 23);
		stringFormat11.Alignment = StringAlignment.Near;
		stringFormat11.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat11.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat11.LineAlignment = StringAlignment.Center;
		stringFormat11.Trimming = StringTrimming.Character;
		this.m_y.StringFormat = stringFormat11;
		this.m_y.TabIndex = 13;
		this.m_y.SelectedIndexChanged += aq;
		this.m_z.AutoSize = true;
		this.m_z.Location = new Point(258, 219);
		this.m_z.Name = "label5";
		this.m_z.Size = new Size(53, 16);
		this.m_z.TabIndex = 83;
		this.m_z.Text = "جنیست";
		this.m_aa.AutoScroll = false;
		this.m_aa.AutoScrollMargin = new Size(0, 0);
		this.m_aa.AutoScrollMinSize = new Size(0, 0);
		this.m_aa.AutoScrollPosition = new Point(0, 0);
		this.m_aa.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_aa.Location = new Point(7, 291);
		this.m_aa.MaxLength = 200;
		this.m_aa.Name = "txtSh_sh";
		this.m_aa.RightToLeft = RightToLeft.Yes;
		this.m_aa.Size = new Size(479, 23);
		this.m_aa.TabIndex = 17;
		this.m_aa.Tag = "";
		this.m_aa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_aa.Leave += ab;
		this.m_aa.Enter += aa;
		this.m_ab.AutoSize = true;
		this.m_ab.Location = new Point(488, 295);
		this.m_ab.Name = "label4";
		this.m_ab.Size = new Size(58, 16);
		this.m_ab.TabIndex = 81;
		this.m_ab.Text = "نمبرتذکره";
		this.m_ac.AutoSize = true;
		this.m_ac.Location = new Point(502, 181);
		this.m_ac.Name = "label2";
		this.m_ac.Size = new Size(54, 16);
		this.m_ac.TabIndex = 80;
		this.m_ac.Text = "تلفن پدر";
		this.m_ad.AutoScroll = false;
		this.m_ad.AutoScrollMargin = new Size(0, 0);
		this.m_ad.AutoScrollMinSize = new Size(0, 0);
		this.m_ad.AutoScrollPosition = new Point(0, 0);
		this.m_ad.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_ad.Location = new Point(579, 174);
		this.m_ad.MaxLength = 12;
		this.m_ad.Name = "txtNumberTelegram";
		this.m_ad.Numeric = true;
		this.m_ad.RightToLeft = RightToLeft.Yes;
		this.m_ad.Size = new Size(140, 23);
		this.m_ad.TabIndex = 8;
		this.m_ad.Tag = "";
		this.m_ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_ad.Leave += ah;
		this.m_ad.Enter += ag;
		this.m_n.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_n.Location = new Point(20, 149);
		this.m_n.Name = "btnDeletePic";
		this.m_n.Size = new Size(75, 23);
		this.m_n.TabIndex = 21;
		this.m_n.Text = "حذف عکس";
		this.m_n.Click += at;
		this.m_j.AutoSize = true;
		this.m_j.Location = new Point(261, 181);
		this.m_j.Name = "label15";
		this.m_j.Size = new Size(60, 16);
		this.m_j.TabIndex = 78;
		this.m_j.Text = "تلفن مادر";
		this.m_o.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_o.Location = new Point(20, 121);
		this.m_o.Name = "btnPic";
		this.m_o.Size = new Size(75, 23);
		this.m_o.TabIndex = 20;
		this.m_o.Text = "انتخاب عکس";
		this.m_o.Click += au;
		this.m_p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_p.Location = new Point(3, 2);
		this.m_p.Name = "pictureBox1";
		this.m_p.Size = new Size(96, 115);
		this.m_p.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_p.TabIndex = 70;
		this.m_p.TabStop = false;
		this.m_p.Tag = "";
		this.m_k.AutoSize = true;
		this.m_k.Location = new Point(724, 177);
		this.m_k.Name = "label14";
		this.m_k.Size = new Size(62, 16);
		this.m_k.TabIndex = 77;
		this.m_k.Text = "نمبرتلگرام";
		this.m_l.AutoScroll = false;
		this.m_l.AutoScrollMargin = new Size(0, 0);
		this.m_l.AutoScrollMinSize = new Size(0, 0);
		this.m_l.AutoScrollPosition = new Point(0, 0);
		this.m_l.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(346, 177);
		this.m_l.MaxLength = 11;
		this.m_l.Name = "txtMobileFather";
		this.m_l.Numeric = true;
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.Size = new Size(143, 23);
		this.m_l.TabIndex = 9;
		this.m_l.Tag = "";
		this.m_l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_l.Leave += af;
		this.m_l.Enter += ae;
		this.m_m.AutoScroll = false;
		this.m_m.AutoScrollMargin = new Size(0, 0);
		this.m_m.AutoScrollMinSize = new Size(0, 0);
		this.m_m.AutoScrollPosition = new Point(0, 0);
		this.m_m.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_m.Location = new Point(112, 177);
		this.m_m.MaxLength = 11;
		this.m_m.Name = "txtMobileMother";
		this.m_m.Numeric = true;
		this.m_m.RightToLeft = RightToLeft.Yes;
		this.m_m.Size = new Size(143, 23);
		this.m_m.TabIndex = 10;
		this.m_m.Tag = "";
		this.m_m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_m.Leave += ad;
		this.m_m.Enter += ac;
		this.m_q.AutoScroll = false;
		this.m_q.AutoScrollMargin = new Size(0, 0);
		this.m_q.AutoScrollMinSize = new Size(0, 0);
		this.m_q.AutoScrollPosition = new Point(0, 0);
		this.m_q.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_q.Location = new Point(577, 215);
		this.m_q.MaxLength = 12;
		this.m_q.Name = "txtCode";
		this.m_q.Numeric = true;
		this.m_q.RightToLeft = RightToLeft.Yes;
		this.m_q.Size = new Size(143, 23);
		this.m_q.TabIndex = 11;
		this.m_q.Tag = "";
		this.m_q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_q.Leave += u;
		this.m_q.Enter += t;
		this.m_r.AutoSize = true;
		this.m_r.Location = new Point(492, 218);
		this.m_r.Name = "labl";
		this.m_r.Size = new Size(70, 16);
		this.m_r.TabIndex = 33;
		this.m_r.Text = "نمبر اساس";
		this.m_x.AutoSize = true;
		this.m_x.Location = new Point(724, 65);
		this.m_x.Name = "label1";
		this.m_x.Size = new Size(24, 16);
		this.m_x.TabIndex = 1;
		this.m_x.Text = "نام";
		this.m_s.AutoScroll = false;
		this.m_s.AutoScrollMargin = new Size(0, 0);
		this.m_s.AutoScrollMinSize = new Size(0, 0);
		this.m_s.AutoScrollPosition = new Point(0, 0);
		this.m_s.Location = new Point(584, 97);
		this.m_s.Name = "txtNamP";
		this.m_s.Size = new Size(135, 23);
		this.m_s.TabIndex = 3;
		this.m_s.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_s.Leave += aj;
		this.m_s.Enter += ai;
		this.m_w.AutoScroll = false;
		this.m_w.AutoScrollMargin = new Size(0, 0);
		this.m_w.AutoScrollMinSize = new Size(0, 0);
		this.m_w.AutoScrollPosition = new Point(0, 0);
		this.m_w.Location = new Point(584, 62);
		this.m_w.Name = "txtNamF";
		this.m_w.Size = new Size(135, 23);
		this.m_w.TabIndex = 0;
		this.m_w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_w.Leave += an;
		this.m_w.Enter += am;
		this.m_t.AutoSize = true;
		this.m_t.Location = new Point(724, 100);
		this.m_t.Name = "label8";
		this.m_t.Size = new Size(40, 16);
		this.m_t.TabIndex = 20;
		this.m_t.Text = "ولدیت";
		this.m_v.AutoSize = true;
		this.m_v.Location = new Point(261, 65);
		this.m_v.Name = "label7";
		this.m_v.Size = new Size(58, 16);
		this.m_v.TabIndex = 18;
		this.m_v.Text = "ولد / بنت";
		this.m_u.AutoScroll = false;
		this.m_u.AutoScrollMargin = new Size(0, 0);
		this.m_u.AutoScrollMinSize = new Size(0, 0);
		this.m_u.AutoScrollPosition = new Point(0, 0);
		this.m_u.Location = new Point(112, 62);
		this.m_u.Name = "txtNamL";
		this.m_u.Size = new Size(143, 23);
		this.m_u.TabIndex = 2;
		this.m_u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_u.Leave += al;
		this.m_u.Enter += ak;
		this.m_i.BackColor = Color.Black;
		this.m_i.Controls.Add(this.m_h);
		this.m_i.Dock = DockStyle.Fill;
		this.m_i.Location = new Point(0, 0);
		this.m_i.Name = "panel2";
		this.m_i.Size = new Size(831, 700);
		this.m_i.TabIndex = 35;
		this.m_ak.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_ak.Title = "انتخاب عکس شاگرد";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.LightSteelBlue;
		ClientSize = new Size(831, 700);
		Controls.Add(this.m_i);
		Font = new Font("Tahoma", 8.25f);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSabtenam";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نام ";
		Load += aw;
		KeyUp += a;
		KeyDown += v;
		this.m_h.ResumeLayout(performLayout: false);
		this.m_h.PerformLayout();
		co.ResumeLayout(performLayout: false);
		ci.ResumeLayout(performLayout: false);
		ci.PerformLayout();
		((ISupportInitialize)bp).EndInit();
		bp.ResumeLayout(performLayout: false);
		bp.PerformLayout();
		((ISupportInitialize)a9).EndInit();
		a9.ResumeLayout(performLayout: false);
		a9.PerformLayout();
		((ISupportInitialize)this.m_p).EndInit();
		this.m_i.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
