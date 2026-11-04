using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;

public class asdp : Form
{
	private IContainer m_a = null;

	private Panel m_b;

	private Panel m_c;

	private Panel m_d;

	private Label e;

	private UIButton f;

	private GridEX g;

	private UIComboBox h;

	private Label i;

	private Label j;

	private Label k;

	private Label l;

	private UIButton m;

	private Label n;

	private Label o;

	private SqlConnection p = new SqlConnection(asdab.e());

	public string q;

	private bool r = true;

	private int s;

	private bool t = false;
protected override void Dispose(bool A_0)
	{
		bool flag = default;
		while (true)
		{
			int num = 5;
			while (true)
			{
				int num2;
				switch (num)
				{
				case 5:
					if (A_0)
					{
						if (true)
						{
						}
						num = 2;
					}
					else
					{
						num = 0;
					}
					continue;
				case 2:
					num = 6;
					continue;
				case 6:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 3:
					this.m_a.Dispose();
					num = 4;
					continue;
				case 1:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 4;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 4:
					{
						base.Dispose(A_0);
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

	private void c()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdp));
		StringFormat stringFormat = new StringFormat();
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_b = new Panel();
		this.m_c = new Panel();
		this.m_d = new Panel();
		o = new Label();
		n = new Label();
		m = new UIButton();
		l = new Label();
		j = new Label();
		k = new Label();
		h = new UIComboBox();
		i = new Label();
		e = new Label();
		f = new UIButton();
		g = new GridEX();
		this.m_b.SuspendLayout();
		this.m_c.SuspendLayout();
		this.m_d.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_b.BackColor = Color.FromArgb(214, 223, 247);
		this.m_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_b.Controls.Add(this.m_c);
		this.m_b.Dock = DockStyle.Fill;
		this.m_b.Font = new Font("B Nazanin", 12f, FontStyle.Bold);
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "panel1";
		this.m_b.Size = new Size(700, 671);
		this.m_b.TabIndex = 0;
		this.m_c.BackColor = Color.Black;
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel2";
		this.m_c.Size = new Size(698, 669);
		this.m_c.TabIndex = 44;
		this.m_d.BackColor = Color.FromArgb(214, 223, 247);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(j);
		this.m_d.Controls.Add(k);
		this.m_d.Controls.Add(h);
		this.m_d.Controls.Add(i);
		this.m_d.Controls.Add(e);
		this.m_d.Controls.Add(f);
		this.m_d.Controls.Add(g);
		this.m_d.Location = new Point(3, 3);
		this.m_d.Name = "panel3";
		this.m_d.Size = new Size(692, 663);
		this.m_d.TabIndex = 0;
		o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		o.Location = new Point(217, 42);
		o.Name = "lcountDay";
		o.Size = new Size(59, 24);
		o.TabIndex = 122;
		n.AutoSize = true;
		n.Location = new Point(285, 41);
		n.Name = "label1";
		n.Size = new Size(62, 26);
		n.TabIndex = 121;
		n.Text = "تعداد روز";
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		m.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button;
		m.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		m.Image = (Image)componentResourceManager.GetObject("btnAcp.Image");
		m.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
		m.ImageIndex = 8;
		m.Location = new Point(529, 620);
		m.Name = "btnAcp";
		m.RightToLeft = RightToLeft.Yes;
		m.Size = new Size(153, 40);
		m.TabIndex = 120;
		m.Text = "ثبت (F5)";
		m.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
		m.Click += a;
		l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		l.Location = new Point(428, 8);
		l.Name = "lterm";
		l.Size = new Size(144, 24);
		l.TabIndex = 119;
		j.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		j.Location = new Point(217, 9);
		j.Name = "lYear";
		j.Size = new Size(59, 24);
		j.TabIndex = 118;
		k.AutoSize = true;
		k.Location = new Point(282, 9);
		k.Name = "label3";
		k.Size = new Size(78, 26);
		k.TabIndex = 117;
		k.Text = "سال تعلیمی\r\n";
		h.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
		h.DropListFont = new Font("B Nazanin", 12f);
		h.Location = new Point(430, 37);
		h.Name = "dropCls";
		h.Size = new Size(142, 33);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		h.StringFormat = stringFormat;
		h.TabIndex = 52;
		h.SelectedIndexChanged += b;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		i.AutoSize = true;
		i.Location = new Point(578, 43);
		i.Name = "label19";
		i.Size = new Size(41, 26);
		i.TabIndex = 51;
		i.Text = "صنف";
		e.AutoSize = true;
		e.Font = new Font("B Nazanin", 14f);
		e.Location = new Point(577, 5);
		e.Name = "label7";
		e.Size = new Size(105, 28);
		e.TabIndex = 50;
		e.Text = "وضعیت حاضری";
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		f.DialogResult = DialogResult.Cancel;
		f.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		f.ImageSize = new Size(40, 40);
		f.Location = new Point(11, 623);
		f.Name = "btnClose";
		f.Size = new Size(93, 35);
		f.TabIndex = 44;
		f.Text = "بستن";
		f.Click += c;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		g.DesignTimeLayout = gridEXLayout;
		g.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		g.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		g.Font = new Font("Tahoma", 9.75f);
		g.GroupByBoxVisible = false;
		g.Location = new Point(8, 76);
		g.Name = "gridEX1";
		g.RecordNavigator = true;
		g.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
		g.SelectedFormatStyle.BackColor = Color.Empty;
		g.SelectedFormatStyle.ForeColor = Color.Empty;
		g.Size = new Size(676, 540);
		g.TabIndex = 45;
		g.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
		g.CellUpdated += a;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(700, 671);
		Controls.Add(this.m_b);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmHazeri";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت نمرات دوره";
		Load += d;
		KeyUp += a;
		FormClosing += a;
		this.m_b.ResumeLayout(performLayout: false);
		this.m_c.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public asdp()
	{
		c();
	}

	private void d(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("3");
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
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 10;
					continue;
				case 13:
					l.Text = "سالانه";
					num = 1;
					continue;
				case 12:
					l.Text = "چهار و نیم ماهه";
					num = 8;
					continue;
				case 7:
					num = 3;
					continue;
				case 11:
					try
					{
						h.SelectedIndex = 0;
						a();
						g.CurrentColumn = g.GetRow(0).Cells["ghayeb"].Column;
						g.Select();
						g.SelectCurrentCellText();
					}
					catch
					{
					}
					num = 4;
					continue;
				case 10:
					if (!flag)
					{
						num = 7;
						continue;
					}
					goto case 5;
				case 1:
				case 8:
					j.Text = asdaj.__field_a;
					b();
					num = 11;
					continue;
				case 4:
					return;
				case 5:
					r = true;
					flag = !(q == "1");
					num = 2;
					continue;
				case 2:
					if (!flag)
					{
						num = 12;
						continue;
					}
					flag = !(q == "2");
					num = 6;
					continue;
				case 3:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_d.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						if (true)
						{
						}
						num = 13;
						continue;
					}
					goto case 1;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 14;
					continue;
				case 14:
					return;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select id,name from tClass where xYear=" + j.Text + " and xPaye in(" + asdaj.n + ")  order by xpaye,sortRpt");
		h.DataSource = dataSource;
		h.DisplayMember = "Name";
		h.ValueMember = "id";
	}

	private void a()
	{
		bool flag = default;
		while (true)
		{
			DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "SELECT    0 as acp,  tYear_Student.id, tYear_Student.sort, tYear_Student.hazer" + q + " as hazer, tYear_Student.Ghayeb" + q + " as Ghayeb, tYear_Student.Mariz" + q + " as Mariz, tYear_Student.rokhsat" + q + " as rokhsat,  tStudent.FName+ ' '+ tStudent.LName as Fullname,  tStudent.NumberAsas\r\n                FROM         tStudent INNER JOIN\r\n                      tYear_Student ON tStudent.id = tYear_Student.xStudent\r\n                WHERE   tYear_Student.shaghe=1 and  (tYear_Student.xYear = " + j.Text + ") AND (tYear_Student.xClass = " + h.SelectedValue.ToString() + ")");
			g.DataSource = dataSource;
			GridEXFormatCondition gridEXFormatCondition = new GridEXFormatCondition(g.RootTable.Columns["acp"], ConditionOperator.Equal, "1");
			gridEXFormatCondition.FormatStyle.ForeColor = SystemColors.WindowText;
			gridEXFormatCondition.FormatStyle.BackColor = Color.FromArgb(0, 200, 0);
			g.RootTable.FormatConditions.Add(gridEXFormatCondition);
			GridEXFormatCondition gridEXFormatCondition2 = new GridEXFormatCondition(g.RootTable.Columns["acp"], ConditionOperator.Equal, "-1");
			gridEXFormatCondition2.FormatStyle.ForeColor = SystemColors.WindowText;
			gridEXFormatCondition2.FormatStyle.BackColor = Color.FromArgb(250, 0, 150);
			g.RootTable.FormatConditions.Add(gridEXFormatCondition2);
			o.Text = "";
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						num = 1;
						continue;
					}
					return;
				case 0:
					try
					{
						while (true)
						{
							IL_0222:
							string text = " ISNULL(tYearMaghtaCountDay.Term1, 0) + ISNULL(tYearMaghtaCountDay.Term2, 0) AS term3 ";
							flag = !(q == "1");
							if (true)
							{
							}
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 3:
									if (!flag)
									{
										num = 0;
										continue;
									}
									goto case 2;
								case 0:
									text = " tYearMaghtaCountDay.Term1 AS term1";
									num = 2;
									continue;
								case 2:
									o.Text = asdcb.a(asdab.e(), CommandType.Text, "SELECT " + text + "\r\n                FROM         tYearMaghtaCountDay INNER JOIN\r\n                      tPaye ON tYearMaghtaCountDay.xMaghta = tPaye.xMaghta INNER JOIN\r\n                      tClass ON tPaye.id = tClass.xpaye\r\n                WHERE     (tClass.id = " + h.SelectedValue.ToString() + ") AND (tYearMaghtaCountDay.xYear = " + asdaj.__field_a + ")").ToString();
									num = 1;
									continue;
								case 1:
									goto end_IL_0209;
								}
								goto IL_0222;
								continue;
								end_IL_0209:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					flag = !(o.Text == "");
					num = 3;
					continue;
				case 1:
					MessageBox.Show("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید");
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		Close();
	}

    private bool recalculatingAttendance;
    private void a(object sender,ColumnActionEventArgs args)
    {
        if(recalculatingAttendance)return;
        r=false;
        string key=args.Column.Key;
        if(!string.Equals(key,"ghayeb",StringComparison.OrdinalIgnoreCase) && !string.Equals(key,"Mariz",StringComparison.OrdinalIgnoreCase) && !string.Equals(key,"rokhsat",StringComparison.OrdinalIgnoreCase))return;
        if(g.Row<0)return;
        var row=g.GetRow(g.Row);
        recalculatingAttendance=true;
        try
        {
            int days=FreeSms.Core.Values.Number(o.Text,1)??0;
            var counts=FreeSms.Core.AttendanceCounts.FromAbsences(days,row.Cells["Ghayeb"].Value,row.Cells["Mariz"].Value,row.Cells["rokhsat"].Value);
            row.BeginEdit();row.Cells["hazer"].Value=counts.Present;row.Cells["Ghayeb"].Value=counts.Absent;
            row.Cells["Mariz"].Value=counts.Sick;row.Cells["rokhsat"].Value=counts.Leave;row.Cells["acp"].Value=0;row.EndEdit();
        }
        catch(FreeSms.Core.ValidationException){row.Cells["acp"].Value=-1;}
        finally{recalculatingAttendance=false;}
    }

	private void b(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = r;
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
					goto case 10;
				case 7:
					try
					{
						g.CurrentColumn = g.GetRow(0).Cells["ghayeb"].Column;
						g.Select();
						g.SelectCurrentCellText();
					}
					catch
					{
					}
					s = h.SelectedIndex;
					num = 2;
					continue;
				case 8:
					t = false;
					num = 1;
					continue;
				case 1:
					return;
				case 0:
					flag = !t;
					num = 3;
					continue;
				case 3:
					if (!flag)
					{
						num = 8;
						continue;
					}
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات صنف دیگیری انتخاب کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 6;
					continue;
				case 10:
					t = false;
					r = true;
					a();
					num = 7;
					continue;
				case 2:
					return;
				case 4:
					t = true;
					h.SelectedIndex = s;
					num = 9;
					continue;
				case 9:
					return;
				case 6:
					if (flag)
					{
						if (true)
						{
						}
						num = 10;
					}
					else
					{
						num = 4;
					}
					continue;
				}
				break;
			}
		}
	}

    private async void a(object sender,EventArgs args)
    {
        if(!g.TryEndEdit())return;
        if(q!="1" && q!="2")throw new InvalidOperationException("Unknown attendance period.");
        int days;
        try{days=FreeSms.Core.Values.Number(o.Text,1)??0;}
        catch(FreeSms.Core.ValidationException){days=0;}
        if(days<=0){MessageBox.Show("تعداد روز های سال تعلیمی را در منوی اطلاعات پایه مشخص کنید");return;}
        int invalid=0,year=int.Parse(j.Text),classroom=Convert.ToInt32(h.SelectedValue);
        string period=q;
        var entries=new System.Collections.Generic.List<(int Row,int Id,FreeSms.Core.AttendanceCounts Counts)>();
        for(int index=0;index<g.RowCount;index++)
        {
            var row=g.GetRow(index);
            try
            {
                var counts=FreeSms.Core.AttendanceCounts.Parse(days,row.Cells["hazer"].Value,row.Cells["Ghayeb"].Value,row.Cells["Mariz"].Value,row.Cells["rokhsat"].Value);
                entries.Add((index,Convert.ToInt32(row.Cells["id"].Value),counts));
            }
            catch(FreeSms.Core.ValidationException){row.Cells["acp"].Value=-1;invalid++;}
        }
        var database=new FreeSms.Core.Database(OriginalRuntime.ConnectionString);
        Enabled=false;UseWaitCursor=true;
        var completed=new System.Collections.Generic.List<int>();Exception failure=null;int failedRow=-1;
        try
        {
            await System.Threading.Tasks.Task.Run(()=>
            {
                foreach(var entry in entries)
                {
                    try
                    {
                        var counts=entry.Counts;
                        int affected=database.Execute("UPDATE tYear_Student SET hazer"+period+"=@p0,Ghayeb"+period+"=@p1,Mariz"+period+"=@p2,rokhsat"+period+"=@p3 WHERE id=@p4 AND xYear=@p5 AND xClass=@p6",
                            new object[]{counts.Present,counts.Absent,counts.Sick,counts.Leave,entry.Id,year,classroom});
                        if(affected!=1)throw new FreeSms.Core.ValidationException("رکورد شاگرد با سال و صنف انتخاب‌شده مطابقت ندارد");
                        completed.Add(entry.Row);
                    }
                    catch(Exception error) when(error is SqlException || error is FreeSms.Core.ValidationException)
                    {failure=error;failedRow=entry.Row;break;}
                }
            });
        }
        finally{if(!IsDisposed){Enabled=true;UseWaitCursor=false;}}
        if(IsDisposed)return;
        foreach(int index in completed)g.GetRow(index).Cells["acp"].Value=1;
        if(failedRow>=0)g.GetRow(failedRow).Cells["acp"].Value=-1;
        g.Refresh();r=invalid==0 && failure==null;
        if(failure!=null)MessageBox.Show("ثبت حاضری انجام نشد. تعداد "+completed.Count+" ردیف پیش از خطا ثبت شد.\n"+failure.Message,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
        else if(invalid>0)MessageBox.Show("تعداد "+completed.Count+" ردیف ثبت شد؛ "+invalid+" ردیف نامعتبر ثبت نشد");
        else if(completed.Count>0)MessageBox.Show("تعداد "+completed.Count+" ردیف انجام شد");
    }

	private void a(object A_0, KeyEventArgs A_1)
	{
		while (true)
		{
			bool flag = A_1.KeyCode != Keys.F5;
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
						num = 0;
						continue;
					}
					return;
				case 0:
					g.Refresh();
					a((object)this, (EventArgs)null);
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		while (true)
		{
			bool flag = r;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (true)
					{
					}
					if (!flag)
					{
						num = 5;
						continue;
					}
					return;
				case 0:
					return;
				case 4:
					A_1.Cancel = true;
					num = 2;
					continue;
				case 2:
					return;
				case 5:
					flag = DialogResult.Yes == MessageBox.Show("آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					num = 1;
					continue;
				case 1:
					num = ((!flag) ? 4 : 0);
					continue;
				}
				break;
			}
		}
	}
}
