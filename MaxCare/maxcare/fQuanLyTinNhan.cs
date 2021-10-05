using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// maxcare.fQuanLyTinNhan
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Net;
	using System.Runtime.InteropServices;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Windows.Forms;
	using Bunifu.Framework.UI;
	using maxcare;
	using maxcare.Helper;
	using maxcare.Properties;
	using MCommon;

	public class fquanLyTinNhan : Form
	{
		private Random rd = new Random();

		private JSON_Settings settings = new JSON_Settings("configGeneral");

		private List<string> lstData = new List<string>();

		private List<Thread> lstThread = null;

		private IContainer components = null;

		private BunifuDragControl bunifuDragControl1;

		private BunifuDragControl bunifuDragControl2;

		private ToolTip toolTip1;

		private Panel pnlHeader;

		private PictureBox pictureBox1;

		private Button button2;

		private Button button1;

		private Button btnMinimize;

		private BunifuCustomLabel bunifuCustomLabel1;

		private BunifuCards bunifuCards1;

		private Panel panel1;

		private TabControl tabMain;

		public DataGridView dgvTaiKhoan;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem hiểnThịToolStripMenuItem;

		private ToolStripMenuItem đóngToolStripMenuItem;

		private Panel panel2;

		private ToolStripMenuItem sửaGhiChúToolStripMenuItem;

		private DataGridViewTextBoxColumn cStt;

		private DataGridViewImageColumn cAvatar;

		private DataGridViewTextBoxColumn cTaiKhoan;

		private DataGridViewTextBoxColumn cUid;

		private DataGridViewTextBoxColumn cPassword;

		private DataGridViewTextBoxColumn cFa2;

		private DataGridViewTextBoxColumn cCookies;

		private DataGridViewTextBoxColumn cProxy;

		private DataGridViewTextBoxColumn cGhiChu;

		private DataGridViewTextBoxColumn cId;

		[DllImport("user32.dll", SetLastError = true)]
		public static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

		public fquanLyTinNhan(List<string> lstData)
		{
			InitializeComponent();
			MCommon.Common.CreateFolder("avatar");
			this.lstData = lstData;
			base.Width = Screen.PrimaryScreen.WorkingArea.Width;
			base.Height = Screen.PrimaryScreen.WorkingArea.Height;
		}

		public int CountChooseRowInDatagridview()
		{
			//Discarded unreachable code: IL_0024, IL_0031
			int result = 0;
			try
			{
				result = dgvTaiKhoan.SelectedRows.Count;
			}
			catch
			{
			}
			return result;
		}

		public void BtnMinimize_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (base.Width == Screen.PrimaryScreen.WorkingArea.Width && base.Height == Screen.PrimaryScreen.WorkingArea.Height)
			{
				base.Width = Base.width;
				base.Height = Base.heigh;
				base.Top = Base.top;
				base.Left = Base.left;
			}
			else
			{
				Base.top = base.Top;
				Base.left = base.Left;
				base.Top = 0;
				base.Left = 0;
				base.Width = Screen.PrimaryScreen.WorkingArea.Width;
				base.Height = Screen.PrimaryScreen.WorkingArea.Height;
			}
		}

		public void SetCellAccount(int indexRow, string column, object value, bool isAllowEmptyValue = true)
		{
			if (isAllowEmptyValue || !(value.ToString().Trim() == ""))
			{
				DatagridviewHelper.SetStatusDataGridView(dgvTaiKhoan, indexRow, column, value);
			}
		}

		public string GetCellAccount(int indexRow, string column)
		{
			return DatagridviewHelper.GetStatusDataGridView(dgvTaiKhoan, indexRow, column);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void AddDataIntoDgv()
		{
			for (int i = 0; i < lstData.Count; i++)
			{
				string[] array = lstData[i].Split('|');
				dgvTaiKhoan.Rows.Add(dgvTaiKhoan.RowCount + 1, Image.FromFile("images\\no_avatar.png"), array[0] + "\r\n" + array[5], array[0], array[1], array[2], array[3], array[4], array[6], array[7]);
			}
		}

		private void fQuanLyTinNhan_Load(object sender, EventArgs e)
		{
			AddDataIntoDgv();
		}

		private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void AddChromeIntoControl(Chrome chrome, Control control)
		{
			Invoke((MethodInvoker)delegate
			{
				SetParent(chrome.process.MainWindowHandle, control.Handle);
				MoveWindow(chrome.process.MainWindowHandle, -10, 0, control.Size.Width + 20, control.Size.Height + 20, repaint: false);
			});
		}

		public int ShowChrome(int indexRow, string uid, string pass, string pass2fa, TabPage tabPage1, string cookie = "", string proxy = "")
		{
			//Discarded unreachable code: IL_0751, IL_075f
			int result = 0;
			int num = 0;
			try
			{
				string text = uid;
				string text2 = text;
				if (uid == "")
				{
					uid = Regex.Match(cookie + ";", "c_user=(.*?);").Groups[1].Value;
				}
				Chrome chrome = null;
				bool flag = false;
				string text3 = "";
				if (uid != "")
				{
					text3 = settings.GetValue("txbPathProfile") + "\\" + uid;
					if (!Directory.Exists(text3))
					{
						text3 = "";
					}
				}
				chrome = new Chrome
				{
					DisableImage = false,
					Size = new Point(300, 500),
					Position = new Point(0, -1000),
					TimeWaitForSearchingElement = 3,
					TimeWaitForLoadingPage = 60,
					ProfilePath = text3,
					UserAgent = Base.useragentDefault
				};
				if (proxy != "")
				{
					int typeProxy = 0;
					if (proxy.EndsWith("*1"))
					{
						typeProxy = 1;
					}
					if (proxy.EndsWith("*0") || proxy.EndsWith("*1"))
					{
						proxy = proxy.Substring(0, proxy.Length - 2);
					}
					chrome.Proxy = proxy;
					chrome.TypeProxy = typeProxy;
				}
				while (chrome.Open())
				{
					chrome.ExecuteScript("document.title=\"proxyauth=" + proxy + "\"");
					chrome.DelayTime(2.0);
					if (!settings.GetValueBool("ckbKhongCheckIP") && proxy.Split(':').Length > 1)
					{
						chrome.GotoURL("https://api.myip.com/");
						chrome.DelayTime(1.0);
						string pageSource = chrome.GetPageSource();
						if (!pageSource.Contains("ip"))
						{
							chrome.Close();
							num++;
							if (num < 3)
							{
								continue;
							}
							break;
						}
					}
					chrome.GetProcess();
					AddChromeIntoControl(chrome, tabPage1);
					flag = CommonChrome.CheckLiveCookie(chrome, "https://m.facebook.com/") == 1;
					if (!flag)
					{
						if (text != "" && pass != "")
						{
							flag = CommonChrome.LoginFacebookUsingUidPassNew(chrome, text, pass, pass2fa, "https://m.facebook.com/", 2) == "1";
						}
						else if (cookie != "")
						{
							flag = CommonChrome.LoginFacebookUsingCookie(chrome, cookie, "https://m.facebook.com/") == "1";
						}
					}
					if (!flag)
					{
						SetRowColor(indexRow, 1);
						string idTap = dgvTaiKhoan.Rows[indexRow].Cells[3].Value.ToString();
						tabMain.Invoke((MethodInvoker)delegate
						{
							tabMain.TabPages.Remove(tabMain.TabPages[idTap]);
						});
						break;
					}
					SetRowColor(indexRow, 2);
					chrome.GotoURL("https://www.facebook.com/messages/t/");
					CommonRequest.DownLoadImageByUid(uid, "avatar");
					if (File.Exists("avatar\\" + uid + ".png"))
					{
						dgvTaiKhoan.Rows[indexRow].Cells[1].Value = Image.FromFile("avatar\\" + uid + ".png");
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		private void SetRowColor(int indexRow, int typeColor)
		{
			switch (typeColor)
			{
				case 1:
					dgvTaiKhoan.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					break;
				case 2:
					dgvTaiKhoan.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					break;
				case 3:
					dgvTaiKhoan.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
					break;
			}
		}

		private void DownloadImage(string url, string filePath)
		{
			//Discarded unreachable code: IL_0059, IL_0092, IL_009d, IL_00b0, IL_00b7, IL_00ca, IL_00d1, IL_00e4, IL_00eb, IL_00f8
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] buffer = webClient.DownloadData(url);
					using (MemoryStream stream = new MemoryStream(buffer))
					{
						using (Image image = Image.FromStream(stream))
						{
							try
							{
								image.Save(filePath + ".png", ImageFormat.Png);
							}
							catch
							{
								image.Save(filePath + ".jpg", ImageFormat.Jpeg);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0079, IL_0093, IL_00c2, IL_00ee
			try
			{
				lstThread = new List<Thread>();
				List<int> lstRow = new List<int>();
				foreach (DataGridViewRow selectedRow in dgvTaiKhoan.SelectedRows)
				{
					lstRow.Add(selectedRow.Index);
				}
				int maxThread = lstRow.Count;
				new Thread((ThreadStart)delegate
				{
					try
					{
						int num = 0;
						while (num < lstRow.Count && lstThread.Count < maxThread)
						{
							int row = lstRow[num++];
							if (row != 0)
							{
								Thread.Sleep(rd.Next(settings.GetValueInt("nudDelayOpenChromeFrom"), settings.GetValueInt("nudDelayOpenChromeTo") + 1));
							}
							Thread thread = new Thread((ThreadStart)delegate
							{
								try
								{
									MoTrinhDuyetOneThread(row);
								}
								catch (Exception ex3)
								{
									MCommon.Common.ExportError(null, ex3);
								}
							})
							{
								Name = row.ToString()
							};
							lstThread.Add(thread);
							MCommon.Common.DelayTime(1.0);
							thread.Start();
						}
						for (int i = 0; i < lstThread.Count; i++)
						{
							lstThread[i].Join();
						}
					}
					catch (Exception ex2)
					{
						MCommon.Common.ExportError(null, ex2);
					}
				}).Start();
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex);
			}
		}

		private void MoTrinhDuyetOneThread(int index)
		{
			int num = 0;
			string cookie = dgvTaiKhoan.Rows[index].Cells[6].Value.ToString();
			string text = dgvTaiKhoan.Rows[index].Cells[3].Value.ToString();
			string pass = dgvTaiKhoan.Rows[index].Cells[4].Value.ToString();
			string pass2fa = dgvTaiKhoan.Rows[index].Cells[5].Value.ToString();
			string proxy = dgvTaiKhoan.Rows[index].Cells[7].Value.ToString();
			TabPage tabPage1 = new TabPage();
			tabPage1.Name = text;
			tabPage1.Text = text;
			tabPage1.BackColor = Color.White;
			tabPage1.ForeColor = Color.White;
			for (int i = 0; i < tabMain.TabPages.Count; i++)
			{
				if (tabMain.TabPages[i].Name.ToString() == tabPage1.Name)
				{
					num++;
					break;
				}
			}
			if (num == 0)
			{
				tabMain.Invoke((MethodInvoker)delegate
				{
					tabMain.ItemSize = new Size(0, 1);
					tabMain.TabPages.Add(tabPage1);
				});
				ShowChrome(index, text, pass, pass2fa, tabPage1, cookie, proxy);
			}
		}

		private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0138, IL_0145
			try
			{
				string idTap = "";
				for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
				{
					idTap = dgvTaiKhoan.SelectedRows[i].Cells[3].Value.ToString();
					if (tabMain.TabPages.Contains(tabMain.TabPages[idTap]))
					{
						tabMain.Invoke((MethodInvoker)delegate
						{
							tabMain.TabPages.Remove(tabMain.TabPages[idTap]);
						});
						SetRowColor(dgvTaiKhoan.SelectedRows[i].Index, 3);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string text = dgvTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
			for (int i = 0; i < tabMain.TabPages.Count; i++)
			{
				if (tabMain.TabPages[i].Name.ToString() == text)
				{
					tabMain.SelectedTab = tabMain.TabPages[text];
					break;
				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void sửaGhiChúToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFormUpdate("Notes");
		}

		private void OpenFormUpdate(string type)
		{
			//Discarded unreachable code: IL_00da, IL_00e7
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
				{
					list.Add(GetCellAccount(dgvTaiKhoan.SelectedRows[i].Index, "cId"));
				}
				if (list.Count == 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n câ\u0323p nhâ\u0323t!"), 3);
				}
				else
				{
					MCommon.Common.ShowForm(new fupdateData2(this, type));
				}
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaGhiChúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.button2);
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 29);
            this.pnlHeader.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::MaxCare.Properties.Resources.min;
            this.button2.Location = new System.Drawing.Point(984, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 0;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MaxCare.Properties.Resources.max;
            this.button1.Location = new System.Drawing.Point(1016, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(178, 16);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Quản lý tin nhắn hàng loạt";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 30000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 40;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, -1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1081, 38);
            this.bunifuCards1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvTaiKhoan);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 565);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabMain);
            this.panel2.Location = new System.Drawing.Point(7, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 519);
            this.panel2.TabIndex = 8;
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(693, 518);
            this.tabMain.TabIndex = 7;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cAvatar,
            this.cTaiKhoan,
            this.cUid,
            this.cPassword,
            this.cFa2,
            this.cCookies,
            this.cProxy,
            this.cGhiChu,
            this.cId});
            this.dgvTaiKhoan.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(706, 39);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTaiKhoan.RowTemplate.Height = 50;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(369, 519);
            this.dgvTaiKhoan.TabIndex = 6;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // cStt
            // 
            this.cStt.HeaderText = "STT";
            this.cStt.Name = "cStt";
            this.cStt.ReadOnly = true;
            this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cStt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cStt.Width = 40;
            // 
            // cAvatar
            // 
            this.cAvatar.FillWeight = 50F;
            this.cAvatar.HeaderText = "Avatar";
            this.cAvatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.cAvatar.Name = "cAvatar";
            this.cAvatar.ReadOnly = true;
            this.cAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cAvatar.Width = 70;
            // 
            // cTaiKhoan
            // 
            this.cTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTaiKhoan.HeaderText = "Tài khoản";
            this.cTaiKhoan.Name = "cTaiKhoan";
            this.cTaiKhoan.ReadOnly = true;
            this.cTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cUid
            // 
            this.cUid.HeaderText = "Uid";
            this.cUid.Name = "cUid";
            this.cUid.ReadOnly = true;
            this.cUid.Visible = false;
            // 
            // cPassword
            // 
            this.cPassword.HeaderText = "Password";
            this.cPassword.Name = "cPassword";
            this.cPassword.ReadOnly = true;
            this.cPassword.Visible = false;
            // 
            // cFa2
            // 
            this.cFa2.HeaderText = "2fa";
            this.cFa2.Name = "cFa2";
            this.cFa2.ReadOnly = true;
            this.cFa2.Visible = false;
            // 
            // cCookies
            // 
            this.cCookies.HeaderText = "Cookie";
            this.cCookies.Name = "cCookies";
            this.cCookies.ReadOnly = true;
            this.cCookies.Visible = false;
            // 
            // cProxy
            // 
            this.cProxy.HeaderText = "Proxy";
            this.cProxy.Name = "cProxy";
            this.cProxy.ReadOnly = true;
            this.cProxy.Visible = false;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.ReadOnly = true;
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịToolStripMenuItem,
            this.đóngToolStripMenuItem,
            this.sửaGhiChúToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 70);
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hiểnThịToolStripMenuItem.Text = "Mở trình duyệt";
            this.hiểnThịToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịToolStripMenuItem_Click);
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.đóngToolStripMenuItem.Text = "Đóng trình duyệt";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.đóngToolStripMenuItem_Click);
            // 
            // sửaGhiChúToolStripMenuItem
            // 
            this.sửaGhiChúToolStripMenuItem.Name = "sửaGhiChúToolStripMenuItem";
            this.sửaGhiChúToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sửaGhiChúToolStripMenuItem.Text = "Sửa ghi chú";
            this.sửaGhiChúToolStripMenuItem.Click += new System.EventHandler(this.sửaGhiChúToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::MaxCare.Properties.Resources.logo_minsoftware_new;
            this.pictureBox1.Location = new System.Drawing.Point(6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::MaxCare.Properties.Resources.close_window_25px;
            this.btnMinimize.Location = new System.Drawing.Point(1048, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // fquanLyTinNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fquanLyTinNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý tin nhắn";
            this.Load += new System.EventHandler(this.fQuanLyTinNhan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
	}

}