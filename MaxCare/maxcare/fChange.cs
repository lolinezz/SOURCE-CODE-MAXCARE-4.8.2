using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Common;
using maxcare.Enum;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// maxcare.fChange
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Security.Cryptography;
	using System.Text;
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
	using Newtonsoft.Json.Linq;

	public class fchange : Form
	{
		private Random rd = new Random();

		private bool isStop = false;

		public static bool isAdd;

		private JSON_Settings settings;

		private JSON_Settings setting_general;

		private JSON_Settings settingg;

		private object k = new object();

		private List<int> lstPossition = new List<int>();

		private List<Thread> lstThread = null;

		private Queue<string> lstProxyTinsoft = new Queue<string>();

		private Queue<string> lstXproxy = new Queue<string>();

		private Queue<string> lstUid = new Queue<string>();

		private string pathFolderAvatar = "";

		private string pathFolderCover = "";

		private string pathFolderTieuSu = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\tieusu";

		private string pathFolderThongTinCaNhan = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\thongtincanhan";

		private string pathFileHo = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doiten\\ho.txt";

		private string pathFileTenDem = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doiten\\tendem.txt";

		private string pathFileTen = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doiten\\ten.txt";

		private string pathFileMatKhau = Path.GetDirectoryName(Application.ExecutablePath) + "\\configschange\\doimk.txt";

		private List<string> lstHo = new List<string>();

		private List<string> lstTenDem = new List<string>();

		private List<string> lstTen = new List<string>();

		private List<string> lstTenRandom = new List<string>();

		private List<string> lstPassword = new List<string>();

		private List<string> lstNoiLamViec = new List<string>();

		private List<string> lstNoiLamViecTemp = new List<string>();

		private List<string> lstQueQuan = new List<string>();

		private List<string> lstQueQuanTemp = new List<string>();

		private List<string> lstThanhPho = new List<string>();

		private List<string> lstThanhPhoTemp = new List<string>();

		private List<string> lstTruongDH = new List<string>();

		private List<string> lstTruongDHTemp = new List<string>();

		private List<string> lstTruongTHPT = new List<string>();

		private List<string> lstTruongTHPTTemp = new List<string>();

		private List<string> lstMailAdd = new List<string>();

		private List<string> lstMailVerify = new List<string>();

		private string ipx = "";

		private List<string> lstMailLoi = new List<string>();

		private List<string> lstPathFileTieuSu = new List<string>();

		private List<string> lstPathFileTieuSuTemp = new List<string>();

		private List<string> lstPathFolderAvatar = new List<string>();

		private List<string> lstPathFolderAvatarTemp = new List<string>();

		private List<string> lstPathFolderCover = new List<string>();

		private List<string> lstPathFolderCoverTemp = new List<string>();

		private List<string> lstPathImage = new List<string>();

		private List<TinsoftProxy> listTinsoft = null;

		private List<XproxyProxy> listxProxy = null;

		private List<TMProxy> listTMProxy = null;

		private List<ProxyWeb> listProxyWeb = null;

		private List<ShopLike> listShopLike = null;

		private List<string> listApiTinsoft = null;

		private List<string> listProxyXproxy = null;

		private List<string> listProxyTMProxy = null;

		private List<string> listProxyProxyv6 = null;

		private List<string> listProxyShopLike = null;

		private object lock_StartProxy = new object();

		private object lock_FinishProxy = new object();

		private object lock1 = new object();

		private IContainer components = null;

		private BunifuDragControl bunifuDragControl1;

		private BunifuDragControl bunifuDragControl2;

		private BunifuCards bunifuCards1;

		private Panel pnlHeader;

		private BunifuCustomLabel bunifuCustomLabel1;

		private Panel panel3;

		private ToolStripMenuItem liveToolStripMenuItem;

		private ToolStripMenuItem dieToolStripMenuItem;

		private ToolStripMenuItem checkpointToolStripMenuItem;

		private ToolStripMenuItem changePasswordToolStripMenuItem;

		private ToolStripMenuItem tokenToolStripMenuItem;

		private ToolStripMenuItem cookieToolStripMenuItem;

		private ToolStripMenuItem uidPassToolStripMenuItem;

		private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		private ToolStripMenuItem danhSáchChọnToolStripMenuItem;

		private ToolStripMenuItem danhSáchKhôngChọnToolStripMenuItem;

		private ToolStripMenuItem tấtCảToolStripMenuItem;

		private ToolStripMenuItem uidToolStripMenuItem;

		private ToolStripMenuItem passToolStripMenuItem;

		private ToolStripMenuItem giữNguyênỞThưMụcCũToolStripMenuItem;

		private ToolStripMenuItem mnsCutAccount;

		private ToolStripMenuItem đăngNhậpProfileToolStripMenuItem;

		private ToolStripMenuItem cookieToolStripMenuItem1;

		private ToolStripMenuItem uidPassToolStripMenuItem1;

		private ToolStripMenuItem đăngNhậpTrìnhDuyệtMớiToolStripMenuItem;

		private ToolStripMenuItem cookieToolStripMenuItem2;

		private ToolStripMenuItem uidPassToolStripMenuItem2;

		private ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		private ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		private ToolStripMenuItem kiểmTraTàiKhoảnToolStripMenuItem;

		private ToolStripMenuItem mậtKhẩuToolStripMenuItem1;

		private ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;

		private ToolStripMenuItem tokenToolStripMenuItem2;

		private ToolStripMenuItem tựĐộngLấyToolStripMenuItem1;

		private ToolStripMenuItem tokenBussinessToolStripMenuItem;

		private ToolStripMenuItem tokenInstagramToolStripMenuItem1;

		private ToolStripMenuItem tokenIosToolStripMenuItem;

		private ToolStripMenuItem tokenAndroidToolStripMenuItem1;

		private ToolStripMenuItem nhậpDữLiệuToolStripMenuItem2;

		private ToolStripMenuItem cookieToolStripMenuItem3;

		private ToolStripMenuItem tựĐộngLấyToolStripMenuItem;

		private ToolStripMenuItem nhậpDữLiệuToolStripMenuItem1;

		private ToolStripMenuItem backupTokenToolStripMenuItem;

		private ToolStripMenuItem backupCookieToolStripMenuItem;

		private ToolStripMenuItem backupCookieTrungGianToolStripMenuItem;

		private PictureBox pictureBox1;

		private Button button2;

		private Button button1;

		private Button btnMinimize;

		private BunifuCustomLabel lblChoosed;

		private BunifuCustomLabel bunifuCustomLabel2;

		private Label lblCountAcc;

		private Label label7;

		private ContextMenuStrip ctmsAcc;

		private ToolStripMenuItem chọnTấtCảToolStripMenuItem;

		private ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		private ToolStripMenuItem ctmsChonTrangThai;

		private ToolStripMenuItem xóaToolStripMenuItem;

		private Button btnConfig;

		private Button btnPause;

		private Button btnStart;

		public DataGridView dtgvAcc;

		private Button button3;

		private DataGridViewCheckBoxColumn cChose;

		private DataGridViewTextBoxColumn cStt;

		private DataGridViewTextBoxColumn cId;

		private DataGridViewTextBoxColumn cUid;

		private DataGridViewTextBoxColumn cCookies;

		private DataGridViewTextBoxColumn cName;

		private DataGridViewTextBoxColumn cBirthday;

		private DataGridViewTextBoxColumn cGender;

		private DataGridViewTextBoxColumn cPassword;

		private DataGridViewTextBoxColumn cFa2;

		private DataGridViewTextBoxColumn cUseragent;

		private DataGridViewTextBoxColumn cProxy;

		private DataGridViewTextBoxColumn cInfo;

		private DataGridViewTextBoxColumn cStatus;

		public fchange(List<string> listAcc)
		{
			InitializeComponent();
			if (listAcc != null && listAcc.Count > 0)
			{
				for (int i = 0; i < listAcc.Count; i++)
				{
					dtgvAcc.Rows.Add(true, listAcc[i].Split('|')[0], listAcc[i].Split('|')[1], listAcc[i].Split('|')[2], listAcc[i].Split('|')[3], listAcc[i].Split('|')[4], listAcc[i].Split('|')[5], listAcc[i].Split('|')[6], listAcc[i].Split('|')[7], listAcc[i].Split('|')[8], listAcc[i].Split('|')[9], listAcc[i].Split('|')[10], listAcc[i].Split('|')[11], "");
				}
			}
			CountAcc();
			LoadConfig();
			ChangeLanguage();
			isAdd = false;
		}

		private void LoadConfig()
		{
			settings = new JSON_Settings("configChange");
			setting_general = new JSON_Settings("configGeneral");
			settingg = new JSON_Settings("configCheckpoint");
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Maximized)
			{
				base.WindowState = FormWindowState.Normal;
			}
			else
			{
				base.WindowState = FormWindowState.Maximized;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void ChangeLanguage()
		{
			//Discarded unreachable code: IL_00b7, IL_00d1
			Language.GetValue(bunifuCustomLabel1);
			Language.GetValue(btnStart);
			Language.GetValue(btnPause);
			Language.GetValue(btnConfig);
			Language.GetValue(button3);
			Language.GetValue(bunifuCustomLabel2);
			Language.GetValue(label7);
			foreach (DataGridViewColumn column in dtgvAcc.Columns)
			{
				Language.GetValue(column);
			}
			Language.GetValue(chọnTấtCảToolStripMenuItem);
			Language.GetValue(bỏChọnTấtCảToolStripMenuItem);
			Language.GetValue(ctmsChonTrangThai);
			Language.GetValue(xóaToolStripMenuItem);
		}

		private void rControl(string dt)
		{
			//Discarded unreachable code: IL_0099, IL_00a6
			try
			{
				if (dt == "start")
				{
					Invoke((MethodInvoker)delegate
					{
						btnPause.Enabled = true;
						btnStart.Enabled = false;
					});
				}
				else if (dt == "stop")
				{
					Invoke((MethodInvoker)delegate
					{
						btnPause.Text = Language.GetValue("Ta\u0323m dư\u0300ng");
						btnPause.Enabled = false;
						btnStart.Enabled = true;
					});
				}
			}
			catch
			{
			}
		}

		private void CountAcc()
		{
			//Discarded unreachable code: IL_0031, IL_003e
			try
			{
				lblCountAcc.Text = dtgvAcc.RowCount.ToString();
			}
			catch
			{
			}
		}

		private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Discarded unreachable code: IL_00e6, IL_00f3, IL_00ff, IL_010c
			try
			{
				if (e.ColumnIndex == 0)
				{
					try
					{
						if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
						{
							dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
						}
						else
						{
							dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			UpdateSelectCountRecord();
		}

		private void UpdateSelectCountRecord()
		{
			//Discarded unreachable code: IL_00d5, IL_00e2
			int count = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					count++;
				}
			}
			try
			{
				lblChoosed.Invoke((MethodInvoker)delegate
				{
					lblChoosed.Text = count.ToString();
				});
			}
			catch
			{
			}
		}

		private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
		{
			//Discarded unreachable code: IL_014e, IL_015b
			try
			{
				if (e.KeyValue == 32)
				{
					for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
					{
						int index = dtgvAcc.SelectedRows[i].Index;
						if (Convert.ToBoolean(dtgvAcc.Rows[index].Cells["cChose"].Value))
						{
							dtgvAcc.Rows[index].Cells["cChose"].Value = false;
						}
						else
						{
							dtgvAcc.Rows[index].Cells["cChose"].Value = true;
						}
					}
				}
			}
			catch
			{
			}
			UpdateSelectCountRecord();
		}

		private void chọnTấtCảToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0081, IL_008e
			try
			{
				for (int i = 0; i < dtgvAcc.Rows.Count; i++)
				{
					dtgvAcc.Rows[i].Cells["cChose"].Value = true;
				}
			}
			catch
			{
			}
			UpdateSelectCountRecord();
		}

		private void bỏChọnTấtCảToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0081, IL_008e
			try
			{
				for (int i = 0; i < dtgvAcc.Rows.Count; i++)
				{
					dtgvAcc.Rows[i].Cells["cChose"].Value = false;
				}
			}
			catch
			{
			}
			UpdateSelectCountRecord();
		}

		private void ctmsChonTrangThai_Click(object sender, EventArgs e)
		{
		}

		private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_01b5, IL_01c2
			try
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < dtgvAcc.Rows.Count; i++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						text = dtgvAcc.Rows[i].Cells["cCookies"].Value.ToString();
						text2 = Regex.Match(text, "c_user=(.*?);").Groups[1].Value;
						dtgvAcc.Rows.RemoveAt(i);
						i--;
					}
				}
				text = dtgvAcc.SelectedRows[0].Cells["cCookies"].Value.ToString();
				text2 = Regex.Match(text, "c_user=(.*?);").Groups[1].Value;
			}
			catch (Exception)
			{
			}
			UpdateSelectCountRecord();
			CountAcc();
		}

		private void ctmsAcc_Opening(object sender, CancelEventArgs e)
		{
			ctmsChonTrangThai.DropDownItems.Clear();
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (dtgvAcc.Rows[i].Cells["cStatus"].Value != null && !dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString().Equals("") && !list.Contains(dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString()))
				{
					string text = dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString();
					string value = Regex.Match(text, "\\(IP: (.*?)\\)").Value;
					if (value != "")
					{
						text = text.Replace(value, "").Trim();
					}
					value = Regex.Match(text, "\\[(.*?)\\]").Value;
					if (value != "")
					{
						text = text.Replace(value, "").Trim();
					}
					if (text != "" && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				ctmsChonTrangThai.DropDownItems.Add(list[j]);
				ctmsChonTrangThai.DropDownItems[j].Click += SelectGridByStatus;
			}
		}

		private void SelectGridByStatus(object sender, EventArgs e)
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string value = toolStripMenuItem.Text;
				dtgvAcc.Rows[i].Cells["cChose"].Value = dtgvAcc.Rows[i].Cells["cStatus"].Value.ToString().Contains(value);
			}
			UpdateSelectCountRecord();
		}

		private void btnConfig_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fChangeConfig());
		}

		public List<string> CloneList(List<string> lstFrom)
		{
			//Discarded unreachable code: IL_004b, IL_0058
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < lstFrom.Count; i++)
				{
					list.Add(lstFrom[i]);
				}
			}
			catch
			{
			}
			return list;
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

		private void btnShare_Click_1(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_17db, IL_1807
			try
			{
				LoadConfig();
				int maxThread = settings.GetValueInt("change_nudThread", 3);
				if (!settings.GetValueBool("change_ckbGiaiCheckPoint") || !settingg.GetValueBool("ckbImage"))
				{
					goto IL_019e;
				}
				string value = settingg.GetValue("txtImage");
				if (value == "")
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng chọn đường dẫn folder chứa ảnh"), 2);
					return;
				}
				if (Directory.GetFiles(value).Length == 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng thêm a\u0309nh!"), 2);
					return;
				}
				lstPathImage = Directory.GetFiles(value).ToList();
				goto IL_019e;
			IL_049e:
				if (!settings.GetValueBool("change_ckbThemMoTa"))
				{
					goto IL_0560;
				}
				if (Directory.GetFiles(pathFolderTieuSu).Length == 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng thêm tiê\u0309u sư\u0309!"), 2);
					return;
				}
				lstPathFileTieuSu = Directory.GetFiles(pathFolderTieuSu).ToList();
				lstPathFileTieuSuTemp = CloneList(lstPathFileTieuSu);
				goto IL_0560;
			IL_0560:
				if (settings.GetValueBool("change_ckbCapNhatThongTin"))
				{
					lstNoiLamViec = File.ReadAllLines("configschange\\thongtincanhan\\NoiLamViec.txt").ToList();
					lstQueQuan = File.ReadAllLines("configschange\\thongtincanhan\\QueQuan.txt").ToList();
					lstThanhPho = File.ReadAllLines("configschange\\thongtincanhan\\ThanhPho.txt").ToList();
					lstTruongDH = File.ReadAllLines("configschange\\thongtincanhan\\TruongDH.txt").ToList();
					lstTruongTHPT = File.ReadAllLines("configschange\\thongtincanhan\\TruongTHPT.txt").ToList();
					lstNoiLamViec = MCommon.Common.RemoveEmptyItems(lstNoiLamViec);
					lstNoiLamViecTemp = MCommon.Common.CloneList(lstNoiLamViec);
					lstQueQuan = MCommon.Common.RemoveEmptyItems(lstQueQuan);
					lstQueQuanTemp = MCommon.Common.CloneList(lstQueQuan);
					lstThanhPho = MCommon.Common.RemoveEmptyItems(lstThanhPho);
					lstThanhPhoTemp = MCommon.Common.CloneList(lstThanhPho);
					lstTruongDH = MCommon.Common.RemoveEmptyItems(lstTruongDH);
					lstTruongDHTemp = MCommon.Common.CloneList(lstTruongDH);
					lstTruongTHPT = MCommon.Common.RemoveEmptyItems(lstTruongTHPT);
					lstTruongTHPTTemp = MCommon.Common.CloneList(lstTruongTHPT);
				}
				if (!settings.GetValueBool("change_ckbDoiTen"))
				{
					goto IL_09d7;
				}
				if (settings.GetValueInt("change_typeDatTen") == 0)
				{
					lstHo = File.ReadAllLines(pathFileHo).ToList();
					lstHo = MCommon.Common.RemoveEmptyItems(lstHo);
					if (lstHo.Count == 0)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng nhâ\u0323p thêm Ho\u0323!"), 2);
						return;
					}
					lstTen = File.ReadAllLines(pathFileTen).ToList();
					lstTen = MCommon.Common.RemoveEmptyItems(lstTen);
					if (lstTen.Count == 0)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng nhâ\u0323p thêm Tên!"), 2);
						return;
					}
					lstTenDem = File.ReadAllLines(pathFileTenDem).ToList();
					lstTenDem = MCommon.Common.RemoveEmptyItems(lstTenDem);
					goto IL_09d7;
				}
				if (settings.GetValueInt("change_typeTenRandom") == 0)
				{
					lstHo = SetupFolder.GetListHoVN();
					lstTenDem = SetupFolder.GetListTenDemVN();
					lstTen = SetupFolder.GetListTenVN();
				}
				else
				{
					lstHo = SetupFolder.GetListHoEN();
					lstTenDem = new List<string>();
					lstTen = SetupFolder.GetListTenEN();
				}
				goto IL_09d7;
			IL_019e:
				if (!settings.GetValueBool("change_ckbDoiAvatar"))
				{
					goto IL_02fe;
				}
				pathFolderAvatar = settings.GetValue("change_txtPathAvatar");
				if (pathFolderAvatar == "")
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng chọn đường dẫn folder chứa avatar!"), 2);
					return;
				}
				if (Directory.GetFiles(pathFolderAvatar).Length == 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng thêm a\u0309nh avatar!"), 2);
					return;
				}
				lstPathFolderAvatar = Directory.GetFiles(pathFolderAvatar).ToList();
				lstPathFolderAvatarTemp = CloneList(lstPathFolderAvatar);
				goto IL_02fe;
			IL_0d85:
				for (int i = 0; i < maxThread; i++)
				{
					lstPossition.Add(0);
				}
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
							for (int m = 0; m < listApiTinsoft.Count; m++)
							{
								TinsoftProxy item4 = new TinsoftProxy(listApiTinsoft[m], setting_general.GetValueInt("nudLuongPerIPTinsoft"), setting_general.GetValueInt("cbbLocationTinsoft"));
								listTinsoft.Add(item4);
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
								MessageBoxHelper.ShowMessageBox(Language.GetValue("XProxy không đủ, vui lòng mua thêm!"), 2);
								return;
							}
							listxProxy = new List<XproxyProxy>();
							for (int n = 0; n < listProxyXproxy.Count; n++)
							{
								XproxyProxy item5 = new XproxyProxy(setting_general.GetValue("txtServiceURLXProxy"), listProxyXproxy[n], setting_general.GetValueInt("typeProxy"), setting_general.GetValueInt("nudLuongPerIPXProxy"));
								listxProxy.Add(item5);
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
							for (int k = 0; k < listProxyTMProxy.Count; k++)
							{
								TMProxy item2 = new TMProxy(listProxyTMProxy[k], 0, setting_general.GetValueInt("nudLuongPerIPTMProxy"));
								listTMProxy.Add(item2);
							}
							if (listProxyTMProxy.Count * setting_general.GetValueInt("nudLuongPerIPTMProxy") < maxThread)
							{
								maxThread = listProxyTMProxy.Count * setting_general.GetValueInt("nudLuongPerIPTMProxy");
							}
							break;
						}
					case 11:
						{
							listProxyProxyv6 = setting_general.GetValueList("txtListProxyv6");
							if (listProxyProxyv6.Count == 0)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Proxy không đủ, vui lòng cấu hình lại!"), 2);
								return;
							}
							listProxyWeb = new List<ProxyWeb>();
							for (int l = 0; l < listProxyProxyv6.Count; l++)
							{
								if (0 == 0)
								{
									ProxyWeb item3 = new ProxyWeb(setting_general.GetValue("txtApiProxyv6"), listProxyProxyv6[l], 0, setting_general.GetValueInt("nudLuongPerIPProxyv6"));
									listProxyWeb.Add(item3);
								}
							}
							if (listProxyProxyv6.Count * setting_general.GetValueInt("nudLuongPerIPProxyv6") < maxThread)
							{
								maxThread = listProxyProxyv6.Count * setting_general.GetValueInt("nudLuongPerIPProxyv6");
							}
							break;
						}
					case 12:
						{
							listProxyShopLike = setting_general.GetValueList("txtApiShopLike");
							if (listProxyShopLike.Count == 0)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("TMProxy không đủ, vui lòng mua thêm!"), 2);
								return;
							}
							listShopLike = new List<ShopLike>();
							for (int j = 0; j < listProxyShopLike.Count; j++)
							{
								ShopLike item = new ShopLike(listProxyShopLike[j], 0, setting_general.GetValueInt("nudLuongPerIPShopLike"));
								listShopLike.Add(item);
							}
							if (listProxyShopLike.Count * setting_general.GetValueInt("nudLuongPerIPShopLike") < maxThread)
							{
								maxThread = listProxyShopLike.Count * setting_general.GetValueInt("nudLuongPerIPShopLike");
							}
							break;
						}
				}
				rControl("start");
				isAdd = true;
				isStop = false;
				int curChangeIp = 0;
				bool isChangeIPSuccess = false;
				int checkDelayChrome = 0;
				lstThread = new List<Thread>();
				new Thread((ThreadStart)delegate
				{
					try
					{
						int num3 = 0;
						while (true)
						{
							if (num3 < dtgvAcc.Rows.Count && !isStop)
							{
								if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
								{
									if (lstThread.Count < maxThread)
									{
										if (isStop)
										{
											goto IL_0454;
										}
										int row = num3++;
										if (checkDelayChrome > 0)
										{
											MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayOpenChrome", 1));
										}
										checkDelayChrome++;
										Thread thread = new Thread((ThreadStart)delegate
										{
											try
											{
												int indexOfPossitionApp = MCommon.Common.GetIndexOfPossitionApp(ref lstPossition);
												ExcuteOneThread(row, indexOfPossitionApp);
												MCommon.Common.FillIndexPossition(ref lstPossition, indexOfPossitionApp);
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, row, "cChose", false);
											}
											catch (Exception ex3)
											{
												MCommon.Common.ExportError(null, ex3);
											}
										});
										lstThread.Add(thread);
										thread.Start();
									}
									else if (setting_general.GetValueInt("ip_iTypeChangeIp") != 0 && setting_general.GetValueInt("ip_iTypeChangeIp") != 7 && setting_general.GetValueInt("ip_iTypeChangeIp") != 8 && setting_general.GetValueInt("ip_iTypeChangeIp") != 9 && setting_general.GetValueInt("ip_iTypeChangeIp") != 10 && setting_general.GetValueInt("ip_iTypeChangeIp") != 11 && setting_general.GetValueInt("ip_iTypeChangeIp") != 12)
									{
										for (int num4 = 0; num4 < lstThread.Count; num4++)
										{
											lstThread[num4].Join();
											lstThread.RemoveAt(num4--);
										}
										if (isStop)
										{
											goto IL_0454;
										}
										Interlocked.Increment(ref curChangeIp);
										if (curChangeIp >= Convert.ToInt32((setting_general.GetValue("ip_nudChangeIpCount") == "") ? "1" : setting_general.GetValue("ip_nudChangeIpCount")))
										{
											for (int num5 = 0; num5 < 3; num5++)
											{
												isChangeIPSuccess = MCommon.Common.ChangeIP(setting_general.GetValueInt("ip_iTypeChangeIp"), setting_general.GetValueInt("typeDcom"), setting_general.GetValue("ip_txtProfileNameDcom"), setting_general.GetValue("txtUrlHilink"), setting_general.GetValueInt("ip_cbbHostpot"), setting_general.GetValue("ip_txtNordVPN"));
												if (isChangeIPSuccess)
												{
													break;
												}
											}
											if (!isChangeIPSuccess)
											{
												MessageBoxHelper.ShowMessageBox(Language.GetValue("Không thê\u0309 đô\u0309i ip!"));
												break;
											}
											curChangeIp = 0;
										}
									}
									else
									{
										for (int num6 = 0; num6 < lstThread.Count; num6++)
										{
											if (!lstThread[num6].IsAlive)
											{
												lstThread.RemoveAt(num6--);
											}
										}
									}
								}
								else
								{
									num3++;
								}
								if (!isStop)
								{
									continue;
								}
							}
							goto IL_0454;
						IL_0454:
							for (int num7 = 0; num7 < lstThread.Count; num7++)
							{
								lstThread[num7].Join();
							}
							break;
						}
					}
					catch (Exception ex2)
					{
						MCommon.Common.ExportError(null, ex2);
					}
					rControl("stop");
					if (settings.GetValueBool("ckbAddMail"))
					{
						if (settings.GetValueInt("themMail") == 1 && !settings.GetValueBool("ckbMailVip"))
						{
							File.WriteAllLines("configschange\\addmail\\hotmail.txt", lstMailAdd);
						}
						MCommon.Common.CreateFolder("configschange\\addmail");
						File.WriteAllLines("configschange\\addmail\\MailLoi.txt", lstMailLoi);
					}
					if (settings.GetValueBool("change_ckbVerify"))
					{
						MCommon.Common.CreateFolder("configschange\\verify");
						File.WriteAllLines("configschange\\verify\\hotmail.txt", lstMailVerify);
					}
				}).Start();
				goto end_IL_0001;
			IL_09d7:
				if (!settings.GetValueBool("change_ckbDoiPass") || settings.GetValueInt("change_typeDoiPass") != 0)
				{
					goto IL_0ab8;
				}
				lstPassword = MCommon.Common.RemoveEmptyItems(File.ReadAllLines(pathFileMatKhau).ToList());
				if (lstPassword.Count != 0)
				{
					goto IL_0ab8;
				}
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng nhâ\u0323p thêm Mâ\u0323t khâ\u0309u!"), 2);
				goto end_IL_0001;
			IL_0ab8:
				int num = 0;
				for (int num2 = 0; num2 < dtgvAcc.Rows.Count; num2++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						num++;
					}
				}
				if (!settings.GetValueBool("ckbAddMail") || settings.GetValueInt("themMail") != 1)
				{
					goto IL_0c84;
				}
				lstMailAdd = File.ReadAllLines("configschange\\addmail\\hotmail.txt").ToList();
				lstMailAdd = MCommon.Common.RemoveEmptyItems(lstMailAdd);
				if (lstMailAdd.Count >= num || settings.GetValueBool("ckbMailVip"))
				{
					goto IL_0c84;
				}
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thêm mail cần add!"), 3);
				goto end_IL_0001;
			IL_02fe:
				if (!settings.GetValueBool("change_ckbDoiAnhBia") || settings.GetValueInt("change_typeUpCover") != 0)
				{
					goto IL_049e;
				}
				pathFolderCover = settings.GetValue("change_txtPathCover");
				if (pathFolderCover == "")
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng chọn đường dẫn folder chứa ảnh bìa!"), 2);
					return;
				}
				if (Directory.GetFiles(pathFolderCover).Length == 0)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng thêm a\u0309nh bi\u0300a!"), 2);
					return;
				}
				lstPathFolderCover = Directory.GetFiles(pathFolderCover).ToList();
				lstPathFolderCoverTemp = CloneList(lstPathFolderCover);
				goto IL_049e;
			IL_0c84:
				if (!settings.GetValueBool("change_ckbVerify") || settings.GetValueInt("change_typeMail") != 0)
				{
					goto IL_0d85;
				}
				lstMailVerify = File.ReadAllLines("configschange\\verify\\hotmail.txt").ToList();
				lstMailVerify = MCommon.Common.RemoveEmptyItems(lstMailVerify);
				if (lstMailVerify.Count >= num)
				{
					goto IL_0d85;
				}
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thêm mail cần add!"), 3);
			end_IL_0001:;
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex);
			}
		}

		private int CheckStatusChrome(Chrome chrome)
		{
			//Discarded unreachable code: IL_0043, IL_0050
			int result = 0;
			try
			{
				if (chrome.CheckChromeClosed())
				{
					result = 2;
				}
				else if (CommonChrome.IsCheckpoint(chrome))
				{
					result = 3;
				}
			}
			catch
			{
			}
			return result;
		}

		public static int ChangeNgaySinh(Chrome chrome, int ngay, int thang, int nam)
		{
			//Discarded unreachable code: IL_02f8, IL_0305
			bool flag = false;
			try
			{
				chrome.GotoURL("https://m.facebook.com/editprofile.php?type=basic&edit=birthday");
				chrome.DelayTime(3.0);
				if (chrome.CheckExistElement("#root > div > form > table > tbody > tr:nth-child(2) > td > div", 5.0) != 1)
				{
					chrome.Select(1, "day", ngay.ToString());
					chrome.DelayTime(1.0);
					chrome.Select(1, "month", thang.ToString());
					chrome.DelayTime(0.5);
					chrome.Select(1, "year", nam.ToString());
					chrome.DelayTime(0.5);
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(2.0);
					if (chrome.CheckExistElement("[name=\"birthday_confirmation\"]", 5.0) == 1)
					{
						chrome.Click(4, "[name=\"birthday_confirmation\"]");
						chrome.DelayTime(1.0);
					}
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(1.0);
					if (chrome.CheckExistElement("[data-sigil=\"profile-card-header\"]", 10.0) == 1)
					{
						flag = true;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		private void LoadStatusDatagridView(int row, string status)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, row, "cStatus", status);
		}

		public void SetStatusAccount(int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", value);
		}

		public void SetInfoAccount(string id, int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cInfo", value);
			CommonSQL.UpdateFieldToAccount(id, "info", value);
		}

		private void ExcuteOneThread(object data, int indexPos)
		{
			//Discarded unreachable code: IL_0345, IL_0359, IL_0669, IL_067e, IL_0779, IL_078d, IL_0b50, IL_0b65, IL_0d13, IL_0d27, IL_1037, IL_104c, IL_1131, IL_1145, IL_14e4, IL_14f9, IL_15de, IL_15f2, IL_1902, IL_1917, IL_2907, IL_291a, IL_37fc, IL_3811, IL_3b4c, IL_3b61, IL_3e1e, IL_3e33, IL_402c, IL_4041, IL_42b5, IL_42d2, IL_4546, IL_4563, IL_47d7, IL_47f4, IL_4a68, IL_4a85, IL_69bc, IL_6a39, IL_6e9e, IL_6eab, IL_6ffe, IL_701b
			int num = 0;
			int num2 = 0;
			string text = "";
			int num3 = (int)data;
			Chrome chrome = null;
			string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cId");
			string text2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cUid");
			string text3 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cPassword");
			string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cCookies");
			string statusDataGridView3 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cFa2");
			string text4 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cUseragent");
			if (text2 == "")
			{
				text2 = Regex.Match(statusDataGridView2, "c_user=(.*?);").Groups[1].Value;
			}
			TinsoftProxy tinsoftProxy = null;
			XproxyProxy xproxyProxy = null;
			TMProxy tMProxy = null;
			ProxyWeb proxyWeb = null;
			ShopLike shopLike = null;
			string text5 = "";
			int typeProxy = 0;
			string text6 = "";
			while (true)
			{
				if (isStop)
				{
					LoadStatusDatagridView(num3, text5 + Language.GetValue("Đã dừng!"));
					num = 1;
					break;
				}
				switch (setting_general.GetValueInt("ip_iTypeChangeIp"))
				{
					case 7:
						LoadStatusDatagridView(num3, Language.GetValue("Đang lấy proxy Tinsoft..."));
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
									TinsoftProxy tinsoftProxy2 = tinsoftProxy;
									tinsoftProxy2.dangSuDung++;
									tinsoftProxy2 = tinsoftProxy;
									tinsoftProxy2.daSuDung++;
									break;
								}
								bool flag7 = true;
							}
							if (isStop)
							{
								LoadStatusDatagridView(num3, text5 + Language.GetValue("Đã dừng!"));
								num = 1;
								break;
							}
							bool flag8 = true;
							if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
							{
								LoadStatusDatagridView(num3, text5 + "Delay check IP...");
								MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
							}
							if (!setting_general.GetValueBool("ckbKhongCheckIP"))
							{
								text5 = "(IP: " + text.Split(':')[0] + ") ";
								LoadStatusDatagridView(num3, text5 + "Check IP...");
								text6 = MCommon.Common.CheckProxy(text, 0);
								if (text6 == "")
								{
									flag8 = false;
								}
							}
							if (!flag8)
							{
								TinsoftProxy tinsoftProxy2 = tinsoftProxy;
								tinsoftProxy2.dangSuDung--;
								tinsoftProxy2 = tinsoftProxy;
								tinsoftProxy2.daSuDung--;
								continue;
							}
							goto default;
						}
					case 8:
						LoadStatusDatagridView(num3, Language.GetValue("Đang lấy Proxy..."));
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
									XproxyProxy xproxyProxy2 = xproxyProxy;
									xproxyProxy2.dangSuDung++;
									xproxyProxy2 = xproxyProxy;
									xproxyProxy2.daSuDung++;
									break;
								}
								xproxyProxy.isProxyLive = false;
								bool flag11 = true;
							}
							if (isStop)
							{
								LoadStatusDatagridView(num3, text5 + Language.GetValue("Đã dừng!"));
								num = 1;
								break;
							}
							bool flag12 = true;
							if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
							{
								LoadStatusDatagridView(num3, text5 + "Delay check IP...");
								MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
							}
							if (!setting_general.GetValueBool("ckbKhongCheckIP"))
							{
								text5 = "(IP: " + text.Split(':')[0] + ") ";
								LoadStatusDatagridView(num3, text5 + "Check IP...");
								int num12 = 0;
								while (true)
								{
									if (num12 >= 30)
									{
										goto IL_0acd;
									}
									MCommon.Common.DelayTime(1.0);
									text6 = MCommon.Common.CheckProxy(text, typeProxy);
									if (text6 != "")
									{
										goto IL_0acd;
									}
									if (isStop)
									{
										LoadStatusDatagridView(num3, text5 + Language.GetValue("Đã dừng!"));
										num = 1;
										goto end_IL_0244;
									}
									num12++;
									continue;
								IL_0acd:
									if (text6 == "")
									{
										flag12 = false;
									}
									break;
								}
							}
							if (!flag12)
							{
								XproxyProxy xproxyProxy2 = xproxyProxy;
								xproxyProxy2.dangSuDung--;
								xproxyProxy2 = xproxyProxy;
								xproxyProxy2.daSuDung--;
								continue;
							}
							goto default;
						}
					case 9:
						text = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, num3, "cProxy");
						typeProxy = (text.EndsWith("*1") ? 1 : 0);
						if (text.EndsWith("*0") || text.EndsWith("*1"))
						{
							text = text.Substring(0, text.Length - 2);
						}
						goto default;
					case 10:
						LoadStatusDatagridView(num3, Language.GetValue("Đang lấy TMProxy ..."));
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
									TMProxy tMProxy2 = tMProxy;
									tMProxy2.dangSuDung++;
									tMProxy2 = tMProxy;
									tMProxy2.daSuDung++;
									break;
								}
								bool flag5 = true;
							}
							if (isStop)
							{
								LoadStatusDatagridView(num3, text5 + Language.GetValue("Đã dừng!"));
								num = 1;
								break;
							}
							bool flag6 = true;
							if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
							{
								LoadStatusDatagridView(num3, text5 + "Delay check IP...");
								MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
							}
							if (!setting_general.GetValueBool("ckbKhongCheckIP"))
							{
								text5 = "(IP: " + text.Split(':')[0] + ") ";
								LoadStatusDatagridView(num3, text5 + "Check IP...");
								text6 = MCommon.Common.CheckProxy(text, 0);
								if (text6 == "")
								{
									flag6 = false;
								}
							}
							if (!flag6)
							{
								TMProxy tMProxy2 = tMProxy;
								tMProxy2.dangSuDung--;
								tMProxy2 = tMProxy;
								tMProxy2.daSuDung--;
								continue;
							}
							goto default;
						}
					case 11:
						SetStatusAccount(num3, Language.GetValue("Đang lấy Proxyv6..."));
						lock (lock_StartProxy)
						{
							while (!isStop)
							{
								proxyWeb = null;
								while (!isStop)
								{
									foreach (ProxyWeb item4 in listProxyWeb)
									{
										if (proxyWeb == null || item4.daSuDung < proxyWeb.daSuDung)
										{
											proxyWeb = item4;
										}
									}
									if (proxyWeb.daSuDung != proxyWeb.limit_theads_use)
									{
										break;
									}
								}
								if (isStop)
								{
									break;
								}
								if (proxyWeb.daSuDung > 0 || proxyWeb.ChangeProxy())
								{
									text = proxyWeb.proxy;
									typeProxy = proxyWeb.typeProxy;
									ProxyWeb proxyWeb2 = proxyWeb;
									proxyWeb2.dangSuDung++;
									proxyWeb2 = proxyWeb;
									proxyWeb2.daSuDung++;
									break;
								}
								bool flag3 = true;
							}
							if (isStop)
							{
								SetStatusAccount(num3, text5 + Language.GetValue("Đã dừng!"));
								num = 1;
								break;
							}
							bool flag4 = true;
							if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
							{
								SetStatusAccount(num3, text5 + "Delay check IP...");
								MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
							}
							if (!setting_general.GetValueBool("ckbKhongCheckIP"))
							{
								text5 = "(IP: " + text.Split(':')[0] + ") ";
								SetStatusAccount(num3, text5 + "Check IP...");
								int num4 = 0;
								while (true)
								{
									if (num4 >= 30)
									{
										goto IL_1461;
									}
									MCommon.Common.DelayTime(1.0);
									text6 = MCommon.Common.CheckProxy(text, typeProxy);
									if (text6 != "")
									{
										goto IL_1461;
									}
									if (isStop)
									{
										SetStatusAccount(num3, text5 + Language.GetValue("Đã dừng!"));
										num = 1;
										goto end_IL_0244;
									}
									num4++;
									continue;
								IL_1461:
									if (text6 == "")
									{
										flag4 = false;
									}
									break;
								}
							}
							if (!flag4)
							{
								ProxyWeb proxyWeb2 = proxyWeb;
								proxyWeb2.dangSuDung--;
								proxyWeb2 = proxyWeb;
								proxyWeb2.daSuDung--;
								continue;
							}
							goto default;
						}
					case 12:
						LoadStatusDatagridView(num3, Language.GetValue("Đang lấy Proxy ShopLike ..."));
						lock (lock_StartProxy)
						{
							while (!isStop)
							{
								shopLike = null;
								while (!isStop)
								{
									foreach (ShopLike item5 in listShopLike)
									{
										if (shopLike == null || item5.daSuDung < shopLike.daSuDung)
										{
											shopLike = item5;
										}
									}
									if (shopLike.daSuDung != shopLike.limit_theads_use)
									{
										break;
									}
								}
								if (isStop)
								{
									break;
								}
								if (shopLike.daSuDung > 0 || shopLike.ChangeProxy())
								{
									text = shopLike.proxy;
									if (text == "")
									{
										text = shopLike.GetProxy();
									}
									ShopLike shopLike2 = shopLike;
									shopLike2.dangSuDung++;
									shopLike2 = shopLike;
									shopLike2.daSuDung++;
									break;
								}
								bool flag = true;
							}
							if (isStop)
							{
								LoadStatusDatagridView(num3, text5 + Language.GetValue("Đã dừng!"));
								num = 1;
								break;
							}
							bool flag2 = true;
							if (setting_general.GetValueInt("nudDelayCheckIP") > 0)
							{
								LoadStatusDatagridView(num3, text5 + "Delay check IP...");
								MCommon.Common.DelayTime(setting_general.GetValueInt("nudDelayCheckIP"));
							}
							if (!setting_general.GetValueBool("ckbKhongCheckIP"))
							{
								text5 = "(IP: " + text.Split(':')[0] + ") ";
								LoadStatusDatagridView(num3, text5 + "Check IP...");
								text6 = MCommon.Common.CheckProxy(text, 0);
								if (text6 == "")
								{
									flag2 = false;
								}
							}
							if (!flag2)
							{
								ShopLike shopLike2 = shopLike;
								shopLike2.dangSuDung--;
								shopLike2 = shopLike;
								shopLike2.daSuDung--;
								continue;
							}
							goto default;
						}
					default:
						{
							if (!setting_general.GetValueBool("ckbKhongCheckIP"))
							{
								if (setting_general.GetValueInt("ip_iTypeChangeIp") != 7 && setting_general.GetValueInt("ip_iTypeChangeIp") != 8 && setting_general.GetValueInt("ip_iTypeChangeIp") != 10)
								{
									if (text != "")
									{
										text5 = "(IP: " + text.Split(':')[0] + ") ";
									}
									LoadStatusDatagridView(num3, text5 + "Check IP...");
									bool flag9 = false;
									for (int i = 0; i < 30; i++)
									{
										MCommon.Common.DelayTime(1.0);
										text6 = MCommon.Common.CheckProxy(text, typeProxy);
										if (text6 != "")
										{
											flag9 = true;
											break;
										}
									}
									if (!flag9)
									{
										LoadStatusDatagridView(num3, text5 + Language.GetValue("Không thể kết nối proxy!"));
										num = 1;
										break;
									}
								}
								text5 = "(IP: " + text6 + ") ";
							}
							if (text4 == "" || text.Split(':').Length == 4)
							{
								text4 = Base.useragentDefault;
							}
							try
							{
								SetStatusAccount(num3, text5 + Language.GetValue("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
								string app = "data:,";
								Point pointFromIndexPosition = MCommon.Common.GetPointFromIndexPosition(indexPos, setting_general.GetValueInt("cbbColumnChrome", 3), setting_general.GetValueInt("cbbRowChrome", 2));
								Point sizeChrome = MCommon.Common.GetSizeChrome(setting_general.GetValueInt("cbbColumnChrome", 3), setting_general.GetValueInt("cbbRowChrome", 2));
								if (text4 == "")
								{
									text4 = Base.useragentDefault;
								}
								string text7 = "";
								if (text2 != "")
								{
									text7 = ConfigHelper.GetPathProfile() + "\\" + text2;
									if (!settings.GetValueBool("ckbCreateProfile") && !Directory.Exists(text7))
									{
										text7 = "";
									}
								}
								Chrome chrome2 = new Chrome();
								chrome2.IndexChrome = num3;
								chrome2.DisableImage = !Convert.ToBoolean((setting_general.GetValue("ckbShowImageInteract") == "") ? "false" : setting_general.GetValue("ckbShowImageInteract"));
								chrome2.UserAgent = text4;
								chrome2.ProfilePath = text7;
								chrome2.Size = sizeChrome;
								chrome2.Position = pointFromIndexPosition;
								chrome2.TimeWaitForSearchingElement = 3;
								chrome2.TimeWaitForLoadingPage = 120;
								chrome2.Proxy = text;
								chrome2.TypeProxy = typeProxy;
								chrome2.DisableSound = true;
								chrome2.App = app;
								chrome2.IsUsePortable = setting_general.GetValueBool("ckbUsePortable");
								chrome2.PathToPortableZip = setting_general.GetValue("txtPathToPortableZip");
								chrome = chrome2;
								if (setting_general.GetValue("sizeChrome").Contains("x"))
								{
									chrome.IsUseEmulator = true;
									string text8 = setting_general.GetValue("sizeChrome").Substring(0, setting_general.GetValue("sizeChrome").LastIndexOf('x'));
									int pixelRatio = Convert.ToInt32(setting_general.GetValue("sizeChrome").Split('x')[2]);
									chrome.Size_Emulator = new Point(Convert.ToInt32(text8.Split('x')[0]), Convert.ToInt32(text8.Split('x')[1]));
									if (text4 == "")
									{
										chrome.UserAgent = Base.useragentDefault;
									}
									chrome.PixelRatio = pixelRatio;
								}
								if (isStop)
								{
									SetStatusAccount(num3, text5 + Language.GetValue("Đã dừng!"));
									num = 1;
									break;
								}
								if (setting_general.GetValueInt("typeBrowser") != 0)
								{
									chrome.LinkToOtherBrowser = setting_general.GetValue("txtLinkToOtherBrowser");
								}
								int num5 = 0;
								while (true)
								{
									if (!chrome.Open())
									{
										SetStatusAccount(num3, text5 + Language.GetValue("Lỗi mở trình duyệt!"));
										num = 1;
										break;
									}
									chrome.ExecuteScript("document.title=\"proxyauth=" + text + "\"");
									chrome.DelayTime(2.0);
									if (!setting_general.GetValueBool("ckbKhongCheckIP") && text.Split(':').Length > 1)
									{
										chrome.GotoURL("https://api.myip.com/");
										chrome.DelayTime(1.0);
										string pageSource = chrome.GetPageSource();
										if (!pageSource.Contains("ip"))
										{
											chrome.Close();
											num5++;
											if (num5 < 3)
											{
												continue;
											}
											SetStatusAccount(num3, text5 + Language.GetValue("Lỗi kết nối proxy!"));
											num = 1;
											break;
										}
									}
									if (!chrome.GetProcess())
									{
										SetStatusAccount(num3, text5 + Language.GetValue("Không check đươ\u0323c chrome!"));
										num = 1;
										break;
									}
									SetStatusAccount(num3, text5 + Language.GetValue("Đang đăng nhâ\u0323p..."));
									bool flag10 = false;
									string text9 = "https://www.facebook.com/";
									if (settings.GetValueInt("typeBrowserLogin") == 0)
									{
										text9 = "https://m.facebook.com/";
									}
									if (!(text7.Trim() != ""))
									{
										goto IL_2618;
									}
									num2 = CommonChrome.CheckLiveCookie(chrome, text9);
									if (!chrome.GetURL().Contains("facebook.com/confirm"))
									{
										switch (num2)
										{
											case 1:
												flag10 = true;
												goto IL_2618;
											case -2:
												chrome.Status = StatusChromeAccount.ChromeClosed;
												goto end_IL_1c0e;
											case -3:
												chrome.Status = StatusChromeAccount.NoInternet;
												goto end_IL_1c0e;
											case 2:
												break;
											default:
												goto IL_2618;
										}
										chrome.Status = StatusChromeAccount.Checkpoint;
									}
									goto IL_2da9;
								IL_2da9:
									SetStatusAccount(num3, text5 + Language.GetValue("Đăng nhâ\u0323p tha\u0300nh công!"));
									if (chrome.GetURL().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway/nt/"))
									{
										chrome.ClickWithAction(4, "span");
										chrome.DelayTime(2.0);
									}
									if (chrome.GetURL().Contains("gettingstarted"))
									{
										for (int j = 0; j < 5; j++)
										{
											if (chrome.CheckExistElement("#nux-nav-button", 3.0) != 1)
											{
												break;
											}
											chrome.Click(1, "nux-nav-button");
											chrome.DelayTime(2.0);
										}
									}
									if (settings.GetValueBool("change_ckbDoiNgonNgu"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đô\u0309i ngôn ngư\u0303..."));
										num2 = ChangeLanguage(chrome, settings.GetValue("change_cbbNgonNgu"));
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("change_ckbVerify"))
									{
										chrome.GotoURL("https://m.facebook.com");
										chrome.DelayTime(1.0);
										if (chrome.GetURL().Contains("facebook.com/confirm"))
										{
											int valueInt = settings.GetValueInt("change_typeMail");
											num2 = VerifyAccount(chrome, num3, text5, statusDataGridView, valueInt);
											switch (num2)
											{
												case 0:
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Verify fail!"));
													WriteFile(num3, 2);
													num = 1;
													goto end_IL_1c0e;
												case 1:
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Verify Success..."));
													goto default;
												case 2:
													num = 4;
													goto end_IL_1c0e;
												case 3:
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Hết mail!"));
													isStop = true;
													num = 1;
													goto end_IL_1c0e;
												case 5:
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Fb không gư\u0309i otp vê\u0300 mail!"));
													num = 1;
													goto end_IL_1c0e;
												default:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															goto end_IL_1c0e;
														case -2:
															num = 2;
															goto end_IL_1c0e;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															goto end_IL_1c0e;
														default:
															chrome.GotoURL("https://m.facebook.com");
															chrome.DelayRandom(2, 3);
															if (chrome.CheckExistElement("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1)
															{
																chrome.ExecuteScript("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
																chrome.DelayTime(3.0);
																if (chrome.CheckExistElement("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1)
																{
																	chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
																	chrome.DelayTime(3.0);
																}
															}
															break;
													}
													break;
											}
										}
									}
									if (settings.GetValueBool("change_ckbAddPhone"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Thêm sô\u0301 điê\u0323n thoa\u0323i..."));
										num2 = AddPhone(chrome, settings.GetValue("change_txtPhone"), rd);
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("change_ckbDoiAvatar"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đô\u0309i avatar..."));
										string text10 = "";
										lock (lstPathFolderAvatarTemp)
										{
											if (lstPathFolderAvatarTemp.Count == 0)
											{
												lstPathFolderAvatarTemp = CloneList(lstPathFolderAvatar);
											}
											if (!settings.GetValueBool("change_ckbAvatarThuTu"))
											{
												text10 = lstPathFolderAvatarTemp[rd.Next(rd.Next(0, lstPathFolderAvatarTemp.Count))];
												lstPathFolderAvatarTemp.Remove(text10);
											}
											else
											{
												text10 = lstPathFolderAvatarTemp[num3];
											}
										}
										num2 = UpAvatar(chrome, text10, rd);
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
											case 1:
												CommonSQL.UpdateFieldToAccount(statusDataGridView, "avatar", "Co\u0301");
												if (settings.GetValueBool("ckbAutoDeleteFile") && File.Exists(text10))
												{
													File.Delete(text10);
												}
												break;
										}
									}
									if (settings.GetValueBool("change_ckbDoiAnhBia"))
									{
										num2 = 0;
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đô\u0309i a\u0309nh bi\u0300a..."));
										string text11 = "";
										if (settings.GetValueInt("change_typeUpCover") == 0)
										{
											lock (lstPathFolderCoverTemp)
											{
												if (lstPathFolderCoverTemp.Count == 0)
												{
													lstPathFolderCoverTemp = CloneList(lstPathFolderCover);
												}
												if (!settings.GetValueBool("change_ckbCoverThuTu"))
												{
													text11 = lstPathFolderCoverTemp[rd.Next(0, lstPathFolderCoverTemp.Count)];
													lstPathFolderCoverTemp.Remove(text11);
												}
												else
												{
													text11 = lstPathFolderCoverTemp[num3];
												}
											}
											num2 = UpCover(chrome, text11, rd);
										}
										else
										{
											num2 = UpCoverNgheThuat(chrome, rd);
										}
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
											case 1:
												if (settings.GetValueBool("ckbAutoDeleteFile") && text11 != "" && File.Exists(text11))
												{
													File.Delete(text11);
												}
												break;
										}
									}
									if (settings.GetValueBool("change_ckbThemMoTa"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Câ\u0323p nhâ\u0323t tiê\u0309u sư\u0309..."));
										string tieuSu = "";
										lock (lstPathFileTieuSuTemp)
										{
											if (lstPathFileTieuSuTemp.Count == 0)
											{
												lstPathFileTieuSuTemp = CloneList(lstPathFileTieuSu);
											}
											string text12 = lstPathFileTieuSuTemp[rd.Next(0, lstPathFileTieuSuTemp.Count)];
											lstPathFileTieuSuTemp.Remove(text12);
											tieuSu = File.ReadAllText(text12);
										}
										num2 = ChangeTieuSu(chrome, tieuSu);
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("change_ckbCapNhatThongTin"))
									{
										num2 = 0;
										string text13 = "";
										lock (lstNoiLamViecTemp)
										{
											if (lstNoiLamViecTemp.Count == 0)
											{
												lstNoiLamViecTemp = MCommon.Common.CloneList(lstNoiLamViec);
											}
											if (lstNoiLamViecTemp.Count > 0)
											{
												text13 = lstNoiLamViecTemp[rd.Next(0, lstNoiLamViecTemp.Count)];
												lstNoiLamViecTemp.Remove(text13);
											}
										}
										if (text13 != "")
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Cập nhật nơi làm việc..."));
											num2 = ChangeWork(chrome, text13);
											switch (num2)
											{
												case -2:
													num = 2;
													goto end_IL_1c0e;
												case 0:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															break;
														case -2:
															num = 2;
															break;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															break;
													}
													goto end_IL_1c0e;
											}
										}
										string text14 = "";
										lock (lstQueQuanTemp)
										{
											if (lstQueQuanTemp.Count == 0)
											{
												lstQueQuanTemp = MCommon.Common.CloneList(lstQueQuan);
											}
											if (lstQueQuanTemp.Count > 0)
											{
												text14 = lstQueQuanTemp[rd.Next(0, lstQueQuanTemp.Count)];
												lstQueQuanTemp.Remove(text14);
											}
										}
										if (text14 != "")
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Cập nhật quê qua\u0301n..."));
											num2 = ChangeHomeTown(chrome, text14);
											switch (num2)
											{
												case -2:
													num = 2;
													goto end_IL_1c0e;
												case 0:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															break;
														case -2:
															num = 2;
															break;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															break;
													}
													goto end_IL_1c0e;
											}
										}
										string text15 = "";
										lock (lstThanhPhoTemp)
										{
											if (lstThanhPhoTemp.Count == 0)
											{
												lstThanhPhoTemp = MCommon.Common.CloneList(lstThanhPho);
											}
											if (lstThanhPhoTemp.Count > 0)
											{
												text15 = lstThanhPhoTemp[rd.Next(0, lstThanhPhoTemp.Count)];
												lstThanhPhoTemp.Remove(text15);
											}
										}
										if (text15 != "")
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Cập nhật thành phố..."));
											num2 = ChangeCity(chrome, text15);
											switch (num2)
											{
												case -2:
													num = 2;
													goto end_IL_1c0e;
												case 0:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															break;
														case -2:
															num = 2;
															break;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															break;
													}
													goto end_IL_1c0e;
											}
										}
										string text16 = "";
										lock (lstTruongDHTemp)
										{
											if (lstTruongDHTemp.Count == 0)
											{
												lstTruongDHTemp = MCommon.Common.CloneList(lstTruongDH);
											}
											if (lstTruongDHTemp.Count > 0)
											{
												text16 = lstTruongDHTemp[rd.Next(0, lstTruongDHTemp.Count)];
												lstTruongDHTemp.Remove(text16);
											}
										}
										if (text16 != "")
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Cập nhật trường ĐH..."));
											num2 = ChangeDaiHoc(chrome, text16);
											switch (num2)
											{
												case -2:
													num = 2;
													goto end_IL_1c0e;
												case 0:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															break;
														case -2:
															num = 2;
															break;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															break;
													}
													goto end_IL_1c0e;
											}
										}
										string text17 = "";
										lock (lstTruongTHPTTemp)
										{
											if (lstTruongTHPTTemp.Count == 0)
											{
												lstTruongTHPTTemp = MCommon.Common.CloneList(lstTruongTHPT);
											}
											if (lstTruongTHPTTemp.Count > 0)
											{
												text17 = lstTruongTHPTTemp[rd.Next(0, lstTruongTHPTTemp.Count)];
												lstTruongTHPTTemp.Remove(text17);
											}
										}
										if (text17 != "")
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Cập nhật trường THPT..."));
											num2 = ChangePTTH(chrome, text17);
											switch (num2)
											{
												case -2:
													num = 2;
													goto end_IL_1c0e;
												case 0:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															break;
														case -2:
															num = 2;
															break;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															break;
													}
													goto end_IL_1c0e;
											}
										}
									}
									if (settings.GetValueBool("change_ckbGioiTinh"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đổi giới tính") + "...");
										int valueInt2 = settings.GetValueInt("change_typeGioiTinh");
										num2 = ChangeGender(chrome, valueInt2, statusDataGridView);
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("change_ckbDoiNgaySinh"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đổi ngày sinh..."));
										int num6 = settings.GetValueInt("change_nudNgayFrom");
										int num7 = settings.GetValueInt("change_nudNgayTo");
										int valueInt3 = settings.GetValueInt("change_nudThangFrom");
										int valueInt4 = settings.GetValueInt("change_nudThangTo");
										int valueInt5 = settings.GetValueInt("change_nudNamFrom");
										int valueInt6 = settings.GetValueInt("change_nudNamTo");
										if (num6 == 31)
										{
											num6 = 30;
										}
										if (num7 == 31)
										{
											num7 = 30;
										}
										int num8 = rd.Next(num6, num7 + 1);
										int num9 = rd.Next(valueInt3, valueInt4 + 1);
										int num10 = rd.Next(valueInt5, valueInt6 + 1);
										if (num9 == 2 && num8 > 28)
										{
											num8 = 28;
										}
										num2 = ChangeNgaySinh(chrome, num8, num9, num10);
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														break;
													case -2:
														num = 2;
														break;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														break;
												}
												goto end_IL_1c0e;
											case 1:
												{
													string arg = ((num9 < 10) ? ("0" + num9) : (num9.ToString() ?? ""));
													string arg2 = ((num8 < 10) ? ("0" + num8) : (num8.ToString() ?? ""));
													CommonSQL.UpdateFieldToAccount(statusDataGridView, "birthday", $"{arg}/{arg2}/{num10}");
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cBirthday", $"{arg}/{arg2}/{num10}");
													break;
												}
										}
									}
									if (settings.GetValueBool("change_ckbDoiTen"))
									{
										while (true)
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đổi tên..."));
											string text18 = "";
											string text19 = "";
											string text20 = "";
											text18 = lstHo[rd.Next(0, lstHo.Count)];
											if (lstTenDem.Count > 0)
											{
												text19 = lstTenDem[rd.Next(0, lstTenDem.Count)];
											}
											text20 = lstTen[rd.Next(0, lstTen.Count)];
											string hoTen = (text18 + " " + text19 + " " + text20).Replace("  ", " ");
											num2 = ChangeName(chrome, hoTen, text3);
											switch (num2)
											{
												case 2:
													continue;
												case -2:
													num = 2;
													goto end_IL_1c0e;
												case 0:
													switch (CommonChrome.CheckStatusChrome(chrome))
													{
														case -1:
															num = 3;
															break;
														case -2:
															num = 2;
															break;
														case -3:
															num = 1;
															LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
															break;
													}
													goto end_IL_1c0e;
											}
											break;
										}
									}
									if (settings.GetValueBool("change_ckbDoiPass"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đổi mật khẩu..."));
										string text21 = "";
										text21 = ((settings.GetValueInt("change_typeDoiPass") != 0) ? MCommon.Common.CreateRandomString(15, rd) : lstPassword[rd.Next(0, lstPassword.Count)]);
										num2 = ((!settings.GetValueBool("change_ckbDoiPassUseLinkHacked")) ? ChangePass(chrome, text3, text21) : ChangePassUseLinkHacked(chrome, text3, text21));
										switch (num2)
										{
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case 0:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đô\u0309i pass thâ\u0301t ba\u0323i..."));
												WriteFile(num3, 1);
												num = 1;
												goto end_IL_1c0e;
											case 1:
												CommonSQL.UpdateFieldToAccount(statusDataGridView, "pass", text21);
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cPassword", text21);
												text3 = text21;
												break;
											case 2:
												num = 4;
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("change_ckb2fa"))
									{
										if (settings.GetValueInt("change_type2fa") == 0)
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Bâ\u0323t 2fa..."));
											statusDataGridView3 = Create2FA(chrome, text3);
											if (statusDataGridView3.StartsWith("1|"))
											{
												statusDataGridView3 = statusDataGridView3.Split('|')[1];
												CommonSQL.UpdateFieldToAccount(statusDataGridView, "fa2", statusDataGridView3);
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cFa2", statusDataGridView3);
											}
										}
										else
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Tă\u0301t 2fa..."));
											if (Remove2FA(chrome, text3))
											{
												CommonSQL.UpdateFieldToAccount(statusDataGridView, "fa2", "");
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cFa2", "");
											}
										}
										switch (CommonChrome.CheckStatusChrome(chrome))
										{
											case -1:
												num = 3;
												goto end_IL_1c0e;
											case -2:
												num = 2;
												goto end_IL_1c0e;
											case -3:
												num = 1;
												LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("ckbAddMail"))
									{
										num2 = (settings.GetValueBool("ckbAddMailLinkHacked") ? ChangeMailHacked(chrome, text3, num3, text5, statusDataGridView) : ChangeMail(chrome, text3, num3, text5, statusDataGridView));
										switch (num2)
										{
											case 0:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Lỗi Add mail!"));
												WriteFile(num3, 2);
												goto default;
											case 1:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Thêm mail tha\u0300nh công..."));
												goto default;
											case 2:
												num = 4;
												goto end_IL_1c0e;
											case 3:
												if (settings.GetValueInt("themMail") == 1)
												{
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Hết mail!"));
												}
												else
												{
													DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Không lấy được Temp-mail!"));
												}
												isStop = true;
												goto default;
											case 4:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Fb bắt nhập pass!"));
												goto default;
											case 5:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Fb không gư\u0309i otp vê\u0300 mail!"));
												goto default;
											default:
												if (num2 != 1 && settings.GetValueBool("ckbCloseChrome"))
												{
													num = 1;
													goto end_IL_0244;
												}
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														goto end_IL_1c0e;
													case -2:
														num = 2;
														goto end_IL_1c0e;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														goto end_IL_1c0e;
												}
												break;
										}
									}
									if (settings.GetValueBool("ckbAnMailAll") && !settings.GetValueBool("ckbAddMail"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đang â\u0309n mail..."));
										chrome.GotoURL("https://m.facebook.com/settings/email/");
										chrome.DelayTime(3.0);
										int num11 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('[data-sigil=\"dialog-link\"]').length").ToString());
										for (int k = 0; k < num11; k++)
										{
											if (!Convert.ToBoolean(chrome.ExecuteScript("return document.querySelectorAll('[data-sigil=\"dialog-link\"]')[" + k + "].getAttribute('data-store').includes('sel=286958161406148')").ToString()))
											{
												chrome.Click(4, "[data-sigil=\"dialog-link\"]", k);
												chrome.DelayTime(1.0);
												if (chrome.CheckExistElement("[data-sigil=\"audience-options-list\"]", 15.0) == 1)
												{
													chrome.Click(4, "[data-sigil=\"audience-options-list\"]>label:nth-child(3)");
													chrome.DelayTime(1.0);
												}
											}
										}
										chrome.DelayTime(1.0);
									}
									if (settings.GetValueBool("ckbXoaMailCu2") && !settings.GetValueBool("ckbAddMail"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đang xo\u0301a mail cu\u0303..."));
										chrome.DelayTime(2.0);
										switch (RemoveMail(chrome, text3))
										{
											case 0:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Xóa mail thất bại!"));
												break;
											case 1:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Xóa mail thành công!"));
												break;
											case 2:
												num = 4;
												goto end_IL_1c0e;
										}
									}
									if (settings.GetValueBool("ckbXoaSdt"))
									{
										num2 = RemovePhone(chrome, text3);
										switch (num2)
										{
											case 0:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Lỗi xóa SĐT!"));
												WriteFile(num3, 2);
												CommonSQL.UpdateFieldToAccount(statusDataGridView, "ghiChu", "Lỗi xóa sđt!");
												num = 1;
												goto end_IL_1c0e;
											case 1:
												DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Xóa SĐT tha\u0300nh công..."));
												goto default;
											case 2:
												num = 4;
												goto end_IL_1c0e;
											default:
												switch (CommonChrome.CheckStatusChrome(chrome))
												{
													case -1:
														num = 3;
														goto end_IL_1c0e;
													case -2:
														num = 2;
														goto end_IL_1c0e;
													case -3:
														num = 1;
														LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
														goto end_IL_1c0e;
												}
												break;
										}
									}
									if (settings.GetValueBool("change_ckbXoaThietBiTinCay"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đang xóa thiết bị tin cậy..."));
										chrome.GotoURL("https://m.facebook.com/settings/security/two_factor/devices/");
										chrome.DelayThaoTacNho();
										if (chrome.CheckExistElement("[data-sigil=\"removable-area marea\"] button", 10.0) == 1)
										{
											chrome.ExecuteScript("var x=document.querySelectorAll('[data-sigil=\"touchable removable-area-button\"]').length;for(var i=1;i<=x;i++){document.querySelectorAll('[data-sigil=\"touchable removable-area-button\"]')[x-i].click()}");
											chrome.DelayTime(1.0);
										}
									}
									if (settings.GetValueBool("ckbLogOut"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đang đăng xuâ\u0301t ca\u0301c thiê\u0301t bi\u0323..."));
										if (Logout(chrome))
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Đa\u0303 đăng xuâ\u0301t ca\u0301c thiê\u0301t bi\u0323!"));
										}
										else
										{
											DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Lô\u0303i đăng xuâ\u0301t ca\u0301c thiê\u0301t bi\u0323!"));
										}
										switch (CommonChrome.CheckStatusChrome(chrome))
										{
											case -1:
												num = 3;
												break;
											case -2:
												num = 2;
												break;
											case -3:
												num = 1;
												LoadStatusDatagridView(num3, text5 + "Disconnect Internet!");
												break;
										}
									}
									break;
								IL_2618:
									if (!flag10)
									{
										string text22 = "";
										switch (settings.GetValueInt("typeLogin"))
										{
											case 0:
												if (text2.Trim() == "" || text3.Trim() == "")
												{
													if (text2.Trim() == "")
													{
														SetStatusAccount(num3, text5 + Language.GetValue("Không ti\u0300m thâ\u0301y UID!"));
													}
													else if (text3.Trim() == "")
													{
														SetStatusAccount(num3, text5 + Language.GetValue("Không ti\u0300m thâ\u0301y Pass!"));
													}
													num = 1;
													goto end_IL_0244;
												}
												SetStatusAccount(num3, text5 + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
												text22 = ((!settings.GetValueBool("change_ckbGiaiCheckPoint")) ? CommonChrome.LoginFacebookUsingUidPassNew(chrome, text2, text3, statusDataGridView3, text9, setting_general.GetValueInt("tocDoGoVanBan"), setting_general.GetValueBool("ckbDontSaveBrowser")) : CommonChrome.LoginFacebookUsingUidPassNew(chrome, text2, text3, statusDataGridView3, "https://www.facebook.com", setting_general.GetValueInt("tocDoGoVanBan"), setting_general.GetValueBool("ckbDontSaveBrowser")));
												try
												{
													num2 = Convert.ToInt32(text22);
												}
												catch
												{
													num2 = -1;
												}
												goto default;
											case 1:
												if (statusDataGridView2.Trim() == "")
												{
													SetStatusAccount(num3, text5 + Language.GetValue("Không ti\u0300m thâ\u0301y Cookie!"));
													num = 1;
													goto end_IL_0244;
												}
												SetStatusAccount(num3, text5 + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng cookie..."));
												num2 = Convert.ToInt32(CommonChrome.LoginFacebookUsingCookie(chrome, statusDataGridView2, text9));
												goto default;
											default:
												if (chrome.GetURL().Contains("facebook.com/confirm"))
												{
													break;
												}
												if (settings.GetValueInt("typeLogin") != 1)
												{
													switch (num2)
													{
														case -2:
															chrome.Status = StatusChromeAccount.ChromeClosed;
															goto default;
														case -1:
															SetStatusAccount(num3, text5 + text22);
															goto default;
														case 0:
															SetStatusAccount(num3, text5 + Language.GetValue("Đăng nhập thất bại!"));
															goto default;
														case 1:
															flag10 = true;
															goto default;
														case 2:
															chrome.Status = StatusChromeAccount.Checkpoint;
															SetInfoAccount(statusDataGridView, num3, Language.GetValue("Checkpoint"));
															break;
														case 3:
															SetStatusAccount(num3, text5 + Language.GetValue("Không có 2fa!"));
															goto default;
														case 4:
															SetStatusAccount(num3, text5 + Language.GetValue("Tài khoản không đúng!"));
															goto default;
														case 5:
															SetStatusAccount(num3, text5 + Language.GetValue("Mật khẩu không đúng!"));
															SetInfoAccount(statusDataGridView, num3, "Changed pass");
															goto default;
														case 6:
															SetStatusAccount(num3, text5 + Language.GetValue("Mã 2fa không đúng!"));
															goto default;
														case 7:
															chrome.Status = StatusChromeAccount.NoInternet;
															goto default;
														default:
															if (!flag10)
															{
																ScreenCaptureError(chrome, text2, 1);
																num = 1;
																goto end_IL_0244;
															}
															break;
													}
													break;
												}
												switch (num2)
												{
													case 1:
														flag10 = true;
														goto default;
													case -2:
														chrome.Status = StatusChromeAccount.ChromeClosed;
														goto end_IL_1c0e;
													case -3:
														chrome.Status = StatusChromeAccount.NoInternet;
														goto end_IL_1c0e;
													case 2:
														chrome.Status = StatusChromeAccount.Checkpoint;
														SetInfoAccount(statusDataGridView, num3, Language.GetValue("Checkpoint"));
														break;
													case 3:
														if (settings.GetValueBool("change_ckbVerify"))
														{
															flag10 = true;
														}
														goto default;
													default:
														if (flag10)
														{
															break;
														}
														SetStatusAccount(num3, text5 + Language.GetValue("Đăng nhâ\u0323p thâ\u0301t ba\u0323i!"));
														ScreenCaptureError(chrome, text2, 1);
														num = 1;
														goto end_IL_1c0e;
												}
												break;
										}
									}
									goto IL_2da9;
								}
							end_IL_1c0e:;
							}
							catch (Exception ex)
							{
								DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
								MCommon.Common.ExportError(chrome, ex);
							}
							break;
						}
					end_IL_0244:
						break;
				}
				break;
			}
			switch (num)
			{
				case 1:
					{
						StatusChromeAccount status = chrome.Status;
						StatusChromeAccount statusChromeAccount = status;
						if (statusChromeAccount == StatusChromeAccount.ChromeClosed || statusChromeAccount == StatusChromeAccount.Checkpoint || statusChromeAccount == StatusChromeAccount.NoInternet)
						{
							DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + GetContentStatusChrome.GetContent(chrome.Status));
						}
						break;
					}
				case 2:
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Không ti\u0300m thâ\u0301y chrome!"));
					break;
				case 3:
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + "Checkpoint!");
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cInfo", "Die");
					CommonSQL.UpdateFieldToAccount(statusDataGridView, "info", "Die");
					WriteFile(num3, 4);
					break;
				case 4:
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Sai pass!"));
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cInfo", "Changed pass");
					CommonSQL.UpdateFieldToAccount(statusDataGridView, "info", "Changed pass");
					WriteFile(num3, 3);
					break;
				default:
					if (CommonChrome.IsCheckpoint(chrome))
					{
						DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + "Checkpoint!");
						DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cInfo", "Die");
						CommonSQL.UpdateFieldToAccount(statusDataGridView, "info", "Die");
						WriteFile(num3, 4);
					}
					else if (!settings.GetValueBool("ckbAddMail") || num2 == 1)
					{
						DatagridviewHelper.SetStatusDataGridView(dtgvAcc, num3, "cStatus", text5 + Language.GetValue("Cập nhật thông tin xong!"));
					}
					break;
			}
			try
			{
				chrome.Close();
			}
			catch
			{
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
					case 11:
						proxyWeb?.DecrementDangSuDung();
						break;
					case 12:
						shopLike?.DecrementDangSuDung();
						break;
					case 9:
						break;
				}
			}
		}

		private int ChangeMailHacked(Chrome chrome, string password, int indexRow, string statusProxy, string id)
		{
			//Discarded unreachable code: IL_0287, IL_029c, IL_0e3c, IL_0e51, IL_1148, IL_11c4
			int result = 0;
			try
			{
				string text = "";
				string text2 = "";
				string imap = "";
				string text3 = "";
				string username = "";
				string text4 = "";
				string text5 = "";
				if (settings.GetValueInt("themMail") == 1)
				{
					if (settings.GetValueBool("ckbMailVip"))
					{
						if (lstMailAdd.Count == 0)
						{
							return 3;
						}
						text4 = lstMailAdd[rd.Next(0, lstMailAdd.Count)];
						username = text4.Split('|')[0];
						text2 = text4.Split('|')[1];
						text4 = text4.Split('|', '@')[1];
						text = GeneratorEmail(text4);
					}
					else
					{
						lock (lstMailAdd)
						{
							if (lstMailAdd.Count == 0)
							{
								return 3;
							}
							text3 = lstMailAdd[0];
							lstMailAdd.RemoveAt(0);
						}
						string[] array = text3.Split('|');
						text = array[0];
						text2 = array[1];
						if (array.Length > 2)
						{
							imap = array[2];
						}
						DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + "Check mail...");
						EmailHelper.DeleteMail(text, text2, imap);
					}
				}
				else
				{
					text = GetMailFromTempMail(chrome, "https://temp-mail.org/");
					if (!(text != ""))
					{
						return 3;
					}
					text2 = "";
				}
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang thêm mail..."));
				for (int i = 0; i < 10; i++)
				{
					chrome.GotoURL("https://m.facebook.com/hacked");
					if (CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 2)
					{
						break;
					}
				}
				if (chrome.CheckExistElement("[value=\"someone_accessed\"]", 10.0) == 1)
				{
					chrome.ExecuteScript("document.querySelector('[value=\"someone_accessed\"]').click()");
					chrome.DelayTime(1.0);
					chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('[type=\"submit\"]')");
					chrome.Click(4, "[type=\"submit\"]");
					chrome.DelayTime(1.0);
					if (chrome.CheckExistElement("#checkpointButtonGetStarted-actual-button", 15.0) == 1)
					{
						chrome.Click(1, "checkpointButtonGetStarted-actual-button");
						chrome.DelayTime(3.0);
						if (chrome.CheckExistElement("#checkpointSubmitButton-actual-button", 30.0) == 1)
						{
							chrome.Click(2, "submit[Continue]");
							chrome.DelayTime(1.0);
							int num = chrome.CheckExistElements(15.0, "[name=\"password_old\"]", "[name=\"password_new\"]");
							switch (num)
							{
								case 1:
									text5 = ((!settings.GetValueBool("ckbRandomPassMailHacked")) ? settings.GetValue("txtPassMailHacked") : (MCommon.Common.CreateRandomString(8) + MCommon.Common.CreateRandomNumber(4)));
									chrome.SendKeys(2, "password_old", password);
									chrome.DelayTime(1.0);
									chrome.SendKeys(2, "password_new", text5);
									chrome.DelayTime(1.0);
									chrome.SendKeys(2, "password_confirm", text5);
									chrome.DelayTime(1.0);
									chrome.Click(2, "submit[Continue]");
									CommonSQL.UpdateFieldToAccount(id, "pass", text5);
									DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cPassword", text5);
									break;
								case 2:
									text5 = ((!settings.GetValueBool("ckbRandomPassMailHacked")) ? settings.GetValue("txtPassMailHacked") : (MCommon.Common.CreateRandomString(8) + MCommon.Common.CreateRandomNumber(4)));
									chrome.SendKeys(2, "password_new", text5);
									chrome.DelayTime(1.0);
									chrome.Click(2, "submit[Continue]");
									CommonSQL.UpdateFieldToAccount(id, "pass", text5);
									DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cPassword", text5);
									break;
							}
							if (num != 0 && chrome.CheckExistElement("[name=\"selected[]\"]", 15.0) == 1)
							{
								chrome.ExecuteScript("var x=document.querySelectorAll('[name=\"selected[]\"]');for(i=0;i<x.length;i++){{x[i].click();}}");
								chrome.DelayTime(1.0);
								chrome.Click(2, "submit[Continue]");
								chrome.DelayTime(1.0);
								if (chrome.CheckExistElement("[name=\"new_cp\"]", 15.0) == 1)
								{
									chrome.SendKeys(2, "new_cp", text);
									chrome.DelayTime(1.0);
									chrome.Click(2, "submit[Add]");
									chrome.DelayTime(3.0);
									DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang lâ\u0301y otp..."));
									string text6 = "";
									text6 = (settings.GetValueBool("ckbMailVip") ? EmailHelper.GetOtpFromMail2(3, username, text2, text, 30, "imap.yandex.com") : EmailHelper.GetOtpFromMail(3, text, text2, 30, imap));
									if (text6.Trim() == "")
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Fb không gư\u0309i otp vê\u0300 mail!"));
										lock (k)
										{
											lstMailLoi.Add(text3);
										}
										return 5;
									}
									chrome.SendKeys(2, "code", text6);
									chrome.DelayTime(1.0);
									chrome.Click(2, "submit[Confirm]");
									chrome.DelayTime(3.0);
									for (int j = 0; j < 5; j++)
									{
										if (chrome.CheckExistElement("[name*=\"submit\"]", 5.0) != 1)
										{
											break;
										}
										chrome.Click(4, "[name*=\"submit\"]");
									}
									result = 1;
									CommonSQL.UpdateFieldToAccount(id, "email", text);
									CommonSQL.UpdateFieldToAccount(id, "passmail", text2);
									if (settings.GetValueBool("ckbAnMailMoi"))
									{
										DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang â\u0309n mail..."));
										chrome.GotoURL("https://m.facebook.com/settings/email/");
										chrome.DelayTime(3.0);
										chrome.ExecuteScript("document.querySelector('#root>div:nth-child(1)>div>div>div.acw.apl>div>div:nth-child(1)>div>div>div:nth-child(2)> a').click()");
										chrome.DelayTime(2.0);
										chrome.ExecuteScript("document.getElementsByName('px')[2].click()");
										chrome.DelayTime(1.0);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(ex, "Add Mail");
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Add mail thất bại!"));
			}
			return result;
		}

		public static string GetPhoneOtpmmo(string apikey, int timeOut = 60)
		{
			//Discarded unreachable code: IL_00da, IL_00e7
			RequestHttp requestHttp = new RequestHttp();
			string text = "";
			for (int i = 0; i < timeOut; i++)
			{
				try
				{
					text = requestHttp.RequestGet("https://otpmmo.xyz/textnow/api.php?apikey=" + apikey + "&type=getphone&qty=1");
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			return "";
		}

		public static string GetOtpOtpmmo(string apikey, string sdt, int timeOut = 60)
		{
			//Discarded unreachable code: IL_0193, IL_01a0
			RequestHttp requestHttp = new RequestHttp();
			string text = "";
			string text2 = "";
			for (int i = 0; i < timeOut; i++)
			{
				try
				{
					text = requestHttp.RequestGet("https://otpmmo.xyz/textnow/api.php?apikey=" + apikey + "&type=getotp&sdt=" + sdt);
					if (text != "")
					{
						text = text.Remove(0, 1);
						text = text.Remove(text.Length - 1, 1);
						JObject jObject = JObject.Parse(text);
						text2 = jObject["otp"].ToString();
						if (text2 != "")
						{
							return Regex.Match(text2, "\\d{6}").Value;
						}
					}
				}
				catch
				{
				}
			}
			return "";
		}

		public static string GetPhonePrimeOtp(string apikey, int timeOut = 60)
		{
			//Discarded unreachable code: IL_01c4, IL_01d1
			RequestHttp requestHttp = new RequestHttp();
			string text = "";
			for (int i = 0; i < timeOut; i++)
			{
				try
				{
					text = requestHttp.RequestGet("http://primeotp.me/api.php?apikey=" + apikey + "&action=create-request&serviceId=1&count=1");
					if (text != "")
					{
						JObject jObject = JObject.Parse(text);
						return jObject["results"]["data"][0]["requestId"].ToString() + "|" + jObject["results"]["data"][0]["sdt"].ToString();
					}
				}
				catch
				{
				}
			}
			return "";
		}

		public static string GetOtpPrimeOtp(string apikey, string id_order, int timeOut = 60)
		{
			//Discarded unreachable code: IL_0193, IL_01a0
			RequestHttp requestHttp = new RequestHttp();
			string text = "";
			string text2 = "";
			for (int i = 0; i < timeOut; i++)
			{
				try
				{
					text = requestHttp.RequestGet("http://primeotp.me/api.php?apikey=" + apikey + "&action=data-request&requestId=" + id_order);
					if (text != "")
					{
						JObject jObject = JObject.Parse(text);
						text2 = jObject["data"][0]["otp"].ToString();
						if (text2 != "")
						{
							return Regex.Match(text2, "\\d{6}").Value;
						}
					}
				}
				catch
				{
				}
			}
			return "";
		}

		private int CheckFacebookLogout(Chrome chrome, string uid, string pass, string fa2, bool isSendRequest = false)
		{
			int result = 0;
			CommonChrome.CheckStatusAccount(chrome, isSendRequest);
			switch (chrome.Status)
			{
				case StatusChromeAccount.ChromeClosed:
					result = -2;
					break;
				case StatusChromeAccount.LoginWithUserPass:
				case StatusChromeAccount.LoginWithSelectAccount:
					{
						string text = CommonChrome.LoginFacebookUsingUidPassNew(chrome, uid, pass, fa2, "https://m.facebook.com/", 2);
						result = ((text == "1") ? 1 : 2);
						break;
					}
				case StatusChromeAccount.Checkpoint:
					result = -1;
					break;
				case StatusChromeAccount.NoInternet:
					result = -3;
					break;
			}
			return result;
		}

		public int ChangeGender(Chrome chrome, int type, string id)
		{
			//Discarded unreachable code: IL_02cb, IL_02d8
			bool flag = false;
			try
			{
				int num = chrome.GotoURLIfNotExist("https://m.facebook.com/profile/edit/infotab/section/forms/?section=basic-info");
				if (num == -2)
				{
					return -2;
				}
				if (chrome.CheckExistElement("[data-sigil=\"gender-selector\"]", 30.0) == 1)
				{
					chrome.ScrollSmooth("document.querySelector('[data-sigil=\"gender-selector\"]')");
					chrome.DelayTime(1.0);
					chrome.Click(4, "[data-sigil=\"option touchable\"]", type);
					chrome.DelayTime(1.0);
					chrome.ScrollSmooth("document.querySelector('[name=\"save\"]')");
					chrome.DelayTime(1.0);
					chrome.Click(2, "save");
					chrome.DelayTime(1.0);
					for (int i = 0; i < 30; i++)
					{
						if (chrome.CheckExistElement("#basic-info") == 1)
						{
							break;
						}
						Thread.Sleep(1000);
					}
					string fieldValue = "";
					switch (type)
					{
						case 0:
							fieldValue = "female";
							break;
						case 1:
							fieldValue = "male";
							break;
					}
					CommonSQL.UpdateFieldToAccount(id, "gender", fieldValue);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangePassUseLinkHacked(Chrome chrome, string old_pass, string new_pass)
		{
			//Discarded unreachable code: IL_05f5, IL_0602
			int num = 0;
			try
			{
				if (!chrome.CheckIsLive())
				{
					return -2;
				}
				chrome.GotoURLIfNotExist("https://m.facebook.com/hacked");
				chrome.DelayTime(1.0);
				if (chrome.CheckExistElement("[value=\"someone_accessed\"]", 10.0) == 1)
				{
					chrome.DelayTime(1.0);
					chrome.ExecuteScript("document.querySelector('[value=\"someone_accessed\"]').checked=true");
					chrome.DelayTime(1.0);
					chrome.Click(4, "[type=\"submit\"]");
					chrome.DelayTime(1.0);
					if (chrome.CheckExistElement("#checkpointButtonGetStarted-actual-button", 10.0) == 1)
					{
						chrome.DelayTime(1.0);
						chrome.Click(4, "#checkpointButtonGetStarted-actual-button");
						chrome.DelayTime(3.0);
						if (chrome.CheckExistElement("#checkpointSubmitButton-actual-button", 60.0) == 1)
						{
							chrome.DelayTime(1.0);
							int num2 = 0;
							for (int i = 0; i < 10; i++)
							{
								if (chrome.CheckExistElement("[name=\"password_new\"]") == 1)
								{
									if (num2 > 0)
									{
										num = 0;
										return num;
									}
									chrome.DelayTime(1.0);
									if (chrome.CheckExistElement("[name=\"password_old\"]") == 1)
									{
										chrome.SendKeys(2, "password_old", old_pass);
										chrome.DelayTime(2.0);
									}
									chrome.SendKeys(2, "password_new", new_pass);
									chrome.DelayTime(2.0);
									if (chrome.CheckExistElement("[name=\"password_confirm\"]") == 1)
									{
										chrome.SendKeys(2, "password_confirm", new_pass);
										chrome.DelayTime(2.0);
									}
									num2++;
									num = 1;
								}
								string text = chrome.CheckExistElementsv2(0.0, "#checkpointSubmitButton-actual-button", "#checkpointButtonContinue-actual-button");
								if (text == "")
								{
									if (chrome.GetURL().StartsWith(CommonChrome.GetWebsiteFacebook(chrome, 2) + "/home.php") || chrome.CheckExistElement("[href*=\"/friends/\"]") == 1)
									{
										return num;
									}
									continue;
								}
								if (text == "-2")
								{
									num = -2;
									return num;
								}
								chrome.Click(4, text);
								chrome.DelayTime(1.0);
							}
						}
					}
				}
			}
			catch
			{
			}
			if (num == 0)
			{
				MCommon.Common.ExportError(chrome, null, "Doi Pass Fail");
			}
			return num;
		}

		private int VerifyAccount(Chrome chrome, int indexRow, string statusProxy, string id, int typeMail)
		{
			//Discarded unreachable code: IL_00df, IL_00f4, IL_0638, IL_064d, IL_073e, IL_07ba
			int result = 0;
			try
			{
				string text = "";
				string text2 = "";
				string text3 = "";
				if (typeMail == 0)
				{
					lock (lstMailVerify)
					{
						if (lstMailVerify.Count == 0)
						{
							return 3;
						}
						text3 = lstMailVerify[0];
						lstMailVerify.RemoveAt(0);
					}
					text = text3.Split('|')[0];
					text2 = text3.Split('|')[1];
				}
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + "Check mail...");
				EmailHelper.DeleteMail(text, text2);
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Verify account..."));
				for (int i = 0; i < 10; i++)
				{
					chrome.GotoURL("https://www.facebook.com/settings?tab=account");
					if (chrome.CheckExistElement("#reload-button") != 1 && CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 1)
					{
						break;
					}
				}
				if (chrome.CheckExistElement("#reload-button") == 1)
				{
					return 0;
				}
				string value = Regex.Match(chrome.GetURL(), "https://(.*?).facebook.com").Value;
				chrome.ExecuteScript("function AddMail(email){var spinR = require([\"SiteData\"]).__spin_r; var spinB = require([\"SiteData\"]).__spin_b; var spinT = require([\"SiteData\"]).__spin_t; var jazoest = require([\"SprinkleConfig\"]).jazoest; var fbdtsg = require([\"DTSGInitData\"]).token; var userId = require([\"CurrentUserInitialData\"]).USER_ID; var hsi = require([\"SiteData\"]).hsi; var pass = \"\"; var url = \"" + value + "/add_contactpoint/dialog/submit/\"; var data = \"jazoest=22134&fb_dtsg=\" + fbdtsg + \"&next=&contactpoint=\" + email + \"&__user=\" + userId + \"&__a=1&__dyn=&__req=1&__be=1&__pc=PHASED%3ADEFAULT&dpr=1&__rev=&__s=&__hsi=\" + hsi + \"&__spin_r=\" + spinR + \"&__spin_b=\" + spinB + \"&__spin_t=\" + spinT; fetch(url, { method: 'POST', body: data, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).then(e => e.text()).then(e => {});};AddMail(\"" + text + "\");");
				chrome.DelayTime(2.0);
				chrome.GotoURL(value + "/settings?tab=account");
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang lâ\u0301y otp..."));
				string text4 = "";
				if (typeMail == 0)
				{
					text4 = EmailHelper.GetOtpFromMail(2, text, text2);
				}
				if (text4 == "")
				{
					chrome.Refresh();
					chrome.DelayTime(1.0);
					if (chrome.CheckExistElement("[rel=\"dialog-post\"]", 10.0) == 1)
					{
						chrome.Click(4, "[rel=\"dialog-post\"]");
						chrome.DelayTime(2.0);
						text4 = EmailHelper.GetOtpFromMail(2, text, text2);
					}
				}
				if (text4.Trim() == "")
				{
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Fb không gư\u0309i otp vê\u0300 mail!"));
					lock (k)
					{
						lstMailLoi.Add(text3);
					}
					return 5;
				}
				for (int j = 0; j < 3; j++)
				{
					chrome.GotoURL(text4);
					chrome.DelayTime(2.0);
					if (chrome.CheckExistElement("[href=\"/help/?ref=404\"]") != 1)
					{
						break;
					}
				}
				result = 1;
				CommonSQL.UpdateFieldToAccount(id, "email", text);
				CommonSQL.UpdateFieldToAccount(id, "passmail", text2);
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(ex, "Verify");
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Verify fail!"));
			}
			return result;
		}

		private string GetMailFromTempMail(Chrome chrome, string url, int timeOut = 30)
		{
			//Discarded unreachable code: IL_01af, IL_01bc
			string text = "";
			try
			{
				for (int i = 0; i < timeOut; i++)
				{
					if (!chrome.GetURL().Contains(url))
					{
						chrome.GotoURL(url);
					}
					string[] array = chrome.GetCookieFromChrome(Regex.Match(url, "https://(.*?)\\.").Groups[1].Value).Split(';');
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j].Split('=')[0] == "email")
						{
							text = WebUtility.UrlDecode(array[j].Split('=')[1]);
							break;
						}
					}
					if (text != "")
					{
						break;
					}
					MCommon.Common.DelayTime(1.0);
				}
			}
			catch
			{
			}
			return text;
		}

		private string GetOTPFromTempMail(string email, int timeOut = 60)
		{
			//Discarded unreachable code: IL_01d8, IL_01e5
			string text = "";
			try
			{
				string text2 = CreateMD5(email);
				RequestXNet requestXNet = new RequestXNet("", "", "", 0);
				string text3 = "";
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < timeOut * 1000)
				{
					text3 = requestXNet.RequestGet("https://api4.temp-mail.org/request/mail/id/" + text2 + "/format/json");
					text = Regex.Match(text3, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value;
					text = text.Replace("amp;", "").Replace("\"", "").Replace("\\", "");
					if (text != "")
					{
						break;
					}
					Thread.Sleep(2000);
				}
			}
			catch
			{
			}
			return text;
		}

		public string CreateMD5(string input)
		{
			//Discarded unreachable code: IL_0085, IL_0098
			using (MD5 mD = MD5.Create())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(input);
				byte[] array = mD.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				return stringBuilder.ToString();
			}
		}

		private void ScreenCaptureError(Chrome chrome, string uid, int type)
		{
			//Discarded unreachable code: IL_0141, IL_014e
			try
			{
				if (chrome != null)
				{
					string text = Application.StartupPath + "\\log_capture";
					switch (type)
					{
						case 0:
							text += "\\checkpoint";
							break;
						case 1:
							text += "\\loginfail";
							break;
						case 2:
							text += "\\disconnect";
							break;
					}
					MCommon.Common.CreateFolder(text);
					chrome.ScreenCapture(text, uid);
					string contents = chrome.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
					File.WriteAllText(text + "\\" + uid + ".html", contents);
				}
			}
			catch
			{
			}
		}

		private int ChangeMail(Chrome chrome, string pass, int indexRow, string statusProxy, string id)
		{
			//Discarded unreachable code: IL_0270, IL_0285, IL_06ba, IL_06cf, IL_08d5, IL_08e2, IL_0c18, IL_0c94
			int result = 0;
			try
			{
				string text = "";
				string text2 = "";
				string imap = "";
				string text3 = "";
				string username = "";
				string text4 = "";
				if (settings.GetValueInt("themMail") == 1)
				{
					if (settings.GetValueBool("ckbMailVip"))
					{
						if (lstMailAdd.Count == 0)
						{
							return 3;
						}
						text4 = lstMailAdd[rd.Next(0, lstMailAdd.Count)];
						username = text4.Split('|')[0];
						text2 = text4.Split('|')[1];
						text4 = text4.Split('|', '@')[1];
						text = GeneratorEmail(text4);
					}
					else
					{
						lock (lstMailAdd)
						{
							if (lstMailAdd.Count == 0)
							{
								return 3;
							}
							text3 = lstMailAdd[0];
							lstMailAdd.RemoveAt(0);
						}
						string[] array = text3.Split('|');
						text = array[0];
						text2 = array[1];
						if (array.Length > 2)
						{
							imap = array[2];
						}
						DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + "Check mail...");
						EmailHelper.DeleteMail(text, text2, imap);
					}
				}
				else
				{
					text = GetMailFromTempMail(chrome, "https://temp-mail.org/");
					if (!(text != ""))
					{
						return 3;
					}
					text2 = "";
				}
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang thêm mail..."));
				for (int i = 0; i < 10; i++)
				{
					chrome.GotoURL("https://www.facebook.com/settings?tab=account");
					if (CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 1)
					{
						break;
					}
				}
				chrome.ExecuteScript("function AddMail(email){var spinR = require([\"SiteData\"]).__spin_r; var spinB = require([\"SiteData\"]).__spin_b; var spinT = require([\"SiteData\"]).__spin_t; var jazoest = require([\"SprinkleConfig\"]).jazoest; var fbdtsg = require([\"DTSGInitData\"]).token; var userId = require([\"CurrentUserInitialData\"]).USER_ID; var hsi = require([\"SiteData\"]).hsi; var pass = \"\"; var url = \"https://www.facebook.com/add_contactpoint/dialog/submit/\"; var data = \"jazoest=22134&fb_dtsg=\" + fbdtsg + \"&next=&contactpoint=\" + email + \"&__user=\" + userId + \"&__a=1&__dyn=&__req=1&__be=1&__pc=PHASED%3ADEFAULT&dpr=1&__rev=&__s=&__hsi=\" + hsi + \"&__spin_r=\" + spinR + \"&__spin_b=\" + spinB + \"&__spin_t=\" + spinT; fetch(url, { method: 'POST', body: data, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).then(e => e.text()).then(e => {});};AddMail(\"" + text + "\");");
				chrome.DelayTime(2.0);
				string text5 = CommonChrome.RequestGet(chrome, "https://m.facebook.com/ntdelegatescreen/?params=%7B%22entry-point%22%3A%22settings%22%7D&path=%2Fcontacts%2Fmanagement%2F", "https://m.facebook.com/");
				if (!text5.Contains(MCommon.Common.UrlEncode(text.ToLower())))
				{
					return 0;
				}
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang lâ\u0301y otp..."));
				string text6 = "";
				text6 = (settings.GetValueBool("ckbMailVip") ? EmailHelper.GetOtpFromMail2(0, username, text2, text, 30, "imap.yandex.com") : EmailHelper.GetOtpFromMail(0, text, text2, 30, imap));
				if (text6.Trim() == "")
				{
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Fb không gư\u0309i otp vê\u0300 mail!"));
					lock (k)
					{
						lstMailLoi.Add(text3);
					}
					return 5;
				}
				for (int j = 0; j < 3; j++)
				{
					chrome.GotoURL(text6);
					chrome.DelayTime(2.0);
					if (chrome.CheckExistElement("[href=\"/help/?ref=404\"]") != 1)
					{
						break;
					}
				}
				if (chrome.CheckExistElement("[name=\"pass\"]") != 1)
				{
					goto IL_08fa;
				}
				if (pass != "")
				{
					chrome.SendKeys(Base.rd, 4, "[name=\"pass\"]", pass, 0.1);
					chrome.DelayTime(1.0);
					chrome.Click(4, "[data-testid=\"sec_ac_button\"]");
					chrome.DelayTime(3.0);
					try
					{
						if (Convert.ToBoolean(chrome.ExecuteScript("(document.querySelector('[name=\"pass\"]').value=='')+''")))
						{
							return 2;
						}
					}
					catch
					{
					}
					goto IL_08fa;
				}
				result = 4;
				goto end_IL_0007;
			IL_08fa:
				result = 1;
				CommonSQL.UpdateFieldToAccount(id, "email", text);
				CommonSQL.UpdateFieldToAccount(id, "passmail", text2);
				if (settings.GetValueBool("ckbAnMailMoi"))
				{
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang â\u0309n mail..."));
					chrome.GotoURL("https://m.facebook.com/settings/email/");
					chrome.DelayTime(3.0);
					chrome.ExecuteScript("document.querySelector('#root>div:nth-child(1)>div>div>div.acw.apl>div>div:nth-child(1)>div>div>div:nth-child(2)> a').click()");
					chrome.DelayTime(2.0);
					chrome.ExecuteScript("document.getElementsByName('px')[2].click()");
					chrome.DelayTime(1.0);
				}
				if (settings.GetValueBool("ckbXoaMailCu"))
				{
					DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Đang xo\u0301a mail cu\u0303..."));
					chrome.DelayTime(2.0);
					switch (RemoveMail(chrome, pass))
					{
						case 0:
							DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Xóa mail thất bại!"));
							break;
						case 1:
							DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Xóa mail thành công!"));
							break;
						case 2:
							result = 4;
							break;
					}
				}
			end_IL_0007:;
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(ex, "Add Mail");
				DatagridviewHelper.SetStatusDataGridView(dtgvAcc, indexRow, "cStatus", statusProxy + Language.GetValue("Add mail thất bại!"));
			}
			return result;
		}

		private string GeneratorEmail(string domain)
		{
			//Discarded unreachable code: IL_0055, IL_0062
			string result = "";
			try
			{
				result = CommonCSharp.CreateRandomString(10) + CommonCSharp.CreateRandomNumber(4) + "@" + domain;
			}
			catch
			{
			}
			return result;
		}

		private int RemovePhone(Chrome chrome, string pass)
		{
			//Discarded unreachable code: IL_03ab, IL_03b8, IL_0511, IL_051e, IL_05ff, IL_060c
			int result = 0;
			try
			{
				chrome.GotoURL("https://m.facebook.com/settings/sms/");
				chrome.DelayTime(3.0);
				string cssSelector = chrome.GetCssSelector("a", "href", "/settings/sms/?remove");
				while (true)
				{
					if (cssSelector != "")
					{
						int num = 0;
						if (num >= 10)
						{
							break;
						}
						chrome.Click(4, cssSelector);
						switch (chrome.CheckExistElements(10.0, "[name=\"remove_phone_warning_acknwoledged\"]", "[name=\"contact_point\"]", "[name=\"save_password\"]"))
						{
							case 1:
								chrome.Click(2, "remove_phone_warning_acknwoledged");
								chrome.DelayTime(1.0);
								chrome.Click(4, "button");
								chrome.DelayTime(3.0);
								if (chrome.CheckExistElement("[name=\"save_password\"]") != 1)
								{
									break;
								}
								chrome.SendKeys(2, "save_password", pass);
								chrome.DelayTime(1.0);
								chrome.Click(2, "save");
								chrome.DelayTime(3.0);
								try
								{
									if (chrome.GetURL().Contains("remove_phone&phone_number"))
									{
										return 0;
									}
									if (Convert.ToBoolean(chrome.ExecuteScript("var x='1'; if(document.querySelector('[name=\"save_password\"]')!=null) x=document.querySelector('[name=\"save_password\"]').value; return (x=='')+''")))
									{
										return 2;
									}
								}
								catch
								{
								}
								break;
							case 2:
								result = 1;
								goto end_IL_0007;
							default:
								chrome.SendKeys(2, "save_password", pass);
								chrome.DelayTime(1.0);
								chrome.Click(2, "save");
								chrome.DelayTime(3.0);
								try
								{
									if (chrome.GetURL().Contains("remove_phone&phone_number"))
									{
										return 0;
									}
									if (Convert.ToBoolean(chrome.ExecuteScript("var x='1'; if(document.querySelector('[name=\"save_password\"]')!=null) x=document.querySelector('[name=\"save_password\"]').value; return (x=='')+''")))
									{
										return 2;
									}
								}
								catch
								{
								}
								break;
						}
						chrome.GotoURL("https://m.facebook.com/settings/sms/");
						chrome.DelayTime(1.0);
						cssSelector = chrome.GetCssSelector("a", "href", "/settings/sms/?remove");
						if (cssSelector == "")
						{
							result = 1;
							break;
						}
						continue;
					}
					result = 1;
					break;
				}
			end_IL_0007:;
			}
			catch
			{
			}
			return result;
		}

		private int RemoveMail(Chrome chrome, string pass, string emailMoiAdd = "")
		{
			//Discarded unreachable code: IL_0412, IL_041f, IL_0562, IL_056f, IL_06b8, IL_06c5
			int result = 0;
			try
			{
				int num = 0;
				while (num < 2)
				{
					if (!chrome.GetURL().StartsWith("https://m.facebook.com/settings/email/"))
					{
						chrome.GotoURL("https://m.facebook.com/settings/email/");
						chrome.DelayTime(3.0);
					}
					string input = chrome.ExecuteScript("return document.documentElement.innerHTML").ToString();
					MatchCollection matchCollection = Regex.Matches(input, "/settings/email/\\?remove_email&(.*?)\"");
					int num2 = 0;
					while (true)
					{
						if (num2 < matchCollection.Count)
						{
							string text = matchCollection[num2].Value.Replace("amp;", "").Replace("\"", "");
							string value = Regex.Match(text, "email=(.*?)&").Groups[1].Value;
							value = MCommon.Common.UrlDecode(value);
							if (value != emailMoiAdd && chrome.ExecuteScript("return (document.documentElement.innerText.match(new RegExp('" + value + "', 'g')) || []).length+''").ToString() != "2")
							{
								chrome.GotoURL("https://m.facebook.com" + text);
								if (chrome.CheckExistElement("[name=\"save\"]", 10.0) == 1)
								{
									chrome.DelayTime(3.0);
									while (true)
									{
										int num3 = chrome.CheckExistElements(0.0, "[name=\"pass\"]", "[name=\"save_password\"]", "[href=\"https://www.facebook.com/help/177066345680802\"]");
										if (num3 != 0)
										{
											switch (num3)
											{
												case 1:
													chrome.SendKeys(2, "pass", pass);
													chrome.DelayTime(1.0);
													chrome.Click(2, "save");
													chrome.DelayTime(3.0);
													try
													{
														if (Convert.ToBoolean(chrome.ExecuteScript("(document.querySelector('[name=\"pass\"]').value=='')+''")))
														{
															result = 2;
															return result;
														}
													}
													catch
													{
													}
													if (chrome.CheckExistElement("[href=\"https://www.facebook.com/help/177066345680802\"]") != 1)
													{
														break;
													}
													result = 3;
													goto end_IL_0007;
												case 2:
													chrome.SendKeys(2, "save_password", pass);
													chrome.DelayTime(1.0);
													chrome.Click(2, "save");
													chrome.DelayTime(3.0);
													try
													{
														if (Convert.ToBoolean(chrome.ExecuteScript("(document.querySelector('[name=\"save_password\"]').value=='')+''")))
														{
															result = 2;
															return result;
														}
													}
													catch
													{
													}
													if (chrome.CheckExistElement("[href=\"https://www.facebook.com/help/177066345680802\"]") != 1)
													{
														break;
													}
													result = 3;
													goto end_IL_0007;
												case 3:
													result = 3;
													goto end_IL_0007;
											}
											break;
										}
										if (chrome.CheckExistElement("[name=\"save\"]") != 1)
										{
											break;
										}
										chrome.Click(2, "save");
										chrome.DelayTime(3.0);
									}
								}
							}
							num2++;
							continue;
						}
						num++;
						break;
					}
				}
			end_IL_0007:;
			}
			catch
			{
			}
			return result;
		}

		private bool Logout(Chrome chrome)
		{
			//Discarded unreachable code: IL_0110, IL_011d
			bool result = false;
			try
			{
				chrome.GotoURL("https://m.facebook.com/settings/security_login/sessions/log_out_all/confirm/");
				chrome.DelayTime(1.0);
				string text = "";
				for (int i = 0; i < 10; i++)
				{
					text = chrome.ExecuteScript("return document.documentElement.innerHTML.match(new RegExp('/security/settings/sessions/log_out_all/(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
					if (text != "")
					{
						chrome.GotoURL("https://m.facebook.com" + text);
						result = true;
						break;
					}
					chrome.DelayTime(1.0);
				}
			}
			catch
			{
			}
			return result;
		}

		public string Create2FA(Chrome chrome, string pass)
		{
			//Discarded unreachable code: IL_0788, IL_0795
			string text = "";
			string text2 = "";
			try
			{
				int num = 0;
				while (true)
				{
					chrome.GotoURL("https://m.facebook.com/security/2fac/setup/intro/");
					chrome.DelayTime(1.0);
					switch (chrome.CheckExistElements(20.0, "a[data-sigil=\"touchable\"]", "[name=\"pass\"]", "[data-testid=\"tfs_header_button\"]"))
					{
						case 0:
							break;
						case 3:
							text = "0|" + Language.GetValue("Đa\u0303 ta\u0323o 2fa trươ\u0301c đo\u0301!");
							break;
						case 2:
							chrome.DelayTime(1.0);
							chrome.SendKeys(Base.rd, 4, "[name=\"pass\"]", pass, 0.1);
							chrome.DelayThaoTacNho();
							chrome.Click(4, "[name=\"save\"]");
							if (chrome.CheckExistElement("[data-testid=\"tfs_header_button\"]", 10.0) == 1)
							{
								text = "0|" + Language.GetValue("Đa\u0303 ta\u0323o 2fa trươ\u0301c đo\u0301!");
							}
							break;
						default:
							{
								string text3 = chrome.ExecuteScript("return document.documentElement.innerHTML.match(new RegExp('https://m.facebook.com/2fac/setup/qrcode/generate(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
								if (text3 == "")
								{
									text3 = chrome.ExecuteScript("return document.documentElement.innerHTML.match(new RegExp('https://m.facebook.com/security/2fac/setup/qrcode/generate(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
								}
								if (!(text3 != ""))
								{
									break;
								}
								chrome.GotoURL(text3);
								chrome.DelayTime(1.0);
								int num2 = chrome.CheckExistElements(20.0, "[name=\"pass\"]", "[data-testid=\"key\"]", "#checkpointSubmitButton", "#captcha_response", "#checkpointBottomBar");
								if (num2 != 1 && num2 != 2)
								{
									break;
								}
								if (num2 == 1)
								{
									chrome.DelayTime(1.0);
									chrome.SendKeys(Base.rd, 4, "[name=\"pass\"]", pass, 0.1);
									chrome.DelayThaoTacNho();
									chrome.Click(4, "[name=\"save\"]");
								}
								if (chrome.CheckExistElement("[data-testid=\"key\"]", 20.0) != 1)
								{
									break;
								}
								text2 = chrome.ExecuteScript("return document.querySelector('[data-testid=\"key\"]').innerText").ToString().Replace(" ", "");
								chrome.Click(4, "[name=\"confirmButton\"]");
								if (chrome.CheckExistElement("[name=\"code\"]", 20.0) != 1)
								{
									break;
								}
								chrome.DelayTime(1.0);
								string totp = MCommon.Common.GetTotp(text2);
								if (totp == "")
								{
									num++;
									if (num == 1)
									{
										continue;
									}
								}
								if (totp != "")
								{
									chrome.SendKeys(Base.rd, 4, "[name=\"code\"]", totp, 0.1);
									chrome.DelayThaoTacNho();
									chrome.Click(1, "submit_code_button");
									chrome.DelayTime(2.0);
								}
								else
								{
									text = "0|" + Language.GetValue("Không ta\u0323o đươ\u0323c ma\u0303 6 sô\u0301!");
								}
								break;
							}
					}
					break;
				}
			}
			catch
			{
			}
			if (text == "")
			{
				text = "1|" + text2;
			}
			return text;
		}

		public bool Remove2FA(Chrome chrome, string pass)
		{
			//Discarded unreachable code: IL_02e3, IL_02f0
			bool result = false;
			try
			{
				chrome.GotoURL("https://m.facebook.com/security/2fac/setup/turn_off/");
				chrome.DelayTime(1.0);
				if (chrome.CheckExistElement("[data-testid=\"tfa_setup_dialog_primary_button\"]", 20.0) == 1)
				{
					chrome.DelayTime(1.0);
					chrome.Click(4, "[data-testid=\"tfa_setup_dialog_primary_button\"]");
					chrome.DelayTime(2.0);
					switch (chrome.CheckExistElements(10.0, "[name=\"pass\"]", "a[data-sigil=\"touchable\"]", "#checkpointSubmitButton", "#captcha_response", "#checkpointBottomBar"))
					{
						case 1:
							chrome.DelayTime(1.0);
							chrome.SendKeys(Base.rd, 4, "[name=\"pass\"]", pass, 0.1);
							chrome.DelayThaoTacNho();
							chrome.Click(4, "[name=\"save\"]");
							if (chrome.CheckExistElement("a[data-sigil=\"touchable\"]", 10.0) == 1)
							{
								result = true;
							}
							break;
						case 2:
							result = true;
							break;
						case 3:
						case 4:
						case 5:
							break;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		public int ChangeHomeTown(Chrome chrome, string homeTown)
		{
			//Discarded unreachable code: IL_01ef, IL_01fc
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=living");
				chrome.DelayTime(2.0);
				if (chrome.CheckExistElement("[data-sigil=\"edit-hometown-text textinput\"]", 10.0) == 1)
				{
					chrome.ClearText(4, "[data-sigil=\"edit-hometown-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendKeys(Base.rd, 4, "[data-sigil=\"edit-hometown-text textinput\"]", homeTown, 0.1);
					chrome.DelayThaoTacNho();
					chrome.SendKeyDown(4, "[data-sigil=\"edit-hometown-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, "[data-sigil=\"edit-hometown-text textinput\"]");
					chrome.DelayThaoTacNho(1);
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangeCity(Chrome chrome, string city)
		{
			//Discarded unreachable code: IL_01dd, IL_01ea
			bool flag = false;
			try
			{
				chrome.GotoURL("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=living");
				chrome.DelayTime(2.0);
				if (chrome.CheckExistElement("[data-sigil=\"edit-current_city-text textinput\"]", 10.0) == 1)
				{
					chrome.ClearText(4, "[data-sigil=\"edit-current_city-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendKeys(Base.rd, 4, "[data-sigil=\"edit-current_city-text textinput\"]", city, 0.1);
					chrome.DelayTime(1.0);
					chrome.SendKeyDown(4, "[data-sigil=\"edit-current_city-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, "[data-sigil=\"edit-current_city-text textinput\"]");
					chrome.DelayThaoTacNho(1);
					chrome.Click(4, "[name=\"save\"]");
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangeWork(Chrome chrome, string work)
		{
			//Discarded unreachable code: IL_0343, IL_0350
			bool flag = false;
			int num = 0;
			int num2 = 0;
			try
			{
				chrome.GotoURLIfNotExist("https://m.facebook.com/me/about");
				chrome.DelayTime(1.0);
				if (chrome.CheckExistElement("#timelineBody", 10.0) == 1)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('.darkTouch.l').length").ToString());
				}
				int num3 = chrome.GotoURLIfNotExist("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=work&experience_type=2002");
				if (num3 == -2)
				{
					return -2;
				}
				chrome.DelayTime(3.0);
				if (chrome.CheckExistElement("[data-sigil=\"edit-employer-text textinput\"]", 10.0) == 1)
				{
					chrome.SendKeys(Base.rd, 4, "[data-sigil=\"edit-employer-text textinput\"]", work, 0.1);
					chrome.DelayThaoTacNho();
					chrome.SendKeyDown(4, "[data-sigil=\"edit-employer-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, "[data-sigil=\"edit-employer-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.Click(4, "[data-sigil=\"junk-text\"]");
					chrome.DelayTime(0.5);
					chrome.Click(4, "[data-sigil=\"edit-current touchable\"]");
					chrome.DelayThaoTacNho();
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangePTTH(Chrome chrome, string ptth)
		{
			//Discarded unreachable code: IL_0315, IL_0322
			bool flag = false;
			int num = 0;
			int num2 = 0;
			try
			{
				chrome.GotoURL("https://m.facebook.com/me/about");
				chrome.DelayTime(1.0);
				if (chrome.CheckExistElement("#timelineBody", 10.0) == 1)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('.darkTouch.l').length").ToString());
				}
				int num3 = chrome.GotoURLIfNotExist("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=education&experience_type=2003");
				if (num3 == -2)
				{
					return -2;
				}
				chrome.DelayTime(3.0);
				if (chrome.CheckExistElement("[data-sigil=\"edit-hs_school-text textinput\"]", 10.0) == 1)
				{
					chrome.SendKeys(Base.rd, 4, "[data-sigil=\"edit-hs_school-text textinput\"]", ptth, 0.1);
					chrome.DelayThaoTacNho();
					chrome.SendKeyDown(4, "[data-sigil=\"edit-hs_school-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, "[data-sigil=\"edit-hs_school-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.Click(4, "[name=\"graduated\"]");
					chrome.DelayThaoTacNho();
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(2.0);
					chrome.GotoURL("https://m.facebook.com/me/about");
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangeDaiHoc(Chrome chrome, string daiHoc)
		{
			//Discarded unreachable code: IL_02df, IL_02ec
			bool flag = false;
			int num = 0;
			int num2 = 0;
			try
			{
				chrome.GotoURLIfNotExist("https://m.facebook.com/me/about");
				chrome.DelayTime(1.0);
				if (chrome.CheckExistElement("#timelineBody", 10.0) == 1)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('.darkTouch.l').length").ToString());
				}
				int num3 = chrome.GotoURLIfNotExist("https://m.facebook.com/profile/edit/infotab/section/forms/?life_event_surface=mtouch_profile&section=education&experience_type=2004");
				if (num3 == -2)
				{
					return -2;
				}
				chrome.DelayTime(3.0);
				if (chrome.CheckExistElement("[data-sigil=\"edit-college_school-text textinput\"]", 10.0) == 1)
				{
					chrome.SendKeys(Base.rd, 4, "[data-sigil=\"edit-college_school-text textinput\"]", daiHoc, 0.1);
					chrome.DelayThaoTacNho();
					chrome.SendKeyDown(4, "[data-sigil=\"edit-college_school-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, "[data-sigil=\"edit-college_school-text textinput\"]");
					chrome.DelayTime(1.0);
					chrome.Click(4, "[name=\"graduated\"]");
					chrome.DelayThaoTacNho();
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangePass(Chrome chrome, string old_pass, string new_pass)
		{
			//Discarded unreachable code: IL_034f, IL_035c
			int num = 0;
			try
			{
				if (!chrome.CheckIsLive())
				{
					return -2;
				}
				chrome.GotoURLIfNotExist("https://m.facebook.com/settings/security/password/");
				chrome.DelayTime(1.0);
				if (chrome.CheckExistElement("[name=\"password_old\"]", 10.0) == 1)
				{
					chrome.SendKeys(Base.rd, 4, "[name=\"password_old\"]", old_pass, 0.1);
					chrome.DelayThaoTacNho();
					chrome.SendKeys(Base.rd, 4, "[name=\"password_new\"]", new_pass, 0.1);
					chrome.DelayThaoTacNho();
					chrome.SendKeys(Base.rd, 4, "[name=\"password_confirm\"]", new_pass, 0.1);
					chrome.DelayThaoTacNho();
					chrome.Click(4, "[name=\"save\"]");
					chrome.DelayTime(5.0);
					num = 1;
					int tickCount = Environment.TickCount;
					while (true)
					{
						if (!chrome.CheckIsLive())
						{
							return -2;
						}
						if (Environment.TickCount - tickCount > 20000)
						{
							break;
						}
						if (chrome.CheckExistElement("[name=\"session_invalidation_options\"]") == 1)
						{
							chrome.DelayTime(1.0);
							chrome.ExecuteScript("document.querySelectorAll(\"#m_check_list_aria_label > input\")[1].click()");
							chrome.DelayTime(1.0);
							chrome.Click(4, "[name=\"submit_action\"]");
							break;
						}
					}
				}
			}
			catch
			{
			}
			if (num == 0)
			{
				MCommon.Common.ExportError(chrome, null, "Doi Pass Fail");
			}
			return num;
		}

		public int ChangeLanguage(Chrome chrome, string country_code)
		{
			//Discarded unreachable code: IL_0241, IL_024e
			bool flag = false;
			try
			{
				chrome.GotoURL("https://m.facebook.com/language.php");
				int tickCount = Environment.TickCount;
				string text = "";
				while (Environment.TickCount - tickCount < 10000)
				{
					text = chrome.ExecuteScript("var x='';if(document.documentElement.innerHTML.includes('/a/language.php?l=" + country_code + "')) x=('https://m.facebook.com'+document.documentElement.innerHTML.match(new RegExp('/a/language.php\\\\?l=" + country_code + "(.*?)\"'))[0]).replace('\"','').split('amp;').join(''); else x=''; return x;").ToString();
					if (text != "")
					{
						chrome.GotoURL(text);
						flag = true;
						break;
					}
					if (chrome.CheckExistElement("[value=\"" + country_code + "\"]") == 1 && chrome.Click(4, "[value=\"" + country_code + "\"]") == 1)
					{
						chrome.CheckExistElement("[href=\"/language.php\"]", 5.0);
						flag = true;
						break;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int AddPhone(Chrome chrome, string phone, Random rd)
		{
			//Discarded unreachable code: IL_02d3, IL_02e0
			bool flag = false;
			try
			{
				while (true)
				{
					string text = "";
					string text2 = "";
					for (int i = 0; i < phone.Length; i++)
					{
						text2 = phone[i].ToString();
						if (text2 == "x")
						{
							text2 = rd.Next(0, 10).ToString();
						}
						text += text2;
					}
					if (text.StartsWith("0"))
					{
						text = "+84" + text.Substring(1);
					}
					chrome.GotoURL("https://m.facebook.com/phoneacquire/?source=contactpoint_settings&entry_point=settings");
					if (chrome.CheckExistElement("[name=\"contact_point\"]", 10.0) == 1)
					{
						chrome.DelayTime(1.0);
						chrome.SendKeys(Base.rd, 4, "[name=\"contact_point\"]", text, 0.1);
						chrome.DelayThaoTacNho();
						chrome.Click(4, ".buttonArea>button");
						chrome.DelayTime(2.0);
						switch (chrome.CheckExistElements(10.0, "#root > div > div > div > div:nth-child(1) > div > div", "[name=\"pin\"]"))
						{
							case 1:
								break;
							default:
								goto end_IL_0007;
							case 2:
								flag = true;
								goto end_IL_0007;
						}
						continue;
					}
					break;
				}
			end_IL_0007:;
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int UpAvatar(Chrome chrome, string pathImage, Random rd)
		{
			//Discarded unreachable code: IL_0540, IL_054d
			bool flag = false;
			try
			{
				while (true)
				{
				IL_0008:
					chrome.DelayTime(3.0);
					chrome.GotoURL("https://m.facebook.com/me");
					switch (chrome.CheckExistElements(20.0, "#m-timeline-cover-section>div>div>div:nth-child(2)>a", "#m-timeline-cover-section>div>div>div:nth-child(2)>div>a"))
					{
						case -2:
							return -2;
						case 1:
							chrome.DelayTime(1.0);
							chrome.Click(4, "#m-timeline-cover-section>div>div>div:nth-child(2)>a");
							break;
						case 2:
							chrome.DelayTime(1.0);
							chrome.Click(4, "#m-timeline-cover-section>div>div>div:nth-child(2)>div>a");
							break;
						case 0:
							goto end_IL_0007;
					}
					if (chrome.CheckExistElement("#nuxPicFileInput", 20.0) != 1)
					{
						break;
					}
					chrome.DelayTime(3.0);
					chrome.SendKeys(1, "nuxPicFileInput", pathImage, isClick: false);
					chrome.DelayTime(2.0);
					int num = 0;
					for (int i = 0; i < 30; i++)
					{
						if (Convert.ToBoolean(chrome.ExecuteScript("return document.querySelector('#nuxPicFileInput_preview').getAttribute('style').includes('background-image')+''")))
						{
							chrome.DelayTime(1.0);
							switch (chrome.CheckExistElements(10.0, "#nuxUploadPhotoButton>button", "#nuxUploadPhotoButton>div>button"))
							{
								case 1:
									chrome.Click(4, "#nuxUploadPhotoButton>button");
									break;
								case 2:
									chrome.Click(4, "#nuxUploadPhotoButton>div>button");
									break;
								default:
									MCommon.Common.ExportError(chrome, null, "Ko up duoc avatar");
									break;
							}
							if (chrome.WaitForSearchElement("#nuxUploadPhotoButton>div>button", 1, 20.0) == 1)
							{
								chrome.DelayTime(1.0);
								flag = true;
							}
							break;
						}
						if (chrome.ExecuteScript("return document.querySelector('#nuxPicFileInput').value+''").ToString() == "")
						{
							chrome.SendKeys(1, "nuxPicFileInput", pathImage, isClick: false);
							chrome.DelayTime(2.0);
							continue;
						}
						num++;
						if (num == 3)
						{
							goto IL_0008;
						}
					}
					break;
				}
			end_IL_0007:;
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int UpCover(Chrome chrome, string pathImage, Random rd)
		{
			//Discarded unreachable code: IL_0342, IL_034f
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist("https://m.facebook.com/me");
				chrome.DelayTime(2.0);
				if (chrome.CheckExistElement("#m-timeline-cover-section > div > div:nth-child(1) > div > div > a", 20.0) == 1)
				{
					chrome.DelayTime(1.0);
					chrome.Click(4, "#m-timeline-cover-section > div > div:nth-child(1) > div > div > a");
					chrome.DelayTime(1.0);
					int num = chrome.CheckExistElements(20.0, "#modalDialogView > div > div:nth-child(1) > div > div > a", "#nuxPicFileInput");
					if (num == 1)
					{
						chrome.Click(4, "#modalDialogView > div > div:nth-child(1) > div > div > a");
						chrome.DelayTime(1.0);
					}
					if (chrome.CheckExistElement("#nuxPicFileInput", 10.0) == 1)
					{
						chrome.DelayTime(1.0);
						chrome.SendKeys(1, "nuxPicFileInput", pathImage);
						chrome.DelayTime(5.0);
						if (chrome.Click(4, "#nuxUploadPhotoButton button") != 1)
						{
							chrome.ExecuteScript("document.querySelector('#nuxUploadPhotoButton button').click()");
						}
						if (chrome.WaitForSearchElement("#nuxUploadPhotoButton button", 1, 20.0) == 1)
						{
							chrome.DelayTime(1.0);
							flag = true;
						}
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int UpCoverNgheThuat(Chrome chrome, Random rd)
		{
			//Discarded unreachable code: IL_01b1, IL_01be
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist("https://mbasic.facebook.com/photos/change/cover_photo/?photo_type=artwork_photos");
				if (chrome.CheckExistElement("#root > table > tbody > tr > td > div > div > div > span > a", 10.0) == 1)
				{
					int num = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('#root > table > tbody > tr > td > div > div > div > span > a').length+''").ToString());
					if (num > 0)
					{
						chrome.ExecuteScript("document.querySelectorAll('#root > table > tbody > tr > td > div > div > div > span > a')[" + rd.Next(0, num) + "].click()");
						chrome.DelayTime(1.0);
						if (chrome.CheckExistElement("#root > table > tbody > tr > td > div > div > div > div > form > div > input", 10.0) == 1)
						{
							chrome.Click(4, "#root > table > tbody > tr > td > div > div > div > div > form > div > input");
						}
						chrome.DelayTime(2.0);
						flag = true;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangeTieuSu(Chrome chrome, string tieuSu, bool isPostWall = true)
		{
			//Discarded unreachable code: IL_02bb, IL_02c8
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist("https://m.facebook.com/profile/intro/edit/public/?refid=17");
				if (chrome.CheckExistElement("#root>div>div>div>div>div>div:nth-child(5)>div> div:nth-child(2)", 10.0) == 1)
				{
					chrome.DelayTime(1.0);
					chrome.Click(4, "#root>div>div>div>div>div>div:nth-child(5)>div> div:nth-child(2)");
					if (chrome.CheckExistElement("[name=\"bio\"]", 10.0) == 1)
					{
						chrome.ClearText(4, "[name=\"bio\"]");
						tieuSu = tieuSu.Replace("\r\n", "\\r\\n");
						chrome.ExecuteScript("document.querySelector('[name=\"bio\"]').value=\"" + tieuSu + "\"");
						if (isPostWall)
						{
							chrome.Click(4, "[name=\"publish_to_feed\"]");
							chrome.DelayTime(1.0);
						}
						if (chrome.Click(4, "[data-sigil=\"touchable profile-intro-card-confirm-button\"]") != 1)
						{
							chrome.ExecuteScript("document.querySelector('[data-sigil=\"touchable profile-intro-card-confirm-button\"]').click()");
						}
						chrome.DelayTime(2.0);
						flag = true;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int ChangeName(Chrome chrome, string hoTen, string password)
		{
			//Discarded unreachable code: IL_0674, IL_0681
			int result = 0;
			try
			{
				chrome.GotoURL("https://m.facebook.com/settings/account/?name");
				switch (chrome.CheckExistElements(20.0, "[href=\"/help/112146705538576\"]", "[href=\"/help/448505685205813\"]"))
				{
					case 1:
						{
							string[] array = hoTen.Split(' ');
							int num = array.Length;
							string content = array[0];
							string text = "";
							string content2 = array[num - 1];
							if (num > 2)
							{
								for (int i = 1; i < num - 1; i++)
								{
									text = text + array[i] + " ";
								}
							}
							text = text.Trim();
							if (chrome.CheckExistElement("[name=\"primary_last_name\"]", 10.0) != 1)
							{
								break;
							}
							chrome.DelayTime(1.0);
							string text2 = chrome.ExecuteScript("return document.querySelector('[name=\"primary_last_name\"]').value").ToString();
							chrome.ClearText(4, "[name=\"primary_last_name\"]");
							chrome.SendKeys(Base.rd, 4, "[name=\"primary_last_name\"]", content, 0.1);
							chrome.DelayTime(1.0);
							chrome.ClearText(4, "[name=\"primary_middle_name\"]");
							if (text != "")
							{
								chrome.SendKeys(Base.rd, 4, "[name=\"primary_middle_name\"]", text, 0.1);
							}
							chrome.DelayTime(1.0);
							chrome.ClearText(4, "[name=\"primary_first_name\"]");
							chrome.SendKeys(Base.rd, 4, "[name=\"primary_first_name\"]", content2, 0.1);
							chrome.DelayTime(2.0);
							chrome.Click(4, "[name=\"save\"]");
							chrome.DelayTime(5.0);
							if (chrome.ExecuteScript("return document.querySelector('[name=\"primary_last_name\"]').value").ToString() == text2)
							{
								return 2;
							}
							int num2 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('#m-settings-form > div:nth-child(4)>fieldset>label').length").ToString());
							for (int j = 0; j < num2; j++)
							{
								string text3 = chrome.ExecuteScript("return document.querySelector('#m-settings-form > div:nth-child(4)>fieldset>label:nth-child(" + (j + 1) + ")>div>div>span').innerText").ToString();
								if (hoTen == text3)
								{
									chrome.Click(4, "#m-settings-form > div:nth-child(4)>fieldset>label:nth-child(" + (j + 1) + ")>div>div:nth-child(2)>input");
									break;
								}
							}
							if (chrome.CheckExistElement("[name=\"save_password\"]", 10.0) == 1)
							{
								chrome.DelayTime(1.0);
								chrome.SendKeys(Base.rd, 4, "[name=\"save_password\"]", password, 0.1);
								chrome.Click(4, "[name=\"save\"]");
								chrome.DelayTime(2.0);
							}
							result = 1;
							break;
						}
					case 2:
						return 0;
				}
			}
			catch
			{
			}
			return result;
		}

		private void btnPause_Click_1(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0059, IL_0066
			try
			{
				isStop = true;
				btnPause.Enabled = false;
				btnPause.Text = Language.GetValue("Đang dư\u0300ng...");
			}
			catch
			{
			}
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_003e, IL_004b
			try
			{
				MCommon.Common.CreateFolder("configschange\\fail");
				Process.Start("configschange\\fail");
			}
			catch
			{
			}
		}

		public static byte[] BitmapToByte2(Bitmap bm)
		{
			//Discarded unreachable code: IL_0026, IL_0039
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bm.Save(memoryStream, ImageFormat.Png);
				return memoryStream.ToArray();
			}
		}

		private void WriteFile(int row, int type)
		{
			//Discarded unreachable code: IL_027f, IL_0294, IL_029b, IL_02a8
			string text = "";
			string text2 = "";
			try
			{
				text = text + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cUid") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cPassword") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cFa2") + "|" + DatagridviewHelper.GetStatusDataGridView(dtgvAcc, row, "cCookies") + "\r\n";
				switch (type)
				{
					case 1:
						text2 = "DoiPassThatBai.txt";
						break;
					case 2:
						text2 = "ThemMailThatBai.txt";
						break;
					case 3:
						text2 = "SaiPass.txt";
						break;
					case 4:
						text2 = "Checkpoint.txt";
						break;
					case 5:
						text2 = "Loi.txt";
						break;
				}
				lock (lock1)
				{
					File.AppendAllText("configschange\\fail\\" + text2, text);
				}
			}
			catch
			{
			}
		}

		private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//Discarded unreachable code: IL_008e, IL_009b
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				UpdateSelectCountRecord();
			}
			catch
			{
			}
		}

		public static string GetPhoneTextNow(string apikey, int timeOut = 60)
		{
			//Discarded unreachable code: IL_0236, IL_0243
			string text = "";
			int num = 1;
			RequestHttp requestHttp = new RequestHttp();
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < 5; i++)
			{
				try
				{
					text2 = requestHttp.RequestGet("http://codetextnow.com/api.php?apikey=" + apikey + "&action=create-request&serviceId=" + num + "&count=1");
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["results"]["data"][0]["requestId"].ToString();
					if (text3 != "")
					{
						text = jObject["results"]["data"][0]["sdt"].ToString();
						break;
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text3 + "|" + text;
		}

		public static string GetOTPTextNow(string apikey, string id_order, int timeOut = 120)
		{
			//Discarded unreachable code: IL_01a5, IL_01b2
			string text = "";
			RequestHttp requestHttp = new RequestHttp();
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= timeOut * 1000)
			{
				string json = requestHttp.RequestGet("http://codetextnow.com/api.php?apikey=" + apikey + "&action=data-request&requestId=" + id_order);
				JObject jObject = JObject.Parse(json);
				if (!(jObject["status"].ToString() == "200"))
				{
					continue;
				}
				try
				{
					text = jObject["data"][0]["otp"].ToString();
					if (text != "")
					{
						break;
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text;
		}

		public static string GetPhoneOtpSim(string apikey, int service_id = 7, int timeOut = 60)
		{
			//Discarded unreachable code: IL_0233, IL_0240
			string text = "";
			RequestHttp requestHttp = new RequestHttp();
			string text2 = "";
			string text3 = "";
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= timeOut * 1000)
			{
				text2 = requestHttp.RequestGet("http://otpsim.com/api/phones/request?token=" + apikey + "&service=" + service_id);
				try
				{
					JObject jObject = JObject.Parse(text2);
					if (Convert.ToBoolean(jObject["success"].ToString()))
					{
						text = JObject.Parse(text2)["data"]["phone_number"].ToString();
						text3 = JObject.Parse(text2)["data"]["session"].ToString();
						if (!(text != "") || !(text3 != ""))
						{
							Thread.Sleep(5000);
							continue;
						}
						break;
					}
					Thread.Sleep(5000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text3 + "|" + text;
		}

		public static string GetOTPOtpSim(string apikey, string id_order, int timeOut = 120)
		{
			//Discarded unreachable code: IL_01ae, IL_01bb
			string text = "";
			RequestHttp requestHttp = new RequestHttp();
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= timeOut * 1000)
			{
				string json = requestHttp.RequestGet("http://otpsim.com/api/sessions/" + id_order + "?token=" + apikey);
				JObject jObject = JObject.Parse(json);
				if (!Convert.ToBoolean(jObject["success"].ToString()))
				{
					continue;
				}
				try
				{
					text = JObject.Parse(json)["data"]["messages"][0]["otp"].ToString();
					if (text != "")
					{
						break;
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text;
		}

		public static string GetPhoneSimCode(string apikey, int service_id = 1001, int timeOut = 60)
		{
			//Discarded unreachable code: IL_019d, IL_01aa
			string text = "";
			RequestHttp requestHttp = new RequestHttp();
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < 5; i++)
			{
				try
				{
					text2 = requestHttp.RequestGet("https://chothuesimcode.com/api?act=number&apik=" + apikey + "&appId=" + service_id);
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["Result"]["Id"].ToString();
					if (text3 != "")
					{
						text = jObject["Result"]["Number"].ToString();
						break;
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text3 + "|" + text;
		}

		public static string GetOTPSimCode(string apikey, string id_order, int timeOut = 120)
		{
			//Discarded unreachable code: IL_0196, IL_01a3
			string text = "";
			RequestHttp requestHttp = new RequestHttp();
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount <= timeOut * 1000)
			{
				string json = requestHttp.RequestGet("https://chothuesimcode.com/api?act=code&apik=" + apikey + "&id=" + id_order);
				JObject jObject = JObject.Parse(json);
				if (!(jObject["ResponseCode"].ToString() == "0"))
				{
					continue;
				}
				try
				{
					text = jObject["Result"]["Code"].ToString();
					if (text != "")
					{
						break;
					}
					Thread.Sleep(3000);
					continue;
				}
				catch
				{
					continue;
				}
			}
			return text;
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maxcare.fChange));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			tấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			dieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			checkpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			đăngNhậpProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			cookieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			uidPassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			đăngNhậpTrìnhDuyệtMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			cookieToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			uidPassToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			danhSáchChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			danhSáchKhôngChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			giữNguyênỞThưMụcCũToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mnsCutAccount = new System.Windows.Forms.ToolStripMenuItem();
			kiểmTraTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			kiểmTraCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			kiểmTraTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			backupTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			backupCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			backupCookieTrungGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mậtKhẩuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			tokenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			tựĐộngLấyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			tokenBussinessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			tokenInstagramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			tokenIosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			tokenAndroidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			nhậpDữLiệuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			cookieToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			tựĐộngLấyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			nhậpDữLiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
			pnlHeader = new System.Windows.Forms.Panel();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			btnMinimize = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(components);
			bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			panel3 = new System.Windows.Forms.Panel();
			lblChoosed = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			lblCountAcc = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			ctmsAcc = new System.Windows.Forms.ContextMenuStrip(components);
			chọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			bỏChọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			ctmsChonTrangThai = new System.Windows.Forms.ToolStripMenuItem();
			xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			dtgvAcc = new System.Windows.Forms.DataGridView();
			btnConfig = new System.Windows.Forms.Button();
			btnPause = new System.Windows.Forms.Button();
			btnStart = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cUseragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			bunifuCards1.SuspendLayout();
			ctmsAcc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
			SuspendLayout();
			tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
			tấtCảToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			liveToolStripMenuItem.Name = "liveToolStripMenuItem";
			liveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			dieToolStripMenuItem.Name = "dieToolStripMenuItem";
			dieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			checkpointToolStripMenuItem.Name = "checkpointToolStripMenuItem";
			checkpointToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			changePasswordToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			đăngNhậpProfileToolStripMenuItem.Name = "đăngNhậpProfileToolStripMenuItem";
			đăngNhậpProfileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			cookieToolStripMenuItem1.Name = "cookieToolStripMenuItem1";
			cookieToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			uidPassToolStripMenuItem1.Name = "uidPassToolStripMenuItem1";
			uidPassToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			đăngNhậpTrìnhDuyệtMớiToolStripMenuItem.Name = "đăngNhậpTrìnhDuyệtMớiToolStripMenuItem";
			đăngNhậpTrìnhDuyệtMớiToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			cookieToolStripMenuItem2.Name = "cookieToolStripMenuItem2";
			cookieToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
			uidPassToolStripMenuItem2.Name = "uidPassToolStripMenuItem2";
			uidPassToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
			tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
			tokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
			cookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			uidToolStripMenuItem.Name = "uidToolStripMenuItem";
			uidToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			passToolStripMenuItem.Name = "passToolStripMenuItem";
			passToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
			uidPassToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
			uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			danhSáchChọnToolStripMenuItem.Name = "danhSáchChọnToolStripMenuItem";
			danhSáchChọnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			danhSáchKhôngChọnToolStripMenuItem.Name = "danhSáchKhôngChọnToolStripMenuItem";
			danhSáchKhôngChọnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			giữNguyênỞThưMụcCũToolStripMenuItem.Name = "giữNguyênỞThưMụcCũToolStripMenuItem";
			giữNguyênỞThưMụcCũToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			mnsCutAccount.Name = "mnsCutAccount";
			mnsCutAccount.Size = new System.Drawing.Size(32, 19);
			kiểmTraTàiKhoảnToolStripMenuItem.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
			kiểmTraTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			kiểmTraCookieToolStripMenuItem.Name = "kiểmTraCookieToolStripMenuItem";
			kiểmTraCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			kiểmTraTokenToolStripMenuItem.Name = "kiểmTraTokenToolStripMenuItem";
			kiểmTraTokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			backupTokenToolStripMenuItem.Name = "backupTokenToolStripMenuItem";
			backupTokenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			backupCookieToolStripMenuItem.Name = "backupCookieToolStripMenuItem";
			backupCookieToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			backupCookieTrungGianToolStripMenuItem.Name = "backupCookieTrungGianToolStripMenuItem";
			backupCookieTrungGianToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			mậtKhẩuToolStripMenuItem1.Name = "mậtKhẩuToolStripMenuItem1";
			mậtKhẩuToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
			nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			tokenToolStripMenuItem2.Name = "tokenToolStripMenuItem2";
			tokenToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
			tựĐộngLấyToolStripMenuItem1.Name = "tựĐộngLấyToolStripMenuItem1";
			tựĐộngLấyToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			tokenBussinessToolStripMenuItem.Name = "tokenBussinessToolStripMenuItem";
			tokenBussinessToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			tokenInstagramToolStripMenuItem1.Name = "tokenInstagramToolStripMenuItem1";
			tokenInstagramToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			tokenIosToolStripMenuItem.Name = "tokenIosToolStripMenuItem";
			tokenIosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			tokenAndroidToolStripMenuItem1.Name = "tokenAndroidToolStripMenuItem1";
			tokenAndroidToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			nhậpDữLiệuToolStripMenuItem2.Name = "nhậpDữLiệuToolStripMenuItem2";
			nhậpDữLiệuToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
			cookieToolStripMenuItem3.Name = "cookieToolStripMenuItem3";
			cookieToolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
			tựĐộngLấyToolStripMenuItem.Name = "tựĐộngLấyToolStripMenuItem";
			tựĐộngLấyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			nhậpDữLiệuToolStripMenuItem1.Name = "nhậpDữLiệuToolStripMenuItem1";
			nhậpDữLiệuToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			bunifuDragControl1.Fixed = true;
			bunifuDragControl1.Horizontal = true;
			bunifuDragControl1.TargetControl = pnlHeader;
			bunifuDragControl1.Vertical = true;
			pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			pnlHeader.BackColor = System.Drawing.Color.White;
			pnlHeader.Controls.Add(button2);
			pnlHeader.Controls.Add(button1);
			pnlHeader.Controls.Add(btnMinimize);
			pnlHeader.Controls.Add(pictureBox1);
			pnlHeader.Controls.Add(bunifuCustomLabel1);
			pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
			pnlHeader.Location = new System.Drawing.Point(0, 5);
			pnlHeader.Name = "pnlHeader";
			pnlHeader.Size = new System.Drawing.Size(986, 32);
			pnlHeader.TabIndex = 9;
			button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			button2.Cursor = System.Windows.Forms.Cursors.Hand;
			button2.Enabled = false;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.Color.White;
			button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
			button2.Location = new System.Drawing.Point(890, -1);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(30, 30);
			button2.TabIndex = 15;
			button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(Button2_Click);
			button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			button1.Cursor = System.Windows.Forms.Cursors.Hand;
			button1.Enabled = false;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.Color.White;
			button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(922, -1);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(30, 30);
			button1.TabIndex = 14;
			button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(Button1_Click);
			btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			btnMinimize.FlatAppearance.BorderSize = 0;
			btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnMinimize.ForeColor = System.Drawing.Color.White;
			btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
			btnMinimize.Location = new System.Drawing.Point(954, -1);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new System.Drawing.Size(30, 30);
			btnMinimize.TabIndex = 13;
			btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			btnMinimize.UseVisualStyleBackColor = true;
			btnMinimize.Click += new System.EventHandler(BtnMinimize_Click);
			pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(7, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(34, 27);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 16;
			pictureBox1.TabStop = false;
			bunifuCustomLabel1.AutoSize = true;
			bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
			bunifuCustomLabel1.Location = new System.Drawing.Point(43, 9);
			bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			bunifuCustomLabel1.Size = new System.Drawing.Size(259, 16);
			bunifuCustomLabel1.TabIndex = 7;
			bunifuCustomLabel1.Text = "MAX CARE - CHỨC NĂNG ĐỔI THÔNG TIN";
			bunifuDragControl2.Fixed = true;
			bunifuDragControl2.Horizontal = true;
			bunifuDragControl2.TargetControl = null;
			bunifuDragControl2.Vertical = true;
			bunifuCards1.BackColor = System.Drawing.Color.White;
			bunifuCards1.BorderRadius = 0;
			bunifuCards1.BottomSahddow = true;
			bunifuCards1.color = System.Drawing.Color.RoyalBlue;
			bunifuCards1.Controls.Add(pnlHeader);
			bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
			bunifuCards1.LeftSahddow = false;
			bunifuCards1.Location = new System.Drawing.Point(0, 0);
			bunifuCards1.Name = "bunifuCards1";
			bunifuCards1.RightSahddow = true;
			bunifuCards1.ShadowDepth = 20;
			bunifuCards1.Size = new System.Drawing.Size(986, 38);
			bunifuCards1.TabIndex = 10;
			panel3.BackColor = System.Drawing.SystemColors.Control;
			panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			panel3.Location = new System.Drawing.Point(0, 558);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(986, 26);
			panel3.TabIndex = 11;
			panel3.Paint += new System.Windows.Forms.PaintEventHandler(panel3_Paint);
			lblChoosed.AutoSize = true;
			lblChoosed.BackColor = System.Drawing.Color.White;
			lblChoosed.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
			lblChoosed.ForeColor = System.Drawing.Color.Maroon;
			lblChoosed.Location = new System.Drawing.Point(690, 514);
			lblChoosed.Name = "lblChoosed";
			lblChoosed.Size = new System.Drawing.Size(16, 16);
			lblChoosed.TabIndex = 120;
			lblChoosed.Text = "0";
			bunifuCustomLabel2.AutoSize = true;
			bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
			bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
			bunifuCustomLabel2.Location = new System.Drawing.Point(626, 514);
			bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			bunifuCustomLabel2.Size = new System.Drawing.Size(70, 16);
			bunifuCustomLabel2.TabIndex = 121;
			bunifuCustomLabel2.Text = "Đã chọn: ";
			lblCountAcc.AutoSize = true;
			lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
			lblCountAcc.ForeColor = System.Drawing.Color.Blue;
			lblCountAcc.Location = new System.Drawing.Point(807, 514);
			lblCountAcc.Name = "lblCountAcc";
			lblCountAcc.Size = new System.Drawing.Size(16, 16);
			lblCountAcc.TabIndex = 76;
			lblCountAcc.Text = "0";
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
			label7.Location = new System.Drawing.Point(765, 514);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(44, 16);
			label7.TabIndex = 77;
			label7.Text = "Tổng:";
			ctmsAcc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { chọnTấtCảToolStripMenuItem, bỏChọnTấtCảToolStripMenuItem, ctmsChonTrangThai, xóaToolStripMenuItem });
			ctmsAcc.Name = "ctmsAcc";
			ctmsAcc.Size = new System.Drawing.Size(160, 92);
			ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
			chọnTấtCảToolStripMenuItem.Name = "chọnTấtCảToolStripMenuItem";
			chọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			chọnTấtCảToolStripMenuItem.Text = "Chọn tất cả";
			chọnTấtCảToolStripMenuItem.Click += new System.EventHandler(chọnTấtCảToolStripMenuItem_Click_1);
			bỏChọnTấtCảToolStripMenuItem.Name = "bỏChọnTấtCảToolStripMenuItem";
			bỏChọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			bỏChọnTấtCảToolStripMenuItem.Text = "Bỏ chọn tất cả";
			bỏChọnTấtCảToolStripMenuItem.Click += new System.EventHandler(bỏChọnTấtCảToolStripMenuItem_Click_1);
			ctmsChonTrangThai.Name = "ctmsChonTrangThai";
			ctmsChonTrangThai.Size = new System.Drawing.Size(159, 22);
			ctmsChonTrangThai.Text = "Chọn tra\u0323ng tha\u0301i";
			ctmsChonTrangThai.Click += new System.EventHandler(ctmsChonTrangThai_Click);
			xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
			xóaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			xóaToolStripMenuItem.Text = "Xóa đã chọn";
			xóaToolStripMenuItem.Click += new System.EventHandler(xóaToolStripMenuItem_Click_1);
			dtgvAcc.AllowUserToAddRows = false;
			dtgvAcc.AllowUserToDeleteRows = false;
			dtgvAcc.AllowUserToResizeRows = false;
			dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgvAcc.Columns.AddRange(cChose, cStt, cId, cUid, cCookies, cName, cBirthday, cGender, cPassword, cFa2, cUseragent, cProxy, cInfo, cStatus);
			dtgvAcc.ContextMenuStrip = ctmsAcc;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
			dtgvAcc.Location = new System.Drawing.Point(5, 43);
			dtgvAcc.Name = "dtgvAcc";
			dtgvAcc.ReadOnly = true;
			dtgvAcc.RowHeadersVisible = false;
			dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			dtgvAcc.Size = new System.Drawing.Size(976, 465);
			dtgvAcc.TabIndex = 125;
			dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
			dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
			dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvAcc_KeyDown);
			btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			btnConfig.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
			btnConfig.Image = (System.Drawing.Image)resources.GetObject("btnConfig.Image");
			btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			btnConfig.Location = new System.Drawing.Point(235, 514);
			btnConfig.Name = "btnConfig";
			btnConfig.Size = new System.Drawing.Size(109, 40);
			btnConfig.TabIndex = 71;
			btnConfig.Text = "Cấu hình";
			btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btnConfig.UseVisualStyleBackColor = false;
			btnConfig.Click += new System.EventHandler(btnConfig_Click_1);
			btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
			btnPause.Enabled = false;
			btnPause.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
			btnPause.Image = (System.Drawing.Image)resources.GetObject("btnPause.Image");
			btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			btnPause.Location = new System.Drawing.Point(120, 514);
			btnPause.Name = "btnPause";
			btnPause.Size = new System.Drawing.Size(109, 40);
			btnPause.TabIndex = 70;
			btnPause.Text = "Tạm dừng";
			btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btnPause.UseVisualStyleBackColor = false;
			btnPause.Click += new System.EventHandler(btnPause_Click_1);
			btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
			btnStart.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
			btnStart.Image = (System.Drawing.Image)resources.GetObject("btnStart.Image");
			btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			btnStart.Location = new System.Drawing.Point(5, 514);
			btnStart.Name = "btnStart";
			btnStart.Size = new System.Drawing.Size(109, 40);
			btnStart.TabIndex = 69;
			btnStart.Text = "Bắt đầu";
			btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btnStart.UseVisualStyleBackColor = false;
			btnStart.Click += new System.EventHandler(btnShare_Click_1);
			button3.Cursor = System.Windows.Forms.Cursors.Hand;
			button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);

			button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			button3.Location = new System.Drawing.Point(350, 514);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(126, 40);
			button3.TabIndex = 71;
			button3.Text = "Ta\u0300i khoa\u0309n Lô\u0303i";
			button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			cChose.HeaderText = "Chọn";
			cChose.Name = "cChose";
			cChose.ReadOnly = true;
			cChose.Width = 40;
			cStt.HeaderText = "STT";
			cStt.Name = "cStt";
			cStt.ReadOnly = true;
			cStt.Width = 50;
			cId.HeaderText = "Id";
			cId.Name = "cId";
			cId.ReadOnly = true;
			cId.Visible = false;
			cId.Width = 90;
			cUid.HeaderText = "UID";
			cUid.Name = "cUid";
			cUid.ReadOnly = true;
			cUid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			cUid.Width = 70;
			cCookies.HeaderText = "Cookie";
			cCookies.Name = "cCookies";
			cCookies.ReadOnly = true;
			cCookies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			cCookies.Width = 60;
			cName.HeaderText = "Name";
			cName.Name = "cName";
			cName.ReadOnly = true;
			cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			cName.Width = 75;
			cBirthday.HeaderText = "Birthday";
			cBirthday.Name = "cBirthday";
			cBirthday.ReadOnly = true;
			cBirthday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			cBirthday.Width = 70;
			cGender.HeaderText = "Giới Tính";
			cGender.Name = "cGender";
			cGender.ReadOnly = true;
			cGender.Width = 80;
			cPassword.HeaderText = "Mật khẩu";
			cPassword.Name = "cPassword";
			cPassword.ReadOnly = true;
			cPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			cPassword.Width = 70;
			cFa2.HeaderText = "2FA";
			cFa2.Name = "cFa2";
			cFa2.ReadOnly = true;
			cFa2.Width = 40;
			cUseragent.HeaderText = "Useragent";
			cUseragent.Name = "cUseragent";
			cUseragent.ReadOnly = true;
			cUseragent.Width = 70;
			cProxy.HeaderText = "Proxy";
			cProxy.Name = "cProxy";
			cProxy.ReadOnly = true;
			cProxy.Width = 50;
			cInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			cInfo.HeaderText = "Tình Trạng";
			cInfo.Name = "cInfo";
			cInfo.ReadOnly = true;
			cInfo.Width = 90;
			cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			cStatus.HeaderText = "Trạng Thái";
			cStatus.Name = "cStatus";
			cStatus.ReadOnly = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			base.ClientSize = new System.Drawing.Size(986, 584);
			base.Controls.Add(lblChoosed);
			base.Controls.Add(dtgvAcc);
			base.Controls.Add(bunifuCustomLabel2);
			base.Controls.Add(lblCountAcc);
			base.Controls.Add(label7);
			base.Controls.Add(button3);
			base.Controls.Add(btnConfig);
			base.Controls.Add(btnPause);
			base.Controls.Add(btnStart);
			base.Controls.Add(panel3);
			base.Controls.Add(bunifuCards1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fChange";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "MAX CARE - CHỨC NĂNG POST";
			pnlHeader.ResumeLayout(false);
			pnlHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			bunifuCards1.ResumeLayout(false);
			ctmsAcc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}

}