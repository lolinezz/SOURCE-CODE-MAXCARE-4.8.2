using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// maxcare.fClearBackup
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.IO;
	using System.Linq;
	using System.Threading;
	using System.Windows.Forms;
	using Bunifu.Framework.UI;
	using maxcare;
	using maxcare.Helper;
	using MCommon;

	public class fclearBackup : Form
	{
		private JSON_Settings setting_general;

		private List<string> lstProfileRac = new List<string>();

		private IContainer components = null;

		private BunifuCards bunifuCards1;

		private Panel pnlHeader;

		private BunifuCustomLabel bunifuCustomLabel1;

		private Button btnMinimize;

		private Button btnCancel;

		private Button btnAdd;

		private BunifuDragControl bunifuDragControl1;

		private BunifuCustomLabel lblStatus;

		private PictureBox pictureBox1;

		public fclearBackup()
		{
			InitializeComponent();
			setting_general = new JSON_Settings("configGeneral");
			ChangeLanguage();
		}

		private void ChangeLanguage()
		{
			Language.GetValue(bunifuCustomLabel1);
			Language.GetValue(lblStatus);
			Language.GetValue(btnAdd);
			Language.GetValue(btnCancel);
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			btnAdd.Enabled = false;
			btnCancel.Enabled = false;
			LoadStatus(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), 0, lstProfileRac.Count));
			int iThread = 0;
			int maxThread = 20;
			int count = 0;
			string pathToBackup = FileHelper.GetPathToCurrentFolder() + "\\backup";
			new Thread((ThreadStart)delegate
			{
				try
				{
					int num = 0;
					while (num < lstProfileRac.Count)
					{
						if (iThread < maxThread)
						{
							Interlocked.Increment(ref iThread);
							int row = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string path = pathToBackup + "\\" + lstProfileRac[row];
									Directory.Delete(path, recursive: true);
									Interlocked.Increment(ref count);
									LoadStatus(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), count, lstProfileRac.Count));
									Interlocked.Decrement(ref iThread);
								}
								catch
								{
								}
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					while (iThread > 0)
					{
						MCommon.Common.DelayTime(1.0);
					}
					Invoke((Action)delegate
					{
						Close();
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã dọn dẹp file backup xong!"));
					});
				}
				catch
				{
				}
			}).Start();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		private List<string> GetListUidFromDatabase()
		{
			//Discarded unreachable code: IL_0075, IL_0082
			List<string> list = new List<string>();
			try
			{
				DataTable allAccountFromDatabase = CommonSQL.GetAllAccountFromDatabase();
				for (int i = 0; i < allAccountFromDatabase.Rows.Count; i++)
				{
					list.Add(allAccountFromDatabase.Rows[i]["uid"].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		private void LoadStatus(string content)
		{
			Invoke((Action)delegate
			{
				lblStatus.Text = content;
			});
		}

		private void fClearProfile_Load(object sender, EventArgs e)
		{
			new Thread((ThreadStart)delegate
			{
				try
				{
					List<string> list = Directory.GetDirectories(FileHelper.GetPathToCurrentFolder() + "\\backup").ToList();
					List<string> listUidFromDatabase = GetListUidFromDatabase();
					string text = "";
					for (int i = 0; i < list.Count; i++)
					{
						text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
						if (!listUidFromDatabase.Contains(text))
						{
							lstProfileRac.Add(text);
						}
					}
					if (lstProfileRac.Count > 0)
					{
						Invoke((Action)delegate
						{
							lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), lstProfileRac.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
							btnAdd.Visible = true;
							btnCancel.Visible = true;
						});
					}
					else
					{
						Invoke((Action)delegate
						{
							Close();
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Không có file backup rác!"));
						});
					}
				}
				catch
				{
				}
			}).Start();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maxcare.fClearBackup));
			bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			pnlHeader = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			btnMinimize = new System.Windows.Forms.Button();
			bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			btnCancel = new System.Windows.Forms.Button();
			btnAdd = new System.Windows.Forms.Button();
			bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
			lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
			bunifuCards1.SuspendLayout();
			pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			bunifuCards1.BackColor = System.Drawing.Color.White;
			bunifuCards1.BorderRadius = 0;
			bunifuCards1.BottomSahddow = true;
			bunifuCards1.color = System.Drawing.Color.SaddleBrown;
			bunifuCards1.Controls.Add(pnlHeader);
			bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
			bunifuCards1.LeftSahddow = false;
			bunifuCards1.Location = new System.Drawing.Point(0, 0);
			bunifuCards1.Name = "bunifuCards1";
			bunifuCards1.RightSahddow = true;
			bunifuCards1.ShadowDepth = 20;
			bunifuCards1.Size = new System.Drawing.Size(396, 38);
			bunifuCards1.TabIndex = 0;
			pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			pnlHeader.BackColor = System.Drawing.Color.White;
			pnlHeader.Controls.Add(pictureBox1);
			pnlHeader.Controls.Add(btnMinimize);
			pnlHeader.Controls.Add(bunifuCustomLabel1);
			pnlHeader.Location = new System.Drawing.Point(0, 5);
			pnlHeader.Name = "pnlHeader";
			pnlHeader.Size = new System.Drawing.Size(396, 32);
			pnlHeader.TabIndex = 9;
			pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(34, 27);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 17;
			pictureBox1.TabStop = false;
			btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			btnMinimize.FlatAppearance.BorderSize = 0;
			btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnMinimize.ForeColor = System.Drawing.Color.White;
			btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
			btnMinimize.Location = new System.Drawing.Point(364, 0);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new System.Drawing.Size(32, 32);
			btnMinimize.TabIndex = 9;
			btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			btnMinimize.UseVisualStyleBackColor = true;
			btnMinimize.Click += new System.EventHandler(BtnMinimize_Click);
			bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
			bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
			bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
			bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
			bunifuCustomLabel1.TabIndex = 1;
			bunifuCustomLabel1.Text = "Dọn dẹp backup";
			bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			btnCancel.BackColor = System.Drawing.Color.Maroon;
			btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnCancel.ForeColor = System.Drawing.Color.White;
			btnCancel.Location = new System.Drawing.Point(204, 105);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new System.Drawing.Size(92, 29);
			btnCancel.TabIndex = 4;
			btnCancel.Text = "Hủy";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Visible = false;
			btnCancel.Click += new System.EventHandler(BtnCancel_Click);
			btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
			btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			btnAdd.ForeColor = System.Drawing.Color.White;
			btnAdd.Location = new System.Drawing.Point(100, 105);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new System.Drawing.Size(92, 29);
			btnAdd.TabIndex = 3;
			btnAdd.Text = "Đồng ý";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Visible = false;
			btnAdd.Click += new System.EventHandler(BtnAdd_Click);
			bunifuDragControl1.Fixed = true;
			bunifuDragControl1.Horizontal = true;
			bunifuDragControl1.TargetControl = bunifuCustomLabel1;
			bunifuDragControl1.Vertical = true;
			lblStatus.BackColor = System.Drawing.Color.Transparent;
			lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
			lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblStatus.ForeColor = System.Drawing.Color.Black;
			lblStatus.Location = new System.Drawing.Point(-1, 57);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new System.Drawing.Size(396, 32);
			lblStatus.TabIndex = 21;
			lblStatus.Text = "Đang quét file backup...";
			lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			lblStatus.Click += new System.EventHandler(bunifuCustomLabel2_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(396, 145);
			base.Controls.Add(lblStatus);
			base.Controls.Add(btnCancel);
			base.Controls.Add(btnAdd);
			base.Controls.Add(bunifuCards1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fClearBackup";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "fAddFile";
			base.Load += new System.EventHandler(fClearProfile_Load);
			bunifuCards1.ResumeLayout(false);
			pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}
	}

}