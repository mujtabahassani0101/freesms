using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdh : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private UIButton m_f;

	private UIButton m_g;

	private Panel h;

	private UIButton i;

	private UIButton j;

	private EditBox k;

	private Label l;

	private Panel m;

	private EditBox n;

	private Label o;

	private UIButton p;

	private Label q;

	private string r;

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
					if (A_0)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 3;
					}
					continue;
				case 4:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 5;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 5:
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

	private void b()
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
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected Obj, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdh));
		this.m_b = new GridEX();
		this.m_c = new Panel();
		l = new Label();
		i = new UIButton();
		h = new Panel();
		n = new EditBox();
		o = new Label();
		p = new UIButton();
		j = new UIButton();
		q = new Label();
		k = new EditBox();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_f = new UIButton();
		this.m_g = new UIButton();
		m = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)h).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)m).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(8, 51);
		((Control)this.m_b).Name = "gridEX1";
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(431, 341);
		((Control)this.m_b).TabIndex = 5;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)h);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_c).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(5, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(445, 487);
		((Control)this.m_c).TabIndex = 0;
		((Control)l).AutoSize = true;
		((Control)l).Font = new Font("B Titr", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(182, 2);
		((Control)l).Name = "label4";
		((Control)l).Size = new Size(74, 42);
		((Control)l).TabIndex = 17;
		((Control)l).Text = "تخفیف";
		((Control)i).Anchor = (AnchorStyles)14;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		((Control)i).Location = new Point(6, 445);
		((Control)i).Name = "btnClose";
		((Control)i).Size = new Size(430, 36);
		((Control)i).TabIndex = 15;
		((Control)i).Text = "خروج";
		((Control)i).Click += c;
		h.BorderStyle = (BorderStyle)1;
		((Control)h).Controls.Add((Control)(object)n);
		((Control)h).Controls.Add((Control)(object)o);
		((Control)h).Controls.Add((Control)(object)p);
		((Control)h).Controls.Add((Control)(object)j);
		((Control)h).Controls.Add((Control)(object)q);
		((Control)h).Controls.Add((Control)(object)k);
		((Control)h).Location = new Point(31, 176);
		((Control)h).Name = "pcls";
		((Control)h).Size = new Size(363, 197);
		((Control)h).TabIndex = 10;
		((Control)h).Visible = false;
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((EditBase)n).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(5, 50);
		n.Multiline = true;
		((Control)n).Name = "txtComment";
		((Control)n).Size = new Size(265, 93);
		((Control)n).TabIndex = 1;
		((EditBase)n).TextAlignment = (TextAlignment)1;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(273, 52);
		((Control)o).Name = "label2";
		((Control)o).Size = new Size(62, 16);
		((Control)o).TabIndex = 17;
		((Control)o).Text = "توضیحات";
		p.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)p).Location = new Point(18, 151);
		((Control)p).Name = "btnCancel";
		((Control)p).Size = new Size(75, 35);
		((Control)p).TabIndex = 3;
		((Control)p).Text = "انصراف";
		((Control)p).Click += b;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)j).Location = new Point(99, 151);
		((Control)j).Name = "btnAcp";
		((Control)j).Size = new Size(75, 35);
		((Control)j).TabIndex = 2;
		((Control)j).Text = "تایید";
		((Control)j).Click += d;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(272, 13);
		((Control)q).Name = "label1";
		((Control)q).Size = new Size(87, 16);
		((Control)q).TabIndex = 1;
		((Control)q).Text = "عنوان تخفیف";
		((EditBase)k).AutoScroll = false;
		((EditBase)k).AutoScrollMargin = new Size(0, 0);
		((EditBase)k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)k).AutoScrollPosition = new Point(0, 0);
		((EditBase)k).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(4, 9);
		((Control)k).Name = "txtNam";
		((Control)k).Size = new Size(265, 23);
		((Control)k).TabIndex = 0;
		((EditBase)k).TextAlignment = (TextAlignment)1;
		((Control)this.m_d).Anchor = (AnchorStyles)14;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Location = new Point(1, 395);
		((Control)this.m_d).Name = "p_new";
		((Control)this.m_d).Size = new Size(438, 45);
		((Control)this.m_d).TabIndex = 9;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_e).Location = new Point(6, 6);
		((Control)this.m_e).Name = "btnDelete";
		((Control)this.m_e).Size = new Size(127, 36);
		((Control)this.m_e).TabIndex = 2;
		((Control)this.m_e).Text = "حذف";
		((Control)this.m_e).Click += a;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_f).Location = new Point(304, 6);
		((Control)this.m_f).Name = "btnNew";
		((Control)this.m_f).Size = new Size(127, 36);
		((Control)this.m_f).TabIndex = 0;
		((Control)this.m_f).Text = "جدید";
		((Control)this.m_f).Click += f;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)this.m_g).Location = new Point(157, 6);
		((Control)this.m_g).Name = "btnEdit";
		((Control)this.m_g).Size = new Size(127, 36);
		((Control)this.m_g).TabIndex = 1;
		((Control)this.m_g).Text = "اصلاح";
		((Control)this.m_g).Click += e;
		((Control)m).BackColor = SystemColors.ControlText;
		((Control)m).Controls.Add((Control)(object)this.m_c);
		((Control)m).Dock = (DockStyle)5;
		((Control)m).Location = new Point(0, 0);
		((Control)m).Name = "panel2";
		((Control)m).Size = new Size(455, 500);
		((Control)m).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(455, 500);
		((Control)this).Controls.Add((Control)(object)m);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmTakhfif";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست تخفیف ها";
		((Form)this).Load += g;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)h).ResumeLayout(false);
		((Control)h).PerformLayout();
		((Control)this.m_d).ResumeLayout(false);
		((Control)m).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdh()
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_c).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto IL_0131;
				case 7:
					return;
				case 1:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					if (1 == 0)
					{
					}
					goto IL_0131;
				case 2:
					{
						num = 3;
						continue;
					}
					IL_0131:
					a();
					num = 7;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tTakhfif");
		this.m_b.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		r = "insert";
		((Control)h).Visible = true;
		((Control)k).Text = "";
		((Control)n).Text = "";
		((Control)k).Focus();
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_b.RowCount <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					r = "update";
					((Control)h).Visible = true;
					((Control)k).Text = this.m_b.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
					((Control)n).Text = this.m_b.SelectedItems[0].GetRow().Cells["comment"].Value.ToString();
					((Control)k).Select();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string text = "0";
			bool flag = !(((Control)k).Text.Trim() == "");
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
					flag = !(r == "update");
					num = 3;
					continue;
				case 4:
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tTakhfif (name,comment) values(N'" + asdaj.b(((Control)k).Text) + "',N'" + ((Control)n).Text + "' )");
					((Control)k).Text = "";
					((Control)n).Text = "";
					((Control)k).Focus();
					if (true)
					{
					}
					num = 1;
					continue;
				case 2:
					text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, " update tTakhfif set name=N'" + asdaj.b(((Control)k).Text) + "',comment=N'" + ((Control)n).Text + "' where id=" + text);
					((Control)h).Visible = false;
					num = 0;
					continue;
				case 9:
					MessageBox.Show("عنوان تخفیف را وارد کنید");
					((Control)k).Focus();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				case 1:
					a();
					num = 8;
					continue;
				case 8:
					return;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(r == "insert");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 0;
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
		((Control)h).Visible = false;
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Invalid comparison between Unknown and I4
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
					num = ((this.m_b.RowCount <= 0) ? 4 : 11);
					continue;
				case 8:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 9;
				case 5:
					MessageBox.Show("تعداد " + text + " شاگرد برای این تخفیف وجود دارد.امکان حذف وجود ندارد");
					num = 7;
					continue;
				case 7:
					return;
				case 4:
					num2 = 1;
					goto IL_0213;
				case 9:
					num = 10;
					continue;
				case 10:
					return;
				case 11:
					num = 12;
					continue;
				case 12:
					if (true)
					{
					}
					num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_0213;
				case 0:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tTakhfif where id=" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 9;
					continue;
				case 1:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tYear_Student WHERE xTakhfif =" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						flag = (int)MessageBox.Show("آيا از حذف تخفیف مطمئن هستيد؟", "حذف تخفیف", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 8;
					}
					else
					{
						num = 5;
					}
					continue;
				case 3:
					{
						if (!flag)
						{
							num = 1;
							continue;
						}
						return;
					}
					IL_0213:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}
}
