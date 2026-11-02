using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.UI;

public class asdav : Form
{
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private IContainer m_b = null;

	private Panel m_c;

	private Panel d;

	private Panel e;

	private UIButton f;

	private UIButton g;

	private Label h;

	private Label i;

	private UIComboBox j;

	public asdav()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		a();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 2:
					try
					{
						if (true)
						{
						}
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)e).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 0:
					j.SelectedValue = asdaj.a;
					num = 7;
					continue;
				case 7:
					return;
				case 1:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 4;
					continue;
				case 4:
					return;
				case 3:
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(asdab.q != asdab.n);
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
					flag = asdab.p >= int.Parse(j.SelectedValue.ToString());
					num = 1;
					continue;
				case 4:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر به سال جدید وجود ندارد");
					num = 3;
					continue;
				case 3:
					return;
				case 1:
				{
					if (!flag)
					{
						num = 4;
						continue;
					}
					SqlParameter[] a_ = new SqlParameter[1] { asdcb.a("@xYear", SqlDbType.Int, j.SelectedValue.ToString()) };
					asdcb.d(asdab.e(), CommandType.StoredProcedure, "Sp_SetDefYear", a_);
					MessageBox.Show("ثبت شد");
					asdaj.a = j.SelectedValue.ToString();
					num = 0;
					continue;
				}
				case 2:
					MessageBox.Show("برای قفل شما هزینه پشتیبانی پرداخت نشده و امکان تغییر سال وجود ندارد");
					num = 6;
					continue;
				case 6:
					if (1 == 0)
					{
					}
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

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
					num = ((!A_0) ? 4 : 5);
					continue;
				case 5:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 0:
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
					this.m_b.Dispose();
					num = 1;
					continue;
				case 4:
					num2 = 1;
					goto IL_0074;
				case 1:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected Obj, but got Unknown
		if (true)
		{
		}
		UIComboBoxItem val = new UIComboBoxItem();
		UIComboBoxItem val2 = new UIComboBoxItem();
		UIComboBoxItem val3 = new UIComboBoxItem();
		UIComboBoxItem val4 = new UIComboBoxItem();
		UIComboBoxItem val5 = new UIComboBoxItem();
		UIComboBoxItem val6 = new UIComboBoxItem();
		StringFormat val7 = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdav));
		this.m_c = new Panel();
		d = new Panel();
		e = new Panel();
		j = new UIComboBox();
		i = new Label();
		h = new Label();
		g = new UIButton();
		f = new UIButton();
		((Control)this.m_c).SuspendLayout();
		((Control)d).SuspendLayout();
		((Control)e).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_c).BackColor = Color.FromArgb(214, 223, 247);
		this.m_c.BorderStyle = (BorderStyle)1;
		((Control)this.m_c).Controls.Add((Control)(object)d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel1";
		((Control)this.m_c).Size = new Size(375, 222);
		((Control)this.m_c).TabIndex = 0;
		((Control)d).BackColor = Color.Black;
		((Control)d).Controls.Add((Control)(object)e);
		((Control)d).Dock = (DockStyle)5;
		((Control)d).Location = new Point(0, 0);
		((Control)d).Name = "panel2";
		((Control)d).Size = new Size(373, 220);
		((Control)d).TabIndex = 44;
		((Control)e).BackColor = Color.FromArgb(214, 223, 247);
		((Control)e).Controls.Add((Control)(object)j);
		((Control)e).Controls.Add((Control)(object)i);
		((Control)e).Controls.Add((Control)(object)h);
		((Control)e).Controls.Add((Control)(object)g);
		((Control)e).Controls.Add((Control)(object)f);
		((Control)e).Location = new Point(3, 3);
		((Control)e).Name = "panel3";
		((Control)e).Size = new Size(367, 213);
		((Control)e).TabIndex = 0;
		((UIComboBase)j).ComboStyle = (ComboStyle)1;
		((UIComboBase)j).DropListFont = new Font("B Nazanin", 15.75f, (FontStyle)1);
		((Control)j).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		val.FormatStyle.Alpha = 0;
		val.Text = "1403";
		val.Value = "1403";
		val2.FormatStyle.Alpha = 0;
		val2.Text = "1402";
		val2.Value = "1402";
		val3.FormatStyle.Alpha = 0;
		val3.Text = "1401";
		val3.Value = "1401";
		val4.FormatStyle.Alpha = 0;
		val4.Text = "1400";
		val4.Value = "1400";
		val5.FormatStyle.Alpha = 0;
		val5.Text = "1399";
		val5.Value = "1399";
		val6.FormatStyle.Alpha = 0;
		val6.Text = "1398";
		val6.Value = "1398";
		j.Items.AddRange(new UIComboBoxItem[6] { val, val2, val3, val4, val5, val6 });
		((Control)j).Location = new Point(83, 83);
		((Control)j).Name = "dropYear";
		((Control)j).Size = new Size(137, 41);
		val7.Alignment = (StringAlignment)0;
		val7.FormatFlags = (StringFormatFlags)20485;
		val7.HotkeyPrefix = (HotkeyPrefix)0;
		val7.LineAlignment = (StringAlignment)1;
		val7.Trimming = (StringTrimming)1;
		((UIComboBase)j).StringFormat = val7;
		((Control)j).TabIndex = 131;
		((Control)i).AutoSize = true;
		((Control)i).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(229, 83);
		((Control)i).Name = "label3";
		((Control)i).Size = new Size(101, 33);
		((Control)i).TabIndex = 127;
		((Control)i).Text = "سال تعلیمی";
		((Control)h).AutoSize = true;
		((Control)h).Font = new Font("B Nazanin", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).ForeColor = Color.DarkViolet;
		((Control)h).Location = new Point(46, 5);
		((Control)h).Name = "label4";
		((Control)h).Size = new Size(274, 51);
		((Control)h).TabIndex = 121;
		((Control)h).Text = "سال تعلیمی پیش فرض";
		g.ButtonStyle = (ButtonStyle)1;
		((Control)g).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		g.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		g.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		g.ImageIndex = 8;
		g.ImageSize = new Size(40, 40);
		((Control)g).Location = new Point(188, 163);
		((Control)g).Name = "btnAcp";
		((Control)g).RightToLeft = (RightToLeft)1;
		((Control)g).Size = new Size(153, 40);
		((Control)g).TabIndex = 4;
		((Control)g).Text = "ثبت";
		g.VisualStyle = (VisualStyle)1;
		((Control)g).Click += a;
		f.DialogResult = (DialogResult)2;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		((Control)f).Location = new Point(20, 163);
		((Control)f).Name = "btnClose";
		((Control)f).Size = new Size(152, 40);
		((Control)f).TabIndex = 16;
		((Control)f).Text = "بستن";
		((Control)f).Click += b;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(375, 222);
		((Control)this).Controls.Add((Control)(object)this.m_c);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSetDefYear";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "سال تعلیمی پیش فرض";
		((Form)this).Load += c;
		((Control)this.m_c).ResumeLayout(false);
		((Control)d).ResumeLayout(false);
		((Control)e).ResumeLayout(false);
		((Control)e).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
