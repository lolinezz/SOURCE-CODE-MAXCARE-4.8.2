using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x020000E9 RID: 233
	public partial class fImportProxy : Form
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x00003132 File Offset: 0x00001332
		public fImportProxy()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0012A8B0 File Offset: 0x00128AB0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.label3);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.rbLanLuot);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.ckbKhongNhapTaiKhoanDaCo);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0012A97C File Offset: 0x00128B7C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtProxy.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				List<string> list2 = new List<string>();
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thêm Proxy!"), 3);
				}
				else
				{
					int num = Convert.ToInt32(this.nudTaiKhoanPerUa.Value);
					for (int i = 0; i < num; i++)
					{
						list2.AddRange(list);
					}
					bool @checked = this.rbNgauNhien.Checked;
					if (@checked)
					{
						list2 = MCommon.Common.ShuffleList(list2);
					}
					Queue<string> queue = new Queue<string>(list2);
					int selectedIndex = this.cbbTypeProxy.SelectedIndex;
					List<string> list3 = new List<string>();
					int j = 0;
					while (j < fmain.remote.dtgvAcc.Rows.Count)
					{
						bool flag2 = Convert.ToBoolean(fmain.remote.GetCellAccount(j, "cChose"));
						if (flag2)
						{
							bool flag3 = fmain.remote.GetCellAccount(j, "cProxy") != "" && this.ckbKhongNhapTaiKhoanDaCo.Checked;
							if (!flag3)
							{
								bool flag4 = queue.Count == 0;
								if (flag4)
								{
									break;
								}
								string str = (queue.Dequeue() + "*" + selectedIndex.ToString()).Replace("'", "''");
								list3.Add(fmain.remote.GetCellAccount(j, "cId") + "|" + str);
							}
						}
						IL_24A:
						j++;
						continue;
						goto IL_24A;
					}
					bool flag5 = CommonSQL.UpdateMultiField("proxy", list3, "accounts");
					bool flag6 = flag5;
					if (flag6)
					{
						queue = new Queue<string>(list2);
						int k = 0;
						while (k < fmain.remote.dtgvAcc.Rows.Count)
						{
							bool flag7 = Convert.ToBoolean(fmain.remote.GetCellAccount(k, "cChose"));
							if (flag7)
							{
								bool flag8 = fmain.remote.GetCellAccount(k, "cProxy") != "" && this.ckbKhongNhapTaiKhoanDaCo.Checked;
								if (!flag8)
								{
									bool flag9 = queue.Count == 0;
									if (flag9)
									{
										break;
									}
									string value = (queue.Dequeue() + "*" + selectedIndex.ToString()).Replace("'", "''");
									fmain.remote.SetCellAccount(k, "cProxy", value, true);
								}
							}
							IL_3FE:
							k++;
							continue;
							goto IL_3FE;
						}
					}
					bool flag10 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Nhập thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
					if (flag10)
					{
						base.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0012AE48 File Offset: 0x00129048
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0012AE80 File Offset: 0x00129080
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtProxy.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Proxy ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

        private void fImportProxy_Load(object sender, EventArgs e)
        {

        }
    }
}
