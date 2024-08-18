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
using QuanLyXeMay_HoangDung.Properties;
using QuanLyXeMay_HoangDung.Class;
using ClosedXML.Excel;
using System.Diagnostics;

namespace QuanLyXeMay_HoangDung.UserControl
{
    public partial class MuaHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLXMEntities db = new QLXMEntities();
        private static string imagePath = Application.StartupPath + @"\AnhXe\";
        private static DataTable tbl;
        private static DataTable tblChiTiet;
        private double tongTien = 0;

        public MuaHang()
        {
            InitializeComponent();
        }

        private void MuaHang_Load(object sender, EventArgs e)
        {
            cbbLoaiXe.SelectedIndex = 0;
            LoadMauXe();
            LoadHangXe();
            TimKiemNCC();
            txtTenNCC.Focus();
            CreateTableDetailAvoid();
            TaoBangChiTiet();
        }

        private void TaoBangChiTiet()
        {
            tblChiTiet = new DataTable();
            tblChiTiet.Columns.Add("MaXe");
            tblChiTiet.Columns.Add("SoKhung");
            tblChiTiet.Columns.Add("SoMay");
            tblChiTiet.Columns.Add("SoHD");
        }

        private void LoadMauXe()
        {
            var listMau = db.MauXes.Select(s => s).ToList();
            MauXe mau = new MauXe();
            mau.MaMau = "0";
            mau.TenMau = "-Chọn màu xe-";
            listMau.Insert(0, mau);
            cbbMauXe.DataSource = listMau;
            cbbMauXe.DisplayMember = "TenMau";
            cbbMauXe.ValueMember = "MaMau";
        }

        private void LoadHangXe()
        {
            var listHang = db.HangXes.Select(s => s).ToList();
            HangXe hang = new HangXe();
            hang.MaHang = "0";
            hang.TenHang = "-Chọn hãng xe-";
            listHang.Insert(0, hang);
            cbbHangXe.DataSource = listHang;
            cbbHangXe.DisplayMember = "TenHang";
            cbbHangXe.ValueMember = "MaHang";
        }

        private void TimKiemNCC()
        {
            var ncc = (from n in db.NhaCungCaps
                         where n.TenNCC.Contains(txtTenNCC.Text)
                         && n.MaNCC.Contains(txtMaNCC.Text)
                         select n).ToList();
            nhaCungCapBindingSource.DataSource = ncc;
        }

        private void CreateTableDetailAvoid()
        {
            tbl = new DataTable();
            tbl.Columns.Add("STT");
            tbl.Columns.Add("MaXe");
            tbl.Columns.Add("SoLuong");
            tbl.Columns.Add("DonGia");
            tbl.Columns.Add("ThanhTien");
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            TimKiemNCC();
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
            TimKiemNCC();
        }

        private void TimKiemXe()
        {
            string hang = "";
            string loai = "";
            string mau = "";
            if (cbbHangXe.SelectedIndex != 0)
            {
                hang = cbbHangXe.Text;
            }
            else
            {
                hang = "";
            }
            if (cbbLoaiXe.SelectedIndex != 0)
            {
                loai = cbbLoaiXe.Text;
            }
            else
            {
                loai = "";
            }
            if (cbbMauXe.SelectedIndex != 0)
            {
                mau = cbbMauXe.Text;
            }
            else
            {
                mau = "";
            }
            var dsxe = (from n in db.Xes
                        where n.TenXe.Contains(txtTenXe.Text)
                        && n.MaXe.Contains(txtMaXe.Text)
                        && n.HangXe.Contains(hang)
                        && n.LoaiXe.Contains(loai)
                        && n.MauSac.Contains(mau)
                        select n).ToList();
            xeBindingSource.DataSource = dsxe;
        }

