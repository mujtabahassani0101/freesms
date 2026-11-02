using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbq : Form
{
	private string m_a;

	private IContainer m_b = null;

	private GridEX m_c;

	private Panel m_d;

	private Panel m_e;

	private UIButton m_f;

	private UIButton m_g;

	private UIButton h;

	private Panel i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private UIButton m;

	private Label n;

	private Label o;

	private Label p;

	private Panel q;

	private NumericEditBox r;

	private Label s;

	private EditBox t;

	private Label u;

	private Label v;

	private MaskedEditBox w;

	private MaskedEditBox x;

	public asdbq()
	{
		a();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 1:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 7;
				case 7:
					((Control)v).Text = asdaj.a;
					b();
					num = 6;
					continue;
				case 6:
					return;
				case 3:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 5;
					continue;
				case 5:
					return;
				case 2:
					num = 1;
					continue;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tExam where term=0 and xYear=" + ((Control)v).Text);
		this.m_c.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		((Control)r).Text = asdcb.a(asdab.e(), CommandType.Text, "select case when isnull(max (NumExam),0)+1 <0 then 1 else isnull(max (NumExam),0)+1 end as n  from tExam where xYear=" + ((Control)v).Text).ToString();
		this.m_a = "insert";
		((Control)i).Visible = true;
		((Control)t).Focus();
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_c.RowCount <= 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 1:
					try
					{
						((Control)w).Text = this.m_c.SelectedItems[0].GetRow().Cells["DateTo"].Value.ToString();
					}
					catch
					{
					}
					if (true)
					{
					}
					((Control)t).Select();
					num = 0;
					continue;
				case 2:
					try
					{
						((Control)x).Text = this.m_c.SelectedItems[0].GetRow().Cells["DateFrom"].Value.ToString();
					}
					catch
					{
					}
					num = 1;
					continue;
				case 0:
					return;
				case 3:
					this.m_a = "update";
					((Control)i).Visible = true;
					((Control)r).Text = this.m_c.SelectedItems[0].GetRow().Cells["NumExam"].Value.ToString();
					((Control)t).Text = this.m_c.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string text = "0";
			bool flag = !(this.m_a == "update");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						flag = !(this.m_a == "insert");
						num = 0;
					}
					continue;
				case 1:
					text = asdcb.a(asdab.e(), CommandType.Text, " select isNull(MAX(ID),100)+1  from tExam").ToString();
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tExam (id,name,NumExam,DateFrom,DateTo,xYear,term) values(" + text + ",N'" + ((Control)t).Text.Trim() + "'," + ((Control)r).Text + ",N'" + ((Control)x).Text + "',N'" + ((Control)w).Text + "'," + ((Control)v).Text + ",0)");
					((Control)i).Visible = false;
					b();
					MessageBox.Show("ثبت شد");
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 2:
					text = this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, " update tExam set NumExam=" + ((Control)r).Text + ",name=N'" + ((Control)t).Text.Trim() + "',DateFrom=N'" + ((Control)x).Text + "',DateTo=N'" + ((Control)w).Text + "',xExportRpt=null where id=" + text);
					b();
					((Control)i).Visible = false;
					MessageBox.Show("اصلاح شد");
					num = 4;
					continue;
				case 4:
					return;
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
		((Control)i).Visible = false;
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Invalid comparison between Unknown and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((this.m_c.RowCount <= 0) ? 10 : 5);
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 3;
				case 14:
					if (flag)
					{
						flag = (int)MessageBox.Show("آيا از حذف دوره مطمئن هستيد؟", "حذف دوره", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 7;
					}
					else
					{
						num = 13;
					}
					continue;
				case 10:
					num2 = 1;
					goto IL_029d;
				case 1:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tExam where id=" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					b();
					num = 3;
					continue;
				case 5:
					num = 15;
					continue;
				case 15:
					num2 = (((int)this.m_c.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_029d;
				case 13:
					MessageBox.Show("تعداد " + text + "توضیحات زیر اطلاع نامه در این دوره وجود دارد.امکان حذف وجود ندارد");
					num = 8;
					continue;
				case 8:
					return;
				case 3:
					num = 6;
					continue;
				case 6:
					return;
				case 9:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tMark WHERE Xtest =" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						if (true)
						{
						}
						text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tComnentKarname WHERE Xtest =" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
						flag = !(text != "0");
						num = 14;
					}
					else
					{
						num = 0;
					}
					continue;
				case 11:
					if (!flag)
					{
						num = 9;
						continue;
					}
					return;
				case 0:
					MessageBox.Show("تعداد " + text + "نمره در این دوره وجود دارد.امکان حذف وجود ندارد");
					num = 4;
					continue;
				case 4:
					return;
					IL_029d:
					flag = (byte)num2 != 0;
					num = 11;
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
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((!A_0) ? 6 : 3);
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 1:
					this.m_b.Dispose();
					num = 4;
					continue;
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 6:
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
					num = 2;
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
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected Obj, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected Obj, but got Unknown
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected Obj, but got Unknown
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7c: Expected Obj, but got Unknown
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected Obj, but got Unknown
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbq));
		this.m_c = new GridEX();
		this.m_d = new Panel();
		v = new Label();
		u = new Label();
		p = new Label();
		i = new Panel();
		w = new MaskedEditBox();
		x = new MaskedEditBox();
		t = new EditBox();
		s = new Label();
		r = new NumericEditBox();
		n = new Label();
		o = new Label();
		m = new UIButton();
		k = new UIButton();
		l = new Label();
		this.m_e = new Panel();
		this.m_f = new UIButton();
		j = new UIButton();
		this.m_g = new UIButton();
		h = new UIButton();
		q = new Panel();
		((ISupportInitialize)this.m_c).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((Control)i).SuspendLayout();
		((Control)this.m_e).SuspendLayout();
		((Control)q).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_c).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = val;
		this.m_c.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_c.GroupByBoxVisible = false;
		((Control)this.m_c).Location = new Point(8, 46);
		((Control)this.m_c).Name = "gridEX1";
		this.m_c.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_c).Size = new Size(428, 303);
		((Control)this.m_c).TabIndex = 5;
		((ScrollableBase)this.m_c).VisualStyle = (VisualStyle)2;
		((Control)this.m_d).BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.BorderStyle = (BorderStyle)1;
		((Control)this.m_d).Controls.Add((Control)(object)v);
		((Control)this.m_d).Controls.Add((Control)(object)u);
		((Control)this.m_d).Controls.Add((Control)(object)p);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_d).Location = new Point(4, 6);
		((Control)this.m_d).Name = "panel1";
		((Control)this.m_d).Size = new Size(446, 395);
		((Control)this.m_d).TabIndex = 0;
		v.BorderStyle = (BorderStyle)1;
		((Control)v).Location = new Point(65, 9);
		((Control)v).Name = "lYear";
		((Control)v).Size = new Size(68, 24);
		((Control)v).TabIndex = 119;
		((Control)u).AutoSize = true;
		((Control)u).Location = new Point(139, 9);
		((Control)u).Name = "label6";
		((Control)u).Size = new Size(70, 24);
		((Control)u).TabIndex = 114;
		((Control)u).Text = "سال تعلیمی";
		((Control)p).AutoSize = true;
		((Control)p).Font = new Font("B Nazanin", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)p).ForeColor = Color.DarkViolet;
		((Control)p).Location = new Point(307, 3);
		((Control)p).Name = "label4";
		((Control)p).Size = new Size(132, 40);
		((Control)p).TabIndex = 16;
		((Control)p).Text = "لیست دوره ها";
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Controls.Add((Control)(object)w);
		((Control)i).Controls.Add((Control)(object)x);
		((Control)i).Controls.Add((Control)(object)t);
		((Control)i).Controls.Add((Control)(object)s);
		((Control)i).Controls.Add((Control)(object)r);
		((Control)i).Controls.Add((Control)(object)n);
		((Control)i).Controls.Add((Control)(object)o);
		((Control)i).Controls.Add((Control)(object)m);
		((Control)i).Controls.Add((Control)(object)k);
		((Control)i).Controls.Add((Control)(object)l);
		((Control)i).Location = new Point(48, 104);
		((Control)i).Name = "pcls";
		((Control)i).Size = new Size(269, 216);
		((Control)i).TabIndex = 10;
		((Control)i).Visible = false;
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((EditBase)w).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)w).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)w).Location = new Point(90, 137);
		w.Mask = "0000/00/00";
		((EditBase)w).MaxLength = 12;
		((Control)w).Name = "txtDatato";
		w.Numeric = true;
		((Control)w).RightToLeft = (RightToLeft)0;
		((Control)w).Size = new Size(100, 26);
		((Control)w).TabIndex = 23;
		((Control)w).Tag = "";
		((EditBase)w).TextAlignment = (TextAlignment)3;
		((EditBase)x).AutoScroll = false;
		((EditBase)x).AutoScrollMargin = new Size(0, 0);
		((EditBase)x).AutoScrollMinSize = new Size(0, 0);
		((EditBase)x).AutoScrollPosition = new Point(0, 0);
		((EditBase)x).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)x).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)x).Location = new Point(90, 97);
		x.Mask = "0000/00/00";
		((EditBase)x).MaxLength = 12;
		((Control)x).Name = "txtDatafrom";
		x.Numeric = true;
		((Control)x).RightToLeft = (RightToLeft)0;
		((Control)x).Size = new Size(100, 26);
		((Control)x).TabIndex = 22;
		((Control)x).Tag = "";
		((EditBase)x).TextAlignment = (TextAlignment)3;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((Control)t).Location = new Point(3, 54);
		((Control)t).Name = "txtNam";
		((Control)t).Size = new Size(187, 31);
		((Control)t).TabIndex = 1;
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((Control)s).AutoSize = true;
		((Control)s).Location = new Point(196, 59);
		((Control)s).Name = "label5";
		((Control)s).Size = new Size(70, 24);
		((Control)s).TabIndex = 21;
		((Control)s).Text = "عنوان دوره :";
		((EditBase)r).AutoScroll = false;
		((EditBase)r).AutoScrollMargin = new Size(0, 0);
		((EditBase)r).AutoScrollMinSize = new Size(0, 0);
		((EditBase)r).AutoScrollPosition = new Point(0, 0);
		((Control)r).Location = new Point(139, 13);
		((EditBase)r).MaxLength = 3;
		((Control)r).Name = "txtNumExam";
		((Control)r).Size = new Size(50, 31);
		((Control)r).TabIndex = 0;
		((Control)r).Text = "0";
		((EditBase)r).TextAlignment = (TextAlignment)1;
		r.Value = 0;
		r.ValueType = (NumericEditValueType)9;
		((Control)n).AutoSize = true;
		((Control)n).Location = new Point(195, 139);
		((Control)n).Name = "label3";
		((Control)n).Size = new Size(67, 24);
		((Control)n).TabIndex = 20;
		((Control)n).Text = "پایان دوره :";
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(195, 99);
		((Control)o).Name = "label2";
		((Control)o).Size = new Size(68, 24);
		((Control)o).TabIndex = 18;
		((Control)o).Text = "شروع دوره :";
		m.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)m).Location = new Point(40, 172);
		((Control)m).Name = "btnCancel";
		((Control)m).Size = new Size(75, 31);
		((Control)m).TabIndex = 5;
		((Control)m).Text = "انصراف";
		((Control)m).Click += b;
		k.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)k).Location = new Point(121, 172);
		((Control)k).Name = "btnAcp";
		((Control)k).Size = new Size(75, 31);
		((Control)k).TabIndex = 4;
		((Control)k).Text = "تایید";
		((Control)k).Click += d;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(195, 15);
		((Control)l).Name = "label1";
		((Control)l).Size = new Size(71, 24);
		((Control)l).TabIndex = 1;
		((Control)l).Text = "شماره دوره :";
		((Control)this.m_e).Anchor = (AnchorStyles)14;
		((Control)this.m_e).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_e).Controls.Add((Control)(object)j);
		((Control)this.m_e).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_e).Controls.Add((Control)(object)h);
		((Control)this.m_e).Location = new Point(3, 350);
		((Control)this.m_e).Name = "p_new";
		((Control)this.m_e).Size = new Size(440, 41);
		((Control)this.m_e).TabIndex = 9;
		((Control)this.m_f).Anchor = (AnchorStyles)10;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_f).Location = new Point(194, 3);
		((Control)this.m_f).Name = "btnDelete";
		((Control)this.m_f).Size = new Size(75, 32);
		((Control)this.m_f).TabIndex = 2;
		((Control)this.m_f).Text = "حذف";
		((Control)this.m_f).Click += a;
		((Control)j).Anchor = (AnchorStyles)6;
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(30, 30);
		((Control)j).Location = new Point(7, 3);
		((Control)j).Name = "btnClose";
		((Control)j).Size = new Size(75, 32);
		((Control)j).TabIndex = 15;
		((Control)j).Text = "خروج";
		j.TextHorizontalAlignment = (TextAlignment)1;
		((Control)j).Click += c;
		((Control)this.m_g).Anchor = (AnchorStyles)10;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_g).Location = new Point(357, 3);
		((Control)this.m_g).Name = "btnNew";
		((Control)this.m_g).Size = new Size(75, 32);
		((Control)this.m_g).TabIndex = 0;
		((Control)this.m_g).Text = "جدید";
		((Control)this.m_g).Click += f;
		((Control)h).Anchor = (AnchorStyles)10;
		h.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)h).Location = new Point(275, 3);
		((Control)h).Name = "btnEdit";
		((Control)h).Size = new Size(75, 32);
		((Control)h).TabIndex = 1;
		((Control)h).Text = "اصلاح";
		((Control)h).Click += e;
		((Control)q).BackColor = SystemColors.ControlText;
		((Control)q).Controls.Add((Control)(object)this.m_d);
		((Control)q).Dock = (DockStyle)5;
		((Control)q).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(0, 0);
		((Control)q).Name = "panel2";
		((Control)q).Size = new Size(456, 407);
		((Control)q).TabIndex = 1;
		((Form)this).AcceptButton = (IButtonControl)(object)k;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(456, 407);
		((Control)this).Controls.Add((Control)(object)q);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmExam";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "تعریف دوره";
		((Form)this).Load += g;
		((ISupportInitialize)this.m_c).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)i).ResumeLayout(false);
		((Control)i).PerformLayout();
		((Control)this.m_e).ResumeLayout(false);
		((Control)q).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
