using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

public class asda : Form
{
	public ReportClass a;

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
		c.ReportSource = this.a;
		c.ShowPrintButton = true;
		c.ShowExportButton = true;
	}

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
		if (true)
		{
		}
		c = new CrystalReportViewer();
		((Control)this).SuspendLayout();
		c.ActiveViewIndex = -1;
		((UserControl)c).BorderStyle = (BorderStyle)1;
		c.DisplayGroupTree = false;
		((Control)c).Dock = (DockStyle)5;
		((Control)c).Location = new Point(0, 0);
		((Control)c).Name = "crystalReportViewer1";
		c.SelectionFormula = "";
		c.ShowExportButton = false;
		c.ShowGroupTreeButton = false;
		c.ShowPrintButton = false;
		c.ShowRefreshButton = false;
		((Control)c).Size = new Size(498, 431);
		((Control)c).TabIndex = 0;
		c.ViewTimeSelectionFormula = "";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(498, 431);
		((Control)this).Controls.Add((Control)(object)c);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Control)this).Name = "frmPrint";
		((Control)this).Text = "پرینت";
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).Load += a;
		((Control)this).ResumeLayout(false);
	}
}
