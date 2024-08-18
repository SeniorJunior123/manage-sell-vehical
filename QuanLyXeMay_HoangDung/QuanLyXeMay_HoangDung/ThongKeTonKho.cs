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
using Microsoft.Office.Interop.Excel;

namespace QuanLyXeMay_HoangDung
{
    public partial class ThongKeTonKho : DevExpress.XtraEditors.XtraForm
    {
        private static QLXMEntities db = new QLXMEntities();

        public ThongKeTonKho()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void TimKiem()
        {
            string hang, loai, ten, phanKhoi;
            if(cbbHang.SelectedIndex == 0)
            {
                hang = null;
            }
            else
            {
                hang = cbbHang.Text;
            }
            if(cbbLoaiXe.Text == "")
            {
                loai = null;
            }
            else
            {
                loai = cbbLoaiXe.Text;
            }
            if(txtPhanKhoi.Text == "")
            {
                phanKhoi = null;
            }
            else
            {
                phanKhoi = txtPhanKhoi.Text;
            }
            if(txtTenXe.Text == "")
            {
                ten = null;
            }
            else
            {
                ten = txtTenXe.Text;
            }
            var resuilt = db.timkiemTonKho(hang, loai, phanKhoi, ten);
            gvTonKho.DataSource = resuilt;
            for (int i = 0; i < gvTonKho.RowCount; i++)
            {
                gvTonKho.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void ThongKeTonKho_Load(object sender, EventArgs e)
        {
            LoadHangXe();
            TimKiem();
        }

        private void LoadHangXe()
        {
            var listHang = db.HangXes.Select(s => s).ToList();
            HangXe hang = new HangXe();
            hang.MaHang = "0";
            hang.TenHang = "-Chọn hãng xe-";
            listHang.Insert(0, hang);
            cbbHang.DataSource = listHang;
            cbbHang.DisplayMember = "TenHang";
            cbbHang.ValueMember = "MaHang";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "ThongKeTonKho";

            // Tạo phần đầu

            Range head = worksheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = "THỐNG KÊ TỒN KHO";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing header part in Excel  
            for (int i = 1; i < gvTonKho.Columns.Count + 1; i++)
            {
                worksheet.Cells[3, i] = gvTonKho.Columns[i - 1].HeaderText;
            }
            Range rowHead = worksheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < gvTonKho.Rows.Count; i++)
            {
                for (int j = 0; j < gvTonKho.Columns.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = gvTonKho.Rows[i].Cells[j].Value.ToString();
                }
            }
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + gvTonKho.Rows.Count - 1;
            int columnEnd = gvTonKho.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Range c1 = (Range)worksheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu
            Range c2 = (Range)worksheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Range range = worksheet.get_Range(c1, c2);

            // Kẻ viền
            range.Borders.LineStyle = Constants.xlSolid;

            //Tự căn chỉnh động rộng cột
            worksheet.Columns.AutoFit();

            // Lưu file xuống
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (.xlsx)|*.xlsx";
            saveFileDialog.FileName = "ThongKeTonKho_" + DateTime.Now.Date.ToString("ddMMyyyy") + ".xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            // Exit from the application  
            app.Quit();
        }
    }
}