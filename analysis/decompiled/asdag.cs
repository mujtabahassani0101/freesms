using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdag : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private Panel m_f;

	private UIButton m_g;

	private UIButton h;

	private EditBox i;

	private Label j;

	private Panel k;

	private EditBox l;

	private Label m;

	private UIButton n;

	private Label o;

	private EditBox p;

	private Label q;

	private NumericEditBox r;

	private NumericEditBox s;

	private Label t;

	private Label u;

	private UIComboBox v;

	private Panel w;

	private string x;

	private string y = "0";

	protected override void a(bool A_0)
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
						num = 6;
					}
					else
					{
						num = 5;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Expected Obj, but got Unknown
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected Obj, but got Unknown
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f01: Expected Obj, but got Unknown
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1084: Expected Obj, but got Unknown
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdag));
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		StringFormat val5 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		v = new UIComboBox();
		j = new Label();
		this.m_f = new Panel();
		w = new Panel();
		i = new EditBox();
		u = new Label();
		o = new Label();
		r = new NumericEditBox();
		h = new UIButton();
		s = new NumericEditBox();
		n = new UIButton();
		t = new Label();
		m = new Label();
		p = new EditBox();
		l = new EditBox();
		q = new Label();
		this.m_d = new Panel();
		this.m_e = new UIButton();
		this.m_g = new UIButton();
		k = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((Control)w).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)k).SuspendLayout();
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(8, 51);
		((Control)this.m_b).Name = "gridEX1";
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(648, 341);
		((Control)this.m_b).TabIndex = 5;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		this.m_b.SelectionChanged += a;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)v);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_c).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(5, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(662, 487);
		((Control)this.m_c).TabIndex = 0;
		((Control)v).Anchor = (AnchorStyles)9;
		((UIComboBase)v).ComboStyle = (ComboStyle)1;
		((UIComboBase)v).DropListFont = new Font("B Titr", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)v).Font = new Font("B Titr", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val2.FormatStyle.Alpha = 0;
		val2.Text = "چهار و نیم ماهه";
		val2.Value = "1";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "سالانه";
		val3.Value = "3";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "نمرات ماهانه";
		val4.Value = "0";
		v.Items.AddRange(new UIComboBoxItem[3] { val2, val3, val4 });
		((Control)v).Location = new Point(119, 5);
		((Control)v).Name = "dropTerm";
		((Control)v).Size = new Size(287, 41);
		val5.Alignment = (StringAlignment)0;
		val5.FormatFlags = (StringFormatFlags)20485;
		val5.HotkeyPrefix = (HotkeyPrefix)0;
		val5.LineAlignment = (StringAlignment)1;
		val5.Trimming = (StringTrimming)1;
		((UIComboBase)v).StringFormat = val5;
		((Control)v).TabIndex = 53;
		v.SelectedIndexChanged += b;
		((Control)j).AutoSize = true;
		((Control)j).Font = new Font("B Titr", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)j).ForeColor = Color.Maroon;
		((Control)j).Location = new Point(408, 0);
		((Control)j).Name = "label4";
		((Control)j).Size = new Size(246, 42);
		((Control)j).TabIndex = 17;
		((Control)j).Text = "تنظیمات درجه بندی نمرات";
		((Control)this.m_f).BackColor = SystemColors.ControlText;
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)w);
		((Control)this.m_f).Location = new Point(16, 97);
		((Control)this.m_f).Name = "pcls";
		((Control)this.m_f).Size = new Size(635, 274);
		((Control)this.m_f).TabIndex = 10;
		((Control)this.m_f).Visible = false;
		((Control)w).BackColor = SystemColors.GradientInactiveCaption;
		w.BorderStyle = (BorderStyle)1;
		((Control)w).Controls.Add((Control)(object)i);
		((Control)w).Controls.Add((Control)(object)u);
		((Control)w).Controls.Add((Control)(object)o);
		((Control)w).Controls.Add((Control)(object)r);
		((Control)w).Controls.Add((Control)(object)h);
		((Control)w).Controls.Add((Control)(object)s);
		((Control)w).Controls.Add((Control)(object)n);
		((Control)w).Controls.Add((Control)(object)t);
		((Control)w).Controls.Add((Control)(object)m);
		((Control)w).Controls.Add((Control)(object)p);
		((Control)w).Controls.Add((Control)(object)l);
		((Control)w).Controls.Add((Control)(object)q);
		((Control)w).Location = new Point(5, 5);
		((Control)w).Name = "panel3";
		((Control)w).Size = new Size(623, 261);
		((Control)w).TabIndex = 41;
		((Control)i).Anchor = (AnchorStyles)10;
		((EditBase)i).AutoScroll = false;
		((EditBase)i).AutoScrollMargin = new Size(0, 0);
		((EditBase)i).AutoScrollMinSize = new Size(0, 0);
		((EditBase)i).AutoScrollPosition = new Point(0, 0);
		((EditBase)i).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(294, 5);
		((EditBase)i).MaxLength = 50;
		((Control)i).Name = "txttosif";
		((Control)i).Size = new Size(246, 23);
		((Control)i).TabIndex = 0;
		((EditBase)i).TextAlignment = (TextAlignment)1;
		((Control)i).Visible = false;
		((Control)u).Anchor = (AnchorStyles)10;
		((Control)u).AutoSize = true;
		((Control)u).Enabled = false;
		((Control)u).Location = new Point(364, 75);
		((Control)u).Name = "label6";
		((Control)u).Size = new Size(62, 16);
		((Control)u).TabIndex = 40;
		((Control)u).Text = "تا کمتر از";
		((Control)o).Anchor = (AnchorStyles)10;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(546, 8);
		((Control)o).Name = "label1";
		((Control)o).Size = new Size(25, 16);
		((Control)o).TabIndex = 1;
		((Control)o).Text = "نام";
		((Control)o).Visible = false;
		((Control)r).Anchor = (AnchorStyles)10;
		((EditBase)r).AutoScroll = false;
		((EditBase)r).AutoScrollMargin = new Size(0, 0);
		((EditBase)r).AutoScrollMinSize = new Size(0, 0);
		((EditBase)r).AutoScrollPosition = new Point(0, 0);
		((Control)r).Location = new Point(294, 72);
		((Control)r).Name = "txttoMark";
		((Control)r).Size = new Size(61, 23);
		((Control)r).TabIndex = 39;
		((Control)r).Text = "100";
		((EditBase)r).TextAlignment = (TextAlignment)1;
		r.Value = (short)100;
		r.ValueType = (NumericEditValueType)7;
		((Control)h).Anchor = (AnchorStyles)10;
		h.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)h).Location = new Point(113, 220);
		((Control)h).Name = "btnAcp";
		((Control)h).Size = new Size(103, 35);
		((Control)h).TabIndex = 2;
		((Control)h).Text = "تایید";
		((Control)h).Click += e;
		((Control)s).Anchor = (AnchorStyles)10;
		((EditBase)s).AutoScroll = false;
		((EditBase)s).AutoScrollMargin = new Size(0, 0);
		((EditBase)s).AutoScrollMinSize = new Size(0, 0);
		((EditBase)s).AutoScrollPosition = new Point(0, 0);
		((Control)s).Enabled = false;
		((Control)s).Location = new Point(474, 72);
		((Control)s).Name = "txtfromMark";
		((Control)s).Size = new Size(66, 23);
		((Control)s).TabIndex = 38;
		((Control)s).Text = "0";
		((EditBase)s).TextAlignment = (TextAlignment)1;
		s.Value = (short)0;
		s.ValueType = (NumericEditValueType)7;
		((Control)n).Anchor = (AnchorStyles)10;
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)n).Location = new Point(18, 220);
		((Control)n).Name = "btnCancel";
		((Control)n).Size = new Size(89, 35);
		((Control)n).TabIndex = 3;
		((Control)n).Text = "انصراف";
		((Control)n).Click += c;
		((Control)t).Anchor = (AnchorStyles)10;
		((Control)t).AutoSize = true;
		((Control)t).Enabled = false;
		((Control)t).Location = new Point(546, 75);
		((Control)t).Name = "label5";
		((Control)t).Size = new Size(54, 16);
		((Control)t).TabIndex = 37;
		((Control)t).Text = "از نمره ";
		((Control)m).Anchor = (AnchorStyles)10;
		((Control)m).Location = new Point(546, 108);
		((Control)m).Name = "label2";
		((Control)m).Size = new Size(62, 44);
		((Control)m).TabIndex = 17;
		((Control)m).Text = " متن در اطلاع نامه";
		m.TextAlign = (ContentAlignment)64;
		((Control)p).Anchor = (AnchorStyles)10;
		((EditBase)p).AutoScroll = false;
		((EditBase)p).AutoScrollMargin = new Size(0, 0);
		((EditBase)p).AutoScrollMinSize = new Size(0, 0);
		((EditBase)p).AutoScrollPosition = new Point(0, 0);
		((EditBase)p).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(474, 38);
		((EditBase)p).MaxLength = 10;
		((Control)p).Name = "txttosifM";
		((Control)p).Size = new Size(66, 23);
		((Control)p).TabIndex = 19;
		((EditBase)p).TextAlignment = (TextAlignment)1;
		((Control)l).Anchor = (AnchorStyles)10;
		((EditBase)l).AutoScroll = false;
		((EditBase)l).AutoScrollMargin = new Size(0, 0);
		((EditBase)l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)l).AutoScrollPosition = new Point(0, 0);
		((EditBase)l).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(11, 109);
		l.Multiline = true;
		((Control)l).Name = "txtComment";
		((Control)l).Size = new Size(529, 107);
		((Control)l).TabIndex = 1;
		((EditBase)l).TextAlignment = (TextAlignment)1;
		((Control)q).Anchor = (AnchorStyles)10;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(546, 42);
		((Control)q).Name = "label3";
		((Control)q).Size = new Size(40, 16);
		((Control)q).TabIndex = 18;
		((Control)q).Text = "درجه";
		((Control)this.m_d).Anchor = (AnchorStyles)14;
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Location = new Point(1, 404);
		((Control)this.m_d).Name = "p_new";
		((Control)this.m_d).Size = new Size(655, 45);
		((Control)this.m_d).TabIndex = 9;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		((Control)this.m_e).Location = new Point(515, 3);
		((Control)this.m_e).Name = "btnEdit";
		((Control)this.m_e).Size = new Size(127, 36);
		((Control)this.m_e).TabIndex = 1;
		((Control)this.m_e).Text = "اصلاح";
		((Control)this.m_e).Click += f;
		((Control)this.m_g).Anchor = (AnchorStyles)14;
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_g.ImageSize = new Size(40, 40);
		((Control)this.m_g).Location = new Point(2, 4);
		((Control)this.m_g).Name = "btnClose";
		((Control)this.m_g).Size = new Size(228, 36);
		((Control)this.m_g).TabIndex = 15;
		((Control)this.m_g).Text = "خروج";
		((Control)this.m_g).Click += d;
		((Control)k).BackColor = SystemColors.ControlText;
		((Control)k).Controls.Add((Control)(object)this.m_c);
		((Control)k).Dock = (DockStyle)5;
		((Control)k).Location = new Point(0, 0);
		((Control)k).Name = "panel2";
		((Control)k).Size = new Size(672, 500);
		((Control)k).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(672, 500);
		((Control)this).Controls.Add((Control)(object)k);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmTosifConfig";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست تخفیف ها";
		((Form)this).Load += g;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)this.m_f).ResumeLayout(false);
		((Control)w).ResumeLayout(false);
		((Control)w).PerformLayout();
		((Control)this.m_d).ResumeLayout(false);
		((Control)k).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdag()
	{
		b();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 3:
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
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto IL_0131;
				case 5:
					return;
				case 1:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 0;
					continue;
				case 0:
					return;
				case 4:
					if (1 == 0)
					{
					}
					goto IL_0131;
				case 2:
					{
						num = 3;
						continue;
					}
					IL_0131:
					v.SelectedIndex = 0;
					a();
					num = 5;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tTosif where term=" + v.SelectedValue.ToString() + " order by lev desc");
		this.m_b.DataSource = dataSource;
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_b.RowCount <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 3:
					((Control)r).Enabled = false;
					num = 0;
					continue;
				case 6:
					x = "update";
					((Control)this.m_f).Visible = true;
					((Control)i).Text = this.m_b.SelectedItems[0].GetRow().Cells["tosif"].Value.ToString();
					((Control)p).Text = this.m_b.SelectedItems[0].GetRow().Cells["tosifM"].Value.ToString();
					((Control)s).Text = this.m_b.SelectedItems[0].GetRow().Cells["fromMark"].Value.ToString();
					((Control)r).Text = this.m_b.SelectedItems[0].GetRow().Cells["toMark"].Value.ToString();
					((Control)l).Text = this.m_b.SelectedItems[0].GetRow().Cells["comment"].Value.ToString();
					y = this.m_b.SelectedItems[0].GetRow().Cells["lev"].Value.ToString();
					flag = !(y == "1");
					if (true)
					{
					}
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						((Control)r).Enabled = true;
						num = 4;
					}
					else
					{
						num = 3;
					}
					continue;
				case 0:
				case 4:
					((Control)i).Select();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string text = "0";
			bool flag = !(((Control)i).Text.Trim() == "");
			int num = 20;
			while (true)
			{
				int num5;
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 15;
						continue;
					}
					flag = !(((Control)p).Text.Trim() == "");
					num = 25;
					continue;
				case 21:
					MessageBox.Show("نمره را وارد کنید");
					((Control)s).Focus();
					num = 23;
					continue;
				case 23:
					return;
				case 14:
				{
					int num4 = int.Parse(y);
					num4--;
					asdcb.d(asdab.e(), CommandType.Text, " update tTosif set fromMark=" + ((Control)r).Text + " where term=" + v.SelectedValue.ToString() + " and lev=" + num4);
					num = 6;
					continue;
				}
				case 5:
					num = 16;
					continue;
				case 16:
					num5 = ((!(((Control)r).Text.Trim() == "0")) ? 1 : 0);
					goto IL_0384;
				case 19:
					num = ((((Control)r).Text.Trim() == "") ? 8 : 5);
					continue;
				case 8:
					num5 = 0;
					goto IL_0384;
				case 15:
					if (true)
					{
					}
					MessageBox.Show("نام را وارد کنید");
					((Control)i).Focus();
					num = 17;
					continue;
				case 17:
					return;
				case 26:
					MessageBox.Show("نمره را وارد کنید");
					((Control)r).Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 9:
					flag = !(y != "1");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 6;
				case 12:
					((Control)this.m_f).Visible = false;
					num = 18;
					continue;
				case 2:
					MessageBox.Show("عنوان درجه را وارد کنید");
					((Control)i).Focus();
					num = 13;
					continue;
				case 13:
					return;
				case 25:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = !(((Control)s).Text.Trim() == "");
					num = 1;
					continue;
				case 18:
					a();
					num = 24;
					continue;
				case 24:
					return;
				case 11:
					if (flag)
					{
						try
						{
							int num6 = int.Parse(((Control)s).Text);
						}
						catch
						{
							MessageBox.Show("نمره اشتباه است فقط عدد وارد کنید");
							((Control)s).Focus();
							return;
						}
						num = 3;
					}
					else
					{
						num = 26;
					}
					continue;
				case 1:
					num = ((!flag) ? 21 : 19);
					continue;
				case 22:
				{
					text = this.m_b.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					int num3 = asdcb.d(asdab.e(), CommandType.Text, " update tTosif set tosif=N'" + asdaj.b(((Control)i).Text) + "',tosifM=N'" + ((Control)p).Text + "',comment=N'" + ((Control)l).Text + "',toMark=" + ((Control)r).Text + " where id=" + text);
					flag = num3 <= 0;
					num = 10;
					continue;
				}
				case 10:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 12;
				case 3:
					try
					{
						int num2 = int.Parse(((Control)r).Text);
					}
					catch
					{
						MessageBox.Show("نمره اشتباه است فقط عدد وارد کنید");
						((Control)r).Focus();
						return;
					}
					flag = !(x == "update");
					num = 0;
					continue;
				case 6:
					num = 12;
					continue;
				case 0:
					{
						if (!flag)
						{
							num = 22;
							continue;
						}
						goto case 18;
					}
					IL_0384:
					flag = (byte)num5 != 0;
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		a();
		((Control)this.m_f).Visible = false;
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}
}
