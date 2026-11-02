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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
			this.m_h.Items.Add("کل", "0");
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
					this.m_h.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
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
			string text = " where  xYear=" + asdaj.__field_a + " and xPaye in(" + asdaj.n + ")";
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
			string text = " tYear_Student.xYear=" + asdaj.__field_a + " and tYear_Student.xPaye in(" + asdaj.n + ") and  dateTosend>=N'" + ShamsiDate.GetShamsiDate(q.the_date) + "' and dateTosend<=N'" + ShamsiDate.GetShamsiDate(p.the_date) + "'";
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
					flag = !(m.Text.Trim() != "");
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
					text = text + " tstudent.LName like '%" + asdaj.b(m.Text) + "%'";
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
					flag = !(n.Text.Trim() != "");
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
					text = text + " tYear_Student.FName like '%" + asdaj.b(n.Text) + "%'";
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
		m.Text = "";
		n.Text = "";
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
		Close();
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
						num2 = ((this.m_d.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_02fa;
					case 6:
						ae.Text = this.m_d.SelectedItems[0].GetRow().Cells["Status"].Value.ToString();
						al.Text = this.m_d.SelectedItems[0].GetRow().Cells["std"].Value.ToString();
						ag.Text = this.m_d.SelectedItems[0].GetRow().Cells["TimeSend"].Value.ToString();
						ah.Text = this.m_d.SelectedItems[0].GetRow().Cells["TimeTosend"].Value.ToString();
						ak.Text = this.m_d.SelectedItems[0].GetRow().Cells["TypeMessage"].Value.ToString();
						ai.Text = this.m_d.SelectedItems[0].GetRow().Cells["dateSend"].Value.ToString();
						aj.Text = this.m_d.SelectedItems[0].GetRow().Cells["dateTosend"].Value.ToString();
						an.Text = asdcb.a(asdab.e(), CommandType.Text, "SELECT Message FROM  tTelegramMessage where id=" + this.m_d.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
						an.Text = an.Text.Replace("\ud83d\udd39", "");
						w.Visible = true;
						num = 3;
						continue;
					case 5:
						if (flag)
						{
							w.Visible = false;
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
			ae.Text = "";
			al.Text = "";
			ag.Text = "";
			ah.Text = "";
			ak.Text = "";
			ai.Text = "";
			aj.Text = "";
			an.Text = "";
			w.Visible = true;
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, EventArgs A_1)
	{
		w.Visible = false;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbj));
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
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
		this.m_e.SuspendLayout();
		w.SuspendLayout();
		af.SuspendLayout();
		((ISupportInitialize)this.m_f).BeginInit();
		this.m_f.SuspendLayout();
		SuspendLayout();
		this.m_d.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_d.DesignTimeLayout = gridEXLayout;
		this.m_d.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_d.Font = new Font("Tahoma", 6.75f);
		this.m_d.GroupByBoxVisible = false;
		this.m_d.Location = new Point(9, 127);
		this.m_d.Name = "gridEX1";
		this.m_d.RecordNavigator = true;
		this.m_d.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_d.Size = new Size(777, 408);
		this.m_d.TabIndex = 5;
		this.m_d.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.SelectionChanged += f;
		this.m_e.BackColor = SystemColors.GradientInactiveCaption;
		this.m_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_e.Controls.Add(w);
		this.m_e.Controls.Add(this.m_d);
		this.m_e.Controls.Add(v);
		this.m_e.Controls.Add(u);
		this.m_e.Controls.Add(r);
		this.m_e.Controls.Add(s);
		this.m_e.Controls.Add(t);
		this.m_e.Controls.Add(p);
		this.m_e.Controls.Add(q);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.Location = new Point(3, 3);
		this.m_e.Name = "panel1";
		this.m_e.Size = new Size(794, 593);
		this.m_e.TabIndex = 0;
		w.BackColor = SystemColors.ControlText;
		w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		w.Controls.Add(af);
		w.Location = new Point(111, 31);
		w.Name = "pMessage";
		w.Size = new Size(575, 459);
		w.TabIndex = 26;
		w.Visible = false;
		af.BackColor = SystemColors.GradientInactiveCaption;
		af.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		af.Controls.Add(ao);
		af.Controls.Add(am);
		af.Controls.Add(an);
		af.Controls.Add(al);
		af.Controls.Add(ag);
		af.Controls.Add(ah);
		af.Controls.Add(ai);
		af.Controls.Add(aj);
		af.Controls.Add(ak);
		af.Controls.Add(aa);
		af.Controls.Add(ae);
		af.Controls.Add(z);
		af.Controls.Add(ab);
		af.Controls.Add(y);
		af.Controls.Add(ac);
		af.Controls.Add(x);
		af.Controls.Add(ad);
		af.Location = new Point(3, 2);
		af.Name = "panel3";
		af.RightToLeft = RightToLeft.Yes;
		af.Size = new Size(566, 451);
		af.TabIndex = 31;
		ao.Location = new Point(7, 421);
		ao.Name = "btnCancelViewMessage";
		ao.Size = new Size(75, 23);
		ao.TabIndex = 40;
		ao.Text = "بستن";
		ao.UseVisualStyleBackColor = true;
		ao.Click += a;
		am.AutoSize = true;
		am.Location = new Point(449, 163);
		am.Name = "label22";
		am.Size = new Size(45, 13);
		am.TabIndex = 37;
		am.Text = "متن پیام";
		an.Location = new Point(7, 159);
		an.Multiline = true;
		an.Name = "txtMessage";
		an.RightToLeft = RightToLeft.No;
		an.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		an.Size = new Size(435, 242);
		an.TabIndex = 36;
		an.TextAlign = HorizontalAlignment.Right;
		al.BackColor = SystemColors.ButtonFace;
		al.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		al.Location = new Point(282, 123);
		al.Name = "lstd";
		al.Size = new Size(161, 23);
		al.TabIndex = 35;
		al.TextAlign = ContentAlignment.MiddleLeft;
		ag.BackColor = SystemColors.ButtonFace;
		ag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ag.Location = new Point(7, 85);
		ag.Name = "lTimeSend";
		ag.Size = new Size(141, 23);
		ag.TabIndex = 34;
		ag.TextAlign = ContentAlignment.MiddleLeft;
		ah.BackColor = SystemColors.ButtonFace;
		ah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ah.Location = new Point(7, 54);
		ah.Name = "lTimeTosend";
		ah.Size = new Size(141, 23);
		ah.TabIndex = 33;
		ah.TextAlign = ContentAlignment.MiddleLeft;
		ai.BackColor = SystemColors.ButtonFace;
		ai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ai.Location = new Point(282, 88);
		ai.Name = "ldateSend";
		ai.Size = new Size(161, 23);
		ai.TabIndex = 32;
		ai.TextAlign = ContentAlignment.MiddleLeft;
		aj.BackColor = SystemColors.ButtonFace;
		aj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		aj.Location = new Point(282, 55);
		aj.Name = "ldateTosend";
		aj.Size = new Size(160, 23);
		aj.TabIndex = 31;
		aj.TextAlign = ContentAlignment.MiddleLeft;
		ak.BackColor = SystemColors.ButtonFace;
		ak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ak.Location = new Point(7, 25);
		ak.Name = "lTypeMessage";
		ak.Size = new Size(141, 23);
		ak.TabIndex = 30;
		ak.TextAlign = ContentAlignment.MiddleLeft;
		aa.AutoSize = true;
		aa.Location = new Point(448, 59);
		aa.Name = "label6";
		aa.Size = new Size(112, 13);
		aa.TabIndex = 22;
		aa.Text = "تاریخ ارسال توسط کاربر";
		ae.BackColor = SystemColors.ButtonFace;
		ae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ae.Location = new Point(282, 25);
		ae.Name = "lStatus";
		ae.Size = new Size(161, 23);
		ae.TabIndex = 29;
		ae.TextAlign = ContentAlignment.MiddleLeft;
		z.AutoSize = true;
		z.Location = new Point(154, 57);
		z.Name = "label7";
		z.Size = new Size(122, 13);
		z.TabIndex = 23;
		z.Text = "ساعت ارسال توسط کاربر";
		ab.AutoSize = true;
		ab.Location = new Point(453, 29);
		ab.Name = "label12";
		ab.Size = new Size(41, 13);
		ab.TabIndex = 28;
		ab.Text = "وضعیت";
		y.AutoSize = true;
		y.Location = new Point(448, 93);
		y.Name = "label9";
		y.Size = new Size(111, 13);
		y.TabIndex = 24;
		y.Text = "تاریخ ارسال توسط ربات";
		ac.AutoSize = true;
		ac.Location = new Point(168, 29);
		ac.Name = "label11";
		ac.Size = new Size(42, 13);
		ac.TabIndex = 27;
		ac.Text = "نوع پیام";
		x.AutoSize = true;
		x.Location = new Point(154, 90);
		x.Name = "label8";
		x.Size = new Size(121, 13);
		x.TabIndex = 25;
		x.Text = "ساعت ارسال توسط ربات";
		ad.AutoSize = true;
		ad.Location = new Point(452, 128);
		ad.Name = "label10";
		ad.Size = new Size(35, 13);
		ad.TabIndex = 26;
		ad.Text = "گیرنده";
		v.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		v.Font = new Font("B Homa", 16f);
		v.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		v.ImageIndex = 8;
		v.ImageSize = new Size(20, 20);
		v.Location = new Point(569, 554);
		v.Name = "btnViewMessage";
		v.Size = new Size(221, 29);
		v.TabIndex = 25;
		v.Text = "مشاهده پیام";
		v.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		v.Click += b;
		u.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		u.Font = new Font("B Homa", 16f);
		u.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		u.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		u.ImageIndex = 8;
		u.ImageSize = new Size(20, 20);
		u.Location = new Point(20, 555);
		u.Name = "btnClose";
		u.Size = new Size(80, 29);
		u.TabIndex = 24;
		u.Text = "خروج";
		u.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		u.Click += e;
		r.Font = new Font("Tahoma", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r.Location = new Point(222, 0);
		r.Name = "label1";
		r.Size = new Size(354, 29);
		r.TabIndex = 23;
		r.Text = "لیست پیام های ارسال شده به تلگرام";
		s.AutoSize = true;
		s.Location = new Point(733, 96);
		s.Name = "label3";
		s.Size = new Size(37, 13);
		s.TabIndex = 22;
		s.Text = "تا تاریخ";
		t.AutoSize = true;
		t.Location = new Point(733, 44);
		t.Name = "label2";
		t.Size = new Size(38, 13);
		t.TabIndex = 21;
		t.Text = "از تاریخ";
		p.AutoToday = true;
		p.BackColor = Color.SeaShell;
		p.BijanForeColor = Color.Blue;
		p.Location = new Point(582, 89);
		p.Name = "txtDateTo";
		p.Size = new Size(144, 24);
		p.TabIndex = 19;
		p.the_date = new DateTime(2020, 8, 25, 14, 3, 21, 748);
		p.the_label = "ازمون تاريخ:";
		p.DateChanged += c;
		q.AutoToday = true;
		q.BackColor = Color.SeaShell;
		q.BijanForeColor = Color.Blue;
		q.Location = new Point(582, 40);
		q.Name = "txtDateFrom";
		q.Size = new Size(144, 24);
		q.TabIndex = 18;
		q.the_date = new DateTime(2020, 8, 25, 14, 3, 21, 752);
		q.the_label = "ازمون تاريخ:";
		q.DateChanged += d;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_f.Controls.Add(o);
		this.m_f.Controls.Add(k);
		this.m_f.Controls.Add(l);
		this.m_f.Controls.Add(m);
		this.m_f.Controls.Add(n);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(this.m_j);
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Controls.Add(this.m_h);
		this.m_f.Location = new Point(11, 31);
		this.m_f.Name = "uiGroupBox1";
		this.m_f.Size = new Size(559, 88);
		this.m_f.TabIndex = 17;
		this.m_f.Text = "جستجو";
		o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		o.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		o.ImageSize = new Size(25, 25);
		o.Location = new Point(3, 21);
		o.Name = "btnNoSearch";
		o.Size = new Size(85, 59);
		o.TabIndex = 6;
		o.Text = "حذف فیلترهای جستجو";
		o.Click += h;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.AutoSize = true;
		k.Location = new Point(265, 26);
		k.Name = "label5";
		k.Size = new Size(65, 13);
		k.TabIndex = 29;
		k.Text = "نام خانوادگی";
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoSize = true;
		l.Location = new Point(513, 26);
		l.Name = "label4";
		l.Size = new Size(20, 13);
		l.TabIndex = 28;
		l.Text = "نام";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.AutoScroll = false;
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.AutoScrollPosition = new Point(0, 0);
		m.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m.Location = new Point(106, 21);
		m.Name = "txtLName";
		m.RightToLeft = RightToLeft.Yes;
		m.Size = new Size(153, 23);
		m.TabIndex = 4;
		m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.KeyUp += a;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n.Location = new Point(354, 21);
		n.Name = "txtFName";
		n.RightToLeft = RightToLeft.Yes;
		n.Size = new Size(153, 23);
		n.TabIndex = 3;
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		n.KeyUp += a;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(266, 63);
		this.m_i.Name = "label19";
		this.m_i.Size = new Size(30, 13);
		this.m_i.TabIndex = 25;
		this.m_i.Text = "صنف";
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_j.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_j.Location = new Point(106, 57);
		this.m_j.Name = "dropCls";
		this.m_j.Size = new Size(153, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_j.StringFormat = stringFormat;
		this.m_j.TabIndex = 2;
		this.m_j.SelectedIndexChanged += g;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.AutoSize = true;
		this.m_g.Location = new Point(510, 63);
		this.m_g.Name = "label20";
		this.m_g.Size = new Size(22, 13);
		this.m_g.TabIndex = 15;
		this.m_g.Text = "پایه";
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.m_h.Location = new Point(334, 57);
		this.m_h.Name = "dropPaye";
		this.m_h.Size = new Size(173, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat2;
		this.m_h.TabIndex = 1;
		this.m_h.SelectedIndexChanged += i;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ActiveCaptionText;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_e);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmlistTelegramMessage";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست شاگردان";
		Load += j;
		((ISupportInitialize)this.m_d).EndInit();
		this.m_e.ResumeLayout(performLayout: false);
		this.m_e.PerformLayout();
		w.ResumeLayout(performLayout: false);
		af.ResumeLayout(performLayout: false);
		af.PerformLayout();
		((ISupportInitialize)this.m_f).EndInit();
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
