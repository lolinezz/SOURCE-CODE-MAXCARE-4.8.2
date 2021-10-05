using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Common;
using maxcare.Enum;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;
using WindowsFormsControlLibrary1;

namespace maxcare
{
	// maxcare.fBin
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Diagnostics;
	using System.Drawing;
	using System.IO;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Windows.Forms;
	using Bunifu.Framework.UI;
	using Common;
	using maxcare;
	using maxcare.Enum;
	using maxcare.Helper;
	using maxcare.Properties;
	using MCommon;
	using MetroFramework;
	using MetroFramework.Controls;
	using Newtonsoft.Json.Linq;
	using WindowsFormsControlLibrary1;

	public class fbin : Form
	{
		private Random rd = new Random();

		private bool isStop;

		private JSON_Settings setting_general;

		private JSON_Settings setting_ShowDtgv;

		private object lock_StartProxy = new object();

		private object lock_FinishProxy = new object();

		private int checkDelayChrome = 0;

		private object lock_checkDelayChrome = new object();

		private List<string> LstKey = new List<string>();

		private List<string> LstLink = new List<string>();

		private List<string> lstua = new List<string>();

		private object _lockbackup = new object();

		private List<int> listPossitionApp = new List<int>();

		private bool isLookStatus = false;

		private object lockStatus = new object();

		private int indexCbbThuMucOld = -1;

		private bool isExcute_CbbThuMuc_SelectedIndexChanged = true;

		private object objLock = new object();

		private object _lock = new object();

		private object _lock2 = new object();

		private object _lock3 = new object();

		private object _lock4 = new object();

		private int indexCbbTinhTrangOld = -1;

		private bool isExcute_CbbTinhTrang_SelectedIndexChanged = true;

		private JSON_Settings setting_MoTrinhDuyet;

		private List<TinsoftProxy> listTinsoft = null;

		private List<XproxyProxy> listxProxy = null;

		private List<TMProxy> listTMProxy = null;

		private List<string> listApiTinsoft = null;

		private List<string> listProxyXproxy = null;

		private List<string> listProxyTMProxy = null;

		private List<Thread> lstThread = null;

		private IContainer components = null;

		public DataGridView dtgvAcc;

		private BunifuDragControl bunifuDragControl1;

		private BunifuCards bunifuCards1;

		private Panel pnlHeader;

		private PictureBox pictureBox1;

		private Button button2;

		private Button button1;

		private Button btnMinimize;

		private BunifuCustomLabel bunifuCustomLabel1;

		private MenuStrip menuStrip1;

		private GroupBox grQuanLyThuMuc;

		private Label label1;

		private MetroComboBox cbbThuMuc;

		private MetroContextMenu ctmsAcc;

		private ToolStripMenuItem chọnLiveToolStripMenuItem;

		private ToolStripMenuItem liveToolStripMenuItem;

		private ToolStripMenuItem copyToolStripMenuItem;

		private ToolStripMenuItem tokenToolStripMenuItem;

		private ToolStripMenuItem cookieToolStripMenuItem;

		private ToolStripMenuItem uidPassToolStripMenuItem;

		private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		private ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;

		private ToolStripMenuItem checkCookieToolStripMenuItem;

		private ToolStripMenuItem backupToolStripMenuItem;

		private ToolStripMenuItem tấtCảToolStripMenuItem;

		private ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		private ToolStripMenuItem passToolStripMenuItem;

		private ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		private ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		private ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;

		private ToolStripMenuItem kiểmTraTàiKhoảnToolStripMenuItem;

		private ToolStripMenuItem mailPassMailToolStripMenuItem;

		private ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

		private ToolStripMenuItem profileToolStripMenuItem;

		private ToolStripMenuItem trạngTháiToolStripMenuItem;

		private ToolStripMenuItem kiểmTraWallToolStripMenuItem;

		private GroupBox grTimKiem;

		private BunifuCustomTextbox txbSearch;

		private ToolStripMenuItem mailToolStripMenuItem;

		private ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

		private ToolStripMenuItem xóaProfileToolStripMenuItem;

		private ToolStripMenuItem fAToolStripMenuItem;

		private ToolStripMenuItem tinhTrangToolStripMenuItem;

		private ToolStripMenuItem uidPass2FaToolStripMenuItem;

		private BunifuDragControl bunifuDragControl2;

		private ToolTip toolTip1;

		private ToolStripMenuItem đinhDangKhacToolStripMenuItem;

		private ToolStripMenuItem backupToolStripMenuItem1;

		private ToolStripMenuItem htmlToolStripMenuItem;

		private ToolStripMenuItem thưMụcToolStripMenuItem;

		private ToolStripMenuItem maBaoMât6SôToolStripMenuItem;

		private ToolStripMenuItem donDepProfileToolStripMenuItem;

		private ToolStripMenuItem thoátToolStripMenuItem;

		private ToolStripMenuItem useragentToolStripMenuItem1;

		private ToolStripMenuItem proxyToolStripMenuItem1;

		private ComboBox cbbSearch;

		private ToolStripMenuItem mởThưMụcBackupToolStripMenuItem;

		private MetroButton btnLoadAcc;

		private MetroComboBox cbbTinhTrang;

		private Label label2;

		private ToolStripMenuItem kiểmTraMailpassMailToolStripMenuItem;

		private MetroButton BtnSearch;

		private ToolStripMenuItem uidToolStripMenuItem;

		private ToolStripMenuItem checkAvatarToolStripMenuItem;

		private ToolStripMenuItem checkProxyToolStripMenuItem;

		private ToolStripMenuItem checkProfileToolStripMenuItem1;

		private ToolStripMenuItem xóaDữLiệuBackupToolStripMenuItem;

		private ToolStripMenuItem mởFolderBackupToolStripMenuItem;

		private ToolStripMenuItem mởFileHTMLToolStripMenuItem;

		private ToolStripMenuItem checkBackupToolStripMenuItem;

		private ToolStripMenuItem checkInfoUIDToolStripMenuItem;

		private ToolStripMenuItem checkBackupToolStripMenuItem1;

		private ToolStripMenuItem khôiPhucTaiKhoanToolStripMenuItem;

		private StatusStrip statusStrip1;

		private ToolStripStatusLabel toolStripStatusLabel5;

		private ToolStripStatusLabel lblCountSelect;

		private ToolStripStatusLabel toolStripStatusLabel7;

		private ToolStripStatusLabel lblCountTotal;

		private DataGridViewCheckBoxColumn cChose;

		private DataGridViewTextBoxColumn cStt;

		private DataGridViewTextBoxColumn cId;

		private DataGridViewTextBoxColumn cUid;

		private DataGridViewTextBoxColumn cToken;

		private DataGridViewTextBoxColumn cCookies;

		private DataGridViewTextBoxColumn cEmail;

		private DataGridViewTextBoxColumn cPhone;

		private DataGridViewTextBoxColumn cName;

		private DataGridViewTextBoxColumn cFollow;

		private DataGridViewTextBoxColumn cFriend;

		private DataGridViewTextBoxColumn cGroup;

		private DataGridViewTextBoxColumn cBirthday;

		private DataGridViewTextBoxColumn cGender;

		private DataGridViewTextBoxColumn cPassword;

		private DataGridViewTextBoxColumn cMailRecovery;

		private DataGridViewTextBoxColumn cPassMail;

		private DataGridViewTextBoxColumn cBackup;

		private DataGridViewTextBoxColumn cFa2;

		private DataGridViewTextBoxColumn cUseragent;

		private DataGridViewTextBoxColumn cProxy;

		private DataGridViewTextBoxColumn cDateCreateAcc;

		private DataGridViewTextBoxColumn cAvatar;

		private DataGridViewTextBoxColumn cProfile;

		private DataGridViewTextBoxColumn cThuMuc;

		private DataGridViewTextBoxColumn cInteractEnd;

		private DataGridViewTextBoxColumn cInfo;

		private DataGridViewTextBoxColumn cGhiChu;

		private DataGridViewTextBoxColumn cDateDelete;

		private DataGridViewTextBoxColumn cStatus;

		private Button button9;

		private Button button3;

		private ToolStripMenuItem mởTrìnhDuyệtToolStripMenuItem;

		private Label label3;

		private ToolStripMenuItem tiếnHànhMởToolStripMenuItem;

		private ToolStripMenuItem càiĐặtCấuHìnhMởToolStripMenuItem;

		public fbin()
		{
			InitializeComponent();
			LoadSetting();
			LoadConfigManHinh();
			LoadcbbSearch();
			menuStrip1.Cursor = Cursors.Hand;
			ChangeLanguage();
		}

		private void ChangeLanguage()
		{
			//Discarded unreachable code: IL_00fb, IL_0115
			Language.GetValue(bunifuCustomLabel1);
			Language.GetValue(thoátToolStripMenuItem);
			Language.GetValue(grTimKiem);
			Language.GetValue(grQuanLyThuMuc);
			Language.GetValue(label1);
			Language.GetValue(label2);
			Language.GetValue(button9);
			Language.GetValue(button3);
			Language.GetValue(toolStripStatusLabel5);
			Language.GetValue(toolStripStatusLabel7);
			Language.GetValue(label3);
			foreach (DataGridViewColumn column in dtgvAcc.Columns)
			{
				Language.GetValue(column);
			}
			Language.GetValue(chọnLiveToolStripMenuItem);
			Language.GetValue(tấtCảToolStripMenuItem);
			Language.GetValue(liveToolStripMenuItem);
			Language.GetValue(tinhTrangToolStripMenuItem);
			Language.GetValue(trạngTháiToolStripMenuItem);
			Language.GetValue(bỏChọnTấtCảToolStripMenuItem);
			Language.GetValue(khôiPhucTaiKhoanToolStripMenuItem);
			Language.GetValue(xóaTàiKhoảnToolStripMenuItem);
			Language.GetValue(mởTrìnhDuyệtToolStripMenuItem);
			Language.GetValue(tiếnHànhMởToolStripMenuItem);
			Language.GetValue(càiĐặtCấuHìnhMởToolStripMenuItem);
			Language.GetValue(maBaoMât6SôToolStripMenuItem);
			Language.GetValue(đinhDangKhacToolStripMenuItem);
			Language.GetValue(checkCookieToolStripMenuItem);
			Language.GetValue(profileToolStripMenuItem);
			Language.GetValue(xóaProfileToolStripMenuItem);
			Language.GetValue(donDepProfileToolStripMenuItem);
			Language.GetValue(backupToolStripMenuItem);
			Language.GetValue(mởThưMụcBackupToolStripMenuItem);
			Language.GetValue(backupToolStripMenuItem1);
			Language.GetValue(xóaDữLiệuBackupToolStripMenuItem);
			Language.GetValue(tảiLạiDanhSáchToolStripMenuItem);
		}

