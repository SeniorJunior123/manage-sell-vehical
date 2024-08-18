using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyXeMay_HoangDung
{
    public partial class DanhSachHangXe : DevExpress.XtraEditors.XtraForm
    {
        private static QLXMEntities db = new QLXMEntities();
        bool addnew = true;

        public DanhSachHangXe()
        {
            InitializeComponent();
        }

        private void DanhSachHangXe_Load(object sender, EventArgs e)
        {
            lockcontrol(true);
            maHangTextEdit.ReadOnly = true;
            tenHangTextEdit.ReadOnly = true;
            LoadDSHang();
            btnLuu.Enabled = false;
        }

        private void LoadDSHang()
        {
            var lishHang = db.HangXes.Select(s => s).ToList();
            hangXeBindingSource.DataSource = lishHang;
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
            maHangTextEdit.ReadOnly = false;
            tenHangTextEdit.ReadOnly = false;
            lockcontrol(false);
            btnLuu.Enabled = true;
            hangXeBindingSource.AddNew();
            addnew = true;
            maHangTextEdit.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tenHangTextEdit.ReadOnly = false;
            lockcontrol(false);
            btnLuu.Enabled = true;
            addnew = false;
            tenHangTextEdit.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var resuilt = db.HangXes.Select(s => s).Where(s => s.MaHang.Equals(maHangTextEdit.Text)).FirstOrDefault();
            if (addnew)
            {
                if (resuilt != null)
                {
                    XtraMessageBox.Show("Mã hãng vừa tạo đã tồn tại", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maHangTextEdit.Text = "";
                    maHangTextEdit.Focus();
                }
                else
                {
                    if (maHangTextEdit.Text == "")
                    {
                        XtraMessageBox.Show("Chưa nhập mã hãng", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maHangTextEdit.Focus();
                    }
                    else
                    {
                        if (tenHangTextEdit.Text == "")
                        {
                            XtraMessageBox.Show("Chưa nhập tên hãng", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tenHangTextEdit.Focus();
                        }
                        else
                        {
                            try
                            {
                                HangXe hang = new HangXe();
                                hang.MaHang = maHangTextEdit.Text;
                                hang.TenHang = tenHangTextEdit.Text;
                                db.HangXes.Add(hang);
                                db.SaveChanges();
                                XtraMessageBox.Show("Tạo mới hãng xe thành công!", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDSHang();
                                maHangTextEdit.ReadOnly = true;
                                tenHangTextEdit.ReadOnly = true;
                                lockcontrol(true);
                                btnLuu.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show("Tạo mới hãng xe thất bại" + ex.Message, "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                if (resuilt != null)
                {
                    if (tenHangTextEdit.Text == "")
                    {
                        XtraMessageBox.Show("Chưa nhập tên hãng", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tenHangTextEdit.Focus();
                    }
                    else
                    {
                        try
                        {
                            hangXeBindingSource.EndEdit();
                            resuilt.TenHang = tenHangTextEdit.Text;
                            db.SaveChanges();
                            XtraMessageBox.Show("Chỉnh sửa hãng xe thành công!", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSHang();
                            lockcontrol(true);
                            tenHangTextEdit.ReadOnly = true;
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Chỉnh sửa hãng xe thất bại" + ex.Message, "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Có thực sự muốn xóa hãng xe: " + tenHangTextEdit.Text + " ?", "Danh sách hãng xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resuilt = db.HangXes.Select(s => s).Where(s => s.MaHang.Equals(maHangTextEdit.Text)).FirstOrDefault();
                try
                {
                    db.HangXes.Remove(resuilt);
                    db.SaveChanges();
                    LoadDSHang();
                    XtraMessageBox.Show("Đã xóa xong!", "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.Message, "Danh sách hãng xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}