using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asda1 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Label m_d;

	private Label m_e;

	private MaskedEditBox m_f;

	private TextBox m_g;

	private Label m_h;

	private UIButton i;

	private UIButton j;

	private Panel k;

	private GridEX l;

	private UIButton m;

	private UIButton n;

	private UIButton o;

	private Panel p;

	private UIButton q;

	private Panel r;

	private Label s;

	private string t = "insert";

	private int u;

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 1;
					}
					continue;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
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
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected Obj, but got Unknown
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected Obj, but got Unknown
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected Obj, but got Unknown
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected Obj, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda1));
		GridEXLayout val = new GridEXLayout();
		this.m_b = new Panel();
		r = new Panel();
		p = new Panel();
		o = new UIButton();
		n = new UIButton();
		m = new UIButton();
		q = new UIButton();
		k = new Panel();
		this.m_c = new Panel();
		this.m_d = new Label();
		this.m_e = new Label();
		this.m_f = new MaskedEditBox();
		this.m_g = new TextBox();
		this.m_h = new Label();
		i = new UIButton();
		j = new UIButton();
		l = new GridEX();
		s = new Label();
		((Control)this.m_b).SuspendLayout();
		((Control)r).SuspendLayout();
		((Control)p).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.ControlText;
		((Control)this.m_b).Controls.Add((Control)(object)r);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(424, 454);
		((Control)this.m_b).TabIndex = 31;
		((Control)r).BackColor = SystemColors.GradientInactiveCaption;
		r.BorderStyle = (BorderStyle)1;
		((Control)r).Controls.Add((Control)(object)s);
		((Control)r).Controls.Add((Control)(object)p);
		((Control)r).Controls.Add((Control)(object)q);
		((Control)r).Controls.Add((Control)(object)k);
		((Control)r).Controls.Add((Control)(object)l);
		((Control)r).Font = new Font("Tahoma", 8.25f);
		((Control)r).Location = new Point(5, 5);
		((Control)r).Name = "panel3";
		((Control)r).Size = new Size(414, 444);
		((Control)r).TabIndex = 0;
		((Control)p).Anchor = (AnchorStyles)10;
		((Control)p).Controls.Add((Control)(object)o);
		((Control)p).Controls.Add((Control)(object)n);
		((Control)p).Controls.Add((Control)(object)m);
		((Control)p).Location = new Point(142, 389);
		((Control)p).Name = "p_new";
		((Control)p).Size = new Size(258, 43);
		((Control)p).TabIndex = 29;
		o.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)o).Location = new Point(3, 6);
		((Control)o).Name = "btnDelete";
		((Control)o).Size = new Size(78, 34);
		((Control)o).TabIndex = 2;
		((Control)o).Text = "حذف";
		((Control)o).Click += a;
		n.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)n).Location = new Point(170, 6);
		((Control)n).Name = "btnNew";
		((Control)n).Size = new Size(85, 34);
		((Control)n).TabIndex = 0;
		((Control)n).Text = "جدید";
		((Control)n).Click += g;
		m.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)m).Location = new Point(87, 6);
		((Control)m).Name = "btnEdit";
		((Control)m).Size = new Size(77, 34);
		((Control)m).TabIndex = 1;
		((Control)m).Text = "اصلاح";
		((Control)m).Click += d;
		((Control)q).Anchor = (AnchorStyles)6;
		q.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		q.ImageSize = new Size(40, 40);
		((Control)q).Location = new Point(16, 392);
		((Control)q).Name = "btnClose";
		((Control)q).Size = new Size(110, 40);
		((Control)q).TabIndex = 30;
		((Control)q).Text = "بستن";
		((Control)q).Click += b;
		((Control)k).BackColor = Color.Gray;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Controls.Add((Control)(object)this.m_c);
		((Control)k).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(18, 160);
		((Control)k).Name = "pStd";
		((Control)k).Size = new Size(375, 207);
		((Control)k).TabIndex = 0;
		((Control)k).Visible = false;
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)2;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Location = new Point(6, 7);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(359, 189);
		((Control)this.m_c).TabIndex = 40;
		((Control)this.m_d).AutoSize = true;
		((Control)this.m_d).Location = new Point(149, 81);
		((Control)this.m_d).Name = "label6";
		((Control)this.m_d).Size = new Size(28, 28);
		((Control)this.m_d).TabIndex = 50;
		((Control)this.m_d).Text = "نفر";
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(257, 81);
		((Control)this.m_e).Name = "label5";
		((Control)this.m_e).Size = new Size(87, 28);
		((Control)this.m_e).TabIndex = 49;
		((Control)this.m_e).Text = "ظرفیت حوزه";
		((EditBase)this.m_f).AutoScroll = false;
		((EditBase)this.m_f).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_f).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_f).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_f).Location = new Point(188, 77);
		((EditBase)this.m_f).MaxLength = 3;
		((Control)this.m_f).Name = "txtCapacity";
		this.m_f.Numeric = true;
		((Control)this.m_f).Size = new Size(64, 36);
		((Control)this.m_f).TabIndex = 3;
		((EditBase)this.m_f).TextAlignment = (TextAlignment)1;
		((Control)this.m_g).Location = new Point(16, 28);
		((Control)this.m_g).Name = "txtName";
		((Control)this.m_g).Size = new Size(237, 36);
		((Control)this.m_g).TabIndex = 2;
		((Control)this.m_h).AutoSize = true;
		((Control)this.m_h).Location = new Point(258, 32);
		((Control)this.m_h).Name = "label2";
		((Control)this.m_h).Size = new Size(61, 28);
		((Control)this.m_h).TabIndex = 42;
		((Control)this.m_h).Text = "نام حوزه";
		i.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)i).Location = new Point(97, 129);
		((Control)i).Name = "btnCancel";
		((Control)i).Size = new Size(75, 38);
		((Control)i).TabIndex = 5;
		((Control)i).Text = "انصراف";
		((Control)i).Click += f;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)j).Location = new Point(178, 129);
		((Control)j).Name = "btnAcp";
		((Control)j).Size = new Size(75, 38);
		((Control)j).TabIndex = 4;
		((Control)j).Text = "تایید";
		((Control)j).Click += e;
		l.AllowEdit = (InheritableBoolean)2;
		((Control)l).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		l.DesignTimeLayout = val;
		l.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)l).Font = new Font("B Nazanin", 12f);
		l.GroupByBoxVisible = false;
		((Control)l).Location = new Point(16, 56);
		((Control)l).Name = "gridEX1";
		((ScrollableBase)l).RecordNavigator = true;
		((Control)l).RightToLeft = (RightToLeft)1;
		l.RowHeaders = (InheritableBoolean)1;
		((Control)l).Size = new Size(380, 325);
		((Control)l).TabIndex = 1;
		((ScrollableBase)l).VisualStyle = (VisualStyle)2;
		l.SelectionChanged += c;
		((Control)s).AutoSize = true;
		((Control)s).Font = new Font("Tahoma", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)s).Location = new Point(124, 15);
		((Control)s).Name = "label4";
		((Control)s).Size = new Size(168, 23);
		((Control)s).TabIndex = 86;
		((Control)s).Text = "تعریف حوزه امتحانی";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(424, 454);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmHozeh";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "تعریف حوزه امتحانی";
		((Form)this).Load += h;
		((Control)this.m_b).ResumeLayout(false);
		((Control)r).ResumeLayout(false);
		((Control)r).PerformLayout();
		((Control)p).ResumeLayout(false);
		((Control)k).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)l).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asda1()
	{
		d();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("14");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 0:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)r).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto IL_0129;
				case 7:
					return;
				case 4:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					if (1 == 0)
					{
					}
					goto IL_0129;
				case 6:
					{
						num = 0;
						continue;
					}
					IL_0129:
					c();
					num = 7;
					continue;
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
			int num = u;
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    id,Name, Capacity   FROM  tHozeh");
			l.DataSource = dataSource;
			int num2 = 0;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					num2 = ((!(t == "update")) ? 4 : 13);
					continue;
				case 11:
					num3 = 1;
					goto IL_00eb;
				case 3:
					num2 = ((t == "update") ? 2 : 11);
					continue;
				case 4:
					num4 = 1;
					goto IL_01aa;
				case 12:
					if (!flag)
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				case 13:
					num2 = 6;
					continue;
				case 6:
					num4 = ((l.RecordCount <= num) ? 1 : 0);
					goto IL_01aa;
				case 2:
					num2 = 9;
					continue;
				case 9:
					num3 = ((l.RecordCount != num) ? 1 : 0);
					goto IL_00eb;
				case 5:
					((Control)l).Focus();
					l.Row = num - 1;
					num2 = 8;
					continue;
				case 1:
					((Control)l).Focus();
					l.Row = num;
					num2 = 7;
					continue;
				case 10:
					num2 = ((!flag) ? 1 : 3);
					continue;
				case 7:
				case 8:
					{
						t = "insert";
						return;
					}
					IL_00eb:
					flag = (byte)num3 != 0;
					num2 = 12;
					continue;
					IL_01aa:
					flag = (byte)num4 != 0;
					if (true)
					{
					}
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		t = "insert";
		((Control)k).Visible = true;
		((Control)this.m_g).Text = "";
		((Control)this.m_g).Focus();
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Control)k).Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		string a_ = default;
		int num2 = default;
		while (true)
		{
			bool flag = !(asdaj.b(((Control)this.m_g).Text) == "");
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = !(asdaj.b(((Control)this.m_f).Text) == "");
					num = 1;
					continue;
				case 5:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 7:
				{
					SqlParameter[] array = new SqlParameter[5]
					{
						asdcb.a("@Code", SqlDbType.Int, null),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(((Control)this.m_g).Text)),
						asdcb.a("@Capacity", SqlDbType.Int, asdaj.b(((Control)this.m_f).Text)),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, t)
					};
					((DbParameter)(object)array[0]).Direction = ParameterDirection.InputOutput;
					num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tHozeh_InsertUpdate", array);
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "0");
					num = 2;
					continue;
				}
				case 2:
					if (flag)
					{
						flag = num2 <= 0;
						num = 5;
					}
					else
					{
						num = 14;
					}
					continue;
				case 14:
					if (true)
					{
					}
					MessageBox.Show("نام حوزه تکراری است");
					((TextBoxBase)this.m_g).SelectAll();
					num = 13;
					continue;
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					a_ = "0";
					flag = !(t == "update");
					num = 9;
					continue;
				case 17:
					((Control)k).Visible = false;
					num = 0;
					continue;
				case 10:
					MessageBox.Show("نام حوزه را وارد کنید");
					((Control)this.m_g).Focus();
					num = 15;
					continue;
				case 15:
					return;
				case 11:
					flag = !(t == "update");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 0;
				case 0:
					c();
					b();
					num = 4;
					continue;
				case 4:
					return;
				case 6:
					a_ = l.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 7;
					continue;
				case 3:
					MessageBox.Show("ظرفیت حوزه را وارد کنید");
					((Control)this.m_f).Focus();
					num = 16;
					continue;
				case 16:
					return;
				case 13:
					return;
				case 9:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 7;
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
		((Control)this.m_g).Text = "";
		((Control)this.m_g).Focus();
	}

	private void a()
	{
		if (true)
		{
		}
		((Control)this.m_g).Text = l.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
		((Control)this.m_f).Text = l.SelectedItems[0].GetRow().Cells["Capacity"].Value.ToString();
		((Control)this.m_g).Focus();
		((TextBoxBase)this.m_g).SelectAll();
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		t = "update";
		((Control)k).Visible = true;
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		u = l.Row;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			int num = 9;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 9:
					if (l.RowCount > 0)
					{
						num = 6;
						continue;
					}
					goto IL_0226;
				case 2:
					return;
				case 12:
					flag = (int)MessageBox.Show(" این حوزه داری شاگرد است. آیا اطمینان به حذف حوزه دارید؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
					num = 5;
					continue;
				case 5:
					num = ((!flag) ? 10 : 2);
					continue;
				case 13:
					num = 1;
					continue;
				case 1:
					num2 = (((int)MessageBox.Show("آيا از حذف حوزه مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6) ? 1 : 0);
					goto IL_01f9;
				case 11:
					num = 8;
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					if ((int)l.SelectedItems[0].RowType == 0)
					{
						num = 13;
						continue;
					}
					goto IL_0226;
				case 10:
					asdcb.d(asdab.e(), CommandType.Text, "update tstudent set idx=null,xhozeh=null where xhozeh=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					num = 11;
					continue;
				case 8:
					asdcb.d(asdab.e(), CommandType.Text, "delete from thozeh where id=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					c();
					num = 7;
					continue;
				case 7:
					return;
				case 0:
					if (!flag)
					{
						num = 15;
						continue;
					}
					return;
				case 15:
				{
					if (true)
					{
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tstudent where xHozeh=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 14;
					continue;
				}
				case 4:
					num2 = 1;
					goto IL_01f9;
				case 14:
					{
						if (!flag)
						{
							num = 12;
							continue;
						}
						goto case 8;
					}
					IL_0226:
					num = 4;
					continue;
					IL_01f9:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}
}
