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
using System.Text.RegularExpressions;

namespace QuanLyXeMay_HoangDung.UserControl
{
    public partial class DanhSachNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLXMEntities db = new QLXMEntities();
        bool addnew = true;
        int errorCode = 0;

        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            gioiTinhComboBox.Enabled = true;
            btnLuu.Enabled = true;
            nhanVienBindingSource.AddNew();
            addnew = true;
            maNVTextEdit.Focus();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            lockcontrol(true);
            ReadOnlyText(true);
            gioiTinhComboBox.Enabled = false;
            LoadDSNV();
            btnLuu.Enabled = false;
        }

        private void LoadDSNV()
        {
            var dsnv = db.NhanViens.Select(s => s).ToList();
            nhanVienBindingSource.DataSource = dsnv;
        }

        private void ReadOnlyText(bool v)
        {
            maNVTextEdit.ReadOnly = v;
            tenNVTextEdit.ReadOnly = v;
            diaChiTextEdit.ReadOnly = v;
            emailTextEdit.ReadOnly = v;
            dienThoaiTextEdit.ReadOnly = v;
        }

        private void lockcontrol(bool v)
        {
            btnThem.Enabled = v;
            btnSua.Enabled = v;
            btnLuu.Enabled = v;
            btnXoa.Enabled = v;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            gioiTinhComboBox.Enabled = true;
            maNVTextEdit.ReadOnly = true;//Không cho sửa mã nhân viên
            btnLuu.Enabled = true;
            addnew = false;
            tenNVTextEdit.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var resuilt = db.NhanViens.Select(s => s).Where(s => s.MaNV.Equals(maNVTextEdit.Text)).FirstOrDefault();
            if (addnew)
            {
                if (resuilt != null)
                {
                    XtraMessageBox.Show("Mã nhân viên vừa tạo đã tồn tại", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maNVTextEdit.Text = "";
                    maNVTextEdit.Focus();
                }
                else
                {
                    if (CheckData())
                    {
                        try
                        {
                            NhanVien nvien = new NhanVien();
                            nvien.MaNV = maNVTextEdit.Text;
                            nvien.TenNV = tenNVTextEdit.Text;
                            nvien.GioiTinh = gioiTinhComboBox.Text;
                            nvien.DiaChi = diaChiTextEdit.Text;
                            nvien.DienThoai = dienThoaiTextEdit.Text;
                            nvien.Email = emailTextEdit.Text;
                            db.NhanViens.Add(nvien);
                            db.SaveChanges();
                            XtraMessageBox.Show("Tạo mới nhân viên thành công!", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSNV();
                            ReadOnlyText(true);
                            gioiTinhComboBox.Enabled = false;
                            lockcontrol(true);
                            
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Tạo mới nhân viên thất bại" + ex.Message, "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            nhanVienBindingSource.EndEdit();
                            resuilt.TenNV = tenNVTextEdit.Text;
                            resuilt.GioiTinh = gioiTinhComboBox.Text;
                            resuilt.DiaChi = diaChiTextEdit.Text;
                            resuilt.DienThoai = dienThoaiTextEdit.Text;
                            resuilt.Email = emailTextEdit.Text;
                            db.SaveChanges();
                            XtraMessageBox.Show("Chỉnh sửa nhân viên thành công!", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSNV();
                            lockcontrol(true);
                            ReadOnlyText(true);
                            gioiTinhComboBox.Enabled = false;
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Chỉnh sửa nhân viên thất bại" + ex.Message, "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        XtraMessageBox.Show("Chưa nhập mã nhân viên", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maNVTextEdit.Focus();
                        break;
                    }
                case 102:
                    {
                        XtraMessageBox.Show("Chưa nhập tên nhân viên", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tenNVTextEdit.Focus();
                        break;
                    }
                case 103:
                    {
                        XtraMessageBox.Show("Số điện thoại không đúng", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dienThoaiTextEdit.Text = "";
                        dienThoaiTextEdit.Focus();
                        break;
                    }
                case 104:
                    {
                        XtraMessageBox.Show("Email không đúng định dạng", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailTextEdit.Text = "";
                        emailTextEdit.Focus();
                        break;
                    }
            }
        }

        public bool CheckData()
        {
            bool OK = true;
            int phone;
            var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (maNVTextEdit.Text == "")//Bỏ trống mã nhân viên
            {
                OK = false;
                errorCode = 101;
            }
            if(tenNVTextEdit.Text == "")//Bỏ trống tên nhân viên
            {
                OK = false;
                errorCode = 102;
            }
            if (dienThoaiTextEdit.Text != "")
            {
                if (dienThoaiTextEdit.Text.Length < 10)
                {
                    OK = false;
                    errorCode = 103;
                }
                if (!int.TryParse(dienThoaiTextEdit.Text, out phone))//Điện thoại không đúng định dạng
                {
                    OK = false;
                    errorCode = 103;
                }
            }
            if (emailTextEdit.Text != "")
            {
                if (!regex.IsMatch(emailTextEdit.Text))//Email không đúng định dạng
                {
                    OK = false;
                    errorCode = 104;
                }
            }
            return OK;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Có thực sự muốn xóa nhân viên: " + tenNVTextEdit.Text + " ?", "Quản lý nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resuilt = db.NhanViens.Select(s => s).Where(s => s.MaNV.Equals(maNVTextEdit.Text)).FirstOrDefault();
                try
                {
                    db.NhanViens.Remove(resuilt);
                    db.SaveChanges();
                    LoadDSNV();
                    XtraMessageBox.Show("Đã xóa xong!", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.Message, "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
