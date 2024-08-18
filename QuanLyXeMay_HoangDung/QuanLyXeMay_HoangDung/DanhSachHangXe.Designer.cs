namespace QuanLyXeMay_HoangDung
{
    partial class DanhSachHangXe
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
            System.Windows.Forms.Label maHangLabel;
            System.Windows.Forms.Label tenHangLabel;
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hangXeDataGridView = new System.Windows.Forms.DataGridView();
            this.maHangTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenHangTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            maHangLabel = new System.Windows.Forms.Label();
            tenHangLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangXeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maHangTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHangTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(163, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 42);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(34, 366);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 42);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(163, 295);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 42);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(34, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 42);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tenHangLabel);
            this.groupBox1.Controls.Add(this.tenHangTextEdit);
            this.groupBox1.Controls.Add(maHangLabel);
            this.groupBox1.Controls.Add(this.maHangTextEdit);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 227);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // hangXeDataGridView
            // 
            this.hangXeDataGridView.AllowUserToAddRows = false;
            this.hangXeDataGridView.AllowUserToDeleteRows = false;
            this.hangXeDataGridView.AutoGenerateColumns = false;
            this.hangXeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hangXeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangXeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.hangXeDataGridView.DataSource = this.hangXeBindingSource;
            this.hangXeDataGridView.Location = new System.Drawing.Point(294, 25);
            this.hangXeDataGridView.Name = "hangXeDataGridView";
            this.hangXeDataGridView.ReadOnly = true;
            this.hangXeDataGridView.RowHeadersVisible = false;
            this.hangXeDataGridView.Size = new System.Drawing.Size(318, 404);
            this.hangXeDataGridView.TabIndex = 19;
            // 
            // maHangLabel
            // 
            maHangLabel.AutoSize = true;
            maHangLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            maHangLabel.Location = new System.Drawing.Point(18, 40);
            maHangLabel.Name = "maHangLabel";
            maHangLabel.Size = new System.Drawing.Size(55, 13);
            maHangLabel.TabIndex = 0;
            maHangLabel.Text = "Mã hãng";
            // 
            // maHangTextEdit
            // 
            this.maHangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hangXeBindingSource, "MaHang", true));
            this.maHangTextEdit.Location = new System.Drawing.Point(21, 68);
            this.maHangTextEdit.Name = "maHangTextEdit";
            this.maHangTextEdit.Size = new System.Drawing.Size(213, 20);
            this.maHangTextEdit.TabIndex = 1;
            // 
            // tenHangLabel
            // 
            tenHangLabel.AutoSize = true;
            tenHangLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            tenHangLabel.Location = new System.Drawing.Point(18, 132);
            tenHangLabel.Name = "tenHangLabel";
            tenHangLabel.Size = new System.Drawing.Size(59, 13);
            tenHangLabel.TabIndex = 2;
            tenHangLabel.Text = "Tên hãng";
            // 
            // tenHangTextEdit
            // 
            this.tenHangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hangXeBindingSource, "TenHang", true));
            this.tenHangTextEdit.Location = new System.Drawing.Point(21, 159);
            this.tenHangTextEdit.Name = "tenHangTextEdit";
            this.tenHangTextEdit.Size = new System.Drawing.Size(213, 20);
            this.tenHangTextEdit.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hãng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hãng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // hangXeBindingSource
            // 
            this.hangXeBindingSource.DataSource = typeof(QuanLyXeMay_HoangDung.HangXe);
            // 
            // DanhSachHangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.hangXeDataGridView);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhSachHangXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hãng xe";
            this.Load += new System.EventHandler(this.DanhSachHangXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangXeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maHangTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHangTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit tenHangTextEdit;
        private System.Windows.Forms.BindingSource hangXeBindingSource;
        private DevExpress.XtraEditors.TextEdit maHangTextEdit;
        private System.Windows.Forms.DataGridView hangXeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}