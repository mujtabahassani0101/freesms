using System;
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

public class asdbu : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private UIGroupBox m_d;

	private Label m_e;

	private UIComboBox m_f;

	private Label m_g;

	private UIComboBox m_h;

	private Label m_i;

	private Label m_j;

	private EditBox m_k;

	private EditBox m_l;

	private OpenFileDialog m;

	private Label n;

	private UIButton o;

	private Button p;

	private UIButton q;

	private Label r;

	private Panel s;

	public string t;

	public string u;

	private bool v = false;

	private int w = 0;

	private int x = 0;

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					if (A_0)
					{
						if (true)
						{
						}
						num = 5;
					}
					else
					{
						num = 2;
					}
					continue;
				case 5:
					num = 1;
					continue;
				case 1:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 6:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 2:
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

	private void d()
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Obj, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected Obj, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected Obj, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected Obj, but got Unknown
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected Obj, but got Unknown
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected Obj, but got Unknown
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected Obj, but got Unknown
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected Obj, but got Unknown
		//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Expected Obj, but got Unknown
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbu));
		StringFormat val2 = new StringFormat();
		StringFormat val3 = new StringFormat();
		this.m_b = new GridEX();
		this.m_c = new Panel();
		r = new Label();
		p = new Button();
		q = new UIButton();
		n = new Label();
		this.m_d = new UIGroupBox();
		o = new UIButton();
		this.m_i = new Label();
		this.m_j = new Label();
		this.m_k = new EditBox();
		this.m_l = new EditBox();
		this.m_g = new Label();
		this.m_h = new UIComboBox();
		this.m_e = new Label();
		this.m_f = new UIComboBox();
		m = new OpenFileDialog();
		s = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((Control)s).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_b.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)this.m_b).Font = new Font("Tahoma", 9.75f, (FontStyle)1);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(8, 112);
		((Control)this.m_b).Name = "gridEX1";
		((ScrollableBase)this.m_b).RecordNavigator = true;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(770, 417);
		((Control)this.m_b).TabIndex = 0;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		((Control)this.m_b).Enter += e;
		this.m_b.SortKeysChanged += f;
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)r);
		((Control)this.m_c).Controls.Add((Control)(object)p);
		((Control)this.m_c).Controls.Add((Control)(object)q);
		((Control)this.m_c).Controls.Add((Control)(object)n);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(6, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(788, 587);
		((Control)this.m_c).TabIndex = 0;
		((Control)r).Anchor = (AnchorStyles)9;
		r.BorderStyle = (BorderStyle)1;
		((Control)r).Font = new Font("B Nazanin", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)r).ForeColor = Color.DarkGreen;
		((Control)r).Location = new Point(614, 50);
		((Control)r).Name = "txtDate";
		((Control)r).Size = new Size(139, 42);
		((Control)r).TabIndex = 34;
		r.TextAlign = (ContentAlignment)32;
		((Control)p).Anchor = (AnchorStyles)10;
		((Control)p).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((Control)p).Location = new Point(581, 535);
		((Control)p).Name = "btnSave";
		((Control)p).Size = new Size(197, 35);
		((Control)p).TabIndex = 1;
		((Control)p).Text = "(F5) ثبت  ";
		((ButtonBase)p).UseVisualStyleBackColor = true;
		((Control)p).Click += g;
		((Control)q).Anchor = (AnchorStyles)6;
		q.DialogResult = (DialogResult)2;
		q.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		q.ImageSize = new Size(40, 40);
		((Control)q).Location = new Point(11, 535);
		((Control)q).Name = "btnClose";
		((Control)q).Size = new Size(189, 35);
		((Control)q).TabIndex = 2;
		((Control)q).Text = "بستن";
		((Control)n).Anchor = (AnchorStyles)9;
		((Control)n).AutoSize = true;
		((Control)n).Font = new Font("B Nazanin", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(670, 8);
		((Control)n).Name = "label1";
		((Control)n).Size = new Size(47, 31);
		((Control)n).TabIndex = 30;
		((Control)n).Text = "تاریخ";
		((Control)this.m_d).Anchor = (AnchorStyles)13;
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_j);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_k);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_l);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_g);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_d).Location = new Point(11, -1);
		((Control)this.m_d).Name = "uiGroupBox1";
		((Control)this.m_d).Size = new Size(578, 107);
		((Control)this.m_d).TabIndex = 17;
		((Control)this.m_d).Text = "جستجو";
		((Control)o).Anchor = (AnchorStyles)9;
		o.Image = (Image)componentResourceManager.GetObject("btnNoSearch.Image");
		o.ImageSize = new Size(25, 25);
		((Control)o).Location = new Point(14, 22);
		((Control)o).Name = "btnNoSearch";
		((Control)o).Size = new Size(93, 71);
		((Control)o).TabIndex = 30;
		((Control)o).TabStop = false;
		((Control)o).Text = "حذف جستجو";
		((Control)o).Click += i;
		((Control)this.m_i).Anchor = (AnchorStyles)9;
		((Control)this.m_i).AutoSize = true;
		((Control)this.m_i).Location = new Point(483, 66);
		((Control)this.m_i).Name = "label5";
		((Control)this.m_i).Size = new Size(84, 24);
		((Control)this.m_i).TabIndex = 29;
		((Control)this.m_i).Text = "نام خانوادگی";
		((Control)this.m_j).Anchor = (AnchorStyles)9;
		((Control)this.m_j).AutoSize = true;
		((Control)this.m_j).Location = new Point(279, 66);
		((Control)this.m_j).Name = "label4";
		((Control)this.m_j).Size = new Size(26, 24);
		((Control)this.m_j).TabIndex = 28;
		((Control)this.m_j).Text = "نام";
		((Control)this.m_k).Anchor = (AnchorStyles)9;
		((EditBase)this.m_k).AutoScroll = false;
		((EditBase)this.m_k).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_k).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_k).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_k).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_k).Location = new Point(333, 66);
		((Control)this.m_k).Name = "txtLName";
		((Control)this.m_k).RightToLeft = (RightToLeft)1;
		((Control)this.m_k).Size = new Size(144, 27);
		((Control)this.m_k).TabIndex = 3;
		((EditBase)this.m_k).TextAlignment = (TextAlignment)1;
		((Control)this.m_k).Leave += d;
		((Control)this.m_k).KeyUp += a;
		((Control)this.m_k).Enter += c;
		((Control)this.m_l).Anchor = (AnchorStyles)9;
		((EditBase)this.m_l).AutoScroll = false;
		((EditBase)this.m_l).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_l).AutoScrollPosition = new Point(0, 0);
		((EditBase)this.m_l).ButtonFont = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_l).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)this.m_l).Location = new Point(132, 66);
		((Control)this.m_l).Name = "txtFName";
		((Control)this.m_l).RightToLeft = (RightToLeft)1;
		((Control)this.m_l).Size = new Size(141, 27);
		((Control)this.m_l).TabIndex = 2;
		((EditBase)this.m_l).TextAlignment = (TextAlignment)1;
		((Control)this.m_l).Leave += a;
		((Control)this.m_l).KeyUp += c;
		((Control)this.m_l).Enter += b;
		((Control)this.m_g).Anchor = (AnchorStyles)9;
		((Control)this.m_g).AutoSize = true;
		((Control)this.m_g).Location = new Point(279, 28);
		((Control)this.m_g).Name = "label19";
		((Control)this.m_g).Size = new Size(42, 24);
		((Control)this.m_g).TabIndex = 25;
		((Control)this.m_g).Text = "صنف";
		((Control)this.m_h).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_h).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_h).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_h).Location = new Point(132, 25);
		((Control)this.m_h).Name = "dropCls";
		((Control)this.m_h).Size = new Size(141, 31);
		val2.Alignment = (StringAlignment)0;
		val2.FormatFlags = (StringFormatFlags)20485;
		val2.HotkeyPrefix = (HotkeyPrefix)0;
		val2.LineAlignment = (StringAlignment)1;
		val2.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_h).StringFormat = val2;
		((Control)this.m_h).TabIndex = 1;
		this.m_h.SelectedIndexChanged += h;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((Control)this.m_e).AutoSize = true;
		((Control)this.m_e).Location = new Point(483, 29);
		((Control)this.m_e).Name = "label20";
		((Control)this.m_e).Size = new Size(33, 24);
		((Control)this.m_e).TabIndex = 15;
		((Control)this.m_e).Text = "پایه";
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_f).ComboStyle = (ComboStyle)1;
		((UIComboBase)this.m_f).DropListFont = new Font("B Nazanin", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)this.m_f).Location = new Point(333, 25);
		((Control)this.m_f).Name = "dropPaye";
		((Control)this.m_f).Size = new Size(144, 31);
		val3.Alignment = (StringAlignment)0;
		val3.FormatFlags = (StringFormatFlags)20485;
		val3.HotkeyPrefix = (HotkeyPrefix)0;
		val3.LineAlignment = (StringAlignment)1;
		val3.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_f).StringFormat = val3;
		((Control)this.m_f).TabIndex = 0;
		this.m_f.SelectedIndexChanged += j;
		((FileDialog)m).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		((FileDialog)m).Title = "انتخاب عکس شاگرد";
		((Control)s).BackColor = SystemColors.ActiveCaptionText;
		((Control)s).Controls.Add((Control)(object)this.m_c);
		((Control)s).Dock = (DockStyle)5;
		((Control)s).Location = new Point(0, 0);
		((Control)s).Name = "panel2";
		((Control)s).Size = new Size(800, 600);
		((Control)s).TabIndex = 35;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 600);
		((Control)this).Controls.Add((Control)(object)s);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmDisciplinaryAddAbsent";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست شاگردان";
		((Form)this).Load += l;
		((Control)this).KeyUp += b;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)s).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdbu()
	{
		d();
	}

	private void l(object A_0, EventArgs A_1)
	{
		((Control)r).Text = t;
		b();
		c();
		a();
		((Control)this.m_k).Focus();
		((EditBase)this.m_k).SelectAll();
		if (1 == 0)
		{
		}
	}

	private void c()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'' as  name union select id,name from tPaye order by id");
		this.m_f.DataSource = dataSource;
		this.m_f.DisplayMember = "Name";
		this.m_f.ValueMember = "id";
		this.m_f.SelectedIndex = 0;
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'' as  name union select id,name from tClass");
		this.m_h.DataSource = dataSource;
		this.m_h.DisplayMember = "Name";
		this.m_h.ValueMember = "id";
		this.m_h.SelectedIndex = 0;
	}

	private void a()
	{
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		while (true)
		{
			x = w;
			string text = "";
			bool flag = this.m_h.SelectedIndex <= 0;
			int num = 19;
			while (true)
			{
				switch (num)
				{
				case 19:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 28;
				case 22:
					text += " and ";
					num = 25;
					continue;
				case 9:
					text = text + " tstudent.FName like '%" + asdaj.b(((Control)this.m_l).Text) + "%'";
					num = 16;
					continue;
				case 28:
					flag = this.m_f.SelectedIndex <= 0;
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 24;
				case 7:
					flag = !(text != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 15;
				case 13:
					text = text + " tstudent.xClass=" + this.m_h.SelectedValue.ToString();
					num = 28;
					continue;
				case 2:
					if (true)
					{
					}
					flag = !(text != "");
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 25;
				case 15:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  0 as acp,   tmpStd.id, tmpStd.code, tmpStd.FName, tmpStd.LName, tmpStd.PName, tmpStd.Class, tmpStd.Paye\r\n    , tmpdis.comment, tmpdis.comment,cast(isnull(tmpdis.dis1,0) as bit) as dis1,cast(isnull(tmpdis.dis2,0)  as bit) as dis2,cast(isnull(tmpdis.dis3,0)  as bit) as dis3,tmpdis.xDisciplinaryCases\r\n    from\r\n    (SELECT     tStudent.id, tStudent.code, tStudent.FName, tStudent.LName, tStudent.PName,\r\n                    tClass.name AS Class, tPaye.Name AS Paye\r\n                        FROM         tStudent INNER JOIN\r\n                      tPaye ON tStudent.xPaye = tPaye.id INNER JOIN\r\n                      tClass ON tStudent.xClass = tClass.id " + text + ")tmpStd left outer join\r\n     (SELECT     xStudent, comment, xDisciplinaryCases,\r\n\t    case xDisciplinaryCases when 1 then 1 else 0  end as  dis1 ,\r\n    \tcase xDisciplinaryCases when 2 then 1 else 0  end as  dis2 ,\r\n    \tcase xDisciplinaryCases when 3 then 1 else 0  end as  dis3\r\n    \tFROM         tDisciplinaryStudent\r\n    \tWHERE     (xDisciplinaryCases IN (1, 2, 3)) AND (DateDis = N'" + ((Control)r).Text + "'))tmpdis on tmpStd.id=tmpdis.xStudent");
					this.m_b.DataSource = dataSource;
					GridEXFormatCondition val = new GridEXFormatCondition(this.m_b.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
					val.FormatStyle.ForeColor = SystemColors.WindowText;
					val.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					this.m_b.RootTable.FormatConditions.Add(val);
					GridEXFormatCondition val2 = new GridEXFormatCondition(this.m_b.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
					val2.FormatStyle.ForeColor = SystemColors.WindowText;
					val2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					this.m_b.RootTable.FormatConditions.Add(val2);
					flag = this.m_b.RowCount <= 0;
					num = 3;
					continue;
				}
				case 3:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 14:
					text += " and ";
					num = 9;
					continue;
				case 1:
					flag = !(text != "");
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 18;
				case 10:
					text = " where " + text;
					num = 15;
					continue;
				case 11:
					this.m_b.Row = 0;
					num = 0;
					continue;
				case 0:
					return;
				case 18:
					text = text + " tstudent.xPaye=" + this.m_f.SelectedValue.ToString();
					num = 24;
					continue;
				case 6:
					flag = !(text != "");
					num = 29;
					continue;
				case 29:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 13;
				case 17:
					text += " and ";
					num = 18;
					continue;
				case 5:
					text += " and ";
					num = 13;
					continue;
				case 24:
					flag = !(((Control)this.m_l).Text.Trim() != "");
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 16;
				case 25:
					text = text + " tstudent.LName like '%" + asdaj.b(((Control)this.m_k).Text) + "%'";
					num = 7;
					continue;
				case 16:
					flag = !(((Control)this.m_k).Text.Trim() != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 7;
				case 4:
					flag = !(text != "");
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void j(object A_0, EventArgs A_1)
	{
		a();
	}

	private void c(object A_0, KeyEventArgs A_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			string text = ((object)A_1.KeyCode).ToString();
			int num = 7;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					if ((int)A_1.KeyCode != 116)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 2;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					return;
				case 5:
					return;
				case 2:
					num2 = 0;
					goto IL_00ba;
				case 1:
					num = 0;
					continue;
				case 0:
					num2 = ((!(text == "Return")) ? 1 : 0);
					goto IL_00ba;
				case 4:
					{
						if (flag)
						{
							a();
							num = 5;
						}
						else
						{
							num = 6;
						}
						continue;
					}
					IL_00ba:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
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
		this.m_f.SelectedIndex = 0;
		this.m_h.SelectedIndex = 0;
		((Control)this.m_k).Text = "";
		((Control)this.m_l).Text = "";
		a();
	}

	private void h(object A_0, EventArgs A_1)
	{
		a();
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		bool flag4 = default;
		string text2 = default;
		while (true)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			string text = "";
			int num = 0;
			int num2 = 0;
			SqlCommand val = null;
			SqlConnection val2 = new SqlConnection(asdab.e());
			int num3 = 0;
			((DbConnection)(object)val2).Open();
			int num4 = 0;
			int num5 = 55;
			while (true)
			{
				int num8;
				int num6;
				int num7;
				switch (num5)
				{
				case 0:
				case 26:
					num5 = 25;
					continue;
				case 34:
					num5 = 35;
					continue;
				case 35:
					num8 = ((!flag3) ? 1 : 0);
					goto IL_03ad;
				case 39:
					if (!flag4)
					{
						num5 = 18;
						continue;
					}
					goto case 13;
				case 53:
					num5 = 56;
					continue;
				case 56:
					num6 = ((!flag3) ? 1 : 0);
					goto IL_060f;
				case 47:
				case 55:
					flag4 = num4 < this.m_b.RowCount;
					num5 = 46;
					continue;
				case 46:
					if (!flag4)
					{
						num5 = 6;
						continue;
					}
					num3 = 0;
					flag = false;
					flag2 = false;
					flag3 = false;
					text = asdaj.b(this.m_b.GetRow(num4).Cells["comment"].Text.ToString());
					flag = bool.Parse(this.m_b.GetRow(num4).Cells["dis1"].Text.ToString());
					flag2 = bool.Parse(this.m_b.GetRow(num4).Cells["dis2"].Text.ToString());
					flag3 = bool.Parse(this.m_b.GetRow(num4).Cells["dis3"].Text.ToString());
					flag4 = !flag;
					num5 = 19;
					continue;
				case 54:
					num5 = 0;
					continue;
				case 6:
					text2 = "";
					flag4 = num <= 0;
					num5 = 31;
					continue;
				case 31:
					if (!flag4)
					{
						num5 = 37;
						continue;
					}
					goto case 41;
				case 37:
					text2 = "تعداد  " + num + "  مورد ثبت شد";
					num5 = 41;
					continue;
				case 16:
					if (!flag4)
					{
						if (true)
						{
						}
						num5 = 9;
					}
					else
					{
						flag4 = !flag3;
						num5 = 12;
					}
					continue;
				case 3:
					if (flag4)
					{
						flag4 = num3 != 0;
						num5 = 39;
					}
					else
					{
						num5 = 8;
					}
					continue;
				case 51:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 43;
					continue;
				case 7:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 10;
					continue;
				case 29:
					if (flag4)
					{
						num3 = 1;
						num5 = 23;
					}
					else
					{
						num5 = 50;
					}
					continue;
				case 13:
				case 23:
				case 38:
				{
					val = new SqlCommand("sp_tDisciplinaryStudent123_insertUpdate", val2);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@xStudent", (object)this.m_b.GetRow(num4).Cells["id"].Text.ToString());
					val.Parameters.AddWithValue("@DateDis", (object)((Control)r).Text);
					val.Parameters.AddWithValue("@xDisciplinaryCases", (object)num3);
					val.Parameters.AddWithValue("@dayOfWeek", (object)u);
					val.Parameters.AddWithValue("@comment", (object)text);
					int num9 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag4 = num9 >= 1;
					num5 = 17;
					continue;
				}
				case 17:
					if (!flag4)
					{
						num5 = 54;
						continue;
					}
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "1";
					this.m_b.GetRow(num4).Cells["xDisciplinaryCases"].Value = num3;
					this.m_b.GetRow(num4).EndEdit();
					num++;
					num5 = 26;
					continue;
				case 12:
					if (flag4)
					{
						flag4 = !(text.Trim() != "");
						num5 = 3;
					}
					else
					{
						num5 = 48;
					}
					continue;
				case 44:
					num5 = 42;
					continue;
				case 42:
					num7 = ((!flag2) ? 1 : 0);
					goto IL_0755;
				case 8:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 1;
					continue;
				case 33:
				{
					object obj = text2;
					text2 = string.Concat(new object[4] { obj, "\nتعداد ", num2, " مورد خطا اتفاق افتاد" });
					num5 = 4;
					continue;
				}
				case 48:
					num5 = 21;
					continue;
				case 21:
					num5 = (flag ? 36 : 44);
					continue;
				case 5:
					if (flag4)
					{
						num3 = 2;
						num5 = 38;
					}
					else
					{
						num5 = 51;
					}
					continue;
				case 20:
					val = new SqlCommand("delete from tDisciplinaryStudent where xStudent=@xStudent and DateDis=@DateDis and xDisciplinaryCases in(1,2,3)", val2);
					val.Parameters.AddWithValue("@xStudent", (object)this.m_b.GetRow(num4).Cells["id"].Text.ToString());
					val.Parameters.AddWithValue("@DateDis", (object)((Control)r).Text);
					((DbCommand)(object)val).CommandType = CommandType.Text;
					((DbCommand)(object)val).ExecuteNonQuery();
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "1";
					this.m_b.GetRow(num4).Cells["xDisciplinaryCases"].Value = DBNull.Value;
					this.m_b.GetRow(num4).EndEdit();
					num++;
					num5 = 32;
					continue;
				case 1:
				case 10:
				case 25:
				case 27:
				case 43:
				case 52:
					num4++;
					num5 = 47;
					continue;
				case 2:
					if (flag4)
					{
						num3 = 3;
						num5 = 13;
					}
					else
					{
						num5 = 7;
					}
					continue;
				case 50:
					this.m_b.GetRow(num4).BeginEdit();
					this.m_b.GetRow(num4).Cells["acp"].Value = "-1";
					this.m_b.GetRow(num4).EndEdit();
					num2++;
					num5 = 27;
					continue;
				case 14:
					num5 = 40;
					continue;
				case 40:
					num5 = (flag2 ? 11 : 34);
					continue;
				case 11:
					num8 = 0;
					goto IL_03ad;
				case 19:
					if (flag4)
					{
						flag4 = !flag2;
						num5 = 16;
					}
					else
					{
						num5 = 14;
					}
					continue;
				case 30:
					num6 = 0;
					goto IL_060f;
				case 18:
					flag4 = !(this.m_b.GetRow(num4).Cells["xDisciplinaryCases"].Value.ToString() != "");
					num5 = 28;
					continue;
				case 28:
					if (!flag4)
					{
						num5 = 20;
						continue;
					}
					goto case 32;
				case 41:
					flag4 = num2 <= 0;
					num5 = 15;
					continue;
				case 15:
					if (!flag4)
					{
						num5 = 33;
						continue;
					}
					goto case 4;
				case 4:
					MessageBox.Show(text2);
					flag4 = num2 != 0;
					num5 = 22;
					continue;
				case 22:
					if (!flag4)
					{
						num5 = 45;
						continue;
					}
					goto case 49;
				case 36:
					num7 = 0;
					goto IL_0755;
				case 32:
					num5 = 52;
					continue;
				case 45:
					((EditBase)this.m_k).SelectAll();
					((Control)this.m_k).Focus();
					num5 = 49;
					continue;
				case 9:
					num5 = 24;
					continue;
				case 24:
					num5 = ((!flag) ? 53 : 30);
					continue;
				case 49:
					{
						((DbConnection)(object)val2).Close();
						return;
					}
					IL_060f:
					flag4 = (byte)num6 != 0;
					num5 = 5;
					continue;
					IL_0755:
					flag4 = (byte)num7 != 0;
					num5 = 2;
					continue;
					IL_03ad:
					flag4 = (byte)num8 != 0;
					num5 = 29;
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
			bool flag = this.m_b.RowCount <= 0;
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
					this.m_b.Row = 0;
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

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		try
		{
			while (true)
			{
				bool flag = !v;
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
						goto case 3;
					case 1:
						((Control)this.m_k).Focus();
						v = true;
						num = 3;
						continue;
					case 3:
						num = 2;
						continue;
					case 2:
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

	private void b(object A_0, KeyEventArgs A_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		while (true)
		{
			bool flag = (int)A_1.KeyCode != 116;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					goto case 4;
				case 2:
					k(this, null);
					num = 0;
					continue;
				case 0:
					return;
				case 4:
					flag = (int)A_1.KeyCode != 27;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 1:
					((Control)this.m_b).Refresh();
					g(this, null);
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_k).BackColor = Color.White;
	}

	private void c(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_k).BackColor = Color.Yellow;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_l).BackColor = Color.Yellow;
	}

	private void a(object A_0, EventArgs A_1)
	{
		((EditBase)this.m_l).BackColor = Color.White;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		bool flag = default;
		while (true)
		{
			string text = ((object)A_1.KeyCode).ToString();
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if ((int)A_1.KeyCode != 116)
					{
						num = 3;
						continue;
					}
					goto IL_007f;
				case 3:
					if (true)
					{
					}
					num = 1;
					continue;
				case 0:
					num = 7;
					continue;
				case 7:
					return;
				case 9:
					num2 = 0;
					goto IL_00ed;
				case 1:
					if ((int)A_1.KeyCode != 112)
					{
						num = 4;
						continue;
					}
					goto IL_007f;
				case 8:
					return;
				case 4:
					num = 2;
					continue;
				case 2:
					num2 = ((!(text == "Return")) ? 1 : 0);
					goto IL_00ed;
				case 5:
					{
						if (flag)
						{
							a();
							num = 8;
						}
						else
						{
							num = 0;
						}
						continue;
					}
					IL_007f:
					num = 9;
					continue;
					IL_00ed:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}
}
