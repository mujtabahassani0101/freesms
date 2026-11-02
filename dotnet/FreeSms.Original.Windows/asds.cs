using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asds : Form
{
	private ImageList m_a;

	private Panel m_b;

	private GridEXPrintDocument m_c;

	private PrintPreviewDialog d;

	private Label e;

	private UIButton f;

	private EditBox g;

	private EditBox h;

	private UIButton i;

	private GridEX j;

	private GridEX k;

	private Label l;

	private Label m;

	private IContainer n;

	public string o;

	public asds()
	{
		a();
	}
protected override void Dispose(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 3;
				case 0:
					num = 3;
					continue;
				case 2:
					n.Dispose();
					num = 0;
					continue;
				case 5:
					flag = n == null;
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 0;
				case 3:
					base.Dispose(A_0);
					return;
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
		n = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asds));
		GridEXLayout gridEXLayout = new GridEXLayout();
		GridEXLayout gridEXLayout2 = new GridEXLayout();
		this.m_a = new ImageList(n);
		this.m_b = new Panel();
		m = new Label();
		l = new Label();
		j = new GridEX();
		k = new GridEX();
		i = new UIButton();
		e = new Label();
		f = new UIButton();
		this.m_c = new GridEXPrintDocument();
		d = new PrintPreviewDialog();
		g = new EditBox();
		h = new EditBox();
		this.m_b.SuspendLayout();
		((ISupportInitialize)j).BeginInit();
		((ISupportInitialize)k).BeginInit();
		SuspendLayout();
		this.m_a.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("icons.ImageStream");
		this.m_a.TransparentColor = Color.Magenta;
		this.m_a.Images.SetKeyName(0, "");
		this.m_a.Images.SetKeyName(1, "");
		this.m_a.Images.SetKeyName(2, "");
		this.m_a.Images.SetKeyName(3, "");
		this.m_a.Images.SetKeyName(4, "");
		this.m_a.Images.SetKeyName(5, "");
		this.m_a.Images.SetKeyName(6, "");
		this.m_a.Images.SetKeyName(7, "");
		this.m_a.Images.SetKeyName(8, "");
		this.m_a.Images.SetKeyName(9, "");
		this.m_b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.m_b.Controls.Add(m);
		this.m_b.Controls.Add(l);
		this.m_b.Controls.Add(j);
		this.m_b.Controls.Add(k);
		this.m_b.Controls.Add(i);
		this.m_b.Controls.Add(e);
		this.m_b.Controls.Add(f);
		this.m_b.Location = new Point(6, 6);
		this.m_b.Name = "panel2";
		this.m_b.RightToLeft = RightToLeft.Yes;
		this.m_b.Size = new Size(636, 640);
		this.m_b.TabIndex = 21;
		m.AutoSize = true;
		m.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Location = new Point(457, 52);
		m.Name = "label1";
		m.Size = new Size(95, 40);
		m.TabIndex = 111;
		m.Text = "نام کاربر :";
		l.AutoSize = true;
		l.Font = new Font("B Nazanin", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.ForeColor = Color.DarkViolet;
		l.Location = new Point(236, 1);
		l.Name = "label2";
		l.Size = new Size(186, 40);
		l.TabIndex = 110;
		l.Text = "سطح دسترسی کاربر";
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout5.LayoutString");
		j.DesignTimeLayout = gridEXLayout;
		j.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		j.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold);
		j.GroupByBoxVisible = false;
		j.Location = new Point(15, 123);
		j.Name = "gForm";
		j.RowFormatStyle.ForeColor = Color.FromArgb(0, 0, 64);
		j.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		j.Size = new Size(307, 436);
		j.TabIndex = 109;
		j.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gridEXLayout2.LayoutString = componentResourceManager.GetString("gridEXLayout6.LayoutString");
		k.DesignTimeLayout = gridEXLayout2;
		k.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		k.Font = new Font("B Nazanin", 9.75f, FontStyle.Bold);
		k.GroupByBoxVisible = false;
		k.Location = new Point(347, 123);
		k.Name = "gPaye";
		k.RowFormatStyle.ForeColor = Color.FromArgb(64, 0, 64);
		k.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		k.Size = new Size(274, 436);
		k.TabIndex = 108;
		k.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		i.BackColor = Color.FromArgb(214, 223, 247);
		i.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		i.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		i.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		i.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		i.ImageIndex = 8;
		i.ImageSize = new Size(40, 40);
		i.Location = new Point(4, 7);
		i.Name = "uiButton2";
		i.Size = new Size(91, 34);
		i.TabIndex = 65;
		i.Text = "خروج";
		i.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		i.Click += a;
		e.BackColor = Color.FromArgb(255, 192, 192);
		e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		e.Font = new Font("B Nazanin", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
		e.ForeColor = Color.FromArgb(0, 64, 0);
		e.Location = new Point(177, 44);
		e.Name = "lname";
		e.Size = new Size(275, 55);
		e.TabIndex = 29;
		e.Text = "محمد احمدی";
		e.TextAlign = ContentAlignment.MiddleCenter;
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		f.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		f.Font = new Font("B Nazanin", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
		f.Image = (Image)componentResourceManager.GetObject("btnAccept.Image");
		f.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		f.ImageIndex = 8;
		f.ImageSize = new Size(30, 30);
		f.Location = new Point(244, 569);
		f.Name = "btnAccept";
		f.Size = new Size(171, 49);
		f.TabIndex = 9;
		f.Text = "تائيد";
		f.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		f.Click += c;
		this.m_c.PageFooterLeft = "3";
		this.m_c.PageFooterRight = "2";
		this.m_c.PageHeaderCenter = "1";
		this.m_c.PageHeaderLeft = "4";
		this.m_c.PageHeaderRight = "5";
		d.AutoScrollMargin = new Size(0, 0);
		d.AutoScrollMinSize = new Size(0, 0);
		d.ClientSize = new Size(400, 300);
		d.Document = this.m_c;
		d.Enabled = true;
		d.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
		d.Name = "printPreviewDialog1";
		d.Visible = false;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.AutoScroll = false;
		g.AutoScrollMargin = new Size(0, 0);
		g.AutoScrollMinSize = new Size(0, 0);
		g.AutoScrollPosition = new Point(0, 0);
		g.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		g.Location = new Point(24, 9);
		g.Name = "txtUid";
		g.RightToLeft = RightToLeft.Yes;
		g.Size = new Size(136, 21);
		g.TabIndex = 2;
		g.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		g.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.AutoScroll = false;
		h.AutoScrollMargin = new Size(0, 0);
		h.AutoScrollMinSize = new Size(0, 0);
		h.AutoScrollPosition = new Point(0, 0);
		h.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		h.Location = new Point(24, 47);
		h.Name = "txtPwd";
		h.PasswordChar = '*';
		h.RightToLeft = RightToLeft.Yes;
		h.Size = new Size(136, 21);
		h.TabIndex = 3;
		h.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		h.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		AutoScaleBaseSize = new Size(5, 13);
		BackColor = SystemColors.InactiveCaption;
		ClientSize = new Size(651, 655);
		ControlBox = false;
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		Name = "frmUserPermission";
		RightToLeft = RightToLeft.Yes;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "اطلاعات اساتيد";
		Load += b;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_b.PerformLayout();
		((ISupportInitialize)j).EndInit();
		((ISupportInitialize)k).EndInit();
		ResumeLayout(performLayout: false);
	}

	private void c(object A_0, EventArgs A_1)
	{
		string text2 = default;
		bool flag = default;
		while (true)
		{
			string text = "";
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num++;
					num2 = 16;
					continue;
				case 15:
					text2 = "";
					num = 0;
					num2 = 17;
					continue;
				case 7:
					num++;
					num2 = 10;
					continue;
				case 4:
					flag = !(text2 != "");
					num2 = 18;
					continue;
				case 18:
					if (!flag)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 13:
					text = text + "," + k.GetRow(num).Cells["id"].Value.ToString();
					num2 = 7;
					continue;
				case 9:
					text2 = text2 + "," + j.GetRow(num).Cells["id"].Value.ToString();
					num2 = 3;
					continue;
				case 6:
					text2 = asdab.d(o + "kbr63" + text2 + ",");
					num2 = 2;
					continue;
				case 14:
					text = asdab.d(o + "kbr63" + text + ",");
					num2 = 15;
					continue;
				case 5:
				case 10:
					flag = num < k.RowCount;
					num2 = 12;
					continue;
				case 12:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					if (true)
					{
					}
					flag = !(k.GetRow(num).Cells["acp"].Value.ToString() == "True");
					num2 = 8;
					continue;
				case 16:
				case 17:
					flag = num < j.RowCount;
					num2 = 1;
					continue;
				case 1:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					flag = !(j.GetRow(num).Cells["acp"].Value.ToString() == "True");
					num2 = 11;
					continue;
				case 11:
					if (!flag)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 8:
					if (!flag)
					{
						num2 = 13;
						continue;
					}
					goto case 7;
				case 0:
					flag = !(text != "");
					num2 = 19;
					continue;
				case 19:
					if (!flag)
					{
						num2 = 14;
						continue;
					}
					goto case 15;
				case 2:
					asdcb.c(asdab.e(), CommandType.Text, "update  tuser set xpaye=N'" + text + "',per=N'" + text2 + "' where id=" + o);
					MessageBox.Show("ثبت شد");
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		bool flag2 = default;
		int num3 = default;
		DataTable dataTable = default;
		string text2 = default;
		int num2 = default;
		string text = default;
		DataTable dataTable2 = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 47;
			while (true)
			{
				switch (num)
				{
				case 47:
					if (!flag)
					{
						num = 56;
						continue;
					}
					goto case 27;
				case 25:
				case 50:
					num = 22;
					continue;
				case 44:
					flag2 = true;
					num = 46;
					continue;
				case 57:
					k.GetRow(num3).BeginEdit();
					k.GetRow(num3).Cells["acp"].Value = true;
					k.GetRow(num3).EndEdit();
					num = 8;
					continue;
				case 14:
				case 48:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "9";
					dataRow["name"] = "ثبت موارد مالی";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					flag = text2.IndexOf(",10,") < 0;
					num = 4;
					continue;
				}
				case 4:
					if (!flag)
					{
						num = 30;
						continue;
					}
					flag2 = false;
					num = 19;
					continue;
				case 26:
				case 32:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "1";
					dataRow["name"] = "منوی اطلاعات پایه";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					flag = text2.IndexOf(",2,") < 0;
					num = 42;
					continue;
				}
				case 42:
					if (!flag)
					{
						num = 20;
						continue;
					}
					flag2 = false;
					num = 17;
					continue;
				case 12:
					num3 = 0;
					num = 55;
					continue;
				case 41:
					num = 40;
					continue;
				case 40:
					return;
				case 56:
					f.Visible = false;
					j.Enabled = false;
					k.Enabled = false;
					num = 27;
					continue;
				case 54:
					flag2 = true;
					num = 32;
					continue;
				case 34:
					if (!flag)
					{
						num = 57;
						continue;
					}
					goto case 8;
				case 3:
					num2 += 5;
					text = text.Substring(num2, text.Length - num2);
					num = 36;
					continue;
				case 23:
					flag2 = true;
					num = 7;
					continue;
				case 6:
				case 28:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "3";
					dataRow["name"] = "ثبت نمرات";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					flag = text2.IndexOf(",4,") < 0;
					num = 29;
					continue;
				}
				case 29:
					if (flag)
					{
						flag2 = false;
						num = 31;
					}
					else
					{
						num = 23;
					}
					continue;
				case 49:
					flag2 = true;
					num = 28;
					continue;
				case 22:
				case 52:
					dataTable = new DataTable("");
					dataTable.Columns.Add("id");
					dataTable.Columns.Add("name");
					dataTable.Columns.Add("acp", typeof(bool));
					flag2 = false;
					flag = text2.IndexOf(",1,") < 0;
					num = 51;
					continue;
				case 51:
					if (flag)
					{
						flag2 = false;
						num = 26;
					}
					else
					{
						num = 54;
					}
					continue;
				case 36:
				case 37:
					num = 45;
					continue;
				case 17:
				case 43:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "2";
					dataRow["name"] = "منوی دانش آموزان";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					flag = text2.IndexOf(",3,") < 0;
					num = 21;
					continue;
				}
				case 21:
					if (!flag)
					{
						num = 49;
						continue;
					}
					flag2 = false;
					num = 6;
					continue;
				case 20:
					flag2 = true;
					num = 43;
					continue;
				case 11:
					flag2 = true;
					num = 48;
					continue;
				case 27:
				{
					GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(k.RootTable.Columns["acp"], ConditionOperator.Equal, true);
					gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(200, 255, 200);
					k.RootTable.FormatConditions.Add(gridEXFormatCondition);
					GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(j.RootTable.Columns["acp"], ConditionOperator.Equal, true);
					gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(200, 255, 200);
					j.RootTable.FormatConditions.Add(gridEXFormatCondition2);
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select *  from tuser where id=" + o);
					e.Text = dataTable2.Rows[0]["uid"].ToString();
					DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select *,cast(0 as bit) as acp  from tpaye");
					k.DataSource = dataSource;
					text2 = asdab.c(dataTable2.Rows[0]["per"].ToString());
					num2 = text2.IndexOf("kbr63");
					flag = num2 <= 0;
					num = 53;
					continue;
				}
				case 53:
					if (flag)
					{
						text2 = "";
						num = 52;
					}
					else
					{
						num = 18;
					}
					continue;
				case 9:
				case 13:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "5";
					dataRow["name"] = "ارسال نمرات به تلگرام";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					j.DataSource = dataTable;
					flag = text2.IndexOf(",9,") < 0;
					num = 24;
					continue;
				}
				case 24:
					if (flag)
					{
						flag2 = false;
						num = 14;
					}
					else
					{
						num = 11;
					}
					continue;
				case 16:
					flag2 = true;
					num = 13;
					continue;
				case 8:
					num3++;
					num = 58;
					continue;
				case 15:
					num2 += 5;
					text2 = text2.Substring(num2, text2.Length - num2);
					num = 50;
					continue;
				case 18:
					flag = !(o == text2.Substring(0, num2));
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 15;
						continue;
					}
					if (true)
					{
					}
					text2 = "";
					num = 25;
					continue;
				case 55:
				case 58:
					flag = num3 < k.RowCount;
					num = 60;
					continue;
				case 60:
					if (flag)
					{
						flag = text.IndexOf("," + k.GetRow(num3).Cells["id"].Value.ToString() + ",") < 0;
						num = 34;
					}
					else
					{
						num = 41;
					}
					continue;
				case 7:
				case 31:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "4";
					dataRow["name"] = "گزارش نمرات";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					flag = text2.IndexOf(",5,") < 0;
					num = 1;
					continue;
				}
				case 1:
					if (flag)
					{
						flag2 = false;
						num = 9;
					}
					else
					{
						num = 16;
					}
					continue;
				case 38:
					flag = !(o == text.Substring(0, num2));
					num = 10;
					continue;
				case 10:
					if (flag)
					{
						text = "";
						num = 37;
					}
					else
					{
						num = 3;
					}
					continue;
				case 30:
					flag2 = true;
					num = 59;
					continue;
				case 19:
				case 59:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "10";
					dataRow["name"] = "گزارش مالی";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					flag = text2.IndexOf(",14,") < 0;
					num = 5;
					continue;
				}
				case 5:
					if (flag)
					{
						flag2 = false;
						num = 2;
					}
					else
					{
						num = 44;
					}
					continue;
				case 33:
				case 45:
					flag = !(text != "");
					num = 35;
					continue;
				case 35:
					if (!flag)
					{
						num = 12;
						continue;
					}
					return;
				case 2:
				case 46:
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow["id"] = "13";
					dataRow["name"] = "شماره چوکی";
					dataRow["acp"] = flag2;
					dataTable.Rows.Add(dataRow);
					text = asdab.c(dataTable2.Rows[0]["xPaye"].ToString());
					num2 = text.IndexOf("kbr63");
					flag = num2 <= 0;
					num = 39;
					continue;
				}
				case 39:
					if (flag)
					{
						text = "";
						num = 33;
					}
					else
					{
						num = 38;
					}
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		Close();
	}
}
