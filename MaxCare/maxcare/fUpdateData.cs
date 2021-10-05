using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// maxcare.fUpdateData
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Drawing;
	using System.Windows.Forms;
	using Bunifu.Framework.UI;
	using maxcare;
	using maxcare.Helper;
	using MCommon;
	using MetroFramework;
	using MetroFramework.Controls;

	public class fupdateData : Form
	{
		private fmain main;

		private IContainer components = null;

		private BunifuCards bunifuCards1;

		private Panel pnlHeader;

		private BunifuCustomLabel bunifuCustomLabel1;

		private Button btnMinimize;

		private MetroComboBox cbbTypeUpdate;

		private Label label1;

		private TextBox txbData;

		private Label label2;

		private Button btnCancel;

		private Button btnAdd;

		private PictureBox pictureBox1;

		private Label label3;

		private ComboBox cbbTypeProxy;

		public fupdateData(fmain main, string mode)
		{
			InitializeComponent();
			ChangeLanguage();
			this.main = main;
			cbbTypeUpdate.Text = mode;
			cbbTypeProxy.SelectedIndex = 0;
		}

		private void ChangeLanguage()
		{
			Language.GetValue(bunifuCustomLabel1);
			Language.GetValue(label1);
			Language.GetValue(label2);
			Language.GetValue(label3);
			Language.GetValue(btnAdd);
			Language.GetValue(btnCancel);
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0ee2, IL_0f14
			try
			{
				bool flag = false;
				if (txbData.Text.Equals("") || txbData.Text.Equals("|"))
				{
					if (MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), main.CountChooseRowInDatagridview())) == DialogResult.Yes)
					{
						flag = true;
					}
				}
				else if (MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), main.CountChooseRowInDatagridview())) == DialogResult.Yes)
				{
					flag = true;
				}
				if (!flag)
				{
					return;
				}
				List<string> list = new List<string>();
				string text = txbData.Text;
				for (int i = 0; i < main.dtgvAcc.Rows.Count; i++)
				{
					if (Convert.ToBoolean(main.dtgvAcc.Rows[i].Cells["cChose"].Value))
					{
						list.Add(main.GetCellAccount(i, "cId"));
					}
				}
				switch (cbbTypeUpdate.Text)
				{
					case "Token":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "token", text))
							{
								break;
							}
							for (int num3 = 0; num3 < main.dtgvAcc.Rows.Count; num3++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[num3].Cells["cChose"].Value))
								{
									main.SetCellAccount(num3, "cToken", text);
								}
							}
							break;
						}
					case "Cookie":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "cookie1", text))
							{
								break;
							}
							for (int n = 0; n < main.dtgvAcc.Rows.Count; n++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[n].Cells["cChose"].Value))
								{
									main.SetCellAccount(n, "cCookies", text);
								}
							}
							break;
						}
					case "Password":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "pass", text))
							{
								break;
							}
							for (int num5 = 0; num5 < main.dtgvAcc.Rows.Count; num5++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[num5].Cells["cChose"].Value))
								{
									main.SetCellAccount(num5, "cPassword", text);
								}
							}
							break;
						}
					case "2FA":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "fa2", text))
							{
								break;
							}
							for (int num2 = 0; num2 < main.dtgvAcc.Rows.Count; num2++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[num2].Cells["cChose"].Value))
								{
									main.SetCellAccount(num2, "cFa2", text);
								}
							}
							break;
						}
					case "Birthday":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "birthday", text))
							{
								break;
							}
							for (int num = 0; num < main.dtgvAcc.Rows.Count; num++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[num].Cells["cChose"].Value))
								{
									main.SetCellAccount(num, "cBirthday", text);
								}
							}
							break;
						}
					case "Useragent":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "useragent", text))
							{
								break;
							}
							for (int k = 0; k < main.dtgvAcc.Rows.Count; k++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[k].Cells["cChose"].Value))
								{
									main.SetCellAccount(k, "cUseragent", text);
								}
							}
							break;
						}
					case "Proxy":
						{
							int selectedIndex = cbbTypeProxy.SelectedIndex;
							string text2 = ((text == "") ? "" : (text + "*" + selectedIndex));
							if (!CommonSQL.UpdateFieldToAccount(list, "proxy", text2))
							{
								break;
							}
							for (int l = 0; l < main.dtgvAcc.Rows.Count; l++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[l].Cells["cChose"].Value))
								{
									main.SetCellAccount(l, "cProxy", text2);
								}
							}
							break;
						}
					case "Notes":
						{
							if (!CommonSQL.UpdateFieldToAccount(list, "ghiChu", text))
							{
								break;
							}
							for (int num4 = 0; num4 < main.dtgvAcc.Rows.Count; num4++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[num4].Cells["cChose"].Value))
								{
									main.SetCellAccount(num4, "cGhiChu", text);
								}
							}
							break;
						}
					case "Mail|pass":
						{
							if (text.Split('|').Length != 2)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lo\u0300ng nhâ\u0323p la\u0323i đi\u0323nh da\u0323ng Mail|Pass Mail!"), 3);
								return;
							}
							if (!CommonSQL.UpdateMultiFieldToAccount(list, "email|passmail", text))
							{
								break;
							}
							for (int m = 0; m < main.dtgvAcc.Rows.Count; m++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[m].Cells["cChose"].Value))
								{
									main.SetCellAccount(m, "cEmail", text.Split('|')[0]);
									main.SetCellAccount(m, "cPassMail", text.Split('|')[1]);
								}
							}
							break;
						}
					case "PassMail":
						{
							if (!CommonSQL.UpdateMultiFieldToAccount(list, "PassMail", text))
							{
								break;
							}
							for (int j = 0; j < main.dtgvAcc.Rows.Count; j++)
							{
								if (Convert.ToBoolean(main.dtgvAcc.Rows[j].Cells["cChose"].Value))
								{
									main.SetCellAccount(j, "cPassMail", text);
								}
							}
							break;
						}
				}
				Close();
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thử lại sau!"), 2);
			}
		}

		private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool visible = cbbTypeUpdate.Text == "Proxy";
			label3.Visible = visible;
			cbbTypeProxy.Visible = visible;
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbbTypeUpdate = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(416, 38);
            this.bunifuCards1.TabIndex = 12;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(416, 32);
            this.pnlHeader.TabIndex = 9;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(382, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(416, 32);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTypeUpdate
            // 
            this.cbbTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeUpdate.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbbTypeUpdate.FormattingEnabled = true;
            this.cbbTypeUpdate.ItemHeight = 19;
            this.cbbTypeUpdate.Items.AddRange(new object[] {
            "Token",
            "Cookie",
            "Password",
            "Mail|pass",
            "PassMail",
            "2FA",
            "Birthday",
            "Useragent",
            "Proxy",
            "Notes"});
            this.cbbTypeUpdate.Location = new System.Drawing.Point(146, 43);
            this.cbbTypeUpdate.Name = "cbbTypeUpdate";
            this.cbbTypeUpdate.Size = new System.Drawing.Size(238, 25);
            this.cbbTypeUpdate.TabIndex = 13;
            this.cbbTypeUpdate.UseSelectable = true;
            this.cbbTypeUpdate.SelectedIndexChanged += new System.EventHandler(this.cbbTypeUpdate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dữ liệu cập nhật:";
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(146, 79);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(238, 23);
            this.txbData.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập dữ liệu:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(209, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(111, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại proxy:";
            // 
            // cbbTypeProxy
            // 
            this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeProxy.FormattingEnabled = true;
            this.cbbTypeProxy.Items.AddRange(new object[] {
            "HTTP",
            "Sock5"});
            this.cbbTypeProxy.Location = new System.Drawing.Point(146, 108);
            this.cbbTypeProxy.Name = "cbbTypeProxy";
            this.cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
            this.cbbTypeProxy.TabIndex = 124;
            // 
            // fupdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 188);
            this.Controls.Add(this.cbbTypeProxy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTypeUpdate);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fupdateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fUpdateData";
            this.Load += new System.EventHandler(this.fupdateData_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void fupdateData_Load(object sender, EventArgs e)
        {

        }
    }

}