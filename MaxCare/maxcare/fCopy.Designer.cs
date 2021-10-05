namespace maxcare
{
	// Token: 0x02000123 RID: 291
	public partial class fCopy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x001E348C File Offset: 0x001E168C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x001E34EC File Offset: 0x001E16EC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCopy));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.cbbDinhDang1 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang2 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang3 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang4 = new global::System.Windows.Forms.ComboBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang5 = new global::System.Windows.Forms.ComboBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang6 = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang7 = new global::System.Windows.Forms.ComboBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang9 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang8 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			base.SuspendLayout();
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(1037, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(1037, 32);
			this.pnlHeader.TabIndex = 9;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;

			this.btnMinimize.Location = new global::System.Drawing.Point(1005, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 32);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(1037, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Tùy chọn định dạng sao chép";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(575, 120);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(467, 120);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Xác nhận";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label1.Location = new global::System.Drawing.Point(20, 66);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(132, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Chọn định dạng copy:";
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.cbbDinhDang1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang1.FormattingEnabled = true;
			this.cbbDinhDang1.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang1.Location = new global::System.Drawing.Point(158, 65);
			this.cbbDinhDang1.Name = "cbbDinhDang1";
			this.cbbDinhDang1.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang1.TabIndex = 42;
			this.cbbDinhDang2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang2.FormattingEnabled = true;
			this.cbbDinhDang2.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang2.Location = new global::System.Drawing.Point(255, 65);
			this.cbbDinhDang2.Name = "cbbDinhDang2";
			this.cbbDinhDang2.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang2.TabIndex = 43;
			this.cbbDinhDang3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang3.FormattingEnabled = true;
			this.cbbDinhDang3.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang3.Location = new global::System.Drawing.Point(352, 65);
			this.cbbDinhDang3.Name = "cbbDinhDang3";
			this.cbbDinhDang3.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang3.TabIndex = 44;
			this.cbbDinhDang4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang4.FormattingEnabled = true;
			this.cbbDinhDang4.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang4.Location = new global::System.Drawing.Point(449, 65);
			this.cbbDinhDang4.Name = "cbbDinhDang4";
			this.cbbDinhDang4.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang4.TabIndex = 45;
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.Location = new global::System.Drawing.Point(721, 67);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(19, 19);
			this.label14.TabIndex = 49;
			this.label14.Text = "|";
			this.cbbDinhDang5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang5.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang5.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang5.FormattingEnabled = true;
			this.cbbDinhDang5.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang5.Location = new global::System.Drawing.Point(546, 65);
			this.cbbDinhDang5.Name = "cbbDinhDang5";
			this.cbbDinhDang5.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang5.TabIndex = 46;
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.Location = new global::System.Drawing.Point(624, 67);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(19, 19);
			this.label13.TabIndex = 50;
			this.label13.Text = "|";
			this.cbbDinhDang6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang6.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang6.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang6.FormattingEnabled = true;
			this.cbbDinhDang6.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang6.Location = new global::System.Drawing.Point(643, 65);
			this.cbbDinhDang6.Name = "cbbDinhDang6";
			this.cbbDinhDang6.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang6.TabIndex = 47;
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.Location = new global::System.Drawing.Point(527, 67);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(19, 19);
			this.label12.TabIndex = 51;
			this.label12.Text = "|";
			this.cbbDinhDang7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang7.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang7.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang7.FormattingEnabled = true;
			this.cbbDinhDang7.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang7.Location = new global::System.Drawing.Point(740, 65);
			this.cbbDinhDang7.Name = "cbbDinhDang7";
			this.cbbDinhDang7.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang7.TabIndex = 48;
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(430, 67);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(19, 19);
			this.label11.TabIndex = 52;
			this.label11.Text = "|";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(236, 67);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(19, 19);
			this.label9.TabIndex = 53;
			this.label9.Text = "|";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(333, 67);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(19, 19);
			this.label10.TabIndex = 54;
			this.label10.Text = "|";
			this.cbbDinhDang9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang9.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang9.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang9.FormattingEnabled = true;
			this.cbbDinhDang9.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang9.Location = new global::System.Drawing.Point(934, 65);
			this.cbbDinhDang9.Name = "cbbDinhDang9";
			this.cbbDinhDang9.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang9.TabIndex = 48;
			this.cbbDinhDang8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang8.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang8.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbDinhDang8.FormattingEnabled = true;
			this.cbbDinhDang8.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy",
				"Tên",
				"Giới tính",
				"Theo dõi",
				"Bạn bè",
				"Nhóm",
				"Ngày sinh",
				"Ngày tạo",
				"Ghi chú"
			});
			this.cbbDinhDang8.Location = new global::System.Drawing.Point(837, 65);
			this.cbbDinhDang8.Name = "cbbDinhDang8";
			this.cbbDinhDang8.Size = new global::System.Drawing.Size(78, 24);
			this.cbbDinhDang8.TabIndex = 47;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(818, 67);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(19, 19);
			this.label2.TabIndex = 50;
			this.label2.Text = "|";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(915, 67);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(19, 19);
			this.label3.TabIndex = 49;
			this.label3.Text = "|";
			this.button1.BackColor = global::System.Drawing.Color.DarkOrange;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(330, 120);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(121, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "Reset định dạng";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1037, 165);
			base.Controls.Add(this.cbbDinhDang1);
			base.Controls.Add(this.cbbDinhDang2);
			base.Controls.Add(this.cbbDinhDang3);
			base.Controls.Add(this.cbbDinhDang4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.cbbDinhDang5);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.cbbDinhDang8);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.cbbDinhDang6);
			base.Controls.Add(this.cbbDinhDang9);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.cbbDinhDang7);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fCopy";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fCopy_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040015A8 RID: 5544
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040015A9 RID: 5545
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040015AA RID: 5546
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040015AB RID: 5547
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040015AC RID: 5548
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040015AD RID: 5549
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040015AE RID: 5550
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040015AF RID: 5551
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040015B0 RID: 5552
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040015B1 RID: 5553
		private global::System.Windows.Forms.ComboBox cbbDinhDang1;

		// Token: 0x040015B2 RID: 5554
		private global::System.Windows.Forms.ComboBox cbbDinhDang2;

		// Token: 0x040015B3 RID: 5555
		private global::System.Windows.Forms.ComboBox cbbDinhDang3;

		// Token: 0x040015B4 RID: 5556
		private global::System.Windows.Forms.ComboBox cbbDinhDang4;

		// Token: 0x040015B5 RID: 5557
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040015B6 RID: 5558
		private global::System.Windows.Forms.ComboBox cbbDinhDang5;

		// Token: 0x040015B7 RID: 5559
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040015B8 RID: 5560
		private global::System.Windows.Forms.ComboBox cbbDinhDang6;

		// Token: 0x040015B9 RID: 5561
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040015BA RID: 5562
		private global::System.Windows.Forms.ComboBox cbbDinhDang7;

		// Token: 0x040015BB RID: 5563
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040015BC RID: 5564
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040015BD RID: 5565
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040015BE RID: 5566
		private global::System.Windows.Forms.ComboBox cbbDinhDang9;

		// Token: 0x040015BF RID: 5567
		private global::System.Windows.Forms.ComboBox cbbDinhDang8;

		// Token: 0x040015C0 RID: 5568
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040015C1 RID: 5569
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040015C2 RID: 5570
		private global::System.Windows.Forms.Button button1;
	}
}
