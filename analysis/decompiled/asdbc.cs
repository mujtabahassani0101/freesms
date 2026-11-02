using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

public class asdbc : Form
{
	private IContainer m_a = null;

	private CrystalReportViewer b;

	public ReportClass c;

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
		b = new CrystalReportViewer();
		((Control)this).SuspendLayout();
		b.ActiveViewIndex = -1;
		((UserControl)b).BorderStyle = (BorderStyle)1;
		b.DisplayGroupTree = false;
		((Control)b).Dock = (DockStyle)5;
		((Control)b).Location = new Point(0, 0);
		((Control)b).Name = "crystalReportViewer1";
		b.SelectionFormula = "";
		b.ShowExportButton = false;
		b.ShowPrintButton = false;
		b.ShowRefreshButton = false;
		((Control)b).Size = new Size(498, 431);
		((Control)b).TabIndex = 0;
		b.ViewTimeSelectionFormula = "";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(498, 431);
		((Control)this).Controls.Add((Control)(object)b);
		((Form)this).FormBorderStyle = (FormBorderStyle)1;
		((Control)this).Name = "frmPrintDis";
		((Control)this).Text = "پرینت";
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).Load += a;
		((Control)this).ResumeLayout(false);
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
