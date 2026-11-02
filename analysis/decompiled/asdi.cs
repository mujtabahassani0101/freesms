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

public class asdi : Form
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

	private Label m_j;

	private EditBox k;

	private EditBox l;

	private UIButton m;

	private GridEXPrintDocument n;

	private PrintPreviewDialog o;

	private UIButton p;

	private UIButton q;

	private UIButton r;

	private UIButton s;

	private Label t;

	private IContainer u;

	private int v;

	public asdi()
	{
		b();
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
					goto case 5;
				case 1:
					num = 5;
					continue;
				case 4:
					u.Dispose();
					num = 1;
					continue;
				case 0:
					flag = u == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 5:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
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
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected Obj, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected Obj, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected Obj, but got Unknown
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected Obj, but got Unknown
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Expected Obj, but got Unknown
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Expected Obj, but got Unknown
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5a: Expected Obj, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected Obj, but got Unknown
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Expected Obj, but got Unknown
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Expected Obj, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected Obj, but got Unknown
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected Obj, but got Unknown
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Expected Obj, but got Unknown
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Expected Obj, but got Unknown
		if (true)
		{
		}
		u = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdi));
		GridEXLayout val = new GridEXLayout();
		this.m_a = new ImageList(u);
		this.m_b = new Panel();
		t = new Label();
		s = new UIButton();
		r = new UIButton();
		this.m_f = new Panel();
		this.m_j = new Label();
		this.m_i = new Label();
		k = new EditBox();
		l = new EditBox();
		this.m_g = new UIButton();
		m = new UIButton();
		q = new UIButton();
		p = new UIButton();
		this.m_c = new UIButton();
		this.m_d = new UIButton();
		this.m_e = new UIButton();
		this.m_h = new GridEX();
		n = new GridEXPrintDocument();
		o = new PrintPreviewDialog();
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
		((Control)this.m_b).Controls.Add((Control)(object)t);
		((Control)this.m_b).Controls.Add((Control)(object)s);
		((Control)this.m_b).Controls.Add((Control)(object)r);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_b).Controls.Add((Control)(object)q);
		((Control)this.m_b).Controls.Add((Control)(object)p);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_b).Location = new Point(6, 6);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(378, 456);
		((Control)this.m_b).TabIndex = 21;
		((Control)t).AutoSize = true;
		((Control)t).Font = new Font("B Nazanin", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).ForeColor = Color.DarkViolet;
		((Control)t).Location = new Point(113, 3);
		((Control)t).Name = "label1";
		((Control)t).Size = new Size(153, 40);
		((Control)t).TabIndex = 66;
		((Control)t).Text = "مدیریت کاربران ";
		s.ButtonStyle = (ButtonStyle)1;
		((Control)s).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		s.ImageIndex = 8;
		((Control)s).Location = new Point(4, 363);
		((Control)s).Name = "btnPermission";
		((Control)s).Size = new Size(110, 40);
		((Control)s).TabIndex = 65;
		((Control)s).Text = "مجوزها";
		s.VisualStyle = (VisualStyle)1;
		((Control)s).Click += c;
		r.BackColor = Color.FromArgb(214, 223, 247);
		r.ButtonStyle = (ButtonStyle)1;
		((Control)r).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		r.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		r.ImageIndex = 8;
		r.ImageSize = new Size(40, 40);
		((Control)r).Location = new Point(4, 409);
		((Control)r).Name = "uiButton2";
		((Control)r).Size = new Size(360, 40);
		((Control)r).TabIndex = 64;
		((Control)r).Text = "خروج";
		r.VisualStyle = (VisualStyle)1;
		((Control)r).Click += b;
		this.m_f.BorderStyle = (BorderStyle)1;
		((Control)this.m_f).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_f).Controls.Add((Control)(object)k);
		((Control)this.m_f).Controls.Add((Control)(object)l);
		((Control)this.m_f).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_f).Controls.Add((Control)(object)m);
		((Control)this.m_f).Location = new Point(36, 128);
		((Control)this.m_f).Name = "pUid";
		((Control)this.m_f).Size = new Size(282, 127);
		((Control)this.m_f).TabIndex = 26;
		((Control)this.m_f).Visible = false;
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((Control)this.m_j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_j).Location = new Point(168, 40);
		((Control)this.m_j).Name = "label4";
		((Control)this.m_j).RightToLeft = (RightToLeft)1;
		((Control)this.m_j).Size = new Size(104, 21);
		((Control)this.m_j).TabIndex = 40;
		((Control)this.m_j).Text = "کلمه عبور :";
		this.m_j.TextAlign = (ContentAlignment)64;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(168, 9);
		((Control)this.m_i).Name = "label3";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(109, 21);
		((Control)this.m_i).TabIndex = 39;
		((Control)this.m_i).Text = "نام کاربر :";
		this.m_i.TextAlign = (ContentAlignment)64;
		((Control)k).Anchor = (AnchorStyles)9;
		((EditBase)k).AutoScroll = false;
		((EditBase)k).AutoScrollMargin = new Size(0, 0);
		((EditBase)k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)k).AutoScrollPosition = new Point(0, 0);
		((Control)k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(24, 40);
		((Control)k).Name = "txtPwd";
		k.PasswordChar = '*';
		((Control)k).RightToLeft = (RightToLeft)1;
		((Control)k).Size = new Size(136, 21);
		((Control)k).TabIndex = 3;
		((EditBase)k).TextAlignment = (TextAlignment)1;
		((EditBase)k).VisualStyle = (VisualStyle)2;
		((Control)l).Anchor = (AnchorStyles)9;
		((EditBase)l).AutoScroll = false;
		((EditBase)l).AutoScrollMargin = new Size(0, 0);
		((EditBase)l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)l).AutoScrollPosition = new Point(0, 0);
		((Control)l).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(24, 9);
		((Control)l).Name = "txtUid";
		((Control)l).RightToLeft = (RightToLeft)1;
		((Control)l).Size = new Size(136, 21);
		((Control)l).TabIndex = 2;
		((EditBase)l).TextAlignment = (TextAlignment)1;
		((EditBase)l).VisualStyle = (VisualStyle)2;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		this.m_g.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_g).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_g.Image = (Image)componentResourceManager.GetObject("btnCansel.Image");
		this.m_g.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		((Control)this.m_g).Location = new Point(15, 76);
		((Control)this.m_g).Name = "btnCansel";
		((Control)this.m_g).Size = new Size(88, 32);
		((Control)this.m_g).TabIndex = 10;
		((Control)this.m_g).Text = "انصراف";
		this.m_g.VisualStyle = (VisualStyle)1;
		((Control)this.m_g).Click += g;
		((Control)m).Anchor = (AnchorStyles)9;
		m.ButtonStyle = (ButtonStyle)1;
		((Control)m).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		m.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		m.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		m.ImageIndex = 8;
		m.ImageSize = new Size(30, 30);
		((Control)m).Location = new Point(109, 76);
		((Control)m).Name = "btnAccept";
		((Control)m).Size = new Size(88, 32);
		((Control)m).TabIndex = 9;
		((Control)m).Text = "تائيد";
		m.VisualStyle = (VisualStyle)1;
		((Control)m).Click += i;
		q.ButtonStyle = (ButtonStyle)1;
		((Control)q).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		q.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		q.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		q.ImageIndex = 8;
		q.ImageSize = new Size(30, 30);
		((Control)q).Location = new Point(16, 512);
		((Control)q).Name = "uiButton1";
		((Control)q).Size = new Size(80, 40);
		((Control)q).TabIndex = 28;
		((Control)q).Text = "خروج";
		q.VisualStyle = (VisualStyle)1;
		((Control)q).Click += e;
		((Control)p).Anchor = (AnchorStyles)9;
		p.ButtonStyle = (ButtonStyle)1;
		((Control)p).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		p.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		p.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		p.ImageSize = new Size(30, 30);
		((Control)p).Location = new Point(-288, 512);
		((Control)p).Name = "btnPrint";
		((Control)p).Size = new Size(82, 40);
		((Control)p).TabIndex = 27;
		((Control)p).Text = "چاپ";
		p.VisualStyle = (VisualStyle)1;
		this.m_c.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_c).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageSize = new Size(30, 30);
		((Control)this.m_c).Location = new Point(120, 364);
		((Control)this.m_c).Name = "btnDelete";
		((Control)this.m_c).Size = new Size(77, 40);
		((Control)this.m_c).TabIndex = 2;
		((Control)this.m_c).Text = "حذف";
		this.m_c.VisualStyle = (VisualStyle)1;
		((Control)this.m_c).Click += f;
		this.m_d.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_d).Font = new Font("Tahoma", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_d.ImageIndex = 8;
		((Control)this.m_d).Location = new Point(292, 364);
		((Control)this.m_d).Name = "btnNew";
		((Control)this.m_d).Size = new Size(72, 40);
		((Control)this.m_d).TabIndex = 0;
		((Control)this.m_d).Text = "جديد";
		this.m_d.VisualStyle = (VisualStyle)1;
		((Control)this.m_d).Click += j;
		this.m_e.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_e).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		this.m_e.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_e.ImageIndex = 8;
		this.m_e.ImageSize = new Size(30, 30);
		((Control)this.m_e).Location = new Point(205, 364);
		((Control)this.m_e).Name = "btnEdit";
		((Control)this.m_e).Size = new Size(81, 40);
		((Control)this.m_e).TabIndex = 1;
		((Control)this.m_e).Text = "اصلاح";
		this.m_e.VisualStyle = (VisualStyle)1;
		((Control)this.m_e).Click += h;
		this.m_h.AllowEdit = (InheritableBoolean)2;
		this.m_h.CardCaptionPrefix = "Product:";
		this.m_h.ColumnAutoResize = true;
		((Control)this.m_h).Cursor = Cursors.Default;
		this.m_h.DataMember = null;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
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
		((Control)this.m_h).Location = new Point(3, 49);
		((Control)this.m_h).Name = "gUid";
		((Control)this.m_h).RightToLeft = (RightToLeft)1;
		this.m_h.RowHeaders = (InheritableBoolean)1;
		this.m_h.SelectedFormatStyle.Blend = 0.5f;
		this.m_h.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)this.m_h).Size = new Size(364, 309);
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
		this.m_h.SelectionChanged += a;
		n.GridEX = this.m_h;
		n.PageFooterLeft = "3";
		n.PageFooterRight = "2";
		n.PageHeaderCenter = "1";
		n.PageHeaderLeft = "4";
		n.PageHeaderRight = "5";
		o.AutoScrollMargin = new Size(0, 0);
		o.AutoScrollMinSize = new Size(0, 0);
		((Form)o).ClientSize = new Size(400, 300);
		o.Document = (PrintDocument)(object)n;
		o.Enabled = true;
		o.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		((Control)o).Name = "printPreviewDialog1";
		o.Visible = false;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = SystemColors.InactiveCaption;
		((Form)this).ClientSize = new Size(391, 472);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmUser";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "اطلاعات اساتيد";
		((Form)this).Load += d;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((Control)this.m_f).ResumeLayout(false);
		((ISupportInitialize)this.m_h).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select *  from tuser");
		this.m_h.DataSource = dataSource;
	}

	private void j(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		v = 1;
		((Control)this.m_f).Visible = true;
		((Control)l).Focus();
	}

	private void i(object A_0, EventArgs A_1)
	{
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)l).Text.Trim() == "");
			int num = 12;
			while (true)
			{
				switch (num)
				{
				case 12:
					if (!flag)
					{
						num = 9;
						continue;
					}
					flag = !(((Control)l).Text.Trim() == "");
					num = 8;
					continue;
				case 10:
					MessageBox.Show("کلمه عبور را وارد کنيد");
					((Control)k).Focus();
					num = 7;
					continue;
				case 7:
					return;
				case 8:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = !(((Control)k).Text.Trim() == "");
					num = 13;
					continue;
				case 9:
					MessageBox.Show("نام کاربر را وارد کنيد");
					((Control)l).Focus();
					num = 11;
					continue;
				case 11:
					return;
				case 6:
					if (flag)
					{
						string a_ = this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + "kbr63" + ((Control)k).Text;
						a_ = asdab.d(a_);
						asdcb.d(asdab.e(), CommandType.Text, "UPDATE tuser SET uid = N'" + ((Control)l).Text + "', pwd = N'" + a_ + "',pw=398 WHERE (id = " + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() + ")");
						((Control)this.m_f).Visible = false;
						((Control)l).Text = "";
						((Control)k).Text = "";
						num = 3;
					}
					else
					{
						num = 5;
					}
					continue;
				case 5:
				{
					if (true)
					{
					}
					string text = asdcb.a(asdab.e(), CommandType.Text, "select isnull(max(id)+1,1) from tuser").ToString();
					string a_ = text + "kbr63" + ((Control)k).Text;
					a_ = asdab.d(a_);
					asdcb.d(asdab.e(), CommandType.Text, "INSERT INTO tuser (id, uid, pwd,pw) VALUES  (" + text + ", N'" + ((Control)l).Text + "', N'" + a_ + "',398)");
					((Control)l).Text = "";
					((Control)k).Text = "";
					((Control)l).Focus();
					num = 2;
					continue;
				}
				case 2:
				case 3:
					a();
					num = 0;
					continue;
				case 0:
					return;
				case 13:
					if (flag)
					{
						((Control)l).Text = asdaj.b(((Control)l).Text.Trim());
						((Control)k).Text = asdaj.b(((Control)k).Text.Trim());
						flag = v != 1;
						num = 6;
					}
					else
					{
						num = 10;
					}
					continue;
				case 1:
					MessageBox.Show("نام کاربر را وارد کنيد");
					((Control)l).Focus();
					num = 4;
					continue;
				case 4:
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		int num2 = default;
		while (true)
		{
			bool flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					v = 2;
					((Control)l).Text = this.m_h.SelectedItems[0].GetRow().Cells["uid"].Value.ToString();
					((Control)k).Text = "";
					text = asdab.c(this.m_h.SelectedItems[0].GetRow().Cells["pwd"].Value.ToString());
					num2 = text.IndexOf("kbr63");
					flag = num2 <= 0;
					num = 7;
					continue;
				case 3:
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					goto IL_0135;
				case 0:
					flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == text.Substring(0, num2));
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 3;
				case 6:
					MessageBox.Show("امکان پذیر نیست admin اصلاح برای کاربر\n برای تغییر رمز از صفحه ورود به برنامه دکمه تغییر رمز استفاده کنید");
					num = 4;
					continue;
				case 4:
					return;
				case 8:
					return;
				case 7:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_0135;
				case 9:
					{
						num2 += 5;
						((Control)k).Text = text.Substring(num2, text.Length - num2);
						num = 3;
						continue;
					}
					IL_0135:
					((Control)this.m_f).Visible = true;
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = this.m_h.RowCount != 0;
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
					flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1");
					num = 6;
					continue;
				case 8:
					if (!flag)
					{
						num = 7;
						continue;
					}
					return;
				case 2:
					MessageBox.Show("امکان پذیر نیست admin حذف کاربر");
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					MessageBox.Show("کاربری انتخاب نشده است");
					num = 5;
					continue;
				case 5:
					return;
				case 7:
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tPermission where xuser=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					asdcb.d(asdab.e(), CommandType.Text, "delete FROM  tuser where id=" + this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
					a();
					num = 3;
					continue;
				case 3:
					return;
				case 6:
					if (flag)
					{
						if (true)
						{
						}
						flag = (int)MessageBox.Show("آيا از حذف کاربر مطمئن هستيد؟", "حذف کاربر", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
						num = 8;
					}
					else
					{
						num = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(asdaj.l != "1");
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
					a();
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (true)
			{
			}
			bool flag = !(this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString() == "1");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					if (!flag)
					{
						num = 0;
						continue;
					}
					asds asds2 = new asds();
					asds2.o = this.m_h.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
					((Form)asds2).ShowDialog();
					num = 2;
					continue;
				}
				case 2:
					return;
				case 0:
					MessageBox.Show("نیازی به تنظیم مجوز ندارد admin کاربر");
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Control)this.m_f).Visible = false;
	}
}
