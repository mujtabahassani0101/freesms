using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdah : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private ComboBox m_e;

	private GroupBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private Label m_i;

	private UIComboBox m_j;

	private Label m_k;

	private UIComboBox m_l;

	private Label m_m;

	private UIComboBox m_n;

	private Label m_o;

	private OpenFileDialog m_p;

	private UIButton m_q;

	private Panel m_r;

	private UIButton m_s;

	private UIButton m_t;

	private Label m_u;

	private EditBox v;

	private UIButton w;

	private UIButton x;

	private GroupBox y;

	private UIButton z;

	private Panel aa;

	private UIButton ab;

	private UIButton ac;

	private UIButton ad;

	private UIButton ae;

	private UIButton af;

	private TextBox ag;

	private TextBox ah;

	private TextBox ai;

	private Button aj;

	private Button ak;

	private Button al;

	private TextBox am;

	private Button an;

	private TextBox ao;

	private Button ap;

	private TextBox aq;

	private Label ar;

	private TextBox @as;

	private Label at;

	private Button au;

	private Label av;

	private TextBox aw;

	private TextBox ax;

	private Label ay;

	private TextBox az;

	private Label a0;

	private Label a1;

	private DatePicker a2;

	private EditBox a3;

	private Label a4;

	private Button a5;

	private Label a6;

	private Label a7;

	public string a8 = "";
