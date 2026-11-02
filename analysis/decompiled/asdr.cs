using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdr : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private Panel m_c;

	private UIButton m_d;

	private Label e;

	private Panel f;

	private UIButton g;

	private EditBox h;

	private Label i;

	private ComboBox j;

	private Label k;

	private Label l;

	private bool m;

	private SqlConnection n = new SqlConnection(asdab.e());

	protected override void a(bool A_0)
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 2;
					}
					continue;
				case 3:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
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
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void c()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdr));
		this.m_b = new GridEX();
		this.m_c = new Panel();
		k = new Label();
		l = new Label();
		j = new ComboBox();
		i = new Label();
		e = new Label();
		this.m_d = new UIButton();
		g = new UIButton();
		f = new Panel();
		h = new EditBox();
		((ISupportInitialize)this.m_b).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)f).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_b.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)this.m_b).Font = new Font("B Nazanin", 12f);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(8, 81);
		((Control)this.m_b).Name = "gridEX1";
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(368, 316);
		((Control)this.m_b).TabIndex = 5;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		((Control)this.m_c).BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)k);
		((Control)this.m_c).Controls.Add((Control)(object)l);
		((Control)this.m_c).Controls.Add((Control)(object)j);
		((Control)this.m_c).Controls.Add((Control)(object)i);
		((Control)this.m_c).Controls.Add((Control)(object)e);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Controls.Add((Control)(object)g);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_c).Location = new Point(5, 6);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(386, 488);
		((Control)this.m_c).TabIndex = 0;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Location = new Point(14, 8);
		((Control)k).Name = "lYear";
		((Control)k).Size = new Size(55, 24);
		((Control)k).TabIndex = 118;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(75, 7);
		((Control)l).Name = "label3";
		((Control)l).Size = new Size(78, 26);
		((Control)l).TabIndex = 117;
		((Control)l).Text = "سال تعلیمی";
		((Control)j).Anchor = (AnchorStyles)9;
		j.DropDownStyle = (ComboBoxStyle)2;
		((Control)j).Font = new Font("Tahoma", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ListControl)j).FormattingEnabled = true;
		((Control)j).Location = new Point(9, 43);
		((Control)j).Name = "dropPayeSeacrch";
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(295, 31);
		((Control)j).TabIndex = 85;
		((ListControl)j).SelectedValueChanged += a;
		((Control)i).Anchor = (AnchorStyles)9;
		((Control)i).AutoSize = true;
		((Control)i).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(309, 44);
		((Control)i).Name = "label1";
		((Control)i).Size = new Size(42, 26);
		((Control)i).TabIndex = 50;
		((Control)i).Text = "پایه  :";
		((Control)e).AutoSize = true;
		((Control)e).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)e).ForeColor = Color.DarkViolet;
		((Control)e).Location = new Point(241, 3);
		((Control)e).Name = "label4";
		((Control)e).Size = new Size(124, 33);
		((Control)e).TabIndex = 17;
		((Control)e).Text = "لیست صنف ها";
		((Control)this.m_d).Anchor = (AnchorStyles)14;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		((Control)this.m_d).Location = new Point(8, 446);
		((Control)this.m_d).Name = "btnClose";
		((Control)this.m_d).Size = new Size(369, 38);
		((Control)this.m_d).TabIndex = 15;
		((Control)this.m_d).Text = "خروج";
		((Control)this.m_d).Click += b;
		g.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)g).Location = new Point(9, 403);
		((Control)g).Name = "btnAcp";
		((Control)g).Size = new Size(368, 39);
		((Control)g).TabIndex = 14;
		((Control)g).Text = "ثبت اولویت";
		((Control)g).Click += c;
		((Control)f).BackColor = SystemColors.ControlText;
		((Control)f).Controls.Add((Control)(object)this.m_c);
		((Control)f).Dock = (DockStyle)5;
		((Control)f).Location = new Point(0, 0);
		((Control)f).Name = "panel2";
		((Control)f).Size = new Size(395, 500);
		((Control)f).TabIndex = 1;
		((EditBase)h).AutoScroll = false;
		((EditBase)h).AutoScrollMargin = new Size(0, 0);
		((EditBase)h).AutoScrollMinSize = new Size(0, 0);
		((EditBase)h).AutoScrollPosition = new Point(0, 0);
		((Control)h).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).Location = new Point(14, 55);
		((Control)h).Name = "txtNam";
		((Control)h).Size = new Size(184, 33);
		((Control)h).TabIndex = 0;
		((EditBase)h).TextAlignment = (TextAlignment)1;
		((Form)this).AcceptButton = (IButtonControl)(object)g;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(395, 500);
		((Control)this).Controls.Add((Control)(object)f);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmClsSort";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست صنف ها";
		((Form)this).Load += d;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_c).PerformLayout();
		((Control)f).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdr()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		c();
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
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
				case 1:
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
					if (true)
					{
					}
					num = 2;
					continue;
				case 3:
					num = 1;
					continue;
				case 2:
					((Control)k).Text = asdaj.a;
					m = false;
					b();
					m = true;
					a();
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		bool flag = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tPaye order by id");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					flag = num < dataTable.Rows.Count;
					num2 = 0;
					continue;
				case 0:
					if (!flag)
					{
						num2 = 2;
						continue;
					}
					dictionary.Add(dataTable.Rows[num]["id"].ToString(), dataTable.Rows[num]["name"].ToString());
					num++;
					if (true)
					{
					}
					num2 = 1;
					continue;
				case 2:
					j.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)j).DisplayMember = "Value";
					((ListControl)j).ValueMember = "Key";
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			bool flag = m;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 4;
						continue;
					}
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * from tclass where  xYear=" + ((Control)k).Text + " and xpaye=" + ((ListControl)j).SelectedValue);
					this.m_b.DataSource = dataSource;
					num = 3;
					continue;
				}
				case 3:
					try
					{
						this.m_b.CurrentColumn = this.m_b.GetRow(0).Cells["sortBarchasb"].Column;
						((Control)this.m_b).Select();
						this.m_b.SelectCurrentCellText();
						((Control)this.m_b).Refresh();
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 0;
					continue;
				case 4:
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		while (true)
		{
			SqlCommand val = null;
			string text = "";
			((DbConnection)(object)n).Open();
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 6:
					((DbCommand)(object)val).ExecuteNonQuery();
					num++;
					num2 = 4;
					continue;
				case 4:
					if (1 == 0)
					{
					}
					goto case 0;
				case 7:
					if (flag)
					{
						val.Parameters.AddWithValue("@sortBarchasb", (object)this.m_b.GetRow(num).Cells["sortBarchasb"].Text.ToString());
						num2 = 3;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 0:
					flag = num < this.m_b.RowCount;
					num2 = 1;
					continue;
				case 1:
					if (flag)
					{
						text = this.m_b.GetRow(num).Cells["sortBarchasb"].Text.ToString();
						val = new SqlCommand("update tclass set sortBarchasb=@sortBarchasb where id=@id", n);
						val.Parameters.AddWithValue("@id", (object)this.m_b.GetRow(num).Cells["id"].Text.ToString());
						flag = !(text == "");
						num2 = 7;
					}
					else
					{
						num2 = 2;
					}
					continue;
				case 5:
					val.Parameters.AddWithValue("@sortBarchasb", (object)DBNull.Value);
					num2 = 6;
					continue;
				case 2:
					((DbConnection)(object)n).Close();
					MessageBox.Show("ثبت شد");
					a();
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
		a();
	}
}
