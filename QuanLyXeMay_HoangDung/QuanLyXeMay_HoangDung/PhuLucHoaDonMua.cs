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
    public partial class PhuLucHoaDonMua : DevExpress.XtraEditors.XtraForm
    {
        public static int soluong = 0;
        public static DataTable tblChiTiet;
        public string soHoaDon = "";
        public string maXe = "";
        private int errorCode = 0;

        public PhuLucHoaDonMua()
        {
            InitializeComponent();
        }

        private void PhuLucHoaDonMua_Load(object sender, EventArgs e)
        {
            CreateTable();
            maPNTextEdit.Text = soHoaDon;
            maXeTextEdit.Text = maXe;
            maXeTextEdit.ReadOnly = true;
            maPNTextEdit.ReadOnly = true;
        }

        private void CreateTable()
        {
            tblChiTiet = new DataTable();
            tblChiTiet.Columns.Add("MaXe");
            tblChiTiet.Columns.Add("SoKhung");
            tblChiTiet.Columns.Add("SoMay");
            tblChiTiet.Columns.Add("SoHD");
            chiTietXeDataGridView.DataSource = tblChiTiet;
        }

        private void ReadOnlyText(bool v)
        {
            maXeTextEdit.ReadOnly = v;
            maPNTextEdit.ReadOnly = v;
            soKhungTextEdit.ReadOnly = v;
            soMayTextEdit.ReadOnly = v;
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckValue())
            {
                DataRow row = tblChiTiet.NewRow();
                row[0] = maXeTextEdit.Text;
                row[1] = soKhungTextEdit.Text;
                row[2] = soMayTextEdit.Text;
                row[3] = maPNTextEdit.Text;
                tblChiTiet.Rows.Add(row);
                chiTietXeDataGridView.DataSource = tblChiTiet;
                chiTietXeDataGridView.Refresh();
                XtraMessageBox.Show("Thêm mới thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                soKhungTextEdit.Text = "";
                soMayTextEdit.Text = "";
            }
            else
            {
                PushError();
            }
        }

        private bool CheckValue()
        {
            bool OK = true;
            double sokhung;
            double somay;
            if (soKhungTextEdit.Text != "")
            {
                if (!double.TryParse(soKhungTextEdit.Text, out sokhung))
                {
                    OK = false;
                    errorCode = 103;
                }
            }
            else
            {
                OK = false;
                errorCode = 103;
            }
            if (soMayTextEdit.Text != "")
            {
                if (!double.TryParse(soMayTextEdit.Text, out somay))
                {
                    OK = false;
                    errorCode = 104;
                }
            }
            else
            {
                OK = false;
                errorCode = 104;
            }
            return OK;
        }

        //Thông báo lỗi
        private void PushError()
        {
            switch (errorCode)
            {
                case 103:
                    {
                        XtraMessageBox.Show("Chưa nhập số khung hoặc sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        soKhungTextEdit.Text = "";
                        soKhungTextEdit.Focus();
                        break;
                    }
                case 104:
                    {
                        XtraMessageBox.Show("Chưa nhập số máy hoặc sai định dạng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        soMayTextEdit.Text = "";
                        soMayTextEdit.Focus();
                        break;
                    }
            }
        }

        private void chiTietXeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == chiTietXeDataGridView.Columns["Xoa"].Index)
            {
                try
                {
                    tblChiTiet.Rows.RemoveAt(e.RowIndex);
                    chiTietXeDataGridView.DataSource = tblChiTiet;
                    chiTietXeDataGridView.Refresh();
                    XtraMessageBox.Show("Đã xóa khỏi hóa đơn");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Xóa không thành công!" + ex.Message);
                }
            }
        }

        private void PhuLucHoaDonMua_FormClosing(object sender, FormClosingEventArgs e)
        {
            soluong = tblChiTiet.Rows.Count;
        }
    }
}
