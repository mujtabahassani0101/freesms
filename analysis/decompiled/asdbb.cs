using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbb : Form
{
	public string a;

	public string b;

	public string c;

	private bool m_d = false;

	private IContainer m_e = null;

	private Panel m_f;

	private OpenFileDialog m_g;

	private Panel m_h;

	private Label m_i;

	private Panel j;

	private Panel k;

	private TextBox l;

	private Label m;

	private UIButton n;

	private UIButton o;

	private Label p;

	private MaskedEditBox q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private Label v;

	private TextBox w;

	private Label x;

	public asdbb()
	{
		a();
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 6;
				case 10:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xStudent", SqlDbType.Int, this.a) };
					DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select code,fname,lname from tstudent where  id=@xStudent", a_);
					((Control)this.m_i).Text = dataTable2.Rows[0]["fname"].ToString() + " - " + dataTable2.Rows[0]["lname"].ToString();
					((Control)s).Text = dataTable2.Rows[0]["code"].ToString();
					flag = !(this.c != "0");
					num = 5;
					continue;
				}
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 3;
						continue;
					}
					((Control)r).Text = "یادداشت جدید";
					num = 0;
					continue;
				case 6:
					flag = !(this.c == "0");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 10;
				case 1:
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
					num = 6;
					continue;
				case 3:
					((Control)r).Text = "اصلاح یادداشت";
					b();
					num = 4;
					continue;
				case 9:
					num = 1;
					continue;
				case 8:
					((Control)q).Text = asdab.b();
					num = 10;
					continue;
				case 0:
				case 4:
					((Control)w).Focus();
					return;
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
		SqlParameter[] a_ = new SqlParameter[2]
		{
			asdcb.a("@id", SqlDbType.Int, this.c),
			asdcb.a("@xStudent", SqlDbType.Int, this.a)
		};
		DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * FROM tComnentStd where xStudent=@xStudent and id=@id", a_);
		((Control)q).Text = dataTable.Rows[0]["DateInsert"].ToString();
		((Control)w).Text = dataTable.Rows[0]["Subject"].ToString();
		((Control)l).Text = dataTable.Rows[0]["comment"].ToString();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			asdaj.k = ((Control)q).Text;
			string text = "";
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 13:
					text = "چهارشنبه";
					num = 4;
					continue;
				case 22:
					if (!flag)
					{
						num = 16;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 25;
					continue;
				case 15:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(text == "Saturday");
					num = 29;
					continue;
				case 23:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 2;
				case 17:
					if (flag)
					{
						flag = !(((Control)l).Text == "");
						num = 15;
					}
					else
					{
						num = 27;
					}
					continue;
				case 25:
					if (!flag)
					{
						num = 13;
						continue;
					}
					flag = !(text == "Thursday");
					num = 8;
					continue;
				case 2:
				case 4:
				case 6:
				case 7:
				case 19:
				case 24:
				{
					SqlParameter[] a_ = new SqlParameter[9]
					{
						asdcb.a("@id", SqlDbType.Int, this.c),
						asdcb.a("@xYear", SqlDbType.Int, this.b),
						asdcb.a("@xStudent", SqlDbType.Int, this.a),
						asdcb.a("@dayOfWeek", SqlDbType.NVarChar, text),
						asdcb.a("@subject", SqlDbType.NVarChar, ((Control)w).Text.Trim()),
						asdcb.a("@comment", SqlDbType.NVarChar, ((Control)l).Text.Trim()),
						asdcb.a("@Date", SqlDbType.NVarChar, asdab.b()),
						asdcb.a("@Time", SqlDbType.NVarChar, asdab.c()),
						asdcb.a("@xUser", SqlDbType.Int, asdaj.l)
					};
					int num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tComnentStd_insertUpdate", a_);
					flag = num2 <= 0;
					num = 30;
					continue;
				}
				case 30:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 11:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 22;
					}
					else
					{
						num = 10;
					}
					continue;
				case 5:
					MessageBox.Show("توضیحات یادداشت را وارد کنید");
					((Control)l).Focus();
					num = 28;
					continue;
				case 28:
					return;
				case 9:
					text = "جمعه";
					num = 24;
					continue;
				case 3:
					asdaj.i = true;
					MessageBox.Show("ثبت شد");
					((Form)this).Close();
					num = 26;
					continue;
				case 26:
					return;
				case 12:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 11;
					}
					else
					{
						num = 14;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_044a:
							DateTime dateTime = ShamsiDate.ShamsiToGregory(((Control)q).Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(dateTime);
							flag = !(shamsiDate != ((Control)q).Text);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 1;
										continue;
									}
									text = dateTime.DayOfWeek.ToString();
									num = 0;
									continue;
								case 1:
									MessageBox.Show("تاریخ یادداشت اشتباه است");
									((Control)q).Focus();
									num = 2;
									continue;
								case 2:
									return;
								case 0:
									goto end_IL_0431;
								}
								goto IL_044a;
								continue;
								end_IL_0431:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ یادداشت اشتباه است");
						((Control)q).Focus();
						return;
					}
					((Control)w).Text = asdaj.b(((Control)w).Text);
					((Control)l).Text = asdaj.b(((Control)l).Text);
					flag = !(((Control)w).Text == "");
					num = 17;
					continue;
				case 27:
					MessageBox.Show("موضوع یادداشت را وارد کنید");
					((Control)w).Focus();
					num = 21;
					continue;
				case 21:
					return;
				case 29:
					if (flag)
					{
						flag = !(text == "Sunday");
						num = 12;
					}
					else
					{
						num = 20;
					}
					continue;
				case 20:
					text = "شنبه";
					num = 19;
					continue;
				case 0:
					text = "پنج شنبه";
					num = 18;
					continue;
				case 18:
					if (1 == 0)
					{
					}
					goto case 2;
				case 8:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 23;
					}
					else
					{
						num = 0;
					}
					continue;
				case 14:
					text = "یکشنبه";
					num = 7;
					continue;
				case 10:
					text = "دوشنبه";
					num = 2;
					continue;
				case 16:
					text = "سه شنبه";
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
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
					num = (((int)A_1.KeyCode != 114) ? 6 : 8);
					continue;
				case 8:
					num = 7;
					continue;
				case 7:
					num2 = ((!((Control)j).Visible) ? 1 : 0);
					goto IL_007f;
				case 6:
					num2 = 1;
					goto IL_007f;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = (int)A_1.KeyCode != 27;
					if (true)
					{
					}
					num = 9;
					continue;
				case 5:
					h(this, null);
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					g(this, null);
					num = 4;
					continue;
				case 4:
					return;
				case 9:
					{
						if (!flag)
						{
							num = 1;
							continue;
						}
						return;
					}
					IL_007f:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 13;
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

	private void f(object A_0, EventArgs A_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (true)
		{
		}
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		MaskedEditBox val = (MaskedEditBox)A_0;
		((EditBase)val).BackColor = Color.FromName("Window");
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Control)l).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)l).BackColor = Color.FromName("Window");
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Control)w).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)w).BackColor = Color.FromName("Window");
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (A_0)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 0:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_e == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_e.Dispose();
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 3:
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected Obj, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got Unknown
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected Obj, but got Unknown
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected Obj, but got Unknown
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected Obj, but got Unknown
		//IL_0d8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d98: Expected Obj, but got Unknown
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbb));
		this.m_f = new Panel();
		v = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		this.m_i = new Label();
		j = new Panel();
		k = new Panel();
		w = new TextBox();
		x = new Label();
		p = new Label();
		q = new MaskedEditBox();
		l = new TextBox();
		m = new Label();
		this.m_g = new OpenFileDialog();
		this.m_h = new Panel();
		n = new UIButton();
		o = new UIButton();
		((Control)this.m_f).SuspendLayout();
		((Control)j).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this.m_h).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_f).BackColor = Color.FromArgb(214, 223, 247);
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)v);
		((Control)this.m_f).Controls.Add((Control)(object)r);
		((Control)this.m_f).Controls.Add((Control)(object)s);
		((Control)this.m_f).Controls.Add((Control)(object)t);
		((Control)this.m_f).Controls.Add((Control)(object)u);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)j);
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_f).Location = new Point(5, 5);
		((Control)this.m_f).Name = "panel1";
		((Control)this.m_f).Size = new Size(601, 450);
		((Control)this.m_f).TabIndex = 0;
		((Control)v).AutoSize = true;
		((Control)v).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(123, 88);
		((Control)v).Name = "label19";
		((Control)v).Size = new Size(81, 17);
		((Control)v).TabIndex = 114;
		((Control)v).Text = "نوع عملیات :";
		((Control)r).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)r).ForeColor = Color.Fuchsia;
		((Control)r).Location = new Point(6, 87);
		((Control)r).Name = "lTypecomand";
		((Control)r).Size = new Size(111, 18);
		((Control)r).TabIndex = 113;
		((Control)s).BackColor = Color.FromArgb(0, 192, 192);
		s.BorderStyle = (BorderStyle)1;
		((Control)s).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)s).Location = new Point(349, 76);
		((Control)s).Name = "lCode";
		((Control)s).RightToLeft = (RightToLeft)1;
		((Control)s).Size = new Size(173, 37);
		((Control)s).TabIndex = 112;
		s.TextAlign = (ContentAlignment)32;
		((Control)t).AutoSize = true;
		((Control)t).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(528, 87);
		((Control)t).Name = "label5";
		((Control)t).Size = new Size(61, 17);
		((Control)t).TabIndex = 111;
		((Control)t).Text = "کد متعلم";
		((Control)u).AutoSize = true;
		((Control)u).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(528, 26);
		((Control)u).Name = "label4";
		((Control)u).Size = new Size(51, 17);
		((Control)u).TabIndex = 110;
		((Control)u).Text = "نام -ولد";
		((Control)this.m_i).BackColor = Color.FromArgb(0, 192, 192);
		this.m_i.BorderStyle = (BorderStyle)1;
		((Control)this.m_i).Font = new Font("B Nazanin", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(10, 3);
		((Control)this.m_i).Name = "lName";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(512, 61);
		((Control)this.m_i).TabIndex = 77;
		this.m_i.TextAlign = (ContentAlignment)32;
		((Control)j).BackColor = Color.Gray;
		j.BorderStyle = (BorderStyle)1;
		((Control)j).Controls.Add((Control)(object)k);
		((Control)j).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)j).Location = new Point(7, 125);
		((Control)j).Name = "pStd";
		((Control)j).Size = new Size(588, 317);
		((Control)j).TabIndex = 79;
		((Control)k).BackColor = Color.FromArgb(214, 223, 247);
		k.BorderStyle = (BorderStyle)2;
		((Control)k).Controls.Add((Control)(object)w);
		((Control)k).Controls.Add((Control)(object)x);
		((Control)k).Controls.Add((Control)(object)p);
		((Control)k).Controls.Add((Control)(object)q);
		((Control)k).Controls.Add((Control)(object)l);
		((Control)k).Controls.Add((Control)(object)m);
		((Control)k).Controls.Add((Control)(object)n);
		((Control)k).Controls.Add((Control)(object)o);
		((Control)k).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(2, 3);
		((Control)k).Name = "panel3";
		((Control)k).Size = new Size(580, 307);
		((Control)k).TabIndex = 40;
		((Control)w).Font = new Font("Tahoma", 9.75f);
		((Control)w).Location = new Point(19, 38);
		((Control)w).Name = "txtSubject";
		((Control)w).Size = new Size(446, 23);
		((Control)w).TabIndex = 1;
		((Control)w).KeyDown += a;
		((Control)w).Leave += a;
		((Control)w).Enter += b;
		((Control)x).AutoSize = true;
		((Control)x).Location = new Point(469, 41);
		((Control)x).Name = "label1";
		((Control)x).Size = new Size(106, 16);
		((Control)x).TabIndex = 110;
		((Control)x).Text = "موضوع یادداشت :";
		((Control)p).AutoSize = true;
		((Control)p).Font = new Font("Tahoma", 9.75f);
		((Control)p).Location = new Point(469, 9);
		((Control)p).Name = "label12";
		((Control)p).Size = new Size(95, 16);
		((Control)p).TabIndex = 109;
		((Control)p).Text = "تاریخ یادداشت :";
		((EditBase)q).AutoScroll = false;
		((EditBase)q).AutoScrollMargin = new Size(0, 0);
		((EditBase)q).AutoScrollMinSize = new Size(0, 0);
		((EditBase)q).AutoScrollPosition = new Point(0, 0);
		((EditBase)q).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)q).Enabled = false;
		((Control)q).Font = new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(378, 7);
		q.Mask = "0000/00/00";
		((EditBase)q).MaxLength = 12;
		((Control)q).Name = "txtDateInsert";
		q.Numeric = true;
		((Control)q).RightToLeft = (RightToLeft)0;
		((Control)q).Size = new Size(86, 22);
		((Control)q).TabIndex = 0;
		((Control)q).Tag = "";
		((EditBase)q).TextAlignment = (TextAlignment)3;
		((Control)q).Leave += e;
		((Control)q).Enter += f;
		((Control)q).KeyDown += a;
		((Control)l).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(19, 68);
		((TextBoxBase)l).Multiline = true;
		((Control)l).Name = "txtComment";
		((Control)l).Size = new Size(446, 147);
		((Control)l).TabIndex = 2;
		((Control)l).Leave += c;
		((Control)l).Enter += d;
		((Control)m).AutoSize = true;
		((Control)m).Location = new Point(469, 75);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(66, 16);
		((Control)m).TabIndex = 42;
		((Control)m).Text = "توضیحات :";
		((FileDialog)this.m_g).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)this.m_g).Title = "انتخاب عکس شاگرد";
		((Control)this.m_h).BackColor = Color.Black;
		((Control)this.m_h).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_h).Dock = (DockStyle)5;
		((Control)this.m_h).Location = new Point(0, 0);
		((Control)this.m_h).Name = "panel2";
		((Control)this.m_h).Size = new Size(611, 461);
		((Control)this.m_h).TabIndex = 1;
		((Control)n).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)n).Location = new Point(19, 259);
		((Control)n).Name = "btnCancel";
		((Control)n).Size = new Size(110, 39);
		((Control)n).TabIndex = 16;
		((Control)n).Text = "انصراف(Esc)";
		((Control)n).Click += g;
		((Control)o).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		o.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)o).Location = new Point(147, 259);
		((Control)o).Name = "btnAcp";
		((Control)o).Size = new Size(110, 39);
		((Control)o).TabIndex = 15;
		((Control)o).Text = "ثبت(F3)";
		((Control)o).Click += h;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(611, 461);
		((Control)this).Controls.Add((Control)(object)this.m_h);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmCommentInsertUpdate";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += i;
		((Control)this).KeyUp += b;
		((Control)this.m_f).ResumeLayout(false);
		((Control)this.m_f).PerformLayout();
		((Control)j).ResumeLayout(false);
		((Control)k).ResumeLayout(false);
		((Control)k).PerformLayout();
		((Control)this.m_h).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
