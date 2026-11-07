using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using FreeSms.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdbh : Form
{
    private bool historyBusy,loadingHistory,historyDirty;
    private int loadedClass,loadedHistoryGrade;
    private readonly Dictionary<int,object> historyOrders=new Dictionary<int,object>();

	private Panel m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private EditBox m_e;

	private Label m_f;

	private EditBox m_g;

	private Label m_h;

	private GridEX m_i;

	private UIButton m_j;

	private Panel m_k;

	private UIButton m_l;

	private UIButton m_m;

	private Label m_n;

	private UIButton o;

	private UIButton p;

	private Label q;

	private UIComboBox r;

	private GridEX s;

	private Label t;

	private NumericEditBox u;

	private NumericEditBox v;

	private Label w;

	private Panel x;

	private Label y;

	private Panel z;

	private RadioButton aa;

	private RadioButton ab;

	private Label ac;

	private NumericEditBox ad;

	private Label ae;

	private TextBox af;

	private Label ag;

	private Container ah = null;


	private string aj;

	private bool ak = false;


	private int am = -1;


	public asdbh()
	{
		f();
        this.m_d.CausesValidation=false;p.CausesValidation=false;this.m_l.CausesValidation=false;this.m_m.CausesValidation=false;
        ad.TextChanged+=(sender,args)=>{if(!loadingHistory && this.m_k.Visible)historyDirty=true;};
        FormClosing+=(sender,args)=>
        {
            if(historyBusy){args.Cancel=true;return;}
            if(!ConfirmHistoryDiscard()){args.Cancel=true;return;}
            s.CancelEdit();
        };
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
						num = 4;
						continue;
					}
					goto case 1;
				case 0:
					num = 1;
					continue;
				case 3:
					ah.Dispose();
					num = 0;
					continue;
				case 4:
					flag = ah == null;
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 1:
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbh));
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		StringFormat stringFormat = new StringFormat();
		this.m_a = new Panel();
		this.m_b = new Panel();
		this.m_k = new Panel();
		x = new Panel();
		af = new TextBox();
		ae = new Label();
		ac = new Label();
		ad = new NumericEditBox();
		y = new Label();
		this.m_n = new Label();
		s = new GridEX();
		this.m_l = new UIButton();
		o = new UIButton();
		this.m_m = new UIButton();
		p = new UIButton();
		this.m_i = new GridEX();
		this.m_f = new Label();
		this.m_e = new EditBox();
		this.m_d = new UIButton();
		this.m_c = new UIButton();
		this.m_j = new UIButton();
		q = new Label();
		r = new UIComboBox();
		this.m_h = new Label();
		this.m_g = new EditBox();
		t = new Label();
		u = new NumericEditBox();
		v = new NumericEditBox();
		w = new Label();
		z = new Panel();
		aa = new RadioButton();
		ab = new RadioButton();
		ag = new Label();
		this.m_a.SuspendLayout();
		this.m_b.SuspendLayout();
		this.m_k.SuspendLayout();
		x.SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((ISupportInitialize)this.m_i).BeginInit();
		z.SuspendLayout();
		SuspendLayout();
		this.m_a.BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_a.Controls.Add(this.m_b);
		this.m_a.Location = new Point(5, 6);
		this.m_a.Name = "panel1";
		this.m_a.Size = new Size(695, 700);
		this.m_a.TabIndex = 16;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(this.m_k);
		this.m_b.Controls.Add(this.m_i);
		this.m_b.Controls.Add(this.m_f);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(this.m_j);
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(r);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Controls.Add(this.m_g);
		this.m_b.Controls.Add(t);
		this.m_b.Controls.Add(u);
		this.m_b.Controls.Add(v);
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(z);
		this.m_b.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(8, 8);
		this.m_b.Name = "panel2";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.Size = new Size(679, 680);
		this.m_b.TabIndex = 0;
		this.m_k.BackColor = Color.Silver;
		this.m_k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_k.Controls.Add(x);
		this.m_k.Location = new Point(116, 3);
		this.m_k.Name = "pStdMark";
		this.m_k.Size = new Size(489, 664);
		this.m_k.TabIndex = 74;
		this.m_k.Visible = false;
		x.BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		x.Controls.Add(ag);
		x.Controls.Add(af);
		x.Controls.Add(ae);
		x.Controls.Add(ac);
		x.Controls.Add(ad);
		x.Controls.Add(y);
		x.Controls.Add(this.m_n);
		x.Controls.Add(s);
		x.Controls.Add(this.m_l);
		x.Controls.Add(o);
		x.Controls.Add(this.m_m);
		x.Controls.Add(p);
		x.Location = new Point(3, 3);
		x.Name = "panel3";
		x.Size = new Size(481, 655);
		x.TabIndex = 81;
		af.Enabled = false;
		af.Location = new Point(126, 579);
		af.Name = "txtSumMark";
		af.RightToLeft = RightToLeft.No;
		af.Size = new Size(82, 23);
		af.TabIndex = 89;
		af.TextAlign = HorizontalAlignment.Center;
		ae.AutoSize = true;
		ae.Location = new Point(211, 582);
		ae.Name = "label2";
		ae.Size = new Size(100, 16);
		ae.TabIndex = 87;
		ae.Text = "مجموع نمرات :";
		ac.AutoSize = true;
		ac.Location = new Point(396, 91);
		ac.Name = "label1";
		ac.Size = new Size(49, 16);
		ac.TabIndex = 86;
		ac.Text = "درجه :";
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.ButtonFont = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ad.Location = new Point(324, 86);
		ad.MaxLength = 2;
		ad.Name = "txtGClass";
		ad.RightToLeft = RightToLeft.No;
		ad.Size = new Size(66, 23);
		ad.TabIndex = 1;
		ad.Text = "0";
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
		ad.Value = (short)0;
		ad.ValueType = NumericEditValueType.Int16;
		ad.Leave += a;
		ad.KeyUp += a;
		ad.Enter += b;
		y.BackColor = Color.FromArgb(255, 224, 192);
		y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		y.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		y.Location = new Point(293, 36);
		y.Name = "lExam";
		y.RightToLeft = RightToLeft.Yes;
		y.Size = new Size(172, 38);
		y.TabIndex = 82;
		y.TextAlign = ContentAlignment.MiddleCenter;
		this.m_n.BackColor = Color.FromArgb(192, 255, 192);
		this.m_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_n.Font = new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_n.Location = new Point(8, 34);
		this.m_n.Name = "lName";
		this.m_n.RightToLeft = RightToLeft.Yes;
		this.m_n.Size = new Size(279, 42);
		this.m_n.TabIndex = 76;
		this.m_n.TextAlign = ContentAlignment.MiddleCenter;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout5.LayoutString");
		s.DesignTimeLayout = gridEXLayout;
		s.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		s.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		s.Font = new Font("Tahoma", 9.75f);
		s.GroupByBoxVisible = false;
		s.Location = new Point(8, 118);
		s.Name = "gStdMark";
		s.RecordNavigator = true;
		s.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		s.SelectedFormatStyle.BackColor = Color.Empty;
		s.SelectedFormatStyle.ForeColor = Color.Empty;
		s.Size = new Size(458, 452);
		s.TabIndex = 2;
		s.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		s.SelectionChanged += d;
		s.KeyUp += e;
		s.CellUpdated += a;
		this.m_l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_l.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_l.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		this.m_l.ImageIndex = 8;
		this.m_l.ImageSize = new Size(30, 30);
		this.m_l.Location = new Point(88, 2);
		this.m_l.Name = "btnPrevious";
		this.m_l.RightToLeft = RightToLeft.Yes;
		this.m_l.Size = new Size(190, 26);
		this.m_l.TabIndex = 75;
		this.m_l.Text = "(pageUp)    قبلی  ";
		this.m_l.ToolTipText = "دکمه میانبر : PageUp";
		this.m_l.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_l.Click += h;
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		o.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		o.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Image = (Image)componentResourceManager.GetObject("btnAcptest.Image");
		o.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Empty;
		o.ImageIndex = 8;
		o.ImageSize = new Size(50, 50);
		o.Location = new Point(156, 612);
		o.Name = "btnAcptest";
		o.Size = new Size(144, 38);
		o.TabIndex = 77;
		o.Text = "(F5)تائيد";
		o.ToolTipText = "دکمه میانبر : F5";
		o.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		o.Click += g;
		this.m_m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_m.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		this.m_m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_m.ImageIndex = 8;
		this.m_m.ImageSize = new Size(30, 30);
		this.m_m.Location = new Point(281, 2);
		this.m_m.Name = "btnNext";
		this.m_m.RightToLeft = RightToLeft.Yes;
		this.m_m.Size = new Size(185, 26);
		this.m_m.TabIndex = 74;
		this.m_m.Tag = "";
		this.m_m.Text = "(pageDown)    بعدی  ";
		this.m_m.ToolTipText = "دکمه میانبر : PageDown";
		this.m_m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_m.Click += i;
		p.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		p.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		p.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		p.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		p.ImageIndex = 8;
		p.ImageSize = new Size(30, 30);
		p.Location = new Point(8, 612);
		p.Name = "btnCancel";
		p.RightToLeft = RightToLeft.Yes;
		p.Size = new Size(142, 38);
		p.TabIndex = 78;
		p.Text = "(Esc)انصراف";
		p.ToolTipText = "دکمه میانبر : Esc";
		p.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		p.Click += m;
		this.m_i.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_i.CardCaptionPrefix = "Product:";
		this.m_i.Cursor = Cursors.Default;
		this.m_i.DataMember = null;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout6.LayoutString");
		this.m_i.DesignTimeLayout = gridEXLayout2;
		this.m_i.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_i.FlatBorderColor = SystemColors.ControlDark;
		this.m_i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
		this.m_i.GridLineColor = SystemColors.ScrollBar;
		this.m_i.GroupByBoxVisible = false;
		this.m_i.GroupRowVisualStyle = GroupRowVisualStyle.Outlook2003;
		this.m_i.Location = new Point(7, 124);
		this.m_i.Name = "gstd";
		this.m_i.RecordNavigator = true;
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_i.SelectedFormatStyle.Blend = 0.5f;
		this.m_i.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		this.m_i.Size = new Size(657, 490);
		this.m_i.TabIndex = 67;
		this.m_i.TabStop = false;
		this.m_i.VisualStyleAreas.CheckBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.ControlBorderStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.EditControlsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.GroupByBoxStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.GroupRowsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_i.VisualStyleAreas.ScrollBarsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.VisualStyleAreas.TreeGliphsStyle = Janus.Windows.GridEX.VisualStyle.Standard;
		this.m_i.SelectionChanged += f;
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_f.Location = new Point(321, 10);
		this.m_f.Name = "label12";
		this.m_f.RightToLeft = RightToLeft.Yes;
		this.m_f.Size = new Size(60, 26);
		this.m_f.TabIndex = 59;
		this.m_f.Text = "نام :";
		this.m_f.TextAlign = ContentAlignment.MiddleRight;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_e.AutoScroll = false;
		this.m_e.AutoScrollMargin = new Size(0, 0);
		this.m_e.AutoScrollMinSize = new Size(0, 0);
		this.m_e.AutoScrollPosition = new Point(0, 0);
		this.m_e.Location = new Point(177, 10);
		this.m_e.Name = "txtNamFSearch";
		this.m_e.RightToLeft = RightToLeft.Yes;
		this.m_e.Size = new Size(138, 23);
		this.m_e.TabIndex = 7;
		this.m_e.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_e.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_e.KeyUp += c;
		this.m_d.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_d.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.m_d.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_d.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_d.ImageIndex = 8;
		this.m_d.ImageSize = new Size(30, 30);
		this.m_d.Location = new Point(7, 624);
		this.m_d.Name = "uiButton2";
		this.m_d.RightToLeft = RightToLeft.Yes;
		this.m_d.Size = new Size(104, 31);
		this.m_d.TabIndex = 65;
		this.m_d.Text = "خروج";
		this.m_d.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_d.Click += l;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_c.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		this.m_c.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_c.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_c.ImageIndex = 8;
		this.m_c.Location = new Point(500, 625);
		this.m_c.Name = "btnNew";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(164, 32);
		this.m_c.TabIndex = 62;
		this.m_c.Text = "(F2)ورود نمرات";
		this.m_c.ToolTipText = "دکمه میانبر : F2";
		this.m_c.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_c.Click += j;
		this.m_j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_j.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnSearch.Image");
		this.m_j.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		this.m_j.ImageIndex = 8;
		this.m_j.ImageSize = new Size(30, 30);
		this.m_j.Location = new Point(177, 67);
		this.m_j.Name = "btnSearch";
		this.m_j.RightToLeft = RightToLeft.Yes;
		this.m_j.Size = new Size(138, 31);
		this.m_j.TabIndex = 73;
		this.m_j.Text = "جستجو اسم(F3)";
		this.m_j.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		this.m_j.Click += k;
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.AutoSize = true;
		q.Location = new Point(593, 16);
		q.Name = "label19";
		q.Size = new Size(48, 16);
		q.TabIndex = 78;
		q.Text = "صنف :";
		r.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		r.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		r.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		r.Location = new Point(416, 13);
		r.Name = "dropCls";
		r.Size = new Size(171, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		r.StringFormat = stringFormat;
		r.TabIndex = 76;
		r.SelectedIndexChanged += e;
		this.m_h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_h.Location = new Point(321, 36);
		this.m_h.Name = "label13";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(78, 28);
		this.m_h.TabIndex = 60;
		this.m_h.Text = "ولد /بنت :";
		this.m_h.TextAlign = ContentAlignment.MiddleRight;
		this.m_g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		this.m_g.AutoScroll = false;
		this.m_g.AutoScrollMargin = new Size(0, 0);
		this.m_g.AutoScrollMinSize = new Size(0, 0);
		this.m_g.AutoScrollPosition = new Point(0, 0);
		this.m_g.Location = new Point(177, 39);
		this.m_g.Name = "txtNamLSearch";
		this.m_g.RightToLeft = RightToLeft.Yes;
		this.m_g.Size = new Size(138, 23);
		this.m_g.TabIndex = 6;
		this.m_g.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_g.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_g.KeyUp += d;
		t.AutoSize = true;
		t.Location = new Point(65, 39);
		t.Name = "label4";
		t.Size = new Size(25, 16);
		t.TabIndex = 84;
		t.Text = "تا :";
		t.Visible = false;
		u.AutoScroll = false;
		u.AutoScrollMargin = new Size(0, 0);
		u.AutoScrollMinSize = new Size(0, 0);
		u.AutoScrollPosition = new Point(0, 0);
		u.Location = new Point(7, 36);
		u.Name = "txtMaxMark";
		u.Size = new Size(52, 23);
		u.TabIndex = 83;
		u.Text = "100";
		u.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		u.Value = (short)100;
		u.ValueType = NumericEditValueType.Int16;
		u.Visible = false;
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.Location = new Point(7, 9);
		v.Name = "txtMinMark";
		v.Size = new Size(52, 23);
		v.TabIndex = 82;
		v.Text = "0";
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		v.Value = (short)0;
		v.ValueType = NumericEditValueType.Int16;
		v.Visible = false;
		w.AutoSize = true;
		w.Location = new Point(65, 10);
		w.Name = "label3";
		w.Size = new Size(83, 16);
		w.TabIndex = 81;
		w.Text = "رنج نمره از :";
		w.Visible = false;
		z.BackColor = Color.FromArgb(255, 192, 255);
		z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		z.Controls.Add(aa);
		z.Controls.Add(ab);
		z.Location = new Point(407, 48);
		z.Name = "panel4";
		z.Size = new Size(185, 58);
		z.TabIndex = 85;
		aa.AutoSize = true;
		aa.Location = new Point(29, 30);
		aa.Name = "r11";
		aa.Size = new Size(142, 20);
		aa.TabIndex = 1;
		aa.Text = "نمرات صنف یازدهم";
		aa.UseVisualStyleBackColor = true;
		ab.AutoSize = true;
		ab.Checked = true;
		ab.Location = new Point(43, 3);
		ab.Name = "r10";
		ab.Size = new Size(128, 20);
		ab.TabIndex = 0;
		ab.TabStop = true;
		ab.Text = "نمرات صنف دهم";
		ab.UseVisualStyleBackColor = true;
		ab.CheckedChanged += c;
		ag.AutoSize = true;
		ag.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ag.ForeColor = Color.Maroon;
		ag.Location = new Point(9, 91);
		ag.Name = "label5";
		ag.Size = new Size(292, 16);
		ag.TabIndex = 90;
		ag.Text = "راهنمای درجه : 1 (الف)   2 (ب)   3(ج)   4 (د)   5(ه)";
		AutoScaleBaseSize = new Size(8, 26);
		BackColor = Color.FromArgb(184, 203, 255);
		ClientSize = new Size(706, 714);
		Controls.Add(this.m_a);
		Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmMarkEntryAgo";
		StartPosition = FormStartPosition.CenterScreen;
		Tag = "10";
		Text = "اطلاعات داوطلبان";
		Load += n;
		KeyUp += b;
		this.m_a.ResumeLayout(performLayout: false);
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		this.m_k.ResumeLayout(performLayout: false);
		x.ResumeLayout(performLayout: false);
		x.PerformLayout();
		((ISupportInitialize)s).EndInit();
		((ISupportInitialize)this.m_i).EndInit();
		z.ResumeLayout(performLayout: false);
		z.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void e()
    {
        if(historyBusy || loadingHistory)return;
        loadingHistory=true;
        try
        {
            r.DataSource=asdcb.c(asdab.e(),CommandType.Text,"SELECT c.id,c.name FROM tClass c WHERE c.xYear=@year AND c.xPaye=12 AND EXISTS(SELECT 1 FROM tYear_Student y WHERE y.xClass=c.id AND y.xYear=@year AND y.xPaye=12) ORDER BY c.sortRpt,c.id",new SqlParameter("@year",int.Parse(asdaj.__field_a)));
            r.DisplayMember="name";r.ValueMember="id";
            if(!HistoryGrades().Contains(12))r.DataSource=null;
        }
        finally{loadingHistory=false;}
        d();
    }

	private void d()
    {
        if(historyBusy || loadingHistory)return;
        if(!ConfirmHistoryDiscard())
        {
            loadingHistory=true;
            try{if(loadedClass>0)r.SelectedValue=loadedClass.ToString();ab.Checked=loadedHistoryGrade!=11;}
            finally{loadingHistory=false;}return;
        }
        loadingHistory=true;
        try
        {
            s.CancelEdit();this.m_k.Visible=false;historyDirty=false;aj=null;historyOrders.Clear();s.DataSource=null;
            int year=Values.Number(asdaj.__field_a,1000,9999) ?? 0;
            int classroom=Values.Number(r.SelectedValue,1) ?? 0;
            if(classroom==0 || !HistoryGrades().Contains(12)){this.m_i.DataSource=null;return;}
            this.m_i.DataSource=asdcb.c(asdab.e(),CommandType.Text,
                "SELECT y.sort,s.id,s.Code,s.FName,s.LName,s.PName,h.Mark,h.gClass FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id JOIN tClass c ON c.id=y.xClass AND c.xYear=y.xYear AND c.xPaye=y.xPaye LEFT JOIN tMarkAgo h ON h.xStudent=s.id AND h.xPaye=@historic AND h.typ=5 WHERE y.xYear=@year AND y.xClass=@class AND y.xPaye=12 AND s.FName LIKE @first AND s.LName LIKE @last ORDER BY y.sort,s.id",
                new SqlParameter("@historic",aa.Checked?11:10),new SqlParameter("@year",year),new SqlParameter("@class",classroom),new SqlParameter("@first","%"+OriginalText.Normalize(this.m_e.Text)+"%"),new SqlParameter("@last","%"+OriginalText.Normalize(this.m_g.Text)+"%"));
        }
        catch(Exception error){MessageBox.Show(error.Message);}
        finally{loadingHistory=false;b();}
    }

	private void c()
    {
        if(historyBusy || loadingHistory)return;
        loadingHistory=true;
        try
        {
            historyDirty=false;historyOrders.Clear();am=-1;ak=false;
            if(this.m_i.RowCount==0 || this.m_i.Row<0 || this.m_i.SelectedItems.Count==0)
            {aj=null;s.DataSource=null;af.Text="";ad.Text="0";return;}
            var selected=this.m_i.SelectedItems[0].GetRow();
            int student=Convert.ToInt32(selected.Cells["id"].Value);aj=student.ToString(CultureInfo.InvariantCulture);
            loadedClass=Values.Number(r.SelectedValue,1) ?? 0;loadedHistoryGrade=aa.Checked?11:10;
            this.m_n.Text=selected.Cells["FName"].Text+" "+selected.Cells["LName"].Text;
            y.Text=loadedHistoryGrade==10?"نمرات صنف دهم":"نمرات صنف یازدهم";
            var table=asdcb.c(asdab.e(),CommandType.Text,"SELECT 0 AS acp,b.id AS xbook,b.Name AS book,b.SortOneEntry,b.sort,h.Mark AS M1 FROM tBook b LEFT JOIN tMarkAgo h ON h.xbook=b.id AND h.xStudent=@student AND h.xPaye=@grade AND h.typ=1 WHERE b.xPaye=12 AND b.showOneEntry=1 ORDER BY b.sort,b.id",new SqlParameter("@student",student),new SqlParameter("@grade",loadedHistoryGrade));
            s.DataSource=table;s.RootTable.FormatConditions.Clear();
            foreach(DataRow row in table.Rows)historyOrders[Convert.ToInt32(row["xbook"])]=row["SortOneEntry"];
            foreach(var state in new[]{("1",Color.FromArgb(0,200,0)),("-1",Color.FromArgb(250,0,150))})
            {
                var condition=new GridEXFormatCondition(s.RootTable.Columns["acp"],ConditionOperator.Equal,state.Item1);condition.FormatStyle.BackColor=state.Item2;s.RootTable.FormatConditions.Add(condition);
            }
            var total=asdcb.c(asdab.e(),CommandType.Text,"SELECT Mark,gClass FROM tMarkAgo WHERE xStudent=@student AND xPaye=@grade AND typ=5",new SqlParameter("@student",student),new SqlParameter("@grade",loadedHistoryGrade));
            af.Text=total.Rows.Count==0?"":Convert.ToString(total.Rows[0]["Mark"],CultureInfo.InvariantCulture);
            ad.Text=total.Rows.Count==0?"0":Convert.ToString(total.Rows[0]["gClass"],CultureInfo.InvariantCulture);
        }
        catch(Exception error){s.DataSource=null;MessageBox.Show(error.Message);}
        finally{loadingHistory=false;b();}
    }

	private void n(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					if (true)
					{
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
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
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 2:
					e();
					num = 3;
					continue;
				case 3:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
    {
        if(historyBusy)return;
        s.CancelEdit();historyDirty=false;this.m_k.Visible=false;d();
    }

	private void l(object A_0, EventArgs A_1)
    {
        Close();
    }

	private void k(object A_0, EventArgs A_1)
	{
		d();
	}

	private void j(object A_0, EventArgs A_1)
    {
        if(historyBusy || !ConfirmHistoryDiscard() || this.m_i.RowCount==0)return;
        c();
        if(s.RowCount==0){MessageBox.Show("مضمونی برای ورود نمرات تعریف نشده است.");return;}
        this.m_k.Visible=true;FocusHistoryEditor();
    }

	private void i(object A_0, EventArgs A_1)
    {
        MoveHistory(1);
    }

	private void b()
    {
        this.m_l.Enabled=!historyBusy && this.m_i.RowCount>0 && this.m_i.Row>0;
        this.m_m.Enabled=!historyBusy && this.m_i.RowCount>0 && this.m_i.Row>=0 && this.m_i.Row<this.m_i.RowCount-1;
        this.m_c.Enabled=!historyBusy && this.m_i.RowCount>0;
    }

	private void h(object A_0, EventArgs A_1)
    {
        MoveHistory(-1);
    }

	private void g(object A_0, EventArgs A_1)
    {
        SaveHistoryAsync();
    }

	private void f(object A_0, EventArgs A_1)
    {
        if(historyBusy || loadingHistory)return;
        if(this.m_i.Row>=0 && this.m_i.SelectedItems.Count>0 && this.m_i.SelectedItems[0].GetRow().Cells["id"].Text==aj){b();return;}
        if(!ConfirmHistoryDiscard())
        {
            loadingHistory=true;
            try{for(int index=0;index<this.m_i.RowCount;index++)if(this.m_i.GetRow(index).Cells["id"].Text==aj){this.m_i.Row=index;break;}}
            finally{loadingHistory=false;}return;
        }
        c();
    }

	private void e(object A_0, KeyEventArgs A_1)
	{
	}

	private void e(object A_0, EventArgs A_1)
	{
		m(this, null);
		d();
	}

	private void d(object A_0, KeyEventArgs A_1)
    {
        HistoryKeyDown(A_1);
    }

	private void c(object A_0, KeyEventArgs A_1)
    {
        HistoryKeyDown(A_1);
    }

	private void b(object A_0, KeyEventArgs A_1)
    {
        HistoryKeyDown(A_1);
    }

	private void a(object A_0, ColumnActionEventArgs A_1)
    {
        if(historyBusy || loadingHistory || s.Row<0)return;
        if(A_1.Column.Key=="SortOneEntry"){SaveHistoryOrderAsync();return;}
        if(A_1.Column.Key.Equals("m1",StringComparison.OrdinalIgnoreCase)){historyDirty=true;a();}
    }

	private void a()
    {
        if(loadingHistory)return;
        loadingHistory=true;var entries=new List<HistoryMark>();ak=false;am=-1;
        try
        {
            for(int index=0;index<s.RowCount;index++)
            {
                var row=s.GetRow(index);
                try{entries.Add(HistoryMark.Create(Convert.ToInt32(row.Cells["xbook"].Value),row.Cells["m1"].Value));row.Cells["acp"].Value=0;}
                catch(ValidationException){ak=true;if(am<0)am=index;row.Cells["acp"].Value=-1;}
            }
            af.Text=ak?"":HistoryMark.Total(entries).ToString(CultureInfo.InvariantCulture);
        }
        finally{loadingHistory=false;}
    }

	private void d(object A_0, EventArgs A_1)
    {
        if(historyBusy || am<0 || am>=s.RowCount)return;
        s.Row=am;MessageBox.Show("نمره وارد شده خارج از محدوده است");FocusHistoryEditor();
    }

	private void c(object A_0, EventArgs A_1)
	{
		d();
	}

	private void b(object A_0, EventArgs A_1)
	{
		ad.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		ad.BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
    {
        if(A_1.KeyCode==Keys.Return){A_1.Handled=true;A_1.SuppressKeyPress=true;FocusHistoryEditor();}
    }

    private int[] HistoryGrades()=>asdaj.n.Split(',').Where(value=>int.TryParse(value,out _)).Select(int.Parse).ToArray();
    private bool HasHistoryEdits()
    {
        var view=s.Controls.OfType<DataGridView>().Single();
        return historyDirty || (this.m_k.Visible && view.IsCurrentCellInEditMode && view.EditingControl is TextBox editor && editor.Text!=Convert.ToString(view.CurrentCell.Value,CultureInfo.CurrentCulture));
    }
    private bool ConfirmHistoryDiscard()
    {
        if(loadingHistory || !HasHistoryEdits())return true;
        if(MessageBox.Show("تغییرات نمرات گذشته ثبت نشده است. بدون ثبت ادامه می‌دهید؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)!=DialogResult.Yes)return false;
        s.CancelEdit();historyDirty=false;return true;
    }
    private void FocusHistoryEditor()
    {
        if(s.RowCount==0)return;s.Row=Math.Max(0,s.Row);s.CurrentColumn=s.RootTable.Columns["m1"];s.Select();s.SelectCurrentCellText();
    }
    private void MoveHistory(int direction)
    {
        if(historyBusy || this.m_i.RowCount==0 || !ConfirmHistoryDiscard())return;
        if(direction>0 && this.m_i.Row<this.m_i.RowCount-1)this.m_i.MoveNext();
        else if(direction<0 && this.m_i.Row>0)this.m_i.MovePrevious();
        c();FocusHistoryEditor();
    }
    private void HistoryKeyDown(KeyEventArgs key)
    {
        if(historyBusy)return;
        if(key.KeyCode==Keys.F2)j(this,EventArgs.Empty);
        else if(key.KeyCode==Keys.F3)k(this,EventArgs.Empty);
        else if(key.KeyCode==Keys.F5 && this.m_k.Visible)SaveHistoryAsync();
        else if(key.KeyCode==Keys.Escape && this.m_k.Visible)m(this,EventArgs.Empty);
        else if(key.KeyCode==Keys.PageDown)MoveHistory(1);
        else if(key.KeyCode==Keys.PageUp)MoveHistory(-1);
        else return;
        key.Handled=true;key.SuppressKeyPress=true;
    }
    private async void SaveHistoryAsync()
    {
        if(historyBusy || !this.m_k.Visible || !s.TryEndEdit())return;
        var entries=new List<HistoryMark>();int year,classroom,student,grade,rank;int[] allowed;
        try
        {
            if(!asdaj.a("3"))throw new ValidationException("شما مجوز ورود به این بخش را ندارید");
            year=Values.Number(asdaj.__field_a,1000,9999) ?? 0;classroom=loadedClass;
            student=Values.Number(aj,1) ?? throw new ValidationException("شاگردی انتخاب نشده است.");grade=loadedHistoryGrade;allowed=HistoryGrades();
            rank=Values.Number(ad.Text,0,short.MaxValue) ?? 0;
            for(int index=0;index<s.RowCount;index++)
                try{var row=s.GetRow(index);entries.Add(HistoryMark.Create(Convert.ToInt32(row.Cells["xbook"].Value),row.Cells["m1"].Value));}
                catch(ValidationException error){s.Row=index;throw new ValidationException("ردیف "+(index+1)+": "+error.Message);}
            if(entries.Count==0)throw new ValidationException("مضمونی برای ورود نمرات تعریف نشده است.");
        }
        catch(Exception error){MessageBox.Show(error.Message);return;}
        bool enabled=Enabled,wait=UseWaitCursor;historyBusy=true;Enabled=false;UseWaitCursor=true;bool saved=false;
        try
        {
            var service=new HistoryMarks(new Database(asdab.e()));
            int total=await Task.Run(()=>service.Save(year,classroom,student,grade,allowed,entries,rank));
            af.Text=total.ToString(CultureInfo.InvariantCulture);historyDirty=false;saved=true;
        }
        catch(Exception error){MessageBox.Show("نمرات گذشته ذخیره نشد.\n"+error.Message);}
        finally{Enabled=enabled;UseWaitCursor=wait;historyBusy=false;}
        if(!saved)return;
        if(this.m_i.Row<this.m_i.RowCount-1 && MessageBox.Show("اطلاعات ذخیره شد . آیا مایل هستید نفر بعدی نمایش داده شود","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){MoveHistory(1);return;}
        if(this.m_i.Row>=this.m_i.RowCount-1)MessageBox.Show("اطلاعات ذخیره شد");
        this.m_k.Visible=false;d();
    }
    private async void SaveHistoryOrderAsync()
    {
        int rowIndex=s.Row,book=Convert.ToInt32(s.GetRow(s.Row).Cells["xbook"].Value);object original=historyOrders.TryGetValue(book,out var old)?old:DBNull.Value;
        bool enabled=Enabled,wait=UseWaitCursor;
        try
        {
            if(!asdaj.a("3"))throw new ValidationException("شما مجوز ورود به این بخش را ندارید");
            int order=Values.Number(s.GetRow(rowIndex).Cells["SortOneEntry"].Value,0,short.MaxValue) ?? throw new ValidationException("ترتیب مضمون خالی است.");
            int[] allowed=HistoryGrades();historyBusy=true;Enabled=false;UseWaitCursor=true;
            await Task.Run(()=>new HistoryMarks(new Database(asdab.e())).SetSubjectOrder(book,order,allowed));historyOrders[book]=order;
        }
        catch(Exception error)
        {
            loadingHistory=true;
            try{if(rowIndex<s.RowCount)s.GetRow(rowIndex).Cells["SortOneEntry"].Value=original;}
            finally{loadingHistory=false;}
            MessageBox.Show("خطا در ترتیب مضمون:\n"+error.Message);
        }
        finally{Enabled=enabled;UseWaitCursor=wait;historyBusy=false;}
    }

}
