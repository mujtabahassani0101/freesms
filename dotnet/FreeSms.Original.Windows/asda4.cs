using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;

public class asda4 : Form
{
	public string __field_a;

	private int m_b = 0;

	private int m_c = 0;

	private IContainer m_d = null;

	private Panel m_e;

	private Panel m_f;

	private UIButton g;

	private UIButton h;

	private UIButton i;

	private UIButton j;

	private OpenFileDialog k;

	private Panel l;

	private GridEX m;

	private Label n;

	private UIGroupBox o;

	private Panel p;

	private GridEXPrintDocument q;

	private UIButton r;

	private PrintPreviewDialog s;

	public asda4()
	{
		a();
	}

	private void f(object A_0, EventArgs A_1)
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
					if (true)
					{
					}
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_e.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 2:
					num = 3;
					continue;
				case 0:
				{
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xStudent", SqlDbType.Int, this.__field_a) };
					DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select code,fname,lname from tstudent where  id=@xStudent", a_);
					n.Text = dataTable2.Rows[0]["fname"].ToString() + " - " + dataTable2.Rows[0]["lname"].ToString();
					b();
					return;
				}
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
		this.m_c = this.m_b;
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT     tComnentStd.id, tComnentStd.xStudent, tComnentStd.xYear, tComnentStd.dayOfWeek, tComnentStd.subject, tComnentStd.Comment, tComnentStd.DateInsert, \r\n                      tuser.uid AS UserInsert\r\nFROM         tComnentStd LEFT OUTER JOIN\r\n                      tuser ON tComnentStd.xUserInsert = tuser.id\r\nWHERE   deleteDate is null and  tComnentStd.xStudent = " + this.__field_a);
		m.DataSource = dataSource;
	}

	private void e(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		asdbb asdbb2 = new asdbb();
		asdbb2.__field_a = this.__field_a;
		asdbb2.__field_c = "0";
		asdbb2.__field_b = asdaj.__field_a;
		asdbb2.ShowDialog();
		b();
	}

	private void d(object A_0, EventArgs A_1)
	{
		bool flag = default;
		while (true)
		{
			string text = "";
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 7:
					num2 = 1;
					goto IL_02b9;
				case 5:
					num = 1;
					continue;
				case 1:
					num2 = ((!(text != "")) ? 1 : 0);
					goto IL_02b9;
				case 0:
				{
					asdbb asdbb2 = new asdbb();
					asdbb2.__field_a = this.__field_a;
					asdbb2.__field_c = text;
					asdbb2.ShowDialog();
					b();
					num = 3;
					continue;
				}
				case 3:
					return;
				case 2:
					try
					{
						while (true)
						{
							IL_00f1:
							num = 9;
							while (true)
							{
								int num4;
								int num3;
								switch (num)
								{
								case 9:
									num = ((m.RowCount <= 0) ? 4 : 3);
									continue;
								case 1:
									num4 = 1;
									goto IL_027b;
								case 4:
									num3 = 1;
									goto IL_0207;
								case 5:
									MessageBox.Show("این یادداشت توسط کاربر دیگری ثبت شده و امکان اصلاح برای شما وجود ندارد", "خطای دسترسی");
									num = 7;
									continue;
								case 7:
									return;
								case 10:
									num = 13;
									continue;
								case 13:
									num = ((!(asdaj.l != "1")) ? 1 : 11);
									continue;
								case 3:
									num = 6;
									continue;
								case 6:
									num3 = ((m.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
									goto IL_0207;
								case 8:
									if (!flag)
									{
										num = 10;
										continue;
									}
									goto case 2;
								case 11:
									num = 12;
									continue;
								case 12:
									num4 = ((!(m.SelectedItems[0].GetRow().Cells["xUserInsert"].Value.ToString() != asdaj.l)) ? 1 : 0);
									goto IL_027b;
								case 0:
									if (flag)
									{
										text = m.SelectedItems[0].GetRow().Cells["id"].Value.ToString();
										num = 2;
									}
									else
									{
										num = 5;
									}
									continue;
								case 2:
									num = 14;
									continue;
								case 14:
									goto end_IL_00ac;
									IL_0207:
									flag = (byte)num3 != 0;
									num = 8;
									continue;
									IL_027b:
									flag = (byte)num4 != 0;
									num = 0;
									continue;
								}
								goto IL_00f1;
								continue;
								end_IL_00ac:
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
					num = 6;
					continue;
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 6:
					{
						num = ((this.__field_a != "") ? 5 : 7);
						continue;
					}
					IL_02b9:
					flag = (byte)num2 != 0;
					num = 4;
					continue;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, PaintEventArgs A_1)
	{
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default;
			while (true)
			{
				IL_005c:
				int num = 7;
				while (true)
				{
					int num3;
					int num2;
					switch (num)
					{
					case 0:
						goto end_IL_000b;
					case 7:
						num = ((m.RowCount <= 0) ? 11 : 5);
						continue;
					case 2:
						if (!flag)
						{
							num = 17;
							continue;
						}
						goto case 6;
					case 11:
						num3 = 1;
						goto IL_0120;
					case 8:
						MessageBox.Show("این یادداشت توسط کاربر دیگری ثبت شده و امکان حذف برای شما وجود ندارد", "خطای دسترسی");
						num = 13;
						continue;
					case 13:
						goto end_IL_000b;
					case 6:
						num = 12;
						continue;
					case 15:
						num2 = 1;
						goto IL_01d7;
					case 10:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 12;
					case 17:
						asdcb.d(asdab.e(), CommandType.Text, "update tComnentStd set deleteDate=N'" + asdab.d() + "-" + asdab.c() + "' where id=" + m.SelectedItems[0].GetRow().Cells["id"].Value.ToString());
						b();
						num = 6;
						continue;
					case 9:
						if (flag)
						{
							flag = MessageBox.Show("آيا از حذف مطمئن هستيد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes;
							num = 2;
						}
						else
						{
							num = 8;
						}
						continue;
					case 4:
						num = 3;
						continue;
					case 3:
						num = ((asdaj.l != "1") ? 16 : 15);
						continue;
					case 5:
						num = 1;
						continue;
					case 1:
						num3 = ((m.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_0120;
					case 16:
						num = 14;
						continue;
					case 14:
						num2 = ((!(m.SelectedItems[0].GetRow().Cells["xUserInsert"].Value.ToString() != asdaj.l)) ? 1 : 0);
						goto IL_01d7;
					case 12:
						{
							num = 0;
							continue;
						}
						IL_0120:
						flag = (byte)num3 != 0;
						num = 10;
						continue;
						IL_01d7:
						flag = (byte)num2 != 0;
						num = 9;
						continue;
					}
					goto IL_005c;
					continue;
					end_IL_000b:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			bool flag = A_1.KeyCode != Keys.F1;
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
					e(this, null);
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default;
			while (true)
			{
				IL_002e:
				int num = 3;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 3:
						num = ((m.RowCount > 0) ? 5 : 0);
						continue;
					case 5:
						num = 2;
						continue;
					case 2:
						num2 = ((m.SelectedItems[0].RowType != RowType.Record) ? 1 : 0);
						goto IL_0153;
					case 4:
					{
						Rectangle bounds = Bounds;
						q.PageHeaderCenter = "لیست یادداشت های " + n.Text;
						q.DefaultPageSettings.Landscape = true;
						q.DefaultPageSettings.Margins.Left = 20;
						q.DefaultPageSettings.Margins.Right = 20;
						s.SetDesktopBounds(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
						s.UseAntiAlias = true;
						s.ShowDialog(this);
						num = 6;
						continue;
					}
					case 0:
						num2 = 1;
						goto IL_0153;
					case 1:
						if (!flag)
						{
							num = 4;
							continue;
						}
						goto case 6;
					case 6:
						num = 7;
						continue;
					case 7:
						goto end_IL_0005;
						IL_0153:
						flag = (byte)num2 != 0;
						num = 1;
						continue;
					}
					goto IL_002e;
					continue;
					end_IL_0005:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}
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
					num = ((!A_0) ? 6 : 5);
					continue;
				case 5:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_d == null) ? 1 : 0);
					goto IL_0074;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 1;
				case 3:
					if (true)
					{
					}
					this.m_d.Dispose();
					num = 1;
					continue;
				case 6:
					num2 = 1;
					goto IL_0074;
				case 1:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 4;
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
		GridEXLayout gridEXLayout = new GridEXLayout();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda4));
		this.m_e = new Panel();
		p = new Panel();
		n = new Label();
		o = new UIGroupBox();
		m = new GridEX();
		this.m_f = new Panel();
		r = new UIButton();
		g = new UIButton();
		i = new UIButton();
		h = new UIButton();
		j = new UIButton();
		k = new OpenFileDialog();
		l = new Panel();
		q = new GridEXPrintDocument();
		s = new PrintPreviewDialog();
		this.m_e.SuspendLayout();
		p.SuspendLayout();
		((ISupportInitialize)o).BeginInit();
		o.SuspendLayout();
		((ISupportInitialize)m).BeginInit();
		this.m_f.SuspendLayout();
		l.SuspendLayout();
		SuspendLayout();
		this.m_e.BackColor = Color.FromArgb(214, 223, 247);
		this.m_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_e.Controls.Add(p);
		this.m_e.Controls.Add(o);
		this.m_e.Controls.Add(this.m_f);
		this.m_e.Font = new Font("Tahoma", 8.25f);
		this.m_e.Location = new Point(5, 5);
		this.m_e.Name = "panel1";
		this.m_e.Size = new Size(790, 639);
		this.m_e.TabIndex = 0;
		this.m_e.Paint += a;
		p.BackColor = SystemColors.HotTrack;
		p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		p.Controls.Add(n);
		p.Location = new Point(217, 8);
		p.Name = "panelStd";
		p.Size = new Size(365, 57);
		p.TabIndex = 133;
		n.BackColor = Color.FromArgb(0, 192, 192);
		n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		n.Font = new Font("B Nazanin", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		n.Location = new Point(2, 2);
		n.Name = "lName";
		n.RightToLeft = RightToLeft.Yes;
		n.Size = new Size(358, 50);
		n.TabIndex = 77;
		n.TextAlign = ContentAlignment.MiddleCenter;
		o.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		o.Controls.Add(m);
		o.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		o.Location = new Point(12, 71);
		o.Name = "GroupBoxPay";
		o.Size = new Size(763, 489);
		o.TabIndex = 2;
		o.Text = "لیست یادداشت های ثبت شده برای دانش آموز";
		m.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		m.DesignTimeLayout = gridEXLayout;
		m.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		m.Font = new Font("Tahoma", 8.25f);
		m.GroupByBoxVisible = false;
		m.Location = new Point(11, 31);
		m.Name = "gridEX1";
		m.RecordNavigator = true;
		m.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		m.SelectedFormatStyle.BackColor = Color.FromArgb(0, 0, 64);
		m.Size = new Size(744, 416);
		m.TabIndex = 18;
		m.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		this.m_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_f.Controls.Add(r);
		this.m_f.Controls.Add(g);
		this.m_f.Controls.Add(i);
		this.m_f.Controls.Add(h);
		this.m_f.Controls.Add(j);
		this.m_f.Font = new Font("B Nazanin", 12f);
		this.m_f.Location = new Point(15, 572);
		this.m_f.Name = "p_new";
		this.m_f.Size = new Size(760, 56);
		this.m_f.TabIndex = 1;
		r.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		r.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		r.Image = (Image)componentResourceManager.GetObject("btnPrint.Image");
		r.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		r.ImageSize = new Size(30, 30);
		r.Location = new Point(150, 3);
		r.Name = "btnPrint";
		r.Size = new Size(126, 46);
		r.TabIndex = 28;
		r.Text = "چاپ";
		r.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		r.Click += a;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		g.Image = (Image)componentResourceManager.GetObject("btnDelete.Image");
		g.Location = new Point(299, 3);
		g.Name = "btnDelete";
		g.Size = new Size(124, 46);
		g.TabIndex = 2;
		g.Text = "حذف";
		g.Click += b;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		i.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		i.ImageSize = new Size(20, 20);
		i.Location = new Point(3, 3);
		i.Name = "btnClose";
		i.Size = new Size(120, 46);
		i.TabIndex = 3;
		i.Text = "بستن";
		i.Click += c;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		h.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		h.Location = new Point(569, 4);
		h.Name = "btnNew";
		h.Size = new Size(183, 45);
		h.TabIndex = 0;
		h.Text = "ثبت یادداشت جدید(F1)";
		h.Click += e;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		j.Image = (Image)componentResourceManager.GetObject("btnEdit.Image");
		j.Location = new Point(444, 3);
		j.Name = "btnEdit";
		j.Size = new Size(119, 46);
		j.TabIndex = 1;
		j.Text = "اصلاح";
		j.Click += d;
		k.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
		k.Title = "انتخاب عکس شاگرد";
		l.BackColor = Color.Black;
		l.Controls.Add(this.m_e);
		l.Dock = DockStyle.Fill;
		l.Location = new Point(0, 0);
		l.Name = "panel2";
		l.Size = new Size(800, 650);
		l.TabIndex = 1;
		q.GridEX = m;
		s.AutoScrollMargin = new Size(0, 0);
		s.AutoScrollMinSize = new Size(0, 0);
		s.ClientSize = new Size(400, 300);
		s.Document = q;
		s.Enabled = true;
		s.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		s.Name = "printPreviewDialog1";
		s.Visible = false;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 650);
		Controls.Add(l);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmCommentAdd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "لیست پرداخت های شاگرد";
		Load += f;
		KeyUp += a;
		this.m_e.ResumeLayout(performLayout: false);
		p.ResumeLayout(performLayout: false);
		((ISupportInitialize)o).EndInit();
		o.ResumeLayout(performLayout: false);
		((ISupportInitialize)m).EndInit();
		this.m_f.ResumeLayout(performLayout: false);
		l.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
