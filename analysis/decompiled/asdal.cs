using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

public class asdal : Form
{
	private IContainer m_a = null;

	private Button m_b;

	private Button m_c;

	private Button m_d;

	private Panel m_e;

	private Button m_f;

	private Panel m_g;

	private Button m_h;

	private Panel m_i;

	private NumericUpDown m_j;

	private NumericUpDown m_k;

	private NumericUpDown m_l;

	private NumericUpDown m_m;

	private Label m_n;

	private Label o;

	private Label p;

	private Label q;

	private GroupBox r;

	private Panel s;

	private Label t;

	private Label u;

	private ComboBox v;

	private ComboBox w;

	private ComboBox x;

	private ComboBox y;

	private GroupBox z;

	private GroupBox aa;

	private TextBox ab;

	private Button ac;

	private Label ad;

	private Label ae;

	private bool af;

	private bool ag;

	private string ah = "";

	private bool ai;

	private bool aj;

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 3:
					if (A_0)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						num = 2;
					}
					continue;
				case 1:
					num = 4;
					continue;
				case 4:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 6;
					continue;
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 6;
				case 2:
					num2 = 1;
					goto IL_007c;
				case 6:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void f()
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected Obj, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected Obj, but got Unknown
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1259: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdal));
		this.m_b = new Button();
		this.m_c = new Button();
		this.m_d = new Button();
		this.m_e = new Panel();
		this.m_f = new Button();
		this.m_g = new Panel();
		this.m_i = new Panel();
		z = new GroupBox();
		ad = new Label();
		ae = new Label();
		w = new ComboBox();
		x = new ComboBox();
		y = new ComboBox();
		v = new ComboBox();
		aa = new GroupBox();
		ac = new Button();
		ab = new TextBox();
		u = new Label();
		t = new Label();
		r = new GroupBox();
		this.m_j = new NumericUpDown();
		q = new Label();
		this.m_m = new NumericUpDown();
		this.m_n = new Label();
		this.m_l = new NumericUpDown();
		o = new Label();
		this.m_k = new NumericUpDown();
		p = new Label();
		this.m_h = new Button();
		s = new Panel();
		((Control)this.m_g).SuspendLayout();
		((Control)this.m_i).SuspendLayout();
		((Control)z).SuspendLayout();
		((Control)aa).SuspendLayout();
		((Control)r).SuspendLayout();
		((ISupportInitialize)this.m_j).BeginInit();
		((ISupportInitialize)this.m_m).BeginInit();
		((ISupportInitialize)this.m_l).BeginInit();
		((ISupportInitialize)this.m_k).BeginInit();
		((Control)s).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_b).Location = new Point(7, 4);
		((Control)this.m_b).Name = "btnCreate";
		((Control)this.m_b).Size = new Size(89, 53);
		((Control)this.m_b).TabIndex = 0;
		((Control)this.m_b).Text = "پیش نمایش ";
		((ButtonBase)this.m_b).UseVisualStyleBackColor = true;
		((Control)this.m_b).Click += n;
		((Control)this.m_c).Location = new Point(3, 192);
		((Control)this.m_c).Name = "button2";
		((Control)this.m_c).Size = new Size(85, 23);
		((Control)this.m_c).TabIndex = 1;
		((Control)this.m_c).Text = "ویرایش گزارش";
		((ButtonBase)this.m_c).UseVisualStyleBackColor = true;
		((Control)this.m_c).Click += m;
		((Control)this.m_d).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_d).Location = new Point(7, 180);
		((Control)this.m_d).Name = "button3";
		((Control)this.m_d).Size = new Size(85, 23);
		((Control)this.m_d).TabIndex = 2;
		((Control)this.m_d).Text = "نمايش گزارش";
		((ButtonBase)this.m_d).UseVisualStyleBackColor = true;
		((Control)this.m_d).Visible = false;
		((Control)this.m_d).Click += l;
		((ScrollableControl)this.m_e).AutoScroll = true;
		((Control)this.m_e).BackColor = Color.FromArgb(255, 224, 192);
		this.m_e.BorderStyle = (BorderStyle)1;
		((Control)this.m_e).Location = new Point(-1, 221);
		((Control)this.m_e).Name = "panel1";
		((Control)this.m_e).Size = new Size(799, 387);
		((Control)this.m_e).TabIndex = 17;
		((Control)this.m_f).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_f).Location = new Point(7, 63);
		((Control)this.m_f).Name = "btnAcp";
		((Control)this.m_f).Size = new Size(89, 55);
		((Control)this.m_f).TabIndex = 18;
		((Control)this.m_f).Text = "ثبت تغییرات";
		((ButtonBase)this.m_f).UseVisualStyleBackColor = true;
		((Control)this.m_f).Click += j;
		((Control)this.m_g).BackColor = SystemColors.GradientActiveCaption;
		this.m_g.BorderStyle = (BorderStyle)1;
		((Control)this.m_g).Controls.Add((Control)(object)this.m_i);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_h);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_b);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_f);
		((Control)this.m_g).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_g).Location = new Point(4, 4);
		((Control)this.m_g).Name = "panel2";
		((Control)this.m_g).Size = new Size(793, 632);
		((Control)this.m_g).TabIndex = 19;
		((Control)this.m_i).Controls.Add((Control)(object)z);
		((Control)this.m_i).Controls.Add((Control)(object)aa);
		((Control)this.m_i).Controls.Add((Control)(object)u);
		((Control)this.m_i).Controls.Add((Control)(object)t);
		((Control)this.m_i).Controls.Add((Control)(object)r);
		((Control)this.m_i).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_i).Location = new Point(102, 0);
		((Control)this.m_i).Name = "panel3";
		((Control)this.m_i).RightToLeft = (RightToLeft)1;
		((Control)this.m_i).Size = new Size(686, 215);
		((Control)this.m_i).TabIndex = 103;
		((Control)z).Controls.Add((Control)(object)ad);
		((Control)z).Controls.Add((Control)(object)ae);
		((Control)z).Controls.Add((Control)(object)w);
		((Control)z).Controls.Add((Control)(object)x);
		((Control)z).Controls.Add((Control)(object)y);
		((Control)z).Controls.Add((Control)(object)v);
		((Control)z).Location = new Point(6, 4);
		((Control)z).Name = "groupBox2";
		((Control)z).Size = new Size(200, 167);
		((Control)z).TabIndex = 14;
		z.TabStop = false;
		((Control)z).Text = "انتخاب شاگردان برای چاپ";
		ad.BorderStyle = (BorderStyle)1;
		((Control)ad).Location = new Point(57, 22);
		((Control)ad).Name = "lYear";
		((Control)ad).Size = new Size(55, 24);
		((Control)ad).TabIndex = 118;
		((Control)ae).AutoSize = true;
		((Control)ae).Location = new Point(118, 26);
		((Control)ae).Name = "label7";
		((Control)ae).Size = new Size(66, 13);
		((Control)ae).TabIndex = 117;
		((Control)ae).Text = "سال تعلیمی";
		w.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)w).FormattingEnabled = true;
		((Control)w).Location = new Point(6, 134);
		((Control)w).Name = "dropStd";
		((Control)w).Size = new Size(189, 21);
		((Control)w).TabIndex = 3;
		((Control)w).Visible = false;
		x.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)x).FormattingEnabled = true;
		((Control)x).Location = new Point(6, 106);
		((Control)x).Name = "dropClass";
		((Control)x).Size = new Size(189, 21);
		((Control)x).TabIndex = 2;
		((Control)x).Visible = false;
		x.SelectedIndexChanged += a;
		y.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)y).FormattingEnabled = true;
		((Control)y).Location = new Point(5, 78);
		((Control)y).Name = "dropHoze_Paye";
		((Control)y).Size = new Size(189, 21);
		((Control)y).TabIndex = 1;
		y.SelectedIndexChanged += b;
		v.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)v).FormattingEnabled = true;
		((Control)v).Location = new Point(5, 50);
		((Control)v).Name = "dropTypeSelect";
		((Control)v).Size = new Size(189, 21);
		((Control)v).TabIndex = 0;
		v.SelectedIndexChanged += c;
		((Control)aa).Controls.Add((Control)(object)ac);
		((Control)aa).Controls.Add((Control)(object)ab);
		((Control)aa).Location = new Point(210, 2);
		((Control)aa).Name = "groupBox4";
		((Control)aa).Size = new Size(244, 102);
		((Control)aa).TabIndex = 13;
		aa.TabStop = false;
		((Control)aa).Text = "محتوای آیتم انتخابی";
		((Control)ac).Location = new Point(13, 52);
		((Control)ac).Name = "btnAcpCaption";
		((Control)ac).Size = new Size(225, 32);
		((Control)ac).TabIndex = 15;
		((Control)ac).Text = "ثبت محتوا";
		((ButtonBase)ac).UseVisualStyleBackColor = true;
		((Control)ac).Click += d;
		((Control)ab).Location = new Point(13, 22);
		((Control)ab).Name = "txtCaption";
		((Control)ab).Size = new Size(225, 21);
		((Control)ab).TabIndex = 15;
		((Control)u).Font = new Font("Tahoma", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)u).Location = new Point(3, 180);
		((Control)u).Name = "label6";
		((Control)u).Size = new Size(664, 30);
		((Control)u).TabIndex = 11;
		((Control)u).Text = componentResourceManager.GetString("label6.Text");
		((Control)t).AutoSize = true;
		((Control)t).Font = new Font("Tahoma", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)t).Location = new Point(334, 148);
		((Control)t).Name = "label5";
		((Control)t).Size = new Size(330, 23);
		((Control)t).TabIndex = 10;
		((Control)t).Text = "نحوه قرارگیری محتویات قابل چاپ در برگه";
		((Control)r).Controls.Add((Control)(object)this.m_j);
		((Control)r).Controls.Add((Control)(object)q);
		((Control)r).Controls.Add((Control)(object)this.m_m);
		((Control)r).Controls.Add((Control)(object)this.m_n);
		((Control)r).Controls.Add((Control)(object)this.m_l);
		((Control)r).Controls.Add((Control)(object)o);
		((Control)r).Controls.Add((Control)(object)this.m_k);
		((Control)r).Controls.Add((Control)(object)p);
		((Control)r).Location = new Point(460, 0);
		((Control)r).Name = "groupBox1";
		((Control)r).Size = new Size(207, 138);
		((Control)r).TabIndex = 8;
		r.TabStop = false;
		((Control)r).Text = "تنظیمات آیتم انتخاب شده";
		((Control)this.m_j).Location = new Point(34, 20);
		this.m_j.Maximum = new decimal(new int[4] { 1500, 0, 0, 0 });
		((Control)this.m_j).Name = "txtTop";
		((Control)this.m_j).Size = new Size(69, 21);
		((Control)this.m_j).TabIndex = 0;
		this.m_j.ValueChanged += h;
		((Control)q).AutoSize = true;
		((Control)q).Location = new Point(110, 86);
		((Control)q).Name = "label4";
		((Control)q).Size = new Size(60, 13);
		((Control)q).TabIndex = 7;
		((Control)q).Text = "اندازه طولی";
		((Control)this.m_m).Location = new Point(34, 52);
		this.m_m.Maximum = new decimal(new int[4] { 750, 0, 0, 0 });
		((Control)this.m_m).Name = "txtleft";
		((Control)this.m_m).Size = new Size(69, 21);
		((Control)this.m_m).TabIndex = 1;
		this.m_m.ValueChanged += g;
		((Control)this.m_n).AutoSize = true;
		((Control)this.m_n).Location = new Point(110, 113);
		((Control)this.m_n).Name = "label3";
		((Control)this.m_n).Size = new Size(33, 13);
		((Control)this.m_n).TabIndex = 6;
		((Control)this.m_n).Text = "ارتفاع";
		((Control)this.m_l).Location = new Point(34, 111);
		this.m_l.Maximum = new decimal(new int[4] { 500, 0, 0, 0 });
		this.m_l.Minimum = new decimal(new int[4] { 20, 0, 0, 0 });
		((Control)this.m_l).Name = "txtH";
		((Control)this.m_l).Size = new Size(69, 21);
		((Control)this.m_l).TabIndex = 2;
		this.m_l.Value = new decimal(new int[4] { 20, 0, 0, 0 });
		this.m_l.ValueChanged += f;
		((Control)o).AutoSize = true;
		((Control)o).Location = new Point(109, 54);
		((Control)o).Name = "label2";
		((Control)o).Size = new Size(64, 13);
		((Control)o).TabIndex = 5;
		((Control)o).Text = "فاصله از چپ";
		((Control)this.m_k).Location = new Point(34, 84);
		this.m_k.Maximum = new decimal(new int[4] { 750, 0, 0, 0 });
		this.m_k.Minimum = new decimal(new int[4] { 50, 0, 0, 0 });
		((Control)this.m_k).Name = "txtW";
		((Control)this.m_k).Size = new Size(69, 21);
		((Control)this.m_k).TabIndex = 3;
		this.m_k.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_k.ValueChanged += e;
		((Control)p).AutoSize = true;
		((Control)p).Location = new Point(110, 24);
		((Control)p).Name = "label1";
		((Control)p).Size = new Size(60, 13);
		((Control)p).TabIndex = 4;
		((Control)p).Text = "فاصله از بالا";
		((Control)this.m_h).Font = new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)this.m_h).Location = new Point(7, 124);
		((Control)this.m_h).Name = "button1";
		((Control)this.m_h).Size = new Size(89, 50);
		((Control)this.m_h).TabIndex = 89;
		((Control)this.m_h).Text = "خروج";
		((ButtonBase)this.m_h).UseVisualStyleBackColor = true;
		((Control)this.m_h).Click += i;
		((Control)s).BackColor = SystemColors.ControlText;
		((Control)s).Controls.Add((Control)(object)this.m_g);
		((Control)s).Dock = (DockStyle)5;
		((Control)s).Location = new Point(0, 0);
		((Control)s).Name = "panel4";
		((Control)s).Size = new Size(801, 640);
		((Control)s).TabIndex = 20;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = SystemColors.InactiveCaptionText;
		((Form)this).ClientSize = new Size(801, 640);
		((Control)this).Controls.Add((Control)(object)s);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmsarbarg";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "سربرگ";
		((Form)this).Load += k;
		((Control)this.m_g).ResumeLayout(false);
		((Control)this.m_i).ResumeLayout(false);
		((Control)this.m_i).PerformLayout();
		((Control)z).ResumeLayout(false);
		((Control)z).PerformLayout();
		((Control)aa).ResumeLayout(false);
		((Control)aa).PerformLayout();
		((Control)r).ResumeLayout(false);
		((Control)r).PerformLayout();
		((ISupportInitialize)this.m_j).EndInit();
		((ISupportInitialize)this.m_m).EndInit();
		((ISupportInitialize)this.m_l).EndInit();
		((ISupportInitialize)this.m_k).EndInit();
		((Control)s).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asdal()
	{
		f();
	}

	private void n(object A_0, EventArgs A_1)
	{
		l(this, null);
	}

	private void m(object A_0, EventArgs A_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		while (true)
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Filter = "Report|*.rpx";
			bool flag = (int)((CommonDialog)val).ShowDialog() != 1;
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
					return;
				case 0:
					if (true)
					{
					}
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			string text = "0";
			string text2 = "0";
			string text3 = "0";
			bool flag = ((ListControl)v).SelectedIndex != 0;
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
					text3 = "2";
					flag = ((ListControl)y).SelectedIndex < 0;
					num = 12;
					continue;
				case 4:
					flag = !(((ListControl)y).SelectedValue.ToString() == "0");
					num = 18;
					continue;
				case 18:
					if (!flag)
					{
						num = 7;
						continue;
					}
					text = "5";
					text2 = ((ListControl)y).SelectedValue.ToString();
					num = 10;
					continue;
				case 26:
					num = 15;
					continue;
				case 36:
					return;
				case 1:
				case 10:
					num = 30;
					continue;
				case 17:
					text = "0";
					text2 = "0";
					num = 16;
					continue;
				case 12:
					if (!flag)
					{
						num = 4;
						continue;
					}
					MessageBox.Show("حوزه ای انتخاب نشده است");
					num = 20;
					continue;
				case 11:
				case 28:
				{
					SqlConnection val = new SqlConnection(asdab.e());
					((DbConnection)(object)val).Open();
					DataSet dataSet = new DataSet();
					SqlCommand val2 = new SqlCommand("sp_SelectStdForSarbarg", val);
					((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
					val2.Parameters.AddWithValue("@type", (object)text);
					val2.Parameters.AddWithValue("@code", (object)text2);
					val2.Parameters.AddWithValue("@sort", (object)text3);
					val2.Parameters.AddWithValue("@xYear", (object)((Control)ad).Text);
					SqlDataAdapter val3 = new SqlDataAdapter(val2);
					((DbDataAdapter)(object)val3).Fill(dataSet, "v_data");
					((DbConnection)(object)val).Close();
					flag = dataSet.Tables[0].Rows.Count != 0;
					num = 21;
					continue;
				}
				case 21:
					if (!flag)
					{
						num = 32;
						continue;
					}
					return;
				case 8:
					num = 26;
					continue;
				case 22:
					flag = ((ListControl)x).SelectedIndex < 0;
					num = 24;
					continue;
				case 24:
					if (!flag)
					{
						num = 23;
						continue;
					}
					MessageBox.Show("صنفی ای انتخاب نشده است");
					num = 29;
					continue;
				case 20:
					return;
				case 32:
					MessageBox.Show("موردی برای چاپ وجود ندارد");
					num = 6;
					continue;
				case 6:
					return;
				case 3:
					flag = !(((ListControl)w).SelectedValue.ToString() != "0");
					num = 14;
					continue;
				case 14:
					if (!flag)
					{
						num = 34;
						continue;
					}
					goto case 33;
				case 2:
					text3 = "1";
					flag = ((ListControl)y).SelectedIndex < 0;
					num = 27;
					continue;
				case 27:
					if (flag)
					{
						MessageBox.Show("پایه ای انتخاب نشده است");
						num = 36;
					}
					else
					{
						num = 5;
					}
					continue;
				case 16:
				case 19:
					num = 22;
					continue;
				case 9:
					text = "2";
					text2 = ((ListControl)x).SelectedValue.ToString();
					flag = ((ListControl)w).SelectedIndex < 0;
					num = 31;
					continue;
				case 31:
					if (!flag)
					{
						num = 3;
						continue;
					}
					MessageBox.Show("شاگردی انتخاب نشده است");
					num = 25;
					continue;
				case 7:
					text = "4";
					text2 = "0";
					num = 1;
					continue;
				case 33:
					num = 8;
					continue;
				case 34:
					text = "3";
					text2 = ((ListControl)w).SelectedValue.ToString();
					num = 33;
					continue;
				case 29:
					return;
				case 23:
					flag = !(((ListControl)x).SelectedValue.ToString() != "0");
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						if (true)
						{
						}
						num = 9;
						continue;
					}
					goto case 26;
				case 5:
					flag = !(((ListControl)y).SelectedValue.ToString() == "0");
					num = 35;
					continue;
				case 35:
					if (flag)
					{
						text = "1";
						text2 = ((ListControl)y).SelectedValue.ToString();
						num = 19;
					}
					else
					{
						num = 17;
					}
					continue;
				case 30:
					num = 28;
					continue;
				case 25:
					return;
				case 15:
					num = 11;
					continue;
				}
				break;
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
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
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 2:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						((Control)this.m_g).BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 0;
					continue;
				case 3:
					if (true)
					{
					}
					num = 2;
					continue;
				case 0:
				{
					((Control)ad).Text = asdaj.a;
					af = false;
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					dictionary.Add("1", "انتخاب بر اساس پایه و صنف");
					dictionary.Add("2", "انتخاب بر اساس حوزه امتحانی");
					v.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)v).DisplayMember = "Value";
					((ListControl)v).ValueMember = "Key";
					af = true;
					e();
					c();
					return;
				}
				}
				break;
			}
		}
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		bool flag = default;
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				case 0:
					((Control)ab).Enabled = true;
					((Control)ac).Enabled = true;
					num2 = 3;
					continue;
				case 3:
					if (1 == 0)
					{
					}
					return;
				case 2:
				{
					Label val = (Label)A_0;
					ag = false;
					ah = ((Control)val).Parent.Name;
					asdan asdan3 = (asdan)(object)((Control)this.m_e).Controls[ah];
					this.m_j.Value = ((Control)asdan3).Top;
					this.m_m.Value = ((Control)asdan3).Left;
					this.m_l.Value = ((Control)asdan3).Height;
					this.m_k.Value = ((Control)asdan3).Width;
					ag = true;
					((Control)asdan3).BackColor = Color.FromName("LightSkyBlue");
					((Control)ab).Text = ((Control)val).Text;
					flag = !(asdan3.e == "l");
					num2 = 1;
					continue;
				}
				case 1:
					if (!flag)
					{
						num2 = 0;
						continue;
					}
					((Control)ab).Enabled = false;
					((Control)ac).Enabled = false;
					num2 = 5;
					continue;
				case 5:
					return;
				case 4:
				case 6:
					flag = num < ((ArrangedElementCollection)((Control)this.m_e).Controls).Count;
					num2 = 7;
					continue;
				case 7:
					if (flag)
					{
						asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[num];
						((Control)asdan2).BackColor = Color.Empty;
						num++;
						num2 = 4;
					}
					else
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void e()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		int num2 = default;
		Font a_ = default;
		float num3 = default;
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tListField");
			bool flag = dataTable.Rows.Count <= 0;
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
					return;
				case 4:
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					num2 = 0;
					num = 7;
					continue;
				case 2:
				case 7:
					flag = num2 < dataTable.Rows.Count;
					num = 3;
					continue;
				case 3:
					if (flag)
					{
						a_ = new Font("Tahoma", 10f);
						num = 5;
					}
					else
					{
						num = 4;
					}
					continue;
				case 5:
				{
					try
					{
						while (true)
						{
							IL_0302:
							string text = Convert.ToString(dataTable.Rows[num2]["fFontName"]);
							bool flag2 = false;
							num = 2;
							while (true)
							{
								switch (num)
								{
								case 5:
									a_ = new Font(text, num3, (FontStyle)1);
									num = 4;
									continue;
								case 2:
									try
									{
										flag2 = bool.Parse(dataTable.Rows[num2]["fFontBold"].ToString());
									}
									catch
									{
									}
									num3 = 10f;
									num = 6;
									continue;
								case 6:
									try
									{
										num3 = float.Parse(dataTable.Rows[num2]["fFontSize"].ToString());
									}
									catch
									{
									}
									flag = !flag2;
									num = 1;
									continue;
								case 1:
									if (flag)
									{
										a_ = new Font(text, num3);
										num = 0;
									}
									else
									{
										num = 5;
									}
									continue;
								case 0:
								case 4:
									num = 3;
									continue;
								case 3:
									goto end_IL_02dd;
								}
								goto IL_0302;
								continue;
								end_IL_02dd:
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
					asdan asdan2 = new asdan();
					((Control)asdan2).Name = dataTable.Rows[num2]["fFieldName"].ToString();
					asdan2.e = dataTable.Rows[num2]["fType"].ToString();
					Label val = (Label)((Control)asdan2).Controls[2];
					((Control)val).MouseDown += a;
					asdan2.a(a_);
					asdan2.a(dataTable.Rows[num2]["fFieldCaption"].ToString());
					asdan2.a(bool.Parse(dataTable.Rows[num2]["show"].ToString()));
					((Control)asdan2).Height = int.Parse(dataTable.Rows[num2]["fHeight"].ToString());
					((Control)asdan2).Width = int.Parse(dataTable.Rows[num2]["fWidth"].ToString());
					((Control)val).Height = int.Parse(dataTable.Rows[num2]["fHeight"].ToString());
					((Control)val).Width = int.Parse(dataTable.Rows[num2]["fWidth"].ToString());
					((Control)asdan2).Top = int.Parse(dataTable.Rows[num2]["fTop"].ToString());
					((Control)asdan2).Left = int.Parse(dataTable.Rows[num2]["fLeft"].ToString());
					((Control)this.m_e).Controls.Add((Control)(object)asdan2);
					num2++;
					num = 2;
					continue;
				}
				}
				break;
			}
		}
	}

	private void d()
	{
		bool flag = default;
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					flag = num < ((ArrangedElementCollection)((Control)this.m_e).Controls).Count;
					num2 = 2;
					continue;
				case 2:
				{
					if (!flag)
					{
						if (true)
						{
						}
						num2 = 1;
						continue;
					}
					asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[num];
					asdcb.d(asdab.e(), CommandType.Text, "UPDATE tListField SET  fFieldCaption=N'" + asdan2.c() + "', fTop = " + ((Control)asdan2).Top + ", fLeft =  " + ((Control)asdan2).Left + ", fHeight = " + ((Control)asdan2).Height + ", fWidth =  " + ((Control)asdan2).Width + ", fFontName = N'" + asdan2.d().Name + "', fFontSize =" + asdan2.d().Size + ", fFontBold =" + asdan2.d().Bold.ToString().Replace("True", "1").Replace("False", "0") + ", show = " + asdan2.b().ToString().Replace("True", "1")
						.Replace("False", "0") + " WHERE     (fFieldName = N'" + ((Control)asdan2).Name + "')");
					num++;
					num2 = 3;
					continue;
				}
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		d();
		MessageBox.Show("تغییرات اعمال شد");
	}

	private void i(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void h(object A_0, EventArgs A_1)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(ah != "");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						if (true)
						{
						}
						num = 5;
					}
					else
					{
						MessageBox.Show("موردی انتخاب نشده است");
						num = 4;
					}
					continue;
				case 2:
					num = 6;
					continue;
				case 6:
					return;
				case 0:
				{
					asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[ah];
					((Control)asdan2).Top = int.Parse(this.m_j.Value.ToString());
					num = 2;
					continue;
				}
				case 5:
					flag = !ag;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 4:
					return;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(ah != "");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 1;
						continue;
					}
					MessageBox.Show("موردی انتخاب نشده است");
					num = 2;
					continue;
				case 0:
					num = 6;
					continue;
				case 6:
					return;
				case 1:
					flag = !ag;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 3:
				{
					if (true)
					{
					}
					asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[ah];
					((Control)asdan2).Left = int.Parse(this.m_m.Value.ToString());
					num = 0;
					continue;
				}
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(ah != "");
			int num = 1;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 2;
						continue;
					}
					MessageBox.Show("موردی انتخاب نشده است");
					num = 6;
					continue;
				case 5:
					num = 0;
					continue;
				case 0:
					return;
				case 3:
				{
					asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[ah];
					((Control)asdan2).Height = int.Parse(this.m_l.Value.ToString());
					num = 5;
					continue;
				}
				case 2:
					flag = !ag;
					num = 4;
					continue;
				case 4:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 5;
				case 6:
					return;
				}
				break;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(ah != "");
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (!flag)
					{
						num = 0;
						continue;
					}
					MessageBox.Show("موردی انتخاب نشده است");
					num = 3;
					continue;
				case 0:
					if (true)
					{
					}
					flag = !ag;
					num = 6;
					continue;
				case 4:
					num = 2;
					continue;
				case 2:
					return;
				case 1:
				{
					asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[ah];
					((Control)asdan2).Width = int.Parse(this.m_k.Value.ToString());
					num = 4;
					continue;
				}
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 4;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			bool flag = !(ah != "");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (!flag)
					{
						if (true)
						{
						}
						num = 1;
					}
					else
					{
						MessageBox.Show("موردی انتخاب نشده است");
						num = 3;
					}
					continue;
				case 0:
					return;
				case 5:
					MessageBox.Show("محتوایی وارد نشده است");
					((Control)ab).Focus();
					num = 2;
					continue;
				case 2:
					return;
				case 1:
					flag = !(((Control)ab).Text == "");
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						((Control)ab).Text = asdaj.b(((Control)ab).Text);
						asdan asdan2 = (asdan)(object)((Control)this.m_e).Controls[ah];
						asdan2.a(((Control)ab).Text);
						num = 0;
					}
					else
					{
						num = 5;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c()
	{
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		string a_ = default;
		Dictionary<string, string> dictionary = default;
		int num2 = default;
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !af;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 20;
						continue;
					}
					return;
				case 7:
					y.DataSource = null;
					num = 10;
					continue;
				case 18:
					a_ = "select id,name from tPaye order by id";
					dictionary.Add("0", "تمام پایه ها");
					((Control)x).Visible = true;
					num = 21;
					continue;
				case 5:
				case 10:
					ai = true;
					flag = ((ListControl)v).SelectedIndex != 0;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 9;
						continue;
					}
					goto case 22;
				case 14:
					if (true)
					{
					}
					a_ = "";
					num = 15;
					continue;
				case 11:
					flag = dictionary.Count != 0;
					num = 16;
					continue;
				case 16:
					if (!flag)
					{
						num = 7;
						continue;
					}
					y.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)y).DisplayMember = "Value";
					((ListControl)y).ValueMember = "Key";
					num = 5;
					continue;
				case 22:
					num = 0;
					continue;
				case 0:
					return;
				case 19:
					num2 = 0;
					num = 17;
					continue;
				case 15:
					flag = ((ListControl)v).SelectedIndex != 0;
					num = 13;
					continue;
				case 13:
					if (!flag)
					{
						num = 18;
						continue;
					}
					a_ = "select id,name from thozeh order by id";
					dictionary.Add("0", "تمام حوزه ها");
					((Control)x).Visible = false;
					((Control)w).Visible = false;
					num = 2;
					continue;
				case 9:
					b();
					num = 22;
					continue;
				case 2:
				case 21:
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count >= 1;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 19;
				case 20:
					ai = false;
					dictionary = new Dictionary<string, string>();
					a_ = "";
					flag = ((ListControl)v).SelectedIndex <= 0;
					num = 23;
					continue;
				case 23:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 15;
				case 6:
					dictionary.Clear();
					num = 19;
					continue;
				case 12:
				case 17:
					flag = num2 < dataTable.Rows.Count;
					num = 4;
					continue;
				case 4:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						num = 12;
					}
					else
					{
						num = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	private void b()
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		Dictionary<string, string> dictionary = default;
		string text = default;
		int num2 = default;
		DataTable dataTable = default;
		while (true)
		{
			bool flag = !ai;
			int num = 15;
			while (true)
			{
				switch (num)
				{
				case 15:
					if (!flag)
					{
						num = 11;
						continue;
					}
					return;
				case 10:
					flag = dictionary.Count != 0;
					num = 8;
					continue;
				case 8:
					if (!flag)
					{
						num = 3;
						continue;
					}
					x.DataSource = (object)new BindingSource((object)dictionary, (string)null);
					((ListControl)x).DisplayMember = "Value";
					((ListControl)x).ValueMember = "Key";
					num = 2;
					continue;
				case 14:
					text = text + " and xpaye=" + ((ListControl)y).SelectedValue.ToString();
					num = 4;
					continue;
				case 11:
					aj = false;
					text = " where xYear=" + ((Control)ad).Text;
					flag = !(((ListControl)y).SelectedValue.ToString() != "0");
					if (true)
					{
					}
					num = 6;
					continue;
				case 6:
					if (!flag)
					{
						num = 14;
						continue;
					}
					goto case 4;
				case 3:
					x.DataSource = null;
					num = 16;
					continue;
				case 2:
				case 16:
					aj = true;
					num = 0;
					continue;
				case 0:
					return;
				case 13:
					num2 = 0;
					num = 7;
					continue;
				case 4:
				{
					string a_ = "select id,name from tClass " + text + " order by id";
					dictionary = new Dictionary<string, string>();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
					flag = dataTable.Rows.Count <= 1;
					num = 1;
					continue;
				}
				case 1:
					if (!flag)
					{
						num = 5;
						continue;
					}
					goto case 13;
				case 7:
				case 9:
					flag = num2 < dataTable.Rows.Count;
					num = 12;
					continue;
				case 12:
					if (flag)
					{
						dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
						num2++;
						num = 9;
					}
					else
					{
						num = 10;
					}
					continue;
				case 5:
					dictionary.Add("0", "تمام صنف ها");
					num = 13;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, string> dictionary = default;
		bool flag = default;
		int num2 = default;
		DataTable dataTable = default;
		while (true)
		{
			if (true)
			{
			}
			int num = 1;
			while (true)
			{
				int num3;
				switch (num)
				{
				case 1:
					num = ((!aj) ? 5 : 3);
					continue;
				case 3:
					num = 7;
					continue;
				case 7:
					num3 = ((((ListControl)x).SelectedIndex < 0) ? 1 : 0);
					goto IL_01f0;
				case 6:
					dictionary.Add("0", "تمام شاگردان صنف");
					num = 11;
					continue;
				case 10:
					((Control)w).Visible = false;
					w.DataSource = null;
					num = 8;
					continue;
				case 8:
					return;
				case 12:
					w.DataSource = null;
					MessageBox.Show("شاگردی در این صنف وجود ندارد");
					num = 18;
					continue;
				case 13:
					if (!flag)
					{
						num = 6;
						continue;
					}
					goto case 11;
				case 0:
					if (!flag)
					{
						num = 20;
						continue;
					}
					return;
				case 5:
					num3 = 1;
					goto IL_01f0;
				case 2:
				case 18:
					num = 4;
					continue;
				case 4:
					return;
				case 11:
					num2 = 0;
					num = 19;
					continue;
				case 20:
					flag = !(((ListControl)x).SelectedValue.ToString() == "0");
					num = 14;
					continue;
				case 14:
					if (flag)
					{
						((Control)w).Visible = true;
						string a_ = "select tStudent.id,tStudent.fname + N' - '+ tStudent.lname as name  from tstudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent where tYear_Student.xclass= " + ((ListControl)x).SelectedValue.ToString() + " order by tYear_Student.sort,tStudent.fname,tStudent.lname,tStudent.id";
						dictionary = new Dictionary<string, string>();
						dataTable = asdcb.c(asdab.e(), CommandType.Text, a_);
						flag = dataTable.Rows.Count <= 1;
						num = 13;
					}
					else
					{
						num = 10;
					}
					continue;
				case 17:
					flag = dictionary.Count != 0;
					num = 9;
					continue;
				case 9:
					if (flag)
					{
						w.DataSource = (object)new BindingSource((object)dictionary, (string)null);
						((ListControl)w).DisplayMember = "Value";
						((ListControl)w).ValueMember = "Key";
						num = 2;
					}
					else
					{
						num = 12;
					}
					continue;
				case 15:
				case 19:
					flag = num2 < dataTable.Rows.Count;
					num = 16;
					continue;
				case 16:
					{
						if (flag)
						{
							dictionary.Add(dataTable.Rows[num2]["id"].ToString(), dataTable.Rows[num2]["name"].ToString());
							num2++;
							num = 15;
						}
						else
						{
							num = 17;
						}
						continue;
					}
					IL_01f0:
					flag = (byte)num3 != 0;
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = ((ListControl)v).SelectedIndex != 0;
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
					b();
					if (true)
					{
					}
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
		while (true)
		{
			bool flag = ((ListControl)v).SelectedIndex != 0;
			if (true)
			{
			}
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
					a();
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
