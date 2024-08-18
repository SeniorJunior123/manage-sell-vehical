using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyXeMay_HoangDung.Properties;
using System.IO;

namespace QuanLyXeMay_HoangDung.UserControl
{
    public partial class DanhSachXe : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLXMEntities db = new QLXMEntities();
        bool addnew = true;
        int errorCode = 0;
        private static string imagePath = Application.StartupPath + @"\AnhXe\";
        public DanhSachXe()
        {
            InitializeComponent();
        }

        private void Chon_Click(object sender, EventArgs e)
        {
            openImage.InitialDirectory = @"C:\";
            openImage.Title = "Chọn ảnh";
            openImage.CheckFileExists = true;
            openImage.CheckPathExists = true;
            openImage.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF| All files (*.*)|*.*";
            openImage.FilterIndex = 1;
            openImage.RestoreDirectory = true;
            openImage.ReadOnlyChecked = true;
            openImage.ShowReadOnly = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                anhXePictureBox.Image = Image.FromFile(openImage.FileName);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            anhXePictureBox.Image = Resources.motorcycle;
        }

        private void DanhSachXe_Load(object sender, EventArgs e)
        {
            lockcontrol(true);
            lockcombobox(false);
            ReadOnlyText(true);
            LoadDSXe();
            btnLuu.Enabled = false;
            CheckImagePath();
            LoadMauXe();
            LoadHangXe();
        }

        private void LoadHangXe()
        {
            var listHang = db.HangXes.Select(s => s).ToList();
            hangXeComboBox.DataSource = listHang;
            hangXeComboBox.DisplayMember = "TenHang";
            hangXeComboBox.ValueMember = "MaHang";
        }

        private void LoadMauXe()
        {
            var listMau = db.MauXes.Select(s => s).ToList();
            mauSacComboBox.DataSource = listMau;
            mauSacComboBox.DisplayMember = "TenMau";
            mauSacComboBox.ValueMember = "MaMau";
        }

        private void CheckImagePath()
        {
            if(!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }
        }

        private void lockcombobox(bool v)
        {
            mauSacComboBox.Enabled = v;
            loaiXeComboBox.Enabled = v;
            hangXeComboBox.Enabled = v;
        }

        private void LoadDSXe()
        {
            var dsnv = db.Xes.Select(s => s).ToList();
            xeBindingSource.DataSource = dsnv;
        }

        private void ReadOnlyText(bool v)
        {
            maXeTextEdit.ReadOnly = v;
            tenXeTextEdit.ReadOnly = v;
            donGiaTextEdit.ReadOnly = v;
            phanKhoiTextEdit.ReadOnly = v;
        }