        private void txtMaXe_TextChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void cbbMauXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void cbbHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemXe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            txtMaXe.Focus();
            lbTenNCC.Text = nhaCungCapDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void xeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                anhXePictureBox.ImageLocation = imagePath + xeDataGridView.CurrentRow.Cells[0].Value + ".jpg";
            }
            catch
            {
                anhXePictureBox.Image = Resources.motorcycle;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddGioHang_Click(object sender, EventArgs e)
        {
            string maX = xeDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (lbMaHD.Text == "")
            {
                lbMaHD.Text = HoaDon.SoHoaDonMuaHang();
            }
            PhuLucHoaDonMua phuLucHoaDon = new PhuLucHoaDonMua();
            phuLucHoaDon.soHoaDon = lbMaHD.Text;
            phuLucHoaDon.maXe = xeDataGridView.CurrentRow.Cells[0].Value.ToString();
            phuLucHoaDon.ShowDialog();
            int soluong = PhuLucHoaDonMua.soluong;
            for (int i = 0; i < soluong; i++)
            {
                DataRow rowCT = tblChiTiet.NewRow();
                rowCT[0] = PhuLucHoaDonMua.tblChiTiet.Rows[i][0];
                rowCT[1] = PhuLucHoaDonMua.tblChiTiet.Rows[i][1];
                rowCT[2] = PhuLucHoaDonMua.tblChiTiet.Rows[i][2];
                rowCT[3] = PhuLucHoaDonMua.tblChiTiet.Rows[i][3];
                tblChiTiet.Rows.Add(rowCT);
            }
            double dongia = double.Parse(xeDataGridView.CurrentRow.Cells[3].Value.ToString());
            DataRow row = tbl.NewRow();
            row[0] = tbl.Rows.Count + 1;
            row[1] = xeDataGridView.CurrentRow.Cells[0].Value;
            row[2] = soluong;
            row[3] = dongia;
            row[4] = soluong * dongia;
            tbl.Rows.Add(row);
            gvChiTietHD.DataSource = tbl;
            gvChiTietHD.Refresh();
            tinhTongTien();
            btnThanhToan.Enabled = true;
        }

        private void tinhTongTien()
        {
            tongTien = 0;
            for (int i = 0; i < gvChiTietHD.RowCount; i++)
            {
                tongTien = tongTien + double.Parse(gvChiTietHD.Rows[i].Cells[4].Value.ToString());
            }
            lbThanhTien.Text = tongTien.ToString("#,##0") + " VND";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                //Thêm mới hóa đơn
                PhieuNhap hoadon = new PhieuNhap();
                hoadon.MaPN = lbMaHD.Text;
                hoadon.MaNCC = nhaCungCapDataGridView.CurrentRow.Cells[0].Value.ToString();
                hoadon.MaNV = "NV0001";
                hoadon.NgayNhap = DateTime.Now;
                hoadon.TongTien = tongTien;
                db.PhieuNhaps.Add(hoadon);
                db.SaveChanges();
                //Thêm mới chi tiết hóa đơn
                for (int i = 0; i < gvChiTietHD.RowCount; i++)
                {
                    string soKhung = gvChiTietHD.Rows[i].Cells[3].Value.ToString();
                    string maXe = gvChiTietHD.Rows[i].Cells[1].Value.ToString();
                    int soLuong = int.Parse(gvChiTietHD.Rows[i].Cells[2].Value.ToString());
                    ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                    chiTietPhieuNhap.MaPN = lbMaHD.Text;
                    chiTietPhieuNhap.MaXe = maXe;
                    chiTietPhieuNhap.DonGia = double.Parse(gvChiTietHD.Rows[i].Cells[3].Value.ToString());
                    chiTietPhieuNhap.SoLuong = soLuong;
                    chiTietPhieuNhap.ThanhTien = double.Parse(gvChiTietHD.Rows[i].Cells[4].Value.ToString());
                    db.ChiTietPhieuNhaps.Add(chiTietPhieuNhap);
                    db.SaveChanges();
                    //Cập nhật lại số lượng xe
                    var xe = db.Xes.Select(s => s).Where(s => s.MaXe.Equals(maXe)).FirstOrDefault();
                    xe.SoLuong += 1;
                    db.SaveChanges();
                }
                //Thêm mới chi tiết xe
                for (int j = 0; j < tblChiTiet.Rows.Count; j++)
                {
                    ChiTietXe chiTiet = new ChiTietXe();
                    chiTiet.MaXe = tblChiTiet.Rows[j][0].ToString();
                    chiTiet.SoKhung = tblChiTiet.Rows[j][1].ToString();
                    chiTiet.SoMay = tblChiTiet.Rows[j][2].ToString();
                    chiTiet.MaPN = tblChiTiet.Rows[j][3].ToString();
                    chiTiet.Active = true;
                    db.ChiTietXes.Add(chiTiet);
                    db.SaveChanges();
                }
                XtraMessageBox.Show("Thanh toán thành công!", "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InHoaDon(tbl);
                txtMaXe.Text = "";
                txtMaNCC.Text = "";
                txtTenNCC.Text = "";
                txtTenXe.Text = "";
                lbMaHD.Text = "";
                lbTenNCC.Text = "";
                tbl.Rows.Clear();
                cbbHangXe.SelectedIndex = 0;
                cbbLoaiXe.SelectedIndex = 0;
                cbbMauXe.SelectedIndex = 0;
                btnThanhToan.Enabled = false;
                groupBox2.Enabled = false;
                lbThanhTien.Text = "0 VND";
                tblChiTiet.Rows.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Thanh toán thất bại!" + ex.Message, "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InHoaDon(DataTable dt)
        {
            string path = Application.StartupPath + @"\HoaDon\HoaDonNhapHang.xlsx";
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet ws = wb.Worksheet(1);
            ws.Cell(7, 3).Value = lbTenNCC.Text;
            int row = 10;
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        ws.Cell(i + row, 1).Value = i + 1;
                        ws.Cell(i + row, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 2).Value = dt.Rows[i]["MaXe"].ToString();
                        ws.Cell(i + row, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 3).Value = dt.Rows[i]["SoLuong"].ToString();
                        ws.Cell(i + row, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 4).Value = dt.Rows[i]["DonGia"].ToString();
                        ws.Cell(i + row, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        ws.Cell(i + row, 5).Value = dt.Rows[i]["ThanhTien"].ToString();
                        ws.Cell(i + row, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ws.Cell(dt.Rows.Count + row + 1, 4).Value = "Tổng cộng:";
                ws.Cell(dt.Rows.Count + row + 1, 4).Style.Font.Bold = true;

                ws.Cell(dt.Rows.Count + row + 1, 5).Value = double.Parse(lbThanhTien.Text.Replace(" VND", "").Replace(",", ""));
                ws.Cell(dt.Rows.Count + row + 1, 6).Style.Font.Bold = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel |*.xlsx";
            saveFileDialog.FileName = "HoaDonNhapHang" + "_" + DateTime.Now.ToString("ddMMyyyy") + "_" + lbTenNCC.Text;
            saveFileDialog.ShowDialog();
            string savePath = saveFileDialog.FileName;
            wb.SaveAs(savePath);
            Process.Start(savePath);
        }
    }
}
