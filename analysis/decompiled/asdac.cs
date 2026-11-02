using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdac : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private UIButton m_e;

	private UIButton f;

	private Label g;

	private Label h;

	private Label i;

	private EditBox j;

	private EditBox k;

	private Label l;

	private EditBox m;

	private Label n;

	private EditBox o;

	private SqlConnection p = new SqlConnection(asdab.e());

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
						num = 6;
					}
					else
					{
						num = 4;
					}
					continue;
				case 6:
					num = 2;
					continue;
				case 2:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 5:
					this.m_a.Dispose();
					num = 0;
					continue;
				case 3:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 0;
				case 4:
					num2 = 1;
					goto IL_007c;
				case 0:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected Obj, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected Obj, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected Obj, but got Unknown
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected Obj, but got Unknown
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdac));
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		l = new Label();
		m = new EditBox();
		n = new Label();
		o = new EditBox();
		h = new Label();
		i = new Label();
		j = new EditBox();
		k = new EditBox();
		g = new Label();
		f = new UIButton();
		this.m_e = new UIButton();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_c).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("B Nazanin", 12f, (FontStyle)1);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(482, 314);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_c).BackColor = Color.Black;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Dock = (DockStyle)5;
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "panel2";
		((Control)this.m_c).Size = new Size(480, 312);
		((Control)this.m_c).TabIndex = 44;
		((Control)this.m_d).BackColor = Color.FromArgb(214, 223, 247);
		((Control)this.m_d).Controls.Add((Control)(object)l);
		((Control)this.m_d).Controls.Add((Control)(object)m);
		((Control)this.m_d).Controls.Add((Control)(object)n);
		((Control)this.m_d).Controls.Add((Control)(object)o);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Controls.Add((Control)(object)i);
		((Control)this.m_d).Controls.Add((Control)(object)j);
		((Control)this.m_d).Controls.Add((Control)(object)k);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Controls.Add((Control)(object)f);
		((Control)this.m_d).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_d).Location = new Point(3, 3);
		((Control)this.m_d).Name = "panel3";
		((Control)this.m_d).Size = new Size(473, 304);
		((Control)this.m_d).TabIndex = 0;
		((Control)l).AutoSize = true;
		((Control)l).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(348, 108);
		((Control)l).Name = "label5";
		((Control)l).Size = new Size(51, 20);
		((Control)l).TabIndex = 129;
		((Control)l).Text = "ولسوالی :";
		((EditBase)m).AutoScroll = false;
		((EditBase)m).AutoScrollMargin = new Size(0, 0);
		((EditBase)m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)m).AutoScrollPosition = new Point(0, 0);
		((Control)m).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(81, 106);
		((EditBase)m).MaxLength = 300;
		((Control)m).Name = "txtCity";
		((Control)m).Size = new Size(263, 23);
		((Control)m).TabIndex = 1;
		((EditBase)m).TextAlignment = (TextAlignment)1;
		((Control)m).Leave += a;
		((Control)m).Enter += b;
		((Control)m).KeyDown += a;
		((Control)n).AutoSize = true;
		((Control)n).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(347, 78);
		((Control)n).Name = "label3";
		((Control)n).Size = new Size(41, 20);
		((Control)n).TabIndex = 127;
		((Control)n).Text = "ولایت :";
		((EditBase)o).AutoScroll = false;
		((EditBase)o).AutoScrollMargin = new Size(0, 0);
		((EditBase)o).AutoScrollMinSize = new Size(0, 0);
		((EditBase)o).AutoScrollPosition = new Point(0, 0);
		((Control)o).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)o).Location = new Point(81, 77);
		((EditBase)o).MaxLength = 300;
		((Control)o).Name = "txtOst";
		((Control)o).Size = new Size(263, 23);
		((Control)o).TabIndex = 0;
		((EditBase)o).TextAlignment = (TextAlignment)1;
		((Control)o).Leave += a;
		((Control)o).Enter += b;
		((Control)o).KeyDown += a;
		((Control)h).AutoSize = true;
		((Control)h).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)h).Location = new Point(348, 171);
		((Control)h).Name = "label2";
		((Control)h).Size = new Size(50, 20);
		((Control)h).TabIndex = 125;
		((Control)h).Text = "نام مدیر :";
		((Control)i).AutoSize = true;
		((Control)i).Font = new Font("B Nazanin", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)i).Location = new Point(347, 140);
		((Control)i).Name = "label1";
		((Control)i).Size = new Size(57, 20);
		((Control)i).TabIndex = 124;
		((Control)i).Text = "نام مکتب :";
		((EditBase)j).AutoScroll = false;
		((EditBase)j).AutoScrollMargin = new Size(0, 0);
		((EditBase)j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)j).AutoScrollPosition = new Point(0, 0);
		((Control)j).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)j).Location = new Point(81, 168);
		((EditBase)j).MaxLength = 300;
		((Control)j).Name = "txtFoter1";
		((Control)j).Size = new Size(263, 23);
		((Control)j).TabIndex = 3;
		((EditBase)j).TextAlignment = (TextAlignment)1;
		((Control)j).Leave += a;
		((Control)j).Enter += b;
		((Control)j).KeyDown += a;
		((EditBase)k).AutoScroll = false;
		((EditBase)k).AutoScrollMargin = new Size(0, 0);
		((EditBase)k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)k).AutoScrollPosition = new Point(0, 0);
		((Control)k).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(81, 139);
		((EditBase)k).MaxLength = 300;
		((Control)k).Name = "txtSch";
		((Control)k).Size = new Size(263, 23);
		((Control)k).TabIndex = 2;
		((EditBase)k).TextAlignment = (TextAlignment)1;
		((Control)k).Leave += a;
		((Control)k).Enter += b;
		((Control)k).KeyDown += a;
		((Control)g).AutoSize = true;
		((Control)g).Font = new Font("B Nazanin", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)g).ForeColor = Color.DarkViolet;
		((Control)g).Location = new Point(129, 14);
		((Control)g).Name = "label4";
		((Control)g).Size = new Size(202, 51);
		((Control)g).TabIndex = 121;
		((Control)g).Text = "مشخصات مکتب";
		f.ButtonStyle = (ButtonStyle)1;
		((Control)f).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		f.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		f.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		f.ImageIndex = 8;
		f.ImageSize = new Size(40, 40);
		((Control)f).Location = new Point(197, 213);
		((Control)f).Name = "btnAcp";
		((Control)f).RightToLeft = (RightToLeft)1;
		((Control)f).Size = new Size(153, 40);
		((Control)f).TabIndex = 4;
		((Control)f).Text = "ثبت";
		f.VisualStyle = (VisualStyle)1;
		((Control)f).Click += c;
		this.m_e.DialogResult = (DialogResult)2;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(40, 40);
		((Control)this.m_e).Location = new Point(39, 213);
		((Control)this.m_e).Name = "btnClose";
		((Control)this.m_e).Size = new Size(152, 40);
		((Control)this.m_e).TabIndex = 16;
		((Control)this.m_e).Text = "بستن";
		((Control)this.m_e).Click += d;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(482, 314);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmSchool";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "مشخصات مکتب";
		((Form)this).Load += e;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_c).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this.m_d).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public asdac()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !(asdaj.l != "1");
			int num = 1;
			while (true)
			{
				DataTable dataTable2;
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 0;
					continue;
				case 2:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_d).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 6;
					continue;
				case 0:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto IL_0134;
				case 3:
					return;
				case 7:
					MessageBox.Show("اجازه ورود به این بخش را دارد admin فقط کاربر", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)64);
					((Form)this).Close();
					num = 4;
					continue;
				case 4:
					return;
				case 6:
					if (1 == 0)
					{
					}
					goto IL_0134;
				case 5:
					{
						num = 2;
						continue;
					}
					IL_0134:
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select * from tParmetr");
					((Control)o).Text = dataTable2.Rows[0]["Ost"].ToString();
					((Control)m).Text = dataTable2.Rows[0]["cty"].ToString();
					((Control)j).Text = dataTable2.Rows[0]["Foter1"].ToString();
					((Control)k).Text = dataTable2.Rows[0]["sch"].ToString();
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		SqlParameter[] a_ = new SqlParameter[4]
		{
			asdcb.a("@Ost", SqlDbType.NVarChar, ((Control)o).Text),
			asdcb.a("@cty", SqlDbType.NVarChar, ((Control)m).Text),
			asdcb.a("@Foter1", SqlDbType.NVarChar, ((Control)j).Text),
			asdcb.a("@sch", SqlDbType.NVarChar, ((Control)k).Text)
		};
		asdcb.d(asdab.e(), CommandType.Text, "UPDATE    tParmetr\r\n                SET  Ost =@Ost , cty =@cty , Foter1 =@Foter1 , sch =@sch", a_);
		MessageBox.Show("ثبت شد");
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (true)
		{
		}
		EditBox val = (EditBox)A_0;
		((EditBase)val).BackColor = Color.FromArgb(255, 255, 128);
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		EditBox val = (EditBox)A_0;
		((EditBase)val).BackColor = Color.FromName("Window");
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		while (true)
		{
			if (true)
			{
			}
			bool flag = (int)A_1.KeyCode != 13;
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
					SendKeys.Send("{tab}");
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
