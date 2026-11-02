using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asda3 : Form
{
	private Panel m_a;

	private UIButton m_b;

	private UIButton m_c;

	private Label m_d;

	private UIComboBox m_e;

	private EditBox m_f;

	private Label g;

	private PictureBox h;

	private Panel i;

	private EditBox j;

	private EditBox k;

	private Label l;

	private Label m;

	private UIButton n;

	private UIButton o;

	private UIButton p;

	private Label q;

	private Label r;

	private IContainer s = null;

	public asda3()
	{
		c();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (true)
					{
					}
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 3:
					num = 2;
					continue;
				case 4:
					s.Dispose();
					num = 3;
					continue;
				case 1:
					flag = s == null;
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 2:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void c()
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
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected Obj, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_0a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected Obj, but got Unknown
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected Obj, but got Unknown
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected Obj, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected Obj, but got Unknown
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Expected Obj, but got Unknown
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected Obj, but got Unknown
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected Obj, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda3));
		StringFormat val = new StringFormat();
		this.m_a = new Panel();
		q = new Label();
		r = new Label();
		i = new Panel();
		j = new EditBox();
		k = new EditBox();
		l = new Label();
		m = new Label();
		n = new UIButton();
		o = new UIButton();
		p = new UIButton();
		h = new PictureBox();
		this.m_f = new EditBox();
		g = new Label();
		this.m_d = new Label();
		this.m_e = new UIComboBox();
		this.m_c = new UIButton();
		this.m_b = new UIButton();
		((Control)this.m_a).SuspendLayout();
		((Control)i).SuspendLayout();
		((ISupportInitialize)h).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.FromArgb(214, 223, 247);
		this.m_a.BorderStyle = (BorderStyle)2;
		((Control)this.m_a).Controls.Add((Control)(object)q);
		((Control)this.m_a).Controls.Add((Control)(object)r);
		((Control)this.m_a).Controls.Add((Control)(object)i);
		((Control)this.m_a).Controls.Add((Control)(object)p);
		((Control)this.m_a).Controls.Add((Control)(object)h);
		((Control)this.m_a).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_a).Controls.Add((Control)(object)g);
		((Control)this.m_a).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_a).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_a).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(12, 12);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(494, 310);
		((Control)this.m_a).TabIndex = 0;
		((Control)q).BackColor = Color.FromArgb(255, 192, 128);
		q.BorderStyle = (BorderStyle)2;
		((Control)q).Font = new Font("Tahoma", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)q).Location = new Point(218, 14);
		((Control)q).Name = "lDefYear";
		((Control)q).RightToLeft = (RightToLeft)0;
		((Control)q).Size = new Size(80, 38);
		((Control)q).TabIndex = 85;
		((Control)q).Text = "1398";
		q.TextAlign = (ContentAlignment)32;
		((Control)r).AutoSize = true;
		((Control)r).Font = new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)r).Location = new Point(300, 21);
		((Control)r).Name = "label2";
		((Control)r).Size = new Size(115, 19);
		((Control)r).TabIndex = 84;
		((Control)r).Text = "سال تعلیمی :";
		i.BorderStyle = (BorderStyle)1;
		((Control)i).Controls.Add((Control)(object)j);
		((Control)i).Controls.Add((Control)(object)k);
		((Control)i).Controls.Add((Control)(object)l);
		((Control)i).Controls.Add((Control)(object)m);
		((Control)i).Controls.Add((Control)(object)n);
		((Control)i).Controls.Add((Control)(object)o);
		((Control)i).Location = new Point(141, 69);
		((Control)i).Name = "pInsert";
		((Control)i).Size = new Size(291, 132);
		((Control)i).TabIndex = 83;
		((Control)i).Visible = false;
		((Control)j).Anchor = (AnchorStyles)9;
		((EditBase)j).AutoScroll = false;
		((EditBase)j).AutoScrollMargin = new Size(0, 0);
		((EditBase)j).AutoScrollMinSize = new Size(0, 0);
		((EditBase)j).AutoScrollPosition = new Point(0, 0);
		((Control)j).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)j).Location = new Point(10, 46);
		((Control)j).Name = "txtNewPass2";
		j.PasswordChar = '*';
		((Control)j).RightToLeft = (RightToLeft)1;
		((Control)j).Size = new Size(130, 21);
		((Control)j).TabIndex = 29;
		((EditBase)j).TextAlignment = (TextAlignment)1;
		((EditBase)j).VisualStyle = (VisualStyle)2;
		((Control)k).Anchor = (AnchorStyles)9;
		((EditBase)k).AutoScroll = false;
		((EditBase)k).AutoScrollMargin = new Size(0, 0);
		((EditBase)k).AutoScrollMinSize = new Size(0, 0);
		((EditBase)k).AutoScrollPosition = new Point(0, 0);
		((Control)k).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Location = new Point(11, 19);
		((Control)k).Name = "txtNewPass";
		k.PasswordChar = '*';
		((Control)k).RightToLeft = (RightToLeft)1;
		((Control)k).Size = new Size(130, 21);
		((Control)k).TabIndex = 28;
		((EditBase)k).TextAlignment = (TextAlignment)1;
		((EditBase)k).VisualStyle = (VisualStyle)2;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(145, 53);
		((Control)l).Name = "label1";
		((Control)l).Size = new Size(97, 13);
		((Control)l).TabIndex = 27;
		((Control)l).Text = "تکرار  رمز عبور جدید";
		((Control)m).AutoSize = true;
		((Control)m).Location = new Point(146, 22);
		((Control)m).Name = "label5";
		((Control)m).Size = new Size(73, 13);
		((Control)m).TabIndex = 25;
		((Control)m).Text = " رمز عبور جدید";
		n.Image = (Image)componentResourceManager.GetObject("btnCancel.Image");
		((Control)n).Location = new Point(10, 91);
		((Control)n).Name = "btnCancel";
		((Control)n).Size = new Size(75, 23);
		((Control)n).TabIndex = 6;
		((Control)n).Text = "انصراف";
		((Control)n).Click += a;
		o.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)o).Location = new Point(91, 91);
		((Control)o).Name = "btnAcp";
		((Control)o).Size = new Size(75, 23);
		((Control)o).TabIndex = 5;
		((Control)o).Text = "تایید";
		((Control)o).Click += b;
		((Control)p).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)p).Location = new Point(42, 110);
		((Control)p).Name = "btnChangPass";
		((Control)p).Size = new Size(117, 36);
		((Control)p).TabIndex = 82;
		((Control)p).Text = "تغییر کلمه عبور";
		((Control)p).Click += c;
		((Control)h).BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage");
		((Control)h).BackgroundImageLayout = (ImageLayout)3;
		((Control)h).Location = new Point(63, 3);
		((Control)h).Name = "pictureBox1";
		((Control)h).Size = new Size(97, 86);
		h.TabIndex = 79;
		h.TabStop = false;
		((Control)this.m_f).Anchor = (AnchorStyles)9;
		((EditBase)this.m_f).AutoScroll = false;
		((EditBase)this.m_f).AutoScrollMargin = new Size(0, 0);
		((EditBase)this.m_f).AutoScrollMinSize = new Size(0, 0);
		((EditBase)this.m_f).AutoScrollPosition = new Point(0, 0);
		((Control)this.m_f).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(169, 112);
		((Control)this.m_f).Name = "txtPass";
		this.m_f.PasswordChar = '*';
		((Control)this.m_f).RightToLeft = (RightToLeft)1;
		((Control)this.m_f).Size = new Size(184, 33);
		((Control)this.m_f).TabIndex = 1;
		((EditBase)this.m_f).TextAlignment = (TextAlignment)1;
		((EditBase)this.m_f).VisualStyle = (VisualStyle)2;
		((Control)this.m_f).KeyDown += a;
		((Control)g).Anchor = (AnchorStyles)9;
		((Control)g).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)g).Location = new Point(361, 115);
		((Control)g).Name = "label6";
		((Control)g).RightToLeft = (RightToLeft)1;
		((Control)g).Size = new Size(90, 30);
		((Control)g).TabIndex = 78;
		((Control)g).Text = "کلمه عبور :";
		g.TextAlign = (ContentAlignment)64;
		((Control)this.m_d).Anchor = (AnchorStyles)9;
		((Control)this.m_d).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(361, 76);
		((Control)this.m_d).Name = "label3";
		((Control)this.m_d).RightToLeft = (RightToLeft)1;
		((Control)this.m_d).Size = new Size(85, 30);
		((Control)this.m_d).TabIndex = 76;
		((Control)this.m_d).Text = "کاربر :";
		this.m_d.TextAlign = (ContentAlignment)64;
		((Control)this.m_e).Anchor = (AnchorStyles)9;
		((UIComboBase)this.m_e).BorderStyle = (BorderStyle)2;
		((UIComboBase)this.m_e).ComboStyle = (ComboStyle)1;
		((Control)this.m_e).Font = new Font("B Nazanin", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		((Control)this.m_e).Location = new Point(169, 75);
		((Control)this.m_e).Name = "ComboUser";
		((Control)this.m_e).RightToLeft = (RightToLeft)1;
		((Control)this.m_e).Size = new Size(184, 33);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)this.m_e).StringFormat = val;
		((Control)this.m_e).TabIndex = 0;
		this.m_c.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_c).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_c.Image = (Image)componentResourceManager.GetObject("uiButton1.Image");
		this.m_c.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_c.ImageIndex = 8;
		this.m_c.ImageSize = new Size(50, 50);
		((Control)this.m_c).Location = new Point(128, 155);
		((Control)this.m_c).Name = "uiButton1";
		((Control)this.m_c).Size = new Size(256, 48);
		((Control)this.m_c).TabIndex = 2;
		((Control)this.m_c).Text = "ورود";
		this.m_c.VisualStyle = (VisualStyle)1;
		((Control)this.m_c).Click += d;
		this.m_b.ButtonStyle = (ButtonStyle)1;
		((Control)this.m_b).Font = new Font("B Nazanin", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)178);
		this.m_b.Image = (Image)componentResourceManager.GetObject("uiButton2.Image");
		this.m_b.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		this.m_b.ImageIndex = 8;
		this.m_b.ImageSize = new Size(50, 50);
		((Control)this.m_b).Location = new Point(128, 210);
		((Control)this.m_b).Name = "uiButton2";
		((Control)this.m_b).Size = new Size(256, 48);
		((Control)this.m_b).TabIndex = 3;
		((Control)this.m_b).Text = "خروج";
		this.m_b.VisualStyle = (VisualStyle)1;
		((Control)this.m_b).Click += f;
		((Form)this).AutoScaleBaseSize = new Size(5, 14);
		((Control)this).BackColor = Color.CornflowerBlue;
		((Form)this).ClientSize = new Size(518, 332);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Control)this).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "frmLogin";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ورود به برنامه";
		((Form)this).Load += e;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_a).PerformLayout();
		((Control)i).ResumeLayout(false);
		((Control)i).PerformLayout();
		((ISupportInitialize)h).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void f(object A_0, EventArgs A_1)
	{
		Application.ExitThread();
	}

	private void b()
	{
		int num2 = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tuser");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 0:
					this.m_e.SelectedIndex = 0;
					num = 7;
					continue;
				case 1:
				case 2:
					flag = num2 < dataTable.Rows.Count;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					this.m_e.Items.Add(dataTable.Rows[num2]["uid"].ToString(), (object)dataTable.Rows[num2]["id"].ToString());
					num2++;
					num = 1;
					continue;
				case 6:
					((CollectionBase)(object)this.m_e.Items).Clear();
					num2 = 0;
					num = 2;
					continue;
				case 7:
					num = 9;
					continue;
				case 9:
					return;
				case 3:
					if (true)
					{
					}
					flag = dataTable.Rows.Count != 1;
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						while (true)
						{
							IL_0099:
							DataTable dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select xYear from tDefYear");
							flag = dataTable2.Rows.Count <= 0;
							num = 1;
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
								case 3:
									((Control)q).Text = dataTable2.Rows[0][0].ToString();
									asdaj.a = ((Control)q).Text;
									num = 0;
									continue;
								case 0:
									num = 2;
									continue;
								case 2:
									goto end_IL_0080;
								}
								goto IL_0099;
								continue;
								end_IL_0080:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					b();
					num = 3;
					continue;
				case 1:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_a).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 2;
					continue;
				case 3:
					try
					{
						string path = Application.StartupPath + "\\user.txt";
						StreamReader streamReader = new StreamReader(path);
						string selectedValue = streamReader.ReadToEnd();
						streamReader.Close();
						this.m_e.SelectedValue = selectedValue;
					}
					catch
					{
					}
					((Control)this.m_f).Select();
					((Control)this.m_f).Focus();
					return;
				case 0:
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = this.m_e.SelectedIndex >= 0;
			int num = 1;
			while (true)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 13;
						continue;
					}
					flag = !(((Control)this.m_f).Text != "arya13880307zx");
					num = 16;
					continue;
				case 20:
					num2 = 0;
					goto IL_0332;
				case 18:
					num3 = 0;
					goto IL_0238;
				case 3:
					num = 12;
					continue;
				case 12:
					num = ((!(asdaj.m == "")) ? 17 : 20);
					continue;
				case 6:
					MessageBox.Show("کلمه عبور اشتباه است");
					((EditBase)this.m_f).SelectAll();
					((Control)this.m_f).Focus();
					num = 24;
					continue;
				case 24:
					return;
				case 21:
					asdaj.l = this.m_e.SelectedValue.ToString();
					num = 0;
					continue;
				case 23:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 21;
				case 17:
					num = 15;
					continue;
				case 15:
					num2 = ((asdaj.m != null) ? 1 : 0);
					goto IL_0332;
				case 25:
					flag = a();
					num = 19;
					continue;
				case 19:
					if (flag)
					{
						flag = !(this.m_e.SelectedValue.ToString() != "1");
						num = 23;
					}
					else
					{
						num = 6;
					}
					continue;
				case 2:
					num = 9;
					continue;
				case 9:
					num3 = ((asdaj.n != null) ? 1 : 0);
					goto IL_0238;
				case 13:
					MessageBox.Show("کاربری انتخاب نشده است");
					num = 8;
					continue;
				case 8:
					return;
				case 27:
					num = (flag ? 21 : 7);
					continue;
				case 22:
					MessageBox.Show("شما مجوزی برای ورود به برنامه ندارید\n\nباید برای شما مجوز صادر کند admin کاربر\n\nبرای این کار باید از منوی مدیریت کاربران و دکمه مجوز ها اقدام شود");
					num = 11;
					continue;
				case 11:
					return;
				case 4:
					num = ((!(asdaj.n == "")) ? 2 : 18);
					continue;
				case 0:
				case 14:
					((Form)this).Close();
					num = 26;
					continue;
				case 26:
					return;
				case 16:
					if (flag)
					{
						asdaj.l = "999";
						num = 14;
					}
					else
					{
						num = 25;
					}
					continue;
				case 10:
					if (flag)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 22;
					}
					continue;
				case 7:
					MessageBox.Show("برای شما در قسمت مجوزها هیچ صنفی انتخاب نشده است\n\nباید برای شما مجوز صنف های مورد نیاز را صادر کند admin کاربر\n\nبرای این کار باید از منوی مدیریت کاربران و دکمه مجوز ها اقدام شود");
					num = 5;
					continue;
				case 5:
					return;
					IL_0332:
					flag = (byte)num2 != 0;
					num = 10;
					continue;
					IL_0238:
					flag = (byte)num3 != 0;
					num = 27;
					continue;
				}
				break;
			}
		}
	}

	private bool a()
	{
		int num3 = default;
		string text4 = default;
		bool flag2 = default;
		DataTable dataTable2 = default;
		string text3 = default;
		string a_ = default;
		bool result = default;
		while (true)
		{
			string text = "-2";
			bool flag = false;
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select id from tpaye");
			string text2 = "";
			int num = 0;
			int num2 = 29;
			while (true)
			{
				switch (num2)
				{
				case 50:
					num3 += 5;
					text4 = text4.Substring(num3, text4.Length - num3);
					num2 = 6;
					continue;
				case 64:
					flag2 = !(dataTable2.Rows[0]["id"].ToString() == text3.Substring(0, num3));
					num2 = 59;
					continue;
				case 59:
					if (flag2)
					{
						text3 = "";
						num2 = 19;
					}
					else
					{
						num2 = 21;
					}
					continue;
				case 63:
					flag2 = !(dataTable2.Rows[0]["id"].ToString() == text4.Substring(0, num3));
					num2 = 24;
					continue;
				case 24:
					if (!flag2)
					{
						num2 = 50;
						continue;
					}
					text4 = "";
					num2 = 31;
					continue;
				case 58:
					asdaj.n = text2;
					num2 = 65;
					continue;
				case 18:
				case 35:
					num2 = 26;
					continue;
				case 23:
				case 32:
					num2 = 44;
					continue;
				case 49:
					if (!flag2)
					{
						num2 = 60;
						continue;
					}
					goto case 43;
				case 55:
					flag = true;
					num2 = 45;
					continue;
				case 40:
					if (!flag2)
					{
						num2 = 0;
						continue;
					}
					flag2 = !(text == "269");
					num2 = 7;
					continue;
				case 65:
					num2 = 2;
					continue;
				case 10:
				case 66:
					num2 = 62;
					continue;
				case 15:
				case 17:
					if (true)
					{
					}
					flag2 = !(text3 != "");
					num2 = 12;
					continue;
				case 12:
					if (!flag2)
					{
						num2 = 34;
						continue;
					}
					goto case 20;
				case 53:
					if (!flag2)
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 3:
					flag = true;
					a_ = dataTable2.Rows[0]["id"].ToString() + "kbr63" + asdab.c(dataTable2.Rows[0]["pwd"].ToString());
					a_ = asdab.d(a_);
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tuser SET  pwd = N'" + a_ + "',pw=398 WHERE     id =" + dataTable2.Rows[0]["id"].ToString());
					flag2 = !(this.m_e.SelectedValue.ToString() == "1");
					num2 = 14;
					continue;
				case 14:
					if (!flag2)
					{
						num2 = 22;
						continue;
					}
					goto case 57;
				case 8:
				case 45:
					flag2 = !(this.m_e.SelectedValue.ToString() == "1");
					num2 = 30;
					continue;
				case 30:
					if (!flag2)
					{
						num2 = 58;
						continue;
					}
					goto case 65;
				case 20:
					num2 = 61;
					continue;
				case 46:
					flag2 = !(dataTable2.Rows[0]["pwd"].ToString() == asdab.d(((Control)this.m_f).Text));
					num2 = 27;
					continue;
				case 27:
					if (flag2)
					{
						flag = false;
						num2 = 32;
					}
					else
					{
						num2 = 3;
					}
					continue;
				case 7:
					if (flag2)
					{
						flag2 = !(text == "398");
						num2 = 53;
					}
					else
					{
						num2 = 46;
					}
					continue;
				case 0:
					flag2 = !(dataTable2.Rows[0]["pwd"].ToString() == asdab.d(((Control)this.m_f).Text));
					num2 = 33;
					continue;
				case 33:
					if (flag2)
					{
						flag = false;
						num2 = 8;
					}
					else
					{
						num2 = 55;
					}
					continue;
				case 13:
					text4 = asdab.c(dataTable2.Rows[0]["per"].ToString());
					num3 = text4.IndexOf("kbr63");
					flag2 = num3 <= 0;
					num2 = 42;
					continue;
				case 42:
					if (flag2)
					{
						text4 = "";
						num2 = 56;
					}
					else
					{
						num2 = 63;
					}
					continue;
				case 60:
					text2 += ",";
					num2 = 43;
					continue;
				case 36:
					flag = true;
					flag2 = !(dataTable2.Rows[0]["id"].ToString() != "1");
					num2 = 47;
					continue;
				case 47:
					if (flag2)
					{
						asdaj.n = text2;
						num2 = 28;
					}
					else
					{
						num2 = 13;
					}
					continue;
				case 9:
					a_ = asdab.c(dataTable2.Rows[0]["pwd"].ToString());
					num3 = a_.IndexOf("kbr63");
					flag2 = num3 <= 0;
					num2 = 39;
					continue;
				case 39:
					if (!flag2)
					{
						num2 = 52;
						continue;
					}
					flag = false;
					num2 = 35;
					continue;
				case 34:
					asdaj.n = text3.Substring(1, text3.Length - 2);
					num2 = 20;
					continue;
				case 52:
					flag2 = !(dataTable2.Rows[0]["id"].ToString() == a_.Substring(0, num3));
					num2 = 16;
					continue;
				case 16:
					if (flag2)
					{
						flag = false;
						num2 = 38;
					}
					else
					{
						num2 = 11;
					}
					continue;
				case 38:
				case 62:
					num2 = 18;
					continue;
				case 4:
					dataTable2 = asdcb.c(asdab.e(), CommandType.Text, "select * from tuser where id= " + this.m_e.SelectedValue.ToString());
					num2 = 25;
					continue;
				case 43:
					text2 += dataTable.Rows[num][0].ToString();
					num++;
					num2 = 37;
					continue;
				case 57:
					num2 = 23;
					continue;
				case 25:
					try
					{
						text = dataTable2.Rows[0]["pw"].ToString();
					}
					catch
					{
					}
					flag2 = !(text == "-2");
					num2 = 40;
					continue;
				case 29:
				case 37:
					flag2 = num < dataTable.Rows.Count;
					num2 = 41;
					continue;
				case 41:
					if (flag2)
					{
						flag2 = !(text2 != "");
						num2 = 49;
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 11:
					num3 += 5;
					flag2 = !(a_.Substring(num3, a_.Length - num3) == ((Control)this.m_f).Text);
					num2 = 51;
					continue;
				case 51:
					if (flag2)
					{
						flag = false;
						num2 = 10;
					}
					else
					{
						num2 = 36;
					}
					continue;
				case 21:
					num3 += 5;
					text3 = text3.Substring(num3, text3.Length - num3);
					num2 = 1;
					continue;
				case 28:
				case 61:
					num2 = 66;
					continue;
				case 1:
				case 19:
					num2 = 15;
					continue;
				case 2:
				case 26:
				case 44:
					result = flag;
					num2 = 54;
					continue;
				case 48:
				case 56:
					asdaj.m = text4;
					text3 = asdab.c(dataTable2.Rows[0]["xPaye"].ToString());
					num3 = text3.IndexOf("kbr63");
					flag2 = num3 <= 0;
					num2 = 5;
					continue;
				case 5:
					if (flag2)
					{
						text3 = "";
						num2 = 17;
					}
					else
					{
						num2 = 64;
					}
					continue;
				case 22:
					asdaj.n = text2;
					num2 = 57;
					continue;
				case 6:
				case 31:
					num2 = 48;
					continue;
				case 54:
					return result;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = this.m_e.SelectedIndex >= 0;
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
					flag = !(((Control)this.m_f).Text != "arya13880307zx");
					num = 8;
					continue;
				case 9:
					flag = a();
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						if (true)
						{
						}
						num = 4;
					}
					else
					{
						num = 5;
					}
					continue;
				case 0:
					MessageBox.Show("کاربری انتخاب نشده است");
					num = 2;
					continue;
				case 2:
					return;
				case 4:
					((Control)i).Visible = true;
					num = 7;
					continue;
				case 7:
					return;
				case 8:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 4;
				case 5:
					MessageBox.Show("کلمه عبور اشتباه است");
					num = 3;
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)k).Text != ((Control)j).Text);
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
					flag = (int)MessageBox.Show("آيا از تغییر کلمه عبور مطمئن هستيد؟", "", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
					if (true)
					{
					}
					num = 1;
					continue;
				case 5:
				{
					string a_ = this.m_e.SelectedValue.ToString() + "kbr63" + ((Control)k).Text;
					a_ = asdab.d(a_);
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tuser SET  pwd = N'" + a_ + "',pw=398 WHERE     id =" + this.m_e.SelectedValue.ToString());
					MessageBox.Show("تغییر ثبت شد");
					((Control)i).Visible = false;
					num = 3;
					continue;
				}
				case 3:
					return;
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 0:
					MessageBox.Show("رمز عبور را با دقت وارد کنید");
					num = 4;
					continue;
				case 4:
					return;
				}
				break;
			}
		}
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
						num = 0;
						continue;
					}
					return;
				case 0:
					d(this, null);
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
		((Control)i).Visible = false;
	}
}
