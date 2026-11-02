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

public class asdq : Form
{
	private string m_a = "insert";

	private int m_b;

	private IContainer m_c = null;

	private Panel m_d;

	private Panel m_e;

	private Label m_f;

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

	private NumericEditBox t;

	public asdq()
	{
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		d();
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			int num = this.m_b;
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    *   FROM  tDisciplinaryCases where typ=3");
			l.DataSource = dataSource;
			int num2 = 6;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 6:
					num2 = ((!(this.m_a == "update")) ? 4 : 11);
					continue;
				case 9:
					num3 = 1;
					goto IL_00f6;
				case 7:
					num2 = ((this.m_a == "update") ? 2 : 9);
					continue;
				case 4:
					num4 = 1;
					goto IL_01b5;
				case 12:
					if (!flag)
					{
						num2 = 13;
						continue;
					}
					goto case 1;
				case 11:
					num2 = 10;
					continue;
				case 10:
					num4 = ((l.RecordCount <= num) ? 1 : 0);
					goto IL_01b5;
				case 2:
					num2 = 0;
					continue;
				case 0:
					num3 = ((l.RecordCount != num) ? 1 : 0);
					goto IL_00f6;
				case 13:
					((Control)l).Focus();
					l.Row = num - 1;
					num2 = 1;
					continue;
				case 8:
					((Control)l).Focus();
					l.Row = num;
					num2 = 3;
					continue;
				case 5:
					if (flag)
					{
						if (true)
						{
						}
						num2 = 7;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 1:
				case 3:
					{
						this.m_a = "insert";
						return;
					}
					IL_00f6:
					flag = (byte)num3 != 0;
					num2 = 12;
					continue;
					IL_01b5:
					flag = (byte)num4 != 0;
					num2 = 5;
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
		this.m_a = "insert";
		((Control)k).Visible = true;
		((Control)this.m_g).Text = "";
		((Control)this.m_g).Focus();
		((Control)this.m_g).Enabled = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		((Control)k).Visible = false;
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		string a_ = default;
		int num3 = default;
		float num2 = default;
		while (true)
		{
			bool flag = !(asdaj.b(((Control)this.m_g).Text) == "");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 17;
						continue;
					}
					flag = !(asdaj.b(((Control)t).Text) == "");
					num = 1;
					continue;
				case 8:
					MessageBox.Show("عنوان اخطار آموزشی تکراری است");
					((TextBoxBase)this.m_g).SelectAll();
					num = 3;
					continue;
				case 3:
					return;
				case 16:
					a_ = l.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					num = 4;
					continue;
				case 12:
					MessageBox.Show("میزان امتیاز منفی را وارد کنید");
					((Control)t).Focus();
					num = 10;
					continue;
				case 10:
					return;
				case 5:
					flag = !(this.m_a == "update");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 18;
						continue;
					}
					goto case 2;
				case 1:
					if (!flag)
					{
						num = 12;
						continue;
					}
					((Control)t).Text = ((Control)t).Text.Trim().Replace("-", "");
					num2 = 0f;
					num = 9;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 2:
					d();
					c();
					num = 13;
					continue;
				case 13:
					return;
				case 15:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 4;
				case 18:
					((Control)k).Visible = false;
					num = 2;
					continue;
				case 4:
				{
					if (true)
					{
					}
					SqlParameter[] array = new SqlParameter[6]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.BigInt, a_),
						asdcb.a("@name", SqlDbType.NVarChar, 100, asdaj.b(((Control)this.m_g).Text)),
						asdcb.a("@mark", SqlDbType.Float, num2),
						asdcb.a("@typ", SqlDbType.SmallInt, 3),
						asdcb.a("@commandType", SqlDbType.VarChar, 10, this.m_a)
					};
					num3 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tDisciplinaryCases_InsertUpdate", array);
					flag = !(((DbParameter)(object)array[0]).Value.ToString() == "0");
					num = 14;
					continue;
				}
				case 14:
					if (flag)
					{
						flag = num3 <= 0;
						num = 0;
					}
					else
					{
						num = 8;
					}
					continue;
				case 9:
					try
					{
						num2 = float.Parse(((Control)t).Text);
						num2 = 0f - num2;
					}
					catch
					{
						MessageBox.Show("برای امتیاز منفی فقط عدد وارد کنید");
						return;
					}
					a_ = "0";
					flag = !(this.m_a == "update");
					num = 15;
					continue;
				case 17:
					MessageBox.Show("عنوان اخطار آموزشی را وارد کنید");
					((Control)this.m_g).Focus();
					num = 7;
					continue;
				case 7:
					return;
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
		((Control)this.m_g).Text = "";
		((Control)this.m_g).Focus();
	}

	private void b()
	{
		bool flag = default;
		while (true)
		{
			((Control)this.m_g).Text = l.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 7;
						continue;
					}
					goto IL_00e5;
				case 1:
					((Control)this.m_g).Enabled = false;
					num = 5;
					continue;
				case 3:
					num2 = 0;
					goto IL_01c3;
				case 7:
					num = 4;
					continue;
				case 4:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 2;
						continue;
					}
					goto IL_00e5;
				case 0:
					if (1 == 0)
					{
					}
					goto case 5;
				case 2:
					num = 8;
					continue;
				case 8:
					num2 = ((!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_01c3;
				case 9:
					if (flag)
					{
						((Control)this.m_g).Enabled = true;
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 5:
					{
						((Control)t).Text = l.SelectedItems[0].GetRow().Cells["mark"].Value.ToString();
						((Control)this.m_g).Focus();
						((TextBoxBase)this.m_g).SelectAll();
						return;
					}
					IL_00e5:
					num = 3;
					continue;
					IL_01c3:
					flag = (byte)num2 != 0;
					num = 9;
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
		this.m_a = "update";
		((Control)k).Visible = true;
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_b = l.Row;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			int num = 9;
			while (true)
			{
				int num3;
				int num2;
				switch (num)
				{
				case 9:
					num = ((l.RowCount <= 0) ? 1 : 10);
					continue;
				case 10:
					num = 17;
					continue;
				case 17:
					num3 = (((int)l.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_021e;
				case 11:
					num2 = 0;
					goto IL_0268;
				case 5:
					num = 2;
					continue;
				case 2:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "2"))
					{
						num = 14;
						continue;
					}
					goto IL_00bf;
				case 13:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 16;
				case 14:
					num = 8;
					continue;
				case 8:
					num2 = ((!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "3")) ? 1 : 0);
					goto IL_0268;
				case 12:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tDisciplinaryCases where id=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					d();
					num = 16;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					return;
				case 1:
					num3 = 1;
					goto IL_021e;
				case 16:
					num = 3;
					continue;
				case 3:
					return;
				case 7:
				{
					if (!flag)
					{
						num = 21;
						continue;
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT count(id)   FROM  tDisciplinaryStudent where xDisciplinaryCases=" + l.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 15;
					continue;
				}
				case 4:
					num = 19;
					continue;
				case 19:
					if (!(l.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1"))
					{
						num = 5;
						continue;
					}
					goto IL_00bf;
				case 18:
					MessageBox.Show("از این اخطار آموزشی استفاده شده و قابل حذف نیست");
					num = 20;
					continue;
				case 20:
					return;
				case 21:
					MessageBox.Show("این اخطار آموزشی قابل حذف نیست");
					num = 0;
					continue;
				case 0:
					return;
				case 15:
					{
						if (flag)
						{
							flag = (int)MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
							if (true)
							{
							}
							num = 13;
						}
						else
						{
							num = 18;
						}
						continue;
					}
					IL_00bf:
					num = 11;
					continue;
					IL_0268:
					flag = (byte)num2 != 0;
					num = 7;
					continue;
					IL_021e:
					flag = (byte)num3 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
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
					num = ((!A_0) ? 1 : 6);
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_c == null) ? 1 : 0);
					goto IL_0074;
				case 0:
					this.m_c.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
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
					if (true)
					{
					}
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void a()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdq));
		GridEXLayout val = new GridEXLayout();
		this.m_d = new Panel();
		r = new Panel();
		s = new Label();
		p = new Panel();
		o = new UIButton();
		n = new UIButton();
		m = new UIButton();
		q = new UIButton();
		k = new Panel();
		this.m_e = new Panel();
		t = new NumericEditBox();
		this.m_f = new Label();
		this.m_g = new TextBox();
		this.m_h = new Label();
		i = new UIButton();
		j = new UIButton();
		l = new GridEX();
		((Control)this.m_d).SuspendLayout();
		((Control)r).SuspendLayout();
		((Control)p).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this.m_e).SuspendLayout();
		((ISupportInitialize)l).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_d).BackColor = SystemColors.ControlText;
		((Control)this.m_d).Controls.Add((Control)(object)r);
		((Control)this.m_d).Dock = (DockStyle)5;
		((Control)this.m_d).Location = new Point(0, 0);
		((Control)this.m_d).Name = "panel2";
		((Control)this.m_d).Size = new Size(550, 600);
		((Control)this.m_d).TabIndex = 31;
		((Control)r).BackColor = Color.FromArgb(214, 223, 247);
		r.BorderStyle = (BorderStyle)1;
		((Control)r).Controls.Add((Control)(object)s);
		((Control)r).Controls.Add((Control)(object)p);
		((Control)r).Controls.Add((Control)(object)q);
		((Control)r).Controls.Add((Control)(object)k);
		((Control)r).Controls.Add((Control)(object)l);
		((Control)r).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(5, 5);
		((Control)r).Name = "panel3";
		((Control)r).Size = new Size(540, 590);
		((Control)r).TabIndex = 0;
		((Control)s).AutoSize = true;
		((Control)s).Font = new Font("B Nazanin", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)s).Location = new Point(149, 3);
		((Control)s).Name = "label4";
		((Control)s).Size = new Size(236, 40);
		((Control)s).TabIndex = 86;
		((Control)s).Text = "تعریف اخطار های آموزشی";
		((Control)p).Anchor = (AnchorStyles)10;
		((Control)p).Controls.Add((Control)(object)o);
		((Control)p).Controls.Add((Control)(object)n);
		((Control)p).Controls.Add((Control)(object)m);
		((Control)p).Location = new Point(268, 535);
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
		((Control)q).Location = new Point(16, 538);
		((Control)q).Name = "btnClose";
		((Control)q).Size = new Size(110, 40);
		((Control)q).TabIndex = 30;
		((Control)q).Text = "بستن";
		((Control)q).Click += b;
		((Control)k).BackColor = Color.Gray;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Controls.Add((Control)(object)this.m_e);
		((Control)k).Font = new Font("B Nazanin", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(18, 160);
		((Control)k).Name = "pStd";
		((Control)k).Size = new Size(514, 207);
		((Control)k).TabIndex = 0;
		((Control)k).Visible = false;
		((Control)this.m_e).BackColor = Color.FromArgb(214, 223, 247);
		this.m_e.BorderStyle = (BorderStyle)2;
		((Control)this.m_e).Controls.Add((Control)(object)t);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_e).Controls.Add((Control)(object)i);
		((Control)this.m_e).Controls.Add((Control)(object)j);
		((Control)this.m_e).Location = new Point(6, 7);
		((Control)this.m_e).Name = "panel1";
		((Control)this.m_e).Size = new Size(498, 189);
		((Control)this.m_e).TabIndex = 40;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((Control)t).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(312, 70);
		((Control)t).Name = "txtMark";
		((Control)t).Size = new Size(62, 31);
		((Control)t).TabIndex = 3;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		t.Value = new decimal(new int[4] { 0, 0, 0, 131072 });
		((Control)this.m_f).AutoSize = true;
		((Control)this.m_f).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(380, 73);
		((Control)this.m_f).Name = "label5";
		((Control)this.m_f).Size = new Size(96, 24);
		((Control)this.m_f).TabIndex = 49;
		((Control)this.m_f).Text = "میزان امتیاز منفی";
		((Control)this.m_g).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_g).Location = new Point(16, 28);
		((Control)this.m_g).Name = "txtName";
		((Control)this.m_g).Size = new Size(358, 31);
		((Control)this.m_g).TabIndex = 2;
		((Control)this.m_h).AutoSize = true;
		((Control)this.m_h).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(380, 31);
		((Control)this.m_h).Name = "label2";
		((Control)this.m_h).Size = new Size(111, 24);
		((Control)this.m_h).TabIndex = 42;
		((Control)this.m_h).Text = "عنوان اخطار آموزشی";
		i.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)i).Location = new Point(97, 129);
		((Control)i).Name = "btnCancel";
		((Control)i).Size = new Size(75, 38);
		((Control)i).TabIndex = 5;
		((Control)i).Text = "انصراف";
		((Control)i).Click += f;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)j).Location = new Point(191, 129);
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
		((Control)l).Location = new Point(6, 56);
		((Control)l).Name = "gridEX1";
		((ScrollableBase)l).RecordNavigator = true;
		((Control)l).RightToLeft = (RightToLeft)1;
		l.RowHeaders = (InheritableBoolean)1;
		((Control)l).Size = new Size(516, 471);
		((Control)l).TabIndex = 1;
		((ScrollableBase)l).VisualStyle = (VisualStyle)2;
		l.SelectionChanged += c;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(550, 600);
		((Control)this).Controls.Add((Control)(object)this.m_d);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmDisciplinaryCases3";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "تعریف اخطارهای آموزشی";
		((Form)this).Load += h;
		((Control)this.m_d).ResumeLayout(false);
		((Control)r).ResumeLayout(false);
		((Control)r).PerformLayout();
		((Control)p).ResumeLayout(false);
		((Control)k).ResumeLayout(false);
		((Control)this.m_e).ResumeLayout(false);
		((Control)this.m_e).PerformLayout();
		((ISupportInitialize)l).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
