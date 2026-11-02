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

public class asdbm : Form
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
						num = 2;
					}
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 5;
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
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected Obj, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected Obj, but got Unknown
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected Obj, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected Obj, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected Obj, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected Obj, but got Unknown
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbm));
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
		((Control)p).BackColor = Color.FromArgb(214, 223, 247);
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
		((Control)q).Size = new Size(192, 40);
		((Control)q).TabIndex = 86;
		((Control)q).Text = "تعریف موارد انضباطی";
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
		((Control)this.m_d).Size = new Size(96, 24);
		((Control)this.m_d).TabIndex = 49;
		((Control)this.m_d).Text = "میزان امتیاز منفی";
		((Control)this.m_e).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(16, 28);
		((Control)this.m_e).Name = "txtName";
		((Control)this.m_e).Size = new Size(358, 31);
		((Control)this.m_e).TabIndex = 2;
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(380, 31);
		((Control)this.m_f).Name = "label2";
		((Control)this.m_f).Size = new Size(110, 24);
		((Control)this.m_f).TabIndex = 42;
		((Control)this.m_f).Text = "عنوان مورد انضباطی";
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
		((Control)this).Name = "frmDisciplinaryCases";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "تعریف موارد انضباطی";
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

	public asdbm()
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
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    *   FROM  tDisciplinaryCases where typ=1");
			j.DataSource = dataSource;
			int num2 = 13;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 13:
					num2 = ((!(s == "update")) ? 9 : 8);
					continue;
				case 6:
					num3 = 1;
					goto IL_00eb;
				case 5:
					num2 = ((s == "update") ? 1 : 6);
					continue;
				case 9:
					num4 = 1;
					goto IL_01b5;
				case 0:
					if (!flag)
					{
						num2 = 12;
						continue;
					}
					goto case 4;
				case 8:
					num2 = 7;
					continue;
				case 7:
					num4 = ((j.RecordCount <= num) ? 1 : 0);
					goto IL_01b5;
				case 1:
					num2 = 10;
					continue;
				case 10:
					num3 = ((j.RecordCount != num) ? 1 : 0);
					goto IL_00eb;
				case 12:
					((Control)j).Focus();
					j.Row = num - 1;
					num2 = 4;
					continue;
				case 11:
					((Control)j).Focus();
					j.Row = num;
					num2 = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					goto case 4;
				case 3:
					num2 = ((!flag) ? 11 : 5);
					continue;
				case 4:
					{
						s = "insert";
						return;
					}
					IL_00eb:
					flag = (byte)num3 != 0;
					num2 = 0;
					continue;
					IL_01b5:
					flag = (byte)num4 != 0;
					num2 = 3;
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
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		string a_ = default;
		int num3 = default;
		float num2 = default;
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
						num = 14;
						continue;
					}
					flag = !(asdaj.b(((Control)r).Text) == "");
					num = 11;
					continue;
				case 9:
					MessageBox.Show("عنوان مورد انضباطی تکراری است");
					((TextBoxBase)this.m_e).SelectAll();
					num = 5;
					continue;
				case 5:
					return;
				case 0:
					MessageBox.Show("میزان امتیاز منفی را وارد کنید");
					((Control)r).Focus();
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					flag = !(s == "update");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 4;
				case 11:
					if (!flag)
					{
						num = 0;
						continue;
					}
					((Control)r).Text = ((Control)r).Text.Trim().Replace("-", "");
					num2 = 0f;
					num = 13;
					continue;
				case 8:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 4:
					c();
					b();
					num = 12;
					continue;
				case 12:
					return;
				case 6:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 10;
				case 15:
					if (true)
					{
					}
					a_ = j.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 10;
					continue;
				case 18:
					((Control)i).Visible = false;
					num = 4;
					continue;
				case 10:
				{
					SqlParameter[] array = new SqlParameter[6]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(((Control)this.m_e).Text)),
						asdcb.a("@mark", SqlDbType.Float, num2),
						asdcb.a("@typ", SqlDbType.SmallInt, 1),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, s)
					};
					num3 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryCases_InsertUpdate", array);
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "0");
					num = 3;
					continue;
				}
				case 3:
					if (flag)
					{
						flag = num3 <= 0;
						num = 8;
					}
					else
					{
						num = 9;
					}
					continue;
				case 13:
					try
					{
						num2 = float.Parse(((Control)r).Text);
						num2 = 0f - num2;
					}
					catch
					{
						MessageBox.Show("برای امتیاز منفی فقط عدد وارد کنید");
						return;
					}
					a_ = "0";
					flag = !(s == "update");
					num = 6;
					continue;
				case 14:
					MessageBox.Show("عنوان مورد انضباطی را وارد کنید");
					((Control)this.m_e).Focus();
					num = 16;
					continue;
				case 16:
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
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 9;
						continue;
					}
					goto IL_00ed;
				case 6:
					if (true)
					{
					}
					((Control)this.m_e).Enabled = false;
					num = 1;
					continue;
				case 2:
					num2 = 0;
					goto IL_01c3;
				case 9:
					num = 8;
					continue;
				case 8:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 3;
						continue;
					}
					goto IL_00ed;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_01c3;
				case 0:
					if (flag)
					{
						((Control)this.m_e).Enabled = true;
						num = 7;
					}
					else
					{
						num = 6;
					}
					continue;
				case 1:
				case 7:
					{
						((Control)r).Text = j.SelectedItems[0].GetRow().Cells["mark"].Value.ToString();
						((Control)this.m_e).Focus();
						((TextBoxBase)this.m_e).SelectAll();
						return;
					}
					IL_00ed:
					num = 2;
					continue;
					IL_01c3:
					flag = (byte)num2 != 0;
					num = 0;
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
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			int num = 10;
			while (true)
			{
				int num3;
				int num2;
				switch (num)
				{
				case 10:
					num = ((j.RowCount <= 0) ? 12 : 11);
					continue;
				case 11:
					num = 0;
					continue;
				case 0:
					num3 = (((int)j.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_021e;
				case 3:
					num2 = 0;
					goto IL_0268;
				case 20:
					num = 14;
					continue;
				case 14:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 4;
						continue;
					}
					goto IL_00bf;
				case 4:
					if (true)
					{
					}
					num = 16;
					continue;
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 18;
				case 16:
					num2 = ((!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_0268;
				case 7:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryCases where id=" + j.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					c();
					num = 18;
					continue;
				case 15:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 12:
					num3 = 1;
					goto IL_021e;
				case 18:
					num = 5;
					continue;
				case 5:
					return;
				case 2:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tDisciplinaryStudent where xDisciplinaryCases=" + j.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 8;
					continue;
				}
				case 9:
					num = 17;
					continue;
				case 17:
					if (!(j.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 20;
						continue;
					}
					goto IL_00bf;
				case 21:
					MessageBox.Show("از این مورد انضباطی استفاده شده و قابل حذف نیست");
					num = 19;
					continue;
				case 19:
					return;
				case 13:
					MessageBox.Show("این مورد انضباطی قابل حذف نیست");
					num = 6;
					continue;
				case 6:
					return;
				case 8:
					{
						if (flag)
						{
							flag = (int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
							num = 1;
						}
						else
						{
							num = 21;
						}
						continue;
					}
					IL_00bf:
					num = 3;
					continue;
					IL_0268:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
					IL_021e:
					flag = (byte)num3 != 0;
					num = 15;
					continue;
				}
				break;
			}
		}
	}
}