        private void lockcontrol(bool v)
        {
            btnThem.Enabled = v;
            btnSua.Enabled = v;
            btnLuu.Enabled = v;
            btnXoa.Enabled = v;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            lockcombobox(true);
            btnLuu.Enabled = true;
            xeBindingSource.AddNew();
            addnew = true;
            maXeTextEdit.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            lockcombobox(true);
            maXeTextEdit.ReadOnly = true;//Không cho sửa mã xe
            btnLuu.Enabled = true;
            addnew = false;
            tenXeTextEdit.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var resuilt = db.Xes.Select(s => s).Where(s => s.MaXe.Equals(maXeTextEdit.Text)).FirstOrDefault();
            if (addnew)
            {
                if (resuilt != null)
                {
                    XtraMessageBox.Show("Mã xe vừa tạo đã tồn tại", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maXeTextEdit.Text = "";
                    maXeTextEdit.Focus();
                }
                else
                {
                    if (CheckData())
                    {
                        try
                        {
                            Xe xe = new Xe();
                            xe.MaXe = maXeTextEdit.Text;
                            xe.TenXe = tenXeTextEdit.Text;
                            xe.LoaiXe = loaiXeComboBox.Text;
                            xe.HangXe = hangXeComboBox.Text;
                            xe.MauSac = mauSacComboBox.Text;
                            xe.PhanKhoi = int.Parse(phanKhoiTextEdit.Text);
                            xe.SoLuong = 0;
                            xe.DonGia = double.Parse(donGiaTextEdit.Text);
                            xe.AnhXe = maXeTextEdit.Text + ".jpg";
                            db.Xes.Add(xe);
                            db.SaveChanges();
                            anhXePictureBox.Image.Save(imagePath + xe.AnhXe);
                            XtraMessageBox.Show("Tạo mới xe thành công!", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSXe();
                            ReadOnlyText(true);
                            lockcombobox(false);
                            lockcontrol(true);
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Tạo mới xe thất bại" + ex.Message, "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        PushError();
                    }
                }
            }
            else
            {
                if (resuilt != null)
                {
                    if (CheckData())
                    {
                        try
                        {
                            xeBindingSource.EndEdit();
                            resuilt.TenXe = tenXeTextEdit.Text;
                            resuilt.LoaiXe = loaiXeComboBox.Text;
                            resuilt.MauSac = mauSacComboBox.Text;
                            resuilt.HangXe = hangXeComboBox.Text;
                            resuilt.PhanKhoi = int.Parse(phanKhoiTextEdit.Text);
                            resuilt.DonGia = double.Parse(donGiaTextEdit.Text);
                            db.SaveChanges();
                            if (File.Exists(imagePath + resuilt.AnhXe))
                            {
                                File.Delete(imagePath + resuilt.AnhXe);
                            }
                            anhXePictureBox.Image.Save(imagePath + resuilt.AnhXe);
                            XtraMessageBox.Show("Chỉnh sửa xe thành công!", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSXe();
                            lockcontrol(true);
                            ReadOnlyText(true);
                            lockcombobox(false);
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Chỉnh sửa xe thất bại" + ex.Message, "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        PushError();
                    }
                }
            }
        }

        //Thông báo lỗi
        private void PushError()
        {
            switch (errorCode)
            {
                case 101:
                    {
                        XtraMessageBox.Show("Chưa nhập mã xe", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maXeTextEdit.Focus();
                        break;
                    }
                case 102:
                    {
                        XtraMessageBox.Show("Chưa nhập tên xe", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tenXeTextEdit.Focus();
                        break;
                    }
                case 103:
                    {
                        XtraMessageBox.Show("Đơn giá không hợp lệ", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        donGiaTextEdit.Text = "";
                        donGiaTextEdit.Focus();
                        break;
                    }
                case 104:
                    {
                        XtraMessageBox.Show("Phân khối không hợp lệ", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        phanKhoiTextEdit.Text = "";
                        phanKhoiTextEdit.Focus();
                        break;
                    }
                case 105:
                    {
                        XtraMessageBox.Show("Không được bỏ trống đơn giá", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        donGiaTextEdit.Focus();
                        break;
                    }
                case 106:
                    {
                        XtraMessageBox.Show("Không được bỏ trống phân khối", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        phanKhoiTextEdit.Focus();
                        break;
                    }
            }
        }

        public bool CheckData()
        {
            bool OK = true;
            double dongia;
            int phankhoi;
            if (maXeTextEdit.Text == "")//Bỏ trống mã xe
            {
                OK = false;
                errorCode = 101;
            }
            if (tenXeTextEdit.Text == "")//Bỏ trống tên xe
            {
                OK = false;
                errorCode = 102;
            }
            if (donGiaTextEdit.Text != "")
            {
                if (!double.TryParse(donGiaTextEdit.Text, out dongia))//Đơn giá không đúng định dạng
                {
                    OK = false;
                    errorCode = 103;
                }
            }
            else
            {
                OK = false;
                errorCode = 105;
            }
            if (phanKhoiTextEdit.Text != "")
            {
                if (!int.TryParse(phanKhoiTextEdit.Text, out phankhoi))//Phân khối xe không đúng định dạng
                {
                    OK = false;
                    errorCode = 104;
                }
            }
            else
            {
                OK = false;
                errorCode = 106;
            }
            return OK;
        }

        private void xeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            anhXePictureBox.ImageLocation = imagePath + maXeTextEdit.Text + ".jpg";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Có thực sự muốn xóa xe: " + tenXeTextEdit.Text + " ?", "Quản lý xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resuilt = db.Xes.Select(s => s).Where(s => s.MaXe.Equals(maXeTextEdit.Text)).FirstOrDefault();
                try
                {
                    db.Xes.Remove(resuilt);
                    db.SaveChanges();
                    LoadDSXe();
                    XtraMessageBox.Show("Đã xóa xong!", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.Message, "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
