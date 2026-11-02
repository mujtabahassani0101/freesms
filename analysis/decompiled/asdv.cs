using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdv : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private UIButton m_c;

	private GridEX m_d;

	private Button m_e;

	private Button f;

	private OpenFileDialog g;

	private Label h;

	private TextBox i;

	private Label j;

	private UIComboBox k;

	private Label l;

	private NumericEditBox m;

	private NumericEditBox n;

	private Label o;

	private Label p;

	private Label q;

	private SqlConnection r = new SqlConnection(asdab.e());

	private string s = "";

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
					if (A_0)
					{
						if (true)
						{
						}
						num = 6;
					}
					else
					{
						num = 1;
					}
					continue;
				case 6:
					num = 5;
					continue;
				case 5:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 0:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got Unknown
		if (true)
		{
		}
		StringFormat val = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdv));
		GridEXLayout val2 = new GridEXLayout();
		this.m_b = new Panel();
		l = new Label();
		m = new NumericEditBox();
		n = new NumericEditBox();
		o = new Label();
		j = new Label();
		k = new UIComboBox();
		h = new Label();
		i = new TextBox();
		f = new Button();
		this.m_e = new Button();
		this.m_c = new UIButton();
		this.m_d = new GridEX();
		g = new OpenFileDialog();
		p = new Label();
		q = new Label();
		((Control)this.m_b).SuspendLayout();
		((ISupportInitialize)this.m_d).BeginInit();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)p);
		((Control)this.m_b).Controls.Add((Control)(object)q);
		((Control)this.m_b).Controls.Add((Control)(object)l);
		((Control)this.m_b).Controls.Add((Control)(object)m);
		((Control)this.m_b).Controls.Add((Control)(object)n);
		((Control)this.m_b).Controls.Add((Control)(object)o);
		((Control)this.m_b).Controls.Add((Control)(object)j);
		((Control)this.m_b).Controls.Add((Control)(object)k);
		((Control)this.m_b).Controls.Add((Control)(object)h);
		((Control)this.m_b).Controls.Add((Control)(object)i);
		((Control)this.m_b).Controls.Add((Control)(object)f);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_b).Dock = (DockStyle)5;
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f);
		((Control)this.m_b).Location = new Point(0, 0);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(798, 598);
		((Control)this.m_b).TabIndex = 0;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(306, 571);
		((Control)l).Name = "label4";
		((Control)l).Size = new Size(20, 13);
		((Control)l).TabIndex = 47;
		((Control)l).Text = "تا :";
		((EditBase)m).AutoScroll = false;
		((EditBase)m).AutoScrollMargin = new Size(0, 0);
		((EditBase)m).AutoScrollMinSize = new Size(0, 0);
		((EditBase)m).AutoScrollPosition = new Point(0, 0);
		((Control)m).Enabled = false;
		((Control)m).Location = new Point(248, 568);
		((Control)m).Name = "txtMaxMark";
		((Control)m).Size = new Size(52, 21);
		((Control)m).TabIndex = 46;
		((Control)m).Text = "100";
		((EditBase)m).TextAlignment = (TextAlignment)1;
		m.Value = (short)100;
		m.ValueType = (NumericEditValueType)7;
		((EditBase)n).AutoScroll = false;
		((EditBase)n).AutoScrollMargin = new Size(0, 0);
		((EditBase)n).AutoScrollMinSize = new Size(0, 0);
		((EditBase)n).AutoScrollPosition = new Point(0, 0);
		((Control)n).Enabled = false;
		((Control)n).Location = new Point(248, 541);
		((Control)n).Name = "txtMinMark";
		((Control)n).Size = new Size(52, 21);
		((Control)n).TabIndex = 45;
		((Control)n).Text = "0";
		((EditBase)n).TextAlignment = (TextAlignment)1;
		n.Value = (short)0;
		n.ValueType = (NumericEditValueType)7;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(306, 542);
		((Control)o).Name = "label3";
		((Control)o).Size = new Size(62, 13);
		((Control)o).TabIndex = 44;
		((Control)o).Text = "رنج نمره از :";
		((Control)j).Anchor = (AnchorStyles)9;
		((Control)j).AutoSize = true;
		((Control)j).Location = new Point(720, 547);
		((Control)j).Name = "label2";
		((Control)j).Size = new Size(26, 13);
		((Control)j).TabIndex = 43;
		((Control)j).Text = "دوره";
		((Control)k).Anchor = (AnchorStyles)9;
		((UIComboBase)k).ComboStyle = (ComboStyle)1;
		((UIComboBase)k).DropListFont = new Font("Tahoma", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)k).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)k).Location = new Point(513, 543);
		((Control)k).Name = "dropExam";
		((Control)k).Size = new Size(201, 23);
		val.Alignment = (StringAlignment)0;
		val.FormatFlags = (StringFormatFlags)20485;
		val.HotkeyPrefix = (HotkeyPrefix)0;
		val.LineAlignment = (StringAlignment)1;
		val.Trimming = (StringTrimming)1;
		((UIComboBase)k).StringFormat = val;
		((Control)k).TabIndex = 42;
		k.SelectedIndexChanged += a;
		((Control)h).AutoSize = true;
		((Control)h).Font = new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)h).ForeColor = Color.Red;
		((Control)h).Location = new Point(171, 45);
		((Control)h).Name = "label1";
		((Control)h).Size = new Size(279, 16);
		((Control)h).TabIndex = 41;
		((Control)h).Text = "نمونه فایل اکسل در مسیر زیر موجود میباشد";
		((Control)i).Location = new Point(12, 67);
		((Control)i).Name = "txtExam";
		((TextBoxBase)i).ReadOnly = true;
		((Control)i).RightToLeft = (RightToLeft)0;
		((Control)i).Size = new Size(440, 21);
		((Control)i).TabIndex = 40;
		((Control)f).Anchor = (AnchorStyles)9;
		((Control)f).Location = new Point(573, 48);
		((Control)f).Name = "BtnNew";
		((Control)f).Size = new Size(197, 35);
		((Control)f).TabIndex = 19;
		((Control)f).Text = "انتخاب فایل اکسل";
		((ButtonBase)f).UseVisualStyleBackColor = true;
		((Control)f).Click += d;
		((Control)this.m_e).Anchor = (AnchorStyles)10;
		((Control)this.m_e).Location = new Point(405, 541);
		((Control)this.m_e).Name = "btnAcp";
		((Control)this.m_e).Size = new Size(102, 27);
		((Control)this.m_e).TabIndex = 18;
		((Control)this.m_e).Text = "ثبت";
		((ButtonBase)this.m_e).UseVisualStyleBackColor = true;
		((Control)this.m_e).Click += c;
		((Control)this.m_c).Anchor = (AnchorStyles)6;
		this.m_c.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_c.ImageSize = new Size(40, 40);
		((Control)this.m_c).Location = new Point(11, 533);
		((Control)this.m_c).Name = "btnClose";
		((Control)this.m_c).Size = new Size(189, 35);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "بستن";
		((Control)this.m_c).Click += e;
		((Control)this.m_d).Anchor = (AnchorStyles)15;
		val2.LayoutString = componentResourceManager.GetString("gridEXLayout2.LayoutString");
		this.m_d.DesignTimeLayout = val2;
		this.m_d.EditorsControlStyle.ButtonAppearance = (ButtonAppearance)0;
		this.m_d.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f);
		this.m_d.GroupByBoxVisible = false;
		((Control)this.m_d).Location = new Point(8, 99);
		((Control)this.m_d).Name = "gridEX1";
		((ScrollableBase)this.m_d).RecordNavigator = true;
		this.m_d.RowHeaders = (InheritableBoolean)1;
		this.m_d.SelectedFormatStyle.BackColor = Color.Empty;
		this.m_d.SelectedFormatStyle.ForeColor = Color.Empty;
		((Control)this.m_d).Size = new Size(780, 385);
		((Control)this.m_d).TabIndex = 5;
		((ScrollableBase)this.m_d).VisualStyle = (VisualStyle)2;
		((FileDialog)g).Filter = "اکسل 2003 |*.xls";
		p.BorderStyle = (BorderStyle)1;
		((Control)p).Location = new Point(646, 505);
		((Control)p).Name = "lYear";
		((Control)p).Size = new Size(68, 24);
		((Control)p).TabIndex = 120;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(720, 508);
		((Control)q).Name = "label6";
		((Control)q).Size = new Size(66, 13);
		((Control)q).TabIndex = 119;
		((Control)q).Text = "سال تعلیمی";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(798, 598);
		((Control)this).Controls.Add((Control)(object)this.m_b);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).KeyPreview = true;
		((Control)this).Name = "frmImportMark";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "ثبت نمرات دوره از فایل اکسل";
		((Form)this).Load += b;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((ISupportInitialize)this.m_d).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public asdv()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		b();
	}

	private void e(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between I4 and Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		string text = default;
		bool flag4 = default;
		int num2 = default;
		bool flag3 = default;
		string text3 = default;
		OleDbConnection val = default;
		OleDbDataAdapter val2 = default;
		DataSet dataSet = default;
		bool flag2 = default;
		while (true)
		{
			bool flag = 1 != (int)((CommonDialog)g).ShowDialog();
			int num = 25;
			while (true)
			{
				switch (num)
				{
				case 25:
					if (!flag)
					{
						num = 8;
						continue;
					}
					return;
				case 30:
					text += "\nفیلد نمره وجود ندارد(mark)";
					num = 11;
					continue;
				case 24:
					text += "\nفیلد کد متعلم وجود ندارد(Code)";
					num = 15;
					continue;
				case 0:
					if (!flag)
					{
						num = 33;
						continue;
					}
					goto case 9;
				case 3:
					flag = flag4;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 11;
				case 9:
					num2++;
					num = 10;
					continue;
				case 21:
					text = "";
					flag = flag3;
					num = 12;
					continue;
				case 12:
					if (!flag)
					{
						num = 24;
						continue;
					}
					goto case 15;
				case 17:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 2;
				case 33:
					this.m_d.RootTable.Columns[num2].Width = 200;
					num = 9;
					continue;
				case 28:
				{
					GridEXFormatCondition val3 = new GridEXFormatCondition(this.m_d.RootTable.Columns["acp"], (ConditionOperator)0, (object)"1");
					val3.FormatStyle.ForeColor = SystemColors.WindowText;
					val3.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
					this.m_d.RootTable.FormatConditions.Add(val3);
					GridEXFormatCondition val4 = new GridEXFormatCondition(this.m_d.RootTable.Columns["acp"], (ConditionOperator)0, (object)"-1");
					val4.FormatStyle.ForeColor = SystemColors.WindowText;
					val4.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
					this.m_d.RootTable.FormatConditions.Add(val4);
					num = 6;
					continue;
				}
				case 6:
					return;
				case 14:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 31;
				case 8:
					text3 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ((FileDialog)g).FileName + ";Extended Properties=Excel 12.0;";
					val = new OleDbConnection(text3);
					num = 27;
					continue;
				case 5:
					try
					{
						((DataAdapter)(object)val2).Fill(dataSet);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
					dataSet.Tables[0].Columns.Add("status");
					dataSet.Tables[0].Columns.Add("acp");
					flag3 = false;
					flag2 = false;
					flag4 = false;
					num2 = 0;
					num = 35;
					continue;
				case 2:
					flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "codedars");
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "mark");
						num = 14;
					}
					else
					{
						num = 19;
					}
					continue;
				case 11:
					flag = !(text != "");
					num = 34;
					continue;
				case 34:
					if (flag)
					{
						this.m_d.DataSource = dataSet.Tables[0];
						((CollectionBase)(object)this.m_d.RootTable.Columns).Clear();
						string text2 = "";
						num2 = 0;
						num = 29;
					}
					else
					{
						num = 20;
					}
					continue;
				case 16:
					flag4 = true;
					num = 31;
					continue;
				case 19:
					flag2 = true;
					num = 36;
					continue;
				case 15:
					flag = flag2;
					num = 26;
					continue;
				case 26:
					if (!flag)
					{
						num = 22;
						continue;
					}
					goto case 3;
				case 7:
					flag3 = true;
					num = 2;
					continue;
				case 20:
					MessageBox.Show(text);
					num = 32;
					continue;
				case 32:
					if (1 == 0)
					{
					}
					return;
				case 31:
				case 36:
					num2++;
					num = 23;
					continue;
				case 23:
				case 35:
					flag = num2 < dataSet.Tables[0].Columns.Count;
					num = 18;
					continue;
				case 18:
					if (flag)
					{
						flag = !(dataSet.Tables[0].Columns[num2].Caption.ToLower() == "code");
						num = 17;
					}
					else
					{
						num = 21;
					}
					continue;
				case 27:
					try
					{
						((DbConnection)(object)val).Open();
						((DbConnection)(object)val).Close();
					}
					catch
					{
						text3 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ((FileDialog)g).FileName + ";Extended Properties=Excel 8.0;";
					}
					val2 = new OleDbDataAdapter("select * from [Sheet1$]", text3);
					dataSet = new DataSet();
					num = 5;
					continue;
				case 10:
				case 29:
					flag = num2 < dataSet.Tables[0].Columns.Count;
					num = 1;
					continue;
				case 1:
					if (flag)
					{
						string text2 = dataSet.Tables[0].Columns[num2].Caption.ToLower();
						this.m_d.RootTable.Columns.Add(text2, (ColumnType)0);
						this.m_d.RootTable.Columns[num2].AllowSort = false;
						flag = !(text2 == "status");
						num = 0;
					}
					else
					{
						num = 28;
					}
					continue;
				case 22:
					text += "\nفیلد کد درس وجود ندارد(codedars)";
					num = 3;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tExam where term in(0,1,2) and xYear=" + ((Control)p).Text + " union select 1000000,N'دوره را انتخاب کنید' order by id desc");
			k.DataSource = dataSource;
			k.DisplayMember = "Name";
			k.ValueMember = "id";
			bool flag = ((CollectionBase)(object)k.Items).Count <= 0;
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
					k.SelectedIndex = 0;
					num = 2;
					continue;
				case 2:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected Obj, but got Unknown
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		SqlCommand val = default;
		int num13 = default;
		int num8 = default;
		int num2 = default;
		string text4 = default;
		string text = default;
		string text2 = default;
		float num5 = default;
		float num6 = default;
		int num7 = default;
		int num3 = default;
		int num4 = default;
		while (true)
		{
			bool flag = k.SelectedIndex > 0;
			int num = 20;
			while (true)
			{
				int num9;
				switch (num)
				{
				case 20:
					if (!flag)
					{
						num = 25;
						continue;
					}
					val = null;
					num = 31;
					continue;
				case 10:
				case 35:
					num = 36;
					continue;
				case 2:
					flag = (int)MessageBox.Show("آيا از انتقال نمرات به  " + k.SelectedItem.Text + " مطمئن هستيد؟", "", (MessageBoxButtons)4, (MessageBoxIcon)48) != 6;
					num = 41;
					continue;
				case 41:
					if (!flag)
					{
						num = 8;
						continue;
					}
					return;
				case 30:
					flag = ((DbConnection)(object)r).State == ConnectionState.Open;
					num = 39;
					continue;
				case 39:
					if (!flag)
					{
						num = 16;
						continue;
					}
					goto case 3;
				case 17:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = num13 >= 1;
					num = 22;
					continue;
				case 33:
					num = 13;
					continue;
				case 13:
					num9 = ((!(s == "2")) ? 1 : 0);
					goto IL_05a9;
				case 16:
					((DbConnection)(object)r).Open();
					num = 3;
					continue;
				case 4:
					((DbConnection)(object)r).Open();
					num = 23;
					continue;
				case 22:
					if (!flag)
					{
						num = 24;
						continue;
					}
					num8++;
					num = 10;
					continue;
				case 37:
					num = 0;
					continue;
				case 24:
					num = 35;
					continue;
				case 3:
					val = new SqlCommand("UPDATE tExam SET procc = 0 WHERE term=3 and xYear=" + ((Control)p).Text, r);
					((DbCommand)(object)val).ExecuteNonQuery();
					num = 2;
					continue;
				case 29:
					num = (flag ? 27 : 7);
					continue;
				case 9:
					this.m_d.GetRow(num2).BeginEdit();
					this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
					this.m_d.GetRow(num2).Cells["status"].Value = "کد درس خالی است";
					this.m_d.GetRow(num2).EndEdit();
					num = 34;
					continue;
				case 21:
					if (!flag)
					{
						num = 30;
						continue;
					}
					goto case 2;
				case 42:
					if (flag)
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "1";
						this.m_d.GetRow(num2).Cells["status"].Value = "";
						this.m_d.GetRow(num2).EndEdit();
						val = new SqlCommand("sp_tMark_insertUpdate_FromXls_Af", r);
						((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
						val.Parameters.Add("@err", SqlDbType.NVarChar, 100);
						val.Parameters.AddWithValue("@xuser", (object)asdaj.l);
						val.Parameters.AddWithValue("@code", (object)text);
						val.Parameters.AddWithValue("@Xtest", (object)k.SelectedValue.ToString());
						val.Parameters.AddWithValue("@xYear", (object)((Control)p).Text);
						val.Parameters.AddWithValue("@codedars", (object)text2);
						val.Parameters.AddWithValue("@mark", (object)text4);
						((DbParameter)(object)val.Parameters[0]).Direction = ParameterDirection.Output;
						num13 = ((DbCommand)(object)val).ExecuteNonQuery();
						flag = !(((DbParameter)(object)val.Parameters[0]).Value.ToString() != "");
						num = 17;
					}
					else
					{
						num = 37;
					}
					continue;
				case 38:
					try
					{
						int num12 = int.Parse(text2);
					}
					catch
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_d.GetRow(num2).Cells["status"].Value = "کد درس اشتباه است";
						this.m_d.GetRow(num2).EndEdit();
						goto case 0;
					}
					num = 14;
					continue;
				case 7:
					this.m_d.GetRow(num2).BeginEdit();
					this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
					this.m_d.GetRow(num2).Cells["status"].Value = "کد متعلم خالی است";
					this.m_d.GetRow(num2).EndEdit();
					num = 18;
					continue;
				case 27:
					try
					{
						long num11 = long.Parse(text);
					}
					catch
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_d.GetRow(num2).Cells["status"].Value = "کد متعلم اشتباه است";
						this.m_d.GetRow(num2).EndEdit();
						goto case 0;
					}
					flag = !(text2 == "");
					num = 11;
					continue;
				case 1:
				case 15:
					flag = num2 < this.m_d.RowCount;
					if (true)
					{
					}
					num = 26;
					continue;
				case 26:
					if (flag)
					{
						text = "";
						text2 = "";
						string text3 = "";
						text4 = "";
						num5 = 0f;
						num6 = 0f;
						num5 = 0f;
						num6 = 0f;
						num7 = 0;
						text = asdaj.b(this.m_d.GetRow(num2).Cells["code"].Value.ToString());
						text2 = asdaj.b(this.m_d.GetRow(num2).Cells["codedars"].Value.ToString());
						flag = !(text == "");
						num = 29;
					}
					else
					{
						num = 6;
					}
					continue;
				case 23:
					val = new SqlCommand("UPDATE tExam SET procc = 0 WHERE  (id = " + k.SelectedValue.ToString() + ")", r);
					((DbCommand)(object)val).ExecuteNonQuery();
					num2 = 0;
					num = 15;
					continue;
				case 14:
					try
					{
						while (true)
						{
							IL_0890:
							flag = !(this.m_d.GetRow(num2).Cells["mark"].Text != "");
							num = 6;
							while (true)
							{
								int num10;
								switch (num)
								{
								case 8:
									goto end_IL_0857;
								case 6:
									if (!flag)
									{
										num = 10;
										continue;
									}
									text4 = null;
									num = 1;
									continue;
								case 4:
									num = 7;
									continue;
								case 7:
									num10 = ((!(num5 < (float)num3)) ? 1 : 0);
									goto IL_08ff;
								case 5:
									if (!flag)
									{
										num = 2;
										continue;
									}
									text4 = num5.ToString();
									num6 += num5;
									num7++;
									num = 9;
									continue;
								case 2:
									this.m_d.GetRow(num2).BeginEdit();
									this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
									this.m_d.GetRow(num2).Cells["status"].Value = "نمره خارج از محدوده است";
									this.m_d.GetRow(num2).EndEdit();
									num = 11;
									continue;
								case 11:
									goto end_IL_0855;
								case 0:
									num10 = 0;
									goto IL_08ff;
								case 10:
									num5 = float.Parse(this.m_d.GetRow(num2).Cells["mark"].Text.ToString());
									num = 3;
									continue;
								case 3:
									num = ((!(num5 > (float)num4)) ? 4 : 0);
									continue;
								case 1:
								case 9:
									{
										num = 8;
										continue;
									}
									IL_08ff:
									flag = (byte)num10 != 0;
									num = 5;
									continue;
								}
								goto IL_0890;
								continue;
								end_IL_0857:
								break;
							}
							break;
						}
						goto IL_05d3;
						end_IL_0855:;
					}
					catch
					{
						this.m_d.GetRow(num2).BeginEdit();
						this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
						this.m_d.GetRow(num2).Cells["status"].Value = "نمره اشتباه است";
						this.m_d.GetRow(num2).EndEdit();
					}
					goto case 0;
				case 0:
				case 18:
				case 19:
				case 34:
				case 36:
					num2++;
					num = 1;
					continue;
				case 11:
					num = ((!flag) ? 9 : 38);
					continue;
				case 31:
					num = ((s == "1") ? 40 : 33);
					continue;
				case 25:
					MessageBox.Show("دوره را انتخاب کنید");
					((UIComboBase)k).Focus();
					num = 32;
					continue;
				case 32:
					return;
				case 40:
					num9 = 0;
					goto IL_05a9;
				case 8:
				{
					num3 = int.Parse(((Control)n).Text);
					num4 = int.Parse(((Control)m).Text);
					text = "";
					text2 = "";
					string text3 = "";
					text4 = "";
					num5 = 0f;
					num6 = 0f;
					num7 = 0;
					num8 = 0;
					flag = ((DbConnection)(object)r).State == ConnectionState.Open;
					num = 28;
					continue;
				}
				case 28:
					if (!flag)
					{
						num = 4;
						continue;
					}
					goto case 23;
				case 5:
					this.m_d.GetRow(num2).BeginEdit();
					this.m_d.GetRow(num2).Cells["acp"].Value = "-1";
					this.m_d.GetRow(num2).Cells["status"].Value = ((DbParameter)(object)val.Parameters[0]).Value.ToString();
					this.m_d.GetRow(num2).EndEdit();
					num = 19;
					continue;
				case 6:
					((DbConnection)(object)r).Close();
					this.m_d.Refetch();
					MessageBox.Show("انجام شد");
					num = 12;
					continue;
				case 12:
					return;
					IL_05d3:
					flag = num7 != 0;
					num = 42;
					continue;
					IL_05a9:
					flag = (byte)num9 != 0;
					num = 21;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					if (true)
					{
					}
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 6;
					continue;
				case 1:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_b).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 2:
					((Control)p).Text = asdaj.a;
					((Control)i).Text = Application.StartupPath + "\\xls\\ExampleMark.xls";
					a();
					num = 7;
					continue;
				case 7:
					return;
				case 3:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", (MessageBoxButtons)0, (MessageBoxIcon)16);
					((Form)this).Close();
					num = 0;
					continue;
				case 0:
					return;
				case 5:
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = k.SelectedIndex <= 0;
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (!flag)
					{
						num = 0;
						continue;
					}
					return;
				case 1:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 2;
				case 3:
					((Control)m).Text = "60";
					num = 6;
					continue;
				case 5:
					((Control)m).Text = "40";
					num = 2;
					continue;
				case 2:
				case 6:
				case 11:
					num = 10;
					continue;
				case 10:
					return;
				case 0:
					if (true)
					{
					}
					s = asdcb.a(asdab.e(), CommandType.Text, "select term from tExam where id=" + k.SelectedValue.ToString()).ToString();
					flag = !(s == "1");
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 5;
						continue;
					}
					flag = !(s == "2");
					num = 4;
					continue;
				case 7:
					((Control)m).Text = "100";
					num = 11;
					continue;
				case 4:
					if (flag)
					{
						flag = !(s == "0");
						num = 1;
					}
					else
					{
						num = 3;
					}
					continue;
				}
				break;
			}
		}
	}
}
