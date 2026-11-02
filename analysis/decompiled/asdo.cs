using System;
using System.Collections;
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
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void c()
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
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected Obj, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected Obj, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Expected Obj, but got Unknown
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected Obj, but got Unknown
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected Obj, but got Unknown
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected Obj, but got Unknown
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Expected Obj, but got Unknown
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Expected Obj, but got Unknown
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected Obj, but got Unknown
		//IL_0ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f01: Expected Obj, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Expected Obj, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Expected Obj, but got Unknown
		//IL_10eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f5: Expected Obj, but got Unknown
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Expected Obj, but got Unknown
		//IL_11ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f4: Expected Obj, but got Unknown
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_1310: Expected Obj, but got Unknown
		//IL_1390: Unknown result type (might be due to invalid IL or missing references)
		//IL_139a: Expected Obj, but got Unknown
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ca: Expected Obj, but got Unknown
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected Obj, but got Unknown
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected Obj, but got Unknown
		//IL_1694: Unknown result type (might be due to invalid IL or missing references)
		//IL_169e: Expected Obj, but got Unknown
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1787: Expected Obj, but got Unknown
		//IL_1799: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a3: Expected Obj, but got Unknown
		//IL_1882: Unknown result type (might be due to invalid IL or missing references)
		//IL_188c: Expected Obj, but got Unknown
		//IL_189e: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a8: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdo));
		StringFormat val2 = new StringFormat();
		GridEXLayout val3 = new GridEXLayout();
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
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)v).SuspendLayout();
		((Control)this.m_g).SuspendLayout();
		((ISupportInitialize)this.m_l).BeginInit();
		((Control)this).SuspendLayout();
		this.m_f.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		this.m_f.CardCaptionPrefix = "Product:";
		this.m_f.ColumnAutoResize = true;
		((Control)this.m_f).Cursor = Cursors.Default;
		this.m_f.DataMember = null;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout3.LayoutString");
		this.m_f.DesignTimeLayout = val;
		this.m_f.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)this.m_f).FlatBorderColor = SystemColors.ControlDark;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f);
		this.m_f.GridLineColor = SystemColors.ScrollBar;
		this.m_f.GroupByBoxVisible = false;
		this.m_f.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)this.m_f).Location = new Point(297, 8);
		((Control)this.m_f).Name = "gOst";
		((Control)this.m_f).RightToLeft = (RightToLeft)1;
		this.m_f.RowHeaders = (InheritableBoolean)1;
		this.m_f.SelectedFormatStyle.Blend = 0.5f;
		this.m_f.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_f).Size = new Size(231, 368);
		((Control)this.m_f).TabIndex = 15;
		((ScrollableBase)this.m_f).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_f).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_f).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_f).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_f).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_f).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_f).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_f).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		this.m_f.SelectionChanged += e;
		((Control)this.m_a).BackColor = Color.CornflowerBlue;
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(5, 4);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(563, 497);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)w);
		((Control)this.m_b).Controls.Add((Control)(object)v);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_m);
		((Control)this.m_b).Controls.Add((Control)(object)n);
		((Control)this.m_b).Controls.Add((Control)(object)o);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Location = new Point(5, 5);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(551, 484);
		((Control)this.m_b).TabIndex = 16;
		w.ButtonStyle = (ButtonStyle)1;
		((Control)w).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		w.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		w.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		w.ImageIndex = 8;
		w.ImageSize = new Size(50, 50);
		((Control)w).Location = new Point(26, 429);
		((Control)w).Name = "uiButton2";
		((Control)w).RightToLeft = (RightToLeft)1;
		((Control)w).Size = new Size(499, 45);
		((Control)w).TabIndex = 44;
		((Control)w).Text = "خروج";
		w.VisualStyle = (VisualStyle)1;
		((Control)w).Click += c;
		((Control)v).Anchor = (AnchorStyles)9;
		v.BorderStyle = (BorderStyle)1;
		((Control)v).Controls.Add((Control)(object)t);
		((Control)v).Controls.Add((Control)(object)s);
		((Control)v).Controls.Add((Control)(object)p);
		((Control)v).Controls.Add((Control)(object)q);
		((Control)v).Controls.Add((Control)(object)u);
		((Control)v).Controls.Add((Control)(object)r);
		((Control)v).Location = new Point(12, 168);
		((Control)v).Name = "PCty";
		((Control)v).Size = new Size(288, 120);
		((Control)v).TabIndex = 42;
		((Control)v).Visible = false;
		((Control)t).Anchor = (AnchorStyles)9;
		((UIComboBase)t).BorderStyle = (BorderStyle)2;
		((UIComboBase)t).ComboStyle = (ComboStyle)1;
		((Control)t).Font = new Font("Tahoma", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(8, 8);
		((Control)t).Name = "comboOst_Cty";
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(184, 24);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)t).StringFormat = val2;
		((Control)t).TabIndex = 30;
		((Control)s).Anchor = (AnchorStyles)9;
		((Control)s).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)s).Location = new Point(200, 8);
		((Control)s).Name = "label2";
		((Control)s).RightToLeft = (RightToLeft)1;
		((Control)s).Size = new Size(80, 21);
		((Control)s).TabIndex = 29;
		((Control)s).Text = "نام ولایت :";
		s.TextAlign = (ContentAlignment)64;
		((Control)p).Anchor = (AnchorStyles)9;
		p.ButtonStyle = (ButtonStyle)1;
		((Control)p).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		p.Image = (Image)componentResourceManager.GetObject("btnCancelCty.Image");
		p.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		p.ImageIndex = 8;
		((Control)p).Location = new Point(40, 80);
		((Control)p).Name = "btnCancelCty";
		((Control)p).RightToLeft = (RightToLeft)1;
		((Control)p).Size = new Size(64, 24);
		((Control)p).TabIndex = 28;
		((Control)p).Text = "انصراف";
		p.VisualStyle = (VisualStyle)1;
		((Control)p).Click += g;
		((Control)q).Anchor = (AnchorStyles)9;
		q.ButtonStyle = (ButtonStyle)1;
		((Control)q).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		q.Image = (Image)componentResourceManager.GetObject("btnAcpCty.Image");
		q.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		q.ImageIndex = 8;
		((Control)q).Location = new Point(120, 80);
		((Control)q).Name = "btnAcpCty";
		((Control)q).RightToLeft = (RightToLeft)1;
		((Control)q).Size = new Size(64, 24);
		((Control)q).TabIndex = 27;
		((Control)q).Text = "تائيد";
		q.VisualStyle = (VisualStyle)1;
		((Control)q).Click += d;
		((Control)u).Anchor = (AnchorStyles)9;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((Control)u).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(8, 48);
		((Control)u).Name = "txtCty";
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(184, 21);
		((Control)u).TabIndex = 23;
		((EditBase)u).TextAlignment = (TextAlignment)1;
		((EditBase)u).VisualStyle = (VisualStyle)2;
		((Control)u).KeyDown += a;
		((Control)r).Anchor = (AnchorStyles)9;
		((Control)r).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(200, 48);
		((Control)r).Name = "label1";
		((Control)r).RightToLeft = (RightToLeft)1;
		((Control)r).Size = new Size(80, 21);
		((Control)r).TabIndex = 22;
		((Control)r).Text = "نام ولسوالی:";
		r.TextAlign = (ContentAlignment)64;
		((Control)this.m_m).Anchor = (AnchorStyles)9;
		this.m_m.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_m).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_m.Image = (Image)componentResourceManager.GetObject("btnDeleteCty.Image");
		this.m_m.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_m.ImageIndex = 8;
		((Control)this.m_m).Location = new Point(29, 384);
		((Control)this.m_m).Name = "btnDeleteCty";
		((Control)this.m_m).RightToLeft = (RightToLeft)1;
		((Control)this.m_m).Size = new Size(64, 32);
		((Control)this.m_m).TabIndex = 37;
		((Control)this.m_m).Text = "حذف";
		this.m_m.VisualStyle = (VisualStyle)1;
		((Control)this.m_m).Click += a;
		((Control)n).Anchor = (AnchorStyles)9;
		n.ButtonStyle = (ButtonStyle)1;
		((Control)n).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		n.Image = (Image)componentResourceManager.GetObject("btnNewCty.Image");
		n.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		n.ImageIndex = 8;
		((Control)n).Location = new Point(208, 384);
		((Control)n).Name = "btnNewCty";
		((Control)n).RightToLeft = (RightToLeft)1;
		((Control)n).Size = new Size(68, 32);
		((Control)n).TabIndex = 35;
		((Control)n).Text = "جديد";
		n.VisualStyle = (VisualStyle)1;
		((Control)n).Click += h;
		((Control)o).Anchor = (AnchorStyles)9;
		o.ButtonStyle = (ButtonStyle)1;
		((Control)o).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		o.Image = (Image)componentResourceManager.GetObject("btnEditCty.Image");
		o.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		o.ImageIndex = 8;
		((Control)o).Location = new Point(111, 384);
		((Control)o).Name = "btnEditCty";
		((Control)o).RightToLeft = (RightToLeft)1;
		((Control)o).Size = new Size(74, 32);
		((Control)o).TabIndex = 36;
		((Control)o).Text = "اصلاح";
		o.VisualStyle = (VisualStyle)1;
		((Control)o).Click += f;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		this.m_g.BorderStyle = (BorderStyle)1;
		((Control)this.m_g).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_g).Location = new Point(272, 192);
		((Control)this.m_g).Name = "POst";
		((Control)this.m_g).Size = new Size(272, 80);
		((Control)this.m_g).TabIndex = 30;
		((Control)this.m_g).Visible = false;
		((Control)this.m_c).Anchor = (AnchorStyles)9;
		this.m_c.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnCancelOst.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageIndex = 8;
		((Control)this.m_c).Location = new Point(24, 48);
		((Control)this.m_c).Name = "btnCancelOst";
		((Control)this.m_c).RightToLeft = (RightToLeft)1;
		((Control)this.m_c).Size = new Size(64, 24);
		((Control)this.m_c).TabIndex = 28;
		((Control)this.m_c).Text = "انصراف";
		this.m_c.VisualStyle = (VisualStyle)1;
		((Control)this.m_c).Click += k;
		((Control)this.m_d).Anchor = (AnchorStyles)9;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnAcpOst.Image");
		this.m_d.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_d.ImageIndex = 8;
		((Control)this.m_d).Location = new Point(104, 48);
		((Control)this.m_d).Name = "btnAcpOst";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		((Control)this.m_d).Size = new Size(64, 24);
		((Control)this.m_d).TabIndex = 27;
		((Control)this.m_d).Text = "تائيد";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += j;
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((EditBase)this.m_k).AutoScroll = false;
		((EditBase)this.m_k).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_k).Location = new Point(8, 16);
		((Control)this.m_k).Name = "txtOst";
		((Control)this.m_k).RightToLeft = (RightToLeft)1;
		((Control)this.m_k).Size = new Size(165, 21);
		((Control)this.m_k).TabIndex = 23;
		((EditBase)this.m_k).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_k).VisualStyle = (VisualStyle)2;
		((Control)this.m_k).KeyDown += b;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(176, 16);
		((Control)this.m_e).Name = "L_Type";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(80, 21);
		((Control)this.m_e).TabIndex = 22;
		((Control)this.m_e).Text = "نام ولایت :";
		this.m_e.TextAlign = (ContentAlignment)64;
		this.m_l.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_l).Anchor = (AnchorStyles)9;
		this.m_l.CardCaptionPrefix = "Product:";
		this.m_l.ColumnAutoResize = true;
		((Control)this.m_l).Cursor = Cursors.Default;
		this.m_l.DataMember = null;
		val3.LayoutString = componentResourceManager.GetString("gridEXLayout4.LayoutString");
		this.m_l.DesignTimeLayout = val3;
		this.m_l.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)this.m_l).FlatBorderColor = SystemColors.ControlDark;
		((Control)this.m_l).Font = new Font("Tahoma", 8.25f);
		this.m_l.GridLineColor = SystemColors.ScrollBar;
		this.m_l.GroupByBoxVisible = false;
		this.m_l.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)this.m_l).Location = new Point(29, 8);
		((Control)this.m_l).Name = "gCty";
		((Control)this.m_l).RightToLeft = (RightToLeft)1;
		this.m_l.RowHeaders = (InheritableBoolean)1;
		this.m_l.SelectedFormatStyle.Blend = 0.5f;
		this.m_l.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_l).Size = new Size(246, 368);
		((Control)this.m_l).TabIndex = 34;
		((ScrollableBase)this.m_l).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_l).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_l).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_l).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_l).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_l).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_l).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_l).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		this.m_h.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_h.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_h.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_h.ImageIndex = 8;
		((Control)this.m_h).Location = new Point(297, 384);
		((Control)this.m_h).Name = "btnDelete";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		((Control)this.m_h).Size = new Size(64, 32);
		((Control)this.m_h).TabIndex = 33;
		((Control)this.m_h).Text = "حذف";
		this.m_h.VisualStyle = (VisualStyle)1;
		((Control)this.m_h).Click += b;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		this.m_i.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_i).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_i.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		this.m_i.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_i.ImageIndex = 8;
		((Control)this.m_i).Location = new Point(464, 384);
		((Control)this.m_i).Name = "btnNew";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(64, 32);
		((Control)this.m_i).TabIndex = 31;
		((Control)this.m_i).Text = "جديد";
		this.m_i.VisualStyle = (VisualStyle)1;
		((Control)this.m_i).Click += l;
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		this.m_j.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_j.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_j.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_j.ImageIndex = 8;
		((Control)this.m_j).Location = new Point(380, 384);
		((Control)this.m_j).Name = "btnEdit";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(64, 32);
		((Control)this.m_j).TabIndex = 32;
		((Control)this.m_j).Text = "اصلاح";
		this.m_j.VisualStyle = (VisualStyle)1;
		((Control)this.m_j).Click += i;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(573, 506);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmOst";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = " ولایت-ولسوالی";
		((Form)this).Load += m;
		((ISupportInitialize)this.m_f).EndInit();
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)v).ResumeLayout(false);
		((Control)this.m_g).ResumeLayout(false);
		((ISupportInitialize)this.m_l).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tostan");
		this.m_f.DataSource = dataSource;
		t.DataSource = null;
		((CollectionBase)(object)t.Items).Clear();
		((Control)t).Text = "";
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
						((Control)this.m_b).BackColor = Color.FromArgb(red, green, blue);
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
		((Control)this.m_k).Text = "";
		((Control)this.m_g).Visible = true;
		((Control)this.m_k).Focus();
	}

	private void k(object A_0, EventArgs A_1)
	{
		((Control)this.m_g).Visible = false;
	}

	private void j(object A_0, EventArgs A_1)
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((Control)this.m_k).Text = asdaj.b(((Control)this.m_k).Text);
			bool flag = !(((Control)this.m_k).Text == "");
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
					((Control)this.m_k).Focus();
					num = 2;
					continue;
				case 4:
				{
					string text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,10) from tOstan").ToString();
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tOstan (id,Name)VALUES(" + text + ", N'" + ((Control)this.m_k).Text.Trim() + "')");
					((Control)this.m_k).Text = "";
					((Control)this.m_k).Focus();
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
						asdcb.d(asdab.e(), CommandType.Text, "update tOstan set Name=N'" + ((Control)this.m_k).Text.Trim() + "' where id=" + this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						((Control)this.m_g).Visible = false;
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
					((Control)this.m_k).Text = this.m_f.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
					((Control)this.m_g).Visible = true;
					((Control)v).Visible = false;
					((Control)this.m_k).Focus();
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
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)u).Text = "";
					t.SelectedValue = this.m_f.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					((Control)v).Visible = true;
					((Control)this.m_g).Visible = false;
					((Control)u).Focus();
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
		((Control)v).Visible = false;
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
					((Control)u).Text = this.m_l.SelectedItems[0].GetRow().Cells["Name"].Value.ToString();
					((Control)v).Visible = true;
					((Control)this.m_g).Visible = false;
					((Control)u).Focus();
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		if (true)
		{
		}
		try
		{
			while (true)
			{
				bool flag = (int)this.m_f.SelectedItems[0].RowType == 5;
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((Control)u).Text = asdaj.b(((Control)u).Text);
			bool flag = !(((Control)u).Text == "");
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
					((Control)u).Focus();
					num = 2;
					continue;
				case 4:
				{
					string text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,100) from tCity").ToString();
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tCity (id,Name,xOstan)VALUES(" + text + ", N'" + ((Control)u).Text.Trim() + "'," + t.SelectedValue.ToString() + ")");
					((Control)u).Text = "";
					((Control)u).Focus();
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
					asdcb.d(asdab.e(), CommandType.Text, "update tCity set Name=N'" + ((Control)u).Text.Trim() + "',xOstan=" + t.SelectedValue.ToString() + " where id=" + this.m_l.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					((Control)v).Visible = false;
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
		((Form)this).Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 13;
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		if (true)
		{
		}
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 13;
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
