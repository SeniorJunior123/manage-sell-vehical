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
    public partial class DanhSachKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLXMEntities db = new QLXMEntities();
        bool addnew = true;
        int errorCode = 0;
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            lockcontrol(true);
            ReadOnlyText(true);
            LoadDSKH();
            btnLuu.Enabled = false;
        }
        private void LoadDSKH()
        {
            var dsnv = db.KhachHangs.Select(s => s).ToList();
            khachHangBindingSource.DataSource = dsnv;
        }

        private void ReadOnlyText(bool v)
        {
            tenKHTextEdit.ReadOnly = v;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            btnLuu.Enabled = true;
            khachHangBindingSource.AddNew();
            addnew = true;
            tenKHTextEdit.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            btnLuu.Enabled = true;
            addnew = false;
            tenKHTextEdit.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (addnew)
            {
                if (CheckData())
                {
                    try
                    {
                        KhachHang khanh = new KhachHang();
                        khanh.TenKH = tenKHTextEdit.Text;
                        khanh.DiaChi = diaChiTextEdit.Text;
                        khanh.DienThoai = dienThoaiTextEdit.Text;
                        khanh.Email = emailTextEdit.Text;
                        db.KhachHangs.Add(khanh);
                        db.SaveChanges();
                        XtraMessageBox.Show("Tạo mới khách hàng thành công!", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSKH();
                        ReadOnlyText(true);
                        lockcontrol(true);
                        btnLuu.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Tạo mới khách hàng thất bại" + ex.Message, "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PushError();
                }
            }
            else
            {
                int maKH = Convert.ToInt32(khachHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                var resuilt = db.KhachHangs.Select(s => s).Where(s => s.MaKH.Equals(maKH)).FirstOrDefault();
                if (resuilt != null)
                {
                    if (CheckData())
                    {
                        try
                        {
                            khachHangBindingSource.EndEdit();
                            resuilt.TenKH = tenKHTextEdit.Text;
                            resuilt.DiaChi = diaChiTextEdit.Text;
                            resuilt.DienThoai = dienThoaiTextEdit.Text;
                            resuilt.Email = emailTextEdit.Text;
                            db.SaveChanges();
                            XtraMessageBox.Show("Chỉnh sửa thông tin khách hàng thành công!", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSKH();
                            lockcontrol(true);
                            ReadOnlyText(true);
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Chỉnh sửa thông tin khách hàng thất bại" + ex.Message, "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        PushError();
                    }
                }
            }
        }
        public bool CheckData()
        {
            bool OK = true;
            int phone;
            var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (tenKHTextEdit.Text == "")//Bỏ trống tên nhân viên
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

        //Thông báo lỗi
        private void PushError()
        {
            switch (errorCode)
            {
                case 102:
                    {
                        XtraMessageBox.Show("Chưa nhập tên khách hàng", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tenKHTextEdit.Focus();
                        break;
                    }
                case 103:
                    {
                        XtraMessageBox.Show("Số điện thoại không đúng", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dienThoaiTextEdit.Text = "";
                        dienThoaiTextEdit.Focus();
                        break;
                    }
                case 104:
                    {
                        XtraMessageBox.Show("Email không đúng định dạng", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailTextEdit.Text = "";
                        emailTextEdit.Focus();
                        break;
                    }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Có thực sự muốn xóa nhân viên: " + tenKHTextEdit.Text + " ?", "Quản lý khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int maKH = Convert.ToInt32(khachHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                var resuilt = db.KhachHangs.Select(s => s).Where(s => s.MaKH.Equals(maKH)).FirstOrDefault();
                try
                {
                    db.KhachHangs.Remove(resuilt);
                    db.SaveChanges();
                    LoadDSKH();
                    XtraMessageBox.Show("Đã xóa xong!", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.Message, "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
