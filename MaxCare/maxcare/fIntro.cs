using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Common;
using DeviceId;
using License.RNCryptor;
using maxcare.Helper;
using maxcare.Properties;
using MaxCare.maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
    // Token: 0x020000F9 RID: 249
    public partial class fIntro : Form
    {
        // Token: 0x06000A0C RID: 2572
        [DllImport("kernel32.dll")]
        private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

        // Token: 0x06000A0D RID: 2573 RVA: 0x00003266 File Offset: 0x00001466
        public fIntro()
        {
            this.InitializeComponent();
            this.ChangeLanguage();
        }

        // Token: 0x06000A0E RID: 2574 RVA: 0x0014C504 File Offset: 0x0014A704
        private void ChangeLanguage()
        {
            Language.GetValue(this.label1);
            Language.GetValue(this.label3);
            Language.GetValue(this.label10);
            Language.GetValue(this.label7);
        }

        // Token: 0x06000A0F RID: 2575 RVA: 0x0014C558 File Offset: 0x0014A758
        private void Intro_Load(object sender, EventArgs e)
        {
            Program.intro++;
            this.timer1.Tick += this.fadeIn;
            this.timer1.Start();
        }

        // Token: 0x06000A10 RID: 2576 RVA: 0x0014C5AC File Offset: 0x0014A7AC
        private void fadeIn(object sender, EventArgs e)
        {
            bool flag = base.Opacity >= 1.0;
            if (flag)
            {
                this.timer1.Stop();
                base.Hide();
                new fmain("").ShowDialog();
                this.timer1.Tick += this.fadeOut;
                this.timer1.Start();
            }
            else
            {
                base.Opacity += 0.05;
            }
        }

        // Token: 0x06000A11 RID: 2577 RVA: 0x0014CF60 File Offset: 0x0014B160
        private void fadeOut(object sender, EventArgs e)
        {
            bool flag = base.Opacity <= 0.0;
            if (flag)
            {
                this.timer1.Stop();
                base.Close();
            }
            else
            {
                base.Opacity -= 0.05;
            }
        }

        // Token: 0x06000A12 RID: 2578 RVA: 0x0014CFD8 File Offset: 0x0014B1D8
        private void timer2_Tick(object sender, EventArgs e)
        {
            bool flag = this.progressBar.Value < 90;
            if (flag)
            {
                this.progressBar.Value += 10;
            }
            else
            {
                this.timer2.Stop();
            }
        }
    }
}
