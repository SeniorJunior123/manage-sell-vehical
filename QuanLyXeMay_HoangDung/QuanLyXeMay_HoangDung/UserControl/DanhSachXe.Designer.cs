namespace QuanLyXeMay_HoangDung.UserControl
{
    partial class DanhSachXe
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
            System.Windows.Forms.Label anhXeLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label mauSauLabel;
            System.Windows.Forms.Label maXeLabel;
            System.Windows.Forms.Label phanKhoiLabel;
            System.Windows.Forms.Label tenXeLabel;
            System.Windows.Forms.Label loaiXeLabel;
            System.Windows.Forms.Label hangXeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mauSacComboBox = new System.Windows.Forms.ComboBox();
            this.loaiXeComboBox = new System.Windows.Forms.ComboBox();
            this.anhXePictureBox = new System.Windows.Forms.PictureBox();
            this.ctmAnh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Chon = new System.Windows.Forms.ToolStripMenuItem();
            this.Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.donGiaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maXeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phanKhoiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenXeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.xeDataGridView = new System.Windows.Forms.DataGridView();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HangXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangXeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            anhXeLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            mauSauLabel = new System.Windows.Forms.Label();
            maXeLabel = new System.Windows.Forms.Label();
            phanKhoiLabel = new System.Windows.Forms.Label();
            tenXeLabel = new System.Windows.Forms.Label();
            loaiXeLabel = new System.Windows.Forms.Label();
            hangXeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhXePictureBox)).BeginInit();
            this.ctmAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maXeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanKhoiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenXeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anhXeLabel
            // 
            anhXeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            anhXeLabel.AutoSize = true;
            anhXeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            anhXeLabel.Location = new System.Drawing.Point(651, 31);
            anhXeLabel.Name = "anhXeLabel";
            anhXeLabel.Size = new System.Drawing.Size(46, 13);
            anhXeLabel.TabIndex = 7;
            anhXeLabel.Text = "Ảnh xe";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            donGiaLabel.Location = new System.Drawing.Point(305, 32);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(50, 13);
            donGiaLabel.TabIndex = 9;
            donGiaLabel.Text = "Đơn giá";
            // 
            // mauSauLabel
            // 
            mauSauLabel.AutoSize = true;
            mauSauLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            mauSauLabel.Location = new System.Drawing.Point(305, 124);
            mauSauLabel.Name = "mauSauLabel";
            mauSauLabel.Size = new System.Drawing.Size(53, 13);
            mauSauLabel.TabIndex = 13;
            mauSauLabel.Text = "Màu sắc";
            // 
            // maXeLabel
            // 
            maXeLabel.AutoSize = true;
            maXeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            maXeLabel.Location = new System.Drawing.Point(20, 32);
            maXeLabel.Name = "maXeLabel";
            maXeLabel.Size = new System.Drawing.Size(41, 13);
            maXeLabel.TabIndex = 15;
            maXeLabel.Text = "Mã xe";
            // 
            // phanKhoiLabel
            // 
            phanKhoiLabel.AutoSize = true;
            phanKhoiLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            phanKhoiLabel.Location = new System.Drawing.Point(305, 77);
            phanKhoiLabel.Name = "phanKhoiLabel";
            phanKhoiLabel.Size = new System.Drawing.Size(62, 13);
            phanKhoiLabel.TabIndex = 17;
            phanKhoiLabel.Text = "Phân khối";
            // 
            // tenXeLabel
            // 
            tenXeLabel.AutoSize = true;
            tenXeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            tenXeLabel.Location = new System.Drawing.Point(20, 77);
            tenXeLabel.Name = "tenXeLabel";
            tenXeLabel.Size = new System.Drawing.Size(45, 13);
            tenXeLabel.TabIndex = 21;
            tenXeLabel.Text = "Tên xe";
            // 
            // loaiXeLabel
            // 
            loaiXeLabel.AutoSize = true;
            loaiXeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            loaiXeLabel.Location = new System.Drawing.Point(20, 124);
            loaiXeLabel.Name = "loaiXeLabel";
            loaiXeLabel.Size = new System.Drawing.Size(47, 13);
            loaiXeLabel.TabIndex = 22;
            loaiXeLabel.Text = "Loại xe";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(hangXeLabel);
            this.groupBox1.Controls.Add(this.hangXeComboBox);
            this.groupBox1.Controls.Add(this.mauSacComboBox);
            this.groupBox1.Controls.Add(loaiXeLabel);
            this.groupBox1.Controls.Add(this.loaiXeComboBox);
            this.groupBox1.Controls.Add(anhXeLabel);
            this.groupBox1.Controls.Add(this.anhXePictureBox);
            this.groupBox1.Controls.Add(donGiaLabel);
            this.groupBox1.Controls.Add(this.donGiaTextEdit);
            this.groupBox1.Controls.Add(mauSauLabel);
            this.groupBox1.Controls.Add(maXeLabel);
            this.groupBox1.Controls.Add(this.maXeTextEdit);
            this.groupBox1.Controls.Add(phanKhoiLabel);
            this.groupBox1.Controls.Add(this.phanKhoiTextEdit);
            this.groupBox1.Controls.Add(tenXeLabel);
            this.groupBox1.Controls.Add(this.tenXeTextEdit);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // mauSacComboBox
            // 
            this.mauSacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xeBindingSource, "MauSac", true));
            this.mauSacComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mauSacComboBox.FormattingEnabled = true;
            this.mauSacComboBox.Location = new System.Drawing.Point(389, 121);
            this.mauSacComboBox.Name = "mauSacComboBox";
            this.mauSacComboBox.Size = new System.Drawing.Size(185, 21);
            this.mauSacComboBox.TabIndex = 23;
            // 
            // loaiXeComboBox
            // 
            this.loaiXeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xeBindingSource, "LoaiXe", true));
            this.loaiXeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiXeComboBox.FormattingEnabled = true;
            this.loaiXeComboBox.Items.AddRange(new object[] {
            "Xe số (côn tự động)",
            "Xe số (côn tay)",
            "Xe tay ga"});
            this.loaiXeComboBox.Location = new System.Drawing.Point(87, 121);
            this.loaiXeComboBox.Name = "loaiXeComboBox";
            this.loaiXeComboBox.Size = new System.Drawing.Size(185, 21);
            this.loaiXeComboBox.TabIndex = 2;
            // 
            // anhXePictureBox
            // 
            this.anhXePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anhXePictureBox.ContextMenuStrip = this.ctmAnh;
            this.anhXePictureBox.Image = global::QuanLyXeMay_HoangDung.Properties.Resources.motorcycle;
            this.anhXePictureBox.Location = new System.Drawing.Point(718, 20);
            this.anhXePictureBox.Name = "anhXePictureBox";
            this.anhXePictureBox.Size = new System.Drawing.Size(175, 175);
            this.anhXePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhXePictureBox.TabIndex = 8;
            this.anhXePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.anhXePictureBox, "Chuột phải để thay đổi");
            // 
            // ctmAnh
            // 
            this.ctmAnh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Chon,
            this.Xoa});
            this.ctmAnh.Name = "ctmAnh";
            this.ctmAnh.Size = new System.Drawing.Size(170, 48);
            // 
            // Chon
            // 
            this.Chon.Name = "Chon";
            this.Chon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Chon.Size = new System.Drawing.Size(169, 22);
            this.Chon.Text = "Chọn ảnh";
            this.Chon.Click += new System.EventHandler(this.Chon_Click);
            // 
            // Xoa
            // 
            this.Xoa.Name = "Xoa";
            this.Xoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Xoa.Size = new System.Drawing.Size(169, 22);
            this.Xoa.Text = "Xóa ảnh";
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // donGiaTextEdit
            // 
            this.donGiaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xeBindingSource, "DonGia", true));
            this.donGiaTextEdit.Location = new System.Drawing.Point(389, 29);
            this.donGiaTextEdit.Name = "donGiaTextEdit";
            this.donGiaTextEdit.Size = new System.Drawing.Size(185, 20);
            this.donGiaTextEdit.TabIndex = 4;
            // 
            // maXeTextEdit
            // 
            this.maXeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xeBindingSource, "MaXe", true));
            this.maXeTextEdit.Location = new System.Drawing.Point(87, 29);
            this.maXeTextEdit.Name = "maXeTextEdit";
            this.maXeTextEdit.Size = new System.Drawing.Size(185, 20);
            this.maXeTextEdit.TabIndex = 0;
            // 
            // phanKhoiTextEdit
            // 
            this.phanKhoiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xeBindingSource, "PhanKhoi", true));
            this.phanKhoiTextEdit.Location = new System.Drawing.Point(389, 74);
            this.phanKhoiTextEdit.Name = "phanKhoiTextEdit";
            this.phanKhoiTextEdit.Size = new System.Drawing.Size(185, 20);
            this.phanKhoiTextEdit.TabIndex = 5;
            // 
            // tenXeTextEdit
            // 
            this.tenXeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xeBindingSource, "TenXe", true));
            this.tenXeTextEdit.Location = new System.Drawing.Point(87, 74);
            this.tenXeTextEdit.Name = "tenXeTextEdit";
            this.tenXeTextEdit.Size = new System.Drawing.Size(185, 20);
            this.tenXeTextEdit.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(646, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 38);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(483, 209);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 38);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(320, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 38);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(157, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 38);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.HangXe,
            this.MauSac});
            this.xeDataGridView.DataSource = this.xeBindingSource;
            this.xeDataGridView.Location = new System.Drawing.Point(17, 290);
            this.xeDataGridView.Name = "xeDataGridView";
            this.xeDataGridView.ReadOnly = true;
            this.xeDataGridView.RowHeadersVisible = false;
            this.xeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xeDataGridView.Size = new System.Drawing.Size(919, 219);
            this.xeDataGridView.TabIndex = 16;
            this.xeDataGridView.SelectionChanged += new System.EventHandler(this.xeDataGridView_SelectionChanged);
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Chuột phải để sửa";
            // 
            // HangXe
            // 
            this.HangXe.DataPropertyName = "HangXe";
            this.HangXe.HeaderText = "Hãng xe";
            this.HangXe.Name = "HangXe";
            this.HangXe.ReadOnly = true;
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu sắc";
            this.MauSac.Name = "MauSac";
            this.MauSac.ReadOnly = true;
            // 
            // hangXeLabel
            // 
            hangXeLabel.AutoSize = true;
            hangXeLabel.Location = new System.Drawing.Point(20, 175);
            hangXeLabel.Name = "hangXeLabel";
            hangXeLabel.Size = new System.Drawing.Size(47, 13);
            hangXeLabel.TabIndex = 23;
            hangXeLabel.Text = "Hãng xe";
            // 
            // hangXeComboBox
            // 
            this.hangXeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xeBindingSource, "HangXe", true));
            this.hangXeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hangXeComboBox.FormattingEnabled = true;
            this.hangXeComboBox.Location = new System.Drawing.Point(87, 172);
            this.hangXeComboBox.Name = "hangXeComboBox";
            this.hangXeComboBox.Size = new System.Drawing.Size(185, 21);
            this.hangXeComboBox.TabIndex = 24;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PhanKhoi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phân khối";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LoaiXe";
            this.dataGridViewTextBoxColumn7.HeaderText = "Loại xe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // xeBindingSource
            // 
            this.xeBindingSource.DataSource = typeof(QuanLyXeMay_HoangDung.Xe);
            // 
            // DanhSachXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachXe";
            this.Size = new System.Drawing.Size(952, 527);
            this.Load += new System.EventHandler(this.DanhSachXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhXePictureBox)).EndInit();
            this.ctmAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maXeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanKhoiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenXeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox loaiXeComboBox;
        private System.Windows.Forms.BindingSource xeBindingSource;
        private System.Windows.Forms.PictureBox anhXePictureBox;
        private DevExpress.XtraEditors.TextEdit donGiaTextEdit;
        private DevExpress.XtraEditors.TextEdit maXeTextEdit;
        private DevExpress.XtraEditors.TextEdit phanKhoiTextEdit;
        private DevExpress.XtraEditors.TextEdit tenXeTextEdit;
        private System.Windows.Forms.DataGridView xeDataGridView;
        private System.Windows.Forms.ContextMenuStrip ctmAnh;
        private System.Windows.Forms.ToolStripMenuItem Chon;
        private System.Windows.Forms.ToolStripMenuItem Xoa;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox mauSacComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.ComboBox hangXeComboBox;
    }
}
