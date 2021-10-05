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
	// Token: 0x02000068 RID: 104
	public partial class fCapNhatDuLieu : Form
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x0004B818 File Offset: 0x00049A18
		public fCapNhatDuLieu()
		{
			this.InitializeComponent();
			this.cbbDinhDangNhap.SelectedIndex = 0;
			this.lstCbbDinhDang = new List<ComboBox>
			{
				this.cbbDinhDang1,
				this.cbbDinhDang2,
				this.cbbDinhDang3,
				this.cbbDinhDang4,
				this.cbbDinhDang5,
				this.cbbDinhDang6,
				this.cbbDinhDang7,
				this.cbbDinhDang8
			};
			fCapNhatDuLieu.isAdd = false;
			this.ChangeLanguage();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0004B8EC File Offset: 0x00049AEC
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label7);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0004B9A0 File Offset: 0x00049BA0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.lstAccountNotError = new List<string>();
			this.lstAccountError = new List<string>();
			try
			{
				List<string> list = this.txbAccount.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thông tin tài khoản!"), 1);
					this.txbAccount.Focus();
				}
				else
				{
					int selectedIndex = this.cbbDinhDangNhap.SelectedIndex;
					bool flag2 = selectedIndex == 5;
					if (flag2)
					{
						bool flag3 = false;
						for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
						{
							bool flag4 = this.lstCbbDinhDang[i].SelectedIndex > -1;
							if (flag4)
							{
								flag3 = true;
								break;
							}
						}
						bool flag5 = !flag3;
						if (flag5)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn định dạng tài khoản!"), 1);
							return;
						}
					}
					this.lblSuccess.Text = "0";
					this.lblError.Text = "0";
					this.lstAccount = new List<string>();
					switch (selectedIndex)
					{
					case 0:
					{
						int num = 2;
						for (int j = 0; j < list.Count; j++)
						{
							string[] array = list[j].Split(new char[]
							{
								'|'
							});
							bool flag6 = array.Count<string>() >= num;
							if (flag6)
							{
								this.lstAccount.Add(array[0] + "|" + array[1] + "|||||||");
								this.lstAccountNotError.Add(list[j]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[j]);
							}
						}
						break;
					}
					case 1:
					{
						int num = 3;
						for (int k = 0; k < list.Count; k++)
						{
							string[] array = list[k].Split(new char[]
							{
								'|'
							});
							bool flag7 = array.Count<string>() >= num;
							if (flag7)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									"|",
									array[1],
									"|||||",
									array[2],
									"||"
								}));
								this.lstAccountNotError.Add(list[k]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[k]);
							}
						}
						break;
					}
					case 2:
					{
						int num = 4;
						for (int l = 0; l < list.Count; l++)
						{
							string[] array = list[l].Split(new char[]
							{
								'|'
							});
							bool flag8 = array.Count<string>() >= num;
							if (flag8)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									"|",
									array[1],
									"|",
									array[2],
									"|",
									array[3],
									"|||||"
								}));
								this.lstAccountNotError.Add(list[l]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[l]);
							}
						}
						break;
					}
					case 3:
					{
						int num = 6;
						for (int m = 0; m < list.Count; m++)
						{
							string[] array = list[m].Split(new char[]
							{
								'|'
							});
							bool flag9 = array.Count<string>() >= num;
							if (flag9)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									"|",
									array[1],
									"|",
									array[2],
									"|",
									array[3],
									"|",
									array[4],
									"|",
									array[5],
									"|||"
								}));
								this.lstAccountNotError.Add(list[m]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[m]);
							}
						}
						break;
					}
					case 4:
					{
						int num = 7;
						for (int n = 0; n < list.Count; n++)
						{
							string[] array = list[n].Split(new char[]
							{
								'|'
							});
							bool flag10 = array.Count<string>() >= num;
							if (flag10)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									"|",
									array[1],
									"|",
									array[2],
									"|",
									array[3],
									"|",
									array[4],
									"|",
									array[5],
									"|",
									array[6],
									"||"
								}));
								this.lstAccountNotError.Add(list[n]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[n]);
							}
						}
						break;
					}
					case 5:
						for (int num2 = 0; num2 < list.Count; num2++)
						{
							string[] array = list[num2].Split(new char[]
							{
								'|'
							});
							string text = "";
							string text2 = "";
							string text3 = "";
							string text4 = "";
							string text5 = "";
							string text6 = "";
							string text7 = "";
							string text8 = "";
							try
							{
								string text9 = array[0];
								for (int num3 = 1; num3 < this.lstCbbDinhDang.Count; num3++)
								{
									switch (this.lstCbbDinhDang[num3 - 1].SelectedIndex)
									{
									case 0:
										text9 = array[num3];
										break;
									case 1:
										text = array[num3];
										break;
									case 2:
										text2 = array[num3];
										break;
									case 3:
										text3 = array[num3];
										break;
									case 4:
										text4 = array[num3];
										break;
									case 5:
										text5 = array[num3];
										break;
									case 6:
										text6 = array[num3];
										break;
									case 7:
										text7 = array[num3];
										break;
									case 8:
										text8 = ((array[num3] == "") ? "" : (array[num3] + "*" + this.cbbTypeProxy.SelectedIndex.ToString()));
										break;
									}
								}
								this.lstAccount.Add(string.Concat(new string[]
								{
									text9,
									"|",
									text,
									"|",
									text2,
									"|",
									text3,
									"|",
									text4,
									"|",
									text5,
									"|",
									text6,
									"|",
									text7,
									"|",
									text8
								}));
								this.lstAccountNotError.Add(list[num2]);
							}
							catch
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[num2]);
							}
						}
						break;
					}
					this.btnAdd.Invoke(new MethodInvoker(delegate()
					{
						this.btnAdd.Enabled = false;
					}));
					this.UpdateStatus(Language.GetValue("Đang cập nhật dữ liệu..."));
					for (int num4 = 0; num4 < this.lstAccount.Count; num4++)
					{
						bool flag11 = CommonSQL.UpdateAccountByUid(this.lstAccount[num4]);
						if (flag11)
						{
							this.IncrementLabel(this.lblSuccess);
						}
						else
						{
							this.IncrementLabel(this.lblError);
						}
					}
					this.btnAdd.Invoke(new MethodInvoker(delegate()
					{
						this.btnAdd.Enabled = true;
					}));
					this.lstAccountNotError.AddRange(this.lstAccountError);
					this.txbAccount.Lines = this.lstAccountNotError.ToArray();
					this.UpdateStatus(Language.GetValue("Cập nhật dữ liệu xong!"));
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Cập nhật dữ liệu xong!"), 1);
					fCapNhatDuLieu.isAdd = true;
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 1);
				MCommon.Common.ExportError(ex, "UpdateAccount");
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		private void UpdateStatus(string content)
		{
			Application.DoEvents();
			this.lblStatus.Invoke(new MethodInvoker(delegate()
			{
				this.lblStatus.Text = content;
			}));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0004CB04 File Offset: 0x0004AD04
		private void TxbAccount_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txbAccount.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblTotal.Text = list.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0004CB78 File Offset: 0x0004AD78
		private void IncrementLabel(Label lbl)
		{
			Application.DoEvents();
			Label lbl2 = lbl;
			lock (lbl2)
			{
				lbl.Invoke(new MethodInvoker(delegate()
				{
					int num = Convert.ToInt32(lbl.Text);
					num++;
					lbl.Text = num.ToString();
				}));
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.plDinhDangNhap.Visible = (this.cbbDinhDangNhap.SelectedIndex == this.cbbDinhDangNhap.Items.Count - 1);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0004CC44 File Offset: 0x0004AE44
		private bool CheckExistDinhDang()
		{
			bool result = false;
			List<int> list = new List<int>();
			for (int i = 0; i <= 6; i++)
			{
				int selectedIndex = this.lstCbbDinhDang[i].SelectedIndex;
				bool flag = selectedIndex != -1;
				if (flag)
				{
					bool flag2 = list.Contains(selectedIndex);
					if (flag2)
					{
						result = true;
						break;
					}
					list.Add(selectedIndex);
				}
			}
			return result;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0004CCF4 File Offset: 0x0004AEF4
		private void cbbDinhDang1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool visible = false;
			for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
			{
				bool flag = this.lstCbbDinhDang[i].Text == "Proxy";
				if (flag)
				{
					visible = true;
					break;
				}
			}
			this.label2.Visible = visible;
			this.cbbTypeProxy.Visible = visible;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		private void fCapNhatDuLieu_Load(object sender, EventArgs e)
		{
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x040002C5 RID: 709
		public static bool isAdd;

		// Token: 0x040002C6 RID: 710
		private List<ComboBox> lstCbbDinhDang;

		// Token: 0x040002C7 RID: 711
		private List<string> lstAccount = new List<string>();

		// Token: 0x040002C8 RID: 712
		private List<string> lstAccountNotError = new List<string>();

		// Token: 0x040002C9 RID: 713
		private List<string> lstAccountError = new List<string>();
	}
}
