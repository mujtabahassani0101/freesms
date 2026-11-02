using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdcd : Form
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

	private Label k;

	private EditBox l;

	private UIButton m;

	private Label n;

	private Panel o;

	private string p;

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 1;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 0;
					}
					continue;
				case 3:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 0:
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
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected Obj, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdcd));
		this.m_b = new GridEX();
		this.m_c = new Panel();
		n = new Label();
		i = new UIButton();
		h = new Panel();
		m = new UIButton();
		j = new UIButton();
		k = new Label();
		l = new EditBox();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_f = new UIButton();
		this.m_g = new UIButton();
		o = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)h).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)o).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(8, 51);
		((Control)this.m_b).Name = "gridEX1";
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(275, 341);
		((Control)this.m_b).TabIndex = 5;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)n);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)h);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(5, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(289, 487);
		((Control)this.m_c).TabIndex = 0;
		((Control)n).AutoSize = true;
		((Control)n).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(94, 6);
		((Control)n).Name = "label4";
		((Control)n).Size = new Size(110, 33);
		((Control)n).TabIndex = 17;
		((Control)n).Text = "لیست پایه ها";
		((Control)i).Anchor = (AnchorStyles)14;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		((Control)i).Location = new Point(6, 445);
		((Control)i).Name = "btnClose";
		((Control)i).Size = new Size(274, 36);
		((Control)i).TabIndex = 15;
		((Control)i).Text = "خروج";
		((Control)i).Click += c;
		h.BorderStyle = (BorderStyle)1;
		((Control)h).Controls.Add((Control)(object)m);
		((Control)h).Controls.Add((Control)(object)j);
		((Control)h).Controls.Add((Control)(object)k);
		((Control)h).Controls.Add((Control)(object)l);
		((Control)h).Location = new Point(16, 176);
		((Control)h).Name = "pcls";
		((Control)h).Size = new Size(260, 104);
		((Control)h).TabIndex = 10;
		((Control)h).Visible = false;
		m.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)m).Location = new Point(18, 53);
		((Control)m).Name = "btnCancel";
		((Control)m).Size = new Size(75, 35);
		((Control)m).TabIndex = 16;
		((Control)m).Text = "انصراف";
		((Control)m).Click += b;
		j.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)j).Location = new Point(99, 53);
		((Control)j).Name = "btnAcp";
		((Control)j).Size = new Size(75, 35);
		((Control)j).TabIndex = 14;
		((Control)j).Text = "تایید";
		((Control)j).Click += d;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(203, 17);
		((Control)k).Name = "label1";
		((Control)k).Size = new Size(52, 26);
		((Control)k).TabIndex = 1;
		((Control)k).Text = "نام پایه";
		((EditBase)l).AutoScroll = false;
		((EditBase)l).AutoScrollMargin = new Size(0, 0);
		((EditBase)l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)l).AutoScrollPosition = new Point(0, 0);
		((EditBase)l).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(3, 12);
		((Control)l).Name = "txtNam";
		((Control)l).Size = new Size(194, 31);
		((Control)l).TabIndex = 0;
		((EditBase)l).TextAlignment = (TextAlignment)1;
		((Control)this.m_d).Anchor = (AnchorStyles)14;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Location = new Point(1, 395);
		((Control)this.m_d).Name = "p_new";
		((Control)this.m_d).Size = new Size(282, 45);
		((Control)this.m_d).TabIndex = 9;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		((Control)this.m_e).Location = new Point(6, 6);
		((Control)this.m_e).Name = "btnDelete";
		((Control)this.m_e).Size = new Size(77, 36);
		((Control)this.m_e).TabIndex = 2;
		((Control)this.m_e).Text = "حذف";
		((Control)this.m_e).Click += a;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_f).Location = new Point(188, 6);
		((Control)this.m_f).Name = "btnNew";
		((Control)this.m_f).Size = new Size(86, 36);
		((Control)this.m_f).TabIndex = 0;
		((Control)this.m_f).Text = "جدید";
		((Control)this.m_f).Click += f;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)this.m_g).Location = new Point(93, 6);
		((Control)this.m_g).Name = "btnEdit";
		((Control)this.m_g).Size = new Size(81, 36);
		((Control)this.m_g).TabIndex = 1;
		((Control)this.m_g).Text = "اصلاح";
		((Control)this.m_g).Click += e;
		((Control)o).BackColor = SystemColors.ControlText;
		((Control)o).Controls.Add((Control)(object)this.m_c);
		((Control)o).Dock = (DockStyle)5;
		((Control)o).Location = new Point(0, 0);
		((Control)o).Name = "panel2";
		((Control)o).Size = new Size(300, 500);
		((Control)o).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(300, 500);
		((Control)this).Controls.Add((Control)(object)o);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmPaye";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست پایه ها";
		((Form)this).Load += g;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)h).ResumeLayout(false);
		((Control)h).PerformLayout();
		((Control)this.m_d).ResumeLayout(false);
		((Control)o).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdcd()
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 7;
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
						((Control)this.m_c).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto IL_0129;
				case 6:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 4;
					continue;
				case 4:
					return;
				case 5:
					if (1 == 0)
					{
					}
					goto IL_0129;
				case 2:
					{
						num = 0;
						continue;
					}
					IL_0129:
					a();
					num = 6;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tPaye where id in(" + asdaj.n + ")");
		this.m_b.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		p = "insert";
		((Control)h).Visible = true;
		((Control)l).Text = "";
		((Control)l).Focus();
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
						num = 2;
						continue;
					}
					return;
				case 2:
					p = "update";
					((Control)h).Visible = true;
					((Control)l).Text = this.m_b.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
					((Control)l).Select();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string text = "0";
			bool flag = !(((Control)l).Text.Trim() == "");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 6;
						continue;
					}
					flag = !(p == "update");
					num = 0;
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, " insert into  tPaye (name) values(N'" + asdaj.b(((Control)l).Text) + "')");
					((Control)l).Text = "";
					((Control)l).Focus();
					if (true)
					{
					}
					num = 5;
					continue;
				case 1:
					text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asdcb.d(asdab.e(), CommandType.Text, " update tPaye set name=N'" + asdaj.b(((Control)l).Text) + "',xExportRpt=null where id=" + text);
					((Control)h).Visible = false;
					num = 7;
					continue;
				case 6:
					MessageBox.Show("نام پایه را وارد کنید");
					((Control)l).Focus();
					num = 8;
					continue;
				case 8:
					return;
				case 5:
				case 7:
					a();
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
					flag = !(p == "insert");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
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
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Invalid comparison between Unknown and I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		bool flag = default;
		string text2 = default;
		string text = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					num = ((this.m_b.RowCount <= 0) ? 3 : 11);
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 15;
				case 14:
					if (flag)
					{
						flag = (int)MessageBox.Show("آيا از حذف پایه مطمئن هستيد؟", "حذف پایه", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 0;
					}
					else
					{
						num = 13;
					}
					continue;
				case 3:
					num2 = 1;
					goto IL_029f;
				case 5:
					asdcb.d(asdab.e(), CommandType.Text, "delete from tPaye where id=" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 15;
					continue;
				case 11:
					num = 2;
					continue;
				case 2:
					num2 = (((int)this.m_b.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_029f;
				case 13:
					MessageBox.Show("تعداد " + text2 + " صنف در این پایه وجود دارد.امکان حذف وجود ندارد");
					num = 10;
					continue;
				case 10:
					if (1 == 0)
					{
					}
					return;
				case 15:
					num = 9;
					continue;
				case 9:
					return;
				case 7:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tStudent WHERE xPaye =" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountClass FROM tClass WHERE xPaye =" + this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
						flag = !(text2 != "0");
						num = 14;
					}
					else
					{
						num = 12;
					}
					continue;
				case 8:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 12:
					MessageBox.Show("تعداد " + text + " شاگرد در این پایه وجود دارد.امکان حذف وجود ندارد");
					num = 4;
					continue;
				case 4:
					return;
					IL_029f:
					flag = (byte)num2 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}
}
