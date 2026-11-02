using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;

public class asdbk : Form
{
	private Panel m_a;

	private Panel m_b;

	private OpenFileDialog m_c;

	private Panel m_d;

	private Label e;

	private UIButton f;

	private EditBox g;

	private UIButton h;

	private UIButton i;

	private Container j = null;

	public string k = "";

	public asdbk()
	{
		a();
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 0:
					num = 5;
					continue;
				case 1:
					j.Dispose();
					num = 0;
					continue;
				case 4:
					flag = j == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 0;
				case 5:
					((Form)this).Dispose(A_0);
					return;
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
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdbk));
		this.m_a = new Panel();
		this.m_b = new Panel();
		i = new UIButton();
		this.m_d = new Panel();
		e = new Label();
		f = new UIButton();
		g = new EditBox();
		h = new UIButton();
		this.m_c = new OpenFileDialog();
		((Control)this.m_a).SuspendLayout();
		((Control)this.m_b).SuspendLayout();
		((Control)this.m_d).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_a).BackColor = Color.FromArgb(184, 203, 255);
		this.m_a.BorderStyle = (BorderStyle)1;
		((Control)this.m_a).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_a).Location = new Point(8, 8);
		((Control)this.m_a).Name = "panel1";
		((Control)this.m_a).Size = new Size(499, 291);
		((Control)this.m_a).TabIndex = 16;
		((Control)this.m_b).BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = (BorderStyle)2;
		((Control)this.m_b).Controls.Add((Control)(object)i);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Location = new Point(7, 8);
		((Control)this.m_b).Name = "panel2";
		((Control)this.m_b).Size = new Size(482, 272);
		((Control)this.m_b).TabIndex = 16;
		i.ButtonStyle = (ButtonStyle)1;
		((Control)i).Font = new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		i.Image = (Image)componentResourceManager.GetObject("uiButton5.Image");
		i.ImageHorizontalAlignment = (ImageHorizontalAlignment)5;
		i.ImageIndex = 8;
		i.ImageSize = new Size(50, 50);
		((Control)i).Location = new Point(19, 209);
		((Control)i).Name = "uiButton5";
		((Control)i).RightToLeft = (RightToLeft)1;
		((Control)i).Size = new Size(443, 45);
		((Control)i).TabIndex = 45;
		((Control)i).Text = "خروج";
		i.VisualStyle = (VisualStyle)1;
		((Control)i).Click += b;
		((Control)this.m_d).Controls.Add((Control)(object)e);
		((Control)this.m_d).Controls.Add((Control)(object)f);
		((Control)this.m_d).Controls.Add((Control)(object)g);
		((Control)this.m_d).Controls.Add((Control)(object)h);
		((Control)this.m_d).Location = new Point(19, 31);
		((Control)this.m_d).Name = "panel4";
		((Control)this.m_d).Size = new Size(443, 150);
		((Control)this.m_d).TabIndex = 1;
		((Control)e).Font = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)e).Location = new Point(111, 8);
		((Control)e).Name = "lReg";
		((Control)e).Size = new Size(316, 28);
		((Control)e).TabIndex = 3;
		e.TextAlign = (ContentAlignment)32;
		((Control)f).Font = new Font("Tahoma", 11.25f);
		f.Image = (Image)componentResourceManager.GetObject("btnRestor.Image");
		f.ImageSize = new Size(50, 50);
		((Control)f).Location = new Point(111, 71);
		((Control)f).Name = "btnRestor";
		((Control)f).Size = new Size(260, 63);
		((Control)f).TabIndex = 2;
		((Control)f).Text = "فعال سازی";
		((Control)f).Click += c;
		((EditBase)g).AutoScroll = false;
		((EditBase)g).AutoScrollMargin = new Size(0, 0);
		((EditBase)g).AutoScrollMinSize = new Size(0, 0);
		((EditBase)g).AutoScrollPosition = new Point(0, 0);
		((Control)g).Location = new Point(111, 45);
		((Control)g).Name = "txtResore";
		((Control)g).Size = new Size(316, 20);
		((Control)g).TabIndex = 1;
		((EditBase)g).TextAlignment = (TextAlignment)1;
		((Control)h).Font = new Font("Tahoma", 8.25f);
		h.Image = (Image)componentResourceManager.GetObject("uiButton4.Image");
		h.ImageSize = new Size(30, 30);
		((Control)h).Location = new Point(3, 38);
		((Control)h).Name = "uiButton4";
		((Control)h).Size = new Size(102, 35);
		((Control)h).TabIndex = 0;
		((Control)h).Text = "انتخاب فایل فعال سازی";
		((Control)h).Click += d;
		((FileDialog)this.m_c).FileName = "openFileDialog1";
		((FileDialog)this.m_c).Filter = "kbrFile|*.kbr";
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Control)this).BackColor = Color.FromArgb(184, 203, 255);
		((Form)this).ClientSize = new Size(514, 307);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmRegisterPak";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "پیشتیبان";
		((Form)this).Load += a;
		((Control)this.m_a).ResumeLayout(false);
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_d).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		while (true)
		{
			DialogResult val = ((CommonDialog)this.m_c).ShowDialog();
			bool flag = (int)val != 1;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 3:
					num = 5;
					continue;
				case 5:
					return;
				case 0:
					((Control)g).Text = ((FileDialog)this.m_c).FileName;
					num = 3;
					continue;
				case 1:
					flag = !(((FileDialog)this.m_c).FileName != "");
					num = 2;
					continue;
				case 2:
					if (true)
					{
					}
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(((Control)g).Text == "");
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (!flag)
					{
						num = 3;
						continue;
					}
					if (true)
					{
					}
					string a_ = "";
					num = 0;
					continue;
				}
				case 0:
					try
					{
						while (true)
						{
							IL_00af:
							StreamReader streamReader = new StreamReader(((Control)g).Text);
							string a_ = streamReader.ReadToEnd();
							streamReader.Close();
							a_ = asdab.c(a_);
							string text = a_.Substring(1, 1) + a_.Substring(4, 1) + a_.Substring(6, 1) + a_.Substring(9, 1);
							flag = !(text != asdab.n);
							num = 8;
							while (true)
							{
								switch (num)
								{
								case 8:
									if (!flag)
									{
										num = 0;
										continue;
									}
									flag = !(a_.Substring(0, 1) != k);
									num = 7;
									continue;
								case 15:
									if (!flag)
									{
										num = 10;
										continue;
									}
									MessageBox.Show("خطا");
									num = 14;
									continue;
								case 9:
								case 14:
									num = 16;
									continue;
								case 3:
									MessageBox.Show("انجام شد");
									((Form)this).Close();
									num = 4;
									continue;
								case 7:
									if (!flag)
									{
										num = 11;
										continue;
									}
									flag = !(k == "0");
									num = 17;
									continue;
								case 10:
									MessageBox.Show("انجام شد");
									((Form)this).Close();
									num = 9;
									continue;
								case 17:
									if (flag)
									{
										flag = !a(int.Parse(k));
										num = 15;
									}
									else
									{
										num = 12;
									}
									continue;
								case 0:
									MessageBox.Show("این فایل برای این مکتب نیست");
									num = 5;
									continue;
								case 5:
									return;
								case 11:
									MessageBox.Show("این فایل برای فعال سازی این بخش نیست");
									num = 13;
									continue;
								case 13:
									return;
								case 12:
								{
									asdu asdu2 = new asdu();
									bool A_2 = false;
									asdu2.a(ref A_2);
									flag = !A_2;
									num = 2;
									continue;
								}
								case 2:
									if (!flag)
									{
										num = 3;
										continue;
									}
									goto case 4;
								case 4:
									num = 6;
									continue;
								case 6:
								case 16:
									num = 1;
									continue;
								case 1:
									goto end_IL_005e;
								}
								goto IL_00af;
								continue;
								end_IL_005e:
								break;
							}
							break;
						}
					}
					catch
					{
						MessageBox.Show("خطا در فایل انتخاب شده");
						return;
					}
					num = 4;
					continue;
				case 3:
					MessageBox.Show("فایلی برای فعال سازی انتخاب نشده است");
					num = 1;
					continue;
				case 1:
					return;
				case 4:
					return;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private bool a(int A_0)
	{
		int num3 = default;
		char[] array = default;
		int num2 = default;
		int num4 = default;
		bool A_1 = default;
		bool result = default;
		while (true)
		{
			string text = "";
			string text2 = asdu.o;
			bool flag = !(text2 == "");
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 4;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 7;
				case 2:
					text2 = "100000000000000";
					num = 8;
					continue;
				case 0:
					asdu.o = text;
					num = 7;
					continue;
				case 5:
					flag = !(asdab.m == "3");
					num = 11;
					continue;
				case 11:
					if (!flag)
					{
						num = 2;
						continue;
					}
					text2 = "110000000000000";
					num = 14;
					continue;
				case 6:
				case 12:
					flag = num3 >= 0;
					num = 10;
					continue;
				case 10:
					if (flag)
					{
						char c = array[num3];
						num2 += int.Parse(array[num3].ToString()) * num4;
						num4 *= 2;
						num3--;
						num = 12;
					}
					else
					{
						num = 13;
					}
					continue;
				case 13:
				{
					if (true)
					{
					}
					asdu asdu2 = new asdu();
					A_1 = false;
					asdu2.a(num2, ref A_1);
					flag = !A_1;
					num = 3;
					continue;
				}
				case 7:
					result = A_1;
					num = 1;
					continue;
				case 8:
				case 14:
					num = 4;
					continue;
				case 4:
					text = text2.Substring(0, A_0 - 1) + "1" + text2.Substring(A_0, text2.Length - A_0);
					array = text.ToCharArray();
					num4 = 1;
					num2 = 0;
					num3 = array.Length - 1;
					num = 6;
					continue;
				case 1:
					return result;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = !(k == "3");
			int num = 11;
			while (true)
			{
				switch (num)
				{
				case 11:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 4:
					((Control)e).Text = "فعال سازی بخش مالی";
					num = 7;
					continue;
				case 3:
					if (true)
					{
					}
					flag = !(k == "5");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 7;
				case 2:
					flag = !(k == "4");
					num = 0;
					continue;
				case 0:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 3;
				case 6:
					((Control)e).Text = "فعال سازی بخش شبکه";
					num = 10;
					continue;
				case 10:
					return;
				case 1:
					((Control)e).Text = "فعال سازی بخش طراحی گزارش";
					num = 2;
					continue;
				case 7:
					flag = !(k == "0");
					num = 5;
					continue;
				case 5:
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 9:
					((Control)e).Text = "فعال سازی بخش انضباطی";
					num = 3;
					continue;
				}
				break;
			}
		}
	}
}
