using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdl : Form
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

	private EditBox m_j;

	private UIButton m_k;

	private GridEXPrintDocument m_l;

	private PrintPreviewDialog m;

	private UIButton n;

	private UIButton o;

	private EditBox p;

	private Label q;

	private Label r;

	private Label s;

	private MaskedEditBox t;

	private MaskedEditBox u;

	private Label v;

	private EditBox w;

	private IContainer x;

	private int y;

	private int z = 0;

	public asdl()
	{
		c();
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
					goto case 4;
				case 1:
					num = 4;
					continue;
				case 5:
					x.Dispose();
					num = 1;
					continue;
				case 0:
					flag = x == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 1;
				case 4:
					base.Dispose(A_0);
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
		x = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdl));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_a = new ImageList(x);
		this.m_b = new Panel();
		q = new Label();
		p = new EditBox();
		this.m_f = new Panel();
		w = new EditBox();
		v = new Label();
		t = new MaskedEditBox();
		u = new MaskedEditBox();
		s = new Label();
		r = new Label();
		this.m_i = new Label();
		this.m_j = new EditBox();
		this.m_g = new UIButton();
		this.m_k = new UIButton();
		o = new UIButton();
		n = new UIButton();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new UIButton();
		this.m_h = new GridEX();
		this.m_l = new GridEXPrintDocument();
		m = new PrintPreviewDialog();
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
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(p);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Controls.Add(o);
		this.m_b.Controls.Add(n);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Location = new Point(8, 11);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(433, 560);
		this.m_b.TabIndex = 21;
		q.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		q.Location = new Point(344, 14);
		q.Name = "lfamily1";
		q.RightToLeft = RightToLeft.Yes;
		q.Size = new Size(82, 21);
		q.TabIndex = 41;
		q.Text = "نام راننده :";
		q.TextAlign = ContentAlignment.MiddleRight;
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.Location = new Point(171, 14);
		p.Name = "txtNamlSearch";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(167, 21);
		p.TabIndex = 2;
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		p.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		p.TextChanged += c;
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(w);
		this.m_f.Controls.Add(v);
		this.m_f.Controls.Add(t);
		this.m_f.Controls.Add(u);
		this.m_f.Controls.Add(s);
		this.m_f.Controls.Add(r);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(this.m_j);
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Controls.Add(this.m_k);
		this.m_f.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(21, 145);
		this.m_f.Name = "panel3";
		this.m_f.Size = new Size(393, 302);
		this.m_f.TabIndex = 26;
		this.m_f.Visible = false;
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.Location = new Point(11, 118);
		w.Multiline = true;
		w.Name = "txtComment";
		w.Size = new Size(305, 122);
		w.TabIndex = 4;
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		v.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		v.Location = new Point(322, 118);
		v.Name = "label1";
		v.RightToLeft = RightToLeft.Yes;
		v.Size = new Size(57, 21);
		v.TabIndex = 45;
		v.Text = "توضیحات :";
		v.TextAlign = ContentAlignment.MiddleRight;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		t.Location = new Point(124, 77);
		t.MaxLength = 11;
		t.Name = "txtMobile2";
		t.Numeric = true;
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(192, 21);
		t.TabIndex = 3;
		t.Tag = "";
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(124, 45);
		u.MaxLength = 11;
		u.Name = "txtMobile1";
		u.Numeric = true;
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(192, 21);
		u.TabIndex = 2;
		u.Tag = "";
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		s.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Location = new Point(322, 77);
		s.Name = "label3";
		s.RightToLeft = RightToLeft.Yes;
		s.Size = new Size(57, 21);
		s.TabIndex = 42;
		s.Text = "تلفن 2  :";
		s.TextAlign = ContentAlignment.MiddleRight;
		r.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Location = new Point(322, 45);
		r.Name = "label2";
		r.RightToLeft = RightToLeft.Yes;
		r.Size = new Size(57, 21);
		r.TabIndex = 41;
		r.Text = "تلفن 1  :";
		r.TextAlign = ContentAlignment.MiddleRight;
		this.m_i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(322, 13);
		this.m_i.Name = "lname2";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(57, 21);
		this.m_i.TabIndex = 39;
		this.m_i.Text = "نام راننده :";
		this.m_i.TextAlign = ContentAlignment.MiddleRight;
		this.m_j.AutoScroll = false;
		this.m_j.AutoScrollMargin = new Size(0, 0);
		this.m_j.AutoScrollMinSize = new Size(0, 0);
		this.m_j.AutoScrollPosition = new Point(0, 0);
		this.m_j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(124, 13);
		this.m_j.Name = "txtNamF";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(192, 21);
		this.m_j.TabIndex = 1;
		this.m_j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_j.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_g.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCansel.Image");
		this.m_g.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_g.Location = new Point(26, 256);
		this.m_g.Name = "btnCansel";
		this.m_g.Size = new Size(88, 32);
		this.m_g.TabIndex = 6;
		this.m_g.Text = "انصراف";
		this.m_g.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_g.Click += h;
		this.m_k.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_k.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_k.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		this.m_k.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_k.ImageIndex = 8;
		this.m_k.ImageSize = new Size(30, 30);
		this.m_k.Location = new Point(124, 256);
		this.m_k.Name = "btnAccept";
		this.m_k.Size = new Size(88, 32);
		this.m_k.TabIndex = 5;
		this.m_k.Text = "تائيد";
		this.m_k.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_k.Click += j;
		o.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		o.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		o.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		o.ImageIndex = 8;
		o.ImageSize = new Size(30, 30);
		o.Location = new Point(11, 512);
		o.Name = "uiButton1";
		o.Size = new Size(73, 40);
		o.TabIndex = 28;
		o.Text = "خروج";
		o.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		o.Click += e;
		n.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		n.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		n.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		n.ImageSize = new Size(30, 30);
		n.Location = new Point(92, 512);
		n.Name = "btnPrint";
		n.Size = new Size(73, 40);
		n.TabIndex = 27;
		n.Text = "چاپ";
		n.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		n.Click += f;
		this.m_c.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_c.Enabled = false;
		this.m_c.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_c.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_c.ImageSize = new Size(30, 30);
		this.m_c.Location = new Point(188, 512);
		this.m_c.Name = "btnDelete";
		this.m_c.Size = new Size(73, 40);
		this.m_c.TabIndex = 2;
		this.m_c.Text = "حذف";
		this.m_c.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_c.Click += g;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.ImageIndex = 8;
		this.m_d.Location = new Point(349, 512);
		this.m_d.Name = "btnNew";
		this.m_d.Size = new Size(73, 40);
		this.m_d.TabIndex = 0;
		this.m_d.Text = "جديد";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += k;
		this.m_e.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_e.Enabled = false;
		this.m_e.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_e.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(30, 30);
		this.m_e.Location = new Point(268, 512);
		this.m_e.Name = "btnEdit";
		this.m_e.Size = new Size(73, 40);
		this.m_e.TabIndex = 1;
		this.m_e.Text = "اصلاح";
		this.m_e.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_e.Click += i;
		this.m_h.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_h.CardCaptionPrefix = "Product:";
		this.m_h.Cursor = Cursors.Default;
		this.m_h.DataMember = null;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
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
		this.m_h.Location = new Point(8, 47);
		this.m_h.Name = "gteacher";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_h.SelectedFormatStyle.Blend = 0.5f;
		this.m_h.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_h.Size = new Size(413, 456);
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
		this.m_h.Click += b;
		this.m_h.SelectionChanged += a;
		this.m_l.GridEX = this.m_h;
		this.m_l.PageFooterLeft = "3";
		this.m_l.PageFooterRight = "2";
		this.m_l.PageHeaderCenter = "1";
		this.m_l.PageHeaderLeft = "4";
		this.m_l.PageHeaderRight = "5";
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.ClientSize = new Size(400, 300);
		m.Document = this.m_l;
		m.Enabled = true;
		m.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		m.Name = "printPreviewDialog1";
		m.Visible = false;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = SystemColors.InactiveCaption;
		ClientSize = new Size(450, 583);
		ControlBox = false;
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmDriver";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "اطلاعات معلمان";
		Load += l;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_f.ResumeLayout(performLayout: false);
		((ISupportInitialize)this.m_h).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void l(object A_0, EventArgs A_1)
	{
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
				case 4:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_b.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_0129;
				case 6:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 5;
					continue;
				case 5:
					return;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0129;
				case 0:
					{
						num = 4;
						continue;
					}
					IL_0129:
					b();
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		int num = z;
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tDriver");
		this.m_h.DataSource = dataSource;
		try
		{
			this.m_h.Focus();
			this.m_h.Row = num - 1;
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		y = 1;
		this.m_f.Visible = true;
		a();
		this.m_j.Focus();
	}

	private void a()
	{
		if (true)
		{
		}
		w.Text = "";
		u.Text = "";
		t.Text = "";
		this.m_j.Text = "";
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			this.m_j.Text = OriginalText.Normalize(this.m_j.Text.Trim());
			bool flag = y != 1;
			if (true)
			{
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 2;
						continue;
					}
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tDriver SET name=@name,mobil=@mobil,mobil2=@mobil2,comment=@comment WHERE id=@id",
                        asdcb.a("@name", SqlDbType.NVarChar, this.m_j.Text.Trim()),
                        asdcb.a("@mobil", SqlDbType.NVarChar, u.Text.Trim()),
                        asdcb.a("@mobil2", SqlDbType.NVarChar, t.Text.Trim()),
                        asdcb.a("@comment", SqlDbType.NVarChar, w.Text.Trim()),
                        asdcb.a("@id", SqlDbType.Int, Convert.ToInt32(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value)));
					this.m_f.Visible = false;
					num = 1;
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tDriver (name,mobil,mobil2,comment) VALUES (@name,@mobil,@mobil2,@comment)",
                        asdcb.a("@name", SqlDbType.NVarChar, this.m_j.Text.Trim()),
                        asdcb.a("@mobil", SqlDbType.NVarChar, u.Text.Trim()),
                        asdcb.a("@mobil2", SqlDbType.NVarChar, t.Text.Trim()),
                        asdcb.a("@comment", SqlDbType.NVarChar, w.Text.Trim()));
					a();
					this.m_j.Focus();
					num = 3;
					continue;
				case 1:
				case 3:
					d(this, null);
					return;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
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
					num = ((this.m_h.RowCount <= 0) ? 5 : 6);
					continue;
				case 6:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_h.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_017d;
				case 0:
				{
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tDriver where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
                    y = 2; // Editing must update the selected driver, not insert another one.
					this.m_j.Text = dataTable.Rows[0]["name"].ToString();
					u.Text = dataTable.Rows[0]["mobil"].ToString();
					t.Text = dataTable.Rows[0]["mobil2"].ToString();
					w.Text = dataTable.Rows[0]["comment"].ToString();
					this.m_f.Visible = true;
					num = 2;
					continue;
				}
				case 2:
					return;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 5:
					{
						num2 = 1;
						goto IL_017d;
					}
					IL_017d:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}

	private void g(object A_0, EventArgs A_1)
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
					num = ((this.m_h.RowCount < 1) ? 12 : 10);
					continue;
				case 5:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tDriver where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					b();
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					goto IL_016a;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					MessageBox.Show("برای این راننده دانش آموز اختصاص یافته است .حذف امکان پذیر نیست");
					num = 9;
					continue;
				case 12:
					num2 = 0;
					goto IL_0221;
				case 11:
					return;
				case 10:
					num = 13;
					continue;
				case 13:
					num2 = ((this.m_h.SelectedItems[0].RowType == RowType.Record) ? 1 : 0);
					goto IL_0221;
				case 4:
					flag = MessageBox.Show("آيا از حذف راننده مطمئن هستيد؟", "حذف راننده", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto IL_016a;
				case 9:
					return;
				case 1:
					MessageBox.Show("راننده ای انتخاب نشده است");
					num = 3;
					continue;
				case 3:
					return;
				case 6:
					{
						if (flag)
						{
							string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) FROM   tYear_Student WHERE xDriver = " + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
							flag = !(text == "0");
							num = 0;
						}
						else
						{
							num = 1;
						}
						continue;
					}
					IL_016a:
					num = 11;
					continue;
					IL_0221:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		Rectangle bounds = Bounds;
		m.SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
		m.UseAntiAlias = true;
		m.ShowDialog(this);
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = z;
			string text = "";
			bool flag = !(p.Text.Trim() != "");
			if (true)
			{
			}
			int num2 = 18;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 18:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					goto case 10;
				case 2:
					text = " where " + text;
					num2 = 12;
					continue;
				case 14:
					num2 = 17;
					continue;
				case 17:
					num3 = ((this.m_h.RecordCount != num) ? 1 : 0);
					goto IL_0152;
				case 12:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tDriver" + text, new SqlParameter("@SearchName", "%"+OriginalText.Normalize(p.Text.Trim())+"%"));
					this.m_h.DataSource = dataSource;
					num2 = 7;
					continue;
				}
				case 7:
					num2 = ((y != 2) ? 6 : 9);
					continue;
				case 13:
					if (!flag)
					{
						num2 = 21;
						continue;
					}
					goto case 4;
				case 16:
					text += " and ";
					num2 = 0;
					continue;
				case 15:
					flag = !(text != "");
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 0;
				case 21:
					this.m_h.Focus();
					this.m_h.Row = num - 1;
					num2 = 4;
					continue;
				case 10:
					flag = !(text != "");
					num2 = 5;
					continue;
				case 5:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					goto case 12;
				case 9:
					num2 = 3;
					continue;
				case 3:
					num4 = ((this.m_h.RecordCount <= num) ? 1 : 0);
					goto IL_02f7;
				case 22:
					num2 = ((y != 2) ? 20 : 14);
					continue;
				case 0:
					text = text + "name like @SearchName";
					num2 = 10;
					continue;
				case 6:
					num4 = 1;
					goto IL_02f7;
				case 8:
					this.m_h.Focus();
					this.m_h.Row = num;
					num2 = 11;
					continue;
				case 19:
					num2 = ((!flag) ? 8 : 22);
					continue;
				case 20:
					num3 = 1;
					goto IL_0152;
				case 4:
				case 11:
					{
						y = 1;
						return;
					}
					IL_02f7:
					flag = (byte)num4 != 0;
					num2 = 19;
					continue;
					IL_0152:
					flag = (byte)num3 != 0;
					num2 = 13;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		d(this, null);
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			while (true)
			{
				if (true)
				{
				}
				bool flag = this.m_h.SelectedItems[0].RowType == RowType.FilterRow;
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
						this.m_c.Enabled = true;
						this.m_e.Enabled = true;
						num = 2;
						continue;
					case 2:
						num = 3;
						continue;
					case 3:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		z = this.m_h.Row;
        bool selected=this.m_h.SelectedItems.Count>0 && this.m_h.SelectedItems[0].RowType==RowType.Record;
        this.m_c.Enabled=selected;
        this.m_e.Enabled=selected;
	}
}