		private void LoadcbbSearch()
		{
			Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "cUid", "UID" },
			{ "cToken", "Token" },
			{ "cCookies", "Cookie" },
			{ "cEmail", "Email" },
			{ "cPassMail", "Pass email" },
			{
				"cName",
				Language.GetValue("Tên")
			},
			{
				"cBirthday",
				Language.GetValue("Ngày sinh")
			},
			{
				"cGender",
				Language.GetValue("Giới tính")
			},
			{
				"cPassword",
				Language.GetValue("Mật khẩu")
			},
			{
				"cGhiChu",
				Language.GetValue("Ghi chu\u0301")
			},
			{
				"cInteractEnd",
				Language.GetValue("Tương ta\u0301c cuô\u0301i")
			}
		};
			cbbSearch.DataSource = new BindingSource(dataSource, null);
			cbbSearch.ValueMember = "Key";
			cbbSearch.DisplayMember = "Value";
		}

		private void LoadConfigManHinh()
		{
			setting_ShowDtgv = new JSON_Settings("configDatagridview");
			dtgvAcc.Columns["cToken"].Visible = setting_ShowDtgv.GetValueBool("cToken");
			dtgvAcc.Columns["cCookies"].Visible = setting_ShowDtgv.GetValueBool("ckbCookie");
			dtgvAcc.Columns["cEmail"].Visible = setting_ShowDtgv.GetValueBool("ckbEmail");
			dtgvAcc.Columns["cName"].Visible = setting_ShowDtgv.GetValueBool("ckbTen");
			dtgvAcc.Columns["cFriend"].Visible = setting_ShowDtgv.GetValueBool("ckbBanBe");
			dtgvAcc.Columns["cGroup"].Visible = setting_ShowDtgv.GetValueBool("ckbNhom");
			dtgvAcc.Columns["cBirthday"].Visible = setting_ShowDtgv.GetValueBool("ckbNgaySinh");
			dtgvAcc.Columns["cGender"].Visible = setting_ShowDtgv.GetValueBool("ckbGioiTinh");
			dtgvAcc.Columns["cPassword"].Visible = setting_ShowDtgv.GetValueBool("ckbMatKhau");
			dtgvAcc.Columns["cPassMail"].Visible = setting_ShowDtgv.GetValueBool("ckbMatKhauMail");
			dtgvAcc.Columns["cBackup"].Visible = setting_ShowDtgv.GetValueBool("ckbBackup");
			dtgvAcc.Columns["cFa2"].Visible = setting_ShowDtgv.GetValueBool("ckbMa2FA");
			dtgvAcc.Columns["cUseragent"].Visible = setting_ShowDtgv.GetValueBool("ckbUseragent");
			dtgvAcc.Columns["cProxy"].Visible = setting_ShowDtgv.GetValueBool("ckbProxy");
			dtgvAcc.Columns["cDateCreateAcc"].Visible = setting_ShowDtgv.GetValueBool("ckbNgayTao");
			dtgvAcc.Columns["cAvatar"].Visible = setting_ShowDtgv.GetValueBool("ckbAvatar");
			dtgvAcc.Columns["cProfile"].Visible = setting_ShowDtgv.GetValueBool("ckbProfile");
			dtgvAcc.Columns["cInfo"].Visible = setting_ShowDtgv.GetValueBool("ckbTinhTrang");
			dtgvAcc.Columns["cThuMuc"].Visible = setting_ShowDtgv.GetValueBool("ckbThuMuc");
			dtgvAcc.Columns["cGhiChu"].Visible = setting_ShowDtgv.GetValueBool("ckbGhiChu");
			dtgvAcc.Columns["cFollow"].Visible = setting_ShowDtgv.GetValueBool("ckbFollow");
			dtgvAcc.Columns["cInteractEnd"].Visible = setting_ShowDtgv.GetValueBool("ckbInteractEnd");
		}

		protected override void OnLoad(EventArgs args)
		{
			Application.Idle += OnLoaded;
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
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

		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void BtnLoadAcc_Click(object sender, EventArgs e)
		{
			string text = "";
			if (cbbThuMuc.SelectedValue != null)
			{
				text = cbbThuMuc.SelectedValue.ToString();
			}
			LoadCbbThuMuc();
			if (text != "999999" && text != "-1")
			{
				indexCbbThuMucOld = -1;
				cbbThuMuc.SelectedValue = text;
				return;
			}
			isExcute_CbbThuMuc_SelectedIndexChanged = false;
			cbbThuMuc.SelectedValue = text;
			isExcute_CbbThuMuc_SelectedIndexChanged = true;
			LoadCbbTinhTrang(fChonThuMuc.lstChooseIdFilesFromBin);
		}

		private List<string> GetIdFile()
		{
			//Discarded unreachable code: IL_00a3, IL_00b0
			List<string> result = null;
			try
			{
				string text = cbbThuMuc.SelectedValue.ToString();
				string text2 = text;
				if (!(text2 == "-1"))
				{
					result = ((!(text2 == "999999")) ? new List<string> { cbbThuMuc.SelectedValue.ToString() } : CollectionHelper.CloneList(fChonThuMuc.lstChooseIdFilesFromBin));
				}
			}
			catch
			{
			}
			return result;
		}

		private void LoadAccountFromFile(List<string> lstIdFile = null, string info = "", bool isGetActive = false)
		{
			//Discarded unreachable code: IL_00b9, IL_00c6
			try
			{
				dtgvAcc.Rows.Clear();
				if (info == "[Tất cả tình trạng]" || info == Language.GetValue("[Tất cả tình trạng]"))
				{
					info = "";
				}
				DataTable accFromFile = CommonSQL.GetAccFromFile(lstIdFile, info, isGetActive);
				LoadDtgvAccFromDatatable(accFromFile);
			}
			catch (Exception)
			{
			}
		}

		private void LoadDtgvAccFromDatatable(DataTable tableAccount)
		{
			for (int i = 0; i < tableAccount.Rows.Count; i++)
			{
				DataRow dataRow = tableAccount.Rows[i];
				dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, dataRow["id"], dataRow["uid"], dataRow["token"], dataRow["cookie1"], dataRow["email"], dataRow["phone"], dataRow["name"], dataRow["follow"], dataRow["friends"], dataRow["groups"], dataRow["birthday"], dataRow["gender"], dataRow["pass"], "", dataRow["passmail"], dataRow["backup"], dataRow["fa2"], dataRow["useragent"], dataRow["proxy"], dataRow["dateCreateAcc"], dataRow["avatar"], dataRow["profile"], dataRow["nameFile"], dataRow["interactEnd"], dataRow["info"], dataRow["ghiChu"], dataRow["dateDelete"], "");
			}
			CountCheckedAccount(0);
			SetRowColor();
			CountTotalAccount();
		}

		private void SetRowColor(int indexRow, int typeColor)
		{
			switch (typeColor)
			{
				case 1:
					dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					break;
				case 2:
					dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					break;
			}
		}

		private void SetRowColor(int indexRow = -1)
		{
			LoadSetting();
			if (setting_general.GetValueInt("typePhanBietMau") == 0)
			{
				if (indexRow == -1)
				{
					for (int i = 0; i < dtgvAcc.RowCount; i++)
					{
						string infoAccount = GetInfoAccount(i);
						if (infoAccount == "Live")
						{
							dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
						}
						else if (infoAccount.Contains("Die") || infoAccount.Contains(Language.GetValue("Checkpoint")) || infoAccount.Contains("Changed pass"))
						{
							dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
						}
					}
				}
				else
				{
					string infoAccount2 = GetInfoAccount(indexRow);
					if (infoAccount2 == "Live")
					{
						dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (infoAccount2.Contains("Die") || infoAccount2.Contains(Language.GetValue("Checkpoint")) || infoAccount2.Contains("Changed pass"))
					{
						dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
			}
			else if (indexRow == -1)
			{
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					string infoAccount3 = GetInfoAccount(j);
					if (infoAccount3 == "Live")
					{
						dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Green;
					}
					else if (infoAccount3.Contains("Die") || infoAccount3.Contains(Language.GetValue("Checkpoint")) || infoAccount3.Contains("Changed pass"))
					{
						dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
					}
				}
			}
			else
			{
				string infoAccount4 = GetInfoAccount(indexRow);
				if (infoAccount4 == "Live")
				{
					dtgvAcc.Rows[indexRow].DefaultCellStyle.ForeColor = Color.Green;
				}
				else if (infoAccount4.Contains("Die") || infoAccount4.Contains(Language.GetValue("Checkpoint")) || infoAccount4.Contains("Changed pass"))
				{
					dtgvAcc.Rows[indexRow].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}

		public void SetStatusAccount(int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", value);
		}

		public void SetInfoAccount(string id, int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cInfo", value);
			SetRowColor(indexRow);
			CommonSQL.UpdateFieldToAccount(id, "info", value);
		}

		public void SetCellAccount(int indexRow, string column, object value)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, column, value);
		}

		public void SetCellAccount(int indexRow, int column, object value)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, column, value);
		}

		public string GetStatusAccount(int indexRow)
		{
			return DatagridviewHelper.GetStatusDataGridView(dtgvAcc, indexRow, "cStatus");
		}

		public string GetInfoAccount(int indexRow)
		{
			return DatagridviewHelper.GetStatusDataGridView(dtgvAcc, indexRow, "cInfo");
		}

		public string GetCellAccount(int indexRow, string column)
		{
			return DatagridviewHelper.GetStatusDataGridView(dtgvAcc, indexRow, column);
		}

		public string GetCellAccount(int indexRow, int column)
		{
			return DatagridviewHelper.GetStatusDataGridView(dtgvAcc, indexRow, column);
		}

		private void CountTotalAccount()
		{
			//Discarded unreachable code: IL_0036, IL_0043
			try
			{
				lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
			}
			catch
			{
			}
		}

		private void CountCheckedAccount(int count = -1)
		{
			if (count == -1)
			{
				count = 0;
				for (int i = 0; i < dtgvAcc.Rows.Count; i++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						count++;
					}
				}
			}
			lblCountSelect.Text = count.ToString();
		}

		private void LoadRowColor(int rowIndex = -1)
		{
			LoadSetting();
			if (setting_general.GetValueInt("typePhanBietMau") == 0)
			{
				if (rowIndex == -1)
				{
					for (int i = 0; i < dtgvAcc.RowCount; i++)
					{
						string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cInfo");
						if (statusDataGridView == "Live")
						{
							dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
						}
						else if (statusDataGridView.Contains("Die") || statusDataGridView.Contains(Language.GetValue("Checkpoint")) || statusDataGridView.Contains("Changed pass"))
						{
							dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
						}
					}
					return;
				}
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, rowIndex, "cInfo");
				string text = statusDataGridView2;
				if (!(text == "Live"))
				{
					if (text == "Die")
					{
						dtgvAcc.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
				else
				{
					dtgvAcc.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				}
			}
			else if (rowIndex == -1)
			{
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					string statusDataGridView3 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, j, "cInfo");
					if (statusDataGridView3.Contains("Die") || statusDataGridView3.Contains(Language.GetValue("Checkpoint")))
					{
						dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
					}
				}
			}
			else
			{
				string statusDataGridView4 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, rowIndex, "cInfo");
				string text2 = statusDataGridView4;
				if (!(text2 == "Live") && text2 == "Die")
				{
					dtgvAcc.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}

		private void LoadStatusGrid(string status, string colname, int rowIndex, int typeColor, DataGridView gv)
		{
			if (!isLookStatus)
			{
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, rowIndex, colname, status);
			}
			if (colname == "cInfo")
			{
				LoadRowColor(rowIndex);
			}
		}

		private void ChoseRowInDatagrid(string modeChose)
		{
			switch (modeChose)
			{
				case "All":
					{
						for (int k = 0; k < dtgvAcc.RowCount; k++)
						{
							SetCellAccount(k, "cChose", true);
						}
						CountCheckedAccount(dtgvAcc.RowCount);
						break;
					}
				case "UnAll":
					{
						for (int j = 0; j < dtgvAcc.RowCount; j++)
						{
							SetCellAccount(j, "cChose", false);
						}
						CountCheckedAccount(0);
						break;
					}
				case "SelectHighline":
					{
						DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
						for (int l = 0; l < selectedRows.Count; l++)
						{
							SetCellAccount(selectedRows[l].Index, "cChose", true);
						}
						CountCheckedAccount();
						break;
					}
				case "ToggleCheck":
					{
						for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
						{
							int index = dtgvAcc.SelectedRows[i].Index;
							SetCellAccount(index, "cChose", !Convert.ToBoolean(GetCellAccount(index, "cChose")));
						}
						CountCheckedAccount();
						break;
					}
			}
		}

		private void CopyRowDatagrid(string modeCopy)
		{
			//Discarded unreachable code: IL_05ab, IL_05b8, IL_0693, IL_06a0, IL_079c, IL_07a9, IL_0884, IL_0891, IL_09d5, IL_09e2, IL_0b70, IL_0b7d, IL_0c58, IL_0c65, IL_0d40, IL_0d4d, IL_0e28, IL_0e35, IL_0f10, IL_0f1d, IL_0ffd, IL_100a, IL_11e2, IL_11ef, IL_1333, IL_1340, IL_15ac, IL_15b9, IL_186f, IL_187c, IL_1957, IL_1964, IL_1a66, IL_1a73, IL_1ada, IL_1ae7
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < dtgvAcc.Rows.Count; i++)
				{
					if (Convert.ToBoolean(DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cChose")))
					{
						list.Add(DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cId"));
						break;
					}
				}
				if (list.Count == 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
					return;
				}
				string text = "";
				switch (modeCopy)
				{
					case "token":
						{
							for (int num4 = 0; num4 < dtgvAcc.RowCount; num4++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num4, "cToken") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "useragent":
						{
							for (int k = 0; k < dtgvAcc.RowCount; k++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[k].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, k, "cUseragent") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "proxy":
						{
							for (int num6 = 0; num6 < dtgvAcc.RowCount; num6++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num6].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num6, "cProxy").Split('*')[0] + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "cookie":
						{
							for (int num10 = 0; num10 < dtgvAcc.RowCount; num10++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num10].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num10, "cCookies") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "uid|pass":
						{
							for (int n = 0; n < dtgvAcc.RowCount; n++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[n].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, n, "cUid") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, n, "cPassword") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "uid|pass|2fa":
						{
							for (int num9 = 0; num9 < dtgvAcc.RowCount; num9++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num9].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num9, "cUid") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num9, "cPassword") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num9, "cFa2") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "uid":
						{
							for (int num = 0; num < dtgvAcc.RowCount; num++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num, "cUid") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "pass":
						{
							for (int num12 = 0; num12 < dtgvAcc.RowCount; num12++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num12].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num12, "cPassword") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "mail":
						{
							for (int num7 = 0; num7 < dtgvAcc.RowCount; num7++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num7].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num7, "cEmail") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "2fa":
						{
							for (int num3 = 0; num3 < dtgvAcc.RowCount; num3++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cFa2") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "ma2fa":
						{
							for (int l = 0; l < dtgvAcc.RowCount; l++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[l].Cells["cChose"].Value))
								{
									try
									{
										text = text + MCommon.Common.GetTotp(DatagridviewHelper.GetStatusDataGridView(dtgvAcc, l, "cFa2")) + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "uid|pass|token|cookie":
						{
							for (int num11 = 0; num11 < dtgvAcc.RowCount; num11++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num11].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num11, "cUid") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num11, "cPassword") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num11, "cToken") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num11, "cCookies") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "mail|passmail":
						{
							for (int num8 = 0; num8 < dtgvAcc.RowCount; num8++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num8].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num8, "cEmail") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num8, "cPassMail") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "uid|pass|token|cookie|mail|passmail":
						{
							for (int num5 = 0; num5 < dtgvAcc.RowCount; num5++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num5].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num5, "cUid") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num5, "cPassword") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num5, "cToken") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num5, "cCookies") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num5, "cEmail") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num5, "cPassMail") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "uid|pass|token|cookie|mail|passmail|fa2":
						{
							for (int num2 = 0; num2 < dtgvAcc.RowCount; num2++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cUid") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cPassword") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cToken") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cCookies") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cEmail") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cPassMail") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num2, "cFa2") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
							break;
						}
					case "name":
						{
							for (int m = 0; m < dtgvAcc.RowCount; m++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[m].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, m, "cName") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text.TrimEnd('\r', '\n'));
							break;
						}
					case "birthday":
						{
							for (int j = 0; j < dtgvAcc.RowCount; j++)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, j, "cBirthday") + "\r\n";
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text.TrimEnd('\r', '\n'));
							break;
						}
				}
			}
			catch
			{
			}
		}

		private void TấtCảToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChoseRowInDatagrid("All");
		}

		private void LiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChoseRowInDatagrid("SelectHighline");
		}

		private void BỏChọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChoseRowInDatagrid("UnAll");
		}

		private void TokenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("token");
		}

		private void CookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("cookie");
		}

		private void UidToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("uid");
		}

		private void PassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("pass");
		}

		private void UidPassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("uid|pass");
		}

		private void UidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("uid|pass|token|cookie");
		}

		private void FMain_Load(object sender, EventArgs e)
		{
		}

		private void CtmsAcc_Opening(object sender, CancelEventArgs e)
		{
			trạngTháiToolStripMenuItem.DropDownItems.Clear();
			List<string> list = new List<string>();
			string text = "";
			string text2 = "";
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				text = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cStatus");
				if (text != "")
				{
					text2 = Regex.Match(text, "\\(IP: (.*?)\\)").Value;
					if (text2 != "")
					{
						text = text.Replace(text2, "").Trim();
					}
					text2 = Regex.Match(text, "\\[(.*?)\\]").Value;
					if (text2 != "")
					{
						text = text.Replace(text2, "").Trim();
					}
					if (text != "" && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				trạngTháiToolStripMenuItem.DropDownItems.Add(list[j]);
				trạngTháiToolStripMenuItem.DropDownItems[j].Click += SelectGridByStatus;
			}
			tinhTrangToolStripMenuItem.DropDownItems.Clear();
			list = new List<string>();
			for (int k = 0; k < dtgvAcc.RowCount; k++)
			{
				if (dtgvAcc.Rows[k].Cells["cInfo"].Value != null && !DatagridviewHelper.GetStatusDataGridView(dtgvAcc, k, "cInfo").Equals("") && !list.Contains(DatagridviewHelper.GetStatusDataGridView(dtgvAcc, k, "cInfo")))
				{
					list.Add(DatagridviewHelper.GetStatusDataGridView(dtgvAcc, k, "cInfo"));
				}
			}
			for (int l = 0; l < list.Count; l++)
			{
				tinhTrangToolStripMenuItem.DropDownItems.Add(list[l]);
				tinhTrangToolStripMenuItem.DropDownItems[l].Click += SelectGridByStatus1;
			}
		}

		private void SelectGridByStatus1(object sender, EventArgs e)
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string value = toolStripMenuItem.Text;
				if (DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cInfo").Equals(value))
				{
					dtgvAcc.Rows[i].Cells["cChose"].Value = true;
				}
				else
				{
					dtgvAcc.Rows[i].Cells["cChose"].Value = false;
				}
			}
		}

		private void SelectGridByStatus(object sender, EventArgs e)
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string value = toolStripMenuItem.Text;
				if (DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cStatus").Contains(value))
				{
					dtgvAcc.Rows[i].Cells["cChose"].Value = true;
				}
				else
				{
					dtgvAcc.Rows[i].Cells["cChose"].Value = false;
				}
			}
		}

		private void DeleteAccount()
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
				}
			}
			if (list.Count == 0)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn tài khoản cần xóa!"), 3);
				return;
			}
			if (MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue("Bạn có thực sự muốn xóa {0} tài khoản đã chọn?"), CountChooseRowInDatagridview()) + "\r\n\r\n" + Language.GetValue("Chu\u0301 y\u0301: Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a thi\u0300 không thê\u0309 khôi phu\u0323c la\u0323i đươ\u0323c nư\u0303a!")) == DialogResult.Yes)
			{
				if (CommonSQL.DeleteAccountToDatabase(list, isReallyDelete: true))
				{
					for (int j = 0; j < dtgvAcc.RowCount; j++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
						{
							dtgvAcc.Rows.RemoveAt(j--);
						}
					}
					if (CommonSQL.DeleteFileToDatabaseIfEmptyAccount())
					{
						RefreshDtgvAcc();
					}
				}
				else
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Xóa thất bại, vui lòng thử lại sau!"), 2);
				}
				UpdateSTTOnDtgvAcc();
			}
			UpdateTotalCountRecord();
			UpdateSelectCountRecord();
		}

		private void RefreshDtgvAcc()
		{
			LoadRowColor();
			UpdateSTTOnDtgvAcc();
			UpdateTotalCountRecord();
			UpdateSelectCountRecord();
		}

		private bool CheckIsUidFacebook(string uid)
		{
			return MCommon.Common.IsNumber(uid) && !uid.StartsWith("0");
		}

		private void cControl(string dt)
		{
			Invoke((MethodInvoker)delegate
			{
				try
				{
					if (dt == "start")
					{
						grTimKiem.Enabled = false;
						grQuanLyThuMuc.Enabled = false;
					}
					else if (dt == "stop")
					{
						grTimKiem.Enabled = true;
						grQuanLyThuMuc.Enabled = true;
					}
				}
				catch (Exception)
				{
				}
			});
		}

		private void DtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Discarded unreachable code: IL_00ad, IL_00ba
			if (e.ColumnIndex == 0)
			{
				try
				{
					dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
					CountCheckedAccount();
				}
				catch
				{
				}
			}
		}

		private void DtgvAcc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 32)
			{
				ChoseRowInDatagrid("ToggleCheck");
			}
		}

		private void LoadStatusDatagridView(int row, string status)
		{
			if (!isLookStatus)
			{
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, row, "cStatus", status);
			}
		}

		private void TảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BtnLoadAcc_Click(null, null);
		}

		private void CbbFileAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isExcute_CbbThuMuc_SelectedIndexChanged || cbbThuMuc.SelectedValue == null || !StringHelper.CheckStringIsNumber(cbbThuMuc.SelectedValue.ToString()) || (cbbThuMuc.SelectedValue.ToString() != "999999" && indexCbbThuMucOld == cbbThuMuc.SelectedIndex))
			{
				return;
			}
			string text = cbbThuMuc.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				if (text2 == "999999")
				{
					MCommon.Common.ShowForm(new fChonThuMuc(isFromBin: true));
					if (!fChonThuMuc.isAdd || fChonThuMuc.lstChooseIdFilesFromBin == null || fChonThuMuc.lstChooseIdFilesFromBin.Count == 0)
					{
						isExcute_CbbThuMuc_SelectedIndexChanged = false;
						cbbThuMuc.SelectedIndex = ((indexCbbThuMucOld != -1) ? indexCbbThuMucOld : 0);
						isExcute_CbbThuMuc_SelectedIndexChanged = true;
					}
					else
					{
						LoadCbbTinhTrang(fChonThuMuc.lstChooseIdFilesFromBin);
					}
				}
				else
				{
					LoadCbbTinhTrang(GetIdFile());
				}
			}
			else
			{
				LoadCbbTinhTrang();
			}
			indexCbbThuMucOld = cbbThuMuc.SelectedIndex;
		}

		private void MailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("mail|passmail");
		}

		private void UidPassTokenCookieMailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("uid|pass|token|cookie|mail|passmail");
		}

		private void UpdateSelectCountRecord()
		{
			//Discarded unreachable code: IL_00ab, IL_00b8
			int num = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					num++;
				}
			}
			try
			{
				lblCountSelect.Text = num.ToString();
			}
			catch
			{
			}
		}

		private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fNhapTokenTrungGian());
			if (!fNhapTokenTrungGian.isOK)
			{
				return;
			}
			LoadSetting();
			string token = setting_general.GetValue("token");
			if (!CommonRequest.CheckLiveToken("", token, "", ""))
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng kiểm tra lại token trung gian!"));
				return;
			}
			int iThread = 0;
			int maxThread = setting_general.GetValueInt("nudHideThread", 10);
			isStop = false;
			new Thread((ThreadStart)delegate
			{
				cControl("start");
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					Application.DoEvents();
					if (isStop)
					{
						break;
					}
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, dtgvAcc);
								CheckMyAvatar(row, token);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				int tickCount = Environment.TickCount;
				while (iThread > 0 && Environment.TickCount - tickCount <= 30000)
				{
					Application.DoEvents();
					Thread.Sleep(300);
				}
				cControl("stop");
			}).Start();
		}

		private void CheckMyAvatar(int row, string token)
		{
			//Discarded unreachable code: IL_024c, IL_02aa
			try
			{
				string uid = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
				string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
				if (CommonRequest.CheckAvatarFromUid(uid, token))
				{
					LoadStatusGrid(Language.GetValue("Đa\u0303 co\u0301 avatar!"), "cStatus", row, 2, dtgvAcc);
					LoadStatusGrid("Yes", "cAvatar", row, 0, dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, "avatar", "Yes");
				}
				else
				{
					LoadStatusGrid(Language.GetValue("Không co\u0301 avatar!"), "cStatus", row, 2, dtgvAcc);
					LoadStatusGrid("No", "cAvatar", row, 0, dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, "avatar", "No");
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Lỗi!!!"), "cStatus", row, 2, dtgvAcc);
			}
		}

		private void UpdateTotalCountRecord()
		{
			//Discarded unreachable code: IL_0036, IL_0043
			try
			{
				lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
			}
			catch
			{
			}
		}

		private void OnLoaded(object sender, EventArgs e)
		{
			Application.Idle -= OnLoaded;
			LoadConfigManHinh();
			LoadCbbThuMuc();
			LoadCbbTinhTrang();
		}

		private void LoadCbbThuMuc()
		{
			isExcute_CbbThuMuc_SelectedIndexChanged = false;
			DataTable allFilesFromDatabaseForBin = CommonSQL.GetAllFilesFromDatabaseForBin(isShowAll: true);
			cbbThuMuc.DataSource = allFilesFromDatabaseForBin;
			cbbThuMuc.ValueMember = "id";
			cbbThuMuc.DisplayMember = "name";
			isExcute_CbbThuMuc_SelectedIndexChanged = true;
		}

		private void LoadCbbTinhTrang(List<string> lstIdFile = null)
		{
			//Discarded unreachable code: IL_0077, IL_0084
			try
			{
				DataTable allInfoFromAccount = CommonSQL.GetAllInfoFromAccount(lstIdFile, isGetActive: false);
				cbbTinhTrang.DataSource = allInfoFromAccount;
				cbbTinhTrang.ValueMember = "id";
				cbbTinhTrang.DisplayMember = "name";
			}
			catch
			{
			}
		}

		private void KiemTraTaiKhoan(int type)
		{
			LoadSetting();
			int iThread = 0;
			int maxThread = setting_general.GetValueInt("nudHideThread", 10);
			string tokenTrungGian = setting_general.GetValue("token");
			isStop = false;
			new Thread((ThreadStart)delegate
			{
				cControl("start");
				switch (type)
				{
					case 0:
						{
							int num4 = 0;
							while (num4 < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
								{
									if (iThread < maxThread)
									{
										Interlocked.Increment(ref iThread);
										int row3 = num4++;
										new Thread((ThreadStart)delegate
										{
											LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row3, 0, dtgvAcc);
											CheckMyWall(row3, tokenTrungGian);
											Interlocked.Decrement(ref iThread);
										}).Start();
									}
									else
									{
										Application.DoEvents();
										Thread.Sleep(200);
									}
								}
								else
								{
									num4++;
								}
							}
							break;
						}
					case 1:
						{
							int num6 = 0;
							while (num6 < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num6].Cells["cChose"].Value))
								{
									if (iThread < maxThread)
									{
										Interlocked.Increment(ref iThread);
										int row = num6++;
										new Thread((ThreadStart)delegate
										{
											LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, dtgvAcc);
											CheckMyToken(row);
											Interlocked.Decrement(ref iThread);
										}).Start();
									}
									else
									{
										Application.DoEvents();
										Thread.Sleep(200);
									}
								}
								else
								{
									num6++;
								}
							}
							break;
						}
					case 2:
						{
							int num2 = 0;
							while (num2 < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
								{
									if (iThread < maxThread)
									{
										Interlocked.Increment(ref iThread);
										int row5 = num2++;
										new Thread((ThreadStart)delegate
										{
											LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row5, 0, dtgvAcc);
											CheckMyCookie(row5);
											Interlocked.Decrement(ref iThread);
										}).Start();
									}
									else
									{
										Application.DoEvents();
										Thread.Sleep(200);
									}
								}
								else
								{
									num2++;
								}
							}
							break;
						}
					case 3:
						{
							int num5 = 0;
							while (num5 < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num5].Cells["cChose"].Value))
								{
									if (iThread < maxThread)
									{
										Interlocked.Increment(ref iThread);
										int row2 = num5++;
										new Thread((ThreadStart)delegate
										{
											LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row2, 0, dtgvAcc);
											CheckDangCheckpoint(row2);
											Interlocked.Decrement(ref iThread);
										}).Start();
									}
									else
									{
										Application.DoEvents();
										Thread.Sleep(200);
									}
								}
								else
								{
									num5++;
								}
							}
							break;
						}
					case 4:
						{
							int num3 = 0;
							while (num3 < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
								{
									if (iThread < maxThread)
									{
										Interlocked.Increment(ref iThread);
										int row4 = num3++;
										new Thread((ThreadStart)delegate
										{
											LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row4, 0, dtgvAcc);
											CheckAccountMail(row4);
											Interlocked.Decrement(ref iThread);
										}).Start();
									}
									else
									{
										Application.DoEvents();
										Thread.Sleep(200);
									}
								}
								else
								{
									num3++;
								}
							}
							break;
						}
					case 5:
						{
							int num = 0;
							while (num < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
								{
									if (iThread < maxThread)
									{
										Interlocked.Increment(ref iThread);
										int row6 = num++;
										new Thread((ThreadStart)delegate
										{
											LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row6, 0, dtgvAcc);
											CheckInfoUid(row6);
											Interlocked.Decrement(ref iThread);
										}).Start();
									}
									else
									{
										Application.DoEvents();
										Thread.Sleep(200);
									}
								}
								else
								{
									num++;
								}
							}
							break;
						}
				}
				int tickCount = Environment.TickCount;
				while (iThread > 0 && Environment.TickCount - tickCount <= 60000)
				{
					MCommon.Common.DelayTime(1.0);
				}
				cControl("stop");
			}).Start();
		}

		private void CheckInfoUid(int row)
		{
			//Discarded unreachable code: IL_045c, IL_0495
			try
			{
				string cellAccount = GetCellAccount(row, "cId");
				string cellAccount2 = GetCellAccount(row, "cUid");
				if (!CheckIsUidFacebook(cellAccount2))
				{
					SetStatusAccount(row, Language.GetValue("Uid không hợp lệ!"));
					return;
				}
				string text = "";
				string text2 = CommonRequest.CheckInfoUsingUid(cellAccount2);
				if (text2.StartsWith("0|"))
				{
					if (CommonRequest.CheckLiveWall(cellAccount2).StartsWith("0|"))
					{
						SetStatusAccount(row, Language.GetValue("Tài khoản Die!"));
						SetInfoAccount(cellAccount, row, "Die");
					}
					else
					{
						SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
					}
				}
				else if (text2.StartsWith("1|"))
				{
					string[] array = text2.Split('|');
					string text3 = array[2];
					string text4 = array[3].ToLower();
					string text5 = array[4];
					string text6 = array[5];
					string text7 = array[6];
					CommonSQL.UpdateMultiFieldToAccount(cellAccount, "name|gender|friends|groups", text3 + "|" + text4 + "|" + text6 + "|" + text7);
					SetCellAccount(row, "cName", text3);
					SetCellAccount(row, "cGender", text4);
					SetCellAccount(row, "cFriend", text6);
					SetCellAccount(row, "cGroup", text7);
					if (text5 != "")
					{
						SetCellAccount(row, "cBirthday", text5);
						CommonSQL.UpdateFieldToAccount(cellAccount, "birthday", text5);
					}
					SetInfoAccount(cellAccount, row, "Live");
					text = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
					SetStatusAccount(row, text);
				}
				else
				{
					SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
				}
			}
			catch
			{
				SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
			}
		}

		private void CheckAccountMail(int row)
		{
			//Discarded unreachable code: IL_0329, IL_0387
			try
			{
				string text = "";
				string text2 = "";
				text = dtgvAcc.Rows[row].Cells["cEmail"].Value.ToString();
				text2 = dtgvAcc.Rows[row].Cells["cPassMail"].Value.ToString();
				if (text == "" || text2 == "")
				{
					LoadStatusGrid(Language.GetValue("Không tìm thấy mail") + "!!!", "cStatus", row, 2, dtgvAcc);
				}
				else if (text.Contains("@hotmail.") || text.Contains("@outlook."))
				{
					string text3 = MCommon.Common.CheckAccountHotmail(text, text2);
					if (text3.Equals("1"))
					{
						LoadStatusGrid(Language.GetValue("Tài khoản mail: live!"), "cStatus", row, 0, dtgvAcc);
					}
					else
					{
						LoadStatusGrid(Language.GetValue("Tài khoản mail: die!"), "cStatus", row, 1, dtgvAcc);
					}
				}
				else
				{
					LoadStatusGrid(Language.GetValue("Mail chưa hỗ trợ") + "!!!", "cStatus", row, 2, dtgvAcc);
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Lỗi!!!"), "cStatus", row, 2, dtgvAcc);
			}
		}

		private void CheckMyWall(int row, string tokenTg)
		{
			//Discarded unreachable code: IL_01f0, IL_0229
			try
			{
				string cellAccount = GetCellAccount(row, "cId");
				string cellAccount2 = GetCellAccount(row, "cUid");
				if (!CheckIsUidFacebook(cellAccount2))
				{
					SetStatusAccount(row, Language.GetValue("Uid không hợp lệ!"));
					return;
				}
				string text = "";
				string text2 = "";
				string text3 = CommonRequest.CheckLiveWall(cellAccount2);
				if (text3.StartsWith("0|"))
				{
					text = "Die";
					text2 = "Wall die";
				}
				else if (text3.StartsWith("1|"))
				{
					text = "Live";
					text2 = "Wall live";
				}
				else
				{
					text2 = Language.GetValue("Không check đươ\u0323c!");
				}
				SetStatusAccount(row, text2);
				if (text != "")
				{
					SetInfoAccount(cellAccount, row, text);
				}
			}
			catch
			{
				SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
			}
		}

		private void CheckMyToken(int row)
		{
			//Discarded unreachable code: IL_0347, IL_03a5
			try
			{
				string text = "";
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cId");
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cCookies");
				string statusDataGridView3 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cToken");
				string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cUseragent");
				string text3 = "";
				int typeProxy = 0;
				if (setting_general.GetValueInt("ip_iTypeChangeIp") == 9)
				{
					text3 = GetCellAccount(row, "cProxy");
					typeProxy = (text3.EndsWith("*1") ? 1 : 0);
					if (text3.EndsWith("*0") || text3.EndsWith("*1"))
					{
						text3 = text3.Substring(0, text3.Length - 2);
					}
				}
				if (text2 == "" || text3.Split(':').Length == 4)
				{
					text2 = Base.useragentDefault;
				}
				string text4 = "";
				if (!CommonRequest.CheckLiveToken(statusDataGridView2, statusDataGridView3, text2, text3, typeProxy))
				{
					text4 = "Token die";
				}
				else
				{
					text = "Live";
					text4 = "Token live";
				}
				LoadStatusGrid(text4, "cStatus", row, 2, dtgvAcc);
				if (text != "")
				{
					SetInfoAccount(statusDataGridView, row, text);
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Không check đươ\u0323c!"), "cStatus", row, 2, dtgvAcc);
			}
		}

		private void CheckMyCookie(int row)
		{
			//Discarded unreachable code: IL_0330, IL_038e
			try
			{
				string text = "";
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cId");
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cCookies");
				string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cUseragent");
				string text3 = "";
				int typeProxy = 0;
				if (setting_general.GetValueInt("ip_iTypeChangeIp") == 9)
				{
					text3 = GetCellAccount(row, "cProxy");
					typeProxy = (text3.EndsWith("*1") ? 1 : 0);
					if (text3.EndsWith("*0") || text3.EndsWith("*1"))
					{
						text3 = text3.Substring(0, text3.Length - 2);
					}
				}
				if (text2 == "" || text3.Split(':').Length == 4)
				{
					text2 = Base.useragentDefault;
				}
				string text4 = "";
				if (!CommonRequest.CheckLiveCookie(statusDataGridView2, text2, text3, typeProxy).StartsWith("1|"))
				{
					text4 = "Cookie die";
				}
				else
				{
					text = "Live";
					text4 = "Cookie live";
				}
				LoadStatusGrid(text4, "cStatus", row, 2, dtgvAcc);
				if (text != "")
				{
					SetInfoAccount(statusDataGridView, row, text);
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Không check đươ\u0323c!"), "cStatus", row, 2, dtgvAcc);
			}
		}

		private void CheckDangCheckpoint(int row)
		{
			string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
			string email = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
			string pass = dtgvAcc.Rows[row].Cells["cPassword"].Value.ToString();
			string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cUseragent");
			string text = "";
			int typeProxy = 0;
			if (setting_general.GetValueInt("ip_iTypeChangeIp") == 9)
			{
				text = GetCellAccount(row, "cProxy");
				typeProxy = (text.EndsWith("*1") ? 1 : 0);
				if (text.EndsWith("*0") || text.EndsWith("*1"))
				{
					text = text.Substring(0, text.Length - 2);
				}
			}
			if (statusDataGridView == "" || text.Split(':').Length == 4)
			{
				statusDataGridView = Base.useragentDefault;
			}
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = CommonRequest.CheckFacebookAccount(email, pass, "", text, typeProxy);
			switch (text5.Split('|')[0])
			{
				case "0":
				case "4":
					text3 = Language.GetValue("Không check đươ\u0323c!");
					break;
				case "5":
					text3 = Language.GetValue("Không check đươ\u0323c (Co\u0301 2fa)!");
					break;
				case "1":
					text4 = text5.Split('|')[1];
					text2 = "Live";
					break;
				case "2":
					text2 = ((!(text5.Split('|')[1].Trim() != "")) ? Language.GetValue("Checkpoint") : ("Checkpoint: " + text5.Split('|')[1]));
					break;
				case "3":
					text2 = "Changed pass";
					break;
			}
			if (text3 == "")
			{
				text3 = Language.GetValue("Đa\u0303 check xong!");
			}
			if (text4 != "")
			{
				CommonSQL.UpdateFieldToAccount(id, "cookie1", text4);
				LoadStatusGrid(text4, "cCookies", row, 1, dtgvAcc);
			}
			if (text2 != "")
			{
				SetInfoAccount(id, row, text2);
			}
			LoadStatusGrid(text3, "cStatus", row, 1, dtgvAcc);
		}

		private void KiểmTraWallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KiemTraTaiKhoan(0);
		}

		private void KiểmTraTokenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.Yes)
			{
				KiemTraTaiKhoan(1);
			}
		}

		private void KiểmTraCookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KiemTraTaiKhoan(2);
		}

		private void KiểmTraTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KiemTraTaiKhoan(3);
		}

		private void MailToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			CopyRowDatagrid("mail");
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0299, IL_02a6
			try
			{
				if (cbbSearch.SelectedIndex == -1)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn kiểu tìm kiếm!"));
					return;
				}
				string columnName = cbbSearch.SelectedValue.ToString();
				string text = txbSearch.Text.Trim();
				if (text == "")
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung tìm kiếm!"));
					return;
				}
				List<int> list = new List<int>();
				text = MCommon.Common.ConvertToUnSign(text.ToLower());
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					string text2 = dtgvAcc.Rows[i].Cells[columnName].Value.ToString();
					text2 = MCommon.Common.ConvertToUnSign(text2.ToLower());
					text = MCommon.Common.ConvertToUnSign(text.ToLower());
					if (text2.Contains(text))
					{
						list.Add(i);
					}
				}
				int index = 0;
				if (list.Count <= 0)
				{
					return;
				}
				int index2 = dtgvAcc.CurrentRow.Index;
				if (index2 >= list[list.Count - 1])
				{
					index = 0;
				}
				else
				{
					for (int j = 0; j < list.Count; j++)
					{
						if (index2 < list[j])
						{
							index = j;
							break;
						}
					}
				}
				int index3 = list[index];
				dtgvAcc.CurrentCell = dtgvAcc.Rows[index3].Cells[columnName];
				dtgvAcc.ClearSelection();
				dtgvAcc.Rows[index3].Selected = true;
			}
			catch
			{
			}
		}

		private void UidPassTokenCookieMailPassMail2faToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("uid|pass|token|cookie|mail|passmail|fa2");
		}

		private void UpdateSTTOnDtgvAcc()
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, i, "cSTT", i + 1);
			}
		}

		private void fAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("2fa");
		}

		private void xóaProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), CountChooseRowInDatagridview())) != DialogResult.Yes)
			{
				return;
			}
			LoadSetting();
			int iThread = 0;
			int maxThread = setting_general.GetValueInt("nudHideThread", 10);
			new Thread((ThreadStart)delegate
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								LoadStatusGrid(Language.GetValue("Đang xo\u0301a profile..."), "cStatus", row, 0, dtgvAcc);
								DeleteProfile(row);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
			}).Start();
		}

		private void DeleteProfile(int row)
		{
			//Discarded unreachable code: IL_02ac, IL_030a
			try
			{
				string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
				string text = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
				if (text.Trim() == "")
				{
					LoadStatusGrid(Language.GetValue("Chưa tạo profile!"), "cStatus", row, 0, dtgvAcc);
					return;
				}
				string path = setting_general.GetValue("txbPathProfile") + "\\" + text;
				if (Directory.Exists(path))
				{
					Directory.Delete(path, recursive: true);
					LoadStatusGrid(Language.GetValue("Xóa profile thành công!"), "cStatus", row, 0, dtgvAcc);
					LoadStatusGrid("No", "cProfile", row, 0, dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, "profile", "No");
				}
				else
				{
					LoadStatusGrid(Language.GetValue("Chưa tạo profile!"), "cStatus", row, 0, dtgvAcc);
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Xóa profile thất bại!"), "cStatus", row, 0, dtgvAcc);
			}
		}

		private void checkProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = 10;
			new Thread((ThreadStart)delegate
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								LoadStatusGrid(Language.GetValue("Đang check profile..."), "cStatus", row, 0, dtgvAcc);
								CheckProfile(row);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
			}).Start();
		}

		private void CheckProfile(int row)
		{
			//Discarded unreachable code: IL_029a, IL_02a7
			try
			{
				string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
				string text = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
				string path = setting_general.GetValue("txbPathProfile") + "\\" + text;
				if (Directory.Exists(path))
				{
					LoadStatusGrid(Language.GetValue("Đã có profile!"), "cStatus", row, 0, dtgvAcc);
					LoadStatusGrid("Yes", "cProfile", row, 0, dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, "profile", "Yes");
				}
				else
				{
					LoadStatusGrid(Language.GetValue("Chưa tạo profile!"), "cStatus", row, 0, dtgvAcc);
					LoadStatusGrid("No", "cProfile", row, 0, dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, "profile", "No");
				}
			}
			catch
			{
			}
		}

		private void donDepProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0013, IL_0031
			try
			{
				MCommon.Common.ShowForm(new fClearProfile());
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(ex.ToString(), 3);
			}
		}

		public void CloseProcess(string nameProcess)
		{
			//Discarded unreachable code: IL_003e, IL_004b
			try
			{
				Process[] processesByName = Process.GetProcessesByName(nameProcess);
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}

		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			CloseProcess("Chrome");
		}

		private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("uid|pass|2fa");
		}

		private void đinhDangKhacToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0531, IL_055d
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						list.Add(GetCellAccount(i, "cUid") + "|" + GetCellAccount(i, "cPassword") + "|" + GetCellAccount(i, "cToken") + "|" + GetCellAccount(i, "cCookies") + "|" + GetCellAccount(i, "cEmail") + "|" + GetCellAccount(i, "cPassMail") + "|" + GetCellAccount(i, "cFa2") + "|" + GetCellAccount(i, "cUseragent") + "|" + GetCellAccount(i, "cProxy").Split('*')[0] + "|" + GetCellAccount(i, "cName") + "|" + GetCellAccount(i, "cGender") + "|" + GetCellAccount(i, "cFollow") + "|" + GetCellAccount(i, "cFriend") + "|" + GetCellAccount(i, "cGroup") + "|" + GetCellAccount(i, "cBirthday") + "|" + GetCellAccount(i, "cDateCreateAcc"));
					}
				}
				if (list.Count <= 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
				}
				else
				{
					MCommon.Common.ShowForm(new fCopy(list));
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "Error Copy");
			}
		}

		private void maBaoMât6SôToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("ma2fa");
		}

		private void trạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void LoadSetting()
		{
			setting_general = new JSON_Settings("configGeneral");
		}

		private void mơFileHTMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = 10;
			new Thread((ThreadStart)delegate
			{
				try
				{
					int num = 0;
					while (num < dtgvAcc.Rows.Count)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
						{
							if (iThread < maxThread)
							{
								Interlocked.Increment(ref iThread);
								int row = num++;
								new Thread((ThreadStart)delegate
								{
									try
									{
										string statusDataGridView = CommonCSharp.GetStatusDataGridView(dtgvAcc, row, "cCookies");
										string text = CommonCSharp.GetStatusDataGridView(dtgvAcc, row, "cUid");
										if (text == "")
										{
											text = Regex.Match(statusDataGridView, "c_user=(.*?);").Groups[1].Value;
										}
										if (File.Exists("backup\\" + text + "\\" + text + ".html"))
										{
											Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
										}
										else
										{
											CommonCSharp.UpdateStatusDataGridView(dtgvAcc, row, "cStatus", Language.GetValue("Chưa tạo html!"));
										}
										Interlocked.Decrement(ref iThread);
									}
									catch (Exception ex2)
									{
										CommonCSharp.ExportError(null, ex2.ToString());
									}
								}).Start();
							}
							else
							{
								CommonCSharp.DelayTime(1.0);
							}
						}
						else
						{
							num++;
						}
					}
					while (iThread > 0)
					{
						CommonCSharp.DelayTime(1.0);
					}
				}
				catch (Exception ex)
				{
					CommonCSharp.ExportError(null, ex.ToString());
				}
			}).Start();
		}

		private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_006f, IL_0082, IL_0264, IL_0271, IL_027d, IL_028a
			string text = "";
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					return;
				}
				text = folderBrowserDialog.SelectedPath;
			}
			int num = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				try
				{
					if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						continue;
					}
					string text2 = dtgvAcc.Rows[i].Cells["cUid"].Value.ToString();
					try
					{
						if (File.Exists("backup\\" + text2 + "\\" + text2 + ".html"))
						{
							File.Copy("backup\\" + text2 + "\\" + text2 + ".html", text + "\\" + text2 + ".html");
							num++;
						}
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Copy thành công {0} tệp backup html!"), num));
		}

		private void thưMụcToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_006f, IL_0082, IL_0247, IL_0254, IL_0260, IL_026d
			string text = "";
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					return;
				}
				text = folderBrowserDialog.SelectedPath;
			}
			int num = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				try
				{
					if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						continue;
					}
					string text2 = dtgvAcc.Rows[i].Cells["cUid"].Value.ToString();
					try
					{
						if (!Directory.Exists(text + "\\" + text2))
						{
							Directory.CreateDirectory(text + "\\" + text2);
						}
						string[] files = Directory.GetFiles("backup\\" + text2);
						for (int j = 0; j < files.Length; j++)
						{
							File.Copy(files[j], text + "\\" + text2 + "\\" + Path.GetFileName(files[j]));
						}
						num++;
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Copy thành công {0} thư mục backup!"), num));
		}

		private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			List<string> list = new List<string> { "cStt", "cFriend", "cGroup", "cFollow" };
			if (list.Contains(e.Column.Name))
			{
				e.SortResult = int.Parse((e.CellValue1.ToString() == "") ? "-1" : e.CellValue1.ToString()).CompareTo(int.Parse((e.CellValue2.ToString() == "") ? "-1" : e.CellValue2.ToString()));
				e.Handled = true;
			}
			else
			{
				e.SortResult = ((e.CellValue1.ToString() == "") ? "" : e.CellValue1.ToString()).CompareTo((e.CellValue2.ToString() == "") ? "" : e.CellValue2.ToString());
				e.Handled = true;
			}
		}

		private void câuHinhHiênThiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fCauHinhHienThi());
			LoadConfigManHinh();
		}

		private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = setting_general.GetValueInt("nudHideThread", 10);
			isStop = false;
			new Thread((ThreadStart)delegate
			{
				cControl("start");
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					Application.DoEvents();
					if (isStop)
					{
						break;
					}
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, dtgvAcc);
								CheckProxy(row);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				int tickCount = Environment.TickCount;
				while (iThread > 0 && Environment.TickCount - tickCount <= 30000)
				{
					Application.DoEvents();
					Thread.Sleep(300);
				}
				cControl("stop");
			}).Start();
		}

		private void CheckProxy(int row)
		{
			//Discarded unreachable code: IL_0218, IL_0276
			try
			{
				string text = dtgvAcc.Rows[row].Cells["cProxy"].Value.ToString();
				int typeProxy = 0;
				if (text.EndsWith("*1"))
				{
					typeProxy = 1;
				}
				text = text.Substring(0, text.Length - 2);
				int num = 0;
				int num2 = 0;
				string text2 = "";
				bool flag = false;
				for (int i = 0; i < 10; i++)
				{
					text2 = MCommon.Common.CheckProxy(text, typeProxy);
					if (text2 != "")
					{
						num++;
						if (num == 3)
						{
							flag = true;
							break;
						}
					}
					else
					{
						num2++;
						if (num2 == 3)
						{
							break;
						}
					}
				}
				if (!flag)
				{
					LoadStatusGrid("Proxy Die!", "cStatus", row, 2, dtgvAcc);
				}
				else
				{
					LoadStatusGrid("Proxy Live!", "cStatus", row, 2, dtgvAcc);
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Lỗi!!!"), "cStatus", row, 2, dtgvAcc);
			}
		}

		private void useragentToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("useragent");
		}

		private void proxyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("proxy");
		}

		private void mởThưMụcBackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_00f1, IL_0125
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (isStop)
				{
					break;
				}
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text = "backup\\" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cUid");
				if (Directory.Exists(text))
				{
					try
					{
						Process.Start(text);
						LoadStatusDatagridView(i, Language.GetValue("Mở thành công!"));
					}
					catch
					{
						LoadStatusDatagridView(i, Language.GetValue("Mở thất bại!"));
					}
				}
				else
				{
					LoadStatusDatagridView(i, Language.GetValue("Chưa backup!"));
				}
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0050, IL_005d
			if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
			{
				try
				{
					Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
				}
				catch
				{
				}
			}
		}

		private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isExcute_CbbTinhTrang_SelectedIndexChanged || cbbTinhTrang.SelectedValue == null || !StringHelper.CheckStringIsNumber(cbbTinhTrang.SelectedValue.ToString()) || (cbbTinhTrang.SelectedValue.ToString() != "-1" && indexCbbTinhTrangOld == cbbTinhTrang.SelectedIndex))
			{
				return;
			}
			string text = cbbThuMuc.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				if (text2 == "999999")
				{
					LoadAccountFromFile(fChonThuMuc.lstChooseIdFilesFromBin, cbbTinhTrang.Text);
				}
				else
				{
					LoadAccountFromFile(GetIdFile(), cbbTinhTrang.Text);
				}
			}
			else
			{
				LoadAccountFromFile(null, cbbTinhTrang.Text);
			}
			indexCbbTinhTrangOld = cbbTinhTrang.SelectedIndex;
		}

		private void giưLaiProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteAccount();
		}

		private void kiểmTraMailpassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KiemTraTaiKhoan(4);
		}

		private void tênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("name");
		}

		private void ngàySinhToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CopyRowDatagrid("birthday");
		}

		public int CountChooseRowInDatagridview()
		{
			//Discarded unreachable code: IL_0090, IL_009d
			int num = 0;
			try
			{
				for (int i = 0; i < dtgvAcc.Rows.Count; i++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						num++;
					}
				}
			}
			catch
			{
			}
			return num;
		}

		private void xóaDữLiệuBackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), CountChooseRowInDatagridview())) != DialogResult.Yes)
			{
				return;
			}
			int iThread = 0;
			int maxThread = setting_general.GetValueInt("nudHideThread", 10);
			new Thread((ThreadStart)delegate
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								LoadStatusGrid(Language.GetValue("Đang xo\u0301a dữ liệu backup..."), "cStatus", row, 0, dtgvAcc);
								DeleteBackup(row);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
			}).Start();
		}

		private void DeleteBackup(int row)
		{
			//Discarded unreachable code: IL_0272, IL_02d0
			try
			{
				string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
				string text = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
				if (text.Trim() == "")
				{
					LoadStatusGrid(Language.GetValue("Chưa backup!"), "cStatus", row, 0, dtgvAcc);
					return;
				}
				string path = "backup\\" + text;
				if (Directory.Exists(path))
				{
					Directory.Delete(path, recursive: true);
					LoadStatusGrid(Language.GetValue("Xóa dữ liệu backup thành công!"), "cStatus", row, 0, dtgvAcc);
					LoadStatusGrid("", "cBackup", row, 0, dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, "backup", "");
				}
				else
				{
					LoadStatusGrid(Language.GetValue("Chưa backup!"), "cStatus", row, 0, dtgvAcc);
				}
			}
			catch
			{
				LoadStatusGrid(Language.GetValue("Xóa dữ liệu backup thất bại!"), "cStatus", row, 0, dtgvAcc);
			}
		}

		private void checkBackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = 10;
			string pathBackup = ConfigHelper.GetPathBackup();
			new Thread((ThreadStart)delegate
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								SetStatusAccount(row, Language.GetValue("Đang check backup..."));
								CheckBackup(row, pathBackup);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
			}).Start();
		}

		private void CheckBackup(int row, string backupPath)
		{
			//Discarded unreachable code: IL_0251, IL_025e
			try
			{
				string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
				string text = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
				backupPath = backupPath + "\\" + text + "\\" + text + ".txt";
				if (File.Exists(backupPath))
				{
					SetStatusAccount(row, Language.GetValue("Đã backup!"));
					SetCellAccount(row, "cBackup", MCommon.Common.GetDateCreatFile(backupPath));
					CommonSQL.UpdateFieldToAccount(id, "backup", MCommon.Common.GetDateCreatFile(backupPath));
				}
				else
				{
					SetStatusAccount(row, Language.GetValue("Chưa backup!"));
					SetCellAccount(row, "cBackup", "");
					CommonSQL.UpdateFieldToAccount(id, "backup", "");
				}
			}
			catch
			{
			}
		}

		private void checkInfoUIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KiemTraTaiKhoan(5);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			KhoiPhucTaiKhoan();
		}

		private void KhoiPhucTaiKhoan()
		{
			//Discarded unreachable code: IL_03fe, IL_042a
			if (CountChooseRowInDatagridview() == 0)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n khôi phu\u0323c!"), 3);
				return;
			}
			MCommon.Common.ShowForm(new fCauHinhKhoiPhucTaiKhoan());
			if (fCauHinhKhoiPhucTaiKhoan.isOK)
			{
				try
				{
					if (fCauHinhKhoiPhucTaiKhoan.typeThuMuc == 0)
					{
						List<string> list = new List<string>();
						List<string> list2 = new List<string>();
						for (int i = 0; i < dtgvAcc.RowCount; i++)
						{
							if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
							{
								string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cId");
								string idFileFromIdAccount = CommonSQL.GetIdFileFromIdAccount(statusDataGridView);
								list.Add(statusDataGridView);
								list2.Add(idFileFromIdAccount);
								dtgvAcc.Rows.RemoveAt(i--);
							}
						}
						UpdateSTTOnDtgvAcc();
						CommonSQL.UpdateFieldToFile(list2, "active", "1");
						if (CommonSQL.UpdateFieldToAccount(list, "active", "1"))
						{
							MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list.Count));
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
						}
					}
					else
					{
						string idFile = fCauHinhKhoiPhucTaiKhoan.idFile;
						List<string> list3 = new List<string>();
						for (int j = 0; j < dtgvAcc.RowCount; j++)
						{
							if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
							{
								string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, j, "cId");
								list3.Add(statusDataGridView2);
								dtgvAcc.Rows.RemoveAt(j--);
							}
						}
						UpdateSTTOnDtgvAcc();
						if (CommonSQL.UpdateFieldToAccount(list3, "idFile", idFile) && CommonSQL.UpdateFieldToAccount(list3, "active", "1"))
						{
							MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list3.Count));
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
						}
					}
				}
				catch (Exception ex)
				{
					MCommon.Common.ExportError(null, ex, "Khoi Phuc Tai Khoan");
				}
			}
			UpdateTotalCountRecord();
			UpdateSelectCountRecord();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			DeleteAccount();
		}

		private void khôiPhucTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KhoiPhucTaiKhoan();
		}

		public List<string> GetListKeyTinsoft()
		{
			//Discarded unreachable code: IL_018a, IL_019f, IL_0217, IL_022b, IL_0233, IL_0240
			List<string> list = new List<string>();
			try
			{
				if (setting_general.GetValueInt("typeApiTinsoft") == 0)
				{
					RequestXNet requestXNet = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
					string json = requestXNet.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + setting_general.GetValue("txtApiUser"));
					JObject jObject = JObject.Parse(json);
					foreach (JToken item in (IEnumerable<JToken>)jObject["data"])
					{
						if (Convert.ToBoolean(item["success"].ToString()))
						{
							list.Add(item["key"].ToString());
						}
					}
				}
				else
				{
					List<string> valueList = setting_general.GetValueList("txtApiProxy");
					foreach (string item2 in valueList)
					{
						if (TinsoftProxy.CheckApiProxy(item2))
						{
							list.Add(item2);
						}
					}
				}
			}
			catch
			{
			}
			return list;
		}

		private void MoTrinhDuyet()
		{
			//Discarded unreachable code: IL_07e1, IL_080d
			try
			{
				setting_MoTrinhDuyet = new JSON_Settings("configOpenBrowser");
				string profilePath = "";
				if (!setting_MoTrinhDuyet.GetValueBool("isUseProfile"))
				{
					goto IL_00db;
				}
				profilePath = ConfigHelper.GetPathProfile();
				if (Directory.Exists(profilePath))
				{
					goto IL_00db;
				}
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đường dẫn profile không hợp lệ!"), 3);
				goto end_IL_0001;
			IL_00db:
				if (!(Base.useragentDefault == ""))
				{
					goto IL_0160;
				}
				Base.useragentDefault = CommonChrome.GetUserAgentDefault();
				if (!(Base.useragentDefault == ""))
				{
					goto IL_0160;
				}
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Phiên bản Chromedriver hiện tại không khả dụng, vui lòng cập nhật!"), 3);
				goto end_IL_0001;
			IL_0160:
				LoadSetting();
				int maxThread = CountChooseRowInDatagridview();
				switch (setting_general.GetValueInt("ip_iTypeChangeIp"))
				{
					case 7:
						{
							listApiTinsoft = GetListKeyTinsoft();
							if (listApiTinsoft.Count == 0)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Proxy Tinsoft không đủ, vui lòng mua thêm!"), 2);
								return;
							}
							listTinsoft = new List<TinsoftProxy>();
							for (int j = 0; j < listApiTinsoft.Count; j++)
							{
								TinsoftProxy item2 = new TinsoftProxy(listApiTinsoft[j], setting_general.GetValueInt("nudLuongPerIPTinsoft"), setting_general.GetValueInt("cbbLocationTinsoft"));
								listTinsoft.Add(item2);
							}
							if (listApiTinsoft.Count * setting_general.GetValueInt("nudLuongPerIPTinsoft") < maxThread)
							{
								maxThread = listApiTinsoft.Count * setting_general.GetValueInt("nudLuongPerIPTinsoft");
							}
							break;
						}
					case 8:
						{
							listProxyXproxy = setting_general.GetValueList("txtListProxy");
							if (listProxyXproxy.Count == 0)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Proxy không đủ, vui lòng cấu hình lại!"), 2);
								return;
							}
							listxProxy = new List<XproxyProxy>();
							for (int k = 0; k < listProxyXproxy.Count; k++)
							{
								XproxyProxy item3 = new XproxyProxy(setting_general.GetValue("txtServiceURLXProxy"), listProxyXproxy[k], setting_general.GetValueInt("typeProxy"), setting_general.GetValueInt("nudLuongPerIPXProxy"));
								listxProxy.Add(item3);
							}
							if (listProxyXproxy.Count * setting_general.GetValueInt("nudLuongPerIPXProxy") < maxThread)
							{
								maxThread = listProxyXproxy.Count * setting_general.GetValueInt("nudLuongPerIPXProxy");
							}
							break;
						}
					case 10:
						{
							listProxyTMProxy = setting_general.GetValueList("txtApiKeyTMProxy");
							if (listProxyTMProxy.Count == 0)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("TMProxy không đủ, vui lòng mua thêm!"), 2);
								return;
							}
							listTMProxy = new List<TMProxy>();
							for (int i = 0; i < listProxyTMProxy.Count; i++)
							{
								TMProxy item = new TMProxy(listProxyTMProxy[i], 0, setting_general.GetValueInt("nudLuongPerIPTMProxy"));
								listTMProxy.Add(item);
							}
							if (listProxyTMProxy.Count * setting_general.GetValueInt("nudLuongPerIPTMProxy") < maxThread)
							{
								maxThread = listProxyTMProxy.Count * setting_general.GetValueInt("nudLuongPerIPTMProxy");
							}
							break;
						}
				}
				isStop = false;
				List<int> lstPossition = new List<int>();
				for (int l = 0; l < CountChooseRowInDatagridview(); l++)
				{
					lstPossition.Add(0);
				}
				checkDelayChrome = 0;
				lstThread = new List<Thread>();
				new Thread((ThreadStart)delegate
				{
					try
					{
						int num = 0;
						while (num < dtgvAcc.Rows.Count && !isStop)
						{
							if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
							{
								if (isStop || lstThread.Count >= maxThread)
								{
									break;
								}
								if (isStop)
								{
									break;
								}
								int row = num++;
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										int indexOfPossitionApp = MCommon.Common.GetIndexOfPossitionApp(ref lstPossition);
										MoTrinhDuyetOneThread(row, indexOfPossitionApp, profilePath);
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
							else
							{
								num++;
							}
							if (isStop)
							{
								break;
							}
						}
						for (int m = 0; m < lstThread.Count; m++)
						{
							lstThread[m].Join();
						}
					}
					catch (Exception ex2)
					{
						MCommon.Common.ExportError(null, ex2);
					}
				}).Start();
			end_IL_0001:;
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex);
			}
		}

		private void MoTrinhDuyetOneThread(int indexRow, int indexPos, string profilePath)
		{
			//Discarded unreachable code: IL_039c, IL_03b0, IL_06a5, IL_06ba, IL_07ba, IL_07ce, IL_0b71, IL_0b86, IL_0d39, IL_0d4d, IL_1042, IL_1057, IL_1651, IL_1666, IL_1db2, IL_1dc5, IL_1f4f, IL_1f62, IL_267e, IL_26dd, IL_27c8, IL_27d5, IL_29ff, IL_2a14
			string text = "";
			Chrome chrome = null;
			int num = 0;
			bool flag = false;
			string text2 = "";
			int typeProxy = 0;
			string text3 = "";
			TinsoftProxy tinsoftProxy = null;
			XproxyProxy xproxyProxy = null;
			TMProxy tMProxy = null;
			bool flag2 = false;
			string text4 = "";
			string text5 = GetCellAccount(indexRow, "cUid");
			string cellAccount = GetCellAccount(indexRow, "cId");
			string cellAccount2 = GetCellAccount(indexRow, "cEmail");
			string cellAccount3 = GetCellAccount(indexRow, "cFa2");
			string cellAccount4 = GetCellAccount(indexRow, "cPassword");
			string cellAccount5 = GetCellAccount(indexRow, "cCookies");
			string cellAccount6 = GetCellAccount(indexRow, "cToken");
			string text6 = GetCellAccount(indexRow, "cUseragent");
			if (text5 == "")
			{
				text5 = Regex.Match(cellAccount5, "c_user=(.*?);").Groups[1].Value;
			}
			if (isStop)
			{
				SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
			}
			else
			{
				while (true)
				{
					switch (setting_general.GetValueInt("ip_iTypeChangeIp"))
					{
						case 7:
							SetStatusAccount(indexRow, Language.GetValue("Đang lấy proxy Tinsoft..."));
							lock (lock_StartProxy)
							{
								while (!isStop)
								{
									tinsoftProxy = null;
									while (!isStop)
									{
										foreach (TinsoftProxy item in listTinsoft)
										{
											if (tinsoftProxy == null || item.daSuDung < tinsoftProxy.daSuDung)
											{
												tinsoftProxy = item;
											}
										}
										if (tinsoftProxy.daSuDung != tinsoftProxy.limit_theads_use)
										{
											break;
										}
									}
									if (isStop)
									{
										break;
									}
									if (tinsoftProxy.daSuDung > 0 || tinsoftProxy.ChangeProxy())
									{
										text = tinsoftProxy.proxy;
										if (text == "")
										{
											text = tinsoftProxy.GetProxy();
										}
										tinsoftProxy.dangSuDung++;
										tinsoftProxy.daSuDung++;
										break;
									}
					
								}
								if (isStop)
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
									break;
								}
								bool flag9 = true;
								if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
								{
									SetStatusAccount(indexRow, text2 + "Delay check IP...");
									MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
								}
								if (!setting_general.GetValueBool("ckbKhongCheckIP"))
								{
									text2 = "(IP: " + text.Split(':')[0] + ") ";
									SetStatusAccount(indexRow, text2 + "Check IP...");
									text3 = MCommon.Common.CheckProxy(text, 0);
									if (text3 == "")
									{
										flag9 = false;
									}
								}
								if (!flag9)
								{
									tinsoftProxy.dangSuDung--;
									tinsoftProxy.daSuDung--;
									continue;
								}
								goto default;
							}
						case 8:
							SetStatusAccount(indexRow, Language.GetValue("Đang lấy Proxy..."));
							lock (lock_StartProxy)
							{
								while (!isStop)
								{
									xproxyProxy = null;
									while (!isStop)
									{
										foreach (XproxyProxy item2 in listxProxy)
										{
											if (xproxyProxy == null || (item2.isProxyLive && item2.daSuDung < xproxyProxy.daSuDung))
											{
												xproxyProxy = item2;
											}
										}
										if (xproxyProxy.daSuDung != xproxyProxy.limit_theads_use)
										{
											break;
										}
									}
									if (isStop)
									{
										break;
									}
									if (xproxyProxy.isProxyLive && (xproxyProxy.daSuDung > 0 || xproxyProxy.ChangeProxy()))
									{
										text = xproxyProxy.proxy;
										typeProxy = xproxyProxy.typeProxy;
										xproxyProxy.dangSuDung++;
										xproxyProxy.daSuDung++;
										break;
									}
									xproxyProxy.isProxyLive = false;
									bool flag5 = true;
								}
								if (isStop)
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
									break;
								}
								bool flag6 = true;
								if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
								{
									SetStatusAccount(indexRow, text2 + "Delay check IP...");
									MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
								}
								if (!setting_general.GetValueBool("ckbKhongCheckIP"))
								{
									text2 = "(IP: " + text.Split(':')[0] + ") ";
									SetStatusAccount(indexRow, text2 + "Check IP...");
									int num2 = 0;
									while (true)
									{
										if (num2 >= 30)
										{
											goto IL_0b00;
										}
										MCommon.Common.DelayTime(1.0);
										text3 = MCommon.Common.CheckProxy(text, typeProxy);
										if (text3 != "")
										{
											goto IL_0b00;
										}
										if (isStop)
										{
											SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
											goto end_IL_029e;
										}
										num2++;
										continue;
									IL_0b00:
										if (text3 == "")
										{
											flag6 = false;
										}
										break;
									}
								}
								if (!flag6)
								{
									xproxyProxy.dangSuDung--;
									xproxyProxy.daSuDung--;
									continue;
								}
								goto default;
							}
						case 9:
							text = GetCellAccount(indexRow, "cProxy");
							typeProxy = (text.EndsWith("*1") ? 1 : 0);
							if (text.EndsWith("*0") || text.EndsWith("*1"))
							{
								text = text.Substring(0, text.Length - 2);
							}
							goto default;
						case 10:
							SetStatusAccount(indexRow, Language.GetValue("Đang lấy TMProxy..."));
							lock (lock_StartProxy)
							{
								while (!isStop)
								{
									tMProxy = null;
									while (!isStop)
									{
										foreach (TMProxy item3 in listTMProxy)
										{
											if (tMProxy == null || item3.daSuDung < tMProxy.daSuDung)
											{
												tMProxy = item3;
											}
										}
										if (tMProxy.daSuDung != tMProxy.limit_theads_use)
										{
											break;
										}
									}
									if (isStop)
									{
										break;
									}
									if (tMProxy.daSuDung > 0 || tMProxy.ChangeProxy())
									{
										text = tMProxy.proxy;
										if (text == "")
										{
											text = tMProxy.GetProxy();
										}
										tMProxy.dangSuDung++;
										tMProxy.daSuDung++;
										break;
									}
									bool flag3 = true;
								}
								if (isStop)
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
									break;
								}
								bool flag4 = true;
								if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
								{
									SetStatusAccount(indexRow, text2 + "Delay check IP...");
									MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
								}
								if (!setting_general.GetValueBool("ckbKhongCheckIP"))
								{
									text2 = "(IP: " + text.Split(':')[0] + ") ";
									SetStatusAccount(indexRow, text2 + "Check IP...");
									text3 = MCommon.Common.CheckProxy(text, 0);
									if (text3 == "")
									{
										flag4 = false;
									}
								}
								if (!flag4)
								{
									tMProxy.dangSuDung--;
									tMProxy.daSuDung--;
									continue;
								}
								goto default;
							}
						default:
							{
								if (isStop)
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
									break;
								}
								if (!setting_general.GetValueBool("ckbKhongCheckIP"))
								{
									if (setting_general.GetValueInt("ip_iTypeChangeIp") != 7 && setting_general.GetValueInt("ip_iTypeChangeIp") != 8 && setting_general.GetValueInt("ip_iTypeChangeIp") != 10)
									{
										if (text != "")
										{
											text2 = "(IP: " + text.Split(':')[0] + ") ";
										}
										SetStatusAccount(indexRow, text2 + "Check IP...");
										bool flag7 = false;
										int num3 = 0;
										while (num3 < 30)
										{
											MCommon.Common.DelayTime(1.0);
											text3 = MCommon.Common.CheckProxy(text, typeProxy);
											if (text3 != "")
											{
												flag7 = true;
												break;
											}
											if (!isStop)
											{
												num3++;
												continue;
											}
											goto IL_12b1;
										}
										if (!flag7)
										{
											if (text != "")
											{
												SetStatusAccount(indexRow, text2 + Language.GetValue("Không thể kết nối proxy!"));
											}
											else
											{
												SetStatusAccount(indexRow, text2 + Language.GetValue("Không có kết nối Internet!"));
											}
											break;
										}
									}
									text2 = "(IP: " + text3 + ") ";
								}
								if (isStop)
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
									break;
								}
								try
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Chờ đến lượt..."));
									lock (lock_checkDelayChrome)
									{
										if (checkDelayChrome > 0)
										{
											int num4 = rd.Next(setting_general.GetValueInt("nudDelayOpenChromeFrom", 1), setting_general.GetValueInt("nudDelayOpenChromeTo", 1) + 1);
											if (num4 > 0)
											{
												int tickCount = Environment.TickCount;
												while ((Environment.TickCount - tickCount) / 1000 - num4 < 0)
												{
													SetStatusAccount(indexRow, text2 + Language.GetValue("Mở tri\u0300nh duyê\u0323t sau") + " {time}s...".Replace("{time}", (num4 - (Environment.TickCount - tickCount) / 1000).ToString()));
													MCommon.Common.DelayTime(0.5);
													if (isStop)
													{
														SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
														goto end_IL_029e;
													}
												}
											}
										}
										else
										{
											checkDelayChrome++;
										}
									}
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
									if (text6 == "" || text.Split(':').Length == 4)
									{
										text6 = Base.useragentDefault;
									}
									string text7 = profilePath + "\\" + text5;
									if (!setting_MoTrinhDuyet.GetValueBool("isUseProfile"))
									{
										text7 = "";
									}
									Point pointFromIndexPosition = MCommon.Common.GetPointFromIndexPosition(indexPos, 5, 2);
									Point sizeChrome = MCommon.Common.GetSizeChrome(5, 2);
									chrome = new Chrome
									{
										DisableImage = !Convert.ToBoolean((setting_general.GetValue("ckbShowImageInteract") == "") ? "false" : setting_general.GetValue("ckbShowImageInteract")),
										UserAgent = text6,
										ProfilePath = text7,
										Size = sizeChrome,
										Position = pointFromIndexPosition,
										TimeWaitForSearchingElement = 3,
										TimeWaitForLoadingPage = 120,
										Proxy = text,
										TypeProxy = typeProxy,
										IsUsePortable = setting_general.GetValueBool("ckbUsePortable"),
										PathToPortableZip = setting_general.GetValue("txtPathToPortableZip")
									};
									if (isStop)
									{
										SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
										break;
									}
									if (setting_general.GetValueInt("typeBrowser") != 0)
									{
										chrome.LinkToOtherBrowser = setting_general.GetValue("txtLinkToOtherBrowser");
									}
									if (!chrome.Open())
									{
										SetStatusAccount(indexRow, text2 + Language.GetValue("Lỗi mở trình duyệt!"));
										break;
									}
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đang đăng nhâ\u0323p..."));
									string text8 = "";
									text8 = ((setting_MoTrinhDuyet.GetValueInt("typeBrowserLogin") != 0) ? "https://www.facebook.com/" : "https://m.facebook.com/");
									if (text7.Trim() != "")
									{
										num = CommonChrome.CheckLiveCookie(chrome, text8);
										switch (num)
										{
											case 1:
												flag = true;
												break;
											case -2:
												chrome.Status = StatusChromeAccount.ChromeClosed;
												goto end_IL_1431;
											case -3:
												chrome.Status = StatusChromeAccount.NoInternet;
												goto end_IL_1431;
											case 2:
												chrome.Status = StatusChromeAccount.Checkpoint;
												SetInfoAccount(cellAccount, indexRow, Language.GetValue("Checkpoint"));
												goto end_IL_1431;
										}
									}
									if (!flag)
									{
										string text9 = "";
										switch (setting_MoTrinhDuyet.GetValueInt("typeLogin"))
										{
											case 0:
												if (text5.Trim() == "" || cellAccount4.Trim() == "")
												{
													if (text5.Trim() == "")
													{
														SetStatusAccount(indexRow, text2 + Language.GetValue("Không ti\u0300m thâ\u0301y UID!"));
													}
													else if (cellAccount4.Trim() == "")
													{
														SetStatusAccount(indexRow, text2 + Language.GetValue("Không ti\u0300m thâ\u0301y Pass!"));
													}
													goto end_IL_029e;
												}
												SetStatusAccount(indexRow, text2 + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
												text9 = CommonChrome.LoginFacebookUsingUidPassNew(chrome, text5, cellAccount4, cellAccount3, text8, 2);
												try
												{
													num = Convert.ToInt32(text9);
												}
												catch
												{
													num = -1;
												}
												goto default;
											case 1:
												if (cellAccount2.Trim() == "" || cellAccount4.Trim() == "")
												{
													if (cellAccount2.Trim() == "")
													{
														SetStatusAccount(indexRow, text2 + Language.GetValue("Không ti\u0300m thâ\u0301y Email!"));
													}
													else if (cellAccount4.Trim() == "")
													{
														SetStatusAccount(indexRow, text2 + Language.GetValue("Không ti\u0300m thâ\u0301y Pass!"));
													}
													goto end_IL_029e;
												}
												SetStatusAccount(indexRow, text2 + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng email|pass..."));
												text9 = CommonChrome.LoginFacebookUsingUidPassNew(chrome, cellAccount2, cellAccount4, cellAccount3, text8, 2);
												try
												{
													num = Convert.ToInt32(text9);
												}
												catch
												{
													num = -1;
												}
												goto default;
											case 2:
												if (cellAccount5.Trim() == "")
												{
													SetStatusAccount(indexRow, text2 + Language.GetValue("Không ti\u0300m thâ\u0301y Cookie!"));
													goto end_IL_029e;
												}
												SetStatusAccount(indexRow, text2 + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng cookie..."));
												num = Convert.ToInt32(CommonChrome.LoginFacebookUsingCookie(chrome, cellAccount5, text8));
												goto default;
											default:
												if (setting_MoTrinhDuyet.GetValueInt("typeLogin") != 2)
												{
													switch (num)
													{
														case -2:
															chrome.Status = StatusChromeAccount.ChromeClosed;
															break;
														case -1:
															SetStatusAccount(indexRow, text2 + text9);
															break;
														case 0:
															SetStatusAccount(indexRow, text2 + Language.GetValue("Đăng nhập thất bại!"));
															CommonChrome.CheckStatusAccount(chrome, isSendRequest: true);
															if (chrome.Status == StatusChromeAccount.Logined)
															{
																flag = true;
															}
															break;
														case 1:
															flag = true;
															break;
														case 2:
															chrome.Status = StatusChromeAccount.Checkpoint;
															SetInfoAccount(cellAccount, indexRow, Language.GetValue("Checkpoint"));
															break;
														case 3:
															SetStatusAccount(indexRow, text2 + Language.GetValue("Không có 2fa!"));
															break;
														case 4:
															SetStatusAccount(indexRow, text2 + Language.GetValue("Tài khoản không đúng!"));
															break;
														case 5:
															SetStatusAccount(indexRow, text2 + Language.GetValue("Mật khẩu không đúng!"));
															SetInfoAccount(cellAccount, indexRow, "Changed pass");
															break;
														case 6:
															SetStatusAccount(indexRow, text2 + Language.GetValue("Mã 2fa không đúng!"));
															break;
														case 7:
															chrome.Status = StatusChromeAccount.NoInternet;
															break;
													}
													if (!flag)
													{
														SetRowColor(indexRow, 1);
														goto end_IL_029e;
													}
													break;
												}
												switch (num)
												{
													case 1:
														flag = true;
														goto default;
													case -2:
														chrome.Status = StatusChromeAccount.ChromeClosed;
														goto end_IL_1431;
													case -3:
														chrome.Status = StatusChromeAccount.NoInternet;
														goto end_IL_1431;
													case 2:
														chrome.Status = StatusChromeAccount.Checkpoint;
														SetInfoAccount(cellAccount, indexRow, Language.GetValue("Checkpoint"));
														goto end_IL_1431;
													default:
														if (flag)
														{
															break;
														}
														SetRowColor(indexRow, 1);
														SetStatusAccount(indexRow, text2 + Language.GetValue("Đăng nhâ\u0323p thâ\u0301t ba\u0323i!"));
														goto end_IL_1431;
												}
												break;
										}
									}
									if (setting_MoTrinhDuyet.GetValueInt("typeBrowserLogin") == 1 && !chrome.GetURL().StartsWith(text8))
									{
										chrome.GotoURL(text8);
									}
									SetStatusAccount(indexRow, text2 + Language.GetValue("Đăng nhâ\u0323p tha\u0300nh công!"));
									SetRowColor(indexRow, 2);
									if (setting_MoTrinhDuyet.GetValueBool("ckbAutoOpenLink"))
									{
										chrome.GotoURL(setting_MoTrinhDuyet.GetValue("txtLink"));
									}
									flag2 = !CheckIsUidFacebook(text5);
									if (flag2)
									{
										text4 = text5;
										text5 = Regex.Match(chrome.GetCookieFromChrome() + ";", "c_user=(.*?);").Groups[1].Value;
										CommonSQL.UpdateFieldToAccount(cellAccount, "uid", text5);
										SetCellAccount(indexRow, "cUid", text5);
									}
									if (setting_MoTrinhDuyet.GetValueBool("isGetCookie"))
									{
										cellAccount5 = chrome.GetCookieFromChrome();
										CommonSQL.UpdateFieldToAccount(cellAccount, "uid", text5);
										CommonSQL.UpdateFieldToAccount(cellAccount, "cookie1", cellAccount5);
										SetCellAccount(indexRow, "cCookies", cellAccount5);
									}
								end_IL_1431:;
								}
								catch (Exception ex)
								{
									SetStatusAccount(indexRow, text2 + Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
									MCommon.Common.ExportError(chrome, ex);
								}
								break;
							}
						IL_12b1:
							SetStatusAccount(indexRow, text2 + Language.GetValue("Đã dừng!"));
							break;
						end_IL_029e:
							break;
					}
					break;
				}
			}
			if (chrome != null)
			{
				StatusChromeAccount status = chrome.Status;
				StatusChromeAccount statusChromeAccount = status;
				if (statusChromeAccount == StatusChromeAccount.ChromeClosed || statusChromeAccount == StatusChromeAccount.Checkpoint || statusChromeAccount == StatusChromeAccount.NoInternet)
				{
					SetRowColor(indexRow, 1);
					SetStatusAccount(indexRow, text2 + GetContentStatusChrome.GetContent(chrome.Status));
				}
			}
			if (!flag && setting_MoTrinhDuyet.GetValueBool("isAutoCloseChromeLoginFail"))
			{
				try
				{
					chrome.Close();
				}
				catch
				{
				}
			}
			if (flag2 && Directory.Exists(setting_general.GetValue("txbPathProfile") + "\\" + text4))
			{
				string text10 = setting_general.GetValue("txbPathProfile") + "\\" + text4;
				string pathTo = setting_general.GetValue("txbPathProfile") + "\\" + text5;
				if (!MCommon.Common.MoveFolder(text10, pathTo) && MCommon.Common.CopyFolder(text10, pathTo))
				{
					MCommon.Common.DeleteFolder(text10);
				}
			}
			lock (lock_FinishProxy)
			{
				switch (setting_general.GetValueInt("ip_iTypeChangeIp"))
				{
					case 7:
						tinsoftProxy?.DecrementDangSuDung();
						break;
					case 8:
						xproxyProxy?.DecrementDangSuDung();
						break;
					case 10:
						tMProxy?.DecrementDangSuDung();
						break;
					case 9:
						break;
				}
			}
		}

		private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//Discarded unreachable code: IL_0093, IL_00a0
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				CountCheckedAccount();
			}
			catch
			{
			}
		}

		private void càiĐặtCấuHìnhMởToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fMoTrinhDuyet());
		}

		private void tiếnHànhMởToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (CountChooseRowInDatagridview() == 0)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn tài khoản cần mở trình duyệt!"), 3);
			}
			else
			{
				MoTrinhDuyet();
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvAcc = new System.Windows.Forms.DataGridView();
            this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUseragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateCreateAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInteractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmsAcc = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.chọnLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trạngTháiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bỏChọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôiPhucTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTrìnhDuyệtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếnHànhMởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtCấuHìnhMởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maBaoMât6SôToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPassTokenCookieMailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useragentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đinhDangKhacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInfoUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBackupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraMailpassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donDepProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởThưMụcBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởFileHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởFolderBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thưMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLạiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grQuanLyThuMuc = new System.Windows.Forms.GroupBox();
            this.btnLoadAcc = new MetroFramework.Controls.MetroButton();
            this.cbbTinhTrang = new MetroFramework.Controls.MetroComboBox();
            this.cbbThuMuc = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grTimKiem = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).BeginInit();
            this.ctmsAcc.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grQuanLyThuMuc.SuspendLayout();
            this.grTimKiem.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvAcc
            // 
            this.dtgvAcc.AllowUserToAddRows = false;
            this.dtgvAcc.AllowUserToDeleteRows = false;
            this.dtgvAcc.AllowUserToResizeRows = false;
            this.dtgvAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChose,
            this.cStt,
            this.cId,
            this.cUid,
            this.cToken,
            this.cCookies,
            this.cEmail,
            this.cPhone,
            this.cName,
            this.cFollow,
            this.cFriend,
            this.cGroup,
            this.cBirthday,
            this.cGender,
            this.cPassword,
            this.cMailRecovery,
            this.cPassMail,
            this.cBackup,
            this.cFa2,
            this.cUseragent,
            this.cProxy,
            this.cDateCreateAcc,
            this.cAvatar,
            this.cProfile,
            this.cThuMuc,
            this.cInteractEnd,
            this.cInfo,
            this.cGhiChu,
            this.cDateDelete,
            this.cStatus});
            this.dtgvAcc.ContextMenuStrip = this.ctmsAcc;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAcc.Location = new System.Drawing.Point(2, 124);
            this.dtgvAcc.Name = "dtgvAcc";
            this.dtgvAcc.ReadOnly = true;
            this.dtgvAcc.RowHeadersVisible = false;
            this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAcc.Size = new System.Drawing.Size(1199, 461);
            this.dtgvAcc.TabIndex = 0;
            this.dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvAcc_CellClick);
            this.dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
            this.dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
            this.dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtgvAcc_KeyDown);
            // 
            // cChose
            // 
            this.cChose.HeaderText = "Chọn";
            this.cChose.Name = "cChose";
            this.cChose.ReadOnly = true;
            this.cChose.Width = 40;
            // 
            // cStt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStt.DefaultCellStyle = dataGridViewCellStyle2;
            this.cStt.HeaderText = "STT";
            this.cStt.Name = "cStt";
            this.cStt.ReadOnly = true;
            this.cStt.Width = 35;
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            this.cId.Width = 90;
            // 
            // cUid
            // 
            this.cUid.HeaderText = "UID";
            this.cUid.Name = "cUid";
            this.cUid.ReadOnly = true;
            this.cUid.Width = 80;
            // 
            // cToken
            // 
            this.cToken.HeaderText = "Token";
            this.cToken.Name = "cToken";
            this.cToken.ReadOnly = true;
            this.cToken.Width = 70;
            // 
            // cCookies
            // 
            this.cCookies.HeaderText = "Cookie";
            this.cCookies.Name = "cCookies";
            this.cCookies.ReadOnly = true;
            this.cCookies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCookies.Width = 70;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Width = 60;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            this.cPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPhone.Visible = false;
            this.cPhone.Width = 90;
            // 
            // cName
            // 
            this.cName.HeaderText = "Tên";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.Width = 70;
            // 
            // cFollow
            // 
            this.cFollow.HeaderText = "Theo dõi";
            this.cFollow.Name = "cFollow";
            this.cFollow.ReadOnly = true;
            this.cFollow.Width = 80;
            // 
            // cFriend
            // 
            this.cFriend.HeaderText = "Bạn bè";
            this.cFriend.Name = "cFriend";
            this.cFriend.ReadOnly = true;
            this.cFriend.Width = 70;
            // 
            // cGroup
            // 
            this.cGroup.HeaderText = "Nhóm";
            this.cGroup.Name = "cGroup";
            this.cGroup.ReadOnly = true;
            this.cGroup.Width = 60;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Ngày sinh";
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.ReadOnly = true;
            this.cBirthday.Width = 90;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Giới Tính";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            this.cGender.Width = 80;
            // 
            // cPassword
            // 
            this.cPassword.HeaderText = "Mật khẩu";
            this.cPassword.Name = "cPassword";
            this.cPassword.ReadOnly = true;
            this.cPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPassword.Visible = false;
            this.cPassword.Width = 70;
            // 
            // cMailRecovery
            // 
            this.cMailRecovery.HeaderText = "Email khôi phục";
            this.cMailRecovery.Name = "cMailRecovery";
            this.cMailRecovery.ReadOnly = true;
            this.cMailRecovery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cMailRecovery.Visible = false;
            this.cMailRecovery.Width = 120;
            // 
            // cPassMail
            // 
            this.cPassMail.HeaderText = "Mật khẩu mail";
            this.cPassMail.Name = "cPassMail";
            this.cPassMail.ReadOnly = true;
            this.cPassMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPassMail.Visible = false;
            this.cPassMail.Width = 120;
            // 
            // cBackup
            // 
            this.cBackup.HeaderText = "Backup";
            this.cBackup.Name = "cBackup";
            this.cBackup.ReadOnly = true;
            this.cBackup.Width = 70;
            // 
            // cFa2
            // 
            this.cFa2.HeaderText = "Mã 2FA";
            this.cFa2.Name = "cFa2";
            this.cFa2.ReadOnly = true;
            this.cFa2.Width = 65;
            // 
            // cUseragent
            // 
            this.cUseragent.HeaderText = "Useragent";
            this.cUseragent.Name = "cUseragent";
            this.cUseragent.ReadOnly = true;
            this.cUseragent.Width = 70;
            // 
            // cProxy
            // 
            this.cProxy.HeaderText = "Proxy";
            this.cProxy.Name = "cProxy";
            this.cProxy.ReadOnly = true;
            this.cProxy.Width = 55;
            // 
            // cDateCreateAcc
            // 
            this.cDateCreateAcc.HeaderText = "Ngày tạo";
            this.cDateCreateAcc.Name = "cDateCreateAcc";
            this.cDateCreateAcc.ReadOnly = true;
            this.cDateCreateAcc.Width = 85;
            // 
            // cAvatar
            // 
            this.cAvatar.HeaderText = "Avatar";
            this.cAvatar.Name = "cAvatar";
            this.cAvatar.ReadOnly = true;
            this.cAvatar.Width = 50;
            // 
            // cProfile
            // 
            this.cProfile.HeaderText = "Profile";
            this.cProfile.Name = "cProfile";
            this.cProfile.ReadOnly = true;
            this.cProfile.Width = 50;
            // 
            // cThuMuc
            // 
            this.cThuMuc.HeaderText = "Thư mục";
            this.cThuMuc.Name = "cThuMuc";
            this.cThuMuc.ReadOnly = true;
            // 
            // cInteractEnd
            // 
            this.cInteractEnd.HeaderText = "Lần tương tác cuối";
            this.cInteractEnd.Name = "cInteractEnd";
            this.cInteractEnd.ReadOnly = true;
            // 
            // cInfo
            // 
            this.cInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cInfo.HeaderText = "Tình Trạng";
            this.cInfo.Name = "cInfo";
            this.cInfo.ReadOnly = true;
            this.cInfo.Width = 90;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi Chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.ReadOnly = true;
            // 
            // cDateDelete
            // 
            this.cDateDelete.HeaderText = "Thời gian xóa";
            this.cDateDelete.Name = "cDateDelete";
            this.cDateDelete.ReadOnly = true;
            this.cDateDelete.Width = 111;
            // 
            // cStatus
            // 
            this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cStatus.HeaderText = "Trạng Thái";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // ctmsAcc
            // 
            this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnLiveToolStripMenuItem,
            this.bỏChọnTấtCảToolStripMenuItem,
            this.khôiPhucTaiKhoanToolStripMenuItem,
            this.xóaTàiKhoảnToolStripMenuItem,
            this.mởTrìnhDuyệtToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.checkCookieToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.tảiLạiDanhSáchToolStripMenuItem});
            this.ctmsAcc.Name = "ctmsAcc";
            this.ctmsAcc.Size = new System.Drawing.Size(198, 224);
            this.ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(this.CtmsAcc_Opening);
            // 
            // chọnLiveToolStripMenuItem
            // 
            this.chọnLiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảToolStripMenuItem,
            this.liveToolStripMenuItem,
            this.tinhTrangToolStripMenuItem,
            this.trạngTháiToolStripMenuItem});
            this.chọnLiveToolStripMenuItem.Name = "chọnLiveToolStripMenuItem";
            this.chọnLiveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.chọnLiveToolStripMenuItem.Text = "Chọn";
            // 
            // tấtCảToolStripMenuItem
            // 
            this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
            this.tấtCảToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tấtCảToolStripMenuItem.Text = "Tất cả";
            this.tấtCảToolStripMenuItem.Click += new System.EventHandler(this.TấtCảToolStripMenuItem_Click);
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.liveToolStripMenuItem.Text = "Bôi đen";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.LiveToolStripMenuItem_Click);
            // 
            // tinhTrangToolStripMenuItem
            // 
            this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
            this.tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tinhTrangToolStripMenuItem.Text = "Tình trạng";
            // 
            // trạngTháiToolStripMenuItem
            // 
            this.trạngTháiToolStripMenuItem.Name = "trạngTháiToolStripMenuItem";
            this.trạngTháiToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.trạngTháiToolStripMenuItem.Text = "Trạng thái";
            this.trạngTháiToolStripMenuItem.Click += new System.EventHandler(this.trạngTháiToolStripMenuItem_Click);
            // 
            // bỏChọnTấtCảToolStripMenuItem
            // 
            this.bỏChọnTấtCảToolStripMenuItem.Name = "bỏChọnTấtCảToolStripMenuItem";
            this.bỏChọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bỏChọnTấtCảToolStripMenuItem.Text = "Bỏ chọn tất cả";
            this.bỏChọnTấtCảToolStripMenuItem.Click += new System.EventHandler(this.BỏChọnTấtCảToolStripMenuItem_Click);
            // 
            // khôiPhucTaiKhoanToolStripMenuItem
            // 
            this.khôiPhucTaiKhoanToolStripMenuItem.Name = "khôiPhucTaiKhoanToolStripMenuItem";
            this.khôiPhucTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.khôiPhucTaiKhoanToolStripMenuItem.Text = "Khôi phục tài khoản";
            this.khôiPhucTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.khôiPhucTaiKhoanToolStripMenuItem_Click);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản vĩnh viễn";
            this.xóaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.giưLaiProfileToolStripMenuItem_Click);
            // 
            // mởTrìnhDuyệtToolStripMenuItem
            // 
            this.mởTrìnhDuyệtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiếnHànhMởToolStripMenuItem,
            this.càiĐặtCấuHìnhMởToolStripMenuItem});
            this.mởTrìnhDuyệtToolStripMenuItem.Name = "mởTrìnhDuyệtToolStripMenuItem";
            this.mởTrìnhDuyệtToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.mởTrìnhDuyệtToolStripMenuItem.Text = "Mở trình duyệt";
            // 
            // tiếnHànhMởToolStripMenuItem
            // 
            this.tiếnHànhMởToolStripMenuItem.Name = "tiếnHànhMởToolStripMenuItem";
            this.tiếnHànhMởToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tiếnHànhMởToolStripMenuItem.Text = "Tiến hành mở";
            this.tiếnHànhMởToolStripMenuItem.Click += new System.EventHandler(this.tiếnHànhMởToolStripMenuItem_Click);
            // 
            // càiĐặtCấuHìnhMởToolStripMenuItem
            // 
            this.càiĐặtCấuHìnhMởToolStripMenuItem.Name = "càiĐặtCấuHìnhMởToolStripMenuItem";
            this.càiĐặtCấuHìnhMởToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.càiĐặtCấuHìnhMởToolStripMenuItem.Text = "Cài đặt cấu hình mở";
            this.càiĐặtCấuHìnhMởToolStripMenuItem.Click += new System.EventHandler(this.càiĐặtCấuHìnhMởToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uidToolStripMenuItem,
            this.passToolStripMenuItem,
            this.tokenToolStripMenuItem,
            this.cookieToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.fAToolStripMenuItem,
            this.maBaoMât6SôToolStripMenuItem,
            this.uidPassToolStripMenuItem,
            this.uidPass2FaToolStripMenuItem,
            this.mailPassMailToolStripMenuItem,
            this.uidPassTokenCookieToolStripMenuItem,
            this.uidPassTokenCookieMailPassMailToolStripMenuItem,
            this.uidPassTokenCookieMailPassMail2faToolStripMenuItem,
            this.useragentToolStripMenuItem1,
            this.proxyToolStripMenuItem1,
            this.đinhDangKhacToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // uidToolStripMenuItem
            // 
            this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
            this.uidToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.uidToolStripMenuItem.Text = "Uid";
            this.uidToolStripMenuItem.Click += new System.EventHandler(this.UidToolStripMenuItem_Click);
            // 
            // passToolStripMenuItem
            // 
            this.passToolStripMenuItem.Name = "passToolStripMenuItem";
            this.passToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.passToolStripMenuItem.Text = "Pass";
            this.passToolStripMenuItem.Click += new System.EventHandler(this.PassToolStripMenuItem_Click);
            // 
            // tokenToolStripMenuItem
            // 
            this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
            this.tokenToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.tokenToolStripMenuItem.Text = "Token";
            this.tokenToolStripMenuItem.Click += new System.EventHandler(this.TokenToolStripMenuItem_Click);
            // 
            // cookieToolStripMenuItem
            // 
            this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
            this.cookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.cookieToolStripMenuItem.Text = "Cookie";
            this.cookieToolStripMenuItem.Click += new System.EventHandler(this.CookieToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.mailToolStripMenuItem.Text = "Email";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.MailToolStripMenuItem_Click_1);
            // 
            // fAToolStripMenuItem
            // 
            this.fAToolStripMenuItem.Name = "fAToolStripMenuItem";
            this.fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.fAToolStripMenuItem.Text = "2FA";
            this.fAToolStripMenuItem.Click += new System.EventHandler(this.fAToolStripMenuItem_Click);
            // 
            // maBaoMât6SôToolStripMenuItem
            // 
            this.maBaoMât6SôToolStripMenuItem.Name = "maBaoMât6SôToolStripMenuItem";
            this.maBaoMât6SôToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.maBaoMât6SôToolStripMenuItem.Text = "Mã bảo mật 6 số";
            this.maBaoMât6SôToolStripMenuItem.Click += new System.EventHandler(this.maBaoMât6SôToolStripMenuItem_Click);
            // 
            // uidPassToolStripMenuItem
            // 
            this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
            this.uidPassToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.uidPassToolStripMenuItem.Text = "Uid|Pass";
            this.uidPassToolStripMenuItem.Click += new System.EventHandler(this.UidPassToolStripMenuItem_Click);
            // 
            // uidPass2FaToolStripMenuItem
            // 
            this.uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
            this.uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
            this.uidPass2FaToolStripMenuItem.Click += new System.EventHandler(this.uidPass2FaToolStripMenuItem_Click);
            // 
            // mailPassMailToolStripMenuItem
            // 
            this.mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
            this.mailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
            this.mailPassMailToolStripMenuItem.Click += new System.EventHandler(this.MailPassMailToolStripMenuItem_Click);
            // 
            // uidPassTokenCookieToolStripMenuItem
            // 
            this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
            this.uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";
            this.uidPassTokenCookieToolStripMenuItem.Click += new System.EventHandler(this.UidPassTokenCookieToolStripMenuItem_Click);
            // 
            // uidPassTokenCookieMailPassMailToolStripMenuItem
            // 
            this.uidPassTokenCookieMailPassMailToolStripMenuItem.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
            this.uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.uidPassTokenCookieMailPassMailToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
            this.uidPassTokenCookieMailPassMailToolStripMenuItem.Click += new System.EventHandler(this.UidPassTokenCookieMailPassMailToolStripMenuItem_Click);
            // 
            // uidPassTokenCookieMailPassMail2faToolStripMenuItem
            // 
            this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
            this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
            this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new System.EventHandler(this.UidPassTokenCookieMailPassMail2faToolStripMenuItem_Click);
            // 
            // useragentToolStripMenuItem1
            // 
            this.useragentToolStripMenuItem1.Name = "useragentToolStripMenuItem1";
            this.useragentToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
            this.useragentToolStripMenuItem1.Text = "Useragent";
            this.useragentToolStripMenuItem1.Click += new System.EventHandler(this.useragentToolStripMenuItem1_Click);
            // 
            // proxyToolStripMenuItem1
            // 
            this.proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
            this.proxyToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
            this.proxyToolStripMenuItem1.Text = "Proxy";
            this.proxyToolStripMenuItem1.Click += new System.EventHandler(this.proxyToolStripMenuItem1_Click);
            // 
            // đinhDangKhacToolStripMenuItem
            // 
            this.đinhDangKhacToolStripMenuItem.Name = "đinhDangKhacToolStripMenuItem";
            this.đinhDangKhacToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.đinhDangKhacToolStripMenuItem.Text = "Định dạng khác...";
            this.đinhDangKhacToolStripMenuItem.Click += new System.EventHandler(this.đinhDangKhacToolStripMenuItem_Click);
            // 
            // checkCookieToolStripMenuItem
            // 
            this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraWallToolStripMenuItem,
            this.checkInfoUIDToolStripMenuItem,
            this.kiểmTraTokenToolStripMenuItem,
            this.kiểmTraCookieToolStripMenuItem,
            this.checkAvatarToolStripMenuItem,
            this.checkProfileToolStripMenuItem1,
            this.checkBackupToolStripMenuItem1,
            this.kiểmTraTàiKhoảnToolStripMenuItem,
            this.kiểmTraMailpassMailToolStripMenuItem,
            this.checkProxyToolStripMenuItem});
            this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
            this.checkCookieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
            // 
            // kiểmTraWallToolStripMenuItem
            // 
            this.kiểmTraWallToolStripMenuItem.Name = "kiểmTraWallToolStripMenuItem";
            this.kiểmTraWallToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kiểmTraWallToolStripMenuItem.Text = "Check Wall";
            this.kiểmTraWallToolStripMenuItem.ToolTipText = "Không cần dùng token";
            this.kiểmTraWallToolStripMenuItem.Click += new System.EventHandler(this.KiểmTraWallToolStripMenuItem_Click);
            // 
            // checkInfoUIDToolStripMenuItem
            // 
            this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
            this.checkInfoUIDToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
            this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn " +
    "bè], [Nhóm], [Ngày sinh]";
            this.checkInfoUIDToolStripMenuItem.Click += new System.EventHandler(this.checkInfoUIDToolStripMenuItem_Click);
            // 
            // kiểmTraTokenToolStripMenuItem
            // 
            this.kiểmTraTokenToolStripMenuItem.Name = "kiểmTraTokenToolStripMenuItem";
            this.kiểmTraTokenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kiểmTraTokenToolStripMenuItem.Text = "Check Token";
            this.kiểmTraTokenToolStripMenuItem.Click += new System.EventHandler(this.KiểmTraTokenToolStripMenuItem_Click);
            // 
            // kiểmTraCookieToolStripMenuItem
            // 
            this.kiểmTraCookieToolStripMenuItem.Name = "kiểmTraCookieToolStripMenuItem";
            this.kiểmTraCookieToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kiểmTraCookieToolStripMenuItem.Text = "Check Cookie";
            this.kiểmTraCookieToolStripMenuItem.Click += new System.EventHandler(this.KiểmTraCookieToolStripMenuItem_Click);
            // 
            // checkAvatarToolStripMenuItem
            // 
            this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
            this.checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
            this.checkAvatarToolStripMenuItem.Click += new System.EventHandler(this.checkAvatarToolStripMenuItem_Click);
            // 
            // checkProfileToolStripMenuItem1
            // 
            this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
            this.checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.checkProfileToolStripMenuItem1.Text = "Check Profile";
            this.checkProfileToolStripMenuItem1.Click += new System.EventHandler(this.checkProfileToolStripMenuItem_Click);
            // 
            // checkBackupToolStripMenuItem1
            // 
            this.checkBackupToolStripMenuItem1.Name = "checkBackupToolStripMenuItem1";
            this.checkBackupToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.checkBackupToolStripMenuItem1.Text = "Check Backup";
            this.checkBackupToolStripMenuItem1.Click += new System.EventHandler(this.checkBackupToolStripMenuItem_Click);
            // 
            // kiểmTraTàiKhoảnToolStripMenuItem
            // 
            this.kiểmTraTàiKhoảnToolStripMenuItem.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
            this.kiểmTraTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kiểmTraTàiKhoảnToolStripMenuItem.Text = "Dạng checkpoint";
            this.kiểmTraTàiKhoảnToolStripMenuItem.ToolTipText = "Chỉ sử dụng khi tài khoản đã bị checkpoint!";
            this.kiểmTraTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.KiểmTraTàiKhoảnToolStripMenuItem_Click);
            // 
            // kiểmTraMailpassMailToolStripMenuItem
            // 
            this.kiểmTraMailpassMailToolStripMenuItem.Name = "kiểmTraMailpassMailToolStripMenuItem";
            this.kiểmTraMailpassMailToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kiểmTraMailpassMailToolStripMenuItem.Text = "Mail|pass Mail";
            this.kiểmTraMailpassMailToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraMailpassMailToolStripMenuItem_Click);
            // 
            // checkProxyToolStripMenuItem
            // 
            this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
            this.checkProxyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.checkProxyToolStripMenuItem.Text = "Check Proxy";
            this.checkProxyToolStripMenuItem.Click += new System.EventHandler(this.checkProxyToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaProfileToolStripMenuItem,
            this.donDepProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.profileToolStripMenuItem.Text = "Profile Chrome";
            // 
            // xóaProfileToolStripMenuItem
            // 
            this.xóaProfileToolStripMenuItem.Name = "xóaProfileToolStripMenuItem";
            this.xóaProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.xóaProfileToolStripMenuItem.Text = "Xóa profile";
            this.xóaProfileToolStripMenuItem.Click += new System.EventHandler(this.xóaProfileToolStripMenuItem_Click);
            // 
            // donDepProfileToolStripMenuItem
            // 
            this.donDepProfileToolStripMenuItem.Name = "donDepProfileToolStripMenuItem";
            this.donDepProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.donDepProfileToolStripMenuItem.Text = "Dọn dẹp profile";
            this.donDepProfileToolStripMenuItem.Click += new System.EventHandler(this.donDepProfileToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBackupToolStripMenuItem,
            this.mởThưMụcBackupToolStripMenuItem,
            this.backupToolStripMenuItem1,
            this.xóaDữLiệuBackupToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.backupToolStripMenuItem.Text = "Backup dữ liệu";
            // 
            // checkBackupToolStripMenuItem
            // 
            this.checkBackupToolStripMenuItem.Name = "checkBackupToolStripMenuItem";
            this.checkBackupToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.checkBackupToolStripMenuItem.Text = "Check Backup";
            this.checkBackupToolStripMenuItem.Click += new System.EventHandler(this.checkBackupToolStripMenuItem_Click);
            // 
            // mởThưMụcBackupToolStripMenuItem
            // 
            this.mởThưMụcBackupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFileHTMLToolStripMenuItem,
            this.mởFolderBackupToolStripMenuItem});
            this.mởThưMụcBackupToolStripMenuItem.Name = "mởThưMụcBackupToolStripMenuItem";
            this.mởThưMụcBackupToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mởThưMụcBackupToolStripMenuItem.Text = "Mở dữ liêu Backup";
            // 
            // mởFileHTMLToolStripMenuItem
            // 
            this.mởFileHTMLToolStripMenuItem.Name = "mởFileHTMLToolStripMenuItem";
            this.mởFileHTMLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mởFileHTMLToolStripMenuItem.Text = "File HTML";
            this.mởFileHTMLToolStripMenuItem.Click += new System.EventHandler(this.mơFileHTMLToolStripMenuItem_Click);
            // 
            // mởFolderBackupToolStripMenuItem
            // 
            this.mởFolderBackupToolStripMenuItem.Name = "mởFolderBackupToolStripMenuItem";
            this.mởFolderBackupToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mởFolderBackupToolStripMenuItem.Text = "Folder Backup";
            this.mởFolderBackupToolStripMenuItem.Click += new System.EventHandler(this.mởThưMụcBackupToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem1
            // 
            this.backupToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlToolStripMenuItem,
            this.thưMụcToolStripMenuItem});
            this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
            this.backupToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.backupToolStripMenuItem1.Text = "Copy dữ liệu Backup";
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.htmlToolStripMenuItem.Text = "File HTML";
            this.htmlToolStripMenuItem.Click += new System.EventHandler(this.htmlToolStripMenuItem_Click);
            // 
            // thưMụcToolStripMenuItem
            // 
            this.thưMụcToolStripMenuItem.Name = "thưMụcToolStripMenuItem";
            this.thưMụcToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.thưMụcToolStripMenuItem.Text = "Folder Backup";
            this.thưMụcToolStripMenuItem.Click += new System.EventHandler(this.thưMụcToolStripMenuItem_Click_1);
            // 
            // xóaDữLiệuBackupToolStripMenuItem
            // 
            this.xóaDữLiệuBackupToolStripMenuItem.Name = "xóaDữLiệuBackupToolStripMenuItem";
            this.xóaDữLiệuBackupToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.xóaDữLiệuBackupToolStripMenuItem.Text = "Xóa dữ liệu Backup";
            this.xóaDữLiệuBackupToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuBackupToolStripMenuItem_Click);
            // 
            // tảiLạiDanhSáchToolStripMenuItem
            // 
            this.tảiLạiDanhSáchToolStripMenuItem.Name = "tảiLạiDanhSáchToolStripMenuItem";
            this.tảiLạiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tảiLạiDanhSáchToolStripMenuItem.Text = "Tải lại danh sách";
            this.tảiLạiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.TảiLạiDanhSáchToolStripMenuItem_Click);
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
            this.pnlHeader.Size = new System.Drawing.Size(1203, 29);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1107, 0);
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
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1139, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1171, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Danh sách tài khoản đã xóa";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkRed;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1204, 38);
            this.bunifuCards1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1201, 25);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.thoátToolStripMenuItem.Text = "Cấu hình hiển thị";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.câuHinhHiênThiToolStripMenuItem_Click);
            // 
            // grQuanLyThuMuc
            // 
            this.grQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
            this.grQuanLyThuMuc.Controls.Add(this.cbbTinhTrang);
            this.grQuanLyThuMuc.Controls.Add(this.cbbThuMuc);
            this.grQuanLyThuMuc.Controls.Add(this.label2);
            this.grQuanLyThuMuc.Controls.Add(this.label1);
            this.grQuanLyThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grQuanLyThuMuc.Location = new System.Drawing.Point(292, 65);
            this.grQuanLyThuMuc.Name = "grQuanLyThuMuc";
            this.grQuanLyThuMuc.Size = new System.Drawing.Size(445, 53);
            this.grQuanLyThuMuc.TabIndex = 5;
            this.grQuanLyThuMuc.TabStop = false;
            this.grQuanLyThuMuc.Text = "Quản lý thư mục";
            // 
            // btnLoadAcc
            // 
            this.btnLoadAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAcc.Location = new System.Drawing.Point(416, 19);
            this.btnLoadAcc.Name = "btnLoadAcc";
            this.btnLoadAcc.Size = new System.Drawing.Size(25, 25);
            this.btnLoadAcc.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLoadAcc, "Load lại danh sách");
            this.btnLoadAcc.UseSelectable = true;
            this.btnLoadAcc.Click += new System.EventHandler(this.BtnLoadAcc_Click);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTinhTrang.DropDownWidth = 300;
            this.cbbTinhTrang.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.ItemHeight = 19;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "[Tất cả tình trạng]"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(289, 19);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(121, 25);
            this.cbbTinhTrang.TabIndex = 3;
            this.cbbTinhTrang.UseSelectable = true;
            this.cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbbTinhTrang_SelectedIndexChanged);
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbThuMuc.DropDownWidth = 350;
            this.cbbThuMuc.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.ItemHeight = 19;
            this.cbbThuMuc.Items.AddRange(new object[] {
            "[Tất cả thư mục]"});
            this.cbbThuMuc.Location = new System.Drawing.Point(72, 19);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(173, 25);
            this.cbbThuMuc.TabIndex = 1;
            this.cbbThuMuc.UseSelectable = true;
            this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(this.CbbFileAccount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lọc:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grTimKiem
            // 
            this.grTimKiem.Controls.Add(this.BtnSearch);
            this.grTimKiem.Controls.Add(this.cbbSearch);
            this.grTimKiem.Controls.Add(this.txbSearch);
            this.grTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTimKiem.Location = new System.Drawing.Point(2, 65);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Size = new System.Drawing.Size(284, 53);
            this.grTimKiem.TabIndex = 4;
            this.grTimKiem.TabStop = false;
            this.grTimKiem.Text = "Tìm kiếm";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Location = new System.Drawing.Point(253, 18);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(24, 24);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseSelectable = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.DropDownWidth = 100;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(12, 18);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(86, 24);
            this.cbbSearch.TabIndex = 0;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.txbSearch.Location = new System.Drawing.Point(104, 19);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(143, 23);
            this.txbSearch.TabIndex = 1;
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.lblCountSelect,
            this.toolStripStatusLabel7,
            this.lblCountTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel5.Text = "Đã chọn:";
            // 
            // lblCountSelect
            // 
            this.lblCountSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCountSelect.Name = "lblCountSelect";
            this.lblCountSelect.Size = new System.Drawing.Size(15, 17);
            this.lblCountSelect.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel7.Text = "Tất cả:";
            // 
            // lblCountTotal
            // 
            this.lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblCountTotal.Name = "lblCountTotal";
            this.lblCountTotal.Size = new System.Drawing.Size(15, 17);
            this.lblCountTotal.Text = "0";
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(836, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(158, 34);
            this.button9.TabIndex = 12;
            this.button9.Text = "Khôi phục tài khoản";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1000, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa tài khoản vĩnh viễn";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(688, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "[Bôi đen nhiều dòng rồi nhấn phím Space] hoặc [Click đúp vào tài khoản] để tích c" +
    "họn!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fbin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grTimKiem);
            this.Controls.Add(this.grQuanLyThuMuc);
            this.Controls.Add(this.dtgvAcc);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fbin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAX CARE";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).EndInit();
            this.ctmsAcc.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grQuanLyThuMuc.ResumeLayout(false);
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}