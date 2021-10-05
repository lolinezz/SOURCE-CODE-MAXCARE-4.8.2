using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x02000127 RID: 295
	public partial class fImportAccount : Form
	{
		// Token: 0x06000D87 RID: 3463 RVA: 0x001F78B0 File Offset: 0x001F5AB0
		public fImportAccount(string idFile)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.Load_cbbThuMuc();
			bool flag = idFile != "" && idFile != "-1" && idFile != "999999";
			if (flag)
			{
				this.cbbThuMuc.SelectedValue = idFile;
			}
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
				this.cbbDinhDang8,
				this.cbbDinhDang9
			};
			fImportAccount.isAddFile = false;
			fImportAccount.isAddAccount = false;
			fImportAccount.idFileAdded = -1;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x001F7A1C File Offset: 0x001F5C1C
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

		// Token: 0x06000D89 RID: 3465 RVA: 0x001F7B10 File Offset: 0x001F5D10
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label6);
			Language.GetValue(this.label2);
			Language.GetValue(this.label7);
			Language.GetValue(this.label16);
			Language.GetValue(this.button1);
			Language.GetValue(this.label8);
			Language.GetValue(this.label15);
			Language.GetValue(this.ckbCheckThongTin);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x001F7C0C File Offset: 0x001F5E0C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txbAccount.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thông tin tài khoản!"), 3);
					this.txbAccount.Focus();
				}
				else
				{
					bool flag2 = this.cbbThuMuc.SelectedValue == null;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn thư mục!"), 3);
					}
					else
					{
						string idFile = this.cbbThuMuc.SelectedValue.ToString();
						bool isCheckThongTin = this.ckbCheckThongTin.Checked;
						int selectedIndex = this.cbbDinhDangNhap.SelectedIndex;
						bool flag3 = selectedIndex == 6;
						if (flag3)
						{
							bool flag4 = false;
							for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
							{
								bool flag5 = this.lstCbbDinhDang[i].SelectedIndex > -1;
								if (flag5)
								{
									flag4 = true;
									break;
								}
							}
							bool flag6 = !flag4;
							if (flag6)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn định dạng tài khoản!"), 3);
								return;
							}
						}
						int maxThread = 100;
						bool flag7 = list.Count < 100;
						if (flag7)
						{
							maxThread = list.Count;
						}
						this.lblSuccess.Text = "0";
						this.lblError.Text = "0";
						this.lblWallDie.Text = "0";
						this.lblKhongCheckDuoc.Text = "0";
						this.lblWallLive.Text = "0";
						this.lstAccount = new List<string>();
						string[] temp;
						switch (selectedIndex)
						{
						case 0:
						{
							int num = 3;
							for (int j = 0; j < list.Count; j++)
							{
								temp = list[j].Split(new char[]
								{
									'|'
								});
								bool flag8 = temp.Count<string>() >= num;
								if (flag8)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										"|",
										temp[1],
										"|||||",
										temp[2],
										"|||"
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 1:
							for (int k = 0; k < list.Count; k++)
							{
								this.lstAccount.Add("|||" + list[k] + "||||||");
							}
							break;
						case 2:
						{
							int num = 2;
							for (int l = 0; l < list.Count; l++)
							{
								temp = list[l].Split(new char[]
								{
									'|'
								});
								bool flag9 = temp.Count<string>() >= num;
								if (flag9)
								{
									this.lstAccount.Add(temp[0] + "|" + temp[1] + "||||||||");
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 3:
						{
							int num = 4;
							for (int m = 0; m < list.Count; m++)
							{
								temp = list[m].Split(new char[]
								{
									'|'
								});
								bool flag10 = temp.Count<string>() >= num;
								if (flag10)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										"|",
										temp[1],
										"|",
										temp[2],
										"|",
										temp[3],
										"||||||"
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 4:
						{
							int num = 6;
							for (int n = 0; n < list.Count; n++)
							{
								temp = list[n].Split(new char[]
								{
									'|'
								});
								bool flag11 = temp.Count<string>() >= num;
								if (flag11)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										"|",
										temp[1],
										"|",
										temp[2],
										"|",
										temp[3],
										"|",
										temp[4],
										"|",
										temp[5],
										"||||"
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 5:
						{
							int num = 7;
							for (int num2 = 0; num2 < list.Count; num2++)
							{
								temp = list[num2].Split(new char[]
								{
									'|'
								});
								bool flag12 = temp.Count<string>() >= num;
								if (flag12)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										"|",
										temp[1],
										"|",
										temp[2],
										"|",
										temp[3],
										"|",
										temp[4],
										"|",
										temp[5],
										"|",
										temp[6],
										"|||"
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 6:
							for (int num3 = 0; num3 < list.Count; num3++)
							{
								temp = list[num3].Split(new char[]
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
								string text9 = "";
								string text10 = "";
								try
								{
									for (int num4 = 0; num4 < this.lstCbbDinhDang.Count; num4++)
									{
										switch (this.lstCbbDinhDang[num4].SelectedIndex)
										{
										case 0:
											text = temp[num4];
											break;
										case 1:
											text2 = temp[num4];
											break;
										case 2:
											text3 = temp[num4];
											break;
										case 3:
											text4 = temp[num4];
											break;
										case 4:
											text5 = temp[num4];
											break;
										case 5:
											text6 = temp[num4];
											break;
										case 6:
											text7 = temp[num4];
											break;
										case 7:
											text8 = temp[num4];
											break;
										case 8:
										{
											bool flag13 = temp[num4].Trim() == "";
											if (flag13)
											{
												text9 = "";
											}
											else
											{
												text9 = temp[num4] + "*0";
											}
											break;
										}
										case 9:
											text10 = temp[num4];
											break;
										}
									}
									this.lstAccount.Add(string.Concat(new string[]
									{
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
										text8,
										"|",
										text9,
										"|",
										text10
									}));
								}
								catch
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						List<string> lstQuery = new List<string>();
						this.lstThread = new List<Thread>();
						new Thread(delegate()
						{
							try
							{
								this.btnAdd.Invoke(new MethodInvoker(delegate()
								{
									this.btnAdd.Enabled = false;
								}));
								this.UpdateStatus(Language.GetValue("Chuẩn bị thêm tài khoản..."), this.lblStatus);
								bool ischeckThongTin = isCheckThongTin;
								if (ischeckThongTin)
								{
									int num5 = 0;
									while (num5 < this.lstAccount.Count)
									{
										bool flag14 = this.lstThread.Count < maxThread;
										if (flag14)
										{
											int stt = num5++;
											this.UpdateStatus(string.Format(Language.GetValue("Đang check thông tin {0}/{1}..."), num5, this.lstAccount.Count), this.lblStatus);
											Thread thread = new Thread(delegate()
											{
												try
												{
													string text14 = this.lstAccount[stt];
													bool flag19 = text14.Trim() == "";
													if (!flag19)
													{
														string[] array2 = text14.Split(new char[]
														{
															'|'
														});
														string text15 = array2[0];
														string pass2 = array2[1];
														string token2 = array2[2];
														string text16 = array2[3];
														string email2 = array2[4];
														string passMail2 = array2[5];
														string fa2 = array2[6];
														string useragent2 = array2[7];
														string proxy2 = array2[8];
														string birthday2 = array2[9];
														string name2 = "";
														string friends2 = "";
														string groups2 = "";
														string gender2 = "";
														string text17 = "unknow";
														bool flag20 = text15 == "";
														if (flag20)
														{
															text15 = Regex.Match(text16, "c_user=(.*?);").Groups[1].Value;
														}
														bool flag21 = text15 == "";
														if (flag21)
														{
															text17 = "Die";
														}
														else
														{
															string text18 = CommonRequest.CheckInfoUsingUid(text15);
															bool flag22 = text18.StartsWith("0|");
															if (flag22)
															{
																bool flag23 = CommonRequest.CheckLiveWall(text15).StartsWith("0|");
																if (flag23)
																{
																	text17 = "Die";
																}
															}
															else
															{
																bool flag24 = text18.StartsWith("1|");
																if (flag24)
																{
																	temp = text18.Split(new char[]
																	{
																		'|'
																	});
																	name2 = temp[2];
																	gender2 = temp[3].ToLower();
																	birthday2 = temp[4];
																	friends2 = temp[5];
																	groups2 = temp[6];
																	text17 = "Live";
																}
															}
														}
														string text19 = text17;
														string a = text19;
														if (!(a == "Live"))
														{
															if (!(a == "Die"))
															{
																this.IncrementLabel(this.lblKhongCheckDuoc, -1);
															}
															else
															{
																this.IncrementLabel(this.lblWallDie, -1);
															}
														}
														else
														{
															this.IncrementLabel(this.lblWallLive, -1);
														}
														lstQuery.Add(CommonSQL.ConvertToSqlInsertAccount(text15, pass2, token2, text16, email2, name2, friends2, groups2, birthday2, gender2, text17, fa2, idFile, passMail2, useragent2, proxy2));
													}
												}
												catch
												{
												}
											});
											this.lstThread.Add(thread);
											thread.Start();
										}
										else
										{
											for (int num6 = 0; num6 < this.lstThread.Count; num6++)
											{
												bool flag15 = !this.lstThread[num6].IsAlive;
												if (flag15)
												{
													this.lstThread.RemoveAt(num6--);
												}
											}
										}
									}
									for (int num7 = 0; num7 < this.lstThread.Count; num7++)
									{
										this.lstThread[num7].Join();
									}
								}
								else
								{
									for (int num8 = 0; num8 < this.lstAccount.Count; num8++)
									{
										try
										{
											string text11 = this.lstAccount[num8];
											bool flag16 = text11.Trim() == "";
											if (flag16)
											{
												return;
											}
											string[] array = text11.Split(new char[]
											{
												'|'
											});
											string text12 = array[0];
											string pass = array[1];
											string token = array[2];
											string text13 = array[3];
											string email = array[4];
											string passMail = array[5];
											string fa = array[6];
											string useragent = array[7];
											string proxy = array[8];
											string birthday = array[9];
											string name = "";
											string friends = "";
											string groups = "";
											string gender = "";
											string info = "unknow";
											bool flag17 = text12 == "";
											if (flag17)
											{
												text12 = Regex.Match(text13, "c_user=(.*?);").Groups[1].Value;
											}
											lstQuery.Add(CommonSQL.ConvertToSqlInsertAccount(text12, pass, token, text13, email, name, friends, groups, birthday, gender, info, fa, idFile, passMail, useragent, proxy));
										}
										catch
										{
										}
									}
								}
								this.UpdateStatus(Language.GetValue("Đang thêm tài khoản..."), this.lblStatus);
								bool flag18 = lstQuery.Count >= 0;
								if (flag18)
								{
									lstQuery = CommonSQL.ConvertToSqlInsertAccount(lstQuery);
									for (int num9 = 0; num9 < lstQuery.Count; num9++)
									{
										this.IncrementLabel(this.lblSuccess, Connector.Instance.ExecuteNonQuery(lstQuery[num9]));
									}
								}
								this.UpdateStatus((Convert.ToInt32(this.lblTotal.Text) - Convert.ToInt32(this.lblSuccess.Text)).ToString() ?? "", this.lblError);
								this.btnAdd.Invoke(new MethodInvoker(delegate()
								{
									this.btnAdd.Enabled = true;
								}));
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm tài khoản thành công!"), 1);
								this.UpdateStatus(Language.GetValue("Thêm tài khoản thành công!"), this.lblStatus);
								fImportAccount.isAddAccount = true;
								fImportAccount.idFileAdded = Convert.ToInt32(idFile);
							}
							catch (Exception ex2)
							{
								MCommon.Common.ExportError(null, ex2, "AddAccount");
							}
						}).Start();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
				MCommon.Common.ExportError(null, ex, "AddAccount");
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x001F8D50 File Offset: 0x001F6F50
		private void UpdateStatus(string content, Label lbl)
		{
			lbl.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				lbl.Text = content;
			}));
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x001F8D94 File Offset: 0x001F6F94
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

		// Token: 0x06000D8E RID: 3470 RVA: 0x001F8E08 File Offset: 0x001F7008
		private void IncrementLabel(Label lbl, int count = -1)
		{
			bool flag = count == -1;
			if (flag)
			{
				lbl.Invoke(new MethodInvoker(delegate()
				{
					Application.DoEvents();
					lbl.Text = (Convert.ToInt32(lbl.Text) + ((count == -1) ? 1 : count)).ToString();
				}));
			}
			else
			{
				lbl.Invoke(new MethodInvoker(delegate()
				{
					Application.DoEvents();
					lbl.Text = (Convert.ToInt32(lbl.Text) + count).ToString();
				}));
			}
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x001F8E84 File Offset: 0x001F7084
		private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.plDinhDangNhap.Visible = (this.cbbDinhDangNhap.SelectedIndex == this.cbbDinhDangNhap.Items.Count - 1);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x001F8ED0 File Offset: 0x001F70D0
		private void button1_Click(object sender, EventArgs e)
		{
			fAddFile f = new fAddFile();
			MCommon.Common.ShowForm(f);
			bool isAdd = fAddFile.isAdd;
			if (isAdd)
			{
				this.Load_cbbThuMuc();
				this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 1;
				fImportAccount.isAddFile = true;
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x001F8F3C File Offset: 0x001F713C
		private bool CheckExistDinhDang()
		{
			bool result = false;
			List<int> list = new List<int>();
			for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
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

		// Token: 0x06000D92 RID: 3474 RVA: 0x001F8FF0 File Offset: 0x001F71F0
		private void cbbDinhDang1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.CheckExistDinhDang();
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Tùy chọn này đã tồn tại, vui lòng chọn tùy chọn khác!"), 3);
				(sender as ComboBox).SelectedIndex = -1;
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00054604 File Offset: 0x00052804
		private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00054604 File Offset: 0x00052804
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040016A1 RID: 5793
		public static bool isAddAccount = false;

		// Token: 0x040016A2 RID: 5794
		public static int idFileAdded = -1;

		// Token: 0x040016A3 RID: 5795
		public static bool isAddFile = false;

		// Token: 0x040016A4 RID: 5796
		private List<ComboBox> lstCbbDinhDang;

		// Token: 0x040016A5 RID: 5797
		private int indexOld = 0;

		// Token: 0x040016A6 RID: 5798
		private List<string> lstAccount = new List<string>();

		// Token: 0x040016A7 RID: 5799
		private List<Thread> lstThread = null;

		// Token: 0x040016A8 RID: 5800
		private object objLock = new object();

        private void fImportAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
