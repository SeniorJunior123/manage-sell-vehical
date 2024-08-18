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
    public partial class DanhSachNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLXMEntities db = new QLXMEntities();
        bool addnew = true;
        private int errorCode = 0;

        public DanhSachNhaCungCap()
        {
            InitializeComponent();
        }

        private void DanhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            lockcontrol(true);
            ReadOnlyText(true);
            LoadDSNCC();
            btnLuu.Enabled = false;
        }

        private void LoadDSNCC()
        {
            var dsncc = db.NhaCungCaps.Select(s => s).ToList();
            nhaCungCapBindingSource.DataSource = dsncc;
        }

        private void ReadOnlyText(bool v)
        {
            maNCCTextEdit.ReadOnly = v;
            tenNCCTextEdit.ReadOnly = v;
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
            maNCCTextEdit.ReadOnly = true;//Không cho sửa mã nhân viên
            btnLuu.Enabled = true;
            addnew = false;
            tenNCCTextEdit.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ReadOnlyText(false);
            lockcontrol(false);
            btnLuu.Enabled = true;
            nhaCungCapBindingSource.AddNew();
            addnew = true;
            maNCCTextEdit.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var resuilt = db.NhaCungCaps.Select(s => s).Where(s => s.MaNCC.Equals(maNCCTextEdit.Text)).FirstOrDefault();
            if (addnew)
            {
                if (resuilt != null)
                {
                    XtraMessageBox.Show("Mã nhà cung cấp vừa tạo đã tồn tại", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maNCCTextEdit.Text = "";
                    maNCCTextEdit.Focus();
                }
                else
                {
                    if (CheckData())
                    {
                        try
                        {
                            NhaCungCap ncc = new NhaCungCap();
                            ncc.MaNCC = maNCCTextEdit.Text;
                            ncc.TenNCC = tenNCCTextEdit.Text;
                            ncc.DiaChi = diaChiTextEdit.Text;
                            ncc.DienThoai = dienThoaiTextEdit.Text;
                            ncc.Email = emailTextEdit.Text;
                            db.NhaCungCaps.Add(ncc);
                            db.SaveChanges();
                            XtraMessageBox.Show("Tạo mới nhà cung cấp thành công!", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSNCC();
                            ReadOnlyText(true);
                            lockcontrol(true);
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Tạo mới nhà cung cấp thất bại" + ex.Message, "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            nhaCungCapBindingSource.EndEdit();
                            resuilt.TenNCC = tenNCCTextEdit.Text;
                            resuilt.DiaChi = diaChiTextEdit.Text;
                            resuilt.DienThoai = dienThoaiTextEdit.Text;
                            resuilt.Email = emailTextEdit.Text;
                            db.SaveChanges();
                            XtraMessageBox.Show("Chỉnh sửa nhà cung cấp thành công!", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDSNCC();
                            lockcontrol(true);
                            ReadOnlyText(true);
                            btnLuu.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Chỉnh sửa nhà cung cấp thất bại" + ex.Message, "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        XtraMessageBox.Show("Chưa nhập mã nhà cung cấp", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maNCCTextEdit.Focus();
                        break;
                    }
                case 102:
                    {
                        XtraMessageBox.Show("Chưa nhập tên nhà cung cấp", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tenNCCTextEdit.Focus();
                        break;
                    }
                case 103:
                    {
                        XtraMessageBox.Show("Số điện thoại không đúng", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dienThoaiTextEdit.Text = "";
                        dienThoaiTextEdit.Focus();
                        break;
                    }
                case 104:
                    {
                        XtraMessageBox.Show("Email không đúng định dạng", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (maNCCTextEdit.Text == "")
            {
                OK = false;
                errorCode = 101;
            }
            if (tenNCCTextEdit.Text == "")
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
            if (XtraMessageBox.Show("Có thực sự muốn xóa nhà cung cấp: " + tenNCCTextEdit.Text + " ?", "Quản lý nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var resuilt = db.NhaCungCaps.Select(s => s).Where(s => s.MaNCC.Equals(maNCCTextEdit.Text)).FirstOrDefault();
                try
                {
                    db.NhaCungCaps.Remove(resuilt);
                    db.SaveChanges();
                    LoadDSNCC();
                    XtraMessageBox.Show("Đã xóa xong!", "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi: " + ex.Message, "Quản lý nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
