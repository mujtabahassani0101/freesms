using Microsoft.Data.SqlClient;
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

public class asdca : Form
{
	private Container m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Label m_d;

	private Panel m_e;

	private Label m_f;

	private UIComboBox m_g;

	private Label m_h;

	private EditBox m_i;

	private UIButton j;

	private Panel k;

	private Label l;

	private Label m;

	private UIComboBox n;

	private UIRadioButton o;

	private UIRadioButton p;

	private Label q;

	private UIButton r;

	private UIButton s;

	private EditBox t;

	private Label u;

	private UIButton v;

	private UIButton w;

	private UIButton x;

	private GridEX y;

	private MaskedEditBox z;

	private Label aa;

	private Label ab;

	private NumericEditBox ac;

	private NumericEditBox ad;

	private MaskedEditBox ae;

	private Label af;

	private CheckBox ag;

	private int ah;

	public asdca()
	{
		f();
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
						num = 2;
						continue;
					}
					goto case 4;
				case 1:
					num = 4;
					continue;
				case 3:
					this.m_a.Dispose();
					num = 1;
					continue;
				case 2:
					flag = this.m_a == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
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

	private void f()
	{
		if (true)
		{
		}
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdca));
		StringFormat stringFormat2 = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_e = new Panel();
		this.m_d = new Label();
		this.m_f = new Label();
		this.m_g = new UIComboBox();
		this.m_h = new Label();
		this.m_i = new EditBox();
		j = new UIButton();
		k = new Panel();
		ag = new CheckBox();
		ae = new MaskedEditBox();
		af = new Label();
		ac = new NumericEditBox();
		z = new MaskedEditBox();
		aa = new Label();
		ad = new NumericEditBox();
		m = new Label();
		ab = new Label();
		n = new UIComboBox();
		o = new UIRadioButton();
		p = new UIRadioButton();
		l = new Label();
		q = new Label();
		r = new UIButton();
		s = new UIButton();
		t = new EditBox();
		u = new Label();
		v = new UIButton();
		w = new UIButton();
		x = new UIButton();
		y = new GridEX();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_e.SuspendLayout();
		k.SuspendLayout();
		((ISupportInitialize)y).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.Black;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel3";
		this.m_b.Size = new Size(550, 585);
		this.m_b.TabIndex = 17;
		this.m_c.BackColor = Color.SkyBlue;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(this.m_e);
		this.m_c.Location = new Point(4, 6);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(542, 573);
		this.m_c.TabIndex = 17;
		this.m_e.BackColor = Color.FromArgb(214, 223, 247);
		this.m_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_e.Controls.Add(this.m_d);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Controls.Add(this.m_g);
		this.m_e.Controls.Add(this.m_h);
		this.m_e.Controls.Add(this.m_i);
		this.m_e.Controls.Add(j);
		this.m_e.Controls.Add(k);
		this.m_e.Controls.Add(v);
		this.m_e.Controls.Add(w);
		this.m_e.Controls.Add(x);
		this.m_e.Controls.Add(y);
		this.m_e.Dock = DockStyle.Bottom;
		this.m_e.Location = new Point(0, -1);
		this.m_e.Name = "panel2";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(540, 572);
		this.m_e.TabIndex = 16;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.AutoSize = true;
		this.m_d.Font = new Font("B Nazanin", 16f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(215, 5);
		this.m_d.Name = "label5";
		this.m_d.Size = new Size(112, 35);
		this.m_d.TabIndex = 49;
		this.m_d.Text = "لیست دروس";
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.AutoSize = true;
		this.m_f.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(218, 58);
		this.m_f.Name = "label4";
		this.m_f.Size = new Size(40, 26);
		this.m_f.TabIndex = 48;
		this.m_f.Text = "نوع  :";
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_g.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(21, 54);
		this.m_g.Name = "dropPayeSeacrch";
		this.m_g.Size = new Size(191, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_g.StringFormat = stringFormat;
		this.m_g.TabIndex = 47;
		this.m_g.SelectedIndexChanged += b;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(471, 58);
		this.m_h.Name = "label2";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(74, 26);
		this.m_h.TabIndex = 46;
		this.m_h.Text = "نام درس :";
		this.m_h.TextAlign = ContentAlignment.MiddleRight;
		this.m_i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_i.AutoScroll = false;
		this.m_i.AutoScrollMargin = new Size(0, 0);
		this.m_i.AutoScrollMinSize = new Size(0, 0);
		this.m_i.AutoScrollPosition = new Point(0, 0);
		this.m_i.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(301, 53);
		this.m_i.Name = "txtNameSearch";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(164, 33);
		this.m_i.TabIndex = 45;
		this.m_i.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_i.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_i.KeyUp += a;
		j.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		j.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		j.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		j.ImageIndex = 8;
		j.ImageSize = new Size(40, 40);
		j.Location = new Point(6, 531);
		j.Name = "uiButton2";
		j.RightToLeft = RightToLeft.Yes;
		j.Size = new Size(107, 32);
		j.TabIndex = 44;
		j.Text = "خروج";
		j.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		j.Click += g;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Controls.Add(ag);
		k.Controls.Add(ae);
		k.Controls.Add(af);
		k.Controls.Add(ac);
		k.Controls.Add(z);
		k.Controls.Add(aa);
		k.Controls.Add(ad);
		k.Controls.Add(m);
		k.Controls.Add(ab);
		k.Controls.Add(n);
		k.Controls.Add(o);
		k.Controls.Add(p);
		k.Controls.Add(l);
		k.Controls.Add(q);
		k.Controls.Add(r);
		k.Controls.Add(s);
		k.Controls.Add(t);
		k.Controls.Add(u);
		k.Location = new Point(43, 203);
		k.Name = "POst";
		k.RightToLeft = RightToLeft.Yes;
		k.Size = new Size(388, 225);
		k.TabIndex = 30;
		k.Visible = false;
		ag.AutoSize = true;
		ag.Checked = true;
		ag.CheckState = CheckState.Checked;
		ag.Location = new Point(225, 82);
		ag.Name = "checkVezarat";
		ag.Size = new Size(54, 28);
		ag.TabIndex = 2;
		ag.Text = "نتایج";
		ag.UseVisualStyleBackColor = true;
		ae.AutoScroll = false;
		ae.AutoScrollMargin = new Size(0, 0);
		ae.AutoScrollMinSize = new Size(0, 0);
		ae.AutoScrollPosition = new Point(0, 0);
		ae.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ae.Location = new Point(21, 116);
		ae.Name = "txtCodeDars";
		ae.Numeric = true;
		ae.Size = new Size(62, 33);
		ae.TabIndex = 4;
		ae.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		af.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		af.Location = new Point(86, 116);
		af.Name = "label3";
		af.RightToLeft = RightToLeft.Yes;
		af.Size = new Size(69, 31);
		af.TabIndex = 38;
		af.Text = "کد درس :";
		af.TextAlign = ContentAlignment.MiddleRight;
		ac.AutoScroll = false;
		ac.AutoScrollMargin = new Size(0, 0);
		ac.AutoScrollMinSize = new Size(0, 0);
		ac.AutoScrollPosition = new Point(0, 0);
		ac.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ac.Location = new Point(204, 267);
		ac.Name = "txttimeWeek";
		ac.Size = new Size(62, 33);
		ac.TabIndex = 2;
		ac.Text = "1.00";
		ac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ac.Value = new decimal(new int[4] { 100, 0, 0, 131072 });
		ac.Visible = false;
		z.AutoScroll = false;
		z.AutoScrollMargin = new Size(0, 0);
		z.AutoScrollMinSize = new Size(0, 0);
		z.AutoScrollPosition = new Point(0, 0);
		z.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		z.Location = new Point(218, 116);
		z.Name = "txtSort";
		z.Numeric = true;
		z.Size = new Size(62, 33);
		z.TabIndex = 3;
		z.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		aa.Font = new Font("B Nazanin", 10f, FontStyle.Bold, GraphicsUnit.Point, 178);
		aa.Location = new Point(285, 119);
		aa.Name = "label6";
		aa.RightToLeft = RightToLeft.Yes;
		aa.Size = new Size(71, 27);
		aa.TabIndex = 33;
		aa.Text = "ترتیب:";
		aa.TextAlign = ContentAlignment.MiddleRight;
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ad.Location = new Point(43, 267);
		ad.Name = "txtVahed";
		ad.Size = new Size(62, 33);
		ad.TabIndex = 4;
		ad.Text = "1.00";
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ad.Value = new decimal(new int[4] { 100, 0, 0, 131072 });
		ad.Visible = false;
		m.Anchor = AnchorStyles.Top;
		m.AutoSize = true;
		m.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Location = new Point(286, 9);
		m.Name = "label20";
		m.Size = new Size(37, 26);
		m.TabIndex = 31;
		m.Text = "نوع :";
		ab.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ab.Location = new Point(269, 269);
		ab.Name = "ltimeWeek";
		ab.RightToLeft = RightToLeft.Yes;
		ab.Size = new Size(115, 29);
		ab.TabIndex = 35;
		ab.Text = "ساعات هفتگی :";
		ab.TextAlign = ContentAlignment.MiddleRight;
		ab.Visible = false;
		n.Anchor = AnchorStyles.Top;
		n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		n.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(21, 6);
		n.Name = "dropPaye";
		n.Size = new Size(259, 33);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		n.StringFormat = stringFormat2;
		n.TabIndex = 0;
		n.SelectedIndexChanged += a;
		o.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(72, 269);
		o.Name = "rEkhtesasi";
		o.RightToLeft = RightToLeft.Yes;
		o.Size = new Size(79, 23);
		o.TabIndex = 6;
		o.Text = "اختصاصی";
		o.Visible = false;
		p.Checked = true;
		p.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Location = new Point(162, 268);
		p.Name = "rOmomi";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(69, 23);
		p.TabIndex = 5;
		p.TabStop = true;
		p.Text = "عمومی";
		p.Visible = false;
		l.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		l.Location = new Point(113, 267);
		l.Name = "lvahed";
		l.RightToLeft = RightToLeft.Yes;
		l.Size = new Size(85, 32);
		l.TabIndex = 32;
		l.Text = "تعداد واحد :";
		l.TextAlign = ContentAlignment.MiddleRight;
		l.Visible = false;
		q.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Location = new Point(285, 46);
		q.Name = "label1";
		q.RightToLeft = RightToLeft.Yes;
		q.Size = new Size(98, 28);
		q.TabIndex = 29;
		q.Text = "عنوان درس :";
		q.TextAlign = ContentAlignment.MiddleRight;
		r.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		r.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		r.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		r.ImageIndex = 8;
		r.Location = new Point(54, 167);
		r.Name = "btnCancel";
		r.RightToLeft = RightToLeft.Yes;
		r.Size = new Size(97, 42);
		r.TabIndex = 6;
		r.Text = "انصراف";
		r.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		r.Click += d;
		s.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		s.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		s.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		s.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		s.ImageIndex = 8;
		s.Location = new Point(157, 167);
		s.Name = "btnAcp";
		s.RightToLeft = RightToLeft.Yes;
		s.Size = new Size(101, 42);
		s.TabIndex = 5;
		s.Text = "تائيد";
		s.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		s.Click += e;
		t.AutoScroll = false;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.AutoScrollPosition = new Point(0, 0);
		t.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		t.Location = new Point(21, 45);
		t.Name = "txtBook";
		t.RightToLeft = RightToLeft.Yes;
		t.Size = new Size(259, 33);
		t.TabIndex = 1;
		t.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		t.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		u.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		u.Location = new Point(237, 264);
		u.Name = "L_Type";
		u.RightToLeft = RightToLeft.Yes;
		u.Size = new Size(88, 29);
		u.TabIndex = 22;
		u.Text = "نوع درس :";
		u.TextAlign = ContentAlignment.MiddleRight;
		u.Visible = false;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		v.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		v.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		v.ImageIndex = 8;
		v.Location = new Point(188, 531);
		v.Name = "btnDelete";
		v.RightToLeft = RightToLeft.Yes;
		v.Size = new Size(107, 32);
		v.TabIndex = 33;
		v.Text = "حذف";
		v.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		v.Click += c;
		w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		w.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		w.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		w.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		w.ImageIndex = 8;
		w.Location = new Point(415, 531);
		w.Name = "btnNew";
		w.RightToLeft = RightToLeft.Yes;
		w.Size = new Size(107, 32);
		w.TabIndex = 31;
		w.Text = "جديد";
		w.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		w.Click += i;
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		x.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		x.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		x.ImageIndex = 8;
		x.Location = new Point(301, 531);
		x.Name = "btnEdit";
		x.RightToLeft = RightToLeft.Yes;
		x.Size = new Size(107, 32);
		x.TabIndex = 32;
		x.Text = "اصلاح";
		x.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		x.Click += f;
		y.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		y.CardCaptionPrefix = "Product:";
		y.Cursor = Cursors.Default;
		y.DataMember = null;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		y.DesignTimeLayout = gridEXLayout;
		y.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		y.FlatBorderColor = SystemColors.ControlDark;
		y.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		y.GridLineColor = SystemColors.ScrollBar;
		y.GroupByBoxVisible = false;
		y.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		y.Location = new Point(11, 91);
		y.Name = "gBook";
		y.RightToLeft = RightToLeft.Yes;
		y.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		y.SelectedFormatStyle.Blend = 0.5f;
		y.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		y.Size = new Size(518, 424);
		y.TabIndex = 15;
		y.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		y.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		y.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		y.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		y.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		y.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		y.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		y.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		AcceptButton = s;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = Color.CornflowerBlue;
		ClientSize = new Size(550, 585);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmbook";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست دروس";
		Load += h;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_e.ResumeLayout(performLayout: false);
		this.m_e.PerformLayout();
		k.ResumeLayout(performLayout: false);
		k.PerformLayout();
		((ISupportInitialize)y).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		n.Enabled = true;
		ah = 1;
		t.Text = "";
		k.Visible = true;
		e();
		d();
		n.Focus();
	}

	private void e()
	{
		while (true)
		{
			bool flag = n.SelectedIndex < 0;
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
					z.Text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(sort),0)+1 as sort from tbook where xpaye=" + n.SelectedValue).ToString();
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		if (true)
		{
		}
		ae.Text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(codedars),0)+1 as id from tbook").ToString();
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
		n.DataSource = dataSource;
		n.DisplayMember = "Name";
		n.ValueMember = "id";
	}

	private void b()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			int num = 0;
			if (true)
			{
			}
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					flag = num < dataTable.Rows.Count;
					num2 = 3;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					this.m_g.Items.Add(dataTable.Rows[num]["name"].ToString(), dataTable.Rows[num]["id"].ToString());
					num++;
					num2 = 2;
					continue;
				case 1:
					this.m_g.Items.Add("", "0");
					this.m_g.SelectedIndex = 0;
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			string text = "";
			bool flag = !(this.m_i.Text != "");
			int num = 10;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 4;
				case 13:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 4:
					num = 9;
					continue;
				case 9:
					num = ((this.m_g.SelectedIndex < 0) ? 18 : 3);
					continue;
				case 5:
					text = " tbook.name like @SearchName";
					num = 4;
					continue;
				case 3:
					num = 17;
					continue;
				case 17:
					num2 = ((!(this.m_g.SelectedValue.ToString() != "0")) ? 1 : 0);
					goto IL_01a4;
				case 12:
					text = " where " + text;
					num = 0;
					continue;
				case 14:
					text += "  tbook.xPaye=@SearchGrade";
					num = 7;
					continue;
				case 6:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 7;
				case 15:
					if (true)
					{
					}
					flag = !(text != "");
					num = 11;
					continue;
				case 18:
					num2 = 1;
					goto IL_01a4;
				case 1:
					text += " and ";
					num = 14;
					continue;
				case 2:
					text += " and ";
					num = 5;
					continue;
				case 11:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 14;
				case 7:
					flag = !(text != "");
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 0;
				case 0:
					{
						DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tbook.id,tbook.CodeDars,tbook.Vezarat,  tbook.sort,tbook.Type, tbook.Name,tbook.xpaye,tbook.vahed,tbook.timeWeek,tpaye.name as paye  FROM tBook inner join tpaye on tbook.xpaye=tpaye.id" + text + " order by tbook.sort", new SqlParameter("@SearchName", "%"+asdaj.b(this.m_i.Text)+"%"), new SqlParameter("@SearchGrade", this.m_g.SelectedValue??"0"));
						y.DataSource = dataSource;
						return;
					}
					IL_01a4:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 11;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 10:
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					goto case 6;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 11:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 8;
					continue;
				case 8:
					return;
				case 2:
					flag = !(asdab.m != "2");
					num = 9;
					continue;
				case 9:
					if (flag)
					{
						ad.Text = "1";
						ac.Text = "1";
						p.Checked = true;
						num = 6;
					}
					else
					{
						num = 10;
					}
					continue;
				case 6:
					c();
					b();
					a();
					num = 1;
					continue;
				case 1:
					return;
				case 5:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_e.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 0:
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			while (true)
			{
				IL_004a:
				bool flag = y.RecordCount <= 0;
				int num = 10;
				while (true)
				{
					switch (num)
					{
					case 10:
						if (!flag)
						{
							num = 14;
							continue;
						}
						goto case 8;
					case 9:
						try
						{
							ag.Checked = bool.Parse(y.SelectedItems[0].GetRow().Cells["Vezarat"].Value.ToString());
							ag.Tag = y.SelectedItems[0].GetRow().Cells["Vezarat"].Value.ToString();
						}
						catch
						{
						}
						ac.Text = y.SelectedItems[0].GetRow().Cells["timeWeek"].Value.ToString();
						z.Text = y.SelectedItems[0].GetRow().Cells["sort"].Value.ToString();
						flag = !(y.SelectedItems[0].GetRow().Cells["Type"].Value.ToString() == "2");
						num = 3;
						continue;
					case 13:
						if (flag)
						{
							p.Checked = false;
							o.Checked = false;
							num = 12;
						}
						else
						{
							num = 0;
						}
						continue;
					case 4:
					case 6:
					case 7:
					case 12:
						k.Visible = true;
						t.Focus();
						num = 8;
						continue;
					case 11:
						if (flag)
						{
							flag = !(y.SelectedItems[0].GetRow().Cells["Type"].Value.ToString() == "4");
							num = 13;
						}
						else
						{
							num = 2;
						}
						continue;
					case 3:
						if (flag)
						{
							flag = !(y.SelectedItems[0].GetRow().Cells["Type"].Value.ToString() == "3");
							num = 11;
						}
						else
						{
							num = 5;
						}
						continue;
					case 0:
						p.Checked = false;
						o.Checked = false;
						num = 6;
						continue;
					case 2:
						p.Checked = false;
						o.Checked = true;
						num = 4;
						continue;
					case 14:
						ah = 2;
						n.SelectedValue = y.SelectedItems[0].GetRow().Cells["xpaye"].Value.ToString();
						n.Enabled = false;
						t.Text = y.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
						ad.Text = y.SelectedItems[0].GetRow().Cells["vahed"].Value.ToString();
						ad.Tag = y.SelectedItems[0].GetRow().Cells["vahed"].Value.ToString();
						ae.Text = y.SelectedItems[0].GetRow().Cells["CodeDars"].Value.ToString();
						num = 9;
						continue;
					case 5:
						p.Checked = true;
						o.Checked = false;
						num = 7;
						continue;
					case 8:
						num = 1;
						continue;
					case 1:
						goto end_IL_0005;
					}
					goto IL_004a;
					continue;
					end_IL_0005:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		string text3 = default;
		string text = default;
		while (true)
		{
			bool flag = n.SelectedIndex >= 0;
			int num = 49;
			while (true)
			{
				int num2;
				int num5;
				switch (num)
				{
				case 49:
					if (!flag)
					{
						num = 33;
						continue;
					}
					flag = !(t.Text == "");
					num = 48;
					continue;
				case 26:
					MessageBox.Show("نام درس را تکراری می باشد");
					t.Focus();
					num = 53;
					continue;
				case 53:
					if (1 == 0)
					{
					}
					return;
				case 46:
					MessageBox.Show("ترتیب را وارد کنيد");
					z.Focus();
					num = 31;
					continue;
				case 31:
					return;
				case 36:
					MessageBox.Show("کد درس را تکراری می باشد");
					ae.Focus();
					num = 5;
					continue;
				case 5:
					return;
				case 13:
				{
					if (!flag)
					{
						num = 40;
						continue;
					}
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) AS countId FROM tBook WHERE  id<>" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + " and  (xPaye = " + n.SelectedValue.ToString() + ") AND (codeDars = " + ae.Text + ")").ToString();
					flag = !(text2 != "0");
					num = 6;
					continue;
				}
				case 44:
					num = ((float.Parse(ad.Text) != float.Parse(ad.Tag.ToString())) ? 37 : 38);
					continue;
				case 38:
					num = 27;
					continue;
				case 27:
					num2 = ((ag.Checked == bool.Parse(ag.Tag.ToString())) ? 1 : 0);
					goto IL_0bce;
				case 42:
					MessageBox.Show("تعداد واحد را وارد کنيد");
					ad.Focus();
					num = 23;
					continue;
				case 23:
					return;
				case 24:
				{
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(id) AS countId FROM tBook WHERE     (xPaye = " + n.SelectedValue.ToString() + ") AND (Name = @Name)", new SqlParameter("@Name", asdaj.b(t.Text))).ToString();
					flag = !(text2 != "0");
					num = 55;
					continue;
				}
				case 55:
				{
					if (!flag)
					{
						num = 26;
						continue;
					}
					string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) AS countId FROM tBook WHERE (xPaye = " + n.SelectedValue.ToString() + ") AND (codeDars = " + ae.Text + ")").ToString();
					flag = !(text2 != "0");
					num = 8;
					continue;
				}
				case 34:
					num = 41;
					continue;
				case 41:
					num5 = (o.Checked ? 1 : 0);
					goto IL_05cd;
				case 9:
				case 16:
					text3 = "0";
					flag = !ag.Checked;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 57;
						continue;
					}
					goto case 54;
				case 19:
					MessageBox.Show("ساعات هفتگی را وارد کنيد");
					ac.Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 54:
					flag = ah != 1;
					num = 17;
					continue;
				case 17:
					if (flag)
					{
						string text2 = asdcb.a(asdab.e(), CommandType.Text, "SELECT     COUNT(id) AS countId FROM tBook WHERE  id<>" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + " and (xPaye = " + n.SelectedValue.ToString() + ") AND (Name = @Name)", new SqlParameter("@Name", asdaj.b(t.Text))).ToString();
						flag = !(text2 != "0");
						num = 13;
					}
					else
					{
						num = 24;
					}
					continue;
				case 10:
					MessageBox.Show("نوع درس را مشخص کنيد");
					p.Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 22:
					if (!flag)
					{
						num = 10;
						continue;
					}
					text = "";
					flag = !p.Checked;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 39;
						continue;
					}
					flag = !o.Checked;
					num = 4;
					continue;
				case 57:
					text3 = "1";
					num = 54;
					continue;
				case 50:
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tExam SET procc = 0 WHERE xyear=" + asdaj.__field_a + " and (id IN(SELECT DISTINCT Xtest FROM tMark  WHERE (xbook = " + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")))");
					num = 21;
					continue;
				case 39:
					text = "2";
					num = 16;
					continue;
				case 32:
					num5 = 1;
					goto IL_05cd;
				case 18:
					MessageBox.Show("کد درس را تکراری می باشد");
					ae.Focus();
					num = 52;
					continue;
				case 52:
					return;
				case 6:
					if (flag)
					{
						asdcb.d(asdab.e(), CommandType.Text, "update tbook set Name=@Name,Type=" + text + ",vahed=" + ad.Text + ",timeWeek=" + ac.Text + ",sort=" + z.Text + ",codeDars = " + ae.Text + ",Vezarat=" + text3 + ",xExportRpt=null where id=" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString(), new SqlParameter("@Name", asdaj.b(t.Text)));
						num = 44;
					}
					else
					{
						num = 36;
					}
					continue;
				case 8:
					if (!flag)
					{
						num = 18;
						continue;
					}
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tbook (xPaye,Name,vahed,timeWeek,Type,sort,SortOneEntry,CodeDars,Vezarat)VALUES(" + n.SelectedValue.ToString() + ", @Name," + ad.Text + "," + ac.Text + "," + text + "," + z.Text + "," + z.Text + "," + ae.Text + "," + text3 + ")", new SqlParameter("@Name", asdaj.b(t.Text)));
					t.Text = "";
					t.Focus();
					num = 47;
					continue;
				case 43:
					if (!flag)
					{
						num = 42;
						continue;
					}
					flag = !(z.Text == "");
					num = 58;
					continue;
				case 35:
					MessageBox.Show("نام درس را وارد کنيد");
					t.Focus();
					num = 25;
					continue;
				case 25:
					return;
				case 1:
					if (flag)
					{
						flag = !(ad.Text == "");
						num = 43;
					}
					else
					{
						num = 19;
					}
					continue;
				case 33:
					MessageBox.Show("نوع را مشخص کنید");
					n.Focus();
					num = 30;
					continue;
				case 30:
					return;
				case 28:
					num = (flag ? 15 : 20);
					continue;
				case 4:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 9;
				case 40:
					MessageBox.Show("نام درس را تکراری می باشد");
					t.Focus();
					num = 45;
					continue;
				case 45:
					return;
				case 47:
					try
					{
						int num3 = int.Parse(z.Text);
						z.Text = (num3 + 1).ToString();
						int num4 = int.Parse(ae.Text);
						ae.Text = (num4 + 1).ToString();
					}
					catch
					{
					}
					num = 51;
					continue;
				case 15:
					num = ((!p.Checked) ? 34 : 32);
					continue;
				case 12:
					if (!flag)
					{
						num = 50;
						continue;
					}
					goto case 21;
				case 48:
					if (flag)
					{
						flag = !(ac.Text == "");
						num = 1;
					}
					else
					{
						num = 35;
					}
					continue;
				case 58:
					if (flag)
					{
						flag = !(ae.Text == "");
						num = 28;
					}
					else
					{
						num = 46;
					}
					continue;
				case 37:
					num2 = 0;
					goto IL_0bce;
				case 56:
					text = "3";
					num = 9;
					continue;
				case 21:
					k.Visible = false;
					num = 0;
					continue;
				case 20:
					MessageBox.Show("کد درس را وارد کنيد");
					ae.Focus();
					num = 29;
					continue;
				case 29:
					return;
				case 0:
				case 51:
					a();
					num = 14;
					continue;
				case 14:
					return;
					IL_05cd:
					flag = (byte)num5 != 0;
					num = 22;
					continue;
					IL_0bce:
					flag = (byte)num2 != 0;
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		k.Visible = false;
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			int num2 = default;
			int num3 = default;
			while (true)
			{
				IL_0064:
				bool flag = y.RecordCount <= 0;
				int num = 14;
				while (true)
				{
					switch (num)
					{
					case 14:
						if (!flag)
						{
							num = 15;
							continue;
						}
						goto case 13;
					case 0:
						num = 2;
						continue;
					case 6:
						try
						{
							num2 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) FROM tDisciplinaryStudent WHERE XBook=" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString());
						}
						catch
						{
						}
						flag = num3 <= 0;
						num = 5;
						continue;
					case 7:
						flag = MessageBox.Show("آیا از حذف درس اطمینان دارید", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 16;
						continue;
					case 16:
						if (!flag)
						{
							num = 17;
							continue;
						}
						goto case 0;
					case 2:
					case 9:
						num = 13;
						continue;
					case 4:
						MessageBox.Show("از این درس در بخش اخطار آموزشی استفاده شده است. شما قادر به حذف نمیباشید", "حذف");
						num = 3;
						continue;
					case 3:
						return;
					case 17:
						asdcb.d(asdab.e(), CommandType.Text, "delete from  tBook WHERE  id = " + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						a();
						num = 0;
						continue;
					case 8:
						MessageBox.Show("برای این درس نمره وارد شده است. شما قادر به حذف نمیباشید", "حذف");
						num = 12;
						continue;
					case 12:
						return;
					case 15:
						num3 = int.Parse(asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) FROM tMark WHERE XBook=" + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString());
						num2 = 0;
						num = 6;
						continue;
					case 5:
						if (!flag)
						{
							num = 8;
							continue;
						}
						flag = num2 <= 0;
						num = 1;
						continue;
					case 1:
					{
						if (!flag)
						{
							num = 4;
							continue;
						}
						string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(xCls) FROM   tTch_Cls WHERE     (xLsn = " + y.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")").ToString();
						flag = !(text == "0");
						num = 10;
						continue;
					}
					case 10:
						if (flag)
						{
							MessageBox.Show("برای این درس معلم تعریف شده است .حذف امکان پذیر نیست");
							num = 9;
						}
						else
						{
							num = 7;
						}
						continue;
					case 13:
						num = 11;
						continue;
					case 11:
						goto end_IL_0013;
					}
					goto IL_0064;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		a();
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_g.SelectedValue = n.SelectedValue;
		e();
	}
}
