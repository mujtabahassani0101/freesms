using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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

	private System.Windows.Forms.Button l;

	private System.Windows.Forms.Button m;

	private System.Windows.Forms.Button n;

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
		d();
		this.m_a.Toolbox = this.m_d;
		this.m_c.Report = this.m_a.Report;
		e = this.m_a.CommandBarManager;
		Controls.Add((Control)(object)e);
		CommandBarItem val = e.CommandBars[0].Items[0];
		CommandBarMenu val2 = (CommandBarMenu)(object)((val is CommandBarMenu) ? val : null);
		a(this.m_d);
		this.m_d.SelectedCategory = "kbr";
		k.Panels.Add(new StatusBarPanel());
		k.Panels.Add(new StatusBarPanel());
		k.Panels[0].AutoSize = StatusBarPanelAutoSize.Spring;
		k.Panels[1].AutoSize = StatusBarPanelAutoSize.Spring;
		k.ShowPanels = true;
	}
protected override void Dispose(bool A_0)
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
					base.Dispose(A_0);
					return;
				}
				break;
			}
		}
	}

	private void d()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		if (true)
		{
		}
		this.m_d = new Toolbox();
		f = new Panel();
		n = new System.Windows.Forms.Button();
		m = new System.Windows.Forms.Button();
		l = new System.Windows.Forms.Button();
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
		f.SuspendLayout();
		i.SuspendLayout();
		SuspendLayout();
		this.m_d.Dock = DockStyle.Fill;
		this.m_d.LargeImages = null;
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "arToolbox";
		this.m_d.Selected = null;
		this.m_d.Size = new Size(200, 578);
		this.m_d.SmallImages = null;
		this.m_d.TabIndex = 0;
		f.Controls.Add(n);
		f.Controls.Add(m);
		f.Controls.Add(l);
		f.Controls.Add(this.m_d);
		f.Dock = DockStyle.Left;
		f.Location = new Point(0, 0);
		f.Name = "pnlToolbox";
		f.Size = new Size(200, 578);
		f.TabIndex = 0;
		n.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		n.BackColor = Color.FromArgb(224, 224, 224);
		n.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		n.Location = new Point(13, 406);
		n.Name = "btnSave";
		n.Size = new Size(182, 57);
		n.TabIndex = 9;
		n.Text = "دریافت فایل الگو این طراحی برای اشتراک گزاری ";
		n.UseVisualStyleBackColor = false;
		n.Click += a;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		m.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		m.Location = new Point(13, 530);
		m.Name = "btnClose";
		m.Size = new Size(182, 31);
		m.TabIndex = 8;
		m.Text = "بستن";
		m.UseVisualStyleBackColor = true;
		m.Click += b;
		l.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		l.Font = new Font("B Nazanin", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
		l.Location = new Point(12, 489);
		l.Name = "btnAcp";
		l.Size = new Size(182, 31);
		l.TabIndex = 7;
		l.Text = "ثبت تغییرات";
		l.UseVisualStyleBackColor = true;
		l.Click += c;
		g.BackColor = SystemColors.Control;
		g.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		g.Location = new Point(200, 0);
		g.Name = "splitterToolboxDesigner";
		g.Size = new Size(3, 578);
		g.TabIndex = 1;
		g.TabStop = false;
		((Control)(object)this.m_a).Dock = DockStyle.Fill;
		this.m_a.IsDirty = false;
		((Control)(object)this.m_a).Location = new Point(203, 0);
		this.m_a.LockControls = false;
		((Control)(object)this.m_a).Name = "arDesigner";
		this.m_a.PropertyGrid = this.m_b;
		this.m_a.ReportTabsVisible = true;
		this.m_a.ShowDataSourceIcon = true;
		((Control)(object)this.m_a).Size = new Size(397, 578);
		((Control)(object)this.m_a).TabIndex = 2;
		this.m_a.Toolbox = null;
		this.m_a.ToolBoxItem = null;
		this.m_a.SelectionChanged += c;
		this.m_a.LayoutChanged += a;
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.LineColor = SystemColors.ScrollBar;
		this.m_b.Location = new Point(0, 231);
		this.m_b.Name = "arPropertyGrid";
		this.m_b.Size = new Size(200, 347);
		this.m_b.TabIndex = 2;
		h.BackColor = SystemColors.Control;
		h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		h.Dock = DockStyle.Right;
		h.Location = new Point(597, 0);
		h.Name = "splitterDesignerProperties";
		h.Size = new Size(3, 578);
		h.TabIndex = 3;
		h.TabStop = false;
		i.Controls.Add(this.m_b);
		i.Controls.Add(j);
		i.Controls.Add((Control)(object)this.m_c);
		i.Dock = DockStyle.Right;
		i.Location = new Point(600, 0);
		i.Name = "pnlProperties";
		i.Size = new Size(200, 578);
		i.TabIndex = 4;
		j.Dock = DockStyle.Top;
		j.Location = new Point(0, 228);
		j.Name = "splitterReportExplorerPropertyGrid";
		j.Size = new Size(200, 3);
		j.TabIndex = 1;
		j.TabStop = false;
		((ScrollableControl)(object)this.m_c).AutoScroll = true;
		((Control)(object)this.m_c).Dock = DockStyle.Top;
		((Control)(object)this.m_c).Location = new Point(0, 0);
		((Control)(object)this.m_c).Name = "arReportExplorer";
		this.m_c.ReportDesigner = null;
		((Control)(object)this.m_c).Size = new Size(200, 228);
		((Control)(object)this.m_c).TabIndex = 0;
		k.Location = new Point(0, 578);
		k.Name = "arStatus";
		k.Size = new Size(800, 22);
		k.TabIndex = 5;
		((Control)(object)e).Dock = DockStyle.Top;
		((Control)(object)e).Location = new Point(0, 0);
		((Control)(object)e).Name = "commandBarManager";
		((Control)(object)e).Size = new Size(800, 0);
		((Control)(object)e).TabIndex = 6;
		((Control)(object)e).TabStop = false;
		AutoScaleBaseSize = new Size(5, 13);
		ClientSize = new Size(800, 600);
		ControlBox = false;
		Controls.Add(h);
		Controls.Add((Control)(object)this.m_a);
		Controls.Add(g);
		Controls.Add(f);
		Controls.Add(i);
		Controls.Add(k);
		Controls.Add((Control)(object)e);
		Name = "EndUserDesignerMainForm";
		StartPosition = FormStartPosition.CenterParent;
		Text = "Data Dynamics ActiveReports 3.0 Report Designer";
		WindowState = FormWindowState.Maximized;
		Load += d;
		FormClosing += a;
		((ISupportInitialize)this.m_d).EndInit();
		f.ResumeLayout(performLayout: false);
		i.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	private void a(Toolbox A_0)
	{
	}

	protected virtual bool a(ref Message A_0, Keys A_1)
	{
		bool result = default;
		while (true)
		{
			bool flag = !((Control)(object)this.m_a.CommandBarManager).PreProcessMessage(ref A_0);
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
					result = base.ProcessCmdKey(ref A_0, A_1);
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
					num = ((!k.Created) ? 1 : 7);
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
					switch ((int)type - 9)
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
                    this.m_a.Report.DataSource = s;
                    this.m_c.ReportDesigner = this.m_a;
                    this.m_c.Report = this.m_a.Report;
                    foreach (DataTable table in s.Tables)
                        foreach (DataColumn column in table.Columns)
                            if (!this.m_d.Items.Contains(column.ColumnName)) this.m_d.Items.Add(column.ColumnName);
					b();
					aa = true;
					num = 3;
					continue;
				case 3:
					return;
				case 2:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
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
									using (var pictureImage = Image.FromFile(x)) val2.Image = pictureImage;
									num2 = 4;
									continue;
								case 3:
									using (var pictureImage = Image.FromFile(x)) val2.Image = pictureImage;
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
									// Picture lifetime is owned by the native report.
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
									using (var pictureImage = Image.FromFile(v)) val4.Image = pictureImage;
									num2 = 4;
									continue;
								case 3:
								case 4:
									// Picture lifetime is owned by the native report.
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
									using (var pictureImage = Image.FromFile(y)) val6.Image = pictureImage;
									num2 = 3;
									continue;
								case 2:
								case 3:
									// Picture lifetime is owned by the native report.
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
									using (var pictureImage = Image.FromFile(z)) val5.Image = pictureImage;
									num2 = 2;
									continue;
								case 2:
								case 3:
									// Picture lifetime is owned by the native report.
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
									using (var pictureImage = Image.FromFile(u)) val3.Image = pictureImage;
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
									using (var pictureImage = Image.FromFile(w)) val.Image = pictureImage;
									num2 = 2;
									continue;
								case 1:
								case 2:
									// Picture lifetime is owned by the native report.
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
		fileStream.ReadExactly(array, 0, (int)fileStream.Length);
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
		Close();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
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
					A_1.Cancel = true;
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
					DialogResult dialogResult = DialogResult.None;
					dialogResult = MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید تغییرات ثبت شود؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
					text = dialogResult.ToString().ToLower();
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
		string text = default;
		while (true)
		{
			DialogResult dialogResult = o.ShowDialog();
			bool flag = dialogResult != DialogResult.OK;
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
