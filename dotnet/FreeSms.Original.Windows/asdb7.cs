using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeSms.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using BijanComponents;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;

public class asdb7 : Form
{
	private readonly OriginalWorkbookImport workbookImport;
	private bool savingWorkbook;
	private SqlConnection m_a = new SqlConnection(asdab.e());

	private IContainer m_b = null;

	private Panel m_c;

	private UIButton m_d;

	private GridEX e;

	private Button f;

	private Button g;

	private OpenFileDialog h;

	private TextBox i;

	private Label j;

	private Label k;

	private Label l;

	private UIComboBox m;

	private Label n;

	private Label o;

	private MaskedEditBox p;

	private ProgressBar q;

	public asdb7()
	{
		a();
		workbookImport = new OriginalWorkbookImport(this);
		FormClosing += (sender, args) => { if(savingWorkbook)args.Cancel=true; };
	}

	private void d(object A_0, EventArgs A_1)
	{
		Close();
	}

	private async void c(object A_0, EventArgs A_1)
	{
		await workbookImport.OpenAsync(h, e, FreeSms.Core.WorkbookImportKind.Students);
	}

	private async void b(object A_0, EventArgs A_1)
    {
        if(savingWorkbook)return;
        if(!e.TryEndEdit())return;
        if(e.DataSource is not DataTable table || table.Rows.Count==0){MessageBox.Show("ابتدا فایل اکسل را انتخاب کنید.");return;}
        var entries=new List<WorkbookStudentEntry>();
        int year,user;int[] grades;string paymentDate,insertedAt;
        try
        {
            if(!asdaj.a("2"))throw new ValidationException("شما مجوز ورود به این بخش را ندارید");
            year=Values.Number(k.Text,1000,9999) ?? throw new ValidationException("سال معتبر نیست.");
            user=Values.Number(asdaj.l,1) ?? throw new ValidationException("کاربر معتبر نیست.");
            grades=asdaj.n.Split(',').Where(value=>int.TryParse(value,out _)).Select(int.Parse).ToArray();
            paymentDate=WorkbookPaymentDate.Parse(p.Text).Text;
            insertedAt=asdab.b()+"-"+asdab.c();
            int discount=Values.Number(m.SelectedValue,0,short.MaxValue) ?? 0;
            for(int index=0;index<table.Rows.Count;index++)
            {
                var row=table.Rows[index];row["acp"]=DBNull.Value;row["status"]=DBNull.Value;
                try
                {
                    var record=new Record();
                    foreach(DataColumn column in table.Columns)record[column.ColumnName]=row[column];
                    entries.Add(WorkbookStudentEntry.Create(record,discount));
                }
                catch(ValidationException error)
                {
                    row["acp"]="-1";row["status"]=error.Message;
                    throw new ValidationException("ردیف "+(index+1)+" فهرست: "+error.Message);
                }
            }
        }
        catch(Exception error){MessageBox.Show(error.Message);return;}
        if(MessageBox.Show("آيا از انتقال مطمئن هستيد؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)!=DialogResult.Yes)return;
        bool enabled=Enabled,wait=UseWaitCursor;savingWorkbook=true;Enabled=false;UseWaitCursor=true;
        q.Maximum=entries.Count;q.Value=0;
        try
        {
            var service=new WorkbookStudents(new Database(asdab.e()));
            await Task.Run(()=>service.Save(year,user,grades,paymentDate,insertedAt,entries));
            foreach(DataRow row in table.Rows){row["acp"]="1";row["status"]="ثبت شد";}
            q.Value=entries.Count;e.Refetch();MessageBox.Show("انجام شد");
        }
        catch(Exception error)
        {
            foreach(DataRow row in table.Rows){row["acp"]="-1";row["status"]=error.Message;}
            e.Refetch();MessageBox.Show("خطا در ثبت شاگردان:\n"+error.Message);
        }
        finally{Enabled=enabled;UseWaitCursor=wait;savingWorkbook=false;}
    }

	private void a(object A_0, EventArgs A_1)
	{
		DataTable dataTable = default;
		while (true)
		{
			bool flag = asdaj.a("2");
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
					b();
					k.Text = asdaj.__field_a;
					p.Text = asdab.b();
					dataTable = asdcb.c(asdab.e(), CommandType.Text, "select * from tFormColor");
					flag = dataTable.Rows.Count <= 0;
					num = 5;
					continue;
				case 6:
					try
					{
						int red = int.Parse(dataTable.Rows[0]["R"].ToString());
						int green = int.Parse(dataTable.Rows[0]["G"].ToString());
						int blue = int.Parse(dataTable.Rows[0]["B"].ToString());
						this.m_c.BackColor = Color.FromArgb(red, green, blue);
					}
					catch
					{
					}
					num = 7;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto IL_0155;
				case 1:
					return;
				case 0:
					MessageBox.Show("شما مجوز ورود به این بخش را ندارید", "خطای دسترسی", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Close();
					num = 2;
					continue;
				case 2:
					return;
				case 7:
					if (1 == 0)
					{
					}
					goto IL_0155;
				case 3:
					{
						num = 6;
						continue;
					}
					IL_0155:
					i.Text = Application.StartupPath + "\\xls\\Example.xls";
					h.FileName = i.Text;
					num = 1;
					continue;
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
		DataTable dataSource = asdcb.c(asdab.e(), CommandType.Text, "select 0 as id ,'-' as  name\r\n                                                                                                                union\r\n                                                                                                                select id,name from ttakhfif order by name");
		m.DataSource = dataSource;
		m.DisplayMember = "Name";
		m.ValueMember = "id";
		m.SelectedIndex = 0;
	}
protected override void Dispose(bool A_0)
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
					num = ((!A_0) ? 4 : 6);
					continue;
				case 6:
					num = 0;
					continue;
				case 0:
					num2 = ((this.m_b == null) ? 1 : 0);
					goto IL_0074;
				case 3:
					this.m_b.Dispose();
					num = 2;
					continue;
				case 5:
					if (!flag)
					{
						num = 3;
						continue;
					}
					goto case 2;
				case 4:
					num2 = 1;
					goto IL_0074;
				case 2:
					{
						base.Dispose(A_0);
						return;
					}
					IL_0074:
					flag = (byte)num2 != 0;
					if (true)
					{
					}
					num = 5;
					continue;
				}
				break;
			}
		}
	}

