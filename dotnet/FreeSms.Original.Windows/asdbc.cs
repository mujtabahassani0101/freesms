using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FreeSms.Reporting;


public class asdbc : Form
{
	private IContainer m_a = null;

	private CrystalReportViewer b;

	public ReportClass c;
protected override void Dispose(bool A_0)
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
						num = 5;
					}
					else
					{
						num = 0;
					}
					continue;
				case 5:
					num = 3;
					continue;
				case 3:
					num2 = ((this.m_a == null) ? 1 : 0);
					goto IL_007c;
				case 1:
					this.m_a.Dispose();
					num = 2;
					continue;
				case 6:
					if (!flag)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 0:
					num2 = 1;
					goto IL_007c;
				case 2:
					{
						base.Dispose(A_0);
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
		if (true)
		{
		}
		b = new CrystalReportViewer();
		SuspendLayout();
		b.ActiveViewIndex = -1;
		b.BorderStyle = BorderStyle.FixedSingle;
		b.DisplayGroupTree = false;
		b.Dock = DockStyle.Fill;
		b.Location = new Point(0, 0);
		b.Name = "crystalReportViewer1";
		b.SelectionFormula = "";
		b.ShowExportButton = false;
		b.ShowPrintButton = false;
		b.ShowRefreshButton = false;
		b.Size = new Size(498, 431);
		b.TabIndex = 0;
		b.ViewTimeSelectionFormula = "";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(498, 431);
		Controls.Add(b);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		Name = "frmPrintDis";
		Text = "پرینت";
		WindowState = FormWindowState.Maximized;
		Load += a;
		ResumeLayout(performLayout: false);
	}

	public asdbc()
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		b.ReportSource = c;
	}
}
