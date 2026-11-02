using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdi : Form
{
	private ImageList m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private UIButton m_e;

	private Panel m_f;

	private UIButton m_g;

	private GridEX m_h;

	private Label m_i;

	private Label m_j;

	private EditBox k;

	private EditBox l;

	private UIButton m;

	private GridEXPrintDocument n;

	private PrintPreviewDialog o;

	private UIButton p;

	private UIButton q;

	private UIButton r;

	private UIButton s;

	private Label t;

	private IContainer u;

	private int v;

	public asdi()
	{
		b();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 5;
				case 1:
					num = 5;
					continue;
				case 4:
					u.Dispose();
					num = 1;
					continue;
				case 0:
					flag = u == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 5:
					base.Dispose(A_0);
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
		u = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdi));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_a = new ImageList(u);
		this.m_b = new Panel();
		t = new Label();
		s = new UIButton();
		r = new UIButton();
		this.m_f = new Panel();
		this.m_j = new Label();
		this.m_i = new Label();
		k = new EditBox();
		l = new EditBox();
		this.m_g = new UIButton();
		m = new UIButton();
		q = new UIButton();
		p = new UIButton();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new UIButton();
		this.m_h = new GridEX();
		n = new GridEXPrintDocument();
		o = new PrintPreviewDialog();
		this.m_b.SuspendLayout();
		this.m_f.SuspendLayout();
		((ISupportInitialize)this.m_h).BeginInit();
		SuspendLayout();
		this.m_a.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("icons.ImageStream");
		this.m_a.TransparentColor = Color.Magenta;
		this.m_a.Images.SetKeyName(0, "");
		this.m_a.Images.SetKeyName(1, "");
		this.m_a.Images.SetKeyName(2, "");
		this.m_a.Images.SetKeyName(3, "");
		this.m_a.Images.SetKeyName(4, "");
		this.m_a.Images.SetKeyName(5, "");
		this.m_a.Images.SetKeyName(6, "");
		this.m_a.Images.SetKeyName(7, "");
		this.m_a.Images.SetKeyName(8, "");
		this.m_a.Images.SetKeyName(9, "");
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(t);
		this.m_b.Controls.Add(s);
		this.m_b.Controls.Add(r);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(p);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Location = new Point(6, 6);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(378, 456);
		this.m_b.TabIndex = 21;
		t.AutoSize = true;
		t.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.ForeColor = Color.DarkViolet;
		t.Location = new Point(113, 3);
		t.Name = "label1";
		t.Size = new Size(153, 40);
		t.TabIndex = 66;
		t.Text = "مدیریت کاربران ";
		s.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		s.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.ImageIndex = 8;
		s.Location = new Point(4, 363);
		s.Name = "btnPermission";
		s.Size = new Size(110, 40);
		s.TabIndex = 65;
		s.Text = "مجوزها";
		s.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		s.Click += c;
		r.BackColor = Color.FromArgb(214, 223, 247);
		r.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		r.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		r.ImageIndex = 8;
		r.ImageSize = new Size(40, 40);
		r.Location = new Point(4, 409);
		r.Name = "uiButton2";
		r.Size = new Size(360, 40);
		r.TabIndex = 64;
		r.Text = "خروج";
		r.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		r.Click += b;
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(this.m_j);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(k);
		this.m_f.Controls.Add(l);
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Controls.Add(m);
		this.m_f.Location = new Point(36, 128);
		this.m_f.Name = "pUid";
		this.m_f.Size = new Size(282, 127);
		this.m_f.TabIndex = 26;
		this.m_f.Visible = false;
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(168, 40);
		this.m_j.Name = "label4";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(104, 21);
		this.m_j.TabIndex = 40;
		this.m_j.Text = "کلمه عبور :";
		this.m_j.TextAlign = ContentAlignment.MiddleRight;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(168, 9);
		this.m_i.Name = "label3";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(109, 21);
		this.m_i.TabIndex = 39;
		this.m_i.Text = "نام کاربر :";
		this.m_i.TextAlign = ContentAlignment.MiddleRight;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.AutoScroll = false;
		k.AutoScrollMargin = new Size(0, 0);
		k.AutoScrollMinSize = new Size(0, 0);
		k.AutoScrollPosition = new Point(0, 0);
		k.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(24, 40);
		k.Name = "txtPwd";
		k.PasswordChar = '*';
		k.RightToLeft = RightToLeft.Yes;
		k.Size = new Size(136, 21);
		k.TabIndex = 3;
		k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		k.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoScroll = false;
		l.AutoScrollMargin = new Size(0, 0);
		l.AutoScrollMinSize = new Size(0, 0);
		l.AutoScrollPosition = new Point(0, 0);
		l.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.Location = new Point(24, 9);
		l.Name = "txtUid";
		l.RightToLeft = RightToLeft.Yes;
		l.Size = new Size(136, 21);
		l.TabIndex = 2;
		l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		l.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCansel.Image");
		this.m_g.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_g.Location = new Point(15, 76);
		this.m_g.Name = "btnCansel";
		this.m_g.Size = new Size(88, 32);
		this.m_g.TabIndex = 10;
		this.m_g.Text = "انصراف";
		this.m_g.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_g.Click += g;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		m.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		m.ImageIndex = 8;
		m.ImageSize = new Size(30, 30);
		m.Location = new Point(109, 76);
		m.Name = "btnAccept";
		m.Size = new Size(88, 32);
		m.TabIndex = 9;
		m.Text = "تائيد";
		m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		m.Click += i;
		q.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		q.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		q.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		q.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		q.ImageIndex = 8;
		q.ImageSize = new Size(30, 30);
		q.Location = new Point(16, 512);
		q.Name = "uiButton1";
		q.Size = new Size(80, 40);
		q.TabIndex = 28;
		q.Text = "خروج";
		q.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		q.Click += e;
		p.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		p.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		p.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		p.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		p.ImageSize = new Size(30, 30);
		p.Location = new Point(-288, 512);
		p.Name = "btnPrint";
		p.Size = new Size(82, 40);
		p.TabIndex = 27;
		p.Text = "چاپ";
		p.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_c.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_c.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_c.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_c.ImageSize = new Size(30, 30);
		this.m_c.Location = new Point(120, 364);
		this.m_c.Name = "btnDelete";
		this.m_c.Size = new Size(77, 40);
		this.m_c.TabIndex = 2;
		this.m_c.Text = "حذف";
		this.m_c.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_c.Click += f;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.ImageIndex = 8;
		this.m_d.Location = new Point(292, 364);
		this.m_d.Name = "btnNew";
		this.m_d.Size = new Size(72, 40);
		this.m_d.TabIndex = 0;
		this.m_d.Text = "جديد";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += j;
		this.m_e.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_e.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_e.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(30, 30);
		this.m_e.Location = new Point(205, 364);
		this.m_e.Name = "btnEdit";
		this.m_e.Size = new Size(81, 40);
		this.m_e.TabIndex = 1;
		this.m_e.Text = "اصلاح";
		this.m_e.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_e.Click += h;
		this.m_h.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_h.CardCaptionPrefix = "Product:";
		this.m_h.ColumnAutoResize = true;
		this.m_h.Cursor = Cursors.Default;
		this.m_h.DataMember = null;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_h.DesignTimeLayout = gridEXLayout;
		this.m_h.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_h.ExternalImageList = this.m_a;
		this.m_h.FlatBorderColor = SystemColors.ControlDark;
		this.m_h.FocusStyle = FocusStyle.None;
		this.m_h.Font = new Font("Tahoma", 8.25f);
		this.m_h.GridLineColor = SystemColors.ScrollBar;
		this.m_h.GroupByBoxInfoFormatStyle.BackColor = Color.Empty;
		this.m_h.GroupByBoxInfoFormatStyle.Key = "4545";
		this.m_h.GroupByBoxVisible = false;
		this.m_h.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_h.GroupTotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		this.m_h.Location = new Point(3, 49);
		this.m_h.Name = "gUid";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_h.SelectedFormatStyle.Blend = 0.5f;
		this.m_h.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_h.Size = new Size(364, 309);
		this.m_h.TabIndex = 4;
		this.m_h.TabStop = false;
		this.m_h.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_h.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.SelectionChanged += a;
		n.GridEX = this.m_h;
		n.PageFooterLeft = "3";
		n.PageFooterRight = "2";
		n.PageHeaderCenter = "1";
		n.PageHeaderLeft = "4";
		n.PageHeaderRight = "5";
		o.AutoScrollMargin = new Size(0, 0);
		o.AutoScrollMinSize = new Size(0, 0);
		o.ClientSize = new Size(400, 300);
		o.Document = n;
		o.Enabled = true;
		o.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		o.Name = "printPreviewDialog1";
		o.Visible = false;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = SystemColors.InactiveCaption;
		ClientSize = new Size(391, 472);
		ControlBox = false;
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmUser";
		RightToLeft = RightToLeft.Yes;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "اطلاعات اساتيد";
		Load += d;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		((ISupportInitialize)this.m_h).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select *  from tuser");
		this.m_h.DataSource = dataSource;
	}

	private void j(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		v = 1;
		this.m_f.Visible = true;
		l.Focus();
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(l.Text.Trim() == "");
			int num = 12;
			while (true)
			{
				switch (num)
				{
				case 12:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = !(l.Text.Trim() == "");
					num = 8;
					continue;
				case 10:
					MessageBox.Show("کلمه عبور را وارد کنيد");
					k.Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 8:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = !(k.Text.Trim() == "");
					num = 13;
					continue;
				case 9:
					MessageBox.Show("نام کاربر را وارد کنيد");
					l.Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 6:
					if (flag)
					{
						string a_ = this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + "kbr63" + k.Text;
						a_ = asdab.d(a_);
						asdcb.d(asdab.e(), CommandType.Text, "UPDATE tuser SET uid = N'" + l.Text + "', pwd = N'" + a_ + "',pw=398 WHERE (id = " + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")");
						this.m_f.Visible = false;
						l.Text = "";
						k.Text = "";
						num = 3;
					}
					else
					{
						num = 5;
					}
					continue;
				case 5:
				{
					if (true)
					{
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,1) from tuser").ToString();
					string a_ = text + "kbr63" + k.Text;
					a_ = asdab.d(a_);
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tuser (id, uid, pwd,pw) VALUES  (" + text + ", N'" + l.Text + "', N'" + a_ + "',398)");
					l.Text = "";
					k.Text = "";
					l.Focus();
					num = 2;
					continue;
				}
				case 2:
				case 3:
					a();
					num = 0;
					continue;
				case 0:
					return;
				case 13:
					if (flag)
					{
						l.Text = asdaj.b(l.Text.Trim());
						k.Text = asdaj.b(k.Text.Trim());
						flag = v != 1;
						num = 6;
					}
					else
					{
						num = 10;
					}
					continue;
				case 1:
					MessageBox.Show("نام کاربر را وارد کنيد");
					l.Focus();
					num = 4;
					continue;
				case 4:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		string text = default;
		int num2 = default;
		while (true)
		{
			bool flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					v = 2;
					l.Text = this.m_h.SelectedItems[0].GetRow().Cells["uid"].Value.ToString();
					k.Text = "";
					text = asdab.c(this.m_h.SelectedItems[0].GetRow().Cells["pwd"].Value.ToString());
					num2 = text.IndexOf("kbr63");
					flag = num2 <= 0;
					num = 7;
					continue;
				case 3:
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0135;
				case 0:
					flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == text.Substring(0, num2));
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 3;
				case 6:
					MessageBox.Show("امکان پذیر نیست admin اصلاح برای کاربر\n برای تغییر رمز از صفحه ورود به برنامه دکمه تغییر رمز استفاده کنید");
					num = 4;
					continue;
				case 4:
					return;
				case 8:
					return;
				case 7:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_0135;
				case 9:
					{
						num2 += 5;
						k.Text = text.Substring(num2, text.Length - num2);
						num = 3;
						continue;
					}
					IL_0135:
					this.m_f.Visible = true;
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_h.RowCount != 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1");
					num = 6;
					continue;
				case 8:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 2:
					MessageBox.Show("امکان پذیر نیست admin حذف کاربر");
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					MessageBox.Show("کاربری انتخاب نشده است");
					num = 5;
					continue;
				case 5:
					return;
				case 7:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tPermission where xuser=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tuser where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 3;
					continue;
				case 3:
					return;
				case 6:
					if (flag)
					{
						if (true)
						{
						}
						flag = MessageBox.Show("آيا از حذف کاربر مطمئن هستيد؟", "حذف کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 8;
					}
					else
					{
						num = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					a();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Close();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 0;
						continue;
					}
					asds asds2 = new asds();
					asds2.o = this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					asds2.ShowDialog();
					num = 2;
					continue;
				}
				case 2:
					return;
				case 0:
					MessageBox.Show("نیازی به تنظیم مجوز ندارد admin کاربر");
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}
}
