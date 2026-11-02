using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;

public class asda4 : Form
{
	public string a;

	private int m_b = 0;

	private int m_c = 0;

	private IContainer m_d = null;

	private Panel m_e;

	private Panel m_f;

	private UIButton g;

	private UIButton h;

	private UIButton i;

	private UIButton j;

	private OpenFileDialog k;

	private Panel l;

	private GridEX m;

	private Label n;

	private UIGroupBox o;

	private Panel p;

	private GridEXPrintDocument q;

	private UIButton r;

	private PrintPreviewDialog s;

	public asda4()
	{
		a();
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
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
					goto case 0;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_e).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 2:
					num = 3;
					continue;
				case 0:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xStudent", SqlDbType.Int, this.a) };
					DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select code,fname,lname from tstudent where  id=@xStudent", a_);
					((Control)n).Text = dataTable2.Rows[0]["fname"].ToString() + " - " + dataTable2.Rows[0]["lname"].ToString();
					b();
					return;
				}
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
		this.m_c = this.m_b;
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tComnentStd.id, tComnentStd.xStudent, tComnentStd.xYear, tComnentStd.dayOfWeek, tComnentStd.subject, tComnentStd.Comment, tComnentStd.DateInsert, \r\n                      tuser.uid AS UserInsert\r\nFROM         tComnentStd LEFT OUTER JOIN\r\n                      tuser ON tComnentStd.xUserInsert = tuser.id\r\nWHERE   deleteDate is null and  tComnentStd.xStudent = " + this.a);
		m.DataSource = dataSource;
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		asdbb asdbb2 = new asdbb();
		asdbb2.a = this.a;
		asdbb2.c = "0";
		asdbb2.b = asdaj.a;
		((Form)asdbb2).ShowDialog();
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Invalid comparison between Unknown and I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			string text = "";
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num2 = 1;
					goto IL_02b9;
				case 5:
					num = 1;
					continue;
				case 1:
					num2 = ((!(text != "")) ? 1 : 0);
					goto IL_02b9;
				case 0:
				{
					asdbb asdbb2 = new asdbb();
					asdbb2.a = this.a;
					asdbb2.c = text;
					((Form)asdbb2).ShowDialog();
					b();
					num = 3;
					continue;
				}
				case 3:
					return;
				case 2:
					try
					{
						while (true)
						{
							IL_00f1:
							num = 9;
							while (true)
							{
								int num4;
								int num3;
								switch (num)
								{
								case 9:
									num = ((m.RowCount <= 0) ? 4 : 3);
									continue;
								case 1:
									num4 = 1;
									goto IL_027b;
								case 4:
									num3 = 1;
									goto IL_0207;
								case 5:
									MessageBox.Show("این یادداشت توسط کاربر دیگری ثبت شده و امکان اصلاح برای شما وجود ندارد", "خطای دسترسی");
									num = 7;
									continue;
								case 7:
									return;
								case 10:
									num = 13;
									continue;
								case 13:
									num = ((!(asdaj.l != "1")) ? 1 : 11);
									continue;
								case 3:
									num = 6;
									continue;
								case 6:
									num3 = (((int)m.SelectedItems[0].RowType != 0) ? 1 : 0);
									goto IL_0207;
								case 8:
									if (!flag)
									{
										num = 10;
										continue;
									}
									goto case 2;
								case 11:
									num = 12;
									continue;
								case 12:
									num4 = ((!(m.SelectedItems[0].GetRow().Cells["xUserInsert"].Value.ToString() != asdaj.l)) ? 1 : 0);
									goto IL_027b;
								case 0:
									if (flag)
									{
										text = m.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
										num = 2;
									}
									else
									{
										num = 5;
									}
									continue;
								case 2:
									num = 14;
									continue;
								case 14:
									goto end_IL_00ac;
									IL_0207:
									flag = (byte)num3 != 0;
									num = 8;
									continue;
									IL_027b:
									flag = (byte)num4 != 0;
									num = 0;
									continue;
								}
								goto IL_00f1;
								continue;
								end_IL_00ac:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 6;
					continue;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 6:
					{
						num = ((this.a != "") ? 5 : 7);
						continue;
					}
					IL_02b9:
					flag = (byte)num2 != 0;
					num = 4;
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

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Invalid comparison between Unknown and I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		try
		{
			bool flag = default;
			while (true)
			{
				IL_005c:
				int num = 7;
				while (true)
				{
					int num3;
					int num2;
					switch (num)
					{
					case 0:
						goto end_IL_000b;
					case 7:
						num = ((m.RowCount <= 0) ? 11 : 5);
						continue;
					case 2:
						if (!flag)
						{
							num = 17;
							continue;
						}
						goto case 6;
					case 11:
						num3 = 1;
						goto IL_0120;
					case 8:
						MessageBox.Show("این یادداشت توسط کاربر دیگری ثبت شده و امکان حذف برای شما وجود ندارد", "خطای دسترسی");
						num = 13;
						continue;
					case 13:
						goto end_IL_000b;
					case 6:
						num = 12;
						continue;
					case 15:
						num2 = 1;
						goto IL_01d7;
					case 10:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 12;
					case 17:
						asdcb.d(asdab.e(), CommandType.Text, "update tComnentStd set deleteDate=N'" + asdab.d() + "-" + asdab.c() + "' where id=" + m.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						b();
						num = 6;
						continue;
					case 9:
						if (flag)
						{
							flag = (int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
							num = 2;
						}
						else
						{
							num = 8;
						}
						continue;
					case 4:
						num = 3;
						continue;
					case 3:
						num = ((asdaj.l != "1") ? 16 : 15);
						continue;
					case 5:
						num = 1;
						continue;
					case 1:
						num3 = (((int)m.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_0120;
					case 16:
						num = 14;
						continue;
					case 14:
						num2 = ((!(m.SelectedItems[0].GetRow().Cells["xUserInsert"].Value.ToString() != asdaj.l)) ? 1 : 0);
						goto IL_01d7;
					case 12:
						{
							num = 0;
							continue;
						}
						IL_0120:
						flag = (byte)num3 != 0;
						num = 10;
						continue;
						IL_01d7:
						flag = (byte)num2 != 0;
						num = 9;
						continue;
					}
					goto IL_005c;
					continue;
					end_IL_000b:
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

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)A_1.KeyCode != 112;
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
					return;
				case 2:
					e(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool flag = default;
			while (true)
			{
				IL_002e:
				int num = 3;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 3:
						num = ((m.RowCount > 0) ? 5 : 0);
						continue;
					case 5:
						num = 2;
						continue;
					case 2:
						num2 = (((int)m.SelectedItems[0].RowType != 0) ? 1 : 0);
						goto IL_0153;
					case 4:
					{
						Rectangle bounds = ((Control)this).Bounds;
						q.PageHeaderCenter = "لیست یادداشت های " + ((Control)n).Text;
						((PrintDocument)q).DefaultPageSettings.Landscape = true;
						((PrintDocument)q).DefaultPageSettings.Margins.Left = 20;
						((PrintDocument)q).DefaultPageSettings.Margins.Right = 20;
						((Form)s).SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
						s.UseAntiAlias = true;
						((Form)s).ShowDialog((IWin32Window)(object)this);
						num = 6;
						continue;
					}
					case 0:
						num2 = 1;
						goto IL_0153;
					case 1:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 6;
					case 6:
						num = 7;
						continue;
					case 7:
						goto end_IL_0005;
						IL_0153:
						flag = (byte)num2 != 0;
						num = 1;
						continue;
					}
					goto IL_002e;
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

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((!A_0) ? 6 : 5);
					continue;
				case 5:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_d == null) ? 1 : 0);
					goto IL_0074;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 3:
					if (true)
					{
					}
					this.m_d.Dispose();
					num = 1;
					continue;
				case 6:
					num2 = 1;
					goto IL_0074;
				case 1:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 4;
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
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected Obj, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected Obj, but got Unknown
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected Obj, but got Unknown
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda4));
		this.m_e = new Panel();
		p = new Panel();
		n = new Label();
		o = new UIGroupBox();
		m = new GridEX();
		this.m_f = new Panel();
		r = new UIButton();
		g = new UIButton();
		i = new UIButton();
		h = new UIButton();
		j = new UIButton();
		k = new OpenFileDialog();
		l = new Panel();
		q = new GridEXPrintDocument();
		s = new PrintPreviewDialog();
		((Control)this.m_e).SuspendLayout();
		((Control)p).SuspendLayout();
		((ISupportInitialize)o).BeginInit();
		((Control)o).SuspendLayout();
		((ISupportInitialize)m).BeginInit();
		((Control)this.m_f).SuspendLayout();
		((Control)l).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_e).BackColor = Color.FromArgb(214, 223, 247);
		this.m_e.BorderStyle = (BorderStyle)1;
		((Control)this.m_e).Controls.Add((Control)(object)p);
		((Control)this.m_e).Controls.Add((Control)(object)o);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_e).Location = new Point(5, 5);
		((Control)this.m_e).Name = "panel1";
		((Control)this.m_e).Size = new Size(790, 639);
		((Control)this.m_e).TabIndex = 0;
		((Control)this.m_e).Paint += a;
		((Control)p).BackColor = SystemColors.HotTrack;
		p.BorderStyle = (BorderStyle)1;
		((Control)p).Controls.Add((Control)(object)n);
		((Control)p).Location = new Point(217, 8);
		((Control)p).Name = "panelStd";
		((Control)p).Size = new Size(365, 57);
		((Control)p).TabIndex = 133;
		((Control)n).BackColor = Color.FromArgb(0, 192, 192);
		n.BorderStyle = (BorderStyle)1;
		((Control)n).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(2, 2);
		((Control)n).Name = "lName";
		((Control)n).RightToLeft = (RightToLeft)1;
		((Control)n).Size = new Size(358, 50);
		((Control)n).TabIndex = 77;
		n.TextAlign = (ContentAlignment)32;
		((Control)o).Anchor = (AnchorStyles)13;
		((Control)o).Controls.Add((Control)(object)m);
		((Control)o).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(12, 71);
		((Control)o).Name = "GroupBoxPay";
		((Control)o).Size = new Size(763, 489);
		((Control)o).TabIndex = 2;
		((Control)o).Text = "لیست یادداشت های ثبت شده برای دانش آموز";
		m.AllowEdit = (InheritableBoolean)2;
		((Control)m).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		m.DesignTimeLayout = val;
		m.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)m).Font = new Font("Tahoma", 8.25f);
		m.GroupByBoxVisible = false;
		((Control)m).Location = new Point(11, 31);
		((Control)m).Name = "gridEX1";
		((ScrollableBase)m).RecordNavigator = true;
		m.RowHeaders = (InheritableBoolean)1;
		m.SelectedFormatStyle.BackColor = Color.FromArgb(0, 0, 64);
		((Control)m).Size = new Size(744, 416);
		((Control)m).TabIndex = 18;
		((ScrollableBase)m).VisualStyle = (VisualStyle)2;
		((Control)this.m_f).Anchor = (AnchorStyles)10;
		((Control)this.m_f).Controls.Add((Control)(object)r);
		((Control)this.m_f).Controls.Add((Control)(object)g);
		((Control)this.m_f).Controls.Add((Control)(object)i);
		((Control)this.m_f).Controls.Add((Control)(object)h);
		((Control)this.m_f).Controls.Add((Control)(object)j);
		((Control)this.m_f).Font = new Font("B Nazanin", 12f);
		((Control)this.m_f).Location = new Point(15, 572);
		((Control)this.m_f).Name = "p_new";
		((Control)this.m_f).Size = new Size(760, 56);
		((Control)this.m_f).TabIndex = 1;
		r.ButtonStyle = (ButtonStyle)1;
		((Control)r).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		r.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		r.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		r.ImageSize = new Size(30, 30);
		((Control)r).Location = new Point(150, 3);
		((Control)r).Name = "btnPrint";
		((Control)r).Size = new Size(126, 46);
		((Control)r).TabIndex = 28;
		((Control)r).Text = "چاپ";
		r.VisualStyle = (VisualStyle)1;
		((Control)r).Click += a;
		((Control)g).Anchor = (AnchorStyles)9;
		((Control)g).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		g.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)g).Location = new Point(299, 3);
		((Control)g).Name = "btnDelete";
		((Control)g).Size = new Size(124, 46);
		((Control)g).TabIndex = 2;
		((Control)g).Text = "حذف";
		((Control)g).Click += b;
		((Control)i).Anchor = (AnchorStyles)9;
		((Control)i).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(20, 20);
		((Control)i).Location = new Point(3, 3);
		((Control)i).Name = "btnClose";
		((Control)i).Size = new Size(120, 46);
		((Control)i).TabIndex = 3;
		((Control)i).Text = "بستن";
		((Control)i).Click += c;
		((Control)h).Anchor = (AnchorStyles)9;
		((Control)h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		h.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)h).Location = new Point(569, 4);
		((Control)h).Name = "btnNew";
		((Control)h).Size = new Size(183, 45);
		((Control)h).TabIndex = 0;
		((Control)h).Text = "ثبت یادداشت جدید(F1)";
		((Control)h).Click += e;
		((Control)j).Anchor = (AnchorStyles)9;
		((Control)j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		j.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)j).Location = new Point(444, 3);
		((Control)j).Name = "btnEdit";
		((Control)j).Size = new Size(119, 46);
		((Control)j).TabIndex = 1;
		((Control)j).Text = "اصلاح";
		((Control)j).Click += d;
		((FileDialog)k).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)k).Title = "انتخاب عکس شاگرد";
		((Control)l).BackColor = Color.Black;
		((Control)l).Controls.Add((Control)(object)this.m_e);
		((Control)l).Dock = (DockStyle)5;
		((Control)l).Location = new Point(0, 0);
		((Control)l).Name = "panel2";
		((Control)l).Size = new Size(800, 650);
		((Control)l).TabIndex = 1;
		q.GridEX = m;
		s.AutoScrollMargin = new Size(0, 0);
		s.AutoScrollMinSize = new Size(0, 0);
		((Form)s).ClientSize = new Size(400, 300);
		s.Document = (PrintDocument)(object)q;
		s.Enabled = true;
		s.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)s).Name = "printPreviewDialog1";
		s.Visible = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 650);
		((Control)this).Controls.Add((Control)(object)l);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmCommentAdd";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پرداخت های شاگرد";
		((Form)this).Load += f;
		((Control)this).KeyUp += a;
		((Control)this.m_e).ResumeLayout(false);
		((Control)p).ResumeLayout(false);
		((ISupportInitialize)o).EndInit();
		((Control)o).ResumeLayout(false);
		((ISupportInitialize)m).EndInit();
		((Control)this.m_f).ResumeLayout(false);
		((Control)l).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
