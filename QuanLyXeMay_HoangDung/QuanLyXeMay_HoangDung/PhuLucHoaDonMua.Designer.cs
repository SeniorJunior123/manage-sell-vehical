namespace QuanLyXeMay_HoangDung
{
    partial class PhuLucHoaDonMua
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
            System.Windows.Forms.Label maXeLabel;
            System.Windows.Forms.Label soKhungLabel;
            System.Windows.Forms.Label soMayLabel;
            System.Windows.Forms.Label maPNLabel;
            this.chiTietXeDataGridView = new System.Windows.Forms.DataGridView();
            this.maXeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soMayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soKhungTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new System.Windows.Forms.Button();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            maXeLabel = new System.Windows.Forms.Label();
            soKhungLabel = new System.Windows.Forms.Label();
            soMayLabel = new System.Windows.Forms.Label();
            maPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietXeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maXeTextEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maPNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soMayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soKhungTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maXeLabel
            // 
            maXeLabel.AutoSize = true;
            maXeLabel.Location = new System.Drawing.Point(51, 30);
            maXeLabel.Name = "maXeLabel";
            maXeLabel.Size = new System.Drawing.Size(36, 13);
            maXeLabel.TabIndex = 1;
            maXeLabel.Text = "Mã xe";
            // 
            // soKhungLabel
            // 
            soKhungLabel.AutoSize = true;
            soKhungLabel.Location = new System.Drawing.Point(408, 30);
            soKhungLabel.Name = "soKhungLabel";
            soKhungLabel.Size = new System.Drawing.Size(53, 13);
            soKhungLabel.TabIndex = 2;
            soKhungLabel.Text = "Số khung";
            // 
            // soMayLabel
            // 
            soMayLabel.AutoSize = true;
            soMayLabel.Location = new System.Drawing.Point(408, 82);
            soMayLabel.Name = "soMayLabel";
            soMayLabel.Size = new System.Drawing.Size(42, 13);
            soMayLabel.TabIndex = 4;
            soMayLabel.Text = "Số máy";
            // 
            // maPNLabel
            // 
            maPNLabel.AutoSize = true;
            maPNLabel.Location = new System.Drawing.Point(51, 82);
            maPNLabel.Name = "maPNLabel";
            maPNLabel.Size = new System.Drawing.Size(63, 13);
            maPNLabel.TabIndex = 6;
            maPNLabel.Text = "Số hóa đơn";
            // 
            // chiTietXeDataGridView
            // 
            this.chiTietXeDataGridView.AllowUserToAddRows = false;
            this.chiTietXeDataGridView.AllowUserToDeleteRows = false;
            this.chiTietXeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chiTietXeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietXeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.SoKhung,
            this.SoMay,
            this.SoHD,
            this.Xoa});
            this.chiTietXeDataGridView.Location = new System.Drawing.Point(16, 206);
            this.chiTietXeDataGridView.Name = "chiTietXeDataGridView";
            this.chiTietXeDataGridView.ReadOnly = true;
            this.chiTietXeDataGridView.RowHeadersVisible = false;
            this.chiTietXeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.chiTietXeDataGridView.Size = new System.Drawing.Size(776, 257);
            this.chiTietXeDataGridView.TabIndex = 1;
            this.chiTietXeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chiTietXeDataGridView_CellContentClick);
            // 
            // maXeTextEdit
            // 
            this.maXeTextEdit.Location = new System.Drawing.Point(122, 27);
            this.maXeTextEdit.Name = "maXeTextEdit";
            this.maXeTextEdit.Size = new System.Drawing.Size(250, 20);
            this.maXeTextEdit.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(maPNLabel);
            this.groupBox1.Controls.Add(this.maPNTextEdit);
            this.groupBox1.Controls.Add(soMayLabel);
            this.groupBox1.Controls.Add(this.soMayTextEdit);
            this.groupBox1.Controls.Add(soKhungLabel);
            this.groupBox1.Controls.Add(this.soKhungTextEdit);
            this.groupBox1.Controls.Add(this.maXeTextEdit);
            this.groupBox1.Controls.Add(maXeLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // maPNTextEdit
            // 
            this.maPNTextEdit.Location = new System.Drawing.Point(122, 79);
            this.maPNTextEdit.Name = "maPNTextEdit";
            this.maPNTextEdit.Size = new System.Drawing.Size(250, 20);
            this.maPNTextEdit.TabIndex = 7;
            // 
            // soMayTextEdit
            // 
            this.soMayTextEdit.Location = new System.Drawing.Point(476, 79);
            this.soMayTextEdit.Name = "soMayTextEdit";
            this.soMayTextEdit.Size = new System.Drawing.Size(250, 20);
            this.soMayTextEdit.TabIndex = 5;
            // 
            // soKhungTextEdit
            // 
            this.soKhungTextEdit.Location = new System.Drawing.Point(476, 27);
            this.soKhungTextEdit.Name = "soKhungTextEdit";
            this.soKhungTextEdit.Size = new System.Drawing.Size(250, 20);
            this.soKhungTextEdit.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(347, 152);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 38);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.FillWeight = 112.3096F;
            this.MaXe.HeaderText = "Mã xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            // 
            // SoKhung
            // 
            this.SoKhung.DataPropertyName = "SoKhung";
            this.SoKhung.FillWeight = 112.3096F;
            this.SoKhung.HeaderText = "Số khung";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            // 
            // SoMay
            // 
            this.SoMay.DataPropertyName = "SoMay";
            this.SoMay.FillWeight = 112.3096F;
            this.SoMay.HeaderText = "Số máy";
            this.SoMay.Name = "SoMay";
            this.SoMay.ReadOnly = true;
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.FillWeight = 112.3096F;
            this.SoHD.HeaderText = "Mã hóa đơn";
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.FillWeight = 50.76142F;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // PhuLucHoaDonMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 477);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chiTietXeDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhuLucHoaDonMua";
            this.Text = "Phụ lục hóa đơn mua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhuLucHoaDonMua_FormClosing);
            this.Load += new System.EventHandler(this.PhuLucHoaDonMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietXeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maXeTextEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maPNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soMayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soKhungTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView chiTietXeDataGridView;
        private DevExpress.XtraEditors.TextEdit maXeTextEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit maPNTextEdit;
        private DevExpress.XtraEditors.TextEdit soMayTextEdit;
        private DevExpress.XtraEditors.TextEdit soKhungTextEdit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}