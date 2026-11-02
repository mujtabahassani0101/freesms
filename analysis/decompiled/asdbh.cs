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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdbh : Form
{
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

	private SqlConnection ai = new SqlConnection(asdab.e());

	private string aj;

	private bool ak = false;

	private string al = "1";

	private int am = -1;

	private bool an = true;

	public asdbh()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		f();
	}

	protected override void a(bool A_0)
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
					((Form)this).Dispose(A_0);
					return;
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
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected Obj, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected Obj, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected Obj, but got Unknown
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected Obj, but got Unknown
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected Obj, but got Unknown
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected Obj, but got Unknown
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected Obj, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected Obj, but got Unknown
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected Obj, but got Unknown
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected Obj, but got Unknown
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e92: Expected Obj, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected Obj, but got Unknown
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcc: Expected Obj, but got Unknown
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected Obj, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected Obj, but got Unknown
		//IL_1431: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected Obj, but got Unknown
		//IL_145c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1466: Expected Obj, but got Unknown
		//IL_1478: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Expected Obj, but got Unknown
		//IL_1572: Unknown result type (might be due to invalid IL or missing references)
		//IL_157c: Expected Obj, but got Unknown
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected Obj, but got Unknown
		//IL_167e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1688: Expected Obj, but got Unknown
		//IL_169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a4: Expected Obj, but got Unknown
		//IL_1810: Unknown result type (might be due to invalid IL or missing references)
		//IL_181a: Expected Obj, but got Unknown
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1838: Expected Obj, but got Unknown
		//IL_1a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3f: Expected Obj, but got Unknown
		//IL_1ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ece: Expected Obj, but got Unknown
		//IL_1fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fab: Expected Obj, but got Unknown
		//IL_2003: Unknown result type (might be due to invalid IL or missing references)
		//IL_200d: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbh));
		GridEXLayout val2 = new GridEXLayout();
		StringFormat val3 = new StringFormat();
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
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_k).SuspendLayout();
		((Control)x).SuspendLayout();
		((ISupportInitialize)s).BeginInit();
		((ISupportInitialize)this.m_i).BeginInit();
		((Control)z).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(5, 6);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(695, 700);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_b).Controls.Add((Control)(object)q);
		((Control)this.m_b).Controls.Add((Control)(object)r);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_b).Controls.Add((Control)(object)t);
		((Control)this.m_b).Controls.Add((Control)(object)u);
		((Control)this.m_b).Controls.Add((Control)(object)v);
		((Control)this.m_b).Controls.Add((Control)(object)w);
		((Control)this.m_b).Controls.Add((Control)(object)z);
		((Control)this.m_b).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_b).Location = new Point(8, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).RightToLeft = (RightToLeft)1;
		((Control)this.m_b).Size = new Size(679, 680);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_k).BackColor = Color.Silver;
		this.m_k.BorderStyle = (BorderStyle)1;
		((Control)this.m_k).Controls.Add((Control)(object)x);
		((Control)this.m_k).Location = new Point(116, 3);
		((Control)this.m_k).Name = "pStdMark";
		((Control)this.m_k).Size = new Size(489, 664);
		((Control)this.m_k).TabIndex = 74;
		((Control)this.m_k).Visible = false;
		((Control)x).BackColor = Color.FromArgb(214, 223, 247);
		x.BorderStyle = (BorderStyle)1;
		((Control)x).Controls.Add((Control)(object)ag);
		((Control)x).Controls.Add((Control)(object)af);
		((Control)x).Controls.Add((Control)(object)ae);
		((Control)x).Controls.Add((Control)(object)ac);
		((Control)x).Controls.Add((Control)(object)ad);
		((Control)x).Controls.Add((Control)(object)y);
		((Control)x).Controls.Add((Control)(object)this.m_n);
		((Control)x).Controls.Add((Control)(object)s);
		((Control)x).Controls.Add((Control)(object)this.m_l);
		((Control)x).Controls.Add((Control)(object)o);
		((Control)x).Controls.Add((Control)(object)this.m_m);
		((Control)x).Controls.Add((Control)(object)p);
		((Control)x).Location = new Point(3, 3);
		((Control)x).Name = "panel3";
		((Control)x).Size = new Size(481, 655);
		((Control)x).TabIndex = 81;
		((Control)af).Enabled = false;
		((Control)af).Location = new Point(126, 579);
		((Control)af).Name = "txtSumMark";
		((Control)af).RightToLeft = (RightToLeft)0;
		((Control)af).Size = new Size(82, 23);
		((Control)af).TabIndex = 89;
		af.TextAlign = (HorizontalAlignment)2;
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(211, 582);
		((Control)ae).Name = "label2";
		((Control)ae).Size = new Size(100, 16);
		((Control)ae).TabIndex = 87;
		((Control)ae).Text = "مجموع نمرات :";
		((Control)ac).AutoSize = true;
		((Control)ac).Location = new Point(396, 91);
		((Control)ac).Name = "label1";
		((Control)ac).Size = new Size(49, 16);
		((Control)ac).TabIndex = 86;
		((Control)ac).Text = "درجه :";
		((EditBase)ad).AutoScroll = false;
		((EditBase)ad).AutoScrollMargin = new Size(0, 0);
		((EditBase)ad).AutoScrollMinSize = new Size(0, 0);
		((EditBase)ad).AutoScrollPosition = new Point(0, 0);
		((EditBase)ad).ButtonFont = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)ad).Location = new Point(324, 86);
		((EditBase)ad).MaxLength = 2;
		((Control)ad).Name = "txtGClass";
		((Control)ad).RightToLeft = (RightToLeft)0;
		((Control)ad).Size = new Size(66, 23);
		((Control)ad).TabIndex = 1;
		((Control)ad).Text = "0";
		((EditBase)ad).TextAlignment = (TextAlignment)2;
		ad.Value = (short)0;
		ad.ValueType = (NumericEditValueType)7;
		((Control)ad).Leave += a;
		((Control)ad).KeyUp += a;
		((Control)ad).Enter += b;
		((Control)y).BackColor = Color.FromArgb(255, 224, 192);
		y.BorderStyle = (BorderStyle)1;
		((Control)y).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)y).Location = new Point(293, 36);
		((Control)y).Name = "lExam";
		((Control)y).RightToLeft = (RightToLeft)1;
		((Control)y).Size = new Size(172, 38);
		((Control)y).TabIndex = 82;
		y.TextAlign = (ContentAlignment)32;
		((Control)this.m_n).BackColor = Color.FromArgb(192, 255, 192);
		this.m_n.BorderStyle = (BorderStyle)1;
		((Control)this.m_n).Font = new Font("Tahoma", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_n).Location = new Point(8, 34);
		((Control)this.m_n).Name = "lName";
		((Control)this.m_n).RightToLeft = (RightToLeft)1;
		((Control)this.m_n).Size = new Size(279, 42);
		((Control)this.m_n).TabIndex = 76;
		this.m_n.TextAlign = (ContentAlignment)32;
		((Control)s).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout5.LayoutString");
		s.DesignTimeLayout = val;
		s.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		s.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)s).Font = new Font("Tahoma", 9.75f);
		s.GroupByBoxVisible = false;
		((Control)s).Location = new Point(8, 118);
		((Control)s).Name = "gStdMark";
		((ScrollableBase)s).RecordNavigator = true;
		s.RowHeaders = (InheritableBoolean)1;
		s.SelectedFormatStyle.BackColor = Color.Empty;
		s.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)s).Size = new Size(458, 452);
		((Control)s).TabIndex = 2;
		((ScrollableBase)s).VisualStyle = (VisualStyle)2;
		s.SelectionChanged += d;
		((Control)s).KeyUp += e;
		s.CellUpdated += a;
		((Control)this.m_l).Anchor = (AnchorStyles)9;
		((Control)this.m_l).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_l.Image = (Image)componentResourceManager.GetObject("btnPrevious.Image");
		this.m_l.ImageIndex = 8;
		this.m_l.ImageSize = new Size(30, 30);
		((Control)this.m_l).Location = new Point(88, 2);
		((Control)this.m_l).Name = "btnPrevious";
		((Control)this.m_l).RightToLeft = (RightToLeft)1;
		((Control)this.m_l).Size = new Size(190, 26);
		((Control)this.m_l).TabIndex = 75;
		((Control)this.m_l).Text = "(pageUp)    قبلی  ";
		this.m_l.ToolTipText = "دکمه میانبر : PageUp";
		this.m_l.VisualStyle = (VisualStyle)1;
		((Control)this.m_l).Click += h;
		((Control)o).Anchor = (AnchorStyles)6;
		o.ButtonStyle = (ButtonStyle)1;
		((Control)o).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		o.Image = (Image)componentResourceManager.GetObject("btnAcptest.Image");
		o.ImageHorizontalAlignment = (ImageHorizontalAlignment)0;
		o.ImageIndex = 8;
		o.ImageSize = new Size(50, 50);
		((Control)o).Location = new Point(156, 612);
		((Control)o).Name = "btnAcptest";
		((Control)o).Size = new Size(144, 38);
		((Control)o).TabIndex = 77;
		((Control)o).Text = "(F5)تائيد";
		o.ToolTipText = "دکمه میانبر : F5";
		o.VisualStyle = (VisualStyle)1;
		((Control)o).Click += g;
		((Control)this.m_m).Anchor = (AnchorStyles)9;
		((Control)this.m_m).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnNext.Image");
		this.m_m.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_m.ImageIndex = 8;
		this.m_m.ImageSize = new Size(30, 30);
		((Control)this.m_m).Location = new Point(281, 2);
		((Control)this.m_m).Name = "btnNext";
		((Control)this.m_m).RightToLeft = (RightToLeft)1;
		((Control)this.m_m).Size = new Size(185, 26);
		((Control)this.m_m).TabIndex = 74;
		((Control)this.m_m).Tag = "";
		((Control)this.m_m).Text = "(pageDown)    بعدی  ";
		this.m_m.ToolTipText = "دکمه میانبر : PageDown";
		this.m_m.VisualStyle = (VisualStyle)1;
		((Control)this.m_m).Click += i;
		((Control)p).Anchor = (AnchorStyles)6;
		p.ButtonStyle = (ButtonStyle)1;
		((Control)p).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		p.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		p.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		p.ImageIndex = 8;
		p.ImageSize = new Size(30, 30);
		((Control)p).Location = new Point(8, 612);
		((Control)p).Name = "btnCancel";
		((Control)p).RightToLeft = (RightToLeft)1;
		((Control)p).Size = new Size(142, 38);
		((Control)p).TabIndex = 78;
		((Control)p).Text = "(Esc)انصراف";
		p.ToolTipText = "دکمه میانبر : Esc";
		p.VisualStyle = (VisualStyle)1;
		((Control)p).Click += m;
		this.m_i.AllowEdit = (InheritableBoolean)2;
		this.m_i.CardCaptionPrefix = "Product:";
		((Control)this.m_i).Cursor = Cursors.Default;
		this.m_i.DataMember = null;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout6.LayoutString");
		this.m_i.DesignTimeLayout = val2;
		this.m_i.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)this.m_i).FlatBorderColor = SystemColors.ControlDark;
		((Control)this.m_i).Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		this.m_i.GridLineColor = SystemColors.ScrollBar;
		this.m_i.GroupByBoxVisible = false;
		this.m_i.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)this.m_i).Location = new Point(7, 124);
		((Control)this.m_i).Name = "gstd";
		((ScrollableBase)this.m_i).RecordNavigator = true;
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		this.m_i.RowHeaders = (InheritableBoolean)1;
		this.m_i.SelectedFormatStyle.Blend = 0.5f;
		this.m_i.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_i).Size = new Size(657, 490);
		((Control)this.m_i).TabIndex = 67;
		((Control)this.m_i).TabStop = false;
		((ScrollableBase)this.m_i).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_i).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_i).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_i).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_i).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_i).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_i).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_i).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		this.m_i.SelectionChanged += f;
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((Control)this.m_f).Location = new Point(321, 10);
		((Control)this.m_f).Name = "label12";
		((Control)this.m_f).RightToLeft = (RightToLeft)1;
		((Control)this.m_f).Size = new Size(60, 26);
		((Control)this.m_f).TabIndex = 59;
		((Control)this.m_f).Text = "نام :";
		this.m_f.TextAlign = (ContentAlignment)64;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((EditBase)this.m_e).AutoScroll = false;
		((EditBase)this.m_e).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_e).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_e).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_e).Location = new Point(177, 10);
		((Control)this.m_e).Name = "txtNamFSearch";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(138, 23);
		((Control)this.m_e).TabIndex = 7;
		((EditBase)this.m_e).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_e).VisualStyle = (VisualStyle)2;
		((Control)this.m_e).KeyUp += c;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		this.m_d.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_d.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_d.ImageIndex = 8;
		this.m_d.ImageSize = new Size(30, 30);
		((Control)this.m_d).Location = new Point(7, 624);
		((Control)this.m_d).Name = "uiButton2";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		((Control)this.m_d).Size = new Size(104, 31);
		((Control)this.m_d).TabIndex = 65;
		((Control)this.m_d).Text = "خروج";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += l;
		((Control)this.m_c).Anchor = (AnchorStyles)9;
		this.m_c.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_c).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageIndex = 8;
		((Control)this.m_c).Location = new Point(500, 625);
		((Control)this.m_c).Name = "btnNew";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(164, 32);
		((Control)this.m_c).TabIndex = 62;
		((Control)this.m_c).Text = "(F2)ورود نمرات";
		this.m_c.ToolTipText = "دکمه میانبر : F2";
		this.m_c.VisualStyle = (VisualStyle)1;
		((Control)this.m_c).Click += j;
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((Control)this.m_j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnSearch.Image");
		this.m_j.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_j.ImageIndex = 8;
		this.m_j.ImageSize = new Size(30, 30);
		((Control)this.m_j).Location = new Point(177, 67);
		((Control)this.m_j).Name = "btnSearch";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(138, 31);
		((Control)this.m_j).TabIndex = 73;
		((Control)this.m_j).Text = "جستجو اسم(F3)";
		this.m_j.VisualStyle = (VisualStyle)1;
		((Control)this.m_j).Click += k;
		((Control)q).Anchor = (AnchorStyles)9;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(593, 16);
		((Control)q).Name = "label19";
		((Control)q).Size = new Size(48, 16);
		((Control)q).TabIndex = 78;
		((Control)q).Text = "صنف :";
		((Control)r).Anchor = (AnchorStyles)9;
		((UIComboBase)r).ComboStyle = (ComboStyle)1;
		((UIComboBase)r).DropListFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)r).Location = new Point(416, 13);
		((Control)r).Name = "dropCls";
		((Control)r).Size = new Size(171, 23);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)r).StringFormat = val3;
		((Control)r).TabIndex = 76;
		r.SelectedIndexChanged += e;
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((Control)this.m_h).Location = new Point(321, 36);
		((Control)this.m_h).Name = "label13";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(78, 28);
		((Control)this.m_h).TabIndex = 60;
		((Control)this.m_h).Text = "ولد /بنت :";
		this.m_h.TextAlign = (ContentAlignment)64;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((EditBase)this.m_g).AutoScroll = false;
		((EditBase)this.m_g).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_g).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_g).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_g).Location = new Point(177, 39);
		((Control)this.m_g).Name = "txtNamLSearch";
		((Control)this.m_g).RightToLeft = (RightToLeft)1;
		((Control)this.m_g).Size = new Size(138, 23);
		((Control)this.m_g).TabIndex = 6;
		((EditBase)this.m_g).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_g).VisualStyle = (VisualStyle)2;
		((Control)this.m_g).KeyUp += d;
		((Control)t).AutoSize = true;
		((Control)t).Location = new Point(65, 39);
		((Control)t).Name = "label4";
		((Control)t).Size = new Size(25, 16);
		((Control)t).TabIndex = 84;
		((Control)t).Text = "تا :";
		((Control)t).Visible = false;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((Control)u).Location = new Point(7, 36);
		((Control)u).Name = "txtMaxMark";
		((Control)u).Size = new Size(52, 23);
		((Control)u).TabIndex = 83;
		((Control)u).Text = "100";
		((EditBase)u).TextAlignment = (TextAlignment)1;
		u.Value = (short)100;
		u.ValueType = (NumericEditValueType)7;
		((Control)u).Visible = false;
		((EditBase)v).AutoScroll = false;
		((EditBase)v).AutoScrollMargin = new Size(0, 0);
		((EditBase)v).AutoScrollMinSize = new Size(0, 0);
		((EditBase)v).AutoScrollPosition = new Point(0, 0);
		((Control)v).Location = new Point(7, 9);
		((Control)v).Name = "txtMinMark";
		((Control)v).Size = new Size(52, 23);
		((Control)v).TabIndex = 82;
		((Control)v).Text = "0";
		((EditBase)v).TextAlignment = (TextAlignment)1;
		v.Value = (short)0;
		v.ValueType = (NumericEditValueType)7;
		((Control)v).Visible = false;
		((Control)w).AutoSize = true;
		((Control)w).Location = new Point(65, 10);
		((Control)w).Name = "label3";
		((Control)w).Size = new Size(83, 16);
		((Control)w).TabIndex = 81;
		((Control)w).Text = "رنج نمره از :";
		((Control)w).Visible = false;
		((Control)z).BackColor = Color.FromArgb(255, 192, 255);
		z.BorderStyle = (BorderStyle)1;
		((Control)z).Controls.Add((Control)(object)aa);
		((Control)z).Controls.Add((Control)(object)ab);
		((Control)z).Location = new Point(407, 48);
		((Control)z).Name = "panel4";
		((Control)z).Size = new Size(185, 58);
		((Control)z).TabIndex = 85;
		((Control)aa).AutoSize = true;
		((Control)aa).Location = new Point(29, 30);
		((Control)aa).Name = "r11";
		((Control)aa).Size = new Size(142, 20);
		((Control)aa).TabIndex = 1;
		((Control)aa).Text = "نمرات صنف یازدهم";
		((ButtonBase)aa).UseVisualStyleBackColor = true;
		((Control)ab).AutoSize = true;
		ab.Checked = true;
		((Control)ab).Location = new Point(43, 3);
		((Control)ab).Name = "r10";
		((Control)ab).Size = new Size(128, 20);
		((Control)ab).TabIndex = 0;
		ab.TabStop = true;
		((Control)ab).Text = "نمرات صنف دهم";
		((ButtonBase)ab).UseVisualStyleBackColor = true;
		ab.CheckedChanged += c;
		((Control)ag).AutoSize = true;
		((Control)ag).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)ag).ForeColor = Color.Maroon;
		((Control)ag).Location = new Point(9, 91);
		((Control)ag).Name = "label5";
		((Control)ag).Size = new Size(292, 16);
		((Control)ag).TabIndex = 90;
		((Control)ag).Text = "راهنمای درجه : 1 (الف)   2 (ب)   3(ج)   4 (د)   5(ه)";
		((Form)this).AutoScaleBaseSize = new Size(8, 26);
		((Control)this).BackColor = Color.FromArgb(184, 203, 255);
		((Form)this).ClientSize = new Size(706, 714);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Control)this).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmMarkEntryAgo";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Tag = "10";
		((Control)this).Text = "اطلاعات داوطلبان";
		((Form)this).Load += n;
		((Control)this).KeyUp += b;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)this.m_k).ResumeLayout(false);
		((Control)x).ResumeLayout(false);
		((Control)x).PerformLayout();
		((ISupportInitialize)s).EndInit();
		((ISupportInitialize)this.m_i).EndInit();
		((Control)z).ResumeLayout(false);
		((Control)z).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void e()
	{
		while (true)
		{
			string text = " where xPaye in(" + asdaj.n + ") and id in(SELECT DISTINCT xClass FROM tyear_student WHERE xYear=" + asdaj.a + " and (xPaye = 12))";
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass " + text);
			r.DataSource = dataSource;
			r.DisplayMember = "Name";
			r.ValueMember = "id";
			bool flag = ((CollectionBase)(object)r.Items).Count <= 0;
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
					r.SelectedIndex = 0;
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

	private void d()
	{
		DataTable dataTable = default;
		while (true)
		{
			string text = "";
			string text2 = "10";
			bool flag = !aa.Checked;
			int num = 21;
			while (true)
			{
				switch (num)
				{
				case 21:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 5;
				case 18:
					flag = !(text != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 0;
				case 10:
					text += " and ";
					num = 3;
					continue;
				case 19:
					((Control)this.m_e).Text = asdaj.b(((Control)this.m_e).Text.Trim());
					flag = !(text != "");
					num = 7;
					continue;
				case 7:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 16;
				case 0:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tmpstd.sort, tmpstd.id, tmpstd.Code, tmpstd.FName, tmpstd.LName, tmpstd.PName,tmpMark.Mark,tmpMark.gclass from\r\n                    (SELECT     tYear_Student.sort, tStudent.id, tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName, tStudent.NumberAsas\r\n                    FROM tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                    WHERE   (tYear_Student.xYear = " + asdaj.a + ") AND tYear_Student.xClass = " + r.SelectedValue.ToString() + text + ") tmpstd left outer join\r\n                    (SELECT     xStudent, mark,gClass\r\n                    FROM         tMarkAgo\r\n                    WHERE     (typ = 5) AND (xpaye = " + text2 + ")) tmpMark on tmpstd.id=tmpMark.xStudent");
					flag = dataTable.Rows.Count <= 0;
					num = 17;
					continue;
				case 17:
					if (!flag)
					{
						num = 2;
						continue;
					}
					this.m_i.DataSource = null;
					num = 14;
					continue;
				case 5:
					flag = !(((Control)this.m_e).Text.Trim() != "");
					num = 9;
					continue;
				case 9:
					if (!flag)
					{
						num = 19;
						continue;
					}
					goto IL_0382;
				case 8:
					text = " and " + text;
					num = 0;
					continue;
				case 14:
					return;
				case 11:
					((Control)this.m_g).Text = asdaj.b(((Control)this.m_g).Text.Trim());
					flag = !(text != "");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 3;
				case 1:
					text += " and ";
					num = 16;
					continue;
				case 2:
					this.m_i.DataSource = dataTable;
					num = 15;
					continue;
				case 15:
					return;
				case 3:
					text = text + " tStudent.LName Like N'%" + ((Control)this.m_g).Text + "%'";
					num = 18;
					continue;
				case 16:
					text = text + " tStudent.FName Like N'%" + ((Control)this.m_e).Text + "%'";
					num = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_0382;
				case 12:
					text2 = "11";
					num = 5;
					continue;
				case 4:
					{
						if (!flag)
						{
							num = 11;
							continue;
						}
						goto case 18;
					}
					IL_0382:
					flag = !(((Control)this.m_g).Text.Trim() != "");
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		DataTable dataTable2 = default;
		DataTable dataTable = default;
		while (true)
		{
			string text = "10";
			bool flag = !aa.Checked;
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
					goto case 9;
				case 8:
				case 10:
				{
					GridEXFormatCondition val = new GridEXFormatCondition(s.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
					val.FormatStyle.ForeColor = SystemColors.WindowText;
					val.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					s.RootTable.FormatConditions.Add(val);
					GridEXFormatCondition val2 = new GridEXFormatCondition(s.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
					val2.FormatStyle.ForeColor = SystemColors.WindowText;
					val2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					s.RootTable.FormatConditions.Add(val2);
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select  gClass,mark from tMarkAgo where  typ=5 and xpaye= " + text + " and xStudent= " + this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					flag = dataTable2.Rows.Count <= 0;
					num = 5;
					continue;
				}
				case 5:
					if (!flag)
					{
						num = 7;
						continue;
					}
					((Control)af).Text = "";
					((Control)ad).Text = "";
					num = 4;
					continue;
				case 9:
					((Control)this.m_n).Text = this.m_i.SelectedItems[0].GetRow().Cells["FName"].Value.ToString() + " " + this.m_i.SelectedItems[0].GetRow().Cells["LName"].Value.ToString();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select  0 as acp,    tmpbok.xbook, tmpbok.book, tmpbok.SortOneEntry,tmpbok.sort,tmpmark.mark as M1\r\n                    \r\n                    from\r\n                    (SELECT     id as xbook, Name as book, SortOneEntry,sort\r\n                        FROM         tBook\r\n                      WHERE     (xPaye = 12) AND (showOneEntry = 1))tmpbok\r\n                        left outer join\r\n                       (SELECT     xStudent, xbook, mark         \r\n                        FROM         tMarkAgo where  typ=1 and xpaye= " + text + " and xStudent= " + this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")tmpmark on tmpbok.xbook=tmpmark.xbook order by tmpbok.sort,tmpbok.xbook");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 6:
					if (flag)
					{
						s.DataSource = null;
						num = 8;
					}
					else
					{
						num = 3;
					}
					continue;
				case 4:
					if (1 == 0)
					{
					}
					return;
				case 0:
					text = "11";
					num = 9;
					continue;
				case 7:
					((Control)af).Text = dataTable2.Rows[0]["mark"].ToString();
					((Control)ad).Text = dataTable2.Rows[0]["gClass"].ToString();
					num = 2;
					continue;
				case 2:
					return;
				case 3:
					s.DataSource = dataTable;
					num = 10;
					continue;
				}
				break;
			}
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
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
						((Control)this.m_b).BackColor = Color.FromArgb(red, green, blue);
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
		((Control)this.m_k).Visible = false;
		d();
	}

	private void l(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void k(object A_0, EventArgs A_1)
	{
		d();
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = this.m_i.RowCount <= 0;
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
					return;
				case 3:
					((Control)y).Text = "نمرات صنف دهم";
					num = 4;
					continue;
				case 0:
					if (true)
					{
					}
					((Control)this.m_k).Visible = true;
					aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					c();
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					((Control)s).Select();
					s.SelectCurrentCellText();
					flag = !ab.Checked;
					num = 5;
					continue;
				case 5:
					if (flag)
					{
						((Control)y).Text = "نمرات صنف یازدهم";
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				case 2:
				case 4:
					((Control)ad).Focus();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_i.MoveNext();
		aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		c();
		s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
		((Control)s).Select();
		s.SelectCurrentCellText();
		((Control)ad).Focus();
	}

	private void b()
	{
		while (true)
		{
			bool flag = this.m_i.Row != 0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 5;
						continue;
					}
					((Control)this.m_l).Enabled = true;
					num = 3;
					continue;
				case 6:
					((Control)this.m_m).Enabled = false;
					num = 4;
					continue;
				case 4:
					return;
				case 3:
				case 7:
					flag = this.m_i.Row != this.m_i.RecordCount - 1;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					((Control)this.m_m).Enabled = true;
					num = 1;
					continue;
				case 5:
					((Control)this.m_l).Enabled = false;
					num = 7;
					continue;
				case 1:
					if (1 == 0)
					{
					}
					return;
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
		this.m_i.MovePrevious();
		aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
		c();
		s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
		((Control)s).Select();
		s.SelectCurrentCellText();
		((Control)ad).Focus();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Invalid comparison between Unknown and I4
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		SqlCommand val = default;
		int num6 = default;
		string text3 = default;
		float num4 = default;
		int num2 = default;
		int num3 = default;
		string text2 = default;
		int num5 = default;
		while (true)
		{
			string text = "10";
			bool flag = !aa.Checked;
			int num = 19;
			while (true)
			{
				int num9;
				int num8;
				switch (num)
				{
				case 19:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 25;
				case 41:
					num9 = 1;
					goto IL_0ab1;
				case 1:
					num8 = 0;
					goto IL_08b7;
				case 17:
					flag = ak;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 44;
						continue;
					}
					goto case 14;
				case 15:
					num = 3;
					continue;
				case 3:
					num9 = ((!(((Control)ad).Text != "")) ? 1 : 0);
					goto IL_0ab1;
				case 39:
					num = 9;
					continue;
				case 9:
					num8 = ((!(((Control)af).Text == "")) ? 1 : 0);
					goto IL_08b7;
				case 27:
					val = new SqlCommand("DELETE FROM tMarkAgo WHERE (xStudent = @xStudent) AND (xpaye = @xpaye) AND (xbook = @xbook)", ai);
					val.Parameters.AddWithValue("@xStudent", (object)aj);
					val.Parameters.AddWithValue("@xpaye", (object)text);
					val.Parameters.AddWithValue("@xbook", (object)s.GetRow(num6).Cells["xbook"].Text.ToString());
					((DbCommand)(object)val).ExecuteNonQuery();
					num = 22;
					continue;
				case 23:
					i(this, null);
					((Control)ad).Focus();
					num = 12;
					continue;
				case 4:
					return;
				case 31:
					text = "11";
					num = 25;
					continue;
				case 38:
					try
					{
						while (true)
						{
							IL_0377:
							flag = !(s.GetRow(num6).Cells["m1"].Text != "");
							num = 5;
							while (true)
							{
								int num7;
								switch (num)
								{
								case 5:
									if (!flag)
									{
										num = 4;
										continue;
									}
									text3 = null;
									num = 1;
									continue;
								case 7:
									num = 2;
									continue;
								case 2:
									num7 = ((!(num4 < (float)num2)) ? 1 : 0);
									goto IL_0501;
								case 4:
									num4 = float.Parse(s.GetRow(num6).Cells["m1"].Text.ToString());
									num = 3;
									continue;
								case 3:
									num = ((!(num4 > (float)num3)) ? 7 : 0);
									continue;
								case 0:
									num7 = 0;
									goto IL_0501;
								case 9:
									s.GetRow(num6).Cells["m1"].FormatStyle.BackColor = Color.Yellow;
									s.GetRow(num6).BeginEdit();
									s.GetRow(num6).Cells["acp"].Value = "-1";
									s.GetRow(num6).EndEdit();
									ak = true;
									num = 8;
									continue;
								case 8:
									goto end_IL_033e;
								case 10:
									if (flag)
									{
										text3 = num4.ToString();
										num = 11;
									}
									else
									{
										num = 9;
									}
									continue;
								case 1:
								case 11:
									num = 6;
									continue;
								case 6:
									goto IL_0702;
									IL_0501:
									flag = (byte)num7 != 0;
									num = 10;
									continue;
								}
								goto IL_0377;
								continue;
								end_IL_033e:
								break;
							}
							break;
						}
					}
					catch
					{
						s.GetRow(num6).BeginEdit();
						s.GetRow(num6).Cells["acp"].Value = "-1";
						s.GetRow(num6).EndEdit();
						ak = true;
					}
					goto case 8;
				case 32:
					val.Parameters.AddWithValue("@Mark", (object)DBNull.Value);
					num = 5;
					continue;
				case 44:
					flag = (int)MessageBox.Show("اطلاعات ذخیره شد . آیا مایل هستید نفر بعدی نمایش داده شود", "", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6;
					num = 43;
					continue;
				case 43:
					num = ((!flag) ? 23 : 40);
					continue;
				case 10:
					text2 = ((Control)ad).Text;
					num = 28;
					continue;
				case 6:
					num = 46;
					continue;
				case 29:
				case 46:
					num = 8;
					continue;
				case 35:
					val = new SqlCommand("DELETE FROM tMarkAgo WHERE (xStudent = @xStudent) AND (xpaye = @xpaye) AND (typ =5)", ai);
					val.Parameters.AddWithValue("@xStudent", (object)aj);
					val.Parameters.AddWithValue("@xpaye", (object)text);
					((DbCommand)(object)val).ExecuteNonQuery();
					num = 7;
					continue;
				case 16:
					if (!flag)
					{
						num = 27;
						continue;
					}
					s.GetRow(num6).BeginEdit();
					s.GetRow(num6).Cells["acp"].Value = "1";
					s.GetRow(num6).EndEdit();
					val = new SqlCommand("sp_tMarkAgo_insertUpdate", ai);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@xStudent", (object)aj);
					val.Parameters.AddWithValue("@xpaye", (object)text);
					val.Parameters.AddWithValue("@xbook", (object)s.GetRow(num6).Cells["xbook"].Text.ToString());
					flag = text3 != null;
					num = 0;
					continue;
				case 7:
				case 21:
					((DbConnection)(object)ai).Close();
					flag = this.m_i.Row >= this.m_i.RowCount - 1;
					num = 36;
					continue;
				case 36:
					if (flag)
					{
						MessageBox.Show("اطلاعات ذخیره شد");
						((Control)this.m_k).Visible = false;
						d();
						num = 4;
					}
					else
					{
						num = 17;
					}
					continue;
				case 0:
					if (flag)
					{
						val.Parameters.AddWithValue("@Mark", (object)text3);
						num = 26;
					}
					else
					{
						num = 32;
					}
					continue;
				case 5:
				case 26:
				{
					int num10 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num10 >= 1;
					num = 24;
					continue;
				}
				case 24:
					if (flag)
					{
						al = "0";
						num5++;
						num = 29;
					}
					else
					{
						num = 6;
					}
					continue;
				case 45:
					if (!flag)
					{
						num = 35;
						continue;
					}
					val = new SqlCommand("if not exists(select id from tMarkAgo where xStudent=@xStudent and xPaye=@xPaye and  typ=5)\r\n\t                    INSERT INTO tMarkAgo\r\n\t                                          (xStudent, xPaye,typ, xbook, Mark,gClass)\r\n\t                    VALUES      (@xStudent, @xPaye,5, -5, @Mark , @gClass)\r\n                    else \r\n\t                    UPDATE    tMarkAgo\r\n\t                    SET  Mark =@Mark ,gClass=@gClass\r\n\t                    where xStudent=@xStudent and xPaye=@xPaye and  typ=5", ai);
					text2 = "0";
					num = 2;
					continue;
				case 25:
				{
					val = null;
					SqlConnection val2 = new SqlConnection(asdab.e());
					ak = false;
					num2 = 0;
					num = 18;
					continue;
				}
				case 2:
					num = ((((Control)ad).Text != "0") ? 15 : 41);
					continue;
				case 30:
				case 33:
					flag = num6 < s.RowCount;
					num = 42;
					continue;
				case 42:
					if (flag)
					{
						if (true)
						{
						}
						text3 = "";
						num = 38;
					}
					else
					{
						num = 34;
					}
					continue;
				case 12:
				case 40:
					num = 14;
					continue;
				case 34:
					((Control)s).Refresh();
					a();
					num = 20;
					continue;
				case 20:
					num = ((((Control)af).Text == "0") ? 1 : 39);
					continue;
				case 14:
					num = 37;
					continue;
				case 37:
					return;
				case 18:
					try
					{
						num2 = int.Parse(((Control)v).Text);
					}
					catch
					{
					}
					num3 = int.Parse(((Control)u).Text);
					text3 = "";
					num4 = 0f;
					num5 = 0;
					((DbConnection)(object)ai).Open();
					num6 = 0;
					num = 33;
					continue;
				case 8:
				case 22:
					num6++;
					num = 30;
					continue;
				case 28:
					val.Parameters.AddWithValue("@xStudent", (object)aj);
					val.Parameters.AddWithValue("@xpaye", (object)text);
					val.Parameters.AddWithValue("@Mark", (object)((Control)af).Text);
					val.Parameters.AddWithValue("@gClass", (object)text2);
					((DbCommand)(object)val).ExecuteNonQuery();
					num = 21;
					continue;
				case 11:
					{
						if (!flag)
						{
							num = 10;
							continue;
						}
						goto case 28;
					}
					IL_0702:
					flag = text3 != null;
					num = 16;
					continue;
					IL_08b7:
					flag = (byte)num8 != 0;
					num = 45;
					continue;
					IL_0ab1:
					flag = (byte)num9 != 0;
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = this.m_i.RowCount <= 0;
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
					b();
					aj = this.m_i.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					c();
					s.Row = 0;
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					((Control)s).Select();
					s.SelectCurrentCellText();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)A_1.KeyCode != 114;
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
					d();
					num = 0;
					continue;
				case 0:
					((Control)this.m_g).Focus();
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 114;
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
					goto case 1;
				case 2:
					d();
					num = 1;
					continue;
				case 1:
					((Control)this.m_e).Focus();
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 113;
			if (true)
			{
			}
			int num = 10;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 10:
					num = ((!flag) ? 1 : 3);
					continue;
				case 2:
					if (!flag)
					{
						num = 19;
						continue;
					}
					flag = (int)A_1.KeyCode != 27;
					num = 5;
					continue;
				case 7:
					an = true;
					((Control)s).Refresh();
					g(this, null);
					num = 21;
					continue;
				case 23:
					num2 = 1;
					goto IL_026b;
				case 5:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 0;
				case 3:
					num = (((int)A_1.KeyCode == 114) ? 18 : 23);
					continue;
				case 20:
					i(this, null);
					num = 15;
					continue;
				case 0:
				case 9:
				case 15:
				case 21:
					num = 6;
					continue;
				case 6:
					return;
				case 16:
					flag = (int)A_1.KeyCode != 116;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 7;
						continue;
					}
					flag = (int)A_1.KeyCode != 34;
					num = 14;
					continue;
				case 18:
					num = 4;
					continue;
				case 4:
					num2 = (((Control)this.m_k).Visible ? 1 : 0);
					goto IL_026b;
				case 24:
					m(this, null);
					num = 0;
					continue;
				case 19:
					h(this, null);
					num = 9;
					continue;
				case 13:
					d();
					num = 17;
					continue;
				case 1:
					j(this, null);
					num = 22;
					continue;
				case 8:
					if (!flag)
					{
						num = 13;
						continue;
					}
					goto case 17;
				case 17:
				case 22:
					flag = !((Control)this.m_k).Visible;
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 16;
						continue;
					}
					return;
				case 14:
					{
						if (flag)
						{
							flag = (int)A_1.KeyCode != 33;
							num = 2;
						}
						else
						{
							num = 20;
						}
						continue;
					}
					IL_026b:
					flag = (byte)num2 != 0;
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		int num2 = default;
		int num3 = default;
		while (true)
		{
			bool flag = !(A_1.Column.Key == "SortOneEntry");
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
					num2 = 0;
					num = 5;
					continue;
				case 0:
					try
					{
						while (true)
						{
							IL_008d:
							int num4 = int.Parse(s.GetRow(s.Row).Cells["m1"].Text.ToString());
							num = 6;
							while (true)
							{
								int num5;
								switch (num)
								{
								case 6:
									num = ((num4 <= num3) ? 7 : 0);
									continue;
								case 0:
									num5 = 0;
									goto IL_0281;
								case 8:
									am = s.Row;
									s.GetRow(s.Row).BeginEdit();
									s.GetRow(s.Row).Cells["acp"].Value = "-1";
									s.GetRow(s.Row).Cells["m1"].Value = num4;
									s.GetRow(s.Row).EndEdit();
									num = 5;
									continue;
								case 7:
									num = 3;
									continue;
								case 3:
									num5 = ((num4 >= num2) ? 1 : 0);
									goto IL_0281;
								case 4:
									if (flag)
									{
										am = -1;
										s.GetRow(s.Row).BeginEdit();
										s.GetRow(s.Row).Cells["acp"].Value = "0";
										s.GetRow(s.Row).Cells["m1"].Value = num4;
										s.GetRow(s.Row).EndEdit();
										num = 1;
									}
									else
									{
										num = 8;
									}
									continue;
								case 1:
								case 5:
									num = 2;
									continue;
								case 2:
									goto end_IL_0060;
									IL_0281:
									flag = (byte)num5 != 0;
									num = 4;
									continue;
								}
								goto IL_008d;
								continue;
								end_IL_0060:
								break;
							}
							break;
						}
					}
					catch
					{
						am = -1;
						s.GetRow(s.Row).BeginEdit();
						s.GetRow(s.Row).Cells["acp"].Value = "0";
						s.GetRow(s.Row).Cells["m1"].Value = DBNull.Value;
						s.GetRow(s.Row).EndEdit();
					}
					a();
					num = 4;
					continue;
				case 4:
					return;
				case 1:
					asdcb.d(asdab.e(), CommandType.Text, "update tbook set SortOneEntry=" + s.GetRow(s.Row).Cells["SortOneEntry"].Value.ToString() + " where id=" + s.GetRow(s.Row).Cells["xbook"].Value.ToString());
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					try
					{
						num2 = int.Parse(((Control)v).Text);
					}
					catch
					{
					}
					num3 = int.Parse(((Control)u).Text);
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		int num4 = default;
		int num5 = default;
		int num7 = default;
		int num3 = default;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						while (true)
						{
							IL_0083:
							flag = !(s.GetRow(num4).Cells["m1"].Text != "");
							num2 = 6;
							while (true)
							{
								int num6;
								switch (num2)
								{
								case 6:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									goto case 1;
								case 7:
									s.GetRow(num4).Cells["m1"].FormatStyle.BackColor = Color.Yellow;
									s.GetRow(num4).BeginEdit();
									s.GetRow(num4).Cells["acp"].Value = "-1";
									s.GetRow(num4).EndEdit();
									ak = true;
									num2 = 10;
									continue;
								case 10:
									goto end_IL_004e;
								case 2:
									num2 = 9;
									continue;
								case 9:
									num6 = ((num5 >= num) ? 1 : 0);
									goto IL_0205;
								case 3:
									num5 = int.Parse(s.GetRow(num4).Cells["m1"].Text.ToString());
									num2 = 0;
									continue;
								case 0:
									num2 = ((num5 > num7) ? 8 : 2);
									continue;
								case 8:
									num6 = 0;
									goto IL_0205;
								case 5:
									if (flag)
									{
										string text = num5.ToString();
										num3 += num5;
										num2 = 1;
									}
									else
									{
										num2 = 7;
									}
									continue;
								case 1:
									num2 = 4;
									continue;
								case 4:
									{
										if (1 == 0)
										{
										}
										goto IL_003a;
									}
									IL_0205:
									flag = (byte)num6 != 0;
									num2 = 5;
									continue;
								}
								goto IL_0083;
								continue;
								end_IL_004e:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					goto case 1;
				case 1:
					num4++;
					num2 = 2;
					continue;
				case 0:
				{
					try
					{
						num = int.Parse(((Control)v).Text);
					}
					catch
					{
					}
					num7 = int.Parse(((Control)u).Text);
					num3 = 0;
					string text = "";
					num4 = 0;
					num2 = 5;
					continue;
				}
				case 2:
				case 5:
					flag = num4 < s.RowCount;
					num2 = 4;
					continue;
				case 4:
					num2 = (flag ? 6 : 3);
					continue;
				case 3:
					{
						((Control)af).Text = num3.ToString();
						return;
					}
					IL_003a:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					num = ((am < 0) ? 4 : 0);
					continue;
				case 0:
					num = 3;
					continue;
				case 3:
					num2 = ((s.Row == am) ? 1 : 0);
					goto IL_00e6;
				case 2:
					s.Row = am;
					MessageBox.Show("نمره وارد شده خارج از محدوده است");
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					((Control)s).Select();
					s.SelectCurrentCellText();
					num = 1;
					continue;
				case 1:
					return;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 4:
					{
						num2 = 1;
						goto IL_00e6;
					}
					IL_00e6:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		d();
	}

	private void b(object A_0, EventArgs A_1)
	{
		((EditBase)ad).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		((EditBase)ad).BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 13;
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
					return;
				case 3:
					((Control)s).Focus();
					s.CurrentColumn = s.GetRow(0).Cells["m1"].Column;
					((Control)s).Select();
					s.SelectCurrentCellText();
					num = 2;
					continue;
				case 4:
					if (true)
					{
					}
					flag = an;
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						an = false;
						num = 0;
					}
					else
					{
						num = 3;
					}
					continue;
				case 0:
				case 2:
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}
}
