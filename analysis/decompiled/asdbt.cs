using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

public class asdbt : Form
{
	private Container m_a = null;

	private Panel m_b;

	private Panel c;

	private Label d;

	private Panel e;

	private GridEX f;

	private UIButton g;

	public asdbt()
	{
		b();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
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
						num = 5;
						continue;
					}
					goto case 2;
				case 1:
					num = 2;
					continue;
				case 3:
					this.m_a.Dispose();
					num = 1;
					continue;
				case 5:
					flag = this.m_a == null;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 2:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
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
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbt));
		GridEXLayout val = new GridEXLayout();
		this.m_b = new Panel();
		c = new Panel();
		e = new Panel();
		g = new UIButton();
		d = new Label();
		f = new GridEX();
		((Control)this.m_b).SuspendLayout();
		((Control)c).SuspendLayout();
		((Control)e).SuspendLayout();
		((ISupportInitialize)f).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.Black;
		((Control)this.m_b).Controls.Add((Control)(object)c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel3";
		((Control)this.m_b).Size = new Size(312, 584);
		((Control)this.m_b).TabIndex = 17;
		((Control)c).BackColor = Color.SkyBlue;
		c.BorderStyle = (BorderStyle)1;
		((Control)c).Controls.Add((Control)(object)e);
		((Control)c).Location = new Point(4, 6);
		((Control)c).Name = "panel1";
		((Control)c).Size = new Size(303, 573);
		((Control)c).TabIndex = 17;
		((Control)e).BackColor = Color.FromArgb(214, 223, 247);
		e.BorderStyle = (BorderStyle)1;
		((Control)e).Controls.Add((Control)(object)g);
		((Control)e).Controls.Add((Control)(object)d);
		((Control)e).Controls.Add((Control)(object)f);
		((Control)e).Dock = (DockStyle)2;
		((Control)e).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)e).Location = new Point(0, -1);
		((Control)e).Name = "panel2";
		((Control)e).RightToLeft = (RightToLeft)1;
		((Control)e).Size = new Size(301, 572);
		((Control)e).TabIndex = 16;
		((Control)g).Anchor = (AnchorStyles)6;
		g.DialogResult = (DialogResult)2;
		g.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		g.ImageSize = new Size(20, 20);
		((Control)g).Location = new Point(218, 11);
		((Control)g).Name = "btnClose";
		((Control)g).Size = new Size(64, 28);
		((Control)g).TabIndex = 50;
		((Control)g).Text = "بستن";
		((Control)g).Click += a;
		((Control)d).Anchor = (AnchorStyles)13;
		((Control)d).AutoSize = true;
		((Control)d).Font = new Font("B Nazanin", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)d).Location = new Point(53, 5);
		((Control)d).Name = "label5";
		((Control)d).Size = new Size(146, 35);
		((Control)d).TabIndex = 49;
		((Control)d).Text = "آیتم های ثبت نام";
		((Control)f).Anchor = (AnchorStyles)9;
		f.CardCaptionPrefix = "Product:";
		f.DataMember = null;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		f.DesignTimeLayout = val;
		f.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((ScrollableBase)f).FlatBorderColor = SystemColors.ControlDark;
		((Control)f).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		f.GridLineColor = SystemColors.ScrollBar;
		f.GroupByBoxVisible = false;
		f.GroupRowVisualStyle = (GroupRowVisualStyle)1;
		((Control)f).Location = new Point(7, 43);
		((Control)f).Name = "gridx1";
		((Control)f).RightToLeft = (RightToLeft)1;
		f.RowHeaders = (InheritableBoolean)1;
		f.SelectedFormatStyle.Blend = 0.5f;
		f.SelectedFormatStyle.ForeColor = SystemColors.WindowText;
		((Control)f).Size = new Size(283, 521);
		((Control)f).TabIndex = 15;
		((ScrollableBase)f).VisualStyleAreas.CheckBoxStyle = (VisualStyle)1;
		((ScrollableBase)f).VisualStyleAreas.ControlBorderStyle = (VisualStyle)1;
		((ScrollableBase)f).VisualStyleAreas.EditControlsStyle = (VisualStyle)1;
		((ScrollableBase)f).VisualStyleAreas.GroupByBoxStyle = (VisualStyle)1;
		((ScrollableBase)f).VisualStyleAreas.GroupRowsStyle = (VisualStyle)1;
		((ScrollableBase)f).VisualStyleAreas.HeadersStyle = (VisualStyle)2;
		((ScrollableBase)f).VisualStyleAreas.ScrollBarsStyle = (VisualStyle)1;
		((ScrollableBase)f).VisualStyleAreas.TreeGliphsStyle = (VisualStyle)1;
		f.CellUpdated += a;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(312, 584);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSabtenamItemEnable";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "لیست دروس";
		((Form)this).Load += b;
		((Control)this.m_b).ResumeLayout(false);
		((Control)c).ResumeLayout(false);
		((Control)e).ResumeLayout(false);
		((Control)e).PerformLayout();
		((ISupportInitialize)f).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void a()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT * from tItemSabtenamEnable");
		f.DataSource = dataSource;
	}

	private void b(object A_0, EventArgs A_1)
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
						num = 1;
						continue;
					}
					goto case 2;
				case 3:
					try
					{
						int num2 = int.Parse(dataTable.Rows[0]["R"].ToString());
						int num3 = int.Parse(dataTable.Rows[0]["G"].ToString());
						int num4 = int.Parse(dataTable.Rows[0]["B"].ToString());
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 2;
					continue;
				case 1:
					num = 3;
					continue;
				case 2:
					a();
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		while (true)
		{
			bool flag = !(A_1.Column.Key == "Enable");
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
					asdcb.d(asdab.e(), CommandType.Text, "update tItemSabtenamEnable set Enable=" + f.GetRow(f.Row).Cells["Enable"].Value.ToString().Replace("True", "1").Replace("False", "0") + " where id=" + f.GetRow(f.Row).Cells["id"].Value.ToString());
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}
}
