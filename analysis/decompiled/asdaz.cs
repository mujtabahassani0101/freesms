using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

public class asdaz : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private IContainer m_b = null;

	private Panel m_c;

	private Panel d;

	private Panel e;

	private Label f;

	private UIButton g;

	private GridEX h;

	private UIComboBox i;

	private Label j;

	private Label k;

	private Label l;

	public asdaz()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 0:
					try
					{
						i.SelectedIndex = 0;
						b();
						h.CurrentColumn = h.GetRow(0).Cells["sort"].Column;
						((Control)h).Select();
						h.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 1;
					continue;
				case 3:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 8;
				case 7:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 5;
					continue;
				case 5:
					return;
				case 8:
					((Control)k).Text = asdaj.a;
					c();
					num = 0;
					continue;
				case 1:
					return;
				case 4:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)e).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 8;
					continue;
				case 6:
					num = 4;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + ((Control)k).Text + " and xPaye in(" + asdaj.n + ") order by xpaye,sortRpt");
		i.DataSource = dataSource;
		i.DisplayMember = "Name";
		i.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tYear_Student.id, tYear_Student.sort, tYear_Student.shaghe,  tYear_Student.hazer,\r\n                          tStudent.FName, tStudent.LName, tStudent.PName, tStudent.Code, tStudent.NumberAsas\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE     (tYear_Student.xYear = " + ((Control)k).Text + ") AND (tYear_Student.xClass = " + i.SelectedValue.ToString() + ")");
		h.DataSource = dataSource;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		while (true)
		{
			bool flag = !(A_1.Column.Key == "sort");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					flag = !(A_1.Column.Key == "shaghe");
					num = 3;
					continue;
				case 7:
					if (!flag)
					{
						num = 2;
						continue;
					}
					return;
				case 8:
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set shaghe=" + h.GetRow(h.Row).Cells["shaghe"].Value.ToString().Replace("True", "1").Replace("False", "0") + " where id=" + h.GetRow(h.Row).Cells["id"].Value.ToString());
					num = 0;
					continue;
				case 0:
					return;
				case 1:
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set sort=" + h.GetRow(h.Row).Cells["sort"].Value.ToString() + " where id=" + h.GetRow(h.Row).Cells["id"].Value.ToString());
					num = 6;
					continue;
				case 6:
					return;
				case 2:
					if (true)
					{
					}
					asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set hazer=" + h.GetRow(h.Row).Cells["hazer"].Value.ToString().Replace("True", "1").Replace("False", "0") + " where id=" + h.GetRow(h.Row).Cells["id"].Value.ToString());
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					if (flag)
					{
						flag = !(A_1.Column.Key == "hazer");
						num = 7;
					}
					else
					{
						num = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
		try
		{
			if (true)
			{
			}
			h.CurrentColumn = h.GetRow(0).Cells["sort"].Column;
			((Control)h).Select();
			h.SelectCurrentCellText();
		}
		catch
		{
		}
	}

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
					num = ((!A_0) ? 3 : 2);
					continue;
				case 2:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 4:
					this.m_b.Dispose();
					num = 6;
					continue;
				case 1:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 6;
				case 3:
					num2 = 1;
					goto IL_0074;
				case 6:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void a()
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
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdaz));
		GridEXLayout val2 = new GridEXLayout();
		this.m_c = new Panel();
		d = new Panel();
		e = new Panel();
		k = new Label();
		l = new Label();
		i = new UIComboBox();
		j = new Label();
		f = new Label();
		g = new UIButton();
		h = new GridEX();
		((Control)this.m_c).SuspendLayout();
		((Control)d).SuspendLayout();
		((Control)e).SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(586, 600);
		((Control)this.m_c).TabIndex = 0;
		((Control)d).BackColor = Color.Black;
		((Control)d).Controls.Add((Control)(object)e);
		((Control)d).Dock = (DockStyle)5;
		((Control)d).Location = new Point(0, 0);
		((Control)d).Name = "panel2";
		((Control)d).Size = new Size(584, 598);
		((Control)d).TabIndex = 44;
		((Control)e).BackColor = Color.FromArgb(214, 223, 247);
		((Control)e).Controls.Add((Control)(object)k);
		((Control)e).Controls.Add((Control)(object)l);
		((Control)e).Controls.Add((Control)(object)i);
		((Control)e).Controls.Add((Control)(object)j);
		((Control)e).Controls.Add((Control)(object)f);
		((Control)e).Controls.Add((Control)(object)g);
		((Control)e).Controls.Add((Control)(object)h);
		((Control)e).Location = new Point(3, 3);
		((Control)e).Name = "panel3";
		((Control)e).Size = new Size(578, 592);
		((Control)e).TabIndex = 0;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Location = new Point(245, 12);
		((Control)k).Name = "lYear";
		((Control)k).Size = new Size(55, 24);
		((Control)k).TabIndex = 118;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(310, 12);
		((Control)l).Name = "label3";
		((Control)l).Size = new Size(86, 24);
		((Control)l).TabIndex = 117;
		((Control)l).Text = "سال تعلیمی";
		((Control)i).Anchor = (AnchorStyles)9;
		((UIComboBase)i).ComboStyle = (ComboStyle)1;
		((UIComboBase)i).DropListFont = new Font("B Nazanin", 12f);
		((Control)i).Location = new Point(11, 8);
		((Control)i).Name = "dropCls";
		((Control)i).Size = new Size(142, 31);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)i).StringFormat = val;
		((Control)i).TabIndex = 52;
		i.SelectedIndexChanged += a;
		((Control)j).Anchor = (AnchorStyles)9;
		((Control)j).AutoSize = true;
		((Control)j).Location = new Point(160, 12);
		((Control)j).Name = "label19";
		((Control)j).Size = new Size(39, 24);
		((Control)j).TabIndex = 51;
		((Control)j).Text = "صنف";
		((Control)f).AutoSize = true;
		((Control)f).Font = new Font("B Nazanin", 14f);
		((Control)f).ForeColor = Color.DarkViolet;
		((Control)f).Location = new Point(421, 10);
		((Control)f).Name = "label7";
		((Control)f).Size = new Size(149, 28);
		((Control)f).TabIndex = 50;
		((Control)f).Text = "مدیریت شقه های صنف";
		((Control)g).Anchor = (AnchorStyles)6;
		g.DialogResult = (DialogResult)2;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(40, 40);
		((Control)g).Location = new Point(11, 552);
		((Control)g).Name = "btnClose";
		((Control)g).Size = new Size(93, 35);
		((Control)g).TabIndex = 44;
		((Control)g).Text = "بستن";
		((Control)g).Click += b;
		((Control)h).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		h.DesignTimeLayout = val2;
		h.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		h.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		h.GroupByBoxVisible = false;
		((Control)h).Location = new Point(8, 56);
		((Control)h).Name = "gridEX1";
		((ScrollableBase)h).RecordNavigator = true;
		h.RowHeaders = (InheritableBoolean)1;
		h.SelectedFormatStyle.BackColor = Color.Empty;
		h.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)h).Size = new Size(562, 489);
		((Control)h).TabIndex = 45;
		((ScrollableBase)h).VisualStyle = (VisualStyle)2;
		h.CellUpdated += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(586, 600);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmshaghe";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره";
		((Form)this).Load += c;
		((Control)this.m_c).ResumeLayout(false);
		((Control)d).ResumeLayout(false);
		((Control)e).ResumeLayout(false);
		((Control)e).PerformLayout();
		((ISupportInitialize)h).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
