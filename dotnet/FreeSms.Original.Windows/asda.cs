using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FreeSms.Reporting;


public class asda : Form
{
	public ReportClass __field_a;

	private IContainer b = null;

	private CrystalReportViewer c;

	public asda()
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		c.ReportSource = this.__field_a;
		c.ShowPrintButton = true;
		c.ShowExportButton = true;
	}
protected override void Dispose(bool A_0)
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
						num = 4;
					}
					else
					{
						num = 1;
					}
					continue;
				case 4:
					num = 0;
					continue;
				case 0:
					num2 = ((b == null) ? 1 : 0);
					goto IL_007c;
				case 2:
					b.Dispose();
					num = 5;
					continue;
				case 6:
					if (!flag)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 1:
					num2 = 1;
					goto IL_007c;
				case 5:
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
		c = new CrystalReportViewer();
		SuspendLayout();
		c.ActiveViewIndex = -1;
		c.BorderStyle = BorderStyle.FixedSingle;
		c.DisplayGroupTree = false;
		c.Dock = DockStyle.Fill;
		c.Location = new Point(0, 0);
		c.Name = "crystalReportViewer1";
		c.SelectionFormula = "";
		c.ShowExportButton = false;
		c.ShowGroupTreeButton = false;
		c.ShowPrintButton = false;
		c.ShowRefreshButton = false;
		c.Size = new Size(498, 431);
		c.TabIndex = 0;
		c.ViewTimeSelectionFormula = "";
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(498, 431);
		Controls.Add(c);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		Name = "frmPrint";
		Text = "پرینت";
		WindowState = FormWindowState.Maximized;
		Load += a;
		ResumeLayout(performLayout: false);
	}
}
