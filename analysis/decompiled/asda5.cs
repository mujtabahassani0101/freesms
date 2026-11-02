using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)this.m_g).BackColor = Color.FromArgb(red, green, blue);
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
					ai.SelectedValue = asdaj.a;
					e();
					f();
					this.m_a = true;
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
			((CollectionBase)(object)this.m_n.Items).Clear();
			this.m_n.Items.Add("کل", (object)"0");
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
					this.m_n.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
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
					flag = !(((Control)ad).Text.Trim() != "");
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
					flag = !(((Control)this.m_s).Text.Trim() != "");
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
					text = text + " tstudent.code=" + asdaj.b(((Control)ad).Text);
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
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)this.m_s).Text) + "%'";
					num = 25;
					continue;
				case 33:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tStudent.id, tStudent.code, tStudent.NumberAsas, tStudent.FName, tStudent.LName, tStudent.PName, \r\n                 tClass.name AS Class, tPaye.Name AS Paye,tYear_Student.sort\r\n                        FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent INNER JOIN\r\n                      tPaye ON tYear_Student.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tYear_Student.xClass = tClass.id " + text);
					aa.DataSource = dataSource;
					((Control)ak).Visible = false;
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
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)this.m_t).Text) + "%'";
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
					((Control)z).Text = "لیست پرداخت های : ";
					x.DataSource = null;
					((Control)y).Text = "";
					num = 35;
					continue;
				case 35:
					return;
				case 3:
					flag = !(((Control)this.m_t).Text.Trim() != "");
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
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			x.DataSource = null;
			((Control)y).Text = "";
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
					Label val = y;
					((Control)val).Text = ((Control)val).Text + "\n" + aa.SelectedItems[0].GetRow().Cells["pname"].Value.ToString();
					num = 2;
					continue;
				}
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0266;
				case 1:
					((Control)y).Text = aa.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + aa.SelectedItems[0].GetRow().Cells["lname"].Value.ToString();
					((Control)z).Text = "لیست پرداخت های : " + ((Control)y).Text;
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
					num2 = (((int)aa.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_02de;
				case 0:
					return;
				case 4:
					{
						if (flag)
						{
							((Control)z).Text = "لیست پرداخت های : ";
							x.DataSource = null;
							((Control)y).Text = "";
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
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
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
									num2 = (((int)aa.SelectedItems[0].RowType != 0) ? 1 : 0);
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
					((Form)asdae2).ShowDialog();
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
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Invalid comparison between Unknown and I4
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
									num4 = (((int)aa.SelectedItems[0].RowType != 0) ? 1 : 0);
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
					((Form)asdae2).ShowDialog();
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
										num2 = (((int)x.SelectedItems[0].RowType != 0) ? 1 : 0);
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
		((Form)this).Close();
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
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Invalid comparison between Unknown and I4
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
						num2 = (((int)x.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_015a;
					case 6:
						asdcb.d(asdab.e(), CommandType.Text, "delete from tPaymentStudent where id=" + x.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						c();
						asdaj.i = true;
						num = 10;
						continue;
					case 0:
						flag = (int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
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
		((EditBase)this.m_s).BackColor = Color.White;
	}

	private void k(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_s).BackColor = Color.Yellow;
		this.m_e = "txtLName";
	}

	private void j(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_t).BackColor = Color.Yellow;
		this.m_e = "txtFName";
	}

	private void i(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_t).BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		if (true)
		{
		}
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 112;
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
		((EditBase)ad).BackColor = Color.Yellow;
		this.m_e = "txtCode";
	}

	private void g(object A_0, EventArgs A_1)
	{
		((EditBase)ad).BackColor = Color.White;
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
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
						num2 = (((int)aa.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_01b3;
					case 4:
					{
						Rectangle bounds = ((Control)this).Bounds;
						af.PageHeaderCenter = "لیست پرداخت های " + aa.SelectedItems[0].GetRow().Cells["fname"].Value.ToString() + " " + aa.SelectedItems[0].GetRow().Cells["lname"].Value.ToString();
						((PrintDocument)af).DefaultPageSettings.Landscape = true;
						((PrintDocument)af).DefaultPageSettings.Margins.Left = 20;
						((PrintDocument)af).DefaultPageSettings.Margins.Right = 20;
						((Form)ah).SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
						ah.UseAntiAlias = true;
						((Form)ah).ShowDialog((IWin32Window)(object)this);
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
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
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
					num2 = (((int)aa.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_00d8;
				case 3:
				{
					string text = aa.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asda4 asda10 = new asda4();
					asda10.a = text;
					((Form)asda10).ShowDialog();
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
		((Control)this).Refresh();
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
		((Control)ak).Visible = true;
		((Control)this).Refresh();
		d();
	}

	private void a(object A_0, EventArgs A_1)
	{
		am.Stop();
		am.Start();
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
						((Form)this).Dispose(A_0);
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected Obj, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected Obj, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected Obj, but got Unknown
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected Obj, but got Unknown
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected Obj, but got Unknown
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Expected Obj, but got Unknown
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Expected Obj, but got Unknown
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e2: Expected Obj, but got Unknown
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected Obj, but got Unknown
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_135e: Expected Obj, but got Unknown
		//IL_14ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b8: Expected Obj, but got Unknown
		//IL_14cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d6: Expected Obj, but got Unknown
		//IL_160d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1617: Expected Obj, but got Unknown
		//IL_1690: Unknown result type (might be due to invalid IL or missing references)
		//IL_169a: Expected Obj, but got Unknown
		//IL_16ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b6: Expected Obj, but got Unknown
		//IL_1783: Unknown result type (might be due to invalid IL or missing references)
		//IL_178d: Expected Obj, but got Unknown
		//IL_179f: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a9: Expected Obj, but got Unknown
		//IL_1843: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Expected Obj, but got Unknown
		//IL_185f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1869: Expected Obj, but got Unknown
		//IL_191b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1925: Expected Obj, but got Unknown
		//IL_1937: Unknown result type (might be due to invalid IL or missing references)
		//IL_1941: Expected Obj, but got Unknown
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e5: Expected Obj, but got Unknown
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a01: Expected Obj, but got Unknown
		//IL_1b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba6: Expected Obj, but got Unknown
		//IL_1ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cac: Expected Obj, but got Unknown
		if (true)
		{
		}
		this.m_f = new Container();
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda5));
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		StringFormat val8 = new StringFormat();
		GridEXLayout val9 = new GridEXLayout();
		StringFormat val10 = new StringFormat();
		StringFormat val11 = new StringFormat();
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
		((Control)this.m_g).SuspendLayout();
		((Control)ac).SuspendLayout();
		((ISupportInitialize)z).BeginInit();
		((Control)z).SuspendLayout();
		((ISupportInitialize)x).BeginInit();
		((ISupportInitialize)this.m_l).BeginInit();
		((Control)this.m_l).SuspendLayout();
		((Control)ak).SuspendLayout();
		((ISupportInitialize)aa).BeginInit();
		((Control)this.m_h).SuspendLayout();
		((Control)w).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_g).BackColor = Color.FromArgb(214, 223, 247);
		this.m_g.BorderStyle = (BorderStyle)1;
		((Control)this.m_g).Controls.Add((Control)(object)ac);
		((Control)this.m_g).Controls.Add((Control)(object)z);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_g).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_g).Location = new Point(5, 5);
		((Control)this.m_g).Name = "panel1";
		((Control)this.m_g).Size = new Size(790, 639);
		((Control)this.m_g).TabIndex = 0;
		((Control)this.m_g).Paint += a;
		((Control)ac).BackColor = SystemColors.HotTrack;
		ac.BorderStyle = (BorderStyle)1;
		((Control)ac).Controls.Add((Control)(object)y);
		((Control)ac).Location = new Point(602, 246);
		((Control)ac).Name = "panelStd";
		((Control)ac).Size = new Size(177, 99);
		((Control)ac).TabIndex = 133;
		((Control)y).BackColor = Color.FromArgb(0, 192, 192);
		y.BorderStyle = (BorderStyle)1;
		((Control)y).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(2, 2);
		((Control)y).Name = "lName";
		((Control)y).RightToLeft = (RightToLeft)1;
		((Control)y).Size = new Size(171, 93);
		((Control)y).TabIndex = 77;
		y.TextAlign = (ContentAlignment)32;
		((Control)z).Anchor = (AnchorStyles)13;
		((Control)z).Controls.Add((Control)(object)x);
		((Control)z).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)z).Location = new Point(12, 239);
		((Control)z).Name = "GroupBoxPay";
		((Control)z).Size = new Size(581, 394);
		((Control)z).TabIndex = 2;
		((Control)z).Text = "لیست پرداخت ها";
		x.AllowEdit = (InheritableBoolean)2;
		((Control)x).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		x.DesignTimeLayout = val;
		x.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)x).Font = new Font("Tahoma", 8.25f);
		x.GroupByBoxVisible = false;
		((Control)x).Location = new Point(11, 31);
		((Control)x).Name = "gridEX2";
		((ScrollableBase)x).RecordNavigator = true;
		x.RowHeaders = (InheritableBoolean)1;
		((Control)x).Size = new Size(562, 358);
		((Control)x).TabIndex = 18;
		x.TotalRow = (InheritableBoolean)1;
		((ScrollableBase)x).VisualStyle = (VisualStyle)2;
		((Control)this.m_l).Anchor = (AnchorStyles)13;
		((Control)this.m_l).Controls.Add((Control)(object)ak);
		((Control)this.m_l).Controls.Add((Control)(object)aj);
		((Control)this.m_l).Controls.Add((Control)(object)ai);
		((Control)this.m_l).Controls.Add((Control)(object)ad);
		((Control)this.m_l).Controls.Add((Control)(object)ae);
		((Control)this.m_l).Controls.Add((Control)(object)ab);
		((Control)this.m_l).Controls.Add((Control)(object)aa);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_q);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_r);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_s);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_t);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_o);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_p);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_l).Controls.Add((Control)(object)this.m_n);
		((Control)this.m_l).Location = new Point(13, -1);
		((Control)this.m_l).Name = "uiGroupBox1";
		((Control)this.m_l).Size = new Size(764, 239);
		((Control)this.m_l).TabIndex = 0;
		((Control)this.m_l).Text = "جستجو";
		((Control)ak).Controls.Add((Control)(object)al);
		((Control)ak).Location = new Point(117, 69);
		((Control)ak).Name = "plode";
		((Control)ak).Size = new Size(305, 100);
		((Control)ak).TabIndex = 140;
		((Control)al).Anchor = (AnchorStyles)9;
		((Control)al).AutoSize = true;
		((Control)al).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((Control)al).Location = new Point(62, 45);
		((Control)al).Name = "label8";
		((Control)al).Size = new Size(189, 13);
		((Control)al).TabIndex = 30;
		((Control)al).Text = "در حال بارگزاری لطفا کمی صبر کنید";
		((Control)aj).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		aj.Image = (Image)(object)Resources.rptview;
		((Control)aj).Location = new Point(484, 202);
		((Control)aj).Name = "btnComment";
		((Control)aj).Size = new Size(203, 28);
		((Control)aj).TabIndex = 139;
		((Control)aj).Text = "یادداشت های دانش آموز";
		((Control)aj).Click += d;
		((UIComboBase)ai).ComboStyle = (ComboStyle)1;
		((UIComboBase)ai).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ai).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "1403";
		val2.Value = "1403";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "1402";
		val3.Value = "1402";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1401";
		val4.Value = "1401";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1400";
		val5.Value = "1400";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1399";
		val6.Value = "1399";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1398";
		val7.Value = "1398";
		ai.Items.AddRange(new UIComboBoxItem[6] { val2, val3, val4, val5, val6, val7 });
		((Control)ai).Location = new Point(586, 25);
		((Control)ai).Name = "dropYear";
		((Control)ai).Size = new Size(97, 23);
		val8.Alignment = (StringAlignment)0;
		val8.FormatFlags = (StringFormatFlags)20485;
		val8.HotkeyPrefix = (HotkeyPrefix)0;
		val8.LineAlignment = (StringAlignment)1;
		val8.Trimming = (StringTrimming)1;
		((UIComboBase)ai).StringFormat = val8;
		((Control)ai).TabIndex = 138;
		ai.SelectedIndexChanged += e;
		((Control)ad).Anchor = (AnchorStyles)9;
		((EditBase)ad).AutoScroll = false;
		((EditBase)ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ad).AutoScrollPosition = new Point(0, 0);
		((EditBase)ad).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ad).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)ad).Location = new Point(484, 172);
		((EditBase)ad).MaxLength = 10;
		((Control)ad).Name = "txtCode";
		ad.Numeric = true;
		((Control)ad).RightToLeft = (RightToLeft)1;
		((Control)ad).Size = new Size(201, 23);
		((Control)ad).TabIndex = 4;
		((EditBase)ad).TextAlignment = (TextAlignment)1;
		((Control)ad).TextChanged += a;
		((Control)ad).Leave += g;
		((Control)ad).Enter += h;
		((Control)ae).Anchor = (AnchorStyles)9;
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(691, 176);
		((Control)ae).Name = "label7";
		((Control)ae).Size = new Size(49, 13);
		((Control)ae).TabIndex = 137;
		((Control)ae).Text = "کد متعلم";
		((Control)ab).AutoSize = true;
		((Control)ab).Location = new Point(694, 30);
		((Control)ab).Name = "label10";
		((Control)ab).Size = new Size(66, 13);
		((Control)ab).TabIndex = 135;
		((Control)ab).Text = "سال تعلیمی";
		aa.AllowEdit = (InheritableBoolean)2;
		((Control)aa).Anchor = (AnchorStyles)15;
		val9.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		aa.DesignTimeLayout = val9;
		aa.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)aa).Font = new Font("Tahoma", 8.25f);
		aa.GroupByBoxVisible = false;
		((Control)aa).Location = new Point(10, 13);
		((Control)aa).Name = "gridEX1";
		((ScrollableBase)aa).RecordNavigator = true;
		aa.RowHeaders = (InheritableBoolean)1;
		((Control)aa).Size = new Size(457, 215);
		((Control)aa).TabIndex = 30;
		((ScrollableBase)aa).VisualStyle = (VisualStyle)2;
		aa.SelectionChanged += m;
		((Control)this.m_q).Anchor = (AnchorStyles)9;
		((Control)this.m_q).AutoSize = true;
		((Control)this.m_q).Location = new Point(691, 150);
		((Control)this.m_q).Name = "label5";
		((Control)this.m_q).Size = new Size(48, 13);
		((Control)this.m_q).TabIndex = 29;
		((Control)this.m_q).Text = "ولد / بنت";
		((Control)this.m_r).Anchor = (AnchorStyles)9;
		((Control)this.m_r).AutoSize = true;
		((Control)this.m_r).Location = new Point(696, 116);
		((Control)this.m_r).Name = "label4";
		((Control)this.m_r).Size = new Size(20, 13);
		((Control)this.m_r).TabIndex = 28;
		((Control)this.m_r).Text = "نام";
		((Control)this.m_s).Anchor = (AnchorStyles)9;
		((EditBase)this.m_s).AutoScroll = false;
		((EditBase)this.m_s).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_s).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_s).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_s).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_s).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_s).Location = new Point(484, 144);
		((Control)this.m_s).Name = "txtLName";
		((Control)this.m_s).RightToLeft = (RightToLeft)1;
		((Control)this.m_s).Size = new Size(201, 24);
		((Control)this.m_s).TabIndex = 3;
		((EditBase)this.m_s).TextAlignment = (TextAlignment)1;
		((Control)this.m_s).TextChanged += a;
		((Control)this.m_s).Leave += l;
		((Control)this.m_s).Enter += k;
		((Control)this.m_t).Anchor = (AnchorStyles)9;
		((EditBase)this.m_t).AutoScroll = false;
		((EditBase)this.m_t).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_t).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_t).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_t).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_t).Location = new Point(484, 115);
		((Control)this.m_t).Name = "txtFName";
		((Control)this.m_t).RightToLeft = (RightToLeft)1;
		((Control)this.m_t).Size = new Size(201, 24);
		((Control)this.m_t).TabIndex = 2;
		((EditBase)this.m_t).TextAlignment = (TextAlignment)1;
		((Control)this.m_t).TextChanged += a;
		((Control)this.m_t).Leave += i;
		((Control)this.m_t).Enter += j;
		((Control)this.m_o).Anchor = (AnchorStyles)9;
		((Control)this.m_o).AutoSize = true;
		((Control)this.m_o).Location = new Point(691, 89);
		((Control)this.m_o).Name = "label19";
		((Control)this.m_o).Size = new Size(30, 13);
		((Control)this.m_o).TabIndex = 25;
		((Control)this.m_o).Text = "صنف";
		((Control)this.m_p).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_p).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_p).DropListFont = new Font("Tahoma", 8.25f);
		((Control)this.m_p).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_p).Location = new Point(484, 85);
		((Control)this.m_p).Name = "dropCls";
		((Control)this.m_p).Size = new Size(201, 23);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_p).StringFormat = val10;
		((Control)this.m_p).TabIndex = 1;
		this.m_p.SelectedIndexChanged += o;
		((Control)this.m_m).Anchor = (AnchorStyles)9;
		((Control)this.m_m).AutoSize = true;
		((Control)this.m_m).Location = new Point(691, 61);
		((Control)this.m_m).Name = "label20";
		((Control)this.m_m).Size = new Size(22, 13);
		((Control)this.m_m).TabIndex = 15;
		((Control)this.m_m).Text = "پایه";
		((Control)this.m_n).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_n).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_n).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_n).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_n).Location = new Point(484, 56);
		((Control)this.m_n).Name = "dropPaye";
		((Control)this.m_n).Size = new Size(201, 23);
		val11.Alignment = (StringAlignment)0;
		val11.FormatFlags = (StringFormatFlags)20485;
		val11.HotkeyPrefix = (HotkeyPrefix)0;
		val11.LineAlignment = (StringAlignment)1;
		val11.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_n).StringFormat = val11;
		((Control)this.m_n).TabIndex = 0;
		this.m_n.SelectedIndexChanged += p;
		((Control)this.m_h).Anchor = (AnchorStyles)10;
		((Control)this.m_h).Controls.Add((Control)(object)ag);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_h).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_h).Controls.Add((Control)(object)u);
		((Control)this.m_h).Font = new Font("B Nazanin", 12f);
		((Control)this.m_h).Location = new Point(599, 351);
		((Control)this.m_h).Name = "p_new";
		((Control)this.m_h).Size = new Size(183, 283);
		((Control)this.m_h).TabIndex = 1;
		ag.ButtonStyle = (ButtonStyle)1;
		((Control)ag).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		ag.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		ag.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		ag.ImageSize = new Size(30, 30);
		((Control)ag).Location = new Point(15, 176);
		((Control)ag).Name = "btnPrint";
		((Control)ag).Size = new Size(149, 46);
		((Control)ag).TabIndex = 28;
		((Control)ag).Text = "چاپ";
		ag.VisualStyle = (VisualStyle)1;
		((Control)ag).Click += f;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_i).Location = new Point(15, 119);
		((Control)this.m_i).Name = "btnDelete";
		((Control)this.m_i).Size = new Size(149, 46);
		((Control)this.m_i).TabIndex = 2;
		((Control)this.m_i).Text = "حذف";
		((Control)this.m_i).Click += n;
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((Control)this.m_k).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_k.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_k.ImageSize = new Size(20, 20);
		((Control)this.m_k).Location = new Point(15, 234);
		((Control)this.m_k).Name = "btnClose";
		((Control)this.m_k).Size = new Size(149, 46);
		((Control)this.m_k).TabIndex = 3;
		((Control)this.m_k).Text = "بستن";
		((Control)this.m_k).Click += q;
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((Control)this.m_j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_j).Location = new Point(15, 16);
		((Control)this.m_j).Name = "btnNew";
		((Control)this.m_j).Size = new Size(149, 45);
		((Control)this.m_j).TabIndex = 0;
		((Control)this.m_j).Text = "ثبت مورد جدید(F1)";
		((Control)this.m_j).Click += s;
		((Control)u).Anchor = (AnchorStyles)9;
		((Control)u).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		u.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)u).Location = new Point(15, 67);
		((Control)u).Name = "btnEdit";
		((Control)u).Size = new Size(149, 46);
		((Control)u).TabIndex = 1;
		((Control)u).Text = "اصلاح";
		((Control)u).Click += r;
		((FileDialog)v).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)v).Title = "انتخاب عکس شاگرد";
		((Control)w).BackColor = Color.Black;
		((Control)w).Controls.Add((Control)(object)this.m_g);
		((Control)w).Dock = (DockStyle)5;
		((Control)w).Location = new Point(0, 0);
		((Control)w).Name = "panel2";
		((Control)w).Size = new Size(800, 650);
		((Control)w).TabIndex = 1;
		af.GridEX = x;
		ah.AutoScrollMargin = new Size(0, 0);
		ah.AutoScrollMinSize = new Size(0, 0);
		((Form)ah).ClientSize = new Size(400, 300);
		ah.Document = (PrintDocument)(object)af;
		ah.Enabled = true;
		ah.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)ah).Name = "printPreviewDialog1";
		ah.Visible = false;
		am.Interval = 700;
		am.Tick += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 650);
		((Control)this).Controls.Add((Control)(object)w);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmPaymentAdd";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += t;
		((Form)this).Shown += c;
		((Control)this).KeyUp += a;
		((Control)this.m_g).ResumeLayout(false);
		((Control)ac).ResumeLayout(false);
		((ISupportInitialize)z).EndInit();
		((Control)z).ResumeLayout(false);
		((ISupportInitialize)x).EndInit();
		((ISupportInitialize)this.m_l).EndInit();
		((Control)this.m_l).ResumeLayout(false);
		((Control)this.m_l).PerformLayout();
		((Control)ak).ResumeLayout(false);
		((Control)ak).PerformLayout();
		((ISupportInitialize)aa).EndInit();
		((Control)this.m_h).ResumeLayout(false);
		((Control)w).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
