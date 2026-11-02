using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdl : Form
{
	private ImageList m_a;

	private Panel m_b;

	private UIButton m_c;

	private UIButton m_d;

	private UIButton m_e;

	private Panel m_f;

	private UIButton m_g;

	private GridEX m_h;

	private Label m_i;

	private EditBox m_j;

	private UIButton m_k;

	private GridEXPrintDocument m_l;

	private PrintPreviewDialog m;

	private UIButton n;

	private UIButton o;

	private EditBox p;

	private Label q;

	private Label r;

	private Label s;

	private MaskedEditBox t;

	private MaskedEditBox u;

	private Label v;

	private EditBox w;

	private IContainer x;

	private int y;

	private int z = 0;

	public asdl()
	{
		c();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 4;
				case 1:
					num = 4;
					continue;
				case 5:
					x.Dispose();
					num = 1;
					continue;
				case 0:
					flag = x == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 1;
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
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
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
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected Obj, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Expected Obj, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected Obj, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got Unknown
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected Obj, but got Unknown
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected Obj, but got Unknown
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected Obj, but got Unknown
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Expected Obj, but got Unknown
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Expected Obj, but got Unknown
		//IL_1088: Unknown result type (might be due to invalid IL or missing references)
		//IL_1092: Expected Obj, but got Unknown
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Expected Obj, but got Unknown
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected Obj, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_1250: Expected Obj, but got Unknown
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_126c: Expected Obj, but got Unknown
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected Obj, but got Unknown
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_1683: Expected Obj, but got Unknown
		if (true)
		{
		}
		x = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdl));
		GridEXLayout val = new GridEXLayout();
		this.m_a = new ImageList(x);
		this.m_b = new Panel();
		q = new Label();
		p = new EditBox();
		this.m_f = new Panel();
		w = new EditBox();
		v = new Label();
		t = new MaskedEditBox();
		u = new MaskedEditBox();
		s = new Label();
		r = new Label();
		this.m_i = new Label();
		this.m_j = new EditBox();
		this.m_g = new UIButton();
		this.m_k = new UIButton();
		o = new UIButton();
		n = new UIButton();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new UIButton();
		this.m_h = new GridEX();
		this.m_l = new GridEXPrintDocument();
		m = new PrintPreviewDialog();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_f).SuspendLayout();
		((ISupportInitialize)this.m_h).BeginInit();
		((Control)this).SuspendLayout();
		this.m_a.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("icons.ImageStream");
		this.m_a.TransparentColor = Color.Magenta;
		this.m_a.Images.SetKeyName(0, "");
		this.m_a.Images.SetKeyName(1, "");
		this.m_a.Images.SetKeyName(2, "");
		this.m_a.Images.SetKeyName(3, "");
		this.m_a.Images.SetKeyName(4, "");
		this.m_a.Images.SetKeyName(5, "");
		this.m_a.Images.SetKeyName(6, "");
		this.m_a.Images.SetKeyName(7, "");
		this.m_a.Images.SetKeyName(8, "");
		this.m_a.Images.SetKeyName(9, "");
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)q);
		((Control)this.m_b).Controls.Add((Control)(object)p);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Controls.Add((Control)(object)o);
		((Control)this.m_b).Controls.Add((Control)(object)n);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Location = new Point(8, 11);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(433, 560);
		((Control)this.m_b).TabIndex = 21;
		((Control)q).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)q).Location = new Point(344, 14);
		((Control)q).Name = "lfamily1";
		((Control)q).RightToLeft = (RightToLeft)1;
		((Control)q).Size = new Size(82, 21);
		((Control)q).TabIndex = 41;
		((Control)q).Text = "نام راننده :";
		q.TextAlign = (ContentAlignment)64;
		((EditBase)p).AutoScroll = false;
		((EditBase)p).AutoScrollMargin = new Size(0, 0);
		((EditBase)p).AutoScrollMinSize = new Size(0, 0);
		((EditBase)p).AutoScrollPosition = new Point(0, 0);
		((Control)p).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(171, 14);
		((Control)p).Name = "txtNamlSearch";
		((Control)p).RightToLeft = (RightToLeft)1;
		((Control)p).Size = new Size(167, 21);
		((Control)p).TabIndex = 2;
		((EditBase)p).TextAlignment = (TextAlignment)1;
		((EditBase)p).VisualStyle = (VisualStyle)2;
		((Control)p).TextChanged += c;
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)w);
		((Control)this.m_f).Controls.Add((Control)(object)v);
		((Control)this.m_f).Controls.Add((Control)(object)t);
		((Control)this.m_f).Controls.Add((Control)(object)u);
		((Control)this.m_f).Controls.Add((Control)(object)s);
		((Control)this.m_f).Controls.Add((Control)(object)r);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(21, 145);
		((Control)this.m_f).Name = "panel3";
		((Control)this.m_f).Size = new Size(393, 302);
		((Control)this.m_f).TabIndex = 26;
		((Control)this.m_f).Visible = false;
		((EditBase)w).AutoScroll = false;
		((EditBase)w).AutoScrollMargin = new Size(0, 0);
		((EditBase)w).AutoScrollMinSize = new Size(0, 0);
		((EditBase)w).AutoScrollPosition = new Point(0, 0);
		((Control)w).Location = new Point(11, 118);
		w.Multiline = true;
		((Control)w).Name = "txtComment";
		((Control)w).Size = new Size(305, 122);
		((Control)w).TabIndex = 4;
		((EditBase)w).TextAlignment = (TextAlignment)1;
		((Control)v).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)v).Location = new Point(322, 118);
		((Control)v).Name = "label1";
		((Control)v).RightToLeft = (RightToLeft)1;
		((Control)v).Size = new Size(57, 21);
		((Control)v).TabIndex = 45;
		((Control)v).Text = "توضیحات :";
		v.TextAlign = (ContentAlignment)64;
		((EditBase)t).AutoScroll = false;
		((EditBase)t).AutoScrollMargin = new Size(0, 0);
		((EditBase)t).AutoScrollMinSize = new Size(0, 0);
		((EditBase)t).AutoScrollPosition = new Point(0, 0);
		((EditBase)t).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(124, 77);
		((EditBase)t).MaxLength = 11;
		((Control)t).Name = "txtMobile2";
		t.Numeric = true;
		((Control)t).RightToLeft = (RightToLeft)1;
		((Control)t).Size = new Size(192, 21);
		((Control)t).TabIndex = 3;
		((Control)t).Tag = "";
		((EditBase)t).TextAlignment = (TextAlignment)1;
		((EditBase)u).AutoScroll = false;
		((EditBase)u).AutoScrollMargin = new Size(0, 0);
		((EditBase)u).AutoScrollMinSize = new Size(0, 0);
		((EditBase)u).AutoScrollPosition = new Point(0, 0);
		((EditBase)u).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(124, 45);
		((EditBase)u).MaxLength = 11;
		((Control)u).Name = "txtMobile1";
		u.Numeric = true;
		((Control)u).RightToLeft = (RightToLeft)1;
		((Control)u).Size = new Size(192, 21);
		((Control)u).TabIndex = 2;
		((Control)u).Tag = "";
		((EditBase)u).TextAlignment = (TextAlignment)1;
		((Control)s).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)s).Location = new Point(322, 77);
		((Control)s).Name = "label3";
		((Control)s).RightToLeft = (RightToLeft)1;
		((Control)s).Size = new Size(57, 21);
		((Control)s).TabIndex = 42;
		((Control)s).Text = "تلفن 2  :";
		s.TextAlign = (ContentAlignment)64;
		((Control)r).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)r).Location = new Point(322, 45);
		((Control)r).Name = "label2";
		((Control)r).RightToLeft = (RightToLeft)1;
		((Control)r).Size = new Size(57, 21);
		((Control)r).TabIndex = 41;
		((Control)r).Text = "تلفن 1  :";
		r.TextAlign = (ContentAlignment)64;
		((Control)this.m_i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(322, 13);
		((Control)this.m_i).Name = "lname2";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(57, 21);
		((Control)this.m_i).TabIndex = 39;
		((Control)this.m_i).Text = "نام راننده :";
		this.m_i.TextAlign = (ContentAlignment)64;
		((EditBase)this.m_j).AutoScroll = false;
		((EditBase)this.m_j).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_j).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(124, 13);
		((Control)this.m_j).Name = "txtNamF";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(192, 21);
		((Control)this.m_j).TabIndex = 1;
		((EditBase)this.m_j).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_j).VisualStyle = (VisualStyle)2;
		this.m_g.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCansel.Image");
		this.m_g.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		((Control)this.m_g).Location = new Point(26, 256);
		((Control)this.m_g).Name = "btnCansel";
		((Control)this.m_g).Size = new Size(88, 32);
		((Control)this.m_g).TabIndex = 6;
		((Control)this.m_g).Text = "انصراف";
		this.m_g.VisualStyle = (VisualStyle)1;
		((Control)this.m_g).Click += h;
		this.m_k.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_k.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		this.m_k.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_k.ImageIndex = 8;
		this.m_k.ImageSize = new Size(30, 30);
		((Control)this.m_k).Location = new Point(124, 256);
		((Control)this.m_k).Name = "btnAccept";
		((Control)this.m_k).Size = new Size(88, 32);
		((Control)this.m_k).TabIndex = 5;
		((Control)this.m_k).Text = "تائيد";
		this.m_k.VisualStyle = (VisualStyle)1;
		((Control)this.m_k).Click += j;
		o.ButtonStyle = (ButtonStyle)1;
		((Control)o).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		o.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		o.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		o.ImageIndex = 8;
		o.ImageSize = new Size(30, 30);
		((Control)o).Location = new Point(11, 512);
		((Control)o).Name = "uiButton1";
		((Control)o).Size = new Size(73, 40);
		((Control)o).TabIndex = 28;
		((Control)o).Text = "خروج";
		o.VisualStyle = (VisualStyle)1;
		((Control)o).Click += e;
		n.ButtonStyle = (ButtonStyle)1;
		((Control)n).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		n.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		n.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		n.ImageSize = new Size(30, 30);
		((Control)n).Location = new Point(92, 512);
		((Control)n).Name = "btnPrint";
		((Control)n).Size = new Size(73, 40);
		((Control)n).TabIndex = 27;
		((Control)n).Text = "چاپ";
		n.VisualStyle = (VisualStyle)1;
		((Control)n).Click += f;
		this.m_c.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_c).Enabled = false;
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageSize = new Size(30, 30);
		((Control)this.m_c).Location = new Point(188, 512);
		((Control)this.m_c).Name = "btnDelete";
		((Control)this.m_c).Size = new Size(73, 40);
		((Control)this.m_c).TabIndex = 2;
		((Control)this.m_c).Text = "حذف";
		this.m_c.VisualStyle = (VisualStyle)1;
		((Control)this.m_c).Click += g;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_d.ImageIndex = 8;
		((Control)this.m_d).Location = new Point(349, 512);
		((Control)this.m_d).Name = "btnNew";
		((Control)this.m_d).Size = new Size(73, 40);
		((Control)this.m_d).TabIndex = 0;
		((Control)this.m_d).Text = "جديد";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += k;
		this.m_e.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_e).Enabled = false;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_e.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(30, 30);
		((Control)this.m_e).Location = new Point(268, 512);
		((Control)this.m_e).Name = "btnEdit";
		((Control)this.m_e).Size = new Size(73, 40);
		((Control)this.m_e).TabIndex = 1;
		((Control)this.m_e).Text = "اصلاح";
		this.m_e.VisualStyle = (VisualStyle)1;
		((Control)this.m_e).Click += i;
		this.m_h.AllowEdit = (InheritableBoolean)2;
		this.m_h.CardCaptionPrefix = "Product:";
		((Control)this.m_h).Cursor = Cursors.Default;
		this.m_h.DataMember = null;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_h.DesignTimeLayout = val;
		this.m_h.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_h.ExternalImageList = this.m_a;
		((ScrollableBase)this.m_h).FlatBorderColor = SystemColors.ControlDark;
		this.m_h.FocusStyle = (FocusStyle)2;
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f);
		this.m_h.GridLineColor = SystemColors.ScrollBar;
		this.m_h.GroupByBoxInfoFormatStyle.BackColor = Color.Empty;
		this.m_h.GroupByBoxInfoFormatStyle.Key = "4545";
		this.m_h.GroupByBoxVisible = false;
		this.m_h.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		this.m_h.GroupTotalRowFormatStyle.TextAlignment = (TextAlignment)2;
		((Control)this.m_h).Location = new Point(8, 47);
		((Control)this.m_h).Name = "gteacher";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		this.m_h.RowHeaders = (InheritableBoolean)1;
		this.m_h.SelectedFormatStyle.Blend = 0.5f;
		this.m_h.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_h).Size = new Size(413, 456);
		((Control)this.m_h).TabIndex = 4;
		((Control)this.m_h).TabStop = false;
		((ScrollableBase)this.m_h).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)this.m_h).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)this.m_h).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		((Control)this.m_h).Click += b;
		this.m_h.SelectionChanged += a;
		this.m_l.GridEX = this.m_h;
		this.m_l.PageFooterLeft = "3";
		this.m_l.PageFooterRight = "2";
		this.m_l.PageHeaderCenter = "1";
		this.m_l.PageHeaderLeft = "4";
		this.m_l.PageHeaderRight = "5";
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		((Form)m).ClientSize = new Size(400, 300);
		m.Document = (PrintDocument)(object)this.m_l;
		m.Enabled = true;
		m.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)m).Name = "printPreviewDialog1";
		m.Visible = false;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = SystemColors.InactiveCaption;
		((Form)this).ClientSize = new Size(450, 583);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmDriver";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "اطلاعات معلمان";
		((Form)this).Load += l;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_f).ResumeLayout(false);
		((ISupportInitialize)this.m_h).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void l(object A_0, EventArgs A_1)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("1");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 4:
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
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_0129;
				case 6:
					return;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 5;
					continue;
				case 5:
					return;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0129;
				case 0:
					{
						num = 4;
						continue;
					}
					IL_0129:
					b();
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		int num = z;
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tDriver");
		this.m_h.DataSource = dataSource;
		try
		{
			((Control)this.m_h).Focus();
			this.m_h.Row = num - 1;
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		y = 1;
		((Control)this.m_f).Visible = true;
		a();
		((Control)this.m_j).Focus();
	}

	private void a()
	{
		if (true)
		{
		}
		((Control)w).Text = "";
		((Control)u).Text = "";
		((Control)t).Text = "";
		((Control)this.m_j).Text = "";
	}

	private void j(object A_0, EventArgs A_1)
	{
		while (true)
		{
			((Control)this.m_j).Text = asdaj.b(((Control)this.m_j).Text.Trim());
			bool flag = y != 1;
			if (true)
			{
			}
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
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tDriver SET name = N'" + ((Control)this.m_j).Text.Trim() + "',mobil = N'" + ((Control)u).Text.Trim() + "',mobil2 = N'" + ((Control)t).Text.Trim() + "',comment = N'" + ((Control)w).Text.Trim() + "' where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					((Control)this.m_f).Visible = false;
					num = 1;
					continue;
				case 2:
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tDriver ( name, mobil,mobil2,comment)VALUES( N'" + ((Control)this.m_j).Text + "',N'" + ((Control)u).Text + "', N'" + ((Control)t).Text + "', N'" + ((Control)w).Text + "')");
					a();
					((Control)this.m_j).Focus();
					num = 3;
					continue;
				case 1:
				case 3:
					d(this, null);
					return;
				}
				break;
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
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
					num = ((this.m_h.RowCount <= 0) ? 5 : 6);
					continue;
				case 6:
					num = 1;
					continue;
				case 1:
					num2 = (((int)this.m_h.SelectedItems[0].RowType != 0) ? 1 : 0);
					goto IL_017d;
				case 0:
				{
					DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tDriver where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					((Control)this.m_j).Text = dataTable.Rows[0]["name"].ToString();
					((Control)u).Text = dataTable.Rows[0]["mobil"].ToString();
					((Control)t).Text = dataTable.Rows[0]["mobil2"].ToString();
					((Control)w).Text = dataTable.Rows[0]["comment"].ToString();
					((Control)this.m_f).Visible = true;
					num = 2;
					continue;
				}
				case 2:
					return;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 5:
					{
						num2 = 1;
						goto IL_017d;
					}
					IL_017d:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Invalid comparison between Unknown and I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 2:
					num = ((this.m_h.RowCount < 1) ? 12 : 10);
					continue;
				case 5:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tDriver where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					b();
					num = 7;
					continue;
				case 7:
					if (1 == 0)
					{
					}
					goto IL_016a;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					MessageBox.Show("برای این راننده دانش آموز اختصاص یافته است .حذف امکان پذیر نیست");
					num = 9;
					continue;
				case 12:
					num2 = 0;
					goto IL_0221;
				case 11:
					return;
				case 10:
					num = 13;
					continue;
				case 13:
					num2 = (((int)this.m_h.SelectedItems[0].RowType == 0) ? 1 : 0);
					goto IL_0221;
				case 4:
					flag = (int)MessageBox.Show("آيا از حذف راننده مطمئن هستيد؟", "حذف راننده", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto IL_016a;
				case 9:
					return;
				case 1:
					MessageBox.Show("راننده ای انتخاب نشده است");
					num = 3;
					continue;
				case 3:
					return;
				case 6:
					{
						if (flag)
						{
							string text = asdcb.a(asdab.e(), CommandType.Text, "SELECT COUNT(id) FROM   tYear_Student WHERE xDriver = " + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString()).ToString();
							flag = !(text == "0");
							num = 0;
						}
						else
						{
							num = 1;
						}
						continue;
					}
					IL_016a:
					num = 11;
					continue;
					IL_0221:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		Rectangle bounds = ((Control)this).Bounds;
		((Form)m).SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
		m.UseAntiAlias = true;
		((Form)m).ShowDialog((IWin32Window)(object)this);
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = z;
			string text = "";
			bool flag = !(((Control)p).Text.Trim() != "");
			if (true)
			{
			}
			int num2 = 18;
			while (true)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 18:
					if (!flag)
					{
						num2 = 15;
						continue;
					}
					goto case 10;
				case 2:
					text = " where " + text;
					num2 = 12;
					continue;
				case 14:
					num2 = 17;
					continue;
				case 17:
					num3 = ((this.m_h.RecordCount != num) ? 1 : 0);
					goto IL_0152;
				case 12:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select * from tDriver" + text);
					this.m_h.DataSource = dataSource;
					num2 = 7;
					continue;
				}
				case 7:
					num2 = ((y != 2) ? 6 : 9);
					continue;
				case 13:
					if (!flag)
					{
						num2 = 21;
						continue;
					}
					goto case 4;
				case 16:
					text += " and ";
					num2 = 0;
					continue;
				case 15:
					flag = !(text != "");
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 0;
				case 21:
					((Control)this.m_h).Focus();
					this.m_h.Row = num - 1;
					num2 = 4;
					continue;
				case 10:
					flag = !(text != "");
					num2 = 5;
					continue;
				case 5:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					goto case 12;
				case 9:
					num2 = 3;
					continue;
				case 3:
					num4 = ((this.m_h.RecordCount <= num) ? 1 : 0);
					goto IL_02f7;
				case 22:
					num2 = ((y != 2) ? 20 : 14);
					continue;
				case 0:
					text = text + "name like N'%" + asdaj.b(((Control)p).Text.Trim()) + "%'";
					num2 = 10;
					continue;
				case 6:
					num4 = 1;
					goto IL_02f7;
				case 8:
					((Control)this.m_h).Focus();
					this.m_h.Row = num;
					num2 = 11;
					continue;
				case 19:
					num2 = ((!flag) ? 8 : 22);
					continue;
				case 20:
					num3 = 1;
					goto IL_0152;
				case 4:
				case 11:
					{
						y = 1;
						return;
					}
					IL_02f7:
					flag = (byte)num4 != 0;
					num2 = 19;
					continue;
					IL_0152:
					flag = (byte)num3 != 0;
					num2 = 13;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		d(this, null);
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		try
		{
			while (true)
			{
				if (true)
				{
				}
				bool flag = (int)this.m_h.SelectedItems[0].RowType == 5;
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
						((Control)this.m_c).Enabled = true;
						((Control)this.m_e).Enabled = true;
						num = 2;
						continue;
					case 2:
						num = 3;
						continue;
					case 3:
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

	private void a(object A_0, EventArgs A_1)
	{
		z = this.m_h.Row;
	}
}
