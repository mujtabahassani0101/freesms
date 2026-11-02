using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdbb : Form
{
	public string __field_a;

	public string __field_b;

	public string __field_c;

	private bool m_d = false;

	private IContainer m_e = null;

	private Panel m_f;

	private OpenFileDialog m_g;

	private Panel m_h;

	private Label m_i;

	private Panel j;

	private Panel k;

	private TextBox l;

	private Label m;

	private UIButton n;

	private UIButton o;

	private Label p;

	private MaskedEditBox q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private Label v;

	private TextBox w;

	private Label x;

	public asdbb()
	{
		a();
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 6;
				case 10:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xStudent", SqlDbType.Int, this.__field_a) };
					DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select code,fname,lname from tstudent where  id=@xStudent", a_);
					this.m_i.Text = dataTable2.Rows[0]["fname"].ToString() + " - " + dataTable2.Rows[0]["lname"].ToString();
					s.Text = dataTable2.Rows[0]["code"].ToString();
					flag = !(this.__field_c != "0");
					num = 5;
					continue;
				}
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 3;
						continue;
					}
					r.Text = "یادداشت جدید";
					num = 0;
					continue;
				case 6:
					flag = !(this.__field_c == "0");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 10;
				case 1:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_f.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 3:
					r.Text = "اصلاح یادداشت";
					b();
					num = 4;
					continue;
				case 9:
					num = 1;
					continue;
				case 8:
					q.Text = asdab.b();
					num = 10;
					continue;
				case 0:
				case 4:
					w.Focus();
					return;
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
		SqlParameter[] a_ = new SqlParameter[2]
		{
			asdcb.a("@id", SqlDbType.Int, this.__field_c),
			asdcb.a("@xStudent", SqlDbType.Int, this.__field_a)
		};
		DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * FROM tComnentStd where xStudent=@xStudent and id=@id", a_);
		q.Text = dataTable.Rows[0]["DateInsert"].ToString();
		w.Text = dataTable.Rows[0]["Subject"].ToString();
		l.Text = dataTable.Rows[0]["comment"].ToString();
	}

	private void h(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			asdaj.k = q.Text;
			string text = "";
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 13:
					text = "چهارشنبه";
					num = 4;
					continue;
				case 22:
					if (!flag)
					{
						num = 16;
						continue;
					}
					flag = !(text == "Wednesday");
					num = 25;
					continue;
				case 15:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(text == "Saturday");
					num = 29;
					continue;
				case 23:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 2;
				case 17:
					if (flag)
					{
						flag = !(l.Text == "");
						num = 15;
					}
					else
					{
						num = 27;
					}
					continue;
				case 25:
					if (!flag)
					{
						num = 13;
						continue;
					}
					flag = !(text == "Thursday");
					num = 8;
					continue;
				case 2:
				case 4:
				case 6:
				case 7:
				case 19:
				case 24:
				{
					SqlParameter[] a_ = new SqlParameter[9]
					{
						asdcb.a("@id", SqlDbType.Int, this.__field_c),
						asdcb.a("@xYear", SqlDbType.Int, this.__field_b),
						asdcb.a("@xStudent", SqlDbType.Int, this.__field_a),
						asdcb.a("@dayOfWeek", SqlDbType.NVarChar, text),
						asdcb.a("@subject", SqlDbType.NVarChar, w.Text.Trim()),
						asdcb.a("@comment", SqlDbType.NVarChar, l.Text.Trim()),
						asdcb.a("@Date", SqlDbType.NVarChar, asdab.b()),
						asdcb.a("@Time", SqlDbType.NVarChar, asdab.c()),
						asdcb.a("@xUser", SqlDbType.Int, asdaj.l)
					};
					int num2 = asdcb.d(asdab.e(), CommandType.StoredProcedure, "sp_tComnentStd_insertUpdate", a_);
					flag = num2 <= 0;
					num = 30;
					continue;
				}
				case 30:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 11:
					if (flag)
					{
						flag = !(text == "Tuesday");
						num = 22;
					}
					else
					{
						num = 10;
					}
					continue;
				case 5:
					MessageBox.Show("توضیحات یادداشت را وارد کنید");
					l.Focus();
					num = 28;
					continue;
				case 28:
					return;
				case 9:
					text = "جمعه";
					num = 24;
					continue;
				case 3:
					asdaj.i = true;
					MessageBox.Show("ثبت شد");
					Close();
					num = 26;
					continue;
				case 26:
					return;
				case 12:
					if (flag)
					{
						flag = !(text == "Monday");
						num = 11;
					}
					else
					{
						num = 14;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_044a:
							DateTime date = ShamsiDate.ShamsiToGregory(q.Text);
							string shamsiDate = ShamsiDate.GetShamsiDate(date);
							flag = !(shamsiDate != q.Text);
							num = 3;
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
									text = date.DayOfWeek.ToString();
									num = 0;
									continue;
								case 1:
									MessageBox.Show("تاریخ یادداشت اشتباه است");
									q.Focus();
									num = 2;
									continue;
								case 2:
									return;
								case 0:
									goto end_IL_0431;
								}
								goto IL_044a;
								continue;
								end_IL_0431:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("تاریخ یادداشت اشتباه است");
						q.Focus();
						return;
					}
					w.Text = asdaj.b(w.Text);
					l.Text = asdaj.b(l.Text);
					flag = !(w.Text == "");
					num = 17;
					continue;
				case 27:
					MessageBox.Show("موضوع یادداشت را وارد کنید");
					w.Focus();
					num = 21;
					continue;
				case 21:
					return;
				case 29:
					if (flag)
					{
						flag = !(text == "Sunday");
						num = 12;
					}
					else
					{
						num = 20;
					}
					continue;
				case 20:
					text = "شنبه";
					num = 19;
					continue;
				case 0:
					text = "پنج شنبه";
					num = 18;
					continue;
				case 18:
					if (1 == 0)
					{
					}
					goto case 2;
				case 8:
					if (flag)
					{
						flag = !(text == "Friday");
						num = 23;
					}
					else
					{
						num = 0;
					}
					continue;
				case 14:
					text = "یکشنبه";
					num = 7;
					continue;
				case 10:
					text = "دوشنبه";
					num = 2;
					continue;
				case 16:
					text = "سه شنبه";
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
					num = ((A_1.KeyCode != Keys.F3) ? 6 : 8);
					continue;
				case 8:
					num = 7;
					continue;
				case 7:
					num2 = ((!j.Visible) ? 1 : 0);
					goto IL_007f;
				case 6:
					num2 = 1;
					goto IL_007f;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = A_1.KeyCode != Keys.Escape;
					if (true)
					{
					}
					num = 9;
					continue;
				case 5:
					h(this, null);
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					g(this, null);
					num = 4;
					continue;
				case 4:
					return;
				case 9:
					{
						if (!flag)
						{
							num = 1;
							continue;
						}
						return;
					}
					IL_007f:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.Return;
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
					if (true)
					{
					}
					SendKeys.Send("{tab}");
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void e(object A_0, EventArgs A_1)
	{
		MaskedEditBox maskedEditBox = (MaskedEditBox)A_0;
		maskedEditBox.BackColor = Color.FromName("Window");
	}

	private void d(object A_0, EventArgs A_1)
	{
		l.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void c(object A_0, EventArgs A_1)
	{
		l.BackColor = Color.FromName("Window");
	}

	private void b(object A_0, EventArgs A_1)
	{
		w.BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		w.BackColor = Color.FromName("Window");
	}
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (A_0)
					{
						if (true)
						{
						}
						num = 0;
					}
					else
					{
						num = 1;
					}
					continue;
				case 0:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_e == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_e.Dispose();
					num = 3;
					continue;
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 3;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 3:
					{
						base.Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbb));
		this.m_f = new Panel();
		v = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		this.m_i = new Label();
		j = new Panel();
		k = new Panel();
		w = new TextBox();
		x = new Label();
		p = new Label();
		q = new MaskedEditBox();
		l = new TextBox();
		m = new Label();
		this.m_g = new OpenFileDialog();
		this.m_h = new Panel();
		n = new UIButton();
		o = new UIButton();
		this.m_f.SuspendLayout();
		j.SuspendLayout();
		k.SuspendLayout();
		this.m_h.SuspendLayout();
		SuspendLayout();
		this.m_f.BackColor = Color.FromArgb(214, 223, 247);
		this.m_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_f.Controls.Add(v);
		this.m_f.Controls.Add(r);
		this.m_f.Controls.Add(s);
		this.m_f.Controls.Add(t);
		this.m_f.Controls.Add(u);
		this.m_f.Controls.Add(this.m_i);
		this.m_f.Controls.Add(j);
		this.m_f.Font = new Font("Tahoma", 8.25f);
		this.m_f.Location = new Point(5, 5);
		this.m_f.Name = "panel1";
		this.m_f.Size = new Size(601, 450);
		this.m_f.TabIndex = 0;
		v.AutoSize = true;
		v.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		v.Location = new Point(123, 88);
		v.Name = "label19";
		v.Size = new Size(81, 17);
		v.TabIndex = 114;
		v.Text = "نوع عملیات :";
		r.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.ForeColor = Color.Fuchsia;
		r.Location = new Point(6, 87);
		r.Name = "lTypecomand";
		r.Size = new Size(111, 18);
		r.TabIndex = 113;
		s.BackColor = Color.FromArgb(0, 192, 192);
		s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		s.Font = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		s.Location = new Point(349, 76);
		s.Name = "lCode";
		s.RightToLeft = RightToLeft.Yes;
		s.Size = new Size(173, 37);
		s.TabIndex = 112;
		s.TextAlign = ContentAlignment.MiddleCenter;
		t.AutoSize = true;
		t.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		t.Location = new Point(528, 87);
		t.Name = "label5";
		t.Size = new Size(61, 17);
		t.TabIndex = 111;
		t.Text = "کد متعلم";
		u.AutoSize = true;
		u.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
		u.Location = new Point(528, 26);
		u.Name = "label4";
		u.Size = new Size(51, 17);
		u.TabIndex = 110;
		u.Text = "نام -ولد";
		this.m_i.BackColor = Color.FromArgb(0, 192, 192);
		this.m_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_i.Font = new Font("B Nazanin", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		this.m_i.Location = new Point(10, 3);
		this.m_i.Name = "lName";
		this.m_i.RightToLeft = RightToLeft.Yes;
		this.m_i.Size = new Size(512, 61);
		this.m_i.TabIndex = 77;
		this.m_i.TextAlign = ContentAlignment.MiddleCenter;
		j.BackColor = Color.Gray;
		j.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		j.Controls.Add(k);
		j.Font = new Font("B Nazanin", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		j.Location = new Point(7, 125);
		j.Name = "pStd";
		j.Size = new Size(588, 317);
		j.TabIndex = 79;
		k.BackColor = Color.FromArgb(214, 223, 247);
		k.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		k.Controls.Add(w);
		k.Controls.Add(x);
		k.Controls.Add(p);
		k.Controls.Add(q);
		k.Controls.Add(l);
		k.Controls.Add(m);
		k.Controls.Add(n);
		k.Controls.Add(o);
		k.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		k.Location = new Point(2, 3);
		k.Name = "panel3";
		k.Size = new Size(580, 307);
		k.TabIndex = 40;
		w.Font = new Font("Tahoma", 9.75f);
		w.Location = new Point(19, 38);
		w.Name = "txtSubject";
		w.Size = new Size(446, 23);
		w.TabIndex = 1;
		w.KeyDown += a;
		w.Leave += a;
		w.Enter += b;
		x.AutoSize = true;
		x.Location = new Point(469, 41);
		x.Name = "label1";
		x.Size = new Size(106, 16);
		x.TabIndex = 110;
		x.Text = "موضوع یادداشت :";
		p.AutoSize = true;
		p.Font = new Font("Tahoma", 9.75f);
		p.Location = new Point(469, 9);
		p.Name = "label12";
		p.Size = new Size(95, 16);
		p.TabIndex = 109;
		p.Text = "تاریخ یادداشت :";
		q.AutoScroll = false;
		q.AutoScrollMargin = new Size(0, 0);
		q.AutoScrollMinSize = new Size(0, 0);
		q.AutoScrollPosition = new Point(0, 0);
		q.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Enabled = false;
		q.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		q.Location = new Point(378, 7);
		q.Mask = "0000/00/00";
		q.MaxLength = 12;
		q.Name = "txtDateInsert";
		q.Numeric = true;
		q.RightToLeft = RightToLeft.No;
		q.Size = new Size(86, 22);
		q.TabIndex = 0;
		q.Tag = "";
		q.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		q.Leave += e;
		q.Enter += f;
		q.KeyDown += a;
		l.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.Location = new Point(19, 68);
		l.Multiline = true;
		l.Name = "txtComment";
		l.Size = new Size(446, 147);
		l.TabIndex = 2;
		l.Leave += c;
		l.Enter += d;
		m.AutoSize = true;
		m.Location = new Point(469, 75);
		m.Name = "label2";
		m.Size = new Size(66, 16);
		m.TabIndex = 42;
		m.Text = "توضیحات :";
		this.m_g.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		this.m_g.Title = "انتخاب عکس شاگرد";
		this.m_h.BackColor = Color.Black;
		this.m_h.Controls.Add(this.m_f);
		this.m_h.Dock = DockStyle.Fill;
		this.m_h.Location = new Point(0, 0);
		this.m_h.Name = "panel2";
		this.m_h.Size = new Size(611, 461);
		this.m_h.TabIndex = 1;
		n.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		n.Location = new Point(19, 259);
		n.Name = "btnCancel";
		n.Size = new Size(110, 39);
		n.TabIndex = 16;
		n.Text = "انصراف(Esc)";
		n.Click += g;
		o.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		o.Location = new Point(147, 259);
		o.Name = "btnAcp";
		o.Size = new Size(110, 39);
		o.TabIndex = 15;
		o.Text = "ثبت(F3)";
		o.Click += h;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(611, 461);
		Controls.Add(this.m_h);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmCommentInsertUpdate";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = "لیست پرداخت های شاگرد";
		Load += i;
		KeyUp += b;
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		j.ResumeLayout(performLayout: false);
		k.ResumeLayout(performLayout: false);
		k.PerformLayout();
		this.m_h.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
