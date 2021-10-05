using System;
using System.Windows.Forms;
using MCommon;

namespace maxcare.Helper
{
	// Token: 0x0200018E RID: 398
	internal class DatagridviewHelper
	{
		// Token: 0x06001192 RID: 4498 RVA: 0x002C7630 File Offset: 0x002C5830
		public static void SetStatusDataGridViewWithWait(DataGridView dgv, int row, string colName, int timeWait = 0, string status = "Đợi {time} giây...")
		{
			try
			{
				int time_start = Environment.TickCount;
				while ((Environment.TickCount - time_start) / 1000 - timeWait < 0)
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[colName].Value = status.Replace("{time}", (timeWait - (Environment.TickCount - time_start) / 1000).ToString());
					}));
					MCommon.Common.DelayTime(0.5);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x002C7720 File Offset: 0x002C5920
		public static void SetStatusDataGridViewWithWait(DataGridView dgv, int row, string colName, int timeWait = 0, int timeStart = 0, string status = "Đợi {time} giây...")
		{
			try
			{
				int time_start = Environment.TickCount;
				while ((Environment.TickCount - time_start) / 1000 - timeWait < 0)
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[colName].Value = status.Replace("{time}", (timeStart - (Environment.TickCount - time_start) / 1000).ToString());
					}));
					MCommon.Common.DelayTime(0.5);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x002C780C File Offset: 0x002C5A0C
		public static string GetStatusDataGridView(DataGridView dgv, int row, int col)
		{
			string output = "";
			try
			{
				bool flag = dgv.Rows[row].Cells[col].Value != null;
				if (flag)
				{
					try
					{
						output = dgv.Rows[row].Cells[col].Value.ToString();
					}
					catch
					{
						dgv.Invoke(new MethodInvoker(delegate()
						{
							output = dgv.Rows[row].Cells[col].Value.ToString();
						}));
					}
				}
			}
			catch
			{
			}
			return output;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x002C7940 File Offset: 0x002C5B40
		public static string GetStatusDataGridView(DataGridView dgv, int row, string colName)
		{
			string output = "";
			try
			{
				bool flag = dgv.Rows[row].Cells[colName].Value != null;
				if (flag)
				{
					try
					{
						output = dgv.Rows[row].Cells[colName].Value.ToString();
					}
					catch
					{
						dgv.Invoke(new MethodInvoker(delegate()
						{
							output = dgv.Rows[row].Cells[colName].Value.ToString();
						}));
					}
				}
			}
			catch
			{
			}
			return output;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x002C7A74 File Offset: 0x002C5C74
		public static void SetStatusDataGridView(DataGridView dgv, int row, int col, object status)
		{
			try
			{
				try
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[col].Value = status;
					}));
				}
				catch
				{
					dgv.Rows[row].Cells[col].Value = status;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x002C7B50 File Offset: 0x002C5D50
		public static void SetStatusDataGridView(DataGridView dgv, int row, string colName, object status)
		{
			try
			{
				try
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[colName].Value = status;
					}));
				}
				catch
				{
					dgv.Rows[row].Cells[colName].Value = status;
				}
			}
			catch
			{
			}
		}
	}
}
