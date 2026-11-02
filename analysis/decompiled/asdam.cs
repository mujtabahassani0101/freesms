using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
						((Form)this).Dispose(A_0);
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
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected Obj, but got Unknown
		if (true)
		{
		}
		GridEXLayout val = new GridEXLayout();
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
		((Control)this).SuspendLayout();
		this.m_b.AllowEdit = (InheritableBoolean)2;
		((Control)this.m_b).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		this.m_b.DesignTimeLayout = val;
		this.m_b.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		this.m_b.GroupByBoxVisible = false;
		((Control)this.m_b).Location = new Point(12, 18);
		((Control)this.m_b).Name = "gridEX1";
		((Control)this.m_b).RightToLeft = (RightToLeft)1;
		this.m_b.RowHeaders = (InheritableBoolean)1;
		((Control)this.m_b).Size = new Size(546, 273);
		((Control)this.m_b).TabIndex = 0;
		((ScrollableBase)this.m_b).VisualStyle = (VisualStyle)2;
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		((Control)this.m_c).Location = new Point(12, 297);
		((Control)this.m_c).Name = "btnview";
		((Control)this.m_c).Size = new Size(117, 38);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "نمایش گزارش";
		((Control)this.m_c).Click += b;
		((Control)d).Anchor = (AnchorStyles)6;
		d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		d.ImageSize = new Size(40, 40);
		((Control)d).Location = new Point(12, 341);
		((Control)d).Name = "btnClose";
		((Control)d).Size = new Size(117, 30);
		((Control)d).TabIndex = 110;
		((Control)d).Text = "بستن";
		((Control)d).Click += a;
		((Control)e).Anchor = (AnchorStyles)10;
		((Control)e).AutoSize = true;
		((Control)e).Location = new Point(475, 326);
		((Control)e).Name = "label10";
		((Control)e).Size = new Size(63, 13);
		((Control)e).TabIndex = 133;
		((Control)e).Text = "بالای کارت 2";
		((Control)f).Anchor = (AnchorStyles)10;
		((EditBase)f).AutoScroll = false;
		((EditBase)f).AutoScrollMargin = new Size(0, 0);
		((EditBase)f).AutoScrollMinSize = new Size(0, 0);
		((EditBase)f).AutoScrollPosition = new Point(0, 0);
		((Control)f).Location = new Point(135, 349);
		((EditBase)f).MaxLength = 300;
		((Control)f).Name = "txtFoter1";
		((Control)f).Size = new Size(334, 21);
		((Control)f).TabIndex = 132;
		((EditBase)f).TextAlignment = (TextAlignment)1;
		((Control)g).Anchor = (AnchorStyles)10;
		((Control)g).AutoSize = true;
		((Control)g).Location = new Point(475, 352);
		((Control)g).Name = "label11";
		((Control)g).Size = new Size(55, 13);
		((Control)g).TabIndex = 131;
		((Control)g).Text = "پایین کارت ";
		((Control)h).Anchor = (AnchorStyles)10;
		((EditBase)h).AutoScroll = false;
		((EditBase)h).AutoScrollMargin = new Size(0, 0);
		((EditBase)h).AutoScrollMinSize = new Size(0, 0);
		((EditBase)h).AutoScrollPosition = new Point(0, 0);
		((Control)h).Location = new Point(135, 324);
		((EditBase)h).MaxLength = 300;
		((Control)h).Name = "txtHeder2";
		((Control)h).Size = new Size(334, 21);
		((Control)h).TabIndex = 130;
		((EditBase)h).TextAlignment = (TextAlignment)1;
		((Control)i).Anchor = (AnchorStyles)10;
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(475, 300);
		((Control)i).Name = "label12";
		((Control)i).Size = new Size(63, 13);
		((Control)i).TabIndex = 129;
		((Control)i).Text = "بالای کارت 1";
		((Control)j).Anchor = (AnchorStyles)10;
		((EditBase)j).AutoScroll = false;
		((EditBase)j).AutoScrollMargin = new Size(0, 0);
		((EditBase)j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)j).AutoScrollPosition = new Point(0, 0);
		((Control)j).Location = new Point(135, 297);
		((EditBase)j).MaxLength = 300;
		((Control)j).Name = "txtHeder1";
		((Control)j).Size = new Size(334, 21);
		((Control)j).TabIndex = 128;
		((EditBase)j).TextAlignment = (TextAlignment)1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.FromArgb(214, 223, 247);
		((Form)this).ClientSize = new Size(581, 384);
		((Control)this).Controls.Add((Control)(object)e);
		((Control)this).Controls.Add((Control)(object)f);
		((Control)this).Controls.Add((Control)(object)g);
		((Control)this).Controls.Add((Control)(object)h);
		((Control)this).Controls.Add((Control)(object)i);
		((Control)this).Controls.Add((Control)(object)j);
		((Control)this).Controls.Add((Control)(object)d);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmRptLable";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "گزارشات";
		((Form)this).Load += c;
		((ISupportInitialize)this.m_b).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public asdam()
	{
		b();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
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
					((Control)f).Text = dataTable.Rows[0]["Foter1"].ToString();
					((Control)j).Text = dataTable.Rows[0]["heder1"].ToString();
					((Control)h).Text = dataTable.Rows[0]["heder2"].ToString();
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
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
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		string[] array = default;
		int value = default;
		while (true)
		{
			string text = this.m_b.SelectedItems[0].GetRow().Cells["Rpt"].Value.ToString();
			string text2 = this.m_b.SelectedItems[0].GetRow().Cells["subReport"].Value.ToString();
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.StoredProcedure, this.m_b.SelectedItems[0].GetRow().Cells["sp"].Value.ToString());
			ReportClass val = null;
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
					((ReportDocument)val).Subreports[array[2].ToString()].SetDataSource(dataSource2);
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
						val = (ReportClass)(object)new crHozehStd4020();
						num = 9;
						break;
					case 0:
						val = (ReportClass)(object)new crHozehLabelByName();
						num = 17;
						break;
					default:
						num = 11;
						break;
					case 14:
						val = (ReportClass)(object)new crStdIdx_Class4020_2();
						num = 23;
						break;
					case 10:
						val = (ReportClass)(object)new CrHozehMinMax2();
						num = 32;
						break;
					case 2:
						val = (ReportClass)(object)new crHozehStd();
						num = 7;
						break;
					case 6:
						val = (ReportClass)(object)new crHozehAlbom();
						num = 8;
						break;
					case 1:
						val = (ReportClass)(object)new crHozehLabel();
						num = 12;
						break;
					case 4:
						val = (ReportClass)(object)new crStdIdx_Class();
						num = 19;
						break;
					case 7:
						val = (ReportClass)(object)new crAmarHozeh();
						num = 0;
						break;
					case 5:
						val = (ReportClass)(object)new crStdIdx_Class2();
						num = 14;
						break;
					case 12:
						val = (ReportClass)(object)new crHozehStd4020_2();
						num = 5;
						break;
					case 3:
						val = (ReportClass)(object)new crHozehStd2();
						num = 18;
						break;
					case 8:
						val = (ReportClass)(object)new CrStdCardidx();
						num = 3;
						break;
					case 9:
						val = (ReportClass)(object)new CrHozehMinMax();
						num = 10;
						break;
					case 13:
						val = (ReportClass)(object)new CrStdCardidx4020();
						num = 29;
						break;
					}
					continue;
				case 26:
					((ReportDocument)val).SetDataSource(dataSource);
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
					array = text2.Split(new char[1] { ',' });
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
					((ReportDocument)val).Subreports[array[0].ToString()].SetDataSource(dataSource2);
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
							((ReportDocument)val).ParameterFields["sch"].CurrentValues.AddValue((object)asdcb.a(asdab.e(), CommandType.Text, "SELECT     sch FROM  tParmetr").ToString());
							((ReportDocument)val).ParameterFields["heder1"].CurrentValues.AddValue((object)((Control)j).Text);
							((ReportDocument)val).ParameterFields["heder2"].CurrentValues.AddValue((object)((Control)h).Text);
							((ReportDocument)val).ParameterFields["foter1"].CurrentValues.AddValue((object)((Control)f).Text);
						}
						catch
						{
						}
						asda asda10 = new asda();
						asda10.a = val;
						((Form)asda10).ShowDialog();
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
			asdcb.a("@heder1", SqlDbType.NVarChar, ((Control)j).Text),
			asdcb.a("@heder2", SqlDbType.NVarChar, ((Control)h).Text),
			asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)f).Text)
		};
		asdcb.d(asdab.e(), CommandType.StoredProcedure, "updatetCardProperties", a_);
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}
}
