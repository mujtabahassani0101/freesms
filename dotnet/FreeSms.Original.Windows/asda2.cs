using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
protected override void Dispose(bool A_0)
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
						base.Dispose(A_0);
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
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda2));
		GridEXLayout gridEXLayout = new GridEXLayout();
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
		this.m_b.SuspendLayout();
		m.SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_d.SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(m);
		this.m_b.Controls.Add(l);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(h);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(800, 600);
		this.m_b.TabIndex = 0;
		q.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		q.ForeColor = Color.DarkViolet;
		q.Location = new Point(279, 3);
		q.Name = "lheder";
		q.Size = new Size(288, 24);
		q.TabIndex = 44;
		q.Text = "ورود توضیحات زیر اطلاع نامه";
		q.TextAlign = ContentAlignment.MiddleCenter;
		m.Controls.Add(n);
		m.Controls.Add(o);
		m.Controls.Add(p);
		m.Location = new Point(8, 89);
		m.Name = "groupBox1";
		m.Size = new Size(779, 52);
		m.TabIndex = 42;
		m.TabStop = false;
		m.Text = "وارد متن یکسان";
		n.Location = new Point(85, 23);
		n.Name = "txtmarkAll";
		n.Size = new Size(638, 21);
		n.TabIndex = 43;
		o.AutoSize = true;
		o.Location = new Point(729, 26);
		o.Name = "label6";
		o.Size = new Size(32, 13);
		o.TabIndex = 42;
		o.Text = "متن :";
		p.Location = new Point(6, 20);
		p.Name = "btnMarkAll";
		p.Size = new Size(71, 24);
		p.TabIndex = 41;
		p.Text = "ثبت";
		p.UseVisualStyleBackColor = true;
		p.Click += a;
		l.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		l.Location = new Point(593, 552);
		l.Name = "btnSaveMark";
		l.Size = new Size(197, 35);
		l.TabIndex = 18;
		l.Text = "ثبت توضیحات";
		l.UseVisualStyleBackColor = true;
		l.Click += b;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(g);
		this.m_d.Controls.Add(f);
		this.m_d.Controls.Add(e);
		this.m_d.Location = new Point(11, 24);
		this.m_d.Name = "uiGroupBox1";
		this.m_d.Size = new Size(776, 62);
		this.m_d.TabIndex = 17;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		j.Location = new Point(19, 26);
		j.Name = "lExam";
		j.Size = new Size(183, 23);
		j.TabIndex = 33;
		j.TextAlign = ContentAlignment.MiddleCenter;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Location = new Point(277, 26);
		k.Name = "lClass";
		k.Size = new Size(183, 23);
		k.TabIndex = 32;
		k.TextAlign = ContentAlignment.MiddleCenter;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		i.Location = new Point(541, 26);
		i.Name = "lPaye";
		i.Size = new Size(183, 23);
		i.TabIndex = 30;
		i.TextAlign = ContentAlignment.MiddleCenter;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.AutoSize = true;
		g.Location = new Point(208, 31);
		g.Name = "ltextExam";
		g.Size = new Size(33, 13);
		g.TabIndex = 29;
		g.Text = "دوره :";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.AutoSize = true;
		f.Location = new Point(466, 30);
		f.Name = "label19";
		f.Size = new Size(37, 13);
		f.TabIndex = 25;
		f.Text = "صنف :";
		e.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		e.AutoSize = true;
		e.Location = new Point(726, 30);
		e.Name = "label20";
		e.Size = new Size(29, 13);
		e.TabIndex = 15;
		e.Text = "پایه :";
		e.TextAlign = ContentAlignment.MiddleLeft;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(40, 40);
		this.m_c.Location = new Point(11, 552);
		this.m_c.Name = "btnClose";
		this.m_c.Size = new Size(189, 35);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "بستن";
		this.m_c.Click += c;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		h.DesignTimeLayout = gridEXLayout;
		h.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		h.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		h.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h.GroupByBoxVisible = false;
		h.Location = new Point(8, 147);
		h.Name = "gridEX1";
		h.RecordNavigator = true;
		h.RowHeaders = InheritableBoolean.True;
		h.SelectedFormatStyle.BackColor = Color.Empty;
		h.SelectedFormatStyle.ForeColor = Color.Empty;
		h.Size = new Size(782, 398);
		h.TabIndex = 5;
		h.VisualStyle = VisualStyle.Office2003;
		h.CellValueChanged += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmCommentKoll";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += d;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		m.ResumeLayout(performLayout: false);
		m.PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)h).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asda2()
	{
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
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
					q.Text = "ورود توضیحات زیر اطلاع نامه";
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
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
					j.Visible = false;
					g.Visible = false;
					q.Text = "ورود توضیحات جدول نتایج";
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
						this.m_b.BackColor = Color.FromArgb(red, green, blue);
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
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(h.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
					gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					h.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(h.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
					gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					h.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					return;
				}
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			SqlCommand sqlCommand = null;
			SqlConnection sqlConnection = new SqlConnection(asdab.e());
			w.Open();
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
					sqlCommand = new SqlCommand("DELETE FROM tComnentKarname WHERE (xStudent = @xStudent) And typ=5 AND (Xtest = @Xtest) AND (xbook = @xbook)", w);
					sqlCommand.Parameters.AddWithValue("@xStudent", h.GetRow(num2).Cells["id"].Text.ToString());
					sqlCommand.Parameters.AddWithValue("@Xtest", t);
					sqlCommand.Parameters.AddWithValue("@xbook", v);
					sqlCommand.ExecuteNonQuery();
					num3 = 7;
					continue;
				case 13:
					w.Close();
					h.Refresh();
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
					sqlCommand = new SqlCommand("sp_tComnentKarname_insertUpdate", w);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@xStudent", h.GetRow(num2).Cells["id"].Text.ToString());
					sqlCommand.Parameters.AddWithValue("@Xtest", t);
					sqlCommand.Parameters.AddWithValue("@xbook", v);
					sqlCommand.Parameters.AddWithValue("@typ", u);
					sqlCommand.Parameters.AddWithValue("@comment", text);
					int num4 = sqlCommand.ExecuteNonQuery();
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
		int num2 = default;
		while (true)
		{
			n.Text = n.Text.Trim();
			bool flag = !(n.Text == "");
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
					flag = DialogResult.Yes == MessageBox.Show("آیا میخواهید متن برای همه وارد شود", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
					n.Focus();
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
						h.GetRow(num2).Cells["comment"].Value = n.Text;
						h.GetRow(num2).Cells["acp"].Value = "0";
						h.GetRow(num2).Cells["comment"].Text = n.Text;
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
					A_1.Cancel = true;
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				case 3:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
