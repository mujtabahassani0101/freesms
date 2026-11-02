using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Janus.Windows.EditControls;

public class asda8 : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private UIButton m_d;

	private UIButton m_e;

	private Label f;

	private Panel g;

	private ColorDialog h;

	private Label i;

	private Label j;

	private NumericUpDown k;

	private Label l;

	private NumericUpDown m;

	private NumericUpDown n;

	private UIButton o;

	protected override void a(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 4;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					if (A_0)
					{
						if (true)
						{
						}
						num = 6;
					}
					else
					{
						num = 5;
					}
					continue;
				case 6:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 0:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto case 2;
				case 5:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						((Form)this).Dispose(A_0);
						return;
					}
					IL_007c:
					flag = (byte)num2 != 0;
					num = 1;
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
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asda8));
		this.m_b = new Panel();
		o = new UIButton();
		l = new Label();
		m = new NumericUpDown();
		n = new NumericUpDown();
		k = new NumericUpDown();
		j = new Label();
		i = new Label();
		f = new Label();
		this.m_c = new Panel();
		this.m_e = new UIButton();
		this.m_d = new UIButton();
		g = new Panel();
		h = new ColorDialog();
		((Control)this.m_b).SuspendLayout();
		((ISupportInitialize)m).BeginInit();
		((ISupportInitialize)n).BeginInit();
		((ISupportInitialize)k).BeginInit();
		((Control)this.m_c).SuspendLayout();
		((Control)g).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)this.m_b).BackColor = SystemColors.GradientInactiveCaption;
		this.m_b.BorderStyle = (BorderStyle)1;
		((Control)this.m_b).Controls.Add((Control)(object)o);
		((Control)this.m_b).Controls.Add((Control)(object)l);
		((Control)this.m_b).Controls.Add((Control)(object)m);
		((Control)this.m_b).Controls.Add((Control)(object)n);
		((Control)this.m_b).Controls.Add((Control)(object)k);
		((Control)this.m_b).Controls.Add((Control)(object)j);
		((Control)this.m_b).Controls.Add((Control)(object)i);
		((Control)this.m_b).Controls.Add((Control)(object)f);
		((Control)this.m_b).Controls.Add((Control)(object)this.m_c);
		((Control)this.m_b).Location = new Point(4, 6);
		((Control)this.m_b).Name = "panel1";
		((Control)this.m_b).Size = new Size(446, 395);
		((Control)this.m_b).TabIndex = 0;
		o.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		((Control)o).Location = new Point(186, 227);
		((Control)o).Name = "btnAcp";
		((Control)o).Size = new Size(96, 32);
		((Control)o).TabIndex = 24;
		((Control)o).Text = "ثبت";
		((Control)o).Click += c;
		((Control)l).AutoSize = true;
		((Control)l).Location = new Point(267, 189);
		((Control)l).Name = "label3";
		((Control)l).Size = new Size(53, 24);
		((Control)l).TabIndex = 23;
		((Control)l).Text = "رنگ آبی";
		((Control)m).Location = new Point(197, 185);
		m.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		((Control)m).Name = "txtB";
		((Control)m).Size = new Size(62, 31);
		((Control)m).TabIndex = 22;
		m.ValueChanged += a;
		((Control)n).Location = new Point(197, 138);
		n.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		((Control)n).Name = "txtG";
		((Control)n).Size = new Size(62, 31);
		((Control)n).TabIndex = 21;
		n.ValueChanged += a;
		((Control)k).Location = new Point(197, 94);
		k.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
		((Control)k).Name = "txtR";
		((Control)k).Size = new Size(62, 31);
		((Control)k).TabIndex = 20;
		k.ValueChanged += a;
		((Control)j).AutoSize = true;
		((Control)j).Location = new Point(265, 140);
		((Control)j).Name = "label2";
		((Control)j).Size = new Size(55, 24);
		((Control)j).TabIndex = 19;
		((Control)j).Text = "رنگ سبز";
		((Control)i).AutoSize = true;
		((Control)i).Location = new Point(265, 96);
		((Control)i).Name = "label1";
		((Control)i).Size = new Size(57, 24);
		((Control)i).TabIndex = 18;
		((Control)i).Text = "رنک قرمز";
		((Control)f).AutoSize = true;
		((Control)f).Font = new Font("B Nazanin", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)f).ForeColor = Color.DarkViolet;
		((Control)f).Location = new Point(125, 9);
		((Control)f).Name = "label4";
		((Control)f).Size = new Size(202, 40);
		((Control)f).TabIndex = 16;
		((Control)f).Text = "رنگ پس زمینه فرم ها";
		((Control)this.m_c).Anchor = (AnchorStyles)14;
		((Control)this.m_c).Controls.Add((Control)(object)this.m_e);
		((Control)this.m_c).Controls.Add((Control)(object)this.m_d);
		((Control)this.m_c).Location = new Point(3, 350);
		((Control)this.m_c).Name = "p_new";
		((Control)this.m_c).Size = new Size(440, 41);
		((Control)this.m_c).TabIndex = 9;
		((Control)this.m_e).Anchor = (AnchorStyles)6;
		this.m_e.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_e.ImageSize = new Size(30, 30);
		((Control)this.m_e).Location = new Point(7, 3);
		((Control)this.m_e).Name = "btnClose";
		((Control)this.m_e).Size = new Size(75, 32);
		((Control)this.m_e).TabIndex = 15;
		((Control)this.m_e).Text = "خروج";
		this.m_e.TextHorizontalAlignment = (TextAlignment)1;
		((Control)this.m_e).Click += b;
		((Control)this.m_d).Anchor = (AnchorStyles)10;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnNew.Image");
		((Control)this.m_d).Location = new Point(316, 3);
		((Control)this.m_d).Name = "btnNew";
		((Control)this.m_d).Size = new Size(116, 32);
		((Control)this.m_d).TabIndex = 0;
		((Control)this.m_d).Text = "انتخاب رنگ ";
		((Control)this.m_d).Click += d;
		((Control)g).BackColor = SystemColors.ControlText;
		((Control)g).Controls.Add((Control)(object)this.m_b);
		((Control)g).Dock = (DockStyle)5;
		((Control)g).Font = new Font("B Nazanin", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)178);
		((Control)g).Location = new Point(0, 0);
		((Control)g).Name = "panel2";
		((Control)g).Size = new Size(456, 407);
		((Control)g).TabIndex = 1;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(456, 407);
		((Control)this).Controls.Add((Control)(object)g);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "frmbackColor";
		((Control)this).RightToLeft = (RightToLeft)1;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "تعریف دوره";
		((Form)this).Load += e;
		((Control)this.m_b).ResumeLayout(false);
		((Control)this.m_b).PerformLayout();
		((ISupportInitialize)m).EndInit();
		((ISupportInitialize)n).EndInit();
		((ISupportInitialize)k).EndInit();
		((Control)this.m_c).ResumeLayout(false);
		((Control)g).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public asda8()
	{
		a();
	}

	private void e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			DataTable dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
			bool flag = dataTable.Rows.Count <= 0;
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
					goto case 3;
				case 1:
					try
					{
						k.Value = decimal.Parse(dataTable.Rows[0]["R"].ToString());
						n.Value = decimal.Parse(dataTable.Rows[0]["G"].ToString());
						m.Value = decimal.Parse(dataTable.Rows[0]["B"].ToString());
					}
					catch
					{
					}
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					num = 1;
					continue;
				case 3:
					((Control)o).Visible = false;
					return;
				}
				break;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		while (true)
		{
			ColorDialog val = new ColorDialog();
			bool flag = (int)((CommonDialog)val).ShowDialog() != 1;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					k.Value = decimal.Parse(val.Color.R.ToString());
					n.Value = decimal.Parse(val.Color.G.ToString());
					m.Value = decimal.Parse(val.Color.B.ToString());
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

	private void a(decimal A_0, decimal A_1, decimal A_2)
	{
		if (true)
		{
		}
		((Control)this.m_b).BackColor = Color.FromArgb(int.Parse(A_0.ToString()), int.Parse(A_1.ToString()), int.Parse(A_2.ToString()));
	}

	private void c(object A_0, EventArgs A_1)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (true)
		{
		}
		asdcb.d(asdab.e(), CommandType.Text, "if not exists(select R from tFormColor)\r\n                insert into tFormColor(R,G,B)values(" + k.Value + "," + n.Value + "," + m.Value + ")\r\n                else\r\n                update tFormColor set R=" + k.Value + ",G=" + n.Value + ",B=" + m.Value);
		MessageBox.Show("ثبت شد");
		((Control)o).Visible = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		a(k.Value, n.Value, m.Value);
		((Control)o).Visible = true;
	}
}
