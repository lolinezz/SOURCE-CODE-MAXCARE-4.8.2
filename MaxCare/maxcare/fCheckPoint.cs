using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x0200006B RID: 107
	public partial class fCheckPoint : Form
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x000029FF File Offset: 0x00000BFF
		public fCheckPoint()
		{
			this.InitializeComponent();
			fCheckPoint.isOK = false;
			this.setting = new JSON_Settings("configCheckpoint", false);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00050D3C File Offset: 0x0004EF3C
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.ckbCaptcha.Checked = this.setting.GetValueBool("ckbCaptcha", false);
				int valueInt = this.setting.GetValueInt("typeCaptcha", 0);
				bool flag = valueInt == 0;
				if (flag)
				{
					this.rb2Captcha.Checked = true;
				}
				else
				{
					bool flag2 = valueInt == 1;
					if (flag2)
					{
						this.rbGuru.Checked = true;
					}
					else
					{
						this.rbAnyCaptcha.Checked = true;
					}
				}
				this.txt2Captcha.Text = this.setting.GetValue("txt2Captcha", "");
				this.txtGuru.Text = this.setting.GetValue("txtGuru", "");
				this.txtAnyCaptcha.Text = this.setting.GetValue("txtAnyCaptcha", "");
				this.ckbPhone.Checked = this.setting.GetValueBool("ckbPhone", false);
				int valueInt2 = this.setting.GetValueInt("typeSim", 0);
				bool flag3 = valueInt2 == 0;
				if (flag3)
				{
					this.rbTextNow.Checked = true;
				}
				else
				{
					bool flag4 = valueInt2 == 1;
					if (flag4)
					{
						this.rbOtpSim.Checked = true;
					}
					else
					{
						bool flag5 = valueInt2 == 2;
						if (flag5)
						{
							this.rbSimCode.Checked = true;
						}
						else
						{
							bool flag6 = valueInt2 == 3;
							if (flag6)
							{
								this.rbOtpmmo.Checked = true;
							}
							else
							{
								this.rbPrimeOtp.Checked = true;
							}
						}
					}
				}
				this.txtTextNow.Text = this.setting.GetValue("txtTextNow", "");
				this.txtOtpSim.Text = this.setting.GetValue("txtOtpSim", "");
				this.txtSimCode.Text = this.setting.GetValue("txtSimCode", "");
				this.txtOtpmmo.Text = this.setting.GetValue("txtOtpmmo", "");
				this.txtPrimeOtp.Text = this.setting.GetValue("txtPrimeOtp", "");
				this.nudTime.Value = this.setting.GetValueInt("nudTime", 120);
				this.ckbImage.Checked = this.setting.GetValueBool("ckbImage", false);
				this.txtImage.Text = this.setting.GetValue("txtImage", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000512A8 File Offset: 0x0004F4A8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				this.setting.Update("ckbCaptcha", this.ckbCaptcha.Checked);
				int num = 0;
				bool @checked = this.rb2Captcha.Checked;
				if (@checked)
				{
					num = 0;
				}
				bool checked2 = this.rbGuru.Checked;
				if (checked2)
				{
					num = 1;
				}
				else
				{
					bool checked3 = this.rbAnyCaptcha.Checked;
					if (checked3)
					{
						num = 2;
					}
				}
				this.setting.Update("typeCaptcha", num);
				this.setting.Update("txt2Captcha", this.txt2Captcha.Text);
				this.setting.Update("txtGuru", this.txtGuru.Text);
				this.setting.Update("txtAnyCaptcha", this.txtAnyCaptcha.Text);
				this.setting.Update("ckbPhone", this.ckbPhone.Checked);
				int num2 = 0;
				bool checked4 = this.rbTextNow.Checked;
				if (checked4)
				{
					num2 = 0;
				}
				bool checked5 = this.rbOtpSim.Checked;
				if (checked5)
				{
					num2 = 1;
				}
				else
				{
					bool checked6 = this.rbSimCode.Checked;
					if (checked6)
					{
						num2 = 2;
					}
					else
					{
						bool checked7 = this.rbOtpmmo.Checked;
						if (checked7)
						{
							num2 = 3;
						}
						else
						{
							bool checked8 = this.rbPrimeOtp.Checked;
							if (checked8)
							{
								num2 = 4;
							}
						}
					}
				}
				this.setting.Update("typeSim", num2);
				this.setting.Update("txtTextNow", this.txtTextNow.Text);
				this.setting.Update("txtOtpSim", this.txtOtpSim.Text);
				this.setting.Update("txtSimCode", this.txtSimCode.Text);
				this.setting.Update("txtOtpmmo", this.txtOtpmmo.Text);
				this.setting.Update("txtPrimeOtp", this.txtPrimeOtp.Text);
				this.setting.Update("nudTime", this.nudTime.Value);
				this.setting.Update("ckbImage", this.ckbImage.Checked);
				this.setting.Update("txtImage", this.txtImage.Text);
				this.setting.Save("");
				fCheckPoint.isOK = true;
				base.Close();
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0005178C File Offset: 0x0004F98C
		private void CheckedChangeFull()
		{
			this.checkBox1_CheckedChanged(null, null);
			this.ckbPhone_CheckedChanged(null, null);
			this.ckbImage_CheckedChanged(null, null);
			this.rbTextNow_CheckedChanged(null, null);
			this.rbOtpSim_CheckedChanged(null, null);
			this.rbSimCode_CheckedChanged(null, null);
			this.rb2Captcha_CheckedChanged(null, null);
			this.rbGuru_CheckedChanged(null, null);
			this.rbAnyCaptcha_CheckedChanged(null, null);
			this.rbOtpmmo_CheckedChanged(null, null);
			this.rbPrimeOtp_CheckedChanged(null, null);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00051834 File Offset: 0x0004FA34
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			bool flag = this.panel1.BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				int num = 1;
				int num2 = num / 2;
				using (Pen pen = new Pen(Color.DarkViolet, (float)num))
				{
					e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, this.panel1.ClientSize.Width - num, this.panel1.ClientSize.Height - num));
				}
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000518F8 File Offset: 0x0004FAF8
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.panel3.Enabled = this.ckbCaptcha.Checked;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00051928 File Offset: 0x0004FB28
		private void ckbPhone_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbPhone.Checked;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00051958 File Offset: 0x0004FB58
		private void ckbImage_CheckedChanged(object sender, EventArgs e)
		{
			this.txtImage.Enabled = this.ckbImage.Checked;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00051988 File Offset: 0x0004FB88
		private void rbTextNow_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbTextNow.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = true;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00051A20 File Offset: 0x0004FC20
		private void rbOtpSim_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbOtpSim.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = true;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00051AB8 File Offset: 0x0004FCB8
		private void rbSimCode_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbSimCode.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = true;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00051B50 File Offset: 0x0004FD50
		private void rb2Captcha_CheckedChanged(object sender, EventArgs e)
		{
			this.txt2Captcha.Enabled = this.rb2Captcha.Checked;
			this.txtGuru.Enabled = !this.rb2Captcha.Checked;
			this.txtAnyCaptcha.Enabled = !this.rb2Captcha.Checked;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		private void rbOtpmmo_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbOtpmmo.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = true;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00051C68 File Offset: 0x0004FE68
		private void rbAnyCaptcha_CheckedChanged(object sender, EventArgs e)
		{
			this.txt2Captcha.Enabled = !this.rbAnyCaptcha.Checked;
			this.txtGuru.Enabled = !this.rbAnyCaptcha.Checked;
			this.txtAnyCaptcha.Enabled = this.rbAnyCaptcha.Checked;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00051CE8 File Offset: 0x0004FEE8
		private void rbGuru_CheckedChanged(object sender, EventArgs e)
		{
			this.txt2Captcha.Enabled = !this.rbGuru.Checked;
			this.txtGuru.Enabled = this.rbGuru.Checked;
			this.txtAnyCaptcha.Enabled = !this.rbGuru.Checked;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00051D68 File Offset: 0x0004FF68
		private void rbPrimeOtp_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbPrimeOtp.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = true;
			}
		}

		// Token: 0x040002FF RID: 767
		private JSON_Settings setting;

		// Token: 0x04000300 RID: 768
		public static bool isOK;
	}
}
