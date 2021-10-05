using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x0200012D RID: 301
	public partial class fCauHinhChung : Form
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x0000343A File Offset: 0x0000163A
		public fCauHinhChung()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configGeneral", false);
			this.ChangeLanguage();
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x001FF048 File Offset: 0x001FD248
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label6);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label9);
			Language.GetValue(this.grChrome);
			Language.GetValue(this.ckbShowImageInteract);
			Language.GetValue(this.ckbAddChromeIntoForm);
			Language.GetValue(this.label10);
			Language.GetValue(this.label20);
			Language.GetValue(this.label29);
			Language.GetValue(this.label21);
			Language.GetValue(this.label2);
			Language.GetValue(this.label32);
			Language.GetValue(this.label31);
			Language.GetValue(this.label30);
			Language.GetValue(this.rbTocDoGoCham);
			Language.GetValue(this.rbTocDoGoBinhThuong);
			Language.GetValue(this.rbTocDoGoNhanh);
			Language.GetValue(this.linkLabel2);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label23);
			Language.GetValue(this.rbPhanBietMauNen);
			Language.GetValue(this.rbPhanBietMauChu);
			Language.GetValue(this.groupBox3);
			Language.GetValue(this.ckbKhongCheckIP);
			Language.GetValue(this.label26);
			Language.GetValue(this.label27);
			Language.GetValue(this.button5);
			Language.GetValue(this.rbNone);
			Language.GetValue(this.rbProxy);
			Language.GetValue(this.rbHma);
			Language.GetValue(this.rbDcom);
			Language.GetValue(this.button4);
			Language.GetValue(this.rbTinsoft);
			Language.GetValue(this.linkLabel3);
			Language.GetValue(this.rbApiUser);
			Language.GetValue(this.ckbWaitDoneAllTinsoft);
			Language.GetValue(this.rbApiProxy);
			Language.GetValue(this.label7);
			Language.GetValue(this.label8);
			Language.GetValue(this.label16);
			Language.GetValue(this.label17);
			Language.GetValue(this.ckbWaitDoneAllXproxy);
			Language.GetValue(this.label18);
			Language.GetValue(this.linkLabel1);
			Language.GetValue(this.label24);
			Language.GetValue(this.ckbWaitDoneAllTMProxy);
			Language.GetValue(this.label25);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x001FF3DC File Offset: 0x001FD5DC
		private void LoadCbbLocation()
		{
			Dictionary<string, string> dataSource = this.TinsoftGetListLocation();
			this.cbbLocationTinsoft.DataSource = new BindingSource(dataSource, null);
			this.cbbLocationTinsoft.ValueMember = "Key";
			this.cbbLocationTinsoft.DisplayMember = "Value";
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x001FF45C File Offset: 0x001FD65C
		public Dictionary<string, string> TinsoftGetListLocation()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			List<string> listCountryTinsoft = SetupFolder.GetListCountryTinsoft();
			for (int i = 0; i < listCountryTinsoft.Count; i++)
			{
				string[] array = listCountryTinsoft[i].Split(new char[]
				{
					'|'
				});
				dictionary.Add(array[0], array[1]);
			}
			return dictionary;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x001FF4E0 File Offset: 0x001FD6E0
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			this.LoadCbbLocation();
			this.LoadCbbSizeChrome();
			this.nudInteractThread.Value = this.settings.GetValueInt("nudInteractThread", 3);
			this.nudHideThread.Value = this.settings.GetValueInt("nudHideThread", 5);
			this.txbPathProfile.Text = ((this.settings.GetValue("txbPathProfile", "") == "") ? (Application.StartupPath + "\\profiles") : this.settings.GetValue("txbPathProfile", ""));
			bool flag = !Directory.Exists(this.txbPathProfile.Text) || this.txbPathProfile.Text.Trim() == "profiles";
			if (flag)
			{
				this.txbPathProfile.Text = Application.StartupPath + "\\profiles";
			}
			this.settings.Update("txbPathProfile", this.txbPathProfile.Text);
			this.ckbShowImageInteract.Checked = Convert.ToBoolean((this.settings.GetValue("ckbShowImageInteract", "") == "") ? "false" : this.settings.GetValue("ckbShowImageInteract", ""));
			this.ckbAddChromeIntoForm.Checked = this.settings.GetValueBool("ckbAddChromeIntoForm", false);
			this.nudDelayOpenChromeFrom.Value = this.settings.GetValueInt("nudDelayOpenChromeFrom", 1);
			this.nudDelayOpenChromeTo.Value = this.settings.GetValueInt("nudDelayOpenChromeTo", 1);
			this.nudDelayCloseChromeFrom.Value = this.settings.GetValueInt("nudDelayCloseChromeFrom", 0);
			this.nudDelayCloseChromeTo.Value = this.settings.GetValueInt("nudDelayCloseChromeTo", 0);
			this.cbbColumnChrome.Text = ((this.settings.GetValue("cbbColumnChrome", "") == "") ? "3" : this.settings.GetValue("cbbColumnChrome", ""));
			this.cbbRowChrome.Text = ((this.settings.GetValue("cbbRowChrome", "") == "") ? "2" : this.settings.GetValue("cbbRowChrome", ""));
			int valueInt = this.settings.GetValueInt("typeBrowser", 0);
			int num = valueInt;
			int num2 = num;
			if (num2 != 0)
			{
				if (num2 == 1)
				{
					this.rbChromium.Checked = true;
				}
			}
			else
			{
				this.rbChrome.Checked = true;
			}
			this.txtLinkToOtherBrowser.Text = this.settings.GetValue("txtLinkToOtherBrowser", "");
			this.ckbUsePortable.Checked = this.settings.GetValueBool("ckbUsePortable", false);
			this.txtPathToPortableZip.Text = this.settings.GetValue("txtPathToPortableZip", "");
			this.cbbSizeChrome.SelectedValue = this.settings.GetValue("sizeChrome", "default").ToString();
			bool flag2 = this.cbbSizeChrome.SelectedValue == null;
			if (flag2)
			{
				this.cbbSizeChrome.SelectedValue = "default";
			}
			switch (this.settings.GetValueInt("tocDoGoVanBan", 0))
			{
			case 0:
				this.rbTocDoGoCham.Checked = true;
				break;
			case 1:
				this.rbTocDoGoBinhThuong.Checked = true;
				break;
			case 2:
				this.rbTocDoGoNhanh.Checked = true;
				break;
			}
			this.ckbKhongCheckIP.Checked = this.settings.GetValueBool("ckbKhongCheckIP", false);
			this.nudChangeIpCount.Value = this.settings.GetValueInt("ip_nudChangeIpCount", 1);
			this.nudDelayCheckIP.Value = this.settings.GetValueInt("nudDelayCheckIP", 0);
			int valueInt2 = this.settings.GetValueInt("ip_iTypeChangeIp", 0);
			bool flag3 = valueInt2 == 0;
			if (flag3)
			{
				this.rbNone.Checked = true;
			}
			else
			{
				bool flag4 = valueInt2 == 1;
				if (flag4)
				{
					this.rbHma.Checked = true;
				}
				else
				{
					bool flag5 = valueInt2 == 2;
					if (flag5)
					{
						this.rbDcom.Checked = true;
					}
					else
					{
						bool flag6 = valueInt2 == 3;
						if (flag6)
						{
							this.rbSSH.Checked = true;
						}
						else
						{
							bool flag7 = valueInt2 == 4;
							if (flag7)
							{
								this.rbExpressVPN.Checked = true;
							}
							else
							{
								bool flag8 = valueInt2 == 5;
								if (flag8)
								{
									this.rbHotspot.Checked = true;
								}
								else
								{
									bool flag9 = valueInt2 == 6;
									if (flag9)
									{
										this.rbNordVPN.Checked = true;
									}
									else
									{
										bool flag10 = valueInt2 == 7;
										if (flag10)
										{
											this.rbTinsoft.Checked = true;
										}
										else
										{
											bool flag11 = valueInt2 == 8;
											if (flag11)
											{
												this.rbXproxy.Checked = true;
											}
											else
											{
												bool flag12 = valueInt2 == 9;
												if (flag12)
												{
													this.rbProxy.Checked = true;
												}
												else
												{
													bool flag13 = valueInt2 == 10;
													if (flag13)
													{
														this.rbTMProxy.Checked = true;
													}
													else
													{
														bool flag14 = valueInt2 == 11;
														if (flag14)
														{
															this.rbProxyv6.Checked = true;
														}
														else
														{
															bool flag15 = valueInt2 == 12;
															if (flag15)
															{
																this.rbShopLike.Checked = true;
															}
															else
															{
																bool flag16 = valueInt2 == 13;
																if (flag16)
																{
																	this.rbMinProxy.Checked = true;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			bool flag17 = this.settings.GetValueInt("typeDcom", 0) == 0;
			if (flag17)
			{
				this.rbDcomThuong.Checked = true;
			}
			else
			{
				this.rbDcomHilink.Checked = true;
			}
			this.txtProfileNameDcom.Text = this.settings.GetValue("ip_txtProfileNameDcom", "");
			this.txtUrlHilink.Text = this.settings.GetValue("txtUrlHilink", "http://192.168.1.1/html/home.html");
			this.txtNordVPN.Text = this.settings.GetValue("ip_txtNordVPN", "");
			this.cbbHostpot.SelectedIndex = this.settings.GetValueInt("ip_cbbHostpot", 0);
			bool flag18 = this.settings.GetValueInt("typeApiTinsoft", 0) == 0;
			if (flag18)
			{
				this.rbApiUser.Checked = true;
			}
			else
			{
				this.rbApiProxy.Checked = true;
			}
			this.txtApiUser.Text = this.settings.GetValue("txtApiUser", "");
			this.txtApiProxy.Text = this.settings.GetValue("txtApiProxy", "");
			this.cbbLocationTinsoft.SelectedValue = ((this.settings.GetValue("cbbLocationTinsoft", "") == "") ? "0" : this.settings.GetValue("cbbLocationTinsoft", ""));
			this.nudLuongPerIPTinsoft.Value = this.settings.GetValueInt("nudLuongPerIPTinsoft", 0);
			this.ckbWaitDoneAllTinsoft.Checked = this.settings.GetValueBool("ckbWaitDoneAllTinsoft", false);
			this.txtServiceURLXProxy.Text = this.settings.GetValue("txtServiceURLXProxy", "");
			int valueInt3 = this.settings.GetValueInt("typeProxy", 0);
			bool flag19 = valueInt3 == 0;
			if (flag19)
			{
				this.rbHttpProxy.Checked = true;
			}
			else
			{
				this.rbSock5Proxy.Checked = true;
			}
			this.txtListProxy.Text = this.settings.GetValue("txtListProxy", "");
			this.nudLuongPerIPXProxy.Value = this.settings.GetValueInt("nudLuongPerIPXProxy", 0);
			this.nudDelayResetXProxy.Value = this.settings.GetValueInt("nudDelayResetXProxy", 5);
			this.ckbWaitDoneAllXproxy.Checked = this.settings.GetValueBool("ckbWaitDoneAllXproxy", false);
			this.txtApiKeyTMProxy.Text = this.settings.GetValue("txtApiKeyTMProxy", "");
			this.nudLuongPerIPTMProxy.Value = this.settings.GetValueInt("nudLuongPerIPTMProxy", 1);
			this.ckbWaitDoneAllTMProxy.Checked = this.settings.GetValueBool("ckbWaitDoneAllTMProxy", false);
			this.txtApiProxyv6.Text = this.settings.GetValue("txtApiProxyv6", "");
			this.txtListProxyv6.Text = this.settings.GetValue("txtListProxyv6", "");
			this.nudLuongPerIPProxyv6.Value = this.settings.GetValueInt("nudLuongPerIPProxyv6", 0);
			this.txtApiShopLike.Text = this.settings.GetValue("txtApiShopLike", "");
			this.nudLuongPerIPShopLike.Value = this.settings.GetValueInt("nudLuongPerIPShopLike", 0);
			this.txtApiKeyMinProxy.Text = this.settings.GetValue("txtApiKeyMinProxy", "");
			this.nudLuongPerIPMinProxy.Value = this.settings.GetValueInt("nudLuongPerIPMinProxy", 0);
			bool flag20 = this.settings.GetValueInt("typePhanBietMau", 0) == 0;
			if (flag20)
			{
				this.rbPhanBietMauNen.Checked = true;
			}
			else
			{
				this.rbPhanBietMauChu.Checked = true;
			}
			this.CheckedChangedFull();
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00200984 File Offset: 0x001FEB84
		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.settings.Update("nudInteractThread", this.nudInteractThread.Value);
				this.settings.Update("nudHideThread", this.nudHideThread.Value);
				this.settings.Update("txbPathProfile", this.txbPathProfile.Text);
				this.settings.Update("ckbShowImageInteract", this.ckbShowImageInteract.Checked);
				this.settings.Update("ckbAddChromeIntoForm", this.ckbAddChromeIntoForm.Checked);
				this.settings.Update("nudWidthChrome", this.nudWidthChrome.Value);
				this.settings.Update("nudHeighChrome", this.nudHeighChrome.Value);
				this.settings.Update("nudDelayOpenChromeFrom", this.nudDelayOpenChromeFrom.Value);
				this.settings.Update("nudDelayOpenChromeTo", this.nudDelayOpenChromeTo.Value);
				this.settings.Update("nudDelayCloseChromeFrom", this.nudDelayCloseChromeFrom.Value);
				this.settings.Update("nudDelayCloseChromeTo", this.nudDelayCloseChromeTo.Value);
				this.settings.Update("cbbColumnChrome", this.cbbColumnChrome.Text);
				this.settings.Update("cbbRowChrome", this.cbbRowChrome.Text);
				int num = 0;
				bool @checked = this.rbChromium.Checked;
				if (@checked)
				{
					num = 1;
				}
				this.settings.Update("typeBrowser", num);
				this.settings.Update("txtLinkToOtherBrowser", this.txtLinkToOtherBrowser.Text.Trim());
				this.settings.Update("ckbUsePortable", this.ckbUsePortable.Checked);
				this.settings.Update("txtPathToPortableZip", this.txtPathToPortableZip.Text.Trim());
				bool flag = num != 0 && this.txtLinkToOtherBrowser.Text.Trim() == "";
				if (flag)
				{
					string arg = "";
					switch (num)
					{
					case 1:
						arg = "Chromium";
						break;
					case 2:
						arg = "Cốc cốc";
						break;
					case 3:
						arg = "Slimjet";
						break;
					}
					MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Vui lòng nhập đường dẫn đến file chạy của trình duyệt {0}!"), arg), 2);
				}
				else
				{
					bool flag2 = this.cbbSizeChrome.Items.Count > 0;
					if (flag2)
					{
						bool flag3 = this.cbbSizeChrome.SelectedValue.ToString() != "";
						if (flag3)
						{
							this.settings.Update("sizeChrome", this.cbbSizeChrome.SelectedValue.ToString());
						}
					}
					bool checked2 = this.rbTocDoGoCham.Checked;
					if (checked2)
					{
						this.settings.Update("tocDoGoVanBan", 0);
					}
					else
					{
						bool checked3 = this.rbTocDoGoBinhThuong.Checked;
						if (checked3)
						{
							this.settings.Update("tocDoGoVanBan", 1);
						}
						else
						{
							this.settings.Update("tocDoGoVanBan", 2);
						}
					}
					this.settings.Update("ckbKhongCheckIP", this.ckbKhongCheckIP.Checked);
					this.settings.Update("ip_nudChangeIpCount", this.nudChangeIpCount.Value);
					this.settings.Update("nudDelayCheckIP", this.nudDelayCheckIP.Value);
					int num2 = 0;
					bool checked4 = this.rbNone.Checked;
					if (checked4)
					{
						num2 = 0;
					}
					else
					{
						bool checked5 = this.rbHma.Checked;
						if (checked5)
						{
							num2 = 1;
						}
						else
						{
							bool checked6 = this.rbDcom.Checked;
							if (checked6)
							{
								num2 = 2;
							}
							else
							{
								bool checked7 = this.rbSSH.Checked;
								if (checked7)
								{
									num2 = 3;
								}
								else
								{
									bool checked8 = this.rbExpressVPN.Checked;
									if (checked8)
									{
										num2 = 4;
									}
									else
									{
										bool checked9 = this.rbHotspot.Checked;
										if (checked9)
										{
											num2 = 5;
										}
										else
										{
											bool checked10 = this.rbNordVPN.Checked;
											if (checked10)
											{
												num2 = 6;
											}
											else
											{
												bool checked11 = this.rbTinsoft.Checked;
												if (checked11)
												{
													num2 = 7;
												}
												else
												{
													bool checked12 = this.rbXproxy.Checked;
													if (checked12)
													{
														num2 = 8;
													}
													else
													{
														bool checked13 = this.rbProxy.Checked;
														if (checked13)
														{
															num2 = 9;
														}
														else
														{
															bool checked14 = this.rbTMProxy.Checked;
															if (checked14)
															{
																num2 = 10;
															}
															else
															{
																bool checked15 = this.rbProxyv6.Checked;
																if (checked15)
																{
																	num2 = 11;
																}
																else
																{
																	bool checked16 = this.rbShopLike.Checked;
																	if (checked16)
																	{
																		num2 = 12;
																	}
																	else
																	{
																		bool checked17 = this.rbMinProxy.Checked;
																		if (checked17)
																		{
																			num2 = 13;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					this.settings.Update("ip_iTypeChangeIp", num2);
					bool checked18 = this.rbDcomThuong.Checked;
					if (checked18)
					{
						this.settings.Update("typeDcom", 0);
					}
					else
					{
						this.settings.Update("typeDcom", 1);
					}
					this.settings.Update("txtUrlHilink", this.txtUrlHilink.Text);
					this.settings.Update("ip_txtProfileNameDcom", this.txtProfileNameDcom.Text);
					this.settings.Update("ip_txtNordVPN", this.txtNordVPN.Text);
					this.settings.Update("ip_cbbHostpot", this.cbbHostpot.SelectedIndex);
					bool checked19 = this.rbApiUser.Checked;
					if (checked19)
					{
						this.settings.Update("typeApiTinsoft", 0);
					}
					else
					{
						this.settings.Update("typeApiTinsoft", 1);
					}
					this.settings.Update("txtApiUser", this.txtApiUser.Text);
					this.settings.Update("txtApiProxy", this.txtApiProxy.Text);
					this.settings.Update("cbbLocationTinsoft", this.cbbLocationTinsoft.SelectedValue);
					this.settings.Update("nudLuongPerIPTinsoft", this.nudLuongPerIPTinsoft.Value);
					this.settings.Update("ckbWaitDoneAllTinsoft", this.ckbWaitDoneAllTinsoft.Checked);
					this.settings.Update("txtServiceURLXProxy", this.txtServiceURLXProxy.Text);
					int num3 = 0;
					bool checked20 = this.rbSock5Proxy.Checked;
					if (checked20)
					{
						num3 = 1;
					}
					this.settings.Update("typeProxy", num3);
					this.settings.Update("txtListProxy", this.txtListProxy.Text);
					this.settings.Update("nudLuongPerIPXProxy", this.nudLuongPerIPXProxy.Value);
					this.settings.Update("nudDelayResetXProxy", this.nudDelayResetXProxy.Value);
					this.settings.Update("ckbWaitDoneAllXproxy", this.ckbWaitDoneAllXproxy.Checked);
					this.settings.Update("txtApiKeyTMProxy", this.txtApiKeyTMProxy.Text);
					this.settings.Update("nudLuongPerIPTMProxy", this.nudLuongPerIPTMProxy.Value);
					this.settings.Update("ckbWaitDoneAllTMProxy", this.ckbWaitDoneAllTMProxy.Checked);
					this.settings.Update("txtApiProxyv6", this.txtApiProxyv6.Text);
					this.settings.Update("txtListProxyv6", this.txtListProxyv6.Text);
					this.settings.Update("nudLuongPerIPProxyv6", this.nudLuongPerIPProxyv6.Value);
					this.settings.Update("txtApiShopLike", this.txtApiShopLike.Text);
					this.settings.Update("nudLuongPerIPShopLike", this.nudLuongPerIPShopLike.Value);
					this.settings.Update("txtApiKeyMinProxy", this.txtApiKeyMinProxy.Text);
					this.settings.Update("nudLuongPerIPMinProxy", this.nudLuongPerIPMinProxy.Value);
					bool checked21 = this.rbPhanBietMauNen.Checked;
					if (checked21)
					{
						this.settings.Update("typePhanBietMau", 0);
					}
					else
					{
						this.settings.Update("typePhanBietMau", 1);
					}
					this.settings.Save("");
					bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
					if (flag4)
					{
						base.Close();
					}
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Lỗi!"), 1);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00201A9C File Offset: 0x001FFC9C
		private void button5_Click(object sender, EventArgs e)
		{
			bool flag = this.settings.GetValueInt("ip_iTypeChangeIp", 0) == 0;
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn loại đổi IP"), 3);
			}
			else
			{
				bool flag2 = MCommon.Common.ChangeIP(this.settings.GetValueInt("ip_iTypeChangeIp", 0), this.settings.GetValueInt("typeDcom", 0), this.settings.GetValue("ip_txtProfileNameDcom", ""), this.settings.GetValue("txtUrlHilink", ""), this.settings.GetValueInt("ip_cbbHostpot", 0), this.settings.GetValue("ip_txtNordVPN", ""));
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Đổi IP thành công!"), 1);
				}
				else
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Đổi IP thất bại!"), 2);
				}
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00201C94 File Offset: 0x001FFE94
		private void btnSSH_Click(object sender, EventArgs e)
		{
			Process.Start("changeip\\ssh.txt");
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00201CC0 File Offset: 0x001FFEC0
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = CommonChrome.GetUserAgentDefault() == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng cập nhật chromedriver!"), 3);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Phiên bản chromedriver khả dụng!"), 1);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00201D48 File Offset: 0x001FFF48
		private void rbTinsoft_CheckedChanged(object sender, EventArgs e)
		{
			this.plTinsoft.Enabled = this.rbTinsoft.Checked;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00201D78 File Offset: 0x001FFF78
		private void rbNordVPN_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.rbNordVPN.Checked;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00201DA8 File Offset: 0x001FFFA8
		private void CheckedChangedFull()
		{
			this.rbTinsoft_CheckedChanged(null, null);
			this.rbNordVPN_CheckedChanged(null, null);
			this.rbDcom_CheckedChanged(null, null);
			this.rbXproxy_CheckedChanged(null, null);
			this.rbHma_CheckedChanged(null, null);
			this.rbChrome_CheckedChanged(null, null);
			this.rbTMProxy_CheckedChanged(null, null);
			this.rbApiUser_CheckedChanged(null, null);
			this.rbApiProxy_CheckedChanged(null, null);
			this.ckbAddChromeIntoForm_CheckedChanged(null, null);
			this.ckbUsePortable_CheckedChanged(null, null);
			this.rbDcomHilink_CheckedChanged(null, null);
			this.radioButton1_CheckedChanged(null, null);
			this.rbProxyv6_CheckedChanged(null, null);
			this.rbShopLike_CheckedChanged(null, null);
			this.rbMinProxy_CheckedChanged(null, null);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00201E98 File Offset: 0x00200098
		private void button3_Click(object sender, EventArgs e)
		{
			string api_user = this.txtApiUser.Text.Trim();
			List<string> listKey = TinsoftProxy.GetListKey(api_user);
			bool flag = listKey.Count > 0;
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), listKey.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Không có proxy khả dụng!"), 2);
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00201F3C File Offset: 0x0020013C
		private void rbDcom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDcom.Enabled = this.rbDcom.Checked;
			this.CheckDoiIPEnable();
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00201F78 File Offset: 0x00200178
		private void rbXproxy_CheckedChanged(object sender, EventArgs e)
		{
			this.plXproxy.Enabled = this.rbXproxy.Checked;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00201FA8 File Offset: 0x002001A8
		private void CheckDoiIPEnable()
		{
			this.plCheckDoiIP.Enabled = (this.rbDcom.Checked || this.rbHma.Checked);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00201FF8 File Offset: 0x002001F8
		private void rbHma_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckDoiIPEnable();
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00202014 File Offset: 0x00200214
		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				};
				Process process = Process.Start(startInfo);
				string text = process.StandardOutput.ReadToEnd();
				bool flag = text.Split(new char[]
				{
					'\n'
				}).Length <= 3;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng kết nối Dcom trước!"), 2);
				}
				else
				{
					this.txtProfileNameDcom.Text = text.Split(new char[]
					{
						'\n'
					}).ToList<string>()[1];
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Lấy tên cấu hình Dcom thành công!"), 1);
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "change ip dcom");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x002021B0 File Offset: 0x002003B0
		private void ChangeVisibleBrowser()
		{
			bool @checked = this.rbChrome.Checked;
			if (@checked)
			{
				this.plLinkToOtherBrowser.Visible = false;
			}
			else
			{
				this.plLinkToOtherBrowser.Visible = true;
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00202208 File Offset: 0x00200408
		private void rbChrome_CheckedChanged(object sender, EventArgs e)
		{
			this.ChangeVisibleBrowser();
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00202224 File Offset: 0x00200424
		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				MCommon.Common.CreateFolder("data\\extension");
				Process.Start("data\\extension");
			}
			catch
			{
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00202294 File Offset: 0x00200494
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
			else
			{
				bool flag2 = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt;
				if (flag2)
				{
					this.plSizeChrome.Visible = false;
				}
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0020235C File Offset: 0x0020055C
		private void rbTMProxy_CheckedChanged(object sender, EventArgs e)
		{
			this.plTMProxy.Enabled = this.rbTMProxy.Checked;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0020238C File Offset: 0x0020058C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("https://youtu.be/eexEDCyPbR8");
			}
			catch
			{
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x002023E0 File Offset: 0x002005E0
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("https://www.youtube.com/watch?v=0t1IwKxkyKw");
			}
			catch
			{
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00202434 File Offset: 0x00200634
		private void txtApiProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtApiProxy.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblCountApiProxy.Text = "(" + list.Count.ToString() + ")";
			}
			catch
			{
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x002024D8 File Offset: 0x002006D8
		private void rbApiUser_CheckedChanged(object sender, EventArgs e)
		{
			this.plApiUser.Enabled = this.rbApiUser.Checked;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00202508 File Offset: 0x00200708
		private void rbApiProxy_CheckedChanged(object sender, EventArgs e)
		{
			this.plApiProxy.Enabled = this.rbApiProxy.Checked;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00202538 File Offset: 0x00200738
		private void button7_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = this.txtApiProxy.Lines.ToList<string>();
			list2 = MCommon.Common.RemoveEmptyItems(list2);
			foreach (string text in list2)
			{
				bool flag = TinsoftProxy.CheckApiProxy(text);
				if (flag)
				{
					list.Add(text);
				}
			}
			this.txtApiProxy.Lines = list.ToArray();
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Không có proxy khả dụng!"), 2);
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00202660 File Offset: 0x00200860
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("https://www.youtube.com/watch?v=XZTveKk-utY");
			}
			catch
			{
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x002026B4 File Offset: 0x002008B4
		private void plXproxy_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbWaitDoneAllXproxy.Visible = true;
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00202714 File Offset: 0x00200914
		private void plTinsoft_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbWaitDoneAllTinsoft.Visible = true;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00202774 File Offset: 0x00200974
		private void plTMProxy_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbWaitDoneAllTMProxy.Visible = true;
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x002027D4 File Offset: 0x002009D4
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.grChrome.Height = 318;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x002027F8 File Offset: 0x002009F8
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.grChrome.Height = 233;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0020281C File Offset: 0x00200A1C
		private void AddFileAccount_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fThemSizeChrome());
			this.LoadCbbSizeChrome();
			JSON_Settings json_Settings = new JSON_Settings("configGeneral", false);
			this.cbbSizeChrome.SelectedValue = json_Settings.GetValue("sizeChrome", "default").ToString();
			bool flag = this.cbbSizeChrome.SelectedValue == null;
			if (flag)
			{
				this.cbbSizeChrome.SelectedValue = "default";
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x002028E8 File Offset: 0x00200AE8
		private void LoadCbbSizeChrome()
		{
			JSON_Settings json_Settings = new JSON_Settings("configChrome", false);
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("default", "Mặc định");
			bool flag = json_Settings.GetValue("sizeChrome", "") != "";
			if (flag)
			{
				Dictionary<string, object> dictionary2 = JSON_Settings.ConvertToDictionary(JObject.Parse(json_Settings.GetValue("sizeChrome", "")));
				foreach (KeyValuePair<string, object> keyValuePair in dictionary2)
				{
					dictionary.Add(keyValuePair.Value.ToString(), keyValuePair.Key + string.Format(" ({0})", keyValuePair.Value));
				}
			}
			this.cbbSizeChrome.DataSource = new BindingSource(dictionary, null);
			this.cbbSizeChrome.ValueMember = "Key";
			this.cbbSizeChrome.DisplayMember = "Value";
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00202ACC File Offset: 0x00200CCC
		private void button8_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = this.txtApiKeyTMProxy.Lines.ToList<string>();
			list2 = MCommon.Common.RemoveEmptyItems(list2);
			foreach (string text in list2)
			{
				bool flag = TMProxy.CheckApiProxy(text);
				if (flag)
				{
					list.Add(text);
				}
			}
			this.txtApiKeyTMProxy.Lines = list.ToArray();
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Không có proxy khả dụng!"), 2);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00202BF4 File Offset: 0x00200DF4
		private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtApiKeyTMProxy.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label24.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00202C88 File Offset: 0x00200E88
		private void txtListProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtListProxy.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label17.Text = string.Format(Language.GetValue("Nhập Proxy ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00202D1C File Offset: 0x00200F1C
		private void txbPathProfile_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				Process.Start(this.txbPathProfile.Text.Trim());
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00202D7C File Offset: 0x00200F7C
		private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
		{
			this.plAddChromeVaoFormView.Enabled = this.ckbAddChromeIntoForm.Checked;
			this.plSapXepCuaSoChrome.Enabled = !this.ckbAddChromeIntoForm.Checked;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00202DD4 File Offset: 0x00200FD4
		private void button9_Click(object sender, EventArgs e)
		{
			this.txbPathProfile.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00054604 File Offset: 0x00052804
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00202DF8 File Offset: 0x00200FF8
		private void ckbUsePortable_CheckedChanged(object sender, EventArgs e)
		{
			this.lblFileZip.Enabled = this.ckbUsePortable.Checked;
			this.txtPathToPortableZip.Enabled = this.ckbUsePortable.Checked;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00202E48 File Offset: 0x00201048
		private void panel3_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.plUsePortable.BringToFront();
			}
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00202EA0 File Offset: 0x002010A0
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.button4.Enabled = this.rbDcomThuong.Checked;
			this.txtProfileNameDcom.Enabled = this.rbDcomThuong.Checked;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00202EF0 File Offset: 0x002010F0
		private void rbDcomHilink_CheckedChanged(object sender, EventArgs e)
		{
			this.label36.Enabled = this.rbDcomHilink.Checked;
			this.txtUrlHilink.Enabled = this.rbDcomHilink.Checked;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00202F40 File Offset: 0x00201140
		private void rbNone_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbNone.Checked;
			if (@checked)
			{
				this.ckbKhongCheckIP.Checked = true;
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00202F7C File Offset: 0x0020117C
		private void txtListProxyv6_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtListProxyv6.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.label43.Text = string.Format(Language.GetValue("Nhập Proxy ({0}):"), list.Count.ToString());
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00202FE8 File Offset: 0x002011E8
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtListProxyVitech.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.label41.Text = string.Format(Language.GetValue("Nhập Proxy ({0}):"), list.Count.ToString());
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00203054 File Offset: 0x00201254
		private void rbProxyv6_CheckedChanged(object sender, EventArgs e)
		{
			this.plProxyv6.Enabled = this.rbProxyv6.Checked;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00203084 File Offset: 0x00201284
		private void rbVitech_CheckedChanged(object sender, EventArgs e)
		{
			this.plVitech.Enabled = this.rbVitech.Checked;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x002030B4 File Offset: 0x002012B4
		private void rbShopLike_CheckedChanged(object sender, EventArgs e)
		{
			this.plShopLike.Enabled = this.rbShopLike.Checked;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x002030E4 File Offset: 0x002012E4
		private void txtApiProxyShopLike_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtApiShopLike.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.label47.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), list.Count.ToString());
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00054604 File Offset: 0x00052804
		private void txbPathProfile_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00203150 File Offset: 0x00201350
		private void rbMinProxy_CheckedChanged(object sender, EventArgs e)
		{
			this.panel5.Enabled = this.rbMinProxy.Checked;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00203180 File Offset: 0x00201380
		private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtApiKeyMinProxy.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.label49.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), list.Count.ToString());
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x002031EC File Offset: 0x002013EC
		private void metroButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.plXproxy.Height == 199;
			if (flag)
			{
				this.plXproxy.Height = 170;
				(sender as Button).BackgroundImage = Resources.icons8_expand_arrow_24px;
			}
			else
			{
				this.plXproxy.Height = 199;
				(sender as Button).BackgroundImage = Resources.icons8_collapse_arrow_24px;
			}
		}

		// Token: 0x040016F2 RID: 5874
		private JSON_Settings settings;

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
