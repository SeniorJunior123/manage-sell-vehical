namespace QuanLyXeMay_HoangDung.UserControl
{
    partial class BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvChiTietHD = new System.Windows.Forms.DataGridView();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonKhach = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.khachHangDataGridView = new System.Windows.Forms.DataGridView();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChonXe = new System.Windows.Forms.Button();
            this.btnAddGioHang = new System.Windows.Forms.Button();
            this.cbbHangXe = new System.Windows.Forms.ComboBox();
            this.cbbMauXe = new System.Windows.Forms.ComboBox();
            this.cbbSoKhung = new System.Windows.Forms.ComboBox();
            this.cbbLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anhXePictureBox = new System.Windows.Forms.PictureBox();
            this.xeDataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.xeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhXePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(544, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 520);
            this.panel1.TabIndex = 0;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Image = global::QuanLyXeMay_HoangDung.Properties.Resources.money;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(162, 458);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(132, 43);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gvChiTietHD);
            this.groupBox3.Controls.Add(this.lbThanhTien);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbMaHD);
            this.groupBox3.Controls.Add(this.lbTenKH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(11, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 427);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // gvChiTietHD
            // 
            this.gvChiTietHD.AllowUserToAddRows = false;
            this.gvChiTietHD.AllowUserToDeleteRows = false;
            this.gvChiTietHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenXe,
            this.MauXe,
            this.SoKhung,
            this.SoMay,
            this.DonGia,
            this.Xoa});
            this.gvChiTietHD.Location = new System.Drawing.Point(6, 99);
            this.gvChiTietHD.Name = "gvChiTietHD";
            this.gvChiTietHD.ReadOnly = true;
            this.gvChiTietHD.RowHeadersVisible = false;
            this.gvChiTietHD.Size = new System.Drawing.Size(422, 289);
            this.gvChiTietHD.TabIndex = 1;
            this.gvChiTietHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChiTietHD_CellContentClick);
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.FillWeight = 110.8629F;
            this.TenXe.HeaderText = "Tên xe";
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            // 
            // MauXe
            // 
            this.MauXe.DataPropertyName = "MauXe";
            this.MauXe.FillWeight = 110.8629F;
            this.MauXe.HeaderText = "Màu xe";
            this.MauXe.Name = "MauXe";
            this.MauXe.ReadOnly = true;
            // 
            // SoKhung
            // 
            this.SoKhung.DataPropertyName = "SoKhung";
            this.SoKhung.FillWeight = 110.8629F;
            this.SoKhung.HeaderText = "Số khung";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            // 
            // SoMay
            // 
            this.SoMay.DataPropertyName = "SoMay";
            this.SoMay.FillWeight = 110.8629F;
            this.SoMay.HeaderText = "Số máy";
            this.SoMay.Name = "SoMay";
            this.SoMay.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.DonGia.FillWeight = 110.8629F;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.FillWeight = 45.68528F;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbThanhTien.Location = new System.Drawing.Point(301, 395);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(52, 17);
            this.lbThanhTien.TabIndex = 0;
            this.lbThanhTien.Text = "0 VND";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành tiền:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbMaHD.ForeColor = System.Drawing.Color.Red;
            this.lbMaHD.Location = new System.Drawing.Point(139, 32);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(0, 18);
            this.lbMaHD.TabIndex = 0;
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbTenKH.Location = new System.Drawing.Point(139, 60);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(0, 14);
            this.lbTenKH.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(25, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 211);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnChonKhach);
            this.groupBox2.Controls.Add(this.btnAddKH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.khachHangDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(10, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn khách hàng";
            // 
            // btnChonKhach
            // 
            this.btnChonKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonKhach.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnChonKhach.Location = new System.Drawing.Point(396, 15);
            this.btnChonKhach.Name = "btnChonKhach";
            this.btnChonKhach.Size = new System.Drawing.Size(121, 35);
            this.btnChonKhach.TabIndex = 4;
            this.btnChonKhach.Text = "Chọn khách";
            this.btnChonKhach.UseVisualStyleBackColor = true;
            this.btnChonKhach.Click += new System.EventHandler(this.btnChonKhach_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddKH.Image = global::QuanLyXeMay_HoangDung.Properties.Resources.add1;
            this.btnAddKH.Location = new System.Drawing.Point(340, 15);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(35, 35);
            this.btnAddKH.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnAddKH, "Thêm khách hàng mới");
            this.btnAddKH.UseVisualStyleBackColor = true;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKH.Location = new System.Drawing.Point(131, 23);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(180, 21);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // khachHangDataGridView
            // 
            this.khachHangDataGridView.AllowUserToAddRows = false;
            this.khachHangDataGridView.AllowUserToDeleteRows = false;
            this.khachHangDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khachHangDataGridView.AutoGenerateColumns = false;
            this.khachHangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.DiaChi,
            this.Column1});
            this.khachHangDataGridView.DataSource = this.khachHangBindingSource;
            this.khachHangDataGridView.Location = new System.Drawing.Point(13, 61);
            this.khachHangDataGridView.Name = "khachHangDataGridView";
            this.khachHangDataGridView.ReadOnly = true;
            this.khachHangDataGridView.RowHeadersVisible = false;
            this.khachHangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachHangDataGridView.Size = new System.Drawing.Size(502, 127);
            this.khachHangDataGridView.TabIndex = 0;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 310);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnChonXe);
            this.groupBox1.Controls.Add(this.btnAddGioHang);
            this.groupBox1.Controls.Add(this.cbbHangXe);
            this.groupBox1.Controls.Add(this.cbbMauXe);
            this.groupBox1.Controls.Add(this.cbbSoKhung);
            this.groupBox1.Controls.Add(this.cbbLoaiXe);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.anhXePictureBox);
            this.groupBox1.Controls.Add(this.xeDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn xe";
            // 
            // btnChonXe
            // 
            this.btnChonXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonXe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChonXe.Location = new System.Drawing.Point(337, 204);
            this.btnChonXe.Name = "btnChonXe";
            this.btnChonXe.Size = new System.Drawing.Size(47, 23);
            this.btnChonXe.TabIndex = 7;
            this.btnChonXe.Text = "Chọn";
            this.btnChonXe.UseVisualStyleBackColor = true;
            this.btnChonXe.Click += new System.EventHandler(this.btnChonXe_Click);
            // 
            // btnAddGioHang
            // 
            this.btnAddGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGioHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddGioHang.Image = global::QuanLyXeMay_HoangDung.Properties.Resources.shopping_cart;
            this.btnAddGioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGioHang.Location = new System.Drawing.Point(337, 241);
            this.btnAddGioHang.Name = "btnAddGioHang";
            this.btnAddGioHang.Size = new System.Drawing.Size(175, 43);
            this.btnAddGioHang.TabIndex = 6;
            this.btnAddGioHang.Text = "Cho vào giỏ hàng";
            this.btnAddGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddGioHang.UseVisualStyleBackColor = true;
            this.btnAddGioHang.Click += new System.EventHandler(this.btnAddGioHang_Click);
            // 
            // cbbHangXe
            // 
            this.cbbHangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHangXe.FormattingEnabled = true;
            this.cbbHangXe.Location = new System.Drawing.Point(95, 136);
            this.cbbHangXe.Name = "cbbHangXe";
            this.cbbHangXe.Size = new System.Drawing.Size(228, 21);
            this.cbbHangXe.TabIndex = 5;
            this.cbbHangXe.SelectedIndexChanged += new System.EventHandler(this.cbbHangXe_SelectedIndexChanged);
            // 
            // cbbMauXe
            // 
            this.cbbMauXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMauXe.FormattingEnabled = true;
            this.cbbMauXe.Location = new System.Drawing.Point(95, 106);
            this.cbbMauXe.Name = "cbbMauXe";
            this.cbbMauXe.Size = new System.Drawing.Size(228, 21);
            this.cbbMauXe.TabIndex = 5;
            this.cbbMauXe.SelectedIndexChanged += new System.EventHandler(this.cbbMauXe_SelectedIndexChanged);
            // 
            // cbbSoKhung
            // 
            this.cbbSoKhung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSoKhung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoKhung.FormattingEnabled = true;
            this.cbbSoKhung.Items.AddRange(new object[] {
            "-Tất cả-",
            "Xe số (côn tự động)",
            "Xe số (côn tay)",
            "Xe tay ga"});
            this.cbbSoKhung.Location = new System.Drawing.Point(390, 205);
            this.cbbSoKhung.Name = "cbbSoKhung";
            this.cbbSoKhung.Size = new System.Drawing.Size(122, 21);
            this.cbbSoKhung.TabIndex = 5;
            this.cbbSoKhung.SelectedIndexChanged += new System.EventHandler(this.cbbSoKhung_SelectedIndexChanged);
            // 
            // cbbLoaiXe
            // 
            this.cbbLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiXe.FormattingEnabled = true;
            this.cbbLoaiXe.Items.AddRange(new object[] {
            "-Tất cả-",
            "Xe số (côn tự động)",
            "Xe số (côn tay)",
            "Xe tay ga"});
            this.cbbLoaiXe.Location = new System.Drawing.Point(95, 76);
            this.cbbLoaiXe.Name = "cbbLoaiXe";
            this.cbbLoaiXe.Size = new System.Drawing.Size(228, 21);
            this.cbbLoaiXe.TabIndex = 5;
            this.cbbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiXe_SelectedIndexChanged);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(95, 18);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(228, 21);
            this.txtMaXe.TabIndex = 4;
            this.txtMaXe.TextChanged += new System.EventHandler(this.txtMaXe_TextChanged);
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(95, 46);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(228, 21);
            this.txtTenXe.TabIndex = 4;
            this.txtTenXe.TextChanged += new System.EventHandler(this.txtTenXe_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hãng xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Màu xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên xe";
            // 
            // anhXePictureBox
            // 
            this.anhXePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anhXePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.xeBindingSource, "AnhXe", true));
            this.anhXePictureBox.Location = new System.Drawing.Point(337, 20);
            this.anhXePictureBox.Name = "anhXePictureBox";
            this.anhXePictureBox.Size = new System.Drawing.Size(175, 175);
            this.anhXePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhXePictureBox.TabIndex = 2;
            this.anhXePictureBox.TabStop = false;
            // 
            // xeDataGridView
            // 
            this.xeDataGridView.AllowUserToAddRows = false;
            this.xeDataGridView.AllowUserToDeleteRows = false;
            this.xeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xeDataGridView.AutoGenerateColumns = false;
            this.xeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.xeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.xeDataGridView.DataSource = this.xeBindingSource;
            this.xeDataGridView.Location = new System.Drawing.Point(10, 166);
            this.xeDataGridView.Name = "xeDataGridView";
            this.xeDataGridView.ReadOnly = true;
            this.xeDataGridView.RowHeadersVisible = false;
            this.xeDataGridView.Size = new System.Drawing.Size(313, 118);
            this.xeDataGridView.TabIndex = 0;
            this.xeDataGridView.SelectionChanged += new System.EventHandler(this.xeDataGridView_SelectionChanged);
            // 
            // xeBindingSource
            // 
            this.xeBindingSource.DataSource = typeof(QuanLyXeMay_HoangDung.Xe);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaXe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã xe";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenXe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên xe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MauSac";
            this.dataGridViewTextBoxColumn3.HeaderText = "Màu sắc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn6.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(QuanLyXeMay_HoangDung.KhachHang);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(1000, 520);
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhXePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox anhXePictureBox;
        private System.Windows.Forms.BindingSource xeBindingSource;
        private System.Windows.Forms.DataGridView xeDataGridView;
        private System.Windows.Forms.ComboBox cbbHangXe;
        private System.Windows.Forms.ComboBox cbbMauXe;
        private System.Windows.Forms.ComboBox cbbLoaiXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnAddGioHang;
        private System.Windows.Forms.ComboBox cbbSoKhung;
        private System.Windows.Forms.Button btnChonXe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView khachHangDataGridView;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnChonKhach;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvChiTietHD;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
