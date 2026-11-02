using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

public class asdal : Form
{
	private IContainer m_a = null;

	private Button m_b;

	private Button m_c;

	private Button m_d;

	private Panel m_e;

	private Button m_f;

	private Panel m_g;

	private Button m_h;

	private Panel m_i;

	private NumericUpDown m_j;

	private NumericUpDown m_k;

	private NumericUpDown m_l;

	private NumericUpDown m_m;

	private Label m_n;

	private Label o;

	private Label p;

	private Label q;

	private GroupBox r;

	private Panel s;

	private Label t;

	private Label u;

	private ComboBox v;

	private ComboBox w;

	private ComboBox x;

	private ComboBox y;

	private GroupBox z;

	private GroupBox aa;

	private TextBox ab;

	private Button ac;

	private Label ad;

	private Label ae;

	private bool af;

	private bool ag;

	private string ah = "";

	private bool ai;

	private bool aj;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (A_0)
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
				case 1:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 6;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 6;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 6:
					{
						base.Dispose(A_0);
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

	private void f()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdal));
		this.m_b = new Button();
		this.m_c = new Button();
		this.m_d = new Button();
		this.m_e = new Panel();
		this.m_f = new Button();
		this.m_g = new Panel();
		this.m_i = new Panel();
		z = new GroupBox();
		ad = new Label();
		ae = new Label();
		w = new ComboBox();
		x = new ComboBox();
		y = new ComboBox();
		v = new ComboBox();
		aa = new GroupBox();
		ac = new Button();
		ab = new TextBox();
		u = new Label();
		t = new Label();
		r = new GroupBox();
		this.m_j = new NumericUpDown();
		q = new Label();
		this.m_m = new NumericUpDown();
		this.m_n = new Label();
		this.m_l = new NumericUpDown();
		o = new Label();
		this.m_k = new NumericUpDown();
		p = new Label();
		this.m_h = new Button();
		s = new Panel();
		this.m_g.SuspendLayout();
		this.m_i.SuspendLayout();
		z.SuspendLayout();
		aa.SuspendLayout();
		r.SuspendLayout();
		((ISupportInitialize)this.m_j).BeginInit();
		((ISupportInitialize)this.m_m).BeginInit();
		((ISupportInitialize)this.m_l).BeginInit();
		((ISupportInitialize)this.m_k).BeginInit();
		s.SuspendLayout();
		SuspendLayout();
		this.m_b.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_b.Location = new Point(7, 4);
		this.m_b.Name = "btnCreate";
		this.m_b.Size = new Size(89, 53);
		this.m_b.TabIndex = 0;
		this.m_b.Text = "پیش نمایش ";
		this.m_b.UseVisualStyleBackColor = true;
		this.m_b.Click += n;
		this.m_c.Location = new Point(3, 192);
		this.m_c.Name = "button2";
		this.m_c.Size = new Size(85, 23);
		this.m_c.TabIndex = 1;
		this.m_c.Text = "ویرایش گزارش";
		this.m_c.UseVisualStyleBackColor = true;
		this.m_c.Click += m;
		this.m_d.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_d.Location = new Point(7, 180);
		this.m_d.Name = "button3";
		this.m_d.Size = new Size(85, 23);
		this.m_d.TabIndex = 2;
		this.m_d.Text = "نمايش گزارش";
		this.m_d.UseVisualStyleBackColor = true;
		this.m_d.Visible = false;
		this.m_d.Click += l;
		this.m_e.AutoScroll = true;
		this.m_e.BackColor = Color.FromArgb(255, 224, 192);
		this.m_e.BorderStyle = BorderStyle.FixedSingle;
		this.m_e.Location = new Point(-1, 221);
		this.m_e.Name = "panel1";
		this.m_e.Size = new Size(799, 387);
		this.m_e.TabIndex = 17;
		this.m_f.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_f.Location = new Point(7, 63);
		this.m_f.Name = "btnAcp";
		this.m_f.Size = new Size(89, 55);
		this.m_f.TabIndex = 18;
		this.m_f.Text = "ثبت تغییرات";
		this.m_f.UseVisualStyleBackColor = true;
		this.m_f.Click += j;
		this.m_g.BackColor = SystemColors.GradientActiveCaption;
		this.m_g.BorderStyle = BorderStyle.FixedSingle;
		this.m_g.Controls.Add(this.m_i);
		this.m_g.Controls.Add(this.m_c);
		this.m_g.Controls.Add(this.m_h);
		this.m_g.Controls.Add(this.m_e);
		this.m_g.Controls.Add(this.m_b);
		this.m_g.Controls.Add(this.m_f);
		this.m_g.Controls.Add(this.m_d);
		this.m_g.Location = new Point(4, 4);
		this.m_g.Name = "panel2";
		this.m_g.Size = new Size(793, 632);
		this.m_g.TabIndex = 19;
		this.m_i.Controls.Add(z);
		this.m_i.Controls.Add(aa);
		this.m_i.Controls.Add(u);
		this.m_i.Controls.Add(t);
		this.m_i.Controls.Add(r);
		this.m_i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(102, 0);
		this.m_i.Name = "panel3";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(686, 215);
		this.m_i.TabIndex = 103;
		z.Controls.Add(ad);
		z.Controls.Add(ae);
		z.Controls.Add(w);
		z.Controls.Add(x);
		z.Controls.Add(y);
		z.Controls.Add(v);
		z.Location = new Point(6, 4);
		z.Name = "groupBox2";
		z.Size = new Size(200, 167);
		z.TabIndex = 14;
		z.TabStop = false;
		z.Text = "انتخاب شاگردان برای چاپ";
		ad.BorderStyle = BorderStyle.FixedSingle;
		ad.Location = new Point(57, 22);
		ad.Name = "lYear";
		ad.Size = new Size(55, 24);
		ad.TabIndex = 118;
		ae.AutoSize = true;
		ae.Location = new Point(118, 26);
		ae.Name = "label7";
		ae.Size = new Size(66, 13);
		ae.TabIndex = 117;
		ae.Text = "سال تعلیمی";
		w.DropDownStyle = ComboBoxStyle.DropDownList;
		w.FormattingEnabled = true;
		w.Location = new Point(6, 134);
		w.Name = "dropStd";
		w.Size = new Size(189, 21);
		w.TabIndex = 3;
		w.Visible = false;
		x.DropDownStyle = ComboBoxStyle.DropDownList;
		x.FormattingEnabled = true;
		x.Location = new Point(6, 106);
		x.Name = "dropClass";
		x.Size = new Size(189, 21);
		x.TabIndex = 2;
		x.Visible = false;
		x.SelectedIndexChanged += a;
		y.DropDownStyle = ComboBoxStyle.DropDownList;
		y.FormattingEnabled = true;
		y.Location = new Point(5, 78);
		y.Name = "dropHoze_Paye";
		y.Size = new Size(189, 21);
		y.TabIndex = 1;
		y.SelectedIndexChanged += b;
		v.DropDownStyle = ComboBoxStyle.DropDownList;
		v.FormattingEnabled = true;
		v.Location = new Point(5, 50);
		v.Name = "dropTypeSelect";
		v.Size = new Size(189, 21);
		v.TabIndex = 0;
		v.SelectedIndexChanged += c;
		aa.Controls.Add(ac);
		aa.Controls.Add(ab);
		aa.Location = new Point(210, 2);
		aa.Name = "groupBox4";
		aa.Size = new Size(244, 102);
		aa.TabIndex = 13;
		aa.TabStop = false;
		aa.Text = "محتوای آیتم انتخابی";
		ac.Location = new Point(13, 52);
		ac.Name = "btnAcpCaption";
		ac.Size = new Size(225, 32);
		ac.TabIndex = 15;
		ac.Text = "ثبت محتوا";
		ac.UseVisualStyleBackColor = true;
		ac.Click += d;
		ab.Location = new Point(13, 22);
		ab.Name = "txtCaption";
		ab.Size = new Size(225, 21);
		ab.TabIndex = 15;
		u.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, 178);
		u.Location = new Point(3, 180);
		u.Name = "label6";
		u.Size = new Size(664, 30);
		u.TabIndex = 11;
		u.Text = componentResourceManager.GetString("label6.Text");
		t.AutoSize = true;
		t.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.Location = new Point(334, 148);
		t.Name = "label5";
		t.Size = new Size(330, 23);
		t.TabIndex = 10;
		t.Text = "نحوه قرارگیری محتویات قابل چاپ در برگه";
		r.Controls.Add(this.m_j);
		r.Controls.Add(q);
		r.Controls.Add(this.m_m);
		r.Controls.Add(this.m_n);
		r.Controls.Add(this.m_l);
		r.Controls.Add(o);
		r.Controls.Add(this.m_k);
		r.Controls.Add(p);
		r.Location = new Point(460, 0);
		r.Name = "groupBox1";
		r.Size = new Size(207, 138);
		r.TabIndex = 8;
		r.TabStop = false;
		r.Text = "تنظیمات آیتم انتخاب شده";
		this.m_j.Location = new Point(34, 20);
		this.m_j.Maximum = new decimal(new int[4] { 1500, 0, 0, 0 });
		this.m_j.Name = "txtTop";
		this.m_j.Size = new Size(69, 21);
		this.m_j.TabIndex = 0;
		this.m_j.ValueChanged += h;
		q.AutoSize = true;
		q.Location = new Point(110, 86);
		q.Name = "label4";
		q.Size = new Size(60, 13);
		q.TabIndex = 7;
		q.Text = "اندازه طولی";
		this.m_m.Location = new Point(34, 52);
		this.m_m.Maximum = new decimal(new int[4] { 750, 0, 0, 0 });
		this.m_m.Name = "txtleft";
		this.m_m.Size = new Size(69, 21);
		this.m_m.TabIndex = 1;
		this.m_m.ValueChanged += g;
		this.m_n.AutoSize = true;
		this.m_n.Location = new Point(110, 113);
		this.m_n.Name = "label3";
		this.m_n.Size = new Size(33, 13);
		this.m_n.TabIndex = 6;
		this.m_n.Text = "ارتفاع";
		this.m_l.Location = new Point(34, 111);
		this.m_l.Maximum = new decimal(new int[4] { 500, 0, 0, 0 });
		this.m_l.Minimum = new decimal(new int[4] { 20, 0, 0, 0 });
		this.m_l.Name = "txtH";
		this.m_l.Size = new Size(69, 21);
		this.m_l.TabIndex = 2;
		this.m_l.Value = new decimal(new int[4] { 20, 0, 0, 0 });
		this.m_l.ValueChanged += f;
		o.AutoSize = true;
		o.Location = new Point(109, 54);
		o.Name = "label2";
		o.Size = new Size(64, 13);
		o.TabIndex = 5;
		o.Text = "فاصله از چپ";
		this.m_k.Location = new Point(34, 84);
		this.m_k.Maximum = new decimal(new int[4] { 750, 0, 0, 0 });
		this.m_k.Minimum = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_k.Name = "txtW";
		this.m_k.Size = new Size(69, 21);
		this.m_k.TabIndex = 3;
		this.m_k.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_k.ValueChanged += e;
		p.AutoSize = true;
		p.Location = new Point(110, 24);
		p.Name = "label1";
		p.Size = new Size(60, 13);
		p.TabIndex = 4;
		p.Text = "فاصله از بالا";
		this.m_h.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		this.m_h.Location = new Point(7, 124);
		this.m_h.Name = "button1";
		this.m_h.Size = new Size(89, 50);
		this.m_h.TabIndex = 89;
		this.m_h.Text = "خروج";
		this.m_h.UseVisualStyleBackColor = true;
		this.m_h.Click += i;
		s.BackColor = SystemColors.ControlText;
		s.Controls.Add(this.m_g);
		s.Dock = DockStyle.Fill;
		s.Location = new Point(0, 0);
		s.Name = "panel4";
		s.Size = new Size(801, 640);
		s.TabIndex = 20;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.InactiveCaptionText;
		ClientSize = new Size(801, 640);
		Controls.Add(s);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmsarbarg";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "سربرگ";
		Load += k;
		this.m_g.ResumeLayout(performLayout: false);
		this.m_i.ResumeLayout(performLayout: false);
		this.m_i.PerformLayout();
		z.ResumeLayout(performLayout: false);
		z.PerformLayout();
		aa.ResumeLayout(performLayout: false);
		aa.PerformLayout();
		r.ResumeLayout(performLayout: false);
		r.PerformLayout();
		((ISupportInitialize)this.m_j).EndInit();
		((ISupportInitialize)this.m_m).EndInit();
		((ISupportInitialize)this.m_l).EndInit();
		((ISupportInitialize)this.m_k).EndInit();
		s.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	public asdal()
	{
		f();
	}

	private void n(object A_0, EventArgs A_1)
	{
		l(this, null);
	}

	private void m(object A_0, EventArgs A_1)
	{
		while (true)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Report|*.rpx";
			bool flag = openFileDialog.ShowDialog() != DialogResult.OK;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
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
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string value = "0";
			string value2 = "0";
			string value3 = "0";
			bool flag = v.SelectedIndex != 0;
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
					value3 = "2";
					flag = y.SelectedIndex < 0;
					num = 12;
					continue;
				case 4:
					flag = !(y.SelectedValue.ToString() == "0");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 7;
						continue;
					}
					value = "5";
					value2 = y.SelectedValue.ToString();
					num = 10;
					continue;
				case 26:
					num = 15;
					continue;
				case 36:
					return;
				case 1:
				case 10:
					num = 30;
					continue;
				case 17:
					value = "0";
					value2 = "0";
					num = 16;
					continue;
				case 12:
					if (!flag)
					{
						num = 4;
						continue;
					}
					MessageBox.Show("حوزه ای انتخاب نشده است");
					num = 20;
					continue;
				case 11:
				case 28:
				{
					SqlConnection sqlConnection = new SqlConnection(asdab.e());
					sqlConnection.Open();
					DataSet dataSet = new DataSet();
					SqlCommand sqlCommand = new SqlCommand("sp_SelectStdForSarbarg", sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.Parameters.AddWithValue("@type", value);
					sqlCommand.Parameters.AddWithValue("@code", value2);
					sqlCommand.Parameters.AddWithValue("@sort", value3);
					sqlCommand.Parameters.AddWithValue("@xYear", ad.Text);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(dataSet, "v_data");
					sqlConnection.Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 21;
					continue;
				}
				case 21:
					if (!flag)
					{
						num = 32;
						continue;
					}
					return;
				case 8:
					num = 26;
					continue;
				case 22:
					flag = x.SelectedIndex < 0;
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 23;
						continue;
					}
					MessageBox.Show("صنفی ای انتخاب نشده است");
					num = 29;
					continue;
				case 20:
					return;
				case 32:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 6;
					continue;
				case 6:
					return;
				case 3:
					flag = !(w.SelectedValue.ToString() != "0");
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 33;
				case 2:
					value3 = "1";
					flag = y.SelectedIndex < 0;
					num = 27;
					continue;
				case 27:
					if (flag)
					{
						MessageBox.Show("پایه ای انتخاب نشده است");
						num = 36;
					}
					else
					{
						num = 5;
					}
					continue;
				case 16:
				case 19:
					num = 22;
					continue;
				case 9:
					value = "2";
					value2 = x.SelectedValue.ToString();
					flag = w.SelectedIndex < 0;
					num = 31;
					continue;
				case 31:
					if (!flag)
					{
						num = 3;
						continue;
					}
					MessageBox.Show("شاگردی انتخاب نشده است");
					num = 25;
					continue;
				case 7:
					value = "4";
					value2 = "0";
					num = 1;
					continue;
				case 33:
					num = 8;
					continue;
				case 34:
					value = "3";
					value2 = w.SelectedValue.ToString();
					num = 33;
					continue;
				case 29:
					return;
				case 23:
					flag = !(x.SelectedValue.ToString() != "0");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						if (true)
						{
						}
						num = 9;
						continue;
					}
					goto case 26;
				case 5:
					flag = !(y.SelectedValue.ToString() == "0");
					num = 35;
					continue;
				case 35:
					if (flag)
					{
						value = "1";
						value2 = y.SelectedValue.ToString();
						num = 19;
					}
					else
					{
						num = 17;
					}
					continue;
				case 30:
					num = 28;
					continue;
				case 25:
					return;
				case 15:
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 2:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_g.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 3:
					if (true)
					{
					}
					num = 2;
					continue;
				case 0:
				{
					ad.Text = asdaj.__field_a;
					af = false;
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					dictionary.Add("1", "انتخاب بر اساس پایه و صنف");
					dictionary.Add("2", "انتخاب بر اساس حوزه امتحانی");
					v.DataSource = new BindingSource(dictionary, null);
					v.DisplayMember = "Value";
					v.ValueMember = "Key";
					af = true;
					e();
					c();
					return;
				}
				}
				break;
			}
		}
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				case 0:
					ab.Enabled = true;
					ac.Enabled = true;
					num2 = 3;
					continue;
				case 3:
					if (1 == 0)
					{
					}
					return;
				case 2:
				{
					Label label = (Label)A_0;
					ag = false;
					ah = label.Parent.Name;
					asdan asdan3 = (asdan)this.m_e.Controls[ah];
					this.m_j.Value = asdan3.Top;
					this.m_m.Value = asdan3.Left;
					this.m_l.Value = asdan3.Height;
					this.m_k.Value = asdan3.Width;
					ag = true;
					asdan3.BackColor = Color.FromName("LightSkyBlue");
					ab.Text = label.Text;
					flag = !(asdan3.e == "l");
					num2 = 1;
					continue;
				}
				case 1:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					ab.Enabled = false;
					ac.Enabled = false;
					num2 = 5;
					continue;
				case 5:
					return;
				case 4:
				case 6:
					flag = num < this.m_e.Controls.Count;
					num2 = 7;
					continue;
				case 7:
					if (flag)
					{
						asdan asdan2 = (asdan)this.m_e.Controls[num];
						asdan2.BackColor = Color.Empty;
						num++;
						num2 = 4;
					}
					else
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void e()
	{
		int num2 = default;
		Font a_ = default;
		float emSize = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tListField");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 4:
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					num2 = 0;
					num = 7;
					continue;
				case 2:
				case 7:
					flag = num2 < dataTable.Rows.Count;
					num = 3;
					continue;
				case 3:
					if (flag)
					{
						a_ = new Font("Tahoma", 10f);
						num = 5;
					}
					else
					{
						num = 4;
					}
					continue;
				case 5:
				{
					try
					{
						while (true)
						{
							IL_0302:
							string familyName = Convert.ToString(dataTable.Rows[num2]["fFontName"]);
							bool flag2 = false;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 5:
									a_ = new Font(familyName, emSize, FontStyle.Bold);
									num = 4;
									continue;
								case 2:
									try
									{
										flag2 = bool.Parse(dataTable.Rows[num2]["fFontBold"].ToString());
									}
									catch
									{
									}
									emSize = 10f;
									num = 6;
									continue;
								case 6:
									try
									{
										emSize = float.Parse(dataTable.Rows[num2]["fFontSize"].ToString());
									}
									catch
									{
									}
									flag = !flag2;
									num = 1;
									continue;
								case 1:
									if (flag)
									{
										a_ = new Font(familyName, emSize);
										num = 0;
									}
									else
									{
										num = 5;
									}
									continue;
								case 0:
								case 4:
									num = 3;
									continue;
								case 3:
									goto end_IL_02dd;
								}
								goto IL_0302;
								continue;
								end_IL_02dd:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					if (true)
					{
					}
					asdan asdan2 = new asdan();
					asdan2.Name = dataTable.Rows[num2]["fFieldName"].ToString();
					asdan2.e = dataTable.Rows[num2]["fType"].ToString();
					Label label = (Label)asdan2.Controls[2];
					label.MouseDown += a;
					asdan2.a(a_);
					asdan2.a(dataTable.Rows[num2]["fFieldCaption"].ToString());
					asdan2.a(bool.Parse(dataTable.Rows[num2]["show"].ToString()));
					asdan2.Height = int.Parse(dataTable.Rows[num2]["fHeight"].ToString());
					asdan2.Width = int.Parse(dataTable.Rows[num2]["fWidth"].ToString());
					label.Height = int.Parse(dataTable.Rows[num2]["fHeight"].ToString());
					label.Width = int.Parse(dataTable.Rows[num2]["fWidth"].ToString());
					asdan2.Top = int.Parse(dataTable.Rows[num2]["fTop"].ToString());
					asdan2.Left = int.Parse(dataTable.Rows[num2]["fLeft"].ToString());
					this.m_e.Controls.Add(asdan2);
					num2++;
					num = 2;
					continue;
				}
				}
				break;
			}
		}
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < this.m_e.Controls.Count;
					num2 = 2;
					continue;
				case 2:
				{
					if (!flag)
					{
						if (true)
						{
						}
						num2 = 1;
						continue;
					}
					asdan asdan2 = (asdan)this.m_e.Controls[num];
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tListField SET  fFieldCaption=N'" + asdan2.c() + "', fTop = " + asdan2.Top + ", fLeft =  " + asdan2.Left + ", fHeight = " + asdan2.Height + ", fWidth =  " + asdan2.Width + ", fFontName = N'" + asdan2.d().Name + "', fFontSize =" + asdan2.d().Size + ", fFontBold =" + asdan2.d().Bold.ToString().Replace("True", "1").Replace("False", "0") + ", show = " + asdan2.b().ToString().Replace("True", "1")
						.Replace("False", "0") + " WHERE     (fFieldName = N'" + asdan2.Name + "')");
					num++;
					num2 = 3;
					continue;
				}
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		d();
		MessageBox.Show("تغییرات اعمال شد");
	}

	private void i(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void h(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ah != "");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
					}
					else
					{
						MessageBox.Show("موردی انتخاب نشده است");
						num = 4;
					}
					continue;
				case 2:
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				{
					asdan asdan2 = (asdan)this.m_e.Controls[ah];
					asdan2.Top = int.Parse(this.m_j.Value.ToString());
					num = 2;
					continue;
				}
				case 5:
					flag = !ag;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 4:
					return;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ah != "");
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
					MessageBox.Show("موردی انتخاب نشده است");
					num = 2;
					continue;
				case 0:
					num = 6;
					continue;
				case 6:
					return;
				case 1:
					flag = !ag;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 3:
				{
					if (true)
					{
					}
					asdan asdan2 = (asdan)this.m_e.Controls[ah];
					asdan2.Left = int.Parse(this.m_m.Value.ToString());
					num = 0;
					continue;
				}
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ah != "");
			int num = 1;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					MessageBox.Show("موردی انتخاب نشده است");
					num = 6;
					continue;
				case 5:
					num = 0;
					continue;
				case 0:
					return;
				case 3:
				{
					asdan asdan2 = (asdan)this.m_e.Controls[ah];
					asdan2.Height = int.Parse(this.m_l.Value.ToString());
					num = 5;
					continue;
				}
				case 2:
					flag = !ag;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 5;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ah != "");
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
					MessageBox.Show("موردی انتخاب نشده است");
					num = 3;
					continue;
				case 0:
					if (true)
					{
					}
					flag = !ag;
					num = 6;
					continue;
				case 4:
					num = 2;
					continue;
				case 2:
					return;
				case 1:
				{
					asdan asdan2 = (asdan)this.m_e.Controls[ah];
					asdan2.Width = int.Parse(this.m_k.Value.ToString());
					num = 4;
					continue;
				}
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(ah != "");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						MessageBox.Show("موردی انتخاب نشده است");
						num = 3;
					}
					continue;
				case 0:
					return;
				case 5:
					MessageBox.Show("محتوایی وارد نشده است");
					ab.Focus();
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					flag = !(ab.Text == "");
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						ab.Text = asdaj.b(ab.Text);
						asdan asdan2 = (asdan)this.m_e.Controls[ah];
						asdan2.a(ab.Text);
						num = 0;
					}
					else
					{
						num = 5;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c()
	{
		string a_ = default;
		Dictionary<string, string> dictionary = default;
		int num2 = default;
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !af;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 20;
						continue;
					}
					return;
				case 7:
					y.DataSource = null;
					num = 10;
					continue;
				case 18:
					a_ = "select id,name from tPaye order by id";
					dictionary.Add("0", "تمام پایه ها");
					x.Visible = true;
					num = 21;
					continue;
				case 5:
				case 10:
					ai = true;
					flag = v.SelectedIndex != 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 22;
				case 14:
					if (true)
					{
					}
					a_ = "";
					num = 15;
					continue;
				case 11:
					flag = dictionary.Count != 0;
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 7;
						continue;
					}
					y.DataSource = new BindingSource(dictionary, null);
					y.DisplayMember = "Value";
					y.ValueMember = "Key";
					num = 5;
					continue;
				case 22:
					num = 0;
					continue;
				case 0:
					return;
				case 19:
					num2 = 0;
					num = 17;
					continue;
				case 15:
					flag = v.SelectedIndex != 0;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 18;
						continue;
					}
					a_ = "select id,name from thozeh order by id";
					dictionary.Add("0", "تمام حوزه ها");
					x.Visible = false;
					w.Visible = false;
					num = 2;
					continue;
				case 9:
					b();
					num = 22;
					continue;
				case 2:
				case 21:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count >= 1;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 19;
				case 20:
					ai = false;
					dictionary = new Dictionary<string, string>();
					a_ = "";
					flag = v.SelectedIndex <= 0;
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 15;
				case 6:
					dictionary.Clear();
					num = 19;
					continue;
				case 12:
				case 17:
					flag = num2 < dataTable.Rows.Count;
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						num = 12;
					}
					else
					{
						num = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		Dictionary<string, string> dictionary = default;
		string text = default;
		int num2 = default;
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !ai;
			int num = 15;
			while (true)
			{
				switch (num)
				{
				case 15:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 10:
					flag = dictionary.Count != 0;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					x.DataSource = new BindingSource(dictionary, null);
					x.DisplayMember = "Value";
					x.ValueMember = "Key";
					num = 2;
					continue;
				case 14:
					text = text + " and xpaye=" + y.SelectedValue.ToString();
					num = 4;
					continue;
				case 11:
					aj = false;
					text = " where xYear=" + ad.Text;
					flag = !(y.SelectedValue.ToString() != "0");
					if (true)
					{
					}
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 4;
				case 3:
					x.DataSource = null;
					num = 16;
					continue;
				case 2:
				case 16:
					aj = true;
					num = 0;
					continue;
				case 0:
					return;
				case 13:
					num2 = 0;
					num = 7;
					continue;
				case 4:
				{
					string a_ = "select id,name from tClass " + text + " order by id";
					dictionary = new Dictionary<string, string>();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count <= 1;
					num = 1;
					continue;
				}
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 13;
				case 7:
				case 9:
					flag = num2 < dataTable.Rows.Count;
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						num = 9;
					}
					else
					{
						num = 10;
					}
					continue;
				case 5:
					dictionary.Add("0", "تمام صنف ها");
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		Dictionary<string, string> dictionary = default;
		bool flag = default;
		int num2 = default;
		DataTable dataTable = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 1;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 1:
					num = ((!aj) ? 5 : 3);
					continue;
				case 3:
					num = 7;
					continue;
				case 7:
					num3 = ((x.SelectedIndex < 0) ? 1 : 0);
					goto IL_01f0;
				case 6:
					dictionary.Add("0", "تمام شاگردان صنف");
					num = 11;
					continue;
				case 10:
					w.Visible = false;
					w.DataSource = null;
					num = 8;
					continue;
				case 8:
					return;
				case 12:
					w.DataSource = null;
					MessageBox.Show("شاگردی در این صنف وجود ندارد");
					num = 18;
					continue;
				case 13:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 11;
				case 0:
					if (!flag)
					{
						num = 20;
						continue;
					}
					return;
				case 5:
					num3 = 1;
					goto IL_01f0;
				case 2:
				case 18:
					num = 4;
					continue;
				case 4:
					return;
				case 11:
					num2 = 0;
					num = 19;
					continue;
				case 20:
					flag = !(x.SelectedValue.ToString() == "0");
					num = 14;
					continue;
				case 14:
					if (flag)
					{
						w.Visible = true;
						string a_ = "select tStudent.id,tStudent.fname + N' - '+ tStudent.lname as name  from tstudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent where tYear_Student.xclass= " + x.SelectedValue.ToString() + " order by tYear_Student.sort,tStudent.fname,tStudent.lname,tStudent.id";
						dictionary = new Dictionary<string, string>();
						dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
						flag = dataTable.Rows.Count <= 1;
						num = 13;
					}
					else
					{
						num = 10;
					}
					continue;
				case 17:
					flag = dictionary.Count != 0;
					num = 9;
					continue;
				case 9:
					if (flag)
					{
						w.DataSource = new BindingSource(dictionary, null);
						w.DisplayMember = "Value";
						w.ValueMember = "Key";
						num = 2;
					}
					else
					{
						num = 12;
					}
					continue;
				case 15:
				case 19:
					flag = num2 < dataTable.Rows.Count;
					num = 16;
					continue;
				case 16:
					{
						if (flag)
						{
							dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
							num2++;
							num = 15;
						}
						else
						{
							num = 17;
						}
						continue;
					}
					IL_01f0:
					flag = (byte)num3 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = v.SelectedIndex != 0;
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
					b();
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

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = v.SelectedIndex != 0;
			if (true)
			{
			}
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
					a();
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}
}
