namespace QuanLyXeMay_HoangDung
{
    partial class CauHinhMauXe
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
            System.Windows.Forms.Label maMauLabel;
            System.Windows.Forms.Label tenMauLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHinhMauXe));
            this.mauXeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.maMauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenMauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mauXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maMauLabel = new System.Windows.Forms.Label();
            tenMauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mauXeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maMauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mauXeDataGridView
            // 
            this.mauXeDataGridView.AllowUserToAddRows = false;
            this.mauXeDataGridView.AllowUserToDeleteRows = false;
            this.mauXeDataGridView.AutoGenerateColumns = false;
            this.mauXeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mauXeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mauXeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mauXeDataGridView.DataSource = this.mauXeBindingSource;
            this.mauXeDataGridView.Location = new System.Drawing.Point(289, 21);
            this.mauXeDataGridView.Name = "mauXeDataGridView";
            this.mauXeDataGridView.ReadOnly = true;
            this.mauXeDataGridView.RowHeadersVisible = false;
            this.mauXeDataGridView.Size = new System.Drawing.Size(316, 399);
            this.mauXeDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(maMauLabel);
            this.groupBox1.Controls.Add(this.maMauTextEdit);
            this.groupBox1.Controls.Add(tenMauLabel);
            this.groupBox1.Controls.Add(this.tenMauTextEdit);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(161, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 42);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(32, 360);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 42);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(161, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 42);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(32, 289);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // maMauLabel
            // 
            maMauLabel.AutoSize = true;
            maMauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMauLabel.Location = new System.Drawing.Point(15, 43);
            maMauLabel.Name = "maMauLabel";
            maMauLabel.Size = new System.Drawing.Size(51, 13);
            maMauLabel.TabIndex = 0;
            maMauLabel.Text = "Mã màu";
            // 
            // maMauTextEdit
            // 
            this.maMauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mauXeBindingSource, "MaMau", true));
            this.maMauTextEdit.Location = new System.Drawing.Point(14, 70);
            this.maMauTextEdit.Name = "maMauTextEdit";
            this.maMauTextEdit.Size = new System.Drawing.Size(222, 20);
            this.maMauTextEdit.TabIndex = 1;
            // 
            // tenMauLabel
            // 
            tenMauLabel.AutoSize = true;
            tenMauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMauLabel.Location = new System.Drawing.Point(11, 110);
            tenMauLabel.Name = "tenMauLabel";
            tenMauLabel.Size = new System.Drawing.Size(56, 13);
            tenMauLabel.TabIndex = 2;
            tenMauLabel.Text = "Tên màu";
            // 
            // tenMauTextEdit
            // 
            this.tenMauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mauXeBindingSource, "TenMau", true));
            this.tenMauTextEdit.Location = new System.Drawing.Point(14, 139);
            this.tenMauTextEdit.Name = "tenMauTextEdit";
            this.tenMauTextEdit.Size = new System.Drawing.Size(222, 20);
            this.tenMauTextEdit.TabIndex = 3;
            // 
            // mauXeBindingSource
            // 
            this.mauXeBindingSource.DataSource = typeof(QuanLyXeMay_HoangDung.MauXe);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMau";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã màu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMau";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên màu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CauHinhMauXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mauXeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CauHinhMauXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình màu xe";
            this.Load += new System.EventHandler(this.CauHinhMauXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mauXeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maMauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mauXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mauXeBindingSource;
        private System.Windows.Forms.DataGridView mauXeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolTip toolTipClose;
        private DevExpress.XtraEditors.TextEdit maMauTextEdit;
        private DevExpress.XtraEditors.TextEdit tenMauTextEdit;
    }
}