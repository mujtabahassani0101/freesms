using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdv : Form
{
	private readonly OriginalWorkbookImport workbookImport;
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private GridEX m_d;

	private Button m_e;

	private Button f;

	private OpenFileDialog g;

	private Label h;

	private TextBox i;

	private Label j;

	private UIComboBox k;

	private Label l;

	private NumericEditBox m;

	private NumericEditBox n;

	private Label o;

	private Label p;

	private Label q;

	private SqlConnection r = new SqlConnection(asdab.e());

	private string s = "";
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
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				case 6:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 4:
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
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdv));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		l = new Label();
		m = new NumericEditBox();
		n = new NumericEditBox();
		o = new Label();
		j = new Label();
		k = new UIComboBox();
		h = new Label();
		i = new TextBox();
		f = new Button();
		this.m_e = new Button();
		this.m_c = new UIButton();
		this.m_d = new GridEX();
		g = new OpenFileDialog();
		p = new Label();
		q = new Label();
		this.m_b.SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(p);
		this.m_b.Controls.Add(q);
		this.m_b.Controls.Add(l);
		this.m_b.Controls.Add(m);
		this.m_b.Controls.Add(n);
		this.m_b.Controls.Add(o);
		this.m_b.Controls.Add(j);
		this.m_b.Controls.Add(k);
		this.m_b.Controls.Add(h);
		this.m_b.Controls.Add(i);
		this.m_b.Controls.Add(f);
		this.m_b.Controls.Add(this.m_e);
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Controls.Add(this.m_d);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("Tahoma", 8.25f);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(798, 598);
		this.m_b.TabIndex = 0;
		l.AutoSize = true;
		l.Location = new Point(306, 571);
		l.Name = "label4";
		l.Size = new Size(20, 13);
		l.TabIndex = 47;
		l.Text = "تا :";
		m.AutoScroll = false;
		m.AutoScrollMargin = new Size(0, 0);
		m.AutoScrollMinSize = new Size(0, 0);
		m.AutoScrollPosition = new Point(0, 0);
		m.Enabled = false;
		m.Location = new Point(248, 568);
		m.Name = "txtMaxMark";
		m.Size = new Size(52, 21);
		m.TabIndex = 46;
		m.Text = "100";
		m.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		m.Value = (short)100;
		m.ValueType = NumericEditValueType.Int16;
		n.AutoScroll = false;
		n.AutoScrollMargin = new Size(0, 0);
		n.AutoScrollMinSize = new Size(0, 0);
		n.AutoScrollPosition = new Point(0, 0);
		n.Enabled = false;
		n.Location = new Point(248, 541);
		n.Name = "txtMinMark";
		n.Size = new Size(52, 21);
		n.TabIndex = 45;
		n.Text = "0";
		n.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		n.Value = (short)0;
		n.ValueType = NumericEditValueType.Int16;
		o.AutoSize = true;
		o.Location = new Point(306, 542);
		o.Name = "label3";
		o.Size = new Size(62, 13);
		o.TabIndex = 44;
		o.Text = "رنج نمره از :";
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.AutoSize = true;
		j.Location = new Point(720, 547);
		j.Name = "label2";
		j.Size = new Size(26, 13);
		j.TabIndex = 43;
		j.Text = "دوره";
		k.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		k.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		k.DropListFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		k.Location = new Point(513, 543);
		k.Name = "dropExam";
		k.Size = new Size(201, 23);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		k.StringFormat = stringFormat;
		k.TabIndex = 42;
		k.SelectedIndexChanged += a;
		h.AutoSize = true;
		h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		h.ForeColor = Color.Red;
		h.Location = new Point(171, 45);
		h.Name = "label1";
		h.Size = new Size(279, 16);
		h.TabIndex = 41;
		h.Text = "نمونه فایل اکسل در مسیر زیر موجود میباشد";
		i.Location = new Point(12, 67);
		i.Name = "txtExam";
		i.ReadOnly = true;
		i.RightToLeft = RightToLeft.No;
		i.Size = new Size(440, 21);
		i.TabIndex = 40;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		f.Location = new Point(573, 48);
		f.Name = "BtnNew";
		f.Size = new Size(197, 35);
		f.TabIndex = 19;
		f.Text = "انتخاب فایل اکسل";
		f.UseVisualStyleBackColor = true;
		f.Click += d;
		this.m_e.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_e.Location = new Point(405, 541);
		this.m_e.Name = "btnAcp";
		this.m_e.Size = new Size(102, 27);
		this.m_e.TabIndex = 18;
		this.m_e.Text = "ثبت";
		this.m_e.UseVisualStyleBackColor = true;
		this.m_e.Click += c;
		this.m_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(40, 40);
		this.m_c.Location = new Point(11, 533);
		this.m_c.Name = "btnClose";
		this.m_c.Size = new Size(189, 35);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "بستن";
		this.m_c.Click += e;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_d.DesignTimeLayout = gridEXLayout;
		this.m_d.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		this.m_d.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		this.m_d.Font = new Font("Tahoma", 8.25f);
		this.m_d.GroupByBoxVisible = false;
		this.m_d.Location = new Point(8, 99);
		this.m_d.Name = "gridEX1";
		this.m_d.RecordNavigator = true;
		this.m_d.RowHeaders = InheritableBoolean.True;
		this.m_d.SelectedFormatStyle.BackColor = Color.Empty;
		this.m_d.SelectedFormatStyle.ForeColor = Color.Empty;
		this.m_d.Size = new Size(780, 385);
		this.m_d.TabIndex = 5;
		this.m_d.VisualStyle = VisualStyle.Office2003;
		g.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
		p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		p.Location = new Point(646, 505);
		p.Name = "lYear";
		p.Size = new Size(68, 24);
		p.TabIndex = 120;
		q.AutoSize = true;
		q.Location = new Point(720, 508);
		q.Name = "label6";
		q.Size = new Size(66, 13);
		q.TabIndex = 119;
		q.Text = "سال تعلیمی";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(798, 598);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmImportMark";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره از فایل اکسل";
		Load += b;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdv()
	{
		b();
		workbookImport = new OriginalWorkbookImport(this);
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private async void d(object A_0, EventArgs A_1)
	{
		await workbookImport.OpenAsync(g, this.m_d, FreeSms.Core.WorkbookImportKind.Marks);
	}

	private void a()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where term in(0,1,2) and xYear=" + p.Text + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			k.DataSource = dataSource;
			k.DisplayMember = "Name";
			k.ValueMember = "id";
			bool flag = k.Items.Count <= 0;
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
					k.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		SqlCommand sqlCommand = default;
		int num13 = default;
		int num8 = default;
		int num2 = default;
		string value = default;
		string text = default;
		string text2 = default;
		float num5 = default;
		float num6 = default;
		int num7 = default;
		int num3 = default;
		int num4 = default;
		while (true)
		{
			bool flag = k.SelectedIndex > 0;
			int num = 20;
			while (true)
			{
				int num9;
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 25;
						continue;
					}
					sqlCommand = null;
					num = 31;
					continue;
				case 10:
				case 35:
					num = 36;
					continue;
				case 2:
					flag = MessageBox.Show("آيا از انتقال نمرات به  " + k.SelectedItem.Text + " مطمئن هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 8;
						continue;
					}
					return;
				case 30:
					flag = r.State == ConnectionState.Open;
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 3;
				case 17:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = num13 >= 1;
					num = 22;
					continue;
				case 33:
					num = 13;
					continue;
				case 13:
					num9 = ((!(s == "2")) ? 1 : 0);
					goto IL_05a9;
				case 16:
					r.Open();
					num = 3;
					continue;
				case 4:
					r.Open();
					num = 23;
					continue;
				case 22:
					if (!flag)
					{
						num = 24;
						continue;
					}
					num8++;
					num = 10;
					continue;
				case 37:
					num = 0;
					continue;
				case 24:
					num = 35;
					continue;
				case 3:
					sqlCommand = new SqlCommand("UPDATE tExam SET procc = 0 WHERE term=3 and xYear=" + p.Text, r);
					sqlCommand.ExecuteNonQuery();
					num = 2;
					continue;
				case 29:
					num = (flag ? 27 : 7);
					continue;
				case 9:
					this.m_d.GetRow(num2).BeginEdit();
					this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
					this.m_d.GetRow(num2).Cells["status"].Value = "کد درس خالی است";
					this.m_d.GetRow(num2).EndEdit();
					num = 34;
					continue;
				case 21:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 2;
				case 42:
					if (flag)
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "1";
						this.m_d.GetRow(num2).Cells["status"].Value = "";
						this.m_d.GetRow(num2).EndEdit();
						sqlCommand = new SqlCommand("sp_tMark_insertUpdate_FromXls_Af", r);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.Add("@err", SqlDbType.NVarChar, 100);
						sqlCommand.Parameters.AddWithValue("@xuser", asdaj.l);
						sqlCommand.Parameters.AddWithValue("@code", text);
						sqlCommand.Parameters.AddWithValue("@Xtest", k.SelectedValue.ToString());
						sqlCommand.Parameters.AddWithValue("@xYear", p.Text);
						sqlCommand.Parameters.AddWithValue("@codedars", text2);
						sqlCommand.Parameters.AddWithValue("@mark", value);
						sqlCommand.Parameters[0].Direction = ParameterDirection.Output;
						num13 = sqlCommand.ExecuteNonQuery();
						flag = !(sqlCommand.Parameters[0].Value.ToString() != "");
						num = 17;
					}
					else
					{
						num = 37;
					}
					continue;
				case 38:
					try
					{
						int num12 = int.Parse(text2);
					}
					catch
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_d.GetRow(num2).Cells["status"].Value = "کد درس اشتباه است";
						this.m_d.GetRow(num2).EndEdit();
						goto case 0;
					}
					num = 14;
					continue;
				case 7:
					this.m_d.GetRow(num2).BeginEdit();
					this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
					this.m_d.GetRow(num2).Cells["status"].Value = "کد متعلم خالی است";
					this.m_d.GetRow(num2).EndEdit();
					num = 18;
					continue;
				case 27:
					try
					{
						long num11 = long.Parse(text);
					}
					catch
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_d.GetRow(num2).Cells["status"].Value = "کد متعلم اشتباه است";
						this.m_d.GetRow(num2).EndEdit();
						goto case 0;
					}
					flag = !(text2 == "");
					num = 11;
					continue;
				case 1:
				case 15:
					flag = num2 < this.m_d.RowCount;
					if (true)
					{
					}
					num = 26;
					continue;
				case 26:
					if (flag)
					{
						text = "";
						text2 = "";
						string text3 = "";
						value = "";
						num5 = 0f;
						num6 = 0f;
						num5 = 0f;
						num6 = 0f;
						num7 = 0;
						text = asdaj.b(this.m_d.GetRow(num2).Cells["code"].Value.ToString());
						text2 = asdaj.b(this.m_d.GetRow(num2).Cells["codedars"].Value.ToString());
						flag = !(text == "");
						num = 29;
					}
					else
					{
						num = 6;
					}
					continue;
				case 23:
					sqlCommand = new SqlCommand("UPDATE tExam SET procc = 0 WHERE  (id = " + k.SelectedValue.ToString() + ")", r);
					sqlCommand.ExecuteNonQuery();
					num2 = 0;
					num = 15;
					continue;
				case 14:
					try
					{
						while (true)
						{
							IL_0890:
							flag = !(this.m_d.GetRow(num2).Cells["mark"].Text != "");
							num = 6;
							while (true)
							{
								int num10;
								switch (num)
								{
								case 8:
									goto end_IL_0857;
								case 6:
									if (!flag)
									{
										num = 10;
										continue;
									}
									value = null;
									num = 1;
									continue;
								case 4:
									num = 7;
									continue;
								case 7:
									num10 = ((!(num5 < (float)num3)) ? 1 : 0);
									goto IL_08ff;
								case 5:
									if (!flag)
									{
										num = 2;
										continue;
									}
									value = num5.ToString();
									num6 += num5;
									num7++;
									num = 9;
									continue;
								case 2:
									this.m_d.GetRow(num2).BeginEdit();
									this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
									this.m_d.GetRow(num2).Cells["status"].Value = "نمره خارج از محدوده است";
									this.m_d.GetRow(num2).EndEdit();
									num = 11;
									continue;
								case 11:
									goto end_IL_0855;
								case 0:
									num10 = 0;
									goto IL_08ff;
								case 10:
									num5 = float.Parse(this.m_d.GetRow(num2).Cells["mark"].Text.ToString());
									num = 3;
									continue;
								case 3:
									num = ((!(num5 > (float)num4)) ? 4 : 0);
									continue;
								case 1:
								case 9:
									{
										num = 8;
										continue;
									}
									IL_08ff:
									flag = (byte)num10 != 0;
									num = 5;
									continue;
								}
								goto IL_0890;
								continue;
								end_IL_0857:
								break;
							}
							break;
						}
						goto IL_05d3;
						end_IL_0855:;
					}
					catch
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_d.GetRow(num2).Cells["status"].Value = "نمره اشتباه است";
						this.m_d.GetRow(num2).EndEdit();
					}
					goto case 0;
				case 0:
				case 18:
				case 19:
				case 34:
				case 36:
					num2++;
					num = 1;
					continue;
				case 11:
					num = ((!flag) ? 9 : 38);
					continue;
				case 31:
					num = ((s == "1") ? 40 : 33);
					continue;
				case 25:
					MessageBox.Show("دوره را انتخاب کنید");
					k.Focus();
					num = 32;
					continue;
				case 32:
					return;
				case 40:
					num9 = 0;
					goto IL_05a9;
				case 8:
				{
					num3 = int.Parse(n.Text);
					num4 = int.Parse(m.Text);
					text = "";
					text2 = "";
					string text3 = "";
					value = "";
					num5 = 0f;
					num6 = 0f;
					num7 = 0;
					num8 = 0;
					flag = r.State == ConnectionState.Open;
					num = 28;
					continue;
				}
				case 28:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 23;
				case 5:
					this.m_d.GetRow(num2).BeginEdit();
					this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
					this.m_d.GetRow(num2).Cells["status"].Value = sqlCommand.Parameters[0].Value.ToString();
					this.m_d.GetRow(num2).EndEdit();
					num = 19;
					continue;
				case 6:
					r.Close();
					this.m_d.Refetch();
					MessageBox.Show("انجام شد");
					num = 12;
					continue;
				case 12:
					return;
					IL_05d3:
					flag = num7 != 0;
					num = 42;
					continue;
					IL_05a9:
					flag = (byte)num9 != 0;
					num = 21;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
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
					if (true)
					{
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 1:
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
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 2:
					p.Text = asdaj.__field_a;
					i.Text = Application.StartupPath + "\\xls\\ExampleMark.xls";
					a();
					num = 7;
					continue;
				case 7:
					return;
				case 3:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 0;
					continue;
				case 0:
					return;
				case 5:
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = k.SelectedIndex <= 0;
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 2;
				case 3:
					m.Text = "60";
					num = 6;
					continue;
				case 5:
					m.Text = "40";
					num = 2;
					continue;
				case 2:
				case 6:
				case 11:
					num = 10;
					continue;
				case 10:
					return;
				case 0:
					if (true)
					{
					}
					s = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + k.SelectedValue.ToString()).ToString();
					flag = !(s == "1");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(s == "2");
					num = 4;
					continue;
				case 7:
					m.Text = "100";
					num = 11;
					continue;
				case 4:
					if (flag)
					{
						flag = !(s == "0");
						num = 1;
					}
					else
					{
						num = 3;
					}
					continue;
				}
				break;
			}
		}
	}
}
