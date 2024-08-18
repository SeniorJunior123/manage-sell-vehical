using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeMay_HoangDung
{
    public partial class CauHinhMauXe : DevExpress.XtraEditors.XtraForm
    {
        private static QLXMEntities db = new QLXMEntities();
        bool addnew = true;

        public CauHinhMauXe()
        {
            InitializeComponent();
        }

        private void CauHinhMauXe_Load(object sender, EventArgs e)
        {
            lockcontrol(true);
            maMauTextEdit.ReadOnly = true;
            tenMauTextEdit.ReadOnly = true;
            LoadDSMau();
            btnLuu.Enabled = false;
        }

        private void LoadDSMau()
        {
            var listMau = db.MauXes.Select(s => s).ToList();
            mauXeBindingSource.DataSource = listMau;
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
            maMauTextEdit.ReadOnly = false;
            tenMauTextEdit.ReadOnly = false;
            lockcontrol(false);
            btnLuu.Enabled = true;
            mauXeBindingSource.AddNew();
            addnew = true;
            maMauTextEdit.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tenMauTextEdit.ReadOnly = false;
            lockcontrol(false);
            btnLuu.Enabled = true;
            addnew = false;
            tenMauTextEdit.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var resuilt = db.MauXes.Select(s => s).Where(s => s.MaMau.Equals(maMauTextEdit.Text)).FirstOrDefault();
            if (addnew)
            {
                if (resuilt != null)
                {
                    XtraMessageBox.Show("Mã màu vừa tạo đã tồn tại", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maMauTextEdit.Text = "";
                    maMauTextEdit.Focus();
                }
                else
                {
                    if (maMauTextEdit.Text == "")
                    {
                        XtraMessageBox.Show("Chưa nhập mã màu", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maMauTextEdit.Focus();
                    }
                    else
                    {
                        if (tenMauTextEdit.Text == "")
                        {
                            XtraMessageBox.Show("Chưa nhập tên màu", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tenMauTextEdit.Focus();
                        }
                        else
                        {
                            try
                            {
                                MauXe mau = new MauXe();
                                mau.MaMau = maMauTextEdit.Text;
                                mau.TenMau = tenMauTextEdit.Text;
                                db.MauXes.Add(mau);
                                db.SaveChanges();
                                XtraMessageBox.Show("Tạo mới màu xe thành công!", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDSMau();
                                maMauTextEdit.ReadOnly = true;
                                tenMauTextEdit.ReadOnly = true;
                                lockcontrol(true);
                                btnLuu.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show("Tạo mới màu xe thất bại" + ex.Message, "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                if (resuilt != null)
                {
                    if (tenMauTextEdit.Text == "")
                    {
                        XtraMessageBox.Show("Chưa nhập tên màu", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tenMauTextEdit.Focus();
                    }
                    else
                    {
                        try
                        {
                            mauXeBindingSource.EndEdit();
                            resuilt.TenMau = tenMauTextEdit.Text;
                            db.SaveChanges();
                            XtraMessageBox.Show("Chỉnh sửa màu xe thành công!", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSMau();
                            lockcontrol(true);
                            tenMauTextEdit.ReadOnly = true;
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Chỉnh sửa màu xe thất bại" + ex.Message, "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Có thực sự muốn xóa màu xe: " + tenMauTextEdit.Text + " ?", "Cấu hình màu xe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resuilt = db.MauXes.Select(s => s).Where(s => s.MaMau.Equals(maMauTextEdit.Text)).FirstOrDefault();
                try
                {
                    db.MauXes.Remove(resuilt);
                    db.SaveChanges();
                    LoadDSMau();
                    XtraMessageBox.Show("Đã xóa xong!", "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.Message, "Cấu hình màu xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
