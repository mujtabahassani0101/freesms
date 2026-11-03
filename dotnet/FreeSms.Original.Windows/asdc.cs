using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdc : Form
{
	private string m_a;

	private IContainer m_b = null;

	private GridEX m_c;

	private Panel m_d;

	private Panel m_e;

	private UIButton m_f;

	private UIButton m_g;

	private UIButton m_h;

	private Panel i;

	private UIButton j;

	private UIButton k;

	private Label l;

	private EditBox m;

	private UIButton n;

	private Label o;

	private Panel p;

	private Label q;

	private UIComboBox r;

	private UIButton s;

	private PrintPreviewDialog t;

	private GridEXPrintDocument u;

	private Label v;

	private EditBox w;

	private Label x;

	private Panel y;

	private Label z;

	private UIComboBox aa;

	private EditBox ab;

	private Label ac;

	private EditBox ad;

	private Label ae;

	private Label af;

	public asdc()
	{
		a();
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
						num = 0;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 1;
					continue;
				case 6:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 2:
					af.Text = asdaj.__field_a;
					c();
					b();
					num = 4;
					continue;
				case 4:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 7;
					continue;
				case 7:
					return;
				case 5:
					num = 6;
					continue;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye where id in(" + asdaj.n + ")  order by id");
		r.DataSource = dataSource;
		r.DisplayMember = "Name";
		r.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tClass.id, tClass.name, tPaye.Name AS Paye, tClass.xpaye, tClass.answerable,\r\n            tClass.fee, tClass.shift, tClass.sortRpt, case tClass.shift when 1 then N'صبح' when 2 then N'عصر' end as shifttext\r\n           FROM         tClass INNER JOIN\r\n                      tPaye ON tClass.xpaye = tPaye.id where xYear=" + af.Text);
		this.m_c.DataSource = dataSource;
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a = "insert";
		r.Enabled = true;
		y.Visible = true;
		m.Text = "";
        w.Text="";ad.Text="0";ab.Text="";aa.SelectedIndex=0;
		m.Focus();
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_c.RowCount <= 0;
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
					this.m_a = "update";
					r.Enabled = false;
					y.Visible = true;
					m.Text = this.m_c.SelectedItems[0].GetRow().Cells["name"].Value.ToString();
					w.Text = this.m_c.SelectedItems[0].GetRow().Cells["Answerable"].Value.ToString();
					ad.Text = this.m_c.SelectedItems[0].GetRow().Cells["Fee"].Value.ToString();
					ab.Text = this.m_c.SelectedItems[0].GetRow().Cells["SortRpt"].Value.ToString();
					r.SelectedValue = this.m_c.SelectedItems[0].GetRow().Cells["xpaye"].Value.ToString();
					aa.SelectedValue = this.m_c.SelectedItems[0].GetRow().Cells["Shift"].Value.ToString();
					m.Select();
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
		SqlParameter[] array = default;
		string a_ = default;
		int num2 = default;
		while (true)
		{
			bool flag = r.SelectedIndex >= 0;
			int num = 18;
			while (true)
			{
				switch (num)
				{
				case 18:
					if (!flag)
					{
						num = 25;
						continue;
					}
					flag = !(m.Text.Trim() == "");
					num = 27;
					continue;
				case 13:
					array = new SqlParameter[9]
					{
						asdcb.a("@Code", SqlDbType.Int),
						asdcb.a("@id", SqlDbType.Int, a_),
						asdcb.a("@xYear", SqlDbType.Int, af.Text),
						asdcb.a("@xpaye", SqlDbType.Int, r.SelectedValue.ToString()),
						asdcb.a("@name", SqlDbType.NVarChar, asdaj.b(m.Text)),
						asdcb.a("@answerable", SqlDbType.NVarChar, asdaj.b(w.Text)),
						asdcb.a("@fee", SqlDbType.NVarChar, asdaj.b(ad.Text)),
						asdcb.a("@shift", SqlDbType.SmallInt, aa.SelectedValue.ToString()),
						asdcb.a("@sortRpt", SqlDbType.Int, ab.Text)
					};
					num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tClass_insertUpdate", array);
					flag = !(array[0].Value.ToString() == "-100");
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 15;
						continue;
					}
					flag = !(array[0].Value.ToString() == "-200");
					num = 16;
					continue;
				case 28:
					if (!flag)
					{
						num = 32;
						continue;
					}
					a_ = "0";
					flag = !(this.m_a == "update");
					num = 22;
					continue;
				case 5:
					MessageBox.Show("نگران را وارد کنید");
					w.Focus();
					num = 29;
					continue;
				case 29:
					return;
				case 6:
					MessageBox.Show("شماره تکراری است");
					ab.SelectAll();
					num = 30;
					continue;
				case 30:
					return;
				case 3:
					MessageBox.Show("عنوان صنف را وارد کنید");
					m.Focus();
					num = 12;
					continue;
				case 12:
					return;
				case 11:
					a_ = this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					if (true)
					{
					}
					num = 13;
					continue;
				case 24:
					y.Visible = false;
					num = 26;
					continue;
				case 21:
					MessageBox.Show("مبلغ را وارد کنید");
					ad.Focus();
					num = 4;
					continue;
				case 4:
					return;
				case 23:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 26:
					b();
					m.Text = "";
					w.Text = "";
					ab.Text = "";
					num = 14;
					continue;
				case 14:
					return;
				case 31:
					if (!flag)
					{
						num = 2;
						continue;
					}
					try
					{
						ab.Text = FreeSms.Core.Values.Number(ab.Text,0,32767).Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
					}
					catch
					{
						MessageBox.Show("شماره باید عدد صحیح بین ۰ و ۳۲۷۶۷ باشد");
						ab.Focus();
						return;
					}
					flag = aa.SelectedIndex >= 0;
					num = 28;
					continue;
				case 25:
					MessageBox.Show("نوع را انتخاب کنید");
					r.Focus();
					num = 9;
					continue;
				case 9:
					return;
				case 20:
					if (!flag)
					{
						num = 21;
						continue;
					}
					try
					{
						ad.Text = FreeSms.Core.Values.Number(ad.Text,0).Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
					}
					catch
					{
						MessageBox.Show("مبلغ باید عدد صحیح غیرمنفی باشد");
						ad.Focus();
						return;
					}
					flag = !(ab.Text.Trim() == "");
					num = 31;
					continue;
				case 19:
					if (flag)
					{
						flag = !(ad.Text.Trim() == "");
						num = 20;
					}
					else
					{
						num = 5;
					}
					continue;
				case 7:
					flag = !(this.m_a == "update");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 26;
				case 15:
					MessageBox.Show("عنوان صنف تکراری است");
					m.SelectAll();
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					MessageBox.Show("شماره را وارد کنید");
					ab.Focus();
					num = 10;
					continue;
				case 10:
					return;
				case 22:
					if (!flag)
					{
						num = 11;
						continue;
					}
					goto case 13;
				case 27:
					if (flag)
					{
						flag = !(w.Text.Trim() == "");
						num = 19;
					}
					else
					{
						num = 3;
					}
					continue;
				case 16:
					if (flag)
					{
						flag = num2 <= 0;
						num = 23;
					}
					else
					{
						num = 6;
					}
					continue;
				case 32:
					MessageBox.Show("شیفت را انتخاب کنید");
					aa.Focus();
					num = 8;
					continue;
				case 8:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		y.Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		bool flag = default;
		string text = default;
		while (true)
		{
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num = ((this.m_c.RowCount <= 0) ? 11 : 5);
					continue;
				case 10:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 9:
					MessageBox.Show("تعداد " + text + " شاگرد در این صنف وجود دارد.امکان حذف وجود ندارد");
					num = 12;
					continue;
				case 12:
					return;
				case 11:
					num2 = 1;
					goto IL_0211;
				case 0:
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					num = 3;
					continue;
				case 3:
					if (true)
					{
					}
					num2 = ((this.m_c.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
					goto IL_0211;
				case 2:
                    try
                    {
                        var service=new FreeSms.Core.SchoolService(new FreeSms.Core.Database(OriginalRuntime.ConnectionString),new FreeSms.Core.Session(int.Parse(af.Text)));
                        service.DeleteClass(Convert.ToInt32(this.m_c.SelectedItems[0].GetRow().Cells["id"].Value));
                    }
                    catch(Exception error) when(error is FreeSms.Core.ValidationException || error is SqlException)
                    {MessageBox.Show(error.Message,"حذف صنف",MessageBoxButtons.OK,MessageBoxIcon.Warning);return;}
					b();
					num = 0;
					continue;
				case 8:
					text = asdcb.a(asdab.e(), CommandType.Text, "SELECT  COUNT(id) AS CountStd FROM tYear_Student WHERE xClass =" + this.m_c.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
					flag = !(text != "0");
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						flag = MessageBox.Show("آيا از حذف صنف مطمئن هستيد؟", "حذف صنف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
						num = 10;
					}
					else
					{
						num = 9;
					}
					continue;
				case 4:
					{
						if (!flag)
						{
							num = 8;
							continue;
						}
						return;
					}
					IL_0211:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		Rectangle bounds = Bounds;
		t.SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
		t.UseAntiAlias = true;
		t.ShowDialog(this);
	}
protected override void Dispose(bool A_0)
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
					num = ((!A_0) ? 3 : 4);
					continue;
				case 4:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 5:
					if (true)
					{
					}
					this.m_b.Dispose();
					num = 2;
					continue;
				case 3:
					num2 = 1;
					goto IL_0074;
				case 2:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 0;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdc));
		UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
		UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
		StringFormat stringFormat = new StringFormat();
		StringFormat stringFormat2 = new StringFormat();
		this.m_c = new GridEX();
		this.m_d = new Panel();
		af = new Label();
		ae = new Label();
		y = new Panel();
		i = new Panel();
		z = new Label();
		aa = new UIComboBox();
		ab = new EditBox();
		ac = new Label();
		ad = new EditBox();
		x = new Label();
		v = new Label();
		w = new EditBox();
		q = new Label();
		r = new UIComboBox();
		n = new UIButton();
		k = new UIButton();
		l = new Label();
		m = new EditBox();
		o = new Label();
		this.m_e = new Panel();
		s = new UIButton();
		this.m_f = new UIButton();
		j = new UIButton();
		this.m_g = new UIButton();
		this.m_h = new UIButton();
		p = new Panel();
		t = new PrintPreviewDialog();
		u = new GridEXPrintDocument();
		((ISupportInitialize)this.m_c).BeginInit();
		this.m_d.SuspendLayout();
		y.SuspendLayout();
		i.SuspendLayout();
		this.m_e.SuspendLayout();
		p.SuspendLayout();
		SuspendLayout();
		this.m_c.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		this.m_c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_c.DesignTimeLayout = gridEXLayout;
		this.m_c.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_c.Font = new Font("B Nazanin", 12f);
		this.m_c.GroupByBoxVisible = false;
		this.m_c.Location = new Point(8, 90);
		this.m_c.Name = "gridEX1";
		this.m_c.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		this.m_c.Size = new Size(630, 471);
		this.m_c.TabIndex = 5;
		this.m_c.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_d.BackColor = SystemColors.GradientInactiveCaption;
		this.m_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_d.Controls.Add(af);
		this.m_d.Controls.Add(ae);
		this.m_d.Controls.Add(y);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_c);
		this.m_d.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(5, 6);
		this.m_d.Name = "panel1";
		this.m_d.Size = new Size(648, 632);
		this.m_d.TabIndex = 0;
		af.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		af.Location = new Point(34, 31);
		af.Name = "lYear";
		af.Size = new Size(68, 24);
		af.TabIndex = 120;
		af.TextAlign = ContentAlignment.MiddleCenter;
		ae.AutoSize = true;
		ae.Location = new Point(107, 29);
		ae.Name = "label7";
		ae.Size = new Size(78, 26);
		ae.TabIndex = 99;
		ae.Text = "سال تعلیمی";
		y.BackColor = SystemColors.ControlText;
		y.Controls.Add(i);
		y.Location = new Point(149, 181);
		y.Name = "pcls";
		y.Size = new Size(320, 323);
		y.TabIndex = 97;
		y.Visible = false;
		i.BackColor = SystemColors.GradientInactiveCaption;
		i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		i.Controls.Add(z);
		i.Controls.Add(aa);
		i.Controls.Add(ab);
		i.Controls.Add(ac);
		i.Controls.Add(ad);
		i.Controls.Add(x);
		i.Controls.Add(v);
		i.Controls.Add(w);
		i.Controls.Add(q);
		i.Controls.Add(r);
		i.Controls.Add(n);
		i.Controls.Add(k);
		i.Controls.Add(l);
		i.Controls.Add(m);
		i.Location = new Point(3, 3);
		i.Name = "pcls00";
		i.Size = new Size(314, 317);
		i.TabIndex = 10;
		z.AutoSize = true;
		z.Location = new Point(213, 214);
		z.Name = "label6";
		z.Size = new Size(47, 26);
		z.TabIndex = 96;
		z.Text = "شیفت";
		aa.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		aa.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		aa.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		uIComboBoxItem.FormatStyle.Alpha = 0;
		uIComboBoxItem.Text = "صبح";
		uIComboBoxItem.Value = "1";
		uIComboBoxItem2.FormatStyle.Alpha = 0;
		uIComboBoxItem2.Text = "عصر";
		uIComboBoxItem2.Value = "2";
		aa.Items.AddRange(new UIComboBoxItem[2] { uIComboBoxItem, uIComboBoxItem2 });
		aa.Location = new Point(88, 210);
		aa.Name = "dropShift";
		aa.Size = new Size(119, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		aa.StringFormat = stringFormat;
		aa.TabIndex = 5;
		ab.AutoScroll = false;
		ab.AutoScrollMargin = new Size(0, 0);
		ab.AutoScrollMinSize = new Size(0, 0);
		ab.AutoScrollPosition = new Point(0, 0);
		ab.Location = new Point(88, 173);
		ab.Name = "txtSortRpt";
		ab.Size = new Size(119, 33);
		ab.TabIndex = 4;
		ab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		ac.AutoSize = true;
		ac.Location = new Point(211, 177);
		ac.Name = "label5";
		ac.Size = new Size(46, 26);
		ac.TabIndex = 93;
		ac.Text = "شماره";
		ad.AutoScroll = false;
		ad.AutoScrollMargin = new Size(0, 0);
		ad.AutoScrollMinSize = new Size(0, 0);
		ad.AutoScrollPosition = new Point(0, 0);
		ad.Location = new Point(88, 136);
		ad.Name = "txtFee";
		ad.Size = new Size(119, 33);
		ad.TabIndex = 3;
		ad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		x.AutoSize = true;
		x.Location = new Point(211, 140);
		x.Name = "label3";
		x.Size = new Size(69, 26);
		x.TabIndex = 41;
		x.Text = "مبلغ فیس";
		v.AutoSize = true;
		v.Location = new Point(211, 103);
		v.Name = "label2";
		v.Size = new Size(43, 26);
		v.TabIndex = 39;
		v.Text = "نگران";
		w.AutoScroll = false;
		w.AutoScrollMargin = new Size(0, 0);
		w.AutoScrollMinSize = new Size(0, 0);
		w.AutoScrollPosition = new Point(0, 0);
		w.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		w.Location = new Point(23, 99);
		w.Name = "txtAnswerable";
		w.Size = new Size(184, 33);
		w.TabIndex = 2;
		w.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		q.AutoSize = true;
		q.Location = new Point(212, 23);
		q.Name = "label20";
		q.Size = new Size(31, 26);
		q.TabIndex = 37;
		q.Text = "نوع";
		r.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		r.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		r.Location = new Point(22, 19);
		r.Name = "dropPaye";
		r.Size = new Size(184, 33);
		stringFormat2.Alignment = StringAlignment.Near;
		stringFormat2.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat2.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat2.LineAlignment = StringAlignment.Center;
		stringFormat2.Trimming = StringTrimming.Character;
		r.StringFormat = stringFormat2;
		r.TabIndex = 0;
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		n.Location = new Point(23, 259);
		n.Name = "btnCancel";
		n.Size = new Size(90, 32);
		n.TabIndex = 7;
		n.Text = "انصراف";
		n.Click += c;
		k.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		k.Location = new Point(131, 259);
		k.Name = "btnAcp";
		k.Size = new Size(96, 32);
		k.TabIndex = 6;
		k.Text = "تایید";
		k.Click += e;
		l.AutoSize = true;
		l.Location = new Point(211, 66);
		l.Name = "label1";
		l.Size = new Size(77, 26);
		l.TabIndex = 1;
		l.Text = "عنوان صنف";
		m.AutoScroll = false;
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.AutoScrollPosition = new Point(0, 0);
		m.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Location = new Point(23, 62);
		m.Name = "txtNam";
		m.Size = new Size(184, 33);
		m.TabIndex = 1;
		m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		o.AutoSize = true;
		o.Font = new Font("B Nazanin", 24f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.ForeColor = Color.DarkViolet;
		o.Location = new Point(445, 14);
		o.Name = "label4";
		o.Size = new Size(184, 51);
		o.TabIndex = 17;
		o.Text = "مدیریت صنوف";
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_e.Controls.Add(s);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Controls.Add(j);
		this.m_e.Controls.Add(this.m_g);
		this.m_e.Controls.Add(this.m_h);
		this.m_e.Location = new Point(1, 567);
		this.m_e.Name = "p_new";
		this.m_e.Size = new Size(642, 51);
		this.m_e.TabIndex = 9;
		s.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		s.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		s.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		s.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		s.ImageSize = new Size(30, 30);
		s.Location = new Point(148, 3);
		s.Name = "btnPrint";
		s.Size = new Size(117, 40);
		s.TabIndex = 28;
		s.Text = "چاپ";
		s.Visible = false;
		s.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		s.Click += a;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_f.Location = new Point(313, 3);
		this.m_f.Name = "btnDelete";
		this.m_f.Size = new Size(107, 42);
		this.m_f.TabIndex = 2;
		this.m_f.Text = "حذف";
		this.m_f.Click += b;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		j.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		j.ImageSize = new Size(40, 40);
		j.Location = new Point(7, 2);
		j.Name = "btnClose";
		j.Size = new Size(134, 43);
		j.TabIndex = 15;
		j.Text = "خروج";
		j.Click += d;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_g.Location = new Point(534, 3);
		this.m_g.Name = "btnNew";
		this.m_g.Size = new Size(90, 42);
		this.m_g.TabIndex = 0;
		this.m_g.Text = "جدید";
		this.m_g.Click += g;
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_h.Location = new Point(431, 3);
		this.m_h.Name = "btnEdit";
		this.m_h.Size = new Size(97, 42);
		this.m_h.TabIndex = 1;
		this.m_h.Text = "اصلاح";
		this.m_h.Click += f;
		p.BackColor = SystemColors.ControlText;
		p.Controls.Add(this.m_d);
		p.Dock = DockStyle.Fill;
		p.Location = new Point(0, 0);
		p.Name = "panel2";
		p.Size = new Size(657, 643);
		p.TabIndex = 1;
		t.AutoScrollMargin = new Size(0, 0);
		t.AutoScrollMinSize = new Size(0, 0);
		t.ClientSize = new Size(400, 300);
		t.Document = u;
		t.Enabled = true;
		t.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		t.Name = "printPreviewDialog1";
		t.Visible = false;
		u.PageFooterLeft = "3";
		u.PageFooterRight = "2";
		u.PageHeaderCenter = "1";
		u.PageHeaderLeft = "4";
		u.PageHeaderRight = "5";
		AcceptButton = k;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(657, 643);
		Controls.Add(p);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmCls";
		RightToLeft = RightToLeft.Yes;
		ShowIcon = false;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "مدیریت صنوف";
		Load += h;
		((ISupportInitialize)this.m_c).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		y.ResumeLayout(performLayout: false);
		i.ResumeLayout(performLayout: false);
		i.PerformLayout();
		this.m_e.ResumeLayout(performLayout: false);
		p.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
