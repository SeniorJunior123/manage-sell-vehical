using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Excel;
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
    public partial class LichSuNhapHang : DevExpress.XtraEditors.XtraForm
    {
        private static QLXMEntities db = new QLXMEntities();

        public LichSuNhapHang()
        {
            InitializeComponent();
        }

        private void LichSuNhapHang_Load(object sender, EventArgs e)
        {
            dateFrom.DateTime = DateTime.Now.Date;
            dateTo.DateTime = DateTime.Now.Date;
        }
        

        private void btnTuanNay_Click(object sender, EventArgs e)
        {
            int soNgay = 0;
            switch(DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    {
                        soNgay = 0;
                        break;
                    }
                case "Tueday":
                    {
                        soNgay = -1;
                        break;
                    }
                case "Wednesday":
                    {
                        soNgay = -2;
                        break;
                    }
                case "Thursday":
                    {
                        soNgay = -3;
                        break;
                    }
                case "Friday":
                    {
                        soNgay = -4;
                        break;
                    }
                case "Saturday":
                    {
                        soNgay = -5;
                        break;
                    }
                case "Sunday":
                    {
                        soNgay = -6;
                        break;
                    }
            }
            dateFrom.DateTime = DateTime.Now.AddDays(soNgay);
            dateTo.DateTime = DateTime.Now.Date;
            TimKiem();
        }

        private void TimKiem()
        {
            var result = db.timKiemLichSuNhapHang(dateFrom.DateTime.Date, dateTo.DateTime.Date);
            viewLichSuNhapBindingSource.DataSource = result;
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dateFrom.DateTime = DateTime.Now.Date;
            dateTo.DateTime = DateTime.Now.Date;
            TimKiem();
        }

        private void btnHomQua_Click(object sender, EventArgs e)
        {
            dateFrom.DateTime = DateTime.Now.AddDays(-1);
            dateTo.DateTime = DateTime.Now.AddDays(-1);
            TimKiem();
        }

        private void dateFrom_EditValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dateTo_EditValueChanged(object sender, EventArgs e)
        {
            if (dateTo.DateTime < dateFrom.DateTime)
            {
                XtraMessageBox.Show("Không được chọn thấp hơn từ ngày", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiem();
            }
        }

        private void btn7Ngay_Click(object sender, EventArgs e)
        {
            dateFrom.DateTime = DateTime.Now.AddDays(-6);
            dateTo.DateTime = DateTime.Now.Date;
            TimKiem();
        }

        private void btnThangNay_Click(object sender, EventArgs e)
        {
            int soNgay = DateTime.Now.Day - 1;
            dateFrom.DateTime = DateTime.Now.AddDays(-soNgay);
            dateTo.DateTime = DateTime.Now.Date;
            TimKiem();
        }

        private void btn30Ngay_Click(object sender, EventArgs e)
        {
            dateFrom.DateTime = DateTime.Now.AddDays(-29);
            dateTo.DateTime = DateTime.Now.Date;
            TimKiem();
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
            worksheet.Name = "ThongKeNhapHang";

            // Tạo phần đầu

            Range head = worksheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "LỊCH SỬ NHẬP HÀNG";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing header part in Excel  
            for (int i = 1; i < viewLichSuNhapDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[3, i] = viewLichSuNhapDataGridView.Columns[i - 1].HeaderText;
            }
            Range rowHead = worksheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < viewLichSuNhapDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < viewLichSuNhapDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 1] = viewLichSuNhapDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + viewLichSuNhapDataGridView.Rows.Count - 1;
            int columnEnd = viewLichSuNhapDataGridView.Columns.Count;

            //Định dạng lại đơn giá, thành tiền
            Range st1 = (Range)worksheet.Cells[rowStart, 4];
            Range st2 = (Range)worksheet.Cells[rowEnd, 5];
            Range soTien = (Range)worksheet.get_Range(st1,st2);
            soTien.NumberFormat = "#,##0 ₫";

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
            saveFileDialog.FileName = "ThongKeNhapHang_" + dateFrom.DateTime.ToString("ddMMyyyy") + " - " + dateTo.DateTime.ToString("ddMMyyyy") + ".xlsx";
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
