using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeMay_HoangDung
{
    public partial class ThemMoiKH : DevExpress.XtraEditors.XtraForm
    {
        private static QLXMEntities db = new QLXMEntities();
        private int errorCode;

        public ThemMoiKH()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemMoiKH_Load(object sender, EventArgs e)
        {
            khachHangBindingSource.AddNew();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                    XtraMessageBox.Show("Tạo mới khách hàng thành công!", "Thêm mới khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Tạo mới khách hàng thất bại" + ex.Message, "Thêm mới khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PushError();
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
    }
}
