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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private static QLXMEntities db = new QLXMEntities();
        public static string username, fullname;
        public static int quyen;
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "")
            {
                var user = db.DangNhaps
             .Where(s => s.TaiKhoan.Equals(txtTaiKhoan.Text, StringComparison.OrdinalIgnoreCase)
                         && s.MatKhau.Equals(txtMatKhau.Text))
             .FirstOrDefault();

                if (user != null)
                {
                    username = txtTaiKhoan.Text;
                    fullname = user.TenDayDu;
                    quyen = int.Parse(user.Quyen + "");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}