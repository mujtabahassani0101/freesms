using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using school_Af.Properties;

public class asda5 : Form
{
	private bool m_a = false;

	private bool m_b = false;

	private int m_c = 0;

	private int m_d = 0;

	private string m_e = "";

	private IContainer m_f = null;

	private Panel m_g;

	private Panel m_h;

	private UIButton m_i;

	private UIButton m_j;

	private UIButton m_k;

	private UIGroupBox m_l;

	private Label m_m;

	private UIComboBox m_n;

	private Label m_o;

	private UIComboBox m_p;

	private Label m_q;

	private Label m_r;

	private EditBox m_s;

	private EditBox m_t;

	private UIButton u;

	private OpenFileDialog v;

	private Panel w;

	private GridEX x;

	private Label y;

	private UIGroupBox z;

	private GridEX aa;

	private Label ab;

	private Panel ac;

	private MaskedEditBox ad;

	private Label ae;

	private GridEXPrintDocument af;

	private UIButton ag;

	private PrintPreviewDialog ah;

	private UIComboBox ai;

	private UIButton aj;

	private Panel ak;

	private Label al;

	private Timer am;

	public asda5()
	{
		a();
	}

	private void t(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("9");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 6:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_g.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 7;
				case 7:
					ai.SelectedValue = asdaj.__field_a;
					e();
					f();
					this.m_a = true;
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void f()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + ai.SelectedValue.ToString() + ") order by id");
			this.m_n.Items.Clear();
			this.m_n.Items.Add("کل", "0");
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					this.m_n.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 2:
					this.m_n.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		while (true)
		{
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = this.m_n.SelectedIndex <= 0;
			int num = 0;
			while (true)
			{
				DataTable dataSource;
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto IL_008b;
				case 1:
					text = text + " and xPaye=" + this.m_n.SelectedValue.ToString();
					num = 2;
					continue;
				case 2:
					{
						if (1 == 0)
						{
						}
						goto IL_008b;
					}
					IL_008b:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'همه صنف ها' as  name\r\n                                                                                                                union select id,name from tClass where xYear=" + ai.SelectedValue.ToString() + text);
					this.m_p.DataSource = dataSource;
					this.m_p.DisplayMember = "Name";
					this.m_p.ValueMember = "id";
					this.m_p.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		string text = default;
		while (true)
		{
			bool flag = this.m_a;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 37;
						continue;
					}
					this.m_d = this.m_c;
					text = " tYear_Student.mali=1 and tYear_Student.xyear=" + ai.SelectedValue.ToString() + " and tYear_Student.xPaye in(" + asdaj.n + ")";
					flag = this.m_p.SelectedIndex <= 0;
					num = 8;
					continue;
				case 25:
					flag = !(ad.Text.Trim() != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 32;
				case 29:
					flag = !(this.m_s.Text.Trim() != "");
					num = 38;
					continue;
				case 38:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 25;
				case 0:
					text = text + " tYear_Student.xClass=" + this.m_p.SelectedValue.ToString();
					num = 19;
					continue;
				case 14:
					text = text + " tstudent.code=" + asdaj.b(ad.Text);
					num = 32;
					continue;
				case 30:
					flag = !(text != "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 0;
				case 9:
					text = text + " tstudent.LName like '%" + asdaj.b(this.m_s.Text) + "%'";
					num = 25;
					continue;
				case 33:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName, \r\n                 tClass.name AS Class, tPaye.Name AS Paye,tYear_Student.sort\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text);
					aa.DataSource = dataSource;
					ak.Visible = false;
					flag = aa.RowCount != 0;
					num = 28;
					continue;
				}
				case 28:
					if (!flag)
					{
						num = 26;
						continue;
					}
					return;
				case 4:
					text = text + " tstudent.FName like '%" + asdaj.b(this.m_t.Text) + "%'";
					num = 29;
					continue;
				case 21:
					flag = !(text != "");
					num = 34;
					continue;
				case 34:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 10;
				case 32:
					flag = !(text != "");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 36;
						continue;
					}
					goto case 33;
				case 26:
					z.Text = "لیست پرداخت های : ";
					x.DataSource = null;
					y.Text = "";
					num = 35;
					continue;
				case 35:
					return;
				case 3:
					flag = !(this.m_t.Text.Trim() != "");
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 29;
				case 37:
					num = 22;
					continue;
				case 22:
					return;
				case 19:
					flag = this.m_n.SelectedIndex <= 0;
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 21;
						continue;
					}
					goto case 3;
				case 11:
					text += " and ";
					num = 0;
					continue;
				case 10:
					text = text + " tYear_Student.xPaye=" + this.m_n.SelectedValue.ToString();
					num = 3;
					continue;
				case 36:
					text = " where " + text;
					num = 33;
					continue;
				case 20:
					if (true)
					{
					}
					flag = !(text != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 14;
				case 15:
					flag = !(text != "");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 4;
				case 17:
					text += " and ";
					num = 4;
					continue;
				case 2:
					text += " and ";
					num = 9;
					continue;
				case 18:
					text += " and ";
					num = 10;
					continue;
				case 8:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 19;
				case 13:
					text += " and ";
					num = 14;
					continue;
				case 31:
					flag = !(text != "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			x.DataSource = null;
			y.Text = "";
			int num = 5;
			while (true)
			{
				int num2;
				DataTable dataSource;
				switch (num)
				{
				case 5:
					num = ((aa.RowCount <= 0) ? 8 : 9);
					continue;
				case 6:
				{
					Label label = y;
					label.Text = label.Text + "\n" + aa.SelectedItems[0].GetRow().Cells["pname"].Value.ToString();
					num = 2;
					continue;
				}
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0266;
				case 1:
					y.Text = aa.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + aa.SelectedItems[0].GetRow().Cells["lname"].Value.ToString();
					z.Text = "لیست پرداخت های : " + y.Text;
					flag = !(aa.SelectedItems[0].GetRow().Cells["pname"].Value.ToString() != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto IL_0266;
				case 8:
					num2 = 1;
					goto IL_02de;
				case 3:
					return;
				case 9:
					num = 10;
					continue;
				case 10:
					num2 = ((aa.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_02de;
				case 0:
					return;
				case 4:
					{
						if (flag)
						{
							z.Text = "لیست پرداخت های : ";
							x.DataSource = null;
							y.Text = "";
							num = 3;
						}
						else
						{
							num = 1;
						}
						continue;
					}
					IL_0266:
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  *,  isnull( Fee,0)+ isnull( Transport,0)+ isnull( racing,0) \r\n            + isnull(Celebration,0) + isnull(Exam,0) + isnull(uniform,0) \r\n            + isnull(maghnae,0) + isnull(ketab,0) + isnull(komakdarsi, 0)\r\n            + isnull(dakhle,0) + isnull(other,0) as SumPay\r\n            FROM         tPaymentStudent where xYear=" + ai.SelectedValue.ToString() + " and xStudent = " + aa.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					x.DataSource = dataSource;
					num = 0;
					continue;
					IL_02de:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = "";
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					try
					{
						while (true)
						{
							IL_0093:
							num = 1;
							while (true)
							{
								int num2;
								switch (num)
								{
								case 1:
									num = ((aa.RowCount > 0) ? 3 : 0);
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									num2 = ((aa.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
									goto IL_0128;
								case 7:
									text = aa.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
									num = 5;
									continue;
								case 6:
									if (!flag)
									{
										num = 7;
										continue;
									}
									goto case 5;
								case 0:
									num2 = 1;
									goto IL_0128;
								case 5:
									num = 4;
									continue;
								case 4:
									goto end_IL_006a;
									IL_0128:
									flag = (byte)num2 != 0;
									num = 6;
									continue;
								}
								goto IL_0093;
								continue;
								end_IL_006a:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					flag = !(text != "");
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 3:
				{
					asdae asdae2 = new asdae();
					asdae2.aw = text;
					asdae2.ax = ai.SelectedValue.ToString();
					asdae2.ay = "0";
					asdae2.ShowDialog();
					c();
					num = 0;
					continue;
				}
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = "";
			string text2 = "";
			int num = 1;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 2:
					num3 = 1;
					goto IL_0080;
				case 5:
					num = ((text2 != "") ? 7 : 2);
					continue;
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					return;
				case 1:
					try
					{
						while (true)
						{
							IL_00d3:
							num = 3;
							while (true)
							{
								int num4;
								switch (num)
								{
								case 3:
									num = ((aa.RowCount > 0) ? 6 : 0);
									continue;
								case 2:
									text2 = aa.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
									num = 5;
									continue;
								case 0:
									num4 = 1;
									goto IL_0179;
								case 6:
									num = 7;
									continue;
								case 7:
									num4 = ((aa.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
									goto IL_0179;
								case 4:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 5;
								case 5:
									num = 1;
									continue;
								case 1:
									goto end_IL_00aa;
									IL_0179:
									flag = (byte)num4 != 0;
									num = 4;
									continue;
								}
								goto IL_00d3;
								continue;
								end_IL_00aa:
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
				case 7:
					if (true)
					{
					}
					num = 4;
					continue;
				case 4:
					num3 = ((!(text != "")) ? 1 : 0);
					goto IL_0080;
				case 8:
				{
					asdae asdae2 = new asdae();
					asdae2.aw = text2;
					asdae2.ax = ai.SelectedValue.ToString();
					asdae2.ay = text;
					asdae2.ShowDialog();
					c();
					num = 3;
					continue;
				}
				case 3:
					return;
				case 0:
					{
						try
						{
							while (true)
							{
								IL_025b:
								num = 4;
								while (true)
								{
									int num2;
									switch (num)
									{
									case 4:
										num = ((x.RowCount <= 0) ? 3 : 0);
										continue;
									case 0:
										num = 6;
										continue;
									case 6:
										num2 = ((x.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
										goto IL_02fe;
									case 3:
										num2 = 1;
										goto IL_02fe;
									case 2:
										text = x.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
										num = 7;
										continue;
									case 1:
										if (!flag)
										{
											num = 2;
											continue;
										}
										goto case 7;
									case 7:
										num = 5;
										continue;
									case 5:
										goto end_IL_0232;
										IL_02fe:
										flag = (byte)num2 != 0;
										num = 1;
										continue;
									}
									goto IL_025b;
									continue;
									end_IL_0232:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						num = 5;
						continue;
					}
					IL_0080:
					flag = (byte)num3 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void p(object A_0, EventArgs A_1)
	{
		e();
		b();
	}

	private void o(object A_0, EventArgs A_1)
	{
		b();
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default;
			while (true)
			{
				IL_003a:
				int num = 7;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 7:
						num = ((x.RowCount <= 0) ? 3 : 4);
						continue;
					case 3:
						num2 = 1;
						goto IL_015a;
					case 10:
						num = 1;
						continue;
					case 4:
						num = 2;
						continue;
					case 2:
						num2 = ((x.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_015a;
					case 6:
						asdcb.d(asdab.e(), CommandType.Text, "delete from tPaymentStudent where id=" + x.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						c();
						asdaj.i = true;
						num = 10;
						continue;
					case 0:
						flag = MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 5;
						continue;
					case 5:
						if (!flag)
						{
							num = 6;
							continue;
						}
						goto case 10;
					case 9:
						if (!flag)
						{
							num = 0;
							continue;
						}
						goto case 1;
					case 1:
						num = 8;
						continue;
					case 8:
						goto end_IL_0005;
						IL_015a:
						flag = (byte)num2 != 0;
						num = 9;
						continue;
					}
					goto IL_003a;
					continue;
					end_IL_0005:
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

	private void m(object A_0, EventArgs A_1)
	{
		c();
	}

	private void l(object A_0, EventArgs A_1)
	{
		this.m_s.BackColor = Color.White;
	}

	private void k(object A_0, EventArgs A_1)
	{
		this.m_s.BackColor = Color.Yellow;
		this.m_e = "txtLName";
	}

	private void j(object A_0, EventArgs A_1)
	{
		this.m_t.BackColor = Color.Yellow;
		this.m_e = "txtFName";
	}

	private void i(object A_0, EventArgs A_1)
	{
		this.m_t.BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F1;
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
					return;
				case 1:
					s(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		ad.BackColor = Color.Yellow;
		this.m_e = "txtCode";
	}

	private void g(object A_0, EventArgs A_1)
	{
		ad.BackColor = Color.White;
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
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
						if (aa.RowCount > 0)
						{
							if (true)
							{
							}
							num = 1;
						}
						else
						{
							num = 2;
						}
						continue;
					case 1:
						num = 6;
						continue;
					case 6:
						num2 = ((aa.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_01b3;
					case 4:
					{
						Rectangle bounds = Bounds;
						af.PageHeaderCenter = "لیست پرداخت های " + aa.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + aa.SelectedItems[0].GetRow().Cells["lname"].Value.ToString();
						af.DefaultPageSettings.Landscape = true;
						af.DefaultPageSettings.Margins.Left = 20;
						af.DefaultPageSettings.Margins.Right = 20;
						ah.SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
						ah.UseAntiAlias = true;
						ah.ShowDialog(this);
						num = 7;
						continue;
					}
					case 2:
						num2 = 1;
						goto IL_01b3;
					case 3:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 7;
					case 7:
						num = 0;
						continue;
					case 0:
						return;
						IL_01b3:
						flag = (byte)num2 != 0;
						num = 3;
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

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		f();
		e();
		b();
	}

	private void d(object A_0, EventArgs A_1)
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
					num = ((aa.RowCount <= 0) ? 6 : 5);
					continue;
				case 5:
					num = 1;
					continue;
				case 1:
					if (true)
					{
					}
					num2 = ((aa.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_00d8;
				case 3:
				{
					string text = aa.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asda4 asda10 = new asda4();
					asda10.__field_a = text;
					asda10.ShowDialog();
					num = 0;
					continue;
				}
				case 0:
					return;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 6:
					{
						num2 = 1;
						goto IL_00d8;
					}
					IL_00d8:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Refresh();
		d();
	}

	private void b(object A_0, EventArgs A_1)
	{
		am.Stop();
		b();
	}

	private void b()
	{
		if (true)
		{
		}
		aa.DataSource = null;
		x.DataSource = null;
		ak.Visible = true;
		Refresh();
		d();
	}

	private void a(object A_0, EventArgs A_1)
	{
		am.Stop();
		am.Start();
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
					num = ((!A_0) ? 1 : 5);
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_f == null) ? 1 : 0);
					goto IL_0074;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 2:
					if (true)
					{
					}
					this.m_f.Dispose();
					num = 4;
					continue;
				case 1:
					num2 = 1;
					goto IL_0074;
				case 4:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
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
		this.m_f = new Container();
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda5));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		this.m_g = new Panel();
		ac = new Panel();
		y = new Label();
		z = new UIGroupBox();
		x = new GridEX();
		this.m_l = new UIGroupBox();
		ak = new Panel();
		al = new Label();
		aj = new UIButton();
		ai = new UIComboBox();
		ad = new MaskedEditBox();
		ae = new Label();
		ab = new Label();
		aa = new GridEX();
		this.m_q = new Label();
		this.m_r = new Label();
		this.m_s = new EditBox();
		this.m_t = new EditBox();
		this.m_o = new Label();
		this.m_p = new UIComboBox();
		this.m_m = new Label();
		this.m_n = new UIComboBox();
		this.m_h = new Panel();
		ag = new UIButton();
		this.m_i = new UIButton();
		this.m_k = new UIButton();
		this.m_j = new UIButton();
		u = new UIButton();
		v = new OpenFileDialog();
		w = new Panel();
		af = new GridEXPrintDocument();
		ah = new PrintPreviewDialog();
		am = new Timer(this.m_f);
		this.m_g.SuspendLayout();
		ac.SuspendLayout();
		((ISupportInitialize)z).BeginInit();
		z.SuspendLayout();
		((ISupportInitialize)x).BeginInit();
		((ISupportInitialize)this.m_l).BeginInit();
		this.m_l.SuspendLayout();
		ak.SuspendLayout();
		((ISupportInitialize)aa).BeginInit();
		this.m_h.SuspendLayout();
		w.SuspendLayout();
		SuspendLayout();
		this.m_g.BackColor = Color.FromArgb(214, 223, 247);
		this.m_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_g.Controls.Add(ac);
		this.m_g.Controls.Add(z);
		this.m_g.Controls.Add(this.m_l);
		this.m_g.Controls.Add(this.m_h);
		this.m_g.Font = new Font("Tahoma", 8.25f);
		this.m_g.Location = new Point(5, 5);
		this.m_g.Name = "panel1";
		this.m_g.Size = new Size(790, 639);
		this.m_g.TabIndex = 0;
		this.m_g.Paint += a;
		ac.BackColor = SystemColors.HotTrack;
		ac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ac.Controls.Add(y);
		ac.Location = new Point(602, 246);
		ac.Name = "panelStd";
		ac.Size = new Size(177, 99);
		ac.TabIndex = 133;
		y.BackColor = Color.FromArgb(0, 192, 192);
		y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		y.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		y.Location = new Point(2, 2);
		y.Name = "lName";
		y.RightToLeft = RightToLeft.Yes;
		y.Size = new Size(171, 93);
		y.TabIndex = 77;
		y.TextAlign = ContentAlignment.MiddleCenter;
		z.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		z.Controls.Add(x);
		z.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		z.Location = new Point(12, 239);
		z.Name = "GroupBoxPay";
		z.Size = new Size(581, 394);
		z.TabIndex = 2;
		z.Text = "لیست پرداخت ها";
		x.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		x.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		x.DesignTimeLayout = gridEXLayout;
		x.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		x.Font = new Font("Tahoma", 8.25f);
		x.GroupByBoxVisible = false;
		x.Location = new Point(11, 31);
		x.Name = "gridEX2";
		x.RecordNavigator = true;
		x.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		x.Size = new Size(562, 358);
		x.TabIndex = 18;
		x.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
		x.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_l.Controls.Add(ak);
		this.m_l.Controls.Add(aj);
		this.m_l.Controls.Add(ai);
		this.m_l.Controls.Add(ad);
		this.m_l.Controls.Add(ae);
		this.m_l.Controls.Add(ab);
		this.m_l.Controls.Add(aa);
		this.m_l.Controls.Add(this.m_q);
		this.m_l.Controls.Add(this.m_r);
		this.m_l.Controls.Add(this.m_s);
		this.m_l.Controls.Add(this.m_t);
		this.m_l.Controls.Add(this.m_o);
		this.m_l.Controls.Add(this.m_p);
		this.m_l.Controls.Add(this.m_m);
		this.m_l.Controls.Add(this.m_n);
		this.m_l.Location = new Point(13, -1);
		this.m_l.Name = "uiGroupBox1";
		this.m_l.Size = new Size(764, 239);
		this.m_l.TabIndex = 0;
		this.m_l.Text = "جستجو";
		ak.Controls.Add(al);
		ak.Location = new Point(117, 69);
		ak.Name = "plode";
		ak.Size = new Size(305, 100);
		ak.TabIndex = 140;
		al.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		al.AutoSize = true;
		al.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		al.Location = new Point(62, 45);
		al.Name = "label8";
		al.Size = new Size(189, 13);
		al.TabIndex = 30;
		al.Text = "در حال بارگزاری لطفا کمی صبر کنید";
		aj.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		aj.Image = Resources.rptview;
		aj.Location = new Point(484, 202);
		aj.Name = "btnComment";
		aj.Size = new Size(203, 28);
		aj.TabIndex = 139;
		aj.Text = "یادداشت های دانش آموز";
		aj.Click += d;
		ai.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		ai.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ai.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "1403";
		uIComboBoxItem.Value = "1403";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "1402";
		uIComboBoxItem2.Value = "1402";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "1401";
		uIComboBoxItem3.Value = "1401";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "1400";
		uIComboBoxItem4.Value = "1400";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "1399";
		uIComboBoxItem5.Value = "1399";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "1398";
		uIComboBoxItem6.Value = "1398";
		ai.Items.AddRange(new UIComboBoxItem[6] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6 });
		ai.Location = new Point(586, 25);
		ai.Name = "dropYear";
		ai.Size = new Size(97, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		ai.StringFormat = stringFormat;
		ai.TabIndex = 138;
		ai.SelectedIndexChanged += e;
		ad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad.Location = new Point(484, 172);
		ad.MaxLength = 10;
		ad.Name = "txtCode";
		ad.Numeric = true;
		ad.RightToLeft = RightToLeft.Yes;
		ad.Size = new Size(201, 23);
		ad.TabIndex = 4;
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ad.TextChanged += a;
		ad.Leave += g;
		ad.Enter += h;
		ae.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		ae.AutoSize = true;
		ae.Location = new Point(691, 176);
		ae.Name = "label7";
		ae.Size = new Size(49, 13);
		ae.TabIndex = 137;
		ae.Text = "کد متعلم";
		ab.AutoSize = true;
		ab.Location = new Point(694, 30);
		ab.Name = "label10";
		ab.Size = new Size(66, 13);
		ab.TabIndex = 135;
		ab.Text = "سال تعلیمی";
		aa.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		aa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		aa.DesignTimeLayout = gridEXLayout2;
		aa.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		aa.Font = new Font("Tahoma", 8.25f);
		aa.GroupByBoxVisible = false;
		aa.Location = new Point(10, 13);
		aa.Name = "gridEX1";
		aa.RecordNavigator = true;
		aa.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		aa.Size = new Size(457, 215);
		aa.TabIndex = 30;
		aa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		aa.SelectionChanged += m;
		this.m_q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_q.AutoSize = true;
		this.m_q.Location = new Point(691, 150);
		this.m_q.Name = "label5";
		this.m_q.Size = new Size(48, 13);
		this.m_q.TabIndex = 29;
		this.m_q.Text = "ولد / بنت";
		this.m_r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_r.AutoSize = true;
		this.m_r.Location = new Point(696, 116);
		this.m_r.Name = "label4";
		this.m_r.Size = new Size(20, 13);
		this.m_r.TabIndex = 28;
		this.m_r.Text = "نام";
		this.m_s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_s.AutoScroll = false;
		this.m_s.AutoScrollMargin = new Size(0, 0);
		this.m_s.AutoScrollMinSize = new Size(0, 0);
		this.m_s.AutoScrollPosition = new Point(0, 0);
		this.m_s.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_s.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_s.Location = new Point(484, 144);
		this.m_s.Name = "txtLName";
		this.m_s.RightToLeft = RightToLeft.Yes;
		this.m_s.Size = new Size(201, 24);
		this.m_s.TabIndex = 3;
		this.m_s.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_s.TextChanged += a;
		this.m_s.Leave += l;
		this.m_s.Enter += k;
		this.m_t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_t.AutoScroll = false;
		this.m_t.AutoScrollMargin = new Size(0, 0);
		this.m_t.AutoScrollMinSize = new Size(0, 0);
		this.m_t.AutoScrollPosition = new Point(0, 0);
		this.m_t.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_t.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_t.Location = new Point(484, 115);
		this.m_t.Name = "txtFName";
		this.m_t.RightToLeft = RightToLeft.Yes;
		this.m_t.Size = new Size(201, 24);
		this.m_t.TabIndex = 2;
		this.m_t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_t.TextChanged += a;
		this.m_t.Leave += i;
		this.m_t.Enter += j;
		this.m_o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_o.AutoSize = true;
		this.m_o.Location = new Point(691, 89);
		this.m_o.Name = "label19";
		this.m_o.Size = new Size(30, 13);
		this.m_o.TabIndex = 25;
		this.m_o.Text = "صنف";
		this.m_p.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_p.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_p.DropListFont = new Font("Tahoma", 8.25f);
		this.m_p.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_p.Location = new Point(484, 85);
		this.m_p.Name = "dropCls";
		this.m_p.Size = new Size(201, 23);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		this.m_p.StringFormat = stringFormat2;
		this.m_p.TabIndex = 1;
		this.m_p.SelectedIndexChanged += o;
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.AutoSize = true;
		this.m_m.Location = new Point(691, 61);
		this.m_m.Name = "label20";
		this.m_m.Size = new Size(22, 13);
		this.m_m.TabIndex = 15;
		this.m_m.Text = "پایه";
		this.m_n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_n.DropListFont = new Font("B Nazanin", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_n.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_n.Location = new Point(484, 56);
		this.m_n.Name = "dropPaye";
		this.m_n.Size = new Size(201, 23);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		this.m_n.StringFormat = stringFormat3;
		this.m_n.TabIndex = 0;
		this.m_n.SelectedIndexChanged += p;
		this.m_h.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_h.Controls.Add(ag);
		this.m_h.Controls.Add(this.m_i);
		this.m_h.Controls.Add(this.m_k);
		this.m_h.Controls.Add(this.m_j);
		this.m_h.Controls.Add(u);
		this.m_h.Font = new Font("B Nazanin", 12f);
		this.m_h.Location = new Point(599, 351);
		this.m_h.Name = "p_new";
		this.m_h.Size = new Size(183, 283);
		this.m_h.TabIndex = 1;
		ag.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		ag.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		ag.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		ag.ImageSize = new Size(30, 30);
		ag.Location = new Point(15, 176);
		ag.Name = "btnPrint";
		ag.Size = new Size(149, 46);
		ag.TabIndex = 28;
		ag.Text = "چاپ";
		ag.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		ag.Click += f;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_i.Location = new Point(15, 119);
		this.m_i.Name = "btnDelete";
		this.m_i.Size = new Size(149, 46);
		this.m_i.TabIndex = 2;
		this.m_i.Text = "حذف";
		this.m_i.Click += n;
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_k.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_k.ImageSize = new Size(20, 20);
		this.m_k.Location = new Point(15, 234);
		this.m_k.Name = "btnClose";
		this.m_k.Size = new Size(149, 46);
		this.m_k.TabIndex = 3;
		this.m_k.Text = "بستن";
		this.m_k.Click += q;
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_j.Location = new Point(15, 16);
		this.m_j.Name = "btnNew";
		this.m_j.Size = new Size(149, 45);
		this.m_j.TabIndex = 0;
		this.m_j.Text = "ثبت مورد جدید(F1)";
		this.m_j.Click += s;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		u.Location = new Point(15, 67);
		u.Name = "btnEdit";
		u.Size = new Size(149, 46);
		u.TabIndex = 1;
		u.Text = "اصلاح";
		u.Click += r;
		v.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		v.Title = "انتخاب عکس شاگرد";
		w.BackColor = Color.Black;
		w.Controls.Add(this.m_g);
		w.Dock = DockStyle.Fill;
		w.Location = new Point(0, 0);
		w.Name = "panel2";
		w.Size = new Size(800, 650);
		w.TabIndex = 1;
		af.GridEX = x;
		ah.AutoScrollMargin = new Size(0, 0);
		ah.AutoScrollMinSize = new Size(0, 0);
		ah.ClientSize = new Size(400, 300);
		ah.Document = af;
		ah.Enabled = true;
		ah.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		ah.Name = "printPreviewDialog1";
		ah.Visible = false;
		am.Interval = 700;
		am.Tick += b;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 650);
		Controls.Add(w);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmPaymentAdd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست پرداخت های شاگرد";
		Load += t;
		Shown += c;
		KeyUp += a;
		this.m_g.ResumeLayout(performLayout: false);
		ac.ResumeLayout(performLayout: false);
		((ISupportInitialize)z).EndInit();
		z.ResumeLayout(performLayout: false);
		((ISupportInitialize)x).EndInit();
		((ISupportInitialize)this.m_l).EndInit();
		this.m_l.ResumeLayout(performLayout: false);
		this.m_l.PerformLayout();
		ak.ResumeLayout(performLayout: false);
		ak.PerformLayout();
		((ISupportInitialize)aa).EndInit();
		this.m_h.ResumeLayout(performLayout: false);
		w.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
