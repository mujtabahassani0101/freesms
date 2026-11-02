using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using school_Af.Rpt.RptLable;
using school_Af.Rpt.RptLable._4020;

public class asdam : Form
{
	private IContainer m_a = null;

	private GridEX m_b;

	private UIButton m_c;

	private UIButton d;

	private Label e;

	private EditBox f;

	private Label g;

	private EditBox h;

	private Label i;

	private EditBox j;
protected override void Dispose(bool A_0)
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
						num = 2;
					}
					else
					{
						num = 3;
					}
					continue;
				case 2:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 5;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 3:
					num2 = 1;
					goto IL_007c;
				case 5:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdam));
		this.m_b = new GridEX();
		this.m_c = new UIButton();
		d = new UIButton();
		e = new Label();
		f = new EditBox();
		g = new Label();
		h = new EditBox();
		i = new Label();
		j = new EditBox();
		((ISupportInitialize)this.m_b).BeginInit();
		SuspendLayout();
		this.m_b.AllowEdit = InheritableBoolean.False;
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = gridEXLayout;
		this.m_b.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		this.m_b.Location = new Point(12, 18);
		this.m_b.Name = "gridEX1";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.RowHeaders = InheritableBoolean.True;
		this.m_b.Size = new Size(546, 273);
		this.m_b.TabIndex = 0;
		this.m_b.VisualStyle = VisualStyle.Office2003;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Location = new Point(12, 297);
		this.m_c.Name = "btnview";
		this.m_c.Size = new Size(117, 38);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "نمایش گزارش";
		this.m_c.Click += b;
		d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		d.ImageSize = new Size(40, 40);
		d.Location = new Point(12, 341);
		d.Name = "btnClose";
		d.Size = new Size(117, 30);
		d.TabIndex = 110;
		d.Text = "بستن";
		d.Click += a;
		e.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		e.AutoSize = true;
		e.Location = new Point(475, 326);
		e.Name = "label10";
		e.Size = new Size(63, 13);
		e.TabIndex = 133;
		e.Text = "بالای کارت 2";
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = false;
		f.AutoScrollMargin = new Size(0, 0);
		f.AutoScrollMinSize = new Size(0, 0);
		f.AutoScrollPosition = new Point(0, 0);
		f.Location = new Point(135, 349);
		f.MaxLength = 300;
		f.Name = "txtFoter1";
		f.Size = new Size(334, 21);
		f.TabIndex = 132;
		f.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		g.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		g.AutoSize = true;
		g.Location = new Point(475, 352);
		g.Name = "label11";
		g.Size = new Size(55, 13);
		g.TabIndex = 131;
		g.Text = "پایین کارت ";
		h.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		h.AutoScroll = false;
		h.AutoScrollMargin = new Size(0, 0);
		h.AutoScrollMinSize = new Size(0, 0);
		h.AutoScrollPosition = new Point(0, 0);
		h.Location = new Point(135, 324);
		h.MaxLength = 300;
		h.Name = "txtHeder2";
		h.Size = new Size(334, 21);
		h.TabIndex = 130;
		h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		i.AutoSize = true;
		i.Location = new Point(475, 300);
		i.Name = "label12";
		i.Size = new Size(63, 13);
		i.TabIndex = 129;
		i.Text = "بالای کارت 1";
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = false;
		j.AutoScrollMargin = new Size(0, 0);
		j.AutoScrollMinSize = new Size(0, 0);
		j.AutoScrollPosition = new Point(0, 0);
		j.Location = new Point(135, 297);
		j.MaxLength = 300;
		j.Name = "txtHeder1";
		j.Size = new Size(334, 21);
		j.TabIndex = 128;
		j.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(214, 223, 247);
		ClientSize = new Size(581, 384);
		Controls.Add(e);
		Controls.Add(f);
		Controls.Add(g);
		Controls.Add(h);
		Controls.Add(i);
		Controls.Add(j);
		Controls.Add(d);
		Controls.Add(this.m_c);
		Controls.Add(this.m_b);
		Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmRptLable";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "گزارشات";
		Load += c;
		((ISupportInitialize)this.m_b).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public asdam()
	{
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("14");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 2;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tRptLable");
					this.m_b.DataSource = dataTable;
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "SELECT  * FROM  tCardProperties");
					flag = dataTable.Rows.Count <= 0;
					num = 3;
					continue;
				case 1:
					f.Text = dataTable.Rows[0]["Foter1"].ToString();
					j.Text = dataTable.Rows[0]["heder1"].ToString();
					h.Text = dataTable.Rows[0]["heder2"].ToString();
					num = 0;
					continue;
				case 0:
					return;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 2:
					if (true)
					{
					}
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 4;
					continue;
				case 4:
					return;
				}
				break;
			}
		}
	}

	private void a()
	{
		bool flag = default;
		string[] array = default;
		int value = default;
		while (true)
		{
			string text = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text2 = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString());
			ReportClass reportClass = null;
			string text3 = asdcb.a(asdab.e(), CommandType.Text, "SELECT  sch FROM  tParmetr").ToString();
			string text4 = text;
			int num = 31;
			while (true)
			{
				switch (num)
				{
				case 31:
					if (text4 != null)
					{
						num = 13;
						continue;
					}
					goto case 0;
				case 0:
				case 2:
				case 3:
				case 5:
				case 7:
				case 8:
				case 9:
				case 10:
				case 12:
				case 14:
				case 17:
				case 18:
				case 19:
				case 23:
				case 29:
				case 32:
					flag = !(text2 != "");
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 26;
				case 4:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[3].ToString());
					reportClass.Subreports[array[2].ToString()].SetDataSource(dataSource2);
					num = 1;
					continue;
				}
				case 30:
					num = 21;
					continue;
				case 21:
					switch (value)
					{
					case 11:
						reportClass = new crHozehStd4020();
						num = 9;
						break;
					case 0:
						reportClass = new crHozehLabelByName();
						num = 17;
						break;
					default:
						num = 11;
						break;
					case 14:
						reportClass = new crStdIdx_Class4020_2();
						num = 23;
						break;
					case 10:
						reportClass = new CrHozehMinMax2();
						num = 32;
						break;
					case 2:
						reportClass = new crHozehStd();
						num = 7;
						break;
					case 6:
						reportClass = new crHozehAlbom();
						num = 8;
						break;
					case 1:
						reportClass = new crHozehLabel();
						num = 12;
						break;
					case 4:
						reportClass = new crStdIdx_Class();
						num = 19;
						break;
					case 7:
						reportClass = new crAmarHozeh();
						num = 0;
						break;
					case 5:
						reportClass = new crStdIdx_Class2();
						num = 14;
						break;
					case 12:
						reportClass = new crHozehStd4020_2();
						num = 5;
						break;
					case 3:
						reportClass = new crHozehStd2();
						num = 18;
						break;
					case 8:
						reportClass = new CrStdCardidx();
						num = 3;
						break;
					case 9:
						reportClass = new CrHozehMinMax();
						num = 10;
						break;
					case 13:
						reportClass = new CrStdCardidx4020();
						num = 29;
						break;
					}
					continue;
				case 26:
					reportClass.SetDataSource(dataSource);
					num = 24;
					continue;
				case 1:
					num = 26;
					continue;
				case 13:
					num = 16;
					continue;
				case 16:
					if (asdbg.b == null)
					{
						num = 25;
						continue;
					}
					goto case 15;
				case 11:
					num = 2;
					continue;
				case 28:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 1;
				case 34:
					array = text2.Split(',');
					flag = array.Length <= 1;
					num = 27;
					continue;
				case 27:
					if (!flag)
					{
						num = 20;
						continue;
					}
					goto IL_038b;
				case 15:
					num = 22;
					continue;
				case 22:
					if (asdbg.b.TryGetValue(text4, out value))
					{
						num = 30;
						continue;
					}
					goto case 0;
				case 20:
				{
					DataTable dataSource2 = asdcb.c(asdab.e(), CommandType.StoredProcedure, array[1].ToString());
					reportClass.Subreports[array[0].ToString()].SetDataSource(dataSource2);
					num = 33;
					continue;
				}
				case 33:
					if (1 == 0)
					{
					}
					goto IL_038b;
				case 25:
					asdbg.b = new Dictionary<string, int>(15)
					{
						{ "crHozehLabelByName", 0 },
						{ "crHozehLabel", 1 },
						{ "crHozehStd", 2 },
						{ "crHozehStd2", 3 },
						{ "crStdIdx_Class", 4 },
						{ "crStdIdx_Class2", 5 },
						{ "crHozehAlbom", 6 },
						{ "crAmarHozeh", 7 },
						{ "CrStdCardidx", 8 },
						{ "CrHozehMinMax", 9 },
						{ "CrHozehMinMax2", 10 },
						{ "crHozehStd4020", 11 },
						{ "crHozehStd4020_2", 12 },
						{ "CrStdCardidx4020", 13 },
						{ "crStdIdx_Class4020_2", 14 }
					};
					num = 15;
					continue;
				case 24:
					{
						try
						{
							reportClass.ParameterFields["sch"].CurrentValues.AddValue(asdcb.a(asdab.e(), CommandType.Text, "SELECT     sch FROM  tParmetr").ToString());
							reportClass.ParameterFields["heder1"].CurrentValues.AddValue(j.Text);
							reportClass.ParameterFields["heder2"].CurrentValues.AddValue(h.Text);
							reportClass.ParameterFields["foter1"].CurrentValues.AddValue(f.Text);
						}
						catch
						{
						}
						asda asda10 = new asda();
						asda10.__field_a = reportClass;
						asda10.ShowDialog();
						return;
					}
					IL_038b:
					flag = array.Length <= 3;
					num = 28;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[3]
		{
			asdcb.a("@heder1", SqlDbType.NVarChar, j.Text),
			asdcb.a("@heder2", SqlDbType.NVarChar, h.Text),
			asdcb.a("@Foter1", SqlDbType.NVarChar, f.Text)
		};
		asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetCardProperties", a_);
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		Close();
	}
}
