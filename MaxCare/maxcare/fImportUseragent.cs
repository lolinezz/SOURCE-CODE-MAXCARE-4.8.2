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
	// Token: 0x020000EA RID: 234
	public partial class fImportUseragent : Form
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x0000315E File Offset: 0x0000135E
		public fImportUseragent()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0012C9C0 File Offset: 0x0012ABC0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label1);
			Language.GetValue(this.label8);
			Language.GetValue(this.label2);
			Language.GetValue(this.rbLanLuot);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.ckbKhongNhapTaiKhoanDaCo);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0012CA78 File Offset: 0x0012AC78
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				List<string> list2 = new List<string>();
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thêm Useragent!"), 3);
				}
				else
				{
					int num = Convert.ToInt32(this.nudTaiKhoanPerUa.Value);
					for (int i = 0; i < list.Count; i++)
					{
						for (int j = 0; j < num; j++)
						{
							list2.Add(list[i]);
						}
					}
					bool @checked = this.rbNgauNhien.Checked;
					if (@checked)
					{
						list2 = MCommon.Common.ShuffleList(list2);
					}
					Queue<string> queue = new Queue<string>(list2);
					int k = 0;
					while (k < fmain.remote.dtgvAcc.Rows.Count)
					{
						bool flag2 = Convert.ToBoolean(fmain.remote.GetCellAccount(k, "cChose"));
						if (flag2)
						{
							bool flag3 = fmain.remote.GetCellAccount(k, "cUseragent") != "" && this.ckbKhongNhapTaiKhoanDaCo.Checked;
							if (!flag3)
							{
								bool flag4 = queue.Count == 0;
								if (flag4)
								{
									break;
								}
								string text = queue.Dequeue().Replace("'", "''");
								bool flag5 = CommonSQL.UpdateFieldToAccount(fmain.remote.GetCellAccount(k, "cId"), "useragent", text);
								if (flag5)
								{
									fmain.remote.SetCellAccount(k, "cUseragent", text, true);
								}
							}
						}
						IL_269:
						k++;
						continue;
						goto IL_269;
					}
					bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Nhập thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
					if (flag6)
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

		// Token: 0x0600096E RID: 2414 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0012CDB0 File Offset: 0x0012AFB0
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0012CDE8 File Offset: 0x0012AFE8
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Useragent ({0}):"), list.Count);
			}
			catch
			{
			}
		}

        private void fImportUseragent_Load(object sender, EventArgs e)
        {

        }
    }
}
