using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using school_Af.Properties;

public class asda6 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private Label m_e;

	private UIButton m_f;

	private GridEX m_g;

	private UIComboBox m_h;

	private Label m_i;

	private Label m_j;

	private Label k;

	private Button l;

	private Button m;

	private CheckBox n;

	private Label o;

	private Panel p;

	private Label q;

	private SqlConnection r = new SqlConnection(asdab.e());

	private string s = "";

	public string t = "";

	private string u = "Acp3";

	private bool v = true;

	private int w;

	private bool x = false;

	private bool y = false;

	protected override void a(bool A_0)
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				case 2:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void f()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected Obj, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected Obj, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected Obj, but got Unknown
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Expected Obj, but got Unknown
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Expected Obj, but got Unknown
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected Obj, but got Unknown
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda6));
		GridEXLayout val2 = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		o = new Label();
		n = new CheckBox();
		m = new Button();
		l = new Button();
		this.m_j = new Label();
		k = new Label();
		this.m_h = new UIComboBox();
		this.m_i = new Label();
		this.m_e = new Label();
		this.m_f = new UIButton();
		this.m_g = new GridEX();
		p = new Panel();
		q = new Label();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)this.m_g).BeginInit();
		((Control)p).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(1010, 700);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_c).BackColor = Color.Black;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel2";
		((Control)this.m_c).Size = new Size(1008, 698);
		((Control)this.m_c).TabIndex = 44;
		((Control)this.m_d).BackColor = Color.FromArgb(214, 223, 247);
		((Control)this.m_d).Controls.Add((Control)(object)p);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)n);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Location = new Point(3, 3);
		((Control)this.m_d).Name = "panel3";
		((Control)this.m_d).Size = new Size(1002, 689);
		((Control)this.m_d).TabIndex = 0;
		((Control)o).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).ForeColor = Color.FromArgb(192, 64, 0);
		((Control)o).Location = new Point(110, 648);
		((Control)o).Name = "label1";
		((Control)o).Size = new Size(419, 41);
		((Control)o).TabIndex = 122;
		((Control)o).Text = "توضیح:زمانی که تیک رنگی شدن نمرات کمتر از حدنصاب خورده باشد ،به علت نیاز به تنظیم رنگ ها سیستم یک مقدار کند می شود";
		((Control)n).AutoSize = true;
		n.Checked = true;
		n.CheckState = (CheckState)1;
		((Control)n).ForeColor = Color.Red;
		((Control)n).Location = new Point(549, 652);
		((Control)n).Name = "checkMarkMin";
		((Control)n).Size = new Size(219, 30);
		((Control)n).TabIndex = 121;
		((Control)n).Text = "رنگی شدن نمرات کمتر از حدنصاب";
		((ButtonBase)n).UseVisualStyleBackColor = true;
		n.CheckedChanged += b;
		((Control)m).BackColor = Color.Violet;
		((ButtonBase)m).FlatAppearance.BorderColor = Color.Maroon;
		((ButtonBase)m).FlatAppearance.BorderSize = 3;
		((ButtonBase)m).FlatStyle = (FlatStyle)0;
		((Control)m).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ButtonBase)m).ImageAlign = (ContentAlignment)64;
		((Control)m).Location = new Point(12, 10);
		((Control)m).Name = "btnCopygClass";
		((Control)m).Size = new Size(194, 35);
		((Control)m).TabIndex = 120;
		((Control)m).Text = "درخواست نتیجه پیشنهادی سیستم";
		((ButtonBase)m).UseVisualStyleBackColor = false;
		((Control)m).Click += f;
		((Control)l).Anchor = (AnchorStyles)6;
		((Control)l).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ButtonBase)l).Image = (Image)(object)Resources._4160;
		((ButtonBase)l).ImageAlign = (ContentAlignment)64;
		((Control)l).Location = new Point(797, 648);
		((Control)l).Name = "btnSaveMark";
		((Control)l).Size = new Size(197, 35);
		((Control)l).TabIndex = 119;
		((Control)l).Text = "ثبت نتایج(F5)";
		((ButtonBase)l).UseVisualStyleBackColor = true;
		((Control)l).Click += g;
		this.m_j.BorderStyle = (BorderStyle)1;
		((Control)this.m_j).Location = new Point(584, 14);
		((Control)this.m_j).Name = "lYear";
		((Control)this.m_j).Size = new Size(55, 24);
		((Control)this.m_j).TabIndex = 118;
		((Control)this.m_j).Click += e;
		((Control)k).AutoSize = true;
		((Control)k).Location = new Point(647, 12);
		((Control)k).Name = "label3";
		((Control)k).Size = new Size(78, 26);
		((Control)k).TabIndex = 117;
		((Control)k).Text = "سال تعلیمی";
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("B Nazanin", 12f);
		((Control)this.m_h).Location = new Point(315, 8);
		((Control)this.m_h).Name = "dropCls";
		((Control)this.m_h).Size = new Size(181, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val;
		((Control)this.m_h).TabIndex = 52;
		this.m_h.SelectedIndexChanged += h;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(502, 13);
		((Control)this.m_i).Name = "label19";
		((Control)this.m_i).Size = new Size(41, 26);
		((Control)this.m_i).TabIndex = 51;
		((Control)this.m_i).Text = "صنف";
		((Control)this.m_e).Font = new Font("B Nazanin", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).ForeColor = Color.DarkViolet;
		((Control)this.m_e).Location = new Point(756, 4);
		((Control)this.m_e).Name = "lTerm";
		((Control)this.m_e).Size = new Size(245, 44);
		((Control)this.m_e).TabIndex = 50;
		((Control)this.m_e).Text = "ثبت نتیجه نهایی";
		this.m_e.TextAlign = (ContentAlignment)32;
		((Control)this.m_f).Anchor = (AnchorStyles)6;
		this.m_f.DialogResult = (DialogResult)2;
		this.m_f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_f.ImageSize = new Size(40, 40);
		((Control)this.m_f).Location = new Point(11, 649);
		((Control)this.m_f).Name = "btnClose";
		((Control)this.m_f).Size = new Size(93, 35);
		((Control)this.m_f).TabIndex = 44;
		((Control)this.m_f).Text = "بستن";
		((Control)this.m_f).Click += i;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_g.DesignTimeLayout = val2;
		this.m_g.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_g.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)this.m_g).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		this.m_g.GroupByBoxVisible = false;
		((Control)this.m_g).Location = new Point(12, 51);
		((Control)this.m_g).Name = "gridEX1";
		((ScrollableBase)this.m_g).RecordNavigator = true;
		((Control)this.m_g).RightToLeft = (RightToLeft)1;
		this.m_g.RowHeaders = (InheritableBoolean)1;
		this.m_g.SelectedFormatStyle.BackColor = Color.Empty;
		this.m_g.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)this.m_g).Size = new Size(987, 591);
		((Control)this.m_g).TabIndex = 45;
		((ScrollableBase)this.m_g).VisualStyle = (VisualStyle)2;
		this.m_g.LayoutLoad += d;
		this.m_g.FormattingRow += a;
		this.m_g.CellUpdated += a;
		this.m_g.Scroll += c;
		((Control)p).Controls.Add((Control)(object)q);
		((Control)p).Location = new Point(349, 294);
		((Control)p).Name = "plode";
		((Control)p).Size = new Size(305, 100);
		((Control)p).TabIndex = 138;
		((Control)q).Anchor = (AnchorStyles)9;
		((Control)q).AutoSize = true;
		((Control)q).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((Control)q).Location = new Point(62, 45);
		((Control)q).Name = "label8";
		((Control)q).Size = new Size(189, 13);
		((Control)q).TabIndex = 30;
		((Control)q).Text = "در حال بارگزاری لطفا کمی صبر کنید";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1010, 700);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSetAcpTerm";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نتایج شاگردان";
		((Form)this).Load += j;
		((Form)this).Shown += a;
		((Control)this).KeyUp += a;
		((Form)this).FormClosing += a;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((ISupportInitialize)this.m_g).EndInit();
		((Control)p).ResumeLayout(false);
		((Control)p).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public asda6()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		f();
	}

	private void e()
	{
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		try
		{
			bool flag = default;
			while (true)
			{
				IL_0052:
				string text = asdcb.a(asdab.e(), CommandType.Text, "select xpaye from tclass where id=" + this.m_h.SelectedValue.ToString()).ToString();
				this.m_g.RootTable.Columns["acpFinal"].HasValueList = true;
				GridEXValueListItemCollection valueList = this.m_g.RootTable.Columns["acpFinal"].ValueList;
				((CollectionBase)(object)valueList).Clear();
				int num = 15;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 15:
						num = ((!(text == "12")) ? 1 : 13);
						continue;
					case 1:
						num = 0;
						continue;
					case 0:
						num2 = ((!(text == "11")) ? 1 : 0);
						goto IL_01be;
					case 8:
						flag = !(t == "3");
						num = 11;
						continue;
					case 11:
						if (!flag)
						{
							num = 14;
							continue;
						}
						valueList.Add(new GridEXValueListItem((object)"1", "کامیاب"));
						valueList.Add(new GridEXValueListItem((object)"0", "ناکام"));
						valueList.Add(new GridEXValueListItem((object)"5", "غایب"));
						valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
						num = 5;
						continue;
					case 12:
						if (!flag)
						{
							num = 8;
							continue;
						}
						flag = !(t == "3");
						num = 10;
						continue;
					case 3:
						valueList.Add(new GridEXValueListItem((object)"1", "ارتقا صنف"));
						valueList.Add(new GridEXValueListItem((object)"2", "مشروط"));
						valueList.Add(new GridEXValueListItem((object)"0", "تکرار صنف"));
						valueList.Add(new GridEXValueListItem((object)"3", "معذرتی"));
						valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
						num = 7;
						continue;
					case 13:
						num2 = 0;
						goto IL_01be;
					case 14:
						valueList.Add(new GridEXValueListItem((object)"1", "کامیاب"));
						valueList.Add(new GridEXValueListItem((object)"2", "مشروط"));
						valueList.Add(new GridEXValueListItem((object)"0", "ناکام"));
						valueList.Add(new GridEXValueListItem((object)"3", "معذرتی"));
						valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
						num = 9;
						continue;
					case 10:
						if (flag)
						{
							valueList.Add(new GridEXValueListItem((object)"1", "موفق"));
							valueList.Add(new GridEXValueListItem((object)"0", "تلاش بیشتر"));
							valueList.Add(new GridEXValueListItem((object)"5", "غایب"));
							valueList.Add(new GridEXValueListItem((object)"4", "محروم"));
							num = 4;
						}
						else
						{
							num = 3;
						}
						continue;
					case 4:
					case 7:
						num = 2;
						continue;
					case 5:
					case 9:
						num = 6;
						continue;
					case 2:
					case 6:
						num = 16;
						continue;
					case 16:
						goto end_IL_0005;
						IL_01be:
						flag = (byte)num2 != 0;
						num = 12;
						continue;
					}
					goto IL_0052;
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

	private void j(object A_0, EventArgs A_1)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 1;
				case 3:
					u = "Acp1";
					((Control)this.m_e).Text = "ثبت نتیجه چهار و نیم ماه";
					num = 8;
					continue;
				case 8:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 4;
					continue;
				case 4:
					return;
				case 1:
					((Control)this.m_j).Text = asdaj.a;
					flag = !(t == "1");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 7:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 1;
					continue;
				case 9:
					num = 7;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		while (true)
		{
			if (true)
			{
			}
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where  xYear=" + ((Control)this.m_j).Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
			this.m_h.DataSource = dataSource;
			this.m_h.DisplayMember = "Name";
			this.m_h.ValueMember = "id";
			bool flag = ((CollectionBase)(object)this.m_h.Items).Count <= 0;
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
					this.m_h.SelectedIndex = 0;
					num = 0;
					continue;
				case 0:
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
		this.m_g.DataSource = null;
		((Control)p).Visible = true;
		((Control)this).Refresh();
		b();
	}

	private void b()
	{
		//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected Obj, but got Unknown
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected Obj, but got Unknown
		DataTable dataTable = default;
		while (true)
		{
			bool flag = this.m_h.SelectedIndex < 0;
			int num = 72;
			while (true)
			{
				switch (num)
				{
				case 72:
					if (!flag)
					{
						num = 20;
						continue;
					}
					return;
				case 11:
				case 27:
					flag = !(dataTable.Rows[0]["book14"].ToString() == "");
					num = 46;
					continue;
				case 46:
					if (!flag)
					{
						num = 43;
						continue;
					}
					this.m_g.RootTable.Columns["mark14"].Caption = dataTable.Rows[0]["book14"].ToString();
					num = 69;
					continue;
				case 60:
					this.m_g.RootTable.Columns["mark11"].Visible = false;
					num = 34;
					continue;
				case 63:
				case 76:
					flag = !(dataTable.Rows[0]["book4"].ToString() == "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 66;
						continue;
					}
					this.m_g.RootTable.Columns["mark4"].Caption = dataTable.Rows[0]["book4"].ToString();
					num = 56;
					continue;
				case 77:
					this.m_g.RootTable.Columns["mark2"].Visible = false;
					num = 2;
					continue;
				case 68:
					this.m_g.RootTable.Columns["mark18"].Visible = false;
					num = 24;
					continue;
				case 39:
					((Control)this.m_g).Visible = true;
					num = 15;
					continue;
				case 26:
					this.m_g.RootTable.Columns["mark8"].Visible = false;
					num = 65;
					continue;
				case 20:
					flag = !n.Checked;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 51;
				case 2:
				case 48:
					flag = !(dataTable.Rows[0]["book3"].ToString() == "");
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark3"].Caption = dataTable.Rows[0]["book3"].ToString();
						num = 76;
					}
					else
					{
						num = 7;
					}
					continue;
				case 3:
					this.m_g.RootTable.Columns["mark5"].Visible = false;
					num = 54;
					continue;
				case 57:
				case 67:
					flag = !(dataTable.Rows[0]["book18"].ToString() == "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 68;
						continue;
					}
					this.m_g.RootTable.Columns["mark18"].Caption = dataTable.Rows[0]["book18"].ToString();
					num = 75;
					continue;
				case 10:
				case 81:
					flag = !(dataTable.Rows[0]["book8"].ToString() == "");
					num = 28;
					continue;
				case 28:
					if (!flag)
					{
						num = 26;
						continue;
					}
					this.m_g.RootTable.Columns["mark8"].Caption = dataTable.Rows[0]["book8"].ToString();
					num = 73;
					continue;
				case 62:
					this.m_g.RootTable.Columns["mark6"].Visible = false;
					num = 18;
					continue;
				case 66:
					this.m_g.RootTable.Columns["mark4"].Visible = false;
					num = 17;
					continue;
				case 9:
					this.m_g.RootTable.Columns["mark16"].Visible = false;
					num = 38;
					continue;
				case 49:
				case 54:
					flag = !(dataTable.Rows[0]["book6"].ToString() == "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 62;
						continue;
					}
					this.m_g.RootTable.Columns["mark6"].Caption = dataTable.Rows[0]["book6"].ToString();
					num = 30;
					continue;
				case 17:
				case 56:
					flag = !(dataTable.Rows[0]["book5"].ToString() == "");
					num = 41;
					continue;
				case 41:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark5"].Caption = dataTable.Rows[0]["book5"].ToString();
						num = 49;
					}
					else
					{
						num = 3;
					}
					continue;
				case 14:
					((Control)this.m_g).Visible = false;
					num = 51;
					continue;
				case 29:
				case 61:
					flag = !(dataTable.Rows[0]["book10"].ToString() == "");
					num = 32;
					continue;
				case 32:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark10"].Caption = dataTable.Rows[0]["book10"].ToString();
						num = 44;
					}
					else
					{
						num = 45;
					}
					continue;
				case 31:
					this.m_g.RootTable.Columns["mark7"].Visible = false;
					num = 81;
					continue;
				case 19:
					this.m_g.RootTable.Columns["mark15"].Visible = false;
					num = 35;
					continue;
				case 65:
				case 73:
					flag = !(dataTable.Rows[0]["book9"].ToString() == "");
					num = 36;
					continue;
				case 36:
					if (!flag)
					{
						num = 64;
						continue;
					}
					this.m_g.RootTable.Columns["mark9"].Caption = dataTable.Rows[0]["book9"].ToString();
					num = 29;
					continue;
				case 70:
					this.m_g.RootTable.Columns["mark17"].Visible = false;
					num = 67;
					continue;
				case 58:
				case 83:
					flag = !(dataTable.Rows[0]["book2"].ToString() == "");
					num = 82;
					continue;
				case 82:
					if (!flag)
					{
						num = 77;
						continue;
					}
					this.m_g.RootTable.Columns["mark2"].Caption = dataTable.Rows[0]["book2"].ToString();
					num = 48;
					continue;
				case 51:
				{
					SqlParameter[] a_ = new SqlParameter[3]
					{
						asdcb.a("@xTerm", SqlDbType.Int, t),
						asdcb.a("@xClass", SqlDbType.Int, this.m_h.SelectedValue.ToString()),
						asdcb.a("@xYear", SqlDbType.Int, ((Control)this.m_j).Text)
					};
					dataTable = asdcb.c(asdab.e(), CommandType.StoredProcedure, "sp_SelectStdForSetAcp", a_);
					this.m_g.DataSource = dataTable;
					this.m_g.RootTable.Columns["mark1"].Visible = true;
					this.m_g.RootTable.Columns["mark2"].Visible = true;
					this.m_g.RootTable.Columns["mark3"].Visible = true;
					this.m_g.RootTable.Columns["mark4"].Visible = true;
					this.m_g.RootTable.Columns["mark5"].Visible = true;
					this.m_g.RootTable.Columns["mark6"].Visible = true;
					this.m_g.RootTable.Columns["mark7"].Visible = true;
					this.m_g.RootTable.Columns["mark8"].Visible = true;
					this.m_g.RootTable.Columns["mark9"].Visible = true;
					this.m_g.RootTable.Columns["mark10"].Visible = true;
					this.m_g.RootTable.Columns["mark11"].Visible = true;
					this.m_g.RootTable.Columns["mark12"].Visible = true;
					this.m_g.RootTable.Columns["mark13"].Visible = true;
					this.m_g.RootTable.Columns["mark14"].Visible = true;
					this.m_g.RootTable.Columns["mark15"].Visible = true;
					this.m_g.RootTable.Columns["mark16"].Visible = true;
					this.m_g.RootTable.Columns["mark17"].Visible = true;
					this.m_g.RootTable.Columns["mark18"].Visible = true;
					flag = dataTable.Rows.Count <= 0;
					num = 50;
					continue;
				}
				case 50:
					if (!flag)
					{
						num = 80;
						continue;
					}
					goto case 33;
				case 24:
				case 75:
					num = 33;
					continue;
				case 30:
					if (1 == 0)
					{
					}
					goto case 18;
				case 25:
				case 35:
					flag = !(dataTable.Rows[0]["book16"].ToString() == "");
					num = 47;
					continue;
				case 47:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark16"].Caption = dataTable.Rows[0]["book16"].ToString();
						num = 5;
					}
					else
					{
						num = 9;
					}
					continue;
				case 79:
					this.m_g.RootTable.Columns["mark1"].Visible = false;
					num = 58;
					continue;
				case 18:
					flag = !(dataTable.Rows[0]["book7"].ToString() == "");
					num = 78;
					continue;
				case 78:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark7"].Caption = dataTable.Rows[0]["book7"].ToString();
						num = 10;
					}
					else
					{
						num = 31;
					}
					continue;
				case 22:
					this.m_g.RootTable.Columns["mark13"].Visible = false;
					num = 27;
					continue;
				case 5:
				case 38:
					flag = !(dataTable.Rows[0]["book17"].ToString() == "");
					num = 37;
					continue;
				case 37:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark17"].Caption = dataTable.Rows[0]["book17"].ToString();
						num = 57;
					}
					else
					{
						num = 70;
					}
					continue;
				case 33:
				{
					GridEXFormatCondition val = new GridEXFormatCondition(this.m_g.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
					val.FormatStyle.ForeColor = SystemColors.WindowText;
					val.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					this.m_g.RootTable.FormatConditions.Add(val);
					GridEXFormatCondition val2 = new GridEXFormatCondition(this.m_g.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
					val2.FormatStyle.ForeColor = SystemColors.WindowText;
					val2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					this.m_g.RootTable.FormatConditions.Add(val2);
					e();
					flag = !n.Checked;
					num = 71;
					continue;
				}
				case 71:
					if (!flag)
					{
						num = 39;
						continue;
					}
					goto case 15;
				case 7:
					this.m_g.RootTable.Columns["mark3"].Visible = false;
					num = 63;
					continue;
				case 12:
					this.m_g.RootTable.Columns["mark12"].Visible = false;
					num = 59;
					continue;
				case 34:
				case 40:
					flag = !(dataTable.Rows[0]["book12"].ToString() == "");
					num = 0;
					continue;
				case 0:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark12"].Caption = dataTable.Rows[0]["book12"].ToString();
						num = 16;
					}
					else
					{
						num = 12;
					}
					continue;
				case 42:
				case 69:
					flag = !(dataTable.Rows[0]["book15"].ToString() == "");
					num = 55;
					continue;
				case 55:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark15"].Caption = dataTable.Rows[0]["book15"].ToString();
						num = 25;
					}
					else
					{
						num = 19;
					}
					continue;
				case 44:
				case 52:
					flag = !(dataTable.Rows[0]["book11"].ToString() == "");
					num = 74;
					continue;
				case 74:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark11"].Caption = dataTable.Rows[0]["book11"].ToString();
						num = 40;
					}
					else
					{
						num = 60;
					}
					continue;
				case 45:
					this.m_g.RootTable.Columns["mark10"].Visible = false;
					num = 52;
					continue;
				case 64:
					this.m_g.RootTable.Columns["mark9"].Visible = false;
					num = 61;
					continue;
				case 16:
				case 59:
					flag = !(dataTable.Rows[0]["book13"].ToString() == "");
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark13"].Caption = dataTable.Rows[0]["book13"].ToString();
						num = 11;
					}
					else
					{
						num = 22;
					}
					continue;
				case 43:
					this.m_g.RootTable.Columns["mark14"].Visible = false;
					num = 42;
					continue;
				case 15:
					((Control)p).Visible = false;
					num = 53;
					continue;
				case 53:
					return;
				case 80:
					flag = !(dataTable.Rows[0]["book1"].ToString() == "");
					num = 23;
					continue;
				case 23:
					if (flag)
					{
						this.m_g.RootTable.Columns["mark1"].Caption = dataTable.Rows[0]["book1"].ToString();
						num = 83;
					}
					else
					{
						num = 79;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected Obj, but got Unknown
		int num4 = default;
		int num6 = default;
		GridEXFormatStyle val = default;
		int num2 = default;
		while (true)
		{
			bool flag = !n.Checked;
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
					return;
				case 13:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_00e2:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark13"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
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
									goto case 2;
								case 0:
									this.m_g.GetRow(num4).Cells["mark13"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_00c9;
								}
								goto IL_00e2;
								continue;
								end_IL_00c9:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 20;
					continue;
				}
				case 2:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_01a0:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark10"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
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
									goto case 1;
								case 0:
									this.m_g.GetRow(num4).Cells["mark10"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0187;
								}
								goto IL_01a0;
								continue;
								end_IL_0187:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 23;
					continue;
				}
				case 18:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_02c6:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark3"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
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
									goto case 2;
								case 0:
									this.m_g.GetRow(num4).Cells["mark3"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_02ad;
								}
								goto IL_02c6;
								continue;
								end_IL_02ad:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 21;
					continue;
				}
				case 16:
				case 31:
					flag = num4 < this.m_g.RowCount;
					num = 10;
					continue;
				case 10:
				{
					if (!flag)
					{
						num = 11;
						continue;
					}
					float num3 = 0f;
					num = 17;
					continue;
				}
				case 28:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_03d7:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark7"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 0;
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
									this.m_g.GetRow(num4).Cells["mark7"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_03be;
								}
								goto IL_03d7;
								continue;
								end_IL_03be:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 29;
					continue;
				}
				case 7:
					if (true)
					{
					}
					num6 = 16;
					flag = !(t == "3");
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 24;
				case 0:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_04de:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark2"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
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
									goto case 0;
								case 1:
									this.m_g.GetRow(num4).Cells["mark2"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_04c5;
								}
								goto IL_04de;
								continue;
								end_IL_04c5:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 18;
					continue;
				}
				case 19:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_05b6:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark17"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
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
									goto case 1;
								case 0:
									this.m_g.GetRow(num4).Cells["mark17"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_059d;
								}
								goto IL_05b6;
								continue;
								end_IL_059d:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 5;
					continue;
				}
				case 21:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_06f6:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark4"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									this.m_g.GetRow(num4).Cells["mark4"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_06dd;
								}
								goto IL_06f6;
								continue;
								end_IL_06dd:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 30;
					continue;
				}
				case 24:
					num2 = 20;
					flag = !(t == "3");
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 12;
				case 22:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_080e:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark6"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									this.m_g.GetRow(num4).Cells["mark6"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_07f5;
								}
								goto IL_080e;
								continue;
								end_IL_07f5:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 28;
					continue;
				}
				case 3:
					num6 = 40;
					num = 24;
					continue;
				case 30:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_08e2:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark5"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
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
									this.m_g.GetRow(num4).Cells["mark5"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 3;
									continue;
								case 3:
									goto end_IL_08c9;
								}
								goto IL_08e2;
								continue;
								end_IL_08c9:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 22;
					continue;
				}
				case 25:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_09a0:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark1"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 0;
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
									goto case 1;
								case 3:
									this.m_g.GetRow(num4).Cells["mark1"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0987;
								}
								goto IL_09a0;
								continue;
								end_IL_0987:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 0;
					continue;
				}
				case 4:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0a5e:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark15"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 0;
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
									goto case 1;
								case 3:
									this.m_g.GetRow(num4).Cells["mark15"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0a45;
								}
								goto IL_0a5e;
								continue;
								end_IL_0a45:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 15;
					continue;
				}
				case 12:
				{
					float num3 = 0f;
					float num5 = 0f;
					val = new GridEXFormatStyle();
					val.BackColor = Color.Red;
					num4 = 0;
					num = 31;
					continue;
				}
				case 8:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0b6c:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark12"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
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
									goto case 3;
								case 2:
									this.m_g.GetRow(num4).Cells["mark12"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_0b53;
								}
								goto IL_0b6c;
								continue;
								end_IL_0b53:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 13;
					continue;
				}
				case 15:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0c5e:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark16"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 2;
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
									goto case 0;
								case 1:
									this.m_g.GetRow(num4).Cells["mark16"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 3;
									continue;
								case 3:
									goto end_IL_0c45;
								}
								goto IL_0c5e;
								continue;
								end_IL_0c45:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 19;
					continue;
				}
				case 5:
					try
					{
						while (true)
						{
							IL_0d1c:
							float num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark18"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									this.m_g.GetRow(num4).Cells["mark18"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0d03;
								}
								goto IL_0d1c;
								continue;
								end_IL_0d03:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num4++;
					num = 16;
					continue;
				case 23:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0dda:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark11"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 0;
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
									this.m_g.GetRow(num4).Cells["mark11"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_0dc1;
								}
								goto IL_0dda;
								continue;
								end_IL_0dc1:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 8;
					continue;
				}
				case 29:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0e98:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark8"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 1;
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
									goto case 2;
								case 0:
									this.m_g.GetRow(num4).Cells["mark8"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_0e7f;
								}
								goto IL_0e98;
								continue;
								end_IL_0e7f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 6;
					continue;
				}
				case 20:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_0f8a:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark14"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 1;
								case 3:
									this.m_g.GetRow(num4).Cells["mark14"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_0f71;
								}
								goto IL_0f8a;
								continue;
								end_IL_0f71:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 4;
					continue;
				}
				case 6:
				{
					float num5;
					try
					{
						while (true)
						{
							IL_1048:
							num5 = float.Parse(this.m_g.GetRow(num4).Cells["mark9"].Value.ToString());
							flag = !(num5 < (float)num6);
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									this.m_g.GetRow(num4).Cells["mark9"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_102f;
								}
								goto IL_1048;
								continue;
								end_IL_102f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num5 = 0f;
					num = 2;
					continue;
				}
				case 11:
					num = 9;
					continue;
				case 9:
					return;
				case 17:
				{
					try
					{
						while (true)
						{
							IL_1148:
							float num3 = float.Parse(this.m_g.GetRow(num4).Cells["markkoll"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 2;
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
									goto case 3;
								case 1:
									this.m_g.GetRow(num4).Cells["markkoll"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_112f;
								}
								goto IL_1148;
								continue;
								end_IL_112f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					float num5 = 0f;
					num = 25;
					continue;
				}
				case 26:
					num2 = 50;
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between I4 and Unknown
		while (true)
		{
			if (true)
			{
			}
			bool flag = v;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 8;
				case 5:
					try
					{
						this.m_g.CurrentColumn = this.m_g.GetRow(0).Cells["gTerm"].Column;
						((Control)this.m_g).Select();
						this.m_g.SelectCurrentCellText();
					}
					catch
					{
					}
					w = this.m_h.SelectedIndex;
					num = 7;
					continue;
				case 0:
					x = false;
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					flag = !x;
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 3;
					continue;
				case 8:
					x = false;
					v = true;
					c();
					num = 5;
					continue;
				case 7:
					return;
				case 10:
					x = true;
					this.m_h.SelectedIndex = w;
					num = 9;
					continue;
				case 9:
					return;
				case 3:
					num = ((!flag) ? 10 : 8);
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		bool flag = default;
		while (true)
		{
			SqlCommand val = null;
			y = true;
			string text = "";
			int num = 0;
			((DbConnection)(object)r).Open();
			int num2 = 0;
			int num3 = 10;
			while (true)
			{
				switch (num3)
				{
				case 7:
				case 13:
					num3 = 3;
					continue;
				case 12:
					num3 = 7;
					continue;
				case 0:
				case 10:
					flag = num2 < this.m_g.RowCount;
					num3 = 14;
					continue;
				case 14:
					if (!flag)
					{
						num3 = 15;
						continue;
					}
					text = "";
					num3 = 6;
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_00fc:
							flag = !(this.m_g.GetRow(num2).Cells["acpFinal"].Text != "");
							if (true)
							{
							}
							num3 = 1;
							while (true)
							{
								switch (num3)
								{
								case 1:
									num3 = (flag ? 4 : 2);
									continue;
								case 2:
									short.Parse(this.m_g.GetRow(num2).Cells["acpFinal"].Value.ToString());
									text = this.m_g.GetRow(num2).Cells["acpFinal"].Value.ToString();
									num3 = 3;
									continue;
								case 4:
									goto end_IL_00df;
								case 3:
									num3 = 0;
									continue;
								case 0:
									goto IL_02af;
								}
								goto IL_00fc;
								continue;
								end_IL_00df:
								break;
							}
							break;
						}
					}
					catch
					{
						this.m_g.GetRow(num2).BeginEdit();
						this.m_g.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_g.GetRow(num2).EndEdit();
					}
					goto case 3;
				case 3:
					num2++;
					num3 = 0;
					continue;
				case 4:
					MessageBox.Show("تعداد " + num + " ردیف انجام شد");
					num3 = 9;
					continue;
				case 9:
					return;
				case 1:
				case 16:
				{
					int num4 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num4 >= 1;
					num3 = 5;
					continue;
				}
				case 5:
					if (!flag)
					{
						num3 = 12;
						continue;
					}
					this.m_g.GetRow(num2).BeginEdit();
					this.m_g.GetRow(num2).Cells["acp"].Value = "1";
					this.m_g.GetRow(num2).EndEdit();
					num++;
					num3 = 13;
					continue;
				case 8:
					if (!flag)
					{
						num3 = 2;
						continue;
					}
					val.Parameters.AddWithValue("@Acp", (object)text);
					num3 = 1;
					continue;
				case 15:
					((DbConnection)(object)r).Close();
					((Control)this.m_g).Refresh();
					v = true;
					y = false;
					a();
					flag = num <= 0;
					num3 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num3 = 4;
						continue;
					}
					return;
				case 2:
					{
						val.Parameters.AddWithValue("@Acp", (object)DBNull.Value);
						num3 = 16;
						continue;
					}
					IL_02af:
					val = new SqlCommand("update tYear_Student set " + u + "=@Acp where id=@id", r);
					val.Parameters.AddWithValue("@id", (object)this.m_g.GetRow(num2).Cells["id"].Text.ToString());
					flag = text != null;
					num3 = 8;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		v = false;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)A_1.KeyCode != 116;
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
					((Control)this.m_g).Refresh();
					g(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = v;
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
					return;
				case 5:
					return;
				case 4:
					((CancelEventArgs)(object)A_1).Cancel = true;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 2;
					continue;
				case 2:
					if (flag)
					{
						if (true)
						{
						}
						num = 5;
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

	private void f(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			v = false;
			y = true;
			int num = 0;
			int num2 = 2;
			while (true)
			{
				if (true)
				{
				}
				switch (num2)
				{
				case 0:
				case 2:
					flag = num < this.m_g.RowCount;
					num2 = 1;
					continue;
				case 1:
					num2 = ((!flag) ? 4 : 3);
					continue;
				case 3:
					try
					{
						this.m_g.GetRow(num).BeginEdit();
						this.m_g.GetRow(num).Cells["acp"].Value = DBNull.Value;
						this.m_g.GetRow(num).Cells["AcpFinal"].Value = this.m_g.GetRow(num).Cells["AcpDef"].Text.ToString();
						this.m_g.GetRow(num).EndEdit();
					}
					catch
					{
					}
					num++;
					num2 = 0;
					continue;
				case 4:
					y = false;
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
	}

	private void d(object A_0, EventArgs A_1)
	{
		e();
	}

	private void c(object A_0, EventArgs A_1)
	{
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !n.Checked;
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
					((Control)this.m_g).Refresh();
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					((Control)this.m_g).Visible = false;
					((Control)this.m_g).Visible = true;
					a();
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

	private void a(object A_0, RowLoadEventArgs A_1)
	{
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected Obj, but got Unknown
		bool flag = default;
		int num4 = default;
		GridEXFormatStyle val = default;
		int num2 = default;
		while (true)
		{
			int num = 18;
			while (true)
			{
				int num6;
				switch (num)
				{
				case 18:
					num = ((!n.Checked) ? 2 : 12);
					continue;
				case 20:
				{
					try
					{
						while (true)
						{
							IL_01a5:
							float num5 = float.Parse(A_1.Row.Cells["markkoll"].Value.ToString());
							flag = !(num5 < (float)num4);
							num = 0;
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
									goto case 3;
								case 2:
									A_1.Row.Cells["markkoll"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 1;
									continue;
								case 1:
									goto end_IL_018c;
								}
								goto IL_01a5;
								continue;
								end_IL_018c:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					float num3 = 0f;
					num = 31;
					continue;
				}
				case 27:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0255:
							num3 = float.Parse(A_1.Row.Cells["mark12"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									A_1.Row.Cells["mark12"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_023c;
								}
								goto IL_0255;
								continue;
								end_IL_023c:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 11;
					continue;
				}
				case 6:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0305:
							num3 = float.Parse(A_1.Row.Cells["mark17"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 1;
								case 2:
									A_1.Row.Cells["mark17"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_02ec;
								}
								goto IL_0305;
								continue;
								end_IL_02ec:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 4;
					continue;
				}
				case 23:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_03cf:
							num3 = float.Parse(A_1.Row.Cells["mark16"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 3;
								case 0:
									A_1.Row.Cells["mark16"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_03b6;
								}
								goto IL_03cf;
								continue;
								end_IL_03b6:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 6;
					continue;
				}
				case 12:
					num = 17;
					continue;
				case 17:
					num6 = (y ? 1 : 0);
					goto IL_0938;
				case 1:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_04b2:
							num3 = float.Parse(A_1.Row.Cells["mark3"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 0;
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
									goto case 1;
								case 3:
									A_1.Row.Cells["mark3"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 2;
									continue;
								case 2:
									goto end_IL_0499;
								}
								goto IL_04b2;
								continue;
								end_IL_0499:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 8;
					continue;
				}
				case 0:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0562:
							num3 = float.Parse(A_1.Row.Cells["mark14"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									A_1.Row.Cells["mark14"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 3;
									continue;
								case 3:
									goto end_IL_0549;
								}
								goto IL_0562;
								continue;
								end_IL_0549:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 29;
					continue;
				}
				case 15:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0629:
							num3 = float.Parse(A_1.Row.Cells["mark6"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 3;
								case 2:
									A_1.Row.Cells["mark6"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_0610;
								}
								goto IL_0629;
								continue;
								end_IL_0610:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 22;
					continue;
				}
				case 19:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_06d9:
							num3 = float.Parse(A_1.Row.Cells["mark11"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 1;
								case 2:
									A_1.Row.Cells["mark11"].FormatStyle = val;
									num = 1;
									continue;
								case 1:
									num = 0;
									continue;
								case 0:
									goto end_IL_06c0;
								}
								goto IL_06d9;
								continue;
								end_IL_06c0:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 27;
					continue;
				}
				case 8:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0789:
							num3 = float.Parse(A_1.Row.Cells["mark4"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 3;
								case 0:
									A_1.Row.Cells["mark4"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_0770;
								}
								goto IL_0789;
								continue;
								end_IL_0770:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 13;
					continue;
				}
				case 25:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0839:
							num3 = float.Parse(A_1.Row.Cells["mark2"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 0;
								case 3:
									A_1.Row.Cells["mark2"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0820;
								}
								goto IL_0839;
								continue;
								end_IL_0820:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 1;
					continue;
				}
				case 29:
				{
					if (true)
					{
					}
					float num3;
					try
					{
						while (true)
						{
							IL_00f5:
							num3 = float.Parse(A_1.Row.Cells["mark15"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 0;
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
									goto case 3;
								case 1:
									A_1.Row.Cells["mark15"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_00dc;
								}
								goto IL_00f5;
								continue;
								end_IL_00dc:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 23;
					continue;
				}
				case 9:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 14:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_097d:
							num3 = float.Parse(A_1.Row.Cells["mark8"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									A_1.Row.Cells["mark8"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0964;
								}
								goto IL_097d;
								continue;
								end_IL_0964:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 30;
					continue;
				}
				case 28:
				{
					float num5 = 0f;
					float num3 = 0f;
					val = new GridEXFormatStyle();
					val.BackColor = Color.Red;
					num5 = 0f;
					num = 20;
					continue;
				}
				case 2:
					num6 = 1;
					goto IL_0938;
				case 5:
					num2 = 40;
					num = 3;
					continue;
				case 31:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0af8:
							num3 = float.Parse(A_1.Row.Cells["mark1"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
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
									goto case 2;
								case 0:
									A_1.Row.Cells["mark1"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_0adf;
								}
								goto IL_0af8;
								continue;
								end_IL_0adf:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 25;
					continue;
				}
				case 13:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0ba8:
							num3 = float.Parse(A_1.Row.Cells["mark5"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 0;
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
									goto case 3;
								case 1:
									A_1.Row.Cells["mark5"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 2;
									continue;
								case 2:
									goto end_IL_0b8f;
								}
								goto IL_0ba8;
								continue;
								end_IL_0b8f:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 15;
					continue;
				}
				case 11:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0c72:
							num3 = float.Parse(A_1.Row.Cells["mark13"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
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
									goto case 2;
								case 0:
									A_1.Row.Cells["mark13"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 1;
									continue;
								case 1:
									goto end_IL_0c59;
								}
								goto IL_0c72;
								continue;
								end_IL_0c59:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 0;
					continue;
				}
				case 10:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0d3c:
							num3 = float.Parse(A_1.Row.Cells["mark10"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 3;
								case 2:
									A_1.Row.Cells["mark10"].FormatStyle = val;
									num = 3;
									continue;
								case 3:
									num = 0;
									continue;
								case 0:
									goto end_IL_0d23;
								}
								goto IL_0d3c;
								continue;
								end_IL_0d23:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 19;
					continue;
				}
				case 3:
					num4 = 20;
					flag = !(t == "3");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 26;
						continue;
					}
					goto case 28;
				case 30:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0e5a:
							num3 = float.Parse(A_1.Row.Cells["mark9"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									A_1.Row.Cells["mark9"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0e41;
								}
								goto IL_0e5a;
								continue;
								end_IL_0e41:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 10;
					continue;
				}
				case 7:
					return;
				case 22:
				{
					float num3;
					try
					{
						while (true)
						{
							IL_0f39:
							num3 = float.Parse(A_1.Row.Cells["mark7"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 2;
										continue;
									}
									goto case 0;
								case 2:
									A_1.Row.Cells["mark7"].FormatStyle = val;
									num = 0;
									continue;
								case 0:
									num = 1;
									continue;
								case 1:
									goto end_IL_0f20;
								}
								goto IL_0f39;
								continue;
								end_IL_0f20:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num3 = 0f;
					num = 14;
					continue;
				}
				case 26:
					num4 = 50;
					num = 28;
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_1019:
							float num3 = float.Parse(A_1.Row.Cells["mark18"].Value.ToString());
							flag = !(num3 < (float)num2);
							num = 1;
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
									goto case 2;
								case 0:
									A_1.Row.Cells["mark18"].FormatStyle = val;
									num = 2;
									continue;
								case 2:
									num = 3;
									continue;
								case 3:
									goto end_IL_1000;
								}
								goto IL_1019;
								continue;
								end_IL_1000:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 7;
					continue;
				case 16:
					num2 = 16;
					flag = !(t == "3");
					num = 24;
					continue;
				case 24:
					{
						if (!flag)
						{
							num = 5;
							continue;
						}
						goto case 3;
					}
					IL_0938:
					flag = (byte)num6 != 0;
					num = 9;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)this).Refresh();
		try
		{
			while (true)
			{
				IL_0025:
				s = asdcb.a(asdab.e(), CommandType.Text, "select id from tExam where xYear=" + ((Control)this.m_j).Text + "  and term=" + t).ToString();
				string text = asdcb.a(asdab.e(), CommandType.Text, "select procc from tExam where id=" + s).ToString();
				bool flag = !(text != "1");
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
						goto case 0;
					case 1:
					{
						SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@Exam", SqlDbType.Int, s) };
						asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_Procc", a_);
						asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_CalcMarkDoreh", a_);
						asdcb.d(asdab.e(), CommandType.Text, "update tExam set procc=1 where id=@Exam", a_);
						num = 0;
						continue;
					}
					case 0:
						d();
						this.m_g.CurrentColumn = this.m_g.GetRow(0).Cells["gTerm"].Column;
						((Control)this.m_g).Select();
						this.m_g.SelectCurrentCellText();
						num = 2;
						continue;
					case 2:
						goto end_IL_000c;
					}
					goto IL_0025;
					continue;
					end_IL_000c:
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
}