	private void a()
	{
		if (true)
		{
		}
		StringFormat stringFormat = new StringFormat();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(asdb7));
		GridEXLayout gridEXLayout = new GridEXLayout();
		this.m_c = new Panel();
		q = new ProgressBar();
		o = new Label();
		p = new MaskedEditBox();
		m = new UIComboBox();
		n = new Label();
		k = new Label();
		l = new Label();
		j = new Label();
		i = new TextBox();
		g = new Button();
		f = new Button();
		this.m_d = new UIButton();
		e = new GridEX();
		h = new OpenFileDialog();
		this.m_c.SuspendLayout();
		((ISupportInitialize)e).BeginInit();
		SuspendLayout();
		this.m_c.BackColor = SystemColors.GradientInactiveCaption;
		this.m_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.m_c.Controls.Add(q);
		this.m_c.Controls.Add(o);
		this.m_c.Controls.Add(p);
		this.m_c.Controls.Add(m);
		this.m_c.Controls.Add(n);
		this.m_c.Controls.Add(k);
		this.m_c.Controls.Add(l);
		this.m_c.Controls.Add(j);
		this.m_c.Controls.Add(i);
		this.m_c.Controls.Add(g);
		this.m_c.Controls.Add(f);
		this.m_c.Controls.Add(this.m_d);
		this.m_c.Controls.Add(e);
		this.m_c.Dock = DockStyle.Fill;
		this.m_c.Font = new Font("Tahoma", 8.25f);
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "panel1";
		this.m_c.Size = new Size(800, 600);
		this.m_c.TabIndex = 0;
		q.Location = new Point(11, 480);
		q.Name = "progressBar1";
		q.Size = new Size(475, 23);
		q.TabIndex = 129;
		o.AutoSize = true;
		o.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		o.Location = new Point(696, 510);
		o.Name = "label12";
		o.Size = new Size(85, 13);
		o.TabIndex = 128;
		o.Text = "تاریخ پرداخت ها :";
		p.AutoScroll = false;
		p.AutoScrollMargin = new Size(0, 0);
		p.AutoScrollMinSize = new Size(0, 0);
		p.AutoScrollPosition = new Point(0, 0);
		p.ButtonFont = new Font("B Nazanin", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 178);
		p.Location = new Point(602, 506);
		p.Mask = "0000/00/00";
		p.MaxLength = 12;
		p.Name = "txtPaynemtDate";
		p.Numeric = true;
		p.RightToLeft = RightToLeft.No;
		p.Size = new Size(86, 22);
		p.TabIndex = 127;
		p.Tag = "";
		p.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m.DropListFont = new Font("B Nazanin", 12f);
		m.Location = new Point(532, 480);
		m.Name = "comboTakhfif";
		m.Size = new Size(156, 21);
		stringFormat.Alignment = StringAlignment.Near;
		stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox | StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
		stringFormat.HotkeyPrefix = HotkeyPrefix.None;
		stringFormat.LineAlignment = StringAlignment.Center;
		stringFormat.Trimming = StringTrimming.Character;
		m.StringFormat = stringFormat;
		m.TabIndex = 125;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		n.AutoSize = true;
		n.Location = new Point(694, 486);
		n.Name = "label40";
		n.Size = new Size(37, 13);
		n.TabIndex = 126;
		n.Text = "تخفیف";
		k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		k.Location = new Point(621, 8);
		k.Name = "lYear";
		k.Size = new Size(55, 24);
		k.TabIndex = 118;
		l.AutoSize = true;
		l.Location = new Point(683, 12);
		l.Name = "label3";
		l.Size = new Size(66, 13);
		l.TabIndex = 117;
		l.Text = "سال تعلیمی";
		j.AutoSize = true;
		j.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j.ForeColor = Color.Red;
		j.Location = new Point(170, 45);
		j.Name = "label1";
		j.Size = new Size(279, 16);
		j.TabIndex = 43;
		j.Text = "نمونه فایل اکسل در مسیر زیر موجود میباشد";
		i.Location = new Point(12, 67);
		i.Name = "txtExam";
		i.ReadOnly = true;
		i.RightToLeft = RightToLeft.No;
		i.Size = new Size(440, 21);
		i.TabIndex = 40;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g.Location = new Point(575, 48);
		g.Name = "BtnNew";
		g.Size = new Size(197, 35);
		g.TabIndex = 19;
		g.Text = "انتخاب فایل اکسل";
		g.UseVisualStyleBackColor = true;
		g.Click += c;
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		f.Location = new Point(532, 535);
		f.Name = "btnAcp";
		f.Size = new Size(156, 35);
		f.TabIndex = 18;
		f.Text = "ثبت";
		f.UseVisualStyleBackColor = true;
		f.Click += b;
		this.m_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		this.m_d.Image = (Image)componentResourceManager.GetObject("btnClose.Image");
		this.m_d.ImageSize = new Size(40, 40);
		this.m_d.Location = new Point(11, 535);
		this.m_d.Name = "btnClose";
		this.m_d.Size = new Size(189, 35);
		this.m_d.TabIndex = 1;
		this.m_d.Text = "بستن";
		this.m_d.Click += d;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>جهت گروه بندی آیتم مورد نظر را با موس به اینجا بکشید و رها کنید</GroupByBoxInfo></LocalizableData>";
		gridEXLayout.LayoutString = componentResourceManager.GetString("gridEXLayout1.LayoutString");
		e.DesignTimeLayout = gridEXLayout;
		e.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
		e.FocusCellFormatStyle.BackColor = Color.FromArgb(255, 192, 192);
		e.Font = new Font("Tahoma", 8.25f);
		e.Location = new Point(8, 99);
		e.Name = "gridEX1";
		e.RecordNavigator = true;
		e.RowHeaders = InheritableBoolean.True;
		e.SelectedFormatStyle.BackColor = Color.Empty;
		e.SelectedFormatStyle.ForeColor = Color.Empty;
		e.Size = new Size(782, 371);
		e.TabIndex = 5;
		e.VisualStyle = VisualStyle.Office2003;
		h.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 600);
		Controls.Add(this.m_c);
		FormBorderStyle = FormBorderStyle.None;
		KeyPreview = true;
		Name = "frmImportStd";
		RightToLeft = RightToLeft.Yes;
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ثبت شاگردان از فایل اکسل";
		Load += a;
		this.m_c.ResumeLayout(performLayout: false);
		this.m_c.PerformLayout();
		((ISupportInitialize)e).EndInit();
		ResumeLayout(performLayout: false);
	}
}
