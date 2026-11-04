using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeSms.Core;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using school_Af.Properties;

public class asdbd : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private Label m_e;

	private GroupBox m_f;

	private TextBox g;

	private Label h;

	private Button i;

	private Label j;

	private UIComboBox k;

	private CheckBox l;

	private Button m;

	private UIGroupBox n;

	private Label o;

	private NumericEditBox p;

	private NumericEditBox q;

	private Label r;

	public Label s;

	public Label t;

	public Label u;

	public Label v;

	private Label w;

	private Label x;

	private Label y;

	private Label z;

	private UIButton aa;

	private GridEX ab;

	private Label ac;

	private Label ad;

	private Label ae;

	public string af;

	public string ag;

	public string ah;

	public string ai;

	public string aj;

	public string ak;

	private bool savingMarks;
	private bool updatingRowState;
	private readonly Dictionary<int,object> savedOrders = new Dictionary<int,object>();

	private bool am = true;

protected override void Dispose(bool A_0)
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 0;
					}
					continue;
				case 1:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 3;
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
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbd));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		ac = new Label();
		o = new Label();
		this.m_e = new Label();
		p = new NumericEditBox();
		this.m_f = new GroupBox();
		g = new TextBox();
		h = new Label();
		i = new Button();
		q = new NumericEditBox();
		r = new Label();
		l = new CheckBox();
		j = new Label();
		m = new Button();
		k = new UIComboBox();
		n = new UIGroupBox();
		ad = new Label();
		ae = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new UIButton();
		ab = new GridEX();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		this.m_f.SuspendLayout();
		((ISupportInitialize)n).BeginInit();
		n.SuspendLayout();
		((ISupportInitialize)ab).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(800, 600);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(798, 598);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(ac);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(r);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(aa);
		this.m_d.Controls.Add(ab);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(792, 592);
		this.m_d.TabIndex = 0;
		ac.Enabled = false;
		ac.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		ac.ForeColor = Color.Red;
		ac.Location = new Point(546, 339);
		ac.Name = "lMark100";
		ac.Size = new Size(213, 68);
		ac.TabIndex = 51;
		ac.Text = "فقط شاگردانی که تیک مربوط به ورود نمره سالانه از 100 دارند در این بخش نمایش داده می شود";
		ac.Visible = false;
		o.AutoSize = true;
		o.Enabled = false;
		o.Location = new Point(685, 499);
		o.Name = "label4";
		o.Size = new Size(27, 26);
		o.TabIndex = 37;
		o.Text = "تا :";
		this.m_e.AutoSize = true;
		this.m_e.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_e.ForeColor = Color.DarkViolet;
		this.m_e.Location = new Point(575, 6);
		this.m_e.Name = "label7";
		this.m_e.Size = new Size(134, 33);
		this.m_e.TabIndex = 50;
		this.m_e.Text = "ورود نمرات دوره";
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.Enabled = false;
		p.Location = new Point(627, 496);
		p.Name = "txtMaxMark";
		p.Size = new Size(52, 33);
		p.TabIndex = 36;
		p.Text = "100";
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		p.Value = (short)100;
		p.ValueType = NumericEditValueType.Int16;
		this.m_f.Controls.Add(g);
		this.m_f.Controls.Add(h);
		this.m_f.Controls.Add(i);
		this.m_f.Font = new Font("B Nazanin", 10f);
		this.m_f.Location = new Point(510, 268);
		this.m_f.Name = "groupBox1";
		this.m_f.Size = new Size(262, 54);
		this.m_f.TabIndex = 49;
		this.m_f.TabStop = false;
		this.m_f.Text = "وارد کردن نمرات یکسان";
		g.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Location = new Point(110, 23);
		g.MaxLength = 3;
		g.Name = "txtmarkAll";
		g.Size = new Size(64, 23);
		g.TabIndex = 43;
		h.AutoSize = true;
		h.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		h.Location = new Point(178, 21);
		h.Name = "label6";
		h.Size = new Size(41, 26);
		h.TabIndex = 42;
		h.Text = "نمره :";
		i.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		i.Location = new Point(24, 19);
		i.Name = "btnMarkAll";
		i.Size = new Size(72, 30);
		i.TabIndex = 41;
		i.Text = "ثبت";
		i.UseVisualStyleBackColor = true;
		i.Click += b;
		q.AutoScroll = false;
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		q.AutoScrollPosition = new Point(0, 0);
		q.Enabled = false;
		q.Location = new Point(627, 457);
		q.Name = "txtMinMark";
		q.Size = new Size(52, 33);
		q.TabIndex = 35;
		q.Text = "0";
		q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.Value = (short)0;
		q.ValueType = NumericEditValueType.Int16;
		r.AutoSize = true;
		r.Enabled = false;
		r.Location = new Point(685, 460);
		r.Name = "label3";
		r.Size = new Size(76, 26);
		r.TabIndex = 34;
		r.Text = "رنج نمره از :";
		l.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		l.AutoSize = true;
		l.Location = new Point(540, 410);
		l.Name = "checkBox1";
		l.Size = new Size(225, 30);
		l.TabIndex = 48;
		l.Text = "فعال کردن ستون ترتیب برای اصلاح";
		l.UseVisualStyleBackColor = true;
		l.Visible = false;
		l.CheckedChanged += c;
		j.AutoSize = true;
		j.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		j.Location = new Point(719, 552);
		j.Name = "label5";
		j.Size = new Size(51, 26);
		j.TabIndex = 38;
		j.Text = "ستون :";
		j.Visible = false;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
		m.Image = Resources._4160;
		m.ImageAlign = ContentAlignment.MiddleRight;
		m.Location = new Point(290, 551);
		m.Name = "btnSaveMark";
		m.Size = new Size(197, 35);
		m.TabIndex = 47;
		m.Text = "ثبت نمرات(F5)";
		m.UseVisualStyleBackColor = true;
		m.Click += d;
		k.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		k.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "نمره 1";
		uIComboBoxItem.Value = "m1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "نمره 2";
		uIComboBoxItem2.Value = "m2";
		uIComboBoxItem3.FormatStyle.Alpha = 0;
		uIComboBoxItem3.Text = "نمره 3";
		uIComboBoxItem3.Value = "m3";
		uIComboBoxItem4.FormatStyle.Alpha = 0;
		uIComboBoxItem4.Text = "نمره 4";
		uIComboBoxItem4.Value = "m4";
		uIComboBoxItem5.FormatStyle.Alpha = 0;
		uIComboBoxItem5.Text = "نمره 5";
		uIComboBoxItem5.Value = "m5";
		uIComboBoxItem6.FormatStyle.Alpha = 0;
		uIComboBoxItem6.Text = "نمره 6";
		uIComboBoxItem6.Value = "m6";
		uIComboBoxItem7.FormatStyle.Alpha = 0;
		uIComboBoxItem7.Text = "نمره 7";
		uIComboBoxItem7.Value = "m7";
		uIComboBoxItem8.FormatStyle.Alpha = 0;
		uIComboBoxItem8.Text = "نمره 8";
		uIComboBoxItem8.Value = "m8";
		k.Items.AddRange(new UIComboBoxItem[8] { uIComboBoxItem, uIComboBoxItem2, uIComboBoxItem3, uIComboBoxItem4, uIComboBoxItem5, uIComboBoxItem6, uIComboBoxItem7, uIComboBoxItem8 });
		k.Location = new Point(664, 552);
		k.Name = "dropMarkAll";
		k.Size = new Size(49, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		k.StringFormat = stringFormat;
		k.TabIndex = 40;
		k.Visible = false;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		n.Controls.Add(ad);
		n.Controls.Add(ae);
		n.Controls.Add(s);
		n.Controls.Add(t);
		n.Controls.Add(u);
		n.Controls.Add(v);
		n.Controls.Add(w);
		n.Controls.Add(x);
		n.Controls.Add(y);
		n.Controls.Add(z);
		n.Location = new Point(493, 39);
		n.Name = "uiGroupBox1";
		n.Size = new Size(288, 223);
		n.TabIndex = 46;
		ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ad.Location = new Point(139, 21);
		ad.Name = "lYear";
		ad.Size = new Size(55, 24);
		ad.TabIndex = 119;
		ad.TextAlign = ContentAlignment.MiddleCenter;
		ae.AutoSize = true;
		ae.Location = new Point(198, 20);
		ae.Name = "label8";
		ae.Size = new Size(78, 26);
		ae.TabIndex = 118;
		ae.Text = "سال تعلیمی";
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		s.Location = new Point(11, 135);
		s.Name = "lExam";
		s.Size = new Size(183, 33);
		s.TabIndex = 33;
		s.TextAlign = ContentAlignment.MiddleCenter;
		t.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		t.Location = new Point(11, 96);
		t.Name = "lClass";
		t.Size = new Size(183, 33);
		t.TabIndex = 32;
		t.TextAlign = ContentAlignment.MiddleCenter;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		u.Location = new Point(11, 179);
		u.Name = "lBook";
		u.Size = new Size(183, 33);
		u.TabIndex = 31;
		u.TextAlign = ContentAlignment.MiddleCenter;
		v.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		v.Location = new Point(11, 56);
		v.Name = "lPaye";
		v.Size = new Size(183, 33);
		v.TabIndex = 30;
		v.TextAlign = ContentAlignment.MiddleCenter;
		w.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		w.AutoSize = true;
		w.Location = new Point(200, 139);
		w.Name = "label2";
		w.Size = new Size(43, 26);
		w.TabIndex = 29;
		w.Text = "دوره :";
		x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		x.AutoSize = true;
		x.Location = new Point(198, 182);
		x.Name = "label1";
		x.Size = new Size(46, 26);
		x.TabIndex = 27;
		x.Text = "درس :";
		y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		y.AutoSize = true;
		y.Location = new Point(200, 100);
		y.Name = "label19";
		y.Size = new Size(47, 26);
		y.TabIndex = 25;
		y.Text = "صنف :";
		z.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		z.AutoSize = true;
		z.Location = new Point(198, 59);
		z.Name = "label20";
		z.Size = new Size(79, 26);
		z.TabIndex = 15;
		z.Text = "صنف اصلی :";
		z.TextAlign = ContentAlignment.MiddleLeft;
		aa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		aa.DialogResult = DialogResult.Cancel;
		aa.CausesValidation = false;
		aa.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		aa.ImageSize = new Size(40, 40);
		aa.Location = new Point(11, 552);
		aa.Name = "btnClose";
		aa.Size = new Size(189, 35);
		aa.TabIndex = 44;
		aa.Text = "بستن";
		aa.Click += e;
		ab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		ab.DesignTimeLayout = gridEXLayout;
		ab.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		ab.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		ab.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		ab.GroupByBoxVisible = false;
		ab.Location = new Point(8, 8);
		ab.Name = "gridEX1";
		ab.RecordNavigator = true;
		ab.RowHeaders = InheritableBoolean.True;
		ab.SelectedFormatStyle.BackColor = Color.Empty;
		ab.SelectedFormatStyle.ForeColor = Color.Empty;
		ab.Size = new Size(479, 537);
		ab.TabIndex = 45;
		ab.VisualStyle = VisualStyle.Office2003;
		ab.SelectionChanged += a;
		ab.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmMarkEntry";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += f;
		KeyUp += a;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		((ISupportInitialize)n).EndInit();
		n.ResumeLayout(performLayout: false);
		n.PerformLayout();
		((ISupportInitialize)ab).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdbd()
	{
		b();
	}

	private void f(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 14;
			while (true)
			{
				switch (num)
				{
				case 14:
					if (!flag)
					{
						num = 12;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 2;
					continue;
				case 8:
					ab.Tables[0].Columns["countAb"].Visible = false;
					ac.Visible = true;
					p.Text = "100";
					num = 0;
					continue;
				case 11:
					if (!flag)
					{
						num = 3;
						continue;
					}
					flag = !(ak == "3");
					num = 6;
					continue;
				case 1:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 13;
					continue;
				case 7:
					try
					{
						ab.CurrentColumn = ab.GetRow(0).Cells["m1"].Column;
						ab.Select();
						ab.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 9;
					continue;
				case 2:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 13;
				case 6:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 0;
				case 9:
					return;
				case 16:
					ab.Tables[0].Columns["countAb"].Visible = false;
					p.Text = "40";
					num = 17;
					continue;
				case 10:
					num = 1;
					continue;
				case 0:
				case 15:
				case 17:
					a();
					num = 7;
					continue;
				case 12:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					if (true)
					{
					}
					num = 4;
					continue;
				case 4:
					return;
				case 13:
					ad.Text = aj;
					am = true;
					flag = !(ak == "1");
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						flag = !(ak == "2");
						num = 11;
					}
					else
					{
						num = 16;
					}
					continue;
				case 3:
					ab.Tables[0].Columns["countAb"].Visible = false;
					p.Text = "60";
					num = 15;
					continue;
				}
				break;
			}
		}
	}

    private void a()
    {
        int year=int.Parse(aj),grade=int.Parse(ag),classroom=int.Parse(af),exam=int.Parse(ah),book=int.Parse(ai),term=int.Parse(ak);
        if(!asdaj.n.Split(',').Any(value=>int.TryParse(value,out int allowed) && allowed==grade))
        {MessageBox.Show("اجازهٔ ثبت نمره برای این پایه را ندارید.");Close();return;}
        string first=term==3?"tmpMark.Mark AS M1,NULL AS M2":"tmpMark.M1,tmpMark.M2";
        var data=asdcb.c(asdab.e(),CommandType.Text,
            "SELECT 0 AS acp,tStudent.id,tStudent.NumberAsas,tYear_Student.sort,tStudent.Code,tStudent.FName,tStudent.LName,tStudent.PName,tmpMark.CountAb,"+first+",tmpMark.M3,tmpMark.M4,tmpMark.M5,tmpMark.M6,tmpMark.M7,tmpMark.M8,tmpMark.M9,tmpMark.M10 FROM tStudent INNER JOIN tYear_Student ON tStudent.id=tYear_Student.xStudent LEFT JOIN tMark tmpMark ON tStudent.id=tmpMark.xStudent AND tmpMark.Xtest=@Exam AND tmpMark.xbook=@Book WHERE tYear_Student.xYear=@Year AND tYear_Student.xPaye=@Grade AND (@Class=0 OR tYear_Student.xClass=@Class) AND tYear_Student.Status IN(1,4) AND (@Term NOT IN(1,2,3) OR tYear_Student.MarkTerm3_From100=CASE WHEN @Term=3 THEN 1 ELSE 0 END) ORDER BY tYear_Student.sort,tStudent.LName,tStudent.FName,tStudent.id",
            new[]{asdcb.a("@Year",SqlDbType.Int,year),asdcb.a("@Grade",SqlDbType.Int,grade),asdcb.a("@Class",SqlDbType.Int,classroom),asdcb.a("@Exam",SqlDbType.Int,exam),asdcb.a("@Book",SqlDbType.Int,book),asdcb.a("@Term",SqlDbType.Int,term)});
        savedOrders.Clear();
        foreach(DataRow row in data.Rows)savedOrders[Convert.ToInt32(row["id"])]=row["sort"];
        ab.DataSource=data;
        foreach(var item in new[]{(1,Color.FromArgb(0,200,0)),(-1,Color.FromArgb(250,0,150))})
        {
            var condition=new GridEXFormatCondition(ab.RootTable.Columns["acp"],ConditionOperator.Equal,item.Item1.ToString());
            condition.FormatStyle.ForeColor=SystemColors.WindowText;condition.FormatStyle.BackColor=item.Item2;
            ab.RootTable.FormatConditions.Add(condition);
        }
        am=true;
    }

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

    private async void d(object sender,EventArgs args)
    {
        if(savingMarks || !ab.TryEndEdit() || savingMarks)return;
        int year=int.Parse(aj),grade=int.Parse(ag),classroom=int.Parse(af),exam=int.Parse(ah),book=int.Parse(ai),term=int.Parse(ak);
        var entries=new List<BulkMark>();
        try
        {
            if(!asdaj.a("3") || !asdaj.n.Split(',').Any(value=>int.TryParse(value,out int allowed) && allowed==grade))
                throw new ValidationException("اجازهٔ ثبت نمره برای این پایه را ندارید.");
            int minimum=Values.Number(q.Text,0,short.MaxValue)??0;
            int maximum=Values.Number(p.Text,minimum,short.MaxValue)??0;
            for(int index=0;index<ab.RowCount;index++)
            {
                var row=ab.GetRow(index);
                try
                {
                    var values=new object[10];
                    for(int i=0;i<10;i++)values[i]=row.Cells["m"+(i+1)].Value;
                    entries.Add(new BulkMark(Convert.ToInt32(row.Cells["id"].Value),IndividualMark.Create(book,row.Cells["CountAb"].Value,values,minimum,maximum,term)));
                }
                catch(ValidationException){row.Cells["acp"].Value=-1;ab.Row=index;throw;}
            }
        }
        catch(ValidationException error){MessageBox.Show(error.Message,"نمره معتبر نیست",MessageBoxButtons.OK,MessageBoxIcon.Warning);return;}
        if(entries.Count==0)return;
        savingMarks=true;Enabled=false;UseWaitCursor=true;
        try
        {
            var database=new Database(OriginalRuntime.ConnectionString);
            await Task.Run(()=>new BulkMarks(database).Save(year,grade,classroom,exam,book,entries));
            if(IsDisposed)return;
            updatingRowState=true;
            try{for(int index=0;index<ab.RowCount;index++)ab.GetRow(index).Cells["acp"].Value=1;}
            finally{updatingRowState=false;}
            am=true;
        }
        catch(Exception error) when(error is SqlException || error is ValidationException)
        {MessageBox.Show("نمره‌ها ذخیره نشد. هیچ تغییری ثبت نشد؛ دوباره تلاش کنید.\n"+error.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);return;}
        finally{savingMarks=false;if(!IsDisposed){Enabled=true;UseWaitCursor=false;}}
        if(!IsDisposed){ab.Refresh();MessageBox.Show("تعداد "+entries.Count+" ردیف انجام شد");}
    }

    private async void a(object sender,ColumnActionEventArgs args)
    {
        if(updatingRowState || savingMarks || ab.Row<0 || args.Column.Key=="acp")return;
        var row=ab.GetRow(ab.Row);
        if(args.Column.Key=="sort")
        {
            int year=int.Parse(aj),grade=int.Parse(ag),classroom=int.Parse(af),student=Convert.ToInt32(row.Cells["id"].Value);
            object order=row.Cells["sort"].Value;
            savingMarks=true;
            // Leave the native CellEndEdit callback before changing focus/state.
            await Task.Yield();
            Enabled=false;UseWaitCursor=true;
            try
            {
                if(!asdaj.a("3") || !asdaj.n.Split(',').Any(value=>int.TryParse(value,out int allowed) && allowed==grade))
                    throw new ValidationException("اجازهٔ ثبت نمره برای این پایه را ندارید.");
                await Task.Run(()=>new BulkMarks(new Database(OriginalRuntime.ConnectionString)).SaveOrder(year,grade,classroom,student,order));
                savedOrders[student]=order;
            }
            catch(Exception error) when(error is SqlException || error is ValidationException)
            {
                updatingRowState=true;
                try{if(savedOrders.TryGetValue(student,out var previous))row.Cells["sort"].Value=previous;}
                finally{updatingRowState=false;}
                MessageBox.Show("ترتیب شاگرد ثبت نشد؛ مقدار قبلی حفظ شد.\n"+error.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally{savingMarks=false;if(!IsDisposed){Enabled=true;UseWaitCursor=false;}}
            return;
        }
        am=false;
        int state=0;
        try
        {
            int minimum=Values.Number(q.Text,0,short.MaxValue)??0,maximum=Values.Number(p.Text,minimum,short.MaxValue)??0;
            if(args.Column.Key.Equals("CountAb",StringComparison.OrdinalIgnoreCase))Values.Number(row.Cells[args.Column.Key].Value,0,short.MaxValue);
            else IndividualMark.Number(row.Cells[args.Column.Key].Value,minimum,maximum);
        }
        catch(ValidationException){state=-1;}
        updatingRowState=true;
        try{row.Cells["acp"].Value=state;}
        finally{updatingRowState=false;}
    }

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		ab.RootTable.Columns["sort"].Selectable = l.Checked;
	}

    private void b(object sender,EventArgs args)
    {
        if(savingMarks || !ab.TryEndEdit() || savingMarks)return;
        if(k.SelectedIndex<0)k.SelectedIndex=0;
        string key=Convert.ToString(k.SelectedValue);string text=g.Text.Trim();
        object value=DBNull.Value;
        if(text.Length==0)
        {
            if(MessageBox.Show("آیا میخواهید نمرات "+k.SelectedItem.Text+" خالی شود","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)!=DialogResult.Yes)return;
        }
        else
        {
            try
            {
                int minimum=Values.Number(q.Text,0,short.MaxValue)??0,maximum=Values.Number(p.Text,minimum,short.MaxValue)??0;
                double number=IndividualMark.Number(text,minimum,maximum).Value;
                if(key.Equals("m1",StringComparison.OrdinalIgnoreCase) && Math.Truncate(number)!=number)
                    throw new ValidationException("نمره باید عدد صحیح باشد.");
                value=number;
            }
            catch(ValidationException error){MessageBox.Show(error.Message);g.Focus();return;}
        }
        updatingRowState=true;
        try
        {
            for(int index=0;index<ab.RowCount;index++)
            {
                var row=ab.GetRow(index);row.BeginEdit();row.Cells[key].Value=value;row.Cells["acp"].Value=0;row.EndEdit();
            }
        }
        finally{updatingRowState=false;}
        am=false;
    }

    private void a(object sender,FormClosingEventArgs args)
    {
        if(savingMarks){args.Cancel=true;return;}
        if(am)return;
        if(MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.Yes)
        {args.Cancel=true;return;}
        ab.CancelEdit();am=true;
    }

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F5;
			int num = 4;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 5:
					e(this, null);
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					flag = A_1.KeyCode != Keys.Escape;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 1:
					ab.Refresh();
					d(this, null);
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
	}
}
