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

public class asdbi : Form
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

	private Label m_k;

	private EditBox m_l;

	private EditBox m_m;

	private EditBox m_n;

	private UIButton o;

	private GridEXPrintDocument p;

	private PrintPreviewDialog q;

	private UIButton r;

	private UIButton s;

	private EditBox t;

	private EditBox u;

	private Label v;

	private EditBox w;

	private Label x;

	private MaskedEditBox y;

	private CheckBox z;

	private Label aa;

	private Label ab;

	private IContainer ac;

	private int ad;

	private int ae = 0;

	public asdbi()
	{
		b();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 0:
					num = 4;
					continue;
				case 2:
					ac.Dispose();
					num = 0;
					continue;
				case 1:
					flag = ac == null;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 4:
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
		ac = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbi));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_a = new ImageList(ac);
		this.m_b = new Panel();
		aa = new Label();
		ab = new Label();
		t = new EditBox();
		u = new EditBox();
		this.m_f = new Panel();
		z = new CheckBox();
		x = new Label();
		y = new MaskedEditBox();
		v = new Label();
		w = new EditBox();
		this.m_k = new Label();
		this.m_j = new Label();
		this.m_i = new Label();
		this.m_l = new EditBox();
		this.m_m = new EditBox();
		this.m_n = new EditBox();
		this.m_g = new UIButton();
		o = new UIButton();
		s = new UIButton();
		r = new UIButton();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new UIButton();
		this.m_h = new GridEX();
		p = new GridEXPrintDocument();
		q = new PrintPreviewDialog();
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
		this.m_b.Controls.Add(aa);
		this.m_b.Controls.Add(ab);
		this.m_b.Controls.Add(t);
		this.m_b.Controls.Add(u);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Controls.Add(s);
		this.m_b.Controls.Add(r);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Location = new Point(8, 11);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(433, 560);
		this.m_b.TabIndex = 21;
		aa.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aa.Location = new Point(126, 13);
		aa.Name = "lname1";
		aa.RightToLeft = RightToLeft.Yes;
		aa.Size = new Size(77, 21);
		aa.TabIndex = 42;
		aa.Text = "نام آموزگار :";
		aa.TextAlign = ContentAlignment.MiddleRight;
		ab.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.Location = new Point(308, 14);
		ab.Name = "lfamily1";
		ab.RightToLeft = RightToLeft.Yes;
		ab.Size = new Size(134, 21);
		ab.TabIndex = 41;
		ab.Text = "نام خانوادگي آموزگار :";
		ab.TextAlign = ContentAlignment.MiddleRight;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.Location = new Point(209, 14);
		t.Name = "txtNamlSearch";
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(96, 21);
		t.TabIndex = 2;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		t.TextChanged += e;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		u.Location = new Point(14, 14);
		u.Name = "txtNamFSearch";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(108, 21);
		u.TabIndex = 3;
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		u.TextChanged += d;
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(z);
		this.m_f.Controls.Add(x);
		this.m_f.Controls.Add(y);
		this.m_f.Controls.Add(v);
		this.m_f.Controls.Add(w);
		this.m_f.Controls.Add(this.m_k);
		this.m_f.Controls.Add(this.m_j);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(this.m_l);
		this.m_f.Controls.Add(this.m_m);
		this.m_f.Controls.Add(this.m_n);
		this.m_f.Controls.Add(this.m_g);
		this.m_f.Controls.Add(o);
		this.m_f.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(46, 190);
		this.m_f.Name = "panel3";
		this.m_f.Size = new Size(292, 177);
		this.m_f.TabIndex = 26;
		this.m_f.Visible = false;
		z.AutoSize = true;
		z.Checked = true;
		z.CheckState = CheckState.Checked;
		z.Location = new Point(22, 12);
		z.Name = "checkID";
		z.Size = new Size(153, 17);
		z.TabIndex = 50;
		z.Text = "کد آموزگار به صورت اتوماتیک";
		z.UseVisualStyleBackColor = true;
		z.CheckedChanged += a;
		x.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		x.Location = new Point(179, 35);
		x.Name = "l_id";
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(96, 21);
		x.TabIndex = 49;
		x.Text = "کد آموزگار :";
		x.TextAlign = ContentAlignment.MiddleRight;
		x.Visible = false;
		y.AutoScroll = false;
		y.AutoScrollMargin = new Size(0, 0);
		y.AutoScrollMinSize = new Size(0, 0);
		y.AutoScrollPosition = new Point(0, 0);
		y.Location = new Point(16, 35);
		y.Name = "txtid";
		y.Numeric = true;
		y.Size = new Size(159, 21);
		y.TabIndex = 48;
		y.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		y.Visible = false;
		v.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		v.Location = new Point(196, 211);
		v.Name = "label10";
		v.RightToLeft = RightToLeft.Yes;
		v.Size = new Size(93, 21);
		v.TabIndex = 47;
		v.Text = "کلمه عبور :";
		v.TextAlign = ContentAlignment.MiddleRight;
		v.Visible = false;
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		w.Location = new Point(31, 211);
		w.MaxLength = 50;
		w.Name = "txtPass";
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(159, 21);
		w.TabIndex = 46;
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		w.Visible = false;
		w.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_k.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_k.Location = new Point(196, 240);
		this.m_k.Name = "label9";
		this.m_k.RightToLeft = RightToLeft.Yes;
		this.m_k.Size = new Size(104, 21);
		this.m_k.TabIndex = 45;
		this.m_k.Text = "پست الکترونيکي :";
		this.m_k.TextAlign = ContentAlignment.MiddleRight;
		this.m_k.Visible = false;
		this.m_j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(179, 87);
		this.m_j.Name = "lfamily2";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(109, 21);
		this.m_j.TabIndex = 40;
		this.m_j.Text = "نام خانوادگي آموزگار :";
		this.m_j.TextAlign = ContentAlignment.MiddleRight;
		this.m_i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(182, 60);
		this.m_i.Name = "lname2";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(96, 21);
		this.m_i.TabIndex = 39;
		this.m_i.Text = "نام آموزگار :";
		this.m_i.TextAlign = ContentAlignment.MiddleRight;
		this.m_l.AutoScroll = false;
		this.m_l.AutoScrollMargin = new Size(0, 0);
		this.m_l.AutoScrollMinSize = new Size(0, 0);
		this.m_l.AutoScrollPosition = new Point(0, 0);
		this.m_l.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(31, 240);
		this.m_l.Name = "txtEmail";
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.Size = new Size(159, 21);
		this.m_l.TabIndex = 8;
		this.m_l.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_l.Visible = false;
		this.m_l.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_m.AutoScroll = false;
		this.m_m.AutoScrollMargin = new Size(0, 0);
		this.m_m.AutoScrollMinSize = new Size(0, 0);
		this.m_m.AutoScrollPosition = new Point(0, 0);
		this.m_m.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_m.Location = new Point(17, 87);
		this.m_m.Name = "txtNamL";
		this.m_m.RightToLeft = RightToLeft.Yes;
		this.m_m.Size = new Size(159, 21);
		this.m_m.TabIndex = 3;
		this.m_m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_m.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_n.AutoScroll = false;
		this.m_n.AutoScrollMargin = new Size(0, 0);
		this.m_n.AutoScrollMinSize = new Size(0, 0);
		this.m_n.AutoScrollPosition = new Point(0, 0);
		this.m_n.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_n.Location = new Point(17, 60);
		this.m_n.Name = "txtNamF";
		this.m_n.RightToLeft = RightToLeft.Yes;
		this.m_n.Size = new Size(159, 21);
		this.m_n.TabIndex = 2;
		this.m_n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_n.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_g.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCansel.Image");
		this.m_g.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_g.Location = new Point(16, 125);
		this.m_g.Name = "btnCansel";
		this.m_g.Size = new Size(88, 32);
		this.m_g.TabIndex = 5;
		this.m_g.Text = "انصراف";
		this.m_g.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_g.Click += j;
		o.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		o.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		o.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		o.ImageIndex = 8;
		o.ImageSize = new Size(30, 30);
		o.Location = new Point(110, 125);
		o.Name = "btnAccept";
		o.Size = new Size(88, 32);
		o.TabIndex = 4;
		o.Text = "تائيد";
		o.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		o.Click += l;
		s.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		s.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		s.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		s.ImageIndex = 8;
		s.ImageSize = new Size(30, 30);
		s.Location = new Point(11, 512);
		s.Name = "uiButton1";
		s.Size = new Size(73, 40);
		s.TabIndex = 28;
		s.Text = "خروج";
		s.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		s.Click += g;
		r.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		r.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		r.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		r.ImageSize = new Size(30, 30);
		r.Location = new Point(92, 512);
		r.Name = "btnPrint";
		r.Size = new Size(73, 40);
		r.TabIndex = 27;
		r.Text = "چاپ";
		r.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		r.Click += h;
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
		this.m_c.Click += i;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.ImageIndex = 8;
		this.m_d.Location = new Point(349, 512);
		this.m_d.Name = "btnNew";
		this.m_d.Size = new Size(73, 40);
		this.m_d.TabIndex = 0;
		this.m_d.Text = "جديد";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += m;
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
		this.m_e.Click += k;
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
		this.m_h.Click += c;
		this.m_h.SelectionChanged += b;
		p.GridEX = this.m_h;
		p.PageFooterLeft = "3";
		p.PageFooterRight = "2";
		p.PageHeaderCenter = "1";
		p.PageHeaderLeft = "4";
		p.PageHeaderRight = "5";
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		q.ClientSize = new Size(400, 300);
		q.Document = p;
		q.Enabled = true;
		q.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		q.Name = "printPreviewDialog1";
		q.Visible = false;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = SystemColors.InactiveCaption;
		ClientSize = new Size(450, 583);
		ControlBox = false;
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmTeacher";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "اطلاعات معلمان";
		Load += n;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		((ISupportInitialize)this.m_h).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void n(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 1:
					flag = !(asdab.m == "3");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 9;
				case 4:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 3:
					ab.Text = "نام خانوادگي معلم :";
					this.m_j.Text = "نام خانوادگي معلم :";
					aa.Text = "نام معلم :";
					this.m_i.Text = "نام معلم :";
					x.Text = "کد معلم :";
					z.Text = "کد معلم به صورت اتوماتیک";
					num = 9;
					continue;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 10;
					continue;
				case 10:
					return;
				case 9:
					a();
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 8:
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
					num = 1;
					continue;
				case 7:
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		int num = ae;
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tteacher");
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

	private void m(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ad = 1;
		z.Visible = true;
		this.m_f.Visible = true;
		this.m_n.Text = "";
		this.m_m.Text = "";
        this.m_l.Text = "";
        w.Text = "";
		this.m_n.Focus();
	}

	private void l(object A_0, EventArgs A_1)
	{
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 26;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 26:
					num = (z.Checked ? 11 : 14);
					continue;
				case 25:
					if (!flag)
					{
						num = 24;
						continue;
					}
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tTeacher SET fNamF=@fNamF,fNamL=@fNamL,fEmail=@fEmail,fPassword=@fPassword,xExportRpt=null WHERE id=@id",
                        asdcb.a("@fNamF", SqlDbType.NVarChar, this.m_n.Text.Trim()),
                        asdcb.a("@fNamL", SqlDbType.NVarChar, this.m_m.Text.Trim()),
                        asdcb.a("@fEmail", SqlDbType.NVarChar, this.m_l.Text.Trim()),
                        asdcb.a("@fPassword", SqlDbType.NVarChar, w.Text.Trim()),
                        asdcb.a("@id", SqlDbType.Int, Convert.ToInt32(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value)));
					this.m_f.Visible = false;
					this.m_n.Text = "";
					this.m_m.Text = "";
					flag = !z.Checked;
					num = 2;
					continue;
				case 7:
					if (flag)
					{
						this.m_n.Text = OriginalText.Normalize(this.m_n.Text.Trim());
						this.m_m.Text = OriginalText.Normalize(this.m_m.Text.Trim());
						flag = ad != 1;
						num = 25;
					}
					else
					{
						num = 20;
					}
					continue;
				case 15:
					y.Text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,10000) from tTeacher").ToString();
					this.m_n.Focus();
					num = 21;
					continue;
				case 24:
					text = "";
					flag = !z.Checked;
					num = 10;
					continue;
				case 10:
					if (!flag)
					{
						num = 17;
						continue;
					}
					text = y.Text;
					flag = !("0" != asdcb.a(asdab.e(), CommandType.Text, "select count(id) from tTeacher where id=@id", asdcb.a("@id", SqlDbType.Int, int.Parse(text))).ToString());
					num = 19;
					continue;
				case 20:
					MessageBox.Show("نام خانوادگي را وارد کنيد");
					this.m_m.Focus();
					if (true)
					{
					}
					num = 5;
					continue;
				case 5:
					return;
				case 4:
					MessageBox.Show("کد معلم را وارد کنيد");
					y.Focus();
					num = 16;
					continue;
				case 16:
					return;
				case 9:
				case 27:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tTeacher (id,fNamF,fNamL,fEmail,fPassword) VALUES (@id,@fNamF,@fNamL,@fEmail,@fPassword)",
                        asdcb.a("@id", SqlDbType.Int, int.Parse(text)),
                        asdcb.a("@fNamF", SqlDbType.NVarChar, this.m_n.Text.Trim()),
                        asdcb.a("@fNamL", SqlDbType.NVarChar, this.m_m.Text.Trim()),
                        asdcb.a("@fEmail", SqlDbType.NVarChar, this.m_l.Text.Trim()),
                        asdcb.a("@fPassword", SqlDbType.NVarChar, w.Text.Trim()));
					this.m_n.Text = "";
					this.m_m.Text = "";
					y.Text = "";
					flag = !z.Checked;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 18;
						continue;
					}
					y.Focus();
					num = 0;
					continue;
				case 14:
					num = 12;
					continue;
				case 12:
					num2 = ((!(y.Text == "")) ? 1 : 0);
					goto IL_0456;
				case 19:
					num = ((!flag) ? 28 : 27);
					continue;
				case 28:
					MessageBox.Show("کد معلم تکراری میباشد");
					y.Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 3:
				case 21:
					num = 8;
					continue;
				case 23:
					if (flag)
					{
						flag = !(this.m_m.Text.Trim() == "");
						num = 7;
					}
					else
					{
						num = 4;
					}
					continue;
				case 11:
					num2 = 1;
					goto IL_0456;
				case 6:
				case 8:
					f(this, null);
					num = 29;
					continue;
				case 29:
					return;
				case 18:
					this.m_n.Focus();
					num = 22;
					continue;
				case 17:
					text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,10000) from tTeacher").ToString();
					num = 9;
					continue;
				case 2:
					if (flag)
					{
						y.Text = "";
						y.Focus();
						num = 3;
					}
					else
					{
						num = 15;
					}
					continue;
				case 0:
				case 22:
					{
						num = 6;
						continue;
					}
					IL_0456:
					flag = (byte)num2 != 0;
					num = 23;
					continue;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
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
					if (this.m_h.RowCount > 0)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 1;
					}
					continue;
				case 4:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_h.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_013b;
				case 6:
					z.Visible = false;
					z.Checked = true;
					ad = 2;
					this.m_n.Text = this.m_h.SelectedItems[0].GetRow().Cells["fNamF"].Value.ToString();
					this.m_m.Text = this.m_h.SelectedItems[0].GetRow().Cells["fNamL"].Value.ToString();
                    var teacher = asdcb.c(asdab.e(), CommandType.Text, "SELECT fEmail,fPassword FROM tTeacher WHERE id=@id",
                        asdcb.a("@id", SqlDbType.Int, Convert.ToInt32(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value))).Rows[0];
                    this.m_l.Text = Convert.ToString(teacher["fEmail"]);
                    w.Text = Convert.ToString(teacher["fPassword"]);
					this.m_f.Visible = true;
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 1:
					{
						num2 = 1;
						goto IL_013b;
					}
					IL_013b:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		this.m_f.Visible = false;
	}

	private void i(object A_0, EventArgs A_1)
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
					num = ((this.m_h.RowCount >= 1) ? 1 : 7);
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tTeacher where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 6;
					continue;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					MessageBox.Show("برای این معلم صنف تعریف شده است .حذف امکان پذیر نیست");
					num = 8;
					continue;
				case 7:
					num2 = 0;
					goto IL_0229;
				case 6:
					num = 12;
					continue;
				case 12:
					return;
				case 1:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_h.SelectedItems[0].RowType == RowType.Record) ? 1 : 0);
					goto IL_0229;
				case 9:
					flag = MessageBox.Show("آيا از حذف معلم مطمئن هستيد؟", "حذف معلم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
					if (true)
					{
					}
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 8:
					return;
				case 10:
					MessageBox.Show("معلمی انتخاب نشده است");
					num = 4;
					continue;
				case 4:
					return;
				case 13:
					{
						if (flag)
						{
							string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(xCls) FROM   tTch_Cls WHERE     (xTch = " + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")").ToString();
							flag = !(text == "0");
							num = 3;
						}
						else
						{
							num = 10;
						}
						continue;
					}
					IL_0229:
					flag = (byte)num2 != 0;
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		Rectangle bounds = Bounds;
		q.SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
		q.UseAntiAlias = true;
		q.ShowDialog(this);
	}

	private void g(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = ae;
			string text = "";
			bool flag = !(u.Text.Trim() != "");
			int num2 = 21;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 21:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 3;
				case 25:
					this.m_h.Focus();
					this.m_h.Row = num;
					num2 = 22;
					continue;
				case 17:
					num2 = 5;
					continue;
				case 5:
					num3 = ((this.m_h.RecordCount <= num) ? 1 : 0);
					goto IL_01c1;
				case 3:
					flag = !(t.Text.Trim() != "");
					num2 = 12;
					continue;
				case 12:
					if (!flag)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 28:
					num2 = 27;
					continue;
				case 27:
					num4 = ((this.m_h.RecordCount != num) ? 1 : 0);
					goto IL_01e9;
				case 18:
					text = text + "tTeacher.fNamF like @FirstName";
					num2 = 3;
					continue;
				case 11:
					num2 = (flag ? 13 : 25);
					continue;
				case 19:
					if (!flag)
					{
						num2 = 24;
						continue;
					}
					goto case 14;
				case 20:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tteacher" + text, new SqlParameter("@FirstName", "%"+OriginalText.Normalize(u.Text.Trim())+"%"), new SqlParameter("@LastName", "%"+OriginalText.Normalize(t.Text.Trim())+"%"));
					this.m_h.DataSource = dataSource;
					num2 = 26;
					continue;
				}
				case 26:
					num2 = ((ad != 2) ? 23 : 17);
					continue;
				case 7:
					flag = !(text != "");
					num2 = 9;
					continue;
				case 9:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 8:
					num4 = 1;
					goto IL_01e9;
				case 24:
					this.m_h.Focus();
					this.m_h.Row = num - 1;
					num2 = 14;
					continue;
				case 2:
					text = text + "tTeacher.fNamL like @LastName";
					num2 = 1;
					continue;
				case 16:
					flag = !(text != "");
					num2 = 10;
					continue;
				case 10:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					goto case 18;
				case 4:
					text += " and ";
					num2 = 2;
					continue;
				case 0:
					text += " and ";
					num2 = 18;
					continue;
				case 1:
					if (true)
					{
					}
					flag = !(text != "");
					num2 = 6;
					continue;
				case 6:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					goto case 20;
				case 13:
					num2 = ((ad == 2) ? 28 : 8);
					continue;
				case 23:
					num3 = 1;
					goto IL_01c1;
				case 15:
					text = " where " + text;
					num2 = 20;
					continue;
				case 14:
				case 22:
					{
						ad = 1;
						return;
					}
					IL_01e9:
					flag = (byte)num4 != 0;
					num2 = 19;
					continue;
					IL_01c1:
					flag = (byte)num3 != 0;
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		f(this, null);
	}

	private void d(object A_0, EventArgs A_1)
	{
		f(this, null);
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		try
		{
			while (true)
			{
				bool flag = this.m_h.SelectedItems[0].RowType == RowType.FilterRow;
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
						goto case 0;
					case 2:
						this.m_c.Enabled = true;
						this.m_e.Enabled = true;
						num = 0;
						continue;
					case 0:
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

	private void b(object A_0, EventArgs A_1)
	{
		ae = this.m_h.Row;
        bool selected=this.m_h.SelectedItems.Count>0 && this.m_h.SelectedItems[0].RowType==RowType.Record;
        this.m_c.Enabled=selected;
        this.m_e.Enabled=selected;
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		y.Visible = !z.Checked;
		x.Visible = !z.Checked;
	}
}
