using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using school_Af.Rpt.afPayment;

public class asdbf : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private UIButton m_c;

	private UIButton m_d;

	private Label m_e;

	private UIComboBox f;

	private GridEX g;

	private Label h;

	private EditBox i;

	private EditBox j;

	private EditBox k;

	private EditBox l;

	private EditBox m;

	private UIComboBox n;

	public asdbf()
	{
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		DataTable dataSource = default;
		while (true)
		{
			bool flag = asdaj.a("10");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 9;
				case 4:
					((Control)j).Text = dataSource.Rows[0]["Foter1"].ToString();
					((Control)l).Text = dataSource.Rows[0]["Foter2"].ToString();
					((Control)i).Text = dataSource.Rows[0]["heder1"].ToString();
					((Control)m).Text = dataSource.Rows[0]["heder2"].ToString();
					((Control)k).Text = dataSource.Rows[0]["sch"].ToString();
					((Control)j).Tag = dataSource.Rows[0]["Foter1"].ToString();
					((Control)l).Tag = dataSource.Rows[0]["Foter2"].ToString();
					((Control)i).Tag = dataSource.Rows[0]["heder1"].ToString();
					((Control)m).Tag = dataSource.Rows[0]["heder2"].ToString();
					((Control)k).Tag = dataSource.Rows[0]["sch"].ToString();
					num = 8;
					continue;
				case 8:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 1;
					continue;
				case 1:
					return;
				case 9:
					n.SelectedValue = asdaj.a;
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptPayment");
					this.m_b.DataSource = dataSource;
					d();
					c();
					dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM         tParmetr");
					flag = dataSource.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 0:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 9;
					continue;
				case 2:
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			((CollectionBase)(object)f.Items).Clear();
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ") and id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + n.SelectedValue.ToString() + ") order by id");
			f.Items.Add("کل", (object)"0");
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
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 3;
						continue;
					}
					f.Items.Add(dataTable.Rows[num]["name"].ToString(), (object)dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 3:
					f.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			string text = " and xPaye in(" + asdaj.n + ")";
			bool flag = f.SelectedIndex <= 0;
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
					goto case 2;
				case 1:
					text = text + " and xPaye=" + f.SelectedValue.ToString();
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tclass where xYear=" + n.SelectedValue.ToString() + text);
					g.DataSource = dataSource;
					return;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		string[] array = default;
		bool flag = default;
		SqlParameter[] a_ = default;
		ReportClass val = default;
		DataTable dataSource = default;
		string text4 = default;
		while (true)
		{
			string text = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text2 = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			string text3 = "";
			int num = 0;
			int num2 = 24;
			while (true)
			{
				switch (num2)
				{
				case 18:
					array = text2.Split(new char[1] { ',' });
					flag = array.Length <= 1;
					num2 = 33;
					continue;
				case 33:
					if (!flag)
					{
						num2 = 30;
						continue;
					}
					goto case 12;
				case 26:
					num++;
					num2 = 2;
					continue;
				case 35:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString(), a_);
					((ReportDocument)val).Subreports[array[2].ToString()].SetDataSource(dataSource2);
					num2 = 32;
					continue;
				}
				case 22:
					text3 += ",";
					num2 = 37;
					continue;
				case 7:
				case 19:
				case 20:
				case 29:
					flag = !(text2 != "");
					num2 = 25;
					continue;
				case 25:
					if (!flag)
					{
						num2 = 18;
						continue;
					}
					goto case 13;
				case 27:
					num2 = 13;
					continue;
				case 5:
					num2 = 29;
					continue;
				case 9:
					flag = !(text3 == "");
					num2 = 15;
					continue;
				case 15:
					if (!flag)
					{
						num2 = 17;
						continue;
					}
					a_ = new SqlParameter[2]
					{
						asdcb.a("@Class", SqlDbType.VarChar, text3),
						asdcb.a("@xYear", SqlDbType.Int, n.SelectedValue.ToString())
					};
					dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString(), a_);
					val = null;
					text4 = text;
					num2 = 36;
					continue;
				case 32:
					flag = array.Length <= 5;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 21;
						continue;
					}
					goto case 27;
				case 13:
				{
					((ReportDocument)val).SetDataSource(dataSource);
					asda asda10 = new asda();
					asda10.a = val;
					((Form)asda10).ShowDialog();
					num2 = 16;
					continue;
				}
				case 16:
					return;
				case 4:
					num2 = 31;
					continue;
				case 31:
					if (text4 == "CrRptPayment1")
					{
						val = (ReportClass)(object)new CrRptPayment1();
						num2 = 7;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 28:
					if (!flag)
					{
						num2 = 23;
						continue;
					}
					goto case 26;
				case 2:
				case 24:
					flag = num < g.RowCount;
					num2 = 10;
					continue;
				case 10:
					if (flag)
					{
						flag = !(g.GetRow(num).Cells["Selector"].Value.ToString() == "True");
						num2 = 28;
					}
					else
					{
						num2 = 9;
					}
					continue;
				case 37:
					text3 += g.GetRow(num).Cells["id"].Value.ToString();
					num2 = 26;
					continue;
				case 36:
					if (text4 != null)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 21:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[5].ToString(), a_);
					((ReportDocument)val).Subreports[array[4].ToString()].SetDataSource(dataSource2);
					num2 = 27;
					continue;
				}
				case 30:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString(), a_);
					((ReportDocument)val).Subreports[array[0].ToString()].SetDataSource(dataSource2);
					num2 = 12;
					continue;
				}
				case 8:
					num2 = 3;
					continue;
				case 3:
					if (!(text4 == "CrRptSumPaymentGroupByClass"))
					{
						num2 = 6;
						continue;
					}
					val = (ReportClass)(object)new CrRptSumPaymentGroupByClass();
					num2 = 19;
					continue;
				case 6:
					num2 = 34;
					continue;
				case 34:
					if (!(text4 == "CrRptSumPaymentKoll"))
					{
						num2 = 5;
						continue;
					}
					val = (ReportClass)(object)new CrRptSumPaymentKoll();
					num2 = 20;
					continue;
				case 17:
					MessageBox.Show("صنفی انتخاب نشده است");
					if (true)
					{
					}
					num2 = 14;
					continue;
				case 14:
					return;
				case 23:
					flag = !(text3 != "");
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 22;
						continue;
					}
					goto case 37;
				case 12:
					flag = array.Length <= 3;
					num2 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 35;
						continue;
					}
					goto case 32;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = asdab.p >= int.Parse(n.SelectedValue.ToString());
			int num = 16;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 16:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = asdab.p != int.Parse(n.SelectedValue.ToString());
					num = 9;
					continue;
				case 19:
					num = 10;
					continue;
				case 10:
					num2 = ((!(((Control)k).Text != ((Control)k).Tag.ToString())) ? 1 : 0);
					goto IL_0166;
				case 8:
					num = 4;
					continue;
				case 4:
					if (!(((Control)i).Text != ((Control)i).Tag.ToString()))
					{
						num = 15;
						continue;
					}
					goto IL_01d5;
				case 20:
					flag = !(asdab.q != asdab.n);
					num = 18;
					continue;
				case 18:
					num = (flag ? 21 : 0);
					continue;
				case 13:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 7;
				case 9:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto case 21;
				case 12:
					num2 = 0;
					goto IL_0166;
				case 7:
					b();
					num = 22;
					continue;
				case 22:
					return;
				case 5:
					num = 11;
					continue;
				case 11:
					if (!(((Control)l).Text != ((Control)l).Tag.ToString()))
					{
						num = 8;
						continue;
					}
					goto IL_01d5;
				case 0:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 17;
					continue;
				case 17:
					if (1 == 0)
					{
					}
					return;
				case 6:
				{
					SqlParameter[] a_ = new SqlParameter[5]
					{
						asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)i).Text),
						asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)m).Text),
						asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)j).Text),
						asdcb.a("@Foter2", SqlDbType.NVarChar, ((Control)l).Text),
						asdcb.a("@sch", SqlDbType.NVarChar, ((Control)k).Text)
					};
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetParmetr", a_);
					num = 7;
					continue;
				}
				case 15:
					num = 14;
					continue;
				case 14:
					if (!(((Control)m).Text != ((Control)m).Tag.ToString()))
					{
						num = 19;
						continue;
					}
					goto IL_01d5;
				case 1:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 2;
					continue;
				case 2:
					return;
				case 21:
					num = 3;
					continue;
				case 3:
					{
						if (!(((Control)j).Text != ((Control)j).Tag.ToString()))
						{
							num = 5;
							continue;
						}
						goto IL_01d5;
					}
					IL_01d5:
					num = 12;
					continue;
					IL_0166:
					flag = (byte)num2 != 0;
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		c();
	}

	private void a(object A_0, EventArgs A_1)
	{
		d();
		c();
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (A_0)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 4;
					}
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 5:
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
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected Obj, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a82: Expected Obj, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbf));
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		UIComboBoxItem val7 = new UIComboBoxItem();
		UIComboBoxItem val8 = new UIComboBoxItem();
		UIComboBoxItem val9 = new UIComboBoxItem();
		StringFormat val10 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new Label();
		f = new UIComboBox();
		g = new GridEX();
		h = new Label();
		i = new EditBox();
		j = new EditBox();
		k = new EditBox();
		l = new EditBox();
		m = new EditBox();
		n = new UIComboBox();
		((ISupportInitialize)this.m_b).BeginInit();
		((ISupportInitialize)g).BeginInit();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(232, 18);
		((Control)this.m_b).Name = "gridEX1";
		((Control)this.m_b).RightToLeft = (RightToLeft)1;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(548, 538);
		((Control)this.m_b).TabIndex = 0;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		((Control)this.m_c).Location = new Point(12, 460);
		((Control)this.m_c).Name = "btnview";
		((Control)this.m_c).Size = new Size(193, 50);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "نمایش گزارش";
		((Control)this.m_c).Click += d;
		((Control)this.m_d).Anchor = (AnchorStyles)6;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		((Control)this.m_d).Location = new Point(12, 516);
		((Control)this.m_d).Name = "btnClose";
		((Control)this.m_d).Size = new Size(193, 42);
		((Control)this.m_d).TabIndex = 110;
		((Control)this.m_d).Text = "بستن";
		((Control)this.m_d).Click += c;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(181, 58);
		((Control)this.m_e).Name = "label20";
		((Control)this.m_e).Size = new Size(22, 13);
		((Control)this.m_e).TabIndex = 126;
		((Control)this.m_e).Text = "پایه";
		((Control)f).Anchor = (AnchorStyles)9;
		((UIComboBase)f).ComboStyle = (ComboStyle)1;
		((UIComboBase)f).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)f).Font = new Font("Tahoma", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)f).Location = new Point(12, 55);
		((Control)f).Name = "dropPaye";
		((Control)f).Size = new Size(164, 20);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)f).StringFormat = val2;
		((Control)f).TabIndex = 125;
		f.SelectedIndexChanged += b;
		((Control)g).Anchor = (AnchorStyles)10;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		g.DesignTimeLayout = val3;
		g.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)g).Font = new Font("B Nazanin", 9.75f, (FontStyle)1);
		g.GroupByBoxVisible = false;
		((Control)g).Location = new Point(12, 90);
		((Control)g).Name = "gClass";
		g.RowHeaders = (InheritableBoolean)1;
		((Control)g).Size = new Size(193, 356);
		((Control)g).TabIndex = 124;
		((ScrollableBase)g).VisualStyle = (VisualStyle)2;
		((Control)h).AutoSize = true;
		((Control)h).Location = new Point(116, 32);
		((Control)h).Name = "label8";
		((Control)h).Size = new Size(66, 13);
		((Control)h).TabIndex = 136;
		((Control)h).Text = "سال تعلیمی";
		((EditBase)i).AutoScroll = false;
		((EditBase)i).AutoScrollMargin = new Size(0, 0);
		((EditBase)i).AutoScrollMinSize = new Size(0, 0);
		((EditBase)i).AutoScrollPosition = new Point(0, 0);
		((Control)i).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(200, 489);
		((EditBase)i).MaxLength = 300;
		((Control)i).Name = "txtHeder1";
		((Control)i).Size = new Size(26, 28);
		((Control)i).TabIndex = 141;
		((EditBase)i).TextAlignment = (TextAlignment)1;
		((Control)i).Visible = false;
		((EditBase)j).AutoScroll = false;
		((EditBase)j).AutoScrollMargin = new Size(0, 0);
		((EditBase)j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)j).AutoScrollPosition = new Point(0, 0);
		((Control)j).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)j).Location = new Point(185, 534);
		((EditBase)j).MaxLength = 300;
		((Control)j).Name = "txtFoter1";
		((Control)j).Size = new Size(15, 28);
		((Control)j).TabIndex = 138;
		((EditBase)j).TextAlignment = (TextAlignment)1;
		((Control)j).Visible = false;
		((EditBase)k).AutoScroll = false;
		((EditBase)k).AutoScrollMargin = new Size(0, 0);
		((EditBase)k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)k).AutoScrollPosition = new Point(0, 0);
		((Control)k).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(212, 522);
		((EditBase)k).MaxLength = 300;
		((Control)k).Name = "txtSch";
		((Control)k).Size = new Size(14, 28);
		((Control)k).TabIndex = 137;
		((EditBase)k).TextAlignment = (TextAlignment)1;
		((Control)k).Visible = false;
		((EditBase)l).AutoScroll = false;
		((EditBase)l).AutoScrollMargin = new Size(0, 0);
		((EditBase)l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)l).AutoScrollPosition = new Point(0, 0);
		((Control)l).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(164, 497);
		((EditBase)l).MaxLength = 300;
		((Control)l).Name = "txtFoter2";
		((Control)l).Size = new Size(15, 28);
		((Control)l).TabIndex = 144;
		((EditBase)l).TextAlignment = (TextAlignment)1;
		((Control)l).Visible = false;
		((EditBase)m).AutoScroll = false;
		((EditBase)m).AutoScrollMargin = new Size(0, 0);
		((EditBase)m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)m).AutoScrollPosition = new Point(0, 0);
		((Control)m).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(164, 532);
		((EditBase)m).MaxLength = 300;
		((Control)m).Name = "txtHeder2";
		((Control)m).Size = new Size(15, 28);
		((Control)m).TabIndex = 143;
		((EditBase)m).TextAlignment = (TextAlignment)1;
		((Control)m).Visible = false;
		((UIComboBase)n).ComboStyle = (ComboStyle)1;
		((UIComboBase)n).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1403";
		val4.Value = "1403";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1402";
		val5.Value = "1402";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1401";
		val6.Value = "1401";
		val7.FormatStyle.Alpha = 0;
		val7.Text = "1400";
		val7.Value = "1400";
		val8.FormatStyle.Alpha = 0;
		val8.Text = "1399";
		val8.Value = "1399";
		val9.FormatStyle.Alpha = 0;
		val9.Text = "1398";
		val9.Value = "1398";
		n.Items.AddRange(new UIComboBoxItem[6] { val4, val5, val6, val7, val8, val9 });
		((Control)n).Location = new Point(12, 26);
		((Control)n).Name = "dropYear";
		((Control)n).Size = new Size(97, 23);
		val10.Alignment = (StringAlignment)0;
		val10.FormatFlags = (StringFormatFlags)20485;
		val10.HotkeyPrefix = (HotkeyPrefix)0;
		val10.LineAlignment = (StringAlignment)1;
		val10.Trimming = (StringTrimming)1;
		((UIComboBase)n).StringFormat = val10;
		((Control)n).TabIndex = 149;
		n.SelectedIndexChanged += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(792, 566);
		((Control)this).Controls.Add((Control)(object)n);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Control)this).Controls.Add((Control)(object)l);
		((Control)this).Controls.Add((Control)(object)m);
		((Control)this).Controls.Add((Control)(object)i);
		((Control)this).Controls.Add((Control)(object)j);
		((Control)this).Controls.Add((Control)(object)k);
		((Control)this).Controls.Add((Control)(object)h);
		((Control)this).Controls.Add((Control)(object)this.m_e);
		((Control)this).Controls.Add((Control)(object)f);
		((Control)this).Controls.Add((Control)(object)g);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmRptPayment";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "گزارش";
		((Form)this).Load += e;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)g).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
