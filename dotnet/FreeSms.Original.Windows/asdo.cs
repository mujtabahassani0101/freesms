using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdo : Form
{
	private Panel m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private Label m_e;

	private GridEX m_f;

	private Panel m_g;

	private UIButton m_h;

	private UIButton m_i;

	private UIButton m_j;

	private EditBox m_k;

	private GridEX m_l;

	private UIButton m_m;

	private UIButton n;

	private UIButton o;

	private UIButton p;

	private UIButton q;

	private Label r;

	private Label s;

	private UIComboBox t;

	private EditBox u;

	private Panel v;

	private UIButton w;

	private Container x = null;

	private int y;

	private int z;

	public asdo()
	{
		c();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 3:
					num = 4;
					continue;
				case 0:
					x.Dispose();
					num = 3;
					continue;
				case 1:
					flag = x == null;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdo));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		this.m_f = new GridEX();
		this.m_a = new Panel();
		this.m_b = new Panel();
		w = new UIButton();
		v = new Panel();
		t = new UIComboBox();
		s = new Label();
		p = new UIButton();
		q = new UIButton();
		u = new EditBox();
		r = new Label();
		this.m_m = new UIButton();
		n = new UIButton();
		o = new UIButton();
		this.m_g = new Panel();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_k = new EditBox();
		this.m_e = new Label();
		this.m_l = new GridEX();
		this.m_h = new UIButton();
		this.m_i = new UIButton();
		this.m_j = new UIButton();
		((ISupportInitialize)this.m_f).BeginInit();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		v.SuspendLayout();
		this.m_g.SuspendLayout();
		((ISupportInitialize)this.m_l).BeginInit();
		SuspendLayout();
		this.m_f.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.CardCaptionPrefix = "Product:";
		this.m_f.ColumnAutoResize = true;
		this.m_f.Cursor = Cursors.Default;
		this.m_f.DataMember = null;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_f.DesignTimeLayout = gridEXLayout;
		this.m_f.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_f.FlatBorderColor = SystemColors.ControlDark;
		this.m_f.Font = new Font("Tahoma", 8.25f);
		this.m_f.GridLineColor = SystemColors.ScrollBar;
		this.m_f.GroupByBoxVisible = false;
		this.m_f.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_f.Location = new Point(297, 8);
		this.m_f.Name = "gOst";
		this.m_f.RightToLeft = RightToLeft.Yes;
		this.m_f.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_f.SelectedFormatStyle.Blend = 0.5f;
		this.m_f.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_f.Size = new Size(231, 368);
		this.m_f.TabIndex = 15;
		this.m_f.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_f.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_f.SelectionChanged += e;
		this.m_a.BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(5, 4);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(563, 497);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(v);
		this.m_b.Controls.Add(this.m_m);
		this.m_b.Controls.Add(n);
		this.m_b.Controls.Add(o);
		this.m_b.Controls.Add(this.m_g);
		this.m_b.Controls.Add(this.m_l);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Controls.Add(this.m_i);
		this.m_b.Controls.Add(this.m_j);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Location = new Point(5, 5);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(551, 484);
		this.m_b.TabIndex = 16;
		w.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		w.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		w.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		w.ImageIndex = 8;
		w.ImageSize = new Size(50, 50);
		w.Location = new Point(26, 429);
		w.Name = "uiButton2";
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(499, 45);
		w.TabIndex = 44;
		w.Text = "خروج";
		w.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		w.Click += c;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		v.Controls.Add(t);
		v.Controls.Add(s);
		v.Controls.Add(p);
		v.Controls.Add(q);
		v.Controls.Add(u);
		v.Controls.Add(r);
		v.Location = new Point(12, 168);
		v.Name = "PCty";
		v.Size = new Size(288, 120);
		v.TabIndex = 42;
		v.Visible = false;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.BorderStyle = Janus.Windows.UI.BorderStyle.RaisedLight3D;
		t.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		t.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.Location = new Point(8, 8);
		t.Name = "comboOst_Cty";
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(184, 24);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		t.StringFormat = stringFormat;
		t.TabIndex = 30;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Location = new Point(200, 8);
		s.Name = "label2";
		s.RightToLeft = RightToLeft.Yes;
		s.Size = new Size(80, 21);
		s.TabIndex = 29;
		s.Text = "نام ولایت :";
		s.TextAlign = ContentAlignment.MiddleRight;
		p.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		p.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		p.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		p.Image = (Image)componentResourceManager.GetObject("btnCancelCty.Image");
		p.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		p.ImageIndex = 8;
		p.Location = new Point(40, 80);
		p.Name = "btnCancelCty";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(64, 24);
		p.TabIndex = 28;
		p.Text = "انصراف";
		p.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		p.Click += g;
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		q.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		q.Image = (Image)componentResourceManager.GetObject("btnAcpCty.Image");
		q.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		q.ImageIndex = 8;
		q.Location = new Point(120, 80);
		q.Name = "btnAcpCty";
		q.RightToLeft = RightToLeft.Yes;
		q.Size = new Size(64, 24);
		q.TabIndex = 27;
		q.Text = "تائيد";
		q.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		q.Click += d;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		u.Location = new Point(8, 48);
		u.Name = "txtCty";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(184, 21);
		u.TabIndex = 23;
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		u.KeyDown += a;
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Location = new Point(200, 48);
		r.Name = "label1";
		r.RightToLeft = RightToLeft.Yes;
		r.Size = new Size(80, 21);
		r.TabIndex = 22;
		r.Text = "نام ولسوالی:";
		r.TextAlign = ContentAlignment.MiddleRight;
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_m.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnDeleteCty.Image");
		this.m_m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_m.ImageIndex = 8;
		this.m_m.Location = new Point(29, 384);
		this.m_m.Name = "btnDeleteCty";
		this.m_m.RightToLeft = RightToLeft.Yes;
		this.m_m.Size = new Size(64, 32);
		this.m_m.TabIndex = 37;
		this.m_m.Text = "حذف";
		this.m_m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_m.Click += a;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		n.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Image = (Image)componentResourceManager.GetObject("btnNewCty.Image");
		n.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		n.ImageIndex = 8;
		n.Location = new Point(208, 384);
		n.Name = "btnNewCty";
		n.RightToLeft = RightToLeft.Yes;
		n.Size = new Size(68, 32);
		n.TabIndex = 35;
		n.Text = "جديد";
		n.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		n.Click += h;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		o.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		o.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Image = (Image)componentResourceManager.GetObject("btnEditCty.Image");
		o.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		o.ImageIndex = 8;
		o.Location = new Point(111, 384);
		o.Name = "btnEditCty";
		o.RightToLeft = RightToLeft.Yes;
		o.Size = new Size(74, 32);
		o.TabIndex = 36;
		o.Text = "اصلاح";
		o.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		o.Click += f;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_g.Controls.Add(this.m_c);
		this.m_g.Controls.Add(this.m_d);
		this.m_g.Controls.Add(this.m_k);
		this.m_g.Controls.Add(this.m_e);
		this.m_g.Location = new Point(272, 192);
		this.m_g.Name = "POst";
		this.m_g.Size = new Size(272, 80);
		this.m_g.TabIndex = 30;
		this.m_g.Visible = false;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_c.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_c.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnCancelOst.Image");
		this.m_c.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_c.ImageIndex = 8;
		this.m_c.Location = new Point(24, 48);
		this.m_c.Name = "btnCancelOst";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(64, 24);
		this.m_c.TabIndex = 28;
		this.m_c.Text = "انصراف";
		this.m_c.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_c.Click += k;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnAcpOst.Image");
		this.m_d.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_d.ImageIndex = 8;
		this.m_d.Location = new Point(104, 48);
		this.m_d.Name = "btnAcpOst";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.Size = new Size(64, 24);
		this.m_d.TabIndex = 27;
		this.m_d.Text = "تائيد";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += j;
		this.m_k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_k.AutoScroll = false;
		this.m_k.AutoScrollMargin = new Size(0, 0);
		this.m_k.AutoScrollMinSize = new Size(0, 0);
		this.m_k.AutoScrollPosition = new Point(0, 0);
		this.m_k.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_k.Location = new Point(8, 16);
		this.m_k.Name = "txtOst";
		this.m_k.RightToLeft = RightToLeft.Yes;
		this.m_k.Size = new Size(165, 21);
		this.m_k.TabIndex = 23;
		this.m_k.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_k.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_k.KeyDown += b;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_e.Location = new Point(176, 16);
		this.m_e.Name = "L_Type";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(80, 21);
		this.m_e.TabIndex = 22;
		this.m_e.Text = "نام ولایت :";
		this.m_e.TextAlign = ContentAlignment.MiddleRight;
		this.m_l.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.CardCaptionPrefix = "Product:";
		this.m_l.ColumnAutoResize = true;
		this.m_l.Cursor = Cursors.Default;
		this.m_l.DataMember = null;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		this.m_l.DesignTimeLayout = gridEXLayout2;
		this.m_l.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_l.FlatBorderColor = SystemColors.ControlDark;
		this.m_l.Font = new Font("Tahoma", 8.25f);
		this.m_l.GridLineColor = SystemColors.ScrollBar;
		this.m_l.GroupByBoxVisible = false;
		this.m_l.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_l.Location = new Point(29, 8);
		this.m_l.Name = "gCty";
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_l.SelectedFormatStyle.Blend = 0.5f;
		this.m_l.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_l.Size = new Size(246, 368);
		this.m_l.TabIndex = 34;
		this.m_l.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_l.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_l.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_l.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_l.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_l.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_l.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_l.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_h.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_h.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_h.ImageIndex = 8;
		this.m_h.Location = new Point(297, 384);
		this.m_h.Name = "btnDelete";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(64, 32);
		this.m_h.TabIndex = 33;
		this.m_h.Text = "حذف";
		this.m_h.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_h.Click += b;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_i.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_i.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_i.ImageIndex = 8;
		this.m_i.Location = new Point(464, 384);
		this.m_i.Name = "btnNew";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(64, 32);
		this.m_i.TabIndex = 31;
		this.m_i.Text = "جديد";
		this.m_i.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_i.Click += l;
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_j.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_j.ImageIndex = 8;
		this.m_j.Location = new Point(380, 384);
		this.m_j.Name = "btnEdit";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(64, 32);
		this.m_j.TabIndex = 32;
		this.m_j.Text = "اصلاح";
		this.m_j.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_j.Click += i;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.CornflowerBlue;
		ClientSize = new Size(573, 506);
		Controls.Add(this.m_a);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmOst";
		StartPosition = FormStartPosition.CenterScreen;
		Text = " ولایت-ولسوالی";
		Load += m;
		((ISupportInitialize)this.m_f).EndInit();
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		v.ResumeLayout(performLayout: false);
		this.m_g.ResumeLayout(performLayout: false);
		((ISupportInitialize)this.m_l).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tostan");
		this.m_f.DataSource = dataSource;
		t.DataSource = null;
		t.Items.Clear();
		t.Text = "";
		t.DataSource = dataSource;
		t.ValueMember = "id";
		t.DisplayMember = "name";
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tCity where xOstan=" + this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
		this.m_l.DataSource = dataSource;
	}

	private void m(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 6;
				case 0:
					a();
					num = 3;
					continue;
				case 3:
					return;
				case 4:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 9;
					continue;
				case 9:
					return;
				case 6:
					if (true)
					{
					}
					b();
					flag = this.m_f.RecordCount <= 0;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 7:
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
					num = 6;
					continue;
				case 8:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		y = 1;
		this.m_k.Text = "";
		this.m_g.Visible = true;
		this.m_k.Focus();
	}

	private void k(object A_0, EventArgs A_1)
	{
		this.m_g.Visible = false;
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			this.m_k.Text = asdaj.b(this.m_k.Text);
			bool flag = !(this.m_k.Text == "");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = y != 1;
					num = 6;
					continue;
				case 1:
					if (true)
					{
					}
					MessageBox.Show("نام ولایت را وارد کنيد");
					this.m_k.Focus();
					num = 2;
					continue;
				case 4:
				{
					string text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,10) from tOstan").ToString();
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tOstan (id,Name)VALUES(" + text + ", N'" + this.m_k.Text.Trim() + "')");
					this.m_k.Text = "";
					this.m_k.Focus();
					num = 0;
					continue;
				}
				case 2:
					return;
				case 0:
				case 7:
					b();
					num = 5;
					continue;
				case 5:
					return;
				case 6:
					if (flag)
					{
						asdcb.d(asdab.e(), CommandType.Text, "update tOstan set Name=N'" + this.m_k.Text.Trim() + "' where id=" + this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						this.m_g.Visible = false;
						num = 7;
					}
					else
					{
						num = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_f.RecordCount <= 0;
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
					if (true)
					{
					}
					y = 2;
					this.m_k.Text = this.m_f.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
					this.m_g.Visible = true;
					v.Visible = false;
					this.m_k.Focus();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_f.RecordCount <= 0;
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
					MessageBox.Show("ابتدا ولایت را تعريف کنيد");
					num = 2;
					continue;
				case 2:
					return;
				case 0:
					z = 1;
					u.Text = "";
					t.SelectedValue = this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					v.Visible = true;
					this.m_g.Visible = false;
					u.Focus();
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		v.Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_l.RecordCount <= 0;
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
					z = 2;
					t.SelectedValue = this.m_l.SelectedItems[0].GetRow().Cells["xOstan"].Value.ToString();
					u.Text = this.m_l.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
					v.Visible = true;
					this.m_g.Visible = false;
					u.Focus();
					if (true)
					{
					}
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		try
		{
			while (true)
			{
				bool flag = this.m_f.SelectedItems[0].RowType == RowType.FilterRow;
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
						goto case 2;
					case 3:
						a();
						num = 2;
						continue;
					case 2:
						num = 1;
						continue;
					case 1:
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

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			u.Text = asdaj.b(u.Text);
			bool flag = !(u.Text == "");
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
					flag = z != 1;
					num = 6;
					continue;
				case 1:
					if (true)
					{
					}
					MessageBox.Show("نام ولسوالی را وارد کنيد");
					u.Focus();
					num = 2;
					continue;
				case 4:
				{
					string text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,100) from tCity").ToString();
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tCity (id,Name,xOstan)VALUES(" + text + ", N'" + u.Text.Trim() + "'," + t.SelectedValue.ToString() + ")");
					u.Text = "";
					u.Focus();
					a();
					num = 5;
					continue;
				}
				case 5:
					return;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					asdcb.d(asdab.e(), CommandType.Text, "update tCity set Name=N'" + u.Text.Trim() + "',xOstan=" + t.SelectedValue.ToString() + " where id=" + this.m_l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					v.Visible = false;
					a();
					num = 3;
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_f.RecordCount <= 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 5:
					return;
				case 3:
					MessageBox.Show("برای این ولایت ، ولسوالی تعریف شده است.ابتدا باید ولسوالی را حذف کنید");
					num = 2;
					continue;
				case 2:
					return;
				case 1:
				{
					int num2 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "select count(id) from tCity where xOstan=" + this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString());
					flag = num2 <= 0;
					num = 0;
					continue;
				}
				case 0:
					if (flag)
					{
						asdcb.d(asdab.e(), CommandType.Text, "delete from tOstan where id=" + this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						b();
						num = 5;
					}
					else
					{
						num = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_l.RecordCount <= 0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					MessageBox.Show("برای این ولسوالی ، شاگرد تعریف شده است.و قابل حذف نیست");
					num = 1;
					continue;
				case 1:
					return;
				case 5:
				{
					int num2 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "select count(id) from tStudent where xCity=" + this.m_l.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString());
					flag = num2 <= 0;
					num = 4;
					continue;
				}
				case 4:
					if (flag)
					{
						asdcb.d(asdab.e(), CommandType.Text, "delete from tCity where id=" + this.m_l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						a();
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Return;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					j(this, null);
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Return;
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
					d(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}
}
