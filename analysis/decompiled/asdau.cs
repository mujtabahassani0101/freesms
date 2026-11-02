using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;

public class asdau : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private bool m_b;

	private int m_c;

	private bool m_d = false;

	private IContainer e = null;

	private Panel f;

	private Panel g;

	private Panel h;

	private UIButton i;

	private GridEX j;

	private UIComboBox k;

	private Label l;

	private UIButton m;

	private Label n;

	private Label o;

	private Label p;

	public asdau()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		a();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("12");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 3:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)h).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 6;
				case 6:
					this.m_b = true;
					((Control)n).Text = asdaj.a;
					c();
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 7;
					continue;
				case 7:
					return;
				case 0:
					num = 3;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + ((Control)n).Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
		k.DataSource = dataSource;
		k.DisplayMember = "Name";
		k.ValueMember = "id";
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT   tYear_Student.id, tYear_Student.sort,      tYear_Student.ShowSarbarg1, tYear_Student.ShowSarbarg2, tYear_Student.ShowSarbarg3, tYear_Student.ShowSarbarg4, tYear_Student.ShowSarbarg6, \r\n                      tYear_Student.ShowSarbarg7,  tStudent.FName+ ' '+ tStudent.LName as Fullname,  tStudent.NumberAsas\r\n,case tYear_Student.Status when 1 then N'برحال' when 2 then N'محروم' when 3 then N'منفک'  when 4 then N'معذرتی' end as vazeyat\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE (tYear_Student.xYear = " + ((Control)n).Text + ") AND (tYear_Student.xClass = " + k.SelectedValue.ToString() + ")");
		j.DataSource = dataSource;
	}

	private void c(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		this.m_b = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = this.m_b;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 10;
				case 8:
					try
					{
						j.CurrentColumn = j.GetRow(0).Cells["ghayeb"].Column;
						((Control)j).Select();
						j.SelectCurrentCellText();
					}
					catch
					{
					}
					if (true)
					{
					}
					this.m_c = k.SelectedIndex;
					num = 7;
					continue;
				case 2:
					this.m_d = false;
					num = 6;
					continue;
				case 6:
					return;
				case 5:
					flag = !this.m_d;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 1;
					continue;
				case 10:
					this.m_d = false;
					this.m_b = true;
					b();
					num = 8;
					continue;
				case 7:
					return;
				case 9:
					this.m_d = true;
					k.SelectedIndex = this.m_c;
					num = 0;
					continue;
				case 0:
					return;
				case 1:
					num = ((!flag) ? 9 : 10);
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			int num = 0;
			if (true)
			{
			}
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 3:
					flag = num < j.RowCount;
					num2 = 0;
					continue;
				case 0:
				{
					if (!flag)
					{
						num2 = 1;
						continue;
					}
					text = j.GetRow(num).Cells["ShowSarbarg1"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text2 = j.GetRow(num).Cells["ShowSarbarg2"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text3 = j.GetRow(num).Cells["ShowSarbarg3"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text4 = j.GetRow(num).Cells["ShowSarbarg4"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text5 = j.GetRow(num).Cells["ShowSarbarg6"].Value.ToString().Replace("True", "1").Replace("False", "0");
					text6 = j.GetRow(num).Cells["ShowSarbarg7"].Value.ToString().Replace("True", "1").Replace("False", "0");
					int num3 = asdcb.d(asdab.e(), CommandType.Text, "update tYear_Student set ShowSarbarg1=" + text + ",ShowSarbarg2=" + text2 + ",ShowSarbarg3=" + text3 + ",ShowSarbarg4=" + text4 + ",ShowSarbarg6=" + text5 + ",ShowSarbarg7=" + text6 + " where id=" + j.GetRow(num).Cells["id"].Value.ToString());
					num++;
					num2 = 2;
					continue;
				}
				case 1:
					MessageBox.Show("انجام شد");
					this.m_b = true;
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
					((Control)j).Refresh();
					a((object)this, (EventArgs)null);
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
			bool flag = this.m_b;
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
					return;
				case 5:
					return;
				case 4:
					((CancelEventArgs)(object)A_1).Cancel = true;
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 0;
					continue;
				case 0:
					num = ((!flag) ? 4 : 5);
					continue;
				}
				break;
			}
		}
	}

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 6;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 6:
					if (true)
					{
					}
					num = ((!A_0) ? 1 : 3);
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					num2 = ((e == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					e.Dispose();
					num = 5;
					continue;
				case 2:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
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
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got Unknown
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdau));
		StringFormat val = new StringFormat();
		GridEXLayout val2 = new GridEXLayout();
		f = new Panel();
		g = new Panel();
		h = new Panel();
		p = new Label();
		m = new UIButton();
		n = new Label();
		o = new Label();
		k = new UIComboBox();
		l = new Label();
		i = new UIButton();
		j = new GridEX();
		((Control)f).SuspendLayout();
		((Control)g).SuspendLayout();
		((Control)h).SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((Control)this).SuspendLayout();
		((Control)f).BackColor = Color.FromArgb(214, 223, 247);
		f.BorderStyle = (BorderStyle)1;
		((Control)f).Controls.Add((Control)(object)g);
		((Control)f).Dock = (DockStyle)5;
		((Control)f).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)f).Location = new Point(0, 0);
		((Control)f).Name = "panel1";
		((Control)f).Size = new Size(719, 671);
		((Control)f).TabIndex = 0;
		((Control)g).BackColor = Color.Black;
		((Control)g).Controls.Add((Control)(object)h);
		((Control)g).Dock = (DockStyle)5;
		((Control)g).Location = new Point(0, 0);
		((Control)g).Name = "panel2";
		((Control)g).Size = new Size(717, 669);
		((Control)g).TabIndex = 44;
		((Control)h).BackColor = Color.FromArgb(214, 223, 247);
		((Control)h).Controls.Add((Control)(object)p);
		((Control)h).Controls.Add((Control)(object)m);
		((Control)h).Controls.Add((Control)(object)n);
		((Control)h).Controls.Add((Control)(object)o);
		((Control)h).Controls.Add((Control)(object)k);
		((Control)h).Controls.Add((Control)(object)l);
		((Control)h).Controls.Add((Control)(object)i);
		((Control)h).Controls.Add((Control)(object)j);
		((Control)h).Location = new Point(3, 3);
		((Control)h).Name = "panel3";
		((Control)h).Size = new Size(711, 663);
		((Control)h).TabIndex = 0;
		((Control)p).AutoSize = true;
		((Control)p).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)p).ForeColor = Color.DarkViolet;
		((Control)p).Location = new Point(140, 2);
		((Control)p).Name = "label7";
		((Control)p).Size = new Size(423, 33);
		((Control)p).TabIndex = 121;
		((Control)p).Text = "فعال / غیرفعال کردن چاپ دانش آموزان در بخش طراحی";
		((Control)m).Anchor = (AnchorStyles)10;
		m.ButtonStyle = (ButtonStyle)1;
		((Control)m).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		m.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		m.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		m.ImageIndex = 8;
		((Control)m).Location = new Point(548, 620);
		((Control)m).Name = "btnAcp";
		((Control)m).RightToLeft = (RightToLeft)1;
		((Control)m).Size = new Size(153, 40);
		((Control)m).TabIndex = 120;
		((Control)m).Text = "ثبت (F5)";
		m.VisualStyle = (VisualStyle)1;
		((Control)m).Click += a;
		n.BorderStyle = (BorderStyle)1;
		((Control)n).Location = new Point(11, 43);
		((Control)n).Name = "lYear";
		((Control)n).Size = new Size(59, 24);
		((Control)n).TabIndex = 118;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(76, 43);
		((Control)o).Name = "label3";
		((Control)o).Size = new Size(78, 26);
		((Control)o).TabIndex = 117;
		((Control)o).Text = "سال تعلیمی\r\n";
		((Control)k).Anchor = (AnchorStyles)9;
		((UIComboBase)k).ComboStyle = (ComboStyle)1;
		((UIComboBase)k).DropListFont = new Font("B Nazanin", 12f);
		((Control)k).Location = new Point(384, 38);
		((Control)k).Name = "dropCls";
		((Control)k).Size = new Size(273, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)k).StringFormat = val;
		((Control)k).TabIndex = 52;
		k.SelectedIndexChanged += b;
		((Control)l).Anchor = (AnchorStyles)9;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(663, 44);
		((Control)l).Name = "label19";
		((Control)l).Size = new Size(41, 26);
		((Control)l).TabIndex = 51;
		((Control)l).Text = "صنف";
		((Control)i).Anchor = (AnchorStyles)6;
		i.DialogResult = (DialogResult)2;
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(40, 40);
		((Control)i).Location = new Point(11, 623);
		((Control)i).Name = "btnClose";
		((Control)i).Size = new Size(93, 35);
		((Control)i).TabIndex = 44;
		((Control)i).Text = "بستن";
		((Control)i).Click += c;
		((Control)j).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		j.DesignTimeLayout = val2;
		j.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		j.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)j).Font = new Font("Tahoma", 9.75f);
		j.GroupByBoxVisible = false;
		((Control)j).Location = new Point(8, 76);
		((Control)j).Name = "gridEX1";
		((ScrollableBase)j).RecordNavigator = true;
		j.RowHeaders = (InheritableBoolean)1;
		j.SelectedFormatStyle.BackColor = Color.Empty;
		j.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)j).Size = new Size(700, 540);
		((Control)j).TabIndex = 45;
		((ScrollableBase)j).VisualStyle = (VisualStyle)2;
		j.CellUpdated += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(719, 671);
		((Control)this).Controls.Add((Control)(object)f);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmActivStdSarbarg";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره";
		((Form)this).Load += d;
		((Control)this).KeyUp += a;
		((Form)this).FormClosing += a;
		((Control)f).ResumeLayout(false);
		((Control)g).ResumeLayout(false);
		((Control)h).ResumeLayout(false);
		((Control)h).PerformLayout();
		((ISupportInitialize)j).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
