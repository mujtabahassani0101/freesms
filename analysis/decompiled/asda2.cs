using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

public class asda2 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private UIGroupBox m_d;

	private Label e;

	private Label f;

	private Label g;

	private GridEX h;

	public Label i;

	public Label j;

	public Label k;

	private Button l;

	private GroupBox m;

	private TextBox n;

	private Label o;

	private Button p;

	private Label q;

	public string r;

	public string s;

	public string t;

	public string u;

	public string v;

	private SqlConnection w = new SqlConnection(asdab.e());

	private bool x;

	protected override void a(bool A_0)
	{
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
					if (A_0)
					{
						if (true)
						{
						}
						num = 3;
					}
					else
					{
						num = 0;
					}
					continue;
				case 3:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 4;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
					continue;
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
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda2));
		GridEXLayout val = new GridEXLayout();
		this.m_b = new Panel();
		q = new Label();
		m = new GroupBox();
		n = new TextBox();
		o = new Label();
		p = new Button();
		l = new Button();
		this.m_d = new UIGroupBox();
		j = new Label();
		k = new Label();
		i = new Label();
		g = new Label();
		f = new Label();
		e = new Label();
		this.m_c = new UIButton();
		h = new GridEX();
		((Control)this.m_b).SuspendLayout();
		((Control)m).SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this.m_d).SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)q);
		((Control)this.m_b).Controls.Add((Control)(object)m);
		((Control)this.m_b).Controls.Add((Control)(object)l);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)h);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(800, 600);
		((Control)this.m_b).TabIndex = 0;
		((Control)q).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)q).ForeColor = Color.DarkViolet;
		((Control)q).Location = new Point(279, 3);
		((Control)q).Name = "lheder";
		((Control)q).Size = new Size(288, 24);
		((Control)q).TabIndex = 44;
		((Control)q).Text = "ورود توضیحات زیر اطلاع نامه";
		q.TextAlign = (ContentAlignment)32;
		((Control)m).Controls.Add((Control)(object)n);
		((Control)m).Controls.Add((Control)(object)o);
		((Control)m).Controls.Add((Control)(object)p);
		((Control)m).Location = new Point(8, 89);
		((Control)m).Name = "groupBox1";
		((Control)m).Size = new Size(779, 52);
		((Control)m).TabIndex = 42;
		m.TabStop = false;
		((Control)m).Text = "وارد متن یکسان";
		((Control)n).Location = new Point(85, 23);
		((Control)n).Name = "txtmarkAll";
		((Control)n).Size = new Size(638, 21);
		((Control)n).TabIndex = 43;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(729, 26);
		((Control)o).Name = "label6";
		((Control)o).Size = new Size(32, 13);
		((Control)o).TabIndex = 42;
		((Control)o).Text = "متن :";
		((Control)p).Location = new Point(6, 20);
		((Control)p).Name = "btnMarkAll";
		((Control)p).Size = new Size(71, 24);
		((Control)p).TabIndex = 41;
		((Control)p).Text = "ثبت";
		((ButtonBase)p).UseVisualStyleBackColor = true;
		((Control)p).Click += a;
		((Control)l).Anchor = (AnchorStyles)10;
		((Control)l).Location = new Point(593, 552);
		((Control)l).Name = "btnSaveMark";
		((Control)l).Size = new Size(197, 35);
		((Control)l).TabIndex = 18;
		((Control)l).Text = "ثبت توضیحات";
		((ButtonBase)l).UseVisualStyleBackColor = true;
		((Control)l).Click += b;
		((Control)this.m_d).Anchor = (AnchorStyles)13;
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Controls.Add((Control)(object)f);
		((Control)this.m_d).Controls.Add((Control)(object)e);
		((Control)this.m_d).Location = new Point(11, 24);
		((Control)this.m_d).Name = "uiGroupBox1";
		((Control)this.m_d).Size = new Size(776, 62);
		((Control)this.m_d).TabIndex = 17;
		((Control)j).Anchor = (AnchorStyles)9;
		j.BorderStyle = (BorderStyle)1;
		((Control)j).Location = new Point(19, 26);
		((Control)j).Name = "lExam";
		((Control)j).Size = new Size(183, 23);
		((Control)j).TabIndex = 33;
		j.TextAlign = (ContentAlignment)32;
		((Control)k).Anchor = (AnchorStyles)9;
		k.BorderStyle = (BorderStyle)1;
		((Control)k).Location = new Point(277, 26);
		((Control)k).Name = "lClass";
		((Control)k).Size = new Size(183, 23);
		((Control)k).TabIndex = 32;
		k.TextAlign = (ContentAlignment)32;
		((Control)i).Anchor = (AnchorStyles)9;
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Location = new Point(541, 26);
		((Control)i).Name = "lPaye";
		((Control)i).Size = new Size(183, 23);
		((Control)i).TabIndex = 30;
		i.TextAlign = (ContentAlignment)32;
		((Control)g).Anchor = (AnchorStyles)9;
		((Control)g).AutoSize = true;
		((Control)g).Location = new Point(208, 31);
		((Control)g).Name = "ltextExam";
		((Control)g).Size = new Size(33, 13);
		((Control)g).TabIndex = 29;
		((Control)g).Text = "دوره :";
		((Control)f).Anchor = (AnchorStyles)9;
		((Control)f).AutoSize = true;
		((Control)f).Location = new Point(466, 30);
		((Control)f).Name = "label19";
		((Control)f).Size = new Size(37, 13);
		((Control)f).TabIndex = 25;
		((Control)f).Text = "صنف :";
		((Control)e).Anchor = (AnchorStyles)9;
		((Control)e).AutoSize = true;
		((Control)e).Location = new Point(726, 30);
		((Control)e).Name = "label20";
		((Control)e).Size = new Size(29, 13);
		((Control)e).TabIndex = 15;
		((Control)e).Text = "پایه :";
		e.TextAlign = (ContentAlignment)16;
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(40, 40);
		((Control)this.m_c).Location = new Point(11, 552);
		((Control)this.m_c).Name = "btnClose";
		((Control)this.m_c).Size = new Size(189, 35);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "بستن";
		((Control)this.m_c).Click += c;
		((Control)h).Anchor = (AnchorStyles)15;
		val.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		h.DesignTimeLayout = val;
		h.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		h.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)h).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		h.GroupByBoxVisible = false;
		((Control)h).Location = new Point(8, 147);
		((Control)h).Name = "gridEX1";
		((ScrollableBase)h).RecordNavigator = true;
		h.RowHeaders = (InheritableBoolean)1;
		h.SelectedFormatStyle.BackColor = Color.Empty;
		h.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)h).Size = new Size(782, 398);
		((Control)h).TabIndex = 5;
		((ScrollableBase)h).VisualStyle = (VisualStyle)2;
		h.CellValueChanged += a;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(800, 600);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmCommentKoll";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره";
		((Form)this).Load += d;
		((Form)this).FormClosing += a;
		((Control)this.m_b).ResumeLayout(false);
		((Control)m).ResumeLayout(false);
		((Control)m).PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((ISupportInitialize)h).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asda2()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 4;
					continue;
				case 0:
					((Control)q).Text = "ورود توضیحات زیر اطلاع نامه";
					num = 1;
					continue;
				case 4:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 1:
					flag = !(u == "6");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 10;
						continue;
					}
					return;
				case 9:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 7;
					continue;
				case 7:
					return;
				case 6:
					x = true;
					a();
					flag = !(u == "5");
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 10:
					((Control)j).Visible = false;
					((Control)g).Visible = false;
					((Control)q).Text = "ورود توضیحات جدول نتایج";
					if (true)
					{
					}
					num = 5;
					continue;
				case 5:
					return;
				case 8:
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
				case 2:
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		while (true)
		{
			string text = "";
			bool flag = !(r != "0");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 13;
				case 11:
					text = text + " tYear_Student.xPaye=" + s;
					num = 3;
					continue;
				case 1:
					flag = !(text != "");
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 11;
				case 10:
					text += " and ";
					num = 9;
					continue;
				case 3:
					flag = !(text != "");
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 2;
				case 0:
					flag = !(text != "");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 10;
						continue;
					}
					goto case 9;
				case 14:
					text += " and ";
					num = 11;
					continue;
				case 7:
					text = " where " + text;
					num = 2;
					continue;
				case 13:
					flag = !(s != "0");
					num = 6;
					continue;
				case 6:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 3;
				case 9:
					text = text + " tYear_Student.xClass=" + r;
					num = 13;
					continue;
				case 2:
				{
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT  0 as acp,  tStudent.id,tYear_Student.sort, tStudent.NumberAsas,\r\n                                                               tStudent.Code, tStudent.FName, tStudent.LName, tStudent.PName,tmpComnent.comment\r\n                                                                FROM  tStudent inner join tYear_Student on tStudent.id=tYear_Student.xStudent   LEFT OUTER JOIN\r\n                                                              (SELECT     xStudent, Xtest, xbook, comment\r\n                                                                 FROM         tComnentKarname\r\n                                                                 WHERE     (Xtest = " + t + ") AND typ=" + u + " and  (xbook = " + v + ")) tmpComnent ON tStudent.id = tmpComnent.xStudent" + text + " order by tStudent.LName, tStudent.FName");
					h.DataSource = dataSource;
					GridEXFormatCondition val = new GridEXFormatCondition(h.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
					val.FormatStyle.ForeColor = SystemColors.WindowText;
					val.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					h.RootTable.FormatConditions.Add(val);
					GridEXFormatCondition val2 = new GridEXFormatCondition(h.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
					val2.FormatStyle.ForeColor = SystemColors.WindowText;
					val2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					h.RootTable.FormatConditions.Add(val2);
					return;
				}
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
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		bool flag = default;
		while (true)
		{
			SqlCommand val = null;
			SqlConnection val2 = new SqlConnection(asdab.e());
			((DbConnection)(object)w).Open();
			string text = "";
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			while (true)
			{
				switch (num3)
				{
				case 1:
				case 6:
					flag = num2 < h.RowCount;
					num3 = 12;
					continue;
				case 12:
					if (!flag)
					{
						num3 = 13;
						continue;
					}
					text = "";
					text = h.GetRow(num2).Cells["comment"].Text.ToString();
					text = asdaj.b(text.Trim());
					flag = !(text == "");
					num3 = 3;
					continue;
				case 8:
				case 14:
					num3 = 5;
					continue;
				case 4:
					val = new SqlCommand("DELETE FROM tComnentKarname WHERE (xStudent = @xStudent) And typ=5 AND (Xtest = @Xtest) AND (xbook = @xbook)", w);
					val.Parameters.AddWithValue("@xStudent", (object)h.GetRow(num2).Cells["id"].Text.ToString());
					val.Parameters.AddWithValue("@Xtest", (object)t);
					val.Parameters.AddWithValue("@xbook", (object)v);
					((DbCommand)(object)val).ExecuteNonQuery();
					num3 = 7;
					continue;
				case 13:
					((DbConnection)(object)w).Close();
					((Control)h).Refresh();
					flag = num <= 0;
					num3 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num3 = 0;
						continue;
					}
					goto case 9;
				case 3:
				{
					if (!flag)
					{
						num3 = 4;
						continue;
					}
					val = new SqlCommand("sp_tComnentKarname_insertUpdate", w);
					((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
					val.Parameters.AddWithValue("@xStudent", (object)h.GetRow(num2).Cells["id"].Text.ToString());
					val.Parameters.AddWithValue("@Xtest", (object)t);
					val.Parameters.AddWithValue("@xbook", (object)v);
					val.Parameters.AddWithValue("@typ", (object)u);
					val.Parameters.AddWithValue("@comment", (object)text);
					int num4 = ((DbCommand)(object)val).ExecuteNonQuery();
					flag = num4 >= 1;
					num3 = 10;
					continue;
				}
				case 5:
				case 7:
					num2++;
					num3 = 6;
					continue;
				case 0:
					MessageBox.Show("تعداد " + num + " ردیف انجام شد");
					if (true)
					{
					}
					num3 = 9;
					continue;
				case 2:
					num3 = 8;
					continue;
				case 10:
					if (!flag)
					{
						num3 = 2;
						continue;
					}
					h.GetRow(num2).BeginEdit();
					h.GetRow(num2).Cells["acp"].Value = "1";
					h.GetRow(num2).EndEdit();
					num++;
					num3 = 14;
					continue;
				case 9:
					x = true;
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between I4 and Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		int num2 = default;
		while (true)
		{
			((Control)n).Text = ((Control)n).Text.Trim();
			bool flag = !(((Control)n).Text == "");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = 6 == (int)MessageBox.Show("آیا میخواهید متن برای همه وارد شود", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)0);
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						if (true)
						{
						}
						num2 = 0;
						num = 9;
					}
					else
					{
						num = 7;
					}
					continue;
				case 8:
					h.Row = 0;
					x = false;
					num = 2;
					continue;
				case 2:
					return;
				case 10:
					MessageBox.Show("متنی وارد نشده است");
					((Control)n).Focus();
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				case 9:
					flag = num2 < h.RowCount;
					num = 3;
					continue;
				case 3:
					if (flag)
					{
						h.GetRow(num2).BeginEdit();
						h.GetRow(num2).Cells["comment"].Value = ((Control)n).Text;
						h.GetRow(num2).Cells["acp"].Value = "0";
						h.GetRow(num2).Cells["comment"].Text = ((Control)n).Text;
						h.GetRow(num2).EndEdit();
						num2++;
						num = 0;
					}
					else
					{
						num = 8;
					}
					continue;
				case 7:
					num = 5;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, ColumnActionEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = !(A_1.Column.Key == "comment");
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
					return;
				case 2:
					h.GetRow(h.Row).BeginEdit();
					h.GetRow(h.Row).Cells["acp"].Value = "0";
					h.GetRow(h.Row).EndEdit();
					x = false;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between I4 and Unknown
		while (true)
		{
			bool flag = x;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 0:
					((CancelEventArgs)(object)A_1).Cancel = true;
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 3:
					flag = 6 == (int)MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", (MessageBoxButtons)4, (MessageBoxIcon)32, (MessageBoxDefaultButton)256);
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				}
				break;
			}
		}
	}
}
