using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x0200012C RID: 300
	public partial class fAddFile : Form
	{
		// Token: 0x06000DA3 RID: 3491 RVA: 0x00003415 File Offset: 0x00001615
		public fAddFile()
		{
			this.InitializeComponent();
			fAddFile.isAdd = false;
			this.ChangeLanguage();
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x001FDDC4 File Offset: 0x001FBFC4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x001FDE18 File Offset: 0x001FC018
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txbNameFile.Text.Trim();
			bool flag = text == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng điền tên thư mục!"), 1);
				this.txbNameFile.Focus();
			}
			else
			{
				bool flag2 = CommonSQL.CheckExitsFile(text);
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"), 1);
					this.txbNameFile.Focus();
				}
				else
				{
					bool flag3 = CommonSQL.InsertFileToDatabase(text);
					if (flag3)
					{
						fAddFile.isAdd = true;
						bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Thêm thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
						if (flag4)
						{
							base.Close();
						}
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm thư mục lỗi!"), 1);
					}
				}
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x001FDF64 File Offset: 0x001FC164
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x040016E6 RID: 5862
		public static bool isAdd;
	}
}
