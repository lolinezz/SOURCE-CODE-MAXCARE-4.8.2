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
	// Token: 0x02000070 RID: 112
	public partial class fEditFile : Form
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public fEditFile(string idFile, string namefile)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.idFile = idFile;
			this.nameFileOld = namefile;
			this.isSuccess = false;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00055908 File Offset: 0x00053B08
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0005596C File Offset: 0x00053B6C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtNameFileNew.Text.Trim();
			bool flag = text == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng điền tên thư mục mới!"), 3);
				this.txtNameFileNew.Focus();
			}
			else
			{
				bool flag2 = CommonSQL.CheckExitsFile(text);
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"), 3);
					this.txtNameFileNew.Focus();
				}
				else
				{
					bool flag3 = text.Equals(this.txtNameFileOld.Text.Trim());
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Tên thư mục mới phải khác thư mục cũ!"), 3);
						this.txtNameFileNew.Focus();
					}
					else
					{
						bool flag4 = CommonSQL.UpdateFileNameToDatabase(this.idFile, text);
						if (flag4)
						{
							this.isSuccess = true;
							bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Cập nhật thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
							if (flag5)
							{
								base.Close();
							}
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Cập nhật tên thư mục lỗi!"), 1);
						}
					}
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00055B28 File Offset: 0x00053D28
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00055B60 File Offset: 0x00053D60
		private void fEditFile_Load(object sender, EventArgs e)
		{
			this.txtNameFileOld.Text = this.nameFileOld;
		}

		// Token: 0x0400033B RID: 827
		private string idFile;

		// Token: 0x0400033C RID: 828
		private string nameFileOld;

		// Token: 0x0400033D RID: 829
		public bool isSuccess = false;
	}
}
