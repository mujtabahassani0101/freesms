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
		a();
	}

	private void f(object A_0, EventArgs A_1)
	{
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
					n.Focus();
					n.Focus();
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					this.m_b = true;
					j.Text = asdaj.__field_a;
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
						this.m_f.BackColor = Color.FromArgb(red, green, blue);
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + j.Text + " and xPaye in(" + asdaj.n + ") order by xpaye,sortRpt");
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
		ad.Text = dataTable.Rows[0]["countAbsent1"].ToString();
		w.Text = dataTable.Rows[0]["countAbsent2"].ToString();
		u.Text = dataTable.Rows[0]["countAcp1"].ToString();
		aa.Text = dataTable.Rows[0]["countAcp2"].ToString();
		n.Text = dataTable.Rows[0]["countDakhele1"].ToString();
		ac.Text = dataTable.Rows[0]["countDakhele2"].ToString();
		v.Text = dataTable.Rows[0]["countExam1"].ToString();
		ab.Text = dataTable.Rows[0]["countExam2"].ToString();
		s.Text = dataTable.Rows[0]["countMashrot1"].ToString();
		y.Text = dataTable.Rows[0]["countMashrot2"].ToString();
		r.Text = dataTable.Rows[0]["countMazerati1"].ToString();
		x.Text = dataTable.Rows[0]["countMazerati2"].ToString();
		t.Text = dataTable.Rows[0]["countNoAcp1"].ToString();
		z.Text = dataTable.Rows[0]["countNoAcp2"].ToString();
		al.Text = dataTable.Rows[0]["Separcheh"].ToString();
		n.Focus();
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		object value3 = default;
		object value11 = default;
		object value6 = default;
		object value13 = default;
		object value5 = default;
		object value14 = default;
		object value7 = default;
		object value15 = default;
		object value9 = default;
		object value8 = default;
		object value12 = default;
		object value2 = default;
		object value4 = default;
		object value10 = default;
		while (true)
		{
			object value = ad.Text;
			bool flag = !(ad.Text.Trim() == "");
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
					value3 = DBNull.Value;
					num = 39;
					continue;
				case 32:
					value11 = DBNull.Value;
					num = 3;
					continue;
				case 33:
					value6 = aa.Text;
					flag = !(aa.Text.Trim() == "");
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
					value13 = DBNull.Value;
					num = 12;
					continue;
				case 15:
					value5 = u.Text;
					flag = !(u.Text.Trim() == "");
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
					value3 = r.Text;
					flag = !(r.Text.Trim() == "");
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
					value14 = DBNull.Value;
					num = 41;
					continue;
				case 29:
					value11 = s.Text;
					flag = !(s.Text.Trim() == "");
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
					value7 = n.Text;
					flag = !(n.Text.Trim() == "");
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
					value14 = z.Text;
					flag = !(z.Text.Trim() == "");
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
					value15 = DBNull.Value;
					num = 30;
					continue;
				case 10:
					value9 = v.Text;
					flag = !(v.Text.Trim() == "");
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
					value = DBNull.Value;
					num = 6;
					continue;
				case 2:
					value6 = DBNull.Value;
					num = 31;
					continue;
				case 24:
					value5 = DBNull.Value;
					num = 33;
					continue;
				case 20:
					value8 = ac.Text;
					flag = !(ac.Text.Trim() == "");
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
					value13 = t.Text;
					flag = !(t.Text.Trim() == "");
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
					value12 = x.Text;
					flag = !(x.Text.Trim() == "");
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
					value9 = DBNull.Value;
					num = 25;
					continue;
				case 9:
					if (true)
					{
					}
					value8 = DBNull.Value;
					num = 10;
					continue;
				case 3:
					value2 = y.Text;
					flag = !(y.Text.Trim() == "");
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
					value7 = DBNull.Value;
					num = 20;
					continue;
				case 11:
					value4 = DBNull.Value;
					num = 15;
					continue;
				case 17:
					value12 = DBNull.Value;
					num = 8;
					continue;
				case 25:
					value10 = ab.Text;
					flag = !(ab.Text.Trim() == "");
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
					value10 = DBNull.Value;
					num = 29;
					continue;
				case 6:
					value4 = w.Text;
					flag = !(w.Text.Trim() == "");
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
					value15 = al.Text;
					flag = !(al.Text.Trim() == "");
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
					value2 = DBNull.Value;
					num = 0;
					continue;
				case 30:
				{
					SqlParameter[] a_ = new SqlParameter[16]
					{
						asdcb.a("@id", SqlDbType.Int, h.SelectedValue.ToString()),
						asdcb.a("@countAbsent1", SqlDbType.SmallInt, value),
						asdcb.a("@countAbsent2", SqlDbType.SmallInt, value4),
						asdcb.a("@countAcp1", SqlDbType.SmallInt, value5),
						asdcb.a("@countAcp2", SqlDbType.SmallInt, value6),
						asdcb.a("@countDakhele1", SqlDbType.SmallInt, value7),
						asdcb.a("@countDakhele2", SqlDbType.SmallInt, value8),
						asdcb.a("@countExam1", SqlDbType.SmallInt, value9),
						asdcb.a("@countExam2", SqlDbType.SmallInt, value10),
						asdcb.a("@countMashrot1", SqlDbType.SmallInt, value11),
						asdcb.a("@countMashrot2", SqlDbType.SmallInt, value2),
						asdcb.a("@countMazerati1", SqlDbType.SmallInt, value3),
						asdcb.a("@countMazerati2", SqlDbType.SmallInt, value12),
						asdcb.a("@countNoAcp1", SqlDbType.SmallInt, value13),
						asdcb.a("@countNoAcp2", SqlDbType.SmallInt, value14),
						asdcb.a("@Separcheh", SqlDbType.SmallInt, value15)
					};
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE    tClass\r\n                SET  countDakhele1 =@countDakhele1 , countDakhele2 =@countDakhele2 , countExam1 =@countExam1 ,\r\n                 countExam2 =@countExam2 , countAcp1 =@countAcp1 ,\r\n                 countAcp2 =@countAcp2 , countNoAcp1 =@countNoAcp1 ,\r\n                 countNoAcp2 =@countNoAcp2 , countMashrot1 =@countMashrot1 ,\r\n                 countMashrot2 =@countMashrot2 ,countMazerati1 =@countMazerati1 , \r\n                 countMazerati2 =@countMazerati2 , countAbsent1 =@countAbsent1 , countAbsent2 =@countAbsent2, Separcheh =@Separcheh\r\n                    WHERE     (id = @id)", a_);
					MessageBox.Show("ثبت شد");
					h.Focus();
					return;
				}
				}
				break;
			}
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.F5;
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
		if (true)
		{
		}
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromName("Window");
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Return;
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
protected override void Dispose(bool A_0)
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
						base.Dispose(A_0);
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
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdba));
		StringFormat stringFormat = new StringFormat();
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
		this.m_d.SuspendLayout();
		this.m_e.SuspendLayout();
		this.m_f.SuspendLayout();
		SuspendLayout();
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Dock = DockStyle.Fill;
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "panel1";
		this.m_d.Size = new Size(482, 567);
		this.m_d.TabIndex = 0;
		this.m_e.BackColor = Color.Black;
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Dock = DockStyle.Fill;
		this.m_e.Location = new Point(0, 0);
		this.m_e.Name = "panel2";
		this.m_e.Size = new Size(480, 565);
		this.m_e.TabIndex = 44;
		this.m_f.BackColor = Color.FromArgb(214, 223, 247);
		this.m_f.Controls.Add(al);
		this.m_f.Controls.Add(ak);
		this.m_f.Controls.Add(af);
		this.m_f.Controls.Add(ag);
		this.m_f.Controls.Add(ah);
		this.m_f.Controls.Add(ai);
		this.m_f.Controls.Add(aj);
		this.m_f.Controls.Add(ae);
		this.m_f.Controls.Add(w);
		this.m_f.Controls.Add(x);
		this.m_f.Controls.Add(y);
		this.m_f.Controls.Add(z);
		this.m_f.Controls.Add(aa);
		this.m_f.Controls.Add(ab);
		this.m_f.Controls.Add(ac);
		this.m_f.Controls.Add(ad);
		this.m_f.Controls.Add(r);
		this.m_f.Controls.Add(s);
		this.m_f.Controls.Add(t);
		this.m_f.Controls.Add(u);
		this.m_f.Controls.Add(v);
		this.m_f.Controls.Add(q);
		this.m_f.Controls.Add(p);
		this.m_f.Controls.Add(o);
		this.m_f.Controls.Add(n);
		this.m_f.Controls.Add(m);
		this.m_f.Controls.Add(l);
		this.m_f.Controls.Add(j);
		this.m_f.Controls.Add(k);
		this.m_f.Controls.Add(h);
		this.m_f.Controls.Add(i);
		this.m_f.Controls.Add(g);
		this.m_f.Location = new Point(3, 3);
		this.m_f.Name = "panel3";
		this.m_f.Size = new Size(473, 559);
		this.m_f.TabIndex = 0;
		af.AutoSize = true;
		af.Location = new Point(323, 416);
		af.Name = "label11";
		af.Size = new Size(83, 26);
		af.TabIndex = 144;
		af.Text = "غایب/محروم";
		ag.AutoSize = true;
		ag.Location = new Point(322, 371);
		ag.Name = "label10";
		ag.Size = new Size(54, 26);
		ag.TabIndex = 143;
		ag.Text = "معذرتی";
		ah.AutoSize = true;
		ah.Location = new Point(322, 328);
		ah.Name = "label9";
		ah.Size = new Size(52, 26);
		ah.TabIndex = 142;
		ah.Text = "مشروط";
		ai.AutoSize = true;
		ai.Location = new Point(322, 286);
		ai.Name = "label8";
		ai.Size = new Size(142, 26);
		ai.TabIndex = 141;
		ai.Text = "تلاش بیشتر/تکرار صنف";
		aj.AutoSize = true;
		aj.Location = new Point(322, 246);
		aj.Name = "label7";
		aj.Size = new Size(107, 26);
		aj.TabIndex = 140;
		aj.Text = "موفق/ارتقاء صنف";
		ae.AutoSize = true;
		ae.Location = new Point(322, 206);
		ae.Name = "label6";
		ae.Size = new Size(86, 26);
		ae.TabIndex = 139;
		ae.Text = "شامل امتحان";
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Location = new Point(63, 412);
		w.MaxLength = 3;
		w.Name = "txtcountAbsent2";
		w.Numeric = true;
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(96, 33);
		w.TabIndex = 13;
		w.Tag = "";
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		w.Leave += a;
		w.Enter += b;
		w.KeyDown += a;
		x.AutoScroll = false;
		x.AutoScrollMargin = new Size(0, 0);
		x.AutoScrollMinSize = new Size(0, 0);
		x.AutoScrollPosition = new Point(0, 0);
		x.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Location = new Point(63, 366);
		x.MaxLength = 3;
		x.Name = "txtcountMazerati2";
		x.Numeric = true;
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(96, 33);
		x.TabIndex = 12;
		x.Tag = "";
		x.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		x.Leave += a;
		x.Enter += b;
		x.KeyDown += a;
		y.AutoScroll = false;
		y.AutoScrollMargin = new Size(0, 0);
		y.AutoScrollMinSize = new Size(0, 0);
		y.AutoScrollPosition = new Point(0, 0);
		y.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		y.Location = new Point(63, 323);
		y.MaxLength = 3;
		y.Name = "txtcountMashrot2";
		y.Numeric = true;
		y.RightToLeft = RightToLeft.Yes;
		y.Size = new Size(96, 33);
		y.TabIndex = 11;
		y.Tag = "";
		y.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		y.Leave += a;
		y.Enter += b;
		y.KeyDown += a;
		z.AutoScroll = false;
		z.AutoScrollMargin = new Size(0, 0);
		z.AutoScrollMinSize = new Size(0, 0);
		z.AutoScrollPosition = new Point(0, 0);
		z.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		z.Location = new Point(63, 282);
		z.MaxLength = 3;
		z.Name = "txtcountNoAcp2";
		z.Numeric = true;
		z.RightToLeft = RightToLeft.Yes;
		z.Size = new Size(96, 33);
		z.TabIndex = 10;
		z.Tag = "";
		z.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		z.Leave += a;
		z.Enter += b;
		z.KeyDown += a;
		aa.AutoScroll = false;
		aa.AutoScrollMargin = new Size(0, 0);
		aa.AutoScrollMinSize = new Size(0, 0);
		aa.AutoScrollPosition = new Point(0, 0);
		aa.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aa.Location = new Point(63, 242);
		aa.MaxLength = 3;
		aa.Name = "txtcountAcp2";
		aa.Numeric = true;
		aa.RightToLeft = RightToLeft.Yes;
		aa.Size = new Size(96, 33);
		aa.TabIndex = 9;
		aa.Tag = "";
		aa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		aa.Leave += a;
		aa.Enter += b;
		aa.KeyDown += a;
		ab.AutoScroll = false;
		ab.AutoScrollMargin = new Size(0, 0);
		ab.AutoScrollMinSize = new Size(0, 0);
		ab.AutoScrollPosition = new Point(0, 0);
		ab.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ab.Location = new Point(63, 202);
		ab.MaxLength = 3;
		ab.Name = "txtcountExam2";
		ab.Numeric = true;
		ab.RightToLeft = RightToLeft.Yes;
		ab.Size = new Size(96, 33);
		ab.TabIndex = 8;
		ab.Tag = "";
		ab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		ab.Leave += a;
		ab.Enter += b;
		ab.KeyDown += a;
		ac.AutoScroll = false;
		ac.AutoScrollMargin = new Size(0, 0);
		ac.AutoScrollMinSize = new Size(0, 0);
		ac.AutoScrollPosition = new Point(0, 0);
		ac.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ac.Location = new Point(63, 161);
		ac.MaxLength = 3;
		ac.Name = "txtcountDakhele2";
		ac.Numeric = true;
		ac.RightToLeft = RightToLeft.Yes;
		ac.Size = new Size(96, 33);
		ac.TabIndex = 7;
		ac.Tag = "";
		ac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		ac.Leave += a;
		ac.Enter += b;
		ac.KeyDown += a;
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ad.Location = new Point(221, 412);
		ad.MaxLength = 3;
		ad.Name = "txtcountAbsent1";
		ad.Numeric = true;
		ad.RightToLeft = RightToLeft.Yes;
		ad.Size = new Size(96, 33);
		ad.TabIndex = 6;
		ad.Tag = "";
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		ad.Leave += a;
		ad.Enter += b;
		ad.KeyDown += a;
		r.AutoScroll = false;
		r.AutoScrollMargin = new Size(0, 0);
		r.AutoScrollMinSize = new Size(0, 0);
		r.AutoScrollPosition = new Point(0, 0);
		r.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Location = new Point(221, 366);
		r.MaxLength = 3;
		r.Name = "txtcountMazerati1";
		r.Numeric = true;
		r.RightToLeft = RightToLeft.Yes;
		r.Size = new Size(96, 33);
		r.TabIndex = 5;
		r.Tag = "";
		r.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		r.Leave += a;
		r.Enter += b;
		r.KeyDown += a;
		s.AutoScroll = false;
		s.AutoScrollMargin = new Size(0, 0);
		s.AutoScrollMinSize = new Size(0, 0);
		s.AutoScrollPosition = new Point(0, 0);
		s.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		s.Location = new Point(221, 323);
		s.MaxLength = 3;
		s.Name = "txtcountMashrot1";
		s.Numeric = true;
		s.RightToLeft = RightToLeft.Yes;
		s.Size = new Size(96, 33);
		s.TabIndex = 4;
		s.Tag = "";
		s.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		s.Leave += a;
		s.Enter += b;
		s.KeyDown += a;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		t.Location = new Point(221, 282);
		t.MaxLength = 3;
		t.Name = "txtcountNoAcp1";
		t.Numeric = true;
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(96, 33);
		t.TabIndex = 3;
		t.Tag = "";
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		t.Leave += a;
		t.Enter += b;
		t.KeyDown += a;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(221, 242);
		u.MaxLength = 3;
		u.Name = "txtcountAcp1";
		u.Numeric = true;
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(96, 33);
		u.TabIndex = 2;
		u.Tag = "";
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		u.Leave += a;
		u.Enter += b;
		u.KeyDown += a;
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Location = new Point(221, 202);
		v.MaxLength = 3;
		v.Name = "txtcountExam1";
		v.Numeric = true;
		v.RightToLeft = RightToLeft.Yes;
		v.Size = new Size(96, 33);
		v.TabIndex = 1;
		v.Tag = "";
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		v.Leave += a;
		v.Enter += b;
		v.KeyDown += a;
		q.AutoSize = true;
		q.Location = new Point(89, 128);
		q.Name = "label5";
		q.Size = new Size(47, 26);
		q.TabIndex = 125;
		q.Text = "سالانه";
		p.AutoSize = true;
		p.Location = new Point(223, 129);
		p.Name = "label2";
		p.Size = new Size(89, 26);
		p.TabIndex = 124;
		p.Text = "چهار نیم ماهه";
		o.AutoSize = true;
		o.Location = new Point(322, 165);
		o.Name = "label1";
		o.Size = new Size(76, 26);
		o.TabIndex = 123;
		o.Text = "تعداد داخله";
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(221, 161);
		n.MaxLength = 3;
		n.Name = "txtcountDakhele1";
		n.Numeric = true;
		n.RightToLeft = RightToLeft.Yes;
		n.Size = new Size(96, 33);
		n.TabIndex = 0;
		n.Tag = "";
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		n.Leave += a;
		n.Enter += b;
		n.KeyDown += a;
		m.AutoSize = true;
		m.Font = new Font("B Nazanin", 24f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.ForeColor = Color.DarkViolet;
		m.Location = new Point(177, 5);
		m.Name = "label4";
		m.Size = new Size(144, 51);
		m.TabIndex = 121;
		m.Text = "خلص نتایج";
		l.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		l.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		l.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		l.ImageIndex = 8;
		l.Location = new Point(220, 504);
		l.Name = "btnAcp";
		l.RightToLeft = RightToLeft.Yes;
		l.Size = new Size(153, 40);
		l.TabIndex = 15;
		l.Text = "ثبت (F5)";
		l.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		l.Click += c;
		j.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		j.Location = new Point(10, 20);
		j.Name = "lYear";
		j.Size = new Size(59, 24);
		j.TabIndex = 118;
		k.AutoSize = true;
		k.Location = new Point(75, 20);
		k.Name = "label3";
		k.Size = new Size(78, 26);
		k.TabIndex = 117;
		k.Text = "سال تعلیمی\r\n";
		h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		h.DropListFont = new Font("B Nazanin", 12f);
		h.Location = new Point(63, 84);
		h.Name = "dropCls";
		h.Size = new Size(254, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat;
		h.TabIndex = 15;
		h.SelectedIndexChanged += d;
		i.AutoSize = true;
		i.Location = new Point(323, 88);
		i.Name = "label19";
		i.Size = new Size(41, 26);
		i.TabIndex = 51;
		i.Text = "صنف";
		g.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		g.DialogResult = DialogResult.Cancel;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(40, 40);
		g.Location = new Point(28, 504);
		g.Name = "btnClose";
		g.Size = new Size(152, 40);
		g.TabIndex = 16;
		g.Text = "بستن";
		g.Click += e;
		ak.AutoSize = true;
		ak.Location = new Point(225, 463);
		ak.Name = "label12";
		ak.Size = new Size(65, 26);
		ak.TabIndex = 145;
		ak.Text = "سه پارچه";
		al.AutoScroll = false;
		al.AutoScrollMargin = new Size(0, 0);
		al.AutoScrollMinSize = new Size(0, 0);
		al.AutoScrollPosition = new Point(0, 0);
		al.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		al.Location = new Point(159, 458);
		al.MaxLength = 3;
		al.Name = "txtSeparcheh";
		al.Numeric = true;
		al.RightToLeft = RightToLeft.Yes;
		al.Size = new Size(66, 33);
		al.TabIndex = 14;
		al.Tag = "";
		al.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(482, 567);
		Controls.Add(this.m_d);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmSummaryResults";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "خلص نتایج";
		Load += f;
		KeyUp += b;
		this.m_d.ResumeLayout(performLayout: false);
		this.m_e.ResumeLayout(performLayout: false);
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