protected override void Dispose(bool A_0)
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
					if (A_0)
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
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						base.Dispose(A_0);
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

	private void f()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdah));
		StringFormat stringFormat = new StringFormat();
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		StringFormat stringFormat2 = new StringFormat();
		StringFormat stringFormat3 = new StringFormat();
		StringFormat stringFormat4 = new StringFormat();
		this.m_b = new Panel();
		a7 = new Label();
		a5 = new Button();
		a3 = new EditBox();
		a4 = new Label();
		this.m_q = new UIButton();
		this.m_g = new Label();
		w = new UIButton();
		y = new GroupBox();
		z = new UIButton();
		aa = new Panel();
		ab = new UIButton();
		ac = new UIButton();
		ad = new UIButton();
		ae = new UIButton();
		af = new UIButton();
		ag = new TextBox();
		ah = new TextBox();
		ai = new TextBox();
		aj = new Button();
		ak = new Button();
		al = new Button();
		am = new TextBox();
		an = new Button();
		ao = new TextBox();
		ap = new Button();
		aq = new TextBox();
		ar = new Label();
		@as = new TextBox();
		at = new Label();
		au = new Button();
		av = new Label();
		aw = new TextBox();
		ax = new TextBox();
		ay = new Label();
		az = new TextBox();
		a0 = new Label();
		a1 = new Label();
		a2 = new DatePicker();
		x = new UIButton();
		this.m_h = new UIComboBox();
		this.m_c = new Panel();
		this.m_f = new GroupBox();
		this.m_m = new Label();
		this.m_n = new UIComboBox();
		this.m_k = new Label();
		this.m_o = new Label();
		this.m_i = new Label();
		this.m_l = new UIComboBox();
		this.m_j = new UIComboBox();
		this.m_e = new ComboBox();
		a6 = new Label();
		this.m_r = new Panel();
		this.m_s = new UIButton();
		this.m_t = new UIButton();
		this.m_u = new Label();
		v = new EditBox();
		this.m_d = new Panel();
		this.m_p = new OpenFileDialog();
		this.m_b.SuspendLayout();
		y.SuspendLayout();
		aa.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_f.SuspendLayout();
		this.m_r.SuspendLayout();
		this.m_d.SuspendLayout();
		SuspendLayout();
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(a7);
		this.m_b.Controls.Add(a5);
		this.m_b.Controls.Add(a3);
		this.m_b.Controls.Add(a4);
		this.m_b.Controls.Add(this.m_q);
		this.m_b.Controls.Add(this.m_g);
		this.m_b.Controls.Add(w);
		this.m_b.Controls.Add(y);
		this.m_b.Controls.Add(x);
		this.m_b.Controls.Add(this.m_h);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(a6);
		this.m_b.Location = new Point(4, 5);
		this.m_b.Name = "panel2";
		this.m_b.Size = new Size(507, 313);
		this.m_b.TabIndex = 19;
		a7.AutoSize = true;
		a7.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a7.ForeColor = Color.DarkViolet;
		a7.Location = new Point(87, 3);
		a7.Name = "label2";
		a7.Size = new Size(355, 40);
		a7.TabIndex = 116;
		a7.Text = "دریافت الگوهای طراحی شده سایر مکاتب";
		a5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		a5.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a5.Location = new Point(11, 65);
		a5.Name = "btnSelectFile";
		a5.Size = new Size(197, 35);
		a5.TabIndex = 114;
		a5.Text = "انتخاب فایل الگو";
		a5.UseVisualStyleBackColor = true;
		a5.Click += a;
		a3.AutoScroll = false;
		a3.AutoScrollMargin = new Size(0, 0);
		a3.AutoScrollMinSize = new Size(0, 0);
		a3.AutoScrollPosition = new Point(0, 0);
		a3.Location = new Point(11, 106);
		a3.Name = "txtpath";
		a3.Size = new Size(487, 20);
		a3.TabIndex = 112;
		a3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		a4.AutoSize = true;
		a4.Font = new Font("Tahoma", 8.25f);
		a4.Location = new Point(407, 80);
		a4.Name = "label9";
		a4.Size = new Size(87, 13);
		a4.TabIndex = 113;
		a4.Text = "مسیر فایل اکسل";
		this.m_q.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_q.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_q.ImageSize = new Size(30, 30);
		this.m_q.Location = new Point(8, 211);
		this.m_q.Name = "btnNew";
		this.m_q.Size = new Size(156, 42);
		this.m_q.TabIndex = 107;
		this.m_q.Text = "ذخیره الگو در نرم افزار";
		this.m_q.Click += p;
		this.m_g.AutoSize = true;
		this.m_g.Font = new Font("B Nazanin", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_g.Location = new Point(155, 479);
		this.m_g.Name = "lBook";
		this.m_g.RightToLeft = RightToLeft.Yes;
		this.m_g.Size = new Size(40, 23);
		this.m_g.TabIndex = 37;
		this.m_g.Text = "درس :";
		this.m_g.TextAlign = ContentAlignment.MiddleCenter;
		w.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		w.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Image = (Image)componentResourceManager.GetObject("btnView.Image");
		w.ImageSize = new Size(40, 40);
		w.Location = new Point(7, 153);
		w.Name = "btnView";
		w.Size = new Size(158, 52);
		w.TabIndex = 109;
		w.Text = "پیش نمایش";
		w.Click += r;
		y.Controls.Add(z);
		y.Controls.Add(aa);
		y.Controls.Add(aq);
		y.Controls.Add(ar);
		y.Controls.Add(@as);
		y.Controls.Add(at);
		y.Controls.Add(au);
		y.Controls.Add(av);
		y.Controls.Add(aw);
		y.Controls.Add(ax);
		y.Controls.Add(ay);
		y.Controls.Add(az);
		y.Controls.Add(a0);
		y.Controls.Add(a1);
		y.Controls.Add(a2);
		y.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		y.Location = new Point(3, 381);
		y.Name = "groupBoxAzmoon";
		y.RightToLeft = RightToLeft.Yes;
		y.Size = new Size(495, 118);
		y.TabIndex = 14;
		y.TabStop = false;
		y.Text = "تنظیمات آزمون";
		y.Visible = false;
		z.Image = (Image)componentResourceManager.GetObject("btnCancel1.Image");
		z.Location = new Point(450, 89);
		z.Name = "btnCancel1";
		z.Size = new Size(30, 22);
		z.TabIndex = 45;
		z.Click += g;
		aa.Controls.Add(ab);
		aa.Controls.Add(ac);
		aa.Controls.Add(ad);
		aa.Controls.Add(ae);
		aa.Controls.Add(af);
		aa.Controls.Add(ag);
		aa.Controls.Add(ah);
		aa.Controls.Add(ai);
		aa.Controls.Add(aj);
		aa.Controls.Add(ak);
		aa.Controls.Add(al);
		aa.Controls.Add(am);
		aa.Controls.Add(an);
		aa.Controls.Add(ao);
		aa.Controls.Add(ap);
		aa.Location = new Point(6, 115);
		aa.Name = "pOtherPage";
		aa.Size = new Size(484, 134);
		aa.TabIndex = 44;
		aa.Visible = false;
		ab.Image = (Image)componentResourceManager.GetObject("btnCancel6.Image");
		ab.Location = new Point(444, 109);
		ab.Name = "btnCancel6";
		ab.Size = new Size(30, 22);
		ab.TabIndex = 58;
		ab.Click += b;
		ac.Image = (Image)componentResourceManager.GetObject("btnCancel5.Image");
		ac.Location = new Point(444, 83);
		ac.Name = "btnCancel5";
		ac.Size = new Size(30, 22);
		ac.TabIndex = 57;
		ac.Click += c;
		ad.Image = (Image)componentResourceManager.GetObject("btnCancel4.Image");
		ad.Location = new Point(444, 55);
		ad.Name = "btnCancel4";
		ad.Size = new Size(30, 22);
		ad.TabIndex = 56;
		ad.Click += d;
		ae.Image = (Image)componentResourceManager.GetObject("btnCancel3.Image");
		ae.Location = new Point(444, 29);
		ae.Name = "btnCancel3";
		ae.Size = new Size(30, 22);
		ae.TabIndex = 55;
		ae.Click += e;
		af.Image = (Image)componentResourceManager.GetObject("btnCancel2.Image");
		af.Location = new Point(444, 4);
		af.Name = "btnCancel2";
		af.Size = new Size(30, 22);
		af.TabIndex = 54;
		af.Click += f;
		ag.Enabled = false;
		ag.Location = new Point(98, 110);
		ag.Name = "txtadress6";
		ag.Size = new Size(340, 21);
		ag.TabIndex = 53;
		ah.Enabled = false;
		ah.Location = new Point(98, 83);
		ah.Name = "txtadress5";
		ah.Size = new Size(340, 21);
		ah.TabIndex = 52;
		ai.Enabled = false;
		ai.Location = new Point(98, 56);
		ai.Name = "txtadress4";
		ai.Size = new Size(340, 21);
		ai.TabIndex = 51;
		aj.Location = new Point(2, 107);
		aj.Name = "btnSelectPage6";
		aj.Size = new Size(89, 23);
		aj.TabIndex = 50;
		aj.Text = "صفحه 6";
		aj.UseVisualStyleBackColor = true;
		aj.Click += h;
		ak.Location = new Point(3, 81);
		ak.Name = "btnSelectPage5";
		ak.Size = new Size(89, 23);
		ak.TabIndex = 49;
		ak.Text = "صفحه 5";
		ak.UseVisualStyleBackColor = true;
		ak.Click += i;
		al.Location = new Point(2, 56);
		al.Name = "btnSelectPage4";
		al.Size = new Size(89, 23);
		al.TabIndex = 48;
		al.Text = "صفحه 4";
		al.UseVisualStyleBackColor = true;
		al.Click += j;
		am.Enabled = false;
		am.Location = new Point(98, 30);
		am.Name = "txtadress3";
		am.Size = new Size(340, 21);
		am.TabIndex = 47;
		an.Location = new Point(2, 29);
		an.Name = "btnSelectPage3";
		an.Size = new Size(89, 23);
		an.TabIndex = 46;
		an.Text = "صفحه 3";
		an.UseVisualStyleBackColor = true;
		an.Click += k;
		ao.Enabled = false;
		ao.Location = new Point(98, 4);
		ao.Name = "txtadress2";
		ao.Size = new Size(340, 21);
		ao.TabIndex = 45;
		ap.Location = new Point(2, 4);
		ap.Name = "btnSelectPage2";
		ap.Size = new Size(91, 23);
		ap.TabIndex = 44;
		ap.Text = "صفحه 2";
		ap.UseVisualStyleBackColor = true;
		ap.Click += l;
		aq.Location = new Point(13, 47);
		aq.MaxLength = 15;
		aq.Name = "txtStartExam";
		aq.Size = new Size(82, 21);
		aq.TabIndex = 23;
		ar.AutoSize = true;
		ar.Location = new Point(98, 51);
		ar.Name = "label11";
		ar.Size = new Size(76, 13);
		ar.TabIndex = 29;
		ar.Text = "ساعت شروع :";
		@as.Location = new Point(198, 46);
		@as.MaxLength = 10;
		@as.Name = "txtCountQus";
		@as.Size = new Size(60, 21);
		@as.TabIndex = 22;
		at.AutoSize = true;
		at.Location = new Point(264, 51);
		at.Name = "label1";
		at.Size = new Size(66, 13);
		at.TabIndex = 28;
		at.Text = "تعداد سوال :";
		au.Location = new Point(7, 90);
		au.Name = "btnSelectPage1";
		au.Size = new Size(94, 23);
		au.TabIndex = 27;
		au.Text = "انتخاب فایل";
		au.UseVisualStyleBackColor = true;
		au.Click += q;
		av.Location = new Point(311, 72);
		av.Name = "lQusText";
		av.Size = new Size(175, 14);
		av.TabIndex = 26;
		av.Text = "مسیر عکس سوالات صفحه اول";
		av.TextAlign = ContentAlignment.MiddleLeft;
		aw.Enabled = false;
		aw.Location = new Point(104, 89);
		aw.Name = "txtadress";
		aw.Size = new Size(340, 21);
		aw.TabIndex = 25;
		ax.Location = new Point(361, 46);
		ax.MaxLength = 10;
		ax.Name = "txtCountPage";
		ax.Size = new Size(57, 21);
		ax.TabIndex = 21;
		ay.AutoSize = true;
		ay.Location = new Point(422, 50);
		ay.Name = "label5";
		ay.Size = new Size(68, 13);
		ay.TabIndex = 23;
		ay.Text = "تعداد صفحه :";
		az.Location = new Point(14, 19);
		az.MaxLength = 50;
		az.Name = "txtTimeExam";
		az.Size = new Size(81, 21);
		az.TabIndex = 20;
		a0.AutoSize = true;
		a0.Location = new Point(102, 23);
		a0.Name = "label4";
		a0.Size = new Size(68, 13);
		a0.TabIndex = 21;
		a0.Text = "مدت امتحان :";
		a1.AutoSize = true;
		a1.Location = new Point(420, 22);
		a1.Name = "label3";
		a1.Size = new Size(68, 13);
		a1.TabIndex = 20;
		a1.Text = "تاریخ امتحان :";
		a2.AutoToday = true;
		a2.BackColor = Color.SeaShell;
		a2.BijanForeColor = Color.Blue;
		a2.Location = new Point(274, 16);
		a2.Name = "txtDateFrom";
		a2.Size = new Size(144, 24);
		a2.TabIndex = 19;
		a2.the_date = new DateTime(2020, 11, 8, 17, 15, 37, 603);
		a2.the_label = "ازمون تاريخ:";
		x.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		x.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		x.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		x.ImageSize = new Size(40, 40);
		x.Location = new Point(6, 258);
		x.Name = "btnClose";
		x.Size = new Size(159, 45);
		x.TabIndex = 111;
		x.Text = "بستن";
		x.Click += m;
		this.m_h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_h.DropListFont = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(7, 478);
		this.m_h.Name = "dropBook";
		this.m_h.RightToLeft = RightToLeft.Yes;
		this.m_h.Size = new Size(144, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		this.m_h.StringFormat = stringFormat;
		this.m_h.TabIndex = 36;
		this.m_c.Controls.Add(this.m_f);
		this.m_c.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_c.Location = new Point(163, 428);
		this.m_c.Name = "pClass";
		this.m_c.RightToLeft = RightToLeft.Yes;
		this.m_c.Size = new Size(336, 185);
		this.m_c.TabIndex = 103;
		this.m_f.Controls.Add(this.m_m);
		this.m_f.Controls.Add(this.m_n);
		this.m_f.Controls.Add(this.m_k);
		this.m_f.Controls.Add(this.m_o);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(this.m_l);
		this.m_f.Controls.Add(this.m_j);
		this.m_f.Controls.Add(this.m_e);
		this.m_f.Location = new Point(35, 41);
		this.m_f.Name = "groupBox2";
		this.m_f.Size = new Size(282, 124);
		this.m_f.TabIndex = 14;
		this.m_f.TabStop = false;
		this.m_f.Text = "انتخاب دانش آموزان برای چاپ";
		this.m_m.AutoSize = true;
		this.m_m.Location = new Point(201, 77);
		this.m_m.Name = "lStd";
		this.m_m.Size = new Size(53, 13);
		this.m_m.TabIndex = 106;
		this.m_m.Text = "دانش آموز";
		this.m_m.Visible = false;
		this.m_n.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_n.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "ترتیب";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "حوزه-شماره چوکی";
		uIComboBoxItem2.Value = "2";
		this.m_n.Items.AddRange(new UIComboBoxItem[2] { uIComboBoxItem, uIComboBoxItem2 });
		this.m_n.Location = new Point(12, 99);
		this.m_n.Name = "dropSort";
		this.m_n.Size = new Size(183, 21);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		this.m_n.StringFormat = stringFormat2;
		this.m_n.TabIndex = 109;
		this.m_k.AutoSize = true;
		this.m_k.Location = new Point(201, 51);
		this.m_k.Name = "label19";
		this.m_k.Size = new Size(30, 13);
		this.m_k.TabIndex = 105;
		this.m_k.Text = "صنف";
		this.m_o.AutoSize = true;
		this.m_o.Location = new Point(200, 104);
		this.m_o.Name = "lSort";
		this.m_o.Size = new Size(64, 13);
		this.m_o.TabIndex = 108;
		this.m_o.Text = "ترتیب نماش ";
		this.m_i.AutoSize = true;
		this.m_i.Location = new Point(201, 24);
		this.m_i.Name = "label20";
		this.m_i.Size = new Size(22, 13);
		this.m_i.TabIndex = 105;
		this.m_i.Text = "پایه";
		this.m_l.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_l.DropListFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_l.Location = new Point(13, 47);
		this.m_l.Name = "dropClass";
		this.m_l.Size = new Size(183, 21);
		stringFormat3.Alignment = StringAlignment.Near;
		stringFormat3.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat3.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat3.LineAlignment = StringAlignment.Center;
		stringFormat3.Trimming = StringTrimming.Character;
		this.m_l.StringFormat = stringFormat3;
		this.m_l.TabIndex = 104;
		this.m_l.SelectedIndexChanged += t;
		this.m_j.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		this.m_j.DropListFont = new Font("Rod", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_j.Location = new Point(13, 20);
		this.m_j.Name = "dropPaye";
		this.m_j.Size = new Size(183, 21);
		stringFormat4.Alignment = StringAlignment.Near;
		stringFormat4.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat4.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat4.LineAlignment = StringAlignment.Center;
		stringFormat4.Trimming = StringTrimming.Character;
		this.m_j.StringFormat = stringFormat4;
		this.m_j.TabIndex = 104;
		this.m_j.SelectedIndexChanged += s;
		this.m_e.DropDownStyle = ComboBoxStyle.DropDownList;
		this.m_e.FormattingEnabled = true;
		this.m_e.Location = new Point(13, 73);
		this.m_e.Name = "dropStd";
		this.m_e.Size = new Size(183, 21);
		this.m_e.TabIndex = 3;
		this.m_e.Visible = false;
		a6.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		a6.Location = new Point(185, 186);
		a6.Name = "ltype";
		a6.RightToLeft = RightToLeft.Yes;
		a6.Size = new Size(299, 96);
		a6.TabIndex = 115;
		a6.TextAlign = ContentAlignment.MiddleCenter;
		this.m_r.BackColor = Color.FromArgb(214, 223, 247);
		this.m_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_r.Controls.Add(this.m_s);
		this.m_r.Controls.Add(this.m_t);
		this.m_r.Controls.Add(this.m_u);
		this.m_r.Controls.Add(v);
		this.m_r.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_r.Location = new Point(173, 150);
		this.m_r.Name = "pNew";
		this.m_r.RightToLeft = RightToLeft.Yes;
		this.m_r.Size = new Size(327, 116);
		this.m_r.TabIndex = 108;
		this.m_r.Visible = false;
		this.m_s.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		this.m_s.Location = new Point(40, 67);
		this.m_s.Name = "btnCancel";
		this.m_s.Size = new Size(75, 32);
		this.m_s.TabIndex = 16;
		this.m_s.Text = "انصراف";
		this.m_s.Click += o;
		this.m_t.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		this.m_t.Location = new Point(121, 67);
		this.m_t.Name = "btnAcp";
		this.m_t.Size = new Size(75, 32);
		this.m_t.TabIndex = 14;
		this.m_t.Text = "تایید";
		this.m_t.Click += n;
		this.m_u.Location = new Point(228, 22);
		this.m_u.Name = "label8";
		this.m_u.Size = new Size(86, 28);
		this.m_u.TabIndex = 1;
		this.m_u.Text = "عنوان الگو";
		this.m_u.TextAlign = ContentAlignment.MiddleRight;
		v.AutoScroll = false;
		v.AutoScrollMargin = new Size(0, 0);
		v.AutoScrollMinSize = new Size(0, 0);
		v.AutoScrollPosition = new Point(0, 0);
		v.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		v.Location = new Point(13, 19);
		v.Name = "txtNam";
		v.Size = new Size(211, 33);
		v.TabIndex = 0;
		v.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.BackColor = SystemColors.ControlText;
		this.m_d.Controls.Add(this.m_b);
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "panel4";
		this.m_d.Size = new Size(515, 323);
		this.m_d.TabIndex = 20;
		this.m_p.Filter = "الگوی طراحی 20 (*.rpx)| *.rpx";
		this.m_p.Title = "فایل عکس صفحه اول سوالات امتحان";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.InactiveCaptionText;
		ClientSize = new Size(515, 323);
		Controls.Add(this.m_r);
		Controls.Add(this.m_d);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmImportSarbargFile";
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "سربرگ";
		Load += u;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		y.ResumeLayout(performLayout: false);
		y.PerformLayout();
		aa.ResumeLayout(performLayout: false);
		aa.PerformLayout();
		this.m_c.ResumeLayout(performLayout: false);
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		this.m_r.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdah()
	{
		f();
	}

	private void e()
	{
		if (true)
		{
		}
		File.Copy(a3.Text, Application.StartupPath + "\\1000.rpx", overwrite: true);
		string text = Application.StartupPath + "\\1000.rpx";
	}

	private void u(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = asdaj.a("12");
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
					d();
					c();
					a();
					this.m_n.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					if (true)
					{
					}
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(SELECT DISTINCT xPaye FROM tYear_Student where xYear=" + asdaj.__field_a + ") order by id");
			this.m_j.DataSource = dataSource;
			this.m_j.DisplayMember = "Name";
			this.m_j.ValueMember = "id";
			bool flag = this.m_j.Items.Count <= 0;
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
					return;
				case 2:
					if (true)
					{
					}
					this.m_j.SelectedIndex = 0;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			string text = "  where  xYear=" + asdaj.__field_a;
			bool flag = this.m_j.SelectedIndex < 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
						continue;
					}
					goto case 1;
				case 2:
					this.m_l.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
					return;
				case 1:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'تمام صنف ها' as  name\r\n                                                                                                                union select id,name from tClass" + text);
					this.m_l.DataSource = dataSource;
					this.m_l.DisplayMember = "Name";
					this.m_l.ValueMember = "id";
					flag = this.m_l.Items.Count <= 0;
					num = 3;
					continue;
				}
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 5:
				{
					string text2 = text;
					text = text2 + " and id in(SELECT DISTINCT xClass FROM tYear_Student where xYear=" + asdaj.__field_a + " and (xPaye = " + this.m_j.SelectedValue.ToString() + "))";
					num = 1;
					continue;
				}
				}
				break;
			}
		}
	}

	private void b()
	{
		Dictionary<string, string> dictionary = default;
		DataTable dataTable = default;
		int num2 = default;
		while (true)
		{
			bool flag = this.m_l.SelectedIndex < 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 13:
					flag = dictionary.Count != 0;
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 3;
						continue;
					}
					this.m_e.DataSource = new BindingSource(dictionary, null);
					this.m_e.DisplayMember = "Value";
					this.m_e.ValueMember = "Key";
					num = 5;
					continue;
				case 11:
					this.m_e.Visible = false;
					this.m_m.Visible = false;
					this.m_e.DataSource = null;
					num = 12;
					continue;
				case 12:
					return;
				case 0:
					flag = !(this.m_l.SelectedValue.ToString() == "0");
					num = 4;
					continue;
				case 4:
				{
					if (!flag)
					{
						num = 11;
						continue;
					}
					this.m_e.Visible = true;
					this.m_m.Visible = true;
					string a_ = "select tStudent.id,tStudent.lname + N' - '+ tStudent.fname as name  from tstudent inner join \r\n                                 tYear_Student on tStudent.id=tYear_Student.xStudent where tYear_Student.status=1 and tYear_Student.xYear=" + asdaj.__field_a + " and tYear_Student.xclass= " + this.m_l.SelectedValue.ToString() + " order by tYear_Student.sort,tStudent.lname,tStudent.fname,tStudent.id";
					dictionary = new Dictionary<string, string>();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count <= 1;
					num = 10;
					continue;
				}
				case 3:
					this.m_e.DataSource = null;
					MessageBox.Show("دانش آموزی در این صنف وجود ندارد");
					num = 6;
					continue;
				case 5:
				case 6:
					num = 16;
					continue;
				case 16:
					return;
				case 1:
					num2 = 0;
					num = 2;
					continue;
				case 10:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 1;
				case 2:
				case 9:
					flag = num2 < dataTable.Rows.Count;
					num = 7;
					continue;
				case 7:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						if (true)
						{
						}
						num = 9;
					}
					else
					{
						num = 13;
					}
					continue;
				case 15:
					dictionary.Add("0", "تمام دانش آموزان صنف");
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			bool flag = this.m_j.SelectedIndex < 0;
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
					this.m_h.DataSource = null;
					num = 6;
					continue;
				case 5:
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					this.m_h.SelectedIndex = 0;
					num = 5;
					continue;
				case 4:
				{
					if (true)
					{
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'انتخاب کنید' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from tbook where xPaye=" + this.m_j.SelectedValue.ToString());
					this.m_h.DataSource = dataSource;
					this.m_h.DisplayMember = "Name";
					this.m_h.ValueMember = "id";
					flag = this.m_h.Items.Count <= 0;
					num = 1;
					continue;
				}
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		b();
	}

	private void s(object A_0, EventArgs A_1)
	{
		c();
		a();
	}

	private void r(object A_0, EventArgs A_1)
	{
		string value = default;
		string value2 = default;
		SqlConnection sqlConnection = default;
		DataSet dataSet = default;
		string cmdText = default;
		while (true)
		{
			bool flag = !(a3.Text == "");
			int num = 14;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 14:
					if (!flag)
					{
						num = 6;
						continue;
					}
					value = "0";
					value2 = "0";
					flag = this.m_j.SelectedIndex < 0;
					num = 18;
					continue;
				case 17:
					num2 = 1;
					goto IL_0326;
				case 2:
					sqlConnection = new SqlConnection(asdab.e());
					sqlConnection.Open();
					dataSet = new DataSet();
					cmdText = "sp_SelectStdForSarbarg_Test_Type1";
					num = 21;
					continue;
				case 21:
					num = ((a8 != "1") ? 20 : 17);
					continue;
				case 1:
					return;
				case 22:
				{
					if (true)
					{
					}
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@type", value);
					sqlCommand.Parameters.AddWithValue("@code", value2);
					sqlCommand.Parameters.AddWithValue("@sort", this.m_n.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@xBook", this.m_h.SelectedValue.ToString());
					sqlCommand.Parameters.AddWithValue("@DateExam", ShamsiDate.GetShamsiDate(a2.the_date));
					sqlCommand.Parameters.AddWithValue("@TimeExam", az.Text);
					sqlCommand.Parameters.AddWithValue("@CountPageExam", ax.Text);
					sqlCommand.Parameters.AddWithValue("@CountQusExam", @as.Text);
					sqlCommand.Parameters.AddWithValue("@StartExam", aq.Text);
					sqlCommand.Parameters.AddWithValue("@xYear", asdaj.__field_a);
					sqlCommand.Parameters.AddWithValue("@formType", a8);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(dataSet, "v_data");
					sqlConnection.Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 19;
					continue;
				}
				case 19:
				{
					if (!flag)
					{
						num = 13;
						continue;
					}
					e();
					asdbp asdbp2 = new asdbp();
					asdbp2.a(dataSet, dataSet.Tables[0].TableName, aw.Text, ao.Text, am.Text, ai.Text, ah.Text, ag.Text);
					asdbp2.ShowDialog();
					asdbp2.Dispose();
					num = 10;
					continue;
				}
				case 18:
					if (flag)
					{
						MessageBox.Show("پایه ای انتخاب نشده است");
						num = 1;
					}
					else
					{
						num = 0;
					}
					continue;
				case 9:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 22;
				case 13:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 16;
					continue;
				case 16:
					return;
				case 5:
					num = 2;
					continue;
				case 15:
					flag = this.m_l.SelectedIndex < 0;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					MessageBox.Show("صنفی ای انتخاب نشده است");
					num = 24;
					continue;
				case 7:
					cmdText = "sp_SelectStdForSarbarg_Test_Type2";
					num = 22;
					continue;
				case 10:
					return;
				case 3:
					flag = !(this.m_l.SelectedValue.ToString() != "0");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 23;
						continue;
					}
					goto case 5;
				case 6:
					MessageBox.Show("الگویی انتخاب نشده است");
					num = 12;
					continue;
				case 12:
					return;
				case 0:
					value = "1";
					value2 = this.m_j.SelectedValue.ToString();
					num = 15;
					continue;
				case 23:
					value = "2";
					value2 = this.m_l.SelectedValue.ToString();
					num = 5;
					continue;
				case 24:
					return;
				case 20:
					num = 11;
					continue;
				case 11:
					{
						num2 = ((!(a8 != "5")) ? 1 : 0);
						goto IL_0326;
					}
					IL_0326:
					flag = (byte)num2 != 0;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_p.ShowDialog() != DialogResult.OK;
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
					return;
				case 2:
					aw.Text = this.m_p.FileName;
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(a3.Text == "");
			int num = 3;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					this.m_b.Enabled = false;
					this.m_r.Visible = true;
					v.Text = "";
					v.Focus();
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					MessageBox.Show("الگویی انتخاب نشده است");
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_b.Enabled = true;
		this.m_r.Visible = false;
	}

	private void n(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(v.Text.Trim() == "");
			if (true)
			{
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 2;
						continue;
					}
					FileStream fileStream = File.OpenRead(a3.Text);
					byte[] array = new byte[fileStream.Length];
					fileStream.ReadExactly(array, 0, (int)fileStream.Length);
					fileStream.Close();
					string a_ = v.Text;
					SqlParameter[] a_2 = new SqlParameter[3]
					{
						asdcb.a("@Rpt", SqlDbType.Image, array),
						asdcb.a("@type", SqlDbType.Int, a8),
						asdcb.a("@Caption", SqlDbType.NVarChar, 200, a_)
					};
					asdcb.d(asdab.e(), CommandType.Text, "declare @idAdd int\r\n                        select @idAdd=isnull (max(id)+1,1001) from tRptDynamic where id>100\r\n                        INSERT into tRptDynamic (id, Caption, Rpt, sys, type) \r\n                        values (@idAdd,@Caption,@Rpt,0,@type)", a_2);
					asdt asdt2 = new asdt();
					asdt2.bx = a8;
					asdt2.ShowDialog();
					Close();
					this.m_b.Enabled = true;
					this.m_r.Visible = false;
					num = 3;
					continue;
				}
				case 3:
					return;
				case 2:
					MessageBox.Show("عنوان الگو جدید را وارد کنید");
					v.Focus();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		Close();
	}

	private string a(string A_0)
	{
		string result = default;
		while (true)
		{
			string text = "";
			bool flag = !(A_0 == "kbrqazwsx");
			int num = 10;
			while (true)
			{
				switch (num)
				{
				case 10:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = !(A_0 == "kbredcrfv");
					num = 2;
					continue;
				case 12:
					text += "5";
					num = 3;
					continue;
				case 0:
					text = "4";
					num = 6;
					continue;
				case 5:
					text = "2";
					num = 9;
					continue;
				case 4:
					if (true)
					{
					}
					text = "6";
					num = 13;
					continue;
				case 2:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(A_0 == "kbrtgbyhn");
					num = 17;
					continue;
				case 14:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(A_0 == "kbrtfcefv");
					num = 16;
					continue;
				case 1:
				case 3:
				case 6:
				case 9:
				case 11:
				case 13:
					result = text;
					num = 18;
					continue;
				case 7:
					text = "3";
					num = 11;
					continue;
				case 8:
					text = "1";
					num = 1;
					continue;
				case 16:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 15:
					if (flag)
					{
						flag = !(A_0 == "kbrolpkio");
						num = 14;
					}
					else
					{
						num = 0;
					}
					continue;
				case 17:
					if (flag)
					{
						flag = !(A_0 == "kbrujmiko");
						num = 15;
					}
					else
					{
						num = 7;
					}
					continue;
				case 18:
					return result;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_p.ShowDialog() != DialogResult.OK;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					ao.Text = this.m_p.FileName;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			bool flag = this.m_p.ShowDialog() != DialogResult.OK;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					am.Text = this.m_p.FileName;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_p.ShowDialog() != DialogResult.OK;
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
					return;
				case 1:
					ai.Text = this.m_p.FileName;
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_p.ShowDialog() != DialogResult.OK;
			if (true)
			{
			}
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					ah.Text = this.m_p.FileName;
					num = 0;
					continue;
				case 0:
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
			bool flag = this.m_p.ShowDialog() != DialogResult.OK;
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
					ag.Text = this.m_p.FileName;
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

	private void g(object A_0, EventArgs A_1)
	{
		aw.Text = "";
	}

	private void f(object A_0, EventArgs A_1)
	{
		ao.Text = "";
	}

	private void e(object A_0, EventArgs A_1)
	{
		am.Text = "";
	}

	private void d(object A_0, EventArgs A_1)
	{
		ai.Text = "";
	}

	private void c(object A_0, EventArgs A_1)
	{
		ah.Text = "";
	}

	private void b(object A_0, EventArgs A_1)
	{
		ag.Text = "";
	}

	private void a(object A_0, EventArgs A_1)
	{
		string text = default;
		string[] array = default;
		while (true)
		{
			bool flag = DialogResult.OK != this.m_p.ShowDialog();
			int num = 20;
			while (true)
			{
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 10;
						continue;
					}
					return;
				case 12:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					a8 = "";
					a3.Text = "";
					MessageBox.Show("فایل انتخاب شده اشتباه است");
					num = 3;
					continue;
				case 21:
					if (flag)
					{
						flag = !(text == "6");
						num = 12;
					}
					else
					{
						num = 11;
					}
					continue;
				case 7:
					if (!flag)
					{
						num = 24;
						continue;
					}
					flag = !(text == "3");
					num = 4;
					continue;
				case 2:
				case 9:
				case 17:
				case 22:
				case 23:
				case 25:
					num = 1;
					continue;
				case 0:
					text = a(array[0]);
					flag = !(text == "1");
					num = 19;
					continue;
				case 19:
					if (flag)
					{
						flag = !(text == "2");
						num = 7;
					}
					else
					{
						num = 15;
					}
					continue;
				case 5:
					a8 = "6";
					a6.Text = "طراحی کارت تبریک تولد";
					num = 25;
					continue;
				case 14:
					return;
				case 18:
					if (flag)
					{
						flag = !(text == "5");
						num = 21;
					}
					else
					{
						num = 13;
					}
					continue;
				case 24:
					a8 = "2";
					a6.Text = "طراحی دعوت نامه و ...";
					num = 9;
					continue;
				case 3:
					return;
				case 1:
					num = 6;
					continue;
				case 6:
					return;
				case 4:
					if (flag)
					{
						flag = !(text == "4");
						num = 18;
					}
					else
					{
						num = 16;
					}
					continue;
				case 10:
				{
					a3.Text = this.m_p.FileName;
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this.m_p.FileName);
					array = fileNameWithoutExtension.Split('-');
					flag = array.Length <= 0;
					num = 8;
					continue;
				}
				case 8:
					if (flag)
					{
						a6.Text = "";
						a3.Text = "";
						MessageBox.Show("فایل انتخاب شده اشتباه است");
						num = 14;
					}
					else
					{
						num = 0;
					}
					continue;
				case 15:
					a8 = "1";
					a6.Text = "طراحی سربرگ امتحانی تک صفحه";
					num = 22;
					continue;
				case 16:
					a8 = "3";
					a6.Text = "طراحی فرم(تعهدنامه انضباطی و ...)";
					num = 23;
					continue;
				case 13:
					a8 = "4";
					a6.Text = "طراحی کارت دانش آموزی و ...";
					num = 17;
					continue;
				case 11:
					a8 = "5";
					a6.Text = "طراحی سربرگ امتحانی چند صفحه ای";
					num = 2;
					continue;
				}
				break;
			}
		}
	}
}
