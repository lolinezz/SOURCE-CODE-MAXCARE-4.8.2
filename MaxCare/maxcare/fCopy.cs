using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;

namespace maxcare
{
	// Token: 0x02000123 RID: 291
	public partial class fCopy : Form
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x001E2D9C File Offset: 0x001E0F9C
		public fCopy(List<string> lstAcc)
		{
			this.InitializeComponent();
			this.lst = lstAcc;
			this.ChangeLanguage();
			this.lstCbbDinhDang = new List<ComboBox>
			{
				this.cbbDinhDang1,
				this.cbbDinhDang2,
				this.cbbDinhDang3,
				this.cbbDinhDang4,
				this.cbbDinhDang5,
				this.cbbDinhDang6,
				this.cbbDinhDang7,
				this.cbbDinhDang8,
				this.cbbDinhDang9
			};
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x001E2E58 File Offset: 0x001E1058
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.button1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x001E2EBC File Offset: 0x001E10BC
		private void SaveDinhDang()
		{
			try
			{
				string text = "";
				for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
				{
					text = text + this.lstCbbDinhDang[i].SelectedIndex.ToString() + "|";
				}
				text = text.TrimEnd(new char[]
				{
					'|'
				});
				File.WriteAllText("settings\\format_copy.txt", text);
			}
			catch
			{
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x001E2FAC File Offset: 0x001E11AC
		private void LoadDinhDang()
		{
			try
			{
				bool flag = File.Exists("settings\\format_copy.txt");
				if (flag)
				{
					string text = File.ReadAllText("settings\\format_copy.txt");
					for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
					{
						this.lstCbbDinhDang[i].SelectedIndex = Convert.ToInt32(text.Split(new char[]
						{
							'|'
						})[i]);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x001E3088 File Offset: 0x001E1288
		private void ResetDinhDang()
		{
			try
			{
				for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
				{
					this.lstCbbDinhDang[i].SelectedIndex = -1;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x001E3108 File Offset: 0x001E1308
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				for (int i = this.lstCbbDinhDang.Count - 1; i >= 0; i--)
				{
					bool flag = this.lstCbbDinhDang[i].SelectedIndex != -1;
					if (flag)
					{
						num = i + 1;
						break;
					}
				}
				bool flag2 = num == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("vui lòng chọn định dạng cần copy!"), 3);
				}
				else
				{
					this.SaveDinhDang();
					for (int j = 0; j < this.lst.Count; j++)
					{
						string text = "";
						string[] array = this.lst[j].Split(new char[]
						{
							'|'
						});
						for (int k = 0; k < this.lstCbbDinhDang.Count; k++)
						{
							bool flag3 = this.lstCbbDinhDang[k].SelectedIndex != -1;
							if (flag3)
							{
								text += array[this.lstCbbDinhDang[k].SelectedIndex];
							}
							text += "|";
						}
						text = text.TrimEnd(new char[]
						{
							'|'
						});
						for (int l = text.Split(new char[]
						{
							'|'
						}).Count<string>(); l < num; l++)
						{
							text += "|";
						}
						list.Add(text);
					}
					string text2 = string.Join("\r\n", list);
					Clipboard.SetText(text2);
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Copy thành công!"), 1);
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x001E3454 File Offset: 0x001E1654
		private void button1_Click(object sender, EventArgs e)
		{
			this.ResetDinhDang();
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x001E3470 File Offset: 0x001E1670
		private void fCopy_Load(object sender, EventArgs e)
		{
			this.LoadDinhDang();
		}

		// Token: 0x040015A6 RID: 5542
		private List<ComboBox> lstCbbDinhDang;

		// Token: 0x040015A7 RID: 5543
		private List<string> lst = new List<string>();
	}
}
