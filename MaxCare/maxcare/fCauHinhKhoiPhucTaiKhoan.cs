using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008A RID: 138
	public partial class fCauHinhKhoiPhucTaiKhoan : Form
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x0006CE08 File Offset: 0x0006B008
		public fCauHinhKhoiPhucTaiKhoan()
		{
			this.InitializeComponent();
			this.Load_cbbThuMuc();
			this.ChangeLanguage();
			fCauHinhKhoiPhucTaiKhoan.isOK = false;
			fCauHinhKhoiPhucTaiKhoan.typeThuMuc = 0;
			fCauHinhKhoiPhucTaiKhoan.idFile = "";
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0006CE68 File Offset: 0x0006B068
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.rbThuMucCu);
			Language.GetValue(this.rbThuMucKhac);
			Language.GetValue(this.button1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0006CEDC File Offset: 0x0006B0DC
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool @checked = this.rbThuMucKhac.Checked;
			if (@checked)
			{
				bool flag = this.cbbThuMuc.SelectedIndex == -1;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm thư mục để lưu tài khoản!"), 3);
					return;
				}
				fCauHinhKhoiPhucTaiKhoan.typeThuMuc = 1;
				fCauHinhKhoiPhucTaiKhoan.idFile = this.cbbThuMuc.SelectedValue.ToString();
			}
			fCauHinhKhoiPhucTaiKhoan.isOK = true;
			base.Close();
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0006CF88 File Offset: 0x0006B188
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.rbThuMucKhac_CheckedChanged(null, null);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0006CFA4 File Offset: 0x0006B1A4
		private void button1_Click(object sender, EventArgs e)
		{
			fAddFile f = new fAddFile();
			MCommon.Common.ShowForm(f);
			bool isAdd = fAddFile.isAdd;
			if (isAdd)
			{
				this.Load_cbbThuMuc();
				this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 1;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0006D008 File Offset: 0x0006B208
		private void Load_cbbThuMuc()
		{
			this.indexOld = this.cbbThuMuc.SelectedIndex;
			DataTable allFilesFromDatabase = CommonSQL.GetAllFilesFromDatabase(false);
			bool flag = allFilesFromDatabase.Rows.Count > 0;
			if (flag)
			{
				this.cbbThuMuc.DataSource = allFilesFromDatabase;
				this.cbbThuMuc.ValueMember = "id";
				this.cbbThuMuc.DisplayMember = "name";
				bool flag2 = this.indexOld == -1;
				if (flag2)
				{
					this.indexOld = 0;
				}
				this.cbbThuMuc.SelectedIndex = this.indexOld;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0006D0FC File Offset: 0x0006B2FC
		private void rbThuMucKhac_CheckedChanged(object sender, EventArgs e)
		{
			this.plThuMucKhac.Enabled = this.rbThuMucKhac.Checked;
		}

		// Token: 0x0400041C RID: 1052
		public static bool isOK = false;

		// Token: 0x0400041D RID: 1053
		public static int typeThuMuc = 0;

		// Token: 0x0400041E RID: 1054
		public static string idFile = "";

		// Token: 0x0400041F RID: 1055
		private int indexOld = 0;
	}
}
