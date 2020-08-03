namespace QLNS
{
    partial class frmSapXep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSapXep));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataHienThiDV = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua_ = new System.Windows.Forms.Button();
            this.btnXoa_ = new System.Windows.Forms.Button();
            this.cboxTenDV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataHienThiCM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.cboxChuyenMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaChuyenMon = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongSo = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxTrinhDo = new System.Windows.Forms.ComboBox();
            this.bntXoaTD = new System.Windows.Forms.Button();
            this.bntSuaTD = new System.Windows.Forms.Button();
            this.dataTrinhDo = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiDV)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiCM)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1460546211_DeleteRed.ico");
            this.imageList1.Images.SetKeyName(1, "chitiettour2.ico");
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPage3.Controls.Add(this.dataTrinhDo);
            this.tabPage3.Controls.Add(this.bntSuaTD);
            this.tabPage3.Controls.Add(this.bntXoaTD);
            this.tabPage3.Controls.Add(this.cboxTrinhDo);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 74);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(391, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TRÌNH ĐỘ      ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPage2.Controls.Add(this.dataHienThiDV);
            this.tabPage2.Controls.Add(this.btnSua_);
            this.tabPage2.Controls.Add(this.btnXoa_);
            this.tabPage2.Controls.Add(this.cboxTenDV);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtMaDV);
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ĐƠN VỊ       ";
            // 
            // dataHienThiDV
            // 
            this.dataHienThiDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThiDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dataHienThiDV.Location = new System.Drawing.Point(-4, 228);
            this.dataHienThiDV.Name = "dataHienThiDV";
            this.dataHienThiDV.ReadOnly = true;
            this.dataHienThiDV.RowTemplate.Height = 24;
            this.dataHienThiDV.Size = new System.Drawing.Size(399, 339);
            this.dataHienThiDV.TabIndex = 3;
            this.dataHienThiDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataHienThiDV_MouseClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNV";
            this.Column4.HeaderText = "Mã NV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HoTen";
            this.Column5.HeaderText = "Họ Tên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 251;
            // 
            // btnSua_
            // 
            this.btnSua_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_.ForeColor = System.Drawing.Color.Blue;
            this.btnSua_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_.ImageIndex = 1;
            this.btnSua_.ImageList = this.imageList1;
            this.btnSua_.Location = new System.Drawing.Point(207, 131);
            this.btnSua_.Name = "btnSua_";
            this.btnSua_.Size = new System.Drawing.Size(165, 79);
            this.btnSua_.TabIndex = 1;
            this.btnSua_.Text = "Sửa";
            this.btnSua_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_.UseVisualStyleBackColor = true;
            this.btnSua_.Click += new System.EventHandler(this.bntSua__Click);
            // 
            // btnXoa_
            // 
            this.btnXoa_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_.ImageIndex = 0;
            this.btnXoa_.ImageList = this.imageList1;
            this.btnXoa_.Location = new System.Drawing.Point(12, 131);
            this.btnXoa_.Name = "btnXoa_";
            this.btnXoa_.Size = new System.Drawing.Size(165, 79);
            this.btnXoa_.TabIndex = 1;
            this.btnXoa_.Text = "Xóa";
            this.btnXoa_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_.UseVisualStyleBackColor = true;
            this.btnXoa_.Click += new System.EventHandler(this.bntXoa__Click);
            // 
            // cboxTenDV
            // 
            this.cboxTenDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTenDV.FormattingEnabled = true;
            this.cboxTenDV.Items.AddRange(new object[] {
            "Văn Phòng",
            "Phòng Tổ chức lao động",
            "Phòng Kế toán - Tài chính",
            "Phòng Vật tư",
            "Phòng Kế hoạch - Tiêu thụ",
            "Phòng Điều hành sản xuất",
            "Phòng Thanh tra BVQS"});
            this.cboxTenDV.Location = new System.Drawing.Point(83, 81);
            this.cboxTenDV.Name = "cboxTenDV";
            this.cboxTenDV.Size = new System.Drawing.Size(289, 28);
            this.cboxTenDV.TabIndex = 2;
            this.cboxTenDV.SelectedIndexChanged += new System.EventHandler(this.cboxTenDV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ĐV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên ĐV:";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Location = new System.Drawing.Point(83, 38);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(289, 27);
            this.txtMaDV.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabPage1.Controls.Add(this.dataHienThiCM);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.bntXoa);
            this.tabPage1.Controls.Add(this.cboxChuyenMon);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMaChuyenMon);
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CHUYÊN MÔN       ";
            // 
            // dataHienThiCM
            // 
            this.dataHienThiCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThiCM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataHienThiCM.Location = new System.Drawing.Point(-4, 228);
            this.dataHienThiCM.Name = "dataHienThiCM";
            this.dataHienThiCM.ReadOnly = true;
            this.dataHienThiCM.RowTemplate.Height = 24;
            this.dataHienThiCM.Size = new System.Drawing.Size(399, 339);
            this.dataHienThiCM.TabIndex = 1;
            this.dataHienThiCM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataHienThiCM_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChuyenMon";
            this.Column3.HeaderText = "Chuyên môn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 121;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageIndex = 1;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(207, 131);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 79);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSuaCM_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.ForeColor = System.Drawing.Color.Blue;
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoa.ImageIndex = 0;
            this.bntXoa.ImageList = this.imageList1;
            this.bntXoa.Location = new System.Drawing.Point(12, 131);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(165, 79);
            this.bntXoa.TabIndex = 7;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.btnXoaCM_Click);
            // 
            // cboxChuyenMon
            // 
            this.cboxChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxChuyenMon.FormattingEnabled = true;
            this.cboxChuyenMon.Items.AddRange(new object[] {
            "CEO",
            "Quản Lý",
            "Bán Hàng",
            "Kế Toán"});
            this.cboxChuyenMon.Location = new System.Drawing.Point(83, 81);
            this.cboxChuyenMon.Name = "cboxChuyenMon";
            this.cboxChuyenMon.Size = new System.Drawing.Size(289, 28);
            this.cboxChuyenMon.TabIndex = 6;
            this.cboxChuyenMon.SelectedIndexChanged += new System.EventHandler(this.cboxChuyenMon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã CM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên CM:";
            // 
            // txtMaChuyenMon
            // 
            this.txtMaChuyenMon.Enabled = false;
            this.txtMaChuyenMon.Location = new System.Drawing.Point(83, 38);
            this.txtMaChuyenMon.Name = "txtMaChuyenMon";
            this.txtMaChuyenMon.Size = new System.Drawing.Size(289, 27);
            this.txtMaChuyenMon.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 70);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng số:";
            // 
            // txtTongSo
            // 
            this.txtTongSo.BackColor = System.Drawing.Color.White;
            this.txtTongSo.Enabled = false;
            this.txtTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSo.ForeColor = System.Drawing.Color.Red;
            this.txtTongSo.Location = new System.Drawing.Point(99, 660);
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(91, 30);
            this.txtTongSo.TabIndex = 2;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(277, 666);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(0, 20);
            this.lbMaNV.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 666);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã NV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên TĐ:";
            // 
            // cboxTrinhDo
            // 
            this.cboxTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTrinhDo.FormattingEnabled = true;
            this.cboxTrinhDo.Items.AddRange(new object[] {
            "ĐH",
            "CĐ",
            "CH"});
            this.cboxTrinhDo.Location = new System.Drawing.Point(83, 81);
            this.cboxTrinhDo.Name = "cboxTrinhDo";
            this.cboxTrinhDo.Size = new System.Drawing.Size(289, 28);
            this.cboxTrinhDo.TabIndex = 1;
            this.cboxTrinhDo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bntXoaTD
            // 
            this.bntXoaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoaTD.ForeColor = System.Drawing.Color.Blue;
            this.bntXoaTD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntXoaTD.ImageIndex = 0;
            this.bntXoaTD.ImageList = this.imageList1;
            this.bntXoaTD.Location = new System.Drawing.Point(12, 131);
            this.bntXoaTD.Name = "bntXoaTD";
            this.bntXoaTD.Size = new System.Drawing.Size(165, 79);
            this.bntXoaTD.TabIndex = 2;
            this.bntXoaTD.Text = "Xóa";
            this.bntXoaTD.UseVisualStyleBackColor = true;
            this.bntXoaTD.Click += new System.EventHandler(this.bntXoaTD_Click);
            // 
            // bntSuaTD
            // 
            this.bntSuaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSuaTD.ForeColor = System.Drawing.Color.Blue;
            this.bntSuaTD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSuaTD.ImageIndex = 1;
            this.bntSuaTD.ImageList = this.imageList1;
            this.bntSuaTD.Location = new System.Drawing.Point(207, 131);
            this.bntSuaTD.Name = "bntSuaTD";
            this.bntSuaTD.Size = new System.Drawing.Size(165, 79);
            this.bntSuaTD.TabIndex = 2;
            this.bntSuaTD.Text = "Sửa";
            this.bntSuaTD.UseVisualStyleBackColor = true;
            this.bntSuaTD.Click += new System.EventHandler(this.bntSuaTD_Click);
            // 
            // dataTrinhDo
            // 
            this.dataTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dataTrinhDo.Location = new System.Drawing.Point(-4, 228);
            this.dataTrinhDo.Name = "dataTrinhDo";
            this.dataTrinhDo.RowTemplate.Height = 24;
            this.dataTrinhDo.Size = new System.Drawing.Size(399, 339);
            this.dataTrinhDo.TabIndex = 3;
            this.dataTrinhDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataTrinhDo_MouseClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaNV";
            this.Column6.HeaderText = "Mã NV";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "HoTen";
            this.Column7.HeaderText = "Họ Tên";
            this.Column7.Name = "Column7";
            this.Column7.Width = 251;
            // 
            // frmSapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 689);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.txtTongSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSapXep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí";
            this.Load += new System.EventHandler(this.frmDonVi_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiDV)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiCM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboxTenDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataHienThiCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cboxChuyenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaChuyenMon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataHienThiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongSo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button btnSua_;
        private System.Windows.Forms.Button btnXoa_;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxTrinhDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button bntSuaTD;
        private System.Windows.Forms.Button bntXoaTD;
    }
}