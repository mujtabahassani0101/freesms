using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using DataDynamics.ActiveReports.Viewer;

public class asdbp : Form
{
	private IContainer m_a = null;

	private Viewer b;

	private ActiveReport3 c = new ActiveReport3();

	private DataSet d = new DataSet();

	private string e = "";

	private string f = "";

	private string g = "";

	private string h = "";

	private string i = "";

	private string j = "";

	private string k = "";

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
						num = 3;
					}
					else
					{
						num = 0;
					}
					continue;
				case 3:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 4:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 2;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						((Form)this).Dispose(A_0);
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
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		if (true)
		{
		}
		b = new Viewer();
		((Control)this).SuspendLayout();
		((Control)b).BackColor = SystemColors.Control;
		((Control)b).Dock = (DockStyle)5;
		b.Document = new Document("");
		((Control)b).Location = new Point(0, 0);
		((Control)b).Name = "arvMain";
		b.ReportViewer.BackColor = SystemColors.Control;
		b.ReportViewer.CurrentPage = 0;
		b.ReportViewer.MultiplePageCols = 3;
		b.ReportViewer.MultiplePageRows = 2;
		b.ReportViewer.ViewType = (ViewType)0;
		((Control)b).Size = new Size(478, 513);
		((Control)b).TabIndex = 2;
		b.TableOfContents.Text = "Contents";
		b.TableOfContents.Width = 200;
		b.TabTitleLength = 35;
		b.Toolbar.Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(478, 513);
		((Control)this).Controls.Add((Control)(object)b);
		((Control)this).Name = "PrintRptDynamic";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).Load += a;
		((Form)this).FormClosing += a;
		((Control)this).ResumeLayout(false);
	}

	public asdbp()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Invalid comparison between I4 and Unknown
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a16: Invalid comparison between I4 and Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdb: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected Obj, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default;
		Picture val6 = default;
		Picture val4 = default;
		Picture val = default;
		while (true)
		{
			int num = 21;
			while (true)
			{
				int num3;
				int num4;
				switch (num)
				{
				case 17:
					try
					{
						while (true)
						{
							IL_00ca:
							Picture val3 = (Picture)c.Sections["Page4"].Controls["pic4"];
							flag = !(i == "");
							num = 9;
							while (true)
							{
								switch (num)
								{
								case 9:
									if (!flag)
									{
										num = 4;
										continue;
									}
									flag = !(i == "0");
									num = 1;
									continue;
								case 4:
									c.Sections["Page4"].Visible = false;
									num = 5;
									continue;
								case 8:
									val3.Image = Image.FromFile(i);
									num = 2;
									continue;
								case 1:
									if (!flag)
									{
										num = 6;
										continue;
									}
									flag = !(i != "");
									num = 0;
									continue;
								case 6:
									c.Sections["Page4"].Controls.Clear();
									val3.Image = null;
									num = 10;
									continue;
								case 2:
								case 10:
									val3.Dispose();
									num = 3;
									continue;
								case 0:
									if (!flag)
									{
										num = 8;
										continue;
									}
									goto case 2;
								case 3:
								case 5:
									num = 7;
									continue;
								case 7:
									goto end_IL_0095;
								}
								goto IL_00ca;
								continue;
								end_IL_0095:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 13;
					continue;
				case 15:
					i = "0";
					num = 20;
					continue;
				case 14:
					num3 = 1;
					goto IL_05be;
				case 5:
					try
					{
						while (true)
						{
							IL_034c:
							flag = !(g == "");
							num = 5;
							while (true)
							{
								switch (num)
								{
								case 5:
									if (!flag)
									{
										num = 4;
										continue;
									}
									val6 = (Picture)c.Sections["Page2"].Controls["pic2"];
									flag = !(g != "");
									num = 7;
									continue;
								case 1:
								case 6:
									val6.Dispose();
									num = 2;
									continue;
								case 0:
									val6.Image = Image.FromFile(g);
									num = 6;
									continue;
								case 7:
									if (flag)
									{
										val6.Image = null;
										num = 1;
									}
									else
									{
										num = 0;
									}
									continue;
								case 4:
									c.Sections["Page2"].Visible = false;
									num = 8;
									continue;
								case 2:
								case 8:
									num = 3;
									continue;
								case 3:
									goto end_IL_031f;
								}
								goto IL_034c;
								continue;
								end_IL_031f:
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
				case 3:
					num = 27;
					continue;
				case 27:
					num = ((!(j != "")) ? 2 : 24);
					continue;
				case 19:
					return;
				case 26:
					num = 4;
					continue;
				case 21:
					try
					{
						while (true)
						{
							IL_050b:
							flag = asdax.a(3);
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 2:
									num = ((!flag) ? 1 : 0);
									continue;
								case 1:
									MessageBox.Show("شما این بخش را فعال نکرده اید.جهت فعال سازی با شرکت تماس بگیرید-09902922484");
									num = 3;
									continue;
								case 3:
									return;
								case 0:
									goto end_IL_04f2;
								}
								goto IL_050b;
								continue;
								end_IL_04f2:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("خطای 1");
						MessageBox.Show(ex.Message);
						return;
					}
					num = 7;
					continue;
				case 12:
					flag = 6 != (int)MessageBox.Show("شما  برای این آزمون 3 عکس انتخاب کرده اید \nاگر قصد گرفتن پرینت به صورت پشت و روی برگه دارید بهتر است بعداز صفحه سوم یک صفحه خالی ایجاد شود\nآیا تمایل دارید بعد از صفحه سوم هر دانش آموز یک صفحه خالی ایجاد شود؟", "ایجاد صفحه خالی", (MessageBoxButtons)4, (MessageBoxIcon)32);
					num = 1;
					continue;
				case 1:
					if (!flag)
					{
						num = 15;
						continue;
					}
					goto case 20;
				case 16:
					if (!flag)
					{
						num = 12;
						continue;
					}
					goto case 3;
				case 2:
					num4 = 1;
					goto IL_09a4;
				case 11:
					try
					{
						while (true)
						{
							IL_0630:
							Picture val5 = (Picture)c.Sections["Page6"].Controls["pic6"];
							flag = !(k == "");
							num = 7;
							while (true)
							{
								switch (num)
								{
								case 7:
									if (!flag)
									{
										num = 6;
										continue;
									}
									flag = !(k == "0");
									num = 9;
									continue;
								case 2:
									if (!flag)
									{
										num = 1;
										continue;
									}
									goto case 4;
								case 9:
									if (flag)
									{
										flag = !(k != "");
										num = 2;
									}
									else
									{
										num = 0;
									}
									continue;
								case 1:
									val5.Image = Image.FromFile(k);
									num = 4;
									continue;
								case 6:
									c.Sections["Page6"].Visible = false;
									num = 3;
									continue;
								case 4:
								case 10:
									val5.Dispose();
									num = 8;
									continue;
								case 0:
									c.Sections["Page6"].Controls.Clear();
									val5.Image = null;
									num = 10;
									continue;
								case 3:
								case 8:
									num = 5;
									continue;
								case 5:
									goto end_IL_05fb;
								}
								goto IL_0630;
								continue;
								end_IL_05fb:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					c.DataSource = d;
					c.DataMember = e;
					c.Run(false);
					b.Document = c.Document;
					num = 18;
					continue;
				case 9:
					k = "0";
					num = 26;
					continue;
				case 4:
					c.LoadLayout(Application.StartupPath + "\\1000.rpx");
					c.SetLicense("aisoft,hasan,DD APN 10 C001511,XO9FIFM4KSKEU7HF8WF9");
					num = 25;
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_086d:
							flag = !(h == "");
							num = 7;
							while (true)
							{
								switch (num)
								{
								case 7:
									if (!flag)
									{
										num = 6;
										continue;
									}
									val4 = (Picture)c.Sections["Page3"].Controls["pic3"];
									flag = !(h != "");
									num = 2;
									continue;
								case 2:
									if (!flag)
									{
										num = 0;
										continue;
									}
									val4.Image = null;
									num = 1;
									continue;
								case 0:
									val4.Image = Image.FromFile(h);
									num = 8;
									continue;
								case 1:
								case 8:
									val4.Dispose();
									num = 4;
									continue;
								case 6:
									c.Sections["Page3"].Visible = false;
									num = 5;
									continue;
								case 4:
								case 5:
									num = 3;
									continue;
								case 3:
									goto end_IL_0840;
								}
								goto IL_086d;
								continue;
								end_IL_0840:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 17;
					continue;
				case 28:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 4;
				case 20:
					num = 3;
					continue;
				case 24:
					num = 10;
					continue;
				case 10:
					num4 = ((!(k == "")) ? 1 : 0);
					goto IL_09a4;
				case 22:
					flag = 6 != (int)MessageBox.Show("شما  برای این آزمون 5 عکس انتخاب کرده اید \nاگر قصد گرفتن پرینت به صورت پشت و روی برگه دارید بهتر است بعداز صفحه پنجم یک صفحه خالی ایجاد شود\nآیا تمایل دارید بعد از صفحه پنجم هر دانش آموز یک صفحه خالی ایجاد شود؟", "ایجاد صفحه خالی", (MessageBoxButtons)4, (MessageBoxIcon)32);
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 26;
				case 8:
					num = 0;
					continue;
				case 0:
					num3 = ((!(i == "")) ? 1 : 0);
					goto IL_05be;
				case 18:
					try
					{
						while (true)
						{
							IL_0abe:
							num = 1;
							while (true)
							{
								int num2;
								switch (num)
								{
								case 1:
									num = ((asdu.o == "") ? 2 : 4);
									continue;
								case 4:
									num = 7;
									continue;
								case 7:
									num2 = ((!(asdu.o.Substring(2, 1) == "0")) ? 1 : 0);
									goto IL_0b1f;
								case 2:
									num2 = 0;
									goto IL_0b1f;
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 10;
								case 0:
									flag = !(asdab.n != "1119");
									num = 5;
									continue;
								case 5:
									if (!flag)
									{
										num = 9;
										continue;
									}
									goto case 8;
								case 9:
									MessageBox.Show("امکان پرینت غیر فعال است جهت فعال سازی با شرکت تماس حاصل نمایید");
									b.Toolbar.Tools[2].Visible = false;
									b.Toolbar.Tools[4].Visible = false;
									num = 8;
									continue;
								case 8:
									num = 10;
									continue;
								case 10:
									num = 6;
									continue;
								case 6:
									goto end_IL_0a89;
									IL_0b1f:
									flag = (byte)num2 != 0;
									num = 3;
									continue;
								}
								goto IL_0abe;
								continue;
								end_IL_0a89:
								break;
							}
							break;
						}
					}
					catch
					{
						b.Toolbar.Tools[2].Visible = false;
						b.Toolbar.Tools[4].Visible = false;
						MessageBox.Show("خطای 2");
					}
					d.Dispose();
					num = 19;
					continue;
				case 7:
					num = ((h != "") ? 8 : 14);
					continue;
				case 25:
					try
					{
						while (true)
						{
							IL_0cb0:
							Picture val2 = (Picture)c.Sections["Detail1"].Controls["pic"];
							flag = !(f != "");
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 4;
										continue;
									}
									val2.Image = null;
									num = 1;
									continue;
								case 4:
									val2.Image = Image.FromFile(f);
									num = 2;
									continue;
								case 1:
								case 2:
									val2.Dispose();
									num = 0;
									continue;
								case 0:
									goto end_IL_0c93;
								}
								goto IL_0cb0;
								continue;
								end_IL_0c93:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num = 5;
					continue;
				case 13:
					{
						try
						{
							while (true)
							{
								IL_0d9c:
								flag = !(j == "");
								num = 5;
								while (true)
								{
									switch (num)
									{
									case 5:
										if (!flag)
										{
											num = 7;
											continue;
										}
										val = (Picture)c.Sections["Page5"].Controls["pic5"];
										flag = !(j != "");
										num = 0;
										continue;
									case 0:
										if (!flag)
										{
											num = 3;
											continue;
										}
										val.Image = null;
										num = 2;
										continue;
									case 3:
										val.Image = Image.FromFile(j);
										num = 8;
										continue;
									case 2:
									case 8:
										val.Dispose();
										num = 1;
										continue;
									case 7:
										c.Sections["Page5"].Visible = false;
										num = 6;
										continue;
									case 1:
									case 6:
										num = 4;
										continue;
									case 4:
										goto end_IL_0d6f;
									}
									goto IL_0d9c;
									continue;
									end_IL_0d6f:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						num = 11;
						continue;
					}
					IL_05be:
					flag = (byte)num3 != 0;
					num = 16;
					continue;
					IL_09a4:
					flag = (byte)num4 != 0;
					num = 28;
					continue;
				}
				break;
			}
		}
	}

	public void a(DataSet A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7)
	{
		if (true)
		{
		}
		e = A_1;
		d = A_0;
		f = A_2;
		g = A_3;
		h = A_4;
		i = A_5;
		j = A_6;
		k = A_7;
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		if (true)
		{
		}
		c.Document.Dispose();
		c.Dispose();
		((Component)(object)b).Dispose();
		((Component)this).Dispose();
	}
}
