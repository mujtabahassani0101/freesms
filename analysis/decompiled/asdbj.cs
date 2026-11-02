using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdbj : Form
{
	private int m_a = 0;

	private int m_b = 0;

	private IContainer m_c = null;

	private GridEX m_d;

	private Panel m_e;

	private UIGroupBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private Label m_i;

	private UIComboBox m_j;

	private Label k;

	private Label l;

	private EditBox m;

	private EditBox n;

	private UIButton o;

	private DatePicker p;

	private DatePicker q;

	private Label r;

	private Label s;

	private Label t;

	private UIButton u;

	private UIButton v;

	private Panel w;

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private Panel af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private Label al;

	private Label am;

	private TextBox an;

	private Button ao;

	public asdbj()
	{
		a();
	}

	private void j(object A_0, EventArgs A_1)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = asdaj.a("5");
			if (true)
			{
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 2;
						continue;
					}
					d();
					e();
					c();
					DateTime the_date = DateTime.Now.AddDays(-7.0);
					q.the_date = the_date;
					num = 0;
					continue;
				}
				case 0:
					return;
				case 2:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") order by id");
			this.m_h.Items.Add("کل", (object)"0");
			int num = 0;
			if (true)
			{
			}
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 2;
					continue;
				case 2:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					this.m_h.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 3;
					continue;
				case 0:
					this.m_h.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			string text = " where  xYear=" + asdaj.a + " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_h.SelectedIndex <= 0;
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
					goto case 1;
				case 0:
					text = text + " and xPaye=" + this.m_h.SelectedValue.ToString();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,N'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass " + text);
					this.m_j.DataSource = dataSource;
					this.m_j.DisplayMember = "Name";
					this.m_j.ValueMember = "id";
					this.m_j.SelectedIndex = 0;
					return;
				}
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			this.m_b = this.m_a;
			string text = " tYear_Student.xYear=" + asdaj.a + " and tYear_Student.xPaye in(" + asdaj.n + ") and  dateTosend>=N'" + ShamsiDate.GetShamsiDate(q.the_date) + "' and dateTosend<=N'" + ShamsiDate.GetShamsiDate(p.the_date) + "'";
			bool flag = this.m_j.SelectedIndex <= 0;
			int num = 17;
			while (true)
			{
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 5;
				case 0:
					flag = !(((Control)m).Text.Trim() != "");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 1;
				case 25:
					text += " and ";
					num = 7;
					continue;
				case 5:
					flag = this.m_h.SelectedIndex <= 0;
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 8;
				case 6:
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)m).Text) + "%'";
					num = 1;
					continue;
				case 11:
					text += " and ";
					num = 23;
					continue;
				case 22:
					flag = !(text != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 6;
				case 1:
					flag = !(text != "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 4;
				case 8:
					flag = !(((Control)n).Text.Trim() != "");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 0;
				case 20:
					flag = !(text != "");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto case 24;
				case 10:
					text += " and ";
					num = 6;
					continue;
				case 26:
					text = " where " + text;
					num = 4;
					continue;
				case 19:
					text += " and ";
					num = 24;
					continue;
				case 16:
					flag = !(text != "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 23;
				case 23:
					text = text + " tYear_Student.xClass=" + this.m_j.SelectedValue.ToString();
					num = 5;
					continue;
				case 24:
					if (true)
					{
					}
					text = text + " tYear_Student.xPaye=" + this.m_h.SelectedValue.ToString();
					num = 8;
					continue;
				case 14:
					flag = !(text != "");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 25;
						continue;
					}
					goto case 7;
				case 7:
					text = text + " tYear_Student.FName like '%" + asdaj.b(((Control)n).Text) + "%'";
					num = 0;
					continue;
				case 4:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tTelegramMessage.id, tTelegramMessage.typMsg,tTelegramTypeMessage.name as TypeMessage, tTelegramMessage.xStudent, tTelegramMessage.sentTo, tTelegramMessage.dateTosend, \r\n                      tTelegramMessage.TimeTosend, tTelegramMessage.dateSend, tTelegramMessage.TimeSend, tTelegramMessage.isSend, \r\n                      tStudent.FName, tStudent.LName, tClass.name AS Class, tPaye.Name AS Paye\r\n                      , case  when tTelegramMessage.sentTo=1  and tTelegramMessage.xStudent>0 then N'پدر ' + tStudent.FName+N' '+ tStudent.LName\r\n                           when tTelegramMessage.sentTo= 2 and tTelegramMessage.xStudent>0 then N'مادر ' + tStudent.FName+N' '+ tStudent.LName\r\n                          when tTelegramMessage.xStudent= 0 then N'ارسال تستی'  end as std\r\n                      , case tTelegramMessage.sentTo  when 1  then  tStudent.MobileFather  when 2 then tStudent.MobileMother end as Mobil\r\n                       ,case tTelegramMessage.isSend when 1 then N'ارسال شد' end as status,dbo.ReturnStatusJoinTelegram(tStudent.id,tTelegramMessage.sentTo) as sendmobil\r\n                        FROM         tTelegramMessage  left OUTER JOIN \r\n                      tStudent ON   tTelegramMessage.xStudent=tStudent.id  left OUTER JOIN \r\n                    tYear_Student ON tStudent.id=tYear_Student.xStudent left OUTER JOIN \r\n                      tPaye  ON  tYear_Student.xPaye=  tPaye.id  left OUTER JOIN \r\n                      tClass ON tYear_Student.xClass = tClass.id INNER JOIN\r\n                     tTelegramTypeMessage on tTelegramMessage.typMsg=tTelegramTypeMessage.id" + text);
					this.m_d.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		c();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		c();
	}

	private void h(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_h.SelectedIndex = 0;
		this.m_j.SelectedIndex = 0;
		((Control)m).Text = "";
		((Control)n).Text = "";
		c();
	}

	private void g(object A_0, EventArgs A_1)
	{
		c();
	}

	private void f(object A_0, EventArgs A_1)
	{
		this.m_a = this.m_d.Row;
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c(object A_0, EventArgs A_1)
	{
		c();
	}

	private void b()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		try
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
						num = ((this.m_d.RowCount <= 0) ? 2 : 4);
						continue;
					case 4:
						if (true)
						{
						}
						num = 0;
						continue;
					case 2:
						num2 = 1;
						goto IL_02fa;
					case 0:
						num2 = (((int)this.m_d.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_02fa;
					case 6:
						((Control)ae).Text = this.m_d.SelectedItems[0].GetRow().Cells["Status"].Value.ToString();
						((Control)al).Text = this.m_d.SelectedItems[0].GetRow().Cells["std"].Value.ToString();
						((Control)ag).Text = this.m_d.SelectedItems[0].GetRow().Cells["TimeSend"].Value.ToString();
						((Control)ah).Text = this.m_d.SelectedItems[0].GetRow().Cells["TimeTosend"].Value.ToString();
						((Control)ak).Text = this.m_d.SelectedItems[0].GetRow().Cells["TypeMessage"].Value.ToString();
						((Control)ai).Text = this.m_d.SelectedItems[0].GetRow().Cells["dateSend"].Value.ToString();
						((Control)aj).Text = this.m_d.SelectedItems[0].GetRow().Cells["dateTosend"].Value.ToString();
						((Control)an).Text = asdcb.a(asdab.e(), CommandType.Text, "SELECT Message FROM  tTelegramMessage where id=" + this.m_d.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
						((Control)an).Text = ((Control)an).Text.Replace("\ud83d\udd39", "");
						((Control)w).Visible = true;
						num = 3;
						continue;
					case 5:
						if (flag)
						{
							((Control)w).Visible = false;
							num = 8;
						}
						else
						{
							num = 6;
						}
						continue;
					case 3:
					case 8:
						num = 7;
						continue;
					case 7:
						return;
						IL_02fa:
						flag = (byte)num2 != 0;
						num = 5;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
			((Control)ae).Text = "";
			((Control)al).Text = "";
			((Control)ag).Text = "";
			((Control)ah).Text = "";
			((Control)ak).Text = "";
			((Control)ai).Text = "";
			((Control)aj).Text = "";
			((Control)an).Text = "";
			((Control)w).Visible = true;
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)w).Visible = false;
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
					num = ((!A_0) ? 6 : 2);
					continue;
				case 2:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_c == null) ? 1 : 0);
					goto IL_0074;
				case 4:
					this.m_c.Dispose();
					num = 5;
					continue;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 6:
					num2 = 1;
					goto IL_0074;
				case 5:
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
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eec: Expected Obj, but got Unknown
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Expected Obj, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected Obj, but got Unknown
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected Obj, but got Unknown
		//IL_12a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Expected Obj, but got Unknown
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_137d: Expected Obj, but got Unknown
		//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Expected Obj, but got Unknown
		//IL_16be: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Expected Obj, but got Unknown
		//IL_173b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Expected Obj, but got Unknown
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b7: Expected Obj, but got Unknown
		//IL_182d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected Obj, but got Unknown
		//IL_18e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ec: Expected Obj, but got Unknown
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Expected Obj, but got Unknown
		//IL_1a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5b: Expected Obj, but got Unknown
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbj));
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		this.m_d = new GridEX();
		this.m_e = new Panel();
		w = new Panel();
		af = new Panel();
		ao = new Button();
		am = new Label();
		an = new TextBox();
		al = new Label();
		ag = new Label();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		aa = new Label();
		ae = new Label();
		z = new Label();
		ab = new Label();
		y = new Label();
		ac = new Label();
		x = new Label();
		ad = new Label();
		v = new UIButton();
		u = new UIButton();
		r = new Label();
		s = new Label();
		t = new Label();
		p = new DatePicker();
		q = new DatePicker();
		this.m_f = new UIGroupBox();
		o = new UIButton();
		k = new Label();
		l = new Label();
		m = new EditBox();
		n = new EditBox();
		this.m_i = new Label();
		this.m_j = new UIComboBox();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_e).SuspendLayout();
		((Control)w).SuspendLayout();
		((Control)af).SuspendLayout();
		((ISupportInitialize)this.m_f).BeginInit();
		((Control)this.m_f).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_d.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_d).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_d.DesignTimeLayout = val;
		this.m_d.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_d).Font = new Font("Tahoma", 6.75f);
		this.m_d.GroupByBoxVisible = false;
		((Control)this.m_d).Location = new Point(9, 127);
		((Control)this.m_d).Name = "gridEX1";
		((ScrollableBase)this.m_d).RecordNavigator = true;
		this.m_d.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_d).Size = new Size(777, 408);
		((Control)this.m_d).TabIndex = 5;
		((ScrollableBase)this.m_d).VisualStyle = (VisualStyle)2;
		this.m_d.SelectionChanged += f;
		((Control)this.m_e).BackColor = SystemColors.GradientInactiveCaption;
		this.m_e.BorderStyle = (BorderStyle)1;
		((Control)this.m_e).Controls.Add((Control)(object)w);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_e).Controls.Add((Control)(object)v);
		((Control)this.m_e).Controls.Add((Control)(object)u);
		((Control)this.m_e).Controls.Add((Control)(object)r);
		((Control)this.m_e).Controls.Add((Control)(object)s);
		((Control)this.m_e).Controls.Add((Control)(object)t);
		((Control)this.m_e).Controls.Add((Control)(object)p);
		((Control)this.m_e).Controls.Add((Control)(object)q);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_e).Location = new Point(3, 3);
		((Control)this.m_e).Name = "panel1";
		((Control)this.m_e).Size = new Size(794, 593);
		((Control)this.m_e).TabIndex = 0;
		((Control)w).BackColor = SystemColors.ControlText;
		w.BorderStyle = (BorderStyle)1;
		((Control)w).Controls.Add((Control)(object)af);
		((Control)w).Location = new Point(111, 31);
		((Control)w).Name = "pMessage";
		((Control)w).Size = new Size(575, 459);
		((Control)w).TabIndex = 26;
		((Control)w).Visible = false;
		((Control)af).BackColor = SystemColors.GradientInactiveCaption;
		af.BorderStyle = (BorderStyle)2;
		((Control)af).Controls.Add((Control)(object)ao);
		((Control)af).Controls.Add((Control)(object)am);
		((Control)af).Controls.Add((Control)(object)an);
		((Control)af).Controls.Add((Control)(object)al);
		((Control)af).Controls.Add((Control)(object)ag);
		((Control)af).Controls.Add((Control)(object)ah);
		((Control)af).Controls.Add((Control)(object)ai);
		((Control)af).Controls.Add((Control)(object)aj);
		((Control)af).Controls.Add((Control)(object)ak);
		((Control)af).Controls.Add((Control)(object)aa);
		((Control)af).Controls.Add((Control)(object)ae);
		((Control)af).Controls.Add((Control)(object)z);
		((Control)af).Controls.Add((Control)(object)ab);
		((Control)af).Controls.Add((Control)(object)y);
		((Control)af).Controls.Add((Control)(object)ac);
		((Control)af).Controls.Add((Control)(object)x);
		((Control)af).Controls.Add((Control)(object)ad);
		((Control)af).Location = new Point(3, 2);
		((Control)af).Name = "panel3";
		((Control)af).RightToLeft = (RightToLeft)1;
		((Control)af).Size = new Size(566, 451);
		((Control)af).TabIndex = 31;
		((Control)ao).Location = new Point(7, 421);
		((Control)ao).Name = "btnCancelViewMessage";
		((Control)ao).Size = new Size(75, 23);
		((Control)ao).TabIndex = 40;
		((Control)ao).Text = "بستن";
		((ButtonBase)ao).UseVisualStyleBackColor = true;
		((Control)ao).Click += a;
		((Control)am).AutoSize = true;
		((Control)am).Location = new Point(449, 163);
		((Control)am).Name = "label22";
		((Control)am).Size = new Size(45, 13);
		((Control)am).TabIndex = 37;
		((Control)am).Text = "متن پیام";
		((Control)an).Location = new Point(7, 159);
		((TextBoxBase)an).Multiline = true;
		((Control)an).Name = "txtMessage";
		((Control)an).RightToLeft = (RightToLeft)0;
		an.ScrollBars = (ScrollBars)2;
		((Control)an).Size = new Size(435, 242);
		((Control)an).TabIndex = 36;
		an.TextAlign = (HorizontalAlignment)1;
		((Control)al).BackColor = SystemColors.ButtonFace;
		al.BorderStyle = (BorderStyle)1;
		((Control)al).Location = new Point(282, 123);
		((Control)al).Name = "lstd";
		((Control)al).Size = new Size(161, 23);
		((Control)al).TabIndex = 35;
		al.TextAlign = (ContentAlignment)16;
		((Control)ag).BackColor = SystemColors.ButtonFace;
		ag.BorderStyle = (BorderStyle)1;
		((Control)ag).Location = new Point(7, 85);
		((Control)ag).Name = "lTimeSend";
		((Control)ag).Size = new Size(141, 23);
		((Control)ag).TabIndex = 34;
		ag.TextAlign = (ContentAlignment)16;
		((Control)ah).BackColor = SystemColors.ButtonFace;
		ah.BorderStyle = (BorderStyle)1;
		((Control)ah).Location = new Point(7, 54);
		((Control)ah).Name = "lTimeTosend";
		((Control)ah).Size = new Size(141, 23);
		((Control)ah).TabIndex = 33;
		ah.TextAlign = (ContentAlignment)16;
		((Control)ai).BackColor = SystemColors.ButtonFace;
		ai.BorderStyle = (BorderStyle)1;
		((Control)ai).Location = new Point(282, 88);
		((Control)ai).Name = "ldateSend";
		((Control)ai).Size = new Size(161, 23);
		((Control)ai).TabIndex = 32;
		ai.TextAlign = (ContentAlignment)16;
		((Control)aj).BackColor = SystemColors.ButtonFace;
		aj.BorderStyle = (BorderStyle)1;
		((Control)aj).Location = new Point(282, 55);
		((Control)aj).Name = "ldateTosend";
		((Control)aj).Size = new Size(160, 23);
		((Control)aj).TabIndex = 31;
		aj.TextAlign = (ContentAlignment)16;
		((Control)ak).BackColor = SystemColors.ButtonFace;
		ak.BorderStyle = (BorderStyle)1;
		((Control)ak).Location = new Point(7, 25);
		((Control)ak).Name = "lTypeMessage";
		((Control)ak).Size = new Size(141, 23);
		((Control)ak).TabIndex = 30;
		ak.TextAlign = (ContentAlignment)16;
		((Control)aa).AutoSize = true;
		((Control)aa).Location = new Point(448, 59);
		((Control)aa).Name = "label6";
		((Control)aa).Size = new Size(112, 13);
		((Control)aa).TabIndex = 22;
		((Control)aa).Text = "تاریخ ارسال توسط کاربر";
		((Control)ae).BackColor = SystemColors.ButtonFace;
		ae.BorderStyle = (BorderStyle)1;
		((Control)ae).Location = new Point(282, 25);
		((Control)ae).Name = "lStatus";
		((Control)ae).Size = new Size(161, 23);
		((Control)ae).TabIndex = 29;
		ae.TextAlign = (ContentAlignment)16;
		((Control)z).AutoSize = true;
		((Control)z).Location = new Point(154, 57);
		((Control)z).Name = "label7";
		((Control)z).Size = new Size(122, 13);
		((Control)z).TabIndex = 23;
		((Control)z).Text = "ساعت ارسال توسط کاربر";
		((Control)ab).AutoSize = true;
		((Control)ab).Location = new Point(453, 29);
		((Control)ab).Name = "label12";
		((Control)ab).Size = new Size(41, 13);
		((Control)ab).TabIndex = 28;
		((Control)ab).Text = "وضعیت";
		((Control)y).AutoSize = true;
		((Control)y).Location = new Point(448, 93);
		((Control)y).Name = "label9";
		((Control)y).Size = new Size(111, 13);
		((Control)y).TabIndex = 24;
		((Control)y).Text = "تاریخ ارسال توسط ربات";
		((Control)ac).AutoSize = true;
		((Control)ac).Location = new Point(168, 29);
		((Control)ac).Name = "label11";
		((Control)ac).Size = new Size(42, 13);
		((Control)ac).TabIndex = 27;
		((Control)ac).Text = "نوع پیام";
		((Control)x).AutoSize = true;
		((Control)x).Location = new Point(154, 90);
		((Control)x).Name = "label8";
		((Control)x).Size = new Size(121, 13);
		((Control)x).TabIndex = 25;
		((Control)x).Text = "ساعت ارسال توسط ربات";
		((Control)ad).AutoSize = true;
		((Control)ad).Location = new Point(452, 128);
		((Control)ad).Name = "label10";
		((Control)ad).Size = new Size(35, 13);
		((Control)ad).TabIndex = 26;
		((Control)ad).Text = "گیرنده";
		v.ButtonStyle = (ButtonStyle)1;
		((Control)v).Font = new Font("B Homa", 16f);
		v.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		v.ImageIndex = 8;
		v.ImageSize = new Size(20, 20);
		((Control)v).Location = new Point(569, 554);
		((Control)v).Name = "btnViewMessage";
		((Control)v).Size = new Size(221, 29);
		((Control)v).TabIndex = 25;
		((Control)v).Text = "مشاهده پیام";
		v.VisualStyle = (VisualStyle)1;
		((Control)v).Click += b;
		u.ButtonStyle = (ButtonStyle)1;
		((Control)u).Font = new Font("B Homa", 16f);
		u.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		u.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		u.ImageIndex = 8;
		u.ImageSize = new Size(20, 20);
		((Control)u).Location = new Point(20, 555);
		((Control)u).Name = "btnClose";
		((Control)u).Size = new Size(80, 29);
		((Control)u).TabIndex = 24;
		((Control)u).Text = "خروج";
		u.VisualStyle = (VisualStyle)1;
		((Control)u).Click += e;
		((Control)r).Font = new Font("Tahoma", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)r).Location = new Point(222, 0);
		((Control)r).Name = "label1";
		((Control)r).Size = new Size(354, 29);
		((Control)r).TabIndex = 23;
		((Control)r).Text = "لیست پیام های ارسال شده به تلگرام";
		((Control)s).AutoSize = true;
		((Control)s).Location = new Point(733, 96);
		((Control)s).Name = "label3";
		((Control)s).Size = new Size(37, 13);
		((Control)s).TabIndex = 22;
		((Control)s).Text = "تا تاریخ";
		((Control)t).AutoSize = true;
		((Control)t).Location = new Point(733, 44);
		((Control)t).Name = "label2";
		((Control)t).Size = new Size(38, 13);
		((Control)t).TabIndex = 21;
		((Control)t).Text = "از تاریخ";
		p.AutoToday = true;
		((Control)p).BackColor = Color.SeaShell;
		p.BijanForeColor = Color.Blue;
		((Control)p).Location = new Point(582, 89);
		((Control)p).Name = "txtDateTo";
		((Control)p).Size = new Size(144, 24);
		((Control)p).TabIndex = 19;
		p.the_date = new DateTime(2020, 8, 25, 14, 3, 21, 748);
		p.the_label = "ازمون تاريخ:";
		p.DateChanged += c;
		q.AutoToday = true;
		((Control)q).BackColor = Color.SeaShell;
		q.BijanForeColor = Color.Blue;
		((Control)q).Location = new Point(582, 40);
		((Control)q).Name = "txtDateFrom";
		((Control)q).Size = new Size(144, 24);
		((Control)q).TabIndex = 18;
		q.the_date = new DateTime(2020, 8, 25, 14, 3, 21, 752);
		q.the_label = "ازمون تاريخ:";
		q.DateChanged += d;
		((Control)this.m_f).Anchor = (AnchorStyles)13;
		((Control)this.m_f).Controls.Add((Control)(object)o);
		((Control)this.m_f).Controls.Add((Control)(object)k);
		((Control)this.m_f).Controls.Add((Control)(object)l);
		((Control)this.m_f).Controls.Add((Control)(object)m);
		((Control)this.m_f).Controls.Add((Control)(object)n);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_f).Location = new Point(11, 31);
		((Control)this.m_f).Name = "uiGroupBox1";
		((Control)this.m_f).Size = new Size(559, 88);
		((Control)this.m_f).TabIndex = 17;
		((Control)this.m_f).Text = "جستجو";
		((Control)o).Anchor = (AnchorStyles)9;
		o.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		o.ImageSize = new Size(25, 25);
		((Control)o).Location = new Point(3, 21);
		((Control)o).Name = "btnNoSearch";
		((Control)o).Size = new Size(85, 59);
		((Control)o).TabIndex = 6;
		((Control)o).Text = "حذف فیلترهای جستجو";
		((Control)o).Click += h;
		((Control)k).Anchor = (AnchorStyles)9;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(265, 26);
		((Control)k).Name = "label5";
		((Control)k).Size = new Size(65, 13);
		((Control)k).TabIndex = 29;
		((Control)k).Text = "نام خانوادگی";
		((Control)l).Anchor = (AnchorStyles)9;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(513, 26);
		((Control)l).Name = "label4";
		((Control)l).Size = new Size(20, 13);
		((Control)l).TabIndex = 28;
		((Control)l).Text = "نام";
		((Control)m).Anchor = (AnchorStyles)9;
		((EditBase)m).AutoScroll = false;
		((EditBase)m).AutoScrollMargin = new Size(0, 0);
		((EditBase)m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)m).AutoScrollPosition = new Point(0, 0);
		((Control)m).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)m).Location = new Point(106, 21);
		((Control)m).Name = "txtLName";
		((Control)m).RightToLeft = (RightToLeft)1;
		((Control)m).Size = new Size(153, 23);
		((Control)m).TabIndex = 4;
		((EditBase)m).TextAlignment = (TextAlignment)1;
		((Control)m).KeyUp += a;
		((Control)n).Anchor = (AnchorStyles)9;
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)n).Location = new Point(354, 21);
		((Control)n).Name = "txtFName";
		((Control)n).RightToLeft = (RightToLeft)1;
		((Control)n).Size = new Size(153, 23);
		((Control)n).TabIndex = 3;
		((EditBase)n).TextAlignment = (TextAlignment)1;
		((Control)n).KeyUp += a;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(266, 63);
		((Control)this.m_i).Name = "label19";
		((Control)this.m_i).Size = new Size(30, 13);
		((Control)this.m_i).TabIndex = 25;
		((Control)this.m_i).Text = "صنف";
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_j).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_j).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_j).Location = new Point(106, 57);
		((Control)this.m_j).Name = "dropCls";
		((Control)this.m_j).Size = new Size(153, 23);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_j).StringFormat = val2;
		((Control)this.m_j).TabIndex = 2;
		this.m_j.SelectedIndexChanged += g;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Location = new Point(510, 63);
		((Control)this.m_g).Name = "label20";
		((Control)this.m_g).Size = new Size(22, 13);
		((Control)this.m_g).TabIndex = 15;
		((Control)this.m_g).Text = "پایه";
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_h).Location = new Point(334, 57);
		((Control)this.m_h).Name = "dropPaye";
		((Control)this.m_h).Size = new Size(173, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val3;
		((Control)this.m_h).TabIndex = 1;
		this.m_h.SelectedIndexChanged += i;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = SystemColors.ActiveCaptionText;
		((Form)this).ClientSize = new Size(800, 600);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmlistTelegramMessage";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست شاگردان";
		((Form)this).Load += j;
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_e).ResumeLayout(false);
		((Control)this.m_e).PerformLayout();
		((Control)w).ResumeLayout(false);
		((Control)af).ResumeLayout(false);
		((Control)af).PerformLayout();
		((ISupportInitialize)this.m_f).EndInit();
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
