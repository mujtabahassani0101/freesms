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

public class asdad : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Label m_d;

	private TextBox m_e;

	private Label m_f;

	private UIButton m_g;

	private UIButton m_h;

	private Panel i;

	private GridEX j;

	private UIButton k;

	private UIButton l;

	private UIButton m;

	private Panel n;

	private UIButton o;

	private Panel p;

	private Label q;

	private NumericEditBox r;

	private string s = "insert";

	private int t;

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
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 6;
					continue;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 6;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 6:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
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
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected Obj, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected Obj, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected Obj, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected Obj, but got Unknown
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdad));
		GridEXLayout val = new GridEXLayout();
		this.m_b = new Panel();
		p = new Panel();
		q = new Label();
		n = new Panel();
		m = new UIButton();
		l = new UIButton();
		k = new UIButton();
		o = new UIButton();
		i = new Panel();
		this.m_c = new Panel();
		r = new NumericEditBox();
		this.m_d = new Label();
		this.m_e = new TextBox();
		this.m_f = new Label();
		this.m_g = new UIButton();
		this.m_h = new UIButton();
		j = new GridEX();
		((Control)this.m_b).SuspendLayout();
		((Control)p).SuspendLayout();
		((Control)n).SuspendLayout();
		((Control)i).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.ControlText;
		((Control)this.m_b).Controls.Add((Control)(object)p);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(550, 600);
		((Control)this.m_b).TabIndex = 31;
		((Control)p).BackColor = SystemColors.GradientInactiveCaption;
		p.BorderStyle = (BorderStyle)1;
		((Control)p).Controls.Add((Control)(object)q);
		((Control)p).Controls.Add((Control)(object)n);
		((Control)p).Controls.Add((Control)(object)o);
		((Control)p).Controls.Add((Control)(object)i);
		((Control)p).Controls.Add((Control)(object)j);
		((Control)p).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(5, 5);
		((Control)p).Name = "panel3";
		((Control)p).Size = new Size(540, 590);
		((Control)p).TabIndex = 0;
		((Control)q).AutoSize = true;
		((Control)q).Font = new Font("B Nazanin", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(181, 5);
		((Control)q).Name = "label4";
		((Control)q).Size = new Size(186, 40);
		((Control)q).TabIndex = 86;
		((Control)q).Text = "تعریف عملکرد مثبت";
		((Control)n).Anchor = (AnchorStyles)10;
		((Control)n).Controls.Add((Control)(object)m);
		((Control)n).Controls.Add((Control)(object)l);
		((Control)n).Controls.Add((Control)(object)k);
		((Control)n).Location = new Point(268, 535);
		((Control)n).Name = "p_new";
		((Control)n).Size = new Size(258, 43);
		((Control)n).TabIndex = 29;
		m.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)m).Location = new Point(3, 6);
		((Control)m).Name = "btnDelete";
		((Control)m).Size = new Size(78, 34);
		((Control)m).TabIndex = 2;
		((Control)m).Text = "حذف";
		((Control)m).Click += a;
		l.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)l).Location = new Point(170, 6);
		((Control)l).Name = "btnNew";
		((Control)l).Size = new Size(85, 34);
		((Control)l).TabIndex = 0;
		((Control)l).Text = "جدید";
		((Control)l).Click += g;
		k.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)k).Location = new Point(87, 6);
		((Control)k).Name = "btnEdit";
		((Control)k).Size = new Size(77, 34);
		((Control)k).TabIndex = 1;
		((Control)k).Text = "اصلاح";
		((Control)k).Click += d;
		((Control)o).Anchor = (AnchorStyles)6;
		o.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		o.ImageSize = new Size(40, 40);
		((Control)o).Location = new Point(16, 538);
		((Control)o).Name = "btnClose";
		((Control)o).Size = new Size(110, 40);
		((Control)o).TabIndex = 30;
		((Control)o).Text = "بستن";
		((Control)o).Click += b;
		((Control)i).BackColor = Color.Gray;
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Controls.Add((Control)(object)this.m_c);
		((Control)i).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(18, 160);
		((Control)i).Name = "pStd";
		((Control)i).Size = new Size(514, 207);
		((Control)i).TabIndex = 0;
		((Control)i).Visible = false;
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)2;
		((Control)this.m_c).Controls.Add((Control)(object)r);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_c).Location = new Point(6, 7);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(498, 189);
		((Control)this.m_c).TabIndex = 40;
		((EditBase)r).AutoScroll = false;
		((EditBase)r).AutoScrollMargin = new Size(0, 0);
		((EditBase)r).AutoScrollMinSize = new Size(0, 0);
		((EditBase)r).AutoScrollPosition = new Point(0, 0);
		((Control)r).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(312, 70);
		((Control)r).Name = "txtMark";
		((Control)r).Size = new Size(62, 31);
		((Control)r).TabIndex = 3;
		((EditBase)r).TextAlignment = (TextAlignment)1;
		r.Value = new decimal(new int[4] { 0, 0, 0, 131072 });
		((Control)this.m_d).AutoSize = true;
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(380, 73);
		((Control)this.m_d).Name = "label5";
		((Control)this.m_d).Size = new Size(98, 24);
		((Control)this.m_d).TabIndex = 49;
		((Control)this.m_d).Text = "میزان امتیاز مثبت";
		((Control)this.m_e).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(16, 28);
		((Control)this.m_e).Name = "txtName";
		((Control)this.m_e).Size = new Size(358, 31);
		((Control)this.m_e).TabIndex = 2;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(380, 31);
		((Control)this.m_f).Name = "label2";
		((Control)this.m_f).Size = new Size(78, 24);
		((Control)this.m_f).TabIndex = 42;
		((Control)this.m_f).Text = "عنوان عملکرد";
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)this.m_g).Location = new Point(97, 129);
		((Control)this.m_g).Name = "btnCancel";
		((Control)this.m_g).Size = new Size(75, 38);
		((Control)this.m_g).TabIndex = 5;
		((Control)this.m_g).Text = "انصراف";
		((Control)this.m_g).Click += f;
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)this.m_h).Location = new Point(191, 129);
		((Control)this.m_h).Name = "btnAcp";
		((Control)this.m_h).Size = new Size(75, 38);
		((Control)this.m_h).TabIndex = 4;
		((Control)this.m_h).Text = "تایید";
		((Control)this.m_h).Click += e;
		j.AllowEdit = (InheritableBoolean)2;
		((Control)j).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		j.DesignTimeLayout = val;
		j.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)j).Font = new Font("B Nazanin", 12f);
		j.GroupByBoxVisible = false;
		((Control)j).Location = new Point(6, 56);
		((Control)j).Name = "gridEX1";
		((ScrollableBase)j).RecordNavigator = true;
		((Control)j).RightToLeft = (RightToLeft)1;
		j.RowHeaders = (InheritableBoolean)1;
		((Control)j).Size = new Size(516, 471);
		((Control)j).TabIndex = 1;
		((ScrollableBase)j).VisualStyle = (VisualStyle)2;
		j.SelectionChanged += c;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(550, 600);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmDisciplinaryCases2";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "تعریف حوزه امتحانی";
		((Form)this).Load += h;
		((Control)this.m_b).ResumeLayout(false);
		((Control)p).ResumeLayout(false);
		((Control)p).PerformLayout();
		((Control)n).ResumeLayout(false);
		((Control)i).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)j).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asdad()
	{
		d();
	}

	private void h(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c()
	{
		bool flag = default;
		while (true)
		{
			int num = t;
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    *   FROM  tDisciplinaryCases where typ=2");
			j.DataSource = dataSource;
			int num2 = 11;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 11:
					num2 = ((!(s == "update")) ? 3 : 5);
					continue;
				case 0:
					num3 = 1;
					goto IL_00eb;
				case 10:
					num2 = ((s == "update") ? 6 : 0);
					continue;
				case 3:
					num4 = 1;
					goto IL_01b5;
				case 13:
					if (!flag)
					{
						num2 = 12;
						continue;
					}
					goto case 7;
				case 5:
					num2 = 9;
					continue;
				case 9:
					num4 = ((j.RecordCount <= num) ? 1 : 0);
					goto IL_01b5;
				case 6:
					num2 = 1;
					continue;
				case 1:
					num3 = ((j.RecordCount != num) ? 1 : 0);
					goto IL_00eb;
				case 12:
					((Control)j).Focus();
					j.Row = num - 1;
					num2 = 7;
					continue;
				case 2:
					((Control)j).Focus();
					j.Row = num;
					num2 = 8;
					continue;
				case 8:
					if (1 == 0)
					{
					}
					goto case 7;
				case 4:
					num2 = ((!flag) ? 2 : 10);
					continue;
				case 7:
					{
						s = "insert";
						return;
					}
					IL_00eb:
					flag = (byte)num3 != 0;
					num2 = 13;
					continue;
					IL_01b5:
					flag = (byte)num4 != 0;
					num2 = 4;
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
		s = "insert";
		((Control)i).Visible = true;
		((Control)this.m_e).Text = "";
		((Control)this.m_e).Focus();
		((Control)this.m_e).Enabled = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Control)i).Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		float num2 = default;
		string a_ = default;
		int num3 = default;
		while (true)
		{
			bool flag = !(asdaj.b(((Control)this.m_e).Text) == "");
			int num = 17;
			while (true)
			{
				switch (num)
				{
				case 17:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(asdaj.b(((Control)r).Text) == "");
					num = 8;
					continue;
				case 4:
					MessageBox.Show("عنوان عملکرد تکراری است");
					((TextBoxBase)this.m_e).SelectAll();
					num = 12;
					continue;
				case 12:
					return;
				case 3:
					MessageBox.Show("میزان امتیاز را وارد کنید");
					((Control)r).Focus();
					num = 0;
					continue;
				case 0:
					return;
				case 9:
					flag = !(s == "update");
					num = 15;
					continue;
				case 15:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 7;
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					((Control)r).Text = ((Control)r).Text.Trim().Replace("-", "");
					num2 = 0f;
					num = 11;
					continue;
				case 16:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 7:
					c();
					b();
					num = 18;
					continue;
				case 18:
					return;
				case 10:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 1:
					if (true)
					{
					}
					a_ = j.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 2;
					continue;
				case 13:
					((Control)i).Visible = false;
					num = 7;
					continue;
				case 2:
				{
					SqlParameter[] array = new SqlParameter[6]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(((Control)this.m_e).Text)),
						asdcb.a("@mark", SqlDbType.Float, num2),
						asdcb.a("@typ", SqlDbType.SmallInt, 2),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, s)
					};
					num3 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryCases_InsertUpdate", array);
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "0");
					num = 6;
					continue;
				}
				case 6:
					if (flag)
					{
						flag = num3 <= 0;
						num = 16;
					}
					else
					{
						num = 4;
					}
					continue;
				case 11:
					try
					{
						num2 = float.Parse(((Control)r).Text);
					}
					catch
					{
						MessageBox.Show("برای امتیاز فقط عدد وارد کنید");
						return;
					}
					a_ = "0";
					flag = !(s == "update");
					num = 10;
					continue;
				case 5:
					MessageBox.Show("عنوان عملکرد را وارد کنید");
					((Control)this.m_e).Focus();
					num = 14;
					continue;
				case 14:
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
		((Control)this.m_e).Text = "";
		((Control)this.m_e).Focus();
	}

	private void a()
	{
		bool flag = default;
		while (true)
		{
			((Control)this.m_e).Text = j.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1") ? 7 : 3);
					continue;
				case 3:
					if (true)
					{
					}
					num = 5;
					continue;
				case 1:
					((Control)this.m_e).Enabled = false;
					num = 0;
					continue;
				case 7:
					num2 = 0;
					goto IL_0162;
				case 5:
					num2 = ((!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2")) ? 1 : 0);
					goto IL_0162;
				case 4:
					if (flag)
					{
						((Control)this.m_e).Enabled = true;
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				case 0:
				case 6:
					{
						((Control)r).Text = j.SelectedItems[0].GetRow().Cells["mark"].Value.ToString();
						((Control)this.m_e).Focus();
						((TextBoxBase)this.m_e).SelectAll();
						return;
					}
					IL_0162:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		s = "update";
		((Control)i).Visible = true;
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		t = j.Row;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 5:
					num = ((j.RowCount <= 0) ? 2 : 6);
					continue;
				case 0:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 18;
				case 6:
					num = 3;
					continue;
				case 3:
					if (true)
					{
					}
					num2 = (((int)j.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_00fc;
				case 19:
					if (!flag)
					{
						num = 14;
						continue;
					}
					return;
				case 1:
					MessageBox.Show("این عملکرد قابل حذف نیست");
					num = 17;
					continue;
				case 17:
					return;
				case 14:
					num = 10;
					continue;
				case 10:
					num = ((j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1") ? 16 : 9);
					continue;
				case 8:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryCases where id=" + j.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					c();
					num = 18;
					continue;
				case 4:
					MessageBox.Show("از این عملکرد استفاده شده و قابل حذف نیست");
					num = 7;
					continue;
				case 7:
					return;
				case 15:
					if (flag)
					{
						flag = (int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 0;
					}
					else
					{
						num = 4;
					}
					continue;
				case 18:
					num = 12;
					continue;
				case 12:
					return;
				case 2:
					num2 = 1;
					goto IL_00fc;
				case 16:
					num3 = 0;
					goto IL_0325;
				case 9:
					num = 13;
					continue;
				case 13:
					num3 = ((!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2")) ? 1 : 0);
					goto IL_0325;
				case 11:
					{
						if (flag)
						{
							string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tDisciplinaryStudent where xDisciplinaryCases=" + j.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
							flag = !(text != "0");
							num = 15;
						}
						else
						{
							num = 1;
						}
						continue;
					}
					IL_0325:
					flag = (byte)num3 != 0;
					num = 11;
					continue;
					IL_00fc:
					flag = (byte)num2 != 0;
					num = 19;
					continue;
				}
				break;
			}
		}
	}
}
