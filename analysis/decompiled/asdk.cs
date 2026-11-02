using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Design;
using DataDynamics.ActiveReports.Design.Toolbox;
using DataDynamics.ActiveReports.Document;

public class asdk : Form
{
	private Designer m_a;

	private PropertyGrid m_b;

	private ReportExplorer m_c;

	private Toolbox m_d;

	private CommandBarManager e;

	private Panel f;

	private Splitter g;

	private Splitter h;

	private Panel i;

	private Splitter j;

	private StatusBar k;

	private Button l;

	private Button m;

	private Button n;

	private FolderBrowserDialog o;

	private Container p = null;

	public string q = "";

	public string r = "";

	private DataSet s = new DataSet();

	private string t = "";

	private string u = "";

	private string v = "";

	private string w = "";

	private string x = "";

	private string y = "";

	private string z = "";

	private bool aa = true;

	public asdk()
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		d();
		this.m_a.Toolbox = (IToolboxService)(object)this.m_d;
		this.m_c.Report = this.m_a.Report;
		e = this.m_a.CommandBarManager;
		((Control)this).Controls.Add((Control)(object)e);
		CommandBarItem val = e.CommandBars[0].Items[0];
		CommandBarMenu val2 = (CommandBarMenu)(object)((val is CommandBarMenu) ? val : null);
		a(this.m_d);
		this.m_d.SelectedCategory = "kbr";
		k.Panels.Add(new StatusBarPanel());
		k.Panels.Add(new StatusBarPanel());
		k.Panels[0].AutoSize = (StatusBarPanelAutoSize)2;
		k.Panels[1].AutoSize = (StatusBarPanelAutoSize)2;
		k.ShowPanels = true;
	}

	protected override void a(bool A_0)
	{
		while (true)
		{
			bool flag = !A_0;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 4:
					num = 2;
					continue;
				case 1:
					p.Dispose();
					num = 4;
					continue;
				case 5:
					flag = p == null;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 2:
					((Form)this).Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected Obj, but got Unknown
		if (true)
		{
		}
		this.m_d = new Toolbox();
		f = new Panel();
		n = new Button();
		m = new Button();
		l = new Button();
		g = new Splitter();
		this.m_a = new Designer();
		this.m_b = new PropertyGrid();
		h = new Splitter();
		i = new Panel();
		j = new Splitter();
		this.m_c = new ReportExplorer();
		k = new StatusBar();
		e = new CommandBarManager();
		o = new FolderBrowserDialog();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)f).SuspendLayout();
		((Control)i).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_d).Dock = (DockStyle)5;
		((GroupListbar)this.m_d).LargeImages = null;
		((Control)this.m_d).Location = new Point(0, 0);
		((Control)this.m_d).Name = "arToolbox";
		((GroupListbar)this.m_d).Selected = null;
		((Control)this.m_d).Size = new Size(200, 578);
		((GroupListbar)this.m_d).SmallImages = null;
		((Control)this.m_d).TabIndex = 0;
		((Control)f).Controls.Add((Control)(object)n);
		((Control)f).Controls.Add((Control)(object)m);
		((Control)f).Controls.Add((Control)(object)l);
		((Control)f).Controls.Add((Control)(object)this.m_d);
		((Control)f).Dock = (DockStyle)3;
		((Control)f).Location = new Point(0, 0);
		((Control)f).Name = "pnlToolbox";
		((Control)f).Size = new Size(200, 578);
		((Control)f).TabIndex = 0;
		((Control)n).Anchor = (AnchorStyles)6;
		((Control)n).BackColor = Color.FromArgb(224, 224, 224);
		((Control)n).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)n).Location = new Point(13, 406);
		((Control)n).Name = "btnSave";
		((Control)n).Size = new Size(182, 57);
		((Control)n).TabIndex = 9;
		((Control)n).Text = "دریافت فایل الگو این طراحی برای اشتراک گزاری ";
		((ButtonBase)n).UseVisualStyleBackColor = false;
		((Control)n).Click += a;
		((Control)m).Anchor = (AnchorStyles)6;
		((Control)m).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)m).Location = new Point(13, 530);
		((Control)m).Name = "btnClose";
		((Control)m).Size = new Size(182, 31);
		((Control)m).TabIndex = 8;
		((Control)m).Text = "بستن";
		((ButtonBase)m).UseVisualStyleBackColor = true;
		((Control)m).Click += b;
		((Control)l).Anchor = (AnchorStyles)6;
		((Control)l).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)l).Location = new Point(12, 489);
		((Control)l).Name = "btnAcp";
		((Control)l).Size = new Size(182, 31);
		((Control)l).TabIndex = 7;
		((Control)l).Text = "ثبت تغییرات";
		((ButtonBase)l).UseVisualStyleBackColor = true;
		((Control)l).Click += c;
		((Control)g).BackColor = SystemColors.Control;
		g.BorderStyle = (BorderStyle)2;
		((Control)g).Location = new Point(200, 0);
		((Control)g).Name = "splitterToolboxDesigner";
		((Control)g).Size = new Size(3, 578);
		((Control)g).TabIndex = 1;
		g.TabStop = false;
		((Control)this.m_a).Dock = (DockStyle)5;
		this.m_a.IsDirty = false;
		((Control)this.m_a).Location = new Point(203, 0);
		this.m_a.LockControls = false;
		((Control)this.m_a).Name = "arDesigner";
		this.m_a.PropertyGrid = this.m_b;
		this.m_a.ReportTabsVisible = true;
		this.m_a.ShowDataSourceIcon = true;
		((Control)this.m_a).Size = new Size(397, 578);
		((Control)this.m_a).TabIndex = 2;
		this.m_a.Toolbox = null;
		this.m_a.ToolBoxItem = null;
		this.m_a.SelectionChanged += c;
		this.m_a.LayoutChanged += a;
		((Control)this.m_b).Dock = (DockStyle)5;
		this.m_b.LineColor = SystemColors.ScrollBar;
		((Control)this.m_b).Location = new Point(0, 231);
		((Control)this.m_b).Name = "arPropertyGrid";
		((Control)this.m_b).Size = new Size(200, 347);
		((Control)this.m_b).TabIndex = 2;
		((Control)h).BackColor = SystemColors.Control;
		h.BorderStyle = (BorderStyle)2;
		((Control)h).Dock = (DockStyle)4;
		((Control)h).Location = new Point(597, 0);
		((Control)h).Name = "splitterDesignerProperties";
		((Control)h).Size = new Size(3, 578);
		((Control)h).TabIndex = 3;
		h.TabStop = false;
		((Control)i).Controls.Add((Control)(object)this.m_b);
		((Control)i).Controls.Add((Control)(object)j);
		((Control)i).Controls.Add((Control)(object)this.m_c);
		((Control)i).Dock = (DockStyle)4;
		((Control)i).Location = new Point(600, 0);
		((Control)i).Name = "pnlProperties";
		((Control)i).Size = new Size(200, 578);
		((Control)i).TabIndex = 4;
		((Control)j).Dock = (DockStyle)1;
		((Control)j).Location = new Point(0, 228);
		((Control)j).Name = "splitterReportExplorerPropertyGrid";
		((Control)j).Size = new Size(200, 3);
		((Control)j).TabIndex = 1;
		j.TabStop = false;
		((ScrollableControl)this.m_c).AutoScroll = true;
		((Control)this.m_c).Dock = (DockStyle)1;
		((Control)this.m_c).Location = new Point(0, 0);
		((Control)this.m_c).Name = "arReportExplorer";
		this.m_c.ReportDesigner = null;
		((Control)this.m_c).Size = new Size(200, 228);
		((Control)this.m_c).TabIndex = 0;
		((Control)k).Location = new Point(0, 578);
		((Control)k).Name = "arStatus";
		((Control)k).Size = new Size(800, 22);
		((Control)k).TabIndex = 5;
		((Control)e).Dock = (DockStyle)1;
		((Control)e).Location = new Point(0, 0);
		((Control)e).Name = "commandBarManager";
		((Control)e).Size = new Size(800, 0);
		((Control)e).TabIndex = 6;
		((Control)e).TabStop = false;
		((Form)this).AutoScaleBaseSize = new Size(5, 13);
		((Form)this).ClientSize = new Size(800, 600);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)h);
		((Control)this).Controls.Add((Control)(object)this.m_a);
		((Control)this).Controls.Add((Control)(object)g);
		((Control)this).Controls.Add((Control)(object)f);
		((Control)this).Controls.Add((Control)(object)i);
		((Control)this).Controls.Add((Control)(object)k);
		((Control)this).Controls.Add((Control)(object)e);
		((Control)this).Name = "EndUserDesignerMainForm";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Data Dynamics ActiveReports 3.0 Report Designer";
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).Load += d;
		((Form)this).FormClosing += a;
		((ISupportInitialize)this.m_d).EndInit();
		((Control)f).ResumeLayout(false);
		((Control)i).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void a(Toolbox A_0)
	{
	}

	protected override bool a(ref Message A_0, Keys A_1)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		bool result = default;
		while (true)
		{
			bool flag = !((Control)this.m_a.CommandBarManager).PreProcessMessage(ref A_0);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					result = ((Form)this).ProcessCmdKey(ref A_0, A_1);
					num = 1;
					continue;
				case 3:
					result = true;
					if (true)
					{
					}
					num = 2;
					continue;
				case 1:
				case 2:
					return result;
				}
				break;
			}
		}
	}

	private void c()
	{
		while (true)
		{
			string text = "";
			IEnumerator enumerator = null;
			bool flag = this.m_a.Selection == null;
			int num = 12;
			while (true)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 12:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 11;
				case 8:
				{
					string text6 = text;
					object current5 = enumerator.Current;
					text = text6 + ((Field)((current5 is Field) ? current5 : null)).Name + ", ";
					num = 25;
					continue;
				}
				case 16:
				case 28:
					num = 10;
					continue;
				case 10:
					num = ((enumerator == null) ? 24 : 29);
					continue;
				case 17:
				{
					string text4 = text;
					object current3 = enumerator.Current;
					text = text4 + ((Section)((current3 is Section) ? current3 : null)).Name + ", ";
					num = 13;
					continue;
				}
				case 1:
					num2 = 1;
					goto IL_04aa;
				case 29:
					num = 30;
					continue;
				case 30:
					num3 = (enumerator.MoveNext() ? 1 : 0);
					goto IL_0346;
				case 14:
				{
					string text2 = text;
					object current = enumerator.Current;
					text = text2 + ((Parameter)((current is Parameter) ? current : null)).Key + ", ";
					num = 26;
					continue;
				}
				case 25:
					flag = !(enumerator.Current is Parameter);
					num = 21;
					continue;
				case 21:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 26;
				case 33:
				{
					string text5 = text;
					object current4 = enumerator.Current;
					text = text5 + ((ActiveReport3)((current4 is ActiveReport3) ? current4 : null)).Document.Name + ", ";
					num = 19;
					continue;
				}
				case 24:
					num3 = 0;
					goto IL_0346;
				case 26:
					flag = !(enumerator.Current is ActiveReport3);
					num = 20;
					continue;
				case 20:
					if (!flag)
					{
						num = 33;
						continue;
					}
					goto case 19;
				case 22:
					flag = !(enumerator.Current is Field);
					num = 32;
					continue;
				case 32:
					if (!flag)
					{
						num = 8;
						continue;
					}
					goto case 25;
				case 27:
					num = 3;
					continue;
				case 3:
					num = ((!((Control)k).Created) ? 1 : 7);
					continue;
				case 4:
					flag = !(text != "");
					num = 15;
					continue;
				case 15:
					if (flag)
					{
						k.Panels[1].Text = "No Selection";
						num = 0;
					}
					else
					{
						num = 2;
					}
					continue;
				case 9:
					if (!flag)
					{
						num = 27;
						continue;
					}
					flag = !(enumerator.Current is Section);
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 17;
						continue;
					}
					goto case 13;
				case 11:
					num = 28;
					continue;
				case 13:
					flag = !(enumerator.Current is ARControl);
					num = 35;
					continue;
				case 35:
					if (!flag)
					{
						num = 31;
						continue;
					}
					goto case 22;
				case 34:
					enumerator = this.m_a.Selection.GetEnumerator();
					num = 11;
					continue;
				case 31:
				{
					string text3 = text;
					object current2 = enumerator.Current;
					text = text3 + ((ARControl)((current2 is ARControl) ? current2 : null)).Name + ", ";
					num = 22;
					continue;
				}
				case 7:
					num = 6;
					continue;
				case 6:
					num2 = ((k.Panels[1] == null) ? 1 : 0);
					goto IL_04aa;
				case 2:
					if (true)
					{
					}
					k.Panels[1].Text = "Current Selection: " + text.Substring(0, text.Length - 2);
					num = 36;
					continue;
				case 5:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 23;
				case 0:
				case 36:
					num = 23;
					continue;
				case 19:
					num = 16;
					continue;
				case 23:
					{
						aa = false;
						return;
					}
					IL_0346:
					flag = (byte)num3 != 0;
					num = 9;
					continue;
					IL_04aa:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, LayoutChangedArgs A_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		while (true)
		{
			LayoutChangeType type = A_1.Type;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					switch (type - 9)
					{
					default:
						num = 3;
						break;
					case 0:
					case 1:
						this.m_c.Report = this.m_a.Report;
						if (true)
						{
						}
						num = 2;
						break;
					}
					continue;
				case 4:
					num = 1;
					continue;
				case 3:
					num = 4;
					continue;
				case 1:
				case 2:
					aa = false;
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = asdaj.a("12");
			if (true)
			{
			}
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
					this.m_a.LoadReport(Application.StartupPath + "\\1000.rpx");
					this.m_a.DrawGrid = false;
					((Control)this.m_a.CommandBarManager.CommandBars[0]).Visible = false;
					((Control)this.m_a.CommandBarManager.CommandBars[1]).Visible = false;
					b();
					aa = true;
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		while (true)
		{
			this.m_a.Report.Document.CacheToDisk = true;
			this.m_a.Report.Document.CacheToDiskLocation = "D:\\tmp20";
			this.m_a.Report.DataSource = s;
			this.m_a.Report.DataMember = t;
			float num = float.Parse("0.25");
			this.m_a.Report.PageSettings.Margins = new Margins(num, num, num, num);
			this.m_a.Report.SetLicense("aisoft,hasan,DD APN 10 C001511,XO9FIFM4KSKEU7HF8WF9");
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						while (true)
						{
							IL_0112:
							Picture val2 = (Picture)this.m_a.Report.Sections["Page4"].Controls["pic4"];
							bool flag = !(x != "");
							num2 = 1;
							while (true)
							{
								switch (num2)
								{
								case 1:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									flag = !(x != "");
									num2 = 0;
									continue;
								case 6:
									val2.Image = Image.FromFile(x);
									num2 = 4;
									continue;
								case 3:
									val2.Image = Image.FromFile(x);
									num2 = 2;
									continue;
								case 0:
									if (!flag)
									{
										num2 = 6;
										continue;
									}
									goto case 2;
								case 2:
								case 4:
									val2.Dispose();
									num2 = 5;
									continue;
								case 5:
									goto end_IL_00ed;
								}
								goto IL_0112;
								continue;
								end_IL_00ed:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num2 = 2;
					continue;
				case 3:
					try
					{
						while (true)
						{
							IL_023e:
							Picture val4 = (Picture)this.m_a.Report.Sections["Page2"].Controls["pic2"];
							bool flag = !(v != "");
							if (true)
							{
							}
							num2 = 2;
							while (true)
							{
								switch (num2)
								{
								case 2:
									if (!flag)
									{
										num2 = 1;
										continue;
									}
									val4.Image = null;
									num2 = 3;
									continue;
								case 1:
									val4.Image = Image.FromFile(v);
									num2 = 4;
									continue;
								case 3:
								case 4:
									val4.Dispose();
									num2 = 0;
									continue;
								case 0:
									goto end_IL_0221;
								}
								goto IL_023e;
								continue;
								end_IL_0221:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num2 = 5;
					continue;
				case 2:
					try
					{
						while (true)
						{
							IL_033e:
							Picture val6 = (Picture)this.m_a.Report.Sections["Page5"].Controls["pic5"];
							bool flag = !(y != "");
							num2 = 0;
							while (true)
							{
								switch (num2)
								{
								case 0:
									if (!flag)
									{
										num2 = 1;
										continue;
									}
									val6.Image = null;
									num2 = 2;
									continue;
								case 1:
									val6.Image = Image.FromFile(y);
									num2 = 3;
									continue;
								case 2:
								case 3:
									val6.Dispose();
									num2 = 4;
									continue;
								case 4:
									goto end_IL_0321;
								}
								goto IL_033e;
								continue;
								end_IL_0321:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num2 = 4;
					continue;
				case 4:
					try
					{
						while (true)
						{
							Picture val5 = (Picture)this.m_a.Report.Sections["Page6"].Controls["pic6"];
							bool flag = !(z != "");
							num2 = 0;
							while (true)
							{
								switch (num2)
								{
								case 0:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									val5.Image = null;
									num2 = 3;
									continue;
								case 4:
									val5.Image = Image.FromFile(z);
									num2 = 2;
									continue;
								case 2:
								case 3:
									val5.Dispose();
									num2 = 1;
									continue;
								case 1:
									return;
								}
								break;
							}
						}
					}
					catch
					{
						return;
					}
				case 0:
					try
					{
						while (true)
						{
							IL_051c:
							Picture val3 = (Picture)this.m_a.Report.Sections["Detail1"].Controls["pic"];
							bool flag = !(u != "");
							num2 = 4;
							while (true)
							{
								switch (num2)
								{
								case 4:
									if (!flag)
									{
										num2 = 3;
										continue;
									}
									val3.Image = null;
									num2 = 2;
									continue;
								case 3:
									val3.Image = Image.FromFile(u);
									num2 = 1;
									continue;
								case 1:
								case 2:
									num2 = 0;
									continue;
								case 0:
									goto end_IL_04ff;
								}
								goto IL_051c;
								continue;
								end_IL_04ff:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num2 = 3;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0604:
							Picture val = (Picture)this.m_a.Report.Sections["Page3"].Controls["pic3"];
							bool flag = !(w != "");
							num2 = 3;
							while (true)
							{
								switch (num2)
								{
								case 3:
									if (!flag)
									{
										num2 = 4;
										continue;
									}
									val.Image = null;
									num2 = 1;
									continue;
								case 4:
									val.Image = Image.FromFile(w);
									num2 = 2;
									continue;
								case 1:
								case 2:
									val.Dispose();
									num2 = 0;
									continue;
								case 0:
									goto end_IL_05e7;
								}
								goto IL_0604;
								continue;
								end_IL_05e7:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					num2 = 1;
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
		t = A_1;
		s = A_0;
		u = A_2;
		v = A_3;
		w = A_4;
		x = A_5;
		y = A_6;
		z = A_7;
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.m_a.SaveReport(Application.StartupPath + "\\1000.rpx");
		FileStream fileStream = File.OpenRead(Application.StartupPath + "\\1000.rpx");
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		fileStream.Close();
		SqlParameter[] a_ = new SqlParameter[2]
		{
			asdcb.a("@Rpt", SqlDbType.Image, array),
			asdcb.a("@id", SqlDbType.Int, q)
		};
		asdcb.d(asdab.e(), CommandType.Text, "update tRptDynamic set Rpt=@Rpt where id=@id", a_);
		aa = true;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		while (true)
		{
			bool flag = aa;
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					return;
				case 0:
					((CancelEventArgs)(object)A_1).Cancel = true;
					if (true)
					{
					}
					num = 7;
					continue;
				case 6:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 5;
				case 3:
				{
					DialogResult val = (DialogResult)0;
					val = MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید تغییرات ثبت شود؟", "", (MessageBoxButtons)3, (MessageBoxIcon)32, (MessageBoxDefaultButton)512);
					text = ((object)val).ToString().ToLower();
					flag = !(text == "yes");
					num = 4;
					continue;
				}
				case 4:
					if (flag)
					{
						flag = !(text == "cancel");
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				case 5:
				case 7:
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					c(this, null);
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		string text = default;
		while (true)
		{
			DialogResult val = ((CommonDialog)o).ShowDialog();
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
				case 1:
					if (true)
					{
					}
					flag = !(o.SelectedPath != "");
					num = 3;
					continue;
				case 6:
					try
					{
						string arguments = "/select, \"" + text + "\"";
						Process.Start("explorer.exe", arguments);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 3:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 5:
					num = 0;
					continue;
				case 0:
					return;
				case 2:
					text = o.SelectedPath + "\\" + a();
					this.m_a.SaveReport(text);
					MessageBox.Show("فایل در مسیر انتخابی شما ساخته شد");
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	private string a()
	{
		string result = default;
		while (true)
		{
			string text = "kbr";
			bool flag = !(r == "1");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 10;
						continue;
					}
					flag = !(r == "2");
					num = 0;
					continue;
				case 13:
					text += "rdefgy-";
					num = 29;
					continue;
				case 25:
					text += "tfcefv-";
					num = 8;
					continue;
				case 4:
					if (!flag)
					{
						num = 26;
						continue;
					}
					flag = !(r == "4");
					num = 11;
					continue;
				case 28:
					text += "mbbvdc-";
					num = 22;
					continue;
				case 20:
					text += "edcrfv-";
					num = 5;
					continue;
				case 21:
					if (!flag)
					{
						if (true)
						{
						}
						num = 13;
					}
					else
					{
						flag = !(r == "8");
						num = 15;
					}
					continue;
				case 2:
					text += "nmjhui-";
					num = 16;
					continue;
				case 14:
					if (!flag)
					{
						num = 25;
						continue;
					}
					flag = !(r == "7");
					num = 17;
					continue;
				case 26:
					text += "tgbyhn-";
					num = 24;
					continue;
				case 12:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 3;
				case 3:
				case 5:
				case 6:
				case 8:
				case 9:
				case 16:
				case 22:
				case 23:
				case 24:
				case 29:
					text = string.Concat(text, Guid.NewGuid(), ".rpx");
					result = text;
					num = 18;
					continue;
				case 30:
					if (flag)
					{
						flag = !(r == "6");
						num = 14;
					}
					else
					{
						num = 19;
					}
					continue;
				case 10:
					text += "qazwsx-";
					num = 6;
					continue;
				case 11:
					if (flag)
					{
						flag = !(r == "5");
						num = 30;
					}
					else
					{
						num = 7;
					}
					continue;
				case 0:
					if (flag)
					{
						flag = !(r == "3");
						num = 4;
					}
					else
					{
						num = 20;
					}
					continue;
				case 19:
					text += "olpkio-";
					num = 3;
					continue;
				case 15:
					if (flag)
					{
						flag = !(r == "9");
						num = 12;
					}
					else
					{
						num = 28;
					}
					continue;
				case 27:
					text += "sdfdfv-";
					num = 23;
					continue;
				case 7:
					text += "ujmiko-";
					num = 9;
					continue;
				case 17:
					if (flag)
					{
						flag = !(r == "8");
						num = 21;
					}
					else
					{
						num = 27;
					}
					continue;
				case 18:
					return result;
				}
				break;
			}
		}
	}
}
