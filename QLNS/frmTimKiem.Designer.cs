namespace QLNS
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNgaySinh = new System.Windows.Forms.RadioButton();
            this.radNgayNhapLuong = new System.Windows.Forms.RadioButton();
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.radLuongCB = new System.Windows.Forms.RadioButton();
            this.radNgaySuaLuong = new System.Windows.Forms.RadioButton();
            this.radChuyenMon = new System.Windows.Forms.RadioButton();
            this.radNgayCapBHXH = new System.Windows.Forms.RadioButton();
            this.radQuocTich = new System.Windows.Forms.RadioButton();
            this.radTDHV = new System.Windows.Forms.RadioButton();
            this.radDiaChi = new System.Windows.Forms.RadioButton();
            this.radDonVi = new System.Windows.Forms.RadioButton();
            this.radTenNV = new System.Windows.Forms.RadioButton();
            this.radDanToc = new System.Windows.Forms.RadioButton();
            this.radNoiCapBHXH = new System.Windows.Forms.RadioButton();
            this.radTonGiao = new System.Windows.Forms.RadioButton();
            this.radNoiSinh = new System.Windows.Forms.RadioButton();
            this.radNoiDKKCB = new System.Windows.Forms.RadioButton();
            this.radSDT = new System.Windows.Forms.RadioButton();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.radGioiTinh = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataTimKiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKQTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimKiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(521, 42);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.radNgaySinh);
            this.panel1.Controls.Add(this.radNgayNhapLuong);
            this.panel1.Controls.Add(this.radMaNV);
            this.panel1.Controls.Add(this.radLuongCB);
            this.panel1.Controls.Add(this.radNgaySuaLuong);
            this.panel1.Controls.Add(this.radChuyenMon);
            this.panel1.Controls.Add(this.radNgayCapBHXH);
            this.panel1.Controls.Add(this.radQuocTich);
            this.panel1.Controls.Add(this.radTDHV);
            this.panel1.Controls.Add(this.radDiaChi);
            this.panel1.Controls.Add(this.radDonVi);
            this.panel1.Controls.Add(this.radTenNV);
            this.panel1.Controls.Add(this.radDanToc);
            this.panel1.Controls.Add(this.radNoiCapBHXH);
            this.panel1.Controls.Add(this.radTonGiao);
            this.panel1.Controls.Add(this.radNoiSinh);
            this.panel1.Controls.Add(this.radNoiDKKCB);
            this.panel1.Controls.Add(this.radSDT);
            this.panel1.Controls.Add(this.radEmail);
            this.panel1.Controls.Add(this.radGioiTinh);
            this.panel1.Location = new System.Drawing.Point(6, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 278);
            this.panel1.TabIndex = 3;
            // 
            // radNgaySinh
            // 
            this.radNgaySinh.AutoSize = true;
            this.radNgaySinh.Location = new System.Drawing.Point(407, 3);
            this.radNgaySinh.Name = "radNgaySinh";
            this.radNgaySinh.Size = new System.Drawing.Size(202, 24);
            this.radNgaySinh.TabIndex = 2;
            this.radNgaySinh.TabStop = true;
            this.radNgaySinh.Text = "Ngày Sinh(YY/MM/DD)";
            this.radNgaySinh.UseVisualStyleBackColor = true;
            // 
            // radNgayNhapLuong
            // 
            this.radNgayNhapLuong.AutoSize = true;
            this.radNgayNhapLuong.Location = new System.Drawing.Point(407, 33);
            this.radNgayNhapLuong.Name = "radNgayNhapLuong";
            this.radNgayNhapLuong.Size = new System.Drawing.Size(163, 24);
            this.radNgayNhapLuong.TabIndex = 2;
            this.radNgayNhapLuong.TabStop = true;
            this.radNgayNhapLuong.Text = "Ngày Nhập Lương";
            this.radNgayNhapLuong.UseVisualStyleBackColor = true;
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.Location = new System.Drawing.Point(33, 3);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(81, 24);
            this.radMaNV.TabIndex = 2;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Mã NV";
            this.radMaNV.UseVisualStyleBackColor = true;
            // 
            // radLuongCB
            // 
            this.radLuongCB.AutoSize = true;
            this.radLuongCB.Location = new System.Drawing.Point(230, 3);
            this.radLuongCB.Name = "radLuongCB";
            this.radLuongCB.Size = new System.Drawing.Size(137, 24);
            this.radLuongCB.TabIndex = 2;
            this.radLuongCB.TabStop = true;
            this.radLuongCB.Text = "Lương Cơ Bản";
            this.radLuongCB.UseVisualStyleBackColor = true;
            // 
            // radNgaySuaLuong
            // 
            this.radNgaySuaLuong.AutoSize = true;
            this.radNgaySuaLuong.Location = new System.Drawing.Point(407, 63);
            this.radNgaySuaLuong.Name = "radNgaySuaLuong";
            this.radNgaySuaLuong.Size = new System.Drawing.Size(153, 24);
            this.radNgaySuaLuong.TabIndex = 2;
            this.radNgaySuaLuong.TabStop = true;
            this.radNgaySuaLuong.Text = "Ngày Sửa Lương";
            this.radNgaySuaLuong.UseVisualStyleBackColor = true;
            // 
            // radChuyenMon
            // 
            this.radChuyenMon.AutoSize = true;
            this.radChuyenMon.Location = new System.Drawing.Point(33, 123);
            this.radChuyenMon.Name = "radChuyenMon";
            this.radChuyenMon.Size = new System.Drawing.Size(123, 24);
            this.radChuyenMon.TabIndex = 2;
            this.radChuyenMon.TabStop = true;
            this.radChuyenMon.Text = "Chuyên Môn";
            this.radChuyenMon.UseVisualStyleBackColor = true;
            // 
            // radNgayCapBHXH
            // 
            this.radNgayCapBHXH.AutoSize = true;
            this.radNgayCapBHXH.Location = new System.Drawing.Point(407, 93);
            this.radNgayCapBHXH.Name = "radNgayCapBHXH";
            this.radNgayCapBHXH.Size = new System.Drawing.Size(157, 24);
            this.radNgayCapBHXH.TabIndex = 2;
            this.radNgayCapBHXH.TabStop = true;
            this.radNgayCapBHXH.Text = "Ngày Cấp BHXH";
            this.radNgayCapBHXH.UseVisualStyleBackColor = true;
            // 
            // radQuocTich
            // 
            this.radQuocTich.AutoSize = true;
            this.radQuocTich.Location = new System.Drawing.Point(33, 243);
            this.radQuocTich.Name = "radQuocTich";
            this.radQuocTich.Size = new System.Drawing.Size(107, 24);
            this.radQuocTich.TabIndex = 2;
            this.radQuocTich.TabStop = true;
            this.radQuocTich.Text = "Quốc Tịch";
            this.radQuocTich.UseVisualStyleBackColor = true;
            // 
            // radTDHV
            // 
            this.radTDHV.AutoSize = true;
            this.radTDHV.Location = new System.Drawing.Point(33, 153);
            this.radTDHV.Name = "radTDHV";
            this.radTDHV.Size = new System.Drawing.Size(123, 24);
            this.radTDHV.TabIndex = 2;
            this.radTDHV.TabStop = true;
            this.radTDHV.Text = "Trình Độ HV";
            this.radTDHV.UseVisualStyleBackColor = true;
            // 
            // radDiaChi
            // 
            this.radDiaChi.AutoSize = true;
            this.radDiaChi.Location = new System.Drawing.Point(33, 93);
            this.radDiaChi.Name = "radDiaChi";
            this.radDiaChi.Size = new System.Drawing.Size(85, 24);
            this.radDiaChi.TabIndex = 2;
            this.radDiaChi.TabStop = true;
            this.radDiaChi.Text = "Địa Chỉ";
            this.radDiaChi.UseVisualStyleBackColor = true;
            // 
            // radDonVi
            // 
            this.radDonVi.AutoSize = true;
            this.radDonVi.Location = new System.Drawing.Point(230, 33);
            this.radDonVi.Name = "radDonVi";
            this.radDonVi.Size = new System.Drawing.Size(108, 24);
            this.radDonVi.TabIndex = 2;
            this.radDonVi.TabStop = true;
            this.radDonVi.Text = "Mã Đơn Vị";
            this.radDonVi.UseVisualStyleBackColor = true;
            // 
            // radTenNV
            // 
            this.radTenNV.AutoSize = true;
            this.radTenNV.Location = new System.Drawing.Point(33, 33);
            this.radTenNV.Name = "radTenNV";
            this.radTenNV.Size = new System.Drawing.Size(86, 24);
            this.radTenNV.TabIndex = 2;
            this.radTenNV.TabStop = true;
            this.radTenNV.Text = "Tên NV";
            this.radTenNV.UseVisualStyleBackColor = true;
            // 
            // radDanToc
            // 
            this.radDanToc.AutoSize = true;
            this.radDanToc.Location = new System.Drawing.Point(33, 183);
            this.radDanToc.Name = "radDanToc";
            this.radDanToc.Size = new System.Drawing.Size(94, 24);
            this.radDanToc.TabIndex = 2;
            this.radDanToc.TabStop = true;
            this.radDanToc.Text = "Dân Tộc";
            this.radDanToc.UseVisualStyleBackColor = true;
            // 
            // radNoiCapBHXH
            // 
            this.radNoiCapBHXH.AutoSize = true;
            this.radNoiCapBHXH.Location = new System.Drawing.Point(230, 63);
            this.radNoiCapBHXH.Name = "radNoiCapBHXH";
            this.radNoiCapBHXH.Size = new System.Drawing.Size(144, 24);
            this.radNoiCapBHXH.TabIndex = 2;
            this.radNoiCapBHXH.TabStop = true;
            this.radNoiCapBHXH.Text = "Nơi Cấp BHXH";
            this.radNoiCapBHXH.UseVisualStyleBackColor = true;
            // 
            // radTonGiao
            // 
            this.radTonGiao.AutoSize = true;
            this.radTonGiao.Location = new System.Drawing.Point(32, 213);
            this.radTonGiao.Name = "radTonGiao";
            this.radTonGiao.Size = new System.Drawing.Size(98, 24);
            this.radTonGiao.TabIndex = 2;
            this.radTonGiao.TabStop = true;
            this.radTonGiao.Text = "Tôn Giáo";
            this.radTonGiao.UseVisualStyleBackColor = true;
            // 
            // radNoiSinh
            // 
            this.radNoiSinh.AutoSize = true;
            this.radNoiSinh.Location = new System.Drawing.Point(33, 63);
            this.radNoiSinh.Name = "radNoiSinh";
            this.radNoiSinh.Size = new System.Drawing.Size(93, 24);
            this.radNoiSinh.TabIndex = 2;
            this.radNoiSinh.TabStop = true;
            this.radNoiSinh.Text = "Nơi Sinh";
            this.radNoiSinh.UseVisualStyleBackColor = true;
            // 
            // radNoiDKKCB
            // 
            this.radNoiDKKCB.AutoSize = true;
            this.radNoiDKKCB.Location = new System.Drawing.Point(230, 93);
            this.radNoiDKKCB.Name = "radNoiDKKCB";
            this.radNoiDKKCB.Size = new System.Drawing.Size(123, 24);
            this.radNoiDKKCB.TabIndex = 2;
            this.radNoiDKKCB.TabStop = true;
            this.radNoiDKKCB.Text = "Nơi ĐK KCB";
            this.radNoiDKKCB.UseVisualStyleBackColor = true;
            // 
            // radSDT
            // 
            this.radSDT.AutoSize = true;
            this.radSDT.Location = new System.Drawing.Point(230, 153);
            this.radSDT.Name = "radSDT";
            this.radSDT.Size = new System.Drawing.Size(77, 24);
            this.radSDT.TabIndex = 2;
            this.radSDT.TabStop = true;
            this.radSDT.Text = "Số ĐT";
            this.radSDT.UseVisualStyleBackColor = true;
            // 
            // radEmail
            // 
            this.radEmail.AutoSize = true;
            this.radEmail.Location = new System.Drawing.Point(230, 183);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(72, 24);
            this.radEmail.TabIndex = 2;
            this.radEmail.TabStop = true;
            this.radEmail.Text = "Email";
            this.radEmail.UseVisualStyleBackColor = true;
            // 
            // radGioiTinh
            // 
            this.radGioiTinh.AutoSize = true;
            this.radGioiTinh.Location = new System.Drawing.Point(230, 123);
            this.radGioiTinh.Name = "radGioiTinh";
            this.radGioiTinh.Size = new System.Drawing.Size(97, 24);
            this.radGioiTinh.TabIndex = 2;
            this.radGioiTinh.TabStop = true;
            this.radGioiTinh.Text = "Giới Tính";
            this.radGioiTinh.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageIndex = 1;
            this.btnTimKiem.ImageList = this.imageList1;
            this.btnTimKiem.Location = new System.Drawing.Point(533, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "698627-icon-111-search-128.png");
            this.imageList1.Images.SetKeyName(1, "search_icon.png");
            // 
            // dataTimKiem
            // 
            this.dataTimKiem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimKiem.Location = new System.Drawing.Point(18, 417);
            this.dataTimKiem.Name = "dataTimKiem";
            this.dataTimKiem.ReadOnly = true;
            this.dataTimKiem.RowTemplate.Height = 24;
            this.dataTimKiem.Size = new System.Drawing.Size(621, 267);
            this.dataTimKiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số KQ tìm kiếm:";
            // 
            // txtKQTimKiem
            // 
            this.txtKQTimKiem.Enabled = false;
            this.txtKQTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQTimKiem.ForeColor = System.Drawing.Color.Red;
            this.txtKQTimKiem.Location = new System.Drawing.Point(136, 381);
            this.txtKQTimKiem.Name = "txtKQTimKiem";
            this.txtKQTimKiem.Size = new System.Drawing.Size(77, 30);
            this.txtKQTimKiem.TabIndex = 5;
            this.txtKQTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel11);
            this.groupBox2.Controls.Add(this.linkLabel10);
            this.groupBox2.Controls.Add(this.linkLabel9);
            this.groupBox2.Controls.Add(this.linkLabel8);
            this.groupBox2.Controls.Add(this.linkLabel7);
            this.groupBox2.Controls.Add(this.linkLabel6);
            this.groupBox2.Controls.Add(this.linkLabel5);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(658, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 672);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nâng cao";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(15, 478);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(84, 20);
            this.linkLabel11.TabIndex = 0;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "linkLabel1";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(15, 436);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(84, 20);
            this.linkLabel10.TabIndex = 0;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "linkLabel1";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(15, 394);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(84, 20);
            this.linkLabel9.TabIndex = 0;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "linkLabel1";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(15, 352);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(84, 20);
            this.linkLabel8.TabIndex = 0;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "linkLabel1";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(15, 310);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(84, 20);
            this.linkLabel7.TabIndex = 0;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "linkLabel1";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(15, 268);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(84, 20);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "linkLabel1";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(15, 226);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(84, 20);
            this.linkLabel5.TabIndex = 0;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "linkLabel1";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(15, 184);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(84, 20);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel1";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(15, 142);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(84, 20);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(15, 100);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(257, 20);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Nhân viên nào có lương thấp nhất";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(261, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nhân viên nào có lương cao nhất?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmTimKiem
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 696);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtKQTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimKiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDanToc;
        private System.Windows.Forms.RadioButton radTDHV;
        private System.Windows.Forms.RadioButton radChuyenMon;
        private System.Windows.Forms.RadioButton radDiaChi;
        private System.Windows.Forms.RadioButton radNoiSinh;
        private System.Windows.Forms.RadioButton radTenNV;
        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.RadioButton radQuocTich;
        private System.Windows.Forms.RadioButton radTonGiao;
        private System.Windows.Forms.RadioButton radNgaySinh;
        private System.Windows.Forms.RadioButton radNgayNhapLuong;
        private System.Windows.Forms.RadioButton radNgaySuaLuong;
        private System.Windows.Forms.RadioButton radNgayCapBHXH;
        private System.Windows.Forms.RadioButton radLuongCB;
        private System.Windows.Forms.RadioButton radDonVi;
        private System.Windows.Forms.RadioButton radNoiCapBHXH;
        private System.Windows.Forms.RadioButton radNoiDKKCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataTimKiem;
        private System.Windows.Forms.RadioButton radGioiTinh;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.RadioButton radSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}